Option Explicit On

Imports Microsoft.VisualBasic.FileIO.FileSystem 'for GetDirectoryInfo, DirectoryInfo, GetFileInfo & FileInfo
'Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports System.Deployment.Application 'for ApplicationDeployment stuff

Module Matts_Utility_Module

    Public Function get_file_extension(ByVal file_path As String) As String

        get_file_extension = System.IO.Path.GetExtension(file_path)

    End Function

    Public Function remove_illegal_characters_for_Windows_filing_system(ByVal string_to_process As String) As String

        Dim temp_string As String
        Dim illegal_character As Char
        Dim counter As Integer

        temp_string = string_to_process

        For counter = 1 To 8
            illegal_character = Choose(counter, "/", "\", ":", "*", "?", """", "<", ">", "|")
            temp_string = Replace(temp_string, illegal_character, "_", , , CompareMethod.Text)
        Next

        remove_illegal_characters_for_Windows_filing_system = temp_string

    End Function

    Public Function replace_reserved_characters_in_URL(ByVal string_to_process As String) As String

        Dim temp_string As String

        temp_string = string_to_process

        temp_string = Replace(temp_string, "&", "%26", , , CompareMethod.Text)
        temp_string = Replace(temp_string, "+", "%2B", , , CompareMethod.Text)
        temp_string = Replace(temp_string, ",", "%2C", , , CompareMethod.Text)
        temp_string = Replace(temp_string, "/", "%2F", , , CompareMethod.Text)
        temp_string = Replace(temp_string, ":", "%3A", , , CompareMethod.Text)
        temp_string = Replace(temp_string, ";", "%3B", , , CompareMethod.Text)
        temp_string = Replace(temp_string, "=", "%3D", , , CompareMethod.Text)
        temp_string = Replace(temp_string, "?", "%3F", , , CompareMethod.Text)
        temp_string = Replace(temp_string, "@", "%40", , , CompareMethod.Text)

        replace_reserved_characters_in_URL = temp_string

    End Function

    Public Function limit_file_path_to_247(ByVal file_path As String, Optional ByVal iterate_if_file_name_found As Boolean = False) As String

        Dim file_extension As String

        If Len(file_path) > 247 Then
            file_extension = get_file_extension(file_path) 'The file extension will just be .mp3 at the moment, but best to keep the code flexible.
            file_path = Left(file_path, 247 - Len(file_extension)) & file_extension
        End If

        If iterate_if_file_name_found Then file_path = iterate_file_name(file_path)

        limit_file_path_to_247 = file_path

    End Function

    Public Function iterate_file_name(ByVal file_path As String) As String

        Dim file_extension As String
        Dim temp_string As String
        Dim chars_to_chop_to_get_down_to_247 As Integer = 0
        Static iteratation As Integer

        If GetFileInfo(file_path).Exists Then

            iteratation = iteratation + 1

            file_extension = get_file_extension(file_path)
            If Len(file_path) + 2 + Len(CStr(iteratation)) > 247 Then 'This will only work if we know that the file path that is passed to this Function is not greater than 256, as should be the case if it is only called by the limit_file_path_to_247 Function.
                chars_to_chop_to_get_down_to_247 = 2 + Len(CStr(iteratation))
            End If
            temp_string = Mid(file_path, 1, Len(file_path) - Len(file_extension) - chars_to_chop_to_get_down_to_247) & "(" & iteratation & ")" & file_extension

            'Debug.Print(temp_string)

            If Not GetFileInfo(temp_string).Exists Then
                iteratation = 0
                iterate_file_name = temp_string
            Else
                iterate_file_name = iterate_file_name(file_path)
            End If

        Else

            iterate_file_name = file_path

        End If

    End Function

    Public Function extract_link_from_hyperlink(ByVal html_containing_link As String, ByVal position_of_href As Long) As String

        'NOT USED!!!

        Dim position_of_double_quote As Long

        position_of_double_quote = InStr(html_containing_link, html_containing_link, """", CompareMethod.Text)

        extract_link_from_hyperlink = ""

    End Function

    Public Function extract_file_name_from_path(ByVal file_path As String) As String

        MsgBox("You can use My.Computer.FileSystem.GetName instead")

        'Unit tested 6/8/10 by Matt.

        Dim temp_string As String
        Dim position_of_backslash As Integer
        Dim number_of_characters As Integer

        position_of_backslash = InStrRev(file_path, "\")
        number_of_characters = Len(file_path) - position_of_backslash
        temp_string = Right(file_path, number_of_characters)
        extract_file_name_from_path = temp_string

    End Function


    Public Function create_well_formed_web_link(ByVal link_string As String, ByVal parent_URL_string As String) As String

        Dim domain_url As String
        Dim position_of_end_of_domain As Integer

        If Left(link_string, 4) = "www." Then link_string = "http://" & link_string 'This assumes that the link in not on a secure server.

        If Left(link_string, 1) = "/" And Left(link_string, 2) <> "//" And Left(parent_URL_string, 4) = "http" Then

            If Left(parent_URL_string, 4) = "www." Then parent_URL_string = "http://" & parent_URL_string
            position_of_end_of_domain = InStr(1, parent_URL_string, "/", CompareMethod.Text)
            position_of_end_of_domain = InStr(position_of_end_of_domain + 2, parent_URL_string, "/", CompareMethod.Text)
            domain_url = Mid(parent_URL_string, 1, position_of_end_of_domain)

            'how to you get the domain URL if the master page is on the hard drive? Or do you even try?

            link_string = domain_url & Mid(link_string, 2)

        End If

        create_well_formed_web_link = link_string

    End Function

    Public Sub set_control_file_path_using_browser(ByRef file_path_ctl As Control)

        Dim folder_browser As New FolderBrowserDialog

        If file_path_ctl.Text <> "" Then folder_browser.SelectedPath = file_path_ctl.Text
        folder_browser.ShowDialog()

        If folder_browser.SelectedPath <> "" Then
            file_path_ctl.Text = folder_browser.SelectedPath
            file_path_ctl.Refresh()
        End If

    End Sub

    Public Sub open_folder_location(ByVal folder_path As String)

        If GetDirectoryInfo(folder_path).Exists Then
            Process.Start("explorer.exe", folder_path)
        Else
            message_string = "'" & single_quote_double_up(folder_path) & "' is not a valid folder path"
            MsgBox(message_string, MsgBoxStyle.Information, "Path Not Valid")
        End If

    End Sub

    Public Function get_application_folder() As String

        If ApplicationDeployment.IsNetworkDeployed Then
            get_application_folder = ApplicationDeployment.CurrentDeployment.DataDirectory & "\"
        Else
            get_application_folder = Application.StartupPath & "\"
            'get_application_folder = System.AppDomain.CurrentDomain.BaseDirectory
        End If

    End Function

    Public Function extract_file_name_from_mp3_link(ByVal mp3_link As String) As String

        Dim position_of_mp3 As Integer
        Dim position_of_forward_slash As Integer

        position_of_mp3 = InStr(mp3_link, ".mp3")
        If position_of_mp3 > 0 Then
            position_of_forward_slash = InStrRev(mp3_link, "/")
            position_of_forward_slash = position_of_forward_slash + 1
            extract_file_name_from_mp3_link = Mid(mp3_link, position_of_forward_slash, Len(mp3_link) - position_of_forward_slash + 1)
        Else
            extract_file_name_from_mp3_link = ""
        End If

    End Function

    Public Function get_center_point_of_form(ByVal parent As Form, ByVal child As Form) As Point

        Dim x As Integer
        Dim y As Integer

        x = parent.Location.X '+ (parent.Width / 2) - (child.Width / 2)
        y = parent.Location.Y '+ (parent.Height / 2.2) - (child.Height / 2)

        get_center_point_of_form = New Point(x, y)

        Exit Function

        child.Location = get_center_point_of_form 'if this works remove duplicates.

        Debug.Print("Parent Form '" & parent.Name & "' has X, Y  of " & parent.Location.X & ", " & parent.Location.Y)
        Debug.Print("Child Form '" & child.Name & "' has been assigned an X, Y  of " & child.Location.X & ", " & child.Location.Y)

    End Function

    Public Function get_beginning_and_end_in_control(ByVal ctl As Control) As String

        Dim text As String
        Dim size_of_text As Double
        Dim size_of_control As Double
        Dim middle_splitter As String = " ... "
        Dim size_of_splitter As Double
        Dim size_of_each_half As Double
        Dim no_chars_to_left As Integer
        Dim no_chars_to_right As Integer
        Dim beginning_and_end_text As String

        text = ctl.Text
        size_of_text = get_size_of_text_in_control(ctl, text)
        size_of_control = ctl.Width

        If size_of_text < size_of_control Then
            get_beginning_and_end_in_control = text
            Exit Function
        End If

        size_of_splitter = get_size_of_text_in_control(ctl, middle_splitter)
        size_of_each_half = (size_of_control - size_of_splitter) / 2

        no_chars_to_left = find_length_of_string_which_is_specified_width(text, ctl, size_of_each_half, False)
        no_chars_to_right = find_length_of_string_which_is_specified_width(text, ctl, size_of_each_half, True)

        beginning_and_end_text = Left(text, no_chars_to_left) & middle_splitter & Mid(text, no_chars_to_right)

        get_beginning_and_end_in_control = beginning_and_end_text

    End Function

    Public Function find_length_of_string_which_is_specified_width(ByVal text As String, ByVal ctl As Control, ByVal target_size As Double, ByVal start_at_end As Boolean)

        find_length_of_string_which_is_specified_width = 10 'to be coded

    End Function

    Public Function get_size_of_text_in_control(ByVal ctl As Control, ByVal text As String) As Double

        Dim g As Graphics = ctl.CreateGraphics
        Dim s As SizeF

        s = g.MeasureString(text, ctl.Font)

        get_size_of_text_in_control = s.Width

    End Function

    Public Function single_quote_double_up(ByVal string_i As String) As String

        single_quote_double_up = Replace(string_i, "'", "''")

    End Function

    Public Sub tester()

        Debug.Print(chop_end_off_string("Ace Ballads\Killa Ballads", , "\", chop_string_modes.search_from_and_return_beginning))

    End Sub

    Public Enum chop_string_modes

        search_from_and_return_beginning = 1
        search_from_beginning_and_return_end = 2
        search_from_end_and_return_beginning = 3
        search_from_and_return_end = 4

    End Enum

    Public Function chop_end_off_string(ByVal string_to_chop As String, Optional ByVal number_of_characters As Integer = 0, Optional ByVal character_to_chop As String = "", Optional ByVal mode As chop_string_modes = chop_string_modes.search_from_end_and_return_beginning, Optional ByVal iterations As Long = 0) As String ', Optional ByVal return_begining_of_string As Boolean = True, Optional ByVal search_from_begining As Boolean = False) As String

        'chops off the end of a string, either at the first instance of the character specified or by the number of characters specified.

        Dim temp_string As String
        Dim position_of_character As Integer
        Dim counter As Long

        If character_to_chop <> "" Then

            For counter = 0 To iterations
                If mode = chop_string_modes.search_from_and_return_beginning Or mode = chop_string_modes.search_from_beginning_and_return_end Then
                    position_of_character = InStr(position_of_character, string_to_chop, character_to_chop)
                Else
                    position_of_character = InStrRev(position_of_character, string_to_chop, character_to_chop)
                End If
            Next

        Else
            position_of_character = Strings.Len(string_to_chop) - (number_of_characters * iterations)
        End If

        If position_of_character = 0 Then
            chop_end_off_string = ""
            Exit Function
        End If

        If mode = chop_string_modes.search_from_and_return_beginning Or mode = chop_string_modes.search_from_end_and_return_beginning Then
            temp_string = Strings.Left(string_to_chop, position_of_character)
        Else
            temp_string = Strings.Right(string_to_chop, Strings.Len(string_to_chop) - position_of_character)
        End If

        chop_end_off_string = temp_string

    End Function

    Public Function is_string_null_or_zero_length(ByVal string_to_check As Object) As Boolean

        If IsDBNull(string_to_check) Then
            is_string_null_or_zero_length = True
        ElseIf string_to_check = "" Then
            is_string_null_or_zero_length = True
        Else
            is_string_null_or_zero_length = False
        End If

    End Function

End Module
