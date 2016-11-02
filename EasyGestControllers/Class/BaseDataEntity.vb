Imports System.ComponentModel

Namespace Data.Entity
    Public MustInherit Class BaseDataEntity

        Private _isChanged As Boolean = False
        Protected Sub OnPropertyChaged(obj As Object, e As PropertyChangedEventArgs)
            _isChanged = True
        End Sub

        Public MustOverride Function IsValid(action As System.Data.Linq.ChangeAction) As Boolean

        'Public Sub Reset()
        '    If Not IsNothing(_originalObject) And DataChanged Then
        '        Me = _originalObject.MemberwiseClone()
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