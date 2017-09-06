Public Class Form1

    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Public Books As List(Of Book)
    Public GradeBook As Book
    Public currentVolume = 150
    Public settings As SettingsPanel
    Public easyChecked As Boolean = True
    Public hardChecked As Boolean = False
    Public time As Integer = 0
    Public limitSet As Boolean = False
    Public currentTime As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Books = New List(Of Book)

        Books.Add(New FindMeBook(My.Resources.cover_findme, "FIND ME"))
        Books.Add(New AlphabetSketchBook(My.Resources.cover_alphabetsketch, "ALPHABET SKETCH"))
        Books.Add(New SoundOffBook(My.Resources.cover_soundoff, "SOUND OFF"))
        'Books.Add(New WhatAmIBook(My.Resources.cover_tapit))
        Books.Add(New WhatAmIBook(My.Resources.cover_whatami, "WHAT AM I"))

        GradeBook = New GradeBook(Me, My.Resources.Grade_Book_Cover, "GRADE BOOK")
        SoundReferenceLibrary.playSoundEffect(My.Resources.bensound_littleidea)
        settings = New SettingsPanel(Me)

        settings.TrackBar1.Value = currentVolume
        Controls.Add(settings)
        settings.Hide()
        'My.Computer.Audio.Play(My.Resources.bensound_littleidea, AudioPlayMode.BackgroundLoop) 'Music: http://www.bensound.com
    End Sub

    Public Sub ResetBooks()
        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click
        ResetBooks()

        If sender Is PictureBox1 Then
            BookControl1.BookControlLoad(Me, Books.ElementAt(0))
            PictureBox1.Visible = False
        ElseIf sender Is PictureBox2 Then
            BookControl1.BookControlLoad(Me, Books.ElementAt(1))
            PictureBox2.Visible = False
        ElseIf sender Is PictureBox3 Then
            BookControl1.BookControlLoad(Me, Books.ElementAt(2))
            PictureBox3.Visible = False
        ElseIf sender Is PictureBox4 Then
            BookControl1.BookControlLoad(Me, GradeBook)
            PictureBox4.Visible = False
        Else
            BookControl1.BookControlLoad(Me, Books.ElementAt(3))
            PictureBox5.Visible = False
        End If

        BookControl1.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        settings.Show()
        settings.BringToFront()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If limitSet Then
            currentTime += 1

            If currentTime >= time Then
                Me.Close()
            End If

        End If
    End Sub
End Class
