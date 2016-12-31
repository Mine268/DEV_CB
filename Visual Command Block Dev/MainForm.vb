
Public Class MainForm
    Public sw As System.IO.StreamWriter
    Public sr As System.IO.StreamReader

    Public sw_ini As System.IO.StreamWriter
    Public sr_ini As System.IO.StreamReader

    'Private Sub CreateAStartingCommandBlockCtrlDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateAStartingCommandBlockCtrlDToolStripMenuItem.Click
    '    addNewStarter()
    'End Sub

    Private Sub addNewStarter()
        Dim Starter As New startCbForm()
        Starter.MdiParent = Me
        Starter.Show()
    End Sub

    'Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
    '    'aboutForm.ShowDialog()
    'End Sub

    'Private Sub GenerateCtrlGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateCtrlGToolStripMenuItem.Click
    '    Generate()
    'End Sub

    Private Sub Generate()
        commands = vbCrLf
        Dim cb As New cbForm()
        For Each sCb As startCbForm In starterSerial

            commands += sCb.compiledAble.ToString + vbCrLf
            commands += sCb.starterName + "|" + sCb.cbType.Text + "|" + sCb.CheckBox_Act.Checked.ToString + "|" + sCb.TextBox_command.Text + "|" + sCb.TextBox_nbt.Text + vbCrLf
            cb = sCb.NextCb

            While (True)
                Try
                    commands += cb.nameOfCb + "|" + cb.cbType.Text + "|" + cb.CheckBox_Act.Checked.ToString + "|" + cb.reCbCommand + "|" + cb.TextBox_nbt.Text + vbCrLf
                    cb = cb.NextCb
                Catch ex As Exception
                    Exit While
                End Try
            End While
            commands += "End_partN" + vbCrLf
        Next

    End Sub

    'Private Sub ExitESCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitESCToolStripMenuItem.Click
    '    Me.Close()
    'End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim n As Integer = MsgBox("Exit or not?" + vbCrLf + "If you have not saved yet, you had better click ""No"".", MsgBoxStyle.YesNo, "Wait...")
        If (n = 7) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub saveData() '保存数据过程
        If (SaveFile.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Try
                sw = New System.IO.StreamWriter(SaveFile.FileName, False)
                sw.Write(commands)
                sw.Close()
            Catch ex As Exception
                sr.Close()
                sw = New System.IO.StreamWriter(SaveFile.FileName, False)
                sw.Write(commands)
                sw.Close()
            End Try
        End If
    End Sub

    Private Sub loadData() '载入数据过程

        On Error Resume Next

        If (OpenFile.ShowDialog = Windows.Forms.DialogResult.OK) Then

            sr = New System.IO.StreamReader(OpenFile.FileName, False)

            '数据结构:CB名字|CB类型|是否cond|CB命令|Marker_NBT
            Dim commandParts() As String = Split(sr.ReadToEnd.ToString, vbCrLf + "End_partN")
            Dim part As String = "" '一个模块
            Dim line() As String '模块的一行
            Dim elements() As String '一行的每一个元素

            Dim f_1 As Integer, f_2 As Integer 'for变量

            For f_1 = 0 To commandParts.Length - 2
                'Debug.Print(commandParts(f_1))
                part = commandParts(f_1)
                line = Split(part, vbCrLf)

                '这里用来处理Starter{
                Dim startF As New startCbForm()
                startF.loadFromFile = True

                Dim serialV(UBound(starterSerial) + 1) As startCbForm
                Dim f As Integer = 0
                For f = 0 To UBound(starterSerial)
                    serialV(f) = starterSerial(f)
                Next
                serialV(UBound(starterSerial) + 1) = startF
                startF.num = UBound(starterSerial) + 1
                starterSerial = serialV

                startF.starterName = Split(line(2), "|")(0).ToString '名字
                startF.Text += " - " + startF.starterName
                startF.cbType.Text = Split(line(2), "|")(1).ToString 'cb模式
                startF.CheckBox_Act.Checked = boolToStr(Split(line(2), "|")(2).ToString) '是否always active
                startF.TextBox_command.Text = Split(line(2), "|")(3).ToString '命令
                startF.TextBox_nbt.Text = Split(line(2), "|")(4).ToString 'Marker Nbt
                'MsgBox(Split(line(2), "|")(3).ToString)

                'complieable
                startF.compiledAble = boolToStr(line(1))
                If (startF.compiledAble) Then
                    startF.Button_disable.Enabled = True
                    startF.Button_enable.Enabled = False
                Else
                    startF.Button_disable.Enabled = False
                    startF.Button_enable.Enabled = True
                End If

                startF.MdiParent = Me

                startF.Show()
                '}

                Dim cbF2 As New cbForm()
                For f_2 = 3 To line.Length - 1
                    'Debug.Print(line(f_2))
                    elements = Split(line(f_2), "|")

                    Dim cbF As New cbForm()
                    'Dim cbF2 As New cbForm()

                    cbF.nameOfCb = elements(0).ToString 'name
                    cbF.loadFromFile = True
                    cbF.MdiParent = Me

                    cbF.Text += " - " + elements(0).ToString 'name ,too
                    cbF.cbType.Text = elements(1).ToString 'cb type
                    cbF.CheckBox_Act.Checked = boolToStr(elements(2).ToString) 'always active or not
                    cbF.TextBox_command.Text = elements(3).ToString 'commands
                    cbF.TextBox_nbt.Text = elements(4).ToString 'Marker NBT

                    If (f_2 = 3) Then '建立连接
                        cbF.preCb = startF
                        CType(cbF.preCb, startCbForm).NextCb = cbF
                    ElseIf (f_2 = 4) Then
                        cbF.preCb = CType(cbF2.preCb, startCbForm).NextCb
                        CType(cbF.preCb, cbForm).NextCb = cbF
                    ElseIf (f_2 > 4) Then
                        cbF.preCb = CType(cbF2.preCb, cbForm).NextCb
                        CType(cbF.preCb, cbForm).NextCb = cbF
                    End If

                    cbF2 = cbF
                    cbF.Show()
                Next
            Next
        End If
    End Sub

    Private Sub SaveSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveSToolStripMenuItem.Click
        Generate()
        saveData()
    End Sub

    'Private Sub NewFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFileToolStripMenuItem.Click
    '    loadData()
    'End Sub

    'Private Sub CreateANewStarterNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateANewStarterNToolStripMenuItem.Click
    '    addNewStarter()
    'End Sub

    'Private Sub ErrTestEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErrTestEToolStripMenuItem.Click
    '    Generate()
    'End Sub

    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        loadData()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Generate()
        saveData()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddAStarterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAStarterToolStripMenuItem.Click
        addNewStarter()
    End Sub

    Private Sub ErrTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErrTestToolStripMenuItem.Click
        Generate()
    End Sub

    Private Sub AboutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem2.Click
        aboutAuthor.ShowDialog()
    End Sub

    Private Sub GenerateTheCommandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateTheCommandToolStripMenuItem.Click
        Dim x As Integer = 1, z As Integer = 1
        oocNbt = ""
        theCommand = ""
        Generate()

        Dim serial() As String = Split(commands, "End_partN")
        For Each part As String In serial
            Dim lines() As String = Split(part, vbCrLf)

            If (lines(1) = "True") Then

                Dim f_1 As Integer
                For f_1 = 2 To lines.Length - 2
                    Dim elements() As String = Split(lines(f_1), "|")
                    'MsgBox(lines(f_1))
                    Debug.Print(elements(0) + " " + elements(1) + " " + elements(2) + " " + elements(3) + " " + elements(4))

                    oocNbt += "{id:MinecartCommandBlock,Command:""setblock ~" + x.ToString + " ~0 ~" + z.ToString + " " '初始命令头

                    Select Case elements(1)
                        Case "RCB"
                            oocNbt += "repeating_command_block 3 replace "
                        Case "ICB"
                            oocNbt += "command_block 3 replace "
                        Case "CCB"
                            oocNbt += "chain_command_block 3 replace "
                    End Select 'cb类别鉴定

                    oocNbt += "{auto:" + elements(2).ToString.ToLower + ",Command:\""" + elements(3).ToString.Replace("\", "\\").Replace("""", "\""").Replace("\\", "\\\\").Replace("\""", "\\\""") + "\""}""},"

                    If (elements(4) = "") Then
                    Else
                        oocNbt += "{id:MinecartCommandBlock,Command:""summon AreaEffectCloud ~" + x.ToString + " ~" + " ~" + z.ToString + " " + elements(4).ToString.Replace("\", "\\").Replace("""", "\""") + """},"
                    End If

                    z += 1
                Next
                x += 1
                z = 1
            End If
        Next

        Dim f_2 As Integer = 0
        For f_2 = 0 To Split(init, vbLf).Length - 1
            'MsgBox(Split(init, vbLf)(f_2))
            oocNbt += "{id:MinecartCommandBlock,Command:""" + Split(init, vbLf)(f_2).ToString.Replace("\", "\\").Replace("""", "\""") + """},"
        Next

        oocNbt = oocNbt.Substring(0, oocNbt.Length - 1)

        theCommand = "/summon FallingSand ~ ~1.5 ~ {Motion:[0.0d,-0.5d,0.0d],Time:1,Block:redstone_block,Passengers:[" '命令最终合并
        theCommand += "{id:FallingSand,Time:1,Block:activator_rail,Passengers:["
        theCommand += oocNbt
        theCommand += "]},"
        theCommand += "{id:MinecartCommandBlock,Command:""summon LightningBolt ~ ~ ~""},"
        theCommand += "{id:MinecartCommandBlock,Command:""fill ~ ~ ~ ~ ~-1 ~ air""}"
        theCommand += "]}"

        generationCommand.ShowDialog() '显示command
    End Sub

    Private Sub ToolStripMenuItem_set_init_command_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_set_init_command.Click
        iniCmd.Show()
    End Sub

    Private Sub ToolStripMenuItem_addIniCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_addIniCmd.Click
        If (OpenFile_ini.ShowDialog = Windows.Forms.DialogResult.OK) Then
            sr_ini = New System.IO.StreamReader(OpenFile_ini.FileName)
            init = sr_ini.ReadToEnd

            iniCmd.rtb_ini.Text = init
            iniCmd.rtb_ini.ForeColor = Color.Black

            sr_ini.Close()
        End If
    End Sub

    Private Sub ToolStripMenuItem_saveToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem_saveToFile.Click
        If (SaveFile_ini.ShowDialog = Windows.Forms.DialogResult.OK) Then
            sw_ini = New System.IO.StreamWriter(SaveFile_ini.FileName)
            sw_ini.Write(init)
            sw_ini.Close()
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'ooc语法
'/summon FallingSand ~ ~1.5 ~ {Motion:[0.0d,-0.5d,0.0d],Time:1,Block:redstone_block,Passengers:[

'{id:FallingSand,Time:1,Block:activator_rail,Passengers:[

'生成块

']},

'{id:MinecartCommandBlock,Command:"summon LightningBolt ~ ~ ~"},
'{id:MinecartCommandBlock,Command:"fill ~ ~ ~ ~ ~-1 ~ air"}

']}
