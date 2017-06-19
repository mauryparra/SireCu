Public Class ReporteIngreso

    Public trimestre As String
    Public año As Integer
    Dim columnas As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))

    Private Sub ReporteIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_Año.Text = año
        tb_Trimestre.Text = trimestre
        tb_Seccional.Text = obtenerSeccional()
    End Sub

    Public Sub cargarGrid(ByVal ingresos As DataTable, ByVal coparticipacion As Double())

        'Creamos las Columnas
        columnas.Add(New KeyValuePair(Of String, String)("meses", "Mes de:"))
        columnas.Add(New KeyValuePair(Of String, String)("IC", "Ingresos Central"))
        columnas.Add(New KeyValuePair(Of String, String)("IP", "Ingresos Provinciales"))
        columnas.Add(New KeyValuePair(Of String, String)("IO", "Otros Ingresos"))
        columnas.Add(New KeyValuePair(Of String, String)("totales", "TOTAL"))
        crearColumna(dgv, columnas)

        Dim meses As String()
        Select Case trimestre
            Case "Primero"
                meses = {"Enero", "Febrero", "Marzo"}
            Case "Segundo"
                meses = {"Abril", "MAyo", "Junio"}
            Case "Tercero"
                meses = {"Julio", "Agosto", "Septiembre"}
            Case "Cuarto"
                meses = {"Octubre", "Noviembre", "Diciembre"}
        End Select

        'Mes 1
        dgv.Rows.Add(meses(0), ingresos.Rows(0).Item("ingresos_central"), ingresos.Rows(0).Item("ingresos_prov"), ingresos.Rows(0).Item("ingresos_otros"),
            (ingresos.Rows(0).Item("ingresos_central") + ingresos.Rows(0).Item("ingresos_prov") + ingresos.Rows(0).Item("ingresos_otros")))
        'Mes 2
        dgv.Rows.Add(meses(1), ingresos.Rows(1).Item("ingresos_central"), ingresos.Rows(1).Item("ingresos_prov"), ingresos.Rows(1).Item("ingresos_otros"),
            (ingresos.Rows(1).Item("ingresos_central") + ingresos.Rows(1).Item("ingresos_prov") + ingresos.Rows(1).Item("ingresos_otros")))
        'Mes 3
        dgv.Rows.Add(meses(2), ingresos.Rows(2).Item("ingresos_central"), ingresos.Rows(2).Item("ingresos_prov"), ingresos.Rows(2).Item("ingresos_otros"),
            (ingresos.Rows(2).Item("ingresos_central") + ingresos.Rows(2).Item("ingresos_prov") + ingresos.Rows(2).Item("ingresos_otros")))
        'Totales Mensuales

        'Total Provincial
        dgv.Rows.Add("", "Total Provincial:", ingresos.Rows(0).Item("ingresos_prov") +
                     ingresos.Rows(1).Item("ingresos_prov") + ingresos.Rows(2).Item("ingresos_prov"), "", "")
        'Coparticipacion
        dgv.Rows.Add("", "Coparticipacion:", (coparticipacion(0) + coparticipacion(1) + coparticipacion(2)), "", "")
        'Total General
        dgv.Rows.Add("", "", "", "Total General:", obtenerIngresos(trimestre, año, "full"))

    End Sub

End Class