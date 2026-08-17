Imports Escola.Data

Public Class _Default1

    Inherits PaginaAutenticada

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Page.Title = $"Lista de Alunos | {Page.Title}"
        CarregarAlunos()

    End Sub

    Private Sub gdvAlunos_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles gdvAlunos.PageIndexChanging

        gdvAlunos.PageIndex = e.NewPageIndex
        CarregarAlunos()

    End Sub

    Private Sub CarregarAlunos()

        Dim repo As New AlunoRepository

        gdvAlunos.DataSource = repo.BuscarTodos()
        gdvAlunos.DataBind()

    End Sub

End Class