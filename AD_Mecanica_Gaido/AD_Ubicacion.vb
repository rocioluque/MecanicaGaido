Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class AD_Ubicacion

    Dim oDatabase As Database

    Public Sub New()
        Try
            DatabaseFactory.SetDatabaseProviderFactory(New DatabaseProviderFactory())
        Catch ex As InvalidOperationException

        End Try
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function BuscarDepositos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Consultar_Depositos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarDepositoPorID(ID As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Consultar_Deposito_ID", ID)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar_Deposito(Nombre As String, Estanterias As Integer, Columnas As Integer, Filas As Integer, Estado As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("Agregar_Deposito", Nombre, Estanterias, Columnas, Filas, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar_Deposito(ID As Integer, Nombre As String, Estanterias As Integer, Columnas As Integer, Filas As Integer, Estado As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Modificar_Deposito", ID, Nombre, Estanterias, Columnas, Filas, Estado)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function




End Class
