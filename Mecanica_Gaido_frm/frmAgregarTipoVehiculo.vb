Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Public Class frmAgregarTipoVehiculo
    Dim o_vehiculo As New AD_Vehiculos

    ' Propiedad para almacenar el nombre del nuevo tipo de vehiculo agregada
    Public Property NuevoTipoVehiculoNombre As String

#Region "Procedimientos"
    Private Sub frmAgregarTipoVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarTema(Me)
    End Sub

    Public Sub limpiar()
        txtTipoVehiculo.Clear()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtTipoVehiculo.Text <> Nothing Then
            Try
                If o_vehiculo.Agregar_TipoVehiculo(txtTipoVehiculo.Text) Then

                    'Almacenar el nombre del nuevo tipo de vehiculo
                    NuevoTipoVehiculoNombre = txtTipoVehiculo.Text
                    MsgBox("Tipo de vehículo agregado correctamente.", vbInformation, "Información")

                    'Al cerrar el modal devuelve un resultado específico en el frmVehiculo
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("El tipo de vehículo ya existe, puede modificarlo en Gestión de Datos.", vbExclamation, "Tipo de vehículo duplicado")
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox("Error al agregar el tipo de vehículo: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
        End If
    End Sub
#End Region

End Class