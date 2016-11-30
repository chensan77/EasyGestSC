Imports EasyGestControllers.Controller
Imports EasyGestControllers.Data

Namespace Presentacion.Formulario.Cliente

    Public Class frmClienteTarjetaEmision

        Private _valePunto, _valeSaldo As Entity.Vales
        Private _tarjetasPunto, _tarjetasSaldo As IEnumerable(Of VWTarjetasFidelizacion)
        Private _maximoPunto, _maximoSaldo As Single

        Private Sub frmClienteTarjetaEmicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Try
                PrepararControles(Me.Controls)

                If _maximoSaldo > 0 Then
                    _valeSaldo = ValesController.NewItem()
                    _valeSaldo.idCliente = _tarjetasSaldo.First.idCliente
                    _valeSaldo.ObtenidoXFidelizacion = True
                    _valeSaldo.EsPunto = False
                    _valeSaldo.FComienzo = Today()
                    txtSaldo.Select()
                End If
                If _maximoPunto > 0 Then
                    _valePunto = ValesController.NewItem()
                    _valePunto.idCliente = _tarjetasPunto.First.idCliente
                    _valePunto.ObtenidoXFidelizacion = True
                    _valePunto.EsPunto = True
                    _valePunto.FComienzo = Today()
                    txtPunto.Select()
                End If
                gboxPuntos.Enabled = _maximoPunto > 0
                gboxSaldos.Enabled = _maximoSaldo > 0
                txtPuntoActual.Text = _maximoPunto.ToString()
                txtSaldoActual.Text = _maximoSaldo.ToString()
                txtPunto.Value = _maximoPunto
                txtSaldo.Value = _maximoSaldo
                btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
                btnAceptar.Enabled = False
                timValidar.Enabled = _maximoPunto > 0 Or _maximoSaldo > 0
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                btnAceptar.Enabled = False
            End Try
        End Sub

        Private Sub New()

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        End Sub

        Public Sub New(id As Long, deCliente As Boolean)

            Me.New()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

            Dim tarjetasAux As IEnumerable(Of VWTarjetasFidelizacion)

            Using ctrl As New VistasController(Of VWTarjetasFidelizacion)
                If deCliente Then
                    tarjetasAux = ctrl.GetItemsBy("idCliente", New Long() {id})
                Else
                    tarjetasAux = ctrl.GetItems("idTarjeta = " & id)
                    txtNumeroTarjeta.Text = tarjetasAux.First.NumeroTarjeta
                End If
                txtPropietario.Text = tarjetasAux.First.Cliente
            End Using

            _tarjetasSaldo = tarjetasAux.Where(Function(c As VWTarjetasFidelizacion) c.Activo = True And c.EnSaldo = True).OrderByDescending(Function(c As VWTarjetasFidelizacion) c.Saldo)
            _tarjetasPunto = tarjetasAux.Where(Function(c As VWTarjetasFidelizacion) c.Activo = True And c.EnSaldo = False).OrderByDescending(Function(c As VWTarjetasFidelizacion) c.Saldo)
            _maximoSaldo = _tarjetasSaldo.Sum(Function(c As VWTarjetasFidelizacion) c.Saldo)
            _maximoPunto = _tarjetasPunto.Sum(Function(c As VWTarjetasFidelizacion) c.Saldo)

        End Sub

        Protected Friend ReadOnly Property Vales() As List(Of Entity.VWVales)
            Get
                Dim val As List(Of Entity.VWVales) = New List(Of Entity.VWVales)()
                Dim listaIds As New List(Of Long)()
                If Not IsNothing(_valePunto) Then
                    listaIds.Add(_valePunto.idVale)
                End If
                If Not IsNothing(_valeSaldo) Then
                    listaIds.Add(_valeSaldo.idVale)
                End If
                If Not listaIds.Count > 0 Then
                    Using control As New VistasController(Of Entity.VWVales)
                        val = control.GetItemsBy("idVale", listaIds.ToArray()).ToList()
                    End Using
                End If
                Return val
            End Get
        End Property

        Protected Friend ReadOnly Property Tarjetas As List(Of VWTarjetasFidelizacion)
            Get
                Dim tarj As New List(Of VWTarjetasFidelizacion)()
                Dim listaIds As New List(Of Long)()
                If Not IsNothing(_tarjetasPunto) Then
                    listaIds.AddRange(From c In _tarjetasPunto Select c.idTarjeta)
                End If
                If Not IsNothing(_tarjetasSaldo) Then
                    listaIds.AddRange(From c In _tarjetasSaldo Select c.idTarjeta)
                End If
                If listaIds.Count > 0 Then
                    Using control As New VistasController(Of VWTarjetasFidelizacion)
                        tarj = control.GetItemsBy("idTarjeta", listaIds.ToArray()).ToList()
                    End Using
                End If
                Return tarj
            End Get
        End Property

        Private Sub timValidar_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timValidar.Tick
            btnAceptar.Enabled = (Not gboxPuntos.Enabled Or (CSng(txtPunto.Value) > 0.0F And CSng(txtPunto.Value) <= _maximoPunto)) And (Not gboxSaldos.Enabled Or (CSng(txtSaldo.Value) > 0.0F And CSng(txtSaldo.Value) <= _maximoSaldo))
        End Sub

        Private Sub CancelarForm()
            'Me.DialogResult = Windows.Forms.DialogResult.Cancel
            timValidar.Enabled = False
            _valeSaldo = Nothing
            _valePunto = Nothing
            _tarjetasSaldo = Nothing
            _tarjetasPunto = Nothing
        End Sub

        Private Sub AceptarForm()
            timValidar.Enabled = False
            'Insertar vales
            Using control As New ValesController
                If Not IsNothing(_valePunto) Then
                    _valePunto.FComienzo = dtpFInicio.Value
                    _valePunto.FValidez = CDate(IIf(spinValidezBeneficio.Value = 0D, Nothing, _valePunto.FComienzo.Value.AddDays(spinValidezBeneficio.Value * 7)))
                    _valePunto.Importe = CSng(txtPunto.Value)
                    control.SyncronisingItem(_valePunto)
                End If
                If Not IsNothing(_valeSaldo) Then
                    _valeSaldo.FComienzo = dtpFInicio.Value
                    _valeSaldo.FValidez = CDate(IIf(spinValidezBeneficio.Value = 0, Nothing, _valeSaldo.FComienzo.Value.AddDays(spinValidezBeneficio.Value * 7)))
                    _valeSaldo.Importe = CSng(txtSaldo.Value)
                    control.SyncronisingItem(_valeSaldo)
                End If
            End Using

            'Actualizar la tarjeta y movimiento.
            RestarSaldoTarjetas(CSng(txtSaldo.Value), _tarjetasSaldo)
            RestarSaldoTarjetas(CSng(txtPunto.Value), _tarjetasPunto)
        End Sub

        Private Sub RestarSaldoTarjetas(totalEmision As Single, tarjetas As IEnumerable(Of VWTarjetasFidelizacion))
            Using control As New TarjetasFidelizacionController
                Dim descripcion As String = String.Format(My.Resources.Application.DescripcionMovTarjEmisionManual, gUsuario.Nombre)
                Dim saldo, resto As Single
                If tarjetas.Count > 0 And totalEmision > 0 Then
                    saldo = totalEmision
                    resto = 0
                    For Each t As VWTarjetasFidelizacion In tarjetas
                        resto = saldo - t.Saldo
                        If t.Saldo > 0 Then
                            If resto >= 0 Then
                                control.ActualizarSaldoTarjeta(t.idTarjeta, -1 * t.Saldo, descripcion)
                            Else
                                control.ActualizarSaldoTarjeta(t.idTarjeta, -1 * saldo, descripcion)
                            End If
                        End If
                        saldo = resto
                        If resto <= 0 Then Exit For
                    Next
                End If
            End Using
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            AceptarForm()
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            CancelarForm()
        End Sub

    End Class

End Namespace
