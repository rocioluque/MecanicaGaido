<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnCambiarTema = New System.Windows.Forms.Button()
        Me.PanelCboGestion = New System.Windows.Forms.Panel()
        Me.btnTipoVenta = New System.Windows.Forms.Button()
        Me.btnTipoVehiculos = New System.Windows.Forms.Button()
        Me.btnFormaPago = New System.Windows.Forms.Button()
        Me.btnFormaEntrega = New System.Windows.Forms.Button()
        Me.btnSeccion = New System.Windows.Forms.Button()
        Me.btnRubro = New System.Windows.Forms.Button()
        Me.btnRol = New System.Windows.Forms.Button()
        Me.btnMarca = New System.Windows.Forms.Button()
        Me.btnCiudad = New System.Windows.Forms.Button()
        Me.btnGestionDatos = New System.Windows.Forms.Button()
        Me.PanelCboTableroControl = New System.Windows.Forms.Panel()
        Me.btnMiscelaneas = New System.Windows.Forms.Button()
        Me.btnRepVentas = New System.Windows.Forms.Button()
        Me.btnRepCompras = New System.Windows.Forms.Button()
        Me.btnRepProductos = New System.Windows.Forms.Button()
        Me.btnRepReparaciones = New System.Windows.Forms.Button()
        Me.btnRepVehiculos = New System.Windows.Forms.Button()
        Me.btnRepPersona = New System.Windows.Forms.Button()
        Me.btnTableroControl = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.btnOrdenReparacion = New System.Windows.Forms.Button()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.btnPersonas = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelCboGestion.SuspendLayout()
        Me.PanelCboTableroControl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelContenedor.Location = New System.Drawing.Point(299, 0)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1301, 1055)
        Me.PanelContenedor.TabIndex = 2
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(88, 84)
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(89, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(89, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 19)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Rol:"
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ForeColor = System.Drawing.Color.White
        Me.lblRol.Location = New System.Drawing.Point(120, 43)
        Me.lblRol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(13, 19)
        Me.lblRol.TabIndex = 28
        Me.lblRol.Text = ":"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(153, 22)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(13, 19)
        Me.lblUsuario.TabIndex = 28
        Me.lblUsuario.Text = ":"
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnCambiarTema)
        Me.PanelMenu.Controls.Add(Me.PanelCboGestion)
        Me.PanelMenu.Controls.Add(Me.btnGestionDatos)
        Me.PanelMenu.Controls.Add(Me.PanelCboTableroControl)
        Me.PanelMenu.Controls.Add(Me.btnTableroControl)
        Me.PanelMenu.Controls.Add(Me.btnVentas)
        Me.PanelMenu.Controls.Add(Me.btnCompras)
        Me.PanelMenu.Controls.Add(Me.btnProducto)
        Me.PanelMenu.Controls.Add(Me.btnOrdenReparacion)
        Me.PanelMenu.Controls.Add(Me.btnVehiculos)
        Me.PanelMenu.Controls.Add(Me.btnPersonas)
        Me.PanelMenu.Controls.Add(Me.btnInicio)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.ForeColor = System.Drawing.Color.White
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(307, 1055)
        Me.PanelMenu.TabIndex = 0
        '
        'btnCambiarTema
        '
        Me.btnCambiarTema.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCambiarTema.BackColor = System.Drawing.Color.Transparent
        Me.btnCambiarTema.FlatAppearance.BorderSize = 0
        Me.btnCambiarTema.Location = New System.Drawing.Point(84, 1012)
        Me.btnCambiarTema.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCambiarTema.Name = "btnCambiarTema"
        Me.btnCambiarTema.Size = New System.Drawing.Size(135, 28)
        Me.btnCambiarTema.TabIndex = 0
        Me.btnCambiarTema.Text = "Button1"
        Me.btnCambiarTema.UseVisualStyleBackColor = False
        Me.btnCambiarTema.Visible = False
        '
        'PanelCboGestion
        '
        Me.PanelCboGestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.PanelCboGestion.Controls.Add(Me.btnTipoVenta)
        Me.PanelCboGestion.Controls.Add(Me.btnTipoVehiculos)
        Me.PanelCboGestion.Controls.Add(Me.btnFormaPago)
        Me.PanelCboGestion.Controls.Add(Me.btnFormaEntrega)
        Me.PanelCboGestion.Controls.Add(Me.btnSeccion)
        Me.PanelCboGestion.Controls.Add(Me.btnRubro)
        Me.PanelCboGestion.Controls.Add(Me.btnRol)
        Me.PanelCboGestion.Controls.Add(Me.btnMarca)
        Me.PanelCboGestion.Controls.Add(Me.btnCiudad)
        Me.PanelCboGestion.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCboGestion.ForeColor = System.Drawing.Color.White
        Me.PanelCboGestion.Location = New System.Drawing.Point(0, 689)
        Me.PanelCboGestion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelCboGestion.Name = "PanelCboGestion"
        Me.PanelCboGestion.Size = New System.Drawing.Size(307, 277)
        Me.PanelCboGestion.TabIndex = 52
        Me.PanelCboGestion.Tag = "0"
        Me.PanelCboGestion.Visible = False
        '
        'btnTipoVenta
        '
        Me.btnTipoVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnTipoVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTipoVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnTipoVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnTipoVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnTipoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoVenta.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnTipoVenta.ForeColor = System.Drawing.Color.White
        Me.btnTipoVenta.Location = New System.Drawing.Point(0, 242)
        Me.btnTipoVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTipoVenta.Name = "btnTipoVenta"
        Me.btnTipoVenta.Size = New System.Drawing.Size(307, 30)
        Me.btnTipoVenta.TabIndex = 25
        Me.btnTipoVenta.Text = "Tipos de Ventas"
        Me.btnTipoVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTipoVenta.UseVisualStyleBackColor = False
        '
        'btnTipoVehiculos
        '
        Me.btnTipoVehiculos.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnTipoVehiculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTipoVehiculos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTipoVehiculos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnTipoVehiculos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnTipoVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnTipoVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoVehiculos.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnTipoVehiculos.ForeColor = System.Drawing.Color.White
        Me.btnTipoVehiculos.Location = New System.Drawing.Point(0, 212)
        Me.btnTipoVehiculos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTipoVehiculos.Name = "btnTipoVehiculos"
        Me.btnTipoVehiculos.Size = New System.Drawing.Size(307, 30)
        Me.btnTipoVehiculos.TabIndex = 24
        Me.btnTipoVehiculos.Text = "Tipos de Vehiculos"
        Me.btnTipoVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTipoVehiculos.UseVisualStyleBackColor = False
        '
        'btnFormaPago
        '
        Me.btnFormaPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnFormaPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFormaPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnFormaPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnFormaPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormaPago.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnFormaPago.ForeColor = System.Drawing.Color.White
        Me.btnFormaPago.Location = New System.Drawing.Point(0, 181)
        Me.btnFormaPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFormaPago.Name = "btnFormaPago"
        Me.btnFormaPago.Size = New System.Drawing.Size(307, 31)
        Me.btnFormaPago.TabIndex = 23
        Me.btnFormaPago.Text = "Formas de Pago"
        Me.btnFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormaPago.UseVisualStyleBackColor = False
        '
        'btnFormaEntrega
        '
        Me.btnFormaEntrega.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnFormaEntrega.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFormaEntrega.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnFormaEntrega.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnFormaEntrega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnFormaEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormaEntrega.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnFormaEntrega.ForeColor = System.Drawing.Color.White
        Me.btnFormaEntrega.Location = New System.Drawing.Point(0, 150)
        Me.btnFormaEntrega.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFormaEntrega.Name = "btnFormaEntrega"
        Me.btnFormaEntrega.Size = New System.Drawing.Size(307, 31)
        Me.btnFormaEntrega.TabIndex = 22
        Me.btnFormaEntrega.Text = "Formas de Entrega"
        Me.btnFormaEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormaEntrega.UseVisualStyleBackColor = False
        '
        'btnSeccion
        '
        Me.btnSeccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnSeccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSeccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnSeccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnSeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeccion.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnSeccion.ForeColor = System.Drawing.Color.White
        Me.btnSeccion.Location = New System.Drawing.Point(0, 120)
        Me.btnSeccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSeccion.Name = "btnSeccion"
        Me.btnSeccion.Size = New System.Drawing.Size(307, 30)
        Me.btnSeccion.TabIndex = 21
        Me.btnSeccion.Text = "Secciones"
        Me.btnSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeccion.UseVisualStyleBackColor = False
        '
        'btnRubro
        '
        Me.btnRubro.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRubro.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRubro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRubro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnRubro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRubro.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnRubro.ForeColor = System.Drawing.Color.White
        Me.btnRubro.Location = New System.Drawing.Point(0, 90)
        Me.btnRubro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRubro.Name = "btnRubro"
        Me.btnRubro.Size = New System.Drawing.Size(307, 30)
        Me.btnRubro.TabIndex = 20
        Me.btnRubro.Text = "Rubros"
        Me.btnRubro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRubro.UseVisualStyleBackColor = False
        '
        'btnRol
        '
        Me.btnRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRol.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRol.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnRol.ForeColor = System.Drawing.Color.White
        Me.btnRol.Location = New System.Drawing.Point(0, 60)
        Me.btnRol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRol.Name = "btnRol"
        Me.btnRol.Size = New System.Drawing.Size(307, 30)
        Me.btnRol.TabIndex = 19
        Me.btnRol.Text = "Roles"
        Me.btnRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRol.UseVisualStyleBackColor = False
        '
        'btnMarca
        '
        Me.btnMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnMarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarca.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnMarca.ForeColor = System.Drawing.Color.White
        Me.btnMarca.Location = New System.Drawing.Point(0, 30)
        Me.btnMarca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMarca.Name = "btnMarca"
        Me.btnMarca.Size = New System.Drawing.Size(307, 30)
        Me.btnMarca.TabIndex = 18
        Me.btnMarca.Text = "Marcas"
        Me.btnMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarca.UseVisualStyleBackColor = False
        '
        'btnCiudad
        '
        Me.btnCiudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnCiudad.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCiudad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnCiudad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnCiudad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCiudad.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnCiudad.ForeColor = System.Drawing.Color.White
        Me.btnCiudad.Location = New System.Drawing.Point(0, 0)
        Me.btnCiudad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCiudad.Name = "btnCiudad"
        Me.btnCiudad.Size = New System.Drawing.Size(307, 30)
        Me.btnCiudad.TabIndex = 17
        Me.btnCiudad.Text = "Ciudades"
        Me.btnCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCiudad.UseVisualStyleBackColor = False
        '
        'btnGestionDatos
        '
        Me.btnGestionDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnGestionDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGestionDatos.FlatAppearance.BorderSize = 0
        Me.btnGestionDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnGestionDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestionDatos.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnGestionDatos.ForeColor = System.Drawing.Color.White
        Me.btnGestionDatos.Image = CType(resources.GetObject("btnGestionDatos.Image"), System.Drawing.Image)
        Me.btnGestionDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionDatos.Location = New System.Drawing.Point(0, 646)
        Me.btnGestionDatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGestionDatos.Name = "btnGestionDatos"
        Me.btnGestionDatos.Size = New System.Drawing.Size(307, 43)
        Me.btnGestionDatos.TabIndex = 16
        Me.btnGestionDatos.Text = "        Gestión de Datos"
        Me.btnGestionDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionDatos.UseVisualStyleBackColor = False
        '
        'PanelCboTableroControl
        '
        Me.PanelCboTableroControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.PanelCboTableroControl.Controls.Add(Me.btnMiscelaneas)
        Me.PanelCboTableroControl.Controls.Add(Me.btnRepVentas)
        Me.PanelCboTableroControl.Controls.Add(Me.btnRepCompras)
        Me.PanelCboTableroControl.Controls.Add(Me.btnRepProductos)
        Me.PanelCboTableroControl.Controls.Add(Me.btnRepReparaciones)
        Me.PanelCboTableroControl.Controls.Add(Me.btnRepVehiculos)
        Me.PanelCboTableroControl.Controls.Add(Me.btnRepPersona)
        Me.PanelCboTableroControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCboTableroControl.ForeColor = System.Drawing.Color.White
        Me.PanelCboTableroControl.Location = New System.Drawing.Point(0, 428)
        Me.PanelCboTableroControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelCboTableroControl.Name = "PanelCboTableroControl"
        Me.PanelCboTableroControl.Size = New System.Drawing.Size(307, 218)
        Me.PanelCboTableroControl.TabIndex = 38
        Me.PanelCboTableroControl.Tag = "0"
        Me.PanelCboTableroControl.Visible = False
        '
        'btnMiscelaneas
        '
        Me.btnMiscelaneas.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnMiscelaneas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMiscelaneas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnMiscelaneas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnMiscelaneas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnMiscelaneas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMiscelaneas.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnMiscelaneas.ForeColor = System.Drawing.Color.White
        Me.btnMiscelaneas.Location = New System.Drawing.Point(0, 181)
        Me.btnMiscelaneas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMiscelaneas.Name = "btnMiscelaneas"
        Me.btnMiscelaneas.Size = New System.Drawing.Size(307, 31)
        Me.btnMiscelaneas.TabIndex = 15
        Me.btnMiscelaneas.Text = "Misceláneas"
        Me.btnMiscelaneas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMiscelaneas.UseVisualStyleBackColor = False
        '
        'btnRepVentas
        '
        Me.btnRepVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRepVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRepVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRepVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnRepVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRepVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepVentas.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnRepVentas.ForeColor = System.Drawing.Color.White
        Me.btnRepVentas.Location = New System.Drawing.Point(0, 150)
        Me.btnRepVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRepVentas.Name = "btnRepVentas"
        Me.btnRepVentas.Size = New System.Drawing.Size(307, 31)
        Me.btnRepVentas.TabIndex = 14
        Me.btnRepVentas.Text = "Ventas"
        Me.btnRepVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepVentas.UseVisualStyleBackColor = False
        '
        'btnRepCompras
        '
        Me.btnRepCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRepCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRepCompras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRepCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnRepCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRepCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepCompras.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnRepCompras.ForeColor = System.Drawing.Color.White
        Me.btnRepCompras.Location = New System.Drawing.Point(0, 120)
        Me.btnRepCompras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRepCompras.Name = "btnRepCompras"
        Me.btnRepCompras.Size = New System.Drawing.Size(307, 30)
        Me.btnRepCompras.TabIndex = 13
        Me.btnRepCompras.Text = "Compras"
        Me.btnRepCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepCompras.UseVisualStyleBackColor = False
        '
        'btnRepProductos
        '
        Me.btnRepProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRepProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRepProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRepProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnRepProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRepProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepProductos.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnRepProductos.ForeColor = System.Drawing.Color.White
        Me.btnRepProductos.Location = New System.Drawing.Point(0, 90)
        Me.btnRepProductos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRepProductos.Name = "btnRepProductos"
        Me.btnRepProductos.Size = New System.Drawing.Size(307, 30)
        Me.btnRepProductos.TabIndex = 12
        Me.btnRepProductos.Text = "Productos"
        Me.btnRepProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepProductos.UseVisualStyleBackColor = False
        '
        'btnRepReparaciones
        '
        Me.btnRepReparaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRepReparaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRepReparaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRepReparaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnRepReparaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRepReparaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepReparaciones.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnRepReparaciones.ForeColor = System.Drawing.Color.White
        Me.btnRepReparaciones.Location = New System.Drawing.Point(0, 60)
        Me.btnRepReparaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRepReparaciones.Name = "btnRepReparaciones"
        Me.btnRepReparaciones.Size = New System.Drawing.Size(307, 30)
        Me.btnRepReparaciones.TabIndex = 11
        Me.btnRepReparaciones.Text = "Reparaciones"
        Me.btnRepReparaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepReparaciones.UseVisualStyleBackColor = False
        '
        'btnRepVehiculos
        '
        Me.btnRepVehiculos.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRepVehiculos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRepVehiculos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRepVehiculos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnRepVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRepVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepVehiculos.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnRepVehiculos.ForeColor = System.Drawing.Color.White
        Me.btnRepVehiculos.Location = New System.Drawing.Point(0, 30)
        Me.btnRepVehiculos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRepVehiculos.Name = "btnRepVehiculos"
        Me.btnRepVehiculos.Size = New System.Drawing.Size(307, 30)
        Me.btnRepVehiculos.TabIndex = 10
        Me.btnRepVehiculos.Text = "Vehiculos"
        Me.btnRepVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepVehiculos.UseVisualStyleBackColor = False
        '
        'btnRepPersona
        '
        Me.btnRepPersona.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRepPersona.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRepPersona.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRepPersona.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnRepPersona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRepPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepPersona.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnRepPersona.ForeColor = System.Drawing.Color.White
        Me.btnRepPersona.Location = New System.Drawing.Point(0, 0)
        Me.btnRepPersona.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRepPersona.Name = "btnRepPersona"
        Me.btnRepPersona.Size = New System.Drawing.Size(307, 30)
        Me.btnRepPersona.TabIndex = 9
        Me.btnRepPersona.Text = "Personas"
        Me.btnRepPersona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepPersona.UseVisualStyleBackColor = False
        '
        'btnTableroControl
        '
        Me.btnTableroControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnTableroControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTableroControl.FlatAppearance.BorderSize = 0
        Me.btnTableroControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnTableroControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTableroControl.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnTableroControl.ForeColor = System.Drawing.Color.White
        Me.btnTableroControl.Image = CType(resources.GetObject("btnTableroControl.Image"), System.Drawing.Image)
        Me.btnTableroControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTableroControl.Location = New System.Drawing.Point(0, 385)
        Me.btnTableroControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTableroControl.Name = "btnTableroControl"
        Me.btnTableroControl.Size = New System.Drawing.Size(307, 43)
        Me.btnTableroControl.TabIndex = 8
        Me.btnTableroControl.Text = "        Tablero de Control"
        Me.btnTableroControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTableroControl.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnVentas.ForeColor = System.Drawing.Color.White
        Me.btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), System.Drawing.Image)
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(0, 342)
        Me.btnVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(307, 43)
        Me.btnVentas.TabIndex = 7
        Me.btnVentas.Text = "        Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnCompras
        '
        Me.btnCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnCompras.ForeColor = System.Drawing.Color.White
        Me.btnCompras.Image = CType(resources.GetObject("btnCompras.Image"), System.Drawing.Image)
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.Location = New System.Drawing.Point(0, 299)
        Me.btnCompras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(307, 43)
        Me.btnCompras.TabIndex = 6
        Me.btnCompras.Text = "        Compras"
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.UseVisualStyleBackColor = False
        '
        'btnProducto
        '
        Me.btnProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProducto.FlatAppearance.BorderSize = 0
        Me.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducto.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnProducto.ForeColor = System.Drawing.Color.White
        Me.btnProducto.Image = CType(resources.GetObject("btnProducto.Image"), System.Drawing.Image)
        Me.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducto.Location = New System.Drawing.Point(0, 256)
        Me.btnProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(307, 43)
        Me.btnProducto.TabIndex = 5
        Me.btnProducto.Text = "        Productos"
        Me.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducto.UseVisualStyleBackColor = False
        '
        'btnOrdenReparacion
        '
        Me.btnOrdenReparacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnOrdenReparacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrdenReparacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrdenReparacion.FlatAppearance.BorderSize = 0
        Me.btnOrdenReparacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnOrdenReparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenReparacion.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnOrdenReparacion.ForeColor = System.Drawing.Color.White
        Me.btnOrdenReparacion.Image = CType(resources.GetObject("btnOrdenReparacion.Image"), System.Drawing.Image)
        Me.btnOrdenReparacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrdenReparacion.Location = New System.Drawing.Point(0, 213)
        Me.btnOrdenReparacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOrdenReparacion.Name = "btnOrdenReparacion"
        Me.btnOrdenReparacion.Size = New System.Drawing.Size(307, 43)
        Me.btnOrdenReparacion.TabIndex = 4
        Me.btnOrdenReparacion.Text = "        Reparaciones"
        Me.btnOrdenReparacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrdenReparacion.UseVisualStyleBackColor = False
        '
        'btnVehiculos
        '
        Me.btnVehiculos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnVehiculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVehiculos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVehiculos.FlatAppearance.BorderSize = 0
        Me.btnVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVehiculos.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnVehiculos.ForeColor = System.Drawing.Color.White
        Me.btnVehiculos.Image = CType(resources.GetObject("btnVehiculos.Image"), System.Drawing.Image)
        Me.btnVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehiculos.Location = New System.Drawing.Point(0, 170)
        Me.btnVehiculos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(307, 43)
        Me.btnVehiculos.TabIndex = 3
        Me.btnVehiculos.Text = "        Vehículos"
        Me.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehiculos.UseVisualStyleBackColor = False
        '
        'btnPersonas
        '
        Me.btnPersonas.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnPersonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPersonas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPersonas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPersonas.FlatAppearance.BorderSize = 0
        Me.btnPersonas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPersonas.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnPersonas.ForeColor = System.Drawing.Color.White
        Me.btnPersonas.Image = CType(resources.GetObject("btnPersonas.Image"), System.Drawing.Image)
        Me.btnPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPersonas.Location = New System.Drawing.Point(0, 127)
        Me.btnPersonas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPersonas.Name = "btnPersonas"
        Me.btnPersonas.Size = New System.Drawing.Size(307, 43)
        Me.btnPersonas.TabIndex = 2
        Me.btnPersonas.Text = "        Personas"
        Me.btnPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPersonas.UseVisualStyleBackColor = False
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), System.Drawing.Image)
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(0, 84)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(307, 43)
        Me.btnInicio.TabIndex = 1
        Me.btnInicio.Text = "        Inicio"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox7)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lblUsuario)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lblRol)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(307, 84)
        Me.Panel3.TabIndex = 1
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1600, 1055)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelMenu)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mecánica Gaido - Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelCboGestion.ResumeLayout(False)
        Me.PanelCboTableroControl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRol As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnOrdenReparacion As Button
    Friend WithEvents btnVehiculos As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnPersonas As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnProducto As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnCompras As Button
    Friend WithEvents PanelCboGestion As Panel
    Friend WithEvents btnTipoVenta As Button
    Friend WithEvents btnTipoVehiculos As Button
    Friend WithEvents btnFormaPago As Button
    Friend WithEvents btnFormaEntrega As Button
    Friend WithEvents btnSeccion As Button
    Friend WithEvents btnRubro As Button
    Friend WithEvents btnRol As Button
    Friend WithEvents btnMarca As Button
    Friend WithEvents btnCiudad As Button
    Friend WithEvents btnGestionDatos As Button
    Friend WithEvents PanelCboTableroControl As Panel
    Friend WithEvents btnMiscelaneas As Button
    Friend WithEvents btnRepVentas As Button
    Friend WithEvents btnRepCompras As Button
    Friend WithEvents btnRepProductos As Button
    Friend WithEvents btnRepReparaciones As Button
    Friend WithEvents btnRepVehiculos As Button
    Friend WithEvents btnRepPersona As Button
    Friend WithEvents btnTableroControl As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnCambiarTema As Button
End Class
