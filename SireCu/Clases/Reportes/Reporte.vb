Public Class Reporte

    Protected sec As String
    Protected trim As String
    Protected año As Integer

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

    Public Sub subir()

    End Sub

    Public Sub descargar()

    End Sub

    Public Sub generar()

    End Sub

End Class
