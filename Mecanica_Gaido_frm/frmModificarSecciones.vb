Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient

Public Class frmModificarSecciones
    Dim o_secciones As New AD_Secciones

#Region "Procedimientos"
    Private Sub frmModificarSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        Cargar_Grilla()
    End Sub

    Public Sub limpiar()
        txtId.Clear()
        txtSeccion.Clear()
        chkEstado.Checked = False
    End Sub

    Public Sub Cargar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_Grilla_Secciones")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            grdModificarSeccion.AutoGenerateColumns = True
            grdModificarSeccion.DataSource = oDs.Tables(0)
            grdModificarSeccion.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Public Sub CargarDatosEnTextBoxes(ByVal rowIndex As Integer)
        If grdModificarSeccion.Rows.Count > 0 Then
            txtId.Text = Convert.ToInt32(grdModificarSeccion.Rows(rowIndex).Cells("N° Sección").Value)
            txtSeccion.Text = grdModificarSeccion.Rows(rowIndex).Cells("Sección").Value.ToString()
            chkEstado.Checked = Convert.ToBoolean(grdModificarSeccion.Rows(rowIndex).Cells("¿Está activa?").Value)
        End If
    End Sub

    Private Sub grdModificarSeccion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdModificarSeccion.CellClick
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
            o_secciones.Modificar_Seccion(Convert.ToInt32(txtId.Text), txtSeccion.Text, chkEstado.Checked)
            MsgBox("Sección modificada correctamente.", vbInformation, "Éxito")
            limpiar()
            Cargar_Grilla()
        Catch ex As Exception
            MsgBox("Error al modificar la sección: " & ex.Message, vbCritical, "Error")
            limpiar()
        End Try
    End Sub
#End Region
End Class