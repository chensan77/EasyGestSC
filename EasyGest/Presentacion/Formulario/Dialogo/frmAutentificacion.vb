Namespace Presentacion.Formulario.Dialogo

    Public Class frmAutentificacion

        Protected Friend Property Usuario As Usuarios

        Private Sub chkComoSuper_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkComoSuper.ToggleStateChanged
            txtNombre.Enabled = Not chkComoSuper.Checked
            txtNombre.Clear()
            txtContraseña.Clear()
            If chkComoSuper.Checked Then
                txtContraseña.Focus()
            Else
                txtNombre.Focus()
            End If
        End Sub

        Private Sub timValidezFormulario_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timValidezFormulario.Tick
            ActivarDesactivarControles((chkComoSuper.Checked And Not String.IsNullOrWhiteSpace(txtContraseña.Text)) Or (Not chkComoSuper.Checked And (Not (String.IsNullOrEmpty(txtNombre.Text) Or String.IsNullOrEmpty(txtContraseña.Text)))), btnAceptar)
        End Sub

        Private Sub frmAutentificacion_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            'centrar panel
            Dim x, y As Integer
            x = CInt(Math.Round(Me.Width / 2 - pnlLogin.Width / 2))
            y = CInt(Math.Round(Me.Height / 2 - pnlLogin.Height / 2))
            pnlLogin.Location = New Point(x, y)
        End Sub

        Private Sub frmAutentificacion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            timValidezFormulario.Enabled = False
            If Me.DialogResult = DialogResult.OK Then
                Dim valido As Boolean = False
                If chkComoSuper.Checked Then
                    If txtContraseña.Text.Equals(gConfGlobal.ClaveAdministrador) Then
                        Using control As New UsuariosController
                            Usuario = control.GetUsuarioSuper()
                        End Using
                        valido = True
                    End If
                Else
                    Using c As New UsuariosController()
                        Usuario = c.Autentificar(txtNombre.Text, txtContraseña.Text)
                        valido = Not IsNothing(Usuario)
                    End Using
                End If
                If Not valido Then
                    e.Cancel = True
                    MostrarMensaje(My.Resources.Application.AvisoNoAutentificado, Me.Text, Telerik.WinControls.RadMessageIcon.Exclamation)
                End If
            End If
        End Sub

        Private Sub frmBDConexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            PrepararControles(Me.Controls)
            timValidezFormulario.Enabled = True
            btnAceptar.Enabled = False
            btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
        End Sub

    End Class
End Namespace