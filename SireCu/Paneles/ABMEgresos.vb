Imports System.ComponentModel
Imports System.Data.SqlServerCe

Public Class ABMEgresos

    Dim ControlesConErroresAgregar As List(Of Control) = New List(Of Control)
    Dim ControlesConErroresModificar As List(Of Control) = New List(Of Control)

    Dim idModificando As Integer = 0
    Dim idPapelera As Integer = 0


#Region "TAB Agregar - Eventos"

    Dim CamposObligatios As List(Of Control) = New List(Of Control)

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        ' Verificacion de campos obligatorios completos
        For Each control As Control In CamposObligatios
            If TypeOf (control) Is TextBox Then
                If control.Text = "" Then
                    Principal.ErrorProvider.SetError(control, "Debe completar el campo")
                    ControlesConErroresAgregar.Add(control)
                End If
            End If
            If TypeOf (control) Is ComboBox Then
                Dim combo As ComboBox = control
                If combo.SelectedIndex = -1 Then
                    Principal.ErrorProvider.SetError(control, "Debe Seleccionar una item")
                    ControlesConErroresAgregar.Add(control)
                End If
            End If
        Next

        'Verificamos que todos los campos hayan pasado las validaciones
        If ControlesConErroresAgregar.Count > 0 Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        'Verificar Saldo Disponible 
        Dim saldo As Double
        Select Case DatePart(DateInterval.Month, dtpFecha.Value)
            Case 1 To 3
                saldo = SaldoActual("Primero", DatePart(DateInterval.Year, dtpFecha.Value))
            Case 4 To 6
                saldo = SaldoActual("Segundo", DatePart(DateInterval.Year, dtpFecha.Value))
            Case 7 To 9
                saldo = SaldoActual("Tercero", DatePart(DateInterval.Year, dtpFecha.Value))
            Case 10 To 12
                saldo = SaldoActual("Cuarto", DatePart(DateInterval.Year, dtpFecha.Value))
            Case Else
                MsgBox("Número de Mes Incorrecto", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
        End Select

        If (saldo < tbMonto.Text) Then
            If (MsgBox("Su saldo es insuficiente." & vbCrLf & "Desea guardar de todas formas?", MsgBoxStyle.YesNo, "Saldo Insuficiente") = MsgBoxResult.No) Then
                Exit Sub
            End If
        End If

        Dim comprobante As String
        If (tbPVenta.Text = "0") Or (tbPVenta.Text = "") Then
            comprobante = tbNComprobante.Text
        Else
            comprobante = tbPVenta.Text & "-" & tbNComprobante.Text
        End If
        Dim reintegro As Date
        If dtpReintegro.Checked Then
            reintegro = dtpReintegro.Value.Date
        Else reintegro = dtpFecha.Value.Date
        End If


        ' GUARDAR
        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Guardar?") = MsgBoxResult.Ok) Then

            nuevo_egreso(
                         comprobante,
                         obtenerID(tbProveedor.Text, "Proveedores"),
                         cbTGasto.SelectedValue,
                         obtenerID(tbNombre.Text, "Personas"),
                         dtpFecha.Value.Date,
                         cbTComprobante.SelectedValue,
                         cbSeccional.SelectedValue,
                         reintegro,
                         CDbl(tbMonto.Text),
                         tbComentario.Text
                        )

            limpiarForm(TabPageAgregar)
            dtpReintegro.Checked = False
            CargardDGV(DGVModificar)
            ActualizarSaldo()
        End If

    End Sub

#End Region

#Region "TAB Modificar - Eventos"

    Private Sub DataGridViewModificar_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVModificar.CellMouseDoubleClick
        ' Cargar el formulario con los datos para modificar
        Try
            idModificando = CInt(DGVModificar.Rows(e.RowIndex).Cells("id").Value)

            TextBoxNombre.Text = DGVModificar.Rows(e.RowIndex).Cells("persona_nombre").Value
            ComboBoxCategGasto.SelectedValue = DGVModificar.Rows(e.RowIndex).Cells("categoria_gasto_id").Value
            TextBoxProveedor.Text = DGVModificar.Rows(e.RowIndex).Cells("proveedor_nombre").Value
            If DGVModificar.Rows(e.RowIndex).Cells("mes_reintegro").Value Is DBNull.Value Then
                DateTimePickerMesReintegro.Value = CDate(DGVModificar.Rows(e.RowIndex).Cells("fecha").Value)
                DateTimePickerMesReintegro.Checked = False
            Else
                If DGVModificar.Rows(e.RowIndex).Cells("mes_reintegro").Value = DGVModificar.Rows(e.RowIndex).Cells("fecha").Value Then
                    DateTimePickerMesReintegro.Value = CDate(DGVModificar.Rows(e.RowIndex).Cells("mes_reintegro").Value)
                    DateTimePickerMesReintegro.Checked = False
                Else
                    DateTimePickerMesReintegro.Value = CDate(DGVModificar.Rows(e.RowIndex).Cells("mes_reintegro").Value)
                    DateTimePickerMesReintegro.Checked = True
                End If
            End If
            ComboBoxSeccional.SelectedValue = DGVModificar.Rows(e.RowIndex).Cells("seccional_id").Value
            TextBoxComentario.Text = DGVModificar.Rows(e.RowIndex).Cells("comentario").Value.ToString
            DateTimePickerFecha.Value = CDate(DGVModificar.Rows(e.RowIndex).Cells("fecha").Value)
            ComboBoxTipoComprobante.SelectedValue = DGVModificar.Rows(e.RowIndex).Cells("tipo_comprobante_id").Value
            If DGVModificar.Rows(e.RowIndex).Cells("nro_comprobante").Value.ToString.Contains("-") Then
                TextBoxPVenta.Text = DGVModificar.Rows(e.RowIndex).Cells("nro_comprobante").Value.ToString.Split("-")(0)
                TextBoxNroComprobante.Text = DGVModificar.Rows(e.RowIndex).Cells("nro_comprobante").Value.ToString.Split("-")(1)
            Else
                TextBoxPVenta.Text = "0"
                TextBoxNroComprobante.Text = DGVModificar.Rows(e.RowIndex).Cells("nro_comprobante").Value
            End If
            TextBoxMonto.Text = DGVModificar.Rows(e.RowIndex).Cells("monto").Value
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar el formulario", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        activarModificar(True)

    End Sub

    Private Sub DGVModificar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVModificar.CellContentClick
        If e.ColumnIndex = 1 Then
            Dim id As Integer = DGVModificar.Rows(e.RowIndex).Cells("id").Value
            Dim seleccionado As Integer
            If DGVModificar.Rows(e.RowIndex).Cells("seleccionado").Value = 0 Then
                seleccionado = 1
            Else
                seleccionado = 0
            End If

            Dim sql As String = "UPDATE Egresos SET seleccionado = " & seleccionado & " WHERE id = " & id
            If consultarNQ(sql, Principal.command) < 1 Then
                MsgBox("Error al actualizar la selección", MsgBoxStyle.Exclamation, "Actualizar selección de egreso")
            Else
                DGVModificar.Rows(e.RowIndex).Cells("seleccionado").Value = seleccionado
            End If
        End If
    End Sub

    Private Sub DGVModificar_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DGVModificar.RowPostPaint

        Dim dgvRow As DataGridViewRow = DGVModificar.Rows(e.RowIndex)

        If dgvRow.Cells(1).Value = False Then
            dgvRow.DefaultCellStyle.BackColor = Color.LavenderBlush
        ElseIf dgvRow.Cells(1).Value = True Then
            dgvRow.DefaultCellStyle.BackColor = Color.Honeydew
        End If

    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click

        'Verificamos que todos los campos hayan pasado las validaciones
        If ControlesConErroresModificar.Count > 0 Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        'Verificar Saldo Disponible 
        Dim saldo As Double
        Select Case DatePart(DateInterval.Month, DateTimePickerFecha.Value)
            Case 1 To 3
                saldo = SaldoActual("Primero", DatePart(DateInterval.Year, DateTimePickerFecha.Value))
            Case 4 To 6
                saldo = SaldoActual("Segundo", DatePart(DateInterval.Year, DateTimePickerFecha.Value))
            Case 7 To 9
                saldo = SaldoActual("Tercero", DatePart(DateInterval.Year, DateTimePickerFecha.Value))
            Case 10 To 12
                saldo = SaldoActual("Cuarto", DatePart(DateInterval.Year, DateTimePickerFecha.Value))
        End Select

        If (saldo < TextBoxMonto.Text) Then
            If (MsgBox("Su saldo es insuficiente." & vbCrLf & "Desea guardar de todas formas?", MsgBoxStyle.YesNo, "Saldo Insuficiente") = MsgBoxResult.No) Then
                Exit Sub
            End If
        End If

        Dim comprobante As String
        If (TextBoxPVenta.Text = 0) Or (TextBoxPVenta.Text = "") Then
            comprobante = TextBoxNroComprobante.Text
        Else
            comprobante = TextBoxPVenta.Text & "-" & TextBoxNroComprobante.Text
        End If
        Dim reintegro As Date
        If DateTimePickerMesReintegro.Checked Then
            reintegro = DateTimePickerMesReintegro.Value.Date
        Else reintegro = DateTimePickerFecha.Value.Date
        End If


        ' MODIFICAR
        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Guardar?") = MsgBoxResult.Ok) Then

            modificar_egreso(
                         idModificando,
                         comprobante,
                         obtenerID(TextBoxProveedor.Text, "Proveedores"),
                         ComboBoxCategGasto.SelectedValue,
                         obtenerID(TextBoxNombre.Text, "Personas"),
                         DateTimePickerFecha.Value.Date,
                         ComboBoxTipoComprobante.SelectedValue,
                         ComboBoxSeccional.SelectedValue,
                         reintegro,
                         CDec(TextBoxMonto.Text),
                         TextBoxComentario.Text
                         )

            idModificando = 0
            limpiarForm(SplitContainerModificar.Panel2)
            activarModificar(False)
            CargardDGV(DGVModificar)
            ActualizarSaldo()
        End If

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Eliminar?") = MsgBoxResult.Ok) Then

            eliminar_egreso_soft(idModificando)

            idModificando = 0
            limpiarForm(SplitContainerModificar.Panel2)
            activarModificar(False)
            CargardDGV(DGVModificar)
            CargardDGV(DGVPapelera, 1, "Egresos_Papelera")
            ActualizarSaldo()
        End If
    End Sub

    Private Sub TSButtonFiltrar_Click(sender As Object, e As EventArgs) Handles TSButtonFiltrar.Click
        Dim filtros As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))
        Dim sql As String = ""

        ' Se guardan todos los filtros activos para crear el SQL
        If Not TSComboBoxTrimestre.SelectedItem = "" Then
            filtros.Add(New KeyValuePair(Of String, String)("trimestre", TSComboBoxTrimestre.SelectedItem))
        End If

        If Not TSTextBoxAño.Text = "" Then
            filtros.Add(New KeyValuePair(Of String, String)("año", TSTextBoxAño.Text))
        End If

        If Not (TSComboBoxFiltro1.SelectedItem = "" Or TSTextBoxFiltro1.Text = "") Then
            filtros.Add(New KeyValuePair(Of String, String)(TSComboBoxFiltro1.SelectedItem, TSTextBoxFiltro1.Text))
        End If

        ' SQL Basico
        sql = "SELECT TOP (500) E.id AS id,
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
                                  E.comentario AS comentario,
                                  E.seleccionado AS seleccionado
                           FROM Egresos AS E
                           LEFT JOIN TiposComprobantes AS Comp ON E.tipo_comprobante_id = Comp.id
                           LEFT JOIN Proveedores AS Pro ON E.proveedor_id = Pro.id
                           LEFT JOIN CategoriasGastos AS Gastos ON E.categoria_gasto_id = Gastos.id
                           LEFT JOIN Personas AS Per ON E.persona_id = Per.id
                           LEFT JOIN Seccionales AS Secc ON E.seccional_id = Secc.id
                           WHERE E.eliminado = 0"

        ' Aplicar Filtros al SQL
        For Each keyv As KeyValuePair(Of String, String) In filtros

            ' Filtrar por trimestre
            If keyv.Key = "trimestre" Then
                Select Case keyv.Value
                    Case "Primero"
                        sql += " AND DATEPART(month, [fecha]) BETWEEN 1 AND 3"
                    Case "Segundo"
                        sql += " AND DATEPART(month, [fecha]) BETWEEN 4 AND 6"
                    Case "Tercero"
                        sql += " AND DATEPART(month, [fecha]) BETWEEN 7 AND 9"
                    Case "Cuarto"
                        sql += " AND DATEPART(month, [fecha]) BETWEEN 10 AND 12"
                    Case Else
                        Exit Select
                End Select

            ElseIf keyv.Key = "año" Then

                ' Filtrar por año
                sql += " AND DATEPART(year, [fecha]) = " & keyv.Value

            Else

                ' Filtros adicionales
                Select Case keyv.Key
                    Case "Id"
                        sql += " AND E.id = " & keyv.Value
                    Case "Nro Comprobante"
                        sql += " AND E.nro_comprobante = '" & keyv.Value & "'"
                    Case "Tipo Comprobante"
                        sql += " AND Comp.nombre = '" & keyv.Value & "'"
                    Case "Proveedor"
                        sql += " AND Pro.nombre = '" & keyv.Value & "'"
                    Case "Categoria Gasto"
                        sql += " AND Gastos.nombre = '" & keyv.Value & "'"
                    Case "Persona"
                        sql += " AND Per.nombre = '" & keyv.Value & "'"
                    Case "Fecha"
                        sql += " AND E.fecha = " & keyv.Value
                    Case "Seccional"
                        sql += " AND Secc.nombre = '" & keyv.Value & "'"
                    Case "Mes Reintegro"
                        sql += " AND E.mes_reintegro = " & keyv.Value
                    Case "Monto"
                        sql += " AND E.monto = " & keyv.Value
                    Case "Comentario"
                        sql += " AND E.comentario = '" & keyv.Value & "'"
                    Case "Seleccionado"
                        sql += " AND E.seleccionado = " & keyv.Value
                    Case Else
                        Exit Select
                End Select
            End If
        Next

        sql += " ORDER BY E.id DESC"

        FiltrarDGV(DGVModificar, sql)

    End Sub

