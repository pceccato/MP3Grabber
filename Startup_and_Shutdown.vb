Imports System.IO 'for StreamReader & Streamwriter
'Imports Microsoft.VisualBasic.FileIO.FileSystem 'for GetDirectoryInfo, DirectoryInfo, GetFileInfo & FileInfo

Module Startup_and_Shutdown

    Private config_file_path As String
    Private excluded_text_xml_path As String
    Private download_history_xml_path As String
    'Private download_history_s_xml_path As String
    'Private download_history_f_xml_path As String

    Sub initialize_app()

        application_directory = get_application_folder()
        config_file_path = application_directory & "config.ini"
        excluded_text_xml_path = application_directory & "excluded_text.xml"
        download_history_xml_path = application_directory & "download_history.xml"

        initialize_hub()

        mp3_grabber_ds = New DataSet("mp3_grabber_dataset")
        download_history_ds = New DataSet("download_history_dataset")

        load_settings()
        load_xml()

        set_up_current_download_mp3s_datatable()

    End Sub

    Private Sub load_settings()

        Dim config_file_reader As StreamReader
        Dim log_text As String
        Const header_length As Integer = 7

        If GetFileInfo(config_file_path).Exists Then

            config_file_reader = New StreamReader(config_file_path)

            While config_file_reader.Peek <> -1
                log_text = config_file_reader.ReadLine()
                Select Case Microsoft.VisualBasic.Left(log_text, 4)
                    Case "mp3F"
                        mp3_save_folder = Mid(log_text, header_length)
                    Case "PrcF"
                        mp3_processed_folder = Mid(log_text, header_length)
                    Case "RevF"
                        music_review_folder = Mid(log_text, header_length)
                    Case "ArcF"
                        archive_folder = Mid(log_text, header_length)
                    Case "WebF"
                        web_page_save_folder = Mid(log_text, header_length)
                    Case "WebA"
                        web_address_to_download_from = Mid(log_text, header_length)
                    Case "IgO0"
                        ignore_offset_0 = IIf(Mid(log_text, header_length) = "T", True, False)
                    Case "OfID"
                        offset_o_string = Mid(log_text, header_length)
                    Case "SURL"
                        search_URL = Mid(log_text, header_length)
                    Case "AlNm"
                        album_name = Mid(log_text, header_length)
                    Case "AlNo"
                        album_number = Mid(log_text, header_length)
                    Case "RemA"
                        remember_album_number = IIf(Mid(log_text, header_length) = "T", True, False)
                    Case "NoFl"
                        number_of_files_per_album = Mid(log_text, header_length)
                    Case "SkpA"
                        skip_files_with_album_name = IIf(Mid(log_text, header_length) = "T", True, False)
                    Case "NumF"
                        numerate_files = IIf(Mid(log_text, header_length) = "T", True, False)
                    Case "RndF"
                        randomize_files = IIf(Mid(log_text, header_length) = "T", True, False)
                    Case "SetA"
                        write_album_tag = IIf(Mid(log_text, header_length) = "T", True, False)
                End Select
            End While

            config_file_reader.Dispose()
            config_file_reader.Close()

        Else 'There is no configuration file so let's assume this is the first time the application has been run and create default directories.

            first_run_set_up()

        End If

    End Sub

    Private Sub first_run_set_up()

        Dim my_docs_path As String

        my_docs_path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        my_docs_path = my_docs_path & "\"

        Try
            temp_string = my_docs_path & "mp3 Save Folder"
            Directory.CreateDirectory(temp_string)
            mp3_save_folder = temp_string
        Catch
        End Try

        Try
            temp_string = my_docs_path & "mp3 Save Folder\Processed"
            Directory.CreateDirectory(temp_string)
            mp3_processed_folder = temp_string
        Catch
        End Try

        Try
            temp_string = my_docs_path & "mp3 Save Folder\To Review"
            Directory.CreateDirectory(temp_string)
            music_review_folder = temp_string
        Catch
        End Try

        Try
            temp_string = my_docs_path & "mp3 Save Folder\Archive"
            Directory.CreateDirectory(temp_string)
            archive_folder = temp_string
        Catch
        End Try

        Try
            temp_string = my_docs_path & "Web Page Save Folder"
            Directory.CreateDirectory(temp_string)
            web_page_save_folder = temp_string
        Catch
        End Try

    End Sub

    Private Sub load_xml()

        Dim fs As FileStream
        Dim xml_text_reader As System.Xml.XmlTextReader

        If GetFileInfo(excluded_text_xml_path).Exists Then
            fs = New FileStream(excluded_text_xml_path, FileMode.Open, FileAccess.Read)
            xml_text_reader = New System.Xml.XmlTextReader(fs)
            mp3_grabber_ds.ReadXml(xml_text_reader, XmlReadMode.ReadSchema)
            xml_text_reader.Close()
            fs.Close()
            excluded_text_dt = mp3_grabber_ds.Tables("Excluded_Text_Datatable")
        Else
            set_up_excluded_text_datatable()
        End If

        If GetFileInfo(download_history_xml_path).Exists Then
            fs = New FileStream(download_history_xml_path, FileMode.Open, FileAccess.Read)
            xml_text_reader = New System.Xml.XmlTextReader(fs)
            download_history_ds.ReadXml(xml_text_reader, XmlReadMode.ReadSchema)
            xml_text_reader.Close()
            fs.Close()
            download_history_s_dt = download_history_ds.Tables("Download_History_S_Datatable")
            download_history_f_dt = download_history_ds.Tables("Download_History_F_Datatable")
        Else
            set_up_download_history_datatables()
        End If

        'apparently you can use cache, but the Cache that I've got here didn't have the method insert: Cache.insert(NAME,dataset,dependency). I think this might be an ASP.NET thing only.

    End Sub

    Public Sub save_defaults()

        Dim config_file_writer As StreamWriter

        Try
            File.Delete(config_file_path)
        Catch
        End Try

        config_file_writer = File.CreateText(config_file_path)

        config_file_writer.WriteLine("mp3F:_" & mp3_save_folder)
        config_file_writer.WriteLine("PrcF:_" & mp3_processed_folder)
        config_file_writer.WriteLine("RevF:_" & music_review_folder)
        config_file_writer.WriteLine("ArcF:_" & archive_folder)
        config_file_writer.WriteLine("WebF:_" & web_page_save_folder)
        config_file_writer.WriteLine("WebA:_" & web_address_to_download_from)
        config_file_writer.WriteLine("IgO0:_" & IIf(ignore_offset_0 = True, "T", "F")) ' True)
        config_file_writer.WriteLine("OfID:_" & offset_o_string)
        config_file_writer.WriteLine("SURL:_" & search_URL) '"http://www.trackitdown.net/search/keyword?q="
        config_file_writer.WriteLine("AlNm:_" & album_name)
        config_file_writer.WriteLine("AlNo:_" & album_number)
        config_file_writer.WriteLine("RemA:_" & IIf(remember_album_number = True, "T", "F"))
        config_file_writer.WriteLine("NoFl:_" & number_of_files_per_album)
        config_file_writer.WriteLine("SkpA:_" & IIf(skip_files_with_album_name = True, "T", "F")) ' True)
        config_file_writer.WriteLine("NumF:_" & IIf(numerate_files = True, "T", "F")) ' True)
        config_file_writer.WriteLine("RndF:_" & IIf(randomize_files = True, "T", "F")) ' True)
        config_file_writer.WriteLine("SetA:_" & IIf(write_album_tag = True, "T", "F")) ' True)

        config_file_writer.Dispose()
        config_file_writer.Close()

        save_xml()

    End Sub

    Private Sub set_up_excluded_text_datatable()

        Dim col As DataColumn

        excluded_text_dt = New DataTable("Excluded_Text_Datatable")

        col = New DataColumn

        col.ColumnName = "Excluded_Text_ID"
        col.DataType = System.Type.GetType("System.Int32")
        col.ReadOnly = False
        col.Unique = True
        col.AutoIncrement = True

        excluded_text_dt.Columns.Add(col) 'Add a column using a DataColumn object.
        excluded_text_dt.PrimaryKey = {col}

        col = New DataColumn

        col.ColumnName = "Excluded_Text"
        col.DataType = System.Type.GetType("System.String")
        col.ReadOnly = False
        col.Unique = True

        excluded_text_dt.Columns.Add(col) 'Add a column using a DataColumn object.

        col = New DataColumn

        col.ColumnName = "Excluded"
        col.DataType = System.Type.GetType("System.Boolean")
        col.ReadOnly = False
        col.Unique = False
        col.DefaultValue = True
        'col.Caption = "Matt's Caption" - Not sure what a caption does, but I figured it would be worth remembering.

        excluded_text_dt.Columns.Add(col) 'Add a column using a DataColumn object.

        'excluded_text_dt.Columns.Add("Excluded_Text", System.Type.GetType("System.String")) 'Add a column without creating a DataColumn object first.

        mp3_grabber_ds.Tables.Add(excluded_text_dt)

    End Sub

    Sub set_up_download_history_datatables()

        Dim col As DataColumn

        'Create Download History (Succeeded) Table.

        download_history_s_dt = New DataTable("Download_History_S_Datatable")

        add_common_columns_to_datatable(download_history_s_dt)

        col = New DataColumn

        col.ColumnName = "Download_Date"
        col.DataType = System.Type.GetType("System.DateTime")
        col.ReadOnly = False
        col.Unique = False
        
        download_history_s_dt.Columns.Add(col) 'Add a column using a DataColumn object.

        download_history_ds.Tables.Add(download_history_s_dt)

        'Create Download History (Failed) Table.

        download_history_f_dt = download_history_s_dt.Clone
        download_history_f_dt.TableName = "Download_History_F_Datatable"
        download_history_ds.Tables.Add(download_history_f_dt)

    End Sub

    Sub set_up_current_download_mp3s_datatable()

        Dim col As DataColumn

        current_download_mp3s_dt = New DataTable("mp3_Links_Datatable")

        add_common_columns_to_datatable(current_download_mp3s_dt)

        col = New DataColumn

        col.ColumnName = "Download"
        col.DataType = System.Type.GetType("System.Boolean")
        col.ReadOnly = False
        col.Unique = False
        col.DefaultValue = True
        
        current_download_mp3s_dt.Columns.Add(col) 'Add a column using a DataColumn object.

        col = New DataColumn

        col.ColumnName = "Downloaded"
        col.DataType = System.Type.GetType("System.Boolean")
        col.ReadOnly = False
        col.Unique = False
        
        current_download_mp3s_dt.Columns.Add(col) 'Add a column using a DataColumn object.

        col = New DataColumn

        col.ColumnName = "Display"
        col.DataType = System.Type.GetType("System.Boolean")
        col.ReadOnly = False
        col.Unique = False

        current_download_mp3s_dt.Columns.Add(col) 'Add a column using a DataColumn object.

        mp3_grabber_ds.Tables.Add(current_download_mp3s_dt)

        'current_download_mp3s_rws = current_download_mp3s_dt.Rows 'this is redundant because when you reassign the table to its sorted defaultview this object continues looking at the old Table.
        current_download_mp3s_dv = New DataView(current_download_mp3s_dt)
        current_download_mp3s_dv.Sort = "File_Name"

    End Sub

    Private Sub add_common_columns_to_datatable(ByRef dt As DataTable)

        Dim col As DataColumn

        col = New DataColumn

        col.ColumnName = "mp3_Link_ID"
        col.DataType = System.Type.GetType("System.Int32")
        col.ReadOnly = False
        col.Unique = True
        col.AutoIncrement = True

        dt.Columns.Add(col)
        dt.PrimaryKey = {col}

        col = New DataColumn

        col.ColumnName = "Link_URL"
        col.DataType = System.Type.GetType("System.String")
        col.ReadOnly = False
        col.Unique = False 'It is permissable to download the same link twice, and you could fail to download the same link many times.

        dt.Columns.Add(col)

        col = New DataColumn

        col.ColumnName = "File_Name"
        col.DataType = System.Type.GetType("System.String")
        col.ReadOnly = False
        col.Unique = False

        dt.Columns.Add(col)

        col = New DataColumn

        col.ColumnName = "File_Name_Tidied"
        col.DataType = System.Type.GetType("System.String")
        col.ReadOnly = False
        col.Unique = False

        dt.Columns.Add(col)

    End Sub

    Public Sub save_xml()

        Dim fs As System.IO.StreamWriter
        Dim xml_text_writer As System.Xml.XmlTextWriter

        'mp3_grabber_ds.WriteXml(xml_text_writer, XmlWriteMode.WriteSchema) ', XmlReadMode.ReadSchema) 'This writes every DataTable in the DataSet to XML.

        fs = New System.IO.StreamWriter(excluded_text_xml_path, False)
        xml_text_writer = New System.Xml.XmlTextWriter(fs)
        excluded_text_dt.WriteXml(xml_text_writer, XmlWriteMode.WriteSchema)

        xml_text_writer.Close()
        fs.Close()

        'If download_history_ds.Tables.Count > 0 Then
        fs = New System.IO.StreamWriter(download_history_xml_path, False)
        xml_text_writer = New System.Xml.XmlTextWriter(fs)
        download_history_ds.WriteXml(xml_text_writer, XmlWriteMode.WriteSchema)

        xml_text_writer.Close()
        fs.Close()
        'End If

        'apparently you can use cache, but the Cache that I've got here didn't have the method insert: Cache.insert(NAME,dataset,dependency)

    End Sub

End Module
