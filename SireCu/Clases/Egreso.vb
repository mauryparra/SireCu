Imports System.Data.SqlServerCe

Module Egreso

    Public Sub nuevo_egreso(ByVal compro As String, ByVal proveedor As String, ByVal categoria As String, ByVal persona As String,
    ByVal fecha As Date, ByVal tipo_comp As String, ByVal secc As String, ByVal reintegro As Date, ByVal monto As Double,
                            ByVal comentario As String)
        Principal.query = "INSERT INTO egresos (nro_comprobante, proveedor_id, categoria_gasto_id, persona_id, " &
            "fecha, tipo_comprobante_id, seccional_id, mes_reintegro, monto, comentario)" &
                              "VALUES (@nro_comprobante, @proveedor, @cat_gasto, @persona, @fecha, @t_comprobante, " &
                                "@seccional, @reintegro, @monto, @comentario)"
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

    Public Sub modificar_egreso()

    End Sub

    Public Sub eliminar_egreso()

    End Sub

    Public Function mostrar_egreso()

    End Function

    Public Sub CargardDGV(ByRef dgv As DataGridView)
        Dim con = New SqlCeConnection(My.Settings.CadenaConexion)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

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
                           LEFT JOIN Seccionales AS Secc ON E.seccional_id = Secc.id"
        Principal.command.Connection = con
        Dim tableadapter = New SqlCeDataAdapter(Principal.command)

        tableadapter.Fill(Principal.dataset, "Egresos_Modificar")
        Dim mybinding = New BindingSource(Principal.dataset, "Egresos_Modificar")

        dgv.AutoGenerateColumns = False

        dgv.Columns.Item("id").DataPropertyName = "id"
        dgv.Columns.Item("nro_comprobante").DataPropertyName = "nro_comprobante"
        dgv.Columns.Item("tipo_comprobante_id").DataPropertyName = "tipo_comprobante_id"
        dgv.Columns.Item("tipo_comprobante_nombre").DataPropertyName = "tipo_comprobante_nombre"
        dgv.Columns.Item("proveedor_id").DataPropertyName = "proveedor_id"
        dgv.Columns.Item("proveedor_nombre").DataPropertyName = "proveedor_nombre"
        dgv.Columns.Item("categoria_gasto_id").DataPropertyName = "categoria_gasto_id"
        dgv.Columns.Item("categoria_nombre").DataPropertyName = "categoria_nombre"
        dgv.Columns.Item("persona_id").DataPropertyName = "persona_id"
        dgv.Columns.Item("persona_nombre").DataPropertyName = "persona_nombre"
        dgv.Columns.Item("fecha").DataPropertyName = "fecha"
        dgv.Columns.Item("seccional_id").DataPropertyName = "seccional_id"
        dgv.Columns.Item("seccional_nombre").DataPropertyName = "seccional_nombre"
        dgv.Columns.Item("mes_reintegro").DataPropertyName = "mes_reintegro"
        dgv.Columns.Item("monto").DataPropertyName = "monto"
        dgv.Columns.Item("comentario").DataPropertyName = "comentario"
        dgv.DataSource = mybinding




    End Sub

End Module
