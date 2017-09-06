Public Class SoundOffPage
    Inherits Page

    Public letters As String
    Public textBoxList As List(Of Char)
    Private difficulty As String

    Sub New(letters As String, difficulty As String)
        MyBase.New()
        Me.letters = letters
        textBoxList = New List(Of Char)
        Me.difficulty = difficulty

        textBoxList.Add("")
        textBoxList.Add("")
        textBoxList.Add("")
        textBoxList.Add("")
    End Sub

    Public Function GetLetters() As List(Of Char)
        Dim letterList = New List(Of Char)

        For Each letter As Char In letters
            letterList.Add(letter)
        Next

        Return letterList
    End Function

    Public Sub SetTextBoxValue(index As Integer, value As Char)
        textBoxList(index) = value
    End Sub

    Public Function GetTextBoxList() As List(Of Char)
        Return textBoxList
    End Function

    Public Function GetIsEasyDifficulty()
        Return difficulty = Book.EASY_CONSTANT
    End Function

End Class
