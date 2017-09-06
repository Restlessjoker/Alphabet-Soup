Public Class PlaceholderControl
    Inherits PictureBox

    Public placeholderName As String

    Private Sub PlaceholderControl_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Dim placeholderForm As PlaceholderForm = New PlaceholderForm(placeholderName)
        placeholderForm.Show()
    End Sub
End Class
