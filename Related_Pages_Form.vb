Public Class Related_Pages_Form

    Private related_pages_i As Collection
    Private second_sweep_i As Boolean

    Private Sub yes_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yes_btn.Click

        DialogResult = Windows.Forms.DialogResult.Yes
        Close()

    End Sub

    Private Sub no_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no_btn.Click

        DialogResult = Windows.Forms.DialogResult.No
        Close()

    End Sub

    Public Sub set_related_pages(ByVal related_pages As Collection)

        related_pages_i = related_pages

    End Sub

    Public Sub set_second_sweep_mode(ByVal second_sweep As Boolean)

        second_sweep_i = second_sweep

    End Sub

    Private Sub Related_Pages_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim related_page As Object

        related_pages_list_ctl.Items.Clear()

        For Each related_page In related_pages_i
            related_pages_list_ctl.Items.Add(related_page(0))
        Next

        related_pages_list_ctl.HorizontalScrollbar = True

        If Not second_sweep_i Then
            Label1.Text = "The following web pages are linked from the web page you selected and look like they may contain related mp3s. Would you like to download any mp3s which are found on those pages as well?"
            Label2.Text = "Please note that if you choose Yes then any potentially related web pages which are found on these web pages will in turn be searched for related web pages, and this process may take some"            
        Else
            Label1.Text = "The following web pages are linked from the related web pages and look like they may contain related mp3s. Would you like to download any mp3s which are found on those pages as well?"
            Label2.Text = ""
        End If

        yes_btn.Focus()

    End Sub

End Class