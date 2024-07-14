Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Imports System.Data.Common
Public Class AD_Roles
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

    Public Function Modificar_Rubro(ByVal RolID As Integer, ByVal Nombre As String, estado As Boolean) As Boolean
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Modificar_Rol", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_Rol", RolID)
                comando.Parameters.AddWithValue("@Nombre", Nombre)
                comando.Parameters.AddWithValue("@estado", estado)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    Throw New Exception("Error al modificar el rol en la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
    End Function
End Class
