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
End Class