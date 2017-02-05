Imports System.Data.SqlServerCe

Module Ingreso

    Private dataset As New DataSet
    Private command As New SqlCeCommand
    Private adapter As SqlCeDataAdapter
    Private query As String

    Public Sub modificar_ingreso(ByVal mes As String, ByVal año As Integer, ByVal iprov As Double,
                                           ByVal iotros As Double, ByVal icen As Double)

        Dim command As New SqlCeCommand
        Dim sql As String = "UPDATE ingresos SET ingresos_prov = @iProvinciales, ingresos_otros = @iOtros, ingresos_central = @iCentral WHERE " &
                            "DATEPART(month, fecha) = '" & mes & "'" & " And DatePart(Year, fecha) = '" & año & "'"
        command.Parameters.AddWithValue("@iProvinciales", iprov)
        command.Parameters.AddWithValue("@iOtros", iotros)
        command.Parameters.AddWithValue("@iCentral", icen)

        consultar(sql, command)
    End Sub

    Public Function mostrar_ingreso(ByVal mes As Integer, ByVal año As Integer)

        query = "SELECT * from ingresos where DATEPART(month, fecha) = '" & mes & "'" &
                " And DatePart(Year, fecha) = '" & año & "'"

        consultar(query, command)
        adapter = New SqlCeDataAdapter(command)
        dataset.Tables.Clear()
        dataset.Tables.Add("ingresos")
        adapter.Fill(dataset.Tables("ingresos"))

        Dim array() As String
        If (dataset.Tables("ingresos").Rows.Count = 0) Then
            array = {0}
            Return (array)
        Else
            array = {
                dataset.Tables("ingresos").Rows.Item(0).Item("ingresos_prov"),
                dataset.Tables("ingresos").Rows.Item(0).Item("ingresos_central"),
                dataset.Tables("ingresos").Rows.Item(0).Item("ingresos_otros")
            }
            Return array
        End If

    End Function

    Public Function ultimoaño()

        query = "SELECT fecha FROM ingresos ORDER BY fecha DESC"
        consultar(query, command)
        dataset.Tables.Clear()

        adapter = New SqlCeDataAdapter(command)
        dataset.Tables.Add("ingresos")
        adapter.Fill(dataset.Tables("ingresos"))

        If (dataset.Tables("ingresos").Rows.Count() = 0) Then
            Return ("2000")
        Else : Return (DatePart(DateInterval.Year, dataset.Tables("ingresos").Rows.Item(0).Item("fecha")))
        End If

    End Function

    'Modificar saldos al cambiar ingresos  #FALTA COMPLETAR
    Private Function modSaldo(ByVal trimestre As String)

    End Function


End Module
