<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.grdVentas = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFormaEntrega = New System.Windows.Forms.ComboBox()
        Me.cboTipoVenta = New System.Windows.Forms.ComboBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cboPersona = New System.Windows.Forms.ComboBox()
        Me.btnAgregarPersona = New System.Windows.Forms.PictureBox()
        Me.btnAgregarEmpleado = New System.Windows.Forms.PictureBox()
        Me.btnAgregarFormaPago = New System.Windows.Forms.PictureBox()
        Me.btnTipoVenta = New System.Windows.Forms.PictureBox()
        Me.btnFormaEntrega = New System.Windows.Forms.PictureBox()
        Me.PanelDetalleDeVentas = New System.Windows.Forms.Panel()
        Me.btnQuitarVenta = New System.Windows.Forms.Button()
        Me.btnAgregarVenta = New System.Windows.Forms.Button()
        Me.CboLote = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCantidadVentas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboProductoVenta = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PanelImpuestos = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtOtrosImpuestos = New System.Windows.Forms.TextBox()
        Me.lblInformacionGeneral = New System.Windows.Forms.Label()
        Me.PanelInformacionGeneral = New System.Windows.Forms.Panel()
        Me.dtpFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.cboEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtNumComprobante = New System.Windows.Forms.TextBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelCliente = New System.Windows.Forms.Panel()
        Me.txtResultadoDocumento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtResultadoTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelFormaPago = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.rbtDescuento = New System.Windows.Forms.RadioButton()
        Me.rbtRecargo = New System.Windows.Forms.RadioButton()
        Me.cboDetalleFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAgregarDetalleFormaPago = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelTotales = New System.Windows.Forms.Panel()
        Me.txtMontoDtoRecargo = New System.Windows.Forms.RichTextBox()
        Me.txtTotal = New System.Windows.Forms.RichTextBox()
        Me.txtIvaMonto = New System.Windows.Forms.RichTextBox()
        Me.txtSubtotal = New System.Windows.Forms.RichTextBox()
        Me.lblMontoDtoRecargo = New System.Windows.Forms.Label()
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTipoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFormaEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetalleDeVentas.SuspendLayout()
        Me.PanelImpuestos.SuspendLayout()
        Me.PanelInformacionGeneral.SuspendLayout()
        Me.PanelCliente.SuspendLayout()
        Me.PanelFormaPago.SuspendLayout()
        CType(Me.btnAgregarDetalleFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTotales.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdVentas
        '
        Me.grdVentas.AllowUserToAddRows = False
        Me.grdVentas.AllowUserToDeleteRows = False
        Me.grdVentas.AllowUserToOrderColumns = True
        Me.grdVentas.AllowUserToResizeRows = False
        Me.grdVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdVentas.Location = New System.Drawing.Point(121, 686)
        Me.grdVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdVentas.Name = "grdVentas"
        Me.grdVentas.ReadOnly = True
        Me.grdVentas.RowHeadersVisible = False
        Me.grdVentas.RowHeadersWidth = 51
        Me.grdVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdVentas.Size = New System.Drawing.Size(1323, 254)
        Me.grdVentas.TabIndex = 95
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(16, 143)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(159, 21)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "Forma de Entrega"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(413, 81)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 21)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Tipo de Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(103, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 21)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "N° Venta"
        '
        'cboFormaEntrega
        '
        Me.cboFormaEntrega.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormaEntrega.FormattingEnabled = True
        Me.cboFormaEntrega.Location = New System.Drawing.Point(20, 169)
        Me.cboFormaEntrega.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboFormaEntrega.Name = "cboFormaEntrega"
        Me.cboFormaEntrega.Size = New System.Drawing.Size(272, 29)
        Me.cboFormaEntrega.TabIndex = 14
        '
        'cboTipoVenta
        '
        Me.cboTipoVenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoVenta.FormattingEnabled = True
        Me.cboTipoVenta.Location = New System.Drawing.Point(417, 107)
        Me.cboTipoVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTipoVenta.Name = "cboTipoVenta"
        Me.cboTipoVenta.Size = New System.Drawing.Size(271, 29)
        Me.cboTipoVenta.TabIndex = 13
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
        Me.btnModificar.Location = New System.Drawing.Point(1307, 249)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(156, 46)
        Me.btnModificar.TabIndex = 16
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
        Me.btnCancelar.Location = New System.Drawing.Point(1307, 444)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(156, 46)
        Me.btnCancelar.TabIndex = 17
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
        Me.btnAceptar.Location = New System.Drawing.Point(1307, 53)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(156, 46)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(273, 63)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(77, 27)
        Me.txtID.TabIndex = 1
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
        Me.btnBuscar.Location = New System.Drawing.Point(384, 58)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(67, 34)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cboPersona
        '
        Me.cboPersona.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPersona.FormattingEnabled = True
        Me.cboPersona.Location = New System.Drawing.Point(15, 48)
        Me.cboPersona.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboPersona.Name = "cboPersona"
        Me.cboPersona.Size = New System.Drawing.Size(272, 29)
        Me.cboPersona.TabIndex = 5
        '
        'btnAgregarPersona
        '
        Me.btnAgregarPersona.BackgroundImage = CType(resources.GetObject("btnAgregarPersona.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarPersona.Location = New System.Drawing.Point(296, 48)
        Me.btnAgregarPersona.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarPersona.Name = "btnAgregarPersona"
        Me.btnAgregarPersona.Size = New System.Drawing.Size(35, 31)
        Me.btnAgregarPersona.TabIndex = 107
        Me.btnAgregarPersona.TabStop = False
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.BackgroundImage = CType(resources.GetObject("btnAgregarEmpleado.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(300, 107)
        Me.btnAgregarEmpleado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(35, 31)
        Me.btnAgregarEmpleado.TabIndex = 108
        Me.btnAgregarEmpleado.TabStop = False
        '
        'btnAgregarFormaPago
        '
        Me.btnAgregarFormaPago.BackgroundImage = CType(resources.GetObject("btnAgregarFormaPago.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarFormaPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarFormaPago.Location = New System.Drawing.Point(277, 49)
        Me.btnAgregarFormaPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarFormaPago.Name = "btnAgregarFormaPago"
        Me.btnAgregarFormaPago.Size = New System.Drawing.Size(35, 31)
        Me.btnAgregarFormaPago.TabIndex = 109
        Me.btnAgregarFormaPago.TabStop = False
        '
        'btnTipoVenta
        '
        Me.btnTipoVenta.BackgroundImage = CType(resources.GetObject("btnTipoVenta.BackgroundImage"), System.Drawing.Image)
        Me.btnTipoVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTipoVenta.Location = New System.Drawing.Point(697, 107)
        Me.btnTipoVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTipoVenta.Name = "btnTipoVenta"
        Me.btnTipoVenta.Size = New System.Drawing.Size(35, 31)
        Me.btnTipoVenta.TabIndex = 110
        Me.btnTipoVenta.TabStop = False
        '
        'btnFormaEntrega
        '
        Me.btnFormaEntrega.BackgroundImage = CType(resources.GetObject("btnFormaEntrega.BackgroundImage"), System.Drawing.Image)
        Me.btnFormaEntrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFormaEntrega.Location = New System.Drawing.Point(300, 169)
        Me.btnFormaEntrega.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFormaEntrega.Name = "btnFormaEntrega"
        Me.btnFormaEntrega.Size = New System.Drawing.Size(35, 31)
        Me.btnFormaEntrega.TabIndex = 111
        Me.btnFormaEntrega.TabStop = False
        '
        'PanelDetalleDeVentas
        '
        Me.PanelDetalleDeVentas.Controls.Add(Me.btnQuitarVenta)
        Me.PanelDetalleDeVentas.Controls.Add(Me.btnAgregarVenta)
        Me.PanelDetalleDeVentas.Controls.Add(Me.CboLote)
        Me.PanelDetalleDeVentas.Controls.Add(Me.Label15)
        Me.PanelDetalleDeVentas.Controls.Add(Me.txtCantidadVentas)
        Me.PanelDetalleDeVentas.Controls.Add(Me.Label12)
        Me.PanelDetalleDeVentas.Controls.Add(Me.cboProductoVenta)
        Me.PanelDetalleDeVentas.Controls.Add(Me.Label10)
        Me.PanelDetalleDeVentas.Location = New System.Drawing.Point(107, 620)
        Me.PanelDetalleDeVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelDetalleDeVentas.Name = "PanelDetalleDeVentas"
        Me.PanelDetalleDeVentas.Size = New System.Drawing.Size(1356, 331)
        Me.PanelDetalleDeVentas.TabIndex = 112
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
        Me.btnQuitarVenta.Location = New System.Drawing.Point(1183, 12)
        Me.btnQuitarVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnQuitarVenta.Name = "btnQuitarVenta"
        Me.btnQuitarVenta.Size = New System.Drawing.Size(156, 46)
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
        Me.btnAgregarVenta.Location = New System.Drawing.Point(1012, 12)
        Me.btnAgregarVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarVenta.Name = "btnAgregarVenta"
        Me.btnAgregarVenta.Size = New System.Drawing.Size(156, 46)
        Me.btnAgregarVenta.TabIndex = 21
        Me.btnAgregarVenta.Text = "Agregar"
        Me.btnAgregarVenta.UseVisualStyleBackColor = False
        '
        'CboLote
        '
        Me.CboLote.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLote.FormattingEnabled = True
        Me.CboLote.Location = New System.Drawing.Point(764, 20)
        Me.CboLote.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboLote.Name = "CboLote"
        Me.CboLote.Size = New System.Drawing.Size(239, 29)
        Me.CboLote.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(707, 25)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 21)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "Lote:"
        '
        'txtCantidadVentas
        '
        Me.txtCantidadVentas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadVentas.Location = New System.Drawing.Point(611, 20)
        Me.txtCantidadVentas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCantidadVentas.Name = "txtCantidadVentas"
        Me.txtCantidadVentas.Size = New System.Drawing.Size(87, 27)
        Me.txtCantidadVentas.TabIndex = 19
        Me.txtCantidadVentas.Text = "1"
        Me.txtCantidadVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(503, 25)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 21)
        Me.Label12.TabIndex = 115
        Me.Label12.Text = "Cantidad:"
        '
        'cboProductoVenta
        '
        Me.cboProductoVenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProductoVenta.FormattingEnabled = True
        Me.cboProductoVenta.Location = New System.Drawing.Point(124, 20)
        Me.cboProductoVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboProductoVenta.Name = "cboProductoVenta"
        Me.cboProductoVenta.Size = New System.Drawing.Size(369, 29)
        Me.cboProductoVenta.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(20, 25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 21)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Producto:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(123, 345)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 20)
        Me.Label16.TabIndex = 129
        Me.Label16.Text = "Impuestos"
        '
        'PanelImpuestos
        '
        Me.PanelImpuestos.Controls.Add(Me.Label17)
        Me.PanelImpuestos.Controls.Add(Me.Label18)
        Me.PanelImpuestos.Controls.Add(Me.txtIVA)
        Me.PanelImpuestos.Controls.Add(Me.txtOtrosImpuestos)
        Me.PanelImpuestos.Location = New System.Drawing.Point(107, 354)
        Me.PanelImpuestos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelImpuestos.Name = "PanelImpuestos"
        Me.PanelImpuestos.Size = New System.Drawing.Size(344, 135)
        Me.PanelImpuestos.TabIndex = 130
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(11, 34)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 21)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "IVA %"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(7, 79)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(143, 21)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Otros impuestos"
        '
        'txtIVA
        '
        Me.txtIVA.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVA.Location = New System.Drawing.Point(167, 31)
        Me.txtIVA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIVA.Size = New System.Drawing.Size(163, 27)
        Me.txtIVA.TabIndex = 8
        Me.txtIVA.Text = "21"
        '
        'txtOtrosImpuestos
        '
        Me.txtOtrosImpuestos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtrosImpuestos.Location = New System.Drawing.Point(167, 75)
        Me.txtOtrosImpuestos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOtrosImpuestos.Name = "txtOtrosImpuestos"
        Me.txtOtrosImpuestos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtOtrosImpuestos.Size = New System.Drawing.Size(163, 27)
        Me.txtOtrosImpuestos.TabIndex = 10
        Me.txtOtrosImpuestos.Text = "0"
        '
        'lblInformacionGeneral
        '
        Me.lblInformacionGeneral.AutoSize = True
        Me.lblInformacionGeneral.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblInformacionGeneral.ForeColor = System.Drawing.Color.White
        Me.lblInformacionGeneral.Location = New System.Drawing.Point(495, 43)
        Me.lblInformacionGeneral.Name = "lblInformacionGeneral"
        Me.lblInformacionGeneral.Size = New System.Drawing.Size(162, 20)
        Me.lblInformacionGeneral.TabIndex = 127
        Me.lblInformacionGeneral.Text = "Información General"
        '
        'PanelInformacionGeneral
        '
        Me.PanelInformacionGeneral.Controls.Add(Me.dtpFechaVenta)
        Me.PanelInformacionGeneral.Controls.Add(Me.cboEmpleado)
        Me.PanelInformacionGeneral.Controls.Add(Me.Label19)
        Me.PanelInformacionGeneral.Controls.Add(Me.Label20)
        Me.PanelInformacionGeneral.Controls.Add(Me.Label21)
        Me.PanelInformacionGeneral.Controls.Add(Me.btnTipoVenta)
        Me.PanelInformacionGeneral.Controls.Add(Me.btnFormaEntrega)
        Me.PanelInformacionGeneral.Controls.Add(Me.txtNumComprobante)
        Me.PanelInformacionGeneral.Controls.Add(Me.btnAgregarEmpleado)
        Me.PanelInformacionGeneral.Controls.Add(Me.chkEstado)
        Me.PanelInformacionGeneral.Controls.Add(Me.cboTipoVenta)
        Me.PanelInformacionGeneral.Controls.Add(Me.Label13)
        Me.PanelInformacionGeneral.Controls.Add(Me.Label14)
        Me.PanelInformacionGeneral.Controls.Add(Me.cboFormaEntrega)
        Me.PanelInformacionGeneral.Location = New System.Drawing.Point(479, 53)
        Me.PanelInformacionGeneral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelInformacionGeneral.Name = "PanelInformacionGeneral"
        Me.PanelInformacionGeneral.Size = New System.Drawing.Size(796, 228)
        Me.PanelInformacionGeneral.TabIndex = 128
        '
        'dtpFechaVenta
        '
        Me.dtpFechaVenta.CalendarFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaVenta.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaVenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaVenta.Location = New System.Drawing.Point(20, 48)
        Me.dtpFechaVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaVenta.Name = "dtpFechaVenta"
        Me.dtpFechaVenta.Size = New System.Drawing.Size(313, 27)
        Me.dtpFechaVenta.TabIndex = 89
        '
        'cboEmpleado
        '
        Me.cboEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpleado.FormattingEnabled = True
        Me.cboEmpleado.Location = New System.Drawing.Point(20, 107)
        Me.cboEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(272, 29)
        Me.cboEmpleado.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(15, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(146, 21)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Fecha de venta"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(413, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(155, 21)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "N° Comprobante"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(16, 81)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 21)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Vendedor"
        '
        'txtNumComprobante
        '
        Me.txtNumComprobante.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumComprobante.Location = New System.Drawing.Point(417, 48)
        Me.txtNumComprobante.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumComprobante.Name = "txtNumComprobante"
        Me.txtNumComprobante.Size = New System.Drawing.Size(313, 27)
        Me.txtNumComprobante.TabIndex = 4
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(419, 159)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(108, 25)
        Me.chkEstado.TabIndex = 12
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(15, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(205, 21)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "Tipo de Forma de Pago"
        '
        'cboFormaPago
        '
        Me.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormaPago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormaPago.FormattingEnabled = True
        Me.cboFormaPago.Location = New System.Drawing.Point(19, 49)
        Me.cboFormaPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Size = New System.Drawing.Size(251, 29)
        Me.cboFormaPago.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(123, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "Cliente"
        '
        'PanelCliente
        '
        Me.PanelCliente.Controls.Add(Me.txtResultadoDocumento)
        Me.PanelCliente.Controls.Add(Me.Label5)
        Me.PanelCliente.Controls.Add(Me.txtResultadoTelefono)
        Me.PanelCliente.Controls.Add(Me.Label4)
        Me.PanelCliente.Controls.Add(Me.Label3)
        Me.PanelCliente.Controls.Add(Me.cboPersona)
        Me.PanelCliente.Controls.Add(Me.btnAgregarPersona)
        Me.PanelCliente.Location = New System.Drawing.Point(107, 117)
        Me.PanelCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelCliente.Name = "PanelCliente"
        Me.PanelCliente.Size = New System.Drawing.Size(344, 217)
        Me.PanelCliente.TabIndex = 132
        '
        'txtResultadoDocumento
        '
        Me.txtResultadoDocumento.Enabled = False
        Me.txtResultadoDocumento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultadoDocumento.Location = New System.Drawing.Point(15, 169)
        Me.txtResultadoDocumento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtResultadoDocumento.Name = "txtResultadoDocumento"
        Me.txtResultadoDocumento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtResultadoDocumento.Size = New System.Drawing.Size(315, 27)
        Me.txtResultadoDocumento.TabIndex = 135
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Documento"
        '
        'txtResultadoTelefono
        '
        Me.txtResultadoTelefono.Enabled = False
        Me.txtResultadoTelefono.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultadoTelefono.Location = New System.Drawing.Point(15, 110)
        Me.txtResultadoTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtResultadoTelefono.Name = "txtResultadoTelefono"
        Me.txtResultadoTelefono.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtResultadoTelefono.Size = New System.Drawing.Size(315, 27)
        Me.txtResultadoTelefono.TabIndex = 133
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(495, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 20)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Forma de pago"
        '
        'PanelFormaPago
        '
        Me.PanelFormaPago.Controls.Add(Me.Label23)
        Me.PanelFormaPago.Controls.Add(Me.TextBox1)
        Me.PanelFormaPago.Controls.Add(Me.rbtDescuento)
        Me.PanelFormaPago.Controls.Add(Me.rbtRecargo)
        Me.PanelFormaPago.Controls.Add(Me.cboDetalleFormaPago)
        Me.PanelFormaPago.Controls.Add(Me.Label7)
        Me.PanelFormaPago.Controls.Add(Me.btnAgregarDetalleFormaPago)
        Me.PanelFormaPago.Controls.Add(Me.cboFormaPago)
        Me.PanelFormaPago.Controls.Add(Me.Label22)
        Me.PanelFormaPago.Controls.Add(Me.btnAgregarFormaPago)
        Me.PanelFormaPago.Location = New System.Drawing.Point(479, 303)
        Me.PanelFormaPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelFormaPago.Name = "PanelFormaPago"
        Me.PanelFormaPago.Size = New System.Drawing.Size(796, 187)
        Me.PanelFormaPago.TabIndex = 134
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(415, 98)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 21)
        Me.Label23.TabIndex = 115
        Me.Label23.Text = "Monto %"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(417, 124)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(292, 27)
        Me.TextBox1.TabIndex = 33
        Me.TextBox1.Text = "0"
        '
        'rbtDescuento
        '
        Me.rbtDescuento.AutoSize = True
        Me.rbtDescuento.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.rbtDescuento.ForeColor = System.Drawing.Color.White
        Me.rbtDescuento.Location = New System.Drawing.Point(185, 123)
        Me.rbtDescuento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtDescuento.Name = "rbtDescuento"
        Me.rbtDescuento.Size = New System.Drawing.Size(122, 25)
        Me.rbtDescuento.TabIndex = 114
        Me.rbtDescuento.TabStop = True
        Me.rbtDescuento.Text = "Descuento"
        Me.rbtDescuento.UseVisualStyleBackColor = True
        '
        'rbtRecargo
        '
        Me.rbtRecargo.AutoSize = True
        Me.rbtRecargo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.rbtRecargo.ForeColor = System.Drawing.Color.White
        Me.rbtRecargo.Location = New System.Drawing.Point(19, 123)
        Me.rbtRecargo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbtRecargo.Name = "rbtRecargo"
        Me.rbtRecargo.Size = New System.Drawing.Size(102, 25)
        Me.rbtRecargo.TabIndex = 113
        Me.rbtRecargo.TabStop = True
        Me.rbtRecargo.Text = "Recargo"
        Me.rbtRecargo.UseVisualStyleBackColor = True
        '
        'cboDetalleFormaPago
        '
        Me.cboDetalleFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDetalleFormaPago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDetalleFormaPago.FormattingEnabled = True
        Me.cboDetalleFormaPago.Location = New System.Drawing.Point(417, 49)
        Me.cboDetalleFormaPago.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboDetalleFormaPago.Name = "cboDetalleFormaPago"
        Me.cboDetalleFormaPago.Size = New System.Drawing.Size(251, 29)
        Me.cboDetalleFormaPago.TabIndex = 110
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(413, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 21)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Nombre"
        '
        'btnAgregarDetalleFormaPago
        '
        Me.btnAgregarDetalleFormaPago.BackgroundImage = CType(resources.GetObject("btnAgregarDetalleFormaPago.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarDetalleFormaPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarDetalleFormaPago.Location = New System.Drawing.Point(676, 49)
        Me.btnAgregarDetalleFormaPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarDetalleFormaPago.Name = "btnAgregarDetalleFormaPago"
        Me.btnAgregarDetalleFormaPago.Size = New System.Drawing.Size(35, 31)
        Me.btnAgregarDetalleFormaPago.TabIndex = 112
        Me.btnAgregarDetalleFormaPago.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1124, 508)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 20)
        Me.Label11.TabIndex = 142
        Me.Label11.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(504, 508)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 20)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "IVA monto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(207, 508)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 139
        Me.Label9.Text = "Subtotal"
        '
        'PanelTotales
        '
        Me.PanelTotales.Controls.Add(Me.txtMontoDtoRecargo)
        Me.PanelTotales.Controls.Add(Me.txtTotal)
        Me.PanelTotales.Controls.Add(Me.txtIvaMonto)
        Me.PanelTotales.Controls.Add(Me.txtSubtotal)
        Me.PanelTotales.Location = New System.Drawing.Point(107, 518)
        Me.PanelTotales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelTotales.Name = "PanelTotales"
        Me.PanelTotales.Size = New System.Drawing.Size(1168, 79)
        Me.PanelTotales.TabIndex = 140
        '
        'txtMontoDtoRecargo
        '
        Me.txtMontoDtoRecargo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoDtoRecargo.Location = New System.Drawing.Point(651, 21)
        Me.txtMontoDtoRecargo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMontoDtoRecargo.Name = "txtMontoDtoRecargo"
        Me.txtMontoDtoRecargo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMontoDtoRecargo.Size = New System.Drawing.Size(184, 34)
        Me.txtMontoDtoRecargo.TabIndex = 14
        Me.txtMontoDtoRecargo.Text = "0"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(949, 21)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(184, 34)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.Text = "0"
        '
        'txtIvaMonto
        '
        Me.txtIvaMonto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIvaMonto.Location = New System.Drawing.Point(352, 21)
        Me.txtIvaMonto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIvaMonto.Name = "txtIvaMonto"
        Me.txtIvaMonto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIvaMonto.Size = New System.Drawing.Size(184, 34)
        Me.txtIvaMonto.TabIndex = 12
        Me.txtIvaMonto.Text = "0"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(53, 21)
        Me.txtSubtotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubtotal.Size = New System.Drawing.Size(184, 34)
        Me.txtSubtotal.TabIndex = 11
        Me.txtSubtotal.Text = "0"
        '
        'lblMontoDtoRecargo
        '
        Me.lblMontoDtoRecargo.AutoSize = True
        Me.lblMontoDtoRecargo.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblMontoDtoRecargo.ForeColor = System.Drawing.Color.White
        Me.lblMontoDtoRecargo.Location = New System.Drawing.Point(817, 508)
        Me.lblMontoDtoRecargo.Name = "lblMontoDtoRecargo"
        Me.lblMontoDtoRecargo.Size = New System.Drawing.Size(62, 20)
        Me.lblMontoDtoRecargo.TabIndex = 143
        Me.lblMontoDtoRecargo.Text = "Monto "
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1529, 977)
        Me.Controls.Add(Me.lblMontoDtoRecargo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PanelTotales)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PanelFormaPago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelCliente)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PanelImpuestos)
        Me.Controls.Add(Me.lblInformacionGeneral)
        Me.Controls.Add(Me.PanelInformacionGeneral)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.grdVentas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelDetalleDeVentas)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTipoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFormaEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetalleDeVentas.ResumeLayout(False)
        Me.PanelDetalleDeVentas.PerformLayout()
        Me.PanelImpuestos.ResumeLayout(False)
        Me.PanelImpuestos.PerformLayout()
        Me.PanelInformacionGeneral.ResumeLayout(False)
        Me.PanelInformacionGeneral.PerformLayout()
        Me.PanelCliente.ResumeLayout(False)
        Me.PanelCliente.PerformLayout()
        Me.PanelFormaPago.ResumeLayout(False)
        Me.PanelFormaPago.PerformLayout()
        CType(Me.btnAgregarDetalleFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTotales.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdVentas As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboFormaEntrega As ComboBox
    Friend WithEvents cboTipoVenta As ComboBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents cboPersona As ComboBox
    Friend WithEvents btnAgregarPersona As PictureBox
    Friend WithEvents btnAgregarEmpleado As PictureBox
    Friend WithEvents btnAgregarFormaPago As PictureBox
    Friend WithEvents btnTipoVenta As PictureBox
    Friend WithEvents btnFormaEntrega As PictureBox
    Friend WithEvents PanelDetalleDeVentas As Panel
    Friend WithEvents btnQuitarVenta As Button
    Friend WithEvents btnAgregarVenta As Button
    Friend WithEvents CboLote As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCantidadVentas As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboProductoVenta As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PanelImpuestos As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents txtOtrosImpuestos As TextBox
    Friend WithEvents lblInformacionGeneral As Label
    Friend WithEvents PanelInformacionGeneral As Panel
    Friend WithEvents dtpFechaVenta As DateTimePicker
    Friend WithEvents cboEmpleado As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtNumComprobante As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cboFormaPago As ComboBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelCliente As Panel
    Friend WithEvents txtResultadoDocumento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtResultadoTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelFormaPago As Panel
    Friend WithEvents cboDetalleFormaPago As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAgregarDetalleFormaPago As PictureBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents rbtDescuento As RadioButton
    Friend WithEvents rbtRecargo As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelTotales As Panel
    Friend WithEvents txtMontoDtoRecargo As RichTextBox
    Friend WithEvents txtTotal As RichTextBox
    Friend WithEvents txtIvaMonto As RichTextBox
    Friend WithEvents txtSubtotal As RichTextBox
    Friend WithEvents lblMontoDtoRecargo As Label
End Class
