Public Class ReporteIngreso

    Public trimestre As String
    Public año As Integer

    Private Sub ReporteIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_Año.Text = año
        tb_Trimestre.Text = trimestre
    End Sub

End Class