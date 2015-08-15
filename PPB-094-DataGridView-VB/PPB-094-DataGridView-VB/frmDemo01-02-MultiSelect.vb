Public Class frmDemo01_MultiSelect

    Private Sub frmDemo01_MultiSelect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim strArray(3) As String

        strArray(0) = "00"
        strArray(1) = "01"
        strArray(2) = "02"
        Me.dgvDataGridView1.Rows.Add(strArray)
        strArray(0) = "10"
        strArray(1) = "11"
        strArray(2) = "12"
        Me.dgvDataGridView1.Rows.Add(strArray)
        strArray(0) = "20"
        strArray(1) = "21"
        strArray(2) = "22"
        Me.dgvDataGridView1.Rows.Add(strArray)

    End Sub
    Private Sub chkMultiSelect_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMultiSelect.CheckedChanged
        If chkMultiSelect.Checked = False Then
            dgvDataGridView1.MultiSelect = False
        Else
            dgvDataGridView1.MultiSelect = True
        End If
        Me.dgvDataGridView1.ClearSelection()
        Call Set_dgvDataGridView_Values()

    End Sub

    Private Sub Set_dgvDataGridView_Values()
        'Me.txtCurrentRow_Index.Text = dgvDataGridView1.CurrentRow.Index
        'Me.txtCurrentCell_RowIndex.Text = dgvDataGridView1.CurrentCell.RowIndex
        'Me.txtCurrentCell_ColumnIndex.Text = dgvDataGridView1.CurrentCell.ColumnIndex

    End Sub

End Class