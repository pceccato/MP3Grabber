Option Explicit On

Imports System.IO 'for file stuff.
Imports Microsoft.VisualBasic.FileIO.FileSystem 'for GetDirectoryInfo, DirectoryInfo, GetFileInfo & FileInfo
Imports System.Net 'for WebClient

Public Class Web_Page_to_Download_From

    Private mp3_links As Collection
    Private related_web_pages As Collection 'Make this a collection of web_page_to_download_from objects.
    Private web_address_i As String
    Private web_file_path_i As String
    Private web_page_save_folder_i As String
    Private web_text As String
    Private message_string As String
    Private web_page_file As StreamReader
    Private mp3_links_have_been_grabbed As Boolean
    Private related_pages_links_have_been_grabbed As Boolean = False

    Public Sub New(ByVal web_address As String, ByVal website_copy_save_folder As String)

        default_constructor()

        web_page_save_folder_i = website_copy_save_folder
        If set_web_address(web_address) Then load_web_text()

    End Sub

    Private Sub default_constructor()

    End Sub

    Private Sub grab_links() 'NOT BEING USED

        grab_mp3_links()
        grab_related_pages_links()

        mp3_links_have_been_grabbed = True

    End Sub

    Private Sub load_web_text()

        web_page_file = File.OpenText(web_file_path_i)
        web_text = web_page_file.ReadToEnd

    End Sub

    Private Sub grab_mp3_links()

        Dim position_of_hyperlink As Long
        Dim position_of_mp3 As Long
        Dim position_of_space As Long
        Dim extracted_link As String

        mp3_links = New Collection

        'If web_address_i = "" Then
        ' message_string = "No web address has been set!"
        ' MsgBox(message_string, MsgBoxStyle.Information, "No Address Set")
        'Exit Sub
        'End If

        position_of_mp3 = 0

        Do

            position_of_mp3 = InStr(position_of_mp3 + 1, web_text, ".mp3", CompareMethod.Text)
            If position_of_mp3 > 0 Then
                position_of_hyperlink = InStrRev(web_text, "<A href=", position_of_mp3, CompareMethod.Text)
                If position_of_hyperlink > 0 Then
                    position_of_space = InStr(position_of_hyperlink + 4, web_text, " ", CompareMethod.Text)
                    If position_of_space >= position_of_mp3 Or position_of_space = 0 Then 'The hyperlink we've found is (probably) for an mp3 file.
                        extracted_link = Trim(Mid(web_text, position_of_hyperlink + 9, position_of_mp3 - position_of_hyperlink - 5))
                        If Not mp3_links.Contains(extracted_link) Then mp3_links.Add(extracted_link, extracted_link) 'If this is after the key perhaps it can't look up the contents.
                    Else
                        position_of_hyperlink = InStrRev(web_text, "http:", position_of_mp3, CompareMethod.Text)
                        If position_of_hyperlink > 0 Then
                            position_of_space = InStr(position_of_hyperlink, web_text, " ", CompareMethod.Text)
                            If position_of_space >= position_of_mp3 Or position_of_space = 0 Then 'The hyperlink we've found is (probably) for an mp3 file.
                                extracted_link = Trim(Mid(web_text, position_of_hyperlink, position_of_mp3 - position_of_hyperlink + 4))
                                If Not mp3_links.Contains(extracted_link) Then mp3_links.Add(extracted_link, extracted_link) 'If this is after the key perhaps it can't look up the contents.
                            End If
                        End If
                    End If    
                End If
            End If

        Loop Until position_of_mp3 = 0

        'MsgBox("Adding Debug Links")
        'extracted_link = "http://player.trackitdown.net/preview/1582776/preview_dj-ino-featuring-silent-djazz-for-the-love-of-you-extended-smooth-mix-house-cafe-music.mp3"
        'mp3_links.Add(extracted_link, extracted_link)
        'extracted_link = "http://player.trackitdown.net/preview/509158/preview_goema-captains-of-cape-town-healing-destination-troydons-destination-for-healing-mix-downsouth-music.mp3"
        'mp3_links.Add(extracted_link, extracted_link)

        For Each extracted_link In mp3_links
            Debug.Print("Link: ")
            Debug.Print(extracted_link)
        Next

        mp3_links_have_been_grabbed = True

    End Sub

    Sub grab_related_pages_links()

        Dim position_of_hyperlink_start As Long
        Dim position_of_hyperlink_end As Long
        Dim test_char As Char
        Dim counter As Integer
        Dim extracted_link As String
        Dim extracted_page_number As Integer
        Dim extracted_page_number_string As String
        Dim extracted_link_info As Object

        related_web_pages = New Collection

        position_of_hyperlink_start = 0

        'Debug.Print(Mid(web_text, 2000, 500))
        'web_text = "<span class=""currentpage"">1</span><a href=""/genre/tech_house_minimal/top10.html?offset=20"">2</a><a href=""/genre/tech_house_minimal/top10.html?offset=40"">3</a><a href=""/genre/tech_house_minimal/top10.html?offset=60"">4</a><a href=""/genre/tech_house_minimal/top10.html?offset=80"">5</a><a class=""next"" href=""/genre/tech_house_minimal/top10.html?offset=20"">Next</a></div>"

        Do

            position_of_hyperlink_start = InStr(position_of_hyperlink_start + 1, web_text, "<A href=", CompareMethod.Text)
            If position_of_hyperlink_start > 0 Then
                position_of_hyperlink_end = InStr(position_of_hyperlink_start, web_text, ">", CompareMethod.Text)
                If position_of_hyperlink_end > 0 Then 'This should always be true in well formed HTML.
                    counter = 1
                    test_char = Mid(web_text, position_of_hyperlink_end + counter, 1) 'skip other tags (e.g. <a href="/"><span>Music</span></a>). If necessary/possible?
                    Do
                        counter = counter + 1
                        test_char = Mid(web_text, position_of_hyperlink_end + counter, 1)
                    Loop Until Not IsNumeric(test_char) Or test_char = "<"
                    If test_char = "<" Then
                        extracted_link = Trim(Mid(web_text, position_of_hyperlink_start + 9, position_of_hyperlink_end - position_of_hyperlink_start - 10))
                        extracted_link = create_well_formed_web_link(extracted_link, get_web_address)
                        If (ignore_offset_0 And InStr(extracted_link, offset_o_string) = 0 Or Not ignore_offset_0) Then
                            If Not related_web_pages.Contains(extracted_link) Then
                                'Debug.Print(Mid(web_text, (position_of_hyperlink_end + 1) - 100, (counter - 1) + 200))
                                extracted_page_number_string = Mid(web_text, position_of_hyperlink_end + 1, counter - 1)
                                If IsNumeric(extracted_page_number_string) Then
                                    extracted_page_number = extracted_page_number_string
                                    related_web_pages.Add({extracted_link, extracted_page_number}, extracted_link)
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Loop Until position_of_hyperlink_start = 0

        For Each extracted_link_info In related_web_pages
            extracted_link = extracted_link_info(1)
            If Not check_number_is_within_range_of_others(extracted_link) Then
                extracted_link = extracted_link_info(0)
                related_web_pages.Remove(extracted_link)
            End If
        Next

        For Each extracted_link_info In related_web_pages
            Debug.Print("Page: " & extracted_link_info(1) & " is on page " & extracted_link_info(0))
        Next

        related_pages_links_have_been_grabbed = True

    End Sub

    Public Function check_number_is_within_range_of_others(ByVal page_number As Long) As Boolean

        Dim extracted_link_info As Object
        Dim extracted_link_number As Long
        Dim margin As Long
        Const acceptable_margin As Integer = 20

        check_number_is_within_range_of_others = False

        For Each extracted_link_info In related_web_pages
            extracted_link_number = extracted_link_info(1)
            margin = page_number - extracted_link_number
            If page_number < extracted_link_number Then margin = margin * -1
            If margin < acceptable_margin And margin <> 0 Then
                check_number_is_within_range_of_others = True
                Exit For
            End If
        Next

    End Function

    Public Function get_links() As Collection

        If Not mp3_links_have_been_grabbed Then grab_mp3_links()
        get_links = mp3_links

    End Function

    Public Function get_related_pages() As Collection

        If Not related_pages_links_have_been_grabbed Then grab_related_pages_links()
        get_related_pages = related_web_pages

    End Function

    Public Function set_web_address(Optional ByVal web_address As String = "") As Boolean

        Dim file_path_exists As Boolean

        set_web_address = False

        web_address_i = web_address

        web_address_i = create_well_formed_web_link(web_address_i, get_web_address)

        If Left(web_address_i, 4) = "http" Then
            web_file_path_i = save_copy_of_web_page()
            If web_file_path_i <> "" Then set_web_address = True
        Else
            Try 'This allows for the possibility that the web address contains a restricted character.
                file_path_exists = GetFileInfo(web_address_i).Exists
            Catch
            End Try
            If file_path_exists Then
                web_file_path_i = web_address_i
                set_web_address = True
            Else
                message_string = "The file path '" & web_address_i & "' is not valid. The webpage object was not loaded."
                MsgBox(message_string, MsgBoxStyle.Information, "Web Page File Not Found")
            End If
        End If

    End Function

    Public Function get_web_address() As String

        get_web_address = web_address_i

    End Function

    Public Function get_file_path() As String

        get_file_path = web_file_path_i

    End Function

    Public Sub set_website_copy_save_folder(ByVal website_copy_save_folder As String)

        web_page_save_folder_i = website_copy_save_folder

    End Sub

    Public Function get_website_copy_save_folder() As String

        get_website_copy_save_folder = web_page_save_folder_i

    End Function

    Private Function save_copy_of_web_page() As String

        Dim file_path As String
        Dim web_client As New WebClient

        save_copy_of_web_page = ""

        If web_page_save_folder_i = Nothing Then
            message_string = "No folder for saving the web page to has been selected."
            MsgBox(message_string, MsgBoxStyle.Information, "No Web Page Save Folder File Path")
            Exit Function
        End If

        If Not GetDirectoryInfo(web_page_save_folder_i).Exists Then
            message_string = "The file path for the folder for saving the web page to is not valid."
            MsgBox(message_string, MsgBoxStyle.Information, "Web Page Save Folder File Path Not Valid")
            Exit Function
        End If

        file_path = remove_illegal_characters_for_Windows_filing_system(web_address_i)
        file_path = web_page_save_folder_i & "\" & file_path
        file_path = limit_file_path_to_247(file_path, True)

        Try
            web_client.DownloadFile(web_address_i, file_path)
            'Debug.Assert(False) 'Need to increment save path so you can save the same page more than once.
            save_copy_of_web_page = file_path
        Catch
            message_string = "The webpage '" & web_address_i & "' failed to download."
            MsgBox(message_string, MsgBoxStyle.Exclamation, "Download Failed")
        End Try

    End Function

    Protected Overrides Sub Finalize()

        MyBase.Finalize()

    End Sub

End Class
