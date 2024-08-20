Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmOrdenesReparacion
    Dim o_Orden As New AD_OrdenReparacion

#Region "Procedimientos"
    Public Sub limpiar()
        txtID.Clear()
        txtSeñasParticulares.Clear()
        txtMotivoReparacion.Clear()
        cboPersonas.SelectedIndex = -1
        'cboServicios.SelectedIndex = -1
        cboVehiculo.SelectedIndex = -1
        chkActivo.Checked = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click, BtnCancelarS3.Click
        limpiar()
    End Sub

    Private Sub frmOrdenesReparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Vehiculos()
        Cargar_Combo_Personas()
        Cargar_Combo_Prestador()
        Cargar_Combo_Repuestos()
        Cargar_Grilla_Terceros()
        Cargar_Grilla_RepuestosPorOrden()
        Cargar_Grilla_Ordenes()
        limpiar()
    End Sub
#End Region

#Region "Cargar cbo"
    Private Sub Cargar_Combo_Vehiculos()
        Try
            Dim tabla As DataTable = o_Orden.Cargar_Combo_Vehiculos()

            If tabla.Rows.Count > 0 Then
                cboVehiculo.DataSource = tabla
                cboVehiculo.DisplayMember = "Nombre"
                cboVehiculo.ValueMember = "ID_Vehiculo"
                cboVehiculo.SelectedValue = -1
            Else
                MsgBox("No se encontraron Vehiculos.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Vehiculos: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_Personas()
        Try
            Dim tabla As DataTable = o_Orden.Cargar_Combo_Personas()

            If tabla.Rows.Count > 0 Then
                cboPersonas.DataSource = tabla
                cboPersonas.DisplayMember = "Persona"
                cboPersonas.ValueMember = "ID_Persona"
                cboPersonas.SelectedValue = -1
            Else
                MsgBox("No se encontraron personas.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar las personas: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_Prestador()
        Try
            Dim tabla As DataTable = o_Orden.Cargar_Combo_Prestador()

            If tabla.Rows.Count > 0 Then
                CboPersonaServ3.DataSource = tabla
                CboPersonaServ3.DisplayMember = "Persona"
                CboPersonaServ3.ValueMember = "ID_Persona"
                CboPersonaServ3.SelectedValue = -1
            Else
                MsgBox("No se encontraron Servicios.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Servicios: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_Repuestos()
        Try
            Dim tabla As DataTable = o_Orden.Cargar_Combo_Repuestos()

            If tabla.Rows.Count > 0 Then
                cboProductoOR.DataSource = tabla
                cboProductoOR.DisplayMember = "Descripcion"
                cboProductoOR.ValueMember = "ID_Repuestos"
                cboProductoOR.SelectedValue = -1
            Else
                MsgBox("No se encontraron Repuestos.", vbInformation, "Información")
            End If

        Catch ex As Exception
            MsgBox("Error al cargar los Repuestos: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Public Sub Cargar_Grilla_Terceros()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_Terceros")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdServiciosTerceros.AutoGenerateColumns = True
                grdServiciosTerceros.DataSource = oDs.Tables(0)

                ' Verificar si las columnas existen antes de ocultarlas
                Dim columnasParaOcultar As String() = {}
                For Each colName As String In columnasParaOcultar
                    If grdServiciosTerceros.Columns.Contains(colName) Then
                        grdServiciosTerceros.Columns(colName).Visible = False
                    End If
                Next
                grdServiciosTerceros.Refresh()
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

    Public Sub Cargar_Grilla_RepuestosPorOrden()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_RepuestosPorOrden")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdRepuestos.AutoGenerateColumns = True
                grdRepuestos.DataSource = oDs.Tables(0)

                ' Verificar si las columnas existen antes de ocultarlas
                Dim columnasParaOcultar As String() = {}
                For Each colName As String In columnasParaOcultar
                    If grdRepuestos.Columns.Contains(colName) Then
                        grdRepuestos.Columns(colName).Visible = False
                    End If
                Next
                grdRepuestos.Refresh()
            Else
                MsgBox("No se encontraron Repuestos Por Orden para mostrar.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al cargar la grilla: " & ex.Message, vbCritical, "Error")
        Finally
        End Try
    End Sub

    Public Sub Cargar_Grilla_Ordenes()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_Ordenes")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdOrdenReparacion.AutoGenerateColumns = True
                grdOrdenReparacion.DataSource = oDs.Tables(0)

                ' Verificar si las columnas existen antes de ocultarlas
                Dim columnasParaOcultar As String() = {}
                For Each colName As String In columnasParaOcultar
                    If grdOrdenReparacion.Columns.Contains(colName) Then
                        grdOrdenReparacion.Columns(colName).Visible = False
                    End If
                Next
                grdOrdenReparacion.Refresh()
            Else
                MsgBox("No se encontraron Ordenes para mostrar.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al cargar la grilla: " & ex.Message, vbCritical, "Error")
        Finally
        End Try
    End Sub
#End Region

#Region "Keypress"
    Private Sub txtSeñasParticulares_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
#End Region

#Region "Css trucho"
    Private Sub PanelDetallesOrden_Paint(sender As Object, e As PaintEventArgs) Handles PanelDetallesOrden.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelDetallesOrden.Width - 1, PanelDetallesOrden.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelInfoVehiculo_Paint(sender As Object, e As PaintEventArgs) Handles PanelInfoVehiculo.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelInfoVehiculo.Width - 1, PanelInfoVehiculo.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelCostos_Paint(sender As Object, e As PaintEventArgs) Handles PanelCostos.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelCostos.Width - 1, PanelCostos.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelDetalleDeRepuestos_Paint(sender As Object, e As PaintEventArgs) Handles PanelDetalleDeRepuestos.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelDetalleDeRepuestos.Width - 1, PanelDetalleDeRepuestos.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelServiciosTerceros_Paint(sender As Object, e As PaintEventArgs) Handles PanelServiciosTerceros.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelServiciosTerceros.Width - 1, PanelServiciosTerceros.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelReparaciones_Paint(sender As Object, e As PaintEventArgs) Handles PanelReparaciones.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelReparaciones.Width - 1, PanelReparaciones.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

#End Region

    Private Sub lblResultado_Click(sender As Object, e As EventArgs) Handles lblResultadoPrestador.Click

    End Sub

    Private Sub CboPersonaServ3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPersonaServ3.SelectedIndexChanged
        ' Verifica si hay un elemento seleccionado
        If CboPersonaServ3.SelectedItem IsNot Nothing Then

            ' Cast del SelectedItem a DataRowView
            Dim selectedRow As DataRowView = CType(CboPersonaServ3.SelectedItem, DataRowView)

            ' Accede a la columna específica que deseas mostrar en la Label
            lblResultadoPrestador.Text = selectedRow("Persona").ToString()
            'txtID_Serv3.Text = selectedRow("ID_Persona").ToString()
        Else
            ' Opcionalmente, puedes manejar el caso donde no hay selección
            lblResultadoPrestador.Text = "-"
            '  txtID_Serv3.Text = "-"
        End If
    End Sub
End Class