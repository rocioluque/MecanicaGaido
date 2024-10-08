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

#Region "Carga de cbo"
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
#End Region

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

    Public Function Consultar_ProductoPorID(ByVal idProducto As String) As SqlDataReader
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Consultar_ProductoPorID", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idProducto", idProducto)

        Try
            conexion.Open()
            Return comando.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Consultar_StockMinimoPorID(ByVal idProducto As String) As Integer
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Consultar_StockMinimoPorID", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idProducto", idProducto)

        Try
            conexion.Open()
            ' Cambiamos el tipo de retorno a ExecuteScalar ya que queremos un solo valor
            Dim stockMinimo As Object = comando.ExecuteScalar()

            ' Verificamos si el valor no es nulo antes de retornarlo
            If stockMinimo IsNot Nothing AndAlso IsNumeric(stockMinimo) Then
                Return Convert.ToInt32(stockMinimo)
            Else
                Return 1 ' Puedes retornar otro valor en caso de no encontrar resultados
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function



    Public Sub Agregar_Producto(Descripcion As String, NombreDiario As String, ID_Rubro As Integer, ID_Marca As Integer,
                            CodigoBarra As String, CodFabricante As String, CantidadBulto As Decimal, origen As String,
                            Alternativo As Boolean, ID_Original As Integer, Estado As Boolean, Nota As String, StockReal As Decimal,
                            StockDisponible As Decimal, StockMinimo As Decimal, Ubicacion As String, PrecioCompra As Decimal,
                            Utilidad As Decimal, PrecioLista As Decimal, FechaCompra As Date, FechaVenta As Date)
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
                comando.Parameters.AddWithValue("@Origen", origen)
                comando.Parameters.AddWithValue("@Alternativo", Alternativo)
                comando.Parameters.AddWithValue("@ID_Original", ID_Original)
                comando.Parameters.AddWithValue("@Estado", Estado)
                comando.Parameters.AddWithValue("@Nota", Nota)
                comando.Parameters.AddWithValue("@StockReal", StockReal)
                comando.Parameters.AddWithValue("@StockDisponible", StockDisponible)
                comando.Parameters.AddWithValue("@StockMinimo", StockMinimo)
                comando.Parameters.AddWithValue("@Ubicacion", Ubicacion)
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

    Public Sub Modificar_Producto(ID As Integer, Descripcion As String, NombreDiario As String, ID_Rubro As Integer, ID_Marca As Integer,
                          CodigoBarra As String, CodFabricante As String, CantidadBulto As Decimal, origen As String,
                          Alternativo As Boolean, ID_Original As Integer, Estado As Boolean, Nota As String, StockReal As Decimal,
                          StockDisponible As Decimal, StockMinimo As Integer, Ubicacion As String, PrecioCompra As Decimal,
                          Utilidad As Decimal, PrecioLista As Decimal, FechaCompra As Date, FechaVenta As Date)
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Modificar_Producto", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID", ID)
                comando.Parameters.AddWithValue("@Descripcion", Descripcion)
                comando.Parameters.AddWithValue("@NombreDiario", NombreDiario)
                comando.Parameters.AddWithValue("@ID_Rubro", ID_Rubro)
                comando.Parameters.AddWithValue("@ID_Marca", ID_Marca)
                comando.Parameters.AddWithValue("@CodigoBarra", CodigoBarra)
                comando.Parameters.AddWithValue("@CodFabricante", CodFabricante)
                comando.Parameters.AddWithValue("@CantidadBulto", CantidadBulto)
                comando.Parameters.AddWithValue("@Origen", origen)
                comando.Parameters.AddWithValue("@Alternativo", Alternativo)
                comando.Parameters.AddWithValue("@ID_Original", ID_Original)
                comando.Parameters.AddWithValue("@Estado", Estado)
                comando.Parameters.AddWithValue("@Nota", Nota)
                comando.Parameters.AddWithValue("@StockReal", StockReal)
                comando.Parameters.AddWithValue("@StockDisponible", StockDisponible)
                comando.Parameters.AddWithValue("@StockMinimo", StockMinimo)
                comando.Parameters.AddWithValue("@Ubicacion", Ubicacion)
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

    Public Sub Agregar_Repuestos_Ordenes(ID_Repuesto As Integer,
                                     ID_OrdenReparacion As Integer,
                                     Cantidad As Decimal,
                                     Precio As Decimal,
                                     Estado As Boolean,
                                     transaction As SqlTransaction)

        Using command As New SqlCommand("Agregar_Repuestos_Ordenes", transaction.Connection)
            command.CommandType = CommandType.StoredProcedure
            command.Transaction = transaction

            command.Parameters.AddWithValue("@ID_Repuesto", ID_Repuesto)
            command.Parameters.AddWithValue("@ID_OrdenReparacion", ID_OrdenReparacion)
            command.Parameters.AddWithValue("@Cantidad", Cantidad)
            command.Parameters.AddWithValue("@Precio", Precio)
            command.Parameters.AddWithValue("@Estado", Estado)

            Try
                command.ExecuteScalar()

            Catch ex As System.Exception
                Throw ex
            End Try
        End Using
    End Sub


    Public Function Consultar_StockDisponiblePorID(ByVal ID_Repuestos As Integer, transaction As SqlTransaction) As Decimal
        Dim stockDisponible As Decimal = 0

        Using command As New SqlCommand("Consultar_StockDisponiblePorID", transaction.Connection)
            command.CommandType = CommandType.StoredProcedure
            command.Transaction = transaction

            command.Parameters.AddWithValue("@ID_Repuestos", ID_Repuestos)

            Try
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    stockDisponible = Convert.ToDecimal(result)
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Using

        Return stockDisponible
    End Function

    Public Sub Modificar_StockDisponiblePorID(ID_Repuestos As Integer, stockDisponible As Decimal, transaction As SqlTransaction)
        Using command As New SqlCommand("Modificar_StockDisponiblePorID", transaction.Connection)
            command.CommandType = CommandType.StoredProcedure
            command.Transaction = transaction

            command.Parameters.AddWithValue("@ID_Repuestos", ID_Repuestos)
            command.Parameters.AddWithValue("@StockDisponible", stockDisponible)

            Try
                command.ExecuteNonQuery()

            Catch ex As Exception
                Throw ex
            End Try
        End Using
    End Sub
End Class
