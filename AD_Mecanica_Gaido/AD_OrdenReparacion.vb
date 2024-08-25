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


    Public Sub Modificar_Orden_Reparacion(
                                                 ID_Orden As Integer,
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
                                                Estado As Boolean)
        Using conn As New SqlConnection(connectionString)
            Using command As New SqlCommand("Modificar_Orden_Reparacion", conn)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@ID_Orden", ID_Orden)

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

                Try
                    conn.Open()
                    command.ExecuteNonQuery()
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Using
            conn.Close()
        End Using
    End Sub

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
                                                transaction As SqlTransaction) As Integer
        Dim ID_Orden
        Using conn As New SqlConnection(connectionString)
            Using command As New SqlCommand("Agregar_Orden_Reparacion", conn)
                ID_Orden = command.CommandType = CommandType.StoredProcedure


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

                Try
                    conn.Open()
                    command.ExecuteScalar()
                    Return ID_Orden
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Using
            conn.Close()
        End Using
    End Function

    Public Sub Agregar_Servicio_Terceros(ID_OrdenReparacion As Integer,
                                                Fecha_Solicitud_Trabajo As Date,
                                                ID_Persona As Integer,
                                                Detalle_Prestacion As String,
                                                Costo_Estimado As Decimal,
                                                Costo_Real As Decimal,
                                                Estado_Trabajo As Boolean,
                                                Estado As Boolean,
                                                transaction As SqlTransaction)

        Using conn As New SqlConnection(connectionString)
            Using command As New SqlCommand("Agregar_Servicio_Terceros", conn)
                command.CommandType = CommandType.StoredProcedure


                command.Parameters.AddWithValue("@ID_OrdenReparacion", ID_OrdenReparacion)
                command.Parameters.AddWithValue("@Fecha_Solicitud_Trabajo", Fecha_Solicitud_Trabajo)
                command.Parameters.AddWithValue("@ID_Persona", ID_Persona)
                command.Parameters.AddWithValue("@Detalle_Prestacion", Detalle_Prestacion)
                command.Parameters.AddWithValue("@Costo_Estimado", Costo_Estimado)
                command.Parameters.AddWithValue("@Costo_Real", Costo_Real)
                command.Parameters.AddWithValue("@Estado_Trabajo", Estado_Trabajo)
                command.Parameters.AddWithValue("@Estado", Estado)

                Try
                    conn.Open()
                    command.ExecuteScalar()

                Catch ex As System.Exception
                    Throw ex
                End Try
            End Using
            conn.Close()
        End Using
    End Sub

    Public Sub Agregar_Repuestos_Ordenes(ID_Repuesto As Integer,
                                           ID_OrdenReparacion As Integer,
                                           Cantidad As Decimal,
                                           Precio As Decimal,
                                           Estado As Boolean,
                                           transaction As SqlTransaction)

        Using conn As New SqlConnection(connectionString)
            Using command As New SqlCommand("Agregar_Repuestos_Ordenes", conn)
                command.CommandType = CommandType.StoredProcedure


                command.Parameters.AddWithValue("@ID_Repuesto", ID_Repuesto)
                command.Parameters.AddWithValue("@ID_OrdenReparacion", ID_OrdenReparacion)
                command.Parameters.AddWithValue("@Cantidad", Cantidad)
                command.Parameters.AddWithValue("@Precio", Precio)
                command.Parameters.AddWithValue("@Estado", Estado)
                Try
                    conn.Open()
                    command.ExecuteScalar()

                Catch ex As System.Exception
                    Throw ex
                End Try
            End Using
            conn.Close()
        End Using
    End Sub

    Public Function Consultar_StockDisponiblePorID(ByVal ID_Repuestos As Integer, transaction As SqlTransaction) As Decimal
        Dim stockDisponible As Integer = 0

        Using conn As New SqlConnection(connectionString)
            Using command As New SqlCommand("Consultar_StockDisponiblePorID", conn)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@ID_Repuestos", ID_Repuestos)

                Try
                    conn.Open()
                    Dim result As Object = command.ExecuteNonQuery()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        stockDisponible = Convert.ToDecimal(result)
                    End If
                Catch ex As Exception
                    Throw ex
                End Try
            End Using
        End Using

        Return stockDisponible
    End Function

    Public Sub Modificar_StockDisponiblePorID(ID_Repuestos As Integer, stockDisponible As Decimal, transaction As SqlTransaction)
        Using conn As New SqlConnection(connectionString)
            Using command As New SqlCommand("Modificar_StockDisponiblePorID", conn)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@ID_Repuestos", ID_Repuestos)
                command.Parameters.AddWithValue("@StockDisponible", stockDisponible)

                Try
                    conn.Open()
                    command.ExecuteNonQuery()

                Catch ex As Exception
                    Throw ex
                End Try
            End Using
            conn.Close()
        End Using

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

