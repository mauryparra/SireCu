Imports System.ComponentModel
Imports System.Data.SqlServerCe

Public Class ABMEgresos

    Dim ControlesConErroresAgregar As List(Of Control) = New List(Of Control)
    Dim ControlesConErroresModificar As List(Of Control) = New List(Of Control)

    Dim idModificando As Integer = 0


#Region "TAB Agregar - Eventos"

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Verificamos que todos los campos hayan pasado las validaciones
        If ControlesConErroresAgregar.Count > 0 Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        'Verificar Saldo Disponible 'OPTIMIZAR TODO
        Dim saldo As Double
        Select Case tbMonth.Text
            Case 1 To 3
                saldo = SaldoActual("Primero", tbYear.Text)
            Case 4 To 6
                saldo = SaldoActual("Segundo", tbYear.Text)
            Case 7 To 9
                saldo = SaldoActual("Tercero", tbYear.Text)
            Case 10 To 12
                saldo = SaldoActual("Cuarto", tbYear.Text)
        End Select

        If (saldo < tbMonto.Text) Then
            If (MsgBox("Su saldo es insuficiente." & vbCrLf & "Desea guardar de todas formas?", MsgBoxStyle.YesNo, "Saldo Insuficiente") = MsgBoxResult.No) Then
                Exit Sub
            End If
        End If

        Dim comprobante As String = tbPVenta.Text & "-" & tbNComprobante.Text
        Dim fecha As Date = tbDay.Text & "/" & tbMonth.Text & "/" & tbYear.Text
        Dim reintegro As Date
        If tbReintegro.Text = "" Then
            reintegro = fecha
        Else reintegro = "01" & "/" & tbReintegro.Text & "/" & tbYear.Text
        End If


        ' GUARDAR
        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Guardar?") = MsgBoxResult.Ok) Then

            nuevo_egreso(
                         comprobante,
                         obtenerID(tbProveedor.Text, "Proveedores"),
                         obtenerID(tbTGasto.Text, "CategoriasGastos"),
                         obtenerID(tbNombre.Text, "Personas"),
                         fecha,
                         obtenerID(tbTComprobante.Text, "TiposComprobantes"),
                         obtenerID(tbSeccional.Text, "Seccionales"),
                         reintegro,
                         CDbl(tbMonto.Text),
                         tbComentario.Text
                        )

            limpiarForm(TabPageAgregar)

        End If

    End Sub
    Private Sub tbYear_DoubleClick(sender As Object, e As EventArgs) Handles tbYear.DoubleClick
        tbYear.ReadOnly = False
    End Sub
    Private Sub tbYear_Leave(sender As Object, e As EventArgs) Handles tbYear.Leave
        tbYear.ReadOnly = True
    End Sub

#End Region

#Region "TAB Modificar - Eventos"

    Private Sub DataGridViewModificar_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewModificar.CellMouseDoubleClick
        ' Cargar el formulario con los datos para modificar
        Try
            idModificando = CInt(DataGridViewModificar.Rows(e.RowIndex).Cells("id").Value)

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
    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click

        'Preguntamos si esta seguro
        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Guardar?") = MsgBoxResult.Ok) Then

            ' Verificamos que todos los campos hayan pasado las validaciones
            If ControlesConErroresModificar.Count > 0 Then
                MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            Else

                ' TODO Verificar si Persona existe si no preguntar si desea agregarlo
                If obtenerID(TextBoxNombre.Text, "Personas") = -1 Then
                    If (MsgBox("Desea agregar a la Persona:" & TextBoxNombre.Text, MsgBoxStyle.OkCancel, "Agregar Persona") = MsgBoxResult.Ok) Then
                        ' TODO Insert nueva Persona

                    Else
                        Exit Sub
                    End If
                End If

                ' TODO Verificar si proveedor existe si no preguntar si desea agregarlo
                If obtenerID(TextBoxProveedor.Text, "Proveedores") = -1 Then
                    If (MsgBox("Desea agregar al Proveedor:" & TextBoxProveedor.Text, MsgBoxStyle.OkCancel, "Agregar Proveedor") = MsgBoxResult.Ok) Then
                        ' TODO Insert nuevo Proveedor

                    Else
                        Exit Sub
                    End If
                End If

                ' TODO Verificar si hay saldo para egreso

                ' Actualizar Egreso
                Dim comprobante As String = ""
                If TextBoxPVenta.Text = 0 Then
                    comprobante = TextBoxNroComprobante.Text
                Else
                    comprobante = TextBoxPVenta.Text & "-" & TextBoxNroComprobante.Text
                End If
                modificar_egreso(idModificando, comprobante, obtenerID(TextBoxProveedor.Text, "Proveedores"),
                                 ComboBoxCategGasto.SelectedValue, obtenerID(TextBoxNombre.Text, "Personas"), DateTimePickerFecha.Value,
                                 ComboBoxTipoComprobante.SelectedValue, ComboBoxSeccional.SelectedValue, DateTimePickerMesReintegro.Value,
                                 CDec(TextBoxMonto.Text), TextBoxComentario.Text)

                idModificando = 0

                limpiarForm(SplitContainerModificar.Panel2)
                activarModificar(False)
                CargardDGV(DataGridViewModificar)

            End If
        Else
            Exit Sub
        End If
    End Sub

