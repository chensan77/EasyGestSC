
Namespace Presentacion.Formulario.Configuracion

    Public Class frmAuxiliarProducto

        Private _marcasdeleted As List(Of Marcas) = New List(Of Marcas)()
        Private _unidadesdeleted As List(Of UnidadesMedida) = New List(Of UnidadesMedida)()
        Private _ubicacionesdeleted As List(Of Ubicaciones) = New List(Of Ubicaciones)()
        Private _familiasdeleted As List(Of Familias) = New List(Of Familias)()
        'Private _tickreferencia As Long = New Date(2010, 1, 1).Ticks

#Region "Eventos Form"
        Private Sub frmAuxiliarProducto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            If Me.DialogResult = DialogResult.OK Then
                Try
                    'tratar marcas
                    Using control As New MarcasController
                        control.SyncronisingItem(_marcasdeleted.AsEnumerable())
                        control.SyncronisingItem(DirectCast(MarcasBindingSource.List, IEnumerable(Of Marcas)))
                    End Using
                    'tratar medidas
                    Using control As New UnidadesMedidaController
                        'Dim nuevos As New List(Of UnidadesMedida)()
                        'control.DeleteItems(_unidadesdeleted)
                        'For Each medida As UnidadesMedida In UnidadesMedidaBindingSource.List
                        '    If medida.idUnidadMedida = 0 Then
                        '        nuevos.Add(medida)
                        '    Else
                        '        control.UpdateItem(medida)
                        '    End If
                        'Next
                        'control.AddItems(nuevos)
                        control.SyncronisingItem(_unidadesdeleted.AsEnumerable())
                        control.SyncronisingItem(DirectCast(UnidadesMedidaBindingSource.List, IEnumerable(Of UnidadesMedida)))
                    End Using
                    'tratar marcas
                    Using control As New UbicacionesController
                        control.SyncronisingItem(_ubicacionesdeleted.AsEnumerable())
                        control.SyncronisingItem(DirectCast(UbicacionesBindingSource.List, IEnumerable(Of Ubicaciones)))
                    End Using
                    'tratar familias
                    Using control As New FamiliasController()
                        ActualizarFamilia(control, treeFamilia.Nodes)
                        control.SyncronisingItem(_familiasdeleted.AsEnumerable())
                    End Using
                    gridMarcas.ContextMenuStrip = GetContextMenu()
                    gridUbicaciones.ContextMenuStrip = GetContextMenu()
                    gridMedidas.ContextMenuStrip = GetContextMenu()
                    btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
                Catch ex As Exception
                    MostrarMensaje(ex, Me.Text, Telerik.WinControls.RadMessageIcon.Error, MessageBoxButtons.OK)
                    e.Cancel = True
                End Try
            End If
        End Sub



        Private Sub frmAuxiliarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            pvDatosAuxiliaresProducto.SelectedPage = pvpMarcas

            Try
                CargarMarcas()
                CargarUnidadesMedida()
                CargarUbicaciones()
                CargarFamilias()
                btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub
#End Region

#Region "Tratamiento Dato"
        Private Sub ActualizarFamilia(ByVal control As FamiliasController, ByVal nodos As RadTreeNodeCollection)
            Dim familia As Familias
            For Each nodo As RadTreeNode In nodos
                familia = DirectCast(nodo.Tag, Familias)
                If nodo.Parent IsNot Nothing Then
                    familia.idFamiliaPadre = DirectCast(nodo.Parent.Tag, Familias).idFamilia
                Else
                    familia.idFamiliaPadre = Nothing
                End If
                'If familia.idFamilia > 0 Then
                '    familia = control.UpdateItem(familia)
                'Else
                '    familia = control.AddItem(familia)
                'End If
                control.SyncronisingItem(familia)
                nodo.Tag = familia
                ActualizarFamilia(control, nodo.Nodes)
            Next
        End Sub

        Private Sub CargarMarcas()
            Using control As New MarcasController
                MarcasBindingSource.DataSource = control.GetItems()
            End Using
        End Sub

        Private Sub CargarUnidadesMedida()
            Using control As New UnidadesMedidaController
                UnidadesMedidaBindingSource.DataSource = control.GetItems()
            End Using
        End Sub

        Private Sub CargarUbicaciones()
            Using control As New UbicacionesController
                UbicacionesBindingSource.DataSource = control.GetItems()
            End Using
        End Sub

        Private Sub CargarFamilias()
            Dim familiasbase As List(Of Familias)
            treeFamilia.Nodes.Clear()
            Using control As New FamiliasController
                familiasbase = control.GetItems("idFamiliaPadre == NULL", "Familia").ToList()
            End Using
            For Each familia As Familias In familiasbase
                Dim nodo As RadTreeNode = NuevoNodo(familia, CargarSubfamilias(familia.idFamilia))
                treeFamilia.Nodes.Add(nodo)
            Next
            treeFamilia.ExpandAll()
        End Sub

        Private Function CargarSubfamilias(ByVal idPadre As Long) As RadTreeNode()
            Dim listaNodo As New List(Of RadTreeNode)
            Dim subfamilias As List(Of Familias)
            Using control As New FamiliasController
                subfamilias = DirectCast(control.GetItems("idFamiliaPadre == " & idPadre, "Familia"), Global.System.Collections.Generic.List(Of Global.EasyGestControllers.Data.Entity.Familias))
            End Using
            For Each familia As Familias In subfamilias
                Dim nodo As RadTreeNode = NuevoNodo(familia, CargarSubfamilias(familia.idFamilia))
                listaNodo.Add(nodo)
            Next
            Return listaNodo.ToArray()
        End Function

