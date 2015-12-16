Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports EasyGestControllers.Data.Entity
Imports EasyGestControllers.Data.Context


Namespace Controller

    Public Class EasyGestController

        Private Shared _tablesPrimaryKeys As Dictionary(Of String, List(Of String)) = EasyGestDataContext.GetTablesPrimaryKeys()

        Public Shared Function GetPrimaryKeys(entityType As Type) As List(Of String)
            Dim keys As List(Of String) = New List(Of String)()
            If _tablesPrimaryKeys.TryGetValue(entityType.Name, keys) Then
                Return keys
            Else
                Return New List(Of String)
            End If
        End Function

        Public Shared Function DataAccesible() As Boolean
            Dim result As Boolean
            Try
                result = EasyGestDataContext.DataBaseAccesible()
            Catch ex As Exception
                result = False
            End Try
            Return result
        End Function

    End Class

    Public Class AlbaranesController
        Inherits BaseController(Of Albaranes, EasyGestDataContext)


        Public Overloads Function AddItem(ByVal item As Data.Entity.Albaranes, ByVal facturar As Boolean) As Data.Entity.Albaranes
            If item Is Nothing Then
                Throw New ArgumentNullException()
            End If

            'item.NumAlbaran = SiguienteNumAlbaran(item.SerieAlbaran)
            'If facturar Then
            '    item.NumFactura = SiguienteNumFactura()
            '    item.FFactura = item.FAlbaran
            'End If            

            Return MyBase.AddItem(item)
        End Function

        Public Sub FacturarAlbaran(ByVal idAlbaran As Long, ByVal idCliente As Long)
            Dim albaran As Data.Entity.Albaranes
            albaran = GetItem(idAlbaran)
            'If albaran.NumFactura Is Nothing Then
            '    albaran.FFactura = Now()
            '    albaran.idCliente = idCliente
            '    albaran.NumFactura = SiguienteNumFactura()
            'End If
            UpdateItem(albaran)
        End Sub

        Public Sub ResumenVentaXPuestoUsuario(empresa As Empresas, puesto As Puestos, usuario As Usuarios, fechaInicio As DateTime, ByRef numero As Integer?, ByRef total As Double?)
            Me.Contexto.SPResumenVentaXPuestoUsuario(empresa.idEmpresa, puesto.idPuesto, CType(IIf(usuario.IsSuper, Nothing, usuario.idUsuario), Long?), fechaInicio, numero, total)
        End Sub

    End Class

    Public Class ApuntesDiarioController
        Inherits BaseController(Of ApuntesDiario, EasyGestDataContext)

        Public Function GetApuntesByDiario(idDiario As Long) As IEnumerable(Of ApuntesDiario)
            Dim query As IQueryable(Of ApuntesDiario)
            query = From a As ApuntesDiario In Contexto.ApuntesDiario Where a.idDiario = idDiario Order By a.FApunte
            Return query.AsEnumerable().ToList()
        End Function

        Function CalcularCierreVenta(idDiario As Long) As Single
            Dim apuntes As List(Of ApuntesDiario)
            Dim venta As Single
            apuntes = GetApuntesByDiario(idDiario)
            venta = apuntes.Sum(Function(c As ApuntesDiario) c.Importe)
            apuntes = Nothing
            Return venta
        End Function

    End Class

    Public Class CaracteristicasProductoController
        Inherits BaseController(Of CaracteristicasProducto, EasyGestDataContext)

        Public Overloads Shared Function NewItem(ByVal idProducto As Long) As Data.Entity.CaracteristicasProducto
            Return New Data.Entity.CaracteristicasProducto(idProducto)
        End Function

        Public Function GetCaracteristicasByProducto(ByVal idProducto As Long) As IEnumerable(Of Data.Entity.CaracteristicasProducto)
            Dim query As IQueryable(Of CaracteristicasProducto)
            query = From c As CaracteristicasProducto In Contexto.CaracteristicasProducto Where c.idProducto = idProducto Select c Order By c.Caracteristica
            Return query.AsEnumerable().ToList()
        End Function

        Public Sub SetCaracteristicasOfProducto(ByVal idProducto As Long, ByVal caracteristicas As IEnumerable(Of CaracteristicasProducto))
            Dim oldcaracteristicas As IEnumerable(Of CaracteristicasProducto)
            If IsNothing(caracteristicas) Then Return

            oldcaracteristicas = From c As CaracteristicasProducto In Contexto.CaracteristicasProducto Where c.idProducto = idProducto Select c
            Contexto.CaracteristicasProducto.DeleteAllOnSubmit(oldcaracteristicas)
            Contexto.SubmitChanges()
            Contexto.CaracteristicasProducto.InsertAllOnSubmit(caracteristicas)
            Contexto.SubmitChanges()
        End Sub
    End Class

    Public Class ClientesController
        Inherits BaseController(Of Clientes, EasyGestDataContext)

        Public Overrides Function DeleteItem(id As Object) As Data.Entity.Clientes
            Dim cliente As Clientes
            cliente = GetItem(id)
            Try
                cliente = MyBase.DeleteItem(id)
            Catch ex As Exception
                cliente = GetItem(id)
                If Not IsNothing(cliente) Then
                    cliente.Activo = False
                    cliente = UpdateItem(cliente)
                End If
            End Try

            Return cliente
        End Function

    End Class

    'Public Class CobrosController
    '    Inherits BaseController(Of Cobros, EasyGestDataContext)

    '    Public Function GetCobrosForDiario(Of T As Class)(ByVal idPuesto As Long, ByVal apertura As DateTime) As IEnumerable(Of T)
    '        Dim filtro As String
    '        filtro = String.Format("idPuesto = {0} AND idModo = {1} AND FCobro.CompareTo(DateTime({2})) >= 0", idPuesto, CInt(ModoPagoEnum.Metalico), apertura.Ticks)
    '        Return MyBase.GetItems(Of T)(filtro, "FechaCobro")
    '    End Function

    '    Public Function GetCobrosByDiario(ByVal diario As Data.Entity.Diarios) As IEnumerable(Of Cobros)
    '        Dim lista As IEnumerable(Of Cobros)
    '        lista = From p In Contexto.Cobros Where (p.idPuesto Is Nothing Or p.idPuesto.Equals(diario.idPuesto)) And p.FCobro.CompareTo(diario.Apertura) >= 0 And p.FCobro.CompareTo(diario.Cierre) <= 0 Select p
    '        Return lista.ToList()
    '    End Function

    'End Class

    Public Class CodigosBarraController
        Inherits BaseController(Of CodigosBarra, EasyGestDataContext)

        Public Overloads Shared Function NewItem(ByVal idProducto As Long) As Data.Entity.CodigosBarra
            Return New Data.Entity.CodigosBarra(idProducto)
        End Function

        Public Function GetCodigosBarraByProducto(ByVal idProducto As Long) As IEnumerable(Of Data.Entity.CodigosBarra)
            Dim query As IQueryable(Of CodigosBarra)
            query = From c As CodigosBarra In Contexto.CodigosBarra Where c.idProducto = idProducto Select c Order By c.CodigoBarra
            Return query.AsEnumerable().ToList()
        End Function

        Public Sub SetCodigosBarraOfProducto(ByVal idProducto As Long, ByVal codigos As IEnumerable(Of CodigosBarra))
            Dim oldcodigos As IEnumerable(Of CodigosBarra)
            If IsNothing(codigos) Then Return

            For Each c In codigos
                c.idProducto = idProducto
            Next

            oldcodigos = From c As CodigosBarra In Contexto.CodigosBarra Where c.idProducto = idProducto Select c
            Contexto.CodigosBarra.DeleteAllOnSubmit(oldcodigos)
            Contexto.SubmitChanges()
            Contexto.CodigosBarra.InsertAllOnSubmit(codigos)
            Contexto.SubmitChanges()
        End Sub
    End Class

    Public Class ConfiguracionesController
        Inherits BaseController(Of Configuraciones, EasyGestDataContext)

        Public Overloads Function UpdateItem(ByVal parametro As String, ByVal valor As String, ByVal idPuesto As Nullable(Of Long)) As Data.Entity.Configuraciones
            Dim param As New Configuraciones()
            Dim params As IEnumerable(Of Configuraciones)
            param.Parametro = parametro
            param.Valor = valor
            param.idPuesto = idPuesto
            params = From p In Contexto.Configuraciones Where p.Parametro.Equals(parametro) Select p
            If params.Count = 0 Then
                Contexto.Configuraciones.InsertOnSubmit(param)
            Else
                params.First().Valor = valor
            End If
            Contexto.SubmitChanges()
            Return param
        End Function

        Public Overrides Function AddItem(item As Data.Entity.Configuraciones) As Data.Entity.Configuraciones
            Return item
        End Function

        Public Overrides Sub AddItems(items As System.Collections.Generic.IEnumerable(Of Data.Entity.Configuraciones))
            'Nothing to do
        End Sub

        Public Overrides Function DeleteItem(id As Object) As Data.Entity.Configuraciones
            Return Nothing
        End Function

        Public Overrides Function DeleteItem(ids As Object()) As Data.Entity.Configuraciones
            Return Nothing
        End Function

        Public Overrides Sub DeleteItems(items As System.Collections.Generic.IEnumerable(Of Data.Entity.Configuraciones))
            'Nothing to do
        End Sub

        Public Overrides Function UpdateItem(item As Data.Entity.Configuraciones) As Data.Entity.Configuraciones
            Return UpdateItem(item.Parametro, item.Valor, item.idPuesto)
        End Function

    End Class

    Public Class ContactosController
        Inherits BaseController(Of Contactos, EasyGestDataContext)

        ''si propietarioid es 0 se filtra todos los contactos de cliente o proveedor
        'Public Function GetItemsByPropietario(ByVal propietarioID As Long, tipo As Char) As System.Collections.Generic.IEnumerable(Of Data.Entity.Contactos)
        '    Return MyBase.GetItems(String.Format("TipoPropietario = '{0}' AND (idPropietario = {1} OR {2})", tipo, propietarioID, IIf(propietarioID = 0, "1 = 1", "1 <> 1")))
        'End Function

    End Class


    Public Class DatosBancarioController
        Inherits BaseController(Of DatosBancario, EasyGestDataContext)


    End Class

    Public Class DiariosController
        Inherits BaseController(Of Diarios, EasyGestDataContext)

        Public Function GetUltimoDiario(idPuesto As Long, idUsuario As Long?) As Diarios
            Try
                Return (From i In MyBase.Contexto.Diarios Where i.Cierre Is Nothing And i.idPuesto = idPuesto And idUsuario.Equals(idUsuario) Order By i.Apertura Descending).First
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function GetRecaudacion(ByVal idPuesto As Long, idUsuario As Long?, ByVal apertura As Date) As Nullable(Of Single)
            Dim listaCobro As IEnumerable(Of Single) = Nothing
            Dim listaPago As IEnumerable(Of Single) = Nothing
            Dim importeCobro, importePago As Single
            'Using control As New CobrosController
            '    listaCobro = control.GetCobrosForDiario(Of Cobros)(idPuesto, apertura).Select(Function(c) c.Importe)
            'End Using
            'Using control As New PagosController
            '    listaPago = control.GetItemsForDiario(Of Pagos)(idPuesto, apertura).Select(Function(p) p.Importe)
            'End Using

            importeCobro = listaCobro.Sum()
            importePago = listaPago.Sum()
            Return importeCobro - importePago
        End Function

    End Class

    Public Class DiseñosEtiquetaController
        Inherits BaseController(Of DiseñosEtiqueta, EasyGestDataContext)


    End Class

    Public Class EmpresasController
        Inherits BaseController(Of Empresas, EasyGestDataContext)

        Sub SetActivo(idEmpresa As Long)
            Dim emps As IEnumerable(Of Empresas)
            emps = From e As Empresas In Contexto.Empresas Select e
            For Each e In emps
                e.Activo = e.idEmpresa.Equals(idEmpresa)
            Next
            Contexto.SubmitChanges()
        End Sub


    End Class

    Public Class EncargosController
        Inherits BaseController(Of Encargos, EasyGestDataContext)

        Public Overloads Function UpdateItem(encargo As Encargos, ByRef lista As ListasCompra) As Encargos
            Dim encargoNuevo As Encargos
            encargoNuevo = MyBase.UpdateItem(encargo)
            Using c As New ListasCompraController()
                lista = c.GetItems("idEncargo = @0", encargoNuevo.idEncargo).FirstOrDefault
                If IsNothing(lista) Then
                    lista = ListasCompraController.NewItem()
                    CopiarAListaCompra(lista, encargoNuevo)
                    lista = c.AddItem(lista)
                Else
                    CopiarAListaCompra(lista, encargoNuevo)
                    lista = c.UpdateItem(lista)
                End If
            End Using
            Return encargoNuevo
        End Function

        Public Overloads Function AddItem(encargo As Encargos, ByRef lista As ListasCompra) As Encargos
            Dim encargoNuevo As Encargos
            encargoNuevo = MyBase.AddItem(encargo)
            Using c As New ListasCompraController()
                lista = ListasCompraController.NewItem()
                CopiarAListaCompra(lista, encargoNuevo)
                c.AddItem(lista)
            End Using
            Return encargoNuevo
        End Function

        Private Sub CopiarAListaCompra(ByRef lista As ListasCompra, encargo As Encargos)
            lista.Descripcion = encargo.Descripcion
            lista.Referencia = encargo.Referencia
            lista.Observacion = String.Format("Cantidad: {0}. Cliente: {1} ({2}). Obs: {3}", encargo.Cantidad, encargo.Cliente, encargo.Telefono, encargo.Observacion)
            lista.idEncargo = encargo.idEncargo
        End Sub
    End Class


    Public Class EtiquetasController
        Inherits BaseController(Of Etiquetas, EasyGestDataContext)


    End Class

    Public Class FamiliasController
        Inherits BaseController(Of Familias, EasyGestDataContext)


    End Class

    Public Class FormasContactoController
        Inherits BaseController(Of FormasContacto, EasyGestDataContext)

        Public Sub New()
            MyBase.New(True)
        End Sub

    End Class

    Public Class GaleriasController
        Inherits BaseController(Of Galerias, EasyGestDataContext)

        Public Function GetItemsByProducto(ByVal productoID As Long) As IEnumerable(Of Galerias)
            Return MyBase.GetItems("idProducto = @0", productoID)
        End Function

    End Class

    Public Class ImpuestosController
        Inherits BaseController(Of Impuestos, EasyGestDataContext)

        Public Sub New()
            MyBase.New()
        End Sub

        Function GetImpuestoPorDefecto() As Impuestos
            'Obtiene el tipo de impuesto que esta marcado como por defecto, si no hay, obtiene la primera. 
            Dim imp As Impuestos = Nothing
            Try
                Dim imps = From i In Contexto.Impuestos Where i.PorDefecto = True
                If imps.Count() = 0 Then
                    imps = From i In Contexto.Impuestos Take 1
                    If imps.Count() > 0 Then
                        imp = imps.First()
                    End If
                Else
                    imp = imps.First()
                End If
            Catch ex As Exception
                imp = Nothing
            End Try

            Return imp
        End Function

    End Class

    Public Class LineasAlbaranController
        Inherits BaseController(Of LineasAlbaran, EasyGestDataContext)

        Public Function GetItemsByAlbaran(ByVal albaranID As Long) As IEnumerable(Of LineasAlbaran)
            Return MyBase.GetItems("idAlbaran = @0", albaranID)
        End Function

    End Class

    Public Class LineasPedidoController
        Inherits BaseController(Of LineasPedido, EasyGestDataContext)

        Public Function GetItemsByPedido(ByVal pedidoID As Long) As IEnumerable(Of LineasPedido)
            Return MyBase.GetItems("idPedido = @0", pedidoID)
        End Function

    End Class

    Public Class ListasCompraController
        Inherits BaseController(Of ListasCompra, EasyGestDataContext)


    End Class

    Public Class MarcasController
        Inherits BaseController(Of Marcas, EasyGestDataContext)


    End Class

    Public Class ModosPagoController
        Inherits BaseController(Of ModosPago, EasyGestDataContext)

       Public Sub New()
            MyBase.New(True)
        End Sub

    End Class

    Public Class MorosidadesController
        Inherits BaseController(Of Morosidades, EasyGestDataContext)

    End Class

    Public Class MovimientosMorosidadController
        Inherits BaseController(Of MovimientosMorosidad, EasyGestDataContext)

    End Class

    Public Class MovimientosTarjetaController
        Inherits BaseController(Of MovimientosTarjeta, EasyGestDataContext)


    End Class

    Public Class MunicipiosEspañolasController
        Inherits BaseController(Of MunicipiosEspañolas, EasyGestDataContext)

        Public Sub New()
            MyBase.New(True)
        End Sub

        Public Function GetItemsByCodProvincia(ByVal codProvincia As String) As IEnumerable(Of MunicipiosEspañolas)
            Return GetItems(String.Format("CodProvincia = ""{0}""", codProvincia), "Municipio")
        End Function

        Public Function GetItemsByNombreProvincia(ByVal nombreProvincia As String) As IEnumerable(Of MunicipiosEspañolas)
            Dim mun As IEnumerable(Of MunicipiosEspañolas)
            mun = From m In Contexto.MunicipiosEspañolas Join p In Contexto.ProvinciasEspañolas On m.CodProvincia Equals p.CodProvincia Where p.Provincia.Equals(nombreProvincia) Select m Order By m.Municipio
            Return mun
        End Function

    End Class

    Public Class OfertasController
        Inherits BaseController(Of Ofertas, EasyGestDataContext)


    End Class

    'Public Class PagosController
    '    Inherits BaseController(Of Pagos, EasyGestDataContext)

    '    Public Function GetItemsForDiario(Of T As Class)(ByVal idPuesto As Long, ByVal apertura As DateTime) As IEnumerable(Of T)
    '        Dim filtro As String
    '        filtro = String.Format("idPuesto = {0} AND idModo = {1} AND FPago.CompareTo(DateTime({2})) >= 0", idPuesto, CInt(ModoPagoEnum.Metalico), apertura.Ticks)
    '        Return MyBase.GetItems(Of T)(filtro, "FechaPago")
    '    End Function

    '    Public Function GetItemsByDiario(ByVal diario As Data.Entity.Diarios) As IEnumerable(Of Pagos)
    '        Dim lista As IEnumerable(Of Pagos)
    '        lista = From p In Contexto.Pagos Where (p.idPuesto Is Nothing Or p.idPuesto.Equals(diario.idPuesto)) And p.FPago.CompareTo(diario.Apertura) >= 0 And p.FPago.CompareTo(diario.Cierre) <= 0 Select p
    '        Return lista.ToList()
    '    End Function

    'End Class

    Public Class PedidosController
        Inherits BaseController(Of Pedidos, EasyGestDataContext)

        Public Function GetInformeCompra(ByVal fechaini As Date, ByVal periodo As Integer, ByVal nombre As String) As IEnumerable(Of Data.Entity.SPInformeCompraResult)
            Return Contexto.SPInformeCompra(fechaini, periodo, nombre).ToList()
        End Function

    End Class

    Public Class PrioridadesTareaController
        Inherits BaseController(Of PrioridadesTarea, EasyGestDataContext)

        Public Sub New()
            MyBase.New(True)
        End Sub

    End Class

    Public Class ProductosController
        Inherits BaseController(Of Productos, EasyGestDataContext)

        Public Overrides Function DeleteItem(ByVal id As Object) As Data.Entity.Productos
            Dim producto As Productos
            producto = GetItem(id)
            Try
                producto = MyBase.DeleteItem(id)
            Catch ex As Exception
                producto = GetItem(id)
                If Not IsNothing(producto) Then
                    producto.Activo = False
                    producto = UpdateItem(producto)
                End If
            End Try

            Return producto
        End Function

        Public Overrides Function UpdateItem(item As Data.Entity.Productos) As Data.Entity.Productos
            item.FModificacion = Now()
            Return MyBase.UpdateItem(item)
        End Function

        Public Function AsignarFamilia(ByVal idProducto As Long, ByVal idfamilia As Long?) As VWProductos
            Dim producto As Productos = GetItem(idProducto)
            producto = (From p In Contexto.Productos Where p.idProducto = idProducto Select p).First
            producto.idFamilia = idfamilia
            Contexto.SubmitChanges()
            Return (From p In Contexto.VWProductos Where p.idProducto = idProducto Select p).First
        End Function

        Public Function AsignarOferta(ByVal idProducto As Long, idoferta As Long?) As VWProductos
            Dim producto As Productos = GetItem(idProducto)
            producto = (From p In Contexto.Productos Where p.idProducto = idProducto Select p).First
            producto.idOferta = idoferta
            Contexto.SubmitChanges()
            Return (From p In Contexto.VWProductos Where p.idProducto = idProducto Select p).First
        End Function

    End Class

    Public Class ProveedoresController
        Inherits BaseController(Of Proveedores, EasyGestDataContext)

        Public Overrides Function DeleteItem(id As Object) As Data.Entity.Proveedores
            Dim proveedor As Proveedores
            proveedor = GetItem(id)
            Try
                proveedor = MyBase.DeleteItem(id)
            Catch ex As Exception
                proveedor = GetItem(id)
                If Not IsNothing(proveedor) Then
                    proveedor.Activo = False
                    proveedor = UpdateItem(proveedor)
                End If
            End Try

            Return proveedor
        End Function

    End Class

    Public Class ProvinciasEspañolasController
        Inherits BaseController(Of ProvinciasEspañolas, EasyGestDataContext)

        Public Sub New()
            MyBase.New(True)
        End Sub

    End Class

    Public Class PuestosController
        Inherits BaseController(Of Puestos, EasyGestDataContext)


    End Class

    Public Class TareasController
        Inherits BaseController(Of Tareas, EasyGestDataContext)

        Public Function GetTareasRecientes(periodo As Integer, usu As Usuarios) As IEnumerable(Of VWTareas)

            Dim idusu As Long? = Nothing
            If Not usu.IsSuper Then idusu = usu.idUsuario
            Return Contexto.SPTareasRecientes(periodo, idusu).ToList()

        End Function

    End Class

    Public Class TarjetasFidelizacionController
        Inherits BaseController(Of TarjetasFidelizacion, EasyGestDataContext)

        Public Sub ActualizarCondicionTarjeta(base As Single, beneficio As Single, basepunto As Single, equivalenciapunto As Single, todo As Boolean)
            Contexto.SPActualizarCondicionTarjetaFidelizacion(base, beneficio, basepunto, equivalenciapunto, todo)
        End Sub

        Sub ActualizarSaldoTarjeta(idTarjeta As Long, saldo As Single, descripcion As String)
            Dim tarjeta As TarjetasFidelizacion = GetItem(idTarjeta)
            If Not IsNothing(tarjeta) Then
                tarjeta.Saldo += saldo
                UpdateItem(tarjeta)
                Using control As New MovimientosTarjetaController()
                    Dim newMovimiento As MovimientosTarjeta = MovimientosTarjetaController.NewItem()
                    newMovimiento.Saldo = saldo
                    newMovimiento.idTarjeta = idTarjeta                    
                    newMovimiento.Descripcion = descripcion                    
                    control.AddItem(newMovimiento)
                End Using
            End If
        End Sub

    End Class

    Public Class TiposIdentificacionController
        Inherits BaseController(Of TiposIdentificacion, EasyGestDataContext)

        Public Sub New()
            MyBase.New(True)
        End Sub

    End Class

    Public Class TiposDatoCaractProductoController
        Inherits BaseController(Of TiposDatoCaractProducto, EasyGestDataContext)

        Public Sub New()
            MyBase.New(True)
        End Sub

    End Class

    Public Class UbicacionesController
        Inherits BaseController(Of Ubicaciones, EasyGestDataContext)


    End Class

    Public Class UnidadesMedidaController
        Inherits BaseController(Of UnidadesMedida, EasyGestDataContext)


    End Class

    Public Class UsuariosController

        Inherits BaseController(Of Usuarios, EasyGestDataContext)

        Public Function GetUsuarioSuper() As Usuarios
            Dim super As Usuarios = Nothing

            super = GetItem(EasyGestDataContext.IDUSUARIOSUPER)
            If IsNothing(super) Then
                super = CrearSuperUsuario()
                AddItem(super)
            Else
                If Not super.IsSuper Then
                    super = CrearSuperUsuario()
                    super = UpdateItem(super)
                End If
            End If
            Return super
        End Function
 
        Private Function CrearSuperUsuario() As Usuarios
            Dim super As Usuarios = NewItem()
            super.idUsuario = EasyGestDataContext.IDUSUARIOSUPER
            super.Nombre = "Super"
            super.NombreSesion = "Super"
            super.InformesAccesibles = "ALL"
            super.PermisoCliente = 15
            super.PermisoCompra = 15
            super.PermisoConfiguracion = 2
            super.PermisoProducto = 15
            super.PermisoProveedor = 15
            super.PermisoVenta = 15
            super.TamañoGrid = 0
            super.FCreacion = Today()
            super.Contraseña = String.Empty
            super.Apariencia = "ControlDefault"
            Return super
        End Function

        Function Autentificar(ByVal nombre As String, ByVal contraseña As String) As Usuarios
            Dim usuario As Usuarios = Nothing
            Try
                usuario = (From u As Usuarios In Contexto.Usuarios Where (u.NombreSesion.Equals(nombre) Or u.Nombre.Equals(nombre)) And u.Contraseña.Equals(contraseña) Select u).First
            Catch ex As Exception
                usuario = Nothing
            End Try
            Return usuario
        End Function

    End Class

    Public Class ValesController
        Inherits BaseController(Of Vales, EasyGestDataContext)

        Public Function GetItemByNumero(ByVal numero As String) As Data.Entity.Vales
            Dim vale As Data.Entity.Vales = Nothing
            Try
                vale = MyBase.GetItems("Numero.Equals(""" & numero & """)").First()
            Catch ex As Exception
                vale = Nothing
            End Try
            Return vale
        End Function

        Public Sub CancelarVale(ByVal numero As String)
            Dim vale As Data.Entity.Vales = Nothing
            vale = GetItemByNumero(numero)
            If vale IsNot Nothing AndAlso vale.Activo Then
                vale.Activo = False
                vale.FCancelacion = Now()
                MyBase.UpdateItem(vale)
            End If
        End Sub

        Public Sub CancelarVale(ByVal idVale As Long)
            Dim vale As Data.Entity.Vales = Nothing
            vale = MyBase.GetItem(idVale)
            If vale IsNot Nothing AndAlso vale.Activo Then
                vale.Activo = False
                vale.FCancelacion = Now()
                MyBase.UpdateItem(vale)
            End If
        End Sub

        'Public Overrides Function AddItem(item As Data.Entity.Vales) As Data.Entity.Vales
        '    item.Numero = GenerarNumeracion(item)
        '    Return MyBase.AddItem(item)
        'End Function

        'Public Overrides Sub AddItems(items As System.Collections.Generic.IEnumerable(Of Data.Entity.Vales))
        '    For Each i As Vales In items

        '    Next


        '    MyBase.AddItems(items)
        'End Sub
    End Class

    Public Class VistasController(Of VEntity As Class)
        Inherits BaseController(Of VEntity, EasyGestDataContext)

        Public Overrides Function AddItem(item As VEntity) As VEntity
            Return item
        End Function

        Public Overrides Sub AddItems(items As System.Collections.Generic.IEnumerable(Of VEntity))
            'Nothing to do
        End Sub

        Public Overrides Function DeleteItem(id As Object) As VEntity
            'Nothing to do
            Return Nothing
        End Function

        Public Overrides Function DeleteItem(keys() As Object) As VEntity
            'Nothing to do
            Return Nothing
        End Function

        Public Overrides Sub DeleteItems(items As System.Collections.Generic.IEnumerable(Of VEntity))
            'Nothing to do
        End Sub

        Public Overrides Function UpdateItem(item As VEntity) As VEntity
            'Nothing to do
            Return item
        End Function
    End Class

End Namespace

