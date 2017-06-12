﻿Imports System.Data.SqlServerCe

Module Reporte

    Public Sub CargarReportes(ByRef dgv As DataGridView, ByVal sql As String, Optional ByVal nombreDataSet As String = "Reportes")

        'Creamos la tabla si no existe
        If Not Principal.dataset.Tables.Contains(nombreDataSet) Then
            Principal.dataset.Tables.Add(nombreDataSet)
        End If
        'Limpiamos la tabla
        Principal.dataset.Tables(nombreDataSet).Clear()

        'Creamos el query
        Principal.command.CommandText = sql

        'Creamos el TableAdapter si no existe
        If Not Principal.tableadapters.ContainsKey(nombreDataSet) Then
            Principal.tableadapters.Add(nombreDataSet, New SqlCeDataAdapter(Principal.command))
        End If

        'Actualizamos el contenido de la tabla
        Principal.tableadapters(nombreDataSet).Fill(Principal.dataset.Tables.Item(nombreDataSet))

        'Asignamos el Bind
        Dim mybinding = New BindingSource(Principal.dataset, nombreDataSet)

        dgv.DataSource = mybinding

        columnasVerReporte(dgv)

        dgv.Columns("id").Visible = False

    End Sub

    Private Sub columnasVerReporte(ByRef dgv As DataGridView)
        Dim i As Integer = 0
        Dim array = New String() {"Ingresos - Gastos", "Ingresos", "Egresos Seccional", "Egresos Central"}

        Do
            If Not dgv.Columns.Contains(array(i)) Then
                Dim column As New DataGridViewButtonColumn
                With column
                    .Name = array(i)
                    .HeaderText = array(i)
                    .Text = "Ver Reporte"
                    .DataPropertyName = array(i)
                    .UseColumnTextForButtonValue = True
                End With
                dgv.Columns.Add(column)
            End If
            i = i + 1
        Loop While i <= 3

    End Sub

    Public Sub crearColumna(ByRef dgv As DataGridView, ByVal filtros As List(Of KeyValuePair(Of String, String)))

        For Each columna As KeyValuePair(Of String, String) In filtros
            If Not dgv.Columns.Contains(columna.Key) Then
                Dim column As New DataGridViewTextBoxColumn
                With column
                    .Name = columna.Key
                    .HeaderText = columna.Value
                    .DataPropertyName = columna.Value
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .DefaultCellStyle.Format = "C2"
                End With
                dgv.Columns.Add(column)
            End If
        Next

    End Sub

    Public Function existReporte(ByVal año As Integer, ByVal trim As Integer)

        cargarTablaEnDataSet("ReportesTrimestrales")
        Dim flag As Boolean = False

        For i = 0 To Principal.dataset.Tables("ReportesTrimestrales").Rows.Count - 1
            If (Principal.dataset.Tables("ReportesTrimestrales").Rows.Item(i).Item("año") = año) And
               (Principal.dataset.Tables("ReportesTrimestrales").Rows.Item(i).Item("trimestre_id") = trim) Then
                flag = True
            End If
        Next

        Return flag

    End Function

    Public Sub ActualizarTablasdeReporte()

    End Sub

    Public Sub CrearRepCentral(ByVal trimestre As Integer, ByVal año As Integer)

    End Sub

    Public Sub CrearRepSeccional(ByVal trimestre As Integer, ByVal año As Integer)

    End Sub

    Public Sub CrearRepIngresos(ByVal trimestre As Integer, ByVal año As Integer)

    End Sub

    Public Sub CrearRepTrimestrales(ByVal trimestre As Integer, ByVal año As Integer)

    End Sub

End Module
