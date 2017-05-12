Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Localization

Namespace Presentacion.LocalizationProvider

    Public Class SpanishRadDockLocalizationProvider
        Inherits UI.Localization.RadDockLocalizationProvider

        Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case id
                Case RadDockStringId.ContextMenuAutoHide
                    Return "Autoocultar"
                Case RadDockStringId.ContextMenuCancel
                    Return "Cancelar"
                Case RadDockStringId.ContextMenuClose
                    Return "Cerrar"
                Case RadDockStringId.ContextMenuCloseAll
                    Return "Cerrar todos"
                Case RadDockStringId.ContextMenuCloseAllButThis
                    Return "Cerrar todos excepto ésta"
                Case RadDockStringId.ContextMenuDockable
                    Return "Acoplable"
                Case RadDockStringId.ContextMenuFloating
                    Return "Flotable"
                Case RadDockStringId.ContextMenuHide
                    Return "Ocultar"
                Case RadDockStringId.ContextMenuMoveToNextTabGroup
                    Return "Mover al siguiente grupo de fichas"
                Case RadDockStringId.ContextMenuMoveToPreviousTabGroup
                    Return "Mover al anterior grupo de fichas"
                Case RadDockStringId.ContextMenuNewHorizontalTabGroup
                    Return "Nuevo grupo de fichas horizontales"
                Case RadDockStringId.ContextMenuNewVerticalTabGroup
                    Return "Nuevo grupo de fichas veticales"
                Case RadDockStringId.ToolTabStripPinButton
                    Return "Anclar"
                Case RadDockStringId.ToolTabStripUnpinButton
                    Return "Desanclar"
                Case RadDockStringId.ToolTabStripDockStateButton
                    Return "Estado acoplaje"
                Case RadDockStringId.ToolTabStripCloseButton
                    Return "Cerrar"
                Case RadDockStringId.DocumentTabStripListButton
                    Return "Lista documentos"
                Case RadDockStringId.DocumentTabStripCloseButton
                    Return "Cerrar"
                Case RadDockStringId.ContextMenuTabbedDocument
                    Return "Documento en pestaña"
                Case RadDockStringId.ToolTabStripDockStateButton
                    Return "Cerrar ventana"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class

    Public Class ChineseRadDockLocalizationProvider
        Inherits UI.Localization.RadDockLocalizationProvider

        Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case id
                Case RadDockStringId.ContextMenuAutoHide
                    Return "自动隐藏"
                Case RadDockStringId.ContextMenuCancel
                    Return "取消"
                Case RadDockStringId.ContextMenuClose
                    Return "关闭"
                Case RadDockStringId.ContextMenuCloseAll
                    Return "关闭所有"
                Case RadDockStringId.ContextMenuCloseAllButThis
                    Return "除此关闭所有"
                Case RadDockStringId.ContextMenuDockable
                    Return "可停靠"
                Case RadDockStringId.ContextMenuFloating
                    Return "可浮动"
                Case RadDockStringId.ContextMenuHide
                    Return "隐藏"
                Case RadDockStringId.ContextMenuMoveToNextTabGroup
                    Return "移到下个卡群"
                Case RadDockStringId.ContextMenuMoveToPreviousTabGroup
                    Return "移到上个卡群"
                Case RadDockStringId.ContextMenuNewHorizontalTabGroup
                    Return "新横卡群"
                Case RadDockStringId.ContextMenuNewVerticalTabGroup
                    Return "新纵卡群"
                Case RadDockStringId.ToolTabStripPinButton
                    Return "闩住"
                Case RadDockStringId.ToolTabStripUnpinButton
                    Return "活动"
                Case RadDockStringId.ToolTabStripDockStateButton
                    Return "停靠状态"
                Case RadDockStringId.ToolTabStripCloseButton
                    Return "关闭"
                Case RadDockStringId.DocumentTabStripListButton
                    Return "卡表"
                Case RadDockStringId.DocumentTabStripCloseButton
                    Return "关闭"
                Case RadDockStringId.ToolTabStripDockStateButton
                    Return "关闭窗口"
                Case RadDockStringId.ContextMenuTabbedDocument
                    Return "文件卡"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
End Namespace