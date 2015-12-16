Imports EasyGestControllers.Controller


Namespace Presentacion.Formulario.Cuenta

    Public Class frmCuentaEdicion

        Private _cuenta As Entity.DatosBancario = Nothing
        Private _action As System.Data.Linq.ChangeAction = System.Data.Linq.ChangeAction.None
        Private _propietariomodificable As Boolean = False

        Friend WriteOnly Property PropietarioModificable As Boolean
            Set(ByVal value As Boolean)
                _propietariomodificable = value
                ddlPropietario.Visible = value
                txtPropietario.Visible = Not value
            End Set
        End Property

        Private Sub frmClienteEdicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Try
                PrepararControles(Me.Controls)
                ' cargar los comboboxs                
                If _cuenta.TipoPropietario.Equals(Util.Comunes.TIPO_PROPIETARIO_CLIENTE) Then
                    ddlPropietario.ValueMember = "idCliente"
                    Using control As New ClientesController
                        PropietarioBindingSource.DataSource = control.GetItems("Activo = true")
                    End Using
                End If
                If _cuenta.TipoPropietario.Equals(Util.Comunes.TIPO_PROPIETARIO_PROVEEDOR) Then
                    ddlPropietario.ValueMember = "idProveedor"
                    Using control As New ProveedoresController
                        PropietarioBindingSource.DataSource = control.GetItems("Activo = true")
                    End Using
                End If
                Me.CuentasBindingSource.DataSource = _cuenta
                If Not _propietariomodificable Then
                    txtTitular.Focus()
                End If
                ddlPropietario.Visible = _propietariomodificable
                txtPropietario.Visible = Not _propietariomodificable
                btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
                btnAceptar.Enabled = False
                timValidar.Enabled = True
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                btnAceptar.Enabled = False
            End Try
        End Sub

        Public Sub New(ByVal idCuenta As Long, ByVal tipo As Char, ByVal idpropietario As Long)

            ' Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            If idCuenta = -1 Then
                _cuenta = DatosBancarioController.NewItem()
                _cuenta.idPropietario = idpropietario
                _action = System.Data.Linq.ChangeAction.Insert
            Else
                _action = System.Data.Linq.ChangeAction.Update
                Using control As New DatosBancarioController
                    _cuenta = control.GetItem(idCuenta)
                End Using
            End If
            _cuenta.TipoPropietario = tipo

            If tipo.Equals(Util.Comunes.TIPO_PROPIETARIO_CLIENTE) Then
                Me.Text = String.Format(Me.Text, My.Resources.Application.TextoCliente)
                lblCliPro.Text = My.Resources.Application.TextoCliente
            End If
            If tipo.Equals(Util.Comunes.TIPO_PROPIETARIO_PROVEEDOR) Then
                Me.Text = String.Format(Me.Text, My.Resources.Application.TextoProveedor)
                lblCliPro.Text = My.Resources.Application.TextoProveedor
            End If
        End Sub

        Protected Friend ReadOnly Property Cuenta() As Entity.VWDatosBancario
            Get
                Dim cta As Entity.VWDatosBancario = Nothing
                If _cuenta IsNot Nothing Then
                    Using control As New VistasController(Of Entity.VWDatosBancario)
                        cta = control.GetItem(_cuenta.idCuenta)
                    End Using
                End If
                Return cta
            End Get
        End Property

        Private Sub timValidar_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timValidar.Tick
            btnAceptar.Enabled = _cuenta.IsValid(_action)
        End Sub

        Private Sub CancelarForm()
            'Me.DialogResult = Windows.Forms.DialogResult.Cancel
            timValidar.Enabled = False
            _cuenta = Nothing
        End Sub

        Private Sub AceptarForm()
            timValidar.Enabled = False
            Using control As New DatosBancarioController
                If _action = System.Data.Linq.ChangeAction.Insert Then
                    _cuenta = control.AddItem(_cuenta)
                ElseIf _action = System.Data.Linq.ChangeAction.Update Then
                    control.UpdateItem(_cuenta)
                End If
            End Using
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AceptarForm()
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            CancelarForm()
        End Sub

    End Class

End Namespace
