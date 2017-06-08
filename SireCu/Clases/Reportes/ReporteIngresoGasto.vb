Public Class ReporteIngresoGasto

    Public trimestre As String
    Public año As Integer

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
                                  Trim.fecha_inicio AS fechaInicial,
                                  Trim.fecha_fin AS fechaFinal                            
                           FROM ReportesTrimestrales AS R
                           LEFT JOIN Trimestres AS Trim ON R.trimestre_id = Trim.id"

        Dim dt As DataTable = consultarReader(sql)

        crearColumna(0, "labels")
        crearColumna(1, "meses")
        crearColumna(2, "totales", "TOTAL")

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

    Private Sub crearColumna(ByVal index As Integer, ByVal nombreColumna As String, Optional ByVal header As String = "")

        If Not dgv.Columns.Contains(nombreColumna) Then
            Dim column As New DataGridViewTextBoxColumn
            With column
                .DisplayIndex = index
                .Name = nombreColumna
                .HeaderText = header
                .DataPropertyName = nombreColumna
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            dgv.Columns.Add(column)
        End If

    End Sub

End Class