Public Class frmForm14

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub chkCheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCheckBox1.CheckedChanged
        If Me.chkCheckBox1.Checked Then
            Me.lblLabel2.Enabled = True
            Me.txtTextBox2.Enabled = True
            Me.chkCheckBox2.Enabled = True
            Me.chkCheckBox4.Enabled = True
            If Me.chkCheckBox2.Checked = True Then
                Me.chkCheckBox3.Enabled = True
            Else
                Me.chkCheckBox3.Enabled = False
            End If
        Else
            Me.lblLabel2.Enabled = False
            Me.txtTextBox2.Enabled = False
            Me.chkCheckBox2.Enabled = False
            Me.chkCheckBox3.Enabled = False
            Me.chkCheckBox4.Enabled = False
        End If
    End Sub

    Private Sub chkCheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCheckBox2.CheckedChanged
        If Me.chkCheckBox2.Checked Then
            Me.chkCheckBox3.Enabled = True
        Else
            Me.lblLabel2.Enabled = False
            Me.chkCheckBox3.Enabled = False
        End If

    End Sub
End Class