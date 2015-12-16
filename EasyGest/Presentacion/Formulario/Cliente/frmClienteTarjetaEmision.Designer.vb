Namespace Presentacion.Formulario.Cliente

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmClienteTarjetaEmision
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClienteTarjetaEmision))
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel3 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel4 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel5 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel6 As Telerik.WinControls.UI.RadLabel
            Me.txtNumeroTarjeta = New Telerik.WinControls.UI.RadTextBox()
            Me.timValidar = New System.Windows.Forms.Timer(Me.components)
            Me.txtPropietario = New Telerik.WinControls.UI.RadTextBox()
            Me.txtSaldoActual = New Telerik.WinControls.UI.RadTextBox()
            Me.dtpFInicio = New Telerik.WinControls.UI.RadDateTimePicker()
            Me.spinValidezBeneficio = New Telerik.WinControls.UI.RadSpinEditor()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.gboxSaldos = New Telerik.WinControls.UI.RadGroupBox()
            Me.txtSaldo = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.txtPunto = New Telerik.WinControls.UI.RadMaskedEditBox()
            Me.gboxPuntos = New Telerik.WinControls.UI.RadGroupBox()
            Me.txtPuntoActual = New Telerik.WinControls.UI.RadTextBox()
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            RadLabel3 = New Telerik.WinControls.UI.RadLabel()
            RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            RadLabel5 = New Telerik.WinControls.UI.RadLabel()
            RadLabel6 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNumeroTarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtSaldoActual, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dtpFInicio, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinValidezBeneficio, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gboxSaldos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gboxSaldos.SuspendLayout()
            CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPunto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gboxPuntos, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gboxPuntos.SuspendLayout()
            CType(Me.txtPuntoActual, System.ComponentModel.ISupportInitialize).BeginInit()
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
            RadLabel1.RootElement.Padding = CType(resources.GetObject("RadLabel1.RootElement.Padding"), System.Windows.Forms.Padding)
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
            RadLabel2.RootElement.Padding = CType(resources.GetObject("RadLabel2.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel2.RootElement.Text = resources.GetString("RadLabel2.RootElement.Text")
            RadLabel2.RootElement.TextOrientation = CType(resources.GetObject("RadLabel2.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel2.RootElement.ToolTipText = resources.GetString("RadLabel2.RootElement.ToolTipText")
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
            RadLabel3.RootElement.KeyTip = resources.GetString("RadLabel3.RootElement.KeyTip")
            RadLabel3.RootElement.Margin = CType(resources.GetObject("RadLabel3.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel3.RootElement.Padding = CType(resources.GetObject("RadLabel3.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel3.RootElement.Text = resources.GetString("RadLabel3.RootElement.Text")
            RadLabel3.RootElement.TextOrientation = CType(resources.GetObject("RadLabel3.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel3.RootElement.ToolTipText = resources.GetString("RadLabel3.RootElement.ToolTipText")
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
            RadLabel4.RootElement.KeyTip = resources.GetString("RadLabel4.RootElement.KeyTip")
            RadLabel4.RootElement.Margin = CType(resources.GetObject("RadLabel4.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel4.RootElement.Padding = CType(resources.GetObject("RadLabel4.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel4.RootElement.Text = resources.GetString("RadLabel4.RootElement.Text")
            RadLabel4.RootElement.TextOrientation = CType(resources.GetObject("RadLabel4.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel4.RootElement.ToolTipText = resources.GetString("RadLabel4.RootElement.ToolTipText")
            '
            'RadLabel5
            '
            resources.ApplyResources(RadLabel5, "RadLabel5")
            RadLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel5.Name = "RadLabel5"
            '
            '
            '
            RadLabel5.RootElement.AccessibleDescription = resources.GetString("RadLabel5.RootElement.AccessibleDescription")
            RadLabel5.RootElement.AccessibleName = resources.GetString("RadLabel5.RootElement.AccessibleName")
            RadLabel5.RootElement.Alignment = CType(resources.GetObject("RadLabel5.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel5.RootElement.AngleTransform = CType(resources.GetObject("RadLabel5.RootElement.AngleTransform"), Single)
            RadLabel5.RootElement.FlipText = CType(resources.GetObject("RadLabel5.RootElement.FlipText"), Boolean)
            RadLabel5.RootElement.KeyTip = resources.GetString("RadLabel5.RootElement.KeyTip")
            RadLabel5.RootElement.Margin = CType(resources.GetObject("RadLabel5.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel5.RootElement.Padding = CType(resources.GetObject("RadLabel5.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel5.RootElement.Text = resources.GetString("RadLabel5.RootElement.Text")
            RadLabel5.RootElement.TextOrientation = CType(resources.GetObject("RadLabel5.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel5.RootElement.ToolTipText = resources.GetString("RadLabel5.RootElement.ToolTipText")
            '
            'RadLabel6
            '
            resources.ApplyResources(RadLabel6, "RadLabel6")
            RadLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel6.Name = "RadLabel6"
            '
            '
            '
            RadLabel6.RootElement.AccessibleDescription = resources.GetString("RadLabel6.RootElement.AccessibleDescription")
            RadLabel6.RootElement.AccessibleName = resources.GetString("RadLabel6.RootElement.AccessibleName")
            RadLabel6.RootElement.Alignment = CType(resources.GetObject("RadLabel6.RootElement.Alignment"), System.Drawing.ContentAlignment)
            RadLabel6.RootElement.AngleTransform = CType(resources.GetObject("RadLabel6.RootElement.AngleTransform"), Single)
            RadLabel6.RootElement.FlipText = CType(resources.GetObject("RadLabel6.RootElement.FlipText"), Boolean)
            RadLabel6.RootElement.KeyTip = resources.GetString("RadLabel6.RootElement.KeyTip")
            RadLabel6.RootElement.Margin = CType(resources.GetObject("RadLabel6.RootElement.Margin"), System.Windows.Forms.Padding)
            RadLabel6.RootElement.Padding = CType(resources.GetObject("RadLabel6.RootElement.Padding"), System.Windows.Forms.Padding)
            RadLabel6.RootElement.Text = resources.GetString("RadLabel6.RootElement.Text")
            RadLabel6.RootElement.TextOrientation = CType(resources.GetObject("RadLabel6.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            RadLabel6.RootElement.ToolTipText = resources.GetString("RadLabel6.RootElement.ToolTipText")
            '
            'txtNumeroTarjeta
            '
            resources.ApplyResources(Me.txtNumeroTarjeta, "txtNumeroTarjeta")
            Me.txtNumeroTarjeta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtNumeroTarjeta.Name = "txtNumeroTarjeta"
            Me.txtNumeroTarjeta.ReadOnly = True
            '
            '
            '
            Me.txtNumeroTarjeta.RootElement.AccessibleDescription = resources.GetString("txtNumeroTarjeta.RootElement.AccessibleDescription")
            Me.txtNumeroTarjeta.RootElement.AccessibleName = resources.GetString("txtNumeroTarjeta.RootElement.AccessibleName")
            Me.txtNumeroTarjeta.RootElement.Alignment = CType(resources.GetObject("txtNumeroTarjeta.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtNumeroTarjeta.RootElement.AngleTransform = CType(resources.GetObject("txtNumeroTarjeta.RootElement.AngleTransform"), Single)
            Me.txtNumeroTarjeta.RootElement.FlipText = CType(resources.GetObject("txtNumeroTarjeta.RootElement.FlipText"), Boolean)
            Me.txtNumeroTarjeta.RootElement.KeyTip = resources.GetString("txtNumeroTarjeta.RootElement.KeyTip")
            Me.txtNumeroTarjeta.RootElement.Margin = CType(resources.GetObject("txtNumeroTarjeta.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtNumeroTarjeta.RootElement.Padding = CType(resources.GetObject("txtNumeroTarjeta.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtNumeroTarjeta.RootElement.Text = resources.GetString("txtNumeroTarjeta.RootElement.Text")
            Me.txtNumeroTarjeta.RootElement.TextOrientation = CType(resources.GetObject("txtNumeroTarjeta.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtNumeroTarjeta.RootElement.ToolTipText = resources.GetString("txtNumeroTarjeta.RootElement.ToolTipText")
            Me.txtNumeroTarjeta.TabStop = False
            Me.txtNumeroTarjeta.Tag = ""
            CType(Me.txtNumeroTarjeta.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text")
            CType(Me.txtNumeroTarjeta.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtNumeroTarjeta.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtNumeroTarjeta.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtNumeroTarjeta.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtNumeroTarjeta.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.White
            CType(Me.txtNumeroTarjeta.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
            CType(Me.txtNumeroTarjeta.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid
            '
            'timValidar
            '
            '
            'txtPropietario
            '
            resources.ApplyResources(Me.txtPropietario, "txtPropietario")
            Me.txtPropietario.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.txtPropietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
            Me.txtPropietario.RootElement.KeyTip = resources.GetString("txtPropietario.RootElement.KeyTip")
            Me.txtPropietario.RootElement.Margin = CType(resources.GetObject("txtPropietario.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtPropietario.RootElement.Padding = CType(resources.GetObject("txtPropietario.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtPropietario.RootElement.Text = resources.GetString("txtPropietario.RootElement.Text")
            Me.txtPropietario.RootElement.TextOrientation = CType(resources.GetObject("txtPropietario.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtPropietario.RootElement.ToolTipText = resources.GetString("txtPropietario.RootElement.ToolTipText")
            Me.txtPropietario.TabStop = False
            Me.txtPropietario.Tag = ""
            CType(Me.txtPropietario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text1")
            CType(Me.txtPropietario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtPropietario.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtPropietario.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtPropietario.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtPropietario.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtSaldoActual
            '
            resources.ApplyResources(Me.txtSaldoActual, "txtSaldoActual")
            Me.txtSaldoActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtSaldoActual.Name = "txtSaldoActual"
            '
            '
            '
            Me.txtSaldoActual.RootElement.AccessibleDescription = resources.GetString("txtSaldoActual.RootElement.AccessibleDescription")
            Me.txtSaldoActual.RootElement.AccessibleName = resources.GetString("txtSaldoActual.RootElement.AccessibleName")
            Me.txtSaldoActual.RootElement.Alignment = CType(resources.GetObject("txtSaldoActual.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtSaldoActual.RootElement.AngleTransform = CType(resources.GetObject("txtSaldoActual.RootElement.AngleTransform"), Single)
            Me.txtSaldoActual.RootElement.FlipText = CType(resources.GetObject("txtSaldoActual.RootElement.FlipText"), Boolean)
            Me.txtSaldoActual.RootElement.KeyTip = resources.GetString("txtSaldoActual.RootElement.KeyTip")
            Me.txtSaldoActual.RootElement.Margin = CType(resources.GetObject("txtSaldoActual.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtSaldoActual.RootElement.Padding = CType(resources.GetObject("txtSaldoActual.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtSaldoActual.RootElement.Text = resources.GetString("txtSaldoActual.RootElement.Text")
            Me.txtSaldoActual.RootElement.TextOrientation = CType(resources.GetObject("txtSaldoActual.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtSaldoActual.RootElement.ToolTipText = resources.GetString("txtSaldoActual.RootElement.ToolTipText")
            Me.txtSaldoActual.TabStop = False
            Me.txtSaldoActual.Tag = ""
            Me.txtSaldoActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtSaldoActual.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text2")
            CType(Me.txtSaldoActual.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtSaldoActual.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            CType(Me.txtSaldoActual.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtSaldoActual.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtSaldoActual.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtSaldoActual.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtSaldoActual.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
            CType(Me.txtSaldoActual.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid
            '
            'dtpFInicio
            '
            resources.ApplyResources(Me.dtpFInicio, "dtpFInicio")
            Me.dtpFInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.dtpFInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFInicio.Name = "dtpFInicio"
            '
            '
            '
            Me.dtpFInicio.RootElement.AccessibleDescription = resources.GetString("dtpFInicio.RootElement.AccessibleDescription")
            Me.dtpFInicio.RootElement.AccessibleName = resources.GetString("dtpFInicio.RootElement.AccessibleName")
            Me.dtpFInicio.RootElement.Alignment = CType(resources.GetObject("dtpFInicio.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.dtpFInicio.RootElement.AngleTransform = CType(resources.GetObject("dtpFInicio.RootElement.AngleTransform"), Single)
            Me.dtpFInicio.RootElement.FlipText = CType(resources.GetObject("dtpFInicio.RootElement.FlipText"), Boolean)
            Me.dtpFInicio.RootElement.KeyTip = resources.GetString("dtpFInicio.RootElement.KeyTip")
            Me.dtpFInicio.RootElement.Margin = CType(resources.GetObject("dtpFInicio.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.dtpFInicio.RootElement.Padding = CType(resources.GetObject("dtpFInicio.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.dtpFInicio.RootElement.Text = resources.GetString("dtpFInicio.RootElement.Text")
            Me.dtpFInicio.RootElement.TextOrientation = CType(resources.GetObject("dtpFInicio.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.dtpFInicio.RootElement.ToolTipText = resources.GetString("dtpFInicio.RootElement.ToolTipText")
            Me.dtpFInicio.TabStop = False
            Me.dtpFInicio.Value = New Date(2013, 9, 2, 0, 0, 0, 0)
            CType(Me.dtpFInicio.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text3")
            '
            'spinValidezBeneficio
            '
            resources.ApplyResources(Me.spinValidezBeneficio, "spinValidezBeneficio")
            Me.spinValidezBeneficio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.spinValidezBeneficio.InterceptArrowKeys = False
            Me.spinValidezBeneficio.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
            Me.spinValidezBeneficio.Name = "spinValidezBeneficio"
            '
            '
            '
            Me.spinValidezBeneficio.RootElement.AccessibleDescription = resources.GetString("spinValidezBeneficio.RootElement.AccessibleDescription")
            Me.spinValidezBeneficio.RootElement.AccessibleName = resources.GetString("spinValidezBeneficio.RootElement.AccessibleName")
            Me.spinValidezBeneficio.RootElement.Alignment = CType(resources.GetObject("spinValidezBeneficio.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.spinValidezBeneficio.RootElement.AngleTransform = CType(resources.GetObject("spinValidezBeneficio.RootElement.AngleTransform"), Single)
            Me.spinValidezBeneficio.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.spinValidezBeneficio.RootElement.FlipText = CType(resources.GetObject("spinValidezBeneficio.RootElement.FlipText"), Boolean)
            Me.spinValidezBeneficio.RootElement.KeyTip = resources.GetString("spinValidezBeneficio.RootElement.KeyTip")
            Me.spinValidezBeneficio.RootElement.Margin = CType(resources.GetObject("spinValidezBeneficio.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.spinValidezBeneficio.RootElement.Padding = CType(resources.GetObject("spinValidezBeneficio.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.spinValidezBeneficio.RootElement.Text = resources.GetString("spinValidezBeneficio.RootElement.Text")
            Me.spinValidezBeneficio.RootElement.TextOrientation = CType(resources.GetObject("spinValidezBeneficio.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.spinValidezBeneficio.RootElement.ToolTipText = resources.GetString("spinValidezBeneficio.RootElement.ToolTipText")
            Me.spinValidezBeneficio.TabStop = False
            Me.spinValidezBeneficio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.spinValidezBeneficio.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.spinValidezBeneficio.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
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
            Me.btnAceptar.RootElement.Padding = CType(resources.GetObject("btnAceptar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnAceptar.RootElement.Text = resources.GetString("btnAceptar.RootElement.Text")
            Me.btnAceptar.RootElement.TextOrientation = CType(resources.GetObject("btnAceptar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.btnAceptar.RootElement.ToolTipText = resources.GetString("btnAceptar.RootElement.ToolTipText")
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.accept
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text4")
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
            Me.btnCancelar.RootElement.KeyTip = resources.GetString("btnCancelar.RootElement.KeyTip")
            Me.btnCancelar.RootElement.Margin = CType(resources.GetObject("btnCancelar.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.btnCancelar.RootElement.Padding = CType(resources.GetObject("btnCancelar.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.btnCancelar.RootElement.Text = resources.GetString("btnCancelar.RootElement.Text")
            Me.btnCancelar.RootElement.TextOrientation = CType(resources.GetObject("btnCancelar.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.btnCancelar.RootElement.ToolTipText = resources.GetString("btnCancelar.RootElement.ToolTipText")
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.cancel
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text5")
            CType(Me.btnCancelar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(10, Byte), Integer))
            '
            'gboxSaldos
            '
            resources.ApplyResources(Me.gboxSaldos, "gboxSaldos")
            Me.gboxSaldos.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.gboxSaldos.Controls.Add(Me.txtSaldoActual)
            Me.gboxSaldos.Controls.Add(Me.txtSaldo)
            Me.gboxSaldos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.gboxSaldos.Name = "gboxSaldos"
            '
            '
            '
            Me.gboxSaldos.RootElement.AccessibleDescription = resources.GetString("gboxSaldos.RootElement.AccessibleDescription")
            Me.gboxSaldos.RootElement.AccessibleName = resources.GetString("gboxSaldos.RootElement.AccessibleName")
            Me.gboxSaldos.RootElement.Alignment = CType(resources.GetObject("gboxSaldos.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.gboxSaldos.RootElement.AngleTransform = CType(resources.GetObject("gboxSaldos.RootElement.AngleTransform"), Single)
            Me.gboxSaldos.RootElement.FlipText = CType(resources.GetObject("gboxSaldos.RootElement.FlipText"), Boolean)
            Me.gboxSaldos.RootElement.KeyTip = resources.GetString("gboxSaldos.RootElement.KeyTip")
            Me.gboxSaldos.RootElement.Margin = CType(resources.GetObject("gboxSaldos.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.gboxSaldos.RootElement.Padding = CType(resources.GetObject("gboxSaldos.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.gboxSaldos.RootElement.Text = resources.GetString("gboxSaldos.RootElement.Text")
            Me.gboxSaldos.RootElement.TextOrientation = CType(resources.GetObject("gboxSaldos.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.gboxSaldos.RootElement.ToolTipText = resources.GetString("gboxSaldos.RootElement.ToolTipText")
            CType(Me.gboxSaldos.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).Padding = CType(resources.GetObject("resource.Padding"), System.Windows.Forms.Padding)
            CType(Me.gboxSaldos.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            '
            'txtSaldo
            '
            resources.ApplyResources(Me.txtSaldo, "txtSaldo")
            Me.txtSaldo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtSaldo.Name = "txtSaldo"
            '
            '
            '
            Me.txtSaldo.RootElement.AccessibleDescription = resources.GetString("txtSaldo.RootElement.AccessibleDescription")
            Me.txtSaldo.RootElement.AccessibleName = resources.GetString("txtSaldo.RootElement.AccessibleName")
            Me.txtSaldo.RootElement.Alignment = CType(resources.GetObject("txtSaldo.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtSaldo.RootElement.AngleTransform = CType(resources.GetObject("txtSaldo.RootElement.AngleTransform"), Single)
            Me.txtSaldo.RootElement.FlipText = CType(resources.GetObject("txtSaldo.RootElement.FlipText"), Boolean)
            Me.txtSaldo.RootElement.KeyTip = resources.GetString("txtSaldo.RootElement.KeyTip")
            Me.txtSaldo.RootElement.Margin = CType(resources.GetObject("txtSaldo.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtSaldo.RootElement.Padding = CType(resources.GetObject("txtSaldo.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtSaldo.RootElement.Text = resources.GetString("txtSaldo.RootElement.Text")
            Me.txtSaldo.RootElement.TextOrientation = CType(resources.GetObject("txtSaldo.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtSaldo.RootElement.ToolTipText = resources.GetString("txtSaldo.RootElement.ToolTipText")
            Me.txtSaldo.TabStop = False
            Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtSaldo.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text6")
            CType(Me.txtSaldo.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtSaldo.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'txtPunto
            '
            resources.ApplyResources(Me.txtPunto, "txtPunto")
            Me.txtPunto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtPunto.Name = "txtPunto"
            '
            '
            '
            Me.txtPunto.RootElement.AccessibleDescription = resources.GetString("txtPunto.RootElement.AccessibleDescription")
            Me.txtPunto.RootElement.AccessibleName = resources.GetString("txtPunto.RootElement.AccessibleName")
            Me.txtPunto.RootElement.Alignment = CType(resources.GetObject("txtPunto.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtPunto.RootElement.AngleTransform = CType(resources.GetObject("txtPunto.RootElement.AngleTransform"), Single)
            Me.txtPunto.RootElement.FlipText = CType(resources.GetObject("txtPunto.RootElement.FlipText"), Boolean)
            Me.txtPunto.RootElement.KeyTip = resources.GetString("txtPunto.RootElement.KeyTip")
            Me.txtPunto.RootElement.Margin = CType(resources.GetObject("txtPunto.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtPunto.RootElement.Padding = CType(resources.GetObject("txtPunto.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtPunto.RootElement.Text = resources.GetString("txtPunto.RootElement.Text")
            Me.txtPunto.RootElement.TextOrientation = CType(resources.GetObject("txtPunto.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtPunto.RootElement.ToolTipText = resources.GetString("txtPunto.RootElement.ToolTipText")
            Me.txtPunto.TabStop = False
            Me.txtPunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtPunto.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = resources.GetString("resource.Text7")
            CType(Me.txtPunto.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtPunto.GetChildAt(0), Telerik.WinControls.UI.RadMaskedEditBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'gboxPuntos
            '
            resources.ApplyResources(Me.gboxPuntos, "gboxPuntos")
            Me.gboxPuntos.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
            Me.gboxPuntos.Controls.Add(Me.txtPunto)
            Me.gboxPuntos.Controls.Add(Me.txtPuntoActual)
            Me.gboxPuntos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.gboxPuntos.Name = "gboxPuntos"
            '
            '
            '
            Me.gboxPuntos.RootElement.AccessibleDescription = resources.GetString("gboxPuntos.RootElement.AccessibleDescription")
            Me.gboxPuntos.RootElement.AccessibleName = resources.GetString("gboxPuntos.RootElement.AccessibleName")
            Me.gboxPuntos.RootElement.Alignment = CType(resources.GetObject("gboxPuntos.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.gboxPuntos.RootElement.AngleTransform = CType(resources.GetObject("gboxPuntos.RootElement.AngleTransform"), Single)
            Me.gboxPuntos.RootElement.FlipText = CType(resources.GetObject("gboxPuntos.RootElement.FlipText"), Boolean)
            Me.gboxPuntos.RootElement.KeyTip = resources.GetString("gboxPuntos.RootElement.KeyTip")
            Me.gboxPuntos.RootElement.Margin = CType(resources.GetObject("gboxPuntos.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.gboxPuntos.RootElement.Padding = CType(resources.GetObject("gboxPuntos.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.gboxPuntos.RootElement.Text = resources.GetString("gboxPuntos.RootElement.Text")
            Me.gboxPuntos.RootElement.TextOrientation = CType(resources.GetObject("gboxPuntos.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.gboxPuntos.RootElement.ToolTipText = resources.GetString("gboxPuntos.RootElement.ToolTipText")
            CType(Me.gboxPuntos.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).Padding = CType(resources.GetObject("resource.Padding1"), System.Windows.Forms.Padding)
            CType(Me.gboxPuntos.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            '
            'txtPuntoActual
            '
            resources.ApplyResources(Me.txtPuntoActual, "txtPuntoActual")
            Me.txtPuntoActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtPuntoActual.Name = "txtPuntoActual"
            '
            '
            '
            Me.txtPuntoActual.RootElement.AccessibleDescription = resources.GetString("txtPuntoActual.RootElement.AccessibleDescription")
            Me.txtPuntoActual.RootElement.AccessibleName = resources.GetString("txtPuntoActual.RootElement.AccessibleName")
            Me.txtPuntoActual.RootElement.Alignment = CType(resources.GetObject("txtPuntoActual.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.txtPuntoActual.RootElement.AngleTransform = CType(resources.GetObject("txtPuntoActual.RootElement.AngleTransform"), Single)
            Me.txtPuntoActual.RootElement.FlipText = CType(resources.GetObject("txtPuntoActual.RootElement.FlipText"), Boolean)
            Me.txtPuntoActual.RootElement.KeyTip = resources.GetString("txtPuntoActual.RootElement.KeyTip")
            Me.txtPuntoActual.RootElement.Margin = CType(resources.GetObject("txtPuntoActual.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.txtPuntoActual.RootElement.Padding = CType(resources.GetObject("txtPuntoActual.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.txtPuntoActual.RootElement.Text = resources.GetString("txtPuntoActual.RootElement.Text")
            Me.txtPuntoActual.RootElement.TextOrientation = CType(resources.GetObject("txtPuntoActual.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.txtPuntoActual.RootElement.ToolTipText = resources.GetString("txtPuntoActual.RootElement.ToolTipText")
            Me.txtPuntoActual.TabStop = False
            Me.txtPuntoActual.Tag = ""
            Me.txtPuntoActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            CType(Me.txtPuntoActual.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text8")
            CType(Me.txtPuntoActual.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtPuntoActual.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtPuntoActual.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtPuntoActual.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.txtPuntoActual.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtPuntoActual.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
            CType(Me.txtPuntoActual.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid
            '
            'frmClienteTarjetaEmision
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancelar
            Me.Controls.Add(Me.gboxPuntos)
            Me.Controls.Add(Me.gboxSaldos)
            Me.Controls.Add(Me.spinValidezBeneficio)
            Me.Controls.Add(Me.dtpFInicio)
            Me.Controls.Add(Me.txtNumeroTarjeta)
            Me.Controls.Add(RadLabel2)
            Me.Controls.Add(RadLabel6)
            Me.Controls.Add(RadLabel5)
            Me.Controls.Add(RadLabel4)
            Me.Controls.Add(RadLabel3)
            Me.Controls.Add(RadLabel1)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.Controls.Add(Me.txtPropietario)
            Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmClienteTarjetaEmision"
            Me.Opacity = 0.9R
            '
            '
            '
            Me.RootElement.AccessibleDescription = resources.GetString("frmClienteTarjetaEmision.RootElement.AccessibleDescription")
            Me.RootElement.AccessibleName = resources.GetString("frmClienteTarjetaEmision.RootElement.AccessibleName")
            Me.RootElement.Alignment = CType(resources.GetObject("frmClienteTarjetaEmision.RootElement.Alignment"), System.Drawing.ContentAlignment)
            Me.RootElement.AngleTransform = CType(resources.GetObject("frmClienteTarjetaEmision.RootElement.AngleTransform"), Single)
            Me.RootElement.ApplyShapeToControl = True
            Me.RootElement.FlipText = CType(resources.GetObject("frmClienteTarjetaEmision.RootElement.FlipText"), Boolean)
            Me.RootElement.KeyTip = resources.GetString("frmClienteTarjetaEmision.RootElement.KeyTip")
            Me.RootElement.Margin = CType(resources.GetObject("frmClienteTarjetaEmision.RootElement.Margin"), System.Windows.Forms.Padding)
            Me.RootElement.Padding = CType(resources.GetObject("frmClienteTarjetaEmision.RootElement.Padding"), System.Windows.Forms.Padding)
            Me.RootElement.Text = resources.GetString("frmClienteTarjetaEmision.RootElement.Text")
            Me.RootElement.TextOrientation = CType(resources.GetObject("frmClienteTarjetaEmision.RootElement.TextOrientation"), System.Windows.Forms.Orientation)
            Me.RootElement.ToolTipText = resources.GetString("frmClienteTarjetaEmision.RootElement.ToolTipText")
            Me.ShowInTaskbar = False
            Me.Tag = ""
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNumeroTarjeta, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPropietario, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtSaldoActual, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dtpFInicio, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinValidezBeneficio, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gboxSaldos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gboxSaldos.ResumeLayout(False)
            Me.gboxSaldos.PerformLayout()
            CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPunto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gboxPuntos, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gboxPuntos.ResumeLayout(False)
            Me.gboxPuntos.PerformLayout()
            CType(Me.txtPuntoActual, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents txtNumeroTarjeta As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents timValidar As System.Windows.Forms.Timer
        Friend WithEvents txtPropietario As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtSaldoActual As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents dtpFInicio As Telerik.WinControls.UI.RadDateTimePicker
        Friend WithEvents spinValidezBeneficio As Telerik.WinControls.UI.RadSpinEditor
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents gboxSaldos As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents gboxPuntos As Telerik.WinControls.UI.RadGroupBox
        Friend WithEvents txtPuntoActual As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents txtSaldo As Telerik.WinControls.UI.RadMaskedEditBox
        Friend WithEvents txtPunto As Telerik.WinControls.UI.RadMaskedEditBox
    End Class

End Namespace

