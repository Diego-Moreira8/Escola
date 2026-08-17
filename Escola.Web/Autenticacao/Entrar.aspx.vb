Imports Escola.Data

Public Class Entrar

    Inherits PaginaBase

    Private Property Repo As UsuarioRepository = New UsuarioRepository

    Protected Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        If Not Page.IsValid Then
            Return
        End If

        Dim usuario = Repo.BuscarPorNomeDeUsuario(txtNomeDeUsuario.Text)
        Dim usuarioLogado = New UsuarioLogado With {.Id = usuario.Id, .NomeDeUsuario = usuario.NomeDeUsuario}

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

        args.IsValid = Repo.SenhaCoincide(txtNomeDeUsuario.Text, args.Value)

    End Sub

End Class