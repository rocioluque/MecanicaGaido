Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmOrdenesReparacion

    Dim o_Orden As New AD_OrdenReparacion

#Region "Procedimientos"
    Private Sub cboPersonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPersonas.SelectedIndexChanged
        If combopersonacargado Then
            Try
                Dim ID_Persona = cboPersonas.SelectedValue
                cboVehiculo.Items.Clear()
                Cargar_Combo_Vehiculos(ID_Persona)
            Catch ex As Exception
                MsgBox("Error al cargar vehículos: " & ex.Message, vbCritical, "Error")

            End Try
        End If
    End Sub
    Public Sub limpiar()
        txtID.Clear()
        txtSeñasParticulares.Clear()
        txtMotivoReparacion.Clear()
        cboPersonas.SelectedIndex = -1
        CboPersonaServ3.SelectedIndex = -1
        cboVehiculo.SelectedIndex = -1
        chkActivo.Checked = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiarServ3()
        limpiar()
        grdRepuestos.Rows.Clear()
        ActualizarMontoTotalRep()
        ActualizarMontoTotalS3()
        txtMontoManoObra.Text = Convert.ToDecimal(0).ToString("N2")
    End Sub

    Private Sub frmOrdenesReparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cargar_Combo_Personas()
        Cargar_Combo_Prestador()
        Cargar_Combo_Repuestos()
        Cargar_Grilla_Ordenes()
        limpiar()
        ponerDecimales()

    End Sub





#End Region

#Region "Repuestos"

    Private Sub DataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles grdRepuestos.CellValidating
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


#End Region

