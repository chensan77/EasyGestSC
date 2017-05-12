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
            RadLabel1.RootElement.AccessibleDescription = Nothing
            RadLabel1.RootElement.AccessibleName = Nothing
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
            'RadLabel18
            '
            resources.ApplyResources(RadLabel18, "RadLabel18")
            RadLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel18.Name = "RadLabel18"
            '
            '
            '
            RadLabel18.RootElement.AccessibleDescription = Nothing
            RadLabel18.RootElement.AccessibleName = Nothing
            '
            'RadLabel19
            '
            resources.ApplyResources(RadLabel19, "RadLabel19")
            RadLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel19.Name = "RadLabel19"
            '
            '
            '
            RadLabel19.RootElement.AccessibleDescription = Nothing
            RadLabel19.RootElement.AccessibleName = Nothing
            '
            'lblAplicarImpIndirecto
            '
            resources.ApplyResources(Me.lblAplicarImpIndirecto, "lblAplicarImpIndirecto")
            Me.lblAplicarImpIndirecto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.lblAplicarImpIndirecto.Name = "lblAplicarImpIndirecto"
            '
            '
            '
            Me.lblAplicarImpIndirecto.RootElement.AccessibleDescription = Nothing
            Me.lblAplicarImpIndirecto.RootElement.AccessibleName = Nothing
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
            Me.grpbContacto.RootElement.AccessibleDescription = Nothing
            Me.grpbContacto.RootElement.AccessibleName = Nothing
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
            Me.txtEmail.RootElement.AccessibleDescription = Nothing
            Me.txtEmail.RootElement.AccessibleName = Nothing
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
            Me.txtFax.RootElement.AccessibleDescription = Nothing
            Me.txtFax.RootElement.AccessibleName = Nothing
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
            Me.txtMovil.RootElement.AccessibleDescription = Nothing
            Me.txtMovil.RootElement.AccessibleName = Nothing
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
            Me.txtTelefono.RootElement.AccessibleDescription = Nothing
            Me.txtTelefono.RootElement.AccessibleName = Nothing
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
            Me.grpbDireccion.RootElement.AccessibleDescription = Nothing
            Me.grpbDireccion.RootElement.AccessibleName = Nothing
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
            Me.txtCodigoPostal.RootElement.AccessibleDescription = Nothing
            Me.txtCodigoPostal.RootElement.AccessibleName = Nothing
            Me.txtCodigoPostal.TabStop = False
            Me.txtCodigoPostal.Tag = ""
            CType(Me.txtCodigoPostal.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text4")
            CType(Me.txtCodigoPostal.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtCodigoPostal.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'ddlLocalidad
            '
            resources.ApplyResources(Me.ddlLocalidad, "ddlLocalidad")
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
            Me.ddlLocalidad.RootElement.AccessibleDescription = Nothing
            Me.ddlLocalidad.RootElement.AccessibleName = Nothing
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
            Me.ddlProvincia.RootElement.AccessibleDescription = Nothing
            Me.ddlProvincia.RootElement.AccessibleName = Nothing
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
            Me.txtPais.RootElement.AccessibleDescription = Nothing
            Me.txtPais.RootElement.AccessibleName = Nothing
            Me.txtPais.RootElement.ApplyShapeToControl = False
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
            Me.txtDireccion.RootElement.AccessibleDescription = Nothing
            Me.txtDireccion.RootElement.AccessibleName = Nothing
            Me.txtDireccion.RootElement.ApplyShapeToControl = False
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
            Me.btnCancelar.RootElement.AccessibleDescription = Nothing
            Me.btnCancelar.RootElement.AccessibleName = Nothing
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
            Me.btnAceptar.RootElement.AccessibleDescription = Nothing
            Me.btnAceptar.RootElement.AccessibleName = Nothing
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.accept
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text8")
            CType(Me.btnAceptar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
            '
            'ddlTipoIdentificacion
            '
            resources.ApplyResources(Me.ddlTipoIdentificacion, "ddlTipoIdentificacion")
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
            Me.ddlTipoIdentificacion.RootElement.AccessibleDescription = Nothing
            Me.ddlTipoIdentificacion.RootElement.AccessibleName = Nothing
            Me.ddlTipoIdentificacion.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlTipoIdentificacion.ValueMember = "TipoID"
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
            Me.txtNumeroIdentificacion.RootElement.AccessibleDescription = Nothing
            Me.txtNumeroIdentificacion.RootElement.AccessibleName = Nothing
            Me.txtNumeroIdentificacion.RootElement.ApplyShapeToControl = False
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
            Me.txtNombre.RootElement.AccessibleDescription = Nothing
            Me.txtNombre.RootElement.AccessibleName = Nothing
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
            Me.txtNombreChino.RootElement.AccessibleDescription = Nothing
            Me.txtNombreChino.RootElement.AccessibleName = Nothing
            Me.txtNombreChino.RootElement.ApplyShapeToControl = False
            Me.txtNombreChino.TabStop = False
            Me.txtNombreChino.Tag = ""
            CType(Me.txtNombreChino.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text11")
            CType(Me.txtNombreChino.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNombreChino.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtNombreChino.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNombreChino.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("楷体", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
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
            Me.txtNombreContacto.RootElement.AccessibleDescription = Nothing
            Me.txtNombreContacto.RootElement.AccessibleName = Nothing
            Me.txtNombreContacto.RootElement.ApplyShapeToControl = False
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
            Me.chkAplicarRE.RootElement.AccessibleDescription = Nothing
            Me.chkAplicarRE.RootElement.AccessibleName = Nothing
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
            Me.spinDescuento.RootElement.AccessibleDescription = Nothing
            Me.spinDescuento.RootElement.AccessibleName = Nothing
            Me.spinDescuento.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
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
            Me.txtCodigo.RootElement.AccessibleDescription = Nothing
            Me.txtCodigo.RootElement.AccessibleName = Nothing
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
            Me.txtObservacion.RootElement.AccessibleDescription = Nothing
            Me.txtObservacion.RootElement.AccessibleName = Nothing
            Me.txtObservacion.RootElement.ApplyShapeToControl = False
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
            Me.dtpFNacimiento.RootElement.AccessibleDescription = Nothing
            Me.dtpFNacimiento.RootElement.AccessibleName = Nothing
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
            Me.chkAplicarImpInd.RootElement.AccessibleDescription = Nothing
            Me.chkAplicarImpInd.RootElement.AccessibleName = Nothing
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
            Me.RootElement.AccessibleDescription = Nothing
            Me.RootElement.AccessibleName = Nothing
            Me.RootElement.ApplyShapeToControl = True
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

