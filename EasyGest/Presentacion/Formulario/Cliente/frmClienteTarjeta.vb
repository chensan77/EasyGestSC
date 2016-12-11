Imports EasyGestControllers
Imports EasyGestControllers.Data
Imports EasyGest.Presentacion.Componente


Namespace Presentacion.Formulario.Cliente

    Public Class frmClienteTarjeta

        Private WithEvents cbBusqueda As Presentacion.Componente.CommandBarFilterItem

        'Private WithEvents bkwCarga As New Wi
        Private _panel As New WaitingPanel()
        Private _numregistro As Integer = 0
        Private _filtro As String = ""
        Private _filtropropietario As String = ""
        Private _orden As String = "NumeroTarjeta ASC"
        Private _idpropietario As Long = 0
        Private _diagnostico As Diagnostics.Stopwatch
        Private _propietariounico As Boolean = False
        Private _nombrepropietario As String = ""

        Friend Property MostrarAgregar As Boolean = False

        Public Sub New()

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            _diagnostico = New Diagnostics.Stopwatch()
        End Sub

#Region "Evento Form"
        Private Sub frmContacto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Controls.Add(_panel)
            _panel.BringToFront()
            PrepararControles(Me.Controls)
            ConfigurarBarraBusqueda()
            ConfigurarCommandBar(cbstripeAccion)
            ConfigurarCommandBar(Me.cbstripeBusqueda)
            gridDatos.AutoExpandGroups = True
            lbleDiagnostico.Text = ""
        End Sub

        Private Sub frmContacto_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            'Establecer Permisos
            cbbtnAgregar.Enabled = ((gUsuario.PermisoCliente And Permiso.Modificacion) = Permiso.Modificacion)
            cbbtnModificar.Enabled = ((gUsuario.PermisoCliente And Permiso.Modificacion) = Permiso.Modificacion)
            cbbtnEliminar.Enabled = ((gUsuario.PermisoCliente And Permiso.Modificacion) = Permiso.Modificacion)
            CargarDatos(_filtropropietario)
            If MostrarAgregar Then
                MostrarAgregar = False
                EditarAgregar(-1)
            End If

        End Sub
#End Region

#Region "Evento Grid"

        Private Sub gridDatos_DataBindingComplete(sender As Object, e As Telerik.WinControls.UI.GridViewBindingCompleteEventArgs) Handles gridDatos.DataBindingComplete
            If gridDatos.Rows.Count = 0 Then
                If MovimientosTarjetaBindingSource.Count > 0 Then MovimientosTarjetaBindingSource.Clear()
            End If
        End Sub

        Private Sub gridDatos_GroupSummaryEvaluate(sender As Object, e As Telerik.WinControls.UI.GroupSummaryEvaluationEventArgs) Handles gridDatos.GroupSummaryEvaluate
            If e.SummaryItem.Name.Equals("Cliente") Then
                Dim numTarjeta As Integer = 0
                Dim saldoValido As Single = 0.0
                For Each row As GridViewRowInfo In e.Group
                    If CBool(row.Cells("Activo").Value) = True Then
                        saldoValido += CSng(row.Cells("Saldo").Value)
                        numTarjeta += 1
                    End If
                Next
                e.FormatString = String.Format(My.Resources.Application.TextoGrupoTarjetaFidelidelizacion, e.Value, numTarjeta, saldoValido)
            End If
        End Sub

        Private Sub gridDatos_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles gridDatos.SelectionChanged
            If gridDatos.SelectedRows.Count = 0 Then
                If MovimientosTarjetaBindingSource.Count > 0 Then MovimientosTarjetaBindingSource.Clear()
            Else
                MovimientosTarjetaBindingSource.DataSource = CargarMovimientos(DirectCast(gridDatos.SelectedRows(0).DataBoundItem, VWTarjetasFidelizacion))
            End If
        End Sub

        Private Sub gridDatos_ViewCellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles gridDatos.ViewCellFormatting, gridMovimientos.ViewCellFormatting
            If TypeOf e.CellElement Is GridDataCellElement AndAlso e.Column.Name.Equals("Condicion") Then
                e.CellElement.Font = gDefaultFont
            End If
        End Sub

#End Region

