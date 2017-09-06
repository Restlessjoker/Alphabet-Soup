Public Class GradePagePanel
    Inherits PagePanel

    Public panels As List(Of Panel)
    Private firstLoad = True

    Public Overrides Sub loadPage(page As Page, form As BookPanel)

        If firstLoad = False Then
            For Each panel In panels
                Controls.Remove(panel)
            Next
        End If

        myPage = page
        myForm = form

        PlaceholderControl1.placeholderName = "Achievements and improvement goals statistics"
        Dim newPage As GradePage = page
        Dim book As Book = newPage.book
        panels = New List(Of Panel)

        Dim completedPages = 0
        Dim completedHardPages = 0

        PictureBox1.Image = newPage.book.cover
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        For Each activityPage As Page In book.GetEasyPages()

            If activityPage.GetIsCompleted() Then
                completedPages = completedPages + 1
            End If

        Next

        For Each activityPage As Page In book.GetHardPages()

            If activityPage.GetIsCompleted() Then
                completedHardPages = completedHardPages + 1
            End If

        Next

        CreateGraph(New Point(EasyBox.Location.X, EasyBox.Location.Y + EasyBox.Height + 5), completedPages, book.GetEasyPages().Count())
        CreateGraph(New Point(HardBox.Location.X, HardBox.Location.Y + HardBox.Height + 5), completedHardPages, book.GetHardPages().Count())

        'EasyLabel.Text = completedPages.ToString() + "/" + book.GetEasyPages().Count().ToString()
        'HardLabel.Text = completedHardPages.ToString() + "/" + book.GetHardPages().Count().ToString()

        firstLoad = False
        SetComplete()
    End Sub

    Private Sub CreateGraph(point As Point, completedPages As Integer, numPages As Integer)

        Dim columns = 3
        Dim counter = completedPages
        Dim rowOffset As Integer = (numPages / columns) * 50
        'Dim pointY = point.Y + rowOffset

        For i = 0 To numPages - 1 Step columns
            For j As Integer = 0 To 2

                If (i + j) < numPages Then
                    Dim panel As New Panel
                    panel.Height = 50
                    panel.Width = 50
                    panel.BorderStyle = BorderStyle.FixedSingle
                    panel.Location = New Point(point.X + (panel.Width * j), point.Y + (panel.Height * i / columns))

                    If counter > 0 Then
                        panel.BackColor = Color.Green
                        counter = counter - 1
                    Else
                        panel.BackColor = Color.Red
                    End If



                    panels.Add(panel)
                    Controls.Add(panel)
                End If
            Next
        Next

    End Sub
End Class
