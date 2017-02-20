Public Class Egreso

    Private nComp As String
    Private provee As String
    Private cGasto As String
    Private gasta As String
    Private fecha As DateTime
    Private tipComp As String
    Private uda As String
    Private reintegro As Integer
    Private mont As Double
    Private comen As String

    'Constructor
    Public Sub New(ByVal numComprobante As String, ByVal proveedor As String, ByVal catGasto As String, _
                   ByVal gastador As String, ByVal fechaEgreso As DateTime, ByVal tipoComprobante As String, _
                   ByVal uda As String, ByVal mesReintegro As Integer, ByVal monto As Double, ByVal comentario As String)
        Me.nComp = numComprobante
        Me.provee = proveedor
        Me.cGasto = catGasto
        Me.gasta = gastador
        Me.fecha = fechaEgreso
        Me.tipComp = tipocomprobante
        Me.uda = uda
        Me.reintegro = mesReintegro
        Me.mont = monto
        Me.comen = comentario

    End Sub
    'Get & Set
    Public Property numcomprobante() As String
        Get
            Return nComp
        End Get
        Set(ByVal value As String)
            nComp = value
        End Set
    End Property
    Public Property proveedor() As String
        Get
            Return provee
        End Get
        Set(ByVal value As String)
            provee = value
        End Set
    End Property
    Public Property catGasto() As String
        Get
            Return cGasto
        End Get
        Set(ByVal value As String)
            cGasto = value
        End Set
    End Property
    Public Property gastador() As String
        Get
            Return gasta
        End Get
        Set(ByVal value As String)
            gasta = value
        End Set
    End Property
    Public Property fechaEgreso() As DateTime
        Get
            Return fecha
        End Get
        Set(ByVal value As DateTime)
            fecha = value
        End Set
    End Property
    Public Property tipoComprobante() As String
        Get
            Return tipComp
        End Get
        Set(ByVal value As String)
            tipComp = value
        End Set
    End Property
    Public Property seccionalUDA() As String
        Get
            Return uda
        End Get
        Set(ByVal value As String)
            uda = value
        End Set
    End Property
    Public Property mesReintegro() As Integer
        Get
            Return reintegro
        End Get
        Set(ByVal value As Integer)
            reintegro = value
        End Set
    End Property
    Public Property monto() As Double
        Get
            Return mont
        End Get
        Set(ByVal value As Double)
            mont = value
        End Set
    End Property
    Public Property comentario() As String
        Get
            Return comen
        End Get
        Set(ByVal value As String)
            comen = value
        End Set
    End Property

    Public Sub cargar_egreso()

    End Sub

    Public Sub modificar_egreso()

    End Sub

    Public Sub eliminar_egreso()

    End Sub

    Public Sub filtrar_datos()

    End Sub

End Class
