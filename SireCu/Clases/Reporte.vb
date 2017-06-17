Imports System.Data.SqlServerCe

Module Reporte


    'Public Sub CrearRepEgreso(ByVal trimestre As String, ByVal año As Integer, ByVal seccional As Integer, ByVal central As Integer)

    '    Dim idTrimestre As Integer = obtenerID("Trimestres", "nombre", trimestre)
    '    Dim idReporteTrimestral = existReporte(año, idTrimestre)
    '    Dim sqlTotEgresoSec As String = ""
    '    Dim sqlTotEgresoCen As String = ""

    '    Select Case trimestre
    '        Case "Primero"
    '            sqlTotEgresoSec = "SELECT SUM(monto) FROM Egresos 
    '               WHERE seccional_id = " & seccional &
    '               " AND ((DATEPART(Month, [fecha]) BETWEEN 1 And 3 AND DATEPART(year, [fecha]) = " & año & ")
    '                OR (DATEPART(Month, [mes_reintegro]) BETWEEN 1 And 3 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
    '            sqlTotEgresoCen = "SELECT SUM(monto) FROM Egresos 
    '               WHERE seccional_id = " & central &
    '               " AND ((DATEPART(Month, [fecha]) BETWEEN 1 And 3 AND DATEPART(year, [fecha]) = " & año & ")
    '                OR (DATEPART(Month, [mes_reintegro]) BETWEEN 1 And 3 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
    '        Case "Segundo"
    '            sqlTotEgresoSec = "SELECT SUM(monto) FROM Egresos 
    '               WHERE seccional_id = " & seccional &
    '               " AND ((DATEPART(Month, [fecha]) BETWEEN 4 And 6 AND DATEPART(year, [fecha]) = " & año & ")
    '                OR (DATEPART(Month, [mes_reintegro]) BETWEEN 4 And 6 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
    '            sqlTotEgresoCen = "SELECT SUM(monto) FROM Egresos 
    '               WHERE seccional_id = " & central &
    '               " AND ((DATEPART(Month, [fecha]) BETWEEN 4 And 6 AND DATEPART(year, [fecha]) = " & año & ")
    '                OR (DATEPART(Month, [mes_reintegro]) BETWEEN 4 And 6 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
    '        Case "Tercero"
    '            sqlTotEgresoSec = "SELECT SUM(monto) FROM Egresos 
    '               WHERE seccional_id = " & seccional &
    '               " AND ((DATEPART(Month, [fecha]) BETWEEN 7 And 7 AND DATEPART(year, [fecha]) = " & año & ")
    '                OR (DATEPART(Month, [mes_reintegro]) BETWEEN 7 And 9 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
    '            sqlTotEgresoCen = "SELECT SUM(monto) FROM Egresos 
    '               WHERE seccional_id = " & central &
    '               " AND ((DATEPART(Month, [fecha]) BETWEEN 7 And 9 AND DATEPART(year, [fecha]) = " & año & ")
    '                OR (DATEPART(Month, [mes_reintegro]) BETWEEN 7 And 9 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
    '        Case "Cuarto"
    '            sqlTotEgresoSec = "SELECT SUM(monto) FROM Egresos 
    '               WHERE seccional_id = " & seccional &
    '               " AND ((DATEPART(Month, [fecha]) BETWEEN 10 And 12 AND DATEPART(year, [fecha]) = " & año & ")
    '                OR (DATEPART(Month, [mes_reintegro]) BETWEEN 10 And 12 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
    '            sqlTotEgresoCen = "SELECT SUM(monto) FROM Egresos 
    '               WHERE seccional_id = " & central &
    '               " AND ((DATEPART(Month, [fecha]) BETWEEN 10 And 12 AND DATEPART(year, [fecha]) = " & año & ")
    '                OR (DATEPART(Month, [mes_reintegro]) BETWEEN 10 And 12 AND DATEPART(year, [mes_reintegro]) = " & año & "))"
    '    End Select

    '    Dim resultadoConsulta = consultarES(sqlTotEgresoSec, Principal.command)
    '    Dim totalEgresoSec As Double = IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta)
    '    resultadoConsulta = consultarES(sqlTotEgresoCen, Principal.command)
    '    Dim totalEgresoCen As Double = IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta)

    '    'Reporte Egreso Seccional
    '    Principal.query = "INSERT INTO ReportesEgresos 
    '                                       (reporte_trimestre_id, seccional_id, total) 
    '                                        VALUES 
    '                                        (" & idReporteTrimestral & "," & seccional & "," & totalEgresoSec & ")"
    '    consultarNQ(Principal.query, Principal.command)
    '    'Reporte Egreso Central
    '    Principal.query = "INSERT INTO ReportesEgresos 
    '                                       (reporte_trimestre_id, seccional_id, total) 
    '                                        VALUES 
    '                                        (" & idReporteTrimestral & "," & central & "," & totalEgresoCen & ")"
    '    consultarNQ(Principal.query, Principal.command)

    'End Sub

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
        egresos = obtenerEgresos(trimestre, año, idSeccional, idCentral)

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
    Public Sub generarRepIngresos()

    End Sub
    'REPORTE EGRESOS SECCIONAL
    Public Sub generarRepEgreSec()

    End Sub
    'REPORTE EGRESOS CENTRAL
    Public Sub generarRepEgreCen()

    End Sub

