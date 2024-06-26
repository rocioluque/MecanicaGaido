Imports System.Net
Imports System.Net.Mail

Public MustInherit Class ServidorCorreo

    Private smtpClient As SmtpClient
    Protected remitenteCorreo As String
    Protected contraseña As String
    Protected host As String
    Protected port As String
    Protected ssl As String

    Protected Sub inicializacionSmtpClient()
        smtpClient = New SmtpClient With {
            .Credentials = New NetworkCredential(remitenteCorreo, contraseña),
            .Host = host,
            .Port = port,
            .EnableSsl = ssl
        }
    End Sub

    Public Sub enviarCorreo(asunto As String, body As String, receptorCorreo As List(Of String))
        Dim mensajeCorreo As New MailMessage

        Try
            mensajeCorreo.From = New MailAddress(remitenteCorreo)
            For Each destinatarioCorreo As String In receptorCorreo
                mensajeCorreo.To.Add(destinatarioCorreo)
            Next
            mensajeCorreo.Subject = asunto
            mensajeCorreo.Body = body
            mensajeCorreo.Priority = MailPriority.Normal

            smtpClient.Send(mensajeCorreo)
        Catch ex As Exception
            MsgBox("Error al enviar el correo: " & ex.Message, vbCritical, "Error")
        Finally
            mensajeCorreo.Dispose()
            smtpClient.Dispose()
        End Try
    End Sub

End Class
