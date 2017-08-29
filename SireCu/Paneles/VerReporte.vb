Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class VerReporte

    Dim sql As String = ""
    Dim command As New MySqlCommand()
    Dim dt As DataTable
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
        Else
            cargarGrid()
        End If

    End Sub

    Private Sub btn_Subir_Click(sender As Object, e As EventArgs) Handles btn_Subir.Click



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
    Private Function HayInternet() As Boolean

        If My.Computer.Network.IsAvailable() Then
            Try
                If My.Computer.Network.Ping("8.8.8.8") Then
                    Return (True)
                Else
                    Return (False)
                End If
            Catch exint As Exception
                Return (False)
            End Try
        Else
            Return (False)
        End If

    End Function

#End Region

#Region "Eventos"

    Private Sub dgv_Reportes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Reportes.CellContentClick

        Dim senderGrid = DirectCast(sender, DataGridView)

        'Verificamos que no se envíen los box vacios
        If (tb_Año.Text = "" Or cb_Trimestre.Text = "") Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then

            Select Case dgv_Reportes.Columns(e.ColumnIndex).HeaderText
                Case "Ingresos - Gastos"
                    generarRepIngGast(cb_Trimestre.Text, tb_Año.Text)
                Case "Ingresos"
                    generarRepIngresos(cb_Trimestre.Text, tb_Año.Text)
                Case "Egresos Seccional"
                    generarRepEgreSec(cb_Trimestre.Text, tb_Año.Text)
                Case "Egresos Central"
                    generarRepEgreCen(cb_Trimestre.Text, tb_Año.Text)
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
