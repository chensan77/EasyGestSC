Imports EasyGestControllers.Controller


Namespace Presentacion.Formulario.Producto

    Public Class frmProductoEdicion

        Private _producto As Entity.Productos = Nothing
        Private _action As System.Data.Linq.ChangeAction = System.Data.Linq.ChangeAction.None
        Private _modificadoCodigo As Boolean = False

        Private Sub frmProductoEdicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Try
                PrepararControles(Me.Controls)
                AddHandler chkControlStock.KeyPress, AddressOf checkbox_KeyPress
                AddHandler chkPrecioVariable.KeyPress, AddressOf checkbox_KeyPress
                spinUnidadPaquete.DecimalPlaces = CInt(IIf(gConfGlobal.UsarDecimalCantidad, 2, 0))
                spinStock.DecimalPlaces = CInt(IIf(gConfGlobal.UsarDecimalCantidad, 2, 0))
                spinStockPaquete.DecimalPlaces = CInt(IIf(gConfGlobal.UsarDecimalCantidad, 2, 0))
                spinUnidadVenta.DecimalPlaces = CInt(IIf(gConfGlobal.UsarDecimalCantidad, 2, 0))
                Me.Size = New Size(Me.Width - 200, Me.Height)
                SplitPanel2.Collapsed = True
                ' cargar los comboboxs
                Using control As New UnidadesMedidaController
                    UnidadesMedidaBindingSource.DataSource = control.GetItems("", "Medida ASC")
                End Using
                Using control As New MarcasController
                    MarcasBindingSource.DataSource = control.GetItems("", "Marca ASC")
                End Using
                Using control As New UbicacionesController
                    UbicacionesBindingSource.DataSource = control.GetItems("", "Ubicacion ASC")
                End Using
                Using control As New FamiliasController
                    FamiliasBindingSource.DataSource = control.GetItems("", "Familia ASC")
                End Using
                Using control As New ImpuestosController
                    ImpuestosBindingSource.DataSource = control.GetItems()
                End Using
                Using control As New CodigosBarraController
                    CodigosBarraBindingSource.DataSource = control.GetCodigosBarraByProducto(_producto.idProducto)
                End Using
                Me.ProductosBindingSource.DataSource = _producto
                btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
                btnAceptar.Enabled = False
                timValidar.Enabled = True
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                btnAceptar.Enabled = False
            End Try
        End Sub

        Public Sub New(ByVal idProducto As Long)

            ' Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            If idProducto = -1 Then
                _producto = ProductosController.NewItem()
                _producto.PrecioImpInc = gConfGlobal.ImpuestoIncluidoPrecioVenta
                _producto.idImpuesto = gImpuestoPorDefecto.idImpuesto
                _producto.ControlStock = gConfGlobal.ControlStock
                _action = System.Data.Linq.ChangeAction.Insert
            Else
                _action = System.Data.Linq.ChangeAction.Update
                Using control As New ProductosController
                    _producto = control.GetItem(idProducto)
                End Using
            End If

        End Sub

        Protected Friend ReadOnly Property Producto() As Entity.VWProductos
            Get
                Dim pro As Entity.VWProductos = Nothing
                If _producto IsNot Nothing Then
                    Using control As New VistasController(Of Entity.VWProductos)
                        pro = control.GetItem(_producto.idProducto)
                    End Using
                End If
                Return pro
            End Get
        End Property

        Private Sub timValidar_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timValidar.Tick
            btnAceptar.Enabled = _producto.IsValid(_action)
        End Sub

        Private Sub CancelarForm()
            'Me.DialogResult = Windows.Forms.DialogResult.Cancel
            timValidar.Enabled = False
            _producto = Nothing
        End Sub

        Private Sub AceptarForm()
            timValidar.Enabled = False
            Using control As New ProductosController
                If _action = System.Data.Linq.ChangeAction.Insert Then
                    _producto = control.AddItem(_producto)
                ElseIf _action = System.Data.Linq.ChangeAction.Update Then
                    control.UpdateItem(_producto)
                End If
            End Using
            If _modificadoCodigo Then
                Using control As New CodigosBarraController
                    control.SetCodigosBarraOfProducto(_producto.idProducto, DirectCast(CodigosBarraBindingSource.DataSource, IEnumerable(Of CodigosBarra)))
                End Using
            End If
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AceptarForm()            
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            CancelarForm()
        End Sub

        Private Sub chkPrecioVariable_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkPrecioVariable.ToggleStateChanged
            grpbPrecio.Enabled = Not chkPrecioVariable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
        End Sub

        Private Sub chkControlStock_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkControlStock.ToggleStateChanged
            grpbStock.Enabled = chkControlStock.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
        End Sub

        Private Sub btnQuitarUnidad_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarUnidad.Click
            _producto.idUnidadMedida = Nothing
        End Sub

        Private Sub btnQuitarMarca_Click(sender As Object, e As System.EventArgs) Handles btnQuitarMarca.Click
            _producto.idMarca = Nothing
        End Sub

        Private Sub btnQuitarUbicacion_Click(sender As Object, e As System.EventArgs) Handles btnQuitarUbicacion.Click
            _producto.idUbicacion = Nothing
        End Sub

        Private Sub btnQuitarFamilia_Click(sender As Object, e As System.EventArgs) Handles btnQuitarFamilia.Click
            _producto.idFamilia = Nothing
        End Sub

        Private Sub btnGenerarReferencia_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarReferencia.Click
            txtReferencia.Text = GenerarReferencia()
        End Sub

        Private Function GenerarReferencia() As String
            Dim refe As String = ""
            Dim ch As Char
            Dim random As New Random()

            For i As Integer = 0 To 1
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)))
                refe &= ch
            Next
            refe &= "-" & CStr(random.Next(0, Now().Millisecond)).PadLeft(3, "0"c)

            Return refe
        End Function

        Private Sub toggleCodigoBarra_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles toggleCodigoBarra.ToggleStateChanged
            If args.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                Me.Size = New Size(Me.Width + 200, Me.Height)
                btnAceptar.Location = New Point(btnAceptar.Location.X + 200, btnAceptar.Location.Y)
                btnCancelar.Location = New Point(btnCancelar.Location.X + 200, btnCancelar.Location.Y)
                SplitPanel2.Collapsed = False
            Else
                SplitPanel2.Collapsed = True
                Me.Size = New Size(Me.Width - 200, Me.Height)
                btnAceptar.Location = New Point(btnAceptar.Location.X - 200, btnAceptar.Location.Y)
                btnCancelar.Location = New Point(btnCancelar.Location.X - 200, btnCancelar.Location.Y)
            End If

        End Sub

