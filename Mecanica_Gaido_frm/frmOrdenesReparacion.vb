Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frmOrdenesReparacion
    Public persona As Integer = -1
    Dim o_Orden As New AD_OrdenReparacion

#Region "Procedimientos"
    Private Sub frmOrdenesReparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Personas()
        Cargar_Combo_Prestador()
        Cargar_Combo_Repuestos()
        If esFiltradoPorGrafico AndAlso Not String.IsNullOrEmpty(estadoParaFiltrar) Then
            Cargar_Grilla_OrdenesP(estadoParaFiltrar)
        Else
            Cargar_Grilla_Ordenes()
        End If
        Cargar_Combo_TiposReparacion()
        limpiar()
        ponerDecimales()
        AplicarTema(Me)
    End Sub

    Public Sub New(Optional ByVal estadoParaFiltrar As String = "", Optional ByVal esFiltradoPorGrafico As Boolean = False)
        InitializeComponent()
        Me.estadoParaFiltrar = estadoParaFiltrar
        Me.esFiltradoPorGrafico = esFiltradoPorGrafico
    End Sub

    Public Sub limpiar()
        txtID.Clear()
        txtSeñasParticulares.Clear()
        txtMotivoReparacion.Clear()
        cboPersonas.SelectedIndex = -1
        CboPersonaServ3.SelectedIndex = -1
        cboVehiculo.SelectedIndex = -1
        CboProgreso.SelectedIndex = -1
        CboTipoReparacion.SelectedIndex = -1
        chkActivo.Checked = True
        chkActivo.Visible = False
        btnAceptar.Enabled = True
        btnModificar.Enabled = False
    End Sub

    Private Sub limpiarServ3()
        CboPersonaServ3.SelectedIndex = -1
        txtID_Serv3.Text = ""
        txtServicioSolicitado.Text = ""
        txtCostoEstimadoS3.Text = Convert.ToDecimal(0).ToString("N2")
        txtCostoRealS3.Text = Convert.ToDecimal(0).ToString("N2")
        chkAvanceServ3.Checked = False
        chkActivo.Checked = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiarServ3()
        grdServiciosTerceros.Rows.Clear()
        limpiar()
        grdRepuestos.Rows.Clear()
        ActualizarMontoTotalRep()
        ActualizarMontoTotalS3()
        txtMontoManoObra.Text = Convert.ToDecimal(0).ToString("N2")
        CalcularTotalOR()
    End Sub

    Private Sub BtnCancelarS3_Click(sender As Object, e As EventArgs) Handles BtnCancelarS3.Click
        limpiarServ3()

        grdServiciosTerceros.Rows.Clear()
        ActualizarMontoTotalS3()
        btnAceptarS3.Enabled = True
        BtnModificarS3.Enabled = False
        btnQuitarS3.Enabled = False
    End Sub

#End Region

