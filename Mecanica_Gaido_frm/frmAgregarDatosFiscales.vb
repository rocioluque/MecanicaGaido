Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmAgregarDatosFiscales
    Dim o_DatosFiscales As New AD_DatosFiscales
    Public Property IdPersona As Integer

#Region "Procedimientos"
    Private Sub frmAgregarDatosFiscales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        Cargar_Grilla()
        If o_DatosFiscales.ControlarIdPersonaEnDatoFiscal(IdPersona) Then
            ' Si la persona ya es un empleado, deshabilitar el botón "Aceptar"
            btnAceptar.Enabled = False
            btnModificar.Enabled = True

            ' Cargar los datos del empleado para modificación
            CargarDatosPorIDPersona(IdPersona)
        Else
            ' Si no es un empleado, habilitar el botón "Aceptar"
            btnAceptar.Enabled = True
            btnModificar.Enabled = False
        End If

        If txtID.Text = Nothing Then
            chkEstado.Visible = False
        Else
            chkEstado.Visible = True
        End If
    End Sub

    Public Sub limpiar()
        txtID.Clear()
        txtIngresosBrutos.Clear()
        txtSaldo.Clear()
        dtpFechaAlta.Value = DateTime.Today
        chkEstado.Checked = False
        lblNombreResultado.Text = Nothing
        lblDocumentoResultado.Text = Nothing
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()

        btnAceptar.Enabled = True
        btnModificar.Enabled = False

        Me.Close()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        limpiar()
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

    Public Sub CargarDatosEnTxt(ByVal idDatoFiscal As Integer)
        Try
            Dim datoleido As SqlDataReader = o_DatosFiscales.Consultar_DatoFiscalPorID(idDatoFiscal)
            If datoleido.Read() Then
                txtID.Text = datoleido("N° Dato Fiscal").ToString()
                lblNombreResultado.Text = datoleido("Cuenta").ToString()
                txtIngresosBrutos.Text = datoleido("Ingresos Brutos").ToString()
                dtpFechaAlta.Value = Convert.ToDateTime(datoleido("Fecha de Alta"))
                txtSaldo.Text = datoleido("Saldo").ToString()
                chkEstado.Checked = datoleido("Estado").ToString()

                lblDocumentoResultado.Text = datoleido("Documento").ToString()

                btnAceptar.Enabled = False
                btnModificar.Enabled = True
            Else
                MsgBox("No se encontraron resultados", vbInformation, "Error")
            End If

            datoleido.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al consultar el dato fiscal: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub grdCuenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdCuenta.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = grdCuenta.Rows(e.RowIndex)
            Dim idDatoFiscal As Integer

            If selectedRow.Cells("N° Dato Fiscal").Value IsNot Nothing Then
                idDatoFiscal = Convert.ToInt32(selectedRow.Cells("N° Dato Fiscal").Value)
                CargarDatosEnTxt(idDatoFiscal)
            Else
                MsgBox("El ID del dato fiscal no puede ser nulo.", vbCritical, "Error")
            End If
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

            Catch ex As Exception
                MsgBox("Error al agregar el dato fiscal: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete los datos correspondientes.", vbInformation, "Error")
        End If
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtIngresosBrutos.Text <> Nothing And txtSaldo.Text <> Nothing Then
            Try
                o_DatosFiscales.Modificar_DatoFiscal(Convert.ToInt32(txtID.Text), txtIngresosBrutos.Text, dtpFechaAlta.Value,
                                                        txtSaldo.Text, chkEstado.Checked)


                MsgBox("Dato Fiscal modificado correctamente.", vbInformation, "Información")
                limpiar()
                Cargar_Grilla()

            Catch ex As Exception
                MsgBox("Error al modificar el dato fiscal: " & ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete los datos correspondientes.", vbInformation, "Error")
        End If
    End Sub

#End Region

#Region "Cargar datos de datos fiscales ya cargado"
    Public Sub CargarDatosPorIDPersona(ByVal idPersona As Integer)
        Try
            Dim datoleido As SqlDataReader = o_DatosFiscales.Consultar_DatoFiscalPorIDPersona(idPersona)

            If datoleido.Read() Then
                txtID.Text = datoleido("N° Dato Fiscal").ToString()
                lblNombreResultado.Text = datoleido("Cuenta").ToString()
                txtIngresosBrutos.Text = datoleido("Ingresos Brutos").ToString()
                dtpFechaAlta.Value = Convert.ToDateTime(datoleido("Fecha de Alta"))
                txtSaldo.Text = datoleido("Saldo").ToString()
                chkEstado.Checked = datoleido("Estado").ToString()

                lblDocumentoResultado.Text = datoleido("Documento").ToString()

                btnAceptar.Enabled = False
            End If
            datoleido.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al consultar el dato fiscal: " & ex.Message, "Error")
        End Try
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

    Private Sub chkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstado.CheckedChanged
        If txtID.Text = Nothing Then
            chkEstado.Visible = False
        Else
            chkEstado.Visible = True
        End If
    End Sub
#End Region
End Class