Imports Escola.Data

Public Class Registrar

    Inherits PaginaAutenticada

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack Then
            pnlErro.Visible = False
            lblErro.Text = String.Empty
        End If

    End Sub

    Protected Sub btnCriarConta_Click(sender As Object, e As EventArgs) Handles btnCriarConta.Click

        Dim repo = New UsuarioRepository

        If Not FormularioValido(repo) Then
            Return
        End If

        repo.Criar(txtNomeDeUsuario.Text, txtSenha.Text)

        Response.Redirect(Rotas.Entrar)

    End Sub

    Private Function FormularioValido(ByVal repo As UsuarioRepository) As Boolean

        Dim nomeDeUsuarioVazio = String.IsNullOrWhiteSpace(txtNomeDeUsuario.Text)
        Dim senhaVazia = String.IsNullOrWhiteSpace(txtSenha.Text)
        Dim senhasCoincidem = txtSenha.Text.Equals(txtConfirmarSenha.Text)

        If nomeDeUsuarioVazio Then
            pnlErro.Visible = True
            lblErro.Text = "Nome de usuário não pode ficar em branco!"
            Return False
        End If

        If senhaVazia Then
            pnlErro.Visible = True
            lblErro.Text = "Senha não pode ficar em branco!"
            Return False
        End If

        If Not senhasCoincidem Then
            pnlErro.Visible = True
            lblErro.Text = "As senhas não batem!"
            Return False
        End If

        If repo.Existe(txtNomeDeUsuario.Text) Then
            pnlErro.Visible = True
            lblErro.Text = "O nome de usuário já existe!"
            Return False
        End If

        Return True

    End Function

End Class