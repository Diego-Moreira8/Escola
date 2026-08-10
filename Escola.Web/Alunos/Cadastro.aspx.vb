Imports Escola.Data

Public Class Cadastro

    Inherits PaginaAutenticada

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Page.Title = $"Cadastro | {Page.Title}"

    End Sub

    Protected Sub btnSalvarNovoAluno_Click(sender As Object, e As EventArgs) Handles btnSalvarNovoAluno.Click

        Dim repo As New AlunoRepository

        repo.Criar(
            ucAlunoFormNovo.Nome,
            ucAlunoFormNovo.DataNascimento
        )

        Response.Redirect(Rotas.Home)

    End Sub

End Class