#End Region

#Region "Eventos"

    Private Sub ABMEgresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TAB Agregar
        '               Usamos el año mas grande de la base de datos
        tbYear.Text = ultimoaño("Egresos")
        '               Colección de Items
        addColección(tbTGasto, "CategoriasGastos")
        addColección(tbTComprobante, "TiposComprobantes")
        addColección(tbSeccional, "Seccionales")
        '               Autocomplete al escribir
        tbProveedor.AutoCompleteCustomSource = autocomplete("Proveedores", "nombre")
        tbNombre.AutoCompleteCustomSource = autocomplete("Personas", "nombre")
        tbTGasto.AutoCompleteCustomSource = autocomplete("CategoriasGastos", "nombre")
        tbTComprobante.AutoCompleteCustomSource = autocomplete("TiposComprobantes", "nombre")
        tbSeccional.AutoCompleteCustomSource = autocomplete("Seccionales", "nombre")

        ' TAB Modificar
        activarModificar(False)
        Egreso.CargardDGV(DataGridViewModificar)
        TextBoxNombre.AutoCompleteCustomSource = autocomplete("Personas", "nombre")
        ComboBoxCategGasto.AutoCompleteCustomSource = autocomplete("CategoriasGastos", "nombre")
        ComboBoxCategGasto.DataSource = Principal.dataset.Tables("CategoriasGastos")
        ComboBoxCategGasto.ValueMember = "id"
        ComboBoxCategGasto.DisplayMember = "nombre"
        TextBoxProveedor.AutoCompleteCustomSource = autocomplete("Proveedores", "nombre")
        DateTimePickerMesReintegro.Value = Now
        ComboBoxSeccional.AutoCompleteCustomSource = autocomplete("Seccionales", "nombre")
        ComboBoxSeccional.DataSource = Principal.dataset.Tables("Seccionales")
        ComboBoxSeccional.ValueMember = "id"
        ComboBoxSeccional.DisplayMember = "nombre"
        DateTimePickerFecha.Value = Now
        ComboBoxTipoComprobante.AutoCompleteCustomSource = autocomplete("TiposComprobantes", "nombre")
        ComboBoxTipoComprobante.DataSource = Principal.dataset.Tables("TiposComprobantes")
        ComboBoxTipoComprobante.ValueMember = "id"
        ComboBoxTipoComprobante.DisplayMember = "nombre"


    End Sub

#End Region

#Region "Helpers"

    Private Function obtenerID(ByVal Campo_a_comparar As String, ByVal tabla As String) As Integer
        Dim id As Integer = -1

        cargarTablaEnDataSet(tabla)

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
                If TypeOf control Is TextBox Or TypeOf control Is ComboBox Or TypeOf control Is DateTimePicker Then
                    control.Enabled = True
                End If
            Next
            ButtonGuardar.Enabled = True
        Else
            For Each control As Control In SplitContainerModificar.Panel2.Controls
                If TypeOf control Is TextBox Or TypeOf control Is ComboBox Or TypeOf control Is DateTimePicker Then
                    control.Enabled = False
                End If
            Next
            ButtonGuardar.Enabled = False
        End If
    End Sub

    ' Limpia los campos de todos los controles dentro de un contenedor
    Private Sub limpiarForm(ByRef contenedor As Object)
        For Each control As Object In contenedor.Controls
            ' Limpia los textbox
            If TypeOf (control) Is TextBox Then
                control.Text = ""
            End If

            ' Datetimepicker quedan con la fecha actual
            If TypeOf (control) Is DateTimePicker Then
                control.Value = Now
            End If

            ' Resetea selección en combobox
            If TypeOf (control) Is ComboBox Then
                control.SelectedItem = ""
                control.text = ""
            End If
        Next
    End Sub

#End Region

