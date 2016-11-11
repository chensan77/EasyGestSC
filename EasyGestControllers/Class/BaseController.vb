Imports System.Reflection
Imports System.Data.Linq
Imports System.Data.Linq.Mapping


Namespace Controller

    Public MustInherit Class BaseController(Of TEntity As Class, TContext As DataContext)
        Implements IDisposable

        Private _disposed As Boolean = False
        Private _readonly As Boolean = False
        Private _context As TContext = Nothing
        Private _entityType As Type = GetType(TEntity)
        Private _primaryKeys As New List(Of String)

        Protected Sub New()
            _context = CType(Activator.CreateInstance(GetType(TContext), ""), TContext)
            _primaryKeys = getPrimaryKeys()
        End Sub

        Protected Sub New([readOnly] As Boolean)
            Me.New()
            _readonly = [readOnly]
        End Sub


        Friend ReadOnly Property Contexto() As TContext
            Get
                Return _context
            End Get
        End Property

        Public Overridable Sub ResetItem(ByRef item As TEntity)
            Dim table As Table(Of TEntity) = _context.GetTable(Of TEntity)()
            _context.Refresh(RefreshMode.OverwriteCurrentValues, item)
        End Sub

        Public Shared Function NewItem() As TEntity
            Return DirectCast(Activator.CreateInstance(GetType(TEntity)), TEntity)
        End Function

        Public Overridable Function AddItem(ByVal item As TEntity) As TEntity
            If _readonly Then Throw New ReadOnlyException("Entidad no modificable")
            If item Is Nothing Then Throw New NullReferenceException()

            Dim table As Table(Of TEntity) = _context.GetTable(Of TEntity)()

            If table IsNot Nothing Then
                table.InsertOnSubmit(item)
                _context.SubmitChanges()
                Return item
            Else
                Throw New ApplicationException("No hay un conjunto de entidad definido")
            End If
        End Function

        Public Overridable Sub AddItems(ByVal items As IEnumerable(Of TEntity))
            If _readonly Then Throw New ReadOnlyException("Entidad no modificable")
            If items Is Nothing Then Throw New NullReferenceException

            Dim table As Table(Of TEntity) = _context.GetTable(Of TEntity)()

            If table IsNot Nothing Then
                table.InsertAllOnSubmit(items)
                _context.SubmitChanges()
            Else
                Throw New ApplicationException("No hay un conjunto de entidad definido")
            End If
        End Sub

        Public Overridable Function UpdateItem(ByVal item As TEntity) As TEntity
            If _readonly Then Throw New ReadOnlyException("Entidad no modificable")
            If item Is Nothing Then Throw New NullReferenceException

            Dim originalItem As TEntity
            Dim valores As List(Of Object)

            valores = GetValuesOfPrimaryKey(item)

            originalItem = GetItem(valores.ToArray)
            If originalItem IsNot Nothing Then
                CloneEntity(item, originalItem)
                Try
                    _context.SubmitChanges()
                Catch ex As ChangeConflictException
                    For Each conflicto As ObjectChangeConflict In _context.ChangeConflicts
                        conflicto.Resolve(RefreshMode.KeepCurrentValues)
                    Next
                    _context.SubmitChanges(ConflictMode.FailOnFirstConflict)
                Catch ex1 As Exception
                    Throw ex1
                End Try
            End If
            Return originalItem
        End Function

        Public Overridable Function DeleteItem(ByVal id As Object) As TEntity
            Return DeleteItem(New Object() {id})
        End Function

        Public Overridable Function DeleteItem(ByVal keys As Object()) As TEntity
            Dim toDelete As TEntity = Nothing
            If _readonly Then Throw New ReadOnlyException("Entidad no modificable")

            toDelete = GetItem(keys)

            If toDelete IsNot Nothing Then
                _context.GetTable(Of TEntity)().DeleteOnSubmit(toDelete)
                _context.SubmitChanges()
            End If
            Return toDelete
        End Function

        Public Overridable Sub DeleteItems(ByVal items As IEnumerable(Of TEntity))
            If _readonly Then Throw New ReadOnlyException("Entidad no modificable")
            If items Is Nothing Then Throw New NullReferenceException

            Dim toDelete As TEntity = Nothing
            Dim toDeletes As New List(Of TEntity)
            Dim valores As List(Of Object)
            For Each item In items
                valores = GetValuesOfPrimaryKey(item)
                toDelete = GetItem(valores.ToArray())

                If toDelete IsNot Nothing Then
                    toDeletes.Add(toDelete)
                End If
            Next

            If toDeletes.Count > 0 Then
                Dim table As Table(Of TEntity) = _context.GetTable(Of TEntity)()

                If table IsNot Nothing Then
                    table.DeleteAllOnSubmit(toDeletes)
                    _context.SubmitChanges()
                Else
                    Throw New ApplicationException("No hay un conjunto de entidad definido")
                End If
            End If

        End Sub

        Public Sub ReloadItem(ByRef item As TEntity)
            _context.Refresh(RefreshMode.OverwriteCurrentValues, item)
        End Sub

        Public Function GetItem(ByVal id As Object) As TEntity
            Return GetItem(Of TEntity)(New Object() {id})
        End Function

        Public Function GetItem(Of T As Class)(ByVal id As Object) As T
            Return GetItem(Of T)(New Object() {id})
        End Function

        Public Function GetItem(ByVal keys As Object()) As TEntity
            Return GetItem(Of TEntity)(keys)
        End Function

        Public Function GetItem(Of T As Class)(ByVal keys As Object()) As T
            If keys Is Nothing Then Throw New NullReferenceException()
            If keys.Length = 0 Then Throw New ArgumentException()
            If _primaryKeys.Count > keys.Length Then Throw New Exception("No se ha especificado las claves primarias")
            Dim filtro As String = ""
            Dim separadorAnd As String = ""
            Dim i As Integer = 0
            Dim query As IEnumerable(Of T)
            For Each key As String In _primaryKeys
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

        Public Overridable Function GetItemsBy(Of T As Class)(ByVal idName As String, ByVal values As Long()) As IEnumerable(Of T)
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

        Public Function Paging(Of T As Class)(ByVal dataList As IEnumerable(Of T), ByVal start As Integer, ByVal limit As Integer, ByRef count As Integer) As IEnumerable(Of T)
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

        Private Function GetValuesOfPrimaryKey(ByVal item As TEntity) As List(Of Object)
            Dim propInfo As PropertyInfo
            Dim valores As New List(Of Object)
            For Each key As String In _primaryKeys
                propInfo = _entityType.GetProperty(key, BindingFlags.Public Or BindingFlags.Instance)
                If propInfo IsNot Nothing Then
                    Try
                        valores.Add(propInfo.GetValue(item, Nothing))
                    Catch ex As Exception
                        Throw New ApplicationException("No se ha podido obtener valor de uno de los clave primaria", ex)
                    End Try
                Else
                    Throw New ApplicationException("Uno de los claves primarias no está definida")
                End If
            Next
            Return valores
        End Function

        Private Sub CloneEntity(ByVal currentEntity As TEntity, ByRef originalEntity As TEntity)
            If originalEntity Is Nothing Then
                Dim ctorInfo As ConstructorInfo = _entityType.GetConstructor(Type.EmptyTypes)
                If ctorInfo Is Nothing Then Exit Sub
                originalEntity = CType(ctorInfo.Invoke(New Object() {}), TEntity)
            End If

            For Each propInfo As PropertyInfo In _entityType.GetProperties(BindingFlags.Instance Or BindingFlags.Public)
                Dim currentValue, originalValue As Object
                If propInfo.CanRead Then
                    originalValue = propInfo.GetValue(originalEntity, Nothing)
                    currentValue = propInfo.GetValue(currentEntity, Nothing)
                    Try
                        If propInfo.CanWrite Then
                            If currentValue Is Nothing Then
                                propInfo.SetValue(originalEntity, Nothing, Nothing)
                            Else
                                If Not currentValue.Equals(originalValue) Then
                                    propInfo.SetValue(originalEntity, currentValue, Nothing)
                                End If
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If
            Next
        End Sub


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

