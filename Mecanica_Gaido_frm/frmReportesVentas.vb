Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmReportesVentas
    Dim o_reportes As New AD_Reportes

#Region "Procedimientos"
    Private Sub frmReportesVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VentasPorMes()
        VentasPorEmpleado()
        AplicarTema(Me)
    End Sub
#End Region

#Region "Grafico Ventas por mes"
    Private Sub VentasPorMes()
        Dim año As Integer

        If Integer.TryParse(txtAño.Text, año) Then
            Dim dt As DataTable = o_reportes.ObtenerVentasPorMes(año)

            lblNoInformacion.Visible = False
            chartVentasMes.Visible = True

            ' Limpiar solo las series y leyendas, mantener el ChartArea
            chartVentasMes.Series.Clear()
            chartVentasMes.Legends.Clear()

            ' Obtener el ChartArea existente o crear uno nuevo si no existe
            Dim chartArea As ChartArea
            If chartVentasMes.ChartAreas.Count > 0 Then
                chartArea = chartVentasMes.ChartAreas(0)
            Else
                chartArea = New ChartArea()
                chartVentasMes.ChartAreas.Add(chartArea)
            End If

            ' Configurar el ChartArea
            chartArea.BackColor = Color.Transparent
            chartArea.AxisX.Interval = 1
            chartArea.AxisX.Title = ""
            chartArea.AxisX.LabelStyle.ForeColor = Color.White
            chartArea.AxisX.LineColor = Color.White
            chartArea.AxisX.MajorGrid.Enabled = False
            chartArea.AxisX.LabelStyle.Font = New Font("Century Gothic", 9.75F)
            chartArea.AxisX.TitleForeColor = Color.White
            chartArea.AxisX.LabelStyle.Angle = -45

            ' Configurar eje Y
            chartArea.AxisY.Title = "Cant. de Ventas"
            chartArea.AxisY.LabelStyle.ForeColor = Color.White
            chartArea.AxisY.LineColor = Color.White
            chartArea.AxisY.MajorGrid.LineColor = Color.Gray
            chartArea.AxisY.LabelStyle.Font = New Font("Century Gothic", 8)
            chartArea.AxisY.TitleForeColor = Color.White

            Dim seriesAñoActual As New Series("Ventas Año " & año)
            seriesAñoActual.ChartType = SeriesChartType.Line
            seriesAñoActual.IsValueShownAsLabel = True
            seriesAñoActual.LabelForeColor = Color.White
            seriesAñoActual.Color = Color.FromArgb(60, 179, 113)
            seriesAñoActual.BorderWidth = 3

            Dim seriesAñoAnterior As New Series("Ventas Año " & (año - 1))
            seriesAñoAnterior.ChartType = SeriesChartType.Line
            seriesAñoAnterior.IsValueShownAsLabel = True
            seriesAñoAnterior.LabelForeColor = Color.White
            seriesAñoAnterior.Color = Color.FromArgb(146, 139, 87)
            seriesAñoAnterior.BorderWidth = 3

            Dim maxCantidad As Decimal = 0
            Dim minCantidad As Decimal = Decimal.MaxValue

            For Each row As DataRow In dt.Rows
                Dim cantidad As Decimal = Convert.ToDecimal(row("CantidadVentas"))
                maxCantidad = Math.Max(maxCantidad, cantidad)
                minCantidad = Math.Min(minCantidad, cantidad)
            Next

            Dim intervalo As Decimal = Math.Ceiling((maxCantidad - minCantidad) / 5.0)
            chartArea.AxisY.Interval = Math.Max(intervalo, 1)
            chartArea.AxisY.MajorGrid.Interval = Math.Max(intervalo, 1)

            chartArea.AxisY.Minimum = Math.Max(minCantidad - intervalo, 0)
            chartArea.AxisY.Maximum = maxCantidad + intervalo

            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    Dim mes As Integer = Convert.ToInt32(row("Mes"))
                    Dim cantidad As Decimal = Convert.ToDecimal(row("CantidadVentas"))
                    Dim añoDato As Integer = Convert.ToInt32(row("Año"))

                    If añoDato = año Then
                        seriesAñoActual.Points.AddXY(mes, cantidad)
                    ElseIf añoDato = año - 1 Then
                        seriesAñoAnterior.Points.AddXY(mes, cantidad)
                    End If
                Next

                chartVentasMes.Series.Add(seriesAñoActual)
                chartVentasMes.Series.Add(seriesAñoAnterior)

                ' Configurar etiquetas personalizadas del eje X
                chartArea.AxisX.CustomLabels.Clear()
                For i As Integer = 1 To 12
                    chartArea.AxisX.CustomLabels.Add(i - 0.5, i + 0.5, New DateTime(2023, i, 1).ToString("MMMM"))
                Next

                ' Configurar leyenda
                Dim legend As New Legend("Leyenda")
                legend.Docking = Docking.Top
                legend.BackColor = Color.Transparent
                legend.ForeColor = Color.White
                legend.Title = "Ventas por Mes"
                legend.TitleFont = New Font("Century Gothic", 9.75F, FontStyle.Regular)
                legend.TitleForeColor = Color.White
                legend.Alignment = StringAlignment.Center
                chartVentasMes.Legends.Add(legend)

                chartVentasMes.BackColor = Color.Transparent
            Else
                lblNoInformacion.Visible = True
                chartVentasMes.Visible = False
                lblNoInformacion.Text = "No hay ventas en el año seleccionado."
            End If
        End If
    End Sub

    Private Sub txtAño_TextChanged(sender As Object, e As EventArgs) Handles txtAño.TextChanged
        Dim año As Integer
        If txtAño.Text.Length = 4 AndAlso Integer.TryParse(txtAño.Text, año) Then
            VentasPorMes()
        Else
            lblNoInformacion.Visible = True
            chartVentasMes.Visible = False
            lblNoInformacion.Text = "Ingrese un año valido"
        End If
    End Sub