#End Region

#Region "FUNCION DE EJEMPLO"
    'Public Sub Agregar_Empleado_Usuario(ByVal idPersona As Integer, ByVal usuario As String, ByVal contraseña As String, ByVal idRol As Integer,
    '                                    ByVal fechaContratacion As Date, ByVal cargo As String, ByVal nota As String, ByVal estado As Boolean,
    '                                    ByVal idSeccion As Integer)
    '    Dim conexion As New SqlConnection(connectionString)
    '    Dim comando As New SqlCommand("Agregar_Empleado_Usuario", conexion)
    '    comando.CommandType = CommandType.StoredProcedure

    '    ' Agregar parámetros
    '    comando.Parameters.AddWithValue("@ID_Persona", idPersona)
    '    comando.Parameters.AddWithValue("@Usuario", usuario)
    '    comando.Parameters.AddWithValue("@Contraseña", contraseña)
    '    comando.Parameters.AddWithValue("@ID_Rol", idRol)
    '    comando.Parameters.AddWithValue("@FechaDeContratacion", fechaContratacion)
    '    comando.Parameters.AddWithValue("@Cargo", cargo)
    '    comando.Parameters.AddWithValue("@Nota", nota)
    '    comando.Parameters.AddWithValue("@Estado", estado)
    '    comando.Parameters.AddWithValue("@ID_Seccion", idSeccion)

    '    Try
    '        conexion.Open()
    '        comando.ExecuteNonQuery()
    '    Catch ex As Exception
    '        Throw New Exception("Ocurrió un error al insertar los datos: " & ex.Message)
    '    Finally
    '        conexion.Close()
    '    End Try
    'End Sub

#End Region

#Region "Procedimientos"

    '    Public Sub Agregar_Orden_Reparacion(@ID_Vehiculo int,
    '@Senas varchar(100),  
    '@Motivo varchar(200),  
    '@Turno datetime,  
    '@Entrada datetime ,  
    '@Salida datetime,  
    '@ID_Persona int ,  
    '@Repuestos money ,  
    '@Serv3 money ,  
    '@MObra money ,  
    '@Total money ,  
    '@Estado bit
    '                                       )
    '        Dim conexion As New SqlConnection(connectionString)
    '        Dim comando As New SqlCommand("Agregar_Empleado_Usuario", conexion)
    '        comando.CommandType = CommandType.StoredProcedure

    '        ' Agregar parámetros
    '        comando.Parameters.AddWithValue("@ID_Persona", idPersona)
    '        comando.Parameters.AddWithValue("@Usuario", usuario)
    '        comando.Parameters.AddWithValue("@Contraseña", contraseña)
    '        comando.Parameters.AddWithValue("@ID_Rol", idRol)
    '        comando.Parameters.AddWithValue("@FechaDeContratacion", fechaContratacion)
    '        comando.Parameters.AddWithValue("@Cargo", cargo)
    '        comando.Parameters.AddWithValue("@Nota", nota)
    '        comando.Parameters.AddWithValue("@Estado", estado)
    '        comando.Parameters.AddWithValue("@ID_Seccion", idSeccion)

    '        Try
    '            conexion.Open()
    '            comando.ExecuteNonQuery()
    '        Catch ex As Exception
    '            Throw New Exception("Ocurrió un error al insertar los datos: " & ex.Message)
    '        Finally
    '            conexion.Close()
    '        End Try
    '    End Sub


#End Region


End Class
