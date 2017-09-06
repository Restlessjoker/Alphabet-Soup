Public Class WhatAmIPagePanel
    Inherits PagePanel

    Public word As Word

    Public Overrides Sub loadPage(page As Page, form As BookPanel)

        If word IsNot Nothing Then

            Dim lastPage As WhatAmIPage = myPage

            Me.Controls.Remove(word)

            For Each letter As Letter In lastPage.draggableLetters
                Me.Controls.Remove(letter)
            Next
            'Me.Controls.Remove(word(ctr))
            'Next
        End If

        Dim newPage As WhatAmIPage = page

        myForm = form
        myPage = newPage

        word = New Word(newPage.getLetters(), Me)
        word.Location = New Point(Me.Size.Width / 2 - word.Size.Width / 2, Me.Size.Height - word.Size.Height - 50)
        Me.Controls.Add(word)

        SetPicture(newPage)
        AddDragLetterControls(newPage)

        'Dim letters As List(Of Char) = myPage.getLetters()
        'Dim numOfLetters As Integer = letters.Count

        'For ctr As Integer = 0 To numOfLetters - 1
        'There was code here
        'AddHandler newLetter.DragEnter, AddressOf Letter_Hover

        'newLetter.Text = letters.ElementAt(ctr)
        'word.Add(newLetter)

        'Next
        'Me.Controls.AddRange(word.ToArray())
    End Sub

    Sub Letter_Hover(sender As Object, e As EventArgs)
        Dim letter As Letter = sender

        If letter.Text = "_" Then
            letter.BackColor = Color.Beige
        End If
    End Sub

    Private Sub SetPicture(page As WhatAmIPage)
        If isComplete() Then
            GamePicture.Image = page.completePhoto
        Else
            GamePicture.Image = page.unCompletePhoto
        End If

        GamePicture.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Public Sub UpdateStatus()
        Dim page As WhatAmIPage = myPage

        CheckIsComplete()

        'SetComplete()
        'page.UpdateStatus()

        SetPicture(page)
    End Sub

    Private Sub AddDragLetterControls(page As WhatAmIPage)

        Dim leftSideX = GamePicture.Bounds.Left - 20
        Dim rightSideX = GamePicture.Bounds.Right + 20

        Dim currentY = 10
        Dim letterSize = word.letterSize

        If letterSize < 35 Then
            letterSize = 18
        ElseIf letterSize < 60
            letterSize = 23
        Else
            letterSize = 35
        End If

        For i As Integer = 0 To page.draggableLetters.Count - 1
            Dim letter = page.draggableLetters(i)

            letter.Font = New Font("Times New Roman", letterSize, FontStyle.Bold)

            If i Mod 2 = 0 Then

                If i > 0 Then
                    currentY = currentY + letter.Height * 2
                End If

                letter.Location = New Point(leftSideX - letter.Width, currentY)
            Else
                letter.Location = New Point(rightSideX, currentY)
            End If


            letter.Visible = True
            letter.AutoSize = True
            letter.BackColor = Me.BackColor
            letter.Movable = True
            letter.loadLetter(Me)
            Me.Controls.Add(letter)
        Next

    End Sub

    Public Sub CheckIsComplete()
        Dim page As WhatAmIPage = myPage

        If page.missingLetters.Count = 0 Then
            SetComplete()
        Else
            SetInComplete()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PlayWordAudio()
    End Sub

    Public Sub PlayWordAudio()
        Dim page As WhatAmIPage = myPage

        SoundReferenceLibrary.PlayAudio(Page.word.ToUpper(), SoundReferenceLibrary.WORD)
    End Sub

End Class
