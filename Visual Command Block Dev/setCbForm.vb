Public Class setCbForm
    Public newCB As cbForm
    Public canshow As Boolean

    Private Sub setCbBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setCbBtn.Click
        setCb()
    End Sub

    Private Sub setCb()
        If (text_CbName.Text = "") Then
            MsgBox("The name cannot be empty!", MsgBoxStyle.Information, "Warning")
        Else
            newCB.nameOfCb = text_CbName.Text
            canshow = True
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        canshow = False
        Me.Close()
    End Sub

    Private Sub text_CbName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles text_CbName.KeyDown
        If (e.KeyCode = 13) Then
            setCb()
        End If
    End Sub

End Class