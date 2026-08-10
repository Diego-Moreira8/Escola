Imports Escola.Data

Public Class Detalhes

    Inherits PaginaAutenticada

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack Then
            Return
        End If

        Dim matricula = UrlUtils.ObterMatriculaDeURL(Request)

        If matricula = Nothing Then
            Response.Redirect(Rotas.Home)
            Return
        End If

        Page.Title = $"Detalhes do Aluno | {Page.Title}"

        CarregarDetalhes(matricula)

    End Sub

    Sub CarregarDetalhes(ByVal matricula As Integer)

        Dim repo As New AlunoRepository()
        Dim aluno = repo.BuscarPorMatricula(matricula)

        If aluno Is Nothing Then
            pnlDetalhes.Visible = False
            lblErro.Text = $"Matrícula {matricula} não existe!"
            Return
        End If

        lblNome.Text = aluno.Nome
        lblDtNascimento.Text = aluno.DataNascimento.ToShortDateString()

        lnkEditar.NavigateUrl = Rotas.EditarAluno(matricula)
        lnkApagar.NavigateUrl = Rotas.ApagarAluno(matricula)

    End Sub

End Class