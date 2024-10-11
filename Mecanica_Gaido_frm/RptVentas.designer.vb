Partial Class RptVentas

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptVentas))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox53 = New Telerik.Reporting.TextBox()
        Me.TextBox54 = New Telerik.Reporting.TextBox()
        Me.TextBox56 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.Shape28 = New Telerik.Reporting.Shape()
        Me.Shape16 = New Telerik.Reporting.Shape()
        Me.Shape29 = New Telerik.Reporting.Shape()
        Me.Shape15 = New Telerik.Reporting.Shape()
        Me.TextBox72 = New Telerik.Reporting.TextBox()
        Me.TextBox50 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox47 = New Telerik.Reporting.TextBox()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.TextBox49 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.ReportFooterSection1 = New Telerik.Reporting.ReportFooterSection()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.ReportHeaderSection1 = New Telerik.Reporting.ReportHeaderSection()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.Shape8 = New Telerik.Reporting.Shape()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.TextBox55 = New Telerik.Reporting.TextBox()
        Me.TextBox59 = New Telerik.Reporting.TextBox()
        Me.TextBox60 = New Telerik.Reporting.TextBox()
        Me.TextBox61 = New Telerik.Reporting.TextBox()
        Me.TextBox62 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox51 = New Telerik.Reporting.TextBox()
        Me.TextBox52 = New Telerik.Reporting.TextBox()
        Me.TextBox66 = New Telerik.Reporting.TextBox()
        Me.TextBox67 = New Telerik.Reporting.TextBox()
        Me.TextBox68 = New Telerik.Reporting.TextBox()
        Me.Shape4 = New Telerik.Reporting.Shape()
        Me.Shape6 = New Telerik.Reporting.Shape()
        Me.Shape9 = New Telerik.Reporting.Shape()
        Me.Shape11 = New Telerik.Reporting.Shape()
        Me.Shape14 = New Telerik.Reporting.Shape()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.TextBox64 = New Telerik.Reporting.TextBox()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.PageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.Shape10 = New Telerik.Reporting.Shape()
        Me.TextBox74 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.Shape5 = New Telerik.Reporting.Shape()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.45486563444137573R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox53, Me.TextBox54, Me.TextBox56, Me.TextBox36, Me.Shape28, Me.Shape16, Me.Shape29, Me.Shape15, Me.TextBox72})
        Me.detail.Name = "detail"
        Me.detail.Style.BorderColor.Bottom = System.Drawing.Color.White
        Me.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox53
        '
        Me.TextBox53.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.099999949336051941R), Telerik.Reporting.Drawing.Unit.Cm(0.11979997158050537R))
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.145417332649231R), Telerik.Reporting.Drawing.Unit.Cm(0.30555734038352966R))
        Me.TextBox53.Style.Color = System.Drawing.Color.Black
        Me.TextBox53.Style.Font.Bold = False
        Me.TextBox53.Style.Font.Name = "Arial"
        Me.TextBox53.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox53.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox53.Value = "= Fields.ID_Repuesto"
        '
        'TextBox54
        '
        Me.TextBox54.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.3815892934799194R), Telerik.Reporting.Drawing.Unit.Cm(0.11979997158050537R))
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.6182107925415039R), Telerik.Reporting.Drawing.Unit.Cm(0.30555734038352966R))
        Me.TextBox54.Style.Color = System.Drawing.Color.Black
        Me.TextBox54.Style.Font.Bold = False
        Me.TextBox54.Style.Font.Name = "Arial"
        Me.TextBox54.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox54.Value = "= Fields.Descripcion"
        '
        'TextBox56
        '
        Me.TextBox56.Format = "{0:N2}"
        Me.TextBox56.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.059599876403809R), Telerik.Reporting.Drawing.Unit.Cm(0.10000034421682358R))
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4999990463256836R), Telerik.Reporting.Drawing.Unit.Cm(0.30555734038352966R))
        Me.TextBox56.Style.Color = System.Drawing.Color.Black
        Me.TextBox56.Style.Font.Bold = False
        Me.TextBox56.Style.Font.Name = "Arial"
        Me.TextBox56.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox56.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox56.Value = "= Fields.PrecioVenta"
        '
        'TextBox36
        '
        Me.TextBox36.Format = "{0:N2}"
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.100000381469727R), Telerik.Reporting.Drawing.Unit.Cm(0.10000034421682358R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.701674222946167R), Telerik.Reporting.Drawing.Unit.Cm(0.30555734038352966R))
        Me.TextBox36.Style.Color = System.Drawing.Color.Black
        Me.TextBox36.Style.Font.Bold = False
        Me.TextBox36.Style.Font.Name = "Arial"
        Me.TextBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox36.Value = "= Fields.Cantidad"
        '
        'Shape28
        '
        Me.Shape28.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Top Or Telerik.Reporting.AnchoringStyles.Bottom), Telerik.Reporting.AnchoringStyles)
        Me.Shape28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.0R), Telerik.Reporting.Drawing.Unit.Cm(0.00000000052567983299667276R))
        Me.Shape28.Name = "Shape28"
        Me.Shape28.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.12999999523162842R), Telerik.Reporting.Drawing.Unit.Cm(0.44753760099411011R))
        '
        'Shape16
        '
        Me.Shape16.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Top Or Telerik.Reporting.AnchoringStyles.Bottom), Telerik.Reporting.AnchoringStyles)
        Me.Shape16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.919399261474609R), Telerik.Reporting.Drawing.Unit.Cm(0.00062657566741108894R))
        Me.Shape16.Name = "Shape16"
        Me.Shape16.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.13854168355464935R), Telerik.Reporting.Drawing.Unit.Cm(0.4469110369682312R))
        '
        'Shape29
        '
        Me.Shape29.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Top Or Telerik.Reporting.AnchoringStyles.Bottom), Telerik.Reporting.AnchoringStyles)
        Me.Shape29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.559799194335938R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Shape29.Name = "Shape29"
        Me.Shape29.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.13854168355464935R), Telerik.Reporting.Drawing.Unit.Cm(0.4469110369682312R))
        '
        'Shape15
        '
        Me.Shape15.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Top Or Telerik.Reporting.AnchoringStyles.Bottom), Telerik.Reporting.AnchoringStyles)
        Me.Shape15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2334027290344238R), Telerik.Reporting.Drawing.Unit.Cm(0.00062657671514898539R))
        Me.Shape15.Name = "Shape15"
        Me.Shape15.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.14513890445232391R), Telerik.Reporting.Drawing.Unit.Cm(0.44628411531448364R))
        '
        'TextBox72
        '
        Me.TextBox72.Format = "{0:N2}"
        Me.TextBox72.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.699999809265137R), Telerik.Reporting.Drawing.Unit.Cm(0.11979997158050537R))
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5999977588653564R), Telerik.Reporting.Drawing.Unit.Cm(0.30555734038352966R))
        Me.TextBox72.Style.Color = System.Drawing.Color.Black
        Me.TextBox72.Style.Font.Bold = False
        Me.TextBox72.Style.Font.Name = "Arial"
        Me.TextBox72.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox72.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox72.Value = "= Fields.TotalRepuesto"
        '
        'TextBox50
        '
        Me.TextBox50.Format = "{0:N2}"
        Me.TextBox50.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.000133514404297R), Telerik.Reporting.Drawing.Unit.Cm(4.3390669822692871R))
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3074383735656738R), Telerik.Reporting.Drawing.Unit.Cm(0.3602423369884491R))
        Me.TextBox50.Style.Color = System.Drawing.Color.Black
        Me.TextBox50.Style.Font.Bold = True
        Me.TextBox50.Style.Font.Italic = False
        Me.TextBox50.Style.Font.Name = "Arial"
        Me.TextBox50.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox50.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox50.Value = "= Fields.Total"
        '
        'TextBox29
        '
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.881880760192871R), Telerik.Reporting.Drawing.Unit.Cm(3.9029982089996338R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0999990701675415R), Telerik.Reporting.Drawing.Unit.Cm(0.33944523334503174R))
        Me.TextBox29.Style.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TextBox29.Style.Font.Bold = True
        Me.TextBox29.Style.Font.Italic = False
        Me.TextBox29.Style.Font.Name = "Arial"
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox29.Value = "IVA: $"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.423138618469238R), Telerik.Reporting.Drawing.Unit.Cm(3.4831371307373047R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5643866062164307R), Telerik.Reporting.Drawing.Unit.Cm(0.33944523334503174R))
        Me.TextBox28.Style.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TextBox28.Style.Font.Bold = True
        Me.TextBox28.Style.Font.Italic = False
        Me.TextBox28.Style.Font.Name = "Arial"
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox28.Value = "Importe Otros Tributos: $"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.520291328430176R), Telerik.Reporting.Drawing.Unit.Cm(3.03729510307312R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4818804264068604R), Telerik.Reporting.Drawing.Unit.Cm(0.33944523334503174R))
        Me.TextBox27.Style.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TextBox27.Style.Font.Bold = True
        Me.TextBox27.Style.Font.Italic = False
        Me.TextBox27.Style.Font.Name = "Arial"
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox27.Value = "Importe Neto Gravado: $"
        '
        'TextBox47
        '
        Me.TextBox47.Format = "{0:N2}"
        Me.TextBox47.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.002372741699219R), Telerik.Reporting.Drawing.Unit.Cm(3.03729510307312R))
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3200004100799561R), Telerik.Reporting.Drawing.Unit.Cm(0.33944472670555115R))
        Me.TextBox47.Style.Color = System.Drawing.Color.Black
        Me.TextBox47.Style.Font.Bold = True
        Me.TextBox47.Style.Font.Italic = False
        Me.TextBox47.Style.Font.Name = "Arial"
        Me.TextBox47.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox47.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox47.Value = "= Fields.Subtotal"
        '
        'TextBox48
        '
        Me.TextBox48.Format = "{0:N2}"
        Me.TextBox48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.987571716308594R), Telerik.Reporting.Drawing.Unit.Cm(3.4831371307373047R))
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3199989795684814R), Telerik.Reporting.Drawing.Unit.Cm(0.33944582939147949R))
        Me.TextBox48.Style.Color = System.Drawing.Color.Black
        Me.TextBox48.Style.Font.Bold = True
        Me.TextBox48.Style.Font.Italic = False
        Me.TextBox48.Style.Font.Name = "Arial"
        Me.TextBox48.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox48.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox48.Value = "= Fields.[Otros Impuestos]"
        '
        'TextBox49
        '
        Me.TextBox49.Format = "{0:N2}"
        Me.TextBox49.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.000133514404297R), Telerik.Reporting.Drawing.Unit.Cm(3.9029982089996338R))
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.30743670463562R), Telerik.Reporting.Drawing.Unit.Cm(0.33944472670555115R))
        Me.TextBox49.Style.Color = System.Drawing.Color.Black
        Me.TextBox49.Style.Font.Bold = True
        Me.TextBox49.Style.Font.Italic = False
        Me.TextBox49.Style.Font.Name = "Arial"
        Me.TextBox49.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox49.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox49.Value = "= Fields.[Monto IVA]"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.294519424438477R), Telerik.Reporting.Drawing.Unit.Cm(4.3390669822692871R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.36024287343025208R))
        Me.TextBox26.Style.BackgroundColor = System.Drawing.Color.White
        Me.TextBox26.Style.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TextBox26.Style.Font.Bold = True
        Me.TextBox26.Style.Font.Italic = False
        Me.TextBox26.Style.Font.Name = "Arial"
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox26.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox26.Value = "Importe Total: $"
        '
        'TextBox30
        '
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.099999949336051941R), Telerik.Reporting.Drawing.Unit.Cm(0.1883527934551239R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.7785415649414062R), Telerik.Reporting.Drawing.Unit.Cm(0.54429978132247925R))
        Me.TextBox30.Style.Color = System.Drawing.Color.Black
        Me.TextBox30.Style.Font.Bold = True
        Me.TextBox30.Style.Font.Name = "Arial"
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox30.Value = "Total Repuestos:"
        '
        'ReportFooterSection1
        '
        Me.ReportFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.80000025033950806R)
        Me.ReportFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox44, Me.TextBox30})
        Me.ReportFooterSection1.KeepTogether = False
        Me.ReportFooterSection1.Name = "ReportFooterSection1"
        Me.ReportFooterSection1.PageBreak = Telerik.Reporting.PageBreak.None
        Me.ReportFooterSection1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox44
        '
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.90000057220459R), Telerik.Reporting.Drawing.Unit.Cm(0.1883527934551239R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.39999771118164R), Telerik.Reporting.Drawing.Unit.Cm(0.54430055618286133R))
        Me.TextBox44.Style.Color = System.Drawing.Color.Black
        Me.TextBox44.Style.Font.Bold = True
        Me.TextBox44.Style.Font.Name = "Arial"
        Me.TextBox44.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox44.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox44.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox44.Value = "= Sum(Fields.TotalRepuesto)"
        '
        'ReportHeaderSection1
        '
        Me.ReportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(8.18019962310791R)
        Me.ReportHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox21, Me.TextBox14, Me.TextBox11, Me.TextBox20, Me.TextBox22, Me.TextBox45, Me.TextBox43, Me.TextBox42, Me.TextBox37, Me.TextBox35, Me.TextBox19, Me.TextBox17, Me.TextBox16, Me.TextBox12, Me.TextBox10, Me.Shape8, Me.TextBox1, Me.TextBox46, Me.TextBox55, Me.TextBox59, Me.TextBox60, Me.TextBox61, Me.TextBox62, Me.TextBox4, Me.TextBox5, Me.TextBox31, Me.TextBox32, Me.TextBox33, Me.TextBox51, Me.TextBox52, Me.TextBox66, Me.TextBox67, Me.TextBox68, Me.Shape4, Me.Shape6, Me.Shape9, Me.Shape11, Me.Shape14, Me.Shape2, Me.TextBox64, Me.PictureBox1, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox13, Me.TextBox18, Me.TextBox24, Me.TextBox38})
        Me.ReportHeaderSection1.Name = "ReportHeaderSection1"
        Me.ReportHeaderSection1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.000099988508736714721R), Telerik.Reporting.Drawing.Unit.Cm(7.4999990463256836R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.2998999357223511R), Telerik.Reporting.Drawing.Unit.Cm(0.617395281791687R))
        Me.TextBox21.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox21.Style.Color = System.Drawing.Color.Black
        Me.TextBox21.Style.Font.Bold = True
        Me.TextBox21.Style.Font.Name = "Arial"
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.Value = "Código"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.699999809265137R), Telerik.Reporting.Drawing.Unit.Cm(7.4999995231628418R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6223750114440918R), Telerik.Reporting.Drawing.Unit.Cm(0.61739450693130493R))
        Me.TextBox14.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox14.Style.Color = System.Drawing.Color.Black
        Me.TextBox14.Style.Font.Bold = True
        Me.TextBox14.Style.Font.Name = "Arial"
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "Total"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.059599876403809R), Telerik.Reporting.Drawing.Unit.Cm(7.4999995231628418R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4999992847442627R), Telerik.Reporting.Drawing.Unit.Cm(0.61739450693130493R))
        Me.TextBox11.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox11.Style.Color = System.Drawing.Color.Black
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Name = "Arial"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "Precio Unit."
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.100000381469727R), Telerik.Reporting.Drawing.Unit.Cm(7.4999990463256836R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8191993236541748R), Telerik.Reporting.Drawing.Unit.Cm(0.617395281791687R))
        Me.TextBox20.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox20.Style.Color = System.Drawing.Color.Black
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Style.Font.Name = "Arial"
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.Value = "Cantidad"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2999999523162842R), Telerik.Reporting.Drawing.Unit.Cm(7.4999990463256836R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.6997995376586914R), Telerik.Reporting.Drawing.Unit.Cm(0.617395281791687R))
        Me.TextBox22.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox22.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox22.Style.Color = System.Drawing.Color.Black
        Me.TextBox22.Style.Font.Bold = True
        Me.TextBox22.Style.Font.Name = "Arial"
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.TextWrap = True
        Me.TextBox22.Value = "Producto/Servicio"
        '
        'TextBox45
        '
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.700200080871582R), Telerik.Reporting.Drawing.Unit.Cm(6.09999942779541R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.8998000621795654R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox45.Style.Color = System.Drawing.Color.Black
        Me.TextBox45.Style.Font.Bold = False
        Me.TextBox45.Style.Font.Name = "Arial"
        Me.TextBox45.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox45.Value = "= Fields.[Detalle Forma de Pago]"
        '
        'TextBox43
        '
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2999997138977051R), Telerik.Reporting.Drawing.Unit.Cm(5.0999984741210938R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8700015544891357R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox43.Style.Color = System.Drawing.Color.Black
        Me.TextBox43.Style.Font.Bold = False
        Me.TextBox43.Style.Font.Name = "Arial"
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox43.Value = "= Fields.ClienteCUIT"
        '
        'TextBox42
        '
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.3999998569488525R), Telerik.Reporting.Drawing.Unit.Cm(5.59999942779541R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.1999993324279785R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox42.Style.Color = System.Drawing.Color.Black
        Me.TextBox42.Style.Font.Bold = False
        Me.TextBox42.Style.Font.Name = "Arial"
        Me.TextBox42.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox42.Value = "= Fields.[Tipo de Venta]"
        '
        'TextBox37
        '
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.752082824707031R), Telerik.Reporting.Drawing.Unit.Cm(5.59999942779541R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.5479159355163574R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox37.Style.Color = System.Drawing.Color.Black
        Me.TextBox37.Style.Font.Bold = False
        Me.TextBox37.Style.Font.Name = "Arial"
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox37.Value = "= Fields.ClienteDireccion+"" ""+ Fields.ClienteNumero"
        '
        'TextBox35
        '
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.09999942779541R), Telerik.Reporting.Drawing.Unit.Cm(5.0999984741210938R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox35.Style.Color = System.Drawing.Color.Black
        Me.TextBox35.Style.Font.Bold = False
        Me.TextBox35.Style.Font.Name = "Arial"
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox35.Value = "= Fields.Cliente"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.2416672557592392R), Telerik.Reporting.Drawing.Unit.Cm(6.09999942779541R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4583330154418945R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox19.Style.Color = System.Drawing.Color.Black
        Me.TextBox19.Style.Font.Bold = True
        Me.TextBox19.Style.Font.Name = "Arial"
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox19.Value = "Forma de Pago:"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.2416672557592392R), Telerik.Reporting.Drawing.Unit.Cm(5.0999984741210938R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0037500858306885R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox17.Style.Color = System.Drawing.Color.Black
        Me.TextBox17.Style.Font.Bold = True
        Me.TextBox17.Style.Font.Name = "Arial"
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox17.Value = "CUIT:"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.2416672557592392R), Telerik.Reporting.Drawing.Unit.Cm(5.59999942779541R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0883324146270752R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox16.Style.Color = System.Drawing.Color.Black
        Me.TextBox16.Style.Font.Bold = True
        Me.TextBox16.Style.Font.Name = "Arial"
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox16.Value = "Tipo de Venta:"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.8999996185302734R), Telerik.Reporting.Drawing.Unit.Cm(5.59999942779541R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8118745088577271R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox12.Style.Color = System.Drawing.Color.Black
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.Font.Name = "Arial"
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox12.Value = "Domicilio:"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.5R), Telerik.Reporting.Drawing.Unit.Cm(5.0999984741210938R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.6041650772094727R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox10.Style.Color = System.Drawing.Color.Black
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox10.Value = "Apellido y Nombre/Razón Social:"
        '
        'Shape8
        '
        Me.Shape8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(7.4499998092651367R))
        Me.Shape8.Name = "Shape8"
        Me.Shape8.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(18.799900054931641R), Telerik.Reporting.Drawing.Unit.Cm(0.12999999523162842R))
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.899999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.4945836067199707R), Telerik.Reporting.Drawing.Unit.Cm(0.599999725818634R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox1.Value = "FACTURA"
        '
        'TextBox46
        '
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Cm(3.0322914123535156R))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1299998760223389R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox46.Style.Color = System.Drawing.Color.Black
        Me.TextBox46.Style.Font.Bold = True
        Me.TextBox46.Style.Font.Name = "Arial"
        Me.TextBox46.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox46.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox46.Value = "Razón Social:"
        '
        'TextBox55
        '
        Me.TextBox55.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.3302001953125R), Telerik.Reporting.Drawing.Unit.Cm(3.0624041557312012R))
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.3431320190429688R), Telerik.Reporting.Drawing.Unit.Cm(0.46988773345947266R))
        Me.TextBox55.Style.Color = System.Drawing.Color.Black
        Me.TextBox55.Style.Font.Bold = False
        Me.TextBox55.Style.Font.Name = "Arial"
        Me.TextBox55.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox55.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox55.Value = "Roberto C. Gaido"
        '
        'TextBox59
        '
        Me.TextBox59.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.3002002239227295R), Telerik.Reporting.Drawing.Unit.Cm(3.5999999046325684R))
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.3941740989685059R), Telerik.Reporting.Drawing.Unit.Cm(0.50812512636184692R))
        Me.TextBox59.Style.Color = System.Drawing.Color.Black
        Me.TextBox59.Style.Font.Bold = False
        Me.TextBox59.Style.Font.Name = "Arial"
        Me.TextBox59.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox59.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox59.Value = "Corrientes 136 - Las Varillas"
        '
        'TextBox60
        '
        Me.TextBox60.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20811714231967926R), Telerik.Reporting.Drawing.Unit.Cm(3.5999999046325684R))
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0918827056884766R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox60.Style.Color = System.Drawing.Color.Black
        Me.TextBox60.Style.Font.Bold = True
        Me.TextBox60.Style.Font.Name = "Arial"
        Me.TextBox60.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox60.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox60.Value = "Domicilio Comercial:"
        '
        'TextBox61
        '
        Me.TextBox61.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Cm(4.1677079200744629R))
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5000002384185791R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox61.Style.Color = System.Drawing.Color.Black
        Me.TextBox61.Style.Font.Bold = True
        Me.TextBox61.Style.Font.Name = "Arial"
        Me.TextBox61.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox61.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox61.Value = "Condición Frente al IVA:"
        '
        'TextBox62
        '
        Me.TextBox62.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.7000000476837158R), Telerik.Reporting.Drawing.Unit.Cm(4.1677079200744629R))
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.8999996185302734R), Telerik.Reporting.Drawing.Unit.Cm(0.5000002384185791R))
        Me.TextBox62.Style.Color = System.Drawing.Color.Black
        Me.TextBox62.Style.Font.Bold = True
        Me.TextBox62.Style.Font.Name = "Arial"
        Me.TextBox62.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox62.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox62.Value = "Resp. Inscripto"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.899999618530273R), Telerik.Reporting.Drawing.Unit.Cm(1.6999996900558472R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6999995708465576R), Telerik.Reporting.Drawing.Unit.Cm(0.34140539169311523R))
        Me.TextBox4.Style.Color = System.Drawing.Color.Black
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "Comp. Nro:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.600199699401856R), Telerik.Reporting.Drawing.Unit.Cm(1.6999996900558472R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.7998008728027344R), Telerik.Reporting.Drawing.Unit.Cm(0.34140539169311523R))
        Me.TextBox5.Style.Color = System.Drawing.Color.Black
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "= Fields.NroComprobante"
        '
        'TextBox31
        '
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.899999618530273R), Telerik.Reporting.Drawing.Unit.Cm(2.1999998092651367R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R))
        Me.TextBox31.Style.Color = System.Drawing.Color.Black
        Me.TextBox31.Style.Font.Bold = True
        Me.TextBox31.Style.Font.Name = "Arial"
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox31.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox31.Value = "Fecha de Emisión:"
        '
        'TextBox32
        '
        Me.TextBox32.Format = "{0:dd/MM/yyyy}"
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.59999942779541R), Telerik.Reporting.Drawing.Unit.Cm(2.1999998092651367R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0000009536743164R), Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R))
        Me.TextBox32.Style.Color = System.Drawing.Color.Black
        Me.TextBox32.Style.Font.Bold = True
        Me.TextBox32.Style.Font.Name = "Arial"
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox32.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox32.Value = "= Fields.FechaVenta.DayOfYear"
        '
        'TextBox33
        '
        Me.TextBox33.Format = "{0:d}"
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.199999809265137R), Telerik.Reporting.Drawing.Unit.Cm(3.9000000953674316R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R))
        Me.TextBox33.Style.Color = System.Drawing.Color.Black
        Me.TextBox33.Style.Font.Bold = False
        Me.TextBox33.Style.Font.Name = "Arial"
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox33.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox33.Value = "20/05/1996"
        '
        'TextBox51
        '
        Me.TextBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.77437686920166R), Telerik.Reporting.Drawing.Unit.Cm(3.8822920322418213R))
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.4252095222473145R), Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R))
        Me.TextBox51.Style.Color = System.Drawing.Color.Black
        Me.TextBox51.Style.Font.Bold = True
        Me.TextBox51.Style.Font.Name = "Arial"
        Me.TextBox51.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox51.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox51.Value = "Fecha de Inicio de Actividades:"
        '
        'TextBox52
        '
        Me.TextBox52.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.774792671203613R), Telerik.Reporting.Drawing.Unit.Cm(3.140486478805542R))
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.925208330154419R), Telerik.Reporting.Drawing.Unit.Cm(0.34140539169311523R))
        Me.TextBox52.Style.Color = System.Drawing.Color.Black
        Me.TextBox52.Style.Font.Bold = True
        Me.TextBox52.Style.Font.Name = "Arial"
        Me.TextBox52.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox52.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox52.Value = "CUIT:"
        '
        'TextBox66
        '
        Me.TextBox66.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.700000762939453R), Telerik.Reporting.Drawing.Unit.Cm(3.140486478805542R))
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4000003337860107R), Telerik.Reporting.Drawing.Unit.Cm(0.34140533208847046R))
        Me.TextBox66.Style.Color = System.Drawing.Color.Black
        Me.TextBox66.Style.Font.Bold = False
        Me.TextBox66.Style.Font.Name = "Arial"
        Me.TextBox66.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox66.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox66.Value = "20-17967468-9"
        '
        'TextBox67
        '
        Me.TextBox67.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.77437686920166R), Telerik.Reporting.Drawing.Unit.Cm(3.4820919036865234R))
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4256255626678467R), Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R))
        Me.TextBox67.Style.Color = System.Drawing.Color.Black
        Me.TextBox67.Style.Font.Bold = True
        Me.TextBox67.Style.Font.Name = "Arial"
        Me.TextBox67.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox67.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox67.Value = "Ingresos Brutos:"
        '
        'TextBox68
        '
        Me.TextBox68.Format = "{0}"
        Me.TextBox68.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.20000171661377R), Telerik.Reporting.Drawing.Unit.Cm(3.4820919036865234R))
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0000009536743164R), Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R))
        Me.TextBox68.Style.Color = System.Drawing.Color.Black
        Me.TextBox68.Style.Font.Bold = False
        Me.TextBox68.Style.Font.Name = "Arial"
        Me.TextBox68.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox68.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox68.Value = "20-17967468-9"
        '
        'Shape4
        '
        Me.Shape4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(4.7999997138977051R))
        Me.Shape4.Name = "Shape4"
        Me.Shape4.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(18.799900054931641R), Telerik.Reporting.Drawing.Unit.Cm(0.12999999523162842R))
        '
        'Shape6
        '
        Me.Shape6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2385417222976685R), Telerik.Reporting.Drawing.Unit.Cm(7.5R))
        Me.Shape6.Name = "Shape6"
        Me.Shape6.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.14000000059604645R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        '
        'Shape9
        '
        Me.Shape9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.0R), Telerik.Reporting.Drawing.Unit.Cm(7.5R))
        Me.Shape9.Name = "Shape9"
        Me.Shape9.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.14000000059604645R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        '
        'Shape11
        '
        Me.Shape11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.919399261474609R), Telerik.Reporting.Drawing.Unit.Cm(7.5R))
        Me.Shape11.Name = "Shape11"
        Me.Shape11.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.14000000059604645R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        '
        'Shape14
        '
        Me.Shape14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.559799194335938R), Telerik.Reporting.Drawing.Unit.Cm(7.5173940658569336R))
        Me.Shape14.Name = "Shape14"
        Me.Shape14.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.14000000059604645R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0.68281257152557373R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(18.799900054931641R), Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R))
        '
        'TextBox64
        '
        Me.TextBox64.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.77437686920166R), Telerik.Reporting.Drawing.Unit.Cm(4.30019998550415R))
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5256234407424927R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox64.Style.Color = System.Drawing.Color.Black
        Me.TextBox64.Style.Font.Bold = True
        Me.TextBox64.Style.Font.Name = "Arial"
        Me.TextBox64.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox64.Value = "Atendió:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.5999997854232788R), Telerik.Reporting.Drawing.Unit.Cm(0.86770862340927124R))
        Me.PictureBox1.MimeType = "image/png"
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.40000057220459R), Telerik.Reporting.Drawing.Unit.Cm(1.9000003337860107R))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox1.Value = CType(resources.GetObject("PictureBox1.Value"), Object)
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.2416672557592392R), Telerik.Reporting.Drawing.Unit.Cm(6.6000003814697266R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6581325531005859R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox7.Style.Color = System.Drawing.Color.Black
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Value = "Forma de Entrega:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.9000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(6.6000003814697266R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.702092170715332R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox8.Style.Color = System.Drawing.Color.Black
        Me.TextBox8.Style.Font.Bold = False
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Value = "= Fields.[Forma de Entrega]"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.90000057220459R), Telerik.Reporting.Drawing.Unit.Cm(6.0999999046325684R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8118745088577271R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox9.Style.Color = System.Drawing.Color.Black
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.Font.Name = "Arial"
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox9.Value = "Localidad:"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.752083778381348R), Telerik.Reporting.Drawing.Unit.Cm(6.0999999046325684R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.5479159355163574R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox13.Style.Color = System.Drawing.Color.Black
        Me.TextBox13.Style.Font.Bold = False
        Me.TextBox13.Style.Font.Name = "Arial"
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox13.Value = "= Fields.ClienteLocalidad"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.90000057220459R), Telerik.Reporting.Drawing.Unit.Cm(6.6000003814697266R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8118745088577271R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox18.Style.Color = System.Drawing.Color.Black
        Me.TextBox18.Style.Font.Bold = True
        Me.TextBox18.Style.Font.Name = "Arial"
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox18.Value = "Teléfono:"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.752082824707031R), Telerik.Reporting.Drawing.Unit.Cm(6.6000003814697266R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.5554885864257812R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox24.Style.Color = System.Drawing.Color.Black
        Me.TextBox24.Style.Font.Bold = False
        Me.TextBox24.Style.Font.Name = "Arial"
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox24.Value = "= Fields.ClienteTelefono"
        '
        'TextBox38
        '
        Me.TextBox38.Format = "{0:d}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.300200462341309R), Telerik.Reporting.Drawing.Unit.Cm(4.2677083015441895R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.5998010635375977R), Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R))
        Me.TextBox38.Style.Color = System.Drawing.Color.Black
        Me.TextBox38.Style.Font.Bold = False
        Me.TextBox38.Style.Font.Name = "Arial"
        Me.TextBox38.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox38.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox38.Value = "= Fields.Vendedor"
        '
        'PageFooterSection1
        '
        Me.PageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(5.3372950553894043R)
        Me.PageFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox47, Me.TextBox28, Me.TextBox48, Me.TextBox29, Me.TextBox49, Me.TextBox26, Me.TextBox50, Me.TextBox27, Me.Shape10, Me.TextBox74, Me.TextBox2, Me.TextBox3, Me.TextBox6, Me.Shape5, Me.TextBox15, Me.TextBox23, Me.TextBox25, Me.TextBox34})
        Me.PageFooterSection1.Name = "PageFooterSection1"
        Me.PageFooterSection1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'Shape10
        '
        Me.Shape10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(1.6372965574264526R))
        Me.Shape10.Name = "Shape10"
        Me.Shape10.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(18.799900054931641R), Telerik.Reporting.Drawing.Unit.Cm(0.12999999523162842R))
        '
        'TextBox74
        '
        Me.TextBox74.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.087526954710483551R), Telerik.Reporting.Drawing.Unit.Cm(0.93729639053344727R))
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.7910146713256836R), Telerik.Reporting.Drawing.Unit.Cm(0.54430055618286133R))
        Me.TextBox74.Style.Color = System.Drawing.Color.Black
        Me.TextBox74.Style.Font.Bold = True
        Me.TextBox74.Style.Font.Name = "Arial"
        Me.TextBox74.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox74.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox74.Value = "Servicios de Terceros:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.92237663269043R), Telerik.Reporting.Drawing.Unit.Cm(0.93729639053344727R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.39999771118164R), Telerik.Reporting.Drawing.Unit.Cm(0.54430055618286133R))
        Me.TextBox2.Style.Color = System.Drawing.Color.Black
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Arial"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox2.Value = "= Fields.[Serv Terceros]"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.942500114440918R), Telerik.Reporting.Drawing.Unit.Cm(0.13729673624038696R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.39999771118164R), Telerik.Reporting.Drawing.Unit.Cm(0.54430055618286133R))
        Me.TextBox3.Style.Color = System.Drawing.Color.Black
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Name = "Arial"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox3.Value = "= Fields.[Mano de Obra]"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10000035166740418R), Telerik.Reporting.Drawing.Unit.Cm(0.13729673624038696R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.7910146713256836R), Telerik.Reporting.Drawing.Unit.Cm(0.54430055618286133R))
        Me.TextBox6.Style.Color = System.Drawing.Color.Black
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.Font.Name = "Arial"
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.TextBox6.Value = "Mano de Obra:"
        '
        'Shape5
        '
        Me.Shape5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0.73729676008224487R))
        Me.Shape5.Name = "Shape5"
        Me.Shape5.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(18.799900054931641R), Telerik.Reporting.Drawing.Unit.Cm(0.12999999523162842R))
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.5R), Telerik.Reporting.Drawing.Unit.Cm(2.5372955799102783R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4818804264068604R), Telerik.Reporting.Drawing.Unit.Cm(0.33944523334503174R))
        Me.TextBox15.Style.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Italic = False
        Me.TextBox15.Style.Font.Name = "Arial"
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox15.Value = "Descuento/Recargo:"
        '
        'TextBox23
        '
        Me.TextBox23.Format = "{0:N2}"
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.966042518615723R), Telerik.Reporting.Drawing.Unit.Cm(2.5372955799102783R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3200004100799561R), Telerik.Reporting.Drawing.Unit.Cm(0.33944472670555115R))
        Me.TextBox23.Style.Color = System.Drawing.Color.Black
        Me.TextBox23.Style.Font.Bold = True
        Me.TextBox23.Style.Font.Italic = False
        Me.TextBox23.Style.Font.Name = "Arial"
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox23.Value = "= Fields.[Descuento/Recargo]"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.600199699401856R), Telerik.Reporting.Drawing.Unit.Cm(3.9029982089996338R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0999990701675415R), Telerik.Reporting.Drawing.Unit.Cm(0.33944523334503174R))
        Me.TextBox25.Style.Color = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TextBox25.Style.Font.Bold = True
        Me.TextBox25.Style.Font.Italic = False
        Me.TextBox25.Style.Font.Name = "Arial"
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox25.Value = "IVA: %"
        '
        'TextBox34
        '
        Me.TextBox34.Format = "{0:P2}"
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.700399398803711R), Telerik.Reporting.Drawing.Unit.Cm(3.9029982089996338R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.181280255317688R), Telerik.Reporting.Drawing.Unit.Cm(0.33944472670555115R))
        Me.TextBox34.Style.Color = System.Drawing.Color.Black
        Me.TextBox34.Style.Font.Bold = True
        Me.TextBox34.Style.Font.Italic = False
        Me.TextBox34.Style.Font.Name = "Arial"
        Me.TextBox34.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox34.Value = "= Fields.[IVA%]/100"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Mecanica_Gaido_frm.My.MySettings.PIN_GRUPO31ConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@ID_Venta", System.Data.DbType.Int32, "=Parameters.ID_Venta.Value")})
        Me.SqlDataSource1.SelectCommand = "dbo.Consultar_VentaFactura_ID"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'RptVentas
        '
        Me.DataSource = Me.SqlDataSource1
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail, Me.ReportFooterSection1, Me.ReportHeaderSection1, Me.PageFooterSection1})
        Me.Name = "RptVentas"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(14.0R), Telerik.Reporting.Drawing.Unit.Mm(8.0R), Telerik.Reporting.Drawing.Unit.Mm(6.0R), Telerik.Reporting.Drawing.Unit.Mm(5.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "ID_Venta"
        ReportParameter1.Text = "@ID_Venta"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        Me.ReportParameters.Add(ReportParameter1)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(19.300199508666992R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents Shape15 As Telerik.Reporting.Shape
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents ReportFooterSection1 As Telerik.Reporting.ReportFooterSection
    Friend WithEvents TextBox47 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox49 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox50 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox53 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox54 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox56 As Telerik.Reporting.TextBox
    Friend WithEvents ReportHeaderSection1 As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents Shape8 As Telerik.Reporting.Shape
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox55 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox59 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox60 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox61 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox62 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox51 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox52 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox66 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox67 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox68 As Telerik.Reporting.TextBox
    Friend WithEvents Shape4 As Telerik.Reporting.Shape
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents Shape6 As Telerik.Reporting.Shape
    Friend WithEvents TextBox72 As Telerik.Reporting.TextBox
    Friend WithEvents PageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
    Friend WithEvents TextBox64 As Telerik.Reporting.TextBox
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents Shape10 As Telerik.Reporting.Shape
    Friend WithEvents TextBox74 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents Shape28 As Telerik.Reporting.Shape
    Friend WithEvents Shape16 As Telerik.Reporting.Shape
    Friend WithEvents Shape29 As Telerik.Reporting.Shape
    Friend WithEvents Shape9 As Telerik.Reporting.Shape
    Friend WithEvents Shape11 As Telerik.Reporting.Shape
    Friend WithEvents Shape14 As Telerik.Reporting.Shape
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents Shape5 As Telerik.Reporting.Shape
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
End Class