Option Explicit On

Imports System.IO 'for StreamReader & Streamwriter
Imports Microsoft.VisualBasic.FileIO.FileSystem 'for GetDirectoryInfo, DirectoryInfo, GetFileInfo & FileInfo
Imports System.Net 'for WebClient
Imports System.Data 'for Dataset
Imports HundredMilesSoftware.UltraID3Lib
Imports System.Deployment.Application 'for ApplicationDeployment stuff

'Imports My.Computer.FileSystem 'for GetParentPath, GetName and RenameFile - not necessary. These commands all work without it.

Module mp3_Graber

    'System variables.

    Public application_directory As String
    Private log_file_path As String
    Private web_pages_to_download_from_i As Web_Pages_to_Download_From
    Private web_page_to_download_from_i As Web_Page_to_Download_From
    Private mp3_links As Collection
    Private mp3_links_with_file_names As Links_Collection
    Public number_of_files_in_current_album As Integer
    Private number_of_files_in_current_album_local As Integer
    Private album_number_local As Long
    Private utraID3_i As New UltraID3
    Public cancel_download As Boolean = False
    Public files_already_downloaded As New Collection
    Private related_pages_2nd_sweep As Collection
    Private select_m3ps_to_download_form_i As New Select_mp3s_to_Download_Form
    Public main_form_i As Form
    Public no_more_files_selected As Boolean

    'User selectable options.
    Public ignore_offset_0 As Boolean = True
    Public offset_o_string As String = "offset=0"
    Public search_URL As String = "http://www.trackitdown.net/search/keyword?q="
    Public album_name As String = "To Review"
    Public album_number As Long = 1
    Public remember_album_number As Boolean = True
    Public number_of_files_per_album As Integer = 20
    Public skip_files_with_album_name As Boolean = True
    Public numerate_files As Boolean = True
    Public randomize_files As Boolean = True
    Public write_album_tag As Boolean = True
    Public mp3_grabber_ds As DataSet
    Public excluded_text_dt As DataTable
    Public excluded_text_dv As DataView
    Public download_history_ds As DataSet
    Public download_history_s_dt As DataTable
    Public download_history_f_dt As DataTable 'Can add this later.
    Public current_download_mp3s_dt As DataTable
    Public current_download_mp3s_selected_rws As DataRow()
    Public current_download_mp3s_rws As DataRowCollection
    Public current_download_mp3s_dv As DataView
    Public remove_underscores As Boolean = True

    'Operation fields.
    Public mp3_save_folder As String = ""
    Public mp3_processed_folder As String = ""
    Public music_review_folder As String = ""
    Public archive_folder As String = ""
    Public web_page_save_folder As String = ""
    Public web_address_to_download_from As String = ""

    'Convenience and development variables
    Public message_string As String
    Public temp_string As String
    Public Const do_not_download As Boolean = False 'For development only

    Private log_file_i As log_file

    Public Sub initialize_hub()

        log_file_path = application_directory & "log.txt"
        log_file_i = New log_file(log_file_path)

    End Sub

    Public Sub download_links()

        Dim mp3_link As String
        Dim rw As DataRow

        web_pages_to_download_from_i = New Web_Pages_to_Download_From
        mp3_links = New Collection

        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

        web_page_to_download_from_i = New Web_Page_to_Download_From(web_address_to_download_from, web_page_save_folder)

        check_for_related_pages(web_page_to_download_from_i)

        mp3_links = web_pages_to_download_from_i.get_all_mp3_links

        current_download_mp3s_dt.Clear()

        For Each mp3_link In mp3_links
            If link_contains_excluded_text(mp3_link) Then
                mp3_links.Remove(mp3_link)
            Else
                rw = current_download_mp3s_dt.NewRow

                rw("Link_URL") = mp3_link

                temp_string = extract_file_name_from_mp3_link(mp3_link) 'I will remove underscores from the file name only when I save it as I want to be able to compare historical file names reliably
                rw("File_Name") = temp_string

                temp_string = chop_off_file_name_at_keyword(rw("File_Name"))
                If remove_underscores Then
                    temp_string = Replace(temp_string, "_", " ", , , CompareMethod.Text)
                    temp_string = Replace(temp_string, "-", " ", , , CompareMethod.Text)
                End If
                rw("File_Name_Tidied") = temp_string

                current_download_mp3s_dt.Rows.Add(rw)
                Debug.Print(rw("mp3_Link_ID").ToString)
            End If
        Next

        current_download_mp3s_dt.DefaultView.Sort = "File_Name"
        current_download_mp3s_dt = current_download_mp3s_dt.DefaultView.ToTable()
        initialize_current_download_mp3s_dt()

        System.Windows.Forms.Cursor.Current = Cursors.Default

        If current_download_mp3s_rws.Count > 0 Then
            save_links()
        Else
            message_string = "No mp3 links were found."
            MsgBox(message_string, MsgBoxStyle.Information, "No mp3 Links Found")
        End If

    End Sub

    Private Function link_contains_excluded_text(ByVal string_to_check) As Boolean

        Dim space_placeholders() As String = {" ", "_", "-"}
        Dim excluded_text_with_placeholder As String
        Dim dr As DataRow

        link_contains_excluded_text = False

        For Each dr In excluded_text_dt.Rows

            If dr("Excluded") Then

                For Each placeholder In space_placeholders
                    excluded_text_with_placeholder = Replace(dr("Excluded_Text"), " ", placeholder, , , CompareMethod.Text)
                    If InStr(string_to_check, excluded_text_with_placeholder, CompareMethod.Text) > 0 Then
                        link_contains_excluded_text = True
                        Exit For
                    End If
                Next

            End If

            If link_contains_excluded_text Then Exit For

        Next

    End Function

    Private Sub check_for_related_pages(ByVal web_page_to_check As Web_Page_to_Download_From)

        Dim related_web_pages As Collection
        Dim related_page As Web_Page_to_Download_From
        Dim related_pages_as_objects As New Collection
        Dim extracted_link_info As Object
        Dim related_pages_frm As New Related_Pages_Form
        Dim process_related_pages As Byte

        related_pages_2nd_sweep = New Collection

        related_web_pages = web_page_to_check.get_related_pages
        web_pages_to_download_from_i.add_web_page(web_page_to_check)

        If related_web_pages.Count = 0 Then Exit Sub

        web_pages_to_download_from_i.add_web_page(web_page_to_check)

        related_pages_frm.set_related_pages(related_web_pages)
        Debug.Print("main_form_i Location X: " & main_form_i.Location.X)
        related_pages_frm.Location = get_center_point_of_form(main_form_i, related_pages_frm)
        Debug.Print("related_pages_frm Location X: " & related_pages_frm.Location.X)

        'the location of the related pages Form is moving in a linear fashion with the main form.

        System.Windows.Forms.Cursor.Current = Cursors.Default
        process_related_pages = related_pages_frm.ShowDialog()
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

        If process_related_pages = DialogResult.Yes Then

            For Each extracted_link_info In related_web_pages 'Add all the linked pages to the overall collection.
                temp_string = extracted_link_info(0)
                related_page = New Web_Page_to_Download_From(temp_string, web_page_save_folder)
                If related_page.get_file_path <> "" Then related_pages_as_objects.Add(related_page, temp_string)
            Next

            For Each related_page In related_pages_as_objects

                related_web_pages = related_page.get_related_pages
                related_web_pages = remove_existing_related_pages_from_collection(related_web_pages)

                If related_web_pages.Count > 0 Then
                    For Each extracted_link_info In related_web_pages
                        temp_string = extracted_link_info(0)
                        related_pages_as_objects.Add(New Web_Page_to_Download_From(temp_string, web_page_save_folder), temp_string) 'Add it to the list so it gets check itself for related pages.
                        related_pages_2nd_sweep.Add(extracted_link_info, extracted_link_info(0)) 'Add it to the list that we are going to ask the user for confirmation on.
                    Next
                End If

                web_pages_to_download_from_i.add_web_page(related_page)

            Next

        End If

        If related_pages_2nd_sweep.Count > 0 Then

            related_pages_frm.set_related_pages(related_pages_2nd_sweep)
            related_pages_frm.set_second_sweep_mode(True)

            System.Windows.Forms.Cursor.Current = Cursors.Default
            process_related_pages = related_pages_frm.ShowDialog()
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            If process_related_pages = DialogResult.No Then

                message_string = "I was rather hoping that you wouldn't say that!"
                message_string = message_string & " I haven't actually coded for this possibility yet because it's a bit of a faff to do and I can't imagine why you'd ever want to download from first level related pages but not second level pages and beyond."
                message_string = message_string & " Please drop me a line at matt.lazell@symmetry-it.net and give me the details of your situation."
                message_string = message_string & " The download will now continue with just the links from the page selected" & vbLf & vbLf & "Apologies and Thanks."

            End If

        End If

        related_pages_2nd_sweep = Nothing

    End Sub

    Private Function remove_existing_related_pages_from_collection(ByVal related_web_pages As Collection) As Collection

        Dim related_page_address_in_current_web_page As Object
        Dim related_page_address_from_all_collection As Object
        Dim all_related_web_pages As Collection

        all_related_web_pages = web_pages_to_download_from_i.get_all_related_pages_links

        If related_web_pages.Count > 0 Then
            For Each related_page_address_from_all_collection In all_related_web_pages
                For Each related_page_address_in_current_web_page In related_web_pages
                    If related_page_address_in_current_web_page(0) = related_page_address_from_all_collection(0) Or related_page_address_in_current_web_page(0) = web_address_to_download_from Then
                        related_web_pages.Remove(related_page_address_in_current_web_page(0)) 'This web page has already been dealt with.
                    End If
                Next
            Next
        End If

        remove_existing_related_pages_from_collection = related_web_pages

    End Function

    Private Sub save_links()

        Dim progress_frm As Progress_Form
        Dim rw As DataRow
        Dim link_URL As String
        Dim file_name As String
        Dim mp3_save_path As String
        Dim web_client As New WebClient
        Dim number_of_files_downloaded As Integer
        Dim number_of_files_failed_to_download As Integer
        Dim download_failed As Boolean

        select_m3ps_to_Download_form_i = New Select_mp3s_to_Download_Form
        select_m3ps_to_Download_form_i.Location = get_center_point_of_form(main_form_i, select_m3ps_to_Download_form_i)

        no_more_files_selected = False
        If Not no_more_files_selected Then remove_links_already_saved()
        If Not no_more_files_selected Then remove_duplicate_links()
        If Not no_more_files_selected Then remove_duplicate_links_historical()
        If Not no_more_files_selected Then select_mp3s_for_download()
        If no_more_files_selected Then Exit Sub

        progress_frm = New Progress_Form
        progress_frm.Location = get_center_point_of_form(main_form_i, progress_frm)
        progress_frm.Visible = True

        If do_not_download And Not ApplicationDeployment.IsNetworkDeployed Then
            message_string = "Please note that do not download mode has been selected."
            MsgBox(message_string, MsgBoxStyle.Information, "Do Not Download Mode Activated")
        End If

        'current_download_mp3s_selected_rws = current_download_mp3s_dt.Select("Download = True")

        For Each rw In current_download_mp3s_rws

            file_name = rw("File_Name")
            link_URL = rw("Link_URL")
            mp3_save_path = Main_Form.mp3_save_folder_ctl.Text & "\" & file_name
            'Debug.Print(link_URL)
            'Debug.Print(mp3_save_path)

            progress_frm.mp3_being_processed_ctl.Text = file_name
            progress_frm.mp3_being_processed_ctl.Refresh()
            progress_frm.progress_ctl.Text = number_of_files_downloaded + number_of_files_failed_to_download & " of " & current_download_mp3s_rws.Count
            progress_frm.progress_ctl.Refresh()

            download_failed = False

            If cancel_download Then
                message_string = "The download process has been cancelled."
                MsgBox(message_string, MsgBoxStyle.Information, "Downloads Cancelled")
                Exit For
            End If

            If (Not do_not_download Or ApplicationDeployment.IsNetworkDeployed) = True Then

                mp3_save_path = limit_file_path_to_247(mp3_save_path)
                If remove_underscores Then
                    mp3_save_path = Replace(mp3_save_path, "_", " ", , , CompareMethod.Text)
                    mp3_save_path = Replace(mp3_save_path, "-", " ", , , CompareMethod.Text)
                End If

                If GetFileInfo(mp3_save_path).Exists Then
                    download_failed = True
                Else
                    Try
                        web_client.DownloadFile(link_URL, mp3_save_path)
                        number_of_files_downloaded = number_of_files_downloaded + 1
                    Catch
                        download_failed = True
                    End Try
                End If
            Else
                download_failed = True
            End If

            If download_failed = True Then
                rw("Downloaded") = False
                number_of_files_failed_to_download = number_of_files_failed_to_download + 1
            Else
                rw("Downloaded") = True
            End If

        Next

        progress_frm.Close()

        write_log()

        If number_of_files_failed_to_download = 0 Then
            message_string = number_of_files_downloaded & " files were successfully downloaded."
        ElseIf number_of_files_downloaded = 0 Then
            message_string = number_of_files_failed_to_download & " files failed to download." & vbLf & vbLf
        Else
            message_string = number_of_files_downloaded & " files were successfully downloaded, and " & number_of_files_failed_to_download & " files failed to download."
        End If

        If number_of_files_failed_to_download > 0 Then save_xml()

        MsgBox(message_string, MsgBoxStyle.Information, "mp3 Download Complete")

    End Sub

    Private Function check_there_are_still_mp3s_to_download() As Boolean

        check_there_are_still_mp3s_to_download = False

        If current_download_mp3s_rws.Count < 1 Then
            message_string = "You have unselected all mp3s and therefore the download process will terminate."
            MsgBox(message_string, MsgBoxStyle.Information, "All mp3s Removed from Download")
            no_more_files_selected = True
            check_there_are_still_mp3s_to_download = True
        End If

    End Function

    Private Sub remove_links_already_saved()

        Dim search_file_name As String
        Dim search_results_rw As DataRow()
        Dim rw As DataRow

        'Identifies links whose full file name has been download in the past.

        'search for variations of file name/tidied tune name.
        'to do it with different combos of underscores and dashes you need to loop round comparing results in the different modes. You only need one hit to mark a tune as a duplicate.

        For Each rw In current_download_mp3s_rws
            search_file_name = rw("File_Name")
            search_results_rw = download_history_s_dt.Select("File_Name = '" & single_quote_double_up(rw("File_Name")) & "'")
            If search_results_rw.Count > 0 Then
                rw("Download") = False
                rw("Display") = True
            Else
                rw("Display") = False
            End If
        Next

        'If files_already_downloaded.Count > 0 Then
        If current_download_mp3s_dt.Select("Download = False").Count > 0 Then
            temp_string = "These mp3s have been downloaded before. Please tick any that you want to download again and then click on OK."
            show_select_mp3s_form(temp_string)
        End If

    End Sub

    Private Sub remove_duplicate_links()

        Dim rw As DataRow
        Dim current_file_name_tidied As String = ""
        Dim at_least_one_duplicate_found As Boolean

        For counter = 0 To current_download_mp3s_rws.Count - 1

            rw = current_download_mp3s_rws(counter)

            If current_file_name_tidied = rw("File_Name_Tidied") Then
                rw("Download") = False
                at_least_one_duplicate_found = True
                rw("Display") = True
                If counter <> 0 Then
                    current_download_mp3s_rws(counter - 1)("Display") = True
                End If
            Else
                current_file_name_tidied = rw("File_Name_Tidied")
                rw("Download") = True
                rw("Display") = False
            End If

        Next

        If at_least_one_duplicate_found Then
            temp_string = "The mp3s below have been analysed to identify where there may be multiple instances of the same tune, based on the shortened version of the file name shown, and where this is the case any duplicate instances are unticked. Please tick or untick any mp3s that you want to download and then click on OK."
            show_select_mp3s_form(temp_string)
        End If

        'need a tick all and untick all button.

    End Sub

    Private Sub remove_duplicate_links_historical()

        Dim rw As DataRow
        Dim current_file_name_tidied As String = ""
        Dim search_results_rws As DataRow()

        For Each rw In current_download_mp3s_rws

            search_results_rws = download_history_s_dt.Select("File_Name_Tidied = '" & single_quote_double_up(rw("File_Name_Tidied")) & "'")
            If search_results_rws.Count > 0 Then
                rw("Download") = False
                rw("Display") = True
            Else
                rw("Display") = False
            End If

        Next

        search_results_rws = current_download_mp3s_dt.Select("Download = False")

        If search_results_rws.Count > 0 Then
            temp_string = "The following mp3s have been matched to previously downloaded mp3s on the basis of the shortened version of the file name shown. Please tick any of these mp3s that you still want to download despite this duplication match and then click on OK."
            show_select_mp3s_form(temp_string)
        End If

    End Sub

    Private Sub select_mp3s_for_download()

        Dim rw As DataRow

        For Each rw In current_download_mp3s_rws
            rw("Display") = True
        Next

        temp_string = "These are the mp3s that will be downloaded. Please untick any that you do not want to be download and then click on OK."
        show_select_mp3s_form(temp_string)

    End Sub

    Private Sub show_select_mp3s_form(ByVal display_text As String)

        select_m3ps_to_download_form_i.main_label_lbl.Text = display_text
        System.Windows.Forms.Cursor.Current = Cursors.Default
        select_m3ps_to_download_form_i.ShowDialog()
        remove_rows_where_download_equals_false()
        If Not check_there_are_still_mp3s_to_download() Then System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

    End Sub

    Private Sub remove_rows_where_download_equals_false()

        Dim counter As Integer
        Dim rw As DataRow

        For counter = current_download_mp3s_rws.Count - 1 To 0 Step -1
            rw = current_download_mp3s_rws(counter)
            If rw("Download") = False Then
                rw.Delete()
            Else
                rw("Display") = True
            End If
        Next

        'current_download_mp3s_dt = current_download_mp3s_dt.Select("Download = True").CopyToDataTable 'This doesn't copy across all the Table structure. It just makes a new Table which can contain the data in the Rows.
        'initialize_current_download_mp3s_dt()

        For Each rw In current_download_mp3s_rws
            rw("Display") = True
        Next

    End Sub

    Private Sub initialize_current_download_mp3s_dt()

        current_download_mp3s_dv = New DataView(current_download_mp3s_dt) 'I have to recreate the DataView each time because if the source Table has been mapped to another Table the DataView continues looking at the old Table.
        current_download_mp3s_dv.Sort = "File_Name"
        current_download_mp3s_dt.PrimaryKey = {current_download_mp3s_dt.Columns("mp3_Link_ID")}
        current_download_mp3s_rws = current_download_mp3s_dt.Rows

    End Sub

    Private Sub print_off_DataTable_contents(ByVal dt As DataTable)

        Dim rw As DataRow

        For Each rw In dt.Rows
            Debug.Print(dt.Rows.IndexOf(rw) & " - " & rw("File_Name"))
        Next

    End Sub

    Private Function chop_off_file_name_at_keyword(ByVal file_name As String) As String

        Dim keywords() As String = {"remix", "mix", "vocal", "instrumental"}
        Dim keyword As String
        Dim position_of_keyword As Integer

        chop_off_file_name_at_keyword = file_name

        For Each keyword In keywords
            position_of_keyword = InStrRev(file_name, keyword, , CompareMethod.Text)
            If position_of_keyword > 0 Then
                chop_off_file_name_at_keyword = Left(file_name, position_of_keyword + Len(position_of_keyword) - 2)
                Exit For
            End If
        Next

    End Function

    Private Sub write_log()

        Dim rw As DataRow
        Dim rw_new As DataRow
        Dim log_table As DataTable

        For Each rw In current_download_mp3s_rws

            If rw("Downloaded") = True Then
                log_table = download_history_s_dt
            Else
                log_table = download_history_f_dt
            End If

            rw_new = log_table.NewRow()

            rw_new("Link_URL") = rw("Link_URL")
            rw_new("File_Name") = rw("File_Name")
            rw_new("File_Name_Tidied") = rw("File_Name_Tidied")
            rw_new("Download_Date") = Now()

            log_table.Rows.Add(rw_new)

        Next

        'log_file_i.write_log(mp3s_successfully_saved, False)
        'log_file_i.write_log(mp3s_not_saved, True)

        'log_file_i.write_log("")

    End Sub

    Public Sub process_files()

        Dim key As Single
        Dim fi As FileInfo
        Dim files As Array
        Dim file_and_key_combo As KeyValuePair(Of Double, String)
        Dim randomized_list As New SortedDictionary(Of Double, String)
        Dim file_name As String
        Dim file_path As String
        Dim fol_src As New DirectoryInfo(mp3_save_folder)
        Dim fol_dest As New DirectoryInfo(mp3_processed_folder)
        Dim count As Integer

        message_string = ""

        If Not fol_src.Exists Then
            message_string = "I'm sorry, but the mp3 Save Folder '" & single_quote_double_up(mp3_save_folder) & "' cannot be found"
        ElseIf Not fol_dest.Exists Then
            message_string = "I'm sorry, but the Processed mp3s Folder '" & single_quote_double_up(mp3_processed_folder) & "' cannot be found"
        End If

        If message_string <> "" Then
            MsgBox(message_string, MsgBoxStyle.Information, "Folder Not Found")
            Exit Sub
        End If

        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

        files = fol_src.GetFiles

        key = 0

        For Each fi In files
            If numerate_files AndAlso randomize_files Then 'The check for numerate_files is not really necessary as without it the files will be copied in a random order but still have their unrandomize names, but I thought worth including for the sake of internal consistency.
                key = Rnd()
            Else
                key = key + 1
            End If
            randomized_list.Add(key, fi.FullName)
        Next

        count = 0

        If write_album_tag Then
            If remember_album_number Then
                album_number_local = album_number
                number_of_files_in_current_album_local = number_of_files_in_current_album
            Else
                album_number_local = 1
                number_of_files_in_current_album_local = 0
            End If
        End If

        For Each file_and_key_combo In randomized_list
            If numerate_files Then
                file_name = (count + 1).ToString("0000") & " - " & GetName(file_and_key_combo.Value) 'MSDN says this should work. http://msdn.microsoft.com/en-us/library/0c899ak8.aspx
            Else
                file_name = GetName(file_and_key_combo.Value)
            End If
            file_path = mp3_processed_folder & "\" & file_name
            file_path = limit_file_path_to_247(file_path, True)
            'Debug.Print("File length: " & Len(file_path) & " - " & file_path)
            MoveFile(file_and_key_combo.Value, file_path)
            If write_album_tag Then update_album_tags(file_path)
            count = count + 1
        Next

        If count = 0 Then
            message_string = "No files were found to process."
        Else
            message_string = count & " files were successfully processed."
        End If

        If remember_album_number Then
            album_number = album_number_local
            number_of_files_in_current_album = number_of_files_in_current_album_local
        End If

        System.Windows.Forms.Cursor.Current = Cursors.Default

        MsgBox(message_string, MsgBoxStyle.Information, "mp3s Processed Report")

    End Sub

    Public Sub update_album_tags(ByVal file_path As String)

        Dim current_album_name As String

        Try

            With utraID3_i

                .Read(file_path)

                Dim Errors As ID3MetaDataException() = utraID3_i.GetExceptions(ID3ExceptionLevels.Error)
                Dim Warnings As ID3MetaDataException() = utraID3_i.GetExceptions(ID3ExceptionLevels.Warning)

                If Errors.Length > 0 Then Debug.Print(Errors.ToString)
                If Warnings.Length > 0 Then Debug.Print(Warnings.ToString)

                .ID3v1Tag.WriteFlag = True 'Add tickboxes to select which tags to write to.
                .ID3v23Tag.WriteFlag = True

                If Not skip_files_with_album_name Or (InStr(.ID3v1Tag.Album, album_name, CompareMethod.Text) = 0 AndAlso InStr(.ID3v23Tag.Album, album_name, CompareMethod.Text) = 0) Then

                    current_album_name = get_current_album_name()

                    If .ID3v1Tag.WriteFlag Then .ID3v1Tag.Album = current_album_name
                    If .ID3v23Tag.WriteFlag Then .ID3v23Tag.Album = current_album_name

                    .Write()

                End If

            End With

        Catch exc As Exception

            MsgBox(exc.Message)

        End Try

    End Sub

    Private Function get_current_album_name() As String

        If number_of_files_in_current_album_local >= number_of_files_per_album Then 'Note it should never be greater than but thought I ought to put it in just in case.
            number_of_files_in_current_album_local = 1
            album_number_local = album_number_local + 1
        Else
            number_of_files_in_current_album_local = number_of_files_in_current_album_local + 1
        End If

        get_current_album_name = album_name & " " & album_number_local

    End Function

    Public Sub move_mp3s_to_review_folder()

        Dim fl As FileInfo
        Dim fol_src As New DirectoryInfo(mp3_processed_folder)
        Dim fol_dest As New DirectoryInfo(music_review_folder)
        Dim count_s As Integer
        Dim count_f As Integer

        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

        message_string = ""

        If Not fol_src.Exists Then
            message_string = "I'm sorry, but the Processed mp3s Folder '" & single_quote_double_up(mp3_processed_folder) & "' cannot be found"
        ElseIf Not fol_dest.Exists Then
            message_string = "I'm sorry, but the Music Review Folder '" & single_quote_double_up(music_review_folder) & "' cannot be found"
        End If

        If message_string <> "" Then
            MsgBox(message_string, MsgBoxStyle.Information, "Folder Not Found")
            Exit Sub
        End If

        For Each fl In fol_src.GetFiles
            Try 'The copy may fail if the source file is longer than 247 or if it is opened exclusively by another process.
                temp_string = music_review_folder & "\" & fl.Name
                temp_string = limit_file_path_to_247(temp_string, True)
                fl.CopyTo(temp_string)
                temp_string = archive_folder & "\" & fl.Name
                'Debug.Print(temp_string)
                temp_string = limit_file_path_to_247(temp_string, True)
                'Debug.Print(temp_string)
                fl.MoveTo(temp_string)
                count_s = count_s + 1
            Catch
                count_f = count_f + 1
            End Try
        Next

        If count_s = 0 And count_f = 0 Then
            message_string = "No files were found in the Processed mp3s Folder."
        ElseIf count_f = 0 Then
            message_string = count_s & " files were moved from the Processed mp3s Folder to the Music Review Folder."
        ElseIf count_s = 0 Then
            message_string = count_f & " files were not moved from the Processed mp3s Folder to the Music Review Folder."
        Else
            message_string = count_s & " files were moved and " & count_f & " files were not moved from the Processed mp3s Folder to the Music Review Folder."
        End If

        System.Windows.Forms.Cursor.Current = Cursors.Default

        MsgBox(message_string, MsgBoxStyle.Information, "Move to Review Folder Report")

    End Sub

End Module
