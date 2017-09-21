Imports MySql.Data.MySqlClient

Module Reporte

    Dim command As New MySqlCommand()
    Dim dt As DataTable

#Region "Crear Reportes"

    'REPORTE INGRESOS-GASTOS
    Public Function generarRepIngGast(ByVal trimestre As String, ByVal año As Integer, Optional ByVal subir As Boolean = False)

        ' 1) Obtener Saldo Inicial y Saldo Final
        ' 2) Obtener Total Ingresos
        ' 3) Obtener Total Egresos
        ' 4) Generar la vista o Subir reporte


        Dim idSeccional As Integer = obtenerID("Seccionales", "nombre", "UDA Central", True)
        Dim idCentral As Integer = obtenerID("Seccionales", "nombre", "UDA Central")
        Dim saldoInicial As Decimal = 0.0
        Dim saldoFinal As Decimal = 0.0
        Dim ingresos As Decimal = 0.0
        Dim egresos As Decimal = 0.0
        Dim fecha As Date

        ' 1)
        Dim saldos() As Double = getSaldos(trimestre, año)
        saldoInicial = saldos(0)

        ' 2)
        ingresos = obtenerIngresos(trimestre, año)

        ' 3)
        egresos = obtenerEgresosTotales(trimestre, año, "full")

        ' 4)
        saldoFinal = ingresos - egresos

        '5)

        If subir = True Then

            Dim idTrimestreSQL As Integer = obtenerIDSQL("trimestres", "nombre", trimestre)
            Dim seccional As String = obtenerSeccional()
            Dim idSeccionalSQL = obtenerIDSQL("seccionales", "nombre", seccional)

            Select Case trimestre
                Case "Primero"
                    fecha = CDate("01/01/" & año)
                Case "Segundo"
                    fecha = CDate("01/04/" & año)
                Case "Tercero"
                    fecha = CDate("01/07/" & año)
                Case "Cuarto"
                    fecha = CDate("01/10/" & año)
            End Select

            Principal.query = "INSERT INTO reportes_trimestrales (" &
            "seccional_id, trimestre_id, fecha, saldo_inicial, ingresos, egresos, saldo_final)" &
            " VALUES (@sec, @trim, @fecha, @ini, @ing, @egre, @fin)"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@sec", idSeccionalSQL)
            command.Parameters.AddWithValue("@trim", idTrimestreSQL)
            command.Parameters.AddWithValue("@fecha", fecha)
            command.Parameters.AddWithValue("@ini", saldoInicial)
            command.Parameters.AddWithValue("@ing", ingresos)
            command.Parameters.AddWithValue("@egre", egresos)
            command.Parameters.AddWithValue("@fin", saldoFinal)

            consultarMySQL(Principal.query, command)

            Dim id As String = "SELECT id FROM reportes_trimestrales WHERE YEAR(fecha)='" & año &
            "' AND trimestre_id='" & idTrimestreSQL & "' AND seccional_id='" & idSeccionalSQL & "'"
            dt = consultarReaderSQL(id)

            Return (dt.Rows(0).Item("id"))

        Else
            Dim nuevo_reporte As New ReporteIngresoGasto
            nuevo_reporte.trimestre = trimestre
            nuevo_reporte.año = año
            nuevo_reporte.cargarGrid(saldoInicial, saldoFinal, ingresos, egresos)
            nuevo_reporte.Show()
            Return (Nothing)
        End If

    End Function
    'REPORTE INGRESOS
    Public Sub generarRepIngresos(ByVal trimestre As String, ByVal año As Integer, Optional ByVal subir As Boolean = False, Optional ByVal idReporteIngGast As Integer = 0)

        ' 1) Obtener los 3 Ingresos de cada mes del trimestre
        ' 2) Generar la vista o Subir reporte

        ' 1)
        Dim ingresos As DataTable = obtenerIngresos(trimestre, año, "meses")

        ' 2)
        If subir = True Then

            Dim totProv As Double = ingresos.Rows(0).Item("ingresos_prov") + ingresos.Rows(1).Item("ingresos_prov") + ingresos.Rows(2).Item("ingresos_prov")
            Dim cop As Double = totProv * 0.5

            Principal.query = "INSERT INTO reportes_ingresos (" &
            "reporte_trimestral_id, total_provincial, coparticipacion, total_general)" &
            " VALUES (@repT, @totP, @cop, @totG)"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@repT", idReporteIngGast)
            command.Parameters.AddWithValue("@totP", totProv)
            command.Parameters.AddWithValue("@cop", cop)
            command.Parameters.AddWithValue("@totG", obtenerIngresos(trimestre, año, "full"))

            consultarMySQL(Principal.query, command)

        Else

            Dim nuevo_reporte As New ReporteIngreso
            nuevo_reporte.trimestre = trimestre
            nuevo_reporte.año = año
            nuevo_reporte.cargarGrid(ingresos)
            nuevo_reporte.Show()
        End If

    End Sub
    'REPORTE EGRESOS SECCIONAL
    Public Sub generarRepEgreSec(ByVal trimestre As String, ByVal año As Integer, Optional ByVal subir As Boolean = False)

        ' 1) Obtener cantidad de Categorias de Gastos
        ' 2) Generar la vista o Subir reporte

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
    Public Sub generarRepEgreCen(ByVal trimestre As String, ByVal año As Integer, Optional ByVal subir As Boolean = False)

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

