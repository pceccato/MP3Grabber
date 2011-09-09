Option Explicit On

Public Class Progress_Form

    Private Sub cancel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_btn.Click

        cancel_download = True
        DialogResult = Windows.Forms.DialogResult.OK
        Close()

    End Sub

End Class