Imports System.Data.SqlServerCe

Module Conexion

    Public conexion As New SqlCeConnection(My.Settings.CadenaConexion)

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

    Sub cargarTablaEnDataSet(ByVal tabla As String)

        Principal.command.Connection = conexion

        ' Crea tabla en dataset si no existe
        If Not Principal.dataset.Tables.Contains(tabla) Then
            Principal.dataset.Tables.Add(tabla)
        End If

        Principal.command.CommandText = "Select * FROM " & tabla

        ' Crea tableadapter si no existe
        If Not Principal.tableadapters.ContainsKey(tabla) Then
            Principal.tableadapters.Add(tabla, New SqlCeDataAdapter(Principal.command))
        End If
        Principal.tableadapters(tabla).Fill(Principal.dataset.Tables.Item(tabla))
    End Sub


End Module
