Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient

Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers

Public Class frmModificarCiudades
    Dim o_Ciudad As New AD_Ciudades
    Private gmapControl As GMapControl

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

        ' Inicializa el control GMap en tu formulario
        gmapControl = New GMapControl()

        ' Establece la ubicación y tamaño del mapa
        gmapControl.Location = New Point(Me.ClientSize.Width - 400, Me.ClientSize.Height - 300) ' Ajusta estas coordenadas según tus necesidades
        gmapControl.Size = New Size(400, 300) ' Establece el tamaño del control

        Me.Controls.Add(gmapControl)

        ' Configura el mapa
        gmapControl.MapProvider = GMapProviders.OpenStreetMap ' O cualquier proveedor que desees usar
        gmapControl.MinZoom = 1
        gmapControl.MaxZoom = 20
        gmapControl.Zoom = 5 ' Ajusta el nivel de zoom inicial

        ' Carga las provincias en el mapa
        CargarPersonasPorProvinciaEnMapa()
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

#Region "Grafico Provincia"
    Private Sub CargarPersonasPorProvinciaEnMapa()
        ' Obtiene los datos desde la capa de acceso a datos
        Dim provincias As List(Of AD_Ciudades.Provincia) = o_Ciudad.ObtenerPersonasPorProvincia()

        ' Crea una capa de marcadores en el mapa
        Dim markers As New GMapOverlay("markers")

        ' Crea una instancia de la clase que contiene las coordenadas
        Dim coordenadasProvincias As List(Of AD_Ciudades.Provincia) = o_Ciudad.ObtenerCoordenadasProvincias()

        ' Recorre cada provincia y agrega un marcador en el mapa
        For Each provincia In provincias
            ' Busca las coordenadas correspondientes a la provincia actual
            Dim coordenadas As AD_Ciudades.Provincia = coordenadasProvincias.FirstOrDefault(Function(p) p.Nombre.Equals(provincia.Nombre, StringComparison.OrdinalIgnoreCase))

            ' Si se encontraron coordenadas, agrega un marcador
            If coordenadas IsNot Nothing Then
                Dim marker As New GMarkerGoogle(New PointLatLng(coordenadas.Latitud, coordenadas.Longitud), GMarkerGoogleType.red_dot)
                marker.ToolTipText = $"{provincia.Nombre}: {provincia.CantidadPersonas} personas registradas"
                markers.Markers.Add(marker)
            End If
        Next

        ' Agrega los marcadores al control del mapa
        gmapControl.Overlays.Add(markers)
        gmapControl.Position = New PointLatLng(-38.4161, -63.6167) ' Centra el mapa en Argentina
    End Sub
#End Region

End Class