Public Class Word

    Public letters As List(Of Letter)
    Public myPage As PagePanel
    Public letterSize As Integer

    Public Sub New(word As List(Of Char), pagePanel As PagePanel)
        InitializeComponent()

        letters = New List(Of Letter)
        myPage = pagePanel

        Dim wordWidth As Integer = 0
        Dim wordHeight As Integer = 0

        letterSize = 60

        Dim letterCount As Integer = word.Count - 1

        If letterCount > 8 Then
            letterSize = 30
        ElseIf letterCount > 6 Then
            letterSize = 35
        End If

        For i As Integer = 0 To letterCount
            Dim newLetter As New Letter
            With newLetter
                .Font = New Font("Times New Roman", letterSize, FontStyle.Bold)
                Dim originX As Integer
                If i = 0 Then
                    originX = 0
                Else
                    originX = letters.ElementAt(i - 1).Location.X + letters.ElementAt(i - 1).Size.Width
                End If
                .Text = word.ElementAt(i)
                .Location = New Point(originX, 0)
                .Visible = True
                .AutoSize = True
                .Movable = False
                .BackColor = Me.BackColor
                .ForeColor = Color.Black
            End With

            newLetter.loadLetter(myPage)
            letters.Add(newLetter)
            Me.Controls.Add(newLetter)

            wordWidth = wordWidth + newLetter.Size.Width
            Console.WriteLine("{0} {1} {2}", wordHeight, wordWidth, newLetter.Text)
            If wordHeight < newLetter.Size.Height Then
                wordHeight = newLetter.Size.Height
            End If
        Next

        Me.Size = New Size(wordWidth, wordHeight)
    End Sub

    Public Sub New(word As List(Of Char), pagePanel As PagePanel, font As Font)
        InitializeComponent()

        letters = New List(Of Letter)
        myPage = pagePanel

        Dim wordWidth As Integer = 0
        Dim wordHeight As Integer = 0

        letterSize = font.Size

        Dim letterCount As Integer = word.Count - 1

        For i As Integer = 0 To letterCount
            Dim newLetter As New Letter
            With newLetter
                .Font = font
                Dim originX As Integer
                If i = 0 Then
                    originX = 0
                Else
                    originX = letters.ElementAt(i - 1).Location.X + letters.ElementAt(i - 1).Size.Width
                End If
                .Text = word.ElementAt(i)
                .Location = New Point(originX, 0)
                .Visible = True
                .AutoSize = True
                .Movable = False
                .BackColor = Me.BackColor
                .ForeColor = Color.Transparent
            End With

            newLetter.loadLetter(myPage)
            letters.Add(newLetter)
            Me.Controls.Add(newLetter)

            wordWidth = wordWidth + newLetter.Size.Width
            Console.WriteLine("{0} {1} {2}", wordHeight, wordWidth, newLetter.Text)
            If wordHeight < newLetter.Size.Height Then
                wordHeight = newLetter.Size.Height
            End If
        Next

        Me.Size = New Size(wordWidth, wordHeight)
    End Sub

    Public Sub UpdateWord(wordLetter As Letter, dragLetter As Letter, index As Integer)
        Dim waiPagePanel As WhatAmIPagePanel = myPage
        Dim waiPage As WhatAmIPage = waiPagePanel.myPage
        Dim word = waiPage.word.ToUpper()

        If CheckCorrectLetter(dragLetter, index, word) Then
            wordLetter.Text = dragLetter.Text
            wordLetter.BackColor = Color.Green

            waiPage.missingLetters.Remove(index)
            myPage.RemoveLetter(dragLetter)
            waiPage.draggableLetters.Remove(dragLetter)

            SoundReferenceLibrary.PlayAudio("", SoundReferenceLibrary.CORRECT)

            waiPagePanel.UpdateStatus()
        Else
            wordLetter.BackColor = Color.Red
            SoundReferenceLibrary.PlayAudio("", SoundReferenceLibrary.WRONG)
            dragLetter.Location = dragLetter.originalPoint
        End If

    End Sub

    Private Function CheckCorrectLetter(dragLetter As Letter, index As Integer, word As String) As Boolean
        Return dragLetter.Text.ToUpper() = word(index)
    End Function

    Public Sub CheckBounds()

        'For Each letter As Letter In letters

        'Next

    End Sub

    Public Function GetAsString()
        Dim str = ""

        For Each letter In letters
            str = str + letter.Text
        Next

        Return str
    End Function

End Class
