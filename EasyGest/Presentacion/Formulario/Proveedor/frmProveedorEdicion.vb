Imports EasyGestControllers.Controller


Namespace Presentacion.Formulario.Proveedor

    Public Class frmProveedorEdicion

        Private _proveedor As Entity.Proveedores = Nothing

        Private Sub frmProveedorEdicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Try
                PrepararControles(Me.Controls)
                ' cargar los comboboxs
                Using control As New ProvinciasEspañolasController
                    ProvinciasEspañolasBindingSource.DataSource = control.GetItems("", "Provincia ASC")
                End Using
                Using control As New TiposIdentificacionController
                    TiposIdentificacionBindingSource.DataSource = control.GetItems()
                End Using
                Using control As New MunicipiosEspañolasController
                    If _proveedor.LINQEntityState <> EntityState.New And Not String.IsNullOrWhiteSpace(_proveedor.Provincia) Then
                        MunicipiosEspañolasBindingSource.DataSource = control.GetItemsByNombreProvincia(_proveedor.Provincia)
                    End If
                End Using
                Me.ProveedoresBindingSource.DataSource = _proveedor
                btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
                btnAceptar.Enabled = False
                timValidar.Enabled = True
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                btnAceptar.Enabled = False
            End Try
        End Sub


        Public Sub New(ByVal idProveedor As Long)

            ' Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            If idProveedor = -1 Then
                _proveedor = ProveedoresController.NewItem()
            Else
                Using control As New ProveedoresController
                    _proveedor = control.GetItem(idProveedor)
                End Using
            End If

        End Sub

        Protected Friend ReadOnly Property Proveedor() As Entity.VWProveedores
            Get
                Dim pro As Entity.VWProveedores = Nothing
                If _proveedor IsNot Nothing Then
                    Using control As New VistasController(Of Entity.VWProveedores)
                        pro = control.GetItem(_proveedor.idProveedor)
                    End Using
                End If
                Return pro
            End Get
        End Property

        Private Sub timValidar_Tick(sender As Object, e As System.EventArgs) Handles timValidar.Tick
            btnAceptar.Enabled = _proveedor.IsValid()
        End Sub

        Private Sub CancelarForm()
            'Me.DialogResult = Windows.Forms.DialogResult.Cancel
            timValidar.Enabled = False
            _proveedor = Nothing
        End Sub

        Private Sub AceptarForm()
            timValidar.Enabled = False
            Using control As New ProveedoresController
                control.SyncronisingItem(_proveedor)
            End Using
            'Me.DialogResult = Windows.Forms.DialogResult.OK
        End Sub

        Private Sub ddlProvincia_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlProvincia.SelectedIndexChanged
            If ddlProvincia.SelectedValue IsNot Nothing Then
                Using control As New MunicipiosEspañolasController()
                    MunicipiosEspañolasBindingSource.DataSource = control.GetItemsByCodProvincia(CStr(ddlProvincia.SelectedValue))
                End Using
            End If
        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As System.EventArgs) Handles btnAceptar.Click
            AceptarForm()
        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As System.EventArgs) Handles btnCancelar.Click
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
