Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient

Public Class frmAgregarMarca
    Dim o_marca As New AD_Marca

    Public Property MarcaID As Integer
    Public Property MarcaNombre As String
    Public Property MarcaEstado As Boolean
    Public Property EsModificacion As Boolean = False

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

#Region "Procedimientos"
    Private Sub frmAgregarMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMarca.Text = MarcaNombre
        chkEstado.Checked = MarcaEstado
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtMarca.Text <> Nothing Then
            Try
                Dim marca As String = txtMarca.Text
                Dim estado As Boolean = chkEstado.Checked

                If o_marca.Agregar_Marca(marca, estado) Then
                    MsgBox("Marca agregada correctamente.", vbInformation, "Información")
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("La marca ya existe, puede modificarla.", vbExclamation, "Marca Duplicada")
                End If
            Catch ex As Exception
                MsgBox("Error al agregar la marca: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
        End If
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim nombreMarca As String = txtMarca.Text
            Dim estado As Boolean = chkEstado.Checked

            If o_marca.Modificar_Marca(MarcaID, nombreMarca, estado) Then
                MsgBox("Marca modificada correctamente.", vbInformation, "Éxito")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("Error al modificar la marca.", vbExclamation, "Error")
            End If
        Catch ex As Exception
            MsgBox("Error al modificar la Marca: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

End Class