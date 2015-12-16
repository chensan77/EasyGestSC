Namespace Presentacion.Formulario.Cuenta

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmCuentaEdicion
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuentaEdicion))
            Dim RadLabel4 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel18 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel3 As Telerik.WinControls.UI.RadLabel
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.CuentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.txtBanco = New Telerik.WinControls.UI.RadTextBox()
            Me.timValidar = New System.Windows.Forms.Timer(Me.components)
            Me.txtObservacion = New Telerik.WinControls.UI.RadTextBox()
            Me.lblCliPro = New Telerik.WinControls.UI.RadLabel()
            Me.txtPropietario = New Telerik.WinControls.UI.RadTextBox()
            Me.ddlPropietario = New Telerik.WinControls.UI.RadDropDownList()
            Me.PropietarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.txtTitular = New Telerik.WinControls.UI.RadTextBox()
            Me.txtNumeroCuenta = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.txtSwitch = New Telerik.WinControls.UI.RadTextBox()
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            RadLabel18 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            RadLabel3 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtBanco, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblCliPro, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PropietarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtTitular, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNumeroCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
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
            'CuentasBindingSource
            '
            Me.CuentasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.DatosBancario)
            '
            'txtBanco
            '
            Me.txtBanco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "Banco", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtBanco, "txtBanco")
            Me.txtBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtBanco.Name = "txtBanco"
            '
            '
            '
            Me.txtBanco.RootElement.AccessibleDescription = resources.GetString("txtBanco.RootElement.AccessibleDescription")
            Me.txtBanco.RootElement.AccessibleName = resources.GetString("txtBanco.RootElement.AccessibleName")
            Me.txtBanco.RootElement.Alignment = CType(resources.GetObject("txtBanco.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtBanco.RootElement.AngleTransform = CType(resources.GetObject("txtBanco.RootElement.AngleTransform"), Single)
            Me.txtBanco.RootElement.FlipText = CType(resources.GetObject("txtBanco.RootElement.FlipText"), Boolean)
            Me.txtBanco.RootElement.Margin = CType(resources.GetObject("txtBanco.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtBanco.RootElement.Padding = CType(resources.GetObject("txtBanco.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtBanco.RootElement.Text = resources.GetString("txtBanco.RootElement.Text")
            Me.txtBanco.RootElement.TextOrientation = CType(resources.GetObject("txtBanco.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtBanco.TabStop = False
            Me.txtBanco.Tag = ""
            CType(Me.txtBanco.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text2")
            CType(Me.txtBanco.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtBanco.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtBanco.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtBanco.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtBanco.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'timValidar
            '
            '
            'txtObservacion
            '
            Me.txtObservacion.AcceptsReturn = True
            Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtObservacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "IBAN", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtObservacion, "txtObservacion")
            Me.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
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
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = False
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text3")
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtObservacion.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = False
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
            Me.ddlPropietario.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CuentasBindingSource, "idPropietario", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlPropietario.DataSource = Me.PropietarioBindingSource
            Me.ddlPropietario.DisplayMember = "NombreYNombreCN"
            Me.ddlPropietario.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlPropietario.DropDownAnimationEnabled = True
            Me.ddlPropietario.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
            Me.ddlPropietario.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            resources.ApplyResources(Me.ddlPropietario, "ddlPropietario")
            Me.ddlPropietario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlPropietario.MaxDropDownItems = 0
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
            Me.ddlPropietario.ShowImageInEditorArea = True
            Me.ddlPropietario.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlPropietario.ValueMember = "idCliente"
            CType(Me.ddlPropietario.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            '
            'PropietarioBindingSource
            '
            Me.PropietarioBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Clientes)
            '
            'txtTitular
            '
            Me.txtTitular.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "Titular", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtTitular, "txtTitular")
            Me.txtTitular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtTitular.Name = "txtTitular"
            '
            '
            '
            Me.txtTitular.RootElement.AccessibleDescription = resources.GetString("txtTitular.RootElement.AccessibleDescription")
            Me.txtTitular.RootElement.AccessibleName = resources.GetString("txtTitular.RootElement.AccessibleName")
            Me.txtTitular.RootElement.Alignment = CType(resources.GetObject("txtTitular.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtTitular.RootElement.AngleTransform = CType(resources.GetObject("txtTitular.RootElement.AngleTransform"), Single)
            Me.txtTitular.RootElement.FlipText = CType(resources.GetObject("txtTitular.RootElement.FlipText"), Boolean)
            Me.txtTitular.RootElement.Margin = CType(resources.GetObject("txtTitular.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtTitular.RootElement.Padding = CType(resources.GetObject("txtTitular.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtTitular.RootElement.Text = resources.GetString("txtTitular.RootElement.Text")
            Me.txtTitular.RootElement.TextOrientation = CType(resources.GetObject("txtTitular.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtTitular.TabStop = False
            Me.txtTitular.Tag = ""
            CType(Me.txtTitular.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text6")
            CType(Me.txtTitular.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtTitular.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtTitular.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtTitular.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtTitular.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtNumeroCuenta
            '
            resources.ApplyResources(Me.txtNumeroCuenta, "txtNumeroCuenta")
            Me.txtNumeroCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "CCC", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
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
            CType(Me.txtNumeroCuenta.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text7")
            CType(Me.txtNumeroCuenta.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNumeroCuenta.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtNumeroCuenta.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNumeroCuenta.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtNumeroCuenta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'txtSwitch
            '
            Me.txtSwitch.AcceptsReturn = True
            Me.txtSwitch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtSwitch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "Switch", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtSwitch, "txtSwitch")
            Me.txtSwitch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtSwitch.Name = "txtSwitch"
            '
            '
            '
            Me.txtSwitch.RootElement.AccessibleDescription = resources.GetString("txtSwitch.RootElement.AccessibleDescription")
            Me.txtSwitch.RootElement.AccessibleName = resources.GetString("txtSwitch.RootElement.AccessibleName")
            Me.txtSwitch.RootElement.Alignment = CType(resources.GetObject("txtSwitch.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtSwitch.RootElement.AngleTransform = CType(resources.GetObject("txtSwitch.RootElement.AngleTransform"), Single)
            Me.txtSwitch.RootElement.ApplyShapeToControl = False
            Me.txtSwitch.RootElement.FlipText = CType(resources.GetObject("txtSwitch.RootElement.FlipText"), Boolean)
            Me.txtSwitch.RootElement.Margin = CType(resources.GetObject("txtSwitch.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtSwitch.RootElement.Padding = CType(resources.GetObject("txtSwitch.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtSwitch.RootElement.Text = resources.GetString("txtSwitch.RootElement.Text")
            Me.txtSwitch.RootElement.TextOrientation = CType(resources.GetObject("txtSwitch.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtSwitch.TabStop = False
            Me.txtSwitch.Tag = ""
            CType(Me.txtSwitch.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = False
            CType(Me.txtSwitch.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text8")
            CType(Me.txtSwitch.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtSwitch.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtSwitch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtSwitch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = False
            CType(Me.txtSwitch.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtSwitch.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'frmCuentaEdicion
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancelar
            Me.Controls.Add(Me.txtObservacion)
            Me.Controls.Add(Me.txtSwitch)
            Me.Controls.Add(RadLabel3)
            Me.Controls.Add(RadLabel18)
            Me.Controls.Add(Me.ddlPropietario)
            Me.Controls.Add(RadLabel4)
            Me.Controls.Add(Me.txtTitular)
            Me.Controls.Add(Me.txtNumeroCuenta)
            Me.Controls.Add(Me.txtBanco)
            Me.Controls.Add(RadLabel2)
            Me.Controls.Add(Me.lblCliPro)
            Me.Controls.Add(RadLabel1)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.txtPropietario)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmCuentaEdicion"
            Me.Opacity = 0.9R
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmCuentaEdicion.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmCuentaEdicion.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmCuentaEdicion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmCuentaEdicion.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmCuentaEdicion.RootElement.FlipText"), Boolean)
            Me.RootElement.Margin = CType(resources.GetObject("frmCuentaEdicion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmCuentaEdicion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmCuentaEdicion.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmCuentaEdicion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ShowInTaskbar = False
            Me.Tag = ""
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CuentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtBanco, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblCliPro, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPropietario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlPropietario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PropietarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtTitular, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNumeroCuenta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtSwitch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents CuentasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents txtBanco As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents timValidar As System.Windows.Forms.Timer
        Friend WithEvents txtObservacion As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents lblCliPro As Telerik.WinControls.UI.RadLabel
        Friend WithEvents PropietarioBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents txtPropietario As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents ddlPropietario As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents txtTitular As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtNumeroCuenta As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents txtSwitch As Telerik.WinControls.UI.RadTextBox
    End Class

End Namespace

