Imports Escola.Models
Imports System.Security.Cryptography

Public Class UsuarioRepository

    Private Const SaltSize As Integer = 32
    Private Const HashSize As Integer = 64
    Private Const Iterations As Integer = 100_000

#Region "Create"

    Public Sub Criar(ByVal nomeDeUsuario As String, ByVal senha As String)

        Dim saltSenha = CriarSalt()
        Dim hashSenha = CriarHash(senha, saltSenha)

        Dim novoUsuario As New Usuario With {
            .NomeDeUsuario = nomeDeUsuario,
            .SaltSenha = saltSenha,
            .HashSenha = hashSenha
        }

        Using db As New EscolaEntities
            db.Usuario.Add(novoUsuario)
            db.SaveChanges()
        End Using

    End Sub

#End Region

#Region "Read"

    Public Function Existe(ByVal nomeDeUsuario As String) As Boolean

        Using db As New EscolaEntities
            Return db.Usuario.Any(Function(u) u.NomeDeUsuario = nomeDeUsuario)
        End Using

    End Function

    Public Function SenhaCoincide(ByVal nomeDeUsuario As String, ByVal senha As String) As Boolean

        Using db As New EscolaEntities
            Dim usuario = db.Usuario.FirstOrDefault(Function(u) u.NomeDeUsuario = nomeDeUsuario)

            If usuario Is Nothing Then
                Return Nothing
            End If

            Dim hashSenhaInformada = CriarHash(senha, usuario.SaltSenha)

            If hashSenhaInformada.Length <> usuario.HashSenha.Length Then
                Return False
            End If

            For i = 0 To hashSenhaInformada.Length - 1
                If hashSenhaInformada(i) <> usuario.HashSenha(i) Then
                    Return False
                End If
            Next

            Return True
        End Using

    End Function

#End Region

#Region "Update"

    Public Sub Atualizar()

        Throw New NotImplementedException

    End Sub

#End Region

#Region "Delete"

    Public Sub Remover()

        Throw New NotImplementedException

    End Sub

#End Region

#Region "Funções de Apoio"

    Private Function CriarHash(ByVal senha As String, ByVal salt As Byte()) As Byte()

        Using pbkdf2 As New Rfc2898DeriveBytes(senha, salt, Iterations)
            Return pbkdf2.GetBytes(HashSize)
        End Using

    End Function

    Private Function CriarSalt() As Byte()

        Dim salt(SaltSize - 1) As Byte

        Using rng = RandomNumberGenerator.Create()
            rng.GetBytes(salt)
        End Using

        Return salt

    End Function

#End Region

End Class
