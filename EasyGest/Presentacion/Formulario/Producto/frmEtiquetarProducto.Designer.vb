Namespace Presentacion.Formulario.Producto

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmEtiquetarProducto
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtiquetarProducto))
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
            Dim InputBinding1 As Telerik.WinControls.Keyboard.InputBinding = New Telerik.WinControls.Keyboard.InputBinding()
            Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.SplitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.gridDatos = New Telerik.WinControls.UI.RadGridView()
            Me.VWProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
            Me.cbBuscarProducto = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.cbstripeBusqueda = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.SplitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.RadSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.SplitPanel3 = New Telerik.WinControls.UI.SplitPanel()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            Me.SplitPanel4 = New Telerik.WinControls.UI.SplitPanel()
            Me.lstvEtiquetas = New Telerik.WinControls.UI.RadListView()
            Me.bgwCarga = New System.ComponentModel.BackgroundWorker()
            Me.cbstripeAccion = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbbtnAgregar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnEliminar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnModificar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbComandos = New Telerik.WinControls.UI.RadCommandBar()
            Me.EtiquetasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer1.SuspendLayout()
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel1.SuspendLayout()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.VWProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel2.SuspendLayout()
            CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer2.SuspendLayout()
            CType(Me.SplitPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel3.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadPanel1.SuspendLayout()
            CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel4.SuspendLayout()
            CType(Me.lstvEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EtiquetasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'RadSplitContainer1
            '
            Me.RadSplitContainer1.Controls.Add(Me.SplitPanel1)
            Me.RadSplitContainer1.Controls.Add(Me.SplitPanel2)
            resources.ApplyResources(Me.RadSplitContainer1, "RadSplitContainer1")
            Me.RadSplitContainer1.Name = "RadSplitContainer1"
            '
            '
            '
            Me.RadSplitContainer1.RootElement.AccessibleDescription = resources.GetString("RadSplitContainer1.RootElement.AccessibleDescription")
            Me.RadSplitContainer1.RootElement.AccessibleName = resources.GetString("RadSplitContainer1.RootElement.AccessibleName")
            Me.RadSplitContainer1.RootElement.Alignment = CType(resources.GetObject("RadSplitContainer1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadSplitContainer1.RootElement.AngleTransform = CType(resources.GetObject("RadSplitContainer1.RootElement.AngleTransform"), Single)
            Me.RadSplitContainer1.RootElement.FlipText = CType(resources.GetObject("RadSplitContainer1.RootElement.FlipText"), Boolean)
            Me.RadSplitContainer1.RootElement.Margin = CType(resources.GetObject("RadSplitContainer1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.RadSplitContainer1.RootElement.Padding = CType(resources.GetObject("RadSplitContainer1.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadSplitContainer1.RootElement.Text = resources.GetString("RadSplitContainer1.RootElement.Text")
            Me.RadSplitContainer1.RootElement.TextOrientation = CType(resources.GetObject("RadSplitContainer1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadSplitContainer1.SplitterWidth = 4
            Me.RadSplitContainer1.TabStop = False
            '
            'SplitPanel1
            '
            Me.SplitPanel1.Controls.Add(Me.gridDatos)
            Me.SplitPanel1.Controls.Add(Me.RadCommandBar1)
            resources.ApplyResources(Me.SplitPanel1, "SplitPanel1")
            Me.SplitPanel1.Name = "SplitPanel1"
            '
            '
            '
            Me.SplitPanel1.RootElement.AccessibleDescription = resources.GetString("SplitPanel1.RootElement.AccessibleDescription")
            Me.SplitPanel1.RootElement.AccessibleName = resources.GetString("SplitPanel1.RootElement.AccessibleName")
            Me.SplitPanel1.RootElement.Alignment = CType(resources.GetObject("SplitPanel1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel1.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel1.RootElement.AngleTransform"), Single)
            Me.SplitPanel1.RootElement.FlipText = CType(resources.GetObject("SplitPanel1.RootElement.FlipText"), Boolean)
            Me.SplitPanel1.RootElement.Margin = CType(resources.GetObject("SplitPanel1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.SplitPanel1.RootElement.Padding = CType(resources.GetObject("SplitPanel1.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.SplitPanel1.RootElement.Text = resources.GetString("SplitPanel1.RootElement.Text")
            Me.SplitPanel1.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.08036676!, 0.0!)
            Me.SplitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-117, 0)
            Me.SplitPanel1.TabStop = False
            '
            'gridDatos
            '
            Me.gridDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDatos.Cursor = System.Windows.Forms.Cursors.Default
            resources.ApplyResources(Me.gridDatos, "gridDatos")
            Me.gridDatos.ForeColor = System.Drawing.Color.Black
            '
            'gridDatos
            '
            Me.gridDatos.MasterTemplate.AllowAddNewRow = False
            Me.gridDatos.MasterTemplate.AllowColumnHeaderContextMenu = False
            Me.gridDatos.MasterTemplate.AllowDeleteRow = False
            Me.gridDatos.MasterTemplate.AllowRowResize = False
            Me.gridDatos.MasterTemplate.AutoExpandGroups = True
            Me.gridDatos.MasterTemplate.AutoGenerateColumns = False
            GridViewTextBoxColumn1.AllowGroup = False
            GridViewTextBoxColumn1.EnableExpressionEditor = False
            GridViewTextBoxColumn1.FieldName = "Referencia"
            resources.ApplyResources(GridViewTextBoxColumn1, "GridViewTextBoxColumn1")
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.IsPinned = True
            GridViewTextBoxColumn1.Name = "Referencia"
            GridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewTextBoxColumn1.ReadOnly = True
            GridViewTextBoxColumn1.Width = 133
            GridViewTextBoxColumn2.AllowGroup = False
            GridViewTextBoxColumn2.EnableExpressionEditor = False
            GridViewTextBoxColumn2.FieldName = "Descripcion"
            resources.ApplyResources(GridViewTextBoxColumn2, "GridViewTextBoxColumn2")
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.IsPinned = True
            GridViewTextBoxColumn2.Name = "Descripcion"
            GridViewTextBoxColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewTextBoxColumn2.ReadOnly = True
            GridViewTextBoxColumn2.Width = 264
            GridViewDecimalColumn1.AllowGroup = False
            GridViewDecimalColumn1.DataType = GetType(Single)
            GridViewDecimalColumn1.EnableExpressionEditor = False
            GridViewDecimalColumn1.FieldName = "PrecioVenta"
            resources.ApplyResources(GridViewDecimalColumn1, "GridViewDecimalColumn1")
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.Name = "PrecioVenta"
            GridViewDecimalColumn1.ReadOnly = True
            GridViewDecimalColumn1.Width = 108
            GridViewDecimalColumn2.AllowFiltering = False
            GridViewDecimalColumn2.AllowGroup = False
            GridViewDecimalColumn2.DataType = GetType(System.Nullable(Of Single))
            GridViewDecimalColumn2.EnableExpressionEditor = False
            GridViewDecimalColumn2.FieldName = "StockSuelto"
            resources.ApplyResources(GridViewDecimalColumn2, "GridViewDecimalColumn2")
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.Name = "StockSuelto"
            GridViewDecimalColumn2.ReadOnly = True
            GridViewDecimalColumn2.Width = 82
            GridViewTextBoxColumn3.EnableExpressionEditor = False
            GridViewTextBoxColumn3.FieldName = "Marca"
            resources.ApplyResources(GridViewTextBoxColumn3, "GridViewTextBoxColumn3")
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.Name = "Marca"
            GridViewTextBoxColumn3.Width = 120
            GridViewTextBoxColumn4.EnableExpressionEditor = False
            GridViewTextBoxColumn4.FieldName = "Familia"
            resources.ApplyResources(GridViewTextBoxColumn4, "GridViewTextBoxColumn4")
            GridViewTextBoxColumn4.IsAutoGenerated = True
            GridViewTextBoxColumn4.Name = "Familia"
            GridViewTextBoxColumn4.ReadOnly = True
            GridViewTextBoxColumn4.Width = 124
            GridViewTextBoxColumn5.EnableExpressionEditor = False
            GridViewTextBoxColumn5.FieldName = "Ubicacion"
            resources.ApplyResources(GridViewTextBoxColumn5, "GridViewTextBoxColumn5")
            GridViewTextBoxColumn5.IsAutoGenerated = True
            GridViewTextBoxColumn5.Name = "Ubicacion"
            GridViewTextBoxColumn5.ReadOnly = True
            GridViewTextBoxColumn5.Width = 128
            Me.gridDatos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewDecimalColumn1, GridViewDecimalColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5})
            Me.gridDatos.MasterTemplate.DataSource = Me.VWProductosBindingSource
            Me.gridDatos.MasterTemplate.EnableAlternatingRowColor = True
            Me.gridDatos.MasterTemplate.EnableFiltering = True
            Me.gridDatos.MasterTemplate.EnableGrouping = False
            Me.gridDatos.MasterTemplate.MultiSelect = True
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
            Me.gridDatos.RootElement.Margin = CType(resources.GetObject("gridDatos.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.gridDatos.RootElement.Padding = CType(resources.GetObject("gridDatos.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.gridDatos.RootElement.Text = resources.GetString("gridDatos.RootElement.Text")
            Me.gridDatos.RootElement.TextOrientation = CType(resources.GetObject("gridDatos.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.gridDatos.ShowGroupPanel = False
            '
            'VWProductosBindingSource
            '
            Me.VWProductosBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.VWProductos)
            '
            'RadCommandBar1
            '
            resources.ApplyResources(Me.RadCommandBar1, "RadCommandBar1")
            Me.RadCommandBar1.Name = "RadCommandBar1"
            '
            '
            '
            Me.RadCommandBar1.RootElement.AccessibleDescription = resources.GetString("RadCommandBar1.RootElement.AccessibleDescription")
            Me.RadCommandBar1.RootElement.AccessibleName = resources.GetString("RadCommandBar1.RootElement.AccessibleName")
            Me.RadCommandBar1.RootElement.Alignment = CType(resources.GetObject("RadCommandBar1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadCommandBar1.RootElement.AngleTransform = CType(resources.GetObject("RadCommandBar1.RootElement.AngleTransform"), Single)
            Me.RadCommandBar1.RootElement.FlipText = CType(resources.GetObject("RadCommandBar1.RootElement.FlipText"), Boolean)
            Me.RadCommandBar1.RootElement.Margin = CType(resources.GetObject("RadCommandBar1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadCommandBar1.RootElement.Padding = CType(resources.GetObject("RadCommandBar1.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadCommandBar1.RootElement.Text = resources.GetString("RadCommandBar1.RootElement.Text")
            Me.RadCommandBar1.RootElement.TextOrientation = CType(resources.GetObject("RadCommandBar1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.cbBuscarProducto})
            '
            'cbBuscarProducto
            '
            resources.ApplyResources(Me.cbBuscarProducto, "cbBuscarProducto")
            Me.cbBuscarProducto.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbBuscarProducto.MinSize = New System.Drawing.Size(25, 25)
            Me.cbBuscarProducto.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.cbstripeBusqueda})
            '
            'cbstripeBusqueda
            '
            resources.ApplyResources(Me.cbstripeBusqueda, "cbstripeBusqueda")
            Me.cbstripeBusqueda.DisplayName = "Ordenación"
            Me.cbstripeBusqueda.Name = "cbstripeOrden"
            '
            'SplitPanel2
            '
            Me.SplitPanel2.Controls.Add(Me.RadSplitContainer2)
            resources.ApplyResources(Me.SplitPanel2, "SplitPanel2")
            Me.SplitPanel2.Name = "SplitPanel2"
            '
            '
            '
            Me.SplitPanel2.RootElement.AccessibleDescription = resources.GetString("SplitPanel2.RootElement.AccessibleDescription")
            Me.SplitPanel2.RootElement.AccessibleName = resources.GetString("SplitPanel2.RootElement.AccessibleName")
            Me.SplitPanel2.RootElement.Alignment = CType(resources.GetObject("SplitPanel2.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel2.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel2.RootElement.AngleTransform"), Single)
            Me.SplitPanel2.RootElement.FlipText = CType(resources.GetObject("SplitPanel2.RootElement.FlipText"), Boolean)
            Me.SplitPanel2.RootElement.Margin = CType(resources.GetObject("SplitPanel2.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel2.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.SplitPanel2.RootElement.Padding = CType(resources.GetObject("SplitPanel2.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.SplitPanel2.RootElement.Text = resources.GetString("SplitPanel2.RootElement.Text")
            Me.SplitPanel2.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.08036679!, 0.0!)
            Me.SplitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(-73, 0)
            Me.SplitPanel2.TabStop = False
            '
            'RadSplitContainer2
            '
            Me.RadSplitContainer2.Controls.Add(Me.SplitPanel3)
            Me.RadSplitContainer2.Controls.Add(Me.SplitPanel4)
            resources.ApplyResources(Me.RadSplitContainer2, "RadSplitContainer2")
            Me.RadSplitContainer2.Name = "RadSplitContainer2"
            '
            '
            '
            Me.RadSplitContainer2.RootElement.AccessibleDescription = resources.GetString("RadSplitContainer2.RootElement.AccessibleDescription")
            Me.RadSplitContainer2.RootElement.AccessibleName = resources.GetString("RadSplitContainer2.RootElement.AccessibleName")
            Me.RadSplitContainer2.RootElement.Alignment = CType(resources.GetObject("RadSplitContainer2.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadSplitContainer2.RootElement.AngleTransform = CType(resources.GetObject("RadSplitContainer2.RootElement.AngleTransform"), Single)
            Me.RadSplitContainer2.RootElement.FlipText = CType(resources.GetObject("RadSplitContainer2.RootElement.FlipText"), Boolean)
            Me.RadSplitContainer2.RootElement.Margin = CType(resources.GetObject("RadSplitContainer2.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadSplitContainer2.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.RadSplitContainer2.RootElement.Padding = CType(resources.GetObject("RadSplitContainer2.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadSplitContainer2.RootElement.Text = resources.GetString("RadSplitContainer2.RootElement.Text")
            Me.RadSplitContainer2.RootElement.TextOrientation = CType(resources.GetObject("RadSplitContainer2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadSplitContainer2.SplitterWidth = 4
            Me.RadSplitContainer2.TabStop = False
            '
            'SplitPanel3
            '
            Me.SplitPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.SplitPanel3.Controls.Add(Me.TableLayoutPanel1)
            resources.ApplyResources(Me.SplitPanel3, "SplitPanel3")
            Me.SplitPanel3.Name = "SplitPanel3"
            '
            '
            '
            Me.SplitPanel3.RootElement.AccessibleDescription = resources.GetString("SplitPanel3.RootElement.AccessibleDescription")
            Me.SplitPanel3.RootElement.AccessibleName = resources.GetString("SplitPanel3.RootElement.AccessibleName")
            Me.SplitPanel3.RootElement.Alignment = CType(resources.GetObject("SplitPanel3.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel3.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel3.RootElement.AngleTransform"), Single)
            Me.SplitPanel3.RootElement.FlipText = CType(resources.GetObject("SplitPanel3.RootElement.FlipText"), Boolean)
            Me.SplitPanel3.RootElement.Margin = CType(resources.GetObject("SplitPanel3.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel3.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.SplitPanel3.RootElement.Padding = CType(resources.GetObject("SplitPanel3.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.SplitPanel3.RootElement.Text = resources.GetString("SplitPanel3.RootElement.Text")
            Me.SplitPanel3.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel3.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel3.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.0!, 0.3142857!)
            Me.SplitPanel3.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 109)
            Me.SplitPanel3.TabStop = False
            '
            'TableLayoutPanel1
            '
            resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
            Me.TableLayoutPanel1.Controls.Add(Me.RadPanel1, 0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            '
            'RadPanel1
            '
            Me.RadPanel1.Controls.Add(Me.RadLabel1)
            resources.ApplyResources(Me.RadPanel1, "RadPanel1")
            Me.RadPanel1.Name = "RadPanel1"
            '
            '
            '
            Me.RadPanel1.RootElement.AccessibleDescription = resources.GetString("RadPanel1.RootElement.AccessibleDescription")
            Me.RadPanel1.RootElement.AccessibleName = resources.GetString("RadPanel1.RootElement.AccessibleName")
            Me.RadPanel1.RootElement.Alignment = CType(resources.GetObject("RadPanel1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadPanel1.RootElement.AngleTransform = CType(resources.GetObject("RadPanel1.RootElement.AngleTransform"), Single)
            Me.RadPanel1.RootElement.FlipText = CType(resources.GetObject("RadPanel1.RootElement.FlipText"), Boolean)
            Me.RadPanel1.RootElement.Margin = CType(resources.GetObject("RadPanel1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadPanel1.RootElement.Padding = CType(resources.GetObject("RadPanel1.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadPanel1.RootElement.Text = resources.GetString("RadPanel1.RootElement.Text")
            Me.RadPanel1.RootElement.TextOrientation = CType(resources.GetObject("RadPanel1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel1
            '
            resources.ApplyResources(Me.RadLabel1, "RadLabel1")
            Me.RadLabel1.BackColor = System.Drawing.Color.White
            Me.RadLabel1.BorderVisible = True
            Me.RadLabel1.Name = "RadLabel1"
            '
            '
            '
            Me.RadLabel1.RootElement.AccessibleDescription = resources.GetString("RadLabel1.RootElement.AccessibleDescription")
            Me.RadLabel1.RootElement.AccessibleName = resources.GetString("RadLabel1.RootElement.AccessibleName")
            Me.RadLabel1.RootElement.Alignment = CType(resources.GetObject("RadLabel1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadLabel1.RootElement.AngleTransform = CType(resources.GetObject("RadLabel1.RootElement.AngleTransform"), Single)
            Me.RadLabel1.RootElement.FlipText = CType(resources.GetObject("RadLabel1.RootElement.FlipText"), Boolean)
            Me.RadLabel1.RootElement.Margin = CType(resources.GetObject("RadLabel1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadLabel1.RootElement.Padding = CType(resources.GetObject("RadLabel1.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadLabel1.RootElement.Text = resources.GetString("RadLabel1.RootElement.Text")
            Me.RadLabel1.RootElement.TextOrientation = CType(resources.GetObject("RadLabel1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'SplitPanel4
            '
            Me.SplitPanel4.Controls.Add(Me.lstvEtiquetas)
            resources.ApplyResources(Me.SplitPanel4, "SplitPanel4")
            Me.SplitPanel4.Name = "SplitPanel4"
            '
            '
            '
            Me.SplitPanel4.RootElement.AccessibleDescription = resources.GetString("SplitPanel4.RootElement.AccessibleDescription")
            Me.SplitPanel4.RootElement.AccessibleName = resources.GetString("SplitPanel4.RootElement.AccessibleName")
            Me.SplitPanel4.RootElement.Alignment = CType(resources.GetObject("SplitPanel4.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel4.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel4.RootElement.AngleTransform"), Single)
            Me.SplitPanel4.RootElement.FlipText = CType(resources.GetObject("SplitPanel4.RootElement.FlipText"), Boolean)
            Me.SplitPanel4.RootElement.Margin = CType(resources.GetObject("SplitPanel4.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel4.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.SplitPanel4.RootElement.Padding = CType(resources.GetObject("SplitPanel4.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.SplitPanel4.RootElement.Text = resources.GetString("SplitPanel4.RootElement.Text")
            Me.SplitPanel4.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel4.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel4.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.0!, -0.3142857!)
            Me.SplitPanel4.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -109)
            Me.SplitPanel4.TabStop = False
            '
            'lstvEtiquetas
            '
            Me.lstvEtiquetas.DisplayMember = "NombreEtiqueta"
            resources.ApplyResources(Me.lstvEtiquetas, "lstvEtiquetas")
            Me.lstvEtiquetas.FullRowSelect = False
            Me.lstvEtiquetas.ItemSize = New System.Drawing.Size(75, 80)
            Me.lstvEtiquetas.ItemSpacing = 5
            Me.lstvEtiquetas.Name = "lstvEtiquetas"
            '
            '
            '
            Me.lstvEtiquetas.RootElement.AccessibleDescription = resources.GetString("lstvEtiquetas.RootElement.AccessibleDescription")
            Me.lstvEtiquetas.RootElement.AccessibleName = resources.GetString("lstvEtiquetas.RootElement.AccessibleName")
            Me.lstvEtiquetas.RootElement.Alignment = CType(resources.GetObject("lstvEtiquetas.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lstvEtiquetas.RootElement.AngleTransform = CType(resources.GetObject("lstvEtiquetas.RootElement.AngleTransform"), Single)
            Me.lstvEtiquetas.RootElement.FlipText = CType(resources.GetObject("lstvEtiquetas.RootElement.FlipText"), Boolean)
            Me.lstvEtiquetas.RootElement.Margin = CType(resources.GetObject("lstvEtiquetas.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lstvEtiquetas.RootElement.Padding = CType(resources.GetObject("lstvEtiquetas.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.lstvEtiquetas.RootElement.Text = resources.GetString("lstvEtiquetas.RootElement.Text")
            Me.lstvEtiquetas.RootElement.TextOrientation = CType(resources.GetObject("lstvEtiquetas.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.lstvEtiquetas.ShowColumnHeaders = False
            Me.lstvEtiquetas.ViewType = Telerik.WinControls.UI.ListViewType.IconsView
            '
            'bgwCarga
            '
            Me.bgwCarga.WorkerSupportsCancellation = True
            '
            'CommandBarRowElement1
            '
            resources.ApplyResources(CommandBarRowElement1, "CommandBarRowElement1")
            CommandBarRowElement1.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            CommandBarRowElement1.BorderLeftShadowColor = System.Drawing.Color.Empty
            CommandBarRowElement1.DisplayName = Nothing
            CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
            CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.cbstripeAccion})
            '
            'cbstripeAccion
            '
            resources.ApplyResources(Me.cbstripeAccion, "cbstripeAccion")
            Me.cbstripeAccion.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.cbstripeAccion.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.cbstripeAccion.DisplayName = "Operación"
            Me.cbstripeAccion.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbtnAgregar, Me.cbbtnEliminar, Me.cbbtnModificar})
            Me.cbstripeAccion.Name = "CommandBarStripElement1"
            '
            'cbbtnAgregar
            '
            resources.ApplyResources(Me.cbbtnAgregar, "cbbtnAgregar")
            Me.cbbtnAgregar.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders
            Me.cbbtnAgregar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(106, Byte), Integer))
            Me.cbbtnAgregar.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.cbbtnAgregar.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.cbbtnAgregar.DisplayName = "Agregar"
            Me.cbbtnAgregar.DrawText = True
            Me.cbbtnAgregar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.cbbtnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnAgregar.Image = Global.EasyGest.My.Resources.Resources._127
            Me.cbbtnAgregar.Name = "cbbtnAgregar"
            Me.cbbtnAgregar.Shape = Nothing
            Me.cbbtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnAgregar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbbtnEliminar
            '
            resources.ApplyResources(Me.cbbtnEliminar, "cbbtnEliminar")
            Me.cbbtnEliminar.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.cbbtnEliminar.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.cbbtnEliminar.DisplayName = "Eliminar"
            Me.cbbtnEliminar.DrawText = True
            Me.cbbtnEliminar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.cbbtnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnEliminar.Image = Global.EasyGest.My.Resources.Resources._128
            Me.cbbtnEliminar.Name = "cbbtnEliminar"
            Me.cbbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnEliminar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbbtnModificar
            '
            resources.ApplyResources(Me.cbbtnModificar, "cbbtnModificar")
            Me.cbbtnModificar.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.cbbtnModificar.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.cbbtnModificar.DisplayName = "Modificar"
            Me.cbbtnModificar.DrawText = True
            Me.cbbtnModificar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.cbbtnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnModificar.Image = Global.EasyGest.My.Resources.Resources._130
            Me.cbbtnModificar.Name = "cbbtnModificar"
            Me.cbbtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnModificar.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
            Me.cbComandos.RootElement.Margin = CType(resources.GetObject("cbComandos.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.cbComandos.RootElement.Padding = CType(resources.GetObject("cbComandos.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.cbComandos.RootElement.Text = resources.GetString("cbComandos.RootElement.Text")
            Me.cbComandos.RootElement.TextOrientation = CType(resources.GetObject("cbComandos.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.cbComandos.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {CommandBarRowElement1})
            '
            'EtiquetasBindingSource
            '
            Me.EtiquetasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Etiquetas)
            '
            'frmEtiquetarProducto
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            InputBinding1.Chord = Nothing
            Me.CommandBindings.AddRange(New Telerik.WinControls.Keyboard.InputBinding() {InputBinding1})
            Me.Controls.Add(Me.RadSplitContainer1)
            Me.Controls.Add(Me.cbComandos)
            Me.Name = "frmEtiquetarProducto"
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmEtiquetarProducto.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmEtiquetarProducto.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmEtiquetarProducto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmEtiquetarProducto.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmEtiquetarProducto.RootElement.FlipText"), Boolean)
            Me.RootElement.Margin = CType(resources.GetObject("frmEtiquetarProducto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmEtiquetarProducto.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmEtiquetarProducto.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmEtiquetarProducto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer1.ResumeLayout(False)
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel1.ResumeLayout(False)
            Me.SplitPanel1.PerformLayout()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.VWProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel2.ResumeLayout(False)
            CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer2.ResumeLayout(False)
            CType(Me.SplitPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel3.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadPanel1.ResumeLayout(False)
            CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel4.ResumeLayout(False)
            CType(Me.lstvEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EtiquetasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents SplitPanel1 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents bgwCarga As System.ComponentModel.BackgroundWorker
        Friend WithEvents cbstripeAccion As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents cbbtnAgregar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnEliminar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnModificar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbComandos As Telerik.WinControls.UI.RadCommandBar
        Private WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
        Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
        Friend WithEvents cbBuscarProducto As Telerik.WinControls.UI.CommandBarRowElement
        Friend WithEvents SplitPanel2 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents cbstripeBusqueda As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents VWProductosBindingSource As System.Windows.Forms.BindingSource
        Private WithEvents gridDatos As Telerik.WinControls.UI.RadGridView
        Friend WithEvents RadSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents SplitPanel3 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents SplitPanel4 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents lstvEtiquetas As Telerik.WinControls.UI.RadListView
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
        Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
        Friend WithEvents EtiquetasBindingSource As System.Windows.Forms.BindingSource
    End Class

End Namespace

