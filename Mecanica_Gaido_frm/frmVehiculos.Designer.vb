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
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.txtNumotor = New System.Windows.Forms.TextBox()
        Me.txtNumchasis = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.cboTipoVehiculo = New System.Windows.Forms.ComboBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregarTipoVehiculo = New System.Windows.Forms.PictureBox()
        Me.btnAgregarMarca = New System.Windows.Forms.PictureBox()
        Me.lblDatosVehiculo = New System.Windows.Forms.Label()
        Me.PanelDatoVehiculo = New System.Windows.Forms.Panel()
        Me.lblIdentificacionVehiculo = New System.Windows.Forms.Label()
        Me.PanelIdentificacionVehiculo = New System.Windows.Forms.Panel()
        CType(Me.grdVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatoVehiculo.SuspendLayout()
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
        Me.grdVehiculo.Location = New System.Drawing.Point(95, 336)
        Me.grdVehiculo.Margin = New System.Windows.Forms.Padding(2)
        Me.grdVehiculo.Name = "grdVehiculo"
        Me.grdVehiculo.ReadOnly = True
        Me.grdVehiculo.RowHeadersVisible = False
        Me.grdVehiculo.RowHeadersWidth = 51
        Me.grdVehiculo.RowTemplate.Height = 24
        Me.grdVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdVehiculo.Size = New System.Drawing.Size(766, 243)
        Me.grdVehiculo.TabIndex = 45
        '
        'txtMatricula
        '
        Me.txtMatricula.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMatricula.Location = New System.Drawing.Point(156, 92)
        Me.txtMatricula.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(253, 23)
        Me.txtMatricula.TabIndex = 10
        '
        'txtNumotor
        '
        Me.txtNumotor.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNumotor.Location = New System.Drawing.Point(156, 58)
        Me.txtNumotor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumotor.Name = "txtNumotor"
        Me.txtNumotor.Size = New System.Drawing.Size(253, 23)
        Me.txtNumotor.TabIndex = 9
        '
        'txtNumchasis
        '
        Me.txtNumchasis.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNumchasis.Location = New System.Drawing.Point(156, 24)
        Me.txtNumchasis.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumchasis.Name = "txtNumchasis"
        Me.txtNumchasis.Size = New System.Drawing.Size(253, 23)
        Me.txtNumchasis.TabIndex = 8
        '
        'txtColor
        '
        Me.txtColor.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtColor.Location = New System.Drawing.Point(13, 172)
        Me.txtColor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(253, 23)
        Me.txtColor.TabIndex = 7
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtModelo.Location = New System.Drawing.Point(13, 128)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(253, 23)
        Me.txtModelo.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNombre.Location = New System.Drawing.Point(13, 84)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(253, 23)
        Me.txtNombre.TabIndex = 5
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtID.Location = New System.Drawing.Point(210, 49)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(48, 23)
        Me.txtID.TabIndex = 1
        '
        'cboMarca
        '
        Me.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarca.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(13, 38)
        Me.cboMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(222, 25)
        Me.cboMarca.TabIndex = 4
        '
        'cboTipoVehiculo
        '
        Me.cboTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboTipoVehiculo.FormattingEnabled = True
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(550, 49)
        Me.cboTipoVehiculo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(222, 25)
        Me.cboTipoVehiculo.TabIndex = 3
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(16, 129)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(85, 21)
        Me.chkEstado.TabIndex = 11
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(13, 95)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Matricula"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(13, 61)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Numero de motor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(13, 27)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 17)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Numero de chasis"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 153)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 109)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Modelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 65)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(407, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Tipo de vehiculo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
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
        Me.btnModificar.Location = New System.Drawing.Point(562, 269)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(117, 37)
        Me.btnModificar.TabIndex = 13
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
        Me.btnCancelar.Location = New System.Drawing.Point(731, 269)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 37)
        Me.btnCancelar.TabIndex = 14
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
        Me.btnAceptar.Location = New System.Drawing.Point(394, 269)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 37)
        Me.btnAceptar.TabIndex = 12
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
        Me.btnBuscar.Location = New System.Drawing.Point(311, 45)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 28)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnAgregarTipoVehiculo
        '
        Me.btnAgregarTipoVehiculo.BackgroundImage = CType(resources.GetObject("btnAgregarTipoVehiculo.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarTipoVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarTipoVehiculo.Location = New System.Drawing.Point(777, 49)
        Me.btnAgregarTipoVehiculo.Name = "btnAgregarTipoVehiculo"
        Me.btnAgregarTipoVehiculo.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarTipoVehiculo.TabIndex = 86
        Me.btnAgregarTipoVehiculo.TabStop = False
        '
        'btnAgregarMarca
        '
        Me.btnAgregarMarca.BackgroundImage = CType(resources.GetObject("btnAgregarMarca.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarMarca.Location = New System.Drawing.Point(240, 38)
        Me.btnAgregarMarca.Name = "btnAgregarMarca"
        Me.btnAgregarMarca.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarMarca.TabIndex = 87
        Me.btnAgregarMarca.TabStop = False
        '
        'lblDatosVehiculo
        '
        Me.lblDatosVehiculo.AutoSize = True
        Me.lblDatosVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblDatosVehiculo.ForeColor = System.Drawing.Color.White
        Me.lblDatosVehiculo.Location = New System.Drawing.Point(92, 85)
        Me.lblDatosVehiculo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDatosVehiculo.Name = "lblDatosVehiculo"
        Me.lblDatosVehiculo.Size = New System.Drawing.Size(121, 17)
        Me.lblDatosVehiculo.TabIndex = 114
        Me.lblDatosVehiculo.Text = "Datos del Vehículo"
        '
        'PanelDatoVehiculo
        '
        Me.PanelDatoVehiculo.Controls.Add(Me.cboMarca)
        Me.PanelDatoVehiculo.Controls.Add(Me.btnAgregarMarca)
        Me.PanelDatoVehiculo.Controls.Add(Me.Label3)
        Me.PanelDatoVehiculo.Controls.Add(Me.txtModelo)
        Me.PanelDatoVehiculo.Controls.Add(Me.Label4)
        Me.PanelDatoVehiculo.Controls.Add(Me.Label5)
        Me.PanelDatoVehiculo.Controls.Add(Me.txtNombre)
        Me.PanelDatoVehiculo.Controls.Add(Me.txtColor)
        Me.PanelDatoVehiculo.Controls.Add(Me.Label6)
        Me.PanelDatoVehiculo.Location = New System.Drawing.Point(82, 93)
        Me.PanelDatoVehiculo.Name = "PanelDatoVehiculo"
        Me.PanelDatoVehiculo.Size = New System.Drawing.Size(279, 213)
        Me.PanelDatoVehiculo.TabIndex = 113
        '
        'lblIdentificacionVehiculo
        '
        Me.lblIdentificacionVehiculo.AutoSize = True
        Me.lblIdentificacionVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblIdentificacionVehiculo.ForeColor = System.Drawing.Color.White
        Me.lblIdentificacionVehiculo.Location = New System.Drawing.Point(404, 85)
        Me.lblIdentificacionVehiculo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIdentificacionVehiculo.Name = "lblIdentificacionVehiculo"
        Me.lblIdentificacionVehiculo.Size = New System.Drawing.Size(169, 17)
        Me.lblIdentificacionVehiculo.TabIndex = 116
        Me.lblIdentificacionVehiculo.Text = "Identificación del Vehículo"
        '
        'PanelIdentificacionVehiculo
        '
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.txtNumchasis)
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.Label7)
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.Label8)
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.Label9)
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.chkEstado)
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.txtNumotor)
        Me.PanelIdentificacionVehiculo.Controls.Add(Me.txtMatricula)
        Me.PanelIdentificacionVehiculo.Location = New System.Drawing.Point(394, 93)
        Me.PanelIdentificacionVehiculo.Name = "PanelIdentificacionVehiculo"
        Me.PanelIdentificacionVehiculo.Size = New System.Drawing.Size(454, 165)
        Me.PanelIdentificacionVehiculo.TabIndex = 115
        '
        'frmVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(939, 581)
        Me.Controls.Add(Me.lblIdentificacionVehiculo)
        Me.Controls.Add(Me.PanelIdentificacionVehiculo)
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
        Me.Name = "frmVehiculos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehiculos"
        CType(Me.grdVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatoVehiculo.ResumeLayout(False)
        Me.PanelDatoVehiculo.PerformLayout()
        Me.PanelIdentificacionVehiculo.ResumeLayout(False)
        Me.PanelIdentificacionVehiculo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdVehiculo As DataGridView
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents txtNumotor As TextBox
    Friend WithEvents txtNumchasis As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents cboTipoVehiculo As ComboBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAgregarTipoVehiculo As PictureBox
    Friend WithEvents btnAgregarMarca As PictureBox
    Friend WithEvents lblDatosVehiculo As Label
    Friend WithEvents PanelDatoVehiculo As Panel
    Friend WithEvents lblIdentificacionVehiculo As Label
    Friend WithEvents PanelIdentificacionVehiculo As Panel
End Class
