<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemo01_01
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
        Me.dgvDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkMultiSelect = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurrentRow_Index = New System.Windows.Forms.TextBox()
        Me.lblCurrentRow = New System.Windows.Forms.Label()
        Me.lblCurrentCell = New System.Windows.Forms.Label()
        Me.txtCurrentCell_RowIndex = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRowIndex = New System.Windows.Forms.Label()
        Me.txtCurrentCell_ColumnIndex = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 487)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dgvDataGridView1
        '
        Me.dgvDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvDataGridView1.Location = New System.Drawing.Point(12, 97)
        Me.dgvDataGridView1.Name = "dgvDataGridView1"
        Me.dgvDataGridView1.Size = New System.Drawing.Size(344, 219)
        Me.dgvDataGridView1.TabIndex = 1
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
        'chkMultiSelect
        '
        Me.chkMultiSelect.AutoSize = True
        Me.chkMultiSelect.Location = New System.Drawing.Point(13, 50)
        Me.chkMultiSelect.Name = "chkMultiSelect"
        Me.chkMultiSelect.Size = New System.Drawing.Size(170, 17)
        Me.chkMultiSelect.TabIndex = 2
        Me.chkMultiSelect.Text = "dgvDataGridView1.MultiSelect"
        Me.chkMultiSelect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "dgvDataGridView1"
        '
        'txtCurrentRow_Index
        '
        Me.txtCurrentRow_Index.Location = New System.Drawing.Point(532, 98)
        Me.txtCurrentRow_Index.Name = "txtCurrentRow_Index"
        Me.txtCurrentRow_Index.Size = New System.Drawing.Size(51, 20)
        Me.txtCurrentRow_Index.TabIndex = 4
        '
        'lblCurrentRow
        '
        Me.lblCurrentRow.AutoSize = True
        Me.lblCurrentRow.Location = New System.Drawing.Point(374, 101)
        Me.lblCurrentRow.Name = "lblCurrentRow"
        Me.lblCurrentRow.Size = New System.Drawing.Size(63, 13)
        Me.lblCurrentRow.TabIndex = 5
        Me.lblCurrentRow.Text = "CurrentRow"
        '
        'lblCurrentCell
        '
        Me.lblCurrentCell.AutoSize = True
        Me.lblCurrentCell.Location = New System.Drawing.Point(374, 127)
        Me.lblCurrentCell.Name = "lblCurrentCell"
        Me.lblCurrentCell.Size = New System.Drawing.Size(58, 13)
        Me.lblCurrentCell.TabIndex = 7
        Me.lblCurrentCell.Text = "CurrentCell"
        '
        'txtCurrentCell_RowIndex
        '
        Me.txtCurrentCell_RowIndex.Location = New System.Drawing.Point(593, 120)
        Me.txtCurrentCell_RowIndex.Name = "txtCurrentCell_RowIndex"
        Me.txtCurrentCell_RowIndex.Size = New System.Drawing.Size(52, 20)
        Me.txtCurrentCell_RowIndex.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(529, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Index"
        '
        'lblRowIndex
        '
        Me.lblRowIndex.AutoSize = True
        Me.lblRowIndex.Location = New System.Drawing.Point(590, 78)
        Me.lblRowIndex.Name = "lblRowIndex"
        Me.lblRowIndex.Size = New System.Drawing.Size(55, 13)
        Me.lblRowIndex.TabIndex = 9
        Me.lblRowIndex.Text = "RowIndex"
        '
        'txtCurrentCell_ColumnIndex
        '
        Me.txtCurrentCell_ColumnIndex.Location = New System.Drawing.Point(651, 120)
        Me.txtCurrentCell_ColumnIndex.Name = "txtCurrentCell_ColumnIndex"
        Me.txtCurrentCell_ColumnIndex.Size = New System.Drawing.Size(68, 20)
        Me.txtCurrentCell_ColumnIndex.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(651, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ColumnIndex"
        '
        'frmDemo01_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 522)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCurrentCell_ColumnIndex)
        Me.Controls.Add(Me.lblRowIndex)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCurrentCell)
        Me.Controls.Add(Me.txtCurrentCell_RowIndex)
        Me.Controls.Add(Me.lblCurrentRow)
        Me.Controls.Add(Me.txtCurrentRow_Index)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkMultiSelect)
        Me.Controls.Add(Me.dgvDataGridView1)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmDemo01_01"
        Me.Text = "frmDemo01_01"
        CType(Me.dgvDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dgvDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents chkMultiSelect As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCurrentRow_Index As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrentRow As System.Windows.Forms.Label
    Friend WithEvents lblCurrentCell As System.Windows.Forms.Label
    Friend WithEvents txtCurrentCell_RowIndex As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblRowIndex As System.Windows.Forms.Label
    Friend WithEvents txtCurrentCell_ColumnIndex As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
