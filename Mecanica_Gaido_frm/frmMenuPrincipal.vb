Imports System.Data
Imports System.Runtime.InteropServices
Imports Comun_Soporte
Imports Mecanica_Gaido_frm.User32

Public Class frmMenuPrincipal

#Region "Movimiento frm"
    ' Evento MouseDown hace que al mantener apretado el formulario se mueva y no esté estático
    Private Sub frmMenuPrincipal_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Llamar a ReleaseCapture para liberar la captura del mouse
            ReleaseCapture()
            ' Enviar el mensaje WM_NCLBUTTONDOWN para iniciar el arrastre
            SendMessage(Me.Handle, &HA1, 2, 0)
        End If
    End Sub
    Private Sub panelContenedor_MouseDown(sender As Object, e As MouseEventArgs) Handles panelContenedor.MouseDown
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

    Private Sub PanelNav_MouseDown(sender As Object, e As MouseEventArgs) Handles panelNav.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &HA1, 2, 0)
        End If
    End Sub
#End Region

#Region "Control btn"
    Private Sub btnVehiculos_Click(sender As Object, e As EventArgs) Handles btnVehiculos.Click
        AbrirFormHijo(New frmVehiculos())
        DirectCast(sender, Button).BackColor = Color.SeaGreen
    End Sub

    Private Sub btnPersonas_Click(sender As Object, e As EventArgs) Handles btnPersonas.Click
        AbrirFormHijo(New frmPersonas())
        DirectCast(sender, Button).BackColor = Color.SeaGreen
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirFormHijo(New frmProductos())
        DirectCast(sender, Button).BackColor = Color.SeaGreen
    End Sub

    Private Sub btnOrdenReparacón_Click(sender As Object, e As EventArgs) Handles btnOrdenReparacón.Click
        AbrirFormHijo(New frmOrdenesReparacion())
        DirectCast(sender, Button).BackColor = Color.SeaGreen
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormHijo(New frmVentas())
        DirectCast(sender, Button).BackColor = Color.SeaGreen
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        AbrirFormHijo(New frmCompras())
        DirectCast(sender, Button).BackColor = Color.SeaGreen
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("¿Estás seguro de cerrar la aplicación?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        If MessageBox.Show("¿Estás seguro de cerrar sesión?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region

#Region "Mantener el color btn"

    Private Sub btnCompras_Leave(sender As Object, e As EventArgs) Handles btnCompras.Leave
        DirectCast(sender, Button).BackColor = Color.FromArgb(65, 65, 65)
    End Sub
    Private Sub btnVentas_Leave(sender As Object, e As EventArgs) Handles btnVentas.Leave
        DirectCast(sender, Button).BackColor = Color.FromArgb(65, 65, 65)
    End Sub
    Private Sub btnOrdenReparacón_Leave(sender As Object, e As EventArgs) Handles btnOrdenReparacón.Leave
        DirectCast(sender, Button).BackColor = Color.FromArgb(65, 65, 65)
    End Sub

    Private Sub btnProductos_Leave(sender As Object, e As EventArgs) Handles btnProductos.Leave
        DirectCast(sender, Button).BackColor = Color.FromArgb(65, 65, 65)
    End Sub

    Private Sub btnPersonas_Leave(sender As Object, e As EventArgs) Handles btnPersonas.Leave
        DirectCast(sender, Button).BackColor = Color.FromArgb(65, 65, 65)
    End Sub

    Private Sub btnVehiculos_Leave(sender As Object, e As EventArgs) Handles btnVehiculos.Leave
        DirectCast(sender, Button).BackColor = Color.FromArgb(65, 65, 65)
    End Sub


#End Region

#Region "frm Padre y resize"
    Private Sub AbrirFormHijo(formHijo As Object)
        If Me.panelContenedor.Controls.Count > 0 Then
            Me.panelContenedor.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(formHijo, Form)
        If fh IsNot Nothing Then
            fh.TopLevel = False
            fh.Dock = DockStyle.Fill
            Me.panelContenedor.Controls.Add(fh)
            Me.panelContenedor.Tag = fh
            fh.Show()
            fh.BringToFront()
        End If
    End Sub

    Private Sub MenuPrincipal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Obtener el tamaño del panel izquierdo que queremos dejar visible
        Dim panelMenuWidth As Integer = PanelMenu.Width

        ' Calcular el nuevo tamaño y posición del panel contenedor a la derecha
        Dim panelContenedorWidth As Integer = Me.Width - panelMenuWidth
        Dim panelContenedorHeight As Integer = Me.Height
        Dim panelContenedorLocation As New Point(panelMenuWidth, 0)

        ' Establecer el nuevo tamaño y posición del panel contenedor
        panelContenedor.Size = New Size(panelContenedorWidth, panelContenedorHeight)
        panelContenedor.Location = panelContenedorLocation
    End Sub
#End Region

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblUsuario.Text = UsuarioActivo.usuario
        lblRol.Text = UsuarioActivo.nombre_rol
        lblNombre.Text = UsuarioActivo.nombrePersona & " " & UsuarioActivo.apellidoPersona
        lblCorreo.Text = UsuarioActivo.correoPersona
    End Sub

End Class
