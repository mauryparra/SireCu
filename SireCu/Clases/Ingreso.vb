Imports System.Data.SqlServerCe

Module Ingreso

    Public Sub modificar_ingreso(ByVal mes As String, ByVal año As Integer, ByVal iprov As Double,
                                           ByVal iotros As Double, ByVal icen As Double)

        Principal.query = "UPDATE ingresos SET ingresos_prov = @iProvinciales, ingresos_otros = @iOtros, ingresos_central = @iCentral WHERE " &
                            "DATEPART(month, fecha) = '" & mes & "'" & " And DatePart(Year, fecha) = '" & año & "'"
        Principal.command.Parameters.AddWithValue("@iProvinciales", iprov)
        Principal.command.Parameters.AddWithValue("@iOtros", iotros)
        Principal.command.Parameters.AddWithValue("@iCentral", icen)

        consultarNQ(Principal.query, Principal.command)

        Principal.command.Parameters.Clear()

    End Sub

    Public Function mostrar_ingreso(ByVal mes As Integer, ByVal año As Integer)

        ' TODO reemplazar fill dataset por command.ExecuteReader

        Principal.query = "SELECT * from ingresos where DATEPART(month, fecha) = '" & mes & "'" &
                " And DatePart(Year, fecha) = '" & año & "'"

        consultarNQ(Principal.query, Principal.command)
        Principal.tableadapters("Ingresos") = New SqlCeDataAdapter(Principal.command)
        ClearDataset(Principal.dataset) ' TODO limpiar solo tabla a usar
        Principal.tableadapters("Ingresos").Fill(Principal.dataset.Tables("ingresos"))

        Dim array() As String
        If (Principal.dataset.Tables("ingresos").Rows.Count = 0) Then
            array = {0}
            Return (array)
        Else
            array = {
                Principal.dataset.Tables("ingresos").Rows.Item(0).Item("ingresos_prov"),
                Principal.dataset.Tables("ingresos").Rows.Item(0).Item("ingresos_central"),
                Principal.dataset.Tables("ingresos").Rows.Item(0).Item("ingresos_otros")
            }
            Return array
        End If

    End Function

    Public Function verificar_año(ByVal año As Integer)

        ' TODO reemplazar fill dataset por command.ExecuteReader

        Principal.query = "SELECT * from ingresos where DATEPART(Year, fecha) = '" & año & "'"
        consultarNQ(Principal.query, Principal.command)
        ClearDataset(Principal.dataset) ' TODO limpiar solo tabla a usar
        Principal.tableadapters("Ingresos") = New SqlCeDataAdapter(Principal.command)
        Principal.tableadapters("Ingresos").Fill(Principal.dataset.Tables("ingresos"))

        If (Principal.dataset.Tables("ingresos").Rows.Count = 0) Then
            Return (False)
        Else
            Return (True)
        End If

    End Function

    Public Sub new_año(ByVal año As String)
        For i = 1 To 12
            Principal.query = "INSERT INTO ingresos (fecha, ingresos_prov, ingresos_central, ingresos_otros)" &
                              "VALUES ('" & i & "-01-" & año & "' , '0,0', '0,0', '0,0')"
            consultarNQ(Principal.query, Principal.command)
        Next
    End Sub

End Module
