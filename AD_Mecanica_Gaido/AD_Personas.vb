Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common

Public Class AD_Personas
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

#Region "Carga de cbo"
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

    'Depende de la provincia elegida, las ciudades que se cargan en el cbo
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

    Public Function Cargar_Combo_TipoDocumento() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_TipoDocumento", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar los tipo de documentos desde la base de datos", ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function

    Public Function Cargar_Combo_TipoPersona() As DataTable
        Dim tabla As New DataTable()

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_TipoPersona", conexion)
                comando.CommandType = CommandType.StoredProcedure

                Try
                    conexion.Open()
                    Dim da As New SqlDataAdapter(comando)
                    da.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar los tipos de personas desde la base de datos", ex)
                End Try
            End Using
        End Using

        Return tabla
    End Function
#End Region

    Public Function Cargar_Grilla() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_Persona", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Function Agregar_Persona(idTipoPersonas As Integer, nombre As String, apellido As String, telefonoMovil As String,
                               telefonoFijo As String, FechaNacimiento As Date, idTipoDocumento As Integer, NumeroDocumento As String,
                              Correo As String, Direccion As String, Numero As Integer, Piso As String, LetraPuerta As String, CodigoPostal As Integer,
                               idCiudad As Integer, Nota As String, Estado As Boolean) As Integer
        Dim idPersona As Integer = 0
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Agregar_Persona", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@idTipoPersonas", idTipoPersonas)
                comando.Parameters.AddWithValue("@Nombre", nombre)
                comando.Parameters.AddWithValue("@Apellido", apellido)
                comando.Parameters.AddWithValue("@telefonoMovil", telefonoMovil)
                comando.Parameters.AddWithValue("@telefonoFijo", telefonoFijo)
                comando.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento)
                comando.Parameters.AddWithValue("@idTipoDocumento", idTipoDocumento)
                comando.Parameters.AddWithValue("@NumeroDocumento", NumeroDocumento)
                comando.Parameters.AddWithValue("@Correo", Correo)
                comando.Parameters.AddWithValue("@Direccion", Direccion)
                comando.Parameters.AddWithValue("@Numero", Numero)
                comando.Parameters.AddWithValue("@Piso", Piso)
                comando.Parameters.AddWithValue("@LetraPuerta", LetraPuerta)
                comando.Parameters.AddWithValue("@CodigoPostal", CodigoPostal)
                comando.Parameters.AddWithValue("@ID_Ciudad", idCiudad)
                comando.Parameters.AddWithValue("@Nota", Nota)
                comando.Parameters.AddWithValue("@Estado", Estado)
                Dim idPersonaParam As New SqlParameter("@ID_Persona", SqlDbType.Int)
                idPersonaParam.Direction = ParameterDirection.Output
                comando.Parameters.Add(idPersonaParam)
                conexion.Open()
                comando.ExecuteNonQuery()
                idPersona = Convert.ToInt32(idPersonaParam.Value)
            End Using
        End Using
        Return idPersona
    End Function

    Public Sub Modificar_Persona(idPersona As Integer, idTipoPersonas As Integer, nombre As String, apellido As String, telefonoMovil As String,
                               telefonoFijo As String, FechaNacimiento As Date, idTipoDocumento As Integer, NumeroDocumento As String,
                              Correo As String, Direccion As String, Numero As Integer, Piso As String, LetraPuerta As String, CodigoPostal As Integer,
                               idCiudad As Integer, Nota As String, Estado As Boolean)
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Modificar_Persona", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_Persona", idPersona)
                comando.Parameters.AddWithValue("@idTipoPersonas", idTipoPersonas)
                comando.Parameters.AddWithValue("@Nombre", nombre)
                comando.Parameters.AddWithValue("@Apellido", apellido)
                comando.Parameters.AddWithValue("@telefonoMovil", telefonoMovil)
                comando.Parameters.AddWithValue("@telefonoFijo", telefonoFijo)
                comando.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento)
                comando.Parameters.AddWithValue("@idTipoDocumento", idTipoDocumento)
                comando.Parameters.AddWithValue("@NumeroDocumento", NumeroDocumento)
                comando.Parameters.AddWithValue("@Correo", Correo)
                comando.Parameters.AddWithValue("@Direccion", Direccion)
                comando.Parameters.AddWithValue("@Numero", Numero)
                comando.Parameters.AddWithValue("@Piso", Piso)
                comando.Parameters.AddWithValue("@LetraPuerta", LetraPuerta)
                comando.Parameters.AddWithValue("@CodigoPostal", CodigoPostal)
                comando.Parameters.AddWithValue("@ID_Ciudad", idCiudad)
                comando.Parameters.AddWithValue("@Nota", Nota)
                comando.Parameters.AddWithValue("@Estado", Estado)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function Consultar_PersonaPorID(ByVal idPersona As Integer) As SqlDataReader
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Consultar_PersonaPorID", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idPersona", idPersona)

        Try
            conexion.Open()
            Return comando.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
