<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanel
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
        Me.components = New System.ComponentModel.Container()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HardCheckBox = New System.Windows.Forms.CheckBox()
        Me.EasyCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.NoneCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LimitCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PlaceholderControl2 = New Alphabet_Soup.PlaceholderControl()
        Me.PlaceholderControl1 = New Alphabet_Soup.PlaceholderControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PlaceholderControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlaceholderControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBar1.Location = New System.Drawing.Point(20, 63)
        Me.TrackBar1.Maximum = 500
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(379, 45)
        Me.TrackBar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 76)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Settings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Music Volume"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Difficulties"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Beige
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TrackBar1)
        Me.Panel1.Location = New System.Drawing.Point(51, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 113)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Beige
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.HardCheckBox)
        Me.Panel2.Controls.Add(Me.EasyCheckBox)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(51, 246)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(197, 99)
        Me.Panel2.TabIndex = 6
        '
        'HardCheckBox
        '
        Me.HardCheckBox.AutoSize = True
        Me.HardCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HardCheckBox.Location = New System.Drawing.Point(100, 63)
        Me.HardCheckBox.Name = "HardCheckBox"
        Me.HardCheckBox.Size = New System.Drawing.Size(63, 24)
        Me.HardCheckBox.TabIndex = 5
        Me.HardCheckBox.Text = "Hard"
        Me.HardCheckBox.UseVisualStyleBackColor = True
        '
        'EasyCheckBox
        '
        Me.EasyCheckBox.AutoSize = True
        Me.EasyCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EasyCheckBox.Location = New System.Drawing.Point(29, 63)
        Me.EasyCheckBox.Name = "EasyCheckBox"
        Me.EasyCheckBox.Size = New System.Drawing.Size(63, 24)
        Me.EasyCheckBox.TabIndex = 4
        Me.EasyCheckBox.Text = "Easy"
        Me.EasyCheckBox.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Beige
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.NoneCheckBox)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(269, 246)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(197, 261)
        Me.Panel3.TabIndex = 7
        '
        'NoneCheckBox
        '
        Me.NoneCheckBox.AutoSize = True
        Me.NoneCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NoneCheckBox.Location = New System.Drawing.Point(29, 63)
        Me.NoneCheckBox.Name = "NoneCheckBox"
        Me.NoneCheckBox.Size = New System.Drawing.Size(66, 24)
        Me.NoneCheckBox.TabIndex = 5
        Me.NoneCheckBox.Text = "None"
        Me.NoneCheckBox.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ComboBox2)
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.LimitCheckBox)
        Me.Panel4.Location = New System.Drawing.Point(14, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(169, 139)
        Me.Panel4.TabIndex = 4
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.ComboBox2.Location = New System.Drawing.Point(87, 74)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(45, 21)
        Me.ComboBox2.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ComboBox1.Location = New System.Drawing.Point(87, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(45, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Set"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(43, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Min"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(43, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Hour"
        '
        'LimitCheckBox
        '
        Me.LimitCheckBox.AutoSize = True
        Me.LimitCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LimitCheckBox.Location = New System.Drawing.Point(15, 12)
        Me.LimitCheckBox.Name = "LimitCheckBox"
        Me.LimitCheckBox.Size = New System.Drawing.Size(99, 24)
        Me.LimitCheckBox.TabIndex = 0
        Me.LimitCheckBox.Text = "Time Limit"
        Me.LimitCheckBox.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Session Limit"
        '
        'PlaceholderControl2
        '
        Me.PlaceholderControl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlaceholderControl2.Image = Global.Alphabet_Soup.My.Resources.Resources.UserRemove
        Me.PlaceholderControl2.Location = New System.Drawing.Point(104, 62)
        Me.PlaceholderControl2.Name = "PlaceholderControl2"
        Me.PlaceholderControl2.Size = New System.Drawing.Size(75, 75)
        Me.PlaceholderControl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PlaceholderControl2.TabIndex = 5
        Me.PlaceholderControl2.TabStop = False
        '
        'PlaceholderControl1
        '
        Me.PlaceholderControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlaceholderControl1.Image = Global.Alphabet_Soup.My.Resources.Resources.UserAdd
        Me.PlaceholderControl1.Location = New System.Drawing.Point(13, 62)
        Me.PlaceholderControl1.Name = "PlaceholderControl1"
        Me.PlaceholderControl1.Size = New System.Drawing.Size(75, 75)
        Me.PlaceholderControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PlaceholderControl1.TabIndex = 4
        Me.PlaceholderControl1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Alphabet_Soup.My.Resources.Resources.homeIcon
        Me.PictureBox1.Location = New System.Drawing.Point(216, 557)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Beige
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.PlaceholderControl2)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.PlaceholderControl1)
        Me.Panel5.Location = New System.Drawing.Point(51, 355)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(197, 152)
        Me.Panel5.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 31)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Users"
        '
        'SettingsPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SettingsPanel"
        Me.Size = New System.Drawing.Size(524, 680)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PlaceholderControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlaceholderControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HardCheckBox As CheckBox
    Friend WithEvents EasyCheckBox As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NoneCheckBox As CheckBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LimitCheckBox As CheckBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PlaceholderControl2 As Alphabet_Soup.PlaceholderControl
    Friend WithEvents PlaceholderControl1 As Alphabet_Soup.PlaceholderControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
