﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarTipoVehiculos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarTipoVehiculos))
        Me.txtTipoVehiculo = New System.Windows.Forms.TextBox()
        Me.lblTipoVehiculo = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.grdModificarTipoVehiculo = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblNumeroTipoVehiculo = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        CType(Me.grdModificarTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTipoVehiculo
        '
        Me.txtTipoVehiculo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoVehiculo.Location = New System.Drawing.Point(608, 44)
        Me.txtTipoVehiculo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTipoVehiculo.Name = "txtTipoVehiculo"
        Me.txtTipoVehiculo.Size = New System.Drawing.Size(248, 24)
        Me.txtTipoVehiculo.TabIndex = 2
        '
        'lblTipoVehiculo
        '
        Me.lblTipoVehiculo.AutoSize = True
        Me.lblTipoVehiculo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoVehiculo.ForeColor = System.Drawing.Color.White
        Me.lblTipoVehiculo.Location = New System.Drawing.Point(427, 46)
        Me.lblTipoVehiculo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoVehiculo.Name = "lblTipoVehiculo"
        Me.lblTipoVehiculo.Size = New System.Drawing.Size(162, 22)
        Me.lblTipoVehiculo.TabIndex = 50
        Me.lblTipoVehiculo.Text = "Tipo de Vehículo"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(103, 103)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(108, 25)
        Me.chkEstado.TabIndex = 3
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'grdModificarTipoVehiculo
        '
        Me.grdModificarTipoVehiculo.AllowUserToAddRows = False
        Me.grdModificarTipoVehiculo.AllowUserToDeleteRows = False
        Me.grdModificarTipoVehiculo.AllowUserToResizeRows = False
        Me.grdModificarTipoVehiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdModificarTipoVehiculo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdModificarTipoVehiculo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdModificarTipoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdModificarTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdModificarTipoVehiculo.Location = New System.Drawing.Point(59, 177)
        Me.grdModificarTipoVehiculo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdModificarTipoVehiculo.Name = "grdModificarTipoVehiculo"
        Me.grdModificarTipoVehiculo.ReadOnly = True
        Me.grdModificarTipoVehiculo.RowHeadersVisible = False
        Me.grdModificarTipoVehiculo.RowHeadersWidth = 51
        Me.grdModificarTipoVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdModificarTipoVehiculo.Size = New System.Drawing.Size(996, 272)
        Me.grdModificarTipoVehiculo.TabIndex = 47
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(993, 103)
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
        Me.txtId.Location = New System.Drawing.Point(307, 44)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(83, 24)
        Me.txtId.TabIndex = 1
        '
        'lblNumeroTipoVehiculo
        '
        Me.lblNumeroTipoVehiculo.AutoSize = True
        Me.lblNumeroTipoVehiculo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroTipoVehiculo.ForeColor = System.Drawing.Color.White
        Me.lblNumeroTipoVehiculo.Location = New System.Drawing.Point(97, 46)
        Me.lblNumeroTipoVehiculo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroTipoVehiculo.Name = "lblNumeroTipoVehiculo"
        Me.lblNumeroTipoVehiculo.Size = New System.Drawing.Size(189, 22)
        Me.lblNumeroTipoVehiculo.TabIndex = 45
        Me.lblNumeroTipoVehiculo.Text = "N° Tipo de Vehículo"
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatAppearance.BorderSize = 2
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(993, 39)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(109, 36)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'frmModificarTipoVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1161, 487)
        Me.Controls.Add(Me.txtTipoVehiculo)
        Me.Controls.Add(Me.lblTipoVehiculo)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.grdModificarTipoVehiculo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblNumeroTipoVehiculo)
        Me.Controls.Add(Me.btnModificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmModificarTipoVehiculos"
        Me.Text = "frmModificarTipoVehiculos"
        CType(Me.grdModificarTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTipoVehiculo As TextBox
    Friend WithEvents lblTipoVehiculo As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents grdModificarTipoVehiculo As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblNumeroTipoVehiculo As Label
    Friend WithEvents btnModificar As Button
End Class
