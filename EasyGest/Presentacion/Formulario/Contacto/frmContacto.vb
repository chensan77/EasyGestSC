Imports EasyGestControllers
Imports EasyGestControllers.Data
Imports EasyGest.Presentacion.Componente


Namespace Presentacion.Formulario.Contacto

    Public Class frmContacto

        Private WithEvents cbOrden As Presentacion.Componente.CommandBarSortItem
        'Private WithEvents bkwCarga As New Wi
        Private _panel As New WaitingPanel()
        Private _numregistro As Integer = 0
        Private _filtro As String = ""
        Private _orden As String = "Nombre ASC"
        Private _tipo As Char
        Private _idpropietario As Long = 0
        Private _diagnostico As Diagnostics.Stopwatch
        Private _propietariounico As Boolean = False
        Private _nombrepropietario As String = ""

        Friend Property MostrarAgregar As Boolean = False

        #Region "Evento Form"
        Private Sub frmContacto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Controls.Add(_panel)
            _panel.BringToFront()
            PrepararControles(Me.Controls)
            ConfigurarBarraOrden()
            ConfigurarCommandBar(cbstripeAccion)
            ConfigurarCommandBar(Me.cbstripeOrden)
            lbleDiagnostico.Text = ""
        End Sub

        Private Sub frmContacto_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            'Establecer Permisos
            Dim perm As Integer = 0
            If _tipo = Util.Comunes.TIPO_PROPIETARIO_PROVEEDOR Then
                perm = gUsuario.PermisoProveedor
            End If
            If _tipo = Util.Comunes.TIPO_PROPIETARIO_CLIENTE Then
                perm = gUsuario.PermisoCliente
            End If
            cbbtnAgregar.Enabled = ((perm And Permiso.Modificacion) = Permiso.Modificacion)
            cbbtnModificar.Enabled = ((perm And Permiso.Modificacion) = Permiso.Modificacion)
            cbbtnEliminar.Enabled = ((perm And Permiso.Modificacion) = Permiso.Modificacion)
            CargarDatos(_filtro)


            If MostrarAgregar Then
                MostrarAgregar = False
                EditarAgregar(-1)
            End If

        End Sub
        #End Region

#Region "Evento Grid"

        Private Sub gridDatos_ViewCellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles gridDatos.ViewCellFormatting
            If TypeOf e.CellElement Is GridDataCellElement AndAlso e.Column.Name.Equals("FormaContacto") Then
                e.CellElement.Font = gDefaultFont
            End If
        End Sub

#End Region

        #Region "Evento botones acciones"

        Private Sub cbbtnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnAgregar.Click
            EditarAgregar(-1)
        End Sub

        Private Sub cbbtnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnModificar.Click
            Dim item As VWContactos = gridDatos.SelectedItem(Of VWContactos)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                EditarAgregar(item.idContacto)
            End If
        End Sub

        Private Sub cbbtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbtnEliminar.Click
            Dim item As VWContactos = gridDatos.SelectedItem(Of VWContactos)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Eliminar(item.idContacto)
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

        Private Function ExpresionFiltroActivo() As String
            Return String.Empty
        End Function

        Private Sub EditarAgregar(ByVal id As Long)
            Dim frm As frmContactoEdicion
            'Dim row As GridViewRowInfo
            Try
                frm = New frmContactoEdicion(id, _tipo, _idpropietario)
                frm.txtPropietario.Text = _nombrepropietario
                frm.PropietarioModificable = Not _propietariounico
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Dim contacto As Entity.VWContactos = frm.Contacto
                    If id = -1 Then
                        Me.VWContactosBindingSource.Add(contacto)                    
                    End If
                    UpdateSelectGridRow(gridDatos, contacto)                    
                End If
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub bgwCarga_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarga.DoWork
            _diagnostico.Start()
            System.Threading.Thread.CurrentThread.CurrentCulture = GetApplicationCulture(Me)
            Using c As New Controller.VistasController(Of Entity.VWContactos)()
                Dim datos As IEnumerable(Of VWContactos)
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
                    VWContactosBindingSource.DataSource = e.Result
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
                    VWContactosBindingSource.RemoveCurrent()
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
        End Sub

        #End Region

        #Region "Ordenacion"

        Private Sub cbOrden_onSort(ByVal sender As CommandBarSortItem, ByVal e As SortEventArgs) Handles cbOrden.onSort
            gridDatos.FilterDescriptors.Clear()
            gridDatos.SortDescriptors.Clear()
            _orden = e.SortExpression
            CargarDatos(ExpresionFiltroActivo() & _filtro)
        End Sub

        Private Sub ConfigurarBarraOrden()
            Dim literalpropietario As String = String.Empty            
            If _tipo = Util.Comunes.TIPO_PROPIETARIO_CLIENTE Then
                literalpropietario = My.Resources.Application.TextoCliente
            End If
            If _tipo = Util.Comunes.TIPO_PROPIETARIO_PROVEEDOR Then
                literalpropietario = My.Resources.Application.TextoProveedor
            End If
            cbOrden = New Presentacion.Componente.CommandBarSortItem(cbstripeOrden)
            cbOrden.AddItemToFieldDDL(literalpropietario, "Nombre")
            cbOrden.AddItemToFieldDDL(gridDatos.Columns("FormaContacto").HeaderText, "FormaContactoEsp")
            cbOrden.AddItemToFieldDDL(gridDatos.Columns("DatoContacto").HeaderText, "DatoContacto")
            cbOrden.Prepare("")
        End Sub

        #End Region

        Public Sub New(tipopropietario As Char)

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            _diagnostico = New Diagnostics.Stopwatch()
            If Char.IsLetter(tipopropietario) Then
                _filtro = String.Format("TipoPropietario = '{0}'", tipopropietario)
                _tipo = tipopropietario
                If tipopropietario.Equals(Util.Comunes.TIPO_PROPIETARIO_CLIENTE) Then
                    gridDatos.Columns("Propietario").HeaderText = My.Resources.Application.TextoCliente
                    Me.Text = String.Format(Me.Text, My.Resources.Application.TextoCliente)
                End If
                If tipopropietario.Equals(Util.Comunes.TIPO_PROPIETARIO_PROVEEDOR) Then
                    gridDatos.Columns("Propietario").HeaderText = My.Resources.Application.TextoProveedor
                    Me.Text = String.Format(Me.Text, My.Resources.Application.TextoProveedor)
                End If
            End If
        End Sub

        Public Sub New(propietario As VWClientes)
            Me.New(Util.Comunes.TIPO_PROPIETARIO_CLIENTE)
            If Not IsNothing(propietario) Then
                Me.Text &= " <" & propietario.Nombre & ">"
                _nombrepropietario = propietario.NombreYNombreCN
                _idpropietario = propietario.idCliente
                _filtro &= " and " & "idPropietario = " & _idpropietario
                _propietariounico = True
            End If
        End Sub

        Public Sub New(propietario As VWProveedores)
            Me.New(Util.Comunes.TIPO_PROPIETARIO_PROVEEDOR)
            If Not IsNothing(propietario) Then
                Me.Text &= " <" & propietario.Nombre & ">"
                _nombrepropietario = propietario.NombreYNombreCN
                _idpropietario = propietario.idProveedor
                _filtro &= " and " & "idPropietario = " & _idpropietario
                _propietariounico = True
            End If
        End Sub

    End Class

End Namespace
