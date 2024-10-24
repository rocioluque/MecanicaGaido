﻿Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient

Public Class frmModificarTipoVenta
    Dim o_TiposDeVenta As New AD_TiposDeVenta

#Region "Procedimientos"
    Private Sub frmModificarTipoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        Cargar_Grilla()
        AplicarTema(Me)
    End Sub

    Public Sub limpiar()
        txtIdTipoDeVenta.Clear()
        txtIdTipoDeVenta.Clear()
        chkEstadoTV.Checked = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
#End Region

#Region "Cargar Grilla"
    Public Sub Cargar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_Grilla_TiposDeVenta")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            grdModificarTipoDeVenta.AutoGenerateColumns = True
            grdModificarTipoDeVenta.DataSource = oDs.Tables(0)
            grdModificarTipoDeVenta.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub
#End Region

#Region "Cargar datos en txt"
    Public Sub CargarDatosEnTextBoxes(ByVal rowIndex As Integer)
        If grdModificarTipoDeVenta.Rows.Count > 0 Then
            txtIdTipoDeVenta.Text = Convert.ToInt32(grdModificarTipoDeVenta.Rows(rowIndex).Cells("Codigo").Value)
            txtTipoDeVenta.Text = grdModificarTipoDeVenta.Rows(rowIndex).Cells("Tipo de Venta").Value.ToString()
            chkEstadoTV.Checked = Convert.ToBoolean(grdModificarTipoDeVenta.Rows(rowIndex).Cells("¿Está activo?").Value)
        End If
    End Sub

    Private Sub grdModificarTipoDeVenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdModificarTipoDeVenta.CellClick
        If e.RowIndex >= 0 Then
            CargarDatosEnTextBoxes(e.RowIndex)
        End If
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            o_TiposDeVenta.Modificar_TipoDeVenta(Convert.ToInt32(txtIdTipoDeVenta.Text), txtTipoDeVenta.Text, chkEstadoTV.Checked)
            MsgBox("Tipo de venta modificado correctamente.", vbInformation, "Éxito")
            limpiar()
            Cargar_Grilla()
        Catch ex As Exception
            MsgBox("Error al modificar el tipo de venta: " & ex.Message, vbCritical, "Error")
            limpiar()
        End Try
    End Sub
#End Region
End Class