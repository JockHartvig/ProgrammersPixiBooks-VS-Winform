<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnForm1 = New System.Windows.Forms.Button()
        Me.btnForm9 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.btnForm4 = New System.Windows.Forms.Button()
        Me.btnForm3 = New System.Windows.Forms.Button()
        Me.btnForm8 = New System.Windows.Forms.Button()
        Me.btnForm0 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnForm1
        '
        Me.btnForm1.Location = New System.Drawing.Point(29, 50)
        Me.btnForm1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnForm1.Name = "btnForm1"
        Me.btnForm1.Size = New System.Drawing.Size(391, 30)
        Me.btnForm1.TabIndex = 0
        Me.btnForm1.Text = "Form 1 - Simple, Fixed data in Designer Items Collection"
        Me.btnForm1.UseVisualStyleBackColor = True
        '
        'btnForm9
        '
        Me.btnForm9.Location = New System.Drawing.Point(29, 396)
        Me.btnForm9.Margin = New System.Windows.Forms.Padding(4)
        Me.btnForm9.Name = "btnForm9"
        Me.btnForm9.Size = New System.Drawing.Size(391, 31)
        Me.btnForm9.TabIndex = 1
        Me.btnForm9.Text = "Form 9 - Pseudo Multi column combo box"
        Me.btnForm9.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(152, 451)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 28)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnForm2
        '
        Me.btnForm2.Location = New System.Drawing.Point(29, 87)
        Me.btnForm2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(391, 30)
        Me.btnForm2.TabIndex = 3
        Me.btnForm2.Text = "Form 2 - String array to DataSource property"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        'btnForm4
        '
        Me.btnForm4.Location = New System.Drawing.Point(29, 160)
        Me.btnForm4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnForm4.Name = "btnForm4"
        Me.btnForm4.Size = New System.Drawing.Size(391, 30)
        Me.btnForm4.TabIndex = 4
        Me.btnForm4.Text = "Form 4 - ArrayList"
        Me.btnForm4.UseVisualStyleBackColor = True
        '
        'btnForm3
        '
        Me.btnForm3.Location = New System.Drawing.Point(29, 124)
        Me.btnForm3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnForm3.Name = "btnForm3"
        Me.btnForm3.Size = New System.Drawing.Size(391, 28)
        Me.btnForm3.TabIndex = 5
        Me.btnForm3.Text = "Form 3 - Items.Add(...)"
        Me.btnForm3.UseVisualStyleBackColor = True
        '
        'btnForm8
        '
        Me.btnForm8.Location = New System.Drawing.Point(29, 358)
        Me.btnForm8.Margin = New System.Windows.Forms.Padding(4)
        Me.btnForm8.Name = "btnForm8"
        Me.btnForm8.Size = New System.Drawing.Size(391, 31)
        Me.btnForm8.TabIndex = 6
        Me.btnForm8.Text = "Form 8 - Programmatically add ComboBox"
        Me.btnForm8.UseVisualStyleBackColor = True
        '
        'btnForm0
        '
        Me.btnForm0.Location = New System.Drawing.Point(29, 14)
        Me.btnForm0.Margin = New System.Windows.Forms.Padding(4)
        Me.btnForm0.Name = "btnForm0"
        Me.btnForm0.Size = New System.Drawing.Size(391, 30)
        Me.btnForm0.TabIndex = 7
        Me.btnForm0.Text = "Form 0 - Behaviour Demo"
        Me.btnForm0.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 539)
        Me.Controls.Add(Me.btnForm0)
        Me.Controls.Add(Me.btnForm8)
        Me.Controls.Add(Me.btnForm3)
        Me.Controls.Add(Me.btnForm4)
        Me.Controls.Add(Me.btnForm2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnForm9)
        Me.Controls.Add(Me.btnForm1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnForm1 As System.Windows.Forms.Button
    Friend WithEvents btnForm9 As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnForm2 As System.Windows.Forms.Button
    Friend WithEvents btnForm4 As System.Windows.Forms.Button
    Friend WithEvents btnForm3 As System.Windows.Forms.Button
    Friend WithEvents btnForm8 As System.Windows.Forms.Button
    Friend WithEvents btnForm0 As System.Windows.Forms.Button
End Class
