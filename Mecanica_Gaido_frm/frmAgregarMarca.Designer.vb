﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgregarMarca
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarMarca))
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.chkProducto = New System.Windows.Forms.CheckBox()
        Me.chkVehiculo = New System.Windows.Forms.CheckBox()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Location = New System.Drawing.Point(373, 1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(19, 18)
        Me.btnCerrar.TabIndex = 14
        Me.btnCerrar.TabStop = False
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(128, 55)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(228, 21)
        Me.txtMarca.TabIndex = 1
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.White
        Me.lblMarca.Location = New System.Drawing.Point(29, 56)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(59, 20)
        Me.lblMarca.TabIndex = 12
        Me.lblMarca.Text = "Marca"
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(299, 175)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(82, 29)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'chkProducto
        '
        Me.chkProducto.AutoSize = True
        Me.chkProducto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProducto.ForeColor = System.Drawing.Color.White
        Me.chkProducto.Location = New System.Drawing.Point(33, 115)
        Me.chkProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.chkProducto.Name = "chkProducto"
        Me.chkProducto.Size = New System.Drawing.Size(141, 21)
        Me.chkProducto.TabIndex = 2
        Me.chkProducto.Text = "¿Es de producto?"
        Me.chkProducto.UseVisualStyleBackColor = True
        '
        'chkVehiculo
        '
        Me.chkVehiculo.AutoSize = True
        Me.chkVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVehiculo.ForeColor = System.Drawing.Color.White
        Me.chkVehiculo.Location = New System.Drawing.Point(221, 115)
        Me.chkVehiculo.Margin = New System.Windows.Forms.Padding(2)
        Me.chkVehiculo.Name = "chkVehiculo"
        Me.chkVehiculo.Size = New System.Drawing.Size(135, 21)
        Me.chkVehiculo.TabIndex = 3
        Me.chkVehiculo.Text = "¿Es de vehículo?"
        Me.chkVehiculo.UseVisualStyleBackColor = True
        '
        'frmAgregarMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(393, 216)
        Me.Controls.Add(Me.chkVehiculo)
        Me.Controls.Add(Me.chkProducto)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.btnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMarca"
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents chkProducto As CheckBox
    Friend WithEvents chkVehiculo As CheckBox
End Class
