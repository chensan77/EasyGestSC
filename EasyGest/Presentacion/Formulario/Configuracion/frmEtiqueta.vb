Imports EasyGestControllers

Namespace Presentacion.Formulario.Configuracion

    Public Class frmEtiqueta

        Private _etiquetasHdeleted As List(Of EtiquetasEnHoja) = New List(Of EtiquetasEnHoja)()
        Private _etiquetasRdeleted As List(Of EtiquetasEnRollo) = New List(Of EtiquetasEnRollo)()
        Private _diseñodeleted As List(Of DiseñosEtiqueta) = New List(Of DiseñosEtiqueta)()

#Region "Evento Form"

        Private Sub frmEtiqueta_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            If Me.DialogResult = DialogResult.OK Then
                Try
                    'tratar etiquetas
                    Using control As New EtiquetasEnHojaController
                        'Dim nuevos As New List(Of EtiquetasEnHoja)()
                        control.SyncronisingItem(_etiquetasHdeleted.AsEnumerable)
                        'For Each Etiqueta As EtiquetasEnHoja In EtiquetasHBindingSource.List
                        '    If Etiqueta.idEtiqueta = 0 Then
                        '        nuevos.Add(Etiqueta)
                        '    Else
                        '        control.UpdateItem(Etiqueta)
                        '    End If
                        'Next
                        control.SyncronisingItem(DirectCast(EtiquetasHBindingSource.List, List(Of EtiquetasEnHoja)).AsEnumerable())
                    End Using
                    Using control As New EtiquetasEnRolloController
                        'Dim nuevos As New List(Of EtiquetasEnRollo)()
                        control.SyncronisingItem(_etiquetasRdeleted.AsEnumerable)
                        'For Each Etiqueta As EtiquetasEnRollo In EtiquetasRBindingSource.List
                        '    If Etiqueta.idEtiqueta = 0 Then
                        '        nuevos.Add(Etiqueta)
                        '    Else
                        '        control.UpdateItem(Etiqueta)
                        '    End If
                        'Next
                        control.SyncronisingItem(DirectCast(EtiquetasRBindingSource.List, List(Of EtiquetasEnRollo)).AsEnumerable())
                    End Using
                    'tratar diseño etiquetas
                    Using control As New DiseñosEtiquetaController
                        'Dim nuevos As New List(Of DiseñosEtiqueta)()
                        control.SyncronisingItem(_diseñodeleted.AsEnumerable)
                        'For Each Diseño As DiseñosEtiqueta In DiseñosEtiquetaBindingSource.List
                        '    If Diseño.idDiseño = 0 Then
                        '        nuevos.Add(Diseño)
                        '    Else
                        '        control.UpdateItem(Diseño)
                        '    End If
                        'Next
                        control.SyncronisingItem(DirectCast(DiseñosEtiquetaBindingSource.List, List(Of DiseñosEtiqueta)).AsEnumerable())
                    End Using
                Catch ex As Exception
                    MostrarMensaje(ex, Me.Text, Telerik.WinControls.RadMessageIcon.Error, MessageBoxButtons.OK)
                    e.Cancel = True
                End Try
            End If
        End Sub

        Private Sub frmEtiqueta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            pvEtiqueta.SelectedPage = pvpEtiquetasEnHoja
            Dim colUidad As GridViewComboBoxColumn = DirectCast(gridEtiqutasR.Columns.Item("UnidadMedida"), GridViewComboBoxColumn)
            colUidad.DataSource = New String() {"CM", "INCH", "POINT"}
            PrepararControles(pvpEtiquetasEnHoja.Controls)
            PrepararControles(pvpDiseños.Controls)
            btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
        End Sub

        Private Sub frmEtiqueta_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            CargarDatos()
            Debug.Flush()
        End Sub

        Private Sub frmEtiqueta_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
            If e.KeyChar = Convert.ToChar(27) Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If
        End Sub

#End Region

