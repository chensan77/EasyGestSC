Namespace Presentacion.Formulario.Cliente

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmClienteEdicion
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteEdicion))
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
            Me.lblAplicarImpIndirecto = New Telerik.WinControls.UI.RadLabel()
            Me.grpbContacto = New Telerik.WinControls.UI.RadGroupBox()
            Me.txtEmail = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.txtFax = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.txtMovil = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.txtTelefono = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.grpbDireccion = New Telerik.WinControls.UI.RadGroupBox()
            Me.txtCodigoPostal = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.ddlLocalidad = New Telerik.WinControls.UI.RadDropDownList()
            Me.MunicipiosEspañolasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ddlProvincia = New Telerik.WinControls.UI.RadDropDownList()
            Me.ProvinciasEspañolasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.txtPais = New Telerik.WinControls.UI.RadTextBox()
            Me.txtDireccion = New Telerik.WinControls.UI.RadTextBox()
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.ddlTipoIdentificacion = New Telerik.WinControls.UI.RadDropDownList()
            Me.TiposIdentificacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.txtNumeroIdentificacion = New Telerik.WinControls.UI.RadTextBox()
            Me.txtNombre = New Telerik.WinControls.UI.RadTextBox()
            Me.txtNombreChino = New Telerik.WinControls.UI.RadTextBox()
            Me.txtNombreContacto = New Telerik.WinControls.UI.RadTextBox()
            Me.chkAplicarRE = New Telerik.WinControls.UI.RadCheckBox()
            Me.spinDescuento = New Telerik.WinControls.UI.RadSpinEditor()
            Me.txtCodigo = New Telerik.WinControls.UI.RadTextBox()
            Me.timValidar = New System.Windows.Forms.Timer(Me.components)
            Me.txtObservacion = New Telerik.WinControls.UI.RadTextBox()
            Me.dtpFNacimiento = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.chkAplicarImpInd = New Telerik.WinControls.UI.RadCheckBox()
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
            CType(Me.lblAplicarImpIndirecto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grpbContacto, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpbContacto.SuspendLayout()
            CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtFax, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtMovil, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grpbDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpbDireccion.SuspendLayout()
            CType(Me.txtCodigoPostal, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MunicipiosEspañolasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlProvincia, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProvinciasEspañolasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPais, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlTipoIdentificacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TiposIdentificacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNumeroIdentificacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNombreChino, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNombreContacto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAplicarRE, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkAplicarImpInd, System.ComponentModel.ISupportInitialize).BeginInit()
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
            RadLabel19.RootElement.Text = resources.GetString("RadLabel19.RootElement.Text")
            RadLabel19.RootElement.TextOrientation = CType(resources.GetObject("RadLabel19.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel19.RootElement.ToolTipText = resources.GetString("RadLabel19.RootElement.ToolTipText")
            '
            'lblAplicarImpIndirecto
            '
            resources.ApplyResources(Me.lblAplicarImpIndirecto, "lblAplicarImpIndirecto")
            Me.lblAplicarImpIndirecto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.lblAplicarImpIndirecto.Name = "lblAplicarImpIndirecto"
            '
            '
            '
            lblAplicarImpIndirecto.RootElement.AccessibleDescription = resources.GetString("lblAplicarImpIndirecto.RootElement.AccessibleDescription")
            lblAplicarImpIndirecto.RootElement.AccessibleName = resources.GetString("lblAplicarImpIndirecto.RootElement.AccessibleName")
            lblAplicarImpIndirecto.RootElement.Alignment = CType(resources.GetObject("lblAplicarImpIndirecto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            lblAplicarImpIndirecto.RootElement.AngleTransform = CType(resources.GetObject("lblAplicarImpIndirecto.RootElement.AngleTransform"), Single)
            lblAplicarImpIndirecto.RootElement.FlipText = CType(resources.GetObject("lblAplicarImpIndirecto.RootElement.FlipText"), Boolean)
            lblAplicarImpIndirecto.RootElement.KeyTip = resources.GetString("lblAplicarImpIndirecto.RootElement.KeyTip")
            lblAplicarImpIndirecto.RootElement.Margin = CType(resources.GetObject("lblAplicarImpIndirecto.RootElement.Margin"), System.Windows.Forms.Padding)
            lblAplicarImpIndirecto.RootElement.Text = resources.GetString("lblAplicarImpIndirecto.RootElement.Text")
            lblAplicarImpIndirecto.RootElement.TextOrientation = CType(resources.GetObject("lblAplicarImpIndirecto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            lblAplicarImpIndirecto.RootElement.ToolTipText = resources.GetString("lblAplicarImpIndirecto.RootElement.ToolTipText")
            '
            'grpbContacto
            '
            resources.ApplyResources(Me.grpbContacto, "grpbContacto")
            Me.grpbContacto.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.grpbContacto.Controls.Add(Me.txtEmail)
            Me.grpbContacto.Controls.Add(Me.txtFax)
            Me.grpbContacto.Controls.Add(Me.txtMovil)
            Me.grpbContacto.Controls.Add(Me.txtTelefono)
            Me.grpbContacto.Controls.Add(RadLabel11)
            Me.grpbContacto.Controls.Add(RadLabel10)
            Me.grpbContacto.Controls.Add(RadLabel9)
            Me.grpbContacto.Controls.Add(RadLabel8)
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
            Me.grpbContacto.RootElement.KeyTip = resources.GetString("grpbContacto.RootElement.KeyTip")
            Me.grpbContacto.RootElement.Margin = CType(resources.GetObject("grpbContacto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.grpbContacto.RootElement.Text = resources.GetString("grpbContacto.RootElement.Text")
            Me.grpbContacto.RootElement.TextOrientation = CType(resources.GetObject("grpbContacto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.grpbContacto.RootElement.ToolTipText = resources.GetString("grpbContacto.RootElement.ToolTipText")
            Me.grpbContacto.TabStop = False
            CType(Me.grpbContacto.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far
            CType(Me.grpbContacto.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).Padding = CType(resources.GetObject("resource.Padding"), System.Windows.Forms.Padding)
            CType(Me.grpbContacto.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            CType(Me.grpbContacto.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            '
            'txtEmail
            '
            resources.ApplyResources(Me.txtEmail, "txtEmail")
            Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBindingSource, "Email", True))
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
            Me.txtEmail.RootElement.KeyTip = resources.GetString("txtEmail.RootElement.KeyTip")
            Me.txtEmail.RootElement.Margin = CType(resources.GetObject("txtEmail.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtEmail.RootElement.Text = resources.GetString("txtEmail.RootElement.Text")
            Me.txtEmail.RootElement.TextOrientation = CType(resources.GetObject("txtEmail.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtEmail.RootElement.ToolTipText = resources.GetString("txtEmail.RootElement.ToolTipText")
            Me.txtEmail.TabStop = False
            CType(Me.txtEmail.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text")
            CType(Me.txtEmail.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtEmail.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'ClientesBindingSource
            '
            Me.ClientesBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Clientes)
            '
            'txtFax
            '
            resources.ApplyResources(Me.txtFax, "txtFax")
            Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBindingSource, "Fax", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
            Me.txtFax.RootElement.KeyTip = resources.GetString("txtFax.RootElement.KeyTip")
            Me.txtFax.RootElement.Margin = CType(resources.GetObject("txtFax.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtFax.RootElement.Text = resources.GetString("txtFax.RootElement.Text")
            Me.txtFax.RootElement.TextOrientation = CType(resources.GetObject("txtFax.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtFax.RootElement.ToolTipText = resources.GetString("txtFax.RootElement.ToolTipText")
            Me.txtFax.TabStop = False
            CType(Me.txtFax.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text1")
            CType(Me.txtFax.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtFax.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtMovil
            '
            resources.ApplyResources(Me.txtMovil, "txtMovil")
            Me.txtMovil.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBindingSource, "Movil", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
            Me.txtMovil.RootElement.KeyTip = resources.GetString("txtMovil.RootElement.KeyTip")
            Me.txtMovil.RootElement.Margin = CType(resources.GetObject("txtMovil.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtMovil.RootElement.Text = resources.GetString("txtMovil.RootElement.Text")
            Me.txtMovil.RootElement.TextOrientation = CType(resources.GetObject("txtMovil.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtMovil.RootElement.ToolTipText = resources.GetString("txtMovil.RootElement.ToolTipText")
            Me.txtMovil.TabStop = False
            CType(Me.txtMovil.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text2")
            CType(Me.txtMovil.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtMovil.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtTelefono
            '
            resources.ApplyResources(Me.txtTelefono, "txtTelefono")
            Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBindingSource, "Telefono", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
            Me.txtTelefono.RootElement.KeyTip = resources.GetString("txtTelefono.RootElement.KeyTip")
            Me.txtTelefono.RootElement.Margin = CType(resources.GetObject("txtTelefono.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtTelefono.RootElement.Text = resources.GetString("txtTelefono.RootElement.Text")
            Me.txtTelefono.RootElement.TextOrientation = CType(resources.GetObject("txtTelefono.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtTelefono.RootElement.ToolTipText = resources.GetString("txtTelefono.RootElement.ToolTipText")
            Me.txtTelefono.TabStop = False
            CType(Me.txtTelefono.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text3")
            CType(Me.txtTelefono.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtTelefono.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'grpbDireccion
            '
            resources.ApplyResources(Me.grpbDireccion, "grpbDireccion")
            Me.grpbDireccion.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.grpbDireccion.Controls.Add(Me.txtCodigoPostal)
            Me.grpbDireccion.Controls.Add(Me.ddlLocalidad)
            Me.grpbDireccion.Controls.Add(Me.ddlProvincia)
            Me.grpbDireccion.Controls.Add(RadLabel17)
            Me.grpbDireccion.Controls.Add(RadLabel12)
            Me.grpbDireccion.Controls.Add(RadLabel13)
            Me.grpbDireccion.Controls.Add(Me.txtPais)
            Me.grpbDireccion.Controls.Add(RadLabel14)
            Me.grpbDireccion.Controls.Add(Me.txtDireccion)
            Me.grpbDireccion.Controls.Add(RadLabel15)
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
            Me.grpbDireccion.RootElement.KeyTip = resources.GetString("grpbDireccion.RootElement.KeyTip")
            Me.grpbDireccion.RootElement.Margin = CType(resources.GetObject("grpbDireccion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.grpbDireccion.RootElement.Text = resources.GetString("grpbDireccion.RootElement.Text")
            Me.grpbDireccion.RootElement.TextOrientation = CType(resources.GetObject("grpbDireccion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.grpbDireccion.RootElement.ToolTipText = resources.GetString("grpbDireccion.RootElement.ToolTipText")
            Me.grpbDireccion.TabStop = False
            CType(Me.grpbDireccion.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far
            CType(Me.grpbDireccion.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).Padding = CType(resources.GetObject("resource.Padding1"), System.Windows.Forms.Padding)
            CType(Me.grpbDireccion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
            CType(Me.grpbDireccion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            '
            'txtCodigoPostal
            '
            resources.ApplyResources(Me.txtCodigoPostal, "txtCodigoPostal")
            Me.txtCodigoPostal.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBindingSource, "CodigoPostal", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
            Me.txtCodigoPostal.RootElement.KeyTip = resources.GetString("txtCodigoPostal.RootElement.KeyTip")
            Me.txtCodigoPostal.RootElement.Margin = CType(resources.GetObject("txtCodigoPostal.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtCodigoPostal.RootElement.Text = resources.GetString("txtCodigoPostal.RootElement.Text")
            Me.txtCodigoPostal.RootElement.TextOrientation = CType(resources.GetObject("txtCodigoPostal.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtCodigoPostal.RootElement.ToolTipText = resources.GetString("txtCodigoPostal.RootElement.ToolTipText")
            Me.txtCodigoPostal.TabStop = False
            Me.txtCodigoPostal.Tag = ""
            CType(Me.txtCodigoPostal.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text4")
            CType(Me.txtCodigoPostal.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtCodigoPostal.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'ddlLocalidad
            '
            resources.ApplyResources(Me.ddlLocalidad, "ddlLocalidad")
            Me.ddlLocalidad.AllowShowFocusCues = False
            Me.ddlLocalidad.AutoCompleteDisplayMember = "Municipio"
            Me.ddlLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ddlLocalidad.AutoCompleteValueMember = "CodMunicipio"
            Me.ddlLocalidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Localidad", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlLocalidad.DataSource = Me.MunicipiosEspañolasBindingSource
            Me.ddlLocalidad.DisplayMember = "Municipio"
            Me.ddlLocalidad.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlLocalidad.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
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
            Me.ddlLocalidad.RootElement.KeyTip = resources.GetString("ddlLocalidad.RootElement.KeyTip")
            Me.ddlLocalidad.RootElement.Margin = CType(resources.GetObject("ddlLocalidad.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlLocalidad.RootElement.Text = resources.GetString("ddlLocalidad.RootElement.Text")
            Me.ddlLocalidad.RootElement.TextOrientation = CType(resources.GetObject("ddlLocalidad.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ddlLocalidad.RootElement.ToolTipText = resources.GetString("ddlLocalidad.RootElement.ToolTipText")
            Me.ddlLocalidad.SelectNextOnDoubleClick = True
            Me.ddlLocalidad.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlLocalidad.ValueMember = "CodMunicipio"
            CType(Me.ddlLocalidad.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
            CType(Me.ddlLocalidad.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadDropDownListElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            '
            'MunicipiosEspañolasBindingSource
            '
            Me.MunicipiosEspañolasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.MunicipiosEspañolas)
            Me.MunicipiosEspañolasBindingSource.Sort = "Municipio"
            '
            'ddlProvincia
            '
            resources.ApplyResources(Me.ddlProvincia, "ddlProvincia")
            Me.ddlProvincia.AllowShowFocusCues = False
            Me.ddlProvincia.AutoCompleteDisplayMember = "Provincia"
            Me.ddlProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ddlProvincia.AutoCompleteValueMember = "CodProvincia"
            Me.ddlProvincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Provincia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlProvincia.DataSource = Me.ProvinciasEspañolasBindingSource
            Me.ddlProvincia.DisplayMember = "Provincia"
            Me.ddlProvincia.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlProvincia.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
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
            Me.ddlProvincia.RootElement.KeyTip = resources.GetString("ddlProvincia.RootElement.KeyTip")
            Me.ddlProvincia.RootElement.Margin = CType(resources.GetObject("ddlProvincia.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlProvincia.RootElement.Text = resources.GetString("ddlProvincia.RootElement.Text")
            Me.ddlProvincia.RootElement.TextOrientation = CType(resources.GetObject("ddlProvincia.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ddlProvincia.RootElement.ToolTipText = resources.GetString("ddlProvincia.RootElement.ToolTipText")
            Me.ddlProvincia.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlProvincia.ValueMember = "CodProvincia"
            CType(Me.ddlProvincia.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
            '
            'ProvinciasEspañolasBindingSource
            '
            Me.ProvinciasEspañolasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.ProvinciasEspañolas)
            Me.ProvinciasEspañolasBindingSource.Sort = "Provincia"
            '
            'txtPais
            '
            resources.ApplyResources(Me.txtPais, "txtPais")
            Me.txtPais.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("txtPais.AutoCompleteCustomSource"), resources.GetString("txtPais.AutoCompleteCustomSource1"), resources.GetString("txtPais.AutoCompleteCustomSource2"), resources.GetString("txtPais.AutoCompleteCustomSource3"), resources.GetString("txtPais.AutoCompleteCustomSource4"), resources.GetString("txtPais.AutoCompleteCustomSource5"), resources.GetString("txtPais.AutoCompleteCustomSource6"), resources.GetString("txtPais.AutoCompleteCustomSource7")})
            Me.txtPais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
            Me.txtPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
            Me.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtPais.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Pais", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.txtPais.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtPais.Name = "txtPais"
            '
            '
            '
            Me.txtPais.RootElement.AccessibleDescription = resources.GetString("txtPais.RootElement.AccessibleDescription")
            Me.txtPais.RootElement.AccessibleName = resources.GetString("txtPais.RootElement.AccessibleName")
            Me.txtPais.RootElement.Alignment = CType(resources.GetObject("txtPais.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtPais.RootElement.AngleTransform = CType(resources.GetObject("txtPais.RootElement.AngleTransform"), Single)
            Me.txtPais.RootElement.ApplyShapeToControl = False
            Me.txtPais.RootElement.FlipText = CType(resources.GetObject("txtPais.RootElement.FlipText"), Boolean)
            Me.txtPais.RootElement.KeyTip = resources.GetString("txtPais.RootElement.KeyTip")
            Me.txtPais.RootElement.Margin = CType(resources.GetObject("txtPais.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtPais.RootElement.Text = resources.GetString("txtPais.RootElement.Text")
            Me.txtPais.RootElement.TextOrientation = CType(resources.GetObject("txtPais.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtPais.RootElement.ToolTipText = resources.GetString("txtPais.RootElement.ToolTipText")
            Me.txtPais.TabStop = False
            Me.txtPais.Tag = ""
            CType(Me.txtPais.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text5")
            CType(Me.txtPais.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtPais.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtPais.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtPais.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtPais.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtDireccion
            '
            resources.ApplyResources(Me.txtDireccion, "txtDireccion")
            Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Direccion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
            Me.txtDireccion.RootElement.KeyTip = resources.GetString("txtDireccion.RootElement.KeyTip")
            Me.txtDireccion.RootElement.Margin = CType(resources.GetObject("txtDireccion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtDireccion.RootElement.Text = resources.GetString("txtDireccion.RootElement.Text")
            Me.txtDireccion.RootElement.TextOrientation = CType(resources.GetObject("txtDireccion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtDireccion.RootElement.ToolTipText = resources.GetString("txtDireccion.RootElement.ToolTipText")
            Me.txtDireccion.TabStop = False
            Me.txtDireccion.Tag = ""
            CType(Me.txtDireccion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text6")
            CType(Me.txtDireccion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtDireccion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtDireccion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtDireccion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtDireccion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
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
            Me.btnCancelar.RootElement.Text = resources.GetString("btnCancelar.RootElement.Text")
            Me.btnCancelar.RootElement.TextOrientation = CType(resources.GetObject("btnCancelar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.btnCancelar.RootElement.ToolTipText = resources.GetString("btnCancelar.RootElement.ToolTipText")
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.cancel
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text7")
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
            Me.btnAceptar.RootElement.Text = resources.GetString("btnAceptar.RootElement.Text")
            Me.btnAceptar.RootElement.TextOrientation = CType(resources.GetObject("btnAceptar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.btnAceptar.RootElement.ToolTipText = resources.GetString("btnAceptar.RootElement.ToolTipText")
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.accept
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text8")
            CType(Me.btnAceptar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
            '
            'ddlTipoIdentificacion
            '
            resources.ApplyResources(Me.ddlTipoIdentificacion, "ddlTipoIdentificacion")
            Me.ddlTipoIdentificacion.AllowShowFocusCues = False
            Me.ddlTipoIdentificacion.AutoCompleteDisplayMember = "TipoIdentificacion"
            Me.ddlTipoIdentificacion.AutoCompleteValueMember = "idTipo"
            Me.ddlTipoIdentificacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesBindingSource, "idTipo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlTipoIdentificacion.DataSource = Me.TiposIdentificacionBindingSource
            Me.ddlTipoIdentificacion.DisplayMember = "TipoIdentificacion"
            Me.ddlTipoIdentificacion.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlTipoIdentificacion.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
            Me.ddlTipoIdentificacion.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.ddlTipoIdentificacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlTipoIdentificacion.Name = "ddlTipoIdentificacion"
            '
            '
            '
            Me.ddlTipoIdentificacion.RootElement.AccessibleDescription = resources.GetString("ddlTipoIdentificacion.RootElement.AccessibleDescription")
            Me.ddlTipoIdentificacion.RootElement.AccessibleName = resources.GetString("ddlTipoIdentificacion.RootElement.AccessibleName")
            Me.ddlTipoIdentificacion.RootElement.Alignment = CType(resources.GetObject("ddlTipoIdentificacion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlTipoIdentificacion.RootElement.AngleTransform = CType(resources.GetObject("ddlTipoIdentificacion.RootElement.AngleTransform"), Single)
            Me.ddlTipoIdentificacion.RootElement.FlipText = CType(resources.GetObject("ddlTipoIdentificacion.RootElement.FlipText"), Boolean)
            Me.ddlTipoIdentificacion.RootElement.KeyTip = resources.GetString("ddlTipoIdentificacion.RootElement.KeyTip")
            Me.ddlTipoIdentificacion.RootElement.Margin = CType(resources.GetObject("ddlTipoIdentificacion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlTipoIdentificacion.RootElement.Text = resources.GetString("ddlTipoIdentificacion.RootElement.Text")
            Me.ddlTipoIdentificacion.RootElement.TextOrientation = CType(resources.GetObject("ddlTipoIdentificacion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ddlTipoIdentificacion.RootElement.ToolTipText = resources.GetString("ddlTipoIdentificacion.RootElement.ToolTipText")
            Me.ddlTipoIdentificacion.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlTipoIdentificacion.ValueMember = "idTipo"
            CType(Me.ddlTipoIdentificacion.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            '
            'TiposIdentificacionBindingSource
            '
            Me.TiposIdentificacionBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.TiposIdentificacion)
            '
            'txtNumeroIdentificacion
            '
            resources.ApplyResources(Me.txtNumeroIdentificacion, "txtNumeroIdentificacion")
            Me.txtNumeroIdentificacion.AllowShowFocusCues = True
            Me.txtNumeroIdentificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Identificacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
            Me.txtNumeroIdentificacion.RootElement.KeyTip = resources.GetString("txtNumeroIdentificacion.RootElement.KeyTip")
            Me.txtNumeroIdentificacion.RootElement.Margin = CType(resources.GetObject("txtNumeroIdentificacion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtNumeroIdentificacion.RootElement.Text = resources.GetString("txtNumeroIdentificacion.RootElement.Text")
            Me.txtNumeroIdentificacion.RootElement.TextOrientation = CType(resources.GetObject("txtNumeroIdentificacion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtNumeroIdentificacion.RootElement.ToolTipText = resources.GetString("txtNumeroIdentificacion.RootElement.ToolTipText")
            Me.txtNumeroIdentificacion.TabStop = False
            Me.txtNumeroIdentificacion.Tag = ""
            CType(Me.txtNumeroIdentificacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text9")
            CType(Me.txtNumeroIdentificacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNumeroIdentificacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtNumeroIdentificacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNumeroIdentificacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtNumeroIdentificacion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtNombre
            '
            resources.ApplyResources(Me.txtNombre, "txtNombre")
            Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
            Me.txtNombre.RootElement.KeyTip = resources.GetString("txtNombre.RootElement.KeyTip")
            Me.txtNombre.RootElement.Margin = CType(resources.GetObject("txtNombre.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtNombre.RootElement.Text = resources.GetString("txtNombre.RootElement.Text")
            Me.txtNombre.RootElement.TextOrientation = CType(resources.GetObject("txtNombre.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtNombre.RootElement.ToolTipText = resources.GetString("txtNombre.RootElement.ToolTipText")
            Me.txtNombre.TabStop = False
            Me.txtNombre.Tag = "REQ"
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text10")
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'txtNombreChino
            '
            resources.ApplyResources(Me.txtNombreChino, "txtNombreChino")
            Me.txtNombreChino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "NombreCN", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.txtNombreChino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtNombreChino.Name = "txtNombreChino"
            '
            '
            '
            Me.txtNombreChino.RootElement.AccessibleDescription = resources.GetString("txtNombreChino.RootElement.AccessibleDescription")
            Me.txtNombreChino.RootElement.AccessibleName = resources.GetString("txtNombreChino.RootElement.AccessibleName")
            Me.txtNombreChino.RootElement.Alignment = CType(resources.GetObject("txtNombreChino.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtNombreChino.RootElement.AngleTransform = CType(resources.GetObject("txtNombreChino.RootElement.AngleTransform"), Single)
            Me.txtNombreChino.RootElement.ApplyShapeToControl = False
            Me.txtNombreChino.RootElement.FlipText = CType(resources.GetObject("txtNombreChino.RootElement.FlipText"), Boolean)
            Me.txtNombreChino.RootElement.KeyTip = resources.GetString("txtNombreChino.RootElement.KeyTip")
            Me.txtNombreChino.RootElement.Margin = CType(resources.GetObject("txtNombreChino.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtNombreChino.RootElement.Text = resources.GetString("txtNombreChino.RootElement.Text")
            Me.txtNombreChino.RootElement.TextOrientation = CType(resources.GetObject("txtNombreChino.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtNombreChino.RootElement.ToolTipText = resources.GetString("txtNombreChino.RootElement.ToolTipText")
            Me.txtNombreChino.TabStop = False
            Me.txtNombreChino.Tag = ""
            CType(Me.txtNombreChino.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text11")
            CType(Me.txtNombreChino.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNombreChino.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtNombreChino.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNombreChino.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("KaiTi", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            CType(Me.txtNombreChino.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtNombreContacto
            '
            resources.ApplyResources(Me.txtNombreContacto, "txtNombreContacto")
            Me.txtNombreContacto.AllowShowFocusCues = True
            Me.txtNombreContacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "NombreContacto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.txtNombreContacto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtNombreContacto.Name = "txtNombreContacto"
            '
            '
            '
            Me.txtNombreContacto.RootElement.AccessibleDescription = resources.GetString("txtNombreContacto.RootElement.AccessibleDescription")
            Me.txtNombreContacto.RootElement.AccessibleName = resources.GetString("txtNombreContacto.RootElement.AccessibleName")
            Me.txtNombreContacto.RootElement.Alignment = CType(resources.GetObject("txtNombreContacto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtNombreContacto.RootElement.AngleTransform = CType(resources.GetObject("txtNombreContacto.RootElement.AngleTransform"), Single)
            Me.txtNombreContacto.RootElement.ApplyShapeToControl = False
            Me.txtNombreContacto.RootElement.FlipText = CType(resources.GetObject("txtNombreContacto.RootElement.FlipText"), Boolean)
            Me.txtNombreContacto.RootElement.KeyTip = resources.GetString("txtNombreContacto.RootElement.KeyTip")
            Me.txtNombreContacto.RootElement.Margin = CType(resources.GetObject("txtNombreContacto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtNombreContacto.RootElement.Text = resources.GetString("txtNombreContacto.RootElement.Text")
            Me.txtNombreContacto.RootElement.TextOrientation = CType(resources.GetObject("txtNombreContacto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtNombreContacto.RootElement.ToolTipText = resources.GetString("txtNombreContacto.RootElement.ToolTipText")
            Me.txtNombreContacto.TabStop = False
            Me.txtNombreContacto.Tag = ""
            CType(Me.txtNombreContacto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text12")
            CType(Me.txtNombreContacto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNombreContacto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtNombreContacto.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNombreContacto.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtNombreContacto.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'chkAplicarRE
            '
            resources.ApplyResources(Me.chkAplicarRE, "chkAplicarRE")
            Me.chkAplicarRE.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ClientesBindingSource, "AplicableRE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.chkAplicarRE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.chkAplicarRE.Name = "chkAplicarRE"
            '
            '
            '
            Me.chkAplicarRE.RootElement.AccessibleDescription = resources.GetString("chkAplicarRE.RootElement.AccessibleDescription")
            Me.chkAplicarRE.RootElement.AccessibleName = resources.GetString("chkAplicarRE.RootElement.AccessibleName")
            Me.chkAplicarRE.RootElement.Alignment = CType(resources.GetObject("chkAplicarRE.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.chkAplicarRE.RootElement.AngleTransform = CType(resources.GetObject("chkAplicarRE.RootElement.AngleTransform"), Single)
            Me.chkAplicarRE.RootElement.FlipText = CType(resources.GetObject("chkAplicarRE.RootElement.FlipText"), Boolean)
            Me.chkAplicarRE.RootElement.KeyTip = resources.GetString("chkAplicarRE.RootElement.KeyTip")
            Me.chkAplicarRE.RootElement.Margin = CType(resources.GetObject("chkAplicarRE.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.chkAplicarRE.RootElement.Text = resources.GetString("chkAplicarRE.RootElement.Text")
            Me.chkAplicarRE.RootElement.TextOrientation = CType(resources.GetObject("chkAplicarRE.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.chkAplicarRE.RootElement.ToolTipText = resources.GetString("chkAplicarRE.RootElement.ToolTipText")
            CType(Me.chkAplicarRE.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Text
            CType(Me.chkAplicarRE.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).Text = resources.GetString("resource.Text13")
            CType(Me.chkAplicarRE.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadCheckmark).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            CType(Me.chkAplicarRE.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            CType(Me.chkAplicarRE.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            '
            'spinDescuento
            '
            resources.ApplyResources(Me.spinDescuento, "spinDescuento")
            Me.spinDescuento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBindingSource, "Descuento", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.spinDescuento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.spinDescuento.InterceptArrowKeys = False
            Me.spinDescuento.Name = "spinDescuento"
            '
            '
            '
            Me.spinDescuento.RootElement.AccessibleDescription = resources.GetString("spinDescuento.RootElement.AccessibleDescription")
            Me.spinDescuento.RootElement.AccessibleName = resources.GetString("spinDescuento.RootElement.AccessibleName")
            Me.spinDescuento.RootElement.Alignment = CType(resources.GetObject("spinDescuento.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.spinDescuento.RootElement.AngleTransform = CType(resources.GetObject("spinDescuento.RootElement.AngleTransform"), Single)
            Me.spinDescuento.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.spinDescuento.RootElement.FlipText = CType(resources.GetObject("spinDescuento.RootElement.FlipText"), Boolean)
            Me.spinDescuento.RootElement.KeyTip = resources.GetString("spinDescuento.RootElement.KeyTip")
            Me.spinDescuento.RootElement.Margin = CType(resources.GetObject("spinDescuento.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.spinDescuento.RootElement.Text = resources.GetString("spinDescuento.RootElement.Text")
            Me.spinDescuento.RootElement.TextOrientation = CType(resources.GetObject("spinDescuento.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.spinDescuento.RootElement.ToolTipText = resources.GetString("spinDescuento.RootElement.ToolTipText")
            Me.spinDescuento.TabStop = False
            Me.spinDescuento.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.spinDescuento.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.spinDescuento.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtCodigo
            '
            resources.ApplyResources(Me.txtCodigo, "txtCodigo")
            Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Codigo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtCodigo.Name = "txtCodigo"
            '
            '
            '
            Me.txtCodigo.RootElement.AccessibleDescription = resources.GetString("txtCodigo.RootElement.AccessibleDescription")
            Me.txtCodigo.RootElement.AccessibleName = resources.GetString("txtCodigo.RootElement.AccessibleName")
            Me.txtCodigo.RootElement.Alignment = CType(resources.GetObject("txtCodigo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtCodigo.RootElement.AngleTransform = CType(resources.GetObject("txtCodigo.RootElement.AngleTransform"), Single)
            Me.txtCodigo.RootElement.FlipText = CType(resources.GetObject("txtCodigo.RootElement.FlipText"), Boolean)
            Me.txtCodigo.RootElement.KeyTip = resources.GetString("txtCodigo.RootElement.KeyTip")
            Me.txtCodigo.RootElement.Margin = CType(resources.GetObject("txtCodigo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtCodigo.RootElement.Text = resources.GetString("txtCodigo.RootElement.Text")
            Me.txtCodigo.RootElement.TextOrientation = CType(resources.GetObject("txtCodigo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtCodigo.RootElement.ToolTipText = resources.GetString("txtCodigo.RootElement.ToolTipText")
            Me.txtCodigo.TabStop = False
            Me.txtCodigo.Tag = "REQ"
            CType(Me.txtCodigo.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text14")
            CType(Me.txtCodigo.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtCodigo.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtCodigo.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Shape = Nothing
            CType(Me.txtCodigo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtCodigo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtCodigo.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'timValidar
            '
            '
            'txtObservacion
            '
            Me.txtObservacion.AcceptsReturn = True
            resources.ApplyResources(Me.txtObservacion, "txtObservacion")
            Me.txtObservacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Observacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
            Me.txtObservacion.RootElement.KeyTip = resources.GetString("txtObservacion.RootElement.KeyTip")
            Me.txtObservacion.RootElement.Margin = CType(resources.GetObject("txtObservacion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtObservacion.RootElement.Text = resources.GetString("txtObservacion.RootElement.Text")
            Me.txtObservacion.RootElement.TextOrientation = CType(resources.GetObject("txtObservacion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtObservacion.RootElement.ToolTipText = resources.GetString("txtObservacion.RootElement.ToolTipText")
            Me.txtObservacion.TabStop = False
            Me.txtObservacion.Tag = ""
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text15")
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = True
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'dtpFNacimiento
            '
            resources.ApplyResources(Me.dtpFNacimiento, "dtpFNacimiento")
            Me.dtpFNacimiento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClientesBindingSource, "FNacimiento", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "d"))
            Me.dtpFNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.dtpFNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFNacimiento.Name = "dtpFNacimiento"
            '
            '
            '
            Me.dtpFNacimiento.RootElement.AccessibleDescription = resources.GetString("dtpFNacimiento.RootElement.AccessibleDescription")
            Me.dtpFNacimiento.RootElement.AccessibleName = resources.GetString("dtpFNacimiento.RootElement.AccessibleName")
            Me.dtpFNacimiento.RootElement.Alignment = CType(resources.GetObject("dtpFNacimiento.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.dtpFNacimiento.RootElement.AngleTransform = CType(resources.GetObject("dtpFNacimiento.RootElement.AngleTransform"), Single)
            Me.dtpFNacimiento.RootElement.FlipText = CType(resources.GetObject("dtpFNacimiento.RootElement.FlipText"), Boolean)
            Me.dtpFNacimiento.RootElement.KeyTip = resources.GetString("dtpFNacimiento.RootElement.KeyTip")
            Me.dtpFNacimiento.RootElement.Margin = CType(resources.GetObject("dtpFNacimiento.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.dtpFNacimiento.RootElement.Text = resources.GetString("dtpFNacimiento.RootElement.Text")
            Me.dtpFNacimiento.RootElement.TextOrientation = CType(resources.GetObject("dtpFNacimiento.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.dtpFNacimiento.RootElement.ToolTipText = resources.GetString("dtpFNacimiento.RootElement.ToolTipText")
            Me.dtpFNacimiento.TabStop = False
            Me.dtpFNacimiento.Value = New Date(CType(0, Long))
            '
            'chkAplicarImpInd
            '
            resources.ApplyResources(Me.chkAplicarImpInd, "chkAplicarImpInd")
            Me.chkAplicarImpInd.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ClientesBindingSource, "AplicableImpIndirecto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.chkAplicarImpInd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.chkAplicarImpInd.Name = "chkAplicarImpInd"
            '
            '
            '
            Me.chkAplicarImpInd.RootElement.AccessibleDescription = resources.GetString("chkAplicarImpInd.RootElement.AccessibleDescription")
            Me.chkAplicarImpInd.RootElement.AccessibleName = resources.GetString("chkAplicarImpInd.RootElement.AccessibleName")
            Me.chkAplicarImpInd.RootElement.Alignment = CType(resources.GetObject("chkAplicarImpInd.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.chkAplicarImpInd.RootElement.AngleTransform = CType(resources.GetObject("chkAplicarImpInd.RootElement.AngleTransform"), Single)
            Me.chkAplicarImpInd.RootElement.FlipText = CType(resources.GetObject("chkAplicarImpInd.RootElement.FlipText"), Boolean)
            Me.chkAplicarImpInd.RootElement.KeyTip = resources.GetString("chkAplicarImpInd.RootElement.KeyTip")
            Me.chkAplicarImpInd.RootElement.Margin = CType(resources.GetObject("chkAplicarImpInd.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.chkAplicarImpInd.RootElement.Text = resources.GetString("chkAplicarImpInd.RootElement.Text")
            Me.chkAplicarImpInd.RootElement.TextOrientation = CType(resources.GetObject("chkAplicarImpInd.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.chkAplicarImpInd.RootElement.ToolTipText = resources.GetString("chkAplicarImpInd.RootElement.ToolTipText")
            CType(Me.chkAplicarImpInd.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Text
            CType(Me.chkAplicarImpInd.GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).Text = resources.GetString("resource.Text16")
            CType(Me.chkAplicarImpInd.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.UI.RadCheckmark).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            CType(Me.chkAplicarImpInd.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            CType(Me.chkAplicarImpInd.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            '
            'frmClienteEdicion
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancelar
            Me.Controls.Add(Me.dtpFNacimiento)
            Me.Controls.Add(Me.txtNombreContacto)
            Me.Controls.Add(RadLabel16)
            Me.Controls.Add(Me.txtNombreChino)
            Me.Controls.Add(RadLabel2)
            Me.Controls.Add(Me.txtObservacion)
            Me.Controls.Add(RadLabel18)
            Me.Controls.Add(Me.chkAplicarImpInd)
            Me.Controls.Add(Me.chkAplicarRE)
            Me.Controls.Add(Me.grpbDireccion)
            Me.Controls.Add(Me.spinDescuento)
            Me.Controls.Add(Me.grpbContacto)
            Me.Controls.Add(Me.txtNumeroIdentificacion)
            Me.Controls.Add(Me.ddlTipoIdentificacion)
            Me.Controls.Add(RadLabel3)
            Me.Controls.Add(RadLabel19)
            Me.Controls.Add(RadLabel5)
            Me.Controls.Add(RadLabel7)
            Me.Controls.Add(Me.lblAplicarImpIndirecto)
            Me.Controls.Add(RadLabel6)
            Me.Controls.Add(Me.txtCodigo)
            Me.Controls.Add(RadLabel4)
            Me.Controls.Add(Me.txtNombre)
            Me.Controls.Add(RadLabel1)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmClienteEdicion"
            Me.Opacity = 0.9R
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmClienteEdicion.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmClienteEdicion.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmClienteEdicion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmClienteEdicion.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmClienteEdicion.RootElement.FlipText"), Boolean)
            Me.RootElement.KeyTip = resources.GetString("frmClienteEdicion.RootElement.KeyTip")
            Me.RootElement.Margin = CType(resources.GetObject("frmClienteEdicion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmClienteEdicion.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmClienteEdicion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RootElement.ToolTipText = resources.GetString("frmClienteEdicion.RootElement.ToolTipText")
            Me.ShowInTaskbar = False
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
            CType(Me.lblAplicarImpIndirecto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grpbContacto, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpbContacto.ResumeLayout(False)
            Me.grpbContacto.PerformLayout()
            CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtFax, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtMovil, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtTelefono, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grpbDireccion, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpbDireccion.ResumeLayout(False)
            Me.grpbDireccion.PerformLayout()
            CType(Me.txtCodigoPostal, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MunicipiosEspañolasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlProvincia, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProvinciasEspañolasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPais, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlTipoIdentificacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TiposIdentificacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNumeroIdentificacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNombreChino, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNombreContacto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAplicarRE, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinDescuento, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkAplicarImpInd, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents ddlTipoIdentificacion As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents TiposIdentificacionBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents txtNumeroIdentificacion As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtCodigoPostal As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents ddlLocalidad As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents MunicipiosEspañolasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ddlProvincia As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents ProvinciasEspañolasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents txtPais As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtDireccion As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtEmail As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents txtFax As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents txtMovil As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents txtTelefono As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents txtNombre As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtNombreChino As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtNombreContacto As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents chkAplicarRE As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents spinDescuento As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents timValidar As System.Windows.Forms.Timer
        Friend WithEvents txtCodigo As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents grpbContacto As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents grpbDireccion As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents txtObservacion As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents dtpFNacimiento As Telerik.WinControls.UI.RadDateTimePicker
        Friend WithEvents chkAplicarImpInd As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents lblAplicarImpIndirecto As Telerik.WinControls.UI.RadLabel
    End Class

End Namespace

