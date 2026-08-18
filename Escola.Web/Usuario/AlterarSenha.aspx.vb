Imports Escola.Data

Public Class AlterarSenha

    Inherits PaginaAutenticada

    Private Property Repo As UsuarioRepository = New UsuarioRepository

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblSucesso.Visible = False

    End Sub

    Protected Sub btnEnviarAlteracao_Click(sender As Object, e As EventArgs) Handles btnEnviarAlteracao.Click

        If Not Page.IsValid Then
            Return
        End If

        Repo.AtualizarSenha(Usuario.NomeDeUsuario, txtNovaSenha.Text)

        lblSucesso.Visible = True

    End Sub

    Private Sub valSenhaAtualCorreta_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles valSenhaAtualCorreta.ServerValidate

        args.IsValid = Repo.SenhaCoincide(Usuario.NomeDeUsuario, args.Value)

    End Sub

    Private Sub valSenhasCoincidem_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles valSenhasCoincidem.ServerValidate

        args.IsValid = txtNovaSenha.Text = args.Value

    End Sub

End Class