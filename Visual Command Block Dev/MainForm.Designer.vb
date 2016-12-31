<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitESCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateAStartingCommandBlockCtrlDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GenerateCtrlGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStripStatusLabel_Version = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CreateANewStarterNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ErrTestEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileOperationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem_set_init_command = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_addIniCmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_saveToFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CBOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAStarterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ErrTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateTheCommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenFile_ini = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFile_ini = New System.Windows.Forms.SaveFileDialog()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewFileToolStripMenuItem, Me.SaveSToolStripMenuItem, Me.ToolStripTextBox1, Me.ExitESCToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.FileToolStripMenuItem.Text = "File[&F]"
        '
        'NewFileToolStripMenuItem
        '
        Me.NewFileToolStripMenuItem.Name = "NewFileToolStripMenuItem"
        Me.NewFileToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.NewFileToolStripMenuItem.Text = "Load[&N]"
        '
        'SaveSToolStripMenuItem
        '
        Me.SaveSToolStripMenuItem.Name = "SaveSToolStripMenuItem"
        Me.SaveSToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SaveSToolStripMenuItem.Text = "Save[&S]"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(120, 6)
        '
        'ExitESCToolStripMenuItem
        '
        Me.ExitESCToolStripMenuItem.Name = "ExitESCToolStripMenuItem"
        Me.ExitESCToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ExitESCToolStripMenuItem.Text = "Exit[&E]"
        '
        'OperateToolStripMenuItem
        '
        Me.OperateToolStripMenuItem.Name = "OperateToolStripMenuItem"
        Me.OperateToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.OperateToolStripMenuItem.Text = "Operate[&O]"
        '
        'CreateAStartingCommandBlockCtrlDToolStripMenuItem
        '
        Me.CreateAStartingCommandBlockCtrlDToolStripMenuItem.Name = "CreateAStartingCommandBlockCtrlDToolStripMenuItem"
        Me.CreateAStartingCommandBlockCtrlDToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'GenerateCtrlGToolStripMenuItem
        '
        Me.GenerateCtrlGToolStripMenuItem.Name = "GenerateCtrlGToolStripMenuItem"
        Me.GenerateCtrlGToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        '
        'OpenFile
        '
        Me.OpenFile.Filter = "DEV Cb file|*.vcb|All files|*.*"
        '
        'SaveFile
        '
        Me.SaveFile.Filter = "Dev Cb file|*.vcb"
        '
        'ToolStripStatusLabel_Version
        '
        Me.ToolStripStatusLabel_Version.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel_Version.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel_Version.Name = "ToolStripStatusLabel_Version"
        Me.ToolStripStatusLabel_Version.Size = New System.Drawing.Size(231, 17)
        Me.ToolStripStatusLabel_Version.Text = "DEV CB 1.0 - Produced By Mine268"
        Me.ToolStripStatusLabel_Version.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'CreateANewStarterNToolStripMenuItem
        '
        Me.CreateANewStarterNToolStripMenuItem.Name = "CreateANewStarterNToolStripMenuItem"
        Me.CreateANewStarterNToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.CreateANewStarterNToolStripMenuItem.Text = "Create a new Starter[&N]"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(205, 6)
        '
        'ErrTestEToolStripMenuItem
        '
        Me.ErrTestEToolStripMenuItem.Name = "ErrTestEToolStripMenuItem"
        Me.ErrTestEToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ErrTestEToolStripMenuItem.Text = "Err test[&E]"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(47, 20)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(203, 17)
        Me.ToolStripStatusLabel1.Text = "DEV CB - Produced By Mine268"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileOperationToolStripMenuItem, Me.CBOperationsToolStripMenuItem, Me.AboutToolStripMenuItem2})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(636, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileOperationToolStripMenuItem
        '
        Me.FileOperationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ToolStripSeparator5, Me.ToolStripMenuItem_set_init_command, Me.ToolStripMenuItem_addIniCmd, Me.ToolStripMenuItem_saveToFile, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileOperationToolStripMenuItem.Name = "FileOperationToolStripMenuItem"
        Me.FileOperationToolStripMenuItem.Size = New System.Drawing.Size(145, 20)
        Me.FileOperationToolStripMenuItem.Text = "File Operations[&F]"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(319, 22)
        Me.LoadToolStripMenuItem.Text = "Load Serial[&A]"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(319, 22)
        Me.SaveToolStripMenuItem.Text = "Save Serial[&S]"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(316, 6)
        '
        'ToolStripMenuItem_set_init_command
        '
        Me.ToolStripMenuItem_set_init_command.Name = "ToolStripMenuItem_set_init_command"
        Me.ToolStripMenuItem_set_init_command.Size = New System.Drawing.Size(319, 22)
        Me.ToolStripMenuItem_set_init_command.Text = "Set init command[&H]"
        '
        'ToolStripMenuItem_addIniCmd
        '
        Me.ToolStripMenuItem_addIniCmd.Name = "ToolStripMenuItem_addIniCmd"
        Me.ToolStripMenuItem_addIniCmd.Size = New System.Drawing.Size(319, 22)
        Me.ToolStripMenuItem_addIniCmd.Text = "Load the init commands from file[&F]"
        '
        'ToolStripMenuItem_saveToFile
        '
        Me.ToolStripMenuItem_saveToFile.Name = "ToolStripMenuItem_saveToFile"
        Me.ToolStripMenuItem_saveToFile.Size = New System.Drawing.Size(319, 22)
        Me.ToolStripMenuItem_saveToFile.Text = "Save the init commands to file[&U]"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(316, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(319, 22)
        Me.ExitToolStripMenuItem.Text = "Exit[&E]"
        '
        'CBOperationsToolStripMenuItem
        '
        Me.CBOperationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAStarterToolStripMenuItem, Me.ToolStripSeparator4, Me.ErrTestToolStripMenuItem, Me.GenerateTheCommandToolStripMenuItem})
        Me.CBOperationsToolStripMenuItem.Name = "CBOperationsToolStripMenuItem"
        Me.CBOperationsToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.CBOperationsToolStripMenuItem.Text = "CB operations[&C]"
        '
        'AddAStarterToolStripMenuItem
        '
        Me.AddAStarterToolStripMenuItem.Name = "AddAStarterToolStripMenuItem"
        Me.AddAStarterToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.AddAStarterToolStripMenuItem.Text = "Add a Starter[&N]"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(232, 6)
        '
        'ErrTestToolStripMenuItem
        '
        Me.ErrTestToolStripMenuItem.Name = "ErrTestToolStripMenuItem"
        Me.ErrTestToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ErrTestToolStripMenuItem.Text = "Err test[&D]"
        '
        'GenerateTheCommandToolStripMenuItem
        '
        Me.GenerateTheCommandToolStripMenuItem.Name = "GenerateTheCommandToolStripMenuItem"
        Me.GenerateTheCommandToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.GenerateTheCommandToolStripMenuItem.Text = "Generate the command[&G]"
        '
        'AboutToolStripMenuItem2
        '
        Me.AboutToolStripMenuItem2.Name = "AboutToolStripMenuItem2"
        Me.AboutToolStripMenuItem2.Size = New System.Drawing.Size(75, 20)
        Me.AboutToolStripMenuItem2.Text = "About[&A]"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 372)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(636, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(266, 17)
        Me.ToolStripStatusLabel2.Text = "DEV CB Beta 1.0 - Produced By Mine268"
        '
        'OpenFile_ini
        '
        Me.OpenFile_ini.Filter = "init file|*.vin|All files|*.*"
        '
        'SaveFile_ini
        '
        Me.SaveFile_ini.Filter = "init file|*.vin"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(636, 394)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Menu = Me.MainMenu1
        Me.Name = "MainForm"
        Me.Text = "DEV CB Beta 1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitESCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateAStartingCommandBlockCtrlDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GenerateCtrlGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripStatusLabel_Version As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CreateANewStarterNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ErrTestEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileOperationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CBOperationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddAStarterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ErrTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GenerateTheCommandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem_set_init_command As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_addIniCmd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem_saveToFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFile_ini As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFile_ini As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu

End Class
