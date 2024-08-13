<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPersonas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonas))
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnDatoFiscal = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.grdPersonas = New System.Windows.Forms.DataGridView()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.lblTipoPersona = New System.Windows.Forms.Label()
        Me.cboTipoPersona = New System.Windows.Forms.ComboBox()
        Me.PanelDatosPersonales = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.txtNumeroDocumento = New System.Windows.Forms.TextBox()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.PanelDirecciones = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.lblTelefonoFijo = New System.Windows.Forms.Label()
        Me.txtTelefonoFijo = New System.Windows.Forms.TextBox()
        Me.lblLetra = New System.Windows.Forms.Label()
        Me.txtLetraPuerta = New System.Windows.Forms.TextBox()
        Me.lblPiso = New System.Windows.Forms.Label()
        Me.txtPiso = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboCiudad = New System.Windows.Forms.ComboBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.btnAgregarCiudad = New System.Windows.Forms.PictureBox()
        Me.lblTelefonoMovil = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefonoMovil = New System.Windows.Forms.TextBox()
        Me.lblDirecciones = New System.Windows.Forms.Label()
        Me.lblDatosPersonales = New System.Windows.Forms.Label()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.PanelNotas = New System.Windows.Forms.Panel()
        Me.txtNota = New System.Windows.Forms.RichTextBox()
        CType(Me.grdPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatosPersonales.SuspendLayout()
        Me.PanelDirecciones.SuspendLayout()
        CType(Me.btnAgregarCiudad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNotas.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(257, 40)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(26, 23)
        Me.txtID.TabIndex = 1
        Me.txtID.Tag = ""
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblId.ForeColor = System.Drawing.Color.White
        Me.lblId.Location = New System.Drawing.Point(135, 43)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(72, 17)
        Me.lblId.TabIndex = 18
        Me.lblId.Text = "N° Persona"
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
        Me.btnBuscar.Location = New System.Drawing.Point(317, 36)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(56, 28)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEmpleados
        '
        Me.btnEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.ForeColor = System.Drawing.Color.White
        Me.btnEmpleados.Location = New System.Drawing.Point(317, 426)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(100, 37)
        Me.btnEmpleados.TabIndex = 23
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.UseVisualStyleBackColor = False
        '
        'btnDatoFiscal
        '
        Me.btnDatoFiscal.BackColor = System.Drawing.Color.Transparent
        Me.btnDatoFiscal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDatoFiscal.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnDatoFiscal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnDatoFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDatoFiscal.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatoFiscal.ForeColor = System.Drawing.Color.White
        Me.btnDatoFiscal.Location = New System.Drawing.Point(138, 426)
        Me.btnDatoFiscal.Name = "btnDatoFiscal"
        Me.btnDatoFiscal.Size = New System.Drawing.Size(100, 37)
        Me.btnDatoFiscal.TabIndex = 22
        Me.btnDatoFiscal.Text = "Datos Fiscales"
        Me.btnDatoFiscal.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(854, 426)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 37)
        Me.btnCancelar.TabIndex = 21
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
        Me.btnAceptar.Location = New System.Drawing.Point(496, 426)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(100, 37)
        Me.btnAceptar.TabIndex = 19
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'grdPersonas
        '
        Me.grdPersonas.AllowUserToAddRows = False
        Me.grdPersonas.AllowUserToDeleteRows = False
        Me.grdPersonas.AllowUserToResizeRows = False
        Me.grdPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdPersonas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.grdPersonas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdPersonas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPersonas.Location = New System.Drawing.Point(138, 498)
        Me.grdPersonas.Name = "grdPersonas"
        Me.grdPersonas.ReadOnly = True
        Me.grdPersonas.RowHeadersVisible = False
        Me.grdPersonas.RowHeadersWidth = 51
        Me.grdPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdPersonas.Size = New System.Drawing.Size(834, 297)
        Me.grdPersonas.TabIndex = 60
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
        Me.btnModificar.Location = New System.Drawing.Point(675, 426)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(100, 37)
        Me.btnModificar.TabIndex = 20
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'lblTipoPersona
        '
        Me.lblTipoPersona.AutoSize = True
        Me.lblTipoPersona.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblTipoPersona.ForeColor = System.Drawing.Color.White
        Me.lblTipoPersona.Location = New System.Drawing.Point(135, 87)
        Me.lblTipoPersona.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoPersona.Name = "lblTipoPersona"
        Me.lblTipoPersona.Size = New System.Drawing.Size(101, 17)
        Me.lblTipoPersona.TabIndex = 49
        Me.lblTipoPersona.Text = "Tipo de Persona"
        '
        'cboTipoPersona
        '
        Me.cboTipoPersona.DisplayMember = "Nombre"
        Me.cboTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoPersona.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPersona.FormattingEnabled = True
        Me.cboTipoPersona.Location = New System.Drawing.Point(257, 79)
        Me.cboTipoPersona.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipoPersona.Name = "cboTipoPersona"
        Me.cboTipoPersona.Size = New System.Drawing.Size(116, 25)
        Me.cboTipoPersona.TabIndex = 3
        Me.cboTipoPersona.ValueMember = "ID_Provincia"
        '
        'PanelDatosPersonales
        '
        Me.PanelDatosPersonales.Controls.Add(Me.Label3)
        Me.PanelDatosPersonales.Controls.Add(Me.Label2)
        Me.PanelDatosPersonales.Controls.Add(Me.Label1)
        Me.PanelDatosPersonales.Controls.Add(Me.cboTipoDocumento)
        Me.PanelDatosPersonales.Controls.Add(Me.dtpFechaNacimiento)
        Me.PanelDatosPersonales.Controls.Add(Me.lblNumeroDocumento)
        Me.PanelDatosPersonales.Controls.Add(Me.txtNumeroDocumento)
        Me.PanelDatosPersonales.Controls.Add(Me.lblFechaNacimiento)
        Me.PanelDatosPersonales.Controls.Add(Me.lblTipoDocumento)
        Me.PanelDatosPersonales.Controls.Add(Me.txtNombre)
        Me.PanelDatosPersonales.Controls.Add(Me.lblNombre)
        Me.PanelDatosPersonales.Controls.Add(Me.lblApellido)
        Me.PanelDatosPersonales.Controls.Add(Me.txtApellido)
        Me.PanelDatosPersonales.Location = New System.Drawing.Point(138, 124)
        Me.PanelDatosPersonales.Name = "PanelDatosPersonales"
        Me.PanelDatosPersonales.Size = New System.Drawing.Size(235, 283)
        Me.PanelDatosPersonales.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(143, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 15)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(165, 209)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 15)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(162, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 15)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "*"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DisplayMember = "Nombre"
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(17, 181)
        Me.cboTipoDocumento.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(220, 25)
        Me.cboTipoDocumento.TabIndex = 7
        Me.cboTipoDocumento.ValueMember = "ID_Provincia"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(17, 135)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(220, 23)
        Me.dtpFechaNacimiento.TabIndex = 6
        Me.dtpFechaNacimiento.Value = New Date(2024, 7, 18, 0, 0, 0, 0)
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.AutoSize = True
        Me.lblNumeroDocumento.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblNumeroDocumento.ForeColor = System.Drawing.Color.White
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(14, 209)
        Me.lblNumeroDocumento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(148, 17)
        Me.lblNumeroDocumento.TabIndex = 53
        Me.lblNumeroDocumento.Text = "Numero de Documento"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(17, 229)
        Me.txtNumeroDocumento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(220, 23)
        Me.txtNumeroDocumento.TabIndex = 8
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblFechaNacimiento.ForeColor = System.Drawing.Color.White
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(14, 115)
        Me.lblFechaNacimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(137, 17)
        Me.lblFechaNacimiento.TabIndex = 50
        Me.lblFechaNacimiento.Text = "Fecha de Nacimiento"
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblTipoDocumento.ForeColor = System.Drawing.Color.White
        Me.lblTipoDocumento.Location = New System.Drawing.Point(15, 161)
        Me.lblTipoDocumento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(125, 17)
        Me.lblTipoDocumento.TabIndex = 51
        Me.lblTipoDocumento.Text = "Tipo de Documento"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(17, 43)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(220, 23)
        Me.txtNombre.TabIndex = 4
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(14, 23)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(145, 17)
        Me.lblNombre.TabIndex = 48
        Me.lblNombre.Text = "Nombre o Razón Social"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblApellido.ForeColor = System.Drawing.Color.White
        Me.lblApellido.Location = New System.Drawing.Point(14, 69)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(58, 17)
        Me.lblApellido.TabIndex = 49
        Me.lblApellido.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(17, 89)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(220, 23)
        Me.txtApellido.TabIndex = 5
        '
        'PanelDirecciones
        '
        Me.PanelDirecciones.Controls.Add(Me.Label10)
        Me.PanelDirecciones.Controls.Add(Me.Label8)
        Me.PanelDirecciones.Controls.Add(Me.Label6)
        Me.PanelDirecciones.Controls.Add(Me.Label4)
        Me.PanelDirecciones.Controls.Add(Me.lblCodigoPostal)
        Me.PanelDirecciones.Controls.Add(Me.txtCodigoPostal)
        Me.PanelDirecciones.Controls.Add(Me.lblTelefonoFijo)
        Me.PanelDirecciones.Controls.Add(Me.txtTelefonoFijo)
        Me.PanelDirecciones.Controls.Add(Me.lblLetra)
        Me.PanelDirecciones.Controls.Add(Me.txtLetraPuerta)
        Me.PanelDirecciones.Controls.Add(Me.lblPiso)
        Me.PanelDirecciones.Controls.Add(Me.txtPiso)
        Me.PanelDirecciones.Controls.Add(Me.lblNumero)
        Me.PanelDirecciones.Controls.Add(Me.txtNumero)
        Me.PanelDirecciones.Controls.Add(Me.lblDireccion)
        Me.PanelDirecciones.Controls.Add(Me.Label7)
        Me.PanelDirecciones.Controls.Add(Me.cboCiudad)
        Me.PanelDirecciones.Controls.Add(Me.chkEstado)
        Me.PanelDirecciones.Controls.Add(Me.Label9)
        Me.PanelDirecciones.Controls.Add(Me.cboProvincia)
        Me.PanelDirecciones.Controls.Add(Me.txtDireccion)
        Me.PanelDirecciones.Controls.Add(Me.txtCorreo)
        Me.PanelDirecciones.Controls.Add(Me.btnAgregarCiudad)
        Me.PanelDirecciones.Controls.Add(Me.lblTelefonoMovil)
        Me.PanelDirecciones.Controls.Add(Me.Label5)
        Me.PanelDirecciones.Controls.Add(Me.txtTelefonoMovil)
        Me.PanelDirecciones.Location = New System.Drawing.Point(421, 39)
        Me.PanelDirecciones.Name = "PanelDirecciones"
        Me.PanelDirecciones.Size = New System.Drawing.Size(532, 267)
        Me.PanelDirecciones.TabIndex = 77
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(412, 135)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 15)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "*"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(137, 23)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 15)
        Me.Label8.TabIndex = 113
        Me.Label8.Text = "*"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(70, 79)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 15)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "*"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(307, 135)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 15)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "*"
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.AutoSize = True
        Me.lblCodigoPostal.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblCodigoPostal.ForeColor = System.Drawing.Color.White
        Me.lblCodigoPostal.Location = New System.Drawing.Point(213, 135)
        Me.lblCodigoPostal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(91, 17)
        Me.lblCodigoPostal.TabIndex = 76
        Me.lblCodigoPostal.Text = "Código Postal"
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoPostal.Location = New System.Drawing.Point(216, 162)
        Me.txtCodigoPostal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(88, 23)
        Me.txtCodigoPostal.TabIndex = 15
        '
        'lblTelefonoFijo
        '
        Me.lblTelefonoFijo.AutoSize = True
        Me.lblTelefonoFijo.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblTelefonoFijo.ForeColor = System.Drawing.Color.White
        Me.lblTelefonoFijo.Location = New System.Drawing.Point(360, 79)
        Me.lblTelefonoFijo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefonoFijo.Name = "lblTelefonoFijo"
        Me.lblTelefonoFijo.Size = New System.Drawing.Size(147, 17)
        Me.lblTelefonoFijo.TabIndex = 74
        Me.lblTelefonoFijo.Text = "Teléfono Fijo (opcional)"
        '
        'txtTelefonoFijo
        '
        Me.txtTelefonoFijo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoFijo.Location = New System.Drawing.Point(363, 104)
        Me.txtTelefonoFijo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefonoFijo.Name = "txtTelefonoFijo"
        Me.txtTelefonoFijo.Size = New System.Drawing.Size(174, 23)
        Me.txtTelefonoFijo.TabIndex = 17
        '
        'lblLetra
        '
        Me.lblLetra.AutoSize = True
        Me.lblLetra.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblLetra.ForeColor = System.Drawing.Color.White
        Me.lblLetra.Location = New System.Drawing.Point(213, 79)
        Me.lblLetra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLetra.Name = "lblLetra"
        Me.lblLetra.Size = New System.Drawing.Size(83, 17)
        Me.lblLetra.TabIndex = 72
        Me.lblLetra.Text = "Letra/Puerta"
        '
        'txtLetraPuerta
        '
        Me.txtLetraPuerta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLetraPuerta.Location = New System.Drawing.Point(216, 104)
        Me.txtLetraPuerta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLetraPuerta.Name = "txtLetraPuerta"
        Me.txtLetraPuerta.Size = New System.Drawing.Size(88, 23)
        Me.txtLetraPuerta.TabIndex = 12
        '
        'lblPiso
        '
        Me.lblPiso.AutoSize = True
        Me.lblPiso.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblPiso.ForeColor = System.Drawing.Color.White
        Me.lblPiso.Location = New System.Drawing.Point(112, 79)
        Me.lblPiso.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPiso.Name = "lblPiso"
        Me.lblPiso.Size = New System.Drawing.Size(31, 17)
        Me.lblPiso.TabIndex = 70
        Me.lblPiso.Text = "Piso"
        '
        'txtPiso
        '
        Me.txtPiso.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPiso.Location = New System.Drawing.Point(115, 104)
        Me.txtPiso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(58, 23)
        Me.txtPiso.TabIndex = 11
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblNumero.ForeColor = System.Drawing.Color.White
        Me.lblNumero.Location = New System.Drawing.Point(12, 79)
        Me.lblNumero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(55, 17)
        Me.lblNumero.TabIndex = 68
        Me.lblNumero.Text = "Número"
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(15, 104)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(58, 23)
        Me.txtNumero.TabIndex = 10
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblDireccion.ForeColor = System.Drawing.Color.White
        Me.lblDireccion.Location = New System.Drawing.Point(12, 23)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(122, 17)
        Me.lblDireccion.TabIndex = 63
        Me.lblDireccion.Text = "Nombre de la calle"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 135)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Ciudad"
        '
        'cboCiudad
        '
        Me.cboCiudad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCiudad.FormattingEnabled = True
        Me.cboCiudad.Location = New System.Drawing.Point(15, 160)
        Me.cboCiudad.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCiudad.Name = "cboCiudad"
        Me.cboCiudad.Size = New System.Drawing.Size(133, 25)
        Me.cboCiudad.TabIndex = 14
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(363, 218)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(85, 21)
        Me.chkEstado.TabIndex = 60
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 193)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 17)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Provincia"
        '
        'cboProvincia
        '
        Me.cboProvincia.DisplayMember = "Nombre"
        Me.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvincia.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(15, 218)
        Me.cboProvincia.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(164, 25)
        Me.cboProvincia.TabIndex = 13
        Me.cboProvincia.ValueMember = "ID_Provincia"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(15, 48)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(287, 23)
        Me.txtDireccion.TabIndex = 9
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(363, 162)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(174, 23)
        Me.txtCorreo.TabIndex = 17
        '
        'btnAgregarCiudad
        '
        Me.btnAgregarCiudad.BackgroundImage = CType(resources.GetObject("btnAgregarCiudad.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarCiudad.Location = New System.Drawing.Point(153, 160)
        Me.btnAgregarCiudad.Name = "btnAgregarCiudad"
        Me.btnAgregarCiudad.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarCiudad.TabIndex = 66
        Me.btnAgregarCiudad.TabStop = False
        '
        'lblTelefonoMovil
        '
        Me.lblTelefonoMovil.AutoSize = True
        Me.lblTelefonoMovil.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblTelefonoMovil.ForeColor = System.Drawing.Color.White
        Me.lblTelefonoMovil.Location = New System.Drawing.Point(360, 23)
        Me.lblTelefonoMovil.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefonoMovil.Name = "lblTelefonoMovil"
        Me.lblTelefonoMovil.Size = New System.Drawing.Size(95, 17)
        Me.lblTelefonoMovil.TabIndex = 61
        Me.lblTelefonoMovil.Text = "Teléfono Móvil"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(360, 135)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Correo"
        '
        'txtTelefonoMovil
        '
        Me.txtTelefonoMovil.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoMovil.Location = New System.Drawing.Point(363, 48)
        Me.txtTelefonoMovil.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefonoMovil.Name = "txtTelefonoMovil"
        Me.txtTelefonoMovil.Size = New System.Drawing.Size(174, 23)
        Me.txtTelefonoMovil.TabIndex = 16
        '
        'lblDirecciones
        '
        Me.lblDirecciones.AutoSize = True
        Me.lblDirecciones.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblDirecciones.ForeColor = System.Drawing.Color.White
        Me.lblDirecciones.Location = New System.Drawing.Point(433, 31)
        Me.lblDirecciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDirecciones.Name = "lblDirecciones"
        Me.lblDirecciones.Size = New System.Drawing.Size(79, 17)
        Me.lblDirecciones.TabIndex = 0
        Me.lblDirecciones.Text = "Direcciones"
        '
        'lblDatosPersonales
        '
        Me.lblDatosPersonales.AutoSize = True
        Me.lblDatosPersonales.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblDatosPersonales.ForeColor = System.Drawing.Color.White
        Me.lblDatosPersonales.Location = New System.Drawing.Point(150, 116)
        Me.lblDatosPersonales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDatosPersonales.Name = "lblDatosPersonales"
        Me.lblDatosPersonales.Size = New System.Drawing.Size(109, 17)
        Me.lblDatosPersonales.TabIndex = 78
        Me.lblDatosPersonales.Text = "Datos Personales"
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblNota.ForeColor = System.Drawing.Color.White
        Me.lblNota.Location = New System.Drawing.Point(433, 314)
        Me.lblNota.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(146, 17)
        Me.lblNota.TabIndex = 77
        Me.lblNota.Text = "Notas (250 Caracteres)"
        '
        'PanelNotas
        '
        Me.PanelNotas.Controls.Add(Me.txtNota)
        Me.PanelNotas.Location = New System.Drawing.Point(421, 322)
        Me.PanelNotas.Name = "PanelNotas"
        Me.PanelNotas.Size = New System.Drawing.Size(531, 84)
        Me.PanelNotas.TabIndex = 79
        '
        'txtNota
        '
        Me.txtNota.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNota.Location = New System.Drawing.Point(13, 19)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(522, 46)
        Me.txtNota.TabIndex = 18
        Me.txtNota.Text = ""
        '
        'frmPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1086, 598)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.PanelNotas)
        Me.Controls.Add(Me.lblDatosPersonales)
        Me.Controls.Add(Me.lblDirecciones)
        Me.Controls.Add(Me.PanelDirecciones)
        Me.Controls.Add(Me.PanelDatosPersonales)
        Me.Controls.Add(Me.cboTipoPersona)
        Me.Controls.Add(Me.lblTipoPersona)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.grdPersonas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnEmpleados)
        Me.Controls.Add(Me.btnDatoFiscal)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblId)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPersonas"
        Me.Text = "frmPersonas"
        CType(Me.grdPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatosPersonales.ResumeLayout(False)
        Me.PanelDatosPersonales.PerformLayout()
        Me.PanelDirecciones.ResumeLayout(False)
        Me.PanelDirecciones.PerformLayout()
        CType(Me.btnAgregarCiudad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNotas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents btnDatoFiscal As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents grdPersonas As DataGridView
    Friend WithEvents btnModificar As Button
    Friend WithEvents lblTipoPersona As Label
    Friend WithEvents cboTipoPersona As ComboBox
    Friend WithEvents PanelDatosPersonales As Panel
    Friend WithEvents cboTipoDocumento As ComboBox
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents lblNumeroDocumento As Label
    Friend WithEvents txtNumeroDocumento As TextBox
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents lblTipoDocumento As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents PanelDirecciones As Panel
    Friend WithEvents lblCodigoPostal As Label
    Friend WithEvents txtCodigoPostal As TextBox
    Friend WithEvents lblTelefonoFijo As Label
    Friend WithEvents txtTelefonoFijo As TextBox
    Friend WithEvents lblLetra As Label
    Friend WithEvents txtLetraPuerta As TextBox
    Friend WithEvents lblPiso As Label
    Friend WithEvents txtPiso As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboCiudad As ComboBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboProvincia As ComboBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnAgregarCiudad As PictureBox
    Friend WithEvents lblTelefonoMovil As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelefonoMovil As TextBox
    Friend WithEvents lblDirecciones As Label
    Friend WithEvents lblDatosPersonales As Label
    Friend WithEvents lblNota As Label
    Friend WithEvents PanelNotas As Panel
    Friend WithEvents txtNota As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
End Class
