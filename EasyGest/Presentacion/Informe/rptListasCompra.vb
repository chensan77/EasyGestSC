Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class rptListasCompra
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
        Using c As New ListasCompraController
            dsListasCompra.DataSource = c.GetItems()
        End Using
    End Sub

    Private Sub List2_NeedDataSource(sender As Object, e As EventArgs) Handles List2.NeedDataSource

    End Sub
End Class