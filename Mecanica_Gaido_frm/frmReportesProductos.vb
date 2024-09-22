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
        Cargar_Combo_Persona()
        CargarGrilla()
        Limpiar()
    End Sub

    Public Sub Limpiar()
        cboPersona.SelectedIndex = 0
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
    End Sub
#End Region

#Region "Grilla"
    Private Sub CargarGrilla()
        Dim dsRepuestos As DataSet = o_reportes.ObtenerRepuestos()

        ' Obtener el DataTable con los repuestos (primer resultado)
        Dim dtRepuestos As DataTable = dsRepuestos.Tables(0)

        ' Limpiar la grilla antes de cargar nuevos datos
        grdRepuestos.Rows.Clear()

        ' Cargar los repuestos en la grilla
        For Each row As DataRow In dtRepuestos.Rows
            Dim fila As DataGridViewRow = CType(grdRepuestos.Rows(grdRepuestos.Rows.Add()), DataGridViewRow)
            fila.Cells("CodFabricante").Value = row("N° Repuesto")
            fila.Cells("Descripcion").Value = row("Descripcion")
            fila.Cells("StockReal").Value = row("Cantidad")
            fila.Cells("PrecioLista").Value = row("Precio Unitario")
            fila.Cells("Total").Value = row("Total")
        Next

        ' Obtener el segundo resultado: el valor total (segunda tabla)
        Dim dtSumaTotal As DataTable = dsRepuestos.Tables(1)
        If dtSumaTotal.Rows.Count > 0 Then
            Dim sumaTotal As Decimal = Convert.ToDecimal(dtSumaTotal.Rows(0)("SumaTotal"))
            ' Asignar el valor de la suma total a un TextBox o Label
            txtTotal.Text = sumaTotal.ToString("N2")
        End If
    End Sub
#End Region

#Region "Carga cbo"
    Private Sub Cargar_Combo_Persona()
        Try
            Dim tabla As DataTable = o_reportes.Cargar_Combo_Personas()

            If tabla.Rows.Count > 0 Then
                cboPersona.DataSource = tabla
                cboPersona.DisplayMember = "Persona"
                cboPersona.ValueMember = "ID_Persona"
                cboPersona.SelectedValue = -1
            Else
                MsgBox("No se encontraron Personas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las personas: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

End Class