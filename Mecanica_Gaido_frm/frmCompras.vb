Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmCompras
    Dim o_Compras As New AD_Compras
    Private denominacionLote As String

#Region "Procedimientos"
    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Persona()
        Cargar_Combo_FormaPago_Compra()
        Cargar_Combo_Repuestos()
        Cargar_Grilla_Compras()
        limpiar()
        PonerDecimales()
        btnModificar.Enabled = False
        txtBusqueda.Visible = False

        AplicarTema(Me)
    End Sub

    Public Sub limpiar()
        txtID.Clear()
        txtBusqueda.Clear()
        txtNumComprobante.Clear()
        txtSubtotal.Text = Convert.ToDecimal(0)
        txtIVA.Text = Convert.ToDecimal(21)
        txtIvaMonto.Text = Convert.ToDecimal(0)
        txtOtrosImpuestos.Text = Convert.ToDecimal(0)
        txtTotal.Text = Convert.ToDecimal(0)
        dtpFechaCompra.Value = Date.Today
        cboPersona.SelectedIndex = -1
        cboFormaPago.SelectedIndex = -1
        cboProductoCompra.SelectedIndex = -1
        txtBusqueda.Visible = False
        lblBusqueda.Visible = False
        chkEstado.Visible = False
        btnAceptar.Enabled = True
        btnModificar.Enabled = False
        chkEstado.Checked = False

        grdRepuestos.Rows.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
#End Region

