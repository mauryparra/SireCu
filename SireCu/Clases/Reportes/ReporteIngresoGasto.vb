Public Class ReporteIngresoGasto

    Public trimestre As String
    Public año As Integer

    Private Sub ReporteIngresoGasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_Año.Text = año
        tb_Trimestre.Text = trimestre
    End Sub

End Class