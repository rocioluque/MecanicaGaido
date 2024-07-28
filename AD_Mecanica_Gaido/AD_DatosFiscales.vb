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
End Class
