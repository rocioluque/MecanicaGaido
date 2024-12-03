Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization
Imports AD_Mecanica_Gaido

Public Class frmReportesVehiculos
    Dim oDS As New DataSet
    Dim o_reporte As New AD_Reportes
    Private Sub frmReportesVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarTema(Me)
        Cargar_Combo_Vehiculo(String.Empty, String.Empty)
        dtpFechaMax.Value = DateTime.Now
        dtpFechaMin.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        Cargar_Criterios()
    End Sub
    Private Sub Cargar_Criterios()
        cboCriterio.Items.Clear()
        cboCriterio.Items.Add("Matricula")
        cboCriterio.Items.Add("Numero_Chasis")
        cboCriterio.Items.Add("Numero_Motor")
    End Sub


    Private Sub Cargar_Combo_Vehiculo(criterio As String, valor As String)
        Try
            Dim tabla As DataTable = o_reporte.Cargar_Combo_Vehiculo(criterio, valor)

            If tabla.Rows.Count > 0 Then
                cboVehiculo.DataSource = tabla
                cboVehiculo.DisplayMember = "Nombre"
                cboVehiculo.ValueMember = "ID_Vehiculo"

            Else
                MsgBox("No se encontraron Vehículos.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Vehículos: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub



    Private Sub MostrarHistorialReparaciones(ByVal ID_Vehiculo As Integer, ByVal FechaMin As String, ByVal FechaMax As String)
        Dim frmReporte As New frmViewHistorialVehiculo()

        ' Pasar los parámetros al formulario del reporte
        frmReporte.ID_Vehiculo = ID_Vehiculo
        frmReporte.FechaMin = FechaMin
        frmReporte.FechaMax = FechaMax

        ' Mostrar el formulario a pantalla completa
        frmReporte.WindowState = FormWindowState.Maximized
        frmReporte.ShowDialog()
    End Sub

    Private Sub btnObtenerHistorial_Click(sender As Object, e As EventArgs) Handles btnObtenerHistorial.Click
        If cboVehiculo.SelectedValue <> Nothing Then
            Dim ID_Vehiculo As Integer = cboVehiculo.SelectedValue
            Dim FechaMin As Date = dtpFechaMin.Value.Date
            Dim FechaMax As Date = dtpFechaMax.Value.Date

            If dtpFechaMin.Value <= dtpFechaMax.Value Then
                If o_reporte.TieneOrdenesDeReparacion_V(ID_Vehiculo, FechaMin, FechaMax) Then
                    MostrarHistorialReparaciones(ID_Vehiculo, FechaMin, FechaMax)
                Else
                    MsgBox("El vehículo seleccionado no tiene órdenes de reparación.", vbInformation, "Información")
                End If
            Else
                MsgBox("La fecha inicial no puede ser mayor que la fecha final.", vbExclamation, "Error en las fechas")
            End If
        Else
            MsgBox("Por favor seleccione un vehículo para buscar su historial de reparaciones.", vbInformation, "Información")
        End If
    End Sub

    Private Sub txtCriterio_leave(sender As Object, e As EventArgs) Handles txtCriterio.Leave
        txtCriterio.Text = txtCriterio.Text.ToUpper()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If cboCriterio.SelectedIndex >= 0 AndAlso Not String.IsNullOrWhiteSpace(txtCriterio.Text) Then
            Dim criterio As String = cboCriterio.SelectedItem.ToString()
            Dim valor As String = txtCriterio.Text

            ' Validar que el criterio sea uno permitido (seguridad adicional)
            Select Case criterio
                Case "Matricula", "Numero_Chasis", "Numero_Motor"
                    Cargar_Combo_Vehiculo(criterio, valor)
                Case Else
                    MsgBox("Seleccione un criterio válido.", vbExclamation, "Advertencia")
            End Select
        Else
            MsgBox("Debe seleccionar un criterio y completar el campo de texto.", vbExclamation, "Advertencia")
        End If

        ' Limpia los controles
        cboCriterio.SelectedIndex = -1
        txtCriterio.Clear()
    End Sub




End Class