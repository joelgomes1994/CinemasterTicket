Public Class FrmPrincipal

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If MsgBox("Tem certeza que quer sair do aplicativo?", vbYesNo + vbQuestion, "Sair do aplicativo") = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        If MsgBox("Tem certeza que quer encerrar a sessão atual?", vbYesNo + vbQuestion, "Encerrar sessão") = vbYes Then
            Admin = False
            UsuarioNome = ""
            AlternarControlesLogin(False)
        End If
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
        FrmUsuarioEntrar.ShowDialog()
        FrmUsuarioEntrar.Select()
    End Sub

    Private Sub EntrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntrarToolStripMenuItem.Click
        FrmUsuarioEntrar.ShowDialog()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        FrmAjudaSobre.ShowDialog()
    End Sub

    Private Sub ComprarIngressosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprarIngressosToolStripMenuItem.Click
        FrmIngressoComprar.ShowDialog()
    End Sub

    Private Sub VerSalasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerSalasToolStripMenuItem.Click
        FrmSalas.ShowDialog()
    End Sub

    Private Sub VerFilmesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerFilmesToolStripMenuItem.Click
        FrmFilmes.ShowDialog()
    End Sub

    Private Sub VerSessõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerSessõesToolStripMenuItem.Click
        FrmSessoes.ShowDialog()
    End Sub

    Private Sub HistóricoDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistóricoDeComprasToolStripMenuItem.Click
        FrmHistorico.ShowDialog()
    End Sub
End Class
