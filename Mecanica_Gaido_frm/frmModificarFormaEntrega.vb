Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Public Class frmModificarFormaEntrega
    Dim o_entrega As New AD_FormaEntrega

#Region "Procedimientos"
    Private Sub frmModificarFormaEntrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        Cargar_Grilla()
    End Sub

    Public Sub limpiar()
        txtId.Text = Nothing
        txtFormaEntrega.Text = Nothing
        chkEstado.Checked = False
    End Sub

    Public Sub Cargar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_Grilla_FormaEntrega")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            grdModificarFormaEntrega.AutoGenerateColumns = True
            grdModificarFormaEntrega.DataSource = oDs.Tables(0)
            grdModificarFormaEntrega.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Public Sub CargarDatosEnTextBoxes(ByVal rowIndex As Integer)
        If grdModificarFormaEntrega.Rows.Count > 0 Then
            txtId.Text = Convert.ToInt32(grdModificarFormaEntrega.Rows(rowIndex).Cells("N° Forma de Entrega").Value)
            txtFormaEntrega.Text = grdModificarFormaEntrega.Rows(rowIndex).Cells("Forma de Entrega").Value.ToString()
            chkEstado.Checked = Convert.ToBoolean(grdModificarFormaEntrega.Rows(rowIndex).Cells("¿Está activa?").Value)
        End If
    End Sub

    Private Sub grdModificarFormaEntrega_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdModificarFormaEntrega.CellClick
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
            Dim FormaEntregaID As Integer = Convert.ToInt32(txtId.Text)
            Dim nombreFormaEntrega As String = txtFormaEntrega.Text
            Dim estado As Boolean = chkEstado.Checked

            o_entrega.Modificar_FormaEntrega(FormaEntregaID, nombreFormaEntrega, estado)
            MsgBox("Forma de Entrega modificada correctamente.", vbInformation, "Éxito")
            limpiar()
            Cargar_Grilla()
        Catch ex As Exception
            MsgBox("Error al modificar la forma de entrega: " & ex.Message, vbCritical, "Error")
            limpiar()
        End Try
    End Sub
#End Region
End Class