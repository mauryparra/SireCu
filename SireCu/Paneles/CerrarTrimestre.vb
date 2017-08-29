Imports System.ComponentModel

Public Class CerrarTrimestre

    Dim ControlesConErrores As List(Of Control) = New List(Of Control)

#Region "Botones"

    Private Sub btn_Ver_Click(sender As Object, e As EventArgs) Handles btn_Ver.Click

        'Verificamos que todos los campos hayan pasado las validaciones
        If ControlesConErrores.Count > 0 Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        ElseIf (tb_Año.Text = "" Or cb_Trimestre.Text = "") Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If


        Dim query As String = ""
        Dim idTrimAnterior As Integer = obtenerID("Trimestres", "nombre", obtenerTrimAnterior(cb_Trimestre.Text))

        tb_Info.Text = vbCrLf & "El Trimestre seleccionado contiene la siguiente información:"

        'Información del Saldo Inicial
        If cb_Trimestre.Text = "Primero" Then
            query = "SELECT saldo_final FROM Saldos WHERE trimestre_id=" &
                idTrimAnterior & " AND año=" &
                (tb_Año.Text - 1)
        Else
            query = "SELECT saldo_final FROM Saldos WHERE trimestre_id=" &
                idTrimAnterior & " AND año=" &
                tb_Año.Text
        End If
        Dim dt As DataTable = consultarReader(query)
        If dt.Rows.Count = 0 Then
            tb_Info.Text = tb_Info.Text & vbCrLf & vbCrLf & "Saldo Inicial: " & vbCrLf &
            "$ 0,0"
        Else
            tb_Info.Text = tb_Info.Text & vbCrLf & vbCrLf & "Saldo Inicial: " & vbCrLf &
            Format(dt.Rows(0).Item("saldo_final"), "$ #,###,##0.00")
        End If
        'Información del Total de Ingresos
        tb_Info.Text = tb_Info.Text & vbCrLf & vbCrLf & "Ingresos Totales: " & vbCrLf &
            Format(obtenerIngresos(cb_Trimestre.Text, tb_Año.Text),
                   "$ #,###,##0.00")
        'Información del Total de Egresos
        tb_Info.Text = tb_Info.Text & vbCrLf & vbCrLf & "Egresos Totales: " & vbCrLf &
            Format(obtenerEgresosTotales(cb_Trimestre.Text, tb_Año.Text, "full"),
                   "$ #,###,##0.00")
        'Información del Saldo Final
        tb_Info.Text = tb_Info.Text & vbCrLf & vbCrLf & "Saldo Final: " & vbCrLf &
            Format(SaldoActual(cb_Trimestre.Text, tb_Año.Text),
                   "$ #,###,##0.00")

        btn_Cerrar.Enabled = True

    End Sub
    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click

        Dim saldo As Double = SaldoActual(cb_Trimestre.Text, tb_Año.Text)
        cierraTrimestre(tb_Año.Text, obtenerID("Trimestres", "nombre", cb_Trimestre.Text),
                           saldo)

        btn_Cerrar.Enabled = False
        tb_Año.Text = ""
        cb_Trimestre.Text = ""
        tb_Info.Text = ""

    End Sub

#End Region

#Region "Eventos"

#End Region

#Region "Helpers"

    Private Function obtenerTrimAnterior(ByVal trimestre As String)

        Dim trimAnterior As String = ""

        Select Case trimestre
            Case "Primero"
                trimAnterior = "Cuarto"
            Case "Segundo"
                trimAnterior = "Primero"
            Case "Tercero"
                trimAnterior = "Segundo"
            Case "Cuarto"
                trimAnterior = "Tercero"
        End Select

        Return (trimAnterior)

    End Function

#End Region

#Region "Validaciones"

    Private Sub CerrarTrimestre_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        cb_Trimestre.Text = ""
        tb_Año.Text = ""
        tb_Info.Text = ""
        btn_Cerrar.Enabled = False

        ControlesConErrores.Clear()
    End Sub

    Private Sub tb_Año_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Año.KeyPress
        keyverify(e, numeros:=True)
    End Sub
    Private Sub cb_Trimestre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_Trimestre.KeyPress
        keyverify(e, letras:=True)
    End Sub
    Private Sub cb_Trimestre_Validating(sender As Object, e As CancelEventArgs) Handles cb_Trimestre.Validating
        If (cb_Trimestre.Text <> "Primero") And (cb_Trimestre.Text <> "Segundo") And (cb_Trimestre.Text <> "Tercero") And
            (cb_Trimestre.Text <> "Cuarto") Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Trimestre válido")
            If Not ControlesConErrores.Contains(sender) Then
                ControlesConErrores.Add(sender)
            End If

        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErrores.Remove(sender)
        End If
    End Sub

#End Region

End Class
