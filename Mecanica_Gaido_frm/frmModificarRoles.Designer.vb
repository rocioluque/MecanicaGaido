<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarRoles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarRoles))
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.grdModificarRol = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblNumeroRol = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        CType(Me.grdModificarRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRol
        '
        Me.txtRol.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRol.Location = New System.Drawing.Point(499, 47)
        Me.txtRol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(248, 24)
        Me.txtRol.TabIndex = 2
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ForeColor = System.Drawing.Color.White
        Me.lblRol.Location = New System.Drawing.Point(375, 48)
        Me.lblRol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(37, 22)
        Me.lblRol.TabIndex = 34
        Me.lblRol.Text = "Rol"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(103, 106)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(108, 25)
        Me.chkEstado.TabIndex = 3
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'grdModificarRol
        '
        Me.grdModificarRol.AllowUserToAddRows = False
        Me.grdModificarRol.AllowUserToDeleteRows = False
        Me.grdModificarRol.AllowUserToResizeRows = False
        Me.grdModificarRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdModificarRol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdModificarRol.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdModificarRol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdModificarRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdModificarRol.Location = New System.Drawing.Point(59, 180)
        Me.grdModificarRol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdModificarRol.Name = "grdModificarRol"
        Me.grdModificarRol.ReadOnly = True
        Me.grdModificarRol.RowHeadersVisible = False
        Me.grdModificarRol.RowHeadersWidth = 51
        Me.grdModificarRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdModificarRol.Size = New System.Drawing.Size(996, 272)
        Me.grdModificarRol.TabIndex = 31
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(993, 106)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(109, 36)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(229, 47)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(83, 24)
        Me.txtId.TabIndex = 1
        '
        'lblNumeroRol
        '
        Me.lblNumeroRol.AutoSize = True
        Me.lblNumeroRol.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroRol.ForeColor = System.Drawing.Color.White
        Me.lblNumeroRol.Location = New System.Drawing.Point(97, 48)
        Me.lblNumeroRol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroRol.Name = "lblNumeroRol"
        Me.lblNumeroRol.Size = New System.Drawing.Size(64, 22)
        Me.lblNumeroRol.TabIndex = 29
        Me.lblNumeroRol.Text = "N° Rol"
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatAppearance.BorderSize = 2
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(993, 37)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(109, 36)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'frmModificarRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1161, 487)
        Me.Controls.Add(Me.txtRol)
        Me.Controls.Add(Me.lblRol)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.grdModificarRol)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblNumeroRol)
        Me.Controls.Add(Me.btnModificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmModificarRoles"
        Me.Text = "frmModificarRoles"
        CType(Me.grdModificarRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRol As TextBox
    Friend WithEvents lblRol As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents grdModificarRol As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblNumeroRol As Label
    Friend WithEvents btnModificar As Button
End Class
