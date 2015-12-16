
Namespace Presentacion.Formulario.CompraVenta

    Public Class frmVentaCobro

        Private _total As Single = 0.0
        Private _entregado As Single = 0.0
        Private _devolucion As Single = 0.0
        Private _listaVales As New List(Of Entity.Vales)

        Protected Friend ReadOnly Property Facturar() As Boolean
            Get
                Return toggleFacturar.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            End Get
        End Property

        Protected Friend ReadOnly Property Debido() As Boolean
            Get
                Return _devolucion < 0
            End Get
        End Property

        Protected Friend ReadOnly Property Diferencia() As Single
            Get
                Return _devolucion
            End Get
        End Property

        Protected Friend ReadOnly Property ModoPago() As Short
            Get
                Return Convert.ToInt16(ddlModoPago.SelectedValue)
            End Get
        End Property

        Protected Friend ReadOnly Property EntregadoEnVale() As Single
            Get
                Return _listaVales.Sum(Function(v As Entity.Vales) v.Importe)
            End Get
        End Property

        Protected Friend ReadOnly Property Vales() As List(Of Entity.Vales)
            Get
                Return _listaVales
            End Get
        End Property

        Protected Friend Property Imprimir As Boolean?
            Get
                Return toggleImprimir.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            End Get
            Set(ByVal value As Boolean?)
                If value.HasValue Then
                    toggleImprimir.ToggleState = DirectCast(IIf(value.Value, Telerik.WinControls.Enumerations.ToggleState.On, Telerik.WinControls.Enumerations.ToggleState.Off), Telerik.WinControls.Enumerations.ToggleState)
                Else
                    toggleImprimir.ToggleState = DirectCast(IIf(gConfGlobal.ImprimirSiempreVenta, Telerik.WinControls.Enumerations.ToggleState.On, Telerik.WinControls.Enumerations.ToggleState.Off), Telerik.WinControls.Enumerations.ToggleState)
                End If
            End Set
        End Property

        Protected Friend WriteOnly Property Total As Single
            Set(value As Single)
                _total = value
            End Set
        End Property

        Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Enter And txtNumeroVale.Focused Then
                e.Handled = True
                'Else
                '    Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
            MyBase.OnKeyDown(e)
        End Sub

        Private Sub frmVentaCobro_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            'centrar panel
            Dim x, y As Integer
            x = CInt(Math.Round(Me.Width / 2 - pnlContenido.Width / 2))
            y = CInt(Math.Round(Me.Height / 2 - pnlContenido.Height / 2))
            pnlContenido.Location = New Point(x, y)
        End Sub

        Private Sub frmBDConexion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        End Sub

        Private Sub frmVentaCobro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            PrepararControles(Me.Controls)
            btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
            Try
                Using control As New EasyGestControllers.Controller.ModosPagoController()
                    ModosPagoBindingSource.DataSource = control.GetItems()
                End Using
                ddlModoPago.SelectedValue = Entity.ModoPagoEnum.Metalico
            Catch ex As Exception

            End Try
            toggleFacturar.ToggleState = DirectCast(IIf(gConfGlobal.FacturarSiempreVenta, Telerik.WinControls.Enumerations.ToggleState.On, Telerik.WinControls.Enumerations.ToggleState.Off), Telerik.WinControls.Enumerations.ToggleState)
            txtTotalVenta.Text = FormatCurrency(_total, 2)
            txtEntregado.Value = _total
            txtEntregado.SelectionStart = 0
            txtEntregado.SelectionLength = txtEntregado.Text.Length
            txtEntregado.Focus()
        End Sub

        Private Sub txtNumeroVale_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtNumeroVale.PreviewKeyDown
            If Not txtNumeroVale.Text.Trim.Equals("") And e.KeyCode = Keys.Enter Then
                Dim vale As Entity.Vales
                Try
                    Using control As New EasyGestControllers.Controller.ValesController()
                        vale = control.GetItemByNumero(txtNumeroVale.Text)
                    End Using
                    If vale IsNot Nothing Then
                        If Not vale.Activo Then
                            MostrarMensaje(My.Resources.Application.AvisoValeNoValido, My.Application.Info.Title, Telerik.WinControls.RadMessageIcon.Exclamation, MessageBoxButtons.OK)
                        Else
                            Dim aceptar As Boolean
                            aceptar = Not _listaVales.Any(Function(V) V.idVale.Equals(vale.idVale))
                            If aceptar And vale.Caducado Then
                                aceptar = MostrarMensaje(My.Resources.Application.ConfirmacionAceptarValeCaducado, My.Application.Info.Title, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo, True) = Windows.Forms.DialogResult.Yes
                            End If
                            If aceptar Then
                                _listaVales.Add(vale)
                                RefrescarDiferencia()
                                ' añadir a la listview
                                lstvVales.Refresh()
                                txtEntregado.Focus()
                            End If
                        End If
                    End If
                Catch ex As Exception
                Finally
                    txtNumeroVale.Clear()
                End Try


            End If
        End Sub

        Private Sub txtContraseña_TextChanged(sender As System.Object, e As System.EventArgs)

        End Sub

        Private Sub lstvVales_CellFormatting(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.ListViewCellFormattingEventArgs) Handles lstvVales.CellFormatting
            e.CellElement.Font = gDefaultFont
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter            
        End Sub

        Private Sub txtEntregado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEntregado.ValueChanged
            _entregado = Convert.ToSingle(txtEntregado.Value)
        End Sub

        Private Sub RefrescarDiferencia()            
            _devolucion = (_entregado + EntregadoEnVale) - _total
            txtDevolucion.Text = FormatNumber(_devolucion, 2)
        End Sub

        Private Sub txtDevolucion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDevolucion.TextChanged
            txtDevolucion.ForeColor = DirectCast(IIf(Debido, Color.Red, Color.Green), Color)
        End Sub

        Private Sub lstvVales_ItemRemoved(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewItemEventArgs) Handles lstvVales.ItemRemoved
            RefrescarDiferencia()
        End Sub

    End Class
End Namespace