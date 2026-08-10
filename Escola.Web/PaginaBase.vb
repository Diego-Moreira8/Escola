Public Class PaginaBase

    Inherits System.Web.UI.Page

    Protected ReadOnly Property Autenticado As Boolean
        Get
            Return AutenticacaoUtils.EstaAutenticado(Session)
        End Get
    End Property

    Protected Overrides Sub OnLoad(e As EventArgs)

        RedirecionarUsuarioJaAutenticado()

        MyBase.OnLoad(e)

    End Sub

    Private Sub RedirecionarUsuarioJaAutenticado()

        Dim naRotaDeAutenticacao = Request.Url.Segments(1) = "Autenticacao/"

        If Autenticado And naRotaDeAutenticacao Then
            Response.Redirect(Rotas.Home)
            Return
        End If

    End Sub

End Class
