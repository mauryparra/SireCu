Imports System.Data.SqlServerCe

Module OtrasFunciones

    Public Function SaldoActual(ByVal trimestre As String, ByVal año As Integer) As Decimal

        ' 1) Buscamos saldo final del trimestre anterior
        ' 2) Sumamos ese monto con el total de Ingresos del trimestre actual
        ' 3) Restamos lo obtenido con el total de Egresos del trimestre actual

        Dim trimAnterior As String = ""
        Dim trimAnteriorAño As Integer = año
        Dim queryEgresos As String = ""
        Dim queryIngresos As String = ""
        Dim saldoAnterior As Decimal = 0
        Dim ingresos As Decimal = 0
        Dim egresos As Decimal = 0

        Select Case trimestre
            Case "Primero"
                trimAnterior = "Cuarto"
                trimAnteriorAño -= 1
                queryIngresos = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) AS Ingresos FROM [Ingresos]" &
                                "WHERE DATEPART(month, [fecha]) BETWEEN 1 AND 3 AND DATEPART(year, [fecha]) = " & año

                queryEgresos = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [fecha]) BETWEEN 1 AND 3" &
                               " AND DATEPART(year, [fecha]) = " & año
            Case "Segundo"
                trimAnterior = "Primero"
                queryIngresos = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) AS Ingresos FROM [Ingresos]" &
                                "WHERE DATEPART(month, [fecha]) BETWEEN 4 AND 6 AND DATEPART(year, [fecha]) = " & año

                queryEgresos = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [fecha]) BETWEEN 4 AND 6" &
                               " AND DATEPART(year, [fecha]) = " & año
            Case "Tercero"
                trimAnterior = "Segundo"
                queryIngresos = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) AS Ingresos FROM [Ingresos]" &
                                "WHERE DATEPART(month, [fecha]) BETWEEN 7 AND 9 AND DATEPART(year, [fecha]) = " & año

                queryEgresos = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [fecha]) BETWEEN 7 AND 9" &
                               " AND DATEPART(year, [fecha]) = " & año
            Case "Cuarto"
                trimAnterior = "Tercero"
                queryIngresos = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) AS Ingresos FROM [Ingresos]" &
                                "WHERE DATEPART(month, [fecha]) BETWEEN 10 AND 12 AND DATEPART(year, [fecha]) = " & año

                queryEgresos = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [fecha]) BETWEEN 10 AND 12" &
                               " AND DATEPART(year, [fecha]) = " & año
        End Select

        ' 1)
        Principal.query = "SELECT [saldo_final] FROM [ReportesTrimestrales] INNER JOIN [Trimestres] ON [Trimestres.nombre] =" &
            trimAnterior & " AND año=" & trimAnteriorAño
        saldoAnterior = consultarES(Principal.query, Principal.command)

        ' 2)
        ingresos = consultarES(queryIngresos, Principal.command)

        ' 3)
        egresos = consultarES(queryEgresos, Principal.command)

        Return (saldoAnterior + ingresos - egresos)

    End Function

    Public Sub ClearDataset(ByVal dataset As DataSet)
        Principal.dataset.Tables("Ingresos").Clear()
        Principal.dataset.Tables("Egresos").Clear()
        Principal.dataset.Tables("Saldos").Clear()
    End Sub

End Module
