Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmPersonas
    Dim o_Personas As New AD_Personas

#Region "Cargar Prov y ciudades"
    Private Sub Cargar_Provincias()
        Try
            Dim tabla As DataTable = o_Personas.Cargar_Provincias()

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

    Private Sub Cargar_Ciudades(ID_Provincia As String)
        Try
            Dim tabla As DataTable = o_Personas.Cargar_Ciudades_Por_Provincia(ID_Provincia)

            If tabla.Rows.Count > 0 Then
                cboCiudad.DataSource = tabla
                cboCiudad.DisplayMember = "Ciudad"
                cboCiudad.ValueMember = "ID_Ciudad"
            Else
                MsgBox("No se encontraron ciudades para la provincia seleccionada.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las ciudades: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedIndexChanged
        Try
            If cboProvincia.SelectedValue IsNot Nothing Then
                Dim idProvincia As Integer
                If TypeOf cboProvincia.SelectedValue Is DataRowView Then
                    idProvincia = Convert.ToInt32(DirectCast(cboProvincia.SelectedValue, DataRowView)("ID_Provincia"))
                Else
                    idProvincia = Convert.ToInt32(cboProvincia.SelectedValue)
                End If
                Cargar_Ciudades(idProvincia)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar ciudades: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Procedimientos"
    Private Sub frmPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Grilla()
        Cargar_Provincias()
        limpiar()
    End Sub

    Public Sub limpiar()
        txtApellido.Text = Nothing
        txtNombre.Text = Nothing
        txtCorreo.Text = Nothing
        txtDireccion.Text = Nothing
        txtID.Text = Nothing
        txtNota.Text = Nothing
        txtTelefono.Text = Nothing
        cboCiudad.SelectedIndex = -1
        cboProvincia.SelectedIndex = -1

    End Sub

    Public Sub Cargar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_Grilla")

        Dim datadapter As New SqlDataAdapter(comando)
        Dim oDs As New DataSet
        datadapter.Fill(oDs)

        If oDs.Tables(0).Rows.Count > 0 Then
            grdPersonas.AutoGenerateColumns = True
            grdPersonas.DataSource = oDs.Tables(0)
            grdPersonas.Refresh()
        End If

        oDs = Nothing
        conexion.Close()
    End Sub

    Public Sub CargarDatosEnTextBoxes(ByVal rowIndex As Integer)
        If grdPersonas.Rows.Count > 0 Then
            txtID.Text = grdPersonas.Rows(rowIndex).Cells("N° Persona").Value.ToString()
            txtNombre.Text = grdPersonas.Rows(rowIndex).Cells("Nombre").Value.ToString()
            txtApellido.Text = grdPersonas.Rows(rowIndex).Cells("Apellido").Value.ToString()
            txtTelefono.Text = grdPersonas.Rows(rowIndex).Cells("Telefono").Value.ToString()
            txtCorreo.Text = grdPersonas.Rows(rowIndex).Cells("Correo").Value.ToString()
            txtDireccion.Text = grdPersonas.Rows(rowIndex).Cells("Direccion").Value.ToString()
            txtNota.Text = grdPersonas.Rows(rowIndex).Cells("Nota").Value.ToString()
            chkEstado.Checked = grdPersonas.Rows(rowIndex).Cells("Estado").Value.ToString()

            ' Buscar y seleccionar la provincia en el ComboBox
            Dim provincia As String = grdPersonas.Rows(rowIndex).Cells("Provincia").Value.ToString()
            For Each item As DataRowView In cboProvincia.Items
                If item("Nombre").ToString() = provincia Then
                    cboProvincia.SelectedValue = item("ID_Provincia")
                    Exit For
                End If
            Next

            ' Cargar y seleccionar la ciudad en el ComboBox basado en la provincia seleccionada
            If cboProvincia.SelectedValue IsNot Nothing AndAlso IsNumeric(cboProvincia.SelectedValue) Then
                Dim idProvincia As Integer = Convert.ToInt32(cboProvincia.SelectedValue)
                Cargar_Ciudades(idProvincia)
                Dim ciudad As String = grdPersonas.Rows(rowIndex).Cells("Ciudad").Value.ToString()
                For Each item As DataRowView In cboCiudad.Items
                    If item("Ciudad").ToString() = ciudad Then
                        cboCiudad.SelectedValue = item("ID_Ciudad")
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub grdPersonas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdPersonas.CellClick
        If e.RowIndex >= 0 Then
            CargarDatosEnTextBoxes(e.RowIndex)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
#End Region

#Region "Abrir frm para agregar datos"
    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        frmAgregarEmpleados.ShowDialog()
    End Sub

    Private Sub btnCtasCtes_Click(sender As Object, e As EventArgs) Handles btnCuentas.Click
        frmAgregarCuentas.ShowDialog()
    End Sub

    Private Sub btnAgregarCiudad_Click(sender As Object, e As EventArgs) Handles btnAgregarCiudad.Click
        frmAgregarCiudad.ShowDialog()
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtNombre.Text <> Nothing And txtApellido.Text <> Nothing And txtTelefono.Text <> Nothing And txtCorreo.Text <> Nothing And
            txtDireccion.Text <> Nothing And cboCiudad.SelectedValue Then

            Try
                Dim nombre As String = txtNombre.Text
                Dim apellido As String = txtApellido.Text
                Dim telefono As String = txtTelefono.Text
                Dim correo As String = txtCorreo.Text
                Dim direccion As String = txtDireccion.Text
                Dim idCiudad As Integer = Convert.ToInt32(cboCiudad.SelectedValue)
                Dim nota As String = txtNota.Text
                Dim estado As Boolean = chkEstado.Checked

                o_Personas.Agregar_Persona(nombre, apellido, telefono, correo, direccion, idCiudad, nota, estado)
                MsgBox("Persona agregada correctamente.", vbInformation, "Información")
                limpiar()

                Cargar_Grilla()
            Catch ex As Exception
                MsgBox("Error al agregar la persona: " & ex.Message, vbCritical, "Error")
                limpiar()
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
            limpiar()
        End If
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtID.Text <> Nothing And txtNombre.Text <> Nothing And txtApellido.Text <> Nothing And txtTelefono.Text <> Nothing And txtCorreo.Text <> Nothing And
            txtDireccion.Text <> Nothing And cboCiudad.SelectedValue Then
            Try
                Dim idPersona As Integer = Convert.ToInt32(txtID.Text)
                Dim nombre As String = txtNombre.Text
                Dim apellido As String = txtApellido.Text
                Dim telefono As String = txtTelefono.Text
                Dim correo As String = txtCorreo.Text
                Dim direccion As String = txtDireccion.Text
                Dim idCiudad As Integer = Convert.ToInt32(cboCiudad.SelectedValue)
                Dim nota As String = txtNota.Text
                Dim estado As Boolean = chkEstado.Checked

                o_Personas.Modificar_Persona(idPersona, nombre, apellido, telefono, correo, direccion, idCiudad, nota, estado)
                MsgBox("Persona modificada correctamente.", vbInformation, "Información")
                limpiar()


                Cargar_Grilla()
            Catch ex As Exception
                MsgBox("Error al modificar la persona: " & ex.Message, vbCritical, "Error")
                limpiar()
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
            limpiar()
        End If
    End Sub
#End Region


End Class