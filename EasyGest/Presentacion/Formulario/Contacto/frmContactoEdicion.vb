Imports EasyGestControllers.Controller


Namespace Presentacion.Formulario.Contacto

    Public Class frmContactoEdicion

        Private _contacto As Entity.Contactos = Nothing
        Private _action As System.Data.Linq.ChangeAction = System.Data.Linq.ChangeAction.None
        Private _propietariomodificable As Boolean = False

        Friend WriteOnly Property PropietarioModificable As Boolean
            Set(value As Boolean)
                _propietariomodificable = value
                ddlPropietario.Visible = value
                txtPropietario.Visible = Not value
            End Set
        End Property

        Private Sub frmContactoEdicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Try
                PrepararControles(Me.Controls)
                ' cargar los comboboxs                
                Using control As New FormasContactoController
                    FormasContactoBindingSource.DataSource = control.GetItems()
                End Using
                If _contacto.TipoPropietario.Equals(Data.Entity.Contactos.TIPO_PROPIETARIO_CLIENTE) Then
                    ddlPropietario.ValueMember = "idCliente"
                    Using control As New ClientesController
                        PropietarioBindingSource.DataSource = control.GetItems("Activo = true")
                    End Using
                End If
                If _contacto.TipoPropietario.Equals(Data.Entity.Contactos.TIPO_PROPIETARIO_PROVEEDOR) Then
                    ddlPropietario.ValueMember = "idProveedor"
                    Using control As New ProveedoresController
                        PropietarioBindingSource.DataSource = control.GetItems("Activo = true")
                    End Using
                End If
                Me.ContactosBindingSource.DataSource = _contacto
                If Not _propietariomodificable Then
                    ddlFormaContacto.Focus()
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

        Public Sub New(ByVal idContacto As Long, tipo As Char, idpropietario As Long)

            ' Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            If idContacto = -1 Then
                _contacto = ContactosController.NewItem()
                _contacto.idPropietario = idpropietario
                _action = System.Data.Linq.ChangeAction.Insert
            Else
                _action = System.Data.Linq.ChangeAction.Update
                Using control As New ContactosController
                    _contacto = control.GetItem(idContacto)
                End Using
            End If
            _contacto.TipoPropietario = tipo

            If tipo.Equals(Data.Entity.Contactos.TIPO_PROPIETARIO_CLIENTE) Then
                Me.Text = String.Format(Me.Text, My.Resources.Application.TextoCliente)
                lblCliPro.Text = My.Resources.Application.TextoCliente
            End If
            If tipo.Equals(Data.Entity.Contactos.TIPO_PROPIETARIO_PROVEEDOR) Then
                Me.Text = String.Format(Me.Text, My.Resources.Application.TextoProveedor)
                lblCliPro.Text = My.Resources.Application.TextoProveedor
            End If
        End Sub

        Protected Friend ReadOnly Property Contacto() As Entity.VWContactos
            Get
                Dim cto As Entity.VWContactos = Nothing
                If _contacto IsNot Nothing Then
                    Using control As New VistasController(Of Entity.VWContactos)
                        cto = control.GetItem(_contacto.idContacto)
                    End Using
                End If
                Return cto
            End Get
        End Property

        Private Sub timValidar_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timValidar.Tick
            btnAceptar.Enabled = _contacto.IsValid()
        End Sub

        Private Sub CancelarForm()
            'Me.DialogResult = Windows.Forms.DialogResult.Cancel
            timValidar.Enabled = False
            _contacto = Nothing
        End Sub

        Private Sub AceptarForm()
            timValidar.Enabled = False
            Using control As New ContactosController
                If _action = System.Data.Linq.ChangeAction.Insert Then
                    _contacto = control.AddItem(_contacto)
                ElseIf _action = System.Data.Linq.ChangeAction.Update Then
                    control.UpdateItem(_contacto)
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
