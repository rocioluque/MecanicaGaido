Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Globalization

Public Class frmProductos
    Dim o_productos As New AD_Productos
    Private txtsConDecimales As New List(Of TextBox)

    Public ubicacionrep As String

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
    End Sub

    Public Sub limpiar()
        txtId.Clear()
        txtDescripcion.Clear()
        txtNombreDiario.Clear()
        txtCantidadBulto.Clear()
        txtStockReal.Clear()
        txtStockDisponible.Clear()
        txtStockMinimo.Clear()
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
#End Region

#Region "Grilla y carga de txt"
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

                If grdProductos.Columns.Contains("Precio Lista") Then
                    grdProductos.Columns("Precio Lista").DefaultCellStyle.Format = "N2"
                End If

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
                txtId.Text = datoleido("N° Producto").ToString()
                txtDescripcion.Text = datoleido("Producto").ToString()
                txtNombreDiario.Text = datoleido("Nombre Diario").ToString()
                cboMarca.SelectedValue = datoleido("Marca").ToString
                txtStockReal.Text = datoleido("Stock Real").ToString()
                txtStockDisponible.Text = datoleido("Stock Disponible").ToString()
                txtStockMinimo.Text = datoleido("Stock Minimo").ToString
                txtPrecioLista.Text = Convert.ToDecimal(datoleido("Precio Lista")).ToString("N2")
                txtPrecioCompra.Text = Convert.ToDecimal(datoleido("PrecioCompra")).ToString("N2")
                txtUbicacion.Text = datoleido("Ubicacion").ToString()
                cboRubro.SelectedValue = datoleido("Rubro").ToString()
                chkAlterntivo.Checked = Convert.ToBoolean(datoleido("alternativo"))
                cboOriginal.SelectedValue = datoleido("ID_Original").ToString()
                txtCantidadBulto.Text = datoleido("Cantidad_X_Bulto").ToString()
                txtUtilidad.Text = Convert.ToDecimal(datoleido("Utilidad")).ToString("N2")
                dtpFechaCompra.Value = Convert.ToDateTime(datoleido("FechaUltimaCompra"))
                dtpFechaVenta.Value = Convert.ToDateTime(datoleido("FechaUltimaVenta"))
                txtCodigoBarra.Text = datoleido("CodBarra").ToString()
                txtCodFabricante.Text = datoleido("CodFabricante").ToString()
                cboOrigen.Text = datoleido("Origen").ToString()
                chkEstado.Checked = Convert.ToBoolean(datoleido("Estado"))
                btnModificar.Enabled = True
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

            ' Obtiene el ID del producto de la celda correspondiente
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
                Dim origen As String = cboOrigen.SelectedItem.ToString()
                Dim precioCompra As Decimal = Convert.ToDecimal(txtPrecioCompra.Text).ToString("N2")
                Dim utilidad As Decimal = Convert.ToDecimal(txtUtilidad.Text).ToString("N2")
                Dim precioLista As Decimal = Convert.ToDecimal(txtPrecioLista.Text).ToString("N2")

                o_productos.Agregar_Producto(txtDescripcion.Text, txtNombreDiario.Text, CInt(cboRubro.SelectedValue),
                       CInt(cboMarca.SelectedValue), txtCodigoBarra.Text, txtCodFabricante.Text, txtCantidadBulto.Text,
                       origen, chkAlterntivo.Checked, CInt(cboOriginal.SelectedValue), chkEstado.Checked, txtStockReal.Text,
                       txtStockDisponible.Text, txtStockMinimo.Text, txtUbicacion.Text, precioCompra, utilidad, precioLista,
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

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtId.Text <> Nothing And txtDescripcion.Text <> Nothing And cboMarca.SelectedValue <> Nothing And txtCodFabricante.Text <> Nothing And
      txtUbicacion.Text <> Nothing And txtUtilidad.Text <> Nothing Then

            Try
                Dim origen As String = cboOrigen.SelectedItem.ToString()
                Dim precioCompra As Decimal = Convert.ToDecimal(txtPrecioCompra.Text).ToString("N2")
                Dim utilidad As Decimal = Convert.ToDecimal(txtUtilidad.Text).ToString("N2")
                Dim precioLista As Decimal = Convert.ToDecimal(txtPrecioLista.Text).ToString("N2")

                o_productos.Modificar_Producto(CInt(txtId.Text), txtDescripcion.Text, txtNombreDiario.Text, CInt(cboRubro.SelectedValue),
                   CInt(cboMarca.SelectedValue), txtCodigoBarra.Text, txtCodFabricante.Text, txtCantidadBulto.Text,
                   origen, chkAlterntivo.Checked, CInt(cboOriginal.SelectedValue), chkEstado.Checked,
                   txtStockReal.Text, txtStockDisponible.Text, txtStockMinimo.Text, txtUbicacion.Text,
                   precioCompra, utilidad, precioLista, dtpFechaCompra.Value, dtpFechaVenta.Value)

                MsgBox("Producto modificado correctamente.", vbInformation, "Información")
                limpiar()
                Cargar_Grilla()
                Cargar_Combo_Original()
                btnModificar.Enabled = False
            Catch ex As Exception
                MsgBox("Error al modificar el producto: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete los datos correspondientes.", vbInformation, "Error")
        End If
    End Sub
#End Region

#Region "Calculo precio lista"

    Private Sub txtPrecioCompra_LostFocus(sender As Object, e As EventArgs) Handles txtPrecioCompra.LostFocus
        Try
            Dim precioCompra As Decimal
            txtPrecioCompra.Text = Decimal.Parse(Replace(txtPrecioCompra.Text, ",", "."), CultureInfo.InvariantCulture)

            CalcularPrecioLista()
            precioCompra = txtPrecioCompra.Text
            txtPrecioCompra.Text = Convert.ToDecimal(precioCompra).ToString("N2")
        Catch
            txtPrecioCompra.Text = 0
        End Try
    End Sub

    Private Sub txtUtilidad_LostFocus(sender As Object, e As EventArgs) Handles txtUtilidad.LostFocus
        Try
            Dim utilidad As Decimal
            txtUtilidad.Text = Decimal.Parse(Replace(txtUtilidad.Text, ",", "."), CultureInfo.InvariantCulture)

            CalcularPrecioLista()
            utilidad = txtUtilidad.Text
            txtUtilidad.Text = Math.Round(Convert.ToDecimal(utilidad), 2).ToString("N2")
        Catch
            txtPrecioCompra.Text = 0
            txtUtilidad.Text = 0
        End Try
    End Sub

    Private Sub txtPrecioLista_LostFocus(sender As Object, e As EventArgs) Handles txtPrecioLista.LostFocus
        Try
            Dim precioLista
            txtPrecioLista.Text = Decimal.Parse(Replace(txtPrecioLista.Text, ",", "."), CultureInfo.InvariantCulture)

            CalcularUtilidad()
            precioLista = txtPrecioLista.Text
            txtPrecioLista.Text = Convert.ToDecimal(precioLista).ToString("N2")
        Catch
        End Try
    End Sub

    Private Sub CalcularPrecioLista()
        Dim precioCompra As Decimal
        Dim utilidad As Decimal

        If Decimal.TryParse(txtPrecioCompra.Text, precioCompra) AndAlso Decimal.TryParse(txtUtilidad.Text, utilidad) Then
            Dim precioLista As Decimal = precioCompra * (utilidad / 100 + 1)

            txtPrecioLista.Text = Convert.ToDecimal(precioLista).ToString("N2")
        Else
            txtPrecioLista.Text = String.Empty
        End If
    End Sub

    Private Sub CalcularUtilidad()
        Dim precioCompra As Decimal
        Dim precioLista As Decimal

        If Decimal.TryParse(txtPrecioCompra.Text, precioCompra) AndAlso Decimal.TryParse(txtPrecioLista.Text, precioLista) Then
            If precioCompra > 0 Then
                ' Calcular la utilidad como un porcentaje
                Dim utilidad As Decimal = ((precioLista / precioCompra) - 1) * 100

                txtUtilidad.Text = Convert.ToDecimal(utilidad)
                '.ToString("N2") si agrego esto al final de la linea anterior lo
            Else
                txtUtilidad.Text = String.Empty
            End If
        Else
            txtUtilidad.Text = String.Empty
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
        Else
            cboOriginal.SelectedIndex = -1
            cboOriginal.Enabled = False
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
        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c Then
            Dim textBox = DirectCast(sender, TextBox)
            If (e.KeyChar = "."c) AndAlso (textBox.Text.Contains(".")) Then
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

    Public Sub AgregarValidacionATextBox(textBox As TextBox)
        If Not txtsConDecimales.Contains(textBox) Then
            txtsConDecimales.Add(textBox)
            AddHandler textBox.KeyPress, AddressOf ValidarNumeroDecimal

        End If
    End Sub

    Private Sub lblCodBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lblCodBarra.KeyPress
        If Char.IsDigit(e.KeyChar) Then

            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNombreDiario.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using frmProbandoArbol As New ProbandoArbol(Me)
            If frmProbandoArbol.ShowDialog() = DialogResult.OK Then
                ' El valor ya se ha establecido en txtUbicacion
                ' Puedes realizar aquí cualquier otra acción necesaria después de cerrar el diálogo
            End If
        End Using
    End Sub
#End Region

#Region "Buscar"
    Private Sub Filtrar_Grilla()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")
            conexion.Open()

            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "Cargar_Grilla_Producto"

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            ' Filtrar por nombre o apellido
            If oDs.Tables(0).Rows.Count > 0 Then
                Dim dt As DataTable = oDs.Tables(0)
                Dim filtro As String = txtBuscar.Text.Trim()

                If Not String.IsNullOrEmpty(filtro) Then
                    Dim dv As New DataView(dt)
                    dv.RowFilter = String.Format(
                     "CONVERT([N° Producto], 'System.String') LIKE '%{0}%' OR Producto LIKE '%{0}%' OR [Nombre Diario] LIKE '%{0}%' OR Marca LIKE '%{0}%' OR CONVERT([Stock Real],
                     'System.String') LIKE '%{0}%' OR CONVERT([Stock Disponible], 'System.String') LIKE '%{0}%' OR CONVERT([Stock Minimo], 'System.String') LIKE '%{0}%' OR CONVERT([Precio Lista], 'System.String') LIKE '%{0}%' OR Ubicacion LIKE '%{0}%'", filtro)
                    grdProductos.DataSource = dv
                Else
                    grdProductos.DataSource = dt
                End If

                grdProductos.Refresh()
            Else
                MsgBox("No se encontraron datos para mostrar.", vbInformation, "Información")
            End If

            oDs = Nothing
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al filtrar la grilla: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Filtrar_Grilla()
    End Sub

#End Region

End Class