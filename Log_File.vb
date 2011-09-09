Option Explicit On

Imports Microsoft.VisualBasic.FileIO.FileSystem 'for GetDirectoryInfo, DirectoryInfo, GetFileInfo & FileInfo
Imports System.IO 'for file stuff.

Public Class log_file
    'Inherits System.IO.FileStream
    'MyBase.New(file_path, FileMode.Open)

    Private log_file_path As String
    Private log_file_r As StreamReader
    Private log_file_w As StreamWriter

    Private length_of_header_info As Integer

    Public Sub New(ByVal file_path As String)

        Dim example_date_string As String

        log_file_path = file_path
        If Not GetFileInfo(log_file_path).Exists Then
            log_file_w = File.CreateText(log_file_path)
            log_file_w.WriteLine("Log file created " & Now())
            log_file_w.WriteLine("")
            log_file_w.Flush()
            log_file_w.Dispose()
            log_file_w.Close()
        End If

        example_date_string = FormatDateTime(Now(), DateFormat.GeneralDate)
        length_of_header_info = Len(example_date_string) + 4

    End Sub

    Public Sub write_log(ByVal log_detail As String)

        log_file_w = New StreamWriter(log_file_path, True)

        'this doesn't append, it overwrites!

        log_file_w.WriteLine(log_detail)

        log_file_w.Flush()
        log_file_w.Dispose()
        log_file_w.Close()
        log_file_w = Nothing

    End Sub

    Public Sub write_log(ByVal log_detail_collection As SortedDictionary(Of String, String), Optional ByVal failed As Boolean = False)

        Dim log_detail As KeyValuePair(Of String, String)
        Dim date_time_string As String
        Dim succeeded_or_failed As String

        If failed Then
            succeeded_or_failed = "F_"
        Else
            succeeded_or_failed = "S_"
        End If

        log_file_w = New StreamWriter(log_file_path, True) ' File.CreateText(log_file_path) 'Apparently this should create a new or open an existing file.

        For Each log_detail In log_detail_collection
            date_time_string = FormatDateTime(Now(), DateFormat.GeneralDate) 'HAVE TO FIGURE OUT HOW TO FORCE THIS TO A STANDARDISED FORMAT.
            log_file_w.WriteLine(date_time_string & ":_" & succeeded_or_failed & log_detail.Value)
        Next

        log_file_w.Flush()
        log_file_w.Dispose()
        log_file_w.Close()

    End Sub

    Public Function read_log() As String

        If GetFileInfo(log_file_path).Exists Then
            log_file_r = New StreamReader(log_file_path)
            read_log = log_file_r.ReadToEnd
            log_file_r.Dispose()
            log_file_r.Close()
        Else
            read_log = ""
        End If

    End Function

    Public Function strings_found_in_log(ByVal search_strings As Links_Collection, ByVal only_return_successfully_downloaded As Boolean) As Collection

        Dim file_contents As String
        Dim position_of_string As Long
        Dim temp_collection As New Collection
        Dim search_string As Object
        Dim file_name As String
        Dim date_string As String
        Dim success_or_failure As String

        file_contents = read_log()

        For Each search_string In search_strings

            file_name = search_string.Value(1)
            Debug.Print("Checking: " & file_name)

            Debug.Assert(file_name <> "preview_armin-van-buuren-vs-sophie-ellis-bextor-not-giving-up-on-love-armin-van-buuren-remix-armada.mp3")

            position_of_string = 1

            Do Until position_of_string = 0

                position_of_string = InStr(position_of_string + 1, file_contents, file_name, CompareMethod.Text)

                If position_of_string > 0 Then
                    success_or_failure = Mid(file_contents, position_of_string - 3, 3)
                    If Not only_return_successfully_downloaded Or success_or_failure = "_S_" Then
                        date_string = Mid(file_contents, position_of_string - length_of_header_info, length_of_header_info - 4)
                        temp_collection.Add({search_string.Value(0), file_name, success_or_failure, date_string})
                        position_of_string = 0 'To make us come out of the loop.
                    End If
                End If

            Loop

        Next

        strings_found_in_log = temp_collection

    End Function

End Class
