Imports EasyGestControllers
Imports EasyGestControllers.Data
Imports EasyGest.Presentacion.Componente
Imports Telerik.WinControls


Namespace Presentacion.Formulario.Producto

    Public Class frmProducto


        Private WithEvents cbBusqueda As Presentacion.Componente.CommandBarFilterItem
        Private WithEvents cbOrden As Presentacion.Componente.CommandBarSortItem
        'Private WithEvents bkwCarga As New Wi
        Private _panel As New WaitingPanel()
        Private _totalpage As Integer = 0
        Private _pagenumber As Integer = 0
        Private _subpagenumber As Integer = 0
        Private _numregistro As Integer = 0
        Private _filtro As String = ""
        Private _orden As String = "Descripcion ASC"
        Private _paginar As Boolean = True
        Private _paginando As Boolean = False
        Private _diagnostico As Diagnostics.Stopwatch
        Private _pagebuttons As RadButtonElement()
        Private _btnbgcolors(3) As Color
        Private _familiaselected As Familias = Nothing
        Private _ofertaselected As Ofertas = Nothing
        Private _startDrag As Point = Point.Empty
        Private _productoDragged As VWProductos = Nothing
        Private _previouNode As TreeNodeElement = Nothing
        Private _previouItem As ListViewDataItem = Nothing
        Private _primercarga As Boolean = True

        Public Sub New()

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            Me.Controls.Add(_panel)
            _panel.BringToFront()
            PrepararControles(pvpDetalle.Controls)
            PrepararControles(pvpOtro.Controls)
            PrepararControles(SplitPanel1.Controls)
            PrepararControles(SplitPanel2.Controls)
            ConfigurarBarraBusqueda()
            ConfigurarBarraOrden()
            ConfigurarPaginacion()
            ConfigurarCommandBar(Me.cbstripeAccion)
            ConfigurarCommandBar(Me.cbstripeOrden)
            ConfigurarCommandBar(Me.cbstripeBusqueda)
            _diagnostico = New Diagnostics.Stopwatch()
        End Sub

#Region "Evento Form"

        Private Sub frmProducto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            pvInfo.SelectedPage = pvpDetalle
            gridDatos.GridViewElement.AllowDrag = True
            chkeNoActivos.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
            lbleDiagnostico.Text = String.Empty
            lstvOfertas.Columns(0).HeaderText = My.Resources.Application.TextoNumeroOferta
            lstvOfertas.Columns(1).HeaderText = My.Resources.Application.TextoPlan
            lstvOfertas.ContextMenuStrip = GetContextMenu()
            treeFamilia.ContextMenuStrip = GetContextMenu()
            ImpuestoLabel.Text = String.Format(ImpuestoLabel.Text, gConfGlobal.NombreImpuesto)
            Try
                CargarFamilias()
                CargarOfertas()
                _primercarga = False
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
            AddHandler chkePaginar.ToggleStateChanged, AddressOf chkePaginar_ToggleStateChanged
        End Sub

        Private Sub frmProducto_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            'Establecer Permisos
            mitemAdquirirImagen.Enabled = ((gUsuario.PermisoProducto And Permiso.Adicion) = Permiso.Adicion) Or ((gUsuario.PermisoProducto And Permiso.Modificacion) = Permiso.Modificacion)
            cbbtnAgregar.Enabled = ((gUsuario.PermisoProducto And Permiso.Adicion) = Permiso.Adicion)
            cbbtnModificar.Enabled = ((gUsuario.PermisoProducto And Permiso.Modificacion) = Permiso.Modificacion)
            cbbtnEliminar.Enabled = ((gUsuario.PermisoProducto And Permiso.Eliminacion) = Permiso.Eliminacion)
            CargarDatos("Activo == True")
        End Sub

#End Region

