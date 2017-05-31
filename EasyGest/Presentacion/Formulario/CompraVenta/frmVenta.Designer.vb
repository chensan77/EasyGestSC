Namespace Presentacion.Formulario.CompraVenta
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmVenta
        Inherits Telerik.WinControls.UI.RadForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Me.cbstripeAccion = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbbtnCrear = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnCancelar = New Telerik.WinControls.UI.CommandBarButton()
            Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.cbbtnTerminar = New Telerik.WinControls.UI.CommandBarButton()
            Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
            Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.cbstripeBuscar = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbbtnBuscarCliente = New Telerik.WinControls.UI.CommandBarDropDownButton()
            Me.mitemCrearCliente = New Telerik.WinControls.UI.RadMenuItem()
            Me.cbbtnBuscarProducto = New Telerik.WinControls.UI.CommandBarDropDownButton()
            Me.mitemCrearProducto = New Telerik.WinControls.UI.RadMenuItem()
            Me.cbstripeSerie = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.CommandBarLabel1 = New Telerik.WinControls.UI.CommandBarLabel()
            Me.cbddlSeries = New Telerik.WinControls.UI.CommandBarDropDownList()
            Me.dockVenta = New Telerik.WinControls.UI.Docking.RadDock()
            Me.ToolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            Me.txtCliente = New Telerik.WinControls.UI.RadTextBox()
            Me.RadSeparator1 = New Telerik.WinControls.UI.RadSeparator()
            Me.txtIntroduccion = New Telerik.WinControls.UI.RadTextBoxControl()
            Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.lblVentaActual = New Telerik.WinControls.UI.RadLabel()
            Me.ToolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.RadSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.doccVentas = New Telerik.WinControls.UI.Docking.DocumentContainer()
            Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
            Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
            Me.pagevVentas = New Telerik.WinControls.UI.RadPageView()
            Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.gridUltimosVentas = New Telerik.WinControls.UI.RadGridView()
            Me.VWAlbaranesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.ToolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
            Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
            Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.lblNumPieza = New Telerik.WinControls.UI.RadLabel()
            Me.lblUnidadVenta = New Telerik.WinControls.UI.RadLabel()
            Me.lblTotal = New Telerik.WinControls.UI.RadLabel()
            Me.lblStockActual = New Telerik.WinControls.UI.RadLabel()
            Me.cmenuUltimasVentas = New Telerik.WinControls.UI.RadContextMenu(Me.components)
            Me.mitemImprimir = New Telerik.WinControls.UI.RadMenuItem()
            Me.cmenuLineaAlbaran = New Telerik.WinControls.UI.RadContextMenu(Me.components)
            Me.mitemModificarProducto = New Telerik.WinControls.UI.RadMenuItem()
            Me.LineasAlbaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockVenta.SuspendLayout()
            Me.ToolWindow3.SuspendLayout()
            CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtIntroduccion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblVentaActual, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolTabStrip3.SuspendLayout()
            CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer2.SuspendLayout()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer1.SuspendLayout()
            CType(Me.doccVentas, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.doccVentas.SuspendLayout()
            CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DocumentTabStrip1.SuspendLayout()
            Me.DocumentWindow1.SuspendLayout()
            CType(Me.pagevVentas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolTabStrip1.SuspendLayout()
            Me.ToolWindow1.SuspendLayout()
            CType(Me.gridUltimosVentas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridUltimosVentas.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.VWAlbaranesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolTabStrip2.SuspendLayout()
            Me.ToolWindow2.SuspendLayout()
            CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblNumPieza, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblUnidadVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblStockActual, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LineasAlbaranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cbstripeAccion
            '
            resources.ApplyResources(Me.cbstripeAccion, "cbstripeAccion")
            '
            '
            '
            Me.cbstripeAccion.Grip.Alignment = CType(resources.GetObject("resource.Alignment"), System.Drawing.ContentAlignment)
            Me.cbstripeAccion.Grip.AngleTransform = CType(resources.GetObject("resource.AngleTransform"), Single)
            Me.cbstripeAccion.Grip.FlipText = CType(resources.GetObject("resource.FlipText"), Boolean)
            Me.cbstripeAccion.Grip.Margin = CType(resources.GetObject("resource.Margin"), System.Windows.Forms.Padding)
            Me.cbstripeAccion.Grip.Padding = CType(resources.GetObject("resource.Padding"), System.Windows.Forms.Padding)
            Me.cbstripeAccion.Grip.RightToLeft = CType(resources.GetObject("resource.RightToLeft"), Boolean)
            Me.cbstripeAccion.Grip.Text = resources.GetString("resource.Text")
            Me.cbstripeAccion.Grip.TextOrientation = CType(resources.GetObject("resource.TextOrientation"), System.Windows.Forms.Orientation)
            Me.cbstripeAccion.Grip.TextWrap = CType(resources.GetObject("resource.TextWrap"), Boolean)
            Me.cbstripeAccion.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbtnCrear, Me.cbbtnCancelar, Me.CommandBarSeparator1, Me.cbbtnTerminar})
            Me.cbstripeAccion.Name = "cbstripeAccion"
            '
            '
            '
            Me.cbstripeAccion.OverflowButton.Alignment = CType(resources.GetObject("resource.Alignment1"), System.Drawing.ContentAlignment)
            Me.cbstripeAccion.OverflowButton.AngleTransform = CType(resources.GetObject("resource.AngleTransform1"), Single)
            Me.cbstripeAccion.OverflowButton.FlipText = CType(resources.GetObject("resource.FlipText1"), Boolean)
            Me.cbstripeAccion.OverflowButton.Margin = CType(resources.GetObject("resource.Margin1"), System.Windows.Forms.Padding)
            Me.cbstripeAccion.OverflowButton.Padding = CType(resources.GetObject("resource.Padding1"), System.Windows.Forms.Padding)
            Me.cbstripeAccion.OverflowButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft1"), Boolean)
            Me.cbstripeAccion.OverflowButton.Text = resources.GetString("resource.Text1")
            Me.cbstripeAccion.OverflowButton.TextOrientation = CType(resources.GetObject("resource.TextOrientation1"), System.Windows.Forms.Orientation)
            Me.cbstripeAccion.OverflowButton.TextWrap = CType(resources.GetObject("resource.TextWrap1"), Boolean)
            CType(Me.cbstripeAccion.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextWrap = CType(resources.GetObject("resource.TextWrap2"), Boolean)
            CType(Me.cbstripeAccion.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextOrientation = CType(resources.GetObject("resource.TextOrientation2"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeAccion.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).FlipText = CType(resources.GetObject("resource.FlipText2"), Boolean)
            CType(Me.cbstripeAccion.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Text = resources.GetString("resource.Text2")
            CType(Me.cbstripeAccion.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Padding = CType(resources.GetObject("resource.Padding2"), System.Windows.Forms.Padding)
            CType(Me.cbstripeAccion.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Margin = CType(resources.GetObject("resource.Margin2"), System.Windows.Forms.Padding)
            CType(Me.cbstripeAccion.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Alignment = CType(resources.GetObject("resource.Alignment2"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeAccion.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).RightToLeft = CType(resources.GetObject("resource.RightToLeft2"), Boolean)
            CType(Me.cbstripeAccion.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).AngleTransform = CType(resources.GetObject("resource.AngleTransform2"), Single)
            CType(Me.cbstripeAccion.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextWrap = CType(resources.GetObject("resource.TextWrap3"), Boolean)
            CType(Me.cbstripeAccion.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextOrientation = CType(resources.GetObject("resource.TextOrientation3"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeAccion.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).FlipText = CType(resources.GetObject("resource.FlipText3"), Boolean)
            CType(Me.cbstripeAccion.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Text = resources.GetString("resource.Text3")
            CType(Me.cbstripeAccion.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Padding = CType(resources.GetObject("resource.Padding3"), System.Windows.Forms.Padding)
            CType(Me.cbstripeAccion.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Margin = CType(resources.GetObject("resource.Margin3"), System.Windows.Forms.Padding)
            CType(Me.cbstripeAccion.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Alignment = CType(resources.GetObject("resource.Alignment3"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeAccion.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).RightToLeft = CType(resources.GetObject("resource.RightToLeft3"), Boolean)
            CType(Me.cbstripeAccion.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).AngleTransform = CType(resources.GetObject("resource.AngleTransform3"), Single)
            '
            'cbbtnCrear
            '
            resources.ApplyResources(Me.cbbtnCrear, "cbbtnCrear")
            Me.cbbtnCrear.DrawText = True
            Me.cbbtnCrear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnCrear.Image = Global.EasyGest.My.Resources.Resources._112
            Me.cbbtnCrear.Name = "cbbtnCrear"
            Me.cbbtnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'cbbtnCancelar
            '
            resources.ApplyResources(Me.cbbtnCancelar, "cbbtnCancelar")
            Me.cbbtnCancelar.DrawText = True
            Me.cbbtnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnCancelar.Image = Global.EasyGest.My.Resources.Resources._116
            Me.cbbtnCancelar.Name = "cbbtnCancelar"
            Me.cbbtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'CommandBarSeparator1
            '
            resources.ApplyResources(Me.CommandBarSeparator1, "CommandBarSeparator1")
            Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
            Me.CommandBarSeparator1.VisibleInOverflowMenu = False
            '
            'cbbtnTerminar
            '
            resources.ApplyResources(Me.cbbtnTerminar, "cbbtnTerminar")
            Me.cbbtnTerminar.DrawText = True
            Me.cbbtnTerminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnTerminar.Image = CType(resources.GetObject("cbbtnTerminar.Image"), System.Drawing.Image)
            Me.cbbtnTerminar.Name = "cbbtnTerminar"
            Me.cbbtnTerminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'RadCommandBar1
            '
            resources.ApplyResources(Me.RadCommandBar1, "RadCommandBar1")
            Me.RadCommandBar1.Name = "RadCommandBar1"
            Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
            '
            'CommandBarRowElement1
            '
            resources.ApplyResources(Me.CommandBarRowElement1, "CommandBarRowElement1")
            Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
            Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.cbstripeAccion, Me.cbstripeBuscar, Me.cbstripeSerie})
            '
            'cbstripeBuscar
            '
            resources.ApplyResources(Me.cbstripeBuscar, "cbstripeBuscar")
            '
            '
            '
            Me.cbstripeBuscar.Grip.Alignment = CType(resources.GetObject("resource.Alignment4"), System.Drawing.ContentAlignment)
            Me.cbstripeBuscar.Grip.AngleTransform = CType(resources.GetObject("resource.AngleTransform4"), Single)
            Me.cbstripeBuscar.Grip.FlipText = CType(resources.GetObject("resource.FlipText4"), Boolean)
            Me.cbstripeBuscar.Grip.Margin = CType(resources.GetObject("resource.Margin4"), System.Windows.Forms.Padding)
            Me.cbstripeBuscar.Grip.Padding = CType(resources.GetObject("resource.Padding4"), System.Windows.Forms.Padding)
            Me.cbstripeBuscar.Grip.RightToLeft = CType(resources.GetObject("resource.RightToLeft4"), Boolean)
            Me.cbstripeBuscar.Grip.Text = resources.GetString("resource.Text4")
            Me.cbstripeBuscar.Grip.TextOrientation = CType(resources.GetObject("resource.TextOrientation4"), System.Windows.Forms.Orientation)
            Me.cbstripeBuscar.Grip.TextWrap = CType(resources.GetObject("resource.TextWrap4"), Boolean)
            Me.cbstripeBuscar.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbtnBuscarCliente, Me.cbbtnBuscarProducto})
            Me.cbstripeBuscar.Name = "cbstripeBuscar"
            '
            '
            '
            Me.cbstripeBuscar.OverflowButton.Alignment = CType(resources.GetObject("resource.Alignment5"), System.Drawing.ContentAlignment)
            Me.cbstripeBuscar.OverflowButton.AngleTransform = CType(resources.GetObject("resource.AngleTransform5"), Single)
            Me.cbstripeBuscar.OverflowButton.FlipText = CType(resources.GetObject("resource.FlipText5"), Boolean)
            Me.cbstripeBuscar.OverflowButton.Margin = CType(resources.GetObject("resource.Margin5"), System.Windows.Forms.Padding)
            Me.cbstripeBuscar.OverflowButton.Padding = CType(resources.GetObject("resource.Padding5"), System.Windows.Forms.Padding)
            Me.cbstripeBuscar.OverflowButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft5"), Boolean)
            Me.cbstripeBuscar.OverflowButton.Text = resources.GetString("resource.Text5")
            Me.cbstripeBuscar.OverflowButton.TextOrientation = CType(resources.GetObject("resource.TextOrientation5"), System.Windows.Forms.Orientation)
            Me.cbstripeBuscar.OverflowButton.TextWrap = CType(resources.GetObject("resource.TextWrap5"), Boolean)
            CType(Me.cbstripeBuscar.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextWrap = CType(resources.GetObject("resource.TextWrap6"), Boolean)
            CType(Me.cbstripeBuscar.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextOrientation = CType(resources.GetObject("resource.TextOrientation6"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeBuscar.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).FlipText = CType(resources.GetObject("resource.FlipText6"), Boolean)
            CType(Me.cbstripeBuscar.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Text = resources.GetString("resource.Text6")
            CType(Me.cbstripeBuscar.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Padding = CType(resources.GetObject("resource.Padding6"), System.Windows.Forms.Padding)
            CType(Me.cbstripeBuscar.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Margin = CType(resources.GetObject("resource.Margin6"), System.Windows.Forms.Padding)
            CType(Me.cbstripeBuscar.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Alignment = CType(resources.GetObject("resource.Alignment6"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeBuscar.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).RightToLeft = CType(resources.GetObject("resource.RightToLeft6"), Boolean)
            CType(Me.cbstripeBuscar.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).AngleTransform = CType(resources.GetObject("resource.AngleTransform6"), Single)
            CType(Me.cbstripeBuscar.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextWrap = CType(resources.GetObject("resource.TextWrap7"), Boolean)
            CType(Me.cbstripeBuscar.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextOrientation = CType(resources.GetObject("resource.TextOrientation7"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeBuscar.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).FlipText = CType(resources.GetObject("resource.FlipText7"), Boolean)
            CType(Me.cbstripeBuscar.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Text = resources.GetString("resource.Text7")
            CType(Me.cbstripeBuscar.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Padding = CType(resources.GetObject("resource.Padding7"), System.Windows.Forms.Padding)
            CType(Me.cbstripeBuscar.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Margin = CType(resources.GetObject("resource.Margin7"), System.Windows.Forms.Padding)
            CType(Me.cbstripeBuscar.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Alignment = CType(resources.GetObject("resource.Alignment7"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeBuscar.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).RightToLeft = CType(resources.GetObject("resource.RightToLeft7"), Boolean)
            CType(Me.cbstripeBuscar.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).AngleTransform = CType(resources.GetObject("resource.AngleTransform7"), Single)
            '
            'cbbtnBuscarCliente
            '
            resources.ApplyResources(Me.cbbtnBuscarCliente, "cbbtnBuscarCliente")
            Me.cbbtnBuscarCliente.DrawText = True
            Me.cbbtnBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnBuscarCliente.Image = Global.EasyGest.My.Resources.Resources.User_2_Search
            Me.cbbtnBuscarCliente.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemCrearCliente})
            Me.cbbtnBuscarCliente.Name = "cbbtnBuscarCliente"
            Me.cbbtnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'mitemCrearCliente
            '
            resources.ApplyResources(Me.mitemCrearCliente, "mitemCrearCliente")
            Me.mitemCrearCliente.Image = Global.EasyGest.My.Resources.Resources.User_2_Add
            Me.mitemCrearCliente.Name = "mitemCrearCliente"
            '
            'cbbtnBuscarProducto
            '
            resources.ApplyResources(Me.cbbtnBuscarProducto, "cbbtnBuscarProducto")
            Me.cbbtnBuscarProducto.DrawText = True
            Me.cbbtnBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnBuscarProducto.Image = Global.EasyGest.My.Resources.Resources.File_Documents_Search
            Me.cbbtnBuscarProducto.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemCrearProducto})
            Me.cbbtnBuscarProducto.Name = "cbbtnBuscarProducto"
            Me.cbbtnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'mitemCrearProducto
            '
            resources.ApplyResources(Me.mitemCrearProducto, "mitemCrearProducto")
            Me.mitemCrearProducto.Image = Global.EasyGest.My.Resources.Resources.Folder_2_Add
            Me.mitemCrearProducto.Name = "mitemCrearProducto"
            '
            'cbstripeSerie
            '
            resources.ApplyResources(Me.cbstripeSerie, "cbstripeSerie")
            '
            '
            '
            Me.cbstripeSerie.Grip.Alignment = CType(resources.GetObject("resource.Alignment8"), System.Drawing.ContentAlignment)
            Me.cbstripeSerie.Grip.AngleTransform = CType(resources.GetObject("resource.AngleTransform8"), Single)
            Me.cbstripeSerie.Grip.FlipText = CType(resources.GetObject("resource.FlipText8"), Boolean)
            Me.cbstripeSerie.Grip.Margin = CType(resources.GetObject("resource.Margin8"), System.Windows.Forms.Padding)
            Me.cbstripeSerie.Grip.Padding = CType(resources.GetObject("resource.Padding8"), System.Windows.Forms.Padding)
            Me.cbstripeSerie.Grip.RightToLeft = CType(resources.GetObject("resource.RightToLeft8"), Boolean)
            Me.cbstripeSerie.Grip.Text = resources.GetString("resource.Text8")
            Me.cbstripeSerie.Grip.TextOrientation = CType(resources.GetObject("resource.TextOrientation8"), System.Windows.Forms.Orientation)
            Me.cbstripeSerie.Grip.TextWrap = CType(resources.GetObject("resource.TextWrap8"), Boolean)
            Me.cbstripeSerie.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.CommandBarLabel1, Me.cbddlSeries})
            Me.cbstripeSerie.Name = "cbstripeSerie"
            '
            '
            '
            Me.cbstripeSerie.OverflowButton.Alignment = CType(resources.GetObject("resource.Alignment9"), System.Drawing.ContentAlignment)
            Me.cbstripeSerie.OverflowButton.AngleTransform = CType(resources.GetObject("resource.AngleTransform9"), Single)
            Me.cbstripeSerie.OverflowButton.FlipText = CType(resources.GetObject("resource.FlipText9"), Boolean)
            Me.cbstripeSerie.OverflowButton.Margin = CType(resources.GetObject("resource.Margin9"), System.Windows.Forms.Padding)
            Me.cbstripeSerie.OverflowButton.Padding = CType(resources.GetObject("resource.Padding9"), System.Windows.Forms.Padding)
            Me.cbstripeSerie.OverflowButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft9"), Boolean)
            Me.cbstripeSerie.OverflowButton.Text = resources.GetString("resource.Text9")
            Me.cbstripeSerie.OverflowButton.TextOrientation = CType(resources.GetObject("resource.TextOrientation9"), System.Windows.Forms.Orientation)
            Me.cbstripeSerie.OverflowButton.TextWrap = CType(resources.GetObject("resource.TextWrap9"), Boolean)
            CType(Me.cbstripeSerie.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextWrap = CType(resources.GetObject("resource.TextWrap10"), Boolean)
            CType(Me.cbstripeSerie.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextOrientation = CType(resources.GetObject("resource.TextOrientation10"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeSerie.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).FlipText = CType(resources.GetObject("resource.FlipText10"), Boolean)
            CType(Me.cbstripeSerie.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Text = resources.GetString("resource.Text10")
            CType(Me.cbstripeSerie.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Padding = CType(resources.GetObject("resource.Padding10"), System.Windows.Forms.Padding)
            CType(Me.cbstripeSerie.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Margin = CType(resources.GetObject("resource.Margin10"), System.Windows.Forms.Padding)
            CType(Me.cbstripeSerie.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Alignment = CType(resources.GetObject("resource.Alignment10"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeSerie.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).RightToLeft = CType(resources.GetObject("resource.RightToLeft10"), Boolean)
            CType(Me.cbstripeSerie.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).AngleTransform = CType(resources.GetObject("resource.AngleTransform10"), Single)
            CType(Me.cbstripeSerie.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextWrap = CType(resources.GetObject("resource.TextWrap11"), Boolean)
            CType(Me.cbstripeSerie.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextOrientation = CType(resources.GetObject("resource.TextOrientation11"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeSerie.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).FlipText = CType(resources.GetObject("resource.FlipText11"), Boolean)
            CType(Me.cbstripeSerie.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Text = resources.GetString("resource.Text11")
            CType(Me.cbstripeSerie.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Padding = CType(resources.GetObject("resource.Padding11"), System.Windows.Forms.Padding)
            CType(Me.cbstripeSerie.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Margin = CType(resources.GetObject("resource.Margin11"), System.Windows.Forms.Padding)
            CType(Me.cbstripeSerie.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Alignment = CType(resources.GetObject("resource.Alignment11"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeSerie.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).RightToLeft = CType(resources.GetObject("resource.RightToLeft11"), Boolean)
            CType(Me.cbstripeSerie.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).AngleTransform = CType(resources.GetObject("resource.AngleTransform11"), Single)
            '
            'CommandBarLabel1
            '
            resources.ApplyResources(Me.CommandBarLabel1, "CommandBarLabel1")
            Me.CommandBarLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.CommandBarLabel1.Name = "CommandBarLabel1"
            '
            'cbddlSeries
            '
            resources.ApplyResources(Me.cbddlSeries, "cbddlSeries")
            Me.cbddlSeries.DrawText = True
            Me.cbddlSeries.DropDownAnimationEnabled = True
            Me.cbddlSeries.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.cbddlSeries.MaxDropDownItems = 0
            Me.cbddlSeries.Name = "cbddlSeries"
            Me.cbddlSeries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'dockVenta
            '
            Me.dockVenta.ActiveWindow = Me.ToolWindow3
            Me.dockVenta.CausesValidation = False
            Me.dockVenta.Controls.Add(Me.ToolTabStrip3)
            Me.dockVenta.Controls.Add(Me.RadSplitContainer2)
            resources.ApplyResources(Me.dockVenta, "dockVenta")
            Me.dockVenta.IsCleanUpTarget = True
            Me.dockVenta.MainDocumentContainer = Me.doccVentas
            Me.dockVenta.Name = "dockVenta"
            '
            '
            '
            Me.dockVenta.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.dockVenta.TabStop = False
            '
            'ToolWindow3
            '
            Me.ToolWindow3.Caption = Nothing
            Me.ToolWindow3.Controls.Add(Me.RadLabel4)
            Me.ToolWindow3.Controls.Add(Me.txtCliente)
            Me.ToolWindow3.Controls.Add(Me.RadSeparator1)
            Me.ToolWindow3.Controls.Add(Me.txtIntroduccion)
            Me.ToolWindow3.Controls.Add(Me.lblVentaActual)
            Me.ToolWindow3.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
            resources.ApplyResources(Me.ToolWindow3, "ToolWindow3")
            Me.ToolWindow3.Name = "ToolWindow3"
            Me.ToolWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.ToolWindow3.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
            '
            'RadLabel4
            '
            resources.ApplyResources(Me.RadLabel4, "RadLabel4")
            Me.RadLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.RadLabel4.Name = "RadLabel4"
            '
            'txtCliente
            '
            resources.ApplyResources(Me.txtCliente, "txtCliente")
            Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCliente.Name = "txtCliente"
            Me.txtCliente.ReadOnly = True
            Me.txtCliente.ShowClearButton = True
            Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'RadSeparator1
            '
            resources.ApplyResources(Me.RadSeparator1, "RadSeparator1")
            Me.RadSeparator1.Name = "RadSeparator1"
            Me.RadSeparator1.Orientation = System.Windows.Forms.Orientation.Vertical
            '
            'txtIntroduccion
            '
            Me.txtIntroduccion.AutoCompleteDataSource = Me.ProductosBindingSource
            Me.txtIntroduccion.AutoCompleteDisplayMember = "Referencia"
            Me.txtIntroduccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            resources.ApplyResources(Me.txtIntroduccion, "txtIntroduccion")
            Me.txtIntroduccion.Name = "txtIntroduccion"
            Me.txtIntroduccion.ShowClearButton = True
            Me.txtIntroduccion.TabStop = False
            '
            'ProductosBindingSource
            '
            Me.ProductosBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Productos)
            '
            'lblVentaActual
            '
            resources.ApplyResources(Me.lblVentaActual, "lblVentaActual")
            Me.lblVentaActual.BorderVisible = True
            Me.lblVentaActual.ForeColor = System.Drawing.Color.Lime
            Me.lblVentaActual.Name = "lblVentaActual"
            CType(Me.lblVentaActual.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.lblVentaActual.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment"), System.Drawing.ContentAlignment)
            CType(Me.lblVentaActual.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text12")
            CType(Me.lblVentaActual.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.lblVentaActual.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.lblVentaActual.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ToolTabStrip3
            '
            Me.ToolTabStrip3.CanUpdateChildIndex = True
            Me.ToolTabStrip3.CaptionVisible = False
            Me.ToolTabStrip3.Controls.Add(Me.ToolWindow3)
            resources.ApplyResources(Me.ToolTabStrip3, "ToolTabStrip3")
            Me.ToolTabStrip3.Name = "ToolTabStrip3"
            '
            '
            '
            Me.ToolTabStrip3.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.ToolTabStrip3.SelectedIndex = 0
            Me.ToolTabStrip3.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 49)
            Me.ToolTabStrip3.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -151)
            Me.ToolTabStrip3.TabStop = False
            '
            'RadSplitContainer2
            '
            Me.RadSplitContainer2.Controls.Add(Me.RadSplitContainer1)
            Me.RadSplitContainer2.Controls.Add(Me.ToolTabStrip2)
            Me.RadSplitContainer2.IsCleanUpTarget = True
            resources.ApplyResources(Me.RadSplitContainer2, "RadSplitContainer2")
            Me.RadSplitContainer2.Name = "RadSplitContainer2"
            '
            '
            '
            Me.RadSplitContainer2.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.RadSplitContainer2.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 328)
            Me.RadSplitContainer2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 151)
            Me.RadSplitContainer2.TabStop = False
            '
            'RadSplitContainer1
            '
            Me.RadSplitContainer1.Controls.Add(Me.doccVentas)
            Me.RadSplitContainer1.Controls.Add(Me.ToolTabStrip1)
            Me.RadSplitContainer1.IsCleanUpTarget = True
            resources.ApplyResources(Me.RadSplitContainer1, "RadSplitContainer1")
            Me.RadSplitContainer1.Name = "RadSplitContainer1"
            '
            '
            '
            Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.RadSplitContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(768, 200)
            Me.RadSplitContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(82, 0)
            Me.RadSplitContainer1.TabStop = False
            '
            'doccVentas
            '
            Me.doccVentas.CausesValidation = False
            Me.doccVentas.Controls.Add(Me.DocumentTabStrip1)
            resources.ApplyResources(Me.doccVentas, "doccVentas")
            Me.doccVentas.Name = "doccVentas"
            '
            '
            '
            Me.doccVentas.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.doccVentas.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 188)
            Me.doccVentas.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
            Me.doccVentas.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 192)
            '
            'DocumentTabStrip1
            '
            Me.DocumentTabStrip1.CanUpdateChildIndex = True
            Me.DocumentTabStrip1.Controls.Add(Me.DocumentWindow1)
            resources.ApplyResources(Me.DocumentTabStrip1, "DocumentTabStrip1")
            Me.DocumentTabStrip1.Name = "DocumentTabStrip1"
            '
            '
            '
            Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.DocumentTabStrip1.SelectedIndex = 0
            Me.DocumentTabStrip1.TabStop = False
            Me.DocumentTabStrip1.TabStripVisible = False
            '
            'DocumentWindow1
            '
            Me.DocumentWindow1.Controls.Add(Me.pagevVentas)
            resources.ApplyResources(Me.DocumentWindow1, "DocumentWindow1")
            Me.DocumentWindow1.Name = "DocumentWindow1"
            Me.DocumentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
            '
            'pagevVentas
            '
            resources.ApplyResources(Me.pagevVentas, "pagevVentas")
            Me.pagevVentas.ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.Individual
            Me.pagevVentas.Name = "pagevVentas"
            CType(Me.pagevVentas.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.All
            CType(Me.pagevVentas.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near
            CType(Me.pagevVentas.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.None
            CType(Me.pagevVentas.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Bottom
            CType(Me.pagevVentas.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSpacing = 3
            CType(Me.pagevVentas.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.Individual
            CType(Me.pagevVentas.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemContentOrientation = Telerik.WinControls.UI.PageViewContentOrientation.Horizontal
            '
            'ToolTabStrip1
            '
            Me.ToolTabStrip1.CanUpdateChildIndex = True
            Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
            resources.ApplyResources(Me.ToolTabStrip1, "ToolTabStrip1")
            Me.ToolTabStrip1.Name = "ToolTabStrip1"
            '
            '
            '
            Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.ToolTabStrip1.SelectedIndex = 0
            Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 136)
            Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -64)
            Me.ToolTabStrip1.TabStop = False
            '
            'ToolWindow1
            '
            Me.ToolWindow1.Caption = Nothing
            Me.ToolWindow1.Controls.Add(Me.gridUltimosVentas)
            Me.ToolWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
            resources.ApplyResources(Me.ToolWindow1, "ToolWindow1")
            Me.ToolWindow1.Name = "ToolWindow1"
            Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
            '
            'gridUltimosVentas
            '
            resources.ApplyResources(Me.gridUltimosVentas, "gridUltimosVentas")
            '
            '
            '
            Me.gridUltimosVentas.MasterTemplate.AllowAddNewRow = False
            Me.gridUltimosVentas.MasterTemplate.AllowColumnReorder = False
            GridViewTextBoxColumn1.FieldName = "NumAlbaran"
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.Name = "NumAlbaran"
            GridViewDateTimeColumn1.FieldName = "FAlbaran"
            GridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            GridViewDateTimeColumn1.IsAutoGenerated = True
            GridViewDateTimeColumn1.Name = "FAlbaran"
            GridViewDecimalColumn1.DataType = GetType(System.Nullable(Of Double))
            GridViewDecimalColumn1.FieldName = "TotalAlbaran"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.Name = "TotalAlbaran"
            GridViewDecimalColumn2.DataType = GetType(Single)
            GridViewDecimalColumn2.FieldName = "Entregado"
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.Name = "Entregado"
            GridViewDecimalColumn3.DataType = GetType(Single)
            GridViewDecimalColumn3.FieldName = "Cambio"
            GridViewDecimalColumn3.IsAutoGenerated = True
            GridViewDecimalColumn3.Name = "Cambio"
            GridViewTextBoxColumn2.FieldName = "Nombre"
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.Name = "Nombre"
            Me.gridUltimosVentas.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewDateTimeColumn1, GridViewDecimalColumn1, GridViewDecimalColumn2, GridViewDecimalColumn3, GridViewTextBoxColumn2})
            Me.gridUltimosVentas.MasterTemplate.DataSource = Me.VWAlbaranesBindingSource
            Me.gridUltimosVentas.MasterTemplate.EnableGrouping = False
            Me.gridUltimosVentas.MasterTemplate.EnableSorting = False
            Me.gridUltimosVentas.MasterTemplate.ShowColumnHeaders = False
            Me.gridUltimosVentas.MasterTemplate.ShowFilteringRow = False
            Me.gridUltimosVentas.MasterTemplate.ViewDefinition = TableViewDefinition1
            Me.gridUltimosVentas.Name = "gridUltimosVentas"
            Me.gridUltimosVentas.ReadOnly = True
            '
            'VWAlbaranesBindingSource
            '
            Me.VWAlbaranesBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.VWAlbaranes)
            '
            'ToolTabStrip2
            '
            Me.ToolTabStrip2.CanUpdateChildIndex = True
            Me.ToolTabStrip2.Controls.Add(Me.ToolWindow2)
            resources.ApplyResources(Me.ToolTabStrip2, "ToolTabStrip2")
            Me.ToolTabStrip2.Name = "ToolTabStrip2"
            '
            '
            '
            Me.ToolTabStrip2.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.ToolTabStrip2.SelectedIndex = 0
            Me.ToolTabStrip2.SizeInfo.AbsoluteSize = New System.Drawing.Size(118, 200)
            Me.ToolTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(-82, 0)
            Me.ToolTabStrip2.TabStop = False
            '
            'ToolWindow2
            '
            Me.ToolWindow2.Caption = Nothing
            Me.ToolWindow2.Controls.Add(Me.RadLabel6)
            Me.ToolWindow2.Controls.Add(Me.RadLabel5)
            Me.ToolWindow2.Controls.Add(Me.RadLabel2)
            Me.ToolWindow2.Controls.Add(Me.RadLabel1)
            Me.ToolWindow2.Controls.Add(Me.lblNumPieza)
            Me.ToolWindow2.Controls.Add(Me.lblUnidadVenta)
            Me.ToolWindow2.Controls.Add(Me.lblTotal)
            Me.ToolWindow2.Controls.Add(Me.lblStockActual)
            Me.ToolWindow2.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
            resources.ApplyResources(Me.ToolWindow2, "ToolWindow2")
            Me.ToolWindow2.Name = "ToolWindow2"
            Me.ToolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.ToolWindow2.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
            '
            'RadLabel6
            '
            resources.ApplyResources(Me.RadLabel6, "RadLabel6")
            Me.RadLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.RadLabel6.Name = "RadLabel6"
            '
            'RadLabel5
            '
            resources.ApplyResources(Me.RadLabel5, "RadLabel5")
            Me.RadLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.RadLabel5.Name = "RadLabel5"
            '
            'RadLabel2
            '
            resources.ApplyResources(Me.RadLabel2, "RadLabel2")
            Me.RadLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.RadLabel2.Name = "RadLabel2"
            '
            'RadLabel1
            '
            resources.ApplyResources(Me.RadLabel1, "RadLabel1")
            Me.RadLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.RadLabel1.Name = "RadLabel1"
            '
            'lblNumPieza
            '
            resources.ApplyResources(Me.lblNumPieza, "lblNumPieza")
            Me.lblNumPieza.BorderVisible = True
            Me.lblNumPieza.ForeColor = System.Drawing.Color.DarkCyan
            Me.lblNumPieza.Name = "lblNumPieza"
            CType(Me.lblNumPieza.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.lblNumPieza.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment1"), System.Drawing.ContentAlignment)
            CType(Me.lblNumPieza.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text13")
            CType(Me.lblNumPieza.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.lblNumPieza.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.lblNumPieza.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'lblUnidadVenta
            '
            resources.ApplyResources(Me.lblUnidadVenta, "lblUnidadVenta")
            Me.lblUnidadVenta.BorderVisible = True
            Me.lblUnidadVenta.ForeColor = System.Drawing.Color.Maroon
            Me.lblUnidadVenta.Name = "lblUnidadVenta"
            CType(Me.lblUnidadVenta.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.lblUnidadVenta.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment2"), System.Drawing.ContentAlignment)
            CType(Me.lblUnidadVenta.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text14")
            CType(Me.lblUnidadVenta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.lblUnidadVenta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.lblUnidadVenta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'lblTotal
            '
            resources.ApplyResources(Me.lblTotal, "lblTotal")
            Me.lblTotal.BorderVisible = True
            Me.lblTotal.ForeColor = System.Drawing.Color.DarkCyan
            Me.lblTotal.Name = "lblTotal"
            CType(Me.lblTotal.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.lblTotal.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment3"), System.Drawing.ContentAlignment)
            CType(Me.lblTotal.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text15")
            CType(Me.lblTotal.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.lblTotal.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.lblTotal.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'lblStockActual
            '
            resources.ApplyResources(Me.lblStockActual, "lblStockActual")
            Me.lblStockActual.BorderVisible = True
            Me.lblStockActual.ForeColor = System.Drawing.Color.Maroon
            Me.lblStockActual.Name = "lblStockActual"
            CType(Me.lblStockActual.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.lblStockActual.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment4"), System.Drawing.ContentAlignment)
            CType(Me.lblStockActual.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text16")
            CType(Me.lblStockActual.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.lblStockActual.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.lblStockActual.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'cmenuUltimasVentas
            '
            Me.cmenuUltimasVentas.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemImprimir})
            '
            'mitemImprimir
            '
            resources.ApplyResources(Me.mitemImprimir, "mitemImprimir")
            Me.mitemImprimir.Image = Global.EasyGest.My.Resources.Resources.Printer
            Me.mitemImprimir.Name = "mitemImprimir"
            '
            'cmenuLineaAlbaran
            '
            Me.cmenuLineaAlbaran.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemModificarProducto})
            '
            'mitemModificarProducto
            '
            resources.ApplyResources(Me.mitemModificarProducto, "mitemModificarProducto")
            Me.mitemModificarProducto.Image = Global.EasyGest.My.Resources.Resources._13
            Me.mitemModificarProducto.Name = "mitemModificarProducto"
            '
            'LineasAlbaranBindingSource
            '
            Me.LineasAlbaranBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.LineasAlbaran)
            '
            'frmVenta
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dockVenta)
            Me.Controls.Add(Me.RadCommandBar1)
            Me.KeyPreview = True
            Me.Name = "frmVenta"
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockVenta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockVenta.ResumeLayout(False)
            Me.ToolWindow3.ResumeLayout(False)
            Me.ToolWindow3.PerformLayout()
            CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtIntroduccion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblVentaActual, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolTabStrip3.ResumeLayout(False)
            CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer2.ResumeLayout(False)
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer1.ResumeLayout(False)
            CType(Me.doccVentas, System.ComponentModel.ISupportInitialize).EndInit()
            Me.doccVentas.ResumeLayout(False)
            CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DocumentTabStrip1.ResumeLayout(False)
            Me.DocumentWindow1.ResumeLayout(False)
            CType(Me.pagevVentas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolTabStrip1.ResumeLayout(False)
            Me.ToolWindow1.ResumeLayout(False)
            CType(Me.gridUltimosVentas.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridUltimosVentas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.VWAlbaranesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolTabStrip2.ResumeLayout(False)
            Me.ToolWindow2.ResumeLayout(False)
            Me.ToolWindow2.PerformLayout()
            CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblNumPieza, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblUnidadVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblTotal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblStockActual, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LineasAlbaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents RadCommandBar1 As RadCommandBar
        Friend WithEvents CommandBarRowElement1 As CommandBarRowElement
        Friend WithEvents cbbtnCrear As CommandBarButton
        Friend WithEvents cbbtnCancelar As CommandBarButton
        Friend WithEvents CommandBarSeparator1 As CommandBarSeparator
        Friend WithEvents cbbtnTerminar As CommandBarButton
        Friend WithEvents cbstripeSerie As CommandBarStripElement
        Friend WithEvents cbddlSeries As CommandBarDropDownList
        Friend WithEvents dockVenta As Docking.RadDock
        Friend WithEvents ToolWindow3 As Docking.ToolWindow
        Friend WithEvents RadSeparator1 As RadSeparator
        Friend WithEvents txtIntroduccion As RadTextBoxControl
        Friend WithEvents ToolTabStrip3 As Docking.ToolTabStrip
        Friend WithEvents RadSplitContainer2 As RadSplitContainer
        Friend WithEvents RadSplitContainer1 As RadSplitContainer
        Friend WithEvents doccVentas As Docking.DocumentContainer
        Friend WithEvents ToolTabStrip1 As Docking.ToolTabStrip
        Friend WithEvents ToolWindow1 As Docking.ToolWindow
        Friend WithEvents ToolTabStrip2 As Docking.ToolTabStrip
        Friend WithEvents ToolWindow2 As Docking.ToolWindow
        Friend WithEvents cbstripeAccion As CommandBarStripElement
        Friend WithEvents cbstripeBuscar As CommandBarStripElement
        Friend WithEvents cbbtnBuscarCliente As CommandBarDropDownButton
        Friend WithEvents cbbtnBuscarProducto As CommandBarDropDownButton
        Friend WithEvents gridUltimosVentas As RadGridView
        Friend WithEvents VWAlbaranesBindingSource As BindingSource
        Friend WithEvents LineasAlbaranBindingSource As BindingSource
        Friend WithEvents lblUnidadVenta As RadLabel
        Friend WithEvents lblStockActual As RadLabel
        Friend WithEvents mitemCrearCliente As RadMenuItem
        Friend WithEvents mitemCrearProducto As RadMenuItem
        Friend WithEvents lblNumPieza As RadLabel
        Friend WithEvents lblTotal As RadLabel
        Friend WithEvents txtCliente As RadTextBox
        Friend WithEvents ProductosBindingSource As BindingSource
        Friend WithEvents RadLabel1 As RadLabel
        Friend WithEvents RadLabel4 As RadLabel
        Friend WithEvents RadLabel6 As RadLabel
        Friend WithEvents RadLabel5 As RadLabel
        Friend WithEvents EnumBinder8 As UI.Data.EnumBinder
        Friend WithEvents EnumBinder9 As UI.Data.EnumBinder
        Friend WithEvents RadLabel2 As RadLabel
        Friend WithEvents CommandBarLabel1 As CommandBarLabel
        Friend WithEvents lblVentaActual As RadLabel
        Friend WithEvents cmenuUltimasVentas As RadContextMenu
        Friend WithEvents mitemImprimir As RadMenuItem
        Friend WithEvents cmenuLineaAlbaran As RadContextMenu
        Friend WithEvents mitemModificarProducto As RadMenuItem
        Friend WithEvents DocumentWindow1 As Docking.DocumentWindow
        Friend WithEvents pagevVentas As RadPageView
        Friend WithEvents DocumentTabStrip1 As Docking.DocumentTabStrip
    End Class
End Namespace

