Option Explicit On

Public Class Web_Pages_to_Download_From

    Private all_web_pages As Collection
    Private all_mp3_links As Collection
    Private all_related_pages_links As Collection
    Private web_page_to_download_from_i As Web_Page_to_Download_From

    Public Sub New()

        all_web_pages = New Collection
        all_mp3_links = New Collection
        all_related_pages_links = New Collection

    End Sub

    Public Sub add_web_page(ByVal web_page_to_download_from_l As Web_Page_to_Download_From, Optional ByVal also_add_related_pages As Boolean = False)

        web_page_to_download_from_i = web_page_to_download_from_l
        If Not all_web_pages.Contains(web_page_to_download_from_i.get_web_address) Then all_web_pages.Add(web_page_to_download_from_i, web_page_to_download_from_i.get_web_address)
        update_all_mp3_links()
        update_all_related_pages()

    End Sub

    Private Sub update_all_mp3_links()

        Dim mp3_link As String

        For Each mp3_link In web_page_to_download_from_i.get_links()
            If Not all_mp3_links.Contains(mp3_link) Then all_mp3_links.Add(mp3_link, mp3_link)
        Next

    End Sub

    Private Sub update_all_related_pages()

        Dim related_page As Object
        Dim related_page_url As String

        For Each related_page In web_page_to_download_from_i.get_related_pages
            related_page_url = related_page(0)
            If Not all_related_pages_links.Contains(related_page_url) Then all_related_pages_links.Add(related_page, related_page_url)
        Next

    End Sub

    Public Function get_all_mp3_links() As Collection

        get_all_mp3_links = all_mp3_links

    End Function

    Public Function get_all_related_pages_links() As Collection

        get_all_related_pages_links = all_related_pages_links

    End Function

    Public Function get_all_web_pages() As Collection

        get_all_web_pages = all_web_pages

    End Function

    Protected Overrides Sub Finalize()

        MyBase.Finalize()

    End Sub

End Class
