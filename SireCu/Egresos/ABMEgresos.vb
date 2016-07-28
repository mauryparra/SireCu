Imports System.Data.SqlServerCe

Public Class ABMEgresos

    Dim command As New SqlCeCommand
    Dim adapter As SqlCeDataAdapter

    Private Sub ABMEgresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'Campos requeridos que están vacios
        If (camposVacios() = True) Then
            Exit Sub
        Else
            'Fechas inválidas
            If (fechainvalida() = True) Then
                Exit Sub
            Else
                'Comprobante repetido
                If (esrepetido() = True) Then
                    Exit Sub
                Else
                    'Ingresos disponibles
                    If (hayingresos() = False) Then
                        Exit Sub
                    Else
                        'GUARDAR
                    End If
                End If
            End If
        End If

    End Sub

    'Verificación de ingresos disponibles
    Private Function hayingresos()

        Dim dataset As New DataSet
        dataset.Tables.Add("ingresos")
        dataset.Tables.Add("saldos")
        Dim sql As String = ""
        Dim trim As String = ""

        'Verificamos si el box del mes de reintegro contiene algo
        If tbReintegro.Text <> "" Then
            'No existe el mes cero
            If (tbReintegro.Text = "0") Then
                MsgBox("El mes de reintegro Cero (0) no existe", MsgBoxStyle.Critical, "Error")
                Return (0)
                'Buscamos por trimestres
            ElseIf (tbReintegro.Text = "01") Or (tbReintegro.Text = "1") Or (tbReintegro.Text = "02") Or (tbReintegro.Text = "2") Or (tbReintegro.Text = "03") Or (tbReintegro.Text = "3") Then
                sql = "SELECT ingresosProv, ingresosOtros FROM ingresos WHERE mes = 'Enero' or mes = 'Febrero' or mes = 'Marzo'"
                trim = "Primero"
            ElseIf (tbReintegro.Text = "04") Or (tbReintegro.Text = "4") Or (tbReintegro.Text = "05") Or (tbReintegro.Text = "5") Or (tbReintegro.Text = "06") Or (tbReintegro.Text = "6") Then
                sql = "SELECT ingresosProv, ingresosOtros FROM ingresos WHERE mes = 'Abril' or mes = 'Mayo' or mes = 'Junio'"
                trim = "Segundo"
            ElseIf (tbReintegro.Text = "07") Or (tbReintegro.Text = "7") Or (tbReintegro.Text = "08") Or (tbReintegro.Text = "8") Or (tbReintegro.Text = "09") Or (tbReintegro.Text = "9") Then
                sql = "SELECT ingresosProv, ingresosOtros FROM ingresos WHERE mes = 'Julio' or mes = 'Agosto' or mes = 'Septiembre'"
                trim = "Tercero"
            ElseIf (tbReintegro.Text = "10") Or (tbReintegro.Text = "11") Or (tbReintegro.Text = "12") Then
                sql = "SELECT ingresosProv, ingresosOtros FROM ingresos WHERE mes = 'Octubre' or mes = 'Noviembre' or mes = 'Diciembre'"
                trim = "Cuarto"
            End If

            'Si no tiene mes de reintegro, buscamos por la fecha de del Comprobante
        Else
            If tbMonth.Text <> "" Then
                'No existe el mes cero
                If (tbMonth.Text = "0") Then
                    MsgBox("El mes Cero (0) no existe", MsgBoxStyle.Critical, "Error")
                    Return (0)
                    'Buscamos por trimestres
                ElseIf (tbMonth.Text = "01") Or (tbMonth.Text = "1") Or (tbMonth.Text = "02") Or (tbMonth.Text = "2") Or (tbMonth.Text = "03") Or (tbMonth.Text = "3") Then
                    sql = "SELECT ingresosProv, ingresosOtros FROM ingresos WHERE mes = 'Enero' or mes = 'Febrero' or mes = 'Marzo'"
                    trim = "Primero"
                ElseIf (tbMonth.Text = "04") Or (tbMonth.Text = "4") Or (tbMonth.Text = "05") Or (tbMonth.Text = "5") Or (tbMonth.Text = "06") Or (tbMonth.Text = "6") Then
                    sql = "SELECT ingresosProv, ingresosOtros FROM ingresos WHERE mes = 'Abril' or mes = 'Mayo' or mes = 'Junio'"
                    trim = "Segundo"
                ElseIf (tbMonth.Text = "07") Or (tbMonth.Text = "7") Or (tbMonth.Text = "08") Or (tbMonth.Text = "8") Or (tbMonth.Text = "09") Or (tbMonth.Text = "9") Then
                    sql = "SELECT ingresosProv, ingresosOtros FROM ingresos WHERE mes = 'Julio' or mes = 'Agosto' or mes = 'Septiembre'"
                    trim = "Tercero"
                ElseIf (tbMonth.Text = "10") Or (tbMonth.Text = "11") Or (tbMonth.Text = "12") Then
                    sql = "SELECT ingresosProv, ingresosOtros FROM ingresos WHERE mes = 'Octubre' or mes = 'Noviembre' or mes = 'Diciembre'"
                    trim = "Cuarto"
                End If
            End If
        End If


        'Consultamos la BD
        If conectar() = True Then
            Return (0)
            Exit Function
        End If
        consultar(sql, command)
        desconectar()

        'Sacamos el resultado
        adapter = New SqlCeDataAdapter(command)
        adapter.Fill(dataset.Tables("ingresos"))
        'Recorrer el dataset
        Dim itotal As Double = 0.0
        For i = 0 To dataset.Tables("ingresos").Rows.Count - 1
            itotal = itotal + Val(dataset.Tables("ingresos").Rows.Item(i).Item("ingresosProv")) _
                + Val(dataset.Tables("ingresos").Rows.Item(i).Item("ingresosOtros"))
        Next i

        'Consulta de saldos del mes trimestre
        sql = "SELECT saldo FROM saldos WHERE trimestre = @trim"
        command.Parameters.AddWithValue("@trim", trim)
        If conectar() = True Then
            Return (0)
            Exit Function
        End If
        consultar(sql, command)
        desconectar()

        'Sacamos el resultado
        adapter = New SqlCeDataAdapter(command)
        adapter.Fill(dataset.Tables("saldos"))

        'Sumamos (o restamos) el saldo del trimestre a los ingresos totales
        itotal = itotal + Val(dataset.Tables("saldos").Rows.Item(0).Item("saldo"))

        'Comparamos saldo disponible vs monto ingresado
        If (Val(tbMonto.Text) <= Val(itotal)) Then
            Return (True)
        Else : Return (False)
        End If

    End Function
    'Verificación de comprobante repetido
    Private Function esrepetido()

        Dim query As String = "SELECT num_comprobante, proveedor FROM egresos WHERE (num_comprobante=@compro) AND (proveedor=@provee)"
        Dim dataset As DataSet = New DataSet
        dataset.Tables.Add("egresos")
        command.Parameters.AddWithValue("@compro", tbPVenta.Text + "-" + tbNComprobante.Text)
        command.Parameters.AddWithValue("@provee", tbProveedor.Text)

        consultar(query, command)

        Dataset.Tables.Add("egresos")
        Adapter = New SqlCeDataAdapter(command)
        Adapter.Fill(Dataset.Tables("egresos"))

        If (Dataset.Tables("egresos").Rows.Count() = 0) Then
            Return False
        Else
            Return True
        End If

    End Function
    'Verificación de campos obligatorios
    Private Function camposVacios()
        'NOMBRE
        If (tbNombre.Text = Nothing) Then
            MsgBox("Ingrese un Nombre", MsgBoxStyle.Exclamation, "Error")
            tbNombre.BackColor = Color.LightSalmon
            tbNombre.Focus()
            Return (True)
        Else : tbNombre.BackColor = Color.White
        End If
        'TIPO DE GASTO
        If (tbGasto.Text = Nothing) Then
            MsgBox("Ingrese un tipo de Gasto", MsgBoxStyle.Exclamation, "Error")
            tbGasto.BackColor = Color.LightSalmon
            tbGasto.Focus()
            Return (True)
        Else : tbGasto.BackColor = Color.White
        End If
        'PROVEEDOR
        If (tbProveedor.Text = Nothing) Then
            MsgBox("Ingrese un Proveedor", MsgBoxStyle.Exclamation, "Error")
            tbProveedor.BackColor = Color.LightSalmon
            tbProveedor.Focus()
            Return (True)
        Else : tbProveedor.BackColor = Color.White
        End If
        'MES DE REINTEGRO
        If (tbReintegro.Text = "") Then
            tbReintegro.Text = "00"
        End If
        If (tbReintegro.Text > 12) Then
            MsgBox("Mes de Reintegro Erroneo (Mayor a 12)", MsgBoxStyle.Exclamation, "Error")
            tbReintegro.BackColor = Color.LightSalmon
            tbReintegro.Focus()
            Return (True)
        Else : tbReintegro.BackColor = Color.White
        End If
        'UDA LA RIOJA O CENTRAL
        If (ckCentral.Checked = False) And (ckLarioja.Checked = False) Then
            MsgBox("Seleccione UDA Central o LR", MsgBoxStyle.Exclamation, "Error")
            ckCentral.BackColor = Color.LightSalmon
            ckLarioja.BackColor = Color.LightSalmon
            Return (True)
        Else
            ckCentral.BackColor = Color.FromArgb(240, 240, 240)
            ckLarioja.BackColor = Color.FromArgb(240, 240, 240)
        End If
        'Tipo de Comprobante
        If (tbTComprobante.Text = Nothing) Then
            MsgBox("Ingrese un Tipo de Comprobante", MsgBoxStyle.Exclamation, "Error")
            tbTComprobante.BackColor = Color.LightSalmon
            tbTComprobante.Focus()
            Return (True)
        Else : tbTComprobante.BackColor = Color.White
        End If
        'NUMERO DE COMPROBANTE
        If (tbNComprobante.Text = Nothing) Then
            MsgBox("Ingrese un Número de Comprobante", MsgBoxStyle.Exclamation, "Error")
            tbNComprobante.BackColor = Color.LightSalmon
            tbPVenta.BackColor = Color.LightSalmon
            tbPVenta.Focus()
            Return (True)
        Else
            tbNComprobante.BackColor = Color.White
            tbPVenta.BackColor = Color.White
        End If
        'MONTO
        If (tbMonto.Text = Nothing) Then
            MsgBox("Ingrese el Monto", MsgBoxStyle.Exclamation, "Error")
            tbMonto.BackColor = Color.LightSalmon
            tbMonto.Focus()
            Return (True)
        Else : tbMonto.BackColor = Color.White
        End If

        'Si no hay error
        Return (False)

    End Function
    'Verificación de fechas inválidas
    Private Function fechainvalida()

    End Function

End Class
