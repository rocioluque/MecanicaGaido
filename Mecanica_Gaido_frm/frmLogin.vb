Imports System.Drawing.Drawing2D
Imports System.Data
Imports System.Runtime.InteropServices
Imports AD_Mecanica_Gaido
Imports Mecanica_Gaido_frm.User32

Public Class frmLogin
    Dim o_Login As New AD_Login

#Region "Enter para pasar de tabulación"

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Enter Then
            ' Verifica si el control activo es un Button
            If TypeOf Me.ActiveControl Is Button Then
                ' Ejecuta el evento Click del botón
                Dim button As Button = DirectCast(Me.ActiveControl, Button)
                button.PerformClick()
                Return True
            Else
                ' Mueve el foco al siguiente control en el orden de tabulación
                Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
                Return True
            End If
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

#End Region

#Region "Procedimientos"
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Aplicar_Imagenes()
    End Sub

    Private Sub Cerrar_Sesion(sender As Object, e As FormClosedEventArgs)
        txtUsuario.Clear()
        txtContraseña.Clear()
        Me.Show()
        txtUsuario.Focus()
    End Sub

    Private Sub Aplicar_Imagenes()
        btnMinimizar.BackgroundImage = Image.FromFile(System.IO.Path.Combine("Imagenes", "minimizar_bco.png"))
        btnCerrar.BackgroundImage = Image.FromFile(System.IO.Path.Combine("Imagenes", "cancel_bco.png"))
        PanelLogo.BackgroundImage = Image.FromFile(System.IO.Path.Combine("Imagenes", "fondo_GaidoRepuestosServicios.png"))
    End Sub
#End Region

#Region "Aceptar"
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        o_Login = New AD_Login

        Dim ValidLogin = o_Login.ValidarUsuario(txtUsuario.Text, txtContraseña.Text)

        If ValidLogin = True Then
            Me.Hide()
            Dim frmBienvenida As New frmBienvenida
            frmBienvenida.ShowDialog()

            frmMenuPrincipal.Show()
            AddHandler frmMenuPrincipal.FormClosed, AddressOf Me.Cerrar_Sesion
        Else
            If txtContraseña.Text = "CONTRASEÑA" And txtUsuario.Text = "USUARIO" Then
                MsgBox("Complete datos", vbInformation, "Login")
            Else
                If ValidLogin = False Then
                    MsgBox("Usuario o contraseña incorrecta." + vbNewLine + "Por favor intente nuevamente.", vbInformation, "Error")
                    txtContraseña.Clear()
                    txtUsuario.Focus()
                End If
            End If
        End If
    End Sub
#End Region

#Region "Contraseña"
    Public Sub TogglePasswordVisibility(chkVerContraseña As CheckBox, txtContraseña As TextBox)
        If chkVerContraseña.Checked Then
            txtContraseña.UseSystemPasswordChar = False
        Else
            txtContraseña.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub chkVerContraseña_CheckedChanged(sender As Object, e As EventArgs) Handles chkVerContraseña.CheckedChanged
        TogglePasswordVisibility(chkVerContraseña, txtContraseña)
    End Sub
#End Region

#Region "Control txt"
    Private Sub txtUsuario_Enter(sender As Object, e As EventArgs) Handles txtUsuario.Enter
        If txtUsuario.Text = "USUARIO" Then
            txtUsuario.Text = Nothing
            txtUsuario.ForeColor = Color.LightGray
        End If
    End Sub

    Private Sub txtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If txtUsuario.Text = Nothing Then
            txtUsuario.Text = "USUARIO"
            txtUsuario.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtContraseña_Enter(sender As Object, e As EventArgs) Handles txtContraseña.Enter
        If txtContraseña.Text = "CONTRASEÑA" Then
            txtContraseña.Text = Nothing
            txtContraseña.ForeColor = Color.LightGray
            txtContraseña.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtContraseña_Leave(sender As Object, e As EventArgs) Handles txtContraseña.Leave
        If txtContraseña.Text = Nothing Then
            txtContraseña.Text = "CONTRASEÑA"
            txtContraseña.ForeColor = Color.DimGray
            txtContraseña.UseSystemPasswordChar = False
        End If
    End Sub
#End Region

#Region "Control botones-mov frm"
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &HA1, 2, 0)
        End If
    End Sub

    Private Sub PanelLogo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelLogo.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &HA1, 2, 0)
        End If
    End Sub

    Private Sub PanelLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelLogin.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, &HA1, 2, 0)
        End If
    End Sub
    Private Sub linkContraseña_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkContraseña.LinkClicked
        frmRecuperarContraseña.ShowDialog()
    End Sub
#End Region

#Region "Css trucho"
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        ' Aplica bordes redondeados al panel existente
        Dim borderRectangle As New Rectangle(0, 0, PanelLogin.Width - 1, PanelLogin.Height - 1)
        Dim path As New GraphicsPath()
        Dim borderSize As Integer = 20

        Dim pathLogo As New GraphicsPath()

        ' Esquina superior izquierda
        pathLogo.AddArc(0, 0, 80, 80, 180, 90)

        ' Línea recta desde el final del arco superior izquierdo hasta la esquina superior derecha
        pathLogo.AddLine(80, 0, PanelLogo.Width, 0)

        ' Línea recta desde la esquina superior derecha hasta la esquina inferior derecha
        pathLogo.AddLine(PanelLogo.Width, 0, PanelLogo.Width, PanelLogo.Height)

        ' Línea recta desde la esquina inferior derecha hasta el inicio del arco inferior izquierdo
        pathLogo.AddLine(PanelLogo.Width, PanelLogo.Height, 80, PanelLogo.Height)

        ' Esquina inferior izquierda
        pathLogo.AddArc(0, PanelLogo.Height - 80, 80, 80, 90, 90)

        ' Línea recta desde el final del arco inferior izquierdo hasta el inicio del arco superior izquierdo
        pathLogo.AddLine(0, PanelLogo.Height - 80, 0, 80)

        pathLogo.CloseAllFigures()
        PanelLogo.Region = New Region(pathLogo)
    End Sub
#End Region

End Class