Module TemaGlobal
    ' Colores del Modo Claro
    Public ModoClaroFondo As Color = Color.FromArgb(201, 201, 201)
    Public ModoClaroTexto As Color = Color.Black

    Public ModoClaroPanelNav As Color = Color.FromArgb(147, 147, 147)
    Public ModoClaroCboNav As Color = Color.FromArgb(174, 174, 174)

    ' Colores del Modo Oscuro
    Public ModoOscuroFondo As Color = Color.FromArgb(39, 39, 39)
    Public ModoOscuroTexto As Color = Color.White

    Public ModoOscuroPanelNav As Color = Color.FromArgb(65, 65, 65)
    Public ModoOscuroCboNav As Color = Color.FromArgb(91, 91, 91)

    ' Variable para identificar el modo actual
    Public ModoActualOscuro As Boolean = False

    ' Alterna el tema (modo oscuro/claro)
    Public Sub CambiarTema()
        ModoActualOscuro = Not ModoActualOscuro
    End Sub

    Public Sub AplicarTemaControles(controls As Control.ControlCollection, colorTexto As Color, colorFondo As Color, colorBoton As Color)
        For Each ctrl As Control In controls
            If TypeOf ctrl Is Panel AndAlso ctrl.Name = "PanelMenu" Then
                ' Asignar colores específicos al panel
                ctrl.BackColor = If(ModoActualOscuro, ModoOscuroPanelNav, ModoClaroPanelNav)

                ' Aplicar el tema a los controles dentro del panel
                AplicarTemaControles(ctrl.Controls, colorTexto, colorFondo, If(ModoActualOscuro, ModoOscuroPanelNav, ModoClaroPanelNav))

            ElseIf TypeOf ctrl Is Panel AndAlso (ctrl.Name = "PanelCboTableroControl" OrElse ctrl.Name = "PanelCboGestion") Then
                ' Asignar colores específicos a los paneles PanelCboTableroControl y PanelCboGestion
                ctrl.BackColor = If(ModoActualOscuro, ModoOscuroCboNav, ModoClaroCboNav)

                ' Aplicar el borde en el evento Paint
                RemoveHandler ctrl.Paint, AddressOf Panel_Paint
                AddHandler ctrl.Paint, AddressOf Panel_Paint

                ' Refresca el panel para forzar el redibujo
                ctrl.Invalidate()

                ' Aplicar el tema a los controles dentro del panel
                AplicarTemaControles(ctrl.Controls, colorTexto, colorFondo, If(ModoActualOscuro, ModoOscuroCboNav, ModoClaroFondo))

            ElseIf TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                If btn.Parent.Name = "PanelCboTableroControl" OrElse btn.Parent.Name = "PanelCboGestion" Then
                    ' Si el botón está dentro de PanelCboTableroControl o PanelCboGestion, usar ModoOscuroCboNav
                    btn.BackColor = If(ModoActualOscuro, ModoOscuroCboNav, ModoClaroCboNav)
                    btn.FlatAppearance.BorderColor = If(ModoActualOscuro, ModoOscuroCboNav, ModoClaroCboNav)
                    btn.FlatStyle = FlatStyle.Flat
                ElseIf btn.Parent IsNot Nothing AndAlso btn.Parent.Name = "PanelMenu" Then
                    btn.BackColor = If(ModoActualOscuro, ModoOscuroPanelNav, ModoClaroPanelNav)
                Else
                    btn.BackColor = colorBoton
                End If
                btn.ForeColor = colorTexto

                ' Aplicar el borde en el evento Paint solo si está en los paneles específicos
                If btn.Parent.Name = "PanelCboTableroControl" OrElse btn.Parent.Name = "PanelCboGestion" Then
                    RemoveHandler btn.Paint, AddressOf Button_Paint ' Elimina el manejador previo si existe
                    AddHandler btn.Paint, AddressOf Button_Paint
                End If

            ElseIf TypeOf ctrl Is TextBox Then
                ' Mantener los TextBox siempre blancos
                ctrl.BackColor = Color.White
                ctrl.ForeColor = colorTexto

            ElseIf TypeOf ctrl Is Label OrElse TypeOf ctrl Is RadioButton OrElse TypeOf ctrl Is CheckBox Then
                ctrl.ForeColor = colorTexto

            ElseIf TypeOf ctrl Is DataGridView Then
                ' Aplicar tema al DataGridView
                Dim grid As DataGridView = DirectCast(ctrl, DataGridView)
                grid.BackgroundColor = colorFondo
                grid.ColumnHeadersDefaultCellStyle.BackColor = colorFondo
                grid.RowHeadersDefaultCellStyle.BackColor = colorFondo

            ElseIf TypeOf ctrl Is DataVisualization.Charting.Chart Then
                ' Cambiar el color del gráfico según el tema
                Dim chart As DataVisualization.Charting.Chart = DirectCast(ctrl, DataVisualization.Charting.Chart)
                chart.BackColor = colorFondo
                chart.ForeColor = colorTexto

                ' Cambiar el color de las áreas del gráfico y los ejes
                For Each area As DataVisualization.Charting.ChartArea In chart.ChartAreas
                    area.BackColor = colorFondo
                    area.AxisX.LabelStyle.ForeColor = colorTexto
                    area.AxisY.LabelStyle.ForeColor = colorTexto
                    area.AxisX.TitleForeColor = colorTexto ' Cambiar el color del título del eje X
                    area.AxisY.TitleForeColor = colorTexto ' Cambiar el color del título del eje Y
                    area.AxisX.LineColor = colorTexto
                    area.AxisY.LineColor = colorTexto
                    area.AxisX.MajorGrid.LineColor = colorTexto
                    area.AxisY.MajorGrid.LineColor = colorTexto
                Next

                ' Cambiar el color de las series
                For Each series As DataVisualization.Charting.Series In chart.Series
                    series.LabelForeColor = colorTexto
                Next

                ' Cambiar el color de las leyendas
                For Each legend As DataVisualization.Charting.Legend In chart.Legends
                    legend.BackColor = colorFondo
                    legend.ForeColor = colorTexto
                    legend.TitleForeColor = colorTexto ' Cambiar el color del título de la leyenda
                Next

                ' Cambiar el color de los títulos del gráfico
                For Each title As DataVisualization.Charting.Title In chart.Titles
                    title.ForeColor = colorTexto
                Next
            End If

            ' Si el control es un contenedor (Panel, GroupBox, etc.), aplicar el tema a los controles hijos
            If ctrl.HasChildren Then
                AplicarTemaControles(ctrl.Controls, colorTexto, colorFondo, colorBoton)
            End If
        Next
    End Sub

    ' Aplica el tema en un formulario específico
    Public Sub AplicarTema(form As Form)
        Dim colorFondo As Color
        Dim colorTexto As Color = If(ModoActualOscuro, ModoOscuroTexto, ModoClaroTexto)
        Dim colorBoton As Color = If(ModoActualOscuro, ModoOscuroPanelNav, ModoClaroFondo)

        Select Case form.Name
            Case "frmAgregarCiudad", "frmAgregarDatosFiscales", "frmAgregarDetalleFormaPago", "frmAgregarEmpleados", "frmAgregarFormaEntrega",
                 "frmAgregarFormaPago", "frmAgregarMarca", "frmAgregarPedidoRepuesto", "frmAgregarRoles", "frmAgregarRubro",
                 "frmAgregarSeccion", "frmAgregarTipoVehiculo", "frmAgregarTipoVenta", "frmUbicacion"
                colorFondo = If(ModoActualOscuro, Color.FromArgb(91, 91, 91), Color.FromArgb(147, 147, 147))
            Case Else
                colorFondo = If(ModoActualOscuro, ModoOscuroFondo, ModoClaroFondo)
        End Select

        form.BackColor = colorFondo

        AplicarTemaControles(form.Controls, colorTexto, colorFondo, colorBoton)
    End Sub

    Private Sub Panel_Paint(sender As Object, e As PaintEventArgs)
        Dim panel As Panel = DirectCast(sender, Panel)
        Dim borderColor As Color = If(ModoActualOscuro, ModoOscuroCboNav, ModoClaroCboNav)

        ' Dibuja el borde
        e.Graphics.DrawRectangle(New Pen(borderColor, 2), 0, 0, panel.Width - 1, panel.Height - 1)
    End Sub

    Private Sub Button_Paint(sender As Object, e As PaintEventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim borderColor As Color = If(ModoActualOscuro, ModoOscuroCboNav, ModoClaroCboNav)

        ' Dibuja el borde
        e.Graphics.DrawRectangle(New Pen(borderColor, 2), 0, 0, button.Width - 1, button.Height - 1)
    End Sub

    ' Aplica el tema en todos los formularios abiertos
    Public Sub AplicarTemaEnTodosLosFormularios()
        For Each form As Form In Application.OpenForms
            AplicarTema(form)
        Next
    End Sub
End Module

