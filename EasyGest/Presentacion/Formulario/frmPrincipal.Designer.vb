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
            Me.dokPrincipal.RootElement.AccessibleDescription = resources.GetString("dokPrincipal.RootElement.AccessibleDescription")
            Me.dokPrincipal.RootElement.AccessibleName = resources.GetString("dokPrincipal.RootElement.AccessibleName")
            Me.dokPrincipal.RootElement.Alignment = CType(resources.GetObject("dokPrincipal.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.dokPrincipal.RootElement.AngleTransform = CType(resources.GetObject("dokPrincipal.RootElement.AngleTransform"), Single)
            Me.dokPrincipal.RootElement.FlipText = CType(resources.GetObject("dokPrincipal.RootElement.FlipText"), Boolean)
            Me.dokPrincipal.RootElement.Margin = CType(resources.GetObject("dokPrincipal.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.dokPrincipal.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.dokPrincipal.RootElement.Text = resources.GetString("dokPrincipal.RootElement.Text")
            Me.dokPrincipal.RootElement.TextOrientation = CType(resources.GetObject("dokPrincipal.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.dokPrincipal.ShowDocumentCloseButton = True
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
            '
            '
            '
            Me.btnSalir.RootElement.AccessibleDescription = resources.GetString("btnSalir.RootElement.AccessibleDescription")
            Me.btnSalir.RootElement.AccessibleName = resources.GetString("btnSalir.RootElement.AccessibleName")
            Me.btnSalir.RootElement.Alignment = CType(resources.GetObject("btnSalir.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnSalir.RootElement.AngleTransform = CType(resources.GetObject("btnSalir.RootElement.AngleTransform"), Single)
            Me.btnSalir.RootElement.FlipText = CType(resources.GetObject("btnSalir.RootElement.FlipText"), Boolean)
            Me.btnSalir.RootElement.Margin = CType(resources.GetObject("btnSalir.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnSalir.RootElement.Text = resources.GetString("btnSalir.RootElement.Text")
            Me.btnSalir.RootElement.TextOrientation = CType(resources.GetObject("btnSalir.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.btnSalir.TabStop = False
            '
            'btnConfiguracion
            '
            resources.ApplyResources(Me.btnConfiguracion, "btnConfiguracion")
            Me.btnConfiguracion.Image = Global.EasyGest.My.Resources.Resources.fconfiguracion
            Me.btnConfiguracion.Name = "btnConfiguracion"
            '
            '
            '
            Me.btnConfiguracion.RootElement.AccessibleDescription = resources.GetString("btnConfiguracion.RootElement.AccessibleDescription")
            Me.btnConfiguracion.RootElement.AccessibleName = resources.GetString("btnConfiguracion.RootElement.AccessibleName")
            Me.btnConfiguracion.RootElement.Alignment = CType(resources.GetObject("btnConfiguracion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnConfiguracion.RootElement.AngleTransform = CType(resources.GetObject("btnConfiguracion.RootElement.AngleTransform"), Single)
            Me.btnConfiguracion.RootElement.FlipText = CType(resources.GetObject("btnConfiguracion.RootElement.FlipText"), Boolean)
            Me.btnConfiguracion.RootElement.Margin = CType(resources.GetObject("btnConfiguracion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnConfiguracion.RootElement.Text = resources.GetString("btnConfiguracion.RootElement.Text")
            Me.btnConfiguracion.RootElement.TextOrientation = CType(resources.GetObject("btnConfiguracion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.btnConfiguracion.TabStop = False
            '
            'btnInforme
            '
            resources.ApplyResources(Me.btnInforme, "btnInforme")
            Me.btnInforme.Image = Global.EasyGest.My.Resources.Resources.finforme
            Me.btnInforme.Name = "btnInforme"
            '
            '
            '
            Me.btnInforme.RootElement.AccessibleDescription = resources.GetString("btnInforme.RootElement.AccessibleDescription")
            Me.btnInforme.RootElement.AccessibleName = resources.GetString("btnInforme.RootElement.AccessibleName")
            Me.btnInforme.RootElement.Alignment = CType(resources.GetObject("btnInforme.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnInforme.RootElement.AngleTransform = CType(resources.GetObject("btnInforme.RootElement.AngleTransform"), Single)
            Me.btnInforme.RootElement.FlipText = CType(resources.GetObject("btnInforme.RootElement.FlipText"), Boolean)
            Me.btnInforme.RootElement.Margin = CType(resources.GetObject("btnInforme.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnInforme.RootElement.Text = resources.GetString("btnInforme.RootElement.Text")
            Me.btnInforme.RootElement.TextOrientation = CType(resources.GetObject("btnInforme.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            '
            '
            '
            Me.sbtnPedido.RootElement.AccessibleDescription = resources.GetString("sbtnPedido.RootElement.AccessibleDescription")
            Me.sbtnPedido.RootElement.AccessibleName = resources.GetString("sbtnPedido.RootElement.AccessibleName")
            Me.sbtnPedido.RootElement.Alignment = CType(resources.GetObject("sbtnPedido.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.sbtnPedido.RootElement.AngleTransform = CType(resources.GetObject("sbtnPedido.RootElement.AngleTransform"), Single)
            Me.sbtnPedido.RootElement.FlipText = CType(resources.GetObject("sbtnPedido.RootElement.FlipText"), Boolean)
            Me.sbtnPedido.RootElement.Margin = CType(resources.GetObject("sbtnPedido.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.sbtnPedido.RootElement.Text = resources.GetString("sbtnPedido.RootElement.Text")
            Me.sbtnPedido.RootElement.TextOrientation = CType(resources.GetObject("sbtnPedido.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            resources.ApplyResources(Me.mbtnitemPedido, "mbtnitemPedido")
            '
            '
            '
            Me.mbtnitemPedido.ButtonElement.AccessibleDescription = resources.GetString("mbtnitemPedido.ButtonElement.AccessibleDescription")
            Me.mbtnitemPedido.ButtonElement.AccessibleName = resources.GetString("mbtnitemPedido.ButtonElement.AccessibleName")
            Me.mbtnitemPedido.ButtonElement.Alignment = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemPedido.ButtonElement.AngleTransform = CType(resources.GetObject("mbtnitemPedido.ButtonElement.AngleTransform"), Single)
            Me.mbtnitemPedido.ButtonElement.FlipText = CType(resources.GetObject("mbtnitemPedido.ButtonElement.FlipText"), Boolean)
            Me.mbtnitemPedido.ButtonElement.Image = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Image"), System.Drawing.Image)
            Me.mbtnitemPedido.ButtonElement.ImageIndex = CType(resources.GetObject("mbtnitemPedido.ButtonElement.ImageIndex"), Integer)
            Me.mbtnitemPedido.ButtonElement.ImageKey = resources.GetString("mbtnitemPedido.ButtonElement.ImageKey")
            Me.mbtnitemPedido.ButtonElement.Margin = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Margin"), System.Windows.Forms.Padding)
            Me.mbtnitemPedido.ButtonElement.Padding = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Padding"), System.Windows.Forms.Padding)
            Me.mbtnitemPedido.ButtonElement.RightToLeft = CType(resources.GetObject("mbtnitemPedido.ButtonElement.RightToLeft"), Boolean)
            Me.mbtnitemPedido.ButtonElement.TextAlignment = CType(resources.GetObject("mbtnitemPedido.ButtonElement.TextAlignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemPedido.ButtonElement.TextOrientation = CType(resources.GetObject("mbtnitemPedido.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.mbtnitemPedido.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mbtnitemPedido.Image = Global.EasyGest.My.Resources.Resources.fpedido
            Me.mbtnitemPedido.Name = "mbtnitemPedido"
            Me.mbtnitemPedido.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Image"), System.Drawing.Image)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageIndex = CType(resources.GetObject("mbtnitemPedido.ButtonElement.ImageIndex"), Integer)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageKey = resources.GetString("mbtnitemPedido.ButtonElement.ImageKey")
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextAlignment = CType(resources.GetObject("mbtnitemPedido.ButtonElement.TextAlignment"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextOrientation = CType(resources.GetObject("mbtnitemPedido.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).FlipText = CType(resources.GetObject("mbtnitemPedido.ButtonElement.FlipText"), Boolean)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Padding = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Padding"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Margin = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Margin"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Alignment = CType(resources.GetObject("mbtnitemPedido.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).RightToLeft = CType(resources.GetObject("mbtnitemPedido.ButtonElement.RightToLeft"), Boolean)
            CType(Me.mbtnitemPedido.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).AngleTransform = CType(resources.GetObject("mbtnitemPedido.ButtonElement.AngleTransform"), Single)
            '
            'sbtnProducto
            '
            Me.sbtnProducto.DropDownDirection = Telerik.WinControls.UI.RadDirection.Right
            resources.ApplyResources(Me.sbtnProducto, "sbtnProducto")
            Me.sbtnProducto.Image = Global.EasyGest.My.Resources.Resources.fproducto
            Me.sbtnProducto.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.sbtnProducto.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemImpresionEtiqueta, Me.mbtnitemProducto})
            Me.sbtnProducto.Name = "sbtnProducto"
            '
            '
            '
            Me.sbtnProducto.RootElement.AccessibleDescription = resources.GetString("sbtnProducto.RootElement.AccessibleDescription")
            Me.sbtnProducto.RootElement.AccessibleName = resources.GetString("sbtnProducto.RootElement.AccessibleName")
            Me.sbtnProducto.RootElement.Alignment = CType(resources.GetObject("sbtnProducto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.sbtnProducto.RootElement.AngleTransform = CType(resources.GetObject("sbtnProducto.RootElement.AngleTransform"), Single)
            Me.sbtnProducto.RootElement.FlipText = CType(resources.GetObject("sbtnProducto.RootElement.FlipText"), Boolean)
            Me.sbtnProducto.RootElement.Margin = CType(resources.GetObject("sbtnProducto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.sbtnProducto.RootElement.Text = resources.GetString("sbtnProducto.RootElement.Text")
            Me.sbtnProducto.RootElement.TextOrientation = CType(resources.GetObject("sbtnProducto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.mitemImpresionEtiqueta.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mbtnitemProducto
            '
            resources.ApplyResources(Me.mbtnitemProducto, "mbtnitemProducto")
            '
            '
            '
            Me.mbtnitemProducto.ButtonElement.AccessibleDescription = resources.GetString("mbtnitemProducto.ButtonElement.AccessibleDescription")
            Me.mbtnitemProducto.ButtonElement.AccessibleName = resources.GetString("mbtnitemProducto.ButtonElement.AccessibleName")
            Me.mbtnitemProducto.ButtonElement.Alignment = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemProducto.ButtonElement.AngleTransform = CType(resources.GetObject("mbtnitemProducto.ButtonElement.AngleTransform"), Single)
            Me.mbtnitemProducto.ButtonElement.FlipText = CType(resources.GetObject("mbtnitemProducto.ButtonElement.FlipText"), Boolean)
            Me.mbtnitemProducto.ButtonElement.Image = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Image"), System.Drawing.Image)
            Me.mbtnitemProducto.ButtonElement.ImageIndex = CType(resources.GetObject("mbtnitemProducto.ButtonElement.ImageIndex"), Integer)
            Me.mbtnitemProducto.ButtonElement.ImageKey = resources.GetString("mbtnitemProducto.ButtonElement.ImageKey")
            Me.mbtnitemProducto.ButtonElement.Margin = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Margin"), System.Windows.Forms.Padding)
            Me.mbtnitemProducto.ButtonElement.Padding = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Padding"), System.Windows.Forms.Padding)
            Me.mbtnitemProducto.ButtonElement.RightToLeft = CType(resources.GetObject("mbtnitemProducto.ButtonElement.RightToLeft"), Boolean)
            Me.mbtnitemProducto.ButtonElement.TextAlignment = CType(resources.GetObject("mbtnitemProducto.ButtonElement.TextAlignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemProducto.ButtonElement.TextOrientation = CType(resources.GetObject("mbtnitemProducto.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.mbtnitemProducto.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mbtnitemProducto.Image = Global.EasyGest.My.Resources.Resources.fproducto
            Me.mbtnitemProducto.Name = "mbtnitemProducto"
            Me.mbtnitemProducto.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Image"), System.Drawing.Image)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageIndex = CType(resources.GetObject("mbtnitemProducto.ButtonElement.ImageIndex"), Integer)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageKey = resources.GetString("mbtnitemProducto.ButtonElement.ImageKey")
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextAlignment = CType(resources.GetObject("mbtnitemProducto.ButtonElement.TextAlignment"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextOrientation = CType(resources.GetObject("mbtnitemProducto.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).FlipText = CType(resources.GetObject("mbtnitemProducto.ButtonElement.FlipText"), Boolean)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Padding = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Padding"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Margin = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Margin"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Alignment = CType(resources.GetObject("mbtnitemProducto.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).RightToLeft = CType(resources.GetObject("mbtnitemProducto.ButtonElement.RightToLeft"), Boolean)
            CType(Me.mbtnitemProducto.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).AngleTransform = CType(resources.GetObject("mbtnitemProducto.ButtonElement.AngleTransform"), Single)
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
            '
            '
            '
            Me.sbtnVenta.RootElement.AccessibleDescription = resources.GetString("sbtnVenta.RootElement.AccessibleDescription")
            Me.sbtnVenta.RootElement.AccessibleName = resources.GetString("sbtnVenta.RootElement.AccessibleName")
            Me.sbtnVenta.RootElement.Alignment = CType(resources.GetObject("sbtnVenta.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.sbtnVenta.RootElement.AngleTransform = CType(resources.GetObject("sbtnVenta.RootElement.AngleTransform"), Single)
            Me.sbtnVenta.RootElement.FlipText = CType(resources.GetObject("sbtnVenta.RootElement.FlipText"), Boolean)
            Me.sbtnVenta.RootElement.Margin = CType(resources.GetObject("sbtnVenta.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.sbtnVenta.RootElement.Text = resources.GetString("sbtnVenta.RootElement.Text")
            Me.sbtnVenta.RootElement.TextOrientation = CType(resources.GetObject("sbtnVenta.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            resources.ApplyResources(Me.mitemIniciar, "mitemIniciar")
            Me.mitemIniciar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemIniciar.Image = Global.EasyGest.My.Resources.Resources.finiciar
            Me.mitemIniciar.Name = "mitemIniciar"
            Me.mitemIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.mitemIniciar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mitemCerrar
            '
            resources.ApplyResources(Me.mitemCerrar, "mitemCerrar")
            Me.mitemCerrar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemCerrar.Image = Global.EasyGest.My.Resources.Resources.fcerrar
            Me.mitemCerrar.Name = "mitemCerrar"
            Me.mitemCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.mitemCerrar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mitemVales
            '
            resources.ApplyResources(Me.mitemVales, "mitemVales")
            Me.mitemVales.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemVales.Image = Global.EasyGest.My.Resources.Resources._85
            Me.mitemVales.Name = "mitemVales"
            Me.mitemVales.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mbtnitemVenta
            '
            resources.ApplyResources(Me.mbtnitemVenta, "mbtnitemVenta")
            '
            '
            '
            Me.mbtnitemVenta.ButtonElement.AccessibleDescription = resources.GetString("mbtnitemVenta.ButtonElement.AccessibleDescription")
            Me.mbtnitemVenta.ButtonElement.AccessibleName = resources.GetString("mbtnitemVenta.ButtonElement.AccessibleName")
            Me.mbtnitemVenta.ButtonElement.Alignment = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemVenta.ButtonElement.AngleTransform = CType(resources.GetObject("mbtnitemVenta.ButtonElement.AngleTransform"), Single)
            Me.mbtnitemVenta.ButtonElement.FlipText = CType(resources.GetObject("mbtnitemVenta.ButtonElement.FlipText"), Boolean)
            Me.mbtnitemVenta.ButtonElement.Image = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Image"), System.Drawing.Image)
            Me.mbtnitemVenta.ButtonElement.ImageIndex = CType(resources.GetObject("mbtnitemVenta.ButtonElement.ImageIndex"), Integer)
            Me.mbtnitemVenta.ButtonElement.ImageKey = resources.GetString("mbtnitemVenta.ButtonElement.ImageKey")
            Me.mbtnitemVenta.ButtonElement.Margin = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Margin"), System.Windows.Forms.Padding)
            Me.mbtnitemVenta.ButtonElement.Padding = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Padding"), System.Windows.Forms.Padding)
            Me.mbtnitemVenta.ButtonElement.RightToLeft = CType(resources.GetObject("mbtnitemVenta.ButtonElement.RightToLeft"), Boolean)
            Me.mbtnitemVenta.ButtonElement.TextAlignment = CType(resources.GetObject("mbtnitemVenta.ButtonElement.TextAlignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemVenta.ButtonElement.TextOrientation = CType(resources.GetObject("mbtnitemVenta.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.mbtnitemVenta.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mbtnitemVenta.Image = Global.EasyGest.My.Resources.Resources.fventa
            Me.mbtnitemVenta.Name = "mbtnitemVenta"
            Me.mbtnitemVenta.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Image"), System.Drawing.Image)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageIndex = CType(resources.GetObject("mbtnitemVenta.ButtonElement.ImageIndex"), Integer)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageKey = resources.GetString("mbtnitemVenta.ButtonElement.ImageKey")
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextAlignment = CType(resources.GetObject("mbtnitemVenta.ButtonElement.TextAlignment"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextOrientation = CType(resources.GetObject("mbtnitemVenta.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).FlipText = CType(resources.GetObject("mbtnitemVenta.ButtonElement.FlipText"), Boolean)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Padding = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Padding"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Margin = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Margin"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Alignment = CType(resources.GetObject("mbtnitemVenta.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).RightToLeft = CType(resources.GetObject("mbtnitemVenta.ButtonElement.RightToLeft"), Boolean)
            CType(Me.mbtnitemVenta.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).AngleTransform = CType(resources.GetObject("mbtnitemVenta.ButtonElement.AngleTransform"), Single)
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
            '
            '
            '
            Me.sbtnProveedor.RootElement.AccessibleDescription = resources.GetString("sbtnProveedor.RootElement.AccessibleDescription")
            Me.sbtnProveedor.RootElement.AccessibleName = resources.GetString("sbtnProveedor.RootElement.AccessibleName")
            Me.sbtnProveedor.RootElement.Alignment = CType(resources.GetObject("sbtnProveedor.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.sbtnProveedor.RootElement.AngleTransform = CType(resources.GetObject("sbtnProveedor.RootElement.AngleTransform"), Single)
            Me.sbtnProveedor.RootElement.FlipText = CType(resources.GetObject("sbtnProveedor.RootElement.FlipText"), Boolean)
            Me.sbtnProveedor.RootElement.Margin = CType(resources.GetObject("sbtnProveedor.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.sbtnProveedor.RootElement.Text = resources.GetString("sbtnProveedor.RootElement.Text")
            Me.sbtnProveedor.RootElement.TextOrientation = CType(resources.GetObject("sbtnProveedor.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.mitemContactosPro.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mitemCuentasPro
            '
            resources.ApplyResources(Me.mitemCuentasPro, "mitemCuentasPro")
            Me.mitemCuentasPro.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemCuentasPro.Image = Global.EasyGest.My.Resources.Resources._80
            Me.mitemCuentasPro.Name = "mitemCuentasPro"
            Me.mitemCuentasPro.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mitemDeberes
            '
            resources.ApplyResources(Me.mitemDeberes, "mitemDeberes")
            Me.mitemDeberes.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemDeberes.Name = "mitemDeberes"
            Me.mitemDeberes.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mbtnitemProveedor
            '
            resources.ApplyResources(Me.mbtnitemProveedor, "mbtnitemProveedor")
            '
            '
            '
            Me.mbtnitemProveedor.ButtonElement.AccessibleDescription = resources.GetString("mbtnitemProveedor.ButtonElement.AccessibleDescription")
            Me.mbtnitemProveedor.ButtonElement.AccessibleName = resources.GetString("mbtnitemProveedor.ButtonElement.AccessibleName")
            Me.mbtnitemProveedor.ButtonElement.Alignment = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemProveedor.ButtonElement.AngleTransform = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.AngleTransform"), Single)
            Me.mbtnitemProveedor.ButtonElement.FlipText = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.FlipText"), Boolean)
            Me.mbtnitemProveedor.ButtonElement.Image = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Image"), System.Drawing.Image)
            Me.mbtnitemProveedor.ButtonElement.ImageIndex = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.ImageIndex"), Integer)
            Me.mbtnitemProveedor.ButtonElement.ImageKey = resources.GetString("mbtnitemProveedor.ButtonElement.ImageKey")
            Me.mbtnitemProveedor.ButtonElement.Margin = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Margin"), System.Windows.Forms.Padding)
            Me.mbtnitemProveedor.ButtonElement.Padding = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Padding"), System.Windows.Forms.Padding)
            Me.mbtnitemProveedor.ButtonElement.RightToLeft = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.RightToLeft"), Boolean)
            Me.mbtnitemProveedor.ButtonElement.TextAlignment = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.TextAlignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemProveedor.ButtonElement.TextOrientation = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.mbtnitemProveedor.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!)
            Me.mbtnitemProveedor.Image = Global.EasyGest.My.Resources.Resources.fproveedor
            Me.mbtnitemProveedor.Name = "mbtnitemProveedor"
            Me.mbtnitemProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.mbtnitemProveedor.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Image"), System.Drawing.Image)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageIndex = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.ImageIndex"), Integer)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageKey = resources.GetString("mbtnitemProveedor.ButtonElement.ImageKey")
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextAlignment = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.TextAlignment"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextOrientation = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).FlipText = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.FlipText"), Boolean)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Padding = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Padding"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Margin = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Margin"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Alignment = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).RightToLeft = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.RightToLeft"), Boolean)
            CType(Me.mbtnitemProveedor.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).AngleTransform = CType(resources.GetObject("mbtnitemProveedor.ButtonElement.AngleTransform"), Single)
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
            '
            '
            '
            Me.sbtnCliente.RootElement.AccessibleDescription = resources.GetString("sbtnCliente.RootElement.AccessibleDescription")
            Me.sbtnCliente.RootElement.AccessibleName = resources.GetString("sbtnCliente.RootElement.AccessibleName")
            Me.sbtnCliente.RootElement.Alignment = CType(resources.GetObject("sbtnCliente.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.sbtnCliente.RootElement.AngleTransform = CType(resources.GetObject("sbtnCliente.RootElement.AngleTransform"), Single)
            Me.sbtnCliente.RootElement.FlipText = CType(resources.GetObject("sbtnCliente.RootElement.FlipText"), Boolean)
            Me.sbtnCliente.RootElement.Margin = CType(resources.GetObject("sbtnCliente.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.sbtnCliente.RootElement.Text = resources.GetString("sbtnCliente.RootElement.Text")
            Me.sbtnCliente.RootElement.TextOrientation = CType(resources.GetObject("sbtnCliente.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.mitemContactosCli.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mitemCuentasCli
            '
            resources.ApplyResources(Me.mitemCuentasCli, "mitemCuentasCli")
            Me.mitemCuentasCli.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemCuentasCli.Image = Global.EasyGest.My.Resources.Resources._80
            Me.mitemCuentasCli.Name = "mitemCuentasCli"
            Me.mitemCuentasCli.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mitemTarjetas
            '
            resources.ApplyResources(Me.mitemTarjetas, "mitemTarjetas")
            Me.mitemTarjetas.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemTarjetas.Image = Global.EasyGest.My.Resources.Resources._60
            Me.mitemTarjetas.Name = "mitemTarjetas"
            Me.mitemTarjetas.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mitemHaberes
            '
            resources.ApplyResources(Me.mitemHaberes, "mitemHaberes")
            Me.mitemHaberes.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemHaberes.Image = Global.EasyGest.My.Resources.Resources._35
            Me.mitemHaberes.Name = "mitemHaberes"
            Me.mitemHaberes.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mbtnitemCliente
            '
            resources.ApplyResources(Me.mbtnitemCliente, "mbtnitemCliente")
            '
            '
            '
            Me.mbtnitemCliente.ButtonElement.AccessibleDescription = resources.GetString("mbtnitemCliente.ButtonElement.AccessibleDescription")
            Me.mbtnitemCliente.ButtonElement.AccessibleName = resources.GetString("mbtnitemCliente.ButtonElement.AccessibleName")
            Me.mbtnitemCliente.ButtonElement.Alignment = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemCliente.ButtonElement.AngleTransform = CType(resources.GetObject("mbtnitemCliente.ButtonElement.AngleTransform"), Single)
            Me.mbtnitemCliente.ButtonElement.FlipText = CType(resources.GetObject("mbtnitemCliente.ButtonElement.FlipText"), Boolean)
            Me.mbtnitemCliente.ButtonElement.Image = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Image"), System.Drawing.Image)
            Me.mbtnitemCliente.ButtonElement.ImageIndex = CType(resources.GetObject("mbtnitemCliente.ButtonElement.ImageIndex"), Integer)
            Me.mbtnitemCliente.ButtonElement.ImageKey = resources.GetString("mbtnitemCliente.ButtonElement.ImageKey")
            Me.mbtnitemCliente.ButtonElement.Margin = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Margin"), System.Windows.Forms.Padding)
            Me.mbtnitemCliente.ButtonElement.Padding = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Padding"), System.Windows.Forms.Padding)
            Me.mbtnitemCliente.ButtonElement.RightToLeft = CType(resources.GetObject("mbtnitemCliente.ButtonElement.RightToLeft"), Boolean)
            Me.mbtnitemCliente.ButtonElement.TextAlignment = CType(resources.GetObject("mbtnitemCliente.ButtonElement.TextAlignment"), System.Drawing.ContentAlignment)
            Me.mbtnitemCliente.ButtonElement.TextOrientation = CType(resources.GetObject("mbtnitemCliente.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.mbtnitemCliente.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mbtnitemCliente.Image = Global.EasyGest.My.Resources.Resources.fcliente
            Me.mbtnitemCliente.Name = "mbtnitemCliente"
            Me.mbtnitemCliente.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Image"), System.Drawing.Image)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageIndex = CType(resources.GetObject("mbtnitemCliente.ButtonElement.ImageIndex"), Integer)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).ImageKey = resources.GetString("mbtnitemCliente.ButtonElement.ImageKey")
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextAlignment = CType(resources.GetObject("mbtnitemCliente.ButtonElement.TextAlignment"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).TextOrientation = CType(resources.GetObject("mbtnitemCliente.ButtonElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).FlipText = CType(resources.GetObject("mbtnitemCliente.ButtonElement.FlipText"), Boolean)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Padding = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Padding"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Margin = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Margin"), System.Windows.Forms.Padding)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).Alignment = CType(resources.GetObject("mbtnitemCliente.ButtonElement.Alignment"), System.Drawing.ContentAlignment)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).RightToLeft = CType(resources.GetObject("mbtnitemCliente.ButtonElement.RightToLeft"), Boolean)
            CType(Me.mbtnitemCliente.GetChildAt(2), Telerik.WinControls.UI.RadButtonElement).AngleTransform = CType(resources.GetObject("mbtnitemCliente.ButtonElement.AngleTransform"), Single)
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
            Me.ToolTabStrip1.RootElement.AccessibleDescription = resources.GetString("ToolTabStrip1.RootElement.AccessibleDescription")
            Me.ToolTabStrip1.RootElement.AccessibleName = resources.GetString("ToolTabStrip1.RootElement.AccessibleName")
            Me.ToolTabStrip1.RootElement.Alignment = CType(resources.GetObject("ToolTabStrip1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ToolTabStrip1.RootElement.AngleTransform = CType(resources.GetObject("ToolTabStrip1.RootElement.AngleTransform"), Single)
            Me.ToolTabStrip1.RootElement.FlipText = CType(resources.GetObject("ToolTabStrip1.RootElement.FlipText"), Boolean)
            Me.ToolTabStrip1.RootElement.Margin = CType(resources.GetObject("ToolTabStrip1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.ToolTabStrip1.RootElement.Text = resources.GetString("ToolTabStrip1.RootElement.Text")
            Me.ToolTabStrip1.RootElement.TextOrientation = CType(resources.GetObject("ToolTabStrip1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.doccPrincipal.RootElement.AccessibleDescription = resources.GetString("doccPrincipal.RootElement.AccessibleDescription")
            Me.doccPrincipal.RootElement.AccessibleName = resources.GetString("doccPrincipal.RootElement.AccessibleName")
            Me.doccPrincipal.RootElement.Alignment = CType(resources.GetObject("doccPrincipal.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.doccPrincipal.RootElement.AngleTransform = CType(resources.GetObject("doccPrincipal.RootElement.AngleTransform"), Single)
            Me.doccPrincipal.RootElement.FlipText = CType(resources.GetObject("doccPrincipal.RootElement.FlipText"), Boolean)
            Me.doccPrincipal.RootElement.Margin = CType(resources.GetObject("doccPrincipal.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.doccPrincipal.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.doccPrincipal.RootElement.Text = resources.GetString("doccPrincipal.RootElement.Text")
            Me.doccPrincipal.RootElement.TextOrientation = CType(resources.GetObject("doccPrincipal.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            '
            '
            Me.sttEstado.RootElement.AccessibleDescription = resources.GetString("sttEstado.RootElement.AccessibleDescription")
            Me.sttEstado.RootElement.AccessibleName = resources.GetString("sttEstado.RootElement.AccessibleName")
            Me.sttEstado.RootElement.Alignment = CType(resources.GetObject("sttEstado.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.sttEstado.RootElement.AngleTransform = CType(resources.GetObject("sttEstado.RootElement.AngleTransform"), Single)
            Me.sttEstado.RootElement.FlipText = CType(resources.GetObject("sttEstado.RootElement.FlipText"), Boolean)
            Me.sttEstado.RootElement.Margin = CType(resources.GetObject("sttEstado.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.sttEstado.RootElement.Text = resources.GetString("sttEstado.RootElement.Text")
            Me.sttEstado.RootElement.TextOrientation = CType(resources.GetObject("sttEstado.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'lbleHoraInicio
            '
            resources.ApplyResources(Me.lbleHoraInicio, "lbleHoraInicio")
            Me.lbleHoraInicio.Font = New System.Drawing.Font("楷体", 9.0!)
            Me.lbleHoraInicio.Name = "lbleHoraInicio"
            Me.sttEstado.SetSpring(Me.lbleHoraInicio, False)
            Me.lbleHoraInicio.TextWrap = True
            Me.lbleHoraInicio.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'lbleHoraApertura
            '
            Me.lbleHoraApertura.Font = New System.Drawing.Font("楷体", 9.0!)
            Me.lbleHoraApertura.Name = "lbleHoraApertura"
            Me.sttEstado.SetSpring(Me.lbleHoraApertura, False)
            Me.lbleHoraApertura.TextWrap = True
            Me.lbleHoraApertura.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'lbleEmpresa
            '
            resources.ApplyResources(Me.lbleEmpresa, "lbleEmpresa")
            Me.lbleEmpresa.Font = New System.Drawing.Font("楷体", 9.0!)
            Me.lbleEmpresa.Name = "lbleEmpresa"
            Me.sttEstado.SetSpring(Me.lbleEmpresa, False)
            Me.lbleEmpresa.TextWrap = True
            Me.lbleEmpresa.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'lblePuesto
            '
            resources.ApplyResources(Me.lblePuesto, "lblePuesto")
            Me.lblePuesto.Font = New System.Drawing.Font("楷体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblePuesto.Name = "lblePuesto"
            Me.sttEstado.SetSpring(Me.lblePuesto, True)
            Me.lblePuesto.TextWrap = True
            Me.lblePuesto.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'lbleUsuario
            '
            resources.ApplyResources(Me.lbleUsuario, "lbleUsuario")
            Me.lbleUsuario.Font = New System.Drawing.Font("楷体", 9.0!)
            Me.lbleUsuario.Name = "lbleUsuario"
            Me.sttEstado.SetSpring(Me.lbleUsuario, False)
            Me.lbleUsuario.TextWrap = True
            Me.lbleUsuario.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'lbleVersion
            '
            resources.ApplyResources(Me.lbleVersion, "lbleVersion")
            Me.lbleVersion.Font = New System.Drawing.Font("楷体", 9.0!)
            Me.lbleVersion.Name = "lbleVersion"
            Me.sttEstado.SetSpring(Me.lbleVersion, False)
            Me.lbleVersion.TextWrap = True
            Me.lbleVersion.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'RadStatusBarPanelElement1
            '
            Me.RadStatusBarPanelElement1.AutoSize = False
            Me.RadStatusBarPanelElement1.Bounds = New System.Drawing.Rectangle(0, 0, 2, 18)
            Me.RadStatusBarPanelElement1.Name = "RadStatusBarPanelElement1"
            Me.sttEstado.SetSpring(Me.RadStatusBarPanelElement1, False)
            resources.ApplyResources(Me.RadStatusBarPanelElement1, "RadStatusBarPanelElement1")
            Me.RadStatusBarPanelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'alertTarea
            '
            Me.alertTarea.AutoCloseDelay = 20
            Me.alertTarea.CaptionText = "任务提醒 - Aviso Tarea"
            Me.alertTarea.ContentImage = CType(resources.GetObject("alertTarea.ContentImage"), System.Drawing.Image)
            Me.alertTarea.Opacity = 0.7!
            Me.alertTarea.PopupAnimationEasing = Telerik.WinControls.RadEasingType.InElastic
            Me.alertTarea.ScreenPosition = Telerik.WinControls.UI.AlertScreenPosition.TopLeft
            Me.alertTarea.ShowOptionsButton = False
            Me.alertTarea.ShowPinButton = False
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
            Me.RootElement.AccessibleDescription = resources.GetString("frmPrincipal.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmPrincipal.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmPrincipal.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmPrincipal.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmPrincipal.RootElement.FlipText"), Boolean)
            Me.RootElement.Margin = CType(resources.GetObject("frmPrincipal.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmPrincipal.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmPrincipal.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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

