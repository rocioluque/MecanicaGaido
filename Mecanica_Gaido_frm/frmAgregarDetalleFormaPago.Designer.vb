<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarDetalleFormaPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarDetalleFormaPago))
        Me.cboFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.txtDetalleFP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtPorcentuaje = New System.Windows.Forms.TextBox()
        Me.rbtDescuento = New System.Windows.Forms.RadioButton()
        Me.rbtRecargo = New System.Windows.Forms.RadioButton()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboFormaPago
        '
        Me.cboFormaPago.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboFormaPago.FormattingEnabled = True
        Me.cboFormaPago.Location = New System.Drawing.Point(177, 51)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Size = New System.Drawing.Size(228, 25)
        Me.cboFormaPago.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Forma de Pago"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Location = New System.Drawing.Point(424, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(19, 18)
        Me.btnCerrar.TabIndex = 14
        Me.btnCerrar.TabStop = False
        '
        'txtDetalleFP
        '
        Me.txtDetalleFP.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDetalleFP.Location = New System.Drawing.Point(177, 96)
        Me.txtDetalleFP.Name = "txtDetalleFP"
        Me.txtDetalleFP.Size = New System.Drawing.Size(228, 23)
        Me.txtDetalleFP.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Detalle "
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(351, 229)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(82, 29)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(31, 141)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 20)
        Me.Label23.TabIndex = 119
        Me.Label23.Text = "Monto %"
        '
        'txtPorcentuaje
        '
        Me.txtPorcentuaje.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentuaje.Location = New System.Drawing.Point(177, 141)
        Me.txtPorcentuaje.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPorcentuaje.Name = "txtPorcentuaje"
        Me.txtPorcentuaje.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPorcentuaje.Size = New System.Drawing.Size(228, 23)
        Me.txtPorcentuaje.TabIndex = 116
        Me.txtPorcentuaje.Text = "0"
        '
        'rbtDescuento
        '
        Me.rbtDescuento.AutoSize = True
        Me.rbtDescuento.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.rbtDescuento.ForeColor = System.Drawing.Color.White
        Me.rbtDescuento.Location = New System.Drawing.Point(177, 186)
        Me.rbtDescuento.Name = "rbtDescuento"
        Me.rbtDescuento.Size = New System.Drawing.Size(95, 21)
        Me.rbtDescuento.TabIndex = 118
        Me.rbtDescuento.TabStop = True
        Me.rbtDescuento.Text = "Descuento"
        Me.rbtDescuento.UseVisualStyleBackColor = True
        '
        'rbtRecargo
        '
        Me.rbtRecargo.AutoSize = True
        Me.rbtRecargo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.rbtRecargo.ForeColor = System.Drawing.Color.White
        Me.rbtRecargo.Location = New System.Drawing.Point(35, 186)
        Me.rbtRecargo.Name = "rbtRecargo"
        Me.rbtRecargo.Size = New System.Drawing.Size(81, 21)
        Me.rbtRecargo.TabIndex = 117
        Me.rbtRecargo.TabStop = True
        Me.rbtRecargo.Text = "Recargo"
        Me.rbtRecargo.UseVisualStyleBackColor = True
        '
        'frmAgregarDetalleFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(445, 270)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtPorcentuaje)
        Me.Controls.Add(Me.rbtDescuento)
        Me.Controls.Add(Me.rbtRecargo)
        Me.Controls.Add(Me.cboFormaPago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtDetalleFP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarDetalleFormaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarDetalleFormaPago"
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboFormaPago As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents txtDetalleFP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents txtPorcentuaje As TextBox
    Friend WithEvents rbtDescuento As RadioButton
    Friend WithEvents rbtRecargo As RadioButton
End Class