#Region "Cargar grilla y datos en txt"
    Private Sub Cargar_Grilla_Compras()
        Try
            Dim oDs As DataSet = o_Compras.Cargar_Grilla_Compras

            If oDs.Tables(0).Rows.Count > 0 Then
                grdCompras.AutoGenerateColumns = True
                grdCompras.DataSource = oDs.Tables(0)
                grdCompras.Columns("Fecha Compra").DefaultCellStyle.Format = "dd/MM/yyyy"
                grdCompras.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                grdCompras.Columns("Total").DefaultCellStyle.Format = "N2"
                grdCompras.Refresh()
            Else
                MsgBox("No se encontraron Compras.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las compras: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub CargarDatosEnTxt(ID_Compra As Integer)
        Dim o_Compras As New AD_Compras
        Try
            Dim datoleido As SqlDataReader = o_Compras.Consultar_Compras_ID(ID_Compra)
            If datoleido.Read() Then
                chkEstado.Visible = True

                txtID.Text = datoleido("ID_Compra").ToString()
                dtpFechaCompra.Value = Convert.ToDateTime(datoleido("FechaCompra"))
                txtNumComprobante.Text = datoleido("NroComprobante").ToString()
                cboPersona.SelectedValue = datoleido("ID_Persona").ToString()
                cboFormaPago.SelectedValue = datoleido("ID_FormaPago").ToString()
                txtSubtotal.Text = Convert.ToDecimal(datoleido("Subtotal")).ToString("N2")
                txtIVA.Text = Convert.ToDecimal(datoleido("IVA")).ToString("N2")
                txtIvaMonto.Text = Convert.ToDecimal(datoleido("IVA_Monto")).ToString("N2")
                txtOtrosImpuestos.Text = Convert.ToDecimal(datoleido("OtrosImpuestos")).ToString("N2")
                txtTotal.Text = Convert.ToDecimal(datoleido("Total")).ToString("N2")
                chkEstado.Checked = Convert.ToBoolean(datoleido("Estado"))
            Else
                MsgBox("No se encontraron resultados", vbInformation, "Error")
            End If

            Dim o_Compras1 As New AD_Compras
            Dim repuestosTable = o_Compras1.Cargar_DetalleCompra(txtID.Text)

            If repuestosTable.Rows.Count > 0 Then
                grdRepuestos.Rows.Clear()
                For Each repuestoRow As DataRow In repuestosTable.Rows
                    Dim totalRep = Convert.ToDecimal(repuestoRow("Cantidad")) * Convert.ToDecimal(repuestoRow("PrecioCompra"))
                    grdRepuestos.Rows.Add(repuestoRow("ID_Repuesto"),
                                          repuestoRow("Nombre"),
                                          repuestoRow("Descripcion"),
                                          repuestoRow("Cantidad"),
                                          repuestoRow("PrecioCompra"),
                                          totalRep)
                Next
            Else
                MsgBox("No hay repuestos cargados")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar las compras: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub grdCompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdCompras.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = grdCompras.Rows(e.RowIndex)
            Dim ID_Compra As Integer
            btnModificar.Enabled = True

            If selectedRow.Cells("Codigo").Value IsNot Nothing Then
                ID_Compra = Convert.ToInt32(selectedRow.Cells("Codigo").Value)
                CargarDatosEnTxt(ID_Compra)

            Else
                MsgBox("El ID de la Compra no puede ser nulo.", vbCritical, "Error")
            End If
        End If

        lblBusqueda.Visible = False
        txtBusqueda.Text = ""
        txtBusqueda.Visible = False
        btnAceptar.Enabled = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        lblBusqueda.Visible = True
        txtBusqueda.Visible = True
        txtBusqueda.Text = ""
        txtBusqueda.Focus()
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Dim cadenas As String = If(String.IsNullOrWhiteSpace(txtBusqueda.Text), "", txtBusqueda.Text)
        FIltrarGrilla(cadenas)
        txtBusqueda.Focus()
        txtBusqueda.Text = cadenas
    End Sub

    Private Sub FIltrarGrilla(cadena As String)
        Try
            Dim oDs As DataSet = o_Compras.Filtrar_Grilla_Compras(cadena)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdCompras.AutoGenerateColumns = True
                grdCompras.DataSource = oDs.Tables(0)
                grdCompras.Columns("Fecha Compra").DefaultCellStyle.Format = "dd/MM/yyyy"
                grdCompras.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                grdCompras.Columns("Total").DefaultCellStyle.Format = "N2"
                grdCompras.Refresh()
            Else
                MsgBox("No se encontraron Compras con ese criterio de búsqueda.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las compras: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Cargar cbo"
    Private Sub Cargar_Combo_Persona()
        Try
            Dim tabla As DataTable = o_Compras.Cargar_Combo_Personas()

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

    Private Sub Cargar_Combo_FormaPago_Compra()
        Try
            Dim tabla As DataTable = o_Compras.Cargar_Combo_FormaPago_Compra()

            If tabla.Rows.Count > 0 Then
                cboFormaPago.DataSource = tabla
                cboFormaPago.DisplayMember = "Nombre"
                cboFormaPago.ValueMember = "ID_FormaPago"
                cboFormaPago.SelectedValue = -1
            Else
                MsgBox("No se encontraron Formas de Pago.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar la Forma de Pago: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_Repuestos()
        Try
            Dim tablaRep As DataTable = o_Compras.Cargar_Combo_Repuestos()

            If tablaRep.Rows.Count > 0 Then
                cboProductoCompra.DataSource = tablaRep
                cboProductoCompra.DisplayMember = "Descripcion"
                cboProductoCompra.ValueMember = "ID_Repuestos"
                cboProductoCompra.SelectedValue = -1
            Else
                MsgBox("No se encontraron Repuestos.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Repuestos: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Agregar / Quitar Productos"
    Private Sub btnAgregarCompra_Click(sender As Object, e As EventArgs) Handles btnAgregarCompra.Click
        Try
            If cboProductoCompra.SelectedValue <> Nothing AndAlso Not String.IsNullOrEmpty(txtCantidadCompra.Text) Then

                Dim rowView As DataRowView = CType(cboProductoCompra.SelectedItem, DataRowView)
                Dim idRepuesto As Integer = Convert.ToInt32(rowView("ID_Repuestos"))
                Dim descripcionRepuesto As String = rowView("Descripcion").ToString()
                Dim nombreDiario As String = rowView("nombreDiario").ToString()
                Dim precio As Decimal = Convert.ToDecimal(rowView("PrecioCompra"))
                precio = InputBox("Confirme el Precio", "Precio Sugerido", Convert.ToDecimal(precio).ToString("N2"))
                Dim cantidad As Integer = Convert.ToDecimal(txtCantidadCompra.Text)
                Dim total As Decimal = precio * cantidad

                grdRepuestos.Rows.Add(idRepuesto, descripcionRepuesto, nombreDiario, cantidad, precio, total)
                Cargar_Combo_Repuestos()
                txtCantidadCompra.Text = Convert.ToDecimal(0).ToString("N2")
                ActualizarMontoTotal()

            Else
                MsgBox("Por favor, seleccione un repuesto y especifique la cantidad.", vbExclamation, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Error al agregar el repuesto: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnQuitarCompra_Click(sender As Object, e As EventArgs) Handles btnQuitarCompra.Click
        Try
            If grdRepuestos.SelectedRows.Count > 0 Then
                grdRepuestos.Rows.Remove(grdRepuestos.SelectedRows(0))

                ActualizarMontoTotal()
            Else
                MsgBox("Por favor, seleccione una fila para quitar.", vbExclamation, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Error al quitar el repuesto: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Formato numero y calculo montos"
    Private Sub PonerDecimales()
        txtIVA.Text = Convert.ToDecimal(txtIVA.Text).ToString("N2")
        txtIvaMonto.Text = Convert.ToDecimal(txtIvaMonto.Text).ToString("N2")
        txtOtrosImpuestos.Text = Convert.ToDecimal(txtOtrosImpuestos.Text).ToString("N2")
        txtSubtotal.Text = Convert.ToDecimal(txtSubtotal.Text).ToString("N2")
        txtTotal.Text = Convert.ToDecimal(txtTotal.Text).ToString("N2")
    End Sub

    Private Sub CalcularTotalCompra()
        txtTotal.Text = Convert.ToDecimal(CDec(txtOtrosImpuestos.Text) + CDec(txtSubtotal.Text) + CDec(txtIvaMonto.Text)).ToString("N2")
    End Sub

    Private Sub txtSubtotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubtotal.TextChanged
        PonerDecimales()
        CalcularTotalCompra()
    End Sub

    Private Sub txtOtrosImpuestos_Leave(sender As Object, e As EventArgs) Handles txtOtrosImpuestos.Leave
        PonerDecimales()
        CalcularTotalCompra()
    End Sub

    Private Sub txtIvaMonto_TextChanged(sender As Object, e As EventArgs) Handles txtIvaMonto.TextChanged
        PonerDecimales()
        CalcularTotalCompra()
    End Sub

    Public Sub ActualizarMontoTotal()
        Dim montoTotal As Decimal = 0
        Dim IvaMonto As Decimal = 0
        Dim iva = txtIVA.Text

        ' Recorre todas las filas de la grilla y suma los valores de la columna Total
        For Each row As DataGridViewRow In grdRepuestos.Rows
            montoTotal += Convert.ToDecimal(row.Cells("Total").Value)
        Next

        txtSubtotal.Text = montoTotal.ToString("F2")

        IvaMonto = ((montoTotal * iva) / 100)

        txtIvaMonto.Text = IvaMonto.ToString("N2")
    End Sub

#End Region

#Region "Concatenar nombre Lote"
    Dim isComprobanteComplete As Boolean = False
    Dim isProveedorSelected As Boolean = False

    Private Sub txtNumComprobante_TextChanged(sender As Object, e As EventArgs) Handles txtNumComprobante.TextChanged
        If txtNumComprobante.Text.Length >= 16 Then
            isComprobanteComplete = True
        Else
            isComprobanteComplete = False
        End If

        If isComprobanteComplete AndAlso isProveedorSelected Then
            ActualizarNombre()
        End If
    End Sub

    Private Sub cboPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPersona.SelectedIndexChanged
        If cboPersona.SelectedIndex <> -1 Then
            isProveedorSelected = True
        Else
            isProveedorSelected = False
        End If

        If isComprobanteComplete AndAlso isProveedorSelected Then
            ActualizarNombre()
        End If
    End Sub

    Private Sub ActualizarNombre()
        Dim fecha As String = dtpFechaCompra.Value.ToString("yyyyMM")

        Dim proveedor As String = cboPersona.Text.Substring(0, 2).ToUpper()

        Dim numeroComprobante As String = txtNumComprobante.Text.Substring(txtNumComprobante.Text.Length - 4)

        denominacionLote = $"{fecha}.{proveedor}.{numeroComprobante}"
    End Sub
#End Region

#Region "Forma de Pago"
    Private Sub btnAgregarFormaPago_Click(sender As Object, e As EventArgs)
        Dim frm As New frmAgregarFormaPago()

        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_FormaPago_Compra()

            Dim nuevaFormaPagoCompras As String = frm.NuevaFormaPagoComprasNombre
            For Each item As DataRowView In cboFormaPago.Items
                If item("Nombre").ToString() = nuevaFormaPagoCompras Then
                    cboFormaPago.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub
#End Region

#Region "Persona"
    Private Sub btnAgregarPersona_Click(sender As Object, e As EventArgs) Handles btnAgregarPersona.Click
        Dim frm As New frmPersonas()

        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_Persona()

            Dim NuevaPersonaNombreCompra As String = frm.NuevaPersonaNombreCompra
            For Each item As DataRowView In cboPersona.Items
                If item("Nombre").ToString() = NuevaPersonaNombreCompra Then
                    cboPersona.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim dtDetalles As New DataTable()
            dtDetalles.Columns.Add("ID_Repuesto", GetType(Integer))
            dtDetalles.Columns.Add("Cantidad", GetType(Integer))
            dtDetalles.Columns.Add("Descripcion", GetType(String))
            dtDetalles.Columns.Add("PrecioCompra", GetType(Decimal))

            For Each row As DataGridViewRow In grdRepuestos.Rows
                If Not row.IsNewRow Then
                    dtDetalles.Rows.Add(row.Cells("ID_Repuesto").Value, row.Cells("Cantidad").Value,
                                        row.Cells("Descripcion").Value, row.Cells("PrecioCompra").Value)
                End If
            Next

            o_Compras.AgregarCompra(dtpFechaCompra.Value, txtNumComprobante.Text, cboPersona.SelectedValue, cboFormaPago.SelectedValue,
                Convert.ToDecimal(txtSubtotal.Text), Convert.ToDecimal(txtIVA.Text), Convert.ToDecimal(txtIvaMonto.Text),
                Convert.ToDecimal(txtOtrosImpuestos.Text), Convert.ToDecimal(txtTotal.Text), chkEstado.Checked,
                dtDetalles, denominacionLote)

            MessageBox.Show("Compra cargada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cargar_Grilla_Compras()
            limpiar()
        Catch ex As Exception
            MessageBox.Show("Error al cargar la compra: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim dtDetalles As New DataTable()
            dtDetalles.Columns.Add("ID_Repuesto", GetType(Integer))
            dtDetalles.Columns.Add("Cantidad", GetType(Integer))
            dtDetalles.Columns.Add("Descripcion", GetType(String))
            dtDetalles.Columns.Add("PrecioCompra", GetType(Decimal))

            For Each row As DataGridViewRow In grdRepuestos.Rows
                If Not row.IsNewRow Then
                    dtDetalles.Rows.Add(row.Cells("ID_Repuesto").Value, row.Cells("Cantidad").Value,
                                    row.Cells("Descripcion").Value, row.Cells("PrecioCompra").Value)
                End If
            Next

            Dim idCompra As Integer = Convert.ToInt32(txtID.Text)

            o_Compras.ModificarCompra(idCompra, dtpFechaCompra.Value, txtNumComprobante.Text, cboPersona.SelectedValue, cboFormaPago.SelectedValue,
            Convert.ToDecimal(txtSubtotal.Text), Convert.ToDecimal(txtIVA.Text), Convert.ToDecimal(txtIvaMonto.Text),
            Convert.ToDecimal(txtOtrosImpuestos.Text), Convert.ToDecimal(txtTotal.Text), chkEstado.Checked,
            dtDetalles, denominacionLote)

            MessageBox.Show("Compra modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cargar_Grilla_Compras()
            limpiar()
            btnAceptar.Enabled = True
            btnModificar.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Error al modificar la compra: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Keypress"
    Private Sub txtNumComprobante_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSubTotal_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtIVA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIVA.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtIvaMonto_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtOtrosImpuestos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtrosImpuestos.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
#End Region

#Region "Css trucho"
    Private Sub PanelInformacionGeneral_Paint(sender As Object, e As PaintEventArgs) Handles PanelInformacionGeneral.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelInformacionGeneral.Width - 1, PanelInformacionGeneral.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelImpuestos_Paint(sender As Object, e As PaintEventArgs) Handles PanelImpuestos.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelImpuestos.Width - 1, PanelImpuestos.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelTotales_Paint(sender As Object, e As PaintEventArgs) Handles PanelTotales.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelTotales.Width - 1, PanelTotales.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelDetalleDeCompras_Paint(sender As Object, e As PaintEventArgs) Handles PanelDetalleDeCompras.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelDetalleDeCompras.Width - 1, PanelDetalleDeCompras.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub


#End Region

End Class