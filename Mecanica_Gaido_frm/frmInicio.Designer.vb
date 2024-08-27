<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.grdProductosBajoStock = New System.Windows.Forms.DataGridView()
        Me.id_Repuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDisponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExportarPDF = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.horaFecha = New System.Windows.Forms.Timer(Me.components)
        Me.chtRepuestos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grdGrilla2 = New System.Windows.Forms.DataGridView()
        Me.grdGrilla1 = New System.Windows.Forms.DataGridView()
        CType(Me.grdProductosBajoStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrilla2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProductosBajoStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdProductosBajoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProductosBajoStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_Repuesto, Me.Descripcion, Me.StockDisponible})
        Me.grdProductosBajoStock.Location = New System.Drawing.Point(540, 58)
        Me.grdProductosBajoStock.Name = "grdProductosBajoStock"
        Me.grdProductosBajoStock.ReadOnly = True
        Me.grdProductosBajoStock.RowHeadersVisible = False
        Me.grdProductosBajoStock.RowHeadersWidth = 51
        Me.grdProductosBajoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdProductosBajoStock.Size = New System.Drawing.Size(562, 297)
        Me.grdProductosBajoStock.TabIndex = 113
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
        Me.Descripcion.HeaderText = "Descripcion"
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
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(536, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 20)
        Me.Label3.TabIndex = 112
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
        Me.btnExportarPDF.Location = New System.Drawing.Point(1008, 13)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Size = New System.Drawing.Size(94, 35)
        Me.btnExportarPDF.TabIndex = 111
        Me.btnExportarPDF.Text = "        PDF"
        Me.btnExportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarPDF.UseVisualStyleBackColor = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.lblFecha.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblFecha.Location = New System.Drawing.Point(12, 58)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(72, 23)
        Me.lblFecha.TabIndex = 110
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblHora.Font = New System.Drawing.Font("Century Gothic", 30.0!)
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(7, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(114, 49)
        Me.lblHora.TabIndex = 109
        Me.lblHora.Text = "Hora"
        '
        'horaFecha
        '
        Me.horaFecha.Enabled = True
        '
        'chtRepuestos
        '
        Me.chtRepuestos.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        ChartArea2.Name = "ChartArea1"
        Me.chtRepuestos.ChartAreas.Add(ChartArea2)
        Me.chtRepuestos.Cursor = System.Windows.Forms.Cursors.Hand
        Legend2.Name = "Legend1"
        Me.chtRepuestos.Legends.Add(Legend2)
        Me.chtRepuestos.Location = New System.Drawing.Point(16, 84)
        Me.chtRepuestos.Name = "chtRepuestos"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chtRepuestos.Series.Add(Series2)
        Me.chtRepuestos.Size = New System.Drawing.Size(518, 510)
        Me.chtRepuestos.TabIndex = 114
        Me.chtRepuestos.Text = "Repuestos:"
        '
        'grdGrilla2
        '
        Me.grdGrilla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdGrilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGrilla2.Location = New System.Drawing.Point(834, 444)
        Me.grdGrilla2.Name = "grdGrilla2"
        Me.grdGrilla2.Size = New System.Drawing.Size(268, 150)
        Me.grdGrilla2.TabIndex = 116
        '
        'grdGrilla1
        '
        Me.grdGrilla1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdGrilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGrilla1.Location = New System.Drawing.Point(540, 444)
        Me.grdGrilla1.Name = "grdGrilla1"
        Me.grdGrilla1.Size = New System.Drawing.Size(268, 150)
        Me.grdGrilla1.TabIndex = 115
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1147, 606)
        Me.Controls.Add(Me.grdGrilla2)
        Me.Controls.Add(Me.grdGrilla1)
        Me.Controls.Add(Me.chtRepuestos)
        Me.Controls.Add(Me.grdProductosBajoStock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExportarPDF)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHora)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "frmInicio"
        CType(Me.grdProductosBajoStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrilla2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdProductosBajoStock As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExportarPDF As Button
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents horaFecha As Timer
    Friend WithEvents id_Repuesto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents StockDisponible As DataGridViewTextBoxColumn
    Friend WithEvents chtRepuestos As DataVisualization.Charting.Chart
    Friend WithEvents grdGrilla2 As DataGridView
    Friend WithEvents grdGrilla1 As DataGridView
End Class
