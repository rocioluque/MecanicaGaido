Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common
Public Class AD_Productos
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

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

    Public Function Cargar_Combo_Rubros() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Rubros", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar los rubros desde la base de datos: " & ex.Message, ex)
                End Try

            End Using
        End Using
        Return tabla
    End Function

    Public Function Cargar_Combo_Original() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Original", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar los repuestos originales desde la base de datos: " & ex.Message, ex)
                End Try

            End Using
        End Using
        Return tabla
    End Function

    Public Function Cargar_Grilla() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_Producto", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Sub Agregar_Producto(Descripcion As String, NombreDiario As String, ID_Rubro As Integer, ID_Marca As Integer,
                                CodigoBarra As String, CodFabricante As String, CantidadBulto As Decimal, ID_Origen As Integer,
                                Alternativo As Boolean, ID_Original As Integer, Estado As Boolean, StockReal As Decimal,
                                StockDisponible As Decimal, Estanteria As String, NumeroFila As String, PrecioCompra As Decimal,
                                Utilidad As Decimal, PrecioLista As String, FechaCompra As Date, FechaVenta As Date)
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Agregar_Producto", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@Descripcion", Descripcion)
                comando.Parameters.AddWithValue("@NombreDiario", NombreDiario)
                comando.Parameters.AddWithValue("@ID_Rubro", ID_Rubro)
                comando.Parameters.AddWithValue("@ID_Marca", ID_Marca)
                comando.Parameters.AddWithValue("@CodigoBarra", CodigoBarra)
                comando.Parameters.AddWithValue("@CodFabricante", CodFabricante)
                comando.Parameters.AddWithValue("@CantidadBulto", CantidadBulto)
                comando.Parameters.AddWithValue("@ID_Origen", ID_Origen)
                comando.Parameters.AddWithValue("@Alternativo", Alternativo)
                comando.Parameters.AddWithValue("@ID_Original", ID_Original)
                comando.Parameters.AddWithValue("@Estado", Estado)
                comando.Parameters.AddWithValue("@StockReal", StockReal)
                comando.Parameters.AddWithValue("@StockDisponible", StockDisponible)
                comando.Parameters.AddWithValue("@Estanteria", Estanteria)
                comando.Parameters.AddWithValue("@NumeroFila", NumeroFila)
                comando.Parameters.AddWithValue("@PrecioCompra", PrecioCompra)
                comando.Parameters.AddWithValue("@Utilidad", Utilidad)
                comando.Parameters.AddWithValue("@PrecioLista", PrecioLista)
                comando.Parameters.AddWithValue("@FechaCompra", FechaCompra)
                comando.Parameters.AddWithValue("@FechaVenta", FechaVenta)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
