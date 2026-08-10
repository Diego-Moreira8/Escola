Imports Escola.Models

Public Class AlunoRepository

#Region "Create"

    Public Sub Criar(ByVal nome As String, ByVal dataNascimento As Date)

        Dim novoAluno As New Aluno With {
            .Nome = nome,
            .DataNascimento = dataNascimento
        }

        Using db As New EscolaEntities
            db.Aluno.Add(novoAluno)
            db.SaveChanges()
        End Using

    End Sub

#End Region

#Region "Read"

    Public Function BuscarTodos() As List(Of Aluno)

        Using db As New EscolaEntities
            Dim queryTodosAlunos = From a In db.Aluno.AsNoTracking()
                                   Order By a.Nome, a.Matricula
                                   Select a

            Return queryTodosAlunos.ToList()
        End Using

    End Function

    Public Function BuscarPorMatricula(ByVal numMatricula As Integer) As Aluno

        Using db As New EscolaEntities
            Return db.Aluno.Find(numMatricula)
        End Using

    End Function

#End Region

#Region "Update"

    Public Sub Atualizar(ByVal numMatricula As Integer, ByVal nome As String, ByVal dataNasc As Date)

        Using db As New EscolaEntities
            Dim aluno = db.Aluno.Find(numMatricula)

            aluno.Nome = nome
            aluno.DataNascimento = dataNasc

            db.SaveChanges()
        End Using

    End Sub

#End Region

#Region "Delete"

    Public Sub Remover(ByVal matricula As Integer)

        Using db As New EscolaEntities
            Dim aluno = db.Aluno.Find(matricula)

            db.Aluno.Remove(aluno)
            db.SaveChanges()
        End Using

    End Sub

#End Region

End Class
