Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration


Public Class frmOrdenesReparacion

    Dim o_Orden As New AD_OrdenReparacion
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtID.Clear()
        'ver que hacer con el cboVehiculo'
        txtSeñasParticulares.Clear()
        txtMotivo.Clear()
        txtFechaturno.Clear()
        txtFechaentrada.Clear()
        txtFechaestimada.Clear()
        txtFechasalida.Clear()
        cboCuenta.SelectedIndex = 0
        cboServicios.SelectedIndex = 0
        chkActivo.Checked = False
    End Sub


    Private Sub txtSeñasParticulares_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSeñasParticulares.KeyPress
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

    Private Sub frmOrdenesReparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Cargar_Combo_Vehiculos()
        Try
            Dim tabla As DataTable = o_Orden.Cargar_Combo_Vehiculos()

            If tabla.Rows.Count > 0 Then
                cboCuenta.DataSource = tabla
                cboVehiculo.DisplayMember = "Nombre/RazonSocial"
                cboVehiculo.ValueMember = "ID_Persona"
                cboVehiculo.SelectedValue = -1
            Else
                MsgBox("No se encontraron Vehiculos.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Vehiculos-: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub