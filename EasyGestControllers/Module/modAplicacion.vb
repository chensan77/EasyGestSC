Public Module ModAplicacion

    Public gCadenaConexion As String = ""
    Public gConfLocal As New EasyGestControllers.Data.Configuracion.ConfiguracionLocal()
    Public gConfGlobal As New EasyGestControllers.Data.Configuracion.ConfiguracionGlobal()
    Public gPuesto As EasyGestControllers.Data.Entity.Puestos = Nothing
    Public gEmpresa As EasyGestControllers.Data.Entity.Empresas = Nothing
    Public gDiario As EasyGestControllers.Data.Entity.Diarios = Nothing
    Public gUsuario As EasyGestControllers.Data.Entity.Usuarios = Nothing

    Public Const SQLERRORNUMBER_DUPLICATEINDEX As Integer = 2601
    Public Const SQLERRORNUMBER_FKCONFLICTONDELETE As Integer = 547

End Module
