Public Class Ingreso

    Private fecha As DateTime
    Private iP As Double
    Private iO As Double

    'Constructor
    Public Sub New(ByVal fechaIng As DateTime, ByVal ingProv As Double, ByVal ingOtros As Double)
        Me.fecha = fechaIng
        Me.iP = ingProv
        Me.iO = ingOtros
    End Sub
    'Get & Set
    Public Property fechaIng() As DateTime
        Get
            Return fecha
        End Get
        Set(ByVal value As DateTime)
            fecha = value
        End Set
    End Property
    Public Property ingProv() As Double
        Get
            Return iP
        End Get
        Set(ByVal value As Double)
            iP = value
        End Set
    End Property
    Public Property ingOtros() As Double
        Get
            Return iO
        End Get
        Set(ByVal value As Double)
            iO = value
        End Set
    End Property

    Public Sub cargar_ingreso()

    End Sub

    Public Sub modificar_ingreso()

    End Sub

    Public Sub filtrar_datos()

    End Sub

End Class