#Region "Validaciones TAB Agregar"

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
        keyverify(e, letras:=True, numeros:=True, espacios:=True)
    End Sub
    Private Sub tbProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbProveedor.KeyPress
        keyverify(e, letras:=True, numeros:=True)
    End Sub
    Private Sub tbPVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPVenta.KeyPress
        keyverify(e, numeros:=True)
    End Sub
    Private Sub tbReintegro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbReintegro.KeyPress
        keyverify(e, numeros:=True)
    End Sub
    Private Sub tbTComprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTComprobante.KeyPress
        keyverify(e, letras:=True, espacios:=True)
    End Sub
    Private Sub tbYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbYear.KeyPress
        keyverify(e, numeros:=True)
        If e.KeyChar = ChrW(Keys.Enter) Then
            tbYear.ReadOnly = True
            tbTGasto.Focus()
        End If
    End Sub
    Private Sub tbSeccional_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSeccional.KeyPress
        keyverify(e, letras:=True, numeros:=True, espacios:=True)
    End Sub

    Private Sub tbNombre_Validating(sender As Object, e As CancelEventArgs) Handles tbNombre.Validating
        If (sender.Text = "") Or (exist("Personas", "nombre", sender.text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Persona correcta." & vbCrLf &
                                             "Puede agregar una nueva en el menú Editar")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub tbTGasto_Validating(sender As Object, e As CancelEventArgs) Handles tbTGasto.Validating
        If (sender.Text = "") Or (exist("CategoriasGastos", "nombre", sender.text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Categoría correcta." & vbCrLf &
                                             "Puede agregar una nueva en el menú Editar")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub tbProveedor_Validating(sender As Object, e As CancelEventArgs) Handles tbProveedor.Validating
        If (sender.Text = "") Or (exist("Proveedores", "nombre", sender.text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Proveedor correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en el menú Editar")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub tbTComprobante_Validating(sender As Object, e As CancelEventArgs) Handles tbTComprobante.Validating
        If (sender.Text = "") Or (exist("TiposComprobantes", "nombre", sender.text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Tipo de Comprobante correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en el menú Editar")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub tbMonto_Validating(sender As Object, e As CancelEventArgs) Handles tbMonto.Validating
        If Not IsNumeric(sender.Text) Or IsDBNull(sender.Text) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un valor numérico o cero")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub tbReintegro_Validating(sender As Object, e As CancelEventArgs) Handles tbReintegro.Validating
        If sender.text = "" Then
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
            Exit Sub
        End If

        If (CDbl(sender.Text) < 1) Or (CDbl(sender.Text) > 12) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un mes de reintegro válido")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub tbSeccional_Validating(sender As Object, e As CancelEventArgs) Handles tbSeccional.Validating
        If (sender.Text = "") Or (exist("Seccionales", "nombre", sender.text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Seccional correcta." & vbCrLf &
                                             "Puede agregar una nueva en el menú Editar")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub tbNComprobante_Validating(sender As Object, e As CancelEventArgs) Handles tbNComprobante.Validating
        If (sender.text = "") Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar número de comprobante")
            ControlesConErroresModificar.Add(sender)
            Exit Sub
        ElseIf (obtenerID(tbProveedor.Text, "Proveedores") = -1) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Proveedor correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en el menú Editar")
            ControlesConErroresModificar.Add(sender)
            Exit Sub
        ElseIf (comprobante_repetido(tbPVenta.Text & "-" & tbNComprobante.Text, obtenerID(tbProveedor.Text, "Proveedores"))) Then
            Principal.ErrorProvider.SetError(sender, "Ese comprobante ya fué cargado para ese Proveedor")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub tbYear_Validating(sender As Object, e As CancelEventArgs) Handles tbYear.Validating
        If Not IsNumeric(sender.Text) Or IsDBNull(sender.Text) Or (tbYear.Text = "") Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Año válido")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub

#End Region

#Region "Validaciones TAB Modificar"

    Private Sub TextBoxNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxNombre.Validating
        If sender.Text = "" Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un nombre")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub

    Private Sub TextBoxProveedor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxProveedor.Validating
        If sender.Text = "" Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un nombre")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub

    Private Sub TextBoxMonto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxMonto.Validating
        If Not IsNumeric(sender.Text) Or IsDBNull(sender.Text) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un valor numérico o 0")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub

    Private Sub TextBoxMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMonto.KeyPress
        keyverify(e, numeros:=True, comas:=True, puntosAComas:=True)
    End Sub





#End Region

End Class