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

#Region "Grilla Stock"
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

#Region "Agregar / Quitar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If grdProductosBajoStock.SelectedRows.Count > 0 AndAlso Not String.IsNullOrEmpty(txtCantidad.Text) Then

                Dim selectedRow As DataGridViewRow = grdProductosBajoStock.SelectedRows(0)

                Dim idRepuesto As Integer = Convert.ToInt32(selectedRow.Cells("id_Repuesto").Value)
                Dim descripcionRepuesto As String = selectedRow.Cells("Descripcion").Value.ToString()
                Dim cantidad As Integer = Convert.ToDecimal(txtCantidad.Text)

                Dim filaNueva As DataGridViewRow = CType(grdRepuestos.Rows(grdRepuestos.Rows.Add()), DataGridViewRow)
                filaNueva.Cells("id_Repuestos").Value = idRepuesto
                filaNueva.Cells("nombre").Value = descripcionRepuesto
                filaNueva.Cells("cantidad").Value = cantidad ' Ajustar al Name de la columna cantidad

                txtCantidad.Text = String.Empty
            Else
                MsgBox("Por favor, seleccione un repuesto de la grilla y especifique la cantidad.", vbExclamation, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Error al agregar el repuesto: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            If grdRepuestos.SelectedRows.Count > 0 Then
                grdRepuestos.Rows.Remove(grdRepuestos.SelectedRows(0))

            Else
                MsgBox("Por favor, seleccione una fila para quitar.", vbExclamation, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Error al quitar el repuesto: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

#End Region

#Region "PDF"
    Public Sub ExportarDatosPDF(ByVal document As Document)
        Dim datatable As New PdfPTable(grdRepuestos.ColumnCount)
        datatable.DefaultCell.Padding = 3
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER

        Dim encabezado As New Paragraph("PEDIDO PARA COMPRA DE REPUESTOS")
        Dim texto As New Phrase("Pedido del día: " + Now.ToString("dd-MM-yyyy") + " al proveedor " + cboPersona.Text)

        For i As Integer = 0 To grdRepuestos.ColumnCount - 1
            datatable.AddCell(grdRepuestos.Columns(i).HeaderText)
        Next

        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To grdRepuestos.RowCount - 1 'Recorre la filas del datagridview
            For j As Integer = 0 To grdRepuestos.ColumnCount - 1 'Recorre las columnas del datagridview
                datatable.AddCell(grdRepuestos(j, i).Value.ToString())

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
            MessageBox.Show("Documento PDF generado con éxito.", "Error")

        Catch ex As Exception
            MessageBox.Show("No se puede generar el documento PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

End Class