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
        cboTipo.SelectedIndex = -1
        cboMarca.SelectedIndex = -1
        txtNombre.Clear()
        txtModelo.Clear()
        txtColor.Clear()
        txtNumchasis.Clear()
        txtNumotor.Clear()
        txtMatricula.Clear()
        chkEstado.Checked = False
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
                cboTipo.DataSource = tabla
                cboTipo.DisplayMember = "Nombre"
                cboTipo.ValueMember = "ID_TipoVehiculo"
                cboTipo.SelectedValue = -1
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
    End Sub
End Class