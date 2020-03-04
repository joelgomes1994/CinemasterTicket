Public Class FrmSessoes
    Private Sub FrmSessoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DgSessoes.Rows.Clear()

            Sql = "select se.id, format(se.horario, 'Short Time'), sa.nome, fi.titulo, 'R$ ' & se.preco " &
                "from (sessoes se inner join filmes fi on se.filme = fi.id) " &
                "inner join salas sa on se.sala = sa.id " &
                "order by sa.nome, se.horario"
            Rs = Db.Execute(Sql)

            Do While Rs.EOF = False
                DgSessoes.Rows.Add(Rs.Fields(0).Value, Rs.Fields(1).Value, Rs.Fields(2).Value, Rs.Fields(3).Value, Rs.Fields(4).Value)
                Rs.MoveNext()
            Loop

        Catch ex As Exception
            DgSessoes.Rows.Add("", "Não foi possível obter os dados")
        End Try
    End Sub
End Class