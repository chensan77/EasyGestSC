﻿Imports EasyGest.Presentacion.Componente

Namespace Presentacion.Formulario

    Public Class frmInicio

        'Private _actionEncargo As System.Data.Linq.ChangeAction = System.Data.Linq.ChangeAction.None
        'Private _actionTarea As System.Data.Linq.ChangeAction = System.Data.Linq.ChangeAction.None
        Private _encargo As Encargos = Nothing
        Private _tarea As Tareas = Nothing

        Private Structure DatosInicio
            Dim Tareas As IEnumerable(Of VWTareas)
            Dim ListaCompra As IEnumerable(Of ListasCompra)
            Dim TotalVenta As Double?
            Dim TotalNumeroVenta As Integer?
            Dim CargarTarea As Boolean
            Dim CargarListaCompra As Boolean
            Dim TodasTareas As Boolean
            Dim FiltroListaCompra As String
        End Structure

#Region "Eventos FORM"
        Private Sub frmInicio_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
            If e.KeyCode = Keys.Insert And e.Control Then
                'nuevo item en la lista de compra
                If Not gridListaCompra.IsInEditMode Then
                    gridListaCompra.CurrentRow = gridListaCompra.MasterView.TableAddNewRow
                    gridListaCompra.CurrentRow.Cells(0).BeginEdit()
                End If
                e.Handled = True
            End If
            If e.KeyCode = Keys.Escape Then
                If gridListaCompra.IsInEditMode Then
                    gridListaCompra.CancelEdit()
                    gridListaCompra.MasterView.TableAddNewRow.CancelAddNewRow()
                End If
                e.Handled = True
            End If
        End Sub

        Private Sub frmInicio_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            AddHandler cbtoggleTodasTareas.ToggleStateChanged, AddressOf cbtoggleTodasTareas_ToggleStateChanged
            ConfigurarCommandBar(cbstripListasCompra)
            ConfigurarCommandBar(cbstripTarea)
            calCalendario.TodayButton.Font = gDefaultFont
            calCalendario.ClearButton.Font = gDefaultFont
            gridListaCompra.MasterTemplate.AddNewBoundRowBeforeEdit = True
            SplitPanel2.Collapsed = True
            SplitPanel4.Collapsed = True
            cbbtnEditarEncargo.Enabled = False
            ActualizarTimerInterval()
            For Each hora As Integer In Tareas.PosiblesHorasAntelacion
                Dim item As New RadListDataItem(CStr(hora) & " H", hora)
                item.ForeColor = ddlAviso.ForeColor
                item.Font = ddlAviso.Font
                ddlAviso.Items.Add(item)
            Next
            toolTarea.AutoHideSize = New System.Drawing.Size(500, 600)
            toolTarea.AutoHide()
            calCalendario.SelectedDate = Today
            Try
                Using control As New PrioridadesTareaController()
                    PrioridadesTareaBindingSource.DataSource = control.GetItems()
                End Using
                Dim dato As New DatosInicio()
                dato.CargarListaCompra = True
                dato.CargarTarea = True
                dato.TodasTareas = False ' = String.Format("Aviso <= DateTime({0}) AND FechaTarea >= DateTime({1})", Now.Ticks, Today.AddDays(-7).Ticks)
                dato.FiltroListaCompra = String.Format("FechaCreacion >= dateTime({0})", Today.AddDays(-7).Ticks)
                CargarDatos(dato)
            Catch ex As Exception

            End Try
        End Sub

        Private Sub frmInicio_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            wbwMeteo.Url = New Uri("file://" & My.Application.Info.DirectoryPath & "/Resources/MeteoWeb.htm")
            waitbDivisa.Visible = True
            waitbMeteo.Visible = True
            If Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("zh") Then
                wbwDivisa.Url = New Uri("file://" & My.Application.Info.DirectoryPath & "/Resources/DivisaWeb_ch.htm")
            Else
                wbwDivisa.Url = New Uri("file://" & My.Application.Info.DirectoryPath & "/Resources/DivisaWeb_es.htm")
            End If
        End Sub

#End Region

