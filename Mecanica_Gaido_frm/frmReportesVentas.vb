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
        AplicarTema(Me)
        VentasPorMes()
        VentasPorEmpleado()
    End Sub
#End Region

#Region "Grafico Ventas por mes"
    Private Sub VentasPorMes()
        Dim año As Integer
        If Integer.TryParse(txtAño.Text, año) Then
            Dim dt As DataTable = o_reportes.ObtenerVentasPorMes(año)

            lblNoInformacion.Visible = False
            chartVentasMes.Visible = True

            chartVentasMes.Series.Clear()

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

                chartVentasMes.BackColor = Color.Transparent
                chartVentasMes.ChartAreas(0).BackColor = Color.Transparent
                chartVentasMes.ChartAreas(0).AxisX.Interval = 1
                chartVentasMes.ChartAreas(0).AxisX.Title = ""
                chartVentasMes.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.White
                chartVentasMes.ChartAreas(0).AxisX.LineColor = Color.White
                chartVentasMes.ChartAreas(0).AxisX.MajorGrid.Enabled = False
                chartVentasMes.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Century Gothic", 9.75F)
                chartVentasMes.ChartAreas(0).AxisX.TitleForeColor = Color.White
                chartVentasMes.ChartAreas(0).AxisX.LabelStyle.Angle = -45
                chartVentasMes.ChartAreas(0).AxisX.CustomLabels.Clear()

                For i As Integer = 1 To 12
                    chartVentasMes.ChartAreas(0).AxisX.CustomLabels.Add(i - 0.5, i + 0.5, New DateTime(2023, i, 1).ToString("MMMM"))
                Next

                chartVentasMes.ChartAreas(0).AxisY.Title = "Cantidad de Ventas"
                chartVentasMes.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.White
                chartVentasMes.ChartAreas(0).AxisY.LineColor = Color.White
                chartVentasMes.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Gray
                chartVentasMes.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Century Gothic", 8)
                chartVentasMes.ChartAreas(0).AxisY.TitleForeColor = Color.White

                chartVentasMes.Legends.Clear()
                Dim legend As New Legend("Leyenda")
                legend.Docking = Docking.Top
                legend.BackColor = Color.Transparent
                legend.ForeColor = Color.White
                legend.Title = "Ventas por Mes"
                legend.TitleFont = New Font("Century Gothic", 9.75F, FontStyle.Regular)
                legend.TitleForeColor = Color.White
                legend.Alignment = StringAlignment.Center
                chartVentasMes.Legends.Add(legend)
            Else
                lblNoInformacion.Visible = True
                chartVentasMes.Visible = False
                lblNoInformacion.Text = "No hay ventas en el año seleccionado."
            End If
        End If
    End Sub

    Private Sub txtAño_TextChanged(sender As Object, e As EventArgs) Handles txtAño.TextChanged
        'Dim año As Integer
        'If txtAño.Text.Length = 4 AndAlso Integer.TryParse(txtAño.Text, año) Then
        '    VentasPorMes()
        'Else
        '    lblNoInformacion.Visible = True
        '    chartVentasMes.Visible = False
        '    lblNoInformacion.Text = "Ingrese un año valido"
        'End If
    End Sub
#End Region

#Region "Grafico Ventas por empleado"
    Private Sub VentasPorEmpleado()
        Dim dt As DataTable = o_reportes.ObtenerVentasPorEmpleado()

        ChtVentasEmpleado.Series.Clear()

        Dim series As New Series("Ventas por Empleado")
        series.ChartType = SeriesChartType.Column
        series.IsValueShownAsLabel = True
        series.LabelForeColor = Color.White

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Dim empleado As String = row("Empleado").ToString()
                Dim cantidad As Integer = Convert.ToInt32(row("CantidadVentas"))
                series.Points.AddXY(empleado, cantidad)
            Next

            ChtVentasEmpleado.Series.Add(series)

            ' Customizar gráfico
            ChtVentasEmpleado.BackColor = Color.Transparent
            ChtVentasEmpleado.ChartAreas(0).BackColor = Color.Transparent
            ChtVentasEmpleado.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.White
            ChtVentasEmpleado.ChartAreas(0).AxisY.Title = "Cantidad de Ventas"
            ChtVentasEmpleado.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.White

            ' Leyenda
            ChtVentasEmpleado.Legends.Clear()
            Dim legend As New Legend("Leyenda")
            legend.Docking = Docking.Top
            legend.ForeColor = Color.White
            ChtVentasEmpleado.Legends.Add(legend)
        Else
            lblNoInformacion.Visible = True
            ChtVentasEmpleado.Visible = False
            lblNoInformacion.Text = "No hay ventas registradas."
        End If
    End Sub
#End Region

End Class