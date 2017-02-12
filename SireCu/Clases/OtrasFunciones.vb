Imports System.Data.SqlServerCe


Module OtrasFunciones

    Public Function SaldoActual(ByVal trimestre As String, ByVal año As Integer)

        ' 1) Buscamos saldo final del trimestre anterior
        ' 2) Sumamos ese monto con el total de Ingresos del trimestre actual
        ' 3) Restamos lo obtenido con el total de Egresos del trimestre actual

        Dim trimAnterior As String = ""
        Dim queryEgresos As String = ""
        Dim queryIngresos As String = ""

        Select Case trimestre
            Case "Primero"
                trimAnterior = "Cuarto"
                queryIngresos = "SELECT * from ingresos where DATEPART(month, fecha) BETWEEN '1' AND '3'" &
                " And DatePart(Year, fecha) = '" & año & "'"
                queryEgresos = "SELECT monto from egresos where DATEPART(month, fecha) BETWEEN '1' AND '3'" &
                " And DatePart(Year, fecha) = '" & año & "'"
            Case "Segundo"
                trimAnterior = "Primero"
                queryIngresos = "SELECT * from ingresos where DATEPART(month, fecha) BETWEEN '4' AND '6'" &
                " And DatePart(Year, fecha) = '" & año & "'"
                queryEgresos = "SELECT monto from egresos where DATEPART(month, fecha) BETWEEN '4' AND '6'" &
                " And DatePart(Year, fecha) = '" & año & "'"
            Case "Tercero"
                trimAnterior = "Segundo"
                queryIngresos = "SELECT * from ingresos where DATEPART(month, fecha) BETWEEN '7' AND '9'" &
                " And DatePart(Year, fecha) = '" & año & "'"
                queryEgresos = "SELECT monto from egresos where DATEPART(month, fecha) BETWEEN '7' AND '9'" &
                " And DatePart(Year, fecha) = '" & año & "'"
            Case "Cuarto"
                trimAnterior = "Tercero"
                queryIngresos = "SELECT * from ingresos where DATEPART(month, fecha) BETWEEN '10' AND '12'" &
                " And DatePart(Year, fecha) = '" & año & "'"
                queryEgresos = "SELECT monto from egresos where DATEPART(month, fecha) BETWEEN '10' AND '12'" &
                " And DatePart(Year, fecha) = '" & año & "'"
        End Select

        ' 1)
        Principal.query = "SELECT saldo_final FROM ReportesTrimestrales inner join Trimestres On Trimestres.nombre=" &
            trimAnterior & " AND año=" & año
        consultar(Principal.query, Principal.command)
        Cleandataset(Principal.dataset)
        Principal.adapter = New SqlCeDataAdapter(Principal.command)
        Principal.adapter.Fill(Principal.dataset.Tables("saldos"))

        ' 2)
        consultar(queryIngresos, Principal.command)
        Principal.adapter = New SqlCeDataAdapter(Principal.command)
        Principal.adapter.Fill(Principal.dataset.Tables("ingresos"))

        Dim Saldo As Double
        If (Principal.dataset.Tables("saldos").Rows.Count = 0) And (Principal.dataset.Tables("ingresos").Rows.Count = 0) Then
            Saldo = "0.0"
        Else
            Saldo = (
            Principal.dataset.Tables("ingresos").Rows.Item(0).Item("ingresos_prov") +
            Principal.dataset.Tables("ingresos").Rows.Item(0).Item("ingresos_central") +
            Principal.dataset.Tables("ingresos").Rows.Item(0).Item("ingresos_otros")
            ) +
            Principal.dataset.Tables("saldos").Rows.Item(0).Item("saldo_final")
        End If

        ' 3)
        consultar(queryEgresos, Principal.command)
        Principal.adapter = New SqlCeDataAdapter(Principal.command)
        Principal.adapter.Fill(Principal.dataset.Tables("egresos"))

        If (Principal.dataset.Tables("egresos").Rows.Count = 0) Then
            'Sin egresos.
        Else
            For i = 0 To Principal.dataset.Tables("Egresos").Rows.Count - 1
                Saldo = Saldo -
                Principal.dataset.Tables("egresos").Rows.Item(i).Item("saldo_final")
            Next
        End If

        Return (Saldo)

    End Function

    Public Sub ClearDataset(ByVal dataset As DataSet)
        Principal.dataset.Tables("Ingresos").Clear()
        Principal.dataset.Tables("Egresos").Clear()
        Principal.dataset.Tables("Saldos").Clear()
    End Sub

End Module
