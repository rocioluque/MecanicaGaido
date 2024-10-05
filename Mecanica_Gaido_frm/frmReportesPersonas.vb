'Imports LiveCharts
'Imports LiveCharts.Wpf
Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization

Public Class frmReportesPersonas
    Private Sub frmReportesPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarTema(Me)
    End Sub
End Class