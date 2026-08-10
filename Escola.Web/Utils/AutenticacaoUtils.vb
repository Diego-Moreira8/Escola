Imports System.Web.SessionState

Public Class AutenticacaoUtils

    Shared ReadOnly Property ChaveDaSessao As String = "Usuario"

    Shared Function EstaAutenticado(ByVal session As HttpSessionState) As Boolean

        Return session(ChaveDaSessao) IsNot Nothing

    End Function

End Class
