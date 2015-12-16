Namespace Presentacion.LocalizationProvider

    Public Class SpanishPropertyGridLocalizationProvider
        Inherits PropertyGridLocalizationProvider
        Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case id
                Case PropertyGridStringId.ContextMenuReset
                    Return "Resetear"
                Case PropertyGridStringId.ContextMenuEdit
                    Return "Editar"
                Case PropertyGridStringId.ContextMenuExpand
                    Return "Expandir"
                Case PropertyGridStringId.ContextMenuCollapse
                    Return "Contraer"
                Case PropertyGridStringId.ContextMenuShowDescription
                    Return "Ver descripción"
                Case PropertyGridStringId.ContextMenuShowToolbar
                    Return "Ver barra herramienta"

                Case PropertyGridStringId.ContextMenuSort
                    Return "Ordenar"
                Case PropertyGridStringId.ContextMenuNoSort
                    Return "No ordenar"
                Case PropertyGridStringId.ContextMenuAlphabetical
                    Return "Alfabética"
                Case PropertyGridStringId.ContextMenuCategorized
                    Return "Categorizado"
                Case PropertyGridStringId.ContextMenuCategorizedAlphabetical
                    Return "Categorizado alfabeticamente"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class

    Public Class ChinesePropertyGridLocalizationProvider
        Inherits PropertyGridLocalizationProvider
        Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case id
                Case PropertyGridStringId.ContextMenuReset
                    Return "重置"
                Case PropertyGridStringId.ContextMenuEdit
                    Return "编辑"
                Case PropertyGridStringId.ContextMenuExpand
                    Return "展开"
                Case PropertyGridStringId.ContextMenuCollapse
                    Return "收起"
                Case PropertyGridStringId.ContextMenuShowDescription
                    Return "显示描述"
                Case PropertyGridStringId.ContextMenuShowToolbar
                    Return "显示工具条"

                Case PropertyGridStringId.ContextMenuSort
                    Return "排序"
                Case PropertyGridStringId.ContextMenuNoSort
                    Return "不排序"
                Case PropertyGridStringId.ContextMenuAlphabetical
                    Return "字母顺序"
                Case PropertyGridStringId.ContextMenuCategorized
                    Return "类别"
                Case PropertyGridStringId.ContextMenuCategorizedAlphabetical
                    Return "类别字母顺序"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
End Namespace
