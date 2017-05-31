Imports EasyGestControllers
Imports EasyGestControllers.Data
Imports EasyGest.Presentacion.Componente


Namespace Presentacion.Formulario.CompraVenta

    Public Class frmVale

        Private WithEvents cbFiltro As Presentacion.Componente.CommandBarFilterItem
        'Private WithEvents bkwCarga As New Wi
        Private _panel As New WaitingPanel()
        Private _numregistro As Integer = 0
        Private _filtro As String = ""
        Private _orden As String = "FEmision DESC"
        Private _diagnostico As Diagnostics.Stopwatch

#Region "Evento Form"
        Private Sub frmContacto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Controls.Add(_panel)
            _panel.BringToFront()
            PrepararControles(Me.Controls)
            ConfigurarBarraFiltro()
            ConfigurarCommandBar(cbstripeAccion)
            ConfigurarCommandBar(Me.cbstripeFiltro)
            gridDatos.MasterTemplate.AutoExpandGroups = True
            gridValeNoVigente.MasterTemplate.AutoExpandGroups = True
            lbleDiagnostico.Text = ""
        End Sub

        Private Sub frmContacto_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            'Establecer Permisos
            Dim perm As Integer = 0
            perm = gUsuario.PermisoVenta

            cbbtnAgregar.Enabled = ((perm And Permiso.Modificacion) = Permiso.Modificacion)
            cbbtnEliminar.Enabled = ((perm And Permiso.Modificacion) = Permiso.Modificacion)
            cbbtnDesactivar.Enabled = ((perm And Permiso.Modificacion) = Permiso.Modificacion)
            cbbtnReactivar.Enabled = ((perm And Permiso.Modificacion) = Permiso.Modificacion)
            CargarDatos(_filtro, False)

        End Sub
#End Region

#Region "Evento Grid"


        Private Sub grid_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles gridValeNoVigente.CellFormatting, gridDatos.CellFormatting
            If Not IsNothing(e.Row.DataBoundItem) Then
                If e.Column.Name = "Importe" Then
                    Dim vale As VWVales = DirectCast(e.Row.DataBoundItem, VWVales)
                    If vale.EsPunto Then
                        e.CellElement.Text = String.Format("{0:N2} P", e.CellElement.Value)
                    Else
                        e.CellElement.Text = String.Format("{0:C2}", e.CellElement.Value)
                    End If
                End If
            End If
        End Sub

#End Region

#Region "Evento botones acciones"

        Private Sub cbbtnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnAgregar.Click
            EditarAgregar()
        End Sub

        Private Sub cbbtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbtnEliminar.Click
            Dim item As VWVales = gridValeNoVigente.SelectedItem(Of VWVales)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Eliminar(item.idVale)
            End If
        End Sub

        Private Sub cbbtnDesactivar_Click(sender As Object, e As EventArgs) Handles cbbtnDesactivar.Click
            Dim item As VWVales = gridDatos.SelectedItem(Of VWVales)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                ActivarDesactivarVales(item, False)
            End If
        End Sub

        Private Sub cbbtnReactivar_Click(sender As Object, e As EventArgs) Handles cbbtnReactivar.Click
            Dim item As VWVales = gridValeNoVigente.SelectedItem(Of VWVales)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                ActivarDesactivarVales(item, True)
            End If
        End Sub

        Private Sub cbbtnImprimir_Click(sender As Object, e As EventArgs) Handles cbbtnImprimir.Click
            Dim vale As VWVales = gridDatos.SelectedItem(Of VWVales)()
            Dim setting As EasyGest.Print.Printing.PrinterSettings
            Dim th As Threading.Thread
            Dim ts As Threading.ParameterizedThreadStart
            Dim tarea As New Print.Printing.PrintJobs()
            Dim spool As Print.Printing.SpoolPrinter
            If IsNothing(vale) Then Return
            setting = New Print.Printing.PrinterSettings()
            setting.PrinterCodePage = Print.Codepage8.Windows_1252
            setting.PrinterLanguaje = "OPOS"
            setting.PrinterName = gConfLocal.ImpresoraTicket
            setting.SupportCutter = gConfLocal.UsarCuchilloCorteImpresora
            setting.CharacterNumberPerLine = gConfLocal.ImpresoraTicketNumCaracteres
            spool = New Print.Printing.SpoolPrinter(setting)
            tarea.Printer = spool
            tarea.SetErrorDelgate(ImpresionErroCallBack)
            Try
                ts = New Threading.ParameterizedThreadStart(AddressOf tarea.PrintVale)
                th = New Threading.Thread(ts)
                th.Start(New Object() {vale, gEmpresa})
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorNoImprimir, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub
#End Region

