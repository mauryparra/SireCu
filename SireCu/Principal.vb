Imports System.Data.SqlServerCe

Public Class Principal

    Public dataset As New DataSet
    Public command As New SqlCeCommand()
    Public tableadapters As New Dictionary(Of String, SqlCeDataAdapter)
    Public query As String
    Public userLogueado As String


#Region "Botones Panel"

    Private Sub btn_Ingresos_Click(sender As Object, e As EventArgs) Handles btn_Ingresos.Click
        AdminPantallas("ABMIngresos")
    End Sub
    Private Sub btn_Egresos_Click(sender As Object, e As EventArgs) Handles btn_Egresos.Click
        AdminPantallas("ABMEgresos")
    End Sub
    Private Sub btn_Administrar_Click(sender As Object, e As EventArgs) Handles btn_Administrar.Click
        AdminPantallas("ABMAdmin")
    End Sub
    Private Sub btn_VerReporte_Click(sender As Object, e As EventArgs) Handles btn_VerReporte.Click
        AdminPantallas("VerReporte")
    End Sub
    Private Sub bttn_Login_Click(sender As Object, e As EventArgs) Handles bttn_Login.Click
        If bttn_Login.Text = "Login" Then
            AdminPantallas("Login")
        Else
            desloguear()
        End If
    End Sub

#End Region

#Region "Botones Menú"

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub SeccionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeccionalToolStripMenuItem.Click
        Config.ShowDialog()
    End Sub
    Private Sub EliminarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarUsuariosToolStripMenuItem.Click
        AdminPantallas("Usuarios")
    End Sub
    Private Sub CerrarTrimestreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTrimestreToolStripMenuItem.Click
        AdminPantallas("CerrarTrimestre")
    End Sub

#End Region

#Region "Helpers"

    Public Sub AdminPantallas(ByVal pantalla As String)
        Dim bandera As Boolean = False

        ' Si la pantalla no se encuentra cargada, la hace visible
        For Each ctrl As Control In SplitContainerPrincipal.Panel2.Controls
            If pantalla = ctrl.Name Then
                ctrl.Show()
                bandera = True
            Else
                ctrl.Hide()
                bandera = False
            End If
        Next

        If bandera = False Then
            Select Case pantalla
                Case "ABMIngresos"
                    Dim pantallaABMIngresos As ABMIngresos = New ABMIngresos()
                    pantallaABMIngresos.Dock = DockStyle.Fill
                    SplitContainerPrincipal.Panel2.Controls.Add(pantallaABMIngresos)
                Case "ABMEgresos"
                    Dim pantallaABMEgresos As ABMEgresos = New ABMEgresos()
                    pantallaABMEgresos.Dock = DockStyle.Fill
                    SplitContainerPrincipal.Panel2.Controls.Add(pantallaABMEgresos)
                Case "ABMAdmin"
                    Dim pantallaABMAdmin As ABMAdmin = New ABMAdmin()
                    pantallaABMAdmin.Dock = DockStyle.Fill
                    SplitContainerPrincipal.Panel2.Controls.Add(pantallaABMAdmin)
                Case "VerReporte"
                    Dim pantallaVerReporte As VerReporte = New VerReporte()
                    pantallaVerReporte.Dock = DockStyle.Fill
                    SplitContainerPrincipal.Panel2.Controls.Add(pantallaVerReporte)
                Case "Login"
                    Dim pantallaLogin As Login = New Login()
                    pantallaLogin.Dock = DockStyle.Fill
                    SplitContainerPrincipal.Panel2.Controls.Add(pantallaLogin)
                Case "Home"
                    Dim pantallaHome As Home = New Home()
                    pantallaHome.Dock = DockStyle.Fill
                    SplitContainerPrincipal.Panel2.Controls.Add(pantallaHome)
                Case "Usuarios"
                    Dim pantallaABMUsuarios As ABMUsuarios = New ABMUsuarios()
                    pantallaABMUsuarios.Dock = DockStyle.Fill
                    SplitContainerPrincipal.Panel2.Controls.Add(pantallaABMUsuarios)
                Case "CerrarTrimestre"
                    Dim pantallaCerrarTrimestre As CerrarTrimestre = New CerrarTrimestre()
                    pantallaCerrarTrimestre.Dock = DockStyle.Fill
                    SplitContainerPrincipal.Panel2.Controls.Add(pantallaCerrarTrimestre)
                Case Else
                    MessageBox.Show("Error del administrador de pantallas")

            End Select

        End If

    End Sub
    Private Sub desloguear()

        ' Limpiamos todas las pantallas
        SplitContainerPrincipal.Panel2.Controls.Clear()

        btn_Ingresos.Enabled = False
        btn_Egresos.Enabled = False
        btn_Administrar.Enabled = False
        btn_VerReporte.Enabled = False

        ArchivoToolStripMenuItem.Enabled = False
        EditarToolStripMenuItem.Enabled = False
        UsuariosToolStripMenuItem.Enabled = False

        TStripLabelSaldo.Text = ""
        stat_Label.Text = "Desconectado"
        bttn_Login.Text = "Login"

        userLogueado = ""

        AdminPantallas("Home")

    End Sub

#End Region

#Region "Eventos"

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Verificamos si se ingreso la Seccional
        While (obtenerSeccional() = "")
            Config.ShowDialog()
        End While

        'Cargar Tablas en Dataset
        cargarTablaEnDataSet("Ingresos")
        cargarTablaEnDataSet("Egresos")
        cargarTablaEnDataSet("Proveedores")
        cargarTablaEnDataSet("Personas")
        cargarTablaEnDataSet("CategoriasGastos")
        cargarTablaEnDataSet("TiposComprobantes")
        cargarTablaEnDataSet("Seccionales")

        AdminPantallas("Home")

    End Sub

#End Region

End Class
