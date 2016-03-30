Imports EasyGest.Presentacion.Formulario.Dialogo
Imports EasyGestControllers.Controller
Imports EasyGestControllers.Data

Namespace Presentacion.Formulario

    Public Class frmBienvenida

        Private Delegate Sub SetTextoEstadoCallback(ByVal [text] As String)

        Private Sub frmBienvenida_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            lblVersion.Text = String.Format(lblVersion.Text, My.Application.Info.Version.ToString(3))
        End Sub

        Private Sub frmBienvenida_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
            bgwInicio.RunWorkerAsync()
        End Sub

        Private Sub SetTextoEstado(ByVal [text] As String)
            If Me.lblAccion.InvokeRequired Then
                Dim d As New SetTextoEstadoCallback(AddressOf SetTextoEstado)
                Me.Invoke(d, New Object() {[text]})
            Else
                lblAccion.Text = [text]
            End If
        End Sub

        Private Sub bgwInicio_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwInicio.DoWork

            'obtener dato conexion
            SetTextoEstado(My.Resources.Application.InfoAccionProbarConexion)
            If gMostrarConfiguracionConexion OrElse String.IsNullOrWhiteSpace(gConfLocal.DbServidor) OrElse String.IsNullOrWhiteSpace(gConfLocal.DbCatalogo) OrElse
            String.IsNullOrWhiteSpace(gConfLocal.DbUsuario) OrElse String.IsNullOrWhiteSpace(gConfLocal.DbContrasña) Then
                e.Result = 1
                Exit Sub
            Else
                Dim cs As String = GenerarCadenaConexion(gConfLocal.DbServidor, gConfLocal.DbCatalogo, gConfLocal.DbUsuario, gConfLocal.DbContrasña, gConfLocal.DbAuxiliar)
                If Not EasyGestController.DataAccesible(cs) Then
                    e.Result = 1
                    Exit Sub
                Else
                    EasyGestController.ResetConnectionString(cs)
                End If
            End If

            SetTextoEstado(My.Resources.Application.InfoAccionPrepararPrincipal)
            'Cargar Empresa activo, En caso de no disponer ninguna se mostrará formulario para crear
            If gMostrarSelectorEmpresas Then
                e.Result = 2
                Exit Sub
            Else
                Using control As New EmpresasController
                    Dim empresas As IEnumerable(Of Entity.Empresas) = control.GetItems("Activo = True")
                    If empresas.Count > 0 Then
                        gEmpresa = empresas.First()
                    Else
                        e.Result = 2
                        Exit Sub
                    End If
                End Using
            End If
            'Cargar Configuracion y prepara para lanzar formulario principal
            Dim listaConf As List(Of Configuraciones)
            gEmpresa.Configuraciones.Load()
            listaConf = gEmpresa.Configuraciones.AsQueryable().ToList()
            gConfGlobal = EasyGestControllers.Data.Configuracion.ConfiguracionGlobal.CargarConfiguracion(listaConf)
            'Using c As New ConfiguracionesController()
            'End Using

            Dim mac As String = Nothing, ip As String = Nothing
            EasyGestControllers.Util.Comunes.GetInformacionRed(mac, ip)
            If Not gConfLocal.PuestoID.HasValue() Then gConfLocal.PuestoID = -1
            Dim puestos As IEnumerable(Of Entity.Puestos)
            Using c As New PuestosController()
                puestos = c.GetItems("Identificacion = """ & mac & """ OR idPuesto = " & gConfLocal.PuestoID.Value)
            End Using
            If puestos.Count() = 0 Then
                Dim puesto As Entity.Puestos
                puesto = New Entity.Puestos
                puesto.Puesto = My.Computer.Name
                puesto.Identificacion = mac
                Using c As New PuestosController()
                    gPuesto = c.AddItem(puesto)
                End Using
            Else
                gPuesto = puestos.First()
            End If
            gConfLocal.PuestoID = gPuesto.idPuesto
            Impresion.TareaImpresion.EstablecerImpresora(gConfLocal.ImpresoraTicket)

            Using control As New ImpuestosController()
                gImpuestoPorDefecto = control.GetImpuestoPorDefecto()
            End Using

        End Sub

        Private Sub bgwInicio_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwInicio.RunWorkerCompleted
            If Not IsNothing(e.Error) Then
                MostrarMensaje(e.Error, Telerik.WinControls.RadMessageIcon.Error, MessageBoxButtons.OK, True)
            Else
                If CInt(e.Result) = 1 Then
                    Dim frm As New frmBDConexion()
                    frm.Servidor = gConfLocal.DbServidor
                    frm.Catalogo = gConfLocal.DbCatalogo
                    frm.Usuario = gConfLocal.DbUsuario
                    frm.Contraseña = gConfLocal.DbContrasña
                    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        If gMostrarConfiguracionConexion Then gMostrarConfiguracionConexion = False
                        gConfLocal.DbServidor = frm.Servidor
                        gConfLocal.DbCatalogo = frm.Catalogo
                        gConfLocal.DbUsuario = frm.Usuario
                        gConfLocal.DbContrasña = frm.Contraseña
                        EasyGestControllers.Data.Configuracion.ConfiguracionLocal.EscribirConfiguracion(gConfLocal)
                        bgwInicio.RunWorkerAsync()
                    Else
                        Me.Close()
                    End If
                ElseIf CInt(e.Result) = 2 Then
                    Dim frm As New Configuracion.frmEmpresa(True)
                    frm.ShowDialog()
                    If gMostrarSelectorEmpresas Then gMostrarSelectorEmpresas = False
                    bgwInicio.RunWorkerAsync()

                Else
                    If gConfGlobal.Autentificar Then
                        SetTextoEstado(My.Resources.Application.InfoAccionEsperarAutentificacion)
                        Dim frm As New frmAutentificacion()
                        If frm.ShowDialog(Me) = DialogResult.OK Then
                            gUsuario = frm.Usuario
                        Else
                            Me.Close()
                            Exit sub
                        End If
                    Else
                        Using c As New UsuariosController()
                            gUsuario = c.GetUsuarioSuper()
                        End Using
                    End If
                    Using c As New UsuariosController()
                        gUsuario.PuestoEnSesion = gPuesto.Puesto
                        c.UpdateItem(gUsuario)
                    End Using
                    ConfigurarIdioma(gUsuario.IdiomaPreferente)

                    Dim imagePrimitive As New Telerik.WinControls.Primitives.ImagePrimitive()
                    imagePrimitive.StretchHorizontally = True
                    imagePrimitive.StretchVertically = True
                    imagePrimitive.ImageLayout = ImageLayout.Stretch
                    imagePrimitive.Image = Me.BackgroundImage
                    My.Forms.frmPrincipal.doccPrincipal.SplitPanelElement.Children.Add(imagePrimitive)

                    'Posible que no se ha cerrado la caja, para continuar con la session anterior
                    If gConfLocal.DiarioID.HasValue() Then
                        Dim diario As Diarios = Nothing
                        Using control As New DiariosController()
                            diario = control.GetItem(gConfLocal.DiarioID.Value)
                        End Using
                        If Not IsNothing(diario) Then
                            If Not diario.Cerrado AndAlso diario.idPuesto = gPuesto.idPuesto AndAlso ((gUsuario.IsSuper And Not diario.idUsuario.HasValue()) Or (Not gUsuario.IsSuper And (diario.idUsuario.HasValue() AndAlso diario.idUsuario.Value = gUsuario.idUsuario))) Then
                                diario.Clone(gDiario)
                            End If
                        End If
                    End If
                    My.Forms.frmPrincipal.Show()
                    Me.Close()
                End If
            End If
        End Sub

        Public Sub New()

            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
            Try
                gConfLocal = EasyGestControllers.Data.Configuracion.ConfiguracionLocal.LeerConfiguracion()

                Dim rnd As New Random()
                Dim num As Integer = rnd.Next()
                Select Case num Mod 8
                    Case 0
                        Me.BackgroundImage = My.Resources.Fondo1
                    Case 1
                        Me.BackgroundImage = My.Resources.Fondo2
                    Case 2
                        Me.BackgroundImage = My.Resources.Fondo3
                    Case 3
                        Me.BackgroundImage = My.Resources.Fondo4
                    Case 4
                        Me.BackgroundImage = My.Resources.Fondo5
                    Case 5
                        Me.BackgroundImage = My.Resources.Fondo6
                    Case 6
                        Me.BackgroundImage = My.Resources.Fondo7
                    Case Else
                        Me.BackgroundImage = My.Resources.Fondo8
                End Select

            Catch ex As Exception

            End Try
        End Sub
    End Class

End Namespace
