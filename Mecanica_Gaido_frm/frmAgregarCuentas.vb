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
End Class