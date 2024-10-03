Imports Google.Apis.Drive.v3
Imports Google.Apis.Drive.v3.Data
Imports Google.Apis.Services
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Util.Store
Imports System.IO
Imports System.Threading
Imports System.Collections.Generic


Public Class GoogleDriveUploader

    ' Define los scopes que se necesitan para trabajar con Google Drive
    Private Shared ReadOnly Scopes As String() = {DriveService.Scope.DriveFile}
    Private Shared ReadOnly ApplicationName As String = "MecanicaGaido"

    ' Método para subir el archivo
    Public Function SubirArchivoDrive(ByVal filePath As String) As String
        If String.IsNullOrEmpty(filePath) Then
            Throw New ArgumentException("La ruta del archivo no puede estar vacía o ser nula.")
        End If

        ' Autenticación
        Dim credential As UserCredential
        Using stream = New FileStream("credentials.json", FileMode.Open, FileAccess.Read)
            Dim credPath As String = "token.json"
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets,
                Scopes,
                "user",
                CancellationToken.None,
                New FileDataStore(credPath, True)).Result
        End Using

        ' Crear el servicio de Google Drive
        Dim service = New DriveService(New BaseClientService.Initializer() With {
            .HttpClientInitializer = credential,
            .ApplicationName = ApplicationName
        })

        ' Subir el archivo
        Dim fileMetadata = New Data.File() With {
            .Name = Path.GetFileName(filePath),
            .Parents = New List(Of String) From {"root"}
        }

        Dim fileStream As New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim request As FilesResource.CreateMediaUpload = service.Files.Create(fileMetadata, fileStream, "application/pdf")
        request.Fields = "id"
        request.Upload()

        ' Obtener el archivo subido
        Dim file As Data.File = request.ResponseBody

        ' Verifica si el archivo fue subido correctamente
        If file Is Nothing Then
            Throw New Exception("Error al subir el archivo a Google Drive.")
        End If

        ' Obtener el ID del archivo subido
        Dim fileId As String = file.Id

        ' Cambiar los permisos del archivo para que sea público
        Dim permiso = New Permission() With {
            .Role = "reader",
            .Type = "anyone"
        }
        service.Permissions.Create(permiso, fileId).Execute()

        ' Obtener el enlace público
        Dim enlaceDescarga As String = "https://drive.google.com/file/d/" & fileId & "/view?usp=sharing"

        Return enlaceDescarga
    End Function
End Class

