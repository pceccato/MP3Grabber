Public Class Select_mp3s_to_Download_Form

    Private Sub mp3s_Already_Downloaded_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        current_download_mp3s_dv.RowFilter = "Display = True" 'Only for the first pass.
        set_up_datagrid()
        ok_btn.Focus()

    End Sub

    Private Sub set_up_datagrid()

        mp3_files_grid.DataSource = current_download_mp3s_dv
        mp3_files_grid.DefaultCellStyle.Font = New Font("Calibri", 9.75)
        mp3_files_grid.ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 9.75)
        mp3_files_grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        mp3_files_grid.RowHeadersVisible = False
        mp3_files_grid.Columns(0).Visible = False
        mp3_files_grid.Columns(1).Width = 100
        mp3_files_grid.Columns(1).HeaderText = "URL"
        mp3_files_grid.Columns(2).Width = 100 '610 ' If I set up the layout of the columns using the Form design it then adds the fields in the datatable/dataview as new columns appended to the end of the dataview. This is why I have to manipulate them programmatically.
        mp3_files_grid.Columns(2).HeaderText = "File Name"
        mp3_files_grid.Columns(3).Width = 410
        mp3_files_grid.Columns(3).HeaderText = "Tidied File Name"
        mp3_files_grid.Columns(4).Width = 80
        mp3_files_grid.Columns(4).HeaderText = "Include"
        mp3_files_grid.Columns(5).Visible = False
        mp3_files_grid.Columns(6).Visible = False

        'to test.
        'mp3_files_grid.CurrentCell.Style.ForeColor = Color.Aqua
        'mp3_files_grid.CurrentRow.Frozen = True

    End Sub

    Private Sub ok_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_btn.Click

        'DialogResult = Windows.Forms.DialogResult.Yes
        Close()

    End Sub

    Private Sub select_all_ctl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_all_ctl.CheckedChanged

        'loop set download = select_all_ctl.Checked

    End Sub

End Class