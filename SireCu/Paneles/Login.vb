Imports System.ComponentModel

Public Class Login

    Dim ControlesConErrores As List(Of Control) = New List(Of Control)

#Region "Botones"

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click

        'Validaciones TODO
        If verificarUsuario(tb_Usuario.Text, tb_Contraseña.Text) Then
            Principal.bttn_Login.Text = "Desloguear"
            Principal.stat_Label.Text = "Logueado como: " & tb_Usuario.Text
            Principal.userLogueado = tb_Usuario.Text

            ActualizarSaldo()
            permisosUsuarios(tb_Usuario.Text)

            ' Limpiamos todas las pantallas
            Principal.SplitContainerPrincipal.Panel2.Controls.Clear()
            Principal.AdminPantallas("Home")
        Else
            Principal.ErrorProvider.SetError(tb_Contraseña, "Usuario y/o Contraseña Inválido/s")
        End If

    End Sub

#End Region

#Region "Helpers"

    Private Sub permisosUsuarios(ByVal user As String)

        Select Case tipoDeUsuario(tb_Usuario.Text)
            Case "Administrador"
                Principal.btn_Ingresos.Enabled = True
                Principal.btn_Egresos.Enabled = True
                Principal.btn_VerReporte.Enabled = True
                Principal.btn_Administrar.Enabled = True
                Principal.EditarToolStripMenuItem.Enabled = True
                Principal.UsuariosToolStripMenuItem.Enabled = True
            Case "Contador"
                Principal.btn_Ingresos.Enabled = True
                Principal.btn_Egresos.Enabled = True
                Principal.btn_VerReporte.Enabled = True
                Principal.btn_Administrar.Enabled = True
                Principal.EditarToolStripMenuItem.Enabled = True
            Case "Usuario"
                Principal.btn_VerReporte.Enabled = True
        End Select
    End Sub

#End Region

#Region "Eventos"

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load

        tb_Usuario.Focus()

    End Sub

#End Region

#Region "Validaciones"

    Private Sub tb_Usuario_Validating(sender As Object, e As CancelEventArgs) Handles tb_Usuario.Validating
        If (sender.Text = "") Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar un Usuario")
            If Not ControlesConErrores.Contains(sender) Then
                ControlesConErrores.Add(sender)
            End If
        Else
            Principal.ErrorProvider.SetError(sender, "")
            ControlesConErrores.Remove(sender)
        End If
    End Sub
    Private Sub tb_Contraseña_Validating(sender As Object, e As CancelEventArgs) Handles tb_Contraseña.Validating
        If (sender.Text = "") Then
            Principal.ErrorProvider.SetError(sender, "Debe ingresar una Contraseña")
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
