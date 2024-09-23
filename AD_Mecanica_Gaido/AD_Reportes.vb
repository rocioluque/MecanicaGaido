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

#Region "Reporte inicio"
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
#End Region

#Region "Reporte personas"

#End Region

#Region "Reporte vehiculos"

#End Region

#Region "Reporte reparaciones"
    Public Function Contar_Reparaciones_Mes(ByVal año As Integer) As DataTable
        Dim dt As New DataTable()

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Contar_Reparaciones_Mes", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@Año", año)

                Dim adapter As New SqlDataAdapter(comando)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

#End Region

#Region "Reporte productos"
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
                    Throw New Exception("Error al cargar las marcas desde la base de datos: " & ex.Message, ex)
                End Try

            End Using
        End Using
        Return tabla
    End Function

    Public Function ObtenerRepuestos(Optional marcaID As Integer? = Nothing) As DataSet
        Dim ds As New DataSet()

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_ListaRepuestos", conexion)
                comando.CommandType = CommandType.StoredProcedure

                If marcaID.HasValue Then
                    comando.Parameters.AddWithValue("@MarcaID", marcaID.Value)
                Else
                    comando.Parameters.AddWithValue("@MarcaID", DBNull.Value)
                End If

                conexion.Open()
                Dim adapter As New SqlDataAdapter(comando)
                adapter.Fill(ds)
            End Using
        End Using

        Return ds
    End Function
#End Region

#Region "Reporte compras"

#End Region

#Region "Reporte ventas"

#End Region

#Region "Reporte miscelaneas"

#End Region
End Class
