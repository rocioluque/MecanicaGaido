﻿Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common
Public Class AD_Secciones
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

    Public Function SeccionExiste(nombreSeccion As String) As Boolean
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("ControlarSeccionExistente", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@nombre", nombreSeccion)
                comando.Parameters.Add("@Existe", SqlDbType.Bit).Direction = ParameterDirection.Output

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Dim existe As Boolean = Convert.ToBoolean(comando.Parameters("@Existe").Value)
                    Return existe
                Catch ex As Exception
                    Throw New Exception("Error al verificar la existencia de la seccion en la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
    End Function

    Public Function Agregar_Seccion(nombreSeccion As String) As Boolean
        If Not SeccionExiste(nombreSeccion) Then
            Using conexion As New SqlConnection(connectionString)
                Using comando As New SqlCommand("Agregar_Seccion", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@Nombre", nombreSeccion)

                    Try
                        conexion.Open()
                        comando.ExecuteNonQuery()
                        Return True
                    Catch ex As Exception
                        Throw New Exception("Error al agregar la seccion a la base de datos: " & ex.Message, ex)
                    End Try
                End Using
            End Using
        Else
            Return False
        End If
    End Function

    Public Function Modificar_Seccion(ByVal SeccionID As Integer, ByVal Nombre As String, estado As Boolean) As Boolean
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Modificar_Seccion", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_Seccion", SeccionID)
                comando.Parameters.AddWithValue("@Nombre", Nombre)
                comando.Parameters.AddWithValue("@estado", estado)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    Throw New Exception("Error al modificar la sección en la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
    End Function
End Class
