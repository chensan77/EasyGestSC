Imports EasyGest.Presentacion.Formulario
  
Namespace Presentacion.Formulario.Dialogo
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmCierre
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCierre))
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel3 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel4 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel5 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel6 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel7 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel8 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel9 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel10 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel11 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel12 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel13 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel14 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel15 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel16 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel17 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel18 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel19 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel20 As Telerik.WinControls.UI.RadLabel
            Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Me.gridDatos = New Telerik.WinControls.UI.RadGridView()
            Me.ApuntesDiarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.tlpConteo = New System.Windows.Forms.TableLayoutPanel()
            Me.BindingSourceDiario = New System.Windows.Forms.BindingSource(Me.components)
            Me.lblFechaApertura = New Telerik.WinControls.UI.RadLabel()
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.pnlLogin = New Telerik.WinControls.UI.RadPanel()
            Me.toggleVerApuntes = New Telerik.WinControls.UI.RadToggleButton()
            Me.toggleVerConteo = New Telerik.WinControls.UI.RadToggleButton()
            Me.txtTotalVenta = New Telerik.WinControls.UI.RadTextBox()
            Me.txtDeposito = New Telerik.WinControls.UI.RadTextBox()
            Me.txtPuesto = New Telerik.WinControls.UI.RadTextBox()
            Me.txtUsuario = New Telerik.WinControls.UI.RadTextBox()
            Me.spinConteoCaja = New Telerik.WinControls.UI.RadSpinEditor()
            Me.txtIncidencia = New Telerik.WinControls.UI.RadTextBox()
            Me.lblFechaCierre = New Telerik.WinControls.UI.RadLabel()
            Me.btnContarCaja = New Telerik.WinControls.UI.RadButton()
            Me.pnlApuntes = New Telerik.WinControls.UI.RadPanel()
            Me.pnlConteo = New Telerik.WinControls.UI.RadPanel()
            Me.btnLimpiar = New Telerik.WinControls.UI.RadButton()
            Me.pnlContenedor = New Telerik.WinControls.UI.RadPanel()
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            RadLabel3 = New Telerik.WinControls.UI.RadLabel()
            RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            RadLabel5 = New Telerik.WinControls.UI.RadLabel()
            RadLabel6 = New Telerik.WinControls.UI.RadLabel()
            RadLabel7 = New Telerik.WinControls.UI.RadLabel()
            RadLabel8 = New Telerik.WinControls.UI.RadLabel()
            RadLabel9 = New Telerik.WinControls.UI.RadLabel()
            RadLabel10 = New Telerik.WinControls.UI.RadLabel()
            RadLabel11 = New Telerik.WinControls.UI.RadLabel()
            RadLabel12 = New Telerik.WinControls.UI.RadLabel()
            RadLabel13 = New Telerik.WinControls.UI.RadLabel()
            RadLabel14 = New Telerik.WinControls.UI.RadLabel()
            RadLabel15 = New Telerik.WinControls.UI.RadLabel()
            RadLabel16 = New Telerik.WinControls.UI.RadLabel()
            RadLabel17 = New Telerik.WinControls.UI.RadLabel()
            RadLabel18 = New Telerik.WinControls.UI.RadLabel()
            RadLabel19 = New Telerik.WinControls.UI.RadLabel()
            RadLabel20 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ApuntesDiarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tlpConteo.SuspendLayout()
            CType(Me.BindingSourceDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblFechaApertura, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlLogin, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlLogin.SuspendLayout()
            CType(Me.toggleVerApuntes, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toggleVerConteo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtTotalVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPuesto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinConteoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtIncidencia, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblFechaCierre, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnContarCaja, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlApuntes, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlApuntes.SuspendLayout()
            CType(Me.pnlConteo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlConteo.SuspendLayout()
            CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlContenedor.SuspendLayout()
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
            RadLabel15.RootElement.KeyTip = resources.GetString("RadLabel15.RootElement.KeyTip")
            RadLabel15.RootElement.Margin = CType(resources.GetObject("RadLabel15.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel15.RootElement.Padding = CType(resources.GetObject("RadLabel15.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel15.RootElement.Text = resources.GetString("RadLabel15.RootElement.Text")
            RadLabel15.RootElement.TextOrientation = CType(resources.GetObject("RadLabel15.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel15.RootElement.ToolTipText = resources.GetString("RadLabel15.RootElement.ToolTipText")
            '
            'RadLabel16
            '
            resources.ApplyResources(RadLabel16, "RadLabel16")
            RadLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel16.Name = "RadLabel16"
            '
            '
            '
            RadLabel16.RootElement.AccessibleDescription = resources.GetString("RadLabel16.RootElement.AccessibleDescription")
            RadLabel16.RootElement.AccessibleName = resources.GetString("RadLabel16.RootElement.AccessibleName")
            RadLabel16.RootElement.Alignment = CType(resources.GetObject("RadLabel16.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel16.RootElement.AngleTransform = CType(resources.GetObject("RadLabel16.RootElement.AngleTransform"), Single)
            RadLabel16.RootElement.FlipText = CType(resources.GetObject("RadLabel16.RootElement.FlipText"), Boolean)
            RadLabel16.RootElement.KeyTip = resources.GetString("RadLabel16.RootElement.KeyTip")
            RadLabel16.RootElement.Margin = CType(resources.GetObject("RadLabel16.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel16.RootElement.Padding = CType(resources.GetObject("RadLabel16.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel16.RootElement.Text = resources.GetString("RadLabel16.RootElement.Text")
            RadLabel16.RootElement.TextOrientation = CType(resources.GetObject("RadLabel16.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel16.RootElement.ToolTipText = resources.GetString("RadLabel16.RootElement.ToolTipText")
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
            RadLabel17.RootElement.KeyTip = resources.GetString("RadLabel17.RootElement.KeyTip")
            RadLabel17.RootElement.Margin = CType(resources.GetObject("RadLabel17.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel17.RootElement.Padding = CType(resources.GetObject("RadLabel17.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel17.RootElement.Text = resources.GetString("RadLabel17.RootElement.Text")
            RadLabel17.RootElement.TextOrientation = CType(resources.GetObject("RadLabel17.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel17.RootElement.ToolTipText = resources.GetString("RadLabel17.RootElement.ToolTipText")
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
            RadLabel18.RootElement.KeyTip = resources.GetString("RadLabel18.RootElement.KeyTip")
            RadLabel18.RootElement.Margin = CType(resources.GetObject("RadLabel18.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel18.RootElement.Padding = CType(resources.GetObject("RadLabel18.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel18.RootElement.Text = resources.GetString("RadLabel18.RootElement.Text")
            RadLabel18.RootElement.TextOrientation = CType(resources.GetObject("RadLabel18.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel18.RootElement.ToolTipText = resources.GetString("RadLabel18.RootElement.ToolTipText")
            '
            'RadLabel19
            '
            resources.ApplyResources(RadLabel19, "RadLabel19")
            RadLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel19.Name = "RadLabel19"
            '
            '
            '
            RadLabel19.RootElement.AccessibleDescription = resources.GetString("RadLabel19.RootElement.AccessibleDescription")
            RadLabel19.RootElement.AccessibleName = resources.GetString("RadLabel19.RootElement.AccessibleName")
            RadLabel19.RootElement.Alignment = CType(resources.GetObject("RadLabel19.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel19.RootElement.AngleTransform = CType(resources.GetObject("RadLabel19.RootElement.AngleTransform"), Single)
            RadLabel19.RootElement.FlipText = CType(resources.GetObject("RadLabel19.RootElement.FlipText"), Boolean)
            RadLabel19.RootElement.KeyTip = resources.GetString("RadLabel19.RootElement.KeyTip")
            RadLabel19.RootElement.Margin = CType(resources.GetObject("RadLabel19.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel19.RootElement.Padding = CType(resources.GetObject("RadLabel19.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel19.RootElement.Text = resources.GetString("RadLabel19.RootElement.Text")
            RadLabel19.RootElement.TextOrientation = CType(resources.GetObject("RadLabel19.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel19.RootElement.ToolTipText = resources.GetString("RadLabel19.RootElement.ToolTipText")
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
            RadLabel20.RootElement.KeyTip = resources.GetString("RadLabel20.RootElement.KeyTip")
            RadLabel20.RootElement.Margin = CType(resources.GetObject("RadLabel20.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel20.RootElement.Padding = CType(resources.GetObject("RadLabel20.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel20.RootElement.Text = resources.GetString("RadLabel20.RootElement.Text")
            RadLabel20.RootElement.TextOrientation = CType(resources.GetObject("RadLabel20.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel20.RootElement.ToolTipText = resources.GetString("RadLabel20.RootElement.ToolTipText")
            '
            'gridDatos
            '
            resources.ApplyResources(Me.gridDatos, "gridDatos")
            Me.gridDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDatos.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridDatos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            '
            'gridDatos
            '
            Me.gridDatos.MasterTemplate.AllowAddNewRow = False
            Me.gridDatos.MasterTemplate.AllowColumnChooser = False
            Me.gridDatos.MasterTemplate.AllowDeleteRow = False
            Me.gridDatos.MasterTemplate.AllowDragToGroup = False
            Me.gridDatos.MasterTemplate.AllowEditRow = False
            resources.ApplyResources(Me.gridDatos.MasterTemplate, "gridDatos")
            GridViewDecimalColumn1.DataType = GetType(Long)
            GridViewDecimalColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn1, "GridViewDecimalColumn1")
            GridViewDecimalColumn1.FieldName = "idApunte"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.IsVisible = False
            GridViewDecimalColumn1.Name = "idApunte"
            GridViewDecimalColumn2.DataType = GetType(Long)
            GridViewDecimalColumn2.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn2, "GridViewDecimalColumn2")
            GridViewDecimalColumn2.FieldName = "idDiario"
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.IsVisible = False
            GridViewDecimalColumn2.Name = "idDiario"
            GridViewTextBoxColumn1.AllowGroup = False
            GridViewTextBoxColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn1, "GridViewTextBoxColumn1")
            GridViewTextBoxColumn1.FieldName = "Concepto"
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.Name = "Concepto"
            GridViewTextBoxColumn1.VisibleInColumnChooser = False
            GridViewTextBoxColumn1.Width = 168
            GridViewDecimalColumn3.AllowGroup = False
            GridViewDecimalColumn3.DataType = GetType(Single)
            GridViewDecimalColumn3.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn3, "GridViewDecimalColumn3")
            GridViewDecimalColumn3.FieldName = "Importe"
            GridViewDecimalColumn3.IsAutoGenerated = True
            GridViewDecimalColumn3.Name = "Importe"
            GridViewDecimalColumn3.VisibleInColumnChooser = False
            GridViewDecimalColumn3.Width = 85
            GridViewCheckBoxColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewCheckBoxColumn1, "GridViewCheckBoxColumn1")
            GridViewCheckBoxColumn1.FieldName = "EsEntrada"
            GridViewCheckBoxColumn1.IsAutoGenerated = True
            GridViewCheckBoxColumn1.IsVisible = False
            GridViewCheckBoxColumn1.MinWidth = 20
            GridViewCheckBoxColumn1.Name = "EsEntrada"
            GridViewCheckBoxColumn1.Width = 73
            GridViewDateTimeColumn1.AllowGroup = False
            resources.ApplyResources(GridViewDateTimeColumn1, "GridViewDateTimeColumn1")
            GridViewDateTimeColumn1.EnableExpressionEditor = False
            GridViewDateTimeColumn1.FieldName = "FApunte"
            GridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
            GridViewDateTimeColumn1.IsAutoGenerated = True
            GridViewDateTimeColumn1.Name = "FApunte"
            GridViewDateTimeColumn1.VisibleInColumnChooser = False
            GridViewDateTimeColumn1.Width = 125
            Me.gridDatos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewDecimalColumn2, GridViewTextBoxColumn1, GridViewDecimalColumn3, GridViewCheckBoxColumn1, GridViewDateTimeColumn1})
            Me.gridDatos.MasterTemplate.DataSource = Me.ApuntesDiarioBindingSource
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
            '
            'ApuntesDiarioBindingSource
            '
            Me.ApuntesDiarioBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.ApuntesDiario)
            '
            'tlpConteo
            '
            resources.ApplyResources(Me.tlpConteo, "tlpConteo")
            Me.tlpConteo.Controls.Add(RadLabel7, 0, 0)
            Me.tlpConteo.Controls.Add(RadLabel8, 0, 1)
            Me.tlpConteo.Controls.Add(RadLabel9, 0, 2)
            Me.tlpConteo.Controls.Add(RadLabel10, 0, 3)
            Me.tlpConteo.Controls.Add(RadLabel11, 0, 4)
            Me.tlpConteo.Controls.Add(RadLabel12, 0, 5)
            Me.tlpConteo.Controls.Add(RadLabel13, 0, 6)
            Me.tlpConteo.Controls.Add(RadLabel14, 2, 0)
            Me.tlpConteo.Controls.Add(RadLabel15, 2, 1)
            Me.tlpConteo.Controls.Add(RadLabel16, 2, 2)
            Me.tlpConteo.Controls.Add(RadLabel17, 2, 3)
            Me.tlpConteo.Controls.Add(RadLabel18, 2, 4)
            Me.tlpConteo.Controls.Add(RadLabel19, 2, 5)
            Me.tlpConteo.Controls.Add(RadLabel20, 2, 6)
            Me.tlpConteo.Name = "tlpConteo"
            '
            'BindingSourceDiario
            '
            Me.BindingSourceDiario.DataSource = GetType(EasyGestControllers.Data.Entity.Diarios)
            '
            'lblFechaApertura
            '
            resources.ApplyResources(Me.lblFechaApertura, "lblFechaApertura")
            Me.lblFechaApertura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceDiario, "Apertura", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "g"))
            Me.lblFechaApertura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.lblFechaApertura.Name = "lblFechaApertura"
            '
            '
            '
            Me.lblFechaApertura.RootElement.AccessibleDescription = resources.GetString("lblFechaApertura.RootElement.AccessibleDescription")
            Me.lblFechaApertura.RootElement.AccessibleName = resources.GetString("lblFechaApertura.RootElement.AccessibleName")
            Me.lblFechaApertura.RootElement.Alignment = CType(resources.GetObject("lblFechaApertura.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lblFechaApertura.RootElement.AngleTransform = CType(resources.GetObject("lblFechaApertura.RootElement.AngleTransform"), Single)
            Me.lblFechaApertura.RootElement.FlipText = CType(resources.GetObject("lblFechaApertura.RootElement.FlipText"), Boolean)
            Me.lblFechaApertura.RootElement.KeyTip = resources.GetString("lblFechaApertura.RootElement.KeyTip")
            Me.lblFechaApertura.RootElement.Margin = CType(resources.GetObject("lblFechaApertura.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lblFechaApertura.RootElement.Padding = CType(resources.GetObject("lblFechaApertura.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.lblFechaApertura.RootElement.Text = resources.GetString("lblFechaApertura.RootElement.Text")
            Me.lblFechaApertura.RootElement.TextOrientation = CType(resources.GetObject("lblFechaApertura.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.lblFechaApertura.RootElement.ToolTipText = resources.GetString("lblFechaApertura.RootElement.ToolTipText")
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
            'pnlLogin
            '
            resources.ApplyResources(Me.pnlLogin, "pnlLogin")
            Me.pnlLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.pnlLogin.Controls.Add(Me.toggleVerApuntes)
            Me.pnlLogin.Controls.Add(Me.toggleVerConteo)
            Me.pnlLogin.Controls.Add(RadLabel4)
            Me.pnlLogin.Controls.Add(Me.txtTotalVenta)
            Me.pnlLogin.Controls.Add(Me.txtDeposito)
            Me.pnlLogin.Controls.Add(Me.txtPuesto)
            Me.pnlLogin.Controls.Add(Me.txtUsuario)
            Me.pnlLogin.Controls.Add(Me.spinConteoCaja)
            Me.pnlLogin.Controls.Add(Me.txtIncidencia)
            Me.pnlLogin.Controls.Add(RadLabel2)
            Me.pnlLogin.Controls.Add(Me.lblFechaCierre)
            Me.pnlLogin.Controls.Add(Me.lblFechaApertura)
            Me.pnlLogin.Controls.Add(RadLabel3)
            Me.pnlLogin.Controls.Add(RadLabel6)
            Me.pnlLogin.Controls.Add(RadLabel5)
            Me.pnlLogin.Controls.Add(RadLabel1)
            Me.pnlLogin.Controls.Add(Me.btnAceptar)
            Me.pnlLogin.Controls.Add(Me.btnCancelar)
            Me.pnlLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.pnlLogin.Name = "pnlLogin"
            '
            '
            '
            Me.pnlLogin.RootElement.AccessibleDescription = resources.GetString("pnlLogin.RootElement.AccessibleDescription")
            Me.pnlLogin.RootElement.AccessibleName = resources.GetString("pnlLogin.RootElement.AccessibleName")
            Me.pnlLogin.RootElement.Alignment = CType(resources.GetObject("pnlLogin.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.pnlLogin.RootElement.AngleTransform = CType(resources.GetObject("pnlLogin.RootElement.AngleTransform"), Single)
            Me.pnlLogin.RootElement.FlipText = CType(resources.GetObject("pnlLogin.RootElement.FlipText"), Boolean)
            Me.pnlLogin.RootElement.KeyTip = resources.GetString("pnlLogin.RootElement.KeyTip")
            Me.pnlLogin.RootElement.Margin = CType(resources.GetObject("pnlLogin.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.pnlLogin.RootElement.Padding = CType(resources.GetObject("pnlLogin.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.pnlLogin.RootElement.Text = resources.GetString("pnlLogin.RootElement.Text")
            Me.pnlLogin.RootElement.TextOrientation = CType(resources.GetObject("pnlLogin.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.pnlLogin.RootElement.ToolTipText = resources.GetString("pnlLogin.RootElement.ToolTipText")
            Me.pnlLogin.TextAlignment = System.Drawing.ContentAlignment.TopCenter
            CType(Me.pnlLogin.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = resources.GetString("resource.Text7")
            CType(Me.pnlLogin.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
            CType(Me.pnlLogin.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            CType(Me.pnlLogin.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
            '
            'toggleVerApuntes
            '
            resources.ApplyResources(Me.toggleVerApuntes, "toggleVerApuntes")
            Me.toggleVerApuntes.Image = Global.EasyGest.My.Resources.Resources.book_next
            Me.toggleVerApuntes.Name = "toggleVerApuntes"
            '
            '
            '
            Me.toggleVerApuntes.RootElement.AccessibleDescription = resources.GetString("toggleVerApuntes.RootElement.AccessibleDescription")
            Me.toggleVerApuntes.RootElement.AccessibleName = resources.GetString("toggleVerApuntes.RootElement.AccessibleName")
            Me.toggleVerApuntes.RootElement.Alignment = CType(resources.GetObject("toggleVerApuntes.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.toggleVerApuntes.RootElement.AngleTransform = CType(resources.GetObject("toggleVerApuntes.RootElement.AngleTransform"), Single)
            Me.toggleVerApuntes.RootElement.FlipText = CType(resources.GetObject("toggleVerApuntes.RootElement.FlipText"), Boolean)
            Me.toggleVerApuntes.RootElement.KeyTip = resources.GetString("toggleVerApuntes.RootElement.KeyTip")
            Me.toggleVerApuntes.RootElement.Margin = CType(resources.GetObject("toggleVerApuntes.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.toggleVerApuntes.RootElement.Padding = CType(resources.GetObject("toggleVerApuntes.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.toggleVerApuntes.RootElement.Text = resources.GetString("toggleVerApuntes.RootElement.Text")
            Me.toggleVerApuntes.RootElement.TextOrientation = CType(resources.GetObject("toggleVerApuntes.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.toggleVerApuntes.RootElement.ToolTipText = resources.GetString("toggleVerApuntes.RootElement.ToolTipText")
            '
            'toggleVerConteo
            '
            resources.ApplyResources(Me.toggleVerConteo, "toggleVerConteo")
            Me.toggleVerConteo.Image = Global.EasyGest.My.Resources.Resources.money_euro
            Me.toggleVerConteo.Name = "toggleVerConteo"
            '
            '
            '
            Me.toggleVerConteo.RootElement.AccessibleDescription = resources.GetString("toggleVerConteo.RootElement.AccessibleDescription")
            Me.toggleVerConteo.RootElement.AccessibleName = resources.GetString("toggleVerConteo.RootElement.AccessibleName")
            Me.toggleVerConteo.RootElement.Alignment = CType(resources.GetObject("toggleVerConteo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.toggleVerConteo.RootElement.AngleTransform = CType(resources.GetObject("toggleVerConteo.RootElement.AngleTransform"), Single)
            Me.toggleVerConteo.RootElement.FlipText = CType(resources.GetObject("toggleVerConteo.RootElement.FlipText"), Boolean)
            Me.toggleVerConteo.RootElement.KeyTip = resources.GetString("toggleVerConteo.RootElement.KeyTip")
            Me.toggleVerConteo.RootElement.Margin = CType(resources.GetObject("toggleVerConteo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.toggleVerConteo.RootElement.Padding = CType(resources.GetObject("toggleVerConteo.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.toggleVerConteo.RootElement.Text = resources.GetString("toggleVerConteo.RootElement.Text")
            Me.toggleVerConteo.RootElement.TextOrientation = CType(resources.GetObject("toggleVerConteo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.toggleVerConteo.RootElement.ToolTipText = resources.GetString("toggleVerConteo.RootElement.ToolTipText")
            '
            'txtTotalVenta
            '
            resources.ApplyResources(Me.txtTotalVenta, "txtTotalVenta")
            Me.txtTotalVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtTotalVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceDiario, "CierreSupuesto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
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
            Me.txtTotalVenta.RootElement.FlipText = CType(resources.GetObject("txtTotalVenta.RootElement.FlipText"), Boolean)
            Me.txtTotalVenta.RootElement.KeyTip = resources.GetString("txtTotalVenta.RootElement.KeyTip")
            Me.txtTotalVenta.RootElement.Margin = CType(resources.GetObject("txtTotalVenta.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtTotalVenta.RootElement.Padding = CType(resources.GetObject("txtTotalVenta.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtTotalVenta.RootElement.Text = resources.GetString("txtTotalVenta.RootElement.Text")
            Me.txtTotalVenta.RootElement.TextOrientation = CType(resources.GetObject("txtTotalVenta.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtTotalVenta.RootElement.ToolTipText = resources.GetString("txtTotalVenta.RootElement.ToolTipText")
            Me.txtTotalVenta.TabStop = False
            Me.txtTotalVenta.Tag = ""
            CType(Me.txtTotalVenta.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text2")
            CType(Me.txtTotalVenta.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtTotalVenta.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtTotalVenta.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtTotalVenta.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtTotalVenta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'txtDeposito
            '
            resources.ApplyResources(Me.txtDeposito, "txtDeposito")
            Me.txtDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtDeposito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceDiario, "DepositoInicio", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
            Me.txtDeposito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtDeposito.Name = "txtDeposito"
            Me.txtDeposito.ReadOnly = True
            '
            '
            '
            Me.txtDeposito.RootElement.AccessibleDescription = resources.GetString("txtDeposito.RootElement.AccessibleDescription")
            Me.txtDeposito.RootElement.AccessibleName = resources.GetString("txtDeposito.RootElement.AccessibleName")
            Me.txtDeposito.RootElement.Alignment = CType(resources.GetObject("txtDeposito.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtDeposito.RootElement.AngleTransform = CType(resources.GetObject("txtDeposito.RootElement.AngleTransform"), Single)
            Me.txtDeposito.RootElement.FlipText = CType(resources.GetObject("txtDeposito.RootElement.FlipText"), Boolean)
            Me.txtDeposito.RootElement.KeyTip = resources.GetString("txtDeposito.RootElement.KeyTip")
            Me.txtDeposito.RootElement.Margin = CType(resources.GetObject("txtDeposito.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtDeposito.RootElement.Padding = CType(resources.GetObject("txtDeposito.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtDeposito.RootElement.Text = resources.GetString("txtDeposito.RootElement.Text")
            Me.txtDeposito.RootElement.TextOrientation = CType(resources.GetObject("txtDeposito.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtDeposito.RootElement.ToolTipText = resources.GetString("txtDeposito.RootElement.ToolTipText")
            Me.txtDeposito.TabStop = False
            Me.txtDeposito.Tag = ""
            CType(Me.txtDeposito.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text3")
            CType(Me.txtDeposito.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtDeposito.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtDeposito.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtDeposito.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtDeposito.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'txtPuesto
            '
            resources.ApplyResources(Me.txtPuesto, "txtPuesto")
            Me.txtPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtPuesto.Name = "txtPuesto"
            Me.txtPuesto.ReadOnly = True
            '
            '
            '
            Me.txtPuesto.RootElement.AccessibleDescription = resources.GetString("txtPuesto.RootElement.AccessibleDescription")
            Me.txtPuesto.RootElement.AccessibleName = resources.GetString("txtPuesto.RootElement.AccessibleName")
            Me.txtPuesto.RootElement.Alignment = CType(resources.GetObject("txtPuesto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtPuesto.RootElement.AngleTransform = CType(resources.GetObject("txtPuesto.RootElement.AngleTransform"), Single)
            Me.txtPuesto.RootElement.FlipText = CType(resources.GetObject("txtPuesto.RootElement.FlipText"), Boolean)
            Me.txtPuesto.RootElement.KeyTip = resources.GetString("txtPuesto.RootElement.KeyTip")
            Me.txtPuesto.RootElement.Margin = CType(resources.GetObject("txtPuesto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtPuesto.RootElement.Padding = CType(resources.GetObject("txtPuesto.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtPuesto.RootElement.Text = resources.GetString("txtPuesto.RootElement.Text")
            Me.txtPuesto.RootElement.TextOrientation = CType(resources.GetObject("txtPuesto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtPuesto.RootElement.ToolTipText = resources.GetString("txtPuesto.RootElement.ToolTipText")
            Me.txtPuesto.TabStop = False
            Me.txtPuesto.Tag = ""
            CType(Me.txtPuesto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text4")
            CType(Me.txtPuesto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtPuesto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtPuesto.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtPuesto.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtPuesto.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'txtUsuario
            '
            resources.ApplyResources(Me.txtUsuario, "txtUsuario")
            Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.ReadOnly = True
            '
            '
            '
            Me.txtUsuario.RootElement.AccessibleDescription = resources.GetString("txtUsuario.RootElement.AccessibleDescription")
            Me.txtUsuario.RootElement.AccessibleName = resources.GetString("txtUsuario.RootElement.AccessibleName")
            Me.txtUsuario.RootElement.Alignment = CType(resources.GetObject("txtUsuario.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtUsuario.RootElement.AngleTransform = CType(resources.GetObject("txtUsuario.RootElement.AngleTransform"), Single)
            Me.txtUsuario.RootElement.FlipText = CType(resources.GetObject("txtUsuario.RootElement.FlipText"), Boolean)
            Me.txtUsuario.RootElement.KeyTip = resources.GetString("txtUsuario.RootElement.KeyTip")
            Me.txtUsuario.RootElement.Margin = CType(resources.GetObject("txtUsuario.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtUsuario.RootElement.Padding = CType(resources.GetObject("txtUsuario.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtUsuario.RootElement.Text = resources.GetString("txtUsuario.RootElement.Text")
            Me.txtUsuario.RootElement.TextOrientation = CType(resources.GetObject("txtUsuario.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtUsuario.RootElement.ToolTipText = resources.GetString("txtUsuario.RootElement.ToolTipText")
            Me.txtUsuario.TabStop = False
            Me.txtUsuario.Tag = ""
            CType(Me.txtUsuario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text5")
            CType(Me.txtUsuario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtUsuario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'spinConteoCaja
            '
            resources.ApplyResources(Me.spinConteoCaja, "spinConteoCaja")
            Me.spinConteoCaja.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSourceDiario, "CierreReal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
            Me.spinConteoCaja.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.spinConteoCaja.Name = "spinConteoCaja"
            '
            '
            '
            Me.spinConteoCaja.RootElement.AccessibleDescription = resources.GetString("spinConteoCaja.RootElement.AccessibleDescription")
            Me.spinConteoCaja.RootElement.AccessibleName = resources.GetString("spinConteoCaja.RootElement.AccessibleName")
            Me.spinConteoCaja.RootElement.Alignment = CType(resources.GetObject("spinConteoCaja.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.spinConteoCaja.RootElement.AngleTransform = CType(resources.GetObject("spinConteoCaja.RootElement.AngleTransform"), Single)
            Me.spinConteoCaja.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.spinConteoCaja.RootElement.FlipText = CType(resources.GetObject("spinConteoCaja.RootElement.FlipText"), Boolean)
            Me.spinConteoCaja.RootElement.KeyTip = resources.GetString("spinConteoCaja.RootElement.KeyTip")
            Me.spinConteoCaja.RootElement.Margin = CType(resources.GetObject("spinConteoCaja.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.spinConteoCaja.RootElement.Padding = CType(resources.GetObject("spinConteoCaja.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.spinConteoCaja.RootElement.Text = resources.GetString("spinConteoCaja.RootElement.Text")
            Me.spinConteoCaja.RootElement.TextOrientation = CType(resources.GetObject("spinConteoCaja.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.spinConteoCaja.RootElement.ToolTipText = resources.GetString("spinConteoCaja.RootElement.ToolTipText")
            Me.spinConteoCaja.ShowUpDownButtons = False
            Me.spinConteoCaja.TabStop = False
            Me.spinConteoCaja.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.spinConteoCaja.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'txtIncidencia
            '
            resources.ApplyResources(Me.txtIncidencia, "txtIncidencia")
            Me.txtIncidencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceDiario, "Incidencia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.txtIncidencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtIncidencia.Multiline = True
            Me.txtIncidencia.Name = "txtIncidencia"
            '
            '
            '
            Me.txtIncidencia.RootElement.AccessibleDescription = resources.GetString("txtIncidencia.RootElement.AccessibleDescription")
            Me.txtIncidencia.RootElement.AccessibleName = resources.GetString("txtIncidencia.RootElement.AccessibleName")
            Me.txtIncidencia.RootElement.Alignment = CType(resources.GetObject("txtIncidencia.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtIncidencia.RootElement.AngleTransform = CType(resources.GetObject("txtIncidencia.RootElement.AngleTransform"), Single)
            Me.txtIncidencia.RootElement.FlipText = CType(resources.GetObject("txtIncidencia.RootElement.FlipText"), Boolean)
            Me.txtIncidencia.RootElement.KeyTip = resources.GetString("txtIncidencia.RootElement.KeyTip")
            Me.txtIncidencia.RootElement.Margin = CType(resources.GetObject("txtIncidencia.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtIncidencia.RootElement.Padding = CType(resources.GetObject("txtIncidencia.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtIncidencia.RootElement.Text = resources.GetString("txtIncidencia.RootElement.Text")
            Me.txtIncidencia.RootElement.TextOrientation = CType(resources.GetObject("txtIncidencia.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtIncidencia.RootElement.ToolTipText = resources.GetString("txtIncidencia.RootElement.ToolTipText")
            Me.txtIncidencia.Tag = ""
            CType(Me.txtIncidencia.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text6")
            CType(Me.txtIncidencia.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtIncidencia.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtIncidencia.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtIncidencia.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
            CType(Me.txtIncidencia.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtIncidencia.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
            CType(Me.txtIncidencia.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'lblFechaCierre
            '
            resources.ApplyResources(Me.lblFechaCierre, "lblFechaCierre")
            Me.lblFechaCierre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceDiario, "Cierre", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "g"))
            Me.lblFechaCierre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.lblFechaCierre.Name = "lblFechaCierre"
            '
            '
            '
            Me.lblFechaCierre.RootElement.AccessibleDescription = resources.GetString("lblFechaCierre.RootElement.AccessibleDescription")
            Me.lblFechaCierre.RootElement.AccessibleName = resources.GetString("lblFechaCierre.RootElement.AccessibleName")
            Me.lblFechaCierre.RootElement.Alignment = CType(resources.GetObject("lblFechaCierre.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lblFechaCierre.RootElement.AngleTransform = CType(resources.GetObject("lblFechaCierre.RootElement.AngleTransform"), Single)
            Me.lblFechaCierre.RootElement.FlipText = CType(resources.GetObject("lblFechaCierre.RootElement.FlipText"), Boolean)
            Me.lblFechaCierre.RootElement.KeyTip = resources.GetString("lblFechaCierre.RootElement.KeyTip")
            Me.lblFechaCierre.RootElement.Margin = CType(resources.GetObject("lblFechaCierre.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lblFechaCierre.RootElement.Padding = CType(resources.GetObject("lblFechaCierre.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.lblFechaCierre.RootElement.Text = resources.GetString("lblFechaCierre.RootElement.Text")
            Me.lblFechaCierre.RootElement.TextOrientation = CType(resources.GetObject("lblFechaCierre.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.lblFechaCierre.RootElement.ToolTipText = resources.GetString("lblFechaCierre.RootElement.ToolTipText")
            '
            'btnContarCaja
            '
            resources.ApplyResources(Me.btnContarCaja, "btnContarCaja")
            Me.btnContarCaja.Image = Global.EasyGest.My.Resources.Resources.calculator
            Me.btnContarCaja.Name = "btnContarCaja"
            '
            '
            '
            Me.btnContarCaja.RootElement.AccessibleDescription = resources.GetString("btnContarCaja.RootElement.AccessibleDescription")
            Me.btnContarCaja.RootElement.AccessibleName = resources.GetString("btnContarCaja.RootElement.AccessibleName")
            Me.btnContarCaja.RootElement.Alignment = CType(resources.GetObject("btnContarCaja.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnContarCaja.RootElement.AngleTransform = CType(resources.GetObject("btnContarCaja.RootElement.AngleTransform"), Single)
            Me.btnContarCaja.RootElement.FlipText = CType(resources.GetObject("btnContarCaja.RootElement.FlipText"), Boolean)
            Me.btnContarCaja.RootElement.KeyTip = resources.GetString("btnContarCaja.RootElement.KeyTip")
            Me.btnContarCaja.RootElement.Margin = CType(resources.GetObject("btnContarCaja.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnContarCaja.RootElement.Padding = CType(resources.GetObject("btnContarCaja.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnContarCaja.RootElement.Text = resources.GetString("btnContarCaja.RootElement.Text")
            Me.btnContarCaja.RootElement.TextOrientation = CType(resources.GetObject("btnContarCaja.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.btnContarCaja.RootElement.ToolTipText = resources.GetString("btnContarCaja.RootElement.ToolTipText")
            '
            'pnlApuntes
            '
            resources.ApplyResources(Me.pnlApuntes, "pnlApuntes")
            Me.pnlApuntes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.pnlApuntes.Controls.Add(Me.gridDatos)
            Me.pnlApuntes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.pnlApuntes.Name = "pnlApuntes"
            '
            '
            '
            Me.pnlApuntes.RootElement.AccessibleDescription = resources.GetString("pnlApuntes.RootElement.AccessibleDescription")
            Me.pnlApuntes.RootElement.AccessibleName = resources.GetString("pnlApuntes.RootElement.AccessibleName")
            Me.pnlApuntes.RootElement.Alignment = CType(resources.GetObject("pnlApuntes.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.pnlApuntes.RootElement.AngleTransform = CType(resources.GetObject("pnlApuntes.RootElement.AngleTransform"), Single)
            Me.pnlApuntes.RootElement.FlipText = CType(resources.GetObject("pnlApuntes.RootElement.FlipText"), Boolean)
            Me.pnlApuntes.RootElement.KeyTip = resources.GetString("pnlApuntes.RootElement.KeyTip")
            Me.pnlApuntes.RootElement.Margin = CType(resources.GetObject("pnlApuntes.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.pnlApuntes.RootElement.Padding = CType(resources.GetObject("pnlApuntes.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.pnlApuntes.RootElement.Text = resources.GetString("pnlApuntes.RootElement.Text")
            Me.pnlApuntes.RootElement.TextOrientation = CType(resources.GetObject("pnlApuntes.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.pnlApuntes.RootElement.ToolTipText = resources.GetString("pnlApuntes.RootElement.ToolTipText")
            Me.pnlApuntes.TextAlignment = System.Drawing.ContentAlignment.TopCenter
            CType(Me.pnlApuntes.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = resources.GetString("resource.Text8")
            CType(Me.pnlApuntes.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.pnlApuntes.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = CType(resources.GetObject("resource.TextAlignment"), System.Drawing.ContentAlignment)
            '
            'pnlConteo
            '
            resources.ApplyResources(Me.pnlConteo, "pnlConteo")
            Me.pnlConteo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.pnlConteo.Controls.Add(Me.btnLimpiar)
            Me.pnlConteo.Controls.Add(Me.btnContarCaja)
            Me.pnlConteo.Controls.Add(Me.tlpConteo)
            Me.pnlConteo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.pnlConteo.Name = "pnlConteo"
            '
            '
            '
            Me.pnlConteo.RootElement.AccessibleDescription = resources.GetString("pnlConteo.RootElement.AccessibleDescription")
            Me.pnlConteo.RootElement.AccessibleName = resources.GetString("pnlConteo.RootElement.AccessibleName")
            Me.pnlConteo.RootElement.Alignment = CType(resources.GetObject("pnlConteo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.pnlConteo.RootElement.AngleTransform = CType(resources.GetObject("pnlConteo.RootElement.AngleTransform"), Single)
            Me.pnlConteo.RootElement.FlipText = CType(resources.GetObject("pnlConteo.RootElement.FlipText"), Boolean)
            Me.pnlConteo.RootElement.KeyTip = resources.GetString("pnlConteo.RootElement.KeyTip")
            Me.pnlConteo.RootElement.Margin = CType(resources.GetObject("pnlConteo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.pnlConteo.RootElement.Padding = CType(resources.GetObject("pnlConteo.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.pnlConteo.RootElement.Text = resources.GetString("pnlConteo.RootElement.Text")
            Me.pnlConteo.RootElement.TextOrientation = CType(resources.GetObject("pnlConteo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.pnlConteo.RootElement.ToolTipText = resources.GetString("pnlConteo.RootElement.ToolTipText")
            Me.pnlConteo.TextAlignment = System.Drawing.ContentAlignment.TopCenter
            CType(Me.pnlConteo.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = resources.GetString("resource.Text9")
            CType(Me.pnlConteo.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.pnlConteo.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = CType(resources.GetObject("resource.TextAlignment1"), System.Drawing.ContentAlignment)
            '
            'btnLimpiar
            '
            resources.ApplyResources(Me.btnLimpiar, "btnLimpiar")
            Me.btnLimpiar.Image = Global.EasyGest.My.Resources.Resources.cross_disabled
            Me.btnLimpiar.Name = "btnLimpiar"
            '
            '
            '
            Me.btnLimpiar.RootElement.AccessibleDescription = resources.GetString("btnLimpiar.RootElement.AccessibleDescription")
            Me.btnLimpiar.RootElement.AccessibleName = resources.GetString("btnLimpiar.RootElement.AccessibleName")
            Me.btnLimpiar.RootElement.Alignment = CType(resources.GetObject("btnLimpiar.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnLimpiar.RootElement.AngleTransform = CType(resources.GetObject("btnLimpiar.RootElement.AngleTransform"), Single)
            Me.btnLimpiar.RootElement.FlipText = CType(resources.GetObject("btnLimpiar.RootElement.FlipText"), Boolean)
            Me.btnLimpiar.RootElement.KeyTip = resources.GetString("btnLimpiar.RootElement.KeyTip")
            Me.btnLimpiar.RootElement.Margin = CType(resources.GetObject("btnLimpiar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnLimpiar.RootElement.Padding = CType(resources.GetObject("btnLimpiar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnLimpiar.RootElement.Text = resources.GetString("btnLimpiar.RootElement.Text")
            Me.btnLimpiar.RootElement.TextOrientation = CType(resources.GetObject("btnLimpiar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.btnLimpiar.RootElement.ToolTipText = resources.GetString("btnLimpiar.RootElement.ToolTipText")
            '
            'pnlContenedor
            '
            resources.ApplyResources(Me.pnlContenedor, "pnlContenedor")
            Me.pnlContenedor.Controls.Add(Me.pnlLogin)
            Me.pnlContenedor.Controls.Add(Me.pnlConteo)
            Me.pnlContenedor.Controls.Add(Me.pnlApuntes)
            Me.pnlContenedor.Name = "pnlContenedor"
            '
            '
            '
            Me.pnlContenedor.RootElement.AccessibleDescription = resources.GetString("pnlContenedor.RootElement.AccessibleDescription")
            Me.pnlContenedor.RootElement.AccessibleName = resources.GetString("pnlContenedor.RootElement.AccessibleName")
            Me.pnlContenedor.RootElement.Alignment = CType(resources.GetObject("pnlContenedor.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.pnlContenedor.RootElement.AngleTransform = CType(resources.GetObject("pnlContenedor.RootElement.AngleTransform"), Single)
            Me.pnlContenedor.RootElement.FlipText = CType(resources.GetObject("pnlContenedor.RootElement.FlipText"), Boolean)
            Me.pnlContenedor.RootElement.KeyTip = resources.GetString("pnlContenedor.RootElement.KeyTip")
            Me.pnlContenedor.RootElement.Margin = CType(resources.GetObject("pnlContenedor.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.pnlContenedor.RootElement.Padding = CType(resources.GetObject("pnlContenedor.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.pnlContenedor.RootElement.Text = resources.GetString("pnlContenedor.RootElement.Text")
            Me.pnlContenedor.RootElement.TextOrientation = CType(resources.GetObject("pnlContenedor.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.pnlContenedor.RootElement.ToolTipText = resources.GetString("pnlContenedor.RootElement.ToolTipText")
            '
            'frmCierre
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancelar
            Me.Controls.Add(Me.pnlContenedor)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmCierre"
            Me.Opacity = 0.8R
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmCierre.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmCierre.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmCierre.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmCierre.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmCierre.RootElement.FlipText"), Boolean)
            Me.RootElement.KeyTip = resources.GetString("frmCierre.RootElement.KeyTip")
            Me.RootElement.Margin = CType(resources.GetObject("frmCierre.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmCierre.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmCierre.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmCierre.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RootElement.ToolTipText = resources.GetString("frmCierre.RootElement.ToolTipText")
            Me.ShowInTaskbar = False
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel20, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ApuntesDiarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tlpConteo.ResumeLayout(False)
            Me.tlpConteo.PerformLayout()
            CType(Me.BindingSourceDiario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblFechaApertura, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlLogin, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlLogin.ResumeLayout(False)
            Me.pnlLogin.PerformLayout()
            CType(Me.toggleVerApuntes, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toggleVerConteo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtTotalVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtDeposito, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPuesto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinConteoCaja, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtIncidencia, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblFechaCierre, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnContarCaja, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlApuntes, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlApuntes.ResumeLayout(False)
            CType(Me.pnlConteo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlConteo.ResumeLayout(False)
            CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlContenedor, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlContenedor.ResumeLayout(False)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents pnlLogin As Telerik.WinControls.UI.RadPanel
        Friend WithEvents txtIncidencia As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents spinConteoCaja As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents txtPuesto As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtUsuario As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents lblFechaApertura As Telerik.WinControls.UI.RadLabel
        Friend WithEvents BindingSourceDiario As System.Windows.Forms.BindingSource
        Friend WithEvents pnlApuntes As Telerik.WinControls.UI.RadPanel
        Friend WithEvents btnContarCaja As Telerik.WinControls.UI.RadButton
        Friend WithEvents txtTotalVenta As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtDeposito As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents pnlConteo As Telerik.WinControls.UI.RadPanel
        Friend WithEvents pnlContenedor As Telerik.WinControls.UI.RadPanel
        Friend WithEvents tlpConteo As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents gridDatos As Telerik.WinControls.UI.RadGridView
        Friend WithEvents ApuntesDiarioBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
        Friend WithEvents toggleVerConteo As Telerik.WinControls.UI.RadToggleButton
        Friend WithEvents toggleVerApuntes As Telerik.WinControls.UI.RadToggleButton
        Friend WithEvents lblFechaCierre As Telerik.WinControls.UI.RadLabel
        Friend WithEvents btnLimpiar As Telerik.WinControls.UI.RadButton
    End Class

End Namespace