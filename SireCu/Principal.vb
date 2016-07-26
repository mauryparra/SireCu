Public Class Principal

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub RadioButtonIngresos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonIngresos.CheckedChanged
        AdminPantallas("ABMIngresos")
    End Sub
    Private Sub RadioButtonEgresos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEgresos.CheckedChanged
        AdminPantallas("ABMEgresos")
    End Sub

    Private Sub AdminPantallas(ByVal pantalla As String)
        Dim bandera As Boolean = False

        ' Si la pantalla no se encuentra cargada, la hace visible
        For Each ctrl As Control In SplitContainerPrincipal.Panel2.Controls
            If pantalla = ctrl.Name Then
                ctrl.Show()
                bandera = True
            Else
                ctrl.Hide()
                bandera = False
            End If
        Next

        If bandera = False Then
            Select Case pantalla
                Case "ABMIngresos"
                    Dim pantallaABMIngresos As ABMIngresos = New ABMIngresos()
                    pantallaABMIngresos.Dock = DockStyle.Fill
                    SplitContainerPrincipal.Panel2.Controls.Add(pantallaABMIngresos)
                Case "ABMEgresos"
                    Dim pantallaABMEgresos As ABMEgresos = New ABMEgresos()
                    pantallaABMEgresos.Dock = DockStyle.Fill
                    SplitContainerPrincipal.Panel2.Controls.Add(pantallaABMEgresos)
                Case Else
                    MessageBox.Show("Error del administrador de pantallas")

            End Select

        End If

    End Sub

End Class
