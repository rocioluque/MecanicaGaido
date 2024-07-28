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
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.lblCodEstanteria = New System.Windows.Forms.Label()
        Me.txtNumeroFila = New System.Windows.Forms.TextBox()
        Me.txtCodigoBarra = New System.Windows.Forms.TextBox()
        Me.txtFabricante = New System.Windows.Forms.TextBox()
        Me.lblCodBarra = New System.Windows.Forms.Label()
        Me.lblCodFabricante = New System.Windows.Forms.Label()
        Me.lblNFila = New System.Windows.Forms.Label()
        Me.lblStockDisponible = New System.Windows.Forms.Label()
        Me.lblStockReal = New System.Windows.Forms.Label()
        Me.lblCantBulto = New System.Windows.Forms.Label()
        Me.lblRubro = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.cboOriginal = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombreDiario = New System.Windows.Forms.TextBox()
        Me.txtCantidadBulto = New System.Windows.Forms.TextBox()
        Me.txtStockReal = New System.Windows.Forms.TextBox()
        Me.txtStockDisponible = New System.Windows.Forms.TextBox()
        Me.txtEstanteria = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNombreDiario = New System.Windows.Forms.Label()
        Me.lblNombreOriginal = New System.Windows.Forms.Label()
        Me.lblNProducto = New System.Windows.Forms.Label()
        Me.cboRubro = New System.Windows.Forms.ComboBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.chkAlternativo = New System.Windows.Forms.CheckBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregarMarca = New System.Windows.Forms.PictureBox()
        Me.btnAgregarRubro = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDatosEspecificos = New System.Windows.Forms.Label()
        Me.PanelDatosEspecificos = New System.Windows.Forms.Panel()
        Me.cboOrigen = New System.Windows.Forms.ComboBox()
        Me.lblExistencia = New System.Windows.Forms.Label()
        Me.PanelExistencia = New System.Windows.Forms.Panel()
        Me.lblMovimientos = New System.Windows.Forms.Label()
        Me.PanelMovimientos = New System.Windows.Forms.Panel()
        Me.lblUtilidad = New System.Windows.Forms.Label()
        Me.txtUtilidad = New System.Windows.Forms.TextBox()
        Me.lblFechaUltVenta = New System.Windows.Forms.Label()
        Me.lblFechaUltimaCompra = New System.Windows.Forms.Label()
        Me.lblPrecioCompra = New System.Windows.Forms.Label()
        Me.txtLista = New System.Windows.Forms.TextBox()
        Me.lblPrecioLista = New System.Windows.Forms.Label()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.txtFechaUltCompra = New System.Windows.Forms.TextBox()
        Me.txtFechaUltVenta = New System.Windows.Forms.TextBox()
        CType(Me.grdProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarRubro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatosEspecificos.SuspendLayout()
        Me.PanelExistencia.SuspendLayout()
        Me.PanelMovimientos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdProductos
        '
        Me.grdProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProductos.Location = New System.Drawing.Point(42, 408)
        Me.grdProductos.Name = "grdProductos"
        Me.grdProductos.ReadOnly = True
        Me.grdProductos.RowHeadersWidth = 51
        Me.grdProductos.Size = New System.Drawing.Size(858, 290)
        Me.grdProductos.TabIndex = 93
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.White
        Me.chkActivo.Location = New System.Drawing.Point(618, 21)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(85, 21)
        Me.chkActivo.TabIndex = 22
        Me.chkActivo.Text = "¿Activo?"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblOrigen
        '
        Me.lblOrigen.AutoSize = True
        Me.lblOrigen.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigen.ForeColor = System.Drawing.Color.White
        Me.lblOrigen.Location = New System.Drawing.Point(328, 126)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(51, 17)
        Me.lblOrigen.TabIndex = 90
        Me.lblOrigen.Text = "Origen"
        '
        'lblCodEstanteria
        '
        Me.lblCodEstanteria.AutoSize = True
        Me.lblCodEstanteria.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodEstanteria.ForeColor = System.Drawing.Color.White
        Me.lblCodEstanteria.Location = New System.Drawing.Point(15, 82)
        Me.lblCodEstanteria.Name = "lblCodEstanteria"
        Me.lblCodEstanteria.Size = New System.Drawing.Size(108, 17)
        Me.lblCodEstanteria.TabIndex = 89
        Me.lblCodEstanteria.Text = "Cod. Estanteria"
        '
        'txtNumeroFila
        '
        Me.txtNumeroFila.Location = New System.Drawing.Point(152, 109)
        Me.txtNumeroFila.Name = "txtNumeroFila"
        Me.txtNumeroFila.Size = New System.Drawing.Size(121, 20)
        Me.txtNumeroFila.TabIndex = 18
        '
        'txtCodigoBarra
        '
        Me.txtCodigoBarra.Location = New System.Drawing.Point(619, 65)
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.Size = New System.Drawing.Size(224, 20)
        Me.txtCodigoBarra.TabIndex = 19
        '
        'txtFabricante
        '
        Me.txtFabricante.Location = New System.Drawing.Point(620, 105)
        Me.txtFabricante.Name = "txtFabricante"
        Me.txtFabricante.Size = New System.Drawing.Size(224, 20)
        Me.txtFabricante.TabIndex = 20
        '
        'lblCodBarra
        '
        Me.lblCodBarra.AutoSize = True
        Me.lblCodBarra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodBarra.ForeColor = System.Drawing.Color.White
        Me.lblCodBarra.Location = New System.Drawing.Point(617, 48)
        Me.lblCodBarra.Name = "lblCodBarra"
        Me.lblCodBarra.Size = New System.Drawing.Size(99, 17)
        Me.lblCodBarra.TabIndex = 82
        Me.lblCodBarra.Text = "Cod. de Barra"
        '
        'lblCodFabricante
        '
        Me.lblCodFabricante.AutoSize = True
        Me.lblCodFabricante.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodFabricante.ForeColor = System.Drawing.Color.White
        Me.lblCodFabricante.Location = New System.Drawing.Point(618, 87)
        Me.lblCodFabricante.Name = "lblCodFabricante"
        Me.lblCodFabricante.Size = New System.Drawing.Size(114, 17)
        Me.lblCodFabricante.TabIndex = 81
        Me.lblCodFabricante.Text = "Cod. Fabricante"
        '
        'lblNFila
        '
        Me.lblNFila.AutoSize = True
        Me.lblNFila.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNFila.ForeColor = System.Drawing.Color.White
        Me.lblNFila.Location = New System.Drawing.Point(16, 110)
        Me.lblNFila.Name = "lblNFila"
        Me.lblNFila.Size = New System.Drawing.Size(69, 17)
        Me.lblNFila.TabIndex = 80
        Me.lblNFila.Text = "N° de Fila"
        '
        'lblStockDisponible
        '
        Me.lblStockDisponible.AutoSize = True
        Me.lblStockDisponible.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockDisponible.ForeColor = System.Drawing.Color.White
        Me.lblStockDisponible.Location = New System.Drawing.Point(16, 54)
        Me.lblStockDisponible.Name = "lblStockDisponible"
        Me.lblStockDisponible.Size = New System.Drawing.Size(114, 17)
        Me.lblStockDisponible.TabIndex = 75
        Me.lblStockDisponible.Text = "Stock Disponible"
        '
        'lblStockReal
        '
        Me.lblStockReal.AutoSize = True
        Me.lblStockReal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockReal.ForeColor = System.Drawing.Color.White
        Me.lblStockReal.Location = New System.Drawing.Point(17, 26)
        Me.lblStockReal.Name = "lblStockReal"
        Me.lblStockReal.Size = New System.Drawing.Size(75, 17)
        Me.lblStockReal.TabIndex = 73
        Me.lblStockReal.Text = "Stock Real"
        '
        'lblCantBulto
        '
        Me.lblCantBulto.AutoSize = True
        Me.lblCantBulto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantBulto.ForeColor = System.Drawing.Color.White
        Me.lblCantBulto.Location = New System.Drawing.Point(618, 126)
        Me.lblCantBulto.Name = "lblCantBulto"
        Me.lblCantBulto.Size = New System.Drawing.Size(106, 17)
        Me.lblCantBulto.TabIndex = 72
        Me.lblCantBulto.Text = "Cant. Por Bulto"
        '
        'lblRubro
        '
        Me.lblRubro.AutoSize = True
        Me.lblRubro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRubro.ForeColor = System.Drawing.Color.White
        Me.lblRubro.Location = New System.Drawing.Point(327, 48)
        Me.lblRubro.Name = "lblRubro"
        Me.lblRubro.Size = New System.Drawing.Size(46, 17)
        Me.lblRubro.TabIndex = 70
        Me.lblRubro.Text = "Rubro"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.White
        Me.lblMarca.Location = New System.Drawing.Point(12, 126)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(49, 17)
        Me.lblMarca.TabIndex = 69
        Me.lblMarca.Text = "Marca"
        '
        'cboMarca
        '
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(15, 144)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(198, 21)
        Me.cboMarca.TabIndex = 5
        '
        'cboOriginal
        '
        Me.cboOriginal.FormattingEnabled = True
        Me.cboOriginal.Location = New System.Drawing.Point(330, 105)
        Me.cboOriginal.Name = "cboOriginal"
        Me.cboOriginal.Size = New System.Drawing.Size(198, 21)
        Me.cboOriginal.TabIndex = 8
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(15, 66)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(224, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtNombreDiario
        '
        Me.txtNombreDiario.Location = New System.Drawing.Point(15, 105)
        Me.txtNombreDiario.Name = "txtNombreDiario"
        Me.txtNombreDiario.Size = New System.Drawing.Size(224, 20)
        Me.txtNombreDiario.TabIndex = 4
        '
        'txtCantidadBulto
        '
        Me.txtCantidadBulto.Location = New System.Drawing.Point(620, 147)
        Me.txtCantidadBulto.Name = "txtCantidadBulto"
        Me.txtCantidadBulto.Size = New System.Drawing.Size(223, 20)
        Me.txtCantidadBulto.TabIndex = 9
        '
        'txtStockReal
        '
        Me.txtStockReal.Location = New System.Drawing.Point(152, 25)
        Me.txtStockReal.Name = "txtStockReal"
        Me.txtStockReal.Size = New System.Drawing.Size(121, 20)
        Me.txtStockReal.TabIndex = 10
        '
        'txtStockDisponible
        '
        Me.txtStockDisponible.Location = New System.Drawing.Point(152, 53)
        Me.txtStockDisponible.Name = "txtStockDisponible"
        Me.txtStockDisponible.Size = New System.Drawing.Size(121, 20)
        Me.txtStockDisponible.TabIndex = 11
        '
        'txtEstanteria
        '
        Me.txtEstanteria.Location = New System.Drawing.Point(152, 81)
        Me.txtEstanteria.Name = "txtEstanteria"
        Me.txtEstanteria.Size = New System.Drawing.Size(121, 20)
        Me.txtEstanteria.TabIndex = 17
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.White
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 48)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(83, 17)
        Me.lblDescripcion.TabIndex = 56
        Me.lblDescripcion.Text = "Descripcion"
        '
        'lblNombreDiario
        '
        Me.lblNombreDiario.AutoSize = True
        Me.lblNombreDiario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDiario.ForeColor = System.Drawing.Color.White
        Me.lblNombreDiario.Location = New System.Drawing.Point(12, 87)
        Me.lblNombreDiario.Name = "lblNombreDiario"
        Me.lblNombreDiario.Size = New System.Drawing.Size(103, 17)
        Me.lblNombreDiario.TabIndex = 55
        Me.lblNombreDiario.Text = "Nombre Diario"
        '
        'lblNombreOriginal
        '
        Me.lblNombreOriginal.AutoSize = True
        Me.lblNombreOriginal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreOriginal.ForeColor = System.Drawing.Color.White
        Me.lblNombreOriginal.Location = New System.Drawing.Point(327, 87)
        Me.lblNombreOriginal.Name = "lblNombreOriginal"
        Me.lblNombreOriginal.Size = New System.Drawing.Size(136, 17)
        Me.lblNombreOriginal.TabIndex = 54
        Me.lblNombreOriginal.Text = "Nombre de Original"
        '
        'lblNProducto
        '
        Me.lblNProducto.AutoSize = True
        Me.lblNProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNProducto.ForeColor = System.Drawing.Color.White
        Me.lblNProducto.Location = New System.Drawing.Point(12, 22)
        Me.lblNProducto.Name = "lblNProducto"
        Me.lblNProducto.Size = New System.Drawing.Size(87, 17)
        Me.lblNProducto.TabIndex = 53
        Me.lblNProducto.Text = "N° Producto"
        '
        'cboRubro
        '
        Me.cboRubro.FormattingEnabled = True
        Me.cboRubro.Location = New System.Drawing.Point(330, 65)
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Size = New System.Drawing.Size(198, 21)
        Me.cboRubro.TabIndex = 6
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(115, 21)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(50, 20)
        Me.txtId.TabIndex = 1
        '
        'chkAlternativo
        '
        Me.chkAlternativo.AutoSize = True
        Me.chkAlternativo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlternativo.ForeColor = System.Drawing.Color.White
        Me.chkAlternativo.Location = New System.Drawing.Point(330, 21)
        Me.chkAlternativo.Name = "chkAlternativo"
        Me.chkAlternativo.Size = New System.Drawing.Size(114, 21)
        Me.chkAlternativo.TabIndex = 7
        Me.chkAlternativo.Text = "¿Alternativo?"
        Me.chkAlternativo.UseVisualStyleBackColor = True
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
        Me.btnBuscar.Location = New System.Drawing.Point(189, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 28)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.UseVisualStyleBackColor = False
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
        Me.btnAceptar.Location = New System.Drawing.Point(818, 234)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(82, 28)
        Me.btnAceptar.TabIndex = 23
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(818, 356)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(82, 28)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnModificar.Location = New System.Drawing.Point(818, 295)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(82, 28)
        Me.btnModificar.TabIndex = 24
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregarMarca
        '
        Me.btnAgregarMarca.BackgroundImage = CType(resources.GetObject("btnAgregarMarca.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarMarca.Location = New System.Drawing.Point(218, 144)
        Me.btnAgregarMarca.Name = "btnAgregarMarca"
        Me.btnAgregarMarca.Size = New System.Drawing.Size(21, 21)
        Me.btnAgregarMarca.TabIndex = 106
        Me.btnAgregarMarca.TabStop = False
        '
        'btnAgregarRubro
        '
        Me.btnAgregarRubro.BackgroundImage = CType(resources.GetObject("btnAgregarRubro.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarRubro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarRubro.Location = New System.Drawing.Point(534, 66)
        Me.btnAgregarRubro.Name = "btnAgregarRubro"
        Me.btnAgregarRubro.Size = New System.Drawing.Size(21, 21)
        Me.btnAgregarRubro.TabIndex = 107
        Me.btnAgregarRubro.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(534, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox1.TabIndex = 108
        Me.PictureBox1.TabStop = False
        '
        'lblDatosEspecificos
        '
        Me.lblDatosEspecificos.AutoSize = True
        Me.lblDatosEspecificos.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblDatosEspecificos.ForeColor = System.Drawing.Color.White
        Me.lblDatosEspecificos.Location = New System.Drawing.Point(54, 12)
        Me.lblDatosEspecificos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDatosEspecificos.Name = "lblDatosEspecificos"
        Me.lblDatosEspecificos.Size = New System.Drawing.Size(112, 17)
        Me.lblDatosEspecificos.TabIndex = 110
        Me.lblDatosEspecificos.Text = "Datos Específicos"
        '
        'PanelDatosEspecificos
        '
        Me.PanelDatosEspecificos.Controls.Add(Me.cboOrigen)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblDescripcion)
        Me.PanelDatosEspecificos.Controls.Add(Me.txtDescripcion)
        Me.PanelDatosEspecificos.Controls.Add(Me.PictureBox1)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblNombreDiario)
        Me.PanelDatosEspecificos.Controls.Add(Me.btnAgregarRubro)
        Me.PanelDatosEspecificos.Controls.Add(Me.txtNombreDiario)
        Me.PanelDatosEspecificos.Controls.Add(Me.btnAgregarMarca)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblMarca)
        Me.PanelDatosEspecificos.Controls.Add(Me.btnBuscar)
        Me.PanelDatosEspecificos.Controls.Add(Me.chkActivo)
        Me.PanelDatosEspecificos.Controls.Add(Me.txtId)
        Me.PanelDatosEspecificos.Controls.Add(Me.cboMarca)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblRubro)
        Me.PanelDatosEspecificos.Controls.Add(Me.chkAlternativo)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblNProducto)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblOrigen)
        Me.PanelDatosEspecificos.Controls.Add(Me.cboRubro)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblNombreOriginal)
        Me.PanelDatosEspecificos.Controls.Add(Me.cboOriginal)
        Me.PanelDatosEspecificos.Controls.Add(Me.txtFabricante)
        Me.PanelDatosEspecificos.Controls.Add(Me.txtCodigoBarra)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblCodBarra)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblCodFabricante)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblCantBulto)
        Me.PanelDatosEspecificos.Controls.Add(Me.txtCantidadBulto)
        Me.PanelDatosEspecificos.Location = New System.Drawing.Point(42, 21)
        Me.PanelDatosEspecificos.Name = "PanelDatosEspecificos"
        Me.PanelDatosEspecificos.Size = New System.Drawing.Size(858, 188)
        Me.PanelDatosEspecificos.TabIndex = 109
        '
        'cboOrigen
        '
        Me.cboOrigen.DisplayMember = "Nacional"
        Me.cboOrigen.FormattingEnabled = True
        Me.cboOrigen.Items.AddRange(New Object() {"Nacional", "Importado"})
        Me.cboOrigen.Location = New System.Drawing.Point(330, 144)
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(224, 21)
        Me.cboOrigen.TabIndex = 109
        '
        'lblExistencia
        '
        Me.lblExistencia.AutoSize = True
        Me.lblExistencia.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblExistencia.ForeColor = System.Drawing.Color.White
        Me.lblExistencia.Location = New System.Drawing.Point(57, 218)
        Me.lblExistencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Size = New System.Drawing.Size(67, 17)
        Me.lblExistencia.TabIndex = 112
        Me.lblExistencia.Text = "Existencia"
        '
        'PanelExistencia
        '
        Me.PanelExistencia.Controls.Add(Me.txtStockDisponible)
        Me.PanelExistencia.Controls.Add(Me.txtStockReal)
        Me.PanelExistencia.Controls.Add(Me.lblStockReal)
        Me.PanelExistencia.Controls.Add(Me.lblStockDisponible)
        Me.PanelExistencia.Controls.Add(Me.txtNumeroFila)
        Me.PanelExistencia.Controls.Add(Me.txtEstanteria)
        Me.PanelExistencia.Controls.Add(Me.lblNFila)
        Me.PanelExistencia.Controls.Add(Me.lblCodEstanteria)
        Me.PanelExistencia.Location = New System.Drawing.Point(42, 227)
        Me.PanelExistencia.Name = "PanelExistencia"
        Me.PanelExistencia.Size = New System.Drawing.Size(316, 157)
        Me.PanelExistencia.TabIndex = 111
        '
        'lblMovimientos
        '
        Me.lblMovimientos.AutoSize = True
        Me.lblMovimientos.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblMovimientos.ForeColor = System.Drawing.Color.White
        Me.lblMovimientos.Location = New System.Drawing.Point(444, 218)
        Me.lblMovimientos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMovimientos.Name = "lblMovimientos"
        Me.lblMovimientos.Size = New System.Drawing.Size(85, 17)
        Me.lblMovimientos.TabIndex = 114
        Me.lblMovimientos.Text = "Movimientos"
        '
        'PanelMovimientos
        '
        Me.PanelMovimientos.Controls.Add(Me.lblUtilidad)
        Me.PanelMovimientos.Controls.Add(Me.txtUtilidad)
        Me.PanelMovimientos.Controls.Add(Me.lblFechaUltVenta)
        Me.PanelMovimientos.Controls.Add(Me.lblFechaUltimaCompra)
        Me.PanelMovimientos.Controls.Add(Me.lblPrecioCompra)
        Me.PanelMovimientos.Controls.Add(Me.txtLista)
        Me.PanelMovimientos.Controls.Add(Me.lblPrecioLista)
        Me.PanelMovimientos.Controls.Add(Me.txtCompra)
        Me.PanelMovimientos.Controls.Add(Me.txtFechaUltCompra)
        Me.PanelMovimientos.Controls.Add(Me.txtFechaUltVenta)
        Me.PanelMovimientos.Location = New System.Drawing.Point(429, 227)
        Me.PanelMovimientos.Name = "PanelMovimientos"
        Me.PanelMovimientos.Size = New System.Drawing.Size(316, 157)
        Me.PanelMovimientos.TabIndex = 113
        '
        'lblUtilidad
        '
        Me.lblUtilidad.AutoSize = True
        Me.lblUtilidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUtilidad.ForeColor = System.Drawing.Color.White
        Me.lblUtilidad.Location = New System.Drawing.Point(30, 71)
        Me.lblUtilidad.Name = "lblUtilidad"
        Me.lblUtilidad.Size = New System.Drawing.Size(57, 17)
        Me.lblUtilidad.TabIndex = 111
        Me.lblUtilidad.Text = "Utilidad"
        '
        'txtUtilidad
        '
        Me.txtUtilidad.Location = New System.Drawing.Point(166, 68)
        Me.txtUtilidad.Name = "txtUtilidad"
        Me.txtUtilidad.Size = New System.Drawing.Size(121, 20)
        Me.txtUtilidad.TabIndex = 104
        '
        'lblFechaUltVenta
        '
        Me.lblFechaUltVenta.AutoSize = True
        Me.lblFechaUltVenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaUltVenta.ForeColor = System.Drawing.Color.White
        Me.lblFechaUltVenta.Location = New System.Drawing.Point(29, 124)
        Me.lblFechaUltVenta.Name = "lblFechaUltVenta"
        Me.lblFechaUltVenta.Size = New System.Drawing.Size(118, 17)
        Me.lblFechaUltVenta.TabIndex = 110
        Me.lblFechaUltVenta.Text = "Fecha. Ult. Venta"
        '
        'lblFechaUltimaCompra
        '
        Me.lblFechaUltimaCompra.AutoSize = True
        Me.lblFechaUltimaCompra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaUltimaCompra.ForeColor = System.Drawing.Color.White
        Me.lblFechaUltimaCompra.Location = New System.Drawing.Point(30, 97)
        Me.lblFechaUltimaCompra.Name = "lblFechaUltimaCompra"
        Me.lblFechaUltimaCompra.Size = New System.Drawing.Size(134, 17)
        Me.lblFechaUltimaCompra.TabIndex = 109
        Me.lblFechaUltimaCompra.Text = "Fecha. Ult. Compra"
        '
        'lblPrecioCompra
        '
        Me.lblPrecioCompra.AutoSize = True
        Me.lblPrecioCompra.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioCompra.ForeColor = System.Drawing.Color.White
        Me.lblPrecioCompra.Location = New System.Drawing.Point(29, 18)
        Me.lblPrecioCompra.Name = "lblPrecioCompra"
        Me.lblPrecioCompra.Size = New System.Drawing.Size(107, 17)
        Me.lblPrecioCompra.TabIndex = 108
        Me.lblPrecioCompra.Text = "Precio Compra"
        '
        'txtLista
        '
        Me.txtLista.Location = New System.Drawing.Point(166, 42)
        Me.txtLista.Name = "txtLista"
        Me.txtLista.Size = New System.Drawing.Size(121, 20)
        Me.txtLista.TabIndex = 103
        '
        'lblPrecioLista
        '
        Me.lblPrecioLista.AutoSize = True
        Me.lblPrecioLista.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioLista.ForeColor = System.Drawing.Color.White
        Me.lblPrecioLista.Location = New System.Drawing.Point(29, 45)
        Me.lblPrecioLista.Name = "lblPrecioLista"
        Me.lblPrecioLista.Size = New System.Drawing.Size(80, 17)
        Me.lblPrecioLista.TabIndex = 107
        Me.lblPrecioLista.Text = "Precio Lista"
        '
        'txtCompra
        '
        Me.txtCompra.Location = New System.Drawing.Point(166, 15)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(121, 20)
        Me.txtCompra.TabIndex = 102
        '
        'txtFechaUltCompra
        '
        Me.txtFechaUltCompra.Enabled = False
        Me.txtFechaUltCompra.Location = New System.Drawing.Point(166, 94)
        Me.txtFechaUltCompra.Name = "txtFechaUltCompra"
        Me.txtFechaUltCompra.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaUltCompra.TabIndex = 105
        '
        'txtFechaUltVenta
        '
        Me.txtFechaUltVenta.Enabled = False
        Me.txtFechaUltVenta.Location = New System.Drawing.Point(166, 121)
        Me.txtFechaUltVenta.Name = "txtFechaUltVenta"
        Me.txtFechaUltVenta.Size = New System.Drawing.Size(121, 20)
        Me.txtFechaUltVenta.TabIndex = 106
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(972, 659)
        Me.Controls.Add(Me.lblMovimientos)
        Me.Controls.Add(Me.PanelMovimientos)
        Me.Controls.Add(Me.lblExistencia)
        Me.Controls.Add(Me.PanelExistencia)
        Me.Controls.Add(Me.lblDatosEspecificos)
        Me.Controls.Add(Me.PanelDatosEspecificos)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.grdProductos)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.grdProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarRubro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatosEspecificos.ResumeLayout(False)
        Me.PanelDatosEspecificos.PerformLayout()
        Me.PanelExistencia.ResumeLayout(False)
        Me.PanelExistencia.PerformLayout()
        Me.PanelMovimientos.ResumeLayout(False)
        Me.PanelMovimientos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdProductos As DataGridView
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents lblOrigen As Label
    Friend WithEvents lblCodEstanteria As Label
    Friend WithEvents txtNumeroFila As TextBox
    Friend WithEvents txtCodigoBarra As TextBox
    Friend WithEvents txtFabricante As TextBox
    Friend WithEvents lblCodBarra As Label
    Friend WithEvents lblCodFabricante As Label
    Friend WithEvents lblNFila As Label
    Friend WithEvents lblStockDisponible As Label
    Friend WithEvents lblStockReal As Label
    Friend WithEvents lblCantBulto As Label
    Friend WithEvents lblRubro As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents cboMarca As ComboBox
    Friend WithEvents cboOriginal As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombreDiario As TextBox
    Friend WithEvents txtCantidadBulto As TextBox
    Friend WithEvents txtStockReal As TextBox
    Friend WithEvents txtStockDisponible As TextBox
    Friend WithEvents txtEstanteria As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblNombreDiario As Label
    Friend WithEvents lblNombreOriginal As Label
    Friend WithEvents lblNProducto As Label
    Friend WithEvents cboRubro As ComboBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents chkAlternativo As CheckBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregarMarca As PictureBox
    Friend WithEvents btnAgregarRubro As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblDatosEspecificos As Label
    Friend WithEvents PanelDatosEspecificos As Panel
    Friend WithEvents cboOrigen As ComboBox
    Friend WithEvents lblExistencia As Label
    Friend WithEvents PanelExistencia As Panel
    Friend WithEvents lblMovimientos As Label
    Friend WithEvents PanelMovimientos As Panel
    Friend WithEvents lblUtilidad As Label
    Friend WithEvents txtUtilidad As TextBox
    Friend WithEvents lblFechaUltVenta As Label
    Friend WithEvents lblFechaUltimaCompra As Label
    Friend WithEvents lblPrecioCompra As Label
    Friend WithEvents txtLista As TextBox
    Friend WithEvents lblPrecioLista As Label
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents txtFechaUltCompra As TextBox
    Friend WithEvents txtFechaUltVenta As TextBox
End Class
