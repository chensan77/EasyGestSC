<Serializable()> _
Public Class InfoVentaTemporal
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

