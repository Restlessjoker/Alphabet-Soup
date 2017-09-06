Public MustInherit Class Book
    Public cover As Bitmap
    Protected pages As List(Of Page)
    Protected difficultPages As List(Of Page)
    Public difficulty As String
    Private currentPage As Integer
    Private currentDifficultPage As Integer

    Public Const EASY_CONSTANT As String = "EASY"
    Public Const DIFFICULT_CONSTANT As String = "HARD"

    Public bookTitle As String

    Sub New(photo As Bitmap, bookTitle As String)
        cover = photo
        pages = New List(Of Page)
        difficultPages = New List(Of Page)
        difficulty = EASY_CONSTANT
        currentPage = 0
        currentDifficultPage = 0
        Me.bookTitle = bookTitle.ToUpper()
    End Sub

    Public Sub SetDifficulty(diff As String)
        difficulty = diff
    End Sub

    Public Sub incrementPage()
        If (difficulty = EASY_CONSTANT) Then
            currentPage = currentPage + 1
        Else
            currentDifficultPage = currentDifficultPage + 1
        End If

    End Sub

    Public Sub decrementPage()
        If (difficulty = EASY_CONSTANT) Then
            currentPage = currentPage - 1
        Else
            currentDifficultPage = currentDifficultPage - 1
        End If
    End Sub

    Public Function GetCurrentPage() As Integer
        If (difficulty = EASY_CONSTANT) Then
            Return currentPage
        Else
            Return currentDifficultPage
        End If
    End Function

    Public Function GetPages() As List(Of Page)
        If (difficulty = EASY_CONSTANT) Then
            Return pages
        Else
            Return difficultPages
        End If
    End Function

    Public Function GetHardPages() As List(Of Page)
        Return difficultPages
    End Function

    Public Function GetEasyPages() As List(Of Page)
        Return pages
    End Function

End Class
