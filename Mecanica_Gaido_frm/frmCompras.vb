Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmCompras
    Dim o_Compras As New AD_Compras

#Region "Procedimientos"
    Public Sub limpiar()
        txtID.Clear()
        dtpFechaCompra.Value = Date.Today
        txtNumComprobante.Clear()
        txtSubtotal.Text = Convert.ToDecimal(0)
        txtIVA.Text = Convert.ToDecimal(21)
        txtIvaMonto.Text = Convert.ToDecimal(0)
        txtOtrosImpuestos.Text = Convert.ToDecimal(0)
        txtTotal.Text = Convert.ToDecimal(0)
        cboPersona.SelectedIndex = -1
        cboFormaPago.SelectedIndex = -1
        chkEstado.Checked = False
    End Sub

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Persona()
        Cargar_Combo_FormaPago()
        Cargar_Combo_Repuestos()
        limpiar()
        PonerDecimales()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
#End Region

#Region "Cargar grilla y datos en txt"
    Public Sub Cargar_Grilla_DetalleCompra()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_DetalleCompra")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdRepuestos.AutoGenerateColumns = True
                grdRepuestos.DataSource = oDs.Tables(0)
                grdRepuestos.Refresh()
            Else
                MsgBox("No hay repuestos asociados a esta compra.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al cargar la grilla: " & ex.Message, vbCritical, "Error")
        Finally
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

    Private Sub Cargar_Combo_FormaPago()
        Try
            Dim tabla As DataTable = o_Compras.Cargar_Combo_FormaPago()

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

#Region "Cargar Productos"
    Private Sub btnAgregarCompra_Click(sender As Object, e As EventArgs) Handles btnAgregarCompra.Click
        Try
            ' Verifica que se haya seleccionado un repuesto y que la cantidad no esté vacía
            If cboProductoCompra.SelectedValue <> Nothing AndAlso Not String.IsNullOrEmpty(txtCantidadCompra.Text) Then

                ' Obtiene los valores necesarios desde el DataRowView del combo box
                Dim rowView As DataRowView = CType(cboProductoCompra.SelectedItem, DataRowView)
                Dim idRepuesto As Integer = Convert.ToInt32(rowView("ID_Repuestos"))
                Dim descripcionRepuesto As String = rowView("Descripcion").ToString()
                Dim nombreDiario As String = rowView("nombreDiario").ToString()
                Dim precio As Decimal = Convert.ToDecimal(rowView("PrecioCompra"))
                Dim cantidad As Integer = Convert.ToDecimal(txtCantidadCompra.Text)
                Dim total As Decimal = precio * cantidad

                ' Agrega una nueva fila a la grilla
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
            ' Verifica si hay una fila seleccionada
            If grdRepuestos.SelectedRows.Count > 0 Then
                ' Elimina la fila seleccionada
                grdRepuestos.Rows.Remove(grdRepuestos.SelectedRows(0))

                ' Actualiza el monto total de los repuestos
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

        ' Muestra el monto total en el TextBox
        txtSubtotal.Text = montoTotal.ToString("F2")

        IvaMonto = ((montoTotal * iva) / 100)

        txtIvaMonto.Text = IvaMonto.ToString("N2")
    End Sub

#End Region

#Region "Forma de Pago"
    Private Sub btnAgregarFormaPago_Click(sender As Object, e As EventArgs) Handles btnAgregarFormaPago.Click
        Dim frm As New frmAgregarFormaPago()

        'Comprueba que si se cerró el modal, se cargue el combo con los nuevos datos
        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_FormaPago()

            ' Buscar y seleccionar la nueva forma de pago en el ComboBox
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

#Region "Keypress"
    Private Sub txtNumComprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumComprobante.KeyPress
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

    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        frmAgregarDatosFiscales.ShowDialog()
    End Sub

End Class