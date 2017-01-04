Imports System.Data.SqlServerCe

Public Class ABMEgresos

    Private Sub ABMEgresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbYear.Text = ultimoaño()
        tbNombre.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim chkFecha As String = ""

        'Campos requeridos que están vacios
        If (camposVacios() = True) Then
            Exit Sub
        Else
            'Fechas inválidas
            If (fechainvalida(chkFecha) = True) Then
                Exit Sub
            Else
                'Comprobante repetido
                If (esrepetido() = True) Then
                    Exit Sub
                Else
                    'Ingresos disponibles
                    If (hayingresos() = False) Then
                        'No cuenta con ingresos
                    Else
                        'GUARDAR
                        If (MsgBox("Está seguro?", MsgBoxStyle.OkCancel, "Guardar?") = MsgBoxResult.Ok) Then
                            conectar()
                            'Consultamos la BD
                            If conectar() = False Then
                                MsgBox("No se pudo conectar a la base de datos", MsgBoxStyle.Critical, "Error")
                                Exit Sub
                            End If

                            Dim sql As String = ""
                            sql = "INSERT INTO egresos (num_comprobante, pventa, proveedor, tipo_gasto, nombre, " + _
                                "fecha, tipo_comprobante, mes, uda, comentario, monto, dia) VALUES " + _
                                "(@ncomp,@pventa,@provee,@tgasto,@nombre,@fecha,@tcompr,@mes,@uda,@comen,@monto,@dia)"
                            Dim command As New SqlCeCommand
                            command.Parameters.AddWithValue("@ncomp", tbNComprobante.Text)
                            command.Parameters.AddWithValue("@pventa", tbPVenta.Text)
                            command.Parameters.AddWithValue("@provee", tbProveedor.Text)
                            command.Parameters.AddWithValue("@tgasto", tbGasto.Text)
                            command.Parameters.AddWithValue("@nombre", tbNombre.Text)
                            command.Parameters.AddWithValue("@fecha", chkFecha)
                            command.Parameters.AddWithValue("@tcompr", tbTComprobante.Text)
                            command.Parameters.AddWithValue("@mes", tbReintegro.Text)
                            If ckCentral.Checked = True Then
                                command.Parameters.AddWithValue("@uda", ckCentral.Text)
                            Else : command.Parameters.AddWithValue("@uda", ckLarioja.Text)
                            End If
                            command.Parameters.AddWithValue("@comen", tbComentario.Text)
                            command.Parameters.AddWithValue("@monto", tbMonto.Text)
                            command.Parameters.AddWithValue("@dia", Now)
                            'Consultamos
                            consultar(sql, command)
                            'Desconectamos
                            desconectar()

                            'Actualizamos tabla de saldos
                            'saldosUpdate()
                        End If
                    End If
                End If
            End If
        End If

    End Sub


    'Verificación de ingresos disponibles
    Private Function hayingresos()

        'Solamente consultamos el saldo disponible del trimestre que se quiere cargar
        Dim command As New SqlCeCommand
        Dim adapter As SqlCeDataAdapter
        Dim dataset As New DataSet
        dataset.Tables.Add("saldos")
        Dim sql As String = "SELECT saldo FROM saldos WHERE trimestre=@trim"
        Dim trimestre As String = ""

        If ((tbMonth.Text = "01") Or (tbMonth.Text = "1") Or (tbMonth.Text = "02") Or (tbMonth.Text = "2") Or _
            (tbMonth.Text = "03") Or (tbMonth.Text = "3")) Then
            trimestre = "Primero"
        ElseIf ((tbMonth.Text = "04") Or (tbMonth.Text = "4") Or (tbMonth.Text = "05") Or (tbMonth.Text = "5") Or _
        (tbMonth.Text = "06") Or (tbMonth.Text = "6")) Then
            trimestre = "Segundo"
        ElseIf ((tbMonth.Text = "07") Or (tbMonth.Text = "7") Or (tbMonth.Text = "08") Or (tbMonth.Text = "8") Or _
        (tbMonth.Text = "09") Or (tbMonth.Text = "9")) Then
            trimestre = "Tercero"
        ElseIf ((tbMonth.Text = "10") Or (tbMonth.Text = "11") Or (tbMonth.Text = "12")) Then
            trimestre = "Cuarto"
        End If
        command.Parameters.AddWithValue("@trim", trimestre)

        'Consultamos la BD
        If conectar() = False Then
            MsgBox("No se pudo conectar a la base de datos", MsgBoxStyle.Critical, "Error")
            Return (False)
        End If
        consultar(sql, command)
        desconectar()

        'Sacamos el resultado
        adapter = New SqlCeDataAdapter(command)
        adapter.Fill(dataset.Tables("saldos"))

        If (dataset.Tables("saldos").Rows.Count() <> 0) Then
            'Comparamos saldo disponible vs monto ingresado
            If (Val(tbMonto.Text) <= Val(dataset.Tables("egresos").Rows.Item(0).Item("monto"))) Then
                Return (True)
            Else
                MsgBox("Su saldo será NEGATIVO", MsgBoxStyle.Critical, "Warning")
                Return (False)
            End If
        Else
            MsgBox("No se cargaron ingresos para el trimestre: " + trimestre + " Año: " + tbYear.Text, _
                   MsgBoxStyle.Critical, "Warning")
            Return (False)
        End If
        

    End Function
    'Verificación de comprobante repetido
    Private Function esrepetido()

        Dim command As New SqlCeCommand
        Dim adapter As SqlCeDataAdapter
        Dim query As String = "SELECT num_comprobante, proveedor FROM egresos WHERE (num_comprobante=@compro) AND (pventa=@pventa) AND (proveedor=@provee)"
        Dim dataset As DataSet = New DataSet
        dataset.Tables.Add("egresos")
        command.Parameters.AddWithValue("@compro", tbNComprobante.Text)
        command.Parameters.AddWithValue("@provee", tbProveedor.Text)
        command.Parameters.AddWithValue("@pventa", tbPVenta.Text)

        'Consultamos la BD
        If conectar() = False Then
            MsgBox("No se pudo conectar a la base de datos", MsgBoxStyle.Critical, "Error")
            Return (True)
        End If
        consultar(query, command)
        desconectar()

        adapter = New SqlCeDataAdapter(command)
        adapter.Fill(dataset.Tables("egresos"))

        If (dataset.Tables("egresos").Rows.Count() <> 0) Then
            MsgBox("Ese comprobante ya fue cargado", MsgBoxStyle.Critical, "Error")
            Return True
        Else
            Return False
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
    Private Function fechainvalida(ByRef chkFecha As String)
        chkFecha = tbDay.Text & "/" & tbMonth.Text & "/" & tbYear.Text

        'Box vacio
        If (chkFecha = Nothing) Then
            MsgBox("Ingrese una Fecha", MsgBoxStyle.Exclamation, "Error")
            tbDay.BackColor = Color.LightSalmon
            tbMonth.BackColor = Color.LightSalmon
            tbDay.Focus()
            Return (True)
        Else
            tbDay.BackColor = Color.White
            tbMonth.BackColor = Color.White
        End If

        'Fecha tipo Datetime
        If (IsDate(chkFecha) = False) Then
            MsgBox("Fecha iválida", MsgBoxStyle.Exclamation, "Error")
            tbDay.BackColor = Color.LightSalmon
            tbMonth.BackColor = Color.LightSalmon
            tbDay.Focus()
            Return (True)
        Else
            tbDay.BackColor = Color.White
            tbMonth.BackColor = Color.White
        End If

        'Si no hay error
        Return (False)

    End Function
    Private Sub saldosUpdate(ByVal saldo As Double, ByVal trimestre As String)
        Dim sql As String = "UPDATE saldos SET saldo=@saldo WHERE trimestre = @trimestre"
        Dim command As New SqlCeCommand
        command.Parameters.AddWithValue("@ncomp", tbNComprobante.Text)
        command.Parameters.AddWithValue("@trimestre", trimestre)
        command.Parameters.AddWithValue("@saldo", saldo)
        If conectar() = False Then
            MsgBox("No se pudo conectar a la base de datos", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        consultar(sql, command)
        desconectar()

    End Sub
    

    'Cambiar el año con doble click
    Private Sub ABMIngresos_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        If e.X > tbYear.Location.X And e.X < tbYear.Location.X + tbYear.Width And _
        e.Y > tbYear.Location.Y And e.Y < tbYear.Location.Y + tbYear.Height Then
            tbYear.Enabled = True
        Else
        End If
        tbYear.Focus()
    End Sub
    'Al perder el foco el año
    Private Sub tbYear_LostFocus(sender As Object, e As EventArgs) Handles tbYear.LostFocus
        tbYear.Enabled = False
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
            MsgBox("No se pudo conectar a la base de datos", MsgBoxStyle.Critical, "Error")
            Return (0)
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


    'No se pueden checkear los dos al mismo tiempo
    Private Sub ckLarioja_CheckedChanged(sender As Object, e As EventArgs) Handles ckLarioja.CheckedChanged
        If ckCentral.Checked = True Then
            ckLarioja.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub ckCentral_CheckedChanged(sender As Object, e As EventArgs) Handles ckCentral.CheckedChanged
        If ckLarioja.Checked = True Then
            ckCentral.CheckState = CheckState.Unchecked
        End If
    End Sub


    'Verificación de entrada de numeros
    Private Sub chkKey(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then 'Letras -> no
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then 'Caracter de control -> si
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then 'Espacio en blanco -> no
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) Then 'Numeros -> si
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub
    Private Sub tbReintegro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbReintegro.KeyPress
        chkKey(e)
    End Sub
    Private Sub tbDay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDay.KeyPress
        chkKey(e)
    End Sub
    Private Sub tbMonth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMonth.KeyPress
        chkKey(e)
    End Sub
    Private Sub tbYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbYear.KeyPress
        chkKey(e)
        If e.KeyChar = ChrW(Keys.Enter) Then
            tbYear.Enabled = False
        End If
    End Sub
    Private Sub tbNComprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNComprobante.KeyPress
        chkKey(e)
    End Sub
    Private Sub tbPVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPVenta.KeyPress
        chkKey(e)
    End Sub
    Private Sub tbMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbMonto.KeyPress
        chkKey(e)
        If (e.KeyChar = ",") Then 'Comas -> si
            e.Handled = False
        End If
    End Sub

End Class
