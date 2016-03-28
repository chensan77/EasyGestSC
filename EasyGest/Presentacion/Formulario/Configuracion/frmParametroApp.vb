
Namespace Presentacion.Formulario.Configuracion

    Public Class frmParametroApp

        Private _condicionTarjetaModificado As Boolean = False

        Private Sub frmParametroApp_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            If DialogResult = Windows.Forms.DialogResult.OK Then
                Try

                    With gConfLocal
                        .DbAuxiliar = txtConexionAuxialiar.Text
                        .SecuenciaAperturaCajon = txtSecuenciaApertura.Text
                        .ImpresoraTicket = ddlImpresoraTicket.Text
                        .ImpresoraXDefecto = ddlImpresoraXDefecto.Text
                        .MomentoAperturaCajon = CType(ddlMomentoApertura.SelectedIndex, EasyGestControllers.Data.Configuracion.MomentoAperturaCajonEnum)
                        .UsarCajon = chkUsarCajon.Checked
                        .AtajoAperturaCajon = ""
                        .AtajoAperturaCajon &= CStr(IIf(chkAtajoAlt.Checked, chkAtajoAlt.Text, ""))
                        .AtajoAperturaCajon &= CStr(IIf(chkAtajoCtrl.Checked, chkAtajoCtrl.Text, ""))
                        .AtajoAperturaCajon &= CStr(IIf(chkAtajoShift.Checked, chkAtajoShift.Text, ""))
                        .AtajoAperturaCajon &= "+" & ddlTeclado.Text
                        .NumRegXPagina = CInt(spinNumeroRegistro.Value)
                        .DepositoCaja = CSng(spinDepositoInicial.Value)
                        .ImpresoraTicketNumCaracteres = CInt(spinNumCaracteres.Value)
                        .MostrarInicioArranque = chkMostrarInicio.Checked
                        .PeriodoActualizacionInicio = CShort(spinPeriodoActInicio.Value)
                        .UsarCuchilloCorteImpresora = chkUsarCuchilloCorte.Checked
                    End With

                    EasyGestControllers.Data.Configuracion.ConfiguracionLocal.EscribirConfiguracion(gConfLocal)
                    Impresion.TareaImpresion.EstablecerImpresora(gConfLocal.ImpresoraTicket)

                    Dim dialogresult As DialogResult = Windows.Forms.DialogResult.None
                    With gConfGlobal
                        If .UsarTarjetaFidelizacion Then
                            If _condicionTarjetaModificado Then
                                dialogresult = MostrarMensaje(My.Resources.Application.ConfirmacionActualizarCondicionTarjeta, Me.Text, RadMessageIcon.Question, MessageBoxButtons.YesNoCancel)
                                If dialogresult <> Windows.Forms.DialogResult.Cancel Then
                                    .BuidFormulaFidelizacion(CSng(txtBaseEuro.Value), CSng(txtEquivalenteEuroBeneficio.Value), CSng(txtBasePunto.Value), CSng(txtEquivalenciaPuntoEuro.Value))
                                End If
                            End If
                        End If
                        .ClaveAdministrador = txtContraseñaAdmin.Text
                        .AvisarPrecioCero = chkAvisarSiCero.Checked
                        .ControlCaja = chkControlCaja.Checked
                        .ControlStock = chkControlStock.Checked
                        .UsarDecimalCantidad = chkDecimalEnCantidad.Checked
                        .FidelizacionModoGlobal = chkFormulaComun.Checked
                        .UsarImpuestoCompra = chkIgualarImpuesto.Checked
                        .ImpuestoIncluidoPrecioVenta = chkImpuestoIncluido.Checked
                        .RecargoIncluidoPrecioVenta = chkRecargoIncluido.Checked
                        .Autentificar = chkIniciarAutentificando.Checked
                        .PermitirCrearProducto = chkPermitirCrearProducto.Checked
                        .FacturarSiempreVenta = chkSiempreFacturar.Checked
                        .ImprimirSiempreVenta = chkSiempreImprimir.Checked
                        .UsarTarjetaFidelizacion = chkUsarTarjeta.Checked
                        .PermitirGastoFidelizacionParcial = chkUsoParcial.Checked
                        .DocumentoVenta = DirectCast(ddlDocumentoVenta.SelectedIndex, EasyGestControllers.Data.Configuracion.TipoDocumentoVentaEnum)
                        .NombreImpuesto = ddlNombreImpuesto.Text
                        .ModoFidelizacion = DirectCast(ddlTipoBeneficio.SelectedIndex, EasyGestControllers.Data.Configuracion.TipoFidelizacionEnum)
                        .CuantiaMinimoEmisionValeFidelizacion = spinCantidadMinEmision.Value
                        .PeriodoEmisionValeFidelizacion = CShort(spinPeriodoEmision.Value)
                        .PorcentajeGanancia = spinPorcGanancia.Value
                        .ValidezBeneficioFidelizacion = CInt(spinValidezBeneficio.Value)
                        .IndiceCorrectorVenta = spinPorcVenta.Value
                        .ValidezAlbaran = CShort(spinValidezAlbaran.Value)
                        .ValidezVale = CShort(spinValidezVales.Value)
                    End With

                    Dim listaparam As List(Of Configuraciones) = EasyGestControllers.Data.Configuracion.ConfiguracionGlobal.DescargarConfiguracion(gConfGlobal, gEmpresa.idEmpresa)
                    Using c As New ConfiguracionesController()
                        For Each param As Configuraciones In listaparam
                            c.UpdateItem(param)
                        Next
                    End Using
                    If dialogresult = Windows.Forms.DialogResult.Yes Or dialogresult = Windows.Forms.DialogResult.No Then
                        Using c As New TarjetasFidelizacionController
                            c.ActualizarCondicionTarjeta(CSng(txtBaseEuro.Value), CSng(txtEquivalenteEuroBeneficio.Value),
                                                         CSng(txtBasePunto.Value), CSng(txtEquivalenciaPuntoEuro.Value), dialogresult = Windows.Forms.DialogResult.Yes)
                        End Using
                    End If
                Catch ex As Exception
                    MostrarMensaje(ex, Me.Text, Telerik.WinControls.RadMessageIcon.Error, MessageBoxButtons.OK)
                    e.Cancel = True
                End Try

            End If
        End Sub

        Private Sub frmParametroApp_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            chkUsarCajon.Select()
        End Sub

        Private Sub frmParametroApp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            pvParametro.SelectedPage = pvpParametroLocal
            pvParametro.Pages.Remove(pvpParametroFidelizacion)
            For Each printer As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters
                ddlImpresoraTicket.Items.Add(printer)
                ddlImpresoraXDefecto.Items.Add(printer)
            Next
            txtBaseEuro.Culture = My.Application.Culture
            txtEquivalenteEuroBeneficio.Culture = My.Application.Culture
            txtBasePunto.Culture = My.Application.Culture
            txtEquivalenciaPuntoEuro.Culture = My.Application.Culture
            Dim base, beneficio, basepunto, equivalente As Single
            With gConfGlobal
                .InterpretarFormulaFidelizacion(base, beneficio, basepunto, equivalente)
                txtBaseEuro.Value = base
                txtEquivalenteEuroBeneficio.Value = beneficio
                txtBasePunto.Value = basepunto
                txtEquivalenciaPuntoEuro.Value = equivalente
                txtContraseñaAdmin.Text = .ClaveAdministrador
                chkAvisarSiCero.Checked = .AvisarPrecioCero
                chkControlCaja.Checked = .ControlCaja
                chkDecimalEnCantidad.Checked = .UsarDecimalCantidad
                chkFormulaComun.Checked = .FidelizacionModoGlobal
                chkIgualarImpuesto.Checked = .UsarImpuestoCompra
                chkImpuestoIncluido.Checked = .ImpuestoIncluidoPrecioVenta
                chkRecargoIncluido.Checked = .RecargoIncluidoPrecioVenta
                chkIniciarAutentificando.Checked = .Autentificar
                chkPermitirCrearProducto.Checked = .PermitirCrearProducto
                chkSiempreFacturar.Checked = .FacturarSiempreVenta
                chkSiempreImprimir.Checked = .ImprimirSiempreVenta
                chkUsarTarjeta.Checked = .UsarTarjetaFidelizacion
                chkUsoParcial.Checked = .PermitirGastoFidelizacionParcial
                chkControlStock.Checked = .ControlStock
                ddlDocumentoVenta.SelectedIndex = CInt(.DocumentoVenta)
                ddlNombreImpuesto.Text = .NombreImpuesto
                ddlTipoBeneficio.SelectedIndex = CInt(.ModoFidelizacion)
                spinCantidadMinEmision.Value = CDec(.CuantiaMinimoEmisionValeFidelizacion)
                spinPeriodoEmision.Value = .PeriodoEmisionValeFidelizacion
                spinValidezBeneficio.Value = .ValidezBeneficioFidelizacion
                spinPorcGanancia.Value = CDec(.PorcentajeGanancia)
                spinPorcVenta.Value = CDec(.IndiceCorrectorVenta)
                spinValidezAlbaran.Value = .ValidezAlbaran
                spinValidezVales.Value = .ValidezVale
            End With

            With gConfLocal
                txtConexionAuxialiar.Text = .DbAuxiliar
                txtSecuenciaApertura.Text = .SecuenciaAperturaCajon
                ddlImpresoraTicket.Text = .ImpresoraTicket
                ddlImpresoraXDefecto.Text = .ImpresoraXDefecto
                ddlMomentoApertura.SelectedIndex = CInt(.MomentoAperturaCajon)
                chkUsarCajon.Checked = .UsarCajon
                chkAtajoAlt.Checked = .AtajoAperturaCajon.Contains(chkAtajoAlt.Text)
                chkAtajoCtrl.Checked = .AtajoAperturaCajon.Contains(chkAtajoCtrl.Text)
                chkAtajoShift.Checked = .AtajoAperturaCajon.Contains(chkAtajoShift.Text)
                Try
                    ddlTeclado.Text = .AtajoAperturaCajon.Split("+"c)(1)
                Catch ex As Exception

                End Try
                spinNumeroRegistro.Value = .NumRegXPagina
                spinDepositoInicial.Value = CDec(.DepositoCaja)
                spinNumCaracteres.Value = .ImpresoraTicketNumCaracteres
                chkMostrarInicio.Checked = .MostrarInicioArranque
                chkUsarCuchilloCorte.Checked = .UsarCuchilloCorteImpresora
            End With

            _condicionTarjetaModificado = False
            btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))

        End Sub

        Private Sub chkUsarTarjeta_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkUsarTarjeta.ToggleStateChanged
            If chkUsarTarjeta.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On Then
                If Not pvParametro.Pages.Contains(pvpParametroFidelizacion) Then pvParametro.Pages.Add(pvpParametroFidelizacion)
            Else
                If pvParametro.Pages.Contains(pvpParametroFidelizacion) Then pvParametro.Pages.Remove(pvpParametroFidelizacion)
            End If
        End Sub

        Private Sub pvParametro_SelectedPageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pvParametro.SelectedPageChanged
            If pvParametro.SelectedPage Is pvpParametroFidelizacion Then
                ddlTipoBeneficio.Select()
            ElseIf pvParametro.SelectedPage Is pvpParametroGlobal Then
                chkControlCaja.Select()
            ElseIf pvParametro.SelectedPage Is pvpParametroLocal Then
                chkUsarCajon.Select()
            End If
        End Sub


        Private Sub txtFormulas_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEquivalenteEuroBeneficio.TextChanged, txtEquivalenciaPuntoEuro.TextChanged, txtBasePunto.TextChanged, txtBaseEuro.TextChanged
            _condicionTarjetaModificado = True
        End Sub

        Public Sub New()

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            PrepararControles(pvpParametroFidelizacion.Controls)
            PrepararControles(pvpParametroGlobal.Controls)
            PrepararControles(pvpParametroLocal.Controls)

        End Sub

        Private Sub chkMostrarInicio_CheckStateChanged(sender As Object, e As EventArgs) Handles chkMostrarInicio.CheckStateChanged
            spinPeriodoActInicio.ReadOnly = chkMostrarInicio.CheckState = CheckState.Unchecked
        End Sub
    End Class

End Namespace
