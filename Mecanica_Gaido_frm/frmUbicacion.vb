Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Configuration
Imports m

Public Class frmUbicacion
    Private frmProductoParent As frmProductos

    ' Constructor que acepta el formulario padre
    Public Sub New(frmProductoParent As frmProductos)
        InitializeComponent()
        Me.frmProductoParent = frmProductoParent
    End Sub

    Private Sub ProbandoArbol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTreeView()
        AplicarTema(Me)
        cargarGrilla()
    End Sub
    Private Sub cargarGrilla()
        Dim ds As New DataSet
        Dim oUbi As New AD_Ubicacion
        Try
            ds = oUbi.BuscarDepositos()
            If ds.Tables(0).Rows.Count > 0 Then
                grdDepositos.AutoGenerateColumns = True
                grdDepositos.DataSource = ds.Tables(0)
            End If

        Catch
            MsgBox("Error en la conexión a la Base de Datos")
        End Try

    End Sub
    Private Sub grdDepositos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdDepositos.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = grdDepositos.Rows(e.RowIndex)
            Dim id_Depo As Integer
            btnD_Modificar.Enabled = True

            If selectedRow.Cells("Nro").Value IsNot Nothing Then
                id_Depo = Convert.ToInt32(selectedRow.Cells("Nro").Value)
                CargarDatosEnTxt(id_Depo)

            Else
                MsgBox("El ID del Depósito no puede ser nulo.", vbCritical, "Error")
            End If
        End If
        chkEstado.Visible = True
        btnD_Aceptar.Enabled = False
    End Sub

    Private Sub CargarDatosEnTxt(id_Depo)

        Dim oUbi As New AD_Ubicacion
        Dim ds As New DataSet
        Try
            ds = oUbi.BuscarDepositoPorID(id_Depo)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim fila As DataRow = ds.Tables(0).Rows(0)
                chkEstado.Visible = True
                chkEstado.Checked = Convert.ToBoolean(fila("Estado"))
                txtNombreDeposito.Text = fila("Nombre").ToString()
                NumEstanterias.Value = Convert.ToInt32(fila("Cant_Estanterias"))
                NumColumnas.Value = Convert.ToInt32(fila("Cant_Columnas"))
                NumFilas.Value = Convert.ToInt32(fila("Cant_Filas"))
                txtID.Text = Convert.ToInt32(fila("ID_Deposito"))
            Else
                MsgBox("No se encontraron Depósitos", vbInformation, "Error")
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al consultar el Depósito: " & ex.Message, "Error")
        End Try
        ds.Clear()
    End Sub
    Private Sub PopulateTreeView()
        treeViewCodDep.Nodes.Clear()

        ' Obtener los datos (esto es un ejemplo, deberías reemplazarlo con tu fuente de datos real)
        Dim datos As List(Of DatoDeposito) = ObtenerDatos()

        For Each dato In datos
            Dim lugarNode As TreeNode = FindOrCreateNode(treeViewCodDep.Nodes, dato.Lugar)
            Dim estanteriaNode As TreeNode = FindOrCreateNode(lugarNode.Nodes, dato.Estanteria)
            Dim columnaNode As TreeNode = FindOrCreateNode(estanteriaNode.Nodes, dato.Columna)
            Dim filaNode As TreeNode = FindOrCreateNode(columnaNode.Nodes, dato.Fila)

            ' Almacenar el COD Dep en el Tag del nodo
            filaNode.Tag = dato.CodDep
        Next
    End Sub

    Private Function FindOrCreateNode(nodes As TreeNodeCollection, key As String) As TreeNode
        For Each node As TreeNode In nodes
            If node.Text = key Then
                Return node
            End If
        Next
        Return nodes.Add(key)
    End Function

    Private Sub treeViewCodDep_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles treeViewCodDep.NodeMouseClick
        If e.Node.Tag IsNot Nothing Then
            txtCodDep.Text = e.Node.Tag.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrEmpty(txtCodDep.Text) Then
            ' Pasar el valor al txtUbicacion en frmproducto
            If frmProductoParent IsNot Nothing AndAlso Not frmProductoParent.IsDisposed Then
                frmProductoParent.txtUbicacion.Text = txtCodDep.Text
            End If

            ' Limpiar txtCodDep
            txtCodDep.Clear()

            ' Cerrar el formulario
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Por favor, seleccione una ubicación primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Function ObtenerDatos() As List(Of DatoDeposito)
        Dim resultado As New List(Of DatoDeposito)

        ' Obtener la cadena de conexión desde App.config
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("Conn").ConnectionString
        Dim conexion As New SqlConnection(connectionString)

        Dim comando As New SqlCommand("Consultar_DepositosActivos", conexion)
        comando.CommandType = CommandType.StoredProcedure

        Try
            conexion.Open()
            Dim reader As SqlDataReader = comando.ExecuteReader()

            While reader.Read()
                Dim deposito As String = reader("Nombre").ToString()
                Dim cantEstanterias As Integer = Convert.ToInt32(reader("Cant_Estanterias"))
                Dim cantColumnas As Integer = Convert.ToInt32(reader("Cant_Columnas"))
                Dim cantFilas As Integer = Convert.ToInt32(reader("Cant_Filas"))

                ' Generar datos para cada estantería
                For estanteria As Integer = 0 To cantEstanterias - 1
                    Dim nombreEstanteria As String = $"Estantería {Convert.ToChar(65 + estanteria)}"

                    ' Generar datos para cada columna
                    For columna As Integer = 1 To cantColumnas
                        ' Generar datos para cada fila
                        For fila As Integer = 1 To cantFilas
                            ' Crear el código único
                            Dim codigo As String = $"{deposito.Substring(0, 2).ToUpper}.{Convert.ToChar(65 + estanteria)}.{columna}.{fila}"

                            ' Agregar el nuevo dato a la lista
                            resultado.Add(New DatoDeposito(
                            deposito,
                            nombreEstanteria,
                            $"Columna {columna}",
                            $"Fila {fila}",
                            codigo))
                        Next
                    Next
                Next
            End While

        Catch ex As Exception
            MessageBox.Show($"Error al obtener datos: {ex.Message}")
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try

        Return resultado
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiarDepo()
        Me.Close()
    End Sub

    Private Sub limpiarDepo()
        chkEstado.Visible = False
        txtID.Text = ""
        txtNombreDeposito.Text = ""
        NumEstanterias.Value = 1
        NumColumnas.Value = 1
        NumFilas.Value = 1
    End Sub
    Private Sub btnD_Aceptar_Click(sender As Object, e As EventArgs) Handles btnD_Aceptar.Click
        Dim oUbi As New AD_Ubicacion

        Try
            If txtNombreDeposito.Text <> Nothing AndAlso NumEstanterias.Value > 0 AndAlso NumColumnas.Value > 0 AndAlso NumFilas.Value > 0 Then
                oUbi.Agregar_Deposito(txtNombreDeposito.Text, CInt(NumEstanterias.Value), CInt(NumColumnas.Value), CInt(NumFilas.Value), True)
                cargarGrilla()
                limpiarDepo()
                MsgBox("Depósito cargado correctamente", vbInformation, "Depósitos")
            Else
                MsgBox("No se pudo cargar el depósito", vbCritical, "Error")
            End If
        Catch ex As Exception
            MsgBox("Error al agregar el depósito: " & ex.Message, vbCritical, "Error")
        End Try
        Call ProbandoArbol_Load(sender, e)
    End Sub

    Private Sub btnD_Modificar_Click(sender As Object, e As EventArgs) Handles btnD_Modificar.Click
        Dim oUbi As New AD_Ubicacion

        Try
            If txtID.Text <> Nothing AndAlso txtNombreDeposito.Text <> Nothing AndAlso NumEstanterias.Value > 0 AndAlso NumColumnas.Value > 0 AndAlso NumFilas.Value > 0 Then
                oUbi.Modificar_Deposito(txtID.Text, txtNombreDeposito.Text, NumEstanterias.Value, NumColumnas.Value, NumFilas.Value, chkEstado.Checked)
                cargarGrilla()
                limpiarDepo()

                MsgBox("Depósito modificado correctamente", vbInformation, "Depósitos")
            Else
                MsgBox("No se pudo modificar el depósito", vbCritical, "Error")
            End If
        Catch ex As Exception
            MsgBox("Error al modificar el depósito: " & ex.Message, vbCritical, "Error")
        End Try
        Call ProbandoArbol_Load(sender, e)
    End Sub
End Class



