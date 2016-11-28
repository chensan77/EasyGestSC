Namespace Presentacion.Formulario.Configuracion

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmAuxiliarProducto
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAuxiliarProducto))
            Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewMaskBoxColumn1 As Telerik.WinControls.UI.GridViewMaskBoxColumn = New Telerik.WinControls.UI.GridViewMaskBoxColumn()
            Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim InputBinding1 As Telerik.WinControls.Keyboard.InputBinding = New Telerik.WinControls.Keyboard.InputBinding()
            Dim Chord1 As Telerik.WinControls.Keyboard.Chord = New Telerik.WinControls.Keyboard.Chord()
            Dim ChordModifier1 As Telerik.WinControls.Keyboard.ChordModifier = New Telerik.WinControls.Keyboard.ChordModifier()
            Me.gridMarcas = New Telerik.WinControls.UI.RadGridView()
            Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridUbicaciones = New Telerik.WinControls.UI.RadGridView()
            Me.UbicacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridMedidas = New Telerik.WinControls.UI.RadGridView()
            Me.UnidadesMedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.pvDatosAuxiliaresProducto = New Telerik.WinControls.UI.RadPageView()
            Me.pvpMarcas = New Telerik.WinControls.UI.RadPageViewPage()
            Me.pvpUbicaciones = New Telerik.WinControls.UI.RadPageViewPage()
            Me.pvpUnidadesMedida = New Telerik.WinControls.UI.RadPageViewPage()
            Me.pvpFamilias = New Telerik.WinControls.UI.RadPageViewPage()
            Me.treeFamilia = New Telerik.WinControls.UI.RadTreeView()
            Me.imglFamilia = New System.Windows.Forms.ImageList(Me.components)
            Me.cmenuFamilia = New Telerik.WinControls.UI.RadContextMenu(Me.components)
            Me.mitemAgregar = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemAgregarFamiliaBase = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemAgregarSubfamilia = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemEditar = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemEliminar = New Telerik.WinControls.UI.RadMenuItem()
            Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
            Me.mitemRefrescar = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemCrearNodoRaiz = New Telerik.WinControls.UI.RadMenuItem()
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.FamiliasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType(Me.gridMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridMarcas.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridUbicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridUbicaciones.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UbicacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridMedidas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridMedidas.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UnidadesMedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pvDatosAuxiliaresProducto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pvDatosAuxiliaresProducto.SuspendLayout()
            Me.pvpMarcas.SuspendLayout()
            Me.pvpUbicaciones.SuspendLayout()
            Me.pvpUnidadesMedida.SuspendLayout()
            Me.pvpFamilias.SuspendLayout()
            CType(Me.treeFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FamiliasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridMarcas
            '
            resources.ApplyResources(Me.gridMarcas, "gridMarcas")
            Me.gridMarcas.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.gridMarcas.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridMarcas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            '
            '
            '
            Me.gridMarcas.MasterTemplate.AllowColumnChooser = False
            Me.gridMarcas.MasterTemplate.AllowColumnReorder = False
            Me.gridMarcas.MasterTemplate.AllowDragToGroup = False
            Me.gridMarcas.MasterTemplate.Caption = resources.GetString("gridMarcas.MasterTemplate.Caption")
            GridViewDecimalColumn1.DataType = GetType(Long)
            GridViewDecimalColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn1, "GridViewDecimalColumn1")
            GridViewDecimalColumn1.FieldName = "idMarca"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.IsVisible = False
            GridViewDecimalColumn1.Name = "idMarca"
            GridViewTextBoxColumn1.AllowFiltering = False
            GridViewTextBoxColumn1.AllowGroup = False
            GridViewTextBoxColumn1.AllowHide = False
            GridViewTextBoxColumn1.ColumnCharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            GridViewTextBoxColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn1, "GridViewTextBoxColumn1")
            GridViewTextBoxColumn1.FieldName = "Marca"
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.Name = "Marca"
            GridViewTextBoxColumn1.Width = 296
            GridViewMaskBoxColumn1.AllowFiltering = False
            GridViewMaskBoxColumn1.AllowGroup = False
            GridViewMaskBoxColumn1.AllowHide = False
            GridViewMaskBoxColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewMaskBoxColumn1, "GridViewMaskBoxColumn1")
            GridViewMaskBoxColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.None
            GridViewMaskBoxColumn1.FieldName = "CodigoEAN"
            GridViewMaskBoxColumn1.IsAutoGenerated = True
            GridViewMaskBoxColumn1.Mask = "9999999"
            GridViewMaskBoxColumn1.MaskType = Telerik.WinControls.UI.MaskType.Standard
            GridViewMaskBoxColumn1.Name = "CodigoEAN"
            GridViewMaskBoxColumn1.Width = 171
            Me.gridMarcas.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1, GridViewMaskBoxColumn1})
            Me.gridMarcas.MasterTemplate.DataSource = Me.MarcasBindingSource
            Me.gridMarcas.MasterTemplate.EnableGrouping = False
            Me.gridMarcas.MasterTemplate.ViewDefinition = TableViewDefinition1
            Me.gridMarcas.Name = "gridMarcas"
            '
            '
            '
            Me.gridMarcas.RootElement.AccessibleDescription = Nothing
            Me.gridMarcas.RootElement.AccessibleName = Nothing
            '
            'MarcasBindingSource
            '
            Me.MarcasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Marcas)
            '
            'gridUbicaciones
            '
            resources.ApplyResources(Me.gridUbicaciones, "gridUbicaciones")
            Me.gridUbicaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.gridUbicaciones.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridUbicaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            '
            '
            '
            Me.gridUbicaciones.MasterTemplate.AllowColumnChooser = False
            Me.gridUbicaciones.MasterTemplate.AllowColumnReorder = False
            Me.gridUbicaciones.MasterTemplate.AllowDragToGroup = False
            Me.gridUbicaciones.MasterTemplate.Caption = resources.GetString("gridUbicaciones.MasterTemplate.Caption")
            GridViewDecimalColumn2.DataType = GetType(Long)
            GridViewDecimalColumn2.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn2, "GridViewDecimalColumn2")
            GridViewDecimalColumn2.FieldName = "idUbicacion"
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.IsVisible = False
            GridViewDecimalColumn2.Name = "idUbicacion"
            GridViewTextBoxColumn2.AllowFiltering = False
            GridViewTextBoxColumn2.AllowGroup = False
            GridViewTextBoxColumn2.ColumnCharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            GridViewTextBoxColumn2.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn2, "GridViewTextBoxColumn2")
            GridViewTextBoxColumn2.FieldName = "Ubicacion"
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.Name = "Ubicacion"
            GridViewTextBoxColumn2.Width = 225
            GridViewTextBoxColumn3.AllowFiltering = False
            GridViewTextBoxColumn3.AllowGroup = False
            GridViewTextBoxColumn3.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn3, "GridViewTextBoxColumn3")
            GridViewTextBoxColumn3.FieldName = "Descripcion"
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.Name = "Descripcion"
            GridViewTextBoxColumn3.Width = 256
            Me.gridUbicaciones.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn2, GridViewTextBoxColumn2, GridViewTextBoxColumn3})
            Me.gridUbicaciones.MasterTemplate.DataSource = Me.UbicacionesBindingSource
            Me.gridUbicaciones.MasterTemplate.EnableGrouping = False
            Me.gridUbicaciones.MasterTemplate.ViewDefinition = TableViewDefinition2
            Me.gridUbicaciones.Name = "gridUbicaciones"
            '
            '
            '
            Me.gridUbicaciones.RootElement.AccessibleDescription = Nothing
            Me.gridUbicaciones.RootElement.AccessibleName = Nothing
            '
            'UbicacionesBindingSource
            '
            Me.UbicacionesBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Ubicaciones)
            '
            'gridMedidas
            '
            resources.ApplyResources(Me.gridMedidas, "gridMedidas")
            Me.gridMedidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.gridMedidas.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridMedidas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            '
            '
            '
            Me.gridMedidas.MasterTemplate.AllowColumnChooser = False
            Me.gridMedidas.MasterTemplate.AllowDragToGroup = False
            Me.gridMedidas.MasterTemplate.Caption = resources.GetString("gridMedidas.MasterTemplate.Caption")
            GridViewDecimalColumn3.DataType = GetType(Long)
            GridViewDecimalColumn3.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn3, "GridViewDecimalColumn3")
            GridViewDecimalColumn3.FieldName = "idUnidadMedida"
            GridViewDecimalColumn3.IsAutoGenerated = True
            GridViewDecimalColumn3.IsVisible = False
            GridViewDecimalColumn3.Name = "idUnidadMedida"
            GridViewTextBoxColumn4.AllowFiltering = False
            GridViewTextBoxColumn4.AllowGroup = False
            GridViewTextBoxColumn4.ColumnCharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            GridViewTextBoxColumn4.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn4, "GridViewTextBoxColumn4")
            GridViewTextBoxColumn4.FieldName = "Medida"
            GridViewTextBoxColumn4.IsAutoGenerated = True
            GridViewTextBoxColumn4.MaxLength = 100
            GridViewTextBoxColumn4.Name = "Medida"
            GridViewTextBoxColumn4.Width = 283
            GridViewTextBoxColumn5.AllowGroup = False
            GridViewTextBoxColumn5.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn5, "GridViewTextBoxColumn5")
            GridViewTextBoxColumn5.FieldName = "Abreviatura"
            GridViewTextBoxColumn5.IsAutoGenerated = True
            GridViewTextBoxColumn5.MaxLength = 10
            GridViewTextBoxColumn5.Name = "Abreviatura"
            GridViewTextBoxColumn5.Width = 123
            Me.gridMedidas.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5})
            Me.gridMedidas.MasterTemplate.DataSource = Me.UnidadesMedidaBindingSource
            Me.gridMedidas.MasterTemplate.EnableGrouping = False
            Me.gridMedidas.MasterTemplate.ViewDefinition = TableViewDefinition3
            Me.gridMedidas.Name = "gridMedidas"
            '
            '
            '
            Me.gridMedidas.RootElement.AccessibleDescription = Nothing
            Me.gridMedidas.RootElement.AccessibleName = Nothing
            '
            'UnidadesMedidaBindingSource
            '
            Me.UnidadesMedidaBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.UnidadesMedida)
            '
            'pvDatosAuxiliaresProducto
            '
            resources.ApplyResources(Me.pvDatosAuxiliaresProducto, "pvDatosAuxiliaresProducto")
            Me.pvDatosAuxiliaresProducto.Controls.Add(Me.pvpMarcas)
            Me.pvDatosAuxiliaresProducto.Controls.Add(Me.pvpUbicaciones)
            Me.pvDatosAuxiliaresProducto.Controls.Add(Me.pvpUnidadesMedida)
            Me.pvDatosAuxiliaresProducto.Controls.Add(Me.pvpFamilias)
            Me.pvDatosAuxiliaresProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.pvDatosAuxiliaresProducto.ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth
            Me.pvDatosAuxiliaresProducto.Name = "pvDatosAuxiliaresProducto"
            '
            '
            '
            Me.pvDatosAuxiliaresProducto.RootElement.AccessibleDescription = Nothing
            Me.pvDatosAuxiliaresProducto.RootElement.AccessibleName = Nothing
            Me.pvDatosAuxiliaresProducto.SelectedPage = Me.pvpMarcas
            CType(Me.pvDatosAuxiliaresProducto.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
            CType(Me.pvDatosAuxiliaresProducto.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.FillHeight
            CType(Me.pvDatosAuxiliaresProducto.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Left
            CType(Me.pvDatosAuxiliaresProducto.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth
            CType(Me.pvDatosAuxiliaresProducto.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemContentOrientation = Telerik.WinControls.UI.PageViewContentOrientation.Horizontal
            '
            'pvpMarcas
            '
            resources.ApplyResources(Me.pvpMarcas, "pvpMarcas")
            Me.pvpMarcas.Controls.Add(Me.gridMarcas)
            Me.pvpMarcas.Image = Global.EasyGest.My.Resources.Resources.ruby
            Me.pvpMarcas.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.pvpMarcas.ItemSize = New System.Drawing.SizeF(44.0!, 44.0!)
            Me.pvpMarcas.Name = "pvpMarcas"
            Me.pvpMarcas.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.pvpMarcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'pvpUbicaciones
            '
            resources.ApplyResources(Me.pvpUbicaciones, "pvpUbicaciones")
            Me.pvpUbicaciones.Controls.Add(Me.gridUbicaciones)
            Me.pvpUbicaciones.Image = Global.EasyGest.My.Resources.Resources.box
            Me.pvpUbicaciones.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.pvpUbicaciones.ItemSize = New System.Drawing.SizeF(44.0!, 44.0!)
            Me.pvpUbicaciones.Name = "pvpUbicaciones"
            Me.pvpUbicaciones.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.pvpUbicaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'pvpUnidadesMedida
            '
            resources.ApplyResources(Me.pvpUnidadesMedida, "pvpUnidadesMedida")
            Me.pvpUnidadesMedida.Controls.Add(Me.gridMedidas)
            Me.pvpUnidadesMedida.Image = Global.EasyGest.My.Resources.Resources.anchor
            Me.pvpUnidadesMedida.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.pvpUnidadesMedida.ItemSize = New System.Drawing.SizeF(70.0!, 44.0!)
            Me.pvpUnidadesMedida.Name = "pvpUnidadesMedida"
            Me.pvpUnidadesMedida.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.pvpUnidadesMedida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'pvpFamilias
            '
            resources.ApplyResources(Me.pvpFamilias, "pvpFamilias")
            Me.pvpFamilias.Controls.Add(Me.treeFamilia)
            Me.pvpFamilias.Image = Global.EasyGest.My.Resources.Resources.sitemap
            Me.pvpFamilias.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.pvpFamilias.ItemSize = New System.Drawing.SizeF(44.0!, 44.0!)
            Me.pvpFamilias.Name = "pvpFamilias"
            Me.pvpFamilias.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.pvpFamilias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'treeFamilia
            '
            resources.ApplyResources(Me.treeFamilia, "treeFamilia")
            Me.treeFamilia.AllowAdd = True
            Me.treeFamilia.AllowDragDrop = True
            Me.treeFamilia.AllowDrop = True
            Me.treeFamilia.AllowEdit = True
            Me.treeFamilia.AllowRemove = True
            Me.treeFamilia.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.treeFamilia.Cursor = System.Windows.Forms.Cursors.Default
            Me.treeFamilia.ExpandAnimation = Telerik.WinControls.UI.ExpandAnimation.None
            Me.treeFamilia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.treeFamilia.ImageList = Me.imglFamilia
            Me.treeFamilia.LineColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.treeFamilia.Name = "treeFamilia"
            Me.treeFamilia.RadContextMenu = Me.cmenuFamilia
            '
            '
            '
            Me.treeFamilia.RootElement.AccessibleDescription = Nothing
            Me.treeFamilia.RootElement.AccessibleName = Nothing
            Me.treeFamilia.ShowLines = True
            Me.treeFamilia.SpacingBetweenNodes = 2
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
            'cmenuFamilia
            '
            Me.cmenuFamilia.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemAgregar, Me.mitemEditar, Me.mitemEliminar, Me.RadMenuSeparatorItem1, Me.mitemRefrescar})
            '
            'mitemAgregar
            '
            Me.mitemAgregar.AccessibleDescription = "Agregar"
            resources.ApplyResources(Me.mitemAgregar, "mitemAgregar")
            Me.mitemAgregar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemAgregar.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemAgregarFamiliaBase, Me.mitemAgregarSubfamilia})
            Me.mitemAgregar.Name = "mitemAgregar"
            '
            'mitemAgregarFamiliaBase
            '
            Me.mitemAgregarFamiliaBase.AccessibleDescription = "Familia Base"
            resources.ApplyResources(Me.mitemAgregarFamiliaBase, "mitemAgregarFamiliaBase")
            Me.mitemAgregarFamiliaBase.Font = New System.Drawing.Font("楷体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemAgregarFamiliaBase.Name = "mitemAgregarFamiliaBase"
            '
            'mitemAgregarSubfamilia
            '
            Me.mitemAgregarSubfamilia.AccessibleDescription = "Subfamilia"
            resources.ApplyResources(Me.mitemAgregarSubfamilia, "mitemAgregarSubfamilia")
            Me.mitemAgregarSubfamilia.Font = New System.Drawing.Font("楷体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemAgregarSubfamilia.Name = "mitemAgregarSubfamilia"
            '
            'mitemEditar
            '
            Me.mitemEditar.AccessibleDescription = "Editar"
            resources.ApplyResources(Me.mitemEditar, "mitemEditar")
            Me.mitemEditar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemEditar.Name = "mitemEditar"
            '
            'mitemEliminar
            '
            Me.mitemEliminar.AccessibleDescription = "Eliminar"
            resources.ApplyResources(Me.mitemEliminar, "mitemEliminar")
            Me.mitemEliminar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemEliminar.Name = "mitemEliminar"
            '
            'RadMenuSeparatorItem1
            '
            resources.ApplyResources(Me.RadMenuSeparatorItem1, "RadMenuSeparatorItem1")
            Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
            '
            'mitemRefrescar
            '
            Me.mitemRefrescar.AccessibleDescription = "Refrescar"
            resources.ApplyResources(Me.mitemRefrescar, "mitemRefrescar")
            Me.mitemRefrescar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemRefrescar.Name = "mitemRefrescar"
            '
            'mitemCrearNodoRaiz
            '
            resources.ApplyResources(Me.mitemCrearNodoRaiz, "mitemCrearNodoRaiz")
            Me.mitemCrearNodoRaiz.Name = "mitemCrearNodoRaiz"
            '
            'btnCancelar
            '
            resources.ApplyResources(Me.btnCancelar, "btnCancelar")
            Me.btnCancelar.Image = Global.EasyGest.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
            '
            '
            '
            Me.btnCancelar.RootElement.AccessibleDescription = Nothing
            Me.btnCancelar.RootElement.AccessibleName = Nothing
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.cancel
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text")
            CType(Me.btnCancelar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(10, Byte), Integer))
            '
            'btnAceptar
            '
            resources.ApplyResources(Me.btnAceptar, "btnAceptar")
            Me.btnAceptar.Image = Global.EasyGest.My.Resources.Resources.accept
            Me.btnAceptar.Name = "btnAceptar"
            '
            '
            '
            Me.btnAceptar.RootElement.AccessibleDescription = Nothing
            Me.btnAceptar.RootElement.AccessibleName = Nothing
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.accept
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text1")
            CType(Me.btnAceptar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
            '
            'FamiliasBindingSource
            '
            Me.FamiliasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Familias)
            '
            'frmAuxiliarProducto
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ChordModifier1.AltModifier = False
            ChordModifier1.ControlModifier = True
            ChordModifier1.ShiftModifier = False
            Chord1.ChordModifier = ChordModifier1
            Chord1.Keys = "Ctrl+A"
            InputBinding1.Chord = Chord1
            Me.CommandBindings.AddRange(New Telerik.WinControls.Keyboard.InputBinding() {InputBinding1})
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.pvDatosAuxiliaresProducto)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmAuxiliarProducto"
            Me.Opacity = 0.9R
            '
            '
            '
            Me.RootElement.AccessibleDescription = Nothing
            Me.RootElement.AccessibleName = Nothing
            Me.RootElement.ApplyShapeToControl = True
            Me.ShowInTaskbar = False
            CType(Me.gridMarcas.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridMarcas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridUbicaciones.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridUbicaciones, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UbicacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridMedidas.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridMedidas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UnidadesMedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pvDatosAuxiliaresProducto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pvDatosAuxiliaresProducto.ResumeLayout(False)
            Me.pvpMarcas.ResumeLayout(False)
            Me.pvpUbicaciones.ResumeLayout(False)
            Me.pvpUnidadesMedida.ResumeLayout(False)
            Me.pvpFamilias.ResumeLayout(False)
            CType(Me.treeFamilia, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FamiliasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents pvDatosAuxiliaresProducto As Telerik.WinControls.UI.RadPageView
        Friend WithEvents pvpMarcas As Telerik.WinControls.UI.RadPageViewPage
        Friend WithEvents pvpUbicaciones As Telerik.WinControls.UI.RadPageViewPage
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents pvpUnidadesMedida As Telerik.WinControls.UI.RadPageViewPage
        Friend WithEvents pvpFamilias As Telerik.WinControls.UI.RadPageViewPage
        Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents gridMarcas As Telerik.WinControls.UI.RadGridView
        Friend WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
        Friend WithEvents gridUbicaciones As Telerik.WinControls.UI.RadGridView
        Friend WithEvents UbicacionesBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents treeFamilia As Telerik.WinControls.UI.RadTreeView
        Friend WithEvents FamiliasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents gridMedidas As Telerik.WinControls.UI.RadGridView
        Friend WithEvents UnidadesMedidaBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents mitemCrearNodoRaiz As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents cmenuFamilia As Telerik.WinControls.UI.RadContextMenu
        Friend WithEvents mitemAgregar As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mitemAgregarFamiliaBase As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mitemAgregarSubfamilia As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mitemEditar As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mitemEliminar As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents imglFamilia As System.Windows.Forms.ImageList
        Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
        Friend WithEvents mitemRefrescar As Telerik.WinControls.UI.RadMenuItem
    End Class

End Namespace

