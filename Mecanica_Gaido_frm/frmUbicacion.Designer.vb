<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUbicacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUbicacion))
        Me.treeViewCodDep = New System.Windows.Forms.TreeView()
        Me.txtCodDep = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnD_Aceptar = New System.Windows.Forms.Button()
        Me.btnD_Modificar = New System.Windows.Forms.Button()
        Me.grdDepositos = New System.Windows.Forms.DataGridView()
        Me.NumFilas = New System.Windows.Forms.NumericUpDown()
        Me.NumColumnas = New System.Windows.Forms.NumericUpDown()
        Me.NumEstanterias = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreDeposito = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        CType(Me.grdDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumFilas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumColumnas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumEstanterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'treeViewCodDep
        '
        Me.treeViewCodDep.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.treeViewCodDep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.treeViewCodDep.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treeViewCodDep.ForeColor = System.Drawing.Color.White
        Me.treeViewCodDep.LineColor = System.Drawing.Color.SeaGreen
        Me.treeViewCodDep.Location = New System.Drawing.Point(15, 27)
        Me.treeViewCodDep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.treeViewCodDep.Name = "treeViewCodDep"
        Me.treeViewCodDep.Size = New System.Drawing.Size(759, 274)
        Me.treeViewCodDep.TabIndex = 0
        '
        'txtCodDep
        '
        Me.txtCodDep.Enabled = False
        Me.txtCodDep.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDep.Location = New System.Drawing.Point(319, 314)
        Me.txtCodDep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodDep.Name = "txtCodDep"
        Me.txtCodDep.Size = New System.Drawing.Size(168, 27)
        Me.txtCodDep.TabIndex = 1
        Me.txtCodDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(517, 307)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Seleccionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(648, 307)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(33, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seleccione la ubicación:"
        '
        'btnD_Aceptar
        '
        Me.btnD_Aceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnD_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnD_Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnD_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnD_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD_Aceptar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnD_Aceptar.ForeColor = System.Drawing.Color.Black
        Me.btnD_Aceptar.Location = New System.Drawing.Point(648, 471)
        Me.btnD_Aceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnD_Aceptar.Name = "btnD_Aceptar"
        Me.btnD_Aceptar.Size = New System.Drawing.Size(126, 43)
        Me.btnD_Aceptar.TabIndex = 142
        Me.btnD_Aceptar.Text = "Aceptar"
        Me.btnD_Aceptar.UseVisualStyleBackColor = False
        '
        'btnD_Modificar
        '
        Me.btnD_Modificar.BackColor = System.Drawing.Color.Transparent
        Me.btnD_Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnD_Modificar.Enabled = False
        Me.btnD_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnD_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnD_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD_Modificar.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnD_Modificar.ForeColor = System.Drawing.Color.Black
        Me.btnD_Modificar.Location = New System.Drawing.Point(648, 522)
        Me.btnD_Modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnD_Modificar.Name = "btnD_Modificar"
        Me.btnD_Modificar.Size = New System.Drawing.Size(126, 43)
        Me.btnD_Modificar.TabIndex = 140
        Me.btnD_Modificar.Text = "Modificar"
        Me.btnD_Modificar.UseVisualStyleBackColor = False
        '
        'grdDepositos
        '
        Me.grdDepositos.AllowUserToAddRows = False
        Me.grdDepositos.AllowUserToDeleteRows = False
        Me.grdDepositos.AllowUserToResizeRows = False
        Me.grdDepositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdDepositos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.grdDepositos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdDepositos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDepositos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdDepositos.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdDepositos.Location = New System.Drawing.Point(13, 470)
        Me.grdDepositos.Margin = New System.Windows.Forms.Padding(4)
        Me.grdDepositos.MultiSelect = False
        Me.grdDepositos.Name = "grdDepositos"
        Me.grdDepositos.ReadOnly = True
        Me.grdDepositos.RowHeadersVisible = False
        Me.grdDepositos.RowHeadersWidth = 51
        Me.grdDepositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDepositos.Size = New System.Drawing.Size(617, 207)
        Me.grdDepositos.TabIndex = 139
        '
        'NumFilas
        '
        Me.NumFilas.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumFilas.Location = New System.Drawing.Point(546, 431)
        Me.NumFilas.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumFilas.Name = "NumFilas"
        Me.NumFilas.Size = New System.Drawing.Size(80, 28)
        Me.NumFilas.TabIndex = 158
        Me.NumFilas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumFilas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumColumnas
        '
        Me.NumColumnas.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumColumnas.Location = New System.Drawing.Point(438, 431)
        Me.NumColumnas.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumColumnas.Name = "NumColumnas"
        Me.NumColumnas.Size = New System.Drawing.Size(102, 28)
        Me.NumColumnas.TabIndex = 157
        Me.NumColumnas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumColumnas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumEstanterias
        '
        Me.NumEstanterias.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumEstanterias.Location = New System.Drawing.Point(334, 431)
        Me.NumEstanterias.Maximum = New Decimal(New Integer() {26, 0, 0, 0})
        Me.NumEstanterias.Name = "NumEstanterias"
        Me.NumEstanterias.Size = New System.Drawing.Size(101, 28)
        Me.NumEstanterias.TabIndex = 156
        Me.NumEstanterias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumEstanterias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(545, 400)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 21)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Filas:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(443, 400)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 21)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Columnas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(330, 400)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 21)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Estanterías:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 400)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 21)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Nombre:"
        '
        'txtNombreDeposito
        '
        Me.txtNombreDeposito.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreDeposito.Location = New System.Drawing.Point(18, 432)
        Me.txtNombreDeposito.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreDeposito.Name = "txtNombreDeposito"
        Me.txtNombreDeposito.Size = New System.Drawing.Size(309, 27)
        Me.txtNombreDeposito.TabIndex = 151
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 374)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 21)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "Gestión de Depósitos"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Checked = True
        Me.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.Black
        Me.chkEstado.Location = New System.Drawing.Point(648, 432)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(108, 25)
        Me.chkEstado.TabIndex = 160
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        Me.chkEstado.Visible = False
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(230, 400)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(97, 27)
        Me.txtID.TabIndex = 161
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtID.Visible = False
        '
        'frmUbicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 704)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumFilas)
        Me.Controls.Add(Me.NumColumnas)
        Me.Controls.Add(Me.NumEstanterias)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombreDeposito)
        Me.Controls.Add(Me.btnD_Aceptar)
        Me.Controls.Add(Me.btnD_Modificar)
        Me.Controls.Add(Me.grdDepositos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCodDep)
        Me.Controls.Add(Me.treeViewCodDep)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmUbicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUbicacion"
        CType(Me.grdDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumFilas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumColumnas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumEstanterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents treeViewCodDep As TreeView
    Friend WithEvents txtCodDep As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnD_Aceptar As Button
    Friend WithEvents btnD_Modificar As Button
    Friend WithEvents grdDepositos As DataGridView
    Friend WithEvents NumFilas As NumericUpDown
    Friend WithEvents NumColumnas As NumericUpDown
    Friend WithEvents NumEstanterias As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreDeposito As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents txtID As TextBox
End Class
