Imports LiveCharts
Imports LiveCharts.Wpf
Public Class frmReportes
    Private Sub grafico()
        Dim cartesianChart As New LiveCharts.WinForms.CartesianChart()
        cartesianChart.Series = New SeriesCollection From {
    New LineSeries With {
        .Values = New ChartValues(Of Double) From {3, 5, 7, 4}
    }
}
        Me.Controls.Add(cartesianChart)
    End Sub

End Class