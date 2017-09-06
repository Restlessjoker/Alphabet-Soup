Public Class BookControl

    Public selectedBook As Book
    Public myForm As Form1

    Private Sub Check_Mark_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim bookPanel As New BookPanel(selectedBook, myForm)
        myForm.Controls.Add(bookPanel)
        bookPanel.Show()
        bookPanel.BringToFront()
        Me.Hide()
        myForm.ResetBooks()
    End Sub

    Private Sub X_Mark_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        myForm.ResetBooks()
    End Sub

    Public Sub BookControlLoad(myForm As Form, book As Book)

        PictureBox1.Image = book.cover
        PictureBox2.Image = My.Resources.x_mark_large
        PictureBox3.Image = My.Resources.Check_mark

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage

        selectedBook = book
        Me.myForm = myForm

        SoundReferenceLibrary.PlayAudio(selectedBook.bookTitle, SoundReferenceLibrary.TITLE)

    End Sub
End Class
