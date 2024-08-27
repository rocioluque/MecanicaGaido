Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common

Public Class AD_MenuPrincipal
    Private connectionstring As String

    Public Sub New()
        connectionstring = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

    Public Function ObtenerProductosBajoStock() As DataTable
        Dim tabla As New DataTable()
        Using conexion As New SqlConnection(connectionstring)
            Using comando As New SqlCommand("Consultar_ProductoBajoStock", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim adapter As New SqlDataAdapter(comando)
                adapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function


End Class
