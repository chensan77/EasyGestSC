Public Class EasyGestReportInfo

    Public ReadOnly Property ReportName As String
    Public ReadOnly Property ReportDescription As String
    Public ReadOnly Property Report As Telerik.Reporting.Report

    Private Sub New()

    End Sub

    Public Sub New(name As String, descrip As String, report As Telerik.Reporting.Report)
        ReportName = name
        ReportDescription = descrip
        Me.Report = report
    End Sub

    Public Function GetReportParameter(nombre As String) As Telerik.Reporting.ReportParameter

        Return Report.ReportParameters.Item(nombre)

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