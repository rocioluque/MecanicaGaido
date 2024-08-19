<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehiculos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVehiculos))
        Me.grdVehiculo = New System.Windows.Forms.DataGridView()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cboTipoVehiculo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregarTipoVehiculo = New System.Windows.Forms.PictureBox()
        Me.lblDatosVehiculo = New System.Windows.Forms.Label()
        Me.PanelDatoVehiculo = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboPersona = New System.Windows.Forms.ComboBox()
        Me.btnAgregarCuenta = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.btnAgregarMarca = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.PanelNotas = New System.Windows.Forms.Panel()
        Me.txtNota = New System.Windows.Forms.RichTextBox()
        Me.lblIdentificacionVehiculo = New System.Windows.Forms.Label()
        Me.PanelIdentificacionVehiculo = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumChasis = New System.Windows.Forms.TextBox()
        Me.lblNumChasis = New System.Windows.Forms.Label()
        Me.lblNumMotor = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtNumMotor = New System.Windows.Forms.TextBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.grdVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatoVehiculo.SuspendLayout()
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNotas.SuspendLayout()
        Me.PanelIdentificacionVehiculo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdVehiculo
        '
        Me.grdVehiculo.AllowUserToAddRows = False
        Me.grdVehiculo.AllowUserToDeleteRows = False
        Me.grdVehiculo.AllowUserToResizeRows = False
        Me.grdVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdVehiculo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.grdVehiculo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdVehiculo.Location = New System.Drawing.Point(109, 516)
        Me.grdVehiculo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grdVehiculo.Name = "grdVehiculo"
        Me.grdVehiculo.ReadOnly = True
        Me.grdVehiculo.RowHeadersVisible = False
        Me.grdVehiculo.RowHeadersWidth = 51
        Me.grdVehiculo.RowTemplate.Height = 24
        Me.grdVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdVehiculo.Size = New System.Drawing.Size(1021, 262)
        Me.grdVehiculo.TabIndex = 45
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtID.Location = New System.Drawing.Point(280, 60)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(63, 27)
        Me.txtID.TabIndex = 1
        '
        'cboTipoVehiculo
        '
        Me.cboTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboTipoVehiculo.FormattingEnabled = True
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(757, 60)
        Me.cboTipoVehiculo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(295, 29)
        Me.cboTipoVehiculo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(543, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Tipo de vehiculo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(105, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 21)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "N° Vehículo"
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
        Me.btnModificar.Location = New System.Drawing.Point(541, 449)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(156, 46)
        Me.btnModificar.TabIndex = 15
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
        Me.btnCancelar.Location = New System.Drawing.Point(973, 449)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(156, 46)
        Me.btnCancelar.TabIndex = 16
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
        Me.btnAceptar.Location = New System.Drawing.Point(109, 449)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(156, 46)
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
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
        Me.btnBuscar.Location = New System.Drawing.Point(415, 55)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(67, 34)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnAgregarTipoVehiculo
        '
        Me.btnAgregarTipoVehiculo.BackgroundImage = CType(resources.GetObject("btnAgregarTipoVehiculo.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarTipoVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarTipoVehiculo.Location = New System.Drawing.Point(1060, 60)
        Me.btnAgregarTipoVehiculo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarTipoVehiculo.Name = "btnAgregarTipoVehiculo"
        Me.btnAgregarTipoVehiculo.Size = New System.Drawing.Size(35, 31)
        Me.btnAgregarTipoVehiculo.TabIndex = 86
        Me.btnAgregarTipoVehiculo.TabStop = False
        '
        'lblDatosVehiculo
        '
        Me.lblDatosVehiculo.AutoSize = True
        Me.lblDatosVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblDatosVehiculo.ForeColor = System.Drawing.Color.White
        Me.lblDatosVehiculo.Location = New System.Drawing.Point(123, 105)
        Me.lblDatosVehiculo.Name = "lblDatosVehiculo"
        Me.lblDatosVehiculo.Size = New System.Drawing.Size(147, 20)
        Me.lblDatosVehiculo.TabIndex = 114
        Me.lblDatosVehiculo.Text = "Datos del Vehículo"
        '
        'PanelDatoVehiculo
        '
        Me.PanelDatoVehiculo.Controls.Add(Me.Label14)
        Me.PanelDatoVehiculo.Controls.Add(Me.cboPersona)
        Me.PanelDatoVehiculo.Controls.Add(Me.btnAgregarCuenta)
        Me.PanelDatoVehiculo.Controls.Add(Me.Label15)
        Me.PanelDatoVehiculo.Controls.Add(Me.Label10)
        Me.PanelDatoVehiculo.Controls.Add(Me.Label11)
        Me.PanelDatoVehiculo.Controls.Add(Me.cboMarca)
        Me.PanelDatoVehiculo.Controls.Add(Me.btnAgregarMarca)
        Me.PanelDatoVehiculo.Controls.Add(Me.Label3)
        Me.PanelDatoVehiculo.Controls.Add(Me.txtModelo)
        Me.PanelDatoVehiculo.Controls.Add(Me.Label4)
        Me.PanelDatoVehiculo.Controls.Add(Me.Label5)
        Me.PanelDatoVehiculo.Controls.Add(Me.txtNombre)
        Me.PanelDatoVehiculo.Controls.Add(Me.txtColor)
        Me.PanelDatoVehiculo.Controls.Add(Me.Label6)
        Me.PanelDatoVehiculo.Location = New System.Drawing.Point(109, 114)
        Me.PanelDatoVehiculo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelDatoVehiculo.Name = "PanelDatoVehiculo"
        Me.PanelDatoVehiculo.Size = New System.Drawing.Size(372, 314)
        Me.PanelDatoVehiculo.TabIndex = 113
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(83, 20)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 18)
        Me.Label14.TabIndex = 128
        Me.Label14.Text = "*"
        '
        'cboPersona
        '
        Me.cboPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPersona.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboPersona.FormattingEnabled = True
        Me.cboPersona.Location = New System.Drawing.Point(17, 43)
        Me.cboPersona.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboPersona.Name = "cboPersona"
        Me.cboPersona.Size = New System.Drawing.Size(295, 29)
        Me.cboPersona.TabIndex = 4
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.BackgroundImage = CType(resources.GetObject("btnAgregarCuenta.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(320, 43)
        Me.btnAgregarCuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(35, 31)
        Me.btnAgregarCuenta.TabIndex = 127
        Me.btnAgregarCuenta.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(13, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 21)
        Me.Label15.TabIndex = 126
        Me.Label15.Text = "Dueño"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(83, 130)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 18)
        Me.Label10.TabIndex = 124
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(93, 187)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 18)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "*"
        '
        'cboMarca
        '
        Me.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarca.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(17, 154)
        Me.cboMarca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(295, 29)
        Me.cboMarca.TabIndex = 6
        '
        'btnAgregarMarca
        '
        Me.btnAgregarMarca.BackgroundImage = CType(resources.GetObject("btnAgregarMarca.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarMarca.Location = New System.Drawing.Point(320, 154)
        Me.btnAgregarMarca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarMarca.Name = "btnAgregarMarca"
        Me.btnAgregarMarca.Size = New System.Drawing.Size(35, 31)
        Me.btnAgregarMarca.TabIndex = 122
        Me.btnAgregarMarca.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Nombre"
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtModelo.Location = New System.Drawing.Point(17, 210)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(336, 27)
        Me.txtModelo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 21)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Marca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 21)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Modelo"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNombre.Location = New System.Drawing.Point(17, 100)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(336, 27)
        Me.txtNombre.TabIndex = 5
        '
        'txtColor
        '
        Me.txtColor.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtColor.Location = New System.Drawing.Point(17, 265)
        Me.txtColor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(336, 27)
        Me.txtColor.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(13, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 21)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Color"
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblNota.ForeColor = System.Drawing.Color.White
        Me.lblNota.Location = New System.Drawing.Point(541, 329)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(176, 20)
        Me.lblNota.TabIndex = 118
        Me.lblNota.Text = "Notas (250 Caracteres)"
        '
        'PanelNotas
        '
        Me.PanelNotas.Controls.Add(Me.txtNota)
        Me.PanelNotas.Location = New System.Drawing.Point(525, 338)
        Me.PanelNotas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelNotas.Name = "PanelNotas"
        Me.PanelNotas.Size = New System.Drawing.Size(605, 90)
        Me.PanelNotas.TabIndex = 119
        '
        'txtNota
        '
        Me.txtNota.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNota.Location = New System.Drawing.Point(17, 23)
        Me.txtNota.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(551, 48)
        Me.txtNota.TabIndex = 13
        Me.txtNota.Text = ""
        '
        'lblIdentificacionVehiculo
        '
        Me.lblIdentificacionVehiculo.AutoSize = True
        Me.lblIdentificacionVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblIdentificacionVehiculo.ForeColor = System.Drawing.Color.White
        Me.lblIdentificacionVehiculo.Location = New System.Drawing.Point(539, 105)
        Me.lblIdentificacionVehiculo.Name = "lblIdentificacionVehiculo"
        Me.lblIdentificacionVehiculo.Size = New System.Drawing.Size(207, 20)
        Me.lblIdentificacionVehiculo.TabIndex = 121
        Me.lblIdentificacionVehiculo.Text = "Identificación del Vehículo"
        '
        'PanelIdentificacionVehiculo
        '
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.Label12)
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.txtNumChasis)
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.lblNumChasis)
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.lblNumMotor)
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.lblMatricula)
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.chkEstado)
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.txtNumMotor)
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.txtMatricula)
        Me.PanelIdentificacionVehiculo.Location = New System.Drawing.Point(525, 114)
        Me.PanelIdentificacionVehiculo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelIdentificacionVehiculo.Name = "PanelIdentificacionVehiculo"
        Me.PanelIdentificacionVehiculo.Size = New System.Drawing.Size(605, 203)
        Me.PanelIdentificacionVehiculo.TabIndex = 120
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(139, 75)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 18)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = "*"
        '
        'txtNumChasis
        '
        Me.txtNumChasis.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNumChasis.Location = New System.Drawing.Point(232, 30)
        Me.txtNumChasis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumChasis.Name = "txtNumChasis"
        Me.txtNumChasis.Size = New System.Drawing.Size(336, 27)
        Me.txtNumChasis.TabIndex = 9
        '
        'lblNumChasis
        '
        Me.lblNumChasis.AutoSize = True
        Me.lblNumChasis.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumChasis.ForeColor = System.Drawing.Color.White
        Me.lblNumChasis.Location = New System.Drawing.Point(17, 33)
        Me.lblNumChasis.Name = "lblNumChasis"
        Me.lblNumChasis.Size = New System.Drawing.Size(113, 21)
        Me.lblNumChasis.TabIndex = 29
        Me.lblNumChasis.Text = "N° de chasis"
        '
        'lblNumMotor
        '
        Me.lblNumMotor.AutoSize = True
        Me.lblNumMotor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumMotor.ForeColor = System.Drawing.Color.White
        Me.lblNumMotor.Location = New System.Drawing.Point(17, 75)
        Me.lblNumMotor.Name = "lblNumMotor"
        Me.lblNumMotor.Size = New System.Drawing.Size(112, 21)
        Me.lblNumMotor.TabIndex = 30
        Me.lblNumMotor.Text = "N° de motor"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatricula.ForeColor = System.Drawing.Color.White
        Me.lblMatricula.Location = New System.Drawing.Point(17, 117)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(90, 21)
        Me.lblMatricula.TabIndex = 31
        Me.lblMatricula.Text = "Matricula"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(21, 159)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(108, 25)
        Me.chkEstado.TabIndex = 12
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'txtNumMotor
        '
        Me.txtNumMotor.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNumMotor.Location = New System.Drawing.Point(232, 71)
        Me.txtNumMotor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNumMotor.Name = "txtNumMotor"
        Me.txtNumMotor.Size = New System.Drawing.Size(336, 27)
        Me.txtNumMotor.TabIndex = 10
        '
        'txtMatricula
        '
        Me.txtMatricula.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMatricula.Location = New System.Drawing.Point(232, 113)
        Me.txtMatricula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(336, 27)
        Me.txtMatricula.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(699, 64)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 33)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "*"
        '
        'frmVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1297, 715)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblIdentificacionVehiculo)
        Me.Controls.Add(Me.PanelIdentificacionVehiculo)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.PanelNotas)
        Me.Controls.Add(Me.lblDatosVehiculo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelDatoVehiculo)
        Me.Controls.Add(Me.btnAgregarTipoVehiculo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cboTipoVehiculo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.grdVehiculo)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmVehiculos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehiculos"
        CType(Me.grdVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatoVehiculo.ResumeLayout(False)
        Me.PanelDatoVehiculo.PerformLayout()
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNotas.ResumeLayout(False)
        Me.PanelIdentificacionVehiculo.ResumeLayout(False)
        Me.PanelIdentificacionVehiculo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdVehiculo As DataGridView
    Friend WithEvents txtID As TextBox
    Friend WithEvents cboTipoVehiculo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAgregarTipoVehiculo As PictureBox
    Friend WithEvents lblDatosVehiculo As Label
    Friend WithEvents PanelDatoVehiculo As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents cboPersona As ComboBox
    Friend WithEvents btnAgregarCuenta As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents btnAgregarMarca As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNota As Label
    Friend WithEvents PanelNotas As Panel
    Friend WithEvents txtNota As RichTextBox
    Friend WithEvents lblIdentificacionVehiculo As Label
    Friend WithEvents PanelIdentificacionVehiculo As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNumChasis As TextBox
    Friend WithEvents lblNumChasis As Label
    Friend WithEvents lblNumMotor As Label
    Friend WithEvents lblMatricula As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents txtNumMotor As TextBox
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents Label7 As Label
End Class