#Region "Cargar cbo"

    Private Sub Cargar_Combo_Vehiculos(ID_Persona)
        Try
            Dim tabla As DataTable = o_Orden.Cargar_Combo_Vehiculos(ID_Persona)

            If tabla.Rows.Count > 0 Then
                cboVehiculo.DataSource = tabla
                cboVehiculo.DisplayMember = "Nombre"
                cboVehiculo.ValueMember = "ID_Vehiculo"
                cboVehiculo.SelectedValue = -1
            Else
                MsgBox("No se encontraron Vehiculos para esta persona.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Vehiculos: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private combopersonacargado = False
    Private Sub Cargar_Combo_Personas()
        Try
            Dim tabla As DataTable = o_Orden.Cargar_Combo_Personas()

            If tabla.Rows.Count > 0 Then
                cboPersonas.DataSource = tabla
                cboPersonas.DisplayMember = "Persona"
                cboPersonas.ValueMember = "ID_Persona"
                cboPersonas.SelectedValue = -1
            Else
                MsgBox("No se encontraron personas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las personas: " & ex.Message, vbCritical, "Error")
        End Try
        combopersonacargado = True
    End Sub

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
            Dim rect As New Rectangle(0, 0, PanelDetallesOrden.Width - 1, PanelDetallesOrden.Height - 1)
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
            Dim rect As New Rectangle(0, 0, PanelInfoVehiculo.Width - 1, PanelInfoVehiculo.Height - 1)
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
            Dim rect As New Rectangle(0, 0, PanelCostos.Width - 1, PanelCostos.Height - 1)
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
            Dim rect As New Rectangle(0, 0, PanelDetalleDeRepuestos.Width - 1, PanelDetalleDeRepuestos.Height - 1)
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
            Dim rect As New Rectangle(0, 0, PanelServiciosTerceros.Width - 1, PanelServiciosTerceros.Height - 1)
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
            Dim rect As New Rectangle(0, 0, PanelReparaciones.Width - 1, PanelReparaciones.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

#End Region

#Region "Servicios de terceros"



    Private Sub CboPersonaServ3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPersonaServ3.SelectedIndexChanged
        If CboPersonaServ3.SelectedItem IsNot Nothing Then

            Dim selectedRow As DataRowView = CType(CboPersonaServ3.SelectedItem, DataRowView)

            lblResultadoPrestador.Text = selectedRow("Persona").ToString()
        Else
            lblResultadoPrestador.Text = ""
        End If
    End Sub

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
                MsgBox("Por favor, seleccione un repuesto y especifique la cantidad.", vbExclamation, "Advertencia")
            End If
        Catch ex As Exception
            MsgBox("Error al agregar el repuesto: " & ex.Message, vbCritical, "Error")
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
        btnAceptarS3.Enabled = False
        BtnModificarS3.Enabled = True
        chkActivoS3.Visible = True
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
    Private Sub BtnCancelarS3_Click(sender As Object, e As EventArgs) Handles BtnCancelarS3.Click
        limpiarServ3()

        grdServiciosTerceros.Rows.Clear()
        ActualizarMontoTotalS3()
        btnAceptarS3.Enabled = True
        BtnModificarS3.Enabled = False
        btnQuitarS3.Enabled = False
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
    Private Sub btnQuitarS3_Click(sender As Object, e As EventArgs) Handles btnQuitarS3.Click
        Try

            If grdServiciosTerceros.SelectedRows.Count > 0 Then

                grdServiciosTerceros.Rows.Remove(grdServiciosTerceros.SelectedRows(0))

                ActualizarMontoTotalS3()
                If grdServiciosTerceros.Rows.Count = 0 Then
                    btnQuitarS3.Enabled = False
                    BtnModificarS3.Enabled = False
                    chkActivoS3.Visible = False
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

#Region "Calcular Totales"

    Private Sub ponerDecimales()

        txtCostoEstimadoS3.Text = Convert.ToDecimal(txtCostoEstimadoS3.Text).ToString("N2")
        txtCostoRealS3.Text = Convert.ToDecimal(txtCostoRealS3.Text).ToString("N2")
        txtMontoManoObra.Text = Convert.ToDecimal(txtMontoManoObra.Text).ToString("N2")
        txtMontoRepuestos.Text = Convert.ToDecimal(txtMontoRepuestos.Text).ToString("N2")
        txtMontoServ3.Text = Convert.ToDecimal(txtMontoServ3.Text).ToString("N2")
        txtMontoTotalOR.Text = Convert.ToDecimal(txtMontoTotalOR.Text).ToString("N2")
        txtCantidadRepOR.Text = Convert.ToDecimal(txtCantidadRepOR.Text).ToString("N2")

    End Sub

    Private Sub CalcularTotalOR()
        txtMontoTotalOR.Text = Convert.ToDecimal(CDec(txtMontoManoObra.Text) + CDec(txtMontoRepuestos.Text) + CDec(txtMontoServ3.Text)).ToString("N2")
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
        txtMontoManoObra.Text = Convert.ToDecimal(txtMontoManoObra.Text).ToString("N2")
    End Sub
    Private Sub txtMontoManoObra_GotFocus(sender As Object, e As EventArgs) Handles txtMontoManoObra.GotFocus
        txtMontoManoObra.SelectAll()
    End Sub

    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click

    End Sub

    Private Sub btnAgregarVehiculo_Click(sender As Object, e As EventArgs) Handles btnAgregarVehiculo.Click

    End Sub

#End Region
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

                Dim ID_Orden As Integer = ordenReparacionData.Agregar_Orden_Reparacion(
                                                                                        Convert.ToInt32(cboVehiculo.SelectedValue),
                                                                                        txtSeñasParticulares.Text,
                                                                                        txtMotivoReparacion.Text,
                                                                                        dtpTurno.Value,
                                                                                        dtpEntrada.Value,
                                                                                        dtpSalida.Value,
                                                                                        cboPersonas.SelectedValue,
                                                                                        Convert.ToDecimal(txtMontoRepuestos.Text),
                                                                                        Convert.ToDecimal(txtMontoServ3.Text),
                                                                                        Convert.ToDecimal(txtMontoManoObra.Text),
                                                                                        Convert.ToDecimal(txtMontoTotalOR.Text),
                                                                                        Convert.ToBoolean(chkActivo.Checked),
                                                                                        transaction)



                If grdServiciosTerceros.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In grdServiciosTerceros.Rows
                        Dim ID_Prestador As Integer = Convert.ToInt32(row.Cells("ID_Prestador").Value)
                        Dim ServSolicitado As String = row.Cells("ServSolicitado").Value
                        Dim CostoEstimado As Decimal = Convert.ToDecimal(row.Cells("CostoEstimado").Value)
                        Dim CostoReal As Decimal = Convert.ToDecimal(row.Cells("CostoReal").Value)
                        Dim Finalizado As Boolean = Convert.ToBoolean(row.Cells("Finalizado").Value)
                        Dim Estado As Boolean = Convert.ToBoolean(row.Cells("Estado").Value)

                        servicioTercerosData.Agregar_Servicio_Terceros(ID_Orden,
                                                                        dtpEntrada.Value,
                                                                        ID_Prestador,
                                                                        ServSolicitado,
                                                                        CostoEstimado,
                                                                        CostoReal,
                                                                        Finalizado,
                                                                        Estado,
                                                                        transaction)
                    Next
                End If


                If grdRepuestos.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In grdRepuestos.Rows
                        Dim ID_Repuestos As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Dim Cantidad As Decimal = Convert.ToDecimal(row.Cells("Cantidad").Value)
                        Dim Precio_Rep As Decimal = Convert.ToDecimal(row.Cells("Precio").Value)

                        repuestosData.Agregar_Repuestos_Ordenes(ID_Repuestos,
                                                                ID_Orden,
                                                                Cantidad,
                                                                Precio_Rep,
                                                                True, 'Harcodeado porque no lo tuvimos en cuenta
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





End Class