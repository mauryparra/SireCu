Public Class ReporteEgresoSec

    Public trimestre As String
    Public año As Integer
    Dim columnas As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))

    Private Sub ReporteEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_Año.Text = año
        tb_Trimestre.Text = trimestre
        tb_Seccional.Text = obtenerSeccional()
    End Sub

    Public Sub cargarGrid(ByVal categorias As DataTable)

        Dim idseccional As Integer = obtenerID("Seccionales", "nombre", "UDA Central", True)
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
        For i = 0 To categorias.Rows.Count - 1
            Dim catMensual As Double() = obtenerEgresosCategorias(trimestre, categorias.Rows(i).Item("id"), año, idseccional)
            dgv.Rows.Add(
                         categorias.Rows(i).Item("nombre"),
                         catMensual(0),
                         catMensual(1),
                         catMensual(2),
                         catMensual(0) + catMensual(1) + catMensual(2)
                         )
            totalmes1 = catMensual(0) + totalmes1
            totalmes2 = catMensual(1) + totalmes2
            totalmes3 = catMensual(2) + totalmes3
        Next
        'Ultima fila (TOTALES)
        dgv.Rows.Add(
                         "TOTAL",
                         totalmes1,
                         totalmes2,
                         totalmes3,
                         totalmes1 + totalmes2 + totalmes3
                         )

    End Sub

End Class