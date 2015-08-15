Public Class frmMenu

    Private Sub frmForm0_Click(sender As System.Object, e As System.EventArgs) Handles btnForm0.Click
        Dim form As New frmForm0
        form.Show()
    End Sub

    Private Sub btnForm1_Click(sender As System.Object, e As System.EventArgs) Handles btnForm1.Click
        Dim form As New frmForm1
        form.Show()
    End Sub

    Private Sub btnForm2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnForm2.Click
        Dim form As New frmForm2
        form.Show()
    End Sub

    Private Sub btnForm3_Click(sender As System.Object, e As System.EventArgs) Handles btnForm3.Click
        Dim form As New frmForm3
        form.Show()
    End Sub

    Private Sub btnForm4_Click(sender As System.Object, e As System.EventArgs) Handles btnForm4.Click
        Dim form As New frmForm4
        form.Show()
    End Sub

    Private Sub btnForm8_Click(sender As System.Object, e As System.EventArgs) Handles btnForm8.Click
        Dim form As New frmForm8
        form.Show()
    End Sub
    Private Sub btnForm9_Click(sender As System.Object, e As System.EventArgs) Handles btnForm9.Click
        Dim form As New frmForm9_PseudoMultiColumnCBO
        form.Show()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class