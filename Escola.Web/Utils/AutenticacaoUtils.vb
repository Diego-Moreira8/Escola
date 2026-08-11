Imports System.Web.SessionState

Public Class AutenticacaoUtils

    Private Const ChaveDaSessao As String = "Usuario"

    Public Shared ReadOnly Property Usuario(ByVal session As HttpSessionState) As UsuarioLogado
        Get
            Return TryCast(session(ChaveDaSessao), UsuarioLogado)
        End Get
    End Property

    Public Shared Function EstaAutenticado(ByVal session As HttpSessionState) As Boolean

        Return Usuario(session) IsNot Nothing

    End Function

    Public Shared Sub Autenticar(ByVal session As HttpSessionState, ByVal usuarioLogado As UsuarioLogado)

        session(ChaveDaSessao) = usuarioLogado

    End Sub

    Public Shared Sub Sair(ByVal session As HttpSessionState)

        session.Clear()
        session.Abandon()

    End Sub

End Class
