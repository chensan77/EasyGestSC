Imports EasyGestControllers


Namespace Presentacion.Formulario.Configuracion

    Public Class frmPuesto

#Region "Evento Form"

        Private Sub frmPuesto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            If Me.DialogResult = DialogResult.OK Then
                Try
                    'tratar impuestos
                    Using control As New PuestosController
                        For Each puesto As Puestos In PuestosBindingSource.List
                            control.UpdateItem(puesto)
                            If puesto.idPuesto = gPuesto.idPuesto Then
                                puesto.Clone(gPuesto)
                                My.Forms.frmPrincipal.lblePuesto.Text = My.Resources.Application.TextoPuesto & ": " & gPuesto.Puesto
                            End If
                        Next
                    End Using
                Catch ex As Exception
                    MostrarMensaje(ex, Me.Text, Telerik.WinControls.RadMessageIcon.Error, MessageBoxButtons.OK)
                    e.Cancel = True
                End Try
            End If
        End Sub

        Private Sub frmPuesto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            PrepararControles(Me.Controls)
            btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
        End Sub

        Private Sub frmPuesto_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            CargarDatos("")
        End Sub

        Private Sub frmPuesto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
            If e.KeyChar = Convert.ToChar(27) Then
                Me.Close()
            End If
        End Sub

#End Region

#Region "Evento Grid"

        Private Sub gridDatos_CellValidating(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.CellValidatingEventArgs) Handles gridDatos.CellValidating
            If IsNothing(e.Row) Or IsNothing(e.Column) Then Return
            If String.IsNullOrWhiteSpace(CStr(e.Value)) Then
                e.Cancel = True
                e.Row.ErrorText = My.Resources.Application.TextoValorRequerido
            Else
                e.Row.ErrorText = String.Empty
            End If
        End Sub

#End Region

#Region "Operaciones ARD"

        Private Sub CargarDatos(ByVal filtro As String)
            Using c As New Controller.PuestosController()
                PuestosBindingSource.DataSource = c.GetItems(filtro, "Puesto")
            End Using
        End Sub

#End Region

#Region "Eventos Bontones Aciones"
        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Sub gridDatos_CommandCellClick(ByVal sender As Object, ByVal e As EventArgs) Handles gridDatos.CommandCellClick
            Dim cell As GridCommandCellElement = TryCast(sender, GridCommandCellElement)
            Dim puesto As Puestos = DirectCast(cell.RowInfo.DataBoundItem, Puestos)
            puesto.Reset()


        End Sub
#End Region


    End Class

End Namespace
