﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarSecciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarSecciones))
        Me.txtSeccion = New System.Windows.Forms.TextBox()
        Me.lblSeccion = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.grdModificarSeccion = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblNumeroSeccion = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        CType(Me.grdModificarSeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSeccion
        '
        Me.txtSeccion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeccion.Location = New System.Drawing.Point(374, 38)
        Me.txtSeccion.Name = "txtSeccion"
        Me.txtSeccion.Size = New System.Drawing.Size(187, 21)
        Me.txtSeccion.TabIndex = 2
        '
        'lblSeccion
        '
        Me.lblSeccion.AutoSize = True
        Me.lblSeccion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeccion.ForeColor = System.Drawing.Color.Black
        Me.lblSeccion.Location = New System.Drawing.Point(281, 39)
        Me.lblSeccion.Name = "lblSeccion"
        Me.lblSeccion.Size = New System.Drawing.Size(68, 20)
        Me.lblSeccion.TabIndex = 42
        Me.lblSeccion.Text = "Sección"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.Black
        Me.chkEstado.Location = New System.Drawing.Point(77, 86)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(85, 21)
        Me.chkEstado.TabIndex = 3
        Me.chkEstado.Text = "¿Activa?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'grdModificarSeccion
        '
        Me.grdModificarSeccion.AllowUserToAddRows = False
        Me.grdModificarSeccion.AllowUserToDeleteRows = False
        Me.grdModificarSeccion.AllowUserToResizeRows = False
        Me.grdModificarSeccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdModificarSeccion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdModificarSeccion.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.grdModificarSeccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdModificarSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdModificarSeccion.Location = New System.Drawing.Point(44, 146)
        Me.grdModificarSeccion.MultiSelect = False
        Me.grdModificarSeccion.Name = "grdModificarSeccion"
        Me.grdModificarSeccion.ReadOnly = True
        Me.grdModificarSeccion.RowHeadersVisible = False
        Me.grdModificarSeccion.RowHeadersWidth = 51
        Me.grdModificarSeccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdModificarSeccion.Size = New System.Drawing.Size(747, 221)
        Me.grdModificarSeccion.TabIndex = 39
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(745, 86)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(82, 29)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(172, 38)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(63, 21)
        Me.txtId.TabIndex = 1
        '
        'lblNumeroSeccion
        '
        Me.lblNumeroSeccion.AutoSize = True
        Me.lblNumeroSeccion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroSeccion.ForeColor = System.Drawing.Color.Black
        Me.lblNumeroSeccion.Location = New System.Drawing.Point(73, 39)
        Me.lblNumeroSeccion.Name = "lblNumeroSeccion"
        Me.lblNumeroSeccion.Size = New System.Drawing.Size(89, 20)
        Me.lblNumeroSeccion.TabIndex = 37
        Me.lblNumeroSeccion.Text = "N° Sección"
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Location = New System.Drawing.Point(745, 34)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(82, 29)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'frmModificarSecciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(871, 396)
        Me.Controls.Add(Me.txtSeccion)
        Me.Controls.Add(Me.lblSeccion)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.grdModificarSeccion)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblNumeroSeccion)
        Me.Controls.Add(Me.btnModificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmModificarSecciones"
        Me.Text = "frmModificarSecciones"
        CType(Me.grdModificarSeccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSeccion As TextBox
    Friend WithEvents lblSeccion As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents grdModificarSeccion As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblNumeroSeccion As Label
    Friend WithEvents btnModificar As Button
End Class
