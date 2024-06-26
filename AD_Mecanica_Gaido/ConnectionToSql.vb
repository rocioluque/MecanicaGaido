Imports System.Data.SqlClient
Public MustInherit Class ConnectionToSql
    Private connectionString As String
    Protected Sub New()
        connectionString = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123"
    End Sub
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class
