Public Class FrmSalas
    Private Sub FrmSalas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DgSalas.Rows.Clear()

            Sql = "select * from salas s order by nome"
            Rs = Db.Execute(Sql)

            Do While Rs.EOF = False
                DgSalas.Rows.Add(Rs.Fields(0).Value, Rs.Fields(1).Value)
                Rs.MoveNext()
            Loop

        Catch ex As Exception
            DgSalas.Rows.Add("", "Não foi possível obter os dados")
        End Try
    End Sub
End Class