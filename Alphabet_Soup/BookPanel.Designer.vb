<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookPanel
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
        Me.BookButtonBox1 = New Alphabet_Soup.BookButtonBox()
        Me.SuspendLayout()
        '
        'BookButtonBox1
        '
        Me.BookButtonBox1.BackColor = System.Drawing.Color.Transparent
        Me.BookButtonBox1.Location = New System.Drawing.Point(28, 508)
        Me.BookButtonBox1.Name = "BookButtonBox1"
        Me.BookButtonBox1.Size = New System.Drawing.Size(470, 159)
        Me.BookButtonBox1.TabIndex = 2
        '
        'BookPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Alphabet_Soup.My.Resources.Resources.Page_Screen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.BookButtonBox1)
        Me.Name = "BookPanel"
        Me.Size = New System.Drawing.Size(530, 680)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BookButtonBox1 As Alphabet_Soup.BookButtonBox

End Class
