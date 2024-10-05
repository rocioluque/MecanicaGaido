Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmAgregarEmpleados
    Dim o_empleados As New AD_Empleados
    Public Property IdPersona As Integer

#Region "Procedimientos"
    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Grilla_Empleados()
        Cargar_Combo_Seccion()
        Cargar_Combo_Rol()
        cboSeccion.TabIndex = 1
        validar()
        AplicarTema(Me)

        If o_empleados.ControlarIdPersonaEnEmpleado(IdPersona) Then
            ' Si la persona ya es un empleado, deshabilitar el botón "Aceptar"
            btnAceptar.Enabled = False
            btnModificar.Enabled = True

            ' Cargar los datos del empleado para modificación
            CargarDatosPorIDPersona(IdPersona)
        Else
            ' Si no es un empleado, habilitar el botón "Aceptar"
            btnAceptar.Enabled = True
            btnModificar.Enabled = False
        End If

    End Sub

    Public Sub limpiar()
        txtID.Clear()
        txtCargo.Clear()
        txtUsuario.Clear()
        txtContraseña.Clear()
        txtNota.Clear()
        dtpFechaContratacion.Value = DateTime.Today
        cboSeccion.SelectedIndex = -1
        cboRol.SelectedIndex = -1
        chkEstado.Checked = False
        lblCargaEmpleado.Text = Nothing
        lblCargaCuil.Text = Nothing
        lblCargaFechaNacimiento.Text = Nothing
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        limpiar()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()

        btnAceptar.Enabled = True
        btnModificar.Enabled = False

        Me.Close()
    End Sub
#End Region

#Region "validacion"
    Public Sub validar()
        If txtUsuario.Text <> Nothing And txtContraseña.Text <> Nothing And txtCargo.Text <> Nothing Then

            chkEstado.Visible = True
        Else
            chkEstado.Visible = False
        End If
    End Sub

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        validar()
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        validar()
    End Sub

    Private Sub txtCargo_TextChanged(sender As Object, e As EventArgs) Handles txtCargo.TextChanged
        validar()
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
        validar()
    End Sub
#End Region

