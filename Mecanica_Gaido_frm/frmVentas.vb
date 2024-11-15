Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Imports Comun_Soporte
Imports Mecanica_Gaido_frm.User32

Public Class frmVentas
    Dim o_ventas As New AD_Ventas

    Dim Id_Empleado_Login As Integer = UsuarioActivo.id_empleado

#Region "Enter para pasar de tabulación"

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Enter Then
            ' Verifica si el control activo es un Button
            If TypeOf Me.ActiveControl Is Button Then
                ' Ejecuta el evento Click del botón
                Dim button As Button = DirectCast(Me.ActiveControl, Button)
                button.PerformClick()
                Return True
            Else
                ' Mueve el foco al siguiente control en el orden de tabulación
                Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
                Return True
            End If
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Control_Enter(sender As Object, e As EventArgs)
        If TypeOf sender Is Windows.Controls.TextBox Then
            CType(sender, Windows.Controls.TextBox).SelectAll()
        ElseIf TypeOf sender Is RichTextBox Then
            CType(sender, RichTextBox).SelectAll()
        End If
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Windows.Forms.TextBox OrElse TypeOf ctrl Is RichTextBox Then
                AddHandler ctrl.Enter, AddressOf Control_Enter
            End If
        Next
        limpiar()
        Cargar_Combo_Persona()
        Cargar_Combo_TipoVenta()

        If vengoDeReparaciones Then

            txtMontoManoObra.Text = NavegacionEntreForms.MontoManoObra.ToString("N2")
            txtMontoServ3.Text = NavegacionEntreForms.MontoServ3.ToString("N2")
            Dim id_orden = NavegacionEntreForms.Nro_orden

            ' Llenar la grilla con los repuestos transferidos
            If NavegacionEntreForms.RepuestosVenta IsNot Nothing Then
                For Each row As DataRow In NavegacionEntreForms.RepuestosVenta.Rows
                    grdVentas.Rows.Add(row("ID"),
                                       row("Descripcion"),
                                       row("Diario"),
                                       Convert.ToDecimal(row("Cantidad")),
                                       Convert.ToDecimal(row("Precio")),
                                       Convert.ToDecimal(row("Total")))
                Next
            End If
            ActualizarMontoTotal()
            ' Restablecer la variable de control
            NavegacionEntreForms.vengoDeReparaciones = False
            NavegacionEntreForms.persona = 0
            
            NavegacionEntreForms.TipoVenta = 1
            NavegacionEntreForms.MontoManoObra = 0
            NavegacionEntreForms.MontoServ3 = 0

        End If




        Cargar_Combo_FormaPago()

        Cargar_Combo_FormaEntrega()
        Cargar_Combo_Repuestos()

        PonerDecimales()
        Cargar_Grilla_Ventas()
        AplicarTema(Me)

        txtVendedor.Text = UsuarioActivo.nombre_empleado

        Dim oVenta As New AD_Ventas
        txtNumComprobante.Text = oVenta.ObtenerNroComprobante
        txtNumComprobante.Enabled = False
        btnModificar.Enabled = False
        chkEstado.Checked = True
        chkEstado.Visible = False
    End Sub


    Public Sub limpiar()
        txtID.Clear()
        dtpFechaVenta.Value = Date.Today
        txtNumComprobante.Clear()
        txtMontoManoObra.Text = Convert.ToDecimal(0)
        txtMontoServ3.Text = Convert.ToDecimal(0)
        txtSubtotal.Text = Convert.ToDecimal(0)
        txtIVA.Text = Convert.ToDecimal(21)
        txtIvaMonto.Text = Convert.ToDecimal(0)
        txtOtrosImpuestos.Text = Convert.ToDecimal(0)
        txtTotal.Text = Convert.ToDecimal(0)
        txtMontoDtoRecargo.Text = Convert.ToDecimal(0)
        txtPorcentaje.Text = Convert.ToDecimal(0)
        cboTipoVenta.SelectedIndex = -1
        cboFormaEntrega.SelectedIndex = -1
        cboDetalleFormaPago.SelectedIndex = -1
        cboPersona.SelectedIndex = -1
        cboFormaPago.SelectedIndex = -1
        rbtRecargo.Checked = False
        rbtDescuento.Checked = False
        chkEstado.Checked = True
        chkEstado.Visible = False
        grdVentas.Rows.Clear()
        btnAceptar.Enabled = True
        btnModificar.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        grdVentas.Rows.Clear()
        limpiar()
        txtVendedor.Text = UsuarioActivo.nombre_empleado
        Dim oVenta As New AD_Ventas
        txtNumComprobante.Text = oVenta.ObtenerNroComprobante
        txtNumComprobante.Enabled = False


        NavegacionEntreForms.vengoDeReparaciones = False
        NavegacionEntreForms.persona = 0
        NavegacionEntreForms.Nro_orden = 0
        NavegacionEntreForms.TipoVenta = 0
        NavegacionEntreForms.MontoManoObra = 0
        NavegacionEntreForms.MontoServ3 = 0

    End Sub
