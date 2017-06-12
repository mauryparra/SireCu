Public Class ReporteEgresoSec

    Public trimestre As String
    Public año As Integer
    Dim columnas As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))

    Private Sub ReporteEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_Año.Text = año
        tb_Trimestre.Text = trimestre
        tb_Seccional.Text = obtenerSeccional()

        cargarGrid()
    End Sub

    Private Sub cargarGrid()

        Dim meses As String() = {}
        Select Case trimestre
            Case "Primero"
                meses = {"Enero", "Febrero", "Marzo"}
            Case "Segundo"
                meses = {"Abril", "Mayo", "Junio"}
            Case "Tercero"
                meses = {"Julio", "Agosto", "Septiembre"}
            Case "Cuarto"
                meses = {"Octubre", "Noviembre", "Diciembre"}
        End Select

        Dim Sql As String
        'Obtener el ID de ReportesEgresos, cuyo reporte_trimestre_id corresponde al trimestre 
        Sql = "SELECT
                RE.id as id,
                RE.total as total
                From ReportesEgresos As RE
                Left Join ReportesTrimestrales as RT on RE.reporte_trimestre_id = RT.id
                WHERE RT.seccional_id = " & obtenerID("Seccionales", "nombre", "UDA Central", True) &
                " AND RT.trimestre_id = " & obtenerID("Trimestres", "nombre", trimestre) &
                " AND RT.año = " & año
        Dim dt As DataTable = consultarReader(Sql)
        Dim idReporteEgreso As Integer = dt.Rows(0).Item("id")
        Dim totalGeneralEgreso As Double = dt.Rows(0).Item("total")
        dt.Clear()

        'Obtenemos el monto de cada mes que se corresponda con el ReporteEgreso obtenido
        Sql = "SELECT             REC.id AS id,
                                  Cate.nombre as categoria,
                                  REC.total_mes_1 as mes1,
                                  REC.total_mes_2 as mes2,
                                  REC.total_mes_3 as mes3                                                             
                           FROM ReportesEgresosCategorias AS REC
                           LEFT JOIN CategoriasGastos AS Cate ON REC.categoria_gasto_id = Cate.id
                           WHERE REC.reporte_egreso_id = " & idReporteEgreso

        dt = consultarReader(Sql)

        'Creamos las Columnas
        columnas.Add(New KeyValuePair(Of String, String)("meses", "MESES:"))
        columnas.Add(New KeyValuePair(Of String, String)("mes1", meses(0)))
        columnas.Add(New KeyValuePair(Of String, String)("mes2", meses(1)))
        columnas.Add(New KeyValuePair(Of String, String)("mes3", meses(2)))
        columnas.Add(New KeyValuePair(Of String, String)("totales", "TOTAL"))
        crearColumna(dgv, columnas)
        'Creamos las filas
        Dim totalmes1 As Double = 0.0
        Dim totalmes2 As Double = 0.0
        Dim totalmes3 As Double = 0.0
        For i = 0 To dt.Rows.Count - 1
            dgv.Rows.Add(
                         dt.Rows(i).Item("categoria"),
                         dt.Rows(i).Item("mes1"),
                         dt.Rows(i).Item("mes2"),
                         dt.Rows(i).Item("mes3"),
                         dt.Rows(i).Item("mes1") + dt.Rows(i).Item("mes2") + dt.Rows(i).Item("mes3")
                         )
            totalmes1 = dt.Rows(i).Item("mes1") + totalmes1
            totalmes2 = dt.Rows(i).Item("mes2") + totalmes2
            totalmes3 = dt.Rows(i).Item("mes3") + totalmes3
            i = i + 1
        Next
        'Ultima fila (TOTALES)
        dgv.Rows.Add(
                         "TOTAL",
                         totalmes1,
                         totalmes2,
                         totalmes3,
                         totalGeneralEgreso
                         )

    End Sub

End Class