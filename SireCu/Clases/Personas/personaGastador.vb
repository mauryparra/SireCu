Public Class personaGastador

    Inherits Persona

    Private loca As String
    Private tel As Integer
    Private gastado As Double

    'Constructor
    Public Sub New(ByVal nombre As String, ByVal apellido As String, _
                   ByVal localidad As String, ByVal telefono As String, ByVal totalGastado As Double)
        Me.nom = nombre
        Me.ape = apellido
        Me.loca = localidad
        Me.tel = telefono
        Me.gastado = totalGastado
    End Sub
    'Get & Set
    Public Property localidad() As String
        Get
            Return loca
        End Get
        Set(ByVal value As String)
            loca = value
        End Set
    End Property
    Public Property telefono() As String
        Get
            Return tel
        End Get
        Set(ByVal value As String)
            tel = value
        End Set
    End Property
    Public Property totalGastado() As String
        Get
            Return gastado
        End Get
        Set(ByVal value As String)
            gastado = value
        End Set
    End Property

    Public Sub total_gastado()

    End Sub

End Class
