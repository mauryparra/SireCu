Public Class reporteGeneral

    Inherits Reporte

    Private sI As Double
    Private sF As Double
    Private ing As Double
    Private egre As Double
    Private totG As Double

    'Constructor
    Public Sub New(ByVal seccional As String, ByVal año As Integer, ByVal trimestre As String, _
                   ByVal saldoInicial As Double, ByVal saldoFinal As Double, ByVal ingresos As Double,
                   ByVal egresos As Double, ByVal totGen As Double)
        Me.año = año
        Me.sec = seccional
        Me.trim = trimestre
        Me.sI = saldoInicial
        Me.sF = saldoFinal
        Me.ing = ingresos
        Me.egre = egresos
        Me.totG = totGen

    End Sub
    'Get & Set
    Public Property saldoInicial() As Double
        Get
            Return sI
        End Get
        Set(ByVal value As Double)
            sI = value
        End Set
    End Property
    Public Property saldoFinal() As Double
        Get
            Return sF
        End Get
        Set(ByVal value As Double)
            sF = value
        End Set
    End Property
    Public Property ingresos() As Double
        Get
            Return ing
        End Get
        Set(ByVal value As Double)
            ing = value
        End Set
    End Property
    Public Property egresos() As Double
        Get
            Return egre
        End Get
        Set(ByVal value As Double)
            egre = value
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
