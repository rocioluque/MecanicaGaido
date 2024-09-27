Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmReportesReparaciones
    Dim o_reportes As New AD_Reportes

#Region "Procedimientos"
    Private Sub frmReportesReparaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReparacionesPorMes()
        CargarGraficoTiposReparacion()
    End Sub
#End Region

#Region "Gráfico Rep por Mes"
    Private Sub ReparacionesPorMes()
        Dim año As Integer
        If Integer.TryParse(txtAño.Text, año) Then
            Dim dt As DataTable = o_reportes.Contar_Reparaciones_Mes(año)

            lblNoInformacion.Visible = False
            chartReparacionesMes.Visible = True

            chartReparacionesMes.Series.Clear()

            Dim seriesAñoActual As New Series("Reparaciones Año " & año)
            seriesAñoActual.ChartType = SeriesChartType.Line
            seriesAñoActual.IsValueShownAsLabel = True
            seriesAñoActual.LabelForeColor = Color.White
            seriesAñoActual.Color = Color.FromArgb(60, 179, 113)
            seriesAñoActual.BorderWidth = 3 '

            Dim seriesAñoAnterior As New Series("Reparaciones Año " & (año - 1))
            seriesAñoAnterior.ChartType = SeriesChartType.Line
            seriesAñoAnterior.IsValueShownAsLabel = True
            seriesAñoAnterior.LabelForeColor = Color.White
            seriesAñoAnterior.Color = Color.FromArgb(146, 139, 87)
            seriesAñoAnterior.BorderWidth = 3

            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    Dim mes As Integer = Convert.ToInt32(row("Mes"))
                    Dim cantidad As Integer = Convert.ToInt32(row("CantidadReparaciones"))
                    Dim añoDato As Integer = Convert.ToInt32(row("Año"))

                    If añoDato = año Then
                        seriesAñoActual.Points.AddXY(mes, cantidad)
                    ElseIf añoDato = año - 1 Then
                        seriesAñoAnterior.Points.AddXY(mes, cantidad)
                    End If
                Next

                chartReparacionesMes.Series.Add(seriesAñoActual)
                chartReparacionesMes.Series.Add(seriesAñoAnterior)

                chartReparacionesMes.BackColor = Color.Transparent
                chartReparacionesMes.ChartAreas(0).BackColor = Color.Transparent
                chartReparacionesMes.ChartAreas(0).AxisX.Interval = 1
                chartReparacionesMes.ChartAreas(0).AxisX.Title = ""
                chartReparacionesMes.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.White
                chartReparacionesMes.ChartAreas(0).AxisX.LineColor = Color.White
                chartReparacionesMes.ChartAreas(0).AxisX.MajorGrid.Enabled = False
                chartReparacionesMes.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Century Gothic", 9.75F)
                chartReparacionesMes.ChartAreas(0).AxisX.TitleForeColor = Color.White
                chartReparacionesMes.ChartAreas(0).AxisX.LabelStyle.Angle = -45
                chartReparacionesMes.ChartAreas(0).AxisX.CustomLabels.Clear()

                For i As Integer = 1 To 12
                    chartReparacionesMes.ChartAreas(0).AxisX.CustomLabels.Add(i - 0.5, i + 0.5, New DateTime(2023, i, 1).ToString("MMMM"))
                Next

                chartReparacionesMes.ChartAreas(0).AxisY.Title = "Cant. de Reparaciones"
                chartReparacionesMes.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.White
                chartReparacionesMes.ChartAreas(0).AxisY.LineColor = Color.White
                chartReparacionesMes.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Gray
                chartReparacionesMes.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Century Gothic", 8)
                chartReparacionesMes.ChartAreas(0).AxisY.TitleForeColor = Color.White

                chartReparacionesMes.Legends.Clear()
                Dim legend As New Legend("Leyenda")
                legend.Docking = Docking.Top
                legend.BackColor = Color.Transparent
                legend.ForeColor = Color.White
                legend.Title = "Reparaciones por Mes"
                legend.TitleFont = New Font("Century Gothic", 9.75F, FontStyle.Regular)
                legend.TitleForeColor = Color.White
                legend.Alignment = StringAlignment.Center
                chartReparacionesMes.Legends.Add(legend)
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
#End Region

#Region "Grafico Tipos de Reparaciones"
    Private Sub CargarGraficoTiposReparacion()
        Dim o_reportes As New AD_Reportes()
        Dim dtTiposReparacion As DataTable = o_reportes.ObtenerOrdenesPorTipoReparacion()

        ChtOrdenReparacion.Series.Clear()

        Dim series As New Series("Cantidad por Tipo de Reparación")
        series.IsVisibleInLegend = False
        series.ChartType = SeriesChartType.Column
        series.IsValueShownAsLabel = True
        series.LabelForeColor = Color.White
        series.Font = New Font("Century Gothic", 9.75F)

        Dim colors As Color() = {
        Color.FromArgb(146, 139, 87),
        Color.FromArgb(60, 179, 113),
        Color.FromArgb(32, 178, 170),
        Color.FromArgb(0, 139, 69),
        Color.FromArgb(0, 255, 127),
        Color.FromArgb(46, 139, 87)
    }
        Dim colorIndex As Integer = 0

        For Each row As DataRow In dtTiposReparacion.Rows
            Dim tipoReparacion As String = row("TipoDeReparacion").ToString()
            Dim cantidad As Integer = Convert.ToInt32(row("Cantidad"))

            Dim pointIndex As Integer = series.Points.AddXY(tipoReparacion, cantidad)

            series.Points(pointIndex).Color = colors(colorIndex Mod colors.Length)
            colorIndex += 1
        Next

        ChtOrdenReparacion.Series.Add(series)

        ChtOrdenReparacion.BackColor = Color.Transparent
        ChtOrdenReparacion.ChartAreas(0).BackColor = Color.Transparent

        ChtOrdenReparacion.ChartAreas(0).AxisX.Title = ""
        ChtOrdenReparacion.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        ChtOrdenReparacion.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisX.LineColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Gray
        ChtOrdenReparacion.ChartAreas(0).AxisX.TitleForeColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Century Gothic", 8)

        ChtOrdenReparacion.ChartAreas(0).AxisY.Title = "Cantidad de Órdenes"
        ChtOrdenReparacion.ChartAreas(0).AxisY.IsStartedFromZero = True
        ChtOrdenReparacion.ChartAreas(0).AxisY.LabelStyle.Interval = 1
        ChtOrdenReparacion.ChartAreas(0).AxisY.MajorGrid.Interval = 1
        ChtOrdenReparacion.ChartAreas(0).AxisY.MajorGrid.Enabled = True
        ChtOrdenReparacion.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisY.LineColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Gray
        ChtOrdenReparacion.ChartAreas(0).AxisY.TitleForeColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Century Gothic", 9.75F)

        ChtOrdenReparacion.Legends.Clear()
        Dim legend As New Legend("Leyenda")
        legend.Docking = Docking.Top
        legend.BackColor = Color.Transparent
        legend.ForeColor = Color.White
        legend.Title = "Órdenes de Reparación por Tipo"
        legend.TitleFont = New Font("Century Gothic", 9.75F, FontStyle.Regular)
        legend.TitleForeColor = Color.White
        legend.Alignment = StringAlignment.Center
        ChtOrdenReparacion.Legends.Add(legend)

        For i As Integer = 0 To series.Points.Count - 1
            Dim legendItem As New LegendItem()
            legendItem.Name = series.Points(i).AxisLabel
            legendItem.Color = series.Points(i).Color
            legend.CustomItems.Add(legendItem)
        Next
    End Sub
#End Region

End Class