Imports EasyGestControllers.Controller


Namespace Presentacion.Formulario.Cliente

    Public Class frmClienteEdicion

        Private _cliente As Entity.Clientes = Nothing
        Private _action As System.Data.Linq.ChangeAction = System.Data.Linq.ChangeAction.None

        Protected Friend ReadOnly Property Cliente() As Entity.VWClientes
            Get
                Dim cli As Entity.VWClientes = Nothing
                If _cliente IsNot Nothing Then
                    Using control As New VistasController(Of Entity.VWClientes)
                        cli = control.GetItem(_cliente.idCliente)
                    End Using
                End If
                Return cli
            End Get
        End Property

        Public Sub New(ByVal idCliente As Long)

            ' Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            If idCliente = -1 Then
                _cliente = ClientesController.NewItem()
                _action = System.Data.Linq.ChangeAction.Insert
            Else
                _action = System.Data.Linq.ChangeAction.Update
                Using control As New ClientesController
                    _cliente = control.GetItem(idCliente)
                End Using
            End If

        End Sub

        Private Sub frmClienteEdicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Try
                PrepararControles(Me.Controls)
                AddHandler chkAplicarRE.KeyPress, AddressOf checkbox_KeyPress
                ' cargar los comboboxs
                Using control As New ProvinciasEspañolasController
                    ProvinciasEspañolasBindingSource.DataSource = control.GetItems("", "Provincia ASC")
                End Using
                Using control As New TiposIdentificacionController
                    TiposIdentificacionBindingSource.DataSource = control.GetItems()
                End Using
                Using control As New MunicipiosEspañolasController
                    If _action = System.Data.Linq.ChangeAction.Update And Not String.IsNullOrWhiteSpace(_cliente.Provincia) Then
                        MunicipiosEspañolasBindingSource.DataSource = control.GetItemsByNombreProvincia(_cliente.Provincia)
                    End If
                End Using
                Me.ClientesBindingSource.DataSource = _cliente
                lblAplicarImpIndirecto.Text = String.Format(lblAplicarImpIndirecto.Text, gConfGlobal.NombreImpuesto)
                btnAceptar.Enabled = False
                timValidar.Enabled = True
                btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                btnAceptar.Enabled = False
            End Try
        End Sub


        Private Sub timValidar_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timValidar.Tick
            btnAceptar.Enabled = _cliente.IsValid(_action)
        End Sub

        Private Sub CancelarForm()
            'Me.DialogResult = Windows.Forms.DialogResult.Cancel
            timValidar.Enabled = False
            _cliente = Nothing
        End Sub

        Private Sub AceptarForm()
            timValidar.Enabled = False
            Using control As New ClientesController
                If _action = System.Data.Linq.ChangeAction.Insert Then
                    _cliente = control.AddItem(_cliente)
                ElseIf _action = System.Data.Linq.ChangeAction.Update Then
                    control.UpdateItem(_cliente)
                End If
            End Using
            'Me.DialogResult = Windows.Forms.DialogResult.OK
        End Sub

        Private Sub ddlProvincia_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlProvincia.SelectedIndexChanged
            If ddlProvincia.SelectedValue IsNot Nothing Then
                Using control As New MunicipiosEspañolasController()
                    MunicipiosEspañolasBindingSource.DataSource = control.GetItemsByCodProvincia(CStr(Me.ddlProvincia.SelectedValue))
                End Using
            End If
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AceptarForm()
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            CancelarForm()
        End Sub

        Private Sub txtNombreChino_Enter(sender As Object, e As EventArgs) Handles txtNombreChino.Enter
            InputLanguage.CurrentInputLanguage = gChineseInputLanguage
        End Sub

        Private Sub txtNombreChino_Leave(sender As Object, e As EventArgs) Handles txtNombreChino.Leave
            InputLanguage.CurrentInputLanguage = InputLanguage.DefaultInputLanguage
        End Sub

    End Class

End Namespace
