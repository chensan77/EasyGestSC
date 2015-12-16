Namespace Presentacion.Componente

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class WaitingPanel
    Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WaitingPanel))
            Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.lblTitulo = New Telerik.WinControls.UI.RadLabel()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.RoundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
            CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RadPanel2.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'RadPanel2
            '
            Me.RadPanel2.BackColor = System.Drawing.Color.Transparent
            Me.RadPanel2.Controls.Add(Me.TableLayoutPanel1)
            resources.ApplyResources(Me.RadPanel2, "RadPanel2")
            Me.RadPanel2.Name = "RadPanel2"
            '
            '
            '
            Me.RadPanel2.RootElement.AccessibleDescription = resources.GetString("RadPanel2.RootElement.AccessibleDescription")
            Me.RadPanel2.RootElement.AccessibleName = resources.GetString("RadPanel2.RootElement.AccessibleName")
            Me.RadPanel2.RootElement.Alignment = CType(resources.GetObject("RadPanel2.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RadPanel2.RootElement.AngleTransform = CType(resources.GetObject("RadPanel2.RootElement.AngleTransform"), Single)
            Me.RadPanel2.RootElement.FlipText = CType(resources.GetObject("RadPanel2.RootElement.FlipText"), Boolean)
            Me.RadPanel2.RootElement.Margin = CType(resources.GetObject("RadPanel2.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RadPanel2.RootElement.Padding = CType(resources.GetObject("RadPanel2.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RadPanel2.RootElement.Text = resources.GetString("RadPanel2.RootElement.Text")
            Me.RadPanel2.RootElement.TextOrientation = CType(resources.GetObject("RadPanel2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RadPanel2.UseWaitCursor = True
            CType(Me.RadPanel2.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = resources.GetString("resource.Text")
            CType(Me.RadPanel2.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Opacity = 0.5R
            CType(Me.RadPanel2.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Padding = CType(resources.GetObject("resource.Padding"), System.Windows.Forms.Padding)
            CType(Me.RadPanel2.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Alignment = CType(resources.GetObject("resource.Alignment"), System.Drawing.ContentAlignment)
            CType(Me.RadPanel2.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Shape = Me.RoundRectShape1
            CType(Me.RadPanel2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(246, Byte), Integer))
            CType(Me.RadPanel2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(246, Byte), Integer))
            CType(Me.RadPanel2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(248, Byte), Integer))
            CType(Me.RadPanel2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(248, Byte), Integer))
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
            resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
            Me.TableLayoutPanel1.Controls.Add(Me.lblTitulo, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.UseWaitCursor = True
            '
            'lblTitulo
            '
            resources.ApplyResources(Me.lblTitulo, "lblTitulo")
            Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(119, Byte), Integer))
            Me.lblTitulo.Name = "lblTitulo"
            '
            '
            '
            Me.lblTitulo.RootElement.AccessibleDescription = resources.GetString("lblTitulo.RootElement.AccessibleDescription")
            Me.lblTitulo.RootElement.AccessibleName = resources.GetString("lblTitulo.RootElement.AccessibleName")
            Me.lblTitulo.RootElement.Alignment = CType(resources.GetObject("lblTitulo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.lblTitulo.RootElement.AngleTransform = CType(resources.GetObject("lblTitulo.RootElement.AngleTransform"), Single)
            Me.lblTitulo.RootElement.FlipText = CType(resources.GetObject("lblTitulo.RootElement.FlipText"), Boolean)
            Me.lblTitulo.RootElement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(119, Byte), Integer))
            Me.lblTitulo.RootElement.Margin = CType(resources.GetObject("lblTitulo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.lblTitulo.RootElement.Padding = CType(resources.GetObject("lblTitulo.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.lblTitulo.RootElement.Text = resources.GetString("lblTitulo.RootElement.Text")
            Me.lblTitulo.RootElement.TextOrientation = CType(resources.GetObject("lblTitulo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.lblTitulo.UseWaitCursor = True
            '
            'PictureBox1
            '
            resources.ApplyResources(Me.PictureBox1, "PictureBox1")
            Me.PictureBox1.Image = Global.EasyGest.My.Resources.Resources.loading1
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.TabStop = False
            Me.PictureBox1.UseWaitCursor = True
            '
            'WaitingPanel
            '
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.RadPanel2)
            Me.DoubleBuffered = True
            resources.ApplyResources(Me, "$this")
            Me.ForeColor = System.Drawing.Color.White
            Me.Name = "WaitingPanel"
            Me.UseWaitCursor = True
            CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RadPanel2.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
        Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents lblTitulo As Telerik.WinControls.UI.RadLabel
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents RoundRectShape1 As Telerik.WinControls.RoundRectShape

    End Class

End Namespace
