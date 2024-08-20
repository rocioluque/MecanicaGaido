Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmVehiculos
    Dim o_vehiculo As New AD_Vehiculos

#Region "Procedimientos"
    Private Sub frmVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Marcas()
        Cargar_Combo_TipoVehiculo()
        Cargar_Combo_Personas()
        Cargar_Grilla()
        Limpiar()

        ' Manejar eventos para concatenar datos
        AddHandler cboTipoVehiculo.SelectedIndexChanged, AddressOf ActualizarNombre
        AddHandler cboMarca.SelectedIndexChanged, AddressOf ActualizarNombre
        AddHandler txtModelo.TextChanged, AddressOf ActualizarNombre
        AddHandler txtNumMotor.TextChanged, AddressOf ActualizarNombre
        AddHandler cboPersona.SelectedIndexChanged, AddressOf ActualizarNombre
    End Sub

    Public Sub Limpiar()
        txtID.Clear()
        txtNombre.Clear()
        txtModelo.Clear()
        txtColor.Clear()
        txtNumChasis.Clear()
        txtNumMotor.Clear()
        txtMatricula.Clear()
        txtNota.Clear()
        cboTipoVehiculo.SelectedIndex = -1
        cboMarca.SelectedIndex = -1
        cboPersona.SelectedIndex = -1
        chkEstado.Checked = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
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
                txtID.Text = datoleido("N° Vehículo").ToString()
                cboPersona.SelectedValue = datoleido("Dueño").ToString
                txtNombre.Text = datoleido("Vehículo").ToString()
                txtNumChasis.Text = datoleido("N° Chasis").ToString()
                txtNumMotor.Text = datoleido("N° Motor").ToString()
                cboTipoVehiculo.SelectedValue = datoleido("Tipo de Vehículo").ToString()
                cboMarca.SelectedValue = datoleido("Marca").ToString()
                txtModelo.Text = datoleido("Modelo").ToString()
                txtColor.Text = datoleido("Color").ToString()
                txtMatricula.Text = datoleido("Matricula").ToString()
                txtNota.Text = datoleido("Nota").ToString()
                chkEstado.Checked = Convert.ToBoolean(datoleido("Estado"))


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

            If selectedRow.Cells("N° Vehículo").Value IsNot Nothing Then
                idVehiculo = Convert.ToInt32(selectedRow.Cells("N° Vehículo").Value)
                CargarDatosEnTxt(idVehiculo)
            Else
                MsgBox("El ID del vehículo no puede ser nulo.", vbCritical, "Error")
            End If
        End If
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If cboPersona.SelectedValue <> Nothing And cboMarca.SelectedValue <> Nothing And cboTipoVehiculo.SelectedValue <> Nothing And
            txtModelo.Text <> Nothing And txtNumMotor.Text <> Nothing Then

            Try
                Dim idVehiculo As Integer = o_vehiculo.Agregar_Vehiculo(CInt(cboTipoVehiculo.SelectedValue), CInt(cboMarca.SelectedValue), txtNombre.Text,
                       txtModelo.Text, txtColor.Text, txtNumChasis.Text, txtNumMotor.Text, txtMatricula.Text, txtNota.Text, chkEstado.Checked)

                o_vehiculo.Agregar_VehiculoXPersona(CInt(cboPersona.SelectedValue), idVehiculo, chkEstado.Checked)

                MsgBox("Vehículo agregado correctamente.", vbInformation, "Información")
                Limpiar()
                Cargar_Grilla()

            Catch ex As Exception
                MsgBox("Error al agregar el vehículo: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete los datos correspondientes.", vbInformation, "Error")
        End If
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
                cboPersona.SelectedValue = -1
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

        'Comprueba que si se cerró el modal, se cargue el combo con los nuevos datos
        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_Marcas()

            ' Buscar y seleccionar la nueva marca en el ComboBox
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

        'Comprueba que si se cerró el modal, se cargue el combo con los nuevos datos
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
        ' Ocultar lblMatricula y txtMatricula si se selecciona Tractor o Maquinaria Agrícola
        Dim tipoSeleccionado As String = cboTipoVehiculo.Text

        If tipoSeleccionado = "Tractor" OrElse tipoSeleccionado = "Maquinaria Agrícola" Then
            lblMatricula.Visible = False
            txtMatricula.Visible = False
        Else
            lblMatricula.Visible = True
            txtMatricula.Visible = True
        End If

        ' Actualizar el nombre concatenado también
        ActualizarNombre(sender, e)
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


#End Region

End Class