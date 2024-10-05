Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Data.Common
Imports Newtonsoft.Json.Linq
Imports System.Text

Public Class frmPersonas
    Dim o_Personas As New AD_Personas

    Dim EsRI As Boolean
    Dim EsMonotributo As Boolean
    Dim EsExento As Boolean
    Dim EsConsFinal As Boolean

    Public Property IdPersona As Integer
    Public Property NuevaPersonaNombre As String
    Public Property NuevaPersonaNombreCompra As String

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

        If cboProvincia.SelectedIndex <> -1 Then
            cboCiudad.Enabled = True
            btnAgregarCiudad.Enabled = True

        Else
            cboCiudad.Enabled = False
            btnAgregarCiudad.Enabled = False

        End If

        validacion()
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
        msktxtNumeroDocumento.Clear()
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
        validacion()
        Cargar_Provincias()
        Cargar_Combo_TipoDocumento()
        Cargar_Combo_TipoPersona()
        Cargar_Grilla()
        btnModificar.Enabled = False
        txtNombre.Enabled = True
        txtBuscar.Visible = False
        txtID.Enabled = False
        AplicarTema(Me)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        btnModificar.Enabled = False
        txtBuscar.Clear
        txtBuscar.Visible = False

    End Sub
#End Region

#Region "Grilla y datos en txt"
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

    Public Sub CargarDatosEnTxt(ByVal idPersona As Integer)
        Try
            Dim datoleido As SqlDataReader = o_Personas.Consultar_PersonaPorID(idPersona)

            If datoleido.Read() Then
                txtID.Text = datoleido("N° Persona").ToString()
                txtNombre.Text = datoleido("Nombre / Razon Social").ToString()
                txtApellido.Text = datoleido("Apellido").ToString()
                dtpFechaNacimiento.Value = Convert.ToDateTime(datoleido("Fecha_Nacimiento"))
                msktxtNumeroDocumento.Text = datoleido("Documento").ToString()
                txtTelefonoMovil.Text = datoleido("Teléfono Móvil").ToString()
                txtTelefonoFijo.Text = datoleido("Teléfono Fijo").ToString()
                txtCorreo.Text = datoleido("Correo").ToString()
                cboProvincia.SelectedValue = datoleido("ID_Provincia").ToString()
                cboCiudad.SelectedValue = datoleido("ID_Ciudad").ToString()
                cboTipoPersona.SelectedValue = datoleido("ID_TipoPersona").ToString()
                cboTipoDocumento.SelectedValue = datoleido("ID_TipoDocumento").ToString()
                txtDireccion.Text = datoleido("Direccion").ToString()
                txtNumero.Text = datoleido("Numero").ToString()
                txtPiso.Text = datoleido("Piso").ToString()
                txtLetraPuerta.Text = datoleido("Letra/Puerta").ToString()
                txtCodigoPostal.Text = datoleido("Codigo_Postal").ToString()
                txtNota.Text = datoleido("Nota").ToString()
                chkEstado.Checked = Convert.ToBoolean(datoleido("Estado"))

            Else
                MsgBox("No se encontraron resultados", vbInformation, "Error")
            End If

            datoleido.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al consultar la persona " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub grdPersonas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdPersonas.CellClick
        If e.RowIndex >= 0 Then

            ' Obtiene el ID de persona de la celda correspondiente
            Dim selectedRow As DataGridViewRow = grdPersonas.Rows(e.RowIndex)
            Dim IdPersona As Integer
            btnModificar.Enabled = True

            If selectedRow.Cells("N° Persona").Value IsNot Nothing Then
                IdPersona = Convert.ToInt32(selectedRow.Cells("N° Persona").Value)
                CargarDatosEnTxt(IdPersona)
            Else
                MsgBox("El ID de Persona no puede ser nulo.", vbCritical, "Error")

            End If
        End If


    End Sub
#End Region