#Region "Evento Grid"

        Private Sub gridDatos_RowsChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCollectionChangingEventArgs) Handles gridEtiquetasH.RowsChanging, gridDiseños.RowsChanging, gridEtiqutasR.RowsChanging
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
                e.Cancel = Not MostrarMensaje(My.Resources.Application.ConfirmacionBorrarDato, Me.Text, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes
            End If

        End Sub

        Private Sub gridDiseños_RowsChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCollectionChangedEventArgs) Handles gridDiseños.RowsChanged
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
                For Each row As GridViewRowInfo In e.OldItems
                    Dim diseño As DiseñosEtiqueta = DirectCast(row.DataBoundItem, DiseñosEtiqueta)
                    If Not IsNothing(diseño) AndAlso diseño.LINQEntityState <> EntityState.New Then
                        diseño.SetAsDeleteOnSubmit()
                        _diseñodeleted.Add(diseño)
                        rptvPrevisualizacion.ReportSource = Nothing
                    End If
                Next
            End If
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Add Then
                For Each row As GridViewRowInfo In e.NewItems
                    DirectCast(row.DataBoundItem, DiseñosEtiqueta).SetAsInsertOnSubmit()
                Next

            End If
        End Sub

        Private Sub gridEtiquetasH_RowsChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCollectionChangedEventArgs) Handles gridEtiquetasH.RowsChanged
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
                Dim diseños As IList(Of DiseñosEtiqueta) = DirectCast(DiseñosEtiquetaBindingSource.DataSource, List(Of DiseñosEtiqueta))
                For Each row As GridViewRowInfo In e.OldItems
                    Dim etiqueta As EtiquetasEnHoja = DirectCast(row.DataBoundItem, EtiquetasEnHoja)
                    If diseños.Any(Function(a As DiseñosEtiqueta) a.idEtiqueta = etiqueta.idEtiqueta And a.TipoEtiqueta = Etiquetas.TIPO_ETIQUETA_ENHOJA) Then
                        row.ErrorText = "No se puede eliminar"
                    Else
                        If Not IsNothing(etiqueta) AndAlso etiqueta.idEtiqueta > 0 Then
                            _etiquetasHdeleted.Add(etiqueta)
                        End If
                    End If
                Next
            ElseIf e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Add Then
                For Each row As GridViewRowInfo In e.NewItems
                    DirectCast(row.DataBoundItem, EtiquetasEnHoja).SetAsInsertOnSubmit()
                Next
            End If

        End Sub

        Private Sub gridEtiqutasR_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles gridEtiqutasR.RowsChanged
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
                Dim diseños As IList(Of DiseñosEtiqueta) = DirectCast(DiseñosEtiquetaBindingSource.DataSource, List(Of DiseñosEtiqueta))
                For Each row As GridViewRowInfo In e.OldItems
                    Dim etiqueta As EtiquetasEnRollo = DirectCast(row.DataBoundItem, EtiquetasEnRollo)
                    If diseños.Any(Function(a As DiseñosEtiqueta) a.idEtiqueta = etiqueta.idEtiqueta And a.TipoEtiqueta = Etiquetas.TIPO_ETIQUETA_ENROLLO) Then
                        row.ErrorText = "No se puede eliminar"
                    Else
                        If Not IsNothing(etiqueta) AndAlso etiqueta.idEtiqueta > 0 Then
                            _etiquetasRdeleted.Add(etiqueta)
                        End If
                    End If
                Next
            ElseIf e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Add Then
                For Each row As GridViewRowInfo In e.NewItems
                    DirectCast(row.DataBoundItem, EtiquetasEnRollo).SetAsInsertOnSubmit()
                Next
            End If

        End Sub

        Private Sub gridDiseños_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridDiseños.SelectionChanged
            Dim seleccionado As DiseñosEtiqueta = gridDiseños.SelectedItem(Of DiseñosEtiqueta)()
            If Not IsNothing(seleccionado) AndAlso Not IsNothing(seleccionado.XMLDiseño) Then
                Dim report As New Telerik.Reporting.XmlReportSource()
                report.Xml = seleccionado.XMLDiseño.ToString()
                rptvPrevisualizacion.ReportSource = report
                rptvPrevisualizacion.RefreshReport()
            Else
                rptvPrevisualizacion.ReportSource = Nothing
                rptvPrevisualizacion.RefreshReport()
            End If
        End Sub
#End Region

#Region "Evento Botones Acciones"

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click
            Dim seleccionado As DiseñosEtiqueta
            seleccionado = gridDiseños.SelectedItem(Of DiseñosEtiqueta)()
            If Not IsNothing(seleccionado) Then
                Using fileDialog As New OpenFileDialog()
                    fileDialog.Multiselect = False
                    fileDialog.Filter = "Diseño de informe|*.trdx;"
                    If fileDialog.ShowDialog() = DialogResult.OK Then
                        Dim report As New Telerik.Reporting.UriReportSource()
                        report.Uri = fileDialog.FileName
                        rptvPrevisualizacion.ReportSource = report
                        rptvPrevisualizacion.RefreshReport()
                        seleccionado.XMLDiseño = CargarXML(fileDialog.FileName)
                        Me.txtArchivo.Text = New IO.FileInfo(fileDialog.FileName).Name
                    End If
                End Using
            End If
        End Sub

#End Region

#Region "Operaciones ARD"

        Private Sub CargarDatos()
            Dim listaEtiquetas As New List(Of Etiquetas)
            Using c As New Controller.EtiquetasEnHojaController()
                EtiquetasHBindingSource.DataSource = c.GetItems("", "Usos DESC, Referencia")
                listaEtiquetas.AddRange(c.GetEtiquetasGenericas())
            End Using
            Using c As New Controller.EtiquetasEnRolloController()
                EtiquetasRBindingSource.DataSource = c.GetItems("", "Usos DESC, Referencia")
                listaEtiquetas.AddRange(c.GetEtiquetasGenericas())
            End Using
            EtiquetasDiseñoBindingSource.DataSource = listaEtiquetas
            Using c As New Controller.DiseñosEtiquetaController()
                DiseñosEtiquetaBindingSource.DataSource = c.GetItems("", "Nombre")
            End Using
        End Sub
#End Region

        Private Function CargarXML(ByVal fileName As String) As Xml.Linq.XElement
            Dim xmlFile As Xml.Linq.XDocument
            Dim xmlEle As Xml.Linq.XElement
            xmlFile = Xml.Linq.XDocument.Load(fileName)

            xmlEle = xmlFile.Root
            Return xmlEle
        End Function


        'Private Sub ddlEtiquetas_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlEtiquetas.SelectedValueChanged
        '    Dim seleccionado As DiseñosEtiqueta = gridDiseños.SelectedItem(Of DiseñosEtiqueta)()
        '    If Not IsNothing(seleccionado) Then
        '        seleccionado.idEtiqueta = ddlEtiquetas.SelectedValue
        '    End If
        'End Sub

    End Class

End Namespace
