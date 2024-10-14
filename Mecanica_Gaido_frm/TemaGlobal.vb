Module TemaGlobal
    ' Colores del Modo Claro
    Public ModoClaroFondo As Color = Color.FromArgb(201, 201, 201)
    Public ModoClaroTexto As Color = Color.Black
    Public ModoClaroBoton As Color = Color.FromArgb(201, 201, 201)

    Public ModoClaroPanelNav As Color = Color.FromArgb(147, 147, 147)
    Public ModoClaroCboNav As Color = Color.FromArgb(174, 174, 174)
    Public ModoClaroBordePanel As Color = Color.FromArgb(174, 174, 174)

    ' Colores del Modo Oscuro
    Public ModoOscuroFondo As Color = Color.FromArgb(39, 39, 39)
    Public ModoOscuroTexto As Color = Color.White
    Public ModoOscuroBoton As Color = Color.FromArgb(39, 39, 39)

    Public ModoOscuroPanelNav As Color = Color.FromArgb(65, 65, 65)
    Public ModoOscuroCboNav As Color = Color.FromArgb(91, 91, 91)
    Public ModoOscuroBordePanel As Color = Color.FromArgb(91, 91, 91)
    Public ModoOscuroBotonPanel As Color = Color.FromArgb(65, 65, 65)

    ' Variable para identificar el modo actual
    Public ModoActualOscuro As Boolean = False

    ' Alterna el tema (modo oscuro/claro)
    Public Sub CambiarTema()
        ModoActualOscuro = Not ModoActualOscuro
    End Sub

    Private Sub AplicarTemaControles(controls As Control.ControlCollection, colorTexto As Color, colorFondo As Color, colorBoton As Color)
        'For Each ctrl As Control In controls
        '    If TypeOf ctrl Is Panel AndAlso ctrl.Name = "PanelMenu" Then
        '        ' Asignar colores específicos al panel
        '        ctrl.BackColor = If(ModoActualOscuro, ModoOscuroPanelNav, ModoClaroPanelNav)

        '        ' Aplicar el tema a los controles dentro del panel
        '        AplicarTemaControles(ctrl.Controls, colorTexto, colorFondo, colorBoton)

        '    ElseIf TypeOf ctrl Is Panel AndAlso (ctrl.Name = "PanelCboTableroControl" OrElse ctrl.Name = "PanelCboGestion") Then
        '        ' Asignar colores específicos a los paneles PanelCboTableroControl y PanelCboGestion
        '        ctrl.BackColor = If(ModoActualOscuro, ModoOscuroCboNav, ModoClaroCboNav)

        '        ' Aplicar el borde en el evento Paint
        '        RemoveHandler ctrl.Paint, AddressOf Panel_Paint ' Elimina el manejador previo si existe
        '        AddHandler ctrl.Paint, AddressOf Panel_Paint

        '        ' Refresca el panel para forzar el redibujo
        '        ctrl.Invalidate()

        '        ' Aplicar el tema a los controles dentro del panel
        '        AplicarTemaControles(ctrl.Controls, colorTexto, colorFondo, If(ModoActualOscuro, ModoOscuroCboNav, ModoClaroBoton))

        '    ElseIf TypeOf ctrl Is Button Then
        '        ' Cambiar el color del botón según el tema
        '        Dim btn As Button = DirectCast(ctrl, Button) ' Convertir a Button
        '        If btn.Parent.Name = "PanelCboTableroControl" OrElse btn.Parent.Name = "PanelCboGestion" Then
        '            ' Si el botón está dentro de PanelCboTableroControl o PanelCboGestion, usar ModoOscuroCboNav
        '            btn.BackColor = If(ModoActualOscuro, ModoOscuroCboNav, ModoClaroCboNav)
        '            btn.FlatAppearance.BorderColor = If(ModoActualOscuro, ModoOscuroBordePanel, ModoClaroBordePanel) ' Asignar el color del borde
        '            btn.FlatStyle = FlatStyle.Flat ' Asegúrate de que el estilo del botón sea plano para que se vea el borde
        '        Else
        '            btn.BackColor = colorBoton ' Vuelve al estilo estándar si no está en los paneles deseados
        '        End If
        '        btn.ForeColor = colorTexto

        '        ' Aplicar el borde en el evento Paint solo si está en los paneles específicos
        '        If btn.Parent.Name = "PanelCboTableroControl" OrElse btn.Parent.Name = "PanelCboGestion" Then
        '            RemoveHandler btn.Paint, AddressOf Button_Paint ' Elimina el manejador previo si existe
        '            AddHandler btn.Paint, AddressOf Button_Paint
        '        End If

        '    ElseIf TypeOf ctrl Is TextBox Then
        '        ' Mantener los TextBox siempre blancos
        '        ctrl.BackColor = Color.White
        '        ctrl.ForeColor = colorTexto

        '    ElseIf TypeOf ctrl Is Label OrElse TypeOf ctrl Is RadioButton OrElse TypeOf ctrl Is CheckBox Then
        '        ctrl.ForeColor = colorTexto

        '    ElseIf TypeOf ctrl Is DataGridView Then
        '        ' Aplicar tema al DataGridView
        '        Dim grid As DataGridView = DirectCast(ctrl, DataGridView)
        '        grid.BackgroundColor = colorFondo
        '        grid.ColumnHeadersDefaultCellStyle.BackColor = colorFondo
        '        grid.RowHeadersDefaultCellStyle.BackColor = colorFondo
        '    End If

        '    ' Si el control es un contenedor (Panel, GroupBox, etc.), aplicar el tema a los controles hijos
        '    If ctrl.HasChildren Then
        '        AplicarTemaControles(ctrl.Controls, colorTexto, colorFondo, colorBoton)
        '    End If
        'Next
    End Sub

    ' Aplica el tema en un formulario específico
    Public Sub AplicarTema(form As Form)
        'Dim colorFondo As Color = If(ModoActualOscuro, ModoOscuroBoton, ModoClaroBoton)
        'Dim colorTexto As Color = If(ModoActualOscuro, ModoOscuroTexto, ModoClaroTexto)
        'Dim colorBoton As Color = If(ModoActualOscuro, ModoOscuroBotonPanel, ModoClaroBoton)
        'Dim bordeColor As Color = If(ModoActualOscuro, ModoOscuroBordePanel, ModoClaroBordePanel)

        'form.BackColor = If(ModoActualOscuro, ModoOscuroFondo, ModoClaroFondo)

        '' Aplicar tema a todos los controles del formulario
        'AplicarTemaControles(form.Controls, colorTexto, colorFondo, colorBoton)
    End Sub

    Private Sub Panel_Paint(sender As Object, e As PaintEventArgs)
        'Dim panel As Panel = DirectCast(sender, Panel)
        'Dim borderColor As Color = If(ModoActualOscuro, ModoOscuroBordePanel, ModoClaroBordePanel)

        '' Dibuja el borde
        'e.Graphics.DrawRectangle(New Pen(borderColor, 2), 0, 0, panel.Width - 1, panel.Height - 1)
    End Sub

    Private Sub Button_Paint(sender As Object, e As PaintEventArgs)
        'Dim button As Button = DirectCast(sender, Button)
        'Dim borderColor As Color = If(ModoActualOscuro, ModoOscuroBordePanel, ModoClaroBordePanel)

        '' Dibuja el borde
        'e.Graphics.DrawRectangle(New Pen(borderColor, 2), 0, 0, button.Width - 1, button.Height - 1)
    End Sub

    ' Aplica el tema en todos los formularios abiertos
    Public Sub AplicarTemaEnTodosLosFormularios()
        'For Each form As Form In Application.OpenForms
        '    AplicarTema(form)
        'Next
    End Sub
End Module
