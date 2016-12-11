Imports System.Data.Linq.Mapping

Namespace Data

    Public MustInherit Class BaseDataContext
        Inherits System.Data.Linq.DataContext

        Protected Friend Shared gCadenaConexion As String
        Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource

        Public Sub New()
            MyBase.New(gCadenaConexion, mappingSource)
        End Sub

        Public Sub New(ByVal connectionstring As String, ByVal mapping As System.Data.Linq.Mapping.MappingSource)
            MyBase.New(connectionstring, mapping)
        End Sub

        Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mapping As System.Data.Linq.Mapping.MappingSource)
            MyBase.New(connection, mapping)
        End Sub

        Public Sub New(ByVal connection As IDbConnection)
            MyBase.New(connection, mappingSource)
        End Sub

    End Class
End Namespace

