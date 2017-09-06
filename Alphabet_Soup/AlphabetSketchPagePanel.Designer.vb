<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlphabetSketchPagePanel
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PlaceholderControl1 = New Alphabet_Soup.PlaceholderControl()
        Me.PlaceholderControl2 = New Alphabet_Soup.PlaceholderControl()
        Me.PlaceholderControl3 = New Alphabet_Soup.PlaceholderControl()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlaceholderControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlaceholderControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlaceholderControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Alphabet_Soup.My.Resources.Resources.Note
        Me.PictureBox1.Location = New System.Drawing.Point(79, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PlaceholderControl1
        '
        Me.PlaceholderControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlaceholderControl1.Image = Global.Alphabet_Soup.My.Resources.Resources.PaintSplotch
        Me.PlaceholderControl1.Location = New System.Drawing.Point(215, 10)
        Me.PlaceholderControl1.Name = "PlaceholderControl1"
        Me.PlaceholderControl1.Size = New System.Drawing.Size(75, 75)
        Me.PlaceholderControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PlaceholderControl1.TabIndex = 1
        Me.PlaceholderControl1.TabStop = False
        '
        'PlaceholderControl2
        '
        Me.PlaceholderControl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlaceholderControl2.Image = Global.Alphabet_Soup.My.Resources.Resources.Erasor
        Me.PlaceholderControl2.Location = New System.Drawing.Point(296, 10)
        Me.PlaceholderControl2.Name = "PlaceholderControl2"
        Me.PlaceholderControl2.Size = New System.Drawing.Size(75, 75)
        Me.PlaceholderControl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PlaceholderControl2.TabIndex = 2
        Me.PlaceholderControl2.TabStop = False
        '
        'PlaceholderControl3
        '
        Me.PlaceholderControl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlaceholderControl3.Image = Global.Alphabet_Soup.My.Resources.Resources.LetterStyle
        Me.PlaceholderControl3.Location = New System.Drawing.Point(377, 10)
        Me.PlaceholderControl3.Name = "PlaceholderControl3"
        Me.PlaceholderControl3.Size = New System.Drawing.Size(75, 75)
        Me.PlaceholderControl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PlaceholderControl3.TabIndex = 3
        Me.PlaceholderControl3.TabStop = False
        '
        'AlphabetSketchPagePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PlaceholderControl3)
        Me.Controls.Add(Me.PlaceholderControl2)
        Me.Controls.Add(Me.PlaceholderControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AlphabetSketchPagePanel"
        Me.Size = New System.Drawing.Size(530, 527)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlaceholderControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlaceholderControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlaceholderControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PlaceholderControl1 As Alphabet_Soup.PlaceholderControl
    Friend WithEvents PlaceholderControl2 As Alphabet_Soup.PlaceholderControl
    Friend WithEvents PlaceholderControl3 As Alphabet_Soup.PlaceholderControl
End Class
