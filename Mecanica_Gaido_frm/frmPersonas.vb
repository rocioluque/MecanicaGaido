Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmPersonas
    Dim o_Personas As New AD_Personas

#Region "Carga de Cbos"
    Private Sub Cargar_Provincias()
        Try
            Dim tabla As DataTable = o_Personas.Cargar_Provincias()

            If tabla.Rows.Count > 0 Then
                cboProvincia.DataSource = tabla
                cboProvincia.DisplayMember = "Nombre"
                cboProvincia.ValueMember = "ID_Provincia"
                cboProvincia.SelectedIndex = -1
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
                cboCiudad.SelectedIndex = -1
            Else
                MsgBox("No se encontraron ciudades para la provincia seleccionada.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las ciudades: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedIndexChanged
        Try
            If cboProvincia.SelectedValue IsNot Nothing AndAlso IsNumeric(cboProvincia.SelectedValue) Then
                Dim idProvincia As Integer = Convert.ToInt32(cboProvincia.SelectedValue)
                Cargar_Ciudades(idProvincia)
            End If
        Catch ex As Exception
            MsgBox("Error al cargar ciudades: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_TipoDocumento()
        Try
            Dim tabla As DataTable = o_Personas.Cargar_Combo_TipoDocumento

            If tabla.Rows.Count > 0 Then
                cboTipoDocumento.DataSource = tabla
                cboTipoDocumento.DisplayMember = "Tipo"
                cboTipoDocumento.ValueMember = "ID_TipoDocumento"
                cboTipoDocumento.SelectedIndex = -1
            Else
                MsgBox("No se encontraron tipos de documento.", vbInformation, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los tipos de documento: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_TipoPersona()
        Try
            Dim tabla As DataTable = o_Personas.Cargar_Combo_TipoPersona

            If tabla.Rows.Count > 0 Then
                cboTipoPersona.DataSource = tabla
                cboTipoPersona.DisplayMember = "Nombre"
                cboTipoPersona.ValueMember = "ID_TipoPersona"
                cboTipoPersona.SelectedIndex = -1
            Else
                MsgBox("No se encontraron tipos de persona.", vbInformation, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los tipos de persona: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Procedimientos"
    Public Sub Limpiar()
        txtID.Text = Nothing
        cboTipoPersona.SelectedIndex = -1
        txtNombre.Text = Nothing
        txtApellido.Text = Nothing
        txtTelefonoMovil.Text = Nothing
        txtTelefonoFijo.Text = Nothing
        dtpFechaNacimiento.Value = DateTime.Today
        cboTipoDocumento.SelectedIndex = -1
        txtNumeroDocumento.Text = Nothing
        txtCorreo.Text = Nothing
        txtDireccion.Text = Nothing
        txtNumero.Text = Nothing
        txtPiso.Text = Nothing
        txtLetraPuerta.Text = Nothing
        txtCodigoPostal.Text = Nothing
        cboProvincia.SelectedIndex = -1
        cboCiudad.SelectedIndex = -1
        txtNota.Text = Nothing
        chkEstado.Checked = False
    End Sub

    Private Sub frmPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        Cargar_Grilla()
        Cargar_Provincias()
        Cargar_Combo_TipoDocumento()
        Cargar_Combo_TipoPersona()


        ' Configuración del estilo de la grilla
        Dim cellStyle As New DataGridViewCellStyle()
        cellStyle.BackColor = Color.FromArgb(65, 65, 65)
        cellStyle.ForeColor = Color.White
        cellStyle.SelectionBackColor = Color.SeaGreen
        cellStyle.SelectionForeColor = SystemColors.HighlightText
        cellStyle.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular, GraphicsUnit.Point, 0)
        cellStyle.WrapMode = DataGridViewTriState.True

        grdPersonas.DefaultCellStyle = cellStyle

        ' Configuración del estilo del encabezado
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.BackColor = Color.SeaGreen
        headerStyle.ForeColor = Color.White
        headerStyle.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular, GraphicsUnit.Point, 0)
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        grdPersonas.ColumnHeadersDefaultCellStyle = headerStyle

    End Sub

    Public Sub Cargar_Grilla()
        Dim conexion As SqlConnection
        Dim comando As New SqlCommand

        conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.StoredProcedure
        comando.CommandText = ("Cargar_Grilla_Persona")

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
            txtNombre.Text = grdPersonas.Rows(rowIndex).Cells("Nombre/RazonSocial").Value.ToString()
            txtApellido.Text = grdPersonas.Rows(rowIndex).Cells("Apellido").Value.ToString()
            txtTelefonoMovil.Text = grdPersonas.Rows(rowIndex).Cells("Telefono_Movil").Value.ToString()
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
        Limpiar()
    End Sub
#End Region

#Region "Abrir frm para agregar datos"
    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        frmAgregarEmpleados.txt_ID_Persona.Text = txtID.Text
        frmAgregarEmpleados.lblCargaEmpleado.Text = txtApellido.Text & " " & txtNombre.Text

        frmAgregarEmpleados.ShowDialog()
    End Sub

    Private Sub btnCtasCtes_Click(sender As Object, e As EventArgs) Handles btnCuentas.Click
        frmAgregarCuentas.txtEmpresa.Text = txtApellido.Text & " " & txtNombre.Text
        frmAgregarCuentas.ShowDialog()
    End Sub

    Private Sub btnAgregarCiudad_Click(sender As Object, e As EventArgs)
        If cboCiudad.SelectedValue <> Nothing And cboProvincia.SelectedValue <> Nothing Then
            Dim frm As New frmAgregarCiudad()

            ' Pasar la ciudad y provincia seleccionada
            frm.CiudadID = Convert.ToInt32(cboCiudad.SelectedValue)
            frm.CiudadNombre = cboCiudad.Text
            frm.ProvinciaSeleccionada = Convert.ToInt32(cboProvincia.SelectedValue)
            frm.CiudadEstado = grdPersonas.CurrentRow.Cells("Estado").Value
            frm.EsModificacion = True

            If frm.ShowDialog() = DialogResult.OK Then
                ' Recargar las ciudades
                If cboProvincia.SelectedValue IsNot Nothing Then
                    Dim idProvincia As Integer
                    If TypeOf cboProvincia.SelectedValue Is DataRowView Then
                        idProvincia = Convert.ToInt32(DirectCast(cboProvincia.SelectedValue, DataRowView)("ID_Provincia"))
                    Else
                        idProvincia = Convert.ToInt32(cboProvincia.SelectedValue)
                    End If
                    Cargar_Ciudades(idProvincia)
                End If
            End If
        Else
            MsgBox("Seleccione una provincia para agregar y/o modificar ciudades.", vbInformation, "Información")
        End If
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtNombre.Text <> Nothing And txtNumeroDocumento.Text <> Nothing And
            txtCorreo.Text <> Nothing And txtDireccion.Text <> Nothing And txtNumero.Text <> Nothing And
            txtCodigoPostal.Text <> Nothing Then

            Try
                o_Personas.Agregar_Persona(CInt(cboTipoPersona.SelectedValue), txtNombre.Text, txtApellido.Text, txtTelefonoMovil.Text,
                       txtTelefonoFijo.Text, dtpFechaNacimiento.Value, CInt(cboTipoDocumento.SelectedValue), txtNumeroDocumento.Text,
                       txtCorreo.Text, txtDireccion.Text, txtNumero.Text, txtPiso.Text, txtLetraPuerta.Text, txtCodigoPostal.Text,
                       Convert.ToInt32(cboCiudad.SelectedValue), txtNota.Text, chkEstado.Checked)

                MsgBox("Persona agregada correctamente.", vbInformation, "Información")
                Limpiar()

                Cargar_Grilla()
            Catch ex As Exception
                MsgBox("Error al agregar la persona: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete los datos correspondientes.", vbInformation, "Error")
        End If
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtID.Text <> Nothing And txtNombre.Text <> Nothing And txtCorreo.Text <> Nothing And txtDireccion.Text <> Nothing Then
            Try
                o_Personas.Modificar_Persona(txtID.Text, CInt(cboTipoPersona.SelectedValue), txtNombre.Text, txtApellido.Text, txtTelefonoMovil.Text,
                       txtTelefonoFijo.Text, dtpFechaNacimiento.Value, CInt(cboTipoDocumento.SelectedValue), txtNumeroDocumento.Text,
                       txtCorreo.Text, txtDireccion.Text, txtNumero.Text, txtPiso.Text, txtLetraPuerta.Text, txtCodigoPostal.Text,
                       Convert.ToInt32(cboCiudad.SelectedValue), txtNota.Text, chkEstado.Checked)
                MsgBox("Persona modificada correctamente.", vbInformation, "Información")
                Limpiar()
                Cargar_Grilla()

            Catch ex As Exception
                MsgBox("Error al modificar la persona: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) _
           AndAlso Not Char.IsControl(e.KeyChar) _
           AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) _
         AndAlso Not Char.IsControl(e.KeyChar) _
         AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub


    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

    End Sub
#End Region

#Region "Css trucho"
    Private Sub PanelDatosPersonales_Paint(sender As Object, e As PaintEventArgs) Handles PanelDatosPersonales.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelDatosPersonales.Width - 1, PanelDatosPersonales.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub


    Private Sub PanelDirecciones_Paint(sender As Object, e As PaintEventArgs) Handles PanelDirecciones.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelDirecciones.Width - 1, PanelDirecciones.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelNotas_Paint(sender As Object, e As PaintEventArgs) Handles PanelNotas.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelNotas.Width - 1, PanelNotas.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub
#End Region
End Class