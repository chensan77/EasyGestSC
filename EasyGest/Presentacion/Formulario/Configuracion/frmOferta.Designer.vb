Namespace Presentacion.Formulario.Configuracion

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmOferta
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
            Dim RadLabel5 As Telerik.WinControls.UI.RadLabel
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOferta))
            Dim RadLabel1 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel6 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel3 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel4 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel7 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel8 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel9 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel10 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel11 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel12 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel13 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel14 As Telerik.WinControls.UI.RadLabel
            Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim GridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim GridViewDateTimeColumn3 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim GridViewCheckBoxColumn2 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn5 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim InputBinding1 As Telerik.WinControls.Keyboard.InputBinding = New Telerik.WinControls.Keyboard.InputBinding()
            Dim Chord1 As Telerik.WinControls.Keyboard.Chord = New Telerik.WinControls.Keyboard.Chord()
            Dim ChordModifier1 As Telerik.WinControls.Keyboard.ChordModifier = New Telerik.WinControls.Keyboard.ChordModifier()
            Me.gridDatos = New Telerik.WinControls.UI.RadGridView()
            Me.OfertasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.SplitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.SplitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.txtDescripcion = New Telerik.WinControls.UI.RadTextBox()
            Me.OfertaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.radDescuentoFijo = New Telerik.WinControls.UI.RadRadioButton()
            Me.RadPanel6 = New Telerik.WinControls.UI.RadPanel()
            Me.txtUnidadPrecio = New Telerik.WinControls.UI.RadSpinEditor()
            Me.txtUnidadBaseP = New Telerik.WinControls.UI.RadSpinEditor()
            Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
            Me.txtUnidadDesc = New Telerik.WinControls.UI.RadSpinEditor()
            Me.txtUnidadBaseD = New Telerik.WinControls.UI.RadSpinEditor()
            Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
            Me.txtUnidadGratis = New Telerik.WinControls.UI.RadSpinEditor()
            Me.txtUnidadBase = New Telerik.WinControls.UI.RadSpinEditor()
            Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
            Me.txtDescPorc = New Telerik.WinControls.UI.RadSpinEditor()
            Me.radUnidadGratis = New Telerik.WinControls.UI.RadRadioButton()
            Me.radUnidadPrecio = New Telerik.WinControls.UI.RadRadioButton()
            Me.radUnidadDescuento = New Telerik.WinControls.UI.RadRadioButton()
            Me.radDescuentoPorcentual = New Telerik.WinControls.UI.RadRadioButton()
            Me.radPrecioEspecial = New Telerik.WinControls.UI.RadRadioButton()
            Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
            Me.txtPrecioEspecial = New Telerik.WinControls.UI.RadSpinEditor()
            Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
            Me.txtDescFijo = New Telerik.WinControls.UI.RadSpinEditor()
            Me.dtpFechaInicio = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.chkActivo = New Telerik.WinControls.UI.RadCheckBox()
            Me.spinDuracion = New Telerik.WinControls.UI.RadSpinEditor()
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.txtNumeroOferta = New Telerik.WinControls.UI.RadTextBox()
            Me.bgwCarga = New System.ComponentModel.BackgroundWorker()
            Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.cbstripeAccion = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbbtnAgregar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnModificar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnEliminar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbstripeOrden = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbComandos = New Telerik.WinControls.UI.RadCommandBar()
            Me.timValidar = New System.Windows.Forms.Timer(Me.components)
            RadLabel5 = New Telerik.WinControls.UI.RadLabel()
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            RadLabel6 = New Telerik.WinControls.UI.RadLabel()
            RadLabel3 = New Telerik.WinControls.UI.RadLabel()
            RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            RadLabel7 = New Telerik.WinControls.UI.RadLabel()
            RadLabel8 = New Telerik.WinControls.UI.RadLabel()
            RadLabel9 = New Telerik.WinControls.UI.RadLabel()
            RadLabel10 = New Telerik.WinControls.UI.RadLabel()
            RadLabel11 = New Telerik.WinControls.UI.RadLabel()
            RadLabel12 = New Telerik.WinControls.UI.RadLabel()
            RadLabel13 = New Telerik.WinControls.UI.RadLabel()
            RadLabel14 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OfertasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer1.SuspendLayout()
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel1.SuspendLayout()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel2.SuspendLayout()
            CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.OfertaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadGroupBox1.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.radDescuentoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadPanel6.SuspendLayout()
            CType(Me.txtUnidadPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtUnidadBaseP, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadPanel5.SuspendLayout()
            CType(Me.txtUnidadDesc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtUnidadBaseD, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadPanel4.SuspendLayout()
            CType(Me.txtUnidadGratis, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtUnidadBase, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadPanel2.SuspendLayout()
            CType(Me.txtDescPorc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radUnidadGratis, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radUnidadPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radUnidadDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radDescuentoPorcentual, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radPrecioEspecial, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadPanel1.SuspendLayout()
            CType(Me.txtPrecioEspecial, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadPanel3.SuspendLayout()
            CType(Me.txtDescFijo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkActivo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNumeroOferta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            RadLabel5.RootElement.KeyTip = resources.GetString("RadLabel5.RootElement.KeyTip")
            RadLabel5.RootElement.Margin = CType(resources.GetObject("RadLabel5.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel5.RootElement.Padding = CType(resources.GetObject("RadLabel5.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel5.RootElement.Text = resources.GetString("RadLabel5.RootElement.Text")
            RadLabel5.RootElement.TextOrientation = CType(resources.GetObject("RadLabel5.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel5.RootElement.ToolTipText = resources.GetString("RadLabel5.RootElement.ToolTipText")
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
            RadLabel6.RootElement.KeyTip = resources.GetString("RadLabel6.RootElement.KeyTip")
            RadLabel6.RootElement.Margin = CType(resources.GetObject("RadLabel6.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel6.RootElement.Padding = CType(resources.GetObject("RadLabel6.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel6.RootElement.Text = resources.GetString("RadLabel6.RootElement.Text")
            RadLabel6.RootElement.TextOrientation = CType(resources.GetObject("RadLabel6.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel6.RootElement.ToolTipText = resources.GetString("RadLabel6.RootElement.ToolTipText")
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
            RadLabel4.RootElement.KeyTip = resources.GetString("RadLabel4.RootElement.KeyTip")
            RadLabel4.RootElement.Margin = CType(resources.GetObject("RadLabel4.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel4.RootElement.Padding = CType(resources.GetObject("RadLabel4.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel4.RootElement.Text = resources.GetString("RadLabel4.RootElement.Text")
            RadLabel4.RootElement.TextOrientation = CType(resources.GetObject("RadLabel4.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel4.RootElement.ToolTipText = resources.GetString("RadLabel4.RootElement.ToolTipText")
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
            RadLabel7.RootElement.KeyTip = resources.GetString("RadLabel7.RootElement.KeyTip")
            RadLabel7.RootElement.Margin = CType(resources.GetObject("RadLabel7.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel7.RootElement.Padding = CType(resources.GetObject("RadLabel7.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel7.RootElement.Text = resources.GetString("RadLabel7.RootElement.Text")
            RadLabel7.RootElement.TextOrientation = CType(resources.GetObject("RadLabel7.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel7.RootElement.ToolTipText = resources.GetString("RadLabel7.RootElement.ToolTipText")
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
            RadLabel8.RootElement.KeyTip = resources.GetString("RadLabel8.RootElement.KeyTip")
            RadLabel8.RootElement.Margin = CType(resources.GetObject("RadLabel8.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel8.RootElement.Padding = CType(resources.GetObject("RadLabel8.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel8.RootElement.Text = resources.GetString("RadLabel8.RootElement.Text")
            RadLabel8.RootElement.TextOrientation = CType(resources.GetObject("RadLabel8.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel8.RootElement.ToolTipText = resources.GetString("RadLabel8.RootElement.ToolTipText")
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
            RadLabel9.RootElement.KeyTip = resources.GetString("RadLabel9.RootElement.KeyTip")
            RadLabel9.RootElement.Margin = CType(resources.GetObject("RadLabel9.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel9.RootElement.Padding = CType(resources.GetObject("RadLabel9.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel9.RootElement.Text = resources.GetString("RadLabel9.RootElement.Text")
            RadLabel9.RootElement.TextOrientation = CType(resources.GetObject("RadLabel9.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel9.RootElement.ToolTipText = resources.GetString("RadLabel9.RootElement.ToolTipText")
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
            RadLabel10.RootElement.KeyTip = resources.GetString("RadLabel10.RootElement.KeyTip")
            RadLabel10.RootElement.Margin = CType(resources.GetObject("RadLabel10.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel10.RootElement.Padding = CType(resources.GetObject("RadLabel10.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel10.RootElement.Text = resources.GetString("RadLabel10.RootElement.Text")
            RadLabel10.RootElement.TextOrientation = CType(resources.GetObject("RadLabel10.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel10.RootElement.ToolTipText = resources.GetString("RadLabel10.RootElement.ToolTipText")
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
            RadLabel11.RootElement.KeyTip = resources.GetString("RadLabel11.RootElement.KeyTip")
            RadLabel11.RootElement.Margin = CType(resources.GetObject("RadLabel11.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel11.RootElement.Padding = CType(resources.GetObject("RadLabel11.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel11.RootElement.Text = resources.GetString("RadLabel11.RootElement.Text")
            RadLabel11.RootElement.TextOrientation = CType(resources.GetObject("RadLabel11.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel11.RootElement.ToolTipText = resources.GetString("RadLabel11.RootElement.ToolTipText")
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
            RadLabel13.RootElement.KeyTip = resources.GetString("RadLabel13.RootElement.KeyTip")
            RadLabel13.RootElement.Margin = CType(resources.GetObject("RadLabel13.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel13.RootElement.Padding = CType(resources.GetObject("RadLabel13.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel13.RootElement.Text = resources.GetString("RadLabel13.RootElement.Text")
            RadLabel13.RootElement.TextOrientation = CType(resources.GetObject("RadLabel13.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel13.RootElement.ToolTipText = resources.GetString("RadLabel13.RootElement.ToolTipText")
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
            RadLabel14.RootElement.KeyTip = resources.GetString("RadLabel14.RootElement.KeyTip")
            RadLabel14.RootElement.Margin = CType(resources.GetObject("RadLabel14.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel14.RootElement.Padding = CType(resources.GetObject("RadLabel14.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel14.RootElement.Text = resources.GetString("RadLabel14.RootElement.Text")
            RadLabel14.RootElement.TextOrientation = CType(resources.GetObject("RadLabel14.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel14.RootElement.ToolTipText = resources.GetString("RadLabel14.RootElement.ToolTipText")
            '
            'gridDatos
            '
            resources.ApplyResources(Me.gridDatos, "gridDatos")
            Me.gridDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDatos.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridDatos.ForeColor = System.Drawing.Color.Black
            '
            'gridDatos
            '
            Me.gridDatos.MasterTemplate.AllowAddNewRow = False
            Me.gridDatos.MasterTemplate.AllowRowResize = False
            resources.ApplyResources(Me.gridDatos.MasterTemplate, "gridDatos")
            GridViewDecimalColumn1.DataType = GetType(Long)
            GridViewDecimalColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn1, "GridViewDecimalColumn1")
            GridViewDecimalColumn1.FieldName = "idOferta"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.IsVisible = False
            GridViewDecimalColumn1.Name = "idOferta"
            GridViewTextBoxColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn1, "GridViewTextBoxColumn1")
            GridViewTextBoxColumn1.FieldName = "NumeroOferta"
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.Name = "NumeroOferta"
            GridViewTextBoxColumn1.Width = 80
            GridViewTextBoxColumn2.AllowFiltering = False
            GridViewTextBoxColumn2.AllowGroup = False
            GridViewTextBoxColumn2.AllowSort = False
            GridViewTextBoxColumn2.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn2, "GridViewTextBoxColumn2")
            GridViewTextBoxColumn2.FieldName = "Plan"
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.Name = "Plan"
            GridViewTextBoxColumn2.ReadOnly = True
            GridViewTextBoxColumn2.Width = 110
            GridViewTextBoxColumn3.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn3, "GridViewTextBoxColumn3")
            GridViewTextBoxColumn3.FieldName = "Descripcion"
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.Name = "Descripcion"
            GridViewTextBoxColumn3.Width = 150
            resources.ApplyResources(GridViewDateTimeColumn1, "GridViewDateTimeColumn1")
            GridViewDateTimeColumn1.EnableExpressionEditor = False
            GridViewDateTimeColumn1.FieldName = "FInicio"
            GridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            GridViewDateTimeColumn1.IsAutoGenerated = True
            GridViewDateTimeColumn1.Name = "FInicio"
            GridViewDateTimeColumn1.Width = 107
            resources.ApplyResources(GridViewDateTimeColumn2, "GridViewDateTimeColumn2")
            GridViewDateTimeColumn2.EnableExpressionEditor = False
            GridViewDateTimeColumn2.FieldName = "FFinalizacion"
            GridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            GridViewDateTimeColumn2.IsAutoGenerated = True
            GridViewDateTimeColumn2.Name = "FFinalizacion"
            GridViewDateTimeColumn2.Width = 111
            GridViewCheckBoxColumn1.AllowFiltering = False
            GridViewCheckBoxColumn1.DataType = GetType(System.Nullable(Of Boolean))
            GridViewCheckBoxColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewCheckBoxColumn1, "GridViewCheckBoxColumn1")
            GridViewCheckBoxColumn1.FieldName = "Vigente"
            GridViewCheckBoxColumn1.IsAutoGenerated = True
            GridViewCheckBoxColumn1.MinWidth = 20
            GridViewCheckBoxColumn1.Name = "Vigente"
            GridViewCheckBoxColumn1.Width = 63
            resources.ApplyResources(GridViewDateTimeColumn3, "GridViewDateTimeColumn3")
            GridViewDateTimeColumn3.EnableExpressionEditor = False
            GridViewDateTimeColumn3.FieldName = "FCreacion"
            GridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
            GridViewDateTimeColumn3.IsAutoGenerated = True
            GridViewDateTimeColumn3.Name = "FCreacion"
            GridViewDateTimeColumn3.Width = 109
            GridViewCheckBoxColumn2.AllowFiltering = False
            GridViewCheckBoxColumn2.EnableExpressionEditor = False
            resources.ApplyResources(GridViewCheckBoxColumn2, "GridViewCheckBoxColumn2")
            GridViewCheckBoxColumn2.FieldName = "Activo"
            GridViewCheckBoxColumn2.IsAutoGenerated = True
            GridViewCheckBoxColumn2.IsVisible = False
            GridViewCheckBoxColumn2.MinWidth = 20
            GridViewCheckBoxColumn2.Name = "Activo"
            GridViewCheckBoxColumn2.Width = 66
            GridViewDecimalColumn2.DataType = GetType(Integer)
            GridViewDecimalColumn2.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn2, "GridViewDecimalColumn2")
            GridViewDecimalColumn2.FieldName = "Forma"
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.IsVisible = False
            GridViewDecimalColumn2.Name = "Forma"
            GridViewDecimalColumn3.DataType = GetType(Integer)
            GridViewDecimalColumn3.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn3, "GridViewDecimalColumn3")
            GridViewDecimalColumn3.FieldName = "DiaDuracion"
            GridViewDecimalColumn3.IsAutoGenerated = True
            GridViewDecimalColumn3.IsVisible = False
            GridViewDecimalColumn3.Name = "DiaDuracion"
            GridViewDecimalColumn4.DataType = GetType(Double)
            GridViewDecimalColumn4.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn4, "GridViewDecimalColumn4")
            GridViewDecimalColumn4.FieldName = "Valor1"
            GridViewDecimalColumn4.IsAutoGenerated = True
            GridViewDecimalColumn4.IsVisible = False
            GridViewDecimalColumn4.Name = "Valor1"
            GridViewDecimalColumn5.DataType = GetType(Double)
            GridViewDecimalColumn5.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn5, "GridViewDecimalColumn5")
            GridViewDecimalColumn5.FieldName = "Valor2"
            GridViewDecimalColumn5.IsAutoGenerated = True
            GridViewDecimalColumn5.IsVisible = False
            GridViewDecimalColumn5.Name = "Valor2"
            Me.gridDatos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewDateTimeColumn1, GridViewDateTimeColumn2, GridViewCheckBoxColumn1, GridViewDateTimeColumn3, GridViewCheckBoxColumn2, GridViewDecimalColumn2, GridViewDecimalColumn3, GridViewDecimalColumn4, GridViewDecimalColumn5})
            Me.gridDatos.MasterTemplate.DataSource = Me.OfertasBindingSource
            Me.gridDatos.MasterTemplate.EnableAlternatingRowColor = True
            Me.gridDatos.MasterTemplate.EnableFiltering = True
            Me.gridDatos.MasterTemplate.EnableGrouping = False
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
            Me.gridDatos.RootElement.KeyTip = resources.GetString("gridDatos.RootElement.KeyTip")
            Me.gridDatos.RootElement.Margin = CType(resources.GetObject("gridDatos.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.gridDatos.RootElement.Padding = CType(resources.GetObject("gridDatos.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.gridDatos.RootElement.Text = resources.GetString("gridDatos.RootElement.Text")
            Me.gridDatos.RootElement.TextOrientation = CType(resources.GetObject("gridDatos.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.gridDatos.RootElement.ToolTipText = resources.GetString("gridDatos.RootElement.ToolTipText")
            Me.gridDatos.ShowGroupPanel = False
            Me.gridDatos.TabStop = False
            '
            'OfertasBindingSource
            '
            Me.OfertasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Ofertas)
            '
            'RadSplitContainer1
            '
            resources.ApplyResources(Me.RadSplitContainer1, "RadSplitContainer1")
            Me.RadSplitContainer1.Controls.Add(Me.SplitPanel1)
            Me.RadSplitContainer1.Controls.Add(Me.SplitPanel2)
            Me.RadSplitContainer1.Name = "RadSplitContainer1"
            '
            '
            '
            Me.RadSplitContainer1.RootElement.AccessibleDescription = resources.GetString("RadSplitContainer1.RootElement.AccessibleDescription")
            Me.RadSplitContainer1.RootElement.AccessibleName = resources.GetString("RadSplitContainer1.RootElement.AccessibleName")
            Me.RadSplitContainer1.RootElement.Alignment = CType(resources.GetObject("RadSplitContainer1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadSplitContainer1.RootElement.AngleTransform = CType(resources.GetObject("RadSplitContainer1.RootElement.AngleTransform"), Single)
            Me.RadSplitContainer1.RootElement.FlipText = CType(resources.GetObject("RadSplitContainer1.RootElement.FlipText"), Boolean)
            Me.RadSplitContainer1.RootElement.KeyTip = resources.GetString("RadSplitContainer1.RootElement.KeyTip")
            Me.RadSplitContainer1.RootElement.Margin = CType(resources.GetObject("RadSplitContainer1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.RadSplitContainer1.RootElement.Padding = CType(resources.GetObject("RadSplitContainer1.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadSplitContainer1.RootElement.Text = resources.GetString("RadSplitContainer1.RootElement.Text")
            Me.RadSplitContainer1.RootElement.TextOrientation = CType(resources.GetObject("RadSplitContainer1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadSplitContainer1.RootElement.ToolTipText = resources.GetString("RadSplitContainer1.RootElement.ToolTipText")
            Me.RadSplitContainer1.TabStop = False
            '
            'SplitPanel1
            '
            resources.ApplyResources(Me.SplitPanel1, "SplitPanel1")
            Me.SplitPanel1.Controls.Add(Me.gridDatos)
            Me.SplitPanel1.Name = "SplitPanel1"
            '
            '
            '
            Me.SplitPanel1.RootElement.AccessibleDescription = resources.GetString("SplitPanel1.RootElement.AccessibleDescription")
            Me.SplitPanel1.RootElement.AccessibleName = resources.GetString("SplitPanel1.RootElement.AccessibleName")
            Me.SplitPanel1.RootElement.Alignment = CType(resources.GetObject("SplitPanel1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel1.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel1.RootElement.AngleTransform"), Single)
            Me.SplitPanel1.RootElement.FlipText = CType(resources.GetObject("SplitPanel1.RootElement.FlipText"), Boolean)
            Me.SplitPanel1.RootElement.KeyTip = resources.GetString("SplitPanel1.RootElement.KeyTip")
            Me.SplitPanel1.RootElement.Margin = CType(resources.GetObject("SplitPanel1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel1.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.SplitPanel1.RootElement.Padding = CType(resources.GetObject("SplitPanel1.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.SplitPanel1.RootElement.Text = resources.GetString("SplitPanel1.RootElement.Text")
            Me.SplitPanel1.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel1.RootElement.ToolTipText = resources.GetString("SplitPanel1.RootElement.ToolTipText")
            Me.SplitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.1980109!, -0.2169231!)
            Me.SplitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(189, -182)
            Me.SplitPanel1.TabStop = False
            '
            'SplitPanel2
            '
            resources.ApplyResources(Me.SplitPanel2, "SplitPanel2")
            Me.SplitPanel2.Controls.Add(Me.txtDescripcion)
            Me.SplitPanel2.Controls.Add(Me.RadGroupBox1)
            Me.SplitPanel2.Controls.Add(Me.dtpFechaInicio)
            Me.SplitPanel2.Controls.Add(Me.chkActivo)
            Me.SplitPanel2.Controls.Add(RadLabel6)
            Me.SplitPanel2.Controls.Add(Me.spinDuracion)
            Me.SplitPanel2.Controls.Add(Me.btnCancelar)
            Me.SplitPanel2.Controls.Add(Me.btnAceptar)
            Me.SplitPanel2.Controls.Add(Me.txtNumeroOferta)
            Me.SplitPanel2.Controls.Add(RadLabel14)
            Me.SplitPanel2.Controls.Add(RadLabel5)
            Me.SplitPanel2.Controls.Add(RadLabel2)
            Me.SplitPanel2.Controls.Add(RadLabel1)
            Me.SplitPanel2.Name = "SplitPanel2"
            '
            '
            '
            Me.SplitPanel2.RootElement.AccessibleDescription = resources.GetString("SplitPanel2.RootElement.AccessibleDescription")
            Me.SplitPanel2.RootElement.AccessibleName = resources.GetString("SplitPanel2.RootElement.AccessibleName")
            Me.SplitPanel2.RootElement.Alignment = CType(resources.GetObject("SplitPanel2.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel2.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel2.RootElement.AngleTransform"), Single)
            Me.SplitPanel2.RootElement.FlipText = CType(resources.GetObject("SplitPanel2.RootElement.FlipText"), Boolean)
            Me.SplitPanel2.RootElement.KeyTip = resources.GetString("SplitPanel2.RootElement.KeyTip")
            Me.SplitPanel2.RootElement.Margin = CType(resources.GetObject("SplitPanel2.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel2.RootElement.MinSize = New System.Drawing.Size(25, 25)
            Me.SplitPanel2.RootElement.Padding = CType(resources.GetObject("SplitPanel2.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.SplitPanel2.RootElement.Text = resources.GetString("SplitPanel2.RootElement.Text")
            Me.SplitPanel2.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel2.RootElement.ToolTipText = resources.GetString("SplitPanel2.RootElement.ToolTipText")
            Me.SplitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.0!, 0.2169231!)
            Me.SplitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 182)
            Me.SplitPanel2.TabStop = False
            '
            'txtDescripcion
            '
            Me.txtDescripcion.AcceptsReturn = True
            resources.ApplyResources(Me.txtDescripcion, "txtDescripcion")
            Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "Descripcion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtDescripcion.Name = "txtDescripcion"
            '
            '
            '
            Me.txtDescripcion.RootElement.AccessibleDescription = resources.GetString("txtDescripcion.RootElement.AccessibleDescription")
            Me.txtDescripcion.RootElement.AccessibleName = resources.GetString("txtDescripcion.RootElement.AccessibleName")
            Me.txtDescripcion.RootElement.Alignment = CType(resources.GetObject("txtDescripcion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtDescripcion.RootElement.AngleTransform = CType(resources.GetObject("txtDescripcion.RootElement.AngleTransform"), Single)
            Me.txtDescripcion.RootElement.ApplyShapeToControl = False
            Me.txtDescripcion.RootElement.FlipText = CType(resources.GetObject("txtDescripcion.RootElement.FlipText"), Boolean)
            Me.txtDescripcion.RootElement.KeyTip = resources.GetString("txtDescripcion.RootElement.KeyTip")
            Me.txtDescripcion.RootElement.Margin = CType(resources.GetObject("txtDescripcion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtDescripcion.RootElement.Padding = CType(resources.GetObject("txtDescripcion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtDescripcion.RootElement.Text = resources.GetString("txtDescripcion.RootElement.Text")
            Me.txtDescripcion.RootElement.TextOrientation = CType(resources.GetObject("txtDescripcion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtDescripcion.RootElement.ToolTipText = resources.GetString("txtDescripcion.RootElement.ToolTipText")
            Me.txtDescripcion.TabStop = False
            Me.txtDescripcion.Tag = ""
            CType(Me.txtDescripcion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = False
            CType(Me.txtDescripcion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text")
            CType(Me.txtDescripcion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtDescripcion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtDescripcion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtDescripcion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = False
            CType(Me.txtDescripcion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtDescripcion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'OfertaBindingSource
            '
            Me.OfertaBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Ofertas)
            '
            'RadGroupBox1
            '
            resources.ApplyResources(Me.RadGroupBox1, "RadGroupBox1")
            Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.RadGroupBox1.Controls.Add(Me.TableLayoutPanel1)
            Me.RadGroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.RadGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            Me.RadGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
            Me.RadGroupBox1.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Left
            Me.RadGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.RadGroupBox1.Name = "RadGroupBox1"
            '
            '
            '
            Me.RadGroupBox1.RootElement.AccessibleDescription = resources.GetString("RadGroupBox1.RootElement.AccessibleDescription")
            Me.RadGroupBox1.RootElement.AccessibleName = resources.GetString("RadGroupBox1.RootElement.AccessibleName")
            Me.RadGroupBox1.RootElement.Alignment = CType(resources.GetObject("RadGroupBox1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadGroupBox1.RootElement.AngleTransform = CType(resources.GetObject("RadGroupBox1.RootElement.AngleTransform"), Single)
            Me.RadGroupBox1.RootElement.FlipText = CType(resources.GetObject("RadGroupBox1.RootElement.FlipText"), Boolean)
            Me.RadGroupBox1.RootElement.KeyTip = resources.GetString("RadGroupBox1.RootElement.KeyTip")
            Me.RadGroupBox1.RootElement.Margin = CType(resources.GetObject("RadGroupBox1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadGroupBox1.RootElement.Padding = CType(resources.GetObject("RadGroupBox1.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadGroupBox1.RootElement.Text = resources.GetString("RadGroupBox1.RootElement.Text")
            Me.RadGroupBox1.RootElement.TextOrientation = CType(resources.GetObject("RadGroupBox1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadGroupBox1.RootElement.ToolTipText = resources.GetString("RadGroupBox1.RootElement.ToolTipText")
            CType(Me.RadGroupBox1.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).InvalidateMeasureInMainLayout = 1
            CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Left
            CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).AngleTransform = CType(resources.GetObject("resource.AngleTransform"), Single)
            '
            'TableLayoutPanel1
            '
            resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
            Me.TableLayoutPanel1.Controls.Add(Me.radDescuentoFijo, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.RadPanel6, 1, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.RadPanel5, 1, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.RadPanel4, 1, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.RadPanel2, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.radUnidadGratis, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.radUnidadPrecio, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.radUnidadDescuento, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.radDescuentoPorcentual, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.radPrecioEspecial, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.RadPanel1, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.RadPanel3, 1, 2)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            '
            'radDescuentoFijo
            '
            resources.ApplyResources(Me.radDescuentoFijo, "radDescuentoFijo")
            Me.radDescuentoFijo.IsThreeState = True
            Me.radDescuentoFijo.Name = "radDescuentoFijo"
            '
            '
            '
            Me.radDescuentoFijo.RootElement.AccessibleDescription = resources.GetString("radDescuentoFijo.RootElement.AccessibleDescription")
            Me.radDescuentoFijo.RootElement.AccessibleName = resources.GetString("radDescuentoFijo.RootElement.AccessibleName")
            Me.radDescuentoFijo.RootElement.Alignment = CType(resources.GetObject("radDescuentoFijo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.radDescuentoFijo.RootElement.AngleTransform = CType(resources.GetObject("radDescuentoFijo.RootElement.AngleTransform"), Single)
            Me.radDescuentoFijo.RootElement.FlipText = CType(resources.GetObject("radDescuentoFijo.RootElement.FlipText"), Boolean)
            Me.radDescuentoFijo.RootElement.KeyTip = resources.GetString("radDescuentoFijo.RootElement.KeyTip")
            Me.radDescuentoFijo.RootElement.Margin = CType(resources.GetObject("radDescuentoFijo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.radDescuentoFijo.RootElement.Padding = CType(resources.GetObject("radDescuentoFijo.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.radDescuentoFijo.RootElement.Text = resources.GetString("radDescuentoFijo.RootElement.Text")
            Me.radDescuentoFijo.RootElement.TextOrientation = CType(resources.GetObject("radDescuentoFijo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.radDescuentoFijo.RootElement.ToolTipText = resources.GetString("radDescuentoFijo.RootElement.ToolTipText")
            Me.radDescuentoFijo.TextWrap = True
            '
            'RadPanel6
            '
            resources.ApplyResources(Me.RadPanel6, "RadPanel6")
            Me.RadPanel6.Controls.Add(RadLabel11)
            Me.RadPanel6.Controls.Add(Me.txtUnidadPrecio)
            Me.RadPanel6.Controls.Add(Me.txtUnidadBaseP)
            Me.RadPanel6.Controls.Add(RadLabel12)
            Me.RadPanel6.Name = "RadPanel6"
            '
            '
            '
            Me.RadPanel6.RootElement.AccessibleDescription = resources.GetString("RadPanel6.RootElement.AccessibleDescription")
            Me.RadPanel6.RootElement.AccessibleName = resources.GetString("RadPanel6.RootElement.AccessibleName")
            Me.RadPanel6.RootElement.Alignment = CType(resources.GetObject("RadPanel6.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadPanel6.RootElement.AngleTransform = CType(resources.GetObject("RadPanel6.RootElement.AngleTransform"), Single)
            Me.RadPanel6.RootElement.FlipText = CType(resources.GetObject("RadPanel6.RootElement.FlipText"), Boolean)
            Me.RadPanel6.RootElement.KeyTip = resources.GetString("RadPanel6.RootElement.KeyTip")
            Me.RadPanel6.RootElement.Margin = CType(resources.GetObject("RadPanel6.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadPanel6.RootElement.Padding = CType(resources.GetObject("RadPanel6.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadPanel6.RootElement.Text = resources.GetString("RadPanel6.RootElement.Text")
            Me.RadPanel6.RootElement.TextOrientation = CType(resources.GetObject("RadPanel6.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadPanel6.RootElement.ToolTipText = resources.GetString("RadPanel6.RootElement.ToolTipText")
            '
            'txtUnidadPrecio
            '
            resources.ApplyResources(Me.txtUnidadPrecio, "txtUnidadPrecio")
            Me.txtUnidadPrecio.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
            Me.txtUnidadPrecio.Name = "txtUnidadPrecio"
            '
            '
            '
            Me.txtUnidadPrecio.RootElement.AccessibleDescription = resources.GetString("txtUnidadPrecio.RootElement.AccessibleDescription")
            Me.txtUnidadPrecio.RootElement.AccessibleName = resources.GetString("txtUnidadPrecio.RootElement.AccessibleName")
            Me.txtUnidadPrecio.RootElement.Alignment = CType(resources.GetObject("txtUnidadPrecio.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtUnidadPrecio.RootElement.AngleTransform = CType(resources.GetObject("txtUnidadPrecio.RootElement.AngleTransform"), Single)
            Me.txtUnidadPrecio.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.txtUnidadPrecio.RootElement.FlipText = CType(resources.GetObject("txtUnidadPrecio.RootElement.FlipText"), Boolean)
            Me.txtUnidadPrecio.RootElement.KeyTip = resources.GetString("txtUnidadPrecio.RootElement.KeyTip")
            Me.txtUnidadPrecio.RootElement.Margin = CType(resources.GetObject("txtUnidadPrecio.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtUnidadPrecio.RootElement.Padding = CType(resources.GetObject("txtUnidadPrecio.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtUnidadPrecio.RootElement.Text = resources.GetString("txtUnidadPrecio.RootElement.Text")
            Me.txtUnidadPrecio.RootElement.TextOrientation = CType(resources.GetObject("txtUnidadPrecio.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtUnidadPrecio.RootElement.ToolTipText = resources.GetString("txtUnidadPrecio.RootElement.ToolTipText")
            Me.txtUnidadPrecio.ShowBorder = True
            Me.txtUnidadPrecio.ShowUpDownButtons = False
            Me.txtUnidadPrecio.TabStop = False
            Me.txtUnidadPrecio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtUnidadPrecio.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'txtUnidadBaseP
            '
            resources.ApplyResources(Me.txtUnidadBaseP, "txtUnidadBaseP")
            Me.txtUnidadBaseP.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
            Me.txtUnidadBaseP.Name = "txtUnidadBaseP"
            '
            '
            '
            Me.txtUnidadBaseP.RootElement.AccessibleDescription = resources.GetString("txtUnidadBaseP.RootElement.AccessibleDescription")
            Me.txtUnidadBaseP.RootElement.AccessibleName = resources.GetString("txtUnidadBaseP.RootElement.AccessibleName")
            Me.txtUnidadBaseP.RootElement.Alignment = CType(resources.GetObject("txtUnidadBaseP.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtUnidadBaseP.RootElement.AngleTransform = CType(resources.GetObject("txtUnidadBaseP.RootElement.AngleTransform"), Single)
            Me.txtUnidadBaseP.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.txtUnidadBaseP.RootElement.FlipText = CType(resources.GetObject("txtUnidadBaseP.RootElement.FlipText"), Boolean)
            Me.txtUnidadBaseP.RootElement.KeyTip = resources.GetString("txtUnidadBaseP.RootElement.KeyTip")
            Me.txtUnidadBaseP.RootElement.Margin = CType(resources.GetObject("txtUnidadBaseP.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtUnidadBaseP.RootElement.Padding = CType(resources.GetObject("txtUnidadBaseP.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtUnidadBaseP.RootElement.Text = resources.GetString("txtUnidadBaseP.RootElement.Text")
            Me.txtUnidadBaseP.RootElement.TextOrientation = CType(resources.GetObject("txtUnidadBaseP.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtUnidadBaseP.RootElement.ToolTipText = resources.GetString("txtUnidadBaseP.RootElement.ToolTipText")
            Me.txtUnidadBaseP.ShowBorder = True
            Me.txtUnidadBaseP.ShowUpDownButtons = False
            Me.txtUnidadBaseP.TabStop = False
            Me.txtUnidadBaseP.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtUnidadBaseP.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'RadPanel5
            '
            resources.ApplyResources(Me.RadPanel5, "RadPanel5")
            Me.RadPanel5.Controls.Add(RadLabel9)
            Me.RadPanel5.Controls.Add(Me.txtUnidadDesc)
            Me.RadPanel5.Controls.Add(Me.txtUnidadBaseD)
            Me.RadPanel5.Controls.Add(RadLabel10)
            Me.RadPanel5.Name = "RadPanel5"
            '
            '
            '
            Me.RadPanel5.RootElement.AccessibleDescription = resources.GetString("RadPanel5.RootElement.AccessibleDescription")
            Me.RadPanel5.RootElement.AccessibleName = resources.GetString("RadPanel5.RootElement.AccessibleName")
            Me.RadPanel5.RootElement.Alignment = CType(resources.GetObject("RadPanel5.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadPanel5.RootElement.AngleTransform = CType(resources.GetObject("RadPanel5.RootElement.AngleTransform"), Single)
            Me.RadPanel5.RootElement.FlipText = CType(resources.GetObject("RadPanel5.RootElement.FlipText"), Boolean)
            Me.RadPanel5.RootElement.KeyTip = resources.GetString("RadPanel5.RootElement.KeyTip")
            Me.RadPanel5.RootElement.Margin = CType(resources.GetObject("RadPanel5.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadPanel5.RootElement.Padding = CType(resources.GetObject("RadPanel5.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadPanel5.RootElement.Text = resources.GetString("RadPanel5.RootElement.Text")
            Me.RadPanel5.RootElement.TextOrientation = CType(resources.GetObject("RadPanel5.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadPanel5.RootElement.ToolTipText = resources.GetString("RadPanel5.RootElement.ToolTipText")
            '
            'txtUnidadDesc
            '
            resources.ApplyResources(Me.txtUnidadDesc, "txtUnidadDesc")
            Me.txtUnidadDesc.Name = "txtUnidadDesc"
            '
            '
            '
            Me.txtUnidadDesc.RootElement.AccessibleDescription = resources.GetString("txtUnidadDesc.RootElement.AccessibleDescription")
            Me.txtUnidadDesc.RootElement.AccessibleName = resources.GetString("txtUnidadDesc.RootElement.AccessibleName")
            Me.txtUnidadDesc.RootElement.Alignment = CType(resources.GetObject("txtUnidadDesc.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtUnidadDesc.RootElement.AngleTransform = CType(resources.GetObject("txtUnidadDesc.RootElement.AngleTransform"), Single)
            Me.txtUnidadDesc.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.txtUnidadDesc.RootElement.FlipText = CType(resources.GetObject("txtUnidadDesc.RootElement.FlipText"), Boolean)
            Me.txtUnidadDesc.RootElement.KeyTip = resources.GetString("txtUnidadDesc.RootElement.KeyTip")
            Me.txtUnidadDesc.RootElement.Margin = CType(resources.GetObject("txtUnidadDesc.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtUnidadDesc.RootElement.Padding = CType(resources.GetObject("txtUnidadDesc.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtUnidadDesc.RootElement.Text = resources.GetString("txtUnidadDesc.RootElement.Text")
            Me.txtUnidadDesc.RootElement.TextOrientation = CType(resources.GetObject("txtUnidadDesc.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtUnidadDesc.RootElement.ToolTipText = resources.GetString("txtUnidadDesc.RootElement.ToolTipText")
            Me.txtUnidadDesc.ShowBorder = True
            Me.txtUnidadDesc.ShowUpDownButtons = False
            Me.txtUnidadDesc.TabStop = False
            Me.txtUnidadDesc.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtUnidadDesc.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'txtUnidadBaseD
            '
            resources.ApplyResources(Me.txtUnidadBaseD, "txtUnidadBaseD")
            Me.txtUnidadBaseD.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
            Me.txtUnidadBaseD.Name = "txtUnidadBaseD"
            '
            '
            '
            Me.txtUnidadBaseD.RootElement.AccessibleDescription = resources.GetString("txtUnidadBaseD.RootElement.AccessibleDescription")
            Me.txtUnidadBaseD.RootElement.AccessibleName = resources.GetString("txtUnidadBaseD.RootElement.AccessibleName")
            Me.txtUnidadBaseD.RootElement.Alignment = CType(resources.GetObject("txtUnidadBaseD.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtUnidadBaseD.RootElement.AngleTransform = CType(resources.GetObject("txtUnidadBaseD.RootElement.AngleTransform"), Single)
            Me.txtUnidadBaseD.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.txtUnidadBaseD.RootElement.FlipText = CType(resources.GetObject("txtUnidadBaseD.RootElement.FlipText"), Boolean)
            Me.txtUnidadBaseD.RootElement.KeyTip = resources.GetString("txtUnidadBaseD.RootElement.KeyTip")
            Me.txtUnidadBaseD.RootElement.Margin = CType(resources.GetObject("txtUnidadBaseD.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtUnidadBaseD.RootElement.Padding = CType(resources.GetObject("txtUnidadBaseD.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtUnidadBaseD.RootElement.Text = resources.GetString("txtUnidadBaseD.RootElement.Text")
            Me.txtUnidadBaseD.RootElement.TextOrientation = CType(resources.GetObject("txtUnidadBaseD.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtUnidadBaseD.RootElement.ToolTipText = resources.GetString("txtUnidadBaseD.RootElement.ToolTipText")
            Me.txtUnidadBaseD.ShowBorder = True
            Me.txtUnidadBaseD.ShowUpDownButtons = False
            Me.txtUnidadBaseD.TabStop = False
            Me.txtUnidadBaseD.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtUnidadBaseD.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'RadPanel4
            '
            resources.ApplyResources(Me.RadPanel4, "RadPanel4")
            Me.RadPanel4.Controls.Add(RadLabel8)
            Me.RadPanel4.Controls.Add(Me.txtUnidadGratis)
            Me.RadPanel4.Controls.Add(Me.txtUnidadBase)
            Me.RadPanel4.Controls.Add(RadLabel7)
            Me.RadPanel4.Name = "RadPanel4"
            '
            '
            '
            Me.RadPanel4.RootElement.AccessibleDescription = resources.GetString("RadPanel4.RootElement.AccessibleDescription")
            Me.RadPanel4.RootElement.AccessibleName = resources.GetString("RadPanel4.RootElement.AccessibleName")
            Me.RadPanel4.RootElement.Alignment = CType(resources.GetObject("RadPanel4.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadPanel4.RootElement.AngleTransform = CType(resources.GetObject("RadPanel4.RootElement.AngleTransform"), Single)
            Me.RadPanel4.RootElement.FlipText = CType(resources.GetObject("RadPanel4.RootElement.FlipText"), Boolean)
            Me.RadPanel4.RootElement.KeyTip = resources.GetString("RadPanel4.RootElement.KeyTip")
            Me.RadPanel4.RootElement.Margin = CType(resources.GetObject("RadPanel4.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadPanel4.RootElement.Padding = CType(resources.GetObject("RadPanel4.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadPanel4.RootElement.Text = resources.GetString("RadPanel4.RootElement.Text")
            Me.RadPanel4.RootElement.TextOrientation = CType(resources.GetObject("RadPanel4.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadPanel4.RootElement.ToolTipText = resources.GetString("RadPanel4.RootElement.ToolTipText")
            '
            'txtUnidadGratis
            '
            resources.ApplyResources(Me.txtUnidadGratis, "txtUnidadGratis")
            Me.txtUnidadGratis.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
            Me.txtUnidadGratis.Name = "txtUnidadGratis"
            '
            '
            '
            Me.txtUnidadGratis.RootElement.AccessibleDescription = resources.GetString("txtUnidadGratis.RootElement.AccessibleDescription")
            Me.txtUnidadGratis.RootElement.AccessibleName = resources.GetString("txtUnidadGratis.RootElement.AccessibleName")
            Me.txtUnidadGratis.RootElement.Alignment = CType(resources.GetObject("txtUnidadGratis.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtUnidadGratis.RootElement.AngleTransform = CType(resources.GetObject("txtUnidadGratis.RootElement.AngleTransform"), Single)
            Me.txtUnidadGratis.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.txtUnidadGratis.RootElement.FlipText = CType(resources.GetObject("txtUnidadGratis.RootElement.FlipText"), Boolean)
            Me.txtUnidadGratis.RootElement.KeyTip = resources.GetString("txtUnidadGratis.RootElement.KeyTip")
            Me.txtUnidadGratis.RootElement.Margin = CType(resources.GetObject("txtUnidadGratis.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtUnidadGratis.RootElement.Padding = CType(resources.GetObject("txtUnidadGratis.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtUnidadGratis.RootElement.Text = resources.GetString("txtUnidadGratis.RootElement.Text")
            Me.txtUnidadGratis.RootElement.TextOrientation = CType(resources.GetObject("txtUnidadGratis.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtUnidadGratis.RootElement.ToolTipText = resources.GetString("txtUnidadGratis.RootElement.ToolTipText")
            Me.txtUnidadGratis.ShowBorder = True
            Me.txtUnidadGratis.ShowUpDownButtons = False
            Me.txtUnidadGratis.TabStop = False
            Me.txtUnidadGratis.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtUnidadGratis.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'txtUnidadBase
            '
            resources.ApplyResources(Me.txtUnidadBase, "txtUnidadBase")
            Me.txtUnidadBase.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
            Me.txtUnidadBase.Name = "txtUnidadBase"
            '
            '
            '
            Me.txtUnidadBase.RootElement.AccessibleDescription = resources.GetString("txtUnidadBase.RootElement.AccessibleDescription")
            Me.txtUnidadBase.RootElement.AccessibleName = resources.GetString("txtUnidadBase.RootElement.AccessibleName")
            Me.txtUnidadBase.RootElement.Alignment = CType(resources.GetObject("txtUnidadBase.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtUnidadBase.RootElement.AngleTransform = CType(resources.GetObject("txtUnidadBase.RootElement.AngleTransform"), Single)
            Me.txtUnidadBase.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.txtUnidadBase.RootElement.FlipText = CType(resources.GetObject("txtUnidadBase.RootElement.FlipText"), Boolean)
            Me.txtUnidadBase.RootElement.KeyTip = resources.GetString("txtUnidadBase.RootElement.KeyTip")
            Me.txtUnidadBase.RootElement.Margin = CType(resources.GetObject("txtUnidadBase.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtUnidadBase.RootElement.Padding = CType(resources.GetObject("txtUnidadBase.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtUnidadBase.RootElement.Text = resources.GetString("txtUnidadBase.RootElement.Text")
            Me.txtUnidadBase.RootElement.TextOrientation = CType(resources.GetObject("txtUnidadBase.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtUnidadBase.RootElement.ToolTipText = resources.GetString("txtUnidadBase.RootElement.ToolTipText")
            Me.txtUnidadBase.ShowBorder = True
            Me.txtUnidadBase.ShowUpDownButtons = False
            Me.txtUnidadBase.TabStop = False
            Me.txtUnidadBase.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtUnidadBase.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'RadPanel2
            '
            resources.ApplyResources(Me.RadPanel2, "RadPanel2")
            Me.RadPanel2.Controls.Add(Me.txtDescPorc)
            Me.RadPanel2.Controls.Add(RadLabel4)
            Me.RadPanel2.Name = "RadPanel2"
            '
            '
            '
            Me.RadPanel2.RootElement.AccessibleDescription = resources.GetString("RadPanel2.RootElement.AccessibleDescription")
            Me.RadPanel2.RootElement.AccessibleName = resources.GetString("RadPanel2.RootElement.AccessibleName")
            Me.RadPanel2.RootElement.Alignment = CType(resources.GetObject("RadPanel2.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadPanel2.RootElement.AngleTransform = CType(resources.GetObject("RadPanel2.RootElement.AngleTransform"), Single)
            Me.RadPanel2.RootElement.FlipText = CType(resources.GetObject("RadPanel2.RootElement.FlipText"), Boolean)
            Me.RadPanel2.RootElement.KeyTip = resources.GetString("RadPanel2.RootElement.KeyTip")
            Me.RadPanel2.RootElement.Margin = CType(resources.GetObject("RadPanel2.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadPanel2.RootElement.Padding = CType(resources.GetObject("RadPanel2.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadPanel2.RootElement.Text = resources.GetString("RadPanel2.RootElement.Text")
            Me.RadPanel2.RootElement.TextOrientation = CType(resources.GetObject("RadPanel2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadPanel2.RootElement.ToolTipText = resources.GetString("RadPanel2.RootElement.ToolTipText")
            '
            'txtDescPorc
            '
            resources.ApplyResources(Me.txtDescPorc, "txtDescPorc")
            Me.txtDescPorc.Name = "txtDescPorc"
            '
            '
            '
            Me.txtDescPorc.RootElement.AccessibleDescription = resources.GetString("txtDescPorc.RootElement.AccessibleDescription")
            Me.txtDescPorc.RootElement.AccessibleName = resources.GetString("txtDescPorc.RootElement.AccessibleName")
            Me.txtDescPorc.RootElement.Alignment = CType(resources.GetObject("txtDescPorc.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtDescPorc.RootElement.AngleTransform = CType(resources.GetObject("txtDescPorc.RootElement.AngleTransform"), Single)
            Me.txtDescPorc.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.txtDescPorc.RootElement.FlipText = CType(resources.GetObject("txtDescPorc.RootElement.FlipText"), Boolean)
            Me.txtDescPorc.RootElement.KeyTip = resources.GetString("txtDescPorc.RootElement.KeyTip")
            Me.txtDescPorc.RootElement.Margin = CType(resources.GetObject("txtDescPorc.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtDescPorc.RootElement.Padding = CType(resources.GetObject("txtDescPorc.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtDescPorc.RootElement.Text = resources.GetString("txtDescPorc.RootElement.Text")
            Me.txtDescPorc.RootElement.TextOrientation = CType(resources.GetObject("txtDescPorc.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtDescPorc.RootElement.ToolTipText = resources.GetString("txtDescPorc.RootElement.ToolTipText")
            Me.txtDescPorc.ShowBorder = True
            Me.txtDescPorc.ShowUpDownButtons = False
            Me.txtDescPorc.TabStop = False
            Me.txtDescPorc.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtDescPorc.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'radUnidadGratis
            '
            resources.ApplyResources(Me.radUnidadGratis, "radUnidadGratis")
            Me.radUnidadGratis.IsThreeState = True
            Me.radUnidadGratis.Name = "radUnidadGratis"
            '
            '
            '
            Me.radUnidadGratis.RootElement.AccessibleDescription = resources.GetString("radUnidadGratis.RootElement.AccessibleDescription")
            Me.radUnidadGratis.RootElement.AccessibleName = resources.GetString("radUnidadGratis.RootElement.AccessibleName")
            Me.radUnidadGratis.RootElement.Alignment = CType(resources.GetObject("radUnidadGratis.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.radUnidadGratis.RootElement.AngleTransform = CType(resources.GetObject("radUnidadGratis.RootElement.AngleTransform"), Single)
            Me.radUnidadGratis.RootElement.FlipText = CType(resources.GetObject("radUnidadGratis.RootElement.FlipText"), Boolean)
            Me.radUnidadGratis.RootElement.KeyTip = resources.GetString("radUnidadGratis.RootElement.KeyTip")
            Me.radUnidadGratis.RootElement.Margin = CType(resources.GetObject("radUnidadGratis.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.radUnidadGratis.RootElement.Padding = CType(resources.GetObject("radUnidadGratis.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.radUnidadGratis.RootElement.Text = resources.GetString("radUnidadGratis.RootElement.Text")
            Me.radUnidadGratis.RootElement.TextOrientation = CType(resources.GetObject("radUnidadGratis.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.radUnidadGratis.RootElement.ToolTipText = resources.GetString("radUnidadGratis.RootElement.ToolTipText")
            Me.radUnidadGratis.TextWrap = True
            '
            'radUnidadPrecio
            '
            resources.ApplyResources(Me.radUnidadPrecio, "radUnidadPrecio")
            Me.radUnidadPrecio.IsThreeState = True
            Me.radUnidadPrecio.Name = "radUnidadPrecio"
            '
            '
            '
            Me.radUnidadPrecio.RootElement.AccessibleDescription = resources.GetString("radUnidadPrecio.RootElement.AccessibleDescription")
            Me.radUnidadPrecio.RootElement.AccessibleName = resources.GetString("radUnidadPrecio.RootElement.AccessibleName")
            Me.radUnidadPrecio.RootElement.Alignment = CType(resources.GetObject("radUnidadPrecio.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.radUnidadPrecio.RootElement.AngleTransform = CType(resources.GetObject("radUnidadPrecio.RootElement.AngleTransform"), Single)
            Me.radUnidadPrecio.RootElement.FlipText = CType(resources.GetObject("radUnidadPrecio.RootElement.FlipText"), Boolean)
            Me.radUnidadPrecio.RootElement.KeyTip = resources.GetString("radUnidadPrecio.RootElement.KeyTip")
            Me.radUnidadPrecio.RootElement.Margin = CType(resources.GetObject("radUnidadPrecio.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.radUnidadPrecio.RootElement.Padding = CType(resources.GetObject("radUnidadPrecio.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.radUnidadPrecio.RootElement.Text = resources.GetString("radUnidadPrecio.RootElement.Text")
            Me.radUnidadPrecio.RootElement.TextOrientation = CType(resources.GetObject("radUnidadPrecio.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.radUnidadPrecio.RootElement.ToolTipText = resources.GetString("radUnidadPrecio.RootElement.ToolTipText")
            Me.radUnidadPrecio.TextWrap = True
            '
            'radUnidadDescuento
            '
            resources.ApplyResources(Me.radUnidadDescuento, "radUnidadDescuento")
            Me.radUnidadDescuento.IsThreeState = True
            Me.radUnidadDescuento.Name = "radUnidadDescuento"
            '
            '
            '
            Me.radUnidadDescuento.RootElement.AccessibleDescription = resources.GetString("radUnidadDescuento.RootElement.AccessibleDescription")
            Me.radUnidadDescuento.RootElement.AccessibleName = resources.GetString("radUnidadDescuento.RootElement.AccessibleName")
            Me.radUnidadDescuento.RootElement.Alignment = CType(resources.GetObject("radUnidadDescuento.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.radUnidadDescuento.RootElement.AngleTransform = CType(resources.GetObject("radUnidadDescuento.RootElement.AngleTransform"), Single)
            Me.radUnidadDescuento.RootElement.FlipText = CType(resources.GetObject("radUnidadDescuento.RootElement.FlipText"), Boolean)
            Me.radUnidadDescuento.RootElement.KeyTip = resources.GetString("radUnidadDescuento.RootElement.KeyTip")
            Me.radUnidadDescuento.RootElement.Margin = CType(resources.GetObject("radUnidadDescuento.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.radUnidadDescuento.RootElement.Padding = CType(resources.GetObject("radUnidadDescuento.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.radUnidadDescuento.RootElement.Text = resources.GetString("radUnidadDescuento.RootElement.Text")
            Me.radUnidadDescuento.RootElement.TextOrientation = CType(resources.GetObject("radUnidadDescuento.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.radUnidadDescuento.RootElement.ToolTipText = resources.GetString("radUnidadDescuento.RootElement.ToolTipText")
            Me.radUnidadDescuento.TextWrap = True
            '
            'radDescuentoPorcentual
            '
            resources.ApplyResources(Me.radDescuentoPorcentual, "radDescuentoPorcentual")
            Me.radDescuentoPorcentual.IsThreeState = True
            Me.radDescuentoPorcentual.Name = "radDescuentoPorcentual"
            '
            '
            '
            Me.radDescuentoPorcentual.RootElement.AccessibleDescription = resources.GetString("radDescuentoPorcentual.RootElement.AccessibleDescription")
            Me.radDescuentoPorcentual.RootElement.AccessibleName = resources.GetString("radDescuentoPorcentual.RootElement.AccessibleName")
            Me.radDescuentoPorcentual.RootElement.Alignment = CType(resources.GetObject("radDescuentoPorcentual.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.radDescuentoPorcentual.RootElement.AngleTransform = CType(resources.GetObject("radDescuentoPorcentual.RootElement.AngleTransform"), Single)
            Me.radDescuentoPorcentual.RootElement.FlipText = CType(resources.GetObject("radDescuentoPorcentual.RootElement.FlipText"), Boolean)
            Me.radDescuentoPorcentual.RootElement.KeyTip = resources.GetString("radDescuentoPorcentual.RootElement.KeyTip")
            Me.radDescuentoPorcentual.RootElement.Margin = CType(resources.GetObject("radDescuentoPorcentual.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.radDescuentoPorcentual.RootElement.Padding = CType(resources.GetObject("radDescuentoPorcentual.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.radDescuentoPorcentual.RootElement.Text = resources.GetString("radDescuentoPorcentual.RootElement.Text")
            Me.radDescuentoPorcentual.RootElement.TextOrientation = CType(resources.GetObject("radDescuentoPorcentual.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.radDescuentoPorcentual.RootElement.ToolTipText = resources.GetString("radDescuentoPorcentual.RootElement.ToolTipText")
            Me.radDescuentoPorcentual.TextWrap = True
            '
            'radPrecioEspecial
            '
            resources.ApplyResources(Me.radPrecioEspecial, "radPrecioEspecial")
            Me.radPrecioEspecial.IsThreeState = True
            Me.radPrecioEspecial.Name = "radPrecioEspecial"
            '
            '
            '
            Me.radPrecioEspecial.RootElement.AccessibleDescription = resources.GetString("radPrecioEspecial.RootElement.AccessibleDescription")
            Me.radPrecioEspecial.RootElement.AccessibleName = resources.GetString("radPrecioEspecial.RootElement.AccessibleName")
            Me.radPrecioEspecial.RootElement.Alignment = CType(resources.GetObject("radPrecioEspecial.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.radPrecioEspecial.RootElement.AngleTransform = CType(resources.GetObject("radPrecioEspecial.RootElement.AngleTransform"), Single)
            Me.radPrecioEspecial.RootElement.FlipText = CType(resources.GetObject("radPrecioEspecial.RootElement.FlipText"), Boolean)
            Me.radPrecioEspecial.RootElement.KeyTip = resources.GetString("radPrecioEspecial.RootElement.KeyTip")
            Me.radPrecioEspecial.RootElement.Margin = CType(resources.GetObject("radPrecioEspecial.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.radPrecioEspecial.RootElement.Padding = CType(resources.GetObject("radPrecioEspecial.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.radPrecioEspecial.RootElement.Text = resources.GetString("radPrecioEspecial.RootElement.Text")
            Me.radPrecioEspecial.RootElement.TextOrientation = CType(resources.GetObject("radPrecioEspecial.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.radPrecioEspecial.RootElement.ToolTipText = resources.GetString("radPrecioEspecial.RootElement.ToolTipText")
            Me.radPrecioEspecial.TextWrap = True
            '
            'RadPanel1
            '
            resources.ApplyResources(Me.RadPanel1, "RadPanel1")
            Me.RadPanel1.Controls.Add(Me.txtPrecioEspecial)
            Me.RadPanel1.Controls.Add(RadLabel3)
            Me.RadPanel1.Name = "RadPanel1"
            '
            '
            '
            Me.RadPanel1.RootElement.AccessibleDescription = resources.GetString("RadPanel1.RootElement.AccessibleDescription")
            Me.RadPanel1.RootElement.AccessibleName = resources.GetString("RadPanel1.RootElement.AccessibleName")
            Me.RadPanel1.RootElement.Alignment = CType(resources.GetObject("RadPanel1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadPanel1.RootElement.AngleTransform = CType(resources.GetObject("RadPanel1.RootElement.AngleTransform"), Single)
            Me.RadPanel1.RootElement.FlipText = CType(resources.GetObject("RadPanel1.RootElement.FlipText"), Boolean)
            Me.RadPanel1.RootElement.KeyTip = resources.GetString("RadPanel1.RootElement.KeyTip")
            Me.RadPanel1.RootElement.Margin = CType(resources.GetObject("RadPanel1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadPanel1.RootElement.Padding = CType(resources.GetObject("RadPanel1.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadPanel1.RootElement.Text = resources.GetString("RadPanel1.RootElement.Text")
            Me.RadPanel1.RootElement.TextOrientation = CType(resources.GetObject("RadPanel1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadPanel1.RootElement.ToolTipText = resources.GetString("RadPanel1.RootElement.ToolTipText")
            '
            'txtPrecioEspecial
            '
            resources.ApplyResources(Me.txtPrecioEspecial, "txtPrecioEspecial")
            Me.txtPrecioEspecial.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
            Me.txtPrecioEspecial.Name = "txtPrecioEspecial"
            '
            '
            '
            Me.txtPrecioEspecial.RootElement.AccessibleDescription = resources.GetString("txtPrecioEspecial.RootElement.AccessibleDescription")
            Me.txtPrecioEspecial.RootElement.AccessibleName = resources.GetString("txtPrecioEspecial.RootElement.AccessibleName")
            Me.txtPrecioEspecial.RootElement.Alignment = CType(resources.GetObject("txtPrecioEspecial.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtPrecioEspecial.RootElement.AngleTransform = CType(resources.GetObject("txtPrecioEspecial.RootElement.AngleTransform"), Single)
            Me.txtPrecioEspecial.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.txtPrecioEspecial.RootElement.FlipText = CType(resources.GetObject("txtPrecioEspecial.RootElement.FlipText"), Boolean)
            Me.txtPrecioEspecial.RootElement.KeyTip = resources.GetString("txtPrecioEspecial.RootElement.KeyTip")
            Me.txtPrecioEspecial.RootElement.Margin = CType(resources.GetObject("txtPrecioEspecial.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtPrecioEspecial.RootElement.Padding = CType(resources.GetObject("txtPrecioEspecial.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtPrecioEspecial.RootElement.Text = resources.GetString("txtPrecioEspecial.RootElement.Text")
            Me.txtPrecioEspecial.RootElement.TextOrientation = CType(resources.GetObject("txtPrecioEspecial.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtPrecioEspecial.RootElement.ToolTipText = resources.GetString("txtPrecioEspecial.RootElement.ToolTipText")
            Me.txtPrecioEspecial.ShowBorder = True
            Me.txtPrecioEspecial.ShowUpDownButtons = False
            Me.txtPrecioEspecial.TabStop = False
            Me.txtPrecioEspecial.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtPrecioEspecial.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'RadPanel3
            '
            resources.ApplyResources(Me.RadPanel3, "RadPanel3")
            Me.RadPanel3.Controls.Add(Me.txtDescFijo)
            Me.RadPanel3.Controls.Add(RadLabel13)
            Me.RadPanel3.Name = "RadPanel3"
            '
            '
            '
            Me.RadPanel3.RootElement.AccessibleDescription = resources.GetString("RadPanel3.RootElement.AccessibleDescription")
            Me.RadPanel3.RootElement.AccessibleName = resources.GetString("RadPanel3.RootElement.AccessibleName")
            Me.RadPanel3.RootElement.Alignment = CType(resources.GetObject("RadPanel3.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadPanel3.RootElement.AngleTransform = CType(resources.GetObject("RadPanel3.RootElement.AngleTransform"), Single)
            Me.RadPanel3.RootElement.FlipText = CType(resources.GetObject("RadPanel3.RootElement.FlipText"), Boolean)
            Me.RadPanel3.RootElement.KeyTip = resources.GetString("RadPanel3.RootElement.KeyTip")
            Me.RadPanel3.RootElement.Margin = CType(resources.GetObject("RadPanel3.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadPanel3.RootElement.Padding = CType(resources.GetObject("RadPanel3.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadPanel3.RootElement.Text = resources.GetString("RadPanel3.RootElement.Text")
            Me.RadPanel3.RootElement.TextOrientation = CType(resources.GetObject("RadPanel3.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadPanel3.RootElement.ToolTipText = resources.GetString("RadPanel3.RootElement.ToolTipText")
            '
            'txtDescFijo
            '
            resources.ApplyResources(Me.txtDescFijo, "txtDescFijo")
            Me.txtDescFijo.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
            Me.txtDescFijo.Name = "txtDescFijo"
            '
            '
            '
            Me.txtDescFijo.RootElement.AccessibleDescription = resources.GetString("txtDescFijo.RootElement.AccessibleDescription")
            Me.txtDescFijo.RootElement.AccessibleName = resources.GetString("txtDescFijo.RootElement.AccessibleName")
            Me.txtDescFijo.RootElement.Alignment = CType(resources.GetObject("txtDescFijo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtDescFijo.RootElement.AngleTransform = CType(resources.GetObject("txtDescFijo.RootElement.AngleTransform"), Single)
            Me.txtDescFijo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.txtDescFijo.RootElement.FlipText = CType(resources.GetObject("txtDescFijo.RootElement.FlipText"), Boolean)
            Me.txtDescFijo.RootElement.KeyTip = resources.GetString("txtDescFijo.RootElement.KeyTip")
            Me.txtDescFijo.RootElement.Margin = CType(resources.GetObject("txtDescFijo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtDescFijo.RootElement.Padding = CType(resources.GetObject("txtDescFijo.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtDescFijo.RootElement.Text = resources.GetString("txtDescFijo.RootElement.Text")
            Me.txtDescFijo.RootElement.TextOrientation = CType(resources.GetObject("txtDescFijo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtDescFijo.RootElement.ToolTipText = resources.GetString("txtDescFijo.RootElement.ToolTipText")
            Me.txtDescFijo.ShowBorder = True
            Me.txtDescFijo.ShowUpDownButtons = False
            Me.txtDescFijo.TabStop = False
            Me.txtDescFijo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtDescFijo.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'dtpFechaInicio
            '
            resources.ApplyResources(Me.dtpFechaInicio, "dtpFechaInicio")
            Me.dtpFechaInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.dtpFechaInicio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OfertaBindingSource, "FInicio", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.dtpFechaInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFechaInicio.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
            Me.dtpFechaInicio.MinDate = New Date(CType(0, Long))
            Me.dtpFechaInicio.Name = "dtpFechaInicio"
            Me.dtpFechaInicio.NullableValue = New Date(2012, 5, 18, 0, 0, 0, 0)
            Me.dtpFechaInicio.NullDate = New Date(CType(0, Long))
            '
            '
            '
            Me.dtpFechaInicio.RootElement.AccessibleDescription = resources.GetString("dtpFechaInicio.RootElement.AccessibleDescription")
            Me.dtpFechaInicio.RootElement.AccessibleName = resources.GetString("dtpFechaInicio.RootElement.AccessibleName")
            Me.dtpFechaInicio.RootElement.Alignment = CType(resources.GetObject("dtpFechaInicio.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.dtpFechaInicio.RootElement.AngleTransform = CType(resources.GetObject("dtpFechaInicio.RootElement.AngleTransform"), Single)
            Me.dtpFechaInicio.RootElement.FlipText = CType(resources.GetObject("dtpFechaInicio.RootElement.FlipText"), Boolean)
            Me.dtpFechaInicio.RootElement.KeyTip = resources.GetString("dtpFechaInicio.RootElement.KeyTip")
            Me.dtpFechaInicio.RootElement.Margin = CType(resources.GetObject("dtpFechaInicio.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.dtpFechaInicio.RootElement.Padding = CType(resources.GetObject("dtpFechaInicio.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.dtpFechaInicio.RootElement.Text = resources.GetString("dtpFechaInicio.RootElement.Text")
            Me.dtpFechaInicio.RootElement.TextOrientation = CType(resources.GetObject("dtpFechaInicio.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.dtpFechaInicio.RootElement.ToolTipText = resources.GetString("dtpFechaInicio.RootElement.ToolTipText")
            Me.dtpFechaInicio.TabStop = False
            Me.dtpFechaInicio.Value = New Date(2012, 5, 18, 0, 0, 0, 0)
            CType(Me.dtpFechaInicio.GetChildAt(0), Telerik.WinControls.UI.RadDateTimePickerElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.dtpFechaInicio.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.dtpFechaInicio.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.dtpFechaInicio.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.dtpFechaInicio.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.dtpFechaInicio.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.dtpFechaInicio.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.dtpFechaInicio.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadDateTimePickerArrowButtonElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.dtpFechaInicio.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.dtpFechaInicio.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.dtpFechaInicio.GetChildAt(0).GetChildAt(1).GetChildAt(2), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text1")
            CType(Me.dtpFechaInicio.GetChildAt(0).GetChildAt(1).GetChildAt(2), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.dtpFechaInicio.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.dtpFechaInicio.GetChildAt(0).GetChildAt(1).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
            '
            'chkActivo
            '
            resources.ApplyResources(Me.chkActivo, "chkActivo")
            Me.chkActivo.CheckAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.chkActivo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.OfertaBindingSource, "Activo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.chkActivo.Name = "chkActivo"
            '
            '
            '
            Me.chkActivo.RootElement.AccessibleDescription = resources.GetString("chkActivo.RootElement.AccessibleDescription")
            Me.chkActivo.RootElement.AccessibleName = resources.GetString("chkActivo.RootElement.AccessibleName")
            Me.chkActivo.RootElement.Alignment = CType(resources.GetObject("chkActivo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.chkActivo.RootElement.AngleTransform = CType(resources.GetObject("chkActivo.RootElement.AngleTransform"), Single)
            Me.chkActivo.RootElement.FlipText = CType(resources.GetObject("chkActivo.RootElement.FlipText"), Boolean)
            Me.chkActivo.RootElement.KeyTip = resources.GetString("chkActivo.RootElement.KeyTip")
            Me.chkActivo.RootElement.Margin = CType(resources.GetObject("chkActivo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.chkActivo.RootElement.Padding = CType(resources.GetObject("chkActivo.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.chkActivo.RootElement.Text = resources.GetString("chkActivo.RootElement.Text")
            Me.chkActivo.RootElement.TextOrientation = CType(resources.GetObject("chkActivo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.chkActivo.RootElement.ToolTipText = resources.GetString("chkActivo.RootElement.ToolTipText")
            '
            'spinDuracion
            '
            resources.ApplyResources(Me.spinDuracion, "spinDuracion")
            Me.spinDuracion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OfertaBindingSource, "DiaDuracion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.spinDuracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.spinDuracion.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.spinDuracion.Name = "spinDuracion"
            '
            '
            '
            Me.spinDuracion.RootElement.AccessibleDescription = resources.GetString("spinDuracion.RootElement.AccessibleDescription")
            Me.spinDuracion.RootElement.AccessibleName = resources.GetString("spinDuracion.RootElement.AccessibleName")
            Me.spinDuracion.RootElement.Alignment = CType(resources.GetObject("spinDuracion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.spinDuracion.RootElement.AngleTransform = CType(resources.GetObject("spinDuracion.RootElement.AngleTransform"), Single)
            Me.spinDuracion.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.spinDuracion.RootElement.FlipText = CType(resources.GetObject("spinDuracion.RootElement.FlipText"), Boolean)
            Me.spinDuracion.RootElement.KeyTip = resources.GetString("spinDuracion.RootElement.KeyTip")
            Me.spinDuracion.RootElement.Margin = CType(resources.GetObject("spinDuracion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.spinDuracion.RootElement.Padding = CType(resources.GetObject("spinDuracion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.spinDuracion.RootElement.Text = resources.GetString("spinDuracion.RootElement.Text")
            Me.spinDuracion.RootElement.TextOrientation = CType(resources.GetObject("spinDuracion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.spinDuracion.RootElement.ToolTipText = resources.GetString("spinDuracion.RootElement.ToolTipText")
            Me.spinDuracion.ShowBorder = True
            Me.spinDuracion.TabStop = False
            Me.spinDuracion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.spinDuracion.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.spinDuracion.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'btnCancelar
            '
            resources.ApplyResources(Me.btnCancelar, "btnCancelar")
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
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text2")
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
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text3")
            CType(Me.btnAceptar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
            '
            'txtNumeroOferta
            '
            resources.ApplyResources(Me.txtNumeroOferta, "txtNumeroOferta")
            Me.txtNumeroOferta.AllowShowFocusCues = True
            Me.txtNumeroOferta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroOferta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OfertaBindingSource, "NumeroOferta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.txtNumeroOferta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtNumeroOferta.Name = "txtNumeroOferta"
            Me.txtNumeroOferta.ReadOnly = True
            '
            '
            '
            Me.txtNumeroOferta.RootElement.AccessibleDescription = resources.GetString("txtNumeroOferta.RootElement.AccessibleDescription")
            Me.txtNumeroOferta.RootElement.AccessibleName = resources.GetString("txtNumeroOferta.RootElement.AccessibleName")
            Me.txtNumeroOferta.RootElement.Alignment = CType(resources.GetObject("txtNumeroOferta.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtNumeroOferta.RootElement.AngleTransform = CType(resources.GetObject("txtNumeroOferta.RootElement.AngleTransform"), Single)
            Me.txtNumeroOferta.RootElement.ApplyShapeToControl = False
            Me.txtNumeroOferta.RootElement.FlipText = CType(resources.GetObject("txtNumeroOferta.RootElement.FlipText"), Boolean)
            Me.txtNumeroOferta.RootElement.KeyTip = resources.GetString("txtNumeroOferta.RootElement.KeyTip")
            Me.txtNumeroOferta.RootElement.Margin = CType(resources.GetObject("txtNumeroOferta.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtNumeroOferta.RootElement.Padding = CType(resources.GetObject("txtNumeroOferta.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtNumeroOferta.RootElement.Text = resources.GetString("txtNumeroOferta.RootElement.Text")
            Me.txtNumeroOferta.RootElement.TextOrientation = CType(resources.GetObject("txtNumeroOferta.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtNumeroOferta.RootElement.ToolTipText = resources.GetString("txtNumeroOferta.RootElement.ToolTipText")
            Me.txtNumeroOferta.TabStop = False
            Me.txtNumeroOferta.Tag = ""
            CType(Me.txtNumeroOferta.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text4")
            CType(Me.txtNumeroOferta.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNumeroOferta.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtNumeroOferta.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNumeroOferta.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtNumeroOferta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
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
            Me.CommandBarRowElement1.DisplayName = Nothing
            Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
            Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.cbstripeAccion, Me.cbstripeOrden})
            '
            'cbstripeAccion
            '
            resources.ApplyResources(Me.cbstripeAccion, "cbstripeAccion")
            Me.cbstripeAccion.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.cbstripeAccion.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.cbstripeAccion.DisplayName = "Strip Acción"
            Me.cbstripeAccion.FloatingForm = Nothing
            Me.cbstripeAccion.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbtnAgregar, Me.cbbtnModificar, Me.cbbtnEliminar})
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
            Me.cbbtnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnAgregar.Image = Global.EasyGest.My.Resources.Resources._127
            Me.cbbtnAgregar.Name = "cbbtnAgregar"
            Me.cbbtnAgregar.Shape = Nothing
            Me.cbbtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnAgregar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbbtnModificar
            '
            resources.ApplyResources(Me.cbbtnModificar, "cbbtnModificar")
            Me.cbbtnModificar.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.cbbtnModificar.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.cbbtnModificar.DisplayName = "Modificar"
            Me.cbbtnModificar.DrawText = True
            Me.cbbtnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnModificar.Image = Global.EasyGest.My.Resources.Resources._130
            Me.cbbtnModificar.Name = "cbbtnModificar"
            Me.cbbtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnModificar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbbtnEliminar
            '
            resources.ApplyResources(Me.cbbtnEliminar, "cbbtnEliminar")
            Me.cbbtnEliminar.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.cbbtnEliminar.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.cbbtnEliminar.DisplayName = "Fijar Activo"
            Me.cbbtnEliminar.DrawText = True
            Me.cbbtnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnEliminar.Image = Global.EasyGest.My.Resources.Resources._128
            Me.cbbtnEliminar.Name = "cbbtnEliminar"
            Me.cbbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnEliminar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbstripeOrden
            '
            resources.ApplyResources(Me.cbstripeOrden, "cbstripeOrden")
            Me.cbstripeOrden.DisplayName = "CommandBarStripElement1"
            Me.cbstripeOrden.FloatingForm = Nothing
            Me.cbstripeOrden.Name = "CommandBarStripElement1"
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
            Me.cbComandos.RootElement.KeyTip = resources.GetString("cbComandos.RootElement.KeyTip")
            Me.cbComandos.RootElement.Margin = CType(resources.GetObject("cbComandos.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.cbComandos.RootElement.Padding = CType(resources.GetObject("cbComandos.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.cbComandos.RootElement.Text = resources.GetString("cbComandos.RootElement.Text")
            Me.cbComandos.RootElement.TextOrientation = CType(resources.GetObject("cbComandos.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.cbComandos.RootElement.ToolTipText = resources.GetString("cbComandos.RootElement.ToolTipText")
            Me.cbComandos.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
            '
            'timValidar
            '
            '
            'frmOferta
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
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmOferta"
            Me.Opacity = 0.9R
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmOferta.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmOferta.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmOferta.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmOferta.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmOferta.RootElement.FlipText"), Boolean)
            Me.RootElement.KeyTip = resources.GetString("frmOferta.RootElement.KeyTip")
            Me.RootElement.Margin = CType(resources.GetObject("frmOferta.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmOferta.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmOferta.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmOferta.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RootElement.ToolTipText = resources.GetString("frmOferta.RootElement.ToolTipText")
            CType(RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OfertasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer1.ResumeLayout(False)
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel1.ResumeLayout(False)
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel2.ResumeLayout(False)
            Me.SplitPanel2.PerformLayout()
            CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.OfertaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadGroupBox1.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.radDescuentoFijo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadPanel6.ResumeLayout(False)
            Me.RadPanel6.PerformLayout()
            CType(Me.txtUnidadPrecio, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtUnidadBaseP, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadPanel5.ResumeLayout(False)
            Me.RadPanel5.PerformLayout()
            CType(Me.txtUnidadDesc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtUnidadBaseD, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadPanel4.ResumeLayout(False)
            Me.RadPanel4.PerformLayout()
            CType(Me.txtUnidadGratis, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtUnidadBase, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadPanel2.ResumeLayout(False)
            Me.RadPanel2.PerformLayout()
            CType(Me.txtDescPorc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radUnidadGratis, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radUnidadPrecio, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radUnidadDescuento, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radDescuentoPorcentual, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radPrecioEspecial, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadPanel1.ResumeLayout(False)
            Me.RadPanel1.PerformLayout()
            CType(Me.txtPrecioEspecial, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadPanel3.ResumeLayout(False)
            Me.RadPanel3.PerformLayout()
            CType(Me.txtDescFijo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkActivo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinDuracion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNumeroOferta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents SplitPanel1 As Telerik.WinControls.UI.SplitPanel
        Dim WithEvents gridDatos As Telerik.WinControls.UI.RadGridView
        Friend WithEvents bgwCarga As System.ComponentModel.BackgroundWorker
        Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
        Friend WithEvents cbstripeAccion As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents cbbtnAgregar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnModificar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnEliminar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbComandos As Telerik.WinControls.UI.RadCommandBar
        Private WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
        Friend WithEvents SplitPanel2 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents txtNumeroOferta As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents OfertaBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents cbstripeOrden As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents timValidar As System.Windows.Forms.Timer
        Friend WithEvents OfertasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents spinDuracion As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents chkActivo As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents dtpFechaInicio As Telerik.WinControls.UI.RadDateTimePicker
        Friend WithEvents txtPrecioEspecial As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents radPrecioEspecial As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents radDescuentoPorcentual As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents RadPanel6 As Telerik.WinControls.UI.RadPanel
        Friend WithEvents txtUnidadPrecio As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents txtUnidadBaseP As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
        Friend WithEvents txtUnidadDesc As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents txtUnidadBaseD As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
        Friend WithEvents txtUnidadGratis As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents txtUnidadBase As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
        Friend WithEvents txtDescPorc As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents radUnidadGratis As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents radUnidadPrecio As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents radUnidadDescuento As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
        Friend WithEvents txtDescFijo As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents txtDescripcion As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents radDescuentoFijo As Telerik.WinControls.UI.RadRadioButton
        Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    End Class

End Namespace

