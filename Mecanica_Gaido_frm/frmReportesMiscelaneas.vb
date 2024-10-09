Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration


Public Class frmReportesMiscelaneas
    Dim o_Orden As New AD_OrdenReparacion
    Private Sub frmReportesMiscelaneas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarTema(Me)

    End Sub
End Class