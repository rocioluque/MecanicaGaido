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
        Me.txtCUIT = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtIVACondicion = New System.Windows.Forms.TextBox()
        Me.txtVarios1 = New System.Windows.Forms.TextBox()
        Me.txtVarios2 = New System.Windows.Forms.TextBox()
        Me.btnConsultarAPI = New System.Windows.Forms.Button()
        Me.btnCargarDatos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCUIT
        '
        Me.txtCUIT.Location = New System.Drawing.Point(340, 41)
        Me.txtCUIT.Name = "txtCUIT"
        Me.txtCUIT.Size = New System.Drawing.Size(137, 20)
        Me.txtCUIT.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(340, 126)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(362, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(340, 152)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(362, 20)
        Me.txtDireccion.TabIndex = 2
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(340, 178)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(362, 20)
        Me.txtNumero.TabIndex = 3
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(340, 204)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(362, 20)
        Me.txtFecha.TabIndex = 4
        '
        'txtIVACondicion
        '
        Me.txtIVACondicion.Location = New System.Drawing.Point(340, 230)
        Me.txtIVACondicion.Name = "txtIVACondicion"
        Me.txtIVACondicion.Size = New System.Drawing.Size(362, 20)
        Me.txtIVACondicion.TabIndex = 5
        '
        'txtVarios1
        '
        Me.txtVarios1.Location = New System.Drawing.Point(340, 255)
        Me.txtVarios1.Name = "txtVarios1"
        Me.txtVarios1.Size = New System.Drawing.Size(362, 20)
        Me.txtVarios1.TabIndex = 6
        '
        'txtVarios2
        '
        Me.txtVarios2.Location = New System.Drawing.Point(340, 281)
        Me.txtVarios2.Name = "txtVarios2"
        Me.txtVarios2.Size = New System.Drawing.Size(362, 20)
        Me.txtVarios2.TabIndex = 7
        '
        'btnConsultarAPI
        '
        Me.btnConsultarAPI.Location = New System.Drawing.Point(340, 318)
        Me.btnConsultarAPI.Name = "btnConsultarAPI"
        Me.btnConsultarAPI.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultarAPI.TabIndex = 8
        Me.btnConsultarAPI.Text = "Consultar"
        Me.btnConsultarAPI.UseVisualStyleBackColor = True
        '
        'btnCargarDatos
        '
        Me.btnCargarDatos.Location = New System.Drawing.Point(592, 318)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(110, 23)
        Me.btnCargarDatos.TabIndex = 9
        Me.btnCargarDatos.Text = "Cargar Datos"
        Me.btnCargarDatos.UseVisualStyleBackColor = True
        '
        'frmAFIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCargarDatos)
        Me.Controls.Add(Me.btnConsultarAPI)
        Me.Controls.Add(Me.txtVarios2)
        Me.Controls.Add(Me.txtVarios1)
        Me.Controls.Add(Me.txtIVACondicion)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCUIT)
        Me.Name = "frmAFIP"
        Me.Text = "frmAFIP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCUIT As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtIVACondicion As TextBox
    Friend WithEvents txtVarios1 As TextBox
    Friend WithEvents txtVarios2 As TextBox
    Friend WithEvents btnConsultarAPI As Button
    Friend WithEvents btnCargarDatos As Button


End Class
