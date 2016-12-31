<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cbForm
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
        Me.Button_Add = New System.Windows.Forms.Button
        Me.TextBox_nbt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox_command = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CheckBox_Act = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbType = New System.Windows.Forms.ComboBox
        Me.Button_Remove = New System.Windows.Forms.Button
        Me.ToolTip_NBT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_toNextCb = New System.Windows.Forms.Button
        Me.Button_toPreCb = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(15, 82)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(316, 23)
        Me.Button_Add.TabIndex = 17
        Me.Button_Add.Text = "Add a command block"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'TextBox_nbt
        '
        Me.TextBox_nbt.Location = New System.Drawing.Point(104, 56)
        Me.TextBox_nbt.Name = "TextBox_nbt"
        Me.TextBox_nbt.Size = New System.Drawing.Size(227, 22)
        Me.TextBox_nbt.TabIndex = 16
        Me.ToolTip_NBT.SetToolTip(Me.TextBox_nbt, "{Tags:[""a"",""b"",""c""],Duration:256}")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 14)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Marker NBTs: "
        '
        'TextBox_command
        '
        Me.TextBox_command.Location = New System.Drawing.Point(88, 32)
        Me.TextBox_command.Name = "TextBox_command"
        Me.TextBox_command.Size = New System.Drawing.Size(243, 22)
        Me.TextBox_command.TabIndex = 14
        Me.ToolTip_NBT.SetToolTip(Me.TextBox_command, "Do not use this cahracter: ""|""")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 14)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Command:"
        '
        'CheckBox_Act
        '
        Me.CheckBox_Act.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Act.AutoSize = True
        Me.CheckBox_Act.Checked = True
        Me.CheckBox_Act.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Act.Location = New System.Drawing.Point(223, 4)
        Me.CheckBox_Act.Name = "CheckBox_Act"
        Me.CheckBox_Act.Size = New System.Drawing.Size(108, 24)
        Me.CheckBox_Act.TabIndex = 12
        Me.CheckBox_Act.Text = "Always Active"
        Me.CheckBox_Act.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox_Act.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "CB type: "
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"RCB", "ICB", "CCB"})
        Me.cbType.Location = New System.Drawing.Point(88, 6)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(129, 22)
        Me.cbType.TabIndex = 9
        '
        'Button_Remove
        '
        Me.Button_Remove.Location = New System.Drawing.Point(15, 110)
        Me.Button_Remove.Name = "Button_Remove"
        Me.Button_Remove.Size = New System.Drawing.Size(316, 23)
        Me.Button_Remove.TabIndex = 18
        Me.Button_Remove.Text = "Remove this command block"
        Me.Button_Remove.UseVisualStyleBackColor = True
        '
        'ToolTip_NBT
        '
        Me.ToolTip_NBT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip_NBT.ToolTipTitle = "e.g."
        '
        'Button_toNextCb
        '
        Me.Button_toNextCb.Location = New System.Drawing.Point(15, 139)
        Me.Button_toNextCb.Name = "Button_toNextCb"
        Me.Button_toNextCb.Size = New System.Drawing.Size(156, 23)
        Me.Button_toNextCb.TabIndex = 19
        Me.Button_toNextCb.Text = "Next cb"
        Me.Button_toNextCb.UseVisualStyleBackColor = True
        '
        'Button_toPreCb
        '
        Me.Button_toPreCb.Location = New System.Drawing.Point(175, 139)
        Me.Button_toPreCb.Name = "Button_toPreCb"
        Me.Button_toPreCb.Size = New System.Drawing.Size(156, 23)
        Me.Button_toPreCb.TabIndex = 20
        Me.Button_toPreCb.Text = "Preview cb"
        Me.Button_toPreCb.UseVisualStyleBackColor = True
        '
        'cbForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 173)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_toPreCb)
        Me.Controls.Add(Me.Button_toNextCb)
        Me.Controls.Add(Me.Button_Remove)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.TextBox_nbt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_command)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox_Act)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbType)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cbForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Tag = "Cb"
        Me.Text = "command_block"
        Me.ToolTip_NBT.SetToolTip(Me, "{Tags:[""a"",""b"",""c""],Duration:256}")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Add As System.Windows.Forms.Button
    Friend WithEvents TextBox_nbt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_command As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_Act As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Remove As System.Windows.Forms.Button
    Friend WithEvents ToolTip_NBT As System.Windows.Forms.ToolTip
    Friend WithEvents Button_toNextCb As System.Windows.Forms.Button
    Friend WithEvents Button_toPreCb As System.Windows.Forms.Button
End Class