#Region "Abrir frm para agregar datos"
    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        If cboTipoPersona.Text = "Personas Físicas" Then
            If txtID.Text <> Nothing And txtNombre.Text <> Nothing And txtApellido.Text <> Nothing And msktxtNumeroDocumento.Text <> Nothing Then
                frmAgregarEmpleados.IdPersona = Convert.ToInt32(txtID.Text)

                frmAgregarEmpleados.lblCargaEmpleado.Text = txtApellido.Text & " " & txtNombre.Text
                frmAgregarEmpleados.lblCargaCuil.Text = msktxtNumeroDocumento.Text
                frmAgregarEmpleados.lblCargaFechaNacimiento.Text = dtpFechaNacimiento.Value.ToString("dd/MM/yyyy")

                frmAgregarEmpleados.ShowDialog()
            Else
                MsgBox("Por favor seleccione una persona para cargar sus datos de empleado.", vbInformation, "Información")
            End If
        Else
            MsgBox("Por favor seleccione una persona física.", vbInformation, "Información")
        End If
    End Sub

    Private Sub btnDatoFiscal_Click(sender As Object, e As EventArgs) Handles btnDatoFiscal.Click
        If txtID.Text <> Nothing And txtNombre.Text <> Nothing And msktxtNumeroDocumento.Text <> Nothing Then
            frmAgregarDatosFiscales.IdPersona = Convert.ToInt32(txtID.Text)

            frmAgregarDatosFiscales.lblNombreResultado.Text = txtApellido.Text & " " & txtNombre.Text
            frmAgregarDatosFiscales.lblDocumentoResultado.Text = msktxtNumeroDocumento.Text

            If cboTipoPersona.Text = "Personas Físicas" Then

                'NO TOQUEN EL NOMBRE DE DONDE ESTÁ

                frmAgregarDatosFiscales.lblNombre.Text = "Apellido y 
Nombre"
            Else
                frmAgregarDatosFiscales.lblNombre.Text = "Razón Social"
            End If

            frmAgregarDatosFiscales.ShowDialog()
        Else
            MsgBox("Por favor seleccione una persona para cargar sus datos físcales.", vbInformation, "Información")
        End If
    End Sub

    Private Sub btnAgregarCiudad_Click(sender As Object, e As EventArgs) Handles btnAgregarCiudad.Click
        If cboCiudad.SelectedValue <> Nothing And cboProvincia.SelectedValue <> Nothing Then
            Dim frm As New frmAgregarCiudad()

            ' Pasar la ciudad y provincia seleccionada
            frm.CiudadID = Convert.ToInt32(cboCiudad.SelectedValue)
            frm.CiudadNombre = cboCiudad.Text
            frm.ProvinciaSeleccionada = Convert.ToInt32(cboProvincia.SelectedValue)
            'frm.CiudadEstado = grdPersonas.CurrentRow.Cells("Estado").Value
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
        If txtNombre.Text <> Nothing And msktxtNumeroDocumento.Text <> Nothing And
            txtCorreo.Text <> Nothing And txtDireccion.Text <> Nothing And txtNumero.Text <> Nothing And
            txtCodigoPostal.Text <> Nothing Then

            Try
                o_Personas.Agregar_Persona(CInt(cboTipoPersona.SelectedValue), txtNombre.Text, txtApellido.Text, txtTelefonoMovil.Text,
                       txtTelefonoFijo.Text, dtpFechaNacimiento.Value, CInt(cboTipoDocumento.SelectedValue), msktxtNumeroDocumento.Text,
                       txtCorreo.Text, txtDireccion.Text, txtNumero.Text, txtPiso.Text, txtLetraPuerta.Text, txtCodigoPostal.Text,
                       Convert.ToInt32(cboCiudad.SelectedValue), txtNota.Text, chkEstado.Checked)

                NuevaPersonaNombre = txtApellido.Text & " " & txtNombre.Text
                NuevaPersonaNombreCompra = txtApellido.Text & " " & txtNombre.Text

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
                       txtTelefonoFijo.Text, dtpFechaNacimiento.Value, CInt(cboTipoDocumento.SelectedValue), msktxtNumeroDocumento.Text,
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

