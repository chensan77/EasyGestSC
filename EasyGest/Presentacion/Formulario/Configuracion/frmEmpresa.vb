Imports EasyGestControllers
Imports EasyGestControllers.Data
Imports EasyGest.Presentacion.Componente


Namespace Presentacion.Formulario.Configuracion

    Public Class frmEmpresa

        Private WithEvents cbOrden As Presentacion.Componente.CommandBarSortItem
        Private _panel As New WaitingPanel()
        Private _orden As String = "Empresa ASC"
        Private _empresa As Entity.Empresas = Nothing

#Region "Evento Form"

        Private Sub frmEmpresa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.Controls.Add(_panel)
            _panel.BringToFront()
            PrepararControles(SplitPanel1.Controls)
            PrepararControles(SplitPanel2.Controls)
            ConfigurarBarraOrden()
            ConfigurarCommandBar(Me.cbstripeAccion)
            ConfigurarCommandBar(Me.cbstripeOrden)
            SplitPanel2.Collapsed = True
            btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))

            Try
                ' cargar los comboboxs
                Using control As New Controller.ProvinciasEspañolasController
                    ProvinciasEspañolasBindingSource.DataSource = control.GetItems("", "Provincia ASC")
                End Using
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub frmEmpresa_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            CargarDatos("")
        End Sub

        Private Sub frmEmpresa_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
            If e.KeyChar = Convert.ToChar(27) And ControlBox = True Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If
        End Sub

        #End Region

