<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarProducto
    Inherits Telerik.WinControls.UI.ShapedForm

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
        Dim RoundRectShapeForm As Telerik.WinControls.RoundRectShape
        Dim RoundRectShapeTitle As Telerik.WinControls.RoundRectShape
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarProducto))
        Me.RadTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
        RoundRectShapeForm = New Telerik.WinControls.RoundRectShape(Me.components)
        RoundRectShapeTitle = New Telerik.WinControls.RoundRectShape(Me.components)
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoundRectShapeForm
        '
        RoundRectShapeForm.Radius = 20
        '
        'RoundRectShapeTitle
        '
        RoundRectShapeTitle.BottomLeftRounded = False
        RoundRectShapeTitle.BottomRightRounded = False
        RoundRectShapeTitle.Radius = 20
        '
        'RadTitleBar1
        '
        resources.ApplyResources(Me.RadTitleBar1, "RadTitleBar1")
        Me.RadTitleBar1.ImageIcon = CType(resources.GetObject("RadTitleBar1.ImageIcon"), System.Drawing.Icon)
        Me.RadTitleBar1.Name = "RadTitleBar1"
        '
        '
        '
        Me.RadTitleBar1.RootElement.ApplyShapeToControl = True
        Me.RadTitleBar1.RootElement.Shape = RoundRectShapeTitle
        Me.RadTitleBar1.TabStop = False
        '
        'FrmBuscarProducto
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RadTitleBar1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscarProducto"
        Me.Opacity = 0.8R
        Me.Shape = RoundRectShapeForm
        Me.TopMost = True
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadTitleBar1 As Telerik.WinControls.UI.RadTitleBar
End Class

