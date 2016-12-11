Imports System.ComponentModel
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Reflection
Imports System.Runtime.Serialization
Imports System.Text
Imports System.Collections
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Xml

Namespace Data.Entity
    'Public MustInherit Class BaseDataEntity
    '    Implements ICloneable

    '    Private _isChanged As Boolean = False

    '    Protected Sub OnPropertyChaged(obj As Object, e As PropertyChangedEventArgs)
    '        _isChanged = True
    '    End Sub

    '    Public MustOverride Function IsValid(action As System.Data.Linq.ChangeAction) As Boolean

    '    Public Function Clone() As Object Implements ICloneable.Clone
    '        Return Me.MemberwiseClone()
    '    End Function

    '    Public ReadOnly Property DataChanged As Boolean
    '        Get
    '            Return _isChanged
    '        End Get
    '    End Property
    'End Class

End Namespace
'*************************************************************************************
' * LINQEntityBase.cs
' * Mar 10 2009 *** VERSION 1.1
' * Minor Change: Changed Caching to use Types instead of strings for keys. 
' * Jul 23 2009 Bug Fix: If the entity's state is "New", LINQ to SQL Tries to attach
' * an FK references as "New" as well - even though this was unintended. 
' * Fixed it so it does not try and insert FK referenced entities when 
' * adding a new object. Thanks Mark & Stephan for finding/fixing the issue.
' * Aug 09 2009 Bug Fix: If the onModifyKeepOriginal parameter on SetAsChangeTrackingRoot()
' * is set to true and an object is detached from a collection (i.e. x.remove(y)), 
' * the object was not being attached properly to the data context when 
' * SynchroniseWithDataContext() was called, causing an error to be thrown.
' * Thanks Yaki for finding the issue!
' * Oct 18 2009 Feature: Added ShallowCompare() method for comparing two entities.
' * Feature: If the onModifyKeepOriginal parameter on SetAsChangeTrackingRoot()
' * is set to true, and an object is modified (i.e. EntityState == Modified)
' * and then modified again in a way which set's it back to be the same as 
' * property values as it's original state, the entity will now have it's 
' * EntityState set to back Original (instead of remaining as EntityState ==
' * Modified.
' * Oct 19 2009 Bug Fix: Fixed Comparison bug in ShadownCompare() method.
' * Nov 19 2009 Bug Fix: When EntityState == CanceNew, don't change to EntityState ==
' * Deleted when SetAsDeleteOnSubmit is called.
' * Apr 17 2010 *** VERSION 1.2
' * ***********************************************************************************

Namespace Data.Entity

    ''' <summary>
    ''' Indicates the entity state.
    ''' NotTracked = this object is not change tracked.
    ''' Original = persisted, but unmodified.
    ''' New = Record to be inserted.
    ''' Modified = Record to be updated.
    ''' Detached = Record is detached (modified)
    ''' Deleted = Record to be deleted.
    ''' </summary>
    Public Enum EntityState
        NotTracked
        Original
        [New]
        Modified
        Detached
        Deleted
        CancelNew
    End Enum

    ''' <summary>
    ''' This object should be used as a superclass for LINQ to SQL Entities
    ''' which are disconnected and need change tracking capabilties.
    ''' 
    ''' To add this class as a superclass for all entities in a DataContext
    ''' Edit the dbml file for the DataContext and add in the "<Database>" xml element
    ''' the "EntityBase" xml attribute, then save the dbml file, right click the dbml file in
    ''' the VS project and select "Run Custom Tool".
    ''' 
    ''' e.g. EntityBase="LINQEntityBaseExample.LINQEntityBase"
    ''' 
    ''' </summary> 
    <DataContract(IsReference:=True)>
    <KnownType("GetKnownTypes")>
    Public MustInherit Class LINQEntityBase

#Region "static_constructor"

        ''' <summary>
        ''' Constructor
        ''' </summary>
        Shared Sub New()
            ' Get the Important LINQ entity properties
            GetImportantProperties()
        End Sub

#End Region

#Region "static_variables"

        ' Static array variables that contains all property information 
        Private Shared _cacheAssociationProperties As Dictionary(Of Type, Dictionary(Of String, PropertyInfo))
        ' stores the property info for associations
        Private Shared _cacheAssociationFKProperties As Dictionary(Of Type, Dictionary(Of String, PropertyInfo))
        ' stores the property info for foreingKey associations
        Private Shared _cacheDBGeneratedProperties As Dictionary(Of Type, Dictionary(Of String, PropertyInfo))
        ' stores the property info for columns that are DbGenerated
        Private Shared _cacheTablesPrimaryKeysProperties As Dictionary(Of Type, Dictionary(Of String, PropertyInfo))
        ' store table primary keys

#End Region

