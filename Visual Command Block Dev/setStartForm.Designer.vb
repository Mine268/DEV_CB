<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setStartForm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.text_starterName = New System.Windows.Forms.TextBox
        Me.setStarterBtn = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ToolTip_name = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name: "
        '
        'text_starterName
        '
        Me.text_starterName.Location = New System.Drawing.Point(67, 6)
        Me.text_starterName.Name = "text_starterName"
        Me.text_starterName.Size = New System.Drawing.Size(154, 22)
        Me.text_starterName.TabIndex = 1
        Me.ToolTip_name.SetToolTip(Me.text_starterName, "Can only ues the English words!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If something happen because you do not obey this" & _
                ", it is goona be your fault.")
        '
        'setStarterBtn
        '
        Me.setStarterBtn.Location = New System.Drawing.Point(15, 34)
        Me.setStarterBtn.Name = "setStarterBtn"
        Me.setStarterBtn.Size = New System.Drawing.Size(206, 23)
        Me.setStarterBtn.TabIndex = 2
        Me.setStarterBtn.Text = "Create a starter[&Y]"
        Me.setStarterBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancel[&C]"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip_name
        '
        Me.ToolTip_name.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.ToolTip_name.ToolTipTitle = "Warning"
        '
        'setStartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 102)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.setStarterBtn)
        Me.Controls.Add(Me.text_starterName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "setStartForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents text_starterName As System.Windows.Forms.TextBox
    Friend WithEvents setStarterBtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip_name As System.Windows.Forms.ToolTip
End Class
