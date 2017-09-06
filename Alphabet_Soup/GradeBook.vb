Public Class GradeBook
    Inherits Book

    Public myForm As Form1

    Sub New(form As Form1, photo As Bitmap, bookTitle As String)
        MyBase.New(photo, bookTitle)
        myForm = form

        For Each book As Book In form.Books
            pages.Add(New GradePage(book))
        Next


    End Sub

End Class
