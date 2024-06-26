<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductos))
        Me.grdProductos = New System.Windows.Forms.DataGridView()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNumeroFila = New System.Windows.Forms.TextBox()
        Me.txtCodigoBarra = New System.Windows.Forms.TextBox()
        Me.txtFabricante = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLista = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.cboOriginal = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.txtNombreDiario = New System.Windows.Forms.TextBox()
        Me.txtFechaUltCompra = New System.Windows.Forms.TextBox()
        Me.txtCantidadBulto = New System.Windows.Forms.TextBox()
        Me.txtStockReal = New System.Windows.Forms.TextBox()
        Me.txtFechaUltVenta = New System.Windows.Forms.TextBox()
        Me.txtStockDisponible = New System.Windows.Forms.TextBox()
        Me.txtEstanteria = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.cboRubro = New System.Windows.Forms.ComboBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.chkAlternativo = New System.Windows.Forms.CheckBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUtilidad = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregarMarca = New System.Windows.Forms.PictureBox()
        Me.btnAgregarRubro = New System.Windows.Forms.PictureBox()
        CType(Me.grdProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarRubro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdProductos
        '
        Me.grdProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProductos.Location = New System.Drawing.Point(42, 379)
        Me.grdProductos.Name = "grdProductos"
        Me.grdProductos.ReadOnly = True
        Me.grdProductos.Size = New System.Drawing.Size(868, 209)
        Me.grdProductos.TabIndex = 93
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.White
        Me.chkActivo.Location = New System.Drawing.Point(526, 320)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(85, 21)
        Me.chkActivo.TabIndex = 91
        Me.chkActivo.Text = "¿Activo?"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(390, 292)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 17)
        Me.Label19.TabIndex = 90
        Me.Label19.Text = "Origen"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(389, 187)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 17)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "Cod. Estanteria"
        '
        'txtNumeroFila
        '
        Me.txtNumeroFila.Location = New System.Drawing.Point(526, 210)
        Me.txtNumeroFila.Name = "txtNumeroFila"
        Me.txtNumeroFila.Size = New System.Drawing.Size(121, 20)
        Me.txtNumeroFila.TabIndex = 88
        '
        'txtCodigoBarra
        '
        Me.txtCodigoBarra.Location = New System.Drawing.Point(526, 236)
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.Size = New System.Drawing.Size(121, 20)
        Me.txtCodigoBarra.TabIndex = 87
        '
        'txtFabricante
        '
        Me.txtFabricante.Location = New System.Drawing.Point(526, 261)
        Me.txtFabricante.Name = "txtFabricante"
        Me.txtFabricante.Size = New System.Drawing.Size(121, 20)
        Me.txtFabricante.TabIndex = 86
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(526, 289)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(121, 20)
        Me.txtOrigen.TabIndex = 85
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(389, 161)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 17)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "Fecha. Ult. Venta"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(390, 134)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 17)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Fecha. Ult. Compra"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(390, 239)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 17)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Cod. de Barra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(390, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Cod. Fabricante"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(390, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "N° de Fila"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(389, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Precio Compra"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(39, 292)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 17)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "Stock Disponible"
        '
        'txtLista
        '
        Me.txtLista.Location = New System.Drawing.Point(526, 79)
        Me.txtLista.Name = "txtLista"
        Me.txtLista.Size = New System.Drawing.Size(121, 20)
        Me.txtLista.TabIndex = 74
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(39, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 17)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Stock Real"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(39, 239)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 17)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Cant. Por Bulto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(389, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 17)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Precio Lista"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(39, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 17)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Rubro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Marca"
        '
        'cboMarca
        '
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(175, 131)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(121, 21)
        Me.cboMarca.TabIndex = 68
        '
        'cboOriginal
        '
        Me.cboOriginal.FormattingEnabled = True
        Me.cboOriginal.Location = New System.Drawing.Point(175, 209)
        Me.cboOriginal.Name = "cboOriginal"
        Me.cboOriginal.Size = New System.Drawing.Size(121, 21)
        Me.cboOriginal.TabIndex = 67
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(175, 79)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(121, 20)
        Me.txtDescripcion.TabIndex = 66
        '
        'txtCompra
        '
        Me.txtCompra.Location = New System.Drawing.Point(526, 52)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(121, 20)
        Me.txtCompra.TabIndex = 65
        '
        'txtNombreDiario
        '
        Me.txtNombreDiario.Location = New System.Drawing.Point(175, 105)
        Me.txtNombreDiario.Name = "txtNombreDiario"
        Me.txtNombreDiario.Size = New System.Drawing.Size(121, 20)
        Me.txtNombreDiario.TabIndex = 64
        '
        'txtFechaUltCompra
        '
        Me.txtFechaUltCompra.Location = New System.Drawing.Point(526, 131)
        Me.txtFechaUltCompra.Name = "txtFechaUltCompra"
        Me.txtFechaUltCompra.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaUltCompra.TabIndex = 63
        '
        'txtCantidadBulto
        '
        Me.txtCantidadBulto.Location = New System.Drawing.Point(175, 236)
        Me.txtCantidadBulto.Name = "txtCantidadBulto"
        Me.txtCantidadBulto.Size = New System.Drawing.Size(121, 20)
        Me.txtCantidadBulto.TabIndex = 62
        '
        'txtStockReal
        '
        Me.txtStockReal.Location = New System.Drawing.Point(175, 261)
        Me.txtStockReal.Name = "txtStockReal"
        Me.txtStockReal.Size = New System.Drawing.Size(121, 20)
        Me.txtStockReal.TabIndex = 61
        '
        'txtFechaUltVenta
        '
        Me.txtFechaUltVenta.Location = New System.Drawing.Point(526, 158)
        Me.txtFechaUltVenta.Name = "txtFechaUltVenta"
        Me.txtFechaUltVenta.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaUltVenta.TabIndex = 60
        '
        'txtStockDisponible
        '
        Me.txtStockDisponible.Location = New System.Drawing.Point(175, 289)
        Me.txtStockDisponible.Name = "txtStockDisponible"
        Me.txtStockDisponible.Size = New System.Drawing.Size(121, 20)
        Me.txtStockDisponible.TabIndex = 59
        '
        'txtEstanteria
        '
        Me.txtEstanteria.Location = New System.Drawing.Point(526, 183)
        Me.txtEstanteria.Name = "txtEstanteria"
        Me.txtEstanteria.Size = New System.Drawing.Size(121, 20)
        Me.txtEstanteria.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(39, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 17)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Descripcion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(39, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 17)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Nombre Diario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(39, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 17)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Nombre de Original"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(39, 55)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(21, 17)
        Me.lbl1.TabIndex = 53
        Me.lbl1.Text = "ID"
        '
        'cboRubro
        '
        Me.cboRubro.FormattingEnabled = True
        Me.cboRubro.Location = New System.Drawing.Point(175, 158)
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Size = New System.Drawing.Size(121, 21)
        Me.cboRubro.TabIndex = 52
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(175, 52)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(50, 20)
        Me.txtId.TabIndex = 97
        '
        'chkAlternativo
        '
        Me.chkAlternativo.AutoSize = True
        Me.chkAlternativo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlternativo.ForeColor = System.Drawing.Color.White
        Me.chkAlternativo.Location = New System.Drawing.Point(175, 185)
        Me.chkAlternativo.Name = "chkAlternativo"
        Me.chkAlternativo.Size = New System.Drawing.Size(114, 21)
        Me.chkAlternativo.TabIndex = 98
        Me.chkAlternativo.Text = "¿Alternativo?"
        Me.chkAlternativo.UseVisualStyleBackColor = True
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
        Me.btnBuscar.Location = New System.Drawing.Point(246, 45)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 28)
        Me.btnBuscar.TabIndex = 99
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(390, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Utilidad"
        '
        'txtUtilidad
        '
        Me.txtUtilidad.Location = New System.Drawing.Point(526, 105)
        Me.txtUtilidad.Name = "txtUtilidad"
        Me.txtUtilidad.Size = New System.Drawing.Size(121, 20)
        Me.txtUtilidad.TabIndex = 100
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
        Me.btnAceptar.Location = New System.Drawing.Point(802, 49)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(82, 28)
        Me.btnAceptar.TabIndex = 102
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(802, 183)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(82, 28)
        Me.btnCancelar.TabIndex = 103
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnModificar.Location = New System.Drawing.Point(802, 116)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(82, 28)
        Me.btnModificar.TabIndex = 104
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregarMarca
        '
        Me.btnAgregarMarca.BackgroundImage = CType(resources.GetObject("btnAgregarMarca.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarMarca.Location = New System.Drawing.Point(312, 131)
        Me.btnAgregarMarca.Name = "btnAgregarMarca"
        Me.btnAgregarMarca.Size = New System.Drawing.Size(21, 21)
        Me.btnAgregarMarca.TabIndex = 106
        Me.btnAgregarMarca.TabStop = False
        '
        'btnAgregarRubro
        '
        Me.btnAgregarRubro.BackgroundImage = CType(resources.GetObject("btnAgregarRubro.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarRubro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarRubro.Location = New System.Drawing.Point(312, 157)
        Me.btnAgregarRubro.Name = "btnAgregarRubro"
        Me.btnAgregarRubro.Size = New System.Drawing.Size(21, 21)
        Me.btnAgregarRubro.TabIndex = 107
        Me.btnAgregarRubro.TabStop = False
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(955, 620)
        Me.Controls.Add(Me.btnAgregarRubro)
        Me.Controls.Add(Me.btnAgregarMarca)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUtilidad)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.chkAlternativo)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.grdProductos)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtNumeroFila)
        Me.Controls.Add(Me.txtCodigoBarra)
        Me.Controls.Add(Me.txtFabricante)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtLista)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMarca)
        Me.Controls.Add(Me.cboOriginal)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCompra)
        Me.Controls.Add(Me.txtNombreDiario)
        Me.Controls.Add(Me.txtFechaUltCompra)
        Me.Controls.Add(Me.txtCantidadBulto)
        Me.Controls.Add(Me.txtStockReal)
        Me.Controls.Add(Me.txtFechaUltVenta)
        Me.Controls.Add(Me.txtStockDisponible)
        Me.Controls.Add(Me.txtEstanteria)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.cboRubro)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.grdProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarRubro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdProductos As DataGridView
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtNumeroFila As TextBox
    Friend WithEvents txtCodigoBarra As TextBox
    Friend WithEvents txtFabricante As TextBox
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtLista As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents cboOriginal As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents txtNombreDiario As TextBox
    Friend WithEvents txtFechaUltCompra As TextBox
    Friend WithEvents txtCantidadBulto As TextBox
    Friend WithEvents txtStockReal As TextBox
    Friend WithEvents txtFechaUltVenta As TextBox
    Friend WithEvents txtStockDisponible As TextBox
    Friend WithEvents txtEstanteria As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents cboRubro As ComboBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents chkAlternativo As CheckBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUtilidad As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregarMarca As PictureBox
    Friend WithEvents btnAgregarRubro As PictureBox
End Class
