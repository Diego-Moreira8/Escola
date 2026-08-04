Imports Escola.Data

Public Class Cadastro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Page.Title = $"Cadastro | {Page.Title}"

    End Sub

    Protected Sub btnSalvarNovoAluno_Click(sender As Object, e As EventArgs) Handles btnSalvarNovoAluno.Click

        Dim repo As New AlunoRepository

        repo.Criar(
            ucAlunoFormNovo.Nome,
            ucAlunoFormNovo.DataNascimento
        )

        Response.Redirect("~/Default.aspx")

    End Sub

End Class