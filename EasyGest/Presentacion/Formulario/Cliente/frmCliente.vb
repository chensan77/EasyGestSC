Imports EasyGestControllers
Imports EasyGestControllers.Data
Imports EasyGest.Presentacion.Componente
Imports EasyGest.Presentacion.Formulario.Cuenta
Imports EasyGest.Presentacion.Formulario.Contacto


Namespace Presentacion.Formulario.Cliente

    Public Class frmCliente

        Private WithEvents cbBusqueda As Presentacion.Componente.CommandBarFilterItem
        Private WithEvents cbOrden As Presentacion.Componente.CommandBarSortItem
        'Private WithEvents bkwCarga As New Wi
        Private _panel As New WaitingPanel()
        Private _totalpage As Integer = 0
        Private _pagenumber As Integer = 0
        Private _subpagenumber As Integer = 0
        Private _numregistro As Integer = 0
        Private _filtro As String = ""
        Private _orden As String = "Nombre ASC"
        Private _paginar As Boolean = True
        Private _paginando As Boolean = False
        Private _diagnostico As Diagnostics.Stopwatch
        Private _pagebuttons As RadButtonElement()
        Private _btnbgcolors(3) As Color

        Public Sub New()

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            _diagnostico = New Diagnostics.Stopwatch()
            Me.Controls.Add(_panel)
            _panel.BringToFront()
            PrepararControles(pvpDetalle.Controls)
            PrepararControles(pvpOtro.Controls)
            PrepararControles(SplitPanel1.Controls)
            ConfigurarBarraBusqueda()
            ConfigurarBarraOrden()
            ConfigurarPaginacion()
            ConfigurarCommandBar(Me.cbstripeAccion)
            ConfigurarCommandBar(Me.cbstripeOrden)
            ConfigurarCommandBar(Me.cbstripeBusqueda)
        End Sub

#Region "Evento Form"

        Private Sub frmCliente_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            pvInfo.SelectedPage = pvpDetalle
            chkeNoActivos.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
            chkeNoActivos.Font = gDefaultFont
            chkePaginar.Font = gDefaultFont
            lbleDiagnostico.Text = ""
            lblAplicarImpInd.Text = String.Format(lblAplicarImpInd.Text, gConfGlobal.NombreImpuesto)
            AddHandler chkePaginar.ToggleStateChanged, AddressOf chkePaginar_ToggleStateChanged
        End Sub

        Private Sub frmCliente_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            'Establecer Permisos
            mitemAgregarContacto.Enabled = ((gUsuario.PermisoCliente And Permiso.Adicion) = Permiso.Adicion) Or ((gUsuario.PermisoProveedor And Permiso.Modificacion) = Permiso.Modificacion)
            mitemAgregarCuenta.Enabled = ((gUsuario.PermisoCliente And Permiso.Adicion) = Permiso.Adicion) Or ((gUsuario.PermisoProveedor And Permiso.Modificacion) = Permiso.Modificacion)
            mitemAgregarTarjeta.Enabled = ((gUsuario.PermisoCliente And Permiso.Adicion) = Permiso.Adicion) Or ((gUsuario.PermisoProveedor And Permiso.Modificacion) = Permiso.Modificacion)
            cbbtnAgregar.Enabled = ((gUsuario.PermisoCliente And Permiso.Adicion) = Permiso.Adicion)
            cbbtnModificar.Enabled = ((gUsuario.PermisoCliente And Permiso.Modificacion) = Permiso.Modificacion)
            cbbtnEliminar.Enabled = ((gUsuario.PermisoCliente And Permiso.Eliminacion) = Permiso.Eliminacion)
            cbbtnTarjetas.Visibility = DirectCast(IIf(gConfGlobal.UsarTarjetaFidelizacion, ElementVisibility.Visible, ElementVisibility.Collapsed), ElementVisibility)
            CargarDatos("Activo = True")
        End Sub

#End Region

