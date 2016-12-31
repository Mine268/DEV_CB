<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startCbForm
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
        Me.cbType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBox_Act = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox_command = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox_nbt = New System.Windows.Forms.TextBox
        Me.Button_Add = New System.Windows.Forms.Button
        Me.Button_disable = New System.Windows.Forms.Button
        Me.Button_enable = New System.Windows.Forms.Button
        Me.ToolTip_NBT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_tpNext = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cbType
        '
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"RCB", "ICB", "CCB"})
        Me.cbType.Location = New System.Drawing.Point(87, 7)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(129, 22)
        Me.cbType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CB type: "
        '
        'CheckBox_Act
        '
        Me.CheckBox_Act.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_Act.AutoSize = True
        Me.CheckBox_Act.Checked = True
        Me.CheckBox_Act.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Act.Location = New System.Drawing.Point(222, 5)
        Me.CheckBox_Act.Name = "CheckBox_Act"
        Me.CheckBox_Act.Size = New System.Drawing.Size(108, 24)
        Me.CheckBox_Act.TabIndex = 3
        Me.CheckBox_Act.Text = "Always Active"
        Me.CheckBox_Act.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Command:"
        '
        'TextBox_command
        '
        Me.TextBox_command.Location = New System.Drawing.Point(87, 33)
        Me.TextBox_command.Name = "TextBox_command"
        Me.TextBox_command.Size = New System.Drawing.Size(243, 22)
        Me.TextBox_command.TabIndex = 5
        Me.ToolTip_NBT.SetToolTip(Me.TextBox_command, "Do not use this character: ""|""")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Marker NBTs: "
        '
        'TextBox_nbt
        '
        Me.TextBox_nbt.Location = New System.Drawing.Point(103, 57)
        Me.TextBox_nbt.Name = "TextBox_nbt"
        Me.TextBox_nbt.Size = New System.Drawing.Size(227, 22)
        Me.TextBox_nbt.TabIndex = 7
        Me.ToolTip_NBT.SetToolTip(Me.TextBox_nbt, "{Tags:[""a"",""b"",""c""],Duration:256}")
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(14, 80)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(316, 23)
        Me.Button_Add.TabIndex = 8
        Me.Button_Add.Text = "Add a command block"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Button_disable
        '
        Me.Button_disable.Location = New System.Drawing.Point(14, 109)
        Me.Button_disable.Name = "Button_disable"
        Me.Button_disable.Size = New System.Drawing.Size(316, 23)
        Me.Button_disable.TabIndex = 9
        Me.Button_disable.Text = "Disable this"
        Me.Button_disable.UseVisualStyleBackColor = True
        '
        'Button_enable
        '
        Me.Button_enable.Enabled = False
        Me.Button_enable.Location = New System.Drawing.Point(14, 138)
        Me.Button_enable.Name = "Button_enable"
        Me.Button_enable.Size = New System.Drawing.Size(316, 23)
        Me.Button_enable.TabIndex = 10
        Me.Button_enable.Text = "Enable this"
        Me.Button_enable.UseVisualStyleBackColor = True
        '
        'ToolTip_NBT
        '
        Me.ToolTip_NBT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip_NBT.ToolTipTitle = "e.g."
        '
        'Button_tpNext
        '
        Me.Button_tpNext.Location = New System.Drawing.Point(14, 167)
        Me.Button_tpNext.Name = "Button_tpNext"
        Me.Button_tpNext.Size = New System.Drawing.Size(316, 23)
        Me.Button_tpNext.TabIndex = 11
        Me.Button_tpNext.Text = "Next cb"
        Me.Button_tpNext.UseVisualStyleBackColor = True
        '
        'startCbForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_tpNext)
        Me.Controls.Add(Me.Button_enable)
        Me.Controls.Add(Me.Button_disable)
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
        Me.Name = "startCbForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "startCb"
        Me.Text = "Starter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_Act As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_command As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_nbt As System.Windows.Forms.TextBox
    Friend WithEvents Button_Add As System.Windows.Forms.Button
    Friend WithEvents Button_disable As System.Windows.Forms.Button
    Friend WithEvents Button_enable As System.Windows.Forms.Button
    Friend WithEvents ToolTip_NBT As System.Windows.Forms.ToolTip
    Friend WithEvents Button_tpNext As System.Windows.Forms.Button
End Class