#Region "Subir Reporte"

    Public Function HayInternet() As Boolean

        If My.Computer.Network.IsAvailable() Then
            Try
                If My.Computer.Network.Ping("8.8.8.8") Then
                    Dim var As DataTable = consultarReaderSQL("SELECT * FROM reportes_trimestrales")
                    If TypeOf var Is Object = False Then
                        Return (False)
                    Else
                        Return (True)
                    End If
                Else
                    Return (False)
                End If
            Catch exint As Exception
                Return (False)
            End Try
        Else
            Return (False)
        End If

    End Function
    Public Function hayReporte(ByVal año As Integer, ByVal trimestre As String)

        Dim idTrimestre = obtenerIDSQL("trimestres", "nombre", trimestre)
        Dim seccional As String = obtenerSeccional()
        Dim idSeccional = obtenerIDSQL("seccionales", "nombre", seccional)

        Dim sql As String = "SELECT * FROM reportes_trimestrales WHERE YEAR(fecha)='" & año &
            "' AND trimestre_id='" & idTrimestre & "' AND seccional_id='" & idSeccional & "'"
        dt = consultarReaderSQL(sql)

        If dt.Rows.Count = 0 Then
            Return (False)
        Else
            Return (True)
        End If

    End Function
    Public Sub SubirReportes(ByVal trimestre As String, ByVal año As Integer)

        Dim sql As String = ""
        Dim id As DataTable

        'Subir reportes_trimestrales
        Dim idReporteIngGast = generarRepIngGast(trimestre, año, True)

        'Subir reportes_ingresos
        generarRepIngresos(trimestre, año, True, idReporteIngGast)

        'Subir reportes_ingresos_mensuales
        sql = "SELECT id FROM reportes_ingresos WHERE reporte_trimestral_id = '" & idReporteIngGast & "'"
        id = consultarReaderSQL(sql)
        Dim ingresos As DataTable = obtenerIngresos(trimestre, año, "meses")
        For i = 0 To ingresos.Rows.Count - 1
            Principal.query = "INSERT INTO reportes_ingresos_mensuales (" &
            "reporte_ingreso_id, mes, ingresos_provincial, ingresos_central, ingresos_otros)" &
            " VALUES (@rep, @mes, @IP, @IC, @IO)"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@rep", id.Rows(0).Item("id"))
            command.Parameters.AddWithValue("@mes", ingresos.Rows(i).Item("fecha"))
            command.Parameters.AddWithValue("@IP", ingresos.Rows(i).Item("ingresos_prov"))
            command.Parameters.AddWithValue("@IC", ingresos.Rows(i).Item("ingresos_central"))
            command.Parameters.AddWithValue("@IO", ingresos.Rows(i).Item("ingresos_otros"))
            consultarMySQL(Principal.query, command)
        Next

        'Subir reportes_egresos
        Dim totSec() As Double = obtenerEgresosTotales(trimestre, año, "seccional", obtenerSeccional())
        Dim totCen() As Double = obtenerEgresosTotales(trimestre, año, "seccional")
        Principal.query = "INSERT INTO reportes_egresos (" &
            "reporte_trimestral_id, total, total_central)" &
            " VALUES (@idrep, @total, @totalC)"
        command.Parameters.Clear()
        command.Parameters.AddWithValue("@idrep", idReporteIngGast)
        command.Parameters.AddWithValue("@total", totSec(0) + totSec(1) + totSec(2))
        command.Parameters.AddWithValue("@totalC", totCen(0) + totCen(1) + totCen(2))
        consultarMySQL(Principal.query, command)

        'Subir reportes_egresos_categorias
        sql = "SELECT id FROM reportes_egresos WHERE reporte_trimestral_id = '" & idReporteIngGast & "'"
        id = consultarReaderSQL(sql)
        sql = "SELECT id, nombre FROM CategoriasGastos"
        Dim cat As DataTable = consultarReader(sql)
        Dim catSec() As Double
        Dim catCen() As Double
        Dim idCen As Integer = obtenerID("Seccionales", "nombre", "UDA Central")
        Dim idSec As Integer = obtenerID("Seccionales", "nombre", "UDA Central", True)
        For i = 0 To cat.Rows.Count - 1
            If (LCase(cat.Rows(i).Item("nombre")) = "aplicables a coparticipacion") Then
                catSec = obtenerEgresosTotales(trimestre, año, "seccional", "UDA Central")
                catCen = {0, 0, 0}
            Else
                catSec = obtenerEgresosCategorias(trimestre, cat.Rows(i).Item("id"), año, idSec)
                catCen = obtenerEgresosCategorias(trimestre, cat.Rows(i).Item("id"), año, idCen)
            End If
            Principal.query = "INSERT INTO reportes_egresos_categorias (" &
            "reporte_egreso_id, categoria_gasto_id, total_mes_1, total_mes_2, total_mes_3," &
            " total_mes_1_central, total_mes_2_central, total_mes_3_central)" &
            " VALUES (@idrep, @idcat, @tot1, @tot2, @tot3, @tot1c, @tot2c, @tot3c)"
            command.Parameters.Clear()
            command.Parameters.AddWithValue("@idrep", idReporteIngGast)
            command.Parameters.AddWithValue("@idcat", cat.Rows(i).Item("id"))
            command.Parameters.AddWithValue("@tot1", catSec(0))
            command.Parameters.AddWithValue("@tot2", catSec(1))
            command.Parameters.AddWithValue("@tot3", catSec(2))
            command.Parameters.AddWithValue("@tot1c", catCen(0))
            command.Parameters.AddWithValue("@tot2c", catCen(1))
            command.Parameters.AddWithValue("@tot3c", catCen(2))
            consultarMySQL(Principal.query, command)
        Next


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
