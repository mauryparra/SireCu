

Public Class ABMIngresos


    Dim ControlesConErrores As List(Of Control) = New List(Of Control)

#Region "Eventos"

    Private Sub ABMIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'usamos el año mas grande de la base de datos
        tb_Año.Text = ultimoaño()

    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click

        activarEdicion(True)

    End Sub

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click

        'Preguntamos si esta seguro
        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Guardar?") = MsgBoxResult.Ok) Then

            'Verificamos que todos los campos hayan pasado las validaciones
            If ControlesConErrores.Count > 0 Then
                MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
            Else

                'Verificamos si el año ya está ingresado
                If (verificar_año(tb_Año.Text) = False) Then
                    new_año(tb_Año.Text)
                End If

                Select Case cb_Trimestre.Text
                    Case "Primero"
                        'Primera fila
                        modificar_ingreso("01", tb_Año.Text, tb_IngresosP1.Text, tb_IngresosO1.Text, tb_IngresosC1.Text)
                        'Segunda fila
                        modificar_ingreso("02", tb_Año.Text, tb_IngresosP2.Text, tb_IngresosO2.Text, tb_IngresosC2.Text)
                        'Tercer fila
                        modificar_ingreso("03", tb_Año.Text, tb_IngresosP3.Text, tb_IngresosO3.Text, tb_IngresosC3.Text)
                    Case "Segundo"
                        'Primera fila
                        modificar_ingreso("04", tb_Año.Text, tb_IngresosP1.Text, tb_IngresosO1.Text, tb_IngresosC1.Text)
                        'Segunda fila
                        modificar_ingreso("05", tb_Año.Text, tb_IngresosP2.Text, tb_IngresosO2.Text, tb_IngresosC2.Text)
                        'Tercer fila
                        modificar_ingreso("06", tb_Año.Text, tb_IngresosP3.Text, tb_IngresosO3.Text, tb_IngresosC3.Text)
                    Case "Tercero"
                        'Primera fila
                        modificar_ingreso("07", tb_Año.Text, tb_IngresosP1.Text, tb_IngresosO1.Text, tb_IngresosC1.Text)
                        'Segunda fila
                        modificar_ingreso("08", tb_Año.Text, tb_IngresosP2.Text, tb_IngresosO2.Text, tb_IngresosC2.Text)
                        'Tercer fila
                        modificar_ingreso("09", tb_Año.Text, tb_IngresosP3.Text, tb_IngresosO3.Text, tb_IngresosC3.Text)
                    Case "Cuarto"
                        'Primera fila
                        modificar_ingreso("10", tb_Año.Text, tb_IngresosP1.Text, tb_IngresosO1.Text, tb_IngresosC1.Text)
                        'Segunda fila
                        modificar_ingreso("11", tb_Año.Text, tb_IngresosP2.Text, tb_IngresosO2.Text, tb_IngresosC2.Text)
                        'Tercer fila
                        modificar_ingreso("12", tb_Año.Text, tb_IngresosP3.Text, tb_IngresosO3.Text, tb_IngresosC3.Text)
                End Select

                activarEdicion(False)

            End If

        Else
            Exit Sub
        End If

    End Sub

    'Cambiar el Año con doble click
    Private Sub tb_Año_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tb_Año.MouseDoubleClick
        cambiandoAño(True)
    End Sub

    'Al apretar enter salga del textbox
    Private Sub tb_Año_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Año.KeyPress
        keyverify(e, numeros:=True)
        If e.KeyChar = ChrW(Keys.Enter) Then
            cambiandoAño(False)
        End If
    End Sub

#End Region

