Imports EasyGestControllers.Controller

Namespace Presentacion.Formulario.Producto

    Public Class frmCaracteristicaProducto

        Private _idProducto As Long
        Private _modificado As Boolean = False
        Private _tempObject As Object

        Private Sub frmCaracteristicaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            PrepararControles(gboxNuevo.Controls)
            Try
                Using control As New TiposDatoCaractProductoController()
                    TiposDatoCaractProductoBindingSource.DataSource = control.GetItems()
                End Using
                Using control As New CaracteristicasProductoController()
                    CaracteristicasProductoBindingSource.DataSource = control.GetCaracteristicasByProducto(_idProducto)
                End Using
                propgridCaracteristica.SelectedObject = ConstruirObjeto()
                btnAgregarCaracteristica.Enabled = False
                btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
                timValidar.Enabled = True
                ddlTipoCaracteristica.SelectedIndex = -1
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                btnAceptar.Enabled = False
            End Try
        End Sub

        Public Sub New(ByVal idProducto As Long)

            ' Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            _idProducto = idProducto
        End Sub


        Private Sub timValidar_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timValidar.Tick
            btnAgregarCaracteristica.Enabled = Not String.IsNullOrWhiteSpace(txtCaracteristica.Text) And ddlTipoCaracteristica.SelectedIndex >= 0
        End Sub

        Private Sub CancelarForm()
            'Me.DialogResult = Windows.Forms.DialogResult.Cancel
            timValidar.Enabled = False
        End Sub

        Private Sub AceptarForm()
            timValidar.Enabled = False
            If _modificado Then
                Using control As New CaracteristicasProductoController()
                    control.SetCaracteristicasOfProducto(_idProducto, DirectCast(CaracteristicasProductoBindingSource.DataSource, IEnumerable(Of CaracteristicasProducto)))
                End Using
            End If
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AceptarForm()
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            CancelarForm()
        End Sub

        Private Function ConstruirObjeto() As RadPropertyStore
            Dim store As New RadPropertyStore()
            If IsNothing(CaracteristicasProductoBindingSource.DataSource) OrElse DirectCast(CaracteristicasProductoBindingSource.DataSource, IList).Count = 0 Then Return Nothing

            For Each c As CaracteristicasProducto In DirectCast(CaracteristicasProductoBindingSource.DataSource, IEnumerable)
                Dim item As PropertyStoreItem
                item = New PropertyStoreItem(c.TipoDato, c.Caracteristica, c.ValorDato)
                store.Add(item)
                'store(store.Count - 1).Label = c.NombrePropiedad
            Next

            Return store
        End Function


        Private Sub propgridCaracteristica_PropertyValueChanged(sender As Object, e As Telerik.WinControls.UI.PropertyGridItemValueChangedEventArgs) Handles propgridCaracteristica.PropertyValueChanged
            Dim propitem As PropertyGridItem = DirectCast(e.Item, PropertyGridItem)
            Dim carac As CaracteristicasProducto = DirectCast(CaracteristicasProductoBindingSource.DataSource, IEnumerable(Of CaracteristicasProducto)).Where(Function(c As CaracteristicasProducto) c.Caracteristica.Equals(propitem.Name)).First
            If propitem.PropertyType.Equals(GetType(Color)) Then
                carac.Valor = ColorTranslator.ToHtml(CType(propitem.Value, Color))
            Else
                carac.Valor = propitem.Value.ToString()
            End If
            _modificado = True
        End Sub

        Private Sub propgridCaracteristica_SelectedObjectChanging(sender As System.Object, e As Telerik.WinControls.UI.PropertyGridSelectedObjectChangingEventArgs) Handles propgridCaracteristica.SelectedObjectChanging
            If Not IsNothing(e.SelectedObject) Then
                propgridCaracteristica.RadContextMenu = cmenuCaracteristica
            Else
                propgridCaracteristica.RadContextMenu = Nothing
            End If
        End Sub

        Private Sub btnAgregarCaracteristica_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarCaracteristica.Click
            Dim carac As CaracteristicasProducto = CaracteristicasProductoController.NewItem(_idProducto)
            Dim nombre As String = txtCaracteristica.Text.Trim().PascalCase(True)
            If Not EstarDuplicado(nombre) Then
                carac.Tipo = CShort(ddlTipoCaracteristica.SelectedValue)
                carac.Caracteristica = nombre
                carac.idCaracteristica = Now().Ticks * -1
                CaracteristicasProductoBindingSource.Add(carac)
                propgridCaracteristica.SelectedObject = ConstruirObjeto()
                _modificado = True
                txtCaracteristica.Clear()
                ddlTipoCaracteristica.SelectedIndex = -1
            End If
        End Sub

        Private Function EstarDuplicado(valor As String) As Boolean
            Dim codigos As IEnumerable(Of CaracteristicasProducto) = DirectCast(CaracteristicasProductoBindingSource.DataSource, Global.System.Collections.Generic.IEnumerable(Of Global.EasyGestControllers.Data.Entity.CaracteristicasProducto))
            Dim numReg As Integer = 0
            numReg = codigos.Where(Function(d As CaracteristicasProducto) d.NombrePropiedad.Equals(valor)).Count()
            Return numReg > 0
        End Function

        Private Sub mitemEliminar_Click(sender As Object, e As System.EventArgs) Handles mitemEliminar.Click
            Dim item As PropertyGridItem
            Dim carac As CaracteristicasProducto
            If Not IsNothing(propgridCaracteristica.SelectedGridItem) Then
                item = DirectCast(propgridCaracteristica.SelectedGridItem, PropertyGridItem)
                carac = DirectCast(CaracteristicasProductoBindingSource.DataSource, IEnumerable(Of CaracteristicasProducto)).Where(Function(c As CaracteristicasProducto) c.Caracteristica.Equals(item.Name)).First
                CaracteristicasProductoBindingSource.Remove(carac)
                propgridCaracteristica.SelectedObject = ConstruirObjeto()
                _modificado = True
            End If
        End Sub
    End Class

End Namespace
