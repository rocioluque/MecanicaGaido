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
        Me.grdProductosBajoStock = New System.Windows.Forms.DataGridView()
        Me.id_Repuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDisponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExportarPDF = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        CType(Me.grdProductosBajoStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grdProductosBajoStock.Location = New System.Drawing.Point(66, 88)
        Me.grdProductosBajoStock.Name = "grdProductosBajoStock"
        Me.grdProductosBajoStock.ReadOnly = True
        Me.grdProductosBajoStock.RowHeadersVisible = False
        Me.grdProductosBajoStock.RowHeadersWidth = 51
        Me.grdProductosBajoStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdProductosBajoStock.Size = New System.Drawing.Size(562, 297)
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
        Me.Label3.Location = New System.Drawing.Point(62, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 20)
        Me.Label3.TabIndex = 115
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
        Me.btnExportarPDF.Location = New System.Drawing.Point(534, 31)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Size = New System.Drawing.Size(94, 35)
        Me.btnExportarPDF.TabIndex = 114
        Me.btnExportarPDF.Text = "        PDF"
        Me.btnExportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarPDF.UseVisualStyleBackColor = False
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
        'frmAgregarPedidoRepuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(706, 411)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.grdProductosBajoStock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExportarPDF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarPedidoRepuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarPedidoRepuesto"
        CType(Me.grdProductosBajoStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdProductosBajoStock As DataGridView
    Friend WithEvents id_Repuesto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents StockDisponible As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExportarPDF As Button
    Friend WithEvents btnCerrar As PictureBox
End Class
