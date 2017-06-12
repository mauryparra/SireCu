Public Class ReporteIngresoGasto

    Public trimestre As String
    Public año As Integer
    Dim columnas As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))

    Private Sub ReporteIngresoGasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_Año.Text = año
        tb_Trimestre.Text = trimestre
        tb_Seccional.Text = obtenerSeccional()

        cargarGrid()
    End Sub

    Private Sub cargarGrid()

        Dim trimid As Integer = obtenerID("Trimestres", "nombre", trimestre)
        Dim sql As String

        sql = "SELECT             R.id AS id,
                                  R.año AS Año,
                                  R.saldo_inicial AS saldoInicial,
                                  R.saldo_final AS saldoFinal,
                                  R.ingresos AS ingresos,
                                  R.egresos AS egresos,
                                  R.trimestre_id as trimID,
                                  Trim.fecha_inicio AS fechaInicial,
                                  Trim.fecha_fin AS fechaFinal                            
                           FROM ReportesTrimestrales AS R
                           LEFT JOIN Trimestres AS Trim ON R.trimestre_id = Trim.id
                           WHERE R.trimestre_id=" & trimid & " AND R.año=" & año

        Dim dt As DataTable = consultarReader(sql)


        'Creamos las Columnas
        columnas.Add(New KeyValuePair(Of String, String)("labels", ""))
        columnas.Add(New KeyValuePair(Of String, String)("fechas", ""))
        columnas.Add(New KeyValuePair(Of String, String)("totales", "TOTAL"))
        crearColumna(dgv, columnas)

        Dim fechaInicio As String = "01/" & DatePart(DateInterval.Month, dt.Rows(0).Item("fechaInicial")) & "/" & año
        Dim fechaFinal As String = DatePart(DateInterval.Day, dt.Rows(0).Item("fechaFinal")) & "/" &
            DatePart(DateInterval.Month, dt.Rows(0).Item("fechaFinal")) & "/" & año

        Dim totalGeneral As Double = dt.Rows(0).Item("saldoFinal") + dt.Rows(0).Item("saldoInicial")

        dgv.Rows.Add("Saldo Inicial a:", fechaInicio, dt.Rows(0).Item("saldoInicial"))
        dgv.Rows.Add("Ingresos", "", dt.Rows(0).Item("ingresos"))
        dgv.Rows.Add("Egresos", "", dt.Rows(0).Item("egresos"))
        dgv.Rows.Add("Saldo Final al", fechaFinal, dt.Rows(0).Item("saldoFinal"))
        dgv.Rows.Add("", "Total General", totalGeneral)

    End Sub

End Class