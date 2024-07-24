Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient

Public Class frmAgregarMarca
    Dim o_marca As New AD_Marca

    ' Propiedad para almacenar el nombre de la nueva marca agregada
    Public Property NuevaMarcaNombre As String
    Public Property NuevaMarcaVehiculoNombre As String

#Region "Cargar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtMarca.Text <> Nothing Then
            Try
                If o_marca.Agregar_Marca(txtMarca.Text, chkProducto.Checked, chkVehiculo.Checked) Then

                    'Almacenar el nombre de la nueva marca
                    NuevaMarcaNombre = txtMarca.Text
                    NuevaMarcaVehiculoNombre = txtMarca.Text
                    MsgBox("Marca agregada correctamente.", vbInformation, "Información")

                    'Al cerrar el modal devuelve un resultado específico en el frmProductos
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("La marca ya existe, puede modificarla en Gestión de Datos.", vbExclamation, "Marca Duplicada")
                End If
            Catch ex As Exception
                MsgBox("Error al agregar la marca: " & ex.Message, vbCritical, "Error")
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