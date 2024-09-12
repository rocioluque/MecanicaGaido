Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports AD_Mecanica_Gaido
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.Data.Common
Public Class frmAFIP

    Private firstTime As Boolean = True


    ' Evento del botón para validar el CUIT
    Private Async Sub BtnValidarCUIT_Click(sender As Object, e As EventArgs) Handles BtnValidarCUIT.Click
        Dim cuit As String = TxtCUIT.Text

        ' Validar que el CUIT tenga 11 dígitos
        If cuit.Length <> 11 Then
            MessageBox.Show("El CUIT debe tener 11 dígitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' URL de la API
        Dim apiUrl As String = $"https://recetas.instantagro.goodapps.com.ar/GetContribuyente.ashx?CUIT={cuit}"

        Try
            ' Realizar la solicitud HTTP
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)
                response.EnsureSuccessStatusCode()

                Dim responseBody As String = Await response.Content.ReadAsStringAsync()

                ' Verificar si el CUIT no existe
                If responseBody.Contains("""error"":""No existe persona con ese Id""") Then
                    MessageBox.Show("No existe persona con ese CUIT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Deserializar la respuesta JSON
                Dim contribuyenteData As ContribuyenteResponse = JsonConvert.DeserializeObject(Of ContribuyenteResponse)(responseBody)
                ' Variable que contiene la dirección completa
                Dim direccionCompleta As String = contribuyenteData.Contribuyente.domicilioFiscal.direccion
                Dim calle As String = ""
                Dim numero As String = ""

                If direccionCompleta <> Nothing Then
                    ' Encuentra el índice del último espacio
                    Dim indiceUltimoEspacio As Integer = direccionCompleta.LastIndexOf(" "c)

                    ' Variables para almacenar la dirección y lo que hay a la derecha del espacio

                    ' Verifica si se encontró un espacio
                    If indiceUltimoEspacio <> -1 Then
                        ' Extrae la parte izquierda (todo antes del último espacio)
                        calle = direccionCompleta.Substring(0, indiceUltimoEspacio)

                        ' Extrae la parte derecha (todo después del último espacio)
                        numero = direccionCompleta.Substring(indiceUltimoEspacio + 1)
                    Else
                        ' Si no se encontró un espacio, usa la dirección completa como parte izquierda
                        calle = direccionCompleta
                    End If


                End If
                ' Actualizar los campos en el formulario con los datos obtenidos
                If contribuyenteData IsNot Nothing AndAlso Not contribuyenteData.errorGetData Then
                    TxtRazonSocial.Text = contribuyenteData.Contribuyente.nombre
                    CboProvincias.SelectedValue = contribuyenteData.Contribuyente.domicilioFiscal.idProvincia
                    cboCiudades.Text = contribuyenteData.Contribuyente.domicilioFiscal.localidad
                    TxtDomicilio.Text = calle
                    txtNro.Text = numero
                    'TxtDomicilio.Text = $"{contribuyenteData.Contribuyente.domicilioFiscal.direccion}"
                    ', {contribuyenteData.Contribuyente.domicilioFiscal.localidad}, {CboProvincias.Text}

                    ' Configurar la categoría IVA
                    If contribuyenteData.Contribuyente.EsRI Then
                        CboCategoriasIVA.SelectedValue = 2 ' Responsable Inscripto
                    ElseIf contribuyenteData.Contribuyente.EsMonotributo Then
                        CboCategoriasIVA.SelectedValue = 3 ' Monotributista
                    End If
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al conectar con la API: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Cargar_Provincias()
        Try
            Dim tabla As New DataTable

            Using conexion As New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")
                Using comando As New SqlCommand("Cargar_CboProvinciaAfip", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    Try
                        conexion.Open()
                        Dim datadapter As New SqlDataAdapter(comando)
                        datadapter.Fill(tabla)
                    Catch ex As Exception
                        Throw New Exception("Error al cargar las provincias desde la base de datos", ex)
                    End Try

                End Using
            End Using

            'Return tabla

            If tabla.Rows.Count > 0 Then
                CboProvincias.DataSource = tabla
                CboProvincias.DisplayMember = "Descripcion"
                CboProvincias.ValueMember = "Codigo"
                CboProvincias.SelectedIndex = -1
            Else
                MsgBox("No se encontraron provincias.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las provincias: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub Cargar_Ciudades(ID_Provincia As Integer)
        Try
            Dim tabla As New DataTable

            Using conexion As New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")
                Using comando As New SqlCommand("Cargar_CboCiudadesAFIP", conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@ID_Provincia", ID_Provincia)

                    conexion.Open()
                    Using lector As SqlDataReader = comando.ExecuteReader()
                        tabla.Load(lector)
                    End Using

                    If tabla.Rows.Count > 0 Then
                        cboCiudades.DataSource = tabla
                        cboCiudades.DisplayMember = "Ciudad"
                        cboCiudades.ValueMember = "ID_Ciudad"

                    Else
                        MsgBox("No se encontraron ciudades para la provincia seleccionada.", vbInformation, "Información")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al cargar las ciudades: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub CboProvincias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboProvincias.SelectedIndexChanged
        If Not firstTime Then

            Cargar_Ciudades(CboProvincias.SelectedValue)
        End If
    End Sub

    Private Sub frmAFIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Provincias()
        cargarCategoriasIVA()
        firstTime = False
    End Sub

    Private Sub cargarCategoriasIVA()


        Dim dt As New DataTable()
        dt.Columns.Add("ValueMember", GetType(Integer))
        dt.Columns.Add("DisplayMember", GetType(String))

        ' Agregar filas al DataTable
        dt.Rows.Add(1, "CONSUMIDOR FINAL")
        dt.Rows.Add(2, "RESPONSABLE INSCRIPTO")
        dt.Rows.Add(3, "MONOTRIBUTO")
        dt.Rows.Add(4, "EXENTO")

        ' Configurar el ComboBox
        With CboCategoriasIVA
            .DataSource = dt
            .ValueMember = "ValueMember"
            .DisplayMember = "DisplayMember"
        End With
    End Sub


End Class


' Clases para deserializar el JSON
Public Class ContribuyenteResponse
    Public Property Contribuyente As Contribuyente
    Public Property errorGetData As Boolean
End Class

Public Class Contribuyente
    Public Property nombre As String
    Public Property domicilioFiscal As DomicilioFiscal
    Public Property EsRI As Boolean
    Public Property EsMonotributo As Boolean
End Class

Public Class DomicilioFiscal
    Public Property direccion As String
    Public Property localidad As String
    Public Property idProvincia As Integer
End Class
