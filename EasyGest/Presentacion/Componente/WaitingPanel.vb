Imports System.ComponentModel

Namespace Presentacion.Componente

    Public Class WaitingPanel

        'Private _panelcontenedor As RadPanel

        <Browsable(True), Description("Mensaje a mostrar"), Localizable(True)> _
        Public Property Caption() As String
            Get
                Return lblTitulo.Text
            End Get
            Set(ByVal value As String)
                lblTitulo.Text = value
            End Set
        End Property

        Public Sub Mostrar()
            Mostrar(Nothing)
        End Sub

        Private Sub CambiarTamaño()
            'Me.Width = Me.Parent.Width
            'Me.Height = Me.Parent.Height
            Me.Left = CInt(Me.Parent.Width / 2 - Me.Width / 2)
            Me.Top = CInt(Me.Parent.Height / 2 - Me.Height / 2)
        End Sub

        Public Sub Mostrar(ByVal titulo As String)
            Me.Parent.Cursor = Cursors.WaitCursor
            If Not IsNothing(titulo) Then _
            Me.Caption = titulo
            CambiarTamaño()
            CambioEstado(True)
            AddHandler Me.Parent.SizeChanged, AddressOf Parent_SizeChanged
            Me.Visible = True
            My.Application.DoEvents()
        End Sub

        Public Sub Ocultar()
            RemoveHandler Me.Parent.SizeChanged, AddressOf Parent_SizeChanged
            'RemoveHandler Me.ParentForm.SizeChanged, AddressOf Parent_SizeChanged
            Me.Parent.Cursor = Cursors.Default
            CambioEstado(False)
            Me.Visible = False
        End Sub

        Private Sub CambioEstado(ByVal mostrado As Boolean)
        ' solo actuamos sobre los objetos del raiz, menos el nuestro

            For Each aux As Control In Me.Parent.Controls
                If Not TypeOf (aux) Is WaitingPanel Then
                    aux.Enabled = Not mostrado
                End If
            Next

        End Sub

        Public Sub New()

            ' Llamada necesaria para el Dise馻dor de Windows Forms.
            InitializeComponent()

            ' Agregue cualquier inicializaci髇 despu閟 de la llamada a InitializeComponent().
            
        End Sub

        Private Sub Parent_SizeChanged(sender As Object, e As System.EventArgs)
            CambiarTamaño()
        End Sub

        Private Sub WaitingPanel_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            CambiarTamaño()
        End Sub
    End Class

End Namespace
