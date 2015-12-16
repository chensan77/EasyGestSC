Namespace Presentacion.LocalizationProvider

    Public Class SpanishCalendarLocalizationProvider
        Inherits CalendarLocalizationProvider
        Public Overrides Function GetLocalizedString(id As String) As String
            Select Case id
                Case CalendarStringId.CalendarClearButton
                    Return "Limpiar"
                Case CalendarStringId.CalendarTodayButton
                    Return "Hoy"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class

    Public Class ChineseCalendarLocalizationProvider
        Inherits CalendarLocalizationProvider
        Public Overrides Function GetLocalizedString(id As String) As String
            Select Case id
                Case CalendarStringId.CalendarClearButton
                    Return "清除"
                Case CalendarStringId.CalendarTodayButton
                    Return "今天"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class

End Namespace