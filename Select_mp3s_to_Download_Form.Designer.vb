<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Select_mp3s_to_Download_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Select_mp3s_to_Download_Form))
        Me.main_label_lbl = New System.Windows.Forms.Label()
        Me.ok_btn = New System.Windows.Forms.Button()
        Me.mp3_files_grid = New System.Windows.Forms.DataGridView()
        Me.select_all_ctl = New System.Windows.Forms.CheckBox()
        CType(Me.mp3_files_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'main_label_lbl
        '
        Me.main_label_lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.main_label_lbl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_label_lbl.Location = New System.Drawing.Point(12, 9)
        Me.main_label_lbl.Name = "main_label_lbl"
        Me.main_label_lbl.Size = New System.Drawing.Size(710, 56)
        Me.main_label_lbl.TabIndex = 1
        Me.main_label_lbl.Text = "Please confirm which mp3s you want to download and then click on Ok."
        '
        'ok_btn
        '
        Me.ok_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ok_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok_btn.Location = New System.Drawing.Point(648, 290)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(74, 29)
        Me.ok_btn.TabIndex = 18
        Me.ok_btn.Text = "Ok"
        Me.ok_btn.UseVisualStyleBackColor = True
        '
        'mp3_files_grid
        '
        Me.mp3_files_grid.AllowUserToOrderColumns = True
        Me.mp3_files_grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mp3_files_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.mp3_files_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mp3_files_grid.DefaultCellStyle = DataGridViewCellStyle2
        Me.mp3_files_grid.Location = New System.Drawing.Point(12, 68)
        Me.mp3_files_grid.Name = "mp3_files_grid"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mp3_files_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.mp3_files_grid.Size = New System.Drawing.Size(710, 216)
        Me.mp3_files_grid.TabIndex = 20
        '
        'select_all_ctl
        '
        Me.select_all_ctl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.select_all_ctl.AutoSize = True
        Me.select_all_ctl.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.select_all_ctl.Enabled = False
        Me.select_all_ctl.Location = New System.Drawing.Point(548, 297)
        Me.select_all_ctl.Name = "select_all_ctl"
        Me.select_all_ctl.Size = New System.Drawing.Size(70, 17)
        Me.select_all_ctl.TabIndex = 21
        Me.select_all_ctl.Text = "Select All"
        Me.select_all_ctl.UseVisualStyleBackColor = True
        Me.select_all_ctl.Visible = False
        '
        'Select_mp3s_to_Download_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 331)
        Me.Controls.Add(Me.select_all_ctl)
        Me.Controls.Add(Me.mp3_files_grid)
        Me.Controls.Add(Me.ok_btn)
        Me.Controls.Add(Me.main_label_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Select_mp3s_to_Download_Form"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "mp3s Selection"
        Me.TopMost = True
        CType(Me.mp3_files_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents main_label_lbl As System.Windows.Forms.Label
    Friend WithEvents ok_btn As System.Windows.Forms.Button
    Friend WithEvents mp3_files_grid As System.Windows.Forms.DataGridView
    Friend WithEvents select_all_ctl As System.Windows.Forms.CheckBox
End Class
