Imports System.ComponentModel

Public Class Otros_AMB

    Public tabla As String

#Region "Botones"
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        dgv_otros.Enabled = True
        tb_editar.Text = ""
        cb_tabla.Enabled = True
        btn_Guardar.Text = "Guardar" & vbCrLf & "Nuevo"
    End Sub
    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click

        'Verificación de tabla correcta
        If (verificarTabla() = 0) Then
            MsgBox("Por favor, seleccione una opción correcta", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        'Verificacion de campos vacios
        If (tb_editar.Text = "") Or (cb_tabla.Text = "") Then
            MsgBox("Por favor, complete todos los campos", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If


        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Guardar?") = MsgBoxResult.Ok) Then

            If (btn_Guardar.Text = "Guardar Nuevo") Then

                'Verificación de registro repetido
                If (exist(tabla, "nombre", tb_editar.Text) = True) Then
                    MsgBox("Ese " & cb_tabla.Text & " ya se encuentra cargado", MsgBoxStyle.Exclamation, "Error")
                    Exit Sub
                End If
                Principal.query = "INSERT INTO [" & tabla & "] ([nombre]) VALUES (@nombre)"

            ElseIf (btn_Guardar.Text = "Actualizar") Then

                Principal.query = "UPDATE " & tabla & " SET [nombre] = @nombre WHERE id=@id "
                Principal.command.Parameters.AddWithValue("@id", dgv_otros.CurrentRow.Cells(0).Value)

                dgv_otros.Enabled = True
                cb_tabla.Enabled = True
                btn_Guardar.Text = "Guardar Nuevo"

            End If

            Principal.command.Parameters.AddWithValue("@nombre", tb_editar.Text)
            consultarNQ(Principal.query, Principal.command)

            Principal.command.Parameters.Clear()

            MsgBox("Guardado Correctamente!", MsgBoxStyle.Information, "Guardado")
            tb_editar.Text = ""
            actualizar()

        End If

    End Sub
    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click

        'Verificacion de selección
        If dgv_otros.SelectedCells.Count = 0 Then
            MsgBox("Por favor seleccione un registro", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If (verificarTabla() = 0) Then
            MsgBox("Por favor, seleccione una opción correcta", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If (MsgBox("Eliminar registro?", MsgBoxStyle.OkCancel, "Eliminar?") = MsgBoxResult.Ok) Then

            Principal.query = "DELETE FROM [" & tabla & "] WHERE id = @id"
            Principal.command.Parameters.AddWithValue("@id", dgv_otros.CurrentRow.Cells(0).Value)
            consultarNQ(Principal.query, Principal.command)

            Principal.command.Parameters.Clear()

            MsgBox("Eliminado correctamente", MsgBoxStyle.Information, "Eliminado")
            tb_editar.Text = ""
            actualizar()

        End If

    End Sub
#End Region

#Region "Otros"
    Private Sub dgv_otros_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_otros.CellMouseDoubleClick
        tb_editar.Text = dgv_otros.CurrentRow.Cells(1).Value
        dgv_otros.Enabled = False
        cb_tabla.Enabled = False
        btn_Guardar.Text = "Actualizar"
    End Sub
    Private Sub Otros_AMB_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        dgv_otros.DataSource = Nothing
    End Sub
    Private Sub cb_tabla_TextChanged(sender As Object, e As EventArgs) Handles cb_tabla.TextChanged
        actualizar()
    End Sub
    Private Sub actualizar()
        Select Case cb_tabla.Text
            Case "Proveedor"
                abm_otros("Proveedores")
            Case "Tipo de Comprobante"
                abm_otros("TiposComprobantes")
            Case "Tipo de Gasto"
                abm_otros("CategoriasGastos")
            Case "Persona"
                abm_otros("Personas")
        End Select
    End Sub
    Private Sub Otros_AMB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case cb_tabla.Text
            Case "Proveedor"
                tabla = "Proveedores"
            Case "Tipo de Comprobante"
                tabla = "TiposComprobantes"
            Case "Tipo de Gasto"
                tabla = "CategoriasGastos"
            Case "Persona"
                tabla = "Personas"
        End Select
    End Sub
    Private Function verificarTabla()
        If (tabla <> "Proveedores") And (tabla <> "TiposComprobantes") And (tabla <> "CategoriasGastos") And (tabla <> "Personas") Then
            Return (0)
        Else Return (1)
        End If
    End Function
#End Region

#Region "Validaciones"
    Private Sub cb_tabla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_tabla.KeyPress
        keyverify(e, letras:=True, espacios:=True)
    End Sub
    Private Sub tb_editar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_editar.KeyPress
        keyverify(e, letras:=True, espacios:=True)
    End Sub
#End Region

End Class