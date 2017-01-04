Public Class personaProveedor

    Inherits Persona

    Private loca As String
    Private tel As Integer
    Private direc As Double

    'Constructor
    Public Sub New(ByVal nombre As String, ByVal apellido As String, _
                   ByVal localidad As String, ByVal telefono As String, ByVal direccion As String)
        Me.nom = nombre
        Me.ape = apellido
        Me.loca = localidad
        Me.tel = telefono
        Me.direc = direccion
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
    Public Property direccion() As String
        Get
            Return direc
        End Get
        Set(ByVal value As String)
            direc = value
        End Set
    End Property

End Class
