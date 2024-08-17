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

#Region "carga cbo"
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
#End Region

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

    Public Function Consultar_ProductoPorID(ByVal idEmpleado As Integer) As SqlDataReader
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Consultar_EmpleadoPorID", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idEmpleado", idEmpleado)

        Try
            conexion.Open()
            Return comando.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Consultar_EmpleadoPorIDPersona(ByVal idPersona As Integer) As SqlDataReader
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Consultar_EmpleadoPorIDPersona", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idPersona", idPersona)

        Try
            conexion.Open()
            Return comando.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ControlarIdPersonaEnEmpleado(ByVal idPersona As Integer) As Boolean
        Dim resultado As Boolean = False
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("ControlarIdPersonaEnEmpleado", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@ID_Persona", idPersona)

        Try
            conexion.Open()
            Dim cantidad As Integer = Convert.ToInt32(comando.ExecuteScalar())

            ' Si la cantidad es mayor a 0, significa que el ID_Persona ya está registrado como empleado.
            If cantidad > 0 Then
                resultado = True
            End If
        Catch ex As Exception
            Throw New Exception("Error al verificar el ID de la persona: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        Return resultado
    End Function

    Public Sub Agregar_Empleado_Usuario(ByVal idPersona As Integer, ByVal usuario As String, ByVal contraseña As String, ByVal idRol As Integer,
                                        ByVal fechaContratacion As Date, ByVal cargo As String, ByVal nota As String, ByVal estado As Boolean,
                                        ByVal idSeccion As Integer)
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Agregar_Empleado_Usuario", conexion)
        comando.CommandType = CommandType.StoredProcedure

        ' Agregar parámetros
        comando.Parameters.AddWithValue("@ID_Persona", idPersona)
        comando.Parameters.AddWithValue("@Usuario", usuario)
        comando.Parameters.AddWithValue("@Contraseña", contraseña)
        comando.Parameters.AddWithValue("@ID_Rol", idRol)
        comando.Parameters.AddWithValue("@FechaDeContratacion", fechaContratacion)
        comando.Parameters.AddWithValue("@Cargo", cargo)
        comando.Parameters.AddWithValue("@Nota", nota)
        comando.Parameters.AddWithValue("@Estado", estado)
        comando.Parameters.AddWithValue("@ID_Seccion", idSeccion)

        Try
            conexion.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Ocurrió un error al insertar los datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Modificar_Empleado_Usuario(ByVal idEmpleado As Integer, ByVal usuario As String, ByVal contraseña As String,
                                           ByVal idRol As Integer, ByVal fechaContratacion As Date, ByVal cargo As String,
                                          ByVal nota As String, ByVal estado As Boolean, ByVal idSeccion As Integer)
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Modificar_Empleado_Usuario", conexion)
        comando.CommandType = CommandType.StoredProcedure

        ' Agregar parámetros
        comando.Parameters.AddWithValue("@ID_Empleado", idEmpleado)
        comando.Parameters.AddWithValue("@Usuario", usuario)
        comando.Parameters.AddWithValue("@Contraseña", contraseña)
        comando.Parameters.AddWithValue("@ID_Rol", idRol)
        comando.Parameters.AddWithValue("@FechaDeContratacion", fechaContratacion)
        comando.Parameters.AddWithValue("@Cargo", cargo)
        comando.Parameters.AddWithValue("@Nota", nota)
        comando.Parameters.AddWithValue("@Estado", estado)
        comando.Parameters.AddWithValue("@ID_Seccion", idSeccion)

        Try
            conexion.Open()
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Ocurrió un error al modificar los datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

End Class
