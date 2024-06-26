<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Me.cboEmpleado = New System.Windows.Forms.ComboBox()
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
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTipoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFormaEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdVentas
        '
        Me.grdVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdVentas.Location = New System.Drawing.Point(55, 304)
        Me.grdVentas.Name = "grdVentas"
        Me.grdVentas.ReadOnly = True
        Me.grdVentas.Size = New System.Drawing.Size(830, 246)
        Me.grdVentas.TabIndex = 95
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(100, 206)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(85, 21)
        Me.chkEstado.TabIndex = 93
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(436, 182)
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
        Me.Label13.Location = New System.Drawing.Point(439, 155)
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
        Me.Label11.Location = New System.Drawing.Point(439, 129)
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
        Me.Label9.Location = New System.Drawing.Point(439, 51)
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
        Me.Label8.Location = New System.Drawing.Point(439, 77)
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
        Me.Label7.Location = New System.Drawing.Point(439, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 17)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Otros Impuestos"
        '
        'txtOtrosImpuestos
        '
        Me.txtOtrosImpuestos.Location = New System.Drawing.Point(589, 102)
        Me.txtOtrosImpuestos.Name = "txtOtrosImpuestos"
        Me.txtOtrosImpuestos.Size = New System.Drawing.Size(121, 20)
        Me.txtOtrosImpuestos.TabIndex = 86
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(589, 128)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(121, 20)
        Me.txtTotal.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(98, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Empleado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(97, 129)
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
        Me.Label4.Location = New System.Drawing.Point(98, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Forma de Pago"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(589, 50)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(121, 20)
        Me.txtSubtotal.TabIndex = 80
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(589, 76)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(121, 20)
        Me.txtIVA.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(97, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 17)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Nro. Comprobante"
        '
        'txtNumComprobante
        '
        Me.txtNumComprobante.Location = New System.Drawing.Point(251, 100)
        Me.txtNumComprobante.Name = "txtNumComprobante"
        Me.txtNumComprobante.Size = New System.Drawing.Size(121, 20)
        Me.txtNumComprobante.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(97, 77)
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
        Me.Label1.Location = New System.Drawing.Point(97, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "ID"
        '
        'cboEmpleado
        '
        Me.cboEmpleado.FormattingEnabled = True
        Me.cboEmpleado.Location = New System.Drawing.Point(251, 154)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.cboEmpleado.TabIndex = 74
        '
        'cboFormaPago
        '
        Me.cboFormaPago.FormattingEnabled = True
        Me.cboFormaPago.Location = New System.Drawing.Point(251, 183)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Size = New System.Drawing.Size(121, 21)
        Me.cboFormaPago.TabIndex = 72
        '
        'cboFormaEntrega
        '
        Me.cboFormaEntrega.FormattingEnabled = True
        Me.cboFormaEntrega.Location = New System.Drawing.Point(589, 181)
        Me.cboFormaEntrega.Name = "cboFormaEntrega"
        Me.cboFormaEntrega.Size = New System.Drawing.Size(121, 21)
        Me.cboFormaEntrega.TabIndex = 71
        '
        'cboTipoVenta
        '
        Me.cboTipoVenta.FormattingEnabled = True
        Me.cboTipoVenta.Location = New System.Drawing.Point(589, 154)
        Me.cboTipoVenta.Name = "cboTipoVenta"
        Me.cboTipoVenta.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoVenta.TabIndex = 70
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
        Me.btnModificar.Location = New System.Drawing.Point(778, 117)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(117, 37)
        Me.btnModificar.TabIndex = 102
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
        Me.btnCancelar.Location = New System.Drawing.Point(775, 180)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 37)
        Me.btnCancelar.TabIndex = 101
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
        Me.btnAceptar.Location = New System.Drawing.Point(778, 54)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 37)
        Me.btnAceptar.TabIndex = 100
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(251, 47)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(46, 20)
        Me.txtID.TabIndex = 103
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
        Me.btnBuscar.Location = New System.Drawing.Point(322, 39)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 28)
        Me.btnBuscar.TabIndex = 104
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtFechaVenta
        '
        Me.txtFechaVenta.Location = New System.Drawing.Point(251, 74)
        Me.txtFechaVenta.Name = "txtFechaVenta"
        Me.txtFechaVenta.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaVenta.TabIndex = 105
        '
        'cboCuenta
        '
        Me.cboCuenta.FormattingEnabled = True
        Me.cboCuenta.Location = New System.Drawing.Point(251, 126)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(121, 21)
        Me.cboCuenta.TabIndex = 106
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.BackgroundImage = CType(resources.GetObject("btnAgregarCuenta.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(378, 126)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(26, 21)
        Me.btnAgregarCuenta.TabIndex = 107
        Me.btnAgregarCuenta.TabStop = False
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.BackgroundImage = CType(resources.GetObject("btnAgregarEmpleado.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(378, 154)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(26, 21)
        Me.btnAgregarEmpleado.TabIndex = 108
        Me.btnAgregarEmpleado.TabStop = False
        '
        'btnAgregarFormaPago
        '
        Me.btnAgregarFormaPago.BackgroundImage = CType(resources.GetObject("btnAgregarFormaPago.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarFormaPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarFormaPago.Location = New System.Drawing.Point(378, 183)
        Me.btnAgregarFormaPago.Name = "btnAgregarFormaPago"
        Me.btnAgregarFormaPago.Size = New System.Drawing.Size(26, 21)
        Me.btnAgregarFormaPago.TabIndex = 109
        Me.btnAgregarFormaPago.TabStop = False
        '
        'btnTipoVenta
        '
        Me.btnTipoVenta.BackgroundImage = CType(resources.GetObject("btnTipoVenta.BackgroundImage"), System.Drawing.Image)
        Me.btnTipoVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTipoVenta.Location = New System.Drawing.Point(716, 154)
        Me.btnTipoVenta.Name = "btnTipoVenta"
        Me.btnTipoVenta.Size = New System.Drawing.Size(26, 21)
        Me.btnTipoVenta.TabIndex = 110
        Me.btnTipoVenta.TabStop = False
        '
        'btnFormaEntrega
        '
        Me.btnFormaEntrega.BackgroundImage = CType(resources.GetObject("btnFormaEntrega.BackgroundImage"), System.Drawing.Image)
        Me.btnFormaEntrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFormaEntrega.Location = New System.Drawing.Point(716, 181)
        Me.btnFormaEntrega.Name = "btnFormaEntrega"
        Me.btnFormaEntrega.Size = New System.Drawing.Size(26, 21)
        Me.btnFormaEntrega.TabIndex = 111
        Me.btnFormaEntrega.TabStop = False
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(939, 581)
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
        Me.Controls.Add(Me.cboEmpleado)
        Me.Controls.Add(Me.cboFormaPago)
        Me.Controls.Add(Me.cboFormaEntrega)
        Me.Controls.Add(Me.cboTipoVenta)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.grdVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTipoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFormaEntrega, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cboEmpleado As ComboBox
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
End Class
