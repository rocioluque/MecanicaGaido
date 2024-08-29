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

    Public Function ObtenerDatosRepuestos() As Tuple(Of Integer, Integer, Integer)
        Dim muchos As Integer = 0
        Dim cero As Integer = 0
        Dim pocos As Integer = 0

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Contar_Repuestos_BD", conexion)
                conexion.Open()
                comando.CommandType = CommandType.StoredProcedure

                Using reader As SqlDataReader = comando.ExecuteReader()
                    If reader.Read() Then
                        muchos = Convert.ToInt32(reader("TotalMuchos"))
                    End If

                    If reader.NextResult() AndAlso reader.Read() Then
                        cero = Convert.ToInt32(reader("TotalCero"))
                    End If

                    If reader.NextResult() AndAlso reader.Read() Then
                        pocos = Convert.ToInt32(reader("TotalPocos"))
                    End If
                End Using
            End Using
        End Using
        Return New Tuple(Of Integer, Integer, Integer)(muchos, cero, pocos)
    End Function
End Class
