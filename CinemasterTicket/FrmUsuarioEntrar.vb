Public Class FrmUsuarioEntrar

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click

        If TxtUsuario.Text = "" Or TxtSenha.Text = "" Then
            MsgBox("Preencha ambos os campos para prosseguir.", vbOKOnly + vbCritical, "Campos inválidos")

        Else
            Try
                Sql = "select nome from usuarios u where (u.usuario = '" _
                        & TxtUsuario.Text & "' or u.email = '" & TxtUsuario.Text _
                        & "') and u.senha = '" & TxtSenha.Text & "'"
                Rs = Db.Execute(Sql)

                If Rs.EOF = False Then
                    TxtSenha.Text = ""
                    UsuarioNome = Rs.Fields(0).Value

                    If TxtUsuario.Text = "admin" Then
                        Admin = True
                    Else
                        Admin = False
                    End If

                    AlternarControlesLogin(True)
                    MsgBox("Usuário autenticado com sucesso!", vbOKOnly + vbInformation, "Login bem sucedido")
                    Me.Hide()

                Else
                    MsgBox("Usuário ou senha incorretos!", vbOKOnly + vbExclamation, "Erro ao entrar")
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub FrmUsuarioEntrar_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        TxtUsuario.Select()
    End Sub
End Class