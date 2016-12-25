Imports System.Reflection
Imports System.Data.Linq
Imports System.Data.Linq.Mapping


Namespace Controller

    Public MustInherit Class BaseController(Of TEntity As Data.Entity.LINQEntityBase, TContext As DataContext)
        Implements IDisposable

        Private _disposed As Boolean = False
        Private _context As TContext = Nothing
        Private _entityType As Type = GetType(TEntity)
        Private _primaryKeys As New Dictionary(Of String, PropertyInfo)

        Protected Sub New()
            _context = CType(Activator.CreateInstance(GetType(TContext), ""), TContext)
            _primaryKeys = Data.Entity.LINQEntityBase.GetLINQEntityPrimaryKeys(_entityType)
        End Sub


        Public Shared Function NewItem() As TEntity
            Dim Item As TEntity = DirectCast(Activator.CreateInstance(GetType(TEntity)), TEntity)
            Item.SetAsInsertOnSubmit()
            Return Item
        End Function

        Friend ReadOnly Property Contexto() As TContext
            Get
                Return _context
            End Get
        End Property

        Public Overridable Sub ResfreshItem(ByRef item As TEntity)
            Dim table As Table(Of TEntity) = _context.GetTable(Of TEntity)()
            table.Attach(item, True)
            _context.Refresh(RefreshMode.OverwriteCurrentValues, item)
        End Sub

        Public Overridable Sub SyncronisingItem(ByRef item As TEntity)
            If item Is Nothing Then Throw New NullReferenceException()
            Dim items As New List(Of TEntity)()
            items.Add(item)
            SyncronisingItem(items)
        End Sub

        Public Overridable Sub SyncronisingItem(ByRef items As IEnumerable(Of TEntity))
            If items Is Nothing Then Throw New NullReferenceException()

            'Before doing anything, check to make sure that the New datacontext
            'doesn 't try any deferred (lazy) loading
            'If _context.DeferredLoadingEnabled = True Then
            '    Throw New ApplicationException("Syncronisation requires that the Deferred loading is disabled on the Target DataContext")
            'End If
            For Each item As TEntity In items
                item.IsSyncronisingWithDB = True
            Next


            Try
                Dim table As Table(Of TEntity) = _context.GetTable(Of TEntity)()
                Dim insertItems As New List(Of TEntity)()
                Dim deleteItems As New List(Of TEntity)()
                For Each item As TEntity In items
                    If item.ReadOnly Then Throw New ApplicationException("Entity dosn´t to modifie")

                    If item.LINQEntityState = Data.Entity.EntityState.Original Then
                        table.Attach(item, False)
                    ElseIf item.LINQEntityState = Data.Entity.EntityState.[New] Then
                        insertItems.Add(item)
                    ElseIf item.LINQEntityState = EasyGestControllers.Data.Entity.EntityState.Modified OrElse item.LINQEntityState = EasyGestControllers.Data.Entity.EntityState.Detached Then
                        If item.LINQEntityOriginalValue IsNot Nothing Then
                            table.Attach(item, item.LINQEntityOriginalValue)
                        Else
                            table.Attach(item, True)
                        End If
                    ElseIf item.LINQEntityState = EasyGestControllers.Data.Entity.EntityState.Deleted Then
                        table.Attach(item)
                        deleteItems.Add(item)
                    End If
                    'item.SetAsChangeTrackingRoot()

                Next
                table.InsertAllOnSubmit(insertItems)
                table.DeleteAllOnSubmit(deleteItems)
                _context.SubmitChanges()

                ' Reset this entity as the change tracking root, getting a new copy of all objects

            Catch ex As ChangeConflictException
                For Each conflicto As ObjectChangeConflict In _context.ChangeConflicts
                    conflicto.Resolve(RefreshMode.KeepCurrentValues)
                Next
                _context.SubmitChanges(ConflictMode.FailOnFirstConflict)
            Catch ex1 As Exception
                Throw ex1
            Finally
                ' Tell each entity that syncronisation is occuring
                For Each item As TEntity In items
                    item.IsSyncronisingWithDB = False
                Next
            End Try
        End Sub

        Protected Overridable Sub AddItem(ByRef item As TEntity)
            If item Is Nothing Then Throw New NullReferenceException()
            If item.ReadOnly Then Throw New ReadOnlyException("Entidad no modificable")
            item.SetAsInsertOnSubmit()
            Me.SyncronisingItem(item)
        End Sub

        'Protected Overridable Sub AddItems(ByVal items As IEnumerable(Of TEntity))
        '    If _readonly Then Throw New ReadOnlyException("Entidad no modificable")
        '    If items Is Nothing Then Throw New NullReferenceException

        '    Dim table As Table(Of TEntity) = _context.GetTable(Of TEntity)()

        '    If table IsNot Nothing Then
        '        table.InsertAllOnSubmit(items)
        '        _context.SubmitChanges()
        '    Else
        '        Throw New ApplicationException("No hay un conjunto de entidad definido")
        '    End If
        'End Sub

        Public Overridable Sub UpdateItem(ByRef item As TEntity)
            If item Is Nothing Then Throw New NullReferenceException
            If item.ReadOnly Then Throw New ReadOnlyException("Entidad no modificable")
            'item.SetAsUpdateOnSubmit()
            SyncronisingItem(item)
        End Sub

        Public Overridable Function DeleteItem(ByVal id As Object) As TEntity
            Return DeleteItem(New Object() {id})
        End Function

        Public Overridable Function DeleteItem(ByVal keys As Object()) As TEntity
            Dim toDelete As TEntity = Nothing

            toDelete = GetItem(keys)
            If toDelete.ReadOnly Then Throw New ReadOnlyException("Entidad no modificable")

            If toDelete IsNot Nothing Then
                toDelete.SetAsDeleteOnSubmit()
                SyncronisingItem(toDelete)
            End If
            Return toDelete
        End Function

        'Public Overridable Sub DeleteItems(ByVal items As IEnumerable(Of TEntity))
        '    If _readonly Then Throw New ReadOnlyException("Entidad no modificable")
        '    If items Is Nothing Then Throw New NullReferenceException

        '    Dim toDelete As TEntity = Nothing
        '    Dim toDeletes As New List(Of TEntity)
        '    Dim valores As List(Of Object)
        '    For Each item In items
        '        valores = GetValuesOfPrimaryKey(item)
        '        toDelete = GetItem(valores.ToArray())

        '        If toDelete IsNot Nothing Then
        '            toDeletes.Add(toDelete)
        '        End If
        '    Next

        '    If toDeletes.Count > 0 Then
        '        Dim table As Table(Of TEntity) = _context.GetTable(Of TEntity)()

        '        If table IsNot Nothing Then
        '            table.DeleteAllOnSubmit(toDeletes)
        '            _context.SubmitChanges()
        '        Else
        '            Throw New ApplicationException("No hay un conjunto de entidad definido")
        '        End If
        '    End If

        'End Sub

        Public Function GetItem(ByVal id As Object) As TEntity
            Return GetItem(Of TEntity)(New Object() {id})
        End Function

        Public Function GetItem(Of T As Class)(ByVal id As Object) As T
            Return GetItem(Of T)(New Object() {id})
        End Function

        Public Function GetItem(ByVal keys As Object()) As TEntity
            Return GetItem(Of TEntity)(keys)
        End Function

        Public Function GetItem(Of T As Data.Entity.LINQEntityBase)(ByVal keys As Object()) As T
            If keys Is Nothing Then Throw New NullReferenceException()
            If keys.Length = 0 Then Throw New ArgumentException()
            If _primaryKeys.Count > keys.Length Then Throw New Exception("No se ha especificado las claves primarias")
            Dim filtro As String = ""
            Dim separadorAnd As String = ""
            Dim i As Integer = 0
            Dim query As IEnumerable(Of T)

            For Each key As String In _primaryKeys.Keys
                filtro &= separadorAnd & key & " == @" & i
                i += 1
                separadorAnd = " and "
            Next
            query = GetItems(Of T)(filtro, keys)
            Try
                Return query.First()
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Overridable Function GetItems() As IEnumerable(Of TEntity)
            Return GetItems(Of TEntity)()
        End Function

        Public Overridable Function GetItems(Of T As Class)() As IEnumerable(Of T)
            Return _context.GetTable(Of T)().AsEnumerable().ToList()
        End Function

        Public Overridable Function GetItems(ByVal filter As String, ByVal ParamArray values As Object()) As IEnumerable(Of TEntity)
            Return GetItems(Of TEntity)(filter, values)
        End Function

        Public Overridable Function GetItems(Of T As Class)(ByVal filter As String, ByVal ParamArray values As Object()) As IEnumerable(Of T)
            Dim query As IQueryable(Of T) = _context.GetTable(Of T)().AsQueryable()
            If Not String.IsNullOrEmpty(filter) Then
                query = query.Where(filter, values)
            End If
            Return query.AsEnumerable().ToList()
        End Function

        Public Overridable Function GetItems(ByVal filter As String, ByVal order As String, ByVal ParamArray values As Object()) As IEnumerable(Of TEntity)
            Return GetItems(Of TEntity)(filter, order, values)
        End Function

        Public Overridable Function GetItems(Of T As Class)(ByVal filter As String, ByVal order As String, ByVal ParamArray values As Object()) As IEnumerable(Of T)
            Dim query As IQueryable(Of T) = _context.GetTable(Of T)().AsQueryable()
            If Not String.IsNullOrEmpty(filter) Then
                query = query.Where(filter, values)
            End If
            If Not String.IsNullOrEmpty(order) Then
                query = query.OrderBy(order)
            End If
            Return query.AsEnumerable().ToList()
        End Function

        Public Overridable Function GetItems(ByVal filter As String, ByVal order As String, ByVal start As Integer, ByVal limit As Integer, ByRef count As Integer, ByVal ParamArray values As Object()) As IEnumerable(Of TEntity)
            Return GetItems(Of TEntity)(filter, order, start, limit, count, values)
        End Function

        Public Overridable Function GetItems(Of T As Class)(ByVal filter As String, ByVal order As String, ByVal start As Integer, ByVal limit As Integer, ByRef count As Integer, ByVal ParamArray values As Object()) As IEnumerable(Of T)
            Dim query As IQueryable(Of T) = _context.GetTable(Of T)().AsQueryable()
            If Not String.IsNullOrEmpty(filter) Then
                query = query.Where(filter, values)
            End If
            If Not String.IsNullOrEmpty(order) Then
                query = query.OrderBy(order)
            End If
            count = query.Count()
            If start < 0 Then start = 0
            If start > 0 Then
                query = CType(query.Start(start), Global.System.Linq.IQueryable(Of T))
            End If
            If limit < 0 Then limit = 0
            If limit > 0 Then
                query = CType(query.Limit(limit), Global.System.Linq.IQueryable(Of T))
            End If
            Return query.AsEnumerable().ToList()
        End Function

        Public Overridable Function GetItemsBy(ByVal idName As String, values As Long()) As IEnumerable(Of TEntity)
            Return GetItemsBy(Of TEntity)(idName, values)
        End Function

        Protected Function ExecuteQuery(query As String, ByVal ParamArray parametros As Object()) As IEnumerable(Of TEntity)
            Return _context.ExecuteQuery(Of TEntity)(query, parametros)
        End Function

        Public Overridable Function GetItemsBy(Of T As Data.Entity.LINQEntityBase)(ByVal idName As String, ByVal values As Long()) As IEnumerable(Of T)
            Dim filter As String = String.Empty
            Dim separator As String = String.Empty
            If String.IsNullOrEmpty(idName) Or IsNothing(values) OrElse values.Length = 0 Then
                Return Nothing
            Else
                For Each v As Long In values
                    filter &= separator & idName & " = " & v.ToString()
                    separator = " OR "
                Next
            End If
            Return GetItems(Of T)(filter)
        End Function

        Public Function Paging(Of T As Data.Entity.LINQEntityBase)(ByVal dataList As IEnumerable(Of T), ByVal start As Integer, ByVal limit As Integer, ByRef count As Integer) As IEnumerable(Of T)
            Dim query As IQueryable(Of T)
            count = 0
            If dataList Is Nothing Then Return Nothing
            If dataList.Count = 0 Then Return dataList
            query = dataList.AsQueryable()
            count = query.Count()
            If start < 0 Then start = 0
            If limit > 0 And start >= 0 Then
                query = CType(query.Start(start).Limit(limit), Global.System.Linq.IQueryable(Of T))
            End If
            Return query.AsEnumerable().ToList()
        End Function

        Private Function getPrimaryKeys() As List(Of String)
            Dim model As MetaTable = _context.Mapping.GetTable(_entityType)
            Dim members As Collections.ObjectModel.ReadOnlyCollection(Of MetaDataMember) = model.RowType.IdentityMembers
            Dim primaryKeys As New List(Of String)
            For Each member As MetaDataMember In members
                primaryKeys.Add(member.Name)
            Next
            Return primaryKeys
        End Function