#Region "Grilla y datos en txt"
    Public Sub Cargar_Grilla_Empleados()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_Empleados")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdEmpleados.AutoGenerateColumns = True
                grdEmpleados.DataSource = oDs.Tables(0)
                grdEmpleados.Refresh()
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

    Public Sub CargarDatosEnTxt(ByVal idEmpleado As Integer)
        Try
            Dim datoleido As SqlDataReader = o_empleados.Consultar_EmpleadoPorID(idEmpleado)

            If datoleido.Read() Then
                txtID.Text = datoleido("N° Empleado").ToString()
                lblCargaEmpleado.Text = datoleido("Empleado").ToString()
                lblCargaCuil.Text = datoleido("Documento").ToString()

                Dim fechaNacimiento As Object = datoleido("Fecha de Nacimiento")

                If IsDate(fechaNacimiento) Then
                    lblCargaFechaNacimiento.Text = Convert.ToDateTime(fechaNacimiento).ToString("dd/MM/yyyy")
                Else
                    lblCargaFechaNacimiento.Text = "Fecha inválida"
                End If

                dtpFechaContratacion.Value = Convert.ToDateTime(datoleido("Fecha de Contratación"))
                txtCargo.Text = datoleido("Cargo").ToString()
                cboSeccion.SelectedValue = datoleido("Seccion").ToString()
                txtUsuario.Text = datoleido("Usuario").ToString()
                txtContraseña.Text = datoleido("Contraseña").ToString()

                cboRol.SelectedValue = datoleido("Rol").ToString()
                txtNota.Text = datoleido("Nota").ToString()

                chkEstado.Checked = Convert.ToBoolean(datoleido("Estado"))

                btnAceptar.Enabled = False
                btnModificar.Enabled = True
            Else
                MsgBox("No se encontraron resultados", vbInformation, "Error")
            End If

            datoleido.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al consultar el empleado: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub grdEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdEmpleados.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = grdEmpleados.Rows(e.RowIndex)
            Dim idEmpleado As Integer

            If selectedRow.Cells("N° Empleado").Value IsNot Nothing Then
                idEmpleado = Convert.ToInt32(selectedRow.Cells("N° Empleado").Value)
                CargarDatosEnTxt(idEmpleado)
            Else
                MsgBox("El ID del empleado no puede ser nulo.", vbCritical, "Error")
            End If
        End If
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtUsuario.Text <> Nothing And txtContraseña.Text <> Nothing And cboSeccion.SelectedValue <> Nothing Then

            Try
                If o_empleados.Agregar_Empleado_Usuario(IdPersona, txtUsuario.Text, txtContraseña.Text, CInt(cboRol.SelectedValue),
                                      dtpFechaContratacion.Value, txtCargo.Text, txtNota.Text, chkEstado.Checked, CInt(cboSeccion.SelectedValue)) Then
                    MsgBox("Empleado y usuario agregado correctamente.", vbInformation, "Información")
                    limpiar()

                    Cargar_Grilla_Empleados()
                Else
                    MsgBox("Esta persona ya está cargada como empleado, puede seleccionarla en la grilla y modificar sus datos.", vbExclamation, "Marca Duplicada")
                End If
            Catch ex As Exception
                MsgBox("Error al agregar el empleado: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
        End If
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtCargo.Text <> Nothing And txtUsuario.Text <> Nothing And txtContraseña.Text <> Nothing And
            cboSeccion.SelectedValue <> Nothing And cboRol.SelectedValue <> Nothing Then
            Try
                o_empleados.Modificar_Empleado_Usuario(Convert.ToInt32(txtID.Text), txtUsuario.Text, txtContraseña.Text, CInt(cboRol.SelectedValue),
                                                       dtpFechaContratacion.Value, txtCargo.Text, txtNota.Text, chkEstado.Checked, CInt(cboSeccion.SelectedValue))
                MessageBox.Show("Empleado y usuario modificados correctamente.", "Éxito")
                limpiar()

                Cargar_Grilla_Empleados()
            Catch ex As Exception
                MsgBox("Error al modificar el empleado: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete los datos correspondientes.", vbInformation, "Error")
        End If
    End Sub
#End Region

#Region "Carga Cbo"
    Private Sub Cargar_Combo_Seccion()
        Try
            Dim tabla As DataTable = o_empleados.Cargar_Combo_Seccion

            If tabla.Rows.Count > 0 Then
                cboSeccion.DataSource = tabla
                cboSeccion.DisplayMember = "Nombre"
                cboSeccion.ValueMember = "ID_Seccion"
                cboSeccion.SelectedValue = -1
            Else
                MsgBox("No se encontraron secciones.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las secciones: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_Rol()
        Try
            Dim tabla As DataTable = o_empleados.Cargar_Combo_Rol

            If tabla.Rows.Count > 0 Then
                cboRol.DataSource = tabla
                cboRol.DisplayMember = "Nombre"
                cboRol.ValueMember = "ID_Rol"
                cboRol.SelectedValue = -1
            Else
                MsgBox("No se encontraron roles.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los roles: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Seccion"
    Private Sub btnAgregarSeccion_Click(sender As Object, e As EventArgs) Handles btnAgregarSeccion.Click
        Dim frm As New frmAgregarSeccion()

        'Comprueba que si se cerró el modal, se cargue el combo con los nuevos datos
        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_Seccion()

            ' Buscar y seleccionar la nueva seccion en el ComboBox
            Dim nuevaSeccion As String = frm.NuevaSeccionNombre
            For Each item As DataRowView In cboSeccion.Items
                If item("Nombre").ToString() = nuevaSeccion Then
                    cboSeccion.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub
#End Region

#Region "Rol"
    Private Sub btnAgregarRol_Click(sender As Object, e As EventArgs) Handles btnAgregarRol.Click
        Dim frm As New frmAgregarRoles()

        'Comprueba que si se cerró el modal, se cargue el combo con los nuevos datos
        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_Rol()

            ' Buscar y seleccionar el nuevo rol en el ComboBox
            Dim nuevoRol As String = frm.NuevoRolNombre
            For Each item As DataRowView In cboRol.Items
                If item("Nombre").ToString() = nuevoRol Then
                    cboRol.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub
#End Region

#Region "Cargar datos de empleado ya cargado"
    Public Sub CargarDatosPorIDPersona(ByVal idPersona As Integer)
        Try
            Dim datoleido As SqlDataReader = o_empleados.Consultar_EmpleadoPorIDPersona(idPersona)

            If datoleido.Read() Then
                ' Si el empleado existe, carga los datos en los controles
                txtID.Text = datoleido("N° Empleado").ToString()
                lblCargaEmpleado.Text = datoleido("Empleado").ToString()
                lblCargaCuil.Text = datoleido("Documento").ToString()

                Dim fechaNacimiento As Object = datoleido("Fecha de Nacimiento")

                If IsDate(fechaNacimiento) Then
                    lblCargaFechaNacimiento.Text = Convert.ToDateTime(fechaNacimiento).ToString("dd/MM/yyyy")
                Else
                    lblCargaFechaNacimiento.Text = "Fecha inválida"
                End If

                dtpFechaContratacion.Value = Convert.ToDateTime(datoleido("Fecha de Contratación"))
                txtCargo.Text = datoleido("Cargo").ToString()
                cboSeccion.SelectedValue = datoleido("Seccion").ToString()
                txtUsuario.Text = datoleido("Usuario").ToString()
                txtContraseña.Text = datoleido("Contraseña").ToString()
                cboRol.SelectedValue = datoleido("Rol").ToString()
                txtNota.Text = datoleido("Nota").ToString()

                chkEstado.Checked = Convert.ToBoolean(datoleido("Estado"))

                btnAceptar.Enabled = False
            Else
                txtID.Text = datoleido("N° Empleado").ToString()
                lblCargaEmpleado.Text = datoleido("Empleado").ToString()
                lblCargaCuil.Text = datoleido("Documento").ToString()
            End If

            datoleido.Close()

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al consultar el empleado: " & ex.Message, "Error")
        End Try
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

    Private Sub PanelDetallesContratación_Paint(sender As Object, e As PaintEventArgs) Handles PanelDetallesContratación.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelDetallesContratación.Width - 1, PanelDetallesContratación.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelUsuario_Paint(sender As Object, e As PaintEventArgs) Handles PanelUsuario.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelUsuario.Width - 1, PanelUsuario.Height - 1)
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