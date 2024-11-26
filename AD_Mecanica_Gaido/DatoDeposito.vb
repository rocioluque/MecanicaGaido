Public Class DatoDeposito
    Public Property Lugar As String
    Public Property Estanteria As String
    Public Property Columna As String
    Public Property Fila As String
    Public Property CodDep As String

    Public Sub New(lugar As String, estanteria As String, columna As String, fila As String, codDep As String)
        Me.Lugar = lugar
        Me.Estanteria = estanteria
        Me.Columna = columna
        Me.Fila = fila
        Me.CodDep = codDep
    End Sub





End Class