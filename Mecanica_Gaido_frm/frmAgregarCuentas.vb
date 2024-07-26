Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmAgregarCuentas
    Dim o_Cuentas As New AD_Cuentas

    ' Propiedades públicas para recibir los datos
    Public Property IdPersona As Integer
    Public Property NombrePersona As String
    Public Property DocumentoPersona As String

#Region "Procedimientos"
    Public Sub limpiar()
        txtID.Clear()
        txtIngresosBrutos.Clear()
        txtSaldo.Clear()
        dtpFechaAlta.Value = DateTime.Today
        chkEstado.Checked = False
    End Sub

    Private Sub frmAgregarCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        Cargar_Grilla()

        ' Usa las propiedades públicas para establecer los valores en los controles del formulario
        lblNombreResultado.Text = NombrePersona
        lblDocumentoResultado.Text = DocumentoPersona
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        lblNombreResultado.Text = Nothing
        lblDocumentoResultado.Text = Nothing
    End Sub

    Public Sub Cargar_Grilla()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_Cuenta")

            Dim datadapter As New SqlDataAdapter(comando)
            Dim oDs As New DataSet
            datadapter.Fill(oDs)

            If oDs.Tables(0).Rows.Count > 0 Then
                grdCuenta.AutoGenerateColumns = True
                grdCuenta.DataSource = oDs.Tables(0)

                ' Verificar si las columnas existen antes de ocultarlas
                Dim columnasParaOcultar As String() = {"Documento", "Estado"}
                For Each colName As String In columnasParaOcultar
                    If grdCuenta.Columns.Contains(colName) Then
                        grdCuenta.Columns(colName).Visible = False
                    End If
                Next

                grdCuenta.Refresh()
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

    Public Sub CargarDatosEnTxt(ByVal rowindex As Integer)
        If grdCuenta.Rows.Count > 0 Then

            txtID.Text = grdCuenta.Rows(rowindex).Cells("N° Cuenta").Value.ToString()
            lblNombreResultado.Text = grdCuenta.Rows(rowindex).Cells("Cuenta").Value.ToString()
            txtIngresosBrutos.Text = grdCuenta.Rows(rowindex).Cells("Ingresos Brutos").Value.ToString()
            dtpFechaAlta.Value = grdCuenta.Rows(rowindex).Cells("Fecha de Alta").Value
            txtSaldo.Text = grdCuenta.Rows(rowindex).Cells("Saldo").Value.ToString()
            chkEstado.Checked = grdCuenta.Rows(rowindex).Cells("Estado").Value.ToString()


            lblDocumentoResultado.Text = grdCuenta.Rows(rowindex).Cells("Documento").Value.ToString()
        End If
    End Sub

    Private Sub grdCuenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdCuenta.CellClick
        If e.RowIndex >= 0 Then
            CargarDatosEnTxt(e.RowIndex)
        End If
    End Sub
#End Region

#Region "Cargar"
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtIngresosBrutos.Text <> Nothing And txtSaldo.Text <> Nothing Then
            Try
                o_Cuentas.Agregar_Persona(IdPersona, txtIngresosBrutos.Text, dtpFechaAlta.Value, txtSaldo.Text)

                MsgBox("Cuenta agregada correctamente.", vbInformation, "Información")
                limpiar()
                Cargar_Grilla()
                lblNombreResultado.Text = Nothing
                lblDocumentoResultado.Text = Nothing

            Catch ex As Exception
                MsgBox("Error al agregar la cuenta: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete los datos correspondientes.", vbInformation, "Error")
        End If
    End Sub
#End Region

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


End Class