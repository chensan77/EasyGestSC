Namespace Presentacion.Formulario.Producto

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmProductoEdicion
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
            Dim RadLabel1 As Telerik.WinControls.UI.RadLabel
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductoEdicion))
            Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewMaskBoxColumn1 As Telerik.WinControls.UI.GridViewMaskBoxColumn = New Telerik.WinControls.UI.GridViewMaskBoxColumn()
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel4 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel5 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel12 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel14 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel15 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel20 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel17 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel18 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel3 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel6 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel7 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel8 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel9 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel10 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel11 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel13 As Telerik.WinControls.UI.RadLabel
            Me.gridDatos = New Telerik.WinControls.UI.RadGridView()
            Me.CodigosBarraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.grpbPrecio = New Telerik.WinControls.UI.RadGroupBox()
            Me.spinPrecioVenta = New Telerik.WinControls.UI.RadSpinEditor()
            Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.spinPrecioCoste = New Telerik.WinControls.UI.RadSpinEditor()
            Me.grpbStock = New Telerik.WinControls.UI.RadGroupBox()
            Me.spinStockPaquete = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinStock = New Telerik.WinControls.UI.RadSpinEditor()
            Me.UnidadesMedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.FamiliasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ddlTipoImpuesto = New Telerik.WinControls.UI.RadDropDownList()
            Me.ImpuestosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.txtNombre = New Telerik.WinControls.UI.RadTextBox()
            Me.txtNombreChino = New Telerik.WinControls.UI.RadTextBox()
            Me.timValidar = New System.Windows.Forms.Timer(Me.components)
            Me.txtObservacion = New Telerik.WinControls.UI.RadTextBox()
            Me.txtReferencia = New Telerik.WinControls.UI.RadTextBox()
            Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.txtDescuento = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinUnidadVenta = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinUnidadPaquete = New Telerik.WinControls.UI.RadSpinEditor()
            Me.chkPrecioVariable = New Telerik.WinControls.UI.RadCheckBox()
            Me.chkControlStock = New Telerik.WinControls.UI.RadCheckBox()
            Me.UbicacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.SplitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.toggleCodigoBarra = New Telerik.WinControls.UI.RadToggleButton()
            Me.btnQuitarUbicacion = New Telerik.WinControls.UI.RadButton()
            Me.btnQuitarUnidad = New Telerik.WinControls.UI.RadButton()
            Me.btnQuitarMarca = New Telerik.WinControls.UI.RadButton()
            Me.btnQuitarFamilia = New Telerik.WinControls.UI.RadButton()
            Me.btnGenerarReferencia = New Telerik.WinControls.UI.RadButton()
            Me.ddlUnidadMedida = New Telerik.WinControls.UI.RadDropDownList()
            Me.ddlFamilia = New Telerik.WinControls.UI.RadDropDownList()
            Me.ddlUbicacion = New Telerik.WinControls.UI.RadDropDownList()
            Me.ddlMarca = New Telerik.WinControls.UI.RadDropDownList()
            Me.SplitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            RadLabel5 = New Telerik.WinControls.UI.RadLabel()
            RadLabel12 = New Telerik.WinControls.UI.RadLabel()
            RadLabel14 = New Telerik.WinControls.UI.RadLabel()
            RadLabel15 = New Telerik.WinControls.UI.RadLabel()
            RadLabel20 = New Telerik.WinControls.UI.RadLabel()
            RadLabel17 = New Telerik.WinControls.UI.RadLabel()
            RadLabel18 = New Telerik.WinControls.UI.RadLabel()
            RadLabel3 = New Telerik.WinControls.UI.RadLabel()
            RadLabel6 = New Telerik.WinControls.UI.RadLabel()
            RadLabel7 = New Telerik.WinControls.UI.RadLabel()
            RadLabel8 = New Telerik.WinControls.UI.RadLabel()
            RadLabel9 = New Telerik.WinControls.UI.RadLabel()
            RadLabel10 = New Telerik.WinControls.UI.RadLabel()
            RadLabel11 = New Telerik.WinControls.UI.RadLabel()
            RadLabel13 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CodigosBarraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grpbPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpbPrecio.SuspendLayout()
            CType(Me.spinPrecioVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinPrecioCoste, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grpbStock, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpbStock.SuspendLayout()
            CType(Me.spinStockPaquete, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinStock, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UnidadesMedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FamiliasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlTipoImpuesto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ImpuestosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNombreChino, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtReferencia, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinUnidadVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinUnidadPaquete, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkPrecioVariable, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkControlStock, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UbicacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer1.SuspendLayout()
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel1.SuspendLayout()
            CType(Me.toggleCodigoBarra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnQuitarUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnQuitarUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnQuitarMarca, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnQuitarFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnGenerarReferencia, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlUnidadMedida, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlMarca, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel2.SuspendLayout()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'RadLabel1
            '
            resources.ApplyResources(RadLabel1, "RadLabel1")
            RadLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel1.Name = "RadLabel1"
            '
            '
            '
            RadLabel1.RootElement.AccessibleDescription = resources.GetString("RadLabel1.RootElement.AccessibleDescription")
            RadLabel1.RootElement.AccessibleName = resources.GetString("RadLabel1.RootElement.AccessibleName")
            RadLabel1.RootElement.Alignment = CType(resources.GetObject("RadLabel1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel1.RootElement.AngleTransform = CType(resources.GetObject("RadLabel1.RootElement.AngleTransform"), Single)
            RadLabel1.RootElement.FlipText = CType(resources.GetObject("RadLabel1.RootElement.FlipText"), Boolean)
            RadLabel1.RootElement.Margin = CType(resources.GetObject("RadLabel1.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel1.RootElement.Padding = CType(resources.GetObject("RadLabel1.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel1.RootElement.Text = resources.GetString("RadLabel1.RootElement.Text")
            RadLabel1.RootElement.TextOrientation = CType(resources.GetObject("RadLabel1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'gridDatos
            '
            Me.gridDatos.AllowShowFocusCues = True
            Me.gridDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDatos.Cursor = System.Windows.Forms.Cursors.Default
            resources.ApplyResources(Me.gridDatos, "gridDatos")
            Me.gridDatos.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow
            Me.gridDatos.ForeColor = System.Drawing.Color.Black
            '
            'gridDatos
            '
            Me.gridDatos.MasterTemplate.AllowColumnChooser = False
            Me.gridDatos.MasterTemplate.AllowDragToGroup = False
            Me.gridDatos.MasterTemplate.AllowRowResize = False
            Me.gridDatos.MasterTemplate.AutoGenerateColumns = False
            GridViewDecimalColumn1.DataType = GetType(Long)
            GridViewDecimalColumn1.EnableExpressionEditor = False
            GridViewDecimalColumn1.FieldName = "idCodigo"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.IsVisible = False
            GridViewDecimalColumn1.Name = "idCodigo"
            GridViewDecimalColumn2.DataType = GetType(Long)
            GridViewDecimalColumn2.EnableExpressionEditor = False
            GridViewDecimalColumn2.FieldName = "idProducto"
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.IsVisible = False
            GridViewDecimalColumn2.Name = "idProducto"
            GridViewMaskBoxColumn1.EnableExpressionEditor = False
            GridViewMaskBoxColumn1.FieldName = "CodigoBarra"
            resources.ApplyResources(GridViewMaskBoxColumn1, "GridViewMaskBoxColumn1")
            GridViewMaskBoxColumn1.IsAutoGenerated = True
            GridViewMaskBoxColumn1.Mask = "##############"
            GridViewMaskBoxColumn1.MaskType = Telerik.WinControls.UI.MaskType.Standard
            GridViewMaskBoxColumn1.Name = "CodigoBarra"
            GridViewMaskBoxColumn1.Width = 172
            Me.gridDatos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewDecimalColumn2, GridViewMaskBoxColumn1})
            Me.gridDatos.MasterTemplate.DataSource = Me.CodigosBarraBindingSource
            Me.gridDatos.MasterTemplate.EnableAlternatingRowColor = True
            Me.gridDatos.MasterTemplate.EnableGrouping = False
            Me.gridDatos.Name = "gridDatos"
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
            'CodigosBarraBindingSource
            '
            Me.CodigosBarraBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.CodigosBarra)
            '
            'RadLabel2
            '
            resources.ApplyResources(RadLabel2, "RadLabel2")
            RadLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel2.Name = "RadLabel2"
            '
            '
            '
            RadLabel2.RootElement.AccessibleDescription = resources.GetString("RadLabel2.RootElement.AccessibleDescription")
            RadLabel2.RootElement.AccessibleName = resources.GetString("RadLabel2.RootElement.AccessibleName")
            RadLabel2.RootElement.Alignment = CType(resources.GetObject("RadLabel2.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel2.RootElement.AngleTransform = CType(resources.GetObject("RadLabel2.RootElement.AngleTransform"), Single)
            RadLabel2.RootElement.FlipText = CType(resources.GetObject("RadLabel2.RootElement.FlipText"), Boolean)
            RadLabel2.RootElement.Margin = CType(resources.GetObject("RadLabel2.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel2.RootElement.Padding = CType(resources.GetObject("RadLabel2.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel2.RootElement.Text = resources.GetString("RadLabel2.RootElement.Text")
            RadLabel2.RootElement.TextOrientation = CType(resources.GetObject("RadLabel2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel4
            '
            resources.ApplyResources(RadLabel4, "RadLabel4")
            RadLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel4.Name = "RadLabel4"
            '
            '
            '
            RadLabel4.RootElement.AccessibleDescription = resources.GetString("RadLabel4.RootElement.AccessibleDescription")
            RadLabel4.RootElement.AccessibleName = resources.GetString("RadLabel4.RootElement.AccessibleName")
            RadLabel4.RootElement.Alignment = CType(resources.GetObject("RadLabel4.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel4.RootElement.AngleTransform = CType(resources.GetObject("RadLabel4.RootElement.AngleTransform"), Single)
            RadLabel4.RootElement.FlipText = CType(resources.GetObject("RadLabel4.RootElement.FlipText"), Boolean)
            RadLabel4.RootElement.Margin = CType(resources.GetObject("RadLabel4.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel4.RootElement.Padding = CType(resources.GetObject("RadLabel4.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel4.RootElement.Text = resources.GetString("RadLabel4.RootElement.Text")
            RadLabel4.RootElement.TextOrientation = CType(resources.GetObject("RadLabel4.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel5
            '
            resources.ApplyResources(RadLabel5, "RadLabel5")
            RadLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel5.Name = "RadLabel5"
            '
            '
            '
            RadLabel5.RootElement.AccessibleDescription = resources.GetString("RadLabel5.RootElement.AccessibleDescription")
            RadLabel5.RootElement.AccessibleName = resources.GetString("RadLabel5.RootElement.AccessibleName")
            RadLabel5.RootElement.Alignment = CType(resources.GetObject("RadLabel5.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel5.RootElement.AngleTransform = CType(resources.GetObject("RadLabel5.RootElement.AngleTransform"), Single)
            RadLabel5.RootElement.FlipText = CType(resources.GetObject("RadLabel5.RootElement.FlipText"), Boolean)
            RadLabel5.RootElement.Margin = CType(resources.GetObject("RadLabel5.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel5.RootElement.Padding = CType(resources.GetObject("RadLabel5.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel5.RootElement.Text = resources.GetString("RadLabel5.RootElement.Text")
            RadLabel5.RootElement.TextOrientation = CType(resources.GetObject("RadLabel5.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel12
            '
            resources.ApplyResources(RadLabel12, "RadLabel12")
            RadLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel12.Name = "RadLabel12"
            '
            '
            '
            RadLabel12.RootElement.AccessibleDescription = resources.GetString("RadLabel12.RootElement.AccessibleDescription")
            RadLabel12.RootElement.AccessibleName = resources.GetString("RadLabel12.RootElement.AccessibleName")
            RadLabel12.RootElement.Alignment = CType(resources.GetObject("RadLabel12.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel12.RootElement.AngleTransform = CType(resources.GetObject("RadLabel12.RootElement.AngleTransform"), Single)
            RadLabel12.RootElement.FlipText = CType(resources.GetObject("RadLabel12.RootElement.FlipText"), Boolean)
            RadLabel12.RootElement.Margin = CType(resources.GetObject("RadLabel12.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel12.RootElement.Padding = CType(resources.GetObject("RadLabel12.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel12.RootElement.Text = resources.GetString("RadLabel12.RootElement.Text")
            RadLabel12.RootElement.TextOrientation = CType(resources.GetObject("RadLabel12.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel14
            '
            resources.ApplyResources(RadLabel14, "RadLabel14")
            RadLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel14.Name = "RadLabel14"
            '
            '
            '
            RadLabel14.RootElement.AccessibleDescription = resources.GetString("RadLabel14.RootElement.AccessibleDescription")
            RadLabel14.RootElement.AccessibleName = resources.GetString("RadLabel14.RootElement.AccessibleName")
            RadLabel14.RootElement.Alignment = CType(resources.GetObject("RadLabel14.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel14.RootElement.AngleTransform = CType(resources.GetObject("RadLabel14.RootElement.AngleTransform"), Single)
            RadLabel14.RootElement.FlipText = CType(resources.GetObject("RadLabel14.RootElement.FlipText"), Boolean)
            RadLabel14.RootElement.Margin = CType(resources.GetObject("RadLabel14.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel14.RootElement.Padding = CType(resources.GetObject("RadLabel14.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel14.RootElement.Text = resources.GetString("RadLabel14.RootElement.Text")
            RadLabel14.RootElement.TextOrientation = CType(resources.GetObject("RadLabel14.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel15
            '
            resources.ApplyResources(RadLabel15, "RadLabel15")
            RadLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel15.Name = "RadLabel15"
            '
            '
            '
            RadLabel15.RootElement.AccessibleDescription = resources.GetString("RadLabel15.RootElement.AccessibleDescription")
            RadLabel15.RootElement.AccessibleName = resources.GetString("RadLabel15.RootElement.AccessibleName")
            RadLabel15.RootElement.Alignment = CType(resources.GetObject("RadLabel15.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel15.RootElement.AngleTransform = CType(resources.GetObject("RadLabel15.RootElement.AngleTransform"), Single)
            RadLabel15.RootElement.FlipText = CType(resources.GetObject("RadLabel15.RootElement.FlipText"), Boolean)
            RadLabel15.RootElement.Margin = CType(resources.GetObject("RadLabel15.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel15.RootElement.Padding = CType(resources.GetObject("RadLabel15.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel15.RootElement.Text = resources.GetString("RadLabel15.RootElement.Text")
            RadLabel15.RootElement.TextOrientation = CType(resources.GetObject("RadLabel15.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel20
            '
            resources.ApplyResources(RadLabel20, "RadLabel20")
            RadLabel20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel20.Name = "RadLabel20"
            '
            '
            '
            RadLabel20.RootElement.AccessibleDescription = resources.GetString("RadLabel20.RootElement.AccessibleDescription")
            RadLabel20.RootElement.AccessibleName = resources.GetString("RadLabel20.RootElement.AccessibleName")
            RadLabel20.RootElement.Alignment = CType(resources.GetObject("RadLabel20.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel20.RootElement.AngleTransform = CType(resources.GetObject("RadLabel20.RootElement.AngleTransform"), Single)
            RadLabel20.RootElement.FlipText = CType(resources.GetObject("RadLabel20.RootElement.FlipText"), Boolean)
            RadLabel20.RootElement.Margin = CType(resources.GetObject("RadLabel20.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel20.RootElement.Padding = CType(resources.GetObject("RadLabel20.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel20.RootElement.Text = resources.GetString("RadLabel20.RootElement.Text")
            RadLabel20.RootElement.TextOrientation = CType(resources.GetObject("RadLabel20.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel17
            '
            resources.ApplyResources(RadLabel17, "RadLabel17")
            RadLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel17.Name = "RadLabel17"
            '
            '
            '
            RadLabel17.RootElement.AccessibleDescription = resources.GetString("RadLabel17.RootElement.AccessibleDescription")
            RadLabel17.RootElement.AccessibleName = resources.GetString("RadLabel17.RootElement.AccessibleName")
            RadLabel17.RootElement.Alignment = CType(resources.GetObject("RadLabel17.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel17.RootElement.AngleTransform = CType(resources.GetObject("RadLabel17.RootElement.AngleTransform"), Single)
            RadLabel17.RootElement.FlipText = CType(resources.GetObject("RadLabel17.RootElement.FlipText"), Boolean)
            RadLabel17.RootElement.Margin = CType(resources.GetObject("RadLabel17.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel17.RootElement.Padding = CType(resources.GetObject("RadLabel17.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel17.RootElement.Text = resources.GetString("RadLabel17.RootElement.Text")
            RadLabel17.RootElement.TextOrientation = CType(resources.GetObject("RadLabel17.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel18
            '
            resources.ApplyResources(RadLabel18, "RadLabel18")
            RadLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel18.Name = "RadLabel18"
            '
            '
            '
            RadLabel18.RootElement.AccessibleDescription = resources.GetString("RadLabel18.RootElement.AccessibleDescription")
            RadLabel18.RootElement.AccessibleName = resources.GetString("RadLabel18.RootElement.AccessibleName")
            RadLabel18.RootElement.Alignment = CType(resources.GetObject("RadLabel18.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel18.RootElement.AngleTransform = CType(resources.GetObject("RadLabel18.RootElement.AngleTransform"), Single)
            RadLabel18.RootElement.FlipText = CType(resources.GetObject("RadLabel18.RootElement.FlipText"), Boolean)
            RadLabel18.RootElement.Margin = CType(resources.GetObject("RadLabel18.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel18.RootElement.Padding = CType(resources.GetObject("RadLabel18.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel18.RootElement.Text = resources.GetString("RadLabel18.RootElement.Text")
            RadLabel18.RootElement.TextOrientation = CType(resources.GetObject("RadLabel18.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel3
            '
            resources.ApplyResources(RadLabel3, "RadLabel3")
            RadLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel3.Name = "RadLabel3"
            '
            '
            '
            RadLabel3.RootElement.AccessibleDescription = resources.GetString("RadLabel3.RootElement.AccessibleDescription")
            RadLabel3.RootElement.AccessibleName = resources.GetString("RadLabel3.RootElement.AccessibleName")
            RadLabel3.RootElement.Alignment = CType(resources.GetObject("RadLabel3.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel3.RootElement.AngleTransform = CType(resources.GetObject("RadLabel3.RootElement.AngleTransform"), Single)
            RadLabel3.RootElement.FlipText = CType(resources.GetObject("RadLabel3.RootElement.FlipText"), Boolean)
            RadLabel3.RootElement.Margin = CType(resources.GetObject("RadLabel3.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel3.RootElement.Padding = CType(resources.GetObject("RadLabel3.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel3.RootElement.Text = resources.GetString("RadLabel3.RootElement.Text")
            RadLabel3.RootElement.TextOrientation = CType(resources.GetObject("RadLabel3.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel6
            '
            resources.ApplyResources(RadLabel6, "RadLabel6")
            RadLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel6.Name = "RadLabel6"
            '
            '
            '
            RadLabel6.RootElement.AccessibleDescription = resources.GetString("RadLabel6.RootElement.AccessibleDescription")
            RadLabel6.RootElement.AccessibleName = resources.GetString("RadLabel6.RootElement.AccessibleName")
            RadLabel6.RootElement.Alignment = CType(resources.GetObject("RadLabel6.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel6.RootElement.AngleTransform = CType(resources.GetObject("RadLabel6.RootElement.AngleTransform"), Single)
            RadLabel6.RootElement.FlipText = CType(resources.GetObject("RadLabel6.RootElement.FlipText"), Boolean)
            RadLabel6.RootElement.Margin = CType(resources.GetObject("RadLabel6.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel6.RootElement.Padding = CType(resources.GetObject("RadLabel6.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel6.RootElement.Text = resources.GetString("RadLabel6.RootElement.Text")
            RadLabel6.RootElement.TextOrientation = CType(resources.GetObject("RadLabel6.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel7
            '
            resources.ApplyResources(RadLabel7, "RadLabel7")
            RadLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel7.Name = "RadLabel7"
            '
            '
            '
            RadLabel7.RootElement.AccessibleDescription = resources.GetString("RadLabel7.RootElement.AccessibleDescription")
            RadLabel7.RootElement.AccessibleName = resources.GetString("RadLabel7.RootElement.AccessibleName")
            RadLabel7.RootElement.Alignment = CType(resources.GetObject("RadLabel7.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel7.RootElement.AngleTransform = CType(resources.GetObject("RadLabel7.RootElement.AngleTransform"), Single)
            RadLabel7.RootElement.FlipText = CType(resources.GetObject("RadLabel7.RootElement.FlipText"), Boolean)
            RadLabel7.RootElement.Margin = CType(resources.GetObject("RadLabel7.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel7.RootElement.Padding = CType(resources.GetObject("RadLabel7.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel7.RootElement.Text = resources.GetString("RadLabel7.RootElement.Text")
            RadLabel7.RootElement.TextOrientation = CType(resources.GetObject("RadLabel7.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel8
            '
            resources.ApplyResources(RadLabel8, "RadLabel8")
            RadLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel8.Name = "RadLabel8"
            '
            '
            '
            RadLabel8.RootElement.AccessibleDescription = resources.GetString("RadLabel8.RootElement.AccessibleDescription")
            RadLabel8.RootElement.AccessibleName = resources.GetString("RadLabel8.RootElement.AccessibleName")
            RadLabel8.RootElement.Alignment = CType(resources.GetObject("RadLabel8.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel8.RootElement.AngleTransform = CType(resources.GetObject("RadLabel8.RootElement.AngleTransform"), Single)
            RadLabel8.RootElement.FlipText = CType(resources.GetObject("RadLabel8.RootElement.FlipText"), Boolean)
            RadLabel8.RootElement.Margin = CType(resources.GetObject("RadLabel8.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel8.RootElement.Padding = CType(resources.GetObject("RadLabel8.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel8.RootElement.Text = resources.GetString("RadLabel8.RootElement.Text")
            RadLabel8.RootElement.TextOrientation = CType(resources.GetObject("RadLabel8.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel9
            '
            resources.ApplyResources(RadLabel9, "RadLabel9")
            RadLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel9.Name = "RadLabel9"
            '
            '
            '
            RadLabel9.RootElement.AccessibleDescription = resources.GetString("RadLabel9.RootElement.AccessibleDescription")
            RadLabel9.RootElement.AccessibleName = resources.GetString("RadLabel9.RootElement.AccessibleName")
            RadLabel9.RootElement.Alignment = CType(resources.GetObject("RadLabel9.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel9.RootElement.AngleTransform = CType(resources.GetObject("RadLabel9.RootElement.AngleTransform"), Single)
            RadLabel9.RootElement.FlipText = CType(resources.GetObject("RadLabel9.RootElement.FlipText"), Boolean)
            RadLabel9.RootElement.Margin = CType(resources.GetObject("RadLabel9.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel9.RootElement.Padding = CType(resources.GetObject("RadLabel9.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel9.RootElement.Text = resources.GetString("RadLabel9.RootElement.Text")
            RadLabel9.RootElement.TextOrientation = CType(resources.GetObject("RadLabel9.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel10
            '
            resources.ApplyResources(RadLabel10, "RadLabel10")
            RadLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel10.Name = "RadLabel10"
            '
            '
            '
            RadLabel10.RootElement.AccessibleDescription = resources.GetString("RadLabel10.RootElement.AccessibleDescription")
            RadLabel10.RootElement.AccessibleName = resources.GetString("RadLabel10.RootElement.AccessibleName")
            RadLabel10.RootElement.Alignment = CType(resources.GetObject("RadLabel10.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel10.RootElement.AngleTransform = CType(resources.GetObject("RadLabel10.RootElement.AngleTransform"), Single)
            RadLabel10.RootElement.FlipText = CType(resources.GetObject("RadLabel10.RootElement.FlipText"), Boolean)
            RadLabel10.RootElement.Margin = CType(resources.GetObject("RadLabel10.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel10.RootElement.Padding = CType(resources.GetObject("RadLabel10.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel10.RootElement.Text = resources.GetString("RadLabel10.RootElement.Text")
            RadLabel10.RootElement.TextOrientation = CType(resources.GetObject("RadLabel10.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel11
            '
            resources.ApplyResources(RadLabel11, "RadLabel11")
            RadLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel11.Name = "RadLabel11"
            '
            '
            '
            RadLabel11.RootElement.AccessibleDescription = resources.GetString("RadLabel11.RootElement.AccessibleDescription")
            RadLabel11.RootElement.AccessibleName = resources.GetString("RadLabel11.RootElement.AccessibleName")
            RadLabel11.RootElement.Alignment = CType(resources.GetObject("RadLabel11.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel11.RootElement.AngleTransform = CType(resources.GetObject("RadLabel11.RootElement.AngleTransform"), Single)
            RadLabel11.RootElement.FlipText = CType(resources.GetObject("RadLabel11.RootElement.FlipText"), Boolean)
            RadLabel11.RootElement.Margin = CType(resources.GetObject("RadLabel11.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel11.RootElement.Padding = CType(resources.GetObject("RadLabel11.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel11.RootElement.Text = resources.GetString("RadLabel11.RootElement.Text")
            RadLabel11.RootElement.TextOrientation = CType(resources.GetObject("RadLabel11.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadLabel13
            '
            resources.ApplyResources(RadLabel13, "RadLabel13")
            RadLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel13.Name = "RadLabel13"
            '
            '
            '
            RadLabel13.RootElement.AccessibleDescription = resources.GetString("RadLabel13.RootElement.AccessibleDescription")
            RadLabel13.RootElement.AccessibleName = resources.GetString("RadLabel13.RootElement.AccessibleName")
            RadLabel13.RootElement.Alignment = CType(resources.GetObject("RadLabel13.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel13.RootElement.AngleTransform = CType(resources.GetObject("RadLabel13.RootElement.AngleTransform"), Single)
            RadLabel13.RootElement.FlipText = CType(resources.GetObject("RadLabel13.RootElement.FlipText"), Boolean)
            RadLabel13.RootElement.Margin = CType(resources.GetObject("RadLabel13.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel13.RootElement.Padding = CType(resources.GetObject("RadLabel13.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel13.RootElement.Text = resources.GetString("RadLabel13.RootElement.Text")
            RadLabel13.RootElement.TextOrientation = CType(resources.GetObject("RadLabel13.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'grpbPrecio
            '
            Me.grpbPrecio.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.grpbPrecio.Controls.Add(Me.spinPrecioVenta)
            Me.grpbPrecio.Controls.Add(RadLabel11)
            Me.grpbPrecio.Controls.Add(Me.spinPrecioCoste)
            Me.grpbPrecio.Controls.Add(RadLabel13)
            resources.ApplyResources(Me.grpbPrecio, "grpbPrecio")
            Me.grpbPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.grpbPrecio.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            Me.grpbPrecio.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far
            Me.grpbPrecio.HeaderTextAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.grpbPrecio.Name = "grpbPrecio"
            '
            '
            '
            Me.grpbPrecio.RootElement.AccessibleDescription = resources.GetString("grpbPrecio.RootElement.AccessibleDescription")
            Me.grpbPrecio.RootElement.AccessibleName = resources.GetString("grpbPrecio.RootElement.AccessibleName")
            Me.grpbPrecio.RootElement.Alignment = CType(resources.GetObject("grpbPrecio.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.grpbPrecio.RootElement.AngleTransform = CType(resources.GetObject("grpbPrecio.RootElement.AngleTransform"), Single)
            Me.grpbPrecio.RootElement.FlipText = CType(resources.GetObject("grpbPrecio.RootElement.FlipText"), Boolean)
            Me.grpbPrecio.RootElement.Margin = CType(resources.GetObject("grpbPrecio.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.grpbPrecio.RootElement.Padding = CType(resources.GetObject("grpbPrecio.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.grpbPrecio.RootElement.Text = resources.GetString("grpbPrecio.RootElement.Text")
            Me.grpbPrecio.RootElement.TextOrientation = CType(resources.GetObject("grpbPrecio.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.grpbPrecio.TabStop = False
            CType(Me.grpbPrecio.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far
            CType(Me.grpbPrecio.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).Padding = CType(resources.GetObject("resource.Padding"), System.Windows.Forms.Padding)
            CType(Me.grpbPrecio.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            CType(Me.grpbPrecio.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            '
            'spinPrecioVenta
            '
            Me.spinPrecioVenta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosBindingSource, "PrecioVenta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.spinPrecioVenta, "spinPrecioVenta")
            Me.spinPrecioVenta.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinPrecioVenta.Name = "spinPrecioVenta"
            '
            '
            '
            Me.spinPrecioVenta.RootElement.AccessibleDescription = resources.GetString("spinPrecioVenta.RootElement.AccessibleDescription")
            Me.spinPrecioVenta.RootElement.AccessibleName = resources.GetString("spinPrecioVenta.RootElement.AccessibleName")
            Me.spinPrecioVenta.RootElement.Alignment = CType(resources.GetObject("spinPrecioVenta.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.spinPrecioVenta.RootElement.AngleTransform = CType(resources.GetObject("spinPrecioVenta.RootElement.AngleTransform"), Single)
            Me.spinPrecioVenta.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.spinPrecioVenta.RootElement.FlipText = CType(resources.GetObject("spinPrecioVenta.RootElement.FlipText"), Boolean)
            Me.spinPrecioVenta.RootElement.Margin = CType(resources.GetObject("spinPrecioVenta.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.spinPrecioVenta.RootElement.Padding = CType(resources.GetObject("spinPrecioVenta.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.spinPrecioVenta.RootElement.Text = resources.GetString("spinPrecioVenta.RootElement.Text")
            Me.spinPrecioVenta.RootElement.TextOrientation = CType(resources.GetObject("spinPrecioVenta.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.spinPrecioVenta.ShowUpDownButtons = False
            Me.spinPrecioVenta.TabStop = False
            Me.spinPrecioVenta.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.spinPrecioVenta.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'ProductosBindingSource
            '
            Me.ProductosBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Productos)
            '
            'spinPrecioCoste
            '
            Me.spinPrecioCoste.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosBindingSource, "Coste", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.spinPrecioCoste, "spinPrecioCoste")
            Me.spinPrecioCoste.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinPrecioCoste.Name = "spinPrecioCoste"
            '
            '
            '
            Me.spinPrecioCoste.RootElement.AccessibleDescription = resources.GetString("spinPrecioCoste.RootElement.AccessibleDescription")
            Me.spinPrecioCoste.RootElement.AccessibleName = resources.GetString("spinPrecioCoste.RootElement.AccessibleName")
            Me.spinPrecioCoste.RootElement.Alignment = CType(resources.GetObject("spinPrecioCoste.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.spinPrecioCoste.RootElement.AngleTransform = CType(resources.GetObject("spinPrecioCoste.RootElement.AngleTransform"), Single)
            Me.spinPrecioCoste.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.spinPrecioCoste.RootElement.FlipText = CType(resources.GetObject("spinPrecioCoste.RootElement.FlipText"), Boolean)
            Me.spinPrecioCoste.RootElement.Margin = CType(resources.GetObject("spinPrecioCoste.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.spinPrecioCoste.RootElement.Padding = CType(resources.GetObject("spinPrecioCoste.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.spinPrecioCoste.RootElement.Text = resources.GetString("spinPrecioCoste.RootElement.Text")
            Me.spinPrecioCoste.RootElement.TextOrientation = CType(resources.GetObject("spinPrecioCoste.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.spinPrecioCoste.ShowUpDownButtons = False
            Me.spinPrecioCoste.TabStop = False
            Me.spinPrecioCoste.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.spinPrecioCoste.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'grpbStock
            '
            Me.grpbStock.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.grpbStock.Controls.Add(Me.spinStockPaquete)
            Me.grpbStock.Controls.Add(Me.spinStock)
            Me.grpbStock.Controls.Add(RadLabel14)
            Me.grpbStock.Controls.Add(RadLabel15)
            resources.ApplyResources(Me.grpbStock, "grpbStock")
            Me.grpbStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.grpbStock.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            Me.grpbStock.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far
            Me.grpbStock.HeaderTextAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.grpbStock.Name = "grpbStock"
            '
            '
            '
            Me.grpbStock.RootElement.AccessibleDescription = resources.GetString("grpbStock.RootElement.AccessibleDescription")
            Me.grpbStock.RootElement.AccessibleName = resources.GetString("grpbStock.RootElement.AccessibleName")
            Me.grpbStock.RootElement.Alignment = CType(resources.GetObject("grpbStock.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.grpbStock.RootElement.AngleTransform = CType(resources.GetObject("grpbStock.RootElement.AngleTransform"), Single)
            Me.grpbStock.RootElement.FlipText = CType(resources.GetObject("grpbStock.RootElement.FlipText"), Boolean)
            Me.grpbStock.RootElement.Margin = CType(resources.GetObject("grpbStock.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.grpbStock.RootElement.Padding = CType(resources.GetObject("grpbStock.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.grpbStock.RootElement.Text = resources.GetString("grpbStock.RootElement.Text")
            Me.grpbStock.RootElement.TextOrientation = CType(resources.GetObject("grpbStock.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.grpbStock.TabStop = False
            CType(Me.grpbStock.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far
            CType(Me.grpbStock.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).Padding = CType(resources.GetObject("resource.Padding1"), System.Windows.Forms.Padding)
            CType(Me.grpbStock.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            CType(Me.grpbStock.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            '
            'spinStockPaquete
            '
            Me.spinStockPaquete.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosBindingSource, "StockCaja", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.spinStockPaquete, "spinStockPaquete")
            Me.spinStockPaquete.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinStockPaquete.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
            Me.spinStockPaquete.Name = "spinStockPaquete"
            '
            '
            '
            Me.spinStockPaquete.RootElement.AccessibleDescription = resources.GetString("spinStockPaquete.RootElement.AccessibleDescription")
            Me.spinStockPaquete.RootElement.AccessibleName = resources.GetString("spinStockPaquete.RootElement.AccessibleName")
            Me.spinStockPaquete.RootElement.Alignment = CType(resources.GetObject("spinStockPaquete.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.spinStockPaquete.RootElement.AngleTransform = CType(resources.GetObject("spinStockPaquete.RootElement.AngleTransform"), Single)
            Me.spinStockPaquete.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.spinStockPaquete.RootElement.FlipText = CType(resources.GetObject("spinStockPaquete.RootElement.FlipText"), Boolean)
            Me.spinStockPaquete.RootElement.Margin = CType(resources.GetObject("spinStockPaquete.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.spinStockPaquete.RootElement.Padding = CType(resources.GetObject("spinStockPaquete.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.spinStockPaquete.RootElement.Text = resources.GetString("spinStockPaquete.RootElement.Text")
            Me.spinStockPaquete.RootElement.TextOrientation = CType(resources.GetObject("spinStockPaquete.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.spinStockPaquete.ShowUpDownButtons = False
            Me.spinStockPaquete.TabStop = False
            Me.spinStockPaquete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.spinStockPaquete.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'spinStock
            '
            Me.spinStock.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosBindingSource, "StockSuelto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.spinStock, "spinStock")
            Me.spinStock.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.spinStock.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
            Me.spinStock.Name = "spinStock"
            '
            '
            '
            Me.spinStock.RootElement.AccessibleDescription = resources.GetString("spinStock.RootElement.AccessibleDescription")
            Me.spinStock.RootElement.AccessibleName = resources.GetString("spinStock.RootElement.AccessibleName")
            Me.spinStock.RootElement.Alignment = CType(resources.GetObject("spinStock.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.spinStock.RootElement.AngleTransform = CType(resources.GetObject("spinStock.RootElement.AngleTransform"), Single)
            Me.spinStock.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.spinStock.RootElement.FlipText = CType(resources.GetObject("spinStock.RootElement.FlipText"), Boolean)
            Me.spinStock.RootElement.Margin = CType(resources.GetObject("spinStock.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.spinStock.RootElement.Padding = CType(resources.GetObject("spinStock.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.spinStock.RootElement.Text = resources.GetString("spinStock.RootElement.Text")
            Me.spinStock.RootElement.TextOrientation = CType(resources.GetObject("spinStock.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.spinStock.ShowUpDownButtons = False
            Me.spinStock.TabStop = False
            Me.spinStock.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.spinStock.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'UnidadesMedidaBindingSource
            '
            Me.UnidadesMedidaBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.UnidadesMedida)
            Me.UnidadesMedidaBindingSource.Sort = ""
            '
            'FamiliasBindingSource
            '
            Me.FamiliasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Familias)
            '
            'ddlTipoImpuesto
            '
            Me.ddlTipoImpuesto.AllowShowFocusCues = True
            Me.ddlTipoImpuesto.AutoCompleteDisplayMember = "Impuesto"
            Me.ddlTipoImpuesto.AutoCompleteValueMember = "idImpuesto"
            Me.ddlTipoImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "idImpuesto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlTipoImpuesto.DataSource = Me.ImpuestosBindingSource
            Me.ddlTipoImpuesto.DisplayMember = "Impuesto"
            Me.ddlTipoImpuesto.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlTipoImpuesto.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
            Me.ddlTipoImpuesto.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            resources.ApplyResources(Me.ddlTipoImpuesto, "ddlTipoImpuesto")
            Me.ddlTipoImpuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlTipoImpuesto.Name = "ddlTipoImpuesto"
            '
            '
            '
            Me.ddlTipoImpuesto.RootElement.AccessibleDescription = resources.GetString("ddlTipoImpuesto.RootElement.AccessibleDescription")
            Me.ddlTipoImpuesto.RootElement.AccessibleName = resources.GetString("ddlTipoImpuesto.RootElement.AccessibleName")
            Me.ddlTipoImpuesto.RootElement.Alignment = CType(resources.GetObject("ddlTipoImpuesto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlTipoImpuesto.RootElement.AngleTransform = CType(resources.GetObject("ddlTipoImpuesto.RootElement.AngleTransform"), Single)
            Me.ddlTipoImpuesto.RootElement.FlipText = CType(resources.GetObject("ddlTipoImpuesto.RootElement.FlipText"), Boolean)
            Me.ddlTipoImpuesto.RootElement.Margin = CType(resources.GetObject("ddlTipoImpuesto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlTipoImpuesto.RootElement.Padding = CType(resources.GetObject("ddlTipoImpuesto.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ddlTipoImpuesto.RootElement.Text = resources.GetString("ddlTipoImpuesto.RootElement.Text")
            Me.ddlTipoImpuesto.RootElement.TextOrientation = CType(resources.GetObject("ddlTipoImpuesto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ddlTipoImpuesto.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlTipoImpuesto.ValueMember = "idImpuesto"
            CType(Me.ddlTipoImpuesto.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            CType(Me.ddlTipoImpuesto.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.ddlTipoImpuesto.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).ShouldPaint = False
            CType(Me.ddlTipoImpuesto.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            CType(Me.ddlTipoImpuesto.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).CanFocus = False
            '
            'ImpuestosBindingSource
            '
            Me.ImpuestosBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Impuestos)
            '
            'txtNombre
            '
            Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripcion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtNombre, "txtNombre")
            Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtNombre.Name = "txtNombre"
            '
            '
            '
            Me.txtNombre.RootElement.AccessibleDescription = resources.GetString("txtNombre.RootElement.AccessibleDescription")
            Me.txtNombre.RootElement.AccessibleName = resources.GetString("txtNombre.RootElement.AccessibleName")
            Me.txtNombre.RootElement.Alignment = CType(resources.GetObject("txtNombre.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtNombre.RootElement.AngleTransform = CType(resources.GetObject("txtNombre.RootElement.AngleTransform"), Single)
            Me.txtNombre.RootElement.FlipText = CType(resources.GetObject("txtNombre.RootElement.FlipText"), Boolean)
            Me.txtNombre.RootElement.Margin = CType(resources.GetObject("txtNombre.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtNombre.RootElement.Padding = CType(resources.GetObject("txtNombre.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtNombre.RootElement.Text = resources.GetString("txtNombre.RootElement.Text")
            Me.txtNombre.RootElement.TextOrientation = CType(resources.GetObject("txtNombre.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtNombre.Tag = ""
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text")
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'txtNombreChino
            '
            resources.ApplyResources(Me.txtNombreChino, "txtNombreChino")
            Me.txtNombreChino.BackColor = System.Drawing.Color.White
            Me.txtNombreChino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "DescripcionLarga", True))
            Me.txtNombreChino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtNombreChino.Multiline = True
            Me.txtNombreChino.Name = "txtNombreChino"
            '
            '
            '
            Me.txtNombreChino.RootElement.AccessibleDescription = resources.GetString("txtNombreChino.RootElement.AccessibleDescription")
            Me.txtNombreChino.RootElement.AccessibleName = resources.GetString("txtNombreChino.RootElement.AccessibleName")
            Me.txtNombreChino.RootElement.Alignment = CType(resources.GetObject("txtNombreChino.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtNombreChino.RootElement.AngleTransform = CType(resources.GetObject("txtNombreChino.RootElement.AngleTransform"), Single)
            Me.txtNombreChino.RootElement.ApplyShapeToControl = False
            Me.txtNombreChino.RootElement.FlipText = CType(resources.GetObject("txtNombreChino.RootElement.FlipText"), Boolean)
            Me.txtNombreChino.RootElement.Margin = CType(resources.GetObject("txtNombreChino.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtNombreChino.RootElement.Padding = CType(resources.GetObject("txtNombreChino.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtNombreChino.RootElement.Text = resources.GetString("txtNombreChino.RootElement.Text")
            Me.txtNombreChino.RootElement.TextOrientation = CType(resources.GetObject("txtNombreChino.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtNombreChino.Tag = ""
            CType(Me.txtNombreChino.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text1")
            CType(Me.txtNombreChino.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNombreChino.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.White
            CType(Me.txtNombreChino.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNombreChino.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
            CType(Me.txtNombreChino.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtNombreChino.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
            CType(Me.txtNombreChino.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.White
            '
            'timValidar
            '
            '
            'txtObservacion
            '
            Me.txtObservacion.AcceptsReturn = True
            resources.ApplyResources(Me.txtObservacion, "txtObservacion")
            Me.txtObservacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Observacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtObservacion.Multiline = True
            Me.txtObservacion.Name = "txtObservacion"
            '
            '
            '
            Me.txtObservacion.RootElement.AccessibleDescription = resources.GetString("txtObservacion.RootElement.AccessibleDescription")
            Me.txtObservacion.RootElement.AccessibleName = resources.GetString("txtObservacion.RootElement.AccessibleName")
            Me.txtObservacion.RootElement.Alignment = CType(resources.GetObject("txtObservacion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtObservacion.RootElement.AngleTransform = CType(resources.GetObject("txtObservacion.RootElement.AngleTransform"), Single)
            Me.txtObservacion.RootElement.ApplyShapeToControl = False
            Me.txtObservacion.RootElement.FlipText = CType(resources.GetObject("txtObservacion.RootElement.FlipText"), Boolean)
            Me.txtObservacion.RootElement.Margin = CType(resources.GetObject("txtObservacion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtObservacion.RootElement.Padding = CType(resources.GetObject("txtObservacion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtObservacion.RootElement.Text = resources.GetString("txtObservacion.RootElement.Text")
            Me.txtObservacion.RootElement.TextOrientation = CType(resources.GetObject("txtObservacion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtObservacion.Tag = ""
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text2")
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = True
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtReferencia
            '
            Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtReferencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Referencia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtReferencia, "txtReferencia")
            Me.txtReferencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtReferencia.Name = "txtReferencia"
            '
            '
            '
            Me.txtReferencia.RootElement.AccessibleDescription = resources.GetString("txtReferencia.RootElement.AccessibleDescription")
            Me.txtReferencia.RootElement.AccessibleName = resources.GetString("txtReferencia.RootElement.AccessibleName")
            Me.txtReferencia.RootElement.Alignment = CType(resources.GetObject("txtReferencia.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtReferencia.RootElement.AngleTransform = CType(resources.GetObject("txtReferencia.RootElement.AngleTransform"), Single)
            Me.txtReferencia.RootElement.FlipText = CType(resources.GetObject("txtReferencia.RootElement.FlipText"), Boolean)
            Me.txtReferencia.RootElement.Margin = CType(resources.GetObject("txtReferencia.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtReferencia.RootElement.Padding = CType(resources.GetObject("txtReferencia.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtReferencia.RootElement.Text = resources.GetString("txtReferencia.RootElement.Text")
            Me.txtReferencia.RootElement.TextOrientation = CType(resources.GetObject("txtReferencia.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtReferencia.Tag = ""
            CType(Me.txtReferencia.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text3")
            CType(Me.txtReferencia.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtReferencia.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtReferencia.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtReferencia.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtReferencia.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'MarcasBindingSource
            '
            Me.MarcasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Marcas)
            Me.MarcasBindingSource.Sort = ""
            '
            'txtDescuento
            '
            Me.txtDescuento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosBindingSource, "Descuento", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtDescuento, "txtDescuento")
            Me.txtDescuento.Name = "txtDescuento"
            '
            '
            '
            Me.txtDescuento.RootElement.AccessibleDescription = resources.GetString("txtDescuento.RootElement.AccessibleDescription")
            Me.txtDescuento.RootElement.AccessibleName = resources.GetString("txtDescuento.RootElement.AccessibleName")
            Me.txtDescuento.RootElement.Alignment = CType(resources.GetObject("txtDescuento.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtDescuento.RootElement.AngleTransform = CType(resources.GetObject("txtDescuento.RootElement.AngleTransform"), Single)
            Me.txtDescuento.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.txtDescuento.RootElement.FlipText = CType(resources.GetObject("txtDescuento.RootElement.FlipText"), Boolean)
            Me.txtDescuento.RootElement.Margin = CType(resources.GetObject("txtDescuento.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtDescuento.RootElement.Padding = CType(resources.GetObject("txtDescuento.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtDescuento.RootElement.Text = resources.GetString("txtDescuento.RootElement.Text")
            Me.txtDescuento.RootElement.TextOrientation = CType(resources.GetObject("txtDescuento.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtDescuento.ShowUpDownButtons = False
            Me.txtDescuento.TabStop = False
            Me.txtDescuento.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtDescuento.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'spinUnidadVenta
            '
            Me.spinUnidadVenta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosBindingSource, "UnidadVenta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.spinUnidadVenta, "spinUnidadVenta")
            Me.spinUnidadVenta.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinUnidadVenta.Name = "spinUnidadVenta"
            '
            '
            '
            Me.spinUnidadVenta.RootElement.AccessibleDescription = resources.GetString("spinUnidadVenta.RootElement.AccessibleDescription")
            Me.spinUnidadVenta.RootElement.AccessibleName = resources.GetString("spinUnidadVenta.RootElement.AccessibleName")
            Me.spinUnidadVenta.RootElement.Alignment = CType(resources.GetObject("spinUnidadVenta.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.spinUnidadVenta.RootElement.AngleTransform = CType(resources.GetObject("spinUnidadVenta.RootElement.AngleTransform"), Single)
            Me.spinUnidadVenta.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.spinUnidadVenta.RootElement.FlipText = CType(resources.GetObject("spinUnidadVenta.RootElement.FlipText"), Boolean)
            Me.spinUnidadVenta.RootElement.Margin = CType(resources.GetObject("spinUnidadVenta.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.spinUnidadVenta.RootElement.Padding = CType(resources.GetObject("spinUnidadVenta.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.spinUnidadVenta.RootElement.Text = resources.GetString("spinUnidadVenta.RootElement.Text")
            Me.spinUnidadVenta.RootElement.TextOrientation = CType(resources.GetObject("spinUnidadVenta.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.spinUnidadVenta.ShowUpDownButtons = False
            Me.spinUnidadVenta.TabStop = False
            Me.spinUnidadVenta.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.spinUnidadVenta.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'spinUnidadPaquete
            '
            Me.spinUnidadPaquete.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductosBindingSource, "UnidadXCaja", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.spinUnidadPaquete, "spinUnidadPaquete")
            Me.spinUnidadPaquete.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinUnidadPaquete.Name = "spinUnidadPaquete"
            '
            '
            '
            Me.spinUnidadPaquete.RootElement.AccessibleDescription = resources.GetString("spinUnidadPaquete.RootElement.AccessibleDescription")
            Me.spinUnidadPaquete.RootElement.AccessibleName = resources.GetString("spinUnidadPaquete.RootElement.AccessibleName")
            Me.spinUnidadPaquete.RootElement.Alignment = CType(resources.GetObject("spinUnidadPaquete.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.spinUnidadPaquete.RootElement.AngleTransform = CType(resources.GetObject("spinUnidadPaquete.RootElement.AngleTransform"), Single)
            Me.spinUnidadPaquete.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.spinUnidadPaquete.RootElement.FlipText = CType(resources.GetObject("spinUnidadPaquete.RootElement.FlipText"), Boolean)
            Me.spinUnidadPaquete.RootElement.Margin = CType(resources.GetObject("spinUnidadPaquete.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.spinUnidadPaquete.RootElement.Padding = CType(resources.GetObject("spinUnidadPaquete.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.spinUnidadPaquete.RootElement.Text = resources.GetString("spinUnidadPaquete.RootElement.Text")
            Me.spinUnidadPaquete.RootElement.TextOrientation = CType(resources.GetObject("spinUnidadPaquete.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.spinUnidadPaquete.ShowUpDownButtons = False
            Me.spinUnidadPaquete.TabStop = False
            Me.spinUnidadPaquete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.spinUnidadPaquete.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'chkPrecioVariable
            '
            Me.chkPrecioVariable.CheckAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkPrecioVariable.DataBindings.Add(New System.Windows.Forms.Binding("IsChecked", Me.ProductosBindingSource, "PrecioVariable", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.chkPrecioVariable, "chkPrecioVariable")
            Me.chkPrecioVariable.Name = "chkPrecioVariable"
            '
            '
            '
            Me.chkPrecioVariable.RootElement.AccessibleDescription = resources.GetString("chkPrecioVariable.RootElement.AccessibleDescription")
            Me.chkPrecioVariable.RootElement.AccessibleName = resources.GetString("chkPrecioVariable.RootElement.AccessibleName")
            Me.chkPrecioVariable.RootElement.Alignment = CType(resources.GetObject("chkPrecioVariable.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.chkPrecioVariable.RootElement.AngleTransform = CType(resources.GetObject("chkPrecioVariable.RootElement.AngleTransform"), Single)
            Me.chkPrecioVariable.RootElement.FlipText = CType(resources.GetObject("chkPrecioVariable.RootElement.FlipText"), Boolean)
            Me.chkPrecioVariable.RootElement.Margin = CType(resources.GetObject("chkPrecioVariable.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.chkPrecioVariable.RootElement.Padding = CType(resources.GetObject("chkPrecioVariable.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.chkPrecioVariable.RootElement.Text = resources.GetString("chkPrecioVariable.RootElement.Text")
            Me.chkPrecioVariable.RootElement.TextOrientation = CType(resources.GetObject("chkPrecioVariable.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.chkPrecioVariable.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).CheckAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.chkPrecioVariable.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).Text = resources.GetString("resource.Text4")
            CType(Me.chkPrecioVariable.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            CType(Me.chkPrecioVariable.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Black
            '
            'chkControlStock
            '
            Me.chkControlStock.CheckAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkControlStock.DataBindings.Add(New System.Windows.Forms.Binding("IsChecked", Me.ProductosBindingSource, "ControlStock", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.chkControlStock, "chkControlStock")
            Me.chkControlStock.Name = "chkControlStock"
            '
            '
            '
            Me.chkControlStock.RootElement.AccessibleDescription = resources.GetString("chkControlStock.RootElement.AccessibleDescription")
            Me.chkControlStock.RootElement.AccessibleName = resources.GetString("chkControlStock.RootElement.AccessibleName")
            Me.chkControlStock.RootElement.Alignment = CType(resources.GetObject("chkControlStock.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.chkControlStock.RootElement.AngleTransform = CType(resources.GetObject("chkControlStock.RootElement.AngleTransform"), Single)
            Me.chkControlStock.RootElement.FlipText = CType(resources.GetObject("chkControlStock.RootElement.FlipText"), Boolean)
            Me.chkControlStock.RootElement.Margin = CType(resources.GetObject("chkControlStock.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.chkControlStock.RootElement.Padding = CType(resources.GetObject("chkControlStock.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.chkControlStock.RootElement.Text = resources.GetString("chkControlStock.RootElement.Text")
            Me.chkControlStock.RootElement.TextOrientation = CType(resources.GetObject("chkControlStock.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.chkControlStock.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).CheckAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.chkControlStock.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).Text = resources.GetString("resource.Text5")
            CType(Me.chkControlStock.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            CType(Me.chkControlStock.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            '
            'UbicacionesBindingSource
            '
            Me.UbicacionesBindingSource.AllowNew = True
            Me.UbicacionesBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Ubicaciones)
            Me.UbicacionesBindingSource.Sort = ""
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
            Me.SplitPanel1.Controls.Add(Me.toggleCodigoBarra)
            Me.SplitPanel1.Controls.Add(RadLabel3)
            Me.SplitPanel1.Controls.Add(Me.btnQuitarUbicacion)
            Me.SplitPanel1.Controls.Add(RadLabel1)
            Me.SplitPanel1.Controls.Add(Me.btnQuitarUnidad)
            Me.SplitPanel1.Controls.Add(Me.txtNombre)
            Me.SplitPanel1.Controls.Add(Me.btnQuitarMarca)
            Me.SplitPanel1.Controls.Add(Me.txtReferencia)
            Me.SplitPanel1.Controls.Add(Me.btnQuitarFamilia)
            Me.SplitPanel1.Controls.Add(RadLabel4)
            Me.SplitPanel1.Controls.Add(Me.btnGenerarReferencia)
            Me.SplitPanel1.Controls.Add(RadLabel8)
            Me.SplitPanel1.Controls.Add(Me.chkControlStock)
            Me.SplitPanel1.Controls.Add(RadLabel5)
            Me.SplitPanel1.Controls.Add(Me.chkPrecioVariable)
            Me.SplitPanel1.Controls.Add(RadLabel9)
            Me.SplitPanel1.Controls.Add(Me.spinUnidadPaquete)
            Me.SplitPanel1.Controls.Add(RadLabel10)
            Me.SplitPanel1.Controls.Add(Me.spinUnidadVenta)
            Me.SplitPanel1.Controls.Add(Me.ddlUnidadMedida)
            Me.SplitPanel1.Controls.Add(Me.ddlFamilia)
            Me.SplitPanel1.Controls.Add(Me.ddlUbicacion)
            Me.SplitPanel1.Controls.Add(Me.ddlMarca)
            Me.SplitPanel1.Controls.Add(Me.ddlTipoImpuesto)
            Me.SplitPanel1.Controls.Add(Me.txtDescuento)
            Me.SplitPanel1.Controls.Add(Me.grpbPrecio)
            Me.SplitPanel1.Controls.Add(Me.grpbStock)
            Me.SplitPanel1.Controls.Add(RadLabel7)
            Me.SplitPanel1.Controls.Add(RadLabel18)
            Me.SplitPanel1.Controls.Add(RadLabel17)
            Me.SplitPanel1.Controls.Add(Me.txtObservacion)
            Me.SplitPanel1.Controls.Add(RadLabel2)
            Me.SplitPanel1.Controls.Add(Me.txtNombreChino)
            Me.SplitPanel1.Controls.Add(RadLabel12)
            Me.SplitPanel1.Controls.Add(RadLabel20)
            Me.SplitPanel1.Controls.Add(RadLabel6)
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
            Me.SplitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.2327707!, 0.0!)
            Me.SplitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(32, 0)
            Me.SplitPanel1.TabStop = False
            '
            'toggleCodigoBarra
            '
            resources.ApplyResources(Me.toggleCodigoBarra, "toggleCodigoBarra")
            Me.toggleCodigoBarra.Image = Global.EasyGest.My.Resources.Resources.application_go
            Me.toggleCodigoBarra.Name = "toggleCodigoBarra"
            '
            '
            '
            Me.toggleCodigoBarra.RootElement.AccessibleDescription = resources.GetString("toggleCodigoBarra.RootElement.AccessibleDescription")
            Me.toggleCodigoBarra.RootElement.AccessibleName = resources.GetString("toggleCodigoBarra.RootElement.AccessibleName")
            Me.toggleCodigoBarra.RootElement.Alignment = CType(resources.GetObject("toggleCodigoBarra.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.toggleCodigoBarra.RootElement.AngleTransform = CType(resources.GetObject("toggleCodigoBarra.RootElement.AngleTransform"), Single)
            Me.toggleCodigoBarra.RootElement.FlipText = CType(resources.GetObject("toggleCodigoBarra.RootElement.FlipText"), Boolean)
            Me.toggleCodigoBarra.RootElement.Margin = CType(resources.GetObject("toggleCodigoBarra.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.toggleCodigoBarra.RootElement.Padding = CType(resources.GetObject("toggleCodigoBarra.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.toggleCodigoBarra.RootElement.Text = resources.GetString("toggleCodigoBarra.RootElement.Text")
            Me.toggleCodigoBarra.RootElement.TextOrientation = CType(resources.GetObject("toggleCodigoBarra.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.toggleCodigoBarra.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Image = Global.EasyGest.My.Resources.Resources.application_go
            CType(Me.toggleCodigoBarra.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.toggleCodigoBarra.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            CType(Me.toggleCodigoBarra.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Text = resources.GetString("resource.Text6")
            CType(Me.toggleCodigoBarra.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(253, Byte), Integer))
            CType(Me.toggleCodigoBarra.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.toggleCodigoBarra.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.toggleCodigoBarra.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'btnQuitarUbicacion
            '
            resources.ApplyResources(Me.btnQuitarUbicacion, "btnQuitarUbicacion")
            Me.btnQuitarUbicacion.Name = "btnQuitarUbicacion"
            '
            '
            '
            Me.btnQuitarUbicacion.RootElement.AccessibleDescription = resources.GetString("btnQuitarUbicacion.RootElement.AccessibleDescription")
            Me.btnQuitarUbicacion.RootElement.AccessibleName = resources.GetString("btnQuitarUbicacion.RootElement.AccessibleName")
            Me.btnQuitarUbicacion.RootElement.Alignment = CType(resources.GetObject("btnQuitarUbicacion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnQuitarUbicacion.RootElement.AngleTransform = CType(resources.GetObject("btnQuitarUbicacion.RootElement.AngleTransform"), Single)
            Me.btnQuitarUbicacion.RootElement.FlipText = CType(resources.GetObject("btnQuitarUbicacion.RootElement.FlipText"), Boolean)
            Me.btnQuitarUbicacion.RootElement.Margin = CType(resources.GetObject("btnQuitarUbicacion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnQuitarUbicacion.RootElement.Padding = CType(resources.GetObject("btnQuitarUbicacion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnQuitarUbicacion.RootElement.Text = resources.GetString("btnQuitarUbicacion.RootElement.Text")
            Me.btnQuitarUbicacion.RootElement.TextOrientation = CType(resources.GetObject("btnQuitarUbicacion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'btnQuitarUnidad
            '
            resources.ApplyResources(Me.btnQuitarUnidad, "btnQuitarUnidad")
            Me.btnQuitarUnidad.Name = "btnQuitarUnidad"
            '
            '
            '
            Me.btnQuitarUnidad.RootElement.AccessibleDescription = resources.GetString("btnQuitarUnidad.RootElement.AccessibleDescription")
            Me.btnQuitarUnidad.RootElement.AccessibleName = resources.GetString("btnQuitarUnidad.RootElement.AccessibleName")
            Me.btnQuitarUnidad.RootElement.Alignment = CType(resources.GetObject("btnQuitarUnidad.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnQuitarUnidad.RootElement.AngleTransform = CType(resources.GetObject("btnQuitarUnidad.RootElement.AngleTransform"), Single)
            Me.btnQuitarUnidad.RootElement.FlipText = CType(resources.GetObject("btnQuitarUnidad.RootElement.FlipText"), Boolean)
            Me.btnQuitarUnidad.RootElement.Margin = CType(resources.GetObject("btnQuitarUnidad.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnQuitarUnidad.RootElement.Padding = CType(resources.GetObject("btnQuitarUnidad.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnQuitarUnidad.RootElement.Text = resources.GetString("btnQuitarUnidad.RootElement.Text")
            Me.btnQuitarUnidad.RootElement.TextOrientation = CType(resources.GetObject("btnQuitarUnidad.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'btnQuitarMarca
            '
            resources.ApplyResources(Me.btnQuitarMarca, "btnQuitarMarca")
            Me.btnQuitarMarca.Name = "btnQuitarMarca"
            '
            '
            '
            Me.btnQuitarMarca.RootElement.AccessibleDescription = resources.GetString("btnQuitarMarca.RootElement.AccessibleDescription")
            Me.btnQuitarMarca.RootElement.AccessibleName = resources.GetString("btnQuitarMarca.RootElement.AccessibleName")
            Me.btnQuitarMarca.RootElement.Alignment = CType(resources.GetObject("btnQuitarMarca.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnQuitarMarca.RootElement.AngleTransform = CType(resources.GetObject("btnQuitarMarca.RootElement.AngleTransform"), Single)
            Me.btnQuitarMarca.RootElement.FlipText = CType(resources.GetObject("btnQuitarMarca.RootElement.FlipText"), Boolean)
            Me.btnQuitarMarca.RootElement.Margin = CType(resources.GetObject("btnQuitarMarca.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnQuitarMarca.RootElement.Padding = CType(resources.GetObject("btnQuitarMarca.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnQuitarMarca.RootElement.Text = resources.GetString("btnQuitarMarca.RootElement.Text")
            Me.btnQuitarMarca.RootElement.TextOrientation = CType(resources.GetObject("btnQuitarMarca.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'btnQuitarFamilia
            '
            resources.ApplyResources(Me.btnQuitarFamilia, "btnQuitarFamilia")
            Me.btnQuitarFamilia.Name = "btnQuitarFamilia"
            '
            '
            '
            Me.btnQuitarFamilia.RootElement.AccessibleDescription = resources.GetString("btnQuitarFamilia.RootElement.AccessibleDescription")
            Me.btnQuitarFamilia.RootElement.AccessibleName = resources.GetString("btnQuitarFamilia.RootElement.AccessibleName")
            Me.btnQuitarFamilia.RootElement.Alignment = CType(resources.GetObject("btnQuitarFamilia.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnQuitarFamilia.RootElement.AngleTransform = CType(resources.GetObject("btnQuitarFamilia.RootElement.AngleTransform"), Single)
            Me.btnQuitarFamilia.RootElement.FlipText = CType(resources.GetObject("btnQuitarFamilia.RootElement.FlipText"), Boolean)
            Me.btnQuitarFamilia.RootElement.Margin = CType(resources.GetObject("btnQuitarFamilia.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnQuitarFamilia.RootElement.Padding = CType(resources.GetObject("btnQuitarFamilia.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnQuitarFamilia.RootElement.Text = resources.GetString("btnQuitarFamilia.RootElement.Text")
            Me.btnQuitarFamilia.RootElement.TextOrientation = CType(resources.GetObject("btnQuitarFamilia.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'btnGenerarReferencia
            '
            Me.btnGenerarReferencia.Image = Global.EasyGest.My.Resources.Resources.cog
            resources.ApplyResources(Me.btnGenerarReferencia, "btnGenerarReferencia")
            Me.btnGenerarReferencia.Name = "btnGenerarReferencia"
            '
            '
            '
            Me.btnGenerarReferencia.RootElement.AccessibleDescription = resources.GetString("btnGenerarReferencia.RootElement.AccessibleDescription")
            Me.btnGenerarReferencia.RootElement.AccessibleName = resources.GetString("btnGenerarReferencia.RootElement.AccessibleName")
            Me.btnGenerarReferencia.RootElement.Alignment = CType(resources.GetObject("btnGenerarReferencia.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnGenerarReferencia.RootElement.AngleTransform = CType(resources.GetObject("btnGenerarReferencia.RootElement.AngleTransform"), Single)
            Me.btnGenerarReferencia.RootElement.FlipText = CType(resources.GetObject("btnGenerarReferencia.RootElement.FlipText"), Boolean)
            Me.btnGenerarReferencia.RootElement.Margin = CType(resources.GetObject("btnGenerarReferencia.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnGenerarReferencia.RootElement.Padding = CType(resources.GetObject("btnGenerarReferencia.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnGenerarReferencia.RootElement.Text = resources.GetString("btnGenerarReferencia.RootElement.Text")
            Me.btnGenerarReferencia.RootElement.TextOrientation = CType(resources.GetObject("btnGenerarReferencia.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'ddlUnidadMedida
            '
            Me.ddlUnidadMedida.AllowShowFocusCues = True
            Me.ddlUnidadMedida.AutoCompleteDisplayMember = "Medida"
            Me.ddlUnidadMedida.AutoCompleteValueMember = "idUnidadMedida"
            Me.ddlUnidadMedida.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "idUnidadMedida", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlUnidadMedida.DataSource = Me.UnidadesMedidaBindingSource
            Me.ddlUnidadMedida.DisplayMember = "Medida"
            Me.ddlUnidadMedida.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlUnidadMedida.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
            Me.ddlUnidadMedida.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            resources.ApplyResources(Me.ddlUnidadMedida, "ddlUnidadMedida")
            Me.ddlUnidadMedida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlUnidadMedida.Name = "ddlUnidadMedida"
            '
            '
            '
            Me.ddlUnidadMedida.RootElement.AccessibleDescription = resources.GetString("ddlUnidadMedida.RootElement.AccessibleDescription")
            Me.ddlUnidadMedida.RootElement.AccessibleName = resources.GetString("ddlUnidadMedida.RootElement.AccessibleName")
            Me.ddlUnidadMedida.RootElement.Alignment = CType(resources.GetObject("ddlUnidadMedida.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlUnidadMedida.RootElement.AngleTransform = CType(resources.GetObject("ddlUnidadMedida.RootElement.AngleTransform"), Single)
            Me.ddlUnidadMedida.RootElement.FlipText = CType(resources.GetObject("ddlUnidadMedida.RootElement.FlipText"), Boolean)
            Me.ddlUnidadMedida.RootElement.Margin = CType(resources.GetObject("ddlUnidadMedida.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlUnidadMedida.RootElement.Padding = CType(resources.GetObject("ddlUnidadMedida.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ddlUnidadMedida.RootElement.Text = resources.GetString("ddlUnidadMedida.RootElement.Text")
            Me.ddlUnidadMedida.RootElement.TextOrientation = CType(resources.GetObject("ddlUnidadMedida.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ddlUnidadMedida.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlUnidadMedida.ValueMember = "idUnidadMedida"
            CType(Me.ddlUnidadMedida.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            CType(Me.ddlUnidadMedida.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.ddlUnidadMedida.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).ShouldPaint = False
            CType(Me.ddlUnidadMedida.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            CType(Me.ddlUnidadMedida.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).CanFocus = False
            '
            'ddlFamilia
            '
            Me.ddlFamilia.AllowShowFocusCues = True
            Me.ddlFamilia.AutoCompleteDisplayMember = "Familia"
            Me.ddlFamilia.AutoCompleteValueMember = "idFamilia"
            Me.ddlFamilia.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "idFamilia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlFamilia.DataSource = Me.FamiliasBindingSource
            Me.ddlFamilia.DisplayMember = "Familia"
            Me.ddlFamilia.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlFamilia.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
            Me.ddlFamilia.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            resources.ApplyResources(Me.ddlFamilia, "ddlFamilia")
            Me.ddlFamilia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlFamilia.Name = "ddlFamilia"
            '
            '
            '
            Me.ddlFamilia.RootElement.AccessibleDescription = resources.GetString("ddlFamilia.RootElement.AccessibleDescription")
            Me.ddlFamilia.RootElement.AccessibleName = resources.GetString("ddlFamilia.RootElement.AccessibleName")
            Me.ddlFamilia.RootElement.Alignment = CType(resources.GetObject("ddlFamilia.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlFamilia.RootElement.AngleTransform = CType(resources.GetObject("ddlFamilia.RootElement.AngleTransform"), Single)
            Me.ddlFamilia.RootElement.FlipText = CType(resources.GetObject("ddlFamilia.RootElement.FlipText"), Boolean)
            Me.ddlFamilia.RootElement.Margin = CType(resources.GetObject("ddlFamilia.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlFamilia.RootElement.Padding = CType(resources.GetObject("ddlFamilia.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ddlFamilia.RootElement.Text = resources.GetString("ddlFamilia.RootElement.Text")
            Me.ddlFamilia.RootElement.TextOrientation = CType(resources.GetObject("ddlFamilia.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ddlFamilia.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlFamilia.ValueMember = "idFamilia"
            CType(Me.ddlFamilia.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            CType(Me.ddlFamilia.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.ddlFamilia.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).ShouldPaint = False
            CType(Me.ddlFamilia.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            CType(Me.ddlFamilia.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).CanFocus = False
            '
            'ddlUbicacion
            '
            Me.ddlUbicacion.AllowShowFocusCues = True
            Me.ddlUbicacion.AutoCompleteDisplayMember = "Ubicacion"
            Me.ddlUbicacion.AutoCompleteValueMember = "idUbicacion"
            Me.ddlUbicacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "idUbicacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlUbicacion.DataSource = Me.UbicacionesBindingSource
            Me.ddlUbicacion.DisplayMember = "Ubicacion"
            Me.ddlUbicacion.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlUbicacion.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
            Me.ddlUbicacion.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            resources.ApplyResources(Me.ddlUbicacion, "ddlUbicacion")
            Me.ddlUbicacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlUbicacion.Name = "ddlUbicacion"
            '
            '
            '
            Me.ddlUbicacion.RootElement.AccessibleDescription = resources.GetString("ddlUbicacion.RootElement.AccessibleDescription")
            Me.ddlUbicacion.RootElement.AccessibleName = resources.GetString("ddlUbicacion.RootElement.AccessibleName")
            Me.ddlUbicacion.RootElement.Alignment = CType(resources.GetObject("ddlUbicacion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlUbicacion.RootElement.AngleTransform = CType(resources.GetObject("ddlUbicacion.RootElement.AngleTransform"), Single)
            Me.ddlUbicacion.RootElement.FlipText = CType(resources.GetObject("ddlUbicacion.RootElement.FlipText"), Boolean)
            Me.ddlUbicacion.RootElement.Margin = CType(resources.GetObject("ddlUbicacion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlUbicacion.RootElement.Padding = CType(resources.GetObject("ddlUbicacion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ddlUbicacion.RootElement.Text = resources.GetString("ddlUbicacion.RootElement.Text")
            Me.ddlUbicacion.RootElement.TextOrientation = CType(resources.GetObject("ddlUbicacion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ddlUbicacion.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlUbicacion.ValueMember = "idUbicacion"
            CType(Me.ddlUbicacion.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            CType(Me.ddlUbicacion.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.ddlUbicacion.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).ShouldPaint = False
            CType(Me.ddlUbicacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            CType(Me.ddlUbicacion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).CanFocus = False
            '
            'ddlMarca
            '
            Me.ddlMarca.AllowShowFocusCues = True
            Me.ddlMarca.AutoCompleteDisplayMember = "Marca"
            Me.ddlMarca.AutoCompleteValueMember = "idMarca"
            Me.ddlMarca.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "idMarca", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlMarca.DataSource = Me.MarcasBindingSource
            Me.ddlMarca.DisplayMember = "Marca"
            Me.ddlMarca.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlMarca.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
            Me.ddlMarca.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            resources.ApplyResources(Me.ddlMarca, "ddlMarca")
            Me.ddlMarca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlMarca.Name = "ddlMarca"
            '
            '
            '
            Me.ddlMarca.RootElement.AccessibleDescription = resources.GetString("ddlMarca.RootElement.AccessibleDescription")
            Me.ddlMarca.RootElement.AccessibleName = resources.GetString("ddlMarca.RootElement.AccessibleName")
            Me.ddlMarca.RootElement.Alignment = CType(resources.GetObject("ddlMarca.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlMarca.RootElement.AngleTransform = CType(resources.GetObject("ddlMarca.RootElement.AngleTransform"), Single)
            Me.ddlMarca.RootElement.FlipText = CType(resources.GetObject("ddlMarca.RootElement.FlipText"), Boolean)
            Me.ddlMarca.RootElement.Margin = CType(resources.GetObject("ddlMarca.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlMarca.RootElement.Padding = CType(resources.GetObject("ddlMarca.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ddlMarca.RootElement.Text = resources.GetString("ddlMarca.RootElement.Text")
            Me.ddlMarca.RootElement.TextOrientation = CType(resources.GetObject("ddlMarca.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ddlMarca.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlMarca.ValueMember = "idMarca"
            CType(Me.ddlMarca.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            CType(Me.ddlMarca.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.ddlMarca.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).ShouldPaint = False
            CType(Me.ddlMarca.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            CType(Me.ddlMarca.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).CanFocus = False
            '
            'SplitPanel2
            '
            Me.SplitPanel2.Controls.Add(Me.gridDatos)
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
            Me.SplitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.2327707!, 0.0!)
            Me.SplitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(-32, 0)
            Me.SplitPanel2.TabStop = False
            '
            'btnAceptar
            '
            resources.ApplyResources(Me.btnAceptar, "btnAceptar")
            Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnAceptar.Image = Global.EasyGest.My.Resources.Resources.accept
            Me.btnAceptar.Name = "btnAceptar"
            '
            '
            '
            Me.btnAceptar.RootElement.AccessibleDescription = resources.GetString("btnAceptar.RootElement.AccessibleDescription")
            Me.btnAceptar.RootElement.AccessibleName = resources.GetString("btnAceptar.RootElement.AccessibleName")
            Me.btnAceptar.RootElement.Alignment = CType(resources.GetObject("btnAceptar.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnAceptar.RootElement.AngleTransform = CType(resources.GetObject("btnAceptar.RootElement.AngleTransform"), Single)
            Me.btnAceptar.RootElement.FlipText = CType(resources.GetObject("btnAceptar.RootElement.FlipText"), Boolean)
            Me.btnAceptar.RootElement.Margin = CType(resources.GetObject("btnAceptar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnAceptar.RootElement.Padding = CType(resources.GetObject("btnAceptar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnAceptar.RootElement.Text = resources.GetString("btnAceptar.RootElement.Text")
            Me.btnAceptar.RootElement.TextOrientation = CType(resources.GetObject("btnAceptar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.accept
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text7")
            CType(Me.btnAceptar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
            '
            'btnCancelar
            '
            resources.ApplyResources(Me.btnCancelar, "btnCancelar")
            Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancelar.Image = Global.EasyGest.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
            '
            '
            '
            Me.btnCancelar.RootElement.AccessibleDescription = resources.GetString("btnCancelar.RootElement.AccessibleDescription")
            Me.btnCancelar.RootElement.AccessibleName = resources.GetString("btnCancelar.RootElement.AccessibleName")
            Me.btnCancelar.RootElement.Alignment = CType(resources.GetObject("btnCancelar.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnCancelar.RootElement.AngleTransform = CType(resources.GetObject("btnCancelar.RootElement.AngleTransform"), Single)
            Me.btnCancelar.RootElement.FlipText = CType(resources.GetObject("btnCancelar.RootElement.FlipText"), Boolean)
            Me.btnCancelar.RootElement.Margin = CType(resources.GetObject("btnCancelar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnCancelar.RootElement.Padding = CType(resources.GetObject("btnCancelar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnCancelar.RootElement.Text = resources.GetString("btnCancelar.RootElement.Text")
            Me.btnCancelar.RootElement.TextOrientation = CType(resources.GetObject("btnCancelar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.cancel
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text8")
            CType(Me.btnCancelar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(10, Byte), Integer))
            '
            'frmProductoEdicion
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancelar
            Me.Controls.Add(Me.RadSplitContainer1)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmProductoEdicion"
            Me.Opacity = 0.9R
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmProductoEdicion.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmProductoEdicion.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmProductoEdicion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmProductoEdicion.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmProductoEdicion.RootElement.FlipText"), Boolean)
            Me.RootElement.Margin = CType(resources.GetObject("frmProductoEdicion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmProductoEdicion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmProductoEdicion.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmProductoEdicion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ShowInTaskbar = False
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CodigosBarraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel20, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grpbPrecio, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpbPrecio.ResumeLayout(False)
            Me.grpbPrecio.PerformLayout()
            CType(Me.spinPrecioVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinPrecioCoste, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grpbStock, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpbStock.ResumeLayout(False)
            Me.grpbStock.PerformLayout()
            CType(Me.spinStockPaquete, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinStock, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UnidadesMedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FamiliasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlTipoImpuesto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ImpuestosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNombreChino, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtReferencia, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtDescuento, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinUnidadVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinUnidadPaquete, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkPrecioVariable, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkControlStock, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UbicacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer1.ResumeLayout(False)
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel1.ResumeLayout(False)
            Me.SplitPanel1.PerformLayout()
            CType(Me.toggleCodigoBarra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnQuitarUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnQuitarUnidad, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnQuitarMarca, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnQuitarFamilia, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnGenerarReferencia, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlUnidadMedida, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlFamilia, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlMarca, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel2.ResumeLayout(False)
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents ddlTipoImpuesto As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents UbicacionesBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents UnidadesMedidaBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents txtNombre As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtNombreChino As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents timValidar As System.Windows.Forms.Timer
        Friend WithEvents grpbPrecio As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents grpbStock As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents txtObservacion As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtReferencia As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtDescuento As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents spinUnidadVenta As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents spinUnidadPaquete As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents chkPrecioVariable As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents chkControlStock As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents spinStock As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents spinStockPaquete As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents spinPrecioVenta As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents spinPrecioCoste As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents btnGenerarReferencia As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnQuitarFamilia As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnQuitarUnidad As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnQuitarMarca As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnQuitarUbicacion As Telerik.WinControls.UI.RadButton
        Friend WithEvents ImpuestosBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents FamiliasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents SplitPanel1 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents SplitPanel2 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents toggleCodigoBarra As Telerik.WinControls.UI.RadToggleButton
        Private WithEvents gridDatos As Telerik.WinControls.UI.RadGridView
        Friend WithEvents CodigosBarraBindingSource As System.Windows.Forms.BindingSource
        Private WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
        Friend WithEvents ddlMarca As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents ddlUnidadMedida As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents ddlFamilia As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents ddlUbicacion As Telerik.WinControls.UI.RadDropDownList
    End Class

End Namespace

