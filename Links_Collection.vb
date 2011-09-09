Option Explicit On

Public Class Links_Collection
    Inherits DictionaryBase 'CollectionBase

    Public Sub New()

    End Sub

    Public Sub New(ByVal links_collection As Collection)

        'Test
        'Dim test_collection As Collection
        'Populate the collection here
        'Dim test_coll As Links_Collection
        'test_coll = New Links_Collection(test_collection)

        '--------------

        'go round in a loop copying this collection across to your one. Add each component as an Array with the file name as the second element.

        Dim link_obj As Object
        Dim link As String
        Dim file_name As String
        Dim link_array() As String

        For Each link_obj In links_collection

            link = link_obj.ToString
            file_name = extract_file_name_from_mp3_link(link)
            link_array = {link, file_name}
            Me.Dictionary.Add(link, link_array)

        Next

    End Sub

    Public Sub remove_links(ByVal link_keys_to_remove As Collection)

        For Each link_key In link_keys_to_remove
            Me.Dictionary.Remove(link_key)
        Next

    End Sub

    Protected Overrides Sub Finalize()

        MyBase.Finalize()

    End Sub

    Sub remove_link(ByVal link_key As String)

        Me.Dictionary.Remove(link_key)

    End Sub

End Class
