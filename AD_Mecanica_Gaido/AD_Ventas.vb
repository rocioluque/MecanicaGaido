Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common
Imports System.Windows.Forms
Imports Microsoft.Practices.EnterpriseLibrary.Data



Public Class AD_Ventas
    Private connectionString As String

    Dim oDatabase As Database
    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"


    End Sub



#Region "Carga de Cbo"
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

    Public Function Cargar_Combo_Persona() As DataTable
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

    'Public Function Cargar_Combo_Empleados() As DataTable
    '    Dim tabla As New DataTable

    '    Using conexion As New SqlConnection(connectionString)
    '        Using comando As New SqlCommand("Cargar_Combo_Empleados", conexion)
    '            comando.CommandType = CommandType.StoredProcedure
    '            Try
    '                conexion.Open()
    '                Dim datadapter As New SqlDataAdapter(comando)
    '                datadapter.Fill(tabla)
    '            Catch ex As Exception
    '                Throw New Exception("Error al cargar los empleados desde la base de datos: " & ex.Message, ex)
    '            End Try

    '        End Using
    '    End Using

    '    Return tabla
    'End Function

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

    Public Function Cargar_Detalles_Por_FP(idFormaPago As Integer) As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_CboDetalleFP", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_FormaPago", idFormaPago)
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using

        Return tabla
    End Function

    Public Function Cargar_Combo_TipoVenta() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_TipoVenta", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar el tipo de venta desde la base de datos: " & ex.Message, ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function

    Public Function Cargar_Combo_FormaEntrega() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_FormaEntrega", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar las formas de entrega desde la base de datos: " & ex.Message, ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function
#End Region

