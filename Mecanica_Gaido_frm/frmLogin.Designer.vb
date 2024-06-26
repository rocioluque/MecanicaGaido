<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.linkContraseña = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkRecordarme = New System.Windows.Forms.CheckBox()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelLogin.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogo.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLogin
        '
        Me.PanelLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelLogin.Controls.Add(Me.linkContraseña)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Controls.Add(Me.PictureBox2)
        Me.PanelLogin.Controls.Add(Me.txtContraseña)
        Me.PanelLogin.Controls.Add(Me.PictureBox1)
        Me.PanelLogin.Controls.Add(Me.chkRecordarme)
        Me.PanelLogin.Controls.Add(Me.btnAcceder)
        Me.PanelLogin.Controls.Add(Me.txtUsuario)
        Me.PanelLogin.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLogin.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(320, 350)
        Me.PanelLogin.TabIndex = 0
        '
        'linkContraseña
        '
        Me.linkContraseña.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.linkContraseña.AutoSize = True
        Me.linkContraseña.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkContraseña.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkContraseña.LinkColor = System.Drawing.Color.DimGray
        Me.linkContraseña.Location = New System.Drawing.Point(70, 283)
        Me.linkContraseña.Name = "linkContraseña"
        Me.linkContraseña.Size = New System.Drawing.Size(178, 17)
        Me.linkContraseña.TabIndex = 0
        Me.linkContraseña.TabStop = True
        Me.linkContraseña.Text = "¿Olvidaste la contraseña?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label1.Location = New System.Drawing.Point(110, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 33)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "LOGIN"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Location = New System.Drawing.Point(22, 172)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(272, 2)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.DimGray
        Me.txtContraseña.Location = New System.Drawing.Point(22, 150)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(272, 19)
        Me.txtContraseña.TabIndex = 2
        Me.txtContraseña.Text = "CONTRASEÑA"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(22, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 2)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'chkRecordarme
        '
        Me.chkRecordarme.AutoSize = True
        Me.chkRecordarme.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecordarme.ForeColor = System.Drawing.Color.DimGray
        Me.chkRecordarme.Location = New System.Drawing.Point(116, 180)
        Me.chkRecordarme.Name = "chkRecordarme"
        Me.chkRecordarme.Size = New System.Drawing.Size(94, 20)
        Me.chkRecordarme.TabIndex = 9
        Me.chkRecordarme.Text = "Recordarme"
        Me.chkRecordarme.UseVisualStyleBackColor = True
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAcceder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcceder.FlatAppearance.BorderSize = 0
        Me.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcceder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceder.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAcceder.Location = New System.Drawing.Point(22, 230)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(272, 40)
        Me.btnAcceder.TabIndex = 3
        Me.btnAcceder.Text = "Acceder"
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsuario.Location = New System.Drawing.Point(22, 96)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(272, 19)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.Text = "USUARIO"
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.PanelLogo.BackgroundImage = CType(resources.GetObject("PanelLogo.BackgroundImage"), System.Drawing.Image)
        Me.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelLogo.Controls.Add(Me.btnMinimizar)
        Me.PanelLogo.Controls.Add(Me.btnCerrar)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelLogo.Location = New System.Drawing.Point(320, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(380, 350)
        Me.PanelLogo.TabIndex = 1
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimizar.Location = New System.Drawing.Point(341, 3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(15, 15)
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Location = New System.Drawing.Point(362, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(15, 15)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 350)
        Me.Controls.Add(Me.PanelLogo)
        Me.Controls.Add(Me.PanelLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLogin As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnAcceder As Button
    Friend WithEvents chkRecordarme As CheckBox
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents linkContraseña As LinkLabel
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
End Class
