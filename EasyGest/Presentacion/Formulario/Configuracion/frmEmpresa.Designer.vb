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
            Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
            Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
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
            RadLabel16.RootElement.Padding = CType(resources.GetObject("RadLabel16.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel16.RootElement.Text = resources.GetString("RadLabel16.RootElement.Text")
            RadLabel16.RootElement.TextOrientation = CType(resources.GetObject("RadLabel16.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel2.RootElement.Padding = CType(resources.GetObject("RadLabel2.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel2.RootElement.Text = resources.GetString("RadLabel2.RootElement.Text")
            RadLabel2.RootElement.TextOrientation = CType(resources.GetObject("RadLabel2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel17.RootElement.Margin = CType(resources.GetObject("RadLabel17.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel17.RootElement.Padding = CType(resources.GetObject("RadLabel17.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel17.RootElement.Text = resources.GetString("RadLabel17.RootElement.Text")
            RadLabel17.RootElement.TextOrientation = CType(resources.GetObject("RadLabel17.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel12.RootElement.Padding = CType(resources.GetObject("RadLabel12.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel12.RootElement.Text = resources.GetString("RadLabel12.RootElement.Text")
            RadLabel12.RootElement.TextOrientation = CType(resources.GetObject("RadLabel12.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel13.RootElement.Padding = CType(resources.GetObject("RadLabel13.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel13.RootElement.Text = resources.GetString("RadLabel13.RootElement.Text")
            RadLabel13.RootElement.TextOrientation = CType(resources.GetObject("RadLabel13.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel15.RootElement.Padding = CType(resources.GetObject("RadLabel15.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel15.RootElement.Text = resources.GetString("RadLabel15.RootElement.Text")
            RadLabel15.RootElement.TextOrientation = CType(resources.GetObject("RadLabel15.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel11.RootElement.Padding = CType(resources.GetObject("RadLabel11.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel11.RootElement.Text = resources.GetString("RadLabel11.RootElement.Text")
            RadLabel11.RootElement.TextOrientation = CType(resources.GetObject("RadLabel11.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel10.RootElement.Padding = CType(resources.GetObject("RadLabel10.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel10.RootElement.Text = resources.GetString("RadLabel10.RootElement.Text")
            RadLabel10.RootElement.TextOrientation = CType(resources.GetObject("RadLabel10.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel9.RootElement.Padding = CType(resources.GetObject("RadLabel9.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel9.RootElement.Text = resources.GetString("RadLabel9.RootElement.Text")
            RadLabel9.RootElement.TextOrientation = CType(resources.GetObject("RadLabel9.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel8.RootElement.Padding = CType(resources.GetObject("RadLabel8.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel8.RootElement.Text = resources.GetString("RadLabel8.RootElement.Text")
            RadLabel8.RootElement.TextOrientation = CType(resources.GetObject("RadLabel8.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel3.RootElement.Padding = CType(resources.GetObject("RadLabel3.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel3.RootElement.Text = resources.GetString("RadLabel3.RootElement.Text")
            RadLabel3.RootElement.TextOrientation = CType(resources.GetObject("RadLabel3.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel5.RootElement.Padding = CType(resources.GetObject("RadLabel5.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel5.RootElement.Text = resources.GetString("RadLabel5.RootElement.Text")
            RadLabel5.RootElement.TextOrientation = CType(resources.GetObject("RadLabel5.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel1.RootElement.Padding = CType(resources.GetObject("RadLabel1.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel1.RootElement.Text = resources.GetString("RadLabel1.RootElement.Text")
            RadLabel1.RootElement.TextOrientation = CType(resources.GetObject("RadLabel1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel4.RootElement.Padding = CType(resources.GetObject("RadLabel4.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel4.RootElement.Text = resources.GetString("RadLabel4.RootElement.Text")
            RadLabel4.RootElement.TextOrientation = CType(resources.GetObject("RadLabel4.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel6.RootElement.Margin = CType(resources.GetObject("RadLabel6.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel6.RootElement.Padding = CType(resources.GetObject("RadLabel6.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel6.RootElement.Text = resources.GetString("RadLabel6.RootElement.Text")
            RadLabel6.RootElement.TextOrientation = CType(resources.GetObject("RadLabel6.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel7.RootElement.Padding = CType(resources.GetObject("RadLabel7.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel7.RootElement.Text = resources.GetString("RadLabel7.RootElement.Text")
            RadLabel7.RootElement.TextOrientation = CType(resources.GetObject("RadLabel7.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            RadLabel14.RootElement.Padding = CType(resources.GetObject("RadLabel14.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel14.RootElement.Text = resources.GetString("RadLabel14.RootElement.Text")
            RadLabel14.RootElement.TextOrientation = CType(resources.GetObject("RadLabel14.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.RadSplitContainer1.RootElement.AccessibleDescription = resources.GetString("RadSplitContainer1.RootElement.AccessibleDescription")
            Me.RadSplitContainer1.RootElement.AccessibleName = resources.GetString("RadSplitContainer1.RootElement.AccessibleName")
            Me.RadSplitContainer1.RootElement.Alignment = CType(resources.GetObject("RadSplitContainer1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadSplitContainer1.RootElement.AngleTransform = CType(resources.GetObject("RadSplitContainer1.RootElement.AngleTransform"), Single)
            Me.RadSplitContainer1.RootElement.FlipText = CType(resources.GetObject("RadSplitContainer1.RootElement.FlipText"), Boolean)
            Me.RadSplitContainer1.RootElement.Margin = CType(resources.GetObject("RadSplitContainer1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 23)
            Me.RadSplitContainer1.RootElement.Padding = CType(resources.GetObject("RadSplitContainer1.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadSplitContainer1.RootElement.Text = resources.GetString("RadSplitContainer1.RootElement.Text")
            Me.RadSplitContainer1.RootElement.TextOrientation = CType(resources.GetObject("RadSplitContainer1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadSplitContainer1.SplitterWidth = 4
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
            Me.SplitPanel1.RootElement.AccessibleDescription = resources.GetString("SplitPanel1.RootElement.AccessibleDescription")
            Me.SplitPanel1.RootElement.AccessibleName = resources.GetString("SplitPanel1.RootElement.AccessibleName")
            Me.SplitPanel1.RootElement.Alignment = CType(resources.GetObject("SplitPanel1.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel1.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel1.RootElement.AngleTransform"), Single)
            Me.SplitPanel1.RootElement.FlipText = CType(resources.GetObject("SplitPanel1.RootElement.FlipText"), Boolean)
            Me.SplitPanel1.RootElement.Margin = CType(resources.GetObject("SplitPanel1.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel1.RootElement.MinSize = New System.Drawing.Size(25, 23)
            Me.SplitPanel1.RootElement.Padding = CType(resources.GetObject("SplitPanel1.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.SplitPanel1.RootElement.Text = resources.GetString("SplitPanel1.RootElement.Text")
            Me.SplitPanel1.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel1.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.1980109!, -0.3442478!)
            Me.SplitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(189, -194)
            Me.SplitPanel1.TabStop = False
            '
            'SplitPanel2
            '
            Me.SplitPanel2.Controls.Add(RadLabel7)
            Me.SplitPanel2.Controls.Add(Me.ddlFormato)
            Me.SplitPanel2.Controls.Add(Me.btnCancelar)
            Me.SplitPanel2.Controls.Add(Me.btnQuitarImagen)
            Me.SplitPanel2.Controls.Add(RadLabel14)
            Me.SplitPanel2.Controls.Add(Me.btnExaminarImagen)
            Me.SplitPanel2.Controls.Add(Me.picLogo)
            Me.SplitPanel2.Controls.Add(Me.txtNumeroCuenta)
            Me.SplitPanel2.Controls.Add(Me.txtNombreComercial)
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
            Me.SplitPanel2.RootElement.AccessibleDescription = resources.GetString("SplitPanel2.RootElement.AccessibleDescription")
            Me.SplitPanel2.RootElement.AccessibleName = resources.GetString("SplitPanel2.RootElement.AccessibleName")
            Me.SplitPanel2.RootElement.Alignment = CType(resources.GetObject("SplitPanel2.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.SplitPanel2.RootElement.AngleTransform = CType(resources.GetObject("SplitPanel2.RootElement.AngleTransform"), Single)
            Me.SplitPanel2.RootElement.FlipText = CType(resources.GetObject("SplitPanel2.RootElement.FlipText"), Boolean)
            Me.SplitPanel2.RootElement.Margin = CType(resources.GetObject("SplitPanel2.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.SplitPanel2.RootElement.MinSize = New System.Drawing.Size(25, 23)
            Me.SplitPanel2.RootElement.Padding = CType(resources.GetObject("SplitPanel2.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.SplitPanel2.RootElement.Text = resources.GetString("SplitPanel2.RootElement.Text")
            Me.SplitPanel2.RootElement.TextOrientation = CType(resources.GetObject("SplitPanel2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.SplitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.0!, 0.3442478!)
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
            resources.ApplyResources(RadListDataItem1, "RadListDataItem1")
            RadListDataItem2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            RadListDataItem2.Text = "Núm./Serie"
            resources.ApplyResources(RadListDataItem2, "RadListDataItem2")
            RadListDataItem3.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            RadListDataItem3.Text = "Núm./Año/Serie"
            resources.ApplyResources(RadListDataItem3, "RadListDataItem3")
            Me.ddlFormato.Items.Add(RadListDataItem1)
            Me.ddlFormato.Items.Add(RadListDataItem2)
            Me.ddlFormato.Items.Add(RadListDataItem3)
            Me.ddlFormato.Name = "ddlFormato"
            '
            '
            '
            Me.ddlFormato.RootElement.AccessibleDescription = resources.GetString("ddlFormato.RootElement.AccessibleDescription")
            Me.ddlFormato.RootElement.AccessibleName = resources.GetString("ddlFormato.RootElement.AccessibleName")
            Me.ddlFormato.RootElement.Alignment = CType(resources.GetObject("ddlFormato.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlFormato.RootElement.AngleTransform = CType(resources.GetObject("ddlFormato.RootElement.AngleTransform"), Single)
            Me.ddlFormato.RootElement.FlipText = CType(resources.GetObject("ddlFormato.RootElement.FlipText"), Boolean)
            Me.ddlFormato.RootElement.Margin = CType(resources.GetObject("ddlFormato.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlFormato.RootElement.Padding = CType(resources.GetObject("ddlFormato.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ddlFormato.RootElement.Text = resources.GetString("ddlFormato.RootElement.Text")
            Me.ddlFormato.RootElement.TextOrientation = CType(resources.GetObject("ddlFormato.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.btnCancelar.RootElement.AccessibleDescription = resources.GetString("btnCancelar.RootElement.AccessibleDescription")
            Me.btnCancelar.RootElement.AccessibleName = resources.GetString("btnCancelar.RootElement.AccessibleName")
            Me.btnCancelar.RootElement.Alignment = CType(resources.GetObject("btnCancelar.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnCancelar.RootElement.AngleTransform = CType(resources.GetObject("btnCancelar.RootElement.AngleTransform"), Single)
            Me.btnCancelar.RootElement.FlipText = CType(resources.GetObject("btnCancelar.RootElement.FlipText"), Boolean)
            Me.btnCancelar.RootElement.Margin = CType(resources.GetObject("btnCancelar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnCancelar.RootElement.Padding = CType(resources.GetObject("btnCancelar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnCancelar.RootElement.Text = resources.GetString("btnCancelar.RootElement.Text")
            Me.btnCancelar.RootElement.TextOrientation = CType(resources.GetObject("btnCancelar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.btnQuitarImagen.RootElement.AccessibleDescription = resources.GetString("btnQuitarImagen.RootElement.AccessibleDescription")
            Me.btnQuitarImagen.RootElement.AccessibleName = resources.GetString("btnQuitarImagen.RootElement.AccessibleName")
            Me.btnQuitarImagen.RootElement.Alignment = CType(resources.GetObject("btnQuitarImagen.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnQuitarImagen.RootElement.AngleTransform = CType(resources.GetObject("btnQuitarImagen.RootElement.AngleTransform"), Single)
            Me.btnQuitarImagen.RootElement.FlipText = CType(resources.GetObject("btnQuitarImagen.RootElement.FlipText"), Boolean)
            Me.btnQuitarImagen.RootElement.Margin = CType(resources.GetObject("btnQuitarImagen.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnQuitarImagen.RootElement.Padding = CType(resources.GetObject("btnQuitarImagen.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnQuitarImagen.RootElement.Text = resources.GetString("btnQuitarImagen.RootElement.Text")
            Me.btnQuitarImagen.RootElement.TextOrientation = CType(resources.GetObject("btnQuitarImagen.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'btnExaminarImagen
            '
            resources.ApplyResources(Me.btnExaminarImagen, "btnExaminarImagen")
            Me.btnExaminarImagen.Image = Global.EasyGest.My.Resources.Resources.folder
            Me.btnExaminarImagen.Name = "btnExaminarImagen"
            '
            '
            '
            Me.btnExaminarImagen.RootElement.AccessibleDescription = resources.GetString("btnExaminarImagen.RootElement.AccessibleDescription")
            Me.btnExaminarImagen.RootElement.AccessibleName = resources.GetString("btnExaminarImagen.RootElement.AccessibleName")
            Me.btnExaminarImagen.RootElement.Alignment = CType(resources.GetObject("btnExaminarImagen.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnExaminarImagen.RootElement.AngleTransform = CType(resources.GetObject("btnExaminarImagen.RootElement.AngleTransform"), Single)
            Me.btnExaminarImagen.RootElement.FlipText = CType(resources.GetObject("btnExaminarImagen.RootElement.FlipText"), Boolean)
            Me.btnExaminarImagen.RootElement.Margin = CType(resources.GetObject("btnExaminarImagen.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnExaminarImagen.RootElement.Padding = CType(resources.GetObject("btnExaminarImagen.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnExaminarImagen.RootElement.Text = resources.GetString("btnExaminarImagen.RootElement.Text")
            Me.btnExaminarImagen.RootElement.TextOrientation = CType(resources.GetObject("btnExaminarImagen.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.txtNumeroCuenta.RootElement.AccessibleDescription = resources.GetString("txtNumeroCuenta.RootElement.AccessibleDescription")
            Me.txtNumeroCuenta.RootElement.AccessibleName = resources.GetString("txtNumeroCuenta.RootElement.AccessibleName")
            Me.txtNumeroCuenta.RootElement.Alignment = CType(resources.GetObject("txtNumeroCuenta.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtNumeroCuenta.RootElement.AngleTransform = CType(resources.GetObject("txtNumeroCuenta.RootElement.AngleTransform"), Single)
            Me.txtNumeroCuenta.RootElement.FlipText = CType(resources.GetObject("txtNumeroCuenta.RootElement.FlipText"), Boolean)
            Me.txtNumeroCuenta.RootElement.Margin = CType(resources.GetObject("txtNumeroCuenta.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtNumeroCuenta.RootElement.Padding = CType(resources.GetObject("txtNumeroCuenta.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtNumeroCuenta.RootElement.Text = resources.GetString("txtNumeroCuenta.RootElement.Text")
            Me.txtNumeroCuenta.RootElement.TextOrientation = CType(resources.GetObject("txtNumeroCuenta.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.txtNombreComercial.RootElement.AccessibleDescription = resources.GetString("txtNombreComercial.RootElement.AccessibleDescription")
            Me.txtNombreComercial.RootElement.AccessibleName = resources.GetString("txtNombreComercial.RootElement.AccessibleName")
            Me.txtNombreComercial.RootElement.Alignment = CType(resources.GetObject("txtNombreComercial.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtNombreComercial.RootElement.AngleTransform = CType(resources.GetObject("txtNombreComercial.RootElement.AngleTransform"), Single)
            Me.txtNombreComercial.RootElement.ApplyShapeToControl = False
            Me.txtNombreComercial.RootElement.FlipText = CType(resources.GetObject("txtNombreComercial.RootElement.FlipText"), Boolean)
            Me.txtNombreComercial.RootElement.Margin = CType(resources.GetObject("txtNombreComercial.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtNombreComercial.RootElement.Padding = CType(resources.GetObject("txtNombreComercial.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtNombreComercial.RootElement.Text = resources.GetString("txtNombreComercial.RootElement.Text")
            Me.txtNombreComercial.RootElement.TextOrientation = CType(resources.GetObject("txtNombreComercial.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.txtSerie.RootElement.AccessibleDescription = resources.GetString("txtSerie.RootElement.AccessibleDescription")
            Me.txtSerie.RootElement.AccessibleName = resources.GetString("txtSerie.RootElement.AccessibleName")
            Me.txtSerie.RootElement.Alignment = CType(resources.GetObject("txtSerie.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtSerie.RootElement.AngleTransform = CType(resources.GetObject("txtSerie.RootElement.AngleTransform"), Single)
            Me.txtSerie.RootElement.ApplyShapeToControl = False
            Me.txtSerie.RootElement.FlipText = CType(resources.GetObject("txtSerie.RootElement.FlipText"), Boolean)
            Me.txtSerie.RootElement.Margin = CType(resources.GetObject("txtSerie.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtSerie.RootElement.Padding = CType(resources.GetObject("txtSerie.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtSerie.RootElement.Text = resources.GetString("txtSerie.RootElement.Text")
            Me.txtSerie.RootElement.TextOrientation = CType(resources.GetObject("txtSerie.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.btnAceptar.RootElement.AccessibleDescription = resources.GetString("btnAceptar.RootElement.AccessibleDescription")
            Me.btnAceptar.RootElement.AccessibleName = resources.GetString("btnAceptar.RootElement.AccessibleName")
            Me.btnAceptar.RootElement.Alignment = CType(resources.GetObject("btnAceptar.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnAceptar.RootElement.AngleTransform = CType(resources.GetObject("btnAceptar.RootElement.AngleTransform"), Single)
            Me.btnAceptar.RootElement.FlipText = CType(resources.GetObject("btnAceptar.RootElement.FlipText"), Boolean)
            Me.btnAceptar.RootElement.Margin = CType(resources.GetObject("btnAceptar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnAceptar.RootElement.Padding = CType(resources.GetObject("btnAceptar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnAceptar.RootElement.Text = resources.GetString("btnAceptar.RootElement.Text")
            Me.btnAceptar.RootElement.TextOrientation = CType(resources.GetObject("btnAceptar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.grpbDireccion.RootElement.AccessibleDescription = resources.GetString("grpbDireccion.RootElement.AccessibleDescription")
            Me.grpbDireccion.RootElement.AccessibleName = resources.GetString("grpbDireccion.RootElement.AccessibleName")
            Me.grpbDireccion.RootElement.Alignment = CType(resources.GetObject("grpbDireccion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.grpbDireccion.RootElement.AngleTransform = CType(resources.GetObject("grpbDireccion.RootElement.AngleTransform"), Single)
            Me.grpbDireccion.RootElement.FlipText = CType(resources.GetObject("grpbDireccion.RootElement.FlipText"), Boolean)
            Me.grpbDireccion.RootElement.Margin = CType(resources.GetObject("grpbDireccion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.grpbDireccion.RootElement.Padding = CType(resources.GetObject("grpbDireccion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.grpbDireccion.RootElement.Text = resources.GetString("grpbDireccion.RootElement.Text")
            Me.grpbDireccion.RootElement.TextOrientation = CType(resources.GetObject("grpbDireccion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.txtCodigoPostal.RootElement.AccessibleDescription = resources.GetString("txtCodigoPostal.RootElement.AccessibleDescription")
            Me.txtCodigoPostal.RootElement.AccessibleName = resources.GetString("txtCodigoPostal.RootElement.AccessibleName")
            Me.txtCodigoPostal.RootElement.Alignment = CType(resources.GetObject("txtCodigoPostal.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtCodigoPostal.RootElement.AngleTransform = CType(resources.GetObject("txtCodigoPostal.RootElement.AngleTransform"), Single)
            Me.txtCodigoPostal.RootElement.FlipText = CType(resources.GetObject("txtCodigoPostal.RootElement.FlipText"), Boolean)
            Me.txtCodigoPostal.RootElement.Margin = CType(resources.GetObject("txtCodigoPostal.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtCodigoPostal.RootElement.Padding = CType(resources.GetObject("txtCodigoPostal.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtCodigoPostal.RootElement.Text = resources.GetString("txtCodigoPostal.RootElement.Text")
            Me.txtCodigoPostal.RootElement.TextOrientation = CType(resources.GetObject("txtCodigoPostal.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.ddlLocalidad.RootElement.AccessibleDescription = resources.GetString("ddlLocalidad.RootElement.AccessibleDescription")
            Me.ddlLocalidad.RootElement.AccessibleName = resources.GetString("ddlLocalidad.RootElement.AccessibleName")
            Me.ddlLocalidad.RootElement.Alignment = CType(resources.GetObject("ddlLocalidad.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlLocalidad.RootElement.AngleTransform = CType(resources.GetObject("ddlLocalidad.RootElement.AngleTransform"), Single)
            Me.ddlLocalidad.RootElement.FlipText = CType(resources.GetObject("ddlLocalidad.RootElement.FlipText"), Boolean)
            Me.ddlLocalidad.RootElement.Margin = CType(resources.GetObject("ddlLocalidad.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlLocalidad.RootElement.Padding = CType(resources.GetObject("ddlLocalidad.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ddlLocalidad.RootElement.Text = resources.GetString("ddlLocalidad.RootElement.Text")
            Me.ddlLocalidad.RootElement.TextOrientation = CType(resources.GetObject("ddlLocalidad.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.ddlProvincia.RootElement.AccessibleDescription = resources.GetString("ddlProvincia.RootElement.AccessibleDescription")
            Me.ddlProvincia.RootElement.AccessibleName = resources.GetString("ddlProvincia.RootElement.AccessibleName")
            Me.ddlProvincia.RootElement.Alignment = CType(resources.GetObject("ddlProvincia.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlProvincia.RootElement.AngleTransform = CType(resources.GetObject("ddlProvincia.RootElement.AngleTransform"), Single)
            Me.ddlProvincia.RootElement.FlipText = CType(resources.GetObject("ddlProvincia.RootElement.FlipText"), Boolean)
            Me.ddlProvincia.RootElement.Margin = CType(resources.GetObject("ddlProvincia.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlProvincia.RootElement.Padding = CType(resources.GetObject("ddlProvincia.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ddlProvincia.RootElement.Text = resources.GetString("ddlProvincia.RootElement.Text")
            Me.ddlProvincia.RootElement.TextOrientation = CType(resources.GetObject("ddlProvincia.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.txtDireccion.RootElement.AccessibleDescription = resources.GetString("txtDireccion.RootElement.AccessibleDescription")
            Me.txtDireccion.RootElement.AccessibleName = resources.GetString("txtDireccion.RootElement.AccessibleName")
            Me.txtDireccion.RootElement.Alignment = CType(resources.GetObject("txtDireccion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtDireccion.RootElement.AngleTransform = CType(resources.GetObject("txtDireccion.RootElement.AngleTransform"), Single)
            Me.txtDireccion.RootElement.ApplyShapeToControl = False
            Me.txtDireccion.RootElement.FlipText = CType(resources.GetObject("txtDireccion.RootElement.FlipText"), Boolean)
            Me.txtDireccion.RootElement.Margin = CType(resources.GetObject("txtDireccion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtDireccion.RootElement.Padding = CType(resources.GetObject("txtDireccion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtDireccion.RootElement.Text = resources.GetString("txtDireccion.RootElement.Text")
            Me.txtDireccion.RootElement.TextOrientation = CType(resources.GetObject("txtDireccion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.grpbContacto.RootElement.AccessibleDescription = resources.GetString("grpbContacto.RootElement.AccessibleDescription")
            Me.grpbContacto.RootElement.AccessibleName = resources.GetString("grpbContacto.RootElement.AccessibleName")
            Me.grpbContacto.RootElement.Alignment = CType(resources.GetObject("grpbContacto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.grpbContacto.RootElement.AngleTransform = CType(resources.GetObject("grpbContacto.RootElement.AngleTransform"), Single)
            Me.grpbContacto.RootElement.FlipText = CType(resources.GetObject("grpbContacto.RootElement.FlipText"), Boolean)
            Me.grpbContacto.RootElement.Margin = CType(resources.GetObject("grpbContacto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.grpbContacto.RootElement.Padding = CType(resources.GetObject("grpbContacto.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.grpbContacto.RootElement.Text = resources.GetString("grpbContacto.RootElement.Text")
            Me.grpbContacto.RootElement.TextOrientation = CType(resources.GetObject("grpbContacto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.txtWeb.RootElement.AccessibleDescription = resources.GetString("txtWeb.RootElement.AccessibleDescription")
            Me.txtWeb.RootElement.AccessibleName = resources.GetString("txtWeb.RootElement.AccessibleName")
            Me.txtWeb.RootElement.Alignment = CType(resources.GetObject("txtWeb.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtWeb.RootElement.AngleTransform = CType(resources.GetObject("txtWeb.RootElement.AngleTransform"), Single)
            Me.txtWeb.RootElement.FlipText = CType(resources.GetObject("txtWeb.RootElement.FlipText"), Boolean)
            Me.txtWeb.RootElement.Margin = CType(resources.GetObject("txtWeb.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtWeb.RootElement.Padding = CType(resources.GetObject("txtWeb.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtWeb.RootElement.Text = resources.GetString("txtWeb.RootElement.Text")
            Me.txtWeb.RootElement.TextOrientation = CType(resources.GetObject("txtWeb.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.txtEmail.RootElement.AccessibleDescription = resources.GetString("txtEmail.RootElement.AccessibleDescription")
            Me.txtEmail.RootElement.AccessibleName = resources.GetString("txtEmail.RootElement.AccessibleName")
            Me.txtEmail.RootElement.Alignment = CType(resources.GetObject("txtEmail.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtEmail.RootElement.AngleTransform = CType(resources.GetObject("txtEmail.RootElement.AngleTransform"), Single)
            Me.txtEmail.RootElement.FlipText = CType(resources.GetObject("txtEmail.RootElement.FlipText"), Boolean)
            Me.txtEmail.RootElement.Margin = CType(resources.GetObject("txtEmail.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtEmail.RootElement.Padding = CType(resources.GetObject("txtEmail.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtEmail.RootElement.Text = resources.GetString("txtEmail.RootElement.Text")
            Me.txtEmail.RootElement.TextOrientation = CType(resources.GetObject("txtEmail.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.txtFax.RootElement.AccessibleDescription = resources.GetString("txtFax.RootElement.AccessibleDescription")
            Me.txtFax.RootElement.AccessibleName = resources.GetString("txtFax.RootElement.AccessibleName")
            Me.txtFax.RootElement.Alignment = CType(resources.GetObject("txtFax.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtFax.RootElement.AngleTransform = CType(resources.GetObject("txtFax.RootElement.AngleTransform"), Single)
            Me.txtFax.RootElement.FlipText = CType(resources.GetObject("txtFax.RootElement.FlipText"), Boolean)
            Me.txtFax.RootElement.Margin = CType(resources.GetObject("txtFax.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtFax.RootElement.Padding = CType(resources.GetObject("txtFax.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtFax.RootElement.Text = resources.GetString("txtFax.RootElement.Text")
            Me.txtFax.RootElement.TextOrientation = CType(resources.GetObject("txtFax.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.txtMovil.RootElement.AccessibleDescription = resources.GetString("txtMovil.RootElement.AccessibleDescription")
            Me.txtMovil.RootElement.AccessibleName = resources.GetString("txtMovil.RootElement.AccessibleName")
            Me.txtMovil.RootElement.Alignment = CType(resources.GetObject("txtMovil.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtMovil.RootElement.AngleTransform = CType(resources.GetObject("txtMovil.RootElement.AngleTransform"), Single)
            Me.txtMovil.RootElement.FlipText = CType(resources.GetObject("txtMovil.RootElement.FlipText"), Boolean)
            Me.txtMovil.RootElement.Margin = CType(resources.GetObject("txtMovil.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtMovil.RootElement.Padding = CType(resources.GetObject("txtMovil.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtMovil.RootElement.Text = resources.GetString("txtMovil.RootElement.Text")
            Me.txtMovil.RootElement.TextOrientation = CType(resources.GetObject("txtMovil.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.txtTelefono.RootElement.AccessibleDescription = resources.GetString("txtTelefono.RootElement.AccessibleDescription")
            Me.txtTelefono.RootElement.AccessibleName = resources.GetString("txtTelefono.RootElement.AccessibleName")
            Me.txtTelefono.RootElement.Alignment = CType(resources.GetObject("txtTelefono.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtTelefono.RootElement.AngleTransform = CType(resources.GetObject("txtTelefono.RootElement.AngleTransform"), Single)
            Me.txtTelefono.RootElement.FlipText = CType(resources.GetObject("txtTelefono.RootElement.FlipText"), Boolean)
            Me.txtTelefono.RootElement.Margin = CType(resources.GetObject("txtTelefono.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtTelefono.RootElement.Padding = CType(resources.GetObject("txtTelefono.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtTelefono.RootElement.Text = resources.GetString("txtTelefono.RootElement.Text")
            Me.txtTelefono.RootElement.TextOrientation = CType(resources.GetObject("txtTelefono.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.txtNumeroIdentificacion.RootElement.AccessibleDescription = resources.GetString("txtNumeroIdentificacion.RootElement.AccessibleDescription")
            Me.txtNumeroIdentificacion.RootElement.AccessibleName = resources.GetString("txtNumeroIdentificacion.RootElement.AccessibleName")
            Me.txtNumeroIdentificacion.RootElement.Alignment = CType(resources.GetObject("txtNumeroIdentificacion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtNumeroIdentificacion.RootElement.AngleTransform = CType(resources.GetObject("txtNumeroIdentificacion.RootElement.AngleTransform"), Single)
            Me.txtNumeroIdentificacion.RootElement.ApplyShapeToControl = False
            Me.txtNumeroIdentificacion.RootElement.FlipText = CType(resources.GetObject("txtNumeroIdentificacion.RootElement.FlipText"), Boolean)
            Me.txtNumeroIdentificacion.RootElement.Margin = CType(resources.GetObject("txtNumeroIdentificacion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtNumeroIdentificacion.RootElement.Padding = CType(resources.GetObject("txtNumeroIdentificacion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtNumeroIdentificacion.RootElement.Text = resources.GetString("txtNumeroIdentificacion.RootElement.Text")
            Me.txtNumeroIdentificacion.RootElement.TextOrientation = CType(resources.GetObject("txtNumeroIdentificacion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.txtNombre.RootElement.AccessibleDescription = resources.GetString("txtNombre.RootElement.AccessibleDescription")
            Me.txtNombre.RootElement.AccessibleName = resources.GetString("txtNombre.RootElement.AccessibleName")
            Me.txtNombre.RootElement.Alignment = CType(resources.GetObject("txtNombre.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtNombre.RootElement.AngleTransform = CType(resources.GetObject("txtNombre.RootElement.AngleTransform"), Single)
            Me.txtNombre.RootElement.FlipText = CType(resources.GetObject("txtNombre.RootElement.FlipText"), Boolean)
            Me.txtNombre.RootElement.Margin = CType(resources.GetObject("txtNombre.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtNombre.RootElement.Padding = CType(resources.GetObject("txtNombre.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtNombre.RootElement.Text = resources.GetString("txtNombre.RootElement.Text")
            Me.txtNombre.RootElement.TextOrientation = CType(resources.GetObject("txtNombre.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            'CommandBarSeparator1
            '
            resources.ApplyResources(Me.CommandBarSeparator1, "CommandBarSeparator1")
            Me.CommandBarSeparator1.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.CommandBarSeparator1.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.CommandBarSeparator1.DisplayName = "CommandBarSeparator1"
            Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
            Me.CommandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me.CommandBarSeparator1.VisibleInOverflowMenu = False
            '
            'cbbtnFijarActivo
            '
            resources.ApplyResources(Me.cbbtnFijarActivo, "cbbtnFijarActivo")
            Me.cbbtnFijarActivo.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical
            Me.cbbtnFijarActivo.BorderLeftShadowColor = System.Drawing.Color.Empty
            Me.cbbtnFijarActivo.DisplayName = "Fijar Activo"
            Me.cbbtnFijarActivo.DrawText = True
            Me.cbbtnFijarActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.cbbtnFijarActivo.Image = Global.EasyGest.My.Resources.Resources._33
            Me.cbbtnFijarActivo.Name = "cbbtnFijarActivo"
            Me.cbbtnFijarActivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me.cbbtnFijarActivo.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'cbstripeOrden
            '
            resources.ApplyResources(Me.cbstripeOrden, "cbstripeOrden")
            Me.cbstripeOrden.DisplayName = "CommandBarStripElement1"
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
            Me.cbComandos.RootElement.Margin = CType(resources.GetObject("cbComandos.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.cbComandos.RootElement.Padding = CType(resources.GetObject("cbComandos.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.cbComandos.RootElement.Text = resources.GetString("cbComandos.RootElement.Text")
            Me.cbComandos.RootElement.TextOrientation = CType(resources.GetObject("cbComandos.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.RootElement.AccessibleDescription = resources.GetString("frmEmpresa.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmEmpresa.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmEmpresa.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmEmpresa.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmEmpresa.RootElement.FlipText"), Boolean)
            Me.RootElement.Margin = CType(resources.GetObject("frmEmpresa.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmEmpresa.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmEmpresa.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmEmpresa.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
        Friend WithEvents EmpresaBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents MunicipiosEspañolasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ProvinciasEspañolasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ddlFormato As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents cbstripeOrden As Telerik.WinControls.UI.CommandBarStripElement
        Friend WithEvents timValidar As System.Windows.Forms.Timer
        Friend WithEvents dlgImagen As System.Windows.Forms.OpenFileDialog
    End Class

End Namespace

