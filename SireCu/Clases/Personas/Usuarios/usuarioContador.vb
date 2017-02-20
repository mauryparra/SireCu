Public Class usuarioContador

    Inherits personaUsuario

    'Constructor
    Public Sub New(ByVal nombre As String, ByVal apellido As String, _
                   ByVal cuenta As String, ByVal password As String, ByVal email As String)
        Me.nom = nombre
        Me.ape = apellido
        Me.acc = cuenta
        Me.pass = password
        Me.mail = email
    End Sub

    Public Sub crear_cuenta()

    End Sub

    Public Sub modificar_cuenta()

    End Sub

    Public Sub eliminar_cuenta()

    End Sub

End Class
