Imports System.Data.Linq.Mapping

Namespace Data

    Public MustInherit Class BaseDataContext
        Inherits System.Data.Linq.DataContext

        Public Shared CadenaConexion As String
        Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource

        Shared Sub New()

        End Sub

        Public Sub New()
            MyBase.New(CadenaConexion, mappingSource)
        End Sub

        Public Sub New(ByVal connectionstring As String, ByVal mapping As System.Data.Linq.Mapping.MappingSource)
            MyBase.New(CadenaConexion, mapping)
        End Sub

        Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mapping As System.Data.Linq.Mapping.MappingSource)
            MyBase.New(connection, mapping)
        End Sub

        Public Sub New(ByVal connection As IDbConnection)
            MyBase.New(connection, mappingSource)
        End Sub

    End Class
End Namespace

