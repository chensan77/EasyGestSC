Namespace My

    ' Los siguientes eventos están disponibles para MyApplication:
    ' 
    ' Inicio: se desencadena cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: generado después de cerrar todos los formularios de la aplicación. Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: generado si la aplicación detecta una excepción no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.
    Partial Friend Class MyApplication

        Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            If Not e.IsNetworkAvailable() Then

            End If
        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As System.EventArgs) Handles Me.Shutdown
            Try
                If Not IsNothing(gConfLocal) Then
                    If Not CajaCerrado AndAlso Not gDiario.Cerrado Then gConfLocal.DiarioID = gDiario.idDiario
                    EasyGestControllers.Data.Configuracion.ConfiguracionLocal.EscribirConfiguracion(gConfLocal)
                End If
                If Not IsNothing(gUsuario) Then
                    Using c As New UsuariosController
                        Dim usu As Usuarios = c.GetItem(gUsuario.idUsuario)
                        usu.PuestoEnSesion = Nothing
                        c.SyncronisingItem(usu)
                    End Using
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub MyApplication_Startup(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Try
                Dim tempPath As String = IO.Path.Combine(My.Application.Info.DirectoryPath, My.Settings.DIRECTORIO_TEMP)
                If Not IO.Directory.Exists(tempPath) Then
                    gDirectorioTemp = IO.Directory.CreateDirectory(tempPath)
                Else
                    gDirectorioTemp = New IO.DirectoryInfo(tempPath)
                End If

                If e.CommandLine.Count > 0 Then
                    gMostrarConfiguracionConexion = e.CommandLine.Item(0).Equals("cc")
                    gMostrarSelectorEmpresas = e.CommandLine.Item(0).Equals("se")
                End If
                For Each il As InputLanguage In InputLanguage.InstalledInputLanguages
                    If il.Culture.Name.Contains("zh") Then _
                        gChineseInputLanguage = il
                Next
                ConfigurarIdioma(My.Settings.IDIOMA_XDEFECTO)
            Catch ex As Exception

            End Try
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            My.Application.Log.WriteException(e.Exception)
            e.ExitApplication = MostrarMensaje(My.Resources.Application.TituloErrorAplicativo, My.Resources.Application.ConfirmacionErrorNoControlado, e.Exception, RadMessageIcon.Question, MessageBoxButtons.YesNo, True) = DialogResult.Yes
        End Sub
    End Class


End Namespace

