Imports Escola.Data

Public Class Apagar

    Inherits PaginaAutenticada

    Private ReadOnly Repo As New AlunoRepository
    Private ReadOnly Property Matricula As Integer
        Get
            Return UrlUtils.ObterMatriculaDeURL(Request)
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack Then
            Return
        End If

        If Matricula = Nothing Then
            Response.Redirect(Rotas.Home)
        End If

        CarregarDadosDoAluno()

    End Sub

    Protected Sub btnConfirmarRemocao_Click(sender As Object, e As EventArgs) Handles btnConfirmarRemocao.Click

        Repo.Remover(Matricula)
        Response.Redirect(Rotas.Home)

    End Sub

    Sub CarregarDadosDoAluno()

        Dim aluno = Repo.BuscarPorMatricula(Matricula)

        If aluno Is Nothing Then
            Response.Redirect(Rotas.Home)
            Return
        End If

        Page.Title = $"Apagar Aluno {aluno.Nome} | {Page.Title}"
        lblDescricao.Text = $"{aluno.Nome} ({aluno.Matricula})"
        lnkCancelar.NavigateUrl = Rotas.DetalhesAluno(Matricula)

    End Sub

End Class