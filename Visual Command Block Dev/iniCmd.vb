Public Class iniCmd
    Public clicked As Boolean

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (clicked) Then
            init = rtb_ini.Text.ToString
        End If
        Me.Hide()
    End Sub

    Private Sub rtb_ini_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rtb_ini.KeyDown
        If (clicked = False) Then
            clicked = True
            rtb_ini.Text = ""
            rtb_ini.ForeColor = Color.Black
        End If
    End Sub
End Class