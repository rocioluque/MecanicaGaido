﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label25 = New System.Windows.Forms.Label()
        Me.CboProgreso = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSeñasParticulares = New System.Windows.Forms.RichTextBox()
        Me.CboTipoReparacion = New System.Windows.Forms.ComboBox()
        Me.txtMotivoReparacion = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelCostos = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtMontoIVA = New System.Windows.Forms.RichTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtIVA = New System.Windows.Forms.RichTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.RichTextBox()
        Me.btnFacturar = New System.Windows.Forms.Button()
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
        Me.PanelDetalleDeRepuestos = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.grdRepuestos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarRepOR = New System.Windows.Forms.Button()
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
        Me.PanelDetalleDeRepuestos.SuspendLayout()
        CType(Me.grdRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdOrdenReparacion
        '
        Me.grdOrdenReparacion.AllowUserToAddRows = False
        Me.grdOrdenReparacion.AllowUserToDeleteRows = False
        Me.grdOrdenReparacion.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.grdOrdenReparacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdOrdenReparacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdOrdenReparacion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdOrdenReparacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdOrdenReparacion.CausesValidation = False
        Me.grdOrdenReparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOrdenReparacion.Location = New System.Drawing.Point(10, 21)
        Me.grdOrdenReparacion.MultiSelect = False
        Me.grdOrdenReparacion.Name = "grdOrdenReparacion"
        Me.grdOrdenReparacion.ReadOnly = True
        Me.grdOrdenReparacion.RowHeadersVisible = False
        Me.grdOrdenReparacion.RowHeadersWidth = 51
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.grdOrdenReparacion.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdOrdenReparacion.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdOrdenReparacion.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.grdOrdenReparacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdOrdenReparacion.Size = New System.Drawing.Size(988, 217)
        Me.grdOrdenReparacion.TabIndex = 89
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.Black
        Me.chkActivo.Location = New System.Drawing.Point(478, 36)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(85, 21)
        Me.chkActivo.TabIndex = 12
        Me.chkActivo.Text = "¿Activo?"
        Me.chkActivo.UseVisualStyleBackColor = True
        Me.chkActivo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
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
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Fecha Entrada"
        '
        'cboVehiculo
        '
        Me.cboVehiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboVehiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboVehiculo.FormattingEnabled = True
        Me.cboVehiculo.Location = New System.Drawing.Point(15, 36)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(417, 25)
        Me.cboVehiculo.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
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
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 17)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Motivo de reparación (200 caracteres)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
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
        Me.Label7.ForeColor = System.Drawing.Color.Black
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
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(37, 28)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(62, 17)
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
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Location = New System.Drawing.Point(915, 68)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(117, 37)
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
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(915, 112)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 37)
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
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Location = New System.Drawing.Point(915, 25)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 37)
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
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Location = New System.Drawing.Point(262, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 28)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtID.Location = New System.Drawing.Point(149, 25)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(86, 23)
        Me.txtID.TabIndex = 1
        '
        'btnAgregarVehiculo
        '
        Me.btnAgregarVehiculo.BackgroundImage = CType(resources.GetObject("btnAgregarVehiculo.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarVehiculo.Location = New System.Drawing.Point(437, 36)
        Me.btnAgregarVehiculo.Name = "btnAgregarVehiculo"
        Me.btnAgregarVehiculo.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarVehiculo.TabIndex = 97
        Me.btnAgregarVehiculo.TabStop = False
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblNota.ForeColor = System.Drawing.Color.Black
        Me.lblNota.Location = New System.Drawing.Point(52, 58)
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
        Me.PanelDetallesOrden.Location = New System.Drawing.Point(40, 66)
        Me.PanelDetallesOrden.Name = "PanelDetallesOrden"
        Me.PanelDetallesOrden.Size = New System.Drawing.Size(272, 206)
        Me.PanelDetallesOrden.TabIndex = 2
        '
        'horaSalida
        '
        Me.horaSalida.CustomFormat = "hh:mm"
        Me.horaSalida.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.horaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.horaSalida.Location = New System.Drawing.Point(152, 170)
        Me.horaSalida.Name = "horaSalida"
        Me.horaSalida.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.horaSalida.Size = New System.Drawing.Size(106, 23)
        Me.horaSalida.TabIndex = 9
        '
        'dtpSalida
        '
        Me.dtpSalida.CustomFormat = "dd/MM/yyyy"
        Me.dtpSalida.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSalida.Location = New System.Drawing.Point(15, 170)
        Me.dtpSalida.Name = "dtpSalida"
        Me.dtpSalida.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpSalida.Size = New System.Drawing.Size(106, 23)
        Me.dtpSalida.TabIndex = 8
        '
        'horaEntrada
        '
        Me.horaEntrada.CustomFormat = "hh:mm"
        Me.horaEntrada.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.horaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.horaEntrada.Location = New System.Drawing.Point(152, 126)
        Me.horaEntrada.Name = "horaEntrada"
        Me.horaEntrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.horaEntrada.Size = New System.Drawing.Size(106, 23)
        Me.horaEntrada.TabIndex = 7
        '
        'dtpEntrada
        '
        Me.dtpEntrada.CustomFormat = "dd/MM/yyyy"
        Me.dtpEntrada.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEntrada.Location = New System.Drawing.Point(15, 126)
        Me.dtpEntrada.Name = "dtpEntrada"
        Me.dtpEntrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpEntrada.Size = New System.Drawing.Size(106, 23)
        Me.dtpEntrada.TabIndex = 6
        '
        'horaTurno
        '
        Me.horaTurno.CustomFormat = "hh:mm"
        Me.horaTurno.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.horaTurno.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.horaTurno.Location = New System.Drawing.Point(152, 82)
        Me.horaTurno.Name = "horaTurno"
        Me.horaTurno.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.horaTurno.Size = New System.Drawing.Size(106, 23)
        Me.horaTurno.TabIndex = 5
        '
        'dtpTurno
        '
        Me.dtpTurno.CustomFormat = "dd/MM/yyyy"
        Me.dtpTurno.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpTurno.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTurno.Location = New System.Drawing.Point(15, 82)
        Me.dtpTurno.Name = "dtpTurno"
        Me.dtpTurno.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpTurno.Size = New System.Drawing.Size(106, 23)
        Me.dtpTurno.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(12, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 17)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Solicitante"
        '
        'cboPersonas
        '
        Me.cboPersonas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPersonas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPersonas.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboPersonas.FormattingEnabled = True
        Me.cboPersonas.Location = New System.Drawing.Point(15, 36)
        Me.cboPersonas.Name = "cboPersonas"
        Me.cboPersonas.Size = New System.Drawing.Size(211, 25)
        Me.cboPersonas.TabIndex = 3
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
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(332, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 17)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Información del Vehículo"
        '
        'PanelInfoVehiculo
        '
        Me.PanelInfoVehiculo.Controls.Add(Me.Label25)
        Me.PanelInfoVehiculo.Controls.Add(Me.CboProgreso)
        Me.PanelInfoVehiculo.Controls.Add(Me.Label24)
        Me.PanelInfoVehiculo.Controls.Add(Me.txtSeñasParticulares)
        Me.PanelInfoVehiculo.Controls.Add(Me.CboTipoReparacion)
        Me.PanelInfoVehiculo.Controls.Add(Me.txtMotivoReparacion)
        Me.PanelInfoVehiculo.Controls.Add(Me.Label8)
        Me.PanelInfoVehiculo.Controls.Add(Me.cboVehiculo)
        Me.PanelInfoVehiculo.Controls.Add(Me.btnAgregarVehiculo)
        Me.PanelInfoVehiculo.Controls.Add(Me.Label7)
        Me.PanelInfoVehiculo.Controls.Add(Me.Label1)
        Me.PanelInfoVehiculo.Controls.Add(Me.chkActivo)
        Me.PanelInfoVehiculo.Location = New System.Drawing.Point(320, 24)
        Me.PanelInfoVehiculo.Name = "PanelInfoVehiculo"
        Me.PanelInfoVehiculo.Size = New System.Drawing.Size(577, 248)
        Me.PanelInfoVehiculo.TabIndex = 10
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(325, 130)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(145, 17)
        Me.Label25.TabIndex = 99
        Me.Label25.Text = "Progreso de la Orden"
        '
        'CboProgreso
        '
        Me.CboProgreso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboProgreso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboProgreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProgreso.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CboProgreso.FormattingEnabled = True
        Me.CboProgreso.Items.AddRange(New Object() {"Iniciada", "Esperando Servicios de Terceros", "Finalizada", "Facturada", "Cancelada"})
        Me.CboProgreso.Location = New System.Drawing.Point(328, 149)
        Me.CboProgreso.Name = "CboProgreso"
        Me.CboProgreso.Size = New System.Drawing.Size(235, 25)
        Me.CboProgreso.TabIndex = 15
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(12, 130)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(134, 17)
        Me.Label24.TabIndex = 97
        Me.Label24.Text = "Tipo de Reparación"
        '
        'txtSeñasParticulares
        '
        Me.txtSeñasParticulares.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSeñasParticulares.Location = New System.Drawing.Point(15, 84)
        Me.txtSeñasParticulares.Name = "txtSeñasParticulares"
        Me.txtSeñasParticulares.Size = New System.Drawing.Size(548, 29)
        Me.txtSeñasParticulares.TabIndex = 13
        Me.txtSeñasParticulares.Text = ""
        '
        'CboTipoReparacion
        '
        Me.CboTipoReparacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboTipoReparacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboTipoReparacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoReparacion.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CboTipoReparacion.FormattingEnabled = True
        Me.CboTipoReparacion.Location = New System.Drawing.Point(15, 149)
        Me.CboTipoReparacion.Name = "CboTipoReparacion"
        Me.CboTipoReparacion.Size = New System.Drawing.Size(299, 25)
        Me.CboTipoReparacion.TabIndex = 14
        '
        'txtMotivoReparacion
        '
        Me.txtMotivoReparacion.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMotivoReparacion.Location = New System.Drawing.Point(15, 207)
        Me.txtMotivoReparacion.Name = "txtMotivoReparacion"
        Me.txtMotivoReparacion.Size = New System.Drawing.Size(548, 29)
        Me.txtMotivoReparacion.TabIndex = 16
        Me.txtMotivoReparacion.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 17)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Mano de obra Propia"
        '
        'PanelCostos
        '
        Me.PanelCostos.Controls.Add(Me.Label28)
        Me.PanelCostos.Controls.Add(Me.txtMontoIVA)
        Me.PanelCostos.Controls.Add(Me.Label27)
        Me.PanelCostos.Controls.Add(Me.txtIVA)
        Me.PanelCostos.Controls.Add(Me.Label26)
        Me.PanelCostos.Controls.Add(Me.txtSubtotal)
        Me.PanelCostos.Controls.Add(Me.btnFacturar)
        Me.PanelCostos.Controls.Add(Me.Label21)
        Me.PanelCostos.Controls.Add(Me.txtMontoTotalOR)
        Me.PanelCostos.Controls.Add(Me.Label5)
        Me.PanelCostos.Controls.Add(Me.Label15)
        Me.PanelCostos.Controls.Add(Me.txtMontoRepuestos)
        Me.PanelCostos.Controls.Add(Me.txtMontoServ3)
        Me.PanelCostos.Controls.Add(Me.Label6)
        Me.PanelCostos.Controls.Add(Me.txtMontoManoObra)
        Me.PanelCostos.Location = New System.Drawing.Point(903, 173)
        Me.PanelCostos.Name = "PanelCostos"
        Me.PanelCostos.Size = New System.Drawing.Size(146, 426)
        Me.PanelCostos.TabIndex = 103
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(10, 266)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(71, 17)
        Me.Label28.TabIndex = 122
        Me.Label28.Text = "Monto IVA"
        '
        'txtMontoIVA
        '
        Me.txtMontoIVA.Enabled = False
        Me.txtMontoIVA.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMontoIVA.Location = New System.Drawing.Point(13, 285)
        Me.txtMontoIVA.Multiline = False
        Me.txtMontoIVA.Name = "txtMontoIVA"
        Me.txtMontoIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMontoIVA.Size = New System.Drawing.Size(124, 29)
        Me.txtMontoIVA.TabIndex = 121
        Me.txtMontoIVA.Text = "0"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(11, 216)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(41, 17)
        Me.Label27.TabIndex = 119
        Me.Label27.Text = "IVA %"
        '
        'txtIVA
        '
        Me.txtIVA.AutoWordSelection = True
        Me.txtIVA.Enabled = False
        Me.txtIVA.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIVA.Location = New System.Drawing.Point(15, 235)
        Me.txtIVA.Multiline = False
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIVA.Size = New System.Drawing.Size(123, 29)
        Me.txtIVA.TabIndex = 120
        Me.txtIVA.Text = "21"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(10, 166)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(59, 17)
        Me.Label26.TabIndex = 117
        Me.Label26.Text = "SubTotal"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.AutoWordSelection = True
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSubtotal.Location = New System.Drawing.Point(14, 185)
        Me.txtSubtotal.Multiline = False
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubtotal.Size = New System.Drawing.Size(123, 29)
        Me.txtSubtotal.TabIndex = 118
        Me.txtSubtotal.Text = "0"
        '
        'btnFacturar
        '
        Me.btnFacturar.BackColor = System.Drawing.Color.Transparent
        Me.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacturar.Enabled = False
        Me.btnFacturar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFacturar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFacturar.ForeColor = System.Drawing.Color.Black
        Me.btnFacturar.Location = New System.Drawing.Point(12, 370)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(117, 37)
        Me.btnFacturar.TabIndex = 116
        Me.btnFacturar.Text = "Facturar"
        Me.btnFacturar.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(10, 316)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(119, 17)
        Me.Label21.TabIndex = 115
        Me.Label21.Text = "Monto Total Orden"
        '
        'txtMontoTotalOR
        '
        Me.txtMontoTotalOR.Enabled = False
        Me.txtMontoTotalOR.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMontoTotalOR.Location = New System.Drawing.Point(13, 335)
        Me.txtMontoTotalOR.Multiline = False
        Me.txtMontoTotalOR.Name = "txtMontoTotalOR"
        Me.txtMontoTotalOR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMontoTotalOR.Size = New System.Drawing.Size(124, 29)
        Me.txtMontoTotalOR.TabIndex = 111
        Me.txtMontoTotalOR.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 66)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 17)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Servicios de Terceros"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(9, 116)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 17)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Repuestos"
        '
        'txtMontoRepuestos
        '
        Me.txtMontoRepuestos.AutoWordSelection = True
        Me.txtMontoRepuestos.Enabled = False
        Me.txtMontoRepuestos.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMontoRepuestos.Location = New System.Drawing.Point(13, 135)
        Me.txtMontoRepuestos.Multiline = False
        Me.txtMontoRepuestos.Name = "txtMontoRepuestos"
        Me.txtMontoRepuestos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMontoRepuestos.Size = New System.Drawing.Size(123, 29)
        Me.txtMontoRepuestos.TabIndex = 110
        Me.txtMontoRepuestos.Text = "0"
        '
        'txtMontoServ3
        '
        Me.txtMontoServ3.AutoWordSelection = True
        Me.txtMontoServ3.Enabled = False
        Me.txtMontoServ3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMontoServ3.Location = New System.Drawing.Point(13, 85)
        Me.txtMontoServ3.Multiline = False
        Me.txtMontoServ3.Name = "txtMontoServ3"
        Me.txtMontoServ3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMontoServ3.Size = New System.Drawing.Size(124, 29)
        Me.txtMontoServ3.TabIndex = 101
        Me.txtMontoServ3.Text = "0"
        '
        'txtMontoManoObra
        '
        Me.txtMontoManoObra.AutoWordSelection = True
        Me.txtMontoManoObra.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMontoManoObra.Location = New System.Drawing.Point(12, 35)
        Me.txtMontoManoObra.Multiline = False
        Me.txtMontoManoObra.Name = "txtMontoManoObra"
        Me.txtMontoManoObra.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMontoManoObra.Size = New System.Drawing.Size(124, 29)
        Me.txtMontoManoObra.TabIndex = 100
        Me.txtMontoManoObra.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(14, -4)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 17)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Servicios de terceros"
        '
        'PanelServiciosTerceros
        '
        Me.PanelServiciosTerceros.Controls.Add(Me.Label9)
        Me.PanelServiciosTerceros.Controls.Add(Me.btnQuitarS3)
        Me.PanelServiciosTerceros.Controls.Add(Me.lblResultadoPrestador)
        Me.PanelServiciosTerceros.Controls.Add(Me.chkActivoS3)
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
        Me.PanelServiciosTerceros.Location = New System.Drawing.Point(40, 610)
        Me.PanelServiciosTerceros.Name = "PanelServiciosTerceros"
        Me.PanelServiciosTerceros.Size = New System.Drawing.Size(1008, 257)
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
        Me.btnQuitarS3.ForeColor = System.Drawing.Color.Black
        Me.btnQuitarS3.Location = New System.Drawing.Point(875, 69)
        Me.btnQuitarS3.Name = "btnQuitarS3"
        Me.btnQuitarS3.Size = New System.Drawing.Size(117, 37)
        Me.btnQuitarS3.TabIndex = 30
        Me.btnQuitarS3.Text = "Quitar"
        Me.btnQuitarS3.UseVisualStyleBackColor = False
        '
        'lblResultadoPrestador
        '
        Me.lblResultadoPrestador.AutoSize = True
        Me.lblResultadoPrestador.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultadoPrestador.ForeColor = System.Drawing.Color.Black
        Me.lblResultadoPrestador.Location = New System.Drawing.Point(160, 70)
        Me.lblResultadoPrestador.Name = "lblResultadoPrestador"
        Me.lblResultadoPrestador.Size = New System.Drawing.Size(69, 17)
        Me.lblResultadoPrestador.TabIndex = 111
        Me.lblResultadoPrestador.Text = "Prestador"
        '
        'chkActivoS3
        '
        Me.chkActivoS3.AutoSize = True
        Me.chkActivoS3.Checked = True
        Me.chkActivoS3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivoS3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivoS3.ForeColor = System.Drawing.Color.Black
        Me.chkActivoS3.Location = New System.Drawing.Point(750, 95)
        Me.chkActivoS3.Name = "chkActivoS3"
        Me.chkActivoS3.Size = New System.Drawing.Size(85, 21)
        Me.chkActivoS3.TabIndex = 28
        Me.chkActivoS3.Text = "¿Activo?"
        Me.chkActivoS3.UseVisualStyleBackColor = True
        Me.chkActivoS3.Visible = False
        '
        'chkAvanceServ3
        '
        Me.chkAvanceServ3.AutoSize = True
        Me.chkAvanceServ3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAvanceServ3.ForeColor = System.Drawing.Color.Black
        Me.chkAvanceServ3.Location = New System.Drawing.Point(626, 95)
        Me.chkAvanceServ3.Name = "chkAvanceServ3"
        Me.chkAvanceServ3.Size = New System.Drawing.Size(108, 21)
        Me.chkAvanceServ3.TabIndex = 27
        Me.chkAvanceServ3.Text = "¿Finalizado?"
        Me.chkAvanceServ3.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(723, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 17)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "Costo Real"
        '
        'txtCostoRealS3
        '
        Me.txtCostoRealS3.AutoWordSelection = True
        Me.txtCostoRealS3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCostoRealS3.Location = New System.Drawing.Point(726, 40)
        Me.txtCostoRealS3.Multiline = False
        Me.txtCostoRealS3.Name = "txtCostoRealS3"
        Me.txtCostoRealS3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCostoRealS3.Size = New System.Drawing.Size(117, 29)
        Me.txtCostoRealS3.TabIndex = 25
        Me.txtCostoRealS3.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(593, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 17)
        Me.Label17.TabIndex = 107
        Me.Label17.Text = "Costo Estimado"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(12, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 17)
        Me.Label16.TabIndex = 105
        Me.Label16.Text = "N° Servicio"
        '
        'txtCostoEstimadoS3
        '
        Me.txtCostoEstimadoS3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCostoEstimadoS3.Location = New System.Drawing.Point(596, 40)
        Me.txtCostoEstimadoS3.Multiline = False
        Me.txtCostoEstimadoS3.Name = "txtCostoEstimadoS3"
        Me.txtCostoEstimadoS3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCostoEstimadoS3.Size = New System.Drawing.Size(117, 29)
        Me.txtCostoEstimadoS3.TabIndex = 24
        Me.txtCostoEstimadoS3.Text = "0"
        '
        'grdServiciosTerceros
        '
        Me.grdServiciosTerceros.AllowUserToAddRows = False
        Me.grdServiciosTerceros.AllowUserToDeleteRows = False
        Me.grdServiciosTerceros.AllowUserToResizeRows = False
        Me.grdServiciosTerceros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdServiciosTerceros.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdServiciosTerceros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdServiciosTerceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdServiciosTerceros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroServicio, Me.ID_Prestador, Me.Prestador, Me.ServSolicitado, Me.CostoEstimado, Me.CostoReal, Me.Finalizado, Me.Estado})
        Me.grdServiciosTerceros.Location = New System.Drawing.Point(15, 139)
        Me.grdServiciosTerceros.MultiSelect = False
        Me.grdServiciosTerceros.Name = "grdServiciosTerceros"
        Me.grdServiciosTerceros.ReadOnly = True
        Me.grdServiciosTerceros.RowHeadersVisible = False
        Me.grdServiciosTerceros.RowHeadersWidth = 51
        Me.grdServiciosTerceros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdServiciosTerceros.Size = New System.Drawing.Size(838, 101)
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
        Me.ServSolicitado.Width = 300
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
        Me.CostoEstimado.Width = 110
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
        Me.CostoReal.Width = 110
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
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(12, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 17)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "Servicio Solicitado a:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(111, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 17)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "Prestador"
        '
        'CboPersonaServ3
        '
        Me.CboPersonaServ3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboPersonaServ3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboPersonaServ3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPersonaServ3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CboPersonaServ3.FormattingEnabled = True
        Me.CboPersonaServ3.Location = New System.Drawing.Point(114, 37)
        Me.CboPersonaServ3.Name = "CboPersonaServ3"
        Me.CboPersonaServ3.Size = New System.Drawing.Size(418, 25)
        Me.CboPersonaServ3.TabIndex = 23
        '
        'btnAgregarServiciosTerceros
        '
        Me.btnAgregarServiciosTerceros.BackgroundImage = CType(resources.GetObject("btnAgregarServiciosTerceros.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarServiciosTerceros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarServiciosTerceros.Location = New System.Drawing.Point(535, 37)
        Me.btnAgregarServiciosTerceros.Name = "btnAgregarServiciosTerceros"
        Me.btnAgregarServiciosTerceros.Size = New System.Drawing.Size(26, 25)
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
        Me.BtnModificarS3.ForeColor = System.Drawing.Color.Black
        Me.BtnModificarS3.Location = New System.Drawing.Point(875, 120)
        Me.BtnModificarS3.Name = "BtnModificarS3"
        Me.BtnModificarS3.Size = New System.Drawing.Size(117, 37)
        Me.BtnModificarS3.TabIndex = 31
        Me.BtnModificarS3.Text = "Modificar"
        Me.BtnModificarS3.UseVisualStyleBackColor = False
        '
        'txtServicioSolicitado
        '
        Me.txtServicioSolicitado.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtServicioSolicitado.Location = New System.Drawing.Point(15, 95)
        Me.txtServicioSolicitado.Name = "txtServicioSolicitado"
        Me.txtServicioSolicitado.Size = New System.Drawing.Size(578, 23)
        Me.txtServicioSolicitado.TabIndex = 26
        '
        'txtID_Serv3
        '
        Me.txtID_Serv3.Enabled = False
        Me.txtID_Serv3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtID_Serv3.Location = New System.Drawing.Point(15, 37)
        Me.txtID_Serv3.Name = "txtID_Serv3"
        Me.txtID_Serv3.Size = New System.Drawing.Size(86, 23)
        Me.txtID_Serv3.TabIndex = 22
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
        Me.BtnCancelarS3.ForeColor = System.Drawing.Color.Black
        Me.BtnCancelarS3.Location = New System.Drawing.Point(875, 171)
        Me.BtnCancelarS3.Name = "BtnCancelarS3"
        Me.BtnCancelarS3.Size = New System.Drawing.Size(117, 37)
        Me.BtnCancelarS3.TabIndex = 32
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
        Me.btnAceptarS3.ForeColor = System.Drawing.Color.Black
        Me.btnAceptarS3.Location = New System.Drawing.Point(875, 18)
        Me.btnAceptarS3.Name = "btnAceptarS3"
        Me.btnAceptarS3.Size = New System.Drawing.Size(117, 37)
        Me.btnAceptarS3.TabIndex = 29
        Me.btnAceptarS3.Text = "Aceptar"
        Me.btnAceptarS3.UseVisualStyleBackColor = False
        '
        'PanelReparaciones
        '
        Me.PanelReparaciones.Controls.Add(Me.grdOrdenReparacion)
        Me.PanelReparaciones.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelReparaciones.Location = New System.Drawing.Point(40, 873)
        Me.PanelReparaciones.Name = "PanelReparaciones"
        Me.PanelReparaciones.Size = New System.Drawing.Size(1008, 250)
        Me.PanelReparaciones.TabIndex = 106
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(54, 867)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(164, 17)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = "Consulta de Reparaciones"
        '
        'PanelDetalleDeRepuestos
        '
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.Label20)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.grdRepuestos)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.btnQuitarRepOR)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.btnAgregarRepOR)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.txtCantidadRepOR)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.Label22)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.cboProductoOR)
        Me.PanelDetalleDeRepuestos.Controls.Add(Me.Label23)
        Me.PanelDetalleDeRepuestos.Location = New System.Drawing.Point(40, 284)
        Me.PanelDetalleDeRepuestos.Name = "PanelDetalleDeRepuestos"
        Me.PanelDetalleDeRepuestos.Size = New System.Drawing.Size(857, 315)
        Me.PanelDetalleDeRepuestos.TabIndex = 17
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(8, -3)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(136, 17)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "Repuestos necesarios"
        '
        'grdRepuestos
        '
        Me.grdRepuestos.AllowUserToAddRows = False
        Me.grdRepuestos.AllowUserToDeleteRows = False
        Me.grdRepuestos.AllowUserToResizeRows = False
        Me.grdRepuestos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
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
        Me.grdRepuestos.Location = New System.Drawing.Point(18, 79)
        Me.grdRepuestos.MultiSelect = False
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
        Me.grdRepuestos.Size = New System.Drawing.Size(836, 227)
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
        Me.ID.Visible = False
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
        Me.Descripcion.Width = 270
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
        Me.Diario.Width = 160
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
        Me.Cantidad.Width = 120
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
        Me.Total.Width = 140
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
        Me.btnQuitarRepOR.ForeColor = System.Drawing.Color.Black
        Me.btnQuitarRepOR.Location = New System.Drawing.Point(730, 23)
        Me.btnQuitarRepOR.Name = "btnQuitarRepOR"
        Me.btnQuitarRepOR.Size = New System.Drawing.Size(117, 37)
        Me.btnQuitarRepOR.TabIndex = 21
        Me.btnQuitarRepOR.Text = "Quitar"
        Me.btnQuitarRepOR.UseVisualStyleBackColor = False
        '
        'btnAgregarRepOR
        '
        Me.btnAgregarRepOR.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarRepOR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarRepOR.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAgregarRepOR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAgregarRepOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarRepOR.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarRepOR.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarRepOR.Location = New System.Drawing.Point(599, 24)
        Me.btnAgregarRepOR.Name = "btnAgregarRepOR"
        Me.btnAgregarRepOR.Size = New System.Drawing.Size(117, 37)
        Me.btnAgregarRepOR.TabIndex = 20
        Me.btnAgregarRepOR.Text = "Agregar"
        Me.btnAgregarRepOR.UseVisualStyleBackColor = False
        '
        'txtCantidadRepOR
        '
        Me.txtCantidadRepOR.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadRepOR.Location = New System.Drawing.Point(518, 29)
        Me.txtCantidadRepOR.Name = "txtCantidadRepOR"
        Me.txtCantidadRepOR.Size = New System.Drawing.Size(66, 23)
        Me.txtCantidadRepOR.TabIndex = 19
        Me.txtCantidadRepOR.Text = "1"
        Me.txtCantidadRepOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(437, 33)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 17)
        Me.Label22.TabIndex = 115
        Me.Label22.Text = "Cantidad:"
        '
        'cboProductoOR
        '
        Me.cboProductoOR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProductoOR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProductoOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductoOR.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProductoOR.FormattingEnabled = True
        Me.cboProductoOR.Location = New System.Drawing.Point(93, 29)
        Me.cboProductoOR.Name = "cboProductoOR"
        Me.cboProductoOR.Size = New System.Drawing.Size(342, 25)
        Me.cboProductoOR.TabIndex = 18
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(15, 33)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 17)
        Me.Label23.TabIndex = 113
        Me.Label23.Text = "Producto:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(908, 162)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(137, 17)
        Me.Label19.TabIndex = 115
        Me.Label19.Text = "Totales por Concepto"
        '
        'frmOrdenesReparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1095, 920)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PanelServiciosTerceros)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.PanelCostos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelInfoVehiculo)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.PanelReparaciones)
        Me.Controls.Add(Me.PanelDetallesOrden)
        Me.Controls.Add(Me.PanelDetalleDeRepuestos)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents Label25 As Label
    Friend WithEvents CboProgreso As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents CboTipoReparacion As ComboBox
    Friend WithEvents btnFacturar As Button
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
    Friend WithEvents Label27 As Label
    Friend WithEvents txtIVA As RichTextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtSubtotal As RichTextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtMontoIVA As RichTextBox
End Class
