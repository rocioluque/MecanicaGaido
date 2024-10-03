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
        CargarGrilla()
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
#End Region

    Public Function GetColumnasSize(dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        Dim datatable As New PdfPTable(grdRepuestos.ColumnCount)
        datatable.DefaultCell.Padding = 3

        Dim headerwidths As Single() = GetColumnasSize(grdRepuestos)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

        Dim encabezado As New Paragraph("Listado de Repuestos hasta el: " + Now.Date.ToString("d"))
        encabezado.SpacingAfter = 10
        Dim total As String = If(txtTotal.Text Is Nothing, "0.00", txtTotal.Text)
        Dim texto As New Paragraph("Capital: $" + total)
        texto.SpacingAfter = 10

        For i As Integer = 0 To grdRepuestos.ColumnCount - 1
            datatable.AddCell(grdRepuestos.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To grdRepuestos.RowCount - 1
            If grdRepuestos.Rows(i).Visible Then
                For j As Integer = 0 To grdRepuestos.ColumnCount - 1
                    Try
                        Dim cellValue As Object = grdRepuestos(j, i).Value

                        ' Si la columna es "PrecioLista" o "Total", formatea con dos decimales
                        If grdRepuestos.Columns(j).Name = "PrecioLista" Or grdRepuestos.Columns(j).Name = "Total" Then
                            If IsNumeric(cellValue) Then
                                datatable.AddCell(Format(CDec(cellValue), "N2"))
                            Else
                                datatable.AddCell("-")
                            End If
                        Else
                            ' Para las demás columnas, muestra el valor o un guion si está vacío o es nulo
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

        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub

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
End Class