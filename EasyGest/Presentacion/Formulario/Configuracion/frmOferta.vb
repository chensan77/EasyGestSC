Imports EasyGestControllers
Imports EasyGestControllers.Data
Imports EasyGest.Presentacion.Componente


Namespace Presentacion.Formulario.Configuracion

    Public Class frmOferta

        Private WithEvents cbOrden As Presentacion.Componente.CommandBarSortItem
        'Private WithEvents bkwCarga As New Wi
        Private _panel As New WaitingPanel()
        Private _orden As String = "NumeroOferta ASC"
        Private _oferta As Entity.Ofertas = Nothing

#Region "Evento Form"

        Private Sub frmOferta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Controls.Add(_panel)
            _panel.BringToFront()
            PrepararControles(SplitPanel1.Controls)
            PrepararControles(SplitPanel2.Controls)
            ConfigurarBarraOrden()
            ConfigurarCommandBar(cbstripeAccion)
            ConfigurarCommandBar(Me.cbstripeOrden)
            SplitPanel2.Collapsed = True
            btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
        End Sub

        Private Sub frmOferta_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            CargarDatos()
        End Sub

        Private Sub frmOferta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
            If e.KeyChar = Convert.ToChar(27) Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If
        End Sub

#End Region

#Region "Evento Grid"

        Private Sub gridDatos_RowFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RowFormattingEventArgs) Handles gridDatos.RowFormatting
            If Not TypeOf e.RowElement Is GridFilterRowElement And Not TypeOf e.RowElement Is GridTableHeaderRowElement Then
                Dim oferta As Ofertas = DirectCast(e.RowElement.Data.DataBoundItem, Ofertas)
                If Not oferta.Activo Then
                    e.RowElement.ForeColor = Color.Red
                Else
                    e.RowElement.ForeColor = gridDatos.GridViewElement.ForeColor
                End If
            End If
        End Sub

#End Region

#Region "Evento Botones Acciones"

        Private Sub cbbtnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnAgregar.Click
            EditarAgregar(-1)
        End Sub

        Private Sub cbbtnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnModificar.Click
            Dim item As Ofertas = gridDatos.SelectedItem(Of Ofertas)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                EditarAgregar(item.idOferta)
            End If
        End Sub

        Private Sub cbbtnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnEliminar.Click
            Dim item As Ofertas = gridDatos.SelectedItem(Of Ofertas)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                Eliminar(item.idOferta)
            End If
        End Sub
  
#End Region

