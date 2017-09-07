Imports System.Data.SqlServerCe

Module OtrasFunciones

#Region "Saldo"

    Public Sub ActualizarSaldo()
        Dim saldo As Double = SaldoActual()

        If saldo >= 0 Then
            Principal.TStripLabelSaldo.ForeColor = Color.Green
        Else
            Principal.TStripLabelSaldo.ForeColor = Color.Red
        End If
        Principal.TStripLabelSaldo.Text = "Saldo: " & Format(saldo, "$ #,###,##0.00") & "    (" & Now.Month & "/" & Now.Year & ")"

    End Sub
    Public Function getSaldos(ByVal trimestre As String, ByVal año As String)

        Dim idTrimestre As Integer = obtenerID("Trimestres", "nombre", trimestre)
        Dim idTrimestreAnterior As Integer
        Dim sql As String
        Dim dt As DataTable
        Dim saldos() As Double = {0.0, 0.0}

        Select Case trimestre
            Case "Primero"
                idTrimestreAnterior = obtenerID("Trimestres", "nombre", "Cuarto")
            Case "Segundo"
                idTrimestreAnterior = obtenerID("Trimestres", "nombre", "Primero")
            Case "Tercero"
                idTrimestreAnterior = obtenerID("Trimestres", "nombre", "Segundo")
            Case "Cuarto"
                idTrimestreAnterior = obtenerID("Trimestres", "nombre", "Tercero")
        End Select

        'Saldo Inicial
        If trimestre = "Primero" Then
            sql = "SELECT saldo_final FROM Saldos WHERE año='" & (año - 1) &
            "' AND trimestre_id='" & idTrimestreAnterior & "'"
        Else
            sql = "SELECT saldo_final FROM Saldos WHERE año='" & año &
            "' AND trimestre_id='" & idTrimestreAnterior & "'"
        End If

        dt = consultarReader(sql)
        If dt.Rows.Count = 0 Then
            saldos(0) = 0
        Else
            saldos(0) = dt.Rows(0).Item("saldo_final")
        End If

        'Saldo final
        sql = "SELECT saldo_final FROM Saldos WHERE año='" & año &
            "' AND trimestre_id='" & idTrimestre & "'"
        dt = consultarReader(sql)
        If dt.Rows.Count = 0 Then
            saldos(1) = 0
        Else
            saldos(1) = dt.Rows(0).Item("saldo_final")
        End If

        Return (saldos)

    End Function
    Public Function SaldoActual() As Decimal

        ' 1) Buscamos el último saldo guardado
        ' 2) Buscamos el total de Ingresos a partir de la fecha del ultimo saldo
        ' 3) Buscamos el total de Egresos a partir de la fecha del ultimo saldo
        ' 4) Retornamos el resultado 

        Dim queryEgresos As String = ""
        Dim queryIngresos As String = ""
        Dim querySaldo As String = ""
        Dim saldoAnterior As Double = 0
        Dim ingresos As Double = 0
        Dim egresos As Double = 0


        ' 1)
        querySaldo = "SELECT TOP 1 S.id as id,
                                S.saldo_final as saldo_final,
                                S.año as año,
                                S.trimestre_id as trimestre_id,
                                T.nombre as trimestre_nombre,
                                T.fecha_inicio as trimestre_fecha
                               FROM Saldos as S 
                               LEFT JOIN Trimestres AS T ON S.trimestre_id = T.id
                               ORDER BY año DESC, trimestre_fecha DESC"

        Dim tablaSaldo As DataTable = consultarReader(querySaldo)
        If tablaSaldo.Rows.Count = 0 Then
            saldoAnterior = 0
            tablaSaldo.Rows.Add(0, 0, "2000", 0, "Cuarto")
        Else
            saldoAnterior = tablaSaldo.Rows(0).Item("saldo_final")
        End If


        ' 2) y 3)
        'Fecha del ultimo registro de Ingresos
        Dim ultimoRegistro As String = "SELECT TOP 1 fecha FROM Ingresos ORDER BY fecha DESC"
        Dim fechaFinalIngreso As Date
        Dim tabla As DataTable = consultarReader(ultimoRegistro)
        If tabla.Rows.Count = 0 Then
            fechaFinalIngreso = Format(Now(), "MM/dd/yyyy")
        Else
            fechaFinalIngreso = Format(tabla.Rows(0).Item("fecha"), "MM/dd/yyyy")
        End If

        'Fecha del ultimo registro de Egresos
        ultimoRegistro = "SELECT TOP 1 fecha FROM Egresos ORDER BY fecha DESC"
        Dim fechaFinalEgreso As Date
        tabla = consultarReader(ultimoRegistro)
        If tabla.Rows.Count = 0 Then
            fechaFinalEgreso = Format(Now(), "MM/dd/yyyy")
        Else
            fechaFinalEgreso = Format(tabla.Rows(0).Item("fecha"), "MM/dd/yyyy")
        End If

        'Seleccionar Todos los registros entre el trimestre siguiente al 
        'último saldo guardado y la fecha del ultimo registro
        Select Case tablaSaldo.Rows(0).Item("trimestre_nombre")
            Case "Primero"
                queryIngresos = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) AS Ingresos FROM [Ingresos]" &
                                " WHERE [fecha] BETWEEN '04/01/" & tablaSaldo.Rows(0).Item("año") & "' AND '" & fechaFinalIngreso & "'"
                queryEgresos = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE [mes_reintegro] BETWEEN '04/01/" &
                                tablaSaldo.Rows(0).Item("año") & "' AND '" & fechaFinalEgreso &
                               "' AND [eliminado] = 0"
            Case "Segundo"
                queryIngresos = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) AS Ingresos FROM [Ingresos]" &
                                " WHERE fecha BETWEEN '07/01/" & tablaSaldo.Rows(0).Item("año") & "' AND '" & fechaFinalIngreso & "'"
                queryEgresos = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE [mes_reintegro] BETWEEN '07/01/" &
                                tablaSaldo.Rows(0).Item("año") & "' AND '" & fechaFinalEgreso &
                               "' AND [eliminado] = 0"

            Case "Tercero"
                queryIngresos = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) AS Ingresos FROM [Ingresos]" &
                                " WHERE fecha BETWEEN '10/01/" & tablaSaldo.Rows(0).Item("año") & "' AND '" & fechaFinalIngreso & "'"
                queryEgresos = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE [mes_reintegro] BETWEEN '10/01/" &
                                tablaSaldo.Rows(0).Item("año") & "' AND '" & fechaFinalEgreso &
                               "' AND [eliminado] = 0"

            Case "Cuarto"
                queryIngresos = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) AS Ingresos FROM [Ingresos]" &
                                " WHERE fecha BETWEEN '01/01/" & (tablaSaldo.Rows(0).Item("año") + 1) & "' AND '" & fechaFinalIngreso & "'"
                queryEgresos = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE [mes_reintegro] BETWEEN '01/01/" &
                                (tablaSaldo.Rows(0).Item("año") + 1) & "' AND '" & fechaFinalEgreso &
                               "' AND [eliminado] = 0"

        End Select

        Dim resultadoConsulta = consultarES(queryIngresos, Principal.command)
        ingresos = IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta)

        resultadoConsulta = Nothing
        resultadoConsulta = consultarES(queryEgresos, Principal.command)
        egresos = IIf(IsDBNull(resultadoConsulta), 0, resultadoConsulta)

        '4)

        Return ((saldoAnterior + ingresos) - egresos)

    End Function

