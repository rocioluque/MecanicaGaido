<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarFormaPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarFormaPago))
        Me.txtFormaDePago = New System.Windows.Forms.TextBox()
        Me.lblFormaDePago = New System.Windows.Forms.Label()
        Me.chkEstadoFP = New System.Windows.Forms.CheckBox()
        Me.grdModificarFP = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdFP = New System.Windows.Forms.TextBox()
        Me.lblNumeroFP = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtNombreDetalle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkEstadoDetalleFP = New System.Windows.Forms.CheckBox()
        Me.txtIdDetalleFP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbtRecargo = New System.Windows.Forms.RadioButton()
        Me.rbtDescuento = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.grdDetalleFP = New System.Windows.Forms.DataGridView()
        CType(Me.grdModificarFP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleFP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFormaDePago
        '
        Me.txtFormaDePago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaDePago.Location = New System.Drawing.Point(511, 35)
        Me.txtFormaDePago.Name = "txtFormaDePago"
        Me.txtFormaDePago.Size = New System.Drawing.Size(232, 23)
        Me.txtFormaDePago.TabIndex = 2
        '
        'lblFormaDePago
        '
        Me.lblFormaDePago.AutoSize = True
        Me.lblFormaDePago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaDePago.ForeColor = System.Drawing.Color.White
        Me.lblFormaDePago.Location = New System.Drawing.Point(388, 38)
        Me.lblFormaDePago.Name = "lblFormaDePago"
        Me.lblFormaDePago.Size = New System.Drawing.Size(61, 17)
        Me.lblFormaDePago.TabIndex = 42
        Me.lblFormaDePago.Text = "Nombre"
        '
        'chkEstadoFP
        '
        Me.chkEstadoFP.AutoSize = True
        Me.chkEstadoFP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstadoFP.ForeColor = System.Drawing.Color.White
        Me.chkEstadoFP.Location = New System.Drawing.Point(77, 75)
        Me.chkEstadoFP.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkEstadoFP.Name = "chkEstadoFP"
        Me.chkEstadoFP.Size = New System.Drawing.Size(85, 21)
        Me.chkEstadoFP.TabIndex = 3
        Me.chkEstadoFP.Text = "¿Activo?"
        Me.chkEstadoFP.UseVisualStyleBackColor = True
        '
        'grdModificarFP
        '
        Me.grdModificarFP.AllowUserToAddRows = False
        Me.grdModificarFP.AllowUserToDeleteRows = False
        Me.grdModificarFP.AllowUserToResizeRows = False
        Me.grdModificarFP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdModificarFP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdModificarFP.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdModificarFP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdModificarFP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdModificarFP.Location = New System.Drawing.Point(77, 110)
        Me.grdModificarFP.Name = "grdModificarFP"
        Me.grdModificarFP.ReadOnly = True
        Me.grdModificarFP.RowHeadersVisible = False
        Me.grdModificarFP.RowHeadersWidth = 51
        Me.grdModificarFP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdModificarFP.Size = New System.Drawing.Size(666, 145)
        Me.grdModificarFP.TabIndex = 39
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(840, 257)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(82, 29)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdFP
        '
        Me.txtIdFP.Enabled = False
        Me.txtIdFP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdFP.Location = New System.Drawing.Point(270, 35)
        Me.txtIdFP.Name = "txtIdFP"
        Me.txtIdFP.Size = New System.Drawing.Size(63, 23)
        Me.txtIdFP.TabIndex = 1
        '
        'lblNumeroFP
        '
        Me.lblNumeroFP.AutoSize = True
        Me.lblNumeroFP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroFP.ForeColor = System.Drawing.Color.White
        Me.lblNumeroFP.Location = New System.Drawing.Point(73, 38)
        Me.lblNumeroFP.Name = "lblNumeroFP"
        Me.lblNumeroFP.Size = New System.Drawing.Size(128, 17)
        Me.lblNumeroFP.TabIndex = 37
        Me.lblNumeroFP.Text = "N° Forma de Pago"
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(840, 141)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(82, 29)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'txtNombreDetalle
        '
        Me.txtNombreDetalle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreDetalle.Location = New System.Drawing.Point(510, 284)
        Me.txtNombreDetalle.Name = "txtNombreDetalle"
        Me.txtNombreDetalle.Size = New System.Drawing.Size(232, 23)
        Me.txtNombreDetalle.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(404, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Nombre"
        '
        'chkEstadoDetalleFP
        '
        Me.chkEstadoDetalleFP.AutoSize = True
        Me.chkEstadoDetalleFP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstadoDetalleFP.ForeColor = System.Drawing.Color.White
        Me.chkEstadoDetalleFP.Location = New System.Drawing.Point(657, 329)
        Me.chkEstadoDetalleFP.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.chkEstadoDetalleFP.Name = "chkEstadoDetalleFP"
        Me.chkEstadoDetalleFP.Size = New System.Drawing.Size(85, 21)
        Me.chkEstadoDetalleFP.TabIndex = 45
        Me.chkEstadoDetalleFP.Text = "¿Activo?"
        Me.chkEstadoDetalleFP.UseVisualStyleBackColor = True
        '
        'txtIdDetalleFP
        '
        Me.txtIdDetalleFP.Enabled = False
        Me.txtIdDetalleFP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdDetalleFP.Location = New System.Drawing.Point(296, 284)
        Me.txtIdDetalleFP.Name = "txtIdDetalleFP"
        Me.txtIdDetalleFP.Size = New System.Drawing.Size(63, 23)
        Me.txtIdDetalleFP.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(73, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 17)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "N° Detalle Forma de Pago"
        '
        'rbtRecargo
        '
        Me.rbtRecargo.AutoSize = True
        Me.rbtRecargo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtRecargo.ForeColor = System.Drawing.Color.White
        Me.rbtRecargo.Location = New System.Drawing.Point(77, 328)
        Me.rbtRecargo.Name = "rbtRecargo"
        Me.rbtRecargo.Size = New System.Drawing.Size(81, 21)
        Me.rbtRecargo.TabIndex = 48
        Me.rbtRecargo.TabStop = True
        Me.rbtRecargo.Text = "Recargo"
        Me.rbtRecargo.UseVisualStyleBackColor = True
        '
        'rbtDescuento
        '
        Me.rbtDescuento.AutoSize = True
        Me.rbtDescuento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDescuento.ForeColor = System.Drawing.Color.White
        Me.rbtDescuento.Location = New System.Drawing.Point(221, 328)
        Me.rbtDescuento.Name = "rbtDescuento"
        Me.rbtDescuento.Size = New System.Drawing.Size(95, 21)
        Me.rbtDescuento.TabIndex = 49
        Me.rbtDescuento.TabStop = True
        Me.rbtDescuento.Text = "Descuento"
        Me.rbtDescuento.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(372, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Porcentaje"
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentaje.Location = New System.Drawing.Point(513, 329)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(81, 23)
        Me.txtPorcentaje.TabIndex = 50
        '
        'grdDetalleFP
        '
        Me.grdDetalleFP.AllowUserToAddRows = False
        Me.grdDetalleFP.AllowUserToDeleteRows = False
        Me.grdDetalleFP.AllowUserToResizeRows = False
        Me.grdDetalleFP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdDetalleFP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdDetalleFP.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdDetalleFP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdDetalleFP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetalleFP.Location = New System.Drawing.Point(77, 381)
        Me.grdDetalleFP.Name = "grdDetalleFP"
        Me.grdDetalleFP.ReadOnly = True
        Me.grdDetalleFP.RowHeadersVisible = False
        Me.grdDetalleFP.RowHeadersWidth = 51
        Me.grdDetalleFP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetalleFP.Size = New System.Drawing.Size(666, 145)
        Me.grdDetalleFP.TabIndex = 52
        '
        'frmModificarFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(962, 548)
        Me.Controls.Add(Me.grdDetalleFP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPorcentaje)
        Me.Controls.Add(Me.rbtDescuento)
        Me.Controls.Add(Me.rbtRecargo)
        Me.Controls.Add(Me.txtNombreDetalle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkEstadoDetalleFP)
        Me.Controls.Add(Me.txtIdDetalleFP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFormaDePago)
        Me.Controls.Add(Me.lblFormaDePago)
        Me.Controls.Add(Me.chkEstadoFP)
        Me.Controls.Add(Me.grdModificarFP)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtIdFP)
        Me.Controls.Add(Me.lblNumeroFP)
        Me.Controls.Add(Me.btnModificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModificarFormaPago"
        Me.Text = "frmModificarFormaPago"
        CType(Me.grdModificarFP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleFP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFormaDePago As TextBox
    Friend WithEvents lblFormaDePago As Label
    Friend WithEvents chkEstadoFP As CheckBox
    Friend WithEvents grdModificarFP As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdFP As TextBox
    Friend WithEvents lblNumeroFP As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtNombreDetalle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkEstadoDetalleFP As CheckBox
    Friend WithEvents txtIdDetalleFP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbtRecargo As RadioButton
    Friend WithEvents rbtDescuento As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPorcentaje As TextBox
    Friend WithEvents grdDetalleFP As DataGridView
End Class
