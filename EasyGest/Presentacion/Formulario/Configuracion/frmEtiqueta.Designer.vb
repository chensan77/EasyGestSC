Namespace Presentacion.Formulario.Configuracion

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmEtiqueta
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtiqueta))
            Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn5 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn6 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn7 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn8 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn9 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn10 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn11 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn12 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
            Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim GridViewDecimalColumn13 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewDecimalColumn14 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
            Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
            Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
            Dim RadLabel4 As Telerik.WinControls.UI.RadLabel
            Dim RadLabel2 As Telerik.WinControls.UI.RadLabel
            Dim InputBinding1 As Telerik.WinControls.Keyboard.InputBinding = New Telerik.WinControls.Keyboard.InputBinding()
            Dim Chord1 As Telerik.WinControls.Keyboard.Chord = New Telerik.WinControls.Keyboard.Chord()
            Dim ChordModifier1 As Telerik.WinControls.Keyboard.ChordModifier = New Telerik.WinControls.Keyboard.ChordModifier()
            Me.gridDatos = New Telerik.WinControls.UI.RadGridView()
            Me.EtiquetasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridDiseños = New Telerik.WinControls.UI.RadGridView()
            Me.DiseñosEtiquetaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.pvEtiqueta = New Telerik.WinControls.UI.RadPageView()
            Me.pvpEtiquetas = New Telerik.WinControls.UI.RadPageViewPage()
            Me.pvpDiseños = New Telerik.WinControls.UI.RadPageViewPage()
            Me.btnExaminar = New Telerik.WinControls.UI.RadButton()
            Me.txtArchivo = New Telerik.WinControls.UI.RadTextBox()
            Me.ddlEtiquetas = New Telerik.WinControls.UI.RadDropDownList()
            Me.EtiquetasDiseñoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.rptvPrevisualizacion = New Telerik.ReportViewer.WinForms.ReportViewer()
            Me.btnCancelar = New Telerik.WinControls.UI.RadButton()
            Me.btnAceptar = New Telerik.WinControls.UI.RadButton()
            RadLabel1 = New Telerik.WinControls.UI.RadLabel()
            RadLabel4 = New Telerik.WinControls.UI.RadLabel()
            RadLabel2 = New Telerik.WinControls.UI.RadLabel()
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EtiquetasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDiseños, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDiseños.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DiseñosEtiquetaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pvEtiqueta, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pvEtiqueta.SuspendLayout()
            Me.pvpEtiquetas.SuspendLayout()
            Me.pvpDiseños.SuspendLayout()
            CType(Me.btnExaminar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ddlEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EtiquetasDiseñoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
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
            RadLabel1.RootElement.AccessibleDescription = Nothing
            RadLabel1.RootElement.AccessibleName = Nothing
            '
            'gridDatos
            '
            resources.ApplyResources(Me.gridDatos, "gridDatos")
            Me.gridDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDatos.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridDatos.ForeColor = System.Drawing.Color.Black
            '
            '
            '
            Me.gridDatos.MasterTemplate.AllowRowResize = False
            Me.gridDatos.MasterTemplate.Caption = resources.GetString("gridDatos.MasterTemplate.Caption")
            GridViewDecimalColumn1.DataType = GetType(Long)
            GridViewDecimalColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn1, "GridViewDecimalColumn1")
            GridViewDecimalColumn1.FieldName = "idEtiqueta"
            GridViewDecimalColumn1.IsAutoGenerated = True
            GridViewDecimalColumn1.IsVisible = False
            GridViewDecimalColumn1.Name = "idEtiqueta"
            GridViewTextBoxColumn1.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn1, "GridViewTextBoxColumn1")
            GridViewTextBoxColumn1.FieldName = "Referencia"
            GridViewTextBoxColumn1.IsAutoGenerated = True
            GridViewTextBoxColumn1.Name = "Referencia"
            GridViewTextBoxColumn1.Width = 91
            GridViewDecimalColumn2.DataType = GetType(Double)
            GridViewDecimalColumn2.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn2, "GridViewDecimalColumn2")
            GridViewDecimalColumn2.FieldName = "Ancho"
            GridViewDecimalColumn2.IsAutoGenerated = True
            GridViewDecimalColumn2.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
            GridViewDecimalColumn2.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
            GridViewDecimalColumn2.Name = "Ancho"
            GridViewDecimalColumn2.ShowUpDownButtons = False
            GridViewDecimalColumn2.Width = 54
            GridViewDecimalColumn3.DataType = GetType(Double)
            GridViewDecimalColumn3.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn3, "GridViewDecimalColumn3")
            GridViewDecimalColumn3.FieldName = "Alto"
            GridViewDecimalColumn3.IsAutoGenerated = True
            GridViewDecimalColumn3.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
            GridViewDecimalColumn3.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
            GridViewDecimalColumn3.Name = "Alto"
            GridViewDecimalColumn3.ShowUpDownButtons = False
            GridViewDecimalColumn3.Width = 60
            GridViewDecimalColumn4.DataType = GetType(Short)
            GridViewDecimalColumn4.DecimalPlaces = 0
            GridViewDecimalColumn4.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn4, "GridViewDecimalColumn4")
            GridViewDecimalColumn4.FieldName = "Filas"
            GridViewDecimalColumn4.IsAutoGenerated = True
            GridViewDecimalColumn4.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
            GridViewDecimalColumn4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            GridViewDecimalColumn4.Name = "Filas"
            GridViewDecimalColumn4.Width = 52
            GridViewDecimalColumn5.DataType = GetType(Short)
            GridViewDecimalColumn5.DecimalPlaces = 0
            GridViewDecimalColumn5.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn5, "GridViewDecimalColumn5")
            GridViewDecimalColumn5.FieldName = "Columnas"
            GridViewDecimalColumn5.IsAutoGenerated = True
            GridViewDecimalColumn5.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
            GridViewDecimalColumn5.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            GridViewDecimalColumn5.Name = "Columnas"
            GridViewDecimalColumn5.Width = 52
            GridViewDecimalColumn6.DataType = GetType(Double)
            GridViewDecimalColumn6.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn6, "GridViewDecimalColumn6")
            GridViewDecimalColumn6.FieldName = "EspacioH"
            GridViewDecimalColumn6.IsAutoGenerated = True
            GridViewDecimalColumn6.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
            GridViewDecimalColumn6.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
            GridViewDecimalColumn6.Name = "EspacioH"
            GridViewDecimalColumn6.ShowUpDownButtons = False
            GridViewDecimalColumn6.Width = 58
            GridViewDecimalColumn7.DataType = GetType(Double)
            GridViewDecimalColumn7.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn7, "GridViewDecimalColumn7")
            GridViewDecimalColumn7.FieldName = "EspacioV"
            GridViewDecimalColumn7.IsAutoGenerated = True
            GridViewDecimalColumn7.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
            GridViewDecimalColumn7.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
            GridViewDecimalColumn7.Name = "EspacioV"
            GridViewDecimalColumn7.ShowUpDownButtons = False
            GridViewDecimalColumn7.Width = 58
            GridViewDecimalColumn8.DataType = GetType(Double)
            GridViewDecimalColumn8.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn8, "GridViewDecimalColumn8")
            GridViewDecimalColumn8.FieldName = "MargenIzq"
            GridViewDecimalColumn8.IsAutoGenerated = True
            GridViewDecimalColumn8.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
            GridViewDecimalColumn8.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
            GridViewDecimalColumn8.Name = "MargenIzq"
            GridViewDecimalColumn8.ShowUpDownButtons = False
            GridViewDecimalColumn8.Width = 60
            GridViewDecimalColumn9.DataType = GetType(Double)
            GridViewDecimalColumn9.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn9, "GridViewDecimalColumn9")
            GridViewDecimalColumn9.FieldName = "MargenDer"
            GridViewDecimalColumn9.IsAutoGenerated = True
            GridViewDecimalColumn9.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
            GridViewDecimalColumn9.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
            GridViewDecimalColumn9.Name = "MargenDer"
            GridViewDecimalColumn9.ShowUpDownButtons = False
            GridViewDecimalColumn9.Width = 60
            GridViewDecimalColumn10.DataType = GetType(Double)
            GridViewDecimalColumn10.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn10, "GridViewDecimalColumn10")
            GridViewDecimalColumn10.FieldName = "MargenSup"
            GridViewDecimalColumn10.IsAutoGenerated = True
            GridViewDecimalColumn10.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
            GridViewDecimalColumn10.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
            GridViewDecimalColumn10.Name = "MargenSup"
            GridViewDecimalColumn10.ShowUpDownButtons = False
            GridViewDecimalColumn10.Width = 60
            GridViewDecimalColumn11.DataType = GetType(Double)
            GridViewDecimalColumn11.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn11, "GridViewDecimalColumn11")
            GridViewDecimalColumn11.FieldName = "MargenInf"
            GridViewDecimalColumn11.IsAutoGenerated = True
            GridViewDecimalColumn11.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
            GridViewDecimalColumn11.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
            GridViewDecimalColumn11.Name = "MargenInf"
            GridViewDecimalColumn11.ShowUpDownButtons = False
            GridViewDecimalColumn11.Width = 60
            GridViewDecimalColumn12.DataType = GetType(Integer)
            GridViewDecimalColumn12.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn12, "GridViewDecimalColumn12")
            GridViewDecimalColumn12.FieldName = "Usos"
            GridViewDecimalColumn12.IsAutoGenerated = True
            GridViewDecimalColumn12.IsVisible = False
            GridViewDecimalColumn12.Name = "Usos"
            GridViewDecimalColumn12.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
            Me.gridDatos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1, GridViewDecimalColumn2, GridViewDecimalColumn3, GridViewDecimalColumn4, GridViewDecimalColumn5, GridViewDecimalColumn6, GridViewDecimalColumn7, GridViewDecimalColumn8, GridViewDecimalColumn9, GridViewDecimalColumn10, GridViewDecimalColumn11, GridViewDecimalColumn12})
            Me.gridDatos.MasterTemplate.DataSource = Me.EtiquetasBindingSource
            Me.gridDatos.MasterTemplate.EnableAlternatingRowColor = True
            Me.gridDatos.MasterTemplate.EnableGrouping = False
            SortDescriptor1.PropertyName = "Usos"
            Me.gridDatos.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
            Me.gridDatos.MasterTemplate.ViewDefinition = TableViewDefinition1
            Me.gridDatos.Name = "gridDatos"
            '
            '
            '
            Me.gridDatos.RootElement.AccessibleDescription = Nothing
            Me.gridDatos.RootElement.AccessibleName = Nothing
            Me.gridDatos.ShowGroupPanel = False
            Me.gridDatos.TabStop = False
            '
            'EtiquetasBindingSource
            '
            Me.EtiquetasBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Etiquetas)
            '
            'gridDiseños
            '
            resources.ApplyResources(Me.gridDiseños, "gridDiseños")
            Me.gridDiseños.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDiseños.Cursor = System.Windows.Forms.Cursors.Default
            Me.gridDiseños.ForeColor = System.Drawing.Color.Black
            '
            '
            '
            Me.gridDiseños.MasterTemplate.AllowRowResize = False
            Me.gridDiseños.MasterTemplate.AutoGenerateColumns = False
            Me.gridDiseños.MasterTemplate.Caption = resources.GetString("gridDiseños.MasterTemplate.Caption")
            GridViewDecimalColumn13.DataType = GetType(Long)
            GridViewDecimalColumn13.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn13, "GridViewDecimalColumn13")
            GridViewDecimalColumn13.FieldName = "idEtiqueta"
            GridViewDecimalColumn13.IsAutoGenerated = True
            GridViewDecimalColumn13.IsVisible = False
            GridViewDecimalColumn13.Name = "idEtiqueta"
            GridViewDecimalColumn14.DataType = GetType(Long)
            GridViewDecimalColumn14.EnableExpressionEditor = False
            resources.ApplyResources(GridViewDecimalColumn14, "GridViewDecimalColumn14")
            GridViewDecimalColumn14.FieldName = "idDiseño"
            GridViewDecimalColumn14.IsAutoGenerated = True
            GridViewDecimalColumn14.IsVisible = False
            GridViewDecimalColumn14.Name = "idDiseño"
            GridViewTextBoxColumn2.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn2, "GridViewTextBoxColumn2")
            GridViewTextBoxColumn2.FieldName = "Nombre"
            GridViewTextBoxColumn2.IsAutoGenerated = True
            GridViewTextBoxColumn2.Name = "Nombre"
            GridViewTextBoxColumn2.Width = 133
            GridViewTextBoxColumn3.EnableExpressionEditor = False
            resources.ApplyResources(GridViewTextBoxColumn3, "GridViewTextBoxColumn3")
            GridViewTextBoxColumn3.FieldName = "Descripcion"
            GridViewTextBoxColumn3.IsAutoGenerated = True
            GridViewTextBoxColumn3.Name = "Descripcion"
            GridViewTextBoxColumn3.Width = 178
            Me.gridDiseños.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn13, GridViewDecimalColumn14, GridViewTextBoxColumn2, GridViewTextBoxColumn3})
            Me.gridDiseños.MasterTemplate.DataSource = Me.DiseñosEtiquetaBindingSource
            Me.gridDiseños.MasterTemplate.EnableAlternatingRowColor = True
            Me.gridDiseños.MasterTemplate.EnableGrouping = False
            Me.gridDiseños.MasterTemplate.ViewDefinition = TableViewDefinition2
            Me.gridDiseños.Name = "gridDiseños"
            '
            '
            '
            Me.gridDiseños.RootElement.AccessibleDescription = Nothing
            Me.gridDiseños.RootElement.AccessibleName = Nothing
            Me.gridDiseños.ShowGroupPanel = False
            Me.gridDiseños.TabStop = False
            '
            'DiseñosEtiquetaBindingSource
            '
            Me.DiseñosEtiquetaBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.DiseñosEtiqueta)
            '
            'RadLabel4
            '
            resources.ApplyResources(RadLabel4, "RadLabel4")
            RadLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel4.Name = "RadLabel4"
            '
            '
            '
            RadLabel4.RootElement.AccessibleDescription = Nothing
            RadLabel4.RootElement.AccessibleName = Nothing
            '
            'RadLabel2
            '
            resources.ApplyResources(RadLabel2, "RadLabel2")
            RadLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(117, Byte), Integer))
            RadLabel2.Name = "RadLabel2"
            '
            '
            '
            RadLabel2.RootElement.AccessibleDescription = Nothing
            RadLabel2.RootElement.AccessibleName = Nothing
            '
            'pvEtiqueta
            '
            resources.ApplyResources(Me.pvEtiqueta, "pvEtiqueta")
            Me.pvEtiqueta.Controls.Add(Me.pvpEtiquetas)
            Me.pvEtiqueta.Controls.Add(Me.pvpDiseños)
            Me.pvEtiqueta.Name = "pvEtiqueta"
            '
            '
            '
            Me.pvEtiqueta.RootElement.AccessibleDescription = Nothing
            Me.pvEtiqueta.RootElement.AccessibleName = Nothing
            Me.pvEtiqueta.SelectedPage = Me.pvpEtiquetas
            CType(Me.pvEtiqueta.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.pvEtiqueta.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.pvEtiqueta.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.StripViewItemLayout).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            CType(Me.pvEtiqueta.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RadPageViewLabelElement).Text = resources.GetString("resource.Text1")
            CType(Me.pvEtiqueta.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RadPageViewLabelElement).Font = New System.Drawing.Font("楷体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            'pvpEtiquetas
            '
            resources.ApplyResources(Me.pvpEtiquetas, "pvpEtiquetas")
            Me.pvpEtiquetas.Controls.Add(RadLabel1)
            Me.pvpEtiquetas.Controls.Add(Me.gridDatos)
            Me.pvpEtiquetas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.pvpEtiquetas.Image = Global.EasyGest.My.Resources.Resources.tag_blue
            Me.pvpEtiquetas.ItemSize = New System.Drawing.SizeF(150.0!, 32.0!)
            Me.pvpEtiquetas.Name = "pvpEtiquetas"
            '
            'pvpDiseños
            '
            resources.ApplyResources(Me.pvpDiseños, "pvpDiseños")
            Me.pvpDiseños.Controls.Add(Me.btnExaminar)
            Me.pvpDiseños.Controls.Add(Me.txtArchivo)
            Me.pvpDiseños.Controls.Add(Me.ddlEtiquetas)
            Me.pvpDiseños.Controls.Add(RadLabel2)
            Me.pvpDiseños.Controls.Add(RadLabel4)
            Me.pvpDiseños.Controls.Add(Me.rptvPrevisualizacion)
            Me.pvpDiseños.Controls.Add(Me.gridDiseños)
            Me.pvpDiseños.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.pvpDiseños.Image = Global.EasyGest.My.Resources.Resources.Telerik_16
            Me.pvpDiseños.ItemSize = New System.Drawing.SizeF(151.0!, 32.0!)
            Me.pvpDiseños.Name = "pvpDiseños"
            '
            'btnExaminar
            '
            resources.ApplyResources(Me.btnExaminar, "btnExaminar")
            Me.btnExaminar.Image = Global.EasyGest.My.Resources.Resources.folder_explore
            Me.btnExaminar.Name = "btnExaminar"
            '
            '
            '
            Me.btnExaminar.RootElement.AccessibleDescription = Nothing
            Me.btnExaminar.RootElement.AccessibleName = Nothing
            Me.btnExaminar.TextWrap = True
            '
            'txtArchivo
            '
            resources.ApplyResources(Me.txtArchivo, "txtArchivo")
            Me.txtArchivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.txtArchivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.txtArchivo.Name = "txtArchivo"
            Me.txtArchivo.ReadOnly = True
            '
            '
            '
            Me.txtArchivo.RootElement.AccessibleDescription = Nothing
            Me.txtArchivo.RootElement.AccessibleName = Nothing
            Me.txtArchivo.RootElement.ApplyShapeToControl = False
            Me.txtArchivo.TabStop = False
            Me.txtArchivo.Tag = ""
            CType(Me.txtArchivo.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = resources.GetString("resource.Text")
            CType(Me.txtArchivo.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            CType(Me.txtArchivo.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            CType(Me.txtArchivo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = ""
            CType(Me.txtArchivo.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!)
            CType(Me.txtArchivo.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
            '
            'ddlEtiquetas
            '
            resources.ApplyResources(Me.ddlEtiquetas, "ddlEtiquetas")
            Me.ddlEtiquetas.AllowShowFocusCues = True
            Me.ddlEtiquetas.AutoCompleteDisplayMember = "NombreEtiqueta"
            Me.ddlEtiquetas.AutoCompleteValueMember = "idEtiqueta"
            Me.ddlEtiquetas.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DiseñosEtiquetaBindingSource, "idEtiqueta", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ddlEtiquetas.DataSource = Me.EtiquetasDiseñoBindingSource
            Me.ddlEtiquetas.DisplayMember = "NombreEtiqueta"
            Me.ddlEtiquetas.DropDownAnimationEasing = Telerik.WinControls.RadEasingType.InBounce
            Me.ddlEtiquetas.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.UpDown
            Me.ddlEtiquetas.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me.ddlEtiquetas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            Me.ddlEtiquetas.Name = "ddlEtiquetas"
            '
            '
            '
            Me.ddlEtiquetas.RootElement.AccessibleDescription = Nothing
            Me.ddlEtiquetas.RootElement.AccessibleName = Nothing
            Me.ddlEtiquetas.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
            Me.ddlEtiquetas.ValueMember = "idEtiqueta"
            CType(Me.ddlEtiquetas.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            '
            'EtiquetasDiseñoBindingSource
            '
            Me.EtiquetasDiseñoBindingSource.DataSource = GetType(EasyGestControllers.Data.Entity.Etiquetas)
            '
            'rptvPrevisualizacion
            '
            resources.ApplyResources(Me.rptvPrevisualizacion, "rptvPrevisualizacion")
            Me.rptvPrevisualizacion.BackColor = System.Drawing.Color.LightGray
            Me.rptvPrevisualizacion.DocumentMapVisible = False
            Me.rptvPrevisualizacion.Name = "rptvPrevisualizacion"
            Me.rptvPrevisualizacion.ParametersAreaVisible = False
            Me.rptvPrevisualizacion.Resources.AllFiles = resources.GetString("rptvPrevisualizacion.Resources.AllFiles")
            Me.rptvPrevisualizacion.Resources.BackToolTip = resources.GetString("rptvPrevisualizacion.Resources.BackToolTip")
            Me.rptvPrevisualizacion.Resources.CurrentPageToolTip = resources.GetString("rptvPrevisualizacion.Resources.CurrentPageToolTip")
            Me.rptvPrevisualizacion.Resources.DocumentMapToolTip = resources.GetString("rptvPrevisualizacion.Resources.DocumentMapToolTip")
            Me.rptvPrevisualizacion.Resources.ExportError = resources.GetString("rptvPrevisualizacion.Resources.ExportError")
            Me.rptvPrevisualizacion.Resources.ExportToolTip = resources.GetString("rptvPrevisualizacion.Resources.ExportToolTip")
            Me.rptvPrevisualizacion.Resources.FirstPageToolTip = resources.GetString("rptvPrevisualizacion.Resources.FirstPageToolTip")
            Me.rptvPrevisualizacion.Resources.ForwardToolTip = resources.GetString("rptvPrevisualizacion.Resources.ForwardToolTip")
            Me.rptvPrevisualizacion.Resources.GenericMessageBoxCaption = resources.GetString("rptvPrevisualizacion.Resources.GenericMessageBoxCaption")
            Me.rptvPrevisualizacion.Resources.LabelOf = resources.GetString("rptvPrevisualizacion.Resources.LabelOf")
            Me.rptvPrevisualizacion.Resources.LastPageToolTip = resources.GetString("rptvPrevisualizacion.Resources.LastPageToolTip")
            Me.rptvPrevisualizacion.Resources.MissingReportSource = resources.GetString("rptvPrevisualizacion.Resources.MissingReportSource")
            Me.rptvPrevisualizacion.Resources.NextPageToolTip = resources.GetString("rptvPrevisualizacion.Resources.NextPageToolTip")
            Me.rptvPrevisualizacion.Resources.NoPageToDisplay = resources.GetString("rptvPrevisualizacion.Resources.NoPageToDisplay")
            Me.rptvPrevisualizacion.Resources.PageSetupToolTip = resources.GetString("rptvPrevisualizacion.Resources.PageSetupToolTip")
            Me.rptvPrevisualizacion.Resources.ParametersToolTip = resources.GetString("rptvPrevisualizacion.Resources.ParametersToolTip")
            Me.rptvPrevisualizacion.Resources.PreviousPageToolTip = resources.GetString("rptvPrevisualizacion.Resources.PreviousPageToolTip")
            Me.rptvPrevisualizacion.Resources.PrintPreviewToolTip = resources.GetString("rptvPrevisualizacion.Resources.PrintPreviewToolTip")
            Me.rptvPrevisualizacion.Resources.PrintToolTip = resources.GetString("rptvPrevisualizacion.Resources.PrintToolTip")
            Me.rptvPrevisualizacion.Resources.ProcessingReportMessage = resources.GetString("rptvPrevisualizacion.Resources.ProcessingReportMessage")
            Me.rptvPrevisualizacion.Resources.RefreshToolTip = resources.GetString("rptvPrevisualizacion.Resources.RefreshToolTip")
            Me.rptvPrevisualizacion.Resources.ReportParametersEmptyStringError = resources.GetString("rptvPrevisualizacion.Resources.ReportParametersEmptyStringError")
            Me.rptvPrevisualizacion.Resources.ReportParametersFalseValueLabel = resources.GetString("rptvPrevisualizacion.Resources.ReportParametersFalseValueLabel")
            Me.rptvPrevisualizacion.Resources.ReportParametersInputDataError = resources.GetString("rptvPrevisualizacion.Resources.ReportParametersInputDataError")
            Me.rptvPrevisualizacion.Resources.ReportParametersInvalidValueText = resources.GetString("rptvPrevisualizacion.Resources.ReportParametersInvalidValueText")
            Me.rptvPrevisualizacion.Resources.ReportParametersNoValueText = resources.GetString("rptvPrevisualizacion.Resources.ReportParametersNoValueText")
            Me.rptvPrevisualizacion.Resources.ReportParametersNullText = resources.GetString("rptvPrevisualizacion.Resources.ReportParametersNullText")
            Me.rptvPrevisualizacion.Resources.ReportParametersPreviewButtonText = resources.GetString("rptvPrevisualizacion.Resources.ReportParametersPreviewButtonText")
            Me.rptvPrevisualizacion.Resources.ReportParametersSelectAllText = resources.GetString("rptvPrevisualizacion.Resources.ReportParametersSelectAllText")
            Me.rptvPrevisualizacion.Resources.ReportParametersSelectAValueText = resources.GetString("rptvPrevisualizacion.Resources.ReportParametersSelectAValueText")
            Me.rptvPrevisualizacion.Resources.ReportParametersTrueValueLabel = resources.GetString("rptvPrevisualizacion.Resources.ReportParametersTrueValueLabel")
            Me.rptvPrevisualizacion.Resources.StopProcessing = resources.GetString("rptvPrevisualizacion.Resources.StopProcessing")
            Me.rptvPrevisualizacion.Resources.StopToolTip = resources.GetString("rptvPrevisualizacion.Resources.StopToolTip")
            Me.rptvPrevisualizacion.Resources.TotalPagesToolTip = resources.GetString("rptvPrevisualizacion.Resources.TotalPagesToolTip")
            Me.rptvPrevisualizacion.Resources.ZoomPercentFormat = resources.GetString("rptvPrevisualizacion.Resources.ZoomPercentFormat")
            Me.rptvPrevisualizacion.Resources.ZoomToolTip = resources.GetString("rptvPrevisualizacion.Resources.ZoomToolTip")
            Me.rptvPrevisualizacion.Resources.ZoomToPageWidth = resources.GetString("rptvPrevisualizacion.Resources.ZoomToPageWidth")
            Me.rptvPrevisualizacion.Resources.ZoomToWholePage = resources.GetString("rptvPrevisualizacion.Resources.ZoomToWholePage")
            Me.rptvPrevisualizacion.ShowDocumentMapButton = False
            Me.rptvPrevisualizacion.ShowExportButton = False
            Me.rptvPrevisualizacion.ShowHistoryButtons = False
            Me.rptvPrevisualizacion.ShowPageNavigationControls = False
            Me.rptvPrevisualizacion.ShowPageSetupButton = False
            Me.rptvPrevisualizacion.ShowParametersButton = False
            Me.rptvPrevisualizacion.ShowPrintButton = False
            Me.rptvPrevisualizacion.ShowPrintPreviewButton = False
            Me.rptvPrevisualizacion.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
            '
            'btnCancelar
            '
            resources.ApplyResources(Me.btnCancelar, "btnCancelar")
            Me.btnCancelar.Image = Global.EasyGest.My.Resources.Resources.cancel
            Me.btnCancelar.Name = "btnCancelar"
            '
            '
            '
            Me.btnCancelar.RootElement.AccessibleDescription = Nothing
            Me.btnCancelar.RootElement.AccessibleName = Nothing
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.cancel
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnCancelar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text2")
            CType(Me.btnCancelar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(10, Byte), Integer))
            '
            'btnAceptar
            '
            resources.ApplyResources(Me.btnAceptar, "btnAceptar")
            Me.btnAceptar.Image = Global.EasyGest.My.Resources.Resources.accept
            Me.btnAceptar.Name = "btnAceptar"
            '
            '
            '
            Me.btnAceptar.RootElement.AccessibleDescription = Nothing
            Me.btnAceptar.RootElement.AccessibleName = Nothing
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.EasyGest.My.Resources.Resources.accept
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
            CType(Me.btnAceptar.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = resources.GetString("resource.Text3")
            CType(Me.btnAceptar.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(66, Byte), Integer))
            '
            'frmEtiqueta
            '
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ChordModifier1.AltModifier = False
            ChordModifier1.ControlModifier = True
            ChordModifier1.ShiftModifier = False
            Chord1.ChordModifier = ChordModifier1
            Chord1.Keys = "Ctrl+A"
            InputBinding1.Chord = Chord1
            Me.CommandBindings.AddRange(New Telerik.WinControls.Keyboard.InputBinding() {InputBinding1})
            Me.Controls.Add(Me.pvEtiqueta)
            Me.Controls.Add(Me.btnCancelar)
            Me.Controls.Add(Me.btnAceptar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.KeyPreview = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmEtiqueta"
            Me.Opacity = 0.9R
            '
            '
            '
            Me.RootElement.AccessibleDescription = Nothing
            Me.RootElement.AccessibleName = Nothing
            Me.RootElement.ApplyShapeToControl = True
            CType(RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDatos, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EtiquetasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDiseños.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDiseños, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DiseñosEtiquetaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pvEtiqueta, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pvEtiqueta.ResumeLayout(False)
            Me.pvpEtiquetas.ResumeLayout(False)
            Me.pvpEtiquetas.PerformLayout()
            Me.pvpDiseños.ResumeLayout(False)
            Me.pvpDiseños.PerformLayout()
            CType(Me.btnExaminar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtArchivo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ddlEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EtiquetasDiseñoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnAceptar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Dim WithEvents gridDatos As Telerik.WinControls.UI.RadGridView
        Private WithEvents MasterTemplate As Telerik.WinControls.UI.RadGridView
        Friend WithEvents btnCancelar As Telerik.WinControls.UI.RadButton
        Friend WithEvents btnAceptar As Telerik.WinControls.UI.RadButton
        Friend WithEvents EtiquetasBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents pvEtiqueta As Telerik.WinControls.UI.RadPageView
        Friend WithEvents pvpEtiquetas As Telerik.WinControls.UI.RadPageViewPage
        Friend WithEvents pvpDiseños As Telerik.WinControls.UI.RadPageViewPage
        Private WithEvents gridDiseños As Telerik.WinControls.UI.RadGridView
        Friend WithEvents DiseñosEtiquetaBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents ddlEtiquetas As Telerik.WinControls.UI.RadDropDownList
        Friend WithEvents txtArchivo As Telerik.WinControls.UI.RadTextBox
        Friend WithEvents btnExaminar As Telerik.WinControls.UI.RadButton
        Friend WithEvents EtiquetasDiseñoBindingSource As System.Windows.Forms.BindingSource
        Private WithEvents rptvPrevisualizacion As Telerik.ReportViewer.WinForms.ReportViewer
    End Class

End Namespace

