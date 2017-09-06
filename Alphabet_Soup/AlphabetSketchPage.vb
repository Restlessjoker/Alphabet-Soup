Public Class AlphabetSketchPage
    Inherits Page

    Public word As String
    Public paintList As List(Of PictureBox)

    Sub New(word As String)
        MyBase.New()
        Me.word = word '.ToUpper()
        paintList = New List(Of PictureBox)
    End Sub

    Public Function getLetters() As List(Of Char)
        Dim letters As List(Of Char) = New List(Of Char)
        Dim length As Integer = word.Length

        For ctr As Integer = 0 To length - 1
            letters.Add(word(ctr))
        Next

        Return letters
    End Function

End Class