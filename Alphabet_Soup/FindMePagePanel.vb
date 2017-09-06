Public Class FindMePagePanel
    Inherits PagePanel

    Private letter As Letter
    Private letterList As List(Of Letter)
    Private alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"

    Public Overrides Sub loadPage(page As Page, form As BookPanel)
        ClearLetters()

        myForm = form
        myPage = page

        letterList = New List(Of Letter)

        PictureBox1.Image = My.Resources.ChestOpen

        Dim newPage As FindMePage = myPage
        Label2.Text = newPage.letter.ToString.ToUpper

        GenerateLetters()
    End Sub

    Private Sub GenerateLetters()
        Randomize()

        Dim newPage As FindMePage = myPage

        letter = New Letter
        letter.Visible = True
        letter.Font = New Font("Times New Roman", 60, FontStyle.Bold)
        letter.Text = newPage.letter
        letter.AutoSize = True
        letter.BackColor = Me.BackColor
        letter.ForeColor = Color.Blue
        letter.Movable = True

        Dim maxX = Me.Size.Width - letter.Size.Width
        Dim minY = 100
        Dim maxY = Me.Size.Height - letter.Size.Height - 200 - minY
        Dim x As Integer = CInt(Int(maxX * Rnd()))
        Dim y As Integer = CInt(Int((maxY * Rnd()) + minY))
        letter.Location = New Point(x, y)

        letter.loadLetter(Me)
        Me.Controls.Add(letter)

        GenerateRandomLetters()
    End Sub

    Private Sub GenerateRandomLetters()
        Dim newPage As FindMePage = myPage

        For i As Integer = 1 To newPage.numOfLetters
            Dim aLetter As Letter = New Letter
            aLetter.Visible = True
            aLetter.Font = New Font("Times New Roman", 60, FontStyle.Bold)

            aLetter.Text = letter.Text
            While aLetter.Text.ToUpper = letter.Text.ToUpper
                If newPage.isHard Then
                    aLetter.Text = alphabet(CInt(Int(52 * Rnd())))
                Else
                    aLetter.Text = alphabet(CInt(Int(26 * Rnd())))
                End If
            End While

            aLetter.AutoSize = True
            aLetter.BackColor = Me.BackColor
            aLetter.ForeColor = Color.Blue
            aLetter.Movable = True

            Dim maxX = Me.Size.Width - letter.Size.Width
            Dim minY = 100
            Dim maxY = Me.Size.Height - letter.Size.Height - 200 - minY
            Dim x As Integer = CInt(Int(maxX * Rnd()))
            Dim y As Integer = CInt(Int((maxY * Rnd()) + minY))
            aLetter.Location = New Point(x, y)

            aLetter.loadLetter(Me)
            Me.Controls.Add(aLetter)
            letterList.Add(aLetter)
        Next
    End Sub

    Private Sub ClearLetters()
        Me.Controls.Remove(letter)

        If Not letterList Is Nothing Then
            For Each aLetter As Letter In letterList
                Me.Controls.Remove(aLetter)
            Next
        End If
    End Sub

    Public Sub LetterMoved(letter As Letter)
        If LetterIsOnChest(letter) Then
            If letter Is Me.letter Then
                PictureBox1.Image = My.Resources.ChestClosed
                SoundReferenceLibrary.PlayAudio("", SoundReferenceLibrary.CORRECT)
                ClearLetters()
                SetComplete()
            Else
                SoundReferenceLibrary.PlayAudio("", SoundReferenceLibrary.WRONG)
                letter.ForeColor = Color.Red
            End If
        Else
            letter.ForeColor = Color.Blue
        End If
    End Sub

    Private Function LetterIsOnChest(letter As Letter) As Boolean
        Dim centerX As Integer = letter.Location.X + letter.Size.Width / 2
        Dim centerY As Integer = letter.Location.Y + letter.Size.Height / 2

        If centerX > PictureBox1.Location.X And centerX < PictureBox1.Location.X + PictureBox1.Size.Width And centerY > PictureBox1.Location.Y And centerY < PictureBox1.Location.Y + PictureBox1.Size.Height Then
            Return True
        End If

        Return False
    End Function

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim newPage As FindMePage = myPage
        SoundReferenceLibrary.PlayAudio(newPage.letter.ToString.ToUpper, SoundReferenceLibrary.LETTER)
    End Sub
End Class
