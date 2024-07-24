Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
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
                    Throw New Exception("Error al cargar los empleados desde la base de datos: " & ex.Message, ex)
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
                    Throw New Exception("Error al cargar la seccion desde la base de datos: " & ex.Message, ex)
                End Try

            End Using
        End Using
        Return tabla
    End Function

    Public Function Cargar_Combo_Rol() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Rol", conexion)
                comando.CommandType = CommandType.StoredProcedure

                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar los roles desde la base de datos: " & ex.Message, ex)
                End Try

            End Using
        End Using
        Return tabla
    End Function

    'Modificar esto, el procedimiento no está creado
    Public Sub Agregar_Empleado(ID_Persona As Integer, ID_Usuario As Integer, ID_Seccion As Integer, CUIL As String, FNac As Date, FContrato As Date, Cargo As String, Nota As String, estado As Boolean)
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Agregar_Empleado", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_Persona", ID_Persona)
                comando.Parameters.AddWithValue("@ID_Usuario", ID_Usuario)
                comando.Parameters.AddWithValue("@ID_Seccion", ID_Seccion)
                comando.Parameters.AddWithValue("@CUIL", CUIL)
                comando.Parameters.AddWithValue("@FN", FNac)
                comando.Parameters.AddWithValue("@FContrato", FContrato)
                comando.Parameters.AddWithValue("@Cargo", Cargo)
                comando.Parameters.AddWithValue("@Nota", Nota)
                comando.Parameters.AddWithValue("@Estado", estado)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
