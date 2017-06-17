Public Class ReporteIngresoGasto

    Public trimestre As String
    Public año As Integer
    Dim columnas As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))

    Private Sub ReporteIngresoGasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_Año.Text = año
        tb_Trimestre.Text = trimestre
        tb_Seccional.Text = obtenerSeccional()
    End Sub

    Public Sub cargarGrid(ByVal saldoInicial As Decimal, ByVal saldoFinal As Decimal, ByVal ingresos As Decimal, ByVal egresos As Decimal)

        Dim trimid As Integer = obtenerID("Trimestres", "nombre", trimestre)

        'Creamos las Columnas
        columnas.Add(New KeyValuePair(Of String, String)("labels", ""))
        columnas.Add(New KeyValuePair(Of String, String)("fechas", ""))
        columnas.Add(New KeyValuePair(Of String, String)("totales", "TOTAL"))
        crearColumna(dgv, columnas)

        Dim dt As New DataTable
        fechaIyF(dt, trimid)
        Dim fechaInicio As String = "01/" & DatePart(DateInterval.Month, dt.Rows(0).Item("fecha_inicio")) & "/" & año
        Dim fechaFinal As String = DatePart(DateInterval.Day, dt.Rows(0).Item("fecha_fin")) & "/" &
            DatePart(DateInterval.Month, dt.Rows(0).Item("fecha_fin")) & "/" & año

        Dim totalGeneral As Double = saldoFinal + saldoInicial

        dgv.Rows.Add("Saldo Inicial a:", fechaInicio, saldoInicial)
        dgv.Rows.Add("Ingresos", "", ingresos)
        dgv.Rows.Add("Egresos", "", egresos)
        dgv.Rows.Add("Saldo Final al", fechaFinal, saldoFinal)
        dgv.Rows.Add("", "Total General", totalGeneral)

    End Sub

    Private Sub fechaIyF(ByRef datatable As DataTable, ByVal trimestre As Integer)

        Dim sql As String = "SELECT  
                                  fecha_inicio,
                                  fecha_fin                            
                           FROM Trimestres
                           WHERE id=" & trimestre

        datatable = consultarReader(sql)

    End Sub

End Class