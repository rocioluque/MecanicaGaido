﻿Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmVehiculos
    Dim o_vehiculo As New AD_Vehiculos
    Private VehiculoPersona As Integer

#Region "Enter para pasar de tabulación"

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Enter Then
            ' Verifica si el control activo es un Button
            If TypeOf Me.ActiveControl Is Button Then
                ' Ejecuta el evento Click del botón
                Dim button As Button = DirectCast(Me.ActiveControl, Button)
                button.PerformClick()
                Return True
            Else
                ' Mueve el foco al siguiente control en el orden de tabulación
                Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
                Return True
            End If
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub Control_Enter(sender As Object, e As EventArgs)
        If TypeOf sender Is TextBox Then
            CType(sender, TextBox).SelectAll()
        ElseIf TypeOf sender Is RichTextBox Then
            CType(sender, RichTextBox).SelectAll()
        End If
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub frmVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is RichTextBox Then
                AddHandler ctrl.Enter, AddressOf Control_Enter
            End If
        Next
        Limpiar()
        Cargar_Combo_Marcas()
        Cargar_Combo_TipoVehiculo()
        Cargar_Combo_Personas()
        Cargar_Grilla()

        btnModificar.Enabled = False
        txtBuscar.Visible = False
        AplicarTema(Me)

        ' Manejar eventos para concatenar datos
        AddHandler cboTipoVehiculo.SelectedIndexChanged, AddressOf ActualizarNombre
        AddHandler cboMarca.SelectedIndexChanged, AddressOf ActualizarNombre
        AddHandler txtModelo.TextChanged, AddressOf ActualizarNombre
        AddHandler txtNumMotor.TextChanged, AddressOf ActualizarNombre
        AddHandler cboPersona.SelectedIndexChanged, AddressOf ActualizarNombre
    End Sub

    Public Sub Limpiar()
        txtID.Clear()
        txtBuscar.Clear()
        txtNombre.Clear()
        txtModelo.Clear()
        txtHorasTrabajadas.Clear()
        txtNumChasis.Clear()
        txtNumMotor.Clear()
        txtMatricula.Clear()
        txtAñoFabricación.Clear()
        txtNota.Clear()
        cboTipoVehiculo.SelectedIndex = -1
        cboPersona.SelectedIndex = -1
        cboMarca.SelectedIndex = -1
        chkEstado.Checked = False
        txtBuscar.Visible = False
        lblBuscar.Visible = False
        chkEstado.Visible = False
        btnAceptar.Enabled = True
        btnModificar.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        NavegacionEntreForms.persona = 0
        NavegacionEntreForms.vehiculo = 0
        NavegacionEntreForms.vengoDeReparaciones = False
        NavegacionEntreForms.combopersonacargado = False
    End Sub
#End Region

