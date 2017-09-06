Public Class DifficultyPagePanel

    Public myBook As BookPanel

    Public Sub loadBook(book As BookPanel)
        myBook = book
    End Sub

    Private Sub HardLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) 

    End Sub

    Private Sub EasyLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) 

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        myBook.myBook.SetDifficulty(Book.EASY_CONSTANT)
        myBook.LoadCurrentBookPage()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        myBook.myBook.SetDifficulty(Book.DIFFICULT_CONSTANT)
        myBook.LoadCurrentBookPage()
    End Sub
End Class
