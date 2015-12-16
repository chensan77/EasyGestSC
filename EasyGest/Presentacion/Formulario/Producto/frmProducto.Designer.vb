Namespace Presentacion.Formulario.Producto

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmProducto
        Inherits Telerik.WinControls.UI.RadForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim ReferenciaLabel As System.Windows.Forms.Label
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducto))
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim GridViewCheckBoxColumn2 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim GridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim DescripcionLabel As System.Windows.Forms.Label
            Dim DescripcionCNLabel As System.Windows.Forms.Label
            Dim MarcaLabel As System.Windows.Forms.Label
            Dim FamiliaLabel As System.Windows.Forms.Label
            Dim UbicacionLabel As System.Windows.Forms.Label
            Dim MedidaLabel As System.Windows.Forms.Label
            Dim ControlStockLabel As System.Windows.Forms.Label
            Dim FModificacionLabel As System.Windows.Forms.Label
            Dim FCreacionLabel As System.Windows.Forms.Label
            Dim ActivoLabel As System.Windows.Forms.Label
            Dim ObservacionLabel As System.Windows.Forms.Label
            Dim DescuentoLabel As System.Windows.Forms.Label
            Dim CosteLabel As System.Windows.Forms.Label
            Dim UnidadVentaLabel As System.Windows.Forms.Label
            Dim UnidadXCajaLabel As System.Windows.Forms.Label
            Dim StockSueltoLabel As System.Windows.Forms.Label
            Dim StockCajaLabel As System.Windows.Forms.Label
            Dim PlanOfertaLabel As System.Windows.Forms.Label
            Dim PrecioVentaLabel As System.Windows.Forms.Label
            Dim PrecioVariableLabel As System.Windows.Forms.Label
            Dim Label1 As System.Windows.Forms.Label
            Dim ListViewDetailColumn1 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Nº Oferta")
            Dim ListViewDetailColumn2 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Plan")
            Dim InputBinding1 As Telerik.WinControls.Keyboard.InputBinding = New Telerik.WinControls.Keyboard.InputBinding()
            Dim Chord1 As Telerik.WinControls.Keyboard.Chord = New Telerik.WinControls.Keyboard.Chord()
            Dim ChordModifier1 As Telerik.WinControls.Keyboard.ChordModifier = New Telerik.WinControls.Keyboard.ChordModifier()
            Me.gridDatos = New Telerik.WinControls.UI.RadGridView()
            Me.VWProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.cbbtnAgregar = New Telerik.WinControls.UI.CommandBarButton()
            Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.cbstripeAccion = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbbtnEliminar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnModificar = New Telerik.WinControls.UI.CommandBarButton()
            Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.cbbtnGaleria = New Telerik.WinControls.UI.CommandBarDropDownButton()
            Me.mitemAdquirirImagen = New Telerik.WinControls.UI.RadMenuItem()
            Me.cbbtnCaracteristicas = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnEtiquetar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbstripeBusqueda = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbstripeOrden = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.ImpuestoLabel = New System.Windows.Forms.Label()
            Me.cbComandos = New Telerik.WinControls.UI.RadCommandBar()
            Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.SplitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.RadSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.SplitPanel4 = New Telerik.WinControls.UI.SplitPanel()
            Me.treeFamilia = New Telerik.WinControls.UI.RadTreeView()
            Me.imglFamilia = New System.Windows.Forms.ImageList(Me.components)
            Me.SplitPanel5 = New Telerik.WinControls.UI.SplitPanel()
            Me.lstvOfertas = New Telerik.WinControls.UI.RadListView()
            Me.SplitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.statuInfo = New Telerik.WinControls.UI.RadStatusStrip()
            Me.btneAnterior = New Telerik.WinControls.UI.RadButtonElement()
            Me.btneSiguiente = New Telerik.WinControls.UI.RadButtonElement()
            Me.lblePagina = New Telerik.WinControls.UI.RadLabelElement()
            Me.RadToolStripSeparatorItem1 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.lbleDiagnostico = New Telerik.WinControls.UI.RadLabelElement()
            Me.chkeNoActivos = New Telerik.WinControls.UI.RadCheckBoxElement()
            Me.chkePaginar = New Telerik.WinControls.UI.RadCheckBoxElement()
            Me.SplitPanel3 = New Telerik.WinControls.UI.SplitPanel()
            Me.pvInfo = New Telerik.WinControls.UI.RadPageView()
            Me.pvpDetalle = New Telerik.WinControls.UI.RadPageViewPage()
            Me.FModificacionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.VWProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.FCreacionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.FidelizableRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.ActivoRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.ControlStockRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.MedidaRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.UbicacionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.FamiliaRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.MarcaRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.DescripcionCNRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.DescripcionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.ReferenciaRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.pvpOtro = New Telerik.WinControls.UI.RadPageViewPage()
            Me.ObservacionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.OfertaVigenteRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.PrecioVariableRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.PrecioVentaRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.PlanOfertaRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.StockCajaRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.StockSueltoRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.UnidadXCajaRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.UnidadVentaRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.CosteRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.ImpuestoRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.DescuentoRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.bgwCarga = New System.ComponentModel.BackgroundWorker()
            Me.FamiliasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            ReferenciaLabel = New System.Windows.Forms.Label()
            DescripcionLabel = New System.Windows.Forms.Label()
            DescripcionCNLabel = New System.Windows.Forms.Label()
            MarcaLabel = New System.Windows.Forms.Label()
            FamiliaLabel = New System.Windows.Forms.Label()
            UbicacionLabel = New System.Windows.Forms.Label()
            MedidaLabel = New System.Windows.Forms.Label()
            ControlStockLabel = New System.Windows.Forms.Label()
            FModificacionLabel = New System.Windows.Forms.Label()
            FCreacionLabel = New System.Windows.Forms.Label()
            ActivoLabel = New System.Windows.Forms.Label()
            ObservacionLabel = New System.Windows.Forms.Label()
            DescuentoLabel = New System.Windows.Forms.Label()
            CosteLabel = New System.Windows.Forms.Label()
            UnidadVentaLabel = New System.Windows.Forms.Label()
            UnidadXCajaLabel = New System.Windows.Forms.Label()
            StockSueltoLabel = New System.Windows.Forms.Label()
            StockCajaLabel = New System.Windows.Forms.Label()
            PlanOfertaLabel = New System.Windows.Forms.Label()
            PrecioVentaLabel = New System.Windows.Forms.Label()
            PrecioVariableLabel = New System.Windows.Forms.Label()
            Label1 = New System.Windows.Forms.Label()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.VWProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer1.SuspendLayout()
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel1.SuspendLayout()
            CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer2.SuspendLayout()
            CType(Me.SplitPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel4.SuspendLayout()
            CType(Me.treeFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel5.SuspendLayout()
            CType(Me.lstvOfertas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel2.SuspendLayout()
            CType(Me.statuInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel3.SuspendLayout()
            CType(Me.pvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pvInfo.SuspendLayout()
            Me.pvpDetalle.SuspendLayout()
            CType(Me.FModificacionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.VWProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FCreacionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FidelizableRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ActivoRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ControlStockRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MedidaRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UbicacionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FamiliaRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MarcaRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DescripcionCNRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DescripcionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ReferenciaRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pvpOtro.SuspendLayout()
            CType(Me.ObservacionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OfertaVigenteRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PrecioVariableRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PrecioVentaRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PlanOfertaRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StockCajaRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.StockSueltoRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UnidadXCajaRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UnidadVentaRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CosteRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ImpuestoRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DescuentoRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FamiliasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ReferenciaLabel
            '
            resources.ApplyResources(ReferenciaLabel, "ReferenciaLabel")
            ReferenciaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ReferenciaLabel.Name = "ReferenciaLabel"
            '
            'gridDatos
            '
            resources.ApplyResources(Me.gridDatos, "gridDatos")
            Me.gridDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDatos.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridDatos.ForeColor = System.Drawing.Color.Black
            '
            'gridDatos
            '
            Me.gridDatos.MasterTemplate.AllowAddNewRow = False
            Me.gridDatos.MasterTemplate.AllowColumnHeaderContextMenu = False
            Me.gridDatos.MasterTemplate.AllowDeleteRow = False
            Me.gridDatos.MasterTemplate.AllowRowResize = False
            Me.gridDatos.MasterTemplate.AllowSearchRow = True
            Me.gridDatos.MasterTemplate.AutoExpandGroups = True
            Me.gridDatos.MasterTemplate.AutoGenerateColumns = False
            resources.ApplyResources(Me.gridDatos.MasterTemplate, "gridDatos")
            GridViewTextBoxColumn1.AllowGroup = False
            GridViewTextBoxColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn1, "GridViewTextBoxColumn1")
            GridViewTextBoxColumn1.FieldName = "Referencia"
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.IsPinned = True
            GridViewTextBoxColumn1.Name = "Referencia"
            GridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewTextBoxColumn1.ReadOnly = True
            GridViewTextBoxColumn1.Width = 133
            GridViewTextBoxColumn2.AllowGroup = False
            GridViewTextBoxColumn2.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn2, "GridViewTextBoxColumn2")
            GridViewTextBoxColumn2.FieldName = "Descripcion"
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.IsPinned = True
            GridViewTextBoxColumn2.Name = "Descripcion"
            GridViewTextBoxColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewTextBoxColumn2.ReadOnly = True
            GridViewTextBoxColumn2.Width = 264
            GridViewDecimalColumn1.AllowGroup = False
            GridViewDecimalColumn1.DataType = GetType(Single)
            GridViewDecimalColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn1, "GridViewDecimalColumn1")
            GridViewDecimalColumn1.FieldName = "PrecioVenta"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.Name = "PrecioVenta"
            GridViewDecimalColumn1.ReadOnly = True
            GridViewDecimalColumn1.Width = 108
            GridViewDecimalColumn2.AllowFiltering = False
            GridViewDecimalColumn2.AllowSort = False
            GridViewDecimalColumn2.DataType = GetType(System.Nullable(Of Single))
            GridViewDecimalColumn2.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn2, "GridViewDecimalColumn2")
            GridViewDecimalColumn2.FieldName = "UltimoPrecioEntrada"
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.Name = "UltimoPrecioEntrada"
            GridViewDecimalColumn2.ReadOnly = True
            GridViewDecimalColumn2.Width = 108
            GridViewTextBoxColumn3.AllowFiltering = False
            GridViewTextBoxColumn3.AllowSort = False
            GridViewTextBoxColumn3.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn3, "GridViewTextBoxColumn3")
            GridViewTextBoxColumn3.FieldName = "UltimoProveedor"
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.Name = "UltimoProveedor"
            GridViewTextBoxColumn3.ReadOnly = True
            GridViewTextBoxColumn3.Width = 190
            GridViewDecimalColumn3.AllowFiltering = False
            GridViewDecimalColumn3.AllowGroup = False
            GridViewDecimalColumn3.DataType = GetType(System.Nullable(Of Single))
            GridViewDecimalColumn3.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn3, "GridViewDecimalColumn3")
            GridViewDecimalColumn3.FieldName = "StockSuelto"
            GridViewDecimalColumn3.IsAutoGenerated = True
            GridViewDecimalColumn3.Name = "StockSuelto"
            GridViewDecimalColumn3.ReadOnly = True
            GridViewDecimalColumn3.Width = 82
            GridViewTextBoxColumn4.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn4, "GridViewTextBoxColumn4")
            GridViewTextBoxColumn4.FieldName = "Marca"
            GridViewTextBoxColumn4.IsAutoGenerated = True
            GridViewTextBoxColumn4.Name = "Marca"
            GridViewTextBoxColumn4.Width = 120
            GridViewTextBoxColumn5.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn5, "GridViewTextBoxColumn5")
            GridViewTextBoxColumn5.FieldName = "Familia"
            GridViewTextBoxColumn5.IsAutoGenerated = True
            GridViewTextBoxColumn5.Name = "Familia"
            GridViewTextBoxColumn5.ReadOnly = True
            GridViewTextBoxColumn5.Width = 124
            GridViewTextBoxColumn6.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn6, "GridViewTextBoxColumn6")
            GridViewTextBoxColumn6.FieldName = "Ubicacion"
            GridViewTextBoxColumn6.IsAutoGenerated = True
            GridViewTextBoxColumn6.Name = "Ubicacion"
            GridViewTextBoxColumn6.ReadOnly = True
            GridViewTextBoxColumn6.Width = 128
            GridViewCheckBoxColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewCheckBoxColumn1, "GridViewCheckBoxColumn1")
            GridViewCheckBoxColumn1.FieldName = "ControlStock"
            GridViewCheckBoxColumn1.IsAutoGenerated = True
            GridViewCheckBoxColumn1.IsVisible = False
            GridViewCheckBoxColumn1.MinWidth = 20
            GridViewCheckBoxColumn1.Name = "ControlStock"
            GridViewCheckBoxColumn2.EnableExpressionEditor = False
            resources.ApplyResources(GridViewCheckBoxColumn2, "GridViewCheckBoxColumn2")
            GridViewCheckBoxColumn2.FieldName = "PrecioVariable"
            GridViewCheckBoxColumn2.IsAutoGenerated = True
            GridViewCheckBoxColumn2.IsVisible = False
            GridViewCheckBoxColumn2.MinWidth = 20
            GridViewCheckBoxColumn2.Name = "PrecioVariable"
            resources.ApplyResources(GridViewDateTimeColumn1, "GridViewDateTimeColumn1")
            GridViewDateTimeColumn1.DataType = GetType(System.Nullable(Of Date))
            GridViewDateTimeColumn1.EnableExpressionEditor = False
            GridViewDateTimeColumn1.FieldName = "FModificacion"
            GridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
            GridViewDateTimeColumn1.IsAutoGenerated = True
            GridViewDateTimeColumn1.IsVisible = False
            GridViewDateTimeColumn1.Name = "FModificacion"
            resources.ApplyResources(GridViewDateTimeColumn2, "GridViewDateTimeColumn2")
            GridViewDateTimeColumn2.EnableExpressionEditor = False
            GridViewDateTimeColumn2.FieldName = "FCreacion"
            GridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
            GridViewDateTimeColumn2.IsAutoGenerated = True
            GridViewDateTimeColumn2.IsVisible = False
            GridViewDateTimeColumn2.Name = "FCreacion"
            Me.gridDatos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewDecimalColumn1, GridViewDecimalColumn2, GridViewTextBoxColumn3, GridViewDecimalColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewCheckBoxColumn1, GridViewCheckBoxColumn2, GridViewDateTimeColumn1, GridViewDateTimeColumn2})
            Me.gridDatos.MasterTemplate.DataSource = Me.VWProductosBindingSource
            Me.gridDatos.MasterTemplate.EnableAlternatingRowColor = True
            Me.gridDatos.MasterTemplate.PageSize = 50
            Me.gridDatos.MasterTemplate.PagingBeforeGrouping = True
            Me.gridDatos.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
            Me.gridDatos.MasterTemplate.ShowChildViewCaptions = True
            Me.gridDatos.MasterTemplate.ShowGroupedColumns = True
            Me.gridDatos.Name = "gridDatos"
            Me.gridDatos.ReadOnly = True
            '
            '
            '
            Me.gridDatos.RootElement.AccessibleDescription = resources.GetString("gridDatos.RootElement.AccessibleDescription")
            Me.gridDatos.RootElement.AccessibleName = resources.GetString("gridDatos.RootElement.AccessibleName")
            Me.gridDatos.RootElement.Alignment = CType(resources.GetObject("gridDatos.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.gridDatos.RootElement.AngleTransform = CType(resources.GetObject("gridDatos.RootElement.AngleTransform"), Single)
            Me.gridDatos.RootElement.FlipText = CType(resources.GetObject("gridDatos.RootElement.FlipText"), Boolean)
            Me.gridDatos.RootElement.KeyTip = resources.GetString("gridDatos.RootElement.KeyTip")
            Me.gridDatos.RootElement.Margin = CType(resources.GetObject("gridDatos.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.gridDatos.RootElement.Text = resources.GetString("gridDatos.RootElement.Text")
            Me.gridDatos.RootElement.TextOrientation = CType(resources.GetObject("gridDatos.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.gridDatos.RootElement.ToolTipText = resources.GetString("gridDatos.RootElement.ToolTipText")
            Me.gridDatos.ShowChildViewCaptions = True
            Me.gridDatos.ShowGroupPanel = False
            '
            'VWProductosBindingSource
            '
            Me.VWProductosBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.VWProductos)
            '
            'DescripcionLabel
            '
            resources.ApplyResources(DescripcionLabel, "DescripcionLabel")
            DescripcionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            DescripcionLabel.Name = "DescripcionLabel"
            '
            'DescripcionCNLabel
            '
            resources.ApplyResources(DescripcionCNLabel, "DescripcionCNLabel")
            DescripcionCNLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            DescripcionCNLabel.Name = "DescripcionCNLabel"
            '
            'MarcaLabel
            '
            resources.ApplyResources(MarcaLabel, "MarcaLabel")
            MarcaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            MarcaLabel.Name = "MarcaLabel"
            '
            'FamiliaLabel
            '
            resources.ApplyResources(FamiliaLabel, "FamiliaLabel")
            FamiliaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            FamiliaLabel.Name = "FamiliaLabel"
            '
            'UbicacionLabel
            '
            resources.ApplyResources(UbicacionLabel, "UbicacionLabel")
            UbicacionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            UbicacionLabel.Name = "UbicacionLabel"
            '
            'MedidaLabel
            '
            resources.ApplyResources(MedidaLabel, "MedidaLabel")
            MedidaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            MedidaLabel.Name = "MedidaLabel"
            '
            'ControlStockLabel
            '
            resources.ApplyResources(ControlStockLabel, "ControlStockLabel")
            ControlStockLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ControlStockLabel.Name = "ControlStockLabel"
            '
            'FModificacionLabel
            '
            resources.ApplyResources(FModificacionLabel, "FModificacionLabel")
            FModificacionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            FModificacionLabel.Name = "FModificacionLabel"
            '
            'FCreacionLabel
            '
            resources.ApplyResources(FCreacionLabel, "FCreacionLabel")
            FCreacionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            FCreacionLabel.Name = "FCreacionLabel"
            '
            'ActivoLabel
            '
            resources.ApplyResources(ActivoLabel, "ActivoLabel")
            ActivoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ActivoLabel.Name = "ActivoLabel"
            '
            'ObservacionLabel
            '
            resources.ApplyResources(ObservacionLabel, "ObservacionLabel")
            ObservacionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ObservacionLabel.Name = "ObservacionLabel"
            '
            'DescuentoLabel
            '
            resources.ApplyResources(DescuentoLabel, "DescuentoLabel")
            DescuentoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            DescuentoLabel.Name = "DescuentoLabel"
            '
            'CosteLabel
            '
            resources.ApplyResources(CosteLabel, "CosteLabel")
            CosteLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            CosteLabel.Name = "CosteLabel"
            '
            'UnidadVentaLabel
            '
            resources.ApplyResources(UnidadVentaLabel, "UnidadVentaLabel")
            UnidadVentaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            UnidadVentaLabel.Name = "UnidadVentaLabel"
            '
            'UnidadXCajaLabel
            '
            resources.ApplyResources(UnidadXCajaLabel, "UnidadXCajaLabel")
            UnidadXCajaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            UnidadXCajaLabel.Name = "UnidadXCajaLabel"
            '
            'StockSueltoLabel
            '
            resources.ApplyResources(StockSueltoLabel, "StockSueltoLabel")
            StockSueltoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            StockSueltoLabel.Name = "StockSueltoLabel"
            '
            'StockCajaLabel
            '
            resources.ApplyResources(StockCajaLabel, "StockCajaLabel")
            StockCajaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            StockCajaLabel.Name = "StockCajaLabel"
            '
            'PlanOfertaLabel
            '
            resources.ApplyResources(PlanOfertaLabel, "PlanOfertaLabel")
            PlanOfertaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            PlanOfertaLabel.Name = "PlanOfertaLabel"
            '
            'PrecioVentaLabel
            '
            resources.ApplyResources(PrecioVentaLabel, "PrecioVentaLabel")
            PrecioVentaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            PrecioVentaLabel.Name = "PrecioVentaLabel"
            '
            'PrecioVariableLabel
            '
            resources.ApplyResources(PrecioVariableLabel, "PrecioVariableLabel")
            PrecioVariableLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            PrecioVariableLabel.Name = "PrecioVariableLabel"
            '
            'Label1
            '
            resources.ApplyResources(Label1, "Label1")
            Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Label1.Name = "Label1"
            '
            'cbbtnAgregar
            '
            resources.ApplyResources(Me.cbbtnAgregar, "cbbtnAgregar")
            Me.cbbtnAgregar.DrawText = True
            Me.cbbtnAgregar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnAgregar.Image = Global.EasyGest.My.Resources.Resources._127
            Me.cbbtnAgregar.Name = "cbbtnAgregar"
            Me.cbbtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnAgregar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'CommandBarRowElement1
            '
            resources.ApplyResources(Me.CommandBarRowElement1, "CommandBarRowElement1")
            Me.CommandBarRowElement1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
            Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.cbstripeAccion, Me.cbstripeBusqueda, Me.cbstripeOrden})
            '
            'cbstripeAccion
            '
            resources.ApplyResources(Me.cbstripeAccion, "cbstripeAccion")
            Me.cbstripeAccion.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.cbstripeAccion.EnableDragging = False
            '
            '
            '
            Me.cbstripeAccion.Grip.AccessibleDescription = resources.GetString("resource.AccessibleDescription")
            Me.cbstripeAccion.Grip.AccessibleName = resources.GetString("resource.AccessibleName")
            Me.cbstripeAccion.Grip.Alignment = CType(resources.GetObject("resource.Alignment"), System.Drawing.ContentAlignment)
            Me.cbstripeAccion.Grip.AngleTransform = CType(resources.GetObject("resource.AngleTransform"), Single)
            Me.cbstripeAccion.Grip.DisplayName = resources.GetString("resource.DisplayName")
            Me.cbstripeAccion.Grip.FlipText = CType(resources.GetObject("resource.FlipText"), Boolean)
            Me.cbstripeAccion.Grip.KeyTip = resources.GetString("resource.KeyTip")
            Me.cbstripeAccion.Grip.Margin = CType(resources.GetObject("resource.Margin"), System.Windows.Forms.Padding)
            Me.cbstripeAccion.Grip.Padding = CType(resources.GetObject("resource.Padding"), System.Windows.Forms.Padding)
            Me.cbstripeAccion.Grip.RightToLeft = CType(resources.GetObject("resource.RightToLeft"), Boolean)
            Me.cbstripeAccion.Grip.Text = resources.GetString("resource.Text")
            Me.cbstripeAccion.Grip.TextOrientation = CType(resources.GetObject("resource.TextOrientation"), System.Windows.Forms.Orientation)
            Me.cbstripeAccion.Grip.TextWrap = CType(resources.GetObject("resource.TextWrap"), Boolean)
            Me.cbstripeAccion.Grip.ToolTipText = resources.GetString("resource.ToolTipText")
            Me.cbstripeAccion.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbtnAgregar, Me.cbbtnEliminar, Me.cbbtnModificar, Me.CommandBarSeparator2, Me.cbbtnGaleria, Me.cbbtnCaracteristicas, Me.cbbtnEtiquetar})
            Me.cbstripeAccion.Name = "CommandBarStripElement1"
            '
            '
            '
            Me.cbstripeAccion.OverflowButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1")
            Me.cbstripeAccion.OverflowButton.AccessibleName = resources.GetString("resource.AccessibleName1")
            Me.cbstripeAccion.OverflowButton.Alignment = CType(resources.GetObject("resource.Alignment1"), System.Drawing.ContentAlignment)
            Me.cbstripeAccion.OverflowButton.AngleTransform = CType(resources.GetObject("resource.AngleTransform1"), Single)
            Me.cbstripeAccion.OverflowButton.DisplayName = resources.GetString("resource.DisplayName1")
            Me.cbstripeAccion.OverflowButton.FlipText = CType(resources.GetObject("resource.FlipText1"), Boolean)
            Me.cbstripeAccion.OverflowButton.KeyTip = resources.GetString("resource.KeyTip1")
            Me.cbstripeAccion.OverflowButton.Margin = CType(resources.GetObject("resource.Margin1"), System.Windows.Forms.Padding)
            Me.cbstripeAccion.OverflowButton.Padding = CType(resources.GetObject("resource.Padding1"), System.Windows.Forms.Padding)
            Me.cbstripeAccion.OverflowButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft1"), Boolean)
            Me.cbstripeAccion.OverflowButton.Text = resources.GetString("resource.Text1")
            Me.cbstripeAccion.OverflowButton.TextOrientation = CType(resources.GetObject("resource.TextOrientation1"), System.Windows.Forms.Orientation)
            Me.cbstripeAccion.OverflowButton.TextWrap = CType(resources.GetObject("resource.TextWrap1"), Boolean)
            Me.cbstripeAccion.OverflowButton.ToolTipText = resources.GetString("resource.ToolTipText1")
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
            'cbbtnEliminar
            '
            resources.ApplyResources(Me.cbbtnEliminar, "cbbtnEliminar")
            Me.cbbtnEliminar.DrawText = True
            Me.cbbtnEliminar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnEliminar.Image = Global.EasyGest.My.Resources.Resources._128
            Me.cbbtnEliminar.Name = "cbbtnEliminar"
            Me.cbbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnEliminar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbbtnModificar
            '
            resources.ApplyResources(Me.cbbtnModificar, "cbbtnModificar")
            Me.cbbtnModificar.DrawText = True
            Me.cbbtnModificar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnModificar.Image = Global.EasyGest.My.Resources.Resources._130
            Me.cbbtnModificar.Name = "cbbtnModificar"
            Me.cbbtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnModificar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'CommandBarSeparator2
            '
            resources.ApplyResources(Me.CommandBarSeparator2, "CommandBarSeparator2")
            Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
            Me.CommandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.CommandBarSeparator2.VisibleInOverflowMenu = False
            '
            'cbbtnGaleria
            '
            resources.ApplyResources(Me.cbbtnGaleria, "cbbtnGaleria")
            Me.cbbtnGaleria.DrawText = True
            Me.cbbtnGaleria.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnGaleria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnGaleria.Image = Global.EasyGest.My.Resources.Resources._63
            Me.cbbtnGaleria.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemAdquirirImagen})
            Me.cbbtnGaleria.Name = "cbbtnGaleria"
            Me.cbbtnGaleria.ShowHorizontalLine = False
            Me.cbbtnGaleria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnGaleria.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mitemAdquirirImagen
            '
            resources.ApplyResources(Me.mitemAdquirirImagen, "mitemAdquirirImagen")
            Me.mitemAdquirirImagen.DescriptionFont = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemAdquirirImagen.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemAdquirirImagen.Image = Global.EasyGest.My.Resources.Resources._112
            Me.mitemAdquirirImagen.Name = "mitemAdquirirImagen"
            Me.mitemAdquirirImagen.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbbtnCaracteristicas
            '
            resources.ApplyResources(Me.cbbtnCaracteristicas, "cbbtnCaracteristicas")
            Me.cbbtnCaracteristicas.DrawText = True
            Me.cbbtnCaracteristicas.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnCaracteristicas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnCaracteristicas.Image = Global.EasyGest.My.Resources.Resources._43
            Me.cbbtnCaracteristicas.Name = "cbbtnCaracteristicas"
            Me.cbbtnCaracteristicas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnCaracteristicas.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbbtnEtiquetar
            '
            resources.ApplyResources(Me.cbbtnEtiquetar, "cbbtnEtiquetar")
            Me.cbbtnEtiquetar.DrawText = True
            Me.cbbtnEtiquetar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnEtiquetar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnEtiquetar.Image = Global.EasyGest.My.Resources.Resources._21
            Me.cbbtnEtiquetar.Name = "cbbtnEtiquetar"
            Me.cbbtnEtiquetar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnEtiquetar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbstripeBusqueda
            '
            resources.ApplyResources(Me.cbstripeBusqueda, "cbstripeBusqueda")
            Me.cbstripeBusqueda.DrawFill = True
            Me.cbstripeBusqueda.DrawText = False
            Me.cbstripeBusqueda.EnableDragging = False
            '
            '
            '
            Me.cbstripeBusqueda.Grip.AccessibleDescription = resources.GetString("resource.AccessibleDescription2")
            Me.cbstripeBusqueda.Grip.AccessibleName = resources.GetString("resource.AccessibleName2")
            Me.cbstripeBusqueda.Grip.Alignment = CType(resources.GetObject("resource.Alignment4"), System.Drawing.ContentAlignment)
            Me.cbstripeBusqueda.Grip.AngleTransform = CType(resources.GetObject("resource.AngleTransform4"), Single)
            Me.cbstripeBusqueda.Grip.DisplayName = resources.GetString("resource.DisplayName2")
            Me.cbstripeBusqueda.Grip.FlipText = CType(resources.GetObject("resource.FlipText4"), Boolean)
            Me.cbstripeBusqueda.Grip.KeyTip = resources.GetString("resource.KeyTip2")
            Me.cbstripeBusqueda.Grip.Margin = CType(resources.GetObject("resource.Margin4"), System.Windows.Forms.Padding)
            Me.cbstripeBusqueda.Grip.Padding = CType(resources.GetObject("resource.Padding4"), System.Windows.Forms.Padding)
            Me.cbstripeBusqueda.Grip.RightToLeft = CType(resources.GetObject("resource.RightToLeft4"), Boolean)
            Me.cbstripeBusqueda.Grip.Text = resources.GetString("resource.Text4")
            Me.cbstripeBusqueda.Grip.TextOrientation = CType(resources.GetObject("resource.TextOrientation4"), System.Windows.Forms.Orientation)
            Me.cbstripeBusqueda.Grip.TextWrap = CType(resources.GetObject("resource.TextWrap4"), Boolean)
            Me.cbstripeBusqueda.Grip.ToolTipText = resources.GetString("resource.ToolTipText2")
            Me.cbstripeBusqueda.Name = "CommandBarStripElement2"
            '
            '
            '
            Me.cbstripeBusqueda.OverflowButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription3")
            Me.cbstripeBusqueda.OverflowButton.AccessibleName = resources.GetString("resource.AccessibleName3")
            Me.cbstripeBusqueda.OverflowButton.Alignment = CType(resources.GetObject("resource.Alignment5"), System.Drawing.ContentAlignment)
            Me.cbstripeBusqueda.OverflowButton.AngleTransform = CType(resources.GetObject("resource.AngleTransform5"), Single)
            Me.cbstripeBusqueda.OverflowButton.DisplayName = resources.GetString("resource.DisplayName3")
            Me.cbstripeBusqueda.OverflowButton.FlipText = CType(resources.GetObject("resource.FlipText5"), Boolean)
            Me.cbstripeBusqueda.OverflowButton.KeyTip = resources.GetString("resource.KeyTip3")
            Me.cbstripeBusqueda.OverflowButton.Margin = CType(resources.GetObject("resource.Margin5"), System.Windows.Forms.Padding)
            Me.cbstripeBusqueda.OverflowButton.Padding = CType(resources.GetObject("resource.Padding5"), System.Windows.Forms.Padding)
            Me.cbstripeBusqueda.OverflowButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft5"), Boolean)
            Me.cbstripeBusqueda.OverflowButton.Text = resources.GetString("resource.Text5")
            Me.cbstripeBusqueda.OverflowButton.TextOrientation = CType(resources.GetObject("resource.TextOrientation5"), System.Windows.Forms.Orientation)
            Me.cbstripeBusqueda.OverflowButton.TextWrap = CType(resources.GetObject("resource.TextWrap5"), Boolean)
            Me.cbstripeBusqueda.OverflowButton.ToolTipText = resources.GetString("resource.ToolTipText3")
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextWrap = CType(resources.GetObject("resource.TextWrap6"), Boolean)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextOrientation = CType(resources.GetObject("resource.TextOrientation6"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).FlipText = CType(resources.GetObject("resource.FlipText6"), Boolean)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Text = resources.GetString("resource.Text6")
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Padding = CType(resources.GetObject("resource.Padding6"), System.Windows.Forms.Padding)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Margin = CType(resources.GetObject("resource.Margin6"), System.Windows.Forms.Padding)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Alignment = CType(resources.GetObject("resource.Alignment6"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).RightToLeft = CType(resources.GetObject("resource.RightToLeft6"), Boolean)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).AngleTransform = CType(resources.GetObject("resource.AngleTransform6"), Single)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextWrap = CType(resources.GetObject("resource.TextWrap7"), Boolean)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextOrientation = CType(resources.GetObject("resource.TextOrientation7"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).FlipText = CType(resources.GetObject("resource.FlipText7"), Boolean)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Text = resources.GetString("resource.Text7")
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Padding = CType(resources.GetObject("resource.Padding7"), System.Windows.Forms.Padding)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Margin = CType(resources.GetObject("resource.Margin7"), System.Windows.Forms.Padding)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Alignment = CType(resources.GetObject("resource.Alignment7"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).RightToLeft = CType(resources.GetObject("resource.RightToLeft7"), Boolean)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).AngleTransform = CType(resources.GetObject("resource.AngleTransform7"), Single)
            '
            'cbstripeOrden
            '
            resources.ApplyResources(Me.cbstripeOrden, "cbstripeOrden")
            '
            '
            '
            Me.cbstripeOrden.Grip.AccessibleDescription = resources.GetString("resource.AccessibleDescription4")
            Me.cbstripeOrden.Grip.AccessibleName = resources.GetString("resource.AccessibleName4")
            Me.cbstripeOrden.Grip.Alignment = CType(resources.GetObject("resource.Alignment8"), System.Drawing.ContentAlignment)
            Me.cbstripeOrden.Grip.AngleTransform = CType(resources.GetObject("resource.AngleTransform8"), Single)
            Me.cbstripeOrden.Grip.DisplayName = resources.GetString("resource.DisplayName4")
            Me.cbstripeOrden.Grip.FlipText = CType(resources.GetObject("resource.FlipText8"), Boolean)
            Me.cbstripeOrden.Grip.KeyTip = resources.GetString("resource.KeyTip4")
            Me.cbstripeOrden.Grip.Margin = CType(resources.GetObject("resource.Margin8"), System.Windows.Forms.Padding)
            Me.cbstripeOrden.Grip.Padding = CType(resources.GetObject("resource.Padding8"), System.Windows.Forms.Padding)
            Me.cbstripeOrden.Grip.RightToLeft = CType(resources.GetObject("resource.RightToLeft8"), Boolean)
            Me.cbstripeOrden.Grip.Text = resources.GetString("resource.Text8")
            Me.cbstripeOrden.Grip.TextOrientation = CType(resources.GetObject("resource.TextOrientation8"), System.Windows.Forms.Orientation)
            Me.cbstripeOrden.Grip.TextWrap = CType(resources.GetObject("resource.TextWrap8"), Boolean)
            Me.cbstripeOrden.Grip.ToolTipText = resources.GetString("resource.ToolTipText4")
            Me.cbstripeOrden.Name = "CommandBarStripElement1"
            '
            '
            '
            Me.cbstripeOrden.OverflowButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription5")
            Me.cbstripeOrden.OverflowButton.AccessibleName = resources.GetString("resource.AccessibleName5")
            Me.cbstripeOrden.OverflowButton.Alignment = CType(resources.GetObject("resource.Alignment9"), System.Drawing.ContentAlignment)
            Me.cbstripeOrden.OverflowButton.AngleTransform = CType(resources.GetObject("resource.AngleTransform9"), Single)
            Me.cbstripeOrden.OverflowButton.DisplayName = resources.GetString("resource.DisplayName5")
            Me.cbstripeOrden.OverflowButton.FlipText = CType(resources.GetObject("resource.FlipText9"), Boolean)
            Me.cbstripeOrden.OverflowButton.KeyTip = resources.GetString("resource.KeyTip5")
            Me.cbstripeOrden.OverflowButton.Margin = CType(resources.GetObject("resource.Margin9"), System.Windows.Forms.Padding)
            Me.cbstripeOrden.OverflowButton.Padding = CType(resources.GetObject("resource.Padding9"), System.Windows.Forms.Padding)
            Me.cbstripeOrden.OverflowButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft9"), Boolean)
            Me.cbstripeOrden.OverflowButton.Text = resources.GetString("resource.Text9")
            Me.cbstripeOrden.OverflowButton.TextOrientation = CType(resources.GetObject("resource.TextOrientation9"), System.Windows.Forms.Orientation)
            Me.cbstripeOrden.OverflowButton.TextWrap = CType(resources.GetObject("resource.TextWrap9"), Boolean)
            Me.cbstripeOrden.OverflowButton.ToolTipText = resources.GetString("resource.ToolTipText5")
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextWrap = CType(resources.GetObject("resource.TextWrap10"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextOrientation = CType(resources.GetObject("resource.TextOrientation10"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).FlipText = CType(resources.GetObject("resource.FlipText10"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Text = resources.GetString("resource.Text10")
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Padding = CType(resources.GetObject("resource.Padding10"), System.Windows.Forms.Padding)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Margin = CType(resources.GetObject("resource.Margin10"), System.Windows.Forms.Padding)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Alignment = CType(resources.GetObject("resource.Alignment10"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).RightToLeft = CType(resources.GetObject("resource.RightToLeft10"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).AngleTransform = CType(resources.GetObject("resource.AngleTransform10"), Single)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextWrap = CType(resources.GetObject("resource.TextWrap11"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextOrientation = CType(resources.GetObject("resource.TextOrientation11"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).FlipText = CType(resources.GetObject("resource.FlipText11"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Text = resources.GetString("resource.Text11")
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Padding = CType(resources.GetObject("resource.Padding11"), System.Windows.Forms.Padding)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Margin = CType(resources.GetObject("resource.Margin11"), System.Windows.Forms.Padding)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Alignment = CType(resources.GetObject("resource.Alignment11"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).RightToLeft = CType(resources.GetObject("resource.RightToLeft11"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).AngleTransform = CType(resources.GetObject("resource.AngleTransform11"), Single)
            '
            'ImpuestoLabel
            '
            resources.ApplyResources(Me.ImpuestoLabel, "ImpuestoLabel")
            Me.ImpuestoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ImpuestoLabel.Name = "ImpuestoLabel"
            '
            'cbComandos
            '
            resources.ApplyResources(Me.cbComandos, "cbComandos")
            Me.cbComandos.Name = "cbComandos"
            '
            '
            '
            Me.cbComandos.RootElement.AccessibleDescription = resources.GetString("cbComandos.RootElement.AccessibleDescription")
            Me.cbComandos.RootElement.AccessibleName = resources.GetString("cbComandos.RootElement.AccessibleName")
            Me.cbComandos.RootElement.Alignment = CType(resources.GetObject("cbComandos.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.cbComandos.RootElement.AngleTransform = CType(resources.GetObject("cbComandos.RootElement.AngleTransform"), Single)
            Me.cbComandos.RootElement.FlipText = CType(resources.GetObject("cbComandos.RootElement.FlipText"), Boolean)
            Me.cbComandos.RootElement.KeyTip = resources.GetString("cbComandos.RootElement.KeyTip")
            Me.cbComandos.RootElement.Margin = CType(resources.GetObject("cbComandos.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.cbComandos.RootElement.Text = resources.GetString("cbComandos.RootElement.Text")
            Me.cbComandos.RootElement.TextOrientation = CType(resources.GetObject("cbComandos.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.cbComandos.RootElement.ToolTipText = resources.GetString("cbComandos.RootElement.ToolTipText")
            Me.cbComandos.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
            '
            'RadSplitContainer1
            '
            resources.ApplyResources(Me.RadSplitContainer1, "RadSplitContainer1")
            Me.RadSplitContainer1.Controls.Add(Me.SplitPanel1)
            Me.RadSplitContainer1.Controls.Add(Me.SplitPanel2)
            Me.RadSplitContainer1.Controls.Add(Me.SplitPanel3)
            Me.RadSplitContainer1.Name = "RadSplitContainer1"
            '
            '
            '
            Me.RadSplitContainer1.RootElement.AccessibleDescription = resources.GetString("RadSplitContainer1.RootElement.AccessibleDescription")
            Me.RadSplitContainer1.RootElement.AccessibleName = resources.GetString("RadSplitContainer1.RootElement.AccessibleName")
            Me.RadSplitContainer1.RootElement.Alignment = CType(resources.GetObject("RadSplitContainer1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadSplitContainer1.RootElement.AngleTransform = CType(resources.GetObject("RadSplitContainer1.RootElement.AngleTransform"), Single)
            Me.RadSplitContainer1.RootElement.FlipText = CType(resources.GetObject("RadSplitContainer1.RootElement.FlipText"), Boolean)
            Me.RadSplitContainer1.RootElement.KeyTip = resources.GetString("RadSplitContainer1.RootElement.KeyTip")
            Me.RadSplitContainer1.RootElement.Margin = CType(resources.GetObject("RadSplitContainer1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.RadSplitContainer1.RootElement.Text = resources.GetString("RadSplitContainer1.RootElement.Text")
            Me.RadSplitContainer1.RootElement.TextOrientation = CType(resources.GetObject("RadSplitContainer1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadSplitContainer1.RootElement.ToolTipText = resources.GetString("RadSplitContainer1.RootElement.ToolTipText")
            Me.RadSplitContainer1.TabStop = False
            '
            'SplitPanel1
            '
            resources.ApplyResources(Me.SplitPanel1, "SplitPanel1")
            Me.SplitPanel1.Controls.Add(Me.RadSplitContainer2)
            Me.SplitPanel1.Name = "SplitPanel1"
            '
            '
            '
            Me.SplitPanel1.RootElement.AccessibleDescription = resources.GetString("SplitPanel1.RootElement.AccessibleDescription")
            Me.SplitPanel1.RootElement.AccessibleName = resources.GetString("SplitPanel1.RootElement.AccessibleName")
            Me.SplitPanel1.RootElement.Alignment = CType(resources.GetObject("SplitPanel1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel1.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel1.RootElement.AngleTransform"), Single)
            Me.SplitPanel1.RootElement.FlipText = CType(resources.GetObject("SplitPanel1.RootElement.FlipText"), Boolean)
            Me.SplitPanel1.RootElement.KeyTip = resources.GetString("SplitPanel1.RootElement.KeyTip")
            Me.SplitPanel1.RootElement.Margin = CType(resources.GetObject("SplitPanel1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel1.RootElement.Text = resources.GetString("SplitPanel1.RootElement.Text")
            Me.SplitPanel1.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel1.RootElement.ToolTipText = resources.GetString("SplitPanel1.RootElement.ToolTipText")
            Me.SplitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.14657!, 0.0!)
            Me.SplitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-162, 0)
            Me.SplitPanel1.TabStop = False
            '
            'RadSplitContainer2
            '
            resources.ApplyResources(Me.RadSplitContainer2, "RadSplitContainer2")
            Me.RadSplitContainer2.Controls.Add(Me.SplitPanel4)
            Me.RadSplitContainer2.Controls.Add(Me.SplitPanel5)
            Me.RadSplitContainer2.Name = "RadSplitContainer2"
            '
            '
            '
            Me.RadSplitContainer2.RootElement.AccessibleDescription = resources.GetString("RadSplitContainer2.RootElement.AccessibleDescription")
            Me.RadSplitContainer2.RootElement.AccessibleName = resources.GetString("RadSplitContainer2.RootElement.AccessibleName")
            Me.RadSplitContainer2.RootElement.Alignment = CType(resources.GetObject("RadSplitContainer2.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadSplitContainer2.RootElement.AngleTransform = CType(resources.GetObject("RadSplitContainer2.RootElement.AngleTransform"), Single)
            Me.RadSplitContainer2.RootElement.FlipText = CType(resources.GetObject("RadSplitContainer2.RootElement.FlipText"), Boolean)
            Me.RadSplitContainer2.RootElement.KeyTip = resources.GetString("RadSplitContainer2.RootElement.KeyTip")
            Me.RadSplitContainer2.RootElement.Margin = CType(resources.GetObject("RadSplitContainer2.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadSplitContainer2.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.RadSplitContainer2.RootElement.Text = resources.GetString("RadSplitContainer2.RootElement.Text")
            Me.RadSplitContainer2.RootElement.TextOrientation = CType(resources.GetObject("RadSplitContainer2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadSplitContainer2.RootElement.ToolTipText = resources.GetString("RadSplitContainer2.RootElement.ToolTipText")
            Me.RadSplitContainer2.TabStop = False
            '
            'SplitPanel4
            '
            resources.ApplyResources(Me.SplitPanel4, "SplitPanel4")
            Me.SplitPanel4.Controls.Add(Me.treeFamilia)
            Me.SplitPanel4.Name = "SplitPanel4"
            '
            '
            '
            Me.SplitPanel4.RootElement.AccessibleDescription = resources.GetString("SplitPanel4.RootElement.AccessibleDescription")
            Me.SplitPanel4.RootElement.AccessibleName = resources.GetString("SplitPanel4.RootElement.AccessibleName")
            Me.SplitPanel4.RootElement.Alignment = CType(resources.GetObject("SplitPanel4.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel4.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel4.RootElement.AngleTransform"), Single)
            Me.SplitPanel4.RootElement.FlipText = CType(resources.GetObject("SplitPanel4.RootElement.FlipText"), Boolean)
            Me.SplitPanel4.RootElement.KeyTip = resources.GetString("SplitPanel4.RootElement.KeyTip")
            Me.SplitPanel4.RootElement.Margin = CType(resources.GetObject("SplitPanel4.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel4.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel4.RootElement.Text = resources.GetString("SplitPanel4.RootElement.Text")
            Me.SplitPanel4.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel4.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel4.RootElement.ToolTipText = resources.GetString("SplitPanel4.RootElement.ToolTipText")
            Me.SplitPanel4.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.0!, 0.1694045!)
            Me.SplitPanel4.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 92)
            Me.SplitPanel4.TabStop = False
            '
            'treeFamilia
            '
            resources.ApplyResources(Me.treeFamilia, "treeFamilia")
            Me.treeFamilia.AllowDrop = True
            Me.treeFamilia.AllowPlusMinusAnimation = True
            Me.treeFamilia.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.treeFamilia.Cursor = System.Windows.Forms.Cursors.Default
            Me.treeFamilia.ExpandAnimation = Telerik.WinControls.UI.ExpandAnimation.None
            Me.treeFamilia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.treeFamilia.ImageList = Me.imglFamilia
            Me.treeFamilia.LineColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.treeFamilia.Name = "treeFamilia"
            '
            '
            '
            Me.treeFamilia.RootElement.AccessibleDescription = resources.GetString("treeFamilia.RootElement.AccessibleDescription")
            Me.treeFamilia.RootElement.AccessibleName = resources.GetString("treeFamilia.RootElement.AccessibleName")
            Me.treeFamilia.RootElement.Alignment = CType(resources.GetObject("treeFamilia.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.treeFamilia.RootElement.AngleTransform = CType(resources.GetObject("treeFamilia.RootElement.AngleTransform"), Single)
            Me.treeFamilia.RootElement.FlipText = CType(resources.GetObject("treeFamilia.RootElement.FlipText"), Boolean)
            Me.treeFamilia.RootElement.KeyTip = resources.GetString("treeFamilia.RootElement.KeyTip")
            Me.treeFamilia.RootElement.Margin = CType(resources.GetObject("treeFamilia.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.treeFamilia.RootElement.Text = resources.GetString("treeFamilia.RootElement.Text")
            Me.treeFamilia.RootElement.TextOrientation = CType(resources.GetObject("treeFamilia.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.treeFamilia.RootElement.ToolTipText = resources.GetString("treeFamilia.RootElement.ToolTipText")
            Me.treeFamilia.ShowLines = True
            Me.treeFamilia.SpacingBetweenNodes = 2
            Me.treeFamilia.ToggleMode = Telerik.WinControls.UI.ToggleMode.None
            '
            'imglFamilia
            '
            Me.imglFamilia.ImageStream = CType(resources.GetObject("imglFamilia.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imglFamilia.TransparentColor = System.Drawing.Color.Transparent
            Me.imglFamilia.Images.SetKeyName(0, "bullet_blue.png")
            Me.imglFamilia.Images.SetKeyName(1, "bullet_green.png")
            Me.imglFamilia.Images.SetKeyName(2, "bullet_orange.png")
            Me.imglFamilia.Images.SetKeyName(3, "bullet_pink.png")
            Me.imglFamilia.Images.SetKeyName(4, "bullet_black.png")
            Me.imglFamilia.Images.SetKeyName(5, "bullet_purple.png")
            Me.imglFamilia.Images.SetKeyName(6, "bullet_red.png")
            Me.imglFamilia.Images.SetKeyName(7, "bullet_yellow.png")
            '
            'SplitPanel5
            '
            resources.ApplyResources(Me.SplitPanel5, "SplitPanel5")
            Me.SplitPanel5.Controls.Add(Me.lstvOfertas)
            Me.SplitPanel5.Name = "SplitPanel5"
            '
            '
            '
            Me.SplitPanel5.RootElement.AccessibleDescription = resources.GetString("SplitPanel5.RootElement.AccessibleDescription")
            Me.SplitPanel5.RootElement.AccessibleName = resources.GetString("SplitPanel5.RootElement.AccessibleName")
            Me.SplitPanel5.RootElement.Alignment = CType(resources.GetObject("SplitPanel5.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel5.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel5.RootElement.AngleTransform"), Single)
            Me.SplitPanel5.RootElement.FlipText = CType(resources.GetObject("SplitPanel5.RootElement.FlipText"), Boolean)
            Me.SplitPanel5.RootElement.KeyTip = resources.GetString("SplitPanel5.RootElement.KeyTip")
            Me.SplitPanel5.RootElement.Margin = CType(resources.GetObject("SplitPanel5.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel5.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel5.RootElement.Text = resources.GetString("SplitPanel5.RootElement.Text")
            Me.SplitPanel5.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel5.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel5.RootElement.ToolTipText = resources.GetString("SplitPanel5.RootElement.ToolTipText")
            Me.SplitPanel5.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.0!, -0.1694045!)
            Me.SplitPanel5.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -92)
            Me.SplitPanel5.TabStop = False
            '
            'lstvOfertas
            '
            resources.ApplyResources(Me.lstvOfertas, "lstvOfertas")
            Me.lstvOfertas.AllowColumnReorder = False
            Me.lstvOfertas.AllowDrop = True
            Me.lstvOfertas.AllowEdit = False
            Me.lstvOfertas.AllowRemove = False
            ListViewDetailColumn1.HeaderText = "Nº Oferta"
            ListViewDetailColumn1.Width = 80.0!
            ListViewDetailColumn2.HeaderText = "Plan"
            ListViewDetailColumn2.Width = 150.0!
            Me.lstvOfertas.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {ListViewDetailColumn1, ListViewDetailColumn2})
            Me.lstvOfertas.EnableColumnSort = True
            Me.lstvOfertas.EnableSorting = True
            Me.lstvOfertas.ItemSize = New System.Drawing.Size(200, 25)
            Me.lstvOfertas.ItemSpacing = 1
            Me.lstvOfertas.Name = "lstvOfertas"
            '
            '
            '
            Me.lstvOfertas.RootElement.AccessibleDescription = resources.GetString("lstvOfertas.RootElement.AccessibleDescription")
            Me.lstvOfertas.RootElement.AccessibleName = resources.GetString("lstvOfertas.RootElement.AccessibleName")
            Me.lstvOfertas.RootElement.Alignment = CType(resources.GetObject("lstvOfertas.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lstvOfertas.RootElement.AngleTransform = CType(resources.GetObject("lstvOfertas.RootElement.AngleTransform"), Single)
            Me.lstvOfertas.RootElement.FlipText = CType(resources.GetObject("lstvOfertas.RootElement.FlipText"), Boolean)
            Me.lstvOfertas.RootElement.KeyTip = resources.GetString("lstvOfertas.RootElement.KeyTip")
            Me.lstvOfertas.RootElement.Margin = CType(resources.GetObject("lstvOfertas.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lstvOfertas.RootElement.Text = resources.GetString("lstvOfertas.RootElement.Text")
            Me.lstvOfertas.RootElement.TextOrientation = CType(resources.GetObject("lstvOfertas.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.lstvOfertas.RootElement.ToolTipText = resources.GetString("lstvOfertas.RootElement.ToolTipText")
            Me.lstvOfertas.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
            '
            'SplitPanel2
            '
            resources.ApplyResources(Me.SplitPanel2, "SplitPanel2")
            Me.SplitPanel2.Controls.Add(Me.gridDatos)
            Me.SplitPanel2.Controls.Add(Me.statuInfo)
            Me.SplitPanel2.Name = "SplitPanel2"
            '
            '
            '
            Me.SplitPanel2.RootElement.AccessibleDescription = resources.GetString("SplitPanel2.RootElement.AccessibleDescription")
            Me.SplitPanel2.RootElement.AccessibleName = resources.GetString("SplitPanel2.RootElement.AccessibleName")
            Me.SplitPanel2.RootElement.Alignment = CType(resources.GetObject("SplitPanel2.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel2.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel2.RootElement.AngleTransform"), Single)
            Me.SplitPanel2.RootElement.FlipText = CType(resources.GetObject("SplitPanel2.RootElement.FlipText"), Boolean)
            Me.SplitPanel2.RootElement.KeyTip = resources.GetString("SplitPanel2.RootElement.KeyTip")
            Me.SplitPanel2.RootElement.Margin = CType(resources.GetObject("SplitPanel2.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel2.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel2.RootElement.Text = resources.GetString("SplitPanel2.RootElement.Text")
            Me.SplitPanel2.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel2.RootElement.ToolTipText = resources.GetString("SplitPanel2.RootElement.ToolTipText")
            Me.SplitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.2650348!, 0.0!)
            Me.SplitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(263, 0)
            Me.SplitPanel2.TabStop = False
            '
            'statuInfo
            '
            resources.ApplyResources(Me.statuInfo, "statuInfo")
            Me.statuInfo.Items.AddRange(New Telerik.WinControls.RadItem() {Me.btneAnterior, Me.btneSiguiente, Me.lblePagina, Me.RadToolStripSeparatorItem1, Me.lbleDiagnostico, Me.chkeNoActivos, Me.chkePaginar})
            Me.statuInfo.Name = "statuInfo"
            '
            '
            '
            Me.statuInfo.RootElement.AccessibleDescription = resources.GetString("statuInfo.RootElement.AccessibleDescription")
            Me.statuInfo.RootElement.AccessibleName = resources.GetString("statuInfo.RootElement.AccessibleName")
            Me.statuInfo.RootElement.Alignment = CType(resources.GetObject("statuInfo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.statuInfo.RootElement.AngleTransform = CType(resources.GetObject("statuInfo.RootElement.AngleTransform"), Single)
            Me.statuInfo.RootElement.FlipText = CType(resources.GetObject("statuInfo.RootElement.FlipText"), Boolean)
            Me.statuInfo.RootElement.KeyTip = resources.GetString("statuInfo.RootElement.KeyTip")
            Me.statuInfo.RootElement.Margin = CType(resources.GetObject("statuInfo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.statuInfo.RootElement.Text = resources.GetString("statuInfo.RootElement.Text")
            Me.statuInfo.RootElement.TextOrientation = CType(resources.GetObject("statuInfo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.statuInfo.RootElement.ToolTipText = resources.GetString("statuInfo.RootElement.ToolTipText")
            '
            'btneAnterior
            '
            resources.ApplyResources(Me.btneAnterior, "btneAnterior")
            Me.btneAnterior.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.btneAnterior.Image = Global.EasyGest.My.Resources.Resources.left
            Me.btneAnterior.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.btneAnterior.Name = "btneAnterior"
            Me.btneAnterior.ShowBorder = False
            Me.statuInfo.SetSpring(Me.btneAnterior, False)
            Me.btneAnterior.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'btneSiguiente
            '
            resources.ApplyResources(Me.btneSiguiente, "btneSiguiente")
            Me.btneSiguiente.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.btneSiguiente.Image = Global.EasyGest.My.Resources.Resources.right
            Me.btneSiguiente.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.btneSiguiente.Name = "btneSiguiente"
            Me.btneSiguiente.ShowBorder = False
            Me.statuInfo.SetSpring(Me.btneSiguiente, False)
            Me.btneSiguiente.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'lblePagina
            '
            resources.ApplyResources(Me.lblePagina, "lblePagina")
            Me.lblePagina.AutoSize = False
            Me.lblePagina.Bounds = New System.Drawing.Rectangle(0, 0, 54, 20)
            Me.lblePagina.Name = "lblePagina"
            Me.statuInfo.SetSpring(Me.lblePagina, False)
            Me.lblePagina.TextWrap = True
            Me.lblePagina.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'RadToolStripSeparatorItem1
            '
            resources.ApplyResources(Me.RadToolStripSeparatorItem1, "RadToolStripSeparatorItem1")
            Me.RadToolStripSeparatorItem1.Name = "RadToolStripSeparatorItem1"
            Me.statuInfo.SetSpring(Me.RadToolStripSeparatorItem1, False)
            Me.RadToolStripSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.RadToolStripSeparatorItem1.VisibleInOverflowMenu = False
            '
            'lbleDiagnostico
            '
            resources.ApplyResources(Me.lbleDiagnostico, "lbleDiagnostico")
            Me.lbleDiagnostico.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbleDiagnostico.Name = "lbleDiagnostico"
            Me.statuInfo.SetSpring(Me.lbleDiagnostico, True)
            Me.lbleDiagnostico.TextWrap = True
            Me.lbleDiagnostico.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'chkeNoActivos
            '
            resources.ApplyResources(Me.chkeNoActivos, "chkeNoActivos")
            Me.chkeNoActivos.Checked = False
            Me.chkeNoActivos.Font = New System.Drawing.Font("KaiTi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkeNoActivos.Name = "chkeNoActivos"
            Me.chkeNoActivos.PositionOffset = New System.Drawing.SizeF(0.0!, 0.0!)
            Me.chkeNoActivos.ReadOnly = False
            Me.statuInfo.SetSpring(Me.chkeNoActivos, False)
            Me.chkeNoActivos.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'chkePaginar
            '
            resources.ApplyResources(Me.chkePaginar, "chkePaginar")
            Me.chkePaginar.CheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.chkePaginar.Checked = True
            Me.chkePaginar.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkePaginar.Font = New System.Drawing.Font("KaiTi", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkePaginar.Image = Global.EasyGest.My.Resources.Resources.categories
            Me.chkePaginar.Name = "chkePaginar"
            Me.chkePaginar.ReadOnly = False
            Me.statuInfo.SetSpring(Me.chkePaginar, False)
            Me.chkePaginar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.chkePaginar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Me.chkePaginar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'SplitPanel3
            '
            resources.ApplyResources(Me.SplitPanel3, "SplitPanel3")
            Me.SplitPanel3.Controls.Add(Me.pvInfo)
            Me.SplitPanel3.Name = "SplitPanel3"
            '
            '
            '
            Me.SplitPanel3.RootElement.AccessibleDescription = resources.GetString("SplitPanel3.RootElement.AccessibleDescription")
            Me.SplitPanel3.RootElement.AccessibleName = resources.GetString("SplitPanel3.RootElement.AccessibleName")
            Me.SplitPanel3.RootElement.Alignment = CType(resources.GetObject("SplitPanel3.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel3.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel3.RootElement.AngleTransform"), Single)
            Me.SplitPanel3.RootElement.FlipText = CType(resources.GetObject("SplitPanel3.RootElement.FlipText"), Boolean)
            Me.SplitPanel3.RootElement.KeyTip = resources.GetString("SplitPanel3.RootElement.KeyTip")
            Me.SplitPanel3.RootElement.Margin = CType(resources.GetObject("SplitPanel3.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel3.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel3.RootElement.Text = resources.GetString("SplitPanel3.RootElement.Text")
            Me.SplitPanel3.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel3.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel3.RootElement.ToolTipText = resources.GetString("SplitPanel3.RootElement.ToolTipText")
            Me.SplitPanel3.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.1184648!, 0.0!)
            Me.SplitPanel3.SizeInfo.SplitterCorrection = New System.Drawing.Size(-101, 0)
            Me.SplitPanel3.TabStop = False
            '
            'pvInfo
            '
            resources.ApplyResources(Me.pvInfo, "pvInfo")
            Me.pvInfo.Controls.Add(Me.pvpDetalle)
            Me.pvInfo.Controls.Add(Me.pvpOtro)
            Me.pvInfo.Name = "pvInfo"
            '
            '
            '
            Me.pvInfo.RootElement.AccessibleDescription = resources.GetString("pvInfo.RootElement.AccessibleDescription")
            Me.pvInfo.RootElement.AccessibleName = resources.GetString("pvInfo.RootElement.AccessibleName")
            Me.pvInfo.RootElement.Alignment = CType(resources.GetObject("pvInfo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.pvInfo.RootElement.AngleTransform = CType(resources.GetObject("pvInfo.RootElement.AngleTransform"), Single)
            Me.pvInfo.RootElement.FlipText = CType(resources.GetObject("pvInfo.RootElement.FlipText"), Boolean)
            Me.pvInfo.RootElement.KeyTip = resources.GetString("pvInfo.RootElement.KeyTip")
            Me.pvInfo.RootElement.Margin = CType(resources.GetObject("pvInfo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.pvInfo.RootElement.Text = resources.GetString("pvInfo.RootElement.Text")
            Me.pvInfo.RootElement.TextOrientation = CType(resources.GetObject("pvInfo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.pvInfo.RootElement.ToolTipText = resources.GetString("pvInfo.RootElement.ToolTipText")
            Me.pvInfo.SelectedPage = Me.pvpOtro
            Me.pvInfo.TabStop = False
            CType(Me.pvInfo.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSpacing = 3
            '
            'pvpDetalle
            '
            resources.ApplyResources(Me.pvpDetalle, "pvpDetalle")
            Me.pvpDetalle.Controls.Add(FModificacionLabel)
            Me.pvpDetalle.Controls.Add(Me.FModificacionRadLabel)
            Me.pvpDetalle.Controls.Add(FCreacionLabel)
            Me.pvpDetalle.Controls.Add(Me.FCreacionRadLabel)
            Me.pvpDetalle.Controls.Add(Label1)
            Me.pvpDetalle.Controls.Add(Me.FidelizableRadLabel)
            Me.pvpDetalle.Controls.Add(ActivoLabel)
            Me.pvpDetalle.Controls.Add(Me.ActivoRadLabel)
            Me.pvpDetalle.Controls.Add(ControlStockLabel)
            Me.pvpDetalle.Controls.Add(Me.ControlStockRadLabel)
            Me.pvpDetalle.Controls.Add(MedidaLabel)
            Me.pvpDetalle.Controls.Add(Me.MedidaRadLabel)
            Me.pvpDetalle.Controls.Add(UbicacionLabel)
            Me.pvpDetalle.Controls.Add(Me.UbicacionRadLabel)
            Me.pvpDetalle.Controls.Add(FamiliaLabel)
            Me.pvpDetalle.Controls.Add(Me.FamiliaRadLabel)
            Me.pvpDetalle.Controls.Add(MarcaLabel)
            Me.pvpDetalle.Controls.Add(Me.MarcaRadLabel)
            Me.pvpDetalle.Controls.Add(DescripcionCNLabel)
            Me.pvpDetalle.Controls.Add(Me.DescripcionCNRadLabel)
            Me.pvpDetalle.Controls.Add(DescripcionLabel)
            Me.pvpDetalle.Controls.Add(Me.DescripcionRadLabel)
            Me.pvpDetalle.Controls.Add(ReferenciaLabel)
            Me.pvpDetalle.Controls.Add(Me.ReferenciaRadLabel)
            Me.pvpDetalle.Description = Nothing
            Me.pvpDetalle.ItemSize = New System.Drawing.SizeF(44.0!, 28.0!)
            Me.pvpDetalle.Name = "pvpDetalle"
            Me.pvpDetalle.Title = "Detalle"
            '
            'FModificacionRadLabel
            '
            resources.ApplyResources(Me.FModificacionRadLabel, "FModificacionRadLabel")
            Me.FModificacionRadLabel.BorderVisible = True
            Me.FModificacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "FModificacion", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "G"))
            Me.FModificacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FModificacionRadLabel.Name = "FModificacionRadLabel"
            '
            '
            '
            Me.FModificacionRadLabel.RootElement.AccessibleDescription = resources.GetString("FModificacionRadLabel.RootElement.AccessibleDescription")
            Me.FModificacionRadLabel.RootElement.AccessibleName = resources.GetString("FModificacionRadLabel.RootElement.AccessibleName")
            Me.FModificacionRadLabel.RootElement.Alignment = CType(resources.GetObject("FModificacionRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.FModificacionRadLabel.RootElement.AngleTransform = CType(resources.GetObject("FModificacionRadLabel.RootElement.AngleTransform"), Single)
            Me.FModificacionRadLabel.RootElement.FlipText = CType(resources.GetObject("FModificacionRadLabel.RootElement.FlipText"), Boolean)
            Me.FModificacionRadLabel.RootElement.KeyTip = resources.GetString("FModificacionRadLabel.RootElement.KeyTip")
            Me.FModificacionRadLabel.RootElement.Margin = CType(resources.GetObject("FModificacionRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.FModificacionRadLabel.RootElement.Text = resources.GetString("FModificacionRadLabel.RootElement.Text")
            Me.FModificacionRadLabel.RootElement.TextOrientation = CType(resources.GetObject("FModificacionRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.FModificacionRadLabel.RootElement.ToolTipText = resources.GetString("FModificacionRadLabel.RootElement.ToolTipText")
            CType(Me.FModificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FModificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text12")
            CType(Me.FModificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FModificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'VWProductoBindingSource
            '
            Me.VWProductoBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.VWProductos)
            '
            'FCreacionRadLabel
            '
            resources.ApplyResources(Me.FCreacionRadLabel, "FCreacionRadLabel")
            Me.FCreacionRadLabel.BorderVisible = True
            Me.FCreacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "FCreacion", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "G"))
            Me.FCreacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FCreacionRadLabel.Name = "FCreacionRadLabel"
            '
            '
            '
            Me.FCreacionRadLabel.RootElement.AccessibleDescription = resources.GetString("FCreacionRadLabel.RootElement.AccessibleDescription")
            Me.FCreacionRadLabel.RootElement.AccessibleName = resources.GetString("FCreacionRadLabel.RootElement.AccessibleName")
            Me.FCreacionRadLabel.RootElement.Alignment = CType(resources.GetObject("FCreacionRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.FCreacionRadLabel.RootElement.AngleTransform = CType(resources.GetObject("FCreacionRadLabel.RootElement.AngleTransform"), Single)
            Me.FCreacionRadLabel.RootElement.FlipText = CType(resources.GetObject("FCreacionRadLabel.RootElement.FlipText"), Boolean)
            Me.FCreacionRadLabel.RootElement.KeyTip = resources.GetString("FCreacionRadLabel.RootElement.KeyTip")
            Me.FCreacionRadLabel.RootElement.Margin = CType(resources.GetObject("FCreacionRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.FCreacionRadLabel.RootElement.Text = resources.GetString("FCreacionRadLabel.RootElement.Text")
            Me.FCreacionRadLabel.RootElement.TextOrientation = CType(resources.GetObject("FCreacionRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.FCreacionRadLabel.RootElement.ToolTipText = resources.GetString("FCreacionRadLabel.RootElement.ToolTipText")
            CType(Me.FCreacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FCreacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text13")
            CType(Me.FCreacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FCreacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'FidelizableRadLabel
            '
            resources.ApplyResources(Me.FidelizableRadLabel, "FidelizableRadLabel")
            Me.FidelizableRadLabel.BorderVisible = True
            Me.FidelizableRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Fidelizable", True))
            Me.FidelizableRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FidelizableRadLabel.Name = "FidelizableRadLabel"
            '
            '
            '
            Me.FidelizableRadLabel.RootElement.AccessibleDescription = resources.GetString("FidelizableRadLabel.RootElement.AccessibleDescription")
            Me.FidelizableRadLabel.RootElement.AccessibleName = resources.GetString("FidelizableRadLabel.RootElement.AccessibleName")
            Me.FidelizableRadLabel.RootElement.Alignment = CType(resources.GetObject("FidelizableRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.FidelizableRadLabel.RootElement.AngleTransform = CType(resources.GetObject("FidelizableRadLabel.RootElement.AngleTransform"), Single)
            Me.FidelizableRadLabel.RootElement.FlipText = CType(resources.GetObject("FidelizableRadLabel.RootElement.FlipText"), Boolean)
            Me.FidelizableRadLabel.RootElement.KeyTip = resources.GetString("FidelizableRadLabel.RootElement.KeyTip")
            Me.FidelizableRadLabel.RootElement.Margin = CType(resources.GetObject("FidelizableRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.FidelizableRadLabel.RootElement.Text = resources.GetString("FidelizableRadLabel.RootElement.Text")
            Me.FidelizableRadLabel.RootElement.TextOrientation = CType(resources.GetObject("FidelizableRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.FidelizableRadLabel.RootElement.ToolTipText = resources.GetString("FidelizableRadLabel.RootElement.ToolTipText")
            CType(Me.FidelizableRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FidelizableRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text14")
            CType(Me.FidelizableRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FidelizableRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ActivoRadLabel
            '
            resources.ApplyResources(Me.ActivoRadLabel, "ActivoRadLabel")
            Me.ActivoRadLabel.BorderVisible = True
            Me.ActivoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Activo", True))
            Me.ActivoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ActivoRadLabel.Name = "ActivoRadLabel"
            '
            '
            '
            Me.ActivoRadLabel.RootElement.AccessibleDescription = resources.GetString("ActivoRadLabel.RootElement.AccessibleDescription")
            Me.ActivoRadLabel.RootElement.AccessibleName = resources.GetString("ActivoRadLabel.RootElement.AccessibleName")
            Me.ActivoRadLabel.RootElement.Alignment = CType(resources.GetObject("ActivoRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ActivoRadLabel.RootElement.AngleTransform = CType(resources.GetObject("ActivoRadLabel.RootElement.AngleTransform"), Single)
            Me.ActivoRadLabel.RootElement.FlipText = CType(resources.GetObject("ActivoRadLabel.RootElement.FlipText"), Boolean)
            Me.ActivoRadLabel.RootElement.KeyTip = resources.GetString("ActivoRadLabel.RootElement.KeyTip")
            Me.ActivoRadLabel.RootElement.Margin = CType(resources.GetObject("ActivoRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ActivoRadLabel.RootElement.Text = resources.GetString("ActivoRadLabel.RootElement.Text")
            Me.ActivoRadLabel.RootElement.TextOrientation = CType(resources.GetObject("ActivoRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ActivoRadLabel.RootElement.ToolTipText = resources.GetString("ActivoRadLabel.RootElement.ToolTipText")
            CType(Me.ActivoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ActivoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text15")
            CType(Me.ActivoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ActivoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ControlStockRadLabel
            '
            resources.ApplyResources(Me.ControlStockRadLabel, "ControlStockRadLabel")
            Me.ControlStockRadLabel.BorderVisible = True
            Me.ControlStockRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "ControlStock", True))
            Me.ControlStockRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ControlStockRadLabel.Name = "ControlStockRadLabel"
            '
            '
            '
            Me.ControlStockRadLabel.RootElement.AccessibleDescription = resources.GetString("ControlStockRadLabel.RootElement.AccessibleDescription")
            Me.ControlStockRadLabel.RootElement.AccessibleName = resources.GetString("ControlStockRadLabel.RootElement.AccessibleName")
            Me.ControlStockRadLabel.RootElement.Alignment = CType(resources.GetObject("ControlStockRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ControlStockRadLabel.RootElement.AngleTransform = CType(resources.GetObject("ControlStockRadLabel.RootElement.AngleTransform"), Single)
            Me.ControlStockRadLabel.RootElement.FlipText = CType(resources.GetObject("ControlStockRadLabel.RootElement.FlipText"), Boolean)
            Me.ControlStockRadLabel.RootElement.KeyTip = resources.GetString("ControlStockRadLabel.RootElement.KeyTip")
            Me.ControlStockRadLabel.RootElement.Margin = CType(resources.GetObject("ControlStockRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ControlStockRadLabel.RootElement.Text = resources.GetString("ControlStockRadLabel.RootElement.Text")
            Me.ControlStockRadLabel.RootElement.TextOrientation = CType(resources.GetObject("ControlStockRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ControlStockRadLabel.RootElement.ToolTipText = resources.GetString("ControlStockRadLabel.RootElement.ToolTipText")
            CType(Me.ControlStockRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ControlStockRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text16")
            CType(Me.ControlStockRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ControlStockRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'MedidaRadLabel
            '
            resources.ApplyResources(Me.MedidaRadLabel, "MedidaRadLabel")
            Me.MedidaRadLabel.BorderVisible = True
            Me.MedidaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Medida", True))
            Me.MedidaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.MedidaRadLabel.Name = "MedidaRadLabel"
            '
            '
            '
            Me.MedidaRadLabel.RootElement.AccessibleDescription = resources.GetString("MedidaRadLabel.RootElement.AccessibleDescription")
            Me.MedidaRadLabel.RootElement.AccessibleName = resources.GetString("MedidaRadLabel.RootElement.AccessibleName")
            Me.MedidaRadLabel.RootElement.Alignment = CType(resources.GetObject("MedidaRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.MedidaRadLabel.RootElement.AngleTransform = CType(resources.GetObject("MedidaRadLabel.RootElement.AngleTransform"), Single)
            Me.MedidaRadLabel.RootElement.FlipText = CType(resources.GetObject("MedidaRadLabel.RootElement.FlipText"), Boolean)
            Me.MedidaRadLabel.RootElement.KeyTip = resources.GetString("MedidaRadLabel.RootElement.KeyTip")
            Me.MedidaRadLabel.RootElement.Margin = CType(resources.GetObject("MedidaRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.MedidaRadLabel.RootElement.Text = resources.GetString("MedidaRadLabel.RootElement.Text")
            Me.MedidaRadLabel.RootElement.TextOrientation = CType(resources.GetObject("MedidaRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.MedidaRadLabel.RootElement.ToolTipText = resources.GetString("MedidaRadLabel.RootElement.ToolTipText")
            CType(Me.MedidaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.MedidaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text17")
            CType(Me.MedidaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.MedidaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'UbicacionRadLabel
            '
            resources.ApplyResources(Me.UbicacionRadLabel, "UbicacionRadLabel")
            Me.UbicacionRadLabel.BorderVisible = True
            Me.UbicacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Ubicacion", True))
            Me.UbicacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.UbicacionRadLabel.Name = "UbicacionRadLabel"
            '
            '
            '
            Me.UbicacionRadLabel.RootElement.AccessibleDescription = resources.GetString("UbicacionRadLabel.RootElement.AccessibleDescription")
            Me.UbicacionRadLabel.RootElement.AccessibleName = resources.GetString("UbicacionRadLabel.RootElement.AccessibleName")
            Me.UbicacionRadLabel.RootElement.Alignment = CType(resources.GetObject("UbicacionRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.UbicacionRadLabel.RootElement.AngleTransform = CType(resources.GetObject("UbicacionRadLabel.RootElement.AngleTransform"), Single)
            Me.UbicacionRadLabel.RootElement.FlipText = CType(resources.GetObject("UbicacionRadLabel.RootElement.FlipText"), Boolean)
            Me.UbicacionRadLabel.RootElement.KeyTip = resources.GetString("UbicacionRadLabel.RootElement.KeyTip")
            Me.UbicacionRadLabel.RootElement.Margin = CType(resources.GetObject("UbicacionRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.UbicacionRadLabel.RootElement.Text = resources.GetString("UbicacionRadLabel.RootElement.Text")
            Me.UbicacionRadLabel.RootElement.TextOrientation = CType(resources.GetObject("UbicacionRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.UbicacionRadLabel.RootElement.ToolTipText = resources.GetString("UbicacionRadLabel.RootElement.ToolTipText")
            CType(Me.UbicacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.UbicacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text18")
            CType(Me.UbicacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.UbicacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'FamiliaRadLabel
            '
            resources.ApplyResources(Me.FamiliaRadLabel, "FamiliaRadLabel")
            Me.FamiliaRadLabel.BorderVisible = True
            Me.FamiliaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Familia", True))
            Me.FamiliaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FamiliaRadLabel.Name = "FamiliaRadLabel"
            '
            '
            '
            Me.FamiliaRadLabel.RootElement.AccessibleDescription = resources.GetString("FamiliaRadLabel.RootElement.AccessibleDescription")
            Me.FamiliaRadLabel.RootElement.AccessibleName = resources.GetString("FamiliaRadLabel.RootElement.AccessibleName")
            Me.FamiliaRadLabel.RootElement.Alignment = CType(resources.GetObject("FamiliaRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.FamiliaRadLabel.RootElement.AngleTransform = CType(resources.GetObject("FamiliaRadLabel.RootElement.AngleTransform"), Single)
            Me.FamiliaRadLabel.RootElement.FlipText = CType(resources.GetObject("FamiliaRadLabel.RootElement.FlipText"), Boolean)
            Me.FamiliaRadLabel.RootElement.KeyTip = resources.GetString("FamiliaRadLabel.RootElement.KeyTip")
            Me.FamiliaRadLabel.RootElement.Margin = CType(resources.GetObject("FamiliaRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.FamiliaRadLabel.RootElement.Text = resources.GetString("FamiliaRadLabel.RootElement.Text")
            Me.FamiliaRadLabel.RootElement.TextOrientation = CType(resources.GetObject("FamiliaRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.FamiliaRadLabel.RootElement.ToolTipText = resources.GetString("FamiliaRadLabel.RootElement.ToolTipText")
            CType(Me.FamiliaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FamiliaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text19")
            CType(Me.FamiliaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FamiliaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'MarcaRadLabel
            '
            resources.ApplyResources(Me.MarcaRadLabel, "MarcaRadLabel")
            Me.MarcaRadLabel.BorderVisible = True
            Me.MarcaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Marca", True))
            Me.MarcaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.MarcaRadLabel.Name = "MarcaRadLabel"
            '
            '
            '
            Me.MarcaRadLabel.RootElement.AccessibleDescription = resources.GetString("MarcaRadLabel.RootElement.AccessibleDescription")
            Me.MarcaRadLabel.RootElement.AccessibleName = resources.GetString("MarcaRadLabel.RootElement.AccessibleName")
            Me.MarcaRadLabel.RootElement.Alignment = CType(resources.GetObject("MarcaRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.MarcaRadLabel.RootElement.AngleTransform = CType(resources.GetObject("MarcaRadLabel.RootElement.AngleTransform"), Single)
            Me.MarcaRadLabel.RootElement.FlipText = CType(resources.GetObject("MarcaRadLabel.RootElement.FlipText"), Boolean)
            Me.MarcaRadLabel.RootElement.KeyTip = resources.GetString("MarcaRadLabel.RootElement.KeyTip")
            Me.MarcaRadLabel.RootElement.Margin = CType(resources.GetObject("MarcaRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.MarcaRadLabel.RootElement.Text = resources.GetString("MarcaRadLabel.RootElement.Text")
            Me.MarcaRadLabel.RootElement.TextOrientation = CType(resources.GetObject("MarcaRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.MarcaRadLabel.RootElement.ToolTipText = resources.GetString("MarcaRadLabel.RootElement.ToolTipText")
            CType(Me.MarcaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.MarcaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text20")
            CType(Me.MarcaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.MarcaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'DescripcionCNRadLabel
            '
            resources.ApplyResources(Me.DescripcionCNRadLabel, "DescripcionCNRadLabel")
            Me.DescripcionCNRadLabel.BorderVisible = True
            Me.DescripcionCNRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "DescripcionLarga", True))
            Me.DescripcionCNRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.DescripcionCNRadLabel.Name = "DescripcionCNRadLabel"
            '
            '
            '
            Me.DescripcionCNRadLabel.RootElement.AccessibleDescription = resources.GetString("DescripcionCNRadLabel.RootElement.AccessibleDescription")
            Me.DescripcionCNRadLabel.RootElement.AccessibleName = resources.GetString("DescripcionCNRadLabel.RootElement.AccessibleName")
            Me.DescripcionCNRadLabel.RootElement.Alignment = CType(resources.GetObject("DescripcionCNRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.DescripcionCNRadLabel.RootElement.AngleTransform = CType(resources.GetObject("DescripcionCNRadLabel.RootElement.AngleTransform"), Single)
            Me.DescripcionCNRadLabel.RootElement.FlipText = CType(resources.GetObject("DescripcionCNRadLabel.RootElement.FlipText"), Boolean)
            Me.DescripcionCNRadLabel.RootElement.KeyTip = resources.GetString("DescripcionCNRadLabel.RootElement.KeyTip")
            Me.DescripcionCNRadLabel.RootElement.Margin = CType(resources.GetObject("DescripcionCNRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.DescripcionCNRadLabel.RootElement.Text = resources.GetString("DescripcionCNRadLabel.RootElement.Text")
            Me.DescripcionCNRadLabel.RootElement.TextOrientation = CType(resources.GetObject("DescripcionCNRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.DescripcionCNRadLabel.RootElement.ToolTipText = resources.GetString("DescripcionCNRadLabel.RootElement.ToolTipText")
            CType(Me.DescripcionCNRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.DescripcionCNRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text21")
            CType(Me.DescripcionCNRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.DescripcionCNRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'DescripcionRadLabel
            '
            resources.ApplyResources(Me.DescripcionRadLabel, "DescripcionRadLabel")
            Me.DescripcionRadLabel.BorderVisible = True
            Me.DescripcionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Descripcion", True))
            Me.DescripcionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.DescripcionRadLabel.Name = "DescripcionRadLabel"
            '
            '
            '
            Me.DescripcionRadLabel.RootElement.AccessibleDescription = resources.GetString("DescripcionRadLabel.RootElement.AccessibleDescription")
            Me.DescripcionRadLabel.RootElement.AccessibleName = resources.GetString("DescripcionRadLabel.RootElement.AccessibleName")
            Me.DescripcionRadLabel.RootElement.Alignment = CType(resources.GetObject("DescripcionRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.DescripcionRadLabel.RootElement.AngleTransform = CType(resources.GetObject("DescripcionRadLabel.RootElement.AngleTransform"), Single)
            Me.DescripcionRadLabel.RootElement.FlipText = CType(resources.GetObject("DescripcionRadLabel.RootElement.FlipText"), Boolean)
            Me.DescripcionRadLabel.RootElement.KeyTip = resources.GetString("DescripcionRadLabel.RootElement.KeyTip")
            Me.DescripcionRadLabel.RootElement.Margin = CType(resources.GetObject("DescripcionRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.DescripcionRadLabel.RootElement.Text = resources.GetString("DescripcionRadLabel.RootElement.Text")
            Me.DescripcionRadLabel.RootElement.TextOrientation = CType(resources.GetObject("DescripcionRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.DescripcionRadLabel.RootElement.ToolTipText = resources.GetString("DescripcionRadLabel.RootElement.ToolTipText")
            CType(Me.DescripcionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.DescripcionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text22")
            CType(Me.DescripcionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.DescripcionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ReferenciaRadLabel
            '
            resources.ApplyResources(Me.ReferenciaRadLabel, "ReferenciaRadLabel")
            Me.ReferenciaRadLabel.BorderVisible = True
            Me.ReferenciaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Referencia", True))
            Me.ReferenciaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ReferenciaRadLabel.Name = "ReferenciaRadLabel"
            '
            '
            '
            Me.ReferenciaRadLabel.RootElement.AccessibleDescription = resources.GetString("ReferenciaRadLabel.RootElement.AccessibleDescription")
            Me.ReferenciaRadLabel.RootElement.AccessibleName = resources.GetString("ReferenciaRadLabel.RootElement.AccessibleName")
            Me.ReferenciaRadLabel.RootElement.Alignment = CType(resources.GetObject("ReferenciaRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ReferenciaRadLabel.RootElement.AngleTransform = CType(resources.GetObject("ReferenciaRadLabel.RootElement.AngleTransform"), Single)
            Me.ReferenciaRadLabel.RootElement.FlipText = CType(resources.GetObject("ReferenciaRadLabel.RootElement.FlipText"), Boolean)
            Me.ReferenciaRadLabel.RootElement.KeyTip = resources.GetString("ReferenciaRadLabel.RootElement.KeyTip")
            Me.ReferenciaRadLabel.RootElement.Margin = CType(resources.GetObject("ReferenciaRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ReferenciaRadLabel.RootElement.Text = resources.GetString("ReferenciaRadLabel.RootElement.Text")
            Me.ReferenciaRadLabel.RootElement.TextOrientation = CType(resources.GetObject("ReferenciaRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ReferenciaRadLabel.RootElement.ToolTipText = resources.GetString("ReferenciaRadLabel.RootElement.ToolTipText")
            CType(Me.ReferenciaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ReferenciaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text23")
            CType(Me.ReferenciaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ReferenciaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'pvpOtro
            '
            resources.ApplyResources(Me.pvpOtro, "pvpOtro")
            Me.pvpOtro.Controls.Add(ObservacionLabel)
            Me.pvpOtro.Controls.Add(Me.ObservacionRadLabel)
            Me.pvpOtro.Controls.Add(Me.OfertaVigenteRadLabel)
            Me.pvpOtro.Controls.Add(PrecioVariableLabel)
            Me.pvpOtro.Controls.Add(Me.PrecioVariableRadLabel)
            Me.pvpOtro.Controls.Add(PrecioVentaLabel)
            Me.pvpOtro.Controls.Add(Me.PrecioVentaRadLabel)
            Me.pvpOtro.Controls.Add(PlanOfertaLabel)
            Me.pvpOtro.Controls.Add(Me.PlanOfertaRadLabel)
            Me.pvpOtro.Controls.Add(StockCajaLabel)
            Me.pvpOtro.Controls.Add(Me.StockCajaRadLabel)
            Me.pvpOtro.Controls.Add(StockSueltoLabel)
            Me.pvpOtro.Controls.Add(Me.StockSueltoRadLabel)
            Me.pvpOtro.Controls.Add(UnidadXCajaLabel)
            Me.pvpOtro.Controls.Add(Me.UnidadXCajaRadLabel)
            Me.pvpOtro.Controls.Add(UnidadVentaLabel)
            Me.pvpOtro.Controls.Add(Me.UnidadVentaRadLabel)
            Me.pvpOtro.Controls.Add(CosteLabel)
            Me.pvpOtro.Controls.Add(Me.CosteRadLabel)
            Me.pvpOtro.Controls.Add(Me.ImpuestoLabel)
            Me.pvpOtro.Controls.Add(Me.ImpuestoRadLabel)
            Me.pvpOtro.Controls.Add(DescuentoLabel)
            Me.pvpOtro.Controls.Add(Me.DescuentoRadLabel)
            Me.pvpOtro.ItemSize = New System.Drawing.SizeF(44.0!, 28.0!)
            Me.pvpOtro.Name = "pvpOtro"
            '
            'ObservacionRadLabel
            '
            resources.ApplyResources(Me.ObservacionRadLabel, "ObservacionRadLabel")
            Me.ObservacionRadLabel.BorderVisible = True
            Me.ObservacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Observacion", True))
            Me.ObservacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ObservacionRadLabel.Name = "ObservacionRadLabel"
            '
            '
            '
            Me.ObservacionRadLabel.RootElement.AccessibleDescription = resources.GetString("ObservacionRadLabel.RootElement.AccessibleDescription")
            Me.ObservacionRadLabel.RootElement.AccessibleName = resources.GetString("ObservacionRadLabel.RootElement.AccessibleName")
            Me.ObservacionRadLabel.RootElement.Alignment = CType(resources.GetObject("ObservacionRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ObservacionRadLabel.RootElement.AngleTransform = CType(resources.GetObject("ObservacionRadLabel.RootElement.AngleTransform"), Single)
            Me.ObservacionRadLabel.RootElement.FlipText = CType(resources.GetObject("ObservacionRadLabel.RootElement.FlipText"), Boolean)
            Me.ObservacionRadLabel.RootElement.KeyTip = resources.GetString("ObservacionRadLabel.RootElement.KeyTip")
            Me.ObservacionRadLabel.RootElement.Margin = CType(resources.GetObject("ObservacionRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ObservacionRadLabel.RootElement.Text = resources.GetString("ObservacionRadLabel.RootElement.Text")
            Me.ObservacionRadLabel.RootElement.TextOrientation = CType(resources.GetObject("ObservacionRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ObservacionRadLabel.RootElement.ToolTipText = resources.GetString("ObservacionRadLabel.RootElement.ToolTipText")
            CType(Me.ObservacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ObservacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text24")
            CType(Me.ObservacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ObservacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'OfertaVigenteRadLabel
            '
            resources.ApplyResources(Me.OfertaVigenteRadLabel, "OfertaVigenteRadLabel")
            Me.OfertaVigenteRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.VWProductoBindingSource, "OfertaVigente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.OfertaVigenteRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.OfertaVigenteRadLabel.Name = "OfertaVigenteRadLabel"
            '
            '
            '
            Me.OfertaVigenteRadLabel.RootElement.AccessibleDescription = resources.GetString("OfertaVigenteRadLabel.RootElement.AccessibleDescription")
            Me.OfertaVigenteRadLabel.RootElement.AccessibleName = resources.GetString("OfertaVigenteRadLabel.RootElement.AccessibleName")
            Me.OfertaVigenteRadLabel.RootElement.Alignment = CType(resources.GetObject("OfertaVigenteRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.OfertaVigenteRadLabel.RootElement.AngleTransform = CType(resources.GetObject("OfertaVigenteRadLabel.RootElement.AngleTransform"), Single)
            Me.OfertaVigenteRadLabel.RootElement.FlipText = CType(resources.GetObject("OfertaVigenteRadLabel.RootElement.FlipText"), Boolean)
            Me.OfertaVigenteRadLabel.RootElement.KeyTip = resources.GetString("OfertaVigenteRadLabel.RootElement.KeyTip")
            Me.OfertaVigenteRadLabel.RootElement.Margin = CType(resources.GetObject("OfertaVigenteRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.OfertaVigenteRadLabel.RootElement.Text = resources.GetString("OfertaVigenteRadLabel.RootElement.Text")
            Me.OfertaVigenteRadLabel.RootElement.TextOrientation = CType(resources.GetObject("OfertaVigenteRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.OfertaVigenteRadLabel.RootElement.ToolTipText = resources.GetString("OfertaVigenteRadLabel.RootElement.ToolTipText")
            '
            'PrecioVariableRadLabel
            '
            resources.ApplyResources(Me.PrecioVariableRadLabel, "PrecioVariableRadLabel")
            Me.PrecioVariableRadLabel.BorderVisible = True
            Me.PrecioVariableRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "PrecioVariable", True))
            Me.PrecioVariableRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PrecioVariableRadLabel.Name = "PrecioVariableRadLabel"
            '
            '
            '
            Me.PrecioVariableRadLabel.RootElement.AccessibleDescription = resources.GetString("PrecioVariableRadLabel.RootElement.AccessibleDescription")
            Me.PrecioVariableRadLabel.RootElement.AccessibleName = resources.GetString("PrecioVariableRadLabel.RootElement.AccessibleName")
            Me.PrecioVariableRadLabel.RootElement.Alignment = CType(resources.GetObject("PrecioVariableRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.PrecioVariableRadLabel.RootElement.AngleTransform = CType(resources.GetObject("PrecioVariableRadLabel.RootElement.AngleTransform"), Single)
            Me.PrecioVariableRadLabel.RootElement.FlipText = CType(resources.GetObject("PrecioVariableRadLabel.RootElement.FlipText"), Boolean)
            Me.PrecioVariableRadLabel.RootElement.KeyTip = resources.GetString("PrecioVariableRadLabel.RootElement.KeyTip")
            Me.PrecioVariableRadLabel.RootElement.Margin = CType(resources.GetObject("PrecioVariableRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.PrecioVariableRadLabel.RootElement.Text = resources.GetString("PrecioVariableRadLabel.RootElement.Text")
            Me.PrecioVariableRadLabel.RootElement.TextOrientation = CType(resources.GetObject("PrecioVariableRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.PrecioVariableRadLabel.RootElement.ToolTipText = resources.GetString("PrecioVariableRadLabel.RootElement.ToolTipText")
            CType(Me.PrecioVariableRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.PrecioVariableRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text25")
            CType(Me.PrecioVariableRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.PrecioVariableRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'PrecioVentaRadLabel
            '
            resources.ApplyResources(Me.PrecioVentaRadLabel, "PrecioVentaRadLabel")
            Me.PrecioVentaRadLabel.BorderVisible = True
            Me.PrecioVentaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "PrecioVenta", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
            Me.PrecioVentaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PrecioVentaRadLabel.Name = "PrecioVentaRadLabel"
            '
            '
            '
            Me.PrecioVentaRadLabel.RootElement.AccessibleDescription = resources.GetString("PrecioVentaRadLabel.RootElement.AccessibleDescription")
            Me.PrecioVentaRadLabel.RootElement.AccessibleName = resources.GetString("PrecioVentaRadLabel.RootElement.AccessibleName")
            Me.PrecioVentaRadLabel.RootElement.Alignment = CType(resources.GetObject("PrecioVentaRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.PrecioVentaRadLabel.RootElement.AngleTransform = CType(resources.GetObject("PrecioVentaRadLabel.RootElement.AngleTransform"), Single)
            Me.PrecioVentaRadLabel.RootElement.FlipText = CType(resources.GetObject("PrecioVentaRadLabel.RootElement.FlipText"), Boolean)
            Me.PrecioVentaRadLabel.RootElement.KeyTip = resources.GetString("PrecioVentaRadLabel.RootElement.KeyTip")
            Me.PrecioVentaRadLabel.RootElement.Margin = CType(resources.GetObject("PrecioVentaRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.PrecioVentaRadLabel.RootElement.Text = resources.GetString("PrecioVentaRadLabel.RootElement.Text")
            Me.PrecioVentaRadLabel.RootElement.TextOrientation = CType(resources.GetObject("PrecioVentaRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.PrecioVentaRadLabel.RootElement.ToolTipText = resources.GetString("PrecioVentaRadLabel.RootElement.ToolTipText")
            CType(Me.PrecioVentaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.PrecioVentaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text26")
            CType(Me.PrecioVentaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.PrecioVentaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'PlanOfertaRadLabel
            '
            resources.ApplyResources(Me.PlanOfertaRadLabel, "PlanOfertaRadLabel")
            Me.PlanOfertaRadLabel.BorderVisible = True
            Me.PlanOfertaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "PlanOferta", True))
            Me.PlanOfertaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PlanOfertaRadLabel.Name = "PlanOfertaRadLabel"
            '
            '
            '
            Me.PlanOfertaRadLabel.RootElement.AccessibleDescription = resources.GetString("PlanOfertaRadLabel.RootElement.AccessibleDescription")
            Me.PlanOfertaRadLabel.RootElement.AccessibleName = resources.GetString("PlanOfertaRadLabel.RootElement.AccessibleName")
            Me.PlanOfertaRadLabel.RootElement.Alignment = CType(resources.GetObject("PlanOfertaRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.PlanOfertaRadLabel.RootElement.AngleTransform = CType(resources.GetObject("PlanOfertaRadLabel.RootElement.AngleTransform"), Single)
            Me.PlanOfertaRadLabel.RootElement.FlipText = CType(resources.GetObject("PlanOfertaRadLabel.RootElement.FlipText"), Boolean)
            Me.PlanOfertaRadLabel.RootElement.KeyTip = resources.GetString("PlanOfertaRadLabel.RootElement.KeyTip")
            Me.PlanOfertaRadLabel.RootElement.Margin = CType(resources.GetObject("PlanOfertaRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.PlanOfertaRadLabel.RootElement.Text = resources.GetString("PlanOfertaRadLabel.RootElement.Text")
            Me.PlanOfertaRadLabel.RootElement.TextOrientation = CType(resources.GetObject("PlanOfertaRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.PlanOfertaRadLabel.RootElement.ToolTipText = resources.GetString("PlanOfertaRadLabel.RootElement.ToolTipText")
            CType(Me.PlanOfertaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.PlanOfertaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text27")
            CType(Me.PlanOfertaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.PlanOfertaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'StockCajaRadLabel
            '
            resources.ApplyResources(Me.StockCajaRadLabel, "StockCajaRadLabel")
            Me.StockCajaRadLabel.BorderVisible = True
            Me.StockCajaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "StockCaja", True))
            Me.StockCajaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.StockCajaRadLabel.Name = "StockCajaRadLabel"
            '
            '
            '
            Me.StockCajaRadLabel.RootElement.AccessibleDescription = resources.GetString("StockCajaRadLabel.RootElement.AccessibleDescription")
            Me.StockCajaRadLabel.RootElement.AccessibleName = resources.GetString("StockCajaRadLabel.RootElement.AccessibleName")
            Me.StockCajaRadLabel.RootElement.Alignment = CType(resources.GetObject("StockCajaRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.StockCajaRadLabel.RootElement.AngleTransform = CType(resources.GetObject("StockCajaRadLabel.RootElement.AngleTransform"), Single)
            Me.StockCajaRadLabel.RootElement.FlipText = CType(resources.GetObject("StockCajaRadLabel.RootElement.FlipText"), Boolean)
            Me.StockCajaRadLabel.RootElement.KeyTip = resources.GetString("StockCajaRadLabel.RootElement.KeyTip")
            Me.StockCajaRadLabel.RootElement.Margin = CType(resources.GetObject("StockCajaRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.StockCajaRadLabel.RootElement.Text = resources.GetString("StockCajaRadLabel.RootElement.Text")
            Me.StockCajaRadLabel.RootElement.TextOrientation = CType(resources.GetObject("StockCajaRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.StockCajaRadLabel.RootElement.ToolTipText = resources.GetString("StockCajaRadLabel.RootElement.ToolTipText")
            CType(Me.StockCajaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.StockCajaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text28")
            CType(Me.StockCajaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.StockCajaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'StockSueltoRadLabel
            '
            resources.ApplyResources(Me.StockSueltoRadLabel, "StockSueltoRadLabel")
            Me.StockSueltoRadLabel.BorderVisible = True
            Me.StockSueltoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "StockSuelto", True))
            Me.StockSueltoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.StockSueltoRadLabel.Name = "StockSueltoRadLabel"
            '
            '
            '
            Me.StockSueltoRadLabel.RootElement.AccessibleDescription = resources.GetString("StockSueltoRadLabel.RootElement.AccessibleDescription")
            Me.StockSueltoRadLabel.RootElement.AccessibleName = resources.GetString("StockSueltoRadLabel.RootElement.AccessibleName")
            Me.StockSueltoRadLabel.RootElement.Alignment = CType(resources.GetObject("StockSueltoRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.StockSueltoRadLabel.RootElement.AngleTransform = CType(resources.GetObject("StockSueltoRadLabel.RootElement.AngleTransform"), Single)
            Me.StockSueltoRadLabel.RootElement.FlipText = CType(resources.GetObject("StockSueltoRadLabel.RootElement.FlipText"), Boolean)
            Me.StockSueltoRadLabel.RootElement.KeyTip = resources.GetString("StockSueltoRadLabel.RootElement.KeyTip")
            Me.StockSueltoRadLabel.RootElement.Margin = CType(resources.GetObject("StockSueltoRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.StockSueltoRadLabel.RootElement.Text = resources.GetString("StockSueltoRadLabel.RootElement.Text")
            Me.StockSueltoRadLabel.RootElement.TextOrientation = CType(resources.GetObject("StockSueltoRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.StockSueltoRadLabel.RootElement.ToolTipText = resources.GetString("StockSueltoRadLabel.RootElement.ToolTipText")
            CType(Me.StockSueltoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.StockSueltoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text29")
            CType(Me.StockSueltoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.StockSueltoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'UnidadXCajaRadLabel
            '
            resources.ApplyResources(Me.UnidadXCajaRadLabel, "UnidadXCajaRadLabel")
            Me.UnidadXCajaRadLabel.BorderVisible = True
            Me.UnidadXCajaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "UnidadXCaja", True))
            Me.UnidadXCajaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.UnidadXCajaRadLabel.Name = "UnidadXCajaRadLabel"
            '
            '
            '
            Me.UnidadXCajaRadLabel.RootElement.AccessibleDescription = resources.GetString("UnidadXCajaRadLabel.RootElement.AccessibleDescription")
            Me.UnidadXCajaRadLabel.RootElement.AccessibleName = resources.GetString("UnidadXCajaRadLabel.RootElement.AccessibleName")
            Me.UnidadXCajaRadLabel.RootElement.Alignment = CType(resources.GetObject("UnidadXCajaRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.UnidadXCajaRadLabel.RootElement.AngleTransform = CType(resources.GetObject("UnidadXCajaRadLabel.RootElement.AngleTransform"), Single)
            Me.UnidadXCajaRadLabel.RootElement.FlipText = CType(resources.GetObject("UnidadXCajaRadLabel.RootElement.FlipText"), Boolean)
            Me.UnidadXCajaRadLabel.RootElement.KeyTip = resources.GetString("UnidadXCajaRadLabel.RootElement.KeyTip")
            Me.UnidadXCajaRadLabel.RootElement.Margin = CType(resources.GetObject("UnidadXCajaRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.UnidadXCajaRadLabel.RootElement.Text = resources.GetString("UnidadXCajaRadLabel.RootElement.Text")
            Me.UnidadXCajaRadLabel.RootElement.TextOrientation = CType(resources.GetObject("UnidadXCajaRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.UnidadXCajaRadLabel.RootElement.ToolTipText = resources.GetString("UnidadXCajaRadLabel.RootElement.ToolTipText")
            CType(Me.UnidadXCajaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.UnidadXCajaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text30")
            CType(Me.UnidadXCajaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.UnidadXCajaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'UnidadVentaRadLabel
            '
            resources.ApplyResources(Me.UnidadVentaRadLabel, "UnidadVentaRadLabel")
            Me.UnidadVentaRadLabel.BorderVisible = True
            Me.UnidadVentaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "UnidadVenta", True))
            Me.UnidadVentaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.UnidadVentaRadLabel.Name = "UnidadVentaRadLabel"
            '
            '
            '
            Me.UnidadVentaRadLabel.RootElement.AccessibleDescription = resources.GetString("UnidadVentaRadLabel.RootElement.AccessibleDescription")
            Me.UnidadVentaRadLabel.RootElement.AccessibleName = resources.GetString("UnidadVentaRadLabel.RootElement.AccessibleName")
            Me.UnidadVentaRadLabel.RootElement.Alignment = CType(resources.GetObject("UnidadVentaRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.UnidadVentaRadLabel.RootElement.AngleTransform = CType(resources.GetObject("UnidadVentaRadLabel.RootElement.AngleTransform"), Single)
            Me.UnidadVentaRadLabel.RootElement.FlipText = CType(resources.GetObject("UnidadVentaRadLabel.RootElement.FlipText"), Boolean)
            Me.UnidadVentaRadLabel.RootElement.KeyTip = resources.GetString("UnidadVentaRadLabel.RootElement.KeyTip")
            Me.UnidadVentaRadLabel.RootElement.Margin = CType(resources.GetObject("UnidadVentaRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.UnidadVentaRadLabel.RootElement.Text = resources.GetString("UnidadVentaRadLabel.RootElement.Text")
            Me.UnidadVentaRadLabel.RootElement.TextOrientation = CType(resources.GetObject("UnidadVentaRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.UnidadVentaRadLabel.RootElement.ToolTipText = resources.GetString("UnidadVentaRadLabel.RootElement.ToolTipText")
            CType(Me.UnidadVentaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.UnidadVentaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text31")
            CType(Me.UnidadVentaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.UnidadVentaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'CosteRadLabel
            '
            resources.ApplyResources(Me.CosteRadLabel, "CosteRadLabel")
            Me.CosteRadLabel.BorderVisible = True
            Me.CosteRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Coste", True))
            Me.CosteRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.CosteRadLabel.Name = "CosteRadLabel"
            '
            '
            '
            Me.CosteRadLabel.RootElement.AccessibleDescription = resources.GetString("CosteRadLabel.RootElement.AccessibleDescription")
            Me.CosteRadLabel.RootElement.AccessibleName = resources.GetString("CosteRadLabel.RootElement.AccessibleName")
            Me.CosteRadLabel.RootElement.Alignment = CType(resources.GetObject("CosteRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.CosteRadLabel.RootElement.AngleTransform = CType(resources.GetObject("CosteRadLabel.RootElement.AngleTransform"), Single)
            Me.CosteRadLabel.RootElement.FlipText = CType(resources.GetObject("CosteRadLabel.RootElement.FlipText"), Boolean)
            Me.CosteRadLabel.RootElement.KeyTip = resources.GetString("CosteRadLabel.RootElement.KeyTip")
            Me.CosteRadLabel.RootElement.Margin = CType(resources.GetObject("CosteRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.CosteRadLabel.RootElement.Text = resources.GetString("CosteRadLabel.RootElement.Text")
            Me.CosteRadLabel.RootElement.TextOrientation = CType(resources.GetObject("CosteRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.CosteRadLabel.RootElement.ToolTipText = resources.GetString("CosteRadLabel.RootElement.ToolTipText")
            CType(Me.CosteRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.CosteRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text32")
            CType(Me.CosteRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.CosteRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ImpuestoRadLabel
            '
            resources.ApplyResources(Me.ImpuestoRadLabel, "ImpuestoRadLabel")
            Me.ImpuestoRadLabel.BorderVisible = True
            Me.ImpuestoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Impuesto", True))
            Me.ImpuestoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ImpuestoRadLabel.Name = "ImpuestoRadLabel"
            '
            '
            '
            Me.ImpuestoRadLabel.RootElement.AccessibleDescription = resources.GetString("ImpuestoRadLabel.RootElement.AccessibleDescription")
            Me.ImpuestoRadLabel.RootElement.AccessibleName = resources.GetString("ImpuestoRadLabel.RootElement.AccessibleName")
            Me.ImpuestoRadLabel.RootElement.Alignment = CType(resources.GetObject("ImpuestoRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ImpuestoRadLabel.RootElement.AngleTransform = CType(resources.GetObject("ImpuestoRadLabel.RootElement.AngleTransform"), Single)
            Me.ImpuestoRadLabel.RootElement.FlipText = CType(resources.GetObject("ImpuestoRadLabel.RootElement.FlipText"), Boolean)
            Me.ImpuestoRadLabel.RootElement.KeyTip = resources.GetString("ImpuestoRadLabel.RootElement.KeyTip")
            Me.ImpuestoRadLabel.RootElement.Margin = CType(resources.GetObject("ImpuestoRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ImpuestoRadLabel.RootElement.Text = resources.GetString("ImpuestoRadLabel.RootElement.Text")
            Me.ImpuestoRadLabel.RootElement.TextOrientation = CType(resources.GetObject("ImpuestoRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ImpuestoRadLabel.RootElement.ToolTipText = resources.GetString("ImpuestoRadLabel.RootElement.ToolTipText")
            CType(Me.ImpuestoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ImpuestoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text33")
            CType(Me.ImpuestoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ImpuestoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'DescuentoRadLabel
            '
            resources.ApplyResources(Me.DescuentoRadLabel, "DescuentoRadLabel")
            Me.DescuentoRadLabel.BorderVisible = True
            Me.DescuentoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Descuento", True))
            Me.DescuentoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.DescuentoRadLabel.Name = "DescuentoRadLabel"
            '
            '
            '
            Me.DescuentoRadLabel.RootElement.AccessibleDescription = resources.GetString("DescuentoRadLabel.RootElement.AccessibleDescription")
            Me.DescuentoRadLabel.RootElement.AccessibleName = resources.GetString("DescuentoRadLabel.RootElement.AccessibleName")
            Me.DescuentoRadLabel.RootElement.Alignment = CType(resources.GetObject("DescuentoRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.DescuentoRadLabel.RootElement.AngleTransform = CType(resources.GetObject("DescuentoRadLabel.RootElement.AngleTransform"), Single)
            Me.DescuentoRadLabel.RootElement.FlipText = CType(resources.GetObject("DescuentoRadLabel.RootElement.FlipText"), Boolean)
            Me.DescuentoRadLabel.RootElement.KeyTip = resources.GetString("DescuentoRadLabel.RootElement.KeyTip")
            Me.DescuentoRadLabel.RootElement.Margin = CType(resources.GetObject("DescuentoRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.DescuentoRadLabel.RootElement.Text = resources.GetString("DescuentoRadLabel.RootElement.Text")
            Me.DescuentoRadLabel.RootElement.TextOrientation = CType(resources.GetObject("DescuentoRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.DescuentoRadLabel.RootElement.ToolTipText = resources.GetString("DescuentoRadLabel.RootElement.ToolTipText")
            CType(Me.DescuentoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.DescuentoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text34")
            CType(Me.DescuentoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.DescuentoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'bgwCarga
            '
            Me.bgwCarga.WorkerSupportsCancellation = True
            '
            'FamiliasBindingSource
            '
            Me.FamiliasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Familias)
            '
            'frmProducto
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ChordModifier1.AltModifier = False
            ChordModifier1.ControlModifier = True
            ChordModifier1.ShiftModifier = False
            Chord1.ChordModifier = ChordModifier1
            Chord1.Keys = "Ctrl+A"
            InputBinding1.Chord = Chord1
            InputBinding1.CommandContext = Me.cbbtnAgregar
            Me.CommandBindings.AddRange(New Telerik.WinControls.Keyboard.InputBinding() {InputBinding1})
            Me.Controls.Add(Me.RadSplitContainer1)
            Me.Controls.Add(Me.cbComandos)
            Me.Name = "frmProducto"
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmProducto.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmProducto.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmProducto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmProducto.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmProducto.RootElement.FlipText"), Boolean)
            Me.RootElement.KeyTip = resources.GetString("frmProducto.RootElement.KeyTip")
            Me.RootElement.Margin = CType(resources.GetObject("frmProducto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmProducto.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmProducto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RootElement.ToolTipText = resources.GetString("frmProducto.RootElement.ToolTipText")
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.VWProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer1.ResumeLayout(False)
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel1.ResumeLayout(False)
            CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer2.ResumeLayout(False)
            CType(Me.SplitPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel4.ResumeLayout(False)
            CType(Me.treeFamilia, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitPanel5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel5.ResumeLayout(False)
            CType(Me.lstvOfertas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel2.ResumeLayout(False)
            Me.SplitPanel2.PerformLayout()
            CType(Me.statuInfo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel3.ResumeLayout(False)
            CType(Me.pvInfo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pvInfo.ResumeLayout(False)
            Me.pvpDetalle.ResumeLayout(False)
            Me.pvpDetalle.PerformLayout()
            CType(Me.FModificacionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.VWProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FCreacionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FidelizableRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ActivoRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ControlStockRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MedidaRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UbicacionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FamiliaRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MarcaRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DescripcionCNRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DescripcionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ReferenciaRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pvpOtro.ResumeLayout(False)
            Me.pvpOtro.PerformLayout()
            CType(Me.ObservacionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OfertaVigenteRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PrecioVariableRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PrecioVentaRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PlanOfertaRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StockCajaRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.StockSueltoRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UnidadXCajaRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UnidadVentaRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CosteRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ImpuestoRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DescuentoRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FamiliasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents cbComandos As Telerik.WinControls.UI.RadCommandBar
        Friend WithEvents cbstripeAccion As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents cbbtnAgregar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnEliminar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnModificar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnGaleria As Telerik.WinControls.UI.CommandBarDropDownButton
        Friend WithEvents cbbtnEtiquetar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnCaracteristicas As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents SplitPanel2 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents SplitPanel3 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents pvInfo As Telerik.WinControls.UI.RadPageView
        Friend WithEvents pvpDetalle As Telerik.WinControls.UI.RadPageViewPage
        Friend WithEvents VWProductosBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents pvpOtro As Telerik.WinControls.UI.RadPageViewPage
        Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
        Dim WithEvents gridDatos As Telerik.WinControls.UI.RadGridView
        Friend WithEvents VWProductoBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents statuInfo As Telerik.WinControls.UI.RadStatusStrip
        Friend WithEvents lbleDiagnostico As Telerik.WinControls.UI.RadLabelElement
        Friend WithEvents chkeNoActivos As Telerik.WinControls.UI.RadCheckBoxElement
        Friend WithEvents RadToolStripSeparatorItem1 As Telerik.WinControls.UI.CommandBarSeparator
        Friend WithEvents lblePagina As Telerik.WinControls.UI.RadLabelElement
        Friend WithEvents cbstripeBusqueda As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents bgwCarga As System.ComponentModel.BackgroundWorker
        Friend WithEvents btneAnterior As Telerik.WinControls.UI.RadButtonElement
        Friend WithEvents btneSiguiente As Telerik.WinControls.UI.RadButtonElement
        Friend WithEvents chkePaginar As Telerik.WinControls.UI.RadCheckBoxElement
        Friend WithEvents mitemAdquirirImagen As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents cbstripeOrden As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents ReferenciaRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents SplitPanel1 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents treeFamilia As Telerik.WinControls.UI.RadTreeView
        Friend WithEvents imglFamilia As System.Windows.Forms.ImageList
        Friend WithEvents FamiliasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents RadSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents SplitPanel4 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents SplitPanel5 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents lstvOfertas As Telerik.WinControls.UI.RadListView
        Friend WithEvents DescripcionRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents DescripcionCNRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents MarcaRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents FamiliaRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents UbicacionRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents MedidaRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents ControlStockRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents FModificacionRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents FCreacionRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents ActivoRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents ObservacionRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents DescuentoRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents ImpuestoRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents CosteRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents UnidadVentaRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents UnidadXCajaRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents StockSueltoRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents StockCajaRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents PlanOfertaRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents PrecioVentaRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents PrecioVariableRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents OfertaVigenteRadLabel As Telerik.WinControls.UI.RadLabel
        Private WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
        Friend WithEvents FidelizableRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents ImpuestoLabel As System.Windows.Forms.Label
        Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    End Class

End Namespace

