﻿Imports System.Data.SqlServerCe

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

    Public Function mostrar_ingreso(ByVal mes As Integer, ByVal año As Integer) As DataTable

        Principal.query = "SELECT * from ingresos where DATEPART(month, fecha) = '" & mes & "'" &
                " And DatePart(Year, fecha) = '" & año & "'"

        Dim dt As DataTable = consultarReader(Principal.query)

        Return dt

    End Function

    Public Function verificar_año(ByVal año As Integer)

        Principal.query = "SELECT * from ingresos where DATEPART(Year, fecha) = '" & año & "'"
        Dim dt As DataTable = consultarReader(Principal.query)

        Return IIf(dt.Rows.Count > 0, True, False)

    End Function

    Public Sub new_año(ByVal año As String)
        For i = 1 To 12
            Principal.query = "INSERT INTO ingresos (fecha, ingresos_prov, ingresos_central, ingresos_otros)" &
                              "VALUES ('" & i & "-01-" & año & "' , '0,0', '0,0', '0,0')"
            consultarNQ(Principal.query, Principal.command)
        Next
    End Sub

End Module
