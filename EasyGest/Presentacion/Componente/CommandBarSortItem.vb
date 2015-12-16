Namespace Presentacion.Componente

    Friend Class SortEventArgs
    Inherits System.EventArgs

        Friend Property SortExpression As String

    End Class

End Namespace

Namespace Presentacion.Componente

    Friend Class CommandBarSortItem

        Private _commandbar As CommandBarStripElement
        Private _cbbtnSort As Telerik.WinControls.UI.CommandBarButton
        Private _cbddlCampo As Telerik.WinControls.UI.CommandBarDropDownList
        Private _cbtggSentido As Telerik.WinControls.UI.CommandBarToggleButton
        Private _sentidoorden As String = "ASC"

        Friend Event onSort(ByVal sender As CommandBarSortItem, ByVal e As SortEventArgs)

        Friend Sub New(ByVal commandbar As CommandBarStripElement)
            _cbbtnSort = New Telerik.WinControls.UI.CommandBarButton()
            _cbddlCampo = New Telerik.WinControls.UI.CommandBarDropDownList()
            _cbtggSentido = New Telerik.WinControls.UI.CommandBarToggleButton()
            '
            'cbddlCampo
            '
            Me._cbddlCampo.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me._cbddlCampo.VisibleInOverflowMenu = True
            Me._cbddlCampo.AutoSize = True
            Me._cbddlCampo.AutoSizeItems = True
            Me._cbddlCampo.DisplayName = My.Resources.Application.TextoCampos
            Me._cbddlCampo.DrawBorder = False
            Me._cbddlCampo.DrawText = False
            Me._cbddlCampo.DropDownAnimationEnabled = True
            Me._cbddlCampo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me._cbddlCampo.Margin = New Padding(0, 0, 0, 0)
            Me._cbddlCampo.ForeColor = gCBForeColor
            Me._cbddlCampo.CaptureOnMouseDown = True
            Me._cbddlCampo.DropDownSizingMode = SizingMode.UpDown
            Me._cbddlCampo.Font = gDefaultFont
            Me._cbddlCampo.ListElement.Font = gDefaultFont
            Me._cbddlCampo.DropDownListElement.EditorElement.Font = gDefaultFont

            '
            'CommandBarToggleButton1
            '
            Me._cbtggSentido.AutoSize = True
            Me._cbtggSentido.DrawText = True
            Me._cbtggSentido.TextImageRelation = TextImageRelation.ImageAboveText
            Me._cbtggSentido.ForeColor = gCBForeColor
            Me._cbtggSentido.Image = Global.EasyGest.My.Resources.Resources.up
            Me._cbtggSentido.DisplayName = My.Resources.Application.TextoOrden
            Me._cbtggSentido.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
            Me._cbtggSentido.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me._cbtggSentido.VisibleInOverflowMenu = True
            Me._cbtggSentido.ForeColor = gCBForeColor
            Me._cbtggSentido.Padding = New Padding(3, 0, 3, 0)
            Me._cbtggSentido.Margin = New Padding(0, 0, 0, 0)
            Me._cbtggSentido.ToolTipText = My.Resources.Application.TextoOrdenAsc
            Me._cbtggSentido.Text = My.Resources.Application.TextoOrdenAsc
            AddHandler _cbtggSentido.ToggleStateChanged, AddressOf CommandBarToggleButton_ToggleStateChanged
            '
            '_cbbtnSort
            '
            Me._cbbtnSort.DisplayName = My.Resources.Application.TextoRecargar
            Me._cbbtnSort.Text = My.Resources.Application.TextoRecargar
            Me._cbbtnSort.DrawText = True
            Me._cbbtnSort.ForeColor = gCBForeColor
            Me._cbbtnSort.Image = Global.EasyGest.My.Resources.Resources._48
            Me._cbbtnSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._cbbtnSort.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me._cbbtnSort.VisibleInOverflowMenu = True
            Me._cbbtnSort.Font = gDefaultFont
            Me._cbbtnSort.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.R))
            
            _commandbar = commandbar
        End Sub

        Friend Sub Prepare(defaultitem As String)
            _commandbar.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me._cbddlCampo, Me._cbtggSentido, Me._cbbtnSort})
            If Not String.IsNullOrWhiteSpace(defaultitem) Then
                For Each item As RadListDataItem In _cbddlCampo.Items
                    If item.Value.ToString().Equals(defaultitem, StringComparison.InvariantCultureIgnoreCase) Then
                        item.Selected = True
                        Exit For
                    End If
                Next
            End If
            AddHandler _cbbtnSort.Click, AddressOf _cbbtnFilter_Click
        End Sub

        Friend Sub AddItemToFieldDDL(displayName As String, fieldName As String)
            Dim item As New RadListDataItem(displayName, fieldName)      
            item.Font = gDefaultFont
            item.Selected = _cbddlCampo.Items.Count = 0
            item.ForeColor = gCBForeColor
            _cbddlCampo.Items.Add(item)
        End Sub

        Private Sub _cbbtnFilter_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim arg As New SortEventArgs()
            arg.SortExpression = BuildSortExpression()
            RaiseEvent onSort(Me, arg)
        End Sub

        Private Sub CommandBarToggleButton_ToggleStateChanged(ByVal sender As System.Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs)
            _sentidoorden = CStr(IIf(_cbtggSentido.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On, "ASC", "DESC"))
            If _cbtggSentido.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                _cbtggSentido.Image = My.Resources.up
                _cbtggSentido.ToolTipText = My.Resources.Application.TextoOrdenAsc
                _cbtggSentido.Text = My.Resources.Application.TextoOrdenAsc
            Else
                _cbtggSentido.Image = My.Resources.down
                _cbtggSentido.ToolTipText = My.Resources.Application.TextoOrdenDesc
                _cbtggSentido.Text = My.Resources.Application.TextoOrdenDesc
            End If
        End Sub

        Private Function BuildSortExpression() As String
            If Not IsNothing(_cbddlCampo.SelectedValue) Then
                Return _cbddlCampo.SelectedValue.ToString() & " " & _sentidoorden
            Else
                Return ""
            End If
        End Function

    End Class

End Namespace
