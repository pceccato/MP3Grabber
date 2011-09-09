<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Child Node")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Root Node", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.browse_for_web_page_file_btn = New System.Windows.Forms.Button()
        Me.search_terms_ctl = New System.Windows.Forms.TextBox()
        Me.create_search_url_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.view_search_page_btn = New System.Windows.Forms.Button()
        Me.web_address_to_download_from_ctl = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.paste_and_download_btn = New System.Windows.Forms.Button()
        Me.download_links_btn = New System.Windows.Forms.Button()
        Me.menu_strip_ctl = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mp3_save_folder_tree_ctl = New System.Windows.Forms.TreeView()
        Me.process_downloaded_mp3s_btn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.run_complete_process_btn = New System.Windows.Forms.Button()
        Me.move_mp3s_to_review_folder_btn = New System.Windows.Forms.Button()
        Me.mp3_save_folder_ctl = New System.Windows.Forms.TextBox()
        Me.set_mp3_save_folder_btn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.open_mp3_download_folder_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.menu_strip_ctl.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Web Address to Download From"
        '
        'browse_for_web_page_file_btn
        '
        Me.browse_for_web_page_file_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browse_for_web_page_file_btn.Location = New System.Drawing.Point(433, 116)
        Me.browse_for_web_page_file_btn.Name = "browse_for_web_page_file_btn"
        Me.browse_for_web_page_file_btn.Size = New System.Drawing.Size(181, 29)
        Me.browse_for_web_page_file_btn.TabIndex = 6
        Me.browse_for_web_page_file_btn.Text = "Browse for Web Page File"
        Me.browse_for_web_page_file_btn.UseVisualStyleBackColor = True
        '
        'search_terms_ctl
        '
        Me.search_terms_ctl.Location = New System.Drawing.Point(6, 36)
        Me.search_terms_ctl.Name = "search_terms_ctl"
        Me.search_terms_ctl.Size = New System.Drawing.Size(354, 20)
        Me.search_terms_ctl.TabIndex = 0
        '
        'create_search_url_btn
        '
        Me.create_search_url_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create_search_url_btn.Location = New System.Drawing.Point(493, 31)
        Me.create_search_url_btn.Name = "create_search_url_btn"
        Me.create_search_url_btn.Size = New System.Drawing.Size(121, 29)
        Me.create_search_url_btn.TabIndex = 2
        Me.create_search_url_btn.Text = "Create Search URL"
        Me.create_search_url_btn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "TrackItDown Search"
        '
        'view_search_page_btn
        '
        Me.view_search_page_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_search_page_btn.Location = New System.Drawing.Point(366, 31)
        Me.view_search_page_btn.Name = "view_search_page_btn"
        Me.view_search_page_btn.Size = New System.Drawing.Size(121, 29)
        Me.view_search_page_btn.TabIndex = 1
        Me.view_search_page_btn.Text = "View Search Page"
        Me.view_search_page_btn.UseVisualStyleBackColor = True
        '
        'web_address_to_download_from_ctl
        '
        Me.web_address_to_download_from_ctl.Location = New System.Drawing.Point(6, 90)
        Me.web_address_to_download_from_ctl.Name = "web_address_to_download_from_ctl"
        Me.web_address_to_download_from_ctl.Size = New System.Drawing.Size(608, 20)
        Me.web_address_to_download_from_ctl.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.paste_and_download_btn)
        Me.GroupBox1.Controls.Add(Me.web_address_to_download_from_ctl)
        Me.GroupBox1.Controls.Add(Me.search_terms_ctl)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.view_search_page_btn)
        Me.GroupBox1.Controls.Add(Me.create_search_url_btn)
        Me.GroupBox1.Controls.Add(Me.download_links_btn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.browse_for_web_page_file_btn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'paste_and_download_btn
        '
        Me.paste_and_download_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paste_and_download_btn.Location = New System.Drawing.Point(220, 116)
        Me.paste_and_download_btn.Name = "paste_and_download_btn"
        Me.paste_and_download_btn.Size = New System.Drawing.Size(181, 29)
        Me.paste_and_download_btn.TabIndex = 5
        Me.paste_and_download_btn.Text = "Paste and Download mp3s"
        Me.paste_and_download_btn.UseVisualStyleBackColor = True
        '
        'download_links_btn
        '
        Me.download_links_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.download_links_btn.Location = New System.Drawing.Point(6, 116)
        Me.download_links_btn.Name = "download_links_btn"
        Me.download_links_btn.Size = New System.Drawing.Size(181, 29)
        Me.download_links_btn.TabIndex = 4
        Me.download_links_btn.Text = "Download mp3s"
        Me.download_links_btn.UseVisualStyleBackColor = True
        '
        'menu_strip_ctl
        '
        Me.menu_strip_ctl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.menu_strip_ctl.Location = New System.Drawing.Point(0, 0)
        Me.menu_strip_ctl.Name = "menu_strip_ctl"
        Me.menu_strip_ctl.Size = New System.Drawing.Size(644, 24)
        Me.menu_strip_ctl.TabIndex = 5
        Me.menu_strip_ctl.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'mp3_save_folder_tree_ctl
        '
        Me.mp3_save_folder_tree_ctl.Location = New System.Drawing.Point(18, 347)
        Me.mp3_save_folder_tree_ctl.Name = "mp3_save_folder_tree_ctl"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "Child Node"
        TreeNode2.Name = "Node0"
        TreeNode2.Text = "Root Node"
        Me.mp3_save_folder_tree_ctl.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.mp3_save_folder_tree_ctl.Size = New System.Drawing.Size(92, 23)
        Me.mp3_save_folder_tree_ctl.TabIndex = 23
        Me.mp3_save_folder_tree_ctl.Visible = False
        '
        'process_downloaded_mp3s_btn
        '
        Me.process_downloaded_mp3s_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.process_downloaded_mp3s_btn.Location = New System.Drawing.Point(6, 22)
        Me.process_downloaded_mp3s_btn.Name = "process_downloaded_mp3s_btn"
        Me.process_downloaded_mp3s_btn.Size = New System.Drawing.Size(181, 29)
        Me.process_downloaded_mp3s_btn.TabIndex = 1
        Me.process_downloaded_mp3s_btn.Text = "Process Downloaded mp3s"
        Me.process_downloaded_mp3s_btn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.run_complete_process_btn)
        Me.GroupBox2.Controls.Add(Me.move_mp3s_to_review_folder_btn)
        Me.GroupBox2.Controls.Add(Me.process_downloaded_mp3s_btn)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(620, 67)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Post Download Processing"
        '
        'run_complete_process_btn
        '
        Me.run_complete_process_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.run_complete_process_btn.Location = New System.Drawing.Point(433, 22)
        Me.run_complete_process_btn.Name = "run_complete_process_btn"
        Me.run_complete_process_btn.Size = New System.Drawing.Size(181, 29)
        Me.run_complete_process_btn.TabIndex = 0
        Me.run_complete_process_btn.Text = "Run Complete Process"
        Me.run_complete_process_btn.UseVisualStyleBackColor = True
        '
        'move_mp3s_to_review_folder_btn
        '
        Me.move_mp3s_to_review_folder_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.move_mp3s_to_review_folder_btn.Location = New System.Drawing.Point(220, 22)
        Me.move_mp3s_to_review_folder_btn.Name = "move_mp3s_to_review_folder_btn"
        Me.move_mp3s_to_review_folder_btn.Size = New System.Drawing.Size(181, 29)
        Me.move_mp3s_to_review_folder_btn.TabIndex = 2
        Me.move_mp3s_to_review_folder_btn.Text = "Move mp3s To Review Folder"
        Me.move_mp3s_to_review_folder_btn.UseVisualStyleBackColor = True
        '
        'mp3_save_folder_ctl
        '
        Me.mp3_save_folder_ctl.AcceptsReturn = True
        Me.mp3_save_folder_ctl.Location = New System.Drawing.Point(18, 315)
        Me.mp3_save_folder_ctl.Name = "mp3_save_folder_ctl"
        Me.mp3_save_folder_ctl.Size = New System.Drawing.Size(608, 20)
        Me.mp3_save_folder_ctl.TabIndex = 2
        '
        'set_mp3_save_folder_btn
        '
        Me.set_mp3_save_folder_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.set_mp3_save_folder_btn.Location = New System.Drawing.Point(445, 341)
        Me.set_mp3_save_folder_btn.Name = "set_mp3_save_folder_btn"
        Me.set_mp3_save_folder_btn.Size = New System.Drawing.Size(181, 29)
        Me.set_mp3_save_folder_btn.TabIndex = 4
        Me.set_mp3_save_folder_btn.Text = "Set mp3 Save Folder"
        Me.set_mp3_save_folder_btn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 17)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "mp3 Save Folder"
        '
        'open_mp3_download_folder_btn
        '
        Me.open_mp3_download_folder_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.open_mp3_download_folder_btn.Location = New System.Drawing.Point(232, 341)
        Me.open_mp3_download_folder_btn.Name = "open_mp3_download_folder_btn"
        Me.open_mp3_download_folder_btn.Size = New System.Drawing.Size(181, 29)
        Me.open_mp3_download_folder_btn.TabIndex = 3
        Me.open_mp3_download_folder_btn.Text = "Open mp3 Download Folder"
        Me.open_mp3_download_folder_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(194, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "+"
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 394)
        Me.Controls.Add(Me.open_mp3_download_folder_btn)
        Me.Controls.Add(Me.mp3_save_folder_ctl)
        Me.Controls.Add(Me.set_mp3_save_folder_btn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.mp3_save_folder_tree_ctl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.menu_strip_ctl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu_strip_ctl
        Me.MaximizeBox = False
        Me.Name = "Main_Form"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mp3 Grabber"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.menu_strip_ctl.ResumeLayout(False)
        Me.menu_strip_ctl.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents browse_for_web_page_file_btn As System.Windows.Forms.Button
    Friend WithEvents search_terms_ctl As System.Windows.Forms.TextBox
    Friend WithEvents create_search_url_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents view_search_page_btn As System.Windows.Forms.Button
    Friend WithEvents web_address_to_download_from_ctl As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents menu_strip_ctl As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents download_links_btn As System.Windows.Forms.Button
    Friend WithEvents mp3_save_folder_tree_ctl As System.Windows.Forms.TreeView
    Friend WithEvents process_downloaded_mp3s_btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents move_mp3s_to_review_folder_btn As System.Windows.Forms.Button
    Friend WithEvents mp3_save_folder_ctl As System.Windows.Forms.TextBox
    Friend WithEvents set_mp3_save_folder_btn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents run_complete_process_btn As System.Windows.Forms.Button
    Friend WithEvents paste_and_download_btn As System.Windows.Forms.Button
    Friend WithEvents open_mp3_download_folder_btn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
