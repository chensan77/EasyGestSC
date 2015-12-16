Imports EasyGestControllers.Controller


Namespace Presentacion.Formulario.Cliente

    Public Class frmClienteTarjetaEdicion

        Private _tarjeta As Entity.TarjetasFidelizacion = Nothing
        Private _action As System.Data.Linq.ChangeAction = System.Data.Linq.ChangeAction.None
        Private _propietariomodificable As Boolean = False
        Private _baseaux, _beneficioaux, _basepuntoaux, _equivalenciapuntoaux As Single
        Private _ensaldoaux As Boolean
        Private _ensaldoinicial As Boolean? = Nothing
        Private _numerodublicado As Boolean = False

        Friend WriteOnly Property PropietarioModificable As Boolean
            Set(value As Boolean)
                _propietariomodificable = value
                ddlCliente.Visible = value
                txtPropietario.Visible = Not value
            End Set
        End Property

        Private Sub frmClienteTarjetaEdicion_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            If _numerodublicado Then
                e.Cancel = True
                _numerodublicado = False
            End If
        End Sub

        Private Sub frmClienteTarjetaEdicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Try
                PrepararControles(Me.Controls)
                ' cargar los comboboxs                               
                Using control As New ClientesController
                    PropietarioBindingSource.DataSource = control.GetItems("Activo = true")
                End Using
                Me.TarjetasFidelizacionBindingSource.DataSource = _tarjeta
                If _propietariomodificable Then
                    ddlCliente.Select()
                Else
                    txtNumeroTarjeta.Select()
                End If

                'Preparar controles si la accion es ACTUALIZACION de acuerdo al estado de activo
                If _action = System.Data.Linq.ChangeAction.Update Then
                    toggleActivacion.Text = CStr(IIf(Not _tarjeta.Activo, My.Resources.Application.TextoActivar, My.Resources.Application.TextoDesactivar))
                    toggleActivacion.Image = DirectCast(IIf(Not _tarjeta.Activo, My.Resources.accept, My.Resources.delete), Image)
                    ActivarDesactivarControles(_tarjeta.Activo, ddlCliente, txtPropietario, txtNumeroTarjeta, txtSaldo, chkCondicionParticular)
                    If _tarjeta.Activo Then
                        gboxCondicion.Enabled = chkCondicionParticular.Checked
                    Else
                        gboxCondicion.Enabled = False
                    End If
                End If

                txtSaldo.ReadOnly = Not gUsuario.IsSuper()
                btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
                btnAceptar.Enabled = False
                timValidar.Enabled = True
                AddHandler toggleActivacion.ToggleStateChanged, AddressOf toggleActivacion_ToggleStateChanged
                AddHandler chkCondicionParticular.ToggleStateChanging, AddressOf chkCondicionParticular_ToggleStateChanging
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                btnAceptar.Enabled = False
            End Try
        End Sub

        Public Sub New(ByVal idTarjeta As Long, idpropietario As Long)

            ' Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            If idTarjeta = -1 Then
                _tarjeta = TarjetasFidelizacionController.NewItem()
                _tarjeta.idCliente = idpropietario
                _tarjeta.EnSaldo = gConfGlobal.ModoFidelizacion = EasyGestControllers.Data.Configuracion.TipoFidelizacionEnum.Saldo
                _tarjeta.CondicionParticular = Not gConfGlobal.FidelizacionModoGlobal
                _tarjeta.FormulaSaldo = gConfGlobal.FormulaFidelizacion
                _action = System.Data.Linq.ChangeAction.Insert
                toggleActivacion.Enabled = False
            Else
                _action = System.Data.Linq.ChangeAction.Update
                Using control As New TarjetasFidelizacionController
                    _tarjeta = control.GetItem(idTarjeta)
                End Using
                txtNumeroTarjeta.ReadOnly = True
                _ensaldoinicial = _tarjeta.EnSaldo
            End If
            _baseaux = _tarjeta.Base
            _beneficioaux = _tarjeta.Beneficio
            _basepuntoaux = _tarjeta.BasePunto
            _equivalenciapuntoaux = _tarjeta.EquivalenciaPunto
            _ensaldoaux = _tarjeta.EnSaldo
        End Sub

        Protected Friend ReadOnly Property Tarjeta() As Entity.VWTarjetasFidelizacion
            Get
                Dim cto As Entity.VWTarjetasFidelizacion = Nothing
                If _tarjeta IsNot Nothing Then
                    Using control As New VistasController(Of Entity.VWTarjetasFidelizacion)
                        cto = control.GetItem(_tarjeta.idTarjeta)
                    End Using
                End If
                Return cto
            End Get
        End Property

        Private Sub timValidar_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timValidar.Tick
            btnAceptar.Enabled = _tarjeta.IsValid(_action)
        End Sub

        Private Sub CancelarForm()
            timValidar.Enabled = False
            _tarjeta = Nothing
        End Sub

        Private Sub AceptarForm()
            Try
                timValidar.Enabled = False
                If _ensaldoinicial.HasValue() Then
                    If Not _ensaldoinicial.Value.Equals(_tarjeta.EnSaldo) Then
                        If _ensaldoinicial.Value = True And _tarjeta.EnSaldo = False Then
                        Else
                            _tarjeta.Saldo = _tarjeta.Saldo * _tarjeta.EquivalenciaPunto / _tarjeta.BasePunto
                        End If
                    End If
                End If
                Using control As New TarjetasFidelizacionController
                    If _action = System.Data.Linq.ChangeAction.Insert Then
                        _tarjeta = control.AddItem(_tarjeta)
                    ElseIf _action = System.Data.Linq.ChangeAction.Update Then
                        control.UpdateItem(_tarjeta)
                    End If
                End Using
            Catch ex As SqlClient.SqlException
                If ex.Number = SQLERRORNUMBER_DUPLICATEINDEX Then
                    MostrarMensaje(My.Resources.Application.AvisoNumTarjetaDuplicado, Me.Text, Telerik.WinControls.RadMessageIcon.Exclamation)
                    _numerodublicado = True
                    timValidar.Enabled = True
                Else
                    Throw ex
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AceptarForm()
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            CancelarForm()
        End Sub

        Private Sub toggleActivacion_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs)
            toggleActivacion.Text = CStr(IIf(args.ToggleState = Enumerations.ToggleState.Off, My.Resources.Application.TextoActivar, My.Resources.Application.TextoDesactivar))
            toggleActivacion.Image = DirectCast(IIf(args.ToggleState = Enumerations.ToggleState.Off, My.Resources.accept, My.Resources.delete), Image)
            ActivarDesactivarControles(args.ToggleState = Enumerations.ToggleState.On, ddlCliente, txtPropietario, txtNumeroTarjeta, txtSaldo, chkCondicionParticular)
            If args.ToggleState = Enumerations.ToggleState.On Then
                gboxCondicion.Enabled = chkCondicionParticular.Checked
            Else
                gboxCondicion.Enabled = False
            End If
        End Sub

        Private Sub chkCondicionParticular_ToggleStateChanging(sender As Object, args As Telerik.WinControls.UI.StateChangingEventArgs)
            If args.NewValue = Enumerations.ToggleState.On Then
                gboxCondicion.Enabled = True
                txtBaseEuro.Value = _baseaux
                txtEquivalenteEuroBeneficio.Value = _beneficioaux
                txtBasePunto.Value = _basepuntoaux
                txtEquivalenciaPuntoEuro.Value = _equivalenciapuntoaux
                rdbSaldo.IsChecked = _ensaldoaux
            End If
            If args.NewValue = Enumerations.ToggleState.Off Then
                gboxCondicion.Enabled = False
                _baseaux = CSng(txtBaseEuro.Value)
                _beneficioaux = CSng(txtEquivalenteEuroBeneficio.Value)
                _basepuntoaux = CSng(txtBasePunto.Value)
                _equivalenciapuntoaux = CSng(txtEquivalenciaPuntoEuro.Value)
                _ensaldoaux = rdbSaldo.IsChecked
                _tarjeta.FormulaSaldo = gConfGlobal.FormulaFidelizacion
                rdbSaldo.IsChecked = gConfGlobal.ModoFidelizacion = EasyGestControllers.Data.Configuracion.TipoFidelizacionEnum.Saldo

            End If
        End Sub

        Private Sub ddlCliente_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ddlCliente.SelectedValueChanged
            If Not IsNothing(ddlCliente.SelectedItem) Then
                txtPropietario.Text = DirectCast(ddlCliente.SelectedItem.DataBoundItem, Clientes).NombreYNombreCN
            Else
                txtPropietario.Clear()
            End If
        End Sub
    End Class

End Namespace
