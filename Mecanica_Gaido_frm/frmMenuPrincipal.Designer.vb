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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.PanelVerdeGestion = New System.Windows.Forms.Panel()
        Me.btnGestionDatos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.PanelVerdeCompras = New System.Windows.Forms.Panel()
        Me.PanelVerdeVentas = New System.Windows.Forms.Panel()
        Me.PanelVerdeOrdenes = New System.Windows.Forms.Panel()
        Me.PanelVerdeVehiculos = New System.Windows.Forms.Panel()
        Me.PanelVerdeProductos = New System.Windows.Forms.Panel()
        Me.PanelVerdePersonas = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.btnOrdenReparacón = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnPersonas = New System.Windows.Forms.Button()
        Me.lblUsuarioBarra = New System.Windows.Forms.Label()
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
        Me.PanelMenu.Controls.Add(Me.lblUsuario)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.btnInicio)
        Me.PanelMenu.Controls.Add(Me.PanelVerdeGestion)
        Me.PanelMenu.Controls.Add(Me.btnGestionDatos)
        Me.PanelMenu.Controls.Add(Me.Label3)
        Me.PanelMenu.Controls.Add(Me.lblRol)
        Me.PanelMenu.Controls.Add(Me.Label4)
        Me.PanelMenu.Controls.Add(Me.lblNombre)
        Me.PanelMenu.Controls.Add(Me.lblCorreo)
        Me.PanelMenu.Controls.Add(Me.Label1)
        Me.PanelMenu.Controls.Add(Me.Label2)
        Me.PanelMenu.Controls.Add(Me.btnCerrarSesion)
        Me.PanelMenu.Controls.Add(Me.PanelVerdeCompras)
        Me.PanelMenu.Controls.Add(Me.PanelVerdeVentas)
        Me.PanelMenu.Controls.Add(Me.PanelVerdeOrdenes)
        Me.PanelMenu.Controls.Add(Me.PanelVerdeVehiculos)
        Me.PanelMenu.Controls.Add(Me.PanelVerdeProductos)
        Me.PanelMenu.Controls.Add(Me.PanelVerdePersonas)
        Me.PanelMenu.Controls.Add(Me.PictureBox7)
        Me.PanelMenu.Controls.Add(Me.btnCompras)
        Me.PanelMenu.Controls.Add(Me.btnProductos)
        Me.PanelMenu.Controls.Add(Me.btnVehiculos)
        Me.PanelMenu.Controls.Add(Me.btnOrdenReparacón)
        Me.PanelMenu.Controls.Add(Me.btnVentas)
        Me.PanelMenu.Controls.Add(Me.btnPersonas)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 27)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(320, 775)
        Me.PanelMenu.TabIndex = 0
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(165, 22)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(13, 19)
        Me.lblUsuario.TabIndex = 28
        Me.lblUsuario.Text = ":"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 134)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(7, 43)
        Me.Panel1.TabIndex = 38
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), System.Drawing.Image)
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(3, 134)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(324, 43)
        Me.btnInicio.TabIndex = 1
        Me.btnInicio.Text = "        Inicio"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'PanelVerdeGestion
        '
        Me.PanelVerdeGestion.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdeGestion.Location = New System.Drawing.Point(0, 487)
        Me.PanelVerdeGestion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelVerdeGestion.Name = "PanelVerdeGestion"
        Me.PanelVerdeGestion.Size = New System.Drawing.Size(7, 43)
        Me.PanelVerdeGestion.TabIndex = 36
        '
        'btnGestionDatos
        '
        Me.btnGestionDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnGestionDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGestionDatos.FlatAppearance.BorderSize = 0
        Me.btnGestionDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnGestionDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestionDatos.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnGestionDatos.ForeColor = System.Drawing.Color.White
        Me.btnGestionDatos.Image = CType(resources.GetObject("btnGestionDatos.Image"), System.Drawing.Image)
        Me.btnGestionDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionDatos.Location = New System.Drawing.Point(3, 487)
        Me.btnGestionDatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGestionDatos.Name = "btnGestionDatos"
        Me.btnGestionDatos.Size = New System.Drawing.Size(324, 43)
        Me.btnGestionDatos.TabIndex = 8
        Me.btnGestionDatos.Text = "        Gestión de Datos "
        Me.btnGestionDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionDatos.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(105, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Correo:"
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ForeColor = System.Drawing.Color.White
        Me.lblRol.Location = New System.Drawing.Point(135, 43)
        Me.lblRol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(13, 19)
        Me.lblRol.TabIndex = 28
        Me.lblRol.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(105, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Nombre:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(173, 64)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(13, 19)
        Me.lblNombre.TabIndex = 31
        Me.lblNombre.Text = ":"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.Color.White
        Me.lblCorreo.Location = New System.Drawing.Point(164, 85)
        Me.lblCorreo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(13, 19)
        Me.lblCorreo.TabIndex = 32
        Me.lblCorreo.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(105, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 19)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Rol:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(105, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Usuario:"
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
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 732)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(320, 43)
        Me.btnCerrarSesion.TabIndex = 9
        Me.btnCerrarSesion.Text = "        Cerrar Sesión"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'PanelVerdeCompras
        '
        Me.PanelVerdeCompras.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdeCompras.Location = New System.Drawing.Point(0, 437)
        Me.PanelVerdeCompras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelVerdeCompras.Name = "PanelVerdeCompras"
        Me.PanelVerdeCompras.Size = New System.Drawing.Size(7, 43)
        Me.PanelVerdeCompras.TabIndex = 23
        '
        'PanelVerdeVentas
        '
        Me.PanelVerdeVentas.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdeVentas.Location = New System.Drawing.Point(0, 386)
        Me.PanelVerdeVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelVerdeVentas.Name = "PanelVerdeVentas"
        Me.PanelVerdeVentas.Size = New System.Drawing.Size(7, 43)
        Me.PanelVerdeVentas.TabIndex = 21
        '
        'PanelVerdeOrdenes
        '
        Me.PanelVerdeOrdenes.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdeOrdenes.Location = New System.Drawing.Point(0, 336)
        Me.PanelVerdeOrdenes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelVerdeOrdenes.Name = "PanelVerdeOrdenes"
        Me.PanelVerdeOrdenes.Size = New System.Drawing.Size(7, 43)
        Me.PanelVerdeOrdenes.TabIndex = 19
        '
        'PanelVerdeVehiculos
        '
        Me.PanelVerdeVehiculos.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdeVehiculos.Location = New System.Drawing.Point(0, 286)
        Me.PanelVerdeVehiculos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelVerdeVehiculos.Name = "PanelVerdeVehiculos"
        Me.PanelVerdeVehiculos.Size = New System.Drawing.Size(7, 43)
        Me.PanelVerdeVehiculos.TabIndex = 17
        '
        'PanelVerdeProductos
        '
        Me.PanelVerdeProductos.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdeProductos.Location = New System.Drawing.Point(0, 235)
        Me.PanelVerdeProductos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelVerdeProductos.Name = "PanelVerdeProductos"
        Me.PanelVerdeProductos.Size = New System.Drawing.Size(7, 43)
        Me.PanelVerdeProductos.TabIndex = 15
        '
        'PanelVerdePersonas
        '
        Me.PanelVerdePersonas.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdePersonas.Location = New System.Drawing.Point(0, 185)
        Me.PanelVerdePersonas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelVerdePersonas.Name = "PanelVerdePersonas"
        Me.PanelVerdePersonas.Size = New System.Drawing.Size(7, 43)
        Me.PanelVerdePersonas.TabIndex = 2
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(0, 17)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(121, 97)
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
        Me.btnCompras.Location = New System.Drawing.Point(3, 437)
        Me.btnCompras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(324, 43)
        Me.btnCompras.TabIndex = 7
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
        Me.btnProductos.Location = New System.Drawing.Point(3, 235)
        Me.btnProductos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(324, 43)
        Me.btnProductos.TabIndex = 3
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
        Me.btnVehiculos.Location = New System.Drawing.Point(3, 286)
        Me.btnVehiculos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(324, 43)
        Me.btnVehiculos.TabIndex = 4
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
        Me.btnOrdenReparacón.Location = New System.Drawing.Point(3, 336)
        Me.btnOrdenReparacón.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOrdenReparacón.Name = "btnOrdenReparacón"
        Me.btnOrdenReparacón.Size = New System.Drawing.Size(324, 43)
        Me.btnOrdenReparacón.TabIndex = 5
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
        Me.btnVentas.Location = New System.Drawing.Point(3, 386)
        Me.btnVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(324, 43)
        Me.btnVentas.TabIndex = 6
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
        Me.btnPersonas.Location = New System.Drawing.Point(3, 185)
        Me.btnPersonas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPersonas.Name = "btnPersonas"
        Me.btnPersonas.Size = New System.Drawing.Size(324, 43)
        Me.btnPersonas.TabIndex = 2
        Me.btnPersonas.Text = "        Personas"
        Me.btnPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPersonas.UseVisualStyleBackColor = False
        '
        'lblUsuarioBarra
        '
        Me.lblUsuarioBarra.AutoSize = True
        Me.lblUsuarioBarra.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioBarra.ForeColor = System.Drawing.Color.White
        Me.lblUsuarioBarra.Location = New System.Drawing.Point(16, 7)
        Me.lblUsuarioBarra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuarioBarra.Name = "lblUsuarioBarra"
        Me.lblUsuarioBarra.Size = New System.Drawing.Size(13, 19)
        Me.lblUsuarioBarra.TabIndex = 27
        Me.lblUsuarioBarra.Text = ":"
        '
        'panelNav
        '
        Me.panelNav.BackColor = System.Drawing.Color.SeaGreen
        Me.panelNav.Controls.Add(Me.btnRestaurar)
        Me.panelNav.Controls.Add(Me.btnMinimizar)
        Me.panelNav.Controls.Add(Me.btnMaximizar)
        Me.panelNav.Controls.Add(Me.btnCerrar)
        Me.panelNav.Controls.Add(Me.lblUsuarioBarra)
        Me.panelNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelNav.Location = New System.Drawing.Point(0, 0)
        Me.panelNav.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelNav.Name = "panelNav"
        Me.panelNav.Size = New System.Drawing.Size(1600, 37)
        Me.panelNav.TabIndex = 1
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackgroundImage = CType(resources.GetObject("btnRestaurar.BackgroundImage"), System.Drawing.Image)
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRestaurar.Location = New System.Drawing.Point(1533, 0)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(33, 37)
        Me.btnRestaurar.TabIndex = 2
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimizar.Location = New System.Drawing.Point(1500, 0)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(33, 37)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackgroundImage = CType(resources.GetObject("btnMaximizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaximizar.Location = New System.Drawing.Point(1533, 0)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(33, 37)
        Me.btnMaximizar.TabIndex = 4
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Location = New System.Drawing.Point(1567, 0)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(33, 37)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.TabStop = False
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelContenedor.Location = New System.Drawing.Point(320, 37)
        Me.panelContenedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(1280, 763)
        Me.panelContenedor.TabIndex = 2
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1600, 800)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.panelNav)
        Me.Controls.Add(Me.PanelMenu)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mecánica Gaido - Menu Principal"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNav.ResumeLayout(False)
        Me.panelNav.PerformLayout()
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
    Friend WithEvents PanelVerdeCompras As Panel
    Friend WithEvents PanelVerdeVentas As Panel
    Friend WithEvents PanelVerdeOrdenes As Panel
    Friend WithEvents PanelVerdeVehiculos As Panel
    Friend WithEvents PanelVerdeProductos As Panel
    Friend WithEvents PanelVerdePersonas As Panel
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents lblRol As Label
    Friend WithEvents lblUsuarioBarra As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents PanelVerdeGestion As Panel
    Friend WithEvents btnGestionDatos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnInicio As Button
    Friend WithEvents lblUsuario As Label
End Class
