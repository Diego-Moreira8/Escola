Imports Escola.Data

Public Class Entrar

    Inherits PaginaBase

    Private Property Repo As UsuarioRepository = New UsuarioRepository

    Protected Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        If Not Page.IsValid Then
            Return
        End If

        Repo.RedefinirContagemSenhaIncorreta(txtNomeDeUsuario.Text)

        Dim usuario = Repo.BuscarPorNomeDeUsuario(txtNomeDeUsuario.Text)
        Dim usuarioLogado = New UsuarioLogado(usuario)

        AutenticacaoUtils.Autenticar(Session, usuarioLogado)

        Response.Redirect(Rotas.Home)

    End Sub

    Private Sub valNomeDeUsuarioExiste_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles valNomeDeUsuarioExiste.ServerValidate

        args.IsValid = Repo.Existe(args.Value)

    End Sub

    Private Sub valSenhaCorreta_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles valSenhaCorreta.ServerValidate

        ' Pula a verificação caso o nome de usuário informado não exista
        If Not valNomeDeUsuarioExiste.IsValid Then
            Return
        End If

        Dim limiteSenhaIncorreta = CInt(ConfigurationManager.AppSettings("LimiteSenhaIncorreta"))
        Dim contagemSenhaIncorreta = Repo.BuscarContagemSenhaIncorreta(txtNomeDeUsuario.Text)
        Dim usuarioBloqueado = contagemSenhaIncorreta >= limiteSenhaIncorreta

        If usuarioBloqueado Then
            valSenhaCorreta.ErrorMessage = "Usuário bloqueado. Contate um administrador do sistema."
            args.IsValid = False
            Return
        End If

        Dim senhaCorreta = Repo.SenhaCoincide(txtNomeDeUsuario.Text, args.Value)

        If Not senhaCorreta Then
            contagemSenhaIncorreta = Repo.IncrementarContagemSenhaIncorreta(txtNomeDeUsuario.Text)

            Dim tentativasRestantes = limiteSenhaIncorreta - contagemSenhaIncorreta

            valSenhaCorreta.ErrorMessage = If(
                tentativasRestantes > 0,
                $"Senha incorreta. Tentativas restantes: {tentativasRestantes}",
                "Senha incorreta. Usuário bloqueado, contate um administrador do sistema."
            )

            args.IsValid = False
            Return
        End If

        args.IsValid = True

    End Sub

End Class