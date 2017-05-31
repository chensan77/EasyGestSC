Namespace Presentacion.Formulario.CompraVenta

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmValeEdicion
        Inherits Telerik.WinControls.UI.RadForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim RadLabel4 As Telerik.WinControls.UI.RadLabel
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmValeEdicion))
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel3 As Telerik.WinControls.UI.RadLabel
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.timValidar = New System.Windows.Forms.Timer(Me.components)
            Me.txtTitular = New Telerik.WinControls.UI.RadTextBox()
            Me.btnBuscarCliente = New Telerik.WinControls.UI.RadButton()
            Me.chkEsPunto = New Telerik.WinControls.UI.RadCheckBox()
            Me.ValesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.spinImporte = New Telerik.WinControls.UI.RadSpinEditor()
            RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            RadLabel3 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtTitular, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnBuscarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chkEsPunto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ValesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinImporte, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'RadLabel4
            '
            resources.ApplyResources(RadLabel4, "RadLabel4")
            RadLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel4.Name = "RadLabel4"
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
            'timValidar
            '
            '
            'txtTitular
            '
            resources.ApplyResources(Me.txtTitular, "txtTitular")
            Me.txtTitular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtTitular.Name = "txtTitular"
            Me.txtTitular.ReadOnly = True
            Me.txtTitular.ShowClearButton = True
            Me.txtTitular.TabStop = False
            Me.txtTitular.Tag = ""
            CType(Me.txtTitular.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text2")
            CType(Me.txtTitular.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtTitular.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtTitular.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtTitular.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtTitular.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'btnBuscarCliente
            '
            Me.btnBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.btnBuscarCliente.Image = Global.EasyGest.My.Resources.Resources.find
            resources.ApplyResources(Me.btnBuscarCliente, "btnBuscarCliente")
            Me.btnBuscarCliente.Name = "btnBuscarCliente"
            '
            'chkEsPunto
            '
            Me.chkEsPunto.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ValesBindingSource, "EsPunto", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            resources.ApplyResources(Me.chkEsPunto, "chkEsPunto")
            Me.chkEsPunto.Name = "chkEsPunto"
            '
            'ValesBindingSource
            '
            Me.ValesBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Vales)
            '
            'spinImporte
            '
            Me.spinImporte.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ValesBindingSource, "Importe", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2"))
            resources.ApplyResources(Me.spinImporte, "spinImporte")
            Me.spinImporte.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
            Me.spinImporte.Maximum = New Decimal(New Integer() {9999, 0, 0, 131072})
            Me.spinImporte.Name = "spinImporte"
            Me.spinImporte.ShowUpDownButtons = False
            Me.spinImporte.TabStop = False
            CType(Me.spinImporte.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.spinImporte.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Text = resources.GetString("resource.Text3")
            CType(Me.spinImporte.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            '
            'frmValeEdicion
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancelar
            Me.Controls.Add(Me.spinImporte)
            Me.Controls.Add(Me.chkEsPunto)
            Me.Controls.Add(Me.btnBuscarCliente)
            Me.Controls.Add(RadLabel3)
            Me.Controls.Add(RadLabel4)
            Me.Controls.Add(Me.txtTitular)
            Me.Controls.Add(RadLabel2)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmValeEdicion"
            Me.Opacity = 0.9R
            '
            '
            '
            Me.RootElement.ApplyShapeToControl = True
            Me.ShowInTaskbar = False
            Me.Tag = ""
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtTitular, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnBuscarCliente, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chkEsPunto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ValesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinImporte, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents ValesBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents timValidar As System.Windows.Forms.Timer
        Friend WithEvents txtTitular As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents btnBuscarCliente As RadButton
        Friend WithEvents chkEsPunto As RadCheckBox
        Friend WithEvents spinImporte As RadSpinEditor
    End Class

End Namespace

