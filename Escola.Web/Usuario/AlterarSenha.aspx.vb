Imports Escola.Data

Public Class AlterarSenha

    Inherits PaginaAutenticada

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnEnviarAlteracao_Click(sender As Object, e As EventArgs) Handles btnEnviarAlteracao.Click

        Dim repo As New UsuarioRepository

        Dim senhaAtual = txtSenhaAtual.Text
        Dim novaSenha = txtNovaSenha.Text
        Dim confirmacaoDeSenha = txtNovaSenhaConfirmacao.Text

        If Not repo.SenhaCoincide(Usuario.NomeDeUsuario, senhaAtual) Then
            lblResultado.Text = "A senha atual informada está incorreta"
            Return
        End If

        If novaSenha <> confirmacaoDeSenha Then
            lblResultado.Text = "As senhas não coincidem"
            Return
        End If

        repo.AtualizarSenha(Usuario.NomeDeUsuario, txtNovaSenha.Text)

        Response.Redirect(Rotas.Usuario)

    End Sub

End Class