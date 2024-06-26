Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Imports System.Data.Common

Public Class AD_Personas
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

    Public Function Cargar_Provincias() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_CboProvincia", conexion)
                comando.CommandType = CommandType.StoredProcedure

                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar las marcas desde la base de datos", ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function

    Public Function Cargar_Ciudades_Por_Provincia(idProvincia As Integer) As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_CboCiudades", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_Provincia", idProvincia)
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using

        Return tabla
    End Function

    Public Function Cargar_Grilla() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Sub Agregar_Persona(nombre As String, apellido As String, telefono As String, correo As String, direccion As String, idCiudad As Integer, nota As String, estado As Boolean)
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Agregar_Persona", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@Nombre", nombre)
                comando.Parameters.AddWithValue("@Apellido", apellido)
                comando.Parameters.AddWithValue("@Telefono", telefono)
                comando.Parameters.AddWithValue("@Correo", correo)
                comando.Parameters.AddWithValue("@Direccion", direccion)
                comando.Parameters.AddWithValue("@ID_Ciudad", idCiudad)
                comando.Parameters.AddWithValue("@Nota", nota)
                comando.Parameters.AddWithValue("@Estado", estado)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Modificar_Persona(idPersona As Integer, nombre As String, apellido As String, telefono As String, correo As String, direccion As String, idCiudad As Integer, nota As String, estado As Boolean)
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Modificar_Persona", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_Persona", idPersona)
                comando.Parameters.AddWithValue("@Nombre", nombre)
                comando.Parameters.AddWithValue("@Apellido", apellido)
                comando.Parameters.AddWithValue("@Telefono", telefono)
                comando.Parameters.AddWithValue("@Correo", correo)
                comando.Parameters.AddWithValue("@Direccion", direccion)
                comando.Parameters.AddWithValue("@ID_Ciudad", idCiudad)
                comando.Parameters.AddWithValue("@Nota", nota)
                comando.Parameters.AddWithValue("@Estado", estado)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
