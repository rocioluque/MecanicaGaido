Public Class frmAgregarCuentas
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtID.Clear()
        txtEmpresa.Clear()
        txtCUIT.Clear()
        txtIngresosBrutos.Clear()
        txtFechaAlta.Clear()
        txtCargo.Clear()
        txtSaldo.Clear()
        chkEstado.Checked = False
    End Sub


    Private Sub txtCargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCargo.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                 AndAlso Not Char.IsControl(e.KeyChar) _
                 AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
End Class