Imports System.Data
Imports AD_Mecanica_Gaido
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmAgregarCuentas
    Dim o_Cuentas As New AD_Cuentas

#Region "Procedimientos"
    Public Sub limpiar()
        txtID.Clear()
        txtIngresosBrutos.Clear()
        txtSaldo.Clear()
        dtpFechaAlta.Value = DateTime.Today
        chkEstado.Checked = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
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
            txtIngresosBrutos.Text = grdCuenta.Rows(rowindex).Cells("Ingresos Brutos").Value.ToString()

            txtSaldo.Text = grdCuenta.Rows(rowindex).Cells("Saldo").Value.ToString()
            chkEstado.Checked = grdCuenta.Rows(rowindex).Cells("Estado").Value.ToString()

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
                o_Cuentas.Agregar_Persona(txtIngresosBrutos.Text, dtpFechaAlta.Value, txtSaldo.Text, chkEstado.Checked)

                MsgBox("Cuenta agregada correctamente.", vbInformation, "Información")
                limpiar()
                Cargar_Grilla()

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

#Region "Keypress"
    Private Sub txtCargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldo.KeyPress
        If Not Char.IsLetter(e.KeyChar) _
                 AndAlso Not Char.IsControl(e.KeyChar) _
                 AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSaldo_KeyPress(sender As Object, e As KeyPressEventArgs)
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