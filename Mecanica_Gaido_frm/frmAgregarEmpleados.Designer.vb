﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.txtCuil = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnAgregarUsuario = New System.Windows.Forms.PictureBox()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboSeccion = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.btnAgregarSeccion = New System.Windows.Forms.PictureBox()
        Me.txtNota = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grdEmpleados = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCargaEmpleado = New System.Windows.Forms.Label()
        Me.btnAgregarRol = New System.Windows.Forms.PictureBox()
        Me.cboRol = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaContratacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_ID_Persona = New System.Windows.Forms.TextBox()
        CType(Me.btnAgregarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarSeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnBuscar.FlatAppearance.BorderSize = 2
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(211, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 28)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(440, 103)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(133, 23)
        Me.txtContraseña.TabIndex = 9
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(145, 183)
        Me.txtFechaNacimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(133, 23)
        Me.txtFechaNacimiento.TabIndex = 5
        '
        'txtCuil
        '
        Me.txtCuil.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuil.Location = New System.Drawing.Point(145, 145)
        Me.txtCuil.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCuil.Name = "txtCuil"
        Me.txtCuil.Size = New System.Drawing.Size(133, 23)
        Me.txtCuil.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(145, 29)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(43, 23)
        Me.txtID.TabIndex = 1
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(335, 222)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(85, 21)
        Me.chkEstado.TabIndex = 12
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(332, 109)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 34)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(43, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "CUIL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "ID"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatAppearance.BorderSize = 2
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(645, 98)
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
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(645, 167)
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
        Me.btnAceptar.FlatAppearance.BorderSize = 2
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(645, 29)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 37)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.BackgroundImage = CType(resources.GetObject("btnAgregarUsuario.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(578, 65)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarUsuario.TabIndex = 59
        Me.btnAgregarUsuario.TabStop = False
        '
        'cboUsuario
        '
        Me.cboUsuario.DisplayMember = "Nombre"
        Me.cboUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsuario.FormattingEnabled = True
        Me.cboUsuario.Location = New System.Drawing.Point(440, 65)
        Me.cboUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(133, 25)
        Me.cboUsuario.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(332, 71)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 17)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Usuario"
        '
        'cboSeccion
        '
        Me.cboSeccion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSeccion.FormattingEnabled = True
        Me.cboSeccion.Location = New System.Drawing.Point(145, 105)
        Me.cboSeccion.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSeccion.Name = "cboSeccion"
        Me.cboSeccion.Size = New System.Drawing.Size(133, 25)
        Me.cboSeccion.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(43, 113)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Seccion"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Location = New System.Drawing.Point(777, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(20, 20)
        Me.btnCerrar.TabIndex = 61
        Me.btnCerrar.TabStop = False
        '
        'btnAgregarSeccion
        '
        Me.btnAgregarSeccion.BackgroundImage = CType(resources.GetObject("btnAgregarSeccion.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarSeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarSeccion.Location = New System.Drawing.Point(283, 105)
        Me.btnAgregarSeccion.Name = "btnAgregarSeccion"
        Me.btnAgregarSeccion.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarSeccion.TabIndex = 62
        Me.btnAgregarSeccion.TabStop = False
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(440, 181)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(164, 59)
        Me.txtNota.TabIndex = 11
        Me.txtNota.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(332, 185)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 17)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Nota"
        '
        'grdEmpleados
        '
        Me.grdEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.grdEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEmpleados.Location = New System.Drawing.Point(47, 271)
        Me.grdEmpleados.Name = "grdEmpleados"
        Me.grdEmpleados.ReadOnly = True
        Me.grdEmpleados.RowHeadersWidth = 51
        Me.grdEmpleados.Size = New System.Drawing.Size(703, 146)
        Me.grdEmpleados.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(43, 73)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Empleado"
        '
        'lblCargaEmpleado
        '
        Me.lblCargaEmpleado.AutoSize = True
        Me.lblCargaEmpleado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargaEmpleado.ForeColor = System.Drawing.Color.White
        Me.lblCargaEmpleado.Location = New System.Drawing.Point(142, 73)
        Me.lblCargaEmpleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCargaEmpleado.Name = "lblCargaEmpleado"
        Me.lblCargaEmpleado.Size = New System.Drawing.Size(0, 17)
        Me.lblCargaEmpleado.TabIndex = 66
        '
        'btnAgregarRol
        '
        Me.btnAgregarRol.BackgroundImage = CType(resources.GetObject("btnAgregarRol.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarRol.Location = New System.Drawing.Point(578, 141)
        Me.btnAgregarRol.Name = "btnAgregarRol"
        Me.btnAgregarRol.Size = New System.Drawing.Size(26, 25)
        Me.btnAgregarRol.TabIndex = 69
        Me.btnAgregarRol.TabStop = False
        '
        'cboRol
        '
        Me.cboRol.DisplayMember = "Nombre"
        Me.cboRol.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRol.FormattingEnabled = True
        Me.cboRol.Location = New System.Drawing.Point(440, 141)
        Me.cboRol.Margin = New System.Windows.Forms.Padding(2)
        Me.cboRol.Name = "cboRol"
        Me.cboRol.Size = New System.Drawing.Size(133, 25)
        Me.cboRol.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(332, 147)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 17)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Rol"
        '
        'txtFechaContratacion
        '
        Me.txtFechaContratacion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaContratacion.Location = New System.Drawing.Point(145, 221)
        Me.txtFechaContratacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFechaContratacion.Name = "txtFechaContratacion"
        Me.txtFechaContratacion.Size = New System.Drawing.Size(133, 23)
        Me.txtFechaContratacion.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(43, 217)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 34)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Fecha de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contratación"
        '
        'txtCargo
        '
        Me.txtCargo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(440, 29)
        Me.txtCargo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(133, 23)
        Me.txtCargo.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(332, 35)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 17)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Cargo"
        '
        'txt_ID_Persona
        '
        Me.txt_ID_Persona.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID_Persona.Location = New System.Drawing.Point(80, 29)
        Me.txt_ID_Persona.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ID_Persona.Name = "txt_ID_Persona"
        Me.txt_ID_Persona.Size = New System.Drawing.Size(43, 23)
        Me.txt_ID_Persona.TabIndex = 73
        Me.txt_ID_Persona.Visible = False
        '
        'frmAgregarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_ID_Persona)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtFechaContratacion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnAgregarRol)
        Me.Controls.Add(Me.cboRol)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCargaEmpleado)
        Me.Controls.Add(Me.grdEmpleados)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnAgregarSeccion)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAgregarUsuario)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboSeccion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtFechaNacimiento)
        Me.Controls.Add(Me.txtCuil)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        CType(Me.btnAgregarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarSeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtFechaNacimiento As TextBox
    Friend WithEvents txtCuil As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnAgregarUsuario As PictureBox
    Friend WithEvents cboUsuario As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboSeccion As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnAgregarSeccion As PictureBox
    Friend WithEvents txtNota As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents grdEmpleados As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCargaEmpleado As Label
    Friend WithEvents btnAgregarRol As PictureBox
    Friend WithEvents cboRol As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFechaContratacion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCargo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_ID_Persona As TextBox
End Class
