Option Explicit On

Public Class Options_Form

    Dim excluded_text_dt_copy As DataTable

    Private Sub Options_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        direct_search_url_ctl.Text = search_URL
        ignore_offset_0_ctl.Checked = ignore_offset_0
        offset_0_identifier_ctl.Text = offset_o_string
        album_name_ctl.Text = album_name
        album_number_ctl.Text = album_number
        remember_album_number_ctl.Checked = remember_album_number
        number_of_files_per_album_ctl.Text = number_of_files_per_album
        skip_files_with_album_name_ctl.Checked = skip_files_with_album_name
        numerate_files_ctl.Checked = numerate_files
        randomize_files_ctl.Checked = randomize_files
        write_album_tag_ctl.Checked = write_album_tag

        mp3_download_folder_ctl.Text = mp3_save_folder
        mp3_processed_folder_ctl.Text = mp3_processed_folder
        music_review_folder_ctl.Text = music_review_folder
        archive_folder_ctl.Text = archive_folder
        web_page_save_folder_ctl.Text = web_page_save_folder

        randomize_files_ctl.Enabled = numerate_files_ctl.Checked
        set_number_of_files_enabled()

        set_up_datagrid()

    End Sub

    Private Sub set_up_datagrid()

        'it needs to have the primary key on an independant column so you can change the value (otherwise you're changing the key!).

        excluded_text_dt_copy = excluded_text_dt.Copy
        excluded_text_dv = New DataView(excluded_text_dt_copy)

        excluded_text_grid.DataSource = excluded_text_dv
        excluded_text_grid.DefaultCellStyle.Font = New Font("Calibri", 9.75)
        excluded_text_grid.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 9.75)
        excluded_text_grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        excluded_text_grid.RowHeadersVisible = False
        excluded_text_grid.Columns(0).Visible = False
        excluded_text_grid.Columns(1).Width = 265 ' If I set up the layout of the columns using the Form design it then adds the fields in the datatable/dataview as new columns appended to the end of the dataview. This is why I have to manipulate them programmatically.
        excluded_text_grid.Columns(1).HeaderText = "Excluded Text"
        excluded_text_grid.Columns(2).Width = 80
        excluded_text_grid.Columns(2).HeaderText = "Excluded"

    End Sub

    Private Sub save_settings()

        search_URL = direct_search_url_ctl.Text
        ignore_offset_0 = ignore_offset_0_ctl.Checked
        offset_o_string = offset_0_identifier_ctl.Text
        If album_name <> album_name_ctl.Text Then number_of_files_in_current_album = 0
        album_name = album_name_ctl.Text
        album_number = album_number_ctl.Text
        remember_album_number = remember_album_number_ctl.Checked
        If number_of_files_per_album <> number_of_files_per_album_ctl.Text Then number_of_files_in_current_album = 0
        number_of_files_per_album = number_of_files_per_album_ctl.Text
        skip_files_with_album_name = skip_files_with_album_name_ctl.Checked
        numerate_files = numerate_files_ctl.Checked
        randomize_files = randomize_files_ctl.Checked
        write_album_tag = write_album_tag_ctl.Checked

        mp3_save_folder = mp3_download_folder_ctl.Text
        mp3_processed_folder = mp3_processed_folder_ctl.Text
        music_review_folder = music_review_folder_ctl.Text
        archive_folder = archive_folder_ctl.Text
        web_page_save_folder = web_page_save_folder_ctl.Text

        excluded_text_dt.Merge(excluded_text_dt_copy)

    End Sub

    Private Sub cancel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_btn.Click

        Me.Close()

    End Sub

    Private Sub OK_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_btn.Click

        save_settings()
        Me.Close()

    End Sub

    Private Sub set_mp3_download_folder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set_mp3_download_folder_btn.Click

        set_control_file_path_using_browser(mp3_download_folder_ctl)

    End Sub

    Private Sub set_music_review_folder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set_music_review_folder_btn.Click

        set_control_file_path_using_browser(music_review_folder_ctl)

    End Sub

    Private Sub set_web_page_save_folder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set_web_page_save_folder_btn.Click

        set_control_file_path_using_browser(web_page_save_folder_ctl)

    End Sub

    Private Sub set_mp3_processed_folder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set_mp3_processed_folder_btn.Click

        set_control_file_path_using_browser(mp3_processed_folder_ctl)

    End Sub

    Private Sub set_archive_folder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles set_archive_folder_btn.Click

        set_control_file_path_using_browser(archive_folder_ctl)

    End Sub

    Private Sub open_mp3_download_folder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_mp3_download_folder_btn.Click

        open_folder_location(mp3_download_folder_ctl.Text)

    End Sub

    Private Sub open_mp3_processed_folder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_mp3_processed_folder_btn.Click

        open_folder_location(mp3_processed_folder_ctl.Text)

    End Sub

    Private Sub open_music_review_folder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_music_review_folder_btn.Click

        open_folder_location(music_review_folder_ctl.Text)

    End Sub

    Private Sub open_web_page_save_folder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_web_page_save_folder_btn.Click

        open_folder_location(web_page_save_folder_ctl.Text)

    End Sub

    Private Sub open_archive_folder_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_archive_folder_btn.Click

        open_folder_location(archive_folder_ctl.Text)

    End Sub

    Private Sub numerate_files_ctl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numerate_files_ctl.CheckedChanged

        If numerate_files_ctl.Checked Then
            randomize_files_ctl.Enabled = True
        Else
            randomize_files_ctl.Enabled = False
        End If

    End Sub

    Private Sub excluded_text_grid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles excluded_text_grid.DataError

        If e.Exception IsNot Nothing AndAlso e.Context = DataGridViewDataErrorContexts.Commit Then

            message_string = "The Excluded Text value must be unique."
            MsgBox(message_string, MsgBoxStyle.Information, "Excluded Text Not Unique")
            'MessageBox.Show("The Excluded Text value must be unique.")

        End If

    End Sub

    Private Sub reset_album_number_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset_album_number_btn.Click

        album_number_ctl.Text = 1
        number_of_files_in_current_album = 0

    End Sub

    Private Sub remember_album_number_ctl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remember_album_number_ctl.Click

        set_number_of_files_enabled()

    End Sub

    Private Sub set_number_of_files_enabled()

        album_number_ctl.Enabled = remember_album_number_ctl.Checked
        
    End Sub

End Class