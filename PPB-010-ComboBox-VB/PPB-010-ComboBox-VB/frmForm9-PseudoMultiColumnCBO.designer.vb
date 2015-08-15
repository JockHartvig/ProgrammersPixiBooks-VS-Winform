<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForm9_PseudoMultiColumnCBO
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
        Me.cboComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtTextBox1 = New System.Windows.Forms.TextBox()
        Me.txtTextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cboComboBox1
        '
        Me.cboComboBox1.FormattingEnabled = True
        Me.cboComboBox1.Location = New System.Drawing.Point(119, 33)
        Me.cboComboBox1.Name = "cboComboBox1"
        Me.cboComboBox1.Size = New System.Drawing.Size(142, 21)
        Me.cboComboBox1.TabIndex = 0
        '
        'txtTextBox1
        '
        Me.txtTextBox1.Location = New System.Drawing.Point(122, 81)
        Me.txtTextBox1.Name = "txtTextBox1"
        Me.txtTextBox1.Size = New System.Drawing.Size(124, 20)
        Me.txtTextBox1.TabIndex = 1
        '
        'txtTextBox2
        '
        Me.txtTextBox2.Location = New System.Drawing.Point(122, 107)
        Me.txtTextBox2.Name = "txtTextBox2"
        Me.txtTextBox2.Size = New System.Drawing.Size(124, 20)
        Me.txtTextBox2.TabIndex = 2
        '
        'frmForm2_MultiColumnCBO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 264)
        Me.Controls.Add(Me.txtTextBox2)
        Me.Controls.Add(Me.txtTextBox1)
        Me.Controls.Add(Me.cboComboBox1)
        Me.Name = "frmForm2_MultiColumnCBO"
        Me.Text = "frmForm2_MultiColumnCBO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTextBox2 As System.Windows.Forms.TextBox
End Class
