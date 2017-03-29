Imports System.Data.SqlServerCe

Public Class Principal

    Public dataset As New DataSet
    Public command As New SqlCeCommand()
    Public tableadapters As New Dictionary(Of String, SqlCeDataAdapter)
    Public query As String

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub RadioButtonIngresos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonIngresos.CheckedChanged
        AdminPantallas("ABMIngresos")
    End Sub
    Private Sub RadioButtonEgresos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEgresos.CheckedChanged
        AdminPantallas("ABMEgresos")
    End Sub

    Private Sub AdminPantallas(ByVal pantalla As String)
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
                Case Else
                    MessageBox.Show("Error del administrador de pantallas")

            End Select

        End If

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargar Tablas en Dataset
        cargarTablaEnDataSet("Ingresos")
        cargarTablaEnDataSet("Egresos")
        cargarTablaEnDataSet("Proveedores")
        cargarTablaEnDataSet("Personas")
        cargarTablaEnDataSet("CategoriasGastos")
        cargarTablaEnDataSet("TiposComprobantes")
        cargarTablaEnDataSet("Seccionales")

    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Otros_AMB.cb_tabla.Text = "Proveedor"
        Otros_AMB.ShowDialog()
    End Sub

    Private Sub TiposDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeGastosToolStripMenuItem.Click
        Otros_AMB.cb_tabla.Text = "Tipo de Comprobante"
        Otros_AMB.ShowDialog()
    End Sub

    Private Sub CategoríasDeGastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoríasDeGastosToolStripMenuItem.Click
        Otros_AMB.cb_tabla.Text = "Tipo de Gasto"
        Otros_AMB.ShowDialog()
    End Sub

    Private Sub PersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonasToolStripMenuItem.Click
        Otros_AMB.cb_tabla.Text = "Persona"
        Otros_AMB.ShowDialog()
    End Sub

    Private Sub SeccionalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeccionalesToolStripMenuItem.Click
        Otros_AMB.cb_tabla.Text = "Seccional"
        Otros_AMB.ShowDialog()
    End Sub
End Class
