Imports System.Data.SqlServerCe

Module Reporte

    'Panel VerReporte
    Public Sub CargarReportes(ByRef dgv As DataGridView, ByVal sql As String, Optional ByVal nombreDataSet As String = "Reportes")

        'Creamos la tabla si no existe
        If Not Principal.dataset.Tables.Contains(nombreDataSet) Then
            Principal.dataset.Tables.Add(nombreDataSet)
        End If
        'Limpiamos la tabla
        Principal.dataset.Tables(nombreDataSet).Clear()

        'Creamos el query
        Principal.command.CommandText = sql

        'Creamos el TableAdapter si no existe
        If Not Principal.tableadapters.ContainsKey(nombreDataSet) Then
            Principal.tableadapters.Add(nombreDataSet, New SqlCeDataAdapter(Principal.command))
        End If

        'Actualizamos el contenido de la tabla
        Principal.tableadapters(nombreDataSet).Fill(Principal.dataset.Tables.Item(nombreDataSet))

        'Asignamos el Bind
        Dim mybinding = New BindingSource(Principal.dataset, nombreDataSet)

        dgv.DataSource = mybinding

        columnasVerReporte(dgv)

        dgv.Columns("id").Visible = False

    End Sub
    Private Sub columnasVerReporte(ByRef dgv As DataGridView)
        Dim i As Integer = 0
        Dim array = New String() {"Ingresos - Gastos", "Ingresos", "Egresos Seccional", "Egresos Central"}

        Do
            If Not dgv.Columns.Contains(array(i)) Then
                Dim column As New DataGridViewButtonColumn
                With column
                    .Name = array(i)
                    .HeaderText = array(i)
                    .Text = "Ver Reporte"
                    .DataPropertyName = array(i)
                    .UseColumnTextForButtonValue = True
                End With
                dgv.Columns.Add(column)
            End If
            i = i + 1
        Loop While i <= 3

    End Sub

    'Helpers
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
    Public Function existReporte(ByVal año As Integer, ByVal trim As Integer)

        cargarTablaEnDataSet("ReportesTrimestrales")
        Dim flag As String = False

        For i = 0 To Principal.dataset.Tables("ReportesTrimestrales").Rows.Count - 1
            If (Principal.dataset.Tables("ReportesTrimestrales").Rows.Item(i).Item("año") = año) And
               (Principal.dataset.Tables("ReportesTrimestrales").Rows.Item(i).Item("trimestre_id") = trim) Then
                flag = Principal.dataset.Tables("ReportesTrimestrales").Rows.Item(i).Item("id")
            End If
        Next

        Return flag

    End Function

    'Crear Reportes
    Public Sub CrearRepTrimestral(ByVal trimestre As Integer, ByVal año As Integer, Optional ByVal blanco As Boolean = False)

        Dim idSeccional As Integer = obtenerID("Seccionales", "nombre", "UDA Central", True)

        'Completamos reporte en Blanco
        If blanco Then
            Principal.query = "INSERT INTO ReportesTrimestrales 
                                           (seccional_id, trimestre_id, año, saldo_inicial, 
                                            ingresos, egresos, saldo_final) 
                                            VALUES 
                                            (" & idSeccional & "," & trimestre & "," & año & ",
                                             0,0,0,0)"
            consultarNQ(Principal.query, Principal.command)

            'Modificamos reporte en blanco existente
        Else

        End If


    End Sub
    Public Sub CrearRepEgreso(ByVal trimestre As String, ByVal año As Integer, ByVal seccional As Integer, ByVal central As Integer)

        Dim idTrimestre As Integer = obtenerID("Trimestres", "nombre", trimestre)
        Dim idReporteTrimestral = existReporte(año, idTrimestre)
        Dim sqlTotEgresoSec As String = ""
        Dim sqlTotEgresoCen As String = ""

        Select Case trimestre
            Case "Primero"
                sqlTotEgresoSec = "SELECT SUM(monto) FROM Egresos 
                   WHERE seccional_id = " & seccional &
                   " AND ((DATEPART(Month, [fecha]) BETWEEN 1 And 3 AND DATEPART(year, [fecha]) = " & año & ")
                    OR (DATEPART(Month, [mes_reintegro]) BETWEEN 1 And 3 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
                sqlTotEgresoCen = "SELECT SUM(monto) FROM Egresos 
                   WHERE seccional_id = " & central &
                   " AND ((DATEPART(Month, [fecha]) BETWEEN 1 And 3 AND DATEPART(year, [fecha]) = " & año & ")
                    OR (DATEPART(Month, [mes_reintegro]) BETWEEN 1 And 3 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
            Case "Segundo"
                sqlTotEgresoSec = "SELECT SUM(monto) FROM Egresos 
                   WHERE seccional_id = " & seccional &
                   " AND ((DATEPART(Month, [fecha]) BETWEEN 4 And 6 AND DATEPART(year, [fecha]) = " & año & ")
                    OR (DATEPART(Month, [mes_reintegro]) BETWEEN 4 And 6 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
                sqlTotEgresoCen = "SELECT SUM(monto) FROM Egresos 
                   WHERE seccional_id = " & central &
                   " AND ((DATEPART(Month, [fecha]) BETWEEN 4 And 6 AND DATEPART(year, [fecha]) = " & año & ")
                    OR (DATEPART(Month, [mes_reintegro]) BETWEEN 4 And 6 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
            Case "Tercero"
                sqlTotEgresoSec = "SELECT SUM(monto) FROM Egresos 
                   WHERE seccional_id = " & seccional &
                   " AND ((DATEPART(Month, [fecha]) BETWEEN 7 And 7 AND DATEPART(year, [fecha]) = " & año & ")
                    OR (DATEPART(Month, [mes_reintegro]) BETWEEN 7 And 9 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
                sqlTotEgresoCen = "SELECT SUM(monto) FROM Egresos 
                   WHERE seccional_id = " & central &
                   " AND ((DATEPART(Month, [fecha]) BETWEEN 7 And 9 AND DATEPART(year, [fecha]) = " & año & ")
                    OR (DATEPART(Month, [mes_reintegro]) BETWEEN 7 And 9 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
            Case "Cuarto"
                sqlTotEgresoSec = "SELECT SUM(monto) FROM Egresos 
                   WHERE seccional_id = " & seccional &
                   " AND ((DATEPART(Month, [fecha]) BETWEEN 10 And 12 AND DATEPART(year, [fecha]) = " & año & ")
                    OR (DATEPART(Month, [mes_reintegro]) BETWEEN 10 And 12 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
                sqlTotEgresoCen = "SELECT SUM(monto) FROM Egresos 
                   WHERE seccional_id = " & central &
                   " AND ((DATEPART(Month, [fecha]) BETWEEN 10 And 12 AND DATEPART(year, [fecha]) = " & año & ")
                    OR (DATEPART(Month, [mes_reintegro]) BETWEEN 10 And 12 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
        End Select

        Dim resultadoConsulta = consultarES(sqlTotEgresoSec, Principal.command)
        Dim totalEgresoSec As Double = IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta)
        resultadoConsulta = consultarES(sqlTotEgresoCen, Principal.command)
        Dim totalEgresoCen As Double = IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta)

        'Reporte Egreso Seccional
        Principal.query = "INSERT INTO ReportesEgresos 
                                           (reporte_trimestre_id, seccional_id, total) 
                                            VALUES 
                                            (" & idReporteTrimestral & "," & seccional & "," & totalEgresoSec & ")"
        consultarNQ(Principal.query, Principal.command)
        'Reporte Egreso Central
        Principal.query = "INSERT INTO ReportesEgresos 
                                           (reporte_trimestre_id, seccional_id, total) 
                                            VALUES 
                                            (" & idReporteTrimestral & "," & central & "," & totalEgresoCen & ")"
        consultarNQ(Principal.query, Principal.command)

    End Sub

    'TODO
    Public Sub ActualizarTablasdeReporte()

    End Sub
    Public Sub CrearRepEgresoMensual(ByVal trimestre As Integer, ByVal año As Integer)



    End Sub
    Public Sub CrearRepIngresos(ByVal trimestre As String, ByVal año As Integer)

        'Consultamos los ingresos en el período ingresado
        'TODO Agregar Reintegro
        'TODO ExistReporte necesita valor integer, no string
        Dim sql As String = ""
        Dim sqlCop As String = ""
        Select Case trimestre
            Case "Primero"
                sql = "SELECT ingresos_prov, ingresos_central, ingresos_otros 
                             FROM [Ingresos]
                             WHERE DATEPART(Month, [fecha]) BETWEEN 1 And 3 And DATEPART(year, [fecha]) = " & año
                sqlCop = "SELECT SUM(monto) FROM Egresos 
                            WHERE seccional_id = " & obtenerID("Seccionales", "nombre", "UDA Central") &
                            " AND DATEPART(Month, [fecha]) BETWEEN 1 And 3 And DATEPART(year, [fecha]) = " & año
            Case "Segundo"
                sql = "SELECT ingresos_prov, ingresos_central, ingresos_otros
                             FROM [Ingresos]
                             WHERE DATEPART(Month, [fecha]) BETWEEN 4 And 6 And DATEPART(year, [fecha]) = " & año
            Case "Tercero"
                sql = "SELECT ingresos_prov, ingresos_central, ingresos_otros
                             FROM [Ingresos]
                             WHERE DATEPART(Month, [fecha]) BETWEEN 7 And 9 And DATEPART(year, [fecha]) = " & año
            Case "Cuarto"
                sql = "SELECT ingresos_prov, ingresos_central, ingresos_otros
                             FROM [Ingresos]
                             WHERE DATEPART(Month, [fecha]) BETWEEN 10 And 12 And DATEPART(year, [fecha]) = " & año
        End Select
        Dim dt As DataTable = consultarReader(sql)
        Dim totalProv As Double = 0.0
        Dim totalGeneral As Double = 0.0
        For i = 0 To dt.Rows.Count - 1
            totalProv = totalProv + dt.Rows(i).Item("ingresos_prov")
            totalGeneral = totalGeneral + (dt.Rows(i).Item("ingresos_prov") +
                dt.Rows(0).Item("ingresos_central") + dt.Rows(0).Item("ingresos_otros"))
        Next

        'Consultamos el total de coparticipacion
        Dim resultadoConsulta = consultarES(sql, Principal.command)
        Dim totalCopart = IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta)


        'Obtenemos el id del reporte_trimestral asociado y guardamos
        Dim idReporteTrimestral = existReporte(año, trimestre)
        Principal.query = "INSERT INTO ReportesIngresos (
                            reporte_trimestre_id, total_provincial, coparticipacion, total_general)
                           VALUES (" & idReporteTrimestral & ""
        consultarNQ(Principal.query, Principal.command)

    End Sub



End Module
