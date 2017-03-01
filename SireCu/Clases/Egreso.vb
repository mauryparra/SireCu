Imports System.Data.SqlServerCe

Module Egreso

    Public Sub nuevo_egreso()

    End Sub

    Public Sub modificar_egreso()

    End Sub

    Public Sub eliminar_egreso()

    End Sub

    Public Function mostrar_egreso()

    End Function

    Public Sub CargardDGV(ByRef dgv As DataGridView)
        Dim cmd = New SqlCeCommand
        Dim con = New SqlCeConnection(My.Settings.CadenaConexion)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        cmd.CommandText = "SELECT E.id AS id,
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
        cmd.Connection = con
        Dim tableadapter = New SqlCeDataAdapter(cmd)
        Dim dataset = New DataSet

        tableadapter.Fill(dataset, "Egresos_Modificar")
        Dim mybinding = New BindingSource(dataset, "Egresos_Modificar")


        dgv.DataSource = mybinding

        dgv.Columns.Item("id").HeaderText = "Id"
        dgv.Columns.Item("nro_comprobante").HeaderText = "Nro Comprobante"
        dgv.Columns.Item("tipo_comprobante_nombre").HeaderText = "Tipo Comprobante"
        dgv.Columns.Item("proveedor_nombre").HeaderText = "Proveedor"
        dgv.Columns.Item("categoria_nombre").HeaderText = "Categoria Gasto"
        dgv.Columns.Item("persona_nombre").HeaderText = "Persona"
        dgv.Columns.Item("fecha").HeaderText = "Fecha"
        dgv.Columns.Item("seccional_nombre").HeaderText = "Seccional"
        dgv.Columns.Item("mes_reintegro").HeaderText = "Mes Reintegro"
        dgv.Columns.Item("monto").HeaderText = "Monto"
        dgv.Columns.Item("comentario").HeaderText = "Comentario"

        dgv.Columns.Item("tipo_comprobante_id").Visible = False
        dgv.Columns.Item("proveedor_id").Visible = False
        dgv.Columns.Item("categoria_gasto_id").Visible = False
        dgv.Columns.Item("persona_id").Visible = False
        dgv.Columns.Item("seccional_id").Visible = False


    End Sub

End Module
