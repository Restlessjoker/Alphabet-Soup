Public Class LetterAudioControl

    Private alphabetSound As IO.UnmanagedMemoryStream
    Private isSolved As Boolean = False
    Private expectedChar As Char
    Private originalColor As Color
    Private myPage As PagePanel
    Public num As Integer
    Private fromKeyPress As Boolean = False
    Private fromLoad As Boolean = False

    Public Sub SetLetter(letter As Char, page As PagePanel, numControl As Integer)
        fromLoad = True
        Label1.Text = letter
        expectedChar = letter.ToString().ToUpper
        myPage = page
        num = numControl
        originalColor = Color.Transparent

        Dim soundPanel As SoundOffPagePanel = page
        Dim soundOffPage As SoundOffPage = page.myPage

        TextBox1.Text = soundOffPage.GetTextBoxList()(num)
        SetPanelColour()
        soundPanel.CheckCompleted()

        fromLoad = False
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim page As SoundOffPagePanel = myPage

        page.SetSelected(num)
        Me.ForeColor = Color.Blue
        SoundReferenceLibrary.PlayAudio(expectedChar, SoundReferenceLibrary.LETTER)

    End Sub

    Public Function GetExpectedLetter() As Char
        Return expectedChar
    End Function

    Public Sub SetSolved()

        isSolved = True

    End Sub

    Public Sub SetUnSolved()
        isSolved = False
    End Sub

    Public Function GetIsSolved()
        Return isSolved
    End Function

    Public Sub SetPanelInCorrect()
        isSolved = False
        Panel1.BackColor = Color.Red

        Dim soundPage As SoundOffPage = myPage.myPage

        If fromLoad = False Then
            SoundReferenceLibrary.PlayAudio("", SoundReferenceLibrary.WRONG)
        End If

        If soundPage.GetIsEasyDifficulty() = False Then
            Label1.Hide()
        End If

    End Sub

    Public Sub SetPanelCorrect()
        SetSolved()
        Panel1.BackColor = Color.Green

        Dim soundPage As SoundOffPage = myPage.myPage

        If fromLoad = False Then
            SoundReferenceLibrary.PlayAudio("", SoundReferenceLibrary.CORRECT)
        End If

        If soundPage.GetIsEasyDifficulty() = False Then
            Label1.Show()
        End If

    End Sub

    Private Sub SetPanelColour()
        Dim soundPage As SoundOffPage = myPage.myPage

        If TextBox1.Text = "" Or TextBox1.Text = vbNullChar Then
            Panel1.BackColor = originalColor
            isSolved = False

            If soundPage.GetIsEasyDifficulty() = False Then
                Label1.Hide()
            End If
        ElseIf TextBox1.Text.ToUpper() = expectedChar
                SetPanelCorrect()
            Else
                SetPanelInCorrect()
            End If
    End Sub

    Public Sub SetFocus()
        Panel1.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Public Sub LoseFocus()
        Panel1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub TextBox1_Keypress(sender As Object, e As EventArgs) Handles TextBox1.KeyPress

        fromKeyPress = True
        If TextBox1.Text <> "" Then
            TextBox1.Text = ""
        End If
        fromKeyPress = False
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.Click
        If fromLoad = False Then
            Dim page As SoundOffPagePanel = myPage
            SetFocus()
            page.SetSelected(num)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If fromKeyPress = False Then

            Dim pagePanel As SoundOffPagePanel = myPage
            Dim page As SoundOffPage = pagePanel.myPage

            If TextBox1.Text = "" Or TextBox1.Text = vbNullChar Then
                Panel1.BackColor = originalColor
                isSolved = False

                If page.GetIsEasyDifficulty() = False Then
                    Label1.Hide()
                End If

            ElseIf TextBox1.Text.ToUpper() = expectedChar
                SetPanelCorrect()
            Else
                SetPanelInCorrect()
            End If

            page.SetTextBoxValue(num, TextBox1.Text)
            pagePanel.CheckCompleted()
        End If

    End Sub
End Class
