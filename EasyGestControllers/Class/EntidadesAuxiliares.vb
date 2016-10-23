
Namespace Data.Entity
    Public Class EntidadesAuxiliar

    End Class

    <Serializable()>
    Public Class ListaCompraTemporal
        Private _idProveedor As Long?
        Private _fechaPedido As Date
        Private _lineasPedido As List(Of Data.Entity.LineasPedido)

        Public Property IdProveedor() As Long?
            Get
                Return _idProveedor
            End Get
            Set(ByVal value As Long?)
                _idProveedor = value
            End Set
        End Property

        Public Property FechaPedido() As Date
            Get
                Return _fechaPedido
            End Get
            Set(ByVal value As Date)
                _fechaPedido = value
            End Set
        End Property

        Public Property LineasPedido() As List(Of Data.Entity.LineasPedido)
            Get
                Return _lineasPedido
            End Get
            Set(ByVal value As List(Of Data.Entity.LineasPedido))
                _lineasPedido = value
            End Set
        End Property
    End Class

    <Serializable()>
    Public Class ListaVentaTemporal
        Private _idCliente As Long?
        Private _lineasAlbaran As List(Of Data.Entity.LineasAlbaran)

        Public Property IdCliente() As Long?
            Get
                Return _idCliente
            End Get
            Set(ByVal value As Long?)
                _idCliente = value
            End Set
        End Property

        Public Property LineasAlbaran() As List(Of Data.Entity.LineasAlbaran)
            Get
                Return _lineasAlbaran
            End Get
            Set(ByVal value As List(Of Data.Entity.LineasAlbaran))
                _lineasAlbaran = value
            End Set
        End Property
    End Class

    <Serializable()>
    Public Class InfoExportacion

        Private _fexportacion As DateTime
        Private _numregistrocli, _numregistroprod, _numregistroprov As Integer
        Private _datoscli, _datosprod, _datosprov As IList

        Public Property FExportacion() As DateTime
            Get
                Return _fexportacion
            End Get
            Set(ByVal value As DateTime)
                _fexportacion = value
            End Set
        End Property

        Public Property NumRegistroCli() As Integer
            Get
                Return _numregistrocli
            End Get
            Set(ByVal value As Integer)
                _numregistrocli = value
            End Set
        End Property

        Public Property NumRegistroProd() As Integer
            Get
                Return _numregistroprod
            End Get
            Set(ByVal value As Integer)
                _numregistroprod = value
            End Set
        End Property

        Public Property NumRegistroProv() As Integer
            Get
                Return _numregistroprov
            End Get
            Set(ByVal value As Integer)
                _numregistroprov = value
            End Set
        End Property

        Public Property DatosClientes() As List(Of Data.Entity.Clientes)
            Get
                Return CType(_datoscli, Global.System.Collections.Generic.List(Of Global.EasyGestControllers.Data.Entity.Clientes))
            End Get
            Set(ByVal value As List(Of Data.Entity.Clientes))
                _datoscli = value
            End Set
        End Property

        Public Property DatosProductos() As List(Of Data.Entity.Productos)
            Get
                Return CType(_datosprod, Global.System.Collections.Generic.List(Of Global.EasyGestControllers.Data.Entity.Productos))
            End Get
            Set(ByVal value As List(Of Data.Entity.Productos))
                _datosprod = value
            End Set
        End Property

        Public Property DatosProveedores() As List(Of Data.Entity.Proveedores)
            Get
                Return CType(_datosprov, Global.System.Collections.Generic.List(Of Global.EasyGestControllers.Data.Entity.Proveedores))
            End Get
            Set(ByVal value As List(Of Data.Entity.Proveedores))
                _datosprov = value
            End Set
        End Property

    End Class

    Public Class Etiquetas

        Public Property idEtiqueta As Long
        Public Property NombreEtiqueta As String
        Public Property TipoEtiqueta As Char = "R"
        Public ReadOnly Property UniqueIdEtiqueta As String
            Get
                Return TipoEtiqueta & idEtiqueta
            End Get
        End Property
        Public ReadOnly Property IconTipo As Image
            Get
                If TipoEtiqueta = TIPO_ETIQUETA_ENHOJA Then
                    Return My.Resources.page
                End If
                If TipoEtiqueta = TIPO_ETIQUETA_ENROLLO Then
                    Return My.Resources.script
                End If
                Return Nothing
            End Get
        End Property

        Public Const TIPO_ETIQUETA_ENROLLO As Char = "R"c
        Public Const TIPO_ETIQUETA_ENHOJA As Char = "H"c

        Public Sub New(id As Long, nombre As String, tipo As Char)
            idEtiqueta = id
            NombreEtiqueta = nombre
            TipoEtiqueta = tipo
        End Sub

    End Class

End Namespace
