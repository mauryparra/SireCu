Imports System.Data.SqlServerCe

Module Reporte

    Public Sub CargarReportes(ByRef dgv As DataGridView, Optional ByVal nombreDataSet As String = "Reportes")

        'Creamos la tabla si no existe
        If Not Principal.dataset.Tables.Contains(nombreDataSet) Then
            Principal.dataset.Tables.Add(nombreDataSet)
        End If
        'Limpiamos la tabla
        Principal.dataset.Tables(nombreDataSet).Clear()

        'Creamos el query
        Principal.command.CommandText = "SELECT TOP (500) R.id AS id,
                                  R.año AS Año,
                                  Trim.nombre AS Trimestre                             
                           FROM ReportesTrimestrales AS R
                           LEFT JOIN Trimestres AS Trim ON R.trimestre_id = Trim.id
                           ORDER BY R.año DESC"

        'Creamos el TableAdapter si no existe
        If Not Principal.tableadapters.ContainsKey(nombreDataSet) Then
            Principal.tableadapters.Add(nombreDataSet, New SqlCeDataAdapter(Principal.command))
        End If

        'Actualizamos el contenido de la tabla
        Principal.tableadapters(nombreDataSet).Fill(Principal.dataset.Tables.Item(nombreDataSet))

        'Asignamos el Bind
        Dim mybinding = New BindingSource(Principal.dataset, nombreDataSet)

        dgv.DataSource = mybinding

        crearColumnas(dgv)

        dgv.Columns("id").Visible = False

    End Sub

    Private Sub crearColumnas(ByRef dgv As DataGridView)

        Dim i As Integer = 0
        Dim array = New String() {"Ingresos - Gastos", "Ingresos", "Egresos Seccional", "Egresos Central"}

        Do
            Dim column As New DataGridViewButtonColumn
            With column
                .HeaderText = array(i)
                .Text = "Ver Reporte"
                .DataPropertyName = array(i)
                .UseColumnTextForButtonValue = True
            End With
            dgv.Columns.Add(column)
            i = i + 1
        Loop While i <= 3

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

End Module
