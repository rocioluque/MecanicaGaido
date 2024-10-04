<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgregarDatosFiscales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarDatosFiscales))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtIngresosBrutos = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.grdCuenta = New System.Windows.Forms.DataGridView()
        Me.lblNombreResultado = New System.Windows.Forms.Label()
        Me.lblDocumentoResultado = New System.Windows.Forms.Label()
        Me.dtpFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.lblDetallesTributarios = New System.Windows.Forms.Label()
        Me.PanelDetallesTributarios = New System.Windows.Forms.Panel()
        Me.lblInformacionFiscal = New System.Windows.Forms.Label()
        Me.PanelInformacionFiscal = New System.Windows.Forms.Panel()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetallesTributarios.SuspendLayout()
        Me.PanelInformacionFiscal.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Location = New System.Drawing.Point(715, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(20, 20)
        Me.btnCerrar.TabIndex = 62
        Me.btnCerrar.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(12, 21)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(90, 34)
        Me.lblNombre.TabIndex = 73
        Me.lblNombre.Text = "Nombre /" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Razón Social"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(295, 30)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 28)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtIngresosBrutos
        '
        Me.txtIngresosBrutos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresosBrutos.Location = New System.Drawing.Point(118, 20)
        Me.txtIngresosBrutos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIngresosBrutos.Name = "txtIngresosBrutos"
        Me.txtIngresosBrutos.Size = New System.Drawing.Size(133, 23)
        Me.txtIngresosBrutos.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(184, 34)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(72, 23)
        Me.txtID.TabIndex = 1
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(13, 111)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(85, 21)
        Me.chkEstado.TabIndex = 6
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 53)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Fecha Alta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Ingresos Brutos"
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.ForeColor = System.Drawing.Color.White
        Me.lblDocumento.Location = New System.Drawing.Point(12, 65)
        Me.lblDocumento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(86, 17)
        Me.lblDocumento.TabIndex = 64
        Me.lblDocumento.Text = "Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "N° Dato Fiscal"
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(118, 79)
        Me.txtSaldo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(133, 23)
        Me.txtSaldo.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(10, 82)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Saldo"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(296, 199)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(117, 37)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(543, 199)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 37)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(49, 199)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 37)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'grdCuenta
        '
        Me.grdCuenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdCuenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.grdCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCuenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCuenta.GridColor = System.Drawing.Color.DarkGray
        Me.grdCuenta.Location = New System.Drawing.Point(49, 268)
        Me.grdCuenta.Name = "grdCuenta"
        Me.grdCuenta.ReadOnly = True
        Me.grdCuenta.RowHeadersWidth = 51
        Me.grdCuenta.Size = New System.Drawing.Size(611, 176)
        Me.grdCuenta.TabIndex = 82
        '
        'lblNombreResultado
        '
        Me.lblNombreResultado.AutoSize = True
        Me.lblNombreResultado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreResultado.ForeColor = System.Drawing.Color.White
        Me.lblNombreResultado.Location = New System.Drawing.Point(113, 24)
        Me.lblNombreResultado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreResultado.Name = "lblNombreResultado"
        Me.lblNombreResultado.Size = New System.Drawing.Size(0, 17)
        Me.lblNombreResultado.TabIndex = 83
        '
        'lblDocumentoResultado
        '
        Me.lblDocumentoResultado.AutoSize = True
        Me.lblDocumentoResultado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentoResultado.ForeColor = System.Drawing.Color.White
        Me.lblDocumentoResultado.Location = New System.Drawing.Point(113, 65)
        Me.lblDocumentoResultado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDocumentoResultado.Name = "lblDocumentoResultado"
        Me.lblDocumentoResultado.Size = New System.Drawing.Size(0, 17)
        Me.lblDocumentoResultado.TabIndex = 84
        '
        'dtpFechaAlta
        '
        Me.dtpFechaAlta.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAlta.Location = New System.Drawing.Point(118, 48)
        Me.dtpFechaAlta.Name = "dtpFechaAlta"
        Me.dtpFechaAlta.Size = New System.Drawing.Size(133, 23)
        Me.dtpFechaAlta.TabIndex = 4
        Me.dtpFechaAlta.Value = New Date(2024, 7, 25, 0, 0, 0, 0)
        '
        'lblDetallesTributarios
        '
        Me.lblDetallesTributarios.AutoSize = True
        Me.lblDetallesTributarios.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblDetallesTributarios.ForeColor = System.Drawing.Color.White
        Me.lblDetallesTributarios.Location = New System.Drawing.Point(404, 23)
        Me.lblDetallesTributarios.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDetallesTributarios.Name = "lblDetallesTributarios"
        Me.lblDetallesTributarios.Size = New System.Drawing.Size(120, 17)
        Me.lblDetallesTributarios.TabIndex = 85
        Me.lblDetallesTributarios.Text = "Detalles Tributarios"
        '
        'PanelDetallesTributarios
        '
        Me.PanelDetallesTributarios.Controls.Add(Me.txtIngresosBrutos)
        Me.PanelDetallesTributarios.Controls.Add(Me.Label3)
        Me.PanelDetallesTributarios.Controls.Add(Me.chkEstado)
        Me.PanelDetallesTributarios.Controls.Add(Me.dtpFechaAlta)
        Me.PanelDetallesTributarios.Controls.Add(Me.Label4)
        Me.PanelDetallesTributarios.Controls.Add(Me.Label7)
        Me.PanelDetallesTributarios.Controls.Add(Me.txtSaldo)
        Me.PanelDetallesTributarios.Location = New System.Drawing.Point(392, 31)
        Me.PanelDetallesTributarios.Name = "PanelDetallesTributarios"
        Me.PanelDetallesTributarios.Size = New System.Drawing.Size(268, 151)
        Me.PanelDetallesTributarios.TabIndex = 86
        '
        'lblInformacionFiscal
        '
        Me.lblInformacionFiscal.AutoSize = True
        Me.lblInformacionFiscal.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblInformacionFiscal.ForeColor = System.Drawing.Color.White
        Me.lblInformacionFiscal.Location = New System.Drawing.Point(61, 69)
        Me.lblInformacionFiscal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInformacionFiscal.Name = "lblInformacionFiscal"
        Me.lblInformacionFiscal.Size = New System.Drawing.Size(115, 17)
        Me.lblInformacionFiscal.TabIndex = 87
        Me.lblInformacionFiscal.Text = "Información Fiscal"
        '
        'PanelInformacionFiscal
        '
        Me.PanelInformacionFiscal.Controls.Add(Me.lblNombre)
        Me.PanelInformacionFiscal.Controls.Add(Me.lblDocumento)
        Me.PanelInformacionFiscal.Controls.Add(Me.lblNombreResultado)
        Me.PanelInformacionFiscal.Controls.Add(Me.lblDocumentoResultado)
        Me.PanelInformacionFiscal.Location = New System.Drawing.Point(49, 77)
        Me.PanelInformacionFiscal.Name = "PanelInformacionFiscal"
        Me.PanelInformacionFiscal.Size = New System.Drawing.Size(296, 105)
        Me.PanelInformacionFiscal.TabIndex = 88
        '
        'frmAgregarDatosFiscales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(752, 407)
        Me.Controls.Add(Me.lblInformacionFiscal)
        Me.Controls.Add(Me.PanelInformacionFiscal)
        Me.Controls.Add(Me.lblDetallesTributarios)
        Me.Controls.Add(Me.PanelDetallesTributarios)
        Me.Controls.Add(Me.grdCuenta)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarDatosFiscales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cuentas Corrientes"
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetallesTributarios.ResumeLayout(False)
        Me.PanelDetallesTributarios.PerformLayout()
        Me.PanelInformacionFiscal.ResumeLayout(False)
        Me.PanelInformacionFiscal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtIngresosBrutos As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDocumento As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents grdCuenta As DataGridView
    Friend WithEvents lblNombreResultado As Label
    Friend WithEvents lblDocumentoResultado As Label
    Friend WithEvents dtpFechaAlta As DateTimePicker
    Friend WithEvents lblDetallesTributarios As Label
    Friend WithEvents PanelDetallesTributarios As Panel
    Friend WithEvents lblInformacionFiscal As Label
    Friend WithEvents PanelInformacionFiscal As Panel
End Class
