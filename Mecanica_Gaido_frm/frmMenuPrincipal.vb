﻿Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports AD_Mecanica_Gaido
Imports Comun_Soporte
Imports Mecanica_Gaido_frm.User32

Public Class frmMenuPrincipal

#Region "Procedimientos"
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblUsuario.Text = UsuarioActivo.usuario
        lblRol.Text = UsuarioActivo.nombre_rol
        PintarBotonInicio()
        MostrarInicio()
        Me.DoubleBuffered = True
        AplicarTema(Me)
    End Sub

    Public Sub MostrarInicio()
        AbrirFormHijo(New frmInicio(), Nothing)
    End Sub

#End Region

#Region "Inicio"
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        AbrirFormHijo(New frmInicio(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub
#End Region

#Region "Personas"
    Private Sub btnPersonas_Click(sender As Object, e As EventArgs) Handles btnPersonas.Click
        AbrirFormHijo(New frmPersonas(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub
#End Region

#Region "Vehiculos"
    Private Sub btnVehiculos_Click(sender As Object, e As EventArgs) Handles btnVehiculos.Click
        AbrirFormHijo(New frmVehiculos(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub
#End Region

#Region "Orden Reparacion"
    Private Sub btnOrdenReparacion_Click(sender As Object, e As EventArgs) Handles btnOrdenReparacion.Click
        ' Si no se ha creado una instancia con parámetros desde el gráfico, crea una por defecto
        AbrirFormHijo(New frmOrdenesReparacion(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

#End Region

#Region "Productos"
    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        AbrirFormHijo(New frmProductos(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub
#End Region

#Region "Compras"
    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        AbrirFormHijo(New frmCompras(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub
#End Region

#Region "Ventas"
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormHijo(New frmVentas(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub
#End Region

#Region "Tablero de Control"
    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnTableroControl.Click
        MostrarPaneles(PanelCboTableroControl)
    End Sub
#End Region

#Region "Cbo Tablero de Control"
    Private Sub btnRepPersona_Click(sender As Object, e As EventArgs) Handles btnRepPersona.Click
        AbrirFormCbo(New frmReportesPersonas(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnRepVehiculos_Click(sender As Object, e As EventArgs) Handles btnRepVehiculos.Click
        AbrirFormCbo(New frmReportesVehiculos(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnRepReparaciones_Click(sender As Object, e As EventArgs) Handles btnRepReparaciones.Click
        AbrirFormCbo(New frmReportesReparaciones(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnRepProductos_Click(sender As Object, e As EventArgs) Handles btnRepProductos.Click
        AbrirFormCbo(New frmReportesProductos(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnRepCompras_Click(sender As Object, e As EventArgs) Handles btnRepCompras.Click
        AbrirFormCbo(New frmReportesCompras(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnRepVentas_Click(sender As Object, e As EventArgs) Handles btnRepVentas.Click
        AbrirFormCbo(New frmReportesVentas(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnMiscelaneas_Click(sender As Object, e As EventArgs) Handles btnMiscelaneas.Click
        AbrirFormCbo(New frmReportesMiscelaneas(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub
#End Region

#Region "Gestion de Datos"
    Private Sub btnGestionDatos_Click(sender As Object, e As EventArgs) Handles btnGestionDatos.Click
        MostrarPaneles(PanelCboGestion)
    End Sub

    Private Sub OcultarPaneles()
        If PanelCboGestion.Visible = True Or PanelCboTableroControl.Visible = True Then
            PanelCboGestion.Visible = False
            PanelCboTableroControl.Visible = False
        End If
    End Sub

    Private Sub MostrarPaneles(subMenu As Panel)
        If subMenu.Visible = False Then
            OcultarPaneles()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub
#End Region

#Region "Cbo Gestion de Datos"
    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        AbrirFormCbo(New frmModificarCiudades(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        AbrirFormCbo(New frmModificarMarca(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRol.Click
        AbrirFormCbo(New frmModificarRoles(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnRubro_Click(sender As Object, e As EventArgs) Handles btnRubro.Click
        AbrirFormCbo(New frmModificarRubros(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnSeccion_Click(sender As Object, e As EventArgs) Handles btnSeccion.Click
        AbrirFormCbo(New frmModificarSecciones(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnFormaEntrega_Click(sender As Object, e As EventArgs) Handles btnFormaEntrega.Click
        AbrirFormCbo(New frmModificarFormaEntrega(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnFormaPago_Click(sender As Object, e As EventArgs) Handles btnFormaPago.Click
        AbrirFormCbo(New frmModificarFormaPago(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnTipoVehiculos_Click(sender As Object, e As EventArgs) Handles btnTipoVehiculos.Click
        AbrirFormCbo(New frmModificarTipoVehiculos(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub

    Private Sub btnTipoVenta_Click(sender As Object, e As EventArgs) Handles btnTipoVenta.Click
        AbrirFormCbo(New frmModificarTipoVenta(), DirectCast(sender, Button))
        OcultarPaneles()
    End Sub
#End Region

#Region "Movimiento formulario"
    ' Evento MouseDown hace que al mantener apretado el formulario se mueva y no esté estático
    Private Sub frmMenuPrincipal_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Llamar a ReleaseCapture para liberar la captura del mouse
            ReleaseCapture()
            ' Enviar el mensaje WM_NCLBUTTONDOWN para iniciar el arrastre
            SendMessage(Me.Handle, &HA1, 2, 0)
        End If
    End Sub

    Private Sub panelContenedor_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelContenedor.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &HA1, 2, 0)
        End If
    End Sub

    Private Sub PanelMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelMenu.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &HA1, 2, 0)
        End If
    End Sub

    Private Sub PanelNav_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &HA1, 2, 0)
        End If
    End Sub
#End Region

#Region "Botón cerrar"
    Private Sub frmMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Mostrar un mensaje de confirmación
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario elige 'No', cancelar el cierre
        If resultado = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
#End Region

#Region "Formulario Padre y colores"
    Private btnAnterior As Button = Nothing
    Private isModoOscuro As Boolean = TemaGlobal.ModoActualOscuro

    Public Sub AbrirFormHijo(formHijo As Object, sender As Button)
        ' Restablecer el color del botón anterior
        If btnAnterior IsNot Nothing AndAlso sender IsNot btnAnterior Then
            btnAnterior.BackColor = If(isModoOscuro, Color.FromArgb(65, 65, 65), Color.FromArgb(147, 147, 147))
        End If

        btnAnterior = sender
        If sender IsNot Nothing Then
            sender.BackColor = Color.SeaGreen
        End If

        'Si el contenedor panelContenedor ya tiene controles hijos, elimina el primer control
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(formHijo, Form)

        If fh IsNot Nothing Then
            fh.TopLevel = False
            fh.Dock = DockStyle.Fill
            Me.PanelContenedor.Controls.Add(fh)
            Me.PanelContenedor.Tag = fh
            fh.Show()
            fh.BringToFront()
        End If

        ' Si no se agregó ningún formulario hijo, pinta el botón "Inicio"
        If Me.PanelContenedor.Controls.Count = 0 Then
            PintarBotonInicio()
        End If
    End Sub

    Private Sub AbrirFormCbo(formHijo As Object, sender As Button)
        ' Restablecer el color del botón anterior
        If btnAnterior IsNot Nothing Then
            btnAnterior.BackColor = If(isModoOscuro, Color.FromArgb(91, 91, 91), Color.FromArgb(174, 174, 174))
        End If

        ' Actualizar el color del botón actual
        btnAnterior = sender
        sender.BackColor = Color.SeaGreen

        'Si el contenedor panelContenedor ya tiene controles hijos, elimina el primer control
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(formHijo, Form)

        If fh IsNot Nothing Then
            fh.TopLevel = False
            fh.Dock = DockStyle.Fill
            Me.PanelContenedor.Controls.Add(fh)
            Me.PanelContenedor.Tag = fh
            fh.Show()
            fh.BringToFront()
        End If

        ' Si no se agregó ningún formulario hijo, pinta el botón "Inicio"
        If Me.PanelContenedor.Controls.Count = 0 Then
            PintarBotonInicio()
        End If
    End Sub

    Private Sub PintarBotonInicio()
        ' Restablecer el color del botón anterior
        If btnAnterior IsNot Nothing Then
            btnAnterior.BackColor = If(isModoOscuro, Color.FromArgb(65, 65, 65), Color.FromArgb(147, 147, 147))
        End If

        ' Actualizar el botón anterior como btnInicio
        btnAnterior = btnInicio
    End Sub
#End Region

#Region "Resize"
    Private Sub MenuPrincipal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Obtener el tamaño del panel izquierdo que queremos dejar visible
        Dim panelMenuWidth As Integer = PanelMenu.Width

        ' Calcular el nuevo tamaño y posición del panel contenedor a la derecha
        Dim panelContenedorWidth As Integer = Me.Width - panelMenuWidth
        Dim panelContenedorHeight As Integer = Me.Height
        Dim panelContenedorLocation As New Point(panelMenuWidth, 0)

        ' Establecer el nuevo tamaño y posición del panel contenedor
        PanelContenedor.Size = New Size(panelContenedorWidth, panelContenedorHeight)
        PanelContenedor.Location = panelContenedorLocation
    End Sub
#End Region

#Region "Modo Color"
    Private WithEvents animationTimer As New Timer()
    Private circleTargetX As Integer
    Private isAnimating As Boolean = False

    Private Sub btnCambiarTema_Click(sender As Object, e As EventArgs) Handles btnCambiarTema.Click
        TemaGlobal.CambiarTema()

        TemaGlobal.AplicarTemaEnTodosLosFormularios()

        circleTargetX = If(TemaGlobal.ModoActualOscuro, btnCambiarTema.Width - btnCambiarTema.Height + 3, 3)

        isAnimating = True
        animationTimer.Start()
    End Sub

    Private Sub btnCambiarTema_Paint(sender As Object, e As PaintEventArgs) Handles btnCambiarTema.Paint
        Dim graphics As Graphics = e.Graphics
        graphics.Clear(btnCambiarTema.Parent.BackColor)

        Dim rectangle As New System.Drawing.Rectangle(0, 0, btnCambiarTema.Width, btnCambiarTema.Height)

        graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim switchBackColor As Color = If(TemaGlobal.ModoActualOscuro, Color.Gray, Color.LightGray)

        Dim borderRadius As Integer = 20
        Using path As New Drawing2D.GraphicsPath()
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90)
            path.AddArc(btnCambiarTema.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90)
            path.AddArc(btnCambiarTema.Width - borderRadius, btnCambiarTema.Height - borderRadius, borderRadius, borderRadius, 0, 90)
            path.AddArc(0, btnCambiarTema.Height - borderRadius, borderRadius, borderRadius, 90, 90)
            path.CloseFigure()

            graphics.FillPath(New SolidBrush(switchBackColor), path)
        End Using

        Dim circleSize As Integer = btnCambiarTema.Height - 6
        Dim circleX As Integer = If(isAnimating, circleTargetX, If(TemaGlobal.ModoActualOscuro, btnCambiarTema.Width - circleSize - 3, 3))

        graphics.FillEllipse(New SolidBrush(If(TemaGlobal.ModoActualOscuro, Color.White, Color.Black)), New System.Drawing.Rectangle(circleX, 3, circleSize, circleSize))
    End Sub

    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        Dim currentCircleX As Integer = If(TemaGlobal.ModoActualOscuro, btnCambiarTema.Width - btnCambiarTema.Height + 3, 3)

        If currentCircleX <> circleTargetX Then
            If Math.Abs(currentCircleX - circleTargetX) < 5 Then
                animationTimer.Stop()
                isAnimating = False
            Else
                If currentCircleX < circleTargetX Then
                    currentCircleX += 5
                ElseIf currentCircleX > circleTargetX Then
                    currentCircleX -= 5
                End If
            End If

            btnCambiarTema.Invalidate()
        End If
    End Sub
#End Region

End Class
