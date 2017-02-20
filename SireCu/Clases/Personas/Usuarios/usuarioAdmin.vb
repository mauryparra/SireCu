Public Class usuarioAdmin

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

End Class
