Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Public Class frmAgregarSeccion
    Dim o_secciones As New AD_Secciones

    ' Propiedad para almacenar el nombre de la nueva seccion agregada
    Public Property NuevaSeccionNombre As String

#Region "Cargar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtSeccion.Text <> Nothing Then
            Try
                If o_secciones.Agregar_Seccion(txtSeccion.Text) Then

                    'Almacenar el nombre de la nueva seccion
                    NuevaSeccionNombre = txtSeccion.Text
                    MsgBox("Seccion agregada correctamente.", vbInformation, "Información")

                    'Al cerrar el modal devuelve un resultado específico en el frmEmpleado
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("La seccion ya existe, puede modificarla en Gestión de Datos.", vbExclamation, "Seccion duplicada")
                End If
            Catch ex As Exception
                MsgBox("Error al agregar la seccion: " & ex.Message, vbCritical, "Error")
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