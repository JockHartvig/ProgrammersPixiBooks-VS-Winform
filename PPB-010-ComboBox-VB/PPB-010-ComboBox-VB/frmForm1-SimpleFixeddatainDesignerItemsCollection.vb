Public Class frmForm1

    Private Sub frmForm1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ' Set deafult value of ComboBox
        Me.cboComboBox.SelectedIndex = 0
        Me.cboComboBox.SelectedText = "xx "
    End Sub

    Private Sub cboComboBox_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cboComboBox.SelectedIndexChanged
        Me.txtSelectedIndex.Text = Me.cboComboBox.SelectedIndex
        Me.txtSelectedItem.Text = Me.cboComboBox.SelectedItem
        Me.txtSelectedValue.Text = Me.cboComboBox.SelectedValue
        Me.txtSelectedText.Text = Me.cboComboBox.SelectedText
        Me.TextBox1.Text = Me.cboComboBox.Text
    End Sub

    Private Sub cboComboBox_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboComboBox.SelectedValueChanged

        Me.txtSorted.Text = Me.cboComboBox.Sorted
        Me.txtSelectedIndex2.Text = Me.cboComboBox.SelectedIndex
        Me.txtSelectedItem2.Text = Me.cboComboBox.SelectedItem
        Me.txtSelectedValue2.Text = Me.cboComboBox.SelectedValue
        Me.txtSelectedText2.Text = Me.cboComboBox.SelectedText
        Me.TextBox2.Text = Me.cboComboBox.Text

    End Sub

    Private Sub cboComboBox_TextChanged(sender As Object, e As System.EventArgs) Handles cboComboBox.TextChanged
        Me.txtSelectedIndex3.Text = Me.cboComboBox.SelectedIndex
        Me.txtSelectedItem3.Text = Me.cboComboBox.SelectedItem
        Me.txtSelectedValue3.Text = Me.cboComboBox.SelectedValue
        Me.txtSelectedText3.Text = Me.cboComboBox.SelectedText
        Me.TextBox3.Text = Me.cboComboBox.Text
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
