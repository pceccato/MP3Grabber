<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Related_Pages_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Related_Pages_Form))
        Me.related_pages_list_ctl = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.no_btn = New System.Windows.Forms.Button()
        Me.yes_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'related_pages_list_ctl
        '
        Me.related_pages_list_ctl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.related_pages_list_ctl.FormattingEnabled = True
        Me.related_pages_list_ctl.Location = New System.Drawing.Point(12, 85)
        Me.related_pages_list_ctl.Name = "related_pages_list_ctl"
        Me.related_pages_list_ctl.Size = New System.Drawing.Size(710, 329)
        Me.related_pages_list_ctl.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(710, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "The following web pages are linked from the web page you selected and look like t" & _
            "hey may contain related mp3s. Would you like to download any mp3s which are foun" & _
            "d on those pages as well?"
        '
        'no_btn
        '
        Me.no_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.no_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_btn.Location = New System.Drawing.Point(648, 421)
        Me.no_btn.Name = "no_btn"
        Me.no_btn.Size = New System.Drawing.Size(74, 29)
        Me.no_btn.TabIndex = 18
        Me.no_btn.Text = "No"
        Me.no_btn.UseVisualStyleBackColor = True
        '
        'yes_btn
        '
        Me.yes_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.yes_btn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yes_btn.Location = New System.Drawing.Point(568, 421)
        Me.yes_btn.Name = "yes_btn"
        Me.yes_btn.Size = New System.Drawing.Size(74, 29)
        Me.yes_btn.TabIndex = 19
        Me.yes_btn.Text = "Yes"
        Me.yes_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(710, 34)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Please note that if you choose Yes then any potentially related web pages which a" & _
            "re found on these web pages will in turn be searched for related web pages, and " & _
            "this process may take some time."
        '
        'Related_Pages_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 462)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.yes_btn)
        Me.Controls.Add(Me.no_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.related_pages_list_ctl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Related_Pages_Form"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Related Pages"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents related_pages_list_ctl As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents no_btn As System.Windows.Forms.Button
    Friend WithEvents yes_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
