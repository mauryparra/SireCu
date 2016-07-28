Imports System.Data.SqlServerCe

Public Class ABMIngresos

    'Cambiar el texto del ComboBox de los Trimestres
    Private Sub cb_Trimestre_TextChanged(sender As Object, e As EventArgs) Handles cb_Trimestre.TextChanged

        'Según que seleccione en el combo box trimestre..
        Select Case cb_Trimestre.Text
            Case "Primero"

                'Casilla de Año vacía
                If (tb_Año.Text = "") Then
                    MsgBox("por favor ingrese un año", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If

                'Cambiamos los meses que son del primer trimestre
                lb_Mes1.Text = "Enero"
                lb_Mes2.Text = "Febrero"
                lb_Mes3.Text = "Marzo"

                'Conectamos la BD
                If conectar() = False Then
                    Exit Sub
                End If

                'Cargamos consultando por cada mes
                'Enero
                cargar(lb_Mes1.Text, tb_IngresosP1, tb_IngresosO1)
                'Febrero
                cargar(lb_Mes2.Text, tb_IngresosP2, tb_IngresosO2)
                'Marzo
                cargar(lb_Mes3.Text, tb_IngresosP3, tb_IngresosO3)

                'Desconectamos
                desconectar()

                'Habilitamos boton para modificar
                btn_Modificar.Enabled = True

            Case "Segundo"

                'Casilla de Año vacía
                If (tb_Año.Text = "") Then
                    MsgBox("por favor ingrese un año", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If

                lb_Mes1.Text = "Abril"
                lb_Mes2.Text = "Mayo"
                lb_Mes3.Text = "Junio"

                If conectar() = False Then
                    Exit Sub
                End If

                'Abril
                cargar(lb_Mes1.Text, tb_IngresosP1, tb_IngresosO1)
                'Mayo
                cargar(lb_Mes2.Text, tb_IngresosP2, tb_IngresosO2)
                'Junio
                cargar(lb_Mes3.Text, tb_IngresosP3, tb_IngresosO3)

                desconectar()

                btn_Modificar.Enabled = True

            Case "Tercero"

                'Casilla de Año vacía
                If (tb_Año.Text = "") Then
                    MsgBox("por favor ingrese un año", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If

                lb_Mes1.Text = "Julio"
                lb_Mes2.Text = "Agosto"
                lb_Mes3.Text = "Septiembre"

                If conectar() = False Then
                    Exit Sub
                End If

                'Julio
                cargar(lb_Mes1.Text, tb_IngresosP1, tb_IngresosO1)
                'Agosto
                cargar(lb_Mes2.Text, tb_IngresosP2, tb_IngresosO2)
                'Septiembre
                cargar(lb_Mes3.Text, tb_IngresosP3, tb_IngresosO3)

                desconectar()

                btn_Modificar.Enabled = True

            Case "Cuarto"

                'Casilla de Año vacía
                If (tb_Año.Text = "") Then
                    MsgBox("por favor ingrese un año", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If

                lb_Mes1.Text = "Octubre"
                lb_Mes2.Text = "Noviembre"
                lb_Mes3.Text = "Diciembre"

                If conectar() = False Then
                    Exit Sub
                End If

                'Octubre
                cargar(lb_Mes1.Text, tb_IngresosP1, tb_IngresosO1)
                'Noviembre
                cargar(lb_Mes2.Text, tb_IngresosP2, tb_IngresosO2)
                'Diciembre
                cargar(lb_Mes3.Text, tb_IngresosP3, tb_IngresosO3)

                desconectar()

                btn_Modificar.Enabled = True

                'Limpiamos si no es ninguno de los Trimestres
            Case Else
                lb_Mes1.Text = "----"
                lb_Mes2.Text = "----"
                lb_Mes3.Text = "----"
                tb_IngresosP1.Text = ""
                tb_IngresosP2.Text = ""
                tb_IngresosP3.Text = ""
                tb_IngresosO1.Text = ""
                tb_IngresosO2.Text = ""
                tb_IngresosO3.Text = ""
                btn_Modificar.Enabled = False
        End Select

    End Sub
    'Carga el contenido de la Base de Datos
    Private Sub cargar(ByVal mes As String, ByRef txb1 As TextBox, ByRef txb2 As TextBox)

        'Query de la consulta
        Dim command As New SqlCeCommand
        Dim adapter As SqlCeDataAdapter
        Dim sql As String = "SELECT ingresosProv, ingresosOtros, mes FROM ingresos WHERE (mes=@mes) AND (año=@año)"
        Dim dataset As New DataSet
        dataset.Tables.Add("ingresos")

        'Al command para consultar le agregamos el mes y el año con el que vamos a filtrar la consulta
        Command.Parameters.AddWithValue("@mes", mes)
        Command.Parameters.AddWithValue("@año", tb_Año.Text)
        'consultamos
        consultar(sql, Command)
        'Resultado de la consulta lo metemos en el adapter
        adapter = New SqlCeDataAdapter(Command)

        'Lleno la tabla del dataset con el contenido del adapter
        adapter.Fill(dataset.Tables("ingresos"))

        'Lleno los Textbox (vienen por referencia a la función) con el contenido del Dataset
        If (dataset.Tables("ingresos").Rows.Count = 0) Then
            txb1.Text = "0"
            txb2.Text = "0"
        Else
            txb1.Text = dataset.Tables("ingresos").Rows.Item(0).Item("ingresosProv")
            txb2.Text = dataset.Tables("ingresos").Rows.Item(0).Item("ingresosOtros")
        End If
        'Limpio el Dataset por si las dudas
        dataset.Tables("ingresos").Rows.Clear()

    End Sub

    'Ver el último año cargado
    Private Function ultimoaño()

        Dim command As New SqlCeCommand
        Dim adapter As SqlCeDataAdapter
        Dim query As String = "SELECT año FROM ingresos ORDER BY año DESC"
        Dim dataset As DataSet = New DataSet
        dataset.Tables.Add("ingresos")

        'Consultamos la BD
        If conectar() = False Then
            Return ("error")
            Exit Function
        End If
        consultar(query, command)
        desconectar()

        adapter = New SqlCeDataAdapter(command)
        adapter.Fill(dataset.Tables("ingresos"))

        If (dataset.Tables("ingresos").Rows.Count() = 0) Then
            Return (0)
        Else : Return (dataset.Tables("ingresos").Rows.Item(0).Item("año"))
        End If

    End Function

    'Boton Modificar
    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click

        'Habilitamos
        tb_IngresosP1.Enabled = True
        tb_IngresosP2.Enabled = True
        tb_IngresosP3.Enabled = True
        tb_IngresosO1.Enabled = True
        tb_IngresosO2.Enabled = True
        tb_IngresosO3.Enabled = True
        btn_Guardar.Enabled = True
        btn_Modificar.Enabled = False
        cb_Trimestre.Enabled = False
        PictureBox1.Visible = True


    End Sub

    'Boton Guardar
    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click

        'Conectamos la BD
        If conectar() = False Then
            Exit Sub
        End If

        'Preguntamos si esta seguro
        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Guardar?") = MsgBoxResult.Ok) Then

            'Verificamos si esta vacío (No se puede convertir un "nothing" en double)

            'Primera Fila
            If (tb_IngresosP1.Text = "") Then
                If tb_IngresosO1.Text = "" Then
                    guardar(lb_Mes1.Text, "0.00", "0.00", tb_Año.Text)
                Else : guardar(lb_Mes1.Text, "0.00", CDbl(tb_IngresosO1.Text), tb_Año.Text)
                End If
            ElseIf (tb_IngresosO1.Text = "") Then
                guardar(lb_Mes1.Text, CDbl(tb_IngresosP1.Text), "0.00", tb_Año.Text)
            Else : guardar(lb_Mes1.Text, CDbl(tb_IngresosP1.Text), CDbl(tb_IngresosO1.Text), tb_Año.Text)
            End If

            'Segunda Fila
            If (tb_IngresosP2.Text = "") Then
                If tb_IngresosO2.Text = "" Then
                    guardar(lb_Mes2.Text, "0.00", "0.00", tb_Año.Text)
                Else : guardar(lb_Mes2.Text, "0.00", CDbl(tb_IngresosO2.Text), tb_Año.Text)
                End If
            ElseIf (tb_IngresosO2.Text = "") Then
                guardar(lb_Mes2.Text, CDbl(tb_IngresosP2.Text), "0.00", tb_Año.Text)
            Else : guardar(lb_Mes2.Text, CDbl(tb_IngresosP2.Text), CDbl(tb_IngresosO2.Text), tb_Año.Text)
            End If

            'Tercera Fila
            If (tb_IngresosP3.Text = "") Then
                If tb_IngresosO3.Text = "" Then
                    guardar(lb_Mes3.Text, "0.00", "0.00", tb_Año.Text)
                Else : guardar(lb_Mes3.Text, "0.00", CDbl(tb_IngresosO3.Text), tb_Año.Text)
                End If
            ElseIf (tb_IngresosO3.Text = "") Then
                guardar(lb_Mes3.Text, CDbl(tb_IngresosP3.Text), "0.00", tb_Año.Text)
            Else : guardar(lb_Mes3.Text, CDbl(tb_IngresosP3.Text), CDbl(tb_IngresosO3.Text), tb_Año.Text)
            End If

            desconectar()

            'Habilitamos
            tb_IngresosP1.Enabled = False
            tb_IngresosP2.Enabled = False
            tb_IngresosP3.Enabled = False
            tb_IngresosO1.Enabled = False
            tb_IngresosO2.Enabled = False
            tb_IngresosO3.Enabled = False
            btn_Guardar.Enabled = False
            btn_Modificar.Enabled = True
            cb_Trimestre.Enabled = True


        Else
            desconectar()
            tb_IngresosP1.Enabled = False
            tb_IngresosP2.Enabled = False
            tb_IngresosP3.Enabled = False
            tb_IngresosO1.Enabled = False
            tb_IngresosO2.Enabled = False
            tb_IngresosO3.Enabled = False
            btn_Guardar.Enabled = False
            btn_Modificar.Enabled = True
            cb_Trimestre.Enabled = True
            Exit Sub
        End If

    End Sub
    Private Sub guardar(ByVal mes As String, ByVal iprov As Double, ByVal oing As Double, ByVal año As Integer)
        Dim command As New SqlCeCommand
        Dim sql As String = "UPDATE ingresos SET ingresosProv = @iProvinciales, ingresosOtros = @oIngresos WHERE mes = @mes AND año = @año"
        command.Parameters.AddWithValue("@iProvinciales", iprov)
        command.Parameters.AddWithValue("@oIngresos", oing)
        command.Parameters.AddWithValue("@mes", mes)
        command.Parameters.AddWithValue("@año", año)

        consultar(sql, command)
    End Sub

    'Verificación de solo entrada de números
    Public Sub keyverify(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then ' Letras -> no
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then 'Caracter de control -> si
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then 'Espacio en blanco -> no
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) Then 'Numeros -> si
            e.Handled = False
        ElseIf (e.KeyChar = ",") Then 'Coma -> Si
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub
    Private Sub tb_IngresosO1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosO1.KeyPress
        keyverify(e)
    End Sub
    Private Sub tb_IngresosO2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosO2.KeyPress
        keyverify(e)
    End Sub
    Private Sub tb_IngresosO3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosO3.KeyPress
        keyverify(e)
    End Sub
    Private Sub tb_IngresosP1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosP1.KeyPress
        keyverify(e)
    End Sub
    Private Sub tb_IngresosP2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosP2.KeyPress
        keyverify(e)
    End Sub
    Private Sub tb_IngresosP3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_IngresosP3.KeyPress
        keyverify(e)
    End Sub
    'Cambiar el Año con doble click
    Private Sub ABMIngresos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        If e.X > tb_Año.Location.X And e.X < tb_Año.Location.X + tb_Año.Width And _
        e.Y > tb_Año.Location.Y And e.Y < tb_Año.Location.Y + tb_Año.Height Then
            tb_Año.Enabled = True
        End If

        cb_Trimestre.Text = ""
        cb_Trimestre.Enabled = False
        tb_IngresosO1.Enabled = False
        tb_IngresosO2.Enabled = False
        tb_IngresosO3.Enabled = False
        tb_IngresosP1.Enabled = False
        tb_IngresosP2.Enabled = False
        tb_IngresosP3.Enabled = False
        btn_Guardar.Enabled = False
        btn_Modificar.Enabled = False
        tb_Año.Focus()

    End Sub
    'Al apretar enter salga del textbox
    Private Sub tb_Año_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Año.KeyPress
        keyverify(e)
        If (e.KeyChar = ",") Then 'Coma -> No
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            tb_Año.Enabled = False
            cb_Trimestre.Enabled = True
        End If
    End Sub
    'Al salir del textbox del AÑO
    Private Sub tb_Año_LostFocus(sender As Object, e As EventArgs) Handles tb_Año.LostFocus

        Dim command As New SqlCeCommand
        Dim adapter As SqlCeDataAdapter
        Dim query As String = "SELECT año FROM ingresos"
        Dim dataset As DataSet = New DataSet
        dataset.Tables.Add("ingresos")

        'Consultamos la BD
        If conectar() = False Then
            Exit Sub
        End If
        consultar(query, command)
        desconectar()

        adapter = New SqlCeDataAdapter(command)
        adapter.Fill(dataset.Tables("ingresos"))

        Dim flag As Boolean = False

        For i = 0 To dataset.Tables("ingresos").Rows.Count - 1
            If (tb_Año.Text = Val(dataset.Tables("ingresos").Rows.Item(i).Item("año"))) And (tb_Año.Text <> "") Then
                flag = True
            Else : flag = False
            End If
        Next i

        If (flag = False) And (tb_Año.Text <> "") Then
            If (MsgBox("El año ingresado no se encuentra en la base de datos." + vbCrLf + _
                   "Desea crear los registros del mismo?", MsgBoxStyle.YesNo, "Año no registrado") = MsgBoxResult.Yes) Then

                'Creamos los 12 meses
                If conectar() = False Then
                    Exit Sub
                End If

                Dim llenar(0 To 11) As String
                llenar(0) = "Enero"
                llenar(1) = "Febrero"
                llenar(2) = "Marzo"
                llenar(3) = "Abril"
                llenar(4) = "Mayo"
                llenar(5) = "Junio"
                llenar(6) = "Julio"
                llenar(7) = "Agosto"
                llenar(8) = "Septiembre"
                llenar(9) = "Octubre"
                llenar(10) = "Noviembre"
                llenar(11) = "Diciembre"

                For i = 0 To 11
                    query = "Insert into ingresos (ingresosProv, ingresosOtros, mes, año)" + _
                        " values (0,0,'" + llenar(i) + "','" + tb_Año.Text + "')"
                    consultar(query, command)
                Next

                desconectar()
                MsgBox("Año correctamente creado!", MsgBoxStyle.Information, "Año no registrado")
            Else
                tb_Año.Text = ""
            End If
        End If


        tb_Año.Enabled = False
        cb_Trimestre.Enabled = True
        cb_Trimestre.Text = ""
        cb_Trimestre.Focus()

    End Sub
    'Load
    Private Sub ABMIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'usamos el año mas grande de la base de datos
        tb_Año.Text = ultimoaño()
    End Sub

    'Eliminar AÑO
    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        If (MsgBox("Eliminar Año " + tb_Año.Text + "?", MsgBoxStyle.YesNo, "Eliminar año") = MsgBoxResult.Yes) Then
            Dim command As New SqlCeCommand
            Dim query As String = "DELETE from ingresos where año='" + tb_Año.Text + "'"

            'Consultamos la BD
            If conectar() = False Then
                Exit Sub
            End If
            consultar(query, command)
            desconectar()

            MsgBox("El año " + tb_Año.Text + " fue borrado exitosamente", MsgBoxStyle.Information, "Año borrado")
        End If

        tb_Año.Text = ""
        cb_Trimestre.Enabled = True
        tb_IngresosO1.Enabled = False
        tb_IngresosO2.Enabled = False
        tb_IngresosO3.Enabled = False
        tb_IngresosP1.Enabled = False
        tb_IngresosP2.Enabled = False
        tb_IngresosP3.Enabled = False
        btn_Guardar.Enabled = False
        cb_Trimestre.Text = ""
        cb_Trimestre.Focus()

    End Sub
End Class
