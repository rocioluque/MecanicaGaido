﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
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
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.grdProductosBajoStock = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExportarPDF = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnGestionDatos = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnOrdenReparacón = New System.Windows.Forms.Button()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnPersonas = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.horaFecha = New System.Windows.Forms.Timer(Me.components)
        Me.id_Repuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDisponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelCboGestion.SuspendLayout()
        Me.panelContenedor.SuspendLayout()
        CType(Me.grdProductosBajoStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.PanelCboGestion.Location = New System.Drawing.Point(0, 383)
        Me.PanelCboGestion.Name = "PanelCboGestion"
        Me.PanelCboGestion.Size = New System.Drawing.Size(230, 225)
        Me.PanelCboGestion.TabIndex = 0
        Me.PanelCboGestion.Tag = "0"
        Me.PanelCboGestion.Visible = False
        '
        'btnTipoVenta
        '
        Me.btnTipoVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTipoVenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnTipoVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnTipoVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnTipoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoVenta.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnTipoVenta.ForeColor = System.Drawing.Color.White
        Me.btnTipoVenta.Location = New System.Drawing.Point(0, 194)
        Me.btnTipoVenta.Name = "btnTipoVenta"
        Me.btnTipoVenta.Size = New System.Drawing.Size(230, 24)
        Me.btnTipoVenta.TabIndex = 12
        Me.btnTipoVenta.Text = "Tipos de Ventas"
        Me.btnTipoVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTipoVenta.UseVisualStyleBackColor = True
        '
        'btnTipoVehiculos
        '
        Me.btnTipoVehiculos.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnTipoVehiculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTipoVehiculos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTipoVehiculos.FlatAppearance.BorderSize = 0
        Me.btnTipoVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnTipoVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoVehiculos.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnTipoVehiculos.ForeColor = System.Drawing.Color.White
        Me.btnTipoVehiculos.Location = New System.Drawing.Point(0, 170)
        Me.btnTipoVehiculos.Name = "btnTipoVehiculos"
        Me.btnTipoVehiculos.Size = New System.Drawing.Size(230, 24)
        Me.btnTipoVehiculos.TabIndex = 37
        Me.btnTipoVehiculos.Text = "Tipos de Vehiculos"
        Me.btnTipoVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTipoVehiculos.UseVisualStyleBackColor = False
        '
        'btnFormaPago
        '
        Me.btnFormaPago.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFormaPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnFormaPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnFormaPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormaPago.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnFormaPago.ForeColor = System.Drawing.Color.White
        Me.btnFormaPago.Location = New System.Drawing.Point(0, 145)
        Me.btnFormaPago.Name = "btnFormaPago"
        Me.btnFormaPago.Size = New System.Drawing.Size(230, 25)
        Me.btnFormaPago.TabIndex = 14
        Me.btnFormaPago.Text = "Formas de Pago"
        Me.btnFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormaPago.UseVisualStyleBackColor = True
        '
        'btnFormaEntrega
        '
        Me.btnFormaEntrega.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFormaEntrega.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnFormaEntrega.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnFormaEntrega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnFormaEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormaEntrega.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnFormaEntrega.ForeColor = System.Drawing.Color.White
        Me.btnFormaEntrega.Location = New System.Drawing.Point(0, 120)
        Me.btnFormaEntrega.Name = "btnFormaEntrega"
        Me.btnFormaEntrega.Size = New System.Drawing.Size(230, 25)
        Me.btnFormaEntrega.TabIndex = 11
        Me.btnFormaEntrega.Text = "Formas de Entrega"
        Me.btnFormaEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormaEntrega.UseVisualStyleBackColor = True
        '
        'btnSeccion
        '
        Me.btnSeccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSeccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnSeccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnSeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeccion.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnSeccion.ForeColor = System.Drawing.Color.White
        Me.btnSeccion.Location = New System.Drawing.Point(0, 96)
        Me.btnSeccion.Name = "btnSeccion"
        Me.btnSeccion.Size = New System.Drawing.Size(230, 24)
        Me.btnSeccion.TabIndex = 10
        Me.btnSeccion.Text = "Secciones"
        Me.btnSeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeccion.UseVisualStyleBackColor = True
        '
        'btnRubro
        '
        Me.btnRubro.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRubro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRubro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnRubro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRubro.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnRubro.ForeColor = System.Drawing.Color.White
        Me.btnRubro.Location = New System.Drawing.Point(0, 72)
        Me.btnRubro.Name = "btnRubro"
        Me.btnRubro.Size = New System.Drawing.Size(230, 24)
        Me.btnRubro.TabIndex = 12
        Me.btnRubro.Text = "Rubros"
        Me.btnRubro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRubro.UseVisualStyleBackColor = True
        '
        'btnRol
        '
        Me.btnRol.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRol.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnRol.ForeColor = System.Drawing.Color.White
        Me.btnRol.Location = New System.Drawing.Point(0, 48)
        Me.btnRol.Name = "btnRol"
        Me.btnRol.Size = New System.Drawing.Size(230, 24)
        Me.btnRol.TabIndex = 13
        Me.btnRol.Text = "Roles"
        Me.btnRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRol.UseVisualStyleBackColor = True
        '
        'btnMarca
        '
        Me.btnMarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarca.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnMarca.ForeColor = System.Drawing.Color.White
        Me.btnMarca.Location = New System.Drawing.Point(0, 24)
        Me.btnMarca.Name = "btnMarca"
        Me.btnMarca.Size = New System.Drawing.Size(230, 24)
        Me.btnMarca.TabIndex = 11
        Me.btnMarca.Text = "Marcas"
        Me.btnMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarca.UseVisualStyleBackColor = True
        '
        'btnCiudad
        '
        Me.btnCiudad.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCiudad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnCiudad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnCiudad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCiudad.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnCiudad.ForeColor = System.Drawing.Color.White
        Me.btnCiudad.Location = New System.Drawing.Point(0, 0)
        Me.btnCiudad.Name = "btnCiudad"
        Me.btnCiudad.Size = New System.Drawing.Size(230, 24)
        Me.btnCiudad.TabIndex = 10
        Me.btnCiudad.Text = "Ciudades"
        Me.btnCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCiudad.UseVisualStyleBackColor = True
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.panelContenedor.Controls.Add(Me.grdProductosBajoStock)
        Me.panelContenedor.Controls.Add(Me.Label3)
        Me.panelContenedor.Controls.Add(Me.btnExportarPDF)
        Me.panelContenedor.Controls.Add(Me.lblFecha)
        Me.panelContenedor.Controls.Add(Me.lblHora)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelContenedor.Location = New System.Drawing.Point(224, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(976, 700)
        Me.panelContenedor.TabIndex = 2
        '
        'grdProductosBajoStock
        '
        Me.grdProductosBajoStock.AllowUserToAddRows = False
        Me.grdProductosBajoStock.AllowUserToDeleteRows = False
        Me.grdProductosBajoStock.AllowUserToResizeRows = False
        Me.grdProductosBajoStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdProductosBajoStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.grdProductosBajoStock.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdProductosBajoStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProductosBajoStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdProductosBajoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProductosBajoStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Repuesto, Me.Descripcion, Me.StockDisponible})
        Me.grdProductosBajoStock.Location = New System.Drawing.Point(46, 391)
        Me.grdProductosBajoStock.Name = "grdProductosBajoStock"
        Me.grdProductosBajoStock.ReadOnly = True
        Me.grdProductosBajoStock.RowHeadersVisible = False
        Me.grdProductosBajoStock.RowHeadersWidth = 51
        Me.grdProductosBajoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdProductosBajoStock.Size = New System.Drawing.Size(638, 297)
        Me.grdProductosBajoStock.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 22)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Productos de bajo Stock:"
        '
        'btnExportarPDF
        '
        Me.btnExportarPDF.BackColor = System.Drawing.Color.Transparent
        Me.btnExportarPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExportarPDF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportarPDF.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnExportarPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnExportarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarPDF.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnExportarPDF.ForeColor = System.Drawing.Color.White
        Me.btnExportarPDF.Image = CType(resources.GetObject("btnExportarPDF.Image"), System.Drawing.Image)
        Me.btnExportarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarPDF.Location = New System.Drawing.Point(590, 346)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Size = New System.Drawing.Size(94, 35)
        Me.btnExportarPDF.TabIndex = 106
        Me.btnExportarPDF.Text = "        PDF"
        Me.btnExportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarPDF.UseVisualStyleBackColor = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 30.0!)
        Me.lblFecha.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblFecha.Location = New System.Drawing.Point(24, 89)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(144, 49)
        Me.lblFecha.TabIndex = 31
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblHora.Font = New System.Drawing.Font("Century Gothic", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(3, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(226, 96)
        Me.lblHora.TabIndex = 30
        Me.lblHora.Text = "Hora"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(66, 68)
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
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
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 665)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(230, 35)
        Me.btnCerrarSesion.TabIndex = 32
        Me.btnCerrarSesion.Text = "        Cerrar Sesión"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(67, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(67, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Rol:"
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ForeColor = System.Drawing.Color.White
        Me.lblRol.Location = New System.Drawing.Point(90, 35)
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
        Me.lblUsuario.Location = New System.Drawing.Point(115, 18)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(11, 16)
        Me.lblUsuario.TabIndex = 28
        Me.lblUsuario.Text = ":"
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PanelCboGestion)
        Me.PanelMenu.Controls.Add(Me.btnGestionDatos)
        Me.PanelMenu.Controls.Add(Me.btnReportes)
        Me.PanelMenu.Controls.Add(Me.btnCompras)
        Me.PanelMenu.Controls.Add(Me.btnVentas)
        Me.PanelMenu.Controls.Add(Me.btnOrdenReparacón)
        Me.PanelMenu.Controls.Add(Me.btnVehiculos)
        Me.PanelMenu.Controls.Add(Me.btnProductos)
        Me.PanelMenu.Controls.Add(Me.btnPersonas)
        Me.PanelMenu.Controls.Add(Me.btnInicio)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.btnCerrarSesion)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(230, 700)
        Me.PanelMenu.TabIndex = 0
        '
        'btnGestionDatos
        '
        Me.btnGestionDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnGestionDatos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGestionDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGestionDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnGestionDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnGestionDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnGestionDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestionDatos.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnGestionDatos.ForeColor = System.Drawing.Color.White
        Me.btnGestionDatos.Image = CType(resources.GetObject("btnGestionDatos.Image"), System.Drawing.Image)
        Me.btnGestionDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionDatos.Location = New System.Drawing.Point(0, 348)
        Me.btnGestionDatos.Name = "btnGestionDatos"
        Me.btnGestionDatos.Size = New System.Drawing.Size(230, 35)
        Me.btnGestionDatos.TabIndex = 47
        Me.btnGestionDatos.Text = "        Gestión de Datos "
        Me.btnGestionDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionDatos.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(0, 313)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(230, 35)
        Me.btnReportes.TabIndex = 46
        Me.btnReportes.Text = "        Reportes "
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'btnCompras
        '
        Me.btnCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompras.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnCompras.ForeColor = System.Drawing.Color.White
        Me.btnCompras.Image = CType(resources.GetObject("btnCompras.Image"), System.Drawing.Image)
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.Location = New System.Drawing.Point(0, 278)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(230, 35)
        Me.btnCompras.TabIndex = 45
        Me.btnCompras.Text = "        Compras "
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompras.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnVentas.ForeColor = System.Drawing.Color.White
        Me.btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), System.Drawing.Image)
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(0, 243)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(230, 35)
        Me.btnVentas.TabIndex = 44
        Me.btnVentas.Text = "        Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnOrdenReparacón
        '
        Me.btnOrdenReparacón.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnOrdenReparacón.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrdenReparacón.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrdenReparacón.FlatAppearance.BorderSize = 0
        Me.btnOrdenReparacón.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnOrdenReparacón.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenReparacón.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnOrdenReparacón.ForeColor = System.Drawing.Color.White
        Me.btnOrdenReparacón.Image = CType(resources.GetObject("btnOrdenReparacón.Image"), System.Drawing.Image)
        Me.btnOrdenReparacón.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrdenReparacón.Location = New System.Drawing.Point(0, 208)
        Me.btnOrdenReparacón.Name = "btnOrdenReparacón"
        Me.btnOrdenReparacón.Size = New System.Drawing.Size(230, 35)
        Me.btnOrdenReparacón.TabIndex = 43
        Me.btnOrdenReparacón.Text = "        Reparaciones"
        Me.btnOrdenReparacón.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrdenReparacón.UseVisualStyleBackColor = False
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
        Me.btnVehiculos.Location = New System.Drawing.Point(0, 173)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(230, 35)
        Me.btnVehiculos.TabIndex = 42
        Me.btnVehiculos.Text = "        Vehículos"
        Me.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehiculos.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnProductos.ForeColor = System.Drawing.Color.White
        Me.btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), System.Drawing.Image)
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(0, 138)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(230, 35)
        Me.btnProductos.TabIndex = 41
        Me.btnProductos.Text = "        Productos"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.UseVisualStyleBackColor = False
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
        Me.btnPersonas.Location = New System.Drawing.Point(0, 103)
        Me.btnPersonas.Name = "btnPersonas"
        Me.btnPersonas.Size = New System.Drawing.Size(230, 35)
        Me.btnPersonas.TabIndex = 40
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
        Me.btnInicio.Location = New System.Drawing.Point(0, 68)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(230, 35)
        Me.btnInicio.TabIndex = 39
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
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(230, 68)
        Me.Panel3.TabIndex = 1
        '
        'horaFecha
        '
        Me.horaFecha.Enabled = True
        '
        'id_Repuesto
        '
        Me.id_Repuesto.HeaderText = "N° Repuesto"
        Me.id_Repuesto.Name = "id_Repuesto"
        Me.id_Repuesto.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'StockDisponible
        '
        Me.StockDisponible.HeaderText = "Stock Disponible"
        Me.StockDisponible.Name = "StockDisponible"
        Me.StockDisponible.ReadOnly = True
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.PanelMenu)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mecánica Gaido - Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelCboGestion.ResumeLayout(False)
        Me.panelContenedor.ResumeLayout(False)
        Me.panelContenedor.PerformLayout()
        CType(Me.grdProductosBajoStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents PanelCboGestion As Panel
    Friend WithEvents btnFormaPago As Button
    Friend WithEvents btnCiudad As Button
    Friend WithEvents btnRol As Button
    Friend WithEvents btnRubro As Button
    Friend WithEvents btnFormaEntrega As Button
    Friend WithEvents btnMarca As Button
    Friend WithEvents btnSeccion As Button
    Friend WithEvents btnTipoVenta As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRol As Label
    Friend WithEvents btnTipoVehiculos As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnGestionDatos As Button
    Friend WithEvents btnReportes As Button
    Friend WithEvents btnCompras As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnOrdenReparacón As Button
    Friend WithEvents btnVehiculos As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnPersonas As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents horaFecha As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExportarPDF As Button
    Friend WithEvents grdProductosBajoStock As DataGridView
    Friend WithEvents id_Repuesto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents StockDisponible As DataGridViewTextBoxColumn
End Class