#Region "Cargar grilla y datos en txt"
    Public Sub Cargar_Grilla()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_Vehiculo")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdVehiculo.AutoGenerateColumns = True
                grdVehiculo.DataSource = oDs.Tables(0)
                grdVehiculo.Refresh()
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

    Public Sub CargarDatosEnTxt(ByVal idVehiculo As Integer)
        Try
            Dim datoleido As SqlDataReader = o_vehiculo.Consultar_VehiculoPorID(idVehiculo)

            If datoleido.Read() Then
                chkEstado.Visible = True

                txtID.Text = datoleido("N° Vehículo").ToString()
                cboPersona.SelectedValue = datoleido("Dueño").ToString
                txtNombre.Text = datoleido("Vehículo").ToString()
                txtNumChasis.Text = datoleido("N° Chasis").ToString()
                txtNumMotor.Text = datoleido("N° Motor").ToString()
                cboTipoVehiculo.SelectedValue = datoleido("Tipo de Vehículo").ToString()
                cboMarca.SelectedValue = datoleido("Marca").ToString()
                txtModelo.Text = datoleido("Modelo").ToString()
                txtHorasTrabajadas.Text = datoleido("Horas Trabajadas").ToString()
                txtMatricula.Text = datoleido("Matricula").ToString()
                txtAñoFabricación.Text = datoleido("Año de Fabricación").ToString()
                txtNota.Text = datoleido("Nota").ToString()
                chkEstado.Checked = Convert.ToBoolean(datoleido("Estado"))

                VehiculoPersona = Convert.ToInt32(datoleido("ID_VehiculoPersona"))
            Else
                MsgBox("No se encontraron resultados", vbInformation, "Error")
            End If

            datoleido.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al consultar el vehículo: " & ex.Message, "Error")
        End Try
    End Sub


    Private Sub grdVehiculo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdVehiculo.CellClick
        If e.RowIndex >= 0 Then

            ' Obtiene el ID del vehiculo de la celda correspondiente
            Dim selectedRow As DataGridViewRow = grdVehiculo.Rows(e.RowIndex)
            Dim idVehiculo As Integer
            btnModificar.Enabled = True
            If selectedRow.Cells("N° Vehículo").Value IsNot Nothing Then
                idVehiculo = Convert.ToInt32(selectedRow.Cells("N° Vehículo").Value)
                CargarDatosEnTxt(idVehiculo)
            Else
                MsgBox("El ID del vehículo no puede ser nulo.", vbCritical, "Error")
            End If
        End If
        txtBuscar.Clear()
        lblBuscar.Visible = False
        txtBuscar.Visible = False
        btnAceptar.Enabled = False
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If cboPersona.SelectedValue <> Nothing And cboMarca.SelectedValue <> Nothing And cboTipoVehiculo.SelectedValue <> Nothing And
            txtModelo.Text <> Nothing And txtNumMotor.Text <> Nothing Then

            Try
                Dim idVehiculo As Integer = o_vehiculo.Agregar_Vehiculo(CInt(cboTipoVehiculo.SelectedValue), CInt(cboMarca.SelectedValue),
                                txtNombre.Text, txtModelo.Text, txtHorasTrabajadas.Text, txtNumChasis.Text, txtNumMotor.Text,
                                txtMatricula.Text, txtAñoFabricación.Text, txtNota.Text, chkEstado.Checked)

                o_vehiculo.Agregar_VehiculoXPersona(CInt(cboPersona.SelectedValue), idVehiculo, chkEstado.Checked)

                MsgBox("Vehículo agregado correctamente.", vbInformation, "Información")
                Limpiar()
                Cargar_Grilla()

                If vengoDeReparaciones Then
                    NavegacionEntreForms.combopersonacargado = True
                    frmMenuPrincipal.btnOrdenReparacion.PerformClick()



                End If
                NavegacionEntreForms.combopersonacargado = False
                NavegacionEntreForms.persona = 0
                NavegacionEntreForms.vehiculo = 0
                NavegacionEntreForms.vengoDeReparaciones = False
                NavegacionEntreForms.vengoDeVehiculos = False

            Catch ex As Exception
                MsgBox("Error al agregar el vehículo: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete los datos correspondientes.", vbInformation, "Error")
        End If
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtModelo.Text <> Nothing And txtNumMotor.Text <> Nothing And cboPersona.SelectedValue <> Nothing And
            cboMarca.SelectedValue <> Nothing And cboTipoVehiculo.SelectedValue <> Nothing Then
            Try
                o_vehiculo.Modificar_Vehiculo(CInt(txtID.Text), CInt(cboTipoVehiculo.SelectedValue), CInt(cboMarca.SelectedValue),
                txtNombre.Text, txtModelo.Text, txtHorasTrabajadas.Text, txtNumChasis.Text, txtNumMotor.Text, txtMatricula.Text,
                txtAñoFabricación.Text, txtNota.Text, chkEstado.Checked)

                o_vehiculo.Modificar_VehiculoXPersona(VehiculoPersona, CInt(cboPersona.SelectedValue), CInt(txtID.Text), chkEstado.Checked)

                MsgBox("Vehículo modificado correctamente.", vbInformation, "Información")

                Limpiar()
                Cargar_Grilla()
                btnModificar.Enabled = False
                btnAceptar.Enabled = True
            Catch ex As Exception
                MsgBox("Error al modificar el vehículo: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete los datos correspondientes.", vbInformation, "Error")
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
            comando.CommandText = "Cargar_Grilla_Vehiculo"

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                Dim dt As DataTable = oDs.Tables(0)
                Dim filtro As String = txtBuscar.Text.Trim()

                If Not String.IsNullOrEmpty(filtro) Then
                    Dim dv As New DataView(dt)
                    dv.RowFilter = String.Format(
                    "CONVERT([N° Vehículo], 'System.String') LIKE '%{0}%' OR Dueño LIKE '%{0}%' OR [Vehículo] LIKE '%{0}%' OR [N° Chasis] LIKE '%{0}%'", filtro)
                    grdVehiculo.DataSource = dv
                Else
                    grdVehiculo.DataSource = dt
                End If

                grdVehiculo.Refresh()
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        txtBuscar.Visible = True
        lblBuscar.Visible = True
        txtBuscar.Clear()
        txtBuscar.Focus()
    End Sub
#End Region

