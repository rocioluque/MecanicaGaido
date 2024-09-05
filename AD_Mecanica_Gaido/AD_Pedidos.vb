﻿Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common

Public Class AD_Pedidos
    Private connectionstring As String

    Public Sub New()
        connectionstring = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

    Public Function Cargar_Combo_Personas() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionstring)
            Using comando As New SqlCommand("Cargar_Combo_Personas", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar las personas desde la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
        Return tabla
    End Function

    Public Function ObtenerProductosBajoStock() As DataTable
        Dim tabla As New DataTable()
        Using conexion As New SqlConnection(connectionstring)
            Using comando As New SqlCommand("Consultar_ProductoBajoStock", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim adapter As New SqlDataAdapter(comando)
                adapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function
End Class
