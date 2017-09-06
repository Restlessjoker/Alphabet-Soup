Public Class FindMePage
    Inherits Page

    Public letter As Char
    Public numOfLetters As Integer
    Public isHard As Boolean

    Sub New(letter As Char, numOfLetters As Integer, isHard As Boolean)
        MyBase.New()
        Me.letter = letter
        Me.numOfLetters = numOfLetters
        Me.isHard = isHard
    End Sub

End Class
