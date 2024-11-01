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

#Region "Procedimiento"
    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarClima()
        'ConsultarDolar()
        lblHora.Visible = True
        lblFecha.Visible = True
        cargar_grafico_Repuestos()
        CargarGraficoEstados()
        ConsultarDolar1()
        AplicarTema(Me)
    End Sub
#End Region

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
        G_lat = lat
        Dim lon As String = coordenadas.Item2.ToString()
        G_lon = lon
        Dim apiKey As String = "89cff514fec4a4da7077ca6b99f9a8d2"

        Dim clima = Await ObtenerClimaAsync(lat, lon)

        If clima IsNot Nothing Then
            lblUbicacion.Text = $"{clima.Name}, {clima.Sys.Country}"
            lblDescripcion.Text = Char.ToUpper(clima.Weather(0).Description(0)) & clima.Weather(0).Description.Substring(1).ToLower()
            lblTemperatura.Text = $"T: {CInt(clima.Main.Temp)}°C"
            lblSensacionTermica.Text = $"ST: {CInt(clima.Main.Feels_Like)}°C"
            lblHumedad.Text = $"{clima.Main.Humidity}%"
            lblVisibilidad.Text = $"{clima.Visibility / 1000} km"
            lblViento.Text = $"{((clima.Wind.Speed) * 3.6).ToString("F1")} km/h"
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

#Region "Grafico Repuestos"
    Public Sub cargar_grafico_Repuestos()
        chtRepuestos.Series.Clear()
        chtRepuestos.ChartAreas.Clear()

        Dim chartArea As New ChartArea()
        chtRepuestos.ChartAreas.Add(chartArea)

        chtRepuestos.ChartAreas(0).BackColor = Color.Transparent
        chtRepuestos.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Century Gothic", 9.75F)

        Dim series As New Series("Stock de Repuestos")
        series.ChartType = SeriesChartType.Pie
        series.IsValueShownAsLabel = True
        series.LabelForeColor = Color.White
        series.Font = New Font("Century Gothic", 11, FontStyle.Bold)
        chtRepuestos.Series.Add(series)

        Dim datos As Tuple(Of Integer, Integer, Integer) = o_reportes.ObtenerDatosRepuestos()
        Dim muchos As Integer = datos.Item1
        Dim cero As Integer = datos.Item2
        Dim pocos As Integer = datos.Item3

        ' Agregar datos al gráfico
        chtRepuestos.Series(0).Points.AddXY("En Stock.", muchos)
        chtRepuestos.Series(0).Points.AddXY("Sin Stock.", cero)
        chtRepuestos.Series(0).Points.AddXY("Pocos.", pocos)

        'Muestra solo la cantidad en el gráfico
        chtRepuestos.Series(0).Points(0).Label = muchos.ToString()
        chtRepuestos.Series(0).Points(1).Label = cero.ToString()
        chtRepuestos.Series(0).Points(2).Label = pocos.ToString()

        ' Personalizar el texto de la leyenda
        chtRepuestos.Series(0).Points(0).LegendText = "En Stock"
        chtRepuestos.Series(0).Points(1).LegendText = "Sin Stock"
        chtRepuestos.Series(0).Points(2).LegendText = "Poca Cantidad"

        Dim colors As Color() = {
        Color.FromArgb(28, 164, 89), 'Verde
        Color.FromArgb(240, 38, 2),  'Rojo 
        Color.FromArgb(218, 182, 3)  'Amarillo
        }

        For i As Integer = 0 To chtRepuestos.Series(0).Points.Count - 1
            chtRepuestos.Series(0).Points(i).Color = colors(i Mod colors.Length)
        Next

        chtRepuestos.BackColor = Color.Transparent
        chtRepuestos.ChartAreas(0).BackColor = Color.Transparent

        chtRepuestos.Legends.Clear()
        Dim legend As New Legend("Leyenda")
        legend.Docking = Docking.Top
        legend.BackColor = Color.Transparent
        legend.ForeColor = Color.White
        legend.Title = "Stock de Repuestos"
        legend.TitleFont = New Font("Century Gothic", 12, FontStyle.Regular)
        legend.TitleForeColor = Color.White
        chtRepuestos.Legends.Add(legend)
    End Sub
