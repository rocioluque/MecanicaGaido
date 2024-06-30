Public Class frmGestionDatos
    Private Sub AbrirFormHijo(formHijo As Object, sender As Button)
        '' Restablecer el color del botón anterior
        'If btnAnterior IsNot Nothing Then
        '    btnAnterior.BackColor = Color.FromArgb(65, 65, 65)
        'End If

        '' Actualizar el color del botón actual
        'btnAnterior = sender
        'sender.BackColor = Color.SeaGreen

        'Si el contenedor panelContenedor ya tiene controles hijos, elimina el primer control
        If Me.PanelPadre.Controls.Count > 0 Then
            Me.PanelPadre.Controls.RemoveAt(0)
        End If

        'Convierte el objeto formHijo a un tipo Form
        Dim fh As Form = TryCast(formHijo, Form)

        If fh IsNot Nothing Then
            'Esto indica que el formulario no es un formulario de nivel superior
            fh.TopLevel = False
            ' El formulario se ajustará al tamaño completo del contenedor
            fh.Dock = DockStyle.Fill
            'Agrega el formulario al contenedor
            Me.PanelPadre.Controls.Add(fh)
            'Almacena una referencia al formulario hijo en la propiedad Tag del contenedor.
            Me.PanelPadre.Tag = fh
            fh.Show()
            'Trae el formulario al frente de cualquier otro control
            fh.BringToFront()
        End If

        ' Si no se agregó ningún formulario hijo, pinta el botón "Inicio"
        If Me.PanelPadre.Controls.Count = 0 Then
            'PintarBotonInicio()
        End If
    End Sub

    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        AbrirFormHijo(New frmModificarMarca(), DirectCast(sender, Button))
    End Sub

    Private Sub btnRubro_Click(sender As Object, e As EventArgs) Handles btnRubro.Click
        AbrirFormHijo(New frmModificarRubros(), DirectCast(sender, Button))
    End Sub

    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        AbrirFormHijo(New frmModificarCiudades(), DirectCast(sender, Button))
    End Sub

    Private Sub btnRol_Click(sender As Object, e As EventArgs) Handles btnRol.Click
        AbrirFormHijo(New frmModificarRoles(), DirectCast(sender, Button))
    End Sub

    Private Sub btnSeccion_Click(sender As Object, e As EventArgs) Handles btnSeccion.Click
        AbrirFormHijo(New frmModificarSecciones(), DirectCast(sender, Button))
    End Sub

    Private Sub btnTipoVehiculos_Click(sender As Object, e As EventArgs) Handles btnTipoVehiculos.Click
        AbrirFormHijo(New frmModificarTipoVehiculos(), DirectCast(sender, Button))
    End Sub

    Private Sub btnTipoVenta_Click(sender As Object, e As EventArgs) Handles btnTipoVenta.Click
        AbrirFormHijo(New frmModificarTipoVenta(), DirectCast(sender, Button))
    End Sub

    Private Sub btnFormaPago_Click(sender As Object, e As EventArgs) Handles btnFormaPago.Click
        AbrirFormHijo(New frmModificarFormaPago(), DirectCast(sender, Button))
    End Sub

    Private Sub frmFormaEntrega_Click(sender As Object, e As EventArgs) Handles frmFormaEntrega.Click
        AbrirFormHijo(New frmModificarFormaEntrega(), DirectCast(sender, Button))
    End Sub
End Class