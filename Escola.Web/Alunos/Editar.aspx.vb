Imports Escola.Data
Imports Escola.Models

Public Class Editar
    Inherits System.Web.UI.Page

    Dim repo As New AlunoRepository

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            CarregarAlunosNaLista()
            ExibirPainelDeEdicao(False)
        End If

        Page.Title = $"Edição | {Page.Title}"

    End Sub

    Protected Sub btnApagarAluno_Click(sender As Object, e As EventArgs) Handles btnApagarAluno.Click

        repo.Remover(CInt(ddlAlunos.SelectedValue))

        Response.Redirect("~/Default.aspx")

    End Sub

    Protected Sub btnSalvarAlteracoes_Click(sender As Object, e As EventArgs) Handles btnSalvarAlteracoes.Click

        repo.Atualizar(
            CInt(ddlAlunos.SelectedValue),
            ucAlunoFormEditar.Nome,
            ucAlunoFormEditar.DataNascimento
        )

        Response.Redirect("~/Default.aspx")

    End Sub

    Protected Sub ddlAlunos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlAlunos.SelectedIndexChanged

        CarregarPainelDeEdicao()

    End Sub



    Sub CarregarAlunosNaLista()

        ddlAlunos.DataSource = repo.BuscarTodos()
        ddlAlunos.DataValueField = "Matricula"
        ddlAlunos.DataTextField = "Nome"
        ddlAlunos.DataBind()

        ddlAlunos.Items.Insert(0, New ListItem("-- Selecione um(a) aluno(a) --", String.Empty))

    End Sub

    Sub CarregarDadosDoAlunoNoForm()
        Dim aluno = repo.BuscarPorMatricula(CInt(ddlAlunos.SelectedValue))

        ucAlunoFormEditar.Nome = aluno.Nome
        ucAlunoFormEditar.DataNascimento = aluno.DataNascimento
    End Sub

    Sub CarregarPainelDeEdicao()

        Dim alunoFoiSelecionado As Boolean = Not String.IsNullOrEmpty(ddlAlunos.SelectedValue)

        ExibirPainelDeEdicao(alunoFoiSelecionado)

        If alunoFoiSelecionado Then
            CarregarDadosDoAlunoNoForm()
        End If

    End Sub

    Sub ExibirPainelDeEdicao(ByVal exibir As Boolean)

        pnlEdicao.Visible = exibir

    End Sub

End Class