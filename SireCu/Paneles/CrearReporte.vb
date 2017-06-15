Public Class CrearReporte

    Private Sub btn_Crear_Click(sender As Object, e As EventArgs) Handles btn_Crear.Click

        'TODO Validaciones de campos

        'TODO Verificaciones de reportes existentes


        ' 1) Crear ReportesTrimestrales en blanco LISTO
        ' 2) Crear ReportesIngresos TODO
        ' 3) Crear ReportesIngresosMensuales TODO 
        ' 4) Crear ReportesEgresos LISTO
        ' 5) Crear ReportesEgresosMensuales TODO
        ' 6) Modificar ReportesTrimestrales con valores verdaderos TODO

        ActualizarTablasdeReporte()
        Dim idTrimestre As Integer = obtenerID("Trimestres", "nombre", cb_Trimestre.Text)
        Dim idCentral As Integer = obtenerID("Seccionales", "nombre", "UDA Central")
        Dim idSeccional As Integer = obtenerID("Seccionales", "nombre", "UDA Central", True)

        ' 1)
        CrearRepTrimestral(idTrimestre, tb_Año.Text, True)

        ' 2)
        'CrearRepIngresos(cb_Trimestre.Text, tb_Año.Text)

        ' 4)
        CrearRepEgreso(cb_Trimestre.Text, tb_Año.Text, idSeccional, idCentral)

        ' 5)
        'CrearRepEgresoMensual(idTrimestre, tb_Año.Text)

        'CrearRepTrimestral(trimid, tb_Año.Text)

    End Sub

End Class
