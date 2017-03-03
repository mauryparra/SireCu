Imports System.Data.SqlServerCe

Module Egreso

    Public Sub nuevo_egreso(ByVal compro As String, ByVal proveedor As String, ByVal categoria As String, ByVal persona As String,
    ByVal fecha As Date, ByVal tipo_comp As String, ByVal secc As String, ByVal reintegro As Date, ByVal monto As Double,
                            ByVal comentario As String)
        Principal.query = "INSERT INTO egresos (nro_comprobante, proveedor_id, categoria_gasto_id, persona_id, " &
            "fecha, tipo_comprobante_id, seccional_id, mes_reintegro, monto, comentario)" &
                              "VALUES (@nro_comprobante, @proveedor, @cat_gasto, @persona, @fecha, @t_comprobante, " &
                                "@seccional, @reintegro, @monto, @comentario)"
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

End Module
