Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration
Imports Comun_Soporte

Public Class AD_Login
    Inherits ConnectionToSql

    Public Function solicitarContraseñaUsuario(solicitarUsuario As String) As String
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand("solicitarContraseñaUsuario", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@usuario", solicitarUsuario)
                command.Parameters.AddWithValue("@correo", solicitarUsuario)

                Using reader = command.ExecuteReader()
                    If reader.Read() = True Then

                        Dim NombreUsuario = reader.GetString(2) & " " & reader.GetString(3)
                        Dim correoUsuario = reader.GetString(4)
                        Dim contraseñaUsuario = reader.GetString(1)

                        Dim correoSoporte As New SoporteSistemaCorreo
                        correoSoporte.enviarCorreo(asunto:="SISTEMA: Solicitud de recuperación de contraseña",
                                                    body:="Hola " & NombreUsuario & vbNewLine & "Solicitaste recuperar tu contraseña." & vbNewLine &
                                                    "Tu actual contraseña es: " & contraseñaUsuario,
                                                    receptorCorreo:=New List(Of String) From {correoUsuario})
                        Return "Hola " & NombreUsuario & vbNewLine & "Solicitaste recuperar tu contraseña." & vbNewLine & "Por favor revisa tu correo." & vbNewLine & correoUsuario
                    Else
                        Return "Lo siento, no tienes una cuenta con este nombre de usuario o correo electrónico."
                    End If
                End Using
            End Using
        End Using
    End Function
    Public Function ValidarUsuario(ByVal usuario As String, ByVal contraseña As String) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand("ValidarUsuario", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@usuario", usuario)
                command.Parameters.AddWithValue("@contraseña", contraseña)

                Dim count = Convert.ToInt32(command.ExecuteScalar())

                If count > 0 Then
                    CargarUsuario_MenuPrincipal(usuario)
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Sub CargarUsuario_MenuPrincipal(ByVal usuario As String)
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand("CargarUsuario_MenuPrincipal", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@usuario", usuario)

                Using reader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            UsuarioActivo.usuario = reader.GetString(0)
                            UsuarioActivo.nombre_rol = reader.GetString(1)
                            UsuarioActivo.nombrePersona = reader.GetString(2)
                            UsuarioActivo.apellidoPersona = reader.GetString(3)
                            UsuarioActivo.correoPersona = reader.GetString(4)
                        End While
                    End If
                End Using
            End Using
        End Using
    End Sub

End Class
