Public Class SoundOffPagePanel
    Inherits PagePanel

    Public letterAudioControls As New List(Of LetterAudioControl)
    Public selectedControl As Integer

    Public Overrides Sub loadPage(page As Page, book As BookPanel)

        letterAudioControls = New List(Of LetterAudioControl)
        myPage = page
        myForm = book

        Dim newPage As SoundOffPage = page

        letterAudioControls.Add(LetterAudioControl1)
        letterAudioControls.Add(LetterAudioControl2)
        letterAudioControls.Add(LetterAudioControl3)
        letterAudioControls.Add(LetterAudioControl4)

        SetLetters(newPage)

        If selectedControl <> -1 Then
            letterAudioControls(selectedControl).LoseFocus()
            selectedControl = -1
        End If

    End Sub

    Private Sub SetLetters(page As SoundOffPage)
        Dim letters = page.GetLetters()

        LetterAudioControl1.SetLetter(letters(0), Me, 0)
        LetterAudioControl2.SetLetter(letters(1), Me, 1)
        LetterAudioControl3.SetLetter(letters(2), Me, 2)
        LetterAudioControl4.SetLetter(letters(3), Me, 3)
    End Sub

    Public Sub SetSelected(selected As Integer)

        If selectedControl <> -1 Then
            letterAudioControls(selectedControl).LoseFocus()
        End If

        'letterAudioControls(selected).SetFocus()

        selectedControl = selected
    End Sub

    Public Sub CheckCompleted()

        Dim counter = 0

        For Each audioControl In letterAudioControls
            If audioControl.GetIsSolved() Then
                counter = counter + 1
            End If
        Next

        If counter = letterAudioControls.Count Then
            SetComplete()
        Else
            SetInComplete()
        End If

    End Sub

End Class
