Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmReportesReparaciones
    Dim o_reportes As New AD_Reportes

    Private Sub frmReportesReparaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReparacionesPorMes()
    End Sub

    Private Sub ReparacionesPorMes()
        Dim año As Integer
        If Integer.TryParse(txtAño.Text, año) Then
            Dim dt As DataTable = o_reportes.Contar_Reparaciones_Mes(año)

            lblNoInformacion.Visible = False
            chartReparacionesMes.Visible = True

            chartReparacionesMes.Series.Clear()
            Dim series As New Series("Reparaciones por Mes")
            series.ChartType = SeriesChartType.Line

            If dt.Rows.Count > 0 Then

                For Each row As DataRow In dt.Rows
                    series.Points.AddXY(row("Mes"), row("CantidadReparaciones"))
                Next

                chartReparacionesMes.Series.Add(series)
                chartReparacionesMes.ChartAreas(0).AxisX.Title = "Mes"
                chartReparacionesMes.ChartAreas(0).AxisY.Title = "Cantidad de Reparaciones"
                chartReparacionesMes.ChartAreas(0).AxisX.Interval = 1
            Else
                lblNoInformacion.Visible = True
                chartReparacionesMes.Visible = False
                lblNoInformacion.Text = "No hay reparaciones en el año seleccionado."
            End If
        End If
    End Sub

    Private Sub txtAño_TextChanged(sender As Object, e As EventArgs) Handles txtAño.TextChanged
        Dim año As Integer
        If txtAño.Text.Length = 4 AndAlso Integer.TryParse(txtAño.Text, año) Then
            ReparacionesPorMes()
        Else
            lblNoInformacion.Visible = True
            chartReparacionesMes.Visible = False
            lblNoInformacion.Text = "Ingrese un año valido"
        End If
    End Sub
End Class