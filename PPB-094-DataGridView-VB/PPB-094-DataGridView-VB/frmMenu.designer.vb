<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDemo0101 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(32, 293)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDemo0101
        '
        Me.btnDemo0101.Location = New System.Drawing.Point(32, 54)
        Me.btnDemo0101.Name = "btnDemo0101"
        Me.btnDemo0101.Size = New System.Drawing.Size(137, 23)
        Me.btnDemo0101.TabIndex = 1
        Me.btnDemo0101.Text = "Button1"
        Me.btnDemo0101.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "02 - MultiSelect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 356)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDemo0101)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmMenu"
        Me.Text = "DataGridView - Demo01 - Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDemo0101 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
