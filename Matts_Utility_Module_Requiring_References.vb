Option Explicit On

Imports ADODB 'This needs a COM reference to be set for the project in question.
Imports CDO 'This needs a COM reference to be set for the project in question.

Module Matts_Utility_Module_Requiring_References

    'taken from http://social.msdn.microsoft.com/Forums/en-US/vbgeneral/thread/0ceadca6-dc14-45cb-9cd2-218b5364fff4

    Public Sub SavePage(ByVal Url As String, ByVal FilePath As String)

        'SavePage("http://forums.microsoft.com/MSDN/default.aspx", "C:\msdn.mht")

        Dim iMessage As CDO.Message = New CDO.Message
        Dim adodbstream As ADODB.Stream = New ADODB.Stream

        iMessage.CreateMHTMLBody(Url, CDO.CdoMHTMLFlags.cdoSuppressNone, "", "")

        adodbstream.Type = ADODB.StreamTypeEnum.adTypeText
        adodbstream.Charset = "US-ASCII"
        adodbstream.Open()
        iMessage.DataSource.SaveToObject(adodbstream, "_Stream")
        adodbstream.SaveToFile(FilePath, ADODB.SaveOptionsEnum.adSaveCreateOverWrite)

    End Sub

End Module
