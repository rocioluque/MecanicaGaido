Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class AD_ServicioTerceros

    Private connectionString As String

    Public Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"

    End Sub

    Public Sub Agregar_Servicio_Terceros(
                                     ID_OrdenReparacion As Integer,
                                     Fecha_Solicitud_Trabajo As Date,
                                     ID_Persona As Integer,
                                     Detalle_Prestacion As String,
                                     Costo_Estimado As Decimal,
                                     Costo_Real As Decimal,
                                     Estado_Trabajo As Boolean,
                                     Estado As Boolean,
                                     transaction As SqlTransaction)

        Using command As New SqlCommand("Agregar_Servicio_Terceros", transaction.Connection)
            command.CommandType = CommandType.StoredProcedure
            command.Transaction = transaction

            command.Parameters.AddWithValue("@ID_OrdenReparacion", ID_OrdenReparacion)
            command.Parameters.AddWithValue("@Fecha_Solicitud_Trabajo", Fecha_Solicitud_Trabajo)
            command.Parameters.AddWithValue("@ID_Persona", ID_Persona)
            command.Parameters.AddWithValue("@Detalle_Prestacion", Detalle_Prestacion)
            command.Parameters.AddWithValue("@Costo_Estimado", Costo_Estimado)
            command.Parameters.AddWithValue("@Costo_Real", Costo_Real)
            command.Parameters.AddWithValue("@Estado_Trabajo", Estado_Trabajo)
            command.Parameters.AddWithValue("@Estado", Estado)

            Try
                command.ExecuteNonQuery()

            Catch ex As System.Exception
                Throw ex
            End Try
        End Using
    End Sub


End Class
