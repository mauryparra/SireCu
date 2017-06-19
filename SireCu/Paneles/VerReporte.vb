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

            cargarGrid()

        End If

    End Sub

#End Region

#Region "Helpers"

    Private Sub cargarGrid()

        Dim i As Integer = 0
        Dim Array As String() = {"Ingresos - Gastos", "Ingresos", "Egresos Seccional", "Egresos Central"}

        dgv_Reportes.Rows.Clear()

        Do
            If Not dgv_Reportes.Columns.Contains(Array(i)) Then
                Dim column As New DataGridViewButtonColumn
                With column
                    .Name = Array(i)
                    .HeaderText = Array(i)
                    .Text = "Ver Reporte"
                    .DataPropertyName = Array(i)
                    .UseColumnTextForButtonValue = True
                End With
                dgv_Reportes.Columns.Add(column)
            End If
            i = i + 1
        Loop While i <= 3

        dgv_Reportes.Rows.Add()

    End Sub

#End Region

#Region "Eventos"

    Private Sub dgv_Reportes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Reportes.CellContentClick

        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then

            Select Case dgv_Reportes.Columns(e.ColumnIndex).HeaderText
                Case "Ingresos - Gastos"
                    generarRepIngGast(cb_Trimestre.Text, tb_Año.Text)
                Case "Ingresos"
                    generarRepIngresos(cb_Trimestre.Text, tb_Año.Text)
                Case "Egresos Seccional"

                Case "Egresos Central"

                Case Else
                    MsgBox("Error al seleccionar el reporte", MsgBoxStyle.Critical, "Error")
                    Exit Sub
            End Select

        End If

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
