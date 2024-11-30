<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesVehiculos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportesVehiculos))
        Me.dtpFechaMax = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaMin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnObtenerHistorial = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboVehiculo = New System.Windows.Forms.ComboBox()
        Me.cboCriterio = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCriterio = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpFechaMax
        '
        Me.dtpFechaMax.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaMax.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaMax.Location = New System.Drawing.Point(147, 234)
        Me.dtpFechaMax.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaMax.Name = "dtpFechaMax"
        Me.dtpFechaMax.Size = New System.Drawing.Size(132, 27)
        Me.dtpFechaMax.TabIndex = 141
        Me.dtpFechaMax.Value = New Date(2024, 11, 9, 0, 0, 0, 0)
        '
        'dtpFechaMin
        '
        Me.dtpFechaMin.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaMin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaMin.Location = New System.Drawing.Point(147, 170)
        Me.dtpFechaMin.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaMin.Name = "dtpFechaMin"
        Me.dtpFechaMin.Size = New System.Drawing.Size(132, 27)
        Me.dtpFechaMin.TabIndex = 140
        Me.dtpFechaMin.Value = New Date(2024, 11, 9, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(55, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 21)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(55, 234)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(55, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 23)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "HISTORIAL DE REPARACIONES"
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
        Me.btnObtenerHistorial.ForeColor = System.Drawing.Color.Black
        Me.btnObtenerHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnObtenerHistorial.Location = New System.Drawing.Point(619, 219)
        Me.btnObtenerHistorial.Margin = New System.Windows.Forms.Padding(4)
        Me.btnObtenerHistorial.Name = "btnObtenerHistorial"
        Me.btnObtenerHistorial.Size = New System.Drawing.Size(167, 43)
        Me.btnObtenerHistorial.TabIndex = 136
        Me.btnObtenerHistorial.Text = "Obtener Historial"
        Me.btnObtenerHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnObtenerHistorial.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(55, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 21)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Vehículo"
        '
        'cboVehiculo
        '
        Me.cboVehiculo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehiculo.FormattingEnabled = True
        Me.cboVehiculo.Location = New System.Drawing.Point(147, 102)
        Me.cboVehiculo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(637, 29)
        Me.cboVehiculo.TabIndex = 134
        '
        'cboCriterio
        '
        Me.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCriterio.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCriterio.FormattingEnabled = True
        Me.cboCriterio.Location = New System.Drawing.Point(147, 302)
        Me.cboCriterio.Name = "cboCriterio"
        Me.cboCriterio.Size = New System.Drawing.Size(234, 29)
        Me.cboCriterio.TabIndex = 142
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(55, 308)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 21)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Criterio"
        '
        'txtCriterio
        '
        Me.txtCriterio.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterio.Location = New System.Drawing.Point(387, 303)
        Me.txtCriterio.Name = "txtCriterio"
        Me.txtCriterio.Size = New System.Drawing.Size(219, 28)
        Me.txtCriterio.TabIndex = 144
        Me.txtCriterio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(619, 295)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(167, 43)
        Me.btnBuscar.TabIndex = 145
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'frmReportesVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1297, 663)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCriterio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCriterio)
        Me.Controls.Add(Me.dtpFechaMax)
        Me.Controls.Add(Me.dtpFechaMin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnObtenerHistorial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboVehiculo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReportesVehiculos"
        Me.Text = "frmReportesVehiculos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpFechaMax As DateTimePicker
    Friend WithEvents dtpFechaMin As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnObtenerHistorial As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboVehiculo As ComboBox
    Friend WithEvents cboCriterio As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCriterio As TextBox
    Friend WithEvents btnBuscar As Button
End Class
