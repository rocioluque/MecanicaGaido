Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient


Public Class frmModificarFormaPago
    Dim o_FormasDePago As New AD_FormasDePago
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmModificarFormaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        Cargar_Grilla()
    End Sub

    Public Sub limpiar()
        txtIdFP.Text = Nothing
        txtFormaDePago.Text = Nothing
        chkEstadoFP.Checked = False
    End Sub

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
            txtIdFP.Text = Convert.ToInt32(grdModificarFP.Rows(rowIndex).Cells("Codigo").Value)
            txtFormaDePago.Text = grdModificarFP.Rows(rowIndex).Cells("Forma de Pago").Value.ToString()
            chkEstadoFP.Checked = Convert.ToBoolean(grdModificarFP.Rows(rowIndex).Cells("¿Está activo?").Value)
        End If
    End Sub

    Private Sub grdModificarFP_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdModificarFP.CellClick
        If e.RowIndex >= 0 Then
            CargarDatosEnTextBoxes(e.RowIndex)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim ID_FP As Integer = Convert.ToInt32(txtIdFP.Text)
            Dim nombreFP As String = txtFormaDePago.Text
            Dim estado As Boolean = chkEstadoFP.Checked

            o_FormasDePago.Modificar_FormasDePago(ID_FP, nombreFP, estado)
            MsgBox("Forma de pago modificada correctamente.", vbInformation, "Éxito")
            limpiar()
            Cargar_Grilla()
        Catch ex As Exception
            MsgBox("Error al modificar la forma de pago: " & ex.Message, vbCritical, "Error")
            limpiar()
        End Try
    End Sub


End Class