#Region "static_methods"

        ''' <summary>
        ''' Gets the list of Known Types
        ''' </summary>
        ''' <returns></returns> 
        Private Shared Function GetKnownTypes() As List(Of Type)
            Return (From a In Assembly.GetExecutingAssembly().GetTypes() Where a.IsSubclassOf(GetType(LINQEntityBase))).ToList()
        End Function


        Public Shared Function GetLINQEntityPrimaryKeys(entityType As Type) As Dictionary(Of String, PropertyInfo)
            Dim primaryKeys As New Dictionary(Of String, PropertyInfo)
            _cacheTablesPrimaryKeysProperties.TryGetValue(entityType, primaryKeys)
            Return primaryKeys
        End Function


        ''' <summary>
        ''' Serializes a LINQ Entity and it's children using DataContract serializer
        ''' </summary>
        ''' <param name="EntitySource">The Entity to be serialized</param>
        ''' <param name="KnownTypes">Any Known Types. Pass in null if you're datacontext is in the same assembly as the LINQ to Entity Base</param>
        ''' <returns>An XML string representing the serialized entity</returns>
        Public Shared Function SerializeEntity(Of T)(entitySource As T, KnownTypes As IEnumerable(Of Type)) As String
            Dim dcs As DataContractSerializer
            If KnownTypes Is Nothing Then
                dcs = New DataContractSerializer(entitySource.[GetType]())
            Else
                dcs = New DataContractSerializer(entitySource.[GetType](), KnownTypes)
            End If
            If entitySource Is Nothing Then
                Return Nothing
            End If
            Dim sb As New StringBuilder()
            Dim xmlw As Xml.XmlWriter = Xml.XmlWriter.Create(sb)
            dcs.WriteObject(xmlw, entitySource)
            xmlw.Close()
            Return sb.ToString()
        End Function

        ''' <summary>
        ''' Takes a serialized entity and re-hydrates it.
        ''' </summary>
        ''' <param name="EntitySource">The string containing the Serialized XML represnting the entity</param>
        ''' <param name="EntityType">The type of the entity being deserialized</param>
        ''' <param name="KnownTypes">Any Known Types. Pass in null if you're datacontext is in the same assembly as the LINQ to Entity Base</param>
        ''' <returns></returns>
        Public Shared Function DeserializeEntity(EntitySource As String, EntityType As Type, KnownTypes As IEnumerable(Of Type)) As Object
            Dim dcs As DataContractSerializer

            Dim entityTarget As Object
            If EntityType Is Nothing Then
                Return Nothing
            End If

            If KnownTypes Is Nothing Then
                dcs = New DataContractSerializer(EntityType)
            Else
                dcs = New DataContractSerializer(EntityType, KnownTypes)
            End If
            Dim sr As New StringReader(EntitySource)
            Dim xmltr As New XmlTextReader(sr)
            entityTarget = DirectCast(dcs.ReadObject(xmltr), Object)
            xmltr.Close()
            Return entityTarget
        End Function

        ''' <summary>
        ''' Make a shallow copy of column values without copying references of the source entity
        ''' </summary>
        ''' <param name="source">the source entity that will have it's values copied</param>
        ''' <returns></returns>
        Public Sub ShallowCopy(ByRef destination As LINQEntityBase)
            Dim sourcePropInfos As PropertyInfo() = Me.[GetType]().GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)
            Dim destinationPropInfos As PropertyInfo() = Me.[GetType]().GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)

            ' create an object to copy values into
            Dim entityType As Type = Me.[GetType]()
            If IsNothing(destination) Then _
                destination = TryCast(Activator.CreateInstance(entityType), LINQEntityBase)

            For Each sourcePropInfo As PropertyInfo In sourcePropInfos

                If Attribute.GetCustomAttribute(sourcePropInfo, GetType(ColumnAttribute), False) IsNot Nothing Then
                    Dim destPropInfo As PropertyInfo = destinationPropInfos.Where(Function(pi) pi.Name = sourcePropInfo.Name).First()
                    destPropInfo.SetValue(destination, sourcePropInfo.GetValue(Me, Nothing), Nothing)
                End If
            Next

            destination.LINQEntityState = EntityState.Original
            destination.LINQEntityGUID = Me.LINQEntityGUID

        End Sub

        ''' <summary>
        ''' Returns true if two entities have the same property values (does not traverse releationships).
        ''' </summary>
        ''' <param name="source"></param>
        ''' <returns></returns>
        Public Shared Function ShallowCompare(entity1 As LINQEntityBase, entity2 As LINQEntityBase) As Boolean
            If Not Object.ReferenceEquals(entity1.[GetType](), entity2.[GetType]()) Then
                Return False
            End If

            Dim entity1PropInfos As PropertyInfo() = entity1.[GetType]().GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)
            Dim entity2PropInfos As PropertyInfo() = entity2.[GetType]().GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)

            ' Find if there are any properties that do not match that are custom attributes
            Dim compareResults = From prop1 In entity1PropInfos.Where(Function(p1) Attribute.GetCustomAttribute(p1, GetType(ColumnAttribute), False) IsNot Nothing)
                                 Group Join prop2 As PropertyInfo In entity2PropInfos.Where(Function(p2) Attribute.GetCustomAttribute(p2, GetType(ColumnAttribute), False) IsNot Nothing)
                                 On prop1.Name Equals prop2.Name Into pij = Group
                                 From prop2 In pij.DefaultIfEmpty()
                                 Select New With {Key .Match = Object.Equals(prop1.GetValue(entity1, Nothing), prop2.GetValue(entity2, Nothing))}

            Return (compareResults.Where(Function(cr) cr.Match = False).Count() = 0)

        End Function

        ''' <summary>
        ''' Loops through the available properties on the class and finds associated, FK and database generated properties,
        ''' putting them into a cache to be used later.
        ''' </summary>
        Private Shared Sub GetImportantProperties()
            Dim assocAttribute As AssociationAttribute
            Dim colAttribute As ColumnAttribute

            _cacheAssociationProperties = New Dictionary(Of Type, Dictionary(Of String, PropertyInfo))()

            _cacheAssociationFKProperties = New Dictionary(Of Type, Dictionary(Of String, PropertyInfo))()

            _cacheDBGeneratedProperties = New Dictionary(Of Type, Dictionary(Of String, PropertyInfo))()

            _cacheTablesPrimaryKeysProperties = New Dictionary(Of Type, Dictionary(Of String, PropertyInfo))()

            For Each type As Type In GetKnownTypes()
                _cacheAssociationProperties.Add(type, New Dictionary(Of String, PropertyInfo)())
                _cacheAssociationFKProperties.Add(type, New Dictionary(Of String, PropertyInfo)())
                _cacheDBGeneratedProperties.Add(type, New Dictionary(Of String, PropertyInfo)())
                _cacheTablesPrimaryKeysProperties.Add(type, New Dictionary(Of String, PropertyInfo)())
                For Each propInfo As PropertyInfo In type.GetProperties()
                    ' check it's an association attribute first
                    assocAttribute = DirectCast(Attribute.GetCustomAttribute(propInfo, GetType(AssociationAttribute), False), AssociationAttribute)

                    ' if it is an association attribute
                    If assocAttribute IsNot Nothing Then
                        ' Store the FK relationships seperately (i.e. child to parent relationships);
                        If assocAttribute.IsForeignKey <> True Then
                            _cacheAssociationProperties(type).Add(propInfo.Name, propInfo)
                        Else
                            _cacheAssociationFKProperties(type).Add(propInfo.Name, propInfo)
                        End If
                    Else
                        ' check if its a column attribute second, less common
                        colAttribute = TryCast(Attribute.GetCustomAttribute(propInfo, GetType(ColumnAttribute), False), ColumnAttribute)

                        If colAttribute IsNot Nothing AndAlso colAttribute.IsDbGenerated = True Then
                            _cacheDBGeneratedProperties(type).Add(propInfo.Name, propInfo)
                            Continue For
                        End If
                        If colAttribute IsNot Nothing AndAlso colAttribute.IsPrimaryKey = True Then
                            _cacheTablesPrimaryKeysProperties(type).Add(propInfo.Name, propInfo)
                            Continue For
                        End If
                    End If

                Next
            Next
        End Sub


#End Region

#Region "constructor"

        ''' <summary>
        ''' Default constructor, always called as long as child entity was created with default constructure aswell.
        ''' </summary>
        Protected Sub New()
            _entityGUID = Guid.NewGuid().ToString()
            'a unique identifier for the entity
            Init()
            BindToEntityEvents()
        End Sub


        Private Sub Init()
            _isSyncronisingWithDB = False
            _isRoot = False
            _entityState = EntityState.Original
            _isKeepOriginal = False

            _entityTree = New EntityTree(Me, _cacheAssociationProperties(Me.[GetType]()))
        End Sub

