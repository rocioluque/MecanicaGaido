<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.horaFecha = New System.Windows.Forms.Timer(Me.components)
        Me.btnExportarPDF = New System.Windows.Forms.Button()
        Me.lblViento = New System.Windows.Forms.Label()
        Me.lblVisibilidad = New System.Windows.Forms.Label()
        Me.lblHumedad = New System.Windows.Forms.Label()
        Me.lblSensacionTermica = New System.Windows.Forms.Label()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblTemperatura = New System.Windows.Forms.Label()
        Me.PictureBoxHumedad = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblDolar = New System.Windows.Forms.Label()
        Me.ChtOrdenReparacion = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chtRepuestos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.PictureBoxHumedad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChtOrdenReparacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.lblFecha.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblFecha.Location = New System.Drawing.Point(25, 73)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(72, 23)
        Me.lblFecha.TabIndex = 110
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblHora.Font = New System.Drawing.Font("Century Gothic", 30.0!)
        Me.lblHora.ForeColor = System.Drawing.Color.Black
        Me.lblHora.Location = New System.Drawing.Point(20, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(114, 49)
        Me.lblHora.TabIndex = 109
        Me.lblHora.Text = "Hora"
        '
        'horaFecha
        '
        Me.horaFecha.Enabled = True
        '
        'btnExportarPDF
        '
        Me.btnExportarPDF.AutoSize = True
        Me.btnExportarPDF.BackColor = System.Drawing.Color.Transparent
        Me.btnExportarPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExportarPDF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportarPDF.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnExportarPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnExportarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportarPDF.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.btnExportarPDF.ForeColor = System.Drawing.Color.Black
        Me.btnExportarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarPDF.Location = New System.Drawing.Point(1004, 23)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Size = New System.Drawing.Size(134, 33)
        Me.btnExportarPDF.TabIndex = 117
        Me.btnExportarPDF.Text = "Realizar pedido"
        Me.btnExportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarPDF.UseVisualStyleBackColor = False
        '
        'lblViento
        '
        Me.lblViento.AutoSize = True
        Me.lblViento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViento.ForeColor = System.Drawing.Color.Black
        Me.lblViento.Location = New System.Drawing.Point(245, 223)
        Me.lblViento.Name = "lblViento"
        Me.lblViento.Size = New System.Drawing.Size(19, 17)
        Me.lblViento.TabIndex = 134
        Me.lblViento.Text = "vi"
        '
        'lblVisibilidad
        '
        Me.lblVisibilidad.AutoSize = True
        Me.lblVisibilidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisibilidad.ForeColor = System.Drawing.Color.Black
        Me.lblVisibilidad.Location = New System.Drawing.Point(150, 223)
        Me.lblVisibilidad.Name = "lblVisibilidad"
        Me.lblVisibilidad.Size = New System.Drawing.Size(16, 17)
        Me.lblVisibilidad.TabIndex = 133
        Me.lblVisibilidad.Text = "v"
        '
        'lblHumedad
        '
        Me.lblHumedad.AutoSize = True
        Me.lblHumedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumedad.ForeColor = System.Drawing.Color.Black
        Me.lblHumedad.Location = New System.Drawing.Point(58, 223)
        Me.lblHumedad.Name = "lblHumedad"
        Me.lblHumedad.Size = New System.Drawing.Size(24, 17)
        Me.lblHumedad.TabIndex = 132
        Me.lblHumedad.Text = "hu"
        '
        'lblSensacionTermica
        '
        Me.lblSensacionTermica.AutoSize = True
        Me.lblSensacionTermica.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSensacionTermica.ForeColor = System.Drawing.Color.Black
        Me.lblSensacionTermica.Location = New System.Drawing.Point(118, 184)
        Me.lblSensacionTermica.Name = "lblSensacionTermica"
        Me.lblSensacionTermica.Size = New System.Drawing.Size(19, 17)
        Me.lblSensacionTermica.TabIndex = 131
        Me.lblSensacionTermica.Text = "ST"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacion.ForeColor = System.Drawing.Color.Black
        Me.lblUbicacion.Location = New System.Drawing.Point(25, 111)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(89, 19)
        Me.lblUbicacion.TabIndex = 128
        Me.lblUbicacion.Text = "ubicacion"
        '
        'lblTemperatura
        '
        Me.lblTemperatura.AutoSize = True
        Me.lblTemperatura.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperatura.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblTemperatura.Location = New System.Drawing.Point(25, 177)
        Me.lblTemperatura.Name = "lblTemperatura"
        Me.lblTemperatura.Size = New System.Drawing.Size(18, 24)
        Me.lblTemperatura.TabIndex = 129
        Me.lblTemperatura.Text = "T"
        '
        'PictureBoxHumedad
        '
        Me.PictureBoxHumedad.Image = CType(resources.GetObject("PictureBoxHumedad.Image"), System.Drawing.Image)
        Me.PictureBoxHumedad.InitialImage = Nothing
        Me.PictureBoxHumedad.Location = New System.Drawing.Point(29, 216)
        Me.PictureBoxHumedad.Name = "PictureBoxHumedad"
        Me.PictureBoxHumedad.Size = New System.Drawing.Size(26, 25)
        Me.PictureBoxHumedad.TabIndex = 135
        Me.PictureBoxHumedad.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(121, 217)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox2.TabIndex = 136
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(216, 217)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox3.TabIndex = 137
        Me.PictureBox3.TabStop = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcion.Location = New System.Drawing.Point(26, 145)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(82, 17)
        Me.lblDescripcion.TabIndex = 138
        Me.lblDescripcion.Text = "descripcion"
        '
        'lblDolar
        '
        Me.lblDolar.AutoSize = True
        Me.lblDolar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDolar.ForeColor = System.Drawing.Color.Black
        Me.lblDolar.Location = New System.Drawing.Point(25, 255)
        Me.lblDolar.Name = "lblDolar"
        Me.lblDolar.Size = New System.Drawing.Size(50, 19)
        Me.lblDolar.TabIndex = 139
        Me.lblDolar.Text = "dolar"
        '
        'ChtOrdenReparacion
        '
        Me.ChtOrdenReparacion.BackColor = System.Drawing.Color.Transparent
        Me.ChtOrdenReparacion.BackSecondaryColor = System.Drawing.Color.White
        ChartArea1.Area3DStyle.Inclination = 10
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisX2.TitleFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY2.TitleFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.SeaGreen
        ChartArea1.CursorX.LineColor = System.Drawing.Color.White
        ChartArea1.CursorX.SelectionColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.CursorY.LineColor = System.Drawing.Color.White
        ChartArea1.CursorY.SelectionColor = System.Drawing.Color.WhiteSmoke
        ChartArea1.Name = "ChartArea1"
        Me.ChtOrdenReparacion.ChartAreas.Add(ChartArea1)
        Me.ChtOrdenReparacion.Location = New System.Drawing.Point(29, 336)
        Me.ChtOrdenReparacion.Name = "ChtOrdenReparacion"
        Me.ChtOrdenReparacion.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.Name = "Series1"
        Me.ChtOrdenReparacion.Series.Add(Series1)
        Me.ChtOrdenReparacion.Size = New System.Drawing.Size(300, 392)
        Me.ChtOrdenReparacion.TabIndex = 140
        '
        'chtRepuestos
        '
        Me.chtRepuestos.BackColor = System.Drawing.Color.Transparent
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.chtRepuestos.ChartAreas.Add(ChartArea2)
        Me.chtRepuestos.Cursor = System.Windows.Forms.Cursors.Hand
        Legend1.Name = "Leyenda"
        Me.chtRepuestos.Legends.Add(Legend1)
        Me.chtRepuestos.Location = New System.Drawing.Point(692, 6)
        Me.chtRepuestos.Name = "chtRepuestos"
        Me.chtRepuestos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Leyenda"
        Series2.Name = "Stock de Repuestos"
        Me.chtRepuestos.Series.Add(Series2)
        Me.chtRepuestos.Size = New System.Drawing.Size(427, 327)
        Me.chtRepuestos.TabIndex = 114
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1147, 702)
        Me.Controls.Add(Me.ChtOrdenReparacion)
        Me.Controls.Add(Me.lblDolar)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBoxHumedad)
        Me.Controls.Add(Me.lblViento)
        Me.Controls.Add(Me.lblVisibilidad)
        Me.Controls.Add(Me.lblHumedad)
        Me.Controls.Add(Me.lblSensacionTermica)
        Me.Controls.Add(Me.lblUbicacion)
        Me.Controls.Add(Me.lblTemperatura)
        Me.Controls.Add(Me.btnExportarPDF)
        Me.Controls.Add(Me.chtRepuestos)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHora)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "frmInicio"
        CType(Me.PictureBoxHumedad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChtOrdenReparacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents horaFecha As Timer
    Friend WithEvents btnExportarPDF As Button
    Friend WithEvents lblViento As Label
    Friend WithEvents lblVisibilidad As Label
    Friend WithEvents lblHumedad As Label
    Friend WithEvents lblSensacionTermica As Label
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblTemperatura As Label
    Friend WithEvents PictureBoxHumedad As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblDolar As Label
    Friend WithEvents ChtOrdenReparacion As DataVisualization.Charting.Chart
    Friend WithEvents chtRepuestos As DataVisualization.Charting.Chart
End Class
