Namespace Presentacion.Formulario.Dialogo

    Public Class frmCierre

        Private _diario As Diarios
        Private monedas() As Decimal = New Decimal() {0.01D, 0.02D, 0.05D, 0.1D, 0.2D, 0.5D, 1D, 2D, 5D, 10D, 20D, 50D, 100D, 200D}
        Private spineditors(13) As RadSpinEditor

        Protected Friend ReadOnly Property Diario As Diarios
            Get
                Return _diario
            End Get
        End Property

        Private Sub frmCierre_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            'centrar panel
            Dim x, y As Integer
            x = CInt(Math.Round(Me.Width / 2 - pnlContenedor.Width / 2))
            y = CInt(Math.Round(Me.Height / 2 - pnlContenedor.Height / 2))
            pnlContenedor.Location = New Point(x, y)
        End Sub

        Private Sub frmCierre_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            If Me.DialogResult = DialogResult.OK Then
                Try                    
                    Using control As New DiariosController
                        control.SyncronisingItem(_diario)
                    End Using

                Catch ex As Exception
                    e.Cancel = True
                    MostrarMensaje(Me.Text, My.Resources.Application.ErrorActualizarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                End Try
            End If
        End Sub

        Private Sub frmCierre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Try
                PrepararTextBoxConteo()
                PrepararControles(Me.Controls)
                Using control As New ApuntesDiarioController
                    ApuntesDiarioBindingSource.DataSource = control.GetApuntesByDiario(_diario.idDiario)
                End Using
                txtPuesto.Text = gPuesto.Puesto
                txtUsuario.Text = gUsuario.Nombre
                BindingSourceDiario.DataSource = _diario
                btnAceptar.ButtonElement.Shortcuts.Add(New Telerik.WinControls.RadShortcut(Keys.Control, Keys.Enter))
            Catch ex As Exception
                MostrarMensaje(Me.Text, My.Resources.Application.ErrorCargarDatos, ex, Telerik.WinControls.RadMessageIcon.Exclamation)
                btnAceptar.Enabled = False
            End Try
        End Sub

        Private Sub gridDatos_RowFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RowFormattingEventArgs) Handles gridDatos.RowFormatting
            If Not TypeOf e.RowElement Is GridFilterRowElement And Not TypeOf e.RowElement Is GridTableHeaderRowElement Then
                Dim emp As ApuntesDiario = DirectCast(e.RowElement.Data.DataBoundItem, ApuntesDiario)
                If emp.EsEntrada Then
                    e.RowElement.ForeColor = Color.Green
                Else
                    e.RowElement.ForeColor = Color.DarkRed
                End If
            End If
        End Sub

        Public Sub New()

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            If IsNothing(gDiario) Then Throw New NoNullAllowedException()
            gDiario.ShallowCopy(_diario)
            _diario.Cierre = Now()
            Using control As New ApuntesDiarioController()
                _diario.CierreSupuesto = control.CalcularCierreVenta(_diario.idDiario)
            End Using
            _diario.CierreReal = _diario.CierreSupuesto

        End Sub

        Private Function NuevoSpinTextBox() As RadSpinEditor
            Dim RadSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
            RadSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
            'CType(RadSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
            RadSpinEditor1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            RadSpinEditor1.ShowUpDownButtons = True
            RadSpinEditor1.Maximum = 1000D
            RadSpinEditor1.Margin = New Padding(3)
            RadSpinEditor1.Padding = New Padding(0)
            RadSpinEditor1.TabStop = False
            RadSpinEditor1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
            CType(RadSpinEditor1.GetChildAt(0), Telerik.WinControls.UI.RadSpinElement).ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(104, Byte), Integer))
            RadSpinEditor1.Anchor = AnchorStyles.None
            RadSpinEditor1.Value = 0
            Return RadSpinEditor1
        End Function

        Private Sub PrepararTextBoxConteo()
            tlpConteo.SuspendLayout()
            For i As Integer = 0 To 1
                For j As Integer = 0 To 6
                    Dim editor As RadSpinEditor = NuevoSpinTextBox()
                    spineditors(i * 7 + j) = editor
                    editor.BeginInit()
                    tlpConteo.Controls.Add(editor, i * 2 + 1, j)
                    editor.EndInit()
                Next
            Next
            tlpConteo.ResumeLayout(True)
        End Sub

        Private Sub btnContarCaja_Click(sender As System.Object, e As System.EventArgs) Handles btnContarCaja.Click
            Dim total As Decimal = 0D
            For i As Integer = 0 To spineditors.Length - 1
                total += spineditors(i).Value * monedas(i)
            Next
            spinConteoCaja.Value = total
        End Sub

        Private Sub toggleVerConteo_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles toggleVerConteo.ToggleStateChanged
            pnlConteo.Visible = toggleVerConteo.ToggleState = Enumerations.ToggleState.On
            If pnlConteo.Visible Then pnlConteo.BringToFront()
        End Sub

        Private Sub toggleVerApuntes_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles toggleVerApuntes.ToggleStateChanged
            pnlApuntes.Visible = toggleVerApuntes.ToggleState = Enumerations.ToggleState.On
            If pnlApuntes.Visible Then pnlApuntes.BringToFront()

        End Sub

        Private Sub btnLimpiar_Click(sender As Object, e As System.EventArgs) Handles btnLimpiar.Click
            For i As Integer = 0 To spineditors.Length - 1
                spineditors(i).Value = 0D
            Next
        End Sub
    End Class
End Namespace