#Region "Evento botones acciones"

        Private Sub cbbtnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnAgregar.Click
            EditarAgregar(-1)
        End Sub

        Private Sub cbbtnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnModificar.Click
            Dim item As VWTarjetasFidelizacion = gridDatos.SelectedItem(Of VWTarjetasFidelizacion)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                EditarAgregar(item.idTarjeta)
            End If
        End Sub

        Private Sub cbbtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbtnEliminar.Click
            Dim item As VWTarjetasFidelizacion = gridDatos.SelectedItem(Of VWTarjetasFidelizacion)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Eliminar(item.idTarjeta)
            End If
        End Sub


        Private Sub cbbtnRecargar_Click(sender As System.Object, e As System.EventArgs) Handles cbbtnRecargar.Click
            CargarDatos(_filtropropietario)
            cbBusqueda.ClearFilterText()
        End Sub

        Private Sub cbbtnEmitirVale_Click(sender As Object, e As System.EventArgs) Handles cbbtnEmitirVale.Click
            Dim item As VWTarjetasFidelizacion = gridDatos.SelectedItem(Of VWTarjetasFidelizacion)()
            If IsNothing(item) Then
                If TypeOf gridDatos.CurrentRow Is GridViewGroupRowInfo Then
                    Dim groupRow As GridViewGroupRowInfo = DirectCast(gridDatos.CurrentRow, GridViewGroupRowInfo)
                    If groupRow.HasChildRows() Then
                        item = DirectCast(groupRow.ChildRows(0).DataBoundItem, VWTarjetasFidelizacion)
                        EmisionVale(item.idCliente, True)
                    End If
                Else
                    MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
                End If
            Else
                EmisionVale(item.idTarjeta, False)
            End If
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

        Private Sub EditarAgregar(ByVal id As Long)
            Dim frm As frmClienteTarjetaEdicion
            Dim row As GridViewRowInfo
            Try
                frm = New frmClienteTarjetaEdicion(id, _idpropietario)
                frm.txtPropietario.Text = _nombrepropietario
                frm.PropietarioModificable = Not _propietariounico
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Dim tarjeta As Entity.VWTarjetasFidelizacion = frm.Tarjeta
                    If id = -1 Then
                        Me.VWTarjetasFidelizacionBindingSource.Add(tarjeta)
                    End If
                    row = UpdateSelectGridRow(gridDatos, tarjeta)
                    If row IsNot Nothing Then
                        MovimientosTarjetaBindingSource.DataSource = CargarMovimientos(tarjeta)
                    End If
                End If
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub bgwCarga_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarga.DoWork
            _diagnostico.Start()
            System.Threading.Thread.CurrentThread.CurrentCulture = GetApplicationCulture(Me)
            Using c As New Controller.VistasController(Of Entity.VWTarjetasFidelizacion)()
                Dim datos As IEnumerable(Of VWTarjetasFidelizacion)
                datos = c.GetItems(_filtro, _orden)
                _numregistro = datos.Count()
                e.Result = datos
            End Using
        End Sub

        Private Sub bgwCarga_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwCarga.RunWorkerCompleted
            _diagnostico.Stop()
            _panel.Ocultar()
            If Not IsNothing(e.Error) Then
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
            Else
                Try
                    VWTarjetasFidelizacionBindingSource.DataSource = e.Result
                    lbleDiagnostico.Text = String.Format(My.Resources.Application.TextoDiagnosticoConsulta, _numregistro, _diagnostico.Elapsed.Milliseconds)
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If

        End Sub

        Private Sub Eliminar(ByVal idSeleccionado As Long)
            If MostrarMensaje(My.Resources.Application.ConfirmacionBorrarDato, Me.Text, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Try
                    Using control As New TarjetasFidelizacionController
                        control.DeleteItem(idSeleccionado)
                    End Using
                    VWTarjetasFidelizacionBindingSource.RemoveCurrent()
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
        End Sub

        Private Function CargarMovimientos(tarjetasFidelizacion As VWTarjetasFidelizacion) As IEnumerable(Of MovimientosTarjeta)
            Try

                Using c As New MovimientosTarjetaController()
                    Return c.GetItemsBy("idTarjeta", New Long() {tarjetasFidelizacion.idTarjeta})
                End Using
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                Return New List(Of MovimientosTarjeta)()
            End Try
        End Function

        Private Sub EmisionVale(id As Long, deCliente As Boolean)
            Try
                Dim frm As New frmClienteTarjetaEmision(id, deCliente)
                Dim vales As List(Of VWVales)
                Dim tarjetasAux As List(Of VWTarjetasFidelizacion)
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    vales = frm.Vales
                    tarjetasAux = frm.Tarjetas
                    For Each t As VWTarjetasFidelizacion In tarjetasAux
                        UpdateSelectGridRow(gridDatos, t)
                    Next
                End If
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub
#End Region

#Region "Busqueda"

        Private Sub cbBusqueda_onFilter(ByVal sender As CommandBarFilterItem, ByVal e As FilterEventArgs) Handles cbBusqueda.onFilter
            gridDatos.FilterDescriptors.Clear()
            gridDatos.SortDescriptors.Clear()
            CargarDatos(CStr(IIf(String.IsNullOrWhiteSpace(_filtropropietario), "", _filtropropietario & " & ")) & e.FilterExpression)
        End Sub

        Private Sub ConfigurarBarraBusqueda()
            cbBusqueda = New Presentacion.Componente.CommandBarFilterItem(cbstripeBusqueda)
            If Not _propietariounico Then cbBusqueda.AddItemToFieldDDL(gridDatos.Columns("Cliente").HeaderText, "Cliente", "String")
            cbBusqueda.AddItemToFieldDDL(gridDatos.Columns("NumeroTarjeta").HeaderText, "NumeroTarjeta", "String")
            cbBusqueda.AddItemToFieldDDL(gridDatos.Columns("Fcreacion").HeaderText, "Fcreacion", "Date")
            cbBusqueda.Prepare("")
        End Sub

#End Region

        Public Sub New(propietario As VWClientes)

            Me.New()

            Me.Text &= " <" & propietario.Nombre & ">"
            _nombrepropietario = propietario.NombreYNombreCN
            _idpropietario = propietario.idCliente
            _filtropropietario &= "idCliente = " & _idpropietario
            _propietariounico = True
        End Sub

    End Class

End Namespace
