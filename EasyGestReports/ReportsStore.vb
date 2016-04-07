Public Class ReportsStore

    Private Shared reports() As EasyGestReport = New EasyGestReport() _
        {
        New EasyGestReport("InformeCliente", "Informe de los clientes", New EasyGestReports.Informes.InformeCliente())
        }

    Public Shared Function GetReports() As List(Of EasyGestReport)
        Return reports.ToList()
    End Function

End Class
