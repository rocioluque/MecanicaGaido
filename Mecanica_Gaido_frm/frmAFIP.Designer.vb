<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAFIP
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
        Me.BtnValidarCUIT = New System.Windows.Forms.Button()
        Me.TxtCUIT = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.CboProvincias = New System.Windows.Forms.ComboBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.CboCategoriasIVA = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCiudades = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnValidarCUIT
        '
        Me.BtnValidarCUIT.Location = New System.Drawing.Point(565, 66)
        Me.BtnValidarCUIT.Name = "BtnValidarCUIT"
        Me.BtnValidarCUIT.Size = New System.Drawing.Size(111, 23)
        Me.BtnValidarCUIT.TabIndex = 0
        Me.BtnValidarCUIT.Text = "Buscar Datos"
        Me.BtnValidarCUIT.UseVisualStyleBackColor = True
        '
        'TxtCUIT
        '
        Me.TxtCUIT.Location = New System.Drawing.Point(163, 66)
        Me.TxtCUIT.Name = "TxtCUIT"
        Me.TxtCUIT.Size = New System.Drawing.Size(142, 20)
        Me.TxtCUIT.TabIndex = 1
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(163, 164)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(299, 20)
        Me.TxtRazonSocial.TabIndex = 2
        '
        'CboProvincias
        '
        Me.CboProvincias.FormattingEnabled = True
        Me.CboProvincias.Location = New System.Drawing.Point(163, 190)
        Me.CboProvincias.Name = "CboProvincias"
        Me.CboProvincias.Size = New System.Drawing.Size(299, 21)
        Me.CboProvincias.TabIndex = 3
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Location = New System.Drawing.Point(163, 252)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(570, 20)
        Me.TxtDomicilio.TabIndex = 4
        '
        'CboCategoriasIVA
        '
        Me.CboCategoriasIVA.FormattingEnabled = True
        Me.CboCategoriasIVA.Location = New System.Drawing.Point(163, 319)
        Me.CboCategoriasIVA.Name = "CboCategoriasIVA"
        Me.CboCategoriasIVA.Size = New System.Drawing.Size(247, 21)
        Me.CboCategoriasIVA.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CUIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre o Razon Social"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Provincia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Calle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Condicion IVA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(111, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Ciudad"
        '
        'cboCiudades
        '
        Me.cboCiudades.FormattingEnabled = True
        Me.cboCiudades.Location = New System.Drawing.Point(163, 217)
        Me.cboCiudades.Name = "cboCiudades"
        Me.cboCiudades.Size = New System.Drawing.Size(299, 21)
        Me.cboCiudades.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(111, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nro"
        '
        'txtNro
        '
        Me.txtNro.Location = New System.Drawing.Point(163, 278)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(121, 20)
        Me.txtNro.TabIndex = 13
        '
        'frmAFIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNro)
        Me.Controls.Add(Me.cboCiudades)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboCategoriasIVA)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.CboProvincias)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Controls.Add(Me.TxtCUIT)
        Me.Controls.Add(Me.BtnValidarCUIT)
        Me.Name = "frmAFIP"
        Me.Text = "frmAFIP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnValidarCUIT As Button
    Friend WithEvents TxtCUIT As TextBox
    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents CboProvincias As ComboBox
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents CboCategoriasIVA As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboCiudades As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNro As TextBox
End Class
