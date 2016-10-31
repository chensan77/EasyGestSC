Imports System.ComponentModel

Namespace Data.Entity
    Public MustInherit Class BaseDataEntity(Of T As Class)
        Private _originalObject As T
        Private _isChanged As Boolean = False

        Protected Friend Sub SetOriginalObject(obj As T)
            If Not IsNothing(obj) Then
                obj.Clone(_originalObject)
            End If
        End Sub
        Protected Sub OnPropertyChaged(obj As Object, e As PropertyChangedEventArgs)
            _isChanged = True
        End Sub

        Public MustOverride Function IsValid(action As System.Data.Linq.ChangeAction) As Boolean

        'Public Sub Reset()
        '    If Not IsNothing(_originalObject) And DataChanged Then
        '        _originalObject.Clone()
        '        _isChanged = False
        '    End If
        'End Sub

        Public ReadOnly Property DataChanged As Boolean
            Get
                Return _isChanged
            End Get
        End Property
    End Class
End Namespace