#End Region

#Region "Helpers"

    Private Function obtenerIngresos(ByVal trimestre As String, ByVal año As Integer, Optional modo As String = "full")

        'Full = true = Total de ingresos
        'Full = false = Total ingresos provinciales

        Dim sqlfull As String = ""
        Dim sqlprov As String = ""

        Select Case trimestre
            Case "Primero"
                sqlfull = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 1 AND 3 AND DATEPART(year, [fecha]) = " & año
                sqlprov = "SELECT SUM( [ingresos_prov] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 1 AND 3 AND DATEPART(year, [fecha]) = " & año
            Case "Segundo"
                sqlfull = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 4 AND 6 AND DATEPART(year, [fecha]) = " & año
                sqlprov = "SELECT SUM( [ingresos_prov] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 1 AND 3 AND DATEPART(year, [fecha]) = " & año
            Case "Tercero"
                sqlfull = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 7 AND 9 AND DATEPART(year, [fecha]) = " & año
                sqlprov = "SELECT SUM( [ingresos_prov] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 1 AND 3 AND DATEPART(year, [fecha]) = " & año
            Case "Cuarto"
                sqlfull = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 10 AND 12 AND DATEPART(year, [fecha]) = " & año
                sqlprov = "SELECT SUM( [ingresos_prov] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 1 AND 3 AND DATEPART(year, [fecha]) = " & año
        End Select

        Select Case modo
            Case "full"
                Dim resultadoConsulta = consultarES(sqlfull, Principal.command)
                Return (IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta))
            Case "provincial"
                Dim resultadoConsulta = consultarES(sqlprov, Principal.command)
                Return (IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta))
            Case Else
                Return (Nothing)
        End Select

    End Function
    Private Function obtenerEgresos(ByVal trimestre As String, ByVal año As Integer, ByVal seccional As Integer, ByVal central As Integer, Optional ByVal modo As String = "full")

        Dim sqlFull As String = ""
        Dim sqlSeccional As String = ""
        Dim sqlCentral As String = ""

        Select Case trimestre
            Case "Primero"
                sqlFull = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 1 AND 3
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0"
                sqlSeccional = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 1 AND 3
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND seccional_id = " & seccional
                sqlCentral = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 1 AND 3
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND seccional_id = " & central
            Case "Segundo"
                sqlFull = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 4 AND 6
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0"
                sqlSeccional = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 4 AND 6
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND seccional_id = " & seccional
                sqlCentral = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 4 AND 6
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND seccional_id = " & central
            Case "Tercero"
                sqlFull = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 7 AND 9
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0"
                sqlSeccional = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 7 AND 9
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND seccional_id = " & seccional
                sqlCentral = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 7 AND 9
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND seccional_id = " & central
            Case "Cuarto"
                sqlFull = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 10 AND 12
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0"
                sqlSeccional = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 10 AND 12
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND seccional_id = " & seccional
                sqlCentral = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 10 AND 12
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND seccional_id = " & central
        End Select


        Select Case modo
            Case "full"
                Dim resultadoConsulta = consultarES(sqlFull, Principal.command)
                Return (IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta))
            Case "seccional"
                Dim resultadoConsulta = consultarES(sqlSeccional, Principal.command)
                Return (IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta))
            Case "central"
                Dim resultadoConsulta = consultarES(sqlCentral, Principal.command)
                Return (IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta))
            Case Else
                Return (Nothing)
        End Select

    End Function
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
