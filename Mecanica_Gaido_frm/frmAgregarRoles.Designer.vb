<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarRoles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarRoles))
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Location = New System.Drawing.Point(497, 1)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(25, 22)
        Me.btnCerrar.TabIndex = 30
        Me.btnCerrar.TabStop = False
        '
        'txtRol
        '
        Me.txtRol.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRol.Location = New System.Drawing.Point(60, 101)
        Me.txtRol.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(303, 24)
        Me.txtRol.TabIndex = 1
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ForeColor = System.Drawing.Color.White
        Me.lblRol.Location = New System.Drawing.Point(55, 58)
        Me.lblRol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(149, 22)
        Me.lblRol.TabIndex = 29
        Me.lblRol.Text = "Nombre del Rol"
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(399, 215)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(109, 36)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmAgregarRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(524, 266)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtRol)
        Me.Controls.Add(Me.lblRol)
        Me.Controls.Add(Me.btnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAgregarRoles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarRoles"
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents txtRol As TextBox
    Friend WithEvents lblRol As Label
    Friend WithEvents btnAgregar As Button
End Class
