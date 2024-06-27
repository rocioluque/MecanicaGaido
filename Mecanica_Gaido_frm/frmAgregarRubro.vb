Public Class frmAgregarRubro
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub txtRubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRubro.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
      AndAlso Not Char.IsControl(e.KeyChar) _
      AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class