#End Region

#Region "TAB Papelera - Eventos"
    Private Sub DGVPapelera_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVPapelera.CellMouseDoubleClick
        ' Asignar el id a restaurar
        idPapelera = CInt(DGVPapelera.Rows(e.RowIndex).Cells("PapeleraId").Value)
        bPapeleraRestaurar.Enabled = True
        bPapeleraEliminar.Enabled = True

    End Sub

    Private Sub bPapeleraRestaurar_Click(sender As Object, e As EventArgs) Handles bPapeleraRestaurar.Click
        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Restaurar?") = MsgBoxResult.Ok) Then

            restaurar_egreso(idPapelera)

            idPapelera = 0
            CargardDGV(DGVPapelera, 1, "Egresos_Papelera")
            CargardDGV(DGVModificar)
            ActualizarSaldo()
            bPapeleraRestaurar.Enabled = False
            bPapeleraEliminar.Enabled = False
        End If
    End Sub

    Private Sub bPapeleraEliminar_Click(sender As Object, e As EventArgs) Handles bPapeleraEliminar.Click
        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Eliminar Permanentemente?") = MsgBoxResult.Ok) Then

            eliminar_egreso_hard(idPapelera)

            idPapelera = 0
            CargardDGV(DGVPapelera, 1, "Egresos_Papelera")
            CargardDGV(DGVModificar)
            ActualizarSaldo()
            bPapeleraRestaurar.Enabled = False
            bPapeleraEliminar.Enabled = False
        End If
    End Sub

    Private Sub bPapeleraVaciarPapelera_Click(sender As Object, e As EventArgs) Handles bPapeleraVaciarPapelera.Click
        If (MsgBox("Está seguro? Esta opción no se puede deshacer!", MsgBoxStyle.OkCancel, "Vaciar Papelera?") = MsgBoxResult.Ok) Then

            vaciar_papelera()

            idPapelera = 0
            CargardDGV(DGVPapelera, 1, "Egresos_Papelera")
            CargardDGV(DGVModificar)
            ActualizarSaldo()
            bPapeleraRestaurar.Enabled = False
            bPapeleraEliminar.Enabled = False
        End If
    End Sub

