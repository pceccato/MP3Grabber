Option Explicit On

Imports System.IO 'for StreamReader & Streamwriter
Imports Microsoft.VisualBasic.FileIO.FileSystem 'for GetDirectoryInfo, DirectoryInfo, GetFileInfo & FileInfo
Imports System.Net 'for WebClient

Public Class Main_Form

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        initialize_app()
        initialize_controls()

        Debug.Print("Main Form Location X: " & Me.Location.X)
        main_form_i = Me
        Debug.Print("main_form_i Location X: " & main_form_i.Location.X)

        Debug.Print(get_size_of_text_in_control(mp3_save_folder_ctl, mp3_save_folder_ctl.Text))
        Debug.Print(mp3_save_folder_ctl.Width)

    End Sub

    Sub initialize_controls()

        mp3_save_folder_ctl.Text = mp3_save_folder
        web_address_to_download_from_ctl.Text = web_address_to_download_from
        search_terms_ctl.Focus()

    End Sub

    Private Sub set_mp3_save_folder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set_mp3_save_folder_btn.Click

        set_control_file_path_using_browser(mp3_save_folder_ctl)
        mp3_save_folder = mp3_save_folder_ctl.Text

    End Sub

    Private Sub download_links_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles download_links_btn.Click

        If all_inputs_are_valid() Then
            Debug.Print("Main Form Location X: " & Me.Location.X)
            main_form_i = Me
            Debug.Print("main_form_i Location X: " & main_form_i.Location.X)
            download_links()
        End If

    End Sub

    Function all_inputs_are_valid() As Boolean

        all_inputs_are_valid = True

        If web_address_to_download_from_ctl.Text = "" Then
            message_string = "No web page has been selected."
            MsgBox(message_string, MsgBoxStyle.Information, "No Web Page Selected")
            all_inputs_are_valid = False
        End If

        If Not GetDirectoryInfo(mp3_save_folder_ctl.Text).Exists Then
            message_string = "The file path selected for saving the mp3s to is not valid."
            MsgBox(message_string, MsgBoxStyle.Information, "mp3 Save File Path Not Valid")
            all_inputs_are_valid = False
        End If

        If Not GetDirectoryInfo(web_page_save_folder).Exists Then
            message_string = "The file path selected for saving the web page copies to is not valid."
            MsgBox(message_string, MsgBoxStyle.Information, "Web Page Save File Path Not Valid")
            all_inputs_are_valid = False
        End If

    End Function

    Private Sub browse_for_web_page_file_btn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles browse_for_web_page_file_btn.Click

        Dim file_browser As New OpenFileDialog

        file_browser.ShowDialog()
        If file_browser.FileName <> "" Then
            Me.web_address_to_download_from_ctl.Text = file_browser.FileName
            Me.web_address_to_download_from_ctl.Refresh()
        End If

    End Sub

    Private Sub create_search_url_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles create_search_url_btn.Click

        set_web_address_using_search_terms()

    End Sub

    Private Sub view_search_page_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles view_search_page_btn.Click

        view_search_page()

    End Sub

    Private Sub view_search_page()

        set_web_address_using_search_terms()
        System.Diagnostics.Process.Start(web_address_to_download_from_ctl.Text)

    End Sub

    Private Sub set_web_address_using_search_terms()

        temp_string = replace_reserved_characters_in_URL(search_terms_ctl.Text)
        temp_string = Replace(temp_string, " ", "+", 1, , CompareMethod.Text)

        web_address_to_download_from_ctl.Text = search_URL & temp_string
        web_address_to_download_from_ctl.Refresh()

    End Sub

    Private Sub Main_Form_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        save_defaults()

    End Sub

    Private Sub mp3_save_folder_ctl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        mp3_save_folder = mp3_save_folder_ctl.Text

    End Sub

    Private Sub web_address_to_download_from_ctl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles web_address_to_download_from_ctl.TextChanged

        web_address_to_download_from = web_address_to_download_from_ctl.Text

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click

        Dim options_frm As New Options_Form

        options_frm.Show(Me)

        'For some reason I cannot persuade the 'Centre Parent' option to work. Not worth investing time to try and resolve when 'Centre Screen' options works ok.

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        Dim about_box_i As New About_Box

        'Me.IsMdiContainer = True 'MDI = Multiple Document Interface, i.e. a Form within a Form.
        'about_box_i.MdiParent = DirectCast(Me, Form)

        'about_box_i.Parent = Me 'This doesn't work due to some 'top level control' error.
        'Debug.Print("Why won't you work you bastard thing?...")

        about_box_i.Show(Me)

        'For some reason I cannot persuade the 'Centre Parent' option to work. Not worth investing time to try and resolve when 'Centre Screen' options works ok.

        'about_box_i.Location = get_center_point_of_form(Me, about_box_i)
        'CenterInParent(Me, about_box_i) 'this doesn't work here!
        'about_box_i.Show(Me)

        Exit Sub

        MsgBox("mp3 Grabber" & vbLf & vbLf & "Developed by Matt Lazell" & vbLf & vbLf & "October 2010")

    End Sub

    Private Sub search_terms_ctl_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        view_search_page()

    End Sub

    Private Sub search_terms_ctl_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles search_terms_ctl.KeyDown

        If e.KeyCode = Keys.Enter Then view_search_page()

    End Sub

    Private Sub move_mp3s_to_review_folder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles move_mp3s_to_review_folder_btn.Click

        move_mp3s_to_review_folder()

    End Sub

    Private Sub process_downloaded_mp3s_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles process_downloaded_mp3s_btn.Click

        process_files()

    End Sub

    Private Sub paste_and_download_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paste_and_download_btn.Click

        Dim clipboard_i As IDataObject = Clipboard.GetDataObject()

        If clipboard_i.GetDataPresent(DataFormats.Text) Then temp_string = clipboard_i.GetData(DataFormats.Text)
        
        web_address_to_download_from_ctl.Text = temp_string

        download_links()

    End Sub

    Private Sub open_mp3_download_folder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_mp3_download_folder_btn.Click

        open_folder_location(Me.mp3_save_folder_ctl.Text)

    End Sub

    Private Sub mp3_save_folder_ctl_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp3_save_folder_ctl.Leave

        mp3_save_folder = mp3_save_folder_ctl.Text 'Note that this will update even if there was no change to the text, but there's not really any point in checking for and only updating when there is a change.

    End Sub

    Private Sub run_complete_process_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles run_complete_process_btn.Click

        process_files()
        move_mp3s_to_review_folder()

    End Sub

End Class
