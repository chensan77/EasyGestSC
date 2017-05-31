
Imports Telerik.WinControls.UI.Docking

Namespace Presentacion.Formulario.CompraVenta
    Public Class frmVenta

        Dim _albaranActual As Albaranes

        Public Sub New()

            ' Esta llamada es exigida por el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        End Sub

        Private Function BuscarProducto(referencia As String) As IEnumerable(Of VWProductos)
            Dim productos As IEnumerable(Of VWProductos)
            Using control As New ProductosController()
                productos = control.GetItemsByReference(referencia)
            End Using
            Return productos
        End Function

        Private Sub cbbtnTerminar_Click(sender As Object, e As EventArgs) Handles cbbtnTerminar.Click
            Dim frm As New Presentacion.Formulario.Dialogo.frmCompraPago()
            frm.Total = 12.0
            If frm.ShowDialog() = DialogResult.OK Then
                My.Forms.frmPrincipal.ShowAlerta("Venta", CStr(frm.Entregado))
            End If
        End Sub

        Private Sub mitemCrearProducto_Click(sender As Object, e As EventArgs) Handles mitemCrearProducto.Click
            Dim frm As New Producto.frmProductoEdicion(-1)
            If frm.ShowDialog() = DialogResult.OK Then
                Dim producto As VWProductos = frm.Producto
                CrearLinea(producto)
            End If
        End Sub

        Private Sub cbbtnCrear_Click(sender As Object, e As EventArgs) Handles cbbtnCrear.Click
            CrearVenta()
            txtIntroduccion.Focus()
        End Sub

        Private Sub CrearVenta()
            Dim page As New RadPageViewPage()
            Dim grid As New RadGridView()
            Dim nombreArchivo As String
            Dim listaLineas As New List(Of LineasAlbaran)()
            Dim albaran As Albaranes = New Albaranes()
            albaran.SerieAlbaran = cbddlSeries.SelectedText
            albaran.LineasAlbaran = listaLineas.ConvertToEntitySet()
            albaran.idEmpresa = gEmpresa.idEmpresa
            albaran.idPuestoEmitido = gPuesto.idPuesto
            albaran.idUsuarioEmitido = gUsuario.idUsuario
            albaran.Contable = True

            If Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("zh") Then
                nombreArchivo = My.Application.Info.DirectoryPath & "/Resources/GridVentaProperty_zh.xml"
            Else
                nombreArchivo = My.Application.Info.DirectoryPath & "/Resources/GridVentaProperty.xml"
            End If
            LineasAlbaranBindingSource.DataSource = albaran.LineasAlbaran.ToList
            grid.AutoGenerateColumns = False

            grid.DataSource = LineasAlbaranBindingSource
            grid.Dock = DockStyle.Fill

            grid.LoadLayout(nombreArchivo)
            page.Tag = albaran

            page.Controls.Add(grid)
            PrepararControles(page.Controls)
            pagevVentas.Pages.Add(page)


        End Sub

        Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles Me.Load

            ConfigurarCommandBar(Me.cbstripeAccion)
            ConfigurarCommandBar(Me.cbstripeBuscar)
            ConfigurarCommandBar(Me.cbstripeSerie)
            PrepararControles(ToolWindow1.Controls)
            PrepararControles(ToolWindow2.Controls)
            PrepararControles(ToolWindow3.Controls)
            cbddlSeries.DataSource = gEmpresa.SeriesArray
            cbbtnBuscarCliente.Shortcuts.Add(New RadShortcut(Keys.Shift, Keys.F1))
            cbbtnBuscarProducto.Shortcuts.Add(New RadShortcut(Keys.Shift, Keys.F2))
            mitemCrearCliente.Shortcuts.Add(New RadShortcut(Keys.Control, Keys.A, Keys.C))
            mitemCrearProducto.Shortcuts.Add(New RadShortcut(Keys.Control, Keys.A, Keys.P))
            CrearVenta()
            Try
                Using control As New ProductosController()
                    Me.ProductosBindingSource.DataSource = control.GetItems("Activo == true ").Take(1000)

                End Using
            Catch ex As Exception

            End Try
        End Sub


        Private Sub RefrescarDatoAlbaran(albaran As Albaranes)
            _albaranActual = albaran
            LineasAlbaranBindingSource.DataSource = _albaranActual.LineasAlbaran.ToList
            lblNumPieza.Text = FormatNumber(albaran.NumeroPiezas, CInt(IIf(gConfGlobal.UsarDecimalCantidad, 2, 0)))
            lblTotal.Text = FormatCurrency(albaran.Importe, 2)
            If albaran.idCliente.HasValue() Then
                Dim cliente As VWClientes = VistasController(Of VWClientes).NewItem
                cliente.idCliente = albaran.idCliente.Value
                cliente.Nombre = albaran.Cliente
                RefrescarDatoCliente(cliente)
            Else

                RefrescarDatoCliente(Nothing)
            End If

        End Sub

        Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged
            If String.IsNullOrEmpty(txtCliente.Text) Then
                RefrescarDatoCliente(Nothing)
            End If
        End Sub

        Private Sub cbbtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles cbbtnBuscarCliente.Click
            cbbtnBuscarCliente.DropDownMenu.ClosePopup(RadPopupCloseReason.ParentClosed)
            Dim f As New Presentacion.Formulario.Dialogo.frmBuscador(Dialogo.frmBuscador.ObjetoBusqueda.Cliente)
            If f.ShowDialog(My.Forms.frmPrincipal) = DialogResult.OK Then
                RefrescarDatoCliente(DirectCast(f.ObjetoEncontrado, VWClientes))
            End If
            txtIntroduccion.Focus()
        End Sub

        Private Sub RefrescarDatoCliente(cliente As VWClientes)
            If IsNothing(cliente) Then
                _albaranActual.idCliente = Nothing
                txtCliente.Text = String.Empty
                pagevVentas.SelectedPage.Text = "Venta_" & Now().ToString("HH:mm:ss")
            Else
                _albaranActual.idCliente = cliente.idCliente
                _albaranActual.Cliente = cliente.Nombre
                txtCliente.Text = cliente.Nombre
                pagevVentas.SelectedPage.Text = "Venta_" & cliente.Nombre
            End If
            lblVentaActual.Text = pagevVentas.SelectedPage.Text

        End Sub

        Private Function CrearLinea(producto As VWProductos) As LineasAlbaran
            Dim linea As LineasAlbaran = LineasAlbaranController.NewItem()
            linea.idProducto = producto.idProducto
            linea.Referencia = producto.Referencia
            linea.DescripcionProducto = producto.Descripcion
            linea.Albaran = _albaranActual
            linea.Recargo = producto.RE
            linea.Impuesto = producto.Impuesto
            If producto.ControlStock Then
                linea.StockProductoActual = producto.StockSuelto
            End If
            linea.UnidadXCaja = producto.UnidadXCaja
            linea.UnidadVenta = producto.UnidadVenta
            linea.Cantidad = linea.UnidadVenta
            If producto.PrecioImpInc Then
                linea.PrecioFinal = producto.PrecioVenta
            Else
                linea.Precio = producto.PrecioVenta * CSng(IIf(producto.Impuesto.HasValue(), producto.Impuesto.Value, 1.0))
            End If
            linea.idAlbaran = _albaranActual.idAlbaran

            Return linea
        End Function



        Private Sub cbbtnBuscarProducto_Click(sender As Object, e As EventArgs) Handles cbbtnBuscarProducto.Click
            cbbtnBuscarProducto.DropDownMenu.ClosePopup(RadPopupCloseReason.ParentClosed)
            Dim f As New Presentacion.Formulario.Dialogo.frmBuscador(Dialogo.frmBuscador.ObjetoBusqueda.Producto)
            If f.ShowDialog(My.Forms.frmPrincipal) = DialogResult.OK Then
                Dim producto As VWProductos = DirectCast(f.ObjetoEncontrado, VWProductos)
                LineasAlbaranBindingSource.Add(CrearLinea(producto))
            End If
            txtIntroduccion.Focus()
        End Sub

        Private Sub pagevVentas_SelectedPageChanging(sender As Object, e As RadPageViewCancelEventArgs) Handles pagevVentas.SelectedPageChanging
            If Not pagevVentas.SelectedPage Is Nothing Then
                Dim albaran As Albaranes = Nothing
                _albaranActual.ShallowCopy(albaran)
                pagevVentas.SelectedPage.Tag = albaran
                LineasAlbaranBindingSource.Clear()
            End If
        End Sub

        Private Sub pagevVentas_PageRemoving(sender As Object, e As RadPageViewCancelEventArgs) Handles pagevVentas.PageRemoving
            Dim albaran As Albaranes = DirectCast(e.Page.Tag, Albaranes)
            If albaran.LineasAlbaran.Count > 0 Then
                Dim result As DialogResult = MostrarMensaje(My.Resources.Application.ConfirmacionGuardarAlbaran, Me.Text, RadMessageIcon.Question, MessageBoxButtons.YesNoCancel)
                e.Cancel = result = DialogResult.Cancel
                If result = DialogResult.Yes Then
                    GuardarAlbaran(albaran)
                End If
            End If
        End Sub

        Private Sub GuardarAlbaran(albaran As Albaranes)

        End Sub

        Private Sub pagevVentas_PageAdded(sender As Object, e As RadPageViewEventArgs) Handles pagevVentas.PageAdded
            e.Page.Text = "Venta_" + Now().ToString("HH:mm:ss")
            pagevVentas.SelectedPage = e.Page
        End Sub

        Private Sub pagevVentas_SelectedPageChanged(sender As Object, e As EventArgs) Handles pagevVentas.SelectedPageChanged
            If Not IsNothing(pagevVentas.SelectedPage) Then
                RefrescarDatoAlbaran(DirectCast(pagevVentas.SelectedPage.Tag, Albaranes))
            Else
                _albaranActual = Nothing
                lblNumPieza.Text = String.Empty
                lblStockActual.Text = String.Empty
                lblTotal.Text = String.Empty
                lblUnidadVenta.Text = String.Empty
                lblVentaActual.Text = String.Empty
                txtCliente.Clear()

            End If
        End Sub

        Private Sub mitemCrearCliente_Click(sender As Object, e As EventArgs) Handles mitemCrearCliente.Click
            Dim frm As New Cliente.frmClienteEdicion(-1)
            If frm.ShowDialog() = DialogResult.OK Then
                RefrescarDatoCliente(frm.Cliente)
            End If
            txtIntroduccion.Focus()
        End Sub

        Private Sub txtIntroduccion_KeyUp(sender As Object, e As KeyEventArgs) Handles txtIntroduccion.KeyUp
            If e.KeyCode = Keys.Enter Then
                If Not String.IsNullOrWhiteSpace(txtIntroduccion.Text) Then
                    Dim productos As IEnumerable(Of VWProductos) = BuscarProducto(txtIntroduccion.Text.Trim())
                    If productos.Count > 0 Then
                        LineasAlbaranBindingSource.Add(CrearLinea(productos.First()))
                        txtIntroduccion.Clear()
                    End If

                End If
            End If
        End Sub

        Private Sub frmVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
            Dim datos As String = txtIntroduccion.Text
            If e.KeyCode = Keys.Up Then
                LineasAlbaranBindingSource.MovePrevious()
                e.SuppressKeyPress = True
            End If
            If e.KeyCode = Keys.Down Then
                LineasAlbaranBindingSource.MoveNext()
                e.SuppressKeyPress = True
            End If
            If e.KeyCode = Keys.Add Or e.KeyCode = Keys.Subtract Then
                If Not IsNothing(LineasAlbaranBindingSource.Current) Then

                    Dim cantidad As Single = 1.0F * CSng(IIf(e.KeyCode = Keys.Subtract, -1.0F, 1.0F))
                    If IsNumeric(datos) Then
                        cantidad = cantidad * Convert.ToSingle(datos)
                        txtIntroduccion.Clear()
                    End If
                    ActualizarCantidad(DirectCast(LineasAlbaranBindingSource.Current, LineasAlbaran), cantidad)

                End If
                e.SuppressKeyPress = True
            End If
            If e.KeyCode = Keys.Multiply Then
                If Not IsNothing(LineasAlbaranBindingSource.Current) Then
                    Dim linea As LineasAlbaran = DirectCast(LineasAlbaranBindingSource.Current, LineasAlbaran)
                    Dim cantidad As Single
                    If IsNumeric(datos) And linea.UnidadXCaja.HasValue Then
                        cantidad = Convert.ToSingle(datos)
                        ActualizarCantidad(linea, cantidad * linea.UnidadXCaja.Value)
                        txtIntroduccion.Clear()
                    End If

                End If
                e.SuppressKeyPress = True
            End If
            If e.KeyCode = Keys.Divide Then
                If IsNumeric(datos) Then
                    Dim cantidad As Single
                    cantidad = Convert.ToSingle(datos)
                    If Not e.Control Then
                        If Not IsNothing(LineasAlbaranBindingSource.Current) Then
                            DirectCast(LineasAlbaranBindingSource.Current, LineasAlbaran).Descuento = cantidad
                        End If
                    Else
                        Dim lineas As IList(Of LineasAlbaran) = DirectCast(LineasAlbaranBindingSource.DataSource, IList(Of LineasAlbaran))
                        For Each linea As LineasAlbaran In lineas
                            linea.Descuento = cantidad
                        Next
                    End If
                    txtIntroduccion.Clear()

                End If

                e.SuppressKeyPress = True
            End If
        End Sub

        Private Sub ActualizarCantidad(linea As LineasAlbaran, cantidad As Single)
            linea.Cantidad += cantidad * linea.UnidadVenta
        End Sub

        Private Sub frmVenta_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
            txtIntroduccion.Focus()
        End Sub

        Private Sub LineasAlbaranBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles LineasAlbaranBindingSource.CurrentItemChanged
            If Not IsNothing(_albaranActual) Then
                lblNumPieza.Text = FormatNumber(_albaranActual.NumeroPiezas, CInt(IIf(gConfGlobal.UsarDecimalCantidad, 2, 0)))
                lblTotal.Text = FormatCurrency(_albaranActual.Importe, 2)
            End If
            If Not IsNothing(LineasAlbaranBindingSource.Current) Then
                Dim linea As LineasAlbaran = DirectCast(LineasAlbaranBindingSource.Current, LineasAlbaran)
                lblUnidadVenta.Text = FormatNumber(linea.Cantidad, CInt(IIf(gConfGlobal.UsarDecimalCantidad, 2, 0)))
            End If
        End Sub

        Private Sub LineasAlbaranBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles LineasAlbaranBindingSource.PositionChanged
            If Not IsNothing(LineasAlbaranBindingSource.Current) Then
                Dim linea As LineasAlbaran = DirectCast(LineasAlbaranBindingSource.Current, LineasAlbaran)
                If linea.StockProductoActual.HasValue Then
                    lblStockActual.Text = FormatNumber(linea.StockProductoActual.Value, CInt(IIf(gConfGlobal.UsarDecimalCantidad, 2, 0)))
                Else
                    lblStockActual.Text = String.Empty
                End If
                lblUnidadVenta.Text = FormatNumber(linea.Cantidad, CInt(IIf(gConfGlobal.UsarDecimalCantidad, 2, 0)))
            Else
                lblStockActual.Text = String.Empty
                lblUnidadVenta.Text = String.Empty
            End If
        End Sub

        Private Sub cbbtnCancelar_Click(sender As Object, e As EventArgs) Handles cbbtnCancelar.Click
            Dim albaran As Albaranes = DirectCast(pagevVentas.SelectedPage.Tag, Albaranes)
            Dim listaLineas As New List(Of LineasAlbaran)()
            If albaran.LineasAlbaran.Count > 0 Then
                Dim result As DialogResult = MostrarMensaje(My.Resources.Application.ConfirmacionGuardarAlbaran, Me.Text, RadMessageIcon.Question, MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    GuardarAlbaran(albaran)
                End If
            End If
            albaran.Reset()
            albaran.LineasAlbaran = listaLineas.ConvertToEntitySet()
            RefrescarDatoAlbaran(albaran)
            txtIntroduccion.Focus()
        End Sub
    End Class
End Namespace
