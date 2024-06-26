Public Class frmVentas
    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        frmAgregarCuentas.ShowDialog()
    End Sub

    Private Sub btnAgregarFormaPago_Click(sender As Object, e As EventArgs) Handles btnAgregarFormaPago.Click
        frmAgregarFormaPago.ShowDialog()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtID.Clear()
        txtFechaVenta.Clear()
        txtNumComprobante.Clear()
        cboCuenta.SelectedIndex = 0
        cboEmpleado.SelectedIndex = 0
        cboFormaPago.SelectedIndex = 0
        txtSubtotal.Clear()
        txtIVA.Clear()
        txtOtrosImpuestos.Clear()
        txtTotal.Clear()
        cboTipoVenta.SelectedIndex = 0
        cboFormaEntrega.SelectedIndex = 0
        chkEstado.Checked = False
    End Sub

    Private Sub btnFormaEntrega_Click(sender As Object, e As EventArgs) Handles btnFormaEntrega.Click
        frmAgregarFormaEntrega.ShowDialog()
    End Sub

    Private Sub btnTipoVenta_Click(sender As Object, e As EventArgs) Handles btnTipoVenta.Click
        frmAgregarTipoVenta.ShowDialog()
    End Sub
End Class