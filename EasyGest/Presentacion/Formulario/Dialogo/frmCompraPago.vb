
Namespace Presentacion.Formulario.Dialogo

    Public Class frmCompraPago

        Private _total As Single = 0.0
        Private _entregado As Single()
        Private _devolucion As Single = 0.0
        Private _txtEntregados As New List(Of RadMaskedEditBox)()

        Public Sub New()

            ' Esta llamada es exigida por el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        End Sub

        Protected Friend ReadOnly Property Debido() As Boolean
            Get
                Return _devolucion < 0
            End Get
        End Property

        Protected Friend ReadOnly Property Diferencia() As Single
            Get
                Return _devolucion
            End Get
        End Property

        Protected Friend ReadOnly Property Entregado As Single
            Get
                Return _entregado.Sum()
            End Get
        End Property

        Protected Friend ReadOnly Property MediosPagos As List(Of Single)
            Get
                Return _entregado.ToList()
            End Get
        End Property

        Protected Friend ReadOnly Property PagadoPorCaja As Boolean
            Get
                Return chkPagadoCaja.Checked
            End Get
        End Property

        Protected Friend Property Imprimir As Boolean?
            Get
                Return toggleImprimir.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
            End Get
            Set(ByVal value As Boolean?)
                If value.HasValue Then
                    toggleImprimir.ToggleState = DirectCast(IIf(value.Value, Telerik.WinControls.Enumerations.ToggleState.On, Telerik.WinControls.Enumerations.ToggleState.Off), Telerik.WinControls.Enumerations.ToggleState)
                Else
                    toggleImprimir.ToggleState = DirectCast(IIf(gConfGlobal.ImprimirSiempreVenta, Telerik.WinControls.Enumerations.ToggleState.On, Telerik.WinControls.Enumerations.ToggleState.Off), Telerik.WinControls.Enumerations.ToggleState)
                End If
            End Set
        End Property

        Protected Friend WriteOnly Property Total As Single
            Set(value As Single)
                _total = value
            End Set
        End Property

        Protected Overrides Sub OnKeyUp(e As KeyEventArgs)
            If e.KeyCode = Keys.Enter Then
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
            End If
            MyBase.OnKeyUp(e)
        End Sub

        Private Sub frmVentaCobro_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            'centrar panel
            Dim x, y As Integer
            x = CInt(Math.Round(Me.Width / 2 - pnlContenido.Width / 2))
            y = CInt(Math.Round(Me.Height / 2 - pnlContenido.Height / 2))
            pnlContenido.Location = New Point(x, y)
        End Sub

        Private Sub frm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        End Sub

        Private Sub frmVentaCobro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            PrepararControles(pnlContenido.Controls)
            btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
            toggleImprimir.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.I))


            _txtEntregados.Add(txtMetalico)
            _txtEntregados.Add(txtTransferencia)
            _txtEntregados.Add(txtCheque)
            _txtEntregados.Add(txtTarjeta)
            _txtEntregados.Add(txtOtro)
            _entregado = New Single(4) {_total, 0.0, 0.0, 0.0, 0.0}
            For i As Integer = 0 To _entregado.Length - 1
                _txtEntregados(i).Value = _entregado(i)
                AddHandler _txtEntregados(i).ValueChanged, AddressOf txtEntregado_ValueChanged
            Next
            toggleImprimir.ToggleState = DirectCast(IIf(gConfGlobal.ImprimirSiempreVenta, Telerik.WinControls.Enumerations.ToggleState.On, Telerik.WinControls.Enumerations.ToggleState.Off), Telerik.WinControls.Enumerations.ToggleState)
            txtTotalVenta.Text = FormatCurrency(_total, 2)
            txtDevolucion.Text = FormatCurrency(0.0, 2)
            txtMetalico.Focus()
        End Sub


        Private Sub lstvVales_CellFormatting(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.ListViewCellFormattingEventArgs)
            e.CellElement.Font = gDefaultFont
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End Sub

        Private Sub txtEntregado_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim txt As RadMaskedEditBox = DirectCast(sender, RadMaskedEditBox)
            Dim index As Integer = _txtEntregados.IndexOf(txt)
            _entregado(index) = CSng(txt.Value)
            RefrescarDiferencia()
        End Sub

        Private Sub RefrescarDiferencia()
            _devolucion = Entregado - _total
            txtDevolucion.Text = FormatCurrency(_devolucion, 2)
        End Sub

        Private Sub txtDevolucion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDevolucion.TextChanged
            txtDevolucion.TextBoxElement.ForeColor = DirectCast(IIf(Debido, Color.Red, Color.Green), Color)
        End Sub

        Private Sub lstvVales_ItemRemoved(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewItemEventArgs)
            RefrescarDiferencia()
        End Sub

    End Class
End Namespace