#End Region

#Region "Ingresos - Egresos"

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
                sqlMeses = "SELECT fecha, ingresos_prov, ingresos_central, ingresos_otros FROM Ingresos
                           WHERE DATEPART(month, [fecha]) BETWEEN 1 AND 3 AND DATEPART(year, [fecha]) = " & año
            Case "Segundo"
                sqlfull = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 4 AND 6 AND DATEPART(year, [fecha]) = " & año
                sqlprov = "SELECT SUM( [ingresos_prov] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 4 AND 6 AND DATEPART(year, [fecha]) = " & año
                sqlMeses = "SELECT fecha, ingresos_prov, ingresos_central, ingresos_otros FROM Ingresos
                           WHERE DATEPART(month, [fecha]) BETWEEN 4 AND 6 AND DATEPART(year, [fecha]) = " & año
            Case "Tercero"
                sqlfull = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 7 AND 9 AND DATEPART(year, [fecha]) = " & año
                sqlprov = "SELECT SUM( [ingresos_prov] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 7 AND 9 AND DATEPART(year, [fecha]) = " & año
                sqlMeses = "SELECT fecha, ingresos_prov, ingresos_central, ingresos_otros FROM Ingresos
                           WHERE DATEPART(month, [fecha]) BETWEEN 7 AND 9 AND DATEPART(year, [fecha]) = " & año
            Case "Cuarto"
                sqlfull = "SELECT SUM( [ingresos_prov] + [ingresos_central] + [ingresos_otros] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 10 AND 12 AND DATEPART(year, [fecha]) = " & año
                sqlprov = "SELECT SUM( [ingresos_prov] ) FROM [Ingresos]
                          WHERE DATEPART(month, [fecha]) BETWEEN 10 AND 12 AND DATEPART(year, [fecha]) = " & año
                sqlMeses = "SELECT fecha, ingresos_prov, ingresos_central, ingresos_otros FROM Ingresos
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
        Dim meses As Integer() = {}
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
                sqlSeccional = "SELECT SUM( [monto] ) AS Egresos FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 1 AND 3
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND seccional_id = " & seccional
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
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND categoria_gasto_id = " & categoria & " AND seccional_id = " & seccional
            Case "Segundo"
                sql = "SELECT monto, mes_reintegro FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 4 AND 6
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND categoria_gasto_id = " & categoria & " AND seccional_id = " & seccional
            Case "Tercero"
                sql = "SELECT monto, mes_reintegro FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 7 AND 9
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND categoria_gasto_id = " & categoria & " AND seccional_id = " & seccional
            Case "Cuarto"
                sql = "SELECT monto, mes_reintegro FROM [Egresos] WHERE DATEPART(month, [mes_reintegro]) BETWEEN 10 AND 12
                               AND DATEPART(year, [mes_reintegro]) = " & año & " AND [eliminado] = 0 AND categoria_gasto_id = " & categoria & " AND seccional_id = " & seccional
        End Select

        Dim dt As DataTable = consultarReader(sql)
        Dim array As Double() = {0, 0, 0}
        Dim i As Integer = 0

        If dt.Rows.Count <> 0 Then
            For i = 0 To dt.Rows.Count - 1
                Select Case DatePart(DateInterval.Month, dt.Rows(i).Item("mes_reintegro"))
                    Case 1, 4, 7, 10
                        array(0) = array(0) + dt.Rows(i).Item("monto")
                    Case 2, 5, 8, 11
                        array(1) = array(1) + dt.Rows(i).Item("monto")
                    Case 3, 6, 9, 12
                        array(2) = array(2) + dt.Rows(i).Item("monto")
                End Select
            Next
        End If

        Return (array)

    End Function

