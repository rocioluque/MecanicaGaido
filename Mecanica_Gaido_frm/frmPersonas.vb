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
        txtID.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtTelefonoMovil.Clear()
        txtTelefonoFijo.Clear()
        txtNumeroDocumento.Clear()
        txtCorreo.Clear()
        txtDireccion.Clear()
        txtNumero.Clear()
        txtPiso.Clear()
        txtLetraPuerta.Clear()
        txtCodigoPostal.Clear()
        txtNota.Clear()
        dtpFechaNacimiento.Value = DateTime.Today
        cboTipoPersona.SelectedIndex = -1
        cboProvincia.SelectedIndex = -1
        cboCiudad.SelectedIndex = -1
        cboTipoDocumento.SelectedIndex = -1
        chkEstado.Checked = False
    End Sub

    Private Sub frmPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        Cargar_Provincias()
        Cargar_Combo_TipoDocumento()
        Cargar_Combo_TipoPersona()
        Cargar_Grilla()


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
        Try
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

                ' Verificar si las columnas existen antes de ocultarlas
                Dim columnasParaOcultar As String() = {"ID_Provincia", "ID_Ciudad", "ID_TipoPersona", "ID_TipoDocumento", "Direccion",
                                                        "Numero", "Piso", "Letra/Puerta", "Codigo_Postal", "Nota", "Estado"}
                For Each colName As String In columnasParaOcultar
                    If grdPersonas.Columns.Contains(colName) Then
                        grdPersonas.Columns(colName).Visible = False
                    End If
                Next
                grdPersonas.Refresh()
            Else
                MsgBox("No se encontraron datos para mostrar.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al cargar la grilla: " & ex.Message, vbCritical, "Error")
        Finally
        End Try
    End Sub

    Public Sub CargarDatosEnTxt(ByVal rowindex As Integer)
        If grdPersonas.Rows.Count > 0 AndAlso rowindex >= 0 AndAlso rowindex < grdPersonas.Rows.Count Then

            txtID.Text = grdPersonas.Rows(rowindex).Cells("N° Persona").Value.ToString()
            txtNombre.Text = grdPersonas.Rows(rowindex).Cells("Nombre / Razon Social").Value.ToString()
            txtApellido.Text = grdPersonas.Rows(rowindex).Cells("Apellido").Value.ToString()
            txtNumeroDocumento.Text = grdPersonas.Rows(rowindex).Cells("Documento").Value.ToString()
            txtTelefonoMovil.Text = grdPersonas.Rows(rowindex).Cells("Teléfono Móvil").Value.ToString()
            txtTelefonoFijo.Text = grdPersonas.Rows(rowindex).Cells("Teléfono Fijo").Value.ToString()
            txtCorreo.Text = grdPersonas.Rows(rowindex).Cells("Correo").Value.ToString()


            cboCiudad.SelectedValue = grdPersonas.Rows(rowindex).Cells("ID_Ciudad").Value
            cboTipoPersona.SelectedValue = grdPersonas.Rows(rowindex).Cells("ID_TipoPersona").Value
            cboTipoDocumento.SelectedValue = grdPersonas.Rows(rowindex).Cells("ID_TipoDocumento").Value
            txtDireccion.Text = grdPersonas.Rows(rowindex).Cells("Direccion").Value.ToString()
            txtNumero.Text = grdPersonas.Rows(rowindex).Cells("Numero").Value.ToString()
            txtPiso.Text = grdPersonas.Rows(rowindex).Cells("Piso").Value.ToString()
            txtLetraPuerta.Text = grdPersonas.Rows(rowindex).Cells("Letra/Puerta").Value.ToString()
            txtCodigoPostal.Text = grdPersonas.Rows(rowindex).Cells("Codigo_Postal").Value.ToString()
            txtNota.Text = grdPersonas.Rows(rowindex).Cells("Nota").Value.ToString()
            chkEstado.Checked = grdPersonas.Rows(rowindex).Cells("Estado").Value.ToString()

        End If
    End Sub

    Private Sub grdPersonas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdPersonas.CellClick
        If e.RowIndex >= 0 Then
            CargarDatosEnTxt(e.RowIndex)
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
        frmAgregarCuentas.lblNombreResultado.Text = txtApellido.Text & " " & txtNombre.Text
        frmAgregarCuentas.lblDocumentoResultado.Text = txtNumeroDocumento.Text
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

#Region "Keypress"
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
End Class