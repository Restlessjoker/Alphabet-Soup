Public Class PlaceholderForm

    Public Sub New(placeholderName As String)
        InitializeComponent()

        Label1.Text = placeholderName + " is currently unavailable and will be present in a later build."
        Label1.Location = New Point(Me.Size.Width / 2 - Label1.Size.Width / 2, Label1.Location.Y)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class