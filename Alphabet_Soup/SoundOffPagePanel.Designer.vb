<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoundOffPagePanel
    Inherits PagePanel

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LetterAudioControl4 = New Alphabet_Soup.LetterAudioControl()
        Me.LetterAudioControl3 = New Alphabet_Soup.LetterAudioControl()
        Me.LetterAudioControl2 = New Alphabet_Soup.LetterAudioControl()
        Me.LetterAudioControl1 = New Alphabet_Soup.LetterAudioControl()
        Me.SuspendLayout()
        '
        'LetterAudioControl4
        '
        Me.LetterAudioControl4.BackColor = System.Drawing.Color.Transparent
        Me.LetterAudioControl4.Location = New System.Drawing.Point(312, 267)
        Me.LetterAudioControl4.Name = "LetterAudioControl4"
        Me.LetterAudioControl4.Size = New System.Drawing.Size(136, 228)
        Me.LetterAudioControl4.TabIndex = 3
        '
        'LetterAudioControl3
        '
        Me.LetterAudioControl3.BackColor = System.Drawing.Color.Transparent
        Me.LetterAudioControl3.Location = New System.Drawing.Point(82, 267)
        Me.LetterAudioControl3.Name = "LetterAudioControl3"
        Me.LetterAudioControl3.Size = New System.Drawing.Size(136, 228)
        Me.LetterAudioControl3.TabIndex = 2
        '
        'LetterAudioControl2
        '
        Me.LetterAudioControl2.BackColor = System.Drawing.Color.Transparent
        Me.LetterAudioControl2.Location = New System.Drawing.Point(315, 45)
        Me.LetterAudioControl2.Name = "LetterAudioControl2"
        Me.LetterAudioControl2.Size = New System.Drawing.Size(133, 230)
        Me.LetterAudioControl2.TabIndex = 1
        '
        'LetterAudioControl1
        '
        Me.LetterAudioControl1.BackColor = System.Drawing.Color.Transparent
        Me.LetterAudioControl1.Location = New System.Drawing.Point(82, 45)
        Me.LetterAudioControl1.Name = "LetterAudioControl1"
        Me.LetterAudioControl1.Size = New System.Drawing.Size(136, 224)
        Me.LetterAudioControl1.TabIndex = 0
        '
        'SoundOffPagePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.LetterAudioControl4)
        Me.Controls.Add(Me.LetterAudioControl3)
        Me.Controls.Add(Me.LetterAudioControl2)
        Me.Controls.Add(Me.LetterAudioControl1)
        Me.Name = "SoundOffPagePanel"
        Me.Size = New System.Drawing.Size(530, 540)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LetterAudioControl1 As LetterAudioControl
    Friend WithEvents LetterAudioControl2 As LetterAudioControl
    Friend WithEvents LetterAudioControl3 As LetterAudioControl
    Friend WithEvents LetterAudioControl4 As LetterAudioControl
End Class