#Region "Evento Grid"

        Private Sub gridDatos_DataBindingComplete(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewBindingCompleteEventArgs) Handles gridDatos.DataBindingComplete
            If gridDatos.Rows.Count = 0 Then
                If VWProductoBindingSource.Current IsNot Nothing Then VWProductoBindingSource.RemoveCurrent()
            End If
        End Sub

        Private Sub gridDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridDatos.SelectionChanged
            If gridDatos.SelectedRows.Count = 0 Then
                If VWProductoBindingSource.Current IsNot Nothing Then VWProductoBindingSource.RemoveCurrent()
            Else
                VWProductoBindingSource.DataSource = gridDatos.SelectedRows(0).DataBoundItem
            End If
        End Sub

        Private Sub gridDatos_ViewRowFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RowFormattingEventArgs) Handles gridDatos.ViewRowFormatting
            If TypeOf e.RowElement Is GridDataRowElement Then
                e.RowElement.AllowDrag = True
            End If
        End Sub

        Private Sub gridDatos_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridDatos.MouseDown
            _startDrag = Point.Empty
            Dim element As RadElement = GetItemFromPoint(Of GridCellElement)(gridDatos, e.Location, False)
            If Not IsNothing(element) AndAlso TypeOf element Is GridDataCellElement Then _startDrag = e.Location
        End Sub

        Private Sub gridDatos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridDatos.MouseMove
            Dim rows As GridViewSelectedRowsCollection = gridDatos.SelectedRows
            If Me.IsRealDrag(e.Location) AndAlso rows IsNot Nothing AndAlso rows.Count > 0 Then
                _productoDragged = DirectCast(rows(0).DataBoundItem, VWProductos)
                Me.gridDatos.DoDragDrop(rows, DragDropEffects.Link)
            End If
        End Sub
#End Region

#Region "Evento botones acciones"

        Private Sub cbbtnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnAgregar.Click
            EditarAgregar(-1)
        End Sub

        Private Sub cbbtnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnModificar.Click
            Dim item As VWProductos = gridDatos.SelectedItem(Of VWProductos)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                EditarAgregar(item.idProducto)
            End If
        End Sub

        Private Sub cbbtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbtnEliminar.Click
            Dim item As VWProductos = gridDatos.SelectedItem(Of VWProductos)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Eliminar(item.idProducto)
            End If
        End Sub

        Private Sub chkeNoActivos_ToggleStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkeNoActivos.ToggleStateChanged
            gridDatos.FilterDescriptors.Clear()
            CargarDatos(ExpresionFiltroActivo())
        End Sub

        Private Sub mitemRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                Dim menu As ContextMenuStrip = DirectCast(DirectCast(sender, ToolStripItem).Owner, ContextMenuStrip)
                If TypeOf menu.SourceControl Is RadListView Then
                    CargarOfertas()
                End If
                If TypeOf menu.SourceControl Is RadTreeView Then
                    CargarFamilias()
                End If

            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub cbbtnCaracteristicas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnCaracteristicas.Click
            Dim item As VWProductos = gridDatos.SelectedItem(Of VWProductos)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Try
                    Dim frm As New frmCaracteristicaProducto(item.idProducto)
                    frm.ShowDialog()

                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorAplicacion, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
        End Sub

        Private Sub cbbtnGaleria_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnGaleria.Click

        End Sub

        Private Sub cbbtnEtiquetar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnEtiquetar.Click

        End Sub

        Private Sub mitemAdquirirImagen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mitemAdquirirImagen.Click

        End Sub

#End Region

