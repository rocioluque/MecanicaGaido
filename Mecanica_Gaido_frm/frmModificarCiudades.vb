Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Public Class frmModificarCiudades
    Dim o_Ciudad As New AD_Ciudades

#Region "Procedimientos"
    Private Sub frmPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()

        ' Cargar provincias al inicializar el formulario
        Cargar_Provincias()
        ' Cargar la grilla con un valor por defecto (opcional)
        If cboProvincia.SelectedIndex <> -1 Then
            Dim idProvincia As Integer = CInt(cboProvincia.SelectedValue)
            Cargar_Grilla(idProvincia)
        End If

        If txtCiudad.Text = Nothing Then
            chkEstado.Visible = False
        Else
            chkEstado.Visible = True
        End If

        AplicarTema(Me)
    End Sub

    Public Sub limpiar()
        txtId.Clear()
        txtCiudad.Clear()
        cboProvincia.SelectedIndex = -1
        chkEstado.Checked = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
#End Region

#Region "Cargar Combo"
    Private Sub Cargar_Provincias()
        Try
            Dim tabla As DataTable = o_Ciudad.Cargar_Provincias()

            If tabla.Rows.Count > 0 Then
                cboProvincia.DataSource = tabla
                cboProvincia.DisplayMember = "Nombre"
                cboProvincia.ValueMember = "ID_Provincia"
            Else
                MsgBox("No se encontraron provincias.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las provincias: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedIndexChanged
        If cboProvincia.SelectedIndex <> -1 Then
            Dim selectedValue As Object = cboProvincia.SelectedValue

            If TypeOf selectedValue Is DataRowView Then
                selectedValue = CType(selectedValue, DataRowView)("ID_Provincia")
            End If

            If TypeOf selectedValue Is Integer Then
                Dim idProvincia As Integer = CInt(selectedValue)
                Cargar_Grilla(idProvincia)
            End If
        End If
    End Sub
#End Region

#Region "Cargar Grilla"
    Public Sub Cargar_Grilla(idProvincia As Integer)
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_Grilla_Ciudad")
        comando.Parameters.AddWithValue("@ID_Provincia", idProvincia)

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            grdModificarCiudad.AutoGenerateColumns = True
            grdModificarCiudad.DataSource = oDs.Tables(0)
            grdModificarCiudad.Columns("ID_Provincia").Visible = False  ' Ocultar la columna de ID_Provincia
            grdModificarCiudad.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub
#End Region

#Region "Cargar Datos en txt"
    Public Sub CargarDatosEnTextBoxes(ByVal rowIndex As Integer)
        If grdModificarCiudad.Rows.Count > 0 Then
            txtId.Text = Convert.ToInt32(grdModificarCiudad.Rows(rowIndex).Cells("N° Ciudad").Value)
            txtCiudad.Text = grdModificarCiudad.Rows(rowIndex).Cells("Ciudad").Value.ToString()
            chkEstado.Checked = Convert.ToBoolean(grdModificarCiudad.Rows(rowIndex).Cells("¿Está activa?").Value)

            ' Obtener el ID de la provincia desde la celda correspondiente
            Dim idProvincia As Integer = Convert.ToInt32(grdModificarCiudad.Rows(rowIndex).Cells("ID_Provincia").Value)

            ' Seleccionar la provincia en el ComboBox
            cboProvincia.SelectedValue = idProvincia
        End If
    End Sub

    Private Sub grdModificarMarca_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdModificarCiudad.CellClick
        If e.RowIndex >= 0 Then
            CargarDatosEnTextBoxes(e.RowIndex)
        End If
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            o_Ciudad.Modificar_Ciudad(txtId.Text, txtCiudad.Text, CInt(cboProvincia.SelectedValue), chkEstado.Checked)
            MsgBox("Ciudad modificada correctamente.", vbInformation, "Éxito")
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al modificar la ciudad: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        If txtCiudad.Text = Nothing Then
            chkEstado.Visible = False
        Else
            chkEstado.Visible = True
        End If
    End Sub

    Private Sub txtCiudad_TextChanged(sender As Object, e As EventArgs) Handles txtCiudad.TextChanged
        If txtCiudad.Text = Nothing Then
            chkEstado.Visible = False
        Else
            chkEstado.Visible = True
        End If
    End Sub
#End Region

End Class