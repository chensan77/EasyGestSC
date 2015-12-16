Imports EasyGestControllers

Namespace Presentacion.Formulario.Configuracion

    Public Class frmImpuesto

        Private _impuestosdeleted As List(Of Impuestos) = New List(Of Impuestos)()

#Region "Evento Form"

        Private Sub frmImpuesto_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            If Me.DialogResult = DialogResult.OK Then
                Try
                    'tratar impuestos
                    Using control As New ImpuestosController
                        Dim nuevos As New List(Of Impuestos)()
                        control.DeleteItems(_impuestosdeleted)
                        For Each impuesto As Impuestos In ImpuestosBindingSource.List
                            If impuesto.idImpuesto = 0 Then
                                nuevos.Add(impuesto)
                            Else
                                control.UpdateItem(impuesto)
                            End If
                        Next
                        control.AddItems(nuevos)
                        gImpuestoPorDefecto = control.GetImpuestoPorDefecto()
                    End Using                    
                Catch ex As Exception
                    MostrarMensaje(ex, Me.Text, Telerik.WinControls.RadMessageIcon.Error, MessageBoxButtons.OK)
                    e.Cancel = True
                End Try
            End If
        End Sub

        Private Sub frmImpuesto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            PrepararControles(Me.Controls)
            ConfigurarCommandBar(cbstrpeAccion)
            btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
        End Sub

        Private Sub frmImpuesto_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            CargarDatos()
        End Sub

        Private Sub frmImpuesto_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
            If e.KeyChar = Convert.ToChar(27) Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If
        End Sub

#End Region

#Region "Evento Grid"

        Private Sub gridDatos_RowFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RowFormattingEventArgs) Handles gridDatos.RowFormatting
            If Not TypeOf e.RowElement Is GridFilterRowElement And Not TypeOf e.RowElement Is GridTableHeaderRowElement Then
                Dim imp As Impuestos = DirectCast(e.RowElement.Data.DataBoundItem, Impuestos)
                If imp.PorDefecto Then
                    e.RowElement.ForeColor = Color.Green
                Else
                    e.RowElement.ForeColor = gridDatos.GridViewElement.ForeColor
                End If
            End If
        End Sub

        Private Sub gridDatos_RowsChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCollectionChangingEventArgs) Handles gridDatos.RowsChanging
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
                e.Cancel = Not MostrarMensaje(My.Resources.Application.ConfirmacionBorrarDato, Me.Text, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes
            End If
        End Sub

        Private Sub gridDatos_RowsChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCollectionChangedEventArgs) Handles gridDatos.RowsChanged
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
                For Each row As GridViewRowInfo In e.OldItems
                    Dim impuesto As Impuestos = DirectCast(row.DataBoundItem, Impuestos)
                    If Not IsNothing(impuesto) AndAlso impuesto.idImpuesto > 0 Then
                        _impuestosdeleted.Add(impuesto)
                    End If
                Next
            End If
        End Sub

#End Region

#Region "Evento Botones Acciones"

        Private Sub cbbtnPordefecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbtnPordefecto.Click
            Dim item As Impuestos = gridDatos.SelectedItem(Of Impuestos)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                For Each row As GridViewDataRowInfo In gridDatos.Rows
                    Dim impuesto As Impuestos = DirectCast(row.DataBoundItem, Impuestos)
                    impuesto.PorDefecto = impuesto.idImpuesto.Equals(item.idImpuesto)
                    row.InvalidateRow()
                Next                
            End If
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub
#End Region

#Region "Operaciones ARD"

        Private Sub CargarDatos()
            Using c As New Controller.ImpuestosController()
                ImpuestosBindingSource.DataSource = c.GetItems("", "Impuesto")
            End Using
        End Sub

#End Region

    End Class

End Namespace