#Region "Evento Grid"

        Private Sub gridDatos_DataBindingComplete(sender As Object, e As Telerik.WinControls.UI.GridViewBindingCompleteEventArgs) Handles gridDatos.DataBindingComplete
            If gridDatos.Rows.Count = 0 Then
                If VWClienteBindingSource.Current IsNot Nothing Then VWClienteBindingSource.RemoveCurrent()
            End If
        End Sub

        Private Sub gridDatos_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles gridDatos.SelectionChanged
            If gridDatos.SelectedRows.Count = 0 Then
                If VWClienteBindingSource.Current IsNot Nothing Then VWClienteBindingSource.RemoveCurrent()
            Else
                VWClienteBindingSource.DataSource = gridDatos.SelectedRows(0).DataBoundItem
            End If
        End Sub

        Private Sub gridDatos_ViewCellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles gridDatos.ViewCellFormatting
            If TypeOf e.CellElement Is GridDataCellElement AndAlso e.Column.Name.Equals("TipoIdentificacion") Then
                e.CellElement.Font = gDefaultFont
            End If
        End Sub

#End Region

#Region "Evento botones acciones"

        Private Sub cbbtnAgregar_Click(sender As Object, e As System.EventArgs) Handles cbbtnAgregar.Click
            EditarAgregar(-1)
        End Sub

        Private Sub cbbtnModificar_Click(sender As Object, e As System.EventArgs) Handles cbbtnModificar.Click
            Dim item As VWClientes = gridDatos.SelectedItem(Of VWClientes)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                EditarAgregar(item.idCliente)
            End If
        End Sub

        Private Sub cbbtnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles cbbtnEliminar.Click
            Dim item As VWClientes = gridDatos.SelectedItem(Of VWClientes)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Eliminar(item.idCliente)
            End If
        End Sub

        Private Sub chkeNoActivos_ToggleStateChanged(sender As System.Object, e As System.EventArgs) Handles chkeNoActivos.ToggleStateChanged
            gridDatos.FilterDescriptors.Clear()
            CargarDatos(ExpresionFiltroActivo())
        End Sub

        Private Sub cbbtnCobros_Click(sender As Object, e As System.EventArgs) Handles cbbtnCobros.Click
            _panel.Mostrar("Probar")
        End Sub

        Private Sub cbbtnTarjetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbtnTarjetas.Click
            cbbtnTarjetas.DropDownMenu.ClosePopup(RadPopupCloseReason.ParentClosed)
            Dim item As VWClientes = gridDatos.SelectedItem(Of VWClientes)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Dim frm As New frmClienteTarjeta(item)
                My.Forms.frmPrincipal.AddForm(frm, True)
            End If
        End Sub

        Private Sub btnmAgregarTarjeta_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            MsgBox("agregar tarjeta")
        End Sub

        Private Sub cbbtnContactos_Click(sender As Object, e As System.EventArgs) Handles cbbtnContactos.Click
            cbbtnContactos.DropDownMenu.ClosePopup(RadPopupCloseReason.ParentClosed)
            Dim item As VWClientes = gridDatos.SelectedItem(Of VWClientes)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Dim frm As New frmContacto(item)
                My.Forms.frmPrincipal.AddForm(frm, True)
            End If
        End Sub

        Private Sub cbbtnCuentas_Click(sender As Object, e As System.EventArgs) Handles cbbtnCuentas.Click
            cbbtnCuentas.DropDownMenu.ClosePopup(RadPopupCloseReason.AppFocusChange)
            Dim item As VWClientes = gridDatos.SelectedItem(Of VWClientes)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Dim frm As New frmCuenta(item)
                My.Forms.frmPrincipal.AddForm(frm, True)
            End If
        End Sub

        Private Sub mitemAgregarContacto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mitemAgregarContacto.Click
            Dim item As VWClientes = gridDatos.SelectedItem(Of VWClientes)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Dim frm As New frmContacto(item)
                frm.MostrarAgregar = True
                My.Forms.frmPrincipal.AddForm(frm, True)
            End If
        End Sub

        Private Sub mitemAgregarCuenta_Click(sender As Object, e As System.EventArgs) Handles mitemAgregarCuenta.Click
            Dim item As VWClientes = gridDatos.SelectedItem(Of VWClientes)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Dim frm As New frmCuenta(item)
                frm.MostrarAgregar = True
                My.Forms.frmPrincipal.AddForm(frm, True)
            End If
        End Sub

        Private Sub mitemAgregarTarjeta_Click(sender As Object, e As System.EventArgs) Handles mitemAgregarTarjeta.Click
            Dim item As VWClientes = gridDatos.SelectedItem(Of VWClientes)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Dim frm As New frmClienteTarjeta(item)
                frm.MostrarAgregar = True
                My.Forms.frmPrincipal.AddForm(frm, True)
            End If
        End Sub