#End Region

#Region "private_members"

        Private _isSyncronisingWithDB As Boolean
        Private _isRoot As Boolean
        ' indicates if the entity is the root of the entity tree
        Private _entityState As EntityState
        'returns the current entity state
        Private _isKeepOriginal As Boolean
        'indicates if the original record before modifications should be kept for use when syncing with DataContext later on.
        Private _entityGUID As String
        'a unique identifier for the entity 
        Private _entityTree As EntityTree
        'used to hold the private class that allows entity Tree to be enumerated
        Private _changeTrackingReferences As List(Of LINQEntityBase)
        'holds a list of all entities, regardless of their state for the purpose of tracking changes.
        Private _originalEntityValue As LINQEntityBase
        ' holds the original entity values before modification
        Private _originalEntityValueTemp As LINQEntityBase

        Public Function PrimaryKeyCompare(data As LINQEntityBase) As Boolean
            Dim primaryKeySource As Dictionary(Of String, PropertyInfo)
            Dim primaryKeyTarget As Dictionary(Of String, PropertyInfo)

            primaryKeySource = GetLINQEntityPrimaryKeys(Me.GetType())
            primaryKeyTarget = GetLINQEntityPrimaryKeys(data.GetType())

            For Each e As KeyValuePair(Of String, PropertyInfo) In primaryKeySource
                Dim sourceValue, targetValue As Object
                If primaryKeyTarget.ContainsKey(e.Key) Then
                    sourceValue = e.Value.GetValue(Me, Nothing)
                    targetValue = primaryKeyTarget(e.Key).GetValue(data, Nothing)
                    If IsNothing(sourceValue) Xor IsNothing(targetValue) Then
                        Return False
                    Else
                        If (Not IsNothing(sourceValue) And Not IsNothing(targetValue)) AndAlso Not sourceValue.Equals(targetValue) Then
                            Return False
                        End If
                    End If
                Else
                    Return False
                End If
            Next
            Return True
        End Function

        ' temporarily holds the original entity value until we no it's a true modification.
        ''' <summary>
        ''' This method binds to the events of the entity that are required.
        ''' </summary>
        Private Sub BindToEntityEvents()
            Dim childEntityChanged As INotifyPropertyChanged
            Dim childEntityChanging As INotifyPropertyChanging

            childEntityChanged = TryCast(Me, INotifyPropertyChanged)
            childEntityChanging = TryCast(Me, INotifyPropertyChanging)

            ' bind the events, so when a property is changed the base class is aware of it.
            ' Note that when tables don't have a primary key, the don't implement these interfaces
            ' so if they can't be cast, then don't attempt to assign an event handler.
            If childEntityChanged IsNot Nothing AndAlso childEntityChanging IsNot Nothing Then
                AddHandler childEntityChanged.PropertyChanged, AddressOf PropertyChanged
                AddHandler childEntityChanging.PropertyChanging, AddressOf PropertyChanging
            End If

        End Sub



        ''' <summary>
        ''' Handles the property changing event sent from child object.
        ''' </summary>
        ''' <param name="sender">child object</param>
        ''' <param name="e">Property Changing arguements</param>
        Private Sub PropertyChanging(sender As Object, e As PropertyChangingEventArgs)
            ' Ignore events if syncronising with DB
            If _isSyncronisingWithDB = True Then
                Return
            End If

            If [ReadOnly] Then Return
            ' Do a check here to make sure that the entity is not change if it is supposed to be deleted
            If Me.LINQEntityState = EntityState.Deleted OrElse Me.LINQEntityState = EntityState.CancelNew Then
                Return 'Throw New ApplicationException("You cannot modify a deleted entity")
            End If

            ' If it's a change tracked object thats in "Original" state
            ' grab a copy of the object incase it's going to be modified
            If Me.LINQEntityState = EntityState.Original AndAlso LINQEntityKeepOriginal = True AndAlso LINQEntityOriginalValue Is Nothing Then
                Me.ShallowCopy(_originalEntityValueTemp)
            End If
        End Sub

        ''' <summary>
        ''' Handles the property changed event sent from child object.
        ''' </summary>
        ''' <param name="sender">child object</param>
        ''' <param name="e">Property Changed arguements</param>
        Private Sub PropertyChanged(sender As Object, e As PropertyChangedEventArgs)

            ' Ignore events if syncronising with DB
            If _isSyncronisingWithDB = True Then
                Return
            End If

            Dim propInfo As PropertyInfo = Nothing

            ' if this object isn't change tracked yet, but it's parent
            ' is, this means it's a new object
            If Me.LINQEntityState = EntityState.NotTracked Then
                ' Check to see if the parent object is change tracked
                ' If there is, set the new flag, and tell this new object it's tracked
                If _cacheAssociationFKProperties(Me.[GetType]()).ContainsKey(e.PropertyName) Then
                    If _cacheAssociationFKProperties(Me.[GetType]()).TryGetValue(e.PropertyName, propInfo) Then
                        If propInfo IsNot Nothing Then
                            Dim parentEntity As LINQEntityBase = DirectCast(propInfo.GetValue(Me, Nothing), LINQEntityBase)

                            If parentEntity IsNot Nothing AndAlso parentEntity.LINQEntityState <> EntityState.NotTracked Then
                                ' loop through this entity and child entities and track them aswell
                                For Each entity As LINQEntityBase In Me.ToEntityTree()
                                    entity.LINQEntityState = EntityState.[New]
                                Next
                            End If
                        End If
                    End If
                End If
            End If


            'if the object is not new....
            If LINQEntityState <> EntityState.[New] Then
                ' only go into this section if it's change tracked
                If Me.LINQEntityState <> EntityState.NotTracked Then
                    If Not _cacheAssociationProperties(Me.[GetType]()).ContainsKey(e.PropertyName) Then
                        If _cacheAssociationFKProperties(Me.[GetType]()).ContainsKey(e.PropertyName) Then
                            If _cacheAssociationFKProperties(Me.[GetType]()).TryGetValue(e.PropertyName, propInfo) Then
                                ' Parent FK has been set to null, object is now detached.
                                If (propInfo IsNot Nothing) AndAlso (propInfo.GetValue(Me, Nothing) Is Nothing) Then
                                    Me._originalEntityValue = Me._originalEntityValueTemp
                                    LINQEntityState = EntityState.Detached
                                ElseIf LINQEntityState <> EntityState.Modified AndAlso LINQEntityState <> EntityState.Detached Then
                                    Me._originalEntityValue = Me._originalEntityValueTemp
                                    LINQEntityState = EntityState.Modified
                                End If
                            End If
                        Else
                            ' if a db generated column has been modified
                            ' do nothing
                            Dim isDbGenerated As Boolean = _cacheDBGeneratedProperties(Me.[GetType]()).TryGetValue(e.PropertyName, propInfo)
                            If isDbGenerated Then
                                Return
                            End If

                            ' if the object is already modified and the property values have reverted back to their
                            ' original values, set the state back to "Original"
                            If LINQEntityState = EntityState.Modified AndAlso Me._originalEntityValue IsNot Nothing Then
                                If ShallowCompare(Me, Me._originalEntityValue) Then
                                    LINQEntityState = EntityState.Original
                                    Me._originalEntityValue = Nothing
                                End If
                                ' if the object isn't already modified or detached
                                ' set it as modified
                            ElseIf LINQEntityState <> EntityState.Modified AndAlso LINQEntityState <> EntityState.Detached Then
                                Me._originalEntityValue = Me._originalEntityValueTemp
                                LINQEntityState = EntityState.Modified
                            End If
                        End If
                    End If
                End If
            End If

            Me._originalEntityValueTemp = Nothing
        End Sub

        ''' <summary>
        ''' Gets/Sets whether this entity has a change tracking root.
        ''' </summary>
        <DataMember(Order:=3)>
        Friend Property LINQEntityKeepOriginal() As Boolean
            Get
                Return _isKeepOriginal
            End Get
            Set
                _isKeepOriginal = Value
            End Set
        End Property

        ''' <summary>
        ''' Gets/Sets the original entity value before any changes
        ''' </summary>
        <DataMember(Order:=4)>
        Friend Property LINQEntityOriginalValue() As LINQEntityBase
            Get
                Return _originalEntityValue
            End Get
            Set
                _originalEntityValue = Value
            End Set
        End Property

        Friend Property [ReadOnly] As Boolean = False

        ''' <summary>
        ''' Gets/Sets the entities which have been detached.
        ''' (Data Contract Serialization Only)
        ''' </summary>
        <DataMember(Order:=5)>
        Private Property LINQEntityDetachedEntities() As List(Of LINQEntityBase)
            Get
                ' if in the root object, get all detached records 
                ' except for root object if marked as detached
                If Me.IsRoot = True Then
                    Dim entities As New List(Of LINQEntityBase)()
                    entities.AddRange(_changeTrackingReferences.Where(Function(e) e.LINQEntityState = EntityState.Detached AndAlso Not e.Equals(Me)))
                    Return entities
                Else
                    Return Nothing
                End If
            End Get

            Set
                _changeTrackingReferences = Value
            End Set
        End Property



        ''' <summary>
        ''' For serialization purposes, returns null if false (so it doesn't take up space in xml)
        ''' Or true if this object is the root.
        ''' </summary>
        <DataMember(Order:=6)>
        Private Property IsRoot() As System.Nullable(Of Boolean)
            Get
                Dim temp As System.Nullable(Of Boolean) = Nothing
                Return If((_isRoot), True, temp)
            End Get
            Set
                If Value Is Nothing Then
                    _isRoot = False
                Else
                    _isRoot = Value.Value
                End If
            End Set
        End Property

        ''' <summary>
        ''' When starting deserialization, call this method to make sure that 
        ''' private variables are setup.
        ''' </summary>
        ''' <param name="sc"></param>
        <OnDeserializing>
        Private Sub BeforeDeserializing(sc As System.Runtime.Serialization.StreamingContext)
            Init()
        End Sub

        ''' <summary>
        ''' Called at the final stage of serialization to make sure that the interal
        ''' change tracking references are correct.
        ''' </summary> 
        <OnDeserialized>
        Private Sub AfterDeserialized(sc As System.Runtime.Serialization.StreamingContext)
            ' Grab the important properties first
            ' FindImportantProperties();

            ' If it's not tracked, bind the property now
            ' Else check if it is tracked and it's the root entity
            ' Then walk through the entity tree and bind all child attributes
            ' And set the changetracking references
            If Me.LINQEntityState = EntityState.NotTracked Then
                BindToEntityEvents()
            ElseIf Me.IsRoot = True Then
                ' Set the change tracking references to the value which 
                ' ToEntityTree() returns, which will inlcude not only the 
                ' entity tree, but the detached entities as well.
                _changeTrackingReferences = Me.ToEntityTree()

                ' Bind to events for every entity in the tree, doing this only as
                ' the very last step of deserialization because we don't want
                ' any of the events to accidentally fire while deserializing.
                For Each entity As LINQEntityBase In _changeTrackingReferences
                    entity.BindToEntityEvents()
                Next
            End If
        End Sub

        ' Gets an Association Property from the cache
        Private Function GetAssociationProperty(propName As String, ByRef propInfo As PropertyInfo) As Boolean
            Return _cacheAssociationProperties(Me.[GetType]()).TryGetValue(propName, propInfo)
        End Function

        ' Gets an FK Association Property from the cache
        Private Function GetAssociationFKProperty(propName As String, ByRef propInfo As PropertyInfo) As Boolean
            Return _cacheAssociationFKProperties(Me.[GetType]()).TryGetValue(propName, propInfo)
        End Function

        ' Gets a Database Generate Property from the cache
        Private Function GetDbGeneratedProperty(propName As String, ByRef propInfo As PropertyInfo) As Boolean
            Return _cacheDBGeneratedProperties(Me.[GetType]()).TryGetValue(propName, propInfo)
        End Function

