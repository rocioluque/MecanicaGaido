Partial Class RptHistorialCliente

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptHistorialCliente))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox53 = New Telerik.Reporting.TextBox()
        Me.TextBox54 = New Telerik.Reporting.TextBox()
        Me.TextBox56 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.Shape16 = New Telerik.Reporting.Shape()
        Me.Shape29 = New Telerik.Reporting.Shape()
        Me.Shape15 = New Telerik.Reporting.Shape()
        Me.TextBox72 = New Telerik.Reporting.TextBox()
        Me.EncabezadoHistorial = New Telerik.Reporting.ReportHeaderSection()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.TextBox55 = New Telerik.Reporting.TextBox()
        Me.TextBox59 = New Telerik.Reporting.TextBox()
        Me.TextBox60 = New Telerik.Reporting.TextBox()
        Me.TextBox61 = New Telerik.Reporting.TextBox()
        Me.TextBox62 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox51 = New Telerik.Reporting.TextBox()
        Me.TextBox52 = New Telerik.Reporting.TextBox()
        Me.TextBox66 = New Telerik.Reporting.TextBox()
        Me.TextBox67 = New Telerik.Reporting.TextBox()
        Me.TextBox68 = New Telerik.Reporting.TextBox()
        Me.Shape4 = New Telerik.Reporting.Shape()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.Shape6 = New Telerik.Reporting.Shape()
        Me.Shape9 = New Telerik.Reporting.Shape()
        Me.Shape11 = New Telerik.Reporting.Shape()
        Me.Shape14 = New Telerik.Reporting.Shape()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.Shape3 = New Telerik.Reporting.Shape()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229162991046906R)
        Me.detail.Name = "detail"
        Me.detail.Style.BorderColor.Bottom = System.Drawing.Color.Black
        Me.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.Visible = False
        '
        'TextBox53
        '
        Me.TextBox53.Format = "{0:N0}"
        Me.TextBox53.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R), Telerik.Reporting.Drawing.Unit.Cm(0.079999998211860657R))
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4299999475479126R), Telerik.Reporting.Drawing.Unit.Cm(0.31000000238418579R))
        Me.TextBox53.Style.Color = System.Drawing.Color.Black
        Me.TextBox53.Style.Font.Bold = False
        Me.TextBox53.Style.Font.Name = "Arial"
        Me.TextBox53.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox53.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox53.Value = "= Fields.OrdenNumero"
        '
        'TextBox54
        '
        Me.TextBox54.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.440000057220459R), Telerik.Reporting.Drawing.Unit.Cm(0.079999998211860657R))
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.380000114440918R), Telerik.Reporting.Drawing.Unit.Cm(0.31000000238418579R))
        Me.TextBox54.Style.Color = System.Drawing.Color.Black
        Me.TextBox54.Style.Font.Bold = False
        Me.TextBox54.Style.Font.Name = "Arial"
        Me.TextBox54.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox54.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox54.Value = "= Fields.OrdenFechaEntrada"
        '
        'TextBox56
        '
        Me.TextBox56.Format = "{0:N2}"
        Me.TextBox56.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.779999732971191R), Telerik.Reporting.Drawing.Unit.Cm(0.079999998211860657R))
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.619999885559082R), Telerik.Reporting.Drawing.Unit.Cm(0.31000000238418579R))
        Me.TextBox56.Style.Color = System.Drawing.Color.Black
        Me.TextBox56.Style.Font.Bold = False
        Me.TextBox56.Style.Font.Name = "Arial"
        Me.TextBox56.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox56.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox56.Value = "= Fields.OrdenMontoRep"
        '
        'TextBox36
        '
        Me.TextBox36.Format = "{0:d}"
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.8199999332427979R), Telerik.Reporting.Drawing.Unit.Cm(0.079999998211860657R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.380000114440918R), Telerik.Reporting.Drawing.Unit.Cm(0.31000000238418579R))
        Me.TextBox36.Style.Color = System.Drawing.Color.Black
        Me.TextBox36.Style.Font.Bold = False
        Me.TextBox36.Style.Font.Name = "Arial"
        Me.TextBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox36.Value = "= Fields.OrdenFechaSalida"
        '
        'Shape16
        '
        Me.Shape16.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Top Or Telerik.Reporting.AnchoringStyles.Bottom), Telerik.Reporting.AnchoringStyles)
        Me.Shape16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.7999999523162842R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Shape16.Name = "Shape16"
        Me.Shape16.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(0.38999998569488525R))
        '
        'Shape29
        '
        Me.Shape29.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Top Or Telerik.Reporting.AnchoringStyles.Bottom), Telerik.Reporting.AnchoringStyles)
        Me.Shape29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.3799991607666R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Shape29.Name = "Shape29"
        Me.Shape29.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(0.38999998569488525R))
        '
        'Shape15
        '
        Me.Shape15.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Top Or Telerik.Reporting.AnchoringStyles.Bottom), Telerik.Reporting.AnchoringStyles)
        Me.Shape15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.4099999666213989R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Shape15.Name = "Shape15"
        Me.Shape15.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(0.38999998569488525R))
        '
        'TextBox72
        '
        Me.TextBox72.Format = "{0:N2}"
        Me.TextBox72.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.399999618530273R), Telerik.Reporting.Drawing.Unit.Cm(0.079999998211860657R))
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.619999885559082R), Telerik.Reporting.Drawing.Unit.Cm(0.31000000238418579R))
        Me.TextBox72.Style.Color = System.Drawing.Color.Black
        Me.TextBox72.Style.Font.Bold = False
        Me.TextBox72.Style.Font.Name = "Arial"
        Me.TextBox72.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox72.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox72.Value = "= Fields.OrdenMontoTotal"
        '
        'EncabezadoHistorial
        '
        Me.EncabezadoHistorial.Height = Telerik.Reporting.Drawing.Unit.Cm(6.2000002861022949R)
        Me.EncabezadoHistorial.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox43, Me.TextBox37, Me.TextBox35, Me.TextBox17, Me.TextBox12, Me.TextBox10, Me.TextBox1, Me.TextBox46, Me.TextBox55, Me.TextBox59, Me.TextBox60, Me.TextBox61, Me.TextBox62, Me.TextBox31, Me.TextBox32, Me.TextBox33, Me.TextBox51, Me.TextBox52, Me.TextBox66, Me.TextBox67, Me.TextBox68, Me.Shape4, Me.PictureBox1, Me.TextBox9, Me.TextBox13, Me.TextBox18, Me.TextBox24})
        Me.EncabezadoHistorial.Name = "EncabezadoHistorial"
        Me.EncabezadoHistorial.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox43
        '
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.2000000476837158R), Telerik.Reporting.Drawing.Unit.Cm(4.5322904586791992R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8700015544891357R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox43.Style.Color = System.Drawing.Color.Black
        Me.TextBox43.Style.Font.Bold = False
        Me.TextBox43.Style.Font.Name = "Arial"
        Me.TextBox43.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox43.Value = "= Fields.ClienteCUIT"
        '
        'TextBox37
        '
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0500006675720215R), Telerik.Reporting.Drawing.Unit.Cm(5.0322918891906738R))
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
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.0R), Telerik.Reporting.Drawing.Unit.Cm(4.5322904586791992R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox35.Style.Color = System.Drawing.Color.Black
        Me.TextBox35.Style.Font.Bold = False
        Me.TextBox35.Style.Font.Name = "Arial"
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox35.Value = "= Fields.Cliente"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.14166750013828278R), Telerik.Reporting.Drawing.Unit.Cm(4.5322904586791992R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0037500858306885R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox17.Style.Color = System.Drawing.Color.Black
        Me.TextBox17.Style.Font.Bold = True
        Me.TextBox17.Style.Font.Name = "Arial"
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox17.Value = "CUIT:"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.14000013470649719R), Telerik.Reporting.Drawing.Unit.Cm(5.0322918891906738R))
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
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.4000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(4.5322904586791992R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.6041650772094727R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox10.Style.Color = System.Drawing.Color.Black
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.Font.Name = "Arial"
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox10.Value = "Apellido y Nombre/Razón Social:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.686039924621582R), Telerik.Reporting.Drawing.Unit.Cm(0.63229143619537354R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.5000038146972656R), Telerik.Reporting.Drawing.Unit.Cm(0.699999988079071R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Arial"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(15.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox1.Value = "HISTORIAL DE REPARACIONES"
        '
        'TextBox46
        '
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.11841068416833878R), Telerik.Reporting.Drawing.Unit.Cm(2.4645829200744629R))
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
        Me.TextBox55.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.3000006675720215R), Telerik.Reporting.Drawing.Unit.Cm(2.4946956634521484R))
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.4000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(0.46988773345947266R))
        Me.TextBox55.Style.Color = System.Drawing.Color.Black
        Me.TextBox55.Style.Font.Bold = False
        Me.TextBox55.Style.Font.Name = "Arial"
        Me.TextBox55.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox55.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox55.Value = "Roberto C. Gaido"
        '
        'TextBox59
        '
        Me.TextBox59.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.2002003192901611R), Telerik.Reporting.Drawing.Unit.Cm(3.0322911739349365R))
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
        Me.TextBox60.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.11841068416833878R), Telerik.Reporting.Drawing.Unit.Cm(3.0322911739349365R))
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
        Me.TextBox61.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.11841068416833878R), Telerik.Reporting.Drawing.Unit.Cm(3.599998950958252R))
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.7000000476837158R), Telerik.Reporting.Drawing.Unit.Cm(0.50000017881393433R))
        Me.TextBox61.Style.Color = System.Drawing.Color.Black
        Me.TextBox61.Style.Font.Bold = True
        Me.TextBox61.Style.Font.Name = "Arial"
        Me.TextBox61.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox61.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox61.Value = "Condición Frente al IVA:"
        '
        'TextBox62
        '
        Me.TextBox62.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.8000004291534424R), Telerik.Reporting.Drawing.Unit.Cm(3.599998950958252R))
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2000002861022949R), Telerik.Reporting.Drawing.Unit.Cm(0.5000002384185791R))
        Me.TextBox62.Style.Color = System.Drawing.Color.Black
        Me.TextBox62.Style.Font.Bold = True
        Me.TextBox62.Style.Font.Name = "Arial"
        Me.TextBox62.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox62.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox62.Value = "Resp. Inscripto"
        '
        'TextBox31
        '
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.300000190734863R), Telerik.Reporting.Drawing.Unit.Cm(1.4322913885116577R))
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
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(14.000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(1.4322913885116577R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.1860413551330566R), Telerik.Reporting.Drawing.Unit.Cm(0.40000000596046448R))
        Me.TextBox32.Style.Color = System.Drawing.Color.Black
        Me.TextBox32.Style.Font.Bold = True
        Me.TextBox32.Style.Font.Name = "Arial"
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox32.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox32.Value = "= Format(""{0:dd/MM/yyyy}"", Now())"
        '
        'TextBox33
        '
        Me.TextBox33.Format = "{0:d}"
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.100000381469727R), Telerik.Reporting.Drawing.Unit.Cm(3.3322913646698R))
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
        Me.TextBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.67437744140625R), Telerik.Reporting.Drawing.Unit.Cm(3.3145833015441895R))
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
        Me.TextBox52.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.674792289733887R), Telerik.Reporting.Drawing.Unit.Cm(2.5727779865264893R))
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
        Me.TextBox66.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.600001335144043R), Telerik.Reporting.Drawing.Unit.Cm(2.5727779865264893R))
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
        Me.TextBox67.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.67437744140625R), Telerik.Reporting.Drawing.Unit.Cm(2.9143834114074707R))
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
        Me.TextBox68.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.100001335144043R), Telerik.Reporting.Drawing.Unit.Cm(2.9143834114074707R))
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
        Me.Shape4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.11841068416833878R), Telerik.Reporting.Drawing.Unit.Cm(4.2322907447814941R))
        Me.Shape4.Name = "Shape4"
        Me.Shape4.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(18.799900054931641R), Telerik.Reporting.Drawing.Unit.Cm(0.12999999523162842R))
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.5R), Telerik.Reporting.Drawing.Unit.Cm(0.30000004172325134R))
        Me.PictureBox1.MimeType = "image/png"
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.40000057220459R), Telerik.Reporting.Drawing.Unit.Cm(1.9000003337860107R))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox1.Value = CType(resources.GetObject("PictureBox1.Value"), Object)
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.14000013470649719R), Telerik.Reporting.Drawing.Unit.Cm(5.5322914123535156R))
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
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0500006675720215R), Telerik.Reporting.Drawing.Unit.Cm(5.5322914123535156R))
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
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.9479188919067383R), Telerik.Reporting.Drawing.Unit.Cm(5.0322918891906738R))
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
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.80000114440918R), Telerik.Reporting.Drawing.Unit.Cm(5.0322918891906738R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.3860430717468262R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox24.Style.Color = System.Drawing.Color.Black
        Me.TextBox24.Style.Font.Bold = False
        Me.TextBox24.Style.Font.Name = "Arial"
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox24.Value = "= Fields.ClienteTelefono"
        '
        'TextBox22
        '
        Me.TextBox22.Format = "{0:d}"
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.440000057220459R), Telerik.Reporting.Drawing.Unit.Cm(1.4999992847442627R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3784112930297852R), Telerik.Reporting.Drawing.Unit.Cm(0.617395281791687R))
        Me.TextBox22.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox22.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.TextBox22.Style.Color = System.Drawing.Color.Black
        Me.TextBox22.Style.Font.Bold = True
        Me.TextBox22.Style.Font.Name = "Arial"
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.TextWrap = True
        Me.TextBox22.Value = "Entrada"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R), Telerik.Reporting.Drawing.Unit.Cm(1.4999992847442627R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4315916299819946R), Telerik.Reporting.Drawing.Unit.Cm(0.617395281791687R))
        Me.TextBox21.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox21.Style.Color = System.Drawing.Color.Black
        Me.TextBox21.Style.Font.Bold = True
        Me.TextBox21.Style.Font.Name = "Arial"
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.Value = "N° Orden"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.399999618530273R), Telerik.Reporting.Drawing.Unit.Cm(1.4999992847442627R))
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
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(1.4999992847442627R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.5799999237060547R), Telerik.Reporting.Drawing.Unit.Cm(0.62000000476837158R))
        Me.TextBox11.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox11.Style.Color = System.Drawing.Color.Black
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Name = "Arial"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "Motivo Reparación"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.8199999332427979R), Telerik.Reporting.Drawing.Unit.Cm(1.4999992847442627R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.380000114440918R), Telerik.Reporting.Drawing.Unit.Cm(0.62000000476837158R))
        Me.TextBox20.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox20.Style.Color = System.Drawing.Color.Black
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Style.Font.Name = "Arial"
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.Value = "Salida"
        '
        'Shape6
        '
        Me.Shape6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.4099999666213989R), Telerik.Reporting.Drawing.Unit.Cm(1.4999992847442627R))
        Me.Shape6.Name = "Shape6"
        Me.Shape6.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        '
        'Shape9
        '
        Me.Shape9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.7999999523162842R), Telerik.Reporting.Drawing.Unit.Cm(1.4999992847442627R))
        Me.Shape9.Name = "Shape9"
        Me.Shape9.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        '
        'Shape11
        '
        Me.Shape11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.179999828338623R), Telerik.Reporting.Drawing.Unit.Cm(1.4999992847442627R))
        Me.Shape11.Name = "Shape11"
        Me.Shape11.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        '
        'Shape14
        '
        Me.Shape14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(16.3799991607666R), Telerik.Reporting.Drawing.Unit.Cm(1.4999992847442627R))
        Me.Shape14.Name = "Shape14"
        Me.Shape14.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.5R), Telerik.Reporting.Drawing.Unit.Cm(0.78531301021575928R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.060122013092041R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox4.Style.Color = System.Drawing.Color.Black
        Me.TextBox4.Style.Font.Bold = False
        Me.TextBox4.Style.Font.Name = "Arial"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox4.Value = "= Fields.TipoVehiculo"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.8184118270874023R), Telerik.Reporting.Drawing.Unit.Cm(0.78531301021575928R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6815881729125977R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox5.Style.Color = System.Drawing.Color.Black
        Me.TextBox5.Style.Font.Bold = True
        Me.TextBox5.Style.Font.Name = "Arial"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox5.Value = "Tipo de Vehículo:"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.9997987747192383R), Telerik.Reporting.Drawing.Unit.Cm(0.28260466456413269R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6000001430511475R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox15.Style.Color = System.Drawing.Color.Black
        Me.TextBox15.Style.Font.Bold = True
        Me.TextBox15.Style.Font.Name = "Arial"
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox15.Value = "Vehículo:"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.14166750013828278R), Telerik.Reporting.Drawing.Unit.Cm(0.78531301021575928R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3767440319061279R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox16.Style.Color = System.Drawing.Color.Black
        Me.TextBox16.Style.Font.Bold = True
        Me.TextBox16.Style.Font.Name = "Arial"
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox16.Value = "Modelo:"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.14166750013828278R), Telerik.Reporting.Drawing.Unit.Cm(0.28260466456413269R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7286186218261719R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox19.Style.Color = System.Drawing.Color.Black
        Me.TextBox19.Style.Font.Bold = True
        Me.TextBox19.Style.Font.Name = "Arial"
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox19.Value = "Matrícula:"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.6000003814697266R), Telerik.Reporting.Drawing.Unit.Cm(0.28260466456413269R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.45939826965332R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox23.Style.Color = System.Drawing.Color.Black
        Me.TextBox23.Style.Font.Bold = False
        Me.TextBox23.Style.Font.Name = "Arial"
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox23.Value = "= Fields.VehiculoNombre"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.51841139793396R), Telerik.Reporting.Drawing.Unit.Cm(0.78531301021575928R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9000008106231689R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox25.Style.Color = System.Drawing.Color.Black
        Me.TextBox25.Style.Font.Bold = False
        Me.TextBox25.Style.Font.Name = "Arial"
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox25.Value = "= Fields.VehiculoModelo"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.8184115886688232R), Telerik.Reporting.Drawing.Unit.Cm(0.28260466456413269R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox26.Style.Color = System.Drawing.Color.Black
        Me.TextBox26.Style.Font.Bold = False
        Me.TextBox26.Style.Font.Name = "Arial"
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox26.Value = "= Fields.VehiculoMatricula"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.300000190734863R), Telerik.Reporting.Drawing.Unit.Cm(0.78531301021575928R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0112497806549072R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox7.Style.Color = System.Drawing.Color.Black
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Arial"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox7.Value = "Año de Fabricación:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.30000114440918R), Telerik.Reporting.Drawing.Unit.Cm(0.78531301021575928R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8813905715942383R), Telerik.Reporting.Drawing.Unit.Cm(0.40000060200691223R))
        Me.TextBox8.Style.Color = System.Drawing.Color.Black
        Me.TextBox8.Style.Font.Bold = False
        Me.TextBox8.Style.Font.Name = "Arial"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox8.Value = "= Fields.VehiculoañoFabricacion"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Mecanica_Gaido_frm.My.MySettings.PIN_GRUPO31ConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@ID_Persona", System.Data.DbType.Int32, "=Parameters.ID_Persona.Value")})
        Me.SqlDataSource1.SelectCommand = "dbo.Consultar_Historial_Reparaciones"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(2.1199991703033447R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox19, Me.TextBox5, Me.TextBox15, Me.TextBox16, Me.TextBox4, Me.TextBox23, Me.TextBox25, Me.TextBox26, Me.TextBox7, Me.TextBox8, Me.TextBox22, Me.TextBox21, Me.TextBox14, Me.TextBox11, Me.TextBox20, Me.Shape6, Me.Shape9, Me.Shape11, Me.Shape14, Me.TextBox27, Me.Shape2})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        Me.groupHeaderSection.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.groupHeaderSection.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.63061058521270752R)
        Me.groupFooterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox54, Me.TextBox53, Me.TextBox56, Me.TextBox36, Me.TextBox72, Me.TextBox28, Me.Shape29, Me.Shape16, Me.Shape15, Me.Shape1, Me.Shape3})
        Me.groupFooterSection.Name = "groupFooterSection"
        Me.groupFooterSection.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'Shape1
        '
        Me.Shape1.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Top Or Telerik.Reporting.AnchoringStyles.Bottom), Telerik.Reporting.AnchoringStyles)
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.179999828338623R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(0.38999998569488525R))
        '
        'TextBox27
        '
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.779999732971191R), Telerik.Reporting.Drawing.Unit.Cm(1.4999992847442627R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.619999885559082R), Telerik.Reporting.Drawing.Unit.Cm(0.62000000476837158R))
        Me.TextBox27.Style.BackgroundColor = System.Drawing.Color.Silver
        Me.TextBox27.Style.Color = System.Drawing.Color.Black
        Me.TextBox27.Style.Font.Bold = True
        Me.TextBox27.Style.Font.Name = "Arial"
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox27.Value = "Monto Repuestos"
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.760000228881836R), Telerik.Reporting.Drawing.Unit.Cm(1.4999992847442627R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        '
        'TextBox28
        '
        Me.TextBox28.Format = "{0:N2}"
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.079999998211860657R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.5799999237060547R), Telerik.Reporting.Drawing.Unit.Cm(0.31000000238418579R))
        Me.TextBox28.Style.Color = System.Drawing.Color.Black
        Me.TextBox28.Style.Font.Bold = False
        Me.TextBox28.Style.Font.Name = "Arial"
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.Value = "= Fields.OrdenMotivo"
        '
        'Shape3
        '
        Me.Shape3.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Top Or Telerik.Reporting.AnchoringStyles.Bottom), Telerik.Reporting.AnchoringStyles)
        Me.Shape3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.760000228881836R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Shape3.Name = "Shape3"
        Me.Shape3.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.NS)
        Me.Shape3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.15000000596046448R), Telerik.Reporting.Drawing.Unit.Cm(0.38999998569488525R))
        '
        'RptHistorialCliente
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.VehiculoNumero"))
        Group1.Name = "GrupoVehiculo"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail, Me.EncabezadoHistorial, Me.groupHeaderSection, Me.groupFooterSection})
        Me.Name = "RptHistorialCliente"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(8.0R), Telerik.Reporting.Drawing.Unit.Mm(8.0R), Telerik.Reporting.Drawing.Unit.Mm(6.0R), Telerik.Reporting.Drawing.Unit.Mm(5.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "ID_Persona"
        ReportParameter1.Text = "@ID_Persona"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        Me.ReportParameters.Add(ReportParameter1)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(19.118310928344727R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents Shape15 As Telerik.Reporting.Shape
    Friend WithEvents TextBox53 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox54 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox56 As Telerik.Reporting.TextBox
    Friend WithEvents EncabezadoHistorial As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox55 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox59 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox60 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox61 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox62 As Telerik.Reporting.TextBox
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
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents Shape16 As Telerik.Reporting.Shape
    Friend WithEvents Shape29 As Telerik.Reporting.Shape
    Friend WithEvents Shape9 As Telerik.Reporting.Shape
    Friend WithEvents Shape11 As Telerik.Reporting.Shape
    Friend WithEvents Shape14 As Telerik.Reporting.Shape
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents Shape3 As Telerik.Reporting.Shape
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
End Class