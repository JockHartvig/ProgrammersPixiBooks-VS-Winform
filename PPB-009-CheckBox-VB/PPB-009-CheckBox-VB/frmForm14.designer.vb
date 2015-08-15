<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForm14
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
        Me.chkCheckBox3 = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chkCheckBox2 = New System.Windows.Forms.CheckBox()
        Me.chkCheckBox4 = New System.Windows.Forms.CheckBox()
        Me.chkCheckBox5 = New System.Windows.Forms.CheckBox()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.txtTextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'chkCheckBox3
        '
        Me.chkCheckBox3.AutoSize = True
        Me.chkCheckBox3.Enabled = False
        Me.chkCheckBox3.Location = New System.Drawing.Point(58, 130)
        Me.chkCheckBox3.Name = "chkCheckBox3"
        Me.chkCheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.chkCheckBox3.TabIndex = 2
        Me.chkCheckBox3.Text = "CheckBox3"
        Me.chkCheckBox3.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 335)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 28)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkCheckBox1
        '
        Me.chkCheckBox1.AutoSize = True
        Me.chkCheckBox1.Checked = True
        Me.chkCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCheckBox1.Location = New System.Drawing.Point(12, 47)
        Me.chkCheckBox1.Name = "chkCheckBox1"
        Me.chkCheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.chkCheckBox1.TabIndex = 0
        Me.chkCheckBox1.Text = "CheckBox1"
        Me.chkCheckBox1.UseVisualStyleBackColor = True
        '
        'chkCheckBox2
        '
        Me.chkCheckBox2.AutoSize = True
        Me.chkCheckBox2.Location = New System.Drawing.Point(33, 107)
        Me.chkCheckBox2.Name = "chkCheckBox2"
        Me.chkCheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.chkCheckBox2.TabIndex = 1
        Me.chkCheckBox2.Text = "CheckBox2"
        Me.chkCheckBox2.UseVisualStyleBackColor = True
        '
        'chkCheckBox4
        '
        Me.chkCheckBox4.AutoSize = True
        Me.chkCheckBox4.Location = New System.Drawing.Point(33, 170)
        Me.chkCheckBox4.Name = "chkCheckBox4"
        Me.chkCheckBox4.Size = New System.Drawing.Size(81, 17)
        Me.chkCheckBox4.TabIndex = 0
        Me.chkCheckBox4.Text = "CheckBox4"
        Me.chkCheckBox4.UseVisualStyleBackColor = True
        '
        'chkCheckBox5
        '
        Me.chkCheckBox5.AutoSize = True
        Me.chkCheckBox5.Location = New System.Drawing.Point(8, 212)
        Me.chkCheckBox5.Name = "chkCheckBox5"
        Me.chkCheckBox5.Size = New System.Drawing.Size(81, 17)
        Me.chkCheckBox5.TabIndex = 1
        Me.chkCheckBox5.Text = "CheckBox5"
        Me.chkCheckBox5.UseVisualStyleBackColor = True
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(32, 84)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(39, 13)
        Me.lblLabel2.TabIndex = 4
        Me.lblLabel2.Text = "Label2"
        '
        'txtTextBox2
        '
        Me.txtTextBox2.Location = New System.Drawing.Point(77, 81)
        Me.txtTextBox2.Name = "txtTextBox2"
        Me.txtTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.txtTextBox2.TabIndex = 5
        '
        'frmForm4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 375)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.txtTextBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.chkCheckBox4)
        Me.Controls.Add(Me.chkCheckBox5)
        Me.Controls.Add(Me.chkCheckBox1)
        Me.Controls.Add(Me.chkCheckBox3)
        Me.Controls.Add(Me.chkCheckBox2)
        Me.Name = "frmForm4"
        Me.Text = "frmForm4 - Multiple dependent CheckBoxes Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkCheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chkCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents lblLabel2 As System.Windows.Forms.Label
    Friend WithEvents txtTextBox2 As System.Windows.Forms.TextBox
End Class
