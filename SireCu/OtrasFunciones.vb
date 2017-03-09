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
        Principal.dataset.Tables("Proveedores").Clear()
        Principal.dataset.Tables("CategoriasGastos").Clear()
        Principal.dataset.Tables("Personas").Clear()
        Principal.dataset.Tables("TiposComprobantes").Clear()
    End Sub

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

        ' TODO reemplazar fill dataset por command.ExecuteReader

        Principal.query = "SELECT fecha FROM " & tabla & " ORDER BY fecha DESC"
        consultarNQ(Principal.query, Principal.command)
        ' ClearDataset(Principal.dataset)  Borrar solo tabla
        Principal.dataset.Tables(tabla).Clear()

        Principal.tableadapters(tabla) = New SqlCeDataAdapter(Principal.command)
        Principal.tableadapters(tabla).Fill(Principal.dataset.Tables(tabla))

        If (Principal.dataset.Tables(tabla).Rows.Count() = 0) Then
            Return ("2000")
        Else : Return (DatePart(DateInterval.Year, Principal.dataset.Tables(tabla).Rows.Item(0).Item("fecha")))
        End If

    End Function

    Public Sub abm_otros(ByVal tabla As String)

        ' ClearDataset(Principal.dataset)

        Principal.dataset.Tables(tabla).Clear()
        cargarTablaEnDataSet(tabla)

        Dim bindSource As New BindingSource
        bindSource.DataSource = Principal.dataset.Tables(tabla)
        Otros_AMB.dgv_otros.DataSource = bindSource
        Otros_AMB.dgv_otros.Columns.Item("id").Visible = False

    End Sub

    Public Function exist(ByVal tabla As String, ByVal campo As String, ByVal comparar As String)

        'Principal.query = "SELECT * FROM " & tabla
        'consultarNQ(Principal.query, Principal.command)
        'Principal.tableadapters(tabla) = New SqlCeDataAdapter(Principal.command)
        'Principal.tableadapters(tabla).Fill(Principal.dataset.Tables(tabla))

        ' TODO Ver si hace falta recargar la tabla en el dataset si no usar el dataset directamente
        cargarTablaEnDataSet(tabla)

        Dim flag As Boolean = False

        For i = 0 To Principal.dataset.Tables(tabla).Rows.Count - 1
            If (LCase(Principal.dataset.Tables(tabla).Rows.Item(i).Item(campo)) = LCase(comparar)) Then
                flag = True
            End If
        Next

        ' ClearDataset(Principal.dataset)
        Principal.dataset.Tables(tabla).Clear()

        Return flag

    End Function


End Module
