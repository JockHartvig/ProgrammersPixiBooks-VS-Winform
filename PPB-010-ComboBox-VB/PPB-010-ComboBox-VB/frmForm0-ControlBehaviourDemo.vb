Public Class frmForm0

    Dim bolFormLoad As Boolean = False

    Private Sub frmForm0_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        bolFormLoad = True
        ' Set deafult value of ComboBox
        Me.cboComboBox.SelectedIndex = 1

        Call Fill_cboDropDownStyle()
        Me.cboDropDownStyle.Text = Me.cboComboBox.DropDownStyle.ToString

        Call Fill_cboAutoCompleteMode()
        Me.cboAutoCompleteMode.Text = Me.cboComboBox.AutoCompleteMode.ToString

        bolFormLoad = False
    End Sub

    Private Sub cboComboBox_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cboComboBox.SelectedIndexChanged
        Me.txtSelectedIndex.Text = Me.cboComboBox.SelectedIndex
        If IsNothing(Me.cboComboBox.SelectedItem) Then
        Else
            Me.txtSelectedItem.Text = Me.cboComboBox.SelectedItem.ToString
        End If
        Me.txtSelectedValue.Text = Me.cboComboBox.SelectedValue
        Me.txtSelectedText.Text = Me.cboComboBox.SelectedText
        Me.TextBox1.Text = Me.cboComboBox.Text
    End Sub

    Private Sub cboComboBox_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboComboBox.SelectedValueChanged

        Me.txtSorted.Text = Me.cboComboBox.Sorted
        Me.txtSelectedIndex2.Text = Me.cboComboBox.SelectedIndex
        If IsNothing(Me.cboComboBox.SelectedItem) Then
        Else
            Me.txtSelectedItem2.Text = Me.cboComboBox.SelectedItem.ToString
        End If
        Me.txtSelectedValue2.Text = Me.cboComboBox.SelectedValue
        Me.txtSelectedText2.Text = Me.cboComboBox.SelectedText
        Me.TextBox2.Text = Me.cboComboBox.Text

    End Sub

    Private Sub cboComboBox_TextChanged(sender As Object, e As System.EventArgs) Handles cboComboBox.TextChanged
        Me.txtSelectedIndex3.Text = Me.cboComboBox.SelectedIndex
        If IsNothing(Me.cboComboBox.SelectedItem) Then
        Else
            Me.txtSelectedItem3.Text = Me.cboComboBox.SelectedItem.ToString
        End If
        Me.txtSelectedValue3.Text = Me.cboComboBox.SelectedValue
        Me.txtSelectedText3.Text = Me.cboComboBox.SelectedText
        Me.TextBox3.Text = Me.cboComboBox.Text
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Sub Fill_cboDropDownStyle()
        ' Define ArrayList to hold combo box list items
        Dim alComboBoxItems As New ArrayList()
        ' Fill  ArrayList with data.
        alComboBoxItems.Add(New clsDropDownStyleItem(ComboBoxStyle.Simple, "Simple"))
        alComboBoxItems.Add(New clsDropDownStyleItem(ComboBoxStyle.DropDown, "DropDown"))
        alComboBoxItems.Add(New clsDropDownStyleItem(ComboBoxStyle.DropDownList, "DropDownList"))
        Me.cboDropDownStyle.DataSource = alComboBoxItems
        Me.cboDropDownStyle.DisplayMember = "DropDownStyleName"
        Me.cboDropDownStyle.ValueMember = "DropDownStyleValue"
        Me.cboDropDownStyle.DataSource = alComboBoxItems
    End Sub

    Private Sub cboDropDownStyle_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboDropDownStyle.SelectedValueChanged
        Dim Style As clsDropDownStyleItem
        If Not bolFormLoad Then
            Style = Me.cboDropDownStyle.SelectedItem
            Me.cboComboBox.DropDownStyle = Style.DropDownStyleValue
        End If
    End Sub


    Sub Fill_cboAutoCompleteMode()
        ' Define ArrayList to hold combo box list items
        Dim alComboBoxItems As New ArrayList()
        ' Fill  ArrayList with data.
        alComboBoxItems.Add(New clsAutoCompleteModeItem(AutoCompleteMode.Append, "Append"))
        alComboBoxItems.Add(New clsAutoCompleteModeItem(AutoCompleteMode.None, "None"))
        alComboBoxItems.Add(New clsAutoCompleteModeItem(AutoCompleteMode.Suggest, "Suggest"))
        alComboBoxItems.Add(New clsAutoCompleteModeItem(AutoCompleteMode.SuggestAppend, "SuggestAppend"))
        Me.cboAutoCompleteMode.DataSource = alComboBoxItems
        Me.cboAutoCompleteMode.DisplayMember = "AutoCompleteModeName"
        Me.cboAutoCompleteMode.ValueMember = "AutoCompleteModeValue"
        Me.cboAutoCompleteMode.DataSource = alComboBoxItems
    End Sub

    Private Sub cboAutoCompleteMode_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboAutoCompleteMode.SelectedValueChanged
        Dim Style As clsAutoCompleteModeItem
        If Not bolFormLoad Then
            Style = Me.cboAutoCompleteMode.SelectedItem
            Me.cboComboBox.AutoCompleteMode = Style.AutoCompleteModeValue
        End If

    End Sub
End Class

Class clsAutoCompleteModeItem
    Private L_AutoCompleteModeValue As Integer = 0
    Private L_AutoCompleteModeName As String = ""

    Public ReadOnly Property AutoCompleteModeValue As Integer
        Get
            Return L_AutoCompleteModeValue
        End Get
    End Property

    Public ReadOnly Property AutoCompleteModeName As String
        Get
            Return L_AutoCompleteModeName
        End Get
    End Property

    Sub New(pAutoCompleteModeValue As Integer, pAutoCompleteModeName As String)
        L_AutoCompleteModeValue = pAutoCompleteModeValue
        L_AutoCompleteModeName = pAutoCompleteModeName
    End Sub

    Sub New()
    End Sub

End Class

Class clsDropDownStyleItem
    Private L_DropDownStyleValue As Integer = 0
    Private L_DropDownStyleName As String = ""

    Public ReadOnly Property DropDownStyleValue As Integer
        Get
            Return L_DropDownStyleValue
        End Get
    End Property

    Public ReadOnly Property DropDownStyleName As String
        Get
            Return L_DropDownStyleName
        End Get
    End Property

    Sub New(pDropDownStyleValue As Integer, pDropDownStyleName As String)
        L_DropDownStyleValue = pDropDownStyleValue
        L_DropDownStyleName = pDropDownStyleName
    End Sub

    Sub New()
    End Sub

End Class
