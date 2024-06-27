
Public Class frmOrdenesReparacion
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtID.Clear()
        'ver que hacer con el cboVehiculo'
        txtSeñasParticulares.Clear()
        txtMotivo.Clear()
        txtFechaturno.Clear()
        txtFechaentrada.Clear()
        txtFechaestimada.Clear()
        txtFechasalida.Clear()
        cboCuenta.SelectedIndex = 0
        cboServicios.SelectedIndex = 0
        chkActivo.Checked = False
    End Sub


    Private Sub txtSeñasParticulares_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSeñasParticulares.KeyPress
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