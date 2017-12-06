Imports System.ComponentModel

Public Class ABMUsuarios

    Dim ControlesConErrores As List(Of Control) = New List(Of Control)

#Region "Botones"

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        DGVAdmin.Enabled = False

        tb_Usuario.Enabled = True
        cb_Rol.Enabled = True
        tb_Contraseña.Enabled = True

        btn_Nuevo.Enabled = False
        btn_Modificar.Enabled = False
        btn_Cancelar.Enabled = True
        btn_Eliminar.Enabled = False
        btn_Guardar.Enabled = True
    End Sub
    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        DGVAdmin.Enabled = False

        tb_Usuario.Enabled = True
        cb_Rol.Enabled = True
        tb_Contraseña.Enabled = True

        btn_Nuevo.Enabled = False
        btn_Modificar.Enabled = False
        btn_Cancelar.Enabled = True
        btn_Eliminar.Enabled = False
        btn_Guardar.Enabled = True
        btn_Guardar.Text = "Actualizar"
    End Sub
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        tb_Usuario.Text = Nothing
        tb_Contraseña.Text = Nothing
        cb_Rol.Text = Nothing

        btn_Modificar.Enabled = False
        btn_Guardar.Enabled = False
        btn_Guardar.Text = "Guardar"
        btn_Eliminar.Enabled = False
        btn_Cancelar.Enabled = False
        btn_Nuevo.Enabled = True

        tb_Usuario.Enabled = False
        tb_Contraseña.Enabled = False
        cb_Rol.Enabled = False

        DGVAdmin.Enabled = True
    End Sub
    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click

        ' Verificamos validaciones
        If ((cb_Rol.Text <> "Administrador") And (cb_Rol.Text <> "Contador") And
            (cb_Rol.Text <> "Usuario")) Or
            IsDBNull(sender.Text) Or (cb_Rol.Text = "") Then
            Principal.ErrorProvider.SetError(cb_Rol, "Debe ingresar una opción válida")
            If Not ControlesConErrores.Contains(cb_Rol) Then
                ControlesConErrores.Add(cb_Rol)
            End If
        Else
            Principal.ErrorProvider.SetError(cb_Rol, "")
            If ControlesConErrores.Contains(cb_Rol) Then
                ControlesConErrores.Remove(cb_Rol)
            End If
        End If

        If ControlesConErrores.Count > 0 Then
            MsgBox("Por favor revise los campos ingresados", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        Select Case btn_Guardar.Text
            Case "Actualizar"

                If (exist("Usuarios", "usuario", tb_Usuario.Text) = True) Then
                    If LCase(tb_Usuario.Text) <> LCase(DGVAdmin.CurrentRow.Cells(1).Value) Then
                        MsgBox("El nombre de usuario ingresado ya se encuentra utilizado." &
                           vbCrLf & "Por favor, intentelo con otro nuevamente.", MsgBoxStyle.Exclamation, "Usuario Inválido")
                        Exit Sub
                    End If
                End If

                If (MsgBox("Quiere Modificar al usuario " & DGVAdmin.CurrentRow.Cells(1).Value & "?",
                         MsgBoxStyle.OkCancel, "Modificar?") = MsgBoxResult.Ok) Then

                    Dim contraseña As String = ""
                    If tb_Contraseña.Text = Usuario.GetHashedPassword(DGVAdmin.CurrentRow.Cells(1).Value) Then
                        contraseña = tb_Contraseña.Text
                    Else
                        contraseña = Usuario.CreateHashedPassword(tb_Contraseña.Text, Usuario.GetSalt(DGVAdmin.CurrentRow.Cells(1).Value))
                    End If

                    Principal.query = "UPDATE [Usuarios] SET " &
                                        "usuario = '" & tb_Usuario.Text &
                                        "' ,contraseña = '" & contraseña &
                                        "' ,rol = '" & cb_Rol.Text &
                                        "' WHERE id= '" & DGVAdmin.CurrentRow.Cells(0).Value & "'"
                    consultarNQ(Principal.query, Principal.command)

                    MsgBox("Modificado Correctamente!", MsgBoxStyle.Information, "Modificado")
                Else
                    Exit Sub
                End If
            Case "Guardar"

                If (exist("Usuarios", "usuario", tb_Usuario.Text) = True) Then
                    MsgBox("El nombre de usuario ingresado ya se encuentra utilizado." &
                           vbCrLf & "Por favor, intentelo con otro nuevamente.", MsgBoxStyle.Exclamation, "Usuario Inválido")
                    Exit Sub
                End If

                If (MsgBox("Guardar nuevo usuario?", MsgBoxStyle.OkCancel, "Guardar?") = MsgBoxResult.Ok) Then

                    Dim salt As String = Usuario.CreateRandomSalt()
                    Dim contraseña As String = Usuario.CreateHashedPassword(tb_Contraseña.Text, salt)

                    Principal.query = "INSERT INTO [Usuarios] (usuario, contraseña, rol, salt) 
                                VALUES ('" &
                                     tb_Usuario.Text & "', '" & contraseña &
                                     "', '" & cb_Rol.Text & "', '" & salt & "')"
                    consultarNQ(Principal.query, Principal.command)

                    MsgBox("Guardado Correctamente!", MsgBoxStyle.Information, "Guardado")
                Else
                    Exit Sub
                End If
        End Select

        tb_Usuario.Text = Nothing
        tb_Contraseña.Text = Nothing
        cb_Rol.Text = Nothing

        btn_Modificar.Enabled = False
        btn_Guardar.Enabled = False
        btn_Guardar.Text = "Guardar"
        btn_Eliminar.Enabled = False
        btn_Cancelar.Enabled = False
        btn_Nuevo.Enabled = True

        tb_Usuario.Enabled = False
        tb_Contraseña.Enabled = False
        cb_Rol.Enabled = False

        DGVAdmin.Enabled = True

        'Actualizamos el grid
        cargarDatos()

    End Sub
    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        'Verificacion de selección
        If DGVAdmin.SelectedCells.Count = 0 Then
            MsgBox("Por favor seleccione un registro", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        'No eliminar usuario logueado
        If DGVAdmin.CurrentRow.Cells("usuario").Value = Principal.userLogueado Then
            MsgBox("No puede eliminarse a si mismo", MsgBoxStyle.Exclamation, "Error")
        Else
            If (MsgBox("Eliminar registro?", MsgBoxStyle.OkCancel, "Eliminar?") = MsgBoxResult.Ok) Then

                Principal.query = "DELETE FROM [Usuarios] WHERE id = '" &
                DGVAdmin.CurrentRow.Cells(0).Value & "'"
                consultarNQ(Principal.query, Principal.command)

                MsgBox("Eliminado correctamente", MsgBoxStyle.Information, "Eliminado")
            End If
        End If

        tb_Usuario.Text = Nothing
        tb_Contraseña.Text = Nothing
        cb_Rol.Text = Nothing

        btn_Modificar.Enabled = False
        btn_Guardar.Enabled = False
        btn_Guardar.Text = "Guardar"
        btn_Eliminar.Enabled = False
        btn_Cancelar.Enabled = False
        btn_Nuevo.Enabled = True

        tb_Usuario.Enabled = False
        tb_Contraseña.Enabled = False
        cb_Rol.Enabled = False

        DGVAdmin.Enabled = True

        'Actualizamos el grid
        cargarDatos()

    End Sub

#End Region

#Region "Eventos"

    Private Sub ABMUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarDatos()
    End Sub
    Private Sub DGVAdmin_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVAdmin.CellFormatting
        If (e.ColumnIndex = 2) Then
            e.Value = New String("*", e.Value.ToString.Length)
        End If
    End Sub
    Private Sub DGVAdmin_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVAdmin.CellMouseDoubleClick
        If e.RowIndex >= 0 Then
            tb_Usuario.Text = DGVAdmin.CurrentRow.Cells("usuario").Value
            tb_Contraseña.Text = DGVAdmin.CurrentRow.Cells("contraseña").Value
            cb_Rol.Text = DGVAdmin.CurrentRow.Cells("rol").Value

            DGVAdmin.Enabled = False

            btn_Modificar.Enabled = True
            btn_Cancelar.Enabled = True
            btn_Eliminar.Enabled = True
            btn_Nuevo.Enabled = False
        End If
    End Sub

#End Region

#Region "Helpers"

    Private Sub cargarDatos()

        cargarTablaEnDataSet("Usuarios")

        Dim bindSource As New BindingSource
        bindSource.DataSource = Principal.dataset.Tables("Usuarios")
        DGVAdmin.DataSource = bindSource
        DGVAdmin.Columns.Item("id").Visible = False
        DGVAdmin.Columns.Item("usuario").HeaderText = "Usuario"
        DGVAdmin.Columns.Item("contraseña").HeaderText = "Contraseña"
        DGVAdmin.Columns.Item("rol").HeaderText = "Rol"
        DGVAdmin.Columns.Item("salt").Visible = False

    End Sub

#End Region

#Region "Validaciones"

    Private Sub cb_Rol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_Rol.KeyPress
        keyverify(e, letras:=True)
    End Sub

#End Region

End Class
