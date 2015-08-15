Public Class frmForm8

    Private Sub frmForm8_Programmatically_AddCbo_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim cboComboBox1 As New ComboBox
        Dim ItemArray As String() = New String() {"Item 1", "Item 2", "Item 3"}

        With cboComboBox1
            .DataSource = ItemArray
            .Location = New System.Drawing.Point(12, 12)
            .Name = "cboComboBox1"
            .Size = New System.Drawing.Size(166, 21)
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        Me.Controls.Add(cboComboBox1)

    End Sub

End Class