#Region "Helpers"

    Private Sub cargar(ByVal mes As Integer, ByVal fila As Integer)
        Dim array = mostrar_ingreso(mes, tb_Año.Text)
        If (array.Length = 1) Then
            Select Case fila
                Case 1
                    tb_IngresosC1.Text = "0.0"
                    tb_IngresosO1.Text = "0.0"
                    tb_IngresosP1.Text = "0.0"
                Case 2
                    tb_IngresosC2.Text = "0.0"
                    tb_IngresosO2.Text = "0.0"
                    tb_IngresosP2.Text = "0.0"
                Case 3
                    tb_IngresosC3.Text = "0.0"
                    tb_IngresosO3.Text = "0.0"
                    tb_IngresosP3.Text = "0.0"
            End Select
        Else
            Select Case fila
                Case 1
                    tb_IngresosC1.Text = array(1)
                    tb_IngresosO1.Text = array(2)
                    tb_IngresosP1.Text = array(0)
                Case 2
                    tb_IngresosC2.Text = array(1)
                    tb_IngresosO2.Text = array(2)
                    tb_IngresosP2.Text = array(0)
                Case 3
                    tb_IngresosC3.Text = array(1)
                    tb_IngresosO3.Text = array(2)
                    tb_IngresosP3.Text = array(0)
            End Select
        End If
    End Sub

    ' Activa o desactiva la edición de Ingresos
    Private Sub activarEdicion(ByVal activar As Boolean)
        If activar Then
            For Each control As Control In GroupBoxIngresos.Controls
                If TypeOf control Is TextBox Then
                    control.Enabled = True
                End If
            Next
            btn_Guardar.Enabled = True
            btn_Modificar.Enabled = False
            cb_Trimestre.Enabled = False
        Else
            For Each control As Control In GroupBoxIngresos.Controls
                If TypeOf control Is TextBox Then
                    control.Enabled = False
                End If
            Next
            btn_Guardar.Enabled = False
            btn_Modificar.Enabled = True
            cb_Trimestre.Enabled = True
        End If
    End Sub

    ' Activa o desactiva los controles del formulario para cambiar el año
    Private Sub cambiandoAño(ByVal activar As Boolean)
        If activar Then
            tb_Año.ReadOnly = False
            cb_Trimestre.Text = ""
            cb_Trimestre.Enabled = False
            For Each control As Control In GroupBoxIngresos.Controls
                If TypeOf control Is TextBox Then
                    control.Enabled = False
                End If
            Next
            btn_Guardar.Enabled = False
            btn_Modificar.Enabled = False
            tb_Año.Focus()
        Else
            tb_Año.ReadOnly = True
            cb_Trimestre.Enabled = True
        End If
    End Sub

    'Verificación de solo entrada por teclado
    Public Sub keyverify(ByVal e As System.Windows.Forms.KeyPressEventArgs,
                         Optional ByVal letras As Boolean = False,
                         Optional ByVal numeros As Boolean = False,
                         Optional ByVal comas As Boolean = False,
                         Optional ByVal puntosAComas As Boolean = False,
                         Optional ByVal espacios As Boolean = False,
                         Optional ByVal control As Boolean = True,
                         Optional ByVal otros As Boolean = False)

        If Char.IsLetter(e.KeyChar) Then        ' Permite o cancela ingreso de letras
            e.Handled = Not letras
        ElseIf Char.IsDigit(e.KeyChar) Then     ' Permite o cancela ingreso de numeros
            e.Handled = Not numeros
        ElseIf e.KeyChar = "," Then             ' Permite o cancela ingreso de comas
            e.Handled = Not comas
        ElseIf comas And e.KeyChar = "." Then   ' Si se permiten comas y el caracter es un punto
            If puntosAComas Then                ' Permite o cancela la sustitución de punto por coma
                e.KeyChar = ","
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf Char.IsSeparator(e.KeyChar) Then ' Permite o cancela ingreso de espacios
            e.Handled = Not espacios
        ElseIf Char.IsControl(e.KeyChar) Then   ' Permite o cancela ingreso caracteres de control
            e.Handled = Not control
        Else
            e.Handled = Not otros               ' Permite o cancela ingreso de otros caracteres
        End If

    End Sub

    Private Sub validarIngresos(sender As Object, e As EventArgs)
        If Not IsNumeric(sender.Text) Or IsDBNull(sender.Text) Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un valor numérico o 0")
            ControlesConErrores.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErrores.Remove(sender)
        End If
    End Sub

#End Region

