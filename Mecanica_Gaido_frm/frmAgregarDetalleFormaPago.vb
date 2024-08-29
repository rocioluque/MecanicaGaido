Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Public Class frmAgregarDetalleFormaPago
    Dim o_FormasDePago As New AD_FormasDePago

    Public Property NuevoDetalleFPNombre As String
    Public Property FormaPagoSeleccionada As Integer

#Region "Procedimientos"
    Private Sub frmAgregarDetalleFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_FormaPago()

        cboFormaPago.SelectedValue = FormaPagoSeleccionada
    End Sub

    Private Sub Cargar_Combo_FormaPago()
        Try
            Dim tabla As DataTable = o_FormasDePago.Cargar_Combo_FormaPago()

            If tabla.Rows.Count > 0 Then
                cboFormaPago.DataSource = tabla
                cboFormaPago.DisplayMember = "Nombre"
                cboFormaPago.ValueMember = "ID_FormaPago"
            Else
                MsgBox("No se encontraron formas de pago.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las formas de pago: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

            If o_FormasDePago.Agregar_DetalleFP(txtDetalleFP.Text, CInt(cboFormaPago.SelectedValue), txtPorcentuaje.Text,
                                                rbtRecargo.Checked, rbtDescuento.Checked) Then

                NuevoDetalleFPNombre = txtDetalleFP.Text

                MsgBox("Detalle de forma de pago agregado correctamente.", vbInformation, "Éxito")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("El detalle ya existe en la forma de pago seleccionada.", vbExclamation, "Detalle Duplicado")
            End If
        Catch ex As Exception
            MsgBox("Error al agregar el detalle: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class