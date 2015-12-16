Namespace Presentacion.LocalizationProvider
    Class SpanishRadTimePickerLocalizationProvider
        Inherits RadTimePickerLocalizationProvider

        Public Overrides Function GetLocalizedString(id As String) As String
            Select Case id
                Case RadTimePickerStringId.HourHeaderText
                    Return "Horas"
                Case RadTimePickerStringId.MinutesHeaderText
                    Return "Minutos"
                Case RadTimePickerStringId.CloseButtonText
                    Return "Cerrar"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select
        End Function

    End Class

    Class ChineseRadTimePickerLocalizationProvider
        Inherits RadTimePickerLocalizationProvider

        Public Overrides Function GetLocalizedString(id As String) As String
            Select Case id
                Case RadTimePickerStringId.HourHeaderText
                    Return "时"
                Case RadTimePickerStringId.MinutesHeaderText
                    Return "分"
                Case RadTimePickerStringId.CloseButtonText
                    Return "关闭"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select
        End Function

    End Class
End Namespace
