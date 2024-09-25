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
        Dim lon As String = coordenadas.Item2.ToString()

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


    Private Sub CargarGraficoEstados()
        Dim connectionString As String = "Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31;UID=PIN_GRUPO31;PWD=PIN_GRUPO31123"

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            ' Llama al procedimiento almacenado
            Dim cmd As New SqlCommand("Consultar_Ordenes_Progreso", conn)
            cmd.CommandType = CommandType.StoredProcedure

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Limpia las series anteriores del gráfico
            ChtOrdenReparacion.Series.Clear()

            ' Crear una nueva serie para el gráfico
            Dim series As New Series("Cantidad por Estado")
            series.IsVisibleInLegend = False
            series.ChartType = SeriesChartType.Column ' Cambia a Pie, Bar, etc. según lo que prefieras

            ' Configuración de etiquetas de la serie
            series.IsValueShownAsLabel = True ' Muestra los valores sobre cada barra
            series.LabelForeColor = Color.White ' Color de las etiquetas
            series.Font = New Font("Century Gothic", 9.75F) ' Tipografía de las etiquetas

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
            While reader.Read()
                Dim estado As String = reader("Estado").ToString()
                Dim cantidad As Integer = Convert.ToInt32(reader("Cantidad"))

                ' Cambia el nombre de la serie específica
                If estado = "Esperando Servicios de Terceros" Then
                    estado = "Esperando S3"
                End If

                Dim pointIndex As Integer = series.Points.AddXY(estado, cantidad)

                ' Establecer el color de la serie para esta categoría
                series.Points(pointIndex).Color = colors(colorIndex Mod colors.Length)
                colorIndex += 1
            End While

            ' Agregar la serie al gráfico
            ChtOrdenReparacion.Series.Add(series)

            ' Personalización del gráfico
            ChtOrdenReparacion.ChartAreas(0).AxisX.Title = "" ' Sin título en el eje X
            ChtOrdenReparacion.ChartAreas(0).AxisY.Title = "Cantidad de Órdenes"

            ' Configurar eje Y para mostrar solo valores enteros
            ChtOrdenReparacion.ChartAreas(0).AxisY.IsStartedFromZero = True
            ChtOrdenReparacion.ChartAreas(0).AxisY.LabelStyle.Interval = 1 ' Muestra solo enteros
            ChtOrdenReparacion.ChartAreas(0).AxisY.MajorGrid.Interval = 1 ' Líneas de cuadrícula

            ' Desactivar las líneas verticales
            ChtOrdenReparacion.ChartAreas(0).AxisX.MajorGrid.Enabled = False

            ' Activar solo las líneas horizontales
            ChtOrdenReparacion.ChartAreas(0).AxisY.MajorGrid.Enabled = True

            ' Configurar colores y tipografía para fondo oscuro
            ChtOrdenReparacion.BackColor = Color.Transparent ' Fondo del gráfico
            ChtOrdenReparacion.ChartAreas(0).BackColor = Color.Transparent ' Fondo del área de gráfico
            ChtOrdenReparacion.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.Transparent ' Sin etiquetas del eje X
            ChtOrdenReparacion.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.White ' Color de las etiquetas del eje Y
            ChtOrdenReparacion.ChartAreas(0).AxisX.LineColor = Color.White ' Color de las líneas del eje X
            ChtOrdenReparacion.ChartAreas(0).AxisY.LineColor = Color.White ' Color de las líneas del eje Y
            ChtOrdenReparacion.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.Gray ' Color de las líneas de la cuadrícula
            ChtOrdenReparacion.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.Gray ' Color de las líneas de la cuadrícula
            ChtOrdenReparacion.ChartAreas(0).AxisX.TitleForeColor = Color.White ' Color del título del eje X
            ChtOrdenReparacion.ChartAreas(0).AxisY.TitleForeColor = Color.White ' Color del título del eje Y
            ChtOrdenReparacion.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Century Gothic", 9.75F) ' Tipografía del eje X
            ChtOrdenReparacion.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Century Gothic", 9.75F) ' Tipografía del eje Y

            ' Configurar leyenda
            ChtOrdenReparacion.Legends.Clear()
            Dim legend As New Legend("Leyenda")
            legend.Docking = Docking.Top ' Ubicación de la leyenda
            legend.BackColor = Color.Transparent
            legend.ForeColor = Color.White
            legend.Title = "Órdenes de Reparación" ' Título de la leyenda
            legend.TitleFont = New Font("Century Gothic", 12, FontStyle.Regular) ' Fuente y tamaño del título
            legend.TitleForeColor = Color.White
            legend.Alignment = StringAlignment.Center
            ChtOrdenReparacion.Legends.Add(legend)


            ' Asignar valores a la leyenda
            For i As Integer = 0 To series.Points.Count - 1
                ' Verificamos que el nombre no sea "Cantidad por Estado"
                If series.Points(i).AxisLabel <> "Cantidad por Estado" Then
                    Dim legendItem As New LegendItem()
                    legendItem.Name = series.Points(i).AxisLabel ' Nombre de la categoría
                    legendItem.Color = series.Points(i).Color ' Color de la categoría

                    legend.CustomItems.Add(legendItem) ' Añade el ítem a la leyenda
                End If
            Next

            reader.Close()
        End Using

    End Sub





    Private Sub ChtOrdenReparacion_MouseClick(sender As Object, e As MouseEventArgs) Handles ChtOrdenReparacion.MouseClick
        Dim result As HitTestResult = ChtOrdenReparacion.HitTest(e.X, e.Y)

        If result.ChartElementType = ChartElementType.DataPoint Then
            Dim punto As DataPoint = result.Series.Points(result.PointIndex)
            Dim estado As String = punto.AxisLabel

            ' Convertir "Esperando S3" a "Esperando Servicios de Terceros"
            If estado = "Esperando S3" Then
                estado = "Esperando Servicios de Terceros"
            End If

            ' Abre el formulario de órdenes de reparación desde el menú principal
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
                    Dim tipoCotizacionUSD As Decimal = 0
                    For Each item As JObject In detalle
                        If item("codigoMoneda").ToString() = "USD" Then
                            tipoCotizacionUSD = item("tipoCotizacion").Value(Of Decimal)()
                            Exit For
                        End If
                    Next

                    ' Mostrar la cotización en un TextBox
                    lblDolar.Text = $"Dólar divisa: {tipoCotizacionUSD.ToString("0.00")}"

                Else
                    ' Manejar el error aquí
                    MessageBox.Show("Error al obtener la cotización: " & response.StatusCode.ToString())
                End If

            Catch ex As Exception
                MessageBox.Show("Error al obtener la cotización: " & ex.Message)
            End Try
        End Using
    End Function
#End Region

#Region "Pedido"
    Private Sub btnExportarPDF_Click(sender As Object, e As EventArgs) Handles btnExportarPDF.Click
        frmAgregarPedidoRepuesto.ShowDialog()
    End Sub
#End Region

End Class