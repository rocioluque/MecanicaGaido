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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.horaFecha = New System.Windows.Forms.Timer(Me.components)
        Me.chtRepuestos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.grdGrilla2 = New System.Windows.Forms.DataGridView()
        Me.grdGrilla1 = New System.Windows.Forms.DataGridView()
        Me.btnExportarPDF = New System.Windows.Forms.Button()
        Me.PanelClima = New System.Windows.Forms.Panel()
        Me.lblViento = New System.Windows.Forms.Label()
        Me.lblVisibilidad = New System.Windows.Forms.Label()
        Me.lblHumedad = New System.Windows.Forms.Label()
        Me.lblSensacionTermica = New System.Windows.Forms.Label()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblTemperatura = New System.Windows.Forms.Label()
        CType(Me.chtRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrilla2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelClima.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.lblFecha.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblFecha.Location = New System.Drawing.Point(12, 58)
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
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(7, 9)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(114, 49)
        Me.lblHora.TabIndex = 109
        Me.lblHora.Text = "Hora"
        '
        'horaFecha
        '
        Me.horaFecha.Enabled = True
        '
        'chtRepuestos
        '
        Me.chtRepuestos.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.chtRepuestos.ChartAreas.Add(ChartArea1)
        Me.chtRepuestos.Cursor = System.Windows.Forms.Cursors.Hand
        Legend1.Name = "Legend1"
        Me.chtRepuestos.Legends.Add(Legend1)
        Me.chtRepuestos.Location = New System.Drawing.Point(677, 32)
        Me.chtRepuestos.Name = "chtRepuestos"
        Me.chtRepuestos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtRepuestos.Series.Add(Series1)
        Me.chtRepuestos.Size = New System.Drawing.Size(427, 327)
        Me.chtRepuestos.TabIndex = 114
        Title1.BackColor = System.Drawing.Color.Transparent
        Title1.DockedToChartArea = "ChartArea1"
        Title1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.ForeColor = System.Drawing.Color.White
        Title1.Name = "TittleEstadoRepuestos"
        Title1.ShadowColor = System.Drawing.Color.Transparent
        Title1.Text = "Estado de Repuestos"
        Me.chtRepuestos.Titles.Add(Title1)
        '
        'grdGrilla2
        '
        Me.grdGrilla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdGrilla2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdGrilla2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdGrilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGrilla2.Location = New System.Drawing.Point(834, 444)
        Me.grdGrilla2.Name = "grdGrilla2"
        Me.grdGrilla2.Size = New System.Drawing.Size(268, 150)
        Me.grdGrilla2.TabIndex = 116
        '
        'grdGrilla1
        '
        Me.grdGrilla1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdGrilla1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.grdGrilla1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdGrilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGrilla1.Location = New System.Drawing.Point(540, 444)
        Me.grdGrilla1.Name = "grdGrilla1"
        Me.grdGrilla1.Size = New System.Drawing.Size(268, 150)
        Me.grdGrilla1.TabIndex = 115
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
        Me.btnExportarPDF.ForeColor = System.Drawing.Color.White
        Me.btnExportarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarPDF.Location = New System.Drawing.Point(957, 102)
        Me.btnExportarPDF.Name = "btnExportarPDF"
        Me.btnExportarPDF.Size = New System.Drawing.Size(134, 33)
        Me.btnExportarPDF.TabIndex = 117
        Me.btnExportarPDF.Text = "Realizar pedido"
        Me.btnExportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarPDF.UseVisualStyleBackColor = False
        '
        'PanelClima
        '
        Me.PanelClima.Controls.Add(Me.lblViento)
        Me.PanelClima.Controls.Add(Me.lblVisibilidad)
        Me.PanelClima.Controls.Add(Me.lblHumedad)
        Me.PanelClima.Controls.Add(Me.lblSensacionTermica)
        Me.PanelClima.Controls.Add(Me.lblUbicacion)
        Me.PanelClima.Controls.Add(Me.lblDescripcion)
        Me.PanelClima.Controls.Add(Me.lblTemperatura)
        Me.PanelClima.Location = New System.Drawing.Point(12, 84)
        Me.PanelClima.Name = "PanelClima"
        Me.PanelClima.Size = New System.Drawing.Size(238, 236)
        Me.PanelClima.TabIndex = 118
        '
        'lblViento
        '
        Me.lblViento.AutoSize = True
        Me.lblViento.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblViento.Location = New System.Drawing.Point(8, 206)
        Me.lblViento.Name = "lblViento"
        Me.lblViento.Size = New System.Drawing.Size(49, 17)
        Me.lblViento.TabIndex = 127
        Me.lblViento.Text = "viento"
        '
        'lblVisibilidad
        '
        Me.lblVisibilidad.AutoSize = True
        Me.lblVisibilidad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisibilidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblVisibilidad.Location = New System.Drawing.Point(8, 171)
        Me.lblVisibilidad.Name = "lblVisibilidad"
        Me.lblVisibilidad.Size = New System.Drawing.Size(72, 17)
        Me.lblVisibilidad.TabIndex = 126
        Me.lblVisibilidad.Text = "visibilidad"
        '
        'lblHumedad
        '
        Me.lblHumedad.AutoSize = True
        Me.lblHumedad.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumedad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHumedad.Location = New System.Drawing.Point(8, 140)
        Me.lblHumedad.Name = "lblHumedad"
        Me.lblHumedad.Size = New System.Drawing.Size(72, 17)
        Me.lblHumedad.TabIndex = 125
        Me.lblHumedad.Text = "humedad"
        '
        'lblSensacionTermica
        '
        Me.lblSensacionTermica.AutoSize = True
        Me.lblSensacionTermica.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSensacionTermica.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSensacionTermica.Location = New System.Drawing.Point(8, 81)
        Me.lblSensacionTermica.Name = "lblSensacionTermica"
        Me.lblSensacionTermica.Size = New System.Drawing.Size(88, 17)
        Me.lblSensacionTermica.TabIndex = 122
        Me.lblSensacionTermica.Text = "sens termica"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUbicacion.Location = New System.Drawing.Point(7, 17)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(89, 19)
        Me.lblUbicacion.TabIndex = 119
        Me.lblUbicacion.Text = "ubicacion"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDescripcion.Location = New System.Drawing.Point(8, 109)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(82, 17)
        Me.lblDescripcion.TabIndex = 121
        Me.lblDescripcion.Text = "descripcion"
        '
        'lblTemperatura
        '
        Me.lblTemperatura.AutoSize = True
        Me.lblTemperatura.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperatura.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblTemperatura.Location = New System.Drawing.Point(6, 45)
        Me.lblTemperatura.Name = "lblTemperatura"
        Me.lblTemperatura.Size = New System.Drawing.Size(140, 24)
        Me.lblTemperatura.TabIndex = 120
        Me.lblTemperatura.Text = "temperatura"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1147, 606)
        Me.Controls.Add(Me.PanelClima)
        Me.Controls.Add(Me.btnExportarPDF)
        Me.Controls.Add(Me.grdGrilla2)
        Me.Controls.Add(Me.grdGrilla1)
        Me.Controls.Add(Me.chtRepuestos)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHora)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "frmInicio"
        CType(Me.chtRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrilla2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelClima.ResumeLayout(False)
        Me.PanelClima.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents horaFecha As Timer
    Friend WithEvents chtRepuestos As DataVisualization.Charting.Chart
    Friend WithEvents grdGrilla2 As DataGridView
    Friend WithEvents grdGrilla1 As DataGridView
    Friend WithEvents btnExportarPDF As Button
    Friend WithEvents PanelClima As Panel
    Friend WithEvents lblSensacionTermica As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblTemperatura As Label
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblHumedad As Label
    Friend WithEvents lblViento As Label
    Friend WithEvents lblVisibilidad As Label
End Class
