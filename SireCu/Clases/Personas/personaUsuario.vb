Public Class personaUsuario

    Inherits Persona

    Protected acc As String
    Protected pass As String
    Protected mail As String

    'Get & Set
    Public Property cuenta() As String
        Get
            Return acc
        End Get
        Set(ByVal value As String)
            acc = value
        End Set
    End Property
    Public Property password() As String
        Get
            Return pass
        End Get
        Set(ByVal value As String)
            pass = value
        End Set
    End Property
    Public Property email() As String
        Get
            Return mail
        End Get
        Set(ByVal value As String)
            mail = value
        End Set
    End Property


End Class
