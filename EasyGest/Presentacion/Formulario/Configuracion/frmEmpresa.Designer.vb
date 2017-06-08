Namespace Presentacion.Formulario.Configuracion

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmEmpresa
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresa))
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel17 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel12 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel13 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel15 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel11 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel10 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel9 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel8 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel3 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel5 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel1 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel4 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel6 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel7 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel14 As Telerik.WinControls.UI.RadLabel
            Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
            Dim GridViewImageColumn1 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadLabel18 As Telerik.WinControls.UI.RadLabel
            Dim InputBinding1 As Telerik.WinControls.Keyboard.InputBinding = New Telerik.WinControls.Keyboard.InputBinding()
            Dim Chord1 As Telerik.WinControls.Keyboard.Chord = New Telerik.WinControls.Keyboard.Chord()
            Dim ChordModifier1 As Telerik.WinControls.Keyboard.ChordModifier = New Telerik.WinControls.Keyboard.ChordModifier()
            Me.gridDatos = New Telerik.WinControls.UI.RadGridView()
            Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
            Me.SplitPanel1 = New Telerik.WinControls.UI.SplitPanel()
            Me.SplitPanel2 = New Telerik.WinControls.UI.SplitPanel()
            Me.ddlFormato = New Telerik.WinControls.UI.RadDropDownList()
            Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnQuitarImagen = New Telerik.WinControls.UI.RadButton()
            Me.btnExaminarImagen = New Telerik.WinControls.UI.RadButton()
            Me.picLogo = New System.Windows.Forms.PictureBox()
            Me.txtNumeroCuenta = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.txtNombreComercial = New Telerik.WinControls.UI.RadTextBox()
            Me.txtSerie = New Telerik.WinControls.UI.RadTextBox()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.grpbDireccion = New Telerik.WinControls.UI.RadGroupBox()
            Me.txtCodigoPostal = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.ddlLocalidad = New Telerik.WinControls.UI.RadDropDownList()
            Me.MunicipiosEspañolasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ddlProvincia = New Telerik.WinControls.UI.RadDropDownList()
            Me.ProvinciasEspañolasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.txtDireccion = New Telerik.WinControls.UI.RadTextBox()
            Me.grpbContacto = New Telerik.WinControls.UI.RadGroupBox()
            Me.txtWeb = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.txtEmail = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.txtFax = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.txtMovil = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.txtTelefono = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.txtNumeroIdentificacion = New Telerik.WinControls.UI.RadTextBox()
            Me.txtNombre = New Telerik.WinControls.UI.RadTextBox()
            Me.bgwCarga = New System.ComponentModel.BackgroundWorker()
            Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
            Me.cbstripeAccion = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbbtnAgregar = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbbtnModificar = New Telerik.WinControls.UI.CommandBarButton()
            Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
            Me.cbbtnFijarActivo = New Telerik.WinControls.UI.CommandBarButton()
            Me.cbstripeOrden = New Telerik.WinControls.UI.CommandBarStripElement()
            Me.cbComandos = New Telerik.WinControls.UI.RadCommandBar()
            Me.timValidar = New System.Windows.Forms.Timer(Me.components)
            Me.dlgImagen = New System.Windows.Forms.OpenFileDialog()
            Me.chkVentaDetalle = New Telerik.WinControls.UI.RadCheckBox()
            Me.chkVentaAlmayor = New Telerik.WinControls.UI.RadCheckBox()
            RadLabel16 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            RadLabel17 = New Telerik.WinControls.UI.RadLabel()
            RadLabel12 = New Telerik.WinControls.UI.RadLabel()
            RadLabel13 = New Telerik.WinControls.UI.RadLabel()
            RadLabel15 = New Telerik.WinControls.UI.RadLabel()
            RadLabel11 = New Telerik.WinControls.UI.RadLabel()
            RadLabel10 = New Telerik.WinControls.UI.RadLabel()
            RadLabel9 = New Telerik.WinControls.UI.RadLabel()
            RadLabel8 = New Telerik.WinControls.UI.RadLabel()
            RadLabel3 = New Telerik.WinControls.UI.RadLabel()
            RadLabel5 = New Telerik.WinControls.UI.RadLabel()
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            RadLabel6 = New Telerik.WinControls.UI.RadLabel()
            RadLabel7 = New Telerik.WinControls.UI.RadLabel()
            RadLabel14 = New Telerik.WinControls.UI.RadLabel()
            RadLabel18 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadSplitContainer1.SuspendLayout()
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel1.SuspendLayout()
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitPanel2.SuspendLayout()
            CType(Me.ddlFormato, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnQuitarImagen, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnExaminarImagen, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNumeroCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNombreComercial, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grpbDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpbDireccion.SuspendLayout()
            CType(Me.txtCodigoPostal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MunicipiosEspañolasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProvinciasEspañolasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grpbContacto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpbContacto.SuspendLayout()
            CType(Me.txtWeb, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtFax, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtMovil, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNumeroIdentificacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkVentaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkVentaAlmayor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
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
            RadLabel16.RootElement.AccessibleDescription = Nothing
            RadLabel16.RootElement.AccessibleName = Nothing
            '
            'RadLabel2
            '
            resources.ApplyResources(RadLabel2, "RadLabel2")
            RadLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel2.Name = "RadLabel2"
            '
            '
            '
            RadLabel2.RootElement.AccessibleDescription = Nothing
            RadLabel2.RootElement.AccessibleName = Nothing
            '
            'RadLabel17
            '
            resources.ApplyResources(RadLabel17, "RadLabel17")
            RadLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel17.Name = "RadLabel17"
            '
            '
            '
            RadLabel17.RootElement.AccessibleDescription = Nothing
            RadLabel17.RootElement.AccessibleName = Nothing
            '
            'RadLabel12
            '
            resources.ApplyResources(RadLabel12, "RadLabel12")
            RadLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel12.Name = "RadLabel12"
            '
            '
            '
            RadLabel12.RootElement.AccessibleDescription = Nothing
            RadLabel12.RootElement.AccessibleName = Nothing
            '
            'RadLabel13
            '
            resources.ApplyResources(RadLabel13, "RadLabel13")
            RadLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel13.Name = "RadLabel13"
            '
            '
            '
            RadLabel13.RootElement.AccessibleDescription = Nothing
            RadLabel13.RootElement.AccessibleName = Nothing
            '
            'RadLabel15
            '
            resources.ApplyResources(RadLabel15, "RadLabel15")
            RadLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel15.Name = "RadLabel15"
            '
            '
            '
            RadLabel15.RootElement.AccessibleDescription = Nothing
            RadLabel15.RootElement.AccessibleName = Nothing
            '
            'RadLabel11
            '
            resources.ApplyResources(RadLabel11, "RadLabel11")
            RadLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel11.Name = "RadLabel11"
            '
            '
            '
            RadLabel11.RootElement.AccessibleDescription = Nothing
            RadLabel11.RootElement.AccessibleName = Nothing
            '
            'RadLabel10
            '
            resources.ApplyResources(RadLabel10, "RadLabel10")
            RadLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel10.Name = "RadLabel10"
            '
            '
            '
            RadLabel10.RootElement.AccessibleDescription = Nothing
            RadLabel10.RootElement.AccessibleName = Nothing
            '
            'RadLabel9
            '
            resources.ApplyResources(RadLabel9, "RadLabel9")
            RadLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel9.Name = "RadLabel9"
            '
            '
            '
            RadLabel9.RootElement.AccessibleDescription = Nothing
            RadLabel9.RootElement.AccessibleName = Nothing
            '
            'RadLabel8
            '
            resources.ApplyResources(RadLabel8, "RadLabel8")
            RadLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel8.Name = "RadLabel8"
            '
            '
            '
            RadLabel8.RootElement.AccessibleDescription = Nothing
            RadLabel8.RootElement.AccessibleName = Nothing
            '
            'RadLabel3
            '
            resources.ApplyResources(RadLabel3, "RadLabel3")
            RadLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel3.Name = "RadLabel3"
            '
            '
            '
            RadLabel3.RootElement.AccessibleDescription = Nothing
            RadLabel3.RootElement.AccessibleName = Nothing
            '
            'RadLabel5
            '
            resources.ApplyResources(RadLabel5, "RadLabel5")
            RadLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel5.Name = "RadLabel5"
            '
            '
            '
            RadLabel5.RootElement.AccessibleDescription = Nothing
            RadLabel5.RootElement.AccessibleName = Nothing
            '
            'RadLabel1
            '
            resources.ApplyResources(RadLabel1, "RadLabel1")
            RadLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel1.Name = "RadLabel1"
            '
            '
            '
            RadLabel1.RootElement.AccessibleDescription = Nothing
            RadLabel1.RootElement.AccessibleName = Nothing
            '
            'RadLabel4
            '
            resources.ApplyResources(RadLabel4, "RadLabel4")
            RadLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel4.Name = "RadLabel4"
            '
            '
            '
            RadLabel4.RootElement.AccessibleDescription = Nothing
            RadLabel4.RootElement.AccessibleName = Nothing
            '
            'RadLabel6
            '
            resources.ApplyResources(RadLabel6, "RadLabel6")
            RadLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel6.Name = "RadLabel6"
            '
            '
            '
            RadLabel6.RootElement.AccessibleDescription = Nothing
            RadLabel6.RootElement.AccessibleName = Nothing
            '
            'RadLabel7
            '
            resources.ApplyResources(RadLabel7, "RadLabel7")
            RadLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel7.Name = "RadLabel7"
            '
            '
            '
            RadLabel7.RootElement.AccessibleDescription = Nothing
            RadLabel7.RootElement.AccessibleName = Nothing
            '
            'RadLabel14
            '
            resources.ApplyResources(RadLabel14, "RadLabel14")
            RadLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel14.Name = "RadLabel14"
            '
            '
            '
            RadLabel14.RootElement.AccessibleDescription = Nothing
            RadLabel14.RootElement.AccessibleName = Nothing
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
            Me.gridDatos.MasterTemplate.AutoGenerateColumns = False
            GridViewCheckBoxColumn1.AllowFiltering = False
            GridViewCheckBoxColumn1.AllowGroup = False
            GridViewCheckBoxColumn1.AllowResize = False
            GridViewCheckBoxColumn1.AllowSort = False
            GridViewCheckBoxColumn1.EnableExpressionEditor = False
            GridViewCheckBoxColumn1.FieldName = "Activo"
            resources.ApplyResources(GridViewCheckBoxColumn1, "GridViewCheckBoxColumn1")
            GridViewCheckBoxColumn1.MinWidth = 20
            GridViewCheckBoxColumn1.Name = "Activo"
            GridViewCheckBoxColumn1.ReadOnly = True
            GridViewCheckBoxColumn1.Width = 60
            GridViewImageColumn1.AllowFiltering = False
            GridViewImageColumn1.AllowSort = False
            GridViewImageColumn1.EnableExpressionEditor = False
            GridViewImageColumn1.FieldName = "LogoImagen"
            resources.ApplyResources(GridViewImageColumn1, "GridViewImageColumn1")
            GridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center
            GridViewImageColumn1.IsVisible = False
            GridViewImageColumn1.Name = "LogoImagen"
            GridViewImageColumn1.Width = 94
            GridViewTextBoxColumn1.AllowGroup = False
            GridViewTextBoxColumn1.EnableExpressionEditor = False
            GridViewTextBoxColumn1.FieldName = "Empresa"
            resources.ApplyResources(GridViewTextBoxColumn1, "GridViewTextBoxColumn1")
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.Name = "Empresa"
            GridViewTextBoxColumn1.ReadOnly = True
            GridViewTextBoxColumn1.Width = 246
            GridViewTextBoxColumn2.AllowGroup = False
            GridViewTextBoxColumn2.EnableExpressionEditor = False
            GridViewTextBoxColumn2.FieldName = "NIF"
            resources.ApplyResources(GridViewTextBoxColumn2, "GridViewTextBoxColumn2")
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.Name = "NIF"
            GridViewTextBoxColumn2.ReadOnly = True
            GridViewTextBoxColumn2.Width = 149
            GridViewTextBoxColumn3.AllowGroup = False
            GridViewTextBoxColumn3.EnableExpressionEditor = False
            GridViewTextBoxColumn3.FieldName = "NombreComercial"
            resources.ApplyResources(GridViewTextBoxColumn3, "GridViewTextBoxColumn3")
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.Name = "NombreComercial"
            GridViewTextBoxColumn3.ReadOnly = True
            GridViewTextBoxColumn3.Width = 268
            Me.gridDatos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewCheckBoxColumn1, GridViewImageColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3})
            Me.gridDatos.MasterTemplate.DataSource = Me.EmpresasBindingSource
            Me.gridDatos.MasterTemplate.EnableAlternatingRowColor = True
            Me.gridDatos.MasterTemplate.EnableFiltering = True
            Me.gridDatos.MasterTemplate.EnableGrouping = False
            Me.gridDatos.MasterTemplate.ViewDefinition = TableViewDefinition1
            Me.gridDatos.Name = "gridDatos"
            Me.gridDatos.ReadOnly = True
            '
            '
            '
            Me.gridDatos.RootElement.AccessibleDescription = Nothing
            Me.gridDatos.RootElement.AccessibleName = Nothing
            Me.gridDatos.ShowGroupPanel = False
            Me.gridDatos.TabStop = False
            '
            'EmpresasBindingSource
            '
            Me.EmpresasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Empresas)
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
            Me.RadSplitContainer1.RootElement.AccessibleDescription = Nothing
            Me.RadSplitContainer1.RootElement.AccessibleName = Nothing
            Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 23)
            Me.RadSplitContainer1.TabStop = False
            '
            'SplitPanel1
            '
            Me.SplitPanel1.Controls.Add(Me.gridDatos)
            resources.ApplyResources(Me.SplitPanel1, "SplitPanel1")
            Me.SplitPanel1.Name = "SplitPanel1"
            '
            '
            '
            Me.SplitPanel1.RootElement.AccessibleDescription = Nothing
            Me.SplitPanel1.RootElement.AccessibleName = Nothing
            Me.SplitPanel1.RootElement.MinSize = New System.Drawing.Size(25, 23)
            Me.SplitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.1980109!, -0.3442478!)
            Me.SplitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(189, -194)
            Me.SplitPanel1.TabStop = False
            '
            'SplitPanel2
            '
            Me.SplitPanel2.Controls.Add(Me.chkVentaAlmayor)
            Me.SplitPanel2.Controls.Add(Me.chkVentaDetalle)
            Me.SplitPanel2.Controls.Add(RadLabel7)
            Me.SplitPanel2.Controls.Add(Me.ddlFormato)
            Me.SplitPanel2.Controls.Add(Me.btnCancelar)
            Me.SplitPanel2.Controls.Add(Me.btnQuitarImagen)
            Me.SplitPanel2.Controls.Add(RadLabel14)
            Me.SplitPanel2.Controls.Add(Me.btnExaminarImagen)
            Me.SplitPanel2.Controls.Add(Me.picLogo)
            Me.SplitPanel2.Controls.Add(Me.txtNumeroCuenta)
            Me.SplitPanel2.Controls.Add(Me.txtNombreComercial)
            Me.SplitPanel2.Controls.Add(RadLabel18)
            Me.SplitPanel2.Controls.Add(RadLabel16)
            Me.SplitPanel2.Controls.Add(Me.txtSerie)
            Me.SplitPanel2.Controls.Add(RadLabel2)
            Me.SplitPanel2.Controls.Add(Me.btnAceptar)
            Me.SplitPanel2.Controls.Add(Me.grpbDireccion)
            Me.SplitPanel2.Controls.Add(Me.grpbContacto)
            Me.SplitPanel2.Controls.Add(Me.txtNumeroIdentificacion)
            Me.SplitPanel2.Controls.Add(RadLabel3)
            Me.SplitPanel2.Controls.Add(RadLabel5)
            Me.SplitPanel2.Controls.Add(Me.txtNombre)
            Me.SplitPanel2.Controls.Add(RadLabel6)
            Me.SplitPanel2.Controls.Add(RadLabel1)
            resources.ApplyResources(Me.SplitPanel2, "SplitPanel2")
            Me.SplitPanel2.Name = "SplitPanel2"
            '
            '
            '
            Me.SplitPanel2.RootElement.AccessibleDescription = Nothing
            Me.SplitPanel2.RootElement.AccessibleName = Nothing
            Me.SplitPanel2.RootElement.MinSize = New System.Drawing.Size(25, 23)
            Me.SplitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.3442478!)
            Me.SplitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 194)
            Me.SplitPanel2.TabStop = False
            '
            'ddlFormato
            '
            Me.ddlFormato.AllowShowFocusCues = True
            Me.ddlFormato.AutoCompleteDisplayMember = "Municipio"
            Me.ddlFormato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ddlFormato.AutoCompleteValueMember = "CodMunicipio"
            Me.ddlFormato.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpresaBindingSource, "FormatoNumeracion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlFormato.DisplayMember = "Municipio"
            Me.ddlFormato.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlFormato.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
            Me.ddlFormato.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            resources.ApplyResources(Me.ddlFormato, "ddlFormato")
            Me.ddlFormato.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            RadListDataItem1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            RadListDataItem1.Selected = True
            RadListDataItem1.Text = "Núm./Año"
            RadListDataItem2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            RadListDataItem2.Text = "Núm./Serie"
            RadListDataItem3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            RadListDataItem3.Text = "Núm./Año/Serie"
            Me.ddlFormato.Items.Add(RadListDataItem1)
            Me.ddlFormato.Items.Add(RadListDataItem2)
            Me.ddlFormato.Items.Add(RadListDataItem3)
            Me.ddlFormato.Name = "ddlFormato"
            '
            '
            '
            Me.ddlFormato.RootElement.AccessibleDescription = Nothing
            Me.ddlFormato.RootElement.AccessibleName = Nothing
            Me.ddlFormato.SelectNextOnDoubleClick = True
            Me.ddlFormato.ValueMember = "CodMunicipio"
            CType(Me.ddlFormato.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            '
            'EmpresaBindingSource
            '
            Me.EmpresaBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Empresas)
            '
            'btnCancelar
            '
            resources.ApplyResources(Me.btnCancelar, "btnCancelar")
            Me.btnCancelar.Image = Global.EasyGest.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
            '
            '
            '
            Me.btnCancelar.RootElement.AccessibleDescription = Nothing
            Me.btnCancelar.RootElement.AccessibleName = Nothing
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.cancel
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text")
            CType(Me.btnCancelar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(10, Byte), Integer))
            '
            'btnQuitarImagen
            '
            resources.ApplyResources(Me.btnQuitarImagen, "btnQuitarImagen")
            Me.btnQuitarImagen.Image = Global.EasyGest.My.Resources.Resources.image_delete
            Me.btnQuitarImagen.Name = "btnQuitarImagen"
            '
            '
            '
            Me.btnQuitarImagen.RootElement.AccessibleDescription = Nothing
            Me.btnQuitarImagen.RootElement.AccessibleName = Nothing
            '
            'btnExaminarImagen
            '
            resources.ApplyResources(Me.btnExaminarImagen, "btnExaminarImagen")
            Me.btnExaminarImagen.Image = Global.EasyGest.My.Resources.Resources.folder
            Me.btnExaminarImagen.Name = "btnExaminarImagen"
            '
            '
            '
            Me.btnExaminarImagen.RootElement.AccessibleDescription = Nothing
            Me.btnExaminarImagen.RootElement.AccessibleName = Nothing
            '
            'picLogo
            '
            resources.ApplyResources(Me.picLogo, "picLogo")
            Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picLogo.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EmpresaBindingSource, "LogoImagen", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.picLogo.Name = "picLogo"
            Me.picLogo.TabStop = False
            '
            'txtNumeroCuenta
            '
            Me.txtNumeroCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "CuentaBanco", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtNumeroCuenta, "txtNumeroCuenta")
            Me.txtNumeroCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
            '
            '
            '
            Me.txtNumeroCuenta.RootElement.AccessibleDescription = Nothing
            Me.txtNumeroCuenta.RootElement.AccessibleName = Nothing
            Me.txtNumeroCuenta.TabStop = False
            Me.txtNumeroCuenta.Tag = ""
            CType(Me.txtNumeroCuenta.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text1")
            CType(Me.txtNumeroCuenta.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNumeroCuenta.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtNumeroCuenta.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNumeroCuenta.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtNumeroCuenta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtNombreComercial
            '
            Me.txtNombreComercial.AllowShowFocusCues = True
            Me.txtNombreComercial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "NombreComercial", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtNombreComercial, "txtNombreComercial")
            Me.txtNombreComercial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtNombreComercial.Name = "txtNombreComercial"
            '
            '
            '
            Me.txtNombreComercial.RootElement.AccessibleDescription = Nothing
            Me.txtNombreComercial.RootElement.AccessibleName = Nothing
            Me.txtNombreComercial.RootElement.ApplyShapeToControl = False
            Me.txtNombreComercial.TabStop = False
            Me.txtNombreComercial.Tag = ""
            CType(Me.txtNombreComercial.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text2")
            CType(Me.txtNombreComercial.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNombreComercial.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtNombreComercial.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNombreComercial.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtNombreComercial.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtSerie
            '
            Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSerie.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Series", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtSerie, "txtSerie")
            Me.txtSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtSerie.Name = "txtSerie"
            '
            '
            '
            Me.txtSerie.RootElement.AccessibleDescription = Nothing
            Me.txtSerie.RootElement.AccessibleName = Nothing
            Me.txtSerie.RootElement.ApplyShapeToControl = False
            Me.txtSerie.TabStop = False
            Me.txtSerie.Tag = ""
            CType(Me.txtSerie.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text3")
            CType(Me.txtSerie.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtSerie.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtSerie.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtSerie.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtSerie.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'btnAceptar
            '
            resources.ApplyResources(Me.btnAceptar, "btnAceptar")
            Me.btnAceptar.Image = Global.EasyGest.My.Resources.Resources.accept
            Me.btnAceptar.Name = "btnAceptar"
            '
            '
            '
            Me.btnAceptar.RootElement.AccessibleDescription = Nothing
            Me.btnAceptar.RootElement.AccessibleName = Nothing
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.accept
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text4")
            CType(Me.btnAceptar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
            '
            'grpbDireccion
            '
            Me.grpbDireccion.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.grpbDireccion.Controls.Add(Me.txtCodigoPostal)
            Me.grpbDireccion.Controls.Add(Me.ddlLocalidad)
            Me.grpbDireccion.Controls.Add(Me.ddlProvincia)
            Me.grpbDireccion.Controls.Add(RadLabel17)
            Me.grpbDireccion.Controls.Add(RadLabel12)
            Me.grpbDireccion.Controls.Add(RadLabel13)
            Me.grpbDireccion.Controls.Add(Me.txtDireccion)
            Me.grpbDireccion.Controls.Add(RadLabel15)
            resources.ApplyResources(Me.grpbDireccion, "grpbDireccion")
            Me.grpbDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.grpbDireccion.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            Me.grpbDireccion.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far
            Me.grpbDireccion.HeaderTextAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.grpbDireccion.Name = "grpbDireccion"
            '
            '
            '
            Me.grpbDireccion.RootElement.AccessibleDescription = Nothing
            Me.grpbDireccion.RootElement.AccessibleName = Nothing
            Me.grpbDireccion.TabStop = False
            CType(Me.grpbDireccion.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far
            CType(Me.grpbDireccion.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).Padding = CType(resources.GetObject("resource.Padding"), System.Windows.Forms.Padding)
            CType(Me.grpbDireccion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            CType(Me.grpbDireccion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            '
            'txtCodigoPostal
            '
            Me.txtCodigoPostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "CodigoPostal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtCodigoPostal, "txtCodigoPostal")
            Me.txtCodigoPostal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtCodigoPostal.Name = "txtCodigoPostal"
            '
            '
            '
            Me.txtCodigoPostal.RootElement.AccessibleDescription = Nothing
            Me.txtCodigoPostal.RootElement.AccessibleName = Nothing
            Me.txtCodigoPostal.TabStop = False
            Me.txtCodigoPostal.Tag = ""
            CType(Me.txtCodigoPostal.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text5")
            CType(Me.txtCodigoPostal.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtCodigoPostal.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'ddlLocalidad
            '
            Me.ddlLocalidad.AllowShowFocusCues = True
            Me.ddlLocalidad.AutoCompleteDisplayMember = "Municipio"
            Me.ddlLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ddlLocalidad.AutoCompleteValueMember = "CodMunicipio"
            Me.ddlLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ddlLocalidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Localidad", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlLocalidad.DataSource = Me.MunicipiosEspañolasBindingSource
            Me.ddlLocalidad.DisplayMember = "Municipio"
            Me.ddlLocalidad.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlLocalidad.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
            resources.ApplyResources(Me.ddlLocalidad, "ddlLocalidad")
            Me.ddlLocalidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlLocalidad.Name = "ddlLocalidad"
            '
            '
            '
            Me.ddlLocalidad.RootElement.AccessibleDescription = Nothing
            Me.ddlLocalidad.RootElement.AccessibleName = Nothing
            Me.ddlLocalidad.SelectNextOnDoubleClick = True
            Me.ddlLocalidad.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlLocalidad.ValueMember = "CodMunicipio"
            CType(Me.ddlLocalidad.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
            '
            'MunicipiosEspañolasBindingSource
            '
            Me.MunicipiosEspañolasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.MunicipiosEspañolas)
            Me.MunicipiosEspañolasBindingSource.Sort = "Municipio"
            '
            'ddlProvincia
            '
            Me.ddlProvincia.AllowShowFocusCues = True
            Me.ddlProvincia.AutoCompleteDisplayMember = "Provincia"
            Me.ddlProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ddlProvincia.AutoCompleteValueMember = "CodProvincia"
            Me.ddlProvincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Provincia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlProvincia.DataSource = Me.ProvinciasEspañolasBindingSource
            Me.ddlProvincia.DisplayMember = "Provincia"
            Me.ddlProvincia.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlProvincia.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
            resources.ApplyResources(Me.ddlProvincia, "ddlProvincia")
            Me.ddlProvincia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlProvincia.Name = "ddlProvincia"
            '
            '
            '
            Me.ddlProvincia.RootElement.AccessibleDescription = Nothing
            Me.ddlProvincia.RootElement.AccessibleName = Nothing
            Me.ddlProvincia.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlProvincia.ValueMember = "CodProvincia"
            CType(Me.ddlProvincia.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
            '
            'ProvinciasEspañolasBindingSource
            '
            Me.ProvinciasEspañolasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.ProvinciasEspañolas)
            '
            'txtDireccion
            '
            Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Direccion", True))
            resources.ApplyResources(Me.txtDireccion, "txtDireccion")
            Me.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtDireccion.Name = "txtDireccion"
            '
            '
            '
            Me.txtDireccion.RootElement.AccessibleDescription = Nothing
            Me.txtDireccion.RootElement.AccessibleName = Nothing
            Me.txtDireccion.RootElement.ApplyShapeToControl = False
            Me.txtDireccion.TabStop = False
            Me.txtDireccion.Tag = ""
            CType(Me.txtDireccion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text6")
            CType(Me.txtDireccion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtDireccion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtDireccion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtDireccion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtDireccion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'grpbContacto
            '
            Me.grpbContacto.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.grpbContacto.Controls.Add(Me.txtWeb)
            Me.grpbContacto.Controls.Add(Me.txtEmail)
            Me.grpbContacto.Controls.Add(Me.txtFax)
            Me.grpbContacto.Controls.Add(Me.txtMovil)
            Me.grpbContacto.Controls.Add(Me.txtTelefono)
            Me.grpbContacto.Controls.Add(RadLabel4)
            Me.grpbContacto.Controls.Add(RadLabel11)
            Me.grpbContacto.Controls.Add(RadLabel10)
            Me.grpbContacto.Controls.Add(RadLabel9)
            Me.grpbContacto.Controls.Add(RadLabel8)
            resources.ApplyResources(Me.grpbContacto, "grpbContacto")
            Me.grpbContacto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.grpbContacto.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            Me.grpbContacto.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far
            Me.grpbContacto.HeaderTextAlignment = System.Drawing.ContentAlignment.BottomCenter
            Me.grpbContacto.Name = "grpbContacto"
            '
            '
            '
            Me.grpbContacto.RootElement.AccessibleDescription = Nothing
            Me.grpbContacto.RootElement.AccessibleName = Nothing
            Me.grpbContacto.TabStop = False
            CType(Me.grpbContacto.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far
            CType(Me.grpbContacto.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).Padding = CType(resources.GetObject("resource.Padding1"), System.Windows.Forms.Padding)
            CType(Me.grpbContacto.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            CType(Me.grpbContacto.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            '
            'txtWeb
            '
            Me.txtWeb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Web", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtWeb, "txtWeb")
            Me.txtWeb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtWeb.Name = "txtWeb"
            '
            '
            '
            Me.txtWeb.RootElement.AccessibleDescription = Nothing
            Me.txtWeb.RootElement.AccessibleName = Nothing
            Me.txtWeb.TabStop = False
            CType(Me.txtWeb.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text7")
            CType(Me.txtWeb.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtWeb.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtEmail
            '
            Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Email", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtEmail, "txtEmail")
            Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtEmail.Name = "txtEmail"
            '
            '
            '
            Me.txtEmail.RootElement.AccessibleDescription = Nothing
            Me.txtEmail.RootElement.AccessibleName = Nothing
            Me.txtEmail.TabStop = False
            CType(Me.txtEmail.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text8")
            CType(Me.txtEmail.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtEmail.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtFax
            '
            Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Fax", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtFax, "txtFax")
            Me.txtFax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtFax.Name = "txtFax"
            '
            '
            '
            Me.txtFax.RootElement.AccessibleDescription = Nothing
            Me.txtFax.RootElement.AccessibleName = Nothing
            Me.txtFax.TabStop = False
            CType(Me.txtFax.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text9")
            CType(Me.txtFax.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtFax.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtMovil
            '
            Me.txtMovil.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Movil", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtMovil, "txtMovil")
            Me.txtMovil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtMovil.Name = "txtMovil"
            '
            '
            '
            Me.txtMovil.RootElement.AccessibleDescription = Nothing
            Me.txtMovil.RootElement.AccessibleName = Nothing
            Me.txtMovil.TabStop = False
            CType(Me.txtMovil.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text10")
            CType(Me.txtMovil.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtMovil.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtTelefono
            '
            Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Telefono", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtTelefono, "txtTelefono")
            Me.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtTelefono.Name = "txtTelefono"
            '
            '
            '
            Me.txtTelefono.RootElement.AccessibleDescription = Nothing
            Me.txtTelefono.RootElement.AccessibleName = Nothing
            Me.txtTelefono.TabStop = False
            CType(Me.txtTelefono.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text11")
            CType(Me.txtTelefono.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtTelefono.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtNumeroIdentificacion
            '
            Me.txtNumeroIdentificacion.AllowShowFocusCues = True
            Me.txtNumeroIdentificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroIdentificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "NIF", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtNumeroIdentificacion, "txtNumeroIdentificacion")
            Me.txtNumeroIdentificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion"
            '
            '
            '
            Me.txtNumeroIdentificacion.RootElement.AccessibleDescription = Nothing
            Me.txtNumeroIdentificacion.RootElement.AccessibleName = Nothing
            Me.txtNumeroIdentificacion.RootElement.ApplyShapeToControl = False
            Me.txtNumeroIdentificacion.TabStop = False
            Me.txtNumeroIdentificacion.Tag = ""
            CType(Me.txtNumeroIdentificacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text12")
            CType(Me.txtNumeroIdentificacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNumeroIdentificacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtNumeroIdentificacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNumeroIdentificacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtNumeroIdentificacion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'txtNombre
            '
            Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Empresa", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtNombre, "txtNombre")
            Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtNombre.Name = "txtNombre"
            '
            '
            '
            Me.txtNombre.RootElement.AccessibleDescription = Nothing
            Me.txtNombre.RootElement.AccessibleName = Nothing
            Me.txtNombre.TabStop = False
            Me.txtNombre.Tag = ""
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text13")
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
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
            Me.cbstripeAccion.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cbbtnAgregar, Me.cbbtnModificar, Me.CommandBarSeparator1, Me.cbbtnFijarActivo})
            Me.cbstripeAccion.Name = "CommandBarStripElement1"
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
            'CommandBarSeparator1
            '
            Me.CommandBarSeparator1.AccessibleDescription = "CommandBarSeparator1"
            Me.CommandBarSeparator1.AccessibleName = "CommandBarSeparator1"
            resources.ApplyResources(Me.CommandBarSeparator1, "CommandBarSeparator1")
            Me.CommandBarSeparator1.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.CommandBarSeparator1.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
            Me.CommandBarSeparator1.VisibleInOverflowMenu = False
            '
            'cbbtnFijarActivo
            '
            resources.ApplyResources(Me.cbbtnFijarActivo, "cbbtnFijarActivo")
            Me.cbbtnFijarActivo.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.cbbtnFijarActivo.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.cbbtnFijarActivo.DrawText = True
            Me.cbbtnFijarActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnFijarActivo.Image = Global.EasyGest.My.Resources.Resources._33
            Me.cbbtnFijarActivo.Name = "cbbtnFijarActivo"
            Me.cbbtnFijarActivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'cbstripeOrden
            '
            resources.ApplyResources(Me.cbstripeOrden, "cbstripeOrden")
            Me.cbstripeOrden.Name = "CommandBarStripElement1"
            '
            'cbComandos
            '
            resources.ApplyResources(Me.cbComandos, "cbComandos")
            Me.cbComandos.Name = "cbComandos"
            '
            '
            '
            Me.cbComandos.RootElement.AccessibleDescription = Nothing
            Me.cbComandos.RootElement.AccessibleName = Nothing
            Me.cbComandos.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
            '
            'timValidar
            '
            '
            'dlgImagen
            '
            Me.dlgImagen.DefaultExt = "*.jpg"
            resources.ApplyResources(Me.dlgImagen, "dlgImagen")
            '
            'chkVentaDetalle
            '
            Me.chkVentaDetalle.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.EmpresaBindingSource, "VentaDetalle", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.chkVentaDetalle, "chkVentaDetalle")
            Me.chkVentaDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.chkVentaDetalle.Name = "chkVentaDetalle"
            '
            'chkVentaAlmayor
            '
            Me.chkVentaAlmayor.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.EmpresaBindingSource, "VentaAlmayor", True))
            resources.ApplyResources(Me.chkVentaAlmayor, "chkVentaAlmayor")
            Me.chkVentaAlmayor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.chkVentaAlmayor.Name = "chkVentaAlmayor"
            '
            'RadLabel18
            '
            resources.ApplyResources(RadLabel18, "RadLabel18")
            RadLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel18.Name = "RadLabel18"
            '
            'frmEmpresa
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
            Me.Name = "frmEmpresa"
            Me.Opacity = 0.9R
            '
            '
            '
            Me.RootElement.AccessibleDescription = Nothing
            Me.RootElement.AccessibleName = Nothing
            Me.RootElement.ApplyShapeToControl = True
            CType(RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadSplitContainer1.ResumeLayout(False)
            CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel1.ResumeLayout(False)
            CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitPanel2.ResumeLayout(False)
            Me.SplitPanel2.PerformLayout()
            CType(Me.ddlFormato, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnQuitarImagen, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnExaminarImagen, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNumeroCuenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNombreComercial, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grpbDireccion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpbDireccion.ResumeLayout(False)
            Me.grpbDireccion.PerformLayout()
            CType(Me.txtCodigoPostal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MunicipiosEspañolasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlProvincia, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProvinciasEspañolasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grpbContacto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpbContacto.ResumeLayout(False)
            Me.grpbContacto.PerformLayout()
            CType(Me.txtWeb, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtFax, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtMovil, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNumeroIdentificacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cbComandos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkVentaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkVentaAlmayor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
        Friend WithEvents cbbtnFijarActivo As Telerik.WinControls.UI.CommandBarButton
        Friend WithEvents cbComandos As Telerik.WinControls.UI.RadCommandBar
        Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
        Private WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
        Friend WithEvents SplitPanel2 As Telerik.WinControls.UI.SplitPanel
        Friend WithEvents txtNombreComercial As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents grpbDireccion As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents txtCodigoPostal As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents ddlLocalidad As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents ddlProvincia As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents txtDireccion As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents grpbContacto As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents txtEmail As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents txtFax As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents txtMovil As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents txtTelefono As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents txtNumeroIdentificacion As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtNombre As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents txtWeb As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents txtNumeroCuenta As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents txtSerie As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents picLogo As System.Windows.Forms.PictureBox
        Friend WithEvents btnExaminarImagen As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnQuitarImagen As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents MunicipiosEspañolasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ProvinciasEspañolasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ddlFormato As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents cbstripeOrden As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents timValidar As System.Windows.Forms.Timer
        Friend WithEvents dlgImagen As System.Windows.Forms.OpenFileDialog
        Friend WithEvents chkVentaAlmayor As RadCheckBox
        Friend WithEvents chkVentaDetalle As RadCheckBox
        Friend WithEvents EmpresaBindingSource As BindingSource
    End Class

End Namespace

