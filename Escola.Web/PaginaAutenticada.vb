Public Class PaginaAutenticada

    Inherits PaginaBase

    Protected ReadOnly Property Usuario As UsuarioLogado
        Get
            Return AutenticacaoUtils.Usuario(Session)
        End Get
    End Property


    Protected Overrides Sub OnLoad(e As EventArgs)

        RedirecionaUsuarioNaoAutenticado()

        MyBase.OnLoad(e)

    End Sub

    Private Sub RedirecionaUsuarioNaoAutenticado()

        Dim naRotaDeAutenticacao = Request.Url.Segments(1) = "Autenticacao/"

        If Not Autenticado And Not naRotaDeAutenticacao Then
            Response.Redirect(Rotas.Entrar)
            Return
        End If

    End Sub

End Class
