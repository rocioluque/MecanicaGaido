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

Imports ModernMessageBoxLib
Imports System.Windows.Input
Imports System.Windows

Public Class frmAgregarPedidoRepuesto
    Dim o_pedidos As New AD_Pedidos()

#Region "Procedimientos"
    Private Sub frmAgregarPedidoRepuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Grilla_Productos_BajoStock()
        Cargar_Combo_Persona()
        AplicarTema(Me)
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


    Private Sub grdProductosBajoStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdProductosBajoStock.CellClick
        Dim o_prod As New AD_Productos

        Try
            If e.RowIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = grdProductosBajoStock.Rows(e.RowIndex)
                Dim idProducto As String = selectedRow.Cells("id_Repuesto").Value.ToString()
                Dim st_minimo As Decimal = o_prod.Consultar_StockMinimoPorID(idProducto)
                Dim stockDisponible As Decimal = Convert.ToDecimal(selectedRow.Cells("StockDisponible").Value)
                Dim cantidadSugerida As Decimal = st_minimo - stockDisponible

                txtCantidad.Text = cantidadSugerida.ToString()

            End If
        Catch ex As Exception
            MsgBox("Error al sugerir cantidad del repuesto: " & ex.Message, vbCritical, "Error")
        End Try
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
                grdProductosBajoStock.Rows.Remove(selectedRow)
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
                Dim o_prod As New AD_Productos
                ' Obtener la fila seleccionada de la grilla de repuestos
                Dim selectedRow As DataGridViewRow = grdRepuestos.SelectedRows(0)

                ' Obtener los valores de la fila seleccionada
                Dim idRepuesto As Integer = Convert.ToInt32(selectedRow.Cells("id_Repuestos").Value)
                Dim descripcionRepuesto As String = selectedRow.Cells("nombre").Value.ToString()
                Dim stockDisponible As Decimal = o_prod.Consultar_StockDisponiblePorID(idRepuesto)

                ' Agregar los datos de vuelta a la grilla de productos bajo stock
                Dim filaNueva As DataGridViewRow = CType(grdProductosBajoStock.Rows(grdProductosBajoStock.Rows.Add()), DataGridViewRow)
                filaNueva.Cells("id_Repuesto").Value = idRepuesto
                filaNueva.Cells("Descripcion").Value = descripcionRepuesto
                filaNueva.Cells("StockDisponible").Value = stockDisponible

                ' Eliminar la fila de la grilla de repuestos
                grdRepuestos.Rows.Remove(selectedRow)

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
        Dim NumOrdenCell As New PdfPCell(New Paragraph("PEDIDO PARA COMPRA DE REPUESTOS", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)))
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

        Dim texto As New Phrase("Pedido de presupuesto del día: " + Now.ToString("dd-MM-yyyy") + " al proveedor " + cboPersona.Text)
        document.Add(texto)

        ' TABLA DE REPUESTOS
        Dim datatable As New PdfPTable(grdRepuestos.ColumnCount)
        datatable.DefaultCell.Padding = 3
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER

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

        document.Add(datatable)
    End Sub
#End Region

#Region "Whatsapp"
    Private Sub btnEnviarWhatsapp_Click(sender As Object, e As EventArgs) Handles btnEnviarWhatsapp.Click
        If cboPersona.SelectedValue <> Nothing Then
            If grdRepuestos.Rows.Count > 0 Then
                Try
                    Dim doc As New Document(PageSize.A4, 10, 10, 10, 10)
                    Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), "Pedidos_productos_" & Now.ToString("dd-MM-yyyy") & ".pdf")


                    Using file As New FileStream(tempFilePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
                        PdfWriter.GetInstance(doc, file)
                        doc.Open()
                        ExportarDatosPDF(doc)
                        doc.Close()
                    End Using


                    If File.Exists(tempFilePath) Then
                        EnviarWhatsapp(tempFilePath)

                        MessageBox.Show("Documento PDF generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("El archivo PDF no se ha creado correctamente porque: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("No se puede generar el documento PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Agregue al menos un repuesto antes de enviar el pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
                MsgBox("Seleccione un proveedor para descargar el pedido", vbInformation, "Error")
        End If
    End Sub

    Private Sub EnviarWhatsapp(tempFilePath As String)
        Dim numeroTelefono As String = Consultar_TelefonoPersona(cboPersona.SelectedValue)

        If String.IsNullOrEmpty(numeroTelefono) Then
            MessageBox.Show("No se ha encontrado un número de teléfono para el proveedor seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Crear instancia del uploader y subir el archivo
        Dim uploader As New GoogleDriveUploader()
        Dim enlacePDF As String = uploader.SubirArchivoDrive(tempFilePath)

        ' Ahora puedes usar ese enlace en tu mensaje de WhatsApp
        Dim mensaje As String = "Aquí tienes el pedido de repuestos. Puedes descargar el PDF aquí: " & enlacePDF

        ' Codificar el mensaje para la URL de WhatsApp
        Dim mensajeCodificado As String = Uri.EscapeDataString(mensaje)
        Dim enlaceWhatsApp As String = "https://wa.me/" & numeroTelefono & "?text=" & mensajeCodificado

        ' Abrir WhatsApp Web en el navegador
        Process.Start(enlaceWhatsApp)
    End Sub

    Private Function Consultar_TelefonoPersona(idPersona As Object) As String
        Dim numeroTelefonoMovil As String = String.Empty
        Try
            Dim dt As DataTable = o_pedidos.Consultar_TelefonoPersona(idPersona)
            If dt.Rows.Count > 0 Then
                numeroTelefonoMovil = dt.Rows(0)("Telefono_Movil").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al obtener el número de teléfono del proveedor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return numeroTelefonoMovil
    End Function


#End Region
End Class