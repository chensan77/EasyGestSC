Namespace Presentacion.Formulario.Configuracion

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmConfiguracion
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracion))
            Dim CarouselEllipsePath1 As Telerik.WinControls.UI.CarouselEllipsePath = New Telerik.WinControls.UI.CarouselEllipsePath()
            Me.crsConfiguracion = New Telerik.WinControls.UI.RadCarousel()
            Me.ibtneEtiqueta = New Telerik.WinControls.UI.RadImageButtonElement()
            Me.ibtnePuesto = New Telerik.WinControls.UI.RadImageButtonElement()
            Me.ibtneUsuario = New Telerik.WinControls.UI.RadImageButtonElement()
            Me.ibtneProducto = New Telerik.WinControls.UI.RadImageButtonElement()
            Me.ibtneEmpresa = New Telerik.WinControls.UI.RadImageButtonElement()
            Me.ibtneParametro = New Telerik.WinControls.UI.RadImageButtonElement()
            Me.ibtneImpuesto = New Telerik.WinControls.UI.RadImageButtonElement()
            Me.RoundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
            Me.ibtneOferta = New Telerik.WinControls.UI.RadImageButtonElement()
            CType(Me.crsConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'crsConfiguracion
            '
            Me.crsConfiguracion.AutoLoopPauseCondition = Telerik.WinControls.UI.AutoLoopPauseConditions.OnMouseOverItem
            Me.crsConfiguracion.BackColor = System.Drawing.Color.Transparent
            resources.ApplyResources(Me.crsConfiguracion, "crsConfiguracion")
            '
            '
            '
            Me.crsConfiguracion.CarouselElement.AccessibleDescription = resources.GetString("crsConfiguracion.CarouselElement.AccessibleDescription")
            Me.crsConfiguracion.CarouselElement.AccessibleName = resources.GetString("crsConfiguracion.CarouselElement.AccessibleName")
            Me.crsConfiguracion.CarouselElement.Alignment = CType(resources.GetObject("crsConfiguracion.CarouselElement.Alignment"), System.Drawing.ContentAlignment)
            Me.crsConfiguracion.CarouselElement.AngleTransform = CType(resources.GetObject("crsConfiguracion.CarouselElement.AngleTransform"), Single)
            Me.crsConfiguracion.CarouselElement.FlipText = CType(resources.GetObject("crsConfiguracion.CarouselElement.FlipText"), Boolean)
            Me.crsConfiguracion.CarouselElement.Margin = CType(resources.GetObject("crsConfiguracion.CarouselElement.Margin"), System.Windows.Forms.Padding)
            Me.crsConfiguracion.CarouselElement.Padding = CType(resources.GetObject("crsConfiguracion.CarouselElement.Padding"), System.Windows.Forms.Padding)
            Me.crsConfiguracion.CarouselElement.RightToLeft = CType(resources.GetObject("crsConfiguracion.CarouselElement.RightToLeft"), Boolean)
            Me.crsConfiguracion.CarouselElement.Text = resources.GetString("crsConfiguracion.CarouselElement.Text")
            Me.crsConfiguracion.CarouselElement.TextOrientation = CType(resources.GetObject("crsConfiguracion.CarouselElement.TextOrientation"), System.Windows.Forms.Orientation)
            CarouselEllipsePath1.Center = New Telerik.WinControls.UI.Point3D(51.797862001943635R, 50.185185185185183R, 0.0R)
            CarouselEllipsePath1.FinalAngle = -45.0R
            CarouselEllipsePath1.InitialAngle = 0.0R
            CarouselEllipsePath1.U = New Telerik.WinControls.UI.Point3D(3.0750193539885697R, -27.037037037037038R, -50.0R)
            CarouselEllipsePath1.V = New Telerik.WinControls.UI.Point3D(41.210612574327556R, 16.111111111111111R, -60.0R)
            CarouselEllipsePath1.ZScale = 500.0R
            Me.crsConfiguracion.CarouselPath = CarouselEllipsePath1
            Me.crsConfiguracion.EasingType = Telerik.WinControls.RadEasingType.Linear
            Me.crsConfiguracion.EnableAnimationOnFormResize = False
            Me.crsConfiguracion.ItemClickDefaultAction = Telerik.WinControls.UI.CarouselItemClickAction.None
            Me.crsConfiguracion.Items.AddRange(New Telerik.WinControls.RadItem() {Me.ibtneEtiqueta, Me.ibtnePuesto, Me.ibtneUsuario, Me.ibtneProducto, Me.ibtneEmpresa, Me.ibtneParametro, Me.ibtneImpuesto, Me.ibtneOferta})
            Me.crsConfiguracion.Name = "crsConfiguracion"
            Me.crsConfiguracion.OpacityChangeCondition = Telerik.WinControls.UI.OpacityChangeConditions.None
            '
            '
            '
            Me.crsConfiguracion.RootElement.AccessibleDescription = resources.GetString("crsConfiguracion.RootElement.AccessibleDescription")
            Me.crsConfiguracion.RootElement.AccessibleName = resources.GetString("crsConfiguracion.RootElement.AccessibleName")
            Me.crsConfiguracion.RootElement.Alignment = CType(resources.GetObject("crsConfiguracion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.crsConfiguracion.RootElement.AngleTransform = CType(resources.GetObject("crsConfiguracion.RootElement.AngleTransform"), Single)
            Me.crsConfiguracion.RootElement.FlipText = CType(resources.GetObject("crsConfiguracion.RootElement.FlipText"), Boolean)
            Me.crsConfiguracion.RootElement.Margin = CType(resources.GetObject("crsConfiguracion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.crsConfiguracion.RootElement.Text = resources.GetString("crsConfiguracion.RootElement.Text")
            Me.crsConfiguracion.RootElement.TextOrientation = CType(resources.GetObject("crsConfiguracion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.crsConfiguracion.VirtualMode = False
            Me.crsConfiguracion.VisibleItemCount = 7
            CType(Me.crsConfiguracion.GetChildAt(0), Telerik.WinControls.UI.RadCarouselElement).TextOrientation = CType(resources.GetObject("crsConfiguracion.CarouselElement.TextOrientation1"), System.Windows.Forms.Orientation)
            CType(Me.crsConfiguracion.GetChildAt(0), Telerik.WinControls.UI.RadCarouselElement).FlipText = CType(resources.GetObject("crsConfiguracion.CarouselElement.FlipText1"), Boolean)
            CType(Me.crsConfiguracion.GetChildAt(0), Telerik.WinControls.UI.RadCarouselElement).Text = resources.GetString("crsConfiguracion.CarouselElement.Text1")
            CType(Me.crsConfiguracion.GetChildAt(0), Telerik.WinControls.UI.RadCarouselElement).Padding = CType(resources.GetObject("crsConfiguracion.CarouselElement.Padding1"), System.Windows.Forms.Padding)
            CType(Me.crsConfiguracion.GetChildAt(0), Telerik.WinControls.UI.RadCarouselElement).Margin = CType(resources.GetObject("crsConfiguracion.CarouselElement.Margin1"), System.Windows.Forms.Padding)
            CType(Me.crsConfiguracion.GetChildAt(0), Telerik.WinControls.UI.RadCarouselElement).Alignment = CType(resources.GetObject("crsConfiguracion.CarouselElement.Alignment1"), System.Drawing.ContentAlignment)
            CType(Me.crsConfiguracion.GetChildAt(0), Telerik.WinControls.UI.RadCarouselElement).RightToLeft = CType(resources.GetObject("crsConfiguracion.CarouselElement.RightToLeft1"), Boolean)
            CType(Me.crsConfiguracion.GetChildAt(0), Telerik.WinControls.UI.RadCarouselElement).AngleTransform = CType(resources.GetObject("crsConfiguracion.CarouselElement.AngleTransform1"), Single)
            CType(Me.crsConfiguracion.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadRepeatButtonElement).Image = Global.EasyGest.My.Resources.Resources.player_start
            CType(Me.crsConfiguracion.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadRepeatButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            CType(Me.crsConfiguracion.GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RadRepeatButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            CType(Me.crsConfiguracion.GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RadRepeatButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            '
            'ibtneEtiqueta
            '
            resources.ApplyResources(Me.ibtneEtiqueta, "ibtneEtiqueta")
            Me.ibtneEtiqueta.AutoSize = True
            Me.ibtneEtiqueta.BackColor = System.Drawing.Color.Transparent
            Me.ibtneEtiqueta.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
            Me.ibtneEtiqueta.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ibtneEtiqueta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(10, Byte), Integer))
            Me.ibtneEtiqueta.Image = Global.EasyGest.My.Resources.Resources.dock1
            Me.ibtneEtiqueta.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.ibtneEtiqueta.Name = "ibtneEtiqueta"
            Me.ibtneEtiqueta.ShowBorder = False
            Me.ibtneEtiqueta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.ibtneEtiqueta.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'ibtnePuesto
            '
            resources.ApplyResources(Me.ibtnePuesto, "ibtnePuesto")
            Me.ibtnePuesto.AutoSize = True
            Me.ibtnePuesto.BackColor = System.Drawing.Color.Transparent
            Me.ibtnePuesto.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
            Me.ibtnePuesto.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ibtnePuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(10, Byte), Integer))
            Me.ibtnePuesto.Image = Global.EasyGest.My.Resources.Resources.Clipper
            Me.ibtnePuesto.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.ibtnePuesto.Name = "ibtnePuesto"
            Me.ibtnePuesto.ShowBorder = False
            Me.ibtnePuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.ibtnePuesto.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'ibtneUsuario
            '
            resources.ApplyResources(Me.ibtneUsuario, "ibtneUsuario")
            Me.ibtneUsuario.AutoSize = True
            Me.ibtneUsuario.BackColor = System.Drawing.Color.Transparent
            Me.ibtneUsuario.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
            Me.ibtneUsuario.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ibtneUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(10, Byte), Integer))
            Me.ibtneUsuario.Image = Global.EasyGest.My.Resources.Resources.user_group
            Me.ibtneUsuario.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.ibtneUsuario.Name = "ibtneUsuario"
            Me.ibtneUsuario.ShowBorder = False
            Me.ibtneUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.ibtneUsuario.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'ibtneProducto
            '
            resources.ApplyResources(Me.ibtneProducto, "ibtneProducto")
            Me.ibtneProducto.AutoSize = True
            Me.ibtneProducto.BackColor = System.Drawing.Color.Transparent
            Me.ibtneProducto.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
            Me.ibtneProducto.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ibtneProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(10, Byte), Integer))
            Me.ibtneProducto.Image = Global.EasyGest.My.Resources.Resources.ksirtet
            Me.ibtneProducto.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.ibtneProducto.Name = "ibtneProducto"
            Me.ibtneProducto.ShowBorder = False
            Me.ibtneProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.ibtneProducto.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'ibtneEmpresa
            '
            resources.ApplyResources(Me.ibtneEmpresa, "ibtneEmpresa")
            Me.ibtneEmpresa.AutoSize = True
            Me.ibtneEmpresa.BackColor = System.Drawing.Color.Transparent
            Me.ibtneEmpresa.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
            Me.ibtneEmpresa.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ibtneEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(10, Byte), Integer))
            Me.ibtneEmpresa.Image = Global.EasyGest.My.Resources.Resources.kfm_home
            Me.ibtneEmpresa.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.ibtneEmpresa.Name = "ibtneEmpresa"
            Me.ibtneEmpresa.ShowBorder = False
            Me.ibtneEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.ibtneEmpresa.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'ibtneParametro
            '
            resources.ApplyResources(Me.ibtneParametro, "ibtneParametro")
            Me.ibtneParametro.AutoSize = True
            Me.ibtneParametro.BackColor = System.Drawing.Color.Transparent
            Me.ibtneParametro.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
            Me.ibtneParametro.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ibtneParametro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(10, Byte), Integer))
            Me.ibtneParametro.Image = Global.EasyGest.My.Resources.Resources.docs9
            Me.ibtneParametro.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.ibtneParametro.Name = "ibtneParametro"
            Me.ibtneParametro.ShowBorder = False
            Me.ibtneParametro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.ibtneParametro.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'ibtneImpuesto
            '
            resources.ApplyResources(Me.ibtneImpuesto, "ibtneImpuesto")
            Me.ibtneImpuesto.AutoSize = True
            Me.ibtneImpuesto.BackColor = System.Drawing.Color.Transparent
            Me.ibtneImpuesto.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
            Me.ibtneImpuesto.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ibtneImpuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(10, Byte), Integer))
            Me.ibtneImpuesto.Image = Global.EasyGest.My.Resources.Resources.kenolaba
            Me.ibtneImpuesto.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.ibtneImpuesto.Name = "ibtneImpuesto"
            Me.ibtneImpuesto.Shape = Me.RoundRectShape1
            Me.ibtneImpuesto.ShowBorder = False
            Me.ibtneImpuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.ibtneImpuesto.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'ibtneOferta
            '
            resources.ApplyResources(Me.ibtneOferta, "ibtneOferta")
            Me.ibtneOferta.AutoSize = True
            Me.ibtneOferta.BackColor = System.Drawing.Color.Transparent
            Me.ibtneOferta.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
            Me.ibtneOferta.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ibtneOferta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(10, Byte), Integer))
            Me.ibtneOferta.Image = Global.EasyGest.My.Resources.Resources.dock2
            Me.ibtneOferta.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.ibtneOferta.Name = "ibtneOferta"
            Me.ibtneOferta.ShowBorder = False
            Me.ibtneOferta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.ibtneOferta.Visibility = Telerik.WinControls.ElementVisibility.Visible
            '
            'frmConfiguracion
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImage = Global.EasyGest.My.Resources.Resources.fondo
            Me.Controls.Add(Me.crsConfiguracion)
            Me.KeyPreview = True
            Me.Name = "frmConfiguracion"
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmConfiguracion.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmConfiguracion.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmConfiguracion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmConfiguracion.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmConfiguracion.RootElement.FlipText"), Boolean)
            Me.RootElement.Margin = CType(resources.GetObject("frmConfiguracion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmConfiguracion.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmConfiguracion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.crsConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents crsConfiguracion As Telerik.WinControls.UI.RadCarousel
        Friend WithEvents ibtneParametro As Telerik.WinControls.UI.RadImageButtonElement
        Friend WithEvents ibtneEmpresa As Telerik.WinControls.UI.RadImageButtonElement
        Friend WithEvents ibtneProducto As Telerik.WinControls.UI.RadImageButtonElement
        Friend WithEvents ibtneUsuario As Telerik.WinControls.UI.RadImageButtonElement
        Friend WithEvents ibtnePuesto As Telerik.WinControls.UI.RadImageButtonElement
        Friend WithEvents ibtneImpuesto As Telerik.WinControls.UI.RadImageButtonElement
        Friend WithEvents ibtneEtiqueta As Telerik.WinControls.UI.RadImageButtonElement
        Friend WithEvents ibtneOferta As Telerik.WinControls.UI.RadImageButtonElement
        Friend WithEvents RoundRectShape1 As Telerik.WinControls.RoundRectShape
    End Class

End Namespace