#Region "Buscar"
    Private Sub Filtrar_Grilla()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "Cargar_Grilla_Persona"

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            ' Filtrar por nombre o apellido
            If oDs.Tables(0).Rows.Count > 0 Then
                Dim dt As DataTable = oDs.Tables(0)
                Dim filtro As String = txtBuscar.Text.Trim()

                If Not String.IsNullOrEmpty(filtro) Then
                    Dim dv As New DataView(dt)
                    dv.RowFilter = String.Format(
                    "[Nombre / Razon Social] LIKE '%{0}%' OR Apellido LIKE '%{0}%' OR Documento LIKE '%{0}%' OR [Teléfono Móvil] LIKE '%{0}%' OR [Teléfono Fijo] LIKE '%{0}%' OR Correo LIKE '%{0}%'",
                    filtro
                )
                    grdPersonas.DataSource = dv
                Else
                    grdPersonas.DataSource = dt
                End If

                grdPersonas.Refresh()
            Else
                MsgBox("No se encontraron datos para mostrar.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al filtrar la grilla: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Filtrar_Grilla()
    End Sub

#End Region

#Region "Keypress"
    'Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If Not Char.IsLetter(e.KeyChar) _
    '       AndAlso Not Char.IsControl(e.KeyChar) _
    '       AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If Not Char.IsLetter(e.KeyChar) _
    '     AndAlso Not Char.IsControl(e.KeyChar) _
    '     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
    '        e.Handled = True
    '    End If

    'End Sub

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

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNumero.Focus()
        End If
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPiso.Focus()
        End If

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

    Private Sub txtLetraPuerta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLetraPuerta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtTelefonoMovil.Focus()
        End If
    End Sub

    Private Sub txtTelefonoMovil_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtTelefonoFijo.Focus()
        End If
    End Sub

    Private Sub txtPiso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPiso.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtLetraPuerta.Focus()
        End If
    End Sub

    Private Sub txtTelefonoFijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefonoFijo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCorreo.Focus()
        End If
    End Sub

    Private Sub txtCorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNota.Focus()
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtApellido.Focus()
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Asc(e.KeyChar) = 13 Then
            msktxtNumeroDocumento.Focus()
        End If
    End Sub

    Private Sub txtNumeroDocumento_KeyPress(sender As Object, e As KeyPressEventArgs)
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

#Region "Mascaras"
    Public Sub Mascaras()
        If cboTipoDocumento.Text IsNot Nothing Then
            Select Case cboTipoDocumento.Text.ToString()
                Case "CUIL", "CUIT"
                    msktxtNumeroDocumento.Mask = "00-00000000-0"
                Case "DNI"
                    msktxtNumeroDocumento.Mask = "00.000.000"
                Case Else
                    msktxtNumeroDocumento.Mask = ""
            End Select
        End If
    End Sub

    Private Sub cboTipoDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoDocumento.SelectedIndexChanged
        Mascaras()
        validacion()
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

#Region "AFIP"
    Private Async Sub BtnValidarCUIT(sender As Object, e As EventArgs) Handles msktxtNumeroDocumento.Leave

        If cboTipoDocumento.SelectedValue = 3 Then

            Dim cuit As String = msktxtNumeroDocumento.Text.Replace("-", "")

            ' Validar que el CUIT tenga 11 dígitos
            If cuit.Length <> 11 Then
                MessageBox.Show("El CUIT debe tener 11 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' URL de la API
            Dim apiUrl As String = $"https://recetas.instantagro.goodapps.com.ar/GetContribuyente.ashx?CUIT={cuit}"

            Try
                ' Realizar la solicitud HTTP
                Using client As New HttpClient()
                    Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)
                    response.EnsureSuccessStatusCode()

                    ' Asegurarse de leer el contenido como UTF-8
                    Dim byteArray As Byte() = Await response.Content.ReadAsByteArrayAsync()
                    Dim responseBody As String = Encoding.UTF8.GetString(byteArray) ' Aquí usas Encoding.UTF8

                    ' Verificar si la respuesta contiene errorGetData
                    Dim jsonResponse = JsonConvert.DeserializeObject(Of JObject)(responseBody)

                    ' Verificar si contiene "errorGetData":true
                    If jsonResponse("errorGetData") IsNot Nothing AndAlso jsonResponse("errorGetData").Value(Of Boolean)() Then
                        MessageBox.Show(jsonResponse("errorMessage").ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                    ' Deserializar la respuesta JSON
                    Dim contribuyenteData As ContribuyenteResponse = JsonConvert.DeserializeObject(Of ContribuyenteResponse)(responseBody)
                    ' Variable que contiene la dirección completa
                    Dim direccionCompleta As String = contribuyenteData.Contribuyente.domicilioFiscal.direccion
                    Dim calle As String = ""
                    Dim numero As String = ""

                    If direccionCompleta <> Nothing Then
                        ' Encuentra el índice del último espacio
                        Dim indiceUltimoEspacio As Integer = direccionCompleta.LastIndexOf(" "c)

                        ' Variables para almacenar la dirección y lo que hay a la derecha del espacio

                        ' Verifica si se encontró un espacio
                        If indiceUltimoEspacio <> -1 Then
                            ' Extrae la parte izquierda (todo antes del último espacio)
                            calle = direccionCompleta.Substring(0, indiceUltimoEspacio)

                            ' Extrae la parte derecha (todo después del último espacio)
                            numero = direccionCompleta.Substring(indiceUltimoEspacio + 1)
                        Else
                            ' Si no se encontró un espacio, usa la dirección completa como parte izquierda
                            calle = direccionCompleta
                        End If
                    End If
                    ' Actualizar los campos en el formulario con los datos obtenidos
                    If contribuyenteData IsNot Nothing AndAlso Not contribuyenteData.errorGetData Then
                        Dim RazonSocial As String = contribuyenteData.Contribuyente.nombre
                        Dim Apellido As String = ""
                        Dim Nombre As String = ""

                        ' Buscar la posición del primer espacio
                        Dim espacioPos As Integer = RazonSocial.IndexOf(" "c)

                        ' Si se encuentra un espacio
                        If espacioPos > -1 Then
                            ' Apellido será todo lo que está antes del primer espacio
                            Apellido = RazonSocial.Substring(0, espacioPos).Trim()

                            ' Nombre será todo lo que está después del primer espacio
                            Nombre = RazonSocial.Substring(espacioPos + 1).Trim()
                        Else
                            ' Si no se encuentra un espacio, se asume que todo es Apellido
                            Apellido = RazonSocial
                        End If

                        If cboTipoPersona.SelectedValue = 1 Then
                            txtApellido.Text = Apellido
                            txtNombre.Text = Nombre
                        Else
                            txtApellido.Text = ""
                            txtNombre.Text = RazonSocial

                        End If

                        cboProvincia.SelectedValue = contribuyenteData.Contribuyente.domicilioFiscal.idProvincia
                        cboCiudad.Text = contribuyenteData.Contribuyente.domicilioFiscal.localidad
                        txtDireccion.Text = calle
                        txtNumero.Text = numero

                        ' Configurar la categoría IVA

                        If contribuyenteData.Contribuyente.EsRI Then
                            EsRI = True
                        ElseIf contribuyenteData.Contribuyente.EsMonotributo Then
                            EsMonotributo = True
                        ElseIf contribuyenteData.Contribuyente.EsExento Then
                            EsExento = True
                        Else
                            EsConsFinal = True
                        End If
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la API: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


#End Region

#Region "Validaciones"
    Public Sub validacion()
        If cboTipoPersona.SelectedValue IsNot Nothing AndAlso
                cboTipoDocumento.SelectedValue IsNot Nothing AndAlso
                cboProvincia.SelectedValue IsNot Nothing AndAlso
                cboCiudad.SelectedValue IsNot Nothing AndAlso
                Not String.IsNullOrWhiteSpace(txtNombre.Text) AndAlso
                Not String.IsNullOrWhiteSpace(txtDireccion.Text) AndAlso
                Not String.IsNullOrWhiteSpace(txtNumero.Text) Then
            chkEstado.Visible = True
        Else
            chkEstado.Visible = False
        End If
    End Sub

    Private Sub cboTipoPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPersona.SelectedIndexChanged
        validacion()
    End Sub

    Private Sub msktxtNumeroDocumento_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msktxtNumeroDocumento.MaskInputRejected
        validacion()
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = False

            txtApellido.Focus()
        End If
    End Sub

    Private Sub txtCodigoPostal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = False

            txtDireccion.Focus()
        End If
    End Sub

    Private Sub txtDireccion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = False

            txtNumero.Focus()
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        validacion()
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged
        validacion()

    End Sub

    Private Sub cboCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCiudad.SelectedIndexChanged
        validacion()
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        validacion()
    End Sub

    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged
        validacion()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' Mostrar el TextBox cuando se presiona el botón
        txtBuscar.Visible = True
        txtBuscar.Focus() ' Para que el cursor esté en el TextBox
    End Sub

    Private Sub grdPersonas_SelectionChanged(sender As Object, e As EventArgs) Handles grdPersonas.SelectionChanged
        If String.IsNullOrWhiteSpace(txtBuscar.Text) Then
            txtBuscar.Visible = False
        End If
    End Sub
#End Region

End Class

' Clases para deserializar el JSON
Public Class ContribuyenteResponse
    Public Property Contribuyente As Contribuyente
    Public Property errorGetData As Boolean
End Class

Public Class Contribuyente
    Public Property nombre As String
    Public Property domicilioFiscal As DomicilioFiscal
    Public Property EsRI As Boolean
    Public Property EsMonotributo As Boolean
    Public Property EsExento As Boolean
End Class

Public Class DomicilioFiscal
    Public Property direccion As String
    Public Property localidad As String
    Public Property idProvincia As Integer
End Class