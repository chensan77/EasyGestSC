Imports EasyGest.Presentacion.Formulario.Cliente
Imports EasyGest.Presentacion.Formulario.Contacto
Imports EasyGest.Presentacion.Formulario.Cuenta
Imports EasyGest.Presentacion.Formulario.Dialogo
Imports EasyGest.Presentacion.Formulario.Proveedor
Imports EasyGest.Presentacion.Formulario.Configuracion
Imports EasyGest.Presentacion.Formulario.Producto
Imports Telerik.WinControls.UI.Docking

Namespace Presentacion.Formulario
    Public Class frmPrincipal

        Private Sub btnCliente_Click(sender As Object, e As System.EventArgs) Handles mbtnitemCliente.Click
            AddForm(New frmCliente(), True)
        End Sub

        Private Sub mbtnitemSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
            Me.Close()
        End Sub

        Private Sub frmPrincipal_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            Application.Exit()
        End Sub

        Private Sub frmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            If e.CloseReason = CloseReason.TaskManagerClosing Or e.CloseReason = CloseReason.WindowsShutDown Then
                If e.CloseReason = CloseReason.WindowsShutDown Then
                    If Not CajaCerrado Then
                        CierreCaja()
                    End If
                End If
            Else
                If Not MostrarMensaje(My.Resources.Application.ConfirmacionSalir, My.Application.Info.ProductName, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo, False) = Windows.Forms.DialogResult.Yes Then
                    e.Cancel = True
                Else
                    If Not CajaCerrado Then
                        CierreCaja()
                    End If
                End If
            End If
        End Sub

        Private Sub frmPrincipal_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
            Dim useCtrl, useAlt, useShift As Boolean
            Dim controlKey, key As String
            If gConfLocal.UsarCajon AndAlso e.KeyValue >= CInt(Keys.F1) And e.KeyValue <= CInt(Keys.F12) Then
                Try
                    controlKey = gConfLocal.AtajoAperturaCajon.Split("+"c)(0)
                    key = gConfLocal.AtajoAperturaCajon.Split("+"c)(1)
                    useAlt = controlKey.Contains("ALT")
                    useCtrl = controlKey.Contains("CTRL")
                    useShift = controlKey.Contains("SHIFT")
                    If e.Shift = useShift And e.Control = useCtrl And e.Alt = useAlt And e.KeyCode.Equals([Enum].Parse(GetType(Keys), key, True)) Then
                        e.SuppressKeyPress = False
                        'Impresion.TareaImpresion.AbrirCajon()
                    End If
                Catch ex As Exception

                End Try
            End If
            If e.KeyCode = Keys.Home And e.Control And e.Alt Then
                AddForm(New frmInicio(), True)
            End If
        End Sub

        Private Sub frmPrincipal_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            mitemCerrar.Font = gDefaultFont
            mitemIniciar.Font = gDefaultFont
            mitemContactosCli.Font = gDefaultFont
            mitemContactosPro.Font = gDefaultFont
            mitemCuentasPro.Font = gDefaultFont
            mitemCuentasCli.Font = gDefaultFont
            mitemTarjetas.Font = gDefaultFont
            mitemImpresionEtiqueta.Font = gDefaultFont
            mitemVales.Font = gDefaultFont
            mitemHaberes.Font = gDefaultFont
            mitemDeberes.Font = gDefaultFont

            sbtnCliente.DropDownButtonElement.ActionButton.Font = gDefaultBiggerFont
            sbtnPedido.DropDownButtonElement.ActionButton.Font = gDefaultBiggerFont
            sbtnProducto.DropDownButtonElement.ActionButton.Font = gDefaultBiggerFont
            sbtnProveedor.DropDownButtonElement.ActionButton.Font = gDefaultBiggerFont
            sbtnVenta.DropDownButtonElement.ActionButton.Font = gDefaultBiggerFont
            btnInforme.Font = gDefaultBiggerFont
            btnConfiguracion.Font = gDefaultBiggerFont

            doccPrincipal.Font = gDefaultFont
            sbtnProducto.DefaultItem = mbtnitemProducto
            sbtnCliente.DefaultItem = mbtnitemCliente
            sbtnProveedor.DefaultItem = mbtnitemProveedor
            sbtnVenta.DefaultItem = mbtnitemVenta
            sbtnPedido.DefaultItem = mbtnitemPedido

            lbleUsuario.Font = gDefaultSmallerFont
            lbleVersion.Font = gDefaultSmallerFont
            lbleEmpresa.Font = gDefaultSmallerFont
            lbleHoraApertura.Font = gDefaultSmallerFont
            lbleHoraInicio.Font = gDefaultSmallerFont
            lblePuesto.Font = gDefaultSmallerFont
            If CajaCerrado Then
                lbleHoraApertura.Text = My.Resources.Application.TextoHoraApertura & ": --"
            Else
                lbleHoraApertura.Text = My.Resources.Application.TextoHoraApertura & ": " & gDiario.Apertura.ToString()
            End If
            lbleUsuario.Text = My.Resources.Application.TextoUsuario & ": " & gUsuario.Nombre
            lbleEmpresa.Text = My.Resources.Application.TextoEmpresa & ": " & gEmpresa.Empresa
            lblePuesto.Text = My.Resources.Application.TextoPuesto & ": " & gPuesto.Puesto
            lbleVersion.Text = My.Resources.Application.TextoVersion & ": " & My.Application.Info.Version.ToString(4)
            lbleHoraInicio.Text = My.Resources.Application.TextoHoraInicio & ": " & Now().ToString()

            sbtnVenta.Enabled = ((gUsuario.PermisoVenta And Permiso.Visualizacion) = Permiso.Visualizacion)
            sbtnPedido.Enabled = ((gUsuario.PermisoCompra And Permiso.Visualizacion) = Permiso.Visualizacion)
            btnConfiguracion.Enabled = ((gUsuario.PermisoConfiguracion And Permiso.Modificacion) = Permiso.Modificacion)
            sbtnProducto.Enabled = ((gUsuario.PermisoProducto And Permiso.Visualizacion) = Permiso.Visualizacion)
            sbtnCliente.Enabled = ((gUsuario.PermisoCliente And Permiso.Visualizacion) = Permiso.Visualizacion)
            sbtnProveedor.Enabled = ((gUsuario.PermisoProveedor And Permiso.Visualizacion) = Permiso.Visualizacion)
            'mitemIniciar.Visibility = CType(IIf(gConfGlobal.Autentificar, ElementVisibility.Visible, ElementVisibility.Collapsed), ElementVisibility)
            'mitemCerrar.Visibility = CType(IIf(gConfGlobal.Autentificar, ElementVisibility.Visible, ElementVisibility.Collapsed), ElementVisibility)
            AsignarTemaAplicacion(gUsuario.Apariencia)
        End Sub

        Friend Function AperturaCaja() As Boolean
            Dim dialogo As New frmApertura()
            Dim continuar As Boolean
            Try
                If dialogo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    gDiario = dialogo.Diario
                    lbleHoraApertura.Text = My.Resources.Application.TextoHoraApertura & ": " & gDiario.Apertura.ToString()
                    ActualizarEstadoInicioCierre()
                    continuar = True
                End If
            Catch ex As Exception
                continuar = False
                MostrarMensaje(My.Application.Info.ProductName, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
            Return continuar
        End Function

        Friend Function CierreCaja() As Boolean
            Dim dialogo As New frmCierre()
            Dim continuar As Boolean
            Try
                If dialogo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    gDiario = Nothing
                    lbleHoraApertura.Text = My.Resources.Application.TextoHoraApertura & ": " & "--"
                    ActualizarEstadoInicioCierre()
                    continuar = True
                End If
            Catch ex As Exception
                continuar = False
                MostrarMensaje(My.Application.Info.ProductName, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
            End Try
            Return continuar
        End Function

        Friend Function FindFormByType(tipo As Type) As IEnumerable(Of Form)
            Return dokPrincipal.MdiChildren.Where(Function(s As Form) s.GetType() Is tipo)
        End Function

        Friend Sub AddForm(frm As RadForm, unico As Boolean)
            If IsNothing(frm) Then Return
            frm.KeyPreview = True
            If unico Then
                Dim forms As IEnumerable(Of Form) = dokPrincipal.MdiChildren.Where(Function(s As Form) s.Name = frm.Name)
                If forms.Count > 0 Then
                    dokPrincipal.ActivateMdiChild(forms.First)
                    Return
                End If
            Else
                frm.Text &= Now().ToString("[hhmmss]")
            End If
            frm.MdiParent = Me
            frm.Show()
        End Sub

        Friend Sub RemoveForm(formType As Type)
            Dim forms As IEnumerable(Of Form) = dokPrincipal.MdiChildren.Where(Function(s As Form) s.GetType() Is formType)

            For Each f As Form In forms
                f.Close()
            Next
        End Sub

        Friend Sub ShowAlerta(titulo As String, contenido As String, Optional contIcon As Image = Nothing)
            alertTarea.CaptionText = titulo
            alertTarea.ContentText = contenido
            If Not IsNothing(contIcon) Then
                alertTarea.ContentImage = contIcon
            Else
                alertTarea.ContentImage = My.Resources.AQUA_ICONS_SYSTEM_ALERT_NOTE_ICON
            End If
            alertTarea.Show()
        End Sub

        Private Sub mitemContactosCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitemContactosCli.Click
            AddForm(New frmContacto(Data.Entity.Contactos.TIPO_PROPIETARIO_CLIENTE), True)
        End Sub

        Private Sub mitemCuentasCli_Click(sender As System.Object, e As System.EventArgs) Handles mitemCuentasCli.Click
            AddForm(New frmCuenta(Data.Entity.DatosBancario.TIPO_PROPIETARIO_CLIENTE), True)
        End Sub

        Private Sub mitemContactosPro_Click(sender As System.Object, e As System.EventArgs) Handles mitemContactosPro.Click
            AddForm(New frmContacto(Data.Entity.Contactos.TIPO_PROPIETARIO_PROVEEDOR), True)
        End Sub

        Private Sub mbtnitemProveedor_Click(sender As Object, e As System.EventArgs) Handles mbtnitemProveedor.Click
            AddForm(New frmProveedor(), True)
        End Sub

        Private Sub btnConfiguracion_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnConfiguracion.Click
            AddForm(New frmConfiguracion(), True)
        End Sub

        Private Sub frmPrincipal_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            ToolWindow1.AutoHide()
            'If gEmpresa Is Nothing Then
            '    Dim frm As New frmEmpresa(False)
            '    frm.ShowDialog()
            'End If
            If gConfLocal.MostrarInicioArranque Then AddForm(New frmInicio(), True)
            If Not CajaCerrado Then
                If gDiario.Apertura.DayOfYear < Today.DayOfYear Then
                    Try
                        Dim mensaje As String = String.Format(My.Resources.Application.ConfirmacionCerrarCajaAnterior, gDiario.Apertura.ToShortDateString)
                        If MostrarMensaje(mensaje, My.Application.Info.ProductName, Telerik.WinControls.RadMessageIcon.Question, MessageBoxButtons.YesNo, False) = Windows.Forms.DialogResult.Yes Then
                            CierreCaja()
                        End If
                    Catch ex As Exception
                        MostrarMensaje(My.Application.Info.ProductName, My.Resources.Application.TituloErrorAplicativo, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                    End Try
                End If
            End If

            ActualizarEstadoInicioCierre()

        End Sub

        Private Sub mitemCuentasPro_Click(sender As Object, e As System.EventArgs) Handles mitemCuentasPro.Click
            AddForm(New frmCuenta(Data.Entity.DatosBancario.TIPO_PROPIETARIO_PROVEEDOR), True)
        End Sub

        Private Sub mitemImpresionEtiqueta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitemImpresionEtiqueta.Click
            AddForm(New frmEtiquetarProducto(Nothing), True)
        End Sub

        Private Sub mbtniemProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mbtnitemProducto.Click
            AddForm(New frmProducto(), True)
        End Sub

        Private Sub btnPedido_Click(sender As System.Object, e As System.EventArgs) Handles sbtnPedido.Click

        End Sub

        Private Sub mitemTarjetas_Click(sender As System.Object, e As System.EventArgs) Handles mitemTarjetas.Click
            AddForm(New frmClienteTarjeta(), True)
        End Sub

        Private Sub mitemVales_Click(sender As System.Object, e As System.EventArgs) Handles mitemVales.Click

        End Sub

        Private Sub mitemCerrar_Click(sender As Object, e As System.EventArgs) Handles mitemCerrar.Click
            If Not CajaCerrado Then CierreCaja()
        End Sub

        Private Sub mitemIniciar_Click(sender As Object, e As System.EventArgs) Handles mitemIniciar.Click
            If CajaCerrado Then AperturaCaja()
        End Sub

        Private Sub ActualizarEstadoInicioCierre()
            mitemCerrar.Enabled = Not CajaCerrado
            mitemIniciar.Enabled = CajaCerrado
        End Sub

        Private Sub dokPrincipal_DockWindowAdded(sender As Object, e As DockWindowEventArgs) Handles dokPrincipal.DockWindowAdded
            Dim form As RadForm

            If e.DockWindow.Controls.Count > 0 Then
                form = TryCast(e.DockWindow.Controls(0), RadForm)
                If Not IsNothing(form) Then e.DockWindow.TabStripItem.Image = New Bitmap(form.Icon.ToBitmap(), New Size(16, 16))

            End If

        End Sub
    End Class

End Namespace

