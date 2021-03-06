﻿Imports System.ComponentModel
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
        Dim saldo As Double = SaldoActual()

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
                         obtenerID("Proveedores", "nombre", tbProveedor.Text),
                         cbTGasto.SelectedValue,
                         obtenerID("Personas", "nombre", tbNombre.Text),
                         dtpFecha.Value.Date,
                         cbTComprobante.SelectedValue,
                         cbSeccional.SelectedValue,
                         reintegro,
                         CDbl(tbMonto.Text),
                         tbComentario.Text
                        )

            limpiarForm(GroupBoxAgregar)
            dtpReintegro.Checked = False
            CargardDGV(DGVModificar)
            ActualizarSaldo()
        End If

    End Sub

#End Region

#Region "TAB Modificar - Eventos"

    Private Sub DataGridViewModificar_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVModificar.CellMouseDoubleClick
        ' Cargar el formulario con los datos para modificar
        If e.RowIndex >= 0 Then ' Evita los encabezados de la tabla
            Try
                idModificando = CInt(DGVModificar.Rows(e.RowIndex).Cells("id").Value)

                TextBoxNombre.Text = DGVModificar.Rows(e.RowIndex).Cells("persona_nombre").Value
                ComboBoxCategGasto.Text = DGVModificar.Rows(e.RowIndex).Cells("categoria_nombre").Value
                TextBoxProveedor.Text = DGVModificar.Rows(e.RowIndex).Cells("proveedor_nombre").Value
                If DGVModificar.Rows(e.RowIndex).Cells("mes_reintegro").Value Is DBNull.Value Then
                    DateTimePickerMesReintegro.Value = CDate(DGVModificar.Rows(e.RowIndex).Cells("fecha").Value)
                    DateTimePickerMesReintegro.Checked = False
                Else
                    DateTimePickerMesReintegro.Value = CDate(DGVModificar.Rows(e.RowIndex).Cells("mes_reintegro").Value)
                    If DGVModificar.Rows(e.RowIndex).Cells("mes_reintegro").Value = DGVModificar.Rows(e.RowIndex).Cells("fecha").Value Then
                        DateTimePickerMesReintegro.Checked = False
                    Else
                        DateTimePickerMesReintegro.Checked = True
                    End If
                End If
                ComboBoxSeccional.Text = DGVModificar.Rows(e.RowIndex).Cells("seccional_nombre").Value
                TextBoxComentario.Text = DGVModificar.Rows(e.RowIndex).Cells("comentario").Value.ToString
                DateTimePickerFecha.Value = CDate(DGVModificar.Rows(e.RowIndex).Cells("fecha").Value)
                ComboBoxTipoComprobante.Text = DGVModificar.Rows(e.RowIndex).Cells("tipo_comprobante_nombre").Value
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
        End If

    End Sub

    Private Sub DGVModificar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVModificar.CellContentClick
        If e.ColumnIndex = 1 And e.RowIndex >= 0 Then
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

        If dgvRow.Cells(14).Value = "UDA Central" Then
            dgvRow.DefaultCellStyle.BackColor = Color.Honeydew
        End If

        If dgvRow.Cells(1).Value = True Then
            dgvRow.DefaultCellStyle.BackColor = Color.LightGray
        Else
            dgvRow.DefaultCellStyle.BackColor = Color.White
        End If

    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click

        'Verificamos que todos los campos hayan pasado las validaciones
        If ControlesConErroresModificar.Count > 0 Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        'Verificar Saldo Disponible 
        Dim saldo As Double = SaldoActual()

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
                         obtenerID("Proveedores", "nombre", TextBoxProveedor.Text),
                         ComboBoxCategGasto.SelectedValue,
                         obtenerID("Personas", "nombre", TextBoxNombre.Text),
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

        If Not TSComboBoxMes.SelectedItem = "" Then
            filtros.Add(New KeyValuePair(Of String, String)("mes", TSComboBoxMes.SelectedItem.ToString.Split(" ")(0)))
        End If

        If Not (TSComboBoxFiltro1.SelectedItem = "" Or TSTextBoxFiltro1.Text = "") Then
            filtros.Add(New KeyValuePair(Of String, String)(TSComboBoxFiltro1.SelectedItem & TSComboBoxOpera1.SelectedItem, TSTextBoxFiltro1.Text))
        End If

        If Not (TSComboBoxFiltro2.SelectedItem = "" Or TSTextBoxFiltro2.Text = "") Then
            filtros.Add(New KeyValuePair(Of String, String)(TSComboBoxFiltro2.SelectedItem & TSComboBoxOpera2.SelectedItem, TSTextBoxFiltro2.Text))
        End If

        ' SQL Basico
        sql = "SELECT E.id AS id,
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
                sql += " AND DATEPART(year, [mes_reintegro]) = " & keyv.Value

            ElseIf keyv.Key = "mes" Then

                ' Filtrar por mes
                sql += " AND DATEPART(month, [mes_reintegro]) = " & keyv.Value

            Else

                ' Filtros adicionales
                Select Case keyv.Key
                    Case "Nro ComprobanteIGUAL"
                        sql += " AND E.nro_comprobante = '" & keyv.Value & "'"
                    Case "Nro ComprobanteCONTIENE"
                        sql += " AND E.nro_comprobante LIKE '%" & keyv.Value & "%'"

                    Case "Tipo ComprobanteIGUAL"
                        sql += " AND Comp.nombre = '" & keyv.Value & "'"
                    Case "Tipo ComprobanteCONTIENE"
                        sql += " AND Comp.nombre LIKE '%" & keyv.Value & "%'"

                    Case "ProveedorIGUAL"
                        sql += " AND Pro.nombre = '" & keyv.Value & "'"
                    Case "ProveedorCONTIENE"
                        sql += " AND Pro.nombre LIKE '%" & keyv.Value & "%'"

                    Case "Categoria GastoIGUAL"
                        sql += " AND Gastos.nombre = '" & keyv.Value & "'"
                    Case "Categoria GastoCONTIENE"
                        sql += " AND Gastos.nombre LIKE '%" & keyv.Value & "%'"

                    Case "PersonaIGUAL"
                        sql += " AND Per.nombre = '" & keyv.Value & "'"
                    Case "PersonaCONTIENE"
                        sql += " AND Per.nombre LIKE '%" & keyv.Value & "%'"

                    Case "FechaIGUAL"
                    Case "FechaCONTIENE"
                        Dim fecha As Date
                        If Date.TryParse(keyv.Value, fecha) Then
                            sql += " AND E.fecha > '" & fecha.AddDays(-1).ToString("yyyy-MM-dd") & "' AND E.fecha < '" & fecha.AddDays(1).ToString("yyyy-MM-dd") & "'"
                        Else
                            MsgBox("No se pudo convertir el filtro a una fecha valida", MsgBoxStyle.Exclamation, "Filtrar")
                        End If

                    Case "SeccionalIGUAL"
                        sql += " AND Secc.nombre = '" & keyv.Value & "'"
                    Case "SeccionalCONTIENE"
                        sql += " AND Secc.nombre LIKE '%" & keyv.Value & "%'"

                    Case "Mes ReintegroIGUAL", "Mes ReintegroCONTIENE"
                        Dim fecha As Date
                        If Date.TryParse(keyv.Value, fecha) Then
                            sql += " AND DATEPART(month, E.mes_reintegro) = '" & fecha.Month & "' AND DATEPART(year, E.mes_reintegro) = '" & fecha.Year & "'"
                        Else
                            MsgBox("No se pudo convertir el filtro a una fecha valida", MsgBoxStyle.Exclamation, "Filtrar")
                        End If

                    Case "MontoIGUAL"
                        sql += " AND E.monto = '" & keyv.Value & "'"
                    Case "MontoCONTIENE"
                        sql += " AND E.monto LIKE '%" & keyv.Value & "%'"

                    Case "ComentarioIGUAL"
                        sql += " AND E.comentario = '" & keyv.Value & "'"
                    Case "ComentarioCONTIENE"
                        sql += " AND E.comentario LIKE '%" & keyv.Value & "%'"

                    Case "SeleccionadoIGUAL", "SeleccionadoCONTIENE"
                        sql += " AND E.seleccionado = " & keyv.Value
                    Case Else
                        Exit Select
                End Select
            End If
        Next

        sql += " ORDER BY E.id DESC"

        FiltrarDGV(DGVModificar, sql)

    End Sub
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        idModificando = 0
        limpiarForm(SplitContainerModificar.Panel2)
        activarModificar(False)
    End Sub
    Private Sub TSButtonQuitarFiltros_Click(sender As Object, e As EventArgs) Handles TSButtonQuitarFiltros.Click

        TSComboBoxTrimestre.SelectedIndex = -1
        TSTextBoxAño.Text = ""
        TSComboBoxFiltro1.SelectedIndex = -1
        TSComboBoxOpera1.SelectedIndex = 0
        TSTextBoxFiltro1.Text = ""
        TSComboBoxFiltro2.SelectedIndex = -1
        TSComboBoxOpera2.SelectedIndex = 0
        TSTextBoxFiltro2.Text = ""

        CargardDGV(DGVModificar)

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

        '               Mostramos los egresos del año corriente
        TSTextBoxAño.Text = Year(Now)
        TSButtonFiltrar_Click(TSButtonFiltrar, Nothing)

        ' ######################################## TAB Papelera
        CargardDGV(DGVPapelera, 1, "Egresos_Papelera")

    End Sub

