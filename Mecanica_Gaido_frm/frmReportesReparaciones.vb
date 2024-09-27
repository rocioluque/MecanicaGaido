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
#End Region

#Region "Grafico Tipos de Reparaciones"
    Private Sub CargarGraficoTiposReparacion()
        Dim o_reportes As New AD_Reportes()
        Dim dtTiposReparacion As DataTable = o_reportes.ObtenerOrdenesPorTipoReparacion()

        ' Limpia las series anteriores del gráfico
        ChtOrdenReparacion.Series.Clear()

        ' Crear una nueva serie para el gráfico
        Dim series As New Series("Cantidad por Tipo de Reparación")
        series.IsVisibleInLegend = False
        series.ChartType = SeriesChartType.Column

        ' Configuración de etiquetas de la serie
        series.IsValueShownAsLabel = True
        series.LabelForeColor = Color.White
        series.Font = New Font("Century Gothic", 9.75F)

        ' Colores personalizados
        Dim colors As Color() = {
        Color.FromArgb(146, 139, 87),
        Color.FromArgb(60, 179, 113),
        Color.FromArgb(32, 178, 170),
        Color.FromArgb(0, 139, 69),
        Color.FromArgb(0, 255, 127)
    }
        Dim colorIndex As Integer = 0

        ' Leer los datos del procedimiento almacenado y agregarlos al gráfico
        For Each row As DataRow In dtTiposReparacion.Rows
            Dim tipoReparacion As String = row("TipoDeReparacion").ToString()
            Dim cantidad As Integer = Convert.ToInt32(row("Cantidad"))

            Dim pointIndex As Integer = series.Points.AddXY(tipoReparacion, cantidad)

            ' Establecer el color de la serie para esta categoría
            series.Points(pointIndex).Color = colors(colorIndex Mod colors.Length)
            colorIndex += 1
        Next

        ' Agregar la serie al gráfico
        ChtOrdenReparacion.Series.Add(series)

        ' Personalización del gráfico
        ChtOrdenReparacion.ChartAreas(0).AxisX.Title = ""
        ChtOrdenReparacion.ChartAreas(0).AxisY.Title = "Cantidad de Órdenes"

        ' Configurar eje Y para mostrar solo valores enteros
        ChtOrdenReparacion.ChartAreas(0).AxisY.IsStartedFromZero = True
        ChtOrdenReparacion.ChartAreas(0).AxisY.LabelStyle.Interval = 1
        ChtOrdenReparacion.ChartAreas(0).AxisY.MajorGrid.Interval = 1

        ' Desactivar las líneas verticales
        ChtOrdenReparacion.ChartAreas(0).AxisX.MajorGrid.Enabled = False

        ' Activar solo las líneas horizontales
        ChtOrdenReparacion.ChartAreas(0).AxisY.MajorGrid.Enabled = True

        ' Configurar colores y tipografía para fondo oscuro
        ChtOrdenReparacion.BackColor = Color.Transparent
        ChtOrdenReparacion.ChartAreas(0).BackColor = Color.Transparent
        ChtOrdenReparacion.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisX.LineColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisY.LineColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Gray
        ChtOrdenReparacion.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Gray
        ChtOrdenReparacion.ChartAreas(0).AxisX.TitleForeColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisY.TitleForeColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Century Gothic", 9.75F)
        ChtOrdenReparacion.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Century Gothic", 9.75F)

        ' Configurar leyenda
        ChtOrdenReparacion.Legends.Clear()
        Dim legend As New Legend("Leyenda")
        legend.Docking = Docking.Top
        legend.BackColor = Color.Transparent
        legend.ForeColor = Color.White
        legend.Title = "Órdenes de Reparación por Tipo"
        legend.TitleFont = New Font("Century Gothic", 12, FontStyle.Regular)
        legend.TitleForeColor = Color.White
        legend.Alignment = StringAlignment.Center
        ChtOrdenReparacion.Legends.Add(legend)

        ' Crear los elementos personalizados para la leyenda
        For i As Integer = 0 To series.Points.Count - 1
            Dim legendItem As New LegendItem()
            legendItem.Name = series.Points(i).AxisLabel
            legendItem.Color = series.Points(i).Color
            legend.CustomItems.Add(legendItem)
        Next
    End Sub
#End Region


End Class