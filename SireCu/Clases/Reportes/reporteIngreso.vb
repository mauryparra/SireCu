Public Class ReporteIngreso

    Public trimestre As String
    Public año As Integer
    Dim columnas As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))


#Region "Botones"

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
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

    Private Sub ReporteIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_Año.Text = año
        tb_Trimestre.Text = trimestre
        tb_Seccional.Text = obtenerSeccional()
    End Sub

#End Region

#Region "Helpers"

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

        If ingresos.Rows.Count = 0 Then
            'Mes 1
            dgv.Rows.Add(meses(0), 0, 0, 0, 0)
            'Mes 2
            dgv.Rows.Add(meses(1), 0, 0, 0, 0)
            'Mes 3
            dgv.Rows.Add(meses(2), 0, 0, 0, 0)
            'Total Provincial
            dgv.Rows.Add("", "Total Provincial:", 0, "", "")
            'Coparticipacion
            dgv.Rows.Add("", "Coparticipacion:", (coparticipacion(0) + coparticipacion(1) + coparticipacion(2)), "", "")
            'Total General
            dgv.Rows.Add("", "", "", "Total General:", 0)
        Else

            'Mes 1
            dgv.Rows.Add(meses(0), ingresos.Rows(0).Item("ingresos_central"), ingresos.Rows(0).Item("ingresos_prov"), ingresos.Rows(0).Item("ingresos_otros"),
            (ingresos.Rows(0).Item("ingresos_central") + ingresos.Rows(0).Item("ingresos_prov") + ingresos.Rows(0).Item("ingresos_otros")))
            'Mes 2
            dgv.Rows.Add(meses(1), ingresos.Rows(1).Item("ingresos_central"), ingresos.Rows(1).Item("ingresos_prov"), ingresos.Rows(1).Item("ingresos_otros"),
                (ingresos.Rows(1).Item("ingresos_central") + ingresos.Rows(1).Item("ingresos_prov") + ingresos.Rows(1).Item("ingresos_otros")))
            'Mes 3
            dgv.Rows.Add(meses(2), ingresos.Rows(2).Item("ingresos_central"), ingresos.Rows(2).Item("ingresos_prov"), ingresos.Rows(2).Item("ingresos_otros"),
                (ingresos.Rows(2).Item("ingresos_central") + ingresos.Rows(2).Item("ingresos_prov") + ingresos.Rows(2).Item("ingresos_otros")))
            'Total Provincial
            dgv.Rows.Add("", "Total Provincial:", ingresos.Rows(0).Item("ingresos_prov") +
                         ingresos.Rows(1).Item("ingresos_prov") + ingresos.Rows(2).Item("ingresos_prov"), "", "")
            'Coparticipacion
            dgv.Rows.Add("", "Coparticipacion:", (coparticipacion(0) + coparticipacion(1) + coparticipacion(2)), "", "")
            'Total General
            dgv.Rows.Add("", "", "", "Total General:", obtenerIngresos(trimestre, año, "full"))
        End If

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
        Sheet.Range("B4:D4").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Sheet.Range("A7:F7").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Sheet.Range("A9:F13").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Sheet.Range("A15:C16").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        Sheet.Range("C18:F18").Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous

        'Tamaño de Letra
        Sheet.Range("A1:G30").font.size = 12
        Sheet.Range("B4").Font.Size = 20
        Sheet.Range("A7").Font.Size = 13
        Sheet.Range("D7").Font.Size = 13
        Sheet.Range("B7").Font.Size = 11
        Sheet.Range("E7").Font.Size = 11

        'Tamaño de columna
        Excel.columns("A").ColumnWidth = 16.43
        Excel.columns("B").ColumnWidth = 15.14
        Excel.columns("C").ColumnWidth = 15.14
        Excel.columns("D").ColumnWidth = 15.14
        Excel.columns("E").ColumnWidth = 10
        Excel.columns("F").ColumnWidth = 10

        'Negrita
        Sheet.Range("B4").Font.Bold = True
        Sheet.Range("A7").Font.Bold = True
        Sheet.Range("D7").Font.Bold = True
        Sheet.Range("A9:F10").Font.Bold = True
        Sheet.Range("A15").Font.Bold = True
        Sheet.Range("A16").Font.Bold = True
        Sheet.Range("C18").Font.Bold = True

        'Formato Moneda
        Sheet.range("A11:F13").NumberFormat = "$ #,##0.00"
        Sheet.range("C15:C16").NumberFormat = "$ #,##0.00"
        Sheet.range("E18").NumberFormat = "$ #,##0.00"

#End Region

#Region "Titulos"

        Sheet.Range("B4:D4").MergeCells = True
        Sheet.Range("B4").Value = "Ingresos"

        Sheet.Range("A7").Value = "Seccional: "
        Sheet.Range("B7:C7").mergecells = True
        Sheet.Range("B7").Value = tb_Seccional.Text

        Sheet.Range("D7").Value = "Trimestre:"
        Sheet.Range("E7:F7").mergecells = True
        Sheet.Range("E7").Value = trimestre & " - " & año

#End Region

#Region "Contenido"

        'Header de columna
        Sheet.Range("A9:A10").mergecells = True
        Sheet.Range("A9").value = "Mes de:"
        Sheet.Range("B9:B10").mergecells = True
        Sheet.Range("B9").value = "Ingresos por" & vbCrLf & "UDA Central"
        Sheet.Range("C9:C10").mergecells = True
        Sheet.Range("C9").value = "Ingresos por" & vbCrLf & "Provinciales"
        Sheet.Range("D9:D10").mergecells = True
        Sheet.Range("D9").value = "Ingresos por" & vbCrLf & "Otros"
        Sheet.Range("E9:F10").mergecells = True
        Sheet.Range("E9").value = "TOTALES"

        'Contenido del DGV
        For i = 0 To dgv.Rows.Count - 4
            Sheet.Range(Sheet.Cells(i + 11, 5), Sheet.Cells(i + 11, 6)).mergecells = True
            Sheet.Cells(i + 11, 1).value = dgv.Rows(i).Cells("meses").Value
            Sheet.Cells(i + 11, 2).value = dgv.Rows(i).Cells("IC").Value
            Sheet.Cells(i + 11, 3).value = dgv.Rows(i).Cells("IP").Value
            Sheet.Cells(i + 11, 4).value = dgv.Rows(i).Cells("IO").Value
            Sheet.Cells(i + 11, 5).value = dgv.Rows(i).Cells("totales").Value
        Next

        'Row Total Provincial
        Sheet.Range("A15:B15").mergecells = True
        Sheet.Range("A15").Value = "Total Ingresos Provinciales"
        Sheet.Range("C15").value = dgv.Rows(3).Cells("IP").Value
        'Row Coparticipacion
        Sheet.Range("A16:B16").mergecells = True
        Sheet.Range("A16").Value = "Coparticipacion"
        Sheet.Range("C16").value = dgv.Rows(4).Cells("IP").Value
        'Row Total General
        Sheet.Range("C18:D18").mergecells = True
        Sheet.Range("E18:F18").mergecells = True
        Sheet.Range("C18").Value = "Total General"
        Sheet.Range("E18").value = dgv.Rows(5).Cells("totales").Value

#End Region

        Return (Book)

    End Function

#End Region

End Class