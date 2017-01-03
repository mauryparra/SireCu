Public Class reporteEgreso

    Inherits Reporte

    Private mes As String
    Private uda As String
    Private iLR As Double
    Private iO As Double
    Private cop As Double
    Private totP As Double
    Private totG As Double

    'Constructor
    Public Sub New(ByVal mesReporte As String, ByVal ingCent As Double, ByVal ingLaRioja As Double,
                   ByVal ingOtros As Double, ByVal copart As Double, ByVal totProv As Double, ByVal totGen As Double)
        Me.mes = mesReporte
        Me.iC = ingCent
        Me.iLR = ingLaRioja
        Me.iO = ingOtros
        Me.cop = copart
        Me.totP = totProv
        Me.totG = totGen

    End Sub
    'Get & Set
    Public Property mesReporte() As String
        Get
            Return mes
        End Get
        Set(ByVal value As String)
            mes = value
        End Set
    End Property
    Public Property ingCent() As Double
        Get
            Return iC
        End Get
        Set(ByVal value As Double)
            iC = value
        End Set
    End Property
    Public Property ingLaRioja() As Double
        Get
            Return iLR
        End Get
        Set(ByVal value As Double)
            iLR = value
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
    Public Property copart() As Double
        Get
            Return cop
        End Get
        Set(ByVal value As Double)
            cop = value
        End Set
    End Property
    Public Property totProv() As Double
        Get
            Return totP
        End Get
        Set(ByVal value As Double)
            totP = value
        End Set
    End Property
    Public Property totGen() As Double
        Get
            Return totG
        End Get
        Set(ByVal value As Double)
            totG = value
        End Set
    End Property

End Class
