Imports Escola.Data

Public Class Entrar

    Inherits PaginaBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack Then
            pnlErro.Visible = False
            lblErro.Text = String.Empty
        End If

    End Sub

    Protected Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        Dim repo As New UsuarioRepository

        Dim usuario = repo.BuscarPorNomeDeUsuario(txtNomeDeUsuario.Text)

        If usuario Is Nothing Then
            pnlErro.Visible = True
            lblErro.Text = "Nome de usuário não encontrado!"
            Return
        End If

        If Not repo.SenhaCoincide(usuario.NomeDeUsuario, txtSenha.Text) Then
            pnlErro.Visible = True
            lblErro.Text = "Senha incorreta!"
            Return
        End If

        Dim usuarioLogado = New UsuarioLogado With {.Id = usuario.Id, .NomeDeUsuario = usuario.NomeDeUsuario}

        AutenticacaoUtils.Autenticar(Session, usuarioLogado)

        Response.Redirect(Rotas.Home)

    End Sub

End Class