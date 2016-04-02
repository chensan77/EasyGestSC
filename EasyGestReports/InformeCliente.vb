Partial Public Class InformeCliente
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
        EasyGestControllers.Controller.EasyGestController.ResetConnectionString("Data Source=CHENZHANG-PC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
    End Sub

    Private Sub InformeCliente_NeedDataSource(sender As Object, e As EventArgs) Handles Me.NeedDataSource
        Using c As New EasyGestControllers.Controller.VistasController(Of EasyGestControllers.Data.Entity.VWClientes)
            DSClientes.DataSource = c.GetItems()
        End Using
    End Sub
End Class