Namespace Presentacion.Formulario.Cuenta

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmCuenta
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuenta))
            Dim GridViewImageColumn1 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim InputBinding1 As Telerik.WinControls.Keyboard.InputBinding = New Telerik.WinControls.Keyboard.InputBinding()
            Dim Chord1 As Telerik.WinControls.Keyboard.Chord = New Telerik.WinControls.Keyboard.Chord()
            Dim ChordModifier1 As Telerik.WinControls.Keyboard.ChordModifier = New Telerik.WinControls.Keyboard.ChordModifier()
            Me.gridDatos = New Telerik.WinControls.UI.RadGridView()
            Me.VWCuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.mitemAgregarTarjeta = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemAgregarContacto = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemAgregarCuenta = New Telerik.WinControls.UI.RadMenuItem()
            Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.SplitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
            Me.lbleDiagnostico = New Telerik.WinControls.UI.RadLabelElement()
            Me.bgwCarga = New System.ComponentModel.BackgroundWorker()
            Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.cbstripeAccion = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbbtnAgregar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnEliminar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnModificar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbstripeOrden = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbComandos = New Telerik.WinControls.UI.RadCommandBar()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.VWCuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer1.SuspendLayout()
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel1.SuspendLayout()
            CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridDatos
            '
            Me.gridDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDatos.Cursor = System.Windows.Forms.Cursors.Default
            resources.ApplyResources(Me.gridDatos, "gridDatos")
            Me.gridDatos.ForeColor = System.Drawing.Color.Black
            '
            '
            '
            Me.gridDatos.MasterTemplate.AllowAddNewRow = False
            Me.gridDatos.MasterTemplate.AllowRowResize = False
            Me.gridDatos.MasterTemplate.AllowSearchRow = True
            GridViewImageColumn1.AllowFiltering = False
            GridViewImageColumn1.AllowSort = False
            GridViewImageColumn1.EnableExpressionEditor = False
            GridViewImageColumn1.FieldName = "IconTipoPropietario"
            GridViewImageColumn1.IsAutoGenerated = True
            GridViewImageColumn1.IsPinned = True
            GridViewImageColumn1.Name = "IconTipoPropietario"
            GridViewImageColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewImageColumn1.Width = 47
            GridViewTextBoxColumn1.AllowGroup = False
            GridViewTextBoxColumn1.EnableExpressionEditor = False
            GridViewTextBoxColumn1.FieldName = "Titular"
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.IsPinned = True
            GridViewTextBoxColumn1.Name = "Titular"
            GridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewTextBoxColumn1.ReadOnly = True
            GridViewTextBoxColumn1.Width = 196
            GridViewTextBoxColumn2.AllowGroup = False
            GridViewTextBoxColumn2.EnableExpressionEditor = False
            GridViewTextBoxColumn2.FieldName = "Banco"
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.IsPinned = True
            GridViewTextBoxColumn2.Name = "Banco"
            GridViewTextBoxColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewTextBoxColumn2.ReadOnly = True
            GridViewTextBoxColumn2.Width = 180
            GridViewTextBoxColumn3.AllowGroup = False
            GridViewTextBoxColumn3.EnableExpressionEditor = False
            GridViewTextBoxColumn3.FieldName = "CCC"
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.IsPinned = True
            GridViewTextBoxColumn3.Name = "CCC"
            GridViewTextBoxColumn3.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewTextBoxColumn3.ReadOnly = True
            GridViewTextBoxColumn3.Width = 218
            GridViewTextBoxColumn4.AllowGroup = False
            GridViewTextBoxColumn4.EnableExpressionEditor = False
            GridViewTextBoxColumn4.FieldName = "Propietario"
            GridViewTextBoxColumn4.IsAutoGenerated = True
            GridViewTextBoxColumn4.Name = "Propietario"
            GridViewTextBoxColumn4.ReadOnly = True
            GridViewTextBoxColumn4.Width = 217
            GridViewTextBoxColumn5.AllowFiltering = False
            GridViewTextBoxColumn5.AllowGroup = False
            GridViewTextBoxColumn5.AllowSort = False
            GridViewTextBoxColumn5.EnableExpressionEditor = False
            GridViewTextBoxColumn5.FieldName = "IBAN"
            GridViewTextBoxColumn5.IsAutoGenerated = True
            GridViewTextBoxColumn5.Name = "IBAN"
            GridViewTextBoxColumn5.ReadOnly = True
            GridViewTextBoxColumn5.Width = 214
            GridViewTextBoxColumn6.AllowFiltering = False
            GridViewTextBoxColumn6.AllowGroup = False
            GridViewTextBoxColumn6.AllowSort = False
            GridViewTextBoxColumn6.EnableExpressionEditor = False
            GridViewTextBoxColumn6.FieldName = "Switch"
            GridViewTextBoxColumn6.IsAutoGenerated = True
            GridViewTextBoxColumn6.Name = "Switch"
            GridViewTextBoxColumn6.ReadOnly = True
            GridViewTextBoxColumn6.Width = 158
            Me.gridDatos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewImageColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6})
            Me.gridDatos.MasterTemplate.DataSource = Me.VWCuentasBindingSource
            Me.gridDatos.MasterTemplate.EnableAlternatingRowColor = True
            Me.gridDatos.MasterTemplate.EnableGrouping = False
            Me.gridDatos.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
            Me.gridDatos.MasterTemplate.ViewDefinition = TableViewDefinition1
            Me.gridDatos.Name = "gridDatos"
            Me.gridDatos.ReadOnly = True
            Me.gridDatos.ShowGroupPanel = False
            '
            'VWCuentasBindingSource
            '
            Me.VWCuentasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.VWDatosBancario)
            '
            'mitemAgregarTarjeta
            '
            resources.ApplyResources(Me.mitemAgregarTarjeta, "mitemAgregarTarjeta")
            Me.mitemAgregarTarjeta.DescriptionFont = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemAgregarTarjeta.DescriptionText = "Agregar una tarjeta de cliente"
            Me.mitemAgregarTarjeta.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemAgregarTarjeta.Image = Global.EasyGest.My.Resources.Resources._112
            Me.mitemAgregarTarjeta.Name = "mitemAgregarTarjeta"
            '
            'mitemAgregarContacto
            '
            Me.mitemAgregarContacto.AccessibleDescription = "Agregar"
            resources.ApplyResources(Me.mitemAgregarContacto, "mitemAgregarContacto")
            Me.mitemAgregarContacto.DescriptionFont = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemAgregarContacto.DescriptionText = "Agregar un contacto de cliente"
            Me.mitemAgregarContacto.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemAgregarContacto.Image = Global.EasyGest.My.Resources.Resources._112
            Me.mitemAgregarContacto.Name = "mitemAgregarContacto"
            '
            'mitemAgregarCuenta
            '
            Me.mitemAgregarCuenta.AccessibleDescription = "Agregar"
            resources.ApplyResources(Me.mitemAgregarCuenta, "mitemAgregarCuenta")
            Me.mitemAgregarCuenta.DescriptionFont = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemAgregarCuenta.DescriptionText = "Agregar una cuenta de banco"
            Me.mitemAgregarCuenta.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemAgregarCuenta.Image = Global.EasyGest.My.Resources.Resources._112
            Me.mitemAgregarCuenta.Name = "mitemAgregarCuenta"
            '
            'RadSplitContainer1
            '
            Me.RadSplitContainer1.Controls.Add(Me.SplitPanel1)
            resources.ApplyResources(Me.RadSplitContainer1, "RadSplitContainer1")
            Me.RadSplitContainer1.Name = "RadSplitContainer1"
            '
            '
            '
            Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.RadSplitContainer1.TabStop = False
            '
            'SplitPanel1
            '
            Me.SplitPanel1.Controls.Add(Me.gridDatos)
            Me.SplitPanel1.Controls.Add(Me.RadStatusStrip1)
            resources.ApplyResources(Me.SplitPanel1, "SplitPanel1")
            Me.SplitPanel1.Name = "SplitPanel1"
            '
            '
            '
            Me.SplitPanel1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.1980109!, 0!)
            Me.SplitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(189, 0)
            Me.SplitPanel1.TabStop = False
            '
            'RadStatusStrip1
            '
            resources.ApplyResources(Me.RadStatusStrip1, "RadStatusStrip1")
            Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.lbleDiagnostico})
            Me.RadStatusStrip1.Name = "RadStatusStrip1"
            '
            'lbleDiagnostico
            '
            Me.lbleDiagnostico.AccessibleDescription = "Núm. Registro:"
            Me.lbleDiagnostico.AccessibleName = "Núm. Registro:"
            resources.ApplyResources(Me.lbleDiagnostico, "lbleDiagnostico")
            Me.lbleDiagnostico.Font = New System.Drawing.Font("楷体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbleDiagnostico.Name = "lbleDiagnostico"
            Me.RadStatusStrip1.SetSpring(Me.lbleDiagnostico, True)
            Me.lbleDiagnostico.TextWrap = True
            '
            'bgwCarga
            '
            Me.bgwCarga.WorkerSupportsCancellation = True
            '
            'CommandBarRowElement1
            '
            resources.ApplyResources(Me.CommandBarRowElement1, "CommandBarRowElement1")
            Me.CommandBarRowElement1.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.CommandBarRowElement1.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
            Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.cbstripeAccion, Me.cbstripeOrden})
            '
            'cbstripeAccion
            '
            resources.ApplyResources(Me.cbstripeAccion, "cbstripeAccion")
            Me.cbstripeAccion.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.cbstripeAccion.BorderLeftShadowColor = System.Drawing.Color.Empty
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
            Me.cbstripeAccion.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbtnAgregar, Me.cbbtnEliminar, Me.cbbtnModificar})
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
            'cbbtnAgregar
            '
            resources.ApplyResources(Me.cbbtnAgregar, "cbbtnAgregar")
            Me.cbbtnAgregar.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders
            Me.cbbtnAgregar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(106, Byte), Integer))
            Me.cbbtnAgregar.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.cbbtnAgregar.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.cbbtnAgregar.DrawText = True
            Me.cbbtnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnAgregar.Image = Global.EasyGest.My.Resources.Resources._127
            Me.cbbtnAgregar.Name = "cbbtnAgregar"
            Me.cbbtnAgregar.Shape = Nothing
            Me.cbbtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'cbbtnEliminar
            '
            resources.ApplyResources(Me.cbbtnEliminar, "cbbtnEliminar")
            Me.cbbtnEliminar.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.cbbtnEliminar.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.cbbtnEliminar.DrawText = True
            Me.cbbtnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnEliminar.Image = Global.EasyGest.My.Resources.Resources._128
            Me.cbbtnEliminar.Name = "cbbtnEliminar"
            Me.cbbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'cbbtnModificar
            '
            resources.ApplyResources(Me.cbbtnModificar, "cbbtnModificar")
            Me.cbbtnModificar.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.cbbtnModificar.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.cbbtnModificar.DrawText = True
            Me.cbbtnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnModificar.Image = Global.EasyGest.My.Resources.Resources._130
            Me.cbbtnModificar.Name = "cbbtnModificar"
            Me.cbbtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'cbstripeOrden
            '
            resources.ApplyResources(Me.cbstripeOrden, "cbstripeOrden")
            '
            '
            '
            Me.cbstripeOrden.Grip.Alignment = CType(resources.GetObject("resource.Alignment4"), System.Drawing.ContentAlignment)
            Me.cbstripeOrden.Grip.AngleTransform = CType(resources.GetObject("resource.AngleTransform4"), Single)
            Me.cbstripeOrden.Grip.FlipText = CType(resources.GetObject("resource.FlipText4"), Boolean)
            Me.cbstripeOrden.Grip.Margin = CType(resources.GetObject("resource.Margin4"), System.Windows.Forms.Padding)
            Me.cbstripeOrden.Grip.Padding = CType(resources.GetObject("resource.Padding4"), System.Windows.Forms.Padding)
            Me.cbstripeOrden.Grip.RightToLeft = CType(resources.GetObject("resource.RightToLeft4"), Boolean)
            Me.cbstripeOrden.Grip.Text = resources.GetString("resource.Text4")
            Me.cbstripeOrden.Grip.TextOrientation = CType(resources.GetObject("resource.TextOrientation4"), System.Windows.Forms.Orientation)
            Me.cbstripeOrden.Grip.TextWrap = CType(resources.GetObject("resource.TextWrap4"), Boolean)
            Me.cbstripeOrden.Name = "CommandBarStripElement1"
            '
            '
            '
            Me.cbstripeOrden.OverflowButton.Alignment = CType(resources.GetObject("resource.Alignment5"), System.Drawing.ContentAlignment)
            Me.cbstripeOrden.OverflowButton.AngleTransform = CType(resources.GetObject("resource.AngleTransform5"), Single)
            Me.cbstripeOrden.OverflowButton.FlipText = CType(resources.GetObject("resource.FlipText5"), Boolean)
            Me.cbstripeOrden.OverflowButton.Margin = CType(resources.GetObject("resource.Margin5"), System.Windows.Forms.Padding)
            Me.cbstripeOrden.OverflowButton.Padding = CType(resources.GetObject("resource.Padding5"), System.Windows.Forms.Padding)
            Me.cbstripeOrden.OverflowButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft5"), Boolean)
            Me.cbstripeOrden.OverflowButton.Text = resources.GetString("resource.Text5")
            Me.cbstripeOrden.OverflowButton.TextOrientation = CType(resources.GetObject("resource.TextOrientation5"), System.Windows.Forms.Orientation)
            Me.cbstripeOrden.OverflowButton.TextWrap = CType(resources.GetObject("resource.TextWrap5"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextWrap = CType(resources.GetObject("resource.TextWrap6"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextOrientation = CType(resources.GetObject("resource.TextOrientation6"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).FlipText = CType(resources.GetObject("resource.FlipText6"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Text = resources.GetString("resource.Text6")
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Padding = CType(resources.GetObject("resource.Padding6"), System.Windows.Forms.Padding)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Margin = CType(resources.GetObject("resource.Margin6"), System.Windows.Forms.Padding)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Alignment = CType(resources.GetObject("resource.Alignment6"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).RightToLeft = CType(resources.GetObject("resource.RightToLeft6"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).AngleTransform = CType(resources.GetObject("resource.AngleTransform6"), Single)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextWrap = CType(resources.GetObject("resource.TextWrap7"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextOrientation = CType(resources.GetObject("resource.TextOrientation7"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).FlipText = CType(resources.GetObject("resource.FlipText7"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Text = resources.GetString("resource.Text7")
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Padding = CType(resources.GetObject("resource.Padding7"), System.Windows.Forms.Padding)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Margin = CType(resources.GetObject("resource.Margin7"), System.Windows.Forms.Padding)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Alignment = CType(resources.GetObject("resource.Alignment7"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).RightToLeft = CType(resources.GetObject("resource.RightToLeft7"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).AngleTransform = CType(resources.GetObject("resource.AngleTransform7"), Single)
            '
            'cbComandos
            '
            resources.ApplyResources(Me.cbComandos, "cbComandos")
            Me.cbComandos.Name = "cbComandos"
            Me.cbComandos.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
            '
            'frmCuenta
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
            Me.Controls.Add(Me.RadSplitContainer1)
            Me.Controls.Add(Me.cbComandos)
            Me.Name = "frmCuenta"
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.VWCuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer1.ResumeLayout(False)
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel1.ResumeLayout(False)
            Me.SplitPanel1.PerformLayout()
            CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents SplitPanel1 As Telerik.WinControls.UI.SplitPanel
        Dim WithEvents gridDatos As Telerik.WinControls.UI.RadGridView
        Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
        Friend WithEvents lbleDiagnostico As Telerik.WinControls.UI.RadLabelElement
        Friend WithEvents bgwCarga As System.ComponentModel.BackgroundWorker
        Friend WithEvents mitemAgregarTarjeta As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mitemAgregarContacto As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mitemAgregarCuenta As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
        Friend WithEvents cbstripeAccion As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents cbbtnAgregar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnEliminar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnModificar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbComandos As Telerik.WinControls.UI.RadCommandBar
        Friend WithEvents VWCuentasBindingSource As System.Windows.Forms.BindingSource
        Private WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
        Friend WithEvents cbstripeOrden As Telerik.WinControls.UI.CommandBarStripElement
    End Class

End Namespace

