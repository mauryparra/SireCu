Module Usuario

    Public Function verificarUsuario(ByVal user As String, ByVal pass As String)

        Dim sql As String = "SELECT * FROM Usuarios WHERE usuario = '" & user & "'"
        Dim dt As DataTable = consultarReader(sql)

        If dt.Rows.Count = 0 Then
            Return False
        ElseIf dt.Rows(0).Item("contraseña") = pass Then
            Return True
        Else Return False
        End If

    End Function

    Public Function tipoDeUsuario(ByVal user As String)

        Dim sql As String = "SELECT * FROM Usuarios WHERE usuario = '" & user & "'"
        Dim dt As DataTable = consultarReader(sql)

        Return (dt.Rows(0).Item("rol"))

    End Function

End Module
