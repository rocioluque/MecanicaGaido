Imports System.Drawing
Imports System.Windows.Forms

Public Class SwitchButton
    Inherits UserControl

    Private isOn As Boolean = False
    Private circlePosition As Integer = 3

    ' Constructor
    Public Sub New()
        Me.Size = New Size(60, 30)
        Me.BackColor = Color.LightGray
        Me.DoubleBuffered = True
    End Sub

    ' Dibuja el botón
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        Dim brush As Brush
        Dim circleBrush As Brush

        ' Establece el color dependiendo de si está activado o no
        If isOn Then
            brush = New SolidBrush(Color.DodgerBlue)
            circleBrush = New SolidBrush(Color.White)
        Else
            brush = New SolidBrush(Color.LightGray)
            circleBrush = New SolidBrush(Color.WhiteSmoke)
        End If

        ' Dibuja el óvalo de fondo
        g.FillRectangle(brush, New Rectangle(0, 0, Me.Width, Me.Height))
        g.FillEllipse(circleBrush, New Rectangle(circlePosition, 3, 24, 24))
    End Sub

    ' Evento para detectar el clic y mover el círculo
    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)

        ' Cambia el estado del botón
        isOn = Not isOn

        ' Mueve el círculo dependiendo del estado
        If isOn Then
            circlePosition = Me.Width - 27 ' Mueve el círculo a la derecha
        Else
            circlePosition = 3 ' Mueve el círculo a la izquierda
        End If

        ' Llama al evento de Paint para redibujar el control
        Me.Invalidate()

        ' Dispara un evento cuando se cambia el tema
        RaiseEvent ThemeChanged(Me, New EventArgs())
    End Sub

    ' Evento personalizado para detectar el cambio de tema
    Public Event ThemeChanged As EventHandler
End Class
