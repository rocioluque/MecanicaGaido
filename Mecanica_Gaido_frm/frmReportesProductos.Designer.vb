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
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 21)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Marca"
        '
        'cboMarca
        '
        Me.cboMarca.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(171, 30)
        Me.cboMarca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(224, 29)
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
        Me.grdRepuestos.Location = New System.Drawing.Point(31, 87)
        Me.grdRepuestos.Margin = New System.Windows.Forms.Padding(4)
        Me.grdRepuestos.MultiSelect = False
        Me.grdRepuestos.Name = "grdRepuestos"
        Me.grdRepuestos.ReadOnly = True
        Me.grdRepuestos.RowHeadersVisible = False
        Me.grdRepuestos.RowHeadersWidth = 51
        Me.grdRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRepuestos.Size = New System.Drawing.Size(844, 217)
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
        Me.Label2.Location = New System.Drawing.Point(537, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 21)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Total General"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(725, 30)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(119, 27)
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
        Me.btnDescargarPDF.Location = New System.Drawing.Point(541, 330)
        Me.btnDescargarPDF.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDescargarPDF.Name = "btnDescargarPDF"
        Me.btnDescargarPDF.Size = New System.Drawing.Size(191, 43)
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
        Me.btnCancelar.Location = New System.Drawing.Point(197, 330)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(173, 43)
        Me.btnCancelar.TabIndex = 126
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmReportesProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1043, 457)
        Me.Controls.Add(Me.btnDescargarPDF)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdRepuestos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMarca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
End Class
