Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common
Public Class AD_Vehiculos
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

#Region "Carga de cbo"
    Public Function Cargar_Combo_Marcas() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Marcas", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar las Marcas desde la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
        Return tabla
    End Function

    Public Function Cargar_Combo_TipoVehiculo() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_TipoVehiculo", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar el tipo de vehiculo desde la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
        Return tabla
    End Function

    Public Function Cargar_Combo_Personas() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Personas", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar las personas desde la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
        Return tabla
    End Function
#End Region

#Region "Tipo de Vehiculos"
    Public Function TipoVehiculoExiste(nombreTipoVehiculo As String) As Boolean
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("ControlarTipoVehiculoExistente", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@nombre", nombreTipoVehiculo)
                comando.Parameters.Add("@Existe", SqlDbType.Bit).Direction = ParameterDirection.Output

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Dim existe As Boolean = Convert.ToBoolean(comando.Parameters("@Existe").Value)
                    Return existe
                Catch ex As Exception
                    Throw New Exception("Error al verificar la existencia del tipo de vehículo en la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
    End Function

    Public Function Agregar_TipoVehiculo(nombreTipoVehiculo As String) As Boolean
        If Not TipoVehiculoExiste(nombreTipoVehiculo) Then
            Using conexion As New SqlConnection(connectionString)
                Using comando As New SqlCommand("Agregar_TipoVehiculo", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@Nombre", nombreTipoVehiculo)

                    Try
                        conexion.Open()
                        comando.ExecuteNonQuery()
                        Return True
                    Catch ex As Exception
                        Throw New Exception("Error al agregar el tipo de vehículo a la base de datos: " & ex.Message, ex)
                    End Try
                End Using
            End Using
        Else
            Return False
        End If
    End Function

    Public Function Modificar_TipoVehiculo(ByVal TipoVehiculoID As Integer, ByVal Nombre As String, estado As Boolean) As Boolean
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Modificar_TipoVehiculo", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_TipoVehiculo", TipoVehiculoID)
                comando.Parameters.AddWithValue("@Nombre", Nombre)
                comando.Parameters.AddWithValue("@estado", estado)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    Throw New Exception("Error al modificar el tipo de vehículo en la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
    End Function
#End Region

    Public Function Cargar_Grilla() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_Vehiculo", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Function Consultar_VehiculoPorID(ByVal idvehiculo As Integer) As SqlDataReader
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Consultar_VehiculoPorID", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idVehiculo", idvehiculo)

        Try
            conexion.Open()
            Return comando.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar_Vehiculo(ID_TipoVehiculo As Integer, ID_Marca As Integer, Nombre As String,
                            Modelo As String, Color As String, NumChasis As String, NumMotor As String,
                            Matricula As String, Nota As String, Estado As Boolean)

        Dim idVehiculo As Integer

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Agregar_Vehiculo", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_TipoVehiculo", ID_TipoVehiculo)
                comando.Parameters.AddWithValue("@ID_Marca", ID_Marca)
                comando.Parameters.AddWithValue("@Nombre", Nombre)
                comando.Parameters.AddWithValue("@Modelo", Modelo)
                comando.Parameters.AddWithValue("@Color", Color)
                comando.Parameters.AddWithValue("@NumChasis", NumChasis)
                comando.Parameters.AddWithValue("@NumMotor", NumMotor)
                comando.Parameters.AddWithValue("@Matricula", Matricula)
                comando.Parameters.AddWithValue("@Nota", Nota)
                comando.Parameters.AddWithValue("@Estado", Estado)

                Dim idVehiculoParam As New SqlParameter("@ID_Vehiculo", SqlDbType.Int)
                idVehiculoParam.Direction = ParameterDirection.Output
                comando.Parameters.Add(idVehiculoParam)

                conexion.Open()
                comando.ExecuteNonQuery()

                idVehiculo = Convert.ToInt32(idVehiculoParam.Value)
            End Using
        End Using
        Return idVehiculo
    End Function

    Public Sub Agregar_VehiculoXPersona(ID_Persona As Integer, ID_Vehiculo As Integer, Estado As Boolean)
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Agregar_VehiculoXPersona", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_Persona", ID_Persona)
                comando.Parameters.AddWithValue("@ID_Vehiculo", ID_Vehiculo)
                comando.Parameters.AddWithValue("@Estado", Estado)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Modificar_Vehiculo(ID_Vehiculo As Integer, ID_TipoVehiculo As Integer, ID_Marca As Integer, Nombre As String,
                              Modelo As String, Color As String, NumChasis As String, NumMotor As String,
                              Matricula As String, Nota As String, Estado As Boolean)
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Modificar_Vehiculo", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_Vehiculo", ID_Vehiculo)
                comando.Parameters.AddWithValue("@ID_TipoVehiculo", ID_TipoVehiculo)
                comando.Parameters.AddWithValue("@ID_Marca", ID_Marca)
                comando.Parameters.AddWithValue("@Nombre", Nombre)
                comando.Parameters.AddWithValue("@Modelo", Modelo)
                comando.Parameters.AddWithValue("@Color", Color)
                comando.Parameters.AddWithValue("@NumChasis", NumChasis)
                comando.Parameters.AddWithValue("@NumMotor", NumMotor)
                comando.Parameters.AddWithValue("@Matricula", Matricula)
                comando.Parameters.AddWithValue("@Nota", Nota)
                comando.Parameters.AddWithValue("@Estado", Estado)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Modificar_VehiculoXPersona(ID_VehiculoPersona As Integer, ID_Persona As Integer, ID_Vehiculo As Integer, Estado As Boolean)
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Modificar_VehiculoXPersona", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_VehiculoPersona", ID_VehiculoPersona)
                comando.Parameters.AddWithValue("@ID_Persona", ID_Persona)
                comando.Parameters.AddWithValue("@ID_Vehiculo", ID_Vehiculo)
                comando.Parameters.AddWithValue("@Estado", Estado)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
