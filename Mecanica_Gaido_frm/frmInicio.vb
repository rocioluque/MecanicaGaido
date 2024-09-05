Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization
Imports AD_Mecanica_Gaido

Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net

Public Class frmInicio
    Dim o_reportes As New AD_Reportes()
    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHora.Visible = True
        lblFecha.Visible = True
        MostrarClima()
        cargar_grafico_Repuestos()
    End Sub



#Region "Clima"



    Private Async Function ObtenerCoordenadasAsync() As Task(Of (Double, Double))
        Dim apiKey As String = "c4487647d6604ceab54adf28379eb4f6"
        Dim url As String = $"https://api.ipgeolocation.io/ipgeo?apiKey={apiKey}"

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(url)
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim data As JObject = JObject.Parse(json)
                Dim lat As Double = data("latitude").Value(Of Double)()
                Dim lon As Double = data("longitude").Value(Of Double)()
                Return (lat, lon)
            Else
                MessageBox.Show("No se pudo obtener la ubicación.")
                Return (0, 0)
            End If
        End Using
    End Function


    'Private Async Function ObtenerClimaAsync(lat As Double, lon As Double) As Task(Of Clima)
    '    Dim apiKey As String = "89cff514fec4a4da7077ca6b99f9a8d2"
    '    Dim url As String = $"http://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&units=metric&appid={apiKey}&lang=es"

    '    Using client As New HttpClient()
    '        Dim response As HttpResponseMessage = Await client.GetAsync(url)
    '        If response.IsSuccessStatusCode Then
    '            Dim json As String = Await response.Content.ReadAsStringAsync()
    '            Dim climaData As Clima = JsonConvert.DeserializeObject(Of Clima)(json)
    '            Return climaData
    '        Else
    '            MessageBox.Show("No se pudo obtener los datos del clima.")
    '            Return Nothing
    '        End If
    '    End Using
    'End Function

    ' Método para obtener los datos del clima actual
    Private Async Function ObtenerClimaAsync(lat As String, lon As String) As Task(Of Clima)
        Dim apiKey As String = "89cff514fec4a4da7077ca6b99f9a8d2"
        Dim url As String = $"http://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&units=metric&appid={apiKey}&lang=es"

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(url)
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Dim climaData As Clima = JsonConvert.DeserializeObject(Of Clima)(json)
                Return climaData
            Else
                MessageBox.Show("No se pudo obtener los datos del clima.")
                Return Nothing
            End If
        End Using
    End Function



    Private Async Sub MostrarClima()

        Dim coordenadas = Await ObtenerCoordenadasAsync()
        Dim lat As String = coordenadas.Item1.ToString()
        Dim lon As String = coordenadas.Item2.ToString()

        Dim apiKey As String = "89cff514fec4a4da7077ca6b99f9a8d2"


        Dim clima = Await ObtenerClimaAsync(lat, lon)

        If clima IsNot Nothing Then
            lblUbicacion.Text = $"{clima.Name}, {clima.Sys.Country}"
            lblDescripcion.Text = clima.Weather(0).Description
            lblTemperatura.Text = $"Temperatura: {clima.Main.Temp}°C"
            lblSensacionTermica.Text = $"Sensación térmica: {clima.Main.Feels_Like}°C"
            lblHumedad.Text = $"Humedad: {clima.Main.Humidity}%"
            lblVisibilidad.Text = $"Visibilidad: {clima.Visibility / 1000} km"
            lblViento.Text = $"Viento: {(clima.Wind.Speed) * 3.6} km/h"


        Else
            MessageBox.Show("No se pudo obtener los datos del clima.")
        End If
    End Sub



#End Region


#Region "Fecha y Hora"
    Private Sub horaFecha_Tick(sender As Object, e As EventArgs) Handles horaFecha.Tick
        lblHora.Text = DateTime.Now.ToLongTimeString
        lblFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy")
    End Sub
#End Region

