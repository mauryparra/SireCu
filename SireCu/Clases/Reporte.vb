Module Reporte

    Public Sub CrearRepSeccional(ByVal trimestre As String, ByVal año As Integer)

    End Sub

    Public Sub CrearRepCentral(ByVal trimestre As String, ByVal año As Integer)

    End Sub

    Public Sub CrearRepIngresos(ByVal trimestre As String, ByVal año As Integer)

        'Obtener Seccional, trimestre y año


        'Obtener Ingresos Provinciales Mensuales
        'Obtener Ingresos UDA Central Mensuales
        'Obtener Ingresos Otros Mensuales

    End Sub

    Public Sub CrearRepTrimestrales(ByVal trimestre As Integer, ByVal año As Integer)

        Dim idSec As Integer = obtenerID("Seccionales", "nombre", "UDA Central", 1)
        Principal.query = "INSERT INTO ReportesTrimestrales
                            (seccional_id, trimestre_id, año, saldo_inicial, ingresos, egresos, saldo_final)
                            VALUES 
                            (" & idSec & ", " & trimestre & ", " & año & ", 0, 0, 0, 0)"

        consultarNQ(Principal.query, Principal.command)

    End Sub

    Public Sub ModifRepTrimestrales(ByVal trimestre As Integer, ByVal año As Integer)

    End Sub

    Public Sub ActualizarTablasdeReporte()
        cargarTablaEnDataSet("ReportesEgresos")
        cargarTablaEnDataSet("ReportesEgresosCategorias")
        cargarTablaEnDataSet("ReportesIngresos")
        cargarTablaEnDataSet("ReportesIngresosMensual")
        cargarTablaEnDataSet("ReportesTrimestrales")
        cargarTablaEnDataSet("Trimestres")
        cargarTablaEnDataSet("Seccionales")
    End Sub

End Module
