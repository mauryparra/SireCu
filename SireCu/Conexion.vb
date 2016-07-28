Imports System.Data.SqlServerCe

Module Conexion
    'Establecer la cadena de conexion
    Private cadena_conexion As String = "Data Source = |DataDirectory|\DBSireCu.sdf"
    Private conexion As New SqlCeConnection(cadena_conexion)

    Function conectar()

        Try
            'Verifica si ya existe una conexion abierta, y sino la establece
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
        Catch e As SqlCeException
            'Muestra el error
            MessageBox.Show(e.Message)
            Return False
            Exit Function
        End Try

        Return True

    End Function

    Sub consultar(ByVal sql As String, ByRef command As SqlCeCommand)
        'El command es por referencia, asi que todo lo que devuelva desde esta función queda guardado en el command.

        Try
            'Toma la cadena de conexion
            command.CommandText = sql
            'Realiza la conexion
            command.Connection = conexion
            'Ejecuta la consulta
            command.ExecuteNonQuery()
        Catch e As SqlCeException
            'Muestra el error
            MessageBox.Show(e.Message)
        End Try

    End Sub

    Sub desconectar()

        'Cierra la Conexion
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If

    End Sub
End Module
