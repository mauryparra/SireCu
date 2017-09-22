Imports System.ComponentModel

Public Class Config

    Dim ControlesConErrores As List(Of Control) = New List(Of Control)

#Region "Botones"

    Private Sub bttn_Guardar_Click(sender As Object, e As EventArgs) Handles bttn_Guardar.Click

        ' Verificamos que todos los campos hayan pasado las validaciones
        If ControlesConErrores.Count > 0 Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If (MsgBox("Está seguro?" & vbCrLf & "Puede volver a configurarlo desde el menú 'Editar'", MsgBoxStyle.OkCancel, "Guardar?") = MsgBoxResult.Ok) Then

            If (obtenerSeccional() = "") Then
                Principal.query = "INSERT INTO [Seccionales] ([nombre]) VALUES ('" & tbSeccional.Text & "')"
            Else
                Dim idSeccional As Integer = obtenerID("Seccionales", "nombre", "UDA Central", True)
                Principal.query = "UPDATE Seccionales SET [nombre]='" & tbSeccional.Text & "' WHERE id='" & idSeccional & "'"
            End If

            consultarNQ(Principal.query, Principal.command)

            MsgBox("Guardado Correctamente!", MsgBoxStyle.Information, "Guardado")

        End If

        Close()

    End Sub

#End Region

#Region "Validaciones"

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSeccional.KeyPress
        keyverify(e, letras:=True, numeros:=True, espacios:=True)
    End Sub
    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles tbSeccional.Validating
        If (sender.Text = "") Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Seccional")
            If Not ControlesConErrores.Contains(sender) Then
                ControlesConErrores.Add(sender)
            End If
        ElseIf (LCase(tbSeccional.Text) = "uda central") Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Seccional distinta")
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