#End Region

#Region "Carga de cbo"

    Private ComboRepOK As Boolean = True
    Private Sub Cargar_Combo_Repuestos()
        Try
            Dim tablaRep As DataTable = o_ventas.Cargar_Combo_Repuestos()

            If tablaRep.Rows.Count > 0 Then
                cboProductoVenta.DataSource = tablaRep
                cboProductoVenta.DisplayMember = "Descripcion"
                cboProductoVenta.ValueMember = "ID_Repuestos"
                cboProductoVenta.SelectedValue = -1
            Else
                MsgBox("No se encontraron Repuestos.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Repuestos: " & ex.Message, vbCritical, "Error")
        Finally
            ComboRepOK = False
        End Try
    End Sub

    Private Sub Cargar_Combo_Persona()
        Try
            Dim tabla As DataTable = o_ventas.Cargar_Combo_Persona()

            If tabla.Rows.Count > 0 Then
                cboPersona.DataSource = tabla
                cboPersona.DisplayMember = "Persona"
                cboPersona.ValueMember = "ID_Persona"
                cboPersona.SelectedValue = NavegacionEntreForms.persona
            Else
                MsgBox("No se encontraron Personas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las Personas: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_FormaPago()
        Try
            Dim tabla As DataTable = o_ventas.Cargar_Combo_FormaPago()

            If tabla.Rows.Count > 0 Then
                cboFormaPago.DataSource = tabla
                cboFormaPago.DisplayMember = "Nombre"
                cboFormaPago.ValueMember = "ID_FormaPago"
                cboFormaPago.SelectedValue = 5
            Else
                MsgBox("No se encontraron Fromas de Pago.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las Formas de Pago: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_DetalleFP(ID_FormaPago As String)
        Try
            Dim tabla As DataTable = o_ventas.Cargar_Detalles_Por_FP(ID_FormaPago)

            If tabla.Rows.Count > 0 Then
                cboDetalleFormaPago.DataSource = tabla
                cboDetalleFormaPago.DisplayMember = "Nombre"
                cboDetalleFormaPago.ValueMember = "ID_DetalleFormaPago"
                cboDetalleFormaPago.SelectedValue = 20
            Else
                MsgBox("No se encontraron detalles para la forma de pago seleccionada.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los detalles de forma de pago: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_TipoVenta()
        Try
            Dim tabla As DataTable = o_ventas.Cargar_Combo_TipoVenta()

            If tabla.Rows.Count > 0 Then
                cboTipoVenta.DataSource = tabla
                cboTipoVenta.DisplayMember = "Nombre"
                cboTipoVenta.ValueMember = "ID_TipoVenta"
                cboTipoVenta.SelectedValue = NavegacionEntreForms.TipoVenta
            Else
                MsgBox("No se encontraron Tipos de Ventas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Tipos de Ventas: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_FormaEntrega()
        Try
            Dim tabla As DataTable = o_ventas.Cargar_Combo_FormaEntrega()

            If tabla.Rows.Count > 0 Then
                cboFormaEntrega.DataSource = tabla
                cboFormaEntrega.DisplayMember = "Nombre"
                cboFormaEntrega.ValueMember = "ID_FormaDeEntrega"
                cboFormaEntrega.SelectedValue = 2
            Else
                MsgBox("No se encontraron Formas de Entrega.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las Formas de Entrega: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Cargar grilla y datos en txt"
    Public Sub Cargar_Grilla_DetalleVenta()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_DetalleVenta")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdVentas.AutoGenerateColumns = True
                grdVentas.DataSource = oDs.Tables(0)
                grdVentas.Refresh()
            Else
                MsgBox("No hay repuestos asociados a esta venta.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al cargar la grilla: " & ex.Message, vbCritical, "Error")
        Finally
        End Try
    End Sub

    Private Sub Cargar_Grilla_Ventas()
        Dim o_Ventas As New AD_Ventas
        Try
            Dim oDs As DataTable = o_Ventas.Cargar_Grilla_Ventas

            If oDs.Rows.Count > 0 Then
                grdVentas1.AutoGenerateColumns = True
                grdVentas1.DataSource = oDs
                'grdVentas1.Columns("Vendedor").Visible = False
                grdVentas1.Columns("Detalle FP").Visible = False
                grdVentas1.Columns("Subtotal").Visible = False
                grdVentas1.Columns("MontoDtoRecargo").Visible = False
                grdVentas1.Columns("IVA").Visible = False
                grdVentas1.Columns("IVAMonto").Visible = False
                grdVentas1.Columns("OtrosImpuestos").Visible = False
                grdVentas1.Columns("Tipo De Venta").Visible = False
                grdVentas1.Columns("Forma de Entrega").Visible = False
                grdVentas1.Columns("Estado").Visible = False
                grdVentas1.Refresh()
            Else
                MsgBox("No se encontraron Ventas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las Ventas: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Agregar / Quitar Productos"
    Private Sub btnAgregarCompra_Click(sender As Object, e As EventArgs) Handles btnAgregarVenta.Click
        Try
            If cboProductoVenta.SelectedValue <> Nothing AndAlso Not String.IsNullOrEmpty(txtCantidadVentas.Text) Then

                Dim rowView As DataRowView = CType(cboProductoVenta.SelectedItem, DataRowView)
                Dim idRepuesto As Integer = Convert.ToInt32(rowView("ID_Repuestos"))
                Dim descripcionRepuesto As String = rowView("Descripcion").ToString()
                Dim nombreDiario As String = rowView("nombreDiario").ToString()
                Dim precio As Decimal = Convert.ToDecimal(rowView("PrecioLista"))
                precio = InputBox("Confirme el Precio", "Precio Sugerido", Convert.ToDecimal(precio).ToString("N2"))
                Dim cantidad As Integer = Convert.ToDecimal(txtCantidadVentas.Text)
                Dim total As Decimal = precio * cantidad

                grdVentas.Rows.Add(idRepuesto, descripcionRepuesto, nombreDiario, cantidad, precio, total)
                Cargar_Combo_Repuestos()
                txtCantidadVentas.Text = Convert.ToDecimal(0).ToString("N2")
                ActualizarMontoTotal()
                lblDispo.Visible = False
            Else
                MsgBox("Por favor, seleccione un repuesto y especifique la cantidad.", vbExclamation, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Error al agregar el repuesto: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnQuitarVenta_Click(sender As Object, e As EventArgs) Handles btnQuitarVenta.Click
        Try
            If grdVentas.SelectedRows.Count > 0 Then
                grdVentas.Rows.Remove(grdVentas.SelectedRows(0))

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
        txtMontoServ3.Text = Convert.ToDecimal(txtMontoServ3.Text).ToString("N2")
        txtMontoManoObra.Text = Convert.ToDecimal(txtMontoManoObra.Text).ToString("N2")
        txtOtrosImpuestos.Text = Convert.ToDecimal(txtOtrosImpuestos.Text).ToString("N2")
        txtSubtotal.Text = Convert.ToDecimal(txtSubtotal.Text).ToString("N2")
        txtTotal.Text = Convert.ToDecimal(txtTotal.Text).ToString("N2")
        txtPorcentaje.Text = Convert.ToDecimal(txtPorcentaje.Text).ToString("N2")
        txtMontoDtoRecargo.Text = Convert.ToDecimal(txtMontoDtoRecargo.Text).ToString("N2")
    End Sub

    Private Sub CalcularTotalCompra()
        ActualizarMontoTotal()
        txtTotal.Text = Convert.ToDecimal(CDec(txtOtrosImpuestos.Text) + CDec(txtSubtotal.Text) + CDec(txtIvaMonto.Text) + CDec(txtMontoDtoRecargo.Text)).ToString("N2")
    End Sub

    Private Sub rbtRecargo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtRecargo.CheckedChanged
        ActualizarMontoTotal()
        PonerDecimales()
        Calculo_DtoRecargo()
        CalcularTotalCompra()
    End Sub

    Private Sub rbtDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDescuento.CheckedChanged
        ActualizarMontoTotal()
        PonerDecimales()
        Calculo_DtoRecargo()
        CalcularTotalCompra()
    End Sub

    Private Sub txtSubtotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubtotal.TextChanged
        PonerDecimales()
        CalcularTotalCompra()
    End Sub

    Private Sub txtOtrosImpuestos_Leave(sender As Object, e As EventArgs) Handles txtOtrosImpuestos.Leave
        ActualizarMontoTotal()
        PonerDecimales()
        CalcularTotalCompra()
    End Sub

    Private Sub txtIvaMonto_TextChanged(sender As Object, e As EventArgs) Handles txtIvaMonto.TextChanged
        ActualizarMontoTotal()
        PonerDecimales()
        CalcularTotalCompra()
    End Sub

    Private Sub txtPorcentaje_Leave(sender As Object, e As EventArgs) Handles txtPorcentaje.Leave
        ActualizarMontoTotal()
        PonerDecimales()
        CalcularTotalCompra()
    End Sub

    Private Sub txtMontoDtoRecargo_Leave(sender As Object, e As EventArgs) Handles txtMontoDtoRecargo.Leave
        ActualizarMontoTotal()
        PonerDecimales()
        CalcularTotalCompra()
    End Sub

    Public Sub Calculo_DtoRecargo()

        Dim montoTotal As Decimal = 0
        Dim porcentajeMonto As Decimal = 0
        Dim porcentaje = txtPorcentaje.Text

        For Each row As DataGridViewRow In grdVentas.Rows
            montoTotal += Convert.ToDecimal(row.Cells("Total").Value)
        Next

        If rbtRecargo.Checked Then
            lblMontoDtoRecargo.Text = "Recargo"

            porcentajeMonto = ((montoTotal * porcentaje) / 100)
            txtMontoDtoRecargo.Text = porcentajeMonto.ToString("N2")
        ElseIf rbtDescuento.Checked Then
            lblMontoDtoRecargo.Text = "Descuento"

            porcentajeMonto = ((montoTotal * porcentaje * -1) / 100)
            txtMontoDtoRecargo.Text = porcentajeMonto.ToString("N2")
        Else
            lblMontoDtoRecargo.Text = "Forma de Pago"
        End If
    End Sub

    Public Sub ActualizarMontoTotal()
        Dim montoTotal As Decimal = 0
        Dim IvaMonto As Decimal = 0
        Dim iva = txtIVA.Text

        montoTotal = montoTotal + Convert.ToDecimal(txtMontoManoObra.Text) + Convert.ToDecimal(txtMontoServ3.Text)


        ' Recorre todas las filas de la grilla y suma los valores de la columna Total
        For Each row As DataGridViewRow In grdVentas.Rows
            montoTotal += Convert.ToDecimal(row.Cells("Total").Value)
        Next

        txtSubtotal.Text = montoTotal.ToString("N2")


        IvaMonto = ((montoTotal * iva) / 100)

        txtIvaMonto.Text = IvaMonto.ToString("N2")
    End Sub
#End Region

#Region "Forma de Entrega"
    Private Sub btnFormaEntrega_Click(sender As Object, e As EventArgs) Handles btnFormaEntrega.Click
        Dim frm As New frmAgregarFormaEntrega()

        'Comprueba que si se cerró el modal, se cargue el combo con los nuevos datos
        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_FormaEntrega()

            ' Buscar y seleccionar la nueva forma de entrega en el ComboBox
            Dim nuevaFormaEntrega As String = frm.NuevaFormaEntregaNombre
            For Each item As DataRowView In cboFormaEntrega.Items
                If item("Nombre").ToString() = nuevaFormaEntrega Then
                    cboFormaEntrega.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub
#End Region

#Region "Forma de Pago"
    Private Sub btnAgregarFormaPago_Click(sender As Object, e As EventArgs) Handles btnAgregarFormaPago.Click
        Dim frm As New frmAgregarFormaPago()

        'Comprueba que si se cerró el modal, se cargue el combo con los nuevos datos
        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_FormaPago()

            ' Buscar y seleccionar la nueva forma de pago en el ComboBox
            Dim NuevaFormaPagoVentasNombre As String = frm.NuevaFormaPagoVentasNombre
            For Each item As DataRowView In cboFormaPago.Items
                If item("Nombre").ToString() = NuevaFormaPagoVentasNombre Then
                    cboFormaPago.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub cboFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFormaPago.SelectedIndexChanged
        Try
            If cboFormaPago.SelectedValue IsNot Nothing AndAlso IsNumeric(cboFormaPago.SelectedValue) Then
                Dim idFormaPago As Integer = Convert.ToInt32(cboFormaPago.SelectedValue)
                Cargar_Combo_DetalleFP(idFormaPago)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar detalles de forma de pago: " & ex.Message, vbCritical, "Error")
        End Try

        If cboFormaPago.SelectedIndex <> -1 Then
            cboDetalleFormaPago.Enabled = True
            btnAgregarDetalleFormaPago.Enabled = True

            rbtRecargo.Checked = False
            rbtDescuento.Checked = False
            txtPorcentaje.Text = Convert.ToDecimal(0)
        Else
            cboDetalleFormaPago.Enabled = False
            btnAgregarDetalleFormaPago.Enabled = False

            rbtRecargo.Checked = False
            rbtDescuento.Checked = False
            txtPorcentaje.Text = Convert.ToDecimal(0)
        End If
    End Sub
#End Region

#Region "Detalle Forma Pago"
    Private Sub btnAgregarDetalleFormaPago_Click(sender As Object, e As EventArgs) Handles btnAgregarDetalleFormaPago.Click
        If cboFormaPago.SelectedValue <> Nothing Then
            Dim frm As New frmAgregarDetalleFormaPago()

            frm.FormaPagoSeleccionada = Convert.ToInt32(cboFormaPago.SelectedValue)

            If frm.ShowDialog() = DialogResult.OK Then
                Dim idFormaPago As Integer = Convert.ToInt32(cboFormaPago.SelectedValue)
                Cargar_Combo_DetalleFP(idFormaPago)

                Dim nuevoDetalleNombre As String = frm.NuevoDetalleFPNombre
                For Each item As DataRowView In cboDetalleFormaPago.Items
                    If item("Nombre").ToString() = nuevoDetalleNombre Then
                        cboDetalleFormaPago.SelectedItem = item
                        Exit For
                    End If
                Next
            End If
        Else
            MsgBox("Seleccione una forma de pago para modificar los detalles.", vbInformation, "Información")
        End If
    End Sub

    Private Sub cboDetalleFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDetalleFormaPago.SelectedIndexChanged
        If cboDetalleFormaPago.SelectedIndex <> -1 Then
            Dim drv As DataRowView = CType(cboDetalleFormaPago.SelectedItem, DataRowView)

            Dim idDetalleFP As Integer = Convert.ToInt32(drv("ID_DetalleFormaPago"))

            CargarDatosDettallesFP(idDetalleFP)
        End If
    End Sub

    Public Sub CargarDatosDettallesFP(ByVal idDetalleFP As Integer)
        Try
            Dim datoleido As SqlDataReader = o_ventas.Consultar_DetalleFPPorID(idDetalleFP)

            If datoleido.Read() Then
                rbtRecargo.Checked = datoleido("Recargo").ToString()
                rbtDescuento.Checked = datoleido("Descuento").ToString()
                txtPorcentaje.Text = datoleido("Porcentaje").ToString()

            Else
                MsgBox("No se encontraron resultados", vbInformation, "Error")
            End If

            datoleido.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al consultar el detalle de forma de pago " & ex.Message, "Error")
        End Try
    End Sub
#End Region

#Region "Tipo de Venta"
    Private Sub btnTipoVenta_Click(sender As Object, e As EventArgs) Handles btnTipoVenta.Click
        Dim frm As New frmAgregarTipoVenta()

        'Comprueba que si se cerró el modal, se cargue el combo con los nuevos datos
        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_TipoVenta()

            ' Buscar y seleccionar el nuevo tipo de venta en el ComboBox
            Dim nuevoTipoVenta As String = frm.NuevoTipoVentaNombre
            For Each item As DataRowView In cboTipoVenta.Items
                If item("Nombre").ToString() = nuevoTipoVenta Then
                    cboTipoVenta.SelectedItem = item
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

            Dim NuevaPersonaNombre As String = frm.NuevaPersonaNombre
            For Each item As DataRowView In cboPersona.Items
                If item("Nombre").ToString() = NuevaPersonaNombre Then
                    cboPersona.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub cboPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPersona.SelectedIndexChanged
        If cboPersona.SelectedIndex <> -1 Then
            Dim drv As DataRowView = CType(cboPersona.SelectedItem, DataRowView)

            Dim idPersona As Integer = Convert.ToInt32(drv("ID_Persona"))

            CargarDatosPersona(idPersona)
        Else
            txtResultadoTelefono.Clear()
            txtResultadoDocumento.Clear()
        End If
    End Sub

    Public Sub CargarDatosPersona(ByVal idPersona As Integer)
        Try
            Dim datoleido As SqlDataReader = o_ventas.Consultar_PersonaPorID(idPersona)

            If datoleido.Read() Then
                txtResultadoTelefono.Text = datoleido("Teléfono Móvil").ToString()
                txtResultadoDocumento.Text = datoleido("Documento").ToString()

            Else
                MsgBox("No se encontraron resultados", vbInformation, "Error")
            End If

            datoleido.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al consultar la persona " & ex.Message, "Error")
        End Try
    End Sub
#End Region

#Region "Mascaras"
    Private Sub txtResultadoTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtResultadoTelefono.TextChanged
        Dim mskTxtTelefono As New MaskedTextBox
        mskTxtTelefono.Mask = "C000-0000-0000"
    End Sub
#End Region

#Region "KeyPress"
    Private Sub txtSubtotal_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtIVA_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtOtrosImpuestos_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub PanelPanelCliente_Paint(sender As Object, e As PaintEventArgs) Handles PanelCliente.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelCliente.Width - 1, PanelCliente.Height - 1)
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

    Private Sub PanelPanelFormaPago_Paint(sender As Object, e As PaintEventArgs) Handles PanelFormaPago.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelFormaPago.Width - 1, PanelFormaPago.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelDetalleDeVentas_Paint(sender As Object, e As PaintEventArgs) Handles PanelDetalleDeVentas.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelDetalleDeVentas.Width - 1, PanelDetalleDeVentas.Height - 1)
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




#End Region

#Region "Botones Principales"
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim ventaDataAccess As New AD_Ventas()

            ' Crear un DataTable para los detalles de la venta
            Dim detalles As New DataTable()
            detalles.Columns.Add("ID_Repuesto", GetType(Integer))
            detalles.Columns.Add("ID_Lote", GetType(Integer))
            detalles.Columns.Add("Cantidad", GetType(Decimal))
            detalles.Columns.Add("Descripcion", GetType(String))
            detalles.Columns.Add("PrecioVenta", GetType(Decimal))
            detalles.Columns.Add("Estado", GetType(Boolean))

            For Each row As DataGridViewRow In grdVentas.Rows
                detalles.Rows.Add(row.Cells("ID").Value,
                                    1, 'por no trabajar con lote
                                    row.Cells("Cantidad").Value,
                                    row.Cells("Descripcion").Value,
                                    row.Cells("Precio").Value,
                                    1)
            Next
            Dim ID_Venta As Integer = 0

            If cboTipoVenta.SelectedValue <> 2 Then
                ' Llamar al método para agregar la venta con detalle
                Dim resultado As Boolean = ventaDataAccess.AgregarVentaConDetalle(Convert.ToDateTime(dtpFechaVenta.Value),
                                                    txtNumComprobante.Text,
                                                    CInt(cboPersona.SelectedValue),
                                                    Id_Empleado_Login,
                                                    CInt(cboFormaPago.SelectedValue),
                                                    CInt(cboDetalleFormaPago.SelectedValue),
                                                    Decimal.Parse(txtMontoManoObra.Text),
                                                    Decimal.Parse(txtMontoServ3.Text),
                                                 Decimal.Parse(txtSubtotal.Text),
                                                 Decimal.Parse(txtMontoDtoRecargo.Text),
                                                 Decimal.Parse(txtIVA.Text),
                                                 Decimal.Parse(txtIvaMonto.Text),
                                                 Decimal.Parse(txtOtrosImpuestos.Text),
                                                 Decimal.Parse(txtTotal.Text),
                                                 CInt(cboTipoVenta.SelectedValue),
                                                 CInt(cboFormaEntrega.SelectedValue),
                                                 1,
                                                 detalles, ID_Venta)
            Else
                Dim resultado As Boolean = ventaDataAccess.AgregarVentaConDetalleOR(Nro_orden,
                                                                                    Convert.ToDateTime(dtpFechaVenta.Value),
                                                                                    txtNumComprobante.Text,
                                                                                    CInt(cboPersona.SelectedValue),
                                                                                    Id_Empleado_Login,
                                                                                    CInt(cboFormaPago.SelectedValue),
                                                                                    CInt(cboDetalleFormaPago.SelectedValue),
                                                                                    Decimal.Parse(txtMontoManoObra.Text),
                                                                                    Decimal.Parse(txtMontoServ3.Text),
                                                                                     Decimal.Parse(txtSubtotal.Text),
                                                                                     Decimal.Parse(txtMontoDtoRecargo.Text),
                                                                                     Decimal.Parse(txtIVA.Text),
                                                                                     Decimal.Parse(txtIvaMonto.Text),
                                                                                     Decimal.Parse(txtOtrosImpuestos.Text),
                                                                                     Decimal.Parse(txtTotal.Text),
                                                                                     CInt(cboTipoVenta.SelectedValue),
                                                                                     CInt(cboFormaEntrega.SelectedValue),
                                                                                     1,
                                                                                     detalles,
                                                                                     ID_Venta)
            End If


            MostrarReporteVenta(ID_Venta)

            'NavegacionEntreForms

            vengoDeReparaciones = False
            persona = 0
            vehiculo = 0
            combopersonacargado = False
            Nro_orden = 0
            TipoVenta = 1
            MontoServ3 = 0
            MontoManoObra = 0


            MessageBox.Show("Venta registrada con éxito.")
            btnCancelar.PerformClick()

        Catch ex As Exception
            MessageBox.Show("Error al registrar la venta: " & ex.Message)
        End Try
    End Sub

    Private Sub MostrarReporteVenta(ByVal ID_Venta As Integer)
        Dim frmReporte As New FrmVentaView()

        ' Pasar el parámetro ID_Venta al formulario del reporte
        frmReporte.ID_Venta = ID_Venta

        ' Mostrar el formulario a pantalla completa
        frmReporte.WindowState = FormWindowState.Maximized
        frmReporte.ShowDialog()
    End Sub

    Private Sub CargarDatosVenta(ID_Venta As Integer)

        Dim oDS As New DataSet
        Dim o_Venta As New AD_Ventas



        oDS = o_Venta.Consultar_Venta_ID(ID_Venta)

        If oDS.Tables(0).Rows.Count > 0 Then

            Dim rowVenta As DataRow = oDS.Tables(0).Rows(0)

            txtID.Text = CInt(rowVenta("ID_Venta"))
            dtpFechaVenta.Value = Convert.ToDateTime(rowVenta("FechaVenta"))
            txtNumComprobante.Text = rowVenta("NroComprobante").ToString()
            cboPersona.SelectedValue = CInt(rowVenta("ID_Persona"))
            txtVendedor.Text = rowVenta("Vendedor").ToString()
            cboFormaPago.SelectedValue = CInt(rowVenta("ID_FormaPago"))
            cboDetalleFormaPago.SelectedValue = CInt(rowVenta("ID_DetalleFormaPago"))
            txtMontoManoObra.Text = CDec(rowVenta("Mano de Obra"))
            txtMontoServ3.Text = CDec(rowVenta("Serv Terceros"))
            txtSubtotal.Text = Convert.ToDecimal(rowVenta("Subtotal")).ToString("N2")
            txtMontoDtoRecargo.Text = Convert.ToDecimal(rowVenta("MontoDtoRecargo")).ToString("N2")
            txtIVA.Text = Convert.ToDecimal(rowVenta("IVA")).ToString("N2")
            txtOtrosImpuestos.Text = Convert.ToDecimal(rowVenta("OtrosImpuestos")).ToString("N2")
            txtTotal.Text = Convert.ToDecimal(rowVenta("Total")).ToString("N2")
            cboFormaPago.SelectedValue = rowVenta("ID_FormaPago")
            txtIvaMonto.Text = Convert.ToDecimal(rowVenta("IVAMonto")).ToString("N2")
            txtMontoDtoRecargo.Text = Convert.ToDecimal(rowVenta("MontoDtoRecargo")).ToString("N2")
            chkEstado.Checked = Convert.ToBoolean(rowVenta("Estado"))
            cboTipoVenta.SelectedValue = CInt(rowVenta("ID_TipoVenta"))
            cboFormaEntrega.SelectedValue = CInt(rowVenta("ID_FormaEntrega"))

            ' Verificar si la tabla de detalles (segundo DataTable) tiene filas
            If oDS.Tables(1).Rows.Count > 0 Then
                ' Limpiar el DataGridView de detalles antes de cargar los nuevos datos
                grdVentas.Rows.Clear()

                ' Recorrer los detalles de la venta y agregar cada uno a la grilla
                For Each rowDetalle As DataRow In oDS.Tables(1).Rows
                    grdVentas.Rows.Add(rowDetalle("ID_Repuesto"),
                                       rowDetalle("Descripcion"),
                                       rowDetalle("NombreDiario"),
                                       rowDetalle("Cantidad"),
                                       rowDetalle("PrecioVenta"),
                                       rowDetalle("Total"))
                Next
            Else
                ' Si no hay detalles de venta, puedes mostrar un mensaje o manejarlo de otra forma
                MessageBox.Show("No se encontraron detalles para esta venta.")
            End If
        Else
            ' Si no se encontró la venta, mostrar un mensaje de error
            MessageBox.Show("No se encuentran datos para esta venta")
        End If
        ActualizarMontoTotal()
        oDS.Clear()
    End Sub

    Private Sub grdVentas1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdVentas1.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < grdVentas1.Rows.Count Then
            Dim selectedRow As DataGridViewRow = grdVentas1.Rows(e.RowIndex)
            Dim ID_Venta As Integer = Convert.ToInt32(selectedRow.Cells("N° Venta").Value)

            CargarDatosVenta(ID_Venta)
            btnModificar.Enabled = True
            chkEstado.Visible = True
            lblBusqueda.Visible = False
            txtBusqueda.Text = ""
            txtBusqueda.Visible = False
            btnAceptar.Enabled = False

        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim ventaDataAccess As New AD_Ventas()

            ' Crear un DataTable para los detalles de la venta
            Dim detalles As New DataTable()
            detalles.Columns.Add("ID_Repuesto", GetType(Integer))
            detalles.Columns.Add("ID_Lote", GetType(Integer))
            detalles.Columns.Add("Cantidad", GetType(Decimal))
            detalles.Columns.Add("Descripcion", GetType(String))
            detalles.Columns.Add("PrecioVenta", GetType(Decimal))
            detalles.Columns.Add("Estado", GetType(Boolean))

            ' Llenar el DataTable con los detalles de la venta (ejemplo)
            ' Aquí deberías agregar la lógica para obtener los detalles de los controles de tu formulario
            ' Por ejemplo:
            For Each row As DataGridViewRow In grdVentas.Rows
                detalles.Rows.Add(row.Cells("ID").Value,
                                    1, 'por no trabajar con lote
                                    row.Cells("Cantidad").Value,
                                    row.Cells("Descripcion").Value,
                                    row.Cells("Precio").Value,
                                    1)
            Next

            ' Llamar al método para agregar la venta con detalle
            ventaDataAccess.ModificarVentaConDetalle(txtID.Text,
                                                    Convert.ToDateTime(dtpFechaVenta.Value),
                                                    txtNumComprobante.Text,
                                                    CInt(cboPersona.SelectedValue),
                                                    Id_Empleado_Login,
                                                    CInt(cboFormaPago.SelectedValue),
                                                    CInt(cboDetalleFormaPago.SelectedValue),
                                                    Decimal.Parse(txtMontoManoObra.Text),
                                                    Decimal.Parse(txtMontoServ3.Text),
                                                 Decimal.Parse(txtSubtotal.Text),
                                                 Decimal.Parse(txtMontoDtoRecargo.Text),
                                                 Decimal.Parse(txtIVA.Text),
                                                 Decimal.Parse(txtIvaMonto.Text),
                                                 Decimal.Parse(txtOtrosImpuestos.Text),
                                                 Decimal.Parse(txtTotal.Text),
                                                 CInt(cboTipoVenta.SelectedValue),
                                                 CInt(cboFormaEntrega.SelectedValue),
                                                 1,
                                                 detalles)


            MostrarReporteVenta(txtID.Text)
            Cargar_Grilla_Ventas()

            MessageBox.Show("Venta modificada con éxito.")

            btnCancelar.PerformClick()

        Catch ex As Exception
            MessageBox.Show("Error al modificar la venta: " & ex.Message)
        End Try
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
            Dim oDs As DataSet = o_ventas.Filtrar_Grilla_Ventas(cadena)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdVentas1.AutoGenerateColumns = True
                grdVentas1.DataSource = oDs.Tables(0)
                grdVentas1.Refresh()
            Else
                MsgBox("No se encontraron Ventas con ese criterio de búsqueda.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las Ventas: " & ex.Message, vbCritical, "Error")
        End Try



    End Sub

    Private Sub cboProductoVenta_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboProductoVenta.SelectedValueChanged
        If ComboRepOK Then Return

        If cboProductoVenta.SelectedValue IsNot Nothing AndAlso CInt(cboProductoVenta.SelectedValue) > 0 Then
            lblDispo.Text = ""
            lblDispo.Visible = True

            Dim o_rep As New AD_Productos

            ' Almacena la tupla en una variable
            Dim resultado = o_rep.Consultar_StocksPorID(CInt(cboProductoVenta.SelectedValue))

            ' Extrae los valores de la tupla por nombre
            Dim stockDisponible As Decimal = resultado.stockDisponible
            Dim stockMinimo As Decimal = resultado.stockMinimo
            Dim stockReal As Decimal = resultado.stockReal

            ' Actualiza el texto del label
            lblDispo.Text = stockDisponible.ToString("F2")

            ' Aplicar formato condicional según el valor de stockDisponible
            lblDispo.Font = New Font(lblDispo.Font, FontStyle.Bold)
            lblDispo.Font = New Font(lblDispo.Font.FontFamily, 10)

            ' Cambiar el color según las condiciones
            If stockDisponible >= stockMinimo Then
                lblDispo.ForeColor = Color.Green
            ElseIf stockDisponible > 0 AndAlso stockDisponible < stockMinimo Then
                lblDispo.ForeColor = Color.Yellow
            ElseIf stockDisponible <= 0 Then
                lblDispo.ForeColor = Color.Red
            End If

            ' También puedes actualizar otros controles como txtCantidadVentas
            txtCantidadVentas.Text = stockDisponible.ToString("F2")
        End If
    End Sub
#End Region

End Class