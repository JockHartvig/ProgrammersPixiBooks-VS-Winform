Public Class frmForm0

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.chkCheckBox2.CheckState = CheckState.Indeterminate

        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox2_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
        Call Set_CheckBox2_CheckState_Texts()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub chkCheckBox1_Click(sender As Object, e As System.EventArgs) Handles chkCheckBox1.Click
        Me.ListBox1.Items.Add("Event - Click")
        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
    End Sub

    Private Sub chkCheckBox2_Click(sender As Object, e As System.EventArgs) Handles chkCheckBox2.Click
        Me.ListBox2.Items.Add("Event - Click")
        Call Set_CheckBox2_Checked_Texts()
        Call Set_CheckBox2_CheckState_Texts()
    End Sub

    Private Sub chkCheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCheckBox1.CheckedChanged
        Me.ListBox1.Items.Add("Event - CheckedChanged")
    End Sub

    Private Sub chkCheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCheckBox2.CheckedChanged
        Me.ListBox2.Items.Add("Event - CheckedChanged")
    End Sub

    Private Sub Set_CheckBox1_Checked_Texts()
        If Me.chkCheckBox1.Checked Then
            Me.txtchkCheckBox1_Checked.Text = "Checked"
        Else
            Me.txtchkCheckBox1_Checked.Text = "Unchecked"
        End If
    End Sub

    Private Sub btnCheckBox1_SetCheckedUnchecked_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox1_SetCheckedUnchecked.Click
        Me.chkCheckBox1.Checked = False
    End Sub

    Private Sub btnCheckBox1_SetCheckedChecked_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox1_SetCheckedChecked.Click
        Me.chkCheckBox1.Checked = True
    End Sub

    Private Sub btnCheckBox1_SetCheckStateUnchecked_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox1_SetCheckStateUnchecked.Click
        Me.chkCheckBox1.CheckState = CheckState.Unchecked
    End Sub

    Private Sub btnCheckBox1_SetCheckStateChecked_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox1_SetCheckStateChecked.Click
        Me.chkCheckBox1.CheckState = CheckState.Checked
    End Sub

    Private Sub btnCheckBox1_SetCheckStateIndeterminate_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox1_SetCheckStateIndeterminate.Click
        Me.chkCheckBox1.CheckState = CheckState.Indeterminate
    End Sub

    Private Sub btnCheckBox2_SetCheckStateUnchecked_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox2_SetCheckStateUnchecked.Click
        Me.chkCheckBox2.CheckState = CheckState.Unchecked
    End Sub

    Private Sub btnCheckBox2_SetCheckStateChecked_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox2_SetCheckStateChecked.Click
        Me.chkCheckBox2.CheckState = CheckState.Checked
    End Sub

    Private Sub btnCheckBox2_SetCheckStateIndeterminate_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox2_SetCheckStateIndeterminate.Click
        Me.chkCheckBox2.CheckState = CheckState.Indeterminate
    End Sub

    Private Sub btnCheckBox2_SetCheckedUnchecked_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox2_SetCheckedUnchecked.Click
        Me.chkCheckBox2.Checked = False
    End Sub

    Private Sub btnCheckBox2_SetCheckedChecked_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox2_SetCheckedChecked.Click
        Me.chkCheckBox2.Checked = True
    End Sub

    Private Sub chkCheckBox1_CheckStateChanged(sender As Object, e As System.EventArgs) Handles chkCheckBox1.CheckStateChanged
        Me.ListBox1.Items.Add("Event - CheckStateChanged")
        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
    End Sub

    Private Sub chkCheckBox2_CheckStateChanged(sender As Object, e As System.EventArgs) Handles chkCheckBox2.CheckStateChanged
        Me.ListBox2.Items.Add("Event - CheckStateChanged")
        Call Set_CheckBox2_Checked_Texts()
        Call Set_CheckBox2_CheckState_Texts()
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

    Private Sub Set_CheckBox2_Checked_Texts()
        If Me.chkCheckBox2.Checked Then
            Me.txtchkCheckBox2_Checked.Text = "Checked"
        Else
            Me.txtchkCheckBox2_Checked.Text = "Unchecked"
        End If
    End Sub

    Private Sub Set_CheckBox2_CheckState_Texts()
        Select Case Me.chkCheckBox2.CheckState
            Case CheckState.Checked
                Me.txtchkCheckBox2_CheckState.Text = "Checked"
            Case CheckState.Unchecked
                Me.txtchkCheckBox2_CheckState.Text = "Unchecked"
            Case CheckState.Indeterminate
                Me.txtchkCheckBox2_CheckState.Text = "Indeterminate"
            Case Else
                Me.txtchkCheckBox2_CheckState.Text = "?????????"
        End Select
    End Sub

    Private Sub btnCheckBox1_ToggleVisible_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox1_ToggleVisible.Click
        If Me.chkCheckBox1.Visible Then
            Me.chkCheckBox1.Visible = False
        Else
            Me.chkCheckBox1.Visible = True
        End If
    End Sub

    Private Sub btnCheckBox1_ToggleEnabled_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox1_ToggleEnabled.Click
        If Me.chkCheckBox1.Enabled Then
            Me.chkCheckBox1.Enabled = False
        Else
            Me.chkCheckBox1.Enabled = True
        End If

    End Sub
End Class
