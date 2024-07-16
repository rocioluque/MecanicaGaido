Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration


Public Class frmVehiculos

    Dim o_vehiculo As New AD_Vehiculos

    Private Sub frmVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Marcas()
        Cargar_Combo_TipoVehiculo()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtID.Clear()
        cboTipo.SelectedIndex = 0
        cboMarca.SelectedIndex = 0
        txtNombre.Clear()
        txtModelo.Clear()
        txtColor.Clear()
        txtNumchasis.Clear()
        txtNumotor.Clear()
        txtMatricula.Clear()
        chkEstado.Checked = False
    End Sub

    Private Sub btnAgregarMarca_Click(sender As Object, e As EventArgs) Handles btnAgregarMarca.Click
        frmAgregarMarca.ShowDialog()
    End Sub

    Private Sub Cargar_Combo_Marcas()
        Try
            Dim tabla As DataTable = o_vehiculo.Cargar_Combo_Marcas()

            If tabla.Rows.Count > 0 Then
                cboMarca.DataSource = tabla
                cboMarca.DisplayMember = "Nombre"
                cboMarca.ValueMember = "ID_Marca"
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
            Else
                MsgBox("No se encontraron Vehiculos.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar el tipo de Vehiculo: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
End Class