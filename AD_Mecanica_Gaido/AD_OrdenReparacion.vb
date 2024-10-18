Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data


Public Class AD_OrdenReparacion
    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"

    End Sub

#Region "Carga cbo"
    Public Function Cargar_Combo_Vehiculos() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Vehiculos", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar los Vehiculos desde la base de datos: " & ex.Message, ex)
                End Try

            End Using
        End Using

        Return tabla
    End Function

    Public Function Cargar_Combo_Vehiculos(ID_Persona) As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Vehiculos_Persona", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add(New SqlParameter("@ID_Persona", SqlDbType.Int)).Value = ID_Persona
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar los Vehiculos desde la base de datos: " & ex.Message, ex)
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

    Public Function Cargar_Combo_Prestador() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_Prestador", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar los prestadores desde la base de datos: " & ex.Message, ex)
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

    Public Function Cargar_Combo_TipoReparacion() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Combo_TipoReparacion", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Try
                    conexion.Open()
                    Dim datadapter As New SqlDataAdapter(comando)
                    datadapter.Fill(tabla)
                Catch ex As Exception
                    Throw New Exception("Error al cargar los Tipos de Reparación desde la base de datos: " & ex.Message, ex)
                End Try
            End Using
        End Using
        Return tabla
    End Function
#End Region

#Region "Grillas"
    Public Function Cargar_Grilla_Terceros() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_Terceros", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Function Cargar_Grilla_RepuestosPorOrden() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_RepuestosPorOrden", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Function Cargar_Grilla_Ordenes() As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_Ordenes", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Function Cargar_Grilla_OrdenesP(progreso As String) As DataTable
        Dim tabla As New DataTable

        Using conexion As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Cargar_Grilla_Ordenes_Progreso", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@Progreso", progreso)
                Dim datadapter As New SqlDataAdapter(comando)
                datadapter.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function
#End Region

#Region "Buscar"
    Public Function Buscar_DatosOrdenReparacion_ID(ID_Orden As Integer) As DataSet
        Using connection As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("Buscar_DatosOrdenReparacion_ID", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID_Orden", ID_Orden)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()

            connection.Open()
            adapter.Fill(ds)
            connection.Close()

            Return ds
        End Using
    End Function

    Public Function BuscarRepuestoPorID(ID_Repuesto As Integer) As DataRow
        Using connection As New SqlConnection(connectionString)
            Dim comando As New SqlCommand("Buscar_Repuesto_Por_ID", connection)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@ID_Repuesto", ID_Repuesto)

            Dim adapter As New SqlDataAdapter(comando)
            Dim ds As New DataSet()

            connection.Open()
            adapter.Fill(ds)
            connection.Close()

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0).Rows(0)
            Else
                Return Nothing
            End If
        End Using
    End Function
#End Region

#Region "Agregar"
    Public Function Agregar_Orden_Reparacion(ID_Vehiculo As Integer, Senas As String, Motivo As String, Turno As Date, Entrada As Date,
                      Salida As Date, ID_Persona As Integer, Repuestos As Decimal, Serv3 As Decimal, MObra As Decimal, subtotal As Decimal, iva As Decimal, montoIva As Decimal, Total As Decimal,
                      Estado As Boolean, TipoRep As Integer, Progreso As String, transaction As SqlTransaction) As Integer

        Dim ID_Orden As Integer

        Using command As New SqlCommand("Agregar_Orden_Reparacion", transaction.Connection)
            command.CommandType = CommandType.StoredProcedure
            command.Transaction = transaction

            command.Parameters.AddWithValue("@ID_Vehiculo", ID_Vehiculo)
            command.Parameters.AddWithValue("@Senas", Senas)
            command.Parameters.AddWithValue("@Motivo", Motivo)
            command.Parameters.AddWithValue("@Turno", Turno)
            command.Parameters.AddWithValue("@Entrada", Entrada)
            command.Parameters.AddWithValue("@Salida", Salida)
            command.Parameters.AddWithValue("@ID_Persona", ID_Persona)
            command.Parameters.AddWithValue("@Repuestos", Repuestos)
            command.Parameters.AddWithValue("@Serv3", Serv3)
            command.Parameters.AddWithValue("@MObra", MObra)
            command.Parameters.AddWithValue("@Subtotal", subtotal)
            command.Parameters.AddWithValue("@IVAPorc", iva)
            command.Parameters.AddWithValue("@IVAmonto", montoIva)
            command.Parameters.AddWithValue("@Total", Total)
            command.Parameters.AddWithValue("@Estado", Estado)
            command.Parameters.AddWithValue("@ID_TipoReparacion", TipoRep)
            command.Parameters.AddWithValue("@ProgresoOrden", Progreso)

            Dim outputParam As New SqlParameter("@ID_Orden", SqlDbType.Int)
            outputParam.Direction = ParameterDirection.Output
            command.Parameters.Add(outputParam)

            Try
                command.ExecuteNonQuery()

                ID_Orden = Convert.ToInt32(outputParam.Value)
            Catch ex As Exception
                Throw ex
            End Try
        End Using
        Return ID_Orden
    End Function

    Public Sub Agregar_Servicio_Terceros(id_orden As Integer, FechaSolicitud As DateTime, id_prestador As Integer, ServSolicitado As String,
                         CostoEstimado As Decimal, CostoReal As Decimal, Finalizado As Boolean, Estado As Boolean, transaction As SqlTransaction)

        Using connection As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Agregar_Servicio_Terceros", connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_OrdenReparacion", id_orden)
                comando.Parameters.AddWithValue("@Fecha_Solicitud_Trabajo", FechaSolicitud)
                comando.Parameters.AddWithValue("@ID_Persona", id_prestador)
                comando.Parameters.AddWithValue("@Detalle_Prestacion", ServSolicitado)
                comando.Parameters.AddWithValue("@Costo_Estimado", CostoEstimado)
                comando.Parameters.AddWithValue("@Costo_Real", CostoReal)
                comando.Parameters.AddWithValue("@Estado_Trabajo", Finalizado)
                comando.Parameters.AddWithValue("@Estado", Estado)

                connection.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Agregar_Repuestos_Ordenes(id_repuesto As Integer, id_orden As Integer, cantidad As Decimal, precio As Decimal,
                                         activo As Boolean, transaction As SqlTransaction)
        Using connection As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Agregar_Repuestos_Ordenes", connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_repuesto", id_repuesto)
                comando.Parameters.AddWithValue("@id_ordenreparacion", id_orden)
                comando.Parameters.AddWithValue("@cantidad", cantidad)
                comando.Parameters.AddWithValue("@precio", precio)
                comando.Parameters.AddWithValue("@Estado", activo)

                connection.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
