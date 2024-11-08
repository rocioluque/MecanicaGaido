Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization
Imports AD_Mecanica_Gaido

Public Class frmReportesPersonas
    Dim oDS As New DataSet
    Dim o_reporte As New AD_Reportes

#Region "Procedimientos"
    Private Sub frmReportesPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarTema(Me)
        Cargar_Combo_Persona()
    End Sub

    Private Sub Cargar_Combo_Persona()
        Try
            Dim tabla As DataTable = o_reporte.Cargar_Combo_Persona()

            If tabla.Rows.Count > 0 Then
                cboPersona.DataSource = tabla
                cboPersona.DisplayMember = "Persona"
                cboPersona.ValueMember = "ID_Persona"
                cboPersona.SelectedValue = NavegacionEntreForms.persona
            Else
                MsgBox("No se encontraron Personas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las Personas: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

    Private Sub MostrarHistorialReparaciones(ByVal ID_Persona As Integer)
        Dim frmReporte As New frmViewHistorialCliente()

        ' Pasar el parámetro ID_Venta al formulario del reporte
        frmReporte.ID_Persona = ID_Persona

        ' Mostrar el formulario a pantalla completa
        frmReporte.WindowState = FormWindowState.Maximized
        frmReporte.ShowDialog()
    End Sub

    Private Sub btnObtenerHistorial_Click(sender As Object, e As EventArgs) Handles btnObtenerHistorial.Click
        If cboPersona.SelectedValue <> Nothing Then
            Dim ID_Persona As Integer = cboPersona.SelectedValue

            If o_reporte.TieneOrdenesDeReparacion(ID_Persona) Then
                MostrarHistorialReparaciones(ID_Persona)
            Else
                MsgBox("La persona seleccionada no tiene órdenes de reparación.", vbInformation, "Información")
            End If

        Else
            MsgBox("Por favor seleccione una persona para buscar su historial de reparaciones.", vbInformation, "Información")
        End If
    End Sub
End Class