#Region "Refresco contenido"

        Private Sub timerRefrescoMeteo_Tick(sender As Object, e As System.EventArgs) Handles timerRefrescoMeteo.Tick
            If Not wbwMeteo.IsBusy Then _
                wbwMeteo.Refresh(WebBrowserRefreshOption.Completely)
        End Sub

        Private Sub timerRefrescoDivisa_Tick(sender As Object, e As System.EventArgs) Handles timerRefrescoDivisa.Tick
            If Not wbwMeteo.IsBusy Then _
                wbwDivisa.Refresh(WebBrowserRefreshOption.Completely)
        End Sub

        Friend Sub ActualizarTimerInterval()
            timerRefrescoDivisa.Stop()
            timerRefrescoInicio.Stop()
            timerRefrescoMeteo.Stop()

            timerRefrescoDivisa.Enabled = False
            timerRefrescoInicio.Enabled = False
            timerRefrescoMeteo.Enabled = False

            timerRefrescoDivisa.Interval = CInt(gConfLocal.PeriodoActualizacionDivisa)
            timerRefrescoInicio.Interval = CInt(gConfLocal.PeriodoActualizacionInicio)
            timerRefrescoMeteo.Interval = CInt(gConfLocal.PeriodoActualizacionMeteologia)

            timerRefrescoDivisa.Enabled = True
            timerRefrescoInicio.Enabled = True
            timerRefrescoMeteo.Enabled = True

            timerRefrescoDivisa.Start()
            timerRefrescoInicio.Start()
            timerRefrescoMeteo.Start()

        End Sub

        Private Sub ActualizarResumenVenta(ByRef numero As Integer?, ByRef total As Double?)
            If CajaCerrado Then
                numero = Nothing
                total = Nothing
            Else
                Try
                    Using control As New AlbaranesController()
                        control.ResumenVentaXPuestoUsuario(gEmpresa, gPuesto, gUsuario, gDiario.Apertura, numero, total)
                    End Using
                Catch ex As Exception
                    numero = Nothing
                    total = Nothing
                End Try
            End If
        End Sub

        Private Sub wbwDivisa_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbwDivisa.DocumentCompleted
            waitbDivisa.Visible = False
        End Sub

        Private Sub wbwMeteo_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbwMeteo.DocumentCompleted
            waitbMeteo.Visible = False
        End Sub

        Private Sub wbwDivisa_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles wbwDivisa.Navigating
            waitbDivisa.Visible = True
        End Sub

        Private Sub wbwMeteo_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles wbwMeteo.Navigating
            waitbMeteo.Visible = True
        End Sub

        Private Sub timerRefrescoInicio_Tick(sender As Object, e As EventArgs) Handles timerRefrescoInicio.Tick
            Dim dato As New DatosInicio()
            dato.CargarTarea = True
            dato.TodasTareas = cbtoggleTodasTareas.ToggleState = Enumerations.ToggleState.On
            CargarDatos(dato)
        End Sub
#End Region

