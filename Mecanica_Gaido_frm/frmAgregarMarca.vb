Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient

Public Class frmAgregarMarca

    Dim o_productos As New AD_Productos
    Dim o_marca As New AD_Marca


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtMarca.Text <> Nothing Then

            Try
                Dim marca As String = txtMarca.Text
                Dim estado As Boolean = chkEstado.Checked

                o_marca.Agregar_Marca(marca, estado)
                MsgBox("Marca agregada correctamente.", vbInformation, "Información")
                'limpiar()

            Catch ex As Exception
                MsgBox("Error al agregar la marca: " & ex.Message, vbCritical, "Error")
                'limpiar()
            End Try
        Else
            MsgBox("Complete Datos", vbInformation, "Error")
            'limpiar()
        End If
    End Sub



    'Public Sub Cargar_Grilla_Marcas()
    'Dim conexion As SqlConnection
    'Dim comando As New SqlCommand

    ' conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

    ' conexion.Open()
    'comando.Connection = conexion
    'comando.CommandType = CommandType.StoredProcedure
    ' comando.CommandText = ("Cargar_Grilla_Marcas")

    ' datadapter As New SqlDataAdapter(comando)
    'Dim oDs As New DataSet
    '  datadapter.Fill(oDs)

    'If oDs.Tables(0).Rows.Count > 0 Then
    '     grdGrilla.AutoGenerateColumns = True
    '     grdGrilla.DataSource = oDs.Tables(0)
    '     grdGrilla.Refresh()
    'End If

    '  oDs = Nothing
    '  conexion.Close()
    ' End Sub

    Private Sub frmAgregarMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar_Grilla_Marcas()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim nombreMarca As String = txtMarca.Text
            Dim estados As Boolean = chkEstado.Checked

            o_marca.Modificar_Marca(nombreMarca, estados)
            MsgBox("Marca modificada correctamente.", vbInformation, "Éxito")
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al modificar la Marca: " & ex.Message, vbCritical, "Error")
        End Try
    End Sub

End Class