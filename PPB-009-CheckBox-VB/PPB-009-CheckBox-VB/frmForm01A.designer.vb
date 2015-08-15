<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForm01A
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
        Me.txtchkCheckBox1_CheckState = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPropCheckState = New System.Windows.Forms.ComboBox()
        Me.chkPropChecked = New System.Windows.Forms.CheckBox()
        Me.chkPropEnabled = New System.Windows.Forms.CheckBox()
        Me.chkPropVisible = New System.Windows.Forms.CheckBox()
        Me.chkPropThreeState = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkCheckBox1
        '
        Me.chkCheckBox1.AutoSize = True
        Me.chkCheckBox1.Checked = True
        Me.chkCheckBox1.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkCheckBox1.Enabled = False
        Me.chkCheckBox1.Location = New System.Drawing.Point(30, 24)
        Me.chkCheckBox1.Name = "chkCheckBox1"
        Me.chkCheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.chkCheckBox1.TabIndex = 0
        Me.chkCheckBox1.Text = "CheckBox1"
        Me.chkCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCheckBox1.UseVisualStyleBackColor = True
        '
        'txtchkCheckBox1_Checked
        '
        Me.txtchkCheckBox1_Checked.Enabled = False
        Me.txtchkCheckBox1_Checked.Location = New System.Drawing.Point(166, 63)
        Me.txtchkCheckBox1_Checked.Name = "txtchkCheckBox1_Checked"
        Me.txtchkCheckBox1_Checked.Size = New System.Drawing.Size(100, 20)
        Me.txtchkCheckBox1_Checked.TabIndex = 2
        '
        'txtchkCheckBox1_CheckState
        '
        Me.txtchkCheckBox1_CheckState.Enabled = False
        Me.txtchkCheckBox1_CheckState.Location = New System.Drawing.Point(166, 88)
        Me.txtchkCheckBox1_CheckState.Name = "txtchkCheckBox1_CheckState"
        Me.txtchkCheckBox1_CheckState.Size = New System.Drawing.Size(100, 20)
        Me.txtchkCheckBox1_CheckState.TabIndex = 5
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(15, 42)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(196, 264)
        Me.ListBox1.TabIndex = 20
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboPropCheckState)
        Me.GroupBox1.Controls.Add(Me.chkPropChecked)
        Me.GroupBox1.Controls.Add(Me.chkPropEnabled)
        Me.GroupBox1.Controls.Add(Me.chkPropVisible)
        Me.GroupBox1.Controls.Add(Me.chkPropThreeState)
        Me.GroupBox1.Controls.Add(Me.txtchkCheckBox1_Checked)
        Me.GroupBox1.Controls.Add(Me.txtchkCheckBox1_CheckState)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 220)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Properties"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CheckState"
        '
        'cboPropCheckState
        '
        Me.cboPropCheckState.FormattingEnabled = True
        Me.cboPropCheckState.Items.AddRange(New Object() {"Checked", "Unchecked", "Indeterminate"})
        Me.cboPropCheckState.Location = New System.Drawing.Point(6, 88)
        Me.cboPropCheckState.Name = "cboPropCheckState"
        Me.cboPropCheckState.Size = New System.Drawing.Size(79, 21)
        Me.cboPropCheckState.TabIndex = 6
        '
        'chkPropChecked
        '
        Me.chkPropChecked.AutoSize = True
        Me.chkPropChecked.Location = New System.Drawing.Point(6, 65)
        Me.chkPropChecked.Name = "chkPropChecked"
        Me.chkPropChecked.Size = New System.Drawing.Size(69, 17)
        Me.chkPropChecked.TabIndex = 3
        Me.chkPropChecked.Text = "Checked"
        Me.chkPropChecked.UseVisualStyleBackColor = True
        '
        'chkPropEnabled
        '
        Me.chkPropEnabled.AutoSize = True
        Me.chkPropEnabled.Location = New System.Drawing.Point(6, 42)
        Me.chkPropEnabled.Name = "chkPropEnabled"
        Me.chkPropEnabled.Size = New System.Drawing.Size(65, 17)
        Me.chkPropEnabled.TabIndex = 2
        Me.chkPropEnabled.Text = "Enabled"
        Me.chkPropEnabled.UseVisualStyleBackColor = True
        '
        'chkPropVisible
        '
        Me.chkPropVisible.AutoSize = True
        Me.chkPropVisible.Location = New System.Drawing.Point(6, 21)
        Me.chkPropVisible.Name = "chkPropVisible"
        Me.chkPropVisible.Size = New System.Drawing.Size(56, 17)
        Me.chkPropVisible.TabIndex = 1
        Me.chkPropVisible.Text = "Visible"
        Me.chkPropVisible.UseVisualStyleBackColor = True
        '
        'chkPropThreeState
        '
        Me.chkPropThreeState.AutoSize = True
        Me.chkPropThreeState.Location = New System.Drawing.Point(6, 143)
        Me.chkPropThreeState.Name = "chkPropThreeState"
        Me.chkPropThreeState.Size = New System.Drawing.Size(79, 17)
        Me.chkPropThreeState.TabIndex = 0
        Me.chkPropThreeState.Text = "ThreeState"
        Me.chkPropThreeState.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(322, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 325)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CheckBox1 events"
        '
        'frmForm01A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 544)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.chkCheckBox1)
        Me.Name = "frmForm01A"
        Me.Text = "Form2 -Programmatically Update of CheckBox - Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtchkCheckBox1_Checked As System.Windows.Forms.TextBox
    Friend WithEvents txtchkCheckBox1_CheckState As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPropThreeState As System.Windows.Forms.CheckBox
    Friend WithEvents chkPropVisible As System.Windows.Forms.CheckBox
    Friend WithEvents chkPropEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents chkPropChecked As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPropCheckState As System.Windows.Forms.ComboBox

End Class
