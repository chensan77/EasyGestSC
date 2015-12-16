<Serializable()> _
Public Class InfoCompraTemporal
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
