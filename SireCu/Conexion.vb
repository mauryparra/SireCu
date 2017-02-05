Imports System.Data.SqlServerCe

Module Conexion
    Private cadena_conexion As String = "Data Source = |DataDirectory|\DBSireCu.sdf"
    Private conexion As New SqlCeConnection(cadena_conexion)

    Private Sub conectar()

        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
        Catch e As SqlCeException
            MessageBox.Show(e.Message)
            Exit Sub
        End Try

    End Sub
    Private Sub desconectar()

        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If

    End Sub

    Sub consultar(ByVal sql As String, ByRef command As SqlCeCommand)

        Try
            conectar()
            command.CommandText = sql
            command.Connection = conexion
            command.ExecuteNonQuery()
            desconectar()
        Catch e As SqlCeException
            MessageBox.Show(e.Message)
        End Try

    End Sub

End Module
