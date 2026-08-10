Imports Escola.Data

Public Class _Default

    Inherits PaginaAutenticada

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Response.Redirect(Rotas.ListaDeAlunos)

    End Sub

End Class