Public Class ReporteEgresoCen

    Public trimestre As String
    Public año As Integer
    Dim columnas As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))

#Region "Botones"

    Private Sub GuardarComoExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoExcelToolStripMenuItem.Click

        Dim Book = guardarIngreso()
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Excel File (*xlsx) | *.xlsx"
        sfd.DefaultExt = "xlsx"
        sfd.AddExtension = True

        If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If sfd.FileName <> "" Then
                Book.SaveAs(sfd.FileName())
                Book.close()
                MsgBox("Correctamente Guardado", MsgBoxStyle.Information, "Guardado")
                Exit Sub
            Else : MsgBox("No se Ingreso un nombre para el Archivo", MsgBoxStyle.Exclamation, "Error")
                Book.close()
                Exit Sub
            End If
        Else
            Book.close()
            Exit Sub
        End If

    End Sub

#End Region

#Region "Eventos"

    Private Sub ReporteEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_Año.Text = año
        tb_Trimestre.Text = trimestre
        tb_Seccional.Text = obtenerSeccional()
    End Sub

#End Region

#Region "Helpers"

    Public Sub cargarGrid(ByVal categorias As DataTable)

        Dim idcentral As Integer = obtenerID("Seccionales", "nombre", "UDA Central")
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
            Dim catMensual As Double() = obtenerEgresosCategorias(trimestre, categorias.Rows(i).Item("id"), año, idcentral)
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
    Private Function guardarIngreso()

        Dim Excel As Object
        Dim Book As Object
        Dim Sheet As Object

        'Iniciar un nuevo libro en Excel
        Excel = CreateObject("Excel.Application")
        Book = Excel.Workbooks.Add
        'Agregamos primero hoja del libro
        Sheet = Book.Worksheets(1)
        Sheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4


#Region "Estilos"

        'Alineamiento
        Sheet.Range("A1:G30").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        Sheet.Range("A1:G30").VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

        'Borde
        Sheet.Range("B4:E4").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Sheet.Range("A7:C7").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Sheet.Range("E7:G7").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Sheet.Range("A9:G10").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

        'Tamaño de Letra
        Sheet.Range("A1:G30").font.size = 11
        Sheet.Range("B4").Font.Size = 20
        Sheet.Range("A7").Font.Size = 13
        Sheet.Range("E7").Font.Size = 13
        Sheet.range("A9:G10").Font.Size = 12

        'Tamaño de columna
        Excel.columns("A").ColumnWidth = 13
        Excel.columns("B").ColumnWidth = 13
        Excel.columns("C").ColumnWidth = 14.14
        Excel.columns("D").ColumnWidth = 14.14
        Excel.columns("E").ColumnWidth = 14.14
        Excel.columns("F").ColumnWidth = 7
        Excel.columns("G").ColumnWidth = 7

        'Negrita
        Sheet.Range("B4").Font.Bold = True
        Sheet.Range("A7").Font.Bold = True
        Sheet.Range("E7").Font.Bold = True
        Sheet.Range("A9").Font.Bold = True
        Sheet.Range("F9").Font.Bold = True

#End Region

#Region "Titulos"

        Sheet.Range("B4:E4").MergeCells = True
        Sheet.Range("B4").Value = "Egresos UDA Central"

        Sheet.Range("A7").Value = "Seccional: "
        Sheet.Range("B7:C7").mergecells = True
        Sheet.Range("B7").Value = tb_Seccional.Text

        Sheet.Range("E7").Value = "Trimestre:"
        Sheet.Range("F7:G7").mergecells = True
        Sheet.Range("F7").Value = trimestre & " - " & año

#End Region

#Region "Contenido"

        'Header de columna
        Sheet.Range("A9:B10").mergecells = True
        Sheet.Range("A9").value = "Meses"
        Sheet.Range("C9:C10").mergecells = True
        Sheet.Range("C9").value = dgv.Columns("mes1").HeaderText
        Sheet.Range("D9:D10").mergecells = True
        Sheet.Range("D9").value = dgv.Columns("mes2").HeaderText
        Sheet.Range("E9:E10").mergecells = True
        Sheet.Range("E9").value = dgv.Columns("mes3").HeaderText
        Sheet.Range("F9:G10").mergecells = True
        Sheet.Range("F9").value = "TOTAL"

        'Contenido del DGV
        Dim ultimaFila As Integer = 0
        For i = 0 To dgv.Rows.Count - 2
            'Combinar de celdas
            Sheet.Range(Sheet.Cells(i + 11, 1), Sheet.Cells(i + 11, 2)).mergecells = True
            Sheet.Range(Sheet.Cells(i + 11, 6), Sheet.Cells(i + 11, 7)).mergecells = True
            'Alineamiento
            Sheet.Range(Sheet.Cells(i + 11, 1), Sheet.Cells(i + 11, 2)).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
            'Borde
            Sheet.Range(Sheet.Cells(i + 11, 1), Sheet.Cells(i + 11, 7)).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
            'Formato Moneda
            Sheet.range(Sheet.Cells(i + 11, 3), Sheet.Cells(i + 11, 7)).NumberFormat = "$ #,##0.00"
            'Valores
            Sheet.Cells(i + 11, 1).value = dgv.Rows(i).Cells("meses").Value
            Sheet.Cells(i + 11, 3).value = dgv.Rows(i).Cells("mes1").Value
            Sheet.Cells(i + 11, 4).value = dgv.Rows(i).Cells("mes2").Value
            Sheet.Cells(i + 11, 5).value = dgv.Rows(i).Cells("mes3").Value
            Sheet.Cells(i + 11, 6).value = dgv.Rows(i).Cells("totales").Value

            ultimaFila = i + 12
        Next

        'Row Total 
        Sheet.Range(Sheet.Cells(ultimaFila, 1), Sheet.Cells(ultimaFila, 2)).mergecells = True
        Sheet.Range(Sheet.Cells(ultimaFila, 6), Sheet.Cells(ultimaFila, 7)).mergecells = True
        Sheet.Range(Sheet.Cells(ultimaFila, 1), Sheet.Cells(ultimaFila, 7)).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Sheet.Range(Sheet.Cells(ultimaFila, 3), Sheet.Cells(ultimaFila, 7)).NumberFormat = "$ #,##0.00"
        Sheet.Range(Sheet.Cells(ultimaFila, 1), Sheet.Cells(ultimaFila, 7)).Font.Bold = True
        Sheet.Cells(ultimaFila, 1).Value = "TOTAL"
        Sheet.Cells(ultimaFila, 3).Value = dgv.Rows(dgv.Rows.Count - 1).Cells("mes1").Value
        Sheet.Cells(ultimaFila, 4).Value = dgv.Rows(dgv.Rows.Count - 1).Cells("mes2").Value
        Sheet.Cells(ultimaFila, 5).Value = dgv.Rows(dgv.Rows.Count - 1).Cells("mes3").Value
        Sheet.Cells(ultimaFila, 6).Value = dgv.Rows(dgv.Rows.Count - 1).Cells("totales").Value

#End Region

        Return (Book)

    End Function

#End Region

End Class