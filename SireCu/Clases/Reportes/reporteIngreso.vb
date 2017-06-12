Public Class ReporteIngreso

    Public trimestre As String
    Public año As Integer
    Dim columnas As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))

    Private Sub ReporteIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_Año.Text = año
        tb_Trimestre.Text = trimestre
        tb_Seccional.Text = obtenerSeccional()

        cargarGrid()
    End Sub

    Private Sub cargarGrid()

        Dim meses As String() = {}
        Dim mesesNom As String() = {}
        Select Case trimestre
            Case "Primero"
                meses = {1, 2, 3}
                mesesNom = {"Enero", "Febrero", "Marzo"}
            Case "Segundo"
                meses = {4, 5, 6}
                mesesNom = {"Abril", "Mayo", "Junio"}
            Case "Tercero"
                meses = {7, 8, 9}
                mesesNom = {"Julio", "Agosto", "Septiembre"}
            Case "Cuarto"
                meses = {10, 11, 12}
                mesesNom = {"Octubre", "Noviembre", "Diciembre"}
        End Select

        Dim sql As String
        sql = "SELECT             Rim.id AS id,
                                  Rim.mes as mes,
                                  Rim.ingresos_provincial AS iProvinciales,
                                  Rim.ingresos_otros AS iOtros,
                                  Rim.ingresos_central AS iCentral,
                                  Ring.total_provincial AS totProv,
                                  Ring.coparticipacion AS copart,
                                  Ring.total_general as totalGen                             
                           FROM ReportesIngresosMensual AS Rim
                           LEFT JOIN ReportesIngresos AS Ring ON Rim.reporte_ingreso_id = Ring.id
                           WHERE 
                            DATEPART(Month, Rim.mes)=" & meses(0) & " AND DATEPART(Year, Rim.mes)=" & año &
                            "OR DATEPART(Month, Rim.mes)=" & meses(1) & " AND DATEPART(Year, Rim.mes)=" & año &
                            "OR DATEPART(Month, Rim.mes)=" & meses(2) & " AND DATEPART(Year, Rim.mes)=" & año

        Dim dt As DataTable = consultarReader(sql)

        'Creamos las Columnas
        columnas.Add(New KeyValuePair(Of String, String)("meses", "Mes de:"))
        columnas.Add(New KeyValuePair(Of String, String)("IC", "Ingresos Central"))
        columnas.Add(New KeyValuePair(Of String, String)("IP", "Ingresos Provinciales"))
        columnas.Add(New KeyValuePair(Of String, String)("IO", "Otros Ingresos"))
        columnas.Add(New KeyValuePair(Of String, String)("totales", "TOTAL"))
        crearColumna(dgv, columnas)


        Dim totalGeneral As Double = dt.Rows(0).Item("totalGen") + dt.Rows(1).Item("totalGen") + dt.Rows(2).Item("totalGen")

        'Mes 1
        dgv.Rows.Add(mesesNom(0), dt.Rows(0).Item("iCentral"), dt.Rows(0).Item("iProvinciales"), dt.Rows(0).Item("iOtros"),
            (dt.Rows(0).Item("iCentral") + dt.Rows(0).Item("iProvinciales") + dt.Rows(0).Item("iOtros")))
        'Mes 2
        dgv.Rows.Add(mesesNom(1), dt.Rows(1).Item("iCentral"), dt.Rows(1).Item("iProvinciales"), dt.Rows(1).Item("iOtros"),
            (dt.Rows(1).Item("iCentral") + dt.Rows(1).Item("iProvinciales") + dt.Rows(1).Item("iOtros")))
        'Mes 3
        dgv.Rows.Add(mesesNom(2), dt.Rows(2).Item("iCentral"), dt.Rows(2).Item("iProvinciales"), dt.Rows(2).Item("iOtros"),
            (dt.Rows(2).Item("iCentral") + dt.Rows(2).Item("iProvinciales") + dt.Rows(2).Item("iOtros")))
        'Total Provincial
        dgv.Rows.Add("", "Total Provincial:", dt.Rows(0).Item("iProvinciales") +
                     dt.Rows(1).Item("iProvinciales") + dt.Rows(2).Item("iProvinciales"), "", "")
        'Coparticipacion
        dgv.Rows.Add("", "Coparticipacion:", dt.Rows(2).Item("copart"), "", "")
        'Total General
        dgv.Rows.Add("", "", "", "Total General:", dt.Rows(2).Item("totalGen"))

    End Sub

End Class