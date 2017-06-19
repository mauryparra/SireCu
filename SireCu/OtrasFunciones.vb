Imports System.Data.SqlServerCe

Module OtrasFunciones

    Public Function SaldoActual(ByVal trimestre As String, ByVal año As Integer) As Decimal

        ' 1) Buscamos saldo final del trimestre anterior
        ' 2) Sumamos ese monto con el total de Ingresos del trimestre actual
        ' 3) Restamos lo obtenido con el total de Egresos del trimestre actual

        Dim trimAnterior As String = ""
        Dim añoAnterior As Integer = año - 1
        Dim queryEgresos As String = ""
        Dim queryIngresos As String = ""
        Dim saldoAnterior As Double = 0
        Dim ingresos As Double = 0
        Dim egresos As Double = 0

        Select Case trimestre
            Case "Primero"
                trimAnterior = "Cuarto"
                queryIngresos = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) AS Ingresos FROM [Ingresos]" &
                                " WHERE DATEPART(month, [fecha]) BETWEEN 1 AND 3 AND DATEPART(year, [fecha]) = " & año

                queryEgresos = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 1 AND 3" &
                               " AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0"
            Case "Segundo"
                trimAnterior = "Primero"
                queryIngresos = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) AS Ingresos FROM [Ingresos]" &
                                " WHERE DATEPART(month, [fecha]) BETWEEN 4 AND 6 AND DATEPART(year, [fecha]) = " & año

                queryEgresos = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 4 AND 6" &
                               " AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0"
            Case "Tercero"
                trimAnterior = "Segundo"
                queryIngresos = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) AS Ingresos FROM [Ingresos]" &
                                " WHERE DATEPART(month, [fecha]) BETWEEN 7 AND 9 AND DATEPART(year, [fecha]) = " & año

                queryEgresos = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 7 AND 9" &
                               " AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0"
            Case "Cuarto"
                trimAnterior = "Tercero"
                queryIngresos = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) AS Ingresos FROM [Ingresos]" &
                                 "WHERE DATEPART(month, [fecha]) BETWEEN 10 AND 12 AND DATEPART(year, [fecha]) = " & año

                queryEgresos = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 10 AND 12" &
                               " AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0"
        End Select

        ' 1)
        Dim idSeccional As Integer = obtenerID("Seccionales", "nombre", "UDA Central", True)
        Dim idCentral As Integer = obtenerID("Seccionales", "nombre", "UDA Central")
        Dim resIng As Decimal
        Dim resEgre As Decimal
        If trimAnterior = "Cuarto" Then
            resIng = obtenerIngresos(trimAnterior, añoAnterior)
            resEgre = obtenerEgresosTotales(trimAnterior, añoAnterior, "full")
        Else
            resIng = obtenerIngresos(trimAnterior, año)
            resEgre = obtenerEgresosTotales(trimAnterior, año, "full")
        End If

        saldoAnterior = resIng - resEgre

        ' 2)
        Dim resultadoConsulta = consultarES(queryIngresos, Principal.command)
        ingresos = IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta)


        ' 3)
        resultadoConsulta = Nothing
        resultadoConsulta = consultarES(queryEgresos, Principal.command)
        egresos = IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta)

        Return (saldoAnterior + ingresos - egresos)

    End Function

    Public Function obtenerIngresos(ByVal trimestre As String, ByVal año As Integer, Optional modo As String = "full")

        Dim sqlfull As String = ""
        Dim sqlprov As String = ""
        Dim sqlMeses As String = ""

        Select Case trimestre
            Case "Primero"
                sqlfull = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 1 AND 3 AND DATEPART(year, [fecha]) = " & año
                sqlprov = "SELECT SUM( [ingresos_prov] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 1 AND 3 AND DATEPART(year, [fecha]) = " & año
                sqlMeses = "SELECT ingresos_prov, ingresos_central, ingresos_otros FROM Ingresos
                           WHERE DATEPART(month, [fecha]) BETWEEN 1 AND 3 AND DATEPART(year, [fecha]) = " & año
            Case "Segundo"
                sqlfull = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 4 AND 6 AND DATEPART(year, [fecha]) = " & año
                sqlprov = "SELECT SUM( [ingresos_prov] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 4 AND 6 AND DATEPART(year, [fecha]) = " & año
                sqlMeses = "SELECT ingresos_prov, ingresos_central, ingresos_otros FROM Ingresos
                           WHERE DATEPART(month, [fecha]) BETWEEN 4 AND 6 AND DATEPART(year, [fecha]) = " & año
            Case "Tercero"
                sqlfull = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 7 AND 9 AND DATEPART(year, [fecha]) = " & año
                sqlprov = "SELECT SUM( [ingresos_prov] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 7 AND 9 AND DATEPART(year, [fecha]) = " & año
                sqlMeses = "SELECT ingresos_prov, ingresos_central, ingresos_otros FROM Ingresos
                           WHERE DATEPART(month, [fecha]) BETWEEN 7 AND 9 AND DATEPART(year, [fecha]) = " & año
            Case "Cuarto"
                sqlfull = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 10 AND 12 AND DATEPART(year, [fecha]) = " & año
                sqlprov = "SELECT SUM( [ingresos_prov] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 10 AND 12 AND DATEPART(year, [fecha]) = " & año
                sqlMeses = "SELECT ingresos_prov, ingresos_central, ingresos_otros FROM Ingresos
                           WHERE DATEPART(month, [fecha]) BETWEEN 10 AND 12 AND DATEPART(year, [fecha]) = " & año
        End Select

        Select Case modo
            Case "full"
                Dim resultadoConsulta = consultarES(sqlfull, Principal.command)
                Return (IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta))
            Case "provincial"
                Dim resultadoConsulta = consultarES(sqlprov, Principal.command)
                Return (IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta))
            Case "meses"
                Return (consultarReader(sqlMeses))
            Case Else
                Return (Nothing)
        End Select

    End Function

    Public Function obtenerEgresosTotales(ByVal trimestre As String, ByVal año As Integer, ByVal modo As String, Optional ByVal seccional As String = "UDA Central")

        Dim sqlFull As String = ""
        Dim sqlSeccional As String = ""
        Dim meses As Integer()
        Dim idSec As Integer
        If seccional = "UDA Central" Then
            idSec = obtenerID("Seccionales", "nombre", "UDA Central")
        Else
            idSec = obtenerID("Seccionales", "nombre", "UDA Central", True)
        End If

        Select Case trimestre
            Case "Primero"
                sqlFull = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 1 AND 3
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0"
                meses = {1, 2, 3}
            Case "Segundo"
                sqlFull = "Select SUM( [monto] ) As Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 4 And 6
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0"
                sqlSeccional = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 4 AND 6
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND seccional_id = " & seccional
                meses = {4, 5, 6}
            Case "Tercero"
                sqlFull = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 7 AND 9
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0"
                sqlSeccional = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 7 AND 9
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND seccional_id = " & seccional
                meses = {7, 8, 9}
            Case "Cuarto"
                sqlFull = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 10 AND 12
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0"
                sqlSeccional = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 10 AND 12
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND seccional_id = " & seccional
                meses = {10, 11, 12}
        End Select


        Select Case modo

            Case "full"

                Dim resultadoConsulta = consultarES(sqlFull, Principal.command)
                Return (IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta))

            Case "seccional"

                Dim arrayResultado As Double() = {0, 0, 0}
                Dim resultadoConsulta = Nothing
                Dim i As Integer = 0

                For i = 0 To meses.Count - 1
                    sqlSeccional = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) = " & meses(i) &
                               " AND DATEPART(Year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND seccional_id = " & idSec
                    resultadoConsulta = consultarES(sqlSeccional, Principal.command)
                    arrayResultado(i) = IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta)
                Next

                Return (arrayResultado)

            Case Else
                Return (Nothing)

        End Select

    End Function

    Public Function obtenerEgresosCategorias(ByVal trimestre As String, ByVal categoria As Integer, ByVal año As Integer, ByVal seccional As Integer)

        Dim sql As String = ""

        Select Case trimestre
            Case "Primero"
                sql = "Select monto, mes_reintegro FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 1 And 3
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND categoria_gasto_id = " & categoria
            Case "Segundo"
                sql = "SELECT monto, mes_reintegro FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 4 AND 6
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND categoria_gasto_id = " & categoria
            Case "Tercero"
                sql = "SELECT monto, mes_reintegro FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 7 AND 9
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND categoria_gasto_id = " & categoria
            Case "Cuarto"
                sql = "SELECT monto, mes_reintegro FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 10 AND 12
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND categoria_gasto_id = " & categoria
        End Select

        Dim dt As DataTable = consultarReader(sql)
        Dim array As Double() = {0, 0, 0}
        Dim i As Integer = 0

        If dt.Rows.Count <> 0 Then
            For i = 0 To dt.Rows.Count - 1
                array(i) = dt.Rows(i).Item("monto")
            Next
        End If

        Return (array)

    End Function

    Public Sub keyverify(ByVal e As System.Windows.Forms.KeyPressEventArgs,
                         Optional ByVal letras As Boolean = False,
                         Optional ByVal numeros As Boolean = False,
                         Optional ByVal comas As Boolean = False,
                         Optional ByVal puntosAComas As Boolean = False,
                         Optional ByVal espacios As Boolean = False,
                         Optional ByVal control As Boolean = True,
                         Optional ByVal otros As Boolean = False)

        If Char.IsLetter(e.KeyChar) Then        ' Permite o cancela ingreso de letras
            e.Handled = Not letras
        ElseIf Char.IsDigit(e.KeyChar) Then     ' Permite o cancela ingreso de numeros
            e.Handled = Not numeros
        ElseIf e.KeyChar = "," Then             ' Permite o cancela ingreso de comas
            e.Handled = Not comas
        ElseIf comas And e.KeyChar = "." Then   ' Si se permiten comas y el caracter es un punto
            If puntosAComas Then                ' Permite o cancela la sustitución de punto por coma
                e.KeyChar = ","
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf Char.IsSeparator(e.KeyChar) Then ' Permite o cancela ingreso de espacios
            e.Handled = Not espacios
        ElseIf Char.IsControl(e.KeyChar) Then   ' Permite o cancela ingreso caracteres de control
            e.Handled = Not control
        Else
            e.Handled = Not otros               ' Permite o cancela ingreso de otros caracteres
        End If

    End Sub

    Public Function ultimoaño(ByVal tabla As String)

        Principal.query = "SELECT fecha FROM " & tabla & " ORDER BY fecha DESC"

        Dim data As DataTable = consultarReader(Principal.query)

        If (data.Rows.Count() = 0) Then
            Return (Now.Date.Year.ToString)
        Else : Return (DatePart(DateInterval.Year, data.Rows.Item(0).Item("fecha")))
        End If

    End Function

    Public Function exist(ByVal tabla As String, ByVal campo As String, ByVal comparar As String)

        Dim flag As Boolean = False

        For i = 0 To Principal.dataset.Tables(tabla).Rows.Count - 1
            If (LCase(Principal.dataset.Tables(tabla).Rows.Item(i).Item(campo)) = LCase(comparar)) Then
                flag = True
            End If
        Next

        Return flag

    End Function

    Public Function autocomplete(ByVal tabla As String, ByVal Campo_a_Mostrar As String)

        Dim coleccion As New AutoCompleteStringCollection

        cargarTablaEnDataSet(tabla)

        For Each row As DataRow In Principal.dataset.Tables(tabla).Rows
            coleccion.Add(Convert.ToString(row.Item(Campo_a_Mostrar)))
        Next

        Return (coleccion)

    End Function

    Public Sub ActualizarSaldo()
        Dim saldo As Double
        Select Case Now.Date.Month
            Case 1 To 3
                saldo = SaldoActual("Primero", Now.Date.Year)
            Case 4 To 6
                saldo = SaldoActual("Segundo", Now.Date.Year)
            Case 7 To 9
                saldo = SaldoActual("Tercero", Now.Date.Year)
            Case 10 To 12
                saldo = SaldoActual("Cuarto", Now.Date.Year)
            Case Else
                Exit Sub
        End Select

        If saldo >= 0 Then
            Principal.TStripLabelSaldo.ForeColor = Color.Green
        Else
            Principal.TStripLabelSaldo.ForeColor = Color.Red
        End If
        Principal.TStripLabelSaldo.Text = "Saldo: $" & saldo & "    (" & Now.Month & "/" & Now.Year & ")"

    End Sub

    Public Function obtenerID(ByVal tabla As String, ByVal campo As String, ByVal item_a_comparar As String, Optional ByVal distinto As Boolean = 0)

        cargarTablaEnDataSet(tabla)

        Dim id As Integer = Nothing

        If distinto = 0 Then
            For i = 0 To Principal.dataset.Tables(tabla).Rows.Count - 1
                If (LCase(Principal.dataset.Tables(tabla).Rows.Item(i).Item(campo)) = LCase(item_a_comparar)) Then
                    id = Principal.dataset.Tables(tabla).Rows.Item(i).Item(id)
                End If
            Next
        Else
            For i = 0 To Principal.dataset.Tables(tabla).Rows.Count - 1
                If (LCase(Principal.dataset.Tables(tabla).Rows.Item(i).Item(campo)) <> LCase(item_a_comparar)) Then
                    id = Principal.dataset.Tables(tabla).Rows.Item(i).Item(id)
                End If
            Next
        End If

        Return id

    End Function

    Public Function obtenerSeccional()

        Dim tabla As String = "Seccionales"
        Dim seccional As String = ""

        cargarTablaEnDataSet(tabla)

        For i = 0 To Principal.dataset.Tables(tabla).Rows.Count - 1
            If (LCase(Principal.dataset.Tables(tabla).Rows.Item(i).Item("nombre")) <> LCase("UDA Central")) Then
                seccional = Principal.dataset.Tables(tabla).Rows.Item(i).Item("nombre")
            End If
        Next

        Return (seccional)

    End Function

End Module
