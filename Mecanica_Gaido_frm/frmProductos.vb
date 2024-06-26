Public Class frmProductos

#Region "Abrir frm"
    Private Sub btnAgregarMarca_Click(sender As Object, e As EventArgs) Handles btnAgregarMarca.Click
        frmAgregarMarca.ShowDialog()
    End Sub

    Private Sub btnAgregarRubro_Click(sender As Object, e As EventArgs) Handles btnAgregarRubro.Click
        frmAgregarRubro.ShowDialog()
    End Sub
#End Region

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtId.Clear()
        txtDescripcion.Clear()
        txtNombreDiario.Clear()
        cboMarca.SelectedIndex = 0
        cboRubro.SelectedIndex = 0
        chkAlternativo.Checked = False
        cboOriginal.SelectedIndex = 0
        txtCantidadBulto.Clear()
        txtStockReal.Clear()
        txtStockDisponible.Clear()
        txtCompra.Clear()
        txtLista.Clear()
        txtUtilidad.Clear()
        txtFechaUltCompra.Clear()
        txtFechaUltVenta.Clear()
        txtEstanteria.Clear()
        txtNumeroFila.Clear()
        txtCodigoBarra.Clear()
        txtFabricante.Clear()
        txtOrigen.Clear()
        chkActivo.Checked = False
    End Sub
End Class