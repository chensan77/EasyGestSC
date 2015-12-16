Imports System.ComponentModel

<Serializable()> _
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

