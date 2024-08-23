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
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.lblOrigen = New System.Windows.Forms.Label()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.txtCodigoBarra = New System.Windows.Forms.TextBox()
        Me.txtCodFabricante = New System.Windows.Forms.TextBox()
        Me.lblCodBarra = New System.Windows.Forms.Label()
        Me.lblCodFabricante = New System.Windows.Forms.Label()
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
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNombreDiario = New System.Windows.Forms.Label()
        Me.lblNombreOriginal = New System.Windows.Forms.Label()
        Me.lblNProducto = New System.Windows.Forms.Label()
        Me.cboRubro = New System.Windows.Forms.ComboBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.chkAlterntivo = New System.Windows.Forms.CheckBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregarMarca = New System.Windows.Forms.PictureBox()
        Me.btnAgregarRubro = New System.Windows.Forms.PictureBox()
        Me.lblDatosEspecificos = New System.Windows.Forms.Label()
        Me.PanelDatosEspecificos = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboOrigen = New System.Windows.Forms.ComboBox()
        Me.lblExistencia = New System.Windows.Forms.Label()
        Me.PanelExistencia = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMovimientos = New System.Windows.Forms.Label()
        Me.PanelMovimientos = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaCompra = New System.Windows.Forms.DateTimePicker()
        Me.lblPrecioLista = New System.Windows.Forms.Label()
        Me.txtPrecioLista = New System.Windows.Forms.TextBox()
        Me.lblFechaUltVenta = New System.Windows.Forms.Label()
        Me.lblFechaUltimaCompra = New System.Windows.Forms.Label()
        Me.lblPrecioCompra = New System.Windows.Forms.Label()
        Me.txtUtilidad = New System.Windows.Forms.TextBox()
        Me.lblUtilidad = New System.Windows.Forms.Label()
        Me.txtPrecioCompra = New System.Windows.Forms.TextBox()
        CType(Me.grdProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarRubro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatosEspecificos.SuspendLayout()
        Me.PanelExistencia.SuspendLayout()
        Me.PanelMovimientos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdProductos
        '
        Me.grdProductos.AllowUserToAddRows = False
        Me.grdProductos.AllowUserToDeleteRows = False
        Me.grdProductos.AllowUserToOrderColumns = True
        Me.grdProductos.AllowUserToResizeRows = False
        Me.grdProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.grdProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProductos.Location = New System.Drawing.Point(56, 529)
        Me.grdProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.grdProductos.Name = "grdProductos"
        Me.grdProductos.ReadOnly = True
        Me.grdProductos.RowHeadersVisible = False
        Me.grdProductos.RowHeadersWidth = 51
        Me.grdProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdProductos.Size = New System.Drawing.Size(1144, 351)
        Me.grdProductos.TabIndex = 25
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Checked = True
        Me.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(801, 199)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(98, 24)
        Me.chkEstado.TabIndex = 13
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'lblOrigen
        '
        Me.lblOrigen.AutoSize = True
        Me.lblOrigen.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblOrigen.ForeColor = System.Drawing.Color.White
        Me.lblOrigen.Location = New System.Drawing.Point(797, 14)
        Me.lblOrigen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrigen.Name = "lblOrigen"
        Me.lblOrigen.Size = New System.Drawing.Size(59, 20)
        Me.lblOrigen.TabIndex = 90
        Me.lblOrigen.Text = "Origen"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblUbicacion.ForeColor = System.Drawing.Color.White
        Me.lblUbicacion.Location = New System.Drawing.Point(21, 142)
        Me.lblUbicacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(85, 20)
        Me.lblUbicacion.TabIndex = 89
        Me.lblUbicacion.Text = "Ubicación"
        '
        'txtCodigoBarra
        '
        Me.txtCodigoBarra.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCodigoBarra.Location = New System.Drawing.Point(409, 91)
        Me.txtCodigoBarra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.Size = New System.Drawing.Size(297, 27)
        Me.txtCodigoBarra.TabIndex = 7
        '
        'txtCodFabricante
        '
        Me.txtCodFabricante.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCodFabricante.Location = New System.Drawing.Point(409, 145)
        Me.txtCodFabricante.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodFabricante.Name = "txtCodFabricante"
        Me.txtCodFabricante.Size = New System.Drawing.Size(297, 27)
        Me.txtCodFabricante.TabIndex = 8
        '
        'lblCodBarra
        '
        Me.lblCodBarra.AutoSize = True
        Me.lblCodBarra.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblCodBarra.ForeColor = System.Drawing.Color.White
        Me.lblCodBarra.Location = New System.Drawing.Point(405, 68)
        Me.lblCodBarra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodBarra.Name = "lblCodBarra"
        Me.lblCodBarra.Size = New System.Drawing.Size(112, 20)
        Me.lblCodBarra.TabIndex = 82
        Me.lblCodBarra.Text = "Cod. de Barra"
        '
        'lblCodFabricante
        '
        Me.lblCodFabricante.AutoSize = True
        Me.lblCodFabricante.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblCodFabricante.ForeColor = System.Drawing.Color.White
        Me.lblCodFabricante.Location = New System.Drawing.Point(405, 122)
        Me.lblCodFabricante.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodFabricante.Name = "lblCodFabricante"
        Me.lblCodFabricante.Size = New System.Drawing.Size(128, 20)
        Me.lblCodFabricante.TabIndex = 81
        Me.lblCodFabricante.Text = "Cod. Fabricante"
        '
        'lblStockDisponible
        '
        Me.lblStockDisponible.AutoSize = True
        Me.lblStockDisponible.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblStockDisponible.ForeColor = System.Drawing.Color.White
        Me.lblStockDisponible.Location = New System.Drawing.Point(21, 87)
        Me.lblStockDisponible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStockDisponible.Name = "lblStockDisponible"
        Me.lblStockDisponible.Size = New System.Drawing.Size(128, 20)
        Me.lblStockDisponible.TabIndex = 75
        Me.lblStockDisponible.Text = "Stock Disponible"
        '
        'lblStockReal
        '
        Me.lblStockReal.AutoSize = True
        Me.lblStockReal.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblStockReal.ForeColor = System.Drawing.Color.White
        Me.lblStockReal.Location = New System.Drawing.Point(21, 33)
        Me.lblStockReal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStockReal.Name = "lblStockReal"
        Me.lblStockReal.Size = New System.Drawing.Size(85, 20)
        Me.lblStockReal.TabIndex = 73
        Me.lblStockReal.Text = "Stock Real"
        '
        'lblCantBulto
        '
        Me.lblCantBulto.AutoSize = True
        Me.lblCantBulto.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblCantBulto.ForeColor = System.Drawing.Color.White
        Me.lblCantBulto.Location = New System.Drawing.Point(405, 176)
        Me.lblCantBulto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantBulto.Name = "lblCantBulto"
        Me.lblCantBulto.Size = New System.Drawing.Size(117, 20)
        Me.lblCantBulto.TabIndex = 72
        Me.lblCantBulto.Text = "Cant. Por Bulto"
        '
        'lblRubro
        '
        Me.lblRubro.AutoSize = True
        Me.lblRubro.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblRubro.ForeColor = System.Drawing.Color.White
        Me.lblRubro.Location = New System.Drawing.Point(16, 176)
        Me.lblRubro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRubro.Name = "lblRubro"
        Me.lblRubro.Size = New System.Drawing.Size(52, 20)
        Me.lblRubro.TabIndex = 70
        Me.lblRubro.Text = "Rubro"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblMarca.ForeColor = System.Drawing.Color.White
        Me.lblMarca.Location = New System.Drawing.Point(405, 14)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(59, 20)
        Me.lblMarca.TabIndex = 69
        Me.lblMarca.Text = "Marca"
        '
        'cboMarca
        '
        Me.cboMarca.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(409, 37)
        Me.cboMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(247, 28)
        Me.cboMarca.TabIndex = 6
        '
        'cboOriginal
        '
        Me.cboOriginal.Enabled = False
        Me.cboOriginal.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cboOriginal.FormattingEnabled = True
        Me.cboOriginal.Location = New System.Drawing.Point(801, 145)
        Me.cboOriginal.Margin = New System.Windows.Forms.Padding(4)
        Me.cboOriginal.Name = "cboOriginal"
        Me.cboOriginal.Size = New System.Drawing.Size(296, 28)
        Me.cboOriginal.TabIndex = 12
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDescripcion.Location = New System.Drawing.Point(20, 92)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(297, 27)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtNombreDiario
        '
        Me.txtNombreDiario.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNombreDiario.Location = New System.Drawing.Point(20, 145)
        Me.txtNombreDiario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreDiario.Name = "txtNombreDiario"
        Me.txtNombreDiario.Size = New System.Drawing.Size(297, 27)
        Me.txtNombreDiario.TabIndex = 4
        '
        'txtCantidadBulto
        '
        Me.txtCantidadBulto.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCantidadBulto.Location = New System.Drawing.Point(409, 199)
        Me.txtCantidadBulto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadBulto.Name = "txtCantidadBulto"
        Me.txtCantidadBulto.Size = New System.Drawing.Size(108, 27)
        Me.txtCantidadBulto.TabIndex = 9
        Me.txtCantidadBulto.Text = "1"
        Me.txtCantidadBulto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStockReal
        '
        Me.txtStockReal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtStockReal.Location = New System.Drawing.Point(203, 30)
        Me.txtStockReal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStockReal.Name = "txtStockReal"
        Me.txtStockReal.Size = New System.Drawing.Size(160, 27)
        Me.txtStockReal.TabIndex = 14
        Me.txtStockReal.Text = "0"
        Me.txtStockReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStockDisponible
        '
        Me.txtStockDisponible.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtStockDisponible.Location = New System.Drawing.Point(203, 84)
        Me.txtStockDisponible.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStockDisponible.Name = "txtStockDisponible"
        Me.txtStockDisponible.Size = New System.Drawing.Size(160, 27)
        Me.txtStockDisponible.TabIndex = 15
        Me.txtStockDisponible.Text = "0"
        Me.txtStockDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUbicacion.Location = New System.Drawing.Point(203, 138)
        Me.txtUbicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(160, 27)
        Me.txtUbicacion.TabIndex = 16
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblDescripcion.ForeColor = System.Drawing.Color.White
        Me.lblDescripcion.Location = New System.Drawing.Point(16, 68)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(96, 20)
        Me.lblDescripcion.TabIndex = 56
        Me.lblDescripcion.Text = "Descripcion"
        '
        'lblNombreDiario
        '
        Me.lblNombreDiario.AutoSize = True
        Me.lblNombreDiario.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblNombreDiario.ForeColor = System.Drawing.Color.White
        Me.lblNombreDiario.Location = New System.Drawing.Point(16, 122)
        Me.lblNombreDiario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreDiario.Name = "lblNombreDiario"
        Me.lblNombreDiario.Size = New System.Drawing.Size(114, 20)
        Me.lblNombreDiario.TabIndex = 55
        Me.lblNombreDiario.Text = "Nombre Diario"
        '
        'lblNombreOriginal
        '
        Me.lblNombreOriginal.AutoSize = True
        Me.lblNombreOriginal.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblNombreOriginal.ForeColor = System.Drawing.Color.White
        Me.lblNombreOriginal.Location = New System.Drawing.Point(797, 122)
        Me.lblNombreOriginal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreOriginal.Name = "lblNombreOriginal"
        Me.lblNombreOriginal.Size = New System.Drawing.Size(152, 20)
        Me.lblNombreOriginal.TabIndex = 54
        Me.lblNombreOriginal.Text = "Nombre de Original"
        '
        'lblNProducto
        '
        Me.lblNProducto.AutoSize = True
        Me.lblNProducto.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblNProducto.ForeColor = System.Drawing.Color.White
        Me.lblNProducto.Location = New System.Drawing.Point(16, 27)
        Me.lblNProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNProducto.Name = "lblNProducto"
        Me.lblNProducto.Size = New System.Drawing.Size(98, 20)
        Me.lblNProducto.TabIndex = 53
        Me.lblNProducto.Text = "N° Producto"
        '
        'cboRubro
        '
        Me.cboRubro.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cboRubro.FormattingEnabled = True
        Me.cboRubro.Location = New System.Drawing.Point(20, 199)
        Me.cboRubro.Margin = New System.Windows.Forms.Padding(4)
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Size = New System.Drawing.Size(247, 28)
        Me.cboRubro.TabIndex = 5
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtId.Location = New System.Drawing.Point(152, 23)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(65, 27)
        Me.txtId.TabIndex = 1
        '
        'chkAlterntivo
        '
        Me.chkAlterntivo.AutoSize = True
        Me.chkAlterntivo.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.chkAlterntivo.ForeColor = System.Drawing.Color.White
        Me.chkAlterntivo.Location = New System.Drawing.Point(800, 86)
        Me.chkAlterntivo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAlterntivo.Name = "chkAlterntivo"
        Me.chkAlterntivo.Size = New System.Drawing.Size(130, 24)
        Me.chkAlterntivo.TabIndex = 11
        Me.chkAlterntivo.Text = "¿Alternativo?"
        Me.chkAlterntivo.UseVisualStyleBackColor = True
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
        Me.btnBuscar.Location = New System.Drawing.Point(252, 18)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(67, 34)
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
        Me.btnAceptar.Location = New System.Drawing.Point(1091, 305)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(109, 34)
        Me.btnAceptar.TabIndex = 22
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
        Me.btnCancelar.Location = New System.Drawing.Point(1091, 463)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(109, 34)
        Me.btnCancelar.TabIndex = 24
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnModificar.Location = New System.Drawing.Point(1091, 384)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(109, 34)
        Me.btnModificar.TabIndex = 23
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregarMarca
        '
        Me.btnAgregarMarca.BackgroundImage = CType(resources.GetObject("btnAgregarMarca.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarMarca.Location = New System.Drawing.Point(673, 37)
        Me.btnAgregarMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarMarca.Name = "btnAgregarMarca"
        Me.btnAgregarMarca.Size = New System.Drawing.Size(35, 31)
        Me.btnAgregarMarca.TabIndex = 106
        Me.btnAgregarMarca.TabStop = False
        '
        'btnAgregarRubro
        '
        Me.btnAgregarRubro.BackgroundImage = CType(resources.GetObject("btnAgregarRubro.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregarRubro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregarRubro.Location = New System.Drawing.Point(284, 199)
        Me.btnAgregarRubro.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarRubro.Name = "btnAgregarRubro"
        Me.btnAgregarRubro.Size = New System.Drawing.Size(35, 31)
        Me.btnAgregarRubro.TabIndex = 107
        Me.btnAgregarRubro.TabStop = False
        '
        'lblDatosEspecificos
        '
        Me.lblDatosEspecificos.AutoSize = True
        Me.lblDatosEspecificos.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblDatosEspecificos.ForeColor = System.Drawing.Color.White
        Me.lblDatosEspecificos.Location = New System.Drawing.Point(72, 20)
        Me.lblDatosEspecificos.Name = "lblDatosEspecificos"
        Me.lblDatosEspecificos.Size = New System.Drawing.Size(136, 20)
        Me.lblDatosEspecificos.TabIndex = 110
        Me.lblDatosEspecificos.Text = "Datos Específicos"
        '
        'PanelDatosEspecificos
        '
        Me.PanelDatosEspecificos.Controls.Add(Me.Label3)
        Me.PanelDatosEspecificos.Controls.Add(Me.Label2)
        Me.PanelDatosEspecificos.Controls.Add(Me.Label1)
        Me.PanelDatosEspecificos.Controls.Add(Me.cboOrigen)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblDescripcion)
        Me.PanelDatosEspecificos.Controls.Add(Me.txtDescripcion)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblNombreDiario)
        Me.PanelDatosEspecificos.Controls.Add(Me.btnAgregarRubro)
        Me.PanelDatosEspecificos.Controls.Add(Me.txtNombreDiario)
        Me.PanelDatosEspecificos.Controls.Add(Me.btnAgregarMarca)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblMarca)
        Me.PanelDatosEspecificos.Controls.Add(Me.btnBuscar)
        Me.PanelDatosEspecificos.Controls.Add(Me.chkEstado)
        Me.PanelDatosEspecificos.Controls.Add(Me.txtId)
        Me.PanelDatosEspecificos.Controls.Add(Me.cboOriginal)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblNombreOriginal)
        Me.PanelDatosEspecificos.Controls.Add(Me.cboMarca)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblRubro)
        Me.PanelDatosEspecificos.Controls.Add(Me.chkAlterntivo)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblOrigen)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblNProducto)
        Me.PanelDatosEspecificos.Controls.Add(Me.cboRubro)
        Me.PanelDatosEspecificos.Controls.Add(Me.txtCodFabricante)
        Me.PanelDatosEspecificos.Controls.Add(Me.txtCodigoBarra)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblCodBarra)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblCodFabricante)
        Me.PanelDatosEspecificos.Controls.Add(Me.lblCantBulto)
        Me.PanelDatosEspecificos.Controls.Add(Me.txtCantidadBulto)
        Me.PanelDatosEspecificos.Location = New System.Drawing.Point(56, 31)
        Me.PanelDatosEspecificos.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDatosEspecificos.Name = "PanelDatosEspecificos"
        Me.PanelDatosEspecificos.Size = New System.Drawing.Size(1144, 247)
        Me.PanelDatosEspecificos.TabIndex = 109
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(544, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 18)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(468, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 18)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(125, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 18)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "*"
        '
        'cboOrigen
        '
        Me.cboOrigen.DisplayMember = "Nacional"
        Me.cboOrigen.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.cboOrigen.FormattingEnabled = True
        Me.cboOrigen.ItemHeight = 20
        Me.cboOrigen.Items.AddRange(New Object() {"Nacional", "Importado"})
        Me.cboOrigen.Location = New System.Drawing.Point(800, 37)
        Me.cboOrigen.Margin = New System.Windows.Forms.Padding(4)
        Me.cboOrigen.Name = "cboOrigen"
        Me.cboOrigen.Size = New System.Drawing.Size(297, 28)
        Me.cboOrigen.TabIndex = 10
        '
        'lblExistencia
        '
        Me.lblExistencia.AutoSize = True
        Me.lblExistencia.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblExistencia.ForeColor = System.Drawing.Color.White
        Me.lblExistencia.Location = New System.Drawing.Point(76, 295)
        Me.lblExistencia.Name = "lblExistencia"
        Me.lblExistencia.Size = New System.Drawing.Size(80, 20)
        Me.lblExistencia.TabIndex = 112
        Me.lblExistencia.Text = "Existencia"
        '
        'PanelExistencia
        '
        Me.PanelExistencia.Controls.Add(Me.Label5)
        Me.PanelExistencia.Controls.Add(Me.txtStockDisponible)
        Me.PanelExistencia.Controls.Add(Me.txtStockReal)
        Me.PanelExistencia.Controls.Add(Me.lblStockReal)
        Me.PanelExistencia.Controls.Add(Me.lblStockDisponible)
        Me.PanelExistencia.Controls.Add(Me.txtUbicacion)
        Me.PanelExistencia.Controls.Add(Me.lblUbicacion)
        Me.PanelExistencia.Location = New System.Drawing.Point(56, 305)
        Me.PanelExistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelExistencia.Name = "PanelExistencia"
        Me.PanelExistencia.Size = New System.Drawing.Size(421, 193)
        Me.PanelExistencia.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(113, 142)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 18)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "*"
        '
        'lblMovimientos
        '
        Me.lblMovimientos.AutoSize = True
        Me.lblMovimientos.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblMovimientos.ForeColor = System.Drawing.Color.White
        Me.lblMovimientos.Location = New System.Drawing.Point(592, 295)
        Me.lblMovimientos.Name = "lblMovimientos"
        Me.lblMovimientos.Size = New System.Drawing.Size(103, 20)
        Me.lblMovimientos.TabIndex = 114
        Me.lblMovimientos.Text = "Movimientos"
        '
        'PanelMovimientos
        '
        Me.PanelMovimientos.Controls.Add(Me.Label4)
        Me.PanelMovimientos.Controls.Add(Me.dtpFechaVenta)
        Me.PanelMovimientos.Controls.Add(Me.dtpFechaCompra)
        Me.PanelMovimientos.Controls.Add(Me.lblPrecioLista)
        Me.PanelMovimientos.Controls.Add(Me.txtPrecioLista)
        Me.PanelMovimientos.Controls.Add(Me.lblFechaUltVenta)
        Me.PanelMovimientos.Controls.Add(Me.lblFechaUltimaCompra)
        Me.PanelMovimientos.Controls.Add(Me.lblPrecioCompra)
        Me.PanelMovimientos.Controls.Add(Me.txtUtilidad)
        Me.PanelMovimientos.Controls.Add(Me.lblUtilidad)
        Me.PanelMovimientos.Controls.Add(Me.txtPrecioCompra)
        Me.PanelMovimientos.Location = New System.Drawing.Point(572, 305)
        Me.PanelMovimientos.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMovimientos.Name = "PanelMovimientos"
        Me.PanelMovimientos.Size = New System.Drawing.Size(421, 193)
        Me.PanelMovimientos.TabIndex = 113
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(143, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 18)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "*"
        '
        'dtpFechaVenta
        '
        Me.dtpFechaVenta.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaVenta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFechaVenta.Enabled = False
        Me.dtpFechaVenta.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaVenta.Location = New System.Drawing.Point(220, 143)
        Me.dtpFechaVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaVenta.Name = "dtpFechaVenta"
        Me.dtpFechaVenta.Size = New System.Drawing.Size(160, 27)
        Me.dtpFechaVenta.TabIndex = 21
        '
        'dtpFechaCompra
        '
        Me.dtpFechaCompra.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaCompra.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFechaCompra.Enabled = False
        Me.dtpFechaCompra.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaCompra.Location = New System.Drawing.Point(220, 112)
        Me.dtpFechaCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaCompra.Name = "dtpFechaCompra"
        Me.dtpFechaCompra.Size = New System.Drawing.Size(160, 27)
        Me.dtpFechaCompra.TabIndex = 20
        '
        'lblPrecioLista
        '
        Me.lblPrecioLista.AutoSize = True
        Me.lblPrecioLista.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblPrecioLista.ForeColor = System.Drawing.Color.White
        Me.lblPrecioLista.Location = New System.Drawing.Point(40, 87)
        Me.lblPrecioLista.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecioLista.Name = "lblPrecioLista"
        Me.lblPrecioLista.Size = New System.Drawing.Size(91, 20)
        Me.lblPrecioLista.TabIndex = 111
        Me.lblPrecioLista.Text = "Precio Lista"
        '
        'txtPrecioLista
        '
        Me.txtPrecioLista.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPrecioLista.Location = New System.Drawing.Point(220, 81)
        Me.txtPrecioLista.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecioLista.Name = "txtPrecioLista"
        Me.txtPrecioLista.Size = New System.Drawing.Size(160, 27)
        Me.txtPrecioLista.TabIndex = 19
        Me.txtPrecioLista.Text = "0"
        Me.txtPrecioLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFechaUltVenta
        '
        Me.lblFechaUltVenta.AutoSize = True
        Me.lblFechaUltVenta.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblFechaUltVenta.ForeColor = System.Drawing.Color.White
        Me.lblFechaUltVenta.Location = New System.Drawing.Point(39, 153)
        Me.lblFechaUltVenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaUltVenta.Name = "lblFechaUltVenta"
        Me.lblFechaUltVenta.Size = New System.Drawing.Size(135, 20)
        Me.lblFechaUltVenta.TabIndex = 110
        Me.lblFechaUltVenta.Text = "Fecha. Ult. Venta"
        '
        'lblFechaUltimaCompra
        '
        Me.lblFechaUltimaCompra.AutoSize = True
        Me.lblFechaUltimaCompra.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblFechaUltimaCompra.ForeColor = System.Drawing.Color.White
        Me.lblFechaUltimaCompra.Location = New System.Drawing.Point(40, 119)
        Me.lblFechaUltimaCompra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaUltimaCompra.Name = "lblFechaUltimaCompra"
        Me.lblFechaUltimaCompra.Size = New System.Drawing.Size(150, 20)
        Me.lblFechaUltimaCompra.TabIndex = 109
        Me.lblFechaUltimaCompra.Text = "Fecha. Ult. Compra"
        '
        'lblPrecioCompra
        '
        Me.lblPrecioCompra.AutoSize = True
        Me.lblPrecioCompra.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblPrecioCompra.ForeColor = System.Drawing.Color.White
        Me.lblPrecioCompra.Location = New System.Drawing.Point(39, 22)
        Me.lblPrecioCompra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecioCompra.Name = "lblPrecioCompra"
        Me.lblPrecioCompra.Size = New System.Drawing.Size(120, 20)
        Me.lblPrecioCompra.TabIndex = 108
        Me.lblPrecioCompra.Text = "Precio Compra"
        '
        'txtUtilidad
        '
        Me.txtUtilidad.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUtilidad.Location = New System.Drawing.Point(220, 50)
        Me.txtUtilidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUtilidad.Name = "txtUtilidad"
        Me.txtUtilidad.Size = New System.Drawing.Size(160, 27)
        Me.txtUtilidad.TabIndex = 18
        Me.txtUtilidad.Text = "0"
        Me.txtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblUtilidad
        '
        Me.lblUtilidad.AutoSize = True
        Me.lblUtilidad.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.lblUtilidad.ForeColor = System.Drawing.Color.White
        Me.lblUtilidad.Location = New System.Drawing.Point(39, 55)
        Me.lblUtilidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUtilidad.Name = "lblUtilidad"
        Me.lblUtilidad.Size = New System.Drawing.Size(90, 20)
        Me.lblUtilidad.TabIndex = 107
        Me.lblUtilidad.Text = "Utilidad (%)"
        '
        'txtPrecioCompra
        '
        Me.txtPrecioCompra.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPrecioCompra.Location = New System.Drawing.Point(220, 20)
        Me.txtPrecioCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecioCompra.Name = "txtPrecioCompra"
        Me.txtPrecioCompra.Size = New System.Drawing.Size(160, 27)
        Me.txtPrecioCompra.TabIndex = 17
        Me.txtPrecioCompra.Text = "0"
        Me.txtPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1319, 828)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.grdProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarRubro, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents lblOrigen As Label
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents txtCodigoBarra As TextBox
    Friend WithEvents txtCodFabricante As TextBox
    Friend WithEvents lblCodBarra As Label
    Friend WithEvents lblCodFabricante As Label
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
    Friend WithEvents txtUbicacion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblNombreDiario As Label
    Friend WithEvents lblNombreOriginal As Label
    Friend WithEvents lblNProducto As Label
    Friend WithEvents cboRubro As ComboBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents chkAlterntivo As CheckBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregarMarca As PictureBox
    Friend WithEvents btnAgregarRubro As PictureBox
    Friend WithEvents lblDatosEspecificos As Label
    Friend WithEvents PanelDatosEspecificos As Panel
    Friend WithEvents cboOrigen As ComboBox
    Friend WithEvents lblExistencia As Label
    Friend WithEvents PanelExistencia As Panel
    Friend WithEvents lblMovimientos As Label
    Friend WithEvents PanelMovimientos As Panel
    Friend WithEvents lblPrecioLista As Label
    Friend WithEvents txtPrecioLista As TextBox
    Friend WithEvents lblFechaUltVenta As Label
    Friend WithEvents lblFechaUltimaCompra As Label
    Friend WithEvents lblPrecioCompra As Label
    Friend WithEvents txtUtilidad As TextBox
    Friend WithEvents lblUtilidad As Label
    Friend WithEvents txtPrecioCompra As TextBox
    Friend WithEvents dtpFechaVenta As DateTimePicker
    Friend WithEvents dtpFechaCompra As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
