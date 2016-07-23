Imports System.Data.SqlServerCe

Public Class ABMIngresos

    'Cambiar el texto del ComboBox de los Trimestres
    Private Sub cb_Trimestre_TextChanged(sender As Object, e As EventArgs) Handles cb_Trimestre.TextChanged

        'Según que seleccione..
        Select Case cb_Trimestre.Text
            Case "Primero"

                'Cambiamos los meses que son del primer trimestre
                lb_Mes1.Text = "Enero"
                lb_Mes2.Text = "Febrero"
                lb_Mes3.Text = "Marzo"

                'Conectamos la BD
                If conectar() = True Then
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
                lb_Mes1.Text = "Abril"
                lb_Mes2.Text = "Mayo"
                lb_Mes3.Text = "Junio"

                If conectar() = True Then
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
                lb_Mes1.Text = "Julio"
                lb_Mes2.Text = "Agosto"
                lb_Mes3.Text = "Septiembre"

                If conectar() = True Then
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
                lb_Mes1.Text = "Octubre"
                lb_Mes2.Text = "Noviembre"
                lb_Mes3.Text = "Diciembre"

                If conectar() = True Then
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
        Dim sql As String = "SELECT iProvinciales, oIngresos, mes FROM ingresos WHERE (mes=@mes)"
        Dim command As New SqlCeCommand
        Dim adapter As SqlCeDataAdapter
        Dim dataset As New DataSet
        dataset.Tables.Add("tabla")

        'Al command para ocnsultar le agregamos el mes con el que vamos a filtrar la consulta
        command.Parameters.AddWithValue("@mes", mes)
        'consultamos
        consultar(sql, command)
        'Resultado de la consulta lo metemos en el adapter
        adapter = New SqlCeDataAdapter(command)

        'Lleno la tabla del dataset con el contenido del adapter
        adapter.Fill(dataset.Tables("tabla"))

        'Lleno los Textbox (vienen por referencia a la función) con el contenido del Dataset
        For i = 0 To dataset.Tables("tabla").Rows.Count - 1
            If (dataset.Tables("tabla").Rows.Item(i).Item("mes") = mes) Then
                txb1.Text = dataset.Tables("tabla").Rows.Item(i).Item("iProvinciales")
                txb2.Text = dataset.Tables("tabla").Rows.Item(i).Item("oIngresos")
            End If
        Next i

        'Limpio el Dataset por si las dudas
        dataset.Tables("tabla").Rows.Clear()

    End Sub

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

    End Sub

    'Boton Guardar
    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click

        'Conectamos la BD
        If conectar() = True Then
            Exit Sub
        End If

        'Preguntamos si esta seguro
        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Guardar?") = MsgBoxResult.Ok) Then

            'Verificamos si esta vacío (No se puede convertir un "nothing" en double)

            'Primera Fila
            If (tb_IngresosP1.Text = "") Then
                If tb_IngresosO1.Text = "" Then
                    guardar(lb_Mes1.Text, "0.00", "0.00")
                Else : guardar(lb_Mes1.Text, "0.00", CDbl(tb_IngresosO1.Text))
                End If
            ElseIf (tb_IngresosO1.Text = "") Then
                guardar(lb_Mes1.Text, CDbl(tb_IngresosP1.Text), "0.00")
            Else : guardar(lb_Mes1.Text, CDbl(tb_IngresosP1.Text), CDbl(tb_IngresosO1.Text))
            End If

            'Segunda Fila
            If (tb_IngresosP2.Text = "") Then
                If tb_IngresosO2.Text = "" Then
                    guardar(lb_Mes2.Text, "0.00", "0.00")
                Else : guardar(lb_Mes2.Text, "0.00", CDbl(tb_IngresosO2.Text))
                End If
            ElseIf (tb_IngresosO2.Text = "") Then
                guardar(lb_Mes2.Text, CDbl(tb_IngresosP2.Text), "0.00")
            Else : guardar(lb_Mes2.Text, CDbl(tb_IngresosP2.Text), CDbl(tb_IngresosO2.Text))
            End If

            'Tercera Fila
            If (tb_IngresosP3.Text = "") Then
                If tb_IngresosO3.Text = "" Then
                    guardar(lb_Mes3.Text, "0.00", "0.00")
                Else : guardar(lb_Mes3.Text, "0.00", CDbl(tb_IngresosO3.Text))
                End If
            ElseIf (tb_IngresosO3.Text = "") Then
                guardar(lb_Mes3.Text, CDbl(tb_IngresosP3.Text), "0.00")
            Else : guardar(lb_Mes3.Text, CDbl(tb_IngresosP3.Text), CDbl(tb_IngresosO3.Text))
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

        Else
            desconectar()
            Exit Sub
        End If

    End Sub
    Private Sub guardar(ByVal mes As String, ByVal iprov As Double, ByVal oing As Double)
        Dim sql As String = "UPDATE ingresos SET iProvinciales = @iProvinciales, oIngresos = @oIngresos WHERE mes = @mes"
        Dim command As New SqlCeCommand
        command.Parameters.AddWithValue("@iProvinciales", iprov)
        command.Parameters.AddWithValue("@oIngresos", oing)
        command.Parameters.AddWithValue("@mes", mes)

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
End Class
