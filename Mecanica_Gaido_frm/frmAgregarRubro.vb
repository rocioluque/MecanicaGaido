Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Public Class frmAgregarRubro
    Dim o_rubro As New AD_Rubros

    ' Propiedad para almacenar el nombre del nuevo rubro agregado
    Public Property NuevoRubroNombre As String

#Region "Cargar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtRubro.Text <> Nothing Then
            Try
                If o_rubro.Agregar_Rubro(txtRubro.Text) Then

                    'Almacenar el nombre del nuevo rubro
                    NuevoRubroNombre = txtRubro.Text
                    MsgBox("Rubro agregado correctamente.", vbInformation, "Información")

                    'Al cerrar el modal devuelve un resultado específico en el frmProductos
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("El rubro ya existe, puede modificarlo en Gestión de Datos.", vbExclamation, "Rubro duplicado")
                End If
            Catch ex As Exception
                MsgBox("Error al agregar el rubro: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
        End If
    End Sub
#End Region

#Region "Keypress"
    Private Sub txtRubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRubro.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
      AndAlso Not Char.IsControl(e.KeyChar) _
      AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
#End Region

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class