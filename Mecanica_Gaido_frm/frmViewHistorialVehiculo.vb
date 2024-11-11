Imports Telerik.Reporting
Imports Telerik.Reporting.Processing
Imports Telerik.Reporting.Drawing
Imports System.IO

Public Class frmViewHistorialVehiculo
    Public Property ID_Vehiculo As Integer

    <Obsolete>
    Private Sub frmViewHistorialVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reportViewer As New Telerik.ReportViewer.WinForms.ReportViewer()

        ' Establecer el tamaño y el anclaje del control (para que se ajuste al formulario)
        reportViewer.Dock = DockStyle.Fill

        Dim report As New RptHistorialVehiculo()

        ' Asignar el parámetro al reporte
        report.ReportParameters("ID_Vehiculo").Value = ID_Vehiculo

        reportViewer.ReportSource = report
        Me.Controls.Add(reportViewer)

        ' Refrescar el ReportViewer para que muestre el reporte
        reportViewer.RefreshReport()
    End Sub

End Class