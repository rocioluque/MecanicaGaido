Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmVentas

    Dim o_ventas As New AD_Ventas
    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarPersona.Click
        frmAgregarDatosFiscales.ShowDialog()
    End Sub

#Region "Procedimientos"
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Cuenta()
        Cargar_Combo_Empleados()
        Cargar_Combo_FormaPago()
        Cargar_Combo_TipoVenta()
        Cargar_Combo_FormaEntrega()
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
        cboPersona.SelectedIndex = -1
        cboEmpleado.SelectedIndex = -1
        cboFormaPago.SelectedIndex = -1
        chkEstado.Checked = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
#End Region

#Region "Carga de cbo"
    Private Sub Cargar_Combo_Cuenta()
        Try
            Dim tabla As DataTable = o_ventas.Cargar_Combo_Cuentas()

            If tabla.Rows.Count > 0 Then
                cboPersona.DataSource = tabla
                cboPersona.DisplayMember = "Cuenta"
                cboPersona.ValueMember = "ID_DatoFiscal"
                cboPersona.SelectedValue = -1
            Else
                MsgBox("No se encontraron Cuentas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las Cuentas: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_Empleados()
        Try
            Dim tabla As DataTable = o_ventas.Cargar_Combo_Empleados()

            If tabla.Rows.Count > 0 Then
                cboEmpleado.DataSource = tabla
                cboEmpleado.DisplayMember = "Nombre/RazonSocial"
                cboEmpleado.ValueMember = "ID_Persona"
                cboEmpleado.SelectedValue = -1
            Else
                MsgBox("No se encontraron Empleados.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Empleados: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

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