Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization
Imports AD_Mecanica_Gaido

Public Class frmReportesProductos
    Dim o_reportes As New AD_Reportes()

#Region "Procedimientos"
    Private Sub frmReportesProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Marcas()
        CargarGrilla()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cboMarca.SelectedIndex = -1
        CargarGrilla()
    End Sub
#End Region

#Region "Grilla"
    Private Sub CargarGrilla(Optional marcaID As Integer? = Nothing)
        Dim dsRepuestos As DataSet = o_reportes.ObtenerRepuestos(marcaID)

        If marcaID.HasValue Then
            dsRepuestos = o_reportes.ObtenerRepuestos(marcaID.Value)
        Else
            dsRepuestos = o_reportes.ObtenerRepuestos()
        End If

        Dim dtRepuestos As DataTable = dsRepuestos.Tables(0)

        grdRepuestos.Rows.Clear()

        For Each row As DataRow In dtRepuestos.Rows
            Dim fila As DataGridViewRow = CType(grdRepuestos.Rows(grdRepuestos.Rows.Add()), DataGridViewRow)
            fila.Cells("CodFabricante").Value = row("N° Repuesto")
            fila.Cells("Descripcion").Value = row("Descripcion")
            fila.Cells("StockReal").Value = row("Cantidad")
            fila.Cells("PrecioLista").Value = row("Precio Unitario")
            fila.Cells("Total").Value = row("Total")
        Next

        Dim dtSumaTotal As DataTable = dsRepuestos.Tables(1)
        If dtSumaTotal.Rows.Count > 0 Then
            If Not IsDBNull(dtSumaTotal.Rows(0)("SumaTotal")) Then
                Dim sumaTotal As Decimal = Convert.ToDecimal(dtSumaTotal.Rows(0)("SumaTotal"))
                txtTotal.Text = sumaTotal.ToString("N2")
            Else
                txtTotal.Text = "0.00"
            End If
        End If
    End Sub
#End Region

#Region "Carga cbo"
    Private Sub Cargar_Combo_Marcas()
        Try
            Dim tabla As DataTable = o_reportes.Cargar_Combo_Marcas

            If tabla.Rows.Count > 0 Then
                cboMarca.DataSource = tabla
                cboMarca.DisplayMember = "Nombre"
                cboMarca.ValueMember = "ID_Marca"
                cboMarca.SelectedIndex = -1
            Else
                MsgBox("No se encontraron marcas.", vbInformation, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar las marcas: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub cboMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMarca.SelectedIndexChanged
        If cboMarca.SelectedValue IsNot Nothing AndAlso IsNumeric(cboMarca.SelectedValue) Then
            Dim marcaID As Integer = CInt(cboMarca.SelectedValue)
            CargarGrilla(marcaID)
        Else
            CargarGrilla()
        End If
    End Sub
#End Region


End Class