#Region "Operaciones AED"

        Private Sub CargarDatos(ByVal filtro As String)
            If bgwCarga.IsBusy() Then Return
            _filtro = filtro
            _panel.Mostrar()
            _diagnostico.Reset()
            bgwCarga.RunWorkerAsync()
        End Sub

        Private Sub bgwCarga_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarga.DoWork
            _diagnostico.Start()
            System.Threading.Thread.CurrentThread.CurrentCulture = GetApplicationCulture(Me)
            Using c As New Controller.VistasController(Of Entity.VWProductos)()
                Dim datos As IEnumerable(Of VWProductos)
                If _paginar Then
                    datos = c.GetItems(_filtro, _orden, (_pagenumber + _subpagenumber) * gConfLocal.NumRegXPagina, gConfLocal.NumRegXPagina, _numregistro)
                Else
                    datos = c.GetItems(_filtro, _orden)
                    _numregistro = datos.Count()
                End If
                e.Result = datos
            End Using

            _diagnostico.Stop()
        End Sub

        Private Sub bgwCarga_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwCarga.RunWorkerCompleted
            _panel.Ocultar()
            If Not IsNothing(e.Error) Then
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
            Else
                Try
                    VWProductosBindingSource.DataSource = e.Result
                    lbleDiagnostico.Text = String.Format(My.Resources.Application.TextoDiagnosticoConsulta, _numregistro, _diagnostico.Elapsed.Milliseconds)
                    If _paginando Then
                        _paginando = False
                    Else
                        If _paginar Then
                            _totalpage = CInt(Math.Ceiling(_numregistro / gConfLocal.NumRegXPagina))
                            CambiarTextoPagina(1)
                            _pagenumber = 0
                            _subpagenumber = 0
                            MostrarBotonesPaginacion(_totalpage - _pagenumber)
                            CambiarColorFondoPaginacion(_pagebuttons(0))
                            btneAnterior.Enabled = False
                            btneSiguiente.Enabled = _totalpage > 5
                        End If
                    End If
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try

            End If

        End Sub

        Private Sub EditarAgregar(ByVal id As Long)
            Dim frm As frmProductoEdicion
            Try

                frm = New frmProductoEdicion(id)
                If frm.ShowDialog(My.Forms.frmPrincipal) = Windows.Forms.DialogResult.OK Then
                    Dim producto As Entity.VWProductos = frm.Producto
                    Dim row As GridViewRowInfo
                    If id = -1 Then
                        Me.VWProductosBindingSource.Add(producto)
                    End If
                    row = UpdateSelectGridRow(gridDatos, producto)
                    If Not IsNothing(row) Then
                        VWProductoBindingSource.DataSource = row.DataBoundItem
                    End If
                End If
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub Eliminar(ByVal idSeleccionado As Long)
            If MostrarMensaje(My.Resources.Application.ConfirmacionBorrarDato, Me.Text, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Try
                    Dim toDelete As Productos
                    Using control As New ProductosController
                        toDelete = control.GetItem(idSeleccionado)
                        toDelete.SetAsDeleteOnSubmit()
                        control.SyncronisingItem(toDelete)
                    End Using
                    VWProductosBindingSource.RemoveCurrent()
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
        End Sub

        Private Function ExpresionFiltroActivo() As String
            Return String.Format("Activo = {0}", IIf(chkeNoActivos.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On, "False", "True"))
        End Function

        Private Sub CargarFamilias()
            Dim familiasbase As List(Of Familias)
            Dim familiaNulo As Familias = Nothing
            Dim nodonocategorizado As New RadTreeNode(My.Resources.Application.TextoProductoNoCategorizado)
            nodonocategorizado.Tag = familiaNulo
            nodonocategorizado.Font = gDefaultFont
            If IsNothing(_familiaselected) And Not _primercarga Then
                nodonocategorizado.Selected = True
            End If
            treeFamilia.Nodes.Clear()
            treeFamilia.Nodes.Add(nodonocategorizado)
            Using control As New FamiliasController
                familiasbase = control.GetItems("idFamiliaPadre == NULL", "Familia").ToList()
            End Using
            For Each familia As Familias In familiasbase
                Dim nodo As RadTreeNode = NuevoNodo(familia, CargarSubfamilias(familia.idFamilia))
                If Not IsNothing(_familiaselected) AndAlso _familiaselected.idFamilia = familia.idFamilia Then nodo.Selected = True
                treeFamilia.Nodes.Add(nodo)
            Next
            treeFamilia.ExpandAll()
        End Sub

        Private Function CargarSubfamilias(ByVal idPadre As Long) As RadTreeNode()
            Dim listaNodo As New List(Of RadTreeNode)
            Dim subfamilias As List(Of Familias)
            Using control As New FamiliasController
                subfamilias = control.GetItems("idFamiliaPadre == " & idPadre, "Familia").ToList()
            End Using
            For Each familia As Familias In subfamilias
                Dim nodo As RadTreeNode = NuevoNodo(familia, CargarSubfamilias(familia.idFamilia))
                If Not IsNothing(_familiaselected) AndAlso _familiaselected.idFamilia = familia.idFamilia Then nodo.Selected = True
                listaNodo.Add(nodo)
            Next
            Return listaNodo.ToArray()
        End Function

        Private Sub CargarOfertas()
            Dim ofertas As IEnumerable(Of Ofertas)
            Dim ofertaNulo As Ofertas = Nothing
            Dim itemnooferta As New ListViewDataItem("-1", New String() {"''", My.Resources.Application.TextoProductoNoOfertado})

            itemnooferta.Tag = ofertaNulo
            If IsNothing(_ofertaselected) And Not _primercarga Then
                lstvOfertas.SelectedItem = itemnooferta
            End If
            lstvOfertas.Items.Clear()
            lstvOfertas.Items.Add(itemnooferta)
            Using c As New OfertasController()
                ofertas = c.GetItems("Activo == True", "NumeroOferta")
            End Using
            For Each oferta As Ofertas In ofertas
                Dim item As New ListViewDataItem(CStr(oferta.idOferta), New String() {oferta.NumeroOferta, oferta.Plan})
                If oferta.Vigente.HasValue AndAlso oferta.Vigente.Value Then
                    item.ForeColor = Color.Green
                Else
                    item.ForeColor = Color.Black
                End If

                item.Tag = oferta                
                If Not IsNothing(_ofertaselected) AndAlso _ofertaselected.idOferta = oferta.idOferta Then lstvOfertas.SelectedItem = item
                lstvOfertas.Items.Add(item)
            Next
        End Sub

        Private Function AsignarFamilia(ByVal familia As Familias, ByVal producto As VWProductos) As VWProductos
            Dim idfamilia As Long? = Nothing
            If IsNothing(producto) Then Throw New NullReferenceException()
            If Not IsNothing(familia) Then idfamilia = familia.idFamilia
            Try
                Using control As New ProductosController()
                    Return control.AsignarFamilia(producto.idProducto, idfamilia)
                End Using
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                Return producto
            End Try
        End Function

        Private Function AsignarOferta(ByVal oferta As Ofertas, ByVal producto As VWProductos) As VWProductos
            Dim idoferta As Long? = Nothing
            If IsNothing(producto) Then Throw New NullReferenceException()
            If Not IsNothing(oferta) Then idoferta = oferta.idOferta
            Try
                Using control As New ProductosController()
                    Return control.AsignarOferta(producto.idProducto, idoferta)
                End Using
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                Return producto
            End Try
        End Function

#End Region

#Region "Busqueda"

        Private Sub ConfigurarBarraBusqueda()
            cbBusqueda = New Presentacion.Componente.CommandBarFilterItem(cbstripeBusqueda)
            cbBusqueda.AddItemToFieldDDL(gridDatos.Columns("Referencia").HeaderText, "Referencia", "String")
            cbBusqueda.AddItemToFieldDDL(gridDatos.Columns("Descripcion").HeaderText, "Descripcion", "String")
            cbBusqueda.AddItemToFieldDDL(gridDatos.Columns("PrecioVenta").HeaderText, "PrecioVenta", "Number")
            cbBusqueda.AddItemToFieldDDL(gridDatos.Columns("Marca").HeaderText, "Marca", "String")
            cbBusqueda.AddItemToFieldDDL(My.Resources.Application.TextoFechaCreacion, "FCreacion", "Date")
            cbBusqueda.AddItemToFieldDDL(My.Resources.Application.TextoFechaModificacion, "FModificacion", "Date")
            cbBusqueda.Prepare("")
        End Sub

        Private Sub cbBusqueda_onFilter(ByVal sender As Presentacion.Componente.CommandBarFilterItem, ByVal e As Presentacion.Componente.FilterEventArgs) Handles cbBusqueda.onFilter
            If Not String.IsNullOrWhiteSpace(e.FilterExpression) And Not bgwCarga.IsBusy() Then
                gridDatos.FilterDescriptors.Clear()
                CargarDatos(e.FilterExpression & " and " & ExpresionFiltroActivo())
            End If
        End Sub

#End Region

#Region "Ordenacion"

        Private Sub cbOrden_onSort(ByVal sender As CommandBarSortItem, ByVal e As SortEventArgs) Handles cbOrden.onSort
            gridDatos.FilterDescriptors.Clear()
            gridDatos.SortDescriptors.Clear()
            cbBusqueda.ClearFilterText()
            _orden = e.SortExpression
            _pagenumber = 0
            _subpagenumber = 0
            CargarDatos(ExpresionFiltroActivo())
        End Sub

        Private Sub ConfigurarBarraOrden()
            cbOrden = New Presentacion.Componente.CommandBarSortItem(cbstripeOrden)
            cbOrden.AddItemToFieldDDL(gridDatos.Columns("Descripcion").HeaderText, "Descripcion")
            cbOrden.AddItemToFieldDDL(gridDatos.Columns("Referencia").HeaderText, "Referencia")
            cbOrden.AddItemToFieldDDL(gridDatos.Columns("PrecioVenta").HeaderText, "PrecioVenta")
            cbOrden.AddItemToFieldDDL(My.Resources.Application.TextoFechaCreacion, "FCreacion")
            cbOrden.Prepare("")
        End Sub

#End Region

#Region "Paginacion"

        Private Sub btneAnterior_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btneAnterior.Click
            If 0 < _pagenumber Then
                MoverPagina(-1)
            End If
        End Sub

        Private Sub btneSiguiente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btneSiguiente.Click
            If _totalpage - 1 > _pagenumber Then
                MoverPagina(1)
            End If
        End Sub

        Private Sub chkePaginar_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            btneAnterior.Enabled = chkePaginar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            btneSiguiente.Enabled = chkePaginar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            _paginar = chkePaginar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            _pagenumber = 0
            _subpagenumber = 0
            lblePagina.Text = String.Empty
            MostrarBotonesPaginacion(0)
            CargarDatos(_filtro)
        End Sub

        Private Sub MoverPagina(ByVal sentido As Integer)
            _pagenumber += 5 * sentido
            btneAnterior.Enabled = _pagenumber > 0
            btneSiguiente.Enabled = _pagenumber + 5 < _totalpage
            _paginando = True
            _subpagenumber = 0
            CambiarTextoPagina(_pagenumber + 1)
            MostrarBotonesPaginacion(_totalpage - _pagenumber)
            CambiarColorFondoPaginacion(_pagebuttons(0))
            CargarDatos(_filtro)
        End Sub

        Private Sub ConfigurarPaginacion()
            ReDim _pagebuttons(4)
            For i As Integer = 0 To 4
                _pagebuttons(i) = GetPageButton(i)
                AddHandler _pagebuttons(i).Click, AddressOf btnePage_Click
                statuInfo.Items.Insert(i + 1, _pagebuttons(i))
            Next
            _btnbgcolors(0) = _pagebuttons(0).ButtonFillElement.BackColor
            _btnbgcolors(1) = _pagebuttons(0).ButtonFillElement.BackColor2
            _btnbgcolors(2) = _pagebuttons(0).ButtonFillElement.BackColor3
            _btnbgcolors(3) = _pagebuttons(0).ButtonFillElement.BackColor4
        End Sub

        Private Sub MostrarBotonesPaginacion(ByVal numbtnamostrar As Integer)
            For i As Integer = 0 To _pagebuttons.Length - 1
                If i < numbtnamostrar Then
                    _pagebuttons(i).Visibility = Telerik.WinControls.ElementVisibility.Visible
                    _pagebuttons(i).Text = CStr(_pagenumber + i + 1)
                Else
                    _pagebuttons(i).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
                End If
            Next
        End Sub

        Private Sub CambiarTextoPagina(ByVal num As Integer)
            lblePagina.Text = String.Format("{0} / {1}", num, _totalpage)
        End Sub

        Private Sub CambiarColorFondoPaginacion(ByVal selectedbtn As RadButtonElement)
            For Each btn As RadButtonElement In _pagebuttons
                If btn Is selectedbtn Then
                    SetFillPrimitiveBackGroundColor(gBTNBGColors, btn.ButtonFillElement)
                Else
                    SetFillPrimitiveBackGroundColor(_btnbgcolors, btn.ButtonFillElement)
                End If
            Next
        End Sub

        Private Sub btnePage_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim senderbtn As RadButtonElement = DirectCast(sender, RadButtonElement)
            If senderbtn.Tag.Equals(_subpagenumber) Then Return
            CambiarColorFondoPaginacion(senderbtn)
            gridDatos.FilterDescriptors.Clear()
            gridDatos.SortDescriptors.Clear()
            _paginando = True
            _subpagenumber = CInt(senderbtn.Tag)
            CambiarTextoPagina(_pagenumber + _subpagenumber + 1)
            CargarDatos(_filtro)
        End Sub
#End Region

#Region "Eventos Arbol"

        Private Sub treeFamilia_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles treeFamilia.DragLeave
            ReestablecerTreeNode()
            lbleDiagnostico.Text = String.Empty
        End Sub

        Private Sub treeFamilia_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles treeFamilia.DragDrop
            Dim itemToDrop As GridViewSelectedRowsCollection = DirectCast(e.Data.GetData(GetType(GridViewSelectedRowsCollection)), GridViewSelectedRowsCollection)
            Dim nodo As TreeNodeElement = GetItemFromPoint(Of TreeNodeElement)(treeFamilia, New Point(e.X, e.Y), True)
            If Not IsNothing(nodo) And Not IsNothing(itemToDrop) Then
                For Each row In itemToDrop
                    Dim prod As VWProductos = AsignarFamilia(TryCast(nodo.Data.Tag, Familias), TryCast(row.DataBoundItem, VWProductos))
                    prod.Clone(DirectCast(row.DataBoundItem, VWProductos))
                    row.InvalidateRow()
                    VWProductoBindingSource.DataSource = row.DataBoundItem
                Next
                nodo.ContentElement.ForeColor = Color.Black
            End If
            ReestablecerTreeNode()
            lbleDiagnostico.Text = String.Empty
        End Sub

        Private Sub treeFamilia_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles treeFamilia.DragOver
            Dim nodo As TreeNodeElement = Nothing
            lbleDiagnostico.Text = String.Empty
            
            If Not e.Data.GetDataPresent(GetType(GridViewSelectedRowsCollection)) Then
                e.Effect = DragDropEffects.None
            Else
                nodo = GetItemFromPoint(Of TreeNodeElement)(treeFamilia, New Point(e.X, e.Y), True)
                If IsNothing(nodo) Then
                    e.Effect = DragDropEffects.None
                    ReestablecerTreeNode()
                Else
                    lbleDiagnostico.Text = String.Format(My.Resources.Application.TextoDescCategorizarProducto, _productoDragged.Descripcion, nodo.Data.Text)
                    If Not Object.ReferenceEquals(nodo, _previouNode) Then
                        ReestablecerTreeNode()
                        _previouNode = nodo
                        nodo.ContentElement.ForeColor = Color.DarkViolet
                    End If
                    e.Effect = DragDropEffects.Link
                End If
            End If
        End Sub

        Private Sub treeFamilia_NodeFormatting(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.TreeNodeFormattingEventArgs) Handles treeFamilia.NodeFormatting
            If imglFamilia.Images.Count > 0 Then e.Node.ImageIndex = e.Node.Level Mod imglFamilia.Images.Count
        End Sub

        Private Sub treeFamilia_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RadTreeViewEventArgs) Handles treeFamilia.NodeMouseDoubleClick
            Dim familia As Familias = TryCast(e.Node.Tag, Familias)
            _familiaselected = TryCast(e.Node.Tag, Familias)
            If IsNothing(familia) Then
                CargarDatos(ExpresionFiltroActivo() & " AND idFamilia == NULL")
            Else
                CargarDatos(ExpresionFiltroActivo() & " AND idFamilia == " & familia.idFamilia)
            End If
        End Sub

