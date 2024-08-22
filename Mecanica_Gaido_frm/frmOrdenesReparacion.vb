Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmOrdenesReparacion
    Dim o_Orden As New AD_OrdenReparacion

#Region "Procedimientos"
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
        limpiar()
    End Sub

    Private Sub frmOrdenesReparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Vehiculos()
        Cargar_Combo_Personas()
        Cargar_Combo_Prestador()
        Cargar_Combo_Repuestos()
        'Cargar_Grilla_Terceros()
        'Cargar_Grilla_RepuestosPorOrden()
        Cargar_Grilla_Ordenes()
        limpiar()
        ponerDecimales()
    End Sub
#End Region

#Region "Cargar cbo"
    Private Sub Cargar_Combo_Vehiculos()
        Try
            Dim tabla As DataTable = o_Orden.Cargar_Combo_Vehiculos()

            If tabla.Rows.Count > 0 Then
                cboVehiculo.DataSource = tabla
                cboVehiculo.DisplayMember = "Nombre"
                cboVehiculo.ValueMember = "ID_Vehiculo"
                cboVehiculo.SelectedValue = -1
            Else
                MsgBox("No se encontraron Vehiculos.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Vehiculos: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
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
    Private Sub btnAgregarRepOR_Click(sender As Object, e As EventArgs) Handles btnAgregarRepOR.Click
        Try

            If cboProductoOR.SelectedValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(txtCantidadRepOR.Text) Then

                Dim rowView As DataRowView = CType(cboProductoOR.SelectedItem, DataRowView)
                Dim idRepuesto As Integer = Convert.ToInt32(rowView("ID_Repuestos"))
                Dim descripcionRepuesto As String = rowView("Descripcion").ToString()
                Dim nombreDiario As String = rowView("nombreDiario").ToString()
                Dim precio As Decimal = Convert.ToDecimal(rowView("PrecioLista"))
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
    'SEGURO QUE VA ESTO?
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

    Private Sub lblResultado_Click(sender As Object, e As EventArgs) Handles lblResultadoPrestador.Click

    End Sub

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
    End Sub

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

    Private Sub BtnCancelarS3_Click(sender As Object, e As EventArgs) Handles BtnCancelarS3.Click
        limpiarServ3()
    End Sub
    Private Sub limpiarServ3()
        CboPersonaServ3.SelectedIndex = -1
        txtID_Serv3.Text = ""
        txtServicioSolicitado.Text = ""
        txtCostoEstimadoS3.Text = Convert.ToDecimal(0).ToString("N2")
        txtCostoRealS3.Text = Convert.ToDecimal(0).ToString("N2")
    End Sub

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


End Class