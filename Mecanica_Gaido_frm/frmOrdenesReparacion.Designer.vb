<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrdenesReparacion
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenesReparacion))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdOrdenReparacion = New System.Windows.Forms.DataGridView()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboVehiculo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnAgregarVehiculo = New System.Windows.Forms.PictureBox()
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
        Me.PanelCostos = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtMontoTotalOR = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMontoRepuestos = New System.Windows.Forms.RichTextBox()
        Me.txtMontoServ3 = New System.Windows.Forms.RichTextBox()
        Me.txtMontoManoObra = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelServiciosTerceros = New System.Windows.Forms.Panel()
        Me.btnQuitarS3 = New System.Windows.Forms.Button()
        Me.lblResultadoPrestador = New System.Windows.Forms.Label()
        Me.chkActivoS3 = New System.Windows.Forms.CheckBox()
        Me.chkAvanceServ3 = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCostoRealS3 = New System.Windows.Forms.RichTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCostoEstimadoS3 = New System.Windows.Forms.RichTextBox()
        Me.grdServiciosTerceros = New System.Windows.Forms.DataGridView()
        Me.NroServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Prestador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prestador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServSolicitado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoEstimado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoReal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Finalizado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CboPersonaServ3 = New System.Windows.Forms.ComboBox()
        Me.btnAgregarServiciosTerceros = New System.Windows.Forms.PictureBox()
        Me.BtnModificarS3 = New System.Windows.Forms.Button()
        Me.txtServicioSolicitado = New System.Windows.Forms.TextBox()
        Me.txtID_Serv3 = New System.Windows.Forms.TextBox()
        Me.BtnCancelarS3 = New System.Windows.Forms.Button()
        Me.btnAceptarS3 = New System.Windows.Forms.Button()
        Me.PanelReparaciones = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grdRepuestosOR = New System.Windows.Forms.DataGridView()
        Me.PanelDetalleDeRepuestos = New System.Windows.Forms.Panel()
        Me.grdRepuestos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarRepOR = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnAgregarRepOR = New System.Windows.Forms.Button()
        Me.txtCantidadRepOR = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboProductoOR = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.grdOrdenReparacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetallesOrden.SuspendLayout()
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelInfoVehiculo.SuspendLayout()
        Me.PanelCostos.SuspendLayout()
        Me.PanelServiciosTerceros.SuspendLayout()
        CType(Me.grdServiciosTerceros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarServiciosTerceros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelReparaciones.SuspendLayout()
        CType(Me.grdRepuestosOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetalleDeRepuestos.SuspendLayout()
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdOrdenReparacion
        '
        Me.grdOrdenReparacion.AllowUserToAddRows = False
        Me.grdOrdenReparacion.AllowUserToDeleteRows = False
        Me.grdOrdenReparacion.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.grdOrdenReparacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdOrdenReparacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdOrdenReparacion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdOrdenReparacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdOrdenReparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOrdenReparacion.Location = New System.Drawing.Point(15, 32)
        Me.grdOrdenReparacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdOrdenReparacion.Name = "grdOrdenReparacion"
        Me.grdOrdenReparacion.ReadOnly = True
        Me.grdOrdenReparacion.RowHeadersVisible = False
        Me.grdOrdenReparacion.RowHeadersWidth = 51
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.grdOrdenReparacion.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdOrdenReparacion.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.grdOrdenReparacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdOrdenReparacion.Size = New System.Drawing.Size(1002, 197)
        Me.grdOrdenReparacion.TabIndex = 89
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.White
        Me.chkActivo.Location = New System.Drawing.Point(938, 55)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(124, 27)
        Me.chkActivo.TabIndex = 11
        Me.chkActivo.Text = "¿Activo?"
        Me.chkActivo.UseVisualStyleBackColor = True
        Me.chkActivo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(18, 232)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 23)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Fecha de salida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 23)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Fecha Entrada"
        '
        'cboVehiculo
        '
        Me.cboVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboVehiculo.FormattingEnabled = True
        Me.cboVehiculo.Location = New System.Drawing.Point(22, 55)
        Me.cboVehiculo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(830, 31)
        Me.cboVehiculo.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(18, 97)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 23)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Fecha del turno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 178)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 23)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Motivo de reparación (200 caracteres)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(18, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 23)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Vehiculo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(18, 98)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(352, 23)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Señas Particulares (100 caracteres)"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(21, 43)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(91, 21)
        Me.lbl1.TabIndex = 67
        Me.lbl1.Text = "N° Orden"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Enabled = False
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(921, 346)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(176, 57)
        Me.btnModificar.TabIndex = 25
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
        Me.btnCancelar.Location = New System.Drawing.Point(1350, 346)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(176, 57)
        Me.btnCancelar.TabIndex = 26
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
        Me.btnAceptar.Location = New System.Drawing.Point(468, 346)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(176, 57)
        Me.btnAceptar.TabIndex = 24
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
        Me.btnBuscar.Location = New System.Drawing.Point(358, 32)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 43)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtID.Location = New System.Drawing.Point(189, 38)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(127, 31)
        Me.txtID.TabIndex = 1
        '
        'btnAgregarVehiculo
        '
        Me.btnAgregarVehiculo.BackgroundImage = CType(resources.GetObject("btnAgregarVehiculo.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarVehiculo.Location = New System.Drawing.Point(876, 55)
        Me.btnAgregarVehiculo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarVehiculo.Name = "btnAgregarVehiculo"
        Me.btnAgregarVehiculo.Size = New System.Drawing.Size(39, 38)
        Me.btnAgregarVehiculo.TabIndex = 97
        Me.btnAgregarVehiculo.TabStop = False
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblNota.ForeColor = System.Drawing.Color.White
        Me.lblNota.Location = New System.Drawing.Point(44, 89)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(189, 21)
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
        Me.PanelDetallesOrden.Location = New System.Drawing.Point(26, 102)
        Me.PanelDetallesOrden.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelDetallesOrden.Name = "PanelDetallesOrden"
        Me.PanelDetallesOrden.Size = New System.Drawing.Size(408, 317)
        Me.PanelDetallesOrden.TabIndex = 99
        '
        'horaSalida
        '
        Me.horaSalida.CustomFormat = "hh:mm"
        Me.horaSalida.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.horaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.horaSalida.Location = New System.Drawing.Point(228, 262)
        Me.horaSalida.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.horaSalida.Name = "horaSalida"
        Me.horaSalida.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.horaSalida.Size = New System.Drawing.Size(157, 31)
        Me.horaSalida.TabIndex = 9
        '
        'dtpSalida
        '
        Me.dtpSalida.CustomFormat = "dd/MM/yyyy"
        Me.dtpSalida.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSalida.Location = New System.Drawing.Point(22, 262)
        Me.dtpSalida.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpSalida.Name = "dtpSalida"
        Me.dtpSalida.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpSalida.Size = New System.Drawing.Size(157, 31)
        Me.dtpSalida.TabIndex = 8
        '
        'horaEntrada
        '
        Me.horaEntrada.CustomFormat = "hh:mm"
        Me.horaEntrada.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.horaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.horaEntrada.Location = New System.Drawing.Point(228, 194)
        Me.horaEntrada.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.horaEntrada.Name = "horaEntrada"
        Me.horaEntrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.horaEntrada.Size = New System.Drawing.Size(157, 31)
        Me.horaEntrada.TabIndex = 7
        '
        'dtpEntrada
        '
        Me.dtpEntrada.CustomFormat = "dd/MM/yyyy"
        Me.dtpEntrada.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEntrada.Location = New System.Drawing.Point(22, 194)
        Me.dtpEntrada.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpEntrada.Name = "dtpEntrada"
        Me.dtpEntrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpEntrada.Size = New System.Drawing.Size(157, 31)
        Me.dtpEntrada.TabIndex = 6
        '
        'horaTurno
        '
        Me.horaTurno.CustomFormat = "hh:mm"
        Me.horaTurno.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.horaTurno.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.horaTurno.Location = New System.Drawing.Point(228, 126)
        Me.horaTurno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.horaTurno.Name = "horaTurno"
        Me.horaTurno.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.horaTurno.Size = New System.Drawing.Size(157, 31)
        Me.horaTurno.TabIndex = 5
        '
        'dtpTurno
        '
        Me.dtpTurno.CustomFormat = "dd/MM/yyyy"
        Me.dtpTurno.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpTurno.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTurno.Location = New System.Drawing.Point(22, 126)
        Me.dtpTurno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpTurno.Name = "dtpTurno"
        Me.dtpTurno.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpTurno.Size = New System.Drawing.Size(157, 31)
        Me.dtpTurno.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(18, 26)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 23)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Solicitante"
        '
        'cboPersonas
        '
        Me.cboPersonas.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboPersonas.FormattingEnabled = True
        Me.cboPersonas.Location = New System.Drawing.Point(22, 55)
        Me.cboPersonas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboPersonas.Name = "cboPersonas"
        Me.cboPersonas.Size = New System.Drawing.Size(314, 31)
        Me.cboPersonas.TabIndex = 3
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.BackgroundImage = CType(resources.GetObject("btnAgregarCuenta.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(348, 55)
        Me.btnAgregarCuenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(39, 38)
        Me.btnAgregarCuenta.TabIndex = 95
        Me.btnAgregarCuenta.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(464, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 21)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Información del Vehículo"
        '
        'PanelInfoVehiculo
        '
        Me.PanelInfoVehiculo.Controls.Add(Me.txtSeñasParticulares)
        Me.PanelInfoVehiculo.Controls.Add(Me.txtMotivoReparacion)
        Me.PanelInfoVehiculo.Controls.Add(Me.Label8)
        Me.PanelInfoVehiculo.Controls.Add(Me.cboVehiculo)
        Me.PanelInfoVehiculo.Controls.Add(Me.btnAgregarVehiculo)
        Me.PanelInfoVehiculo.Controls.Add(Me.Label7)
        Me.PanelInfoVehiculo.Controls.Add(Me.Label1)
        Me.PanelInfoVehiculo.Controls.Add(Me.chkActivo)
        Me.PanelInfoVehiculo.Location = New System.Drawing.Point(446, 37)
        Me.PanelInfoVehiculo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelInfoVehiculo.Name = "PanelInfoVehiculo"
        Me.PanelInfoVehiculo.Size = New System.Drawing.Size(1112, 282)
        Me.PanelInfoVehiculo.TabIndex = 101
        '
        'txtSeñasParticulares
        '
        Me.txtSeñasParticulares.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSeñasParticulares.Location = New System.Drawing.Point(22, 129)
        Me.txtSeñasParticulares.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSeñasParticulares.Name = "txtSeñasParticulares"
        Me.txtSeñasParticulares.Size = New System.Drawing.Size(1057, 42)
        Me.txtSeñasParticulares.TabIndex = 12
        Me.txtSeñasParticulares.Text = ""
        '
        'txtMotivoReparacion
        '
        Me.txtMotivoReparacion.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMotivoReparacion.Location = New System.Drawing.Point(22, 209)
        Me.txtMotivoReparacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMotivoReparacion.Name = "txtMotivoReparacion"
        Me.txtMotivoReparacion.Size = New System.Drawing.Size(1057, 42)
        Me.txtMotivoReparacion.TabIndex = 13
        Me.txtMotivoReparacion.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(32, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 21)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Mano de obra Propia"
        '
        'PanelCostos
        '
        Me.PanelCostos.Controls.Add(Me.Label21)
        Me.PanelCostos.Controls.Add(Me.txtMontoTotalOR)
        Me.PanelCostos.Controls.Add(Me.Label5)
        Me.PanelCostos.Controls.Add(Me.Label15)
        Me.PanelCostos.Controls.Add(Me.txtMontoRepuestos)
        Me.PanelCostos.Controls.Add(Me.txtMontoServ3)
        Me.PanelCostos.Controls.Add(Me.Label6)
        Me.PanelCostos.Controls.Add(Me.txtMontoManoObra)
        Me.PanelCostos.Location = New System.Drawing.Point(1062, 1345)
        Me.PanelCostos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelCostos.Name = "PanelCostos"
        Me.PanelCostos.Size = New System.Drawing.Size(495, 243)
        Me.PanelCostos.TabIndex = 103
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(266, 122)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(177, 21)
        Me.Label21.TabIndex = 115
        Me.Label21.Text = "Monto Total Orden"
        '
        'txtMontoTotalOR
        '
        Me.txtMontoTotalOR.Enabled = False
        Me.txtMontoTotalOR.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMontoTotalOR.Location = New System.Drawing.Point(270, 152)
        Me.txtMontoTotalOR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMontoTotalOR.Multiline = False
        Me.txtMontoTotalOR.Name = "txtMontoTotalOR"
        Me.txtMontoTotalOR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMontoTotalOR.Size = New System.Drawing.Size(193, 42)
        Me.txtMontoTotalOR.TabIndex = 111
        Me.txtMontoTotalOR.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(32, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 21)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Servicios de Terceros"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(266, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 21)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Repuestos"
        '
        'txtMontoRepuestos
        '
        Me.txtMontoRepuestos.AutoWordSelection = True
        Me.txtMontoRepuestos.Enabled = False
        Me.txtMontoRepuestos.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMontoRepuestos.Location = New System.Drawing.Point(270, 58)
        Me.txtMontoRepuestos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMontoRepuestos.Multiline = False
        Me.txtMontoRepuestos.Name = "txtMontoRepuestos"
        Me.txtMontoRepuestos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMontoRepuestos.Size = New System.Drawing.Size(193, 42)
        Me.txtMontoRepuestos.TabIndex = 110
        Me.txtMontoRepuestos.Text = "0"
        '
        'txtMontoServ3
        '
        Me.txtMontoServ3.AutoWordSelection = True
        Me.txtMontoServ3.Enabled = False
        Me.txtMontoServ3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMontoServ3.Location = New System.Drawing.Point(38, 152)
        Me.txtMontoServ3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMontoServ3.Multiline = False
        Me.txtMontoServ3.Name = "txtMontoServ3"
        Me.txtMontoServ3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMontoServ3.Size = New System.Drawing.Size(193, 42)
        Me.txtMontoServ3.TabIndex = 101
        Me.txtMontoServ3.Text = "0"
        '
        'txtMontoManoObra
        '
        Me.txtMontoManoObra.AutoWordSelection = True
        Me.txtMontoManoObra.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMontoManoObra.Location = New System.Drawing.Point(36, 58)
        Me.txtMontoManoObra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMontoManoObra.Multiline = False
        Me.txtMontoManoObra.Name = "txtMontoManoObra"
        Me.txtMontoManoObra.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMontoManoObra.Size = New System.Drawing.Size(193, 42)
        Me.txtMontoManoObra.TabIndex = 100
        Me.txtMontoManoObra.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(21, -5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(190, 21)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Servicios de terceros"
        '
        'PanelServiciosTerceros
        '
        Me.PanelServiciosTerceros.Controls.Add(Me.btnQuitarS3)
        Me.PanelServiciosTerceros.Controls.Add(Me.lblResultadoPrestador)
        Me.PanelServiciosTerceros.Controls.Add(Me.chkActivoS3)
        Me.PanelServiciosTerceros.Controls.Add(Me.Label9)
        Me.PanelServiciosTerceros.Controls.Add(Me.chkAvanceServ3)
        Me.PanelServiciosTerceros.Controls.Add(Me.Label18)
        Me.PanelServiciosTerceros.Controls.Add(Me.txtCostoRealS3)
        Me.PanelServiciosTerceros.Controls.Add(Me.Label17)
        Me.PanelServiciosTerceros.Controls.Add(Me.Label16)
        Me.PanelServiciosTerceros.Controls.Add(Me.txtCostoEstimadoS3)
        Me.PanelServiciosTerceros.Controls.Add(Me.grdServiciosTerceros)
        Me.PanelServiciosTerceros.Controls.Add(Me.Label14)
        Me.PanelServiciosTerceros.Controls.Add(Me.Label11)
        Me.PanelServiciosTerceros.Controls.Add(Me.CboPersonaServ3)
        Me.PanelServiciosTerceros.Controls.Add(Me.btnAgregarServiciosTerceros)
        Me.PanelServiciosTerceros.Controls.Add(Me.BtnModificarS3)
        Me.PanelServiciosTerceros.Controls.Add(Me.txtServicioSolicitado)
        Me.PanelServiciosTerceros.Controls.Add(Me.txtID_Serv3)
        Me.PanelServiciosTerceros.Controls.Add(Me.BtnCancelarS3)
        Me.PanelServiciosTerceros.Controls.Add(Me.btnAceptarS3)
        Me.PanelServiciosTerceros.Location = New System.Drawing.Point(27, 938)
        Me.PanelServiciosTerceros.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelServiciosTerceros.Name = "PanelServiciosTerceros"
        Me.PanelServiciosTerceros.Size = New System.Drawing.Size(1530, 395)
        Me.PanelServiciosTerceros.TabIndex = 105
        '
        'btnQuitarS3
        '
        Me.btnQuitarS3.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitarS3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitarS3.Enabled = False
        Me.btnQuitarS3.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnQuitarS3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnQuitarS3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarS3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarS3.ForeColor = System.Drawing.Color.White
        Me.btnQuitarS3.Location = New System.Drawing.Point(1323, 135)
        Me.btnQuitarS3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuitarS3.Name = "btnQuitarS3"
        Me.btnQuitarS3.Size = New System.Drawing.Size(176, 57)
        Me.btnQuitarS3.TabIndex = 112
        Me.btnQuitarS3.Text = "Quitar"
        Me.btnQuitarS3.UseVisualStyleBackColor = False
        '
        'lblResultadoPrestador
        '
        Me.lblResultadoPrestador.AutoSize = True
        Me.lblResultadoPrestador.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultadoPrestador.Location = New System.Drawing.Point(240, 106)
        Me.lblResultadoPrestador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResultadoPrestador.Name = "lblResultadoPrestador"
        Me.lblResultadoPrestador.Size = New System.Drawing.Size(103, 23)
        Me.lblResultadoPrestador.TabIndex = 111
        Me.lblResultadoPrestador.Text = "Prestador"
        '
        'chkActivoS3
        '
        Me.chkActivoS3.AutoSize = True
        Me.chkActivoS3.Checked = True
        Me.chkActivoS3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivoS3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivoS3.ForeColor = System.Drawing.Color.White
        Me.chkActivoS3.Location = New System.Drawing.Point(1098, 146)
        Me.chkActivoS3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkActivoS3.Name = "chkActivoS3"
        Me.chkActivoS3.Size = New System.Drawing.Size(124, 27)
        Me.chkActivoS3.TabIndex = 20
        Me.chkActivoS3.Text = "¿Activo?"
        Me.chkActivoS3.UseVisualStyleBackColor = True
        Me.chkActivoS3.Visible = False
        '
        'chkAvanceServ3
        '
        Me.chkAvanceServ3.AutoSize = True
        Me.chkAvanceServ3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAvanceServ3.ForeColor = System.Drawing.Color.White
        Me.chkAvanceServ3.Location = New System.Drawing.Point(912, 146)
        Me.chkAvanceServ3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkAvanceServ3.Name = "chkAvanceServ3"
        Me.chkAvanceServ3.Size = New System.Drawing.Size(157, 27)
        Me.chkAvanceServ3.TabIndex = 19
        Me.chkAvanceServ3.Text = "¿Finalizado?"
        Me.chkAvanceServ3.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(1094, 28)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(117, 23)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "Costo Real"
        '
        'txtCostoRealS3
        '
        Me.txtCostoRealS3.AutoWordSelection = True
        Me.txtCostoRealS3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCostoRealS3.Location = New System.Drawing.Point(1098, 62)
        Me.txtCostoRealS3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCostoRealS3.Multiline = False
        Me.txtCostoRealS3.Name = "txtCostoRealS3"
        Me.txtCostoRealS3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCostoRealS3.Size = New System.Drawing.Size(174, 42)
        Me.txtCostoRealS3.TabIndex = 18
        Me.txtCostoRealS3.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(898, 26)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(162, 23)
        Me.Label17.TabIndex = 107
        Me.Label17.Text = "Costo Estimado"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(18, 28)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 23)
        Me.Label16.TabIndex = 105
        Me.Label16.Text = "N° Servicio"
        '
        'txtCostoEstimadoS3
        '
        Me.txtCostoEstimadoS3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCostoEstimadoS3.Location = New System.Drawing.Point(903, 62)
        Me.txtCostoEstimadoS3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCostoEstimadoS3.Multiline = False
        Me.txtCostoEstimadoS3.Name = "txtCostoEstimadoS3"
        Me.txtCostoEstimadoS3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCostoEstimadoS3.Size = New System.Drawing.Size(174, 42)
        Me.txtCostoEstimadoS3.TabIndex = 17
        Me.txtCostoEstimadoS3.Text = "0"
        '
        'grdServiciosTerceros
        '
        Me.grdServiciosTerceros.AllowUserToAddRows = False
        Me.grdServiciosTerceros.AllowUserToDeleteRows = False
        Me.grdServiciosTerceros.AllowUserToResizeRows = False
        Me.grdServiciosTerceros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdServiciosTerceros.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdServiciosTerceros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdServiciosTerceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdServiciosTerceros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroServicio, Me.ID_Prestador, Me.Prestador, Me.ServSolicitado, Me.CostoEstimado, Me.CostoReal, Me.Finalizado, Me.Estado})
        Me.grdServiciosTerceros.Location = New System.Drawing.Point(22, 214)
        Me.grdServiciosTerceros.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdServiciosTerceros.Name = "grdServiciosTerceros"
        Me.grdServiciosTerceros.ReadOnly = True
        Me.grdServiciosTerceros.RowHeadersVisible = False
        Me.grdServiciosTerceros.RowHeadersWidth = 51
        Me.grdServiciosTerceros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdServiciosTerceros.Size = New System.Drawing.Size(1250, 155)
        Me.grdServiciosTerceros.TabIndex = 104
        '
        'NroServicio
        '
        Me.NroServicio.HeaderText = "Nro Servicio"
        Me.NroServicio.MinimumWidth = 6
        Me.NroServicio.Name = "NroServicio"
        Me.NroServicio.ReadOnly = True
        Me.NroServicio.Visible = False
        Me.NroServicio.Width = 71
        '
        'ID_Prestador
        '
        Me.ID_Prestador.HeaderText = "ID Prestador"
        Me.ID_Prestador.MinimumWidth = 6
        Me.ID_Prestador.Name = "ID_Prestador"
        Me.ID_Prestador.ReadOnly = True
        Me.ID_Prestador.Visible = False
        Me.ID_Prestador.Width = 72
        '
        'Prestador
        '
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Prestador.DefaultCellStyle = DataGridViewCellStyle4
        Me.Prestador.HeaderText = "Prestador"
        Me.Prestador.MinimumWidth = 6
        Me.Prestador.Name = "Prestador"
        Me.Prestador.ReadOnly = True
        Me.Prestador.Width = 250
        '
        'ServSolicitado
        '
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.ServSolicitado.DefaultCellStyle = DataGridViewCellStyle5
        Me.ServSolicitado.HeaderText = "Servicio Solicitado"
        Me.ServSolicitado.MinimumWidth = 6
        Me.ServSolicitado.Name = "ServSolicitado"
        Me.ServSolicitado.ReadOnly = True
        Me.ServSolicitado.Width = 290
        '
        'CostoEstimado
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.CostoEstimado.DefaultCellStyle = DataGridViewCellStyle6
        Me.CostoEstimado.HeaderText = "C. Estimado"
        Me.CostoEstimado.MinimumWidth = 6
        Me.CostoEstimado.Name = "CostoEstimado"
        Me.CostoEstimado.ReadOnly = True
        Me.CostoEstimado.Width = 120
        '
        'CostoReal
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Format = "N2"
        Me.CostoReal.DefaultCellStyle = DataGridViewCellStyle7
        Me.CostoReal.HeaderText = "C. Real"
        Me.CostoReal.MinimumWidth = 6
        Me.CostoReal.Name = "CostoReal"
        Me.CostoReal.ReadOnly = True
        Me.CostoReal.Width = 120
        '
        'Finalizado
        '
        Me.Finalizado.HeaderText = "Fin.?"
        Me.Finalizado.MinimumWidth = 6
        Me.Finalizado.Name = "Finalizado"
        Me.Finalizado.ReadOnly = True
        Me.Finalizado.Width = 50
        '
        'Estado
        '
        Me.Estado.HeaderText = "Activo?"
        Me.Estado.MinimumWidth = 6
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Visible = False
        Me.Estado.Width = 49
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(18, 108)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(210, 23)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "Servicio Solicitado a:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(166, 28)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 23)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Prestador"
        '
        'CboPersonaServ3
        '
        Me.CboPersonaServ3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CboPersonaServ3.FormattingEnabled = True
        Me.CboPersonaServ3.Location = New System.Drawing.Point(171, 57)
        Me.CboPersonaServ3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CboPersonaServ3.Name = "CboPersonaServ3"
        Me.CboPersonaServ3.Size = New System.Drawing.Size(624, 31)
        Me.CboPersonaServ3.TabIndex = 14
        '
        'btnAgregarServiciosTerceros
        '
        Me.btnAgregarServiciosTerceros.BackgroundImage = CType(resources.GetObject("btnAgregarServiciosTerceros.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarServiciosTerceros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarServiciosTerceros.Location = New System.Drawing.Point(825, 57)
        Me.btnAgregarServiciosTerceros.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarServiciosTerceros.Name = "btnAgregarServiciosTerceros"
        Me.btnAgregarServiciosTerceros.Size = New System.Drawing.Size(39, 38)
        Me.btnAgregarServiciosTerceros.TabIndex = 96
        Me.btnAgregarServiciosTerceros.TabStop = False
        Me.btnAgregarServiciosTerceros.Tag = "Revisar"
        '
        'BtnModificarS3
        '
        Me.BtnModificarS3.BackColor = System.Drawing.Color.Transparent
        Me.BtnModificarS3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificarS3.Enabled = False
        Me.BtnModificarS3.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.BtnModificarS3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnModificarS3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificarS3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificarS3.ForeColor = System.Drawing.Color.White
        Me.BtnModificarS3.Location = New System.Drawing.Point(1323, 214)
        Me.BtnModificarS3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnModificarS3.Name = "BtnModificarS3"
        Me.BtnModificarS3.Size = New System.Drawing.Size(176, 57)
        Me.BtnModificarS3.TabIndex = 22
        Me.BtnModificarS3.Text = "Modificar"
        Me.BtnModificarS3.UseVisualStyleBackColor = False
        '
        'txtServicioSolicitado
        '
        Me.txtServicioSolicitado.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtServicioSolicitado.Location = New System.Drawing.Point(22, 146)
        Me.txtServicioSolicitado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtServicioSolicitado.Name = "txtServicioSolicitado"
        Me.txtServicioSolicitado.Size = New System.Drawing.Size(853, 31)
        Me.txtServicioSolicitado.TabIndex = 16
        '
        'txtID_Serv3
        '
        Me.txtID_Serv3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtID_Serv3.Location = New System.Drawing.Point(22, 57)
        Me.txtID_Serv3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtID_Serv3.Name = "txtID_Serv3"
        Me.txtID_Serv3.Size = New System.Drawing.Size(127, 31)
        Me.txtID_Serv3.TabIndex = 15
        Me.txtID_Serv3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCancelarS3
        '
        Me.BtnCancelarS3.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarS3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCancelarS3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelarS3.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.BtnCancelarS3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnCancelarS3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarS3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarS3.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarS3.Location = New System.Drawing.Point(1323, 292)
        Me.BtnCancelarS3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCancelarS3.Name = "BtnCancelarS3"
        Me.BtnCancelarS3.Size = New System.Drawing.Size(176, 57)
        Me.BtnCancelarS3.TabIndex = 23
        Me.BtnCancelarS3.Text = "Cancelar"
        Me.BtnCancelarS3.UseVisualStyleBackColor = False
        '
        'btnAceptarS3
        '
        Me.btnAceptarS3.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptarS3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptarS3.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAceptarS3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAceptarS3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarS3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarS3.ForeColor = System.Drawing.Color.White
        Me.btnAceptarS3.Location = New System.Drawing.Point(1323, 57)
        Me.btnAceptarS3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAceptarS3.Name = "btnAceptarS3"
        Me.btnAceptarS3.Size = New System.Drawing.Size(176, 57)
        Me.btnAceptarS3.TabIndex = 21
        Me.btnAceptarS3.Text = "Aceptar"
        Me.btnAceptarS3.UseVisualStyleBackColor = False
        '
        'PanelReparaciones
        '
        Me.PanelReparaciones.Controls.Add(Me.grdOrdenReparacion)
        Me.PanelReparaciones.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelReparaciones.Location = New System.Drawing.Point(27, 1343)
        Me.PanelReparaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelReparaciones.Name = "PanelReparaciones"
        Me.PanelReparaciones.Size = New System.Drawing.Size(1026, 245)
        Me.PanelReparaciones.TabIndex = 106
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(48, 1334)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(243, 21)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = "Consulta de Reparaciones"
        '
        'grdRepuestosOR
        '
        Me.grdRepuestosOR.AllowUserToAddRows = False
        Me.grdRepuestosOR.AllowUserToDeleteRows = False
        Me.grdRepuestosOR.AllowUserToOrderColumns = True
        Me.grdRepuestosOR.AllowUserToResizeRows = False
        Me.grdRepuestosOR.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdRepuestosOR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdRepuestosOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepuestosOR.Location = New System.Drawing.Point(42, 638)
        Me.grdRepuestosOR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdRepuestosOR.Name = "grdRepuestosOR"
        Me.grdRepuestosOR.ReadOnly = True
        Me.grdRepuestosOR.RowHeadersVisible = False
        Me.grdRepuestosOR.RowHeadersWidth = 51
        Me.grdRepuestosOR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRepuestosOR.Size = New System.Drawing.Size(1185, 402)
        Me.grdRepuestosOR.TabIndex = 113
        '
        'PanelDetalleDeRepuestos
        '
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.grdRepuestos)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.btnQuitarRepOR)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.Label20)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.btnAgregarRepOR)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.txtCantidadRepOR)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.Label22)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.cboProductoOR)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.Label23)
        Me.PanelDetalleDeRepuestos.Location = New System.Drawing.Point(26, 437)
        Me.PanelDetalleDeRepuestos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelDetalleDeRepuestos.Name = "PanelDetalleDeRepuestos"
        Me.PanelDetalleDeRepuestos.Size = New System.Drawing.Size(1532, 491)
        Me.PanelDetalleDeRepuestos.TabIndex = 114
        '
        'grdRepuestos
        '
        Me.grdRepuestos.AllowUserToAddRows = False
        Me.grdRepuestos.AllowUserToDeleteRows = False
        Me.grdRepuestos.AllowUserToResizeRows = False
        Me.grdRepuestos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdRepuestos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRepuestos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRepuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Descripcion, Me.Diario, Me.Cantidad, Me.Precio, Me.Total})
        Me.grdRepuestos.Location = New System.Drawing.Point(27, 122)
        Me.grdRepuestos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdRepuestos.Name = "grdRepuestos"
        Me.grdRepuestos.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdRepuestos.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.grdRepuestos.RowHeadersVisible = False
        Me.grdRepuestos.RowHeadersWidth = 51
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        Me.grdRepuestos.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.grdRepuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRepuestos.Size = New System.Drawing.Size(1473, 349)
        Me.grdRepuestos.TabIndex = 116
        '
        'ID
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.ID.DefaultCellStyle = DataGridViewCellStyle9
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 70
        '
        'Descripcion
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.Descripcion.DefaultCellStyle = DataGridViewCellStyle10
        Me.Descripcion.HeaderText = "Repuesto"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 240
        '
        'Diario
        '
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        Me.Diario.DefaultCellStyle = DataGridViewCellStyle11
        Me.Diario.HeaderText = "Nombre común"
        Me.Diario.MinimumWidth = 6
        Me.Diario.Name = "Diario"
        Me.Diario.ReadOnly = True
        Me.Diario.Width = 240
        '
        'Cantidad
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle12
        Me.Cantidad.HeaderText = "Cant."
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 140
        '
        'Precio
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle13
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 140
        '
        'Total
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle14
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 150
        '
        'btnQuitarRepOR
        '
        Me.btnQuitarRepOR.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitarRepOR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitarRepOR.Enabled = False
        Me.btnQuitarRepOR.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnQuitarRepOR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnQuitarRepOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarRepOR.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarRepOR.ForeColor = System.Drawing.Color.White
        Me.btnQuitarRepOR.Location = New System.Drawing.Point(1324, 35)
        Me.btnQuitarRepOR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuitarRepOR.Name = "btnQuitarRepOR"
        Me.btnQuitarRepOR.Size = New System.Drawing.Size(176, 57)
        Me.btnQuitarRepOR.TabIndex = 30
        Me.btnQuitarRepOR.Text = "Quitar"
        Me.btnQuitarRepOR.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(12, -6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(199, 21)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "Repuestos necesarios"
        '
        'btnAgregarRepOR
        '
        Me.btnAgregarRepOR.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarRepOR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarRepOR.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAgregarRepOR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAgregarRepOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarRepOR.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarRepOR.ForeColor = System.Drawing.Color.White
        Me.btnAgregarRepOR.Location = New System.Drawing.Point(1128, 37)
        Me.btnAgregarRepOR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregarRepOR.Name = "btnAgregarRepOR"
        Me.btnAgregarRepOR.Size = New System.Drawing.Size(176, 57)
        Me.btnAgregarRepOR.TabIndex = 29
        Me.btnAgregarRepOR.Text = "Agregar"
        Me.btnAgregarRepOR.UseVisualStyleBackColor = False
        '
        'txtCantidadRepOR
        '
        Me.txtCantidadRepOR.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadRepOR.Location = New System.Drawing.Point(996, 45)
        Me.txtCantidadRepOR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCantidadRepOR.Name = "txtCantidadRepOR"
        Me.txtCantidadRepOR.Size = New System.Drawing.Size(97, 31)
        Me.txtCantidadRepOR.TabIndex = 28
        Me.txtCantidadRepOR.Text = "1"
        Me.txtCantidadRepOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(874, 51)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(109, 23)
        Me.Label22.TabIndex = 115
        Me.Label22.Text = "Cantidad:"
        '
        'cboProductoOR
        '
        Me.cboProductoOR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProductoOR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProductoOR.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProductoOR.FormattingEnabled = True
        Me.cboProductoOR.Location = New System.Drawing.Point(140, 45)
        Me.cboProductoOR.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboProductoOR.Name = "cboProductoOR"
        Me.cboProductoOR.Size = New System.Drawing.Size(726, 31)
        Me.cboProductoOR.TabIndex = 27
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(22, 51)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(105, 23)
        Me.Label23.TabIndex = 113
        Me.Label23.Text = "Producto:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(1094, 1334)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(203, 21)
        Me.Label19.TabIndex = 115
        Me.Label19.Text = "Totales por Concepto"
        '
        'frmOrdenesReparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1650, 985)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.PanelDetalleDeRepuestos)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PanelServiciosTerceros)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.PanelCostos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelInfoVehiculo)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.PanelDetallesOrden)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.PanelReparaciones)
        Me.Controls.Add(Me.grdRepuestosOR)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmOrdenesReparacion"
        Me.Text = "Orden de reparacion"
        CType(Me.grdOrdenReparacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetallesOrden.ResumeLayout(False)
        Me.PanelDetallesOrden.PerformLayout()
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelInfoVehiculo.ResumeLayout(False)
        Me.PanelInfoVehiculo.PerformLayout()
        Me.PanelCostos.ResumeLayout(False)
        Me.PanelCostos.PerformLayout()
        Me.PanelServiciosTerceros.ResumeLayout(False)
        Me.PanelServiciosTerceros.PerformLayout()
        CType(Me.grdServiciosTerceros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarServiciosTerceros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelReparaciones.ResumeLayout(False)
        CType(Me.grdRepuestosOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetalleDeRepuestos.ResumeLayout(False)
        Me.PanelDetalleDeRepuestos.PerformLayout()
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnAgregarVehiculo As PictureBox
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
    Friend WithEvents PanelCostos As Panel
    Friend WithEvents txtMontoManoObra As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelServiciosTerceros As Panel
    Friend WithEvents CboPersonaServ3 As ComboBox
    Friend WithEvents btnAgregarServiciosTerceros As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PanelReparaciones As Panel
    Friend WithEvents grdServiciosTerceros As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMontoRepuestos As RichTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtMontoServ3 As RichTextBox
    Friend WithEvents chkActivoS3 As CheckBox
    Friend WithEvents chkAvanceServ3 As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtCostoRealS3 As RichTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCostoEstimadoS3 As RichTextBox
    Friend WithEvents BtnModificarS3 As Button
    Friend WithEvents BtnCancelarS3 As Button
    Friend WithEvents btnAceptarS3 As Button
    Friend WithEvents grdRepuestosOR As DataGridView
    Friend WithEvents PanelDetalleDeRepuestos As Panel
    Friend WithEvents btnQuitarRepOR As Button
    Friend WithEvents btnAgregarRepOR As Button
    Friend WithEvents txtCantidadRepOR As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cboProductoOR As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtMontoTotalOR As RichTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtServicioSolicitado As TextBox
    Friend WithEvents txtID_Serv3 As TextBox
    Friend WithEvents lblResultadoPrestador As Label
    Friend WithEvents grdRepuestos As DataGridView
    Friend WithEvents btnQuitarS3 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents NroServicio As DataGridViewTextBoxColumn
    Friend WithEvents ID_Prestador As DataGridViewTextBoxColumn
    Friend WithEvents Prestador As DataGridViewTextBoxColumn
    Friend WithEvents ServSolicitado As DataGridViewTextBoxColumn
    Friend WithEvents CostoEstimado As DataGridViewTextBoxColumn
    Friend WithEvents CostoReal As DataGridViewTextBoxColumn
    Friend WithEvents Finalizado As DataGridViewCheckBoxColumn
    Friend WithEvents Estado As DataGridViewCheckBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Diario As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
