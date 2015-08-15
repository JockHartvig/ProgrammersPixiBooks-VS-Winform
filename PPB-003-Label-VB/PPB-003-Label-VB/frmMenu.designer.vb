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
        Me.btnForm01 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnForm01
        '
        Me.btnForm01.Location = New System.Drawing.Point(12, 38)
        Me.btnForm01.Name = "btnForm01"
        Me.btnForm01.Size = New System.Drawing.Size(170, 23)
        Me.btnForm01.TabIndex = 1
        Me.btnForm01.Text = "Form 01 - Propertis, events"
        Me.btnForm01.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 314)
        Me.Controls.Add(Me.btnForm01)
        Me.Name = "frmMenu"
        Me.Text = "Pixi-Book 003 Label Demo VB - Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnForm01 As System.Windows.Forms.Button

End Class
