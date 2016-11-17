Imports EasyGestControllers
Imports EasyGestControllers.Data
Imports EasyGest.Presentacion.Componente


Namespace Presentacion.Formulario.Configuracion

    Public Class frmUsuario

        Private WithEvents cbOrden As Presentacion.Componente.CommandBarSortItem
        'Private WithEvents bkwCarga As New Wi
        Private _panel As New WaitingPanel()
        Private _orden As String = "Nombre ASC"
        Private _usuario As Entity.Usuarios = Nothing

#Region "Evento Form"

        Private Sub frmUsuario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ConfigurarBarraOrden()
            ConfigurarCommandBar(cbstripeAccion)
            ConfigurarCommandBar(Me.cbstripeOrden)
            SplitPanel2.Collapsed = True
            btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
            Try
                ' cargar los informes

            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub frmUsuario_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            CargarDatos()
        End Sub

        Private Sub frmUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
            If e.KeyChar = Convert.ToChar(27) And ControlBox = True Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If
        End Sub

#End Region

#Region "Evento Grid"

        Private Sub gridDatos_SelectionChanged(sender As Object, e As EventArgs) Handles gridDatos.SelectionChanged
            If gridDatos.SelectedRows.Count > 0 Then
                Dim usu As Usuarios = DirectCast(gridDatos.SelectedRows(0).DataBoundItem, Usuarios)
                cbbtnEliminar.Enabled = Not usu.IsSuper
                cbbtnModificar.Enabled = Not usu.IsSuper Or (usu.IsSuper And gUsuario.IsSuper)
            End If
        End Sub

        Private Sub gridDatos_RowFormatting(sender As Object, e As Telerik.WinControls.UI.RowFormattingEventArgs) Handles gridDatos.RowFormatting
            If Not TypeOf e.RowElement Is GridFilterRowElement And Not TypeOf e.RowElement Is GridTableHeaderRowElement Then
                Dim usu As Usuarios = DirectCast(e.RowElement.Data.DataBoundItem, Usuarios)
                If Not usu.Activo Then
                    e.RowElement.ForeColor = Color.Red
                Else
                    e.RowElement.ForeColor = gridDatos.GridViewElement.ForeColor
                End If
                If usu.IsSuper Then
                    e.RowElement.ForeColor = Color.ForestGreen
                End If
            End If
        End Sub

#End Region

#Region "Evento Botones Acciones"

        Private Sub cbbtnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnAgregar.Click
            txtNombre.ReadOnly = False
            txtNombreSesion.ReadOnly = False
            chkActivo.ReadOnly = False
            grpbPermiso.Enabled = True
            EditarAgregar(-1)
        End Sub

        Private Sub cbbtnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnModificar.Click
            Dim item As Usuarios = gridDatos.SelectedItem(Of Usuarios)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                txtNombre.ReadOnly = item.IsSuper
                txtNombreSesion.ReadOnly = item.IsSuper
                chkActivo.ReadOnly = item.IsSuper
                grpbPermiso.Enabled = Not item.IsSuper
                EditarAgregar(item.idUsuario)
            End If
        End Sub

        Private Sub cbbtnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnEliminar.Click
            Dim item As Usuarios = gridDatos.SelectedItem(Of Usuarios)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Eliminar(item.idusuario)
            End If
        End Sub

#End Region

#Region "Eventos"

        Private Sub timValidar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timValidar.Tick
            btnAceptar.Enabled = _usuario.IsValid()
        End Sub

#End Region

