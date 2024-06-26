Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Imports System.Data.Common

Public Class AD_Empleados
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

    Public Function Cargar_Grilla_Empleados() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_Empleados", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Function Cargar_Combo_Usuarios() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Usuarios", conexion)
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

    Public Function Cargar_Combo_Seccion() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Seccion", conexion)
                comando.CommandType = CommandType.StoredProcedure

                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar la seccion desde la base de datos", ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function

    Public Sub Agregar_Empleado(direccion As String, nombre As String, apellido As String, idusuario As Integer, contraseña As String, idseccion As Integer, nota As String, estado As Boolean)
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Agregar_Empleado", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@Direccion", direccion)
                comando.Parameters.AddWithValue("@Nombre", nombre)
                comando.Parameters.AddWithValue("@Apellido", apellido)
                comando.Parameters.AddWithValue("@idusuario", idusuario)
                comando.Parameters.AddWithValue("@Contraseña", contraseña)
                comando.Parameters.AddWithValue("@idseccion", idseccion)
                comando.Parameters.AddWithValue("@Nota", nota)
                comando.Parameters.AddWithValue("@Estado", estado)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