#End Region

#Region "Grafico Reparaciones"
    Private Sub CargarGraficoEstados()
        Dim o_reportes As New AD_Reportes()
        Dim dtOrdenes As DataTable = o_reportes.ObtenerOrdenesProgreso()

        ' Limpia las series anteriores del gráfico
        ChtOrdenReparacion.Series.Clear()

        ' Crear una nueva serie para el gráfico
        Dim series As New Series("Cantidad por Estado")
        series.IsVisibleInLegend = False
        series.ChartType = SeriesChartType.Column

        ' Configuración de etiquetas de la serie
        series.IsValueShownAsLabel = True
        series.LabelForeColor = Color.White
        series.Font = New Font("Century Gothic", 9.75F)

        ' Colores de la paleta SeaGreen
        Dim colors As Color() = {
        Color.FromArgb(146, 139, 87),
        Color.FromArgb(60, 179, 113),
        Color.FromArgb(32, 178, 170),
        Color.FromArgb(0, 139, 69),
        Color.FromArgb(0, 255, 127)
    }
        Dim colorIndex As Integer = 0

        ' Leer los datos del procedimiento almacenado y agregarlos al gráfico
        For Each row As DataRow In dtOrdenes.Rows
            Dim estado As String = row("Estado").ToString()
            Dim cantidad As Integer = Convert.ToInt32(row("Cantidad"))

            ' Cambia el nombre de la serie específica
            If estado = "Esperando Servicios de Terceros" Then
                estado = "Esperando S3"
            End If

            Dim pointIndex As Integer = series.Points.AddXY(estado, cantidad)

            ' Establecer el color de la serie para esta categoría
            series.Points(pointIndex).Color = colors(colorIndex Mod colors.Length)
            colorIndex += 1
        Next

        ' Agregar la serie al gráfico
        ChtOrdenReparacion.Series.Add(series)

        ' Personalización del gráfico
        ChtOrdenReparacion.ChartAreas(0).AxisX.Title = ""
        ChtOrdenReparacion.ChartAreas(0).AxisY.Title = "Cantidad de Órdenes"

        ' Configurar eje Y para mostrar solo valores enteros
        ChtOrdenReparacion.ChartAreas(0).AxisY.IsStartedFromZero = True
        ChtOrdenReparacion.ChartAreas(0).AxisY.LabelStyle.Interval = 1
        ChtOrdenReparacion.ChartAreas(0).AxisY.MajorGrid.Interval = 1

        ' Desactivar las líneas verticales
        ChtOrdenReparacion.ChartAreas(0).AxisX.MajorGrid.Enabled = False

        ' Activar solo las líneas horizontales
        ChtOrdenReparacion.ChartAreas(0).AxisY.MajorGrid.Enabled = True

        ' Configurar colores y tipografía para fondo oscuro
        ChtOrdenReparacion.BackColor = Color.Transparent
        ChtOrdenReparacion.ChartAreas(0).BackColor = Color.Transparent
        ChtOrdenReparacion.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.Transparent
        ChtOrdenReparacion.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisX.LineColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisY.LineColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Gray
        ChtOrdenReparacion.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Gray
        ChtOrdenReparacion.ChartAreas(0).AxisX.TitleForeColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisY.TitleForeColor = Color.White
        ChtOrdenReparacion.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Century Gothic", 9.75F)
        ChtOrdenReparacion.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Century Gothic", 9.75F)

        ' Configurar leyenda
        ChtOrdenReparacion.Legends.Clear()
        Dim legend As New Legend("Leyenda")
        legend.Docking = Docking.Top
        legend.BackColor = Color.Transparent
        legend.ForeColor = Color.White
        legend.Title = "Órdenes de Reparación"
        legend.TitleFont = New Font("Century Gothic", 12, FontStyle.Regular)
        legend.TitleForeColor = Color.White
        legend.Alignment = StringAlignment.Center
        ChtOrdenReparacion.Legends.Add(legend)

        For i As Integer = 0 To series.Points.Count - 1
            If series.Points(i).AxisLabel <> "Cantidad por Estado" Then
                Dim legendItem As New LegendItem()
                legendItem.Name = series.Points(i).AxisLabel
                legendItem.Color = series.Points(i).Color

                legend.CustomItems.Add(legendItem)
            End If
        Next
    End Sub

    Private Sub ChtOrdenReparacion_MouseClick(sender As Object, e As MouseEventArgs) Handles ChtOrdenReparacion.MouseClick
        Dim result As HitTestResult = ChtOrdenReparacion.HitTest(e.X, e.Y)

        If result.ChartElementType = ChartElementType.DataPoint Then
            Dim punto As DataPoint = result.Series.Points(result.PointIndex)
            Dim estado As String = punto.AxisLabel

            If estado = "Esperando S3" Then
                estado = "Esperando Servicios de Terceros"
            End If

            Dim frm As New frmOrdenesReparacion(estado, True)
            frmMenuPrincipal.AbrirFormHijo(frm, frmMenuPrincipal.btnOrdenReparacion)
        End If
    End Sub
