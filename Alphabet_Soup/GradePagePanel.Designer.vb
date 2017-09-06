<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradePagePanel
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
        Me.PlaceholderControl1 = New Alphabet_Soup.PlaceholderControl()
        Me.HardBox = New System.Windows.Forms.PictureBox()
        Me.EasyBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PlaceholderControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HardBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EasyBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlaceholderControl1
        '
        Me.PlaceholderControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlaceholderControl1.Image = Global.Alphabet_Soup.My.Resources.Resources.Achievements
        Me.PlaceholderControl1.Location = New System.Drawing.Point(443, 19)
        Me.PlaceholderControl1.Name = "PlaceholderControl1"
        Me.PlaceholderControl1.Size = New System.Drawing.Size(62, 100)
        Me.PlaceholderControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PlaceholderControl1.TabIndex = 3
        Me.PlaceholderControl1.TabStop = False
        '
        'HardBox
        '
        Me.HardBox.Image = Global.Alphabet_Soup.My.Resources.Resources.Star2
        Me.HardBox.Location = New System.Drawing.Point(313, 230)
        Me.HardBox.Name = "HardBox"
        Me.HardBox.Size = New System.Drawing.Size(100, 50)
        Me.HardBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HardBox.TabIndex = 4
        Me.HardBox.TabStop = False
        '
        'EasyBox
        '
        Me.EasyBox.Image = Global.Alphabet_Soup.My.Resources.Resources.Star1
        Me.EasyBox.Location = New System.Drawing.Point(95, 230)
        Me.EasyBox.Name = "EasyBox"
        Me.EasyBox.Size = New System.Drawing.Size(50, 50)
        Me.EasyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EasyBox.TabIndex = 3
        Me.EasyBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(126, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 190)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GradePagePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PlaceholderControl1)
        Me.Controls.Add(Me.HardBox)
        Me.Controls.Add(Me.EasyBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "GradePagePanel"
        Me.Size = New System.Drawing.Size(530, 573)
        CType(Me.PlaceholderControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HardBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EasyBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EasyBox As PictureBox
    Friend WithEvents HardBox As PictureBox
    Friend WithEvents PlaceholderControl1 As Alphabet_Soup.PlaceholderControl
End Class
