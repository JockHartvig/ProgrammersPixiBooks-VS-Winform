Imports System.Collections

Public Class frmForm4

    Private Sub frmForm4_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        ' Define ArrayList to hold combo box list items
        Dim alComboBoxItems As New ArrayList()
        ' Fill  ArrayList with data.
        alComboBoxItems.Add(New clsComboBoxItem(1, "Item 1"))
        alComboBoxItems.Add(New clsComboBoxItem(2, "Item 2"))
        alComboBoxItems.Add(New clsComboBoxItem(3, "Item 31"))
        Me.cboComboBox.DataSource = alComboBoxItems
        Me.cboComboBox.DisplayMember = "ItemName"
        Me.cboComboBox.ValueMember = "ItemNo"
        Me.cboComboBox.DataSource = alComboBoxItems

    End Sub

    'Private Sub cboComboBox_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cboComboBox.SelectedIndexChanged
    '    Me.txtSelectedIndex.Text = Me.cboComboBox.SelectedIndex
    '    Me.txtSelectedItem.Text = Me.cboComboBox.SelectedItem
    '    Me.txtSelectedValue.Text = Me.cboComboBox.SelectedValue
    '    Me.txtSelectedText.Text = Me.cboComboBox.SelectedText
    '    Me.TextBox1.Text = Me.cboComboBox.Text
    'End Sub

    Private Sub cboComboBox_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboComboBox.SelectedValueChanged

        'Me.txtSorted.Text = Me.cboComboBox.Sorted
        Me.txtSelectedIndex2.Text = Me.cboComboBox.SelectedIndex
        ' Me.txtSelectedItem2.Text = Me.cboComboBox.SelectedItem
        Me.txtSelectedValue2.Text = Me.cboComboBox.SelectedValue.ToString
        Me.txtSelectedText2.Text = Me.cboComboBox.SelectedText.ToString()
        Me.TextBox2.Text = Me.cboComboBox.Text

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Sub fill()

        ' Define in-memory DataTable to hold combo box list items
        Dim dtaComboBox As New DataTable
        'Create columns in in-memory DataTable.
        With dtaComboBox.Columns
            .Add("ItemNo", GetType(Integer))
            .Add("ItemName", GetType(String))
        End With
        ' Fill  in-memory DataTable with data.
        dtaComboBox.Rows.Add(1, "Item 1")
        dtaComboBox.Rows.Add(2, "Item 2")
        dtaComboBox.Rows.Add(3, "Item 3")
        ' Relate Udvalgsroller ComboBox Data Table to DataGridView column "UdvalgsMedlemRolle".
        Me.cboComboBox.DisplayMember = "ItemName" ' Cells in this column are the string items in ComboBox  List
        Me.cboComboBox.ValueMember = "ItemNo"
        Me.cboComboBox.DataSource = dtaComboBox

    End Sub
End Class

Class clsComboBoxItem
    Private L_ItemNo As Integer
    Private L_ItemName As String

    Public ReadOnly Property ItemNo As Integer
        Get
            Return L_ItemNo
        End Get
    End Property

    Public ReadOnly Property ItemName As String
        Get
            Return L_ItemName
        End Get
    End Property

    Sub New(pNo As Integer, pName As String)
        L_ItemNo = pNo
        L_ItemName = pName
    End Sub
End Class