#Region "Concatenar Nombre"
    Private Sub ActualizarNombre(sender As Object, e As EventArgs)
        Dim tipoVehiculo As String = If(cboTipoVehiculo.SelectedItem IsNot Nothing, cboTipoVehiculo.Text, String.Empty)
        Dim marca As String = If(cboMarca.SelectedItem IsNot Nothing, cboMarca.Text, String.Empty)
        Dim modelo As String = txtModelo.Text
        Dim nroMotor As String = txtNumMotor.Text
        Dim dueño As String = If(cboPersona.SelectedItem IsNot Nothing, cboPersona.Text, String.Empty)

        txtNombre.Text = $"{tipoVehiculo}.{marca}.{modelo}.{nroMotor}.{dueño}".Trim()
    End Sub
#End Region

#Region "Carga cbo"
    Private Sub Cargar_Combo_Marcas()
        Try
            Dim tabla As DataTable = o_vehiculo.Cargar_Combo_Marcas()

            If tabla.Rows.Count > 0 Then
                cboMarca.DataSource = tabla
                cboMarca.DisplayMember = "Nombre"
                cboMarca.ValueMember = "ID_Marca"
                cboMarca.SelectedValue = -1
            Else
                MsgBox("No se encontraron Marcas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar la Marca: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_TipoVehiculo()
        Try
            Dim tabla As DataTable = o_vehiculo.Cargar_Combo_TipoVehiculo()

            If tabla.Rows.Count > 0 Then
                cboTipoVehiculo.DataSource = tabla
                cboTipoVehiculo.DisplayMember = "Nombre"
                cboTipoVehiculo.ValueMember = "ID_TipoVehiculo"
                cboTipoVehiculo.SelectedValue = -1
            Else
                MsgBox("No se encontraron Vehiculos.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar el tipo de Vehiculo: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_Personas()
        Try
            Dim tabla As DataTable = o_vehiculo.Cargar_Combo_Personas()

            If tabla.Rows.Count > 0 Then
                cboPersona.DataSource = tabla
                cboPersona.DisplayMember = "Persona"
                cboPersona.ValueMember = "ID_Persona"
                cboPersona.SelectedValue = NavegacionEntreForms.persona
            Else
                MsgBox("No se encontraron Personas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar la persona: " & ex.Message, vbCritical, "Error")
        End Try

    End Sub
#End Region

#Region "Marca"
    Private Sub btnAgregarMarca_Click(sender As Object, e As EventArgs) Handles btnAgregarMarca.Click
        Dim frm As New frmAgregarMarca()
        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_Marcas()

            Dim nuevaMarcaVehiculo As String = frm.NuevaMarcaVehiculoNombre
            For Each item As DataRowView In cboMarca.Items
                If item("Nombre").ToString() = nuevaMarcaVehiculo Then
                    cboMarca.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub
#End Region

#Region "Tipo de Vehiculo"
    Private Sub btnAgregarTipoVehiculo_Click(sender As Object, e As EventArgs) Handles btnAgregarTipoVehiculo.Click
        Dim frm As New frmAgregarTipoVehiculo()

        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_TipoVehiculo()

            ' Buscar y seleccionar la nueva marca en el ComboBox
            Dim nuevoTipoVehiculo As String = frm.NuevoTipoVehiculoNombre
            For Each item As DataRowView In cboTipoVehiculo.Items
                If item("Nombre").ToString() = nuevoTipoVehiculo Then
                    cboTipoVehiculo.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub cboTipoVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoVehiculo.SelectedIndexChanged
        ActualizarNombre(sender, e)
    End Sub

    Private Sub txtDominio_leave(sender As Object, e As EventArgs) Handles txtMatricula.Leave
        txtMatricula.Text = txtMatricula.Text.ToUpper()
    End Sub
    Private Sub txtMotor_leave(sender As Object, e As EventArgs) Handles txtNumMotor.Leave
        txtNumMotor.Text = txtNumMotor.Text.ToUpper()
    End Sub
    Private Sub txtChasis_leave(sender As Object, e As EventArgs) Handles txtNumChasis.Leave
        txtNumChasis.Text = txtNumChasis.Text.ToUpper()
    End Sub
#End Region

#Region "Css trucho"
    Private Sub PanelDatoVehiculo_Paint(sender As Object, e As PaintEventArgs) Handles PanelDatoVehiculo.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelDatoVehiculo.Width - 1, PanelDatoVehiculo.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelIdentificacionVehiculo_Paint(sender As Object, e As PaintEventArgs) Handles PanelIdentificacionVehiculo.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelIdentificacionVehiculo.Width - 1, PanelIdentificacionVehiculo.Height - 1)
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

    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        NavegacionEntreForms.vengoDeVehiculos = True
        frmMenuPrincipal.btnPersonas.PerformClick()
    End Sub
#End Region

End Class