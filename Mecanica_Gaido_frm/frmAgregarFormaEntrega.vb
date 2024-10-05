Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient

Public Class frmAgregarFormaEntrega
    Dim o_entrega As New AD_FormasDeEntrega

    ' Almacena el nombre de la nueva forma de entrega agregada
    Public Property NuevaFormaEntregaNombre As String

#Region "Cargar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtFormaEntrega.Text <> Nothing Then
            Try
                If o_entrega.Agregar_FormaEntrega(txtFormaEntrega.Text) Then

                    'Almacenar el nombre de la nueva forma de entrega
                    NuevaFormaEntregaNombre = txtFormaEntrega.Text
                    MsgBox("Forma de entrega agregada correctamente.", vbInformation, "Información")

                    'Al cerrar el modal devuelve un resultado específico en el frmVenta
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("La forma de entrega ya existe, puede modificarla en Gestión de Datos.", vbExclamation, "Forma de entrega Duplicada")
                End If
            Catch ex As Exception
                MsgBox("Error al agregar la forma de entrega: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
        End If
    End Sub
#End Region

#Region "Procedimientos"
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmAgregarFormaEntrega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AplicarTema(Me)
    End Sub
#End Region

End Class