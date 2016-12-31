Public Class startCbForm
    Private setMe As New setStartForm()
    Public starterName As String
    Public num As Integer '本starter在集合中的编号
    Public compiledAble As Boolean = True
    Public NextCb As cbForm = Nothing
    Public loadFromFile As Boolean

    Private Sub startCbForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If (loadFromFile = False) Then
            setMe.newStarterCB = Me '将starterForm传入
            setMe.ShowDialog() '显示设置界面

            If (setMe.canshow) Then
                Me.Text += " - " + starterName
                Me.cbType.Text = "RCB"
            Else
                Me.Hide()
            End If

            'For Each s As startCbForm In starterSerial
            '    Debug.Print(s.starterName)
            'Next
        End If
    End Sub

    Private Sub Button_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Add.Click
        Button_Add.Enabled = False
        addnewcb()
    End Sub

    Private Sub addnewcb()
        Dim cbForm As New cbForm()

        cbForm.MdiParent = MainForm

        cbForm.preCb = Me
        Me.NextCb = cbForm
        'cbForm.Location = New Point(Me.Location.X, Me.Location.Y + 50)
        cbForm.Show()
    End Sub

    Private Sub Button_disable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_disable.Click
        compiledAble = False
        Button_enable.Enabled = True
        Button_disable.Enabled = False
    End Sub

    Private Sub Button_enable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_enable.Click
        compiledAble = True
        Button_enable.Enabled = False
        Button_disable.Enabled = True
    End Sub

    Private Sub startCbForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'no
    End Sub

    Private Sub Button_tpNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_tpNext.Click
        Try
            NextCb.Focus()
        Catch ex As Exception

        End Try
    End Sub

End Class