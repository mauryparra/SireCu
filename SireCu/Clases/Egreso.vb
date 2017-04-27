Imports System.Data.SqlServerCe

Module Egreso

    Public Sub nuevo_egreso(ByVal compro As String, ByVal proveedor As String, ByVal categoria As String, ByVal persona As String,
    ByVal fecha As Date, ByVal tipo_comp As String, ByVal secc As String, ByVal reintegro As Date, ByVal monto As Double,
                            ByVal comentario As String)
        Principal.query = "INSERT INTO egresos (nro_comprobante, proveedor_id, categoria_gasto_id, persona_id, " &
            "fecha, tipo_comprobante_id, seccional_id, mes_reintegro, monto, comentario, eliminado)" &
                              "VALUES (@nro_comprobante, @proveedor, @cat_gasto, @persona, @fecha, @t_comprobante, " &
                                "@seccional, @reintegro, @monto, @comentario, 0)"
        Principal.command.Parameters.Clear()
        Principal.command.Parameters.AddWithValue("@nro_comprobante", compro)
        Principal.command.Parameters.AddWithValue("@proveedor", proveedor)
        Principal.command.Parameters.AddWithValue("@cat_gasto", categoria)
        Principal.command.Parameters.AddWithValue("@persona", persona)
        Principal.command.Parameters.AddWithValue("@fecha", fecha)
        Principal.command.Parameters.AddWithValue("@t_comprobante", tipo_comp)
        Principal.command.Parameters.AddWithValue("@seccional", secc)
        Principal.command.Parameters.AddWithValue("@reintegro", reintegro)
        Principal.command.Parameters.AddWithValue("@monto", monto)
        Principal.command.Parameters.AddWithValue("@comentario", comentario)

        consultarNQ(Principal.query, Principal.command)
    End Sub

    Public Sub modificar_egreso(ByVal id As Integer, ByVal compro As String, ByVal proveedor As Integer, ByVal categoria As Integer,
                                ByVal persona As Integer, ByVal fecha As Date, ByVal tipo_comp As Integer, ByVal secc As Integer,
                                ByVal reintegro As Date, ByVal monto As Decimal, ByVal comentario As String)

        Principal.query = "UPDATE Egresos SET nro_comprobante = @nro_comprobante, proveedor_id = @proveedor, categoria_gasto_id = @cat_gasto, " &
                            "persona_id = @persona, fecha = @fecha, tipo_comprobante_id = @t_comprobante, seccional_id = @seccional, " &
                            "mes_reintegro = @reintegro, monto = @monto, comentario = @comentario " &
                            "WHERE id = @id"
        Principal.command.Parameters.Clear()
        Principal.command.Parameters.AddWithValue("@nro_comprobante", compro)
        Principal.command.Parameters.AddWithValue("@proveedor", proveedor)
        Principal.command.Parameters.AddWithValue("@cat_gasto", categoria)
        Principal.command.Parameters.AddWithValue("@persona", persona)
        Principal.command.Parameters.AddWithValue("@fecha", fecha)
        Principal.command.Parameters.AddWithValue("@t_comprobante", tipo_comp)
        Principal.command.Parameters.AddWithValue("@seccional", secc)
        Principal.command.Parameters.AddWithValue("@reintegro", reintegro)
        Principal.command.Parameters.AddWithValue("@monto", monto)
        Principal.command.Parameters.AddWithValue("@comentario", comentario)
        Principal.command.Parameters.AddWithValue("@id", id)

        If consultarNQ(Principal.query, Principal.command) > 0 Then
            MsgBox("Egreso modificado exitosamente", MsgBoxStyle.OkOnly, "Guardar Cambios")
        Else
            MsgBox("Ocurrio un error al guardar los cambios", MsgBoxStyle.Exclamation, "Guardar Cambios")
        End If
    End Sub

    Public Sub eliminar_egreso(ByVal id As Integer)
        Principal.query = "UPDATE Egresos SET eliminado = 1 WHERE id = @id"
        Principal.command.Parameters.Clear()
        Principal.command.Parameters.AddWithValue("@id", id)

        If consultarNQ(Principal.query, Principal.command) > 0 Then
            MsgBox("Egreso eliminado exitosamente", MsgBoxStyle.OkOnly, "Eliminar Egreso")
        Else
            MsgBox("Ocurrio un error al eliminar el egreso", MsgBoxStyle.Exclamation, "Eliminar Egreso")
        End If
    End Sub

    Public Sub restaurar_egreso(ByVal id As Integer)
        Principal.query = "UPDATE Egresos SET eliminado = 0 WHERE id = @id"
        Principal.command.Parameters.Clear()
        Principal.command.Parameters.AddWithValue("@id", id)

        If consultarNQ(Principal.query, Principal.command) > 0 Then
            MsgBox("Egreso restaurado exitosamente", MsgBoxStyle.OkOnly, "Restaurar Egreso")
        Else
            MsgBox("Ocurrio un error al restaurar el egreso", MsgBoxStyle.Exclamation, "Restaurar Egreso")
        End If
    End Sub

    Public Sub CargardDGV(ByRef dgv As DataGridView, Optional ByVal eliminado As Integer = 0, Optional ByVal nombreDataSet As String = "Egresos_Modificar")

        'Creamos la tabla si no existe
        If Not Principal.dataset.Tables.Contains(nombreDataSet) Then
            Principal.dataset.Tables.Add(nombreDataSet)
        End If
        'Limpiamos la tabla
        Principal.dataset.Tables(nombreDataSet).Clear()

        'Creamos el query
        Principal.command.CommandText = "SELECT E.id AS id,
                                  E.nro_comprobante AS nro_comprobante,
                                  E.tipo_comprobante_id AS tipo_comprobante_id,
                                  Comp.nombre AS tipo_comprobante_nombre,
                                  E.proveedor_id AS proveedor_id,
                                  Pro.nombre AS proveedor_nombre,
                                  E.categoria_gasto_id AS categoria_gasto_id,
                                  Gastos.nombre AS categoria_nombre,
                                  E.persona_id AS persona_id,
                                  Per.nombre AS persona_nombre,
                                  E.fecha AS fecha,
                                  E.seccional_id AS seccional_id,
                                  Secc.nombre AS seccional_nombre,
                                  E.mes_reintegro AS mes_reintegro,
                                  E.monto AS monto,
                                  E.comentario AS comentario
                           FROM Egresos AS E
                           LEFT JOIN TiposComprobantes AS Comp ON E.tipo_comprobante_id = Comp.id
                           LEFT JOIN Proveedores AS Pro ON E.proveedor_id = Pro.id
                           LEFT JOIN CategoriasGastos AS Gastos ON E.categoria_gasto_id = Gastos.id
                           LEFT JOIN Personas AS Per ON E.persona_id = Per.id
                           LEFT JOIN Seccionales AS Secc ON E.seccional_id = Secc.id
                           WHERE E.eliminado = " & eliminado

        'Creamos el TableAdapter si no existe
        If Not Principal.tableadapters.ContainsKey(nombreDataSet) Then
            Principal.tableadapters.Add(nombreDataSet, New SqlCeDataAdapter(Principal.command))
        End If

        'Actualizamos el contenido de la tabla
        Principal.tableadapters(nombreDataSet).Fill(Principal.dataset.Tables.Item(nombreDataSet))

        'Asignamos el Bind
        Dim mybinding = New BindingSource(Principal.dataset, nombreDataSet)

        dgv.AutoGenerateColumns = False

        dgv.Columns.Item(0).DataPropertyName = "id"
        dgv.Columns.Item(1).DataPropertyName = "nro_comprobante"
        dgv.Columns.Item(2).DataPropertyName = "tipo_comprobante_id"
        dgv.Columns.Item(3).DataPropertyName = "tipo_comprobante_nombre"
        dgv.Columns.Item(4).DataPropertyName = "proveedor_id"
        dgv.Columns.Item(5).DataPropertyName = "proveedor_nombre"
        dgv.Columns.Item(6).DataPropertyName = "categoria_gasto_id"
        dgv.Columns.Item(7).DataPropertyName = "categoria_nombre"
        dgv.Columns.Item(8).DataPropertyName = "persona_id"
        dgv.Columns.Item(9).DataPropertyName = "persona_nombre"
        dgv.Columns.Item(10).DataPropertyName = "fecha"
        dgv.Columns.Item(11).DataPropertyName = "seccional_id"
        dgv.Columns.Item(12).DataPropertyName = "seccional_nombre"
        dgv.Columns.Item(13).DataPropertyName = "mes_reintegro"
        dgv.Columns.Item(14).DataPropertyName = "monto"
        dgv.Columns.Item(15).DataPropertyName = "comentario"
        dgv.DataSource = mybinding

    End Sub

    Public Function comprobante_repetido(ByVal nComprobante As String, ByVal proveedorID As Integer)

        cargarTablaEnDataSet("Egresos")

        Dim flag As Boolean = False

        For i = 0 To Principal.dataset.Tables("Egresos").Rows.Count - 1
            If (Principal.dataset.Tables("Egresos").Rows.Item(i).Item("nro_comprobante") = nComprobante) And
               (Principal.dataset.Tables("Egresos").Rows.Item(i).Item("proveedor_id") = proveedorID) Then
                flag = True
            End If
        Next

        Return flag

    End Function

End Module
