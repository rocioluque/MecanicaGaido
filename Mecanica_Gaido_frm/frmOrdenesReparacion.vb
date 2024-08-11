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
        cboServicios.SelectedIndex = -1
        cboVehiculo.SelectedIndex = -1
        chkActivo.Checked = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub frmOrdenesReparacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Vehiculos()
        Cargar_Combo_Personas()
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
#End Region

End Class