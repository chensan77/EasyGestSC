
Namespace Presentacion.Formulario.Configuracion

    Public Class frmConfiguracion


        Private Sub ibtneUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ibtneUsuario.Click
            Dim frm As New frmUsuario(True)
            frm.ShowDialog(Me)
        End Sub

        Private Sub ibtneEmpresa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ibtneEmpresa.Click
            Dim frm As New frmEmpresa(True)
            frm.ShowDialog(Me)
        End Sub

        Private Sub ibtneParametro_Click(sender As Object, e As System.EventArgs) Handles ibtneParametro.Click
            Dim frm As New frmParametroApp()
            frm.ShowDialog(Me)
        End Sub

        Private Sub ibtneProducto_Click(sender As Object, e As System.EventArgs) Handles ibtneProducto.Click
            Dim frm As New frmAuxiliarProducto()
            frm.ShowDialog(Me)
        End Sub

        Private Sub ibtnePuesto_Click(sender As Object, e As System.EventArgs) Handles ibtnePuesto.Click
            Dim frm As New frmPuesto()
            frm.ShowDialog(Me)
        End Sub

        Private Sub ibtneImpuesto_Click(sender As Object, e As System.EventArgs) Handles ibtneImpuesto.Click
            Dim frm As New frmImpuesto()
            frm.ShowDialog(Me)
        End Sub

        Private Sub ibtneEtiqueta_Click(sender As Object, e As System.EventArgs) Handles ibtneEtiqueta.Click
            Dim frm As New frmEtiqueta()
            frm.ShowDialog(Me)
        End Sub

        Private Sub ibtneOferta_Click(sender As Object, e As System.EventArgs) Handles ibtneOferta.Click
            Dim frm As New frmOferta()
            frm.ShowDialog(Me)
        End Sub

        Private Sub ibtne_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ibtneUsuario.MouseEnter, ibtnePuesto.MouseEnter, ibtneProducto.MouseEnter, ibtneParametro.MouseEnter, ibtneImpuesto.MouseEnter, ibtneEtiqueta.MouseEnter, ibtneEmpresa.MouseEnter, ibtneOferta.MouseEnter
            Dim ibtn As RadImageButtonElement = DirectCast(sender, RadImageButtonElement)
            ibtn.ShowBorder = True
            Me.Cursor = Cursors.Hand
        End Sub

        Private Sub frmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim colorborder As Color = Color.FromArgb(152, 230, 115)
            For Each btn As RadImageButtonElement In crsConfiguracion.Items
                btn.ShowBorder = False
                btn.BorderThickness = New Padding(2)
                btn.Padding = New Padding(3)
                btn.BorderElement.ForeColor = colorborder
                btn.Shape = RoundRectShape1
                btn.Font = New Font(gDefaultFont.FontFamily.Name, 14.25)
            Next
        End Sub

        Private Sub ibtne_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ibtneUsuario.MouseLeave, ibtnePuesto.MouseLeave, ibtneProducto.MouseLeave, ibtneParametro.MouseLeave, ibtneImpuesto.MouseLeave, ibtneEtiqueta.MouseLeave, ibtneEmpresa.MouseLeave, ibtneOferta.MouseLeave
            Dim ibtn As RadImageButtonElement = DirectCast(sender, RadImageButtonElement)
            ibtn.ShowBorder = False
            Me.Cursor = Cursors.Default
        End Sub

    End Class

End Namespace