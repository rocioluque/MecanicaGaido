Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmProductos
    Dim o_productos As New AD_Productos

#Region "Abrir frm"
    Private Sub btnAgregarRubro_Click(sender As Object, e As EventArgs) Handles btnAgregarRubro.Click
        frmAgregarRubro.ShowDialog()
    End Sub
#End Region

#Region "Procedimientos"
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Marcas()
        limpiar()
    End Sub

    Public Sub limpiar()
        txtId.Clear()
        txtDescripcion.Clear()
        txtNombreDiario.Clear()
        cboRubro.SelectedIndex = -1
        chkAlternativo.Checked = False
        cboOriginal.SelectedIndex = -1
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
        cboMarca.SelectedIndex = -1
    End Sub

#End Region

#Region "Carga de Combos"
    Private Sub Cargar_Combo_Marcas()
        Try
            Dim tabla As DataTable = o_productos.Cargar_Combo_Marcas

            If tabla.Rows.Count > 0 Then
                cboMarca.DataSource = tabla
                cboMarca.DisplayMember = "Nombre"
                cboMarca.ValueMember = "ID_Marca"
            Else
                MsgBox("No se encontraron marcas.", vbInformation, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar las marcas: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Marca"
    Private Sub btnAgregarMarca_Click(sender As Object, e As EventArgs) Handles btnAgregarMarca.Click
        Dim frm As New frmAgregarMarca()

        'Comprueba que si se cerró el modal, se cargue el combo con los nuevos datos
        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_Marcas()

            ' Buscar y seleccionar la nueva marca en el ComboBox
            Dim nuevaMarca As String = frm.NuevaMarcaNombre
            For Each item As DataRowView In cboMarca.Items
                If item("Nombre").ToString() = nuevaMarca Then
                    cboMarca.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub
#End Region

#Region "KeyPress"
    Private Sub txtCantidadBulto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadBulto.KeyPress
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

    Private Sub txtStockReal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockReal.KeyPress
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

    Private Sub txtStockDisponible_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockDisponible.KeyPress
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

    Private Sub txtCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompra.KeyPress
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

    Private Sub txtLista_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLista.KeyPress
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

    Private Sub txtNumeroFila_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroFila.KeyPress
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
#End Region

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
End Class