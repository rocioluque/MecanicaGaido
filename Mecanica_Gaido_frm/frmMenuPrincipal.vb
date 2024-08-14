Imports System.Data
Imports System.Runtime.InteropServices
Imports Comun_Soporte
Imports Mecanica_Gaido_frm.User32

Public Class frmMenuPrincipal

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblUsuario.Text = UsuarioActivo.usuario
        lblRol.Text = UsuarioActivo.nombre_rol
        lblNombre.Text = UsuarioActivo.nombrePersona & " " & UsuarioActivo.apellidoPersona
        lblCorreo.Text = UsuarioActivo.correoPersona
        PintarBotonInicio()
    End Sub

#Region "Productos"
    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirFormHijo(New frmProductos(), DirectCast(sender, Button))
    End Sub
#End Region

#Region "Vehiculos"
    Private Sub btnVehiculos_Click(sender As Object, e As EventArgs) Handles btnVehiculos.Click
        AbrirFormHijo(New frmVehiculos(), DirectCast(sender, Button))
    End Sub
#End Region

#Region "Personas"
    Private Sub btnPersonas_Click(sender As Object, e As EventArgs) Handles btnPersonas.Click
        AbrirFormHijo(New frmPersonas(), DirectCast(sender, Button))
    End Sub
#End Region

#Region "Orden Reparcion"
    Private Sub btnOrdenReparacón_Click(sender As Object, e As EventArgs) Handles btnOrdenReparacón.Click
        AbrirFormHijo(New frmOrdenesReparacion(), DirectCast(sender, Button))
    End Sub
#End Region

#Region "Ventas"
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormHijo(New frmVentas(), DirectCast(sender, Button))
    End Sub
#End Region

#Region "Compras"
    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        AbrirFormHijo(New frmCompras(), DirectCast(sender, Button))
    End Sub
#End Region

#Region "Reportes"
    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        AbrirFormHijo(New frmReportes(), DirectCast(sender, Button))
    End Sub
#End Region

#Region "Gestion de Datos"
    Private Sub btnGestionDatos_Click(sender As Object, e As EventArgs) Handles btnGestionDatos.Click
        MostrarPaneles(PanelCboGestion)
    End Sub

    Private Sub OcultarPaneles()
        If PanelCboGestion.Visible = True Then
            PanelCboGestion.Visible = False
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

#Region "Control botones"

    Private Sub btnInicio_Click(sender As Object, e As EventArgs)
        'Restablecer el color del botón anterior
        If btnAnterior IsNot Nothing Then
            btnAnterior.BackColor = Color.FromArgb(65, 65, 65)
        End If

        ' Pintar el botón "Inicio"
        PintarBotonInicio()

        ' Cerrar todos los formularios hijos
        If Me.panelContenedor.Controls.Count > 0 Then
            Me.panelContenedor.Controls.RemoveAt(0)
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("¿Estás seguro de cerrar la aplicación?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        If MessageBox.Show("¿Estás seguro de cerrar sesión?", "Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
#End Region

#Region "Formulario Padre y resize"
    Private btnAnterior As Button = Nothing

    Private Sub AbrirFormHijo(formHijo As Object, sender As Button)
        ' Restablecer el color del botón anterior
        If btnAnterior IsNot Nothing Then
            btnAnterior.BackColor = Color.FromArgb(65, 65, 65)
        End If

        ' Actualizar el color del botón actual
        btnAnterior = sender
        sender.BackColor = Color.SeaGreen

        'Si el contenedor panelContenedor ya tiene controles hijos, elimina el primer control
        If Me.panelContenedor.Controls.Count > 0 Then
            Me.panelContenedor.Controls.RemoveAt(0)
        End If

        'Convierte el objeto formHijo a un tipo Form
        Dim fh As Form = TryCast(formHijo, Form)

        If fh IsNot Nothing Then
            'Esto indica que el formulario no es un formulario de nivel superior
            fh.TopLevel = False
            ' El formulario se ajustará al tamaño completo del contenedor
            fh.Dock = DockStyle.Fill
            'Agrega el formulario al contenedor
            Me.panelContenedor.Controls.Add(fh)
            'Almacena una referencia al formulario hijo en la propiedad Tag del contenedor.
            Me.panelContenedor.Tag = fh
            fh.Show()
            'Trae el formulario al frente de cualquier otro control
            fh.BringToFront()
        End If

        ' Si no se agregó ningún formulario hijo, pinta el botón "Inicio"
        If Me.panelContenedor.Controls.Count = 0 Then
            PintarBotonInicio()
        End If
    End Sub

    Private Sub AbrirFormCbo(formHijo As Object, sender As Button)
        ' Restablecer el color del botón anterior
        If btnAnterior IsNot Nothing Then
            btnAnterior.BackColor = Color.FromArgb(91, 91, 91)
        End If

        ' Actualizar el color del botón actual
        btnAnterior = sender
        sender.BackColor = Color.SeaGreen

        'Si el contenedor panelContenedor ya tiene controles hijos, elimina el primer control
        If Me.panelContenedor.Controls.Count > 0 Then
            Me.panelContenedor.Controls.RemoveAt(0)
        End If

        'Convierte el objeto formHijo a un tipo Form
        Dim fh As Form = TryCast(formHijo, Form)

        If fh IsNot Nothing Then
            'Esto indica que el formulario no es un formulario de nivel superior
            fh.TopLevel = False
            ' El formulario se ajustará al tamaño completo del contenedor
            fh.Dock = DockStyle.Fill
            'Agrega el formulario al contenedor
            Me.panelContenedor.Controls.Add(fh)
            'Almacena una referencia al formulario hijo en la propiedad Tag del contenedor.
            Me.panelContenedor.Tag = fh
            fh.Show()
            'Trae el formulario al frente de cualquier otro control
            fh.BringToFront()
        End If

        ' Si no se agregó ningún formulario hijo, pinta el botón "Inicio"
        If Me.panelContenedor.Controls.Count = 0 Then
            PintarBotonInicio()
        End If
    End Sub

    Private Sub PintarBotonInicio()
        ' Restablecer el color del botón anterior
        If btnAnterior IsNot Nothing Then
            btnAnterior.BackColor = Color.FromArgb(65, 65, 65)
        End If

        ' Pintar el botón "Inicio" con un color especial cuando no hay formularios hijos abiertos
        btnInicio.BackColor = Color.SeaGreen

        ' Actualizar el botón anterior como btnInicio
        btnAnterior = btnInicio
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

End Class
