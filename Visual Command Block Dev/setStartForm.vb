Public Class setStartForm
    Public newStarterCB As startCbForm '表示要设置的starterForm
    Public canshow As Boolean '表示是否处理成功

    Private Sub setStarterBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setStarterBtn.Click
        setStarter()
    End Sub

    Public Sub setStarter()
        If (text_starterName.Text = "") Then
            MsgBox("The name cannot be empty!", MsgBoxStyle.Information, "Warning")
        Else
            '向starter集合中添加starter
            Dim serialV(UBound(starterSerial) + 1) As startCbForm
            Dim f As Integer = 0
            For f = 0 To UBound(starterSerial)
                serialV(f) = starterSerial(f)
            Next
            serialV(UBound(starterSerial) + 1) = newStarterCB
            newStarterCB.num = UBound(starterSerial) + 1
            starterSerial = serialV

            newStarterCB.starterName = text_starterName.Text

            canshow = True
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub text_starterName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles text_starterName.KeyDown
        If (e.KeyCode = 13) Then
            setStarter()
        End If
    End Sub
End Class