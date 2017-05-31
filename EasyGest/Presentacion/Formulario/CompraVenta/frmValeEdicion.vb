Imports EasyGestControllers.Controller


Namespace Presentacion.Formulario.CompraVenta

    Public Class frmValeEdicion

        Private _vale As Entity.Vales = Nothing

        Private Sub frmValeEdicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Try
                PrepararControles(Me.Controls)

                Me.ValesBindingSource.DataSource = _vale
                btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
                btnAceptar.Enabled = False
                timValidar.Enabled = True
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                btnAceptar.Enabled = False
            End Try
        End Sub

        Public Sub New()

            ' Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            _vale = ValesController.NewItem()
            If gConfGlobal.ValidezVale > 0 Then _
                _vale.FValidez = _vale.FEmision.AddDays(gConfGlobal.ValidezVale)

        End Sub

        Protected Friend ReadOnly Property Vales() As Entity.VWVales
            Get
                Dim cta As Entity.VWVales = Nothing
                If _vale IsNot Nothing Then
                    Using control As New VistasController(Of Entity.VWVales)
                        cta = control.GetItem(_vale.idVale)
                    End Using
                End If
                Return cta
            End Get
        End Property

        Private Sub timValidar_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timValidar.Tick
            btnAceptar.Enabled = _vale.IsValid()
        End Sub

        Private Sub CancelarForm()
            'Me.DialogResult = Windows.Forms.DialogResult.Cancel
            timValidar.Enabled = False
            _vale = Nothing
        End Sub

        Private Sub AceptarForm()
            timValidar.Enabled = False
            Using control As New ValesController
                control.AddItem(_vale)
            End Using
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AceptarForm()
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            CancelarForm()
        End Sub

        Private Sub frmValeEdicion_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            spinImporte.Select()
        End Sub

        Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
            Dim frm As Dialogo.frmBuscador
            frm = New Dialogo.frmBuscador(Dialogo.frmBuscador.ObjetoBusqueda.Cliente)
            If frm.ShowDialog() = DialogResult.OK Then
                If Not IsNothing(frm.ObjetoEncontrado) Then
                    Dim cliente As VWClientes = TryCast(frm.ObjetoEncontrado, VWClientes)
                    _vale.idCliente = cliente.idCliente
                    txtTitular.Text = cliente.NombreYNombreCN
                End If
            End If
        End Sub

        Private Sub txtTitular_TextChanged(sender As Object, e As EventArgs) Handles txtTitular.TextChanged
            If String.IsNullOrEmpty(txtTitular.Text) Then _vale.idCliente = Nothing
        End Sub
    End Class

End Namespace
