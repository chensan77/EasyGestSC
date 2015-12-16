Namespace Presentacion.LocalizationProvider

    Public Class SpanishColorDialogLocalizationProvider
        Inherits ColorDialogLocalizationProvider
        Public Overrides Function GetLocalizedString(id As String) As String
            Select Case id
                'localizing the static strings
                Case ColorDialogStringId.ColorDialogProfessionalTab
                    Return "Profesional"
                Case ColorDialogStringId.ColorDialogWebTab
                    Return "Web"
                Case ColorDialogStringId.ColorDialogSystemTab
                    Return "Sistema"
                Case ColorDialogStringId.ColorDialogBasicTab
                    Return "Básico"
                Case ColorDialogStringId.ColorDialogAddCustomColorButton
                    Return "Añadir color personalizado"
                Case ColorDialogStringId.ColorDialogOKButton
                    Return "Aceptar"
                Case ColorDialogStringId.ColorDialogCancelButton
                    Return "Cancelar"
                Case ColorDialogStringId.ColorDialogNewColorLabel
                    Return "Nuevo"
                Case ColorDialogStringId.ColorDialogCurrentColorLabel
                    Return "Actual"
                Case ColorDialogStringId.ColorDialogCaption
                    Return "Dialogo color"
                    'you can also localize the names of the colors
                    'Case "Black"
                    '    Return "Localized Black"
                    'Case "Blue"
                    '    Return "Localized Blue"
                    'Case "Aqua"
                    '    Return "Localized Aqua"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class

    Public Class ChineseColorDialogLocalizationProvider
        Inherits ColorDialogLocalizationProvider
        Public Overrides Function GetLocalizedString(id As String) As String
            Select Case id
                'localizing the static strings
                Case ColorDialogStringId.ColorDialogProfessionalTab
                    Return "专业"
                Case ColorDialogStringId.ColorDialogWebTab
                    Return "Web"
                Case ColorDialogStringId.ColorDialogSystemTab
                    Return "系统"
                Case ColorDialogStringId.ColorDialogBasicTab
                    Return "基础"
                Case ColorDialogStringId.ColorDialogAddCustomColorButton
                    Return "添加个性颜色"
                Case ColorDialogStringId.ColorDialogOKButton
                    Return "确定"
                Case ColorDialogStringId.ColorDialogCancelButton
                    Return "取消"
                Case ColorDialogStringId.ColorDialogNewColorLabel
                    Return "新"
                Case ColorDialogStringId.ColorDialogCurrentColorLabel
                    Return "当前"
                Case ColorDialogStringId.ColorDialogCaption
                    Return "颜色窗口"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
End Namespace