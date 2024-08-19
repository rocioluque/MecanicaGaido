Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmAgregarDatosFiscales
    Dim o_DatosFiscales As New AD_DatosFiscales
    Public Property IdPersona As Integer

#Region "Procedimientos"
    Public Sub limpiar()
        txtID.Clear()
        txtIngresosBrutos.Clear()
        txtSaldo.Clear()
        dtpFechaAlta.Value = DateTime.Today
        chkEstado.Checked = False
    End Sub

    Private Sub frmAgregarDatosFiscales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        Cargar_Grilla()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        lblNombreResultado.Text = Nothing
        lblDocumentoResultado.Text = Nothing
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
#End Region

#Region "Grilla y datos en txt"
    Public Sub Cargar_Grilla()
        Try
            Dim conexion As SqlConnection
            Dim comando As New SqlCommand

            conexion = New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = ("Cargar_Grilla_DatoFiscal")

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

            txtID.Text = grdCuenta.Rows(rowindex).Cells("N° Dato Fiscal").Value.ToString()
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
                o_DatosFiscales.Agregar_DatoFiscal(IdPersona, txtIngresosBrutos.Text, dtpFechaAlta.Value, txtSaldo.Text)

                MsgBox("Dato Fiscal agregado correctamente.", vbInformation, "Información")
                limpiar()
                Cargar_Grilla()
                lblNombreResultado.Text = Nothing
                lblDocumentoResultado.Text = Nothing

            Catch ex As Exception
                MsgBox("Error al agregar el dato fiscal: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete los datos correspondientes.", vbInformation, "Error")
        End If
    End Sub
#End Region

#Region "Css trucho"
    Private Sub PanelInformacionFiscal_Paint(sender As Object, e As PaintEventArgs) Handles PanelInformacionFiscal.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelInformacionFiscal.Width - 1, PanelInformacionFiscal.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub


    Private Sub PanelDetallesTributarios_Paint(sender As Object, e As PaintEventArgs) Handles PanelDetallesTributarios.Paint
        ' Configurar los colores y el grosor del borde
        Dim borderColor As Color = Color.SeaGreen
        Dim borderWidth As Integer = 1

        ' Crear un objeto Pen para dibujar el borde
        Using pen As New Pen(borderColor, borderWidth)
            ' Ajustar el área para dibujar el borde sin recortes
            Dim rect As New Rectangle(0, 0, PanelDetallesTributarios.Width - 1, PanelDetallesTributarios.Height - 1)
            e.Graphics.DrawRectangle(pen, rect)
        End Using
    End Sub
#End Region

#Region "Modificar"

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIngresosBrutos.Text <> Nothing And txtSaldo.Text <> Nothing Then
            Try
                ' Crear la conexión a la base de datos
                Using conn As New SqlConnection("Data Source=168.197.51.109;Initial Catalog=PIN_GRUPO31; UID=PIN_GRUPO31; PWD=PIN_GRUPO31123")

                    conn.Open()

                    ' Crear el comando para ejecutar el procedimiento almacenado
                    Using cmd As New SqlCommand("Modificar_DatoFiscal", conn)
                        cmd.CommandType = CommandType.StoredProcedure

                        ' Agregar los parámetros al comando
                        cmd.Parameters.AddWithValue("@idPersona", Convert.ToInt32(txtID.Text))
                        cmd.Parameters.AddWithValue("@IngresosBrutos", txtIngresosBrutos.Text)
                        cmd.Parameters.AddWithValue("@fechaAlta", dtpFechaAlta.Value)
                        cmd.Parameters.AddWithValue("@Saldo", Convert.ToDecimal(txtSaldo.Text))

                        ' Ejecutar el procedimiento almacenado
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' Mostrar mensaje 
                MsgBox("Dato Fiscal modificado correctamente.", vbInformation, "Información")
                limpiar()
                Cargar_Grilla()
                lblNombreResultado.Text = Nothing
                lblDocumentoResultado.Text = Nothing

            Catch ex As Exception
                MsgBox("Error al modificar el dato fiscal: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete los datos correspondientes.", vbInformation, "Error")
        End If
    End Sub

#End Region
End Class