#End Region

#Region "Grafico Ventas por empleado"
    Private Sub VentasPorEmpleado()
        Dim dt As DataTable = o_reportes.ObtenerVentasPorEmpleado()

        ChtVentasEmpleado.Series.Clear()

        Dim series As New Series("Ventas por Empleado")
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

        Dim maxCantidad As Integer = 0
        Dim minCantidad As Integer = Integer.MaxValue

        For Each row As DataRow In dt.Rows
            Dim empleado As String = row("Empleado").ToString()
            Dim cantidad As Integer = Convert.ToInt32(row("CantidadVentas"))

            maxCantidad = Math.Max(maxCantidad, cantidad)
            minCantidad = Math.Min(minCantidad, cantidad)

            Dim pointIndex As Integer = series.Points.AddXY(empleado, cantidad)
            series.Points(pointIndex).Color = colors(colorIndex Mod colors.Length)
            colorIndex += 1
        Next

        ChtVentasEmpleado.Series.Add(series)

        ChtVentasEmpleado.BackColor = Color.Transparent
        ChtVentasEmpleado.ChartAreas(0).BackColor = Color.Transparent

        ChtVentasEmpleado.ChartAreas(0).AxisX.Title = ""
        ChtVentasEmpleado.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        ChtVentasEmpleado.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.White
        ChtVentasEmpleado.ChartAreas(0).AxisX.LineColor = Color.White
        ChtVentasEmpleado.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Gray
        ChtVentasEmpleado.ChartAreas(0).AxisX.TitleForeColor = Color.White
        ChtVentasEmpleado.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Century Gothic", 8)

        ChtVentasEmpleado.ChartAreas(0).AxisY.Title = "Cantidad de Ventas"
        ChtVentasEmpleado.ChartAreas(0).AxisY.IsStartedFromZero = True

        Dim intervalo As Integer = Math.Ceiling((maxCantidad - minCantidad) / 5.0)
        ChtVentasEmpleado.ChartAreas(0).AxisY.Interval = Math.Max(intervalo, 1)
        ChtVentasEmpleado.ChartAreas(0).AxisY.MajorGrid.Interval = Math.Max(intervalo, 1)

        ChtVentasEmpleado.ChartAreas(0).AxisY.Minimum = Math.Max(minCantidad - intervalo, 0)
        ChtVentasEmpleado.ChartAreas(0).AxisY.Maximum = maxCantidad + intervalo

        ChtVentasEmpleado.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.White
        ChtVentasEmpleado.ChartAreas(0).AxisY.LineColor = Color.White
        ChtVentasEmpleado.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Gray
        ChtVentasEmpleado.ChartAreas(0).AxisY.TitleForeColor = Color.White
        ChtVentasEmpleado.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Century Gothic", 9.75F)

        ChtVentasEmpleado.Legends.Clear()
        Dim legend As New Legend("Leyenda")
        legend.Docking = Docking.Top
        legend.ForeColor = Color.White
        legend.BackColor = Color.Transparent
        legend.Title = "Cantidad de Ventas por Empleados"
        legend.TitleFont = New Font("Century Gothic", 9.75F, FontStyle.Regular)
        legend.TitleForeColor = Color.White
        legend.Alignment = StringAlignment.Center
        ChtVentasEmpleado.Legends.Add(legend)

        For i As Integer = 0 To series.Points.Count - 1
            Dim legendItem As New LegendItem()
            legendItem.Name = series.Points(i).AxisLabel
            legendItem.Color = series.Points(i).Color
            legend.CustomItems.Add(legendItem)
        Next
    End Sub
#End Region

End Class