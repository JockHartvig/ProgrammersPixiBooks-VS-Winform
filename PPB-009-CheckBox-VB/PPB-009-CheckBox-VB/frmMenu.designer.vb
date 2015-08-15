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
        Me.btnForm11 = New System.Windows.Forms.Button()
        Me.btnForm12 = New System.Windows.Forms.Button()
        Me.btnForm13 = New System.Windows.Forms.Button()
        Me.btnForm14 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnForm0 = New System.Windows.Forms.Button()
        Me.btnForm01 = New System.Windows.Forms.Button()
        Me.btnForm1222 = New System.Windows.Forms.Button()
        Me.btnForm01A = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnForm11
        '
        Me.btnForm11.Location = New System.Drawing.Point(31, 92)
        Me.btnForm11.Name = "btnForm11"
        Me.btnForm11.Size = New System.Drawing.Size(196, 23)
        Me.btnForm11.TabIndex = 0
        Me.btnForm11.Text = "Form 11 - Two/Three State Demo"
        Me.btnForm11.UseVisualStyleBackColor = True
        '
        'btnForm12
        '
        Me.btnForm12.Location = New System.Drawing.Point(31, 121)
        Me.btnForm12.Name = "btnForm12"
        Me.btnForm12.Size = New System.Drawing.Size(179, 23)
        Me.btnForm12.TabIndex = 1
        Me.btnForm12.Text = "Form 12 -Programmatically Update of CheckBox"
        Me.btnForm12.UseVisualStyleBackColor = True
        '
        'btnForm13
        '
        Me.btnForm13.Location = New System.Drawing.Point(31, 150)
        Me.btnForm13.Name = "btnForm13"
        Me.btnForm13.Size = New System.Drawing.Size(179, 23)
        Me.btnForm13.TabIndex = 2
        Me.btnForm13.Text = "Form 13 - AutoCheck Property"
        Me.btnForm13.UseVisualStyleBackColor = True
        '
        'btnForm14
        '
        Me.btnForm14.Location = New System.Drawing.Point(280, 193)
        Me.btnForm14.Name = "btnForm14"
        Me.btnForm14.Size = New System.Drawing.Size(179, 23)
        Me.btnForm14.TabIndex = 3
        Me.btnForm14.Text = "Form 4 - Nested CheckBoxesBox Demo"
        Me.btnForm14.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(69, 193)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnForm0
        '
        Me.btnForm0.Location = New System.Drawing.Point(280, 39)
        Me.btnForm0.Name = "btnForm0"
        Me.btnForm0.Size = New System.Drawing.Size(179, 23)
        Me.btnForm0.TabIndex = 5
        Me.btnForm0.Text = "Form 0 - All in one"
        Me.btnForm0.UseVisualStyleBackColor = True
        '
        'btnForm01
        '
        Me.btnForm01.Location = New System.Drawing.Point(31, 28)
        Me.btnForm01.Name = "btnForm01"
        Me.btnForm01.Size = New System.Drawing.Size(196, 23)
        Me.btnForm01.TabIndex = 6
        Me.btnForm01.Text = "Form 1 - CheckBox created via IDE"
        Me.btnForm01.UseVisualStyleBackColor = True
        '
        'btnForm1222
        '
        Me.btnForm1222.Location = New System.Drawing.Point(31, 106)
        Me.btnForm1222.Name = "btnForm1222"
        Me.btnForm1222.Size = New System.Drawing.Size(179, 23)
        Me.btnForm1222.TabIndex = 0
        Me.btnForm1222.Text = "Form 11 - Two/Three State Demo"
        Me.btnForm1222.UseVisualStyleBackColor = True
        '
        'btnForm01A
        '
        Me.btnForm01A.Location = New System.Drawing.Point(31, 57)
        Me.btnForm01A.Name = "btnForm01A"
        Me.btnForm01A.Size = New System.Drawing.Size(196, 23)
        Me.btnForm01A.TabIndex = 7
        Me.btnForm01A.Text = "Form 1A - CheckBox properties,events, methods"
        Me.btnForm01A.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 257)
        Me.Controls.Add(Me.btnForm01A)
        Me.Controls.Add(Me.btnForm01)
        Me.Controls.Add(Me.btnForm0)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnForm14)
        Me.Controls.Add(Me.btnForm13)
        Me.Controls.Add(Me.btnForm12)
        Me.Controls.Add(Me.btnForm11)
        Me.Name = "frmMenu"
        Me.Text = "Programmers Pixi Book - CheckBox Demo program VB ver. 1.0 - Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnForm11 As System.Windows.Forms.Button
    Friend WithEvents btnForm12 As System.Windows.Forms.Button
    Friend WithEvents btnForm13 As System.Windows.Forms.Button
    Friend WithEvents btnForm14 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnForm0 As System.Windows.Forms.Button
    Friend WithEvents btnForm01 As System.Windows.Forms.Button
    Friend WithEvents btnForm1222 As System.Windows.Forms.Button
    Friend WithEvents btnForm01A As System.Windows.Forms.Button
End Class
