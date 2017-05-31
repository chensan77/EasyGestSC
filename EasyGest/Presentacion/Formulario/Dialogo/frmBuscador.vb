
Imports System.ComponentModel

Namespace Presentacion.Formulario.Dialogo

    Public Class frmBuscador

        Private WithEvents gridDatos As RadGridView
        Private _dataBinding As BindingSource
        Private _objetoEncontrado As LINQEntityBase = Nothing
        Private _expresionBusqueda As String = String.Empty
        Private _objetoABuscar As ObjetoBusqueda
        Private _filtro As String = String.Empty
        Protected Sub New()
            InitializeComponent()

        End Sub

        Protected Friend ReadOnly Property ObjetoEncontrado As LINQEntityBase
            Get
                Return _objetoEncontrado
            End Get
        End Property


        Public Sub New(ByVal objetivo As ObjetoBusqueda, Optional textoBusqueda As String = "")
            Me.New()
            _objetoABuscar = objetivo
            PrepararControles(docwGridCliente.Controls)
            PrepararControles(docwGridProducto.Controls)
            PrepararControles(docwGridProveedor.Controls)
            SettingGridHeaderText(gridProducto, My.Resources.Application.GridHeaderTextBuscarProducto.Split(CARACTERSEPARADOR))
            SettingGridHeaderText(gridCliente, My.Resources.Application.GridHeaderTextBuscarCliente.Split(CARACTERSEPARADOR))
            SettingGridHeaderText(gridProveedor, My.Resources.Application.GridHeaderTextBuscarProveedor.Split(CARACTERSEPARADOR))
            btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))

            If Not IsNothing(textoBusqueda) Then txtValor.Text = textoBusqueda.Trim()

        End Sub

        Private Sub gridDatos_SelectionChanged(sender As Object, e As EventArgs) Handles gridDatos.SelectionChanged
            If gridDatos.SelectedRows.Count = 0 Then
                _objetoEncontrado = Nothing
            Else
                _objetoEncontrado = DirectCast(gridDatos.SelectedRows.First.DataBoundItem, LINQEntityBase)
            End If
        End Sub

        Private Sub txtValor_KeyUp(sender As Object, e As KeyEventArgs) Handles txtValor.KeyUp
            If e.KeyCode = Keys.Enter And Not String.IsNullOrWhiteSpace(txtValor.Text) Then
                Dim expresion As String = String.Empty
                Dim operador As String = String.Empty
                Dim palabras As String() = txtValor.Text.Trim().Split(CChar(" "))
                For Each palabra As String In palabras
                    expresion &= operador & String.Format(_expresionBusqueda, palabra)
                    operador = " AND "
                Next
                CargarDatos("(Activo == True) AND" & expresion)

            End If
        End Sub

        Private Sub CargarDatos(filtro As String, Optional ejecucionDirecta As Boolean = False)
            If bgwCargar.IsBusy Then Return
            _filtro = filtro
            bgwCargar.RunWorkerAsync(ejecucionDirecta)
        End Sub

        Private Sub bwgCargar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwCargar.DoWork
            System.Threading.Thread.CurrentThread.CurrentCulture = GetApplicationCulture(Me)
            Dim ejecucionDirecta As Boolean = CBool(e.Argument)
            Select Case _objetoABuscar
                Case ObjetoBusqueda.Producto
                    Using control As New VistasController(Of VWProductos)()
                        If ejecucionDirecta Then
                            e.Result = control.ExecuteQuery(_filtro)
                        Else
                            e.Result = control.GetItems(_filtro)
                        End If
                    End Using
                Case ObjetoBusqueda.Cliente
                    Using control As New VistasController(Of VWClientes)()
                        If ejecucionDirecta Then
                            e.Result = control.ExecuteQuery(_filtro)
                        Else
                            e.Result = control.GetItems(_filtro)
                        End If
                    End Using
                Case ObjetoBusqueda.Proveedor
                    Using control As New VistasController(Of VWProveedores)()
                        If ejecucionDirecta Then
                            e.Result = control.ExecuteQuery(_filtro)
                        Else
                            e.Result = control.GetItems(_filtro)
                        End If
                    End Using
            End Select
        End Sub

        Private Sub bgwCargar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwCargar.RunWorkerCompleted
            If Not IsNothing(e.Error) Then
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
            Else
                Try
                    _dataBinding.DataSource = e.Result
                    If _dataBinding.Count > 0 Then gridDatos.Focus()
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
        End Sub

        Private Sub gridDatos_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles gridDatos.CellDoubleClick
            If Not IsNothing(e.Row.DataBoundItem) Then
                _objetoEncontrado = TryCast(e.Row.DataBoundItem, LINQEntityBase)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
            _objetoEncontrado = Nothing
        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
            AceptarForm()
        End Sub

        Private Sub frmBuscador_Load(sender As Object, e As EventArgs) Handles Me.Load
            toolBusquedaAvanzada.AutoHide()
            ToolWindow3.Show()
            Select Case _objetoABuscar
                Case ObjetoBusqueda.Producto
                    docwGridProveedor.Close()
                    docwGridCliente.Close()
                    Me.Text = String.Format(Me.Text, My.Resources.Application.TextoProducto)
                    gridDatos = gridProducto
                    _dataBinding = VWProductosBindingSource
                    _expresionBusqueda = "(Referencia.Contains(""{0}"") OR Descripcion.Contains(""{0}""))"
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Referencia", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Descripcion", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Familia", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Ubicacion", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Marca", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("UltimoProveedor", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("PrecioVenta", GetType(Double)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("FCreacion", GetType(Date)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("OfertaVigente", GetType(Boolean)))
                    'datafilterBusquadaAvanzada.DataFilterElement.
                Case ObjetoBusqueda.Cliente
                    docwGridProducto.Close()
                    docwGridProveedor.Close()
                    Me.Text = String.Format(Me.Text, My.Resources.Application.TextoCliente)
                    gridDatos = gridCliente
                    _dataBinding = VWClientesBindingSource
                    _expresionBusqueda = "(Nombre.Contains(""{0}"") OR NombreCN.Contains(""{0}"") OR Identificacion.Contains(""{0}""))"
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Nombre", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Identificacion", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Direccion", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Localidad", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Provincia", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("CodigoPostal", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("FCreacion", GetType(Date)))
                Case ObjetoBusqueda.Proveedor
                    docwGridProducto.Close()
                    docwGridCliente.Close()
                    Me.Text = String.Format(Me.Text, My.Resources.Application.TextoProveedor)
                    gridDatos = gridProveedor
                    _dataBinding = VWProveedoresBindingSource
                    _expresionBusqueda = "(Nombre.Contains(""{0}"") OR NombreCN.Contains(""{0}"") OR Identificacion.Contains(""{0}""))"
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Nombre", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Identificacion", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Direccion", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Localidad", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("Provincia", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("CodigoPostal", GetType(String)))
                    datafilterBusquadaAvanzada.Descriptors.Add(New DataFilterDescriptorItem("FCreacion", GetType(Date)))
            End Select
            txtValor.Focus()
        End Sub

        Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click

            If Not String.IsNullOrEmpty(datafilterBusquadaAvanzada.Expression) Then _
                CargarDatos("(" & datafilterBusquadaAvanzada.Expression & ") AND Activo = 1", True)

        End Sub

        Protected Overrides Sub OnKeyUp(e As KeyEventArgs)
            If e.KeyCode = Keys.Enter Then
                If Not txtValor.Focus Then
                    AceptarForm()
                End If
            End If
            MyBase.OnKeyUp(e)
        End Sub

        Private Sub AceptarForm()
            If gridDatos.SelectedRows.Count > 0 Then
                _objetoEncontrado = TryCast(gridDatos.SelectedRows.First.DataBoundItem, LINQEntityBase)
            End If
            Me.DialogResult = DialogResult.OK
        End Sub

        Private Sub gridDatos_KeyUp(sender As Object, e As KeyEventArgs) Handles gridDatos.KeyUp
            If e.KeyCode = Keys.Enter Then
                AceptarForm()
            End If
        End Sub

        Public Enum ObjetoBusqueda
            Producto
            Cliente
            Proveedor
        End Enum


    End Class
End Namespace
