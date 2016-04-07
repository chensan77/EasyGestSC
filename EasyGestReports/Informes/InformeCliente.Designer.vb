
Namespace EasyGestReports.Informes
    Partial Class InformeCliente

        'NOTE: The following procedure is required by the telerik Reporting Designer
        'It can be modified using the telerik Reporting Designer.  
        'Do not modify it using the code editor.
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformeCliente))
            Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
            Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
            Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
            Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
            Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
            Dim TableGroup6 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
            Dim TableGroup7 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
            Dim TableGroup8 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
            Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
            Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
            Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
            Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
            Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
            Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
            Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
            Me.TextBox15 = New Telerik.Reporting.TextBox()
            Me.detail = New Telerik.Reporting.DetailSection()
            Me.Table1 = New Telerik.Reporting.Table()
            Me.TextBox8 = New Telerik.Reporting.TextBox()
            Me.TextBox9 = New Telerik.Reporting.TextBox()
            Me.TextBox10 = New Telerik.Reporting.TextBox()
            Me.TextBox11 = New Telerik.Reporting.TextBox()
            Me.TextBox12 = New Telerik.Reporting.TextBox()
            Me.TextBox13 = New Telerik.Reporting.TextBox()
            Me.TextBox14 = New Telerik.Reporting.TextBox()
            Me.DSClientes = New Telerik.Reporting.ObjectDataSource()
            Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
            Me.TextBox7 = New Telerik.Reporting.TextBox()
            Me.TextBox6 = New Telerik.Reporting.TextBox()
            Me.TextBox5 = New Telerik.Reporting.TextBox()
            Me.TextBox4 = New Telerik.Reporting.TextBox()
            Me.TextBox3 = New Telerik.Reporting.TextBox()
            Me.TextBox2 = New Telerik.Reporting.TextBox()
            Me.TextBox1 = New Telerik.Reporting.TextBox()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'pageHeaderSection1
            '
            Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(1.2999999523162842R)
            Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox15})
            Me.pageHeaderSection1.Name = "pageHeaderSection1"
            '
            'TextBox15
            '
            Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.30000004172325134R))
            Me.TextBox15.Name = "TextBox15"
            Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.40000057220459R), Telerik.Reporting.Drawing.Unit.Cm(0.59999990463256836R))
            resources.ApplyResources(Me.TextBox15, "TextBox15")
            '
            'detail
            '
            Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(1.5000001192092896R)
            Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table1})
            Me.detail.Name = "detail"
            '
            'Table1
            '
            Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.3758318424224854R)))
            Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(5.6777129173278809R)))
            Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(4.7516632080078125R)))
            Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.8412503004074097R)))
            Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.550208330154419R)))
            Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.6824992895126343R)))
            Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.3649992942810059R)))
            Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.97624987363815308R)))
            Me.Table1.Body.SetCellContent(0, 0, Me.TextBox8)
            Me.Table1.Body.SetCellContent(0, 1, Me.TextBox9)
            Me.Table1.Body.SetCellContent(0, 2, Me.TextBox10)
            Me.Table1.Body.SetCellContent(0, 3, Me.TextBox11)
            Me.Table1.Body.SetCellContent(0, 4, Me.TextBox12)
            Me.Table1.Body.SetCellContent(0, 5, Me.TextBox13)
            Me.Table1.Body.SetCellContent(0, 6, Me.TextBox14)
            TableGroup1.ReportItem = Me.TextBox1
            TableGroup2.ReportItem = Me.TextBox2
            TableGroup3.ReportItem = Me.TextBox3
            TableGroup4.ReportItem = Me.TextBox4
            TableGroup5.ReportItem = Me.TextBox5
            TableGroup6.ReportItem = Me.TextBox6
            TableGroup7.ReportItem = Me.TextBox7
            Me.Table1.ColumnGroups.Add(TableGroup1)
            Me.Table1.ColumnGroups.Add(TableGroup2)
            Me.Table1.ColumnGroups.Add(TableGroup3)
            Me.Table1.ColumnGroups.Add(TableGroup4)
            Me.Table1.ColumnGroups.Add(TableGroup5)
            Me.Table1.ColumnGroups.Add(TableGroup6)
            Me.Table1.ColumnGroups.Add(TableGroup7)
            Me.Table1.DataSource = Me.DSClientes
            Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7})
            Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
            Me.Table1.Name = "Table1"
            TableGroup8.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
            TableGroup8.Name = "Detail"
            Me.Table1.RowGroups.Add(TableGroup8)
            Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.244165420532227R), Telerik.Reporting.Drawing.Unit.Cm(1.3968749046325684R))
            Me.Table1.StyleName = "Civic.TableNormal"
            '
            'TextBox8
            '
            Me.TextBox8.Name = "TextBox8"
            Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3758320808410645R), Telerik.Reporting.Drawing.Unit.Cm(0.9762500524520874R))
            Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
            Me.TextBox8.StyleName = "Civic.TableBody"
            resources.ApplyResources(Me.TextBox8, "TextBox8")
            '
            'TextBox9
            '
            Me.TextBox9.Name = "TextBox9"
            Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.6777133941650391R), Telerik.Reporting.Drawing.Unit.Cm(0.9762500524520874R))
            Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
            Me.TextBox9.StyleName = "Civic.TableBody"
            resources.ApplyResources(Me.TextBox9, "TextBox9")
            '
            'TextBox10
            '
            Me.TextBox10.Name = "TextBox10"
            Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7516641616821289R), Telerik.Reporting.Drawing.Unit.Cm(0.9762500524520874R))
            Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
            Me.TextBox10.StyleName = "Civic.TableBody"
            resources.ApplyResources(Me.TextBox10, "TextBox10")
            '
            'TextBox11
            '
            Me.TextBox11.Name = "TextBox11"
            Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8412504196166992R), Telerik.Reporting.Drawing.Unit.Cm(0.9762500524520874R))
            Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
            Me.TextBox11.StyleName = "Civic.TableBody"
            resources.ApplyResources(Me.TextBox11, "TextBox11")
            '
            'TextBox12
            '
            Me.TextBox12.Name = "TextBox12"
            Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5502084493637085R), Telerik.Reporting.Drawing.Unit.Cm(0.9762500524520874R))
            Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
            Me.TextBox12.StyleName = "Civic.TableBody"
            resources.ApplyResources(Me.TextBox12, "TextBox12")
            '
            'TextBox13
            '
            Me.TextBox13.Name = "TextBox13"
            Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6824994087219238R), Telerik.Reporting.Drawing.Unit.Cm(0.9762500524520874R))
            Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
            Me.TextBox13.StyleName = "Civic.TableBody"
            resources.ApplyResources(Me.TextBox13, "TextBox13")
            '
            'TextBox14
            '
            Me.TextBox14.Name = "TextBox14"
            Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3649994134902954R), Telerik.Reporting.Drawing.Unit.Cm(0.9762500524520874R))
            Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
            Me.TextBox14.StyleName = "Civic.TableBody"
            resources.ApplyResources(Me.TextBox14, "TextBox14")
            '
            'DSClientes
            '
            Me.DSClientes.DataSource = GetType(EasyGestControllers.Data.Entity.VWClientes)
            Me.DSClientes.Name = "DSClientes"
            '
            'pageFooterSection1
            '
            Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.60000014305114746R)
            Me.pageFooterSection1.Name = "pageFooterSection1"
            '
            'TextBox7
            '
            Me.TextBox7.Name = "TextBox7"
            Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3649994134902954R), Telerik.Reporting.Drawing.Unit.Cm(0.4206250011920929R))
            Me.TextBox7.StyleName = "Civic.TableHeader"
            resources.ApplyResources(Me.TextBox7, "TextBox7")
            '
            'TextBox6
            '
            Me.TextBox6.Name = "TextBox6"
            Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6824994087219238R), Telerik.Reporting.Drawing.Unit.Cm(0.4206250011920929R))
            Me.TextBox6.StyleName = "Civic.TableHeader"
            resources.ApplyResources(Me.TextBox6, "TextBox6")
            '
            'TextBox5
            '
            Me.TextBox5.Name = "TextBox5"
            Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5502084493637085R), Telerik.Reporting.Drawing.Unit.Cm(0.4206250011920929R))
            Me.TextBox5.StyleName = "Civic.TableHeader"
            resources.ApplyResources(Me.TextBox5, "TextBox5")
            '
            'TextBox4
            '
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8412504196166992R), Telerik.Reporting.Drawing.Unit.Cm(0.4206250011920929R))
            Me.TextBox4.StyleName = "Civic.TableHeader"
            resources.ApplyResources(Me.TextBox4, "TextBox4")
            '
            'TextBox3
            '
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7516641616821289R), Telerik.Reporting.Drawing.Unit.Cm(0.4206250011920929R))
            Me.TextBox3.StyleName = "Civic.TableHeader"
            resources.ApplyResources(Me.TextBox3, "TextBox3")
            '
            'TextBox2
            '
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.6777133941650391R), Telerik.Reporting.Drawing.Unit.Cm(0.4206250011920929R))
            Me.TextBox2.StyleName = "Civic.TableHeader"
            resources.ApplyResources(Me.TextBox2, "TextBox2")
            '
            'TextBox1
            '
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3758320808410645R), Telerik.Reporting.Drawing.Unit.Cm(0.4206250011920929R))
            Me.TextBox1.StyleName = "Civic.TableHeader"
            resources.ApplyResources(Me.TextBox1, "TextBox1")
            '
            'InformeCliente
            '
            Me.DataSource = Me.DSClientes
            Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
            Me.Name = "InformeCliente"
            Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273R))
            Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
            StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
            StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
            StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Civic.TableNormal")})
            StyleRule2.Style.BorderColor.Default = System.Drawing.Color.Black
            StyleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
            StyleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
            StyleRule2.Style.Color = System.Drawing.Color.Black
            StyleRule2.Style.Font.Name = "Georgia"
            StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
            DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Civic.TableBody")})
            StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
            StyleRule3.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            StyleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
            StyleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
            StyleRule3.Style.Color = System.Drawing.Color.DarkOliveGreen
            StyleRule3.Style.Font.Name = "Georgia"
            StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
            DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Civic.TableHeader")})
            StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
            StyleRule4.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(173, Byte), Integer))
            StyleRule4.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            StyleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
            StyleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
            StyleRule4.Style.Color = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer))
            StyleRule4.Style.Font.Name = "Georgia"
            StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
            StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
            Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
            Me.Width = Telerik.Reporting.Drawing.Unit.Cm(20.299999237060547R)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
        Friend WithEvents detail As Telerik.Reporting.DetailSection
        Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
        Friend WithEvents Table1 As Telerik.Reporting.Table
        Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
        Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
        Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
        Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
        Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
        Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
        Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
        Friend WithEvents DSClientes As Telerik.Reporting.ObjectDataSource
        Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
        Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
        Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
        Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
        Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
        Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
        Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
        Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    End Class

End Namespace