#End Region

#Region "Dolar"
    'Private Sub ConsultarDolar()
    '    ' API Key de Open Exchange Rates (Reemplazar con tu propia API Key)
    '    Dim apiKey As String = "d0ffe5f5874d4676a5cc98ee7ec71968"

    '    ' URL de la API para consultar la cotización del dólar
    '    Dim url As String = $"https://openexchangerates.org/api/latest.json?app_id={apiKey}&symbols=USD,ARS"

    '    ' Realizar la solicitud HTTP
    '    Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
    '    request.Method = "GET"

    '    Try
    '        ' Obtener la respuesta
    '        Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
    '        Dim reader As New StreamReader(response.GetResponseStream())
    '        Dim jsonResponse As String = reader.ReadToEnd()

    '        ' Parsear la respuesta JSON
    '        Dim jsonData As JObject = JObject.Parse(jsonResponse)

    '        ' Extraer la cotización del dólar (USD a ARS)
    '        Dim cotizacionDolar As Decimal = jsonData("rates")("ARS")

    '        ' Mostrar la cotización en un TextBox
    '        lblDolar.Text = $"Dólar divisa: {cotizacionDolar.ToString("0.00")}"

    '    Catch ex As Exception
    '        MessageBox.Show("Error al obtener la cotización: " & ex.Message)
    '    End Try
    'End Sub

    'Private Async Function ConsultarDolar1() As Task
    '    Dim fechaHoy As DateTime = DateTime.Now

    '    ' Verificar si hoy es sábado o domingo
    '    If fechaHoy.DayOfWeek = DayOfWeek.Saturday Then
    '        fechaHoy = fechaHoy.AddDays(-1) ' Retroceder un día
    '    ElseIf fechaHoy.DayOfWeek = DayOfWeek.Sunday Then
    '        fechaHoy = fechaHoy.AddDays(-2) ' Retroceder dos días
    '    ElseIf fechaHoy.DayOfWeek = DayOfWeek.Monday AndAlso fechaHoy.Hour < 10 Then
    '        fechaHoy = fechaHoy.AddDays(-3) ' Retroceder tres días (viernes anterior)
    '    ElseIf fechaHoy.Hour < 10 Then
    '        fechaHoy = fechaHoy.AddDays(-1) ' Retroceder un día
    '    End If

    '    Dim fechaFormateada As String = fechaHoy.ToString("yyyy-MM-dd")

    '    Dim url As String = $"https://api.bcra.gob.ar/estadisticascambiarias/v1.0/Cotizaciones?fecha={fechaFormateada}"

    '    Using client As New HttpClient()
    '        Try
    '            Dim response As HttpResponseMessage = Await client.GetAsync(url)
    '            If response.IsSuccessStatusCode Then
    '                Dim content As String = Await response.Content.ReadAsStringAsync()

    '                ' Parsear la respuesta JSON
    '                Dim jsonData As JObject = JObject.Parse(content)

    '                ' Extraer el detalle
    '                Dim detalle As JArray = jsonData("results")("detalle")

    '                ' Buscar la cotización para USD
    '                Dim tipoCotizacionUSD As Decimal = 0
    '                For Each item As JObject In detalle
    '                    If item("codigoMoneda").ToString() = "USD" Then
    '                        tipoCotizacionUSD = item("tipoCotizacion").Value(Of Decimal)()
    '                        Exit For
    '                    End If
    '                Next

    '                ' Mostrar la cotización en un TextBox
    '                lblDolar.Text = $"Dólar divisa: {tipoCotizacionUSD.ToString("0.00")}"

    '            Else
    '                ' Manejar el error aquí
    '                MessageBox.Show("Error al obtener la cotización: " & response.StatusCode.ToString())
    '            End If

    '        Catch ex As Exception
    '            MessageBox.Show("Error al obtener la cotización: " & ex.Message)
    '        End Try
    '    End Using
    'End Function

    Private Async Function ConsultarDolar1() As Task
        Dim fechaHoy As DateTime = DateTime.Now

        ' Verificar si hoy es sábado o domingo
        If fechaHoy.DayOfWeek = DayOfWeek.Saturday Then
            fechaHoy = fechaHoy.AddDays(-1) ' Retroceder un día
        ElseIf fechaHoy.DayOfWeek = DayOfWeek.Sunday Then
            fechaHoy = fechaHoy.AddDays(-2) ' Retroceder dos días
        ElseIf fechaHoy.DayOfWeek = DayOfWeek.Monday AndAlso fechaHoy.Hour < 10 Then
            fechaHoy = fechaHoy.AddDays(-3) ' Retroceder tres días (viernes anterior)
        ElseIf fechaHoy.Hour < 10 Then
            fechaHoy = fechaHoy.AddDays(-1) ' Retroceder un día
        End If

        Dim tipoCotizacionUSD As Decimal = 0

        Do
            Dim fechaFormateada As String = fechaHoy.ToString("yyyy-MM-dd")
            Dim url As String = $"https://api.bcra.gob.ar/estadisticascambiarias/v1.0/Cotizaciones?fecha={fechaFormateada}"

            Using client As New HttpClient()
                Try
                    Dim response As HttpResponseMessage = Await client.GetAsync(url)
                    If response.IsSuccessStatusCode Then
                        Dim content As String = Await response.Content.ReadAsStringAsync()

                        ' Parsear la respuesta JSON
                        Dim jsonData As JObject = JObject.Parse(content)

                        ' Extraer el detalle
                        Dim detalle As JArray = jsonData("results")("detalle")

                        ' Buscar la cotización para USD
                        For Each item As JObject In detalle
                            If item("codigoMoneda").ToString() = "USD" Then
                                tipoCotizacionUSD = item("tipoCotizacion").Value(Of Decimal)()
                                Exit For
                            End If
                        Next

                        ' Verificar si se encontró una cotización válida (distinta de cero)
                        If tipoCotizacionUSD > 0 Then
                            lblDolar.Text = $"Dólar divisa: {tipoCotizacionUSD.ToString("0.00")}"
                            Exit Do ' Salir del bucle si se encontró un valor válido
                        End If

                    Else
                        ' Manejar el error aquí
                        MessageBox.Show("Error al obtener la cotización: " & response.StatusCode.ToString())
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error al obtener la cotización: " & ex.Message)
                End Try
            End Using

            ' Si no se encontró una cotización válida, retroceder un día
            fechaHoy = fechaHoy.AddDays(-1)

        Loop While tipoCotizacionUSD = 0 ' Repetir hasta encontrar una cotización válida

    End Function


#End Region

#Region "Pedido"
    Private Sub btnExportarPDF_Click(sender As Object, e As EventArgs) Handles btnExportarPDF.Click
        frmAgregarPedidoRepuesto.ShowDialog()
    End Sub


#End Region

End Class