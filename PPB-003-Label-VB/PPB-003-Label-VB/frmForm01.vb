Public Class frmForm01

    Private Sub frmForm01_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Call chkPropVisible_SetValue()
        Call chkPropEnabled_SetValue()
        Call cboPropBorderStyle_SetValue()
    End Sub

    Private Sub btnClearEventList_Click(sender As System.Object, e As System.EventArgs) Handles btnClearEventList.Click
        Me.lbEventsLabel1.Items.Clear()
    End Sub

    '-------------------------------------------------
    ' Label1 Event Procedures
    '-------------------------------------------------

    Private Sub Label1_Disposed(sender As Object, e As System.EventArgs) Handles Label1.Disposed
        Call ListboxEvents_Add("    Event Label1 Disposed")
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As System.EventArgs) Handles Label1.TextChanged
        Call ListboxEvents_Add("    Event Label1 TextChanged")
    End Sub

    Private Sub Label1_EnabledChanged(sender As Object, e As System.EventArgs) Handles Label1.EnabledChanged
        Call ListboxEvents_Add("    Event Label1 EnabledChanged")
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Call ListboxEvents_Add("-- Action Label1 Click")
        Call ListboxEvents_Add("    Event Label1 Click")
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As System.EventArgs) Handles Label1.DoubleClick
        Call ListboxEvents_Add("    Event Label1 DoubleClick")
    End Sub

    Private Sub Label1_GotFocus(sender As Object, e As System.EventArgs) Handles Label1.GotFocus
        Call ListboxEvents_Add("    Event Label1 GotFocus")
    End Sub

    Private Sub Label1_LostFocus(sender As Object, e As System.EventArgs) Handles Label1.LostFocus
        Call ListboxEvents_Add("    Event Label1 LostFocus")
    End Sub

    Private Sub Label1_Enter(sender As Object, e As System.EventArgs) Handles Label1.Enter
        Call ListboxEvents_Add("    Event Label1 Enter")
    End Sub

    Private Sub Label1_Leave(sender As Object, e As System.EventArgs) Handles Label1.Leave
        Call ListboxEvents_Add("    Event Label1 Leave")
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As System.EventArgs) Handles Label1.MouseEnter
        Call ListboxEvents_Add("    Event Label1 MouseEnter")
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As System.EventArgs) Handles Label1.MouseLeave
        Call ListboxEvents_Add("    Event Label1 MouseLeave")
    End Sub

    '-------------------------------------------------
    ' Label1 Property Comtrols Procedures
    '-------------------------------------------------

    Private Sub chkPropVisible_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPropVisible.CheckedChanged
        If Me.chkPropVisible.Checked Then
            Me.Label1.Visible = True
        Else
            Me.Label1.Visible = False
        End If
    End Sub

    Private Sub chkPropVisible_SetValue()
        If Me.Label1.Visible Then
            Me.chkPropVisible.Checked = True
        Else
            Me.chkPropVisible.Checked = False
        End If
    End Sub

    Private Sub chkPropEnabled_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPropEnabled.CheckedChanged
        If Me.chkPropEnabled.Checked Then
            Me.Label1.Enabled = True
        Else
            Me.Label1.Enabled = False
        End If
    End Sub

    Private Sub chkPropEnabled_SetValue()
        If Me.Label1.Enabled Then
            Me.chkPropEnabled.Checked = True
        Else
            Me.chkPropEnabled.Checked = False
        End If
    End Sub

    Private Sub cboPropBorderStyle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPropBorderStyle.SelectedIndexChanged
        Select Case cboPropBorderStyle.Text
            Case "None"
                Me.Label1.BorderStyle = BorderStyle.None
                Me.lblPropBorderStyleEnumVal.Text = BorderStyle.None
            Case "FixedSingle"
                Me.Label1.BorderStyle = BorderStyle.FixedSingle
                Me.lblPropBorderStyleEnumVal.Text = BorderStyle.FixedSingle
            Case "Fixed3D"
                Me.Label1.BorderStyle = BorderStyle.Fixed3D
                Me.lblPropBorderStyleEnumVal.Text = BorderStyle.Fixed3D
        End Select
    End Sub

    Private Sub cboPropBorderStyle_SetValue()
        Select Case Me.Label1.BorderStyle
            Case BorderStyle.None ' 0
                Me.cboPropBorderStyle.SelectedText = "None"
                Me.lblPropBorderStyleEnumVal.Text = BorderStyle.None
            Case BorderStyle.FixedSingle ' 1 
                Me.cboPropBorderStyle.SelectedText = "FixedSingle"
                Me.lblPropBorderStyleEnumVal.Text = BorderStyle.FixedSingle
            Case BorderStyle.Fixed3D ' 2
                Me.cboPropBorderStyle.SelectedText = "Fixed3D"
                Me.lblPropBorderStyleEnumVal.Text = BorderStyle.Fixed3D
        End Select
    End Sub

    '-------------------------------------------------
    ' Private Form Procedures
    '-------------------------------------------------

    Private Sub ListboxEvents_Add(pText As String)
        Me.lbEventsLabel1.Items.Add(pText)
        Me.lbEventsLabel1.SetSelected(Me.lbEventsLabel1.Items.Count - 1, True)
    End Sub

End Class