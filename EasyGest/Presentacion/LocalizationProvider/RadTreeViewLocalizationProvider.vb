
Namespace Presentacion.LocalizationProvider

    Public Class SpanishRadTreeViewLocalizationProvider
        Inherits TreeViewLocalizationProvider

        Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case id
                Case TreeViewStringId.ContextMenuCollapse
                    Return "Contraer"
                Case TreeViewStringId.ContextMenuDelete
                    Return "Eliminar"
                Case TreeViewStringId.ContextMenuEdit
                    Return "Editar"
                Case TreeViewStringId.ContextMenuExpand
                    Return "Expandir"
                Case TreeViewStringId.ContextMenuNew
                    Return "Agregar"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class

    Public Class ChineseRadTreeViewLocalizationProvider
        Inherits TreeViewLocalizationProvider

        Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case id
                Case TreeViewStringId.ContextMenuCollapse
                    Return "收起"
                Case TreeViewStringId.ContextMenuDelete
                    Return "删除"
                Case TreeViewStringId.ContextMenuEdit
                    Return "编辑"
                Case TreeViewStringId.ContextMenuExpand
                    Return "展开"
                Case TreeViewStringId.ContextMenuNew
                    Return "新建"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
End Namespace