Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Public Class frmAgregarRoles
    Dim o_roles As New AD_Roles

    ' Propiedad para almacenar el nombre del nuevo rol agregado
    Public Property NuevoRolNombre As String

#Region "Cargar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtRol.Text <> Nothing Then
            Try
                If o_roles.Agregar_Rol(txtRol.Text) Then

                    'Almacenar el nombre del nuevo rol
                    NuevoRolNombre = txtRol.Text
                    MsgBox("Rol agregado correctamente.", vbInformation, "Información")

                    'Al cerrar el modal devuelve un resultado específico en el frmEmpleado
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("El rol ya existe, puede modificarlo en Gestión de Datos.", vbExclamation, "Rol duplicado")
                End If
            Catch ex As Exception
                MsgBox("Error al agregar el rol: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
        End If
    End Sub
#End Region

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class