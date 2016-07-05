Public Class ReportsStore

    Private Shared reports() As EasyGestReportInfo = New EasyGestReportInfo() _
        {
        New EasyGestReportInfo("Cliente", "InformeCliente", "Informe de los clientes", GetType(EasyGestReports.Informes.InformeCliente))
        }

    Public Shared Function GetReports() As List(Of EasyGestReportInfo)
        Return reports.ToList()
    End Function

    Public Shared Function GetReports(Categoria As String) As List(Of EasyGestReportInfo)
        Dim reportscategoria As IEnumerable(Of EasyGestReportInfo)
        reportscategoria = From s As EasyGestReportInfo In reports Where s.ReportCategory.Equals(Categoria)
        Return reportscategoria.ToList()
    End Function

    Public Shared Function GetReport(nombre As String) As Telerik.Reporting.Report
        Dim report As Telerik.Reporting.Report = Nothing
        Return report
    End Function

End Class
