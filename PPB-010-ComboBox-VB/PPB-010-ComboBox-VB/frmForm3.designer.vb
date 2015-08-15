<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForm3
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cboComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(268, 332)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 30)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cboComboBox1
        '
        Me.cboComboBox1.FormattingEnabled = True
        Me.cboComboBox1.Location = New System.Drawing.Point(34, 49)
        Me.cboComboBox1.Name = "cboComboBox1"
        Me.cboComboBox1.Size = New System.Drawing.Size(172, 21)
        Me.cboComboBox1.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "DropDownStyle - DropDown"
        '
        'cboComboBox2
        '
        Me.cboComboBox2.FormattingEnabled = True
        Me.cboComboBox2.Location = New System.Drawing.Point(34, 76)
        Me.cboComboBox2.Name = "cboComboBox2"
        Me.cboComboBox2.Size = New System.Drawing.Size(172, 21)
        Me.cboComboBox2.TabIndex = 5
        '
        'frmForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 384)
        Me.Controls.Add(Me.cboComboBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboComboBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmForm3"
        Me.Text = "Form 3 - Items.Add(...)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cboComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboComboBox2 As System.Windows.Forms.ComboBox
End Class
