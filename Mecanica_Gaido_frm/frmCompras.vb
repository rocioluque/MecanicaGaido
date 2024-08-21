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
        txtSubTotal.Clear()
        txtIVA.Clear()
        txtIvaMonto.Clear()
        txtOtrosImpuestos.Clear()
        txtTotal.Clear()
        cboPersona.SelectedIndex = -1
        cboFormaPago.SelectedIndex = -1
        chkEstado.Checked = False
    End Sub

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Cuentas()
        Cargar_Combo_FormaPago()
        limpiar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
#End Region

#Region "Cargar cbo"
    Private Sub Cargar_Combo_Cuentas()
        Try
            Dim tabla As DataTable = o_Compras.Cargar_Combo_Cuentas()

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

    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        frmAgregarDatosFiscales.ShowDialog()
    End Sub

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

End Class