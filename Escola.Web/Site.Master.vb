Public Class Site1

    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If AutenticacaoUtils.EstaAutenticado(Session) Then
            pnlInfoDoUsuario.Visible = True
            lnkNomeDeUsuario.Text = Session(AutenticacaoUtils.ChaveDaSessao).ToString()
        End If

    End Sub

    Protected Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Session.Clear()
        Session.Abandon()
        Response.Redirect(Rotas.Entrar)

    End Sub
End Class