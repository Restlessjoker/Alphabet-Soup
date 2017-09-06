Public Class WhatAmIPage
    Inherits Page

    Public completePhoto As Bitmap
    Public unCompletePhoto As Bitmap
    Public word As String
    Public missingLetters As List(Of Integer)
    Public draggableLetters As List(Of Letter)
    Public alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

    Sub New(unComplete As Bitmap, complete As Bitmap, word As String, numOfmissingLetters As Integer, numOfDragLetters As Integer)
        MyBase.New()

        completePhoto = complete
        unCompletePhoto = unComplete
        Me.word = word.ToUpper()
        missingLetters = New List(Of Integer)
        draggableLetters = New List(Of Letter)

        setMissingLetters(numOfmissingLetters, word.Length - 1)
        setDraggableLetters(numOfmissingLetters, numOfDragLetters)
    End Sub


    Sub setMissingLetters(numOfLetters As Integer, wordLength As Integer)

        Dim ctr As Integer = 0

        While ctr < numOfLetters
            Dim value As Integer = getRandomNumber(wordLength)

            If missingLetters.Contains(value) = False Then
                missingLetters.Add(value)
                ctr = ctr + 1
            End If

        End While

    End Sub

    Sub setDraggableLetters(numOfLetters As Integer, numOfControls As Integer)

        Dim ctr As Integer = 0
        Dim missingCtr = 0

        Dim alphabetLength = alphabet.length
        Dim randomSpots = New List(Of Integer)

        While ctr < numOfLetters
            Dim value As Integer = getRandomNumber(numOfControls)

            If randomSpots.Contains(value) = False Then
                randomSpots.Add(value)
                ctr = ctr + 1
            End If

        End While

        ctr = 0

        While ctr < numOfControls
            Dim value As Integer = getRandomNumber(alphabetLength)
            Dim letter = New Letter()

            If randomSpots.Contains(ctr) Then
                letter.Text = word(missingLetters(missingCtr))

                missingCtr = missingCtr + 1
                randomSpots.Remove(ctr)
            Else
                letter.Text = alphabet(value)

            End If
            draggableLetters.Add(letter)

            ctr = ctr + 1

        End While

    End Sub

    Function getRandomNumber(max As Integer) As Integer
        Randomize()
        Dim value As Integer = CInt(Int((max * Rnd())))

        Return value
    End Function

    Public Function getLetters() As List(Of Char)
        Dim letters As List(Of Char) = New List(Of Char)
        Dim length As Integer = word.Length

        For ctr As Integer = 0 To length - 1

            If missingLetters.Contains(ctr) Then
                letters.Add("_")
            Else
                letters.Add(word(ctr))
            End If
        Next

        Return letters
    End Function

    Public Sub UpdateStatus()

        If missingLetters.Count = 0 Then
            SetComplete()
        Else
            SetInComplete()
        End If

    End Sub
End Class
