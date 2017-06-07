Public Class CrearReporte

    Private Sub btn_Crear_Click(sender As Object, e As EventArgs) Handles btn_Crear.Click

        'TODO Validaciones de campos

        'TODO Verificaciones de reportes existentes


        ' 1) Crear ReportesTrimestrales en blanco
        ' 2) Crear ReportesIngresos
        ' 3) Crear ReportesIngresosMensuales
        ' 4) Crear ReportesEgresos
        ' 5) Crear ReportesEgresosCategoras
        ' 6) Modificar ReportesTrimestrales con valores verdaderos

        ActualizarTablasdeReporte()
        Dim trimid As Integer = obtenerID("Trimestres", "nombre", cb_Trimestre.Text)

        ' 1)

        CrearRepTrimestrales(trimid, tb_Año.Text)
        CrearRepCentral(trimid, tb_Año.Text)

        CrearRepSeccional(trimid, tb_Año.Text)
        CrearRepIngresos(trimid, tb_Año.Text)

        'Abrimos los reportes creados


    End Sub

End Class
