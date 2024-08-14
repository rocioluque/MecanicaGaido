Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Public Class frmAgregarTipoVenta
    Dim o_TiposDeVenta As New AD_TiposDeVenta

    ' Propiedad para almacenar el nombre del nuevo tipo de venta agregado
    Public Property NuevoTipoVentaNombre As String

#Region "Cargar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtTipoVenta.Text <> Nothing Then
            Try
                If o_TiposDeVenta.Agregar_TipoVenta(txtTipoVenta.Text) Then

                    'Almacenar el nombre del nuevo tipo de venta
                    NuevoTipoVentaNombre = txtTipoVenta.Text
                    MsgBox("Tipo de Venta agregado correctamente.", vbInformation, "Información")

                    'Al cerrar el modal devuelve un resultado específico en el frmVenta
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("El Tipo de Venta ya existe, puede modificarlo en Gestión de Datos.", vbExclamation, "Tipo de Venta duplicado")
                End If
            Catch ex As Exception
                MsgBox("Error al agregar el tipo de venta: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
        End If
    End Sub
#End Region

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class