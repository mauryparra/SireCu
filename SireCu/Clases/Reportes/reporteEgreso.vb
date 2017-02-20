Public Class reporteEgreso

    Inherits Reporte

    Private gDesen As Double
    Private gAdmin As Double
    Private gLib As Double
    Private gPren As Double
    Private gAlq As Double
    Private gFranq As Double
    Private gImp As Double
    Private gSeg As Double
    Private gBanc As Double
    Private gHono As Double
    Private gMovi As Double
    Private gSubsi As Double
    Private gPresta As Double
    Private gFili As Double
    Private gCopa As Double
    Private gACopa As Double

    'Constructor
    Public Sub New(ByVal seccional As String, ByVal año As Integer, ByVal trimestre As String, _
                   ByVal gDesenvolvimiento As Double, _
                   ByVal gAdministrativos As Double, ByVal gLibreria As Double, ByVal gPrensa As Double, _
                   ByVal gAlquileres As Double, ByVal gFranqueo As Double, ByVal gImpuestos As Double, _
                   ByRef gSeguros As Double, ByVal gBanco As Double, ByVal gHonorario As Double, _
                   ByVal gMovilidad As Double, ByVal gSubsidio As Double, ByVal gPyS As Double, _
                   ByVal gFiliales As Double, ByVal gCoparti As Double, ByVal gApliCopart As Double)

        Me.sec = seccional
        Me.año = año
        Me.trim = trimestre
        Me.gDesen = gDesenvolvimiento
        Me.gAdmin = gAdministrativos
        Me.gLib = gLibreria
        Me.gPren = gPrensa
        Me.gAlq = gAlquileres
        Me.gFranq = gFranqueo
        Me.gImp = gImpuestos
        Me.gSeg = gSeguros
        Me.gBanc = gBanco
        Me.gHono = gHonorario
        Me.gMovi = gMovilidad
        Me.gSubsi = gSubsidio
        Me.gPresta = gPyS
        Me.gFili = gFiliales
        Me.gCopa = gCoparti
        Me.gACopa = gACopa
    End Sub
    'Get & Set
    
    Public Property gDesenvolvimiento() As Double
        Get
            Return gDesen
        End Get
        Set(ByVal value As Double)
            gDesen = value
        End Set
    End Property
    Public Property gAdministrativo() As Double
        Get
            Return gAdmin
        End Get
        Set(ByVal value As Double)
            gAdmin = value
        End Set
    End Property
    Public Property gLibreria() As Double
        Get
            Return gLib
        End Get
        Set(ByVal value As Double)
            gLib = value
        End Set
    End Property
    Public Property gPrensa() As Double
        Get
            Return gPren
        End Get
        Set(ByVal value As Double)
            gPren = value
        End Set
    End Property
    Public Property gAlquiler() As Double
        Get
            Return gAlq
        End Get
        Set(ByVal value As Double)
            gAlq = value
        End Set
    End Property
    Public Property gFranqueo() As Double
        Get
            Return gFranq
        End Get
        Set(ByVal value As Double)
            gFranq = value
        End Set
    End Property
    Public Property gImpuesto() As Double
        Get
            Return gImp
        End Get
        Set(ByVal value As Double)
            gImp = value
        End Set
    End Property
    Public Property gSeguro() As Double
        Get
            Return gSeg
        End Get
        Set(ByVal value As Double)
            gSeg = value
        End Set
    End Property
    Public Property gBanco() As Double
        Get
            Return gBanc
        End Get
        Set(ByVal value As Double)
            gBanc = value
        End Set
    End Property
    Public Property gHonorario() As Double
        Get
            Return gHono
        End Get
        Set(ByVal value As Double)
            gHono = value
        End Set
    End Property
    Public Property gMovilidad() As Double
        Get
            Return gMovi
        End Get
        Set(ByVal value As Double)
            gMovi = value
        End Set
    End Property
    Public Property gSubsidio() As Double
        Get
            Return gSubsi
        End Get
        Set(ByVal value As Double)
            gSubsi = value
        End Set
    End Property
    Public Property gPyS() As Double
        Get
            Return gPresta
        End Get
        Set(ByVal value As Double)
            gPresta = value
        End Set
    End Property
    Public Property gFilial() As Double
        Get
            Return gFili
        End Get
        Set(ByVal value As Double)
            gFili = value
        End Set
    End Property
    Public Property gCoparticipacion() As Double
        Get
            Return gCopa
        End Get
        Set(ByVal value As Double)
            gCopa = value
        End Set
    End Property
    Public Property gACoparticipacion() As Double
        Get
            Return gACopa
        End Get
        Set(ByVal value As Double)
            gACopa = value
        End Set
    End Property

End Class
