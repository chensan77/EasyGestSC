Namespace Presentacion.Formulario.Producto

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmCaracteristicaProducto
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaracteristicaProducto))
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Me.gboxNuevo = New Telerik.WinControls.UI.RadGroupBox()
            Me.btnAgregarCaracteristica = New Telerik.WinControls.UI.RadButton()
            Me.ddlTipoCaracteristica = New Telerik.WinControls.UI.RadDropDownList()
            Me.TiposDatoCaractProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.txtCaracteristica = New Telerik.WinControls.UI.RadTextBox()
            Me.timValidar = New System.Windows.Forms.Timer(Me.components)
            Me.propgridCaracteristica = New Telerik.WinControls.UI.RadPropertyGrid()
            Me.cmenuCaracteristica = New Telerik.WinControls.UI.RadContextMenu(Me.components)
            Me.mitemEliminar = New Telerik.WinControls.UI.RadMenuItem()
            Me.CaracteristicasProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gboxNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gboxNuevo.SuspendLayout()
            CType(Me.btnAgregarCaracteristica, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlTipoCaracteristica, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TiposDatoCaractProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtCaracteristica, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.propgridCaracteristica, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CaracteristicasProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
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
            RadLabel1.RootElement.KeyTip = resources.GetString("RadLabel1.RootElement.KeyTip")
            RadLabel1.RootElement.Margin = CType(resources.GetObject("RadLabel1.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel1.RootElement.Padding = CType(resources.GetObject("RadLabel1.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel1.RootElement.Text = resources.GetString("RadLabel1.RootElement.Text")
            RadLabel1.RootElement.TextOrientation = CType(resources.GetObject("RadLabel1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel1.RootElement.ToolTipText = resources.GetString("RadLabel1.RootElement.ToolTipText")
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
            RadLabel2.RootElement.KeyTip = resources.GetString("RadLabel2.RootElement.KeyTip")
            RadLabel2.RootElement.Margin = CType(resources.GetObject("RadLabel2.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel2.RootElement.Padding = CType(resources.GetObject("RadLabel2.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel2.RootElement.Text = resources.GetString("RadLabel2.RootElement.Text")
            RadLabel2.RootElement.TextOrientation = CType(resources.GetObject("RadLabel2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel2.RootElement.ToolTipText = resources.GetString("RadLabel2.RootElement.ToolTipText")
            '
            'gboxNuevo
            '
            resources.ApplyResources(Me.gboxNuevo, "gboxNuevo")
            Me.gboxNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.gboxNuevo.Controls.Add(Me.btnAgregarCaracteristica)
            Me.gboxNuevo.Controls.Add(RadLabel2)
            Me.gboxNuevo.Controls.Add(RadLabel1)
            Me.gboxNuevo.Controls.Add(Me.ddlTipoCaracteristica)
            Me.gboxNuevo.Controls.Add(Me.txtCaracteristica)
            Me.gboxNuevo.Name = "gboxNuevo"
            '
            '
            '
            Me.gboxNuevo.RootElement.AccessibleDescription = resources.GetString("gboxNuevo.RootElement.AccessibleDescription")
            Me.gboxNuevo.RootElement.AccessibleName = resources.GetString("gboxNuevo.RootElement.AccessibleName")
            Me.gboxNuevo.RootElement.Alignment = CType(resources.GetObject("gboxNuevo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.gboxNuevo.RootElement.AngleTransform = CType(resources.GetObject("gboxNuevo.RootElement.AngleTransform"), Single)
            Me.gboxNuevo.RootElement.FlipText = CType(resources.GetObject("gboxNuevo.RootElement.FlipText"), Boolean)
            Me.gboxNuevo.RootElement.KeyTip = resources.GetString("gboxNuevo.RootElement.KeyTip")
            Me.gboxNuevo.RootElement.Margin = CType(resources.GetObject("gboxNuevo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.gboxNuevo.RootElement.Padding = CType(resources.GetObject("gboxNuevo.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.gboxNuevo.RootElement.Text = resources.GetString("gboxNuevo.RootElement.Text")
            Me.gboxNuevo.RootElement.TextOrientation = CType(resources.GetObject("gboxNuevo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.gboxNuevo.RootElement.ToolTipText = resources.GetString("gboxNuevo.RootElement.ToolTipText")
            '
            'btnAgregarCaracteristica
            '
            resources.ApplyResources(Me.btnAgregarCaracteristica, "btnAgregarCaracteristica")
            Me.btnAgregarCaracteristica.Image = Global.EasyGest.My.Resources.Resources.add
            Me.btnAgregarCaracteristica.Name = "btnAgregarCaracteristica"
            '
            '
            '
            Me.btnAgregarCaracteristica.RootElement.AccessibleDescription = resources.GetString("btnAgregarCaracteristica.RootElement.AccessibleDescription")
            Me.btnAgregarCaracteristica.RootElement.AccessibleName = resources.GetString("btnAgregarCaracteristica.RootElement.AccessibleName")
            Me.btnAgregarCaracteristica.RootElement.Alignment = CType(resources.GetObject("btnAgregarCaracteristica.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnAgregarCaracteristica.RootElement.AngleTransform = CType(resources.GetObject("btnAgregarCaracteristica.RootElement.AngleTransform"), Single)
            Me.btnAgregarCaracteristica.RootElement.FlipText = CType(resources.GetObject("btnAgregarCaracteristica.RootElement.FlipText"), Boolean)
            Me.btnAgregarCaracteristica.RootElement.KeyTip = resources.GetString("btnAgregarCaracteristica.RootElement.KeyTip")
            Me.btnAgregarCaracteristica.RootElement.Margin = CType(resources.GetObject("btnAgregarCaracteristica.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnAgregarCaracteristica.RootElement.Padding = CType(resources.GetObject("btnAgregarCaracteristica.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnAgregarCaracteristica.RootElement.Text = resources.GetString("btnAgregarCaracteristica.RootElement.Text")
            Me.btnAgregarCaracteristica.RootElement.TextOrientation = CType(resources.GetObject("btnAgregarCaracteristica.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.btnAgregarCaracteristica.RootElement.ToolTipText = resources.GetString("btnAgregarCaracteristica.RootElement.ToolTipText")
            '
            'ddlTipoCaracteristica
            '
            resources.ApplyResources(Me.ddlTipoCaracteristica, "ddlTipoCaracteristica")
            Me.ddlTipoCaracteristica.AllowShowFocusCues = True
            Me.ddlTipoCaracteristica.AutoCompleteDisplayMember = "TipoDato"
            Me.ddlTipoCaracteristica.AutoCompleteValueMember = "TipoID"
            Me.ddlTipoCaracteristica.DataSource = Me.TiposDatoCaractProductoBindingSource
            Me.ddlTipoCaracteristica.DisplayMember = "TipoDato"
            Me.ddlTipoCaracteristica.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlTipoCaracteristica.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
            Me.ddlTipoCaracteristica.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.ddlTipoCaracteristica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlTipoCaracteristica.Name = "ddlTipoCaracteristica"
            '
            '
            '
            Me.ddlTipoCaracteristica.RootElement.AccessibleDescription = resources.GetString("ddlTipoCaracteristica.RootElement.AccessibleDescription")
            Me.ddlTipoCaracteristica.RootElement.AccessibleName = resources.GetString("ddlTipoCaracteristica.RootElement.AccessibleName")
            Me.ddlTipoCaracteristica.RootElement.Alignment = CType(resources.GetObject("ddlTipoCaracteristica.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlTipoCaracteristica.RootElement.AngleTransform = CType(resources.GetObject("ddlTipoCaracteristica.RootElement.AngleTransform"), Single)
            Me.ddlTipoCaracteristica.RootElement.FlipText = CType(resources.GetObject("ddlTipoCaracteristica.RootElement.FlipText"), Boolean)
            Me.ddlTipoCaracteristica.RootElement.KeyTip = resources.GetString("ddlTipoCaracteristica.RootElement.KeyTip")
            Me.ddlTipoCaracteristica.RootElement.Margin = CType(resources.GetObject("ddlTipoCaracteristica.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlTipoCaracteristica.RootElement.Padding = CType(resources.GetObject("ddlTipoCaracteristica.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ddlTipoCaracteristica.RootElement.Text = resources.GetString("ddlTipoCaracteristica.RootElement.Text")
            Me.ddlTipoCaracteristica.RootElement.TextOrientation = CType(resources.GetObject("ddlTipoCaracteristica.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ddlTipoCaracteristica.RootElement.ToolTipText = resources.GetString("ddlTipoCaracteristica.RootElement.ToolTipText")
            Me.ddlTipoCaracteristica.ValueMember = "TipoID"
            CType(Me.ddlTipoCaracteristica.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            '
            'TiposDatoCaractProductoBindingSource
            '
            Me.TiposDatoCaractProductoBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.TiposDatoCaractProducto)
            '
            'txtCaracteristica
            '
            resources.ApplyResources(Me.txtCaracteristica, "txtCaracteristica")
            Me.txtCaracteristica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtCaracteristica.Name = "txtCaracteristica"
            '
            '
            '
            Me.txtCaracteristica.RootElement.AccessibleDescription = resources.GetString("txtCaracteristica.RootElement.AccessibleDescription")
            Me.txtCaracteristica.RootElement.AccessibleName = resources.GetString("txtCaracteristica.RootElement.AccessibleName")
            Me.txtCaracteristica.RootElement.Alignment = CType(resources.GetObject("txtCaracteristica.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtCaracteristica.RootElement.AngleTransform = CType(resources.GetObject("txtCaracteristica.RootElement.AngleTransform"), Single)
            Me.txtCaracteristica.RootElement.ApplyShapeToControl = False
            Me.txtCaracteristica.RootElement.FlipText = CType(resources.GetObject("txtCaracteristica.RootElement.FlipText"), Boolean)
            Me.txtCaracteristica.RootElement.KeyTip = resources.GetString("txtCaracteristica.RootElement.KeyTip")
            Me.txtCaracteristica.RootElement.Margin = CType(resources.GetObject("txtCaracteristica.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtCaracteristica.RootElement.Padding = CType(resources.GetObject("txtCaracteristica.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtCaracteristica.RootElement.Text = resources.GetString("txtCaracteristica.RootElement.Text")
            Me.txtCaracteristica.RootElement.TextOrientation = CType(resources.GetObject("txtCaracteristica.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtCaracteristica.RootElement.ToolTipText = resources.GetString("txtCaracteristica.RootElement.ToolTipText")
            Me.txtCaracteristica.TabStop = False
            Me.txtCaracteristica.Tag = ""
            CType(Me.txtCaracteristica.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text")
            CType(Me.txtCaracteristica.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtCaracteristica.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtCaracteristica.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtCaracteristica.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtCaracteristica.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'timValidar
            '
            '
            'propgridCaracteristica
            '
            resources.ApplyResources(Me.propgridCaracteristica, "propgridCaracteristica")
            Me.propgridCaracteristica.AllowDefaultContextMenu = False
            Me.propgridCaracteristica.EnableGrouping = False
            Me.propgridCaracteristica.HelpVisible = False
            Me.propgridCaracteristica.ItemSpacing = 2
            Me.propgridCaracteristica.Name = "propgridCaracteristica"
            Me.propgridCaracteristica.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
            Me.propgridCaracteristica.RadContextMenu = Me.cmenuCaracteristica
            '
            '
            '
            Me.propgridCaracteristica.RootElement.AccessibleDescription = resources.GetString("propgridCaracteristica.RootElement.AccessibleDescription")
            Me.propgridCaracteristica.RootElement.AccessibleName = resources.GetString("propgridCaracteristica.RootElement.AccessibleName")
            Me.propgridCaracteristica.RootElement.Alignment = CType(resources.GetObject("propgridCaracteristica.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.propgridCaracteristica.RootElement.AngleTransform = CType(resources.GetObject("propgridCaracteristica.RootElement.AngleTransform"), Single)
            Me.propgridCaracteristica.RootElement.FlipText = CType(resources.GetObject("propgridCaracteristica.RootElement.FlipText"), Boolean)
            Me.propgridCaracteristica.RootElement.KeyTip = resources.GetString("propgridCaracteristica.RootElement.KeyTip")
            Me.propgridCaracteristica.RootElement.Margin = CType(resources.GetObject("propgridCaracteristica.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.propgridCaracteristica.RootElement.Padding = CType(resources.GetObject("propgridCaracteristica.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.propgridCaracteristica.RootElement.Text = resources.GetString("propgridCaracteristica.RootElement.Text")
            Me.propgridCaracteristica.RootElement.TextOrientation = CType(resources.GetObject("propgridCaracteristica.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.propgridCaracteristica.RootElement.ToolTipText = resources.GetString("propgridCaracteristica.RootElement.ToolTipText")
            Me.propgridCaracteristica.SortOrder = System.Windows.Forms.SortOrder.Ascending
            '
            'cmenuCaracteristica
            '
            Me.cmenuCaracteristica.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemEliminar})
            '
            'mitemEliminar
            '
            resources.ApplyResources(Me.mitemEliminar, "mitemEliminar")
            Me.mitemEliminar.Font = New System.Drawing.Font("楷体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemEliminar.Image = Global.EasyGest.My.Resources.Resources.delete
            Me.mitemEliminar.Name = "mitemEliminar"
            Me.mitemEliminar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'CaracteristicasProductoBindingSource
            '
            Me.CaracteristicasProductoBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.CaracteristicasProducto)
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
            Me.btnCancelar.RootElement.KeyTip = resources.GetString("btnCancelar.RootElement.KeyTip")
            Me.btnCancelar.RootElement.Margin = CType(resources.GetObject("btnCancelar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnCancelar.RootElement.Padding = CType(resources.GetObject("btnCancelar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnCancelar.RootElement.Text = resources.GetString("btnCancelar.RootElement.Text")
            Me.btnCancelar.RootElement.TextOrientation = CType(resources.GetObject("btnCancelar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.btnCancelar.RootElement.ToolTipText = resources.GetString("btnCancelar.RootElement.ToolTipText")
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.cancel
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text1")
            CType(Me.btnCancelar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(10, Byte), Integer))
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
            Me.btnAceptar.RootElement.KeyTip = resources.GetString("btnAceptar.RootElement.KeyTip")
            Me.btnAceptar.RootElement.Margin = CType(resources.GetObject("btnAceptar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnAceptar.RootElement.Padding = CType(resources.GetObject("btnAceptar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnAceptar.RootElement.Text = resources.GetString("btnAceptar.RootElement.Text")
            Me.btnAceptar.RootElement.TextOrientation = CType(resources.GetObject("btnAceptar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.btnAceptar.RootElement.ToolTipText = resources.GetString("btnAceptar.RootElement.ToolTipText")
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.accept
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text2")
            CType(Me.btnAceptar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
            '
            'frmCaracteristicaProducto
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancelar
            Me.Controls.Add(Me.gboxNuevo)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.propgridCaracteristica)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmCaracteristicaProducto"
            Me.Opacity = 0.9R
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmCaracteristicaProducto.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmCaracteristicaProducto.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmCaracteristicaProducto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmCaracteristicaProducto.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmCaracteristicaProducto.RootElement.FlipText"), Boolean)
            Me.RootElement.KeyTip = resources.GetString("frmCaracteristicaProducto.RootElement.KeyTip")
            Me.RootElement.Margin = CType(resources.GetObject("frmCaracteristicaProducto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmCaracteristicaProducto.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmCaracteristicaProducto.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmCaracteristicaProducto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RootElement.ToolTipText = resources.GetString("frmCaracteristicaProducto.RootElement.ToolTipText")
            Me.ShowInTaskbar = False
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gboxNuevo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gboxNuevo.ResumeLayout(False)
            Me.gboxNuevo.PerformLayout()
            CType(Me.btnAgregarCaracteristica, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlTipoCaracteristica, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TiposDatoCaractProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtCaracteristica, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.propgridCaracteristica, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CaracteristicasProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents CaracteristicasProductoBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents timValidar As System.Windows.Forms.Timer
        Friend WithEvents propgridCaracteristica As Telerik.WinControls.UI.RadPropertyGrid
        Friend WithEvents cmenuCaracteristica As Telerik.WinControls.UI.RadContextMenu
        Friend WithEvents mitemEliminar As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents ddlTipoCaracteristica As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents txtCaracteristica As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents btnAgregarCaracteristica As Telerik.WinControls.UI.RadButton
        Friend WithEvents TiposDatoCaractProductoBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents gboxNuevo As Telerik.WinControls.UI.RadGroupBox
    End Class

End Namespace