#End Region

#Region "Validaciones"

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

#End Region

#Region "Obtener"

    Public Function ultimoaño(ByVal tabla As String)

        Principal.query = "SELECT fecha FROM " & tabla & " ORDER BY fecha DESC"

        Dim data As DataTable = consultarReader(Principal.query)

        If (data.Rows.Count() = 0) Then
            Return (Now.Date.Year.ToString)
        Else : Return (DatePart(DateInterval.Year, data.Rows.Item(0).Item("fecha")))
        End If

    End Function
    Public Function obtenerID(ByVal tabla As String, ByVal campo As String, ByVal item_a_comparar As String, Optional ByVal distinto As Boolean = 0)

        Dim dt As DataTable
        Dim sql As String = ""

        If distinto = 0 Then
            sql = "SELECT id from " & tabla & " WHERE " & campo & " = '" & item_a_comparar & "'"
        Else
            sql = "SELECT id from " & tabla & " WHERE " & campo & " <> '" & item_a_comparar & "'"
        End If

        dt = consultarReader(sql)

        If dt.Rows.Count = 0 Then
            Return Nothing
        Else
            Return dt.Rows(0).Item("id")
        End If

    End Function
    Public Function obtenerIDSQL(ByVal tabla As String, ByVal campo As String, ByVal item_a_comparar As String, Optional ByVal distinto As Boolean = 0)

        Dim dt As DataTable
        Dim sql As String = ""

        If distinto = 0 Then
            sql = "SELECT id from " & tabla & " WHERE " & campo & " = '" & item_a_comparar & "'"
        Else
            sql = "SELECT id from " & tabla & " WHERE " & campo & " <> '" & item_a_comparar & "'"
        End If

        dt = consultarReaderSQL(sql)

        If dt.Rows.Count = 0 Then
            Return Nothing
        Else
            Return dt.Rows(0).Item("id")
        End If

    End Function
    Public Function obtenerSeccional()

        Dim dt As DataTable
        Dim sql As String = ""

        sql = "SELECT nombre from Seccionales WHERE nombre NOT LIKE 'UDA Central'"

        dt = consultarReader(sql)

        If dt.Rows.Count = 0 Then
            Return ("")
        Else
            Return dt.Rows(0).Item("nombre")
        End If

    End Function

