Public Class ReportsStore

    Private Shared reports() As EasyGestReportInfo = New EasyGestReportInfo() _
        {
        New EasyGestReportInfo("InformeCliente", "Informe de los clientes", New EasyGestReports.Informes.InformeCliente())
        }

    Public Shared Function GetReports() As List(Of EasyGestReportInfo)
        Return reports.ToList()
    End Function

    Public Shared Function GetReport(nombre As String) As EasyGestReportInfo
        Dim iter As IEnumerator = reports.GetEnumerator
        Dim report As EasyGestReportInfo = Nothing
        While iter.MoveNext
            If DirectCast(iter.Current, EasyGestReportInfo).ReportName.Equals(nombre, StringComparison.OrdinalIgnoreCase) Then
                report = DirectCast(iter.Current, EasyGestReportInfo)
                Exit While
            End If
        End While
        Return report
    End Function

End Class
