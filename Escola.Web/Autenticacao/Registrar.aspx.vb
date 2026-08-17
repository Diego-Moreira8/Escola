Imports Escola.Data

Public Class Registrar

    Inherits PaginaAutenticada

    Private Property Repo As UsuarioRepository = New UsuarioRepository

    Protected Sub btnCriarConta_Click(sender As Object, e As EventArgs) Handles btnCriarConta.Click

        If Not Page.IsValid Then
            Return
        End If

        Repo.Criar(txtNomeDeUsuario.Text, txtSenha.Text)

        Response.Redirect(Rotas.Entrar)

    End Sub

    Private Sub valNomeDeUsuarioExistente_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles valNomeDeUsuarioExistente.ServerValidate

        args.IsValid = Not Repo.Existe(args.Value)

    End Sub

    Private Sub valConfirmarSenhaCoincide_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles valConfirmarSenhaCoincide.ServerValidate

        args.IsValid = txtSenha.Text = args.Value

    End Sub
End Class