<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForm13
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
        Me.txtchkCheckBox1_Checked = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtchkCheckBox1_CheckState = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkAutoCheck = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'chkCheckBox1
        '
        Me.chkCheckBox1.AutoCheck = False
        Me.chkCheckBox1.AutoSize = True
        Me.chkCheckBox1.Location = New System.Drawing.Point(149, 48)
        Me.chkCheckBox1.Name = "chkCheckBox1"
        Me.chkCheckBox1.Size = New System.Drawing.Size(137, 17)
        Me.chkCheckBox1.TabIndex = 0
        Me.chkCheckBox1.Text = "CheckBox1 - Two state"
        Me.chkCheckBox1.UseVisualStyleBackColor = True
        '
        'txtchkCheckBox1_Checked
        '
        Me.txtchkCheckBox1_Checked.Enabled = False
        Me.txtchkCheckBox1_Checked.Location = New System.Drawing.Point(149, 72)
        Me.txtchkCheckBox1_Checked.Name = "txtchkCheckBox1_Checked"
        Me.txtchkCheckBox1_Checked.Size = New System.Drawing.Size(100, 20)
        Me.txtchkCheckBox1_Checked.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Checked"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CheckBox Property"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CheckState"
        '
        'txtchkCheckBox1_CheckState
        '
        Me.txtchkCheckBox1_CheckState.Enabled = False
        Me.txtchkCheckBox1_CheckState.Location = New System.Drawing.Point(149, 98)
        Me.txtchkCheckBox1_CheckState.Name = "txtchkCheckBox1_CheckState"
        Me.txtchkCheckBox1_CheckState.Size = New System.Drawing.Size(100, 20)
        Me.txtchkCheckBox1_CheckState.TabIndex = 5
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(149, 279)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(163, 212)
        Me.ListBox1.TabIndex = 20
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(210, 508)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 30)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkAutoCheck
        '
        Me.chkAutoCheck.AutoSize = True
        Me.chkAutoCheck.Checked = True
        Me.chkAutoCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoCheck.Location = New System.Drawing.Point(149, 124)
        Me.chkAutoCheck.Name = "chkAutoCheck"
        Me.chkAutoCheck.Size = New System.Drawing.Size(121, 17)
        Me.chkAutoCheck.TabIndex = 2
        Me.chkAutoCheck.Text = "AutoCheck Property"
        Me.chkAutoCheck.UseVisualStyleBackColor = True
        '
        'frmForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 544)
        Me.Controls.Add(Me.chkAutoCheck)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtchkCheckBox1_CheckState)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtchkCheckBox1_Checked)
        Me.Controls.Add(Me.chkCheckBox1)
        Me.Name = "frmForm3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtchkCheckBox1_Checked As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtchkCheckBox1_CheckState As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents chkAutoCheck As System.Windows.Forms.CheckBox

End Class
