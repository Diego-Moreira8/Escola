Public Class Rotas

    Public Shared ReadOnly Property Home As String
        Get
            Return "~/Default.aspx"
        End Get
    End Property

    Public Shared ReadOnly Property Entrar As String
        Get
            Return "~/Autenticacao/Entrar.aspx"
        End Get
    End Property

    Public Shared ReadOnly Property Registrar As String
        Get
            Return "~/Autenticacao/Registrar.aspx"
        End Get
    End Property

    Public Shared ReadOnly Property ListaDeAlunos As String
        Get
            Return "~/Alunos/Default.aspx"
        End Get
    End Property

    Public Shared ReadOnly Property Cadastro As String
        Get
            Return "~/Alunos/Cadastro.aspx"
        End Get
    End Property

    Public Shared Function DetalhesAluno(matricula As Integer) As String
        Return $"~/Alunos/Detalhes.aspx?matricula={matricula}"
    End Function

    Public Shared Function EditarAluno(matricula As Integer) As String
        Return $"~/Alunos/Editar.aspx?matricula={matricula}"
    End Function

    Public Shared Function ApagarAluno(matricula As Integer) As String
        Return $"~/Alunos/Apagar.aspx?matricula={matricula}"
    End Function

End Class
