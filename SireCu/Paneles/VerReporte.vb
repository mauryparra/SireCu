Public Class VerReporte

    Private Sub btn_Abrir_Click(sender As Object, e As EventArgs) Handles btn_Abrir.Click

        'TODO Check campos requeridos

        'Mostrar todos los reportes de la selección
        Dim trimid As Integer
        Select Case cb_Trimestre.Text
            Case "Primero"
                trimid = 1
            Case "Segundo"
                trimid = 2
            Case "Tercero"
                trimid = 3
            Case "Cuarto"
                trimid = 4
            Case Else
                MsgBox("Trimestre ingresado inválido", MsgBoxStyle.Exclamation, "Error")
                Exit Sub
        End Select

        If existReporte(tb_Año.Text, trimid) = False Then
            MsgBox("No se generó ningún reporte en la fecha establecida", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        Select Case cb_Reporte.Text
            Case "Ingresos"
                Dim repIng As New ReporteIngreso
                repIng.trimestre = cb_Trimestre.Text
                repIng.año = tb_Año.Text
                repIng.Show()
            Case "Egresos Seccional"
                Dim repSec As New ReporteEgresoSec
                repSec.trimestre = cb_Trimestre.Text
                repSec.año = tb_Año.Text
                repSec.Show()
            Case "Egresos Central"
                Dim repCen As New ReporteEgresoCen
                repCen.trimestre = cb_Trimestre.Text
                repCen.año = tb_Año.Text
                repCen.Show()
            Case "Ingresos -Gastos"
                Dim repIngGas As New ReporteIngresoGasto
                repIngGas.trimestre = cb_Trimestre.Text
                repIngGas.año = tb_Año.Text
                repIngGas.Show()
        End Select

    End Sub

End Class
