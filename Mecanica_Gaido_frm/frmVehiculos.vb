Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmVehiculos
    Dim o_vehiculo As New AD_Vehiculos

#Region "Procedimientos"
    Private Sub frmVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Marcas()
        Cargar_Combo_TipoVehiculo()
        limpiar
    End Sub

    Public Sub Limpiar()
        txtID.Clear()
        txtNombre.Clear()
        txtModelo.Clear()
        txtColor.Clear()
        txtNumchasis.Clear()
        txtNumotor.Clear()
        txtMatricula.Clear()
        cboTipoVehiculo.SelectedIndex = -1
        cboMarca.SelectedIndex = -1
        chkEstado.Checked = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
    End Sub
#End Region

#Region "Carga cbo"
    Private Sub Cargar_Combo_Marcas()
        Try
            Dim tabla As DataTable = o_vehiculo.Cargar_Combo_Marcas()

            If tabla.Rows.Count > 0 Then
                cboMarca.DataSource = tabla
                cboMarca.DisplayMember = "Nombre"
                cboMarca.ValueMember = "ID_Marca"
                cboMarca.SelectedValue = -1
            Else
                MsgBox("No se encontraron Marcas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar la Marca: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_TipoVehiculo()
        Try
            Dim tabla As DataTable = o_vehiculo.Cargar_Combo_TipoVehiculo()

            If tabla.Rows.Count > 0 Then
                cboTipoVehiculo.DataSource = tabla
                cboTipoVehiculo.DisplayMember = "Nombre"
                cboTipoVehiculo.ValueMember = "ID_TipoVehiculo"
                cboTipoVehiculo.SelectedValue = -1
            Else
                MsgBox("No se encontraron Vehiculos.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar el tipo de Vehiculo: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Marca"
    Private Sub btnAgregarMarca_Click(sender As Object, e As EventArgs) Handles btnAgregarMarca.Click
        Dim frm As New frmAgregarMarca()

        'Comprueba que si se cerró el modal, se cargue el combo con los nuevos datos
        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_Marcas()

            ' Buscar y seleccionar la nueva marca en el ComboBox
            Dim nuevaMarcaVehiculo As String = frm.NuevaMarcaVehiculoNombre
            For Each item As DataRowView In cboMarca.Items
                If item("Nombre").ToString() = nuevaMarcaVehiculo Then
                    cboMarca.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub
#End Region

#Region "Tipo de Vehiculo"
    Private Sub btnAgregarTipoVehiculo_Click(sender As Object, e As EventArgs) Handles btnAgregarTipoVehiculo.Click
        Dim frm As New frmAgregarTipoVehiculo()

        'Comprueba que si se cerró el modal, se cargue el combo con los nuevos datos
        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_TipoVehiculo()

            ' Buscar y seleccionar la nueva marca en el ComboBox
            Dim nuevoTipoVehiculo As String = frm.NuevoTipoVehiculoNombre
            For Each item As DataRowView In cboTipoVehiculo.Items
                If item("Nombre").ToString() = nuevoTipoVehiculo Then
                    cboTipoVehiculo.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub
#End Region
End Class