#End Region

#Region "Eventos Lista"

        Private Sub lstvOfertas_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lstvOfertas.DragDrop
            Dim itemToDrop As GridViewSelectedRowsCollection = DirectCast(e.Data.GetData(GetType(GridViewSelectedRowsCollection)), GridViewSelectedRowsCollection)
            Dim item As DetailListViewDataCellElement = GetItemFromPoint(Of DetailListViewDataCellElement)(lstvOfertas, New Point(e.X, e.Y), True)
            If Not IsNothing(item) And Not IsNothing(itemToDrop) Then
                For Each row In itemToDrop
                    Dim prod As VWProductos = AsignarOferta(TryCast(item.Row.Tag, Ofertas), TryCast(row.DataBoundItem, VWProductos))
                    prod.Clone(DirectCast(row.DataBoundItem, VWProductos))
                    row.InvalidateRow()
                    VWProductoBindingSource.DataSource = row.DataBoundItem
                Next
                If IsNothing(item.Row.Tag) Then
                    item.Row.ForeColor = Color.Black
                Else
                    Dim vigente As Boolean? = TryCast(item.Row.Tag, Ofertas).Vigente
                    If vigente.HasValue AndAlso vigente.Value = True Then
                        item.Row.ForeColor = Color.Green
                    Else
                        item.Row.ForeColor = Color.Black
                    End If
                End If
            End If
            ReestablecerListItem()
            lbleDiagnostico.Text = String.Empty
        End Sub

        Private Sub lstvOfertas_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstvOfertas.DragLeave
            ReestablecerListItem()
            lbleDiagnostico.Text = String.Empty
        End Sub

        Private Sub lstvOfertas_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lstvOfertas.DragOver
            Dim item As DetailListViewDataCellElement = Nothing
            If Not e.Data.GetDataPresent(GetType(GridViewSelectedRowsCollection)) Then
                e.Effect = DragDropEffects.None
            Else
                item = GetItemFromPoint(Of DetailListViewDataCellElement)(lstvOfertas, New Point(e.X, e.Y), True)
                If IsNothing(item) Then
                    ReestablecerListItem()
                    e.Effect = DragDropEffects.None
                Else
                    lbleDiagnostico.Text = String.Format(My.Resources.Application.TextoDescEstablecerOfertaProducto, _productoDragged.Descripcion, item.Row(0).ToString())
                    If Not Object.ReferenceEquals(item.Row, _previouItem) Then
                        ReestablecerListItem()
                        _previouItem = item.Row
                        item.Row.ForeColor = Color.DarkViolet
                    End If
                    e.Effect = DragDropEffects.Link
                End If
            End If
        End Sub

        Private Sub lstvOfertas_ItemMouseDoubleClick(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewItemEventArgs) Handles lstvOfertas.ItemMouseDoubleClick
            Dim oferta As Ofertas = TryCast(e.Item.Tag, Ofertas)
            _ofertaselected = TryCast(e.Item.Tag, Ofertas)
            If IsNothing(oferta) Then
                CargarDatos(ExpresionFiltroActivo() & " AND idOferta == NULL")
            Else
                CargarDatos(ExpresionFiltroActivo() & " AND idOferta == " & oferta.idOferta)
            End If
        End Sub

