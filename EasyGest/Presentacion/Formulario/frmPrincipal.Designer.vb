Namespace Presentacion.Formulario
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmPrincipal
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
            Me.dokPrincipal = New Telerik.WinControls.UI.Docking.RadDock()
            Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.btnSalir = New Telerik.WinControls.UI.RadButton()
            Me.btnConfiguracion = New Telerik.WinControls.UI.RadButton()
            Me.btnInforme = New Telerik.WinControls.UI.RadButton()
            Me.sbtnPedido = New Telerik.WinControls.UI.RadSplitButton()
            Me.mbtnitemPedido = New Telerik.WinControls.UI.RadMenuButtonItem()
            Me.sbtnProducto = New Telerik.WinControls.UI.RadSplitButton()
            Me.mitemImpresionEtiqueta = New Telerik.WinControls.UI.RadMenuItem()
            Me.mbtnitemProducto = New Telerik.WinControls.UI.RadMenuButtonItem()
            Me.sbtnVenta = New Telerik.WinControls.UI.RadSplitButton()
            Me.mitemIniciar = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemCerrar = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemVales = New Telerik.WinControls.UI.RadMenuItem()
            Me.mbtnitemVenta = New Telerik.WinControls.UI.RadMenuButtonItem()
            Me.sbtnProveedor = New Telerik.WinControls.UI.RadSplitButton()
            Me.mitemContactosPro = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemCuentasPro = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemDeberes = New Telerik.WinControls.UI.RadMenuItem()
            Me.mbtnitemProveedor = New Telerik.WinControls.UI.RadMenuButtonItem()
            Me.sbtnCliente = New Telerik.WinControls.UI.RadSplitButton()
            Me.mitemContactosCli = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemCuentasCli = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemTarjetas = New Telerik.WinControls.UI.RadMenuItem()
            Me.mitemHaberes = New Telerik.WinControls.UI.RadMenuItem()
            Me.mbtnitemCliente = New Telerik.WinControls.UI.RadMenuButtonItem()
            Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.doccPrincipal = New Telerik.WinControls.UI.Docking.DocumentContainer()
            Me.RoundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
            Me.sttEstado = New Telerik.WinControls.UI.RadStatusStrip()
            Me.lbleHoraInicio = New Telerik.WinControls.UI.RadLabelElement()
            Me.lbleHoraApertura = New Telerik.WinControls.UI.RadLabelElement()
            Me.lbleEmpresa = New Telerik.WinControls.UI.RadLabelElement()
            Me.lblePuesto = New Telerik.WinControls.UI.RadLabelElement()
            Me.lbleUsuario = New Telerik.WinControls.UI.RadLabelElement()
            Me.lbleVersion = New Telerik.WinControls.UI.RadLabelElement()
            Me.RadStatusBarPanelElement1 = New Telerik.WinControls.UI.RadStatusBarPanelElement()
            Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
            Me.menuPrincipal = New Telerik.WinControls.UI.RadContextMenu(Me.components)
            Me.alertTarea = New Telerik.WinControls.UI.RadDesktopAlert(Me.components)
            CType(Me.dokPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dokPrincipal.SuspendLayout()
            Me.ToolWindow1.SuspendLayout()
            CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnInforme, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbtnPedido, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbtnProducto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbtnVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbtnProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sbtnCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolTabStrip1.SuspendLayout()
            CType(Me.doccPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.sttEstado, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dokPrincipal
            '
            Me.dokPrincipal.ActiveWindow = Me.ToolWindow1
            Me.dokPrincipal.AutoDetectMdiChildren = True
            Me.dokPrincipal.AutoHideAnimation = Telerik.WinControls.UI.Docking.AutoHideAnimateMode.Both
            resources.ApplyResources(Me.dokPrincipal, "dokPrincipal")
            Me.dokPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dokPrincipal.CausesValidation = False
            Me.dokPrincipal.Controls.Add(Me.ToolTabStrip1)
            Me.dokPrincipal.Controls.Add(Me.doccPrincipal)
            Me.dokPrincipal.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.ToBack
            Me.dokPrincipal.DocumentTabsTextOrientation = Telerik.WinControls.UI.TabStripTextOrientation.Horizontal
            Me.dokPrincipal.DragDropMode = Telerik.WinControls.UI.Docking.DragDropMode.Preview
            Me.dokPrincipal.IsCleanUpTarget = True
            Me.dokPrincipal.MainDocumentContainer = Me.doccPrincipal
            Me.dokPrincipal.Name = "dokPrincipal"
            Me.dokPrincipal.QuickNavigatorSettings.DocumentPaneListHeader = "Activar ventana"
            Me.dokPrincipal.QuickNavigatorSettings.ShowFooter = False
            Me.dokPrincipal.QuickNavigatorSettings.ShowPreview = False
            Me.dokPrincipal.QuickNavigatorSettings.ShowToolPanes = False
            '
            '
            '
            Me.dokPrincipal.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.dokPrincipal.ShowDocumentCloseButton = True
            Me.dokPrincipal.ShowDocumentPinButton = True
            Me.dokPrincipal.TabStop = False
            Me.dokPrincipal.ToolWindowInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.ToBack
            '
            'ToolWindow1
            '
            resources.ApplyResources(Me.ToolWindow1, "ToolWindow1")
            Me.ToolWindow1.Caption = Nothing
            Me.ToolWindow1.Controls.Add(Me.btnSalir)
            Me.ToolWindow1.Controls.Add(Me.btnConfiguracion)
            Me.ToolWindow1.Controls.Add(Me.btnInforme)
            Me.ToolWindow1.Controls.Add(Me.sbtnPedido)
            Me.ToolWindow1.Controls.Add(Me.sbtnProducto)
            Me.ToolWindow1.Controls.Add(Me.sbtnVenta)
            Me.ToolWindow1.Controls.Add(Me.sbtnProveedor)
            Me.ToolWindow1.Controls.Add(Me.sbtnCliente)
            Me.ToolWindow1.Name = "ToolWindow1"
            Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide
            '
            'btnSalir
            '
            resources.ApplyResources(Me.btnSalir, "btnSalir")
            Me.btnSalir.Image = Global.EasyGest.My.Resources.Resources.fsalir
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.TabStop = False
            '
            'btnConfiguracion
            '
            resources.ApplyResources(Me.btnConfiguracion, "btnConfiguracion")
            Me.btnConfiguracion.Image = Global.EasyGest.My.Resources.Resources.fconfiguracion
            Me.btnConfiguracion.Name = "btnConfiguracion"
            Me.btnConfiguracion.TabStop = False
            '
            'btnInforme
            '
            resources.ApplyResources(Me.btnInforme, "btnInforme")
            Me.btnInforme.Image = Global.EasyGest.My.Resources.Resources.finforme
            Me.btnInforme.Name = "btnInforme"
            Me.btnInforme.TabStop = False
            '
            'sbtnPedido
            '
            Me.sbtnPedido.DropDownDirection = Telerik.WinControls.UI.RadDirection.Right
            resources.ApplyResources(Me.sbtnPedido, "sbtnPedido")
            Me.sbtnPedido.Image = Global.EasyGest.My.Resources.Resources.fpedido
            Me.sbtnPedido.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.sbtnPedido.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mbtnitemPedido})
            Me.sbtnPedido.Name = "sbtnPedido"
            Me.sbtnPedido.TabStop = False
            Me.sbtnPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.sbtnPedido.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).Image = Global.EasyGest.My.Resources.Resources.fpedido
            CType(Me.sbtnPedido.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.sbtnPedido.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.sbtnPedido.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).Text = resources.GetString("resource.Text")
            CType(Me.sbtnPedido.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).CanFocus = True
            '
            'mbtnitemPedido
            '
            Me.mbtnitemPedido.AccessibleDescription = "Pedido"
            Me.mbtnitemPedido.AccessibleName = "Pedido"
            resources.ApplyResources(Me.mbtnitemPedido, "mbtnitemPedido")
            '
            '
            '
            Me.mbtnitemPedido.ButtonElement.AccessibleDescription = "Pedido"
            Me.mbtnitemPedido.ButtonElement.AccessibleName = "Pedido"
            Me.mbtnitemPedido.ButtonElement.Alignment = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemPedido.ButtonElement.AngleTransform = CType(resources.GetObject("mbtnitemPedido.ButtonElement.AngleTransform"), Single)
            Me.mbtnitemPedido.ButtonElement.FlipText = CType(resources.GetObject("mbtnitemPedido.ButtonElement.FlipText"), Boolean)
            Me.mbtnitemPedido.ButtonElement.Image = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Image"), System.Drawing.Image)
            Me.mbtnitemPedido.ButtonElement.ImageIndex = CType(resources.GetObject("mbtnitemPedido.ButtonElement.ImageIndex"), Integer)
            Me.mbtnitemPedido.ButtonElement.ImageKey = resources.GetString("mbtnitemPedido.ButtonElement.ImageKey")
            Me.mbtnitemPedido.ButtonElement.Margin = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Margin"), System.Windows.Forms.Padding)
            Me.mbtnitemPedido.ButtonElement.Padding = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Padding"), System.Windows.Forms.Padding)
            Me.mbtnitemPedido.ButtonElement.RightToLeft = CType(resources.GetObject("mbtnitemPedido.ButtonElement.RightToLeft"), Boolean)
            Me.mbtnitemPedido.ButtonElement.TextOrientation = CType(resources.GetObject("mbtnitemPedido.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.mbtnitemPedido.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mbtnitemPedido.Image = Global.EasyGest.My.Resources.Resources.fpedido
            Me.mbtnitemPedido.Name = "mbtnitemPedido"
            Me.mbtnitemPedido.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Image1"), System.Drawing.Image)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageIndex = CType(resources.GetObject("mbtnitemPedido.ButtonElement.ImageIndex1"), Integer)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageKey = resources.GetString("mbtnitemPedido.ButtonElement.ImageKey1")
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextOrientation = CType(resources.GetObject("mbtnitemPedido.ButtonElement.TextOrientation1"), System.Windows.Forms.Orientation)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).FlipText = CType(resources.GetObject("mbtnitemPedido.ButtonElement.FlipText1"), Boolean)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Padding = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Padding1"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Margin = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Margin1"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Alignment = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Alignment1"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).RightToLeft = CType(resources.GetObject("mbtnitemPedido.ButtonElement.RightToLeft1"), Boolean)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).AngleTransform = CType(resources.GetObject("mbtnitemPedido.ButtonElement.AngleTransform1"), Single)
            '
            'sbtnProducto
            '
            Me.sbtnProducto.DropDownDirection = Telerik.WinControls.UI.RadDirection.Right
            resources.ApplyResources(Me.sbtnProducto, "sbtnProducto")
            Me.sbtnProducto.Image = Global.EasyGest.My.Resources.Resources.fproducto
            Me.sbtnProducto.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.sbtnProducto.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemImpresionEtiqueta, Me.mbtnitemProducto})
            Me.sbtnProducto.Name = "sbtnProducto"
            Me.sbtnProducto.TabStop = False
            Me.sbtnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.sbtnProducto.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).Image = Global.EasyGest.My.Resources.Resources.fproducto
            CType(Me.sbtnProducto.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.sbtnProducto.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.sbtnProducto.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).Text = resources.GetString("resource.Text1")
            CType(Me.sbtnProducto.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).CanFocus = True
            '
            'mitemImpresionEtiqueta
            '
            resources.ApplyResources(Me.mitemImpresionEtiqueta, "mitemImpresionEtiqueta")
            Me.mitemImpresionEtiqueta.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemImpresionEtiqueta.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.mitemImpresionEtiqueta.Name = "mitemImpresionEtiqueta"
            '
            'mbtnitemProducto
            '
            resources.ApplyResources(Me.mbtnitemProducto, "mbtnitemProducto")
            '
            '
            '
            Me.mbtnitemProducto.ButtonElement.AccessibleDescription = "Producto"
            Me.mbtnitemProducto.ButtonElement.AccessibleName = "Producto"
            Me.mbtnitemProducto.ButtonElement.Alignment = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemProducto.ButtonElement.AngleTransform = CType(resources.GetObject("mbtnitemProducto.ButtonElement.AngleTransform"), Single)
            Me.mbtnitemProducto.ButtonElement.FlipText = CType(resources.GetObject("mbtnitemProducto.ButtonElement.FlipText"), Boolean)
            Me.mbtnitemProducto.ButtonElement.Image = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Image"), System.Drawing.Image)
            Me.mbtnitemProducto.ButtonElement.ImageIndex = CType(resources.GetObject("mbtnitemProducto.ButtonElement.ImageIndex"), Integer)
            Me.mbtnitemProducto.ButtonElement.ImageKey = resources.GetString("mbtnitemProducto.ButtonElement.ImageKey")
            Me.mbtnitemProducto.ButtonElement.Margin = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Margin"), System.Windows.Forms.Padding)
            Me.mbtnitemProducto.ButtonElement.Padding = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Padding"), System.Windows.Forms.Padding)
            Me.mbtnitemProducto.ButtonElement.RightToLeft = CType(resources.GetObject("mbtnitemProducto.ButtonElement.RightToLeft"), Boolean)
            Me.mbtnitemProducto.ButtonElement.TextOrientation = CType(resources.GetObject("mbtnitemProducto.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.mbtnitemProducto.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mbtnitemProducto.Image = Global.EasyGest.My.Resources.Resources.fproducto
            Me.mbtnitemProducto.Name = "mbtnitemProducto"
            Me.mbtnitemProducto.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Image1"), System.Drawing.Image)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageIndex = CType(resources.GetObject("mbtnitemProducto.ButtonElement.ImageIndex1"), Integer)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageKey = resources.GetString("mbtnitemProducto.ButtonElement.ImageKey1")
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextOrientation = CType(resources.GetObject("mbtnitemProducto.ButtonElement.TextOrientation1"), System.Windows.Forms.Orientation)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).FlipText = CType(resources.GetObject("mbtnitemProducto.ButtonElement.FlipText1"), Boolean)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Padding = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Padding1"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Margin = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Margin1"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Alignment = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Alignment1"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).RightToLeft = CType(resources.GetObject("mbtnitemProducto.ButtonElement.RightToLeft1"), Boolean)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).AngleTransform = CType(resources.GetObject("mbtnitemProducto.ButtonElement.AngleTransform1"), Single)
            '
            'sbtnVenta
            '
            Me.sbtnVenta.ArrowDirection = Telerik.WinControls.ArrowDirection.Right
            Me.sbtnVenta.DropDownDirection = Telerik.WinControls.UI.RadDirection.Right
            resources.ApplyResources(Me.sbtnVenta, "sbtnVenta")
            Me.sbtnVenta.Image = Global.EasyGest.My.Resources.Resources.fventa
            Me.sbtnVenta.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.sbtnVenta.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemIniciar, Me.mitemCerrar, Me.mitemVales, Me.mbtnitemVenta})
            Me.sbtnVenta.Name = "sbtnVenta"
            Me.sbtnVenta.TabStop = False
            Me.sbtnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.sbtnVenta.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).Image = Global.EasyGest.My.Resources.Resources.fventa
            CType(Me.sbtnVenta.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.sbtnVenta.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.sbtnVenta.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).Text = resources.GetString("resource.Text2")
            CType(Me.sbtnVenta.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).CanFocus = True
            '
            'mitemIniciar
            '
            Me.mitemIniciar.AccessibleDescription = "Iniciar Sesión"
            resources.ApplyResources(Me.mitemIniciar, "mitemIniciar")
            Me.mitemIniciar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemIniciar.Image = Global.EasyGest.My.Resources.Resources.finiciar
            Me.mitemIniciar.Name = "mitemIniciar"
            Me.mitemIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'mitemCerrar
            '
            Me.mitemCerrar.AccessibleDescription = "Cerrar"
            resources.ApplyResources(Me.mitemCerrar, "mitemCerrar")
            Me.mitemCerrar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemCerrar.Image = Global.EasyGest.My.Resources.Resources.fcerrar
            Me.mitemCerrar.Name = "mitemCerrar"
            Me.mitemCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            '
            'mitemVales
            '
            resources.ApplyResources(Me.mitemVales, "mitemVales")
            Me.mitemVales.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemVales.Image = Global.EasyGest.My.Resources.Resources._85
            Me.mitemVales.Name = "mitemVales"
            '
            'mbtnitemVenta
            '
            Me.mbtnitemVenta.AccessibleDescription = "Venta"
            Me.mbtnitemVenta.AccessibleName = "Venta"
            resources.ApplyResources(Me.mbtnitemVenta, "mbtnitemVenta")
            '
            '
            '
            Me.mbtnitemVenta.ButtonElement.AccessibleDescription = "Venta"
            Me.mbtnitemVenta.ButtonElement.AccessibleName = "Venta"
            Me.mbtnitemVenta.ButtonElement.Alignment = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemVenta.ButtonElement.AngleTransform = CType(resources.GetObject("mbtnitemVenta.ButtonElement.AngleTransform"), Single)
            Me.mbtnitemVenta.ButtonElement.FlipText = CType(resources.GetObject("mbtnitemVenta.ButtonElement.FlipText"), Boolean)
            Me.mbtnitemVenta.ButtonElement.Image = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Image"), System.Drawing.Image)
            Me.mbtnitemVenta.ButtonElement.ImageIndex = CType(resources.GetObject("mbtnitemVenta.ButtonElement.ImageIndex"), Integer)
            Me.mbtnitemVenta.ButtonElement.ImageKey = resources.GetString("mbtnitemVenta.ButtonElement.ImageKey")
            Me.mbtnitemVenta.ButtonElement.Margin = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Margin"), System.Windows.Forms.Padding)
            Me.mbtnitemVenta.ButtonElement.Padding = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Padding"), System.Windows.Forms.Padding)
            Me.mbtnitemVenta.ButtonElement.RightToLeft = CType(resources.GetObject("mbtnitemVenta.ButtonElement.RightToLeft"), Boolean)
            Me.mbtnitemVenta.ButtonElement.TextOrientation = CType(resources.GetObject("mbtnitemVenta.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.mbtnitemVenta.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mbtnitemVenta.Image = Global.EasyGest.My.Resources.Resources.fventa
            Me.mbtnitemVenta.Name = "mbtnitemVenta"
            Me.mbtnitemVenta.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Image1"), System.Drawing.Image)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageIndex = CType(resources.GetObject("mbtnitemVenta.ButtonElement.ImageIndex1"), Integer)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageKey = resources.GetString("mbtnitemVenta.ButtonElement.ImageKey1")
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextOrientation = CType(resources.GetObject("mbtnitemVenta.ButtonElement.TextOrientation1"), System.Windows.Forms.Orientation)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).FlipText = CType(resources.GetObject("mbtnitemVenta.ButtonElement.FlipText1"), Boolean)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Padding = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Padding1"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Margin = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Margin1"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Alignment = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Alignment1"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).RightToLeft = CType(resources.GetObject("mbtnitemVenta.ButtonElement.RightToLeft1"), Boolean)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).AngleTransform = CType(resources.GetObject("mbtnitemVenta.ButtonElement.AngleTransform1"), Single)
            '
            'sbtnProveedor
            '
            Me.sbtnProveedor.ArrowDirection = Telerik.WinControls.ArrowDirection.Right
            Me.sbtnProveedor.DropDownDirection = Telerik.WinControls.UI.RadDirection.Right
            resources.ApplyResources(Me.sbtnProveedor, "sbtnProveedor")
            Me.sbtnProveedor.Image = Global.EasyGest.My.Resources.Resources.fproveedor
            Me.sbtnProveedor.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.sbtnProveedor.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemContactosPro, Me.mitemCuentasPro, Me.mitemDeberes, Me.mbtnitemProveedor})
            Me.sbtnProveedor.Name = "sbtnProveedor"
            Me.sbtnProveedor.TabStop = False
            Me.sbtnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.sbtnProveedor.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).Image = Global.EasyGest.My.Resources.Resources.fproveedor
            CType(Me.sbtnProveedor.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.sbtnProveedor.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.sbtnProveedor.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).Text = resources.GetString("resource.Text3")
            CType(Me.sbtnProveedor.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).CanFocus = True
            '
            'mitemContactosPro
            '
            resources.ApplyResources(Me.mitemContactosPro, "mitemContactosPro")
            Me.mitemContactosPro.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemContactosPro.Image = Global.EasyGest.My.Resources.Resources._75
            Me.mitemContactosPro.Name = "mitemContactosPro"
            '
            'mitemCuentasPro
            '
            resources.ApplyResources(Me.mitemCuentasPro, "mitemCuentasPro")
            Me.mitemCuentasPro.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemCuentasPro.Image = Global.EasyGest.My.Resources.Resources._80
            Me.mitemCuentasPro.Name = "mitemCuentasPro"
            '
            'mitemDeberes
            '
            Me.mitemDeberes.AccessibleDescription = "Deberes a pagar"
            resources.ApplyResources(Me.mitemDeberes, "mitemDeberes")
            Me.mitemDeberes.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemDeberes.Name = "mitemDeberes"
            '
            'mbtnitemProveedor
            '
            Me.mbtnitemProveedor.AccessibleDescription = "Proveedor"
            Me.mbtnitemProveedor.AccessibleName = "Proveedor"
            resources.ApplyResources(Me.mbtnitemProveedor, "mbtnitemProveedor")
            '
            '
            '
            Me.mbtnitemProveedor.ButtonElement.AccessibleDescription = "Proveedor"
            Me.mbtnitemProveedor.ButtonElement.AccessibleName = "Proveedor"
            Me.mbtnitemProveedor.ButtonElement.Alignment = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemProveedor.ButtonElement.AngleTransform = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.AngleTransform"), Single)
            Me.mbtnitemProveedor.ButtonElement.FlipText = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.FlipText"), Boolean)
            Me.mbtnitemProveedor.ButtonElement.Image = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Image"), System.Drawing.Image)
            Me.mbtnitemProveedor.ButtonElement.ImageIndex = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.ImageIndex"), Integer)
            Me.mbtnitemProveedor.ButtonElement.ImageKey = resources.GetString("mbtnitemProveedor.ButtonElement.ImageKey")
            Me.mbtnitemProveedor.ButtonElement.Margin = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Margin"), System.Windows.Forms.Padding)
            Me.mbtnitemProveedor.ButtonElement.Padding = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Padding"), System.Windows.Forms.Padding)
            Me.mbtnitemProveedor.ButtonElement.RightToLeft = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.RightToLeft"), Boolean)
            Me.mbtnitemProveedor.ButtonElement.TextOrientation = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.mbtnitemProveedor.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!)
            Me.mbtnitemProveedor.Image = Global.EasyGest.My.Resources.Resources.fproveedor
            Me.mbtnitemProveedor.Name = "mbtnitemProveedor"
            Me.mbtnitemProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.mbtnitemProveedor.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Image1"), System.Drawing.Image)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageIndex = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.ImageIndex1"), Integer)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageKey = resources.GetString("mbtnitemProveedor.ButtonElement.ImageKey1")
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextOrientation = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.TextOrientation1"), System.Windows.Forms.Orientation)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).FlipText = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.FlipText1"), Boolean)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Padding = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Padding1"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Margin = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Margin1"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Alignment = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Alignment1"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).RightToLeft = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.RightToLeft1"), Boolean)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).AngleTransform = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.AngleTransform1"), Single)
            '
            'sbtnCliente
            '
            Me.sbtnCliente.ArrowDirection = Telerik.WinControls.ArrowDirection.Right
            Me.sbtnCliente.DropDownDirection = Telerik.WinControls.UI.RadDirection.Right
            resources.ApplyResources(Me.sbtnCliente, "sbtnCliente")
            Me.sbtnCliente.Image = Global.EasyGest.My.Resources.Resources.fcliente
            Me.sbtnCliente.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.sbtnCliente.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemContactosCli, Me.mitemCuentasCli, Me.mitemTarjetas, Me.mitemHaberes, Me.mbtnitemCliente})
            Me.sbtnCliente.Name = "sbtnCliente"
            Me.sbtnCliente.TabStop = False
            Me.sbtnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.sbtnCliente.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).Image = Global.EasyGest.My.Resources.Resources.fcliente
            CType(Me.sbtnCliente.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.sbtnCliente.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.sbtnCliente.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).Text = resources.GetString("resource.Text4")
            CType(Me.sbtnCliente.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).CanFocus = True
            CType(Me.sbtnCliente.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.ActionButtonElement).UseDefaultDisabledPaint = True
            '
            'mitemContactosCli
            '
            resources.ApplyResources(Me.mitemContactosCli, "mitemContactosCli")
            Me.mitemContactosCli.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemContactosCli.Image = Global.EasyGest.My.Resources.Resources._75
            Me.mitemContactosCli.Name = "mitemContactosCli"
            '
            'mitemCuentasCli
            '
            resources.ApplyResources(Me.mitemCuentasCli, "mitemCuentasCli")
            Me.mitemCuentasCli.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemCuentasCli.Image = Global.EasyGest.My.Resources.Resources._80
            Me.mitemCuentasCli.Name = "mitemCuentasCli"
            '
            'mitemTarjetas
            '
            Me.mitemTarjetas.AccessibleDescription = "Tarjetas"
            resources.ApplyResources(Me.mitemTarjetas, "mitemTarjetas")
            Me.mitemTarjetas.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemTarjetas.Image = Global.EasyGest.My.Resources.Resources._60
            Me.mitemTarjetas.Name = "mitemTarjetas"
            '
            'mitemHaberes
            '
            Me.mitemHaberes.AccessibleDescription = "Haberes a cobrar"
            resources.ApplyResources(Me.mitemHaberes, "mitemHaberes")
            Me.mitemHaberes.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemHaberes.Image = Global.EasyGest.My.Resources.Resources._35
            Me.mitemHaberes.Name = "mitemHaberes"
            '
            'mbtnitemCliente
            '
            Me.mbtnitemCliente.AccessibleDescription = "Cliente"
            Me.mbtnitemCliente.AccessibleName = "Cliente"
            resources.ApplyResources(Me.mbtnitemCliente, "mbtnitemCliente")
            '
            '
            '
            Me.mbtnitemCliente.ButtonElement.AccessibleDescription = "Cliente"
            Me.mbtnitemCliente.ButtonElement.AccessibleName = "Cliente"
            Me.mbtnitemCliente.ButtonElement.Alignment = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemCliente.ButtonElement.AngleTransform = CType(resources.GetObject("mbtnitemCliente.ButtonElement.AngleTransform"), Single)
            Me.mbtnitemCliente.ButtonElement.FlipText = CType(resources.GetObject("mbtnitemCliente.ButtonElement.FlipText"), Boolean)
            Me.mbtnitemCliente.ButtonElement.Image = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Image"), System.Drawing.Image)
            Me.mbtnitemCliente.ButtonElement.ImageIndex = CType(resources.GetObject("mbtnitemCliente.ButtonElement.ImageIndex"), Integer)
            Me.mbtnitemCliente.ButtonElement.ImageKey = resources.GetString("mbtnitemCliente.ButtonElement.ImageKey")
            Me.mbtnitemCliente.ButtonElement.Margin = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Margin"), System.Windows.Forms.Padding)
            Me.mbtnitemCliente.ButtonElement.Padding = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Padding"), System.Windows.Forms.Padding)
            Me.mbtnitemCliente.ButtonElement.RightToLeft = CType(resources.GetObject("mbtnitemCliente.ButtonElement.RightToLeft"), Boolean)
            Me.mbtnitemCliente.ButtonElement.TextOrientation = CType(resources.GetObject("mbtnitemCliente.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.mbtnitemCliente.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mbtnitemCliente.Image = Global.EasyGest.My.Resources.Resources.fcliente
            Me.mbtnitemCliente.Name = "mbtnitemCliente"
            Me.mbtnitemCliente.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Image1"), System.Drawing.Image)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageIndex = CType(resources.GetObject("mbtnitemCliente.ButtonElement.ImageIndex1"), Integer)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageKey = resources.GetString("mbtnitemCliente.ButtonElement.ImageKey1")
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextOrientation = CType(resources.GetObject("mbtnitemCliente.ButtonElement.TextOrientation1"), System.Windows.Forms.Orientation)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).FlipText = CType(resources.GetObject("mbtnitemCliente.ButtonElement.FlipText1"), Boolean)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Padding = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Padding1"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Margin = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Margin1"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Alignment = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Alignment1"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).RightToLeft = CType(resources.GetObject("mbtnitemCliente.ButtonElement.RightToLeft1"), Boolean)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).AngleTransform = CType(resources.GetObject("mbtnitemCliente.ButtonElement.AngleTransform1"), Single)
            '
            'ToolTabStrip1
            '
            Me.ToolTabStrip1.CanUpdateChildIndex = True
            Me.ToolTabStrip1.CausesValidation = False
            Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
            resources.ApplyResources(Me.ToolTabStrip1, "ToolTabStrip1")
            Me.ToolTabStrip1.Name = "ToolTabStrip1"
            '
            '
            '
            Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.ToolTabStrip1.SelectedIndex = 0
            Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(147, 200)
            Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-53, 0)
            Me.ToolTabStrip1.TabStop = False
            CType(Me.ToolTabStrip1.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.Docking.ToolWindowCaptionElement).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            'doccPrincipal
            '
            resources.ApplyResources(Me.doccPrincipal, "doccPrincipal")
            Me.doccPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.doccPrincipal.Name = "doccPrincipal"
            '
            '
            '
            Me.doccPrincipal.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.doccPrincipal.SizeInfo.AbsoluteSize = New System.Drawing.Size(642, 393)
            Me.doccPrincipal.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
            Me.doccPrincipal.SizeInfo.SplitterCorrection = New System.Drawing.Size(-429, 156)
            CType(Me.doccPrincipal.GetChildAt(0), Telerik.WinControls.UI.SplitPanelElement).Padding = CType(resources.GetObject("resource.Padding"), System.Windows.Forms.Padding)
            CType(Me.doccPrincipal.GetChildAt(0), Telerik.WinControls.UI.SplitPanelElement).Shape = Nothing
            CType(Me.doccPrincipal.GetChildAt(1), Telerik.WinControls.UI.SplitContainerElement).SplitterWidth = 4
            CType(Me.doccPrincipal.GetChildAt(1), Telerik.WinControls.UI.SplitContainerElement).Shape = Nothing
            '
            'sttEstado
            '
            Me.sttEstado.Items.AddRange(New Telerik.WinControls.RadItem() {Me.lbleHoraInicio, Me.lbleHoraApertura, Me.lbleEmpresa, Me.lblePuesto, Me.lbleUsuario, Me.lbleVersion, Me.RadStatusBarPanelElement1})
            resources.ApplyResources(Me.sttEstado, "sttEstado")
            Me.sttEstado.Name = "sttEstado"
            '
            'lbleHoraInicio
            '
            resources.ApplyResources(Me.lbleHoraInicio, "lbleHoraInicio")
            Me.lbleHoraInicio.Font = New System.Drawing.Font("楷体", 9.0!)
            Me.lbleHoraInicio.Name = "lbleHoraInicio"
            Me.sttEstado.SetSpring(Me.lbleHoraInicio, False)
            Me.lbleHoraInicio.TextWrap = True
            '
            'lbleHoraApertura
            '
            Me.lbleHoraApertura.Font = New System.Drawing.Font("楷体", 9.0!)
            Me.lbleHoraApertura.Name = "lbleHoraApertura"
            Me.sttEstado.SetSpring(Me.lbleHoraApertura, False)
            Me.lbleHoraApertura.TextWrap = True
            '
            'lbleEmpresa
            '
            resources.ApplyResources(Me.lbleEmpresa, "lbleEmpresa")
            Me.lbleEmpresa.Font = New System.Drawing.Font("楷体", 9.0!)
            Me.lbleEmpresa.Name = "lbleEmpresa"
            Me.sttEstado.SetSpring(Me.lbleEmpresa, False)
            Me.lbleEmpresa.TextWrap = True
            '
            'lblePuesto
            '
            resources.ApplyResources(Me.lblePuesto, "lblePuesto")
            Me.lblePuesto.Font = New System.Drawing.Font("楷体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblePuesto.Name = "lblePuesto"
            Me.sttEstado.SetSpring(Me.lblePuesto, True)
            Me.lblePuesto.TextWrap = True
            '
            'lbleUsuario
            '
            resources.ApplyResources(Me.lbleUsuario, "lbleUsuario")
            Me.lbleUsuario.Font = New System.Drawing.Font("楷体", 9.0!)
            Me.lbleUsuario.Name = "lbleUsuario"
            Me.sttEstado.SetSpring(Me.lbleUsuario, False)
            Me.lbleUsuario.TextWrap = True
            '
            'lbleVersion
            '
            resources.ApplyResources(Me.lbleVersion, "lbleVersion")
            Me.lbleVersion.Font = New System.Drawing.Font("楷体", 9.0!)
            Me.lbleVersion.Name = "lbleVersion"
            Me.sttEstado.SetSpring(Me.lbleVersion, False)
            Me.lbleVersion.TextWrap = True
            '
            'RadStatusBarPanelElement1
            '
            Me.RadStatusBarPanelElement1.AutoSize = False
            Me.RadStatusBarPanelElement1.Bounds = New System.Drawing.Rectangle(0, 0, 2, 18)
            Me.RadStatusBarPanelElement1.Name = "RadStatusBarPanelElement1"
            Me.sttEstado.SetSpring(Me.RadStatusBarPanelElement1, False)
            resources.ApplyResources(Me.RadStatusBarPanelElement1, "RadStatusBarPanelElement1")
            '
            'alertTarea
            '
            Me.alertTarea.AutoCloseDelay = 8
            Me.alertTarea.AutoSize = True
            Me.alertTarea.CaptionText = "提醒 - Aviso"
            Me.alertTarea.ContentImage = Global.EasyGest.My.Resources.Resources.AQUA_ICONS_SYSTEM_ALERT_NOTE_ICON
            Me.alertTarea.Opacity = 1.0!
            Me.alertTarea.PopupAnimationDirection = Telerik.WinControls.UI.RadDirection.Up
            Me.alertTarea.ShowOptionsButton = False
            Me.alertTarea.ShowPinButton = False
            Me.alertTarea.ThemeName = ""
            '
            'frmPrincipal
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dokPrincipal)
            Me.Controls.Add(Me.sttEstado)
            Me.IsMdiContainer = True
            Me.KeyPreview = True
            Me.Name = "frmPrincipal"
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.dokPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dokPrincipal.ResumeLayout(False)
            Me.ToolWindow1.ResumeLayout(False)
            CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnInforme, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbtnPedido, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbtnProducto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbtnVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbtnProveedor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sbtnCliente, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolTabStrip1.ResumeLayout(False)
            CType(Me.doccPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.sttEstado, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents dokPrincipal As Telerik.WinControls.UI.Docking.RadDock
        Friend WithEvents doccPrincipal As Telerik.WinControls.UI.Docking.DocumentContainer
        Friend WithEvents btnConfiguracion As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnInforme As Telerik.WinControls.UI.RadButton
        Friend WithEvents sbtnCliente As Telerik.WinControls.UI.RadSplitButton
        Friend WithEvents sbtnProducto As Telerik.WinControls.UI.RadSplitButton
        Friend WithEvents sbtnProveedor As Telerik.WinControls.UI.RadSplitButton
        Friend WithEvents btnSalir As Telerik.WinControls.UI.RadButton
        Friend WithEvents mitemIniciar As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mitemCerrar As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
        Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
        Friend WithEvents RoundRectShape1 As Telerik.WinControls.RoundRectShape
        Friend WithEvents sttEstado As Telerik.WinControls.UI.RadStatusStrip
        Friend WithEvents lbleHoraInicio As Telerik.WinControls.UI.RadLabelElement
        Friend WithEvents lblePuesto As Telerik.WinControls.UI.RadLabelElement
        Friend WithEvents lbleUsuario As Telerik.WinControls.UI.RadLabelElement
        Friend WithEvents lbleVersion As Telerik.WinControls.UI.RadLabelElement
        Friend WithEvents mitemContactosCli As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mbtnitemCliente As Telerik.WinControls.UI.RadMenuButtonItem
        Friend WithEvents mitemCuentasCli As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mitemTarjetas As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mitemContactosPro As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mbtnitemProveedor As Telerik.WinControls.UI.RadMenuButtonItem
        Friend WithEvents mitemCuentasPro As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents lbleEmpresa As Telerik.WinControls.UI.RadLabelElement
        Friend WithEvents mitemImpresionEtiqueta As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mbtnitemProducto As Telerik.WinControls.UI.RadMenuButtonItem
        Friend WithEvents sbtnPedido As Telerik.WinControls.UI.RadSplitButton
        Friend WithEvents sbtnVenta As Telerik.WinControls.UI.RadSplitButton
        Friend WithEvents mitemVales As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mbtnitemVenta As Telerik.WinControls.UI.RadMenuButtonItem
        Friend WithEvents mbtnitemPedido As Telerik.WinControls.UI.RadMenuButtonItem
        Friend WithEvents mitemDeberes As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mitemHaberes As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
        Friend WithEvents lbleHoraApertura As Telerik.WinControls.UI.RadLabelElement
        Friend WithEvents menuPrincipal As Telerik.WinControls.UI.RadContextMenu
        Friend WithEvents RadStatusBarPanelElement1 As Telerik.WinControls.UI.RadStatusBarPanelElement
        Friend WithEvents alertTarea As Telerik.WinControls.UI.RadDesktopAlert
    End Class

End Namespace

