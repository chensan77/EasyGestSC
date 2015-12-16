
Namespace Presentacion.Formulario
    Public Class frmInformes

        Private Sub frmInformes_Load(sender As Object, e As EventArgs) Handles Me.Load
            ReportViewer1.RefreshReport()

        End Sub

        Private Sub ReportViewer1_Print(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ReportViewer1.Print
            'ReportViewer1.ParametersAreaVisible
        End Sub
    End Class
End Namespace