Partial Class rptListasCompra
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TextBox7 As Telerik.Reporting.TextBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptListasCompra))
        Dim TextBox8 As Telerik.Reporting.TextBox
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.DetailSection1 = New Telerik.Reporting.DetailSection()
        Me.List2 = New Telerik.Reporting.List()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.dsListasCompra = New Telerik.Reporting.ObjectDataSource()
        Me.PageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        TextBox7 = New Telerik.Reporting.TextBox()
        TextBox8 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TextBox7
        '
        TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.9999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        TextBox7.Name = "ReportNameTextBox"
        TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9999995231628418R), Telerik.Reporting.Drawing.Unit.Cm(0.49999994039535522R))
        TextBox7.Style.Font.Bold = False
        TextBox7.Style.Font.Name = "Lucida Sans Unicode"
        TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        resources.ApplyResources(TextBox7, "TextBox7")
        '
        'TextBox8
        '
        TextBox8.Culture = New System.Globalization.CultureInfo("")
        TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0001001020209514536R), Telerik.Reporting.Drawing.Unit.Cm(0.50019979476928711R))
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.9998002052307129R), Telerik.Reporting.Drawing.Unit.Cm(1.7998000383377075R))
        TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        resources.ApplyResources(TextBox8, "TextBox8")
        '
        'DetailSection1
        '
        Me.DetailSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(1.7000004053115845R)
        Me.DetailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.List2})
        Me.DetailSection1.Name = "DetailSection1"
        '
        'List2
        '
        Me.List2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(7.0R)))
        Me.List2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(1.7000004053115845R)))
        Me.List2.Body.SetCellContent(0, 0, Me.TextBox1)
        TableGroup1.Name = "group"
        Me.List2.ColumnGroups.Add(TableGroup1)
        Me.List2.DataSource = Me.dsListasCompra
        Me.List2.Docking = Telerik.Reporting.DockingStyle.Fill
        Me.List2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1})
        Me.List2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.000099921220680698752R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
        Me.List2.Name = "List2"
        TableGroup2.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup2.Name = "DetailGroup"
        Me.List2.RowGroups.Add(TableGroup2)
        Me.List2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.0R), Telerik.Reporting.Drawing.Unit.Cm(1.7000004053115845R))
        '
        'TextBox1
        '
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.0R), Telerik.Reporting.Drawing.Unit.Cm(1.7000004053115845R))
        Me.TextBox1.StyleName = ""
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        '
        'dsListasCompra
        '
        Me.dsListasCompra.DataSource = GetType(EasyGestControllers.Data.Entity.ListasCompra)
        Me.dsListasCompra.Name = "dsListasCompra"
        '
        'PageHeaderSection1
        '
        Me.PageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.3999998569488525R)
        Me.PageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {TextBox7, TextBox8})
        Me.PageHeaderSection1.Name = "PageHeaderSection1"
        '
        'rptListasCompra
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.DetailSection1, Me.PageHeaderSection1})
        Me.Name = "rptListasCompra"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Apex.TableNormal")})
        StyleRule2.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule2.Style.Color = System.Drawing.Color.Black
        StyleRule2.Style.Font.Name = "Book Antiqua"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Apex.TableHeader")})
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
        StyleRule3.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(109, Byte), Integer))
        StyleRule3.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule3.Style.Color = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(102, Byte), Integer))
        StyleRule3.Style.Font.Name = "Book Antiqua"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Apex.TableBody")})
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule4.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule4.Style.Font.Name = "Book Antiqua"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(8.0R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents DetailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents dsListasCompra As Telerik.Reporting.ObjectDataSource
    Friend WithEvents PageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents List2 As Telerik.Reporting.List
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
End Class