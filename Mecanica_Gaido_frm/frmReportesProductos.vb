Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization
Imports AD_Mecanica_Gaido
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frmReportesProductos
    Dim o_reportes As New AD_Reportes()

#Region "Procedimientos"
    Private Sub frmReportesProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Marcas()
        Cargar_Combo_Repuestos()
        CargarGrilla()
        AplicarTema(Me)
        dtpFechaMax.Value = DateTime.Now
        dtpFechaMin.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cboMarca.SelectedIndex = -1
        CargarGrilla()
    End Sub
#End Region

#Region "Grilla"
    Private Sub CargarGrilla(Optional marcaID As Integer? = Nothing)
        Dim dsRepuestos As DataSet = o_reportes.ObtenerRepuestos(marcaID)

        If marcaID.HasValue Then
            dsRepuestos = o_reportes.ObtenerRepuestos(marcaID.Value)
        Else
            dsRepuestos = o_reportes.ObtenerRepuestos()
        End If

        Dim dtRepuestos As DataTable = dsRepuestos.Tables(0)

        grdRepuestos.Rows.Clear()

        For Each row As DataRow In dtRepuestos.Rows
            Dim fila As DataGridViewRow = CType(grdRepuestos.Rows(grdRepuestos.Rows.Add()), DataGridViewRow)
            fila.Cells("CodFabricante").Value = row("N° Repuesto")
            fila.Cells("Descripcion").Value = row("Descripcion")
            fila.Cells("StockReal").Value = row("Cantidad")
            fila.Cells("PrecioLista").Value = row("Precio Unitario")
            fila.Cells("Total").Value = row("Total")
        Next

        Dim dtSumaTotal As DataTable = dsRepuestos.Tables(1)
        If dtSumaTotal.Rows.Count > 0 Then
            If Not IsDBNull(dtSumaTotal.Rows(0)("SumaTotal")) Then
                Dim sumaTotal As Decimal = Convert.ToDecimal(dtSumaTotal.Rows(0)("SumaTotal"))
                txtTotal.Text = sumaTotal.ToString("N2")
            Else
                txtTotal.Text = "0.00"
            End If
        End If
    End Sub
#End Region

