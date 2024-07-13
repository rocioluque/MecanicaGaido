Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Public Class frmModificarRoles
    Dim o_roles As New AD_Roles
#Region "Procedimientos"
    Private Sub frmPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        Cargar_Grilla()
    End Sub

    Public Sub limpiar()
        txtId.Text = Nothing
        txtRol.Text = Nothing
        chkEstado.Checked = False
    End Sub

    Public Sub Cargar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_Grilla_Roles")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            grdModificarRol.AutoGenerateColumns = True
            grdModificarRol.DataSource = oDs.Tables(0)
            grdModificarRol.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Public Sub CargarDatosEnTextBoxes(ByVal rowIndex As Integer)
        If grdModificarRol.Rows.Count > 0 Then
            txtId.Text = Convert.ToInt32(grdModificarRol.Rows(rowIndex).Cells("N° Rol").Value)
            txtRol.Text = grdModificarRol.Rows(rowIndex).Cells("Rol").Value.ToString()
            chkEstado.Checked = Convert.ToBoolean(grdModificarRol.Rows(rowIndex).Cells("¿Está activo?").Value)
        End If
    End Sub

    Private Sub grdModificarRol_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdModificarRol.CellClick
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
            Dim RolID As Integer = Convert.ToInt32(txtId.Text)
            Dim nombreRol As String = txtRol.Text
            Dim estado As Boolean = chkEstado.Checked

            o_roles.Modificar_Rubro(RolID, nombreRol, estado)
            MsgBox("Rol modificado correctamente.", vbInformation, "Éxito")
            limpiar()
            Cargar_Grilla()
        Catch ex As Exception
            MsgBox("Error al modificar el rol: " & ex.Message, vbCritical, "Error")
            limpiar()
        End Try
    End Sub
#End Region
End Class