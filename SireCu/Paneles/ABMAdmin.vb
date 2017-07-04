Public Class ABMAdmin

    Dim tabla As String
    Dim ControlesConErrores As List(Of Control) = New List(Of Control)

#Region "Eventos y Botones"
    Private Sub ABMAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar()
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        ' Verificamos que todos los campos hayan pasado las validaciones
        If ControlesConErrores.Count > 0 Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Guardar?") = MsgBoxResult.Ok) Then

            If (BGuardar.Text = "Guardar Nuevo") Then

                'Verificación de registro repetido
                If (exist(tabla, "nombre", TBModificar.Text) = True) Then
                    MsgBox("Ese " & CBTabla.Text & " ya se encuentra cargado", MsgBoxStyle.Exclamation, "Error")
                    Exit Sub
                End If
                Principal.query = "INSERT INTO [" & tabla & "] ([nombre]) VALUES (@nombre)"

            ElseIf (BGuardar.Text = "Actualizar") Then

                Principal.query = "UPDATE " & tabla & " SET [nombre] = @nombre WHERE id=@id "
                Principal.command.Parameters.AddWithValue("@id", DGVAdmin.CurrentRow.Cells(0).Value)

                DGVAdmin.Enabled = True
                CBTabla.Enabled = True
                BGuardar.Text = "Guardar Nuevo"

            End If

            Principal.command.Parameters.AddWithValue("@nombre", TBModificar.Text)
            consultarNQ(Principal.query, Principal.command)

            Principal.command.Parameters.Clear()

            MsgBox("Guardado Correctamente!", MsgBoxStyle.Information, "Guardado")
            TBModificar.Text = ""
            BCancelar.Enabled = False

            'Actualizamos el Autocomplete de campos y el DataGridview
            actualizar()

        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        'Verificacion de selección
        If DGVAdmin.SelectedCells.Count = 0 Then
            MsgBox("Por favor seleccione un registro", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If ControlesConErrores.Count > 0 Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If (MsgBox("Eliminar registro?", MsgBoxStyle.OkCancel, "Eliminar?") = MsgBoxResult.Ok) Then

            Principal.query = "DELETE FROM [" & tabla & "] WHERE id = @id"
            Principal.command.Parameters.AddWithValue("@id", DGVAdmin.CurrentRow.Cells(0).Value)
            consultarNQ(Principal.query, Principal.command)

            Principal.command.Parameters.Clear()

            MsgBox("Eliminado correctamente", MsgBoxStyle.Information, "Eliminado")
            TBModificar.Text = ""
            actualizar()

        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        DGVAdmin.Enabled = True
        TBModificar.Text = ""
        CBTabla.Enabled = True
        BCancelar.Enabled = False
        BGuardar.Text = "Guardar Nuevo"
    End Sub

    Private Sub DGVAdmin_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVAdmin.CellMouseDoubleClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then
            TBModificar.Text = DGVAdmin.CurrentRow.Cells(1).Value
            DGVAdmin.Enabled = False
            CBTabla.Enabled = False
            BGuardar.Text = "Actualizar"
            BCancelar.Enabled = True
        End If
    End Sub

    Private Sub CBTabla_TextChanged(sender As Object, e As EventArgs) Handles CBTabla.TextChanged
        actualizar()
        Principal.ErrorProvider.SetError(TBModificar, "")
        ControlesConErrores.Remove(TBModificar)
    End Sub
#End Region

#Region "Helpers"

    Private Sub actualizar()
        Select Case CBTabla.Text
            Case "Proveedor"
                tabla = "Proveedores"
                cargarDatos("Proveedores")
            Case "Tipo de Comprobante"
                tabla = "TiposComprobantes"
                cargarDatos("TiposComprobantes")
            Case "Tipo de Gasto"
                tabla = "CategoriasGastos"
                cargarDatos("CategoriasGastos")
            Case "Persona"
                tabla = "Personas"
                cargarDatos("Personas")
        End Select
    End Sub
    Private Sub cargarDatos(ByVal tabla As String)

        cargarTablaEnDataSet(tabla)

        Dim bindSource As New BindingSource
        bindSource.DataSource = Principal.dataset.Tables(tabla)
        DGVAdmin.DataSource = bindSource
        DGVAdmin.Columns.Item("id").Visible = False

        TBModificar.AutoCompleteCustomSource = autocomplete(tabla, "nombre")

    End Sub

#End Region

#Region "Validaciones"

    Private Sub CBTabla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBTabla.KeyPress
        keyverify(e, letras:=True, espacios:=True)
    End Sub

    Private Sub TBModificar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBModificar.KeyPress
        keyverify(e, letras:=True, espacios:=True, numeros:=True)
    End Sub

    Private Sub CBTabla_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CBTabla.Validating
        'TODO Revisar
        If (CBTabla.Text <> "Proveedor") And (CBTabla.Text <> "Tipo de Comprobante") And
            (CBTabla.Text <> "Tipo de Gasto") And (CBTabla.Text <> "Persona") Or
            IsDBNull(sender.Text) Or (CBTabla.Text = "") Then

            Principal.ErrorProvider.SetError(sender, "Debe ingresar una opción válida")
            If Not ControlesConErrores.Contains(sender) Then
                ControlesConErrores.Add(sender)
            End If
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErrores.Remove(sender)
        End If
    End Sub

    Private Sub TBModificar_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TBModificar.Validating
        If IsDBNull(sender.Text) Or (TBModificar.Text = "") Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un nombre válido")
            If Not ControlesConErrores.Contains(sender) Then
                ControlesConErrores.Add(sender)
            End If
        Else
                Principal.ErrorProvider.SetError(sender, "")
            ControlesConErrores.Remove(sender)
        End If
    End Sub

#End Region

End Class
