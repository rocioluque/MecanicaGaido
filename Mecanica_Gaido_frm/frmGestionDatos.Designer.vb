﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionDatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionDatos))
        Me.PanelPadre = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMarca = New System.Windows.Forms.Button()
        Me.btnRubro = New System.Windows.Forms.Button()
        Me.btnRol = New System.Windows.Forms.Button()
        Me.btnCiudad = New System.Windows.Forms.Button()
        Me.btnTipoVenta = New System.Windows.Forms.Button()
        Me.btnFormaPago = New System.Windows.Forms.Button()
        Me.btnTipoVehiculos = New System.Windows.Forms.Button()
        Me.frmFormaEntrega = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.btnSeccion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PanelPadre
        '
        Me.PanelPadre.Location = New System.Drawing.Point(53, 208)
        Me.PanelPadre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelPadre.Name = "PanelPadre"
        Me.PanelPadre.Size = New System.Drawing.Size(1161, 487)
        Me.PanelPadre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "¿Dónde quéres gestionar?"
        '
        'btnMarca
        '
        Me.btnMarca.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnMarca.FlatAppearance.BorderSize = 2
        Me.btnMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarca.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarca.ForeColor = System.Drawing.Color.White
        Me.btnMarca.Location = New System.Drawing.Point(271, 76)
        Me.btnMarca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMarca.Name = "btnMarca"
        Me.btnMarca.Size = New System.Drawing.Size(109, 36)
        Me.btnMarca.TabIndex = 1
        Me.btnMarca.Text = "Marcas"
        Me.btnMarca.UseVisualStyleBackColor = True
        '
        'btnRubro
        '
        Me.btnRubro.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnRubro.FlatAppearance.BorderSize = 2
        Me.btnRubro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRubro.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRubro.ForeColor = System.Drawing.Color.White
        Me.btnRubro.Location = New System.Drawing.Point(421, 76)
        Me.btnRubro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRubro.Name = "btnRubro"
        Me.btnRubro.Size = New System.Drawing.Size(109, 36)
        Me.btnRubro.TabIndex = 3
        Me.btnRubro.Text = "Rubros"
        Me.btnRubro.UseVisualStyleBackColor = True
        '
        'btnRol
        '
        Me.btnRol.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnRol.FlatAppearance.BorderSize = 2
        Me.btnRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRol.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRol.ForeColor = System.Drawing.Color.White
        Me.btnRol.Location = New System.Drawing.Point(723, 76)
        Me.btnRol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRol.Name = "btnRol"
        Me.btnRol.Size = New System.Drawing.Size(109, 36)
        Me.btnRol.TabIndex = 7
        Me.btnRol.Text = "Roles"
        Me.btnRol.UseVisualStyleBackColor = True
        '
        'btnCiudad
        '
        Me.btnCiudad.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCiudad.FlatAppearance.BorderSize = 2
        Me.btnCiudad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCiudad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCiudad.ForeColor = System.Drawing.Color.White
        Me.btnCiudad.Location = New System.Drawing.Point(572, 76)
        Me.btnCiudad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCiudad.Name = "btnCiudad"
        Me.btnCiudad.Size = New System.Drawing.Size(109, 36)
        Me.btnCiudad.TabIndex = 5
        Me.btnCiudad.Text = "Ciudades"
        Me.btnCiudad.UseVisualStyleBackColor = True
        '
        'btnTipoVenta
        '
        Me.btnTipoVenta.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnTipoVenta.FlatAppearance.BorderSize = 2
        Me.btnTipoVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnTipoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoVenta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipoVenta.ForeColor = System.Drawing.Color.White
        Me.btnTipoVenta.Location = New System.Drawing.Point(729, 148)
        Me.btnTipoVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTipoVenta.Name = "btnTipoVenta"
        Me.btnTipoVenta.Size = New System.Drawing.Size(163, 36)
        Me.btnTipoVenta.TabIndex = 6
        Me.btnTipoVenta.Text = "Tipos de Ventas"
        Me.btnTipoVenta.UseVisualStyleBackColor = True
        '
        'btnFormaPago
        '
        Me.btnFormaPago.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnFormaPago.FlatAppearance.BorderSize = 2
        Me.btnFormaPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormaPago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormaPago.ForeColor = System.Drawing.Color.White
        Me.btnFormaPago.Location = New System.Drawing.Point(516, 148)
        Me.btnFormaPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFormaPago.Name = "btnFormaPago"
        Me.btnFormaPago.Size = New System.Drawing.Size(172, 36)
        Me.btnFormaPago.TabIndex = 4
        Me.btnFormaPago.Text = "Formas de Pago"
        Me.btnFormaPago.UseVisualStyleBackColor = True
        '
        'btnTipoVehiculos
        '
        Me.btnTipoVehiculos.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnTipoVehiculos.FlatAppearance.BorderSize = 2
        Me.btnTipoVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnTipoVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTipoVehiculos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipoVehiculos.ForeColor = System.Drawing.Color.White
        Me.btnTipoVehiculos.Location = New System.Drawing.Point(273, 148)
        Me.btnTipoVehiculos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTipoVehiculos.Name = "btnTipoVehiculos"
        Me.btnTipoVehiculos.Size = New System.Drawing.Size(201, 36)
        Me.btnTipoVehiculos.TabIndex = 2
        Me.btnTipoVehiculos.Text = "Tipos de Vehiculos"
        Me.btnTipoVehiculos.UseVisualStyleBackColor = True
        '
        'frmFormaEntrega
        '
        Me.frmFormaEntrega.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.frmFormaEntrega.FlatAppearance.BorderSize = 2
        Me.frmFormaEntrega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.frmFormaEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.frmFormaEntrega.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmFormaEntrega.ForeColor = System.Drawing.Color.White
        Me.frmFormaEntrega.Location = New System.Drawing.Point(933, 148)
        Me.frmFormaEntrega.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.frmFormaEntrega.Name = "frmFormaEntrega"
        Me.frmFormaEntrega.Size = New System.Drawing.Size(197, 36)
        Me.frmFormaEntrega.TabIndex = 8
        Me.frmFormaEntrega.Text = "Formas de Entrega"
        Me.frmFormaEntrega.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.Button10.FlatAppearance.BorderSize = 2
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(1033, 76)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(109, 36)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = ".........."
        Me.Button10.UseVisualStyleBackColor = True
        '
        'btnSeccion
        '
        Me.btnSeccion.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnSeccion.FlatAppearance.BorderSize = 2
        Me.btnSeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeccion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeccion.ForeColor = System.Drawing.Color.White
        Me.btnSeccion.Location = New System.Drawing.Point(873, 76)
        Me.btnSeccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSeccion.Name = "btnSeccion"
        Me.btnSeccion.Size = New System.Drawing.Size(119, 36)
        Me.btnSeccion.TabIndex = 9
        Me.btnSeccion.Text = "Secciones"
        Me.btnSeccion.UseVisualStyleBackColor = True
        '
        'frmGestionDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1600, 800)
        Me.Controls.Add(Me.frmFormaEntrega)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.btnSeccion)
        Me.Controls.Add(Me.btnTipoVenta)
        Me.Controls.Add(Me.btnFormaPago)
        Me.Controls.Add(Me.btnTipoVehiculos)
        Me.Controls.Add(Me.btnRol)
        Me.Controls.Add(Me.btnCiudad)
        Me.Controls.Add(Me.btnRubro)
        Me.Controls.Add(Me.btnMarca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelPadre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmGestionDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmGestionDatos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelPadre As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMarca As Button
    Friend WithEvents btnRubro As Button
    Friend WithEvents btnRol As Button
    Friend WithEvents btnCiudad As Button
    Friend WithEvents btnTipoVenta As Button
    Friend WithEvents btnFormaPago As Button
    Friend WithEvents btnTipoVehiculos As Button
    Friend WithEvents frmFormaEntrega As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents btnSeccion As Button
End Class