#Region "Consultas"
    Public Function Consultar_DetalleFPPorID(ByVal idDetalleFP As Integer) As SqlDataReader
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Consultar_DetalleFPPorID", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idDetalleFP", idDetalleFP)

        Try
            conexion.Open()
            Return comando.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Consultar_PersonaPorID(ByVal idPersona As Integer) As SqlDataReader
        Dim conexion As New SqlConnection(connectionString)
        Dim comando As New SqlCommand("Consultar_PersonaPorID", conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("@idPersona", idPersona)

        Try
            conexion.Open()
            Return comando.ExecuteReader(CommandBehavior.CloseConnection)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

    Public Function Cargar_Grilla_DetalleVenta() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_DetalleVenta", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Function Cargar_Grilla_Ventas() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_Ventas", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Function Consultar_Venta_ID(ID As Integer) As DataSet
        Dim oDS As New DataSet

        Try
            Using conexion As New SqlConnection(connectionString)
                Using comando As New SqlCommand("Consultar_Venta_ID", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Add(New SqlParameter("@ID_Venta", SqlDbType.Int)).Value = ID

                    Dim datadapter As New SqlDataAdapter(comando)

                    datadapter.Fill(oDS)
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try

        Return oDS
    End Function



    Public Function ObtenerNroComprobante() As String
        Dim nroComprobante As String = ""


        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()


                Using command As New SqlCommand("Consultar_UltNroComprobante", connection)
                    command.CommandType = CommandType.StoredProcedure

                    ' Ejecutar el comando y obtener el resultado
                    Dim resultado As Object = command.ExecuteScalar()
                    Dim varTemp As Integer = 1

                    If resultado IsNot Nothing Then
                        varTemp = Convert.ToInt32(ObtenerNro(resultado))
                        varTemp += 1
                        nroComprobante = "X-0001-" + varTemp.ToString("D8")
                    Else
                        nroComprobante = "X-0001-00000001"
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Manejo de excepciones en caso de error
            MessageBox.Show("Error: " & ex.Message)
        End Try

        Return nroComprobante
    End Function
    Public Function ObtenerNro(input As String) As String

        Dim longitudMaxima As Integer = Math.Min(input.Length, 8)

        Dim ultimosOchoCaracteres As String = input.Substring(input.Length - longitudMaxima)

        For i As Integer = 0 To ultimosOchoCaracteres.Length - 1
            If ultimosOchoCaracteres(i) <> "0"c Then
                Return ultimosOchoCaracteres.Substring(i)
            End If
        Next

        Return String.Empty
    End Function


#Region "Agregar"
    Public Sub AgregarVentaConDetalle(fechaVenta As Date,
                                      nroComprobante As String,
                                      idPersona As Integer,
                                      vendedor As String,
                                      idFormaPago As Integer,
                                      idDetalleFormaPago As Integer,
                                      subtotal As Decimal,
                                      montoDtoRecargo As Decimal,
                                      iva As Decimal,
                                      ivaMonto As Decimal,
                                      otrosImpuestos As Decimal,
                                      total As Decimal,
                                      idTipoVenta As Integer,
                                      idFormaEntrega As Integer,
                                      estado As Boolean,
                                      detalles As DataTable)

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("Agregar_VentaConDetalle", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Parámetros para la tabla de ventas
                command.Parameters.AddWithValue("@FechaVenta", fechaVenta)
                command.Parameters.AddWithValue("@NroComprobante", nroComprobante)
                command.Parameters.AddWithValue("@ID_Persona", idPersona)
                command.Parameters.AddWithValue("@Vendedor", vendedor)
                command.Parameters.AddWithValue("@ID_FormaPago", idFormaPago)
                command.Parameters.AddWithValue("@ID_DetalleFormaPago", idDetalleFormaPago)
                command.Parameters.AddWithValue("@Subtotal", subtotal)
                command.Parameters.AddWithValue("@MontoDtoRecargo", montoDtoRecargo)
                command.Parameters.AddWithValue("@IVA", iva)
                command.Parameters.AddWithValue("@IVAMonto", ivaMonto)
                command.Parameters.AddWithValue("@OtrosImpuestos", otrosImpuestos)
                command.Parameters.AddWithValue("@Total", total)
                command.Parameters.AddWithValue("@ID_TipoVenta", idTipoVenta)
                command.Parameters.AddWithValue("@ID_FormaEntrega", idFormaEntrega)
                command.Parameters.AddWithValue("@Estado", estado)

                ' Crear el parámetro de tipo tabla para los detalles
                Dim detallesParam As SqlParameter = command.Parameters.AddWithValue("@DetallesVenta", detalles)
                detallesParam.SqlDbType = SqlDbType.Structured
                detallesParam.TypeName = "dbo.DetalleVentaType" ' Asegúrate de que este sea el tipo correcto

                ' Abrir conexión y ejecutar el comando
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
#End Region


#Region "Modificar"
    Public Sub ModificarVentaConDetalle(ID_Venta As Integer,
                                       fechaVenta As Date,
                                     nroComprobante As String,
                                     idPersona As Integer,
                                     vendedor As String,
                                     idFormaPago As Integer,
                                     idDetalleFormaPago As Integer,
                                     subtotal As Decimal,
                                     montoDtoRecargo As Decimal,
                                     iva As Decimal,
                                     ivaMonto As Decimal,
                                     otrosImpuestos As Decimal,
                                     total As Decimal,
                                     idTipoVenta As Integer,
                                     idFormaEntrega As Integer,
                                     estado As Boolean,
                                     detalles As DataTable)

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("Modificar_VentaConDetalle", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Parámetros para la tabla de ventas
                command.Parameters.AddWithValue("@ID_Venta", ID_Venta)
                command.Parameters.AddWithValue("@FechaVenta", fechaVenta)
                command.Parameters.AddWithValue("@NroComprobante", nroComprobante)
                command.Parameters.AddWithValue("@ID_Persona", idPersona)
                command.Parameters.AddWithValue("@Vendedor", vendedor)
                command.Parameters.AddWithValue("@ID_FormaPago", idFormaPago)
                command.Parameters.AddWithValue("@ID_DetalleFormaPago", idDetalleFormaPago)
                command.Parameters.AddWithValue("@Subtotal", subtotal)
                command.Parameters.AddWithValue("@MontoDtoRecargo", montoDtoRecargo)
                command.Parameters.AddWithValue("@IVA", iva)
                command.Parameters.AddWithValue("@IVAMonto", ivaMonto)
                command.Parameters.AddWithValue("@OtrosImpuestos", otrosImpuestos)
                command.Parameters.AddWithValue("@Total", total)
                command.Parameters.AddWithValue("@ID_TipoVenta", idTipoVenta)
                command.Parameters.AddWithValue("@ID_FormaEntrega", idFormaEntrega)
                command.Parameters.AddWithValue("@Estado", estado)

                ' Crear el parámetro de tipo tabla para los detalles
                Dim detallesParam As SqlParameter = command.Parameters.AddWithValue("@DetallesVenta", detalles)
                detallesParam.SqlDbType = SqlDbType.Structured
                detallesParam.TypeName = "dbo.DetalleVentaType" ' Asegúrate de que este sea el tipo correcto

                ' Abrir conexión y ejecutar el comando
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
#End Region


End Class
