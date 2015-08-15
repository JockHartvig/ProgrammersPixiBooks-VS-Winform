<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForm01
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpPropLabel1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPropBorderStyleEnumVal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPropBorderStyle = New System.Windows.Forms.ComboBox()
        Me.chkPropEnabled = New System.Windows.Forms.CheckBox()
        Me.chkPropVisible = New System.Windows.Forms.CheckBox()
        Me.grpEvtLabel1 = New System.Windows.Forms.GroupBox()
        Me.btnClearEventList = New System.Windows.Forms.Button()
        Me.lbEventsLabel1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSetLabel1Text = New System.Windows.Forms.Button()
        Me.txtLabel1TextBox = New System.Windows.Forms.TextBox()
        Me.grpPropLabel1.SuspendLayout()
        Me.grpEvtLabel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(204, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1Text"
        '
        'grpPropLabel1
        '
        Me.grpPropLabel1.Controls.Add(Me.txtLabel1TextBox)
        Me.grpPropLabel1.Controls.Add(Me.btnSetLabel1Text)
        Me.grpPropLabel1.Controls.Add(Me.Label6)
        Me.grpPropLabel1.Controls.Add(Me.Label5)
        Me.grpPropLabel1.Controls.Add(Me.Label4)
        Me.grpPropLabel1.Controls.Add(Me.Label1)
        Me.grpPropLabel1.Controls.Add(Me.lblPropBorderStyleEnumVal)
        Me.grpPropLabel1.Controls.Add(Me.Label2)
        Me.grpPropLabel1.Controls.Add(Me.cboPropBorderStyle)
        Me.grpPropLabel1.Controls.Add(Me.chkPropEnabled)
        Me.grpPropLabel1.Controls.Add(Me.chkPropVisible)
        Me.grpPropLabel1.Location = New System.Drawing.Point(12, 67)
        Me.grpPropLabel1.Name = "grpPropLabel1"
        Me.grpPropLabel1.Size = New System.Drawing.Size(315, 207)
        Me.grpPropLabel1.TabIndex = 1
        Me.grpPropLabel1.TabStop = False
        Me.grpPropLabel1.Text = "Label1 Properties"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Value"
        '
        'lblPropBorderStyleEnumVal
        '
        Me.lblPropBorderStyleEnumVal.AutoSize = True
        Me.lblPropBorderStyleEnumVal.Location = New System.Drawing.Point(203, 169)
        Me.lblPropBorderStyleEnumVal.Name = "lblPropBorderStyleEnumVal"
        Me.lblPropBorderStyleEnumVal.Size = New System.Drawing.Size(17, 13)
        Me.lblPropBorderStyleEnumVal.TabIndex = 4
        Me.lblPropBorderStyleEnumVal.Text = "xx"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BorderStyle"
        '
        'cboPropBorderStyle
        '
        Me.cboPropBorderStyle.FormattingEnabled = True
        Me.cboPropBorderStyle.Items.AddRange(New Object() {"None", "FixedSingle", "Fixed3D"})
        Me.cboPropBorderStyle.Location = New System.Drawing.Point(9, 166)
        Me.cboPropBorderStyle.Name = "cboPropBorderStyle"
        Me.cboPropBorderStyle.Size = New System.Drawing.Size(121, 21)
        Me.cboPropBorderStyle.TabIndex = 2
        '
        'chkPropEnabled
        '
        Me.chkPropEnabled.AutoSize = True
        Me.chkPropEnabled.Location = New System.Drawing.Point(9, 129)
        Me.chkPropEnabled.Name = "chkPropEnabled"
        Me.chkPropEnabled.Size = New System.Drawing.Size(65, 17)
        Me.chkPropEnabled.TabIndex = 1
        Me.chkPropEnabled.Text = "Enabled"
        Me.chkPropEnabled.UseVisualStyleBackColor = True
        '
        'chkPropVisible
        '
        Me.chkPropVisible.AutoSize = True
        Me.chkPropVisible.Location = New System.Drawing.Point(9, 106)
        Me.chkPropVisible.Name = "chkPropVisible"
        Me.chkPropVisible.Size = New System.Drawing.Size(56, 17)
        Me.chkPropVisible.TabIndex = 0
        Me.chkPropVisible.Text = "Visible"
        Me.chkPropVisible.UseVisualStyleBackColor = True
        '
        'grpEvtLabel1
        '
        Me.grpEvtLabel1.Controls.Add(Me.btnClearEventList)
        Me.grpEvtLabel1.Controls.Add(Me.lbEventsLabel1)
        Me.grpEvtLabel1.Location = New System.Drawing.Point(366, 67)
        Me.grpEvtLabel1.Name = "grpEvtLabel1"
        Me.grpEvtLabel1.Size = New System.Drawing.Size(275, 257)
        Me.grpEvtLabel1.TabIndex = 2
        Me.grpEvtLabel1.TabStop = False
        Me.grpEvtLabel1.Text = "Label1 Events"
        '
        'btnClearEventList
        '
        Me.btnClearEventList.Location = New System.Drawing.Point(6, 19)
        Me.btnClearEventList.Name = "btnClearEventList"
        Me.btnClearEventList.Size = New System.Drawing.Size(94, 23)
        Me.btnClearEventList.TabIndex = 22
        Me.btnClearEventList.Text = "Clear event list"
        Me.btnClearEventList.UseVisualStyleBackColor = True
        '
        'lbEventsLabel1
        '
        Me.lbEventsLabel1.FormattingEnabled = True
        Me.lbEventsLabel1.Location = New System.Drawing.Point(6, 48)
        Me.lbEventsLabel1.Name = "lbEventsLabel1"
        Me.lbEventsLabel1.Size = New System.Drawing.Size(229, 186)
        Me.lbEventsLabel1.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(9, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Text"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Property"
        '
        'btnSetLabel1Text
        '
        Me.btnSetLabel1Text.Location = New System.Drawing.Point(129, 37)
        Me.btnSetLabel1Text.Name = "btnSetLabel1Text"
        Me.btnSetLabel1Text.Size = New System.Drawing.Size(68, 22)
        Me.btnSetLabel1Text.TabIndex = 7
        Me.btnSetLabel1Text.Text = "Set text"
        Me.btnSetLabel1Text.UseVisualStyleBackColor = True
        '
        'txtLabel1TextBox
        '
        Me.txtLabel1TextBox.Location = New System.Drawing.Point(45, 39)
        Me.txtLabel1TextBox.Name = "txtLabel1TextBox"
        Me.txtLabel1TextBox.Size = New System.Drawing.Size(78, 20)
        Me.txtLabel1TextBox.TabIndex = 4
        '
        'frmForm01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 468)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpEvtLabel1)
        Me.Controls.Add(Me.grpPropLabel1)
        Me.Name = "frmForm01"
        Me.Text = "Demo Form 01 - Label properties, events"
        Me.grpPropLabel1.ResumeLayout(False)
        Me.grpPropLabel1.PerformLayout()
        Me.grpEvtLabel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpPropLabel1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpEvtLabel1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbEventsLabel1 As System.Windows.Forms.ListBox
    Friend WithEvents btnClearEventList As System.Windows.Forms.Button
    Friend WithEvents chkPropVisible As System.Windows.Forms.CheckBox
    Friend WithEvents chkPropEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboPropBorderStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPropBorderStyleEnumVal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLabel1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSetLabel1Text As System.Windows.Forms.Button
End Class
