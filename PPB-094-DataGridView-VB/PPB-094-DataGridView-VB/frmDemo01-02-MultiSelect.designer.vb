<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemo01_MultiSelect
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
        Me.dgvDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.chkMultiSelect = New System.Windows.Forms.CheckBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDataGridView1
        '
        Me.dgvDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvDataGridView1.Location = New System.Drawing.Point(30, 79)
        Me.dgvDataGridView1.Name = "dgvDataGridView1"
        Me.dgvDataGridView1.Size = New System.Drawing.Size(345, 150)
        Me.dgvDataGridView1.TabIndex = 0
        '
        'chkMultiSelect
        '
        Me.chkMultiSelect.AutoSize = True
        Me.chkMultiSelect.Location = New System.Drawing.Point(30, 43)
        Me.chkMultiSelect.Name = "chkMultiSelect"
        Me.chkMultiSelect.Size = New System.Drawing.Size(78, 17)
        Me.chkMultiSelect.TabIndex = 2
        Me.chkMultiSelect.Text = "MultiSelect"
        Me.chkMultiSelect.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'frmDemo01_MultiSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 345)
        Me.Controls.Add(Me.chkMultiSelect)
        Me.Controls.Add(Me.dgvDataGridView1)
        Me.Name = "frmDemo01_MultiSelect"
        Me.Text = "frmDemo01_MultiSelect"
        CType(Me.dgvDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents chkMultiSelect As System.Windows.Forms.CheckBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
