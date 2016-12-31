Module Module_1
    Public starterSerial() As startCbForm = {}

    Public commands As String = ""

    Public theCommand As String = "" 'ooc
    Public oocNbt As String = "" 'ooc的生成块

    Public init As String = "" 'init

    Public Function encode(ByVal strIn As String)
        Dim code As String = ""
        Dim i As Integer = strIn.Length, f As Integer

        For f = 0 To i - 1 Step 1
            code += CStr(Asc(strIn.Substring(f, 1))) + "|"
        Next

        Return code
    End Function

    Public Function boolToStr(ByVal str As String) As Boolean
        Select Case str
            Case "True"
                Return True
            Case "False"
                Return False
        End Select
    End Function
End Module