#End Region

#Region "Eventos"

    Private Sub ABMEgresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ######################################## TAB Agregar

        '               Campos Obligatorios
        CamposObligatios.AddRange({tbNombre,
                                   cbTGasto,
                                   cbTComprobante,
                                   tbProveedor,
                                   tbNComprobante,
                                   tbMonto,
                                   cbSeccional})

        dtpFecha.Value = Now
        dtpReintegro.Value = Now
        dtpReintegro.Checked = False
        '               Autocomplete al escribir
        tbProveedor.AutoCompleteCustomSource = autocomplete("Proveedores", "nombre")
        tbNombre.AutoCompleteCustomSource = autocomplete("Personas", "nombre")
        cbTGasto.AutoCompleteCustomSource = autocomplete("CategoriasGastos", "nombre")
        cbTComprobante.AutoCompleteCustomSource = autocomplete("TiposComprobantes", "nombre")
        cbSeccional.AutoCompleteCustomSource = autocomplete("Seccionales", "nombre")
        '               Colección de Items
        cbTGasto.DataSource = Principal.dataset.Tables("CategoriasGastos")
        cbTComprobante.DataSource = Principal.dataset.Tables("TiposComprobantes")
        cbSeccional.DataSource = Principal.dataset.Tables("Seccionales")
        cbTGasto.ValueMember = "id"
        cbTGasto.DisplayMember = "nombre"
        cbTComprobante.ValueMember = "id"
        cbTComprobante.DisplayMember = "nombre"
        cbSeccional.ValueMember = "id"
        cbSeccional.DisplayMember = "nombre"


        ' ######################################## TAB Modificar

        activarModificar(False)
        CargardDGV(DGVModificar)

        '               Autocomplete al escribir
        TextBoxNombre.AutoCompleteCustomSource = autocomplete("Personas", "nombre")
        ComboBoxCategGasto.AutoCompleteCustomSource = autocomplete("CategoriasGastos", "nombre")
        TextBoxProveedor.AutoCompleteCustomSource = autocomplete("Proveedores", "nombre")
        ComboBoxSeccional.AutoCompleteCustomSource = autocomplete("Seccionales", "nombre")
        ComboBoxTipoComprobante.AutoCompleteCustomSource = autocomplete("TiposComprobantes", "nombre")
        '               Colección de Items
        ComboBoxCategGasto.DataSource = Principal.dataset.Tables("CategoriasGastos")
        ComboBoxSeccional.DataSource = Principal.dataset.Tables("Seccionales")
        ComboBoxTipoComprobante.DataSource = Principal.dataset.Tables("TiposComprobantes")
        ComboBoxCategGasto.ValueMember = "id"
        ComboBoxCategGasto.DisplayMember = "nombre"
        ComboBoxSeccional.ValueMember = "id"
        ComboBoxSeccional.DisplayMember = "nombre"
        ComboBoxTipoComprobante.ValueMember = "id"
        ComboBoxTipoComprobante.DisplayMember = "nombre"
        '               Setup Panel
        DateTimePickerMesReintegro.Value = Now
        DateTimePickerFecha.Value = Now


        ' ######################################## TAB Papelera
        CargardDGV(DGVPapelera, 1, "Egresos_Papelera")

    End Sub

