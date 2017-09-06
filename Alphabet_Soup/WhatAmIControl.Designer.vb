<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhatAmIControl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.WhatAmIPagePanel1 = New Alphabet_Soup.WhatAmIPagePanel()
        Me.SuspendLayout()
        '
        'BookButtonBox1
        '
        Me.BookButtonBox1.Location = New System.Drawing.Point(35, 464)
        Me.BookButtonBox1.Name = "BookButtonBox1"
        Me.BookButtonBox1.Size = New System.Drawing.Size(467, 150)
        Me.BookButtonBox1.TabIndex = 0
        '
        'WhatAmIPagePanel1
        '
        Me.WhatAmIPagePanel1.Location = New System.Drawing.Point(35, 37)
        Me.WhatAmIPagePanel1.Name = "WhatAmIPagePanel1"
        Me.WhatAmIPagePanel1.Size = New System.Drawing.Size(150, 150)
        Me.WhatAmIPagePanel1.TabIndex = 1
        '
        'WhatAmIControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 626)
        Me.Controls.Add(Me.WhatAmIPagePanel1)
        Me.Controls.Add(Me.BookButtonBox1)
        Me.Name = "WhatAmIControl"
        Me.Text = "WhatAmIControl"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BookButtonBox1 As BookButtonBox
    Friend WithEvents WhatAmIPagePanel1 As Alphabet_Soup.WhatAmIPagePanel
End Class
