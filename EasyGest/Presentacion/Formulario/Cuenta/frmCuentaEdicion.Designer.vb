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
            'RadLabel4
            '
            resources.ApplyResources(RadLabel4, "RadLabel4")
            RadLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel4.Name = "RadLabel4"
            '
            'RadLabel18
            '
            resources.ApplyResources(RadLabel18, "RadLabel18")
            RadLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel18.Name = "RadLabel18"
            '
            'RadLabel2
            '
            resources.ApplyResources(RadLabel2, "RadLabel2")
            RadLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel2.Name = "RadLabel2"
            '
            'RadLabel3
            '
            resources.ApplyResources(RadLabel3, "RadLabel3")
            RadLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel3.Name = "RadLabel3"
            '
            'btnCancelar
            '
            resources.ApplyResources(Me.btnCancelar, "btnCancelar")
            Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancelar.Image = Global.EasyGest.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
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
            Me.txtObservacion.RootElement.ApplyShapeToControl = False
            Me.txtObservacion.TabStop = False
            Me.txtObservacion.Tag = ""
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text3")
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtObservacion.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = False
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
            'txtPropietario
            '
            Me.txtPropietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            resources.ApplyResources(Me.txtPropietario, "txtPropietario")
            Me.txtPropietario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtPropietario.Name = "txtPropietario"
            Me.txtPropietario.ReadOnly = True
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
            Me.ddlPropietario.DropDownSizingMode = CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode)
            Me.ddlPropietario.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            resources.ApplyResources(Me.ddlPropietario, "ddlPropietario")
            Me.ddlPropietario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlPropietario.Name = "ddlPropietario"
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
            Me.txtTitular.TabStop = False
            Me.txtTitular.Tag = ""
            CType(Me.txtTitular.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text5")
            CType(Me.txtTitular.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtTitular.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtTitular.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtTitular.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtTitular.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtNumeroCuenta
            '
            Me.txtNumeroCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtNumeroCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentasBindingSource, "CCC", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.txtNumeroCuenta, "txtNumeroCuenta")
            Me.txtNumeroCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtNumeroCuenta.Name = "txtNumeroCuenta"
            Me.txtNumeroCuenta.TabStop = False
            Me.txtNumeroCuenta.Tag = ""
            CType(Me.txtNumeroCuenta.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text6")
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
            Me.txtSwitch.RootElement.ApplyShapeToControl = False
            Me.txtSwitch.TabStop = False
            Me.txtSwitch.Tag = ""
            CType(Me.txtSwitch.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text7")
            CType(Me.txtSwitch.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtSwitch.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtSwitch.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = False
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
            Me.RootElement.ApplyShapeToControl = True
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

