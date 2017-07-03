Imports System.Data.SqlServerCe

Module Reporte

#Region "Crear Reportes"

    'REPORTE INGRESOS-GASTOS
    Public Sub generarRepIngGast(ByVal trimestre As String, ByVal año As Integer)

        ' 1) Obtener Saldo Inicial
        ' 2) Obtener total Ingresos
        ' 3) Obtener total Egresos
        ' 4) Obtener Saldo Final
        ' 5) Generar la vista


        Dim idSeccional As Integer = obtenerID("Seccionales", "nombre", "UDA Central", True)
        Dim idCentral As Integer = obtenerID("Seccionales", "nombre", "UDA Central")
        Dim saldoInicial As Decimal = 0.0
        Dim saldoFinal As Decimal = 0.0
        Dim ingresos As Decimal = 0.0
        Dim egresos As Decimal = 0.0

        ' 1)
        Select Case trimestre
            Case "Primero"
                saldoInicial = SaldoActual("Cuarto", (año - 1))
            Case "Segundo"
                saldoInicial = SaldoActual("Primero", año)
            Case "Tercero"
                saldoInicial = SaldoActual("Segundo", año)
            Case "Cuarto"
                saldoInicial = SaldoActual("Tercero", año)
        End Select

        ' 2)
        ingresos = obtenerIngresos(trimestre, año)

        ' 3)
        egresos = obtenerEgresosTotales(trimestre, año, "full")

        ' 4)
        saldoFinal = ingresos - egresos

        '5)
        Dim nuevo_reporte As New ReporteIngresoGasto
        nuevo_reporte.trimestre = trimestre
        nuevo_reporte.año = año
        nuevo_reporte.cargarGrid(saldoInicial, saldoFinal, ingresos, egresos)
        nuevo_reporte.Show()

    End Sub
    'REPORTE INGRESOS
    Public Sub generarRepIngresos(ByVal trimestre As String, ByVal año As Integer)

        ' 1) Obtener los 3 Ingresos de cada mes del trimestre
        ' 2) Generar la vista

        ' 1)
        Dim ingresos As DataTable = obtenerIngresos(trimestre, año, "meses")

        ' 2)
        Dim nuevo_reporte As New ReporteIngreso
        nuevo_reporte.trimestre = trimestre
        nuevo_reporte.año = año
        nuevo_reporte.cargarGrid(ingresos)
        nuevo_reporte.Show()
    End Sub
    'REPORTE EGRESOS SECCIONAL
    Public Sub generarRepEgreSec(ByVal trimestre As String, ByVal año As Integer)

        ' 1) Obtener cantidad de Categorias de Gastos
        ' 2) Generar la vista

        ' 1)
        Dim sql As String = "SELECT id, nombre FROM CategoriasGastos"
        Dim dt As DataTable = consultarReader(sql)

        ' 2)
        Dim nuevo_reporte As New ReporteEgresoSec
        nuevo_reporte.trimestre = trimestre
        nuevo_reporte.año = año
        nuevo_reporte.cargarGrid(dt)
        nuevo_reporte.Show()

    End Sub
    'REPORTE EGRESOS CENTRAL
    Public Sub generarRepEgreCen(ByVal trimestre As String, ByVal año As Integer)

        ' 1) Obtener cantidad de Categorias de Gastos
        ' 2) Generar la vista

        ' 1)
        Dim sql As String = "SELECT id, nombre FROM CategoriasGastos"
        Dim dt As DataTable = consultarReader(sql)

        ' 2)
        Dim nuevo_reporte As New ReporteEgresoCen
        nuevo_reporte.trimestre = trimestre
        nuevo_reporte.año = año
        nuevo_reporte.cargarGrid(dt)
        nuevo_reporte.Show()

    End Sub

#End Region

#Region "Helpers"

    Public Sub crearColumna(ByRef dgv As DataGridView, ByVal filtros As List(Of KeyValuePair(Of String, String)))

        For Each columna As KeyValuePair(Of String, String) In filtros
            If Not dgv.Columns.Contains(columna.Key) Then
                Dim column As New DataGridViewTextBoxColumn
                With column
                    .Name = columna.Key
                    .HeaderText = columna.Value
                    .DataPropertyName = columna.Value
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .DefaultCellStyle.Format = "C2"
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                dgv.Columns.Add(column)
            End If
        Next

    End Sub

#End Region

End Module
