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
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOtrosImpuestos = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumComprobante = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboVendedor = New System.Windows.Forms.ComboBox()
        Me.cboFormaPago = New System.Windows.Forms.ComboBox()
        Me.cboFormaEntrega = New System.Windows.Forms.ComboBox()
        Me.cboTipoVenta = New System.Windows.Forms.ComboBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtFechaVenta = New System.Windows.Forms.TextBox()
        Me.cboCuenta = New System.Windows.Forms.ComboBox()
        Me.btnAgregarCuenta = New System.Windows.Forms.PictureBox()
        Me.btnAgregarEmpleado = New System.Windows.Forms.PictureBox()
        Me.btnAgregarFormaPago = New System.Windows.Forms.PictureBox()
        Me.btnTipoVenta = New System.Windows.Forms.PictureBox()
        Me.btnFormaEntrega = New System.Windows.Forms.PictureBox()
        Me.PanelDetalleDeVentas = New System.Windows.Forms.Panel()
        Me.btnQuitarVenta = New System.Windows.Forms.Button()
        Me.btnAgregarVenta = New System.Windows.Forms.Button()
        Me.CboListaPrecios = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCantidadVentas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboProductoVenta = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTipoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFormaEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetalleDeVentas.SuspendLayout()
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
        Me.grdVentas.Location = New System.Drawing.Point(36, 458)
        Me.grdVentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdVentas.Name = "grdVentas"
        Me.grdVentas.ReadOnly = True
        Me.grdVentas.RowHeadersVisible = False
        Me.grdVentas.RowHeadersWidth = 51
        Me.grdVentas.Size = New System.Drawing.Size(1332, 402)
        Me.grdVentas.TabIndex = 95
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(150, 317)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(85, 21)
        Me.chkEstado.TabIndex = 8
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(654, 280)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 17)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "Forma de Entrega"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(658, 238)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 17)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Tipo de Venta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(658, 198)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 17)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(658, 78)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Subtotal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(658, 118)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 17)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "IVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(658, 158)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 17)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Otros Impuestos"
        '
        'txtOtrosImpuestos
        '
        Me.txtOtrosImpuestos.Location = New System.Drawing.Point(884, 157)
        Me.txtOtrosImpuestos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOtrosImpuestos.Name = "txtOtrosImpuestos"
        Me.txtOtrosImpuestos.Size = New System.Drawing.Size(180, 26)
        Me.txtOtrosImpuestos.TabIndex = 11
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(884, 197)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(180, 26)
        Me.txtTotal.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(147, 240)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Vendedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(146, 198)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Cuenta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(147, 282)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Forma de Pago"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(884, 77)
        Me.txtSubtotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(180, 26)
        Me.txtSubtotal.TabIndex = 9
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(884, 117)
        Me.txtIVA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(180, 26)
        Me.txtIVA.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(146, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 17)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Nro. Comprobante"
        '
        'txtNumComprobante
        '
        Me.txtNumComprobante.Location = New System.Drawing.Point(376, 154)
        Me.txtNumComprobante.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumComprobante.Name = "txtNumComprobante"
        Me.txtNumComprobante.Size = New System.Drawing.Size(180, 26)
        Me.txtNumComprobante.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(146, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Fecha Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(146, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "ID"
        '
        'cboVendedor
        '
        Me.cboVendedor.FormattingEnabled = True
        Me.cboVendedor.Location = New System.Drawing.Point(376, 237)
        Me.cboVendedor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Size = New System.Drawing.Size(180, 28)
        Me.cboVendedor.TabIndex = 6
        '
        'cboFormaPago
        '
        Me.cboFormaPago.FormattingEnabled = True
        Me.cboFormaPago.Location = New System.Drawing.Point(376, 282)
        Me.cboFormaPago.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Size = New System.Drawing.Size(180, 28)
        Me.cboFormaPago.TabIndex = 7
        '
        'cboFormaEntrega
        '
        Me.cboFormaEntrega.FormattingEnabled = True
        Me.cboFormaEntrega.Location = New System.Drawing.Point(884, 278)
        Me.cboFormaEntrega.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboFormaEntrega.Name = "cboFormaEntrega"
        Me.cboFormaEntrega.Size = New System.Drawing.Size(180, 28)
        Me.cboFormaEntrega.TabIndex = 14
        '
        'cboTipoVenta
        '
        Me.cboTipoVenta.FormattingEnabled = True
        Me.cboTipoVenta.Location = New System.Drawing.Point(884, 237)
        Me.cboTipoVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboTipoVenta.Name = "cboTipoVenta"
        Me.cboTipoVenta.Size = New System.Drawing.Size(180, 28)
        Me.cboTipoVenta.TabIndex = 13
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatAppearance.BorderSize = 2
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(1167, 180)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(176, 57)
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
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(1167, 282)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(176, 57)
        Me.btnCancelar.TabIndex = 17
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAceptar.FlatAppearance.BorderSize = 2
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(1167, 83)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(176, 57)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(376, 72)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(67, 26)
        Me.txtID.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnBuscar.FlatAppearance.BorderSize = 2
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(483, 60)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 43)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtFechaVenta
        '
        Me.txtFechaVenta.Location = New System.Drawing.Point(376, 114)
        Me.txtFechaVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFechaVenta.Name = "txtFechaVenta"
        Me.txtFechaVenta.Size = New System.Drawing.Size(180, 26)
        Me.txtFechaVenta.TabIndex = 3
        '
        'cboCuenta
        '
        Me.cboCuenta.FormattingEnabled = True
        Me.cboCuenta.Location = New System.Drawing.Point(376, 194)
        Me.cboCuenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(180, 28)
        Me.cboCuenta.TabIndex = 5
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.BackgroundImage = CType(resources.GetObject("btnAgregarCuenta.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(567, 194)
        Me.btnAgregarCuenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(39, 32)
        Me.btnAgregarCuenta.TabIndex = 107
        Me.btnAgregarCuenta.TabStop = False
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.BackgroundImage = CType(resources.GetObject("btnAgregarEmpleado.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(567, 237)
        Me.btnAgregarEmpleado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(39, 32)
        Me.btnAgregarEmpleado.TabIndex = 108
        Me.btnAgregarEmpleado.TabStop = False
        '
        'btnAgregarFormaPago
        '
        Me.btnAgregarFormaPago.BackgroundImage = CType(resources.GetObject("btnAgregarFormaPago.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarFormaPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarFormaPago.Location = New System.Drawing.Point(567, 282)
        Me.btnAgregarFormaPago.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarFormaPago.Name = "btnAgregarFormaPago"
        Me.btnAgregarFormaPago.Size = New System.Drawing.Size(39, 32)
        Me.btnAgregarFormaPago.TabIndex = 109
        Me.btnAgregarFormaPago.TabStop = False
        '
        'btnTipoVenta
        '
        Me.btnTipoVenta.BackgroundImage = CType(resources.GetObject("btnTipoVenta.BackgroundImage"), System.Drawing.Image)
        Me.btnTipoVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTipoVenta.Location = New System.Drawing.Point(1074, 237)
        Me.btnTipoVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTipoVenta.Name = "btnTipoVenta"
        Me.btnTipoVenta.Size = New System.Drawing.Size(39, 32)
        Me.btnTipoVenta.TabIndex = 110
        Me.btnTipoVenta.TabStop = False
        '
        'btnFormaEntrega
        '
        Me.btnFormaEntrega.BackgroundImage = CType(resources.GetObject("btnFormaEntrega.BackgroundImage"), System.Drawing.Image)
        Me.btnFormaEntrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFormaEntrega.Location = New System.Drawing.Point(1074, 278)
        Me.btnFormaEntrega.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFormaEntrega.Name = "btnFormaEntrega"
        Me.btnFormaEntrega.Size = New System.Drawing.Size(39, 32)
        Me.btnFormaEntrega.TabIndex = 111
        Me.btnFormaEntrega.TabStop = False
        '
        'PanelDetalleDeVentas
        '
        Me.PanelDetalleDeVentas.Controls.Add(Me.btnQuitarVenta)
        Me.PanelDetalleDeVentas.Controls.Add(Me.btnAgregarVenta)
        Me.PanelDetalleDeVentas.Controls.Add(Me.CboListaPrecios)
        Me.PanelDetalleDeVentas.Controls.Add(Me.Label15)
        Me.PanelDetalleDeVentas.Controls.Add(Me.txtCantidadVentas)
        Me.PanelDetalleDeVentas.Controls.Add(Me.Label12)
        Me.PanelDetalleDeVentas.Controls.Add(Me.cboProductoVenta)
        Me.PanelDetalleDeVentas.Controls.Add(Me.Label10)
        Me.PanelDetalleDeVentas.Location = New System.Drawing.Point(20, 377)
        Me.PanelDetalleDeVentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelDetalleDeVentas.Name = "PanelDetalleDeVentas"
        Me.PanelDetalleDeVentas.Size = New System.Drawing.Size(1371, 498)
        Me.PanelDetalleDeVentas.TabIndex = 112
        '
        'btnQuitarVenta
        '
        Me.btnQuitarVenta.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitarVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitarVenta.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnQuitarVenta.FlatAppearance.BorderSize = 2
        Me.btnQuitarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnQuitarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarVenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarVenta.ForeColor = System.Drawing.Color.White
        Me.btnQuitarVenta.Location = New System.Drawing.Point(1173, 15)
        Me.btnQuitarVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuitarVenta.Name = "btnQuitarVenta"
        Me.btnQuitarVenta.Size = New System.Drawing.Size(176, 57)
        Me.btnQuitarVenta.TabIndex = 113
        Me.btnQuitarVenta.Text = "Quitar"
        Me.btnQuitarVenta.UseVisualStyleBackColor = False
        '
        'btnAgregarVenta
        '
        Me.btnAgregarVenta.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarVenta.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAgregarVenta.FlatAppearance.BorderSize = 2
        Me.btnAgregarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarVenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarVenta.ForeColor = System.Drawing.Color.White
        Me.btnAgregarVenta.Location = New System.Drawing.Point(981, 15)
        Me.btnAgregarVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarVenta.Name = "btnAgregarVenta"
        Me.btnAgregarVenta.Size = New System.Drawing.Size(176, 57)
        Me.btnAgregarVenta.TabIndex = 113
        Me.btnAgregarVenta.Text = "Agregar"
        Me.btnAgregarVenta.UseVisualStyleBackColor = False
        '
        'CboListaPrecios
        '
        Me.CboListaPrecios.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboListaPrecios.FormattingEnabled = True
        Me.CboListaPrecios.Location = New System.Drawing.Point(860, 25)
        Me.CboListaPrecios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CboListaPrecios.Name = "CboListaPrecios"
        Me.CboListaPrecios.Size = New System.Drawing.Size(106, 25)
        Me.CboListaPrecios.TabIndex = 117
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(795, 31)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 17)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "Lista:"
        '
        'txtCantidadVentas
        '
        Me.txtCantidadVentas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadVentas.Location = New System.Drawing.Point(687, 25)
        Me.txtCantidadVentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCantidadVentas.Name = "txtCantidadVentas"
        Me.txtCantidadVentas.Size = New System.Drawing.Size(97, 23)
        Me.txtCantidadVentas.TabIndex = 113
        Me.txtCantidadVentas.Text = "1"
        Me.txtCantidadVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(566, 31)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 17)
        Me.Label12.TabIndex = 115
        Me.Label12.Text = "Cantidad:"
        '
        'cboProductoVenta
        '
        Me.cboProductoVenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProductoVenta.FormattingEnabled = True
        Me.cboProductoVenta.Location = New System.Drawing.Point(140, 25)
        Me.cboProductoVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboProductoVenta.Name = "cboProductoVenta"
        Me.cboProductoVenta.Size = New System.Drawing.Size(415, 25)
        Me.cboProductoVenta.TabIndex = 114
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(22, 31)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 17)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Producto:"
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1408, 894)
        Me.Controls.Add(Me.btnFormaEntrega)
        Me.Controls.Add(Me.btnTipoVenta)
        Me.Controls.Add(Me.btnAgregarFormaPago)
        Me.Controls.Add(Me.btnAgregarEmpleado)
        Me.Controls.Add(Me.btnAgregarCuenta)
        Me.Controls.Add(Me.cboCuenta)
        Me.Controls.Add(Me.txtFechaVenta)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.grdVentas)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtOtrosImpuestos)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumComprobante)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboVendedor)
        Me.Controls.Add(Me.cboFormaPago)
        Me.Controls.Add(Me.cboFormaEntrega)
        Me.Controls.Add(Me.cboTipoVenta)
        Me.Controls.Add(Me.PanelDetalleDeVentas)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTipoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFormaEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetalleDeVentas.ResumeLayout(False)
        Me.PanelDetalleDeVentas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdVentas As DataGridView
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOtrosImpuestos As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtIVA As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumComprobante As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboVendedor As ComboBox
    Friend WithEvents cboFormaPago As ComboBox
    Friend WithEvents cboFormaEntrega As ComboBox
    Friend WithEvents cboTipoVenta As ComboBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtFechaVenta As TextBox
    Friend WithEvents cboCuenta As ComboBox
    Friend WithEvents btnAgregarCuenta As PictureBox
    Friend WithEvents btnAgregarEmpleado As PictureBox
    Friend WithEvents btnAgregarFormaPago As PictureBox
    Friend WithEvents btnTipoVenta As PictureBox
    Friend WithEvents btnFormaEntrega As PictureBox
    Friend WithEvents PanelDetalleDeVentas As Panel
    Friend WithEvents btnQuitarVenta As Button
    Friend WithEvents btnAgregarVenta As Button
    Friend WithEvents CboListaPrecios As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCantidadVentas As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboProductoVenta As ComboBox
    Friend WithEvents Label10 As Label
End Class