#End Region

#Region "Helpers"

    Private Function obtenerID(ByVal Campo_a_comparar As String, ByVal tabla As String) As Integer
        Dim id As Integer = -1

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
            ButtonEliminar.Enabled = True
        Else
            For Each control As Control In SplitContainerModificar.Panel2.Controls
                If TypeOf control Is TextBox Or TypeOf control Is ComboBox Or TypeOf control Is DateTimePicker Then
                    control.Enabled = False
                End If
            Next
            ButtonGuardar.Enabled = False
            ButtonEliminar.Enabled = False
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

    'Keypress
    Private Sub tbDay_KeyPress(sender As Object, e As KeyPressEventArgs)
        keyverify(e, numeros:=True)
    End Sub
    Private Sub tbTGasto_KeyPress(sender As Object, e As KeyPressEventArgs)
        keyverify(e, letras:=True)
    End Sub
    Private Sub tbMonth_KeyPress(sender As Object, e As KeyPressEventArgs)
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
        keyverify(e, letras:=True, numeros:=True, espacios:=True)
    End Sub
    Private Sub tbPVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPVenta.KeyPress
        keyverify(e, numeros:=True)
    End Sub
    Private Sub tbReintegro_KeyPress(sender As Object, e As KeyPressEventArgs)
        keyverify(e, numeros:=True)
    End Sub
    Private Sub tbTComprobante_KeyPress(sender As Object, e As KeyPressEventArgs)
        keyverify(e, letras:=True, espacios:=True)
    End Sub
    Private Sub tbSeccional_KeyPress(sender As Object, e As KeyPressEventArgs)
        keyverify(e, letras:=True, numeros:=True, espacios:=True)
    End Sub

    'Validating
    Private Sub tbNombre_Validating(sender As Object, e As CancelEventArgs) Handles tbNombre.Validating
        If (sender.Text = "") Or (exist("Personas", "nombre", sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Persona correcta." & vbCrLf &
                                             "Puede agregar una nueva en el menú Editar")
            ControlesConErroresAgregar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresAgregar.Remove(sender)
        End If
    End Sub
    Private Sub cbTGasto_Validating(sender As Object, e As CancelEventArgs) Handles cbTGasto.Validating
        ' Verifica que haya un item seleccionado y corresponda a la colección de opciones
        If (sender.Text = "") Or (cbTGasto.AutoCompleteCustomSource.Contains(sender.Text) = False) Then
            Dim var As String = cbTGasto.SelectedText
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Categoría correcta." & vbCrLf &
                                             "Puede agregar una nueva en el menú Editar")
            ControlesConErroresAgregar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresAgregar.Remove(sender)
        End If
    End Sub

    Private Sub tbProveedor_Validating(sender As Object, e As CancelEventArgs) Handles tbProveedor.Validating
        If (sender.Text = "") Or (exist("Proveedores", "nombre", sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Proveedor correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en el menú Editar")
            ControlesConErroresAgregar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresAgregar.Remove(sender)
        End If
    End Sub
    Private Sub cbTComprobante_Validating(sender As Object, e As CancelEventArgs) Handles cbTComprobante.Validating
        ' Verifica que haya un item seleccionado y corresponda a la colección de opciones
        If (sender.Text = "") Or (cbTComprobante.AutoCompleteCustomSource.Contains(sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Tipo de Comprobante correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en el menú Editar")
            ControlesConErroresAgregar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresAgregar.Remove(sender)
        End If
    End Sub
    Private Sub tbMonto_Validating(sender As Object, e As CancelEventArgs) Handles tbMonto.Validating
        If Not IsNumeric(sender.Text) Or IsDBNull(sender.Text) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un valor numérico o cero")
            ControlesConErroresAgregar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresAgregar.Remove(sender)
        End If
    End Sub
    Private Sub cbSeccional_Validating(sender As Object, e As CancelEventArgs) Handles cbSeccional.Validating
        ' Verifica que haya un item seleccionado y corresponda a la colección de opciones
        If (sender.Text = "") Or (cbSeccional.AutoCompleteCustomSource.Contains(sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Seccional correcta." & vbCrLf &
                                             "Puede agregar una nueva en el menú Editar")
            ControlesConErroresAgregar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresAgregar.Remove(sender)
        End If
    End Sub
    Private Sub tbNComprobante_Validating(sender As Object, e As CancelEventArgs) Handles tbNComprobante.Validating
        Dim comprobante As String
        If (tbPVenta.Text = "0") Or (tbPVenta.Text = "") Then
            comprobante = tbNComprobante.Text
        Else
            comprobante = tbPVenta.Text & "-" & tbNComprobante.Text
        End If
        If (sender.text = "") Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar número de comprobante")
            ControlesConErroresAgregar.Add(sender)
            Exit Sub
        ElseIf (obtenerID(tbProveedor.Text, "Proveedores") = -1) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Proveedor correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en el menú Editar")
            ControlesConErroresAgregar.Add(sender)
            Exit Sub
        ElseIf (comprobante_repetido(comprobante, obtenerID(tbProveedor.Text, "Proveedores"))) Then
            Principal.ErrorProvider.SetError(sender, "Ese comprobante ya fué cargado para ese Proveedor")
            ControlesConErroresAgregar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresAgregar.Remove(sender)
        End If
    End Sub

#End Region

#Region "Validaciones TAB Modificar"

    'Keypress
    Private Sub TextBoxMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxMonto.KeyPress
        keyverify(e, numeros:=True, comas:=True, puntosAComas:=True)
    End Sub
    Private Sub TextBoxNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNombre.KeyPress
        keyverify(e, letras:=True, numeros:=True, espacios:=True)
    End Sub
    Private Sub TextBoxNroComprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNroComprobante.KeyPress
        keyverify(e, numeros:=True)
    End Sub
    Private Sub TextBoxProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxProveedor.KeyPress
        keyverify(e, letras:=True, numeros:=True, espacios:=True)
    End Sub
    Private Sub TextBoxPVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPVenta.KeyPress
        keyverify(e, numeros:=True)
    End Sub
    Private Sub ComboBoxCategGasto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxCategGasto.KeyPress
        keyverify(e, letras:=True)
    End Sub
    Private Sub ComboBoxSeccional_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxSeccional.KeyPress
        keyverify(e, letras:=True, numeros:=True, espacios:=True)
    End Sub
    Private Sub ComboBoxTipoComprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxTipoComprobante.KeyPress
        keyverify(e, letras:=True, espacios:=True)
    End Sub

    'Validating
    Private Sub TextBoxNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxNombre.Validating
        If (sender.Text = "") Or (exist("Personas", "nombre", sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Persona correcta." & vbCrLf &
                                             "Puede agregar una nueva en el menú Editar")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub TextBoxProveedor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxProveedor.Validating
        If (sender.Text = "") Or (exist("Proveedores", "nombre", sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Proveedor correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en el menú Editar")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub TextBoxMonto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxMonto.Validating
        If Not IsNumeric(sender.Text) Or IsDBNull(sender.Text) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un valor numérico o cero")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub TextBoxNroComprobante_Validating(sender As Object, e As CancelEventArgs) Handles TextBoxNroComprobante.Validating
        Dim comprobante As String
        If (TextBoxPVenta.Text = 0) Or (TextBoxPVenta.Text = "") Then
            comprobante = TextBoxNroComprobante.Text
        Else
            comprobante = TextBoxPVenta.Text & "-" & TextBoxNroComprobante.Text
        End If
        If (sender.text = "") Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar número de comprobante")
            ControlesConErroresModificar.Add(sender)
            Exit Sub
        ElseIf (obtenerID(TextBoxProveedor.Text, "Proveedores") = -1) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Proveedor correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en el menú Editar")
            ControlesConErroresModificar.Add(sender)
            Exit Sub
        ElseIf (comprobante_repetido(comprobante, obtenerID(tbProveedor.Text, "Proveedores"))) Then
            Principal.ErrorProvider.SetError(sender, "Ese comprobante ya fué cargado para ese Proveedor")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub ComboBoxSeccional_Validating(sender As Object, e As CancelEventArgs) Handles ComboBoxSeccional.Validating
        If (sender.Text = "") Or (ComboBoxSeccional.AutoCompleteCustomSource.Contains(sender.text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Seccional correcta." & vbCrLf &
                                             "Puede agregar una nueva en el menú Editar")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub ComboBoxTipoComprobante_Validating(sender As Object, e As CancelEventArgs) Handles ComboBoxTipoComprobante.Validating
        If (sender.Text = "") Or (ComboBoxTipoComprobante.AutoCompleteCustomSource.Contains(sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Tipo de Comprobante correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en el menú Editar")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub ComboBoxCategGasto_Validating(sender As Object, e As CancelEventArgs) Handles ComboBoxCategGasto.Validating
        If (sender.Text = "") Or (ComboBoxCategGasto.AutoCompleteCustomSource.Contains(sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Categoría correcta." & vbCrLf &
                                             "Puede agregar una nueva en el menú Editar")
            ControlesConErroresModificar.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub

    Private Sub TSTextBoxFiltro1_Validating(sender As Object, e As CancelEventArgs) Handles TSTextBoxFiltro1.Validating
        ' TODO validación segun tipo de campo seleccionado
    End Sub
#End Region

End Class