#Region "Operaciones ARD"

        Private Sub CargarDatos()
            If bgwCarga.IsBusy() Then Return
            _panel.Mostrar()
            bgwCarga.RunWorkerAsync()
        End Sub

        Private Sub EditarAgregar(ByVal id As Long)
            If id = -1 Then
                _usuario = Controller.UsuariosController.NewItem()
            Else
                Using c As New Controller.UsuariosController()
                    _usuario = c.GetItem(id)
                End Using
            End If
            UsuarioBindingSource.DataSource = _usuario
            ChequearPermiso(_usuario)
            timValidar.Enabled = True
            SplitPanel2.Collapsed = False
            SplitPanel1.Collapsed = True
            btnAceptar.Enabled = False
            cbstripeAccion.Enabled = False
            cbstripeOrden.Enabled = False
            txtNombreSesion.Focus()
        End Sub

        Private Sub Eliminar(ByVal idSeleccionado As Long)
            If MostrarMensaje(My.Resources.Application.ConfirmacionBorrarDato, Me.Text, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Try
                    Using control As New UsuariosController
                        control.DeleteItem(idSeleccionado)
                    End Using
                    UsuariosBindingSource.RemoveCurrent()
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            _usuario = Nothing
            SplitPanel2.Collapsed = True
            SplitPanel1.Collapsed = False
            timValidar.Enabled = False
            cbstripeAccion.Enabled = True
            cbstripeOrden.Enabled = True
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            Try
                GuardarPermiso(_usuario)
                Using control As New UsuariosController()
                    'If _action = System.Data.Linq.ChangeAction.Insert Then
                    '    _usuario = control.AddItem(_usuario)
                    '    Me.UsuariosBindingSource.Add(_usuario)
                    'ElseIf _action = System.Data.Linq.ChangeAction.Update Then
                    '    _usuario = control.UpdateItem(_usuario)
                    'Else
                    '    Exit Sub
                    'End If
                    Dim esNuevo As Boolean = _usuario.LINQEntityState = EntityState.New
                    _usuario = control.SaveItem(_usuario)
                    If esNuevo Then Me.UsuariosBindingSource.Add(_usuario)
                End Using

                UpdateSelectGridRow(gridDatos, _usuario)

                SplitPanel2.Collapsed = True
                SplitPanel1.Collapsed = False
                timValidar.Enabled = False
                cbstripeAccion.Enabled = True
                cbstripeOrden.Enabled = True
                If _usuario.idUsuario.Equals(gUsuario.idUsuario) Then
                    If Not String.Equals(_usuario.Apariencia, gUsuario.Apariencia, StringComparison.OrdinalIgnoreCase) Then
                        AsignarTemaAplicacion(_usuario.Apariencia)
                    End If
                    gUsuario = DirectCast(_usuario.ShallowCopy(), Usuarios)
                End If
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub bgwCarga_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarga.DoWork
            System.Threading.Thread.CurrentThread.CurrentCulture = GetApplicationCulture(Me)
            Using c As New Controller.UsuariosController()
                Dim datos As IEnumerable(Of Usuarios)
                datos = c.GetItems("", _orden)
                e.Result = datos
            End Using
        End Sub

        Private Sub bgwCarga_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwCarga.RunWorkerCompleted
            _panel.Ocultar()
            If Not IsNothing(e.Error) Then
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
            Else
                Try
                    UsuariosBindingSource.DataSource = e.Result
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If

        End Sub

#End Region

#Region "Ordenación"

        Private Sub cbOrden_onSort(ByVal sender As CommandBarSortItem, ByVal e As SortEventArgs) Handles cbOrden.onSort
            gridDatos.FilterDescriptors.Clear()
            gridDatos.SortDescriptors.Clear()
            _orden = e.SortExpression
            CargarDatos()
        End Sub

        Private Sub ConfigurarBarraOrden()
            cbOrden = New Presentacion.Componente.CommandBarSortItem(cbstripeOrden)
            cbOrden.AddItemToFieldDDL(gridDatos.Columns("Nombre").HeaderText, "Nombre")
            cbOrden.AddItemToFieldDDL(gridDatos.Columns("NombreSesion").HeaderText, "NombreSesion")
            cbOrden.Prepare("")
        End Sub

#End Region

#Region "Eventos Checkbox"
        Private Sub chkVenta_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkMVenta.ToggleStateChanged, chkEVenta.ToggleStateChanged, chkAVenta.ToggleStateChanged
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                chkVVenta.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            End If
        End Sub

        Private Sub chkCliente_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkMCliente.ToggleStateChanged, chkECliente.ToggleStateChanged, chkACliente.ToggleStateChanged            
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                chkVCliente.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            End If
        End Sub

        Private Sub chkProveedor_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkMProveedor.ToggleStateChanged, chkEProveedor.ToggleStateChanged, chkAProveedor.ToggleStateChanged
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                chkVProveedor.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            End If
        End Sub

        Private Sub chkProducto_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkMProducto.ToggleStateChanged, chkEProducto.ToggleStateChanged, chkAProducto.ToggleStateChanged
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                chkVProducto.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            End If
        End Sub

        Private Sub chkCompra_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkMCompra.ToggleStateChanged, chkECompra.ToggleStateChanged, chkACompra.ToggleStateChanged
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                chkVCompra.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            End If
        End Sub

        Private Sub chkVCliente_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkVCliente.ToggleStateChanged
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
                chkACliente.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
                chkMCliente.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
                chkECliente.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
            End If
        End Sub

        Private Sub chkVProveedor_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkVProveedor.ToggleStateChanged
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
                chkAProveedor.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
                chkMProveedor.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
                chkEProveedor.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
            End If
        End Sub

        Private Sub chkVVenta_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkVVenta.ToggleStateChanged
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
                chkAVenta.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
                chkMVenta.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
                chkEVenta.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
            End If
        End Sub

        Private Sub chkVCompra_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkVCompra.ToggleStateChanged
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
                chkACompra.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
                chkMCompra.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
                chkECompra.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
            End If
        End Sub

        Private Sub chkVProducto_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkVProducto.ToggleStateChanged
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off Then
                chkAProducto.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
                chkMProducto.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
                chkEProducto.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
            End If
        End Sub
#End Region

        Private Sub ChequearPermiso(usuario As Usuarios)
            chkAProducto.Checked = ((usuario.PermisoProducto And Permiso.Adicion) = Permiso.Adicion)
            chkEProducto.Checked = ((usuario.PermisoProducto And Permiso.Eliminacion) = Permiso.Eliminacion)
            chkVProducto.Checked = ((usuario.PermisoProducto And Permiso.Visualizacion) = Permiso.Visualizacion)
            chkMProducto.Checked = ((usuario.PermisoProducto And Permiso.Modificacion) = Permiso.Modificacion)

            chkACliente.Checked = ((usuario.PermisoCliente And Permiso.Adicion) = Permiso.Adicion)
            chkECliente.Checked = ((usuario.PermisoCliente And Permiso.Eliminacion) = Permiso.Eliminacion)
            chkVCliente.Checked = ((usuario.PermisoCliente And Permiso.Visualizacion) = Permiso.Visualizacion)
            chkMCliente.Checked = ((usuario.PermisoCliente And Permiso.Modificacion) = Permiso.Modificacion)

            chkACompra.Checked = ((usuario.PermisoCompra And Permiso.Adicion) = Permiso.Adicion)
            chkECompra.Checked = ((usuario.PermisoCompra And Permiso.Eliminacion) = Permiso.Eliminacion)
            chkVCompra.Checked = ((usuario.PermisoCompra And Permiso.Visualizacion) = Permiso.Visualizacion)
            chkMCompra.Checked = ((usuario.PermisoCompra And Permiso.Modificacion) = Permiso.Modificacion)

            chkAProveedor.Checked = ((usuario.PermisoProveedor And Permiso.Adicion) = Permiso.Adicion)
            chkEProveedor.Checked = ((usuario.PermisoProveedor And Permiso.Eliminacion) = Permiso.Eliminacion)
            chkVProveedor.Checked = ((usuario.PermisoProveedor And Permiso.Visualizacion) = Permiso.Visualizacion)
            chkMProveedor.Checked = ((usuario.PermisoProveedor And Permiso.Modificacion) = Permiso.Modificacion)

            chkAVenta.Checked = ((usuario.PermisoVenta And Permiso.Adicion) = Permiso.Adicion)
            chkEVenta.Checked = ((usuario.PermisoVenta And Permiso.Eliminacion) = Permiso.Eliminacion)
            chkVVenta.Checked = ((usuario.PermisoVenta And Permiso.Visualizacion) = Permiso.Visualizacion)
            chkMVenta.Checked = ((usuario.PermisoVenta And Permiso.Modificacion) = Permiso.Modificacion)

            chkMConfiguracion.Checked = ((usuario.PermisoConfiguracion And Permiso.Modificacion) = Permiso.Modificacion)

        End Sub

        Private Sub GuardarPermiso(ByVal usuario As Entity.Usuarios)
            _usuario.PermisoCliente = Permiso.SinAcceso
            _usuario.PermisoCompra = Permiso.SinAcceso
            _usuario.PermisoConfiguracion = Permiso.SinAcceso
            _usuario.PermisoProducto = Permiso.SinAcceso
            _usuario.PermisoProveedor = Permiso.SinAcceso
            _usuario.PermisoVenta = Permiso.SinAcceso

            _usuario.PermisoCliente += CInt(IIf(chkACliente.Checked, CInt(Permiso.Adicion), 0))
            _usuario.PermisoCliente += CInt(IIf(chkMCliente.Checked, CInt(Permiso.Modificacion), 0))
            _usuario.PermisoCliente += CInt(IIf(chkECliente.Checked, CInt(Permiso.Eliminacion), 0))
            _usuario.PermisoCliente += CInt(IIf(chkVCliente.Checked, CInt(Permiso.Visualizacion), 0))

            _usuario.PermisoCompra += CInt(IIf(chkACompra.Checked, CInt(Permiso.Adicion), 0))
            _usuario.PermisoCompra += CInt(IIf(chkMCompra.Checked, CInt(Permiso.Modificacion), 0))
            _usuario.PermisoCompra += CInt(IIf(chkECompra.Checked, CInt(Permiso.Eliminacion), 0))
            _usuario.PermisoCompra += CInt(IIf(chkVCompra.Checked, CInt(Permiso.Visualizacion), 0))

            _usuario.PermisoProducto += CInt(IIf(chkAProducto.Checked, CInt(Permiso.Adicion), 0))
            _usuario.PermisoProducto += CInt(IIf(chkMProducto.Checked, CInt(Permiso.Modificacion), 0))
            _usuario.PermisoProducto += CInt(IIf(chkEProducto.Checked, CInt(Permiso.Eliminacion), 0))
            _usuario.PermisoProducto += CInt(IIf(chkVProducto.Checked, CInt(Permiso.Visualizacion), 0))

            _usuario.PermisoProveedor += CInt(IIf(chkAProveedor.Checked, CInt(Permiso.Adicion), 0))
            _usuario.PermisoProveedor += CInt(IIf(chkMProveedor.Checked, CInt(Permiso.Modificacion), 0))
            _usuario.PermisoProveedor += CInt(IIf(chkEProveedor.Checked, CInt(Permiso.Eliminacion), 0))
            _usuario.PermisoProveedor += CInt(IIf(chkVProveedor.Checked, CInt(Permiso.Visualizacion), 0))

            _usuario.PermisoVenta += CInt(IIf(chkAVenta.Checked, CInt(Permiso.Adicion), 0))
            _usuario.PermisoVenta += CInt(IIf(chkMVenta.Checked, CInt(Permiso.Modificacion), 0))
            _usuario.PermisoVenta += CInt(IIf(chkEVenta.Checked, CInt(Permiso.Eliminacion), 0))
            _usuario.PermisoVenta += CInt(IIf(chkVVenta.Checked, CInt(Permiso.Visualizacion), 0))

            _usuario.PermisoConfiguracion += CInt(IIf(chkMConfiguracion.Checked, CInt(Permiso.Modificacion), 0))

            _usuario.InformesAccesibles = String.Empty

        End Sub

        Public Sub New(cerrable As Boolean)

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            Me.Controls.Add(_panel)
            _panel.BringToFront()
            ddlIdioma.Items(0).Value = "ES"
            ddlIdioma.Items(1).Value = "ZH"
            ControlBox = cerrable
            PrepararControles(SplitPanel1.Controls)
            PrepararControles(SplitPanel2.Controls)

        End Sub


        Private Sub ddlTemasAplicacion_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlTemasAplicacion.SelectedIndexChanged
            picbPrevisualizacion.ImageLocation = My.Application.Info.DirectoryPath & "\Resources\" & ddlTemasAplicacion.Items(e.Position).Text & ".PNG"
        End Sub
    End Class

End Namespace
