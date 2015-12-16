Namespace Presentacion.Formulario.Dialogo

    Public Class frmBDConexion

        Private _resulatdo As Boolean = False

        Private Sub frmBDConexion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            timValidezFormulario.Enabled = False
        End Sub

        Private Sub frmBDConexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            PrepararControles(Me.Controls)
            timValidezFormulario.Enabled = True
            btnAceptar.Enabled = False            
            btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
        End Sub

        Private Sub timValidezFormulario_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timValidezFormulario.Tick
            If Not bgwProbar.IsBusy Then _
            ActivarDesactivarControles(Not (String.IsNullOrWhiteSpace(txtCatalogo.Text) Or String.IsNullOrEmpty(txtContraseña.Text) Or _
                    String.IsNullOrWhiteSpace(txtServidor.Text) Or String.IsNullOrEmpty(txtUsuario.Text)), btnAceptar, btnProbar)
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            Me.Close()
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            If bgwProbar.IsBusy Then
                If Not bgwProbar.CancellationPending Then bgwProbar.CancelAsync()
            Else
                Me.Close()
            End If
        End Sub

        Private Sub btnProbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProbar.Click
            EjecutarConexion()
        End Sub

        Private Sub bgwProbar_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProbar.DoWork
            EasyGestControllers.Util.Comunes.CadenaConexion = e.Argument.ToString()
            _resulatdo = EasyGestController.DataAccesible()
        End Sub

        Private Sub bgwProbar_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProbar.RunWorkerCompleted
            wtbEsperar.StopWaiting()
            wtbEsperar.Hide()
            ActivarDesactivarControles(True, btnAceptar, btnProbar)
            If _resulatdo = True Then
                MostrarMensaje(Me, My.Resources.Application.AvisoProbarConexionExitosa, Telerik.WinControls.RadMessageIcon.Info)
            Else
                MostrarMensaje(Me, My.Resources.Application.AvisoProbarConexionFallida, Telerik.WinControls.RadMessageIcon.Info)
            End If
        End Sub

        Private Sub EjecutarConexion()
            wtbEsperar.Show()
            wtbEsperar.StartWaiting()
            ActivarDesactivarControles(False, btnAceptar, btnProbar)
            bgwProbar.RunWorkerAsync(GenerarCadenaConexion(Servidor, Catalogo, Usuario, Contraseña))
        End Sub

        Protected Friend Property Servidor As String
            Get
                Return txtServidor.Text
            End Get
            Set(ByVal value As String)
                txtServidor.Text = value
            End Set
        End Property

        Protected Friend Property Catalogo As String
            Get
                Return txtCatalogo.Text
            End Get
            Set(ByVal value As String)
                txtCatalogo.Text = value
            End Set
        End Property

        Protected Friend Property Usuario As String
            Get
                Return txtUsuario.Text
            End Get
            Set(ByVal value As String)
                txtUsuario.Text = value
            End Set
        End Property

        Protected Friend Property Contraseña As String
            Get
                Return txtContraseña.Text
            End Get
            Set(ByVal value As String)
                txtContraseña.Text = value
            End Set
        End Property

    End Class

End Namespace
