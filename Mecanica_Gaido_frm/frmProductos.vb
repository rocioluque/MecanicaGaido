Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmProductos
    Dim o_productos As New AD_Productos

    Private txtsConDecimales As New List(Of TextBox)

#Region "Procedimientos"
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar_Combo_Marcas()
        Cargar_Combo_Rubros()
        Cargar_Combo_Original()
        limpiar()
        Cargar_Grilla()

        'AGREGAR LOS TEXTBOXS QUE NECESITEN QUE SE VALIDEN COMO NUMERO DECIMAL
        AgregarValidacionATextBox(txtPrecioLista)
        AgregarValidacionATextBox(txtPrecioCompra)
        AgregarValidacionATextBox(txtCantidadBulto)
        AgregarValidacionATextBox(txtStockDisponible)
        AgregarValidacionATextBox(txtStockReal)
        AgregarValidacionATextBox(txtUtilidad)

        'AddHandler txtPrecioLista.KeyPress, AddressOf ValidarNumeroDecimal
        'AddHandler txtStockDisponible.KeyPress, AddressOf ValidarNumeroDecimal
        'AddHandler txtStockReal.KeyPress, AddressOf ValidarNumeroDecimal
        'AddHandler txtUtilidad.KeyPress, AddressOf ValidarNumeroDecimal
        'AddHandler txtPrecioCompra.KeyPress, AddressOf ValidarNumeroDecimal
        'AddHandler txtCantidadBulto.KeyPress, AddressOf ValidarNumeroDecimal

    End Sub



    Public Sub limpiar()
        txtId.Clear()
        txtDescripcion.Clear()
        txtNombreDiario.Clear()
        txtCantidadBulto.Clear()
        txtStockReal.Clear()
        txtStockDisponible.Clear()
        txtPrecioCompra.Clear()
        txtUtilidad.Clear()
        txtPrecioLista.Clear()
        txtUbicacion.Clear()
        txtCodigoBarra.Clear()
        txtCodFabricante.Clear()
        cboRubro.SelectedIndex = -1
        cboMarca.SelectedIndex = -1
        cboOriginal.SelectedIndex = -1
        cboOrigen.SelectedIndex = -1
        dtpFechaCompra.Value = DateTime.Today
        dtpFechaVenta.Value = DateTime.Today
        chkAlterntivo.Checked = False
        chkEstado.Checked = False
    End Sub

    Public Sub Cargar_Grilla()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_Producto")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdProductos.AutoGenerateColumns = True
                grdProductos.DataSource = oDs.Tables(0)

                ' Verificar si las columnas existen antes de ocultarlas
                Dim columnasParaOcultar As String() = {"Rubro", "alternativo", "ID_Original", "Cantidad_X_Bulto", "PrecioCompra", "Utilidad",
                                                        "FechaUltimaCompra", "FechaUltimaVenta", "CodBarra", "CodFabricante", "Origen", "Estado"}
                For Each colName As String In columnasParaOcultar
                    If grdProductos.Columns.Contains(colName) Then
                        grdProductos.Columns(colName).Visible = False
                    End If
                Next
                grdProductos.Refresh()
            Else
                MsgBox("No se encontraron datos para mostrar.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al cargar la grilla: " & ex.Message, vbCritical, "Error")
        Finally
        End Try
    End Sub

    Public Sub CargarDatosEnTxt(ByVal idProducto As Integer)
        Dim o_Productos As New AD_Productos

        Try
            Dim datoleido As SqlDataReader = o_Productos.Consultar_ProductoPorID(idProducto)

            If datoleido.Read() Then
                txtId.Text = If(IsDBNull(datoleido("N° Producto")), String.Empty, datoleido("N° Producto").ToString())
                txtDescripcion.Text = If(IsDBNull(datoleido("Producto")), String.Empty, datoleido("Producto").ToString())
                txtNombreDiario.Text = If(IsDBNull(datoleido("Nombre Diario")), String.Empty, datoleido("Nombre Diario").ToString())
                cboMarca.SelectedValue = If(IsDBNull(datoleido("Marca")), -1, datoleido("Marca"))
                txtStockReal.Text = If(IsDBNull(datoleido("Stock Real")), String.Empty, datoleido("Stock Real").ToString())
                txtStockDisponible.Text = If(IsDBNull(datoleido("Stock Disponible")), String.Empty, datoleido("Stock Disponible").ToString())
                txtPrecioLista.Text = If(IsDBNull(datoleido("Precio Lista")), String.Empty, datoleido("Precio Lista").ToString())
                txtUbicacion.Text = If(IsDBNull(datoleido("Ubicacion")), String.Empty, datoleido("Ubicacion").ToString())
                cboRubro.SelectedValue = If(IsDBNull(datoleido("Rubro")), String.Empty, datoleido("Rubro").ToString())
                chkAlterntivo.Checked = If(IsDBNull(datoleido("alternativo")), False, Convert.ToBoolean(datoleido("alternativo")))
                cboOriginal.SelectedValue = If(IsDBNull(datoleido("ID_Original")), String.Empty, datoleido("ID_Original").ToString())
                txtCantidadBulto.Text = If(IsDBNull(datoleido("Cantidad_X_Bulto")), String.Empty, datoleido("Cantidad_X_Bulto").ToString())
                txtPrecioCompra.Text = If(IsDBNull(datoleido("PrecioCompra")), String.Empty, datoleido("PrecioCompra").ToString())
                txtUtilidad.Text = If(IsDBNull(datoleido("Utilidad")), String.Empty, datoleido("Utilidad").ToString())

                ' Convert.ToDateTime maneja los valores nulos y fechas inválidas
                If Not IsDBNull(datoleido("FechaUltimaCompra")) Then
                    dtpFechaCompra.Value = Convert.ToDateTime(datoleido("FechaUltimaCompra"))
                Else
                    dtpFechaCompra.Value = DateTime.Now
                End If

                If Not IsDBNull(datoleido("FechaUltimaVenta")) Then
                    dtpFechaVenta.Value = Convert.ToDateTime(datoleido("FechaUltimaVenta"))
                Else
                    dtpFechaVenta.Value = DateTime.Now
                End If

                txtCodigoBarra.Text = If(IsDBNull(datoleido("CodBarra")), String.Empty, datoleido("CodBarra").ToString())
                txtCodFabricante.Text = If(IsDBNull(datoleido("CodFabricante")), String.Empty, datoleido("CodFabricante").ToString())
                cboOrigen.Text = If(IsDBNull(datoleido("Origen")), String.Empty, datoleido("Origen").ToString())
                chkEstado.Checked = If(IsDBNull(datoleido("Estado")), False, Convert.ToBoolean(datoleido("Estado")))
            Else
                MsgBox("No se encontraron resultados", vbInformation, "Error")
            End If

            datoleido.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al consultar el producto: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub grdProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdProductos.CellClick
        If e.RowIndex >= 0 Then

            ' Obtiene el ID de la joya de la celda correspondiente
            Dim selectedRow As DataGridViewRow = grdProductos.Rows(e.RowIndex)
            Dim idProducto As Integer

            If selectedRow.Cells("N° Producto").Value IsNot Nothing Then
                idProducto = Convert.ToInt32(selectedRow.Cells("N° Producto").Value)
                CargarDatosEnTxt(idProducto)
            Else
                MsgBox("El ID del producto no puede ser nulo.", vbCritical, "Error")
            End If
        End If
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
                cboMarca.SelectedIndex = -1
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
                cboRubro.SelectedIndex = -1
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
                cboOriginal.DataSource = tabla
                cboOriginal.DisplayMember = "Descripcion"
                cboOriginal.ValueMember = "ID_Repuestos"
                cboOriginal.SelectedIndex = -1
            Else
                MsgBox("No se encontraron productos originales.", vbInformation, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los productos originales: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtDescripcion.Text <> Nothing And cboMarca.SelectedValue <> Nothing And txtCodFabricante.Text <> Nothing And
            txtUbicacion.Text <> Nothing And txtUtilidad.Text <> Nothing Then

            Try
                o_productos.Agregar_Producto(txtDescripcion.Text, txtNombreDiario.Text, CInt(cboRubro.SelectedValue),
                       CInt(cboMarca.SelectedValue), txtCodigoBarra.Text, txtCodFabricante.Text, txtCantidadBulto.Text,
                       CInt(cboOrigen.SelectedValue), chkAlterntivo.Checked, CInt(cboOriginal.SelectedValue), chkEstado.Checked, txtStockReal.Text,
                       txtStockDisponible.Text, txtUbicacion.Text, txtPrecioCompra.Text, txtUtilidad.Text, txtPrecioLista.Text,
                       dtpFechaCompra.Value, dtpFechaVenta.Value)

                MsgBox("Producto agregado correctamente.", vbInformation, "Información")
                limpiar()
                Cargar_Grilla()
                Cargar_Combo_Original()

            Catch ex As Exception
                MsgBox("Error al agregar el producto: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete los datos correspondientes.", vbInformation, "Error")
        End If
    End Sub
#End Region

#Region "Calculo precio lista"
    Private Sub txtPrecioCompra_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioCompra.TextChanged
        CalcularPrecioLista()
    End Sub

    Private Sub txtUtilidad_TextChanged(sender As Object, e As EventArgs) Handles txtUtilidad.TextChanged
        CalcularPrecioLista()
    End Sub

    Private Sub CalcularPrecioLista()
        Dim precioCompra As Decimal
        Dim utilidad As Decimal

        ' Verifica que los valores ingresados sean números válidos
        If Decimal.TryParse(txtPrecioCompra.Text, precioCompra) AndAlso Decimal.TryParse(txtUtilidad.Text, utilidad) Then

            Dim precioLista As Decimal = precioCompra * (utilidad / 100 + 1)
            txtPrecioLista.Text = precioLista.ToString("F2") 'Formatea el resultado a dos decimales
        Else
            ' Si los valores no son válidos, limpia el TextBox de precio de lista
            txtPrecioLista.Text = String.Empty
        End If
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
    Private Sub chkAlternativo_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlterntivo.CheckedChanged
        If chkAlterntivo.Checked = True Then
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

    Public Sub ValidarNumeroDecimal(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c OrElse e.KeyChar = ","c Then
            Dim textBox = DirectCast(sender, TextBox)
            If (e.KeyChar = "."c OrElse e.KeyChar = ","c) AndAlso (textBox.Text.Contains(".") OrElse textBox.Text.Contains(",")) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub FormatearNumero(sender As Object, e As EventArgs)
        Dim textBox = DirectCast(sender, TextBox)
        Dim numero As Decimal

        If Decimal.TryParse(textBox.Text.Replace(",", "."), Globalization.NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, numero) Then
            textBox.Tag = numero.ToString("N2", Globalization.CultureInfo.CurrentCulture) ' Guarda el valor formateado para mostrar
            textBox.Text = numero.ToString(Globalization.CultureInfo.InvariantCulture) ' Guarda el valor sin formato en Text
        ElseIf String.IsNullOrWhiteSpace(textBox.Text) Then
            textBox.Tag = "0,00"
            textBox.Text = "0.00"
        End If

        MostrarValorFormateado(textBox)
    End Sub

    Private Sub MostrarValorFormateado(textBox As TextBox)
        If textBox.Focused Then
            ' Si el TextBox tiene el foco, muestra el valor sin formato
            textBox.Text = textBox.Text
        Else
            ' Si el TextBox no tiene el foco, muestra el valor formateado
            textBox.Text = textBox.Tag.ToString()
        End If
    End Sub


    Public Sub AgregarValidacionATextBox(textBox As TextBox)
        If Not txtsConDecimales.Contains(textBox) Then
            txtsConDecimales.Add(textBox)
            AddHandler textBox.KeyPress, AddressOf ValidarNumeroDecimal
            AddHandler textBox.LostFocus, AddressOf FormatearNumero
            AddHandler textBox.GotFocus, AddressOf TextBox_GotFocus
        End If
    End Sub
    Private Sub TextBox_GotFocus(sender As Object, e As EventArgs)
        Dim textBox = DirectCast(sender, TextBox)
        textBox.Text = textBox.Text.Replace(",", ".")
    End Sub

    'Private Sub txtCantidadBulto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadBulto.KeyPress
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        If Char.IsControl(e.KeyChar) Then
    '            e.Handled = False
    '        Else
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtStockReal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockReal.KeyPress
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        If Char.IsControl(e.KeyChar) Then
    '            e.Handled = False
    '        Else
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtStockDisponible_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStockDisponible.KeyPress
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        If Char.IsControl(e.KeyChar) Then
    '            e.Handled = False
    '        Else
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtPrecioCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioCompra.KeyPress
    '    soloNumeros(e)
    'End Sub

    'Private Sub txtPrecioLista_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        If Char.IsControl(e.KeyChar) Then
    '            e.Handled = False
    '        Else
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub txtNumeroFila_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        If Char.IsControl(e.KeyChar) Then
    '            e.Handled = False
    '        Else
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub
#End Region

    Private Sub txtUtilidad_LostFocus(sender As Object, e As EventArgs) Handles txtUtilidad.LostFocus

        Dim value As Double

        ' Intenta convertir el valor del TextBox a un número
        If Double.TryParse(txtUtilidad.Text, value) Then
            ' Si la conversión es exitosa, formatea el número con 2 decimales
            txtUtilidad.Text = value.ToString("F2")
        Else
            ' Si la conversión falla, muestra un mensaje de error o maneja el error según sea necesario
            MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
End Class