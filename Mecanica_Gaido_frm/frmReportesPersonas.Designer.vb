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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportesPersonas))
        Me.chtRepuestos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdGrilla1 = New System.Windows.Forms.DataGridView()
        Me.lblDisponible = New System.Windows.Forms.Label()
        Me.grdGrilla2 = New System.Windows.Forms.DataGridView()
        CType(Me.chtRepuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrilla2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chtRepuestos
        '
        Me.chtRepuestos.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.chtRepuestos.ChartAreas.Add(ChartArea1)
        Me.chtRepuestos.Cursor = System.Windows.Forms.Cursors.Hand
        Legend1.Name = "Legend1"
        Me.chtRepuestos.Legends.Add(Legend1)
        Me.chtRepuestos.Location = New System.Drawing.Point(12, 36)
        Me.chtRepuestos.Name = "chtRepuestos"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtRepuestos.Series.Add(Series1)
        Me.chtRepuestos.Size = New System.Drawing.Size(284, 298)
        Me.chtRepuestos.TabIndex = 0
        Me.chtRepuestos.Text = "Repuestos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Stock total de Repuestos."
        '
        'grdGrilla1
        '
        Me.grdGrilla1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdGrilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGrilla1.Location = New System.Drawing.Point(28, 337)
        Me.grdGrilla1.Name = "grdGrilla1"
        Me.grdGrilla1.Size = New System.Drawing.Size(268, 150)
        Me.grdGrilla1.TabIndex = 2
        '
        'lblDisponible
        '
        Me.lblDisponible.AutoSize = True
        Me.lblDisponible.Location = New System.Drawing.Point(13, 337)
        Me.lblDisponible.Name = "lblDisponible"
        Me.lblDisponible.Size = New System.Drawing.Size(0, 13)
        Me.lblDisponible.TabIndex = 3
        '
        'grdGrilla2
        '
        Me.grdGrilla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdGrilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGrilla2.Location = New System.Drawing.Point(28, 493)
        Me.grdGrilla2.Name = "grdGrilla2"
        Me.grdGrilla2.Size = New System.Drawing.Size(268, 150)
        Me.grdGrilla2.TabIndex = 4
        '
        'frmReportesPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 685)
        Me.Controls.Add(Me.grdGrilla2)
        Me.Controls.Add(Me.lblDisponible)
        Me.Controls.Add(Me.grdGrilla1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chtRepuestos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportesPersonas"
        Me.Text = "frmReportes"
        CType(Me.chtRepuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrilla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrilla2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chtRepuestos As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents grdGrilla1 As DataGridView
    Friend WithEvents lblDisponible As Label
    Friend WithEvents grdGrilla2 As DataGridView
End Class
