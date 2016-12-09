Imports System.Data.SqlClient
Imports System.Reflection

Namespace Modulo

    Module modAplicacion

        Private ReadOnly gChineseDefaultFont As Font = New Font("楷体", 10.5)
        Private ReadOnly gSpanishDefaultFont As Font = New Font("Lucida Sans Unicode", 9.75)
        Private ReadOnly gEditControlForecolor As Color = Color.FromArgb(10, 17, 104)
        Private ReadOnly gBorderFocusedColor As Color = Color.FromArgb(47, 82, 139)
        Private ReadOnly gBorderColor As Color = Color.FromArgb(156, 189, 232)

        Public gMostrarConfiguracionConexion As Boolean = False
        Public gMostrarSelectorEmpresas As Boolean = False
        Public gIsChinese As Boolean = False
        Public gDefaultFont, gDefaultSmallerFont, gDefaultBiggerFont As Font
        Public ReadOnly gCBForeColor As Color = Color.FromArgb(0, 197, 45)
        Public ReadOnly gBTNBGColors As Color() = New Color(3) {Color.FromArgb(251, 241, 191), Color.FromArgb(185, 234, 71), Color.FromArgb(173, 215, 76), Color.FromArgb(251, 241, 191)}
        Public gImpuestoPorDefecto As Impuestos = Nothing
        Public cLog As New General.Logs(My.Application.Info.DirectoryPath & "\logs", "EasyGest_")
        Public gChineseInputLanguage As InputLanguage = InputLanguage.DefaultInputLanguage

        Public Const CARACTERSEPARADOR As Char = ";"c

        Public Delegate Function GetApplicationCultureCallBack(f As Form) As System.Globalization.CultureInfo

        Public ReadOnly Property CajaCerrado As Boolean
            Get
                Return gDiario Is Nothing
            End Get
        End Property


        Public Function MostrarMensaje(ByVal parent As Form, ByVal texto As String, Optional ByVal estilo As Telerik.WinControls.RadMessageIcon = Telerik.WinControls.RadMessageIcon.Info, Optional botones As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal emitirSonido As Boolean = False) As DialogResult
            Return MostrarMensaje(parent, parent.Text, texto, Nothing, estilo, botones, emitirSonido)
        End Function

        Public Function MostrarMensaje(ByVal parent As Form, ByVal texto As String, ByVal titulo As String, Optional ByVal estilo As Telerik.WinControls.RadMessageIcon = Telerik.WinControls.RadMessageIcon.Info, Optional botones As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal emitirSonido As Boolean = False) As DialogResult
            Return MostrarMensaje(parent, titulo, texto, Nothing, estilo, botones, emitirSonido)
        End Function

        Public Function MostrarMensaje(ByVal parent As Form, ByVal excepcion As Exception, Optional ByVal estilo As Telerik.WinControls.RadMessageIcon = Telerik.WinControls.RadMessageIcon.Error, Optional botones As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal emitirSonido As Boolean = False) As DialogResult
            Return MostrarMensaje(parent, parent.Text, Nothing, excepcion, estilo, botones, emitirSonido)
        End Function

        Public Function MostrarMensaje(ByVal parent As Form, ByVal excepcion As Exception, ByVal titulo As String, Optional ByVal estilo As Telerik.WinControls.RadMessageIcon = Telerik.WinControls.RadMessageIcon.Error, Optional botones As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal emitirSonido As Boolean = False) As DialogResult
            Return MostrarMensaje(parent, titulo, Nothing, excepcion, estilo, botones, emitirSonido)
        End Function

        Public Function MostrarMensaje(ByVal texto As String, Optional ByVal estilo As Telerik.WinControls.RadMessageIcon = Telerik.WinControls.RadMessageIcon.Info, Optional botones As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal emitirSonido As Boolean = False) As DialogResult
            Return MostrarMensaje(My.Forms.frmPrincipal, My.Application.Info.ProductName, texto, Nothing, estilo, botones, emitirSonido)
        End Function

        Public Function MostrarMensaje(ByVal texto As String, ByVal titulo As String, Optional ByVal estilo As Telerik.WinControls.RadMessageIcon = Telerik.WinControls.RadMessageIcon.Info, Optional botones As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal emitirSonido As Boolean = False) As DialogResult
            Return MostrarMensaje(My.Forms.frmPrincipal, titulo, texto, Nothing, estilo, botones, emitirSonido)
        End Function

        Public Function MostrarMensaje(ByVal excepcion As Exception, Optional ByVal estilo As Telerik.WinControls.RadMessageIcon = Telerik.WinControls.RadMessageIcon.Error, Optional botones As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal emitirSonido As Boolean = False) As DialogResult
            Return MostrarMensaje(My.Forms.frmPrincipal, My.Application.Info.ProductName, Nothing, excepcion, estilo, botones, emitirSonido)
        End Function

        Public Function MostrarMensaje(ByVal excepcion As Exception, ByVal titulo As String, Optional ByVal estilo As Telerik.WinControls.RadMessageIcon = Telerik.WinControls.RadMessageIcon.Error, Optional botones As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal emitirSonido As Boolean = False) As DialogResult
            Return MostrarMensaje(My.Forms.frmPrincipal, titulo, Nothing, excepcion, estilo, botones, emitirSonido)
        End Function

        Public Function MostrarMensaje(ByVal titulo As String, ByVal texto As String, ByVal excepcion As Exception, Optional ByVal estilo As Telerik.WinControls.RadMessageIcon = Telerik.WinControls.RadMessageIcon.Error, Optional botones As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal emitirSonido As Boolean = False) As DialogResult
            Return MostrarMensaje(My.Forms.frmPrincipal, titulo, texto, excepcion, estilo, botones, emitirSonido)
        End Function

        Public Function MostrarMensaje(ByVal parent As Form, ByVal titulo As String, ByVal texto As String, ByVal excepcion As Exception, Optional ByVal estilo As Telerik.WinControls.RadMessageIcon = Telerik.WinControls.RadMessageIcon.None, Optional botones As MessageBoxButtons = MessageBoxButtons.OK, Optional ByVal emitirSonido As Boolean = False) As DialogResult
            Dim resultado As DialogResult

            If String.IsNullOrWhiteSpace(titulo) Then titulo = My.Application.Info.ProductName
            If String.IsNullOrWhiteSpace(texto) Then
                texto = ""
            Else
                texto = String.Concat(texto, IIf(IsNothing(excepcion), "", ControlChars.NewLine))
            End If

            If excepcion IsNot Nothing Then
                texto &= excepcion.GetType().FullName & ControlChars.NewLine & excepcion.Message
                Try
                    cLog.EscribirLog(Now(), String.Format("Título: {0}" & ControlChars.NewLine & "Mensaje: {1}" & ControlChars.NewLine & "Excepción: {2}" & ControlChars.NewLine & "Trace: " & ControlChars.NewLine & "{3}", titulo, excepcion.Message, excepcion.GetType.FullName, excepcion.StackTrace))
                Catch ex As Exception

                End Try

            End If
            If emitirSonido Then
                If estilo = Telerik.WinControls.RadMessageIcon.Error Or estilo = Telerik.WinControls.RadMessageIcon.Exclamation Then
                    My.Computer.Audio.Play(My.Resources.errores, AudioPlayMode.Background)
                End If
                If estilo = Telerik.WinControls.RadMessageIcon.Question Then
                    My.Computer.Audio.Play(My.Resources.question, AudioPlayMode.Background)
                End If
                If estilo = Telerik.WinControls.RadMessageIcon.Info Or estilo = Telerik.WinControls.RadMessageIcon.None Then
                    My.Computer.Audio.Play(My.Resources.aviso, AudioPlayMode.Background)
                End If
            End If
            resultado = Telerik.WinControls.RadMessageBox.Show(parent, texto, titulo, botones, estilo)
            Return resultado
        End Function

        Public Function GetApplicationCulture(f As Form) As System.Globalization.CultureInfo
            If f.InvokeRequired Then
                Dim d As New GetApplicationCultureCallBack(AddressOf GetApplicationCulture)
                Return DirectCast(f.Invoke(d, New Object() {f}), System.Globalization.CultureInfo)
            Else
                Return System.Threading.Thread.CurrentThread.CurrentCulture
            End If
        End Function

        Public Function GenerarCadenaConexion(servidor As String, catalogo As String, usuario As String, contraseña As String, Optional ByVal otros As String = "") As String
            Dim cadena As New SqlClient.SqlConnectionStringBuilder()
            Try
                cadena.Password = contraseña
                cadena.DataSource = servidor
                cadena.InitialCatalog = catalogo
                cadena.UserID = usuario
            Catch ex As Exception
                cadena.Clear()
            End Try
            Return String.Concat(cadena.ConnectionString, IIf(String.IsNullOrWhiteSpace(otros), "", ";" & otros))
        End Function

        Public Sub ActivarDesactivarControles(activo As Boolean, ByVal ParamArray controles As Control())
            For Each c As Control In controles
                c.Enabled = activo
            Next
        End Sub

        Public Sub ActivarDesactivarControles(activo As Boolean, ByVal ParamArray controles As Telerik.WinControls.RadElement())
            For Each c As Telerik.WinControls.RadElement In controles
                c.Enabled = activo
            Next
        End Sub

        Public Sub RellenarCombo(ddl As RadDropDownList, items As Dictionary(Of String, Nullable(Of Integer)))
            ddl.Items.Clear()
            For Each item As String In items.Keys
                Dim listitem As RadListDataItem = New RadListDataItem(item, items(item))
                listitem.ForeColor = ddl.ForeColor
                ddl.Items.Add(listitem)
            Next
        End Sub

        Public Sub ConfigurarIdioma(idioma As String)
            Dim cultLengua As New System.Globalization.CultureInfo(idioma)
            Dim dateFormat As Globalization.DateTimeFormatInfo = cultLengua.DateTimeFormat
            Dim numberFormat As Globalization.NumberFormatInfo = cultLengua.NumberFormat
            dateFormat.DateSeparator = "/"
            dateFormat.TimeSeparator = ":"
            dateFormat.FirstDayOfWeek = DayOfWeek.Monday
            dateFormat.ShortDatePattern = "dd/MM/yyyy"
            dateFormat.LongDatePattern = "dddd, dd/MM/yyyy"
            dateFormat.ShortTimePattern = "HH:mm"
            dateFormat.LongTimePattern = "HH:mm:ss"
            numberFormat.NumberDecimalSeparator = "."
            numberFormat.NumberGroupSeparator = ","
            numberFormat.NumberNegativePattern = 3
            numberFormat.PercentDecimalSeparator = "."
            numberFormat.PercentGroupSeparator = ","
            numberFormat.PercentSymbol = "%"
            numberFormat.PositiveSign = "+"
            numberFormat.NegativeSign = "-"
            numberFormat.CurrencySymbol = "€"
            numberFormat.CurrencyDecimalSeparator = "."
            numberFormat.CurrencyGroupSeparator = ","
            numberFormat.CurrencyPositivePattern = 3
            numberFormat.CurrencyNegativePattern = 8
            System.Threading.Thread.CurrentThread.CurrentCulture = cultLengua
            System.Windows.Forms.Application.CurrentCulture = cultLengua
            My.Resources.Application.Culture = cultLengua
            My.Application.ChangeCulture(idioma)
            My.Application.ChangeUICulture(idioma)
            My.Application.Culture.NumberFormat = numberFormat
            My.Application.Culture.DateTimeFormat = dateFormat

            If idioma.Equals("zh", StringComparison.InvariantCultureIgnoreCase) Then
                gIsChinese = True
                Telerik.WinControls.UI.Localization.RadGridLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.ChineseRadGridLocationProvider()
                Telerik.WinControls.UI.TreeViewLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.ChineseRadTreeViewLocalizationProvider()
                Telerik.WinControls.RadMessageLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.ChineseRadMessageLocalizationProvider()
                Telerik.WinControls.UI.CommandBarLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.ChineseCommandBarLocalizationProvider()
                Telerik.WinControls.UI.Localization.RadDockLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.ChineseRadDockLocalizationProvider()
                Telerik.WinControls.UI.ColorDialogLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.ChineseColorDialogLocalizationProvider()
                Telerik.WinControls.UI.CalendarLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.ChineseCalendarLocalizationProvider()
                Telerik.WinControls.UI.PropertyGridLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.ChinesePropertyGridLocalizationProvider()
                Telerik.WinControls.UI.PrintDialogsLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.ChinesePrintDialogsLocalizationProvider()
                Telerik.WinControls.UI.RadTimePickerLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.ChineseRadTimePickerLocalizationProvider()
                gDefaultFont = gChineseDefaultFont
            Else
                Telerik.WinControls.UI.Localization.RadGridLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.SpanishRadGridLocalizationProvider()
                TreeViewLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.SpanishRadTreeViewLocalizationProvider()
                Telerik.WinControls.RadMessageLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.SpanishRadMessageLocalizationProvider()
                Telerik.WinControls.UI.CommandBarLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.SpanishCommandBarLocalizationProvider()
                Telerik.WinControls.UI.Localization.RadDockLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.SpanishRadDockLocalizationProvider()
                Telerik.WinControls.UI.ColorDialogLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.SpanishColorDialogLocalizationProvider()
                Telerik.WinControls.UI.CalendarLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.SpanishCalendarLocalizationProvider()
                Telerik.WinControls.UI.PropertyGridLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.SpanishPropertyGridLocalizationProvider()
                Telerik.WinControls.UI.PrintDialogsLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.SpanishPrintDialogLocalizationProvider
                Telerik.WinControls.UI.RadTimePickerLocalizationProvider.CurrentProvider = New Presentacion.LocalizationProvider.SpanishRadTimePickerLocalizationProvider()

                gDefaultFont = gSpanishDefaultFont
            End If
            gDefaultSmallerFont = New Font(gDefaultFont.FontFamily, gDefaultFont.SizeInPoints - 2.0F)
            gDefaultBiggerFont = New Font(gDefaultFont.FontFamily, gDefaultFont.SizeInPoints + 2.0F)
        End Sub

        Private Function FindGridRow(ByVal grid As RadGridView, ByVal data As LINQEntityBase) As GridViewRowInfo

            'Dim tipo As Type = data.GetType()
            'Dim valoresidentidad As List(Of Object) = New List(Of Object)()
            Dim rowFound As GridViewRowInfo = Nothing
            rowFound = grid.Rows.Cast(Of GridViewRowInfo)().FirstOrDefault(Function(s As GridViewRowInfo) DirectCast(s.DataBoundItem, LINQEntityBase).PrimaryKeyCompare(data))
            'For Each identidad As String In identidades
            '    Dim identidadProperty As PropertyInfo = tipo.GetProperty(identidad, BindingFlags.Public Or BindingFlags.Instance)
            '    If Not IsNothing(identidadProperty) Then
            '        valoresidentidad.Add(identidadProperty.GetValue(data, Nothing))
            '    Else
            '        valoresidentidad.Add(Nothing)
            '    End If
            'Next
            'For Each row As GridViewRowInfo In grid.Rows
            '    Dim rowdata As Object = row.DataBoundItem
            '    Dim rowdatatype As Type = rowdata.GetType
            '    rowFound = Nothing
            '    If rowdatatype.Equals(tipo) Then
            '        If rowdata IsNot Nothing Then
            '            For i As Integer = 0 To identidades.Count - 1
            '                Dim rowdataProperty As PropertyInfo = rowdatatype.GetProperty(identidades(i))
            '                If rowdataProperty IsNot Nothing Then
            '                    If Not rowdataProperty.GetValue(rowdata, Nothing).Equals(valoresidentidad(i)) Then
            '                        rowFound = Nothing
            '                        Exit For
            '                    Else
            '                        rowFound = row
            '                    End If
            '                End If

            '            Next
            '            If rowFound IsNot Nothing Then Exit For
            '        End If
            '    End If
            'Next
            Return rowFound
        End Function

        'Public Function HasEntityInBingdingSource(bingding As BindingSource, entity As LINQEntityBase) As Boolean
        '    Dim source As Object = bingding.DataSource
        '    If IsNothing(source) Then Return False
        '    If TypeOf source Is IEnumerable Then

        '    End If
        '    If TypeOf source Is LINQEntityBase Then
        '        Return LINQEntityBase.ShallowCompare(DirectCast(source, LINQEntityBase), entity)
        '    End If
        '    Return False
        'End Function

        Public Sub AsignarTemaAplicacion(nombreTema As String)

            If Not String.IsNullOrWhiteSpace(nombreTema) Then
                Try
                    Dim tema As Telerik.WinControls.RadThemeComponentBase
                    If Not nombreTema.Equals("ControlDefault") Then
                        Dim ass As Reflection.Assembly = Reflection.Assembly.LoadFrom(My.Application.Info.DirectoryPath & "\" & "Telerik.WinControls.Themes." & nombreTema & ".dll")
                        tema = CType(ass.CreateInstance("Telerik.WinControls.Themes." & nombreTema & "Theme"), RadThemeComponentBase)
                        ass = Nothing
                        ThemeResolutionService.ApplicationThemeName = tema.ThemeName
                    Else
                        ThemeResolutionService.ApplicationThemeName = "ControlDefault"
                    End If
                Catch ex As Exception

                End Try
            End If

        End Sub

        Public Function UpdateSelectGridRow(ByRef grid As RadGridView, data As LINQEntityBase) As GridViewRowInfo

            Dim row As GridViewRowInfo
            If IsNothing(data) Then Return Nothing
            row = FindGridRow(grid, data)
            If Not IsNothing(row) Then
                data.ShallowCopy(DirectCast(row.DataBoundItem, LINQEntityBase))
            Else
                Dim binding As BindingSource = TryCast(grid.MasterTemplate.DataSource, BindingSource)
                If Not IsNothing(binding) Then _
                    binding.Add(data)
                row = FindGridRow(grid, data)
            End If
            grid.TableElement.ScrollToRow(row)
            grid.CurrentRow = row
            row.IsSelected = True
            row.InvalidateRow()
            Return row
        End Function

        Public Sub ConfigurarCommandBar(commandBarStripElement As CommandBarStripElement)
            For Each comando In commandBarStripElement.Items
                comando.Margin = New Padding(1, 0, 1, 0)
                If Not TypeOf comando Is CommandBarSeparator Then
                    'comando.BorderColor = Color.FromArgb(100, 150, 30)
                    comando.Shape = New Telerik.WinControls.RoundRectShape(5)
                    comando.Font = gDefaultFont
                    comando.ForeColor = Color.Coral
                    If TypeOf comando Is CommandBarDropDownList Then
                        Dim ddl As CommandBarDropDownList = DirectCast(comando, CommandBarDropDownList)
                        ddl.DropDownListElement.Shape = New Telerik.WinControls.RoundRectShape(5)
                        For Each i As RadListDataItem In ddl.Items
                            i.Font = gDefaultFont
                        Next
                    End If
                    If TypeOf comando Is CommandBarDropDownButton Then
                        Dim ddl As CommandBarDropDownButton = DirectCast(comando, CommandBarDropDownButton)
                        For Each i As RadItem In ddl.Items
                            i.Font = gDefaultFont
                        Next
                    End If
                    If comando.Name.Equals("cbbtnAgregar") Then
                        comando.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Insert))
                    End If
                    If comando.Name.Equals("cbbtnModificar") Then
                        comando.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
                    End If
                    If comando.Name.Equals("cbbtnEliminar") Then
                        comando.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Delete))
                    End If
                End If
            Next
        End Sub

        Public Sub PrepararControles(ctrls As Control.ControlCollection)
            For Each ctrl As Control In ctrls
                If TypeOf ctrl Is Telerik.WinControls.RadControl Then
                    PrepararRadControl(DirectCast(ctrl, RadControl))
                    EstablecerBorderRedondeado(DirectCast(ctrl, Telerik.WinControls.RadControl), 3)
                End If
                If TypeOf ctrl Is RadCheckBox Then PrepararCheckbox(DirectCast(ctrl, RadCheckBox))
                If TypeOf ctrl Is RadRadioButton Then PrepararRadiobutton(DirectCast(ctrl, RadRadioButton))
                If TypeOf ctrl Is RadDropDownList Then PrepararDropdownlist(DirectCast(ctrl, RadDropDownList))
                If TypeOf ctrl Is RadTextBox Then PrepararTextbox(DirectCast(ctrl, RadTextBox))
                If TypeOf ctrl Is RadMaskedEditBox Then PrepararMaskededitbox(DirectCast(ctrl, RadMaskedEditBox))
                If TypeOf ctrl Is RadGridView Then PrepararGridview(DirectCast(ctrl, RadGridView))
                If TypeOf ctrl Is RadSpinEditor Then PrepararSpinEditor(DirectCast(ctrl, RadSpinEditor))
                If TypeOf ctrl Is RadDateTimePicker Or TypeOf ctrl Is RadTimePicker Then PrepararDatetimerpicker(DirectCast(ctrl, RadControl))
                If TypeOf ctrl Is RadCalculatorDropDown Then PrepararCalculatordropdown(DirectCast(ctrl, RadCalculatorDropDown))
                If TypeOf ctrl Is RadGroupBox Or TypeOf ctrl Is RadPanel Or TypeOf ctrl Is RadSplitContainer Or TypeOf ctrl Is SplitPanel Then
                    PrepararControles(DirectCast(ctrl, Telerik.WinControls.RadControl).Controls)
                End If
                If TypeOf ctrl Is TableLayoutPanel Then
                    PrepararControles(DirectCast(ctrl, TableLayoutPanel).Controls)
                End If
            Next
        End Sub

        Private Sub PrepararCheckbox(checkbox As RadCheckBox)
            'checkbox.AllowShowFocusCues = True
            checkbox.BackColor = Color.Transparent
            Dim bordes As List(Of RadElement).Enumerator = checkbox.RootElement.GetDescendants(New TypeFilter(Of Primitives.BorderPrimitive)(), TreeTraversalMode.BreadthFirst).GetEnumerator()
            While bordes.MoveNext
                DirectCast(bordes.Current, Primitives.BorderPrimitive).ForeColor = gBorderColor
            End While
            'checkbox.ForeColor = gEditControlForecolor
            AddHandler checkbox.KeyPress, AddressOf checkbox_KeyPress
            AddHandler checkbox.GotFocus, AddressOf radControl_GotFocus
            AddHandler checkbox.LostFocus, AddressOf radContro_LostFocus
        End Sub

        Private Sub PrepararDatetimerpicker(picker As RadControl)
            AddHandler picker.GotFocus, AddressOf radControl_GotFocus
            AddHandler picker.LostFocus, AddressOf radContro_LostFocus
        End Sub

        Private Sub PrepararDropdownlist(dropdownlist As RadDropDownList)
            'dropdownlist.AllowShowFocusCues = True
            'dropdownlist.ForeColor = gEditControlForecolor
            
            AddHandler dropdownlist.ItemDataBound, AddressOf ddl_ItemDataBound
            AddHandler dropdownlist.GotFocus, AddressOf ddl_GotFocus
            AddHandler dropdownlist.GotFocus, AddressOf radControl_GotFocus
            AddHandler dropdownlist.LostFocus, AddressOf radContro_LostFocus
        End Sub

        Private Sub PrepararTextbox(textbox As RadTextBox)
            'textbox.AllowShowFocusCues = True
            'textbox.ForeColor = gEditControlForecolor
            AddHandler textbox.GotFocus, AddressOf txt_GotFocus
            AddHandler textbox.GotFocus, AddressOf radControl_GotFocus
            AddHandler textbox.LostFocus, AddressOf radContro_LostFocus
        End Sub

        Private Sub PrepararGridview(grid As RadGridView)
            'grid.AllowShowFocusCues = True
            'grid.ForeColor = gEditControlForecolor
            Dim tamañoFuente As Single = 0.0
            grid.TableElement.RowSpacing = 2
            grid.EnableAlternatingRowColor = True
            If Not IsNothing(gUsuario) Then
                tamañoFuente = gUsuario.TamañoGrid
            End If
            Dim fuente As Font = grid.TableElement.Font
            grid.TableElement.Font = New Font(fuente.FontFamily, fuente.SizeInPoints + tamañoFuente, fuente.Style)
            AddHandler grid.ViewCellFormatting, AddressOf grid_ViewCellFormatting
        End Sub

        Private Sub PrepararMaskededitbox(textbox As RadMaskedEditBox)
            'textbox.AllowShowFocusCues = True
            'textbox.ForeColor = gEditControlForecolor
            AddHandler textbox.GotFocus, AddressOf maskedtxt_GotFocus
            AddHandler textbox.GotFocus, AddressOf radControl_GotFocus
            AddHandler textbox.LostFocus, AddressOf radContro_LostFocus
        End Sub

        Private Sub PrepararRadControl(ctrl As RadControl)
            ctrl.AllowShowFocusCues = True
            ctrl.ForeColor = gEditControlForecolor            
        End Sub

        Private Sub PrepararRadiobutton(RadioButton As RadRadioButton)
            'RadioButton.AllowShowFocusCues = True
            RadioButton.BackColor = Color.Transparent
            'RadioButton.ForeColor = gEditControlForecolor
            AddHandler RadioButton.KeyPress, AddressOf radiobutton_KeyPress
        End Sub

        Private Sub EstablecerBorderRedondeado(ByVal ctrl As Telerik.WinControls.RadControl, ByVal diametro As Integer)
            Dim rrshape As New Telerik.WinControls.RoundRectShape(diametro)
            If TypeOf ctrl Is RadTextBox Then
                Dim txt As RadTextBox = DirectCast(ctrl, RadTextBox)
                txt.TextBoxElement.Shape = rrshape
            End If
            If TypeOf ctrl Is RadSpinEditor Then
                Dim txt As RadSpinEditor = DirectCast(ctrl, RadSpinEditor)
                txt.SpinElement.Shape = rrshape
                txt.SpinElement.Children(2).Children(1).Shape = rrshape
                txt.SpinElement.Children(2).Children(1).Children(0).Shape = rrshape
                txt.SpinElement.Children(2).Children(1).Children(1).Shape = rrshape
            End If
            If TypeOf ctrl Is RadDropDownList Then
                Dim txt As RadDropDownList = DirectCast(ctrl, RadDropDownList)
                txt.DropDownListElement.ArrowButton.Shape = rrshape
                txt.DropDownListElement.EditableElement.Shape = rrshape
                txt.DropDownListElement.Shape = rrshape
            End If
            If TypeOf ctrl Is RadDateTimePicker Then
                Dim txt As RadDateTimePicker = DirectCast(ctrl, RadDateTimePicker)
                txt.DateTimePickerElement.Shape = rrshape
                txt.DateTimePickerElement.TextBoxElement.Shape = rrshape
                txt.DateTimePickerElement.Children(2).Children(2).Shape = rrshape
            End If
            If TypeOf ctrl Is RadTimePicker Then
                Dim txt As RadTimePicker = DirectCast(ctrl, RadTimePicker)
                txt.TimePickerElement.Shape = rrshape
                txt.TimePickerElement.EditorElement.Shape = rrshape
                txt.TimePickerElement.Children(2).Children(2).Shape = rrshape
                txt.TimePickerElement.Children(2).Children(2).Children(0).Shape = rrshape
                txt.TimePickerElement.Children(2).Children(2).Children(1).Shape = rrshape
            End If
            If TypeOf ctrl Is RadMultiColumnComboBox Then
                Dim txt As RadMultiColumnComboBox = DirectCast(ctrl, RadMultiColumnComboBox)
                txt.MultiColumnComboBoxElement.Shape = rrshape
                txt.MultiColumnComboBoxElement.EditorElement.Shape = rrshape
                txt.MultiColumnComboBoxElement.TextBoxElement.Shape = rrshape
                txt.MultiColumnComboBoxElement.Children(2).Children(1).Shape = rrshape
            End If
            If TypeOf ctrl Is RadMaskedEditBox Then
                Dim txt As RadMaskedEditBox = DirectCast(ctrl, RadMaskedEditBox)
                txt.MaskedEditBoxElement.Shape = rrshape
            End If
            If TypeOf ctrl Is RadCalculatorDropDown Then
                Dim txt As RadCalculatorDropDown = DirectCast(ctrl, RadCalculatorDropDown)
                txt.CalculatorElement.Shape = rrshape
                txt.CalculatorElement.EditorContentElement.Shape = rrshape
                txt.CalculatorElement.EditorElement.Shape = rrshape
                txt.CalculatorElement.Children(1).Shape = rrshape
            End If
            If TypeOf ctrl Is RadLabel Then
                Dim txt As RadLabel = DirectCast(ctrl, RadLabel)
                If txt.BorderVisible Then _
                txt.LabelElement.Shape = rrshape                
            End If
            If TypeOf ctrl Is RadCheckBox Then

            End If
        End Sub

        Public Function GetPageButton(num As Integer) As RadButtonElement
            Dim btn As New RadButtonElement()
            btn.Shape = New Telerik.WinControls.RoundRectShape(5)
            btn.AutoSize = True
            btn.Size = New Size(35, 22)
            btn.Font = gSpanishDefaultFont
            btn.Tag = num
            btn.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            btn.TextAlignment = ContentAlignment.MiddleCenter
            btn.Margin = New Padding(3, 0, 3, 0)
            Return (btn)
        End Function

        Public Sub SetFillPrimitiveBackGroundColor(colors() As Color, ByVal element As Telerik.WinControls.Primitives.FillPrimitive)
            If colors IsNot Nothing Then
                If colors.Length > 0 Then
                    element.BackColor = colors(0)
                End If
                If colors.Length > 1 Then
                    element.BackColor2 = colors(1)
                End If
                If colors.Length > 2 Then
                    element.BackColor3 = colors(2)
                End If
                If colors.Length > 3 Then
                    element.BackColor4 = colors(3)
                End If
            End If
        End Sub

        Public Sub radiobutton_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
            Dim radiobutton As RadRadioButton = DirectCast(sender, RadRadioButton)
            If e.KeyChar = "+"c Then
                radiobutton.IsChecked = True
            End If
            If e.KeyChar = "-"c Then
                radiobutton.IsChecked = False
            End If
        End Sub

        Public Sub checkbox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
            Dim checkbox As RadCheckBox = DirectCast(sender, RadCheckBox)
            If e.KeyChar = "+"c Then
                checkbox.Checked = True
            End If
            If e.KeyChar = "-"c Then
                checkbox.Checked = False
            End If
        End Sub

        Private Sub radControl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim ctrl As RadControl = DirectCast(sender, RadControl)
            CambiarColorBorde(ctrl, gBorderFocusedColor)
        End Sub

        Private Sub radContro_LostFocus(sender As Object, e As EventArgs)
            Dim ctrl As RadControl = DirectCast(sender, RadControl)
            CambiarColorBorde(ctrl, gBorderColor)
        End Sub

        Private Sub CambiarColorBorde(control As RadControl, color As Color)
            Dim bordes As List(Of RadElement).Enumerator
            bordes = control.RootElement.GetDescendants(New TypeFilter(Of Primitives.BorderPrimitive)(), TreeTraversalMode.BreadthFirst).GetEnumerator()
            Do While bordes.MoveNext
                'gBorderColor = borde.ForeColor
                Dim borde As Primitives.BorderPrimitive = TryCast(bordes.Current, Primitives.BorderPrimitive)
                If Not IsNothing(borde) Then borde.ForeColor = color
            Loop
        End Sub

        Private Sub ddl_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
            Try
                DirectCast(sender, RadDropDownList).SelectAllText()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub txt_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                DirectCast(sender, RadTextBox).SelectAll()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub maskedtxt_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                DirectCast(sender, RadMaskedEditBox).SelectAll()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub ddl_ItemDataBound(sender As System.Object, args As Telerik.WinControls.UI.ListItemDataBoundEventArgs)
            Try
                args.NewItem.ForeColor = gEditControlForecolor
                args.NewItem.Font = DirectCast(args.NewItem.OwnerControl, DropDownPopupForm).OwnerDropDownListElement.Font
            Catch ex As Exception

            End Try
        End Sub

        Private Sub grid_ViewCellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CellFormattingEventArgs)
            Try
                If TypeOf e.CellElement Is GridHeaderCellElement Or TypeOf e.CellElement Is GridTableHeaderCellElement Then
                    e.CellElement.Font = New Font(gDefaultFont.FontFamily, gDefaultFont.SizeInPoints + gUsuario.TamañoGrid)
                ElseIf TypeOf e.CellElement Is GridFilterCellElement Or TypeOf e.CellElement Is GridGroupContentCellElement Or TypeOf e.CellElement Is GridSummaryCellElement Or TypeOf e.CellElement Is GridSearchCellElement Then
                    e.CellElement.Font = New Font(gDefaultSmallerFont.FontFamily, gDefaultSmallerFont.SizeInPoints + gUsuario.TamañoGrid)
                End If
            Catch ex As Exception
            End Try
        End Sub

        Public Function GetItemFromPoint(Of T As Telerik.WinControls.RadElement)(ByVal control As Telerik.WinControls.RadControl, ByVal point As Point, ByVal isScreenPoint As Boolean) As T
            Dim rPoint As Point
            If isScreenPoint Then
                rPoint = control.PointToClient(point)
            Else
                rPoint = point
            End If
            Dim element As Telerik.WinControls.RadElement = control.ElementTree.GetElementAtPoint(rPoint)
            If TypeOf element Is T Then
                Return DirectCast(element, T)
            Else
                Return Nothing
            End If
        End Function

        Private Sub PrepararSpinEditor(radSpinEditor As RadSpinEditor)
            'radSpinEditor.AllowShowFocusCues = True
            'radSpinEditor.ForeColor = gEditControlForecolor
            radSpinEditor.BackColor = Color.Transparent
            AddHandler radSpinEditor.GotFocus, AddressOf txt_GotFocus
            AddHandler radSpinEditor.GotFocus, AddressOf radControl_GotFocus
            AddHandler radSpinEditor.LostFocus, AddressOf radContro_LostFocus
        End Sub

        Private Sub PrepararCalculatordropdown(calculatorDropDown As RadCalculatorDropDown)
            AddHandler calculatorDropDown.GotFocus, AddressOf radControl_GotFocus
            AddHandler calculatorDropDown.LostFocus, AddressOf radContro_LostFocus
        End Sub

    End Module

End Namespace
