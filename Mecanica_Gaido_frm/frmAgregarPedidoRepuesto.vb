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

Public Class frmAgregarPedidoRepuesto
    Dim o_pedidos As New AD_Pedidos()

#Region "Procedimientos"
    Private Sub frmAgregarPedidoRepuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Grilla_Productos_BajoStock()
        Cargar_Combo_Persona()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
#End Region

#Region "Cbo"
    Private Sub Cargar_Combo_Persona()
        Try
            Dim tabla As DataTable = o_pedidos.Cargar_Combo_Personas()

            If tabla.Rows.Count > 0 Then
                cboPersona.DataSource = tabla
                cboPersona.DisplayMember = "Persona"
                cboPersona.ValueMember = "ID_Persona"
                cboPersona.SelectedValue = -1
            Else
                MsgBox("No se encontraron Personas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las personas: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Grilla"
    Private Sub Cargar_Grilla_Productos_BajoStock()
        Dim dtProductos As DataTable = o_pedidos.ObtenerProductosBajoStock()

        grdProductosBajoStock.Rows.Clear()

        For Each row As DataRow In dtProductos.Rows
            Dim fila As DataGridViewRow = CType(grdProductosBajoStock.Rows(grdProductosBajoStock.Rows.Add()), DataGridViewRow)
            fila.Cells("id_Repuesto").Value = row("N° Repuesto")
            fila.Cells("Descripcion").Value = row("Descripcion")
            fila.Cells("StockDisponible").Value = row("Stock Disponible")
        Next
    End Sub
#End Region

#Region "PDF"
    Public Sub ExportarDatosPDF(ByVal document As Document)
        Dim datatable As New PdfPTable(grdProductosBajoStock.ColumnCount)
        datatable.DefaultCell.Padding = 3
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER

        Dim encabezado As New Paragraph("PEDIDO PARA COMPRA DE REPUESTOS")
        Dim texto As New Phrase("Pedido del día: " + Now.ToString("dd-MM-yyyy") + " al proveedor " + cboPersona.Text)

        For i As Integer = 0 To grdProductosBajoStock.ColumnCount - 1
            datatable.AddCell(grdProductosBajoStock.Columns(i).HeaderText)
        Next

        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To grdProductosBajoStock.RowCount - 1 'Recorre la filas del datagridview
            For j As Integer = 0 To grdProductosBajoStock.ColumnCount - 1 'Recorre las columnas del datagridview
                datatable.AddCell(grdProductosBajoStock(j, i).Value.ToString())

            Next
            datatable.CompleteRow()
        Next

        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
    End Sub

    Private Sub btnExportarPDF_Click(sender As Object, e As EventArgs) Handles btnExportarPDF.Click
        Try
            Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
            Dim safeDate As String = Now.ToString("dd-MM-yyyy")
            Dim filename As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "Pedidos productos " + safeDate + ".pdf")

            Using file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
                PdfWriter.GetInstance(doc, file)
                doc.Open()
                ExportarDatosPDF(doc)
                doc.Close()
            End Using

            Process.Start(filename)
            MessageBox.Show("Documento PDF generado con exito.")
        Catch ex As Exception
            MessageBox.Show("No se puede generar el documento PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

End Class