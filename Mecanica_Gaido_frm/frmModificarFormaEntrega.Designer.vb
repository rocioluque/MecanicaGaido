﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarFormaEntrega
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarFormaEntrega))
        Me.txtFormaEntrega = New System.Windows.Forms.TextBox()
        Me.lblFormaEntrega = New System.Windows.Forms.Label()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.grdModificarFormaEntrega = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblNumeroFormaEntrega = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        CType(Me.grdModificarFormaEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFormaEntrega
        '
        Me.txtFormaEntrega.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaEntrega.Location = New System.Drawing.Point(619, 44)
        Me.txtFormaEntrega.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFormaEntrega.Name = "txtFormaEntrega"
        Me.txtFormaEntrega.Size = New System.Drawing.Size(248, 24)
        Me.txtFormaEntrega.TabIndex = 2
        '
        'lblFormaEntrega
        '
        Me.lblFormaEntrega.AutoSize = True
        Me.lblFormaEntrega.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaEntrega.ForeColor = System.Drawing.Color.White
        Me.lblFormaEntrega.Location = New System.Drawing.Point(427, 46)
        Me.lblFormaEntrega.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormaEntrega.Name = "lblFormaEntrega"
        Me.lblFormaEntrega.Size = New System.Drawing.Size(175, 22)
        Me.lblFormaEntrega.TabIndex = 58
        Me.lblFormaEntrega.Text = "Forma de Entrega"
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstado.ForeColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(103, 103)
        Me.chkEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(109, 25)
        Me.chkEstado.TabIndex = 3
        Me.chkEstado.Text = "¿Activa?"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'grdModificarFormaEntrega
        '
        Me.grdModificarFormaEntrega.AllowUserToAddRows = False
        Me.grdModificarFormaEntrega.AllowUserToDeleteRows = False
        Me.grdModificarFormaEntrega.AllowUserToResizeRows = False
        Me.grdModificarFormaEntrega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdModificarFormaEntrega.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grdModificarFormaEntrega.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdModificarFormaEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdModificarFormaEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdModificarFormaEntrega.Location = New System.Drawing.Point(59, 177)
        Me.grdModificarFormaEntrega.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdModificarFormaEntrega.Name = "grdModificarFormaEntrega"
        Me.grdModificarFormaEntrega.ReadOnly = True
        Me.grdModificarFormaEntrega.RowHeadersVisible = False
        Me.grdModificarFormaEntrega.RowHeadersWidth = 51
        Me.grdModificarFormaEntrega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdModificarFormaEntrega.Size = New System.Drawing.Size(996, 272)
        Me.grdModificarFormaEntrega.TabIndex = 55
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
        Me.txtId.Location = New System.Drawing.Point(319, 44)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.ShortcutsEnabled = False
        Me.txtId.Size = New System.Drawing.Size(83, 24)
        Me.txtId.TabIndex = 1
        '
        'lblNumeroFormaEntrega
        '
        Me.lblNumeroFormaEntrega.AutoSize = True
        Me.lblNumeroFormaEntrega.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroFormaEntrega.ForeColor = System.Drawing.Color.White
        Me.lblNumeroFormaEntrega.Location = New System.Drawing.Point(97, 46)
        Me.lblNumeroFormaEntrega.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroFormaEntrega.Name = "lblNumeroFormaEntrega"
        Me.lblNumeroFormaEntrega.Size = New System.Drawing.Size(202, 22)
        Me.lblNumeroFormaEntrega.TabIndex = 53
        Me.lblNumeroFormaEntrega.Text = "N° Forma de Entrega"
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
        'frmModificarFormaEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1161, 487)
        Me.Controls.Add(Me.txtFormaEntrega)
        Me.Controls.Add(Me.lblFormaEntrega)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.grdModificarFormaEntrega)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblNumeroFormaEntrega)
        Me.Controls.Add(Me.btnModificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmModificarFormaEntrega"
        Me.Text = "frmModificarFormaEntrega"
        CType(Me.grdModificarFormaEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFormaEntrega As TextBox
    Friend WithEvents lblFormaEntrega As Label
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents grdModificarFormaEntrega As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblNumeroFormaEntrega As Label
    Friend WithEvents btnModificar As Button
End Class
