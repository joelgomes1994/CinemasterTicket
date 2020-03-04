Module Modulo
    Public Db As New ADODB.Connection ' Variável do banco
    Public Rs As New ADODB.Recordset ' Variável da tabela
    Public Diretorio, Sql, Aux, Resp As String ' Query da tabela
    Public Conexao = Application.StartupPath & "\banco\cinemaster.mdb"
    Public Admin As Boolean
    Public UsuarioNome As String
    Public PrecoIngresso, TipoIngresso As Double

    Sub ConectarBanco()
        Try
            Db = CreateObject("ADODB.Connection") ' String de conexão com o Access
            Db.Open("Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & Conexao)
        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco de dados!", vbCritical + vbOKOnly, "Erro")
        End Try
    End Sub

    Sub AlternarControlesLogin(ByVal Ativar As Boolean)

        Dim AtivarLocal As Boolean

        With FrmPrincipal
            .EntrarToolStripMenuItem.Enabled = Not (Ativar)
            .EncerrarSessãoToolStripMenuItem.Enabled = Ativar
            .ServiçosToolStripMenuItem.Enabled = Ativar

            If Admin Then
                AtivarLocal = True
            Else
                AtivarLocal = False
            End If

            .VerFilmesToolStripMenuItem.Enabled = AtivarLocal
            .VerSalasToolStripMenuItem.Enabled = AtivarLocal
            .VerSessõesToolStripMenuItem.Enabled = AtivarLocal
            .HistóricoDeComprasToolStripMenuItem.Enabled = AtivarLocal

            If UsuarioNome <> "" Then
                .Text = "Cinemaster Ticket (" & UsuarioNome & ")"
            Else
                .Text = "Cinemaster Ticket"
            End If
        End With
    End Sub

End Module
