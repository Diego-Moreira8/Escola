Imports Escola.Models

Public Class UsuarioRepository

#Region "Create"

    Public Sub Criar(ByVal nomeDeUsuario As String, ByVal senha As String)

        Dim novoUsuario As New Usuario With {
            .NomeDeUsuario = nomeDeUsuario,
            .Senha = senha
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

            If senha <> usuario.Senha Then
                Return False
            End If

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

End Class
