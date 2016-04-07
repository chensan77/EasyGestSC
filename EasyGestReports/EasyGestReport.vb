Public Class EasyGestReport

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

    'Public Property ReportName1 As String
    '    Get

    '    End Get
    '    Protected Set(value As String)

    '    End Set
    'End Property

End Class
