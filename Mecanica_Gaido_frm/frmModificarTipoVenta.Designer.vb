﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarTipoVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarTipoVenta))
        Me.txtTipoDeVenta = New System.Windows.Forms.TextBox()
        Me.lblTipoDeVenta = New System.Windows.Forms.Label()
        Me.chkEstadoTV = New System.Windows.Forms.CheckBox()
        Me.grdModificarTipoDeVenta = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtIdTipoDeVenta = New System.Windows.Forms.TextBox()
        Me.lblNumeroTV = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        CType(Me.grdModificarTipoDeVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTipoDeVenta
        '
        Me.txtTipoDeVenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoDeVenta.Location = New System.Drawing.Point(646, 58)
        Me.txtTipoDeVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTipoDeVenta.Name = "txtTipoDeVenta"
        Me.txtTipoDeVenta.Size = New System.Drawing.Size(346, 21)
        Me.txtTipoDeVenta.TabIndex = 49
        '
        'lblTipoDeVenta
        '
        Me.lblTipoDeVenta.AutoSize = True
        Me.lblTipoDeVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDeVenta.ForeColor = System.Drawing.Color.White
        Me.lblTipoDeVenta.Location = New System.Drawing.Point(422, 59)
        Me.lblTipoDeVenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoDeVenta.Name = "lblTipoDeVenta"
        Me.lblTipoDeVenta.Size = New System.Drawing.Size(110, 20)
        Me.lblTipoDeVenta.TabIndex = 50
        Me.lblTipoDeVenta.Text = "Tipo de Venta"
        '
        'chkEstadoTV
        '
        Me.chkEstadoTV.AutoSize = True
        Me.chkEstadoTV.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstadoTV.ForeColor = System.Drawing.Color.White
        Me.chkEstadoTV.Location = New System.Drawing.Point(116, 131)
        Me.chkEstadoTV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkEstadoTV.Name = "chkEstadoTV"
        Me.chkEstadoTV.Size = New System.Drawing.Size(85, 21)
        Me.chkEstadoTV.TabIndex = 48
        Me.chkEstadoTV.Text = "¿Activo?"
        Me.chkEstadoTV.UseVisualStyleBackColor = True
        '
        'grdModificarTipoDeVenta
        '
        Me.grdModificarTipoDeVenta.AllowUserToAddRows = False
        Me.grdModificarTipoDeVenta.AllowUserToDeleteRows = False
        Me.grdModificarTipoDeVenta.AllowUserToResizeRows = False
        Me.grdModificarTipoDeVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdModificarTipoDeVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdModificarTipoDeVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.grdModificarTipoDeVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdModificarTipoDeVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdModificarTipoDeVenta.Location = New System.Drawing.Point(66, 224)
        Me.grdModificarTipoDeVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdModificarTipoDeVenta.Name = "grdModificarTipoDeVenta"
        Me.grdModificarTipoDeVenta.ReadOnly = True
        Me.grdModificarTipoDeVenta.RowHeadersVisible = False
        Me.grdModificarTipoDeVenta.RowHeadersWidth = 51
        Me.grdModificarTipoDeVenta.Size = New System.Drawing.Size(1120, 340)
        Me.grdModificarTipoDeVenta.TabIndex = 47
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(1117, 131)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(123, 45)
        Me.btnCancelar.TabIndex = 46
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtIdTipoDeVenta
        '
        Me.txtIdTipoDeVenta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdTipoDeVenta.Location = New System.Drawing.Point(258, 58)
        Me.txtIdTipoDeVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIdTipoDeVenta.Name = "txtIdTipoDeVenta"
        Me.txtIdTipoDeVenta.Size = New System.Drawing.Size(93, 21)
        Me.txtIdTipoDeVenta.TabIndex = 43
        '
        'lblNumeroTV
        '
        Me.lblNumeroTV.AutoSize = True
        Me.lblNumeroTV.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroTV.ForeColor = System.Drawing.Color.White
        Me.lblNumeroTV.Location = New System.Drawing.Point(109, 59)
        Me.lblNumeroTV.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroTV.Name = "lblNumeroTV"
        Me.lblNumeroTV.Size = New System.Drawing.Size(64, 20)
        Me.lblNumeroTV.TabIndex = 45
        Me.lblNumeroTV.Text = "Código"
        '
        'btnModificar
        '
        Me.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatAppearance.BorderSize = 2
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(1117, 45)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(123, 45)
        Me.btnModificar.TabIndex = 44
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'frmModificarTipoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 609)
        Me.Controls.Add(Me.txtTipoDeVenta)
        Me.Controls.Add(Me.lblTipoDeVenta)
        Me.Controls.Add(Me.chkEstadoTV)
        Me.Controls.Add(Me.grdModificarTipoDeVenta)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtIdTipoDeVenta)
        Me.Controls.Add(Me.lblNumeroTV)
        Me.Controls.Add(Me.btnModificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmModificarTipoVenta"
        Me.Text = "frmModificarTipoVenta"
        CType(Me.grdModificarTipoDeVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTipoDeVenta As TextBox
    Friend WithEvents lblTipoDeVenta As Label
    Friend WithEvents chkEstadoTV As CheckBox
    Friend WithEvents grdModificarTipoDeVenta As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtIdTipoDeVenta As TextBox
    Friend WithEvents lblNumeroTV As Label
    Friend WithEvents btnModificar As Button
End Class
