Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common

Imports System.Net
Imports Newtonsoft.Json.Linq
Imports GMap.NET

Public Class AD_Ciudades
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

#Region "Funciones de Datos"
    Public Function ObtenerPersonasPorProvincia() As List(Of Provincia)
        Dim provincias As New List(Of Provincia)

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("Obtener_Personas_Provincia", connection)
            command.CommandType = CommandType.StoredProcedure
            connection.Open()

            Using reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim provincia As New Provincia() With {
                        .Nombre = reader("Provincia").ToString(),
                        .CantidadPersonas = Convert.ToInt32(reader("Cantidad"))
                    }
                    provincias.Add(provincia)
                End While
            End Using
        End Using

        Return provincias
    End Function

    Public Function ObtenerCoordenadasProvincias() As List(Of Provincia)
        Dim provincias As New List(Of Provincia) From {
            New Provincia() With {.Nombre = "Ciudad Autónoma de Buenos Aires", .Latitud = -34.6075, .Longitud = -58.3816},
            New Provincia() With {.Nombre = "Buenos Aires", .Latitud = -38.4161, .Longitud = -63.6167},
            New Provincia() With {.Nombre = "Catamarca", .Latitud = -28.469, .Longitud = -66.164},
            New Provincia() With {.Nombre = "Córdoba", .Latitud = -31.4201, .Longitud = -64.1888},
            New Provincia() With {.Nombre = "Corrientes", .Latitud = -27.5, .Longitud = -58.8395},
            New Provincia() With {.Nombre = "Entre Ríos", .Latitud = -32.4014, .Longitud = -60.706},
            New Provincia() With {.Nombre = "Jujuy", .Latitud = -24.185, .Longitud = -65.2996},
            New Provincia() With {.Nombre = "Mendoza", .Latitud = -32.8894, .Longitud = -68.8272},
            New Provincia() With {.Nombre = "La Rioja", .Latitud = -29.41, .Longitud = -67.7},
            New Provincia() With {.Nombre = "Salta", .Latitud = -24.7823, .Longitud = -65.412},
            New Provincia() With {.Nombre = "San Juan", .Latitud = -31.525, .Longitud = -68.5385},
            New Provincia() With {.Nombre = "San Luis", .Latitud = -33.2953, .Longitud = -66.3351},
            New Provincia() With {.Nombre = "Santa Fe", .Latitud = -31.6344, .Longitud = -60.7002},
            New Provincia() With {.Nombre = "Santiago del Estero", .Latitud = -27.7852, .Longitud = -64.261},
            New Provincia() With {.Nombre = "Tucumán", .Latitud = -26.812, .Longitud = -65.2174},
            New Provincia() With {.Nombre = "Chaco", .Latitud = -26.9929, .Longitud = -60.7783},
            New Provincia() With {.Nombre = "Chubut", .Latitud = -43.902, .Longitud = -67.482},
            New Provincia() With {.Nombre = "Formosa", .Latitud = -25.9201, .Longitud = -58.1294},
            New Provincia() With {.Nombre = "Misiones", .Latitud = -27.3656, .Longitud = -55.9183},
            New Provincia() With {.Nombre = "Neuquén", .Latitud = -38.951, .Longitud = -68.0595},
            New Provincia() With {.Nombre = "La Pampa", .Latitud = -36.6167, .Longitud = -64.4},
            New Provincia() With {.Nombre = "Río Negro", .Latitud = -39.0381, .Longitud = -67.6156},
            New Provincia() With {.Nombre = "Santa Cruz", .Latitud = -50.4961, .Longitud = -68.1193},
            New Provincia() With {.Nombre = "Tierra del Fuego", .Latitud = -54.8019, .Longitud = -68.303}
        }

        Return provincias
    End Function
#End Region

    Public Class Provincia
        Public Property Nombre As String
        Public Property CantidadPersonas As Integer
        Public Property Latitud As Double
        Public Property Longitud As Double
    End Class

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
                    Throw New Exception("Error al verificar la existencia de la ciudad en la base de datos: " & ex.Message, ex)
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
                    Throw New Exception("Error al modificar la ciudad en la base de datos: " & ex.Message, ex)
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
                    Throw New Exception("Error al cargar las provincias desde la base de datos: " & ex.Message, ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function

End Class
