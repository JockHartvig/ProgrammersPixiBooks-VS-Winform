Public Class frmForm13

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Me.chkCheckBox1.AutoCheck = True Then
            Me.chkAutoCheck.Checked = True
        Else
            Me.chkAutoCheck.Checked = False
        End If
        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub chkCheckBox1_Click(sender As Object, e As System.EventArgs) Handles chkCheckBox1.Click
        Me.ListBox1.Items.Add("Event - Click")
        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
    End Sub

    Private Sub chkCheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCheckBox1.CheckedChanged
        Me.ListBox1.Items.Add("Event - CheckedChanged")
    End Sub

    Private Sub Set_CheckBox1_Checked_Texts()
        If Me.chkCheckBox1.Checked Then
            Me.txtchkCheckBox1_Checked.Text = "Checked"
        Else
            Me.txtchkCheckBox1_Checked.Text = "Unchecked"
        End If
    End Sub

    Private Sub chkCheckBox1_CheckStateChanged(sender As Object, e As System.EventArgs) Handles chkCheckBox1.CheckStateChanged
        Me.ListBox1.Items.Add("Event - CheckStateChanged")
        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
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

    Private Sub chkAutoCheck_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAutoCheck.CheckedChanged
        Select Case Me.chkAutoCheck.CheckState
            Case CheckState.Checked
                Me.chkCheckBox1.AutoCheck = True
            Case CheckState.Unchecked
                Me.chkCheckBox1.AutoCheck = False
            Case CheckState.Indeterminate
                Me.chkCheckBox1.AutoCheck = True
            Case Else
                Me.chkCheckBox1.AutoCheck = False
        End Select

    End Sub
End Class
