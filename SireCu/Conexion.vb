Imports System.Data.SqlServerCe

Module Conexion

    Private conexion As New SqlCeConnection(My.Settings.CadenaConexion)

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

    Function consultarNQ(ByVal sql As String, ByRef command As SqlCeCommand) As Integer
        Dim resultado As Integer = 0

        Try
            conectar()
            command.CommandText = sql
            command.Connection = conexion
            resultado = command.ExecuteNonQuery()
            desconectar()
        Catch ex As SqlCeException
            MessageBox.Show(ex.Message)
        End Try

        Return resultado
    End Function

    Function consultarES(ByVal sql As String, ByRef command As SqlCeCommand) As Object
        Dim resultado As Object = New Object

        Try
            conectar()
            command.CommandText = sql
            command.Connection = conexion
            resultado = command.ExecuteScalar()
            desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return resultado
    End Function


End Module
