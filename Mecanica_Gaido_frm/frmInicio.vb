Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization
Imports AD_Mecanica_Gaido

Public Class frmInicio
    Dim o_MenuPrincipal As New AD_MenuPrincipal()
    Private accesoDatos As New AccesoDatos()

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHora.Visible = True
        lblFecha.Visible = True

        cargar_grafico_Repuestos()
    End Sub

#Region "Fecha y Hora"
    Private Sub horaFecha_Tick(sender As Object, e As EventArgs) Handles horaFecha.Tick
        lblHora.Text = DateTime.Now.ToLongTimeString
        lblFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy")
    End Sub
#End Region

#Region "Grafico"
    Public Sub cargar_grafico_Repuestos()
        ' Limpiar el gráfico existente
        chtRepuestos.Series.Clear()
        chtRepuestos.ChartAreas.Clear()

        ' Crear una nueva área de gráfico
        Dim chartArea As New ChartArea()
        chtRepuestos.ChartAreas.Add(chartArea)

        ' Establecer el fondo del área del gráfico como transparente
        chtRepuestos.ChartAreas(0).BackColor = Color.Transparent

        ' Crear y configurar la serie para el gráfico tipo Pie
        Dim series As New Series()
        series.ChartType = SeriesChartType.Pie
        chtRepuestos.Series.Add(series)

        ' Variables para almacenar los resultados de la base de datos
        Dim muchos As Integer = 0
        Dim cero As Integer = 0
        Dim pocos As Integer = 0

        ' Conectar a la base de datos y ejecutar el procedimiento almacenado
        Using conn As New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")
            conn.Open()

            ' Crear el comando para ejecutar el procedimiento almacenado
            Using cmd As New SqlCommand("Contar_Repuestos_BD", conn)
                cmd.CommandType = CommandType.StoredProcedure

                ' Ejecutar el comando y leer los resultados
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        muchos = Convert.ToInt32(reader("TotalMuchos"))
                    End If

                    ' Mover al siguiente resultado y leer los inactivos
                    If reader.NextResult() AndAlso reader.Read() Then
                        cero = Convert.ToInt32(reader("TotalCero"))
                    End If

                    ' Mover al siguiente resultado y leer los Repuestos que quedan pocos.
                    If reader.NextResult() AndAlso reader.Read() Then
                        pocos = Convert.ToInt32(reader("TotalPocos"))
                    End If
                End Using
            End Using
        End Using

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