#End Region

#Region "Helpers"

    Public Function autocomplete(ByVal tabla As String, ByVal Campo_a_Mostrar As String)

        Dim coleccion As New AutoCompleteStringCollection

        cargarTablaEnDataSet(tabla)

        For Each row As DataRow In Principal.dataset.Tables(tabla).Rows
            coleccion.Add(Convert.ToString(row.Item(Campo_a_Mostrar)))
        Next

        Return (coleccion)

    End Function
    Public Sub cierraTrimestre(ByVal año As Integer, ByVal trimestre As String, ByVal saldo As Double)

        Dim idTrimestre As Integer = obtenerID("Trimestres", "nombre", trimestre)
        Dim idTrimestreAnterior As Integer
        Select Case trimestre
            Case "Primero"
                idTrimestreAnterior = obtenerID("Trimestres", "nombre", "Cuarto")
            Case "Segundo"
                idTrimestreAnterior = obtenerID("Trimestres", "nombre", "Primero")
            Case "Tercero"
                idTrimestreAnterior = obtenerID("Trimestres", "nombre", "Segundo")
            Case "Cuarto"
                idTrimestreAnterior = obtenerID("Trimestres", "nombre", "Tercero")
        End Select


        Dim query As String = "SELECT * FROM Saldos WHERE trimestre_id=" & idTrimestre &
            " AND año=" & año
        Dim dtExist As DataTable = consultarReader(query)

        If dtExist.Rows.Count = 0 Then

            'Verificamos que el trimestre anterior este cerrado
            If trimestre = "Primero" Then
                query = "SELECT * FROM Saldos WHERE trimestre_id=" & idTrimestreAnterior &
                        " AND año=" & (año - 1)
            Else
                query = "SELECT * FROM Saldos WHERE trimestre_id=" & idTrimestreAnterior &
                        " AND año=" & año
            End If

            Dim dtCerrado As DataTable = consultarReader(query)
            If dtCerrado.Rows.Count = 0 Then
                MsgBox("Para cerrar el trimestre:" & trimestre & " del año: " & año & vbCrLf &
                       "Primero debe cerrar el trimestre anterior.", MsgBoxStyle.Exclamation, "Error")
            Else
                Principal.query = "INSERT INTO Saldos (saldo_final, año, trimestre_id)
                                VALUES (@saldo, @año, @trim)"
                Principal.command.Parameters.Clear()
                Principal.command.Parameters.AddWithValue("@saldo", saldo)
                Principal.command.Parameters.AddWithValue("@año", año)
                Principal.command.Parameters.AddWithValue("@trim", idTrimestre)
                consultarNQ(Principal.query, Principal.command)

                MsgBox("Trimestre cerrado correctamente.", MsgBoxStyle.Information, "Trimestre Cerrado")
            End If

        Else
            If MsgBox("El trimestre ingresado ya fue cerrado con un saldo de: " &
                      vbCrLf & Format(dtExist.Rows(0).Item("saldo_final"), "$ #,###,##0.00") &
                      vbCrLf & "Desea reemplazarlo?",
                      MsgBoxStyle.YesNo, "Reemplazar?") = MsgBoxResult.Yes Then

                Principal.query = "UPDATE Saldos SET saldo_final=@saldo
                                WHERE trimestre_id=@trim AND año=@año"
                Principal.command.Parameters.Clear()
                Principal.command.Parameters.AddWithValue("@saldo", saldo)
                Principal.command.Parameters.AddWithValue("@año", año)
                Principal.command.Parameters.AddWithValue("@trim", idTrimestre)
                consultarNQ(Principal.query, Principal.command)

                MsgBox("Trimestre actualizado correctamente.", MsgBoxStyle.Information, "Trimestre Cerrado")

                'TODO 
                'Cuando actualiza, debe actualizar todos los trimestres siguientes

            End If
        End If

    End Sub
    Public Function exist(ByVal tabla As String, ByVal campo As String, ByVal comparar As String)

        Dim flag As Boolean = False

        For i = 0 To Principal.dataset.Tables(tabla).Rows.Count - 1
            If (LCase(Principal.dataset.Tables(tabla).Rows.Item(i).Item(campo)) = LCase(comparar)) Then
                flag = True
            End If
        Next

        Return flag

    End Function

#End Region

End Module
