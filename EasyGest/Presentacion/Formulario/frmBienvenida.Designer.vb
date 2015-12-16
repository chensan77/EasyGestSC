Namespace Presentacion.Formulario

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmBienvenida
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
            Dim TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBienvenida))
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.lblAccion = New Telerik.WinControls.UI.RadLabel()
            Me.lblVersion = New Telerik.WinControls.UI.RadLabel()
            Me.lblDescripcion = New Telerik.WinControls.UI.RadLabel()
            Me.lblTitulo = New Telerik.WinControls.UI.RadLabel()
            Me.EllipseShape1 = New Telerik.WinControls.EllipseShape()
            Me.bgwInicio = New System.ComponentModel.BackgroundWorker()
            TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            TableLayoutPanel1.SuspendLayout()
            Me.Panel1.SuspendLayout()
            CType(Me.lblAccion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblVersion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TableLayoutPanel1
            '
            TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
            resources.ApplyResources(TableLayoutPanel1, "TableLayoutPanel1")
            TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
            TableLayoutPanel1.Controls.Add(Me.lblDescripcion, 0, 1)
            TableLayoutPanel1.Controls.Add(Me.lblTitulo, 0, 0)
            TableLayoutPanel1.Name = "TableLayoutPanel1"
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.lblAccion)
            Me.Panel1.Controls.Add(Me.lblVersion)
            resources.ApplyResources(Me.Panel1, "Panel1")
            Me.Panel1.Name = "Panel1"
            '
            'lblAccion
            '
            resources.ApplyResources(Me.lblAccion, "lblAccion")
            Me.lblAccion.ForeColor = System.Drawing.Color.DarkBlue
            Me.lblAccion.Name = "lblAccion"
            '
            '
            '
            Me.lblAccion.RootElement.AccessibleDescription = resources.GetString("lblAccion.RootElement.AccessibleDescription")
            Me.lblAccion.RootElement.AccessibleName = resources.GetString("lblAccion.RootElement.AccessibleName")
            Me.lblAccion.RootElement.Alignment = CType(resources.GetObject("lblAccion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lblAccion.RootElement.AngleTransform = CType(resources.GetObject("lblAccion.RootElement.AngleTransform"), Single)
            Me.lblAccion.RootElement.FlipText = CType(resources.GetObject("lblAccion.RootElement.FlipText"), Boolean)
            Me.lblAccion.RootElement.Margin = CType(resources.GetObject("lblAccion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lblAccion.RootElement.Text = resources.GetString("lblAccion.RootElement.Text")
            Me.lblAccion.RootElement.TextOrientation = CType(resources.GetObject("lblAccion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'lblVersion
            '
            resources.ApplyResources(Me.lblVersion, "lblVersion")
            Me.lblVersion.ForeColor = System.Drawing.Color.DarkBlue
            Me.lblVersion.Name = "lblVersion"
            '
            '
            '
            Me.lblVersion.RootElement.AccessibleDescription = resources.GetString("lblVersion.RootElement.AccessibleDescription")
            Me.lblVersion.RootElement.AccessibleName = resources.GetString("lblVersion.RootElement.AccessibleName")
            Me.lblVersion.RootElement.Alignment = CType(resources.GetObject("lblVersion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lblVersion.RootElement.AngleTransform = CType(resources.GetObject("lblVersion.RootElement.AngleTransform"), Single)
            Me.lblVersion.RootElement.FlipText = CType(resources.GetObject("lblVersion.RootElement.FlipText"), Boolean)
            Me.lblVersion.RootElement.Margin = CType(resources.GetObject("lblVersion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lblVersion.RootElement.Text = resources.GetString("lblVersion.RootElement.Text")
            Me.lblVersion.RootElement.TextOrientation = CType(resources.GetObject("lblVersion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'lblDescripcion
            '
            resources.ApplyResources(Me.lblDescripcion, "lblDescripcion")
            Me.lblDescripcion.ForeColor = System.Drawing.Color.DarkBlue
            Me.lblDescripcion.Name = "lblDescripcion"
            '
            '
            '
            Me.lblDescripcion.RootElement.AccessibleDescription = resources.GetString("lblDescripcion.RootElement.AccessibleDescription")
            Me.lblDescripcion.RootElement.AccessibleName = resources.GetString("lblDescripcion.RootElement.AccessibleName")
            Me.lblDescripcion.RootElement.Alignment = CType(resources.GetObject("lblDescripcion.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lblDescripcion.RootElement.AngleTransform = CType(resources.GetObject("lblDescripcion.RootElement.AngleTransform"), Single)
            Me.lblDescripcion.RootElement.FlipText = CType(resources.GetObject("lblDescripcion.RootElement.FlipText"), Boolean)
            Me.lblDescripcion.RootElement.Margin = CType(resources.GetObject("lblDescripcion.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lblDescripcion.RootElement.Text = resources.GetString("lblDescripcion.RootElement.Text")
            Me.lblDescripcion.RootElement.TextOrientation = CType(resources.GetObject("lblDescripcion.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'lblTitulo
            '
            resources.ApplyResources(Me.lblTitulo, "lblTitulo")
            Me.lblTitulo.ForeColor = System.Drawing.Color.DarkBlue
            Me.lblTitulo.Name = "lblTitulo"
            '
            '
            '
            Me.lblTitulo.RootElement.AccessibleDescription = resources.GetString("lblTitulo.RootElement.AccessibleDescription")
            Me.lblTitulo.RootElement.AccessibleName = resources.GetString("lblTitulo.RootElement.AccessibleName")
            Me.lblTitulo.RootElement.Alignment = CType(resources.GetObject("lblTitulo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lblTitulo.RootElement.AngleTransform = CType(resources.GetObject("lblTitulo.RootElement.AngleTransform"), Single)
            Me.lblTitulo.RootElement.FlipText = CType(resources.GetObject("lblTitulo.RootElement.FlipText"), Boolean)
            Me.lblTitulo.RootElement.Margin = CType(resources.GetObject("lblTitulo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lblTitulo.RootElement.Text = resources.GetString("lblTitulo.RootElement.Text")
            Me.lblTitulo.RootElement.TextOrientation = CType(resources.GetObject("lblTitulo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            '
            'bgwInicio
            '
            '
            'frmBienvenida
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackgroundImage = Global.EasyGest.My.Resources.Resources.Fondo4
            Me.BorderWidth = 0
            Me.CausesValidation = False
            Me.ControlBox = False
            Me.Controls.Add(TableLayoutPanel1)
            Me.Name = "frmBienvenida"
            Me.Shape = Me.EllipseShape1
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            TableLayoutPanel1.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            CType(Me.lblAccion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblVersion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lblDescripcion As Telerik.WinControls.UI.RadLabel
        Friend WithEvents lblTitulo As Telerik.WinControls.UI.RadLabel
        Friend WithEvents EllipseShape1 As Telerik.WinControls.EllipseShape
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents lblAccion As Telerik.WinControls.UI.RadLabel
        Friend WithEvents lblVersion As Telerik.WinControls.UI.RadLabel
        Friend WithEvents bgwInicio As System.ComponentModel.BackgroundWorker
    End Class

End Namespace

