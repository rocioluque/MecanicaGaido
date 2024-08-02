<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarMarca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarMarca))
        Me.chkVehiculo = New System.Windows.Forms.CheckBox()
        Me.chkProducto = New System.Windows.Forms.CheckBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblNumeroMarca = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grdModificarMarca = New System.Windows.Forms.DataGridView()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        CType(Me.grdModificarMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkVehiculo
        '
        Me.chkVehiculo.AutoSize = True
        Me.chkVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVehiculo.ForeColor = System.Drawing.Color.White
        Me.chkVehiculo.Location = New System.Drawing.Point(441, 169)
        Me.chkVehiculo.Name = "chkVehiculo"
        Me.chkVehiculo.Size = New System.Drawing.Size(135, 21)
        Me.chkVehiculo.TabIndex = 17
        Me.chkVehiculo.Text = "¿Es de vehículo?"
        Me.chkVehiculo.UseVisualStyleBackColor = True
        '
        'chkProducto
        '
        Me.chkProducto.AutoSize = True
        Me.chkProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProducto.ForeColor = System.Drawing.Color.White
        Me.chkProducto.Location = New System.Drawing.Point(129, 169)
        Me.chkProducto.Name = "chkProducto"
        Me.chkProducto.Size = New System.Drawing.Size(141, 21)
        Me.chkProducto.TabIndex = 16
        Me.chkProducto.Text = "¿Es de producto?"
        Me.chkProducto.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(272, 83)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(92, 21)
        Me.txtId.TabIndex = 15
        '
        'lblNumeroMarca
        '
        Me.lblNumeroMarca.AutoSize = True
        Me.lblNumeroMarca.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroMarca.ForeColor = System.Drawing.Color.White
        Me.lblNumeroMarca.Location = New System.Drawing.Point(123, 85)
        Me.lblNumeroMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroMarca.Name = "lblNumeroMarca"
        Me.lblNumeroMarca.Size = New System.Drawing.Size(80, 20)
        Me.lblNumeroMarca.TabIndex = 19
        Me.lblNumeroMarca.Text = "N° Marca"
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatAppearance.BorderSize = 2
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(1131, 71)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(123, 45)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(1131, 157)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(123, 45)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grdModificarMarca
        '
        Me.grdModificarMarca.AllowUserToAddRows = False
        Me.grdModificarMarca.AllowUserToDeleteRows = False
        Me.grdModificarMarca.AllowUserToResizeRows = False
        Me.grdModificarMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdModificarMarca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdModificarMarca.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.grdModificarMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdModificarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdModificarMarca.Location = New System.Drawing.Point(80, 249)
        Me.grdModificarMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdModificarMarca.Name = "grdModificarMarca"
        Me.grdModificarMarca.ReadOnly = True
        Me.grdModificarMarca.RowHeadersVisible = False
        Me.grdModificarMarca.Size = New System.Drawing.Size(1120, 340)
        Me.grdModificarMarca.TabIndex = 21
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(744, 169)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(85, 21)
        Me.chkEstado.TabIndex = 22
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(591, 83)
        Me.txtMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(278, 21)
        Me.txtMarca.TabIndex = 23
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.White
        Me.lblMarca.Location = New System.Drawing.Point(435, 85)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(59, 20)
        Me.lblMarca.TabIndex = 24
        Me.lblMarca.Text = "Marca"
        '
        'frmModificarMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 609)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.grdModificarMarca)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.chkVehiculo)
        Me.Controls.Add(Me.chkProducto)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblNumeroMarca)
        Me.Controls.Add(Me.btnModificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmModificarMarca"
        Me.Text = "frmModificar"
        CType(Me.grdModificarMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkVehiculo As CheckBox
    Friend WithEvents chkProducto As CheckBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblNumeroMarca As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents grdModificarMarca As DataGridView
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents lblMarca As Label
End Class
