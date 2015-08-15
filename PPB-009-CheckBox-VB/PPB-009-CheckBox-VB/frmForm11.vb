Public Class frmForm11

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox2_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
        Call Set_CheckBox2_CheckState_Texts()
    End Sub

    '-------------------------------------------------
    ' Usefull CheckBox Event Procedures
    '-------------------------------------------------

    Private Sub chkCheckBox1_Click(sender As Object, e As System.EventArgs) Handles chkCheckBox1.Click
        Listbox1_Add("Event - Click")
        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
    End Sub

    Private Sub chkCheckBox2_Click(sender As Object, e As System.EventArgs) Handles chkCheckBox2.Click
        Me.ListBox2.Items.Add("Event - Click")
        Call Set_CheckBox2_Checked_Texts()
        Call Set_CheckBox2_CheckState_Texts()
    End Sub

    Private Sub chkCheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCheckBox1.CheckedChanged
        Listbox1_Add("Event - CheckedChanged")
    End Sub

    Private Sub chkCheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCheckBox2.CheckedChanged
        Me.ListBox2.Items.Add("Event - CheckedChanged")
    End Sub

    Private Sub chkCheckBox1_CheckStateChanged(sender As Object, e As System.EventArgs) Handles chkCheckBox1.CheckStateChanged
        Listbox1_Add("Event - CheckStateChanged")
        Call Set_CheckBox1_Checked_Texts()
        Call Set_CheckBox1_CheckState_Texts()
    End Sub

    Private Sub chkCheckBox2_CheckStateChanged(sender As Object, e As System.EventArgs) Handles chkCheckBox2.CheckStateChanged
        Me.ListBox2.Items.Add("Event - CheckStateChanged")
        Call Set_CheckBox2_Checked_Texts()
        Call Set_CheckBox2_CheckState_Texts()
    End Sub

    '-------------------------------------------------
    ' Other Event Procedures
    '-------------------------------------------------

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCheckBox1_ToggleVisible_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox1_ToggleVisible.Click
        If Me.chkCheckBox1.Visible Then
            Me.chkCheckBox1.Visible = False
        Else
            Me.chkCheckBox1.Visible = True
        End If
    End Sub

    Private Sub btnCheckBox2_ToggleVisible_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox2_ToggleVisible.Click
        If Me.chkCheckBox2.Visible Then
            Me.chkCheckBox2.Visible = False
        Else
            Me.chkCheckBox2.Visible = True
        End If
    End Sub

    Private Sub btnCheckBox1_ToggleEnabled_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox1_ToggleEnabled.Click
        If Me.chkCheckBox1.Enabled Then
            Me.chkCheckBox1.Enabled = False
        Else
            Me.chkCheckBox1.Enabled = True
        End If
    End Sub

    Private Sub btnCheckBox2_ToggleEnabled_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckBox2_ToggleEnabled.Click
        If Me.chkCheckBox2.Enabled Then
            Me.chkCheckBox2.Enabled = False
        Else
            Me.chkCheckBox2.Enabled = True
        End If
    End Sub

    '-------------------------------------------------
    ' Private Procedures
    '-------------------------------------------------

    Private Sub Set_CheckBox1_Checked_Texts()
        If Me.chkCheckBox1.Checked Then
            Me.txtchkCheckBox1_Checked.Text = "Checked"
        Else
            Me.txtchkCheckBox1_Checked.Text = "Unchecked"
        End If
    End Sub

    Private Sub Set_CheckBox2_Checked_Texts()
        If Me.chkCheckBox2.Checked Then
            Me.txtchkCheckBox2_Checked.Text = "Checked"
        Else
            Me.txtchkCheckBox2_Checked.Text = "Unchecked"
        End If
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

    Private Sub Listbox1_Add(pText As String)
        Me.ListBox1.Items.Add(pText)
        Me.ListBox1.SetSelected(Me.ListBox1.Items.Count - 1, True)
    End Sub

    '-------------------------------------------------
    ' Demo Event Procedures
    '-------------------------------------------------

    Private Sub chkCheckBox1_Leave(sender As Object, e As System.EventArgs) Handles chkCheckBox1.Leave
        Listbox1_Add("Event - Leave")
    End Sub

    Private Sub chkCheckBox1_GotFocus(sender As Object, e As System.EventArgs) Handles chkCheckBox1.GotFocus
        Listbox1_Add("Event - GotFocus")
    End Sub

    Private Sub chkCheckBox1_LostFocus(sender As Object, e As System.EventArgs) Handles chkCheckBox1.LostFocus
        Listbox1_Add("Event - LostFocus")
    End Sub

    Private Sub chkCheckBox1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles chkCheckBox1.MouseClick
        Listbox1_Add("Event - MouseClick")
    End Sub

    Private Sub chkCheckBox1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles chkCheckBox1.MouseDown
        Listbox1_Add("Event - MouseDown")
    End Sub

    Private Sub chkCheckBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles chkCheckBox1.MouseEnter
        Listbox1_Add("Event - MouseEnter")
    End Sub

    Private Sub chkCheckBox1_MouseHover(sender As Object, e As System.EventArgs) Handles chkCheckBox1.MouseHover
        Listbox1_Add("Event - MouseHover")
    End Sub

    Private Sub chkCheckBox1_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles chkCheckBox1.MouseWheel
        Listbox1_Add("Event - MouseWheel")
    End Sub

    Private Sub chkCheckBox1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles chkCheckBox1.Paint
        Listbox1_Add("Event - Paint")
    End Sub

    Private Sub chkCheckBox1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles chkCheckBox1.MouseUp
        Listbox1_Add("Event - MouseUp")
    End Sub

    Private Sub chkCheckBox1_MouseLeave(sender As Object, e As System.EventArgs) Handles chkCheckBox1.MouseLeave
        Listbox1_Add("Event - MouseLeave")
    End Sub
End Class