#Region "Repuestos"
    Private Sub grdRepuestos_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles grdRepuestos.CellValidating
        If grdRepuestos.Columns(e.ColumnIndex).Name = "Precio" Then
            Dim newPrice As Decimal
            If Not Decimal.TryParse(e.FormattedValue.ToString(), newPrice) Then
                e.Cancel = True
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el precio.")
            End If
        End If
    End Sub

    Private Sub btnAgregarRepOR_Click(sender As Object, e As EventArgs) Handles btnAgregarRepOR.Click
        Try
            If cboProductoOR.SelectedValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(txtCantidadRepOR.Text) Then
                Dim rowView As DataRowView = CType(cboProductoOR.SelectedItem, DataRowView)
                Dim idRepuesto As Integer = Convert.ToInt32(rowView("ID_Repuestos"))
                Dim descripcionRepuesto As String = rowView("Descripcion").ToString()
                Dim nombreDiario As String = rowView("nombreDiario").ToString()
                Dim precio As Decimal = Convert.ToDecimal(rowView("PrecioLista"))
                precio = InputBox("Confirme el Precio", "Precio Sugerido", Convert.ToDecimal(precio).ToString("N2"))
                Dim cantidad As Integer = Convert.ToDecimal(txtCantidadRepOR.Text)
                Dim total As Decimal = precio * cantidad

                grdRepuestos.Rows.Add(idRepuesto, descripcionRepuesto, nombreDiario, cantidad, precio, total)

                Cargar_Combo_Repuestos()
                txtCantidadRepOR.Text = Convert.ToDecimal(1).ToString("N2")
                ActualizarMontoTotalRep()
                btnQuitarRepOR.Enabled = True
            Else
                MsgBox("Por favor, seleccione un repuesto y especifique la cantidad.", vbExclamation, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Error al agregar el repuesto: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitarRepOR.Click
        Try
            If grdRepuestos.SelectedRows.Count > 0 Then
                grdRepuestos.Rows.Remove(grdRepuestos.SelectedRows(0))
                ActualizarMontoTotalRep()
                If grdRepuestos.Rows.Count = 0 Then
                    btnQuitarRepOR.Enabled = False
                End If
            Else
                MsgBox("Por favor, seleccione una fila para quitar.", vbExclamation, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Error al quitar el repuesto: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub grdRepuestos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRepuestos.CellClick
        btnQuitarRepOR.Enabled = True
    End Sub

#End Region

#Region "Cbo y Grilla Repuestos"
    Private Sub Cargar_Combo_Repuestos()
        Try
            Dim tablaRep As DataTable = o_Orden.Cargar_Combo_Repuestos()

            If tablaRep.Rows.Count > 0 Then
                cboProductoOR.DataSource = tablaRep
                cboProductoOR.DisplayMember = "Descripcion"
                cboProductoOR.ValueMember = "ID_Repuestos"

                cboProductoOR.SelectedValue = -1
            Else
                MsgBox("No se encontraron Repuestos.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Repuestos: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Public Sub Cargar_Grilla_RepuestosPorOrden()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_RepuestosPorOrden")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdRepuestos.AutoGenerateColumns = True
                grdRepuestos.DataSource = oDs.Tables(0)

                Dim columnasParaOcultar As String() = {}
                For Each colName As String In columnasParaOcultar
                    If grdRepuestos.Columns.Contains(colName) Then
                        grdRepuestos.Columns(colName).Visible = False
                    End If
                Next
                grdRepuestos.Refresh()
            Else
                MsgBox("No se Repuestos asociados a esta Orden.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al cargar la grilla: " & ex.Message, vbCritical, "Error")
        Finally
        End Try
    End Sub
#End Region

#Region "Cbo Persona"
    Private combopersonacargado = False

    Private nombrePersona As String
    Private telefonoPersona As String
    Private direccionPersona As String
    Private cuitPersona As String
    Private localidadPersona As String

    Private Sub Cargar_Combo_Personas()
        Try
            Dim tabla As DataTable = o_Orden.Cargar_Combo_Personas()

            If tabla.Rows.Count > 0 Then
                cboPersonas.DataSource = Nothing
                cboPersonas.DataSource = tabla
                cboPersonas.DisplayMember = "Persona"
                cboPersonas.ValueMember = "ID_Persona"
                cboPersonas.SelectedIndex = -1
            Else
                MsgBox("No se encontraron personas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las personas: " & ex.Message, vbCritical, "Error")
        End Try
        combopersonacargado = True
    End Sub

    Private Sub cboPersonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPersonas.SelectedIndexChanged
        If combopersonacargado AndAlso cboPersonas.SelectedIndex <> -1 Then
            Dim ID_Persona As Integer = Convert.ToInt32(cboPersonas.SelectedValue)
            Cargar_Combo_Vehiculos(ID_Persona)
        End If

        If cboPersonas.SelectedValue IsNot Nothing Then
            Dim selectedValue As Object = cboPersonas.SelectedValue
            Dim idPersona As Integer

            If Integer.TryParse(selectedValue.ToString(), idPersona) Then
                Dim dtPersona As DataTable = o_Orden.ObtenerDatosPersona(idPersona)

                If dtPersona.Rows.Count > 0 Then
                    nombrePersona = dtPersona.Rows(0)("Nombre").ToString()
                    telefonoPersona = dtPersona.Rows(0)("Telefono_Movil").ToString()
                    direccionPersona = dtPersona.Rows(0)("Direccion").ToString() & " " & dtPersona.Rows(0)("Numero").ToString()
                    cuitPersona = dtPersona.Rows(0)("CUIT").ToString()
                    localidadPersona = dtPersona.Rows(0)("Localidad").ToString()
                End If
            End If
        End If
    End Sub
#End Region

#Region "Cbo Vehiculos"
    Private marcaVehiculo As String
    Private modeloVehiculo As String
    Private chasisVehiculo As String
    Private numMotorVehiculo As String
    Private horasVehiculo As String

    Private Sub Cargar_Combo_Vehiculos(ID_Persona As Integer)
        Try
            Dim tabla As DataTable = o_Orden.Cargar_Combo_Vehiculos(ID_Persona)

            If tabla.Rows.Count > 0 Then
                cboVehiculo.DataSource = Nothing
                cboVehiculo.DataSource = tabla
                cboVehiculo.DisplayMember = "Nombre"
                cboVehiculo.ValueMember = "ID_Vehiculo"
                cboVehiculo.SelectedIndex = -1
            Else
                MsgBox("No se encontraron vehículos para esta persona.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los vehículos: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub cboVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVehiculo.SelectedIndexChanged
        If cboVehiculo.SelectedValue IsNot Nothing Then
            Dim selectedValue As Object = cboVehiculo.SelectedValue
            Dim idVehiculo As Integer

            If Integer.TryParse(selectedValue.ToString(), idVehiculo) Then
                Dim dtVehiculo As DataTable = o_Orden.ObtenerDatosVehiculo(idVehiculo)

                If dtVehiculo.Rows.Count > 0 Then
                    marcaVehiculo = dtVehiculo.Rows(0)("Marca").ToString()
                    modeloVehiculo = dtVehiculo.Rows(0)("Modelo").ToString()
                    chasisVehiculo = dtVehiculo.Rows(0)("Numero_Chasis").ToString()
                    numMotorVehiculo = dtVehiculo.Rows(0)("Numero_Motor").ToString()
                    horasVehiculo = dtVehiculo.Rows(0)("Horas_Trabajadas").ToString()
                End If
            End If
        End If
    End Sub
#End Region

#Region "Servicios de terceros"
    Private Sub btnAceptarS3_Click(sender As Object, e As EventArgs) Handles btnAceptarS3.Click
        'Cargar_Grilla_Terceros()
        Try
            If CboPersonaServ3.SelectedValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(txtServicioSolicitado.Text) Then

                Dim rowView As DataRowView = CType(CboPersonaServ3.SelectedItem, DataRowView)
                Dim Nro_Servicio As Integer
                If txtID_Serv3.Text <> Nothing Then
                    Nro_Servicio = Convert.ToInt32(txtID_Serv3.Text)
                Else
                    Nro_Servicio = 0
                End If
                Dim ID_Prestador As Integer = rowView("ID_Persona").ToString()
                Dim Prestador As String = rowView("Persona").ToString()
                Dim ServSolicitado As String = txtServicioSolicitado.Text
                Dim estimado As Decimal = Convert.ToDecimal(txtCostoEstimadoS3.Text).ToString("N2")
                Dim real As Decimal = Convert.ToDecimal(txtCostoRealS3.Text).ToString("N2")
                Dim Fin As Boolean = chkAvanceServ3.Checked
                Dim activo As Boolean = chkActivoS3.Checked

                grdServiciosTerceros.Rows.Add(Nro_Servicio, ID_Prestador, Prestador, ServSolicitado, estimado, real, Fin, activo)
                Cargar_Combo_Prestador()

                ActualizarMontoTotalS3()
                limpiarServ3()
                btnQuitarS3.Enabled = True
                BtnModificarS3.Enabled = False
            Else
                MsgBox("Por favor, seleccione un proveedor y especifique el servicio.", vbExclamation, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Error al agregar el servicio: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnModificarS3_Click(sender As Object, e As EventArgs) Handles BtnModificarS3.Click
        Try
            If filaElegida >= 0 Then
                Dim selectedRow As DataGridViewRow = grdServiciosTerceros.Rows(filaElegida)

                selectedRow.Cells("NroServicio").Value = Convert.ToInt32(txtID_Serv3.Text)
                selectedRow.Cells("ID_Prestador").Value = CboPersonaServ3.SelectedValue
                selectedRow.Cells("Prestador").Value = CboPersonaServ3.Text
                selectedRow.Cells("servSolicitado").Value = txtServicioSolicitado.Text
                selectedRow.Cells("CostoEstimado").Value = Convert.ToDecimal(txtCostoEstimadoS3.Text)
                selectedRow.Cells("CostoReal").Value = Convert.ToDecimal(txtCostoRealS3.Text)
                selectedRow.Cells("Finalizado").Value = chkAvanceServ3.Checked
                selectedRow.Cells("Estado").Value = chkActivo.Checked

                grdServiciosTerceros.ClearSelection()
                ActualizarMontoTotalS3()
                limpiarServ3()
                chkActivoS3.Visible = False
                btnAceptarS3.Enabled = True
                BtnModificarS3.Enabled = False
            Else
                MsgBox("Por favor, selecciona un registro para modificar.", vbExclamation, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Error al modificar el servicio de terceros: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnQuitarS3_Click(sender As Object, e As EventArgs) Handles btnQuitarS3.Click
        Try
            If grdServiciosTerceros.SelectedRows.Count > 0 Then
                grdServiciosTerceros.Rows.Remove(grdServiciosTerceros.SelectedRows(0))

                ActualizarMontoTotalS3()
                If grdServiciosTerceros.Rows.Count = 0 Then
                    btnQuitarS3.Enabled = False
                    BtnModificarS3.Enabled = False
                    chkActivoS3.Visible = False
                Else
                    btnQuitarS3.Enabled = True
                    BtnModificarS3.Enabled = True
                    chkActivoS3.Visible = True
                End If
                limpiarServ3()
                btnAceptarS3.Enabled = True
            Else
                MsgBox("Por favor, seleccione una fila para quitar.", vbExclamation, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Error al quitar el registro: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Cbo y Grilla Servicio 3eros"
    Private Sub Cargar_Combo_Prestador()
        Try
            Dim tabla As DataTable = o_Orden.Cargar_Combo_Prestador()

            If tabla.Rows.Count > 0 Then
                CboPersonaServ3.DataSource = tabla
                CboPersonaServ3.DisplayMember = "Persona"
                CboPersonaServ3.ValueMember = "ID_Persona"

                CboPersonaServ3.SelectedValue = -1
            Else
                MsgBox("No se encontraron Servicios.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Servicios: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub CboPersonaServ3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPersonaServ3.SelectedIndexChanged
        If CboPersonaServ3.SelectedItem IsNot Nothing Then

            Dim selectedRow As DataRowView = CType(CboPersonaServ3.SelectedItem, DataRowView)

            lblResultadoPrestador.Text = selectedRow("Persona").ToString()
        Else
            lblResultadoPrestador.Text = ""
        End If
    End Sub

    Public Sub Cargar_Grilla_Terceros()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_Terceros")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdServiciosTerceros.AutoGenerateColumns = True
                grdServiciosTerceros.DataSource = oDs.Tables(0)

                Dim columnasParaOcultar As String() = {}
                For Each colName As String In columnasParaOcultar
                    If grdServiciosTerceros.Columns.Contains(colName) Then
                        grdServiciosTerceros.Columns(colName).Visible = False
                    End If
                Next
                grdServiciosTerceros.Refresh()
            Else
                MsgBox("No hay Servicios de terceros asociados a esta orden.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al cargar la grilla: " & ex.Message, vbCritical, "Error")
        Finally
        End Try
    End Sub

    Private filaElegida As Integer = -1

    Private Sub grdServiciosTerceros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdServiciosTerceros.CellClick
        If e.RowIndex >= 0 Then
            filaElegida = e.RowIndex
            Dim selectedRow As DataGridViewRow = grdServiciosTerceros.Rows(filaElegida)
            txtID_Serv3.Text = selectedRow.Cells("NroServicio").Value.ToString()
            CboPersonaServ3.SelectedValue = selectedRow.Cells("ID_Prestador").Value
            txtServicioSolicitado.Text = selectedRow.Cells("servSolicitado").Value.ToString()
            txtCostoEstimadoS3.Text = Convert.ToDecimal(selectedRow.Cells("CostoEstimado").Value).ToString("N2")
            txtCostoRealS3.Text = Convert.ToDecimal(selectedRow.Cells("CostoReal").Value).ToString("N2")
            chkAvanceServ3.Checked = Convert.ToBoolean(selectedRow.Cells("Finalizado").Value)
            chkActivo.Checked = Convert.ToBoolean(selectedRow.Cells("Estado").Value)
        End If
        If grdServiciosTerceros.Rows.Count > 0 Then
            btnQuitarS3.Enabled = True
        Else
            btnQuitarS3.Enabled = False
        End If
        btnAceptarS3.Enabled = False
        BtnModificarS3.Enabled = True
        chkActivoS3.Visible = True
    End Sub
#End Region

#Region "Cbo Tipo Reparacion"
    Private Sub Cargar_Combo_TiposReparacion()
        Try
            Dim tablaTipoRep As DataTable = o_Orden.Cargar_Combo_TipoReparacion()

            If tablaTipoRep.Rows.Count > 0 Then
                CboTipoReparacion.DataSource = tablaTipoRep
                CboTipoReparacion.DisplayMember = "TipoDeReparacion"
                CboTipoReparacion.ValueMember = "ID_TipoReparacion"

                CboTipoReparacion.SelectedValue = -1
            Else
                MsgBox("No se encontraron Tipos de Reparación.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Tipos de Reparación: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Grilla Ord y mostrar datos"
    Public Sub Cargar_Grilla_Ordenes()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_Ordenes")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdOrdenReparacion.AutoGenerateColumns = True
                grdOrdenReparacion.DataSource = oDs.Tables(0)

                Dim columnasParaOcultar As String() = {}
                For Each colName As String In columnasParaOcultar
                    If grdOrdenReparacion.Columns.Contains(colName) Then
                        grdOrdenReparacion.Columns(colName).Visible = False
                    End If
                Next
                grdOrdenReparacion.Refresh()
            Else
                MsgBox("No se encontraron Ordenes para mostrar.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al cargar la grilla: " & ex.Message, vbCritical, "Error")
        Finally
        End Try
    End Sub

    Public Sub Cargar_Grilla_OrdenesP(estado As String)
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_Ordenes_Progreso")
            comando.Parameters.AddWithValue("@Progreso", estado)

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdOrdenReparacion.AutoGenerateColumns = True
                grdOrdenReparacion.DataSource = oDs.Tables(0)


                grdOrdenReparacion.Refresh()
            Else
                MsgBox("No se encontraron Ordenes para mostrar.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al cargar la grilla: " & ex.Message, vbCritical, "Error")

        End Try
    End Sub

    Private Sub grdOrdenReparacion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdOrdenReparacion.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < grdOrdenReparacion.Rows.Count Then
            Dim selectedRow As DataGridViewRow = grdOrdenReparacion.Rows(e.RowIndex)
            Dim ID_Orden As Integer = Convert.ToInt32(selectedRow.Cells("ID").Value)

            CargarDatosOrden(ID_Orden)

            btnAceptar.Enabled = False
            btnModificar.Enabled = True
        End If
    End Sub

    Private Sub CargarDatosOrden(ID_Orden As Integer)
        combopersonacargado = False

        Dim connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"

        Using conn As New SqlConnection(connectionString)

            Dim adOrdenReparacion As New AD_OrdenReparacion()

            Dim ds As DataSet = adOrdenReparacion.Buscar_DatosOrdenReparacion_ID(ID_Orden)

            If ds.Tables.Count > 0 Then

                Dim ordenTable As DataTable = ds.Tables(0)
                If ordenTable.Rows.Count > 0 Then
                    Dim row As DataRow = ordenTable.Rows(0)
                    cboPersonas.SelectedValue = row("ID_Persona")
                    Cargar_Combo_Vehiculos(Convert.ToInt32(row("ID_Persona")))
                    cboVehiculo.SelectedValue = row("ID_Vehiculo")
                    txtSeñasParticulares.Text = row("Señas_Particulares").ToString()
                    txtMotivoReparacion.Text = row("Motivo_Reparacion").ToString()
                    dtpTurno.Value = Convert.ToDateTime(row("Fecha_Turno"))
                    dtpEntrada.Value = Convert.ToDateTime(row("Fecha_Entrada"))
                    dtpSalida.Value = Convert.ToDateTime(row("Fecha_Salida"))
                    txtMontoManoObra.Text = If(IsDBNull(row("Precio_Mano_De_Obra")), "0,00", Convert.ToDecimal(row("Precio_Mano_De_Obra")).ToString("N2"))
                    txtMontoRepuestos.Text = If(IsDBNull(row("MontoRepuestos")), "0,00", Convert.ToDecimal(row("MontoRepuestos")).ToString("N2"))
                    txtMontoServ3.Text = If(IsDBNull(row("MontoServicioTerceros")), "0,00", Convert.ToDecimal(row("MontoServicioTerceros")).ToString("N2"))
                    txtSubtotal.Text = If(IsDBNull(row("Subtotal")), "0,00", Convert.ToDecimal(row("Subtotal")).ToString("N2"))
                    txtIVA.Text = If(IsDBNull(row("IVAPorc")), "0,00", Convert.ToDecimal(row("IVAPorc")).ToString("N2"))
                    txtMontoIVA.Text = If(IsDBNull(row("MontoIVA")), "0,00", Convert.ToDecimal(row("MontoIVA")).ToString("N2"))
                    txtMontoTotalOR.Text = If(IsDBNull(row("MontoTotalOrden")), "0,00", Convert.ToDecimal(row("MontoTotalOrden")).ToString("N2"))
                    chkActivo.Checked = Convert.ToBoolean(row("Estado"))
                    CboTipoReparacion.SelectedValue = row("ID_TipoReparacion")
                    CboProgreso.SelectedItem = row("ProgresoOrden")
                End If

                Dim serviciosTable As DataTable = ds.Tables(1)
                grdServiciosTerceros.Rows.Clear()

                For Each serviceRow As DataRow In serviciosTable.Rows
                    Dim Prestador As String = String.Empty
                    For Each item As DataRowView In CboPersonaServ3.Items
                        If Convert.ToInt32(item(CboPersonaServ3.ValueMember)) = Convert.ToInt32(serviceRow("ID_Persona")) Then
                            Prestador = item(CboPersonaServ3.DisplayMember).ToString()
                            Exit For
                        End If
                    Next

                    grdServiciosTerceros.Rows.Add(serviceRow("ID_ServicioTercero"), serviceRow("ID_Persona"), Prestador, serviceRow("Detalle_Prestacion"),
                                    serviceRow("Costo_Estimado"), serviceRow("Costo_Real"), serviceRow("Estado_Trabajo"), serviceRow("Estado"))
                Next
                txtID_Serv3.Text = ""
                CboPersonaServ3.SelectedIndex = -1
                txtServicioSolicitado.Text = ""
                txtCostoEstimadoS3.Text = Convert.ToDecimal(0).ToString("N2")
                txtCostoRealS3.Text = Convert.ToDecimal(0).ToString("N2")

                Dim repuestosTable As DataTable = ds.Tables(2)
                grdRepuestos.Rows.Clear()
                For Each repuestoRow As DataRow In repuestosTable.Rows

                    Dim repuestoData As DataRow = adOrdenReparacion.BuscarRepuestoPorID(Convert.ToInt32(repuestoRow("ID_Repuesto")))
                    If repuestoData IsNot Nothing Then
                        Dim NombreRepuesto As String = repuestoData("Descripcion").ToString()
                        Dim NombreDiarioRepuesto As String = repuestoData("NombreDiario").ToString()
                        Dim totalRep = Convert.ToDecimal(repuestoRow("Cantidad")) * Convert.ToDecimal(repuestoRow("Precio"))

                        grdRepuestos.Rows.Add(repuestoRow("ID_Repuesto"), NombreRepuesto, NombreDiarioRepuesto,
                                              repuestoRow("Cantidad"), repuestoRow("Precio"), totalRep)
                    End If
                Next
                cboProductoOR.SelectedIndex = -1
            End If
        End Using
        chkActivo.Visible = True
        combopersonacargado = True
    End Sub
#End Region

#Region "Grafico"
    Public Property esFiltradoPorGrafico As Boolean = False
    Public Property estadoParaFiltrar As String
    Public WithEvents formTimer As New Timer()

    Public Sub New()
        InitializeComponent()
        ' Configurar el timer para que se ejecute una vez, después de 200ms
        formTimer.Interval = 400
        AddHandler formTimer.Tick, AddressOf OnFormTimerTick
    End Sub

    Private Sub OnFormTimerTick(sender As Object, e As EventArgs)
        formTimer.Stop() ' Detener el timer después de que se ejecute

        If Not String.IsNullOrEmpty(estadoParaFiltrar) Then
            Cargar_Grilla_OrdenesP(estadoParaFiltrar)
        End If
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim ordenReparacionData As New AD_OrdenReparacion
        Dim servicioTercerosData As New AD_ServicioTerceros
        Dim repuestosData As New AD_Productos

        Dim connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim transaction As SqlTransaction = conn.BeginTransaction()

            If cboVehiculo.SelectedValue Is Nothing Then
                MessageBox.Show("Por favor, seleccione un vehículo.")
                Exit Sub
            End If

            Try
                Dim ID_Orden As Integer = ordenReparacionData.Agregar_Orden_Reparacion(Convert.ToInt32(cboVehiculo.SelectedValue),
                          txtSeñasParticulares.Text, txtMotivoReparacion.Text, dtpTurno.Value, dtpEntrada.Value, dtpSalida.Value,
                          cboPersonas.SelectedValue, Convert.ToDecimal(txtMontoRepuestos.Text), Convert.ToDecimal(txtMontoServ3.Text),
                          Convert.ToDecimal(txtMontoManoObra.Text), Convert.ToDecimal(txtMontoTotalOR.Text), Convert.ToBoolean(chkActivo.Checked),
                           CboTipoReparacion.SelectedValue, CboProgreso.SelectedItem, transaction)

                If grdServiciosTerceros.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In grdServiciosTerceros.Rows
                        Dim ID_Prestador As Integer = Convert.ToInt32(row.Cells("ID_Prestador").Value)
                        Dim ServSolicitado As String = row.Cells("ServSolicitado").Value
                        Dim CostoEstimado As Decimal = Convert.ToDecimal(row.Cells("CostoEstimado").Value)
                        Dim CostoReal As Decimal = Convert.ToDecimal(row.Cells("CostoReal").Value)
                        Dim Finalizado As Boolean = Convert.ToBoolean(row.Cells("Finalizado").Value)
                        Dim Estado As Boolean = Convert.ToBoolean(row.Cells("Estado").Value)

                        servicioTercerosData.Agregar_Servicio_Terceros(ID_Orden, dtpEntrada.Value, ID_Prestador, ServSolicitado,
                                                    CostoEstimado, CostoReal, Finalizado, Estado, transaction)
                    Next
                End If

                If grdRepuestos.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In grdRepuestos.Rows
                        Dim ID_Repuestos As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Dim Cantidad As Decimal = Convert.ToDecimal(row.Cells("Cantidad").Value)
                        Dim Precio_Rep As Decimal = Convert.ToDecimal(row.Cells("Precio").Value)

                        repuestosData.Agregar_Repuestos_Ordenes(ID_Repuestos, ID_Orden, Cantidad, Precio_Rep, True, 'Harcodeado porque no lo tuvimos en cuenta
                                                                transaction)

                        Dim stockDisponible As Integer = repuestosData.Consultar_StockDisponiblePorID(ID_Repuestos, transaction)

                        stockDisponible -= Cantidad

                        repuestosData.Modificar_StockDisponiblePorID(ID_Repuestos, stockDisponible, transaction)
                    Next
                End If
                transaction.Commit()
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        Cargar_Grilla_Ordenes()
        MessageBox.Show("Orden cargada exitosamente")

        limpiarServ3()
        txtID.Clear()
        txtSeñasParticulares.Clear()
        txtMotivoReparacion.Clear()

        cboPersonas.SelectedIndex = -1
        CboPersonaServ3.SelectedIndex = -1
        grdRepuestos.Rows.Clear()
        ActualizarMontoTotalRep()
        ActualizarMontoTotalS3()
        txtMontoManoObra.Text = Convert.ToDecimal(0).ToString("N2")
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim ID_Orden As Integer = GetSelectedIDOrden()

        If ID_Orden > 0 Then
            ModificarOrden(ID_Orden)
            btnModificar.Enabled = False
            btnAceptar.Enabled = True
            Cargar_Grilla_Ordenes()
            If grdServiciosTerceros.Rows.Count > 1 Then
                btnQuitarS3.Enabled = True
            Else
                btnQuitarS3.Enabled = False
            End If
        Else
            MessageBox.Show("Seleccione una orden para modificar.")
        End If
    End Sub

    Private Function GetSelectedIDOrden() As Integer
        If grdOrdenReparacion.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = grdOrdenReparacion.SelectedRows(0)
            Return Convert.ToInt32(selectedRow.Cells("ID").Value)
        End If

        Return -1
    End Function

    Private Sub ModificarOrden(id_orden As Integer)
        Dim connectionstring = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"

        Using conn As New SqlConnection(connectionstring)
            conn.Open()
            Dim transaction As SqlTransaction = conn.BeginTransaction()

            Try
                Dim Orden As New AD_OrdenReparacion()

                ' Validar si el progreso es Finalizada o Facturada y hay servicios de terceros no finalizados
                If (CboProgreso.SelectedItem = "Finalizada" Or CboProgreso.SelectedItem = "Facturada") Then
                    Dim noFinalizados As Integer = 0
                    For Each fila As DataGridViewRow In grdServiciosTerceros.Rows
                        Dim estadoTrabajo As Boolean = CBool(fila.Cells("Finalizado").Value)
                        If Not estadoTrabajo Then
                            noFinalizados += 1
                        End If
                    Next

                    ' Si hay servicios de terceros no finalizados, hacer Rollback y mostrar mensaje
                    If noFinalizados > 0 Then
                        MessageBox.Show("No se puede Finalizar o Facturar la Orden de Reparación con Servicios de Terceros No Finalizados.")
                        transaction.Rollback()
                        Exit Sub
                    End If
                End If

                ' Si no hay problemas con los servicios, continuar con la modificación de la orden
                Orden.Modificar_OrdenReparacion(id_orden, CInt(cboVehiculo.SelectedValue), txtSeñasParticulares.Text, txtMotivoReparacion.Text,
                             dtpTurno.Value, dtpEntrada.Value, dtpSalida.Value, CInt(cboPersonas.SelectedValue), Convert.ToDecimal(txtMontoRepuestos.Text),
                             Convert.ToDecimal(txtMontoServ3.Text), Convert.ToDecimal(txtMontoManoObra.Text), Convert.ToDecimal(txtMontoTotalOR.Text),
                             Convert.ToBoolean(chkActivo.Checked), CInt(CboTipoReparacion.SelectedValue), CboProgreso.SelectedItem, transaction)

                ' Dar de baja servicios de terceros
                Orden.DarDeBaja_ServiciosTerceros(id_orden, transaction)

                ' Agregar servicios de terceros
                If grdServiciosTerceros.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In grdServiciosTerceros.Rows
                        Dim id_prestador As Integer = Convert.ToInt32(row.Cells("ID_Prestador").Value)
                        Dim servsolicitado As String = row.Cells("ServSolicitado").Value
                        Dim costoestimado As Decimal = Convert.ToDecimal(row.Cells("CostoEstimado").Value)
                        Dim costoreal As Decimal = Convert.ToDecimal(row.Cells("CostoReal").Value)
                        Dim finalizado As Boolean = Convert.ToBoolean(row.Cells("Finalizado").Value)
                        Dim estado As Boolean = Convert.ToBoolean(row.Cells("Estado").Value)

                        Orden.Agregar_Servicio_Terceros(id_orden, dtpEntrada.Value, id_prestador, servsolicitado, costoestimado,
                                                    costoreal, finalizado, estado, transaction)
                    Next
                End If

                ' Dar de baja repuestos de la orden
                Orden.DarDeBajaRepuestos_Ordenes(id_orden, transaction)

                ' Agregar repuestos
                If grdRepuestos.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In grdRepuestos.Rows
                        If Not row.IsNewRow AndAlso row.Cells("id").Value IsNot Nothing Then
                            Dim id_repuestos As Integer = Convert.ToInt32(row.Cells("id").Value)
                            Dim cantidad As Decimal = Convert.ToDecimal(row.Cells("cantidad").Value)
                            Dim precio_rep As Decimal = Convert.ToDecimal(row.Cells("precio").Value)

                            Orden.Agregar_Repuestos_Ordenes(id_repuestos, id_orden, cantidad, precio_rep, 1, transaction)

                            Dim repuestosdata As New AD_Productos
                            Dim stockdisponible As Integer = repuestosdata.Consultar_StockDisponiblePorID(id_repuestos, transaction)
                            stockdisponible -= cantidad

                            ' Actualiza el stock disponible en la base de datos
                            repuestosdata.Modificar_StockDisponiblePorID(id_repuestos, stockdisponible, transaction)
                        End If
                    Next
                End If
                ' Si todo está bien, hacer commit
                transaction.Commit()
                MessageBox.Show("Orden modificada exitosamente.")
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error al modificar la orden: " & ex.Message)
            End Try
        End Using
        btnCancelar.PerformClick()
    End Sub
#End Region

#Region "Facturar"
    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click

    End Sub
#End Region

#Region "Calcular Totales"
    Private Sub ponerDecimales()
        txtCostoEstimadoS3.Text = Convert.ToDecimal(txtCostoEstimadoS3.Text).ToString("N2")
        txtCostoRealS3.Text = Convert.ToDecimal(txtCostoRealS3.Text).ToString("N2")
        txtMontoManoObra.Text = Convert.ToDecimal(txtMontoManoObra.Text).ToString("N2")
        txtMontoRepuestos.Text = Convert.ToDecimal(txtMontoRepuestos.Text).ToString("N2")
        txtMontoServ3.Text = Convert.ToDecimal(txtMontoServ3.Text).ToString("N2")
        txtMontoTotalOR.Text = Convert.ToDecimal(txtMontoTotalOR.Text).ToString("N2")
        txtSubtotal.Text = Convert.ToDecimal(txtSubtotal.Text).ToString("N2")
        txtIVA.Text = Convert.ToDecimal(txtIVA.Text).ToString("N2")
        txtMontoIVA.Text = Convert.ToDecimal(txtMontoIVA.Text).ToString("N2")
        txtCantidadRepOR.Text = Convert.ToDecimal(txtCantidadRepOR.Text).ToString("N2")
    End Sub

    Private Sub CalcularTotalOR()

        txtSubtotal.Text = Convert.ToDecimal(CDec(txtMontoManoObra.Text) + CDec(txtMontoRepuestos.Text) + CDec(txtMontoServ3.Text)).ToString("N2")
        txtMontoIVA.Text = Convert.ToDecimal(CDec(txtSubtotal.Text) * ((CDec(txtIVA.Text).ToString("N2") / 100))).ToString("n2")
        txtMontoTotalOR.Text = Convert.ToDecimal(CDec(txtSubtotal.Text) + (CDec(txtMontoIVA.Text).ToString("N2"))).ToString("N2")

    End Sub

    Private Sub txtMontoManoObra_Leave(sender As Object, e As EventArgs) Handles txtMontoManoObra.Leave
        ponerDecimales()
        CalcularTotalOR()
    End Sub

    Private Sub txtMontoServ3_TextChanged(sender As Object, e As EventArgs) Handles txtMontoServ3.TextChanged
        ponerDecimales()
        CalcularTotalOR()
    End Sub

    Private Sub txtMontoRepuestos_TextChanged(sender As Object, e As EventArgs) Handles txtMontoRepuestos.TextChanged
        ponerDecimales()
        CalcularTotalOR()
    End Sub

    Private Sub ActualizarMontoTotalRep()
        Dim montoTotal As Decimal = 0

        For Each row As DataGridViewRow In grdRepuestos.Rows
            montoTotal += Convert.ToDecimal(row.Cells("Total").Value)
        Next
        txtMontoRepuestos.Text = montoTotal.ToString("F2")
    End Sub

    Private Sub ActualizarMontoTotalS3()
        Dim montoTotal As Decimal = 0

        For Each row As DataGridViewRow In grdServiciosTerceros.Rows
            montoTotal += Convert.ToDecimal(row.Cells("CostoReal").Value)
        Next
        txtMontoServ3.Text = montoTotal.ToString("F2")
    End Sub
#End Region

#Region "Crear PDF"
    Public Sub CrearPDF()
        Dim pdfPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), $"OrdenesReparaciones.pdf")
        Using fs As New FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None)
            Dim document As New Document()
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, fs)
            document.Open()

            ' ENCABEZADO
            Dim encabezado As New PdfPTable(8)
            encabezado.WidthPercentage = 100

            ' Fila 1 a 4 Columnas 1-2-3
            Dim logoPath As String = System.IO.Path.Combine("Imagenes", "mecanicaGaidoLogo-SinFondo.png")
            If File.Exists(logoPath) Then
                Dim logo As Image = Image.GetInstance(logoPath)
                logo.ScaleToFit(140, 120)

                Dim logoCell As New PdfPCell(logo)
                logoCell.Colspan = 3
                logoCell.Rowspan = 4
                logoCell.HorizontalAlignment = Element.ALIGN_CENTER
                logoCell.VerticalAlignment = Element.ALIGN_MIDDLE
                logoCell.Border = PdfPCell.NO_BORDER
                logoCell.BorderWidthTop = 1
                logoCell.BorderWidthLeft = 1
                logoCell.BorderColor = BaseColor.BLACK

                encabezado.AddCell(logoCell)
            Else
                MessageBox.Show("La imagen no se encontró en la ruta especificada.")
            End If

            ' Fila 1 Columna 4 VACIA
            Dim Col4F1 As New PdfPCell(New Phrase(" "))
            Col4F1.Colspan = 1
            Col4F1.Border = PdfPCell.NO_BORDER
            Col4F1.BorderWidthTop = 1
            Col4F1.BorderColorTop = BaseColor.BLACK
            encabezado.AddCell(Col4F1)

            ' Fila 1 Columnas 5-6-7-8
            Dim NumOrdenCell As New PdfPCell(New Paragraph("ORDEN DE REPARACIÓN N° ", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)))
            NumOrdenCell.Colspan = 4
            NumOrdenCell.Border = PdfPCell.NO_BORDER
            NumOrdenCell.BorderWidthTop = 1
            NumOrdenCell.BorderWidthRight = 1
            NumOrdenCell.BorderColor = BaseColor.BLACK
            NumOrdenCell.HorizontalAlignment = Element.ALIGN_LEFT
            encabezado.AddCell(NumOrdenCell)

            ' Fila 2 Columnas 4-5-6 VACIAS
            For col As Integer = 4 To 8
                Dim emptyCell As New PdfPCell(New Phrase(" "))

                If col = 8 Then
                    emptyCell.Border = PdfPCell.NO_BORDER
                    emptyCell.BorderWidthRight = 1
                    emptyCell.BorderColor = BaseColor.BLACK
                Else
                    emptyCell.Border = PdfPCell.NO_BORDER
                End If
                encabezado.AddCell(emptyCell)
            Next

            ' Fila 3 Columnas 4-5-6
            Dim direccionCell As New PdfPCell(New Paragraph("Corrientes 136 - (5940) LAS VARILLAS (Cba.)", FontFactory.GetFont(FontFactory.HELVETICA, 8)))
            direccionCell.Colspan = 3
            direccionCell.Border = PdfPCell.NO_BORDER
            direccionCell.HorizontalAlignment = Element.ALIGN_CENTER
            direccionCell.VerticalAlignment = Element.ALIGN_TOP
            encabezado.AddCell(direccionCell)

            ' Fila 3 Columnas 7-8
            Dim FechaCell As New PdfPCell(New Paragraph("Fecha: " & dtpEntrada.Value.ToString("dd/MM/yyyy"), FontFactory.GetFont(FontFactory.HELVETICA, 10)))
            FechaCell.Colspan = 2
            FechaCell.Border = PdfPCell.NO_BORDER
            FechaCell.BorderWidthRight = 1
            FechaCell.BorderColor = BaseColor.BLACK
            FechaCell.HorizontalAlignment = Element.ALIGN_LEFT
            FechaCell.VerticalAlignment = Element.ALIGN_TOP
            encabezado.AddCell(FechaCell)

            ' Fila 4 Columnas 4-5-6
            Dim telefonoCell As New PdfPCell(New Paragraph("Tel. 03533 420505 / 03533 15419566", FontFactory.GetFont(FontFactory.HELVETICA, 8)))
            telefonoCell.Colspan = 3
            telefonoCell.Border = PdfPCell.NO_BORDER
            telefonoCell.HorizontalAlignment = Element.ALIGN_CENTER
            telefonoCell.VerticalAlignment = Element.ALIGN_TOP
            encabezado.AddCell(telefonoCell)

            ' Fila 4 Columnas 7-8 VACIAS
            For col As Integer = 7 To 8
                Dim emptyCell As New PdfPCell(New Phrase(" "))
                If col = 8 Then
                    emptyCell.Border = PdfPCell.NO_BORDER
                    emptyCell.BorderWidthRight = 1
                    emptyCell.BorderColor = BaseColor.BLACK
                Else
                    emptyCell.Border = PdfPCell.NO_BORDER
                End If
                encabezado.AddCell(emptyCell)
            Next

            ' Fila 5 Columnas 1-2-3
            Dim Dueñocell As New PdfPCell(New Phrase("de Roberto C. Gaido", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11)))
            Dueñocell.Colspan = 3
            Dueñocell.Border = PdfPCell.NO_BORDER
            Dueñocell.BorderWidthLeft = 1
            Dueñocell.BorderColor = BaseColor.BLACK
            Dueñocell.HorizontalAlignment = Element.ALIGN_CENTER
            Dueñocell.VerticalAlignment = Element.ALIGN_TOP
            encabezado.AddCell(Dueñocell)

            ' Fila 5 Columnas 4-5-6
            Dim emailCell As New PdfPCell(New Paragraph("rgaido@lasvarinet.com.ar", FontFactory.GetFont(FontFactory.HELVETICA, 8)))
            emailCell.Colspan = 3
            emailCell.Border = PdfPCell.NO_BORDER
            emailCell.HorizontalAlignment = Element.ALIGN_CENTER
            emailCell.VerticalAlignment = Element.ALIGN_TOP
            encabezado.AddCell(emailCell)

            ' Fila 5 Columnas 7-8
            Dim FechaEntregaCell As New PdfPCell(New Paragraph("Fecha Entrega: " & dtpSalida.Value.ToString("dd/MM/yyyy"), FontFactory.GetFont(FontFactory.HELVETICA, 10)))
            FechaEntregaCell.Colspan = 2
            FechaEntregaCell.Border = PdfPCell.NO_BORDER
            FechaEntregaCell.BorderWidthRight = 1
            FechaEntregaCell.BorderColor = BaseColor.BLACK
            FechaEntregaCell.HorizontalAlignment = Element.ALIGN_LEFT
            FechaEntregaCell.VerticalAlignment = Element.ALIGN_TOP
            encabezado.AddCell(FechaEntregaCell)

            document.Add(encabezado)

            ' CLIENTE
            Dim DatosCliente As New PdfPTable(8)
            DatosCliente.WidthPercentage = 100

            ' Filas 1-2 Columnas 1 a 5
            Dim NombreCelll As New PdfPCell(New Paragraph("  Señor/es: " & nombrePersona, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            NombreCelll.Colspan = 5
            NombreCelll.Rowspan = 2
            NombreCelll.Border = PdfPCell.NO_BORDER
            NombreCelll.BorderWidthLeft = 1
            NombreCelll.BorderWidthTop = 1
            NombreCelll.BorderColor = BaseColor.BLACK
            NombreCelll.HorizontalAlignment = Element.ALIGN_LEFT
            NombreCelll.VerticalAlignment = Element.ALIGN_BOTTOM
            DatosCliente.AddCell(NombreCelll)

            ' Filas 1-2 Columnas 6-7-8
            Dim TelCell As New PdfPCell(New Paragraph("Teléfono: " & telefonoPersona, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            TelCell.Colspan = 3
            TelCell.Rowspan = 2
            TelCell.Border = PdfPCell.NO_BORDER
            TelCell.BorderWidthRight = 1
            TelCell.BorderWidthTop = 1
            TelCell.BorderColor = BaseColor.BLACK
            TelCell.HorizontalAlignment = Element.ALIGN_LEFT
            TelCell.VerticalAlignment = Element.ALIGN_BOTTOM
            DatosCliente.AddCell(TelCell)

            ' Fila 3 Columnas 1 a 4
            Dim DomicilioCell As New PdfPCell(New Paragraph("  Domicilio: " & direccionPersona, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            DomicilioCell.Colspan = 4
            DomicilioCell.Border = PdfPCell.NO_BORDER
            DomicilioCell.BorderWidthLeft = 1
            DomicilioCell.BorderColor = BaseColor.BLACK
            DomicilioCell.HorizontalAlignment = Element.ALIGN_LEFT
            DomicilioCell.VerticalAlignment = Element.ALIGN_CENTER
            DatosCliente.AddCell(DomicilioCell)

            ' Fila 3 Columnas 5 a 8
            Dim LocalidadCell As New PdfPCell(New Paragraph("Localidad: " & localidadPersona, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            LocalidadCell.Colspan = 4
            LocalidadCell.Border = PdfPCell.NO_BORDER
            LocalidadCell.BorderWidthRight = 1
            LocalidadCell.BorderColor = BaseColor.BLACK
            LocalidadCell.HorizontalAlignment = Element.ALIGN_LEFT
            LocalidadCell.VerticalAlignment = Element.ALIGN_CENTER
            DatosCliente.AddCell(LocalidadCell)

            ' Filas 4-5 Columna 1
            Dim IVACell As New PdfPCell(New Paragraph("  IVA", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            IVACell.Colspan = 1
            IVACell.Rowspan = 2
            IVACell.Border = PdfPCell.NO_BORDER
            IVACell.BorderWidthLeft = 1
            IVACell.HorizontalAlignment = Element.ALIGN_LEFT
            IVACell.VerticalAlignment = Element.ALIGN_TOP
            DatosCliente.AddCell(IVACell)

            ' Filas 4-5 Columna 2-3
            Dim InscCell As New PdfPCell(New Paragraph("Inscripto  [   ]", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            InscCell.Colspan = 2
            InscCell.Rowspan = 2
            InscCell.Border = PdfPCell.NO_BORDER
            InscCell.HorizontalAlignment = Element.ALIGN_LEFT
            InscCell.VerticalAlignment = Element.ALIGN_TOP
            DatosCliente.AddCell(InscCell)

            ' Filas 4-5 Columna 4-5
            Dim MonotributoCell As New PdfPCell(New Paragraph("Monotributo  [   ]", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            MonotributoCell.Colspan = 2
            MonotributoCell.Rowspan = 2
            MonotributoCell.Border = PdfPCell.NO_BORDER
            MonotributoCell.HorizontalAlignment = Element.ALIGN_LEFT
            MonotributoCell.VerticalAlignment = Element.ALIGN_TOP
            DatosCliente.AddCell(MonotributoCell)

            ' Filas 4-5 Columnas 6-7-8
            Dim CuitCell As New PdfPCell(New Paragraph("CUIT: " & cuitPersona, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            CuitCell.Colspan = 3
            CuitCell.Rowspan = 2
            CuitCell.Border = PdfPCell.NO_BORDER
            CuitCell.BorderWidthRight = 1
            CuitCell.BorderColor = BaseColor.BLACK
            CuitCell.HorizontalAlignment = Element.ALIGN_LEFT
            CuitCell.VerticalAlignment = Element.ALIGN_TOP
            DatosCliente.AddCell(CuitCell)

            ' Fila VACIA
            Dim filaVaciaCliente As New PdfPCell(New Paragraph(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            filaVaciaCliente.Colspan = 8
            filaVaciaCliente.Border = PdfPCell.NO_BORDER
            filaVaciaCliente.BorderWidthBottom = 1
            filaVaciaCliente.BorderWidthLeft = 1
            filaVaciaCliente.BorderWidthRight = 1
            filaVaciaCliente.BorderColor = BaseColor.BLACK
            filaVaciaCliente.FixedHeight = 5.0F
            DatosCliente.AddCell(filaVaciaCliente)

            document.Add(DatosCliente)

            ' VEHICULO
            Dim DatosVehículo As New PdfPTable(8)
            DatosVehículo.WidthPercentage = 100

            ' Fila 1 VACIA
            Dim SeparadorTabla As New PdfPCell(New Paragraph(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            SeparadorTabla.Colspan = 8
            SeparadorTabla.Border = PdfPCell.NO_BORDER
            DatosVehículo.AddCell(SeparadorTabla)

            ' Filas 2-3 Columnas 1 a 4
            Dim MarcaCell As New PdfPCell(New Phrase("  Marca: " & marcaVehiculo, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            MarcaCell.Colspan = 4
            MarcaCell.Rowspan = 2
            MarcaCell.Border = PdfPCell.NO_BORDER
            MarcaCell.BorderWidthTop = 1
            MarcaCell.BorderWidthLeft = 1
            MarcaCell.BorderColor = BaseColor.BLACK
            MarcaCell.HorizontalAlignment = Element.ALIGN_LEFT
            MarcaCell.VerticalAlignment = Element.ALIGN_BOTTOM
            DatosVehículo.AddCell(MarcaCell)

            ' Filas 2-3 Columnas 5-6
            Dim ModeloCell As New PdfPCell(New Paragraph("Modelo: " & modeloVehiculo, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            ModeloCell.Colspan = 2
            ModeloCell.Rowspan = 2
            ModeloCell.Border = PdfPCell.NO_BORDER
            ModeloCell.BorderWidthTop = 1
            ModeloCell.HorizontalAlignment = Element.ALIGN_LEFT
            ModeloCell.VerticalAlignment = Element.ALIGN_BOTTOM
            DatosVehículo.AddCell(ModeloCell)

            ' Filas 2-3 Columnas 7-8
            Dim HorasCell As New PdfPCell(New Paragraph("Horas: " & horasVehiculo, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            HorasCell.Colspan = 2
            HorasCell.Rowspan = 2
            HorasCell.Border = PdfPCell.NO_BORDER
            HorasCell.BorderWidthTop = 1
            HorasCell.BorderWidthRight = 1
            HorasCell.BorderColor = BaseColor.BLACK
            HorasCell.HorizontalAlignment = Element.ALIGN_LEFT
            HorasCell.VerticalAlignment = Element.ALIGN_BOTTOM
            DatosVehículo.AddCell(HorasCell)

            ' Fila 4 Columnas 1 a 4
            Dim ChasisCell As New PdfPCell(New Phrase("  Chasis: " & chasisVehiculo, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            ChasisCell.Colspan = 4
            ChasisCell.Border = PdfPCell.NO_BORDER
            ChasisCell.BorderWidthLeft = 1
            ChasisCell.BorderColor = BaseColor.BLACK
            ChasisCell.HorizontalAlignment = Element.ALIGN_LEFT
            ChasisCell.VerticalAlignment = Element.ALIGN_BOTTOM
            DatosVehículo.AddCell(ChasisCell)

            ' Fila 4 Columnas 5-6
            Dim MotorCell As New PdfPCell(New Paragraph("Motor: ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            MotorCell.Colspan = 2
            MotorCell.Border = PdfPCell.NO_BORDER
            MotorCell.HorizontalAlignment = Element.ALIGN_LEFT
            MotorCell.VerticalAlignment = Element.ALIGN_BOTTOM
            DatosVehículo.AddCell(MotorCell)

            ' Fila 4 Columnas 7-8
            Dim NumCell As New PdfPCell(New Paragraph("N°: " & numMotorVehiculo, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            NumCell.Colspan = 2
            NumCell.Border = PdfPCell.NO_BORDER
            NumCell.BorderWidthRight = 1
            NumCell.BorderColor = BaseColor.BLACK
            NumCell.HorizontalAlignment = Element.ALIGN_LEFT
            NumCell.VerticalAlignment = Element.ALIGN_TOP
            DatosVehículo.AddCell(NumCell)

            ' Fila VACIA
            Dim filaVaciaVehiculo As New PdfPCell(New Paragraph(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            filaVaciaVehiculo.Colspan = 8
            filaVaciaVehiculo.Border = PdfPCell.NO_BORDER
            filaVaciaVehiculo.BorderWidthBottom = 1
            filaVaciaVehiculo.BorderWidthLeft = 1
            filaVaciaVehiculo.BorderWidthRight = 1
            filaVaciaVehiculo.BorderColor = BaseColor.BLACK
            filaVaciaVehiculo.FixedHeight = 5.0F
            DatosVehículo.AddCell(filaVaciaVehiculo)

            document.Add(DatosVehículo)

            ' TRABAJOS A REALIZAR
            Dim TablaTrabajos As New PdfPTable(6)
            TablaTrabajos.WidthPercentage = 100

            ' Fila 1 VACIA
            Dim FilaVaciaTrabajos As New PdfPCell(New Paragraph(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            FilaVaciaTrabajos.Colspan = 6
            FilaVaciaTrabajos.Border = PdfPCell.NO_BORDER
            TablaTrabajos.AddCell(FilaVaciaTrabajos)

            ' Ancho de las columnas
            Dim anchoColumnasTrabajos As Single() = New Single() {0.8F, 2.5F, 0.5F, 2.5F, 1.5F, 1.2F}
            TablaTrabajos.SetWidths(anchoColumnasTrabajos)
            ' Altura de las filas
            Dim filaTrabajos As Single = 15.0F

            ' Fila 2 Columnas 1 a 4
            Dim TrabajosCell As PdfPCell = New PdfPCell(New Phrase("TRABAJOS A REALIZAR", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.Bold, BaseColor.WHITE)))
            TrabajosCell.Colspan = 4
            TrabajosCell.Border = PdfPCell.BOX
            TrabajosCell.BorderColor = BaseColor.BLACK
            TrabajosCell.BorderWidth = 1
            TrabajosCell.HorizontalAlignment = Element.ALIGN_CENTER
            TrabajosCell.BackgroundColor = New BaseColor(46, 139, 87)
            TablaTrabajos.AddCell(TrabajosCell)

            ' Fila 2 Columnas 5-6
            Dim ImporteCell As PdfPCell = New PdfPCell(New Phrase("IMPORTE", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.Bold, BaseColor.WHITE)))
            ImporteCell.Colspan = 2
            ImporteCell.Border = PdfPCell.BOX
            ImporteCell.BorderColor = BaseColor.BLACK
            ImporteCell.BorderWidth = 1
            ImporteCell.HorizontalAlignment = Element.ALIGN_CENTER
            ImporteCell.BackgroundColor = New BaseColor(46, 139, 87)
            TablaTrabajos.AddCell(ImporteCell)

            ' Filas 3 a 10  
            For i As Integer = 1 To 9
                ' Columnas 1 a 4 VACIAS
                Dim VaciasTrabajos As New PdfPCell(New Phrase(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
                VaciasTrabajos.Colspan = 4
                VaciasTrabajos.FixedHeight = filaTrabajos
                VaciasTrabajos.Border = PdfPCell.LEFT_BORDER Or PdfPCell.RIGHT_BORDER Or PdfPCell.BOTTOM_BORDER
                VaciasTrabajos.BorderWidthLeft = 1
                VaciasTrabajos.BorderWidthRight = 1
                VaciasTrabajos.BorderWidthBottom = 0.5F
                TablaTrabajos.AddCell(VaciasTrabajos)

                ' Columnas 5-6 VACIAS
                For j As Integer = 1 To 2
                    Dim VaciasImporte As New PdfPCell(New Phrase(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
                    VaciasImporte.FixedHeight = filaTrabajos
                    VaciasImporte.Border = PdfPCell.LEFT_BORDER Or PdfPCell.RIGHT_BORDER Or PdfPCell.BOTTOM_BORDER
                    VaciasImporte.BorderWidthLeft = 1
                    VaciasImporte.BorderWidthRight = 1
                    VaciasImporte.BorderWidthBottom = 0.5F
                    TablaTrabajos.AddCell(VaciasImporte)
                Next
            Next

            ' Fila 11 Columnas 1 a 4 BORDES
            Dim TrabajosColspanFinalCell As New PdfPCell(New Phrase(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            TrabajosColspanFinalCell.Colspan = 4
            TrabajosColspanFinalCell.FixedHeight = filaTrabajos
            TrabajosColspanFinalCell.Border = PdfPCell.LEFT_BORDER Or PdfPCell.RIGHT_BORDER Or PdfPCell.BOTTOM_BORDER
            TrabajosColspanFinalCell.BorderColor = BaseColor.BLACK
            TrabajosColspanFinalCell.BorderWidthLeft = 1
            TrabajosColspanFinalCell.BorderWidthRight = 1
            TrabajosColspanFinalCell.BorderWidthBottom = 1
            TablaTrabajos.AddCell(TrabajosColspanFinalCell)

            ' Fila 11 Columnas 5-6 BORDES
            For j As Integer = 1 To 2
                Dim ImporteFinalCell As New PdfPCell(New Phrase(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
                ImporteFinalCell.FixedHeight = filaTrabajos
                ImporteFinalCell.Border = PdfPCell.LEFT_BORDER Or PdfPCell.RIGHT_BORDER Or PdfPCell.BOTTOM_BORDER
                ImporteFinalCell.BorderColor = BaseColor.BLACK
                ImporteFinalCell.BorderWidthLeft = 1
                ImporteFinalCell.BorderWidthRight = 1
                ImporteFinalCell.BorderWidthBottom = 1
                TablaTrabajos.AddCell(ImporteFinalCell)
            Next

            document.Add(TablaTrabajos)

            ' SERVICIOS 3EROS
            Dim TablaTerceros As New PdfPTable(6)
            TablaTerceros.WidthPercentage = 100

            ' Ancho de las columnas
            Dim anchoColumnasTerceros As Single() = New Single() {0.8F, 2.5F, 0.5F, 2.5F, 1.5F, 1.2F}
            TablaTerceros.SetWidths(anchoColumnasTerceros)
            ' Altura de las filas
            Dim AltoFilaTercero As Single = 15.0F

            ' Fila 1 VACIA
            Dim FilaVaciaTerceros As New PdfPCell(New Paragraph(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            FilaVaciaTerceros.Colspan = 6
            FilaVaciaTerceros.Border = PdfPCell.NO_BORDER
            TablaTerceros.AddCell(FilaVaciaTerceros)

            ' Fila 2 Columnas 1 a 6
            Dim TercerosCell As PdfPCell = New PdfPCell(New Phrase("MANO DE OBRA DE TERCEROS", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            TercerosCell.Colspan = 6
            TercerosCell.HorizontalAlignment = Element.ALIGN_CENTER
            TercerosCell.Border = PdfPCell.BOX
            TercerosCell.BorderColor = BaseColor.BLACK
            TercerosCell.BorderWidth = 1
            TablaTerceros.AddCell(TercerosCell)

            ' Filas 3 a 8 VACIAS BORDES
            For i As Integer = 1 To 6
                For j As Integer = 1 To 6
                    Dim VaciasTerceros As New PdfPCell(New Phrase(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
                    VaciasTerceros.FixedHeight = filaTrabajos
                    VaciasTerceros.Border = PdfPCell.NO_BORDER
                    VaciasTerceros.BorderColorLeft = BaseColor.BLACK
                    VaciasTerceros.BorderWidthLeft = 1.0F
                    VaciasTerceros.BorderWidthBottom = 0.5F

                    VaciasTerceros.BorderColorBottom = BaseColor.BLACK


                    If j = 6 Then
                        VaciasTerceros.BorderColorRight = BaseColor.BLACK
                        VaciasTerceros.BorderWidthRight = 1.0F
                    End If
                    ' Añadir celdas a la tabla
                    TablaTerceros.AddCell(VaciasTerceros)
                Next
            Next

            ' Fila 9 VACIA BORDES
            For j As Integer = 1 To 6
                If j = 6 Then
                    Dim VaciasTercerosUltima As New PdfPCell(New Phrase(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
                    VaciasTercerosUltima.FixedHeight = filaTrabajos
                    VaciasTercerosUltima.Border = PdfPCell.NO_BORDER
                    VaciasTercerosUltima.BorderWidthLeft = 1.0F
                    VaciasTercerosUltima.BorderWidthRight = 1.0F
                    VaciasTercerosUltima.BorderWidthBottom = 1.0F
                    TablaTerceros.AddCell(VaciasTercerosUltima)
                Else
                    Dim VaciasTercerosUltima As New PdfPCell(New Phrase(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
                    VaciasTercerosUltima.FixedHeight = filaTrabajos
                    VaciasTercerosUltima.Border = PdfPCell.NO_BORDER
                    VaciasTercerosUltima.BorderWidthLeft = 1.0F
                    VaciasTercerosUltima.BorderWidthBottom = 1.0F
                    TablaTerceros.AddCell(VaciasTercerosUltima)
                End If
            Next

            ' Fila 10 Columnas 1 a 5
            Dim TotalMOTCell As PdfPCell = New PdfPCell(New Phrase("TOTAL MANO DE OBRA DE TERCEROS", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            TotalMOTCell.Colspan = 5
            TotalMOTCell.HorizontalAlignment = Element.ALIGN_CENTER
            TotalMOTCell.Border = PdfPCell.NO_BORDER
            TotalMOTCell.BorderWidthLeft = 1
            TotalMOTCell.BorderWidthRight = 1
            TotalMOTCell.BorderWidthBottom = 1
            TotalMOTCell.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(TotalMOTCell)

            ' Fila 10 Columna 6 VACIA
            Dim f10Vacia As PdfPCell = New PdfPCell(New Phrase(txtMontoServ3.Text, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            f10Vacia.HorizontalAlignment = Element.ALIGN_CENTER
            f10Vacia.Border = PdfPCell.NO_BORDER
            f10Vacia.BorderWidthRight = 1
            f10Vacia.BorderWidthBottom = 1
            f10Vacia.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(f10Vacia)

            ' Filas 11-12-13 Columnas 1-2-3
            Dim ObservacionesCell As PdfPCell = New PdfPCell(New Phrase("OBSERVACIONES:", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            ObservacionesCell.Colspan = 3
            ObservacionesCell.Rowspan = 3
            ObservacionesCell.HorizontalAlignment = Element.ALIGN_LEFT
            ObservacionesCell.VerticalAlignment = Element.ALIGN_TOP
            ObservacionesCell.Border = PdfPCell.NO_BORDER
            ObservacionesCell.BorderWidthLeft = 1
            ObservacionesCell.BorderWidthRight = 1
            ObservacionesCell.BorderWidthBottom = 1
            ObservacionesCell.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(ObservacionesCell)

            ' Fila 11 Columnas 4-5
            Dim ManoObra As PdfPCell = New PdfPCell(New Phrase("Total Mano de Obra", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            ManoObra.Colspan = 2
            ManoObra.HorizontalAlignment = Element.ALIGN_LEFT
            ManoObra.Border = PdfPCell.NO_BORDER
            ManoObra.BorderWidthRight = 1
            ManoObra.BorderWidthBottom = 1
            ManoObra.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(ManoObra)

            ' Fila 11 Columna 6 VACIA
            Dim F11C6 As New PdfPCell(New Paragraph(txtMontoManoObra.Text, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            F11C6.Border = PdfPCell.NO_BORDER
            F11C6.BorderWidthRight = 1
            F11C6.BorderWidthBottom = 1
            F11C6.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(F11C6)

            ' Fila 12 Columnas 4-5
            Dim RepLubricante As PdfPCell = New PdfPCell(New Phrase("Total Rep y Lubricantes", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            RepLubricante.Colspan = 2
            RepLubricante.HorizontalAlignment = Element.ALIGN_LEFT
            RepLubricante.Border = PdfPCell.NO_BORDER
            RepLubricante.BorderWidthRight = 1
            RepLubricante.BorderWidthBottom = 1
            RepLubricante.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(RepLubricante)

            ' Fila 12 Columna 6 VACIA
            Dim F12C6 As New PdfPCell(New Paragraph(txtMontoRepuestos.Text, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            F12C6.Border = PdfPCell.NO_BORDER
            F12C6.BorderWidthRight = 1
            F12C6.BorderWidthBottom = 1
            F12C6.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(F12C6)

            ' Fila 13 Columnas 4-5
            Dim ManoObraTerceros As PdfPCell = New PdfPCell(New Phrase("Total Mano de Obra de Terceros", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            ManoObraTerceros.Colspan = 2
            ManoObraTerceros.HorizontalAlignment = Element.ALIGN_LEFT
            ManoObraTerceros.Border = PdfPCell.NO_BORDER
            ManoObraTerceros.BorderWidthRight = 1
            ManoObraTerceros.BorderWidthBottom = 1
            ManoObraTerceros.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(ManoObraTerceros)

            ' Fila 13 Columna 6 VACIA
            Dim F13C6 As New PdfPCell(New Paragraph(txtMontoServ3.Text, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            F13C6.Border = PdfPCell.NO_BORDER
            F13C6.BorderWidthRight = 1
            F13C6.BorderWidthBottom = 1
            F13C6.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(F13C6)

            ' Filas 14-15-16 Columnas 1-2-3
            Dim AutorizoCell As PdfPCell = New PdfPCell(New Phrase("Autorizo el trabajo descripto y acepto las condiciones", FontFactory.GetFont(FontFactory.HELVETICA, 9)))
            AutorizoCell.Colspan = 3
            AutorizoCell.Rowspan = 3
            AutorizoCell.HorizontalAlignment = Element.ALIGN_LEFT
            AutorizoCell.VerticalAlignment = Element.ALIGN_TOP
            AutorizoCell.Border = PdfPCell.NO_BORDER
            AutorizoCell.BorderWidthLeft = 1
            AutorizoCell.BorderWidthRight = 1
            AutorizoCell.BorderWidthBottom = 1
            AutorizoCell.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(AutorizoCell)

            ' Fila 14 Columnas 4-5
            Dim PrecioKm As PdfPCell = New PdfPCell(New Phrase("..... Km a $ ..... x Km ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            PrecioKm.Colspan = 2
            PrecioKm.HorizontalAlignment = Element.ALIGN_LEFT
            PrecioKm.Border = PdfPCell.NO_BORDER
            PrecioKm.BorderWidthRight = 1
            PrecioKm.BorderWidthBottom = 1
            PrecioKm.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(PrecioKm)

            ' Fila 14 Columna 6 VACIA
            Dim F14C6 As New PdfPCell(New Paragraph(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            F14C6.Border = PdfPCell.NO_BORDER
            F14C6.BorderWidthRight = 1
            F14C6.BorderWidthBottom = 1
            F14C6.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(F14C6)

            ' Fila 15 Columnas 4-5
            Dim SubTotal As PdfPCell = New PdfPCell(New Phrase("Sub Total ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            SubTotal.Colspan = 2
            SubTotal.HorizontalAlignment = Element.ALIGN_LEFT
            SubTotal.Border = PdfPCell.NO_BORDER
            SubTotal.BorderWidthRight = 1
            SubTotal.BorderWidthBottom = 1
            SubTotal.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(SubTotal)

            ' Fila 15 Columna 6 VACIA
            Dim F15C6 As New PdfPCell(New Paragraph(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            F15C6.Border = PdfPCell.NO_BORDER
            F15C6.BorderWidthRight = 1
            F15C6.BorderWidthBottom = 1
            F15C6.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(F15C6)

            ' Fila 16 Columnas 4-5
            Dim IVA As PdfPCell = New PdfPCell(New Phrase("IVA    % ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            IVA.Colspan = 2
            IVA.HorizontalAlignment = Element.ALIGN_LEFT
            IVA.Border = PdfPCell.NO_BORDER
            IVA.BorderWidthRight = 1
            IVA.BorderWidthBottom = 1
            IVA.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(IVA)

            ' Fila 16 Columna 6 VACIA
            Dim F16C6 As New PdfPCell(New Paragraph(" ", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            F16C6.Border = PdfPCell.NO_BORDER
            F16C6.BorderWidthRight = 1
            F16C6.BorderWidthBottom = 1
            F16C6.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(F16C6)

            ' Fila 17 Columnas 1-2-3
            Dim RecibiCell As PdfPCell = New PdfPCell(New Phrase("Recibí conforme la unidad reparada", FontFactory.GetFont(FontFactory.HELVETICA, 9)))
            RecibiCell.Colspan = 3
            RecibiCell.HorizontalAlignment = Element.ALIGN_LEFT
            RecibiCell.VerticalAlignment = Element.ALIGN_TOP
            RecibiCell.Border = PdfPCell.NO_BORDER
            RecibiCell.BorderWidthLeft = 1
            RecibiCell.BorderWidthRight = 1
            RecibiCell.BorderWidthBottom = 1
            RecibiCell.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(RecibiCell)

            ' Fila 17 Columnas 4-5
            Dim ImpTotal As PdfPCell = New PdfPCell(New Phrase("IMPORTE TOTAL", FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            ImpTotal.Colspan = 2
            ImpTotal.HorizontalAlignment = Element.ALIGN_LEFT
            ImpTotal.Border = PdfPCell.NO_BORDER
            ImpTotal.BorderWidthRight = 1
            ImpTotal.BorderWidthBottom = 1
            ImpTotal.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(ImpTotal)

            ' Fila 17 Columna 6 VACIA
            Dim F17C6 As New PdfPCell(New Paragraph(txtMontoTotalOR.Text, FontFactory.GetFont(FontFactory.HELVETICA, 11)))
            F17C6.Border = PdfPCell.NO_BORDER
            F17C6.BorderWidthRight = 1
            F17C6.BorderWidthBottom = 1
            F17C6.BorderColor = BaseColor.BLACK
            TablaTerceros.AddCell(F17C6)

            document.Add(TablaTerceros)

            ' Salto de página
            document.NewPage()

            ' PRODUCTOS
            Dim TablaProductos As New PdfPTable(6)
            TablaProductos.WidthPercentage = 100

            ' Ancho de las columnas
            Dim anchoColumnasTProd As Single() = New Single() {0.8F, 1.0F, 0.5F, 4.3F, 1.2F, 1.2F}
            TablaProductos.SetWidths(anchoColumnasTProd)
            ' Altura de las filas
            Dim rowHeight As Single = 15.0F

            ' Fila 1 Columnas 1 a 4
            Dim cellRepuestos As PdfPCell = New PdfPCell(New Phrase("REPUESTOS UTILIZADOS", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.Bold, BaseColor.WHITE)))
            cellRepuestos.Colspan = 4
            cellRepuestos.HorizontalAlignment = Element.ALIGN_CENTER
            cellRepuestos.BackgroundColor = New BaseColor(46, 139, 87)
            TablaProductos.AddCell(cellRepuestos)

            ' Fila 1 Columnas 5-6
            Dim cellTotal As PdfPCell = New PdfPCell(New Phrase("TOTAL", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.Bold, BaseColor.WHITE)))
            cellTotal.Colspan = 2
            cellTotal.HorizontalAlignment = Element.ALIGN_CENTER
            cellTotal.BackgroundColor = New BaseColor(46, 139, 87)
            TablaProductos.AddCell(cellTotal)

            ' Fila 2 
            Dim titles() As String = {"CANT.", "PIEZA N°", "C", "DESCRIPCIÓN", "PRECIO", "TOTAL"}
            For Each title In titles
                Dim cell As New PdfPCell(New Phrase(title, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)))
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                TablaProductos.AddCell(cell)
            Next

            ' Añadir las filas de la grilla (grdRepuestos)
            Dim numFilas As Integer = grdRepuestos.Rows.Count
            For i As Integer = 0 To numFilas - 1
                Dim cantidad As String = grdRepuestos.Rows(i).Cells("Cantidad").Value.ToString()

                ' Separar el valor concatenado "CodFabricante - Descripcion"
                Dim descripcionCompleta As String = grdRepuestos.Rows(i).Cells("Descripcion").Value.ToString()
                Dim partesDescripcion() As String = descripcionCompleta.Split("-"c)

                ' Asignar cada parte a las variables correspondientes
                Dim piezaNro As String = partesDescripcion(0) ' Esto es CodFabricante
                Dim descripcion As String = partesDescripcion(1) ' Esto es Descripcion

                Dim precioUnitario As String = Convert.ToDecimal(grdRepuestos.Rows(i).Cells("Precio").Value).ToString("N2")
                Dim importe As String = Convert.ToDecimal(grdRepuestos.Rows(i).Cells("Total").Value).ToString("N2")

                ' Añadir las celdas a la tabla
                TablaProductos.AddCell(New PdfPCell(New Phrase(cantidad, FontFactory.GetFont(FontFactory.HELVETICA, 8))) With {.HorizontalAlignment = Element.ALIGN_CENTER})
                TablaProductos.AddCell(New PdfPCell(New Phrase(piezaNro, FontFactory.GetFont(FontFactory.HELVETICA, 8))) With {.HorizontalAlignment = Element.ALIGN_CENTER}) ' Aquí se coloca CodFabricante
                TablaProductos.AddCell(New PdfPCell(New Phrase(" ", FontFactory.GetFont(FontFactory.HELVETICA, 8))) With {.HorizontalAlignment = Element.ALIGN_CENTER})
                TablaProductos.AddCell(New PdfPCell(New Phrase(descripcion, FontFactory.GetFont(FontFactory.HELVETICA, 8))) With {.HorizontalAlignment = Element.ALIGN_LEFT}) ' Aquí se coloca la descripción
                TablaProductos.AddCell(New PdfPCell(New Phrase(precioUnitario, FontFactory.GetFont(FontFactory.HELVETICA, 8))) With {.HorizontalAlignment = Element.ALIGN_RIGHT})
                TablaProductos.AddCell(New PdfPCell(New Phrase(importe, FontFactory.GetFont(FontFactory.HELVETICA, 8))) With {.HorizontalAlignment = Element.ALIGN_RIGHT})
            Next

            ' Calcular cuántas filas vacías se pueden agregar sin exceder el límite de una página
            Dim maxFilasPorPagina As Integer = 48 ' Número de filas que caben en una página
            Dim filasRestantes As Integer = maxFilasPorPagina - numFilas

            ' Añadir las filas vacías restantes
            For i As Integer = 1 To filasRestantes
                For j As Integer = 1 To 6
                    Dim emptyCell As New PdfPCell(New Phrase(" ", FontFactory.GetFont(FontFactory.HELVETICA, 10)))
                    emptyCell.FixedHeight = rowHeight
                    TablaProductos.AddCell(emptyCell)
                Next
            Next

            ' Fila final
            Dim cellTotalRepuestos As PdfPCell = New PdfPCell(New Phrase("TOTAL DE REPUESTOS Y LUBRICANTES", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)))
            cellTotalRepuestos.Colspan = 5
            cellTotalRepuestos.HorizontalAlignment = Element.ALIGN_CENTER
            TablaProductos.AddCell(cellTotalRepuestos)

            Dim lastCell As New PdfPCell(New Phrase(txtMontoRepuestos.Text, FontFactory.GetFont(FontFactory.HELVETICA, 10)))
            lastCell.FixedHeight = rowHeight
            TablaProductos.AddCell(lastCell)

            document.Add(TablaProductos)
            document.Close()
        End Using

        MessageBox.Show("PDF creado exitosamente en: " & pdfPath)
    End Sub

    Private Sub btnDescargarPDF_Click(sender As Object, e As EventArgs) Handles btnDescargarPDF.Click
        CrearPDF()
    End Sub
#End Region

    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        frmMenuPrincipal.btnPersonas.PerformClick()
    End Sub

    Private Sub btnAgregarVehiculo_Click(sender As Object, e As EventArgs) Handles btnAgregarVehiculo.Click
        persona = cboPersonas.SelectedValue
        frmMenuPrincipal.btnVehiculos.PerformClick()
        frmVehiculos.cboPersona.SelectedValue = persona
    End Sub

#Region "Focus txt"
    Private Sub txtCostoEstimadoS3_GotFocus(sender As Object, e As EventArgs) Handles txtCostoEstimadoS3.GotFocus
        txtCostoEstimadoS3.SelectAll()
    End Sub

    Private Sub txtCostoEstimado_LostFocus(sender As Object, e As EventArgs) Handles txtCostoEstimadoS3.LostFocus
        txtCostoEstimadoS3.Text = Convert.ToDecimal(txtCostoEstimadoS3.Text).ToString("N2")
        txtCostoRealS3.Text = Convert.ToDecimal(txtCostoEstimadoS3.Text).ToString("N2")
    End Sub

    Private Sub txtCostoRealS3_GotFocus(sender As Object, e As EventArgs) Handles txtCostoRealS3.GotFocus
        txtCostoRealS3.SelectAll()
    End Sub

    Private Sub txtMontoManoObra_LostFocus(sender As Object, e As EventArgs) Handles txtMontoManoObra.LostFocus
        Dim mmo As Decimal
        If String.IsNullOrWhiteSpace(txtMontoManoObra.Text) Then
            ' Si está vacío, asigna un valor predeterminado (opcional) o simplemente regresa
            txtMontoManoObra.Text = "0.00"
            Return
        End If

        If Decimal.TryParse(txtMontoManoObra.Text, mmo) Then
            txtMontoManoObra.Text = mmo.ToString("N2")
        Else
            txtMontoManoObra.Text = Convert.ToDecimal(0).ToString("N2")
        End If
    End Sub

    Private Sub txtMontoManoObra_GotFocus(sender As Object, e As EventArgs) Handles txtMontoManoObra.GotFocus
        txtMontoManoObra.SelectAll()
    End Sub
#End Region

#Region "Keypress"
    Private Sub txtSeñasParticulares_KeyPress(sender As Object, e As KeyPressEventArgs)
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
    Private Sub PanelDetallesOrden_Paint(sender As Object, e As PaintEventArgs) Handles PanelDetallesOrden.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New System.Drawing.Rectangle(0, 0, PanelDetallesOrden.Width - 1, PanelDetallesOrden.Height - 1)

            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelInfoVehiculo_Paint(sender As Object, e As PaintEventArgs) Handles PanelInfoVehiculo.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New System.Drawing.Rectangle(0, 0, PanelInfoVehiculo.Width - 1, PanelInfoVehiculo.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelCostos_Paint(sender As Object, e As PaintEventArgs) Handles PanelCostos.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New System.Drawing.Rectangle(0, 0, PanelCostos.Width - 1, PanelCostos.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelDetalleDeRepuestos_Paint(sender As Object, e As PaintEventArgs) Handles PanelDetalleDeRepuestos.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New System.Drawing.Rectangle(0, 0, PanelDetalleDeRepuestos.Width - 1, PanelDetalleDeRepuestos.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelServiciosTerceros_Paint(sender As Object, e As PaintEventArgs) Handles PanelServiciosTerceros.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New System.Drawing.Rectangle(0, 0, PanelServiciosTerceros.Width - 1, PanelServiciosTerceros.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelReparaciones_Paint(sender As Object, e As PaintEventArgs) Handles PanelReparaciones.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New System.Drawing.Rectangle(0, 0, PanelReparaciones.Width - 1, PanelReparaciones.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub
#End Region
End Class