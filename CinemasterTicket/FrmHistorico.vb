Public Class FrmHistorico
    Private Sub FrmHistorico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DgHistorico.Rows.Clear()

            Sql = "select c.id, c.data, format(se.horario, 'Short Time'), fi.titulo, c.assento, c.tipo " &
                "from (compras c inner join sessoes se on c.sessao = se.id)" &
                "inner join filmes fi on se.filme = fi.id order by c.data"
            Rs = Db.Execute(Sql)

            Do While Rs.EOF = False
                DgHistorico.Rows.Add(Rs.Fields(0).Value, Rs.Fields(1).Value, Rs.Fields(2).Value, Rs.Fields(3).Value, Rs.Fields(4).Value, Rs.Fields(5).Value)
                Rs.MoveNext()
            Loop

        Catch ex As Exception
            DgHistorico.Rows.Add("", "Não foi possível obter os dados")
        End Try
    End Sub
End Class