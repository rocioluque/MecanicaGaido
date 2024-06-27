Public Class frmCompras
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtID.Clear()
        txtFechaCompra.Clear()
        txtNumComprobante.Clear()
        cboCuenta.SelectedIndex = 0
        cboFormaPago.SelectedIndex = 0
        txtSubTotal.Clear()
        txtIVA.Clear()
        txtIvaMonto.Clear()
        txtOtrosImpuestos.Clear()
        txtTotal.Clear()
        chkEstado.Checked = False
    End Sub

    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        frmAgregarCuentas.ShowDialog()
    End Sub

    Private Sub btnAgregarFormaPago_Click(sender As Object, e As EventArgs) Handles btnAgregarFormaPago.Click
        frmAgregarFormaPago.ShowDialog()
    End Sub


    Private Sub txtNumComprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumComprobante.KeyPress
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


    Private Sub txtSubTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubTotal.KeyPress
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

    Private Sub txtIVA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIVA.KeyPress
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

    Private Sub txtIvaMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIvaMonto.KeyPress
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

    Private Sub txtOtrosImpuestos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtrosImpuestos.KeyPress
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


    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
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