Public Class EasyGestReportInfo

    Public ReadOnly Property ReportCategory As String
    Public ReadOnly Property ReportName As String
    Public ReadOnly Property ReportDescription As String
    Public ReadOnly Property ReportType As Type

    Private Sub New()

    End Sub

    Public Sub New(category As String, name As String, descrip As String, type As Type)
        ReportCategory = category
        ReportName = name
        ReportDescription = descrip
        ReportType = type
    End Sub

    Public Function GetReport() As Telerik.Reporting.Report

        If ReportType.BaseType.FullName.Equals("Telerik.Reporting.Report") Then
            Return DirectCast(ReportType.GetConstructor(Type.EmptyTypes).Invoke(New Object() {}), Telerik.Reporting.Report)
        Else
            Return Nothing
        End If

    End Function
    'Public Property ReportName1 As String
    '    Get

    '    End Get
    '    Protected Set(value As String)

    '    End Set
    'End Property

End Class

Public Interface IEasyGestReport

    Sub Configurar()

End Interface