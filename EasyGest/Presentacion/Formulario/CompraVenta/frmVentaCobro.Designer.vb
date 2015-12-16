Namespace Presentacion.Formulario.CompraVenta
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmVentaCobro
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentaCobro))
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel3 As Telerik.WinControls.UI.RadLabel
            Dim RadSeparator1 As Telerik.WinControls.UI.RadSeparator
            Dim RadSeparator2 As Telerik.WinControls.UI.RadSeparator
            Dim RadLabel12 As Telerik.WinControls.UI.RadLabel
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.pnlContenido = New Telerik.WinControls.UI.RadPanel()
            Me.ddlModoPago = New Telerik.WinControls.UI.RadDropDownList()
            Me.ModosPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.grpValesCompras = New Telerik.WinControls.UI.RadGroupBox()
            Me.lstvVales = New Telerik.WinControls.UI.RadListView()
            Me.ValesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.txtNumeroVale = New Telerik.WinControls.UI.RadTextBox()
            Me.txtEntregado = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.txtDevolucion = New Telerik.WinControls.UI.RadTextBox()
            Me.txtTotalVenta = New Telerik.WinControls.UI.RadTextBox()
            Me.toggleFacturar = New Telerik.WinControls.UI.RadToggleButton()
            Me.toggleImprimir = New Telerik.WinControls.UI.RadToggleButton()
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            RadLabel3 = New Telerik.WinControls.UI.RadLabel()
            RadSeparator1 = New Telerik.WinControls.UI.RadSeparator()
            RadSeparator2 = New Telerik.WinControls.UI.RadSeparator()
            RadLabel12 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlContenido, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlContenido.SuspendLayout()
            CType(Me.ddlModoPago, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ModosPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grpValesCompras, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpValesCompras.SuspendLayout()
            CType(Me.lstvVales, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ValesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNumeroVale, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtEntregado, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtDevolucion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtTotalVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toggleFacturar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toggleImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
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
            RadLabel3.RootElement.KeyTip = resources.GetString("RadLabel3.RootElement.KeyTip")
            RadLabel3.RootElement.Margin = CType(resources.GetObject("RadLabel3.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel3.RootElement.Padding = CType(resources.GetObject("RadLabel3.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel3.RootElement.Text = resources.GetString("RadLabel3.RootElement.Text")
            RadLabel3.RootElement.TextOrientation = CType(resources.GetObject("RadLabel3.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel3.RootElement.ToolTipText = resources.GetString("RadLabel3.RootElement.ToolTipText")
            '
            'RadSeparator1
            '
            resources.ApplyResources(RadSeparator1, "RadSeparator1")
            RadSeparator1.Name = "RadSeparator1"
            '
            '
            '
            RadSeparator1.RootElement.AccessibleDescription = resources.GetString("RadSeparator1.RootElement.AccessibleDescription")
            RadSeparator1.RootElement.AccessibleName = resources.GetString("RadSeparator1.RootElement.AccessibleName")
            RadSeparator1.RootElement.Alignment = CType(resources.GetObject("RadSeparator1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadSeparator1.RootElement.AngleTransform = CType(resources.GetObject("RadSeparator1.RootElement.AngleTransform"), Single)
            RadSeparator1.RootElement.FlipText = CType(resources.GetObject("RadSeparator1.RootElement.FlipText"), Boolean)
            RadSeparator1.RootElement.KeyTip = resources.GetString("RadSeparator1.RootElement.KeyTip")
            RadSeparator1.RootElement.Margin = CType(resources.GetObject("RadSeparator1.RootElement.Margin"), System.Windows.Forms.Padding)
            RadSeparator1.RootElement.Padding = CType(resources.GetObject("RadSeparator1.RootElement.Padding"), System.Windows.Forms.Padding)
            RadSeparator1.RootElement.Text = resources.GetString("RadSeparator1.RootElement.Text")
            RadSeparator1.RootElement.TextOrientation = CType(resources.GetObject("RadSeparator1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadSeparator1.RootElement.ToolTipText = resources.GetString("RadSeparator1.RootElement.ToolTipText")
            '
            'RadSeparator2
            '
            resources.ApplyResources(RadSeparator2, "RadSeparator2")
            RadSeparator2.Name = "RadSeparator2"
            '
            '
            '
            RadSeparator2.RootElement.AccessibleDescription = resources.GetString("RadSeparator2.RootElement.AccessibleDescription")
            RadSeparator2.RootElement.AccessibleName = resources.GetString("RadSeparator2.RootElement.AccessibleName")
            RadSeparator2.RootElement.Alignment = CType(resources.GetObject("RadSeparator2.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadSeparator2.RootElement.AngleTransform = CType(resources.GetObject("RadSeparator2.RootElement.AngleTransform"), Single)
            RadSeparator2.RootElement.FlipText = CType(resources.GetObject("RadSeparator2.RootElement.FlipText"), Boolean)
            RadSeparator2.RootElement.KeyTip = resources.GetString("RadSeparator2.RootElement.KeyTip")
            RadSeparator2.RootElement.Margin = CType(resources.GetObject("RadSeparator2.RootElement.Margin"), System.Windows.Forms.Padding)
            RadSeparator2.RootElement.Padding = CType(resources.GetObject("RadSeparator2.RootElement.Padding"), System.Windows.Forms.Padding)
            RadSeparator2.RootElement.Text = resources.GetString("RadSeparator2.RootElement.Text")
            RadSeparator2.RootElement.TextOrientation = CType(resources.GetObject("RadSeparator2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadSeparator2.RootElement.ToolTipText = resources.GetString("RadSeparator2.RootElement.ToolTipText")
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
            RadLabel12.RootElement.KeyTip = resources.GetString("RadLabel12.RootElement.KeyTip")
            RadLabel12.RootElement.Margin = CType(resources.GetObject("RadLabel12.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel12.RootElement.Padding = CType(resources.GetObject("RadLabel12.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel12.RootElement.Text = resources.GetString("RadLabel12.RootElement.Text")
            RadLabel12.RootElement.TextOrientation = CType(resources.GetObject("RadLabel12.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel12.RootElement.ToolTipText = resources.GetString("RadLabel12.RootElement.ToolTipText")
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
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text")
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
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text1")
            CType(Me.btnAceptar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
            '
            'pnlContenido
            '
            resources.ApplyResources(Me.pnlContenido, "pnlContenido")
            Me.pnlContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.pnlContenido.Controls.Add(Me.ddlModoPago)
            Me.pnlContenido.Controls.Add(RadLabel12)
            Me.pnlContenido.Controls.Add(RadSeparator2)
            Me.pnlContenido.Controls.Add(RadSeparator1)
            Me.pnlContenido.Controls.Add(Me.grpValesCompras)
            Me.pnlContenido.Controls.Add(Me.txtEntregado)
            Me.pnlContenido.Controls.Add(Me.txtDevolucion)
            Me.pnlContenido.Controls.Add(Me.txtTotalVenta)
            Me.pnlContenido.Controls.Add(Me.toggleFacturar)
            Me.pnlContenido.Controls.Add(Me.toggleImprimir)
            Me.pnlContenido.Controls.Add(RadLabel2)
            Me.pnlContenido.Controls.Add(RadLabel3)
            Me.pnlContenido.Controls.Add(RadLabel1)
            Me.pnlContenido.Controls.Add(Me.btnAceptar)
            Me.pnlContenido.Controls.Add(Me.btnCancelar)
            Me.pnlContenido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.pnlContenido.Name = "pnlContenido"
            '
            '
            '
            Me.pnlContenido.RootElement.AccessibleDescription = resources.GetString("pnlContenido.RootElement.AccessibleDescription")
            Me.pnlContenido.RootElement.AccessibleName = resources.GetString("pnlContenido.RootElement.AccessibleName")
            Me.pnlContenido.RootElement.Alignment = CType(resources.GetObject("pnlContenido.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.pnlContenido.RootElement.AngleTransform = CType(resources.GetObject("pnlContenido.RootElement.AngleTransform"), Single)
            Me.pnlContenido.RootElement.FlipText = CType(resources.GetObject("pnlContenido.RootElement.FlipText"), Boolean)
            Me.pnlContenido.RootElement.KeyTip = resources.GetString("pnlContenido.RootElement.KeyTip")
            Me.pnlContenido.RootElement.Margin = CType(resources.GetObject("pnlContenido.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.pnlContenido.RootElement.Padding = CType(resources.GetObject("pnlContenido.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.pnlContenido.RootElement.Text = resources.GetString("pnlContenido.RootElement.Text")
            Me.pnlContenido.RootElement.TextOrientation = CType(resources.GetObject("pnlContenido.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.pnlContenido.RootElement.ToolTipText = resources.GetString("pnlContenido.RootElement.ToolTipText")
            Me.pnlContenido.TextAlignment = System.Drawing.ContentAlignment.TopCenter
            CType(Me.pnlContenido.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = resources.GetString("resource.Text6")
            CType(Me.pnlContenido.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
            CType(Me.pnlContenido.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            CType(Me.pnlContenido.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
            CType(Me.pnlContenido.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = CType(resources.GetObject("resource.TextAlignment"), System.Drawing.ContentAlignment)
            '
            'ddlModoPago
            '
            resources.ApplyResources(Me.ddlModoPago, "ddlModoPago")
            Me.ddlModoPago.AllowShowFocusCues = True
            Me.ddlModoPago.AutoCompleteDisplayMember = "ModoPago"
            Me.ddlModoPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ddlModoPago.AutoCompleteValueMember = "idModo"
            Me.ddlModoPago.DataSource = Me.ModosPagoBindingSource
            Me.ddlModoPago.DisplayMember = "ModoPago"
            Me.ddlModoPago.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlModoPago.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
            Me.ddlModoPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlModoPago.Name = "ddlModoPago"
            '
            '
            '
            Me.ddlModoPago.RootElement.AccessibleDescription = resources.GetString("ddlModoPago.RootElement.AccessibleDescription")
            Me.ddlModoPago.RootElement.AccessibleName = resources.GetString("ddlModoPago.RootElement.AccessibleName")
            Me.ddlModoPago.RootElement.Alignment = CType(resources.GetObject("ddlModoPago.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlModoPago.RootElement.AngleTransform = CType(resources.GetObject("ddlModoPago.RootElement.AngleTransform"), Single)
            Me.ddlModoPago.RootElement.FlipText = CType(resources.GetObject("ddlModoPago.RootElement.FlipText"), Boolean)
            Me.ddlModoPago.RootElement.KeyTip = resources.GetString("ddlModoPago.RootElement.KeyTip")
            Me.ddlModoPago.RootElement.Margin = CType(resources.GetObject("ddlModoPago.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlModoPago.RootElement.Padding = CType(resources.GetObject("ddlModoPago.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ddlModoPago.RootElement.Text = resources.GetString("ddlModoPago.RootElement.Text")
            Me.ddlModoPago.RootElement.TextOrientation = CType(resources.GetObject("ddlModoPago.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ddlModoPago.RootElement.ToolTipText = resources.GetString("ddlModoPago.RootElement.ToolTipText")
            Me.ddlModoPago.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlModoPago.ValueMember = "idModo"
            CType(Me.ddlModoPago.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
            '
            'ModosPagoBindingSource
            '
            Me.ModosPagoBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.ModosPago)
            '
            'grpValesCompras
            '
            resources.ApplyResources(Me.grpValesCompras, "grpValesCompras")
            Me.grpValesCompras.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.grpValesCompras.Controls.Add(Me.lstvVales)
            Me.grpValesCompras.Controls.Add(Me.txtNumeroVale)
            Me.grpValesCompras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.grpValesCompras.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            Me.grpValesCompras.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Left
            Me.grpValesCompras.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.grpValesCompras.Name = "grpValesCompras"
            '
            '
            '
            Me.grpValesCompras.RootElement.AccessibleDescription = resources.GetString("grpValesCompras.RootElement.AccessibleDescription")
            Me.grpValesCompras.RootElement.AccessibleName = resources.GetString("grpValesCompras.RootElement.AccessibleName")
            Me.grpValesCompras.RootElement.Alignment = CType(resources.GetObject("grpValesCompras.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.grpValesCompras.RootElement.AngleTransform = CType(resources.GetObject("grpValesCompras.RootElement.AngleTransform"), Single)
            Me.grpValesCompras.RootElement.FlipText = CType(resources.GetObject("grpValesCompras.RootElement.FlipText"), Boolean)
            Me.grpValesCompras.RootElement.KeyTip = resources.GetString("grpValesCompras.RootElement.KeyTip")
            Me.grpValesCompras.RootElement.Margin = CType(resources.GetObject("grpValesCompras.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.grpValesCompras.RootElement.Padding = CType(resources.GetObject("grpValesCompras.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.grpValesCompras.RootElement.Text = resources.GetString("grpValesCompras.RootElement.Text")
            Me.grpValesCompras.RootElement.TextOrientation = CType(resources.GetObject("grpValesCompras.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.grpValesCompras.RootElement.ToolTipText = resources.GetString("grpValesCompras.RootElement.ToolTipText")
            CType(Me.grpValesCompras.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).InvalidateMeasureInMainLayout = 1
            CType(Me.grpValesCompras.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Left
            CType(Me.grpValesCompras.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            CType(Me.grpValesCompras.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            CType(Me.grpValesCompras.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).AngleTransform = CType(resources.GetObject("resource.AngleTransform"), Single)
            '
            'lstvVales
            '
            resources.ApplyResources(Me.lstvVales, "lstvVales")
            Me.lstvVales.AllowColumnReorder = False
            Me.lstvVales.AllowColumnResize = False
            Me.lstvVales.AllowEdit = False
            Me.lstvVales.DataSource = Me.ValesBindingSource
            Me.lstvVales.DisplayMember = "Numero"
            Me.lstvVales.ItemSpacing = -1
            Me.lstvVales.MultiSelect = True
            Me.lstvVales.Name = "lstvVales"
            '
            '
            '
            Me.lstvVales.RootElement.AccessibleDescription = resources.GetString("lstvVales.RootElement.AccessibleDescription")
            Me.lstvVales.RootElement.AccessibleName = resources.GetString("lstvVales.RootElement.AccessibleName")
            Me.lstvVales.RootElement.Alignment = CType(resources.GetObject("lstvVales.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lstvVales.RootElement.AngleTransform = CType(resources.GetObject("lstvVales.RootElement.AngleTransform"), Single)
            Me.lstvVales.RootElement.FlipText = CType(resources.GetObject("lstvVales.RootElement.FlipText"), Boolean)
            Me.lstvVales.RootElement.KeyTip = resources.GetString("lstvVales.RootElement.KeyTip")
            Me.lstvVales.RootElement.Margin = CType(resources.GetObject("lstvVales.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lstvVales.RootElement.Padding = CType(resources.GetObject("lstvVales.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.lstvVales.RootElement.Text = resources.GetString("lstvVales.RootElement.Text")
            Me.lstvVales.RootElement.TextOrientation = CType(resources.GetObject("lstvVales.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.lstvVales.RootElement.ToolTipText = resources.GetString("lstvVales.RootElement.ToolTipText")
            Me.lstvVales.ValueMember = "idVale"
            Me.lstvVales.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
            '
            'ValesBindingSource
            '
            Me.ValesBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Vales)
            '
            'txtNumeroVale
            '
            resources.ApplyResources(Me.txtNumeroVale, "txtNumeroVale")
            Me.txtNumeroVale.AllowShowFocusCues = True
            Me.txtNumeroVale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtNumeroVale.Name = "txtNumeroVale"
            '
            '
            '
            Me.txtNumeroVale.RootElement.AccessibleDescription = resources.GetString("txtNumeroVale.RootElement.AccessibleDescription")
            Me.txtNumeroVale.RootElement.AccessibleName = resources.GetString("txtNumeroVale.RootElement.AccessibleName")
            Me.txtNumeroVale.RootElement.Alignment = CType(resources.GetObject("txtNumeroVale.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtNumeroVale.RootElement.AngleTransform = CType(resources.GetObject("txtNumeroVale.RootElement.AngleTransform"), Single)
            Me.txtNumeroVale.RootElement.ApplyShapeToControl = False
            Me.txtNumeroVale.RootElement.FlipText = CType(resources.GetObject("txtNumeroVale.RootElement.FlipText"), Boolean)
            Me.txtNumeroVale.RootElement.KeyTip = resources.GetString("txtNumeroVale.RootElement.KeyTip")
            Me.txtNumeroVale.RootElement.Margin = CType(resources.GetObject("txtNumeroVale.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtNumeroVale.RootElement.Padding = CType(resources.GetObject("txtNumeroVale.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtNumeroVale.RootElement.Text = resources.GetString("txtNumeroVale.RootElement.Text")
            Me.txtNumeroVale.RootElement.TextOrientation = CType(resources.GetObject("txtNumeroVale.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtNumeroVale.RootElement.ToolTipText = resources.GetString("txtNumeroVale.RootElement.ToolTipText")
            Me.txtNumeroVale.TabStop = False
            Me.txtNumeroVale.Tag = ""
            CType(Me.txtNumeroVale.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text2")
            CType(Me.txtNumeroVale.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNumeroVale.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtNumeroVale.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNumeroVale.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtNumeroVale.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtEntregado
            '
            resources.ApplyResources(Me.txtEntregado, "txtEntregado")
            Me.txtEntregado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtEntregado.Name = "txtEntregado"
            '
            '
            '
            Me.txtEntregado.RootElement.AccessibleDescription = resources.GetString("txtEntregado.RootElement.AccessibleDescription")
            Me.txtEntregado.RootElement.AccessibleName = resources.GetString("txtEntregado.RootElement.AccessibleName")
            Me.txtEntregado.RootElement.Alignment = CType(resources.GetObject("txtEntregado.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtEntregado.RootElement.AngleTransform = CType(resources.GetObject("txtEntregado.RootElement.AngleTransform"), Single)
            Me.txtEntregado.RootElement.FlipText = CType(resources.GetObject("txtEntregado.RootElement.FlipText"), Boolean)
            Me.txtEntregado.RootElement.KeyTip = resources.GetString("txtEntregado.RootElement.KeyTip")
            Me.txtEntregado.RootElement.Margin = CType(resources.GetObject("txtEntregado.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtEntregado.RootElement.Padding = CType(resources.GetObject("txtEntregado.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtEntregado.RootElement.Text = resources.GetString("txtEntregado.RootElement.Text")
            Me.txtEntregado.RootElement.TextOrientation = CType(resources.GetObject("txtEntregado.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtEntregado.RootElement.ToolTipText = resources.GetString("txtEntregado.RootElement.ToolTipText")
            Me.txtEntregado.TabStop = False
            Me.txtEntregado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            CType(Me.txtEntregado.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text3")
            CType(Me.txtEntregado.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtEntregado.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtDevolucion
            '
            resources.ApplyResources(Me.txtDevolucion, "txtDevolucion")
            Me.txtDevolucion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtDevolucion.Name = "txtDevolucion"
            Me.txtDevolucion.ReadOnly = True
            '
            '
            '
            Me.txtDevolucion.RootElement.AccessibleDescription = resources.GetString("txtDevolucion.RootElement.AccessibleDescription")
            Me.txtDevolucion.RootElement.AccessibleName = resources.GetString("txtDevolucion.RootElement.AccessibleName")
            Me.txtDevolucion.RootElement.Alignment = CType(resources.GetObject("txtDevolucion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtDevolucion.RootElement.AngleTransform = CType(resources.GetObject("txtDevolucion.RootElement.AngleTransform"), Single)
            Me.txtDevolucion.RootElement.ApplyShapeToControl = False
            Me.txtDevolucion.RootElement.FlipText = CType(resources.GetObject("txtDevolucion.RootElement.FlipText"), Boolean)
            Me.txtDevolucion.RootElement.KeyTip = resources.GetString("txtDevolucion.RootElement.KeyTip")
            Me.txtDevolucion.RootElement.Margin = CType(resources.GetObject("txtDevolucion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtDevolucion.RootElement.Padding = CType(resources.GetObject("txtDevolucion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtDevolucion.RootElement.Text = resources.GetString("txtDevolucion.RootElement.Text")
            Me.txtDevolucion.RootElement.TextOrientation = CType(resources.GetObject("txtDevolucion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtDevolucion.RootElement.ToolTipText = resources.GetString("txtDevolucion.RootElement.ToolTipText")
            Me.txtDevolucion.TabStop = False
            Me.txtDevolucion.Tag = ""
            Me.txtDevolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            CType(Me.txtDevolucion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text4")
            CType(Me.txtDevolucion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtDevolucion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtDevolucion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtDevolucion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold)
            CType(Me.txtDevolucion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtTotalVenta
            '
            resources.ApplyResources(Me.txtTotalVenta, "txtTotalVenta")
            Me.txtTotalVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtTotalVenta.Name = "txtTotalVenta"
            Me.txtTotalVenta.ReadOnly = True
            '
            '
            '
            Me.txtTotalVenta.RootElement.AccessibleDescription = resources.GetString("txtTotalVenta.RootElement.AccessibleDescription")
            Me.txtTotalVenta.RootElement.AccessibleName = resources.GetString("txtTotalVenta.RootElement.AccessibleName")
            Me.txtTotalVenta.RootElement.Alignment = CType(resources.GetObject("txtTotalVenta.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtTotalVenta.RootElement.AngleTransform = CType(resources.GetObject("txtTotalVenta.RootElement.AngleTransform"), Single)
            Me.txtTotalVenta.RootElement.ApplyShapeToControl = False
            Me.txtTotalVenta.RootElement.FlipText = CType(resources.GetObject("txtTotalVenta.RootElement.FlipText"), Boolean)
            Me.txtTotalVenta.RootElement.KeyTip = resources.GetString("txtTotalVenta.RootElement.KeyTip")
            Me.txtTotalVenta.RootElement.Margin = CType(resources.GetObject("txtTotalVenta.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtTotalVenta.RootElement.Padding = CType(resources.GetObject("txtTotalVenta.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtTotalVenta.RootElement.Text = resources.GetString("txtTotalVenta.RootElement.Text")
            Me.txtTotalVenta.RootElement.TextOrientation = CType(resources.GetObject("txtTotalVenta.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtTotalVenta.RootElement.ToolTipText = resources.GetString("txtTotalVenta.RootElement.ToolTipText")
            Me.txtTotalVenta.TabStop = False
            Me.txtTotalVenta.Tag = ""
            Me.txtTotalVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            CType(Me.txtTotalVenta.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text5")
            CType(Me.txtTotalVenta.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtTotalVenta.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtTotalVenta.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtTotalVenta.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtTotalVenta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'toggleFacturar
            '
            resources.ApplyResources(Me.toggleFacturar, "toggleFacturar")
            Me.toggleFacturar.IsThreeState = True
            Me.toggleFacturar.Name = "toggleFacturar"
            '
            '
            '
            Me.toggleFacturar.RootElement.AccessibleDescription = resources.GetString("toggleFacturar.RootElement.AccessibleDescription")
            Me.toggleFacturar.RootElement.AccessibleName = resources.GetString("toggleFacturar.RootElement.AccessibleName")
            Me.toggleFacturar.RootElement.Alignment = CType(resources.GetObject("toggleFacturar.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.toggleFacturar.RootElement.AngleTransform = CType(resources.GetObject("toggleFacturar.RootElement.AngleTransform"), Single)
            Me.toggleFacturar.RootElement.FlipText = CType(resources.GetObject("toggleFacturar.RootElement.FlipText"), Boolean)
            Me.toggleFacturar.RootElement.KeyTip = resources.GetString("toggleFacturar.RootElement.KeyTip")
            Me.toggleFacturar.RootElement.Margin = CType(resources.GetObject("toggleFacturar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.toggleFacturar.RootElement.Padding = CType(resources.GetObject("toggleFacturar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.toggleFacturar.RootElement.Text = resources.GetString("toggleFacturar.RootElement.Text")
            Me.toggleFacturar.RootElement.TextOrientation = CType(resources.GetObject("toggleFacturar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.toggleFacturar.RootElement.ToolTipText = resources.GetString("toggleFacturar.RootElement.ToolTipText")
            Me.toggleFacturar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate
            '
            'toggleImprimir
            '
            resources.ApplyResources(Me.toggleImprimir, "toggleImprimir")
            Me.toggleImprimir.IsThreeState = True
            Me.toggleImprimir.Name = "toggleImprimir"
            '
            '
            '
            Me.toggleImprimir.RootElement.AccessibleDescription = resources.GetString("toggleImprimir.RootElement.AccessibleDescription")
            Me.toggleImprimir.RootElement.AccessibleName = resources.GetString("toggleImprimir.RootElement.AccessibleName")
            Me.toggleImprimir.RootElement.Alignment = CType(resources.GetObject("toggleImprimir.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.toggleImprimir.RootElement.AngleTransform = CType(resources.GetObject("toggleImprimir.RootElement.AngleTransform"), Single)
            Me.toggleImprimir.RootElement.FlipText = CType(resources.GetObject("toggleImprimir.RootElement.FlipText"), Boolean)
            Me.toggleImprimir.RootElement.KeyTip = resources.GetString("toggleImprimir.RootElement.KeyTip")
            Me.toggleImprimir.RootElement.Margin = CType(resources.GetObject("toggleImprimir.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.toggleImprimir.RootElement.Padding = CType(resources.GetObject("toggleImprimir.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.toggleImprimir.RootElement.Text = resources.GetString("toggleImprimir.RootElement.Text")
            Me.toggleImprimir.RootElement.TextOrientation = CType(resources.GetObject("toggleImprimir.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.toggleImprimir.RootElement.ToolTipText = resources.GetString("toggleImprimir.RootElement.ToolTipText")
            Me.toggleImprimir.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate
            '
            'frmVentaCobro
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancelar
            Me.Controls.Add(Me.pnlContenido)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmVentaCobro"
            Me.Opacity = 0.8R
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmVentaCobro.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmVentaCobro.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmVentaCobro.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmVentaCobro.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmVentaCobro.RootElement.FlipText"), Boolean)
            Me.RootElement.KeyTip = resources.GetString("frmVentaCobro.RootElement.KeyTip")
            Me.RootElement.Margin = CType(resources.GetObject("frmVentaCobro.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmVentaCobro.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmVentaCobro.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmVentaCobro.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RootElement.ToolTipText = resources.GetString("frmVentaCobro.RootElement.ToolTipText")
            Me.ShowInTaskbar = False
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlContenido, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlContenido.ResumeLayout(False)
            Me.pnlContenido.PerformLayout()
            CType(Me.ddlModoPago, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ModosPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grpValesCompras, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpValesCompras.ResumeLayout(False)
            Me.grpValesCompras.PerformLayout()
            CType(Me.lstvVales, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ValesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNumeroVale, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtEntregado, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtDevolucion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtTotalVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toggleFacturar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toggleImprimir, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents pnlContenido As Telerik.WinControls.UI.RadPanel
        Friend WithEvents toggleImprimir As Telerik.WinControls.UI.RadToggleButton
        Friend WithEvents toggleFacturar As Telerik.WinControls.UI.RadToggleButton
        Friend WithEvents txtTotalVenta As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtEntregado As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents grpValesCompras As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents txtNumeroVale As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents lstvVales As Telerik.WinControls.UI.RadListView
        Friend WithEvents ValesBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents txtDevolucion As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents ddlModoPago As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents ModosPagoBindingSource As System.Windows.Forms.BindingSource
    End Class

End Namespace