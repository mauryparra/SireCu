Public Class Reporte

    Private sec As String
    Private trim As String
    Private año As Integer

    'Get & Set
    Public Property seccional() As String
        Get
            Return sec
        End Get
        Set(ByVal value As String)
            sec = value
        End Set
    End Property
    Public Property trimestre() As String
        Get
            Return trim
        End Get
        Set(ByVal value As String)
            trim = value
        End Set
    End Property
    Public Property añoReporte() As Integer
        Get
            Return año
        End Get
        Set(ByVal value As Integer)
            año = value
        End Set
    End Property

End Class
