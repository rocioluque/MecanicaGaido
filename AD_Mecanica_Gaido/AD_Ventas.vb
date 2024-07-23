﻿Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Imports System.Data.Common

Public Class AD_Ventas

    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

    Public Function Cargar_Combo_Cuentas2() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Cuentas2", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar las cuentas desde la base de datos", ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function
    Public Function Cargar_Combo_Empleados() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Empleados", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar los empleados desde la base de datos", ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function
    Public Function Cargar_Combo_FormaPago() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_FormaPago", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar las formas de pago desde la base de datos", ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function
    Public Function Cargar_Combo_TipoVenta() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_TipoVenta", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar el tipo de venta desde la base de datos", ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function
    Public Function Cargar_Combo_FormaEntrega() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_FormaEntrega", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar las formas de entrega desde la base de datos", ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function
End Class