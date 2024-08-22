<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarEmpleados))
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.cboSeccion = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.btnAgregarSeccion = New System.Windows.Forms.PictureBox()
        Me.txtNota = New System.Windows.Forms.RichTextBox()
        Me.grdEmpleados = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCargaEmpleado = New System.Windows.Forms.Label()
        Me.btnAgregarRol = New System.Windows.Forms.PictureBox()
        Me.cboRol = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCargaCuil = New System.Windows.Forms.Label()
        Me.lblCargaFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblDatosPersonales = New System.Windows.Forms.Label()
        Me.PanelDatosPersonales = New System.Windows.Forms.Panel()
        Me.lblDetallesContratación = New System.Windows.Forms.Label()
        Me.PanelDetallesContratación = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFechaContratacion = New System.Windows.Forms.DateTimePicker()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PanelUsuario = New System.Windows.Forms.Panel()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.PanelNotas = New System.Windows.Forms.Panel()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarSeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatosPersonales.SuspendLayout()
        Me.PanelDetallesContratación.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelNotas.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnBuscar.Location = New System.Drawing.Point(357, 30)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(67, 34)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(20, 100)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(273, 27)
        Me.txtContraseña.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(208, 36)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(80, 27)
        Me.txtID.TabIndex = 1
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(20, 180)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(108, 25)
        Me.chkEstado.TabIndex = 9
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 21)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 21)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Fecha de Nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 21)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(57, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "N° Empleado"
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
        Me.btnModificar.Location = New System.Drawing.Point(881, 213)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(156, 46)
        Me.btnModificar.TabIndex = 12
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
        Me.btnCancelar.Location = New System.Drawing.Point(881, 367)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(156, 46)
        Me.btnCancelar.TabIndex = 13
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
        Me.btnAceptar.Location = New System.Drawing.Point(881, 59)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(156, 46)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(19, 20)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(77, 21)
        Me.lblNombre.TabIndex = 57
        Me.lblNombre.Text = "Nombre"
        '
        'cboSeccion
        '
        Me.cboSeccion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSeccion.FormattingEnabled = True
        Me.cboSeccion.Location = New System.Drawing.Point(20, 146)
        Me.cboSeccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboSeccion.Name = "cboSeccion"
        Me.cboSeccion.Size = New System.Drawing.Size(232, 29)
        Me.cboSeccion.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 21)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Seccion"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Location = New System.Drawing.Point(1036, 4)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(27, 25)
        Me.btnCerrar.TabIndex = 61
        Me.btnCerrar.TabStop = False
        '
        'btnAgregarSeccion
        '
        Me.btnAgregarSeccion.BackgroundImage = CType(resources.GetObject("btnAgregarSeccion.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarSeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarSeccion.Location = New System.Drawing.Point(260, 146)
        Me.btnAgregarSeccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarSeccion.Name = "btnAgregarSeccion"
        Me.btnAgregarSeccion.Size = New System.Drawing.Size(35, 31)
        Me.btnAgregarSeccion.TabIndex = 62
        Me.btnAgregarSeccion.TabStop = False
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(20, 34)
        Me.txtNota.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(332, 82)
        Me.txtNota.TabIndex = 10
        Me.txtNota.Text = ""
        '
        'grdEmpleados
        '
        Me.grdEmpleados.AllowUserToAddRows = False
        Me.grdEmpleados.AllowUserToDeleteRows = False
        Me.grdEmpleados.AllowUserToResizeRows = False
        Me.grdEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.grdEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.grdEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEmpleados.Location = New System.Drawing.Point(61, 455)
        Me.grdEmpleados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdEmpleados.Name = "grdEmpleados"
        Me.grdEmpleados.ReadOnly = True
        Me.grdEmpleados.RowHeadersWidth = 51
        Me.grdEmpleados.Size = New System.Drawing.Size(976, 239)
        Me.grdEmpleados.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 21)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Empleado"
        '
        'lblCargaEmpleado
        '
        Me.lblCargaEmpleado.AutoSize = True
        Me.lblCargaEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblCargaEmpleado.ForeColor = System.Drawing.Color.White
        Me.lblCargaEmpleado.Location = New System.Drawing.Point(121, 22)
        Me.lblCargaEmpleado.Name = "lblCargaEmpleado"
        Me.lblCargaEmpleado.Size = New System.Drawing.Size(17, 20)
        Me.lblCargaEmpleado.TabIndex = 66
        Me.lblCargaEmpleado.Text = "1"
        '
        'btnAgregarRol
        '
        Me.btnAgregarRol.BackgroundImage = CType(resources.GetObject("btnAgregarRol.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarRol.Location = New System.Drawing.Point(260, 154)
        Me.btnAgregarRol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarRol.Name = "btnAgregarRol"
        Me.btnAgregarRol.Size = New System.Drawing.Size(35, 31)
        Me.btnAgregarRol.TabIndex = 69
        Me.btnAgregarRol.TabStop = False
        '
        'cboRol
        '
        Me.cboRol.DisplayMember = "Nombre"
        Me.cboRol.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRol.FormattingEnabled = True
        Me.cboRol.Location = New System.Drawing.Point(20, 154)
        Me.cboRol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboRol.Name = "cboRol"
        Me.cboRol.Size = New System.Drawing.Size(232, 29)
        Me.cboRol.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 21)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Rol"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(16, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 21)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Fecha de Contratación"
        '
        'txtCargo
        '
        Me.txtCargo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(20, 95)
        Me.txtCargo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(273, 27)
        Me.txtCargo.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(16, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 21)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Cargo"
        '
        'lblCargaCuil
        '
        Me.lblCargaCuil.AutoSize = True
        Me.lblCargaCuil.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblCargaCuil.ForeColor = System.Drawing.Color.White
        Me.lblCargaCuil.Location = New System.Drawing.Point(128, 48)
        Me.lblCargaCuil.Name = "lblCargaCuil"
        Me.lblCargaCuil.Size = New System.Drawing.Size(17, 20)
        Me.lblCargaCuil.TabIndex = 73
        Me.lblCargaCuil.Text = "2"
        '
        'lblCargaFechaNacimiento
        '
        Me.lblCargaFechaNacimiento.AutoSize = True
        Me.lblCargaFechaNacimiento.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblCargaFechaNacimiento.ForeColor = System.Drawing.Color.White
        Me.lblCargaFechaNacimiento.Location = New System.Drawing.Point(219, 74)
        Me.lblCargaFechaNacimiento.Name = "lblCargaFechaNacimiento"
        Me.lblCargaFechaNacimiento.Size = New System.Drawing.Size(17, 20)
        Me.lblCargaFechaNacimiento.TabIndex = 74
        Me.lblCargaFechaNacimiento.Text = "3"
        '
        'lblDatosPersonales
        '
        Me.lblDatosPersonales.AutoSize = True
        Me.lblDatosPersonales.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblDatosPersonales.ForeColor = System.Drawing.Color.White
        Me.lblDatosPersonales.Location = New System.Drawing.Point(77, 73)
        Me.lblDatosPersonales.Name = "lblDatosPersonales"
        Me.lblDatosPersonales.Size = New System.Drawing.Size(133, 20)
        Me.lblDatosPersonales.TabIndex = 80
        Me.lblDatosPersonales.Text = "Datos Personales"
        '
        'PanelDatosPersonales
        '
        Me.PanelDatosPersonales.Controls.Add(Me.Label6)
        Me.PanelDatosPersonales.Controls.Add(Me.lblCargaEmpleado)
        Me.PanelDatosPersonales.Controls.Add(Me.lblCargaFechaNacimiento)
        Me.PanelDatosPersonales.Controls.Add(Me.Label3)
        Me.PanelDatosPersonales.Controls.Add(Me.lblCargaCuil)
        Me.PanelDatosPersonales.Controls.Add(Me.Label4)
        Me.PanelDatosPersonales.Location = New System.Drawing.Point(61, 82)
        Me.PanelDatosPersonales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelDatosPersonales.Name = "PanelDatosPersonales"
        Me.PanelDatosPersonales.Size = New System.Drawing.Size(375, 114)
        Me.PanelDatosPersonales.TabIndex = 81
        '
        'lblDetallesContratación
        '
        Me.lblDetallesContratación.AutoSize = True
        Me.lblDetallesContratación.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblDetallesContratación.ForeColor = System.Drawing.Color.White
        Me.lblDetallesContratación.Location = New System.Drawing.Point(77, 213)
        Me.lblDetallesContratación.Name = "lblDetallesContratación"
        Me.lblDetallesContratación.Size = New System.Drawing.Size(193, 20)
        Me.lblDetallesContratación.TabIndex = 82
        Me.lblDetallesContratación.Text = "Detalles de Contratación"
        '
        'PanelDetallesContratación
        '
        Me.PanelDetallesContratación.Controls.Add(Me.Label12)
        Me.PanelDetallesContratación.Controls.Add(Me.Label9)
        Me.PanelDetallesContratación.Controls.Add(Me.Label8)
        Me.PanelDetallesContratación.Controls.Add(Me.dtpFechaContratacion)
        Me.PanelDetallesContratación.Controls.Add(Me.Label10)
        Me.PanelDetallesContratación.Controls.Add(Me.Label11)
        Me.PanelDetallesContratación.Controls.Add(Me.txtCargo)
        Me.PanelDetallesContratación.Controls.Add(Me.Label7)
        Me.PanelDetallesContratación.Controls.Add(Me.cboSeccion)
        Me.PanelDetallesContratación.Controls.Add(Me.btnAgregarSeccion)
        Me.PanelDetallesContratación.Controls.Add(Me.chkEstado)
        Me.PanelDetallesContratación.Location = New System.Drawing.Point(61, 223)
        Me.PanelDetallesContratación.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelDetallesContratación.Name = "PanelDetallesContratación"
        Me.PanelDetallesContratación.Size = New System.Drawing.Size(375, 210)
        Me.PanelDetallesContratación.TabIndex = 83
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(93, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 21)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "*"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(83, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 21)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(229, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 21)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "*"
        '
        'dtpFechaContratacion
        '
        Me.dtpFechaContratacion.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpFechaContratacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaContratacion.Location = New System.Drawing.Point(20, 43)
        Me.dtpFechaContratacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFechaContratacion.Name = "dtpFechaContratacion"
        Me.dtpFechaContratacion.Size = New System.Drawing.Size(273, 27)
        Me.dtpFechaContratacion.TabIndex = 6
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(489, 30)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(63, 20)
        Me.lblUsuario.TabIndex = 84
        Me.lblUsuario.Text = "Usuario"
        '
        'PanelUsuario
        '
        Me.PanelUsuario.Controls.Add(Me.txtUsuario)
        Me.PanelUsuario.Controls.Add(Me.Label15)
        Me.PanelUsuario.Controls.Add(Me.Label14)
        Me.PanelUsuario.Controls.Add(Me.Label13)
        Me.PanelUsuario.Controls.Add(Me.Label5)
        Me.PanelUsuario.Controls.Add(Me.txtContraseña)
        Me.PanelUsuario.Controls.Add(Me.lblNombre)
        Me.PanelUsuario.Controls.Add(Me.Label2)
        Me.PanelUsuario.Controls.Add(Me.btnAgregarRol)
        Me.PanelUsuario.Controls.Add(Me.cboRol)
        Me.PanelUsuario.Location = New System.Drawing.Point(473, 39)
        Me.PanelUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelUsuario.Name = "PanelUsuario"
        Me.PanelUsuario.Size = New System.Drawing.Size(375, 207)
        Me.PanelUsuario.TabIndex = 85
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(20, 43)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(273, 27)
        Me.txtUsuario.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(53, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 21)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(128, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 21)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(100, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 21)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "*"
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblNota.ForeColor = System.Drawing.Color.White
        Me.lblNota.Location = New System.Drawing.Point(489, 276)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(168, 20)
        Me.lblNota.TabIndex = 86
        Me.lblNota.Text = "Nota (250 caracteres)"
        '
        'PanelNotas
        '
        Me.PanelNotas.Controls.Add(Me.txtNota)
        Me.PanelNotas.Location = New System.Drawing.Point(473, 286)
        Me.PanelNotas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelNotas.Name = "PanelNotas"
        Me.PanelNotas.Size = New System.Drawing.Size(375, 148)
        Me.PanelNotas.TabIndex = 87
        '
        'frmAgregarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1091, 645)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.PanelNotas)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.PanelUsuario)
        Me.Controls.Add(Me.lblDetallesContratación)
        Me.Controls.Add(Me.PanelDetallesContratación)
        Me.Controls.Add(Me.lblDatosPersonales)
        Me.Controls.Add(Me.PanelDatosPersonales)
        Me.Controls.Add(Me.grdEmpleados)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAgregarEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarSeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatosPersonales.ResumeLayout(False)
        Me.PanelDatosPersonales.PerformLayout()
        Me.PanelDetallesContratación.ResumeLayout(False)
        Me.PanelDetallesContratación.PerformLayout()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelNotas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents cboSeccion As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnAgregarSeccion As PictureBox
    Friend WithEvents txtNota As RichTextBox
    Friend WithEvents grdEmpleados As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCargaEmpleado As Label
    Friend WithEvents btnAgregarRol As PictureBox
    Friend WithEvents cboRol As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCargo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCargaCuil As Label
    Friend WithEvents lblCargaFechaNacimiento As Label
    Friend WithEvents lblDatosPersonales As Label
    Friend WithEvents PanelDatosPersonales As Panel
    Friend WithEvents lblDetallesContratación As Label
    Friend WithEvents PanelDetallesContratación As Panel
    Friend WithEvents dtpFechaContratacion As DateTimePicker
    Friend WithEvents lblUsuario As Label
    Friend WithEvents PanelUsuario As Panel
    Friend WithEvents lblNota As Label
    Friend WithEvents PanelNotas As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtUsuario As TextBox
End Class
