Imports System.Windows.Forms

Public Class frmForm3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Fill cboComboBox1
        With cboComboBox1
            .Items.Add("Item 1.1")
            .Items.AddRange({"Item 1.2", "Item 1.3"})
        End With

        ' Fill cboComboBox2
        ' Create an Array (0)->(2) of Strings
        Dim ItemArray2(2) As String
        ItemArray2(0) = "Item 2.1"
        ItemArray2(1) = "Item 2.2"
        ItemArray2(2) = "Item 2.3"

        ' Fill cboComboBox2
        Me.cboComboBox2.Items.Clear()
        For Each strValue As String In ItemArray2
            Me.cboComboBox2.Items.Add(strValue)
        Next
        ' When using Items.Add, no default text is set.
        Me.cboComboBox2.Text = ItemArray2(1)

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class

