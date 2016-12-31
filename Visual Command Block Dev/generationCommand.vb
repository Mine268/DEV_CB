Public Class generationCommand

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (rtb_command.Text = "") Then
            'nothing
        Else
            Clipboard.SetText(rtb_command.Text.ToString)
        End If
    End Sub

    Private Sub generationCommand_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        rtb_command.Text = theCommand.ToString
    End Sub
End Class