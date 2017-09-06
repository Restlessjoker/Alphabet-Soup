Imports System.Drawing.Text
Imports System.Runtime.InteropServices

Public Class AlphabetSketchPagePanel
    Inherits PagePanel

    Public word As Word
    Private isDrawing As Boolean
    Private drawDelay As Boolean

    Public Overrides Sub loadPage(page As Page, book As BookPanel)

        If word IsNot Nothing Then

            Dim lastPage As AlphabetSketchPage = myPage

            Me.Controls.Remove(word)

            For Each paint As PictureBox In lastPage.paintList
                Me.Controls.Remove(paint)
            Next
            'Me.Controls.Remove(word(ctr))
            'Next
        End If

        myPage = page
        myForm = book

        PlaceholderControl1.placeholderName = "Colour/brush selection"
        PlaceholderControl2.placeholderName = "Erasor"
        PlaceholderControl3.placeholderName = "Letter style selection"

        Dim newPage As AlphabetSketchPage = page

        Dim letters As List(Of Char) = newPage.getLetters()
        If letters.Count = 2 Then
            word = New Word(letters, Me, New Font("Arial", 180, FontStyle.Bold))
        ElseIf letters.Count = 3
            word = New Word(letters, Me, New Font("Arial", 120, FontStyle.Bold))
        Else
            word = New Word(letters, Me, New Font("Arial", 80, FontStyle.Bold))
        End If

        Dim pfc As PrivateFontCollection
        Try
            pfc = New PrivateFontCollection
            Dim fontMemPointer As IntPtr = Marshal.AllocCoTaskMem(My.Resources.LondrinaOutline_Regular.Length)
            Marshal.Copy(My.Resources.LondrinaOutline_Regular, 0, fontMemPointer, My.Resources.LondrinaOutline_Regular.Length)
            pfc.AddMemoryFont(fontMemPointer, My.Resources.LondrinaOutline_Regular.Length)
            Marshal.FreeCoTaskMem(fontMemPointer)

            Console.WriteLine("{0}", pfc.Families(0))

            Dim aFont As New Font(pfc.Families(0), 50, FontStyle.Regular)
            'word.Font = New Font(word.Font.FontFamily, 120, word.Font.Style)
            word.Location = New Point(Me.Size.Width / 2 - word.Size.Width / 2, Me.Size.Height / 2 - word.Size.Height / 2)
            Me.Controls.Add(word)
            word.Enabled = False

            'Dim label As Label = New Label
            'label.Font = New Font(pfc.Families(0), 50)
            'label.Text = "Hi"
            'label.AutoSize = True
            'Me.Controls.Add(label)
        Catch ex As Exception
            'ERROR LOADING FONT. HANDLE EXCEPTION HERE
        End Try

    End Sub

    Private Sub AlphabetSketchPagePanel_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        isDrawing = True
        drawDelay = False
    End Sub

    Private Sub AlphabetSketchPagePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        Dim newPage As AlphabetSketchPage = myPage
        Dim letters As List(Of Char) = newPage.getLetters()
        Dim size = New Size(25, 25)

        If letters.Count > 3 Then
            size = New Size(15, 15)
        End If

        If isDrawing Then
            If Not drawDelay Then
                Dim paint As PictureBox = New PictureBox
                paint.Size = size
                paint.BackColor = Color.Yellow
                paint.SizeMode = PictureBoxSizeMode.Zoom
                paint.Location = New Point(Me.PointToClient(MousePosition).X - paint.Size.Width / 2, Me.PointToClient(MousePosition).Y - paint.Size.Height / 2)
                paint.Enabled = False
                Me.Controls.Add(paint)
                paint.BringToFront()
                Me.Invalidate()

                Dim thisPage As AlphabetSketchPage = myPage
                thisPage.paintList.Add(paint)
                SetComplete()
            End If
            drawDelay = Not drawDelay
        End If
    End Sub

    Private Sub AlphabetSketchPagePanel_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        isDrawing = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim str = word.GetAsString()

        If str.length > 2 Then
            SoundReferenceLibrary.PlayAudio(str, SoundReferenceLibrary.WORD)
        Else
            SoundReferenceLibrary.PlayAudio(str(0), SoundReferenceLibrary.LETTER)
        End If
    End Sub
End Class
