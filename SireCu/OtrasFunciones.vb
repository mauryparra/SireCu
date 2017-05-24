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
        Select Case trimestre
            Case "Primero"
                Principal.query = "SELECT [saldo_final] FROM [ReportesTrimestrales] INNER JOIN [Trimestres] ON [nombre] = '" &
            trimAnterior & "' AND año= '" & añoAnterior & "'"
            Case Else
                Principal.query = "SELECT [saldo_final] FROM [ReportesTrimestrales] INNER JOIN [Trimestres] ON [nombre] = '" &
            trimAnterior & "' AND año= '" & año & "'"
        End Select

        saldoAnterior = consultarES(Principal.query, Principal.command)

        ' 2)
        Dim resultadoConsulta = consultarES(queryIngresos, Principal.command)
        ingresos = IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta)


        ' 3)
        resultadoConsulta = Nothing
        resultadoConsulta = consultarES(queryEgresos, Principal.command)
        egresos = IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta)

        Return (saldoAnterior + ingresos - egresos)

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

    Public Function existReporte(ByVal año As Integer, ByVal trim As Integer)

        cargarTablaEnDataSet("ReportesTrimestrales")
        Dim flag As Boolean = False

        For i = 0 To Principal.dataset.Tables("ReportesTrimestrales").Rows.Count - 1
            If (Principal.dataset.Tables("ReportesTrimestrales").Rows.Item(i).Item("año") = año) And
               (Principal.dataset.Tables("ReportesTrimestrales").Rows.Item(i).Item("trimestre_id") = trim) Then
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

End Module
