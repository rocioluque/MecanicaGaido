<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBienvenida
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBienvenida))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSaludo = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New CircularProgressBar.CircularProgressBar()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.lblHola = New System.Windows.Forms.Label()
        Me.PanelLogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(175, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 131)
        Me.Panel1.TabIndex = 0
        '
        'lblSaludo
        '
        Me.lblSaludo.AutoSize = True
        Me.lblSaludo.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.lblSaludo.ForeColor = System.Drawing.Color.White
        Me.lblSaludo.Location = New System.Drawing.Point(11, 207)
        Me.lblSaludo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSaludo.Name = "lblSaludo"
        Me.lblSaludo.Size = New System.Drawing.Size(86, 22)
        Me.lblSaludo.TabIndex = 25
        Me.lblSaludo.Text = "Mensaje"
        '
        'Timer2
        '
        Me.Timer2.Interval = 30
        '
        'ProgressBar1
        '
        Me.ProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.ProgressBar1.AnimationSpeed = 500
        Me.ProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar1.Font = New System.Drawing.Font("Century Gothic", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressBar1.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ProgressBar1.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProgressBar1.InnerMargin = 2
        Me.ProgressBar1.InnerWidth = -1
        Me.ProgressBar1.Location = New System.Drawing.Point(254, 253)
        Me.ProgressBar1.MarqueeAnimationSpeed = 2000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.OuterColor = System.Drawing.Color.Silver
        Me.ProgressBar1.OuterMargin = -25
        Me.ProgressBar1.OuterWidth = 25
        Me.ProgressBar1.ProgressColor = System.Drawing.Color.SeaGreen
        Me.ProgressBar1.ProgressWidth = 20
        Me.ProgressBar1.SecondaryFont = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.ProgressBar1.Size = New System.Drawing.Size(145, 145)
        Me.ProgressBar1.StartAngle = 270
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(5, -35, 0, 0)
        Me.ProgressBar1.SubscriptText = "%"
        Me.ProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.ProgressBar1.SuperscriptText = ""
        Me.ProgressBar1.TabIndex = 27
        Me.ProgressBar1.Text = "0"
        Me.ProgressBar1.TextMargin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.ProgressBar1.Value = 68
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.Panel1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(654, 161)
        Me.PanelLogo.TabIndex = 28
        '
        'lblHola
        '
        Me.lblHola.AutoSize = True
        Me.lblHola.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.lblHola.ForeColor = System.Drawing.Color.White
        Me.lblHola.Location = New System.Drawing.Point(11, 174)
        Me.lblHola.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHola.Name = "lblHola"
        Me.lblHola.Size = New System.Drawing.Size(51, 22)
        Me.lblHola.TabIndex = 29
        Me.lblHola.Text = "Hola"
        '
        'frmBienvenida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(654, 409)
        Me.Controls.Add(Me.lblHola)
        Me.Controls.Add(Me.PanelLogo)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblSaludo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBienvenida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreenForm"
        Me.TopMost = True
        Me.PanelLogo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSaludo As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents lblHola As Label
End Class
