Imports EasyGestControllers

Namespace Presentacion.Formulario.Configuracion

    Public Class frmEtiqueta

        Private _etiquetasdeleted As List(Of Etiquetas) = New List(Of Etiquetas)()
        Private _diseñodeleted As List(Of DiseñosEtiqueta) = New List(Of DiseñosEtiqueta)()

#Region "Evento Form"

        Private Sub frmEtiqueta_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            If Me.DialogResult = DialogResult.OK Then
                Try
                    'tratar etiquetas
                    Using control As New EtiquetasController
                        Dim nuevos As New List(Of Etiquetas)()
                        control.DeleteItems(_etiquetasdeleted)
                        For Each Etiqueta As Etiquetas In EtiquetasBindingSource.List
                            If Etiqueta.idEtiqueta = 0 Then
                                nuevos.Add(Etiqueta)
                            Else
                                control.UpdateItem(Etiqueta)
                            End If
                        Next
                        control.AddItems(nuevos)
                    End Using
                    'tratar diseño etiquetas
                    Using control As New DiseñosEtiquetaController
                        Dim nuevos As New List(Of DiseñosEtiqueta)()
                        control.DeleteItems(_diseñodeleted)
                        For Each Diseño As DiseñosEtiqueta In DiseñosEtiquetaBindingSource.List
                            If Diseño.idDiseño = 0 Then
                                nuevos.Add(Diseño)
                            Else
                                control.UpdateItem(Diseño)
                            End If
                        Next
                        control.AddItems(nuevos)
                    End Using
                Catch ex As Exception
                    MostrarMensaje(ex, Me.Text, Telerik.WinControls.RadMessageIcon.Error, MessageBoxButtons.OK)
                    e.Cancel = True
                End Try
            End If
        End Sub

        Private Sub frmEtiqueta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            pvEtiqueta.SelectedPage = pvpEtiquetas
            PrepararControles(pvpEtiquetas.Controls)
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

        Private Sub gridDatos_RowsChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCollectionChangingEventArgs) Handles gridDatos.RowsChanging, gridDiseños.RowsChanging
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then                
                e.Cancel = Not MostrarMensaje(My.Resources.Application.ConfirmacionBorrarDato, Me.Text, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes
            End If
        End Sub

        Private Sub gridDiseños_RowsChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCollectionChangedEventArgs) Handles gridDiseños.RowsChanged
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
                For Each row As GridViewRowInfo In e.OldItems
                    Dim diseño As DiseñosEtiqueta = DirectCast(row.DataBoundItem, DiseñosEtiqueta)
                    If Not IsNothing(diseño) AndAlso diseño.idDiseño > 0 Then
                        _diseñodeleted.Add(diseño)
                        rptvPrevisualizacion.ReportSource = Nothing
                    End If
                Next
            End If
        End Sub

        Private Sub gridDatos_RowsChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.GridViewCollectionChangedEventArgs) Handles gridDatos.RowsChanged
            If e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove Then
                Dim diseños As IList(Of DiseñosEtiqueta) = DirectCast(DiseñosEtiquetaBindingSource.DataSource, List(Of DiseñosEtiqueta))
                For Each row As GridViewRowInfo In e.OldItems
                    Dim etiqueta As Etiquetas = DirectCast(row.DataBoundItem, Etiquetas)
                    If diseños.Any(Function(a As DiseñosEtiqueta) a.idEtiqueta = etiqueta.idEtiqueta) Then
                        row.ErrorText = "No se puede eliminar"
                    Else
                        If Not IsNothing(etiqueta) AndAlso etiqueta.idEtiqueta > 0 Then
                            _etiquetasdeleted.Add(etiqueta)
                        End If
                    End If
                Next
            ElseIf e.Action = Telerik.WinControls.Data.NotifyCollectionChangedAction.ItemChanged Then

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
            Using c As New Controller.EtiquetasController()
                EtiquetasBindingSource.DataSource = c.GetItems("", "Usos DESC, Referencia")
                EtiquetasDiseñoBindingSource.DataSource = c.GetItems("", "Referencia")
            End Using

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
