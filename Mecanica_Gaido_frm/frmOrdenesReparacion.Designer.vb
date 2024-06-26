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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaentrada = New System.Windows.Forms.TextBox()
        Me.txtFechaturno = New System.Windows.Forms.TextBox()
        Me.cboVehiculo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboServicios = New System.Windows.Forms.ComboBox()
        Me.cboCuenta = New System.Windows.Forms.ComboBox()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.txtSeñasParticulares = New System.Windows.Forms.TextBox()
        Me.txtFechaestimada = New System.Windows.Forms.TextBox()
        Me.txtFechasalida = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnAgregarCuenta = New System.Windows.Forms.PictureBox()
        Me.btnAgregarServiciosTerceros = New System.Windows.Forms.PictureBox()
        Me.btnAgregarMarca = New System.Windows.Forms.PictureBox()
        CType(Me.grdOrdenReparacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarServiciosTerceros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdOrdenReparacion
        '
        Me.grdOrdenReparacion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdOrdenReparacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdOrdenReparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOrdenReparacion.Location = New System.Drawing.Point(54, 338)
        Me.grdOrdenReparacion.Name = "grdOrdenReparacion"
        Me.grdOrdenReparacion.ReadOnly = True
        Me.grdOrdenReparacion.Size = New System.Drawing.Size(843, 241)
        Me.grdOrdenReparacion.TabIndex = 89
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.White
        Me.chkActivo.Location = New System.Drawing.Point(394, 245)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(85, 21)
        Me.chkActivo.TabIndex = 87
        Me.chkActivo.Text = "¿Activo?"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(391, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 17)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Servicios de terceros"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(391, 123)
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
        Me.Label3.Location = New System.Drawing.Point(391, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Fecha Estimada Salida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(391, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Fecha Entrada"
        '
        'txtFechaentrada
        '
        Me.txtFechaentrada.Location = New System.Drawing.Point(569, 37)
        Me.txtFechaentrada.Name = "txtFechaentrada"
        Me.txtFechaentrada.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaentrada.TabIndex = 82
        '
        'txtFechaturno
        '
        Me.txtFechaturno.Location = New System.Drawing.Point(205, 207)
        Me.txtFechaturno.Name = "txtFechaturno"
        Me.txtFechaturno.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaturno.TabIndex = 81
        '
        'cboVehiculo
        '
        Me.cboVehiculo.FormattingEnabled = True
        Me.cboVehiculo.Location = New System.Drawing.Point(206, 80)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(121, 21)
        Me.cboVehiculo.TabIndex = 80
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(391, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 17)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Cuenta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(51, 208)
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
        Me.Label1.Location = New System.Drawing.Point(51, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Motivo de reparación"
        '
        'cboServicios
        '
        Me.cboServicios.FormattingEnabled = True
        Me.cboServicios.Location = New System.Drawing.Point(569, 206)
        Me.cboServicios.Name = "cboServicios"
        Me.cboServicios.Size = New System.Drawing.Size(121, 21)
        Me.cboServicios.TabIndex = 75
        '
        'cboCuenta
        '
        Me.cboCuenta.FormattingEnabled = True
        Me.cboCuenta.Location = New System.Drawing.Point(569, 164)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(121, 21)
        Me.cboCuenta.TabIndex = 74
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(206, 164)
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(121, 20)
        Me.txtMotivo.TabIndex = 73
        '
        'txtSeñasParticulares
        '
        Me.txtSeñasParticulares.Location = New System.Drawing.Point(205, 122)
        Me.txtSeñasParticulares.Name = "txtSeñasParticulares"
        Me.txtSeñasParticulares.Size = New System.Drawing.Size(121, 20)
        Me.txtSeñasParticulares.TabIndex = 72
        '
        'txtFechaestimada
        '
        Me.txtFechaestimada.Location = New System.Drawing.Point(569, 80)
        Me.txtFechaestimada.Name = "txtFechaestimada"
        Me.txtFechaestimada.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaestimada.TabIndex = 71
        '
        'txtFechasalida
        '
        Me.txtFechasalida.Location = New System.Drawing.Point(569, 122)
        Me.txtFechasalida.Name = "txtFechasalida"
        Me.txtFechasalida.Size = New System.Drawing.Size(121, 20)
        Me.txtFechasalida.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(51, 81)
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
        Me.Label7.Location = New System.Drawing.Point(51, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 17)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Señas Particulares"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(51, 38)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(21, 17)
        Me.lbl1.TabIndex = 67
        Me.lbl1.Text = "ID"
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
        Me.btnModificar.Location = New System.Drawing.Point(763, 118)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(117, 37)
        Me.btnModificar.TabIndex = 93
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
        Me.btnCancelar.Location = New System.Drawing.Point(763, 181)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 37)
        Me.btnCancelar.TabIndex = 92
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
        Me.btnAceptar.Location = New System.Drawing.Point(763, 55)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 37)
        Me.btnAceptar.TabIndex = 91
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
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
        Me.btnBuscar.Location = New System.Drawing.Point(276, 31)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 28)
        Me.btnBuscar.TabIndex = 90
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(205, 37)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(43, 20)
        Me.txtID.TabIndex = 94
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.BackgroundImage = CType(resources.GetObject("btnAgregarCuenta.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(696, 164)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(26, 21)
        Me.btnAgregarCuenta.TabIndex = 95
        Me.btnAgregarCuenta.TabStop = False
        '
        'btnAgregarServiciosTerceros
        '
        Me.btnAgregarServiciosTerceros.BackgroundImage = CType(resources.GetObject("btnAgregarServiciosTerceros.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarServiciosTerceros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarServiciosTerceros.Location = New System.Drawing.Point(696, 206)
        Me.btnAgregarServiciosTerceros.Name = "btnAgregarServiciosTerceros"
        Me.btnAgregarServiciosTerceros.Size = New System.Drawing.Size(26, 21)
        Me.btnAgregarServiciosTerceros.TabIndex = 96
        Me.btnAgregarServiciosTerceros.TabStop = False
        '
        'btnAgregarMarca
        '
        Me.btnAgregarMarca.BackgroundImage = CType(resources.GetObject("btnAgregarMarca.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarMarca.Location = New System.Drawing.Point(333, 81)
        Me.btnAgregarMarca.Name = "btnAgregarMarca"
        Me.btnAgregarMarca.Size = New System.Drawing.Size(26, 21)
        Me.btnAgregarMarca.TabIndex = 97
        Me.btnAgregarMarca.TabStop = False
        '
        'frmOrdenesReparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(955, 620)
        Me.Controls.Add(Me.btnAgregarMarca)
        Me.Controls.Add(Me.btnAgregarServiciosTerceros)
        Me.Controls.Add(Me.btnAgregarCuenta)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.grdOrdenReparacion)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFechaentrada)
        Me.Controls.Add(Me.txtFechaturno)
        Me.Controls.Add(Me.cboVehiculo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboServicios)
        Me.Controls.Add(Me.cboCuenta)
        Me.Controls.Add(Me.txtMotivo)
        Me.Controls.Add(Me.txtSeñasParticulares)
        Me.Controls.Add(Me.txtFechaestimada)
        Me.Controls.Add(Me.txtFechasalida)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdenesReparacion"
        Me.Text = "Orden de reparacion"
        CType(Me.grdOrdenReparacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarServiciosTerceros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdOrdenReparacion As DataGridView
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFechaentrada As TextBox
    Friend WithEvents txtFechaturno As TextBox
    Friend WithEvents cboVehiculo As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboServicios As ComboBox
    Friend WithEvents cboCuenta As ComboBox
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents txtSeñasParticulares As TextBox
    Friend WithEvents txtFechaestimada As TextBox
    Friend WithEvents txtFechasalida As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnAgregarCuenta As PictureBox
    Friend WithEvents btnAgregarServiciosTerceros As PictureBox
    Friend WithEvents btnAgregarMarca As PictureBox
End Class
