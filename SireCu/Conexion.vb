Imports System.Data.SqlServerCe
Imports MySql.Data.MySqlClient

Module Conexion

    Public conexion As New SqlCeConnection(My.Settings.CadenaConexion)
    Public conexionMySQL As New MySqlConnection(My.Settings.CadenaSQL)

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

#Region "Desktop"

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
    Function consultarReader(ByVal sql As String) As DataTable

        Dim reader As SqlCeDataReader
        Dim dt As New DataTable

        Try
            conectar()
            Principal.command.CommandText = sql
            Principal.command.Connection = conexion
            reader = Principal.command.ExecuteReader()
            dt.Load(reader)
            desconectar()
        Catch ex As SqlCeException
            MessageBox.Show(ex.Message)
            reader = Nothing
        End Try

        Return dt
    End Function
    Sub cargarTablaEnDataSet(ByVal tabla As String)

        Principal.command.Connection = conexion

        ' Crea tabla en dataset si no existe
        If Not Principal.dataset.Tables.Contains(tabla) Then
            Principal.dataset.Tables.Add(tabla)
        End If
        'Limpiamos la tabla
        Principal.dataset.Tables(tabla).Clear()

        Principal.command.CommandText = "Select * FROM " & tabla

        ' Crea tableadapter si no existe
        If Not Principal.tableadapters.ContainsKey(tabla) Then
            Principal.tableadapters.Add(tabla, New SqlCeDataAdapter(Principal.command))
        End If

        'Refrescamos el contenido
        Principal.tableadapters(tabla).Fill(Principal.dataset.Tables.Item(tabla))

    End Sub

#End Region

#Region "Web"

    Function consultarMySQL(ByVal sql As String, ByRef command As MySqlCommand)
        Dim resultado As Integer = 0

        Try
            If conexionMySQL.State = ConnectionState.Closed Then
                conexionMySQL.Open()
            End If
            command.CommandText = sql
            command.Connection = conexionMySQL
            resultado = command.ExecuteNonQuery()
        Catch e As MySqlException
            MessageBox.Show(e.Message)
            resultado = 1
        End Try

        conexionMySQL.Close()

        Return resultado

    End Function
    Function consultarReaderSQL(ByVal sql As String) As DataTable

        Dim reader As MySqlDataReader
        Dim dt As New DataTable
        Dim command As New MySqlCommand

        Try
            If conexionMySQL.State = ConnectionState.Closed Then
                conexionMySQL.Open()
            End If
            command.CommandText = sql
            command.Connection = conexionMySQL
            reader = command.ExecuteReader()
            dt.Load(reader)
            conexionMySQL.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            reader = Nothing
        End Try

        Return dt
    End Function

#End Region



End Module