#End Region

#Region "Modificar"
    Public Sub Modificar_OrdenReparacion(id_orden As Integer, id_vehiculo As Integer, señasparticulares As String, motivoreparacion As String,
                        turno As DateTime, entrada As DateTime, salida As DateTime, id_persona As Integer, montorepuestos As Decimal,
                        montoservicios As Decimal, montomanoobra As Decimal, subtotal As Decimal, iva As Decimal, montoIva As Decimal, montototal As Decimal, activo As Boolean,
                        ID_TipoReparacion As Integer, ProgresoOrden As String, transaction As SqlTransaction)

        Using conection As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Modificar_Orden_Reparacion", conection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_Orden", id_orden)
                comando.Parameters.AddWithValue("@ID_Vehiculo", id_vehiculo)
                comando.Parameters.AddWithValue("@Senas", señasparticulares)
                comando.Parameters.AddWithValue("@Motivo", motivoreparacion)
                comando.Parameters.AddWithValue("@Turno", turno)
                comando.Parameters.AddWithValue("@Entrada", entrada)
                comando.Parameters.AddWithValue("@Salida", salida)
                comando.Parameters.AddWithValue("@ID_Persona", id_persona)
                comando.Parameters.AddWithValue("@Repuestos", montorepuestos)
                comando.Parameters.AddWithValue("@Serv3", montoservicios)
                comando.Parameters.AddWithValue("@MObra", montomanoobra)
                comando.Parameters.AddWithValue("@Subtotal", subtotal)
                comando.Parameters.AddWithValue("@IVAPorc", iva)
                comando.Parameters.AddWithValue("@IVAmonto", montoIva)
                comando.Parameters.AddWithValue("@Total", montototal)
                comando.Parameters.AddWithValue("@Estado", activo)
                comando.Parameters.AddWithValue("@ID_TipoReparacion", ID_TipoReparacion)
                comando.Parameters.AddWithValue("@ProgresoOrden", ProgresoOrden)

                conection.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
#End Region

#Region "Dar de baja"
    Public Sub DarDeBaja_ServiciosTerceros(id_orden As Integer, transaction As SqlTransaction)
        Using connection As New SqlConnection(connectionString)
            Using comando As New SqlCommand("DarDeBaja_ServiciosTerceros", connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_orden", id_orden)

                connection.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DarDeBajaRepuestos_Ordenes(id_orden As Integer, transaction As SqlTransaction)
        Using connection As New SqlConnection(connectionString)
            Using comando As New SqlCommand("DarDeBajaRepuestos", connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_orden", id_orden)

                connection.Open()
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
#End Region

#Region "Obtener Datos"
    Public Function ObtenerDatosPersona(ByVal idPersona As Integer) As DataTable
        Dim tabla As New DataTable()
        Using connection As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Obtener_Datos_Persona", connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_Persona", idPersona)
                Dim da As New SqlDataAdapter(comando)
                da.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function

    Public Function ObtenerDatosVehiculo(ByVal idVehiculo As Integer) As DataTable
        Dim tabla As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Using comando As New SqlCommand("Obtener_Datos_Vehiculo", connection)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@ID_Vehiculo", idVehiculo)
                Dim da As New SqlDataAdapter(comando)
                da.Fill(tabla)
            End Using
        End Using
        Return tabla
    End Function
#End Region

End Class
