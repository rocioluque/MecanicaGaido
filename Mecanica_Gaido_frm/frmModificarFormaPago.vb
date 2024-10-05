Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient

Public Class frmModificarFormaPago
    Dim o_FormasDePago As New AD_FormasDePago

#Region "Procedimientos"
    Private Sub frmModificarFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        Cargar_Grilla()
    End Sub

    Public Sub limpiar()
        txtIdFP.Clear()
        txtIdDetalleFP.Clear()
        txtFormaDePago.Clear()
        txtNombreDetalle.Clear()
        txtPorcentaje.Clear()
        chkEstadoFP.Checked = False
        chkEstadoDetalleFP.Checked = False
        rbtRecargo.Checked = False
        rbtDescuento.Checked = False
        grdDetalleFP.DataSource = Nothing
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Me.Close()
    End Sub
#End Region

#Region "Grilla y datos en txt Forma Pago"
    Public Sub Cargar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_Grilla_FormasDePago")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            grdModificarFP.AutoGenerateColumns = True
            grdModificarFP.DataSource = oDs.Tables(0)
            grdModificarFP.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Public Sub CargarDatosEnTextBoxes(ByVal rowIndex As Integer)
        If grdModificarFP.Rows.Count > 0 Then
            Dim idFormaPago As Integer = Convert.ToInt32(grdModificarFP.Rows(rowIndex).Cells("N° Forma de Pago").Value)

            txtIdFP.Text = idFormaPago
            txtFormaDePago.Text = grdModificarFP.Rows(rowIndex).Cells("Forma de Pago").Value.ToString()
            chkEstadoFP.Checked = Convert.ToBoolean(grdModificarFP.Rows(rowIndex).Cells("¿Está activo?").Value)

            Cargar_Grilla_Detalle_FormaPago(idFormaPago)
        End If
    End Sub

    Private Sub grdModificarFP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdModificarFP.CellClick
        If e.RowIndex >= 0 Then
            CargarDatosEnTextBoxes(e.RowIndex)
        End If
    End Sub
#End Region

#Region "Grilla Detalle FP"
    Public Sub Cargar_Grilla_Detalle_FormaPago(idFormaPago As Integer)
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = "Cargar_Grilla_Detalle_FormaPago"
        comando.Parameters.AddWithValue("@ID_FormaPago", idFormaPago)

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            grdDetalleFP.AutoGenerateColumns = True
            grdDetalleFP.DataSource = oDs.Tables(0)
            grdDetalleFP.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Public Sub CargarDatosEnTextBoxesDetalle(ByVal rowIndex As Integer)
        If grdDetalleFP.Rows.Count > 0 Then
            txtIdDetalleFP.Text = Convert.ToInt32(grdDetalleFP.Rows(rowIndex).Cells("N° Detalle").Value)
            txtNombreDetalle.Text = grdDetalleFP.Rows(rowIndex).Cells("Nombre").Value.ToString()
            rbtRecargo.Checked = grdDetalleFP.Rows(rowIndex).Cells("Recargo").Value
            rbtDescuento.Checked = grdDetalleFP.Rows(rowIndex).Cells("Descuento").Value
            txtPorcentaje.Text = grdDetalleFP.Rows(rowIndex).Cells("Porcentaje").Value.ToString()
            chkEstadoDetalleFP.Checked = Convert.ToBoolean(grdDetalleFP.Rows(rowIndex).Cells("¿Está activo?").Value)
        End If
    End Sub

    Private Sub grdDetalleFP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdDetalleFP.CellClick
        If e.RowIndex >= 0 Then
            CargarDatosEnTextBoxesDetalle(e.RowIndex)
        End If
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If txtIdFP.Text <> Nothing Then
                o_FormasDePago.Modificar_FormasDePago(txtIdFP.Text, txtFormaDePago.Text, chkEstadoFP.Checked)

                If txtIdDetalleFP.Text <> Nothing And txtNombreDetalle.Text <> Nothing Then
                    o_FormasDePago.Modificar_DetalleFormaPago(txtIdDetalleFP.Text, txtNombreDetalle.Text,
                                                          rbtRecargo.Checked, rbtDescuento.Checked, txtPorcentaje.Text, chkEstadoDetalleFP.Checked)
                End If

                MsgBox("Forma de pago y detalles modificados correctamente.", vbInformation, "Éxito")
                Cargar_Grilla()
                limpiar()
            End If

        Catch ex As Exception
            MsgBox("Error al modificar la forma de pago y detalles: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region
End Class