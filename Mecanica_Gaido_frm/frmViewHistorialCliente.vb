Imports Telerik.Reporting
Imports Telerik.Reporting.Processing
Imports Telerik.Reporting.Drawing
Imports System.IO

Public Class frmViewHistorialCliente
    Public Property ID_Persona As Integer

    <Obsolete>
    Private Sub FrmVentaView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Crear instancia del control ReportViewer
        Dim reportViewer As New Telerik.ReportViewer.WinForms.ReportViewer()

        ' Establecer el tamaño y el anclaje del control (para que se ajuste al formulario)
        reportViewer.Dock = DockStyle.Fill

        ' Crear el reporte y asignar el ID_Persona como parámetro
        Dim report As New RptHistorialCliente()

        ' Asignar el parámetro al reporte
        report.ReportParameters("ID_Persona").Value = ID_Persona

        ' Asignar el reporte al ReportViewer
        reportViewer.ReportSource = report

        ' Agregar el control ReportViewer al formulario
        Me.Controls.Add(reportViewer)

        ' Refrescar el ReportViewer para que muestre el reporte
        reportViewer.RefreshReport()
    End Sub
End Class