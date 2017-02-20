Public Class Persona

    Protected nom As String
    Protected ape As String

    'Get & Set
    Public Property nombre() As String
        Get
            Return nom
        End Get
        Set(ByVal value As String)
            nom = value
        End Set
    End Property
    Public Property apellido() As String
        Get
            Return ape
        End Get
        Set(ByVal value As String)
            ape = value
        End Set
    End Property

End Class
