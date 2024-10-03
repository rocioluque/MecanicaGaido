<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompras))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtOtrosImpuestos = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
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
        Me.btnAgregarPersona = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.PanelDetalleDeCompras = New System.Windows.Forms.Panel()
        Me.grdRepuestos = New System.Windows.Forms.DataGridView()
        Me.ID_Repuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarCompra = New System.Windows.Forms.Button()
        Me.btnAgregarCompra = New System.Windows.Forms.Button()
        Me.txtCantidadCompra = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboProductoCompra = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblInformacionGeneral = New System.Windows.Forms.Label()
        Me.PanelInformacionGeneral = New System.Windows.Forms.Panel()
        Me.txtNumComprobante = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelImpuestos = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PanelTotales = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.RichTextBox()
        Me.txtIvaMonto = New System.Windows.Forms.RichTextBox()
        Me.txtSubtotal = New System.Windows.Forms.RichTextBox()
        Me.grdCompras = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.lblBusqueda = New System.Windows.Forms.Label()
        CType(Me.btnAgregarPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetalleDeCompras.SuspendLayout()
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInformacionGeneral.SuspendLayout()
        Me.PanelImpuestos.SuspendLayout()
        Me.PanelTotales.SuspendLayout()
        CType(Me.grdCompras, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtOtrosImpuestos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtOtrosImpuestos.Size = New System.Drawing.Size(123, 23)
        Me.txtOtrosImpuestos.TabIndex = 10
        Me.txtOtrosImpuestos.Text = "0"
        '
        'txtIVA
        '
        Me.txtIVA.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVA.Location = New System.Drawing.Point(125, 25)
        Me.txtIVA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIVA.Size = New System.Drawing.Size(123, 23)
        Me.txtIVA.TabIndex = 8
        Me.txtIVA.Text = "21"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(214, 75)
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
        Me.cboFormaPago.Size = New System.Drawing.Size(220, 25)
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
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Proveedor"
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
        Me.Label1.Location = New System.Drawing.Point(92, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "N° Compra"
        '
        'btnAgregarPersona
        '
        Me.btnAgregarPersona.BackgroundImage = CType(resources.GetObject("btnAgregarPersona.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarPersona.Location = New System.Drawing.Point(189, 90)
        Me.btnAgregarPersona.Name = "btnAgregarPersona"
        Me.btnAgregarPersona.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarPersona.TabIndex = 87
        Me.btnAgregarPersona.TabStop = False
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
        Me.btnModificar.Location = New System.Drawing.Point(936, 172)
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
        Me.btnCancelar.Location = New System.Drawing.Point(936, 275)
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
        Me.btnAceptar.Location = New System.Drawing.Point(936, 69)
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
        Me.btnBuscar.Location = New System.Drawing.Point(287, 69)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 28)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'PanelDetalleDeCompras
        '
        Me.PanelDetalleDeCompras.Controls.Add(Me.grdRepuestos)
        Me.PanelDetalleDeCompras.Controls.Add(Me.btnQuitarCompra)
        Me.PanelDetalleDeCompras.Controls.Add(Me.btnAgregarCompra)
        Me.PanelDetalleDeCompras.Controls.Add(Me.txtCantidadCompra)
        Me.PanelDetalleDeCompras.Controls.Add(Me.Label12)
        Me.PanelDetalleDeCompras.Controls.Add(Me.cboProductoCompra)
        Me.PanelDetalleDeCompras.Controls.Add(Me.Label6)
        Me.PanelDetalleDeCompras.Location = New System.Drawing.Point(95, 236)
        Me.PanelDetalleDeCompras.Name = "PanelDetalleDeCompras"
        Me.PanelDetalleDeCompras.Size = New System.Drawing.Size(814, 324)
        Me.PanelDetalleDeCompras.TabIndex = 115
        '
        'grdRepuestos
        '
        Me.grdRepuestos.AllowUserToAddRows = False
        Me.grdRepuestos.AllowUserToDeleteRows = False
        Me.grdRepuestos.AllowUserToResizeRows = False
        Me.grdRepuestos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdRepuestos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRepuestos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Repuesto, Me.Descripcion, Me.Diario, Me.Cantidad, Me.PrecioCompra, Me.Total})
        Me.grdRepuestos.Location = New System.Drawing.Point(3, 52)
        Me.grdRepuestos.Name = "grdRepuestos"
        Me.grdRepuestos.ReadOnly = True
        Me.grdRepuestos.RowHeadersVisible = False
        Me.grdRepuestos.RowHeadersWidth = 51
        Me.grdRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRepuestos.Size = New System.Drawing.Size(808, 256)
        Me.grdRepuestos.TabIndex = 117
        '
        'ID_Repuesto
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.ID_Repuesto.DefaultCellStyle = DataGridViewCellStyle2
        Me.ID_Repuesto.HeaderText = "ID"
        Me.ID_Repuesto.MinimumWidth = 6
        Me.ID_Repuesto.Name = "ID_Repuesto"
        Me.ID_Repuesto.ReadOnly = True
        Me.ID_Repuesto.Visible = False
        Me.ID_Repuesto.Width = 50
        '
        'Descripcion
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.Descripcion.DefaultCellStyle = DataGridViewCellStyle3
        Me.Descripcion.HeaderText = "Repuesto"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 220
        '
        'Diario
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Diario.DefaultCellStyle = DataGridViewCellStyle4
        Me.Diario.HeaderText = "Nombre común"
        Me.Diario.MinimumWidth = 6
        Me.Diario.Name = "Diario"
        Me.Diario.ReadOnly = True
        Me.Diario.Width = 210
        '
        'Cantidad
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.Cantidad.HeaderText = "Cant."
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 125
        '
        'PrecioCompra
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.PrecioCompra.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrecioCompra.HeaderText = "Precio"
        Me.PrecioCompra.MinimumWidth = 6
        Me.PrecioCompra.Name = "PrecioCompra"
        Me.PrecioCompra.ReadOnly = True
        Me.PrecioCompra.Width = 116
        '
        'Total
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle7
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 116
        '
        'btnQuitarCompra
        '
        Me.btnQuitarCompra.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitarCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitarCompra.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnQuitarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnQuitarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarCompra.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarCompra.ForeColor = System.Drawing.Color.White
        Me.btnQuitarCompra.Location = New System.Drawing.Point(670, 9)
        Me.btnQuitarCompra.Name = "btnQuitarCompra"
        Me.btnQuitarCompra.Size = New System.Drawing.Size(117, 37)
        Me.btnQuitarCompra.TabIndex = 22
        Me.btnQuitarCompra.Text = "Quitar"
        Me.btnQuitarCompra.UseVisualStyleBackColor = False
        '
        'btnAgregarCompra
        '
        Me.btnAgregarCompra.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarCompra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarCompra.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAgregarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAgregarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCompra.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCompra.ForeColor = System.Drawing.Color.White
        Me.btnAgregarCompra.Location = New System.Drawing.Point(542, 9)
        Me.btnAgregarCompra.Name = "btnAgregarCompra"
        Me.btnAgregarCompra.Size = New System.Drawing.Size(117, 37)
        Me.btnAgregarCompra.TabIndex = 21
        Me.btnAgregarCompra.Text = "Agregar"
        Me.btnAgregarCompra.UseVisualStyleBackColor = False
        '
        'txtCantidadCompra
        '
        Me.txtCantidadCompra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadCompra.Location = New System.Drawing.Point(458, 16)
        Me.txtCantidadCompra.Name = "txtCantidadCompra"
        Me.txtCantidadCompra.Size = New System.Drawing.Size(66, 23)
        Me.txtCantidadCompra.TabIndex = 19
        Me.txtCantidadCompra.Text = "1"
        Me.txtCantidadCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'cboProductoCompra
        '
        Me.cboProductoCompra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProductoCompra.FormattingEnabled = True
        Me.cboProductoCompra.Location = New System.Drawing.Point(93, 16)
        Me.cboProductoCompra.Name = "cboProductoCompra"
        Me.cboProductoCompra.Size = New System.Drawing.Size(278, 25)
        Me.cboProductoCompra.TabIndex = 18
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
        Me.lblInformacionGeneral.Location = New System.Drawing.Point(386, 61)
        Me.lblInformacionGeneral.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInformacionGeneral.Name = "lblInformacionGeneral"
        Me.lblInformacionGeneral.Size = New System.Drawing.Size(130, 17)
        Me.lblInformacionGeneral.TabIndex = 116
        Me.lblInformacionGeneral.Text = "Información General"
        '
        'PanelInformacionGeneral
        '
        Me.PanelInformacionGeneral.Controls.Add(Me.txtNumComprobante)
        Me.PanelInformacionGeneral.Controls.Add(Me.dtpFechaCompra)
        Me.PanelInformacionGeneral.Controls.Add(Me.cboPersona)
        Me.PanelInformacionGeneral.Controls.Add(Me.Label2)
        Me.PanelInformacionGeneral.Controls.Add(Me.Label3)
        Me.PanelInformacionGeneral.Controls.Add(Me.Label4)
        Me.PanelInformacionGeneral.Controls.Add(Me.btnAgregarPersona)
        Me.PanelInformacionGeneral.Controls.Add(Me.Label5)
        Me.PanelInformacionGeneral.Controls.Add(Me.cboFormaPago)
        Me.PanelInformacionGeneral.Controls.Add(Me.chkEstado)
        Me.PanelInformacionGeneral.Location = New System.Drawing.Point(374, 69)
        Me.PanelInformacionGeneral.Name = "PanelInformacionGeneral"
        Me.PanelInformacionGeneral.Size = New System.Drawing.Size(535, 153)
        Me.PanelInformacionGeneral.TabIndex = 117
        '
        'txtNumComprobante
        '
        Me.txtNumComprobante.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumComprobante.Location = New System.Drawing.Point(298, 35)
        Me.txtNumComprobante.Mask = "A-00000-00000000"
        Me.txtNumComprobante.Name = "txtNumComprobante"
        Me.txtNumComprobante.Size = New System.Drawing.Size(220, 23)
        Me.txtNumComprobante.TabIndex = 90
        '
        'dtpFechaCompra
        '
        Me.dtpFechaCompra.CalendarFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCompra.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaCompra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaCompra.Location = New System.Drawing.Point(15, 36)
        Me.dtpFechaCompra.Name = "dtpFechaCompra"
        Me.dtpFechaCompra.Size = New System.Drawing.Size(200, 23)
        Me.dtpFechaCompra.TabIndex = 89
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(107, 104)
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
        Me.PanelImpuestos.Location = New System.Drawing.Point(95, 112)
        Me.PanelImpuestos.Name = "PanelImpuestos"
        Me.PanelImpuestos.Size = New System.Drawing.Size(258, 110)
        Me.PanelImpuestos.TabIndex = 123
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(784, 575)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 17)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "Total"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(465, 575)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 17)
        Me.Label14.TabIndex = 126
        Me.Label14.Text = "IVA monto"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(170, 575)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 17)
        Me.Label13.TabIndex = 124
        Me.Label13.Text = "Subtotal"
        '
        'PanelTotales
        '
        Me.PanelTotales.Controls.Add(Me.txtTotal)
        Me.PanelTotales.Controls.Add(Me.txtIvaMonto)
        Me.PanelTotales.Controls.Add(Me.txtSubtotal)
        Me.PanelTotales.Location = New System.Drawing.Point(95, 583)
        Me.PanelTotales.Name = "PanelTotales"
        Me.PanelTotales.Size = New System.Drawing.Size(814, 64)
        Me.PanelTotales.TabIndex = 125
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(634, 17)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTotal.Size = New System.Drawing.Size(139, 28)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.Text = "0"
        '
        'txtIvaMonto
        '
        Me.txtIvaMonto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIvaMonto.Location = New System.Drawing.Point(336, 17)
        Me.txtIvaMonto.Name = "txtIvaMonto"
        Me.txtIvaMonto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIvaMonto.Size = New System.Drawing.Size(139, 28)
        Me.txtIvaMonto.TabIndex = 12
        Me.txtIvaMonto.Text = "0"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(40, 17)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubtotal.Size = New System.Drawing.Size(139, 28)
        Me.txtSubtotal.TabIndex = 11
        Me.txtSubtotal.Text = "0"
        '
        'grdCompras
        '
        Me.grdCompras.AllowUserToAddRows = False
        Me.grdCompras.AllowUserToDeleteRows = False
        Me.grdCompras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCompras.Location = New System.Drawing.Point(95, 653)
        Me.grdCompras.MultiSelect = False
        Me.grdCompras.Name = "grdCompras"
        Me.grdCompras.ReadOnly = True
        Me.grdCompras.RowHeadersVisible = False
        Me.grdCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCompras.Size = New System.Drawing.Size(814, 164)
        Me.grdCompras.TabIndex = 128
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(374, 25)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBusqueda.Size = New System.Drawing.Size(535, 23)
        Me.txtBusqueda.TabIndex = 33
        Me.txtBusqueda.Visible = False
        '
        'lblBusqueda
        '
        Me.lblBusqueda.AutoSize = True
        Me.lblBusqueda.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusqueda.ForeColor = System.Drawing.Color.White
        Me.lblBusqueda.Location = New System.Drawing.Point(107, 28)
        Me.lblBusqueda.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(262, 17)
        Me.lblBusqueda.TabIndex = 91
        Me.lblBusqueda.Text = "Utilice el cuadro para hacer búsquedas"
        Me.lblBusqueda.Visible = False
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1138, 846)
        Me.Controls.Add(Me.lblBusqueda)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.grdCompras)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PanelTotales)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PanelImpuestos)
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
        CType(Me.btnAgregarPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetalleDeCompras.ResumeLayout(False)
        Me.PanelDetalleDeCompras.PerformLayout()
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInformacionGeneral.ResumeLayout(False)
        Me.PanelInformacionGeneral.PerformLayout()
        Me.PanelImpuestos.ResumeLayout(False)
        Me.PanelImpuestos.PerformLayout()
        Me.PanelTotales.ResumeLayout(False)
        CType(Me.grdCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents txtOtrosImpuestos As TextBox
    Friend WithEvents txtIVA As TextBox
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
    Friend WithEvents btnAgregarPersona As PictureBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents PanelDetalleDeCompras As Panel
    Friend WithEvents btnQuitarCompra As Button
    Friend WithEvents btnAgregarCompra As Button
    Friend WithEvents txtCantidadCompra As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboProductoCompra As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblInformacionGeneral As Label
    Friend WithEvents PanelInformacionGeneral As Panel
    Friend WithEvents dtpFechaCompra As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelImpuestos As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PanelTotales As Panel
    Friend WithEvents txtTotal As RichTextBox
    Friend WithEvents txtIvaMonto As RichTextBox
    Friend WithEvents txtSubtotal As RichTextBox
    Friend WithEvents grdRepuestos As DataGridView
    Friend WithEvents txtNumComprobante As MaskedTextBox
    Friend WithEvents grdCompras As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents lblBusqueda As Label
    Friend WithEvents ID_Repuesto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Diario As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompra As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
