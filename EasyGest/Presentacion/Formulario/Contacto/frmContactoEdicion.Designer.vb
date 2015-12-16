Namespace Presentacion.Formulario.Contacto

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmContactoEdicion
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContactoEdicion))
            Dim RadLabel4 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel18 As Telerik.WinControls.UI.RadLabel
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.txtContacto = New Telerik.WinControls.UI.RadTextBox()
            Me.ContactosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.timValidar = New System.Windows.Forms.Timer(Me.components)
            Me.txtObservacion = New Telerik.WinControls.UI.RadTextBox()
            Me.lblCliPro = New Telerik.WinControls.UI.RadLabel()
            Me.txtPropietario = New Telerik.WinControls.UI.RadTextBox()
            Me.ddlPropietario = New Telerik.WinControls.UI.RadDropDownList()
            Me.PropietarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ddlFormaContacto = New Telerik.WinControls.UI.RadDropDownList()
            Me.FormasContactoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            RadLabel18 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtContacto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ContactosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblCliPro, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PropietarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlFormaContacto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FormasContactoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
            RadLabel18.RootElement.Padding = CType(resources.GetObject("RadLabel18.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel18.RootElement.Text = resources.GetString("RadLabel18.RootElement.Text")
            RadLabel18.RootElement.TextOrientation = CType(resources.GetObject("RadLabel18.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.btnCancelar.RootElement.Margin = CType(resources.GetObject("btnCancelar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnCancelar.RootElement.Padding = CType(resources.GetObject("btnCancelar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnCancelar.RootElement.Text = resources.GetString("btnCancelar.RootElement.Text")
            Me.btnCancelar.RootElement.TextOrientation = CType(resources.GetObject("btnCancelar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
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
            Me.btnAceptar.RootElement.Margin = CType(resources.GetObject("btnAceptar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnAceptar.RootElement.Padding = CType(resources.GetObject("btnAceptar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnAceptar.RootElement.Text = resources.GetString("btnAceptar.RootElement.Text")
            Me.btnAceptar.RootElement.TextOrientation = CType(resources.GetObject("btnAceptar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.accept
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text1")
            CType(Me.btnAceptar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
            '
            'txtContacto
            '
            Me.txtContacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosBindingSource, "DatoContacto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtContacto, "txtContacto")
            Me.txtContacto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtContacto.Name = "txtContacto"
            '
            '
            '
            Me.txtContacto.RootElement.AccessibleDescription = resources.GetString("txtContacto.RootElement.AccessibleDescription")
            Me.txtContacto.RootElement.AccessibleName = resources.GetString("txtContacto.RootElement.AccessibleName")
            Me.txtContacto.RootElement.Alignment = CType(resources.GetObject("txtContacto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtContacto.RootElement.AngleTransform = CType(resources.GetObject("txtContacto.RootElement.AngleTransform"), Single)
            Me.txtContacto.RootElement.FlipText = CType(resources.GetObject("txtContacto.RootElement.FlipText"), Boolean)
            Me.txtContacto.RootElement.Margin = CType(resources.GetObject("txtContacto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtContacto.RootElement.Padding = CType(resources.GetObject("txtContacto.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtContacto.RootElement.Text = resources.GetString("txtContacto.RootElement.Text")
            Me.txtContacto.RootElement.TextOrientation = CType(resources.GetObject("txtContacto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtContacto.TabStop = False
            Me.txtContacto.Tag = ""
            CType(Me.txtContacto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text2")
            CType(Me.txtContacto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtContacto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtContacto.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtContacto.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtContacto.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'ContactosBindingSource
            '
            Me.ContactosBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Contactos)
            '
            'timValidar
            '
            '
            'txtObservacion
            '
            Me.txtObservacion.AcceptsReturn = True
            resources.ApplyResources(Me.txtObservacion, "txtObservacion")
            Me.txtObservacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactosBindingSource, "Observacion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
            Me.txtObservacion.RootElement.Padding = CType(resources.GetObject("txtObservacion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtObservacion.RootElement.Text = resources.GetString("txtObservacion.RootElement.Text")
            Me.txtObservacion.RootElement.TextOrientation = CType(resources.GetObject("txtObservacion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtObservacion.TabStop = False
            Me.txtObservacion.Tag = ""
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text3")
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = True
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'lblCliPro
            '
            resources.ApplyResources(Me.lblCliPro, "lblCliPro")
            Me.lblCliPro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.lblCliPro.Name = "lblCliPro"
            '
            '
            '
            Me.lblCliPro.RootElement.AccessibleDescription = resources.GetString("lblCliPro.RootElement.AccessibleDescription")
            Me.lblCliPro.RootElement.AccessibleName = resources.GetString("lblCliPro.RootElement.AccessibleName")
            Me.lblCliPro.RootElement.Alignment = CType(resources.GetObject("lblCliPro.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lblCliPro.RootElement.AngleTransform = CType(resources.GetObject("lblCliPro.RootElement.AngleTransform"), Single)
            Me.lblCliPro.RootElement.FlipText = CType(resources.GetObject("lblCliPro.RootElement.FlipText"), Boolean)
            Me.lblCliPro.RootElement.Margin = CType(resources.GetObject("lblCliPro.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lblCliPro.RootElement.Padding = CType(resources.GetObject("lblCliPro.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.lblCliPro.RootElement.Text = resources.GetString("lblCliPro.RootElement.Text")
            Me.lblCliPro.RootElement.TextOrientation = CType(resources.GetObject("lblCliPro.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'txtPropietario
            '
            Me.txtPropietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            resources.ApplyResources(Me.txtPropietario, "txtPropietario")
            Me.txtPropietario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtPropietario.Name = "txtPropietario"
            Me.txtPropietario.ReadOnly = True
            '
            '
            '
            Me.txtPropietario.RootElement.AccessibleDescription = resources.GetString("txtPropietario.RootElement.AccessibleDescription")
            Me.txtPropietario.RootElement.AccessibleName = resources.GetString("txtPropietario.RootElement.AccessibleName")
            Me.txtPropietario.RootElement.Alignment = CType(resources.GetObject("txtPropietario.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtPropietario.RootElement.AngleTransform = CType(resources.GetObject("txtPropietario.RootElement.AngleTransform"), Single)
            Me.txtPropietario.RootElement.FlipText = CType(resources.GetObject("txtPropietario.RootElement.FlipText"), Boolean)
            Me.txtPropietario.RootElement.Margin = CType(resources.GetObject("txtPropietario.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtPropietario.RootElement.Padding = CType(resources.GetObject("txtPropietario.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtPropietario.RootElement.Text = resources.GetString("txtPropietario.RootElement.Text")
            Me.txtPropietario.RootElement.TextOrientation = CType(resources.GetObject("txtPropietario.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtPropietario.TabStop = False
            Me.txtPropietario.Tag = ""
            CType(Me.txtPropietario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text4")
            CType(Me.txtPropietario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtPropietario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtPropietario.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtPropietario.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtPropietario.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'ddlPropietario
            '
            Me.ddlPropietario.AllowShowFocusCues = True
            Me.ddlPropietario.AutoCompleteDisplayMember = "NombreYNombreCN"
            Me.ddlPropietario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ddlPropietario.AutoCompleteValueMember = "idCliente"
            Me.ddlPropietario.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ContactosBindingSource, "idPropietario", True))
            Me.ddlPropietario.DataSource = Me.PropietarioBindingSource
            Me.ddlPropietario.DisplayMember = "NombreYNombreCN"
            Me.ddlPropietario.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlPropietario.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
            Me.ddlPropietario.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            resources.ApplyResources(Me.ddlPropietario, "ddlPropietario")
            Me.ddlPropietario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlPropietario.Name = "ddlPropietario"
            '
            '
            '
            Me.ddlPropietario.RootElement.AccessibleDescription = resources.GetString("ddlPropietario.RootElement.AccessibleDescription")
            Me.ddlPropietario.RootElement.AccessibleName = resources.GetString("ddlPropietario.RootElement.AccessibleName")
            Me.ddlPropietario.RootElement.Alignment = CType(resources.GetObject("ddlPropietario.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlPropietario.RootElement.AngleTransform = CType(resources.GetObject("ddlPropietario.RootElement.AngleTransform"), Single)
            Me.ddlPropietario.RootElement.FlipText = CType(resources.GetObject("ddlPropietario.RootElement.FlipText"), Boolean)
            Me.ddlPropietario.RootElement.Margin = CType(resources.GetObject("ddlPropietario.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlPropietario.RootElement.Padding = CType(resources.GetObject("ddlPropietario.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ddlPropietario.RootElement.Text = resources.GetString("ddlPropietario.RootElement.Text")
            Me.ddlPropietario.RootElement.TextOrientation = CType(resources.GetObject("ddlPropietario.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ddlPropietario.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlPropietario.ValueMember = "idCliente"
            CType(Me.ddlPropietario.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            '
            'PropietarioBindingSource
            '
            Me.PropietarioBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Clientes)
            '
            'ddlFormaContacto
            '
            Me.ddlFormaContacto.AllowShowFocusCues = True
            Me.ddlFormaContacto.AutoCompleteDisplayMember = "FormaContacto"
            Me.ddlFormaContacto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ddlFormaContacto.AutoCompleteValueMember = "idForma"
            Me.ddlFormaContacto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ContactosBindingSource, "idFormaContacto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlFormaContacto.DataSource = Me.FormasContactoBindingSource
            Me.ddlFormaContacto.DisplayMember = "FormaContacto"
            Me.ddlFormaContacto.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlFormaContacto.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
            Me.ddlFormaContacto.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            resources.ApplyResources(Me.ddlFormaContacto, "ddlFormaContacto")
            Me.ddlFormaContacto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlFormaContacto.Name = "ddlFormaContacto"
            '
            '
            '
            Me.ddlFormaContacto.RootElement.AccessibleDescription = resources.GetString("ddlFormaContacto.RootElement.AccessibleDescription")
            Me.ddlFormaContacto.RootElement.AccessibleName = resources.GetString("ddlFormaContacto.RootElement.AccessibleName")
            Me.ddlFormaContacto.RootElement.Alignment = CType(resources.GetObject("ddlFormaContacto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.ddlFormaContacto.RootElement.AngleTransform = CType(resources.GetObject("ddlFormaContacto.RootElement.AngleTransform"), Single)
            Me.ddlFormaContacto.RootElement.FlipText = CType(resources.GetObject("ddlFormaContacto.RootElement.FlipText"), Boolean)
            Me.ddlFormaContacto.RootElement.Margin = CType(resources.GetObject("ddlFormaContacto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.ddlFormaContacto.RootElement.Padding = CType(resources.GetObject("ddlFormaContacto.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.ddlFormaContacto.RootElement.Text = resources.GetString("ddlFormaContacto.RootElement.Text")
            Me.ddlFormaContacto.RootElement.TextOrientation = CType(resources.GetObject("ddlFormaContacto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ddlFormaContacto.ValueMember = "idForma"
            CType(Me.ddlFormaContacto.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            '
            'FormasContactoBindingSource
            '
            Me.FormasContactoBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.FormasContacto)
            '
            'frmContactoEdicion
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancelar
            Me.Controls.Add(Me.ddlFormaContacto)
            Me.Controls.Add(Me.txtObservacion)
            Me.Controls.Add(RadLabel18)
            Me.Controls.Add(Me.ddlPropietario)
            Me.Controls.Add(RadLabel4)
            Me.Controls.Add(Me.txtContacto)
            Me.Controls.Add(Me.lblCliPro)
            Me.Controls.Add(RadLabel1)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.txtPropietario)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmContactoEdicion"
            Me.Opacity = 0.9R
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmContactoEdicion.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmContactoEdicion.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmContactoEdicion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmContactoEdicion.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmContactoEdicion.RootElement.FlipText"), Boolean)
            Me.RootElement.Margin = CType(resources.GetObject("frmContactoEdicion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmContactoEdicion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmContactoEdicion.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmContactoEdicion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ShowInTaskbar = False
            Me.Tag = ""
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtContacto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ContactosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblCliPro, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPropietario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlPropietario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PropietarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlFormaContacto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FormasContactoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents FormasContactoBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ContactosBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents txtContacto As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents timValidar As System.Windows.Forms.Timer
        Friend WithEvents txtObservacion As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents lblCliPro As Telerik.WinControls.UI.RadLabel
        Friend WithEvents PropietarioBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents txtPropietario As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents ddlPropietario As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents ddlFormaContacto As Telerik.WinControls.UI.RadDropDownList
    End Class

End Namespace

