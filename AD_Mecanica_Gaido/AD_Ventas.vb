Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common

Public Class AD_Ventas
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

#Region "Carga de Cbo"
    Public Function Cargar_Combo_Persona() As DataTable
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

    Public Function Cargar_Combo_Empleados() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Empleados", conexion)
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

    Public Function Cargar_Combo_FormaPago() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_FormaPago", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar las formas de pago desde la base de datos: " & ex.Message, ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function

    Public Function Cargar_Detalles_Por_FP(idFormaPago As Integer) As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_CboDetalleFP", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_FormaPago", idFormaPago)
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using

        Return tabla
    End Function

    Public Function Cargar_Combo_TipoVenta() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_TipoVenta", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar el tipo de venta desde la base de datos: " & ex.Message, ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function

    Public Function Cargar_Combo_FormaEntrega() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_FormaEntrega", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar las formas de entrega desde la base de datos: " & ex.Message, ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function

#End Region

#Region "Consultas"
    Public Function Consultar_DetalleFPPorID(ByVal idDetalleFP As Integer) As SqlDataReader
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Consultar_DetalleFPPorID", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idDetalleFP", idDetalleFP)

        Try
            conexion.Open()
            Return comando.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

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
#End Region

End Class
