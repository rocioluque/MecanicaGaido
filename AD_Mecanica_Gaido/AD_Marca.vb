Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Imports System.Data.Common

Public Class AD_Marca
    Private connectionstring As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

    Public Sub Agregar_Marca(marca As String, estado As Boolean)
        Using conexion As New SqlConnection(connectionstring)
            Using comando As New SqlCommand("Agregar_Marca", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@Nombre", marca)
                comando.Parameters.AddWithValue("@Estado", estado)
                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function Cargar_Grilla_Marcas() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionstring)
            Using comando As New SqlCommand("Cargar_Grilla_Marcas", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Sub Modificar_Marca(marca As String, estado As Boolean)
        Using conexion As New SqlConnection(connectionstring)
            Using comando As New SqlCommand("Modificar_Marca", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@Nombre", marca)
                comando.Parameters.AddWithValue("@Estado", estado)
                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
