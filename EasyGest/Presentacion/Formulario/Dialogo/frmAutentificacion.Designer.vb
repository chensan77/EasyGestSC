Imports EasyGest.Presentacion.Formulario.Dialogo
  
Namespace Presentacion.Formulario.Dialogo
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmAutentificacion
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutentificacion))
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.pnlLogin = New Telerik.WinControls.UI.RadPanel()
            Me.txtContraseña = New Telerik.WinControls.UI.RadTextBox()
            Me.txtNombre = New Telerik.WinControls.UI.RadTextBox()
            Me.chkComoSuper = New Telerik.WinControls.UI.RadCheckBox()
            Me.timValidezFormulario = New System.Windows.Forms.Timer(Me.components)
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pnlLogin, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlLogin.SuspendLayout()
            CType(Me.txtContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkComoSuper, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.btnAceptar.RootElement.KeyTip = resources.GetString("btnAceptar.RootElement.KeyTip")
            Me.btnAceptar.RootElement.Margin = CType(resources.GetObject("btnAceptar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnAceptar.RootElement.Text = resources.GetString("btnAceptar.RootElement.Text")
            Me.btnAceptar.RootElement.TextOrientation = CType(resources.GetObject("btnAceptar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.btnAceptar.RootElement.ToolTipText = resources.GetString("btnAceptar.RootElement.ToolTipText")
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.accept
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text1")
            CType(Me.btnAceptar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
            '
            'pnlLogin
            '
            resources.ApplyResources(Me.pnlLogin, "pnlLogin")
            Me.pnlLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.pnlLogin.Controls.Add(Me.txtContraseña)
            Me.pnlLogin.Controls.Add(Me.txtNombre)
            Me.pnlLogin.Controls.Add(RadLabel2)
            Me.pnlLogin.Controls.Add(RadLabel1)
            Me.pnlLogin.Controls.Add(Me.chkComoSuper)
            Me.pnlLogin.Controls.Add(Me.btnAceptar)
            Me.pnlLogin.Controls.Add(Me.btnCancelar)
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
            Me.pnlLogin.RootElement.KeyTip = resources.GetString("pnlLogin.RootElement.KeyTip")
            Me.pnlLogin.RootElement.Margin = CType(resources.GetObject("pnlLogin.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.pnlLogin.RootElement.Text = resources.GetString("pnlLogin.RootElement.Text")
            Me.pnlLogin.RootElement.TextOrientation = CType(resources.GetObject("pnlLogin.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.pnlLogin.RootElement.ToolTipText = resources.GetString("pnlLogin.RootElement.ToolTipText")
            Me.pnlLogin.TextAlignment = System.Drawing.ContentAlignment.TopCenter
            CType(Me.pnlLogin.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = resources.GetString("resource.Text4")
            CType(Me.pnlLogin.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
            CType(Me.pnlLogin.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
            CType(Me.pnlLogin.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
            '
            'txtContraseña
            '
            resources.ApplyResources(Me.txtContraseña, "txtContraseña")
            Me.txtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
            Me.txtContraseña.RootElement.FlipText = CType(resources.GetObject("txtContraseña.RootElement.FlipText"), Boolean)
            Me.txtContraseña.RootElement.KeyTip = resources.GetString("txtContraseña.RootElement.KeyTip")
            Me.txtContraseña.RootElement.Margin = CType(resources.GetObject("txtContraseña.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtContraseña.RootElement.Text = resources.GetString("txtContraseña.RootElement.Text")
            Me.txtContraseña.RootElement.TextOrientation = CType(resources.GetObject("txtContraseña.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtContraseña.RootElement.ToolTipText = resources.GetString("txtContraseña.RootElement.ToolTipText")
            Me.txtContraseña.TabStop = False
            Me.txtContraseña.Tag = "REQ"
            CType(Me.txtContraseña.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text2")
            CType(Me.txtContraseña.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtContraseña.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtContraseña.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'txtNombre
            '
            resources.ApplyResources(Me.txtNombre, "txtNombre")
            Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text3")
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNombre.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtNombre.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'chkComoSuper
            '
            resources.ApplyResources(Me.chkComoSuper, "chkComoSuper")
            Me.chkComoSuper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.chkComoSuper.Name = "chkComoSuper"
            '
            '
            '
            Me.chkComoSuper.RootElement.AccessibleDescription = resources.GetString("chkComoSuper.RootElement.AccessibleDescription")
            Me.chkComoSuper.RootElement.AccessibleName = resources.GetString("chkComoSuper.RootElement.AccessibleName")
            Me.chkComoSuper.RootElement.Alignment = CType(resources.GetObject("chkComoSuper.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.chkComoSuper.RootElement.AngleTransform = CType(resources.GetObject("chkComoSuper.RootElement.AngleTransform"), Single)
            Me.chkComoSuper.RootElement.FlipText = CType(resources.GetObject("chkComoSuper.RootElement.FlipText"), Boolean)
            Me.chkComoSuper.RootElement.KeyTip = resources.GetString("chkComoSuper.RootElement.KeyTip")
            Me.chkComoSuper.RootElement.Margin = CType(resources.GetObject("chkComoSuper.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.chkComoSuper.RootElement.Text = resources.GetString("chkComoSuper.RootElement.Text")
            Me.chkComoSuper.RootElement.TextOrientation = CType(resources.GetObject("chkComoSuper.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.chkComoSuper.RootElement.ToolTipText = resources.GetString("chkComoSuper.RootElement.ToolTipText")
            Me.chkComoSuper.TabStop = False
            '
            'timValidezFormulario
            '
            Me.timValidezFormulario.Interval = 500
            '
            'frmAutentificacion
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancelar
            Me.Controls.Add(Me.pnlLogin)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmAutentificacion"
            Me.Opacity = 0.8R
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmAutentificacion.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmAutentificacion.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmAutentificacion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmAutentificacion.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmAutentificacion.RootElement.FlipText"), Boolean)
            Me.RootElement.KeyTip = resources.GetString("frmAutentificacion.RootElement.KeyTip")
            Me.RootElement.Margin = CType(resources.GetObject("frmAutentificacion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmAutentificacion.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmAutentificacion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RootElement.ToolTipText = resources.GetString("frmAutentificacion.RootElement.ToolTipText")
            Me.ShowInTaskbar = False
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pnlLogin, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlLogin.ResumeLayout(False)
            Me.pnlLogin.PerformLayout()
            CType(Me.txtContraseña, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkComoSuper, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents pnlLogin As Telerik.WinControls.UI.RadPanel
        Friend WithEvents chkComoSuper As Telerik.WinControls.UI.RadCheckBox
        Friend WithEvents txtNombre As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtContraseña As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents timValidezFormulario As System.Windows.Forms.Timer
    End Class

End Namespace