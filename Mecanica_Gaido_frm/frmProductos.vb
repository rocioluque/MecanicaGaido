Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmProductos
    Dim o_productos As New AD_Productos

#Region "Procedimientos"
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Marcas()
        Cargar_Combo_Rubros()
        Cargar_Combo_Original
        limpiar()
    End Sub

    Public Sub limpiar()
        txtId.Clear()
        txtDescripcion.Clear()
        txtNombreDiario.Clear()
        txtCantidadBulto.Clear()
        txtStockReal.Clear()
        txtStockDisponible.Clear()
        txtCompra.Clear()
        txtUtilidad.Clear()
        txtLista.Clear()
        txtFechaUltCompra.Clear()
        txtFechaUltVenta.Clear()
        txtEstanteria.Clear()
        txtNumeroFila.Clear()
        txtCodigoBarra.Clear()
        txtFabricante.Clear()
        cboRubro.SelectedIndex = -1
        cboMarca.SelectedIndex = -1
        cboOriginal.SelectedIndex = -1
        chkAlternativo.Checked = False
        chkActivo.Checked = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
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

    Private Sub Cargar_Combo_Rubros()
        Try
            Dim tabla As DataTable = o_productos.Cargar_Combo_Rubros

            If tabla.Rows.Count > 0 Then
                cboRubro.DataSource = tabla
                cboRubro.DisplayMember = "Nombre"
                cboRubro.ValueMember = "ID_Rubro"
            Else
                MsgBox("No se encontraron rubros.", vbInformation, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los rubros: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Cargar_Combo_Original()
        Try
            Dim tabla As DataTable = o_productos.Cargar_Combo_Original

            If tabla.Rows.Count > 0 Then
                cboRubro.DataSource = tabla
                cboRubro.DisplayMember = "Descripcion"
                cboRubro.ValueMember = "ID_Producto"
            Else
                MsgBox("No se encontraron productos originales.", vbInformation, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los productos originales: " & ex.Message, vbCritical, "Error")
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

#Region "Rubro"
    Private Sub btnAgregarRubro_Click(sender As Object, e As EventArgs) Handles btnAgregarRubro.Click
        Dim frm As New frmAgregarRubro()

        'Comprueba que si se cerró el modal, se cargue el combo con los nuevos datos
        If frm.ShowDialog() = DialogResult.OK Then
            Cargar_Combo_Rubros()

            ' Buscar y seleccionar la nueva marca en el ComboBox
            Dim nuevoRubro As String = frm.NuevoRubroNombre
            For Each item As DataRowView In cboRubro.Items
                If item("Nombre").ToString() = nuevoRubro Then
                    cboRubro.SelectedItem = item
                    Exit For
                End If
            Next
        End If
    End Sub
#End Region

#Region "Alternativo"
    Private Sub chkAlternativo_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlternativo.CheckedChanged
        If chkAlternativo.Checked = True Then
            cboOriginal.Enabled = True
        End If
    End Sub
#End Region

#Region "Css trucho"
    Private Sub PanelDatosEspecificos_Paint(sender As Object, e As PaintEventArgs) Handles PanelDatosEspecificos.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelDatosEspecificos.Width - 1, PanelDatosEspecificos.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub


    Private Sub PanelExistencia_Paint(sender As Object, e As PaintEventArgs) Handles PanelExistencia.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelExistencia.Width - 1, PanelExistencia.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub

    Private Sub PanelMovimientos_Paint(sender As Object, e As PaintEventArgs) Handles PanelMovimientos.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelMovimientos.Width - 1, PanelMovimientos.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
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

    Private Sub txtCompra_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtLista_KeyPress(sender As Object, e As KeyPressEventArgs)
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
End Class