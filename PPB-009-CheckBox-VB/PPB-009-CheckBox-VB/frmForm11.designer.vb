<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForm11
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
        Me.chkCheckBox2 = New System.Windows.Forms.CheckBox()
        Me.txtchkCheckBox1_Checked = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtchkCheckBox1_CheckState = New System.Windows.Forms.TextBox()
        Me.txtchkCheckBox2_CheckState = New System.Windows.Forms.TextBox()
        Me.txtchkCheckBox2_Checked = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCheckBox1_ToggleEnabled = New System.Windows.Forms.Button()
        Me.btnCheckBox1_ToggleVisible = New System.Windows.Forms.Button()
        Me.btnCheckBox2_ToggleVisible = New System.Windows.Forms.Button()
        Me.btnCheckBox2_ToggleEnabled = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkCheckBox1
        '
        Me.chkCheckBox1.AutoSize = True
        Me.chkCheckBox1.Checked = True
        Me.chkCheckBox1.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkCheckBox1.Location = New System.Drawing.Point(149, 48)
        Me.chkCheckBox1.Name = "chkCheckBox1"
        Me.chkCheckBox1.Size = New System.Drawing.Size(137, 17)
        Me.chkCheckBox1.TabIndex = 0
        Me.chkCheckBox1.Text = "CheckBox1 - Two state"
        Me.chkCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCheckBox1.UseVisualStyleBackColor = True
        '
        'chkCheckBox2
        '
        Me.chkCheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkCheckBox2.AutoSize = True
        Me.chkCheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCheckBox2.Checked = True
        Me.chkCheckBox2.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkCheckBox2.Location = New System.Drawing.Point(353, 42)
        Me.chkCheckBox2.Name = "chkCheckBox2"
        Me.chkCheckBox2.Size = New System.Drawing.Size(132, 23)
        Me.chkCheckBox2.TabIndex = 1
        Me.chkCheckBox2.Text = "CheckBox2 -Three state"
        Me.chkCheckBox2.ThreeState = True
        Me.chkCheckBox2.UseVisualStyleBackColor = True
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
        'txtchkCheckBox2_CheckState
        '
        Me.txtchkCheckBox2_CheckState.Enabled = False
        Me.txtchkCheckBox2_CheckState.Location = New System.Drawing.Point(353, 97)
        Me.txtchkCheckBox2_CheckState.Name = "txtchkCheckBox2_CheckState"
        Me.txtchkCheckBox2_CheckState.Size = New System.Drawing.Size(100, 20)
        Me.txtchkCheckBox2_CheckState.TabIndex = 8
        '
        'txtchkCheckBox2_Checked
        '
        Me.txtchkCheckBox2_Checked.Enabled = False
        Me.txtchkCheckBox2_Checked.Location = New System.Drawing.Point(353, 71)
        Me.txtchkCheckBox2_Checked.Name = "txtchkCheckBox2_Checked"
        Me.txtchkCheckBox2_Checked.Size = New System.Drawing.Size(100, 20)
        Me.txtchkCheckBox2_Checked.TabIndex = 7
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(149, 203)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(163, 329)
        Me.ListBox1.TabIndex = 20
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(356, 203)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(162, 329)
        Me.ListBox2.TabIndex = 21
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(24, 502)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(104, 30)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCheckBox1_ToggleEnabled
        '
        Me.btnCheckBox1_ToggleEnabled.Location = New System.Drawing.Point(146, 124)
        Me.btnCheckBox1_ToggleEnabled.Name = "btnCheckBox1_ToggleEnabled"
        Me.btnCheckBox1_ToggleEnabled.Size = New System.Drawing.Size(166, 20)
        Me.btnCheckBox1_ToggleEnabled.TabIndex = 23
        Me.btnCheckBox1_ToggleEnabled.Text = "Toggle Enabled/Disabled"
        Me.btnCheckBox1_ToggleEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckBox1_ToggleEnabled.UseVisualStyleBackColor = True
        '
        'btnCheckBox1_ToggleVisible
        '
        Me.btnCheckBox1_ToggleVisible.Location = New System.Drawing.Point(146, 150)
        Me.btnCheckBox1_ToggleVisible.Name = "btnCheckBox1_ToggleVisible"
        Me.btnCheckBox1_ToggleVisible.Size = New System.Drawing.Size(166, 20)
        Me.btnCheckBox1_ToggleVisible.TabIndex = 24
        Me.btnCheckBox1_ToggleVisible.Text = "Toggle Visible/Invisble"
        Me.btnCheckBox1_ToggleVisible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckBox1_ToggleVisible.UseVisualStyleBackColor = True
        '
        'btnCheckBox2_ToggleVisible
        '
        Me.btnCheckBox2_ToggleVisible.Location = New System.Drawing.Point(352, 150)
        Me.btnCheckBox2_ToggleVisible.Name = "btnCheckBox2_ToggleVisible"
        Me.btnCheckBox2_ToggleVisible.Size = New System.Drawing.Size(166, 20)
        Me.btnCheckBox2_ToggleVisible.TabIndex = 26
        Me.btnCheckBox2_ToggleVisible.Text = "Toggle Visible/Invisble"
        Me.btnCheckBox2_ToggleVisible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckBox2_ToggleVisible.UseVisualStyleBackColor = True
        '
        'btnCheckBox2_ToggleEnabled
        '
        Me.btnCheckBox2_ToggleEnabled.Location = New System.Drawing.Point(352, 124)
        Me.btnCheckBox2_ToggleEnabled.Name = "btnCheckBox2_ToggleEnabled"
        Me.btnCheckBox2_ToggleEnabled.Size = New System.Drawing.Size(166, 20)
        Me.btnCheckBox2_ToggleEnabled.TabIndex = 25
        Me.btnCheckBox2_ToggleEnabled.Text = "Toggle Enabled/Disabled"
        Me.btnCheckBox2_ToggleEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckBox2_ToggleEnabled.UseVisualStyleBackColor = True
        '
        'frmForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 544)
        Me.Controls.Add(Me.btnCheckBox2_ToggleVisible)
        Me.Controls.Add(Me.btnCheckBox2_ToggleEnabled)
        Me.Controls.Add(Me.btnCheckBox1_ToggleVisible)
        Me.Controls.Add(Me.btnCheckBox1_ToggleEnabled)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtchkCheckBox2_CheckState)
        Me.Controls.Add(Me.txtchkCheckBox2_Checked)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtchkCheckBox1_CheckState)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtchkCheckBox1_Checked)
        Me.Controls.Add(Me.chkCheckBox2)
        Me.Controls.Add(Me.chkCheckBox1)
        Me.Name = "frmForm1"
        Me.Text = "Form1 -Update CheckBox via User Interface - Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtchkCheckBox1_Checked As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtchkCheckBox1_CheckState As System.Windows.Forms.TextBox
    Friend WithEvents txtchkCheckBox2_CheckState As System.Windows.Forms.TextBox
    Friend WithEvents txtchkCheckBox2_Checked As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCheckBox1_ToggleEnabled As System.Windows.Forms.Button
    Friend WithEvents btnCheckBox1_ToggleVisible As System.Windows.Forms.Button
    Friend WithEvents btnCheckBox2_ToggleVisible As System.Windows.Forms.Button
    Friend WithEvents btnCheckBox2_ToggleEnabled As System.Windows.Forms.Button

End Class
