Public Class Letter
    Inherits Label

    Public myPage As PagePanel
    Public originalColour As Color
    Public originalPoint As Point

    Public Sub loadLetter(page As PagePanel)
        myPage = page
        originalColour = Me.BackColor
        originalPoint = Me.Location
        BackColor = Color.Transparent
    End Sub


#Region "Drag and Drop"

    Private MouseX, MouseY As Integer
    Private DrawMode As Boolean = False
    Private Points As List(Of Point) = New List(Of Point)
    Private MousePoint As Point
    Private YellowPen As New Pen(Color.Yellow, 1)
    Private eMs As Object
    Public Movable As Boolean

    Private Sub Shape_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        MouseX = e.X
        MouseY = e.Y

        Cursor = Cursors.Hand

        Me.Capture = True
        Me.BringToFront()
    End Sub
    Private Sub Letter_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Me.Capture And Movable Then
            Dim myX = Me.Left + (e.X - MouseX)
            Dim myY = Me.Top + (e.Y - MouseY)

            If isWithinBounds(myX, myY) Then
                Me.Invalidate()
                MoveMe(myX, myY)
                checkForOverlap(False)
            End If

            If myPage.GetType Is GetType(FindMePagePanel) Then
                Dim page As FindMePagePanel = myPage
                page.LetterMoved(Me)
            End If

        ElseIf Me.DrawMode Then
            MousePoint = e.Location
            Refresh()
        End If
    End Sub
    Private Sub Letter_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Me.Capture = False
        Cursor = DefaultCursor
        checkForOverlap(True)
    End Sub

    Private Sub MoveMe(ByVal x As Integer, ByVal y As Integer)
        Me.Location = New Point(x, y)
    End Sub
#End Region

    Private Function isWithinBounds(newX As Integer, newY As Integer)
        Dim newXMax = newX + Me.Width
        Dim newYmax = newY + Me.Height

        If newYmax > myPage.Bounds.Bottom Or
            newY < myPage.Bounds.Top Or
            newX < myPage.Bounds.Left Or
            newXMax > myPage.Bounds.Right Then

            Return False
        End If

        Return True

    End Function

    Private Sub checkForOverlap(isMouseUpEvent As Boolean)
        If myPage.GetType Is GetType(WhatAmIPagePanel) Then
            Dim page As WhatAmIPagePanel = myPage
            Dim wordX = page.word.Bounds.Left
            Dim wordY = page.word.Bounds.Top
            Dim numOfLetters = page.word.letters.Count - 1

            For i As Integer = 0 To numOfLetters
                Dim letter = page.word.letters(i)

                If CheckIfOverlapped(Letter, wordX, wordY) Then
                    If isMouseUpEvent Then
                        page.word.UpdateWord(letter, Me, i)
                    Else
                        Letter.BackColor = Color.Blue
                    End If
                Else
                    Letter.BackColor = originalColour
                End If
            Next
        End If
    End Sub

    Public Function CheckIfOverlapped(letter As Letter, offsetX As Integer, offsetY As Integer) As Boolean

        Dim letterOffsetXmin = letter.Bounds.Left + offsetX
        Dim letterOffsetXmax = letter.Bounds.Right + offsetX

        Dim letterOffsetYmin = letter.Bounds.Top + offsetY
        Dim letterOffsetYmax = letter.Bounds.Bottom + offsetY
        If letter.Text = "_" And
            (letterOffsetXmin < Me.Bounds.Left And
                letterOffsetXmax > Me.Bounds.Right And
                letterOffsetYmin < Me.Bounds.Top And
                letterOffsetYmax > Me.Bounds.Bottom) Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class