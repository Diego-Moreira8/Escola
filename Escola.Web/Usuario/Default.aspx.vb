Imports Escola.Data

Public Class _Default3

    Inherits PaginaAutenticada

    Private Property Repo As UsuarioRepository = New UsuarioRepository

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            txtNomeDeUsuario.Text = Usuario.NomeDeUsuario
        End If

        lblSucesso.Visible = False

    End Sub

    Protected Sub btnSalvarAlteracoes_Click(sender As Object, e As EventArgs) Handles btnSalvarAlteracoes.Click

        If Not Page.IsValid Then
            Return
        End If

        Dim novoNomeDeUsuario = txtNomeDeUsuario.Text

        Repo.AtualizarDados(Usuario.NomeDeUsuario, novoNomeDeUsuario)

        Reautenticar(novoNomeDeUsuario)

        AtualizarTextoDoLinkParaUsuario()

        lblSucesso.Visible = True

    End Sub

    Private Sub valNomeDeUsuarioExistente_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles valNomeDeUsuarioExistente.ServerValidate

        Dim nenhumaAlteracao = Usuario.NomeDeUsuario = args.Value

        If nenhumaAlteracao Then
            Return
        End If

        args.IsValid = Not Repo.Existe(args.Value)

    End Sub

    Private Sub AtualizarTextoDoLinkParaUsuario()

        Dim site = DirectCast(Master, Site1)
        site.TextoLinkUsuario = Usuario.NomeDeUsuario

    End Sub

    Private Sub Reautenticar(novoNomeDeUsuario As String)

        Dim usuarioAtualizado = Repo.BuscarPorNomeDeUsuario(novoNomeDeUsuario)
        Dim usuarioLogadoAtualizado = New UsuarioLogado(usuarioAtualizado)

        AutenticacaoUtils.Autenticar(Session, usuarioLogadoAtualizado)

    End Sub

End Class