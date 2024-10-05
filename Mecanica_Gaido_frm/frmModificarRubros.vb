Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Public Class frmModificarRubros
    Dim o_rubro As New AD_Rubros

#Region "Procedimientos"
    Private Sub frmPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        Cargar_Grilla()
    End Sub

    Public Sub limpiar()
        txtId.Clear()
        txtRubro.Clear()
        chkEstado.Checked = False
    End Sub

    Public Sub Cargar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_Grilla_Rubro")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            grdModificarRubros.AutoGenerateColumns = True
            grdModificarRubros.DataSource = oDs.Tables(0)
            grdModificarRubros.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Public Sub CargarDatosEnTextBoxes(ByVal rowIndex As Integer)
        If grdModificarRubros.Rows.Count > 0 Then
            txtId.Text = Convert.ToInt32(grdModificarRubros.Rows(rowIndex).Cells("N° Rubro").Value)
            txtRubro.Text = grdModificarRubros.Rows(rowIndex).Cells("Rubro").Value.ToString()
            chkEstado.Checked = Convert.ToBoolean(grdModificarRubros.Rows(rowIndex).Cells("¿Está activo?").Value)
        End If
    End Sub

    Private Sub grdModificarRubros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdModificarRubros.CellClick
        If e.RowIndex >= 0 Then
            CargarDatosEnTextBoxes(e.RowIndex)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Me.Close()
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            o_rubro.Modificar_Rubro(txtId.Text, txtRubro.Text, chkEstado.Checked)
            MsgBox("Rubro modificado correctamente.", vbInformation, "Éxito")
            Cargar_Grilla()
        Catch ex As Exception
            MsgBox("Error al modificar el rubro: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub grdModificarRubros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdModificarRubros.CellContentClick

    End Sub
#End Region
End Class