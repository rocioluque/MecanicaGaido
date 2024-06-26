Public Class frmVehiculos
    Private Sub frmVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtID.Clear()
        cboTipo.SelectedIndex = 0
        cboMarca.SelectedIndex = 0
        txtNombre.Clear()
        txtModelo.Clear()
        txtColor.Clear()
        txtNumchasis.Clear()
        txtNumotor.Clear()
        txtMatricula.Clear()
        chkEstado.Checked = False
    End Sub

    Private Sub btnAgregarMarca_Click(sender As Object, e As EventArgs) Handles btnAgregarMarca.Click
        frmAgregarMarca.ShowDialog()
    End Sub
End Class