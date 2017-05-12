Imports System.ComponentModel

Public Class Otros_AMB

    Dim tabla As String
    Dim ControlesConErrores As List(Of Control) = New List(Of Control)

#Region "Botones"
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        dgv_otros.Enabled = True
        tb_editar.Text = ""
        cb_tabla.Enabled = True
        btn_Cancelar.Enabled = False
        btn_Guardar.Text = "Guardar Nuevo"
    End Sub
    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click

        ' Verificamos que todos los campos hayan pasado las validaciones
        If ControlesConErrores.Count > 0 Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
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
            btn_Cancelar.Enabled = False

            'Actualizamos el Autocomplete de campos y el DataGridview
            actualizar()

        End If

    End Sub
    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click

        'Verificacion de selección
        If dgv_otros.SelectedCells.Count = 0 Then
            MsgBox("Por favor seleccione un registro", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If ControlesConErrores.Count > 0 Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
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
        btn_Cancelar.Enabled = True
    End Sub
    Private Sub Otros_AMB_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        dgv_otros.DataSource = Nothing
    End Sub
    Private Sub cb_tabla_TextChanged(sender As Object, e As EventArgs) Handles cb_tabla.TextChanged
        actualizar()

        'Sacamos el TB de la lista de errores
        Principal.ErrorProvider.SetError(tb_editar, "")
        ControlesConErrores.Remove(tb_editar)
    End Sub
    Private Sub actualizar()
        Select Case cb_tabla.Text
            Case "Proveedor"
                tabla = "Proveedores"
                abm_otros("Proveedores")
            Case "Tipo de Comprobante"
                tabla = "TiposComprobantes"
                abm_otros("TiposComprobantes")
            Case "Tipo de Gasto"
                tabla = "CategoriasGastos"
                abm_otros("CategoriasGastos")
            Case "Persona"
                tabla = "Personas"
                abm_otros("Personas")
            Case "Seccional"
                tabla = "Seccionales"
                abm_otros("Seccionales")
        End Select
    End Sub
    Private Sub Otros_AMB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar()
    End Sub
    Private Sub abm_otros(ByVal tabla As String)

        cargarTablaEnDataSet(tabla)

        Dim bindSource As New BindingSource
        bindSource.DataSource = Principal.dataset.Tables(tabla)
        dgv_otros.DataSource = bindSource
        dgv_otros.Columns.Item("id").Visible = False

        tb_editar.AutoCompleteCustomSource = autocomplete(tabla, "nombre")

    End Sub
#End Region

#Region "Validaciones"
    Private Sub cb_tabla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_tabla.KeyPress
        keyverify(e, letras:=True, espacios:=True)
    End Sub
    Private Sub tb_editar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_editar.KeyPress
        keyverify(e, letras:=True, espacios:=True, numeros:=True)
    End Sub

    Private Sub cb_tabla_Validating(sender As Object, e As CancelEventArgs) Handles cb_tabla.Validating
        If (cb_tabla.Text <> "Proveedor") And (cb_tabla.Text <> "Tipo de Comprobante") And
            (cb_tabla.Text <> "Tipo de Gasto") And (cb_tabla.Text <> "Persona") And (cb_tabla.Text <> "Seccional") Or
            IsDBNull(sender.Text) Or (cb_tabla.Text = "") Then

            Principal.ErrorProvider.SetError(sender, "Debe ingresar una opción válida")
            ControlesConErrores.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErrores.Remove(sender)
        End If
    End Sub
    Private Sub tb_editar_Validating(sender As Object, e As CancelEventArgs) Handles tb_editar.Validating
        If IsDBNull(sender.Text) Or (tb_editar.Text = "") Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un nombre válido")
            ControlesConErrores.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErrores.Remove(sender)
        End If
    End Sub

#End Region

End Class