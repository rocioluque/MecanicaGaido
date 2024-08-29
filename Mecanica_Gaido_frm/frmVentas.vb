Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Imports Comun_Soporte
Imports Mecanica_Gaido_frm.User32

Public Class frmVentas
    Dim o_ventas As New AD_Ventas

#Region "Procedimientos"
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Persona()
        'Cargar_Combo_Empleados()
        Cargar_Combo_FormaPago()
        Cargar_Combo_TipoVenta()
        Cargar_Combo_FormaEntrega()

        txtVendedor.Text = UsuarioActivo.nombre_empleado
    End Sub

    Public Sub limpiar()
        txtID.Clear()
        dtpFechaVenta.Value = Today
        txtNumComprobante.Clear()
        txtSubtotal.Clear()
        txtIVA.Clear()
        txtOtrosImpuestos.Clear()
        txtTotal.Clear()
        cboTipoVenta.SelectedIndex = -1
        cboFormaEntrega.SelectedIndex = -1
        cboDetalleFormaPago.SelectedIndex = -1
        cboPersona.SelectedIndex = -1
        'cboEmpleado.SelectedIndex = -1
        cboFormaPago.SelectedIndex = -1
        chkEstado.Checked = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
#End Region

#Region "Carga de cbo"
    Private Sub Cargar_Combo_Persona()
        Try
            Dim tabla As DataTable = o_ventas.Cargar_Combo_Persona()

            If tabla.Rows.Count > 0 Then
                cboPersona.DataSource = tabla
                cboPersona.DisplayMember = "Persona"
                cboPersona.ValueMember = "ID_Persona"
                cboPersona.SelectedValue = -1
            Else
                MsgBox("No se encontraron Personas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las Personas: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Private Sub Cargar_Combo_Empleados()
    '    Try
    '        Dim tabla As DataTable = o_ventas.Cargar_Combo_Empleados()

    '        If tabla.Rows.Count > 0 Then
    '            cboEmpleado.DataSource = tabla
    '            cboEmpleado.DisplayMember = "Nombre/RazonSocial"
    '            cboEmpleado.ValueMember = "ID_Persona"
    '            cboEmpleado.SelectedValue = -1
    '        Else
    '            MsgBox("No se encontraron Empleados.", vbInformation, "Información")
    '        End If

    '    Catch ex As Exception
    '        MsgBox("Error al cargar los Empleados: " & ex.Message, vbCritical, "Error")
    '    End Try
    'End Sub

    Private Sub Cargar_Combo_FormaPago()
        Try
            Dim tabla As DataTable = o_ventas.Cargar_Combo_FormaPago()

            If tabla.Rows.Count > 0 Then
                cboFormaPago.DataSource = tabla
                cboFormaPago.DisplayMember = "Nombre"
                cboFormaPago.ValueMember = "ID_FormaPago"
                cboFormaPago.SelectedValue = -1
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
                cboDetalleFormaPago.SelectedIndex = -1
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
                cboTipoVenta.SelectedValue = -1
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
                cboFormaEntrega.SelectedValue = -1
            Else
                MsgBox("No se encontraron Formas de Entrega.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las Formas de Entrega: " & ex.Message, vbCritical, "Error")
        End Try
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
            txtProcentaje.Clear()
        Else
            cboDetalleFormaPago.Enabled = False
            btnAgregarDetalleFormaPago.Enabled = False

            rbtRecargo.Checked = False
            rbtDescuento.Checked = False
            txtProcentaje.Clear()
        End If
    End Sub

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
                txtProcentaje.Text = datoleido("Porcentaje").ToString()

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
End Class