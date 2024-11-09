<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportesPersonas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportesPersonas))
        Me.lblDisponible = New System.Windows.Forms.Label()
        Me.btnObtenerHistorial = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPersona = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaMin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaMax = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lblDisponible
        '
        Me.lblDisponible.AutoSize = True
        Me.lblDisponible.Location = New System.Drawing.Point(13, 337)
        Me.lblDisponible.Name = "lblDisponible"
        Me.lblDisponible.Size = New System.Drawing.Size(0, 13)
        Me.lblDisponible.TabIndex = 3
        '
        'btnObtenerHistorial
        '
        Me.btnObtenerHistorial.BackColor = System.Drawing.Color.Transparent
        Me.btnObtenerHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnObtenerHistorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnObtenerHistorial.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnObtenerHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnObtenerHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnObtenerHistorial.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObtenerHistorial.ForeColor = System.Drawing.Color.White
        Me.btnObtenerHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnObtenerHistorial.Location = New System.Drawing.Point(359, 68)
        Me.btnObtenerHistorial.Name = "btnObtenerHistorial"
        Me.btnObtenerHistorial.Size = New System.Drawing.Size(125, 35)
        Me.btnObtenerHistorial.TabIndex = 128
        Me.btnObtenerHistorial.Text = "Obtener Historial"
        Me.btnObtenerHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnObtenerHistorial.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Cliente"
        '
        'cboPersona
        '
        Me.cboPersona.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPersona.FormattingEnabled = True
        Me.cboPersona.Location = New System.Drawing.Point(130, 75)
        Me.cboPersona.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPersona.Name = "cboPersona"
        Me.cboPersona.Size = New System.Drawing.Size(169, 25)
        Me.cboPersona.TabIndex = 126
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 18)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "HISTORIAL DE REPARACIONES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(284, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(28, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Desde"
        '
        'dtpFechaMin
        '
        Me.dtpFechaMin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMin.Location = New System.Drawing.Point(130, 132)
        Me.dtpFechaMin.Name = "dtpFechaMin"
        Me.dtpFechaMin.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaMin.TabIndex = 132
        Me.dtpFechaMin.Value = New Date(2024, 11, 9, 0, 0, 0, 0)
        '
        'dtpFechaMax
        '
        Me.dtpFechaMax.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMax.Location = New System.Drawing.Point(384, 131)
        Me.dtpFechaMax.Name = "dtpFechaMax"
        Me.dtpFechaMax.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaMax.TabIndex = 133
        Me.dtpFechaMax.Value = New Date(2024, 11, 9, 0, 0, 0, 0)
        '
        'frmReportesPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1004, 575)
        Me.Controls.Add(Me.dtpFechaMax)
        Me.Controls.Add(Me.dtpFechaMin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnObtenerHistorial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPersona)
        Me.Controls.Add(Me.lblDisponible)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportesPersonas"
        Me.Text = "frmReportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDisponible As Label
    Friend WithEvents btnObtenerHistorial As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboPersona As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaMin As DateTimePicker
    Friend WithEvents dtpFechaMax As DateTimePicker
End Class
