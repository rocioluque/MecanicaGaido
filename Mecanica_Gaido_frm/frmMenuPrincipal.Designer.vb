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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnGestionDatos = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.PanelVerdeGestion = New System.Windows.Forms.Panel()
        Me.btnReportes = New System.Windows.Forms.Button()
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
        Me.panelNav = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.btnSeccion = New System.Windows.Forms.Button()
        Me.btnRol = New System.Windows.Forms.Button()
        Me.btnCiudad = New System.Windows.Forms.Button()
        Me.btnRubro = New System.Windows.Forms.Button()
        Me.btnMarca = New System.Windows.Forms.Button()
        Me.frmFormaEntrega = New System.Windows.Forms.Button()
        Me.btnTipoVenta = New System.Windows.Forms.Button()
        Me.btnFormaPago = New System.Windows.Forms.Button()
        Me.btnTipoVehiculos = New System.Windows.Forms.Button()
        Me.PanelMenu.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.lblUsuario)
        Me.PanelMenu.Controls.Add(Me.btnGestionDatos)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.btnInicio)
        Me.PanelMenu.Controls.Add(Me.PanelVerdeGestion)
        Me.PanelMenu.Controls.Add(Me.btnReportes)
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
        Me.PanelMenu.Location = New System.Drawing.Point(0, 22)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(240, 780)
        Me.PanelMenu.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel3.Controls.Add(Me.frmFormaEntrega)
        Me.Panel3.Controls.Add(Me.btnSeccion)
        Me.Panel3.Controls.Add(Me.btnTipoVenta)
        Me.Panel3.Controls.Add(Me.btnMarca)
        Me.Panel3.Controls.Add(Me.btnFormaPago)
        Me.Panel3.Controls.Add(Me.btnRol)
        Me.Panel3.Controls.Add(Me.btnTipoVehiculos)
        Me.Panel3.Controls.Add(Me.btnCiudad)
        Me.Panel3.Controls.Add(Me.btnRubro)
        Me.Panel3.Location = New System.Drawing.Point(0, 478)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 270)
        Me.Panel3.TabIndex = 0
        Me.Panel3.Tag = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Location = New System.Drawing.Point(0, 437)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 35)
        Me.Panel2.TabIndex = 38
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(124, 18)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(11, 16)
        Me.lblUsuario.TabIndex = 28
        Me.lblUsuario.Text = ":"
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
        Me.btnGestionDatos.Location = New System.Drawing.Point(2, 437)
        Me.btnGestionDatos.Name = "btnGestionDatos"
        Me.btnGestionDatos.Size = New System.Drawing.Size(243, 35)
        Me.btnGestionDatos.TabIndex = 37
        Me.btnGestionDatos.Text = "        Gestión de Datos "
        Me.btnGestionDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionDatos.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 35)
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
        Me.btnInicio.Location = New System.Drawing.Point(2, 109)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(243, 35)
        Me.btnInicio.TabIndex = 24
        Me.btnInicio.Text = "        Inicio"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'PanelVerdeGestion
        '
        Me.PanelVerdeGestion.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdeGestion.Location = New System.Drawing.Point(0, 396)
        Me.PanelVerdeGestion.Name = "PanelVerdeGestion"
        Me.PanelVerdeGestion.Size = New System.Drawing.Size(5, 35)
        Me.PanelVerdeGestion.TabIndex = 36
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(2, 396)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(243, 35)
        Me.btnReportes.TabIndex = 31
        Me.btnReportes.Text = "        Reportes "
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(79, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Correo:"
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ForeColor = System.Drawing.Color.White
        Me.lblRol.Location = New System.Drawing.Point(101, 35)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(11, 16)
        Me.lblRol.TabIndex = 28
        Me.lblRol.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(79, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Nombre:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(130, 52)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(11, 16)
        Me.lblNombre.TabIndex = 31
        Me.lblNombre.Text = ":"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.Color.White
        Me.lblCorreo.Location = New System.Drawing.Point(123, 69)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(11, 16)
        Me.lblCorreo.TabIndex = 32
        Me.lblCorreo.Text = ":"
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
        Me.Label2.Location = New System.Drawing.Point(79, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Usuario:"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 745)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(240, 35)
        Me.btnCerrarSesion.TabIndex = 32
        Me.btnCerrarSesion.Text = "        Cerrar Sesión"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'PanelVerdeCompras
        '
        Me.PanelVerdeCompras.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdeCompras.Location = New System.Drawing.Point(0, 355)
        Me.PanelVerdeCompras.Name = "PanelVerdeCompras"
        Me.PanelVerdeCompras.Size = New System.Drawing.Size(5, 35)
        Me.PanelVerdeCompras.TabIndex = 23
        '
        'PanelVerdeVentas
        '
        Me.PanelVerdeVentas.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdeVentas.Location = New System.Drawing.Point(0, 314)
        Me.PanelVerdeVentas.Name = "PanelVerdeVentas"
        Me.PanelVerdeVentas.Size = New System.Drawing.Size(5, 35)
        Me.PanelVerdeVentas.TabIndex = 21
        '
        'PanelVerdeOrdenes
        '
        Me.PanelVerdeOrdenes.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdeOrdenes.Location = New System.Drawing.Point(0, 273)
        Me.PanelVerdeOrdenes.Name = "PanelVerdeOrdenes"
        Me.PanelVerdeOrdenes.Size = New System.Drawing.Size(5, 35)
        Me.PanelVerdeOrdenes.TabIndex = 19
        '
        'PanelVerdeVehiculos
        '
        Me.PanelVerdeVehiculos.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdeVehiculos.Location = New System.Drawing.Point(0, 232)
        Me.PanelVerdeVehiculos.Name = "PanelVerdeVehiculos"
        Me.PanelVerdeVehiculos.Size = New System.Drawing.Size(5, 35)
        Me.PanelVerdeVehiculos.TabIndex = 17
        '
        'PanelVerdeProductos
        '
        Me.PanelVerdeProductos.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdeProductos.Location = New System.Drawing.Point(0, 191)
        Me.PanelVerdeProductos.Name = "PanelVerdeProductos"
        Me.PanelVerdeProductos.Size = New System.Drawing.Size(5, 35)
        Me.PanelVerdeProductos.TabIndex = 15
        '
        'PanelVerdePersonas
        '
        Me.PanelVerdePersonas.BackColor = System.Drawing.Color.SeaGreen
        Me.PanelVerdePersonas.Location = New System.Drawing.Point(0, 150)
        Me.PanelVerdePersonas.Name = "PanelVerdePersonas"
        Me.PanelVerdePersonas.Size = New System.Drawing.Size(5, 35)
        Me.PanelVerdePersonas.TabIndex = 2
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
        Me.btnCompras.Location = New System.Drawing.Point(2, 355)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(243, 35)
        Me.btnCompras.TabIndex = 30
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
        Me.btnProductos.Location = New System.Drawing.Point(2, 191)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(243, 35)
        Me.btnProductos.TabIndex = 26
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
        Me.btnVehiculos.Location = New System.Drawing.Point(2, 232)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(243, 35)
        Me.btnVehiculos.TabIndex = 27
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
        Me.btnOrdenReparacón.Location = New System.Drawing.Point(2, 273)
        Me.btnOrdenReparacón.Name = "btnOrdenReparacón"
        Me.btnOrdenReparacón.Size = New System.Drawing.Size(243, 35)
        Me.btnOrdenReparacón.TabIndex = 28
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
        Me.btnVentas.Location = New System.Drawing.Point(2, 314)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(243, 35)
        Me.btnVentas.TabIndex = 29
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
        Me.btnPersonas.Location = New System.Drawing.Point(2, 150)
        Me.btnPersonas.Name = "btnPersonas"
        Me.btnPersonas.Size = New System.Drawing.Size(243, 35)
        Me.btnPersonas.TabIndex = 25
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
        Me.panelContenedor.Size = New System.Drawing.Size(960, 770)
        Me.panelContenedor.TabIndex = 2
        '
        'btnSeccion
        '
        Me.btnSeccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSeccion.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnSeccion.FlatAppearance.BorderSize = 0
        Me.btnSeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeccion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeccion.ForeColor = System.Drawing.Color.White
        Me.btnSeccion.Location = New System.Drawing.Point(0, 203)
        Me.btnSeccion.Name = "btnSeccion"
        Me.btnSeccion.Size = New System.Drawing.Size(240, 29)
        Me.btnSeccion.TabIndex = 14
        Me.btnSeccion.Text = "Secciones"
        Me.btnSeccion.UseVisualStyleBackColor = True
        '
        'btnRol
        '
        Me.btnRol.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRol.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnRol.FlatAppearance.BorderSize = 0
        Me.btnRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRol.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRol.ForeColor = System.Drawing.Color.White
        Me.btnRol.Location = New System.Drawing.Point(0, 87)
        Me.btnRol.Name = "btnRol"
        Me.btnRol.Size = New System.Drawing.Size(240, 29)
        Me.btnRol.TabIndex = 13
        Me.btnRol.Text = "Roles"
        Me.btnRol.UseVisualStyleBackColor = True
        '
        'btnCiudad
        '
        Me.btnCiudad.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCiudad.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCiudad.FlatAppearance.BorderSize = 0
        Me.btnCiudad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCiudad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCiudad.ForeColor = System.Drawing.Color.White
        Me.btnCiudad.Location = New System.Drawing.Point(0, 29)
        Me.btnCiudad.Name = "btnCiudad"
        Me.btnCiudad.Size = New System.Drawing.Size(240, 29)
        Me.btnCiudad.TabIndex = 12
        Me.btnCiudad.Text = "Ciudades"
        Me.btnCiudad.UseVisualStyleBackColor = True
        '
        'btnRubro
        '
        Me.btnRubro.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRubro.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnRubro.FlatAppearance.BorderSize = 0
        Me.btnRubro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRubro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRubro.ForeColor = System.Drawing.Color.White
        Me.btnRubro.Location = New System.Drawing.Point(0, 0)
        Me.btnRubro.Name = "btnRubro"
        Me.btnRubro.Size = New System.Drawing.Size(240, 29)
        Me.btnRubro.TabIndex = 11
        Me.btnRubro.Text = "Rubros"
        Me.btnRubro.UseVisualStyleBackColor = True
        '
        'btnMarca
        '
        Me.btnMarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMarca.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnMarca.FlatAppearance.BorderSize = 0
        Me.btnMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarca.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarca.ForeColor = System.Drawing.Color.White
        Me.btnMarca.Location = New System.Drawing.Point(0, 145)
        Me.btnMarca.Name = "btnMarca"
        Me.btnMarca.Size = New System.Drawing.Size(240, 29)
        Me.btnMarca.TabIndex = 10
        Me.btnMarca.Text = "Marcas"
        Me.btnMarca.UseVisualStyleBackColor = True
        '
        'frmFormaEntrega
        '
        Me.frmFormaEntrega.Dock = System.Windows.Forms.DockStyle.Top
        Me.frmFormaEntrega.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.frmFormaEntrega.FlatAppearance.BorderSize = 0
        Me.frmFormaEntrega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.frmFormaEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmFormaEntrega.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmFormaEntrega.ForeColor = System.Drawing.Color.White
        Me.frmFormaEntrega.Location = New System.Drawing.Point(0, 232)
        Me.frmFormaEntrega.Name = "frmFormaEntrega"
        Me.frmFormaEntrega.Size = New System.Drawing.Size(240, 29)
        Me.frmFormaEntrega.TabIndex = 12
        Me.frmFormaEntrega.Text = "Formas de Entrega"
        Me.frmFormaEntrega.UseVisualStyleBackColor = True
        '
        'btnTipoVenta
        '
        Me.btnTipoVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTipoVenta.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnTipoVenta.FlatAppearance.BorderSize = 0
        Me.btnTipoVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnTipoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoVenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipoVenta.ForeColor = System.Drawing.Color.White
        Me.btnTipoVenta.Location = New System.Drawing.Point(0, 174)
        Me.btnTipoVenta.Name = "btnTipoVenta"
        Me.btnTipoVenta.Size = New System.Drawing.Size(240, 29)
        Me.btnTipoVenta.TabIndex = 11
        Me.btnTipoVenta.Text = "Tipos de Ventas"
        Me.btnTipoVenta.UseVisualStyleBackColor = True
        '
        'btnFormaPago
        '
        Me.btnFormaPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFormaPago.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnFormaPago.FlatAppearance.BorderSize = 0
        Me.btnFormaPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormaPago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormaPago.ForeColor = System.Drawing.Color.White
        Me.btnFormaPago.Location = New System.Drawing.Point(0, 116)
        Me.btnFormaPago.Name = "btnFormaPago"
        Me.btnFormaPago.Size = New System.Drawing.Size(240, 29)
        Me.btnFormaPago.TabIndex = 10
        Me.btnFormaPago.Text = "Formas de Pago"
        Me.btnFormaPago.UseVisualStyleBackColor = True
        '
        'btnTipoVehiculos
        '
        Me.btnTipoVehiculos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTipoVehiculos.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnTipoVehiculos.FlatAppearance.BorderSize = 0
        Me.btnTipoVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnTipoVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoVehiculos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipoVehiculos.ForeColor = System.Drawing.Color.White
        Me.btnTipoVehiculos.Location = New System.Drawing.Point(0, 58)
        Me.btnTipoVehiculos.Name = "btnTipoVehiculos"
        Me.btnTipoVehiculos.Size = New System.Drawing.Size(240, 29)
        Me.btnTipoVehiculos.TabIndex = 9
        Me.btnTipoVehiculos.Text = "Tipos de Vehiculos"
        Me.btnTipoVehiculos.UseVisualStyleBackColor = True
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.panelNav)
        Me.Controls.Add(Me.PanelMenu)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "Mecánica Gaido - Menu Principal"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.Panel3.ResumeLayout(False)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents PanelVerdeGestion As Panel
    Friend WithEvents btnReportes As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnInicio As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGestionDatos As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSeccion As Button
    Friend WithEvents btnMarca As Button
    Friend WithEvents btnRol As Button
    Friend WithEvents btnCiudad As Button
    Friend WithEvents btnRubro As Button
    Friend WithEvents btnTipoVenta As Button
    Friend WithEvents btnFormaPago As Button
    Friend WithEvents btnTipoVehiculos As Button
    Friend WithEvents frmFormaEntrega As Button
End Class
