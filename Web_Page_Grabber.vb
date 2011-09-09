Option Explicit On

Imports ADODB
Imports CDO

'taken from http://social.msdn.microsoft.com/Forums/en-US/vbgeneral/thread/0ceadca6-dc14-45cb-9cd2-218b5364fff4

Public Class Web_Page_Grabber

    'SavePage("http://forums.microsoft.com/MSDN/default.aspx", "C:\msdn.mht")

    Public Sub SavePage(ByVal Url As String, ByVal FilePath As String)

        Dim iMessage As CDO.Message = New CDO.Message
        Dim adodbstream As ADODB.Stream = New ADODB.Stream

        iMessage.CreateMHTMLBody(Url, CDO.CdoMHTMLFlags.cdoSuppressNone, "", "")

        adodbstream.Type = ADODB.StreamTypeEnum.adTypeText
        adodbstream.Charset = "US-ASCII"
        adodbstream.Open()
        iMessage.DataSource.SaveToObject(adodbstream, "_Stream")
        adodbstream.SaveToFile(FilePath, ADODB.SaveOptionsEnum.adSaveCreateOverWrite)

    End Sub

End Class