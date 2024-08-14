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
        txtID.Enabled = False
        cboSeccion.TabIndex = 1
    End Sub

    Public Sub limpiar()
        txtID.Clear()
        txtCuil.Clear()
        txtFechaNacimiento.Clear()
        txtFechaContratacion.Clear()
        txtCargo.Clear()
        txtContraseña.Clear()
        txtNota.Clear()
        cboSeccion.SelectedIndex = -1
        cboUsuario.SelectedIndex = -1
        cboRol.SelectedIndex = -1
        chkEstado.Enabled = False
        txtID.Enabled = False
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        lblCargaEmpleado.Text = ""
        Me.Close()
    End Sub
#End Region

#Region "Cargar"
    'Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
    '    If cboUsuario.SelectedValue <> Nothing And txtContraseña.Text <> Nothing And cboSeccion.SelectedValue <> Nothing Then

    '        Try
    '            o_empleados.Agregar_Empleado(idusuario, contraseña, idseccion, nota, estado)
    '            MsgBox("Empleado agregado correctamente.", vbInformation, "Información")
    '            limpiar()

    '            Cargar_Grilla_Empleados()
    '        Catch ex As Exception
    '            MsgBox("Error al agregar el empleado: " & ex.Message, vbCritical, "Error")
    '            limpiar()
    '        End Try
    '    Else
    '        MsgBox("Complete Datos", vbInformation, "Error")
    '    End If
    'End Sub
#End Region

#Region "Carga Cbo"
    Private Sub Cargar_Combo_Usuarios()
        Try
            Dim tabla As DataTable = o_empleados.Cargar_Combo_Usuarios

            If tabla.Rows.Count > 0 Then
                cboUsuario.DataSource = tabla
                cboUsuario.DisplayMember = "Usuario"
                cboUsuario.ValueMember = "ID_Usuario"
                cboUsuario.SelectedValue = -1
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub
#End Region

End Class