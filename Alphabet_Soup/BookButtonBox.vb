Public Class BookButtonBox

    Public book As Book
    Public myForm As BookPanel

    Private Sub NextImage_Click(sender As Object, e As EventArgs) Handles NextImage.Click
        myForm.NextPage()
        CheckButtons()
    End Sub

    Private Sub PreviousImage_Click(sender As Object, e As EventArgs) Handles PreviousImage.Click
        myForm.PreviousPage()
        CheckButtons()
    End Sub

    Public Sub BookButtonBoxLoad(book As Book, myForm As BookPanel)
        Me.book = book
        Me.myForm = myForm
        CheckButtons()
    End Sub

    Private Sub BookButtonBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NextImage.Image = My.Resources.Next_Button
        PreviousImage.Image = My.Resources.Back_Button

        NextImage.SizeMode = PictureBoxSizeMode.StretchImage
        PreviousImage.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs)
        myForm.myForm.Controls.Remove(myForm)
    End Sub

    Public Sub CheckButtons()
        CheckNextButton()
        CheckBackButton()
        CheckSpeakerIcon()
    End Sub

    Public Sub CheckSpeakerIcon()
        If myForm.isTableOfContentsOpen Or book.GetCurrentPage >= book.GetPages().Count Then
            SpeakerBox.Hide()
        Else
            SpeakerBox.Show()
        End If
    End Sub

    Private Sub CheckNextButton()

        If myForm.isTableOfContentsOpen Then
            NextImage.Hide()
        ElseIf myForm.isGradeBook() = True And book.GetCurrentPage >= book.GetPages().Count - 1
            NextImage.Hide()
        ElseIf book.GetCurrentPage >= book.GetPages().Count
            NextImage.Hide()
        ElseIf book.GetPages(book.GetCurrentPage()).GetIsCompleted() And book.GetCurrentPage < book.GetPages().Count
            NextImage.Show()
        Else
            NextImage.Hide()
        End If
    End Sub

    Private Sub CheckBackButton()
        If myForm.isTableOfContentsOpen Then
            PreviousImage.Hide()
        ElseIf book.GetCurrentPage() = 0
            PreviousImage.Hide()
        Else
            PreviousImage.Show()
        End If
    End Sub

    Private Sub SpeakerBox_Click(sender As Object, e As EventArgs) Handles SpeakerBox.Click
        myForm.PlayInstruction()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        myForm.myForm.Controls.Remove(myForm)
    End Sub
End Class
