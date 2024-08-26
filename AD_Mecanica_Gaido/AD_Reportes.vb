Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common

Public Class AD_Reportes
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

    Public Function Cargar_Grilla_Reportes1() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_Reportes1", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Function Cargar_Grilla_Reportes2() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_Reportes2", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function
End Class
