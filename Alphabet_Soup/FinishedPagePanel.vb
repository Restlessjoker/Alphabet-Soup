Public Class FinishedPagePanel
    Inherits PagePanel

    Public Overrides Sub loadPage(page As Page, book As BookPanel)

        myPage = page
        myForm = book

        PictureBox1.Image = My.Resources.smiley
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

End Class
