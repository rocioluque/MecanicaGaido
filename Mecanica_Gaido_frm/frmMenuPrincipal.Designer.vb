<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.btnOrdenReparacón = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnPersonas = New System.Windows.Forms.Button()
        Me.panelNav = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNav.SuspendLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Label3)
        Me.PanelMenu.Controls.Add(Me.Label4)
        Me.PanelMenu.Controls.Add(Me.lblCorreo)
        Me.PanelMenu.Controls.Add(Me.lblNombre)
        Me.PanelMenu.Controls.Add(Me.Label1)
        Me.PanelMenu.Controls.Add(Me.Label2)
        Me.PanelMenu.Controls.Add(Me.lblRol)
        Me.PanelMenu.Controls.Add(Me.lblUsuario)
        Me.PanelMenu.Controls.Add(Me.btnCerrarSesion)
        Me.PanelMenu.Controls.Add(Me.Panel7)
        Me.PanelMenu.Controls.Add(Me.Panel6)
        Me.PanelMenu.Controls.Add(Me.Panel5)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.PictureBox7)
        Me.PanelMenu.Controls.Add(Me.btnCompras)
        Me.PanelMenu.Controls.Add(Me.btnProductos)
        Me.PanelMenu.Controls.Add(Me.btnVehiculos)
        Me.PanelMenu.Controls.Add(Me.btnOrdenReparacón)
        Me.PanelMenu.Controls.Add(Me.btnVentas)
        Me.PanelMenu.Controls.Add(Me.btnPersonas)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 22)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(240, 630)
        Me.PanelMenu.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(79, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Correo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(79, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Nombre:"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.Color.White
        Me.lblCorreo.Location = New System.Drawing.Point(123, 70)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(11, 16)
        Me.lblCorreo.TabIndex = 32
        Me.lblCorreo.Text = ":"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(129, 53)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(11, 16)
        Me.lblNombre.TabIndex = 31
        Me.lblNombre.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Rol:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(79, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Usuario:"
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ForeColor = System.Drawing.Color.White
        Me.lblRol.Location = New System.Drawing.Point(102, 35)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(11, 16)
        Me.lblRol.TabIndex = 28
        Me.lblRol.Text = ":"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(126, 19)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(11, 16)
        Me.lblUsuario.TabIndex = 27
        Me.lblUsuario.Text = ":"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 595)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(240, 35)
        Me.btnCerrarSesion.TabIndex = 25
        Me.btnCerrarSesion.Text = "        Cerrar Sesión"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel7.Location = New System.Drawing.Point(0, 314)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 35)
        Me.Panel7.TabIndex = 23
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel6.Location = New System.Drawing.Point(0, 273)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 35)
        Me.Panel6.TabIndex = 21
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel5.Location = New System.Drawing.Point(0, 232)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 35)
        Me.Panel5.TabIndex = 19
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Location = New System.Drawing.Point(0, 191)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 35)
        Me.Panel4.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Location = New System.Drawing.Point(0, 150)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 35)
        Me.Panel3.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Location = New System.Drawing.Point(0, 109)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 35)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(0, 14)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(91, 79)
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        '
        'btnCompras
        '
        Me.btnCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnCompras.ForeColor = System.Drawing.Color.White
        Me.btnCompras.Image = CType(resources.GetObject("btnCompras.Image"), System.Drawing.Image)
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.Location = New System.Drawing.Point(3, 314)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(243, 35)
        Me.btnCompras.TabIndex = 5
        Me.btnCompras.Text = "        Compras "
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnProductos.ForeColor = System.Drawing.Color.White
        Me.btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), System.Drawing.Image)
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(2, 150)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(243, 35)
        Me.btnProductos.TabIndex = 4
        Me.btnProductos.Text = "        Productos"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnVehiculos
        '
        Me.btnVehiculos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnVehiculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVehiculos.FlatAppearance.BorderSize = 0
        Me.btnVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVehiculos.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnVehiculos.ForeColor = System.Drawing.Color.White
        Me.btnVehiculos.Image = CType(resources.GetObject("btnVehiculos.Image"), System.Drawing.Image)
        Me.btnVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehiculos.Location = New System.Drawing.Point(3, 191)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(243, 35)
        Me.btnVehiculos.TabIndex = 3
        Me.btnVehiculos.Text = "        Vehículos"
        Me.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehiculos.UseVisualStyleBackColor = False
        '
        'btnOrdenReparacón
        '
        Me.btnOrdenReparacón.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnOrdenReparacón.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrdenReparacón.FlatAppearance.BorderSize = 0
        Me.btnOrdenReparacón.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnOrdenReparacón.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenReparacón.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnOrdenReparacón.ForeColor = System.Drawing.Color.White
        Me.btnOrdenReparacón.Image = CType(resources.GetObject("btnOrdenReparacón.Image"), System.Drawing.Image)
        Me.btnOrdenReparacón.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrdenReparacón.Location = New System.Drawing.Point(3, 232)
        Me.btnOrdenReparacón.Name = "btnOrdenReparacón"
        Me.btnOrdenReparacón.Size = New System.Drawing.Size(243, 35)
        Me.btnOrdenReparacón.TabIndex = 2
        Me.btnOrdenReparacón.Text = "        Ordenes de Reparación"
        Me.btnOrdenReparacón.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrdenReparacón.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnVentas.ForeColor = System.Drawing.Color.White
        Me.btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), System.Drawing.Image)
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(3, 273)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(243, 35)
        Me.btnVentas.TabIndex = 1
        Me.btnVentas.Text = "        Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnPersonas
        '
        Me.btnPersonas.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnPersonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPersonas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPersonas.FlatAppearance.BorderSize = 0
        Me.btnPersonas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPersonas.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnPersonas.ForeColor = System.Drawing.Color.White
        Me.btnPersonas.Image = CType(resources.GetObject("btnPersonas.Image"), System.Drawing.Image)
        Me.btnPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPersonas.Location = New System.Drawing.Point(2, 109)
        Me.btnPersonas.Name = "btnPersonas"
        Me.btnPersonas.Size = New System.Drawing.Size(243, 35)
        Me.btnPersonas.TabIndex = 0
        Me.btnPersonas.Text = "        Personas"
        Me.btnPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPersonas.UseVisualStyleBackColor = False
        '
        'panelNav
        '
        Me.panelNav.BackColor = System.Drawing.Color.SeaGreen
        Me.panelNav.Controls.Add(Me.btnRestaurar)
        Me.panelNav.Controls.Add(Me.btnMinimizar)
        Me.panelNav.Controls.Add(Me.btnMaximizar)
        Me.panelNav.Controls.Add(Me.btnCerrar)
        Me.panelNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelNav.Location = New System.Drawing.Point(0, 0)
        Me.panelNav.Name = "panelNav"
        Me.panelNav.Size = New System.Drawing.Size(1200, 30)
        Me.panelNav.TabIndex = 1
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackgroundImage = CType(resources.GetObject("btnRestaurar.BackgroundImage"), System.Drawing.Image)
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRestaurar.Location = New System.Drawing.Point(1150, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(25, 30)
        Me.btnRestaurar.TabIndex = 2
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimizar.Location = New System.Drawing.Point(1125, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(25, 30)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackgroundImage = CType(resources.GetObject("btnMaximizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaximizar.Location = New System.Drawing.Point(1150, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(25, 30)
        Me.btnMaximizar.TabIndex = 4
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Location = New System.Drawing.Point(1175, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(25, 30)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.TabStop = False
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelContenedor.Location = New System.Drawing.Point(240, 30)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(960, 620)
        Me.panelContenedor.TabIndex = 2
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1200, 650)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.panelNav)
        Me.Controls.Add(Me.PanelMenu)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mecánica Gaido - Menu Principal"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNav.ResumeLayout(False)
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnPersonas As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnVehiculos As Button
    Friend WithEvents btnOrdenReparacón As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnCompras As Button
    Friend WithEvents panelNav As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents lblRol As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblNombre As Label
End Class
