'Imports Telerik.WinControls.UI.Localization

Namespace Presentacion.LocalizationProvider

    Public Class SpanishCommandBarLocalizationProvider
        Inherits CommandBarLocalizationProvider

        Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case (id)
                Case CommandBarStringId.ContextMenuCustomizeText
                    Return "Personalizar..."
                Case CommandBarStringId.CustomizeDialogChooseToolstripLabelText
                    Return "Escoge una barra de herramienta para reorganizarla."
                Case CommandBarStringId.CustomizeDialogCloseButtonText
                    Return "Cerrar"
                Case CommandBarStringId.CustomizeDialogItemsPageTitle
                    Return "Elementos"
                Case CommandBarStringId.CustomizeDialogMoveDownButtonText
                    Return "Bajar"
                Case CommandBarStringId.CustomizeDialogMoveUpButtonText
                    Return "Subir"
                Case CommandBarStringId.CustomizeDialogResetButtonText
                    Return "Resetear"
                Case CommandBarStringId.CustomizeDialogTitle
                    Return "Personalizar"
                Case CommandBarStringId.CustomizeDialogToolstripsPageTitle
                    Return "Barra Herramientas"
                Case CommandBarStringId.OverflowMenuAddOrRemoveButtonsText
                    Return "Añadir o quitar botones"
                Case CommandBarStringId.OverflowMenuCustomizeText
                    Return "Personalizar..."
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select
        End Function

    End Class

    Public Class ChineseCommandBarLocalizationProvider
        Inherits CommandBarLocalizationProvider

        Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case (id)
                Case CommandBarStringId.ContextMenuCustomizeText
                    Return "个性化..."
                Case CommandBarStringId.CustomizeDialogChooseToolstripLabelText
                    Return "选择一个工具栏重新排列."
                Case CommandBarStringId.CustomizeDialogCloseButtonText
                    Return "关闭"
                Case CommandBarStringId.CustomizeDialogItemsPageTitle
                    Return "Elementos"
                Case CommandBarStringId.CustomizeDialogMoveDownButtonText
                    Return "上调"
                Case CommandBarStringId.CustomizeDialogMoveUpButtonText
                    Return "下调"
                Case CommandBarStringId.CustomizeDialogResetButtonText
                    Return "重置"
                Case CommandBarStringId.CustomizeDialogTitle
                    Return "个性化"
                Case CommandBarStringId.CustomizeDialogToolstripsPageTitle
                    Return "工具栏"
                Case CommandBarStringId.OverflowMenuAddOrRemoveButtonsText
                    Return "添加或删除按钮"
                Case CommandBarStringId.OverflowMenuCustomizeText
                    Return "个性化..."
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select
            Return String.Empty
        End Function
    End Class

End Namespace
