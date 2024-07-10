Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Imports System.Data.Common

Public Class AD_Ciudades
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

    Public Function CiudadExiste(nombreCiudad As String, idProvincia As Integer) As Boolean
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("ControlarCiudadExistente", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@Ciudad", nombreCiudad)
                comando.Parameters.AddWithValue("@ID_Provincia", idProvincia)
                comando.Parameters.Add("@Existe", SqlDbType.Bit).Direction = ParameterDirection.Output

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Dim existe As Boolean = Convert.ToBoolean(comando.Parameters("@Existe").Value)
                    Return existe
                Catch ex As Exception
                    Throw New Exception("Error al verificar la existencia de la ciudad en la base de datos", ex)
                End Try
            End Using
        End Using
    End Function

    Public Function Agregar_Ciudad(ByVal Ciudad As String, ByVal idProvincia As Integer) As Boolean
        If Not CiudadExiste(Ciudad, idProvincia) Then
            Using conexion As New SqlConnection(connectionString)
                Using comando As New SqlCommand("Agregar_Ciudad", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@Ciudad", Ciudad)
                    comando.Parameters.AddWithValue("@ID_Provincia", idProvincia)

                    Try
                        conexion.Open()
                        comando.ExecuteNonQuery()
                        Return True
                    Catch ex As Exception
                        Throw New Exception("Error al agregar la ciudad a la base de datos: " & ex.Message, ex)
                    End Try
                End Using
            End Using
        Else
            Return False 'La ciudad ya existe
        End If
    End Function

    Public Function Modificar_Ciudad(ByVal idCiudad As Integer, ByVal Ciudad As String, ByVal idProvincia As Integer, estado As Boolean) As Boolean
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Modificar_Ciudad", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_Ciudad", idCiudad)
                comando.Parameters.AddWithValue("@Ciudad", Ciudad)
                comando.Parameters.AddWithValue("@ID_Provincia", idProvincia)
                comando.Parameters.AddWithValue("@estado", estado)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    Throw New Exception("Error al modificar la ciudad en la base de datos", ex)
                End Try
            End Using
        End Using
    End Function

    'Carga cbo Provincias
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
                    Throw New Exception("Error al cargar las provincias desde la base de datos", ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function
End Class
