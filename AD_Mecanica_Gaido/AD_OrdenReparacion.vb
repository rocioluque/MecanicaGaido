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



#Region "Procedimientos"



    Public Function Buscar_DatosOrdenReparacion_ID(ID_Orden As Integer) As DataSet
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("Buscar_DatosOrdenReparacion_ID", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID_Orden", ID_Orden)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()

            conn.Open()
            adapter.Fill(ds)
            conn.Close()

            Return ds
        End Using
    End Function

    Public Function BuscarRepuestoPorID(ID_Repuesto As Integer) As DataRow
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("Buscar_Repuesto_Por_ID", conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID_Repuesto", ID_Repuesto)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()

            conn.Open()
            adapter.Fill(ds)
            conn.Close()

            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0).Rows(0)
            Else
                Return Nothing
            End If
        End Using
    End Function


    Public Function Agregar_Orden_Reparacion(
                                         ID_Vehiculo As Integer,
                                         Senas As String,
                                         Motivo As String,
                                         Turno As Date,
                                         Entrada As Date,
                                         Salida As Date,
                                         ID_Persona As Integer,
                                         Repuestos As Decimal,
                                         Serv3 As Decimal,
                                         MObra As Decimal,
                                         Total As Decimal,
                                         Estado As Boolean,
                                         TipoRep As Integer,
                                         Progreso As String,
                                         transaction As SqlTransaction) As Integer

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

    Public Sub Modificar_OrdenReparacion(id_orden As Integer,
                                         id_vehiculo As Integer,
                                         señasparticulares As String,
                                         motivoreparacion As String,
                                         turno As DateTime,
                                         entrada As DateTime,
                                         salida As DateTime,
                                         id_persona As Integer,
                                         montorepuestos As Decimal,
                                         montoservicios As Decimal,
                                         montomanoobra As Decimal,
                                         montototal As Decimal,
                                         activo As Boolean,
                                         ID_TipoReparacion As Integer,
                                         ProgresoOrden As String,
                                         transaction As SqlTransaction)

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("Modificar_Orden_Reparacion", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID_Orden", id_orden)
                cmd.Parameters.AddWithValue("@ID_Vehiculo", id_vehiculo)
                cmd.Parameters.AddWithValue("@Senas", señasparticulares)
                cmd.Parameters.AddWithValue("@Motivo", motivoreparacion)
                cmd.Parameters.AddWithValue("@Turno", turno)
                cmd.Parameters.AddWithValue("@Entrada", entrada)
                cmd.Parameters.AddWithValue("@Salida", salida)
                cmd.Parameters.AddWithValue("@ID_Persona", id_persona)
                cmd.Parameters.AddWithValue("@Repuestos", montorepuestos)
                cmd.Parameters.AddWithValue("@Serv3", montoservicios)
                cmd.Parameters.AddWithValue("@MObra", montomanoobra)
                cmd.Parameters.AddWithValue("@Total", montototal)
                cmd.Parameters.AddWithValue("@Estado", activo)
                cmd.Parameters.AddWithValue("@ID_TipoReparacion", ID_TipoReparacion)
                cmd.Parameters.AddWithValue("@ProgresoOrden", ProgresoOrden)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DarDeBaja_ServiciosTerceros(id_orden As Integer, transaction As SqlTransaction)
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("DarDeBaja_ServiciosTerceros", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_orden", id_orden)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Agregar_Servicio_Terceros(id_orden As Integer,
                                         FechaSolicitud As DateTime,
                                         id_prestador As Integer,
                                         ServSolicitado As String,
                                         CostoEstimado As Decimal,
                                         CostoReal As Decimal,
                                         Finalizado As Boolean,
                                         Estado As Boolean,
                                         transaction As SqlTransaction)

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("Agregar_Servicio_Terceros", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID_OrdenReparacion", id_orden)
                cmd.Parameters.AddWithValue("@Fecha_Solicitud_Trabajo", FechaSolicitud)
                cmd.Parameters.AddWithValue("@ID_Persona", id_prestador)
                cmd.Parameters.AddWithValue("@Detalle_Prestacion", ServSolicitado)
                cmd.Parameters.AddWithValue("@Costo_Estimado", CostoEstimado)
                cmd.Parameters.AddWithValue("@Costo_Real", CostoReal)
                cmd.Parameters.AddWithValue("@Estado_Trabajo", Finalizado)
                cmd.Parameters.AddWithValue("@Estado", Estado)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DarDeBajaRepuestos_Ordenes(id_orden As Integer, transaction As SqlTransaction)
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("DarDeBajaRepuestos", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_orden", id_orden)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Agregar_Repuestos_Ordenes(id_repuesto As Integer, id_orden As Integer, cantidad As Decimal, precio As Decimal, activo As Boolean, transaction As SqlTransaction)
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("Agregar_Repuestos_Ordenes", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_repuesto", id_repuesto)
                cmd.Parameters.AddWithValue("@id_ordenreparacion", id_orden)
                cmd.Parameters.AddWithValue("@cantidad", cantidad)
                cmd.Parameters.AddWithValue("@precio", precio)
                cmd.Parameters.AddWithValue("@Estado", activo)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub




#End Region


End Class
