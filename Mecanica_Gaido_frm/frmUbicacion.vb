
Imports System.Windows.Forms

Public Class frmUbicacion
    Private frmProductoParent As frmProductos

    ' Constructor que acepta el formulario padre
    Public Sub New(frmProductoParent As frmProductos)
        InitializeComponent()
        Me.frmProductoParent = frmProductoParent
    End Sub

    Private Sub ProbandoArbol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTreeView()

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
        ' Aquí deberías implementar la lógica para obtener tus datos reales
        ' Por ahora, devolveré una lista de ejemplo
        Return New List(Of DatoDeposito) From {
            New DatoDeposito("Taller", "Estantería A", "Columna 1", "Fila 1", "TA.A.1.1"),
                New DatoDeposito("Taller", "Estantería A", "Columna 2", "Fila 1", "TA.A.2.1"),
                New DatoDeposito("Taller", "Estantería B", "Columna 1", "Fila 1", "TA.B.1.1"),
                New DatoDeposito("Taller", "Estantería B", "Columna 1", "Fila 2", "TA.B.1.2"),
                New DatoDeposito("Taller", "Estantería C", "Columna 1", "Fila 1", "TA.C.1.1"),
                New DatoDeposito("Taller", "Estantería C", "Columna 2", "Fila 1", "TA.C.2.1")
        }
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

Public Class DatoDeposito
    Public Property Lugar As String
    Public Property Estanteria As String
    Public Property Columna As String
    Public Property Fila As String
    Public Property CodDep As String

    Public Sub New(lugar As String, estanteria As String, columna As String, fila As String, codDep As String)
        Me.Lugar = lugar
        Me.Estanteria = estanteria
        Me.Columna = columna
        Me.Fila = fila
        Me.CodDep = codDep
    End Sub
End Class