#Region "Evento Grid"

        Private Sub gridDatos_RowsChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCollectionChangingEventArgs) Handles gridDatos.RowsChanging
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
                e.Cancel = Not MostrarMensaje(My.Resources.Application.ConfirmacionBorrarDato, Me.Text, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes
            End If
        End Sub

        Private Sub gridDatos_RowsChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCollectionChangedEventArgs) Handles gridDatos.RowsChanged
            If Not (e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Reset Or
                e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Move Or
                e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Batch Or
                e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Replace) Then
                _modificadoCodigo = True
            End If
        End Sub

        Private Sub gridDatos_CellValidating(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.CellValidatingEventArgs) Handles gridDatos.CellValidating
            If IsNothing(e.Row) Or IsNothing(e.Column) Then Return

            If String.IsNullOrWhiteSpace(CStr(e.Value)) Then
                e.Cancel = True
                e.Row.ErrorText = My.Resources.Application.TextoValorRequerido
            Else
                If EstarDuplicado(e.Value.ToString(), e.RowIndex = -1) Then
                    e.Cancel = True
                    e.Row.ErrorText = My.Resources.Application.TextoValorDuplicado
                Else
                    e.Row.ErrorText = String.Empty
                End If
            End If
        End Sub
#End Region

        Private Function EstarDuplicado(ByVal valor As String, ByVal nueva As Boolean) As Boolean
            Dim codigos As IEnumerable(Of CodigosBarra) = DirectCast(CodigosBarraBindingSource.DataSource, IEnumerable(Of CodigosBarra))
            Dim numReg As Integer = 0
            numReg = codigos.Where(Function(d As CodigosBarra) d.CodigoBarra.Equals(valor)).Count()
            Return CBool(IIf(nueva, numReg > 0, numReg > 1))
        End Function

       
    End Class

End Namespace
