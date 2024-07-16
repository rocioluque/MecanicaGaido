Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmAgregarEmpleados
    Dim o_empleados As New AD_Empleados

#Region "Procedimientos"
    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Usuarios()
        Cargar_Grilla_Empleados()
        Cargar_Combo_Seccion()
        Cargar_Combo_Rol()
    End Sub

    Public Sub limpiar()
        txtID.Text = Nothing
        cboSeccion.SelectedIndex = -1
        txtCuil.Text = Nothing
        txtFechaNacimiento.Text = Nothing
        txtFechaContratacion.Text = Nothing
        txtCargo.Text = Nothing
        cboUsuario.SelectedIndex = -1
        txtContraseña = Nothing
        cboRol.SelectedIndex = -1
        txtNota.Text = Nothing
        chkEstado.Enabled = False
    End Sub

    Public Sub Cargar_Grilla_Empleados()
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
        End If

        oDs = Nothing
        conexion.Close()
    End Sub
#End Region

#Region "Cargar Combos"
    Private Sub Cargar_Combo_Usuarios()
        Try
            Dim tabla As DataTable = o_empleados.Cargar_Combo_Usuarios

            If tabla.Rows.Count > 0 Then
                cboUsuario.DataSource = tabla
                cboUsuario.DisplayMember = "Usuario"
                cboUsuario.ValueMember = "ID_Usuario"
            Else
                MsgBox("No se encontraron usuarios.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los usuarios: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_Seccion()
        Try
            Dim tabla As DataTable = o_empleados.Cargar_Combo_Seccion

            If tabla.Rows.Count > 0 Then
                cboSeccion.DataSource = tabla
                cboSeccion.DisplayMember = "Nombre"
                cboSeccion.ValueMember = "ID_Seccion"
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
            Else
                MsgBox("No se encontraron roles.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los roles: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        lblCargaEmpleado.Text = ""
        Me.Close()
    End Sub



    'Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
    '    If txtDireccion.Text <> Nothing And txtNombre.Text <> Nothing And txtApellido.Text <> Nothing And txtTelefono.Text <> Nothing And cboUsuario.SelectedValue <> Nothing And
    '       txtContraseña.Text <> Nothing And cboSeccion.SelectedValue <> Nothing And txtNota.Text <> Nothing Then

    '        Try
    '            Dim direccion As String = txtDireccion.Text
    '            Dim nombre As String = txtNombre.Text
    '            Dim apellido As String = txtApellido.Text
    '            Dim telefono As String = txtTelefono.Text
    '            Dim idusuario As Integer = Convert.ToInt32(cboUsuario.SelectedValue)
    '            Dim contraseña As String = txtContraseña.Text
    '            Dim idseccion As Integer = Convert.ToInt32(cboSeccion.SelectedValue)
    '            Dim nota As String = txtNota.Text
    '            Dim estado As Boolean = chkEstado.Checked

    '            o_empleados.Agregar_Empleado(direccion, nombre, apellido, telefono, idusuario, contraseña, idseccion, nota, estado)
    '            MsgBox("Empleado agregado correctamente.", vbInformation, "Información")
    '            limpiar()

    '            Cargar_Grilla_Empleados()
    '        Catch ex As Exception
    '            MsgBox("Error al agregar el empleado: " & ex.Message, vbCritical, "Error")
    '            limpiar()
    '        End Try
    '    Else
    '        MsgBox("Complete Datos", vbInformation, "Error")
    '        limpiar()
    '    End If
    'End Sub

End Class