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
        connectionstring = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

    Public Function MarcaExiste(nombreMarca As String) As Boolean
        Using conexion As New SqlConnection(connectionstring)
            Using comando As New SqlCommand("ControlarMarcaExistente", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@nombre", nombreMarca)
                comando.Parameters.Add("@Existe", SqlDbType.Bit).Direction = ParameterDirection.Output

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Dim existe As Boolean = Convert.ToBoolean(comando.Parameters("@Existe").Value)
                    Return existe
                Catch ex As Exception
                    Throw New Exception("Error al verificar la existencia de la marca en la base de datos", ex)
                End Try
            End Using
        End Using
    End Function

    Public Function Agregar_Marca(nombreMarca As String, repuesto As Boolean, vehiculo As Boolean) As Boolean
        If Not MarcaExiste(nombreMarca) Then
            Using conexion As New SqlConnection(connectionstring)
                Using comando As New SqlCommand("Agregar_Marca", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@Nombre", nombreMarca)
                    comando.Parameters.AddWithValue("@Repuesto", repuesto)
                    comando.Parameters.AddWithValue("@Vehiculo", vehiculo)

                    Try
                        conexion.Open()
                        comando.ExecuteNonQuery()
                        Return True
                    Catch ex As Exception
                        Throw New Exception("Error al agregar la marca a la base de datos: " & ex.Message, ex)
                    End Try
                End Using
            End Using
        Else
            'Si la marca ya existe
            Return False
        End If
    End Function

    Public Sub Modificar_Marca(id_marca As Integer, nombre As String, EsRepuesto As Boolean, EsVehiculo As Boolean, estado As Boolean)
        Using conexion As New SqlConnection(connectionstring)
            Using comando As New SqlCommand("Modificar_Marca", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_Marca", id_marca)
                comando.Parameters.AddWithValue("@Nombre", nombre)
                comando.Parameters.AddWithValue("@Repuesto", EsRepuesto)
                comando.Parameters.AddWithValue("@Vehiculo", EsVehiculo)
                comando.Parameters.AddWithValue("@Estado", estado)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
