Module TemaGlobal
    ' Colores del Modo Claro
    Public ModoClaroFondo As Color = Color.FromArgb(201, 201, 201)
    Public ModoClaroTexto As Color = Color.Black
    Public ModoClaroBoton As Color = Color.FromArgb(201, 201, 201)

    ' Colores del Modo Oscuro
    Public ModoOscuroFondo As Color = Color.FromArgb(39, 39, 39)
    Public ModoOscuroTexto As Color = Color.White
    Public ModoOscuroBoton As Color = Color.FromArgb(39, 39, 39)

    ' Variable para identificar el modo actual
    Public ModoActualOscuro As Boolean = False

    ' Función para alternar el tema (modo oscuro/claro)
    Public Sub CambiarTema()
        ModoActualOscuro = Not ModoActualOscuro
    End Sub

    ' Sub para aplicar el tema en un formulario específico
    Public Sub AplicarTema(form As Form)
        If ModoActualOscuro Then
            ' Aplicar Modo Oscuro
            form.BackColor = ModoOscuroFondo
            For Each ctrl As Control In form.Controls
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = ModoOscuroBoton
                    ctrl.ForeColor = ModoOscuroTexto
                ElseIf TypeOf ctrl Is Label Then
                    ctrl.ForeColor = ModoOscuroTexto
                ElseIf TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                    ctrl.BackColor = ModoOscuroBoton
                    ctrl.ForeColor = ModoOscuroTexto
                End If
            Next
        Else
            ' Aplicar Modo Claro
            form.BackColor = ModoClaroFondo
            For Each ctrl As Control In form.Controls
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = ModoClaroBoton
                    ctrl.ForeColor = ModoClaroTexto
                ElseIf TypeOf ctrl Is Label Then
                    ctrl.ForeColor = ModoClaroTexto
                ElseIf TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                    ctrl.BackColor = ModoClaroBoton
                    ctrl.ForeColor = ModoClaroTexto
                End If
            Next
        End If
    End Sub

    ' Sub para aplicar el tema en todos los formularios abiertos
    Public Sub AplicarTemaEnTodosLosFormularios()
        For Each form As Form In Application.OpenForms
            AplicarTema(form)
        Next
    End Sub

End Module
