Imports System.ComponentModel

Namespace Data.Entity
    Public MustInherit Class BaseDataEntity
        Private _originalObject As Object
        Private _isChanged As Boolean = False

        Protected Friend Sub SetOriginalObject(obj As Object)
            _originalObject = obj
        End Sub
        Protected Sub OnPropertyChaged(obj As Object, e As PropertyChangedEventArgs)
            _isChanged = True
        End Sub

        Public MustOverride Function IsValid(action As System.Data.Linq.ChangeAction) As Boolean

        Public Sub Reset()
            If Not IsNothing(_originalObject) Then
                _originalObject.Clone(Me)
            End If
        End Sub

        Public ReadOnly Property DataChanged As Boolean
            Get
                Return _isChanged
            End Get
        End Property
    End Class
End Namespace