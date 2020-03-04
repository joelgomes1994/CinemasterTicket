Public Class FrmFilmes
    Private Sub FrmFilmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DgFilmes.Rows.Clear()

            Sql = "select * from filmes f order by titulo"
            Rs = Db.Execute(Sql)

            Do While Rs.EOF = False
                DgFilmes.Rows.Add(Rs.Fields(0).Value, Rs.Fields(1).Value, Rs.Fields(2).Value, Rs.Fields(3).Value, Rs.Fields(4).Value)
                Rs.MoveNext()
            Loop

        Catch ex As Exception
            DgFilmes.Rows.Add("", "Não foi possível obter os dados")
        End Try
    End Sub
End Class