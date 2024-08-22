Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common
Public Class AD_DatosFiscales
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

#Region "Consultar y controlar"
    Public Function Consultar_DatoFiscalPorID(IdDatoFiscal As Integer)
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Consultar_DatoFiscalPorID", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@IdDatoFiscal", IdDatoFiscal)

        Try
            conexion.Open()
            Return comando.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Consultar_DatoFiscalPorIDPersona(ByVal idPersona As Integer) As SqlDataReader
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Consultar_DatoFiscalPorIDPersona", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idPersona", idPersona)

        Try
            conexion.Open()
            Return comando.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ControlarIdPersonaEnDatoFiscal(ByVal idPersona As Integer) As Boolean
        Dim resultado As Boolean = False
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("ControlarIdPersonaEnDatoFiscal", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@ID_Persona", idPersona)

        Try
            conexion.Open()
            Dim cantidad As Integer = Convert.ToInt32(comando.ExecuteScalar())

            ' Si la cantidad es mayor a 0, significa que el ID_Persona ya está registrado como dato fiscal.
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
#End Region

    Public Function Cargar_Grilla() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_DatoFiscal", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Sub Agregar_DatoFiscal(IdPersona As Integer, IngresosBrutos As Integer, FechaAlta As Date, Saldo As String)
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Agregar_DatoFiscal", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@idPersona", IdPersona)
                comando.Parameters.AddWithValue("@IngresosBrutos", IngresosBrutos)
                comando.Parameters.AddWithValue("@FechaAlta", FechaAlta)
                comando.Parameters.AddWithValue("@Saldo", Saldo)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Modificar_DatoFiscal(ByVal idDatoFiscal As Integer, ByVal IngresosBrutos As String, ByVal fechaAlta As Date,
                                    ByVal saldo As Decimal, ByVal estado As Boolean)
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Modificar_DatoFiscal", conexion)
        comando.CommandType = CommandType.StoredProcedure

        comando.Parameters.AddWithValue("@idDatoFiscal", idDatoFiscal)
        comando.Parameters.AddWithValue("@IngresosBrutos", IngresosBrutos)
        comando.Parameters.AddWithValue("@fechaAlta", fechaAlta)
        comando.Parameters.AddWithValue("@Saldo", saldo)
        comando.Parameters.AddWithValue("@Estado", estado)

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
