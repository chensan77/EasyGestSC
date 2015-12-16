Namespace Presentacion.Formulario.Proveedor

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmProveedor
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
            Dim CodigoPostalLabel As System.Windows.Forms.Label
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedor))
            Dim DireccionLabel As System.Windows.Forms.Label
            Dim EmailLabel As System.Windows.Forms.Label
            Dim FaxLabel As System.Windows.Forms.Label
            Dim LocalidadLabel As System.Windows.Forms.Label
            Dim MovilLabel As System.Windows.Forms.Label
            Dim NombreYNombreCNLabel As System.Windows.Forms.Label
            Dim TelefonoLabel As System.Windows.Forms.Label
            Dim ProvinciaLabel As System.Windows.Forms.Label
            Dim PaisLabel As System.Windows.Forms.Label
            Dim NombreContactoLabel As System.Windows.Forms.Label
            Dim ObservacionLabel As System.Windows.Forms.Label
            Dim ActivoLabel As System.Windows.Forms.Label
            Dim PendienteLabel As System.Windows.Forms.Label
            Dim FCreacionLabel As System.Windows.Forms.Label
            Dim FModificacionLabel As System.Windows.Forms.Label
            Dim IdentificacionLabel As System.Windows.Forms.Label
            Dim TipoIdentificacionLabel As System.Windows.Forms.Label
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim InputBinding1 As Telerik.WinControls.Keyboard.InputBinding = New Telerik.WinControls.Keyboard.InputBinding()
            Dim Chord1 As Telerik.WinControls.Keyboard.Chord = New Telerik.WinControls.Keyboard.Chord()
            Dim ChordModifier1 As Telerik.WinControls.Keyboard.ChordModifier = New Telerik.WinControls.Keyboard.ChordModifier()
            Dim ClickCommand1 As Telerik.WinControls.Elements.ClickCommand = New Telerik.WinControls.Elements.ClickCommand()
            Me.cbbtnAgregar = New Telerik.WinControls.UI.CommandBarButton()
            Me.gridDatos = New Telerik.WinControls.UI.RadGridView()
            Me.VWProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.cbComandos = New Telerik.WinControls.UI.RadCommandBar()
            Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.cbstripeAccion = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbbtnEliminar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnModificar = New Telerik.WinControls.UI.CommandBarButton()
            Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.cbbtnContactos = New Telerik.WinControls.UI.CommandBarDropDownButton()
            Me.mitemAgregarContacto = New Telerik.WinControls.UI.RadMenuItem()
            Me.cbbtnCuentas = New Telerik.WinControls.UI.CommandBarDropDownButton()
            Me.mitemAgregarCuenta = New Telerik.WinControls.UI.RadMenuItem()
            Me.cbbtnPagos = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbstripeBusqueda = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbstripeOrden = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.SplitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.statuInfo = New Telerik.WinControls.UI.RadStatusStrip()
            Me.btneAnterior = New Telerik.WinControls.UI.RadButtonElement()
            Me.btneSiguiente = New Telerik.WinControls.UI.RadButtonElement()
            Me.lblePagina = New Telerik.WinControls.UI.RadLabelElement()
            Me.RadToolStripSeparatorItem1 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.lbleDiagnostico = New Telerik.WinControls.UI.RadLabelElement()
            Me.chkeNoActivos = New Telerik.WinControls.UI.RadCheckBoxElement()
            Me.chkePaginar = New Telerik.WinControls.UI.RadCheckBoxElement()
            Me.SplitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.pvInfo = New Telerik.WinControls.UI.RadPageView()
            Me.pvpDetalle = New Telerik.WinControls.UI.RadPageViewPage()
            Me.TipoIdentificacionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.VWProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.IdentificacionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.NombreContactoRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.PaisRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.ProvinciaRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.TelefonoRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.NombreYNombreCNRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.MovilRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.LocalidadRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.FaxRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.EmailRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.DireccionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.CodigoPostalRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.pvpOtro = New Telerik.WinControls.UI.RadPageViewPage()
            Me.FModificacionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.FCreacionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.PendienteRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.ActivoRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.ObservacionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.bgwCarga = New System.ComponentModel.BackgroundWorker()
            CodigoPostalLabel = New System.Windows.Forms.Label()
            DireccionLabel = New System.Windows.Forms.Label()
            EmailLabel = New System.Windows.Forms.Label()
            FaxLabel = New System.Windows.Forms.Label()
            LocalidadLabel = New System.Windows.Forms.Label()
            MovilLabel = New System.Windows.Forms.Label()
            NombreYNombreCNLabel = New System.Windows.Forms.Label()
            TelefonoLabel = New System.Windows.Forms.Label()
            ProvinciaLabel = New System.Windows.Forms.Label()
            PaisLabel = New System.Windows.Forms.Label()
            NombreContactoLabel = New System.Windows.Forms.Label()
            ObservacionLabel = New System.Windows.Forms.Label()
            ActivoLabel = New System.Windows.Forms.Label()
            PendienteLabel = New System.Windows.Forms.Label()
            FCreacionLabel = New System.Windows.Forms.Label()
            FModificacionLabel = New System.Windows.Forms.Label()
            IdentificacionLabel = New System.Windows.Forms.Label()
            TipoIdentificacionLabel = New System.Windows.Forms.Label()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.VWProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer1.SuspendLayout()
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel1.SuspendLayout()
            CType(Me.statuInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel2.SuspendLayout()
            CType(Me.pvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pvInfo.SuspendLayout()
            Me.pvpDetalle.SuspendLayout()
            CType(Me.TipoIdentificacionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.VWProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IdentificacionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NombreContactoRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PaisRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProvinciaRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TelefonoRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NombreYNombreCNRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MovilRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LocalidadRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FaxRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmailRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DireccionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CodigoPostalRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pvpOtro.SuspendLayout()
            CType(Me.FModificacionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FCreacionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PendienteRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ActivoRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ObservacionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'CodigoPostalLabel
            '
            resources.ApplyResources(CodigoPostalLabel, "CodigoPostalLabel")
            CodigoPostalLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            CodigoPostalLabel.Name = "CodigoPostalLabel"
            '
            'DireccionLabel
            '
            resources.ApplyResources(DireccionLabel, "DireccionLabel")
            DireccionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            DireccionLabel.Name = "DireccionLabel"
            '
            'EmailLabel
            '
            resources.ApplyResources(EmailLabel, "EmailLabel")
            EmailLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            EmailLabel.Name = "EmailLabel"
            '
            'FaxLabel
            '
            resources.ApplyResources(FaxLabel, "FaxLabel")
            FaxLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            FaxLabel.Name = "FaxLabel"
            '
            'LocalidadLabel
            '
            resources.ApplyResources(LocalidadLabel, "LocalidadLabel")
            LocalidadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            LocalidadLabel.Name = "LocalidadLabel"
            '
            'MovilLabel
            '
            resources.ApplyResources(MovilLabel, "MovilLabel")
            MovilLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            MovilLabel.Name = "MovilLabel"
            '
            'NombreYNombreCNLabel
            '
            resources.ApplyResources(NombreYNombreCNLabel, "NombreYNombreCNLabel")
            NombreYNombreCNLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            NombreYNombreCNLabel.Name = "NombreYNombreCNLabel"
            '
            'TelefonoLabel
            '
            resources.ApplyResources(TelefonoLabel, "TelefonoLabel")
            TelefonoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            TelefonoLabel.Name = "TelefonoLabel"
            '
            'ProvinciaLabel
            '
            resources.ApplyResources(ProvinciaLabel, "ProvinciaLabel")
            ProvinciaLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ProvinciaLabel.Name = "ProvinciaLabel"
            '
            'PaisLabel
            '
            resources.ApplyResources(PaisLabel, "PaisLabel")
            PaisLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            PaisLabel.Name = "PaisLabel"
            '
            'NombreContactoLabel
            '
            resources.ApplyResources(NombreContactoLabel, "NombreContactoLabel")
            NombreContactoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            NombreContactoLabel.Name = "NombreContactoLabel"
            '
            'ObservacionLabel
            '
            resources.ApplyResources(ObservacionLabel, "ObservacionLabel")
            ObservacionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ObservacionLabel.Name = "ObservacionLabel"
            '
            'ActivoLabel
            '
            resources.ApplyResources(ActivoLabel, "ActivoLabel")
            ActivoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            ActivoLabel.Name = "ActivoLabel"
            '
            'PendienteLabel
            '
            resources.ApplyResources(PendienteLabel, "PendienteLabel")
            PendienteLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            PendienteLabel.Name = "PendienteLabel"
            '
            'FCreacionLabel
            '
            resources.ApplyResources(FCreacionLabel, "FCreacionLabel")
            FCreacionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            FCreacionLabel.Name = "FCreacionLabel"
            '
            'FModificacionLabel
            '
            resources.ApplyResources(FModificacionLabel, "FModificacionLabel")
            FModificacionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            FModificacionLabel.Name = "FModificacionLabel"
            '
            'IdentificacionLabel
            '
            resources.ApplyResources(IdentificacionLabel, "IdentificacionLabel")
            IdentificacionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            IdentificacionLabel.Name = "IdentificacionLabel"
            '
            'TipoIdentificacionLabel
            '
            resources.ApplyResources(TipoIdentificacionLabel, "TipoIdentificacionLabel")
            TipoIdentificacionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            TipoIdentificacionLabel.Name = "TipoIdentificacionLabel"
            '
            'cbbtnAgregar
            '
            resources.ApplyResources(Me.cbbtnAgregar, "cbbtnAgregar")
            Me.cbbtnAgregar.DisplayName = "Agregar"
            Me.cbbtnAgregar.DrawText = True
            Me.cbbtnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnAgregar.Image = Global.EasyGest.My.Resources.Resources._127
            Me.cbbtnAgregar.Name = "cbbtnAgregar"
            Me.cbbtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnAgregar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'gridDatos
            '
            Me.gridDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDatos.Cursor = System.Windows.Forms.Cursors.Default
            resources.ApplyResources(Me.gridDatos, "gridDatos")
            Me.gridDatos.ForeColor = System.Drawing.Color.Black
            '
            'gridDatos
            '
            Me.gridDatos.MasterTemplate.AllowAddNewRow = False
            Me.gridDatos.MasterTemplate.AllowRowResize = False
            Me.gridDatos.MasterTemplate.AutoGenerateColumns = False
            GridViewTextBoxColumn1.AllowFiltering = False
            GridViewTextBoxColumn1.AllowGroup = False
            GridViewTextBoxColumn1.AllowSort = False
            GridViewTextBoxColumn1.EnableExpressionEditor = False
            GridViewTextBoxColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text
            GridViewTextBoxColumn1.FieldName = "Numero"
            resources.ApplyResources(GridViewTextBoxColumn1, "GridViewTextBoxColumn1")
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.IsPinned = True
            GridViewTextBoxColumn1.Name = "Numero"
            GridViewTextBoxColumn1.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewTextBoxColumn1.ReadOnly = True
            GridViewTextBoxColumn1.Width = 84
            GridViewTextBoxColumn2.AllowGroup = False
            GridViewTextBoxColumn2.EnableExpressionEditor = False
            GridViewTextBoxColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text
            GridViewTextBoxColumn2.FieldName = "NombreYNombreCN"
            resources.ApplyResources(GridViewTextBoxColumn2, "GridViewTextBoxColumn2")
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.IsPinned = True
            GridViewTextBoxColumn2.Name = "NombreYNombreCN"
            GridViewTextBoxColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewTextBoxColumn2.ReadOnly = True
            GridViewTextBoxColumn2.Width = 215
            GridViewTextBoxColumn3.AllowFiltering = False
            GridViewTextBoxColumn3.AllowGroup = False
            GridViewTextBoxColumn3.EnableExpressionEditor = False
            GridViewTextBoxColumn3.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text
            GridViewTextBoxColumn3.FieldName = "TipoIdentificacion"
            resources.ApplyResources(GridViewTextBoxColumn3, "GridViewTextBoxColumn3")
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.Name = "TipoIdentificacion"
            GridViewTextBoxColumn3.ReadOnly = True
            GridViewTextBoxColumn3.Width = 101
            GridViewTextBoxColumn4.AllowGroup = False
            GridViewTextBoxColumn4.EnableExpressionEditor = False
            GridViewTextBoxColumn4.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text
            GridViewTextBoxColumn4.FieldName = "Identificacion"
            resources.ApplyResources(GridViewTextBoxColumn4, "GridViewTextBoxColumn4")
            GridViewTextBoxColumn4.IsAutoGenerated = True
            GridViewTextBoxColumn4.Name = "Identificacion"
            GridViewTextBoxColumn4.Width = 130
            GridViewTextBoxColumn5.EnableExpressionEditor = False
            GridViewTextBoxColumn5.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Text
            GridViewTextBoxColumn5.FieldName = "NombreContacto"
            resources.ApplyResources(GridViewTextBoxColumn5, "GridViewTextBoxColumn5")
            GridViewTextBoxColumn5.IsAutoGenerated = True
            GridViewTextBoxColumn5.Name = "NombreContacto"
            GridViewTextBoxColumn5.Width = 239
            Me.gridDatos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5})
            Me.gridDatos.MasterTemplate.DataSource = Me.VWProveedoresBindingSource
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
            Me.gridDatos.RootElement.Margin = CType(resources.GetObject("gridDatos.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.gridDatos.RootElement.Padding = CType(resources.GetObject("gridDatos.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.gridDatos.RootElement.Text = resources.GetString("gridDatos.RootElement.Text")
            Me.gridDatos.RootElement.TextOrientation = CType(resources.GetObject("gridDatos.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.gridDatos.ShowGroupPanel = False
            '
            'VWProveedoresBindingSource
            '
            Me.VWProveedoresBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.VWProveedores)
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
            Me.cbComandos.RootElement.Margin = CType(resources.GetObject("cbComandos.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.cbComandos.RootElement.Padding = CType(resources.GetObject("cbComandos.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.cbComandos.RootElement.Text = resources.GetString("cbComandos.RootElement.Text")
            Me.cbComandos.RootElement.TextOrientation = CType(resources.GetObject("cbComandos.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.cbComandos.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
            '
            'CommandBarRowElement1
            '
            resources.ApplyResources(Me.CommandBarRowElement1, "CommandBarRowElement1")
            Me.CommandBarRowElement1.DisplayName = Nothing
            Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
            Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.cbstripeAccion, Me.cbstripeBusqueda, Me.cbstripeOrden})
            '
            'cbstripeAccion
            '
            resources.ApplyResources(Me.cbstripeAccion, "cbstripeAccion")
            Me.cbstripeAccion.DisplayName = "Operación"
            Me.cbstripeAccion.EnableDragging = False
            Me.cbstripeAccion.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbtnAgregar, Me.cbbtnEliminar, Me.cbbtnModificar, Me.CommandBarSeparator2, Me.cbbtnContactos, Me.cbbtnCuentas, Me.cbbtnPagos})
            Me.cbstripeAccion.Name = "CommandBarStripElement1"
            '
            'cbbtnEliminar
            '
            resources.ApplyResources(Me.cbbtnEliminar, "cbbtnEliminar")
            Me.cbbtnEliminar.DisplayName = "Eliminar"
            Me.cbbtnEliminar.DrawText = True
            Me.cbbtnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnEliminar.Image = Global.EasyGest.My.Resources.Resources._128
            Me.cbbtnEliminar.Name = "cbbtnEliminar"
            Me.cbbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnEliminar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbbtnModificar
            '
            resources.ApplyResources(Me.cbbtnModificar, "cbbtnModificar")
            Me.cbbtnModificar.DisplayName = "Modificar"
            Me.cbbtnModificar.DrawText = True
            Me.cbbtnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnModificar.Image = Global.EasyGest.My.Resources.Resources._130
            Me.cbbtnModificar.Name = "cbbtnModificar"
            Me.cbbtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnModificar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'CommandBarSeparator2
            '
            resources.ApplyResources(Me.CommandBarSeparator2, "CommandBarSeparator2")
            Me.CommandBarSeparator2.DisplayName = "CommandBarSeparator2"
            Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
            Me.CommandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.CommandBarSeparator2.VisibleInOverflowMenu = False
            '
            'cbbtnContactos
            '
            resources.ApplyResources(Me.cbbtnContactos, "cbbtnContactos")
            Me.cbbtnContactos.DisplayName = "Contactos"
            Me.cbbtnContactos.DrawText = True
            Me.cbbtnContactos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnContactos.Image = Global.EasyGest.My.Resources.Resources._75
            Me.cbbtnContactos.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemAgregarContacto})
            Me.cbbtnContactos.Name = "cbbtnContactos"
            Me.cbbtnContactos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnContactos.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mitemAgregarContacto
            '
            resources.ApplyResources(Me.mitemAgregarContacto, "mitemAgregarContacto")
            Me.mitemAgregarContacto.DescriptionFont = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemAgregarContacto.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemAgregarContacto.Image = Global.EasyGest.My.Resources.Resources._112
            Me.mitemAgregarContacto.Name = "mitemAgregarContacto"
            Me.mitemAgregarContacto.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbbtnCuentas
            '
            resources.ApplyResources(Me.cbbtnCuentas, "cbbtnCuentas")
            Me.cbbtnCuentas.DisplayName = "Bancarios"
            Me.cbbtnCuentas.DrawText = True
            Me.cbbtnCuentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnCuentas.Image = Global.EasyGest.My.Resources.Resources._80
            Me.cbbtnCuentas.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemAgregarCuenta})
            Me.cbbtnCuentas.Name = "cbbtnCuentas"
            Me.cbbtnCuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnCuentas.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'mitemAgregarCuenta
            '
            resources.ApplyResources(Me.mitemAgregarCuenta, "mitemAgregarCuenta")
            Me.mitemAgregarCuenta.DescriptionFont = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemAgregarCuenta.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemAgregarCuenta.Image = Global.EasyGest.My.Resources.Resources._112
            Me.mitemAgregarCuenta.Name = "mitemAgregarCuenta"
            Me.mitemAgregarCuenta.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbbtnPagos
            '
            resources.ApplyResources(Me.cbbtnPagos, "cbbtnPagos")
            Me.cbbtnPagos.DisplayName = "Pagos"
            Me.cbbtnPagos.DrawText = True
            Me.cbbtnPagos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnPagos.Image = Global.EasyGest.My.Resources.Resources._88
            Me.cbbtnPagos.Name = "cbbtnPagos"
            Me.cbbtnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnPagos.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbstripeBusqueda
            '
            resources.ApplyResources(Me.cbstripeBusqueda, "cbstripeBusqueda")
            Me.cbstripeBusqueda.DisplayName = "Busqueda"
            Me.cbstripeBusqueda.DrawFill = True
            Me.cbstripeBusqueda.DrawText = False
            Me.cbstripeBusqueda.EnableDragging = False
            Me.cbstripeBusqueda.Name = "CommandBarStripElement2"
            '
            'cbstripeOrden
            '
            resources.ApplyResources(Me.cbstripeOrden, "cbstripeOrden")
            Me.cbstripeOrden.DisplayName = "Ordenación"
            Me.cbstripeOrden.Name = "CommandBarStripElement1"
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
            Me.SplitPanel1.Controls.Add(Me.gridDatos)
            Me.SplitPanel1.Controls.Add(Me.statuInfo)
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
            Me.SplitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.1980109!, 0.0!)
            Me.SplitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(189, 0)
            Me.SplitPanel1.TabStop = False
            '
            'statuInfo
            '
            resources.ApplyResources(Me.statuInfo, "statuInfo")
            Me.statuInfo.Items.AddRange(New Telerik.WinControls.RadItem() {Me.btneAnterior, Me.btneSiguiente, Me.lblePagina, Me.RadToolStripSeparatorItem1, Me.lbleDiagnostico, Me.chkeNoActivos, Me.chkePaginar})
            Me.statuInfo.Name = "statuInfo"
            '
            '
            '
            Me.statuInfo.RootElement.AccessibleDescription = resources.GetString("statuInfo.RootElement.AccessibleDescription")
            Me.statuInfo.RootElement.AccessibleName = resources.GetString("statuInfo.RootElement.AccessibleName")
            Me.statuInfo.RootElement.Alignment = CType(resources.GetObject("statuInfo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.statuInfo.RootElement.AngleTransform = CType(resources.GetObject("statuInfo.RootElement.AngleTransform"), Single)
            Me.statuInfo.RootElement.FlipText = CType(resources.GetObject("statuInfo.RootElement.FlipText"), Boolean)
            Me.statuInfo.RootElement.Margin = CType(resources.GetObject("statuInfo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.statuInfo.RootElement.Padding = CType(resources.GetObject("statuInfo.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.statuInfo.RootElement.Text = resources.GetString("statuInfo.RootElement.Text")
            Me.statuInfo.RootElement.TextOrientation = CType(resources.GetObject("statuInfo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'btneAnterior
            '
            resources.ApplyResources(Me.btneAnterior, "btneAnterior")
            Me.btneAnterior.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.btneAnterior.Image = Global.EasyGest.My.Resources.Resources.left
            Me.btneAnterior.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.btneAnterior.Name = "btneAnterior"
            Me.btneAnterior.ShowBorder = False
            Me.statuInfo.SetSpring(Me.btneAnterior, False)
            Me.btneAnterior.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'btneSiguiente
            '
            resources.ApplyResources(Me.btneSiguiente, "btneSiguiente")
            Me.btneSiguiente.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
            Me.btneSiguiente.Image = Global.EasyGest.My.Resources.Resources.right
            Me.btneSiguiente.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.btneSiguiente.Name = "btneSiguiente"
            Me.btneSiguiente.ShowBorder = False
            Me.statuInfo.SetSpring(Me.btneSiguiente, False)
            Me.btneSiguiente.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'lblePagina
            '
            resources.ApplyResources(Me.lblePagina, "lblePagina")
            Me.lblePagina.AutoSize = False
            Me.lblePagina.Bounds = New System.Drawing.Rectangle(0, 0, 54, 20)
            Me.lblePagina.Name = "lblePagina"
            Me.statuInfo.SetSpring(Me.lblePagina, False)
            Me.lblePagina.TextWrap = True
            Me.lblePagina.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'RadToolStripSeparatorItem1
            '
            resources.ApplyResources(Me.RadToolStripSeparatorItem1, "RadToolStripSeparatorItem1")
            Me.RadToolStripSeparatorItem1.Name = "RadToolStripSeparatorItem1"
            Me.statuInfo.SetSpring(Me.RadToolStripSeparatorItem1, False)
            Me.RadToolStripSeparatorItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.RadToolStripSeparatorItem1.VisibleInOverflowMenu = False
            '
            'lbleDiagnostico
            '
            resources.ApplyResources(Me.lbleDiagnostico, "lbleDiagnostico")
            Me.lbleDiagnostico.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbleDiagnostico.Name = "lbleDiagnostico"
            Me.statuInfo.SetSpring(Me.lbleDiagnostico, True)
            Me.lbleDiagnostico.TextWrap = True
            Me.lbleDiagnostico.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'chkeNoActivos
            '
            resources.ApplyResources(Me.chkeNoActivos, "chkeNoActivos")
            Me.chkeNoActivos.AutoSize = True
            Me.chkeNoActivos.Checked = False
            Me.chkeNoActivos.Font = New System.Drawing.Font("楷体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkeNoActivos.Name = "chkeNoActivos"
            Me.chkeNoActivos.PositionOffset = New System.Drawing.SizeF(0.0!, 0.0!)
            Me.statuInfo.SetSpring(Me.chkeNoActivos, False)
            Me.chkeNoActivos.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'chkePaginar
            '
            resources.ApplyResources(Me.chkePaginar, "chkePaginar")
            Me.chkePaginar.CheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.chkePaginar.Checked = True
            Me.chkePaginar.Font = New System.Drawing.Font("楷体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkePaginar.Image = Global.EasyGest.My.Resources.Resources.categories
            Me.chkePaginar.Name = "chkePaginar"
            Me.statuInfo.SetSpring(Me.chkePaginar, False)
            Me.chkePaginar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.chkePaginar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Me.chkePaginar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'SplitPanel2
            '
            Me.SplitPanel2.Controls.Add(Me.pvInfo)
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
            Me.SplitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.1980109!, 0.0!)
            Me.SplitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(-189, 0)
            Me.SplitPanel2.TabStop = False
            '
            'pvInfo
            '
            Me.pvInfo.Controls.Add(Me.pvpDetalle)
            Me.pvInfo.Controls.Add(Me.pvpOtro)
            resources.ApplyResources(Me.pvInfo, "pvInfo")
            Me.pvInfo.Name = "pvInfo"
            '
            '
            '
            Me.pvInfo.RootElement.AccessibleDescription = resources.GetString("pvInfo.RootElement.AccessibleDescription")
            Me.pvInfo.RootElement.AccessibleName = resources.GetString("pvInfo.RootElement.AccessibleName")
            Me.pvInfo.RootElement.Alignment = CType(resources.GetObject("pvInfo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.pvInfo.RootElement.AngleTransform = CType(resources.GetObject("pvInfo.RootElement.AngleTransform"), Single)
            Me.pvInfo.RootElement.FlipText = CType(resources.GetObject("pvInfo.RootElement.FlipText"), Boolean)
            Me.pvInfo.RootElement.Margin = CType(resources.GetObject("pvInfo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.pvInfo.RootElement.Padding = CType(resources.GetObject("pvInfo.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.pvInfo.RootElement.Text = resources.GetString("pvInfo.RootElement.Text")
            Me.pvInfo.RootElement.TextOrientation = CType(resources.GetObject("pvInfo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.pvInfo.SelectedPage = Me.pvpOtro
            Me.pvInfo.TabStop = False
            CType(Me.pvInfo.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSpacing = 3
            '
            'pvpDetalle
            '
            Me.pvpDetalle.Controls.Add(TipoIdentificacionLabel)
            Me.pvpDetalle.Controls.Add(Me.TipoIdentificacionRadLabel)
            Me.pvpDetalle.Controls.Add(IdentificacionLabel)
            Me.pvpDetalle.Controls.Add(Me.IdentificacionRadLabel)
            Me.pvpDetalle.Controls.Add(NombreContactoLabel)
            Me.pvpDetalle.Controls.Add(Me.NombreContactoRadLabel)
            Me.pvpDetalle.Controls.Add(PaisLabel)
            Me.pvpDetalle.Controls.Add(Me.PaisRadLabel)
            Me.pvpDetalle.Controls.Add(ProvinciaLabel)
            Me.pvpDetalle.Controls.Add(Me.ProvinciaRadLabel)
            Me.pvpDetalle.Controls.Add(TelefonoLabel)
            Me.pvpDetalle.Controls.Add(Me.TelefonoRadLabel)
            Me.pvpDetalle.Controls.Add(NombreYNombreCNLabel)
            Me.pvpDetalle.Controls.Add(Me.NombreYNombreCNRadLabel)
            Me.pvpDetalle.Controls.Add(MovilLabel)
            Me.pvpDetalle.Controls.Add(Me.MovilRadLabel)
            Me.pvpDetalle.Controls.Add(LocalidadLabel)
            Me.pvpDetalle.Controls.Add(Me.LocalidadRadLabel)
            Me.pvpDetalle.Controls.Add(FaxLabel)
            Me.pvpDetalle.Controls.Add(Me.FaxRadLabel)
            Me.pvpDetalle.Controls.Add(EmailLabel)
            Me.pvpDetalle.Controls.Add(Me.EmailRadLabel)
            Me.pvpDetalle.Controls.Add(DireccionLabel)
            Me.pvpDetalle.Controls.Add(Me.DireccionRadLabel)
            Me.pvpDetalle.Controls.Add(CodigoPostalLabel)
            Me.pvpDetalle.Controls.Add(Me.CodigoPostalRadLabel)
            Me.pvpDetalle.Description = Nothing
            resources.ApplyResources(Me.pvpDetalle, "pvpDetalle")
            Me.pvpDetalle.Name = "pvpDetalle"
            Me.pvpDetalle.Title = "Detalle"
            '
            'TipoIdentificacionRadLabel
            '
            resources.ApplyResources(Me.TipoIdentificacionRadLabel, "TipoIdentificacionRadLabel")
            Me.TipoIdentificacionRadLabel.BorderVisible = True
            Me.TipoIdentificacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "TipoIdentificacion", True))
            Me.TipoIdentificacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.TipoIdentificacionRadLabel.Name = "TipoIdentificacionRadLabel"
            '
            '
            '
            Me.TipoIdentificacionRadLabel.RootElement.AccessibleDescription = resources.GetString("TipoIdentificacionRadLabel.RootElement.AccessibleDescription")
            Me.TipoIdentificacionRadLabel.RootElement.AccessibleName = resources.GetString("TipoIdentificacionRadLabel.RootElement.AccessibleName")
            Me.TipoIdentificacionRadLabel.RootElement.Alignment = CType(resources.GetObject("TipoIdentificacionRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.TipoIdentificacionRadLabel.RootElement.AngleTransform = CType(resources.GetObject("TipoIdentificacionRadLabel.RootElement.AngleTransform"), Single)
            Me.TipoIdentificacionRadLabel.RootElement.FlipText = CType(resources.GetObject("TipoIdentificacionRadLabel.RootElement.FlipText"), Boolean)
            Me.TipoIdentificacionRadLabel.RootElement.Margin = CType(resources.GetObject("TipoIdentificacionRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.TipoIdentificacionRadLabel.RootElement.Padding = CType(resources.GetObject("TipoIdentificacionRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.TipoIdentificacionRadLabel.RootElement.Text = resources.GetString("TipoIdentificacionRadLabel.RootElement.Text")
            Me.TipoIdentificacionRadLabel.RootElement.TextOrientation = CType(resources.GetObject("TipoIdentificacionRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.TipoIdentificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.TipoIdentificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment"), System.Drawing.ContentAlignment)
            CType(Me.TipoIdentificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text")
            CType(Me.TipoIdentificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.TipoIdentificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'VWProveedorBindingSource
            '
            Me.VWProveedorBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.VWProveedores)
            '
            'IdentificacionRadLabel
            '
            resources.ApplyResources(Me.IdentificacionRadLabel, "IdentificacionRadLabel")
            Me.IdentificacionRadLabel.BorderVisible = True
            Me.IdentificacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "Identificacion", True))
            Me.IdentificacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.IdentificacionRadLabel.Name = "IdentificacionRadLabel"
            '
            '
            '
            Me.IdentificacionRadLabel.RootElement.AccessibleDescription = resources.GetString("IdentificacionRadLabel.RootElement.AccessibleDescription")
            Me.IdentificacionRadLabel.RootElement.AccessibleName = resources.GetString("IdentificacionRadLabel.RootElement.AccessibleName")
            Me.IdentificacionRadLabel.RootElement.Alignment = CType(resources.GetObject("IdentificacionRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.IdentificacionRadLabel.RootElement.AngleTransform = CType(resources.GetObject("IdentificacionRadLabel.RootElement.AngleTransform"), Single)
            Me.IdentificacionRadLabel.RootElement.FlipText = CType(resources.GetObject("IdentificacionRadLabel.RootElement.FlipText"), Boolean)
            Me.IdentificacionRadLabel.RootElement.Margin = CType(resources.GetObject("IdentificacionRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.IdentificacionRadLabel.RootElement.Padding = CType(resources.GetObject("IdentificacionRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.IdentificacionRadLabel.RootElement.Text = resources.GetString("IdentificacionRadLabel.RootElement.Text")
            Me.IdentificacionRadLabel.RootElement.TextOrientation = CType(resources.GetObject("IdentificacionRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.IdentificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.IdentificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment1"), System.Drawing.ContentAlignment)
            CType(Me.IdentificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text1")
            CType(Me.IdentificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.IdentificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'NombreContactoRadLabel
            '
            resources.ApplyResources(Me.NombreContactoRadLabel, "NombreContactoRadLabel")
            Me.NombreContactoRadLabel.BorderVisible = True
            Me.NombreContactoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "NombreContacto", True))
            Me.NombreContactoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.NombreContactoRadLabel.Name = "NombreContactoRadLabel"
            '
            '
            '
            Me.NombreContactoRadLabel.RootElement.AccessibleDescription = resources.GetString("NombreContactoRadLabel.RootElement.AccessibleDescription")
            Me.NombreContactoRadLabel.RootElement.AccessibleName = resources.GetString("NombreContactoRadLabel.RootElement.AccessibleName")
            Me.NombreContactoRadLabel.RootElement.Alignment = CType(resources.GetObject("NombreContactoRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.NombreContactoRadLabel.RootElement.AngleTransform = CType(resources.GetObject("NombreContactoRadLabel.RootElement.AngleTransform"), Single)
            Me.NombreContactoRadLabel.RootElement.FlipText = CType(resources.GetObject("NombreContactoRadLabel.RootElement.FlipText"), Boolean)
            Me.NombreContactoRadLabel.RootElement.Margin = CType(resources.GetObject("NombreContactoRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.NombreContactoRadLabel.RootElement.Padding = CType(resources.GetObject("NombreContactoRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.NombreContactoRadLabel.RootElement.Text = resources.GetString("NombreContactoRadLabel.RootElement.Text")
            Me.NombreContactoRadLabel.RootElement.TextOrientation = CType(resources.GetObject("NombreContactoRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.NombreContactoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.NombreContactoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment2"), System.Drawing.ContentAlignment)
            CType(Me.NombreContactoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text2")
            CType(Me.NombreContactoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.NombreContactoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'PaisRadLabel
            '
            resources.ApplyResources(Me.PaisRadLabel, "PaisRadLabel")
            Me.PaisRadLabel.BorderVisible = True
            Me.PaisRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "Pais", True))
            Me.PaisRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PaisRadLabel.Name = "PaisRadLabel"
            '
            '
            '
            Me.PaisRadLabel.RootElement.AccessibleDescription = resources.GetString("PaisRadLabel.RootElement.AccessibleDescription")
            Me.PaisRadLabel.RootElement.AccessibleName = resources.GetString("PaisRadLabel.RootElement.AccessibleName")
            Me.PaisRadLabel.RootElement.Alignment = CType(resources.GetObject("PaisRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.PaisRadLabel.RootElement.AngleTransform = CType(resources.GetObject("PaisRadLabel.RootElement.AngleTransform"), Single)
            Me.PaisRadLabel.RootElement.FlipText = CType(resources.GetObject("PaisRadLabel.RootElement.FlipText"), Boolean)
            Me.PaisRadLabel.RootElement.Margin = CType(resources.GetObject("PaisRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.PaisRadLabel.RootElement.Padding = CType(resources.GetObject("PaisRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.PaisRadLabel.RootElement.Text = resources.GetString("PaisRadLabel.RootElement.Text")
            Me.PaisRadLabel.RootElement.TextOrientation = CType(resources.GetObject("PaisRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.PaisRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.PaisRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment3"), System.Drawing.ContentAlignment)
            CType(Me.PaisRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text3")
            CType(Me.PaisRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.PaisRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ProvinciaRadLabel
            '
            resources.ApplyResources(Me.ProvinciaRadLabel, "ProvinciaRadLabel")
            Me.ProvinciaRadLabel.BorderVisible = True
            Me.ProvinciaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "Provincia", True))
            Me.ProvinciaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ProvinciaRadLabel.Name = "ProvinciaRadLabel"
            '
            '
            '
            Me.ProvinciaRadLabel.RootElement.AccessibleDescription = resources.GetString("ProvinciaRadLabel.RootElement.AccessibleDescription")
            Me.ProvinciaRadLabel.RootElement.AccessibleName = resources.GetString("ProvinciaRadLabel.RootElement.AccessibleName")
            Me.ProvinciaRadLabel.RootElement.Alignment = CType(resources.GetObject("ProvinciaRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ProvinciaRadLabel.RootElement.AngleTransform = CType(resources.GetObject("ProvinciaRadLabel.RootElement.AngleTransform"), Single)
            Me.ProvinciaRadLabel.RootElement.FlipText = CType(resources.GetObject("ProvinciaRadLabel.RootElement.FlipText"), Boolean)
            Me.ProvinciaRadLabel.RootElement.Margin = CType(resources.GetObject("ProvinciaRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ProvinciaRadLabel.RootElement.Padding = CType(resources.GetObject("ProvinciaRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ProvinciaRadLabel.RootElement.Text = resources.GetString("ProvinciaRadLabel.RootElement.Text")
            Me.ProvinciaRadLabel.RootElement.TextOrientation = CType(resources.GetObject("ProvinciaRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.ProvinciaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ProvinciaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment4"), System.Drawing.ContentAlignment)
            CType(Me.ProvinciaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text4")
            CType(Me.ProvinciaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ProvinciaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'TelefonoRadLabel
            '
            resources.ApplyResources(Me.TelefonoRadLabel, "TelefonoRadLabel")
            Me.TelefonoRadLabel.BorderVisible = True
            Me.TelefonoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "Telefono", True))
            Me.TelefonoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.TelefonoRadLabel.Name = "TelefonoRadLabel"
            '
            '
            '
            Me.TelefonoRadLabel.RootElement.AccessibleDescription = resources.GetString("TelefonoRadLabel.RootElement.AccessibleDescription")
            Me.TelefonoRadLabel.RootElement.AccessibleName = resources.GetString("TelefonoRadLabel.RootElement.AccessibleName")
            Me.TelefonoRadLabel.RootElement.Alignment = CType(resources.GetObject("TelefonoRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.TelefonoRadLabel.RootElement.AngleTransform = CType(resources.GetObject("TelefonoRadLabel.RootElement.AngleTransform"), Single)
            Me.TelefonoRadLabel.RootElement.FlipText = CType(resources.GetObject("TelefonoRadLabel.RootElement.FlipText"), Boolean)
            Me.TelefonoRadLabel.RootElement.Margin = CType(resources.GetObject("TelefonoRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.TelefonoRadLabel.RootElement.Padding = CType(resources.GetObject("TelefonoRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.TelefonoRadLabel.RootElement.Text = resources.GetString("TelefonoRadLabel.RootElement.Text")
            Me.TelefonoRadLabel.RootElement.TextOrientation = CType(resources.GetObject("TelefonoRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.TelefonoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.TelefonoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment5"), System.Drawing.ContentAlignment)
            CType(Me.TelefonoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text5")
            CType(Me.TelefonoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.TelefonoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'NombreYNombreCNRadLabel
            '
            resources.ApplyResources(Me.NombreYNombreCNRadLabel, "NombreYNombreCNRadLabel")
            Me.NombreYNombreCNRadLabel.BorderVisible = True
            Me.NombreYNombreCNRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "NombreYNombreCN", True))
            Me.NombreYNombreCNRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.NombreYNombreCNRadLabel.Name = "NombreYNombreCNRadLabel"
            '
            '
            '
            Me.NombreYNombreCNRadLabel.RootElement.AccessibleDescription = resources.GetString("NombreYNombreCNRadLabel.RootElement.AccessibleDescription")
            Me.NombreYNombreCNRadLabel.RootElement.AccessibleName = resources.GetString("NombreYNombreCNRadLabel.RootElement.AccessibleName")
            Me.NombreYNombreCNRadLabel.RootElement.Alignment = CType(resources.GetObject("NombreYNombreCNRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.NombreYNombreCNRadLabel.RootElement.AngleTransform = CType(resources.GetObject("NombreYNombreCNRadLabel.RootElement.AngleTransform"), Single)
            Me.NombreYNombreCNRadLabel.RootElement.FlipText = CType(resources.GetObject("NombreYNombreCNRadLabel.RootElement.FlipText"), Boolean)
            Me.NombreYNombreCNRadLabel.RootElement.Margin = CType(resources.GetObject("NombreYNombreCNRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.NombreYNombreCNRadLabel.RootElement.Padding = CType(resources.GetObject("NombreYNombreCNRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.NombreYNombreCNRadLabel.RootElement.Text = resources.GetString("NombreYNombreCNRadLabel.RootElement.Text")
            Me.NombreYNombreCNRadLabel.RootElement.TextOrientation = CType(resources.GetObject("NombreYNombreCNRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.NombreYNombreCNRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.NombreYNombreCNRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment6"), System.Drawing.ContentAlignment)
            CType(Me.NombreYNombreCNRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text6")
            CType(Me.NombreYNombreCNRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.NombreYNombreCNRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'MovilRadLabel
            '
            resources.ApplyResources(Me.MovilRadLabel, "MovilRadLabel")
            Me.MovilRadLabel.BorderVisible = True
            Me.MovilRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "Movil", True))
            Me.MovilRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.MovilRadLabel.Name = "MovilRadLabel"
            '
            '
            '
            Me.MovilRadLabel.RootElement.AccessibleDescription = resources.GetString("MovilRadLabel.RootElement.AccessibleDescription")
            Me.MovilRadLabel.RootElement.AccessibleName = resources.GetString("MovilRadLabel.RootElement.AccessibleName")
            Me.MovilRadLabel.RootElement.Alignment = CType(resources.GetObject("MovilRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.MovilRadLabel.RootElement.AngleTransform = CType(resources.GetObject("MovilRadLabel.RootElement.AngleTransform"), Single)
            Me.MovilRadLabel.RootElement.FlipText = CType(resources.GetObject("MovilRadLabel.RootElement.FlipText"), Boolean)
            Me.MovilRadLabel.RootElement.Margin = CType(resources.GetObject("MovilRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.MovilRadLabel.RootElement.Padding = CType(resources.GetObject("MovilRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.MovilRadLabel.RootElement.Text = resources.GetString("MovilRadLabel.RootElement.Text")
            Me.MovilRadLabel.RootElement.TextOrientation = CType(resources.GetObject("MovilRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.MovilRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.MovilRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment7"), System.Drawing.ContentAlignment)
            CType(Me.MovilRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text7")
            CType(Me.MovilRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.MovilRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'LocalidadRadLabel
            '
            resources.ApplyResources(Me.LocalidadRadLabel, "LocalidadRadLabel")
            Me.LocalidadRadLabel.BorderVisible = True
            Me.LocalidadRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "Localidad", True))
            Me.LocalidadRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.LocalidadRadLabel.Name = "LocalidadRadLabel"
            '
            '
            '
            Me.LocalidadRadLabel.RootElement.AccessibleDescription = resources.GetString("LocalidadRadLabel.RootElement.AccessibleDescription")
            Me.LocalidadRadLabel.RootElement.AccessibleName = resources.GetString("LocalidadRadLabel.RootElement.AccessibleName")
            Me.LocalidadRadLabel.RootElement.Alignment = CType(resources.GetObject("LocalidadRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.LocalidadRadLabel.RootElement.AngleTransform = CType(resources.GetObject("LocalidadRadLabel.RootElement.AngleTransform"), Single)
            Me.LocalidadRadLabel.RootElement.FlipText = CType(resources.GetObject("LocalidadRadLabel.RootElement.FlipText"), Boolean)
            Me.LocalidadRadLabel.RootElement.Margin = CType(resources.GetObject("LocalidadRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.LocalidadRadLabel.RootElement.Padding = CType(resources.GetObject("LocalidadRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.LocalidadRadLabel.RootElement.Text = resources.GetString("LocalidadRadLabel.RootElement.Text")
            Me.LocalidadRadLabel.RootElement.TextOrientation = CType(resources.GetObject("LocalidadRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.LocalidadRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.LocalidadRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment8"), System.Drawing.ContentAlignment)
            CType(Me.LocalidadRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text8")
            CType(Me.LocalidadRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.LocalidadRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'FaxRadLabel
            '
            resources.ApplyResources(Me.FaxRadLabel, "FaxRadLabel")
            Me.FaxRadLabel.BorderVisible = True
            Me.FaxRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "Fax", True))
            Me.FaxRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FaxRadLabel.Name = "FaxRadLabel"
            '
            '
            '
            Me.FaxRadLabel.RootElement.AccessibleDescription = resources.GetString("FaxRadLabel.RootElement.AccessibleDescription")
            Me.FaxRadLabel.RootElement.AccessibleName = resources.GetString("FaxRadLabel.RootElement.AccessibleName")
            Me.FaxRadLabel.RootElement.Alignment = CType(resources.GetObject("FaxRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.FaxRadLabel.RootElement.AngleTransform = CType(resources.GetObject("FaxRadLabel.RootElement.AngleTransform"), Single)
            Me.FaxRadLabel.RootElement.FlipText = CType(resources.GetObject("FaxRadLabel.RootElement.FlipText"), Boolean)
            Me.FaxRadLabel.RootElement.Margin = CType(resources.GetObject("FaxRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.FaxRadLabel.RootElement.Padding = CType(resources.GetObject("FaxRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.FaxRadLabel.RootElement.Text = resources.GetString("FaxRadLabel.RootElement.Text")
            Me.FaxRadLabel.RootElement.TextOrientation = CType(resources.GetObject("FaxRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.FaxRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FaxRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment9"), System.Drawing.ContentAlignment)
            CType(Me.FaxRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text9")
            CType(Me.FaxRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FaxRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'EmailRadLabel
            '
            resources.ApplyResources(Me.EmailRadLabel, "EmailRadLabel")
            Me.EmailRadLabel.BorderVisible = True
            Me.EmailRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "Email", True))
            Me.EmailRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.EmailRadLabel.Name = "EmailRadLabel"
            '
            '
            '
            Me.EmailRadLabel.RootElement.AccessibleDescription = resources.GetString("EmailRadLabel.RootElement.AccessibleDescription")
            Me.EmailRadLabel.RootElement.AccessibleName = resources.GetString("EmailRadLabel.RootElement.AccessibleName")
            Me.EmailRadLabel.RootElement.Alignment = CType(resources.GetObject("EmailRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.EmailRadLabel.RootElement.AngleTransform = CType(resources.GetObject("EmailRadLabel.RootElement.AngleTransform"), Single)
            Me.EmailRadLabel.RootElement.FlipText = CType(resources.GetObject("EmailRadLabel.RootElement.FlipText"), Boolean)
            Me.EmailRadLabel.RootElement.Margin = CType(resources.GetObject("EmailRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.EmailRadLabel.RootElement.Padding = CType(resources.GetObject("EmailRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.EmailRadLabel.RootElement.Text = resources.GetString("EmailRadLabel.RootElement.Text")
            Me.EmailRadLabel.RootElement.TextOrientation = CType(resources.GetObject("EmailRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.EmailRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.EmailRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment10"), System.Drawing.ContentAlignment)
            CType(Me.EmailRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text10")
            CType(Me.EmailRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.EmailRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'DireccionRadLabel
            '
            resources.ApplyResources(Me.DireccionRadLabel, "DireccionRadLabel")
            Me.DireccionRadLabel.BorderVisible = True
            Me.DireccionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "Direccion", True))
            Me.DireccionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.DireccionRadLabel.Name = "DireccionRadLabel"
            '
            '
            '
            Me.DireccionRadLabel.RootElement.AccessibleDescription = resources.GetString("DireccionRadLabel.RootElement.AccessibleDescription")
            Me.DireccionRadLabel.RootElement.AccessibleName = resources.GetString("DireccionRadLabel.RootElement.AccessibleName")
            Me.DireccionRadLabel.RootElement.Alignment = CType(resources.GetObject("DireccionRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.DireccionRadLabel.RootElement.AngleTransform = CType(resources.GetObject("DireccionRadLabel.RootElement.AngleTransform"), Single)
            Me.DireccionRadLabel.RootElement.FlipText = CType(resources.GetObject("DireccionRadLabel.RootElement.FlipText"), Boolean)
            Me.DireccionRadLabel.RootElement.Margin = CType(resources.GetObject("DireccionRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.DireccionRadLabel.RootElement.Padding = CType(resources.GetObject("DireccionRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.DireccionRadLabel.RootElement.Text = resources.GetString("DireccionRadLabel.RootElement.Text")
            Me.DireccionRadLabel.RootElement.TextOrientation = CType(resources.GetObject("DireccionRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.DireccionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.DireccionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment11"), System.Drawing.ContentAlignment)
            CType(Me.DireccionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text11")
            CType(Me.DireccionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.DireccionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'CodigoPostalRadLabel
            '
            resources.ApplyResources(Me.CodigoPostalRadLabel, "CodigoPostalRadLabel")
            Me.CodigoPostalRadLabel.BorderVisible = True
            Me.CodigoPostalRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "CodigoPostal", True))
            Me.CodigoPostalRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.CodigoPostalRadLabel.Name = "CodigoPostalRadLabel"
            '
            '
            '
            Me.CodigoPostalRadLabel.RootElement.AccessibleDescription = resources.GetString("CodigoPostalRadLabel.RootElement.AccessibleDescription")
            Me.CodigoPostalRadLabel.RootElement.AccessibleName = resources.GetString("CodigoPostalRadLabel.RootElement.AccessibleName")
            Me.CodigoPostalRadLabel.RootElement.Alignment = CType(resources.GetObject("CodigoPostalRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.CodigoPostalRadLabel.RootElement.AngleTransform = CType(resources.GetObject("CodigoPostalRadLabel.RootElement.AngleTransform"), Single)
            Me.CodigoPostalRadLabel.RootElement.FlipText = CType(resources.GetObject("CodigoPostalRadLabel.RootElement.FlipText"), Boolean)
            Me.CodigoPostalRadLabel.RootElement.Margin = CType(resources.GetObject("CodigoPostalRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.CodigoPostalRadLabel.RootElement.Padding = CType(resources.GetObject("CodigoPostalRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.CodigoPostalRadLabel.RootElement.Text = resources.GetString("CodigoPostalRadLabel.RootElement.Text")
            Me.CodigoPostalRadLabel.RootElement.TextOrientation = CType(resources.GetObject("CodigoPostalRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.CodigoPostalRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.CodigoPostalRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment12"), System.Drawing.ContentAlignment)
            CType(Me.CodigoPostalRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text12")
            CType(Me.CodigoPostalRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.CodigoPostalRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'pvpOtro
            '
            Me.pvpOtro.Controls.Add(FModificacionLabel)
            Me.pvpOtro.Controls.Add(Me.FModificacionRadLabel)
            Me.pvpOtro.Controls.Add(FCreacionLabel)
            Me.pvpOtro.Controls.Add(Me.FCreacionRadLabel)
            Me.pvpOtro.Controls.Add(PendienteLabel)
            Me.pvpOtro.Controls.Add(Me.PendienteRadLabel)
            Me.pvpOtro.Controls.Add(ActivoLabel)
            Me.pvpOtro.Controls.Add(Me.ActivoRadLabel)
            Me.pvpOtro.Controls.Add(ObservacionLabel)
            Me.pvpOtro.Controls.Add(Me.ObservacionRadLabel)
            resources.ApplyResources(Me.pvpOtro, "pvpOtro")
            Me.pvpOtro.Name = "pvpOtro"
            '
            'FModificacionRadLabel
            '
            resources.ApplyResources(Me.FModificacionRadLabel, "FModificacionRadLabel")
            Me.FModificacionRadLabel.BorderVisible = True
            Me.FModificacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "FModificacion", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "G"))
            Me.FModificacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FModificacionRadLabel.Name = "FModificacionRadLabel"
            '
            '
            '
            Me.FModificacionRadLabel.RootElement.AccessibleDescription = resources.GetString("FModificacionRadLabel.RootElement.AccessibleDescription")
            Me.FModificacionRadLabel.RootElement.AccessibleName = resources.GetString("FModificacionRadLabel.RootElement.AccessibleName")
            Me.FModificacionRadLabel.RootElement.Alignment = CType(resources.GetObject("FModificacionRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.FModificacionRadLabel.RootElement.AngleTransform = CType(resources.GetObject("FModificacionRadLabel.RootElement.AngleTransform"), Single)
            Me.FModificacionRadLabel.RootElement.FlipText = CType(resources.GetObject("FModificacionRadLabel.RootElement.FlipText"), Boolean)
            Me.FModificacionRadLabel.RootElement.Margin = CType(resources.GetObject("FModificacionRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.FModificacionRadLabel.RootElement.Padding = CType(resources.GetObject("FModificacionRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.FModificacionRadLabel.RootElement.Text = resources.GetString("FModificacionRadLabel.RootElement.Text")
            Me.FModificacionRadLabel.RootElement.TextOrientation = CType(resources.GetObject("FModificacionRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.FModificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FModificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text13")
            CType(Me.FModificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FModificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'FCreacionRadLabel
            '
            resources.ApplyResources(Me.FCreacionRadLabel, "FCreacionRadLabel")
            Me.FCreacionRadLabel.BorderVisible = True
            Me.FCreacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "FCreacion", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "G"))
            Me.FCreacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FCreacionRadLabel.Name = "FCreacionRadLabel"
            '
            '
            '
            Me.FCreacionRadLabel.RootElement.AccessibleDescription = resources.GetString("FCreacionRadLabel.RootElement.AccessibleDescription")
            Me.FCreacionRadLabel.RootElement.AccessibleName = resources.GetString("FCreacionRadLabel.RootElement.AccessibleName")
            Me.FCreacionRadLabel.RootElement.Alignment = CType(resources.GetObject("FCreacionRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.FCreacionRadLabel.RootElement.AngleTransform = CType(resources.GetObject("FCreacionRadLabel.RootElement.AngleTransform"), Single)
            Me.FCreacionRadLabel.RootElement.FlipText = CType(resources.GetObject("FCreacionRadLabel.RootElement.FlipText"), Boolean)
            Me.FCreacionRadLabel.RootElement.Margin = CType(resources.GetObject("FCreacionRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.FCreacionRadLabel.RootElement.Padding = CType(resources.GetObject("FCreacionRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.FCreacionRadLabel.RootElement.Text = resources.GetString("FCreacionRadLabel.RootElement.Text")
            Me.FCreacionRadLabel.RootElement.TextOrientation = CType(resources.GetObject("FCreacionRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.FCreacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FCreacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text14")
            CType(Me.FCreacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FCreacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'PendienteRadLabel
            '
            resources.ApplyResources(Me.PendienteRadLabel, "PendienteRadLabel")
            Me.PendienteRadLabel.BorderVisible = True
            Me.PendienteRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "Pendiente", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
            Me.PendienteRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PendienteRadLabel.Name = "PendienteRadLabel"
            '
            '
            '
            Me.PendienteRadLabel.RootElement.AccessibleDescription = resources.GetString("PendienteRadLabel.RootElement.AccessibleDescription")
            Me.PendienteRadLabel.RootElement.AccessibleName = resources.GetString("PendienteRadLabel.RootElement.AccessibleName")
            Me.PendienteRadLabel.RootElement.Alignment = CType(resources.GetObject("PendienteRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.PendienteRadLabel.RootElement.AngleTransform = CType(resources.GetObject("PendienteRadLabel.RootElement.AngleTransform"), Single)
            Me.PendienteRadLabel.RootElement.FlipText = CType(resources.GetObject("PendienteRadLabel.RootElement.FlipText"), Boolean)
            Me.PendienteRadLabel.RootElement.Margin = CType(resources.GetObject("PendienteRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.PendienteRadLabel.RootElement.Padding = CType(resources.GetObject("PendienteRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.PendienteRadLabel.RootElement.Text = resources.GetString("PendienteRadLabel.RootElement.Text")
            Me.PendienteRadLabel.RootElement.TextOrientation = CType(resources.GetObject("PendienteRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.PendienteRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.PendienteRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text15")
            CType(Me.PendienteRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.PendienteRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ActivoRadLabel
            '
            resources.ApplyResources(Me.ActivoRadLabel, "ActivoRadLabel")
            Me.ActivoRadLabel.BorderVisible = True
            Me.ActivoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "Activo", True))
            Me.ActivoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ActivoRadLabel.Name = "ActivoRadLabel"
            '
            '
            '
            Me.ActivoRadLabel.RootElement.AccessibleDescription = resources.GetString("ActivoRadLabel.RootElement.AccessibleDescription")
            Me.ActivoRadLabel.RootElement.AccessibleName = resources.GetString("ActivoRadLabel.RootElement.AccessibleName")
            Me.ActivoRadLabel.RootElement.Alignment = CType(resources.GetObject("ActivoRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ActivoRadLabel.RootElement.AngleTransform = CType(resources.GetObject("ActivoRadLabel.RootElement.AngleTransform"), Single)
            Me.ActivoRadLabel.RootElement.FlipText = CType(resources.GetObject("ActivoRadLabel.RootElement.FlipText"), Boolean)
            Me.ActivoRadLabel.RootElement.Margin = CType(resources.GetObject("ActivoRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ActivoRadLabel.RootElement.Padding = CType(resources.GetObject("ActivoRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ActivoRadLabel.RootElement.Text = resources.GetString("ActivoRadLabel.RootElement.Text")
            Me.ActivoRadLabel.RootElement.TextOrientation = CType(resources.GetObject("ActivoRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.ActivoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ActivoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text16")
            CType(Me.ActivoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ActivoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ObservacionRadLabel
            '
            resources.ApplyResources(Me.ObservacionRadLabel, "ObservacionRadLabel")
            Me.ObservacionRadLabel.BorderVisible = True
            Me.ObservacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWProveedorBindingSource, "Observacion", True))
            Me.ObservacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ObservacionRadLabel.Name = "ObservacionRadLabel"
            '
            '
            '
            Me.ObservacionRadLabel.RootElement.AccessibleDescription = resources.GetString("ObservacionRadLabel.RootElement.AccessibleDescription")
            Me.ObservacionRadLabel.RootElement.AccessibleName = resources.GetString("ObservacionRadLabel.RootElement.AccessibleName")
            Me.ObservacionRadLabel.RootElement.Alignment = CType(resources.GetObject("ObservacionRadLabel.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ObservacionRadLabel.RootElement.AngleTransform = CType(resources.GetObject("ObservacionRadLabel.RootElement.AngleTransform"), Single)
            Me.ObservacionRadLabel.RootElement.FlipText = CType(resources.GetObject("ObservacionRadLabel.RootElement.FlipText"), Boolean)
            Me.ObservacionRadLabel.RootElement.Margin = CType(resources.GetObject("ObservacionRadLabel.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ObservacionRadLabel.RootElement.Padding = CType(resources.GetObject("ObservacionRadLabel.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ObservacionRadLabel.RootElement.Text = resources.GetString("ObservacionRadLabel.RootElement.Text")
            Me.ObservacionRadLabel.RootElement.TextOrientation = CType(resources.GetObject("ObservacionRadLabel.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.ObservacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ObservacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text17")
            CType(Me.ObservacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ObservacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'bgwCarga
            '
            Me.bgwCarga.WorkerSupportsCancellation = True
            '
            'frmProveedor
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ChordModifier1.AltModifier = False
            ChordModifier1.ControlModifier = True
            ChordModifier1.ShiftModifier = False
            Chord1.ChordModifier = ChordModifier1
            Chord1.Keys = "Ctrl+A"
            InputBinding1.Chord = Chord1
            ClickCommand1.ContextType = Nothing
            ClickCommand1.ImageList = Nothing
            ClickCommand1.Name = "ActionCommand"
            ClickCommand1.OwnerType = GetType(Telerik.WinControls.RadItem)
            ClickCommand1.Text = "This command rises the Click event of a selected RadItem instance."
            ClickCommand1.Type = ""
            InputBinding1.Command = ClickCommand1
            InputBinding1.CommandContext = Me.cbbtnAgregar
            Me.CommandBindings.AddRange(New Telerik.WinControls.Keyboard.InputBinding() {InputBinding1})
            Me.Controls.Add(Me.RadSplitContainer1)
            Me.Controls.Add(Me.cbComandos)
            Me.EnableKeyMap = True
            Me.Name = "frmProveedor"
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmProveedor.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmProveedor.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmProveedor.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmProveedor.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmProveedor.RootElement.FlipText"), Boolean)
            Me.RootElement.Margin = CType(resources.GetObject("frmProveedor.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmProveedor.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmProveedor.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmProveedor.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.VWProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer1.ResumeLayout(False)
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel1.ResumeLayout(False)
            Me.SplitPanel1.PerformLayout()
            CType(Me.statuInfo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel2.ResumeLayout(False)
            CType(Me.pvInfo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pvInfo.ResumeLayout(False)
            Me.pvpDetalle.ResumeLayout(False)
            Me.pvpDetalle.PerformLayout()
            CType(Me.TipoIdentificacionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.VWProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IdentificacionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NombreContactoRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PaisRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProvinciaRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TelefonoRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NombreYNombreCNRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MovilRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LocalidadRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FaxRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmailRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DireccionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CodigoPostalRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pvpOtro.ResumeLayout(False)
            Me.pvpOtro.PerformLayout()
            CType(Me.FModificacionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FCreacionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PendienteRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ActivoRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ObservacionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents cbComandos As Telerik.WinControls.UI.RadCommandBar
        Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
        Friend WithEvents cbstripeAccion As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents cbbtnAgregar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnEliminar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnModificar As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbbtnContactos As Telerik.WinControls.UI.CommandBarDropDownButton
        Friend WithEvents cbbtnCuentas As Telerik.WinControls.UI.CommandBarDropDownButton
        Friend WithEvents cbbtnPagos As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents SplitPanel1 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents SplitPanel2 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents pvInfo As Telerik.WinControls.UI.RadPageView
        Friend WithEvents pvpDetalle As Telerik.WinControls.UI.RadPageViewPage
        Friend WithEvents VWProveedoresBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents MovilRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents LocalidadRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents FaxRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents EmailRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents DireccionRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents CodigoPostalRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents pvpOtro As Telerik.WinControls.UI.RadPageViewPage
        Friend WithEvents TipoIdentificacionRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents IdentificacionRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents NombreContactoRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents PaisRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents ProvinciaRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents TelefonoRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents NombreYNombreCNRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents FModificacionRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents FCreacionRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents PendienteRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents ActivoRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents ObservacionRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
        Dim WithEvents gridDatos As Telerik.WinControls.UI.RadGridView
        Friend WithEvents VWProveedorBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents statuInfo As Telerik.WinControls.UI.RadStatusStrip
        Friend WithEvents lbleDiagnostico As Telerik.WinControls.UI.RadLabelElement
        Friend WithEvents chkeNoActivos As Telerik.WinControls.UI.RadCheckBoxElement
        Friend WithEvents RadToolStripSeparatorItem1 As Telerik.WinControls.UI.CommandBarSeparator
        Friend WithEvents lblePagina As Telerik.WinControls.UI.RadLabelElement
        Friend WithEvents cbstripeBusqueda As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents bgwCarga As System.ComponentModel.BackgroundWorker
        Friend WithEvents btneAnterior As Telerik.WinControls.UI.RadButtonElement
        Friend WithEvents btneSiguiente As Telerik.WinControls.UI.RadButtonElement
        Friend WithEvents chkePaginar As Telerik.WinControls.UI.RadCheckBoxElement
        Friend WithEvents mitemAgregarContacto As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mitemAgregarCuenta As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents cbstripeOrden As Telerik.WinControls.UI.CommandBarStripElement
    End Class

End Namespace

