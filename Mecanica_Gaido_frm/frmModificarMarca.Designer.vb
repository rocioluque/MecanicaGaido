﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarMarca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarMarca))
        Me.chkVehiculo = New System.Windows.Forms.CheckBox()
        Me.chkProducto = New System.Windows.Forms.CheckBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grdModificarMarca = New System.Windows.Forms.DataGridView()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        CType(Me.grdModificarMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkVehiculo
        '
        Me.chkVehiculo.AutoSize = True
        Me.chkVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVehiculo.ForeColor = System.Drawing.Color.White
        Me.chkVehiculo.Location = New System.Drawing.Point(270, 110)
        Me.chkVehiculo.Margin = New System.Windows.Forms.Padding(2)
        Me.chkVehiculo.Name = "chkVehiculo"
        Me.chkVehiculo.Size = New System.Drawing.Size(135, 21)
        Me.chkVehiculo.TabIndex = 17
        Me.chkVehiculo.Text = "¿Es de vehículo?"
        Me.chkVehiculo.UseVisualStyleBackColor = True
        '
        'chkProducto
        '
        Me.chkProducto.AutoSize = True
        Me.chkProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProducto.ForeColor = System.Drawing.Color.White
        Me.chkProducto.Location = New System.Drawing.Point(86, 110)
        Me.chkProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.chkProducto.Name = "chkProducto"
        Me.chkProducto.Size = New System.Drawing.Size(141, 21)
        Me.chkProducto.TabIndex = 16
        Me.chkProducto.Text = "¿Es de producto?"
        Me.chkProducto.UseVisualStyleBackColor = True
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(181, 54)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(228, 21)
        Me.txtMarca.TabIndex = 15
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.White
        Me.lblMarca.Location = New System.Drawing.Point(82, 55)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(59, 20)
        Me.lblMarca.TabIndex = 19
        Me.lblMarca.Text = "Marca"
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatAppearance.BorderSize = 2
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(609, 46)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(82, 29)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(609, 102)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(82, 29)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grdModificarMarca
        '
        Me.grdModificarMarca.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.grdModificarMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdModificarMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdModificarMarca.Location = New System.Drawing.Point(53, 178)
        Me.grdModificarMarca.Name = "grdModificarMarca"
        Me.grdModificarMarca.Size = New System.Drawing.Size(676, 205)
        Me.grdModificarMarca.TabIndex = 21
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(442, 110)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(85, 21)
        Me.chkEstado.TabIndex = 22
        Me.chkEstado.Text = "¿Activo?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'frmModificarMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.grdModificarMarca)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.chkVehiculo)
        Me.Controls.Add(Me.chkProducto)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.btnModificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModificarMarca"
        Me.Text = "frmModificar"
        CType(Me.grdModificarMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkVehiculo As CheckBox
    Friend WithEvents chkProducto As CheckBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents grdModificarMarca As DataGridView
    Friend WithEvents chkEstado As CheckBox
End Class
