Imports EasyGest.Presentacion.Formulario.Dialogo
  
Namespace Presentacion.Formulario.Dialogo
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmApertura
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApertura))
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel3 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel4 As Telerik.WinControls.UI.RadLabel
            Me.lblFechaApertura = New Telerik.WinControls.UI.RadLabel()
            Me.BindingSourceDiario = New System.Windows.Forms.BindingSource(Me.components)
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.pnlLogin = New Telerik.WinControls.UI.RadPanel()
            Me.txtPuesto = New Telerik.WinControls.UI.RadTextBox()
            Me.txtUsuario = New Telerik.WinControls.UI.RadTextBox()
            Me.txtDeposito = New Telerik.WinControls.UI.RadSpinEditor()
            Me.txtIncidencia = New Telerik.WinControls.UI.RadTextBox()
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            RadLabel3 = New Telerik.WinControls.UI.RadLabel()
            RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblFechaApertura, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BindingSourceDiario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlLogin, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlLogin.SuspendLayout()
            CType(Me.txtPuesto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtIncidencia, System.ComponentModel.ISupportInitialize).BeginInit()
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
            'lblFechaApertura
            '
            resources.ApplyResources(Me.lblFechaApertura, "lblFechaApertura")
            Me.lblFechaApertura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceDiario, "Apertura", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "g"))
            Me.lblFechaApertura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.lblFechaApertura.Name = "lblFechaApertura"
            '
            '
            '
            Me.lblFechaApertura.RootElement.AccessibleDescription = resources.GetString("lblFechaApertura.RootElement.AccessibleDescription")
            Me.lblFechaApertura.RootElement.AccessibleName = resources.GetString("lblFechaApertura.RootElement.AccessibleName")
            Me.lblFechaApertura.RootElement.Alignment = CType(resources.GetObject("lblFechaApertura.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lblFechaApertura.RootElement.AngleTransform = CType(resources.GetObject("lblFechaApertura.RootElement.AngleTransform"), Single)
            Me.lblFechaApertura.RootElement.FlipText = CType(resources.GetObject("lblFechaApertura.RootElement.FlipText"), Boolean)
            Me.lblFechaApertura.RootElement.Margin = CType(resources.GetObject("lblFechaApertura.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lblFechaApertura.RootElement.Padding = CType(resources.GetObject("lblFechaApertura.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.lblFechaApertura.RootElement.Text = resources.GetString("lblFechaApertura.RootElement.Text")
            Me.lblFechaApertura.RootElement.TextOrientation = CType(resources.GetObject("lblFechaApertura.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'BindingSourceDiario
            '
            Me.BindingSourceDiario.DataSource = GetType(EasyGestControllers.Data.Entity.Diarios)
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
            'pnlLogin
            '
            Me.pnlLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.pnlLogin.Controls.Add(Me.txtPuesto)
            Me.pnlLogin.Controls.Add(Me.txtUsuario)
            Me.pnlLogin.Controls.Add(Me.txtDeposito)
            Me.pnlLogin.Controls.Add(Me.txtIncidencia)
            Me.pnlLogin.Controls.Add(RadLabel2)
            Me.pnlLogin.Controls.Add(RadLabel4)
            Me.pnlLogin.Controls.Add(Me.lblFechaApertura)
            Me.pnlLogin.Controls.Add(RadLabel3)
            Me.pnlLogin.Controls.Add(RadLabel1)
            Me.pnlLogin.Controls.Add(Me.btnAceptar)
            Me.pnlLogin.Controls.Add(Me.btnCancelar)
            resources.ApplyResources(Me.pnlLogin, "pnlLogin")
            Me.pnlLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.pnlLogin.Name = "pnlLogin"
            '
            '
            '
            Me.pnlLogin.RootElement.AccessibleDescription = resources.GetString("pnlLogin.RootElement.AccessibleDescription")
            Me.pnlLogin.RootElement.AccessibleName = resources.GetString("pnlLogin.RootElement.AccessibleName")
            Me.pnlLogin.RootElement.Alignment = CType(resources.GetObject("pnlLogin.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.pnlLogin.RootElement.AngleTransform = CType(resources.GetObject("pnlLogin.RootElement.AngleTransform"), Single)
            Me.pnlLogin.RootElement.FlipText = CType(resources.GetObject("pnlLogin.RootElement.FlipText"), Boolean)
            Me.pnlLogin.RootElement.Margin = CType(resources.GetObject("pnlLogin.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.pnlLogin.RootElement.Padding = CType(resources.GetObject("pnlLogin.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.pnlLogin.RootElement.Text = resources.GetString("pnlLogin.RootElement.Text")
            Me.pnlLogin.RootElement.TextOrientation = CType(resources.GetObject("pnlLogin.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.pnlLogin.TextAlignment = System.Drawing.ContentAlignment.TopCenter
            CType(Me.pnlLogin.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = resources.GetString("resource.Text5")
            CType(Me.pnlLogin.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
            CType(Me.pnlLogin.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            CType(Me.pnlLogin.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
            '
            'txtPuesto
            '
            Me.txtPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            resources.ApplyResources(Me.txtPuesto, "txtPuesto")
            Me.txtPuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtPuesto.Name = "txtPuesto"
            Me.txtPuesto.ReadOnly = True
            '
            '
            '
            Me.txtPuesto.RootElement.AccessibleDescription = resources.GetString("txtPuesto.RootElement.AccessibleDescription")
            Me.txtPuesto.RootElement.AccessibleName = resources.GetString("txtPuesto.RootElement.AccessibleName")
            Me.txtPuesto.RootElement.Alignment = CType(resources.GetObject("txtPuesto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtPuesto.RootElement.AngleTransform = CType(resources.GetObject("txtPuesto.RootElement.AngleTransform"), Single)
            Me.txtPuesto.RootElement.FlipText = CType(resources.GetObject("txtPuesto.RootElement.FlipText"), Boolean)
            Me.txtPuesto.RootElement.Margin = CType(resources.GetObject("txtPuesto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtPuesto.RootElement.Padding = CType(resources.GetObject("txtPuesto.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtPuesto.RootElement.Text = resources.GetString("txtPuesto.RootElement.Text")
            Me.txtPuesto.RootElement.TextOrientation = CType(resources.GetObject("txtPuesto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtPuesto.TabStop = False
            Me.txtPuesto.Tag = ""
            CType(Me.txtPuesto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text2")
            CType(Me.txtPuesto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtPuesto.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtPuesto.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtPuesto.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtPuesto.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'txtUsuario
            '
            Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            resources.ApplyResources(Me.txtUsuario, "txtUsuario")
            Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtUsuario.Name = "txtUsuario"
            Me.txtUsuario.ReadOnly = True
            '
            '
            '
            Me.txtUsuario.RootElement.AccessibleDescription = resources.GetString("txtUsuario.RootElement.AccessibleDescription")
            Me.txtUsuario.RootElement.AccessibleName = resources.GetString("txtUsuario.RootElement.AccessibleName")
            Me.txtUsuario.RootElement.Alignment = CType(resources.GetObject("txtUsuario.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtUsuario.RootElement.AngleTransform = CType(resources.GetObject("txtUsuario.RootElement.AngleTransform"), Single)
            Me.txtUsuario.RootElement.FlipText = CType(resources.GetObject("txtUsuario.RootElement.FlipText"), Boolean)
            Me.txtUsuario.RootElement.Margin = CType(resources.GetObject("txtUsuario.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtUsuario.RootElement.Padding = CType(resources.GetObject("txtUsuario.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtUsuario.RootElement.Text = resources.GetString("txtUsuario.RootElement.Text")
            Me.txtUsuario.RootElement.TextOrientation = CType(resources.GetObject("txtUsuario.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtUsuario.TabStop = False
            Me.txtUsuario.Tag = ""
            CType(Me.txtUsuario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text3")
            CType(Me.txtUsuario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtUsuario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(232, Byte), Integer))
            '
            'txtDeposito
            '
            Me.txtDeposito.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSourceDiario, "DepositoInicio", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "C2"))
            resources.ApplyResources(Me.txtDeposito, "txtDeposito")
            Me.txtDeposito.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.txtDeposito.Name = "txtDeposito"
            '
            '
            '
            Me.txtDeposito.RootElement.AccessibleDescription = resources.GetString("txtDeposito.RootElement.AccessibleDescription")
            Me.txtDeposito.RootElement.AccessibleName = resources.GetString("txtDeposito.RootElement.AccessibleName")
            Me.txtDeposito.RootElement.Alignment = CType(resources.GetObject("txtDeposito.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtDeposito.RootElement.AngleTransform = CType(resources.GetObject("txtDeposito.RootElement.AngleTransform"), Single)
            Me.txtDeposito.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.txtDeposito.RootElement.FlipText = CType(resources.GetObject("txtDeposito.RootElement.FlipText"), Boolean)
            Me.txtDeposito.RootElement.Margin = CType(resources.GetObject("txtDeposito.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtDeposito.RootElement.Padding = CType(resources.GetObject("txtDeposito.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtDeposito.RootElement.Text = resources.GetString("txtDeposito.RootElement.Text")
            Me.txtDeposito.RootElement.TextOrientation = CType(resources.GetObject("txtDeposito.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtDeposito.ShowUpDownButtons = False
            Me.txtDeposito.TabStop = False
            Me.txtDeposito.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtDeposito.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            '
            'txtIncidencia
            '
            resources.ApplyResources(Me.txtIncidencia, "txtIncidencia")
            Me.txtIncidencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceDiario, "Incidencia", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.txtIncidencia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtIncidencia.Multiline = True
            Me.txtIncidencia.Name = "txtIncidencia"
            '
            '
            '
            Me.txtIncidencia.RootElement.AccessibleDescription = resources.GetString("txtIncidencia.RootElement.AccessibleDescription")
            Me.txtIncidencia.RootElement.AccessibleName = resources.GetString("txtIncidencia.RootElement.AccessibleName")
            Me.txtIncidencia.RootElement.Alignment = CType(resources.GetObject("txtIncidencia.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtIncidencia.RootElement.AngleTransform = CType(resources.GetObject("txtIncidencia.RootElement.AngleTransform"), Single)
            Me.txtIncidencia.RootElement.FlipText = CType(resources.GetObject("txtIncidencia.RootElement.FlipText"), Boolean)
            Me.txtIncidencia.RootElement.Margin = CType(resources.GetObject("txtIncidencia.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtIncidencia.RootElement.Padding = CType(resources.GetObject("txtIncidencia.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtIncidencia.RootElement.Text = resources.GetString("txtIncidencia.RootElement.Text")
            Me.txtIncidencia.RootElement.TextOrientation = CType(resources.GetObject("txtIncidencia.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtIncidencia.Tag = ""
            CType(Me.txtIncidencia.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text4")
            CType(Me.txtIncidencia.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtIncidencia.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtIncidencia.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtIncidencia.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
            CType(Me.txtIncidencia.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtIncidencia.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
            CType(Me.txtIncidencia.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'frmApertura
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancelar
            Me.Controls.Add(Me.pnlLogin)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmApertura"
            Me.Opacity = 0.8R
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmApertura.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmApertura.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmApertura.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmApertura.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmApertura.RootElement.FlipText"), Boolean)
            Me.RootElement.Margin = CType(resources.GetObject("frmApertura.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmApertura.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmApertura.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmApertura.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ShowInTaskbar = False
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblFechaApertura, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BindingSourceDiario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlLogin, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlLogin.ResumeLayout(False)
            Me.pnlLogin.PerformLayout()
            CType(Me.txtPuesto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtDeposito, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtIncidencia, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents pnlLogin As Telerik.WinControls.UI.RadPanel
        Friend WithEvents txtIncidencia As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtDeposito As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents txtPuesto As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtUsuario As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents lblFechaApertura As Telerik.WinControls.UI.RadLabel
        Friend WithEvents BindingSourceDiario As System.Windows.Forms.BindingSource
    End Class

End Namespace