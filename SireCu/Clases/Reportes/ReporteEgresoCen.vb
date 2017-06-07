Public Class ReporteEgresoCen

    Public trimestre As String
    Public año As Integer

    Private Sub ReporteEgresoCen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_Trimestre.Text = trimestre
        tb_Año.Text = año
    End Sub
End Class