#End Region

#Region "Helpers"

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
            btn_Cancelar.Enabled = True
        Else
            For Each control As Control In SplitContainerModificar.Panel2.Controls
                If TypeOf control Is TextBox Or TypeOf control Is ComboBox Or TypeOf control Is DateTimePicker Then
                    control.Enabled = False
                End If
            Next
            ButtonGuardar.Enabled = False
            ButtonEliminar.Enabled = False
            btn_Cancelar.Enabled = False
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
                                             "Puede agregar una nueva en la seccion Administrar")
            If Not ControlesConErroresAgregar.Contains(sender) Then
                ControlesConErroresAgregar.Add(sender)
            End If
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresAgregar.Remove(sender)
        End If
    End Sub
    Private Sub cbTGasto_Validating(sender As Object, e As CancelEventArgs) Handles cbTGasto.Validating
        If (sender.Text = "") Or (exist("CategoriasGastos", "nombre", sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Categoría correcta." & vbCrLf &
                                             "Puede agregar una nueva en la seccion Administrar")
            If Not ControlesConErroresAgregar.Contains(sender) Then
                ControlesConErroresAgregar.Add(sender)
            End If
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresAgregar.Remove(sender)
        End If
    End Sub
    Private Sub tbProveedor_Validating(sender As Object, e As CancelEventArgs) Handles tbProveedor.Validating
        If (sender.Text = "") Or (exist("Proveedores", "nombre", sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Proveedor correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en la seccion Administrar")
            If Not ControlesConErroresAgregar.Contains(sender) Then
                ControlesConErroresAgregar.Add(sender)
            End If
        Else
                Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresAgregar.Remove(sender)
        End If
    End Sub
    Private Sub cbTComprobante_Validating(sender As Object, e As CancelEventArgs) Handles cbTComprobante.Validating
        If (sender.Text = "") Or (exist("TiposComprobantes", "nombre", sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Tipo de Comprobante correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en la seccion Administrar")
            If Not ControlesConErroresAgregar.Contains(sender) Then
                ControlesConErroresAgregar.Add(sender)
            End If
        Else
                Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresAgregar.Remove(sender)
        End If
    End Sub
    Private Sub tbMonto_Validating(sender As Object, e As CancelEventArgs) Handles tbMonto.Validating
        If Not IsNumeric(sender.Text) Or IsDBNull(sender.Text) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un valor numérico o cero")
            If Not ControlesConErroresAgregar.Contains(sender) Then
                ControlesConErroresAgregar.Add(sender)
            End If
        Else
                Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresAgregar.Remove(sender)
        End If
    End Sub
    Private Sub cbSeccional_Validating(sender As Object, e As CancelEventArgs) Handles cbSeccional.Validating
        If (sender.Text = "") Or (exist("Seccionales", "nombre", sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Seccional correcta." & vbCrLf &
                                             "Puede configurarlo desde el Menú Editar")
            If Not ControlesConErroresAgregar.Contains(sender) Then
                ControlesConErroresAgregar.Add(sender)
            End If
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
            If Not ControlesConErroresAgregar.Contains(sender) Then
                ControlesConErroresAgregar.Add(sender)
            End If
            Exit Sub
        ElseIf (obtenerID("Proveedores", "nombre", tbProveedor.Text) = Nothing) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Proveedor correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en la seccion Administrar")
            If Not ControlesConErroresAgregar.Contains(sender) Then
                ControlesConErroresAgregar.Add(sender)
            End If
            Exit Sub
        ElseIf (comprobante_repetido(comprobante, obtenerID("Proveedores", "nombre", tbProveedor.Text))) Then
            Principal.ErrorProvider.SetError(sender, "Ese comprobante ya fué cargado para ese Proveedor")
            If Not ControlesConErroresAgregar.Contains(sender) Then
                ControlesConErroresAgregar.Add(sender)
            End If
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
    Private Sub TSTextBoxAño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TSTextBoxAño.KeyPress
        keyverify(e, numeros:=True)
    End Sub

    'Validating
    Private Sub TextBoxNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxNombre.Validating
        If (sender.Text = "") Or (exist("Personas", "nombre", sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Persona correcta." & vbCrLf &
                                             "Puede agregar una nueva en la seccion Administrar")
            If Not ControlesConErroresModificar.Contains(sender) Then
                ControlesConErroresModificar.Add(sender)
            End If
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub TextBoxProveedor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxProveedor.Validating
        If (sender.Text = "") Or (exist("Proveedores", "nombre", sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Proveedor correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en la seccion Administrar")
            If Not ControlesConErroresModificar.Contains(sender) Then
                ControlesConErroresModificar.Add(sender)
            End If
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub TextBoxMonto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxMonto.Validating
        If Not IsNumeric(sender.Text) Or IsDBNull(sender.Text) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un valor numérico o cero")
            If Not ControlesConErroresModificar.Contains(sender) Then
                ControlesConErroresModificar.Add(sender)
            End If
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
            If Not ControlesConErroresModificar.Contains(sender) Then
                ControlesConErroresModificar.Add(sender)
            End If
            Exit Sub
        ElseIf (obtenerID("Proveedores", "nombre", TextBoxProveedor.Text) = Nothing) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Proveedor correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en la seccion Administrar")
            If Not ControlesConErroresModificar.Contains(sender) Then
                ControlesConErroresModificar.Add(sender)
            End If
            Exit Sub
        ElseIf (comprobante_repetido(comprobante, obtenerID("Proveedores", "nombre", tbProveedor.Text))) Then
            Principal.ErrorProvider.SetError(sender, "Ese comprobante ya fué cargado para ese Proveedor")
            If Not ControlesConErroresModificar.Contains(sender) Then
                ControlesConErroresModificar.Add(sender)
            End If
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub ComboBoxSeccional_Validating(sender As Object, e As CancelEventArgs) Handles ComboBoxSeccional.Validating
        If (sender.Text = "") Or (exist("Seccionales", "nombre", sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Seccional correcta." & vbCrLf &
                                             "Puede configurarlo desde el Menú Editar")
            If Not ControlesConErroresModificar.Contains(sender) Then
                ControlesConErroresModificar.Add(sender)
            End If
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub ComboBoxTipoComprobante_Validating(sender As Object, e As CancelEventArgs) Handles ComboBoxTipoComprobante.Validating
        If (sender.Text = "") Or (exist("TiposComprobantes", "nombre", sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Tipo de Comprobante correcto." & vbCrLf &
                                             "Puede agregar uno nuevo en la seccion Administrar")
            If Not ControlesConErroresModificar.Contains(sender) Then
                ControlesConErroresModificar.Add(sender)
            End If
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub
    Private Sub ComboBoxCategGasto_Validating(sender As Object, e As CancelEventArgs) Handles ComboBoxCategGasto.Validating
        If (sender.Text = "") Or (exist("Categoriasgastos", "nombre", sender.Text) = False) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Categoría correcta." & vbCrLf &
                                             "Puede agregar una nueva en la seccion Administrar")
            If Not ControlesConErroresModificar.Contains(sender) Then
                ControlesConErroresModificar.Add(sender)
            End If
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErroresModificar.Remove(sender)
        End If
    End Sub

    Private Sub TSTextBoxFiltro1_Validating(sender As Object, e As CancelEventArgs) Handles TSTextBoxFiltro1.Validating
        Select Case TSComboBoxFiltro1.SelectedItem
            Case "Fecha", "Mes Reintegro"
                If Not (Date.TryParse(sender.Text, New Date) Or sender.Text = "") Then
                    System.Media.SystemSounds.Beep.Play()
                    sender.BackColor = Color.MistyRose
                    TSComboBoxFiltro1.BackColor = Color.MistyRose
                Else
                    sender.BackColor = SystemColors.Window
                    TSComboBoxFiltro1.BackColor = SystemColors.Window
                End If
            Case "Monto"
                If Not (IsNumeric(sender.Text) Or sender.Text = "") Then
                    System.Media.SystemSounds.Beep.Play()
                    sender.BackColor = Color.MistyRose
                    TSComboBoxFiltro1.BackColor = Color.MistyRose
                Else
                    sender.BackColor = SystemColors.Window
                    TSComboBoxFiltro1.BackColor = SystemColors.Window
                End If
            Case "Seleccionado"
                If Not (sender.text = "0" Or sender.Text = "1" Or sender.Text = "") Then
                    System.Media.SystemSounds.Beep.Play()
                    sender.BackColor = Color.MistyRose
                    TSComboBoxFiltro1.BackColor = Color.MistyRose
                Else
                    sender.BackColor = SystemColors.Window
                    TSComboBoxFiltro1.BackColor = SystemColors.Window
                End If
            Case Else
                sender.BackColor = SystemColors.Window
                TSComboBoxFiltro1.BackColor = SystemColors.Window
                Exit Select
        End Select
    End Sub
    Private Sub TSTextBoxFiltro2_Validating(sender As Object, e As CancelEventArgs) Handles TSTextBoxFiltro2.Validating
        Select Case TSComboBoxFiltro2.SelectedItem
            Case "Fecha", "Mes Reintegro"
                If Not (Date.TryParse(sender.Text, New Date) Or sender.Text = "") Then
                    System.Media.SystemSounds.Beep.Play()
                    sender.BackColor = Color.MistyRose
                    TSComboBoxFiltro2.BackColor = Color.MistyRose
                Else
                    sender.BackColor = SystemColors.Window
                    TSComboBoxFiltro2.BackColor = SystemColors.Window
                End If
            Case "Monto"
                If Not (IsNumeric(sender.Text) Or sender.Text = "") Then
                    System.Media.SystemSounds.Beep.Play()
                    sender.BackColor = Color.MistyRose
                    TSComboBoxFiltro2.BackColor = Color.MistyRose
                Else
                    sender.BackColor = SystemColors.Window
                    TSComboBoxFiltro2.BackColor = SystemColors.Window
                End If
            Case "Seleccionado"
                If Not (sender.text = "0" Or sender.Text = "1" Or sender.Text = "") Then
                    System.Media.SystemSounds.Beep.Play()
                    sender.BackColor = Color.MistyRose
                    TSComboBoxFiltro2.BackColor = Color.MistyRose
                Else
                    sender.BackColor = SystemColors.Window
                    TSComboBoxFiltro2.BackColor = SystemColors.Window
                End If
            Case Else
                sender.BackColor = SystemColors.Window
                TSComboBoxFiltro2.BackColor = SystemColors.Window
                Exit Select
        End Select
    End Sub
    Private Sub TSComboBoxTrimestre_Validating(sender As Object, e As CancelEventArgs) Handles TSComboBoxTrimestre.Validating
        If TSComboBoxTrimestre.Items.Contains(TSComboBoxTrimestre.Text) Or TSComboBoxTrimestre.Text = "" Then
            TSComboBoxTrimestre.BackColor = SystemColors.Window
        Else
            TSComboBoxTrimestre.SelectedIndex = -1
            TSComboBoxTrimestre.Text = ""
            System.Media.SystemSounds.Beep.Play()
            TSComboBoxTrimestre.BackColor = Color.MistyRose
        End If
    End Sub
    Private Sub TSComboBoxFiltro1_Validating(sender As Object, e As CancelEventArgs) Handles TSComboBoxFiltro1.Validating
        If TSComboBoxFiltro1.Items.Contains(TSComboBoxFiltro1.Text) Or TSComboBoxFiltro1.Text = "" Then
            TSComboBoxFiltro1.BackColor = SystemColors.Window
        Else
            TSComboBoxFiltro1.SelectedIndex = -1
            TSComboBoxFiltro1.Text = ""
            System.Media.SystemSounds.Beep.Play()
            TSComboBoxFiltro1.BackColor = Color.MistyRose
        End If
    End Sub

    Private Sub TSComboBoxFiltro1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TSComboBoxFiltro1.SelectedIndexChanged
        TSTextBoxFiltro1.Text = ""
    End Sub

    Private Sub TSComboBoxFiltro2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TSComboBoxFiltro2.SelectedIndexChanged
        TSTextBoxFiltro2.Text = ""
    End Sub

    Private Sub TSComboBoxMes_Validating(sender As Object, e As CancelEventArgs) Handles TSComboBoxMes.Validating
        If TSComboBoxMes.Items.Contains(TSComboBoxMes.Text) Or TSComboBoxMes.Text = "" Then
            TSComboBoxMes.BackColor = SystemColors.Window
        Else
            TSComboBoxMes.SelectedIndex = -1
            TSComboBoxMes.Text = ""
            System.Media.SystemSounds.Beep.Play()
            TSComboBoxMes.BackColor = Color.MistyRose
        End If
    End Sub

#End Region

End Class