Imports Escola.Data

Public Class _Default1

    Inherits PaginaAutenticada

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack Then
            Return
        End If

        Dim repo As New AlunoRepository

        gdvAlunos.DataSource = repo.BuscarTodos()
        gdvAlunos.DataBind()

        Page.Title = $"Lista de Alunos | {Page.Title}"

    End Sub

End Class