#Region " IDisposable Support "
        ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
        Public Overloads Sub Dispose() Implements IDisposable.Dispose
            ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

        Private Overloads Sub Dispose(ByVal disposing As Boolean)
            ' Check to see if Dispose has already been called.
            If Not Me._disposed Then
                ' If disposing equals true, dispose all managed 
                ' and unmanaged resources.
                If disposing Then
                    _context.Dispose()

                End If
            End If
            _disposed = True
        End Sub
#End Region

        Protected Overrides Sub Finalize()
            Me.Dispose(False)
            MyBase.Finalize()
        End Sub
    End Class

    Public Class DataChangeActionException
        Inherits Exception

        Public Property Instance As Object

        Private _mensaje As String = ""

        Public Sub New(changeAction As System.Data.Linq.ChangeAction, instance As Object)
            MyBase.New()
            Dim accion As String = ""
            Dim entidadOrigen As String = ""
            Dim idiomaEs As Boolean = Globalization.CultureInfo.CurrentCulture.Name.Equals("es-es", StringComparison.InvariantCultureIgnoreCase)
            Select Case changeAction
                Case System.Data.Linq.ChangeAction.Delete
                    accion = CStr(IIf(idiomaEs, "Eliminación ", "删除"))
                Case System.Data.Linq.ChangeAction.Update
                    accion = CStr(IIf(idiomaEs, "Modificación ", "更新"))
                Case System.Data.Linq.ChangeAction.Insert
                    accion = CStr(IIf(idiomaEs, "Inserción ", "添加"))
            End Select
            If instance IsNot Nothing Then
                If instance.GetType().IsGenericTypeDefinition Then
                    entidadOrigen = instance.GetType().GetGenericArguments()(0).Name
                Else
                    entidadOrigen = instance.GetType.Name
                End If
            End If
            _mensaje = CStr(IIf(idiomaEs, "Existe en la entidad {0} error/es, la acción {1}no será aceptada.", "{0}实体存在错误，在{1}操作将不会被接受。"))
            _mensaje = String.Format(_mensaje, entidadOrigen, accion)
            Me.Instance = instance
        End Sub

        Public Overrides ReadOnly Property Message As String
            Get
                Return _mensaje
            End Get
        End Property

    End Class
End Namespace

