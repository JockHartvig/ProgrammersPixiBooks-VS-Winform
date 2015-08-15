Public Class frmForm01A

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.chkPropVisible.Checked = Me.chkCheckBox1.Visible
        Me.chkPropEnabled.Checked = Me.chkCheckBox1.Enabled
        Me.chkPropVisible.Checked = Me.chkCheckBox1.Visible

        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
        Call Set_CheckBox1_CheckState_ComboList()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    '-------------------------------------------------
    ' CheckBox1 Event Procedures
    '-------------------------------------------------

    Private Sub chkCheckBox1_Click(sender As Object, e As System.EventArgs) Handles chkCheckBox1.Click
        Listbox1_Add("Event - Click")
        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
    End Sub

    Private Sub chkCheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCheckBox1.CheckedChanged
        Listbox1_Add("Event - CheckedChanged")
    End Sub

    Private Sub chkCheckBox1_CheckStateChanged(sender As Object, e As System.EventArgs) Handles chkCheckBox1.CheckStateChanged
        Listbox1_Add("Event - CheckStateChanged")
        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
    End Sub

    '-------------------------------------------------
    ' CheckBox1 Property Event Procedures
    '-------------------------------------------------

    Private Sub chkPropThreeState_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPropThreeState.CheckedChanged
        If Me.chkPropThreeState.Checked Then
            Listbox1_Add("Property ThreeState - Checked")
            Me.chkCheckBox1.ThreeState = True
        Else
            Listbox1_Add("Property ThreeState - UnChecked")
            Me.chkCheckBox1.ThreeState = False
        End If
        Call Set_CheckBox1_CheckState_ComboList()
    End Sub

    Private Sub chkPropVisible_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPropVisible.CheckedChanged
        If Me.chkPropVisible.Checked Then
            Listbox1_Add("Property Visible - Checked")
            Me.chkCheckBox1.Visible = True
        Else
            Listbox1_Add("Property Visible - UnChecked")
            Me.chkCheckBox1.Visible = False
        End If
    End Sub

    Private Sub chkPropEnabled_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPropEnabled.CheckedChanged
        If Me.chkPropEnabled.Checked Then
            Listbox1_Add("Property Enabled - Checked")
            Me.chkCheckBox1.Enabled = True
        Else
            Listbox1_Add("Property Enabled - UnChecked")
            Me.chkCheckBox1.Enabled = False
        End If
    End Sub

    Private Sub chkPropChecked_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPropChecked.CheckedChanged
        If chkPropChecked.Checked Then
            Me.chkCheckBox1.Checked = True
        Else
            Me.chkCheckBox1.Checked = False
        End If
        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
    End Sub

    Private Sub cboPropCheckState_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPropCheckState.SelectedIndexChanged
        Select Case cboPropCheckState.Text
            Case "Checked"
                Me.chkCheckBox1.CheckState = CheckState.Checked
            Case "Unchecked"
                Me.chkCheckBox1.CheckState = CheckState.Unchecked
            Case "Indeterminate"
                Me.chkCheckBox1.CheckState = CheckState.Indeterminate
        End Select
        '       Me.chkCheckBox1.Refresh()
        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
    End Sub
    '-------------------------------------------------
    ' Private Form Procedures
    '-------------------------------------------------

    Private Sub Set_CheckBox1_Checked_Texts()
        If Me.chkCheckBox1.Checked Then
            Me.txtchkCheckBox1_Checked.Text = "Checked"
        Else
            Me.txtchkCheckBox1_Checked.Text = "Unchecked"
        End If
    End Sub

    Private Sub Set_CheckBox1_CheckState_ComboList()
        Dim ItemArray3 As String() = New String() {"Checked", "Unchecked", "Indeterminate"}
        Dim ItemArray2 As String() = New String() {"Checked", "Unchecked"}
        If Me.chkCheckBox1.ThreeState Then
            cboPropCheckState.DataSource = ItemArray3
        Else
            cboPropCheckState.DataSource = ItemArray2
        End If

        Select Case Me.chkCheckBox1.CheckState
            Case CheckState.Checked
                Me.cboPropCheckState.Text = "Checked"
            Case CheckState.Unchecked
                Me.cboPropCheckState.Text = "Unchecked"
            Case CheckState.Indeterminate
                Me.cboPropCheckState.Text = "Indeterminate"
            Case Else
                Me.cboPropCheckState.Text = "?????????"
        End Select
    End Sub

    Private Sub Set_CheckBox1_CheckState_Texts()
        Select Case Me.chkCheckBox1.CheckState
            Case CheckState.Checked
                Me.txtchkCheckBox1_CheckState.Text = "Checked"
            Case CheckState.Unchecked
                Me.txtchkCheckBox1_CheckState.Text = "Unchecked"
            Case CheckState.Indeterminate
                Me.txtchkCheckBox1_CheckState.Text = "Indeterminate"
            Case Else
                Me.txtchkCheckBox1_CheckState.Text = "?????????"
        End Select
    End Sub

    Private Sub Listbox1_Add(pText As String)
        Me.ListBox1.Items.Add(pText)
        Me.ListBox1.SetSelected(Me.ListBox1.Items.Count - 1, True)
    End Sub

End Class