#End Region

#Region "Eventos Grilla"


        Private Sub grid_RowsChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCollectionChangedEventArgs) Handles gridUbicaciones.RowsChanged, gridMedidas.RowsChanged, gridMarcas.RowsChanged
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Add Then
                For Each row As GridViewRowInfo In e.NewItems
                    Dim item As LINQEntityBase = DirectCast(row.DataBoundItem, LINQEntityBase)
                    item.SetAsInsertOnSubmit()
                Next
            End If
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
                For Each row As GridViewRowInfo In e.NewItems
                    Dim item As LINQEntityBase = DirectCast(row.DataBoundItem, LINQEntityBase)
                    If Not IsNothing(item) Then
                        If item.LINQEntityState <> EntityState.New Then
                            item.SetAsDeleteOnSubmit()
                            If TypeOf item Is Ubicaciones Then
                                _ubicacionesdeleted.Add(DirectCast(item, Ubicaciones))
                            ElseIf TypeOf item Is UnidadesMedida Then
                                _unidadesdeleted.Add(DirectCast(item, UnidadesMedida))
                            ElseIf TypeOf item Is Marcas Then
                                _marcasdeleted.Add(DirectCast(item, Marcas))
                            End If
                        End If
                    End If
                Next
            End If
        End Sub

        Private Sub grid_RowsChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCollectionChangingEventArgs) Handles gridMarcas.RowsChanging, gridMedidas.RowsChanging, gridUbicaciones.RowsChanging
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
                Dim titulo As String = String.Empty
                If Object.ReferenceEquals(sender, gridMarcas) Then
                    titulo = pvpMarcas.Text
                ElseIf Object.ReferenceEquals(sender, gridUbicaciones) Then
                    titulo = pvpUbicaciones.Text
                ElseIf Object.ReferenceEquals(sender, gridMedidas) Then
                    titulo = pvpUnidadesMedida.Text
                End If
                e.Cancel = Not MostrarMensaje(My.Resources.Application.ConfirmacionBorrarDato, titulo, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes
            End If
        End Sub

        Private Sub grid_CellValidating(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.CellValidatingEventArgs) Handles gridMarcas.CellValidating, gridMedidas.CellValidating, gridUbicaciones.CellValidating
            If IsNothing(e.Row) Or IsNothing(e.Column) Then Return
            If Not e.Column.Name.Equals("Descripcion") AndAlso String.IsNullOrWhiteSpace(CStr(e.Value)) Then
                e.Cancel = True
                e.Row.ErrorText = My.Resources.Application.TextoValorRequerido
            Else
                e.Row.ErrorText = String.Empty
            End If
        End Sub

#End Region

#Region "Eventos Boton"

        Private Sub mitemRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                Dim menu As ContextMenuStrip = DirectCast(DirectCast(sender, ToolStripItem).Owner, Windows.Forms.ContextMenuStrip)
                If Object.ReferenceEquals(menu.SourceControl, gridMarcas) Then
                    If gridMarcas.IsInEditMode Then gridMarcas.CancelEdit()
                    CargarMarcas()
                End If
                If Object.ReferenceEquals(menu.SourceControl, gridUbicaciones) Then
                    If gridUbicaciones.IsInEditMode Then gridUbicaciones.CancelEdit()
                    CargarUbicaciones()
                End If
                If Object.ReferenceEquals(menu.SourceControl, gridMedidas) Then
                    If gridMedidas.IsInEditMode Then gridMedidas.CancelEdit()
                    CargarUnidadesMedida()
                End If
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub

        Private Sub mitemRefrescar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitemRefrescar.Click
            Try
                CargarFamilias()
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
        End Sub
        'Private Sub btnRefrescar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefrescar.Click
        '    Try
        '        If pvDatosAuxiliaresProducto.SelectedPage Is pvpMarcas Then
        '            CargarMarcas()
        '        ElseIf pvDatosAuxiliaresProducto.SelectedPage Is pvpUnidadesMedida Then
        '            CargarUnidadesMedida()
        '        ElseIf pvDatosAuxiliaresProducto.SelectedPage Is pvpUbicaciones Then
        '            CargarUbicaciones()
        '        Else
        '            CargarFamilias()
        '        End If
        '    Catch ex As Exception
        '        MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
        '    End Try
        'End Sub

        Private Sub mitemAgregarFamiliaBase_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mitemAgregarFamiliaBase.Click
            Dim nodo As RadTreeNode
            Dim familia As Familias = AddFamilia(Nothing)
            'treeFamilia.Refresh()
            nodo = NuevoNodo(familia, New RadTreeNode() {})
            If Not IsNothing(nodo) Then
                treeFamilia.Nodes.Add(nodo)
                treeFamilia.SelectedNode = nodo
                nodo.BeginEdit()
            End If
        End Sub

        Private Sub mitemEditar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mitemEditar.Click
            treeFamilia.SelectedNode.BeginEdit()
        End Sub

        Private Sub mitemEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mitemEliminar.Click
            Dim familia As Familias
            familia = DirectCast(treeFamilia.SelectedNode.Tag, Familias)
            If Not IsNothing(familia) AndAlso familia.idFamilia > 0 Then
                _familiasdeleted.Add(familia)
            End If
            treeFamilia.SelectedNode.Remove()
        End Sub

        Private Sub mitemAgregarSubfamilia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mitemAgregarSubfamilia.Click
            Dim nodo As RadTreeNode
            Dim familia As Familias = DirectCast(treeFamilia.SelectedNode.Tag, Familias)
            familia = AddFamilia(familia.idFamilia)
            'treeFamilia.Refresh()
            nodo = NuevoNodo(familia, New RadTreeNode() {})
            If Not IsNothing(nodo) Then
                treeFamilia.SelectedNode.Nodes.Add(nodo)
                treeFamilia.SelectedNode.Expand()
                treeFamilia.SelectedNode = nodo
                nodo.BeginEdit()
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

#Region "Eventos Arbol"

        Private Sub treeFamilia_ContextMenuOpening(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.TreeViewContextMenuOpeningEventArgs) Handles treeFamilia.ContextMenuOpening
            mitemAgregarSubfamilia.Enabled = Not IsNothing(e.Node)
            mitemEditar.Enabled = Not IsNothing(e.Node)
            mitemEliminar.Enabled = Not IsNothing(e.Node) AndAlso e.Node.Nodes.Count = 0
        End Sub

        Private Sub treeFamilia_NodeFormatting(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.TreeNodeFormattingEventArgs) Handles treeFamilia.NodeFormatting
            If imglFamilia.Images.Count > 0 Then e.Node.ImageIndex = e.Node.Level Mod imglFamilia.Images.Count
        End Sub

        Private Sub treeFamilia_DragEnded(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RadTreeViewDragEventArgs) Handles treeFamilia.DragEnded
            Dim familia As Familias
            familia = DirectCast(e.Node.Tag, Familias)
            If e.Node.Parent Is Nothing Then
                familia.idFamiliaPadre = Nothing
            Else
                familia.idFamiliaPadre = DirectCast(e.Node.Parent.Tag, Familias).idFamilia
            End If
        End Sub

        Private Sub treeFamilia_Edited(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.TreeNodeEditedEventArgs) Handles treeFamilia.Edited
            Dim familia As Familias
            If Not e.Canceled Then
                familia = DirectCast(e.Node.Tag, Familias)
                familia.Familia = CStr(e.Node.Value)
            End If
        End Sub
#End Region

        Private Function AddFamilia(ByVal idPadre As Long?) As Familias
            Dim familia As Familias = FamiliasController.NewItem()
            familia.Familia = "Nodo Nuevo"
            familia.idFamiliaPadre = idPadre
            FamiliasBindingSource.Add(familia)
            Return familia
        End Function

        Private Function NuevoNodo(ByVal familia As Familias, ByVal subnodos As RadTreeNode()) As RadTreeNode
            If IsNothing(familia) Then Throw New ArgumentNullException()
            Dim nodo As New RadTreeNode(familia.Familia, subnodos)
            nodo.Tag = familia
            Return nodo
        End Function

        Private Function GetContextMenu() As ContextMenuStrip
            Dim menu As New ContextMenuStrip()
            Dim mitem As ToolStripItem = menu.Items.Add(My.Resources.Application.TextoRecargar, My.Resources.arrow_refresh)
            AddHandler mitem.Click, AddressOf mitemRefrescar_Click
            Return (menu)
        End Function

    End Class

End Namespace