#Region "Evento botones acciones"

        Private Sub cbtoggleTodasTareas_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
            Dim dato As New DatosInicio()
            dato.CargarTarea = True
            dato.TodasTareas = cbtoggleTodasTareas.ToggleState = Enumerations.ToggleState.On
            CargarDatos(dato)
        End Sub

        Private Sub cbbtnAgregarEncargo_Click(sender As Object, e As EventArgs) Handles cbbtnAgregarEncargo.Click
            If IsNothing(_encargo) Then
                EditarAgregarEncargo(-1L)
            End If
        End Sub

        Private Sub cbbtnAgregarTarea_Click(sender As Object, e As EventArgs) Handles cbbtnAgregarTarea.Click
            If IsNothing(_tarea) Then
                EditarAgregarTarea(-1L)
            End If
        End Sub

        Private Sub btnAceptarTarea_Click(sender As Object, e As EventArgs) Handles btnAceptarTarea.Click
            If _tarea.IsValid() Then
                Dim tarea As VWTareas = ActualizarTarea()
                If Not IsNothing(tarea) Then
                    'If Not HasEntityInBingdingSource(Me.TareasBindingSource, _tarea) Then
                    '    Me.TareasBindingSource.Add(tarea)
                    'End If
                    UpdateSelectGridRow(gridTareas, tarea)
                    ResetearTarea()
                End If
            End If
        End Sub

        Private Sub btnAceptarEncargo_Click(sender As Object, e As EventArgs) Handles btnAceptarEncargo.Click
            If _encargo.IsValid() Then
                Dim lista As ListasCompra
                lista = ActualizarEncargo()
                If Not IsNothing(lista) Then
                    'Me.ListasCompraBindingSource.DataSource
                    'If _actionEncargo = System.Data.Linq.ChangeAction.Insert Then
                    '    Me.ListasCompraBindingSource.Add(lista)
                    'End If
                    UpdateSelectGridRow(gridListaCompra, lista)
                    ResetearEncargo()
                End If
            End If
        End Sub

        Private Sub btnCancelarTarea_Click(sender As Object, e As EventArgs) Handles btnCancelarTarea.Click
            ResetearTarea()
        End Sub

        Private Sub btnCancelarEncargo_Click(sender As Object, e As EventArgs) Handles btnCancelarEncargo.Click
            ResetearEncargo()
        End Sub

        Private Sub cbbtnEditarTarea_Click(sender As Object, e As EventArgs) Handles cbbtnEditarTarea.Click
            If IsNothing(_tarea) Then
                Dim item As VWTareas = gridTareas.SelectedItem(Of VWTareas)()
                If IsNothing(item) Then
                    MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
                Else
                    EditarAgregarTarea(item.idTarea)
                End If
            End If
        End Sub

        Private Sub cbbtnEditarEncargo_Click(sender As Object, e As EventArgs) Handles cbbtnEditarEncargo.Click
            If IsNothing(_encargo) Then
                Dim item As ListasCompra = gridListaCompra.SelectedItem(Of ListasCompra)()
                If IsNothing(item) Then
                    MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
                Else
                    EditarAgregarEncargo(item.idEncargo.Value)
                End If
            End If
        End Sub

        Private Sub cbbtnEliminarTarea_Click(sender As Object, e As EventArgs) Handles cbbtnEliminarTarea.Click
            If IsNothing(_tarea) Then
                Dim item As List(Of VWTareas) = gridTareas.SelectedItems(Of VWTareas)()
                If item.Count = 0 Then
                    MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
                Else
                    If MostrarMensaje(My.Resources.Application.ConfirmacionBorrarDato, Me.Text, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        EliminarTarea(item)
                    End If
                End If
            End If
        End Sub

        Private Sub cbbtnImprimirLista_Click(sender As Object, e As EventArgs) Handles cbbtnImprimirLista.Click
            If gridListaCompra.RowCount > 0 Then
                Dim frm As New frmInformes()
                frm.ShowDialog(My.Forms.frmPrincipal)
            End If
        End Sub

        Private Sub mnitemReciente_Click(sender As Object, e As EventArgs) Handles mnitemReciente.Click
            Dim dato As New DatosInicio()
            dato.CargarListaCompra = True
            dato.FiltroListaCompra = String.Format("FechaCreacion >= dateTime({0})", Today.AddDays(-7).Ticks)
            CargarDatos(dato)
        End Sub

        Private Sub mnitemTodas_Click(sender As Object, e As EventArgs) Handles mnitemTodas.Click
            Dim dato As New DatosInicio()
            dato.CargarListaCompra = True
            dato.FiltroListaCompra = String.Empty
            CargarDatos(dato)
        End Sub

#End Region

#Region "Operaciones AED"

        Private Sub CargarDatos(dato As DatosInicio)
            If bgwInicio.IsBusy() Then Return
            If dato.CargarTarea Then waitbTareas.Visible = True
            bgwInicio.RunWorkerAsync(dato)
        End Sub

        Private Sub EliminarTarea(ByVal items As List(Of VWTareas))
            Try
                Using control As New TareasController
                    For Each tarea As VWTareas In items
                        control.DeleteItem(tarea.idTarea)
                        TareasBindingSource.Remove(tarea)
                    Next
                End Using
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub bgwInicio_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwInicio.DoWork
            System.Threading.Thread.CurrentThread.CurrentCulture = GetApplicationCulture(Me)
            Dim datos As New DatosInicio()
            datos = CType(e.Argument, DatosInicio)
            If datos.CargarTarea Then
                If datos.TodasTareas Then
                    Dim filtro As String
                    filtro = "idUsuario == " & gUsuario.idUsuario

                    Using c As New VistasController(Of VWTareas)()
                        datos.Tareas = c.GetItems(filtro, "FechaTarea")
                    End Using
                Else
                    Using c As New TareasController()
                        datos.Tareas = c.GetTareasRecientes(gConfGlobal.PeriodoObtencionTarea, gUsuario)
                    End Using
                End If
            End If

            If datos.CargarListaCompra Then
                Using c1 As New ListasCompraController()
                    Dim filtro As String = String.Empty
                    If Not String.IsNullOrEmpty(datos.FiltroListaCompra) Then filtro = datos.FiltroListaCompra
                    datos.ListaCompra = c1.GetItems(filtro, "FechaCreacion")
                End Using
            End If
            ActualizarResumenVenta(datos.TotalNumeroVenta, datos.TotalVenta)
            e.Result = datos
        End Sub

        Private Sub bgwInicio_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwInicio.RunWorkerCompleted
            If Not IsNothing(e.Error) Then
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
            Else
                Try
                    Dim datos As DatosInicio = CType(e.Result, Global.EasyGest.Presentacion.Formulario.frmInicio.DatosInicio)
                    If datos.CargarTarea Then
                        TareasBindingSource.DataSource = datos.Tareas
                    End If
                    If datos.CargarListaCompra Then
                        ListasCompraBindingSource.DataSource = datos.ListaCompra
                    End If
                    lblNumeroVenta.Text = String.Empty
                    lblTotalVenta.Text = String.Empty
                    If datos.TotalNumeroVenta.HasValue Then
                        lblNumeroVenta.Text = CStr(datos.TotalNumeroVenta.Value)
                    End If
                    If datos.TotalVenta.HasValue() Then
                        lblTotalVenta.Text = FormatCurrency(datos.TotalVenta.Value, 2)
                    End If
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
            waitbTareas.Visible = False
        End Sub

        Private Sub EditarAgregarTarea(id As Long)
            If id = -1 Then
                _tarea = TareasController.NewItem()
                _tarea.idUsuario = gUsuario.idUsuario
                TareaBindingSource.DataSource = _tarea
                dtpFechaTarea.MinDate = Today()
                SplitPanel4.Collapsed = False

                dtpFechaTarea.Focus()
            Else
                Try
                    Using c As New TareasController()
                        _tarea = c.GetItem(id)
                    End Using
                    If Not IsNothing(_tarea) Then
                        TareaBindingSource.DataSource = _tarea
                        dtpFechaTarea.MinDate = CDate(IIf(_tarea.FechaTarea.CompareTo(Today()) > 0, Today(), _tarea.FechaTarea))
                        SplitPanel4.Collapsed = False
                        dtpFechaTarea.Focus()
                    End If
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                    _tarea = Nothing
                End Try
            End If
        End Sub

        Private Sub EditarAgregarEncargo(id As Long)
            If id = -1 Then
                _encargo = EncargosController.NewItem()
                EncargoBindingSource.DataSource = _encargo
                SplitPanel2.Collapsed = False
                dtpRecogida.MinDate = Today()
                txtReferencia.Focus()
            Else
                Try
                    Using c As New EncargosController()
                        _encargo = c.GetItem(id)
                    End Using
                    If Not IsNothing(_encargo) Then
                        EncargoBindingSource.DataSource = _encargo
                        SplitPanel2.Collapsed = False
                        If _encargo.FechaRecogidaPrevista.HasValue Then
                            If _encargo.FechaRecogidaPrevista.Value.CompareTo(Today()) < 0 Then
                                dtpRecogida.MinDate = _encargo.FechaRecogidaPrevista.Value
                            Else
                                dtpRecogida.MinDate = Today
                            End If
                        Else
                            dtpRecogida.MinDate = Today
                        End If
                        txtReferencia.Focus()
                    End If
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                    _encargo = Nothing
                End Try
            End If
        End Sub

        Private Function ActualizarTarea() As VWTareas
            Dim tareaMod As VWTareas = Nothing
            Try
                If Not IsNothing(_tarea) Then
                    Using control As New TareasController()
                        control.SyncronisingItem(_tarea)
                    End Using
                    Using control As New VistasController(Of VWTareas)()
                        tareaMod = control.GetItem(_tarea.idTarea)
                    End Using
                End If
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                tareaMod = Nothing
            End Try
            Return tareaMod
        End Function

        Private Function ActualizarEncargo() As ListasCompra
            Dim lista As ListasCompra = Nothing
            Try
                Using c As New EncargosController()
                    c.SyncronisingItem(_encargo, lista)
                End Using

                'Buscar en la listascompra si encuentra el nuevo elemento
                Dim listas As IEnumerable(Of ListasCompra) = DirectCast(Me.ListasCompraBindingSource.DataSource, Global.System.Collections.Generic.IEnumerable(Of Global.EasyGestControllers.Data.Entity.ListasCompra))
                listas = listas.Where(Function(l As ListasCompra) l.idCompra.Equals(lista.idCompra))
                If listas.Count() = 0 Then
                    Me.ListasCompraBindingSource.Add(lista)
                End If

            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                lista = Nothing
            End Try
            Return lista
        End Function

#End Region

#Region "Eventos GRID"

        Private Sub gridListaCompra_SelectionChanged(sender As Object, e As EventArgs) Handles gridListaCompra.SelectionChanged
            If gridListaCompra.SelectedRows.Count > 0 Then
                Dim compra As ListasCompra = DirectCast(gridListaCompra.SelectedRows.First.DataBoundItem, ListasCompra)
                cbbtnEditarEncargo.Enabled = compra.EsEncargo
            End If
        End Sub

        Private Sub gridListaCompra_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gridListaCompra.ViewCellFormatting
            If TypeOf e.CellElement Is GridDataCellElement And e.RowIndex >= 0 Then
                Dim compra As ListasCompra = DirectCast(e.CellElement.RowInfo.DataBoundItem, ListasCompra)
                If e.Column.Name = "Descripcion" Or e.Column.Name = "Referencia" Or e.Column.Name = "Observacion" Then _
                    e.Row.Cells(e.ColumnIndex).ReadOnly = compra.EsEncargo
                If compra.FechaCreacion < Today.AddDays(-7) Then
                    e.CellElement.ForeColor = Color.Red
                End If
            End If
        End Sub

        Private Sub gridListaCompra_CellValidating(sender As Object, e As CellValidatingEventArgs) Handles gridListaCompra.CellValidating
            If IsNothing(e.Row) Or IsNothing(e.Column) Then Return

            If String.Equals(e.Column.Name, "Descripcion") And String.IsNullOrWhiteSpace(CStr(e.Value)) And Not TypeOf e.Row Is GridViewNewRowInfo Then
                e.Cancel = True
                e.Row.ErrorText = My.Resources.Application.TextoValorRequerido
            Else
                e.Row.ErrorText = String.Empty
            End If
        End Sub

        Private Sub gridListaCompra_CellValueChanged(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles gridListaCompra.CellValueChanged
            If e.RowIndex >= 0 Then
                Dim itemAMod As ListasCompra = DirectCast(e.Row.DataBoundItem, ListasCompra)
                Try
                    Using c As New ListasCompraController()
                        c.SyncronisingItem(itemAMod)
                    End Using
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
        End Sub

        Private Sub gridListaCompra_RowsChanging(sender As Object, e As GridViewCollectionChangingEventArgs) Handles gridListaCompra.RowsChanging
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Add Then
                Dim item As ListasCompra = DirectCast(e.GridViewTemplate.MasterViewInfo.CurrentRow.DataBoundItem, ListasCompra)
                If item Is Nothing Then
                    e.Cancel = True
                Else
                    If Not item.IsValid() Then
                        e.Cancel = True
                        gridListaCompra.CurrentRow = gridListaCompra.MasterView.TableAddNewRow
                        gridListaCompra.CurrentRow.Cells(0).BeginEdit()
                    Else
                        item.SetAsInsertOnSubmit()
                    End If
                    Try
                        Using c As New ListasCompraController()
                            c.SyncronisingItem(item)
                        End Using
                    Catch ex As Exception
                        e.Cancel = True
                        MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                    End Try
                End If
            End If
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
                If MostrarMensaje(My.Resources.Application.ConfirmacionBorrarDato, Me.Text, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim itemABorrar As List(Of ListasCompra) = New List(Of ListasCompra)()

                    For Each row As GridViewDataRowInfo In e.OldItems
                        If Not IsNothing(_encargo) AndAlso _encargo.idEncargo = DirectCast(row.DataBoundItem, ListasCompra).idEncargo Then
                            ResetearEncargo()
                        End If
                        Dim todelete As ListasCompra = DirectCast(row.DataBoundItem, ListasCompra)
                        todelete.SetAsDeleteOnSubmit()
                        itemABorrar.Add(todelete)
                    Next

                    Try
                        Using c As New ListasCompraController()
                            c.SyncronisingItem(itemABorrar.AsEnumerable())
                        End Using
                    Catch ex As Exception
                        e.Cancel = True
                        MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                    End Try
                End If
            End If
        End Sub

        Private Sub gridTareas_ViewRowFormatting(sender As Object, e As RowFormattingEventArgs) Handles gridTareas.ViewRowFormatting
            If TypeOf e.RowElement Is GridDataRowElement And e.RowElement.RowInfo.Index >= 0 Then
                Dim tarea As VWTareas = DirectCast(e.RowElement.RowInfo.DataBoundItem, VWTareas)
                e.RowElement.ForeColor = tarea.ColorPrioridad
            End If
        End Sub
#End Region

        Public Sub New()

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            PrepararControles(SplitPanel1.Controls)
            PrepararControles(SplitPanel2.Controls)
            PrepararControles(SplitPanel3.Controls)
            PrepararControles(SplitPanel4.Controls)
            SettingGridHeaderText(gridListaCompra, My.Resources.Application.GridHeaderTextListaInicio.Split(CARACTERSEPARADOR))
            SettingGridHeaderText(gridTareas, My.Resources.Application.GridHeaderTextTareaInicio.Split(CARACTERSEPARADOR))
            TryCast(Me.dtpFechaTarea.DateTimePickerElement.CurrentBehavior, RadDateTimePickerCalendar).ShowTimePicker = True
            TryCast(Me.dtpFechaTarea.DateTimePickerElement.CurrentBehavior, RadDateTimePickerCalendar).DropDownMinSize = New System.Drawing.Size(450, 330)
        End Sub

        Private Sub ResetearTarea()
            SplitPanel4.Collapsed = True
            TareaBindingSource.Clear()
            _tarea = Nothing
        End Sub

        Private Sub ResetearEncargo()
            SplitPanel2.Collapsed = True
            EncargoBindingSource.Clear()
            _encargo = Nothing
        End Sub

        Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
            Dim frm As Dialogo.frmBuscador
            frm = New Dialogo.frmBuscador(Dialogo.frmBuscador.ObjetoBusqueda.Producto)
            If frm.ShowDialog() = DialogResult.OK Then
                If Not IsNothing(frm.ObjetoEncontrado) Then
                    Dim producto As VWProductos = TryCast(frm.ObjetoEncontrado, VWProductos)
                    txtReferencia.Text = producto.Referencia
                    txtProducto.Text = producto.Descripcion

                End If
            End If
        End Sub

        Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
            Dim frm As Dialogo.frmBuscador
            frm = New Dialogo.frmBuscador(Dialogo.frmBuscador.ObjetoBusqueda.Cliente)
            If frm.ShowDialog() = DialogResult.OK Then
                If Not IsNothing(frm.ObjetoEncontrado) Then
                    Dim cliente As VWClientes = TryCast(frm.ObjetoEncontrado, VWClientes)
                    txtNombre.Text = cliente.NombreYNombreCN
                    txtTelefono.Text = cliente.Telefono

                End If
            End If
        End Sub
    End Class
End Namespace
