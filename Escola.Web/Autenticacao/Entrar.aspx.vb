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

        If Not repo.Existe(txtNomeDeUsuario.Text) Then
            pnlErro.Visible = True
            lblErro.Text = "Nome de usuário não encontrado!"
            Return
        End If

        If Not repo.SenhaCoincide(txtNomeDeUsuario.Text, txtSenha.Text) Then
            pnlErro.Visible = True
            lblErro.Text = "Senha incorreta!"
            Return
        End If

        Session(AutenticacaoUtils.ChaveDaSessao) = txtNomeDeUsuario.Text

        Response.Redirect(Rotas.Home)

    End Sub

End Class