Public Class frmForm2

    Private Sub frmForm2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ' Form has three ComboBoxes with
        '   1 - cboComboBox1 - DropDownStyle=Simple.
        '   2 - cboComboBox2 - DropDownStyle=Simple.
        '   3 - cboComboBox3 - DropDownStyle=Simple.

        ' Fill cboComboBox1
        Dim ItemArray1 As String() = New String() {"Item 1.1", "Item 1.2", "Item 1.3"}
        Me.cboComboBox1.DataSource = ItemArray1
        ' By default the first item is selected as default Text
        ' Here item 2 is set.
        Me.cboComboBox1.Text = ItemArray1(1)

        ' Fill cboComboBox2
        ' Create an Array (0)->(2) of Strings
        Dim ItemArray2(2) As String
        ItemArray2(0) = "Item 2.1"
        ItemArray2(1) = "Item 2.2"
        ItemArray2(2) = "Item 2.3"
        Me.cboComboBox2.DataSource = ItemArray2
        ' By default the first item is selected as default Text
        ' Here item 2 is set.
        Me.cboComboBox2.Text = ItemArray2(1)

        ' Fill cboComboBox3
        ' Create an Array (0)->(2) of Strings
        Dim ItemArray3(2) As String
        ItemArray3(0) = "Item 3.1"
        ItemArray3(1) = "Item 3.2"
        ItemArray3(2) = "Item 3.3"
        Me.cboComboBox3.DataSource = ItemArray3
        ' By default the first item is selected as default Text
        ' Here item 2 is set.
        Me.cboComboBox3.Text = ItemArray3(1)

    End Sub

    Private Sub cboComboBox1_TextChanged(sender As Object, e As System.EventArgs) Handles cboComboBox1.TextChanged
        Me.txtText1.Text = Me.cboComboBox1.Text
        Me.txtSelectedText1.Text = Me.cboComboBox1.SelectedText
        Me.txtSelectedValue1.Text = Me.cboComboBox1.SelectedValue
        If IsNothing(Me.cboComboBox1.SelectedItem) Then
            Me.txtSelectedItem1.Text = "Nothing"
        Else
            Me.txtSelectedItem1.Text = Me.cboComboBox1.SelectedItem.ToString
        End If
        Me.txtSelectedIndex1.Text = Me.cboComboBox1.SelectedIndex
    End Sub

    Private Sub cboComboBox2_TextChanged(sender As Object, e As System.EventArgs) Handles cboComboBox2.TextChanged
        Me.txtText2.Text = Me.cboComboBox2.Text
        Me.txtSelectedText2.Text = Me.cboComboBox2.SelectedText
        Me.txtSelectedValue2.Text = Me.cboComboBox2.SelectedValue
        If IsNothing(Me.cboComboBox2.SelectedItem) Then
            Me.txtSelectedItem2.Text = "Nothing"
        Else
            Me.txtSelectedItem2.Text = Me.cboComboBox2.SelectedItem.ToString
        End If
        Me.txtSelectedIndex2.Text = Me.cboComboBox2.SelectedIndex
    End Sub

    Private Sub cboComboBox3_TextChanged(sender As Object, e As System.EventArgs) Handles cboComboBox3.TextChanged
        Me.txtText3.Text = Me.cboComboBox3.Text
        Me.txtSelectedText3.Text = Me.cboComboBox3.SelectedText
        Me.txtSelectedValue3.Text = Me.cboComboBox3.SelectedValue
        If IsNothing(Me.cboComboBox3.SelectedItem) Then
            Me.txtSelectedItem3.Text = "Nothing"
        Else
            Me.txtSelectedItem3.Text = Me.cboComboBox3.SelectedItem.ToString
        End If
        Me.txtSelectedIndex3.Text = Me.cboComboBox3.SelectedIndex
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class