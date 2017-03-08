Imports System.Data.SqlServerCe

Public Class ABMEgresos


#Region "Eventos"
    Private Sub ABMEgresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Tab Agregar
        tbNombre.Focus()
        'usamos el año mas grande de la base de datos
        tbYear.Text = ultimoaño("Egresos")

        tbProveedor.AutoCompleteCustomSource = autocomplete("Proveedores", "nombre")
        tbNombre.AutoCompleteCustomSource = autocomplete("Personas", "nombre")
        tbTGasto.AutoCompleteCustomSource = autocomplete("CategoriasGastos", "nombre")
        tbTComprobante.AutoCompleteCustomSource = autocomplete("TiposComprobantes", "nombre")

        ' Tab Modificar
        activarModificar(False)
        Egreso.CargardDGV(DataGridViewModificar)
        TextBoxNombre.AutoCompleteCustomSource = autocomplete("Personas", "nombre")
        ComboBoxCategGasto.AutoCompleteCustomSource = autocomplete("CategoriasGastos", "nombre")
        ComboBoxCategGasto.DataSource = Principal.dataset.Tables("CategoriasGastos")
        ComboBoxCategGasto.Enabled = True
        ComboBoxCategGasto.ValueMember = "id"
        ComboBoxCategGasto.DisplayMember = "nombre"
        TextBoxProveedor.AutoCompleteCustomSource = autocomplete("Proveedores", "nombre")
        DateTimePickerMesReintegro.Value = Now
        ComboBoxSeccional.AutoCompleteCustomSource = autocomplete("Seccionales", "nombre")
        DateTimePickerFecha.Value = Now
        ComboBoxTipoComprobante.AutoCompleteCustomSource = autocomplete("TiposComprobantes", "nombre")


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Preguntamos si esta seguro
        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Guardar?") = MsgBoxResult.Ok) Then

            'Verificamos que todos los campos hayan pasado las validaciones ' TODO
            'If ControlesConErrores.Count > 0 Then
            '    MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
            '    Exit Sub
            'Else

            'Verificar Tipo de Gasto válido 'TODO
            'Verificar Fecha válida(y mes de reintegro) 'TODO
            Dim fecha As Date = tbDay.Text & "/" & tbMonth.Text & "/" & tbYear.Text
            Dim reintegro As Date
            If tbReintegro.Text = "" Then
                reintegro = fecha
            Else reintegro = "01" & "/" & tbMonth.Text & "/" & tbYear.Text
            End If

            'Verificar Comprobante Repetido ' TODO
            'Verificar Saldo Disponible ' TODO

            Dim comprobante As String = tbPVenta.Text & "-" & tbNComprobante.Text
            Dim seccional As String
            If ckCentral.Checked = True Then
                seccional = ckCentral.Text
            ElseIf ckLarioja.Checked = True Then
                seccional = ckLarioja.Text
            Else
                MsgBox("Por favor seleccione una seccional", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            End If

            ' GUARDAR
            nuevo_egreso(
                         comprobante,
                         obtenerID(tbProveedor.Text, "Proveedores"),
                         obtenerID(tbTGasto.Text, "CategoriasGastos"),
                         obtenerID(tbNombre.Text, "Personas"),
                         fecha,
                         obtenerID(tbTComprobante.Text, "TiposComprobantes"),
                         obtenerID(seccional, "Seccionales"),
                         reintegro,
                         CDbl(tbMonto.Text),
                         tbComentario.Text
                        )

        End If

        ''Else
        'Exit Sub
        'End If
    End Sub

    Private Sub DataGridViewModificar_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewModificar.CellMouseDoubleClick
        ' Cargar el formulario con los datos para modificar
        Try
            TextBoxNombre.Text = DataGridViewModificar.Rows(e.RowIndex).Cells("persona_nombre").Value
            ComboBoxCategGasto.SelectedItem = DataGridViewModificar.Rows(e.RowIndex).Cells("categoria_nombre").Value
            TextBoxProveedor.Text = DataGridViewModificar.Rows(e.RowIndex).Cells("proveedor_nombre").Value
            If DataGridViewModificar.Rows(e.RowIndex).Cells("mes_reintegro").Value Is DBNull.Value Then
                DateTimePickerMesReintegro.Value = CDate(DataGridViewModificar.Rows(e.RowIndex).Cells("fecha").Value)
            Else
                DateTimePickerMesReintegro.Value = CDate(DataGridViewModificar.Rows(e.RowIndex).Cells("mes_reintegro").Value)
            End If
            ComboBoxSeccional.SelectedItem = DataGridViewModificar.Rows(e.RowIndex).Cells("seccional_nombre").Value
            TextBoxComentario.Text = DataGridViewModificar.Rows(e.RowIndex).Cells("comentario").Value.ToString
            DateTimePickerFecha.Value = CDate(DataGridViewModificar.Rows(e.RowIndex).Cells("fecha").Value)
            ComboBoxTipoComprobante.SelectedItem = DataGridViewModificar.Rows(e.RowIndex).Cells("tipo_comprobante_nombre").Value
            If DataGridViewModificar.Rows(e.RowIndex).Cells("nro_comprobante").Value.ToString.Contains("-") Then
                TextBoxPVenta.Text = DataGridViewModificar.Rows(e.RowIndex).Cells("nro_comprobante").Value.ToString.Split("-")(0)
                TextBoxNroComprobante.Text = DataGridViewModificar.Rows(e.RowIndex).Cells("nro_comprobante").Value.ToString.Split("-")(1)
            Else
                TextBoxPVenta.Text = "0"
                TextBoxNroComprobante.Text = DataGridViewModificar.Rows(e.RowIndex).Cells("nro_comprobante").Value
            End If
            TextBoxMonto.Text = DataGridViewModificar.Rows(e.RowIndex).Cells("monto").Value
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar el formulario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        activarModificar(True)

    End Sub

#End Region

#Region "Helpers"
    Public Function autocomplete(ByVal tabla As String, ByVal Campo_a_Mostrar As String)

        Dim coleccion As New AutoCompleteStringCollection

        Principal.query = "SELECT * FROM " & tabla
        consultarNQ(Principal.query, Principal.command)
        Principal.adapter = New SqlCeDataAdapter(Principal.command)
        Principal.adapter.Fill(Principal.dataset.Tables(tabla))

        For Each row As DataRow In Principal.dataset.Tables(tabla).Rows
            coleccion.Add(Convert.ToString(row.Item(Campo_a_Mostrar)))
        Next

        '        Administrativos
        '        Alquileres
        '        Bancarios
        '        Coparticipación
        '        Desenvolvimiento
        '        Filiales
        '        Franqueo y Encomiendas
        'Honorarios
        '        Impuestos y servicios
        'Librería e impresiones
        'Seguros
        '        Movilidad y traslado
        'Prensa y difusión
        'Prestaciones
        '        Subsidios



        '        Factura A
        'Factura B
        'Factura C
        'Recibo A
        'Recibo B
        'Recibo C
        'Recibo X
        'Tique Fact.A
        'Tique Fact.B
        'Tique Fact.C
        'Tique
        '        Pasaje
        '        Extracto Bancario
        'Otro

        Return (coleccion)

    End Function

    Private Function obtenerID(ByVal Campo_a_comparar As String, ByVal tabla As String)
        Dim id As Integer = -1

        Principal.query = "SELECT * FROM " & tabla
        consultarNQ(Principal.query, Principal.command)
        Principal.adapter = New SqlCeDataAdapter(Principal.command)
        Principal.adapter.Fill(Principal.dataset.Tables(tabla))

        For Each row As DataRow In Principal.dataset.Tables(tabla).Rows
            If (LCase(row.Item("nombre")) = LCase(Campo_a_comparar)) Then
                id = row.Item("id")
            End If
        Next



        Return (id)

    End Function

    ' Activa o desactiva la modificación de un Egreso
    Private Sub activarModificar(ByVal activar As Boolean)
        If activar Then
            For Each control As Control In SplitContainerModificar.Panel2.Controls
                If TypeOf control Is TextBox Or TypeOf control Is ComboBox Then
                    control.Enabled = True
                End If
            Next
            ButtonGuardar.Enabled = True
        Else
            For Each control As Control In SplitContainerModificar.Panel2.Controls
                If TypeOf control Is TextBox Or TypeOf control Is ComboBox Then
                    control.Enabled = False
                End If
            Next
            ButtonGuardar.Enabled = False
        End If
    End Sub

#End Region

#Region "Validaciones"

    Private Sub tbDay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDay.KeyPress
        keyverify(e, numeros:=True)
    End Sub
    Private Sub tbTGasto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTGasto.KeyPress
        keyverify(e, letras:=True)
    End Sub
    Private Sub tbMonth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMonth.KeyPress
        keyverify(e, numeros:=True)
    End Sub
    Private Sub tbMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMonto.KeyPress
        keyverify(e, numeros:=True, comas:=True, puntosAComas:=True)
    End Sub
    Private Sub tbNComprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNComprobante.KeyPress
        keyverify(e, numeros:=True)
    End Sub
    Private Sub tbNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNombre.KeyPress
        keyverify(e, letras:=True, numeros:=True)
    End Sub
    Private Sub tbProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbProveedor.KeyPress
        keyverify(e, letras:=True, numeros:=True)
    End Sub
    Private Sub tbPVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPVenta.KeyPress
        keyverify(e, numeros:=True)
    End Sub
    Private Sub tbReintegro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbReintegro.KeyPress
        keyverify(e, letras:=True)
    End Sub
    Private Sub tbTComprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTComprobante.KeyPress
        keyverify(e, letras:=True)
    End Sub
    Private Sub tbYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbYear.KeyPress
        keyverify(e, numeros:=True)
    End Sub
    Private Sub ckCentral_CheckedChanged(sender As Object, e As EventArgs) Handles ckCentral.CheckedChanged
        If ckLarioja.Checked = True Then
            ckCentral.Checked = False
        End If
    End Sub
    Private Sub ckLarioja_CheckedChanged(sender As Object, e As EventArgs) Handles ckLarioja.CheckedChanged
        If ckCentral.Checked = True Then
            ckLarioja.Checked = False
        End If
    End Sub

#End Region


End Class