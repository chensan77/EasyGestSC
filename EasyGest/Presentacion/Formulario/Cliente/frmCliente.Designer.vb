﻿Namespace Presentacion.Formulario.Cliente

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmCliente
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
            Dim CodigoLabel As System.Windows.Forms.Label
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
            Dim CodigoPostalLabel As System.Windows.Forms.Label
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
            Dim DescuentoLabel As System.Windows.Forms.Label
            Dim ObservacionLabel As System.Windows.Forms.Label
            Dim ActivoLabel As System.Windows.Forms.Label
            Dim AplicableRELabel As System.Windows.Forms.Label
            Dim PendienteLabel As System.Windows.Forms.Label
            Dim TarjetasPoseidasLabel As System.Windows.Forms.Label
            Dim FCreacionLabel As System.Windows.Forms.Label
            Dim FModificacionLabel As System.Windows.Forms.Label
            Dim IdentificacionLabel As System.Windows.Forms.Label
            Dim TipoIdentificacionLabel As System.Windows.Forms.Label
            Dim Label1 As System.Windows.Forms.Label
            Dim Label2 As System.Windows.Forms.Label
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
            Me.cbbtnAgregar = New Telerik.WinControls.UI.CommandBarButton()
            Me.gridDatos = New Telerik.WinControls.UI.RadGridView()
            Me.VWClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.cbComandos = New Telerik.WinControls.UI.RadCommandBar()
            Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.cbstripeAccion = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbbtnEliminar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnModificar = New Telerik.WinControls.UI.CommandBarButton()
            Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.cbbtnTarjetas = New Telerik.WinControls.UI.CommandBarDropDownButton()
            Me.mitemAgregarTarjeta = New Telerik.WinControls.UI.RadMenuItem()
            Me.cbbtnContactos = New Telerik.WinControls.UI.CommandBarDropDownButton()
            Me.mitemAgregarContacto = New Telerik.WinControls.UI.RadMenuItem()
            Me.cbbtnCuentas = New Telerik.WinControls.UI.CommandBarDropDownButton()
            Me.mitemAgregarCuenta = New Telerik.WinControls.UI.RadMenuItem()
            Me.cbbtnCobros = New Telerik.WinControls.UI.CommandBarButton()
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
            Me.VWClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
            Me.CodigoRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.pvpOtro = New Telerik.WinControls.UI.RadPageViewPage()
            Me.FModificacionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.FNacimientoRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.FCreacionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.TarjetasSaldosRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.TarjetasPoseidasRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.PendienteRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.lblAplicarImpInd = New System.Windows.Forms.Label()
            Me.AplicableImpIndirectoRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.AplicableRERadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.ActivoRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.ObservacionRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.DescuentoRadLabel = New Telerik.WinControls.UI.RadLabel()
            Me.bgwCarga = New System.ComponentModel.BackgroundWorker()
            Me.RadButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
            Me.RadButtonElement2 = New Telerik.WinControls.UI.RadButtonElement()
            CodigoLabel = New System.Windows.Forms.Label()
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
            DescuentoLabel = New System.Windows.Forms.Label()
            ObservacionLabel = New System.Windows.Forms.Label()
            ActivoLabel = New System.Windows.Forms.Label()
            AplicableRELabel = New System.Windows.Forms.Label()
            PendienteLabel = New System.Windows.Forms.Label()
            TarjetasPoseidasLabel = New System.Windows.Forms.Label()
            FCreacionLabel = New System.Windows.Forms.Label()
            FModificacionLabel = New System.Windows.Forms.Label()
            IdentificacionLabel = New System.Windows.Forms.Label()
            TipoIdentificacionLabel = New System.Windows.Forms.Label()
            Label1 = New System.Windows.Forms.Label()
            Label2 = New System.Windows.Forms.Label()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.VWClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType(Me.VWClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType(Me.CodigoRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pvpOtro.SuspendLayout()
            CType(Me.FModificacionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FNacimientoRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FCreacionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TarjetasSaldosRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TarjetasPoseidasRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PendienteRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AplicableImpIndirectoRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AplicableRERadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ActivoRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ObservacionRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DescuentoRadLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'CodigoLabel
            '
            resources.ApplyResources(CodigoLabel, "CodigoLabel")
            CodigoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            CodigoLabel.Name = "CodigoLabel"
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
            'DescuentoLabel
            '
            resources.ApplyResources(DescuentoLabel, "DescuentoLabel")
            DescuentoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            DescuentoLabel.Name = "DescuentoLabel"
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
            'AplicableRELabel
            '
            resources.ApplyResources(AplicableRELabel, "AplicableRELabel")
            AplicableRELabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            AplicableRELabel.Name = "AplicableRELabel"
            '
            'PendienteLabel
            '
            resources.ApplyResources(PendienteLabel, "PendienteLabel")
            PendienteLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            PendienteLabel.Name = "PendienteLabel"
            '
            'TarjetasPoseidasLabel
            '
            resources.ApplyResources(TarjetasPoseidasLabel, "TarjetasPoseidasLabel")
            TarjetasPoseidasLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            TarjetasPoseidasLabel.Name = "TarjetasPoseidasLabel"
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
            'Label1
            '
            resources.ApplyResources(Label1, "Label1")
            Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Label1.Name = "Label1"
            '
            'Label2
            '
            resources.ApplyResources(Label2, "Label2")
            Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Label2.Name = "Label2"
            '
            'cbbtnAgregar
            '
            resources.ApplyResources(Me.cbbtnAgregar, "cbbtnAgregar")
            Me.cbbtnAgregar.DrawText = True
            Me.cbbtnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnAgregar.Image = Global.EasyGest.My.Resources.Resources._127
            Me.cbbtnAgregar.Name = "cbbtnAgregar"
            Me.cbbtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
            Me.gridDatos.MasterTemplate.AutoGenerateColumns = False
            GridViewTextBoxColumn1.AllowFiltering = False
            GridViewTextBoxColumn1.AllowGroup = False
            GridViewTextBoxColumn1.AllowSort = False
            GridViewTextBoxColumn1.EnableExpressionEditor = False
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
            GridViewTextBoxColumn2.FieldName = "Codigo"
            resources.ApplyResources(GridViewTextBoxColumn2, "GridViewTextBoxColumn2")
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.IsPinned = True
            GridViewTextBoxColumn2.Name = "Codigo"
            GridViewTextBoxColumn2.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewTextBoxColumn2.Width = 86
            GridViewTextBoxColumn3.AllowGroup = False
            GridViewTextBoxColumn3.EnableExpressionEditor = False
            GridViewTextBoxColumn3.FieldName = "NombreYNombreCN"
            resources.ApplyResources(GridViewTextBoxColumn3, "GridViewTextBoxColumn3")
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.IsPinned = True
            GridViewTextBoxColumn3.Name = "NombreYNombreCN"
            GridViewTextBoxColumn3.PinPosition = Telerik.WinControls.UI.PinnedColumnPosition.Left
            GridViewTextBoxColumn3.ReadOnly = True
            GridViewTextBoxColumn3.Width = 215
            GridViewTextBoxColumn4.AllowFiltering = False
            GridViewTextBoxColumn4.AllowGroup = False
            GridViewTextBoxColumn4.EnableExpressionEditor = False
            GridViewTextBoxColumn4.FieldName = "TipoIdentificacion"
            resources.ApplyResources(GridViewTextBoxColumn4, "GridViewTextBoxColumn4")
            GridViewTextBoxColumn4.IsAutoGenerated = True
            GridViewTextBoxColumn4.Name = "TipoIdentificacion"
            GridViewTextBoxColumn4.ReadOnly = True
            GridViewTextBoxColumn4.Width = 101
            GridViewTextBoxColumn5.AllowGroup = False
            GridViewTextBoxColumn5.EnableExpressionEditor = False
            GridViewTextBoxColumn5.FieldName = "Identificacion"
            resources.ApplyResources(GridViewTextBoxColumn5, "GridViewTextBoxColumn5")
            GridViewTextBoxColumn5.IsAutoGenerated = True
            GridViewTextBoxColumn5.Name = "Identificacion"
            GridViewTextBoxColumn5.Width = 130
            GridViewTextBoxColumn6.EnableExpressionEditor = False
            GridViewTextBoxColumn6.FieldName = "NombreContacto"
            resources.ApplyResources(GridViewTextBoxColumn6, "GridViewTextBoxColumn6")
            GridViewTextBoxColumn6.IsAutoGenerated = True
            GridViewTextBoxColumn6.Name = "NombreContacto"
            GridViewTextBoxColumn6.Width = 239
            Me.gridDatos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6})
            Me.gridDatos.MasterTemplate.DataSource = Me.VWClientesBindingSource
            Me.gridDatos.MasterTemplate.EnableAlternatingRowColor = True
            Me.gridDatos.MasterTemplate.EnableGrouping = False
            Me.gridDatos.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom
            Me.gridDatos.MasterTemplate.ViewDefinition = TableViewDefinition1
            Me.gridDatos.Name = "gridDatos"
            Me.gridDatos.ReadOnly = True
            Me.gridDatos.ShowGroupPanel = False
            '
            'VWClientesBindingSource
            '
            Me.VWClientesBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.VWClientes)
            '
            'cbComandos
            '
            resources.ApplyResources(Me.cbComandos, "cbComandos")
            Me.cbComandos.Name = "cbComandos"
            Me.cbComandos.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
            '
            'CommandBarRowElement1
            '
            resources.ApplyResources(Me.CommandBarRowElement1, "CommandBarRowElement1")
            Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
            Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.cbstripeAccion, Me.cbstripeBusqueda, Me.cbstripeOrden})
            '
            'cbstripeAccion
            '
            resources.ApplyResources(Me.cbstripeAccion, "cbstripeAccion")
            Me.cbstripeAccion.DrawText = False
            Me.cbstripeAccion.EnableDragging = False
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
            Me.cbstripeAccion.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbtnAgregar, Me.cbbtnEliminar, Me.cbbtnModificar, Me.CommandBarSeparator2, Me.cbbtnTarjetas, Me.cbbtnContactos, Me.cbbtnCuentas, Me.cbbtnCobros})
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
            Me.cbstripeAccion.ShowHorizontalLine = False
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
            'cbbtnEliminar
            '
            resources.ApplyResources(Me.cbbtnEliminar, "cbbtnEliminar")
            Me.cbbtnEliminar.DrawText = True
            Me.cbbtnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnEliminar.Image = Global.EasyGest.My.Resources.Resources._128
            Me.cbbtnEliminar.Name = "cbbtnEliminar"
            Me.cbbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'cbbtnModificar
            '
            resources.ApplyResources(Me.cbbtnModificar, "cbbtnModificar")
            Me.cbbtnModificar.DrawText = True
            Me.cbbtnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnModificar.Image = Global.EasyGest.My.Resources.Resources._130
            Me.cbbtnModificar.Name = "cbbtnModificar"
            Me.cbbtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'CommandBarSeparator2
            '
            Me.CommandBarSeparator2.AccessibleDescription = "CommandBarSeparator2"
            Me.CommandBarSeparator2.AccessibleName = "CommandBarSeparator2"
            resources.ApplyResources(Me.CommandBarSeparator2, "CommandBarSeparator2")
            Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
            Me.CommandBarSeparator2.VisibleInOverflowMenu = False
            '
            'cbbtnTarjetas
            '
            resources.ApplyResources(Me.cbbtnTarjetas, "cbbtnTarjetas")
            Me.cbbtnTarjetas.DrawText = True
            Me.cbbtnTarjetas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnTarjetas.Image = Global.EasyGest.My.Resources.Resources._60
            Me.cbbtnTarjetas.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemAgregarTarjeta})
            Me.cbbtnTarjetas.Name = "cbbtnTarjetas"
            Me.cbbtnTarjetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'mitemAgregarTarjeta
            '
            resources.ApplyResources(Me.mitemAgregarTarjeta, "mitemAgregarTarjeta")
            Me.mitemAgregarTarjeta.DescriptionFont = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemAgregarTarjeta.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemAgregarTarjeta.Image = Global.EasyGest.My.Resources.Resources._112
            Me.mitemAgregarTarjeta.Name = "mitemAgregarTarjeta"
            '
            'cbbtnContactos
            '
            resources.ApplyResources(Me.cbbtnContactos, "cbbtnContactos")
            Me.cbbtnContactos.DrawText = True
            Me.cbbtnContactos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnContactos.Image = Global.EasyGest.My.Resources.Resources._75
            Me.cbbtnContactos.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemAgregarContacto})
            Me.cbbtnContactos.Name = "cbbtnContactos"
            Me.cbbtnContactos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'mitemAgregarContacto
            '
            resources.ApplyResources(Me.mitemAgregarContacto, "mitemAgregarContacto")
            Me.mitemAgregarContacto.DescriptionFont = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemAgregarContacto.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemAgregarContacto.Image = Global.EasyGest.My.Resources.Resources._112
            Me.mitemAgregarContacto.Name = "mitemAgregarContacto"
            '
            'cbbtnCuentas
            '
            Me.cbbtnCuentas.AccessibleDescription = "Cuentas"
            Me.cbbtnCuentas.AccessibleName = "Cuentas"
            resources.ApplyResources(Me.cbbtnCuentas, "cbbtnCuentas")
            Me.cbbtnCuentas.DrawText = True
            Me.cbbtnCuentas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnCuentas.Image = Global.EasyGest.My.Resources.Resources._80
            Me.cbbtnCuentas.Items.AddRange(New Telerik.WinControls.RadItem() {Me.mitemAgregarCuenta})
            Me.cbbtnCuentas.Name = "cbbtnCuentas"
            Me.cbbtnCuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'mitemAgregarCuenta
            '
            resources.ApplyResources(Me.mitemAgregarCuenta, "mitemAgregarCuenta")
            Me.mitemAgregarCuenta.DescriptionFont = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            Me.mitemAgregarCuenta.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mitemAgregarCuenta.Image = Global.EasyGest.My.Resources.Resources._112
            Me.mitemAgregarCuenta.Name = "mitemAgregarCuenta"
            '
            'cbbtnCobros
            '
            resources.ApplyResources(Me.cbbtnCobros, "cbbtnCobros")
            Me.cbbtnCobros.DrawText = True
            Me.cbbtnCobros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnCobros.Image = Global.EasyGest.My.Resources.Resources._88
            Me.cbbtnCobros.Name = "cbbtnCobros"
            Me.cbbtnCobros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'cbstripeBusqueda
            '
            resources.ApplyResources(Me.cbstripeBusqueda, "cbstripeBusqueda")
            Me.cbstripeBusqueda.DrawFill = True
            Me.cbstripeBusqueda.DrawText = False
            Me.cbstripeBusqueda.EnableDragging = False
            '
            '
            '
            Me.cbstripeBusqueda.Grip.Alignment = CType(resources.GetObject("resource.Alignment4"), System.Drawing.ContentAlignment)
            Me.cbstripeBusqueda.Grip.AngleTransform = CType(resources.GetObject("resource.AngleTransform4"), Single)
            Me.cbstripeBusqueda.Grip.FlipText = CType(resources.GetObject("resource.FlipText4"), Boolean)
            Me.cbstripeBusqueda.Grip.Margin = CType(resources.GetObject("resource.Margin4"), System.Windows.Forms.Padding)
            Me.cbstripeBusqueda.Grip.Padding = CType(resources.GetObject("resource.Padding4"), System.Windows.Forms.Padding)
            Me.cbstripeBusqueda.Grip.RightToLeft = CType(resources.GetObject("resource.RightToLeft4"), Boolean)
            Me.cbstripeBusqueda.Grip.Text = resources.GetString("resource.Text4")
            Me.cbstripeBusqueda.Grip.TextOrientation = CType(resources.GetObject("resource.TextOrientation4"), System.Windows.Forms.Orientation)
            Me.cbstripeBusqueda.Grip.TextWrap = CType(resources.GetObject("resource.TextWrap4"), Boolean)
            Me.cbstripeBusqueda.Name = "CommandBarStripElement2"
            '
            '
            '
            Me.cbstripeBusqueda.OverflowButton.Alignment = CType(resources.GetObject("resource.Alignment5"), System.Drawing.ContentAlignment)
            Me.cbstripeBusqueda.OverflowButton.AngleTransform = CType(resources.GetObject("resource.AngleTransform5"), Single)
            Me.cbstripeBusqueda.OverflowButton.FlipText = CType(resources.GetObject("resource.FlipText5"), Boolean)
            Me.cbstripeBusqueda.OverflowButton.Margin = CType(resources.GetObject("resource.Margin5"), System.Windows.Forms.Padding)
            Me.cbstripeBusqueda.OverflowButton.Padding = CType(resources.GetObject("resource.Padding5"), System.Windows.Forms.Padding)
            Me.cbstripeBusqueda.OverflowButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft5"), Boolean)
            Me.cbstripeBusqueda.OverflowButton.Text = resources.GetString("resource.Text5")
            Me.cbstripeBusqueda.OverflowButton.TextOrientation = CType(resources.GetObject("resource.TextOrientation5"), System.Windows.Forms.Orientation)
            Me.cbstripeBusqueda.OverflowButton.TextWrap = CType(resources.GetObject("resource.TextWrap5"), Boolean)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextWrap = CType(resources.GetObject("resource.TextWrap6"), Boolean)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextOrientation = CType(resources.GetObject("resource.TextOrientation6"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).FlipText = CType(resources.GetObject("resource.FlipText6"), Boolean)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Text = resources.GetString("resource.Text6")
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Padding = CType(resources.GetObject("resource.Padding6"), System.Windows.Forms.Padding)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Margin = CType(resources.GetObject("resource.Margin6"), System.Windows.Forms.Padding)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Alignment = CType(resources.GetObject("resource.Alignment6"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).RightToLeft = CType(resources.GetObject("resource.RightToLeft6"), Boolean)
            CType(Me.cbstripeBusqueda.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).AngleTransform = CType(resources.GetObject("resource.AngleTransform6"), Single)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextWrap = CType(resources.GetObject("resource.TextWrap7"), Boolean)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextOrientation = CType(resources.GetObject("resource.TextOrientation7"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).FlipText = CType(resources.GetObject("resource.FlipText7"), Boolean)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Text = resources.GetString("resource.Text7")
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Padding = CType(resources.GetObject("resource.Padding7"), System.Windows.Forms.Padding)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Margin = CType(resources.GetObject("resource.Margin7"), System.Windows.Forms.Padding)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Alignment = CType(resources.GetObject("resource.Alignment7"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).RightToLeft = CType(resources.GetObject("resource.RightToLeft7"), Boolean)
            CType(Me.cbstripeBusqueda.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).AngleTransform = CType(resources.GetObject("resource.AngleTransform7"), Single)
            '
            'cbstripeOrden
            '
            resources.ApplyResources(Me.cbstripeOrden, "cbstripeOrden")
            Me.cbstripeOrden.EnableDragging = False
            '
            '
            '
            Me.cbstripeOrden.Grip.Alignment = CType(resources.GetObject("resource.Alignment8"), System.Drawing.ContentAlignment)
            Me.cbstripeOrden.Grip.AngleTransform = CType(resources.GetObject("resource.AngleTransform8"), Single)
            Me.cbstripeOrden.Grip.FlipText = CType(resources.GetObject("resource.FlipText8"), Boolean)
            Me.cbstripeOrden.Grip.Margin = CType(resources.GetObject("resource.Margin8"), System.Windows.Forms.Padding)
            Me.cbstripeOrden.Grip.Padding = CType(resources.GetObject("resource.Padding8"), System.Windows.Forms.Padding)
            Me.cbstripeOrden.Grip.RightToLeft = CType(resources.GetObject("resource.RightToLeft8"), Boolean)
            Me.cbstripeOrden.Grip.Text = resources.GetString("resource.Text8")
            Me.cbstripeOrden.Grip.TextOrientation = CType(resources.GetObject("resource.TextOrientation8"), System.Windows.Forms.Orientation)
            Me.cbstripeOrden.Grip.TextWrap = CType(resources.GetObject("resource.TextWrap8"), Boolean)
            Me.cbstripeOrden.Name = "CommandBarStripElement1"
            '
            '
            '
            Me.cbstripeOrden.OverflowButton.Alignment = CType(resources.GetObject("resource.Alignment9"), System.Drawing.ContentAlignment)
            Me.cbstripeOrden.OverflowButton.AngleTransform = CType(resources.GetObject("resource.AngleTransform9"), Single)
            Me.cbstripeOrden.OverflowButton.FlipText = CType(resources.GetObject("resource.FlipText9"), Boolean)
            Me.cbstripeOrden.OverflowButton.Margin = CType(resources.GetObject("resource.Margin9"), System.Windows.Forms.Padding)
            Me.cbstripeOrden.OverflowButton.Padding = CType(resources.GetObject("resource.Padding9"), System.Windows.Forms.Padding)
            Me.cbstripeOrden.OverflowButton.RightToLeft = CType(resources.GetObject("resource.RightToLeft9"), Boolean)
            Me.cbstripeOrden.OverflowButton.Text = resources.GetString("resource.Text9")
            Me.cbstripeOrden.OverflowButton.TextOrientation = CType(resources.GetObject("resource.TextOrientation9"), System.Windows.Forms.Orientation)
            Me.cbstripeOrden.OverflowButton.TextWrap = CType(resources.GetObject("resource.TextWrap9"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextWrap = CType(resources.GetObject("resource.TextWrap10"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).TextOrientation = CType(resources.GetObject("resource.TextOrientation10"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).FlipText = CType(resources.GetObject("resource.FlipText10"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Text = resources.GetString("resource.Text10")
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Padding = CType(resources.GetObject("resource.Padding10"), System.Windows.Forms.Padding)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Margin = CType(resources.GetObject("resource.Margin10"), System.Windows.Forms.Padding)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Alignment = CType(resources.GetObject("resource.Alignment10"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).RightToLeft = CType(resources.GetObject("resource.RightToLeft10"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).AngleTransform = CType(resources.GetObject("resource.AngleTransform10"), Single)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextWrap = CType(resources.GetObject("resource.TextWrap11"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).TextOrientation = CType(resources.GetObject("resource.TextOrientation11"), System.Windows.Forms.Orientation)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).FlipText = CType(resources.GetObject("resource.FlipText11"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Text = resources.GetString("resource.Text11")
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Padding = CType(resources.GetObject("resource.Padding11"), System.Windows.Forms.Padding)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Margin = CType(resources.GetObject("resource.Margin11"), System.Windows.Forms.Padding)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Alignment = CType(resources.GetObject("resource.Alignment11"), System.Drawing.ContentAlignment)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).RightToLeft = CType(resources.GetObject("resource.RightToLeft11"), Boolean)
            CType(Me.cbstripeOrden.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).AngleTransform = CType(resources.GetObject("resource.AngleTransform11"), Single)
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
            Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
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
            Me.SplitPanel1.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.2396021!, 0!)
            Me.SplitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(235, 0)
            Me.SplitPanel1.TabStop = False
            '
            'statuInfo
            '
            resources.ApplyResources(Me.statuInfo, "statuInfo")
            Me.statuInfo.Items.AddRange(New Telerik.WinControls.RadItem() {Me.btneAnterior, Me.btneSiguiente, Me.lblePagina, Me.RadToolStripSeparatorItem1, Me.lbleDiagnostico, Me.chkeNoActivos, Me.chkePaginar})
            Me.statuInfo.Name = "statuInfo"
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
            '
            'lblePagina
            '
            Me.lblePagina.AccessibleDescription = "RadLabelElement1"
            Me.lblePagina.AccessibleName = "RadLabelElement1"
            resources.ApplyResources(Me.lblePagina, "lblePagina")
            Me.lblePagina.AutoSize = False
            Me.lblePagina.Bounds = New System.Drawing.Rectangle(0, 0, 54, 20)
            Me.lblePagina.Name = "lblePagina"
            Me.statuInfo.SetSpring(Me.lblePagina, False)
            Me.lblePagina.TextWrap = True
            '
            'RadToolStripSeparatorItem1
            '
            Me.RadToolStripSeparatorItem1.AccessibleDescription = "RadToolStripSeparatorItem1"
            Me.RadToolStripSeparatorItem1.AccessibleName = "RadToolStripSeparatorItem1"
            resources.ApplyResources(Me.RadToolStripSeparatorItem1, "RadToolStripSeparatorItem1")
            Me.RadToolStripSeparatorItem1.Name = "RadToolStripSeparatorItem1"
            Me.statuInfo.SetSpring(Me.RadToolStripSeparatorItem1, False)
            Me.RadToolStripSeparatorItem1.VisibleInOverflowMenu = False
            '
            'lbleDiagnostico
            '
            Me.lbleDiagnostico.AccessibleDescription = "Núm. Registro:"
            Me.lbleDiagnostico.AccessibleName = "Núm. Registro:"
            resources.ApplyResources(Me.lbleDiagnostico, "lbleDiagnostico")
            Me.lbleDiagnostico.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbleDiagnostico.Name = "lbleDiagnostico"
            Me.statuInfo.SetSpring(Me.lbleDiagnostico, True)
            Me.lbleDiagnostico.TextWrap = True
            '
            'chkeNoActivos
            '
            resources.ApplyResources(Me.chkeNoActivos, "chkeNoActivos")
            Me.chkeNoActivos.Checked = False
            Me.chkeNoActivos.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkeNoActivos.Name = "chkeNoActivos"
            Me.chkeNoActivos.PositionOffset = New System.Drawing.SizeF(0!, 0!)
            Me.chkeNoActivos.ReadOnly = False
            Me.statuInfo.SetSpring(Me.chkeNoActivos, False)
            '
            'chkePaginar
            '
            resources.ApplyResources(Me.chkePaginar, "chkePaginar")
            Me.chkePaginar.CheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.chkePaginar.Checked = True
            Me.chkePaginar.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkePaginar.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chkePaginar.Image = Global.EasyGest.My.Resources.Resources.categories
            Me.chkePaginar.Name = "chkePaginar"
            Me.chkePaginar.ReadOnly = False
            Me.statuInfo.SetSpring(Me.chkePaginar, False)
            Me.chkePaginar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.chkePaginar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            '
            'SplitPanel2
            '
            Me.SplitPanel2.Controls.Add(Me.pvInfo)
            resources.ApplyResources(Me.SplitPanel2, "SplitPanel2")
            Me.SplitPanel2.Name = "SplitPanel2"
            '
            '
            '
            Me.SplitPanel2.RootElement.MinSize = New System.Drawing.Size(0, 0)
            Me.SplitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.2396022!, 0!)
            Me.SplitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(-235, 0)
            Me.SplitPanel2.TabStop = False
            '
            'pvInfo
            '
            Me.pvInfo.Controls.Add(Me.pvpDetalle)
            Me.pvInfo.Controls.Add(Me.pvpOtro)
            resources.ApplyResources(Me.pvInfo, "pvInfo")
            Me.pvInfo.Name = "pvInfo"
            Me.pvInfo.SelectedPage = Me.pvpOtro
            Me.pvInfo.TabStop = False
            CType(Me.pvInfo.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
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
            Me.pvpDetalle.Controls.Add(CodigoLabel)
            Me.pvpDetalle.Controls.Add(Me.CodigoRadLabel)
            Me.pvpDetalle.Description = Nothing
            resources.ApplyResources(Me.pvpDetalle, "pvpDetalle")
            Me.pvpDetalle.ItemSize = New System.Drawing.SizeF(58.0!, 32.0!)
            Me.pvpDetalle.Name = "pvpDetalle"
            Me.pvpDetalle.Title = "Detalle"
            '
            'TipoIdentificacionRadLabel
            '
            resources.ApplyResources(Me.TipoIdentificacionRadLabel, "TipoIdentificacionRadLabel")
            Me.TipoIdentificacionRadLabel.BorderVisible = True
            Me.TipoIdentificacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "TipoIdentificacion", True))
            Me.TipoIdentificacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.TipoIdentificacionRadLabel.Name = "TipoIdentificacionRadLabel"
            CType(Me.TipoIdentificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.TipoIdentificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment"), System.Drawing.ContentAlignment)
            CType(Me.TipoIdentificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text12")
            CType(Me.TipoIdentificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.TipoIdentificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.TipoIdentificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'VWClienteBindingSource
            '
            Me.VWClienteBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.VWClientes)
            '
            'IdentificacionRadLabel
            '
            resources.ApplyResources(Me.IdentificacionRadLabel, "IdentificacionRadLabel")
            Me.IdentificacionRadLabel.BorderVisible = True
            Me.IdentificacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Identificacion", True))
            Me.IdentificacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.IdentificacionRadLabel.Name = "IdentificacionRadLabel"
            CType(Me.IdentificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.IdentificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment1"), System.Drawing.ContentAlignment)
            CType(Me.IdentificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text13")
            CType(Me.IdentificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.IdentificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.IdentificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'NombreContactoRadLabel
            '
            resources.ApplyResources(Me.NombreContactoRadLabel, "NombreContactoRadLabel")
            Me.NombreContactoRadLabel.BorderVisible = True
            Me.NombreContactoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "NombreContacto", True))
            Me.NombreContactoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.NombreContactoRadLabel.Name = "NombreContactoRadLabel"
            CType(Me.NombreContactoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.NombreContactoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment2"), System.Drawing.ContentAlignment)
            CType(Me.NombreContactoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text14")
            CType(Me.NombreContactoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.NombreContactoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.NombreContactoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'PaisRadLabel
            '
            resources.ApplyResources(Me.PaisRadLabel, "PaisRadLabel")
            Me.PaisRadLabel.BorderVisible = True
            Me.PaisRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Pais", True))
            Me.PaisRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PaisRadLabel.Name = "PaisRadLabel"
            CType(Me.PaisRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.PaisRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment3"), System.Drawing.ContentAlignment)
            CType(Me.PaisRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text15")
            CType(Me.PaisRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.PaisRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.PaisRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ProvinciaRadLabel
            '
            resources.ApplyResources(Me.ProvinciaRadLabel, "ProvinciaRadLabel")
            Me.ProvinciaRadLabel.BorderVisible = True
            Me.ProvinciaRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Provincia", True))
            Me.ProvinciaRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ProvinciaRadLabel.Name = "ProvinciaRadLabel"
            CType(Me.ProvinciaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ProvinciaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment4"), System.Drawing.ContentAlignment)
            CType(Me.ProvinciaRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text16")
            CType(Me.ProvinciaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ProvinciaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.ProvinciaRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'TelefonoRadLabel
            '
            resources.ApplyResources(Me.TelefonoRadLabel, "TelefonoRadLabel")
            Me.TelefonoRadLabel.BorderVisible = True
            Me.TelefonoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Telefono", True))
            Me.TelefonoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.TelefonoRadLabel.Name = "TelefonoRadLabel"
            CType(Me.TelefonoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.TelefonoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment5"), System.Drawing.ContentAlignment)
            CType(Me.TelefonoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text17")
            CType(Me.TelefonoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.TelefonoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.TelefonoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'NombreYNombreCNRadLabel
            '
            resources.ApplyResources(Me.NombreYNombreCNRadLabel, "NombreYNombreCNRadLabel")
            Me.NombreYNombreCNRadLabel.BorderVisible = True
            Me.NombreYNombreCNRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "NombreYNombreCN", True))
            Me.NombreYNombreCNRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.NombreYNombreCNRadLabel.Name = "NombreYNombreCNRadLabel"
            CType(Me.NombreYNombreCNRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.NombreYNombreCNRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment6"), System.Drawing.ContentAlignment)
            CType(Me.NombreYNombreCNRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text18")
            CType(Me.NombreYNombreCNRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.NombreYNombreCNRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.NombreYNombreCNRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'MovilRadLabel
            '
            resources.ApplyResources(Me.MovilRadLabel, "MovilRadLabel")
            Me.MovilRadLabel.BorderVisible = True
            Me.MovilRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Movil", True))
            Me.MovilRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.MovilRadLabel.Name = "MovilRadLabel"
            CType(Me.MovilRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.MovilRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment7"), System.Drawing.ContentAlignment)
            CType(Me.MovilRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text19")
            CType(Me.MovilRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.MovilRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.MovilRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'LocalidadRadLabel
            '
            resources.ApplyResources(Me.LocalidadRadLabel, "LocalidadRadLabel")
            Me.LocalidadRadLabel.BorderVisible = True
            Me.LocalidadRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Localidad", True))
            Me.LocalidadRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.LocalidadRadLabel.Name = "LocalidadRadLabel"
            CType(Me.LocalidadRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.LocalidadRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment8"), System.Drawing.ContentAlignment)
            CType(Me.LocalidadRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text20")
            CType(Me.LocalidadRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.LocalidadRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.LocalidadRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'FaxRadLabel
            '
            resources.ApplyResources(Me.FaxRadLabel, "FaxRadLabel")
            Me.FaxRadLabel.BorderVisible = True
            Me.FaxRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Fax", True))
            Me.FaxRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FaxRadLabel.Name = "FaxRadLabel"
            CType(Me.FaxRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FaxRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment9"), System.Drawing.ContentAlignment)
            CType(Me.FaxRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text21")
            CType(Me.FaxRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FaxRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.FaxRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'EmailRadLabel
            '
            resources.ApplyResources(Me.EmailRadLabel, "EmailRadLabel")
            Me.EmailRadLabel.BorderVisible = True
            Me.EmailRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Email", True))
            Me.EmailRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.EmailRadLabel.Name = "EmailRadLabel"
            CType(Me.EmailRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.EmailRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment10"), System.Drawing.ContentAlignment)
            CType(Me.EmailRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text22")
            CType(Me.EmailRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.EmailRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.EmailRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'DireccionRadLabel
            '
            resources.ApplyResources(Me.DireccionRadLabel, "DireccionRadLabel")
            Me.DireccionRadLabel.BorderVisible = True
            Me.DireccionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Direccion", True))
            Me.DireccionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.DireccionRadLabel.Name = "DireccionRadLabel"
            CType(Me.DireccionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.DireccionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment11"), System.Drawing.ContentAlignment)
            CType(Me.DireccionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text23")
            CType(Me.DireccionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.DireccionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.DireccionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'CodigoPostalRadLabel
            '
            resources.ApplyResources(Me.CodigoPostalRadLabel, "CodigoPostalRadLabel")
            Me.CodigoPostalRadLabel.BorderVisible = True
            Me.CodigoPostalRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "CodigoPostal", True))
            Me.CodigoPostalRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.CodigoPostalRadLabel.Name = "CodigoPostalRadLabel"
            CType(Me.CodigoPostalRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.CodigoPostalRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment12"), System.Drawing.ContentAlignment)
            CType(Me.CodigoPostalRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text24")
            CType(Me.CodigoPostalRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.CodigoPostalRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.CodigoPostalRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'CodigoRadLabel
            '
            resources.ApplyResources(Me.CodigoRadLabel, "CodigoRadLabel")
            Me.CodigoRadLabel.BorderVisible = True
            Me.CodigoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Codigo", True))
            Me.CodigoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.CodigoRadLabel.Name = "CodigoRadLabel"
            CType(Me.CodigoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.CodigoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = CType(resources.GetObject("resource.TextAlignment13"), System.Drawing.ContentAlignment)
            CType(Me.CodigoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text25")
            CType(Me.CodigoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.CodigoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.CodigoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'pvpOtro
            '
            Me.pvpOtro.Controls.Add(FModificacionLabel)
            Me.pvpOtro.Controls.Add(Me.FModificacionRadLabel)
            Me.pvpOtro.Controls.Add(Label2)
            Me.pvpOtro.Controls.Add(Me.FNacimientoRadLabel)
            Me.pvpOtro.Controls.Add(FCreacionLabel)
            Me.pvpOtro.Controls.Add(Me.FCreacionRadLabel)
            Me.pvpOtro.Controls.Add(Label1)
            Me.pvpOtro.Controls.Add(Me.TarjetasSaldosRadLabel)
            Me.pvpOtro.Controls.Add(TarjetasPoseidasLabel)
            Me.pvpOtro.Controls.Add(Me.TarjetasPoseidasRadLabel)
            Me.pvpOtro.Controls.Add(PendienteLabel)
            Me.pvpOtro.Controls.Add(Me.PendienteRadLabel)
            Me.pvpOtro.Controls.Add(Me.lblAplicarImpInd)
            Me.pvpOtro.Controls.Add(Me.AplicableImpIndirectoRadLabel)
            Me.pvpOtro.Controls.Add(AplicableRELabel)
            Me.pvpOtro.Controls.Add(Me.AplicableRERadLabel)
            Me.pvpOtro.Controls.Add(ActivoLabel)
            Me.pvpOtro.Controls.Add(Me.ActivoRadLabel)
            Me.pvpOtro.Controls.Add(ObservacionLabel)
            Me.pvpOtro.Controls.Add(Me.ObservacionRadLabel)
            Me.pvpOtro.Controls.Add(DescuentoLabel)
            Me.pvpOtro.Controls.Add(Me.DescuentoRadLabel)
            resources.ApplyResources(Me.pvpOtro, "pvpOtro")
            Me.pvpOtro.ItemSize = New System.Drawing.SizeF(50.0!, 32.0!)
            Me.pvpOtro.Name = "pvpOtro"
            '
            'FModificacionRadLabel
            '
            resources.ApplyResources(Me.FModificacionRadLabel, "FModificacionRadLabel")
            Me.FModificacionRadLabel.BorderVisible = True
            Me.FModificacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "FModificacion", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "G"))
            Me.FModificacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FModificacionRadLabel.Name = "FModificacionRadLabel"
            CType(Me.FModificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FModificacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text26")
            CType(Me.FModificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FModificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.FModificacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'FNacimientoRadLabel
            '
            resources.ApplyResources(Me.FNacimientoRadLabel, "FNacimientoRadLabel")
            Me.FNacimientoRadLabel.BorderVisible = True
            Me.FNacimientoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "FNacimiento", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
            Me.FNacimientoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FNacimientoRadLabel.Name = "FNacimientoRadLabel"
            CType(Me.FNacimientoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FNacimientoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text27")
            CType(Me.FNacimientoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FNacimientoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.FNacimientoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'FCreacionRadLabel
            '
            resources.ApplyResources(Me.FCreacionRadLabel, "FCreacionRadLabel")
            Me.FCreacionRadLabel.BorderVisible = True
            Me.FCreacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "FCreacion", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "G"))
            Me.FCreacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.FCreacionRadLabel.Name = "FCreacionRadLabel"
            CType(Me.FCreacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.FCreacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text28")
            CType(Me.FCreacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.FCreacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.FCreacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'TarjetasSaldosRadLabel
            '
            resources.ApplyResources(Me.TarjetasSaldosRadLabel, "TarjetasSaldosRadLabel")
            Me.TarjetasSaldosRadLabel.BorderVisible = True
            Me.TarjetasSaldosRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "TarjetasSaldos", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
            Me.TarjetasSaldosRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.TarjetasSaldosRadLabel.Name = "TarjetasSaldosRadLabel"
            CType(Me.TarjetasSaldosRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.TarjetasSaldosRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text29")
            CType(Me.TarjetasSaldosRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.TarjetasSaldosRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.TarjetasSaldosRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'TarjetasPoseidasRadLabel
            '
            resources.ApplyResources(Me.TarjetasPoseidasRadLabel, "TarjetasPoseidasRadLabel")
            Me.TarjetasPoseidasRadLabel.BorderVisible = True
            Me.TarjetasPoseidasRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "TarjetasPoseidas", True))
            Me.TarjetasPoseidasRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.TarjetasPoseidasRadLabel.Name = "TarjetasPoseidasRadLabel"
            CType(Me.TarjetasPoseidasRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.TarjetasPoseidasRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text30")
            CType(Me.TarjetasPoseidasRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.TarjetasPoseidasRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.TarjetasPoseidasRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'PendienteRadLabel
            '
            resources.ApplyResources(Me.PendienteRadLabel, "PendienteRadLabel")
            Me.PendienteRadLabel.BorderVisible = True
            Me.PendienteRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Pendiente", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
            Me.PendienteRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PendienteRadLabel.Name = "PendienteRadLabel"
            CType(Me.PendienteRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.PendienteRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text31")
            CType(Me.PendienteRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.PendienteRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.PendienteRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'lblAplicarImpInd
            '
            resources.ApplyResources(Me.lblAplicarImpInd, "lblAplicarImpInd")
            Me.lblAplicarImpInd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.lblAplicarImpInd.Name = "lblAplicarImpInd"
            '
            'AplicableImpIndirectoRadLabel
            '
            resources.ApplyResources(Me.AplicableImpIndirectoRadLabel, "AplicableImpIndirectoRadLabel")
            Me.AplicableImpIndirectoRadLabel.BorderVisible = True
            Me.AplicableImpIndirectoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "AplicableImpIndirecto", True))
            Me.AplicableImpIndirectoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.AplicableImpIndirectoRadLabel.Name = "AplicableImpIndirectoRadLabel"
            CType(Me.AplicableImpIndirectoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.AplicableImpIndirectoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text32")
            CType(Me.AplicableImpIndirectoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.AplicableImpIndirectoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.AplicableImpIndirectoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'AplicableRERadLabel
            '
            resources.ApplyResources(Me.AplicableRERadLabel, "AplicableRERadLabel")
            Me.AplicableRERadLabel.BorderVisible = True
            Me.AplicableRERadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "AplicableRE", True))
            Me.AplicableRERadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.AplicableRERadLabel.Name = "AplicableRERadLabel"
            CType(Me.AplicableRERadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.AplicableRERadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text33")
            CType(Me.AplicableRERadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.AplicableRERadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.AplicableRERadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ActivoRadLabel
            '
            resources.ApplyResources(Me.ActivoRadLabel, "ActivoRadLabel")
            Me.ActivoRadLabel.BorderVisible = True
            Me.ActivoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Activo", True))
            Me.ActivoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ActivoRadLabel.Name = "ActivoRadLabel"
            CType(Me.ActivoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ActivoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text34")
            CType(Me.ActivoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ActivoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.ActivoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'ObservacionRadLabel
            '
            resources.ApplyResources(Me.ObservacionRadLabel, "ObservacionRadLabel")
            Me.ObservacionRadLabel.BorderVisible = True
            Me.ObservacionRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Observacion", True))
            Me.ObservacionRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.ObservacionRadLabel.Name = "ObservacionRadLabel"
            CType(Me.ObservacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.ObservacionRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text35")
            CType(Me.ObservacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.ObservacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.ObservacionRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'DescuentoRadLabel
            '
            resources.ApplyResources(Me.DescuentoRadLabel, "DescuentoRadLabel")
            Me.DescuentoRadLabel.BorderVisible = True
            Me.DescuentoRadLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VWClienteBindingSource, "Descuento", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "p2"))
            Me.DescuentoRadLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.DescuentoRadLabel.Name = "DescuentoRadLabel"
            CType(Me.DescuentoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
            CType(Me.DescuentoRadLabel.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = resources.GetString("resource.Text36")
            CType(Me.DescuentoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
            CType(Me.DescuentoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
            CType(Me.DescuentoRadLabel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
            '
            'bgwCarga
            '
            Me.bgwCarga.WorkerSupportsCancellation = True
            '
            'RadButtonElement1
            '
            resources.ApplyResources(Me.RadButtonElement1, "RadButtonElement1")
            Me.RadButtonElement1.AutoSize = True
            Me.RadButtonElement1.Name = "RadButtonElement1"
            Me.RadButtonElement1.Tag = "1"
            '
            'RadButtonElement2
            '
            resources.ApplyResources(Me.RadButtonElement2, "RadButtonElement2")
            Me.RadButtonElement2.AutoSize = True
            Me.RadButtonElement2.Name = "RadButtonElement2"
            Me.RadButtonElement2.Tag = "1"
            '
            'frmCliente
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ChordModifier1.AltModifier = False
            ChordModifier1.ControlModifier = True
            ChordModifier1.ShiftModifier = False
            Chord1.ChordModifier = ChordModifier1
            Chord1.Keys = "Ctrl+A"
            InputBinding1.Chord = Chord1
            InputBinding1.CommandContext = Me.cbbtnAgregar
            Me.CommandBindings.AddRange(New Telerik.WinControls.Keyboard.InputBinding() {InputBinding1})
            Me.Controls.Add(Me.RadSplitContainer1)
            Me.Controls.Add(Me.cbComandos)
            Me.Name = "frmCliente"
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.VWClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
            CType(Me.VWClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
            CType(Me.CodigoRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pvpOtro.ResumeLayout(False)
            Me.pvpOtro.PerformLayout()
            CType(Me.FModificacionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FNacimientoRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FCreacionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TarjetasSaldosRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TarjetasPoseidasRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PendienteRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AplicableImpIndirectoRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AplicableRERadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ActivoRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ObservacionRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DescuentoRadLabel, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents cbbtnTarjetas As Telerik.WinControls.UI.CommandBarDropDownButton
        Friend WithEvents cbbtnContactos As Telerik.WinControls.UI.CommandBarDropDownButton
        Friend WithEvents cbbtnCuentas As Telerik.WinControls.UI.CommandBarDropDownButton
        Friend WithEvents cbbtnCobros As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
        Friend WithEvents SplitPanel1 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents SplitPanel2 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents pvInfo As Telerik.WinControls.UI.RadPageView
        Friend WithEvents pvpDetalle As Telerik.WinControls.UI.RadPageViewPage
        Friend WithEvents VWClientesBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents MovilRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents LocalidadRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents FaxRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents EmailRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents DireccionRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents CodigoPostalRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents CodigoRadLabel As Telerik.WinControls.UI.RadLabel
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
        Friend WithEvents TarjetasPoseidasRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents PendienteRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents AplicableRERadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents ActivoRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents ObservacionRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents DescuentoRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
        Dim WithEvents gridDatos As Telerik.WinControls.UI.RadGridView
        Friend WithEvents VWClienteBindingSource As System.Windows.Forms.BindingSource
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
        Friend WithEvents mitemAgregarTarjeta As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mitemAgregarContacto As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents mitemAgregarCuenta As Telerik.WinControls.UI.RadMenuItem
        Friend WithEvents RadButtonElement1 As Telerik.WinControls.UI.RadButtonElement
        Friend WithEvents RadButtonElement2 As Telerik.WinControls.UI.RadButtonElement
        Friend WithEvents cbstripeOrden As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents FNacimientoRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents TarjetasSaldosRadLabel As Telerik.WinControls.UI.RadLabel
        Friend WithEvents lblAplicarImpInd As System.Windows.Forms.Label
        Friend WithEvents AplicableImpIndirectoRadLabel As Telerik.WinControls.UI.RadLabel
    End Class

End Namespace