#Region "Evento Grid"

        Private Sub gridDatos_RowFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RowFormattingEventArgs) Handles gridDatos.RowFormatting
            If Not TypeOf e.RowElement Is GridFilterRowElement And Not TypeOf e.RowElement Is GridTableHeaderRowElement Then
                Dim emp As Empresas = DirectCast(e.RowElement.Data.DataBoundItem, Empresas)
                If emp.Activo Then
                    e.RowElement.ForeColor = Color.Green
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
            Dim item As Empresas = gridDatos.SelectedItem(Of Empresas)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                EditarAgregar(item.idEmpresa)
            End If
        End Sub

        Private Sub cbbtnFijarActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbtnFijarActivo.Click
            Dim item As Empresas = gridDatos.SelectedItem(Of Empresas)()
            If IsNothing(item) Then
                MostrarMensaje(My.Resources.Application.AvisoSeleccionFila, Me.Text, Telerik.WinControls.RadMessageIcon.Info)
            Else
                If Not item.Activo Then
                    FijarActivo(item.idEmpresa)
                End If

            End If
        End Sub

        #End Region

        #Region "Eventos"

        Private Sub btnExaminarImagen_Click(sender As Object, e As System.EventArgs) Handles btnExaminarImagen.Click
            If dlgImagen.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    Dim imagen As System.Drawing.Image = System.Drawing.Image.FromStream(dlgImagen.OpenFile())
                    picLogo.Image = DirectCast(imagen.Clone(), Image)
                    _empresa.LogoImagen = picLogo.Image
                    imagen.Dispose()
                    imagen = Nothing
                Catch ex As Exception

                End Try
            End If
        End Sub

        Private Sub btnQuitarImagen_Click(sender As Object, e As System.EventArgs) Handles btnQuitarImagen.Click
            picLogo.Image = Nothing
            _empresa.LogoImagen = Nothing
        End Sub

        Private Sub timValidar_Tick(sender As System.Object, e As System.EventArgs) Handles timValidar.Tick
            btnAceptar.Enabled = _empresa.IsValid()
        End Sub

        Private Sub ddlFormato_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
            If Not ddlFormato.SelectedValue.Equals("n/a") And String.IsNullOrWhiteSpace(txtSerie.Text) Then
                txtSerie.Text = "A"
            End If
        End Sub

        Private Sub ddlProvincia_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles ddlProvincia.SelectedIndexChanged
            If ddlProvincia.SelectedValue IsNot Nothing Then
                Using control As New MunicipiosEspañolasController()
                    MunicipiosEspañolasBindingSource.DataSource = control.GetItemsByCodProvincia(CStr(ddlProvincia.SelectedValue))
                End Using
            End If
        End Sub

        #End Region

        #Region "Operaciones ARD"

        Private Sub CargarDatos(ByVal filtro As String)
            If bgwCarga.IsBusy() Then Return
            _panel.Mostrar()
            bgwCarga.RunWorkerAsync()
        End Sub

        Private Sub FijarActivo(ByVal idEmpresa As Long)
            Try
                Using c As New EmpresasController()
                    c.SetActivo(idEmpresa)
                End Using
                For Each row As GridViewRowInfo In gridDatos.Rows
                    Dim emp As Empresas = DirectCast(row.DataBoundItem, Empresas)
                    emp.Activo = emp.idEmpresa = idEmpresa
                    row.InvalidateRow()
                    If emp.idEmpresa.Equals(idEmpresa) Then emp.Clone(gEmpresa)
                Next
                ControlBox = True
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub EditarAgregar(ByVal id As Long)
            If id = -1 Then
                _empresa = Controller.EmpresasController.NewItem()
            Else
                Using c As New Controller.EmpresasController()
                    _empresa = c.GetItem(id)
                End Using
            End If
            EmpresaBindingSource.DataSource = _empresa
            timValidar.Enabled = True
            SplitPanel2.Collapsed = False
            SplitPanel1.Collapsed = True
            btnAceptar.Enabled = False
            cbstripeAccion.Enabled = False
            cbstripeOrden.Enabled = False            
            txtNumeroIdentificacion.Focus()
        End Sub

        Private Sub btnCancelar_Click(sender As Object, e As System.EventArgs) Handles btnCancelar.Click
            _empresa = Nothing
            SplitPanel2.Collapsed = True
            SplitPanel1.Collapsed = False
            timValidar.Enabled = False
            cbstripeAccion.Enabled = True
            cbstripeOrden.Enabled = True
        End Sub

        Private Sub btnAceptar_Click(sender As Object, e As System.EventArgs) Handles btnAceptar.Click
            Try
                Using control As New EmpresasController()
                    If _empresa.LINQEntityState = EntityState.New Then
                        Me.EmpresasBindingSource.Add(_empresa)
                    End If
                    control.SyncronisingItem(_empresa)
                End Using

                'Dim row As GridViewRowInfo
                UpdateSelectGridRow(gridDatos, _empresa)
                'If Not IsNothing(row) Then
                '    If _action = System.Data.Linq.ChangeAction.Update Then _empresa.Clone(row.DataBoundItem)
                '    gridDatos.TableElement.ScrollToRow(row)
                '    gridDatos.CurrentRow = row
                '    row.IsSelected = True
                '    row.InvalidateRow()
                'End If
                SplitPanel2.Collapsed = True
                SplitPanel1.Collapsed = False
                timValidar.Enabled = False
                cbstripeAccion.Enabled = True
                cbstripeOrden.Enabled = True
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub bgwCarga_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwCarga.DoWork
            System.Threading.Thread.CurrentThread.CurrentCulture = GetApplicationCulture(Me)
            Using c As New Controller.EmpresasController()
                Dim datos As IEnumerable(Of Empresas)
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
                    EmpresasBindingSource.DataSource = e.Result
                Catch ex As Exception
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, e.Error, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If

        End Sub

        #End Region

        Public Sub New(cerrable As Boolean)

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            ddlFormato.Items(0).Value = "n-a"
            ddlFormato.Items(1).Value = "n-s"
            ddlFormato.Items(2).Value = "n-a-s"
            AddHandler ddlFormato.SelectedIndexChanged, AddressOf ddlFormato_SelectedIndexChanged
            ControlBox = cerrable
        End Sub

        #Region "Ordenación"

        Private Sub cbOrden_onSort(ByVal sender As CommandBarSortItem, ByVal e As SortEventArgs) Handles cbOrden.onSort
            gridDatos.FilterDescriptors.Clear()
            gridDatos.SortDescriptors.Clear()
            _orden = e.SortExpression
            CargarDatos("")
        End Sub

        Private Sub ConfigurarBarraOrden()
            cbOrden = New Presentacion.Componente.CommandBarSortItem(cbstripeOrden)
            cbOrden.AddItemToFieldDDL(gridDatos.Columns("Empresa").HeaderText, "Empresa")
            cbOrden.Prepare("")
        End Sub

        #End Region



    End Class

End Namespace
