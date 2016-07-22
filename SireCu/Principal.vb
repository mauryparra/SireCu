Public Class Principal

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AdminPantallas(ByVal pantalla As String)
        Dim bandera As Boolean = False

        ' Controla que la pantalla no se encuentre cargada, en dicho caso la hace visible
        For Each ctrl As Control In SplitContainerPrincipal.Panel2.Controls
            If pantalla = ctrl.Name Then
                ctrl.Show()
                bandera = True
            Else

                ' TO DO ver si es necesario
                ctrl.Hide()
            End If
        Next

        If bandera = False Then
            Select Case pantalla
                Case "ABMIngresos"
                    Dim pantallaABMIngresos As ABMIngresos = New ABMIngresos()
                    pantallaABMIngresos.Dock = DockStyle.Fill
                    SplitContainerPrincipal.Panel2.Controls.Add(pantallaABMIngresos)
                Case 2

                Case Else
                    MessageBox.Show("Error del administrador de pantallas")

            End Select

        End If

    End Sub

    Private Sub RadioButtonIngresos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonIngresos.CheckedChanged
        AdminPantallas("ABMIngresos")
    End Sub
End Class
