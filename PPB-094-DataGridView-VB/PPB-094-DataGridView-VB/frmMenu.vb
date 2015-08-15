Public Class frmMenu

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDemo0101_Click(sender As System.Object, e As System.EventArgs) Handles btnDemo0101.Click
        Dim frmForm As New frmDemo01_01
        frmForm.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim frmForm As New frmDemo01_MultiSelect
        frmForm.Show()
    End Sub
End Class
