
Namespace Presentacion.Componente

    Friend Class FilterEventArgs
    Inherits System.EventArgs

        Friend Property FilterExpression As String

    End Class

End Namespace
Namespace Presentacion.Componente

    Friend Class CommandBarFilterItem

        Private _commandbar As CommandBarStripElement
        Private _texteditor As Telerik.WinControls.UI.RadTextBoxElement
        Private _numbereditor As Telerik.WinControls.UI.RadSpinElement
        Private _dateeditor As Telerik.WinControls.UI.RadDateTimePickerElement
        Private _cbbtnFilter As Telerik.WinControls.UI.CommandBarButton
        Private _cbddlCampo As Telerik.WinControls.UI.CommandBarDropDownList
        Private _cbddlFiltro As Telerik.WinControls.UI.CommandBarDropDownList
        Private _cbhostValor As Telerik.WinControls.UI.CommandBarHostItem
        Private _itemContiene As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Private _itemNoContiene As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Private _itemEmpiezaPor As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Private _itemTerminaEn As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Private _itemIgual As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Private _itemDistinto As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Private _itemMayor As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Private _itemMayorIgual As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Private _itemMenor As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Private _itemMenorIgual As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Private _itemEsNulo As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Private _itemNoNulo As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()

        Friend Event onFilter(ByVal sender As CommandBarFilterItem, e As FilterEventArgs)

        Friend Sub New(commandbar As CommandBarStripElement)
            _texteditor = New Telerik.WinControls.UI.RadTextBoxElement()
            _numbereditor = New Telerik.WinControls.UI.RadSpinElement()
            _dateeditor = New Telerik.WinControls.UI.RadDateTimePickerElement()
            _cbbtnFilter = New Telerik.WinControls.UI.CommandBarButton()
            _cbddlCampo = New Telerik.WinControls.UI.CommandBarDropDownList()
            _cbddlFiltro = New Telerik.WinControls.UI.CommandBarDropDownList()
            _cbhostValor = New Telerik.WinControls.UI.CommandBarHostItem()
            '
            'texteditor
            '
            _texteditor.Font = gDefaultFont
            _texteditor.ShowBorder = True
            _texteditor.Border.ForeColor = gCBForeColor
            _texteditor.AutoSize = False
            '_texteditor.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
            _texteditor.Size = New Size(125, 45)
            _texteditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            _texteditor.ForeColor = gCBForeColor
            _texteditor.AutoSizeMode = RadAutoSizeMode.FitToAvailableSize
            '
            'numbereditor
            '
            _numbereditor.ShowBorder = True
            _numbereditor.Font = gDefaultFont
            _numbereditor.AutoSize = False
            _numbereditor.DecimalPlaces = 2
            _numbereditor.MinValue = Decimal.MinValue
            _numbereditor.MaxValue = Decimal.MaxValue
            _numbereditor.ThousandsSeparator = True
            _numbereditor.Size = New Size(125, 45)
            _numbereditor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            _numbereditor.ForeColor = gCBForeColor
            _numbereditor.ShowBorder = True
            '_numbereditor.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
            '
            'dateeditor
            '
            _dateeditor.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            _dateeditor.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
            _dateeditor.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
            _dateeditor.NullDate = New Date(0L)
            '_dateeditor.ShowUpDown = True
            _dateeditor.Value = Nothing
            _dateeditor.Font = gDefaultFont
            _dateeditor.AutoSize = False
            _dateeditor.AutoSizeMode = RadAutoSizeMode.FitToAvailableSize
            _dateeditor.Size = New Size(125, 45)
            _dateeditor.ForeColor = gCBForeColor
            '_dateeditor.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
            _dateeditor.TextBoxElement.TextAlign = HorizontalAlignment.Center
            _dateeditor.TextBoxElement.ShowBorder = True
            _dateeditor.TextBoxElement.Border.ForeColor = gCBForeColor
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
            Me._cbddlCampo.Padding = New Padding(0, 0, 0, 0)
            Me._cbddlCampo.ForeColor = gCBForeColor
            Me._cbddlCampo.CaptureOnMouseDown = True
            Me._cbddlCampo.DropDownSizingMode = SizingMode.UpDown
            Me._cbddlCampo.Font = gDefaultFont
            Me._cbddlCampo.ListElement.Font = gDefaultFont
            Me._cbddlCampo.DropDownListElement.EditorElement.Font = gDefaultFont
            '
            'cbddlFiltro
            '
            Me._cbddlFiltro.AutoSize = True
            Me._cbddlFiltro.AutoSizeItems = True
            Me._cbddlFiltro.DisplayName = My.Resources.Application.TextoOperadores
            Me._cbddlFiltro.DrawBorder = False
            Me._cbddlFiltro.DrawText = False
            Me._cbddlFiltro.DropDownAnimationEnabled = True
            Me._cbddlFiltro.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            Me._cbddlFiltro.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me._cbddlFiltro.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me._cbddlFiltro.VisibleInOverflowMenu = True
            Me._cbddlFiltro.Padding = New Padding(0, 0, 0, 0)
            Me._cbddlFiltro.ForeColor = gCBForeColor
            Me._cbddlFiltro.CaptureOnMouseDown = True
            Me._cbddlFiltro.DropDownSizingMode = SizingMode.UpDownAndRightBottom

            Me._cbddlFiltro.Font = gDefaultFont
            Me._cbddlFiltro.ListElement.Font = gDefaultFont
            Me._cbddlFiltro.DropDownListElement.EditorElement.Font = gDefaultFont
            '
            'cbhostValor
            '
            Me._cbhostValor.AutoSize = True
            'Me._cbhostValor.Size = New Size(130, 48)
            Me._cbhostValor.DisplayName = My.Resources.Application.TextoValor
            Me._cbhostValor.DrawBorder = True
            Me._cbhostValor.BorderColor = gCBForeColor
            Me._cbhostValor.DrawFill = False
            Me._cbhostValor.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me._cbhostValor.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me._cbhostValor.VisibleInOverflowMenu = True
            Me._cbhostValor.ForeColor = gCBForeColor
            Me._cbhostValor.Padding = New Padding(1)
            Me._cbhostValor.Alignment = ContentAlignment.MiddleCenter

            '
            '_cbbtnFilter
            '
            Me._cbbtnFilter.DisplayName = My.Resources.Application.TextoBuscar
            Me._cbbtnFilter.Text = My.Resources.Application.TextoBuscar
            Me._cbbtnFilter.DrawText = True
            Me._cbbtnFilter.ForeColor = gCBForeColor
            Me._cbbtnFilter.Image = Global.EasyGest.My.Resources.Resources._10
            Me._cbbtnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            Me._cbbtnFilter.Visibility = Telerik.WinControls.ElementVisibility.Visible
            Me._cbbtnFilter.VisibleInOverflowMenu = True
            Me._cbbtnFilter.Margin = New Padding(10, 0, 0, 0)
            Me._cbbtnFilter.Font = gDefaultFont
            Me._cbbtnFilter.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.B))
            '
            'ListItems
            '
            _itemContiene.Font = gDefaultFont
            _itemContiene.Selected = True
            _itemContiene.Tag = "{0}.Contains({1})"
            _itemContiene.Text = My.Resources.Application.TextoContiene
            _itemContiene.ForeColor = gCBForeColor
            _itemNoContiene.Font = gDefaultFont
            _itemNoContiene.Tag = "not {0}.Contains({1})"
            _itemNoContiene.Text = My.Resources.Application.TextoNoContiene
            _itemNoContiene.ForeColor = gCBForeColor
            _itemEmpiezaPor.Font = gDefaultFont
            _itemEmpiezaPor.Tag = "{0}.StartsWith({1})"
            _itemEmpiezaPor.Text = My.Resources.Application.TextoEmpiezaPor
            _itemEmpiezaPor.ForeColor = gCBForeColor
            _itemTerminaEn.Font = gDefaultFont
            _itemTerminaEn.Tag = "{0}.Endswith({1})"
            _itemTerminaEn.Text = My.Resources.Application.TextoTerminaEn
            _itemTerminaEn.ForeColor = gCBForeColor
            _itemIgual.Font = gDefaultFont
            _itemIgual.Tag = "{0} = {1}"
            _itemIgual.Text = My.Resources.Application.TextoIgual
            _itemIgual.ForeColor = gCBForeColor
            _itemDistinto.Font = gDefaultFont
            _itemDistinto.Tag = "{0} <> {1}"
            _itemDistinto.Text = My.Resources.Application.TextoDistinto
            _itemDistinto.ForeColor = gCBForeColor
            _itemMayor.Font = gDefaultFont
            _itemMayor.Tag = "{0} > {1}"
            _itemMayor.Text = My.Resources.Application.TextoMayor
            _itemMayor.ForeColor = gCBForeColor
            _itemMayorIgual.Font = gDefaultFont
            _itemMayorIgual.Tag = "{0} >= {1}"
            _itemMayorIgual.Text = My.Resources.Application.TextoMayorIgual
            _itemMayorIgual.ForeColor = gCBForeColor
            _itemMenor.Font = gDefaultFont
            _itemMenor.Tag = "{0} < {1}"
            _itemMenor.Text = My.Resources.Application.TextoMenor
            _itemMenor.ForeColor = gCBForeColor
            _itemMenorIgual.Font = gDefaultFont
            _itemMenorIgual.Tag = "{0} <= {1}"
            _itemMenorIgual.Text = My.Resources.Application.TextoMenorIgual
            _itemMenorIgual.ForeColor = gCBForeColor
            _itemEsNulo.Font = gDefaultFont
            _itemEsNulo.Tag = "{0} = null"
            _itemEsNulo.Text = My.Resources.Application.TextoEsNulo
            _itemEsNulo.ForeColor = gCBForeColor
            _itemNoNulo.Font = gDefaultFont
            _itemNoNulo.Tag = "{0} <> null"
            _itemNoNulo.Text = My.Resources.Application.TextoNoNulo
            _itemNoNulo.ForeColor = gCBForeColor
            _commandbar = commandbar
        End Sub

        Friend Sub Prepare(defaultitem As String)
            _commandbar.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me._cbddlCampo, Me._cbddlFiltro, Me._cbhostValor, Me._cbbtnFilter})
            If Not String.IsNullOrWhiteSpace(defaultitem) Then
                For Each item As RadListDataItem In _cbddlCampo.Items
                    If item.Value.ToString().Equals(defaultitem, StringComparison.InvariantCultureIgnoreCase) Then
                        item.Selected = True
                        Exit For
                    End If
                Next
            End If
            ConfigureByType(_cbddlCampo.SelectedItem.Tag.ToString())
            AddHandler _cbddlCampo.SelectedIndexChanging, AddressOf _cbddlCampo_SelectedIndexChanging
            AddHandler _cbbtnFilter.Click, AddressOf _cbbtnFilter_Click
        End Sub

        Friend Sub AddItemToFieldDDL(displayName As String, fieldName As String, type As String)
            Dim item As New RadListDataItem(displayName, fieldName)
            item.Tag = type
            item.Font = gDefaultFont
            item.Selected = _cbddlCampo.Items.Count = 0
            item.ForeColor = gCBForeColor
            _cbddlCampo.Items.Add(item)

        End Sub

        Friend Sub ClearFilterText()
            If TypeOf _cbhostValor.HostedItem Is RadTextBoxElement Then
                _texteditor.Text = String.Empty
            ElseIf TypeOf _cbhostValor.HostedItem Is RadSpinElement Then
                _numbereditor.Value = 0D
            ElseIf TypeOf _cbhostValor.HostedItem Is RadDateTimePickerElement Then
                _dateeditor.Value = Nothing
            End If
        End Sub

        Private Sub _cbbtnFilter_Click(sender As Object, e As System.EventArgs)
            Dim arg As New FilterEventArgs()
            arg.FilterExpression = BuildFilterExpression()
            RaiseEvent onFilter(Me, arg)
        End Sub

        Private Function GetFilterText() As String
            If TypeOf _cbhostValor.HostedItem Is RadTextBoxElement Then
                Return _texteditor.Text
            ElseIf TypeOf _cbhostValor.HostedItem Is RadSpinElement Then
                Return Convert.ToString(_numbereditor.Value)
            ElseIf TypeOf _cbhostValor.HostedItem Is RadDateTimePickerElement Then
                If _dateeditor.Value.HasValue() AndAlso _dateeditor.Value.Value.Ticks > 0 Then
                    Return _dateeditor.Value.Value.Ticks.ToString()
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Function

        Private Function BuildFilterExpression() As String
            Dim text As String = GetFilterText()
            If _cbddlFiltro.SelectedItem Is Nothing Or _cbddlCampo.SelectedItem Is Nothing Then
                Return ""
            Else
                Dim exp As String = _cbddlFiltro.SelectedItem.Tag.ToString()
                Dim tipo As String = _cbddlCampo.SelectedItem.Tag.ToString()
                Dim field As String = _cbddlCampo.SelectedItem.Value.ToString()
                Dim formatedexp As String = ""
                If _cbddlFiltro.SelectedItem Is _itemEsNulo Or _cbddlFiltro.SelectedItem Is _itemNoNulo Then
                    formatedexp = String.Format(exp, field)
                Else
                    If Not String.IsNullOrWhiteSpace(text) Then
                        Select Case tipo
                            Case Is = "String"
                                formatedexp = String.Format(exp, field, """" & text & """")
                            Case Is = "Number"
                                formatedexp = String.Format(exp, field, text)
                            Case Is = "Date"                                
                                formatedexp = String.Format(exp, field, "DateTime(" & text & ")")
                        End Select
                    End If
                End If

                Return formatedexp
            End If
        End Function

        Private Sub ConfigureByType(ByVal [type] As String)
            _cbddlFiltro.Items.Clear()
            Select Case [type].ToString()
                Case Is = "String"
                    _cbhostValor.HostedItem = _texteditor
                    _cbddlFiltro.Items.AddRange(New RadListDataItem() {_itemContiene, _itemNoContiene, _itemEmpiezaPor, _itemTerminaEn, _itemIgual, _itemDistinto})
                Case Is = "Date"
                    _cbhostValor.HostedItem = _dateeditor
                    _cbddlFiltro.Items.AddRange(New RadListDataItem() {_itemIgual, _itemDistinto, _itemMayor, _itemMayorIgual, _itemMenor, _itemMenorIgual})
                Case Is = "Number"
                    _cbhostValor.HostedItem = _numbereditor
                    _cbddlFiltro.Items.AddRange(New RadListDataItem() {_itemIgual, _itemDistinto, _itemMayor, _itemMayorIgual, _itemMenor, _itemMenorIgual})
            End Select
            _cbddlFiltro.Items.AddRange(New RadListDataItem() {_itemEsNulo, _itemNoNulo})
            _cbddlFiltro.SelectedIndex = 0
        End Sub

        Private Sub _cbddlCampo_SelectedIndexChanging(sender As System.Object, e As Telerik.WinControls.UI.Data.PositionChangingCancelEventArgs)
            Me.ConfigureByType(CStr(_cbddlCampo.Items(e.Position).Tag))
        End Sub

    End Class

End Namespace
