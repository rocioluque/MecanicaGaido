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
        CType(Me.grdModificarFP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFormaDePago
        '
        Me.txtFormaDePago.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaDePago.Location = New System.Drawing.Point(574, 46)
        Me.txtFormaDePago.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFormaDePago.Name = "txtFormaDePago"
        Me.txtFormaDePago.Size = New System.Drawing.Size(308, 24)
        Me.txtFormaDePago.TabIndex = 41
        '
        'lblFormaDePago
        '
        Me.lblFormaDePago.AutoSize = True
        Me.lblFormaDePago.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaDePago.ForeColor = System.Drawing.Color.White
        Me.lblFormaDePago.Location = New System.Drawing.Point(375, 47)
        Me.lblFormaDePago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormaDePago.Name = "lblFormaDePago"
        Me.lblFormaDePago.Size = New System.Drawing.Size(151, 22)
        Me.lblFormaDePago.TabIndex = 42
        Me.lblFormaDePago.Text = "Forma de Pago"
        '
        'chkEstadoFP
        '
        Me.chkEstadoFP.AutoSize = True
        Me.chkEstadoFP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstadoFP.ForeColor = System.Drawing.Color.White
        Me.chkEstadoFP.Location = New System.Drawing.Point(103, 105)
        Me.chkEstadoFP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkEstadoFP.Name = "chkEstadoFP"
        Me.chkEstadoFP.Size = New System.Drawing.Size(108, 25)
        Me.chkEstadoFP.TabIndex = 40
        Me.chkEstadoFP.Text = "¿Activo?"
        Me.chkEstadoFP.UseVisualStyleBackColor = True
        '
        'grdModificarFP
        '
        Me.grdModificarFP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdModificarFP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdModificarFP.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.grdModificarFP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdModificarFP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdModificarFP.Location = New System.Drawing.Point(59, 179)
        Me.grdModificarFP.Margin = New System.Windows.Forms.Padding(4)
        Me.grdModificarFP.Name = "grdModificarFP"
        Me.grdModificarFP.ReadOnly = True
        Me.grdModificarFP.RowHeadersWidth = 51
        Me.grdModificarFP.Size = New System.Drawing.Size(996, 272)
        Me.grdModificarFP.TabIndex = 39
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(993, 105)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(109, 36)
        Me.btnCancelar.TabIndex = 38
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdFP
        '
        Me.txtIdFP.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdFP.Location = New System.Drawing.Point(229, 46)
        Me.txtIdFP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdFP.Name = "txtIdFP"
        Me.txtIdFP.Size = New System.Drawing.Size(83, 24)
        Me.txtIdFP.TabIndex = 35
        '
        'lblNumeroFP
        '
        Me.lblNumeroFP.AutoSize = True
        Me.lblNumeroFP.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroFP.ForeColor = System.Drawing.Color.White
        Me.lblNumeroFP.Location = New System.Drawing.Point(97, 47)
        Me.lblNumeroFP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroFP.Name = "lblNumeroFP"
        Me.lblNumeroFP.Size = New System.Drawing.Size(78, 22)
        Me.lblNumeroFP.TabIndex = 37
        Me.lblNumeroFP.Text = "Código"
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatAppearance.BorderSize = 2
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(993, 36)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(109, 36)
        Me.btnModificar.TabIndex = 36
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'frmModificarFormaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1161, 487)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmModificarFormaPago"
        Me.Text = "frmModificarFormaPago"
        CType(Me.grdModificarFP, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
