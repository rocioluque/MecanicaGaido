Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmModificarMarca
    Dim o_Marca As New AD_Marca

#Region "Procedimientos"
    Private Sub frmPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Grilla()
        limpiar()
        AplicarTema(Me)
    End Sub

    Public Sub limpiar()
        txtId.Clear()
        txtMarca.Clear()
        chkProducto.Checked = False
        chkVehiculo.Checked = False
        chkEstado.Checked = False
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
        comando.CommandText = ("Cargar_Grilla_Marca")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            grdModificarMarca.AutoGenerateColumns = True
            grdModificarMarca.DataSource = oDs.Tables(0)
            grdModificarMarca.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub
#End Region

#Region "Cargar datos en txt"
    Public Sub CargarDatosEnTextBoxes(ByVal rowIndex As Integer)
        If grdModificarMarca.Rows.Count > 0 Then
            txtId.Text = Convert.ToInt32(grdModificarMarca.Rows(rowIndex).Cells("N° Marca").Value)
            txtMarca.Text = grdModificarMarca.Rows(rowIndex).Cells("Marca").Value.ToString()
            chkProducto.Checked = Convert.ToBoolean(grdModificarMarca.Rows(rowIndex).Cells("¿Es de repuesto?").Value)
            chkVehiculo.Checked = Convert.ToBoolean(grdModificarMarca.Rows(rowIndex).Cells("¿Es de vehículo?").Value)
            chkEstado.Checked = Convert.ToBoolean(grdModificarMarca.Rows(rowIndex).Cells("¿Está activa?").Value)
        End If
    End Sub

    Private Sub grdModificarMarca_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdModificarMarca.CellClick
        If e.RowIndex >= 0 Then
            CargarDatosEnTextBoxes(e.RowIndex)
        End If
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtId.Text <> Nothing And txtMarca.Text <> Nothing Then
            Try
                o_Marca.Modificar_Marca(Convert.ToInt32(txtId.Text), txtMarca.Text, chkProducto.Checked, chkVehiculo.Checked, chkEstado.Checked)
                MsgBox("Marca modificada correctamente.", vbInformation, "Información")
                limpiar()
                Cargar_Grilla()

            Catch ex As Exception
                MsgBox("Error al modificar la marca: " & ex.Message, vbCritical, "Error")
                limpiar()
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
            limpiar()
        End If
    End Sub
#End Region
End Class