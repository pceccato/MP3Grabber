<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options_Form))
        Me.OK_btn = New System.Windows.Forms.Button()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.open_archive_folder_btn = New System.Windows.Forms.Button()
        Me.archive_folder_ctl = New System.Windows.Forms.TextBox()
        Me.set_archive_folder_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.open_music_review_folder_btn = New System.Windows.Forms.Button()
        Me.open_mp3_processed_folder_btn = New System.Windows.Forms.Button()
        Me.open_mp3_download_folder_btn = New System.Windows.Forms.Button()
        Me.open_web_page_save_folder_btn = New System.Windows.Forms.Button()
        Me.music_review_folder_ctl = New System.Windows.Forms.TextBox()
        Me.set_music_review_folder_btn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mp3_processed_folder_ctl = New System.Windows.Forms.TextBox()
        Me.set_mp3_processed_folder_btn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mp3_download_folder_ctl = New System.Windows.Forms.TextBox()
        Me.set_mp3_download_folder_btn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.web_page_save_folder_ctl = New System.Windows.Forms.TextBox()
        Me.set_web_page_save_folder_btn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.excluded_text_grid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numerate_files_ctl = New System.Windows.Forms.CheckBox()
        Me.write_album_tag_ctl = New System.Windows.Forms.CheckBox()
        Me.randomize_files_ctl = New System.Windows.Forms.CheckBox()
        Me.mp3_tagger_settings_group = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.skip_files_with_album_name_ctl = New System.Windows.Forms.CheckBox()
        Me.number_of_files_per_album_ctl = New System.Windows.Forms.TextBox()
        Me.reset_album_number_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.album_number_ctl = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.album_name_ctl = New System.Windows.Forms.TextBox()
        Me.remember_album_number_ctl = New System.Windows.Forms.CheckBox()
        Me.offset_0_group = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.offset_0_identifier_ctl = New System.Windows.Forms.TextBox()
        Me.ignore_offset_0_ctl = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.direct_search_url_ctl = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.excluded_text_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.mp3_tagger_settings_group.SuspendLayout()
        Me.offset_0_group.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_btn
        '
        Me.OK_btn.Location = New System.Drawing.Point(507, 488)
        Me.OK_btn.Name = "OK_btn"
        Me.OK_btn.Size = New System.Drawing.Size(75, 23)
        Me.OK_btn.TabIndex = 0
        Me.OK_btn.Text = "OK"
        Me.OK_btn.UseVisualStyleBackColor = True
        '
        'cancel_btn
        '
        Me.cancel_btn.Location = New System.Drawing.Point(601, 488)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(75, 23)
        Me.cancel_btn.TabIndex = 1
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(16)
        Me.TabPage2.Size = New System.Drawing.Size(658, 436)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Folders Locations"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.open_archive_folder_btn)
        Me.GroupBox3.Controls.Add(Me.archive_folder_ctl)
        Me.GroupBox3.Controls.Add(Me.set_archive_folder_btn)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.open_music_review_folder_btn)
        Me.GroupBox3.Controls.Add(Me.open_mp3_processed_folder_btn)
        Me.GroupBox3.Controls.Add(Me.open_mp3_download_folder_btn)
        Me.GroupBox3.Controls.Add(Me.open_web_page_save_folder_btn)
        Me.GroupBox3.Controls.Add(Me.music_review_folder_ctl)
        Me.GroupBox3.Controls.Add(Me.set_music_review_folder_btn)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.mp3_processed_folder_ctl)
        Me.GroupBox3.Controls.Add(Me.set_mp3_processed_folder_btn)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.mp3_download_folder_ctl)
        Me.GroupBox3.Controls.Add(Me.set_mp3_download_folder_btn)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.web_page_save_folder_ctl)
        Me.GroupBox3.Controls.Add(Me.set_web_page_save_folder_btn)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox3.Size = New System.Drawing.Size(620, 398)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'open_archive_folder_btn
        '
        Me.open_archive_folder_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.open_archive_folder_btn.Location = New System.Drawing.Point(213, 281)
        Me.open_archive_folder_btn.Name = "open_archive_folder_btn"
        Me.open_archive_folder_btn.Size = New System.Drawing.Size(194, 29)
        Me.open_archive_folder_btn.TabIndex = 10
        Me.open_archive_folder_btn.Text = "Open Archive Folder"
        Me.open_archive_folder_btn.UseVisualStyleBackColor = True
        '
        'archive_folder_ctl
        '
        Me.archive_folder_ctl.AcceptsReturn = True
        Me.archive_folder_ctl.Location = New System.Drawing.Point(13, 255)
        Me.archive_folder_ctl.Name = "archive_folder_ctl"
        Me.archive_folder_ctl.Size = New System.Drawing.Size(594, 20)
        Me.archive_folder_ctl.TabIndex = 9
        '
        'set_archive_folder_btn
        '
        Me.set_archive_folder_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.set_archive_folder_btn.Location = New System.Drawing.Point(413, 281)
        Me.set_archive_folder_btn.Name = "set_archive_folder_btn"
        Me.set_archive_folder_btn.Size = New System.Drawing.Size(194, 29)
        Me.set_archive_folder_btn.TabIndex = 11
        Me.set_archive_folder_btn.Text = "Set Archive Folder"
        Me.set_archive_folder_btn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Archive Folder"
        '
        'open_music_review_folder_btn
        '
        Me.open_music_review_folder_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.open_music_review_folder_btn.Location = New System.Drawing.Point(213, 211)
        Me.open_music_review_folder_btn.Name = "open_music_review_folder_btn"
        Me.open_music_review_folder_btn.Size = New System.Drawing.Size(194, 29)
        Me.open_music_review_folder_btn.TabIndex = 7
        Me.open_music_review_folder_btn.Text = "Open Music Review Folder"
        Me.open_music_review_folder_btn.UseVisualStyleBackColor = True
        '
        'open_mp3_processed_folder_btn
        '
        Me.open_mp3_processed_folder_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.open_mp3_processed_folder_btn.Location = New System.Drawing.Point(213, 140)
        Me.open_mp3_processed_folder_btn.Name = "open_mp3_processed_folder_btn"
        Me.open_mp3_processed_folder_btn.Size = New System.Drawing.Size(194, 29)
        Me.open_mp3_processed_folder_btn.TabIndex = 4
        Me.open_mp3_processed_folder_btn.Text = "Open Processed mp3s Folder"
        Me.open_mp3_processed_folder_btn.UseVisualStyleBackColor = True
        '
        'open_mp3_download_folder_btn
        '
        Me.open_mp3_download_folder_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.open_mp3_download_folder_btn.Location = New System.Drawing.Point(213, 69)
        Me.open_mp3_download_folder_btn.Name = "open_mp3_download_folder_btn"
        Me.open_mp3_download_folder_btn.Size = New System.Drawing.Size(194, 29)
        Me.open_mp3_download_folder_btn.TabIndex = 1
        Me.open_mp3_download_folder_btn.Text = "Open mp3 Download Folder"
        Me.open_mp3_download_folder_btn.UseVisualStyleBackColor = True
        '
        'open_web_page_save_folder_btn
        '
        Me.open_web_page_save_folder_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.open_web_page_save_folder_btn.Location = New System.Drawing.Point(213, 352)
        Me.open_web_page_save_folder_btn.Name = "open_web_page_save_folder_btn"
        Me.open_web_page_save_folder_btn.Size = New System.Drawing.Size(194, 29)
        Me.open_web_page_save_folder_btn.TabIndex = 13
        Me.open_web_page_save_folder_btn.Text = "Open Web Page Save Folder"
        Me.open_web_page_save_folder_btn.UseVisualStyleBackColor = True
        '
        'music_review_folder_ctl
        '
        Me.music_review_folder_ctl.AcceptsReturn = True
        Me.music_review_folder_ctl.Location = New System.Drawing.Point(13, 185)
        Me.music_review_folder_ctl.Name = "music_review_folder_ctl"
        Me.music_review_folder_ctl.Size = New System.Drawing.Size(594, 20)
        Me.music_review_folder_ctl.TabIndex = 6
        '
        'set_music_review_folder_btn
        '
        Me.set_music_review_folder_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.set_music_review_folder_btn.Location = New System.Drawing.Point(413, 211)
        Me.set_music_review_folder_btn.Name = "set_music_review_folder_btn"
        Me.set_music_review_folder_btn.Size = New System.Drawing.Size(194, 29)
        Me.set_music_review_folder_btn.TabIndex = 8
        Me.set_music_review_folder_btn.Text = "Set Music Review Folder"
        Me.set_music_review_folder_btn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Music Review Folder"
        '
        'mp3_processed_folder_ctl
        '
        Me.mp3_processed_folder_ctl.AcceptsReturn = True
        Me.mp3_processed_folder_ctl.Location = New System.Drawing.Point(13, 114)
        Me.mp3_processed_folder_ctl.Name = "mp3_processed_folder_ctl"
        Me.mp3_processed_folder_ctl.Size = New System.Drawing.Size(594, 20)
        Me.mp3_processed_folder_ctl.TabIndex = 3
        '
        'set_mp3_processed_folder_btn
        '
        Me.set_mp3_processed_folder_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.set_mp3_processed_folder_btn.Location = New System.Drawing.Point(413, 140)
        Me.set_mp3_processed_folder_btn.Name = "set_mp3_processed_folder_btn"
        Me.set_mp3_processed_folder_btn.Size = New System.Drawing.Size(194, 29)
        Me.set_mp3_processed_folder_btn.TabIndex = 5
        Me.set_mp3_processed_folder_btn.Text = "Set Processed mp3s Folder"
        Me.set_mp3_processed_folder_btn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Processed mp3s Folder"
        '
        'mp3_download_folder_ctl
        '
        Me.mp3_download_folder_ctl.AcceptsReturn = True
        Me.mp3_download_folder_ctl.Location = New System.Drawing.Point(13, 43)
        Me.mp3_download_folder_ctl.Name = "mp3_download_folder_ctl"
        Me.mp3_download_folder_ctl.Size = New System.Drawing.Size(594, 20)
        Me.mp3_download_folder_ctl.TabIndex = 0
        '
        'set_mp3_download_folder_btn
        '
        Me.set_mp3_download_folder_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.set_mp3_download_folder_btn.Location = New System.Drawing.Point(413, 69)
        Me.set_mp3_download_folder_btn.Name = "set_mp3_download_folder_btn"
        Me.set_mp3_download_folder_btn.Size = New System.Drawing.Size(194, 29)
        Me.set_mp3_download_folder_btn.TabIndex = 2
        Me.set_mp3_download_folder_btn.Text = "Set mp3 Download Folder"
        Me.set_mp3_download_folder_btn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "mp3 Download Folder"
        '
        'web_page_save_folder_ctl
        '
        Me.web_page_save_folder_ctl.Location = New System.Drawing.Point(13, 326)
        Me.web_page_save_folder_ctl.Name = "web_page_save_folder_ctl"
        Me.web_page_save_folder_ctl.Size = New System.Drawing.Size(594, 20)
        Me.web_page_save_folder_ctl.TabIndex = 12
        '
        'set_web_page_save_folder_btn
        '
        Me.set_web_page_save_folder_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.set_web_page_save_folder_btn.Location = New System.Drawing.Point(413, 352)
        Me.set_web_page_save_folder_btn.Name = "set_web_page_save_folder_btn"
        Me.set_web_page_save_folder_btn.Size = New System.Drawing.Size(194, 29)
        Me.set_web_page_save_folder_btn.TabIndex = 14
        Me.set_web_page_save_folder_btn.Text = "Set Web Page Save Folder"
        Me.set_web_page_save_folder_btn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Web Page Save Folder"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.excluded_text_grid)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.mp3_tagger_settings_group)
        Me.TabPage1.Controls.Add(Me.offset_0_group)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.direct_search_url_ctl)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(16)
        Me.TabPage1.Size = New System.Drawing.Size(658, 436)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Options"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label11.Location = New System.Drawing.Point(19, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Excluded Text"
        '
        'excluded_text_grid
        '
        Me.excluded_text_grid.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.excluded_text_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.excluded_text_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.excluded_text_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.excluded_text_grid.Location = New System.Drawing.Point(19, 256)
        Me.excluded_text_grid.Name = "excluded_text_grid"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.excluded_text_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.excluded_text_grid.Size = New System.Drawing.Size(365, 161)
        Me.excluded_text_grid.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numerate_files_ctl)
        Me.GroupBox1.Controls.Add(Me.write_album_tag_ctl)
        Me.GroupBox1.Controls.Add(Me.randomize_files_ctl)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 124)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Rename Settings"
        '
        'numerate_files_ctl
        '
        Me.numerate_files_ctl.AutoSize = True
        Me.numerate_files_ctl.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.numerate_files_ctl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numerate_files_ctl.Location = New System.Drawing.Point(16, 28)
        Me.numerate_files_ctl.Name = "numerate_files_ctl"
        Me.numerate_files_ctl.Size = New System.Drawing.Size(108, 19)
        Me.numerate_files_ctl.TabIndex = 0
        Me.numerate_files_ctl.Text = "Numerate Files"
        Me.numerate_files_ctl.UseVisualStyleBackColor = True
        '
        'write_album_tag_ctl
        '
        Me.write_album_tag_ctl.AutoSize = True
        Me.write_album_tag_ctl.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.write_album_tag_ctl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.write_album_tag_ctl.Location = New System.Drawing.Point(23, 86)
        Me.write_album_tag_ctl.Name = "write_album_tag_ctl"
        Me.write_album_tag_ctl.Size = New System.Drawing.Size(101, 19)
        Me.write_album_tag_ctl.TabIndex = 2
        Me.write_album_tag_ctl.Text = "Set Album Tag"
        Me.write_album_tag_ctl.UseVisualStyleBackColor = True
        '
        'randomize_files_ctl
        '
        Me.randomize_files_ctl.AutoSize = True
        Me.randomize_files_ctl.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.randomize_files_ctl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.randomize_files_ctl.Location = New System.Drawing.Point(9, 57)
        Me.randomize_files_ctl.Name = "randomize_files_ctl"
        Me.randomize_files_ctl.Size = New System.Drawing.Size(115, 19)
        Me.randomize_files_ctl.TabIndex = 1
        Me.randomize_files_ctl.Text = "Randomize Files"
        Me.randomize_files_ctl.UseVisualStyleBackColor = True
        '
        'mp3_tagger_settings_group
        '
        Me.mp3_tagger_settings_group.Controls.Add(Me.Label5)
        Me.mp3_tagger_settings_group.Controls.Add(Me.skip_files_with_album_name_ctl)
        Me.mp3_tagger_settings_group.Controls.Add(Me.number_of_files_per_album_ctl)
        Me.mp3_tagger_settings_group.Controls.Add(Me.reset_album_number_btn)
        Me.mp3_tagger_settings_group.Controls.Add(Me.Label4)
        Me.mp3_tagger_settings_group.Controls.Add(Me.album_number_ctl)
        Me.mp3_tagger_settings_group.Controls.Add(Me.Label3)
        Me.mp3_tagger_settings_group.Controls.Add(Me.album_name_ctl)
        Me.mp3_tagger_settings_group.Controls.Add(Me.remember_album_number_ctl)
        Me.mp3_tagger_settings_group.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mp3_tagger_settings_group.Location = New System.Drawing.Point(173, 22)
        Me.mp3_tagger_settings_group.Name = "mp3_tagger_settings_group"
        Me.mp3_tagger_settings_group.Size = New System.Drawing.Size(466, 121)
        Me.mp3_tagger_settings_group.TabIndex = 1
        Me.mp3_tagger_settings_group.TabStop = False
        Me.mp3_tagger_settings_group.Text = "Album Tagger Settings"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Number of Files per Album"
        '
        'skip_files_with_album_name_ctl
        '
        Me.skip_files_with_album_name_ctl.AutoSize = True
        Me.skip_files_with_album_name_ctl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skip_files_with_album_name_ctl.Location = New System.Drawing.Point(283, 25)
        Me.skip_files_with_album_name_ctl.Name = "skip_files_with_album_name_ctl"
        Me.skip_files_with_album_name_ctl.Size = New System.Drawing.Size(177, 19)
        Me.skip_files_with_album_name_ctl.TabIndex = 1
        Me.skip_files_with_album_name_ctl.Text = "Skip Files with Album Name"
        Me.skip_files_with_album_name_ctl.UseVisualStyleBackColor = True
        '
        'number_of_files_per_album_ctl
        '
        Me.number_of_files_per_album_ctl.Location = New System.Drawing.Point(196, 81)
        Me.number_of_files_per_album_ctl.Name = "number_of_files_per_album_ctl"
        Me.number_of_files_per_album_ctl.Size = New System.Drawing.Size(48, 23)
        Me.number_of_files_per_album_ctl.TabIndex = 4
        Me.number_of_files_per_album_ctl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'reset_album_number_btn
        '
        Me.reset_album_number_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset_album_number_btn.Location = New System.Drawing.Point(283, 78)
        Me.reset_album_number_btn.Name = "reset_album_number_btn"
        Me.reset_album_number_btn.Size = New System.Drawing.Size(167, 26)
        Me.reset_album_number_btn.TabIndex = 5
        Me.reset_album_number_btn.Text = "Reset Album Number"
        Me.reset_album_number_btn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Starting Album Number"
        '
        'album_number_ctl
        '
        Me.album_number_ctl.Location = New System.Drawing.Point(196, 52)
        Me.album_number_ctl.Name = "album_number_ctl"
        Me.album_number_ctl.Size = New System.Drawing.Size(48, 23)
        Me.album_number_ctl.TabIndex = 2
        Me.album_number_ctl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Album Name"
        '
        'album_name_ctl
        '
        Me.album_name_ctl.Location = New System.Drawing.Point(88, 23)
        Me.album_name_ctl.Name = "album_name_ctl"
        Me.album_name_ctl.Size = New System.Drawing.Size(156, 23)
        Me.album_name_ctl.TabIndex = 0
        Me.album_name_ctl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'remember_album_number_ctl
        '
        Me.remember_album_number_ctl.AutoSize = True
        Me.remember_album_number_ctl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remember_album_number_ctl.Location = New System.Drawing.Point(283, 54)
        Me.remember_album_number_ctl.Name = "remember_album_number_ctl"
        Me.remember_album_number_ctl.Size = New System.Drawing.Size(167, 19)
        Me.remember_album_number_ctl.TabIndex = 3
        Me.remember_album_number_ctl.Text = "Remember Album Number"
        Me.remember_album_number_ctl.UseVisualStyleBackColor = True
        '
        'offset_0_group
        '
        Me.offset_0_group.Controls.Add(Me.Label2)
        Me.offset_0_group.Controls.Add(Me.offset_0_identifier_ctl)
        Me.offset_0_group.Controls.Add(Me.ignore_offset_0_ctl)
        Me.offset_0_group.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.offset_0_group.Location = New System.Drawing.Point(403, 169)
        Me.offset_0_group.Name = "offset_0_group"
        Me.offset_0_group.Size = New System.Drawing.Size(236, 107)
        Me.offset_0_group.TabIndex = 9
        Me.offset_0_group.TabStop = False
        Me.offset_0_group.Text = "Ignore Starting Page"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Text to Identify Starting Page"
        '
        'offset_0_identifier_ctl
        '
        Me.offset_0_identifier_ctl.Location = New System.Drawing.Point(12, 67)
        Me.offset_0_identifier_ctl.Name = "offset_0_identifier_ctl"
        Me.offset_0_identifier_ctl.Size = New System.Drawing.Size(213, 23)
        Me.offset_0_identifier_ctl.TabIndex = 1
        '
        'ignore_offset_0_ctl
        '
        Me.ignore_offset_0_ctl.AutoSize = True
        Me.ignore_offset_0_ctl.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ignore_offset_0_ctl.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.ignore_offset_0_ctl.Location = New System.Drawing.Point(12, 22)
        Me.ignore_offset_0_ctl.Name = "ignore_offset_0_ctl"
        Me.ignore_offset_0_ctl.Size = New System.Drawing.Size(191, 19)
        Me.ignore_offset_0_ctl.TabIndex = 0
        Me.ignore_offset_0_ctl.Text = "Ignore Related Pages with Text"
        Me.ignore_offset_0_ctl.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(19, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Direct Search URL"
        '
        'direct_search_url_ctl
        '
        Me.direct_search_url_ctl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direct_search_url_ctl.Location = New System.Drawing.Point(19, 187)
        Me.direct_search_url_ctl.Name = "direct_search_url_ctl"
        Me.direct_search_url_ctl.Size = New System.Drawing.Size(365, 22)
        Me.direct_search_url_ctl.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(14, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(666, 462)
        Me.TabControl1.TabIndex = 10
        '
        'Options_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 530)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.OK_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Options_Form"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Options"
        Me.TopMost = True
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.excluded_text_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.mp3_tagger_settings_group.ResumeLayout(False)
        Me.mp3_tagger_settings_group.PerformLayout()
        Me.offset_0_group.ResumeLayout(False)
        Me.offset_0_group.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_btn As System.Windows.Forms.Button
    Friend WithEvents cancel_btn As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents open_archive_folder_btn As System.Windows.Forms.Button
    Friend WithEvents archive_folder_ctl As System.Windows.Forms.TextBox
    Friend WithEvents set_archive_folder_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents open_music_review_folder_btn As System.Windows.Forms.Button
    Friend WithEvents open_mp3_processed_folder_btn As System.Windows.Forms.Button
    Friend WithEvents open_mp3_download_folder_btn As System.Windows.Forms.Button
    Friend WithEvents open_web_page_save_folder_btn As System.Windows.Forms.Button
    Friend WithEvents music_review_folder_ctl As System.Windows.Forms.TextBox
    Friend WithEvents set_music_review_folder_btn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents mp3_processed_folder_ctl As System.Windows.Forms.TextBox
    Friend WithEvents set_mp3_processed_folder_btn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mp3_download_folder_ctl As System.Windows.Forms.TextBox
    Friend WithEvents set_mp3_download_folder_btn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents web_page_save_folder_ctl As System.Windows.Forms.TextBox
    Friend WithEvents set_web_page_save_folder_btn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents excluded_text_grid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents numerate_files_ctl As System.Windows.Forms.CheckBox
    Friend WithEvents write_album_tag_ctl As System.Windows.Forms.CheckBox
    Friend WithEvents randomize_files_ctl As System.Windows.Forms.CheckBox
    Friend WithEvents mp3_tagger_settings_group As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents skip_files_with_album_name_ctl As System.Windows.Forms.CheckBox
    Friend WithEvents number_of_files_per_album_ctl As System.Windows.Forms.TextBox
    Friend WithEvents reset_album_number_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents album_number_ctl As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents album_name_ctl As System.Windows.Forms.TextBox
    Friend WithEvents remember_album_number_ctl As System.Windows.Forms.CheckBox
    Friend WithEvents offset_0_group As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents offset_0_identifier_ctl As System.Windows.Forms.TextBox
    Friend WithEvents ignore_offset_0_ctl As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents direct_search_url_ctl As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
