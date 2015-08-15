Public Class frmForm9_PseudoMultiColumnCBO

    Private listComboBoxItems As List(Of ComboBoxItem)

    Public Sub New()
        InitializeComponent()
        listComboBoxItems = New List(Of ComboBoxItem)()
        FillComboBox()
    End Sub

    Private Sub cboComboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cboComboBox1.SelectedIndexChanged
        Dim line As String = Me.cboComboBox1.SelectedItem.ToString()
        ' Char "-" is used as column separator
        Dim split As String() = line.Split("-")
        ' Key
        Me.txtTextBox1.Text = split(0).Trim()
        ' Name
        Me.txtTextBox2.Text = split(1).Trim()
    End Sub

    Private Sub FillComboBox()
        Dim cboItem1 As New ComboBoxItem(1, "ComboBox Item 1")
        Dim cboItem2 As New ComboBoxItem(2, "ComboBox Item 2")
        Dim cboItem3 As New ComboBoxItem(3, "ComboBox Item 3")

        ' Char "-" is used as column separator
        Me.cboComboBox1.Items.Add(cboItem1.Key & " - " & cboItem1.Name)
        Me.cboComboBox1.Items.Add(cboItem2.Key & " - " & cboItem2.Name)
        Me.cboComboBox1.Items.Add(cboItem3.Key & " - " & cboItem3.Name)
    End Sub

End Class

Class ComboBoxItem

    Public Sub New(pKey As Integer, pName As String)
        Key = pKey
        Name = pName
    End Sub

    Public Property Key() As Integer = 0
    Public Property Name() As String = ""

End Class