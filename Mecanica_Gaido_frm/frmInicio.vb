Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization
Imports AD_Mecanica_Gaido

Imports System.Net.Http
Imports Newtonsoft.Json

Public Class frmInicio
    Dim o_reportes As New AD_Reportes()
    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHora.Visible = True
        lblFecha.Visible = True

        cargar_grafico_Repuestos()
    End Sub

    Private Async Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim climaData As Clima = Await ObtenerClimaAsync()
        If climaData IsNot Nothing Then
            lblUbicacion.Text = climaData.name
            lblTemperatura.Text = $"{climaData.main.temp}°C"
            lblMaxMin.Text = "Previsión"
            lblDescripcion.Text = climaData.weather(0).description
        End If
    End Sub

#Region "Clima"

    Private Async Function ObtenerClimaAsync() As Task(Of Clima)
        Dim apiKey As String = "89cff514fec4a4da7077ca6b99f9a8d2"
        Dim ciudad As String = "Las Varillas" ' Cambia esto a tu ciudad
        Dim url As String = $"http://api.openweathermap.org/data/2.5/weather?q={ciudad}&units=metric&appid={apiKey}&lang=es"

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
End Class