#Region "Validaciones"

    Private Sub cb_Trimestre_TextChanged(sender As Object, e As EventArgs) Handles cb_Trimestre.TextChanged

        'Casilla de Año vacía
        If (tb_Año.Text = "") Then
            MsgBox("por favor ingrese un año", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Select Case cb_Trimestre.Text
            Case "Primero"

                lb_Mes1.Text = "Enero"
                cargar("01", 1)
                lb_Mes2.Text = "Febrero"
                cargar("02", 2)
                lb_Mes3.Text = "Marzo"
                cargar("03", 3)

                btn_Modificar.Enabled = True

            Case "Segundo"

                lb_Mes1.Text = "Abril"
                cargar("04", 1)
                lb_Mes2.Text = "Mayo"
                cargar("05", 2)
                lb_Mes3.Text = "Junio"
                cargar("06", 3)

                btn_Modificar.Enabled = True

            Case "Tercero"

                lb_Mes1.Text = "Julio"
                cargar("07", 1)
                lb_Mes2.Text = "Agosto"
                cargar("08", 2)
                lb_Mes3.Text = "Septiembre"
                cargar("09", 3)

                btn_Modificar.Enabled = True

            Case "Cuarto"

                lb_Mes1.Text = "Octubre"
                cargar("10", 1)
                lb_Mes2.Text = "Noviembre"
                cargar("11", 2)
                lb_Mes3.Text = "Diciembre"
                cargar("12", 3)

                btn_Modificar.Enabled = True

                'Limpiamos si no es ninguno de los Trimestres
            Case Else
                For Each control As Control In GroupBoxIngresos.Controls
                    If TypeOf control Is Label And control.Name.Contains("lb_Mes") Then
                        control.Text = "----"
                    End If

                    If TypeOf control Is TextBox Then
                        control.Text = ""
                    End If
                Next
                btn_Modificar.Enabled = False
        End Select

    End Sub

    Private Sub tb_IngresosP1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosP1.KeyPress
        keyverify(e, numeros:=True, comas:=True, puntosAComas:=True)
    End Sub
    Private Sub tb_IngresosP2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosP2.KeyPress
        keyverify(e, numeros:=True, comas:=True, puntosAComas:=True)
    End Sub
    Private Sub tb_IngresosP3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosP3.KeyPress
        keyverify(e, numeros:=True, comas:=True, puntosAComas:=True)
    End Sub

    Private Sub tb_IngresosC1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosC1.KeyPress
        keyverify(e, numeros:=True, comas:=True, puntosAComas:=True)
    End Sub
    Private Sub tb_IngresosC2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosC2.KeyPress
        keyverify(e, numeros:=True, comas:=True, puntosAComas:=True)
    End Sub
    Private Sub tb_IngresosC3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosC3.KeyPress
        keyverify(e, numeros:=True, comas:=True, puntosAComas:=True)
    End Sub

    Private Sub tb_IngresosO1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosO1.KeyPress
        keyverify(e, numeros:=True, comas:=True, puntosAComas:=True)
    End Sub
    Private Sub tb_IngresosO2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosO2.KeyPress
        keyverify(e, numeros:=True, comas:=True, puntosAComas:=True)
    End Sub
    Private Sub tb_IngresosO3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosO3.KeyPress
        keyverify(e, numeros:=True, comas:=True, puntosAComas:=True)
    End Sub

    Private Sub tb_IngresosC1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_IngresosC1.Validating
        validarIngresos(sender, e)
    End Sub

    Private Sub tb_IngresosC2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_IngresosC2.Validating
        validarIngresos(sender, e)
    End Sub

    Private Sub tb_IngresosC3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_IngresosC3.Validating
        validarIngresos(sender, e)
    End Sub

    Private Sub tb_IngresosP1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_IngresosP1.Validating
        validarIngresos(sender, e)
    End Sub

    Private Sub tb_IngresosP2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_IngresosP2.Validating
        validarIngresos(sender, e)
    End Sub

    Private Sub tb_IngresosP3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_IngresosP3.Validating
        validarIngresos(sender, e)
    End Sub

    Private Sub tb_IngresosO1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_IngresosO1.Validating
        validarIngresos(sender, e)
    End Sub

    Private Sub tb_IngresosO2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_IngresosO2.Validating
        validarIngresos(sender, e)
    End Sub

    Private Sub tb_IngresosO3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tb_IngresosO3.Validating
        validarIngresos(sender, e)
    End Sub

#End Region

End Class
