<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setCbForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Button1 = New System.Windows.Forms.Button
        Me.setCbBtn = New System.Windows.Forms.Button
        Me.text_CbName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolTip_name = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancel[&C]"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'setCbBtn
        '
        Me.setCbBtn.Location = New System.Drawing.Point(15, 34)
        Me.setCbBtn.Name = "setCbBtn"
        Me.setCbBtn.Size = New System.Drawing.Size(206, 23)
        Me.setCbBtn.TabIndex = 6
        Me.setCbBtn.Text = "Create a starter[&Y]"
        Me.setCbBtn.UseVisualStyleBackColor = True
        '
        'text_CbName
        '
        Me.text_CbName.Location = New System.Drawing.Point(67, 6)
        Me.text_CbName.Name = "text_CbName"
        Me.text_CbName.Size = New System.Drawing.Size(154, 22)
        Me.text_CbName.TabIndex = 5
        Me.ToolTip_name.SetToolTip(Me.text_CbName, "Can only ues the English words!")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name: "
        '
        'ToolTip_name
        '
        Me.ToolTip_name.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        '
        'setCbForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 102)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.setCbBtn)
        Me.Controls.Add(Me.text_CbName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "setCbForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.ToolTip_name.SetToolTip(Me, "Warning")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents setCbBtn As System.Windows.Forms.Button
    Friend WithEvents text_CbName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip_name As System.Windows.Forms.ToolTip
End Class
