﻿Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Public Class frmAgregarCiudad
    Dim o_Personas As New AD_Personas
    Dim o_Ciudad As New AD_Ciudades

#Region "Procedimientos"
    Public Property ProvinciaSeleccionada As Integer
    Public Property CiudadID As Integer
    Public Property CiudadNombre As String
    Public Property CiudadEstado As Boolean
    Public Property EsModificacion As Boolean = False

    Private Sub frmAgregarCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Provincias()

        If EsModificacion Then
            ' Si es una modificación, establecer los valores
            cboProvincia.SelectedValue = ProvinciaSeleccionada
            txtCiudad.Text = CiudadNombre
        Else
            ' Si es una nueva ciudad, establecer la provincia seleccionada
            If ProvinciaSeleccionada <> 0 Then
                cboProvincia.SelectedValue = ProvinciaSeleccionada
            End If
        End If
        AplicarTema(Me)
    End Sub

    Private Sub Cargar_Provincias()
        Try
            Dim tabla As DataTable = o_Personas.Cargar_Provincias()

            If tabla.Rows.Count > 0 Then
                cboProvincia.DataSource = tabla
                cboProvincia.DisplayMember = "Nombre"
                cboProvincia.ValueMember = "ID_Provincia"
            Else
                MsgBox("No se encontraron provincias.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las provincias: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

            If o_Ciudad.Agregar_Ciudad(txtCiudad.Text, CInt(cboProvincia.SelectedValue)) Then
                MsgBox("Ciudad agregada correctamente.", vbInformation, "Éxito")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("La ciudad ya existe en la provincia seleccionada.", vbExclamation, "Ciudad Duplicada")
            End If
        Catch ex As Exception
            MsgBox("Error al agregar la ciudad: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class