#Region "Operaciones AED"

        Private Sub CargarDatos(ByVal filtro As String, soloVigentes As Boolean)
            If bgwCarga.IsBusy() Then Return
            _filtro = filtro
            _panel.Mostrar()
            _diagnostico.Reset()
            bgwCarga.RunWorkerAsync(soloVigentes)
        End Sub

        Private Sub EditarAgregar()
            Dim frm As frmValeEdicion
            'Dim row As GridViewRowInfo
            Try
                frm = New frmValeEdicion()

                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Dim vale As Entity.VWVales = frm.Vales
                    Me.VWValesBindingSource.Add(vale)

                    UpdateSelectGridRow(gridDatos, vale)
                End If
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub bgwCarga_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarga.DoWork
            _diagnostico.Start()
            System.Threading.Thread.CurrentThread.CurrentCulture = GetApplicationCulture(Me)
            Dim soloVigente As Boolean = CBool(e.Argument)
            Using c As New Controller.VistasController(Of Entity.VWVales)()
                Dim datos As List(Of VWVales)()
                Dim valeVigente, valeNoVigente As List(Of VWVales)
                valeVigente = c.GetItems("Activo == True", _orden).ToList()
                If Not soloVigente Then
                    valeNoVigente = c.GetItems("Activo == False", _orden).ToList()
                    datos = New List(Of VWVales)() {valeVigente, valeNoVigente}
                Else
                    datos = New List(Of VWVales)() {valeVigente}
                End If

                _numregistro = valeVigente.Count()
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
                    Dim source As List(Of VWVales)() = DirectCast(e.Result, List(Of VWVales)())
                    VWValesBindingSource.DataSource = source(0)
                    If source.Length > 1 Then VWValesNoVigenteBindingSource.DataSource = source(1)
                    lbleDiagnostico.Text = String.Format(My.Resources.Application.TextoDiagnosticoConsulta, _numregistro, _diagnostico.Elapsed.Milliseconds)
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If

        End Sub

        Private Sub Eliminar(ByVal idSeleccionado As Long)
            If MostrarMensaje(My.Resources.Application.ConfirmacionBorrarDato, Me.Text, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Try
                    Using control As New ContactosController
                        control.DeleteItem(idSeleccionado)
                    End Using
                    VWValesNoVigenteBindingSource.RemoveCurrent()
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
        End Sub

        Private Sub ActivarDesactivarVales(vale As VWVales, activo As Boolean)
            Dim mensaje As String
            mensaje = CType(IIf(activo, My.Resources.Application.ConfirmacionReactivarVale, My.Resources.Application.ConfirmacionCancelarVale), String)
            mensaje = String.Format(mensaje, vale.Numero, IIf(vale.EsPunto, vale.Importe & " P", FormatCurrency(vale.Importe, 2)))
            If MostrarMensaje(mensaje, Me.Text, RadMessageIcon.Question, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    vale.Activo = activo
                    vale.FCancelacion = CType(IIf(activo, Nothing, Today), Date?)
                    If activo Then
                        Using control As New ValesController
                            control.ReactivarVale(vale.idVale)
                        End Using
                        VWValesNoVigenteBindingSource.RemoveCurrent()
                        VWValesBindingSource.Add(vale)
                        UpdateSelectGridRow(gridDatos, vale)
                    Else
                        Using control As New ValesController
                            control.CancelarVale(vale.idVale)
                        End Using
                        VWValesBindingSource.RemoveCurrent()
                        VWValesNoVigenteBindingSource.Add(vale)
                        UpdateSelectGridRow(gridValeNoVigente, vale)
                    End If

                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
        End Sub
#End Region

#Region "Busqueda"

        Private Sub cbBusqueda_onFilter(sender As Presentacion.Componente.CommandBarFilterItem, e As Presentacion.Componente.FilterEventArgs) Handles cbFiltro.onFilter
            If Not String.IsNullOrWhiteSpace(e.FilterExpression) And Not bgwCarga.IsBusy() Then
                gridDatos.FilterDescriptors.Clear()
                CargarDatos(e.FilterExpression, True)
            End If
        End Sub

        Private Sub ConfigurarBarraFiltro()
            cbFiltro = New Presentacion.Componente.CommandBarFilterItem(cbstripeFiltro)
            cbFiltro.AddItemToFieldDDL(gridDatos.Columns("Numero").HeaderText, "Numero", "String")
            cbFiltro.AddItemToFieldDDL(gridDatos.Columns("FEmision").HeaderText, "FEmision", "Date")
            cbFiltro.AddItemToFieldDDL(gridDatos.Columns("Cliente").HeaderText, "Nombre", "String")
            cbFiltro.Prepare("")
        End Sub

#End Region

        Public Sub New()

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            _diagnostico = New Diagnostics.Stopwatch()

        End Sub


    End Class

End Namespace