#End Region

#Region "Operaciones AED"

        Private Sub CargarDatos(filtro As String)
            If bgwCarga.IsBusy() Then Return
            _filtro = filtro
            _panel.Mostrar()
            _diagnostico.Reset()
            bgwCarga.RunWorkerAsync()
        End Sub

        Private Sub bgwCarga_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarga.DoWork
            _diagnostico.Start()
            System.Threading.Thread.CurrentThread.CurrentCulture = GetApplicationCulture(Me)
            Using c As New Controller.VistasController(Of Entity.VWClientes)()
                Dim datos As IEnumerable(Of VWClientes)
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

        Private Sub bgwCarga_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwCarga.RunWorkerCompleted
            _panel.Ocultar()
            If Not IsNothing(e.Error) Then
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
            Else
                Try
                    VWClientesBindingSource.DataSource = e.Result
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
            Dim frm As frmClienteEdicion
            Dim row As GridViewRowInfo
            Try

                frm = New frmClienteEdicion(id)
                If frm.ShowDialog(My.Forms.frmPrincipal) = Windows.Forms.DialogResult.OK Then
                    Dim cliente As Entity.VWClientes = frm.Cliente
                    If id = -1 Then
                        Me.VWClientesBindingSource.Add(cliente)
                    End If
                    row = UpdateSelectGridRow(gridDatos, cliente)
                    If Not IsNothing(row) Then
                        VWClienteBindingSource.DataSource = row.DataBoundItem
                    End If
                End If
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub Eliminar(ByVal idSeleccionado As Long)
            If MostrarMensaje(My.Resources.Application.ConfirmacionBorrarDato, Me.Text, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Try
                    Using control As New ClientesController
                        control.DeleteItem(idSeleccionado)
                    End Using
                    VWClientesBindingSource.RemoveCurrent()
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
        End Sub

        Private Function ExpresionFiltroActivo() As String
            Return String.Format("Activo = {0}", IIf(chkeNoActivos.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On, "False", "True"))
        End Function

#End Region

#Region "Busqueda"

        Private Sub ConfigurarBarraBusqueda()
            cbBusqueda = New Presentacion.Componente.CommandBarFilterItem(cbstripeBusqueda)
            cbBusqueda.AddItemToFieldDDL(My.Resources.Application.TextoNombre, "Nombre", "String")
            cbBusqueda.AddItemToFieldDDL(My.Resources.Application.TextoCodigo, "Codigo", "String")
            cbBusqueda.AddItemToFieldDDL(My.Resources.Application.TextoIdentificacion, "Identificacion", "String")
            cbBusqueda.AddItemToFieldDDL(My.Resources.Application.TextoFechaCreacion, "FCreacion", "Date")
            cbBusqueda.Prepare("")
        End Sub

        Private Sub cbBusqueda_onFilter(sender As Presentacion.Componente.CommandBarFilterItem, e As Presentacion.Componente.FilterEventArgs) Handles cbBusqueda.onFilter
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
            cbOrden.AddItemToFieldDDL(My.Resources.Application.TextoNombre, "Nombre")
            cbOrden.AddItemToFieldDDL(My.Resources.Application.TextoCodigo, "Codigo")
            cbOrden.AddItemToFieldDDL(My.Resources.Application.TextoIdentificacion, "Identificacion")
            cbOrden.Prepare("")
        End Sub

#End Region

#Region "Paginacion"

        Private Sub btneAnterior_Click(sender As Object, e As System.EventArgs) Handles btneAnterior.Click
            If 0 < _pagenumber Then
                MoverPagina(-1)
            End If
        End Sub

        Private Sub btneSiguiente_Click(sender As Object, e As System.EventArgs) Handles btneSiguiente.Click
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

        Private Sub MoverPagina(sentido As Integer)
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

        Private Sub MostrarBotonesPaginacion(numbtnamostrar As Integer)
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

        Private Sub btnePage_Click(sender As Object, e As System.EventArgs)
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


    End Class

End Namespace
