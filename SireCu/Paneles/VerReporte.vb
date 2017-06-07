Imports System.ComponentModel

Public Class VerReporte

    Dim sql As String = ""
    Dim ControlesConErrores As List(Of Control) = New List(Of Control)


#Region "Botones"

    Private Sub btn_Ver_Click(sender As Object, e As EventArgs) Handles btn_Ver.Click

        'Verificamos que todos los campos hayan pasado las validaciones
        If ControlesConErrores.Count > 0 Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        Else

            Dim filtros As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))

            If Not cb_Trimestre.SelectedItem = "" Then
                filtros.Add(New KeyValuePair(Of String, String)("trimestre", cb_Trimestre.SelectedItem))
            End If

            If Not tb_Año.Text = "" Then
                filtros.Add(New KeyValuePair(Of String, String)("año", tb_Año.Text))
            End If

            'SQL Básico
            sql = "SELECT TOP (100) R.id AS id,
                                  R.año AS Año,
                                  Trim.nombre AS Trimestre                             
                           FROM ReportesTrimestrales AS R
                           LEFT JOIN Trimestres AS Trim ON R.trimestre_id = Trim.id WHERE R.id >= 0"


            ' Aplicar Filtros al SQL

            For Each keyv As KeyValuePair(Of String, String) In filtros
                ' Filtrar por trimestre
                If keyv.Key = "trimestre" Then
                    sql += " AND Trim.nombre LIKE '" & keyv.Value & "'"
                    ' Filtrar por año
                ElseIf keyv.Key = "año" Then
                    sql += " AND R.año =" & keyv.Value
                End If
            Next
            sql += " ORDER BY R.año DESC"

            CargarReportes(dgv_Reportes, sql)

            bttn_Qfiltro.Enabled = True

        End If

    End Sub
    Private Sub bttn_Qfiltro_Click(sender As Object, e As EventArgs) Handles bttn_Qfiltro.Click
        sql = "SELECT TOP (100) R.id AS id,
                                  R.año AS Año,
                                  Trim.nombre AS Trimestre                             
                           FROM ReportesTrimestrales AS R
                           LEFT JOIN Trimestres AS Trim ON R.trimestre_id = Trim.id
                           ORDER BY R.año DESC"

        CargarReportes(dgv_Reportes, sql)

        bttn_Qfiltro.Enabled = False
        cb_Trimestre.Text = ""
        tb_Año.Text = ""
    End Sub

#End Region

#Region "Eventos"

    Private Sub dgv_Reportes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Reportes.CellContentClick

        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then

            Select Case dgv_Reportes.Columns(e.ColumnIndex).HeaderText
                Case "Ingresos - Gastos"
                    Dim nuevo_reporte As New ReporteIngresoGasto
                    nuevo_reporte.trimestre = dgv_Reportes.Rows(e.RowIndex).Cells(6).Value
                    nuevo_reporte.año = dgv_Reportes.Rows(e.RowIndex).Cells(5).Value
                    nuevo_reporte.Show()
                Case "Ingresos"
                    Dim nuevo_reporte As New ReporteIngreso
                    nuevo_reporte.trimestre = dgv_Reportes.Rows(e.RowIndex).Cells(6).Value
                    nuevo_reporte.año = dgv_Reportes.Rows(e.RowIndex).Cells(5).Value
                    nuevo_reporte.Show()
                Case "Egresos Seccional"
                    Dim nuevo_reporte As New ReporteEgresoSec
                    nuevo_reporte.trimestre = dgv_Reportes.Rows(e.RowIndex).Cells(6).Value
                    nuevo_reporte.año = dgv_Reportes.Rows(e.RowIndex).Cells(5).Value
                    nuevo_reporte.Show()
                Case "Egresos Central"
                    Dim nuevo_reporte As New ReporteEgresoCen
                    nuevo_reporte.trimestre = dgv_Reportes.Rows(e.RowIndex).Cells(6).Value
                    nuevo_reporte.año = dgv_Reportes.Rows(e.RowIndex).Cells(5).Value
                    nuevo_reporte.Show()
                Case Else
                    MsgBox("Error al seleccionar el reporte", MsgBoxStyle.Critical, "Error")
                    Exit Sub
            End Select

        End If

    End Sub
    Private Sub VerReporte_Load(sender As Object, e As EventArgs) Handles Me.Load

        sql = "SELECT TOP (100) R.id AS id,
                                  R.año AS Año,
                                  Trim.nombre AS Trimestre                             
                           FROM ReportesTrimestrales AS R
                           LEFT JOIN Trimestres AS Trim ON R.trimestre_id = Trim.id
                           ORDER BY R.año DESC"

        CargarReportes(dgv_Reportes, sql)

    End Sub

#End Region

#Region "Validaciones"

    Private Sub tb_Año_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Año.KeyPress
        keyverify(e, numeros:=True)
    End Sub
    Private Sub cb_Trimestre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_Trimestre.KeyPress
        keyverify(e, letras:=True, espacios:=True)
    End Sub

    Private Sub cb_Trimestre_Validating(sender As Object, e As CancelEventArgs) Handles cb_Trimestre.Validating
        If (cb_Trimestre.Text <> "Primero") And (cb_Trimestre.Text <> "Segundo") And (cb_Trimestre.Text <> "Tercero") And
            (cb_Trimestre.Text <> "Cuarto") Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Trimestre válido")
            ControlesConErrores.Add(sender)
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErrores.Remove(sender)
        End If
    End Sub

#End Region

End Class