#Region "Eventos"

        Private Sub timValidar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timValidar.Tick
            btnAceptar.Enabled = _oferta.IsValid()
        End Sub

        Private Sub radPrecioEspecial_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radPrecioEspecial.ToggleStateChanged
            RadPanel1.Enabled = radPrecioEspecial.IsChecked
            If radPrecioEspecial.IsChecked And Not IsNothing(_oferta) Then
                _oferta.Forma = FormaOfertaEnum.PrecioEspecial
                txtPrecioEspecial.DataBindings.Add("Value", OfertaBindingSource, "Valor1", True, DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2")
                txtPrecioEspecial.Focus()
            Else
                txtPrecioEspecial.DataBindings.Clear()
                txtPrecioEspecial.Value = 0
            End If
        End Sub

        Private Sub radDescuentoEspecial_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radDescuentoPorcentual.ToggleStateChanged
            RadPanel2.Enabled = radDescuentoPorcentual.IsChecked
            If radDescuentoPorcentual.IsChecked And Not IsNothing(_oferta) Then
                _oferta.Forma = FormaOfertaEnum.DescuentoPorcentual
                txtDescPorc.DataBindings.Add("Value", OfertaBindingSource, "Valor1", True, DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2")
                txtDescPorc.Focus()
            Else
                txtDescPorc.DataBindings.Clear()
                txtDescPorc.Value = 0
            End If
        End Sub

        Private Sub radDescuentoFijo_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radDescuentoFijo.ToggleStateChanged
            RadPanel3.Enabled = radDescuentoFijo.IsChecked
            If radDescuentoFijo.IsChecked And Not IsNothing(_oferta) Then
                _oferta.Forma = FormaOfertaEnum.DescuentoFijo
                txtDescFijo.DataBindings.Add("Value", OfertaBindingSource, "Valor1", True, DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2")
                txtDescFijo.Focus()
            Else
                txtDescFijo.DataBindings.Clear()
                txtDescFijo.Value = 0
            End If
        End Sub

        Private Sub radUnidadGratis_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radUnidadGratis.ToggleStateChanged
            RadPanel4.Enabled = radUnidadGratis.IsChecked
            If radUnidadGratis.IsChecked And Not IsNothing(_oferta) Then
                _oferta.Forma = FormaOfertaEnum.UnidadGratis
                txtUnidadBase.DataBindings.Add("Value", OfertaBindingSource, "Valor1", True, DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0")
                txtUnidadGratis.DataBindings.Add("Value", OfertaBindingSource, "Valor2", True, DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0")
                txtUnidadBase.Focus()
            Else
                txtUnidadBase.DataBindings.Clear()
                txtUnidadGratis.DataBindings.Clear()
                txtUnidadBase.Value = 0
                txtUnidadGratis.Value = 0
            End If
        End Sub

        Private Sub radUnidadDescuento_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radUnidadDescuento.ToggleStateChanged
            RadPanel5.Enabled = radUnidadDescuento.IsChecked
            If radUnidadDescuento.IsChecked And Not IsNothing(_oferta) Then
                _oferta.Forma = FormaOfertaEnum.UnidadConDescuento
                txtUnidadBaseD.DataBindings.Add("Value", OfertaBindingSource, "Valor1", True, DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0")
                txtUnidadDesc.DataBindings.Add("Value", OfertaBindingSource, "Valor2", True, DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2")
                txtUnidadBaseD.Focus()
            Else
                txtUnidadBaseD.DataBindings.Clear()
                txtUnidadDesc.DataBindings.Clear()
                txtUnidadBaseD.Value = 0
                txtUnidadDesc.Value = 0
            End If
        End Sub

        Private Sub radUnidadPrecio_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles radUnidadPrecio.ToggleStateChanged
            RadPanel6.Enabled = radUnidadPrecio.IsChecked
            If radUnidadPrecio.IsChecked And Not IsNothing(_oferta) Then
                _oferta.Forma = FormaOfertaEnum.UnidadAPrecioEspecial
                txtUnidadBaseP.DataBindings.Add("Value", OfertaBindingSource, "Valor1", True, DataSourceUpdateMode.OnPropertyChanged, Nothing, "N0")
                txtUnidadPrecio.DataBindings.Add("Value", OfertaBindingSource, "Valor2", True, DataSourceUpdateMode.OnPropertyChanged, Nothing, "N2")
                txtUnidadBaseP.Focus()
            Else
                txtUnidadBaseP.DataBindings.Clear()
                txtUnidadPrecio.DataBindings.Clear()
                txtUnidadBaseP.Value = 0
                txtUnidadPrecio.Value = 0
            End If
        End Sub

#End Region

#Region "Operaciones ARD"

        Private Sub CargarDatos()
            If bgwCarga.IsBusy() Then Return
            _panel.Mostrar()
            bgwCarga.RunWorkerAsync()
        End Sub

        Private Sub Eliminar(ByVal idSeleccionado As Long)
            If MostrarMensaje(My.Resources.Application.ConfirmacionBorrarDato, Me.Text, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Try
                    Using control As New OfertasController
                        control.DeleteItem(idSeleccionado)
                    End Using
                    OfertasBindingSource.RemoveCurrent()
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
        End Sub

        Private Sub EditarAgregar(ByVal id As Long)
            If id = -1 Then
                _oferta = Controller.OfertasController.NewItem()
            Else
                Using c As New Controller.OfertasController()
                    _oferta = c.GetItem(id)
                End Using
                _oferta.SetAsUpdateOnSubmit()
            End If

            OfertaBindingSource.DataSource = _oferta
            timValidar.Enabled = True
            SplitPanel2.Collapsed = False
            SplitPanel1.Collapsed = True
            btnAceptar.Enabled = False
            cbstripeAccion.Enabled = False
            cbstripeOrden.Enabled = False
            txtDescripcion.Focus()
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            _oferta = Nothing
            SplitPanel2.Collapsed = True
            SplitPanel1.Collapsed = False
            timValidar.Enabled = False
            cbstripeAccion.Enabled = True
            cbstripeOrden.Enabled = True
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            Try
                Using control As New OfertasController()
                    If _oferta.LINQEntityState = EntityState.New Then
                        Me.OfertasBindingSource.Add(_oferta)
                    End If
                    control.SyncronisingItem(_oferta)
                End Using

                UpdateSelectGridRow(gridDatos, _oferta)
                
                OfertaBindingSource.RemoveCurrent()
                SplitPanel2.Collapsed = True
                SplitPanel1.Collapsed = False
                timValidar.Enabled = False
                cbstripeAccion.Enabled = True
                cbstripeOrden.Enabled = True
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub OfertaBindingSource_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OfertaBindingSource.DataSourceChanged
            Dim oferta As Ofertas = Nothing
            oferta = TryCast(OfertaBindingSource.DataSource, Ofertas)
            InterpretarFormula(oferta)
        End Sub

        Private Sub InterpretarFormula(ByVal oferta As Ofertas)
            radPrecioEspecial.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate
            radDescuentoPorcentual.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate
            radDescuentoFijo.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate
            radUnidadGratis.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate
            radUnidadDescuento.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate
            radUnidadPrecio.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Indeterminate
            If Not IsNothing(oferta) Then
                Select Case oferta.Forma
                    Case FormaOfertaEnum.PrecioEspecial
                        radPrecioEspecial.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
                    Case FormaOfertaEnum.DescuentoPorcentual
                        radDescuentoPorcentual.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
                    Case FormaOfertaEnum.DescuentoFijo
                        radDescuentoFijo.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
                    Case FormaOfertaEnum.UnidadGratis
                        radUnidadGratis.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
                    Case FormaOfertaEnum.UnidadConDescuento
                        radUnidadDescuento.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
                    Case FormaOfertaEnum.UnidadAPrecioEspecial
                        radUnidadPrecio.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
                    Case Else

                End Select
            End If
        End Sub
        Private Sub bgwCarga_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarga.DoWork
            System.Threading.Thread.CurrentThread.CurrentCulture = GetApplicationCulture(Me)
            Using c As New Controller.OfertasController()
                Dim datos As IEnumerable(Of Ofertas)
                datos = c.GetItems("", _orden)
                e.Result = datos
            End Using
        End Sub

        Private Sub bgwCarga_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwCarga.RunWorkerCompleted
            _panel.Ocultar()
            If Not IsNothing(e.Error) Then
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
            Else
                Try
                    OfertasBindingSource.DataSource = e.Result
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If

        End Sub

#End Region

#Region "Ordenación"

        Private Sub cbOrden_onSort(ByVal sender As CommandBarSortItem, ByVal e As SortEventArgs) Handles cbOrden.onSort
            gridDatos.FilterDescriptors.Clear()
            gridDatos.SortDescriptors.Clear()
            _orden = e.SortExpression
            CargarDatos()
        End Sub

        Private Sub ConfigurarBarraOrden()
            cbOrden = New Presentacion.Componente.CommandBarSortItem(cbstripeOrden)
            cbOrden.AddItemToFieldDDL(gridDatos.Columns("NumeroOferta").HeaderText, "NumeroOferta")
            cbOrden.AddItemToFieldDDL(gridDatos.Columns("FInicio").HeaderText, "FInicio")
            cbOrden.Prepare("")
        End Sub

#End Region

    End Class

End Namespace
