Public Class cbForm
    Public setForm As New setCbForm()
    Public NextCb As cbForm
    Public preCb As Form
    Public nameOfCb As String = ""
    Public loadFromFile As Boolean

    Private Sub cbForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If (loadFromFile = False) Then
            setForm.newCB = Me
            setForm.ShowDialog()
            If (setForm.canshow) Then
                Me.Text += " - " + nameOfCb
                Me.cbType.Text = "CCB"
            Else
                'CType(Me.preCb, startCbForm).NextCb = Nothing
                '检测form.tag鉴别了类型
                Select Case Me.preCb.Tag
                    Case "startCb"
                        CType(Me.preCb, startCbForm).NextCb = Nothing
                    Case "Cb"
                        CType(Me.preCb, cbForm).NextCb = Nothing
                End Select
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Button_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Add.Click
        Dim newCbForm As New cbForm()

        newCbForm.preCb = Me
        Me.NextCb = newCbForm

        newCbForm.MdiParent = MainForm
        'newCbForm.Location = New Point(Me.Location.X, Me.Location.Y + 50)
        newCbForm.Show()

        Button_Add.Enabled = False
    End Sub

    Private Sub Button_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Remove.Click
        Select Case Me.preCb.Tag
            Case "startCb"
                CType(Me.preCb, startCbForm).NextCb = Me.NextCb
                CType(Me.preCb, startCbForm).Button_Add.Enabled = True

                Me.Hide()
            Case "Cb"
                CType(Me.preCb, cbForm).NextCb = Me.NextCb
                CType(Me.preCb, cbForm).Button_Add.Enabled = True

                Me.Hide()
        End Select
    End Sub

    Public Function reCbCommand() As String
        Return TextBox_command.Text
    End Function

    Private Sub cbForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'no
    End Sub

    Private Sub Button_toNextCb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_toNextCb.Click
        Try
            NextCb.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_toPreCb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_toPreCb.Click
        preCb.Focus()
    End Sub
End Class