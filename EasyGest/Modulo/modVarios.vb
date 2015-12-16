Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports EasyGestControllers.Linq.Dynamic
Imports System.Linq.Expressions
Imports System.Text

Module modVarios

    <Extension()> _
    Public Function Compara(Of T)(ByVal source As T, ByVal target As Object) As Boolean
        Dim res As Boolean = True

        Dim typeObj As Type = GetType(T)
        Dim propsInfo As PropertyInfo()
        Dim value1, value2 As Object

        Dim typeTarget As Type = target.GetType

        If source Is Nothing Then
            Return False
        End If
        If target Is Nothing Then
            Return False
        End If
        propsInfo = typeObj.GetProperties(BindingFlags.Public Or BindingFlags.Instance)
        For Each prop As PropertyInfo In propsInfo
            Try
                Dim propTarget As PropertyInfo
                propTarget = typeTarget.GetProperty(prop.Name, BindingFlags.Public Or BindingFlags.Instance)
                If Not IsNothing(propTarget) Then
                    value1 = prop.GetValue(source, Nothing)
                    value2 = propTarget.GetValue(target, Nothing)

                    If Not value1.Equals(value2) Then
                        res = False
                        Exit For
                    End If
                End If

            Catch ex As Exception

            End Try
        Next
        Return res
    End Function

    <System.Runtime.CompilerServices.Extension()> _
    Public Function ConvertToEntitySet(Of T As Class)(ByVal source As IEnumerable(Of T)) As System.Data.Linq.EntitySet(Of T)
        Dim entidad As New System.Data.Linq.EntitySet(Of T)()
        If source IsNot Nothing Then
            entidad.AddRange(source)
        End If
        Return entidad
    End Function

    <System.Runtime.CompilerServices.Extension()> _
    Public Sub Clone(Of T As Class)(ByVal source As T, ByRef target As T)
        Dim typeObj As Type = GetType(T)
        'Dim typeTarget As Type = GetType(T)
        Dim propsInfo As PropertyInfo()
        Dim consInfo As ConstructorInfo
        Dim value1, value2 As Object

        If source Is Nothing Then target = Nothing
        If target Is Nothing Then
            consInfo = typeObj.GetConstructor(System.Type.EmptyTypes)
            target = CType(consInfo.Invoke(New Object() {}), T)
        End If
        propsInfo = typeObj.GetProperties(BindingFlags.Public Or BindingFlags.Instance Or BindingFlags.NonPublic)
        For Each prop As PropertyInfo In propsInfo
            Try
                value1 = prop.GetValue(source, Nothing)
                value2 = prop.GetValue(target, Nothing)

                If IsNothing(value1) Then
                    prop.SetValue(target, value1, Nothing)
                Else
                    If Not value1.Equals(value2) Then
                        prop.SetValue(target, value1, Nothing)
                    End If
                End If
                'Dim propTarget As PropertyInfo
                'propTarget = typeTarget.GetProperty(prop.Name, BindingFlags.Public Or BindingFlags.Instance Or BindingFlags.NonPublic)
                'If Not IsNothing(propTarget) AndAlso propTarget.CanWrite And prop.CanRead Then

                'End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    <Extension()> _
    Public Function Where(Of T)(ByVal source As IQueryable(Of T), ByVal predicate As String, ByVal ParamArray values() As Object) As IQueryable(Of T)
        Return DirectCast(Where(DirectCast(source, IQueryable), predicate, values), IQueryable(Of T))
    End Function

    <Extension()> _
    Public Function Where(ByVal source As IQueryable, ByVal predicate As String, ByVal ParamArray values() As Object) As IQueryable
        If source Is Nothing Then Throw New ArgumentNullException("source")
        If predicate Is Nothing Then Throw New ArgumentNullException("predicate")
        Dim lambda As LambdaExpression = EasyGestControllers.Linq.Dynamic.DynamicExpression.ParseLambda(source.ElementType, GetType(Boolean), predicate, values)
        Return source.Provider.CreateQuery( _
            Expression.Call( _
                GetType(Queryable), "Where", _
                New Type() {source.ElementType}, _
                source.Expression, Expression.Quote(lambda)))
    End Function

    <Extension()> _
    Public Function [Select](ByVal source As IQueryable, ByVal selector As String, ByVal ParamArray values() As Object) As IQueryable
        If source Is Nothing Then Throw New ArgumentNullException("source")
        If selector Is Nothing Then Throw New ArgumentNullException("selector")
        Dim lambda As LambdaExpression = EasyGestControllers.Linq.Dynamic.DynamicExpression.ParseLambda(source.ElementType, Nothing, selector, values)
        Return source.Provider.CreateQuery( _
            Expression.Call( _
                GetType(Queryable), "Select", _
                New Type() {source.ElementType, lambda.Body.Type}, _
                source.Expression, Expression.Quote(lambda)))
    End Function

    <Extension()> _
    Public Function OrderBy(Of T)(ByVal source As IQueryable(Of T), ByVal ordering As String, ByVal ParamArray values() As Object) As IQueryable(Of T)
        Return DirectCast(OrderBy(DirectCast(source, IQueryable), ordering, values), IQueryable(Of T))
    End Function

    <Extension()> _
    Public Function OrderBy(ByVal source As IQueryable, ByVal ordering As String, ByVal ParamArray values() As Object) As IQueryable
        If (source Is Nothing) Then Throw New ArgumentNullException("source")
        If (ordering Is Nothing) Then Throw New ArgumentNullException("ordering")
        Dim parameters = New ParameterExpression() { _
            Expression.Parameter(source.ElementType, "")}
        Dim parser As New ExpressionParser(parameters, ordering, values)
        Dim orderings As IEnumerable(Of DynamicOrdering) = parser.ParseOrdering()
        Dim queryExpr As Expression = source.Expression
        Dim methodAsc = "OrderBy"
        Dim methodDesc = "OrderByDescending"
        For Each o As DynamicOrdering In orderings
            queryExpr = Expression.Call( _
                GetType(Queryable), If(o.Ascending, methodAsc, methodDesc), _
                New Type() {source.ElementType, o.Selector.Type}, _
                queryExpr, Expression.Quote(Expression.Lambda(o.Selector, parameters)))
            methodAsc = "ThenBy"
            methodDesc = "ThenByDescending"
        Next o
        Return source.Provider.CreateQuery(queryExpr)
    End Function

    <Extension()> _
    Public Function Limit(ByVal source As IQueryable, ByVal count As Integer) As IQueryable
        If (source Is Nothing) Then Throw New ArgumentNullException("source")
        Return source.Provider.CreateQuery( _
            Expression.Call( _
                GetType(Queryable), "Take", _
                New Type() {source.ElementType}, _
                source.Expression, Expression.Constant(count)))
    End Function

    <Extension()> _
    Public Function Start(ByVal source As IQueryable, ByVal count As Integer) As IQueryable
        If (source Is Nothing) Then Throw New ArgumentNullException("source")
        Return source.Provider.CreateQuery( _
            Expression.Call( _
                GetType(Queryable), "Skip", _
                New Type() {source.ElementType}, _
                source.Expression, Expression.Constant(count)))
    End Function

    <Extension()> _
    Public Function GroupBy(ByVal source As IQueryable, ByVal keySelector As String, ByVal elementSelector As String, ByVal ParamArray values() As Object) As IQueryable
        If (source Is Nothing) Then Throw New ArgumentNullException("source")
        If (keySelector Is Nothing) Then Throw New ArgumentNullException("keySelector")
        If (elementSelector Is Nothing) Then Throw New ArgumentNullException("elementSelector")
        Dim keyLambda As LambdaExpression = EasyGestControllers.Linq.Dynamic.DynamicExpression.ParseLambda(source.ElementType, Nothing, keySelector, values)
        Dim elementLambda As LambdaExpression = EasyGestControllers.Linq.Dynamic.DynamicExpression.ParseLambda(source.ElementType, Nothing, elementSelector, values)
        Return source.Provider.CreateQuery( _
            Expression.Call( _
                GetType(Queryable), "GroupBy", _
                New Type() {source.ElementType, keyLambda.Body.Type, elementLambda.Body.Type}, _
                source.Expression, Expression.Quote(keyLambda), Expression.Quote(elementLambda)))
    End Function

    <Extension()> _
    Public Function Any(ByVal source As IQueryable) As Boolean
        If (source Is Nothing) Then Throw New ArgumentNullException("source")
        Return CBool(source.Provider.Execute( _
            Expression.Call( _
                GetType(Queryable), "Any", _
                New Type() {source.ElementType}, source.Expression)))
    End Function

    <Extension()> _
    Public Function Count(ByVal source As IQueryable) As Integer
        If (source Is Nothing) Then Throw New ArgumentNullException("source")
        Return CInt(source.Provider.Execute( _
            Expression.Call( _
                GetType(Queryable), "Count", _
                New Type() {source.ElementType}, source.Expression)))
    End Function

    <Extension()> _
    Public Function SelectedItem(Of T As Class)(ByVal grid As RadGridView) As T
        Dim item As T
        item = Nothing
        If grid.SelectedRows.Count > 0 Then
            If TypeOf grid.SelectedRows.First.DataBoundItem Is T Then
                item = DirectCast(grid.SelectedRows.First.DataBoundItem, T)
            End If
        End If
        Return item
    End Function

    <Extension()> _
    Public Function SelectedItems(Of T As Class)(ByVal grid As RadGridView) As List(Of T)
        Dim items As New List(Of T)()
        For Each row As GridViewRowInfo In grid.SelectedRows
            If TypeOf row.DataBoundItem Is T Then
                items.Add(DirectCast(row.DataBoundItem, T))
            End If
        Next
        Return items
    End Function

    <System.Runtime.CompilerServices.Extension()> _
    Public Function PascalCase(ByVal str As String, withSpace As Boolean) As String
        If String.IsNullOrWhiteSpace(str) Then
            Return String.Empty
        Else
            Dim sb As New StringBuilder()
            Dim partes As String() = str.Split(New Char() {" "c, "-"c}, StringSplitOptions.RemoveEmptyEntries)
            Dim espacio As String = String.Empty
            For Each parte As String In partes
                If parte.Length = 0 Then Continue For
                parte = parte.Substring(0, 1).ToUpperInvariant() & parte.Substring(1)
                If withSpace Then
                    parte = espacio & parte
                    espacio = " "
                End If
                sb.Append(parte)
            Next
            Return sb.ToString()
        End If
    End Function
End Module