#End Region

#Region "public_members"

        ''' <summary>
        ''' Returns an ID that is unique for this object.
        ''' </summary>
        <DataMember(Order:=1)>
        Public Property LINQEntityGUID() As String
            Get
                Return _entityGUID
            End Get
            Private Set
                _entityGUID = Value
            End Set
        End Property

        <DataMember(Order:=2)>
        Public Property LINQEntityState() As EntityState
            Get
                Return _entityState
            End Get
            Private Set
                _entityState = Value
            End Set
        End Property

        Friend Property IsSyncronisingWithDB As Boolean
            Get
                Return _isSyncronisingWithDB
            End Get
            Set(value As Boolean)
                _isSyncronisingWithDB = value
            End Set
        End Property


        ''' <summary>
        ''' This method flattens the hierachy of objects into a single list that can be queried by linq
        ''' </summary>
        ''' <returns></returns>
        Public Function ToEntityTree() As List(Of LINQEntityBase)
            ' Deleted records won't show up in entity tree
            ' So include these when returning the results

            Dim entities As List(Of LINQEntityBase)

            entities = (From t In _entityTree).ToList()

            If Me.IsRoot = True Then
                entities.AddRange(LINQEntityDetachedEntities)
            End If

            Return entities
        End Function

        Public Overridable Function IsValid() As Boolean
            Return True
        End Function

        ''' <summary>
        ''' Sets the current entity as the root for change tracking.
        ''' Assumes object is in original state (unmodified)
        ''' Does not keep original values.
        ''' </summary>
        Public Sub SetAsChangeTrackingRoot()
            SetAsChangeTrackingRoot(EntityState.Original, False)
        End Sub

        ''' <summary>
        ''' Sets the current entity as the root for change tracking.
        ''' Assumes object is in original state (unmodified)
        ''' </summary>
        ''' <param name="OnModifyKeepOriginal">If modified, original entity state is kept for attachment to context later on.</param>
        Public Sub SetAsChangeTrackingRoot(onModifyKeepOriginal As Boolean)
            SetAsChangeTrackingRoot(EntityState.Original, onModifyKeepOriginal)
        End Sub

        ''' <summary>
        ''' Sets the current entity as the root for change tracking.
        ''' Does not keep original values.
        ''' </summary>
        ''' <param name="initialEntityState">The initial state of the root entity</param>
        Public Sub SetAsChangeTrackingRoot(initialEntityState As EntityState)
            SetAsChangeTrackingRoot(initialEntityState, False)
        End Sub

        ''' <summary>
        ''' Sets the current entity as the root for change tracking and resets all the values of all entities.
        ''' </summary>
        ''' <param name="initialEntityState">The initial state of the root entity</param>
        ''' <param name="onModifyKeepOriginal">If modified, original entity state is kept for attachment to context later on.</param>
        Public Sub SetAsChangeTrackingRoot(initialEntityState As EntityState, onModifyKeepOriginal As Boolean)
            ' Throw an exception if this object is already being change tracked
            If Me.LINQEntityState <> EntityState.NotTracked AndAlso Me.IsRoot = False Then
                Throw New ApplicationException("This entity is already being Change Tracked and cannot be the root.")
            End If

            ' Throw an exception if "Modified" is passed in - this is not allowed
            If initialEntityState = EntityState.Modified Then
                Throw New ApplicationException("An Entity cannot be set as the Change Tracking Root whilst modified. Instead, Set as Change Tracking root and then modify the entity.")
            End If

            ' Throw an exception if "Detached" is passed in - this is not allowed
            If initialEntityState = EntityState.Detached Then
                Throw New ApplicationException("An Entity cannot be set as the Change Tracking Root whilst detached.")
            End If

            ' This is the root object, so grab a list of all the references and keep for later.
            ' We need this, so that we can track entity deletions.
            _changeTrackingReferences = Me._entityTree.ToList()
            _isRoot = True

            ' Reset all the change tracked object states
            For Each entity As LINQEntityBase In _changeTrackingReferences
                ' if initial state is deleted, only set the root object to deleted
                If initialEntityState = EntityState.Deleted Then
                    If Me Is entity Then
                        entity.LINQEntityState = EntityState.Deleted
                    Else
                        entity.LINQEntityState = EntityState.Original
                    End If
                Else
                    entity.LINQEntityState = initialEntityState
                End If

                entity.LINQEntityOriginalValue = Nothing
                entity.LINQEntityKeepOriginal = onModifyKeepOriginal
            Next
        End Sub

        '''' <summary>
        '''' Syncronises this EntityBase and all sub objects
        '''' with a data context. Assumes you want cascade deletes.
        '''' </summary>
        '''' <param name="targetDataContext">The data context that will apply the changes</param>
        'Friend Sub SynchroniseWithDataContext(targetDataContext As DataContext)
        '    SynchroniseWithDataContext(targetDataContext, True)
        'End Sub

        '''' <summary>
        '''' Syncronises this EntityBase and all sub objects
        '''' with a data context.
        '''' </summary>
        '''' <param name="targetDataContext">The data context that will apply the changes</param>
        '''' <param name="cascadeDelete">Whether or not casade deletes is allowed</param>
        'Friend Sub SynchroniseWithDataContext(targetDataContext As DataContext, cascadeDelete As Boolean)
        ' Before doing anything, check to make sure that the new datacontext
        ' doesn't try any deferred (lazy) loading
        'If targetDataContext.DeferredLoadingEnabled = True Then
        '        Throw New ApplicationException("Syncronisation requires that the Deferred loading is disabled on the Target DataContext")
        '    End If

        '    ' Also Make sure this entity is the change tracking root
        '    If Me.IsRoot = False Then
        '        Throw New ApplicationException("You cannot syncronise an entity that is not the change tracking root")
        '    End If

        '    Dim entities As List(Of LINQEntityBase) = Me.ToEntityTree().Distinct().ToList()
        '    Dim entitiesDeleted As New List(Of LINQEntityBase)()

        '    Try

        '        ' Tell each entity that syncronisation is occuring
        '        For Each entity As LINQEntityBase In entities
        '            entity._isSyncronisingWithDB = True
        '        Next

        '        ' For entities which have been Cancelled (Added as new then deleted before submission to DB)
        '        ' detach these entities by removing it's references so that they can be garbage collected.

        '        For Each entity As LINQEntityBase In entities
        '            If entity.LINQEntityState = EntityState.CancelNew Then
        '                For Each propInfo As PropertyInfo In _cacheAssociationFKProperties(entity.[GetType]()).Values
        '                    propInfo.SetValue(entity, Nothing, Nothing)
        '                Next
        '            End If
        '        Next

        '        ' Loop through all the entities, attaching as appropriate to the data context

        '        For Each entity As LINQEntityBase In entities
        '            If entity.LINQEntityState = EntityState.Original Then
        '                targetDataContext.GetTable(entity.GetEntityType()).Attach(entity, False)
        '            ElseIf entity.LINQEntityState = EntityState.[New] Then
        '                ' If the entity's state is new, LINQ to SQL Tries to attach an FK references as "New" as well.
        '                ' To avoid this, attach all FK references first as unmodified (unless they were intended to be new anyway) 
        '                ' then attach the new record.
        '                For Each fkPropInfo As PropertyInfo In _cacheAssociationFKProperties(entity.[GetType]()).Values
        '                    Dim fkProp As LINQEntityBase = TryCast(fkPropInfo.GetValue(entity, Nothing), LINQEntityBase)
        '                    If fkProp IsNot Nothing AndAlso fkProp.LINQEntityState <> EntityState.[New] Then
        '                        Try
        '                            targetDataContext.GetTable(fkProp.[GetType]()).Attach(fkProp, False)
        '                            ' do nothing as the entity was already attached.
        '                        Catch
        '                        End Try
        '                    End If
        '                Next

        '                targetDataContext.GetTable(entity.GetEntityType()).InsertOnSubmit(entity)
        '            ElseIf entity.LINQEntityState = EntityState.Modified OrElse entity.LINQEntityState = EntityState.Detached Then
        '                If entity.LINQEntityOriginalValue IsNot Nothing Then
        '                    targetDataContext.GetTable(entity.GetEntityType()).Attach(entity, entity.LINQEntityOriginalValue)
        '                Else
        '                    targetDataContext.GetTable(entity.GetEntityType()).Attach(entity, True)
        '                End If
        '            End If

        '            If entity.LINQEntityState = EntityState.Deleted AndAlso Not entitiesDeleted.Contains(entity) Then
        '                ' Check to see if cascading deletes is allowed
        '                If cascadeDelete Then
        '                    ' Grab the entity tree and reverse it so that this entity is deleted last
        '                    Dim entityTreeReversed As List(Of LINQEntityBase) = entity.ToEntityTree()
        '                    entityTreeReversed.Reverse()

        '                    ' Cascade delete children and then this object
        '                    For Each toDelete As LINQEntityBase In entityTreeReversed
        '                        ' Before we try and delete, make sure the entity hasn't been marked to be deleted already
        '                        ' through another relationship linkng this entity in the same sub-tree that is being deleted.
        '                        If Not entitiesDeleted.Contains(toDelete) Then
        '                            ' Mark for deletion
        '                            toDelete.SetAsDeleteOnSubmit()
        '                            targetDataContext.GetTable(toDelete.GetEntityType()).Attach(toDelete)
        '                            targetDataContext.GetTable(toDelete.GetEntityType()).DeleteOnSubmit(toDelete)

        '                            'add deleted entity to a list to make sure we don't delete them twice.
        '                            entitiesDeleted.Add(toDelete)
        '                        End If
        '                    Next
        '                Else
        '                    ' Mark for deletion
        '                    targetDataContext.GetTable(entity.GetEntityType()).Attach(entity)
        '                    targetDataContext.GetTable(entity.GetEntityType()).DeleteOnSubmit(entity)

        '                    'add deleted entity to a list to make sure we don't delete them twice.
        '                    entitiesDeleted.Add(entity)
        '                End If
        '                targetDataContext.SubmitChanges()
        '                ' if this is the root object, there's no need to do more processing 
        '                ' so just quit the loop
        '                If Me Is entity Then
        '                    Exit For
        '                End If
        '            End If
        '        Next

        '        ' Reset this entity as the change tracking root, getting a new copy of all objects

        '        Me.SetAsChangeTrackingRoot(Me.LINQEntityKeepOriginal)
        '    Finally
        '        ' Tell each entity that syncronisation is occuring
        '        For Each entity As LINQEntityBase In entities
        '            entity._isSyncronisingWithDB = False
        '        Next
        '    End Try
        'End Sub

        ''' <summary>
        ''' Set the entity to be Inserted into the database
        ''' </summary>
        ''' <param name="ApplyToChildEntities">
        ''' Indicates whether all child objects are also marked to be inserted
        ''' </param>
        Public Sub SetAsInsertOnSubmit(ApplyToChildEntities As Boolean)
            If ApplyToChildEntities = True Then
                For Each entity As LINQEntityBase In Me.ToEntityTree().Distinct().ToList()
                    entity.SetAsInsertOnSubmit()
                Next
            Else
                Me.SetAsInsertOnSubmit()
            End If
        End Sub

        ''' <summary>
        ''' Set the entity to be Inserted into the database
        ''' </summary>
        Public Sub SetAsInsertOnSubmit()
            If Me.LINQEntityState = EntityState.Detached Then
                Throw New ApplicationException("You cannot change the Entity State from 'Detached' to 'New'")
            End If

            If Me.LINQEntityState = EntityState.NotTracked Then
                Throw New ApplicationException("You cannot change the Entity State when the Entity is not change tracked")
            End If

            LINQEntityState = EntityState.[New]
        End Sub



        ''' <summary>
        ''' Indicates that the entity will Update the database.
        ''' If a snapshot of the original value of this entity already exists from a previous modification, the original value will be kept.
        ''' </summary>
        Public Sub SetAsUpdateOnSubmit()
            If _originalEntityValue IsNot Nothing Then
                SetAsUpdateOnSubmit(_originalEntityValue)
            Else
                Dim no As LINQEntityBase = Nothing
                SetAsUpdateOnSubmit(no)
            End If
        End Sub

        ''' <summary>
        ''' Indicates that the entity will Update the database.
        ''' If a snapshot of the original value of this entity or any of it's children already exists from a previous modification, the original value will be kept
        ''' </summary>
        ''' <param name="ApplyToChildEntities">
        ''' Indicates whether all child entities are also marked to be updates
        ''' </param>
        Public Sub SetAsUpdateOnSubmit(ApplyToChildEntities As Boolean)
            If ApplyToChildEntities = True Then
                For Each entity As LINQEntityBase In Me.ToEntityTree().Distinct().ToList()
                    entity.SetAsUpdateOnSubmit()
                Next
            Else
                Me.SetAsUpdateOnSubmit()
            End If
        End Sub

        ''' <summary>
        ''' Indicates that the entity will Update the database.
        ''' </summary>
        ''' <param name="OriginalValue">
        ''' Sets/Overrides the original value of the entity. 
        ''' The entity value passed in should be an earlier shallow copy of the entity.
        ''' This value can be set to null to indicate if the original entity value should be removed if it exists from a previous modification.
        ''' </param>
        Public Sub SetAsUpdateOnSubmit(OriginalValue As LINQEntityBase)
            If Me.LINQEntityState = EntityState.Detached Then
                Throw New ApplicationException("You cannot change the Entity State from 'Detached' to 'Modified'")
            End If

            If Me.LINQEntityState = EntityState.NotTracked Then
                Throw New ApplicationException("You cannot change the Entity State when the Entity is not change tracked")
            End If

            If OriginalValue IsNot Nothing Then
                Me.ShallowCopy(Me._originalEntityValue)
            Else
                Me._originalEntityValue = Nothing
            End If

            Me.LINQEntityState = EntityState.Modified
        End Sub

        ''' <summary>
        ''' Indicates that the entity will NOT modify the database.
        ''' </summary>
        ''' <param name="ApplyToChildEntities">
        ''' Indicates whether all child entities should be marked so that they do not modify the database.
        ''' </param>
        Public Sub SetAsNoChangeOnSubmit(ApplyToChildEntities As Boolean)
            If ApplyToChildEntities = True Then
                For Each entity As LINQEntityBase In Me.ToEntityTree().Distinct().ToList()
                    entity.SetAsNoChangeOnSubmit()
                Next
            Else
                Me.SetAsNoChangeOnSubmit()
            End If
        End Sub

        ''' <summary>
        ''' Indicates that the entity will NOT modify the database.
        ''' </summary> 
        Public Sub SetAsNoChangeOnSubmit()
            If Me.LINQEntityState = EntityState.Detached Then
                Throw New ApplicationException("You cannot change the Entity State from 'Detached' to 'Original'")
            End If

            If Me.LINQEntityState = EntityState.NotTracked Then
                Throw New ApplicationException("You cannot change the Entity State when the Entity is not change tracked")
            End If

            Me.LINQEntityState = EntityState.Original
        End Sub

        ''' <summary>
        ''' Indicates that the entity should be deleted from the database.
        ''' </summary>
        ''' <param name="ApplyToChildEntities">
        ''' Indicates whether all child entities should be marked for deletion (cascade delete).
        ''' </param>
        Public Sub SetAsDeleteOnSubmit(ApplyToChildEntities As Boolean)
            If ApplyToChildEntities = True Then
                For Each entity As LINQEntityBase In Me.ToEntityTree().Distinct().ToList()
                    entity.SetAsDeleteOnSubmit()
                Next
            Else
                Me.SetAsDeleteOnSubmit()
            End If
        End Sub

        ''' <summary>
        ''' Set the entity to Deleted on Syncronisation with Database
        ''' </summary>
        Public Sub SetAsDeleteOnSubmit()
            If Me.LINQEntityState = EntityState.Detached Then
                Throw New ApplicationException("You cannot modify the Entity State from 'Detached' to 'Delete' ")
            End If

            If Me.LINQEntityState = EntityState.NotTracked Then
                Throw New ApplicationException("You cannot change the Entity State when the Entity is not change tracked")
            End If

            If Me.LINQEntityState = EntityState.[New] Then
                Me.LINQEntityState = EntityState.CancelNew
            ElseIf Me.LINQEntityState <> EntityState.CancelNew Then
                Me.LINQEntityState = EntityState.Deleted
            End If

        End Sub

        ''' <summary>
        ''' Finds the Entity Type of the current object by find the class marked with the TableAttribute
        ''' </summary>
        ''' <returns></returns>
        Public Function GetEntityType() As Type
            Dim type As Type = Me.[GetType]()
            Dim tableAttribute As TableAttribute = DirectCast(Attribute.GetCustomAttribute(type, GetType(TableAttribute), False), TableAttribute)

            While tableAttribute Is Nothing AndAlso type <> GetType(LINQEntityBase)
                type = type.BaseType
                tableAttribute = DirectCast(Attribute.GetCustomAttribute(type, GetType(TableAttribute), False), TableAttribute)
            End While

            Return type

        End Function

        'Public Function GetTableEntityPrimaryKeys() As Dictionary(Of String, PropertyInfo)
        '    Return _cacheTablesPrimaryKeysProperties(Me.GetType())
        'End Function

