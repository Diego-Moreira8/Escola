
Imports Escola.Data

Public Class Global_asax

    Inherits HttpApplication

    ' Permite que o desenvolvedor consiga fazer logout
    Private Property TentouLogarComUsuarioTeste As Boolean = False

    Sub Application_Start(sender As Object, e As EventArgs)

    End Sub

    Private Sub Session_Start(sender As Object, e As EventArgs)

        LogarComUsuarioTeste()

    End Sub

    Private Sub LogarComUsuarioTeste()

        If Not TentouLogarComUsuarioTeste AndAlso Ambiente.EhDesenvolvimento Then
            TentouLogarComUsuarioTeste = True

            Try
                Dim repo = New UsuarioRepository
                Dim usuarioTeste = repo.BuscarPorNomeDeUsuario(ConfigurationManager.AppSettings("UsuarioTeste"))
                Dim usuarioLogado = New UsuarioLogado(usuarioTeste)

                AutenticacaoUtils.Autenticar(Session, usuarioLogado)
            Catch ex As Exception
                Debug.WriteLine("Erro ao tentar autenticar com usuário configurado.")
                Debug.WriteLine(ex)
            End Try
        End If

    End Sub

End Class