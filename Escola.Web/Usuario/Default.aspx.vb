Imports Escola.Data

Public Class _Default3

    Inherits PaginaAutenticada

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            txtNomeDeUsuario.Text = Usuario.NomeDeUsuario
        End If

    End Sub

    Protected Sub btnSalvarAlteracoes_Click(sender As Object, e As EventArgs) Handles btnSalvarAlteracoes.Click

        Try
            Dim novoNomeDeUsuario = txtNomeDeUsuario.Text
            Dim repo As New UsuarioRepository

            repo.AtualizarDados(Usuario.NomeDeUsuario, novoNomeDeUsuario)

            Dim usuarioAtualizado = repo.BuscarPorNomeDeUsuario(novoNomeDeUsuario)

            Dim usuarioLogadoAtualizado = New UsuarioLogado With {
                .Id = usuarioAtualizado.Id,
                .NomeDeUsuario = usuarioAtualizado.NomeDeUsuario
            }

            AutenticacaoUtils.Autenticar(Session, usuarioLogadoAtualizado)

            Response.Redirect(Rotas.Usuario)
        Catch ex As UsuarioJaExisteException
            lblResultado.Text = ex.Message
        End Try

    End Sub
End Class