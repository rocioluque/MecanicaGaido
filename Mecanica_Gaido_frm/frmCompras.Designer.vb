<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompras))
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtOtrosImpuestos = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtNumComprobante = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cboFormaPago = New System.Windows.Forms.ComboBox()
        Me.cboPersona = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregarCuenta = New System.Windows.Forms.PictureBox()
        Me.btnAgregarFormaPago = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.grdCompras = New System.Windows.Forms.DataGridView()
        Me.PanelDetalleDeCompras = New System.Windows.Forms.Panel()
        Me.btnQuitarVenta = New System.Windows.Forms.Button()
        Me.btnAgregarVenta = New System.Windows.Forms.Button()
        Me.CboListaPrecios = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCantidadVentas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboProductoVenta = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblInformacionGeneral = New System.Windows.Forms.Label()
        Me.PanelInformacionGeneral = New System.Windows.Forms.Panel()
        Me.dtpFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.PanelTotales = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.RichTextBox()
        Me.txtIvaMonto = New System.Windows.Forms.RichTextBox()
        Me.txtSubtotal = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelImpuestos = New System.Windows.Forms.Panel()
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetalleDeCompras.SuspendLayout()
        Me.PanelInformacionGeneral.SuspendLayout()
        Me.PanelTotales.SuspendLayout()
        Me.PanelImpuestos.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(219, 122)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(85, 21)
        Me.chkEstado.TabIndex = 12
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'txtOtrosImpuestos
        '
        Me.txtOtrosImpuestos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtrosImpuestos.Location = New System.Drawing.Point(125, 61)
        Me.txtOtrosImpuestos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOtrosImpuestos.Name = "txtOtrosImpuestos"
        Me.txtOtrosImpuestos.Size = New System.Drawing.Size(123, 23)
        Me.txtOtrosImpuestos.TabIndex = 10
        '
        'txtIVA
        '
        Me.txtIVA.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVA.Location = New System.Drawing.Point(125, 25)
        Me.txtIVA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(123, 23)
        Me.txtIVA.TabIndex = 8
        '
        'txtNumComprobante
        '
        Me.txtNumComprobante.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumComprobante.Location = New System.Drawing.Point(298, 36)
        Me.txtNumComprobante.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumComprobante.Name = "txtNumComprobante"
        Me.txtNumComprobante.Size = New System.Drawing.Size(220, 23)
        Me.txtNumComprobante.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(165, 44)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(46, 23)
        Me.txtID.TabIndex = 1
        '
        'cboFormaPago
        '
        Me.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormaPago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormaPago.FormattingEnabled = True
        Me.cboFormaPago.Location = New System.Drawing.Point(298, 90)
        Me.cboFormaPago.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Size = New System.Drawing.Size(189, 25)
        Me.cboFormaPago.TabIndex = 6
        '
        'cboPersona
        '
        Me.cboPersona.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPersona.FormattingEnabled = True
        Me.cboPersona.Location = New System.Drawing.Point(15, 90)
        Me.cboPersona.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPersona.Name = "cboPersona"
        Me.cboPersona.Size = New System.Drawing.Size(169, 25)
        Me.cboPersona.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(8, 61)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 17)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Otros impuestos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(10, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "IVA %"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(295, 71)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Forma de pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 71)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Vendedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(295, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "N° Comprobante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Fecha compra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "N° Compra"
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.BackgroundImage = CType(resources.GetObject("btnAgregarCuenta.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(189, 90)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarCuenta.TabIndex = 87
        Me.btnAgregarCuenta.TabStop = False
        '
        'btnAgregarFormaPago
        '
        Me.btnAgregarFormaPago.BackgroundImage = CType(resources.GetObject("btnAgregarFormaPago.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarFormaPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarFormaPago.Location = New System.Drawing.Point(492, 90)
        Me.btnAgregarFormaPago.Name = "btnAgregarFormaPago"
        Me.btnAgregarFormaPago.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarFormaPago.TabIndex = 88
        Me.btnAgregarFormaPago.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(887, 141)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(117, 37)
        Me.btnModificar.TabIndex = 14
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(887, 244)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 37)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(887, 38)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 37)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(238, 38)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 28)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'grdCompras
        '
        Me.grdCompras.AllowUserToAddRows = False
        Me.grdCompras.AllowUserToDeleteRows = False
        Me.grdCompras.AllowUserToOrderColumns = True
        Me.grdCompras.AllowUserToResizeRows = False
        Me.grdCompras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCompras.Location = New System.Drawing.Point(40, 60)
        Me.grdCompras.Name = "grdCompras"
        Me.grdCompras.ReadOnly = True
        Me.grdCompras.RowHeadersVisible = False
        Me.grdCompras.RowHeadersWidth = 51
        Me.grdCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCompras.Size = New System.Drawing.Size(888, 261)
        Me.grdCompras.TabIndex = 114
        '
        'PanelDetalleDeCompras
        '
        Me.PanelDetalleDeCompras.Controls.Add(Me.btnQuitarVenta)
        Me.PanelDetalleDeCompras.Controls.Add(Me.btnAgregarVenta)
        Me.PanelDetalleDeCompras.Controls.Add(Me.CboListaPrecios)
        Me.PanelDetalleDeCompras.Controls.Add(Me.Label15)
        Me.PanelDetalleDeCompras.Controls.Add(Me.txtCantidadVentas)
        Me.PanelDetalleDeCompras.Controls.Add(Me.Label12)
        Me.PanelDetalleDeCompras.Controls.Add(Me.cboProductoVenta)
        Me.PanelDetalleDeCompras.Controls.Add(Me.Label6)
        Me.PanelDetalleDeCompras.Controls.Add(Me.grdCompras)
        Me.PanelDetalleDeCompras.Location = New System.Drawing.Point(46, 306)
        Me.PanelDetalleDeCompras.Name = "PanelDetalleDeCompras"
        Me.PanelDetalleDeCompras.Size = New System.Drawing.Size(958, 324)
        Me.PanelDetalleDeCompras.TabIndex = 115
        '
        'btnQuitarVenta
        '
        Me.btnQuitarVenta.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitarVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitarVenta.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnQuitarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnQuitarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarVenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarVenta.ForeColor = System.Drawing.Color.White
        Me.btnQuitarVenta.Location = New System.Drawing.Point(782, 10)
        Me.btnQuitarVenta.Name = "btnQuitarVenta"
        Me.btnQuitarVenta.Size = New System.Drawing.Size(117, 37)
        Me.btnQuitarVenta.TabIndex = 22
        Me.btnQuitarVenta.Text = "Quitar"
        Me.btnQuitarVenta.UseVisualStyleBackColor = False
        '
        'btnAgregarVenta
        '
        Me.btnAgregarVenta.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarVenta.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAgregarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarVenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarVenta.ForeColor = System.Drawing.Color.White
        Me.btnAgregarVenta.Location = New System.Drawing.Point(654, 10)
        Me.btnAgregarVenta.Name = "btnAgregarVenta"
        Me.btnAgregarVenta.Size = New System.Drawing.Size(117, 37)
        Me.btnAgregarVenta.TabIndex = 21
        Me.btnAgregarVenta.Text = "Agregar"
        Me.btnAgregarVenta.UseVisualStyleBackColor = False
        '
        'CboListaPrecios
        '
        Me.CboListaPrecios.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboListaPrecios.FormattingEnabled = True
        Me.CboListaPrecios.Location = New System.Drawing.Point(573, 16)
        Me.CboListaPrecios.Name = "CboListaPrecios"
        Me.CboListaPrecios.Size = New System.Drawing.Size(72, 25)
        Me.CboListaPrecios.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(530, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 17)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "Lista:"
        '
        'txtCantidadVentas
        '
        Me.txtCantidadVentas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadVentas.Location = New System.Drawing.Point(458, 16)
        Me.txtCantidadVentas.Name = "txtCantidadVentas"
        Me.txtCantidadVentas.Size = New System.Drawing.Size(66, 23)
        Me.txtCantidadVentas.TabIndex = 19
        Me.txtCantidadVentas.Text = "1"
        Me.txtCantidadVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(377, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 17)
        Me.Label12.TabIndex = 115
        Me.Label12.Text = "Cantidad:"
        '
        'cboProductoVenta
        '
        Me.cboProductoVenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProductoVenta.FormattingEnabled = True
        Me.cboProductoVenta.Location = New System.Drawing.Point(93, 16)
        Me.cboProductoVenta.Name = "cboProductoVenta"
        Me.cboProductoVenta.Size = New System.Drawing.Size(278, 25)
        Me.cboProductoVenta.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Producto:"
        '
        'lblInformacionGeneral
        '
        Me.lblInformacionGeneral.AutoSize = True
        Me.lblInformacionGeneral.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblInformacionGeneral.ForeColor = System.Drawing.Color.White
        Me.lblInformacionGeneral.Location = New System.Drawing.Point(337, 30)
        Me.lblInformacionGeneral.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInformacionGeneral.Name = "lblInformacionGeneral"
        Me.lblInformacionGeneral.Size = New System.Drawing.Size(130, 17)
        Me.lblInformacionGeneral.TabIndex = 116
        Me.lblInformacionGeneral.Text = "Información General"
        '
        'PanelInformacionGeneral
        '
        Me.PanelInformacionGeneral.Controls.Add(Me.dtpFechaCompra)
        Me.PanelInformacionGeneral.Controls.Add(Me.cboPersona)
        Me.PanelInformacionGeneral.Controls.Add(Me.Label2)
        Me.PanelInformacionGeneral.Controls.Add(Me.Label3)
        Me.PanelInformacionGeneral.Controls.Add(Me.Label4)
        Me.PanelInformacionGeneral.Controls.Add(Me.txtNumComprobante)
        Me.PanelInformacionGeneral.Controls.Add(Me.btnAgregarCuenta)
        Me.PanelInformacionGeneral.Controls.Add(Me.Label5)
        Me.PanelInformacionGeneral.Controls.Add(Me.cboFormaPago)
        Me.PanelInformacionGeneral.Controls.Add(Me.btnAgregarFormaPago)
        Me.PanelInformacionGeneral.Controls.Add(Me.chkEstado)
        Me.PanelInformacionGeneral.Location = New System.Drawing.Point(325, 38)
        Me.PanelInformacionGeneral.Name = "PanelInformacionGeneral"
        Me.PanelInformacionGeneral.Size = New System.Drawing.Size(535, 153)
        Me.PanelInformacionGeneral.TabIndex = 117
        '
        'dtpFechaCompra
        '
        Me.dtpFechaCompra.CalendarFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCompra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCompra.Location = New System.Drawing.Point(15, 36)
        Me.dtpFechaCompra.Name = "dtpFechaCompra"
        Me.dtpFechaCompra.Size = New System.Drawing.Size(200, 23)
        Me.dtpFechaCompra.TabIndex = 89
        '
        'PanelTotales
        '
        Me.PanelTotales.Controls.Add(Me.txtTotal)
        Me.PanelTotales.Controls.Add(Me.txtIvaMonto)
        Me.PanelTotales.Controls.Add(Me.txtSubtotal)
        Me.PanelTotales.Location = New System.Drawing.Point(46, 217)
        Me.PanelTotales.Name = "PanelTotales"
        Me.PanelTotales.Size = New System.Drawing.Size(814, 64)
        Me.PanelTotales.TabIndex = 119
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(634, 17)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(139, 28)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.Text = ""
        '
        'txtIvaMonto
        '
        Me.txtIvaMonto.Location = New System.Drawing.Point(336, 17)
        Me.txtIvaMonto.Name = "txtIvaMonto"
        Me.txtIvaMonto.Size = New System.Drawing.Size(139, 28)
        Me.txtIvaMonto.TabIndex = 12
        Me.txtIvaMonto.Text = ""
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(40, 17)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(139, 28)
        Me.txtSubtotal.TabIndex = 11
        Me.txtSubtotal.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(121, 209)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 17)
        Me.Label13.TabIndex = 118
        Me.Label13.Text = "Subtotal"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(416, 209)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 17)
        Me.Label14.TabIndex = 120
        Me.Label14.Text = "IVA monto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(735, 209)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 17)
        Me.Label11.TabIndex = 121
        Me.Label11.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(58, 73)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "Impuestos"
        '
        'PanelImpuestos
        '
        Me.PanelImpuestos.Controls.Add(Me.Label8)
        Me.PanelImpuestos.Controls.Add(Me.Label10)
        Me.PanelImpuestos.Controls.Add(Me.txtIVA)
        Me.PanelImpuestos.Controls.Add(Me.txtOtrosImpuestos)
        Me.PanelImpuestos.Location = New System.Drawing.Point(46, 81)
        Me.PanelImpuestos.Name = "PanelImpuestos"
        Me.PanelImpuestos.Size = New System.Drawing.Size(258, 110)
        Me.PanelImpuestos.TabIndex = 123
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1044, 556)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PanelImpuestos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PanelTotales)
        Me.Controls.Add(Me.lblInformacionGeneral)
        Me.Controls.Add(Me.PanelInformacionGeneral)
        Me.Controls.Add(Me.PanelDetalleDeCompras)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCompras"
        Me.Text = "frmCompras"
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetalleDeCompras.ResumeLayout(False)
        Me.PanelDetalleDeCompras.PerformLayout()
        Me.PanelInformacionGeneral.ResumeLayout(False)
        Me.PanelInformacionGeneral.PerformLayout()
        Me.PanelTotales.ResumeLayout(False)
        Me.PanelImpuestos.ResumeLayout(False)
        Me.PanelImpuestos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents txtOtrosImpuestos As TextBox
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents txtNumComprobante As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents cboFormaPago As ComboBox
    Friend WithEvents cboPersona As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarCuenta As PictureBox
    Friend WithEvents btnAgregarFormaPago As PictureBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents grdCompras As DataGridView
    Friend WithEvents PanelDetalleDeCompras As Panel
    Friend WithEvents btnQuitarVenta As Button
    Friend WithEvents btnAgregarVenta As Button
    Friend WithEvents CboListaPrecios As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCantidadVentas As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboProductoVenta As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblInformacionGeneral As Label
    Friend WithEvents PanelInformacionGeneral As Panel
    Friend WithEvents dtpFechaCompra As DateTimePicker
    Friend WithEvents PanelTotales As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelImpuestos As Panel
    Friend WithEvents txtTotal As RichTextBox
    Friend WithEvents txtIvaMonto As RichTextBox
    Friend WithEvents txtSubtotal As RichTextBox
End Class