#Region "Carga cbo"
    Private Sub Cargar_Combo_Marcas()
        Try
            Dim tabla As DataTable = o_reportes.Cargar_Combo_Marcas

            If tabla.Rows.Count > 0 Then
                cboMarca.DataSource = tabla
                cboMarca.DisplayMember = "Nombre"
                cboMarca.ValueMember = "ID_Marca"
                cboMarca.SelectedIndex = -1
            Else
                MsgBox("No se encontraron marcas.", vbInformation, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar las marcas: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub cboMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMarca.SelectedIndexChanged
        If cboMarca.SelectedValue IsNot Nothing AndAlso IsNumeric(cboMarca.SelectedValue) Then
            Dim marcaID As Integer = CInt(cboMarca.SelectedValue)
            CargarGrilla(marcaID)
        Else
            CargarGrilla()
        End If
    End Sub

    Private Sub Cargar_Combo_Repuestos()
        Try
            Dim tabla As DataTable = o_reportes.Cargar_Combo_Repuestos

            If tabla.Rows.Count > 0 Then
                cboProducto.DataSource = tabla
                cboProducto.DisplayMember = "Descripcion"
                cboProducto.ValueMember = "ID_Repuestos"
                cboProducto.SelectedIndex = -1
            Else
                MsgBox("No se encontraron productos.", vbInformation, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los productos: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Crear PDF Listado Capítal Rep"
    Public Function GetColumnasSize(dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        ' Iniciar el documento PDF
        document.Open()

        ' ENCABEZADO
        Dim encabezado As New PdfPTable(8)
        encabezado.WidthPercentage = 100

        ' Fila 1 a 4 Columnas 1 a 4
        Dim logoPath As String = System.IO.Path.Combine("Imagenes", "mecanicaGaidoLogo-SinFondo.png")
        If File.Exists(logoPath) Then
            Dim logo As Image = Image.GetInstance(logoPath)
            logo.ScaleToFit(140, 120)

            Dim logoCell As New PdfPCell(logo)
            logoCell.Colspan = 4
            logoCell.Rowspan = 4
            logoCell.HorizontalAlignment = Element.ALIGN_CENTER
            logoCell.VerticalAlignment = Element.ALIGN_MIDDLE
            logoCell.Border = PdfPCell.NO_BORDER
            logoCell.BorderWidthTop = 1
            logoCell.BorderWidthLeft = 1
            logoCell.BorderColor = BaseColor.BLACK

            encabezado.AddCell(logoCell)
        Else
            MessageBox.Show("La imagen no se encontró en la ruta especificada.")
        End If

        ' Fila 1 Columnas 5 a 8
        Dim NumOrdenCell As New PdfPCell(New Paragraph("LISTADO DE REPUESTOS HASTA EL DÍA: " + Now.Date.ToString("d"), FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)))
        NumOrdenCell.Colspan = 4
        NumOrdenCell.Border = PdfPCell.NO_BORDER
        NumOrdenCell.BorderWidthTop = 1
        NumOrdenCell.BorderWidthRight = 1
        NumOrdenCell.BorderColor = BaseColor.BLACK
        NumOrdenCell.HorizontalAlignment = Element.ALIGN_LEFT
        encabezado.AddCell(NumOrdenCell)

        ' Fila 2 Columnas 5 a 8 VACIAS
        For col As Integer = 5 To 8
            Dim emptyCell As New PdfPCell(New Phrase(" "))

            If col = 8 Then
                emptyCell.Border = PdfPCell.NO_BORDER
                emptyCell.BorderWidthRight = 1
                emptyCell.BorderColor = BaseColor.BLACK
            Else
                emptyCell.Border = PdfPCell.NO_BORDER
            End If
            encabezado.AddCell(emptyCell)
        Next

        ' Fila 3 Columnas 5 a 8
        Dim direccionCell As New PdfPCell(New Paragraph("Corrientes 136 - (5940) LAS VARILLAS (Cba.)", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
        direccionCell.Colspan = 4
        direccionCell.Border = PdfPCell.NO_BORDER
        direccionCell.BorderWidthRight = 1
        direccionCell.HorizontalAlignment = Element.ALIGN_CENTER
        direccionCell.VerticalAlignment = Element.ALIGN_TOP
        encabezado.AddCell(direccionCell)

        ' Fila 4 Columnas 4-5-6
        Dim telefonoCell As New PdfPCell(New Paragraph("Tel. 03533 420505 / 03533 15419566", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
        telefonoCell.Colspan = 4
        telefonoCell.Border = PdfPCell.NO_BORDER
        telefonoCell.BorderWidthRight = 1
        telefonoCell.HorizontalAlignment = Element.ALIGN_CENTER
        telefonoCell.VerticalAlignment = Element.ALIGN_TOP
        encabezado.AddCell(telefonoCell)

        ' Fila 5 Columnas 1-2-3
        Dim Dueñocell As New PdfPCell(New Phrase("de Roberto C. Gaido", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)))
        Dueñocell.Colspan = 4
        Dueñocell.Border = PdfPCell.NO_BORDER
        Dueñocell.BorderWidthLeft = 1
        Dueñocell.BorderWidthBottom = 1
        Dueñocell.BorderColor = BaseColor.BLACK
        Dueñocell.HorizontalAlignment = Element.ALIGN_CENTER
        Dueñocell.VerticalAlignment = Element.ALIGN_TOP
        encabezado.AddCell(Dueñocell)

        ' Fila 5 Columnas 4-5-6
        Dim emailCell As New PdfPCell(New Paragraph("rgaido@lasvarinet.com.ar", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
        emailCell.Colspan = 4
        emailCell.Border = PdfPCell.NO_BORDER
        emailCell.BorderWidthRight = 1
        emailCell.BorderWidthBottom = 1
        emailCell.HorizontalAlignment = Element.ALIGN_CENTER
        emailCell.VerticalAlignment = Element.ALIGN_TOP
        encabezado.AddCell(emailCell)

        document.Add(encabezado)

        Dim total As String = If(txtTotal.Text Is Nothing, "0.00", txtTotal.Text)
        Dim texto As New Paragraph("Capital: $" + total)
        texto.SpacingAfter = 10
        document.Add(texto)

        ' Crear la tabla de productos
        Dim datatable As New PdfPTable(grdRepuestos.ColumnCount)
        datatable.DefaultCell.Padding = 3

        ' Anchos de columna
        Dim headerWidths As Single() = GetColumnasSize(grdRepuestos)
        datatable.SetWidths(headerWidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        ' Añadir encabezados de las columnas
        For i As Integer = 0 To grdRepuestos.ColumnCount - 1
            datatable.AddCell(grdRepuestos.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        ' Añadir filas de datos
        For i As Integer = 0 To grdRepuestos.RowCount - 1
            If grdRepuestos.Rows(i).Visible Then
                For j As Integer = 0 To grdRepuestos.ColumnCount - 1
                    Try
                        Dim cellValue As Object = grdRepuestos(j, i).Value

                        ' Formatear "PrecioLista" y "Total" con dos decimales
                        If grdRepuestos.Columns(j).Name = "PrecioLista" Or grdRepuestos.Columns(j).Name = "Total" Then
                            If IsNumeric(cellValue) Then
                                datatable.AddCell(Format(CDec(cellValue), "N2"))
                            Else
                                datatable.AddCell("-")
                            End If
                        Else
                            ' Manejar valores nulos o vacíos
                            If IsDBNull(cellValue) OrElse cellValue Is Nothing Then
                                datatable.AddCell("-")
                            Else
                                datatable.AddCell(cellValue.ToString())
                            End If
                        End If
                    Catch ex As Exception
                        datatable.AddCell("-")
                    End Try
                Next
                datatable.CompleteRow()
            End If
        Next

        ' Agregar la tabla al documento
        document.Add(datatable)

        ' Cerrar el documento
        document.Close()
    End Sub
#End Region

#Region "Mandar PDF"
    Private Sub btnDescargarPDF_Click(sender As Object, e As EventArgs) Handles btnDescargarPDF.Click
        Try
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            Dim fechaActual As String = DateTime.Now.ToString("MMyyyy")

            Dim nombreMarca As String = String.Empty
            If cboMarca.SelectedIndex <> -1 Then
                nombreMarca = cboMarca.Text
            End If

            Dim filename As String
            If String.IsNullOrEmpty(nombreMarca) Then
                filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), $"ListadoRepuestos_{fechaActual}.pdf")
            Else
                filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), $"ListadoRepuestos_{nombreMarca}_{fechaActual}.pdf")
            End If

            Using file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
                PdfWriter.GetInstance(doc, file)
                doc.Open()
                ExportarDatosPDF(doc)
                doc.Close()
            End Using
            Process.Start(filename)

        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


#End Region

#Region "Crear PDF Reporte Productos"
    Public Sub PDFReporteProductos(ByVal document As Document)
        ' Iniciar el documento PDF
        document.Open()

        '************
        ' ENCABEZADO
        '************
        Dim encabezado As New PdfPTable(8)
        encabezado.WidthPercentage = 100

        ' Filas 1 a 4, Columnas 1 a 4 - Logo
        Dim logoPath As String = System.IO.Path.Combine("Imagenes", "mecanicaGaidoLogo-SinFondo.png")
        If File.Exists(logoPath) Then
            Dim logo As Image = Image.GetInstance(logoPath)
            logo.ScaleToFit(140, 120)

            Dim logoCell As New PdfPCell(logo)
            logoCell.Colspan = 4
            logoCell.Rowspan = 4
            logoCell.HorizontalAlignment = Element.ALIGN_CENTER
            logoCell.VerticalAlignment = Element.ALIGN_MIDDLE
            logoCell.Border = PdfPCell.NO_BORDER

            encabezado.AddCell(logoCell)
        Else
            MessageBox.Show("La imagen no se encontró en la ruta especificada.")
        End If

        ' Fila 1, Columnas 5 a 8 - Vacia
        Dim NumOrdenCell As New PdfPCell(New Paragraph("  ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)))
        NumOrdenCell.Colspan = 4
        NumOrdenCell.Border = PdfPCell.NO_BORDER
        NumOrdenCell.HorizontalAlignment = Element.ALIGN_LEFT
        encabezado.AddCell(NumOrdenCell)

        ' Fila 2, Columnas 5 a 8 - Dirección
        Dim direccionCell As New PdfPCell(New Paragraph("Corrientes 136 - (5940) LAS VARILLAS (Cba.)", FontFactory.GetFont(FontFactory.HELVETICA, 10)))
        direccionCell.Colspan = 4
        direccionCell.Border = PdfPCell.NO_BORDER
        direccionCell.HorizontalAlignment = Element.ALIGN_CENTER
        direccionCell.VerticalAlignment = Element.ALIGN_TOP
        encabezado.AddCell(direccionCell)

        ' Fila 3, Columnas 5 a 8 - Teléfono
        Dim telefonoCell As New PdfPCell(New Paragraph("Tel. 03533 420505 / 03533 15419566", FontFactory.GetFont(FontFactory.HELVETICA, 10)))
        telefonoCell.Colspan = 4
        telefonoCell.Border = PdfPCell.NO_BORDER
        telefonoCell.HorizontalAlignment = Element.ALIGN_CENTER
        telefonoCell.VerticalAlignment = Element.ALIGN_TOP
        encabezado.AddCell(telefonoCell)

        ' Fila 4, Columnas 5 a 8 - Email
        Dim emailCell As New PdfPCell(New Paragraph("rgaido@lasvarinet.com.ar", FontFactory.GetFont(FontFactory.HELVETICA, 10)))
        emailCell.Colspan = 4
        emailCell.Border = PdfPCell.NO_BORDER
        emailCell.HorizontalAlignment = Element.ALIGN_CENTER
        emailCell.VerticalAlignment = Element.ALIGN_TOP
        encabezado.AddCell(emailCell)

        ' Fila 5, Columnas 1 a 4 - Dueño
        Dim Dueñocell As New PdfPCell(New Phrase("de Roberto C. Gaido", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)))
        Dueñocell.Colspan = 4
        Dueñocell.Border = PdfPCell.NO_BORDER
        Dueñocell.HorizontalAlignment = Element.ALIGN_CENTER
        Dueñocell.VerticalAlignment = Element.ALIGN_TOP
        encabezado.AddCell(Dueñocell)

        ' Fila 5, Columnas 5 a 8 - Vacia
        For col As Integer = 5 To 8
            Dim emptyCell As New PdfPCell(New Phrase(" "))

            If col = 8 Then
                emptyCell.Border = PdfPCell.NO_BORDER
            Else
                emptyCell.Border = PdfPCell.NO_BORDER
            End If
            encabezado.AddCell(emptyCell)
        Next

        ' Fila 6, Columnas 1 a 8 - Línea de separación 
        Dim separadorCell As New PdfPCell()
        separadorCell.Colspan = 8
        separadorCell.FixedHeight = 1
        separadorCell.Border = PdfPCell.NO_BORDER
        separadorCell.BackgroundColor = New BaseColor(46, 139, 87)
        encabezado.AddCell(separadorCell)

        document.Add(encabezado)

        '*******************
        ' TÍTULO DE REPORTE
        '*******************
        Dim TituloReporte As New PdfPTable(8)
        TituloReporte.WidthPercentage = 100

        ' Fila 1, Columnas 1 a 8 - Vacia
        Dim SeparadorTabla As New PdfPCell(New Paragraph(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
        SeparadorTabla.Colspan = 8
        SeparadorTabla.Border = PdfPCell.NO_BORDER
        TituloReporte.AddCell(SeparadorTabla)

        ' Filas 2-3, Columnas 1 a 8 - Fecha Emisión
        Dim FechaEmisionCell As New PdfPCell(New Paragraph("Fecha de emisión " & DateTime.Now.ToShortDateString, FontFactory.GetFont(FontFactory.HELVETICA, 9)))
        FechaEmisionCell.Colspan = 8
        FechaEmisionCell.Rowspan = 1
        FechaEmisionCell.Border = PdfPCell.NO_BORDER
        FechaEmisionCell.HorizontalAlignment = Element.ALIGN_RIGHT
        FechaEmisionCell.VerticalAlignment = Element.ALIGN_TOP
        TituloReporte.AddCell(FechaEmisionCell)

        ' Filas 4-5, Columnas 1 a 8 - Título
        Dim TituloCell As New PdfPCell(New Phrase("RESUMEN DE MOVIMIENTO DE MERCADERÍA", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)))
        TituloCell.Colspan = 8
        TituloCell.Rowspan = 2
        TituloCell.Border = PdfPCell.NO_BORDER
        TituloCell.HorizontalAlignment = Element.ALIGN_CENTER
        TituloCell.VerticalAlignment = Element.ALIGN_BOTTOM
        TituloCell.PaddingLeft = 10
        TituloReporte.AddCell(TituloCell)

        ' Filas 6-7, Columnas 1 a 8 - Fecha
        Dim FechaMin As Date = dtpFechaMin.Value.Date
        Dim FechaMax As Date = dtpFechaMax.Value.Date

        Dim FechaCell As New PdfPCell(New Paragraph("Del " & FechaMin & " al " & FechaMax, FontFactory.GetFont(FontFactory.HELVETICA, 10)))
        FechaCell.Colspan = 8
        FechaCell.Rowspan = 2
        FechaCell.Border = PdfPCell.NO_BORDER
        FechaCell.HorizontalAlignment = Element.ALIGN_CENTER
        FechaCell.VerticalAlignment = Element.ALIGN_BOTTOM
        TituloReporte.AddCell(FechaCell)

        ' Fila 8, Columnas 1 a 8 - Vacia
        Dim FilaVaciaTabla As New PdfPCell(New Paragraph(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
        FilaVaciaTabla.Colspan = 8
        FilaVaciaTabla.Border = PdfPCell.NO_BORDER
        TituloReporte.AddCell(FilaVaciaTabla)

        ' Filas 9-10, Columnas 1 a 8 - Repuesto
        Dim RepuestoCell As New PdfPCell(New Paragraph("Repuesto: " & cboProducto.Text, FontFactory.GetFont(FontFactory.HELVETICA, 10)))
        RepuestoCell.Colspan = 8
        RepuestoCell.Rowspan = 2
        RepuestoCell.Border = PdfPCell.NO_BORDER
        RepuestoCell.HorizontalAlignment = Element.ALIGN_LEFT
        RepuestoCell.VerticalAlignment = Element.ALIGN_BOTTOM
        TituloReporte.AddCell(RepuestoCell)

        document.Add(TituloReporte)

        '*******************
        ' ENCABEZADO TABLA
        '*******************

        Dim EncabezadoTabla As New PdfPTable(8)
        EncabezadoTabla.WidthPercentage = 100

        ' Fila 1, Columnas 1 a 8 - Vacia
        Dim FilaVaciaEncabezado As New PdfPCell(New Paragraph(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
        FilaVaciaEncabezado.Colspan = 8
        FilaVaciaEncabezado.Border = PdfPCell.NO_BORDER
        EncabezadoTabla.AddCell(FilaVaciaEncabezado)

        document.Close()
    End Sub


#End Region

#Region "Descargar pdf"
    Private Sub btnObtenerResumen_Click(sender As Object, e As EventArgs) Handles btnObtenerResumen.Click
        Try
            Dim folderPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Movimiento de Repuestos")

            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            Dim pdfPath As String = Path.Combine(folderPath, "ReporteProductos.pdf")

            Dim document As New Document()
            PdfWriter.GetInstance(document, New FileStream(pdfPath, FileMode.Create))

            PDFReporteProductos(document)

            MessageBox.Show("El PDF se ha guardado correctamente en: " & pdfPath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

End Class