Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common
Public Class AD_Compras
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

#Region "Carga cbo"
    Public Function Cargar_Combo_FormaPago_Compra() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_FormaPago_Compra", conexion)
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

    Public Function Cargar_Combo_Personas() As DataTable
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

    Public Function Cargar_Combo_Repuestos() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Repuestos", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar los Repuestos desde la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
        Return tabla
    End Function
#End Region

    Public Function Cargar_Grilla_DetalleCompra() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_DetalleCompra", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Sub AgregarCompra(fechaCompra As DateTime, nroComprobante As String, idPersona As Integer, idFormaPago As Integer,
                             subtotal As Decimal, iva As Decimal, ivaMonto As Decimal, otrosImpuestos As Decimal,
                             total As Decimal, estado As Boolean, detallesCompra As DataTable, denominacionLote As String)
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Agregar_Compra", conexion)
                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@FechaCompra", fechaCompra)
                comando.Parameters.AddWithValue("@NroComprobante", nroComprobante)
                comando.Parameters.AddWithValue("@ID_Persona", idPersona)
                comando.Parameters.AddWithValue("@ID_FormaPago", idFormaPago)
                comando.Parameters.AddWithValue("@Subtotal", subtotal)
                comando.Parameters.AddWithValue("@IVA", iva)
                comando.Parameters.AddWithValue("@IVA_Monto", ivaMonto)
                comando.Parameters.AddWithValue("@OtrosImpuestos", otrosImpuestos)
                comando.Parameters.AddWithValue("@Total", total)
                comando.Parameters.AddWithValue("@Estado", estado)

                Dim paramDetalles As New SqlParameter("@DetallesCompra", SqlDbType.Structured)
                paramDetalles.TypeName = "Type_DetalleCompra"
                paramDetalles.Value = detallesCompra
                comando.Parameters.Add(paramDetalles)

                comando.Parameters.AddWithValue("@DenominacionLote", denominacionLote)

                conexion.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
