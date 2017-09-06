<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookButtonBox
    Inherits System.Windows.Forms.UserControl

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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SpeakerBox = New System.Windows.Forms.PictureBox()
        Me.PreviousImage = New System.Windows.Forms.PictureBox()
        Me.NextImage = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeakerBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviousImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Alphabet_Soup.My.Resources.Resources.homeIcon
        Me.PictureBox1.Location = New System.Drawing.Point(189, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'SpeakerBox
        '
        Me.SpeakerBox.Image = Global.Alphabet_Soup.My.Resources.Resources.Question_Mark
        Me.SpeakerBox.Location = New System.Drawing.Point(189, 84)
        Me.SpeakerBox.Name = "SpeakerBox"
        Me.SpeakerBox.Size = New System.Drawing.Size(75, 75)
        Me.SpeakerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SpeakerBox.TabIndex = 3
        Me.SpeakerBox.TabStop = False
        '
        'PreviousImage
        '
        Me.PreviousImage.Image = Global.Alphabet_Soup.My.Resources.Resources.Back_Button
        Me.PreviousImage.Location = New System.Drawing.Point(15, 22)
        Me.PreviousImage.Name = "PreviousImage"
        Me.PreviousImage.Size = New System.Drawing.Size(117, 114)
        Me.PreviousImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PreviousImage.TabIndex = 1
        Me.PreviousImage.TabStop = False
        '
        'NextImage
        '
        Me.NextImage.Image = Global.Alphabet_Soup.My.Resources.Resources.Next_Button
        Me.NextImage.Location = New System.Drawing.Point(338, 22)
        Me.NextImage.Name = "NextImage"
        Me.NextImage.Size = New System.Drawing.Size(117, 114)
        Me.NextImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NextImage.TabIndex = 0
        Me.NextImage.TabStop = False
        '
        'BookButtonBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.SpeakerBox)
        Me.Controls.Add(Me.PreviousImage)
        Me.Controls.Add(Me.NextImage)
        Me.Name = "BookButtonBox"
        Me.Size = New System.Drawing.Size(470, 164)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeakerBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviousImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NextImage As PictureBox
    Friend WithEvents PreviousImage As PictureBox
    Friend WithEvents SpeakerBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