#End Region

#Region "private_classes"

        ''' <summary>
        ''' This class is used internally to implement IEnumerable, so that the Tree can
        ''' be enumerated by LINQ queries.
        ''' </summary>
        Private Class EntityTree
            Implements IEnumerable(Of LINQEntityBase)
            Private _entityAssociationProperties As Dictionary(Of String, Reflection.PropertyInfo)
            Private _entityRoot As LINQEntityBase

            Public Sub New(EntityRoot As LINQEntityBase, EntityAssociationProperties As Dictionary(Of String, Reflection.PropertyInfo))
                _entityRoot = EntityRoot
                _entityAssociationProperties = EntityAssociationProperties
            End Sub

            ' implement the GetEnumerator Type
            Public Iterator Function GetEnumerator() As IEnumerator(Of LINQEntityBase)
                ' return the current object
                Yield _entityRoot

                ' return the children (using reflection)
                For Each propInfo As Reflection.PropertyInfo In _entityAssociationProperties.Values
                    ' Is it an EntitySet<> ?
                    If propInfo.PropertyType.IsGenericType AndAlso propInfo.PropertyType.GetGenericTypeDefinition() = GetType(System.Data.Linq.EntitySet(Of)) Then
                        ' It's an EntitySet<> so lets grab the value, loop through each value and
                        ' return each value as an EntityBase.
                        Dim entityList As IEnumerator = TryCast(propInfo.GetValue(_entityRoot, Nothing), IEnumerable).GetEnumerator()

                        While entityList.MoveNext() = True
                            If entityList.Current.[GetType]().IsSubclassOf(GetType(LINQEntityBase)) Then
                                Dim currentEntity As LINQEntityBase = DirectCast(entityList.Current, LINQEntityBase)
                                For Each subEntity As LINQEntityBase In currentEntity.ToEntityTree()
                                    Yield subEntity
                                Next
                            End If
                        End While
                    ElseIf propInfo.PropertyType.IsSubclassOf(GetType(LINQEntityBase)) Then
                        ' ignore the property if it's null
                        If propInfo.GetValue(_entityRoot, Nothing) IsNot Nothing Then
                            'Ask for these children for their section of the tree.
                            For Each subEntity As LINQEntityBase In TryCast(propInfo.GetValue(_entityRoot, Nothing), LINQEntityBase).ToEntityTree()
                                Yield subEntity
                            Next
                        End If
                    End If
                Next
            End Function

            ' implement the GetEnumerator type
            Private Function IEnumerable_GetEnumerator1() As IEnumerator(Of LINQEntityBase) Implements IEnumerable(Of LINQEntityBase).GetEnumerator
                Return Me.GetEnumerator()
            End Function

            Private Function IEnumerable_GetEnumerator2() As IEnumerator Implements IEnumerable.GetEnumerator
                Return Me.GetEnumerator()
            End Function
        End Class

#End Region

    End Class

End Namespace
