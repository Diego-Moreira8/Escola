Public Class Site1

    Inherits System.Web.UI.MasterPage

    Public Property TextoLinkUsuario As String
        Get
            Return lnkNomeDeUsuario.Text
        End Get
        Set(value As String)
            lnkNomeDeUsuario.Text = value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If AutenticacaoUtils.EstaAutenticado(Session) Then
            pnlInfoDoUsuario.Visible = True
            TextoLinkUsuario = AutenticacaoUtils.Usuario(Session).NomeDeUsuario
        End If

    End Sub

    Protected Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        AutenticacaoUtils.Sair(Session)
        Response.Redirect(Rotas.Entrar)

    End Sub
End Class