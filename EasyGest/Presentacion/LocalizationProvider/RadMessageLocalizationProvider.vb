Imports Telerik.WinControls

Namespace Presentacion.LocalizationProvider

    Public Class SpanishRadMessageLocalizationProvider
        Inherits RadMessageLocalizationProvider

        Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case id
                Case RadMessageStringID.AbortButton
                    Return "Abortar"
                Case RadMessageStringID.CancelButton
                    Return "Cancelar"
                Case RadMessageStringID.IgnoreButton
                    Return "Ignorar"
                Case RadMessageStringID.NoButton
                    Return "No"
                Case RadMessageStringID.OKButton
                    Return "Aceptar"
                Case RadMessageStringID.RetryButton
                    Return "Reintentar"
                Case RadMessageStringID.YesButton
                    Return "Sí"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class

    Public Class ChineseRadMessageLocalizationProvider
        Inherits RadMessageLocalizationProvider

        Public Overrides Function GetLocalizedString(ByVal id As String) As String
            Select Case id
                Case RadMessageStringID.AbortButton
                    Return "终止"
                Case RadMessageStringID.CancelButton
                    Return "取消"
                Case RadMessageStringID.IgnoreButton
                    Return "忽略"
                Case RadMessageStringID.NoButton
                    Return "否"
                Case RadMessageStringID.OKButton
                    Return "确定"
                Case RadMessageStringID.RetryButton
                    Return "重试"
                Case RadMessageStringID.YesButton
                    Return "是"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
End Namespace