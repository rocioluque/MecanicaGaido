Imports AD_Mecanica_Gaido
Public Class frmRecuperarContraseña
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim solicitarContraseñaUsuario As New AD_Login

        Dim resultado = solicitarContraseñaUsuario.solicitarContraseñaUsuario(txtIngreseUserCorreo.Text)
        lblResultado.Text = resultado
        lblResultado.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

End Class