<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarPedidoRepuesto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarPedidoRepuesto))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdProductosBajoStock = New System.Windows.Forms.DataGridView()
        Me.id_Repuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDisponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.cboPersona = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grdRepuestos = New System.Windows.Forms.DataGridView()
        Me.ID_Repuestos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEnviarWhatsapp = New System.Windows.Forms.Button()
        CType(Me.grdProductosBajoStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdProductosBajoStock
        '
        Me.grdProductosBajoStock.AllowUserToAddRows = False
        Me.grdProductosBajoStock.AllowUserToDeleteRows = False
        Me.grdProductosBajoStock.AllowUserToResizeRows = False
        Me.grdProductosBajoStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdProductosBajoStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.grdProductosBajoStock.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
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
        Me.grdProductosBajoStock.Location = New System.Drawing.Point(71, 105)
        Me.grdProductosBajoStock.Name = "grdProductosBajoStock"
        Me.grdProductosBajoStock.ReadOnly = True
        Me.grdProductosBajoStock.RowHeadersVisible = False
        Me.grdProductosBajoStock.RowHeadersWidth = 51
        Me.grdProductosBajoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdProductosBajoStock.Size = New System.Drawing.Size(562, 135)
        Me.grdProductosBajoStock.TabIndex = 116
        '
        'id_Repuesto
        '
        Me.id_Repuesto.FillWeight = 50.0!
        Me.id_Repuesto.HeaderText = "N° Repuesto"
        Me.id_Repuesto.Name = "id_Repuesto"
        Me.id_Repuesto.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 111.9289!
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'StockDisponible
        '
        Me.StockDisponible.FillWeight = 50.0!
        Me.StockDisponible.HeaderText = "Stock Disponible"
        Me.StockDisponible.Name = "StockDisponible"
        Me.StockDisponible.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(68, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 17)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "Productos de bajo Stock:"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Location = New System.Drawing.Point(685, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(19, 18)
        Me.btnCerrar.TabIndex = 117
        Me.btnCerrar.TabStop = False
        '
        'cboPersona
        '
        Me.cboPersona.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPersona.FormattingEnabled = True
        Me.cboPersona.Location = New System.Drawing.Point(170, 34)
        Me.cboPersona.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPersona.Name = "cboPersona"
        Me.cboPersona.Size = New System.Drawing.Size(169, 25)
        Me.cboPersona.TabIndex = 118
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(68, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Proveedor"
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.White
        Me.btnQuitar.Location = New System.Drawing.Point(426, 255)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(117, 37)
        Me.btnQuitar.TabIndex = 122
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(298, 255)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(117, 37)
        Me.btnAgregar.TabIndex = 121
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(170, 262)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(66, 23)
        Me.txtCantidad.TabIndex = 120
        Me.txtCantidad.Text = "1"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(89, 266)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 17)
        Me.Label12.TabIndex = 123
        Me.Label12.Text = "Cantidad:"
        '
        'grdRepuestos
        '
        Me.grdRepuestos.AllowUserToAddRows = False
        Me.grdRepuestos.AllowUserToDeleteRows = False
        Me.grdRepuestos.AllowUserToResizeRows = False
        Me.grdRepuestos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.grdRepuestos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRepuestos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Repuestos, Me.Nombre, Me.Cantidad})
        Me.grdRepuestos.Location = New System.Drawing.Point(71, 307)
        Me.grdRepuestos.Name = "grdRepuestos"
        Me.grdRepuestos.ReadOnly = True
        Me.grdRepuestos.RowHeadersVisible = False
        Me.grdRepuestos.RowHeadersWidth = 51
        Me.grdRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRepuestos.Size = New System.Drawing.Size(562, 135)
        Me.grdRepuestos.TabIndex = 124
        '
        'ID_Repuestos
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.ID_Repuestos.DefaultCellStyle = DataGridViewCellStyle3
        Me.ID_Repuestos.HeaderText = "N° Repuesto"
        Me.ID_Repuestos.MinimumWidth = 6
        Me.ID_Repuestos.Name = "ID_Repuestos"
        Me.ID_Repuestos.ReadOnly = True
        Me.ID_Repuestos.Width = 150
        '
        'Nombre
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle4
        Me.Nombre.HeaderText = "Descripción"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 250
        '
        'Cantidad
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 160
        '
        'btnEnviarWhatsapp
        '
        Me.btnEnviarWhatsapp.BackColor = System.Drawing.Color.Transparent
        Me.btnEnviarWhatsapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEnviarWhatsapp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviarWhatsapp.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnEnviarWhatsapp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnEnviarWhatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarWhatsapp.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnEnviarWhatsapp.ForeColor = System.Drawing.Color.White
        Me.btnEnviarWhatsapp.Image = CType(resources.GetObject("btnEnviarWhatsapp.Image"), System.Drawing.Image)
        Me.btnEnviarWhatsapp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviarWhatsapp.Location = New System.Drawing.Point(503, 27)
        Me.btnEnviarWhatsapp.Name = "btnEnviarWhatsapp"
        Me.btnEnviarWhatsapp.Size = New System.Drawing.Size(130, 35)
        Me.btnEnviarWhatsapp.TabIndex = 125
        Me.btnEnviarWhatsapp.Text = "        Enviar PDF"
        Me.btnEnviarWhatsapp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviarWhatsapp.UseVisualStyleBackColor = False
        '
        'frmAgregarPedidoRepuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(706, 488)
        Me.Controls.Add(Me.btnEnviarWhatsapp)
        Me.Controls.Add(Me.grdRepuestos)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPersona)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.grdProductosBajoStock)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarPedidoRepuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarPedidoRepuesto"
        CType(Me.grdProductosBajoStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdProductosBajoStock As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents cboPersona As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents id_Repuesto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents StockDisponible As DataGridViewTextBoxColumn
    Friend WithEvents grdRepuestos As DataGridView
    Friend WithEvents ID_Repuestos As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents btnEnviarWhatsapp As Button
End Class
