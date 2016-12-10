Namespace Presentacion.Formulario.Dialogo

    Public Class frmApertura

        Private _diario As Diarios

        Protected Friend ReadOnly Property Diario As Diarios
            Get
                Return _diario
            End Get
        End Property

        Private Sub frmApertura_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            'centrar panel
            Dim x, y As Integer
            x = CInt(Math.Round(Me.Width / 2 - pnlLogin.Width / 2))
            y = CInt(Math.Round(Me.Height / 2 - pnlLogin.Height / 2))
            pnlLogin.Location = New Point(x, y)
        End Sub

        Private Sub frmApertura_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            If Me.DialogResult = DialogResult.OK Then
                Try
                    Using control As New DiariosController
                        control.SyncronisingItem(_diario)
                    End Using

                Catch ex As Exception
                    e.Cancel = True
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
        End Sub

        Private Sub frmApertura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            PrepararControles(Me.Controls)            
            txtPuesto.Text = gPuesto.Puesto
            txtUsuario.Text = gUsuario.Nombre
            BindingSourceDiario.DataSource = _diario
            btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
        End Sub

        Public Sub New()

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            _diario = DiariosController.NewItem()
            _diario.idPuesto = gPuesto.idPuesto
            _diario.idUsuario = gUsuario.idUsuario
            _diario.DepositoInicio = gConfLocal.DepositoCaja
        End Sub
    End Class
End Namespace