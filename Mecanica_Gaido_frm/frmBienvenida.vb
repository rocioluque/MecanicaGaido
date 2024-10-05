Imports Comun_Soporte
Imports Mecanica_Gaido_frm.User32
Imports System.Drawing.Drawing2D

Public Class frmBienvenida

#Region "Procedimientos"
    Private Sub frmBienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Me.Opacity = 0
        lblSaludo.Text = ObtenerSaludoAleatorio()
        lblHola.Text = "¡Hola " & UsuarioActivo.nombre_empleado & "!"
        Timer1.Start()
        AplicarTema(Me)
    End Sub
#End Region

#Region "Saludos"
    Private random As New Random()

    Private saludos As String() = {
        "¡Bienvenido a Mecánica Gaido!",
        "¡Esperamos que tengas un excelente día!",
        "¡Gracias por tu esfuerzo en Mecánica Gaido!",
        "¡Que tengas una jornada productiva!",
        "¡Nos alegra contar con vos en el equipo!",
        "¡Seguí brillando en Mecánica Gaido!",
        "¡Hoy es un gran día para lograr grandes cosas!",
        "¡Cada día es una nueva oportunidad!",
        "¡Tu trabajo es valioso, seguí así!",
        "¡Gracias por tu compromiso con Mecánica Gaido!",
        "¡Gracias por ser parte de Mecánica Gaido!",
        "¡Hoy es un buen día para superarse!",
        "¡Siempre contamos con vos para grandes logros!",
        "¡Tu dedicación marca la diferencia!",
        "¡Sigue inspirando con tu trabajo cada día!",
        "¡Es un honor tenerte en nuestro equipo!",
        "¡Juntos construimos el éxito!",
        "¡Tu esfuerzo impulsa a Mecánica Gaido hacia adelante!",
        "¡Hoy puede ser un día excepcional, hacelo posible!",
        "¡Gracias por tu constancia y dedicación!"
    }

    Private Function ObtenerSaludoAleatorio() As String
        Dim indice As Integer = random.Next(saludos.Length)
        Return saludos(indice)
    End Function
#End Region

#Region "Timer y opacidad de frm"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        ProgressBar1.Text = ProgressBar1.Value.ToString
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Timer2.Stop()
            Me.Close()
        End If
    End Sub
#End Region

#Region "Css trucho"
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        ' Aplica bordes redondeados al panel existente
        Dim pathLogo As New GraphicsPath()
        Dim borderRadius As Integer = 80

        ' Línea recta desde la esquina superior izquierda hasta la esquina superior derecha
        pathLogo.AddLine(0, 0, PanelLogo.Width, 0)

        ' Línea recta desde la esquina superior derecha hasta la esquina inferior derecha
        pathLogo.AddLine(PanelLogo.Width, 0, PanelLogo.Width, PanelLogo.Height - borderRadius)

        ' Arco en la esquina inferior derecha
        pathLogo.AddArc(PanelLogo.Width - borderRadius, PanelLogo.Height - borderRadius, borderRadius, borderRadius, 0, 90)

        ' Línea recta desde el final del arco inferior derecho hasta el inicio del arco inferior izquierdo
        pathLogo.AddLine(PanelLogo.Width - borderRadius, PanelLogo.Height, borderRadius, PanelLogo.Height)

        ' Arco en la esquina inferior izquierda
        pathLogo.AddArc(0, PanelLogo.Height - borderRadius, borderRadius, borderRadius, 90, 90)

        ' Línea recta desde la esquina inferior izquierda hasta la esquina superior izquierda
        pathLogo.AddLine(0, PanelLogo.Height - borderRadius, 0, 0)

        pathLogo.CloseAllFigures()
        PanelLogo.Region = New Region(pathLogo)
    End Sub
#End Region

End Class