#Region "Grafico"
    Public Sub cargar_grafico_Repuestos()
        chtRepuestos.Series.Clear()
        chtRepuestos.ChartAreas.Clear()

        ' Crear una nueva área de gráfico
        Dim chartArea As New ChartArea()
        chtRepuestos.ChartAreas.Add(chartArea)

        chtRepuestos.ChartAreas(0).BackColor = Color.Transparent

        ' Crear y configurar la serie para el gráfico tipo Pie
        Dim series As New Series()
        series.ChartType = SeriesChartType.Pie
        chtRepuestos.Series.Add(series)

        Dim datos As Tuple(Of Integer, Integer, Integer) = o_reportes.ObtenerDatosRepuestos()
        Dim muchos As Integer = datos.Item1
        Dim cero As Integer = datos.Item2
        Dim pocos As Integer = datos.Item3

        ' Agregar datos al gráfico
        chtRepuestos.Series(0).Points.AddXY("En Stock.", muchos)
        chtRepuestos.Series(0).Points.AddXY("Sin Stock.", cero)
        chtRepuestos.Series(0).Points.AddXY("Pocos.", pocos)

        ' Personalizar etiquetas
        chtRepuestos.Series(0).Points(0).Label = String.Format("En Stock: {0}", muchos)
        chtRepuestos.Series(0).Points(1).Label = String.Format("Sin Stock: {0}", cero)
        chtRepuestos.Series(0).Points(2).Label = String.Format("Poca Cantidad: {0}", pocos)

    End Sub

    Private Sub chtRepuestos_Click(sender As Object, e As EventArgs) Handles chtRepuestos.Click
        Cargar_Grilla_Reportes1()
        Cargar_Grilla_Reportes2()
    End Sub
#End Region

#Region "Cargar Grilla"
    Public Sub Cargar_Grilla_Reportes1()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_Reportes1")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdGrilla1.AutoGenerateColumns = True
                grdGrilla1.DataSource = oDs.Tables(0)



                grdGrilla1.Refresh()
            Else
                MsgBox("No se encontraron datos para mostrar.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al cargar la grilla: " & ex.Message, vbCritical, "Error")
        Finally
        End Try
    End Sub

    Public Sub Cargar_Grilla_Reportes2()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_Reportes2")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdGrilla2.AutoGenerateColumns = True
                grdGrilla2.DataSource = oDs.Tables(0)



                grdGrilla2.Refresh()
            Else
                MsgBox("No se encontraron datos para mostrar.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al cargar la grilla: " & ex.Message, vbCritical, "Error")
        Finally
        End Try
    End Sub
#End Region

    Private Sub btnExportarPDF_Click(sender As Object, e As EventArgs) Handles btnExportarPDF.Click
        frmAgregarPedidoRepuesto.ShowDialog()
    End Sub

#Region "Dolar"


    Private Sub btnDolar_Click(sender As Object, e As EventArgs) Handles btnDolar.Click
        ' Token de autenticación (reemplaza con tu propio token)
        Dim token As String = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE3NTcwMzc4NDAsInR5cGUiOiJleHRlcm5hbCIsInVzZXIiOiJmYWJyaWNpb3J1aXo2NjhAZ21haWwuY29tIn0.UqXVuir-Uv7QeTwB0AZwT1M3MhLmp_PKuPo2VYxq5flrafZQ7SililKIV9QVS48QRr1q3IGgaYYEVa5gjWmHHg"

        ' URL de la API para consultar la cotización del dólar
        Dim url As String = "https://api.estadisticasbcra.com/usd"

        ' Realizar la solicitud HTTP
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        request.Method = "GET"
        request.Headers.Add("Authorization", "BEARER " & token)

        Try
            ' Obtener la respuesta
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            Dim reader As New StreamReader(response.GetResponseStream())
            Dim jsonResponse As String = reader.ReadToEnd()

            ' Parsear la respuesta JSON
            Dim jsonData As JArray = JArray.Parse(jsonResponse)

            ' Extraer la cotización más reciente (último valor)
            Dim cotizacionDolar As Decimal = jsonData.Last("v").Value(Of Decimal)()

            ' Mostrar la cotización en un TextBox
            txtCotizacionDolar.Text = cotizacionDolar.ToString("0.00")

        Catch ex As Exception
            MessageBox.Show("Error al obtener la cotización: " & ex.Message)
        End Try
    End Sub

#End Region

End Class