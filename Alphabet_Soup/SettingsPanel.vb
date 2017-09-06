Public Class SettingsPanel
    Dim fromProgram = False
    Public myForm As Form1

    Sub New(form As Form1)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        myForm = form

        PlaceholderControl1.placeholderName = "Add user feature"
        PlaceholderControl2.placeholderName = "Remove user feature"

        NoneCheckBox.Checked = True
        
        EasyCheckBox.Checked = True
        HardCheckBox.Checked = True

        ComboBox1.Text = 00
        ComboBox2.Text = 00

        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        Button1.Enabled = False
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        SoundReferenceLibrary.SetBackgroundAudio(TrackBar1.Value)
    End Sub

    Private Sub EasyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EasyCheckBox.CheckedChanged
        If EasyCheckBox.Checked = False And HardCheckBox.Checked = False Then
            HardCheckBox.Checked = True
        End If
        myForm.easyChecked = EasyCheckBox.Checked
    End Sub

    Private Sub HardCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles HardCheckBox.CheckedChanged
        If HardCheckBox.Checked = False And EasyCheckBox.Checked = False Then
            EasyCheckBox.Checked = True
        End If

        myForm.hardChecked = HardCheckBox.Checked
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Hide()
    End Sub

    Private Sub LimitBox_CheckedChanged(sender As Object, e As EventArgs) Handles LimitCheckBox.Click
        NoneCheckBox.Checked = False

        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        Button1.Enabled = True
    End Sub

    Private Sub NoneBox_CheckedChanged(sender As Object, e As EventArgs) Handles NoneCheckBox.Click
        LimitCheckBox.Checked = False

        myForm.limitSet = False

        ComboBox1.Text = 00
        ComboBox2.Text = 00

        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        Button1.Enabled = False
        myForm.Timer1.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim hours As Integer = ComboBox1.Text
        Dim min As Integer = ComboBox2.Text

        myForm.time = (hours * 3600) + (min * 60)
        myForm.limitSet = True
        myForm.currentTime = 0
        myForm.Timer1.Enabled = True
    End Sub
End Class
