<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgregarFormaEntrega
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarFormaEntrega))
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.txtFormaEntrega = New System.Windows.Forms.TextBox()
        Me.lblFormaEntrega = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
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
        Me.btnCerrar.TabIndex = 26
        Me.btnCerrar.TabStop = False
        '
        'txtFormaEntrega
        '
        Me.txtFormaEntrega.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormaEntrega.Location = New System.Drawing.Point(44, 83)
        Me.txtFormaEntrega.Name = "txtFormaEntrega"
        Me.txtFormaEntrega.Size = New System.Drawing.Size(228, 21)
        Me.txtFormaEntrega.TabIndex = 1
        '
        'lblFormaEntrega
        '
        Me.lblFormaEntrega.AutoSize = True
        Me.lblFormaEntrega.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaEntrega.ForeColor = System.Drawing.Color.White
        Me.lblFormaEntrega.Location = New System.Drawing.Point(40, 48)
        Me.lblFormaEntrega.Name = "lblFormaEntrega"
        Me.lblFormaEntrega.Size = New System.Drawing.Size(139, 20)
        Me.lblFormaEntrega.TabIndex = 24
        Me.lblFormaEntrega.Text = "Forma de Entrega"
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(299, 175)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(82, 29)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'frmAgregarFormaEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(393, 216)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtFormaEntrega)
        Me.Controls.Add(Me.lblFormaEntrega)
        Me.Controls.Add(Me.btnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgregarFormaEntrega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarFormaEntrega"
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents txtFormaEntrega As TextBox
    Friend WithEvents lblFormaEntrega As Label
    Friend WithEvents btnAgregar As Button
End Class
