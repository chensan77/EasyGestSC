Imports EasyGest.Presentacion.Formulario.Dialogo
  
Namespace Presentacion.Formulario.Dialogo

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBDConexion
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
            Dim RadLabel4 As Telerik.WinControls.UI.RadLabel
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBDConexion))
            Dim RadLabel3 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel1 As Telerik.WinControls.UI.RadLabel
            Me.txtUsuario = New Telerik.WinControls.UI.RadTextBox()
            Me.txtCatalogo = New Telerik.WinControls.UI.RadTextBox()
            Me.txtServidor = New Telerik.WinControls.UI.RadTextBox()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnProbar = New Telerik.WinControls.UI.RadButton()
            Me.wtbEsperar = New Telerik.WinControls.UI.RadWaitingBar()
            Me.bgwProbar = New System.ComponentModel.BackgroundWorker()
            Me.txtContraseña = New Telerik.WinControls.UI.RadTextBox()
            Me.timValidezFormulario = New System.Windows.Forms.Timer(Me.components)
            RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            RadLabel3 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtServidor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnProbar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.wtbEsperar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'RadLabel4
            '
            RadLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            resources.ApplyResources(RadLabel4, "RadLabel4")
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
            'RadLabel3
            '
            RadLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            resources.ApplyResources(RadLabel3, "RadLabel3")
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
            'RadLabel2
            '
            RadLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            resources.ApplyResources(RadLabel2, "RadLabel2")
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
            'RadLabel1
            '
            RadLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            resources.ApplyResources(RadLabel1, "RadLabel1")
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
            'txtUsuario
            '
            resources.ApplyResources(Me.txtUsuario, "txtUsuario")
            Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtUsuario.Name = "txtUsuario"
            '
            '
            '
            Me.txtUsuario.RootElement.AccessibleDescription = resources.GetString("txtUsuario.RootElement.AccessibleDescription")
            Me.txtUsuario.RootElement.AccessibleName = resources.GetString("txtUsuario.RootElement.AccessibleName")
            Me.txtUsuario.RootElement.Alignment = CType(resources.GetObject("txtUsuario.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtUsuario.RootElement.AngleTransform = CType(resources.GetObject("txtUsuario.RootElement.AngleTransform"), Single)
            Me.txtUsuario.RootElement.ApplyShapeToControl = False
            Me.txtUsuario.RootElement.FlipText = CType(resources.GetObject("txtUsuario.RootElement.FlipText"), Boolean)
            Me.txtUsuario.RootElement.Margin = CType(resources.GetObject("txtUsuario.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtUsuario.RootElement.Padding = CType(resources.GetObject("txtUsuario.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtUsuario.RootElement.Text = resources.GetString("txtUsuario.RootElement.Text")
            Me.txtUsuario.RootElement.TextOrientation = CType(resources.GetObject("txtUsuario.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtUsuario.Tag = ""
            CType(Me.txtUsuario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text")
            CType(Me.txtUsuario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtUsuario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientAngle = 0.0!
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.3!
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.5!
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
            CType(Me.txtUsuario.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'txtCatalogo
            '
            resources.ApplyResources(Me.txtCatalogo, "txtCatalogo")
            Me.txtCatalogo.ForeColor = System.Drawing.Color.Black
            Me.txtCatalogo.Name = "txtCatalogo"
            '
            '
            '
            Me.txtCatalogo.RootElement.AccessibleDescription = resources.GetString("txtCatalogo.RootElement.AccessibleDescription")
            Me.txtCatalogo.RootElement.AccessibleName = resources.GetString("txtCatalogo.RootElement.AccessibleName")
            Me.txtCatalogo.RootElement.Alignment = CType(resources.GetObject("txtCatalogo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtCatalogo.RootElement.AngleTransform = CType(resources.GetObject("txtCatalogo.RootElement.AngleTransform"), Single)
            Me.txtCatalogo.RootElement.ApplyShapeToControl = False
            Me.txtCatalogo.RootElement.FlipText = CType(resources.GetObject("txtCatalogo.RootElement.FlipText"), Boolean)
            Me.txtCatalogo.RootElement.Margin = CType(resources.GetObject("txtCatalogo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtCatalogo.RootElement.Padding = CType(resources.GetObject("txtCatalogo.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtCatalogo.RootElement.Text = resources.GetString("txtCatalogo.RootElement.Text")
            Me.txtCatalogo.RootElement.TextOrientation = CType(resources.GetObject("txtCatalogo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtCatalogo.Tag = ""
            CType(Me.txtCatalogo.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text1")
            CType(Me.txtCatalogo.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtCatalogo.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtCatalogo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtCatalogo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtCatalogo.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'txtServidor
            '
            resources.ApplyResources(Me.txtServidor, "txtServidor")
            Me.txtServidor.ForeColor = System.Drawing.Color.Black
            Me.txtServidor.Name = "txtServidor"
            '
            '
            '
            Me.txtServidor.RootElement.AccessibleDescription = resources.GetString("txtServidor.RootElement.AccessibleDescription")
            Me.txtServidor.RootElement.AccessibleName = resources.GetString("txtServidor.RootElement.AccessibleName")
            Me.txtServidor.RootElement.Alignment = CType(resources.GetObject("txtServidor.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtServidor.RootElement.AngleTransform = CType(resources.GetObject("txtServidor.RootElement.AngleTransform"), Single)
            Me.txtServidor.RootElement.FlipText = CType(resources.GetObject("txtServidor.RootElement.FlipText"), Boolean)
            Me.txtServidor.RootElement.Margin = CType(resources.GetObject("txtServidor.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtServidor.RootElement.Padding = CType(resources.GetObject("txtServidor.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtServidor.RootElement.Text = resources.GetString("txtServidor.RootElement.Text")
            Me.txtServidor.RootElement.TextOrientation = CType(resources.GetObject("txtServidor.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtServidor.Tag = ""
            CType(Me.txtServidor.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text2")
            CType(Me.txtServidor.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtServidor.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtServidor.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtServidor.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtServidor.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
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
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text3")
            CType(Me.btnAceptar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
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
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text4")
            CType(Me.btnCancelar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(10, Byte), Integer))
            '
            'btnProbar
            '
            resources.ApplyResources(Me.btnProbar, "btnProbar")
            Me.btnProbar.Image = Global.EasyGest.My.Resources.Resources.connect
            Me.btnProbar.Name = "btnProbar"
            '
            '
            '
            Me.btnProbar.RootElement.AccessibleDescription = resources.GetString("btnProbar.RootElement.AccessibleDescription")
            Me.btnProbar.RootElement.AccessibleName = resources.GetString("btnProbar.RootElement.AccessibleName")
            Me.btnProbar.RootElement.Alignment = CType(resources.GetObject("btnProbar.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.btnProbar.RootElement.AngleTransform = CType(resources.GetObject("btnProbar.RootElement.AngleTransform"), Single)
            Me.btnProbar.RootElement.FlipText = CType(resources.GetObject("btnProbar.RootElement.FlipText"), Boolean)
            Me.btnProbar.RootElement.Margin = CType(resources.GetObject("btnProbar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnProbar.RootElement.Padding = CType(resources.GetObject("btnProbar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnProbar.RootElement.Text = resources.GetString("btnProbar.RootElement.Text")
            Me.btnProbar.RootElement.TextOrientation = CType(resources.GetObject("btnProbar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'wtbEsperar
            '
            resources.ApplyResources(Me.wtbEsperar, "wtbEsperar")
            Me.wtbEsperar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(119, Byte), Integer))
            Me.wtbEsperar.Name = "wtbEsperar"
            '
            '
            '
            Me.wtbEsperar.RootElement.AccessibleDescription = resources.GetString("wtbEsperar.RootElement.AccessibleDescription")
            Me.wtbEsperar.RootElement.AccessibleName = resources.GetString("wtbEsperar.RootElement.AccessibleName")
            Me.wtbEsperar.RootElement.Alignment = CType(resources.GetObject("wtbEsperar.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.wtbEsperar.RootElement.AngleTransform = CType(resources.GetObject("wtbEsperar.RootElement.AngleTransform"), Single)
            Me.wtbEsperar.RootElement.FlipText = CType(resources.GetObject("wtbEsperar.RootElement.FlipText"), Boolean)
            Me.wtbEsperar.RootElement.Margin = CType(resources.GetObject("wtbEsperar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.wtbEsperar.RootElement.Padding = CType(resources.GetObject("wtbEsperar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.wtbEsperar.RootElement.Text = resources.GetString("wtbEsperar.RootElement.Text")
            Me.wtbEsperar.RootElement.TextOrientation = CType(resources.GetObject("wtbEsperar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.wtbEsperar.ShowText = True
            Me.wtbEsperar.TabStop = False
            Me.wtbEsperar.WaitingIndicatorSize = New System.Drawing.Size(20, 30)
            Me.wtbEsperar.WaitingSpeed = 75
            Me.wtbEsperar.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Throbber
            CType(Me.wtbEsperar.GetChildAt(0), Telerik.WinControls.UI.RadWaitingBarElement).WaitingIndicatorSize = New System.Drawing.Size(20, 30)
            CType(Me.wtbEsperar.GetChildAt(0), Telerik.WinControls.UI.RadWaitingBarElement).WaitingSpeed = 75
            CType(Me.wtbEsperar.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.WaitingBarContentElement).WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Throbber
            CType(Me.wtbEsperar.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.WaitingBarTextElement).Text = resources.GetString("resource.Text5")
            CType(Me.wtbEsperar.GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.WaitingBarTextElement).Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            'bgwProbar
            '
            Me.bgwProbar.WorkerSupportsCancellation = True
            '
            'txtContraseña
            '
            resources.ApplyResources(Me.txtContraseña, "txtContraseña")
            Me.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtContraseña.Name = "txtContraseña"
            Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            '
            '
            '
            Me.txtContraseña.RootElement.AccessibleDescription = resources.GetString("txtContraseña.RootElement.AccessibleDescription")
            Me.txtContraseña.RootElement.AccessibleName = resources.GetString("txtContraseña.RootElement.AccessibleName")
            Me.txtContraseña.RootElement.Alignment = CType(resources.GetObject("txtContraseña.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtContraseña.RootElement.AngleTransform = CType(resources.GetObject("txtContraseña.RootElement.AngleTransform"), Single)
            Me.txtContraseña.RootElement.ApplyShapeToControl = False
            Me.txtContraseña.RootElement.FlipText = CType(resources.GetObject("txtContraseña.RootElement.FlipText"), Boolean)
            Me.txtContraseña.RootElement.Margin = CType(resources.GetObject("txtContraseña.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtContraseña.RootElement.Padding = CType(resources.GetObject("txtContraseña.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtContraseña.RootElement.Text = resources.GetString("txtContraseña.RootElement.Text")
            Me.txtContraseña.RootElement.TextOrientation = CType(resources.GetObject("txtContraseña.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtContraseña.Tag = ""
            CType(Me.txtContraseña.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text6")
            CType(Me.txtContraseña.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtContraseña.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Solid
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientAngle = 0.0!
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.3!
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.5!
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'timValidezFormulario
            '
            Me.timValidezFormulario.Interval = 500
            '
            'frmBDConexion
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancelar
            Me.CausesValidation = False
            Me.Controls.Add(Me.wtbEsperar)
            Me.Controls.Add(Me.btnProbar)
            Me.Controls.Add(RadLabel4)
            Me.Controls.Add(RadLabel3)
            Me.Controls.Add(RadLabel2)
            Me.Controls.Add(Me.txtContraseña)
            Me.Controls.Add(Me.txtUsuario)
            Me.Controls.Add(Me.txtCatalogo)
            Me.Controls.Add(RadLabel1)
            Me.Controls.Add(Me.txtServidor)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmBDConexion"
            Me.Opacity = 0.9R
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmBDConexion.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmBDConexion.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmBDConexion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmBDConexion.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmBDConexion.RootElement.FlipText"), Boolean)
            Me.RootElement.Margin = CType(resources.GetObject("frmBDConexion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmBDConexion.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmBDConexion.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmBDConexion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.ShowInTaskbar = False
            Me.TopMost = True
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtUsuario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtServidor, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnProbar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.wtbEsperar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtContraseña, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtUsuario As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtCatalogo As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtServidor As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnProbar As Telerik.WinControls.UI.RadButton
        Friend WithEvents wtbEsperar As Telerik.WinControls.UI.RadWaitingBar
        Friend WithEvents bgwProbar As System.ComponentModel.BackgroundWorker
        Friend WithEvents txtContraseña As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents timValidezFormulario As System.Windows.Forms.Timer
    End Class

End Namespace

