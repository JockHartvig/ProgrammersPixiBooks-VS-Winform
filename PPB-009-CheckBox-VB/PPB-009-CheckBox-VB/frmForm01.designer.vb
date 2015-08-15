<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForm01
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
        Me.chkCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkCheckBox2 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'chkCheckBox1
        '
        Me.chkCheckBox1.AutoSize = True
        Me.chkCheckBox1.Location = New System.Drawing.Point(28, 47)
        Me.chkCheckBox1.Name = "chkCheckBox1"
        Me.chkCheckBox1.Size = New System.Drawing.Size(137, 17)
        Me.chkCheckBox1.TabIndex = 0
        Me.chkCheckBox1.Text = "CheckBox1 - Two state"
        Me.chkCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCheckBox1.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(28, 150)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 30)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkCheckBox2
        '
        Me.chkCheckBox2.AutoSize = True
        Me.chkCheckBox2.Location = New System.Drawing.Point(189, 47)
        Me.chkCheckBox2.Name = "chkCheckBox2"
        Me.chkCheckBox2.Size = New System.Drawing.Size(144, 17)
        Me.chkCheckBox2.TabIndex = 23
        Me.chkCheckBox2.Text = "CheckBox2 - Three state"
        Me.chkCheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCheckBox2.ThreeState = True
        Me.chkCheckBox2.UseVisualStyleBackColor = True
        '
        'frmForm01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 257)
        Me.Controls.Add(Me.chkCheckBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.chkCheckBox1)
        Me.Name = "frmForm01"
        Me.Text = "Form1 - CheckBox created via IDE - Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chkCheckBox2 As System.Windows.Forms.CheckBox

End Class
