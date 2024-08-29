Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common
Public Class AD_FormasDePago
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub

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

    Public Function FormaPagoExiste(nombreFormaPago As String) As Boolean
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("ControlarFormaPagoExistente", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@nombre", nombreFormaPago)
                comando.Parameters.Add("@Existe", SqlDbType.Bit).Direction = ParameterDirection.Output

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Dim existe As Boolean = Convert.ToBoolean(comando.Parameters("@Existe").Value)
                    Return existe
                Catch ex As Exception
                    Throw New Exception("Error al verificar la existencia de la forma de pago en la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
    End Function

    Public Function Agregar_FormaPago(nombreFormaPago As String) As Boolean
        If Not FormaPagoExiste(nombreFormaPago) Then
            Using conexion As New SqlConnection(connectionString)
                Using comando As New SqlCommand("Agregar_FormaPago", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@Nombre", nombreFormaPago)

                    Try
                        conexion.Open()
                        comando.ExecuteNonQuery()
                        Return True
                    Catch ex As Exception
                        Throw New Exception("Error al agregar la forma de pago a la base de datos: " & ex.Message, ex)
                    End Try
                End Using
            End Using
        Else
            Return False
        End If
    End Function

    Public Function Modificar_FormasDePago(ByVal ID_FP As Integer, ByVal Nombre As String, estado As Boolean) As Boolean
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Modificar_FormasDePago", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_FP", ID_FP)
                comando.Parameters.AddWithValue("@Nombre", Nombre)
                comando.Parameters.AddWithValue("@estado", estado)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    Throw New Exception("Error al modificar la forma de pago en la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
    End Function

    Public Function DetalleFPExiste(nombreDetalle As String, idFormaPago As Integer, porcentaje As Decimal, recargo As Boolean, descuento As Boolean) As Boolean
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("ControlarDetalleFPExistente", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@nombreDetalle", nombreDetalle)
                comando.Parameters.AddWithValue("@ID_FormaPago", idFormaPago)
                comando.Parameters.AddWithValue("@porcentaje", porcentaje)
                comando.Parameters.AddWithValue("@recargo", recargo)
                comando.Parameters.AddWithValue("@descuento", descuento)
                comando.Parameters.Add("@Existe", SqlDbType.Bit).Direction = ParameterDirection.Output

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Dim existe As Boolean = Convert.ToBoolean(comando.Parameters("@Existe").Value)
                    Return existe
                Catch ex As Exception
                    Throw New Exception("Error al verificar la existencia del detalle de la forma de pago en la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
    End Function

    Public Function Agregar_DetalleFP(nombreDetalle As String, idFormaPago As Integer, porcentaje As Decimal, recargo As Boolean, descuento As Boolean) As Boolean
        If Not DetalleFPExiste(nombreDetalle, idFormaPago, porcentaje, recargo, descuento) Then
            Using conexion As New SqlConnection(connectionString)
                Using comando As New SqlCommand("Agregar_DetalleFP", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@nombreDetalle", nombreDetalle)
                    comando.Parameters.AddWithValue("@ID_FormaPago", idFormaPago)
                    comando.Parameters.AddWithValue("@porcentaje", porcentaje)
                    comando.Parameters.AddWithValue("@recargo", recargo)
                    comando.Parameters.AddWithValue("@descuento", descuento)

                    Try
                        conexion.Open()
                        comando.ExecuteNonQuery()
                        Return True
                    Catch ex As Exception
                        Throw New Exception("Error al agregar el detalle de forma de pago a la base de datos: " & ex.Message, ex)
                    End Try
                End Using
            End Using
        Else
            Return False
        End If
    End Function

    Public Function Modificar_DetalleFormaPago(ByVal ID_Detalle As Integer, ByVal Nombre As String, ByVal Recargo As Decimal, ByVal Descuento As Decimal, ByVal Porcentaje As Decimal, ByVal Estado As Boolean) As Boolean
        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Modificar_Detalle_FormaPago", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_DetalleFormaPago", ID_Detalle)
                comando.Parameters.AddWithValue("@Nombre", Nombre)
                comando.Parameters.AddWithValue("@Recargo", Recargo)
                comando.Parameters.AddWithValue("@Descuento", Descuento)
                comando.Parameters.AddWithValue("@Porcentaje", Porcentaje)
                comando.Parameters.AddWithValue("@Estado", Estado)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    Throw New Exception("Error al modificar el detalle de forma de pago: " & ex.Message, ex)
                End Try
            End Using
        End Using
    End Function
End Class

