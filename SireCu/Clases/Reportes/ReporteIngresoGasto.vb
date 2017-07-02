Public Class ReporteIngresoGasto

    Public trimestre As String
    Public año As Integer
    Dim columnas As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))


#Region "Botones"

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

        Dim Book = guardarIngresoGasto()
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
        Else : Exit Sub
        End If

    End Sub

#End Region

#Region "Eventos"

    Private Sub ReporteIngresoGasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_Año.Text = año
        tb_Trimestre.Text = trimestre
        tb_Seccional.Text = obtenerSeccional()
    End Sub

#End Region

#Region "Helpers"

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
        dgv.Rows.Add("Saldo Final al:", fechaFinal, saldoFinal)
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
    Private Function guardarIngresoGasto()

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
        Sheet.Range("C4:E4").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Sheet.Range("A7:C7").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Sheet.Range("E7:G7").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Sheet.Range("F9:G9").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Sheet.Range("A10:G13").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Sheet.Range("D15:G15").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

        'Tamaño de Letra
        Sheet.Range("A1:G30").font.size = 12
        Sheet.Range("C4").Font.Size = 20
        Sheet.Range("A7").Font.Size = 13
        Sheet.Range("E7").Font.Size = 13
        Sheet.Range("B7").Font.Size = 11
        Sheet.Range("F7").Font.Size = 11

        'Tamaño de columna
        Excel.columns("C").ColumnWidth = 12.47
        Excel.columns("D").ColumnWidth = 12.47
        Excel.columns("E").ColumnWidth = 12.47

        'Negrita
        Sheet.Range("C4").Font.Bold = True
        Sheet.Range("A7").Font.Bold = True
        Sheet.Range("E7").Font.Bold = True
        Sheet.Range("F9").Font.Bold = True

        'Formato Moneda
        Sheet.range("F10:F13").NumberFormat = "$ #,##0.00"
        Sheet.range("F15").NumberFormat = "$ #,##0.00"

#End Region

#Region "Titulos"

        Sheet.Range("C4:E4").MergeCells = True
        Sheet.Range("C4").Value = "Ingresos - Gastos"

        Sheet.Range("A7").Value = "Seccional: "
        Sheet.Range("B7:C7").mergecells = True
        Sheet.Range("B7").Value = tb_Seccional.Text

        Sheet.Range("E7").Value = "Trimestre:"
        Sheet.Range("F7:G7").mergecells = True
        Sheet.Range("F7").Value = trimestre & " - " & año

#End Region

#Region "Contenido"

        'Header de columna
        Sheet.Range("F9:G9").mergecells = True
        Sheet.Range("F9").value = "TOTALES"

        'Contenido del DGV
        For i = 0 To dgv.Rows.Count - 2
            Sheet.Range(Sheet.Cells(i + 10, 1), Sheet.Cells(i + 10, 2)).mergecells = True
            Sheet.Range(Sheet.Cells(i + 10, 3), Sheet.Cells(i + 10, 5)).mergecells = True
            Sheet.Range(Sheet.Cells(i + 10, 6), Sheet.Cells(i + 10, 7)).mergecells = True
            Sheet.Cells(i + 10, 1).value = dgv.Rows(i).Cells("labels").Value
            Sheet.Cells(i + 10, 3).value = dgv.Rows(i).Cells("fechas").Value
            Sheet.Cells(i + 10, 6).value = dgv.Rows(i).Cells("totales").Value
        Next

        'Row Total General
        Sheet.Range("D15:E15").mergecells = True
        Sheet.Range("F15:G15").mergecells = True
        Sheet.Range("D15").value = "Total General"
        Sheet.Range("F15").value = dgv.Rows(4).Cells("totales").Value

#End Region

        Return (Book)

    End Function

#End Region

End Class