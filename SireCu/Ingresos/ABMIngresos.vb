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

End Class
