<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenesReparacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenesReparacion))
        Me.grdOrdenReparacion = New System.Windows.Forms.DataGridView()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboVehiculo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboServicios = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnAgregarServiciosTerceros = New System.Windows.Forms.PictureBox()
        Me.btnAgregarMarca = New System.Windows.Forms.PictureBox()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.PanelDetallesOrden = New System.Windows.Forms.Panel()
        Me.horaSalida = New System.Windows.Forms.DateTimePicker()
        Me.dtpSalida = New System.Windows.Forms.DateTimePicker()
        Me.horaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtpEntrada = New System.Windows.Forms.DateTimePicker()
        Me.horaTurno = New System.Windows.Forms.DateTimePicker()
        Me.dtpTurno = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboPersonas = New System.Windows.Forms.ComboBox()
        Me.btnAgregarCuenta = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelInfoVehiculo = New System.Windows.Forms.Panel()
        Me.txtSeñasParticulares = New System.Windows.Forms.RichTextBox()
        Me.txtMotivoReparacion = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelServiciosTerceros = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.grdOrdenReparacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarServiciosTerceros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetallesOrden.SuspendLayout()
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInfoVehiculo.SuspendLayout()
        Me.PanelServiciosTerceros.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdOrdenReparacion
        '
        Me.grdOrdenReparacion.AllowUserToAddRows = False
        Me.grdOrdenReparacion.AllowUserToDeleteRows = False
        Me.grdOrdenReparacion.AllowUserToResizeRows = False
        Me.grdOrdenReparacion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdOrdenReparacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdOrdenReparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOrdenReparacion.Location = New System.Drawing.Point(54, 388)
        Me.grdOrdenReparacion.Name = "grdOrdenReparacion"
        Me.grdOrdenReparacion.ReadOnly = True
        Me.grdOrdenReparacion.RowHeadersVisible = False
        Me.grdOrdenReparacion.RowHeadersWidth = 51
        Me.grdOrdenReparacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdOrdenReparacion.Size = New System.Drawing.Size(843, 241)
        Me.grdOrdenReparacion.TabIndex = 89
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.White
        Me.chkActivo.Location = New System.Drawing.Point(436, 36)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(85, 21)
        Me.chkActivo.TabIndex = 12
        Me.chkActivo.Text = "¿Activo?"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Fecha de salida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Fecha Entrada"
        '
        'cboVehiculo
        '
        Me.cboVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboVehiculo.FormattingEnabled = True
        Me.cboVehiculo.Location = New System.Drawing.Point(15, 36)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(211, 25)
        Me.cboVehiculo.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 17)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Fecha del turno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 17)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Motivo de reparación (200 caracteres)"
        '
        'cboServicios
        '
        Me.cboServicios.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboServicios.FormattingEnabled = True
        Me.cboServicios.Location = New System.Drawing.Point(192, 17)
        Me.cboServicios.Name = "cboServicios"
        Me.cboServicios.Size = New System.Drawing.Size(121, 25)
        Me.cboServicios.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Vehiculo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 17)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Señas Particulares (100 caracteres)"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(51, 38)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(62, 17)
        Me.lbl1.TabIndex = 67
        Me.lbl1.Text = "N° Orden"
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
        Me.btnModificar.Location = New System.Drawing.Point(417, 316)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(117, 37)
        Me.btnModificar.TabIndex = 14
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
        Me.btnCancelar.Location = New System.Drawing.Point(780, 316)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 37)
        Me.btnCancelar.TabIndex = 15
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
        Me.btnAceptar.Location = New System.Drawing.Point(54, 316)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 37)
        Me.btnAceptar.TabIndex = 13
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
        Me.btnBuscar.Location = New System.Drawing.Point(276, 31)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 28)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtID.Location = New System.Drawing.Point(163, 35)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(86, 23)
        Me.txtID.TabIndex = 1
        '
        'btnAgregarServiciosTerceros
        '
        Me.btnAgregarServiciosTerceros.BackgroundImage = CType(resources.GetObject("btnAgregarServiciosTerceros.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarServiciosTerceros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarServiciosTerceros.Location = New System.Drawing.Point(319, 17)
        Me.btnAgregarServiciosTerceros.Name = "btnAgregarServiciosTerceros"
        Me.btnAgregarServiciosTerceros.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarServiciosTerceros.TabIndex = 96
        Me.btnAgregarServiciosTerceros.TabStop = False
        '
        'btnAgregarMarca
        '
        Me.btnAgregarMarca.BackgroundImage = CType(resources.GetObject("btnAgregarMarca.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarMarca.Location = New System.Drawing.Point(232, 36)
        Me.btnAgregarMarca.Name = "btnAgregarMarca"
        Me.btnAgregarMarca.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarMarca.TabIndex = 97
        Me.btnAgregarMarca.TabStop = False
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblNota.ForeColor = System.Drawing.Color.White
        Me.lblNota.Location = New System.Drawing.Point(66, 74)
        Me.lblNota.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(130, 17)
        Me.lblNota.TabIndex = 98
        Me.lblNota.Text = "Detalles de la Orden"
        '
        'PanelDetallesOrden
        '
        Me.PanelDetallesOrden.Controls.Add(Me.horaSalida)
        Me.PanelDetallesOrden.Controls.Add(Me.dtpSalida)
        Me.PanelDetallesOrden.Controls.Add(Me.horaEntrada)
        Me.PanelDetallesOrden.Controls.Add(Me.dtpEntrada)
        Me.PanelDetallesOrden.Controls.Add(Me.horaTurno)
        Me.PanelDetallesOrden.Controls.Add(Me.dtpTurno)
        Me.PanelDetallesOrden.Controls.Add(Me.Label10)
        Me.PanelDetallesOrden.Controls.Add(Me.Label12)
        Me.PanelDetallesOrden.Controls.Add(Me.cboPersonas)
        Me.PanelDetallesOrden.Controls.Add(Me.btnAgregarCuenta)
        Me.PanelDetallesOrden.Controls.Add(Me.Label3)
        Me.PanelDetallesOrden.Controls.Add(Me.Label4)
        Me.PanelDetallesOrden.Location = New System.Drawing.Point(54, 82)
        Me.PanelDetallesOrden.Name = "PanelDetallesOrden"
        Me.PanelDetallesOrden.Size = New System.Drawing.Size(272, 208)
        Me.PanelDetallesOrden.TabIndex = 99
        '
        'horaSalida
        '
        Me.horaSalida.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.horaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.horaSalida.Location = New System.Drawing.Point(152, 170)
        Me.horaSalida.Name = "horaSalida"
        Me.horaSalida.Size = New System.Drawing.Size(106, 23)
        Me.horaSalida.TabIndex = 101
        '
        'dtpSalida
        '
        Me.dtpSalida.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSalida.Location = New System.Drawing.Point(15, 170)
        Me.dtpSalida.Name = "dtpSalida"
        Me.dtpSalida.Size = New System.Drawing.Size(106, 23)
        Me.dtpSalida.TabIndex = 100
        '
        'horaEntrada
        '
        Me.horaEntrada.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.horaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.horaEntrada.Location = New System.Drawing.Point(152, 126)
        Me.horaEntrada.Name = "horaEntrada"
        Me.horaEntrada.Size = New System.Drawing.Size(106, 23)
        Me.horaEntrada.TabIndex = 99
        '
        'dtpEntrada
        '
        Me.dtpEntrada.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEntrada.Location = New System.Drawing.Point(15, 126)
        Me.dtpEntrada.Name = "dtpEntrada"
        Me.dtpEntrada.Size = New System.Drawing.Size(106, 23)
        Me.dtpEntrada.TabIndex = 98
        '
        'horaTurno
        '
        Me.horaTurno.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.horaTurno.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.horaTurno.Location = New System.Drawing.Point(152, 82)
        Me.horaTurno.Name = "horaTurno"
        Me.horaTurno.Size = New System.Drawing.Size(106, 23)
        Me.horaTurno.TabIndex = 97
        '
        'dtpTurno
        '
        Me.dtpTurno.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpTurno.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTurno.Location = New System.Drawing.Point(15, 82)
        Me.dtpTurno.Name = "dtpTurno"
        Me.dtpTurno.Size = New System.Drawing.Size(106, 23)
        Me.dtpTurno.TabIndex = 96
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 17)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Solicitante"
        '
        'cboPersonas
        '
        Me.cboPersonas.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboPersonas.FormattingEnabled = True
        Me.cboPersonas.Location = New System.Drawing.Point(15, 36)
        Me.cboPersonas.Name = "cboPersonas"
        Me.cboPersonas.Size = New System.Drawing.Size(211, 25)
        Me.cboPersonas.TabIndex = 10
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.BackgroundImage = CType(resources.GetObject("btnAgregarCuenta.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(232, 36)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarCuenta.TabIndex = 95
        Me.btnAgregarCuenta.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(374, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 17)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Información del Vehículo"
        '
        'PanelInfoVehiculo
        '
        Me.PanelInfoVehiculo.Controls.Add(Me.txtSeñasParticulares)
        Me.PanelInfoVehiculo.Controls.Add(Me.txtMotivoReparacion)
        Me.PanelInfoVehiculo.Controls.Add(Me.Label8)
        Me.PanelInfoVehiculo.Controls.Add(Me.cboVehiculo)
        Me.PanelInfoVehiculo.Controls.Add(Me.btnAgregarMarca)
        Me.PanelInfoVehiculo.Controls.Add(Me.Label7)
        Me.PanelInfoVehiculo.Controls.Add(Me.Label1)
        Me.PanelInfoVehiculo.Controls.Add(Me.chkActivo)
        Me.PanelInfoVehiculo.Location = New System.Drawing.Point(362, 34)
        Me.PanelInfoVehiculo.Name = "PanelInfoVehiculo"
        Me.PanelInfoVehiculo.Size = New System.Drawing.Size(535, 183)
        Me.PanelInfoVehiculo.TabIndex = 101
        '
        'txtSeñasParticulares
        '
        Me.txtSeñasParticulares.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSeñasParticulares.Location = New System.Drawing.Point(15, 84)
        Me.txtSeñasParticulares.Name = "txtSeñasParticulares"
        Me.txtSeñasParticulares.Size = New System.Drawing.Size(506, 29)
        Me.txtSeñasParticulares.TabIndex = 99
        Me.txtSeñasParticulares.Text = ""
        '
        'txtMotivoReparacion
        '
        Me.txtMotivoReparacion.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMotivoReparacion.Location = New System.Drawing.Point(15, 136)
        Me.txtMotivoReparacion.Name = "txtMotivoReparacion"
        Me.txtMotivoReparacion.Size = New System.Drawing.Size(506, 29)
        Me.txtMotivoReparacion.TabIndex = 98
        Me.txtMotivoReparacion.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(374, 225)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 17)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Servicios de terceros"
        '
        'PanelServiciosTerceros
        '
        Me.PanelServiciosTerceros.Controls.Add(Me.cboServicios)
        Me.PanelServiciosTerceros.Controls.Add(Me.btnAgregarServiciosTerceros)
        Me.PanelServiciosTerceros.Location = New System.Drawing.Point(362, 233)
        Me.PanelServiciosTerceros.Name = "PanelServiciosTerceros"
        Me.PanelServiciosTerceros.Size = New System.Drawing.Size(535, 57)
        Me.PanelServiciosTerceros.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(242, 368)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(465, 17)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "FALTA DE LA TABLA PRECIO MANO DE OBRA Y VER QUE ONDA SERVICIOS 3EROS"
        '
        'frmOrdenesReparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 598)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PanelServiciosTerceros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelInfoVehiculo)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.PanelDetallesOrden)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.grdOrdenReparacion)
        Me.Controls.Add(Me.lbl1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdenesReparacion"
        Me.Text = "Orden de reparacion"
        CType(Me.grdOrdenReparacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarServiciosTerceros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetallesOrden.ResumeLayout(False)
        Me.PanelDetallesOrden.PerformLayout()
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInfoVehiculo.ResumeLayout(False)
        Me.PanelInfoVehiculo.PerformLayout()
        Me.PanelServiciosTerceros.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdOrdenReparacion As DataGridView
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboVehiculo As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboServicios As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnAgregarServiciosTerceros As PictureBox
    Friend WithEvents btnAgregarMarca As PictureBox
    Friend WithEvents lblNota As Label
    Friend WithEvents PanelDetallesOrden As Panel
    Friend WithEvents dtpTurno As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents cboPersonas As ComboBox
    Friend WithEvents btnAgregarCuenta As PictureBox
    Friend WithEvents horaSalida As DateTimePicker
    Friend WithEvents dtpSalida As DateTimePicker
    Friend WithEvents horaEntrada As DateTimePicker
    Friend WithEvents dtpEntrada As DateTimePicker
    Friend WithEvents horaTurno As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelInfoVehiculo As Panel
    Friend WithEvents txtSeñasParticulares As RichTextBox
    Friend WithEvents txtMotivoReparacion As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelServiciosTerceros As Panel
    Friend WithEvents Label5 As Label
End Class
