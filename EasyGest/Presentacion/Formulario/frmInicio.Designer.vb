Namespace Presentacion.Formulario

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmInicio
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
            Dim RadLabel16 As Telerik.WinControls.UI.RadLabel
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
            Dim RadPanel5 As Telerik.WinControls.UI.RadPanel
            Dim RadLabel4 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel3 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Dim toolListaCompra As Telerik.WinControls.UI.Docking.ToolWindow
            Dim RadPanel1 As Telerik.WinControls.UI.RadPanel
            Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim RadLabel10 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel14 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel18 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel13 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel12 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel9 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel11 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel15 As Telerik.WinControls.UI.RadLabel
            Dim gboxTarea As Telerik.WinControls.UI.RadGroupBox
            Dim RadLabel7 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel8 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel5 As Telerik.WinControls.UI.RadLabel
            Dim RadPanel2 As Telerik.WinControls.UI.RadPanel
            Dim RadLabel1 As Telerik.WinControls.UI.RadLabel
            Dim toolDivisa As Telerik.WinControls.UI.Docking.ToolWindow
            Dim toolReloj As Telerik.WinControls.UI.Docking.ToolWindow
            Dim RadCalendarDay1 As Telerik.WinControls.UI.RadCalendarDay = New Telerik.WinControls.UI.RadCalendarDay()
            Dim RadCalendarDay2 As Telerik.WinControls.UI.RadCalendarDay = New Telerik.WinControls.UI.RadCalendarDay()
            Dim RadCalendarDay3 As Telerik.WinControls.UI.RadCalendarDay = New Telerik.WinControls.UI.RadCalendarDay()
            Dim RadCalendarDay4 As Telerik.WinControls.UI.RadCalendarDay = New Telerik.WinControls.UI.RadCalendarDay()
            Dim RadCalendarDay5 As Telerik.WinControls.UI.RadCalendarDay = New Telerik.WinControls.UI.RadCalendarDay()
            Dim RadCalendarDay6 As Telerik.WinControls.UI.RadCalendarDay = New Telerik.WinControls.UI.RadCalendarDay()
            Dim RadCalendarDay7 As Telerik.WinControls.UI.RadCalendarDay = New Telerik.WinControls.UI.RadCalendarDay()
            Dim RadCalendarDay8 As Telerik.WinControls.UI.RadCalendarDay = New Telerik.WinControls.UI.RadCalendarDay()
            Dim RadCalendarDay9 As Telerik.WinControls.UI.RadCalendarDay = New Telerik.WinControls.UI.RadCalendarDay()
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewImageColumn1 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
            Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim GridViewDateTimeColumn3 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
            Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Me.waitbMeteo = New Telerik.WinControls.UI.RadWaitingBar()
            Me.btnActualizarMeteologia = New Telerik.WinControls.UI.RadButton()
            Me.trbTiempo = New Telerik.WinControls.UI.RadTrackBar()
            Me.wbwMeteo = New System.Windows.Forms.WebBrowser()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.SplitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.gridListaCompra = New Telerik.WinControls.UI.RadGridView()
            Me.ListasCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.SplitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.gboxEncargo = New Telerik.WinControls.UI.RadGroupBox()
            Me.btnBuscarProducto = New Telerik.WinControls.UI.RadButton()
            Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
            Me.txtNombre = New Telerik.WinControls.UI.RadTextBox()
            Me.EncargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.txtTelefono = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.chkRecogido = New Telerik.WinControls.UI.RadCheckBox()
            Me.spinFianza = New Telerik.WinControls.UI.RadSpinEditor()
            Me.spinCantidad = New Telerik.WinControls.UI.RadSpinEditor()
            Me.dtpRecogida = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.txtProducto = New Telerik.WinControls.UI.RadTextBox()
            Me.txtReferencia = New Telerik.WinControls.UI.RadTextBox()
            Me.btnCancelarEncargo = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptarEncargo = New Telerik.WinControls.UI.RadButton()
            Me.chkSuspendido = New Telerik.WinControls.UI.RadCheckBox()
            Me.txtObservacion = New Telerik.WinControls.UI.RadTextBox()
            Me.cbListaCompra = New Telerik.WinControls.UI.RadCommandBar()
            Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.cbstripListasCompra = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbbtnAgregarEncargo = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnEditarEncargo = New Telerik.WinControls.UI.CommandBarButton()
            Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.cbddbRecargarLista = New Telerik.WinControls.UI.CommandBarDropDownButton()
            Me.mnitemReciente = New Telerik.WinControls.UI.RadMenuItem()
            Me.mnitemTodas = New Telerik.WinControls.UI.RadMenuItem()
            Me.cbbtnImprimirLista = New Telerik.WinControls.UI.CommandBarButton()
            Me.btnCancelarTarea = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptarTarea = New Telerik.WinControls.UI.RadButton()
            Me.txtTarea = New Telerik.WinControls.UI.RadTextBox()
            Me.TareaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ddlAviso = New Telerik.WinControls.UI.RadDropDownList()
            Me.ddlPrioridadTarea = New Telerik.WinControls.UI.RadDropDownList()
            Me.PrioridadesTareaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.dtpTiempoAviso = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.dtpFechaTarea = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.waitbDivisa = New Telerik.WinControls.UI.RadWaitingBar()
            Me.btnActualizarDivisa = New Telerik.WinControls.UI.RadButton()
            Me.trbDivisa = New Telerik.WinControls.UI.RadTrackBar()
            Me.wbwDivisa = New System.Windows.Forms.WebBrowser()
            Me.RadClock1 = New Telerik.WinControls.UI.RadClock()
            Me.lblTotalVenta = New Telerik.WinControls.UI.RadLabel()
            Me.RoundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
            Me.lblNumeroVenta = New Telerik.WinControls.UI.RadLabel()
            Me.calCalendario = New Telerik.WinControls.UI.RadCalendar()
            Me.gridTareas = New Telerik.WinControls.UI.RadGridView()
            Me.TareasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.waitbTareas = New Telerik.WinControls.UI.RadWaitingBar()
            Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock()
            Me.toolTarea = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.RadSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.SplitPanel3 = New Telerik.WinControls.UI.SplitPanel()
            Me.SplitPanel4 = New Telerik.WinControls.UI.SplitPanel()
            Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
            Me.CommandBarRowElement2 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.cbstripTarea = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbbtnAgregarTarea = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnEliminarTarea = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnEditarTarea = New Telerik.WinControls.UI.CommandBarButton()
            Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.cbtoggleTodasTareas = New Telerik.WinControls.UI.CommandBarToggleButton()
            Me.ToolTabStrip4 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.RadSplitContainer3 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.RadSplitContainer4 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.ToolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.toolMeteo = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.RadSplitContainer5 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.ToolTabStrip6 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.toolCalendario = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.ToolTabStrip7 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.ToolTabStrip8 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
            Me.toolResumen = New Telerik.WinControls.UI.Docking.ToolWindow()
            Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
            Me.timerRefrescoInicio = New System.Windows.Forms.Timer(Me.components)
            Me.timerRefrescoDivisa = New System.Windows.Forms.Timer(Me.components)
            Me.timerRefrescoMeteo = New System.Windows.Forms.Timer(Me.components)
            Me.bgwInicio = New System.ComponentModel.BackgroundWorker()
            RadLabel16 = New Telerik.WinControls.UI.RadLabel()
            RadPanel5 = New Telerik.WinControls.UI.RadPanel()
            RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            RadLabel3 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            toolListaCompra = New Telerik.WinControls.UI.Docking.ToolWindow()
            RadPanel1 = New Telerik.WinControls.UI.RadPanel()
            RadLabel10 = New Telerik.WinControls.UI.RadLabel()
            RadLabel14 = New Telerik.WinControls.UI.RadLabel()
            RadLabel18 = New Telerik.WinControls.UI.RadLabel()
            RadLabel13 = New Telerik.WinControls.UI.RadLabel()
            RadLabel12 = New Telerik.WinControls.UI.RadLabel()
            RadLabel9 = New Telerik.WinControls.UI.RadLabel()
            RadLabel11 = New Telerik.WinControls.UI.RadLabel()
            RadLabel15 = New Telerik.WinControls.UI.RadLabel()
            gboxTarea = New Telerik.WinControls.UI.RadGroupBox()
            RadLabel7 = New Telerik.WinControls.UI.RadLabel()
            RadLabel8 = New Telerik.WinControls.UI.RadLabel()
            RadLabel5 = New Telerik.WinControls.UI.RadLabel()
            RadPanel2 = New Telerik.WinControls.UI.RadPanel()
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            toolDivisa = New Telerik.WinControls.UI.Docking.ToolWindow()
            toolReloj = New Telerik.WinControls.UI.Docking.ToolWindow()
            CType(RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
            RadPanel5.SuspendLayout()
            CType(Me.waitbMeteo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnActualizarMeteologia, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trbTiempo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            toolListaCompra.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            RadPanel1.SuspendLayout()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer1.SuspendLayout()
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel1.SuspendLayout()
            CType(Me.gridListaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridListaCompra.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ListasCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel2.SuspendLayout()
            CType(Me.gboxEncargo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gboxEncargo.SuspendLayout()
            CType(Me.btnBuscarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadGroupBox3.SuspendLayout()
            CType(RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EncargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkRecogido, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinFianza, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpRecogida, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtProducto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtReferencia, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelarEncargo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptarEncargo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkSuspendido, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbListaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(gboxTarea, System.ComponentModel.ISupportInitialize).BeginInit()
            gboxTarea.SuspendLayout()
            CType(Me.btnCancelarTarea, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptarTarea, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtTarea, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TareaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlAviso, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlPrioridadTarea, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PrioridadesTareaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpTiempoAviso, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFechaTarea, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            RadPanel2.SuspendLayout()
            CType(Me.waitbDivisa, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnActualizarDivisa, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trbDivisa, System.ComponentModel.ISupportInitialize).BeginInit()
            toolDivisa.SuspendLayout()
            toolReloj.SuspendLayout()
            CType(Me.RadClock1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblTotalVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblNumeroVenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.calCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridTareas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridTareas.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TareasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.waitbTareas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadDock1.SuspendLayout()
            Me.toolTarea.SuspendLayout()
            CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer2.SuspendLayout()
            CType(Me.SplitPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel3.SuspendLayout()
            CType(Me.SplitPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel4.SuspendLayout()
            CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolTabStrip4.SuspendLayout()
            CType(Me.RadSplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer3.SuspendLayout()
            CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolTabStrip1.SuspendLayout()
            CType(Me.RadSplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer4.SuspendLayout()
            CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolTabStrip2.SuspendLayout()
            CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolTabStrip3.SuspendLayout()
            Me.toolMeteo.SuspendLayout()
            CType(Me.RadSplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer5.SuspendLayout()
            CType(Me.ToolTabStrip6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolTabStrip6.SuspendLayout()
            Me.toolCalendario.SuspendLayout()
            CType(Me.ToolTabStrip7, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolTabStrip7.SuspendLayout()
            CType(Me.ToolTabStrip8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolTabStrip8.SuspendLayout()
            Me.toolResumen.SuspendLayout()
            CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            RadLabel16.RootElement.Margin = CType(resources.GetObject("RadLabel16.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel16.RootElement.Text = resources.GetString("RadLabel16.RootElement.Text")
            RadLabel16.RootElement.TextOrientation = CType(resources.GetObject("RadLabel16.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadPanel5
            '
            RadPanel5.Controls.Add(Me.waitbMeteo)
            RadPanel5.Controls.Add(Me.btnActualizarMeteologia)
            RadPanel5.Controls.Add(RadLabel16)
            RadPanel5.Controls.Add(Me.trbTiempo)
            RadPanel5.Controls.Add(Me.wbwMeteo)
            resources.ApplyResources(RadPanel5, "RadPanel5")
            RadPanel5.Name = "RadPanel5"
            '
            '
            '
            RadPanel5.RootElement.AccessibleDescription = resources.GetString("RadPanel5.RootElement.AccessibleDescription")
            RadPanel5.RootElement.AccessibleName = resources.GetString("RadPanel5.RootElement.AccessibleName")
            RadPanel5.RootElement.Alignment = CType(resources.GetObject("RadPanel5.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadPanel5.RootElement.AngleTransform = CType(resources.GetObject("RadPanel5.RootElement.AngleTransform"), Single)
            RadPanel5.RootElement.FlipText = CType(resources.GetObject("RadPanel5.RootElement.FlipText"), Boolean)
            RadPanel5.RootElement.Margin = CType(resources.GetObject("RadPanel5.RootElement.Margin"), System.Windows.Forms.Padding)
            RadPanel5.RootElement.Text = resources.GetString("RadPanel5.RootElement.Text")
            RadPanel5.RootElement.TextOrientation = CType(resources.GetObject("RadPanel5.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'waitbMeteo
            '
            resources.ApplyResources(Me.waitbMeteo, "waitbMeteo")
            Me.waitbMeteo.Name = "waitbMeteo"
            '
            '
            '
            Me.waitbMeteo.RootElement.AccessibleDescription = resources.GetString("waitbMeteo.RootElement.AccessibleDescription")
            Me.waitbMeteo.RootElement.AccessibleName = resources.GetString("waitbMeteo.RootElement.AccessibleName")
            Me.waitbMeteo.RootElement.Alignment = CType(resources.GetObject("waitbMeteo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.waitbMeteo.RootElement.AngleTransform = CType(resources.GetObject("waitbMeteo.RootElement.AngleTransform"), Single)
            Me.waitbMeteo.RootElement.FlipText = CType(resources.GetObject("waitbMeteo.RootElement.FlipText"), Boolean)
            Me.waitbMeteo.RootElement.Margin = CType(resources.GetObject("waitbMeteo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.waitbMeteo.RootElement.Text = resources.GetString("waitbMeteo.RootElement.Text")
            Me.waitbMeteo.RootElement.TextOrientation = CType(resources.GetObject("waitbMeteo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.waitbMeteo.WaitingSpeed = 80
            Me.waitbMeteo.WaitingStep = 10
            Me.waitbMeteo.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Throbber
            '
            'btnActualizarMeteologia
            '
            resources.ApplyResources(Me.btnActualizarMeteologia, "btnActualizarMeteologia")
            Me.btnActualizarMeteologia.Name = "btnActualizarMeteologia"
            '
            '
            '
            Me.btnActualizarMeteologia.RootElement.AccessibleDescription = resources.GetString("btnActualizarMeteologia.RootElement.AccessibleDescription")
            Me.btnActualizarMeteologia.RootElement.AccessibleName = resources.GetString("btnActualizarMeteologia.RootElement.AccessibleName")
            Me.btnActualizarMeteologia.RootElement.Alignment = CType(resources.GetObject("btnActualizarMeteologia.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnActualizarMeteologia.RootElement.AngleTransform = CType(resources.GetObject("btnActualizarMeteologia.RootElement.AngleTransform"), Single)
            Me.btnActualizarMeteologia.RootElement.FlipText = CType(resources.GetObject("btnActualizarMeteologia.RootElement.FlipText"), Boolean)
            Me.btnActualizarMeteologia.RootElement.Margin = CType(resources.GetObject("btnActualizarMeteologia.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnActualizarMeteologia.RootElement.Text = resources.GetString("btnActualizarMeteologia.RootElement.Text")
            Me.btnActualizarMeteologia.RootElement.TextOrientation = CType(resources.GetObject("btnActualizarMeteologia.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'trbTiempo
            '
            resources.ApplyResources(Me.trbTiempo, "trbTiempo")
            Me.trbTiempo.BackColor = System.Drawing.Color.Transparent
            Me.trbTiempo.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.TopLeft
            Me.trbTiempo.LargeChange = 1
            Me.trbTiempo.LargeTickFrequency = 1
            Me.trbTiempo.Maximum = 6.0!
            Me.trbTiempo.Minimum = 1.0!
            Me.trbTiempo.Name = "trbTiempo"
            '
            '
            '
            Me.trbTiempo.RootElement.AccessibleDescription = resources.GetString("trbTiempo.RootElement.AccessibleDescription")
            Me.trbTiempo.RootElement.AccessibleName = resources.GetString("trbTiempo.RootElement.AccessibleName")
            Me.trbTiempo.RootElement.Alignment = CType(resources.GetObject("trbTiempo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.trbTiempo.RootElement.AngleTransform = CType(resources.GetObject("trbTiempo.RootElement.AngleTransform"), Single)
            Me.trbTiempo.RootElement.FlipText = CType(resources.GetObject("trbTiempo.RootElement.FlipText"), Boolean)
            Me.trbTiempo.RootElement.Margin = CType(resources.GetObject("trbTiempo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.trbTiempo.RootElement.Text = resources.GetString("trbTiempo.RootElement.Text")
            Me.trbTiempo.RootElement.TextOrientation = CType(resources.GetObject("trbTiempo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.trbTiempo.ShowSlideArea = False
            Me.trbTiempo.TickStyle = Telerik.WinControls.Enumerations.TickStyles.None
            Me.trbTiempo.Value = 6.0!
            CType(Me.trbTiempo.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).BackColor = System.Drawing.Color.Transparent
            CType(Me.trbTiempo.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).MinSize = New System.Drawing.Size(100, 0)
            '
            'wbwMeteo
            '
            resources.ApplyResources(Me.wbwMeteo, "wbwMeteo")
            Me.wbwMeteo.Name = "wbwMeteo"
            Me.wbwMeteo.TabStop = False
            Me.wbwMeteo.Url = New System.Uri("", System.UriKind.Relative)
            Me.wbwMeteo.WebBrowserShortcutsEnabled = False
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
            RadLabel4.RootElement.Text = resources.GetString("RadLabel4.RootElement.Text")
            RadLabel4.RootElement.TextOrientation = CType(resources.GetObject("RadLabel4.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel3.RootElement.Text = resources.GetString("RadLabel3.RootElement.Text")
            RadLabel3.RootElement.TextOrientation = CType(resources.GetObject("RadLabel3.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel2.RootElement.Text = resources.GetString("RadLabel2.RootElement.Text")
            RadLabel2.RootElement.TextOrientation = CType(resources.GetObject("RadLabel2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'toolListaCompra
            '
            toolListaCompra.Caption = Nothing
            toolListaCompra.Controls.Add(Me.TableLayoutPanel1)
            toolListaCompra.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
            resources.ApplyResources(toolListaCompra, "toolListaCompra")
            toolListaCompra.Name = "toolListaCompra"
            toolListaCompra.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            toolListaCompra.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
            '
            'TableLayoutPanel1
            '
            resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
            Me.TableLayoutPanel1.Controls.Add(RadPanel1, 0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            '
            'RadPanel1
            '
            Me.TableLayoutPanel1.SetColumnSpan(RadPanel1, 2)
            RadPanel1.Controls.Add(Me.RadSplitContainer1)
            RadPanel1.Controls.Add(Me.cbListaCompra)
            resources.ApplyResources(RadPanel1, "RadPanel1")
            RadPanel1.Name = "RadPanel1"
            '
            '
            '
            RadPanel1.RootElement.AccessibleDescription = resources.GetString("RadPanel1.RootElement.AccessibleDescription")
            RadPanel1.RootElement.AccessibleName = resources.GetString("RadPanel1.RootElement.AccessibleName")
            RadPanel1.RootElement.Alignment = CType(resources.GetObject("RadPanel1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadPanel1.RootElement.AngleTransform = CType(resources.GetObject("RadPanel1.RootElement.AngleTransform"), Single)
            RadPanel1.RootElement.FlipText = CType(resources.GetObject("RadPanel1.RootElement.FlipText"), Boolean)
            RadPanel1.RootElement.Margin = CType(resources.GetObject("RadPanel1.RootElement.Margin"), System.Windows.Forms.Padding)
            RadPanel1.RootElement.Text = resources.GetString("RadPanel1.RootElement.Text")
            RadPanel1.RootElement.TextOrientation = CType(resources.GetObject("RadPanel1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.TableLayoutPanel1.SetRowSpan(RadPanel1, 2)
            '
            'RadSplitContainer1
            '
            Me.RadSplitContainer1.Controls.Add(Me.SplitPanel1)
            Me.RadSplitContainer1.Controls.Add(Me.SplitPanel2)
            resources.ApplyResources(Me.RadSplitContainer1, "RadSplitContainer1")
            Me.RadSplitContainer1.EnableCollapsing = True
            Me.RadSplitContainer1.IsCleanUpTarget = True
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
            Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.RadSplitContainer1.RootElement.Text = resources.GetString("RadSplitContainer1.RootElement.Text")
            Me.RadSplitContainer1.RootElement.TextOrientation = CType(resources.GetObject("RadSplitContainer1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadSplitContainer1.TabStop = False
            '
            'SplitPanel1
            '
            Me.SplitPanel1.Controls.Add(Me.gridListaCompra)
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
            Me.SplitPanel1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel1.RootElement.Text = resources.GetString("SplitPanel1.RootElement.Text")
            Me.SplitPanel1.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.002604167!)
            Me.SplitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 5)
            Me.SplitPanel1.TabStop = False
            '
            'gridListaCompra
            '
            Me.gridListaCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.gridListaCompra.Cursor = System.Windows.Forms.Cursors.Default
            resources.ApplyResources(Me.gridListaCompra, "gridListaCompra")
            Me.gridListaCompra.ForeColor = System.Drawing.Color.Black
            '
            '
            '
            Me.gridListaCompra.MasterTemplate.AllowCellContextMenu = False
            Me.gridListaCompra.MasterTemplate.AllowColumnChooser = False
            Me.gridListaCompra.MasterTemplate.AllowDragToGroup = False
            Me.gridListaCompra.MasterTemplate.AutoGenerateColumns = False
            GridViewDecimalColumn1.DataType = GetType(Long)
            GridViewDecimalColumn1.EnableExpressionEditor = False
            GridViewDecimalColumn1.FieldName = "idCompra"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.IsVisible = False
            GridViewDecimalColumn1.Name = "idCompra"
            GridViewTextBoxColumn1.AllowFiltering = False
            GridViewTextBoxColumn1.AllowGroup = False
            GridViewTextBoxColumn1.ColumnCharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            GridViewTextBoxColumn1.EnableExpressionEditor = False
            GridViewTextBoxColumn1.FieldName = "Descripcion"
            resources.ApplyResources(GridViewTextBoxColumn1, "GridViewTextBoxColumn1")
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.IsPinned = True
            GridViewTextBoxColumn1.Name = "Descripcion"
            GridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewTextBoxColumn1.Width = 226
            GridViewTextBoxColumn2.AllowFiltering = False
            GridViewTextBoxColumn2.AllowGroup = False
            GridViewTextBoxColumn2.EnableExpressionEditor = False
            GridViewTextBoxColumn2.FieldName = "Referencia"
            resources.ApplyResources(GridViewTextBoxColumn2, "GridViewTextBoxColumn2")
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.Name = "Referencia"
            GridViewTextBoxColumn2.Width = 149
            GridViewTextBoxColumn3.AllowFiltering = False
            GridViewTextBoxColumn3.AllowGroup = False
            GridViewTextBoxColumn3.EnableExpressionEditor = False
            GridViewTextBoxColumn3.FieldName = "Observacion"
            resources.ApplyResources(GridViewTextBoxColumn3, "GridViewTextBoxColumn3")
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.Multiline = True
            GridViewTextBoxColumn3.Name = "Observacion"
            GridViewTextBoxColumn3.Width = 174
            GridViewDateTimeColumn1.AllowGroup = False
            GridViewDateTimeColumn1.EnableExpressionEditor = False
            GridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumTime
            GridViewDateTimeColumn1.FieldName = "FechaCreacion"
            GridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            resources.ApplyResources(GridViewDateTimeColumn1, "GridViewDateTimeColumn1")
            GridViewDateTimeColumn1.IsAutoGenerated = True
            GridViewDateTimeColumn1.Name = "FechaCreacion"
            GridViewDateTimeColumn1.ReadOnly = True
            GridViewDateTimeColumn1.Width = 108
            GridViewCheckBoxColumn1.AllowGroup = False
            GridViewCheckBoxColumn1.AllowSort = False
            GridViewCheckBoxColumn1.EnableExpressionEditor = False
            GridViewCheckBoxColumn1.FieldName = "EsEncargo"
            resources.ApplyResources(GridViewCheckBoxColumn1, "GridViewCheckBoxColumn1")
            GridViewCheckBoxColumn1.IsAutoGenerated = True
            GridViewCheckBoxColumn1.MinWidth = 20
            GridViewCheckBoxColumn1.Name = "EsEncargo"
            GridViewCheckBoxColumn1.ReadOnly = True
            GridViewCheckBoxColumn1.Width = 66
            Me.gridListaCompra.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewDateTimeColumn1, GridViewCheckBoxColumn1})
            Me.gridListaCompra.MasterTemplate.DataSource = Me.ListasCompraBindingSource
            Me.gridListaCompra.MasterTemplate.EnableAlternatingRowColor = True
            Me.gridListaCompra.MasterTemplate.EnableGrouping = False
            Me.gridListaCompra.MasterTemplate.MultiSelect = True
            Me.gridListaCompra.MasterTemplate.ViewDefinition = TableViewDefinition1
            Me.gridListaCompra.Name = "gridListaCompra"
            Me.gridListaCompra.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell
            '
            '
            '
            Me.gridListaCompra.RootElement.AccessibleDescription = resources.GetString("gridListaCompra.RootElement.AccessibleDescription")
            Me.gridListaCompra.RootElement.AccessibleName = resources.GetString("gridListaCompra.RootElement.AccessibleName")
            Me.gridListaCompra.RootElement.Alignment = CType(resources.GetObject("gridListaCompra.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.gridListaCompra.RootElement.AngleTransform = CType(resources.GetObject("gridListaCompra.RootElement.AngleTransform"), Single)
            Me.gridListaCompra.RootElement.FlipText = CType(resources.GetObject("gridListaCompra.RootElement.FlipText"), Boolean)
            Me.gridListaCompra.RootElement.Margin = CType(resources.GetObject("gridListaCompra.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.gridListaCompra.RootElement.Text = resources.GetString("gridListaCompra.RootElement.Text")
            Me.gridListaCompra.RootElement.TextOrientation = CType(resources.GetObject("gridListaCompra.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.gridListaCompra.ShowGroupPanel = False
            '
            'ListasCompraBindingSource
            '
            Me.ListasCompraBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.ListasCompra)
            '
            'SplitPanel2
            '
            resources.ApplyResources(Me.SplitPanel2, "SplitPanel2")
            Me.SplitPanel2.Controls.Add(Me.gboxEncargo)
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
            Me.SplitPanel2.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel2.RootElement.Text = resources.GetString("SplitPanel2.RootElement.Text")
            Me.SplitPanel2.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.002604167!)
            Me.SplitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -5)
            Me.SplitPanel2.TabStop = False
            '
            'gboxEncargo
            '
            Me.gboxEncargo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.gboxEncargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.gboxEncargo.Controls.Add(Me.btnBuscarProducto)
            Me.gboxEncargo.Controls.Add(Me.RadGroupBox3)
            Me.gboxEncargo.Controls.Add(Me.chkRecogido)
            Me.gboxEncargo.Controls.Add(RadLabel18)
            Me.gboxEncargo.Controls.Add(RadLabel13)
            Me.gboxEncargo.Controls.Add(Me.spinFianza)
            Me.gboxEncargo.Controls.Add(RadLabel12)
            Me.gboxEncargo.Controls.Add(Me.spinCantidad)
            Me.gboxEncargo.Controls.Add(RadLabel9)
            Me.gboxEncargo.Controls.Add(RadLabel11)
            Me.gboxEncargo.Controls.Add(RadLabel15)
            Me.gboxEncargo.Controls.Add(Me.dtpRecogida)
            Me.gboxEncargo.Controls.Add(Me.txtProducto)
            Me.gboxEncargo.Controls.Add(Me.txtReferencia)
            Me.gboxEncargo.Controls.Add(Me.btnCancelarEncargo)
            Me.gboxEncargo.Controls.Add(Me.btnAceptarEncargo)
            Me.gboxEncargo.Controls.Add(Me.chkSuspendido)
            Me.gboxEncargo.Controls.Add(Me.txtObservacion)
            resources.ApplyResources(Me.gboxEncargo, "gboxEncargo")
            Me.gboxEncargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.gboxEncargo.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            Me.gboxEncargo.HeaderImage = Global.EasyGest.My.Resources.Resources.cart_put
            Me.gboxEncargo.HeaderImageAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.gboxEncargo.HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Left
            Me.gboxEncargo.HeaderTextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.gboxEncargo.Name = "gboxEncargo"
            '
            '
            '
            Me.gboxEncargo.RootElement.AccessibleDescription = resources.GetString("gboxEncargo.RootElement.AccessibleDescription")
            Me.gboxEncargo.RootElement.AccessibleName = resources.GetString("gboxEncargo.RootElement.AccessibleName")
            Me.gboxEncargo.RootElement.Alignment = CType(resources.GetObject("gboxEncargo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.gboxEncargo.RootElement.AngleTransform = CType(resources.GetObject("gboxEncargo.RootElement.AngleTransform"), Single)
            Me.gboxEncargo.RootElement.FlipText = CType(resources.GetObject("gboxEncargo.RootElement.FlipText"), Boolean)
            Me.gboxEncargo.RootElement.Margin = CType(resources.GetObject("gboxEncargo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.gboxEncargo.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.gboxEncargo.RootElement.Text = resources.GetString("gboxEncargo.RootElement.Text")
            Me.gboxEncargo.RootElement.TextOrientation = CType(resources.GetObject("gboxEncargo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.gboxEncargo.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).InvalidateMeasureInMainLayout = 1
            CType(Me.gboxEncargo.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).Padding = CType(resources.GetObject("resource.Padding"), System.Windows.Forms.Padding)
            CType(Me.gboxEncargo.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).HeaderPosition = Telerik.WinControls.UI.HeaderPosition.Left
            CType(Me.gboxEncargo.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            CType(Me.gboxEncargo.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.gboxEncargo.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).AngleTransform = CType(resources.GetObject("resource.AngleTransform"), Single)
            '
            'btnBuscarProducto
            '
            Me.btnBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.btnBuscarProducto.Image = Global.EasyGest.My.Resources.Resources.find
            resources.ApplyResources(Me.btnBuscarProducto, "btnBuscarProducto")
            Me.btnBuscarProducto.Name = "btnBuscarProducto"
            '
            '
            '
            Me.btnBuscarProducto.RootElement.AccessibleDescription = resources.GetString("btnBuscarProducto.RootElement.AccessibleDescription")
            Me.btnBuscarProducto.RootElement.AccessibleName = resources.GetString("btnBuscarProducto.RootElement.AccessibleName")
            Me.btnBuscarProducto.RootElement.Alignment = CType(resources.GetObject("btnBuscarProducto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnBuscarProducto.RootElement.AngleTransform = CType(resources.GetObject("btnBuscarProducto.RootElement.AngleTransform"), Single)
            Me.btnBuscarProducto.RootElement.FlipText = CType(resources.GetObject("btnBuscarProducto.RootElement.FlipText"), Boolean)
            Me.btnBuscarProducto.RootElement.Margin = CType(resources.GetObject("btnBuscarProducto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnBuscarProducto.RootElement.Text = resources.GetString("btnBuscarProducto.RootElement.Text")
            Me.btnBuscarProducto.RootElement.TextOrientation = CType(resources.GetObject("btnBuscarProducto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'RadGroupBox3
            '
            Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            resources.ApplyResources(Me.RadGroupBox3, "RadGroupBox3")
            Me.RadGroupBox3.Controls.Add(RadLabel10)
            Me.RadGroupBox3.Controls.Add(Me.txtNombre)
            Me.RadGroupBox3.Controls.Add(RadLabel14)
            Me.RadGroupBox3.Controls.Add(Me.txtTelefono)
            Me.RadGroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.RadGroupBox3.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center
            Me.RadGroupBox3.Name = "RadGroupBox3"
            '
            '
            '
            Me.RadGroupBox3.RootElement.AccessibleDescription = resources.GetString("RadGroupBox3.RootElement.AccessibleDescription")
            Me.RadGroupBox3.RootElement.AccessibleName = resources.GetString("RadGroupBox3.RootElement.AccessibleName")
            Me.RadGroupBox3.RootElement.Alignment = CType(resources.GetObject("RadGroupBox3.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadGroupBox3.RootElement.AngleTransform = CType(resources.GetObject("RadGroupBox3.RootElement.AngleTransform"), Single)
            Me.RadGroupBox3.RootElement.FlipText = CType(resources.GetObject("RadGroupBox3.RootElement.FlipText"), Boolean)
            Me.RadGroupBox3.RootElement.Margin = CType(resources.GetObject("RadGroupBox3.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadGroupBox3.RootElement.Text = resources.GetString("RadGroupBox3.RootElement.Text")
            Me.RadGroupBox3.RootElement.TextOrientation = CType(resources.GetObject("RadGroupBox3.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadGroupBox3.TabStop = False
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
            RadLabel10.RootElement.Text = resources.GetString("RadLabel10.RootElement.Text")
            RadLabel10.RootElement.TextOrientation = CType(resources.GetObject("RadLabel10.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'txtNombre
            '
            resources.ApplyResources(Me.txtNombre, "txtNombre")
            Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncargoBindingSource, "Cliente", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
            Me.txtNombre.RootElement.Text = resources.GetString("txtNombre.RootElement.Text")
            Me.txtNombre.RootElement.TextOrientation = CType(resources.GetObject("txtNombre.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtNombre.Tag = ""
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text")
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'EncargoBindingSource
            '
            Me.EncargoBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Encargos)
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
            RadLabel14.RootElement.Text = resources.GetString("RadLabel14.RootElement.Text")
            RadLabel14.RootElement.TextOrientation = CType(resources.GetObject("RadLabel14.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'txtTelefono
            '
            resources.ApplyResources(Me.txtTelefono, "txtTelefono")
            Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncargoBindingSource, "Telefono", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtTelefono.Name = "txtTelefono"
            '
            '
            '
            Me.txtTelefono.RootElement.AccessibleDescription = resources.GetString("txtTelefono.RootElement.AccessibleDescription")
            Me.txtTelefono.RootElement.AccessibleName = resources.GetString("txtTelefono.RootElement.AccessibleName")
            Me.txtTelefono.RootElement.Alignment = CType(resources.GetObject("txtTelefono.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtTelefono.RootElement.AngleTransform = CType(resources.GetObject("txtTelefono.RootElement.AngleTransform"), Single)
            Me.txtTelefono.RootElement.FlipText = CType(resources.GetObject("txtTelefono.RootElement.FlipText"), Boolean)
            Me.txtTelefono.RootElement.Margin = CType(resources.GetObject("txtTelefono.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtTelefono.RootElement.Text = resources.GetString("txtTelefono.RootElement.Text")
            Me.txtTelefono.RootElement.TextOrientation = CType(resources.GetObject("txtTelefono.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtTelefono.TabStop = False
            CType(Me.txtTelefono.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text1")
            CType(Me.txtTelefono.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtTelefono.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtTelefono.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtTelefono.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'chkRecogido
            '
            Me.chkRecogido.DataBindings.Add(New System.Windows.Forms.Binding("IsChecked", Me.EncargoBindingSource, "Recogido", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.chkRecogido, "chkRecogido")
            Me.chkRecogido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.chkRecogido.Name = "chkRecogido"
            '
            '
            '
            Me.chkRecogido.RootElement.AccessibleDescription = resources.GetString("chkRecogido.RootElement.AccessibleDescription")
            Me.chkRecogido.RootElement.AccessibleName = resources.GetString("chkRecogido.RootElement.AccessibleName")
            Me.chkRecogido.RootElement.Alignment = CType(resources.GetObject("chkRecogido.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.chkRecogido.RootElement.AngleTransform = CType(resources.GetObject("chkRecogido.RootElement.AngleTransform"), Single)
            Me.chkRecogido.RootElement.FlipText = CType(resources.GetObject("chkRecogido.RootElement.FlipText"), Boolean)
            Me.chkRecogido.RootElement.Margin = CType(resources.GetObject("chkRecogido.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.chkRecogido.RootElement.Text = resources.GetString("chkRecogido.RootElement.Text")
            Me.chkRecogido.RootElement.TextOrientation = CType(resources.GetObject("chkRecogido.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel18.RootElement.Text = resources.GetString("RadLabel18.RootElement.Text")
            RadLabel18.RootElement.TextOrientation = CType(resources.GetObject("RadLabel18.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel13.RootElement.Text = resources.GetString("RadLabel13.RootElement.Text")
            RadLabel13.RootElement.TextOrientation = CType(resources.GetObject("RadLabel13.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'spinFianza
            '
            Me.spinFianza.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EncargoBindingSource, "Fianza", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
            resources.ApplyResources(Me.spinFianza, "spinFianza")
            Me.spinFianza.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinFianza.Name = "spinFianza"
            '
            '
            '
            Me.spinFianza.RootElement.AccessibleDescription = resources.GetString("spinFianza.RootElement.AccessibleDescription")
            Me.spinFianza.RootElement.AccessibleName = resources.GetString("spinFianza.RootElement.AccessibleName")
            Me.spinFianza.RootElement.Alignment = CType(resources.GetObject("spinFianza.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.spinFianza.RootElement.AngleTransform = CType(resources.GetObject("spinFianza.RootElement.AngleTransform"), Single)
            Me.spinFianza.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.spinFianza.RootElement.FlipText = CType(resources.GetObject("spinFianza.RootElement.FlipText"), Boolean)
            Me.spinFianza.RootElement.Margin = CType(resources.GetObject("spinFianza.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.spinFianza.RootElement.Text = resources.GetString("spinFianza.RootElement.Text")
            Me.spinFianza.RootElement.TextOrientation = CType(resources.GetObject("spinFianza.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.spinFianza.ShowUpDownButtons = False
            Me.spinFianza.TabStop = False
            Me.spinFianza.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.spinFianza.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
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
            RadLabel12.RootElement.Text = resources.GetString("RadLabel12.RootElement.Text")
            RadLabel12.RootElement.TextOrientation = CType(resources.GetObject("RadLabel12.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'spinCantidad
            '
            Me.spinCantidad.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EncargoBindingSource, "Cantidad", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.spinCantidad, "spinCantidad")
            Me.spinCantidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinCantidad.Name = "spinCantidad"
            '
            '
            '
            Me.spinCantidad.RootElement.AccessibleDescription = resources.GetString("spinCantidad.RootElement.AccessibleDescription")
            Me.spinCantidad.RootElement.AccessibleName = resources.GetString("spinCantidad.RootElement.AccessibleName")
            Me.spinCantidad.RootElement.Alignment = CType(resources.GetObject("spinCantidad.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.spinCantidad.RootElement.AngleTransform = CType(resources.GetObject("spinCantidad.RootElement.AngleTransform"), Single)
            Me.spinCantidad.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.spinCantidad.RootElement.FlipText = CType(resources.GetObject("spinCantidad.RootElement.FlipText"), Boolean)
            Me.spinCantidad.RootElement.Margin = CType(resources.GetObject("spinCantidad.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.spinCantidad.RootElement.Text = resources.GetString("spinCantidad.RootElement.Text")
            Me.spinCantidad.RootElement.TextOrientation = CType(resources.GetObject("spinCantidad.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.spinCantidad.ShowUpDownButtons = False
            Me.spinCantidad.TabStop = False
            Me.spinCantidad.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.spinCantidad.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
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
            RadLabel9.RootElement.Text = resources.GetString("RadLabel9.RootElement.Text")
            RadLabel9.RootElement.TextOrientation = CType(resources.GetObject("RadLabel9.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel11.RootElement.Text = resources.GetString("RadLabel11.RootElement.Text")
            RadLabel11.RootElement.TextOrientation = CType(resources.GetObject("RadLabel11.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel15.RootElement.Text = resources.GetString("RadLabel15.RootElement.Text")
            RadLabel15.RootElement.TextOrientation = CType(resources.GetObject("RadLabel15.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'dtpRecogida
            '
            Me.dtpRecogida.BackColor = System.Drawing.Color.White
            Me.dtpRecogida.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EncargoBindingSource, "FechaRecogidaPrevista", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "d"))
            resources.ApplyResources(Me.dtpRecogida, "dtpRecogida")
            Me.dtpRecogida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.dtpRecogida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpRecogida.Name = "dtpRecogida"
            '
            '
            '
            Me.dtpRecogida.RootElement.AccessibleDescription = resources.GetString("dtpRecogida.RootElement.AccessibleDescription")
            Me.dtpRecogida.RootElement.AccessibleName = resources.GetString("dtpRecogida.RootElement.AccessibleName")
            Me.dtpRecogida.RootElement.Alignment = CType(resources.GetObject("dtpRecogida.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.dtpRecogida.RootElement.AngleTransform = CType(resources.GetObject("dtpRecogida.RootElement.AngleTransform"), Single)
            Me.dtpRecogida.RootElement.FlipText = CType(resources.GetObject("dtpRecogida.RootElement.FlipText"), Boolean)
            Me.dtpRecogida.RootElement.Margin = CType(resources.GetObject("dtpRecogida.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.dtpRecogida.RootElement.Text = resources.GetString("dtpRecogida.RootElement.Text")
            Me.dtpRecogida.RootElement.TextOrientation = CType(resources.GetObject("dtpRecogida.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.dtpRecogida.TabStop = False
            Me.dtpRecogida.Value = New Date(CType(0, Long))
            '
            'txtProducto
            '
            Me.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncargoBindingSource, "Descripcion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtProducto, "txtProducto")
            Me.txtProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtProducto.Name = "txtProducto"
            '
            '
            '
            Me.txtProducto.RootElement.AccessibleDescription = resources.GetString("txtProducto.RootElement.AccessibleDescription")
            Me.txtProducto.RootElement.AccessibleName = resources.GetString("txtProducto.RootElement.AccessibleName")
            Me.txtProducto.RootElement.Alignment = CType(resources.GetObject("txtProducto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtProducto.RootElement.AngleTransform = CType(resources.GetObject("txtProducto.RootElement.AngleTransform"), Single)
            Me.txtProducto.RootElement.FlipText = CType(resources.GetObject("txtProducto.RootElement.FlipText"), Boolean)
            Me.txtProducto.RootElement.Margin = CType(resources.GetObject("txtProducto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtProducto.RootElement.Text = resources.GetString("txtProducto.RootElement.Text")
            Me.txtProducto.RootElement.TextOrientation = CType(resources.GetObject("txtProducto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtProducto.Tag = ""
            CType(Me.txtProducto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text2")
            CType(Me.txtProducto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtProducto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtProducto.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtProducto.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtProducto.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'txtReferencia
            '
            Me.txtReferencia.BackColor = System.Drawing.Color.White
            Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtReferencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncargoBindingSource, "Referencia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
            Me.txtReferencia.RootElement.Text = resources.GetString("txtReferencia.RootElement.Text")
            Me.txtReferencia.RootElement.TextOrientation = CType(resources.GetObject("txtReferencia.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtReferencia.Tag = ""
            CType(Me.txtReferencia.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text3")
            CType(Me.txtReferencia.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtReferencia.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.White
            CType(Me.txtReferencia.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtReferencia.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtReferencia.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.White
            '
            'btnCancelarEncargo
            '
            resources.ApplyResources(Me.btnCancelarEncargo, "btnCancelarEncargo")
            Me.btnCancelarEncargo.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancelarEncargo.Image = Global.EasyGest.My.Resources.Resources.cancel
            Me.btnCancelarEncargo.Name = "btnCancelarEncargo"
            '
            '
            '
            Me.btnCancelarEncargo.RootElement.AccessibleDescription = resources.GetString("btnCancelarEncargo.RootElement.AccessibleDescription")
            Me.btnCancelarEncargo.RootElement.AccessibleName = resources.GetString("btnCancelarEncargo.RootElement.AccessibleName")
            Me.btnCancelarEncargo.RootElement.Alignment = CType(resources.GetObject("btnCancelarEncargo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnCancelarEncargo.RootElement.AngleTransform = CType(resources.GetObject("btnCancelarEncargo.RootElement.AngleTransform"), Single)
            Me.btnCancelarEncargo.RootElement.FlipText = CType(resources.GetObject("btnCancelarEncargo.RootElement.FlipText"), Boolean)
            Me.btnCancelarEncargo.RootElement.Margin = CType(resources.GetObject("btnCancelarEncargo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnCancelarEncargo.RootElement.Text = resources.GetString("btnCancelarEncargo.RootElement.Text")
            Me.btnCancelarEncargo.RootElement.TextOrientation = CType(resources.GetObject("btnCancelarEncargo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.btnCancelarEncargo.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.cancel
            CType(Me.btnCancelarEncargo.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnCancelarEncargo.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnCancelarEncargo.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            CType(Me.btnCancelarEncargo.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text4")
            CType(Me.btnCancelarEncargo.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(10, Byte), Integer))
            '
            'btnAceptarEncargo
            '
            resources.ApplyResources(Me.btnAceptarEncargo, "btnAceptarEncargo")
            Me.btnAceptarEncargo.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnAceptarEncargo.Image = Global.EasyGest.My.Resources.Resources.accept
            Me.btnAceptarEncargo.Name = "btnAceptarEncargo"
            '
            '
            '
            Me.btnAceptarEncargo.RootElement.AccessibleDescription = resources.GetString("btnAceptarEncargo.RootElement.AccessibleDescription")
            Me.btnAceptarEncargo.RootElement.AccessibleName = resources.GetString("btnAceptarEncargo.RootElement.AccessibleName")
            Me.btnAceptarEncargo.RootElement.Alignment = CType(resources.GetObject("btnAceptarEncargo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnAceptarEncargo.RootElement.AngleTransform = CType(resources.GetObject("btnAceptarEncargo.RootElement.AngleTransform"), Single)
            Me.btnAceptarEncargo.RootElement.FlipText = CType(resources.GetObject("btnAceptarEncargo.RootElement.FlipText"), Boolean)
            Me.btnAceptarEncargo.RootElement.Margin = CType(resources.GetObject("btnAceptarEncargo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnAceptarEncargo.RootElement.Text = resources.GetString("btnAceptarEncargo.RootElement.Text")
            Me.btnAceptarEncargo.RootElement.TextOrientation = CType(resources.GetObject("btnAceptarEncargo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.btnAceptarEncargo.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.accept
            CType(Me.btnAceptarEncargo.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnAceptarEncargo.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnAceptarEncargo.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            CType(Me.btnAceptarEncargo.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text5")
            CType(Me.btnAceptarEncargo.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
            '
            'chkSuspendido
            '
            Me.chkSuspendido.DataBindings.Add(New System.Windows.Forms.Binding("IsChecked", Me.EncargoBindingSource, "Suspendido", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.chkSuspendido, "chkSuspendido")
            Me.chkSuspendido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.chkSuspendido.Name = "chkSuspendido"
            '
            '
            '
            Me.chkSuspendido.RootElement.AccessibleDescription = resources.GetString("chkSuspendido.RootElement.AccessibleDescription")
            Me.chkSuspendido.RootElement.AccessibleName = resources.GetString("chkSuspendido.RootElement.AccessibleName")
            Me.chkSuspendido.RootElement.Alignment = CType(resources.GetObject("chkSuspendido.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.chkSuspendido.RootElement.AngleTransform = CType(resources.GetObject("chkSuspendido.RootElement.AngleTransform"), Single)
            Me.chkSuspendido.RootElement.FlipText = CType(resources.GetObject("chkSuspendido.RootElement.FlipText"), Boolean)
            Me.chkSuspendido.RootElement.Margin = CType(resources.GetObject("chkSuspendido.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.chkSuspendido.RootElement.Text = resources.GetString("chkSuspendido.RootElement.Text")
            Me.chkSuspendido.RootElement.TextOrientation = CType(resources.GetObject("chkSuspendido.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'txtObservacion
            '
            Me.txtObservacion.AcceptsReturn = True
            resources.ApplyResources(Me.txtObservacion, "txtObservacion")
            Me.txtObservacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EncargoBindingSource, "Observacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
            Me.txtObservacion.RootElement.Text = resources.GetString("txtObservacion.RootElement.Text")
            Me.txtObservacion.RootElement.TextOrientation = CType(resources.GetObject("txtObservacion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtObservacion.Tag = ""
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text6")
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = True
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'cbListaCompra
            '
            resources.ApplyResources(Me.cbListaCompra, "cbListaCompra")
            Me.cbListaCompra.Name = "cbListaCompra"
            '
            '
            '
            Me.cbListaCompra.RootElement.AccessibleDescription = resources.GetString("cbListaCompra.RootElement.AccessibleDescription")
            Me.cbListaCompra.RootElement.AccessibleName = resources.GetString("cbListaCompra.RootElement.AccessibleName")
            Me.cbListaCompra.RootElement.Alignment = CType(resources.GetObject("cbListaCompra.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.cbListaCompra.RootElement.AngleTransform = CType(resources.GetObject("cbListaCompra.RootElement.AngleTransform"), Single)
            Me.cbListaCompra.RootElement.FlipText = CType(resources.GetObject("cbListaCompra.RootElement.FlipText"), Boolean)
            Me.cbListaCompra.RootElement.Margin = CType(resources.GetObject("cbListaCompra.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.cbListaCompra.RootElement.Text = resources.GetString("cbListaCompra.RootElement.Text")
            Me.cbListaCompra.RootElement.TextOrientation = CType(resources.GetObject("cbListaCompra.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.cbListaCompra.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
            '
            'CommandBarRowElement1
            '
            resources.ApplyResources(Me.CommandBarRowElement1, "CommandBarRowElement1")
            Me.CommandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
            Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.cbstripListasCompra})
            Me.CommandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            '
            'cbstripListasCompra
            '
            resources.ApplyResources(Me.cbstripListasCompra, "cbstripListasCompra")
            Me.cbstripListasCompra.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.cbstripListasCompra.DrawText = True
            '
            '
            '
            Me.cbstripListasCompra.Grip.AccessibleDescription = resources.GetString("resource.AccessibleDescription")
            Me.cbstripListasCompra.Grip.AccessibleName = resources.GetString("resource.AccessibleName")
            Me.cbstripListasCompra.Grip.Alignment = CType(resources.GetObject("resource.Alignment"), System.Drawing.ContentAlignment)
            Me.cbstripListasCompra.Grip.AngleTransform = CType(resources.GetObject("resource.AngleTransform1"), Single)
            Me.cbstripListasCompra.Grip.FlipText = CType(resources.GetObject("resource.FlipText"), Boolean)
            Me.cbstripListasCompra.Grip.Margin = CType(resources.GetObject("resource.Margin"), System.Windows.Forms.Padding)
            Me.cbstripListasCompra.Grip.Padding = CType(resources.GetObject("resource.Padding1"), System.Windows.Forms.Padding)
            Me.cbstripListasCompra.Grip.RightToLeft = CType(resources.GetObject("resource.RightToLeft"), Boolean)
            Me.cbstripListasCompra.Grip.Text = resources.GetString("resource.Text7")
            Me.cbstripListasCompra.Grip.TextOrientation = CType(resources.GetObject("resource.TextOrientation"), System.Windows.Forms.Orientation)
            Me.cbstripListasCompra.Grip.TextWrap = CType(resources.GetObject("resource.TextWrap"), Boolean)
            Me.cbstripListasCompra.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbtnAgregarEncargo, Me.cbbtnEditarEncargo, Me.CommandBarSeparator1, Me.cbddbRecargarLista, Me.cbbtnImprimirLista})
            Me.cbstripListasCompra.Name = "CommandBarStripElement1"
            '
            '
            '
            Me.cbstripListasCompra.OverflowButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1")
            Me.cbstripListasCompra.OverflowButton.AccessibleName = resources.GetString("resource.AccessibleName1")
            Me.cbstripListasCompra.OverflowButton.Alignment = CType(resources.GetObject("resource.Alignment1"), System.Drawing.ContentAlignment)
            Me.cbstripListasCompra.OverflowButton.AngleTransform = CType(resources.GetObject("resource.AngleTransform2"), Single)
            Me.cbstripListasCompra.OverflowButton.FlipText = CType(resources.GetObject("resource.FlipText1"), Boolean)
            Me.cbstripListasCompra.OverflowButton.Margin = CType(resources.GetObject("resource.Margin1"), System.Windows.Forms.Padding)
            Me.cbstripListasCompra.OverflowButton.Padding = CType(resources.GetObject("resource.Padding2"), System.Windows.Forms.Padding)
            Me.cbstripListasCompra.OverflowButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft1"), Boolean)
            Me.cbstripListasCompra.OverflowButton.Text = resources.GetString("resource.Text8")
            Me.cbstripListasCompra.OverflowButton.TextOrientation = CType(resources.GetObject("resource.TextOrientation1"), System.Windows.Forms.Orientation)
            Me.cbstripListasCompra.OverflowButton.TextWrap = CType(resources.GetObject("resource.TextWrap1"), Boolean)
            Me.cbstripListasCompra.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            CType(Me.cbstripListasCompra.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextWrap = CType(resources.GetObject("resource.TextWrap2"), Boolean)
            CType(Me.cbstripListasCompra.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextOrientation = CType(resources.GetObject("resource.TextOrientation2"), System.Windows.Forms.Orientation)
            CType(Me.cbstripListasCompra.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).FlipText = CType(resources.GetObject("resource.FlipText2"), Boolean)
            CType(Me.cbstripListasCompra.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Text = resources.GetString("resource.Text9")
            CType(Me.cbstripListasCompra.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Padding = CType(resources.GetObject("resource.Padding3"), System.Windows.Forms.Padding)
            CType(Me.cbstripListasCompra.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Margin = CType(resources.GetObject("resource.Margin2"), System.Windows.Forms.Padding)
            CType(Me.cbstripListasCompra.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Alignment = CType(resources.GetObject("resource.Alignment2"), System.Drawing.ContentAlignment)
            CType(Me.cbstripListasCompra.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).RightToLeft = CType(resources.GetObject("resource.RightToLeft2"), Boolean)
            CType(Me.cbstripListasCompra.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).AngleTransform = CType(resources.GetObject("resource.AngleTransform3"), Single)
            CType(Me.cbstripListasCompra.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextWrap = CType(resources.GetObject("resource.TextWrap3"), Boolean)
            CType(Me.cbstripListasCompra.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextOrientation = CType(resources.GetObject("resource.TextOrientation3"), System.Windows.Forms.Orientation)
            CType(Me.cbstripListasCompra.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).FlipText = CType(resources.GetObject("resource.FlipText3"), Boolean)
            CType(Me.cbstripListasCompra.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Text = resources.GetString("resource.Text10")
            CType(Me.cbstripListasCompra.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Padding = CType(resources.GetObject("resource.Padding4"), System.Windows.Forms.Padding)
            CType(Me.cbstripListasCompra.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Margin = CType(resources.GetObject("resource.Margin3"), System.Windows.Forms.Padding)
            CType(Me.cbstripListasCompra.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Alignment = CType(resources.GetObject("resource.Alignment3"), System.Drawing.ContentAlignment)
            CType(Me.cbstripListasCompra.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).RightToLeft = CType(resources.GetObject("resource.RightToLeft3"), Boolean)
            CType(Me.cbstripListasCompra.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).AngleTransform = CType(resources.GetObject("resource.AngleTransform4"), Single)
            '
            'cbbtnAgregarEncargo
            '
            resources.ApplyResources(Me.cbbtnAgregarEncargo, "cbbtnAgregarEncargo")
            Me.cbbtnAgregarEncargo.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.cbbtnAgregarEncargo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnAgregarEncargo.Image = CType(resources.GetObject("cbbtnAgregarEncargo.Image"), System.Drawing.Image)
            Me.cbbtnAgregarEncargo.Name = "cbbtnAgregarEncargo"
            Me.cbbtnAgregarEncargo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            '
            'cbbtnEditarEncargo
            '
            resources.ApplyResources(Me.cbbtnEditarEncargo, "cbbtnEditarEncargo")
            Me.cbbtnEditarEncargo.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.cbbtnEditarEncargo.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnEditarEncargo.Image = CType(resources.GetObject("cbbtnEditarEncargo.Image"), System.Drawing.Image)
            Me.cbbtnEditarEncargo.Name = "cbbtnEditarEncargo"
            Me.cbbtnEditarEncargo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            '
            'CommandBarSeparator1
            '
            resources.ApplyResources(Me.CommandBarSeparator1, "CommandBarSeparator1")
            Me.CommandBarSeparator1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
            Me.CommandBarSeparator1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.CommandBarSeparator1.VisibleInOverflowMenu = False
            '
            'cbddbRecargarLista
            '
            resources.ApplyResources(Me.cbddbRecargarLista, "cbddbRecargarLista")
            Me.cbddbRecargarLista.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.cbddbRecargarLista.Image = Global.EasyGest.My.Resources.Resources.arrow_refresh
            Me.cbddbRecargarLista.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mnitemReciente, Me.mnitemTodas})
            Me.cbddbRecargarLista.Name = "cbddbRecargarLista"
            Me.cbddbRecargarLista.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            '
            'mnitemReciente
            '
            resources.ApplyResources(Me.mnitemReciente, "mnitemReciente")
            Me.mnitemReciente.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
            Me.mnitemReciente.Font = New System.Drawing.Font("KaiTi", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mnitemReciente.Name = "mnitemReciente"
            '
            'mnitemTodas
            '
            resources.ApplyResources(Me.mnitemTodas, "mnitemTodas")
            Me.mnitemTodas.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
            Me.mnitemTodas.Font = New System.Drawing.Font("KaiTi", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mnitemTodas.Name = "mnitemTodas"
            '
            'cbbtnImprimirLista
            '
            resources.ApplyResources(Me.cbbtnImprimirLista, "cbbtnImprimirLista")
            Me.cbbtnImprimirLista.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            Me.cbbtnImprimirLista.Font = New System.Drawing.Font("KaiTi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnImprimirLista.Image = CType(resources.GetObject("cbbtnImprimirLista.Image"), System.Drawing.Image)
            Me.cbbtnImprimirLista.Name = "cbbtnImprimirLista"
            Me.cbbtnImprimirLista.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            '
            'gboxTarea
            '
            gboxTarea.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            gboxTarea.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
            gboxTarea.Controls.Add(Me.btnCancelarTarea)
            gboxTarea.Controls.Add(Me.btnAceptarTarea)
            gboxTarea.Controls.Add(Me.txtTarea)
            gboxTarea.Controls.Add(Me.ddlAviso)
            gboxTarea.Controls.Add(Me.ddlPrioridadTarea)
            gboxTarea.Controls.Add(RadLabel7)
            gboxTarea.Controls.Add(RadLabel8)
            gboxTarea.Controls.Add(RadLabel5)
            gboxTarea.Controls.Add(Me.dtpTiempoAviso)
            gboxTarea.Controls.Add(RadLabel4)
            gboxTarea.Controls.Add(Me.dtpFechaTarea)
            resources.ApplyResources(gboxTarea, "gboxTarea")
            gboxTarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            gboxTarea.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            gboxTarea.HeaderImage = Global.EasyGest.My.Resources.Resources._date
            gboxTarea.HeaderTextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            gboxTarea.Name = "gboxTarea"
            '
            '
            '
            gboxTarea.RootElement.AccessibleDescription = resources.GetString("gboxTarea.RootElement.AccessibleDescription")
            gboxTarea.RootElement.AccessibleName = resources.GetString("gboxTarea.RootElement.AccessibleName")
            gboxTarea.RootElement.Alignment = CType(resources.GetObject("gboxTarea.RootElement.Alignment"), System.Drawing.ContentAlignment)
            gboxTarea.RootElement.AngleTransform = CType(resources.GetObject("gboxTarea.RootElement.AngleTransform"), Single)
            gboxTarea.RootElement.FlipText = CType(resources.GetObject("gboxTarea.RootElement.FlipText"), Boolean)
            gboxTarea.RootElement.Margin = CType(resources.GetObject("gboxTarea.RootElement.Margin"), System.Windows.Forms.Padding)
            gboxTarea.RootElement.MinSize = New System.Drawing.Size(0, 0)
            gboxTarea.RootElement.Text = resources.GetString("gboxTarea.RootElement.Text")
            gboxTarea.RootElement.TextOrientation = CType(resources.GetObject("gboxTarea.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(gboxTarea.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            CType(gboxTarea.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'btnCancelarTarea
            '
            resources.ApplyResources(Me.btnCancelarTarea, "btnCancelarTarea")
            Me.btnCancelarTarea.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancelarTarea.Image = Global.EasyGest.My.Resources.Resources.cancel
            Me.btnCancelarTarea.Name = "btnCancelarTarea"
            '
            '
            '
            Me.btnCancelarTarea.RootElement.AccessibleDescription = resources.GetString("btnCancelarTarea.RootElement.AccessibleDescription")
            Me.btnCancelarTarea.RootElement.AccessibleName = resources.GetString("btnCancelarTarea.RootElement.AccessibleName")
            Me.btnCancelarTarea.RootElement.Alignment = CType(resources.GetObject("btnCancelarTarea.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnCancelarTarea.RootElement.AngleTransform = CType(resources.GetObject("btnCancelarTarea.RootElement.AngleTransform"), Single)
            Me.btnCancelarTarea.RootElement.FlipText = CType(resources.GetObject("btnCancelarTarea.RootElement.FlipText"), Boolean)
            Me.btnCancelarTarea.RootElement.Margin = CType(resources.GetObject("btnCancelarTarea.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnCancelarTarea.RootElement.Text = resources.GetString("btnCancelarTarea.RootElement.Text")
            Me.btnCancelarTarea.RootElement.TextOrientation = CType(resources.GetObject("btnCancelarTarea.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.btnCancelarTarea.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.cancel
            CType(Me.btnCancelarTarea.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnCancelarTarea.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnCancelarTarea.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            CType(Me.btnCancelarTarea.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text11")
            CType(Me.btnCancelarTarea.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(10, Byte), Integer))
            '
            'btnAceptarTarea
            '
            resources.ApplyResources(Me.btnAceptarTarea, "btnAceptarTarea")
            Me.btnAceptarTarea.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.btnAceptarTarea.Image = Global.EasyGest.My.Resources.Resources.accept
            Me.btnAceptarTarea.Name = "btnAceptarTarea"
            '
            '
            '
            Me.btnAceptarTarea.RootElement.AccessibleDescription = resources.GetString("btnAceptarTarea.RootElement.AccessibleDescription")
            Me.btnAceptarTarea.RootElement.AccessibleName = resources.GetString("btnAceptarTarea.RootElement.AccessibleName")
            Me.btnAceptarTarea.RootElement.Alignment = CType(resources.GetObject("btnAceptarTarea.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnAceptarTarea.RootElement.AngleTransform = CType(resources.GetObject("btnAceptarTarea.RootElement.AngleTransform"), Single)
            Me.btnAceptarTarea.RootElement.FlipText = CType(resources.GetObject("btnAceptarTarea.RootElement.FlipText"), Boolean)
            Me.btnAceptarTarea.RootElement.Margin = CType(resources.GetObject("btnAceptarTarea.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnAceptarTarea.RootElement.Text = resources.GetString("btnAceptarTarea.RootElement.Text")
            Me.btnAceptarTarea.RootElement.TextOrientation = CType(resources.GetObject("btnAceptarTarea.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.btnAceptarTarea.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.accept
            CType(Me.btnAceptarTarea.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnAceptarTarea.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnAceptarTarea.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            CType(Me.btnAceptarTarea.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text12")
            CType(Me.btnAceptarTarea.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
            '
            'txtTarea
            '
            Me.txtTarea.AcceptsReturn = True
            resources.ApplyResources(Me.txtTarea, "txtTarea")
            Me.txtTarea.BackColor = System.Drawing.Color.White
            Me.txtTarea.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TareaBindingSource, "Tarea", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.txtTarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtTarea.Multiline = True
            Me.txtTarea.Name = "txtTarea"
            '
            '
            '
            Me.txtTarea.RootElement.AccessibleDescription = resources.GetString("txtTarea.RootElement.AccessibleDescription")
            Me.txtTarea.RootElement.AccessibleName = resources.GetString("txtTarea.RootElement.AccessibleName")
            Me.txtTarea.RootElement.Alignment = CType(resources.GetObject("txtTarea.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtTarea.RootElement.AngleTransform = CType(resources.GetObject("txtTarea.RootElement.AngleTransform"), Single)
            Me.txtTarea.RootElement.ApplyShapeToControl = False
            Me.txtTarea.RootElement.FlipText = CType(resources.GetObject("txtTarea.RootElement.FlipText"), Boolean)
            Me.txtTarea.RootElement.Margin = CType(resources.GetObject("txtTarea.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtTarea.RootElement.Text = resources.GetString("txtTarea.RootElement.Text")
            Me.txtTarea.RootElement.TextOrientation = CType(resources.GetObject("txtTarea.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtTarea.Tag = ""
            CType(Me.txtTarea.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text13")
            CType(Me.txtTarea.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtTarea.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.White
            CType(Me.txtTarea.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = True
            CType(Me.txtTarea.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtTarea.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
            CType(Me.txtTarea.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtTarea.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.White
            '
            'TareaBindingSource
            '
            Me.TareaBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Tareas)
            '
            'ddlAviso
            '
            resources.ApplyResources(Me.ddlAviso, "ddlAviso")
            Me.ddlAviso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ddlAviso.BackColor = System.Drawing.Color.White
            Me.ddlAviso.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TareaBindingSource, "AvisoAntelacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlAviso.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlAviso.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
            Me.ddlAviso.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.ddlAviso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlAviso.Name = "ddlAviso"
            '
            '
            '
            Me.ddlAviso.RootElement.AccessibleDescription = resources.GetString("ddlAviso.RootElement.AccessibleDescription")
            Me.ddlAviso.RootElement.AccessibleName = resources.GetString("ddlAviso.RootElement.AccessibleName")
            Me.ddlAviso.RootElement.Alignment = CType(resources.GetObject("ddlAviso.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlAviso.RootElement.AngleTransform = CType(resources.GetObject("ddlAviso.RootElement.AngleTransform"), Single)
            Me.ddlAviso.RootElement.FlipText = CType(resources.GetObject("ddlAviso.RootElement.FlipText"), Boolean)
            Me.ddlAviso.RootElement.Margin = CType(resources.GetObject("ddlAviso.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlAviso.RootElement.Text = resources.GetString("ddlAviso.RootElement.Text")
            Me.ddlAviso.RootElement.TextOrientation = CType(resources.GetObject("ddlAviso.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.ddlAviso.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            '
            'ddlPrioridadTarea
            '
            resources.ApplyResources(Me.ddlPrioridadTarea, "ddlPrioridadTarea")
            Me.ddlPrioridadTarea.AutoCompleteDisplayMember = "Prioridad"
            Me.ddlPrioridadTarea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ddlPrioridadTarea.AutoCompleteValueMember = "PrioridadID"
            Me.ddlPrioridadTarea.BackColor = System.Drawing.Color.White
            Me.ddlPrioridadTarea.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TareaBindingSource, "Prioridad", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlPrioridadTarea.DataSource = Me.PrioridadesTareaBindingSource
            Me.ddlPrioridadTarea.DisplayMember = "Prioridad"
            Me.ddlPrioridadTarea.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlPrioridadTarea.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
            Me.ddlPrioridadTarea.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.ddlPrioridadTarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlPrioridadTarea.Name = "ddlPrioridadTarea"
            '
            '
            '
            Me.ddlPrioridadTarea.RootElement.AccessibleDescription = resources.GetString("ddlPrioridadTarea.RootElement.AccessibleDescription")
            Me.ddlPrioridadTarea.RootElement.AccessibleName = resources.GetString("ddlPrioridadTarea.RootElement.AccessibleName")
            Me.ddlPrioridadTarea.RootElement.Alignment = CType(resources.GetObject("ddlPrioridadTarea.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlPrioridadTarea.RootElement.AngleTransform = CType(resources.GetObject("ddlPrioridadTarea.RootElement.AngleTransform"), Single)
            Me.ddlPrioridadTarea.RootElement.FlipText = CType(resources.GetObject("ddlPrioridadTarea.RootElement.FlipText"), Boolean)
            Me.ddlPrioridadTarea.RootElement.Margin = CType(resources.GetObject("ddlPrioridadTarea.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlPrioridadTarea.RootElement.Text = resources.GetString("ddlPrioridadTarea.RootElement.Text")
            Me.ddlPrioridadTarea.RootElement.TextOrientation = CType(resources.GetObject("ddlPrioridadTarea.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ddlPrioridadTarea.ValueMember = "PrioridadID"
            CType(Me.ddlPrioridadTarea.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            '
            'PrioridadesTareaBindingSource
            '
            Me.PrioridadesTareaBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.PrioridadesTarea)
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
            RadLabel8.RootElement.Text = resources.GetString("RadLabel8.RootElement.Text")
            RadLabel8.RootElement.TextOrientation = CType(resources.GetObject("RadLabel8.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel5.RootElement.Text = resources.GetString("RadLabel5.RootElement.Text")
            RadLabel5.RootElement.TextOrientation = CType(resources.GetObject("RadLabel5.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'dtpTiempoAviso
            '
            resources.ApplyResources(Me.dtpTiempoAviso, "dtpTiempoAviso")
            Me.dtpTiempoAviso.BackColor = System.Drawing.Color.White
            Me.dtpTiempoAviso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TareaBindingSource, "Aviso", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "g"))
            Me.dtpTiempoAviso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.dtpTiempoAviso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpTiempoAviso.Name = "dtpTiempoAviso"
            Me.dtpTiempoAviso.ReadOnly = True
            '
            '
            '
            Me.dtpTiempoAviso.RootElement.AccessibleDescription = resources.GetString("dtpTiempoAviso.RootElement.AccessibleDescription")
            Me.dtpTiempoAviso.RootElement.AccessibleName = resources.GetString("dtpTiempoAviso.RootElement.AccessibleName")
            Me.dtpTiempoAviso.RootElement.Alignment = CType(resources.GetObject("dtpTiempoAviso.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.dtpTiempoAviso.RootElement.AngleTransform = CType(resources.GetObject("dtpTiempoAviso.RootElement.AngleTransform"), Single)
            Me.dtpTiempoAviso.RootElement.FlipText = CType(resources.GetObject("dtpTiempoAviso.RootElement.FlipText"), Boolean)
            Me.dtpTiempoAviso.RootElement.Margin = CType(resources.GetObject("dtpTiempoAviso.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.dtpTiempoAviso.RootElement.Text = resources.GetString("dtpTiempoAviso.RootElement.Text")
            Me.dtpTiempoAviso.RootElement.TextOrientation = CType(resources.GetObject("dtpTiempoAviso.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.dtpTiempoAviso.TabStop = False
            Me.dtpTiempoAviso.Value = New Date(CType(0, Long))
            CType(Me.dtpTiempoAviso.GetChildAt(0), Telerik.WinControls.UI.RadDateTimePickerElement).Text = resources.GetString("resource.Text14")
            CType(Me.dtpTiempoAviso.GetChildAt(0), Telerik.WinControls.UI.RadDateTimePickerElement).BackColor = System.Drawing.Color.White
            CType(Me.dtpTiempoAviso.GetChildAt(0).GetChildAt(2).GetChildAt(2), Telerik.WinControls.UI.RadDateTimePickerArrowButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            '
            'dtpFechaTarea
            '
            resources.ApplyResources(Me.dtpFechaTarea, "dtpFechaTarea")
            Me.dtpFechaTarea.BackColor = System.Drawing.Color.White
            Me.dtpFechaTarea.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TareaBindingSource, "FechaTarea", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "g"))
            Me.dtpFechaTarea.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.dtpFechaTarea.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpFechaTarea.Name = "dtpFechaTarea"
            '
            '
            '
            Me.dtpFechaTarea.RootElement.AccessibleDescription = resources.GetString("dtpFechaTarea.RootElement.AccessibleDescription")
            Me.dtpFechaTarea.RootElement.AccessibleName = resources.GetString("dtpFechaTarea.RootElement.AccessibleName")
            Me.dtpFechaTarea.RootElement.Alignment = CType(resources.GetObject("dtpFechaTarea.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.dtpFechaTarea.RootElement.AngleTransform = CType(resources.GetObject("dtpFechaTarea.RootElement.AngleTransform"), Single)
            Me.dtpFechaTarea.RootElement.FlipText = CType(resources.GetObject("dtpFechaTarea.RootElement.FlipText"), Boolean)
            Me.dtpFechaTarea.RootElement.Margin = CType(resources.GetObject("dtpFechaTarea.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.dtpFechaTarea.RootElement.Text = resources.GetString("dtpFechaTarea.RootElement.Text")
            Me.dtpFechaTarea.RootElement.TextOrientation = CType(resources.GetObject("dtpFechaTarea.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.dtpFechaTarea.TabStop = False
            Me.dtpFechaTarea.Value = New Date(CType(0, Long))
            '
            'RadPanel2
            '
            RadPanel2.Controls.Add(Me.waitbDivisa)
            RadPanel2.Controls.Add(Me.btnActualizarDivisa)
            RadPanel2.Controls.Add(RadLabel1)
            RadPanel2.Controls.Add(Me.trbDivisa)
            RadPanel2.Controls.Add(Me.wbwDivisa)
            resources.ApplyResources(RadPanel2, "RadPanel2")
            RadPanel2.Name = "RadPanel2"
            '
            '
            '
            RadPanel2.RootElement.AccessibleDescription = resources.GetString("RadPanel2.RootElement.AccessibleDescription")
            RadPanel2.RootElement.AccessibleName = resources.GetString("RadPanel2.RootElement.AccessibleName")
            RadPanel2.RootElement.Alignment = CType(resources.GetObject("RadPanel2.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadPanel2.RootElement.AngleTransform = CType(resources.GetObject("RadPanel2.RootElement.AngleTransform"), Single)
            RadPanel2.RootElement.FlipText = CType(resources.GetObject("RadPanel2.RootElement.FlipText"), Boolean)
            RadPanel2.RootElement.Margin = CType(resources.GetObject("RadPanel2.RootElement.Margin"), System.Windows.Forms.Padding)
            RadPanel2.RootElement.Text = resources.GetString("RadPanel2.RootElement.Text")
            RadPanel2.RootElement.TextOrientation = CType(resources.GetObject("RadPanel2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'waitbDivisa
            '
            resources.ApplyResources(Me.waitbDivisa, "waitbDivisa")
            Me.waitbDivisa.Name = "waitbDivisa"
            '
            '
            '
            Me.waitbDivisa.RootElement.AccessibleDescription = resources.GetString("waitbDivisa.RootElement.AccessibleDescription")
            Me.waitbDivisa.RootElement.AccessibleName = resources.GetString("waitbDivisa.RootElement.AccessibleName")
            Me.waitbDivisa.RootElement.Alignment = CType(resources.GetObject("waitbDivisa.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.waitbDivisa.RootElement.AngleTransform = CType(resources.GetObject("waitbDivisa.RootElement.AngleTransform"), Single)
            Me.waitbDivisa.RootElement.FlipText = CType(resources.GetObject("waitbDivisa.RootElement.FlipText"), Boolean)
            Me.waitbDivisa.RootElement.Margin = CType(resources.GetObject("waitbDivisa.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.waitbDivisa.RootElement.Text = resources.GetString("waitbDivisa.RootElement.Text")
            Me.waitbDivisa.RootElement.TextOrientation = CType(resources.GetObject("waitbDivisa.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.waitbDivisa.WaitingSpeed = 80
            Me.waitbDivisa.WaitingStep = 10
            Me.waitbDivisa.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Throbber
            '
            'btnActualizarDivisa
            '
            resources.ApplyResources(Me.btnActualizarDivisa, "btnActualizarDivisa")
            Me.btnActualizarDivisa.Name = "btnActualizarDivisa"
            '
            '
            '
            Me.btnActualizarDivisa.RootElement.AccessibleDescription = resources.GetString("btnActualizarDivisa.RootElement.AccessibleDescription")
            Me.btnActualizarDivisa.RootElement.AccessibleName = resources.GetString("btnActualizarDivisa.RootElement.AccessibleName")
            Me.btnActualizarDivisa.RootElement.Alignment = CType(resources.GetObject("btnActualizarDivisa.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnActualizarDivisa.RootElement.AngleTransform = CType(resources.GetObject("btnActualizarDivisa.RootElement.AngleTransform"), Single)
            Me.btnActualizarDivisa.RootElement.FlipText = CType(resources.GetObject("btnActualizarDivisa.RootElement.FlipText"), Boolean)
            Me.btnActualizarDivisa.RootElement.Margin = CType(resources.GetObject("btnActualizarDivisa.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnActualizarDivisa.RootElement.Text = resources.GetString("btnActualizarDivisa.RootElement.Text")
            Me.btnActualizarDivisa.RootElement.TextOrientation = CType(resources.GetObject("btnActualizarDivisa.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel1.RootElement.Text = resources.GetString("RadLabel1.RootElement.Text")
            RadLabel1.RootElement.TextOrientation = CType(resources.GetObject("RadLabel1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'trbDivisa
            '
            resources.ApplyResources(Me.trbDivisa, "trbDivisa")
            Me.trbDivisa.BackColor = System.Drawing.Color.Transparent
            Me.trbDivisa.LabelStyle = Telerik.WinControls.UI.TrackBarLabelStyle.TopLeft
            Me.trbDivisa.LargeChange = 1
            Me.trbDivisa.LargeTickFrequency = 1
            Me.trbDivisa.Maximum = 6.0!
            Me.trbDivisa.Minimum = 1.0!
            Me.trbDivisa.Name = "trbDivisa"
            '
            '
            '
            Me.trbDivisa.RootElement.AccessibleDescription = resources.GetString("trbDivisa.RootElement.AccessibleDescription")
            Me.trbDivisa.RootElement.AccessibleName = resources.GetString("trbDivisa.RootElement.AccessibleName")
            Me.trbDivisa.RootElement.Alignment = CType(resources.GetObject("trbDivisa.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.trbDivisa.RootElement.AngleTransform = CType(resources.GetObject("trbDivisa.RootElement.AngleTransform"), Single)
            Me.trbDivisa.RootElement.FlipText = CType(resources.GetObject("trbDivisa.RootElement.FlipText"), Boolean)
            Me.trbDivisa.RootElement.Margin = CType(resources.GetObject("trbDivisa.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.trbDivisa.RootElement.Text = resources.GetString("trbDivisa.RootElement.Text")
            Me.trbDivisa.RootElement.TextOrientation = CType(resources.GetObject("trbDivisa.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.trbDivisa.ShowSlideArea = False
            Me.trbDivisa.TickStyle = Telerik.WinControls.Enumerations.TickStyles.None
            Me.trbDivisa.Value = 6.0!
            CType(Me.trbDivisa.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).BackColor = System.Drawing.Color.Transparent
            CType(Me.trbDivisa.GetChildAt(0), Telerik.WinControls.UI.RadTrackBarElement).MinSize = New System.Drawing.Size(100, 0)
            '
            'wbwDivisa
            '
            resources.ApplyResources(Me.wbwDivisa, "wbwDivisa")
            Me.wbwDivisa.Name = "wbwDivisa"
            Me.wbwDivisa.TabStop = False
            Me.wbwDivisa.Url = New System.Uri("", System.UriKind.Relative)
            Me.wbwDivisa.WebBrowserShortcutsEnabled = False
            '
            'toolDivisa
            '
            toolDivisa.Caption = Nothing
            toolDivisa.Controls.Add(RadPanel2)
            toolDivisa.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
            resources.ApplyResources(toolDivisa, "toolDivisa")
            toolDivisa.Name = "toolDivisa"
            toolDivisa.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            toolDivisa.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
            '
            'toolReloj
            '
            toolReloj.Caption = Nothing
            toolReloj.Controls.Add(Me.RadClock1)
            toolReloj.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
            resources.ApplyResources(toolReloj, "toolReloj")
            toolReloj.Name = "toolReloj"
            toolReloj.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            toolReloj.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
            '
            'RadClock1
            '
            resources.ApplyResources(Me.RadClock1, "RadClock1")
            Me.RadClock1.Name = "RadClock1"
            '
            '
            '
            Me.RadClock1.RootElement.AccessibleDescription = resources.GetString("RadClock1.RootElement.AccessibleDescription")
            Me.RadClock1.RootElement.AccessibleName = resources.GetString("RadClock1.RootElement.AccessibleName")
            Me.RadClock1.RootElement.Alignment = CType(resources.GetObject("RadClock1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadClock1.RootElement.AngleTransform = CType(resources.GetObject("RadClock1.RootElement.AngleTransform"), Single)
            Me.RadClock1.RootElement.FlipText = CType(resources.GetObject("RadClock1.RootElement.FlipText"), Boolean)
            Me.RadClock1.RootElement.Margin = CType(resources.GetObject("RadClock1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadClock1.RootElement.Text = resources.GetString("RadClock1.RootElement.Text")
            Me.RadClock1.RootElement.TextOrientation = CType(resources.GetObject("RadClock1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadClock1.TabStop = False
            '
            'lblTotalVenta
            '
            resources.ApplyResources(Me.lblTotalVenta, "lblTotalVenta")
            Me.lblTotalVenta.BorderVisible = True
            Me.lblTotalVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(193, Byte), Integer))
            Me.lblTotalVenta.Name = "lblTotalVenta"
            '
            '
            '
            Me.lblTotalVenta.RootElement.AccessibleDescription = resources.GetString("lblTotalVenta.RootElement.AccessibleDescription")
            Me.lblTotalVenta.RootElement.AccessibleName = resources.GetString("lblTotalVenta.RootElement.AccessibleName")
            Me.lblTotalVenta.RootElement.Alignment = CType(resources.GetObject("lblTotalVenta.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lblTotalVenta.RootElement.AngleTransform = CType(resources.GetObject("lblTotalVenta.RootElement.AngleTransform"), Single)
            Me.lblTotalVenta.RootElement.FlipText = CType(resources.GetObject("lblTotalVenta.RootElement.FlipText"), Boolean)
            Me.lblTotalVenta.RootElement.Margin = CType(resources.GetObject("lblTotalVenta.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lblTotalVenta.RootElement.Text = resources.GetString("lblTotalVenta.RootElement.Text")
            Me.lblTotalVenta.RootElement.TextOrientation = CType(resources.GetObject("lblTotalVenta.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.lblTotalVenta.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.lblTotalVenta.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment"), System.Drawing.ContentAlignment)
            CType(Me.lblTotalVenta.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text15")
            CType(Me.lblTotalVenta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.lblTotalVenta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.lblTotalVenta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Shape = Me.RoundRectShape1
            '
            'lblNumeroVenta
            '
            resources.ApplyResources(Me.lblNumeroVenta, "lblNumeroVenta")
            Me.lblNumeroVenta.BorderVisible = True
            Me.lblNumeroVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(193, Byte), Integer))
            Me.lblNumeroVenta.Name = "lblNumeroVenta"
            '
            '
            '
            Me.lblNumeroVenta.RootElement.AccessibleDescription = resources.GetString("lblNumeroVenta.RootElement.AccessibleDescription")
            Me.lblNumeroVenta.RootElement.AccessibleName = resources.GetString("lblNumeroVenta.RootElement.AccessibleName")
            Me.lblNumeroVenta.RootElement.Alignment = CType(resources.GetObject("lblNumeroVenta.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lblNumeroVenta.RootElement.AngleTransform = CType(resources.GetObject("lblNumeroVenta.RootElement.AngleTransform"), Single)
            Me.lblNumeroVenta.RootElement.FlipText = CType(resources.GetObject("lblNumeroVenta.RootElement.FlipText"), Boolean)
            Me.lblNumeroVenta.RootElement.Margin = CType(resources.GetObject("lblNumeroVenta.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lblNumeroVenta.RootElement.Text = resources.GetString("lblNumeroVenta.RootElement.Text")
            Me.lblNumeroVenta.RootElement.TextOrientation = CType(resources.GetObject("lblNumeroVenta.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.lblNumeroVenta.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.lblNumeroVenta.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment1"), System.Drawing.ContentAlignment)
            CType(Me.lblNumeroVenta.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text16")
            CType(Me.lblNumeroVenta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.lblNumeroVenta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.lblNumeroVenta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Shape = Me.RoundRectShape1
            '
            'calCalendario
            '
            Me.calCalendario.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.FirstTwoLetters
            resources.ApplyResources(Me.calCalendario, "calCalendario")
            Me.calCalendario.Name = "calCalendario"
            '
            '
            '
            Me.calCalendario.RootElement.AccessibleDescription = resources.GetString("calCalendario.RootElement.AccessibleDescription")
            Me.calCalendario.RootElement.AccessibleName = resources.GetString("calCalendario.RootElement.AccessibleName")
            Me.calCalendario.RootElement.Alignment = CType(resources.GetObject("calCalendario.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.calCalendario.RootElement.AngleTransform = CType(resources.GetObject("calCalendario.RootElement.AngleTransform"), Single)
            Me.calCalendario.RootElement.FlipText = CType(resources.GetObject("calCalendario.RootElement.FlipText"), Boolean)
            Me.calCalendario.RootElement.Margin = CType(resources.GetObject("calCalendario.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.calCalendario.RootElement.Text = resources.GetString("calCalendario.RootElement.Text")
            Me.calCalendario.RootElement.TextOrientation = CType(resources.GetObject("calCalendario.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.calCalendario.ShowFooter = True
            Me.calCalendario.ShowOtherMonthsDays = False
            RadCalendarDay1.Date = New Date(2014, 1, 1, 0, 0, 0, 0)
            RadCalendarDay1.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth
            RadCalendarDay1.Selectable = False
            RadCalendarDay2.Date = New Date(2014, 1, 6, 0, 0, 0, 0)
            RadCalendarDay2.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth
            RadCalendarDay2.Selectable = False
            RadCalendarDay3.Date = New Date(2014, 5, 1, 0, 0, 0, 0)
            RadCalendarDay3.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth
            RadCalendarDay3.Selectable = False
            RadCalendarDay4.Date = New Date(2014, 8, 15, 0, 0, 0, 0)
            RadCalendarDay4.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth
            RadCalendarDay4.Selectable = False
            RadCalendarDay5.Date = New Date(2014, 10, 12, 0, 0, 0, 0)
            RadCalendarDay5.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth
            RadCalendarDay5.Selectable = False
            RadCalendarDay6.Date = New Date(2014, 11, 1, 0, 0, 0, 0)
            RadCalendarDay6.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth
            RadCalendarDay6.Selectable = False
            RadCalendarDay7.Date = New Date(2014, 12, 6, 0, 0, 0, 0)
            RadCalendarDay7.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth
            RadCalendarDay7.Selectable = False
            RadCalendarDay8.Date = New Date(2014, 12, 8, 0, 0, 0, 0)
            RadCalendarDay8.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth
            RadCalendarDay8.Selectable = False
            RadCalendarDay9.Date = New Date(2014, 12, 25, 0, 0, 0, 0)
            RadCalendarDay9.Recurring = Telerik.WinControls.UI.RecurringEvents.DayAndMonth
            RadCalendarDay9.Selectable = False
            Me.calCalendario.SpecialDays.Add(RadCalendarDay1)
            Me.calCalendario.SpecialDays.Add(RadCalendarDay2)
            Me.calCalendario.SpecialDays.Add(RadCalendarDay3)
            Me.calCalendario.SpecialDays.Add(RadCalendarDay4)
            Me.calCalendario.SpecialDays.Add(RadCalendarDay5)
            Me.calCalendario.SpecialDays.Add(RadCalendarDay6)
            Me.calCalendario.SpecialDays.Add(RadCalendarDay7)
            Me.calCalendario.SpecialDays.Add(RadCalendarDay8)
            Me.calCalendario.SpecialDays.Add(RadCalendarDay9)
            '
            'gridTareas
            '
            Me.gridTareas.BackColor = System.Drawing.Color.Transparent
            Me.gridTareas.Cursor = System.Windows.Forms.Cursors.Default
            resources.ApplyResources(Me.gridTareas, "gridTareas")
            Me.gridTareas.ForeColor = System.Drawing.Color.Black
            '
            '
            '
            Me.gridTareas.MasterTemplate.AllowAddNewRow = False
            Me.gridTareas.MasterTemplate.AllowCellContextMenu = False
            Me.gridTareas.MasterTemplate.AllowColumnChooser = False
            Me.gridTareas.MasterTemplate.AllowDragToGroup = False
            Me.gridTareas.MasterTemplate.AllowEditRow = False
            Me.gridTareas.MasterTemplate.AllowRowReorder = True
            Me.gridTareas.MasterTemplate.AutoGenerateColumns = False
            GridViewDecimalColumn2.DataType = GetType(Long)
            GridViewDecimalColumn2.EnableExpressionEditor = False
            GridViewDecimalColumn2.FieldName = "idTarea"
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.IsVisible = False
            GridViewDecimalColumn2.Name = "idTarea"
            GridViewImageColumn1.EnableExpressionEditor = False
            GridViewImageColumn1.FieldName = "ImagenPrioridad"
            GridViewImageColumn1.IsAutoGenerated = True
            GridViewImageColumn1.Name = "ImagenPrioridad"
            GridViewImageColumn1.Width = 33
            GridViewTextBoxColumn4.EnableExpressionEditor = False
            GridViewTextBoxColumn4.FieldName = "Tarea"
            resources.ApplyResources(GridViewTextBoxColumn4, "GridViewTextBoxColumn4")
            GridViewTextBoxColumn4.IsAutoGenerated = True
            GridViewTextBoxColumn4.Multiline = True
            GridViewTextBoxColumn4.Name = "Tarea"
            GridViewTextBoxColumn4.Width = 194
            GridViewDateTimeColumn2.EnableExpressionEditor = False
            GridViewDateTimeColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumTime
            GridViewDateTimeColumn2.FieldName = "FechaTarea"
            GridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            resources.ApplyResources(GridViewDateTimeColumn2, "GridViewDateTimeColumn2")
            GridViewDateTimeColumn2.IsAutoGenerated = True
            GridViewDateTimeColumn2.Name = "FechaTarea"
            GridViewDateTimeColumn2.Width = 118
            GridViewDateTimeColumn3.EnableExpressionEditor = False
            GridViewDateTimeColumn3.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.MediumTime
            GridViewDateTimeColumn3.FieldName = "HoraTarea"
            GridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            resources.ApplyResources(GridViewDateTimeColumn3, "GridViewDateTimeColumn3")
            GridViewDateTimeColumn3.IsAutoGenerated = True
            GridViewDateTimeColumn3.Name = "HoraTarea"
            GridViewDateTimeColumn3.ReadOnly = True
            GridViewDateTimeColumn3.Width = 78
            Me.gridTareas.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn2, GridViewImageColumn1, GridViewTextBoxColumn4, GridViewDateTimeColumn2, GridViewDateTimeColumn3})
            Me.gridTareas.MasterTemplate.DataSource = Me.TareasBindingSource
            Me.gridTareas.MasterTemplate.EnableGrouping = False
            Me.gridTareas.MasterTemplate.MultiSelect = True
            Me.gridTareas.MasterTemplate.ViewDefinition = TableViewDefinition2
            Me.gridTareas.Name = "gridTareas"
            '
            '
            '
            Me.gridTareas.RootElement.AccessibleDescription = resources.GetString("gridTareas.RootElement.AccessibleDescription")
            Me.gridTareas.RootElement.AccessibleName = resources.GetString("gridTareas.RootElement.AccessibleName")
            Me.gridTareas.RootElement.Alignment = CType(resources.GetObject("gridTareas.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.gridTareas.RootElement.AngleTransform = CType(resources.GetObject("gridTareas.RootElement.AngleTransform"), Single)
            Me.gridTareas.RootElement.FlipText = CType(resources.GetObject("gridTareas.RootElement.FlipText"), Boolean)
            Me.gridTareas.RootElement.Margin = CType(resources.GetObject("gridTareas.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.gridTareas.RootElement.Text = resources.GetString("gridTareas.RootElement.Text")
            Me.gridTareas.RootElement.TextOrientation = CType(resources.GetObject("gridTareas.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.gridTareas.ShowGroupPanel = False
            '
            'TareasBindingSource
            '
            Me.TareasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.VWTareas)
            '
            'waitbTareas
            '
            resources.ApplyResources(Me.waitbTareas, "waitbTareas")
            Me.waitbTareas.Name = "waitbTareas"
            '
            '
            '
            Me.waitbTareas.RootElement.AccessibleDescription = resources.GetString("waitbTareas.RootElement.AccessibleDescription")
            Me.waitbTareas.RootElement.AccessibleName = resources.GetString("waitbTareas.RootElement.AccessibleName")
            Me.waitbTareas.RootElement.Alignment = CType(resources.GetObject("waitbTareas.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.waitbTareas.RootElement.AngleTransform = CType(resources.GetObject("waitbTareas.RootElement.AngleTransform"), Single)
            Me.waitbTareas.RootElement.FlipText = CType(resources.GetObject("waitbTareas.RootElement.FlipText"), Boolean)
            Me.waitbTareas.RootElement.Margin = CType(resources.GetObject("waitbTareas.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.waitbTareas.RootElement.Text = resources.GetString("waitbTareas.RootElement.Text")
            Me.waitbTareas.RootElement.TextOrientation = CType(resources.GetObject("waitbTareas.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.waitbTareas.WaitingSpeed = 80
            Me.waitbTareas.WaitingStep = 10
            Me.waitbTareas.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Throbber
            '
            'RadDock1
            '
            Me.RadDock1.ActiveWindow = Me.toolTarea
            Me.RadDock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.RadDock1.CausesValidation = False
            Me.RadDock1.Controls.Add(Me.ToolTabStrip4)
            Me.RadDock1.Controls.Add(Me.RadSplitContainer3)
            Me.RadDock1.Controls.Add(Me.RadSplitContainer5)
            Me.RadDock1.Controls.Add(Me.DocumentContainer1)
            resources.ApplyResources(Me.RadDock1, "RadDock1")
            Me.RadDock1.IsCleanUpTarget = True
            Me.RadDock1.MainDocumentContainer = Me.DocumentContainer1
            Me.RadDock1.MainDocumentContainerVisible = False
            Me.RadDock1.MdiChildrenDockType = Telerik.WinControls.UI.Docking.DockType.ToolWindow
            Me.RadDock1.Name = "RadDock1"
            '
            '
            '
            Me.RadDock1.RootElement.AccessibleDescription = resources.GetString("RadDock1.RootElement.AccessibleDescription")
            Me.RadDock1.RootElement.AccessibleName = resources.GetString("RadDock1.RootElement.AccessibleName")
            Me.RadDock1.RootElement.Alignment = CType(resources.GetObject("RadDock1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadDock1.RootElement.AngleTransform = CType(resources.GetObject("RadDock1.RootElement.AngleTransform"), Single)
            Me.RadDock1.RootElement.FlipText = CType(resources.GetObject("RadDock1.RootElement.FlipText"), Boolean)
            Me.RadDock1.RootElement.Margin = CType(resources.GetObject("RadDock1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.RadDock1.RootElement.Text = resources.GetString("RadDock1.RootElement.Text")
            Me.RadDock1.RootElement.TextOrientation = CType(resources.GetObject("RadDock1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadDock1.TabStop = False
            Me.RadDock1.UseSplitterButtons = True
            '
            'toolTarea
            '
            Me.toolTarea.Caption = Nothing
            Me.toolTarea.Controls.Add(Me.RadSplitContainer2)
            Me.toolTarea.Controls.Add(Me.RadCommandBar1)
            Me.toolTarea.DefaultFloatingSize = New System.Drawing.Size(600, 300)
            Me.toolTarea.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
            resources.ApplyResources(Me.toolTarea, "toolTarea")
            Me.toolTarea.Name = "toolTarea"
            Me.toolTarea.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.toolTarea.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
            '
            'RadSplitContainer2
            '
            Me.RadSplitContainer2.Controls.Add(Me.SplitPanel3)
            Me.RadSplitContainer2.Controls.Add(Me.SplitPanel4)
            resources.ApplyResources(Me.RadSplitContainer2, "RadSplitContainer2")
            Me.RadSplitContainer2.EnableCollapsing = True
            Me.RadSplitContainer2.IsCleanUpTarget = True
            Me.RadSplitContainer2.Name = "RadSplitContainer2"
            '
            '
            '
            Me.RadSplitContainer2.RootElement.AccessibleDescription = resources.GetString("RadSplitContainer2.RootElement.AccessibleDescription")
            Me.RadSplitContainer2.RootElement.AccessibleName = resources.GetString("RadSplitContainer2.RootElement.AccessibleName")
            Me.RadSplitContainer2.RootElement.Alignment = CType(resources.GetObject("RadSplitContainer2.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadSplitContainer2.RootElement.AngleTransform = CType(resources.GetObject("RadSplitContainer2.RootElement.AngleTransform"), Single)
            Me.RadSplitContainer2.RootElement.FlipText = CType(resources.GetObject("RadSplitContainer2.RootElement.FlipText"), Boolean)
            Me.RadSplitContainer2.RootElement.Margin = CType(resources.GetObject("RadSplitContainer2.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadSplitContainer2.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.RadSplitContainer2.RootElement.Text = resources.GetString("RadSplitContainer2.RootElement.Text")
            Me.RadSplitContainer2.RootElement.TextOrientation = CType(resources.GetObject("RadSplitContainer2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadSplitContainer2.TabStop = False
            '
            'SplitPanel3
            '
            Me.SplitPanel3.Controls.Add(Me.waitbTareas)
            Me.SplitPanel3.Controls.Add(Me.gridTareas)
            resources.ApplyResources(Me.SplitPanel3, "SplitPanel3")
            Me.SplitPanel3.Name = "SplitPanel3"
            '
            '
            '
            Me.SplitPanel3.RootElement.AccessibleDescription = resources.GetString("SplitPanel3.RootElement.AccessibleDescription")
            Me.SplitPanel3.RootElement.AccessibleName = resources.GetString("SplitPanel3.RootElement.AccessibleName")
            Me.SplitPanel3.RootElement.Alignment = CType(resources.GetObject("SplitPanel3.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel3.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel3.RootElement.AngleTransform"), Single)
            Me.SplitPanel3.RootElement.FlipText = CType(resources.GetObject("SplitPanel3.RootElement.FlipText"), Boolean)
            Me.SplitPanel3.RootElement.Margin = CType(resources.GetObject("SplitPanel3.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel3.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel3.RootElement.Text = resources.GetString("SplitPanel3.RootElement.Text")
            Me.SplitPanel3.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel3.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel3.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.07540263!)
            Me.SplitPanel3.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 58)
            Me.SplitPanel3.TabStop = False
            '
            'SplitPanel4
            '
            Me.SplitPanel4.Controls.Add(gboxTarea)
            resources.ApplyResources(Me.SplitPanel4, "SplitPanel4")
            Me.SplitPanel4.Name = "SplitPanel4"
            '
            '
            '
            Me.SplitPanel4.RootElement.AccessibleDescription = resources.GetString("SplitPanel4.RootElement.AccessibleDescription")
            Me.SplitPanel4.RootElement.AccessibleName = resources.GetString("SplitPanel4.RootElement.AccessibleName")
            Me.SplitPanel4.RootElement.Alignment = CType(resources.GetObject("SplitPanel4.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel4.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel4.RootElement.AngleTransform"), Single)
            Me.SplitPanel4.RootElement.FlipText = CType(resources.GetObject("SplitPanel4.RootElement.FlipText"), Boolean)
            Me.SplitPanel4.RootElement.Margin = CType(resources.GetObject("SplitPanel4.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel4.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel4.RootElement.Text = resources.GetString("SplitPanel4.RootElement.Text")
            Me.SplitPanel4.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel4.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel4.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.07540263!)
            Me.SplitPanel4.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -58)
            Me.SplitPanel4.TabStop = False
            '
            'RadCommandBar1
            '
            resources.ApplyResources(Me.RadCommandBar1, "RadCommandBar1")
            Me.RadCommandBar1.Name = "RadCommandBar1"
            '
            '
            '
            Me.RadCommandBar1.RootElement.AccessibleDescription = resources.GetString("RadCommandBar1.RootElement.AccessibleDescription")
            Me.RadCommandBar1.RootElement.AccessibleName = resources.GetString("RadCommandBar1.RootElement.AccessibleName")
            Me.RadCommandBar1.RootElement.Alignment = CType(resources.GetObject("RadCommandBar1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadCommandBar1.RootElement.AngleTransform = CType(resources.GetObject("RadCommandBar1.RootElement.AngleTransform"), Single)
            Me.RadCommandBar1.RootElement.FlipText = CType(resources.GetObject("RadCommandBar1.RootElement.FlipText"), Boolean)
            Me.RadCommandBar1.RootElement.Margin = CType(resources.GetObject("RadCommandBar1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadCommandBar1.RootElement.Text = resources.GetString("RadCommandBar1.RootElement.Text")
            Me.RadCommandBar1.RootElement.TextOrientation = CType(resources.GetObject("RadCommandBar1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement2})
            '
            'CommandBarRowElement2
            '
            resources.ApplyResources(Me.CommandBarRowElement2, "CommandBarRowElement2")
            Me.CommandBarRowElement2.MinSize = New System.Drawing.Size(25, 25)
            Me.CommandBarRowElement2.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.cbstripTarea})
            '
            'cbstripTarea
            '
            resources.ApplyResources(Me.cbstripTarea, "cbstripTarea")
            Me.cbstripTarea.DrawFill = True
            '
            '
            '
            Me.cbstripTarea.Grip.Alignment = CType(resources.GetObject("resource.Alignment4"), System.Drawing.ContentAlignment)
            Me.cbstripTarea.Grip.AngleTransform = CType(resources.GetObject("resource.AngleTransform5"), Single)
            Me.cbstripTarea.Grip.FlipText = CType(resources.GetObject("resource.FlipText4"), Boolean)
            Me.cbstripTarea.Grip.Margin = CType(resources.GetObject("resource.Margin4"), System.Windows.Forms.Padding)
            Me.cbstripTarea.Grip.Padding = CType(resources.GetObject("resource.Padding5"), System.Windows.Forms.Padding)
            Me.cbstripTarea.Grip.RightToLeft = CType(resources.GetObject("resource.RightToLeft4"), Boolean)
            Me.cbstripTarea.Grip.Text = resources.GetString("resource.Text17")
            Me.cbstripTarea.Grip.TextOrientation = CType(resources.GetObject("resource.TextOrientation4"), System.Windows.Forms.Orientation)
            Me.cbstripTarea.Grip.TextWrap = CType(resources.GetObject("resource.TextWrap4"), Boolean)
            Me.cbstripTarea.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbtnAgregarTarea, Me.cbbtnEliminarTarea, Me.cbbtnEditarTarea, Me.CommandBarSeparator2, Me.cbtoggleTodasTareas})
            Me.cbstripTarea.Name = "CommandBarStripElement2"
            '
            '
            '
            Me.cbstripTarea.OverflowButton.Alignment = CType(resources.GetObject("resource.Alignment5"), System.Drawing.ContentAlignment)
            Me.cbstripTarea.OverflowButton.AngleTransform = CType(resources.GetObject("resource.AngleTransform6"), Single)
            Me.cbstripTarea.OverflowButton.FlipText = CType(resources.GetObject("resource.FlipText5"), Boolean)
            Me.cbstripTarea.OverflowButton.Margin = CType(resources.GetObject("resource.Margin5"), System.Windows.Forms.Padding)
            Me.cbstripTarea.OverflowButton.Padding = CType(resources.GetObject("resource.Padding6"), System.Windows.Forms.Padding)
            Me.cbstripTarea.OverflowButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft5"), Boolean)
            Me.cbstripTarea.OverflowButton.Text = resources.GetString("resource.Text18")
            Me.cbstripTarea.OverflowButton.TextOrientation = CType(resources.GetObject("resource.TextOrientation5"), System.Windows.Forms.Orientation)
            Me.cbstripTarea.OverflowButton.TextWrap = CType(resources.GetObject("resource.TextWrap5"), Boolean)
            Me.cbstripTarea.Visibility = Telerik.WinControls.ElementVisibility.Visible
            CType(Me.cbstripTarea.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextWrap = CType(resources.GetObject("resource.TextWrap6"), Boolean)
            CType(Me.cbstripTarea.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextOrientation = CType(resources.GetObject("resource.TextOrientation6"), System.Windows.Forms.Orientation)
            CType(Me.cbstripTarea.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).FlipText = CType(resources.GetObject("resource.FlipText6"), Boolean)
            CType(Me.cbstripTarea.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Text = resources.GetString("resource.Text19")
            CType(Me.cbstripTarea.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Padding = CType(resources.GetObject("resource.Padding7"), System.Windows.Forms.Padding)
            CType(Me.cbstripTarea.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Margin = CType(resources.GetObject("resource.Margin6"), System.Windows.Forms.Padding)
            CType(Me.cbstripTarea.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Alignment = CType(resources.GetObject("resource.Alignment6"), System.Drawing.ContentAlignment)
            CType(Me.cbstripTarea.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).RightToLeft = CType(resources.GetObject("resource.RightToLeft6"), Boolean)
            CType(Me.cbstripTarea.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).AngleTransform = CType(resources.GetObject("resource.AngleTransform7"), Single)
            CType(Me.cbstripTarea.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextWrap = CType(resources.GetObject("resource.TextWrap7"), Boolean)
            CType(Me.cbstripTarea.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextOrientation = CType(resources.GetObject("resource.TextOrientation7"), System.Windows.Forms.Orientation)
            CType(Me.cbstripTarea.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).FlipText = CType(resources.GetObject("resource.FlipText7"), Boolean)
            CType(Me.cbstripTarea.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Text = resources.GetString("resource.Text20")
            CType(Me.cbstripTarea.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Padding = CType(resources.GetObject("resource.Padding8"), System.Windows.Forms.Padding)
            CType(Me.cbstripTarea.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Margin = CType(resources.GetObject("resource.Margin7"), System.Windows.Forms.Padding)
            CType(Me.cbstripTarea.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Alignment = CType(resources.GetObject("resource.Alignment7"), System.Drawing.ContentAlignment)
            CType(Me.cbstripTarea.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).RightToLeft = CType(resources.GetObject("resource.RightToLeft7"), Boolean)
            CType(Me.cbstripTarea.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).AngleTransform = CType(resources.GetObject("resource.AngleTransform8"), Single)
            '
            'cbbtnAgregarTarea
            '
            resources.ApplyResources(Me.cbbtnAgregarTarea, "cbbtnAgregarTarea")
            Me.cbbtnAgregarTarea.Font = New System.Drawing.Font("KaiTi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnAgregarTarea.Image = CType(resources.GetObject("cbbtnAgregarTarea.Image"), System.Drawing.Image)
            Me.cbbtnAgregarTarea.Name = "cbbtnAgregarTarea"
            Me.cbbtnAgregarTarea.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
            '
            'cbbtnEliminarTarea
            '
            resources.ApplyResources(Me.cbbtnEliminarTarea, "cbbtnEliminarTarea")
            Me.cbbtnEliminarTarea.DrawText = False
            Me.cbbtnEliminarTarea.Font = New System.Drawing.Font("KaiTi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnEliminarTarea.Image = CType(resources.GetObject("cbbtnEliminarTarea.Image"), System.Drawing.Image)
            Me.cbbtnEliminarTarea.Name = "cbbtnEliminarTarea"
            '
            'cbbtnEditarTarea
            '
            resources.ApplyResources(Me.cbbtnEditarTarea, "cbbtnEditarTarea")
            Me.cbbtnEditarTarea.Font = New System.Drawing.Font("KaiTi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cbbtnEditarTarea.Image = CType(resources.GetObject("cbbtnEditarTarea.Image"), System.Drawing.Image)
            Me.cbbtnEditarTarea.Name = "cbbtnEditarTarea"
            '
            'CommandBarSeparator2
            '
            resources.ApplyResources(Me.CommandBarSeparator2, "CommandBarSeparator2")
            Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
            Me.CommandBarSeparator2.VisibleInOverflowMenu = False
            '
            'cbtoggleTodasTareas
            '
            resources.ApplyResources(Me.cbtoggleTodasTareas, "cbtoggleTodasTareas")
            Me.cbtoggleTodasTareas.Image = CType(resources.GetObject("cbtoggleTodasTareas.Image"), System.Drawing.Image)
            Me.cbtoggleTodasTareas.Name = "cbtoggleTodasTareas"
            '
            'ToolTabStrip4
            '
            resources.ApplyResources(Me.ToolTabStrip4, "ToolTabStrip4")
            Me.ToolTabStrip4.CanUpdateChildIndex = True
            Me.ToolTabStrip4.CausesValidation = False
            Me.ToolTabStrip4.Controls.Add(Me.toolTarea)
            Me.ToolTabStrip4.Name = "ToolTabStrip4"
            '
            '
            '
            Me.ToolTabStrip4.RootElement.AccessibleDescription = resources.GetString("ToolTabStrip4.RootElement.AccessibleDescription")
            Me.ToolTabStrip4.RootElement.AccessibleName = resources.GetString("ToolTabStrip4.RootElement.AccessibleName")
            Me.ToolTabStrip4.RootElement.Alignment = CType(resources.GetObject("ToolTabStrip4.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ToolTabStrip4.RootElement.AngleTransform = CType(resources.GetObject("ToolTabStrip4.RootElement.AngleTransform"), Single)
            Me.ToolTabStrip4.RootElement.FlipText = CType(resources.GetObject("ToolTabStrip4.RootElement.FlipText"), Boolean)
            Me.ToolTabStrip4.RootElement.Margin = CType(resources.GetObject("ToolTabStrip4.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ToolTabStrip4.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.ToolTabStrip4.RootElement.Text = resources.GetString("ToolTabStrip4.RootElement.Text")
            Me.ToolTabStrip4.RootElement.TextOrientation = CType(resources.GetObject("ToolTabStrip4.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ToolTabStrip4.SelectedIndex = 0
            Me.ToolTabStrip4.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.1024904!, 0!)
            Me.ToolTabStrip4.SizeInfo.SplitterCorrection = New System.Drawing.Size(-35, 0)
            Me.ToolTabStrip4.TabStop = False
            '
            'RadSplitContainer3
            '
            Me.RadSplitContainer3.Controls.Add(Me.ToolTabStrip1)
            Me.RadSplitContainer3.Controls.Add(Me.RadSplitContainer4)
            Me.RadSplitContainer3.IsCleanUpTarget = True
            resources.ApplyResources(Me.RadSplitContainer3, "RadSplitContainer3")
            Me.RadSplitContainer3.Name = "RadSplitContainer3"
            '
            '
            '
            Me.RadSplitContainer3.RootElement.AccessibleDescription = resources.GetString("RadSplitContainer3.RootElement.AccessibleDescription")
            Me.RadSplitContainer3.RootElement.AccessibleName = resources.GetString("RadSplitContainer3.RootElement.AccessibleName")
            Me.RadSplitContainer3.RootElement.Alignment = CType(resources.GetObject("RadSplitContainer3.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadSplitContainer3.RootElement.AngleTransform = CType(resources.GetObject("RadSplitContainer3.RootElement.AngleTransform"), Single)
            Me.RadSplitContainer3.RootElement.FlipText = CType(resources.GetObject("RadSplitContainer3.RootElement.FlipText"), Boolean)
            Me.RadSplitContainer3.RootElement.Margin = CType(resources.GetObject("RadSplitContainer3.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadSplitContainer3.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.RadSplitContainer3.RootElement.Text = resources.GetString("RadSplitContainer3.RootElement.Text")
            Me.RadSplitContainer3.RootElement.TextOrientation = CType(resources.GetObject("RadSplitContainer3.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadSplitContainer3.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.2595786!, 0!)
            Me.RadSplitContainer3.SizeInfo.SplitterCorrection = New System.Drawing.Size(239, 0)
            Me.RadSplitContainer3.TabStop = False
            '
            'ToolTabStrip1
            '
            Me.ToolTabStrip1.CanUpdateChildIndex = True
            Me.ToolTabStrip1.CaptionVisible = False
            Me.ToolTabStrip1.Controls.Add(toolListaCompra)
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
            Me.ToolTabStrip1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.2721024!, 0.1441177!)
            Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(177, 65)
            Me.ToolTabStrip1.TabStop = False
            '
            'RadSplitContainer4
            '
            Me.RadSplitContainer4.Controls.Add(Me.ToolTabStrip2)
            Me.RadSplitContainer4.Controls.Add(Me.ToolTabStrip3)
            Me.RadSplitContainer4.IsCleanUpTarget = True
            resources.ApplyResources(Me.RadSplitContainer4, "RadSplitContainer4")
            Me.RadSplitContainer4.Name = "RadSplitContainer4"
            '
            '
            '
            Me.RadSplitContainer4.RootElement.AccessibleDescription = resources.GetString("RadSplitContainer4.RootElement.AccessibleDescription")
            Me.RadSplitContainer4.RootElement.AccessibleName = resources.GetString("RadSplitContainer4.RootElement.AccessibleName")
            Me.RadSplitContainer4.RootElement.Alignment = CType(resources.GetObject("RadSplitContainer4.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadSplitContainer4.RootElement.AngleTransform = CType(resources.GetObject("RadSplitContainer4.RootElement.AngleTransform"), Single)
            Me.RadSplitContainer4.RootElement.FlipText = CType(resources.GetObject("RadSplitContainer4.RootElement.FlipText"), Boolean)
            Me.RadSplitContainer4.RootElement.Margin = CType(resources.GetObject("RadSplitContainer4.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadSplitContainer4.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.RadSplitContainer4.RootElement.Text = resources.GetString("RadSplitContainer4.RootElement.Text")
            Me.RadSplitContainer4.RootElement.TextOrientation = CType(resources.GetObject("RadSplitContainer4.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadSplitContainer4.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.1441177!)
            Me.RadSplitContainer4.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -65)
            Me.RadSplitContainer4.TabStop = False
            '
            'ToolTabStrip2
            '
            Me.ToolTabStrip2.CanUpdateChildIndex = True
            Me.ToolTabStrip2.Controls.Add(toolDivisa)
            resources.ApplyResources(Me.ToolTabStrip2, "ToolTabStrip2")
            Me.ToolTabStrip2.Name = "ToolTabStrip2"
            '
            '
            '
            Me.ToolTabStrip2.RootElement.AccessibleDescription = resources.GetString("ToolTabStrip2.RootElement.AccessibleDescription")
            Me.ToolTabStrip2.RootElement.AccessibleName = resources.GetString("ToolTabStrip2.RootElement.AccessibleName")
            Me.ToolTabStrip2.RootElement.Alignment = CType(resources.GetObject("ToolTabStrip2.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ToolTabStrip2.RootElement.AngleTransform = CType(resources.GetObject("ToolTabStrip2.RootElement.AngleTransform"), Single)
            Me.ToolTabStrip2.RootElement.FlipText = CType(resources.GetObject("ToolTabStrip2.RootElement.FlipText"), Boolean)
            Me.ToolTabStrip2.RootElement.Margin = CType(resources.GetObject("ToolTabStrip2.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ToolTabStrip2.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.ToolTabStrip2.RootElement.Text = resources.GetString("ToolTabStrip2.RootElement.Text")
            Me.ToolTabStrip2.RootElement.TextOrientation = CType(resources.GetObject("ToolTabStrip2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ToolTabStrip2.SelectedIndex = 0
            Me.ToolTabStrip2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.0511111!, -0.1741344!)
            Me.ToolTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(-35, -85)
            Me.ToolTabStrip2.TabStop = False
            '
            'ToolTabStrip3
            '
            Me.ToolTabStrip3.CanUpdateChildIndex = True
            Me.ToolTabStrip3.Controls.Add(Me.toolMeteo)
            resources.ApplyResources(Me.ToolTabStrip3, "ToolTabStrip3")
            Me.ToolTabStrip3.Name = "ToolTabStrip3"
            '
            '
            '
            Me.ToolTabStrip3.RootElement.AccessibleDescription = resources.GetString("ToolTabStrip3.RootElement.AccessibleDescription")
            Me.ToolTabStrip3.RootElement.AccessibleName = resources.GetString("ToolTabStrip3.RootElement.AccessibleName")
            Me.ToolTabStrip3.RootElement.Alignment = CType(resources.GetObject("ToolTabStrip3.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ToolTabStrip3.RootElement.AngleTransform = CType(resources.GetObject("ToolTabStrip3.RootElement.AngleTransform"), Single)
            Me.ToolTabStrip3.RootElement.FlipText = CType(resources.GetObject("ToolTabStrip3.RootElement.FlipText"), Boolean)
            Me.ToolTabStrip3.RootElement.Margin = CType(resources.GetObject("ToolTabStrip3.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ToolTabStrip3.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.ToolTabStrip3.RootElement.Text = resources.GetString("ToolTabStrip3.RootElement.Text")
            Me.ToolTabStrip3.RootElement.TextOrientation = CType(resources.GetObject("ToolTabStrip3.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ToolTabStrip3.SelectedIndex = 0
            Me.ToolTabStrip3.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.0511111!, 0!)
            Me.ToolTabStrip3.SizeInfo.SplitterCorrection = New System.Drawing.Size(35, 0)
            Me.ToolTabStrip3.TabStop = False
            '
            'toolMeteo
            '
            Me.toolMeteo.Caption = Nothing
            Me.toolMeteo.Controls.Add(RadPanel5)
            Me.toolMeteo.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
            resources.ApplyResources(Me.toolMeteo, "toolMeteo")
            Me.toolMeteo.Name = "toolMeteo"
            Me.toolMeteo.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.toolMeteo.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
            '
            'RadSplitContainer5
            '
            Me.RadSplitContainer5.CausesValidation = False
            Me.RadSplitContainer5.Controls.Add(Me.ToolTabStrip6)
            Me.RadSplitContainer5.Controls.Add(Me.ToolTabStrip7)
            Me.RadSplitContainer5.Controls.Add(Me.ToolTabStrip8)
            Me.RadSplitContainer5.IsCleanUpTarget = True
            resources.ApplyResources(Me.RadSplitContainer5, "RadSplitContainer5")
            Me.RadSplitContainer5.Name = "RadSplitContainer5"
            '
            '
            '
            Me.RadSplitContainer5.RootElement.AccessibleDescription = resources.GetString("RadSplitContainer5.RootElement.AccessibleDescription")
            Me.RadSplitContainer5.RootElement.AccessibleName = resources.GetString("RadSplitContainer5.RootElement.AccessibleName")
            Me.RadSplitContainer5.RootElement.Alignment = CType(resources.GetObject("RadSplitContainer5.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadSplitContainer5.RootElement.AngleTransform = CType(resources.GetObject("RadSplitContainer5.RootElement.AngleTransform"), Single)
            Me.RadSplitContainer5.RootElement.FlipText = CType(resources.GetObject("RadSplitContainer5.RootElement.FlipText"), Boolean)
            Me.RadSplitContainer5.RootElement.Margin = CType(resources.GetObject("RadSplitContainer5.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadSplitContainer5.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.RadSplitContainer5.RootElement.Text = resources.GetString("RadSplitContainer5.RootElement.Text")
            Me.RadSplitContainer5.RootElement.TextOrientation = CType(resources.GetObject("RadSplitContainer5.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadSplitContainer5.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.1570881!, 0!)
            Me.RadSplitContainer5.SizeInfo.SplitterCorrection = New System.Drawing.Size(-204, 0)
            Me.RadSplitContainer5.TabStop = False
            '
            'ToolTabStrip6
            '
            Me.ToolTabStrip6.CanUpdateChildIndex = True
            Me.ToolTabStrip6.CaptionVisible = False
            Me.ToolTabStrip6.Controls.Add(Me.toolCalendario)
            resources.ApplyResources(Me.ToolTabStrip6, "ToolTabStrip6")
            Me.ToolTabStrip6.Name = "ToolTabStrip6"
            '
            '
            '
            Me.ToolTabStrip6.RootElement.AccessibleDescription = resources.GetString("ToolTabStrip6.RootElement.AccessibleDescription")
            Me.ToolTabStrip6.RootElement.AccessibleName = resources.GetString("ToolTabStrip6.RootElement.AccessibleName")
            Me.ToolTabStrip6.RootElement.Alignment = CType(resources.GetObject("ToolTabStrip6.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ToolTabStrip6.RootElement.AngleTransform = CType(resources.GetObject("ToolTabStrip6.RootElement.AngleTransform"), Single)
            Me.ToolTabStrip6.RootElement.FlipText = CType(resources.GetObject("ToolTabStrip6.RootElement.FlipText"), Boolean)
            Me.ToolTabStrip6.RootElement.Margin = CType(resources.GetObject("ToolTabStrip6.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ToolTabStrip6.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.ToolTabStrip6.RootElement.Text = resources.GetString("ToolTabStrip6.RootElement.Text")
            Me.ToolTabStrip6.RootElement.TextOrientation = CType(resources.GetObject("ToolTabStrip6.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ToolTabStrip6.SelectedIndex = 0
            Me.ToolTabStrip6.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.02234637!)
            Me.ToolTabStrip6.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 31)
            Me.ToolTabStrip6.TabStop = False
            '
            'toolCalendario
            '
            Me.toolCalendario.Caption = Nothing
            Me.toolCalendario.Controls.Add(Me.calCalendario)
            Me.toolCalendario.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
            resources.ApplyResources(Me.toolCalendario, "toolCalendario")
            Me.toolCalendario.Name = "toolCalendario"
            Me.toolCalendario.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.toolCalendario.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
            '
            'ToolTabStrip7
            '
            Me.ToolTabStrip7.CanUpdateChildIndex = True
            Me.ToolTabStrip7.CaptionVisible = False
            Me.ToolTabStrip7.Controls.Add(toolReloj)
            resources.ApplyResources(Me.ToolTabStrip7, "ToolTabStrip7")
            Me.ToolTabStrip7.Name = "ToolTabStrip7"
            '
            '
            '
            Me.ToolTabStrip7.RootElement.AccessibleDescription = resources.GetString("ToolTabStrip7.RootElement.AccessibleDescription")
            Me.ToolTabStrip7.RootElement.AccessibleName = resources.GetString("ToolTabStrip7.RootElement.AccessibleName")
            Me.ToolTabStrip7.RootElement.Alignment = CType(resources.GetObject("ToolTabStrip7.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ToolTabStrip7.RootElement.AngleTransform = CType(resources.GetObject("ToolTabStrip7.RootElement.AngleTransform"), Single)
            Me.ToolTabStrip7.RootElement.FlipText = CType(resources.GetObject("ToolTabStrip7.RootElement.FlipText"), Boolean)
            Me.ToolTabStrip7.RootElement.Margin = CType(resources.GetObject("ToolTabStrip7.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ToolTabStrip7.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.ToolTabStrip7.RootElement.Text = resources.GetString("ToolTabStrip7.RootElement.Text")
            Me.ToolTabStrip7.RootElement.TextOrientation = CType(resources.GetObject("ToolTabStrip7.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ToolTabStrip7.SelectedIndex = 0
            Me.ToolTabStrip7.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 191)
            Me.ToolTabStrip7.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.05374755!)
            Me.ToolTabStrip7.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Absolute
            Me.ToolTabStrip7.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -34)
            Me.ToolTabStrip7.TabStop = False
            '
            'ToolTabStrip8
            '
            Me.ToolTabStrip8.CanUpdateChildIndex = True
            Me.ToolTabStrip8.CausesValidation = False
            Me.ToolTabStrip8.Controls.Add(Me.toolResumen)
            resources.ApplyResources(Me.ToolTabStrip8, "ToolTabStrip8")
            Me.ToolTabStrip8.Name = "ToolTabStrip8"
            '
            '
            '
            Me.ToolTabStrip8.RootElement.AccessibleDescription = resources.GetString("ToolTabStrip8.RootElement.AccessibleDescription")
            Me.ToolTabStrip8.RootElement.AccessibleName = resources.GetString("ToolTabStrip8.RootElement.AccessibleName")
            Me.ToolTabStrip8.RootElement.Alignment = CType(resources.GetObject("ToolTabStrip8.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ToolTabStrip8.RootElement.AngleTransform = CType(resources.GetObject("ToolTabStrip8.RootElement.AngleTransform"), Single)
            Me.ToolTabStrip8.RootElement.FlipText = CType(resources.GetObject("ToolTabStrip8.RootElement.FlipText"), Boolean)
            Me.ToolTabStrip8.RootElement.Margin = CType(resources.GetObject("ToolTabStrip8.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ToolTabStrip8.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.ToolTabStrip8.RootElement.Text = resources.GetString("ToolTabStrip8.RootElement.Text")
            Me.ToolTabStrip8.RootElement.TextOrientation = CType(resources.GetObject("ToolTabStrip8.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ToolTabStrip8.SelectedIndex = 0
            Me.ToolTabStrip8.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 204)
            Me.ToolTabStrip8.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.08116233!)
            Me.ToolTabStrip8.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Absolute
            Me.ToolTabStrip8.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 3)
            Me.ToolTabStrip8.TabStop = False
            '
            'toolResumen
            '
            Me.toolResumen.Caption = Nothing
            Me.toolResumen.Controls.Add(Me.lblTotalVenta)
            Me.toolResumen.Controls.Add(RadLabel2)
            Me.toolResumen.Controls.Add(Me.lblNumeroVenta)
            Me.toolResumen.Controls.Add(RadLabel3)
            Me.toolResumen.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
            resources.ApplyResources(Me.toolResumen, "toolResumen")
            Me.toolResumen.Name = "toolResumen"
            Me.toolResumen.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
            Me.toolResumen.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
            '
            'DocumentContainer1
            '
            Me.DocumentContainer1.Collapsed = True
            Me.DocumentContainer1.Name = "DocumentContainer1"
            '
            '
            '
            Me.DocumentContainer1.RootElement.AccessibleDescription = resources.GetString("DocumentContainer1.RootElement.AccessibleDescription")
            Me.DocumentContainer1.RootElement.AccessibleName = resources.GetString("DocumentContainer1.RootElement.AccessibleName")
            Me.DocumentContainer1.RootElement.Alignment = CType(resources.GetObject("DocumentContainer1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.DocumentContainer1.RootElement.AngleTransform = CType(resources.GetObject("DocumentContainer1.RootElement.AngleTransform"), Single)
            Me.DocumentContainer1.RootElement.FlipText = CType(resources.GetObject("DocumentContainer1.RootElement.FlipText"), Boolean)
            Me.DocumentContainer1.RootElement.Margin = CType(resources.GetObject("DocumentContainer1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.DocumentContainer1.RootElement.Text = resources.GetString("DocumentContainer1.RootElement.Text")
            Me.DocumentContainer1.RootElement.TextOrientation = CType(resources.GetObject("DocumentContainer1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
            resources.ApplyResources(Me.DocumentContainer1, "DocumentContainer1")
            '
            'timerRefrescoInicio
            '
            Me.timerRefrescoInicio.Interval = 60000
            '
            'timerRefrescoDivisa
            '
            '
            'timerRefrescoMeteo
            '
            '
            'bgwInicio
            '
            '
            'frmInicio
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.RadDock1)
            Me.KeyPreview = True
            Me.Name = "frmInicio"
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmInicio.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmInicio.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmInicio.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmInicio.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmInicio.RootElement.FlipText"), Boolean)
            Me.RootElement.Margin = CType(resources.GetObject("frmInicio.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmInicio.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmInicio.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
            RadPanel5.ResumeLayout(False)
            RadPanel5.PerformLayout()
            CType(Me.waitbMeteo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnActualizarMeteologia, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trbTiempo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            toolListaCompra.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            RadPanel1.ResumeLayout(False)
            RadPanel1.PerformLayout()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer1.ResumeLayout(False)
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel1.ResumeLayout(False)
            CType(Me.gridListaCompra.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridListaCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ListasCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel2.ResumeLayout(False)
            CType(Me.gboxEncargo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gboxEncargo.ResumeLayout(False)
            Me.gboxEncargo.PerformLayout()
            CType(Me.btnBuscarProducto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadGroupBox3.ResumeLayout(False)
            Me.RadGroupBox3.PerformLayout()
            CType(RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EncargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkRecogido, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinFianza, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinCantidad, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpRecogida, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtProducto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtReferencia, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelarEncargo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptarEncargo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkSuspendido, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbListaCompra, System.ComponentModel.ISupportInitialize).EndInit()
            CType(gboxTarea, System.ComponentModel.ISupportInitialize).EndInit()
            gboxTarea.ResumeLayout(False)
            gboxTarea.PerformLayout()
            CType(Me.btnCancelarTarea, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptarTarea, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtTarea, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TareaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlAviso, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlPrioridadTarea, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PrioridadesTareaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpTiempoAviso, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFechaTarea, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            RadPanel2.ResumeLayout(False)
            RadPanel2.PerformLayout()
            CType(Me.waitbDivisa, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnActualizarDivisa, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trbDivisa, System.ComponentModel.ISupportInitialize).EndInit()
            toolDivisa.ResumeLayout(False)
            toolReloj.ResumeLayout(False)
            toolReloj.PerformLayout()
            CType(Me.RadClock1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblTotalVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblNumeroVenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.calCalendario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridTareas.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridTareas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TareasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.waitbTareas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadDock1.ResumeLayout(False)
            Me.toolTarea.ResumeLayout(False)
            Me.toolTarea.PerformLayout()
            CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer2.ResumeLayout(False)
            CType(Me.SplitPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel3.ResumeLayout(False)
            CType(Me.SplitPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel4.ResumeLayout(False)
            CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolTabStrip4.ResumeLayout(False)
            CType(Me.RadSplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer3.ResumeLayout(False)
            CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolTabStrip1.ResumeLayout(False)
            CType(Me.RadSplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer4.ResumeLayout(False)
            CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolTabStrip2.ResumeLayout(False)
            CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolTabStrip3.ResumeLayout(False)
            Me.toolMeteo.ResumeLayout(False)
            CType(Me.RadSplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer5.ResumeLayout(False)
            CType(Me.ToolTabStrip6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolTabStrip6.ResumeLayout(False)
            Me.toolCalendario.ResumeLayout(False)
            CType(Me.ToolTabStrip7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolTabStrip7.ResumeLayout(False)
            CType(Me.ToolTabStrip8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolTabStrip8.ResumeLayout(False)
            Me.toolResumen.ResumeLayout(False)
            Me.toolResumen.PerformLayout()
            CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
        Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
        Friend WithEvents ToolTabStrip4 As Telerik.WinControls.UI.Docking.ToolTabStrip
        Friend WithEvents calCalendario As Telerik.WinControls.UI.RadCalendar
        Friend WithEvents wbwMeteo As System.Windows.Forms.WebBrowser
        Friend WithEvents trbTiempo As Telerik.WinControls.UI.RadTrackBar
        Friend WithEvents btnActualizarMeteologia As Telerik.WinControls.UI.RadButton
        Friend WithEvents timerRefrescoInicio As System.Windows.Forms.Timer
        Friend WithEvents timerRefrescoDivisa As System.Windows.Forms.Timer
        Friend WithEvents timerRefrescoMeteo As System.Windows.Forms.Timer
        Friend WithEvents lblNumeroVenta As Telerik.WinControls.UI.RadLabel
        Friend WithEvents lblTotalVenta As Telerik.WinControls.UI.RadLabel
        Friend WithEvents toolTarea As Telerik.WinControls.UI.Docking.ToolWindow
        Friend WithEvents ListasCompraBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
        Friend WithEvents gridTareas As Telerik.WinControls.UI.RadGridView
        Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
        Friend WithEvents CommandBarRowElement2 As Telerik.WinControls.UI.CommandBarRowElement
        Friend WithEvents cbstripTarea As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents RadSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents SplitPanel3 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents SplitPanel4 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents TareasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents cbbtnAgregarTarea As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnEliminarTarea As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents dtpFechaTarea As Telerik.WinControls.UI.RadDateTimePicker
        Friend WithEvents ddlPrioridadTarea As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents txtTarea As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents ddlAviso As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents dtpTiempoAviso As Telerik.WinControls.UI.RadDateTimePicker
        Friend WithEvents btnCancelarTarea As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptarTarea As Telerik.WinControls.UI.RadButton
        Friend WithEvents PrioridadesTareaBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents cbbtnEditarTarea As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbtoggleTodasTareas As Telerik.WinControls.UI.CommandBarToggleButton
        Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
        Friend WithEvents TareaBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents EncargoBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents waitbTareas As Telerik.WinControls.UI.RadWaitingBar
        Friend WithEvents waitbMeteo As Telerik.WinControls.UI.RadWaitingBar
        Friend WithEvents bgwInicio As System.ComponentModel.BackgroundWorker
        Friend WithEvents RadSplitContainer3 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
        Friend WithEvents RadSplitContainer4 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents ToolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
        Friend WithEvents ToolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
        Friend WithEvents toolMeteo As Telerik.WinControls.UI.Docking.ToolWindow
        Friend WithEvents RadSplitContainer5 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents ToolTabStrip6 As Telerik.WinControls.UI.Docking.ToolTabStrip
        Friend WithEvents toolCalendario As Telerik.WinControls.UI.Docking.ToolWindow
        Friend WithEvents ToolTabStrip7 As Telerik.WinControls.UI.Docking.ToolTabStrip
        Friend WithEvents ToolTabStrip8 As Telerik.WinControls.UI.Docking.ToolTabStrip
        Friend WithEvents toolResumen As Telerik.WinControls.UI.Docking.ToolWindow
        Friend WithEvents waitbDivisa As Telerik.WinControls.UI.RadWaitingBar
        Friend WithEvents btnActualizarDivisa As Telerik.WinControls.UI.RadButton
        Friend WithEvents trbDivisa As Telerik.WinControls.UI.RadTrackBar
        Friend WithEvents wbwDivisa As System.Windows.Forms.WebBrowser
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents SplitPanel1 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents gridListaCompra As Telerik.WinControls.UI.RadGridView
        Friend WithEvents SplitPanel2 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents gboxEncargo As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents btnBuscarProducto As Telerik.WinControls.UI.RadButton
        Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents txtNombre As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtTelefono As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents chkRecogido As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents spinFianza As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents spinCantidad As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents dtpRecogida As Telerik.WinControls.UI.RadDateTimePicker
        Friend WithEvents txtProducto As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtReferencia As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents btnCancelarEncargo As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptarEncargo As Telerik.WinControls.UI.RadButton
        Friend WithEvents chkSuspendido As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents txtObservacion As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents cbListaCompra As Telerik.WinControls.UI.RadCommandBar
        Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
        Friend WithEvents cbstripListasCompra As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents cbbtnAgregarEncargo As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnEditarEncargo As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
        Friend WithEvents cbddbRecargarLista As Telerik.WinControls.UI.CommandBarDropDownButton
        Friend WithEvents mnitemReciente As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mnitemTodas As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents cbbtnImprimirLista As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents RadClock1 As Telerik.WinControls.UI.RadClock
        Friend WithEvents RoundRectShape1 As Telerik.WinControls.RoundRectShape
    End Class

End Namespace

