Imports Escola.Models

Public Class UsuarioLogado

    Public Property Id As Integer
    Public Property NomeDeUsuario As String
    Public Property EhAdmin As Boolean
    Public Property ContagemSenhaIncorreta As Integer

    Public Sub New(ByVal usuario As Usuario)
        With usuario
            Id = .Id
            NomeDeUsuario = .NomeDeUsuario
            EhAdmin = .EhAdmin
            ContagemSenhaIncorreta = .ContagemSenhaIncorreta
        End With
    End Sub

End Class
