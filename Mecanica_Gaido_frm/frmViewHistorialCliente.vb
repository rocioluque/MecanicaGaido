Imports Telerik.Reporting
Imports Telerik.Reporting.Processing
Imports Telerik.Reporting.Drawing
Imports System.IO

Public Class frmViewHistorialCliente
    Public Property ID_Persona As Integer
    Public Property FechaMin As Date
    Public Property FechaMax As Date

    <Obsolete>
    Private Sub frmViewHistorialCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reportViewer As New Telerik.ReportViewer.WinForms.ReportViewer()

        ' Establecer el tamaño y el anclaje del control (para que se ajuste al formulario)
        reportViewer.Dock = DockStyle.Fill

        Dim report As New RptHistorialCliente()

        ' Asignar el parámetro al reporte
        report.ReportParameters("ID_Persona").Value = ID_Persona
        report.ReportParameters("FechaMin").Value = FechaMin
        report.ReportParameters("FechaMax").Value = FechaMax

        reportViewer.ReportSource = report
        Me.Controls.Add(reportViewer)

        ' Refrescar el ReportViewer para que muestre el reporte
        reportViewer.RefreshReport()
    End Sub

End Class