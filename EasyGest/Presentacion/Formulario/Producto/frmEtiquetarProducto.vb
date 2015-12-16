Imports EasyGestControllers
Imports EasyGestControllers.Data
Imports EasyGest.Presentacion.Componente


Namespace Presentacion.Formulario.Producto

    Public Class frmEtiquetarProducto

        Private WithEvents cbBusqueda As Presentacion.Componente.CommandBarFilterItem
        'Private WithEvents bkwCarga As New Wi
        Private _panel As New WaitingPanel()
        Private _filtro As String = ""
        Private _orden As String = "Descripcion ASC"

#Region "Evento Form"

        Private Sub frmEtiquetarProducto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Controls.Add(_panel)
            _panel.BringToFront()
            _panel.Ocultar()
            PrepararControles(Me.Controls)
            ConfigurarBarraBusqueda()
            ConfigurarCommandBar(cbstripeAccion)
            ConfigurarCommandBar(Me.cbstripeBusqueda)
        End Sub

        Private Sub frmEtiquetarProducto_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            Try
                Using control As New EtiquetasController
                    EtiquetasBindingSource.DataSource = control.GetItems("", "Usos DESC")
                End Using
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try

        End Sub

#End Region

#Region "Evento Grid"

#End Region

#Region "Evento botones acciones"

        Private Sub cbbtnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnAgregar.Click
        End Sub

        Private Sub cbbtnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnModificar.Click

        End Sub

        Private Sub cbbtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbtnEliminar.Click

        End Sub

#End Region

#Region "Operaciones AED"

        Private Sub CargarDatos(ByVal filtro As String)
            If bgwCarga.IsBusy() Then Return
            _filtro = filtro
            _panel.Mostrar()
            bgwCarga.RunWorkerAsync()
        End Sub

        Private Sub bgwCarga_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarga.DoWork
            System.Threading.Thread.CurrentThread.CurrentCulture = GetApplicationCulture(Me)
            Using c As New Controller.VistasController(Of Entity.VWProductos)()
                Dim datos As IEnumerable(Of VWProductos)
                datos = c.GetItems(_filtro, _orden)
                e.Result = datos
            End Using
        End Sub

        Private Sub bgwCarga_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwCarga.RunWorkerCompleted
            _panel.Ocultar()
            If Not IsNothing(e.Error) Then
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
            Else
                Try
                    VWProductosBindingSource.DataSource = e.Result
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try

            End If
        End Sub


#End Region

#Region "Busqueda"

        Private Sub ConfigurarBarraBusqueda()
            cbBusqueda = New Presentacion.Componente.CommandBarFilterItem(cbstripeBusqueda)
            cbBusqueda.AddItemToFieldDDL(gridDatos.Columns("Referencia").HeaderText, "Referencia", "String")
            cbBusqueda.AddItemToFieldDDL(gridDatos.Columns("Descripcion").HeaderText, "Descripcion", "String")
            cbBusqueda.AddItemToFieldDDL(gridDatos.Columns("Marca").HeaderText, "Marca", "String")
            cbBusqueda.AddItemToFieldDDL(gridDatos.Columns("Familia").HeaderText, "Familia", "String")
            cbBusqueda.AddItemToFieldDDL(My.Resources.Application.TextoFechaCreacion, "FCreacion", "Date")
            cbBusqueda.AddItemToFieldDDL(My.Resources.Application.TextoFechaModificacion, "FModificacion", "Date")
            cbBusqueda.Prepare("")
        End Sub

        Private Sub cbBusqueda_onFilter(ByVal sender As Presentacion.Componente.CommandBarFilterItem, ByVal e As Presentacion.Componente.FilterEventArgs) Handles cbBusqueda.onFilter
            If Not String.IsNullOrWhiteSpace(e.FilterExpression) And Not bgwCarga.IsBusy() Then
                gridDatos.FilterDescriptors.Clear()
                CargarDatos(e.FilterExpression & " AND Activo = TRUE")
            End If
        End Sub

#End Region

        Public Sub New()

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        End Sub

        Public Sub New(ByVal productos As List(Of VWProductos))

            Me.New()

            If Not IsNothing(productos) Then
                VWProductosBindingSource.DataSource = productos
                gridDatos.Select()
            End If
        End Sub

        Private Sub lstvEtiquetas_CellFormatting(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.ListViewCellFormattingEventArgs) Handles lstvEtiquetas.CellFormatting
            e.CellElement.Font = gDefaultFont
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
            e.CellElement.BackColor = Color.Red
        End Sub
    End Class

End Namespace
