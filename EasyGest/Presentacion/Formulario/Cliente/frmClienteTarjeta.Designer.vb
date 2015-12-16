Namespace Presentacion.Formulario.Cliente

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmClienteTarjeta
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteTarjeta))
            Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim GridViewCheckBoxColumn2 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim GridViewCheckBoxColumn3 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim GridViewCheckBoxColumn4 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GroupDescriptor1 As Telerik.WinControls.Data.GroupDescriptor = New Telerik.WinControls.Data.GroupDescriptor()
            Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
            Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn5 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim GridViewDecimalColumn6 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim InputBinding1 As Telerik.WinControls.Keyboard.InputBinding = New Telerik.WinControls.Keyboard.InputBinding()
            Dim Chord1 As Telerik.WinControls.Keyboard.Chord = New Telerik.WinControls.Keyboard.Chord()
            Dim ChordModifier1 As Telerik.WinControls.Keyboard.ChordModifier = New Telerik.WinControls.Keyboard.ChordModifier()
            Me.cbbtnAgregar = New Telerik.WinControls.UI.CommandBarButton()
            Me.gridDatos = New Telerik.WinControls.UI.RadGridView()
            Me.VWTarjetasFidelizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridMovimientos = New Telerik.WinControls.UI.RadGridView()
            Me.MovimientosTarjetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.cbComandos = New Telerik.WinControls.UI.RadCommandBar()
            Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.cbstripeAccion = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbbtnEliminar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnModificar = New Telerik.WinControls.UI.CommandBarButton()
            Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.cbbtnEmitirVale = New Telerik.WinControls.UI.CommandBarButton()
            Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.cbbtnRecargar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbstripeBusqueda = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.SplitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
            Me.lbleDiagnostico = New Telerik.WinControls.UI.RadLabelElement()
            Me.SplitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.bgwCarga = New System.ComponentModel.BackgroundWorker()
            Me.RadButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
            Me.RadButtonElement2 = New Telerik.WinControls.UI.RadButtonElement()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.VWTarjetasFidelizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MovimientosTarjetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer1.SuspendLayout()
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel1.SuspendLayout()
            CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel2.SuspendLayout()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cbbtnAgregar
            '
            resources.ApplyResources(Me.cbbtnAgregar, "cbbtnAgregar")
            Me.cbbtnAgregar.DisplayName = "Agregar"
            Me.cbbtnAgregar.DrawText = True
            Me.cbbtnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnAgregar.Image = Global.EasyGest.My.Resources.Resources._127
            Me.cbbtnAgregar.Name = "cbbtnAgregar"
            Me.cbbtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnAgregar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'gridDatos
            '
            Me.gridDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDatos.Cursor = System.Windows.Forms.Cursors.Default
            resources.ApplyResources(Me.gridDatos, "gridDatos")
            Me.gridDatos.ForeColor = System.Drawing.Color.Black
            Me.gridDatos.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide
            '
            'gridDatos
            '
            Me.gridDatos.MasterTemplate.AllowAddNewRow = False
            Me.gridDatos.MasterTemplate.AllowColumnChooser = False
            Me.gridDatos.MasterTemplate.AllowDragToGroup = False
            Me.gridDatos.MasterTemplate.AllowRowResize = False
            Me.gridDatos.MasterTemplate.AutoGenerateColumns = False
            GridViewDecimalColumn1.DataType = GetType(Long)
            GridViewDecimalColumn1.EnableExpressionEditor = False
            GridViewDecimalColumn1.FieldName = "idTarjeta"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.IsVisible = False
            GridViewDecimalColumn1.Name = "idTarjeta"
            GridViewDecimalColumn2.DataType = GetType(Long)
            GridViewDecimalColumn2.EnableExpressionEditor = False
            GridViewDecimalColumn2.FieldName = "idCliente"
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.IsVisible = False
            GridViewDecimalColumn2.Name = "idCliente"
            GridViewTextBoxColumn1.AllowGroup = False
            GridViewTextBoxColumn1.EnableExpressionEditor = False
            GridViewTextBoxColumn1.FieldName = "NumeroTarjeta"
            resources.ApplyResources(GridViewTextBoxColumn1, "GridViewTextBoxColumn1")
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.IsPinned = True
            GridViewTextBoxColumn1.Name = "NumeroTarjeta"
            GridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewTextBoxColumn1.Width = 170
            GridViewDecimalColumn3.AllowGroup = False
            GridViewDecimalColumn3.DataType = GetType(Single)
            GridViewDecimalColumn3.EnableExpressionEditor = False
            GridViewDecimalColumn3.FieldName = "Saldo"
            resources.ApplyResources(GridViewDecimalColumn3, "GridViewDecimalColumn3")
            GridViewDecimalColumn3.IsAutoGenerated = True
            GridViewDecimalColumn3.IsPinned = True
            GridViewDecimalColumn3.Name = "Saldo"
            GridViewDecimalColumn3.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewDecimalColumn3.Width = 88
            GridViewDateTimeColumn1.AllowGroup = False
            GridViewDateTimeColumn1.EnableExpressionEditor = False
            GridViewDateTimeColumn1.FieldName = "FCreacion"
            GridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            resources.ApplyResources(GridViewDateTimeColumn1, "GridViewDateTimeColumn1")
            GridViewDateTimeColumn1.IsAutoGenerated = True
            GridViewDateTimeColumn1.Name = "FCreacion"
            GridViewDateTimeColumn1.Width = 105
            GridViewCheckBoxColumn1.AllowGroup = False
            GridViewCheckBoxColumn1.AllowSort = False
            GridViewCheckBoxColumn1.EnableExpressionEditor = False
            GridViewCheckBoxColumn1.FieldName = "Activo"
            resources.ApplyResources(GridViewCheckBoxColumn1, "GridViewCheckBoxColumn1")
            GridViewCheckBoxColumn1.IsAutoGenerated = True
            GridViewCheckBoxColumn1.MinWidth = 20
            GridViewCheckBoxColumn1.Name = "Activo"
            GridViewCheckBoxColumn1.Width = 62
            GridViewCheckBoxColumn2.AllowFiltering = False
            GridViewCheckBoxColumn2.AllowGroup = False
            GridViewCheckBoxColumn2.AllowSort = False
            GridViewCheckBoxColumn2.EnableExpressionEditor = False
            GridViewCheckBoxColumn2.FieldName = "EnSaldo"
            resources.ApplyResources(GridViewCheckBoxColumn2, "GridViewCheckBoxColumn2")
            GridViewCheckBoxColumn2.IsAutoGenerated = True
            GridViewCheckBoxColumn2.MinWidth = 20
            GridViewCheckBoxColumn2.Name = "EnSaldo"
            GridViewCheckBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            GridViewCheckBoxColumn2.Width = 69
            GridViewCheckBoxColumn3.AllowFiltering = False
            GridViewCheckBoxColumn3.AllowGroup = False
            GridViewCheckBoxColumn3.AllowSort = False
            GridViewCheckBoxColumn3.EnableExpressionEditor = False
            GridViewCheckBoxColumn3.FieldName = "EnPunto"
            resources.ApplyResources(GridViewCheckBoxColumn3, "GridViewCheckBoxColumn3")
            GridViewCheckBoxColumn3.IsAutoGenerated = True
            GridViewCheckBoxColumn3.MinWidth = 20
            GridViewCheckBoxColumn3.Name = "EnPunto"
            GridViewCheckBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            GridViewCheckBoxColumn3.Width = 75
            GridViewCheckBoxColumn4.AllowFiltering = False
            GridViewCheckBoxColumn4.AllowGroup = False
            GridViewCheckBoxColumn4.AllowSort = False
            GridViewCheckBoxColumn4.EnableExpressionEditor = False
            GridViewCheckBoxColumn4.FieldName = "CondicionParticular"
            resources.ApplyResources(GridViewCheckBoxColumn4, "GridViewCheckBoxColumn4")
            GridViewCheckBoxColumn4.IsAutoGenerated = True
            GridViewCheckBoxColumn4.MinWidth = 20
            GridViewCheckBoxColumn4.Name = "CondicionParticular"
            GridViewCheckBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            GridViewCheckBoxColumn4.Width = 112
            GridViewTextBoxColumn2.AllowFiltering = False
            GridViewTextBoxColumn2.AllowGroup = False
            GridViewTextBoxColumn2.AllowSort = False
            GridViewTextBoxColumn2.EnableExpressionEditor = False
            GridViewTextBoxColumn2.FieldName = "Condicion"
            resources.ApplyResources(GridViewTextBoxColumn2, "GridViewTextBoxColumn2")
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.Name = "Condicion"
            GridViewTextBoxColumn2.Width = 337
            GridViewTextBoxColumn3.EnableExpressionEditor = False
            GridViewTextBoxColumn3.FieldName = "Cliente"
            resources.ApplyResources(GridViewTextBoxColumn3, "GridViewTextBoxColumn3")
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.Name = "Cliente"
            GridViewTextBoxColumn3.Width = 185
            Me.gridDatos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewDecimalColumn2, GridViewTextBoxColumn1, GridViewDecimalColumn3, GridViewDateTimeColumn1, GridViewCheckBoxColumn1, GridViewCheckBoxColumn2, GridViewCheckBoxColumn3, GridViewCheckBoxColumn4, GridViewTextBoxColumn2, GridViewTextBoxColumn3})
            Me.gridDatos.MasterTemplate.DataSource = Me.VWTarjetasFidelizacionBindingSource
            Me.gridDatos.MasterTemplate.EnableAlternatingRowColor = True
            Me.gridDatos.MasterTemplate.EnableFiltering = True
            GroupDescriptor1.Format = "{0}: {1:C2}"
            SortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending
            SortDescriptor1.PropertyName = "Cliente"
            GroupDescriptor1.GroupNames.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
            Me.gridDatos.MasterTemplate.GroupDescriptors.AddRange(New Telerik.WinControls.Data.GroupDescriptor() {GroupDescriptor1})
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
            'VWTarjetasFidelizacionBindingSource
            '
            Me.VWTarjetasFidelizacionBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.VWTarjetasFidelizacion)
            '
            'gridMovimientos
            '
            Me.gridMovimientos.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridMovimientos.Cursor = System.Windows.Forms.Cursors.Default
            resources.ApplyResources(Me.gridMovimientos, "gridMovimientos")
            Me.gridMovimientos.ForeColor = System.Drawing.Color.Black
            '
            'gridMovimientos
            '
            Me.gridMovimientos.MasterTemplate.AllowAddNewRow = False
            Me.gridMovimientos.MasterTemplate.AllowDeleteRow = False
            Me.gridMovimientos.MasterTemplate.AllowRowResize = False
            GridViewDecimalColumn4.DataType = GetType(Long)
            GridViewDecimalColumn4.EnableExpressionEditor = False
            GridViewDecimalColumn4.FieldName = "idMovimiento"
            resources.ApplyResources(GridViewDecimalColumn4, "GridViewDecimalColumn4")
            GridViewDecimalColumn4.IsAutoGenerated = True
            GridViewDecimalColumn4.IsVisible = False
            GridViewDecimalColumn4.Name = "idMovimiento"
            GridViewDecimalColumn5.DataType = GetType(Long)
            GridViewDecimalColumn5.EnableExpressionEditor = False
            GridViewDecimalColumn5.FieldName = "idTarjeta"
            resources.ApplyResources(GridViewDecimalColumn5, "GridViewDecimalColumn5")
            GridViewDecimalColumn5.IsAutoGenerated = True
            GridViewDecimalColumn5.IsVisible = False
            GridViewDecimalColumn5.Name = "idTarjeta"
            GridViewDateTimeColumn2.EnableExpressionEditor = False
            GridViewDateTimeColumn2.FieldName = "FMovimiento"
            GridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
            resources.ApplyResources(GridViewDateTimeColumn2, "GridViewDateTimeColumn2")
            GridViewDateTimeColumn2.IsAutoGenerated = True
            GridViewDateTimeColumn2.IsPinned = True
            GridViewDateTimeColumn2.Name = "FMovimiento"
            GridViewDateTimeColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewDateTimeColumn2.Width = 111
            GridViewDecimalColumn6.DataType = GetType(Single)
            GridViewDecimalColumn6.EnableExpressionEditor = False
            GridViewDecimalColumn6.FieldName = "Saldo"
            resources.ApplyResources(GridViewDecimalColumn6, "GridViewDecimalColumn6")
            GridViewDecimalColumn6.IsAutoGenerated = True
            GridViewDecimalColumn6.Name = "Saldo"
            GridViewDecimalColumn6.Width = 111
            GridViewTextBoxColumn4.EnableExpressionEditor = False
            GridViewTextBoxColumn4.FieldName = "Descripcion"
            resources.ApplyResources(GridViewTextBoxColumn4, "GridViewTextBoxColumn4")
            GridViewTextBoxColumn4.IsAutoGenerated = True
            GridViewTextBoxColumn4.Name = "Descripcion"
            GridViewTextBoxColumn4.Width = 262
            Me.gridMovimientos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn4, GridViewDecimalColumn5, GridViewDateTimeColumn2, GridViewDecimalColumn6, GridViewTextBoxColumn4})
            Me.gridMovimientos.MasterTemplate.DataSource = Me.MovimientosTarjetaBindingSource
            Me.gridMovimientos.MasterTemplate.EnableAlternatingRowColor = True
            Me.gridMovimientos.MasterTemplate.EnableGrouping = False
            Me.gridMovimientos.Name = "gridMovimientos"
            Me.gridMovimientos.ReadOnly = True
            '
            '
            '
            Me.gridMovimientos.RootElement.AccessibleDescription = resources.GetString("gridMovimientos.RootElement.AccessibleDescription")
            Me.gridMovimientos.RootElement.AccessibleName = resources.GetString("gridMovimientos.RootElement.AccessibleName")
            Me.gridMovimientos.RootElement.Alignment = CType(resources.GetObject("gridMovimientos.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.gridMovimientos.RootElement.AngleTransform = CType(resources.GetObject("gridMovimientos.RootElement.AngleTransform"), Single)
            Me.gridMovimientos.RootElement.FlipText = CType(resources.GetObject("gridMovimientos.RootElement.FlipText"), Boolean)
            Me.gridMovimientos.RootElement.Margin = CType(resources.GetObject("gridMovimientos.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.gridMovimientos.RootElement.Padding = CType(resources.GetObject("gridMovimientos.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.gridMovimientos.RootElement.Text = resources.GetString("gridMovimientos.RootElement.Text")
            Me.gridMovimientos.RootElement.TextOrientation = CType(resources.GetObject("gridMovimientos.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.gridMovimientos.ShowGroupPanel = False
            '
            'MovimientosTarjetaBindingSource
            '
            Me.MovimientosTarjetaBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.MovimientosTarjeta)
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
            Me.cbComandos.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
            '
            'CommandBarRowElement1
            '
            resources.ApplyResources(Me.CommandBarRowElement1, "CommandBarRowElement1")
            Me.CommandBarRowElement1.DisplayName = Nothing
            Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
            Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.cbstripeAccion, Me.cbstripeBusqueda})
            '
            'cbstripeAccion
            '
            resources.ApplyResources(Me.cbstripeAccion, "cbstripeAccion")
            Me.cbstripeAccion.DisplayName = "Operación"
            Me.cbstripeAccion.EnableDragging = False
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
            Me.cbstripeAccion.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbtnAgregar, Me.cbbtnEliminar, Me.cbbtnModificar, Me.CommandBarSeparator2, Me.cbbtnEmitirVale, Me.CommandBarSeparator1, Me.cbbtnRecargar})
            Me.cbstripeAccion.Name = "CommandBarStripElement1"
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
            'cbbtnEliminar
            '
            resources.ApplyResources(Me.cbbtnEliminar, "cbbtnEliminar")
            Me.cbbtnEliminar.DisplayName = "Eliminar"
            Me.cbbtnEliminar.DrawText = True
            Me.cbbtnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnEliminar.Image = Global.EasyGest.My.Resources.Resources._128
            Me.cbbtnEliminar.Name = "cbbtnEliminar"
            Me.cbbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnEliminar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbbtnModificar
            '
            resources.ApplyResources(Me.cbbtnModificar, "cbbtnModificar")
            Me.cbbtnModificar.DisplayName = "Modificar"
            Me.cbbtnModificar.DrawText = True
            Me.cbbtnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnModificar.Image = Global.EasyGest.My.Resources.Resources._130
            Me.cbbtnModificar.Name = "cbbtnModificar"
            Me.cbbtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnModificar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'CommandBarSeparator2
            '
            resources.ApplyResources(Me.CommandBarSeparator2, "CommandBarSeparator2")
            Me.CommandBarSeparator2.DisplayName = "CommandBarSeparator2"
            Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
            Me.CommandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.CommandBarSeparator2.VisibleInOverflowMenu = False
            '
            'cbbtnEmitirVale
            '
            resources.ApplyResources(Me.cbbtnEmitirVale, "cbbtnEmitirVale")
            Me.cbbtnEmitirVale.DisplayName = "Cobro"
            Me.cbbtnEmitirVale.DrawText = True
            Me.cbbtnEmitirVale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnEmitirVale.Image = Global.EasyGest.My.Resources.Resources._88
            Me.cbbtnEmitirVale.Name = "cbbtnEmitirVale"
            Me.cbbtnEmitirVale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnEmitirVale.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'CommandBarSeparator1
            '
            resources.ApplyResources(Me.CommandBarSeparator1, "CommandBarSeparator1")
            Me.CommandBarSeparator1.DisplayName = "CommandBarSeparator1"
            Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
            Me.CommandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.CommandBarSeparator1.VisibleInOverflowMenu = False
            '
            'cbbtnRecargar
            '
            resources.ApplyResources(Me.cbbtnRecargar, "cbbtnRecargar")
            Me.cbbtnRecargar.DisplayName = "Recargar"
            Me.cbbtnRecargar.DrawText = True
            Me.cbbtnRecargar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnRecargar.Image = Global.EasyGest.My.Resources.Resources._48
            Me.cbbtnRecargar.Name = "cbbtnRecargar"
            Me.cbbtnRecargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnRecargar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbstripeBusqueda
            '
            resources.ApplyResources(Me.cbstripeBusqueda, "cbstripeBusqueda")
            Me.cbstripeBusqueda.DisplayName = "Busqueda"
            Me.cbstripeBusqueda.DrawFill = True
            Me.cbstripeBusqueda.DrawText = False
            Me.cbstripeBusqueda.EnableDragging = False
            '
            '
            '
            Me.cbstripeBusqueda.Grip.Alignment = CType(resources.GetObject("resource.Alignment4"), System.Drawing.ContentAlignment)
            Me.cbstripeBusqueda.Grip.AngleTransform = CType(resources.GetObject("resource.AngleTransform4"), Single)
            Me.cbstripeBusqueda.Grip.FlipText = CType(resources.GetObject("resource.FlipText4"), Boolean)
            Me.cbstripeBusqueda.Grip.Margin = CType(resources.GetObject("resource.Margin4"), System.Windows.Forms.Padding)
            Me.cbstripeBusqueda.Grip.Padding = CType(resources.GetObject("resource.Padding4"), System.Windows.Forms.Padding)
            Me.cbstripeBusqueda.Grip.RightToLeft = CType(resources.GetObject("resource.RightToLeft4"), Boolean)
            Me.cbstripeBusqueda.Grip.Text = resources.GetString("resource.Text4")
            Me.cbstripeBusqueda.Grip.TextOrientation = CType(resources.GetObject("resource.TextOrientation4"), System.Windows.Forms.Orientation)
            Me.cbstripeBusqueda.Grip.TextWrap = CType(resources.GetObject("resource.TextWrap4"), Boolean)
            Me.cbstripeBusqueda.Name = "CommandBarStripElement2"
            '
            '
            '
            Me.cbstripeBusqueda.OverflowButton.Alignment = CType(resources.GetObject("resource.Alignment5"), System.Drawing.ContentAlignment)
            Me.cbstripeBusqueda.OverflowButton.AngleTransform = CType(resources.GetObject("resource.AngleTransform5"), Single)
            Me.cbstripeBusqueda.OverflowButton.FlipText = CType(resources.GetObject("resource.FlipText5"), Boolean)
            Me.cbstripeBusqueda.OverflowButton.Margin = CType(resources.GetObject("resource.Margin5"), System.Windows.Forms.Padding)
            Me.cbstripeBusqueda.OverflowButton.Padding = CType(resources.GetObject("resource.Padding5"), System.Windows.Forms.Padding)
            Me.cbstripeBusqueda.OverflowButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft5"), Boolean)
            Me.cbstripeBusqueda.OverflowButton.Text = resources.GetString("resource.Text5")
            Me.cbstripeBusqueda.OverflowButton.TextOrientation = CType(resources.GetObject("resource.TextOrientation5"), System.Windows.Forms.Orientation)
            Me.cbstripeBusqueda.OverflowButton.TextWrap = CType(resources.GetObject("resource.TextWrap5"), Boolean)
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
            Me.SplitPanel1.Controls.Add(Me.RadStatusStrip1)
            Me.SplitPanel1.Controls.Add(Me.cbComandos)
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
            Me.SplitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.2502263!, 0.0!)
            Me.SplitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(247, 0)
            Me.SplitPanel1.TabStop = False
            '
            'RadStatusStrip1
            '
            Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.lbleDiagnostico})
            resources.ApplyResources(Me.RadStatusStrip1, "RadStatusStrip1")
            Me.RadStatusStrip1.Name = "RadStatusStrip1"
            '
            '
            '
            Me.RadStatusStrip1.RootElement.AccessibleDescription = resources.GetString("RadStatusStrip1.RootElement.AccessibleDescription")
            Me.RadStatusStrip1.RootElement.AccessibleName = resources.GetString("RadStatusStrip1.RootElement.AccessibleName")
            Me.RadStatusStrip1.RootElement.Alignment = CType(resources.GetObject("RadStatusStrip1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadStatusStrip1.RootElement.AngleTransform = CType(resources.GetObject("RadStatusStrip1.RootElement.AngleTransform"), Single)
            Me.RadStatusStrip1.RootElement.FlipText = CType(resources.GetObject("RadStatusStrip1.RootElement.FlipText"), Boolean)
            Me.RadStatusStrip1.RootElement.Margin = CType(resources.GetObject("RadStatusStrip1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadStatusStrip1.RootElement.Padding = CType(resources.GetObject("RadStatusStrip1.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadStatusStrip1.RootElement.Text = resources.GetString("RadStatusStrip1.RootElement.Text")
            Me.RadStatusStrip1.RootElement.TextOrientation = CType(resources.GetObject("RadStatusStrip1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'lbleDiagnostico
            '
            resources.ApplyResources(Me.lbleDiagnostico, "lbleDiagnostico")
            Me.lbleDiagnostico.Name = "lbleDiagnostico"
            Me.RadStatusStrip1.SetSpring(Me.lbleDiagnostico, True)
            Me.lbleDiagnostico.TextWrap = True
            Me.lbleDiagnostico.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'SplitPanel2
            '
            Me.SplitPanel2.Controls.Add(Me.gridMovimientos)
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
            Me.SplitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.2502263!, 0.0!)
            Me.SplitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(-247, 0)
            Me.SplitPanel2.TabStop = False
            '
            'bgwCarga
            '
            Me.bgwCarga.WorkerSupportsCancellation = True
            '
            'RadButtonElement1
            '
            resources.ApplyResources(Me.RadButtonElement1, "RadButtonElement1")
            Me.RadButtonElement1.AutoSize = True
            Me.RadButtonElement1.Name = "RadButtonElement1"
            Me.RadButtonElement1.Tag = "1"
            Me.RadButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'RadButtonElement2
            '
            resources.ApplyResources(Me.RadButtonElement2, "RadButtonElement2")
            Me.RadButtonElement2.AutoSize = True
            Me.RadButtonElement2.Name = "RadButtonElement2"
            Me.RadButtonElement2.Tag = "1"
            Me.RadButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'frmClienteTarjeta
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
            Me.Name = "frmClienteTarjeta"
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmClienteTarjeta.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmClienteTarjeta.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmClienteTarjeta.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmClienteTarjeta.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmClienteTarjeta.RootElement.FlipText"), Boolean)
            Me.RootElement.Margin = CType(resources.GetObject("frmClienteTarjeta.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmClienteTarjeta.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmClienteTarjeta.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmClienteTarjeta.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.VWTarjetasFidelizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MovimientosTarjetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer1.ResumeLayout(False)
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel1.ResumeLayout(False)
            Me.SplitPanel1.PerformLayout()
            CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel2.ResumeLayout(False)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents cbComandos As Telerik.WinControls.UI.RadCommandBar
        Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
        Friend WithEvents cbstripeAccion As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents cbbtnAgregar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnEliminar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnModificar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnEmitirVale As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents SplitPanel1 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents SplitPanel2 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
        Dim WithEvents gridDatos As Telerik.WinControls.UI.RadGridView
        Friend WithEvents cbstripeBusqueda As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents bgwCarga As System.ComponentModel.BackgroundWorker
        Friend WithEvents RadButtonElement1 As Telerik.WinControls.UI.RadButtonElement
        Friend WithEvents RadButtonElement2 As Telerik.WinControls.UI.RadButtonElement
        Friend WithEvents VWTarjetasFidelizacionBindingSource As System.Windows.Forms.BindingSource
        Private WithEvents gridMovimientos As Telerik.WinControls.UI.RadGridView
        Friend WithEvents MovimientosTarjetaBindingSource As System.Windows.Forms.BindingSource
        Private WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
        Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
        Friend WithEvents lbleDiagnostico As Telerik.WinControls.UI.RadLabelElement
        Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
        Friend WithEvents cbbtnRecargar As Telerik.WinControls.UI.CommandBarButton
    End Class

End Namespace

