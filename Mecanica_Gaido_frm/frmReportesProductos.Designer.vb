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
        Me.cboPersona = New System.Windows.Forms.ComboBox()
        Me.grdRepuestos = New System.Windows.Forms.DataGridView()
        Me.CodFabricante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockReal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnEnviarWhatsapp = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Proveedor"
        '
        'cboPersona
        '
        Me.cboPersona.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPersona.FormattingEnabled = True
        Me.cboPersona.Location = New System.Drawing.Point(165, 24)
        Me.cboPersona.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPersona.Name = "cboPersona"
        Me.cboPersona.Size = New System.Drawing.Size(169, 25)
        Me.cboPersona.TabIndex = 120
        '
        'grdRepuestos
        '
        Me.grdRepuestos.AllowUserToAddRows = False
        Me.grdRepuestos.AllowUserToDeleteRows = False
        Me.grdRepuestos.AllowUserToResizeRows = False
        Me.grdRepuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdRepuestos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.grdRepuestos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
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
        Me.CodFabricante.Name = "CodFabricante"
        Me.CodFabricante.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.FillWeight = 120.0!
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'StockReal
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.StockReal.DefaultCellStyle = DataGridViewCellStyle6
        Me.StockReal.FillWeight = 45.0!
        Me.StockReal.HeaderText = "Cantidad"
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
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.White
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
        Me.txtTotal.Location = New System.Drawing.Point(566, 24)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(90, 23)
        Me.txtTotal.TabIndex = 124
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnEnviarWhatsapp
        '
        Me.btnEnviarWhatsapp.BackColor = System.Drawing.Color.Transparent
        Me.btnEnviarWhatsapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEnviarWhatsapp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviarWhatsapp.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnEnviarWhatsapp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnEnviarWhatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarWhatsapp.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnEnviarWhatsapp.ForeColor = System.Drawing.Color.White
        Me.btnEnviarWhatsapp.Image = CType(resources.GetObject("btnEnviarWhatsapp.Image"), System.Drawing.Image)
        Me.btnEnviarWhatsapp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviarWhatsapp.Location = New System.Drawing.Point(406, 268)
        Me.btnEnviarWhatsapp.Name = "btnEnviarWhatsapp"
        Me.btnEnviarWhatsapp.Size = New System.Drawing.Size(130, 35)
        Me.btnEnviarWhatsapp.TabIndex = 127
        Me.btnEnviarWhatsapp.Text = "             Enviar PDF"
        Me.btnEnviarWhatsapp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviarWhatsapp.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(148, 268)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(130, 35)
        Me.btnCancelar.TabIndex = 126
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmReportesProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 572)
        Me.Controls.Add(Me.btnEnviarWhatsapp)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdRepuestos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPersona)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportesProductos"
        Me.Text = "frmReportesProductos"
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboPersona As ComboBox
    Friend WithEvents grdRepuestos As DataGridView
    Friend WithEvents CodFabricante As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents StockReal As DataGridViewTextBoxColumn
    Friend WithEvents PrecioLista As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnEnviarWhatsapp As Button
    Friend WithEvents btnCancelar As Button
End Class
