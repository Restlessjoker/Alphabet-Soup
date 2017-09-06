Public Class GradePage
    Inherits Page

    Public book As Book

    Sub New(book As Book)
        MyBase.New()
        Me.book = book
    End Sub

End Class
