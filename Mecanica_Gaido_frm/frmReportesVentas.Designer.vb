<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportesVentas
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim CustomLabel1 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel2 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel3 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel4 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel5 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel6 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel7 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim CustomLabel8 As System.Windows.Forms.DataVisualization.Charting.CustomLabel = New System.Windows.Forms.DataVisualization.Charting.CustomLabel()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportesVentas))
        Me.lblNoInformacion = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chartVentasMes = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChtVentasEmpleado = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chartVentasMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChtVentasEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNoInformacion
        '
        Me.lblNoInformacion.AutoSize = True
        Me.lblNoInformacion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoInformacion.ForeColor = System.Drawing.Color.White
        Me.lblNoInformacion.Location = New System.Drawing.Point(55, 57)
        Me.lblNoInformacion.Name = "lblNoInformacion"
        Me.lblNoInformacion.Size = New System.Drawing.Size(0, 21)
        Me.lblNoInformacion.TabIndex = 83
        Me.lblNoInformacion.Visible = False
        '
        'txtAño
        '
        Me.txtAño.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.txtAño.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAño.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAño.ForeColor = System.Drawing.Color.White
        Me.txtAño.Location = New System.Drawing.Point(121, 25)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(73, 16)
        Me.txtAño.TabIndex = 81
        Me.txtAño.Text = "2024"
        Me.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Año"
        '
        'chartVentasMes
        '
        Me.chartVentasMes.BackColor = System.Drawing.Color.Transparent
        CustomLabel1.ForeColor = System.Drawing.Color.White
        CustomLabel1.Text = "Enero"
        CustomLabel2.Text = "Febrero"
        CustomLabel3.Text = "Marzo"
        CustomLabel4.Text = "Abril"
        CustomLabel5.Text = "Mayo"
        CustomLabel6.Text = "Junio"
        CustomLabel7.Text = "Julio"
        ChartArea1.AxisX.CustomLabels.Add(CustomLabel1)
        ChartArea1.AxisX.CustomLabels.Add(CustomLabel2)
        ChartArea1.AxisX.CustomLabels.Add(CustomLabel3)
        ChartArea1.AxisX.CustomLabels.Add(CustomLabel4)
        ChartArea1.AxisX.CustomLabels.Add(CustomLabel5)
        ChartArea1.AxisX.CustomLabels.Add(CustomLabel6)
        ChartArea1.AxisX.CustomLabels.Add(CustomLabel7)
        ChartArea1.AxisX.CustomLabels.Add(CustomLabel8)
        ChartArea1.AxisX.InterlacedColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisX.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.Maximum = 12.0R
        ChartArea1.AxisX.Minimum = 1.0R
        ChartArea1.AxisX.Title = "Mes"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.InterlacedColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.Title = "Cant. de Ventas"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Century Gothic", 9.0!)
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea1.BorderColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.chartVentasMes.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Leyenda"
        Me.chartVentasMes.Legends.Add(Legend1)
        Me.chartVentasMes.Location = New System.Drawing.Point(31, 40)
        Me.chartVentasMes.Name = "chartVentasMes"
        Me.chartVentasMes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.BorderWidth = 3
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.SeaGreen
        Series1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Leyenda"
        Series1.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Series1.MarkerSize = 8
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Cantidad de Ventas"
        Me.chartVentasMes.Series.Add(Series1)
        Me.chartVentasMes.Size = New System.Drawing.Size(584, 327)
        Me.chartVentasMes.TabIndex = 80
        Me.chartVentasMes.Text = "Chart1"
        '
        'ChtVentasEmpleado
        '
        Me.ChtVentasEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.ChtVentasEmpleado.BackSecondaryColor = System.Drawing.Color.White
        ChartArea2.Area3DStyle.Inclination = 10
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea2.AxisX2.TitleFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisX2.TitleForeColor = System.Drawing.Color.White
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea2.AxisY2.TitleFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY2.TitleForeColor = System.Drawing.Color.White
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.BorderColor = System.Drawing.Color.SeaGreen
        ChartArea2.CursorX.LineColor = System.Drawing.Color.White
        ChartArea2.CursorX.SelectionColor = System.Drawing.Color.WhiteSmoke
        ChartArea2.CursorY.LineColor = System.Drawing.Color.White
        ChartArea2.CursorY.SelectionColor = System.Drawing.Color.WhiteSmoke
        ChartArea2.Name = "ChartArea1"
        Me.ChtVentasEmpleado.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Leyenda"
        Me.ChtVentasEmpleado.Legends.Add(Legend2)
        Me.ChtVentasEmpleado.Location = New System.Drawing.Point(31, 388)
        Me.ChtVentasEmpleado.Name = "ChtVentasEmpleado"
        Me.ChtVentasEmpleado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Leyenda"
        Series2.Name = "Series1"
        Me.ChtVentasEmpleado.Series.Add(Series2)
        Me.ChtVentasEmpleado.Size = New System.Drawing.Size(584, 323)
        Me.ChtVentasEmpleado.TabIndex = 142
        '
        'frmReportesVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1315, 752)
        Me.Controls.Add(Me.ChtVentasEmpleado)
        Me.Controls.Add(Me.lblNoInformacion)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chartVentasMes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportesVentas"
        Me.Text = "frmReportesVentas"
        CType(Me.chartVentasMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChtVentasEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNoInformacion As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chartVentasMes As DataVisualization.Charting.Chart
    Friend WithEvents ChtVentasEmpleado As DataVisualization.Charting.Chart
End Class
