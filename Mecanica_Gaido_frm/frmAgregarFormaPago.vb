Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Public Class frmAgregarFormaPago
    Dim o_FormasDePago As New AD_FormasDePago

    ' Propiedad para almacenar el nombre de la nueva forma de pago agregada
    Public Property NuevaFormaPagoVentasNombre As String
    Public Property NuevaFormaPagoComprasNombre As String

#Region "Procedimientos"
    Private Sub frmAgregarFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarTema(Me)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtFormaPago.Text <> Nothing Then
            Try
                If o_FormasDePago.Agregar_FormaPago(txtFormaPago.Text) Then

                    'Almacenar el nombre de la nueva forma de pago
                    NuevaFormaPagoVentasNombre = txtFormaPago.Text
                    NuevaFormaPagoComprasNombre = txtFormaPago.Text

                    MsgBox("Forma de pago agregada correctamente.", vbInformation, "Información")

                    'Al cerrar el modal devuelve un resultado específico en el frmVenta
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("La forma de pago ya existe, puede modificarla en Gestión de Datos.", vbExclamation, "Forma de pago duplicada")
                End If
            Catch ex As Exception
                MsgBox("Error al agregar la forma de pago: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
        End If
    End Sub
#End Region

#Region "Keypress"
    Private Sub txtFormaPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFormaPago.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
      AndAlso Not Char.IsControl(e.KeyChar) _
      AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
#End Region

End Class