#End Region

        Private Function NuevoNodo(ByVal familia As Familias, ByVal subnodos As RadTreeNode()) As RadTreeNode
            If IsNothing(familia) Then Throw New ArgumentNullException()
            Dim nodo As New RadTreeNode(familia.Familia, subnodos)
            nodo.Tag = familia
            nodo.AllowDrop = True            
            Return nodo
        End Function

        Private Function IsRealDrag(ByVal location As Point) As Boolean
            If Control.MouseButtons <> MouseButtons.Left Or _startDrag.Equals(Point.Empty) Then
                Return False
            End If
            If _startDrag = Point.Empty Then
                _startDrag = location
            Else
                Dim xOffset As Integer = Math.Abs(_startDrag.X - location.X)
                Dim yOffset As Integer = Math.Abs(_startDrag.Y - location.Y)
                If xOffset >= SystemInformation.DragSize.Width OrElse yOffset >= SystemInformation.DragSize.Height Then
                    Return True
                End If
            End If
            Return False
        End Function

        Private Sub ReestablecerListItem()
            If Not IsNothing(_previouItem) Then
                If IsNothing(_previouItem.Tag) Then
                    _previouItem.ForeColor = Color.Black
                Else
                    Dim vigente As Boolean? = TryCast(_previouItem.Tag, Ofertas).Vigente
                    If vigente.HasValue AndAlso vigente.Value = True Then
                        _previouItem.ForeColor = Color.Green
                    Else
                        _previouItem.ForeColor = Color.Black
                    End If
                End If
            End If
            _previouItem = Nothing
        End Sub

        Private Sub ReestablecerTreeNode()
            If Not IsNothing(_previouNode) Then _
                _previouNode.ContentElement.ForeColor = Color.Black
            _previouNode = Nothing
        End Sub

        Private Function GetContextMenu() As ContextMenuStrip
            Dim menu As New ContextMenuStrip()
            Dim mitem As ToolStripItem = menu.Items.Add(My.Resources.Application.TextoRecargar, My.Resources.arrow_refresh)
            AddHandler mitem.Click, AddressOf mitemRefrescar_Click
            Return (menu)
        End Function

    End Class

End Namespace
