Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Public Class frmModificarTipoVehiculos
    Dim o_vehiculo As New AD_Vehiculos

#Region "Procedimientos"
    Private Sub frmModificarTipoVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        Cargar_Grilla()
    End Sub

    Public Sub limpiar()
        txtId.Clear()
        txtTipoVehiculo.Clear()
        chkEstado.Checked = False
    End Sub

    Public Sub Cargar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_Grilla_TipoVehiculo")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            grdModificarTipoVehiculo.AutoGenerateColumns = True
            grdModificarTipoVehiculo.DataSource = oDs.Tables(0)
            grdModificarTipoVehiculo.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Public Sub CargarDatosEnTextBoxes(ByVal rowIndex As Integer)
        If grdModificarTipoVehiculo.Rows.Count > 0 Then
            txtId.Text = Convert.ToInt32(grdModificarTipoVehiculo.Rows(rowIndex).Cells("N° Tipo de Vehículo").Value)
            txtTipoVehiculo.Text = grdModificarTipoVehiculo.Rows(rowIndex).Cells("Tipo de Vehículo").Value.ToString()
            chkEstado.Checked = Convert.ToBoolean(grdModificarTipoVehiculo.Rows(rowIndex).Cells("¿Está activo?").Value)
        End If
    End Sub

    Private Sub grdModificarTipoVehiculo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdModificarTipoVehiculo.CellClick
        If e.RowIndex >= 0 Then
            CargarDatosEnTextBoxes(e.RowIndex)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            o_vehiculo.Modificar_TipoVehiculo(Convert.ToInt32(txtId.Text), txtTipoVehiculo.Text, chkEstado.Checked)
            MsgBox("Tipo de Vehiculo modificado correctamente.", vbInformation, "Éxito")
            limpiar()
            Cargar_Grilla()
        Catch ex As Exception
            MsgBox("Error al modificar el tipo de vehiculo: " & ex.Message, vbCritical, "Error")
            limpiar()
        End Try
    End Sub

#End Region
End Class