<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportesProductos
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportesProductos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.grdRepuestos = New System.Windows.Forms.DataGridView()
        Me.CodFabricante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockReal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnDescargarPDF = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dtpFechaMax = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaMin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnObtenerResumen = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(35, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Marca"
        '
        'cboMarca
        '
        Me.cboMarca.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(128, 24)
        Me.cboMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(169, 25)
        Me.cboMarca.TabIndex = 120
        '
        'grdRepuestos
        '
        Me.grdRepuestos.AllowUserToAddRows = False
        Me.grdRepuestos.AllowUserToDeleteRows = False
        Me.grdRepuestos.AllowUserToResizeRows = False
        Me.grdRepuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdRepuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.grdRepuestos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdRepuestos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRepuestos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodFabricante, Me.Descripcion, Me.StockReal, Me.PrecioLista, Me.Total})
        Me.grdRepuestos.Location = New System.Drawing.Point(23, 71)
        Me.grdRepuestos.MultiSelect = False
        Me.grdRepuestos.Name = "grdRepuestos"
        Me.grdRepuestos.ReadOnly = True
        Me.grdRepuestos.RowHeadersVisible = False
        Me.grdRepuestos.RowHeadersWidth = 51
        Me.grdRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRepuestos.Size = New System.Drawing.Size(633, 176)
        Me.grdRepuestos.TabIndex = 122
        '
        'CodFabricante
        '
        Me.CodFabricante.FillWeight = 50.0!
        Me.CodFabricante.HeaderText = "N° Repuesto"
        Me.CodFabricante.MinimumWidth = 6
        Me.CodFabricante.Name = "CodFabricante"
        Me.CodFabricante.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 120.0!
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'StockReal
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.StockReal.DefaultCellStyle = DataGridViewCellStyle6
        Me.StockReal.FillWeight = 45.0!
        Me.StockReal.HeaderText = "Cantidad"
        Me.StockReal.MinimumWidth = 6
        Me.StockReal.Name = "StockReal"
        Me.StockReal.ReadOnly = True
        '
        'PrecioLista
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.PrecioLista.DefaultCellStyle = DataGridViewCellStyle7
        Me.PrecioLista.FillWeight = 60.0!
        Me.PrecioLista.HeaderText = "Precio Unitario"
        Me.PrecioLista.MinimumWidth = 6
        Me.PrecioLista.Name = "PrecioLista"
        Me.PrecioLista.ReadOnly = True
        '
        'Total
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.Total.DefaultCellStyle = DataGridViewCellStyle8
        Me.Total.FillWeight = 50.0!
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(403, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Total General"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(544, 24)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(90, 23)
        Me.txtTotal.TabIndex = 124
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDescargarPDF
        '
        Me.btnDescargarPDF.BackColor = System.Drawing.Color.Transparent
        Me.btnDescargarPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDescargarPDF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDescargarPDF.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnDescargarPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnDescargarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDescargarPDF.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnDescargarPDF.ForeColor = System.Drawing.Color.Black
        Me.btnDescargarPDF.Image = CType(resources.GetObject("btnDescargarPDF.Image"), System.Drawing.Image)
        Me.btnDescargarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDescargarPDF.Location = New System.Drawing.Point(703, 71)
        Me.btnDescargarPDF.Name = "btnDescargarPDF"
        Me.btnDescargarPDF.Size = New System.Drawing.Size(137, 35)
        Me.btnDescargarPDF.TabIndex = 127
        Me.btnDescargarPDF.Text = "          Descargar PDF"
        Me.btnDescargarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDescargarPDF.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(703, 140)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(137, 35)
        Me.btnCancelar.TabIndex = 126
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'dtpFechaMax
        '
        Me.dtpFechaMax.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaMax.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaMax.Location = New System.Drawing.Point(109, 603)
        Me.dtpFechaMax.Name = "dtpFechaMax"
        Me.dtpFechaMax.Size = New System.Drawing.Size(100, 23)
        Me.dtpFechaMax.TabIndex = 149
        Me.dtpFechaMax.Value = New Date(2024, 11, 9, 0, 0, 0, 0)
        '
        'dtpFechaMin
        '
        Me.dtpFechaMin.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaMin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaMin.Location = New System.Drawing.Point(109, 551)
        Me.dtpFechaMin.Name = "dtpFechaMin"
        Me.dtpFechaMin.Size = New System.Drawing.Size(100, 23)
        Me.dtpFechaMin.TabIndex = 148
        Me.dtpFechaMin.Value = New Date(2024, 11, 9, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(35, 556)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(35, 603)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Hasta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(35, 451)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 18)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "RESUMEN DE MOVIMIENTO"
        '
        'btnObtenerResumen
        '
        Me.btnObtenerResumen.BackColor = System.Drawing.Color.Transparent
        Me.btnObtenerResumen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnObtenerResumen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnObtenerResumen.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnObtenerResumen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnObtenerResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnObtenerResumen.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObtenerResumen.ForeColor = System.Drawing.Color.Black
        Me.btnObtenerResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnObtenerResumen.Location = New System.Drawing.Point(451, 591)
        Me.btnObtenerResumen.Name = "btnObtenerResumen"
        Me.btnObtenerResumen.Size = New System.Drawing.Size(137, 35)
        Me.btnObtenerResumen.TabIndex = 144
        Me.btnObtenerResumen.Text = "Obtener Resumen"
        Me.btnObtenerResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnObtenerResumen.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(35, 499)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Producto"
        '
        'cboProducto
        '
        Me.cboProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(109, 496)
        Me.cboProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(479, 25)
        Me.cboProducto.TabIndex = 142
        '
        'frmReportesProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1032, 649)
        Me.Controls.Add(Me.dtpFechaMax)
        Me.Controls.Add(Me.dtpFechaMin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnObtenerResumen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.btnDescargarPDF)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdRepuestos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMarca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportesProductos"
        Me.Text = "frmReportesProductos"
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents grdRepuestos As DataGridView
    Friend WithEvents CodFabricante As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents StockReal As DataGridViewTextBoxColumn
    Friend WithEvents PrecioLista As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnDescargarPDF As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dtpFechaMax As DateTimePicker
    Friend WithEvents dtpFechaMin As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnObtenerResumen As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cboProducto As ComboBox
End Class
