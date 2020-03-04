Public Class FrmIngressoComprar

    Sub AtualizarPrecoTotal()
        TxtTotal.Text = PrecoIngresso / TipoIngresso
    End Sub

    Sub AtualizarDgAssentos()
        Dim Cadeira, CadeiraOcupada As Image
        Dim Branco As Image
        Dim Cont As Integer

        Cadeira = Image.FromFile("icones\Cadeira.png")
        CadeiraOcupada = Image.FromFile("icones\CadeiraOcupada.png")
        Branco = Image.FromFile("icones\Branco.png")

        DgSalaAssentos.Rows.Clear()

        For Cont = 1 To 15 Step 1
            If Cont < 8 Then
                DgSalaAssentos.Rows.Add(Cont, Cadeira, Cadeira, Cadeira, Cadeira, Cadeira, "", Cadeira, Cadeira, Cadeira, Cadeira, Cadeira)
            ElseIf Cont = 8 Then
                DgSalaAssentos.Rows.Add("", Branco, Branco, Branco, Branco, Branco, "", Branco, Branco, Branco, Branco, Branco)
            Else
                DgSalaAssentos.Rows.Add(Cont - 1, Cadeira, Cadeira, Cadeira, Cadeira, Cadeira, "", Cadeira, Cadeira, Cadeira, Cadeira, Cadeira)
            End If
        Next

        Sql = "select c.assentocoluna, c.assentolinha from (compras c " &
            "inner join sessoes se on se.id = c.sessao) " &
            "inner join salas sa on sa.id = se.sala " &
            "where sa.nome = '" & CmbSala.Text & "' and format(se.horario, 'Short Time') = '" & CmbSessao.Text & "' "
        Rs = Db.Execute(Sql)

        Do While Rs.EOF = False
            With DgSalaAssentos.Rows(CInt(Rs(1).Value)).Cells(CInt(Rs(0).Value))
                .Value = CadeiraOcupada
                .ToolTipText = "Indisponível"
            End With
            Rs.MoveNext()
        Loop

    End Sub

    Private Sub FrmIngressoSala_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Sql = "select * from salas s order by nome"
            Rs = Db.Execute(Sql)

            CmbSala.Items.Clear()

            Do While Rs.EOF = False
                CmbSala.Items.Add(Rs(1).Value)
                Rs.MoveNext()
            Loop

            AtualizarDgAssentos()

            CmbIngressoTipo.SelectedIndex = 0
            CmbSala.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub DgSalaAssentos_SelectionChanged(sender As Object, e As EventArgs) Handles DgSalaAssentos.SelectionChanged

        Try
            If DgSalaAssentos.CurrentCell.ColumnIndex = 0 Or DgSalaAssentos.CurrentCell.ColumnIndex = 6 Then
                DgSalaAssentos.CurrentCell = DgSalaAssentos.Rows(DgSalaAssentos.CurrentCell.RowIndex).Cells(DgSalaAssentos.CurrentCell.ColumnIndex + 1)
            End If

            If DgSalaAssentos.CurrentCell.RowIndex = 7 Then
                DgSalaAssentos.CurrentCell = DgSalaAssentos.Rows(DgSalaAssentos.CurrentCell.RowIndex - 1).Cells(DgSalaAssentos.CurrentCell.ColumnIndex)
            End If

            If DgSalaAssentos.CurrentCell.ToolTipText = "Indisponível" Then
                DgSalaAssentos.CurrentCell.Selected = False
                TxtAssento.Text = ""
            End If

            If DgSalaAssentos.CurrentCell.Selected = True Then
                TxtAssento.Text = DgSalaAssentos.Columns(DgSalaAssentos.CurrentCell.ColumnIndex).HeaderText & DgSalaAssentos.Rows(DgSalaAssentos.CurrentCell.RowIndex).Cells(0).Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmbSala_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSala.SelectedIndexChanged

        Try
            CmbSessao.Items.Clear()

            Sql = "Select format(se.horario, 'Short Time') from sessoes se " &
                "inner join salas sa on se.sala = sa.id " &
                "where sa.nome = '" & CmbSala.Text & "'" &
                "order by se.horario"
            Rs = Db.Execute(Sql)

            Do While Rs.EOF = False
                CmbSessao.Items.Add(Rs(0).Value)
                Rs.MoveNext()
            Loop

            CmbSessao.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CmbSessao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSessao.SelectedIndexChanged

        AtualizarDgAssentos()

        Try
            Sql = "select fi.titulo, fi.sinopse, fi.duracao, fi.poster, se.preco from (filmes fi  " &
                "inner join sessoes se on se.filme = fi.id) " &
                "inner join salas sa on se.sala = sa.id " &
                "where format(se.horario, 'Short Time') = '" & CmbSessao.Text & "' " &
                "and sa.nome = '" & CmbSala.Text & "'"
            Rs = Db.Execute(Sql)

            If Rs.EOF = False Then
                TxtTitulo.Text = Rs.Fields(0).Value
                TxtSinopse.Text = Rs.Fields(1).Value
                TxtDuracao.Text = Rs.Fields(2).Value
                ImgPoster.Load(Application.StartupPath & Rs.Fields(3).Value)
                Double.TryParse(Rs.Fields(4).Value, PrecoIngresso)
                AtualizarPrecoTotal()

            Else
                TxtTitulo.Text = "Título"
                TxtSinopse.Text = "Sinopse"
                TxtDuracao.Text = "000"
                ImgPoster.Load(Application.StartupPath & "\posteres\Sem Poster.png")

            End If

            DgSalaAssentos.CurrentCell.Selected = False

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CmbIngressoTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbIngressoTipo.SelectedIndexChanged
        If CmbIngressoTipo.Text = "Inteira" Then
            TipoIngresso = 1.0
        Else
            TipoIngresso = 2.0
        End If
        AtualizarPrecoTotal()
    End Sub

    Private Sub BtnComprar_Click(sender As Object, e As EventArgs) Handles BtnComprar.Click

        If TxtAssento.Text <> "" Then
            If MsgBox("Realizar a compra do ingresso?" & vbNewLine &
                      "Filme: " & TxtTitulo.Text & vbNewLine &
                      "Sessão: " & CmbSessao.Text & vbNewLine &
                      "Assento: " & TxtAssento.Text, vbYesNo + vbQuestion, "Confirmar compra") = vbYes Then

                Try
                    Sql = "insert into compras (data, sessao, assentocoluna, assentolinha, tipo, assento) " &
                                            "select now(), se.id, " & DgSalaAssentos.CurrentCell.ColumnIndex & ", " & DgSalaAssentos.CurrentCell.RowIndex & ", '" & CmbIngressoTipo.Text & "', '" & TxtAssento.Text & "' from sessoes se " &
                                            "inner join salas sa on se.sala = sa.id " &
                                            "where sa.nome = '" & CmbSala.Text & "' and format(se.horario, 'Short Time') = '" & CmbSessao.Text & "' "
                    Db.Execute(Sql)
                    MsgBox("Compra realizada com sucesso!", vbOKOnly + vbInformation, "Compra realizada")

                    AtualizarDgAssentos()
                    DgSalaAssentos.CurrentCell.Selected = False
                    TxtAssento.Text = ""
                Catch ex As Exception

                End Try
            End If
        Else
            MsgBox("Selecione um assento não ocupado!", vbOKOnly + vbExclamation, "Assento inválido")
        End If
    End Sub
End Class