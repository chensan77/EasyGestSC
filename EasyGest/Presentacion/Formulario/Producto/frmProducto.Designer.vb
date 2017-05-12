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
            Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim ListViewDetailColumn1 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Nº Oferta")
            Dim ListViewDetailColumn2 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Plan")
            Dim InputBinding1 As Telerik.WinControls.Keyboard.InputBinding = New Telerik.WinControls.Keyboard.InputBinding()
            Dim Chord1 As Telerik.WinControls.Keyboard.Chord = New Telerik.WinControls.Keyboard.Chord()
            Dim ChordModifier1 As Telerik.WinControls.Keyboard.ChordModifier = New Telerik.WinControls.Keyboard.ChordModifier()
            Me.cbbtnAgregar = New Telerik.WinControls.UI.CommandBarButton()
            Me.gridDatos = New Telerik.WinControls.UI.RadGridView()
            Me.VWProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
            '
            'gridDatos
            '
            resources.ApplyResources(Me.gridDatos, "gridDatos")
            Me.gridDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDatos.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridDatos.ForeColor = System.Drawing.Color.Black
            '
            '
            '
            Me.gridDatos.MasterTemplate.AllowAddNewRow = False
            Me.gridDatos.MasterTemplate.AllowColumnHeaderContextMenu = False
            Me.gridDatos.MasterTemplate.AllowDeleteRow = False
            Me.gridDatos.MasterTemplate.AllowRowResize = False
            Me.gridDatos.MasterTemplate.AllowSearchRow = True
            Me.gridDatos.MasterTemplate.AutoExpandGroups = True
            Me.gridDatos.MasterTemplate.AutoGenerateColumns = False
            Me.gridDatos.MasterTemplate.Caption = resources.GetString("gridDatos.MasterTemplate.Caption")
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
            Me.gridDatos.MasterTemplate.ViewDefinition = TableViewDefinition1
            Me.gridDatos.Name = "gridDatos"
            Me.gridDatos.ReadOnly = True
            Me.gridDatos.ShowChildViewCaptions = True
            Me.gridDatos.ShowGroupPanel = False
            '
            'VWProductosBindingSource
            '
            Me.VWProductosBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.VWProductos)
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
            '
            'CommandBarSeparator2
            '
            Me.CommandBarSeparator2.AccessibleDescription = "CommandBarSeparator2"
            Me.CommandBarSeparator2.AccessibleName = "CommandBarSeparator2"
            resources.ApplyResources(Me.CommandBarSeparator2, "CommandBarSeparator2")
            Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
            Me.CommandBarSeparator2.VisibleInOverflowMenu = False
            '
            'cbbtnGaleria
            '
            Me.cbbtnGaleria.AccessibleDescription = "Galeria Imagen"
            Me.cbbtnGaleria.AccessibleName = "Galeria Imagen"
            resources.ApplyResources(Me.cbbtnGaleria, "cbbtnGaleria")
            Me.cbbtnGaleria.DrawText = True
            Me.cbbtnGaleria.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnGaleria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnGaleria.Image = Global.EasyGest.My.Resources.Resources._63
            Me.cbbtnGaleria.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemAdquirirImagen})
            Me.cbbtnGaleria.Name = "cbbtnGaleria"
            Me.cbbtnGaleria.ShowHorizontalLine = False
            Me.cbbtnGaleria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'mitemAdquirirImagen
            '
            Me.mitemAdquirirImagen.AccessibleDescription = "Agregar"
            resources.ApplyResources(Me.mitemAdquirirImagen, "mitemAdquirirImagen")
            Me.mitemAdquirirImagen.DescriptionFont = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemAdquirirImagen.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemAdquirirImagen.Image = Global.EasyGest.My.Resources.Resources._112
            Me.mitemAdquirirImagen.Name = "mitemAdquirirImagen"
            '
            'cbbtnCaracteristicas
            '
            Me.cbbtnCaracteristicas.AccessibleDescription = "Características"
            Me.cbbtnCaracteristicas.AccessibleName = "Características"
            resources.ApplyResources(Me.cbbtnCaracteristicas, "cbbtnCaracteristicas")
            Me.cbbtnCaracteristicas.DrawText = True
            Me.cbbtnCaracteristicas.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnCaracteristicas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnCaracteristicas.Image = Global.EasyGest.My.Resources.Resources._43
            Me.cbbtnCaracteristicas.Name = "cbbtnCaracteristicas"
            Me.cbbtnCaracteristicas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
            Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
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
            Me.SplitPanel1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.14657!, 0!)
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
            Me.RadSplitContainer2.RootElement.MinSize = New System.Drawing.Size(0, 0)
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
            Me.SplitPanel4.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel4.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.1694045!)
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
            Me.SplitPanel5.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel5.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.1694045!)
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
            Me.SplitPanel2.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.2650348!, 0!)
            Me.SplitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(263, 0)
            Me.SplitPanel2.TabStop = False
            '
            'statuInfo
            '
            resources.ApplyResources(Me.statuInfo, "statuInfo")
            Me.statuInfo.Items.AddRange(New Telerik.WinControls.RadItem() {Me.btneAnterior, Me.btneSiguiente, Me.lblePagina, Me.RadToolStripSeparatorItem1, Me.lbleDiagnostico, Me.chkeNoActivos, Me.chkePaginar})
            Me.statuInfo.Name = "statuInfo"
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
            '
            'lblePagina
            '
            Me.lblePagina.AccessibleDescription = "RadLabelElement1"
            Me.lblePagina.AccessibleName = "RadLabelElement1"
            resources.ApplyResources(Me.lblePagina, "lblePagina")
            Me.lblePagina.AutoSize = False
            Me.lblePagina.Bounds = New System.Drawing.Rectangle(0, 0, 54, 20)
            Me.lblePagina.Name = "lblePagina"
            Me.statuInfo.SetSpring(Me.lblePagina, False)
            Me.lblePagina.TextWrap = True
            '
            'RadToolStripSeparatorItem1
            '
            Me.RadToolStripSeparatorItem1.AccessibleDescription = "RadToolStripSeparatorItem1"
            Me.RadToolStripSeparatorItem1.AccessibleName = "RadToolStripSeparatorItem1"
            resources.ApplyResources(Me.RadToolStripSeparatorItem1, "RadToolStripSeparatorItem1")
            Me.RadToolStripSeparatorItem1.Name = "RadToolStripSeparatorItem1"
            Me.statuInfo.SetSpring(Me.RadToolStripSeparatorItem1, False)
            Me.RadToolStripSeparatorItem1.VisibleInOverflowMenu = False
            '
            'lbleDiagnostico
            '
            Me.lbleDiagnostico.AccessibleDescription = "Núm. Registro:"
            Me.lbleDiagnostico.AccessibleName = "Núm. Registro:"
            resources.ApplyResources(Me.lbleDiagnostico, "lbleDiagnostico")
            Me.lbleDiagnostico.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbleDiagnostico.Name = "lbleDiagnostico"
            Me.statuInfo.SetSpring(Me.lbleDiagnostico, True)
            Me.lbleDiagnostico.TextWrap = True
            '
            'chkeNoActivos
            '
            resources.ApplyResources(Me.chkeNoActivos, "chkeNoActivos")
            Me.chkeNoActivos.Checked = False
            Me.chkeNoActivos.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkeNoActivos.Name = "chkeNoActivos"
            Me.chkeNoActivos.PositionOffset = New System.Drawing.SizeF(0!, 0!)
            Me.chkeNoActivos.ReadOnly = False
            Me.statuInfo.SetSpring(Me.chkeNoActivos, False)
            '
            'chkePaginar
            '
            resources.ApplyResources(Me.chkePaginar, "chkePaginar")
            Me.chkePaginar.CheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.chkePaginar.Checked = True
            Me.chkePaginar.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkePaginar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkePaginar.Image = Global.EasyGest.My.Resources.Resources.categories
            Me.chkePaginar.Name = "chkePaginar"
            Me.chkePaginar.ReadOnly = False
            Me.statuInfo.SetSpring(Me.chkePaginar, False)
            Me.chkePaginar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.chkePaginar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'SplitPanel3
            '
            resources.ApplyResources(Me.SplitPanel3, "SplitPanel3")
            Me.SplitPanel3.Controls.Add(Me.pvInfo)
            Me.SplitPanel3.Name = "SplitPanel3"
            '
            '
            '
            Me.SplitPanel3.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel3.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.1184648!, 0!)
            Me.SplitPanel3.SizeInfo.SplitterCorrection = New System.Drawing.Size(-101, 0)
            Me.SplitPanel3.TabStop = False
            '
            'pvInfo
            '
            resources.ApplyResources(Me.pvInfo, "pvInfo")
            Me.pvInfo.Controls.Add(Me.pvpDetalle)
            Me.pvInfo.Controls.Add(Me.pvpOtro)
            Me.pvInfo.Name = "pvInfo"
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
            CType(Me.FModificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FModificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text12")
            CType(Me.FModificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FModificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
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
            CType(Me.FCreacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FCreacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text13")
            CType(Me.FCreacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FCreacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.FCreacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'FidelizableRadLabel
            '
            resources.ApplyResources(Me.FidelizableRadLabel, "FidelizableRadLabel")
            Me.FidelizableRadLabel.BorderVisible = True
            Me.FidelizableRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Fidelizable", True))
            Me.FidelizableRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FidelizableRadLabel.Name = "FidelizableRadLabel"
            CType(Me.FidelizableRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FidelizableRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text14")
            CType(Me.FidelizableRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FidelizableRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.FidelizableRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ActivoRadLabel
            '
            resources.ApplyResources(Me.ActivoRadLabel, "ActivoRadLabel")
            Me.ActivoRadLabel.BorderVisible = True
            Me.ActivoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Activo", True))
            Me.ActivoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ActivoRadLabel.Name = "ActivoRadLabel"
            CType(Me.ActivoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ActivoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text15")
            CType(Me.ActivoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ActivoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.ActivoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ControlStockRadLabel
            '
            resources.ApplyResources(Me.ControlStockRadLabel, "ControlStockRadLabel")
            Me.ControlStockRadLabel.BorderVisible = True
            Me.ControlStockRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "ControlStock", True))
            Me.ControlStockRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ControlStockRadLabel.Name = "ControlStockRadLabel"
            CType(Me.ControlStockRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ControlStockRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text16")
            CType(Me.ControlStockRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ControlStockRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.ControlStockRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'MedidaRadLabel
            '
            resources.ApplyResources(Me.MedidaRadLabel, "MedidaRadLabel")
            Me.MedidaRadLabel.BorderVisible = True
            Me.MedidaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Medida", True))
            Me.MedidaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.MedidaRadLabel.Name = "MedidaRadLabel"
            CType(Me.MedidaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.MedidaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text17")
            CType(Me.MedidaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.MedidaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.MedidaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'UbicacionRadLabel
            '
            resources.ApplyResources(Me.UbicacionRadLabel, "UbicacionRadLabel")
            Me.UbicacionRadLabel.BorderVisible = True
            Me.UbicacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Ubicacion", True))
            Me.UbicacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.UbicacionRadLabel.Name = "UbicacionRadLabel"
            CType(Me.UbicacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.UbicacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text18")
            CType(Me.UbicacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.UbicacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.UbicacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'FamiliaRadLabel
            '
            resources.ApplyResources(Me.FamiliaRadLabel, "FamiliaRadLabel")
            Me.FamiliaRadLabel.BorderVisible = True
            Me.FamiliaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Familia", True))
            Me.FamiliaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FamiliaRadLabel.Name = "FamiliaRadLabel"
            CType(Me.FamiliaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FamiliaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text19")
            CType(Me.FamiliaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FamiliaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.FamiliaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'MarcaRadLabel
            '
            resources.ApplyResources(Me.MarcaRadLabel, "MarcaRadLabel")
            Me.MarcaRadLabel.BorderVisible = True
            Me.MarcaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Marca", True))
            Me.MarcaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.MarcaRadLabel.Name = "MarcaRadLabel"
            CType(Me.MarcaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.MarcaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text20")
            CType(Me.MarcaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.MarcaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.MarcaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'DescripcionCNRadLabel
            '
            resources.ApplyResources(Me.DescripcionCNRadLabel, "DescripcionCNRadLabel")
            Me.DescripcionCNRadLabel.BorderVisible = True
            Me.DescripcionCNRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "DescripcionLarga", True))
            Me.DescripcionCNRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.DescripcionCNRadLabel.Name = "DescripcionCNRadLabel"
            CType(Me.DescripcionCNRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.DescripcionCNRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text21")
            CType(Me.DescripcionCNRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.DescripcionCNRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.DescripcionCNRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'DescripcionRadLabel
            '
            resources.ApplyResources(Me.DescripcionRadLabel, "DescripcionRadLabel")
            Me.DescripcionRadLabel.BorderVisible = True
            Me.DescripcionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Descripcion", True))
            Me.DescripcionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.DescripcionRadLabel.Name = "DescripcionRadLabel"
            CType(Me.DescripcionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.DescripcionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text22")
            CType(Me.DescripcionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.DescripcionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.DescripcionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ReferenciaRadLabel
            '
            resources.ApplyResources(Me.ReferenciaRadLabel, "ReferenciaRadLabel")
            Me.ReferenciaRadLabel.BorderVisible = True
            Me.ReferenciaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Referencia", True))
            Me.ReferenciaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ReferenciaRadLabel.Name = "ReferenciaRadLabel"
            CType(Me.ReferenciaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ReferenciaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text23")
            CType(Me.ReferenciaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ReferenciaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
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
            CType(Me.ObservacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ObservacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text24")
            CType(Me.ObservacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ObservacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.ObservacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'OfertaVigenteRadLabel
            '
            resources.ApplyResources(Me.OfertaVigenteRadLabel, "OfertaVigenteRadLabel")
            Me.OfertaVigenteRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Visible", Me.VWProductoBindingSource, "OfertaVigente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.OfertaVigenteRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.OfertaVigenteRadLabel.Name = "OfertaVigenteRadLabel"
            '
            'PrecioVariableRadLabel
            '
            resources.ApplyResources(Me.PrecioVariableRadLabel, "PrecioVariableRadLabel")
            Me.PrecioVariableRadLabel.BorderVisible = True
            Me.PrecioVariableRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "PrecioVariable", True))
            Me.PrecioVariableRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PrecioVariableRadLabel.Name = "PrecioVariableRadLabel"
            CType(Me.PrecioVariableRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.PrecioVariableRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text25")
            CType(Me.PrecioVariableRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.PrecioVariableRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.PrecioVariableRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'PrecioVentaRadLabel
            '
            resources.ApplyResources(Me.PrecioVentaRadLabel, "PrecioVentaRadLabel")
            Me.PrecioVentaRadLabel.BorderVisible = True
            Me.PrecioVentaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "PrecioVenta", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
            Me.PrecioVentaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PrecioVentaRadLabel.Name = "PrecioVentaRadLabel"
            CType(Me.PrecioVentaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.PrecioVentaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text26")
            CType(Me.PrecioVentaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.PrecioVentaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.PrecioVentaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'PlanOfertaRadLabel
            '
            resources.ApplyResources(Me.PlanOfertaRadLabel, "PlanOfertaRadLabel")
            Me.PlanOfertaRadLabel.BorderVisible = True
            Me.PlanOfertaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "PlanOferta", True))
            Me.PlanOfertaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PlanOfertaRadLabel.Name = "PlanOfertaRadLabel"
            CType(Me.PlanOfertaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.PlanOfertaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text27")
            CType(Me.PlanOfertaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.PlanOfertaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.PlanOfertaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'StockCajaRadLabel
            '
            resources.ApplyResources(Me.StockCajaRadLabel, "StockCajaRadLabel")
            Me.StockCajaRadLabel.BorderVisible = True
            Me.StockCajaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "StockCaja", True))
            Me.StockCajaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.StockCajaRadLabel.Name = "StockCajaRadLabel"
            CType(Me.StockCajaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.StockCajaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text28")
            CType(Me.StockCajaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.StockCajaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.StockCajaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'StockSueltoRadLabel
            '
            resources.ApplyResources(Me.StockSueltoRadLabel, "StockSueltoRadLabel")
            Me.StockSueltoRadLabel.BorderVisible = True
            Me.StockSueltoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "StockSuelto", True))
            Me.StockSueltoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.StockSueltoRadLabel.Name = "StockSueltoRadLabel"
            CType(Me.StockSueltoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.StockSueltoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text29")
            CType(Me.StockSueltoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.StockSueltoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.StockSueltoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'UnidadXCajaRadLabel
            '
            resources.ApplyResources(Me.UnidadXCajaRadLabel, "UnidadXCajaRadLabel")
            Me.UnidadXCajaRadLabel.BorderVisible = True
            Me.UnidadXCajaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "UnidadXCaja", True))
            Me.UnidadXCajaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.UnidadXCajaRadLabel.Name = "UnidadXCajaRadLabel"
            CType(Me.UnidadXCajaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.UnidadXCajaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text30")
            CType(Me.UnidadXCajaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.UnidadXCajaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.UnidadXCajaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'UnidadVentaRadLabel
            '
            resources.ApplyResources(Me.UnidadVentaRadLabel, "UnidadVentaRadLabel")
            Me.UnidadVentaRadLabel.BorderVisible = True
            Me.UnidadVentaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "UnidadVenta", True))
            Me.UnidadVentaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.UnidadVentaRadLabel.Name = "UnidadVentaRadLabel"
            CType(Me.UnidadVentaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.UnidadVentaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text31")
            CType(Me.UnidadVentaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.UnidadVentaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.UnidadVentaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'CosteRadLabel
            '
            resources.ApplyResources(Me.CosteRadLabel, "CosteRadLabel")
            Me.CosteRadLabel.BorderVisible = True
            Me.CosteRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Coste", True))
            Me.CosteRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.CosteRadLabel.Name = "CosteRadLabel"
            CType(Me.CosteRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.CosteRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text32")
            CType(Me.CosteRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.CosteRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.CosteRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ImpuestoRadLabel
            '
            resources.ApplyResources(Me.ImpuestoRadLabel, "ImpuestoRadLabel")
            Me.ImpuestoRadLabel.BorderVisible = True
            Me.ImpuestoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Impuesto", True))
            Me.ImpuestoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ImpuestoRadLabel.Name = "ImpuestoRadLabel"
            CType(Me.ImpuestoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ImpuestoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text33")
            CType(Me.ImpuestoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ImpuestoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.ImpuestoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'DescuentoRadLabel
            '
            resources.ApplyResources(Me.DescuentoRadLabel, "DescuentoRadLabel")
            Me.DescuentoRadLabel.BorderVisible = True
            Me.DescuentoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProductoBindingSource, "Descuento", True))
            Me.DescuentoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.DescuentoRadLabel.Name = "DescuentoRadLabel"
            CType(Me.DescuentoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.DescuentoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text34")
            CType(Me.DescuentoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.DescuentoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
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
            Me.RootElement.ApplyShapeToControl = True
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

